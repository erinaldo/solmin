Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.Utilitario
Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades

Public Class frmConfiguracionValorizacion
    Private oValorizacion As SOLMIN_CTZ.Entidades.Valorizacion
    Private BandNew As Boolean = True
    Private gEnum_Mantenimiento As MANTENIMIENTO

    Private Sub frmConfiguracionValorizacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        UcCompania.Usuario = ConfigurationWizard.UserName
        UcCompania.pActualizar()
        UcCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        CargaEstadoCombo()
        Me.dtgOperaciones.AutoGenerateColumns = False
        gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        EstadoBoton(gEnum_Mantenimiento)
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

            oValorizacion.CCMPN = Me.UcCompania.CCMPN_CodigoCompania
            oValorizacion.CCLNT = Me.UcCliente.pCodigo
            oValorizacion.REFCNT = Me.txtFchCorte.Text
            oValorizacion.QDAPVL = Me.txtTiempoAprobacion.Text
            oValorizacion.TOBSE1 = Me.txtObservacion.Text
            oValorizacion.NTRMNL = HelpClass.NombreMaquina
            oValorizacion.CULUSA = ConfigurationWizard.UserName

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
                MessageBox.Show(sErrorMesage, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        BandNew = True
        LimpiarTextos()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        BandNew = False
        LimpiarTextos()
        gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        EstadoBoton(gEnum_Mantenimiento)
        BuscarValorizacion()
    End Sub

    Private Sub btnAnularCancelar_Click(sender As Object, e As EventArgs) Handles btnAnularCancelar.Click
        BandNew = False
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

            oValorizacion.CCMPN = UcCompania.CCMPN_CodigoCompania
            oValorizacion.CCLNT = UcCliente.pCodigo
            oValorizacion.CNFCVL = dtgOperaciones.CurrentRow.Cells("CNFCVL").Value
            oValorizacion.NTRMNL = HelpClass.NombreMaquina
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
        '   Campos Asignación
        'IN PSCCMPN VARCHAR(2) ,	Compañía
        'IN PNCCLNT NUMERIC(6,0),	Cliente
        'PNCNFCVL	Correlativo Cierre
        'IN PSNTRMNL VARCHAR(10),	Nombre Máquina
        'IN PSCULUSA VARCHAR(10)	Usuario

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
        ElseIf txtObservacion.Text.Trim().Length = 0 Then
            msg = msg & vbCrLf & "* Ingrese Alguna Observacion"
        ElseIf txtTiempoAprobacion.Text.Trim().Length = 0 Then
            msg = msg & vbCrLf & "* Ingrese el Tiempo Aprobacion"
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
        If UcCliente.pRazonSocial = "" Then
            lstr_validacion += "* CLIENTE" & Chr(13)
        End If
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
                btnAnularCancelar.Enabled = False
                lbool_estado = False

            Case MANTENIMIENTO.EDITAR
                btnNuevo.Enabled = False
                btnGuardar.Visible = True
                btnCancelar.Visible = True
                btnAnularCancelar.Enabled = True
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

    End Sub

    Private Sub dtgOperaciones_SelectionChanged(sender As Object, e As EventArgs) Handles dtgOperaciones.SelectionChanged
        BandNew = False
        LimpiarTextos()
        ' If e.RowIndex < 0 Then Exit Sub
        If Me.dtgOperaciones.RowCount = 0 OrElse Me.dtgOperaciones.CurrentCellAddress.Y < 0 Then Exit Sub

        txtFchCorte.Text = dtgOperaciones.CurrentRow.Cells("REFCNT").Value
        txtTiempoAprobacion.Text = dtgOperaciones.CurrentRow.Cells("QDAPVL").Value
        txtObservacion.Text = dtgOperaciones.CurrentRow.Cells("TOBSE1").Value
        If dtgOperaciones.CurrentRow.Cells("SESTRG").Value = "A" Then
            gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
        Else
            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        End If
        EstadoBoton(gEnum_Mantenimiento)
    End Sub

End Class
