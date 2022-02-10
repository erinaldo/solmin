Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports System.Text
Imports SOLMIN_ST.ENTIDADES

Public Class frmAsignacionRuta

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub


#Region "Atributos"
    Private bolbuscar As Double
    Private gEnum_Mantenimiento As MANTENIMIENTO
#End Region

#Region "Eventos"
    Private Sub frmAsignacionRuta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Cargar_Combos()
        CargarRuta()
        ListarAsignacionRuta()
        gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnEliminar.Enabled = False
        Me.Estado_Controles(False, Panel2)
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        ListarAsignacionRuta()
    End Sub

    Private Sub dtgAsignacion_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgAsignacion.CellClick
        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            If Me.dtgAsignacion.Rows.Count > 0 Then
                Me.dtgAsignacion.CurrentRow.Selected = False
            End If
            HelpClass.MsgBox("Debe guardar o cancelar.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        btnGuardar.Text = "Modificar"
        btnGuardar.Enabled = True
        btnEliminar.Enabled = True
        Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
        ListaDetalleAsignacionRuta()

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
        btnNuevo.Enabled = False
        btnGuardar.Text = "Guardar"
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnEliminar.Enabled = False
        Limpiar_Controles(Panel2)
        Estado_Controles(True, Panel2)
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
            If Validar() Then
                MantenimientoAsignacion_Km_AVC_Ruta("A")
            End If
        ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            If Validar() Then
                MantenimientoAsignacion_Km_AVC_Ruta("A")
            End If
            ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
                Me.Estado_Controles(True, Panel2, 1)
                btnGuardar.Text = "Guardar"
                btnNuevo.Enabled = False
                btnCancelar.Enabled = True
                btnEliminar.Enabled = False
                Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
            End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        AccionCancelar()
        Me.Limpiar_Controles(Panel2)
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If HelpClass.RspMsgBox("Desea eliminar este registro?") = MsgBoxResult.Yes Then
            MantenimientoAsignacion_Km_AVC_Ruta("*")
            Limpiar_Controles(Panel2)
        End If
    End Sub

    Private Sub ctbDestino_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctbDestino.Leave, ctbOrigen.Leave, cmbMedioTransporte.Leave
        Dim intCont As Integer

        If Me.cmbMedioTransporte.SelectedValue = Nothing Or ctbOrigen.Codigo = Nothing Or Me.ctbDestino.Codigo = Nothing Then
            Me.Limpiar_Controles(Panel2, 1)
            Exit Sub
        End If

        Me.Limpiar_Controles(Panel2, 1)
        For intCont = 0 To Me.dtgAsignacion.Rows.Count - 1
            If (CType(dtgAsignacion.Rows(intCont).Cells("CTPMDT").Value, Double) = Me.cmbMedioTransporte.SelectedValue) And dtgAsignacion.Rows(intCont).Cells("CLCLOR").Value.ToString.Trim = ctbOrigen.Codigo.ToString.Trim And dtgAsignacion.Rows(intCont).Cells("CLCLDS").Value.ToString.Trim = ctbDestino.Codigo.ToString.Trim Then
                Me.txtKm.Text = Me.dtgAsignacion.Rows(intCont).Cells("QDSTKM").Value
            End If
        Next
    End Sub

    Private Sub dtgAsignacion_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgAsignacion.KeyUp
        If (e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down) Then
            If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
                If Me.dtgAsignacion.Rows.Count > 0 Then
                    Me.dtgAsignacion.CurrentRow.Selected = False
                End If
                HelpClass.MsgBox("Debe guardar el nuevo Obrero o cancelar.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            btnGuardar.Text = "Modificar"
            btnGuardar.Enabled = True
            btnEliminar.Enabled = True
            Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
            Me.ListaDetalleAsignacionRuta()
        End If
    End Sub

    Private Sub txtKm_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKm.KeyPress, txtImportePedidoEfectivo.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(HelpClass.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
        Dim objListDtg As New List(Of DataGridView)
        objListDtg.Add(Me.dtgAsignacion)
        HelpClass.ExportarExcel_HTML(objListDtg)
    End Sub

    Private Sub txtImportePedidoEfectivo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImportePedidoEfectivo.Leave
        If IsNumeric(txtImportePedidoEfectivo.Text) Then
            txtImportePedidoEfectivo.Text = Format(CType(txtImportePedidoEfectivo.Text, Double), "###,###,##0.00")
        Else
            txtImportePedidoEfectivo.Text = "0"
        End If
    End Sub
#End Region

#Region "Metodos"

  Private Sub Cargar_Combos()
    Dim objEntidadTracto As New ENTIDADES.mantenimientos.TransportistaTracto
    Try
      Dim objMedioTransporte As New NEGOCIO.MedioTransporte_BLL
      With Me.cmbMedioTransporte
        .DataSource = objMedioTransporte.Lista_Medio_Transporte()
        .ValueMember = "CTPMDT"
        .DisplayMember = "TTPMDT"
      End With

      With Me.cmbMedioTransCon0
        .DataSource = objMedioTransporte.Lista_Medio_Transporte(1)
        .ValueMember = "CTPMDT"
        .DisplayMember = "TTPMDT"
      End With
    Catch ex As Exception
    End Try
  End Sub

    Private Sub Estado_Controles(ByVal lbool_estado As Boolean, ByVal Contenedor As Object, Optional ByVal intEstado As Integer = 0)
        Dim X As Control
        If intEstado = 0 Then
            If Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Or MANTENIMIENTO.NUEVO Or MANTENIMIENTO.MODIFICAR Then
                For Each X In Contenedor.Controls
                    X.Enabled = lbool_estado
                Next
            End If
        Else
            If Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Or MANTENIMIENTO.NUEVO Or MANTENIMIENTO.MODIFICAR Then
                txtKm.Enabled = lbool_estado
                Me.dtpFechaVigencia.Enabled = lbool_estado
                Me.txtImportePedidoEfectivo.Enabled = lbool_estado
            End If
        End If

    End Sub

    Private Sub CargarRuta()
        Dim obj_Logica_Localidad As New NEGOCIO.Localidad_BLL
        Dim objDt As DataTable
        objDt = obj_Logica_Localidad.Listar_Localidades_Combo("EZ") 'CType(MainModule.gobj_TablasGeneralesdelSistema("LOCALIDADES"), DataTable).Copy()
        With Me.ctbOrigen
            .DataSource = objDt.Copy
            .KeyField = "CLCLD"
            .ValueField = "TCMLCL"
            .DataBind()
        End With
        With Me.ctbDestino
            .DataSource = objDt.Copy
            .KeyField = "CLCLD"
            .ValueField = "TCMLCL"
            .DataBind()
        End With
        With Me.ctbOrigenCon1
            .DataSource = objDt.Copy
            .KeyField = "CLCLD"
            .ValueField = "TCMLCL"
            .DataBind()
        End With
        With Me.ctbOrigenCon2
            .DataSource = objDt.Copy
            .KeyField = "CLCLD"
            .ValueField = "TCMLCL"
            .DataBind()
        End With
    End Sub

    Private Sub ListarAsignacionRuta()
        Me.Cursor = Cursors.WaitCursor
        Dim objLogica As New AsignacionRuta_BLL()
        Dim objEntidad As New AsignacionRuta()
        If Me.ctbOrigenCon1.Codigo = "" Then
            objEntidad.CLCLOR = 0
        Else
            objEntidad.CLCLOR = Me.ctbOrigenCon1.Codigo
        End If
        If Me.ctbOrigenCon2.Codigo = "" Then
            objEntidad.CLCLDS = 0
        Else
            objEntidad.CLCLDS = Me.ctbOrigenCon2.Codigo
        End If
        objEntidad.CTPMDT = cmbMedioTransCon0.SelectedValue
        Me.dtgAsignacion.AutoGenerateColumns = False
        Me.dtgAsignacion.DataSource = HelpClass.GetDataSetNative(objLogica.ListarAsignacion_Km_AVC_Ruta(objEntidad))
        If dtgAsignacion.Rows.Count > 0 Then
            ListaDetalleAsignacionRuta()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ListaDetalleAsignacionRuta()
        Me.Cursor = Cursors.WaitCursor
        If Not dtgAsignacion.CurrentRow.Selected Then
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        Limpiar_Controles(Me.Panel2, 0)
        Me.cmbMedioTransporte.SelectedValue = CType(Me.dtgAsignacion.SelectedRows(0).Cells("CTPMDT").Value, Double)
        Me.ctbOrigen.Codigo = Me.dtgAsignacion.SelectedRows(0).Cells("CLCLOR").Value
        Me.ctbDestino.Codigo = Me.dtgAsignacion.SelectedRows(0).Cells("CLCLDS").Value
        Me.txtKm.Text = Me.dtgAsignacion.SelectedRows(0).Cells("QDSTKM").Value
        Me.txtImporteAvc.Text = Me.dtgAsignacion.SelectedRows(0).Cells("IRTAVC").Value
        Me.dtpFechaVigencia.Value = Me.dtgAsignacion.SelectedRows(0).Cells("FVGAVC").Value
        Me.txtImportePedidoEfectivo.Text = Format(CType(Me.dtgAsignacion.SelectedRows(0).Cells("IGSTVJ").Value, Double), "###,###,##0.00")

        Me.Cursor = Cursors.Default
    End Sub

    Public Sub Limpiar_Controles(ByVal Contenedor As Object, Optional ByVal intTipo As Integer = 0)
        Dim X As Control
        If intTipo = 0 Then
            Me.ctbOrigen.Limpiar()
            Me.ctbDestino.Limpiar()
            For Each X In Contenedor.Controls
                If TypeOf X Is TextBox Then CType(X, TextBox).Clear()
                If TypeOf X Is ComponentFactory.Krypton.Toolkit.KryptonTextBox Then CType(X, ComponentFactory.Krypton.Toolkit.KryptonTextBox).Clear()
                If TypeOf X Is ComponentFactory.Krypton.Toolkit.KryptonComboBox Then CType(X, ComponentFactory.Krypton.Toolkit.KryptonComboBox).SelectedIndex = -1
                If TypeOf X Is DateTimePicker Then CType(X, DateTimePicker).Value = Now
                If TypeOf X Is CheckBox Then CType(X, CheckBox).Checked = False
                If TypeOf X Is RadioButton Then CType(X, RadioButton).Checked = False
                If TypeOf X Is ComboBox Then CType(X, ComboBox).SelectedIndex = -1
                If TypeOf X Is DateTimePicker Then CType(X, DateTimePicker).Value = Now

            Next
        Else
            For Each X In Contenedor.Controls
                If TypeOf X Is TextBox Then CType(X, TextBox).Clear()
                If TypeOf X Is ComponentFactory.Krypton.Toolkit.KryptonTextBox Then CType(X, ComponentFactory.Krypton.Toolkit.KryptonTextBox).Clear()
                If TypeOf X Is DateTimePicker Then CType(X, DateTimePicker).Value = Now
            Next
        End If

    End Sub



    '===========Operaciones Mantenimiento

    Private Function Validar() As Double
        Dim strError As String = "DEBE DE INGRESAR: " & Chr(13)
        If Me.cmbMedioTransporte.SelectedValue = vbNullString Then
            strError += "* Medio de Transporte " & Chr(13)
        End If

        If Me.ctbOrigen.Codigo = vbNullString Then
            strError += "* Código Origen ruta" & Chr(13)
        End If
        If Me.ctbDestino.Codigo = vbNullString Then
            strError += "* Código destino ruta" & Chr(13)
        End If
        If Me.txtKm.Text.Trim = vbNullString Then
            strError += "* Cantidad de Kilómetros" & Chr(13)
        End If
        If Me.txtImportePedidoEfectivo.Text.Trim.Length = 0 Then
            strError += "* Importe pedido efectivo valido" & Chr(13)
        End If
        If strError.Trim.Length > 17 Then
            HelpClass.MsgBox(strError, MessageBoxIcon.Warning)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub AccionCancelar()
        If gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Or gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Or gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
            Estado_Controles(False, Panel2)
            If Me.dtgAsignacion.Rows.Count > 0 Then
                Me.dtgAsignacion.CurrentRow.Selected = False
            End If
        End If
        gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    '===========fin operaciones Manetenimiento

    '==========Mantenimiento==========
    Private Sub MantenimientoAsignacion_Km_AVC_Ruta(ByVal strEstado As String)
        Me.Cursor = Cursors.WaitCursor
        Dim objLogica As New AsignacionRuta_BLL()
        Dim objEntidad As New AsignacionRuta()

        Try
            objEntidad.CTPMDT = Me.cmbMedioTransporte.SelectedValue
            objEntidad.CLCLOR = Me.ctbOrigen.Codigo
            objEntidad.CLCLDS = Me.ctbDestino.Codigo
            objEntidad.QDSTKM = Me.txtKm.Text
            objEntidad.IGSTVJ = Me.txtImportePedidoEfectivo.Text
            objEntidad.IRTAVC = 0 'Me.txtImporteAvc.Text
            objEntidad.FVGAVC = HelpClass.CtypeDate(Me.dtpFechaVigencia.Value)
            objEntidad.CULUSA = MainModule.USUARIO
            objEntidad.FULTAC = HelpClass.TodayNumeric
            objEntidad.HULTAC = HelpClass.NowNumeric
            objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            objEntidad.SESTRG = strEstado
            objLogica.MantenimientoAsignacion_Km_AVC_Ruta(objEntidad)
            AccionCancelar()
            ListarAsignacionRuta()
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
        End Try
        Me.Cursor = Cursors.Default
    End Sub
    '==========Mantenimiento============
#End Region

   

   
End Class
