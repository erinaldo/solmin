Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.Utilitario
Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades
Imports System.IO

Public Class frmConfiguracionValorizacion
    Private oCorreoValoriz As SOLMIN_CTZ.Entidades.Valorizacion
    Private BandNew As Boolean = True
    Private gEnum_Mantenimiento As MANTENIMIENTO

    Private Sub frmConfiguracionValorizacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            UcCompania.Usuario = ConfigurationWizard.UserName
            UcCompania.pActualizar()
            UcCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
            CargaProcesoCombo()
            Me.dtgOperaciones.AutoGenerateColumns = False
            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            EstadoBoton(gEnum_Mantenimiento)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Limpiar()
            If Me.Validar_Datos_Filtro = True Then Exit Sub
            BuscarCorreosValorizacion()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BuscarCorreosValorizacion()
        Dim oCorreoValoriz As New beCorreoValorizacion
        Dim obrCorreoValoriz As New clsDestiCorreoValorizacion
        With oCorreoValoriz
          
            .CCLNT = Me.UcCliente.pCodigo

            .NLTECL = Me.cmbProceso.SelectedValue
        End With
        Limpiar()
        dtgOperaciones.DataSource = obrCorreoValoriz.ListarConfCierreValorizacion(oCorreoValoriz)

        gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        EstadoBoton(gEnum_Mantenimiento)

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim msgValidacion As String = ValidarIngreso()
            If msgValidacion.Length > 0 Then
                MessageBox.Show(msgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim oCorreoValoriz As New beCorreoValorizacion
            Dim obrCorreoValorizacion As New clsDestiCorreoValorizacion
            Dim dtTransaccion As New DataTable
            Dim sErrorMesage As String = ""
            Dim sMesageAlerta As String = ""
            Dim sStatus As String = ""

            Dim CodCliente As String
            CodCliente = Me.UcCliente_TxtF011.pCodigo


            oCorreoValoriz.CCLNT = CodCliente
            oCorreoValoriz.NLTECL = Me.cmbProceso.SelectedValue
            oCorreoValoriz.EMAILTO = txtCorreo.Text
            oCorreoValoriz.TNMYAP = txtNombre.Text
            oCorreoValoriz.EMAILCC = ""
            oCorreoValoriz.EMAILBC = ""


            oCorreoValoriz.TIPPROC = Me.cmbProceso.SelectedValue

            oCorreoValoriz.CULUSA = ConfigurationWizard.UserName

            If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
                dtTransaccion = obrCorreoValorizacion.InsertarCorreoValorizacion(oCorreoValoriz)
            Else
                oCorreoValoriz.NCRRIT = dtgOperaciones.CurrentRow.Cells("NCRRIT").Value
                dtTransaccion = obrCorreoValorizacion.ActualizaCorreoValorizacion(oCorreoValoriz)
            End If

            For Each row As DataRow In dtTransaccion.Rows
                sStatus = row("STATUS").ToString.Trim
                If sStatus = "E" Then
                    sErrorMesage = sErrorMesage & row("OBSRESULT").ToString.Trim & Environment.NewLine
                End If
                If sStatus = "S" Then
                    sMesageAlerta = sMesageAlerta & row("OBSRESULT").ToString.Trim & Environment.NewLine
                End If
            Next
            sErrorMesage = sErrorMesage.Trim
            sMesageAlerta = sMesageAlerta.Trim

            If sStatus = "E" Then
                MessageBox.Show(sErrorMesage, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If sStatus = "S" Then
                MessageBox.Show(sMesageAlerta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            BuscarCorreosValorizacion()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
            EstadoBoton(gEnum_Mantenimiento)
            BandNew = True
            LimpiarTextos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            BandNew = False
            LimpiarTextos()
            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            EstadoBoton(gEnum_Mantenimiento)
            dtgOperaciones_SelectionChanged(dtgOperaciones, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
       
    End Sub

    Private Sub btnAnularCancelar_Click(sender As Object, e As EventArgs) Handles btnAnularCancelar.Click
        BandNew = False
        Try
            If dtgOperaciones.CurrentRow Is Nothing Then
                Exit Sub
            End If

            If MessageBox.Show("¿Está seguro de anular?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            Dim oCorreoValoriz As New beCorreoValorizacion
            Dim obrCorreoValoriz As New clsDestiCorreoValorizacion
            Dim dtTransaccion As New DataTable
            Dim sErrorMesage As String = ""
            Dim sErrorMesageAlerta As String = ""
            Dim sStatus As String = ""
            oCorreoValoriz.CCLNT = dtgOperaciones.CurrentRow.Cells("CCLNT").Value
            oCorreoValoriz.NLTECL = Me.cmbProceso.SelectedValue
            oCorreoValoriz.NCRRIT = dtgOperaciones.CurrentRow.Cells("NCRRIT").Value
            oCorreoValoriz.CULUSA = ConfigurationWizard.UserName
            obrCorreoValoriz.EliminarCorreoValorizacion(oCorreoValoriz)
           
           
            MessageBox.Show("Registro eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BuscarCorreosValorizacion()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Limpiar()
        Me.dtgOperaciones.DataSource = Nothing
        LimpiarTextos()
    End Sub

    Private Sub LimpiarTextos()
        txtNombre.Text = ""
        txtCorreo.Text = ""
        
    End Sub

    Private Function ValidarIngreso() As String
        Dim msg As String = ""
        txtNombre.Text = txtNombre.Text.Trim
        txtCorreo.Text = txtCorreo.Text.Trim
        Dim CodCliente As String
        CodCliente = Me.UcCliente_TxtF011.pCodigo
        If txtNombre.Text.Trim().Length = 0 Then
            msg = "* Ingrese Nombre de Contacto "
           
        ElseIf txtCorreo.Text.Trim.Length > 0 AndAlso ValidEmail(txtCorreo.Text) = False Then
            msg = msg & vbCrLf & "* Formato no válido Correo"
           
        End If
        Return msg
    End Function

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            If Me.dtgOperaciones.RowCount = 0 Then Exit Sub
            Dim dtGrid As New DataGridView
            dtGrid = Me.dtgOperaciones
            Dim strlTitulo As String
            Dim strlFiltros As New List(Of String)
            strlTitulo = "Listado Correos Valorizacion"
            
            strlFiltros.Add("Cliente : \n" & UcCliente.pRazonSocial)
            strlFiltros.Add("Tipo Proceso : \n" & cmbProceso.Text)
            Ransa.Utilitario.HelpClass.ExportExcelConTitulos(dtGrid, strlTitulo, strlFiltros)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function Validar_Datos_Filtro() As Boolean
        Dim lstr_validacion As String = ""
        Dim lbool_existe_error As Boolean = False

       
        If lstr_validacion <> "" Then
            HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & lstr_validacion)
            lbool_existe_error = True
        End If
        Return lbool_existe_error
    End Function

    Private Sub CargaProcesoCombo()
        Dim dt As New DataTable("Proceso")
        dt.Columns.Add("CodProceso")
        dt.Columns.Add("DescProceso")
        dt.Rows.Add(New Object() {"CT_VALORIZ", "Valorización"})
        cmbProceso.DataSource = dt
        cmbProceso.ValueMember = "CodProceso"
        cmbProceso.DisplayMember = "DescProceso"
    End Sub

    Private Sub EstadoBoton(ByVal op As MANTENIMIENTO)

        Dim lbool_estado As Boolean = False
        Select Case op
            Case MANTENIMIENTO.NEUTRAL
                btnNuevo.Enabled = True
                btnGuardar.Visible = False
                btnCancelar.Visible = False
                btnAnularCancelar.Enabled = True
                lbool_estado = False
                btnModificar.Enabled = True

            Case MANTENIMIENTO.EDITAR
                btnNuevo.Enabled = False
                btnGuardar.Visible = True
                btnCancelar.Visible = True
                btnAnularCancelar.Enabled = False
                lbool_estado = True
                btnModificar.Enabled = False

            Case MANTENIMIENTO.NUEVO
                btnNuevo.Enabled = False
                btnGuardar.Visible = True
                btnCancelar.Visible = True
                btnAnularCancelar.Enabled = False

               

                btnModificar.Enabled = False
                
                lbool_estado = True
        End Select

        Me.txtNombre.Enabled = lbool_estado
        Me.txtCorreo.Enabled = lbool_estado
        'Me.chkGeneral.Enabled = lbool_estado
        UcCliente_TxtF011.Enabled = lbool_estado
    End Sub

    Private Sub dtgOperaciones_SelectionChanged(sender As Object, e As EventArgs) Handles dtgOperaciones.SelectionChanged
        Try
            BandNew = False
            LimpiarTextos()
            If Me.dtgOperaciones.RowCount = 0 OrElse Me.dtgOperaciones.CurrentCellAddress.Y < 0 Then Exit Sub
            txtNombre.Text = dtgOperaciones.CurrentRow.Cells("NOMBRE").Value
            txtCorreo.Text = dtgOperaciones.CurrentRow.Cells("EMAILTO").Value
            UcCliente_TxtF011.pCargar(dtgOperaciones.CurrentRow.Cells("CCLNT").Value)
           
            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            EstadoBoton(gEnum_Mantenimiento)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     

    End Sub

    Function IsValidEmailFormat(ByVal s As String) As Boolean
        Try
            Dim a As New System.Net.Mail.MailAddress(s)
        Catch
            Return False
        End Try
        Return True
    End Function

   
    Function ValidEmail(ByVal strCheck As String) As Boolean
        Try
            Dim bCK As Boolean
            Dim strDomainType As String


            Const sInvalidChars As String = "!#$%^&*()=+{}[]|\;:'/?>,< "
            Dim i As Integer

            'Check to see if there is a double quote
            bCK = Not InStr(1, strCheck, Chr(34)) > 0
            If Not bCK Then GoTo ExitFunction

            'Check to see if there are consecutive dots
            bCK = Not InStr(1, strCheck, "..") > 0
            If Not bCK Then GoTo ExitFunction

            ' Check for invalid characters.
            If Len(strCheck) > Len(sInvalidChars) Then
                For i = 1 To Len(sInvalidChars)
                    If InStr(strCheck, Mid(sInvalidChars, i, 1)) > 0 Then
                        bCK = False
                        GoTo ExitFunction
                    End If
                Next
            Else
                For i = 1 To Len(strCheck)
                    If InStr(sInvalidChars, Mid(strCheck, i, 1)) > 0 Then
                        bCK = False
                        GoTo ExitFunction
                    End If
                Next
            End If

            If InStr(1, strCheck, "@") > 1 Then 'Check for an @ symbol
                bCK = Len(Strings.Left(strCheck, InStr(1, strCheck, "@") - 1)) > 0
            Else
                bCK = False
            End If
            If Not bCK Then GoTo ExitFunction

            strCheck = Strings.Right(strCheck, Len(strCheck) - InStr(1, strCheck, "@"))
            bCK = Not InStr(1, strCheck, "@") > 0 'Check to see if there are too many @'s
            If Not bCK Then GoTo ExitFunction

            strDomainType = Strings.Right(strCheck, Len(strCheck) - InStr(1, strCheck, "."))
            bCK = Len(strDomainType) > 0 And InStr(1, strCheck, ".") < Len(strCheck)
            If Not bCK Then GoTo ExitFunction

            strCheck = Strings.Left(strCheck, Len(strCheck) - Len(strDomainType) - 1)
            Do Until InStr(1, strCheck, ".") <= 1
                If Len(strCheck) >= InStr(1, strCheck, ".") Then
                    strCheck = Strings.Left(strCheck, Len(strCheck) - (InStr(1, strCheck, ".") - 1))
                Else
                    bCK = False
                    GoTo ExitFunction
                End If
            Loop
            If strCheck = "." Or Len(strCheck) = 0 Then bCK = False

ExitFunction:
            ValidEmail = bCK
        Catch ex As ArgumentException
            Return False
        End Try
        Return ValidEmail
    End Function

    

   

    Private Sub dtgOperaciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgOperaciones.CellContentClick

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
        EstadoBoton(gEnum_Mantenimiento)
        UcCliente_TxtF011.Enabled = False
    End Sub
End Class
