Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.Utilitario
Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades

Public Class frmAprobacionValorizacion
    Public pbeValorizacion As SOLMIN_CTZ.Entidades.beMantValorizacion
    'Private BandNew As Boolean = True
    Private gEnum_Mantenimiento As MANTENIMIENTO

    Private Sub frmProvisionDeVentas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            UcCompania.Usuario = ConfigurationWizard.UserName
            UcCompania.pActualizar()
            UcCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
            CargaEstadoCombo()
            Me.dtgOperaciones.AutoGenerateColumns = False
            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            EstadoBoton(gEnum_Mantenimiento)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            If Me.Validar_Datos_Filtro = True Then Exit Sub
            BuscarValorizacion()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BuscarValorizacion()
        Dim oValorizacion As New Valorizacion
        Dim obrConfValorizacion As New clsConfValorizacion
        With oValorizacion
            .CCMPN = Me.UcCompania.CCMPN_CodigoCompania
            .CCLNT = Me.UcCliente.pCodigo
            .SESTRG = Me.cmbEstado.SelectedValue
        End With
        Limpiar()
        dtgOperaciones.DataSource = obrConfValorizacion.ListarConfCierreValorizacion(oValorizacion)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim msgValidacion As String = ValidarIngreso()
            If msgValidacion.Length > 0 Then
                MessageBox.Show(msgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim oValorizacion As New Valorizacion
            Dim obrValorizacion As New clsConfValorizacion
            Dim dtTransaccion As New DataTable
            Dim sErrorMesage As String = ""
            Dim sMesageAlerta As String = ""
            Dim sStatus As String = ""

            With oValorizacion
                .CCMPN = Me.UcCompania.CCMPN_CodigoCompania
                .CCLNT = Me.UcCliente_TxtF011.pCodigo
                .REFCNT = Me.txtFchCorte.Text.Trim
                .QDAPVL = Me.txtTiempoAprobacion.Text.Trim
                .TOBSE1 = Me.txtObservacion.Text.Trim
                .NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                .CULUSA = ConfigurationWizard.UserName
            End With

            If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
                oValorizacion.CNFCVL = 0
                dtTransaccion = obrValorizacion.Insertar_Valorizacion(oValorizacion)
            ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
                oValorizacion.CNFCVL = dtgOperaciones.CurrentRow.Cells("CNFCVL").Value
                dtTransaccion = obrValorizacion.Actualizar_Valorizacion(oValorizacion)
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
                MessageBox.Show(sErrorMesage, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If sStatus = "S" Then
                MessageBox.Show(sMesageAlerta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            BuscarValorizacion()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
        EstadoBoton(gEnum_Mantenimiento)
        'BandNew = True
        LimpiarTextos()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'BandNew = False
        LimpiarTextos()
        gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        EstadoBoton(gEnum_Mantenimiento)
        BuscarValorizacion()
    End Sub

    Private Sub btnAnularCancelar_Click(sender As Object, e As EventArgs) Handles btnAnularCancelar.Click
        'BandNew = False
        Try
            If dtgOperaciones.CurrentRow Is Nothing Then
                Exit Sub
            End If

            Dim oValorizacion As New Valorizacion
            Dim obrValorizacion As New clsConfValorizacion
            Dim dtTransaccion As New DataTable
            Dim sErrorMesage As String = ""
            Dim sErrorMesageAlerta As String = ""
            Dim sStatus As String = ""
            'SESTRG
            Dim estado As String = dtgOperaciones.CurrentRow.Cells("SESTRG").Value.ToString.Trim
            If estado = "C" Or estado = "*" Then
                MessageBox.Show("El registro ya se encuentra cerrado/anulado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If MessageBox.Show("¿Está seguro de Cerrar/Anular?", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

            oValorizacion.CCMPN = UcCompania.CCMPN_CodigoCompania
            oValorizacion.CCLNT = dtgOperaciones.CurrentRow.Cells("CCLNT").Value
            oValorizacion.CNFCVL = dtgOperaciones.CurrentRow.Cells("CNFCVL").Value
            oValorizacion.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            oValorizacion.CULUSA = ConfigurationWizard.UserName

            dtTransaccion = obrValorizacion.AnularCerrar_Valorizacion(oValorizacion)

            For Each row As DataRow In dtTransaccion.Rows
                sStatus = row("STATUS").ToString.Trim
                If sStatus = "E" Then
                    sErrorMesage = sErrorMesage & row("OBSRESULT").ToString.Trim & Environment.NewLine
                End If
                If sStatus = "S" Then
                    sErrorMesageAlerta = sErrorMesageAlerta & row("OBSRESULT").ToString.Trim & Environment.NewLine
                End If
            Next
            sErrorMesage = sErrorMesage.Trim
            If sStatus = "E" Then MessageBox.Show(sErrorMesage, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If sStatus = "S" Then MessageBox.Show(sErrorMesageAlerta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            BuscarValorizacion()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        

    End Sub
    Private Sub Limpiar()
        Me.dtgOperaciones.DataSource = Nothing
        LimpiarTextos()
    End Sub

    Private Sub LimpiarTextos()
        txtFchCorte.Text = ""
        txtObservacion.Text = ""
        txtTiempoAprobacion.Text = ""
    End Sub

    Private Function ValidarIngreso() As String
        Dim msg As String = ""
        txtFchCorte.Text = txtFchCorte.Text.Trim
        txtObservacion.Text = txtObservacion.Text.Trim
        txtTiempoAprobacion.Text = txtTiempoAprobacion.Text.Trim
        If txtFchCorte.Text.Trim().Length = 0 Then
            msg = "* Ingrese Fecha de Corte "
            'ElseIf txtObservacion.Text.Trim().Length = 0 Then
            '    msg = msg & vbCrLf & "* Ingrese Observacion"
        ElseIf txtTiempoAprobacion.Text.Trim().Length = 0 Then
            msg = msg & vbCrLf & "* Ingrese el tiempo aprobación"
        ElseIf UcCliente_TxtF011.pCodigo = "0" Then
            msg = msg & vbCrLf & "* Seleccione un Cliente"
        End If
        Return msg
    End Function

    Private Sub txtTiempoAprobacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTiempoAprobacion.KeyPress
        If e.KeyChar = "." Then
            e.Handled = True
            Exit Sub
        End If
        If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            If Me.dtgOperaciones.RowCount = 0 Then Exit Sub
            Dim dtGrid As New DataGridView
            dtGrid = Me.dtgOperaciones
            Dim strlTitulo As String
            Dim strlFiltros As New List(Of String)
            strlTitulo = "Listado Aprobacion Valorizacion"
            strlFiltros.Add("Compañia : \n" & UcCompania.CCMPN_Descripcion)
            strlFiltros.Add("Estado : \n" & cmbEstado.Text)
            Ransa.Utilitario.HelpClass.ExportExcelConTitulos(dtGrid, strlTitulo, strlFiltros)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function Validar_Datos_Filtro() As Boolean
        Dim lstr_validacion As String = ""
        Dim lbool_existe_error As Boolean = False
        If UcCompania.CCMPN_CodigoCompania = "" Then
            lstr_validacion += "* COMPAÑIA " & Chr(13)
        End If
        'If UcCliente.pRazonSocial = "" Then
        '    lstr_validacion += "* CLIENTE" & Chr(13)
        'End If
        If lstr_validacion <> "" Then
            HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & lstr_validacion)
            lbool_existe_error = True
        End If
        Return lbool_existe_error
    End Function

    Private Sub CargaEstadoCombo()
        Dim dt As New DataTable("Estados")
        dt.Columns.Add("CodEstado")
        dt.Columns.Add("DescEstado")
        dt.Rows.Add(New Object() {"A", "Activo"})
        dt.Rows.Add(New Object() {"C", "Cerrado"})
        cmbEstado.DataSource = dt
        cmbEstado.ValueMember = "CodEstado"
        cmbEstado.DisplayMember = "DescEstado"
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

            Case MANTENIMIENTO.EDITAR
                btnNuevo.Enabled = False
                btnGuardar.Visible = True
                btnCancelar.Visible = True
                btnAnularCancelar.Enabled = False
                lbool_estado = True

            Case MANTENIMIENTO.NUEVO
                btnNuevo.Enabled = False
                btnGuardar.Visible = True
                btnCancelar.Visible = True
                btnAnularCancelar.Enabled = False
                lbool_estado = True
        End Select

        Me.txtFchCorte.Enabled = lbool_estado
        Me.txtObservacion.Enabled = lbool_estado
        Me.txtTiempoAprobacion.Enabled = lbool_estado
        UcCliente_TxtF011.Enabled = lbool_estado

    End Sub

    Private Sub dtgOperaciones_SelectionChanged(sender As Object, e As EventArgs) Handles dtgOperaciones.SelectionChanged
        Try

            LimpiarTextos()

            If Me.dtgOperaciones.RowCount = 0 OrElse Me.dtgOperaciones.CurrentCellAddress.Y < 0 Then Exit Sub

            txtFchCorte.Text = dtgOperaciones.CurrentRow.Cells("REFCNT").Value.ToString.Trim
            txtTiempoAprobacion.Text = Val(dtgOperaciones.CurrentRow.Cells("QDAPVL").Value)
            txtObservacion.Text = dtgOperaciones.CurrentRow.Cells("TOBSE1").Value.ToString.Trim
            UcCliente_TxtF011.pCargar(dtgOperaciones.CurrentRow.Cells("CCLNT").Value)
            '

 
            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            EstadoBoton(gEnum_Mantenimiento)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

 


End Class
