Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO
Imports System.Text

Public Class frmFactorPagoAVC

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

    Private Sub frmFactorPagoAVC_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Cargar_Combos()
        Cargar_Categoria_Conductor()
        gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnEliminar.Enabled = False
        Me.Estado_Controles(False, Panel2)
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        ListaFactorPagoAVC()
    End Sub

    Private Sub dtgFactorPagoAVC_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgFactorPagoAVC.CellClick
        If Me.gEnum_Mantenimiento = Mantenimiento.NUEVO OrElse Me.gEnum_Mantenimiento = Mantenimiento.EDITAR Then
            If Me.dtgFactorPagoAVC.Rows.Count > 0 Then
                Me.dtgFactorPagoAVC.CurrentRow.Selected = False
            End If
            HelpClass.MsgBox("Debe guardar o cancelar.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        btnGuardar.Text = "Modificar"
        btnGuardar.Enabled = True
        btnEliminar.Enabled = True
        Me.gEnum_Mantenimiento = Mantenimiento.MODIFICAR
        ListarDetalle_FatorPagoAVC()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        gEnum_Mantenimiento = Mantenimiento.NUEVO
        btnNuevo.Enabled = False
        btnGuardar.Text = "Guardar"
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnEliminar.Enabled = False
        Limpiar_Controles(Panel2)
        Estado_Controles(True, Panel2)
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.gEnum_Mantenimiento = Mantenimiento.NUEVO Then
            If Validar() Then
                Mantenimiento_Factor_Pago_AVC("A")
            End If
        ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            If Validar() Then
                Mantenimiento_Factor_Pago_AVC("A")
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
            Mantenimiento_Factor_Pago_AVC("*")
            Limpiar_Controles(Panel2)
        End If
    End Sub

    Private Sub cmbMedioTransporte_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCliente.Leave, cmbCategoria.Leave, cmbMedioTransporte.Leave
        Dim intCont As Integer
        If Me.cmbMedioTransporte.SelectedValue = Nothing Or Me.txtCliente.pCodigo = 0 Or Me.cmbCategoria.SelectedValue = Nothing Then
            Me.Limpiar_Controles(Panel2, 1)
            Exit Sub
        End If
        Me.Limpiar_Controles(Panel2, 1)
        For intCont = 0 To Me.dtgFactorPagoAVC.Rows.Count - 1
            If (CType(dtgFactorPagoAVC.Rows(intCont).Cells("CTPMDT").Value, Double) = Me.cmbMedioTransporte.SelectedValue) _
             And dtgFactorPagoAVC.Rows(intCont).Cells("CCLNT").Value.ToString.Trim = Me.txtCliente.pCodigo.ToString.Trim And _
             dtgFactorPagoAVC.Rows(intCont).Cells("SCATEG").Value = Me.cmbCategoria.SelectedValue Then
                Me.txtFactorPago.Text = Format(Me.dtgFactorPagoAVC.Rows(intCont).Cells("IFCTPG").Value, "###,###,##0.00000")
            End If
        Next
    End Sub

    Private Sub txtFactorPago_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFactorPago.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(HelpClass.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub dtgFactorPagoAVC_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgFactorPagoAVC.KeyUp
        If (e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down) Then
            If Me.gEnum_Mantenimiento = Mantenimiento.NUEVO OrElse Me.gEnum_Mantenimiento = Mantenimiento.EDITAR Then
                If Me.dtgFactorPagoAVC.Rows.Count > 0 Then
                    Me.dtgFactorPagoAVC.CurrentRow.Selected = False
                End If
                HelpClass.MsgBox("Debe guardar el nuevo Obrero o cancelar.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            btnGuardar.Text = "Modificar"
            btnGuardar.Enabled = True
            btnEliminar.Enabled = True
            Me.gEnum_Mantenimiento = Mantenimiento.MODIFICAR
            Me.ListarDetalle_FatorPagoAVC()
        End If
    End Sub

    Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
        Dim objListDtg As New List(Of DataGridView)
        objListDtg.Add(Me.dtgFactorPagoAVC)
        HelpClass.ExportarExcel_HTML(objListDtg)

    End Sub

#End Region

#Region "Metodos"

    Private Sub Cargar_Categoria_Conductor()
        Dim objlogica As New Categoria_Chofer_BLL
        Me.cmbCategoria.DataSource = objlogica.Listar_Categoria_Chofer
        Me.cmbCategoria.DisplayMember = "TCATEG"
        Me.cmbCategoria.ValueMember = "SCATEG"
    End Sub

    Private Sub ListaFactorPagoAVC()
        Me.Cursor = Cursors.WaitCursor
        Dim objEntidad As New FactorPagoAVC
        Dim objLogical As New FactorPagoAVC_BLL

        objEntidad.CCLNT = Me.txtClienteBusqueda.pCodigo
        dtgFactorPagoAVC.AutoGenerateColumns = False
        dtgFactorPagoAVC.DataSource = HelpClass.GetDataSetNative(objLogical.ListarFactorPagoAVC_Cliente(objEntidad))

        If dtgFactorPagoAVC.Rows.Count > 0 Then
            Me.ListarDetalle_FatorPagoAVC()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ListarDetalle_FatorPagoAVC()
        Me.Cursor = Cursors.WaitCursor
        If Me.dtgFactorPagoAVC.Rows.Count = 0 Then Exit Sub
        If Not dtgFactorPagoAVC.CurrentRow.Selected Then
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        Limpiar_Controles(Me.Panel2, 0)
        Me.cmbMedioTransporte.SelectedValue = CType(Me.dtgFactorPagoAVC.SelectedRows(0).Cells("CTPMDT").Value, Double)
        txtCliente.pCargar(Me.dtgFactorPagoAVC.SelectedRows(0).Cells("CCLNT").Value)
        Me.cmbCategoria.SelectedValue = Me.dtgFactorPagoAVC.SelectedRows(0).Cells("SCATEG").Value
        txtFactorPago.Text = Format(Me.dtgFactorPagoAVC.SelectedRows(0).Cells("IFCTPG").Value, "###,###,##0.00000")
        Me.Cursor = Cursors.Default

    End Sub

    Public Sub Limpiar_Controles(ByVal Contenedor As Object, Optional ByVal intTipo As Integer = 0)
        'Me.HeaderDatos.ValuesPrimary.Heading = "Información del Obrero"
        Dim X As Control
        If intTipo = 0 Then
            txtCliente.pClear()
            For Each X In Contenedor.Controls
                If TypeOf X Is TextBox Then CType(X, TextBox).Clear()
                If TypeOf X Is ComponentFactory.Krypton.Toolkit.KryptonTextBox Then CType(X, ComponentFactory.Krypton.Toolkit.KryptonTextBox).Clear()
                If TypeOf X Is ComponentFactory.Krypton.Toolkit.KryptonComboBox Then CType(X, ComponentFactory.Krypton.Toolkit.KryptonComboBox).SelectedIndex = -1
                If TypeOf X Is DateTimePicker Then CType(X, DateTimePicker).Value = Now
                If TypeOf X Is CheckBox Then CType(X, CheckBox).Checked = False
                If TypeOf X Is RadioButton Then CType(X, RadioButton).Checked = False
                If TypeOf X Is ComboBox Then CType(X, ComboBox).SelectedIndex = -1

            Next
        Else
            For Each X In Contenedor.Controls
                If TypeOf X Is TextBox Then CType(X, TextBox).Clear()
                If TypeOf X Is ComponentFactory.Krypton.Toolkit.KryptonTextBox Then CType(X, ComponentFactory.Krypton.Toolkit.KryptonTextBox).Clear()
            Next
        End If

    End Sub

    Private Sub Estado_Controles(ByVal lbool_estado As Boolean, ByVal Contenedor As Object, Optional ByVal intEstado As Integer = 0)
        Dim X As Control
        If intEstado = 0 Then
            If Me.gEnum_Mantenimiento = Mantenimiento.EDITAR Or Mantenimiento.NUEVO Or Mantenimiento.MODIFICAR Then
                For Each X In Contenedor.Controls
                    X.Enabled = lbool_estado
                Next
            End If
        Else
            If Me.gEnum_Mantenimiento = Mantenimiento.EDITAR Or Mantenimiento.NUEVO Or Mantenimiento.MODIFICAR Then
                txtFactorPago.Enabled = lbool_estado
            End If
        End If

    End Sub

    Private Function Validar() As Double
        Dim strError As String = "DEBE DE INGRESAR: " & Chr(13)
        If Me.cmbMedioTransporte.SelectedValue = vbNullString Then
            strError += "* Medio de Transporte " & Chr(13)
        End If

        If Me.txtCliente.pCodigo = 0 Then
            strError += "* Cliente " & Chr(13)
        End If
        If Me.cmbCategoria.SelectedValue = vbNullString Then
            strError += "* Categoria " & Chr(13)
        End If
        
        If txtFactorPago.Text.Length = 0 OrElse txtFactorPago.Text = 0 Then
            strError = strError & "* Factor de pago" & Chr(13)
        Else
            If CType(txtFactorPago.Text.Trim.Split(".").GetValue(0).ToString, Double).ToString.Length > 2 Then
                strError = strError & "* Factor de pago valido" & Chr(13)
            End If
        End If
        If strError.Trim.Length > 17 Then
            HelpClass.MsgBox(strError, MessageBoxIcon.Warning)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Mantenimiento_Factor_Pago_AVC(ByVal strEstado As String)
        Dim objEntidad As New FactorPagoAVC
        Dim objLogical As New FactorPagoAVC_BLL

        Try
            objEntidad.CCLNT = Me.txtCliente.pCodigo
            objEntidad.CTPMDT = Me.cmbMedioTransporte.SelectedValue
            objEntidad.SCATEG = Me.cmbCategoria.SelectedValue
            objEntidad.CULUSA = MainModule.USUARIO
            objEntidad.IFCTPG = Me.txtFactorPago.Text
            objEntidad.FULTAC = HelpClass.TodayNumeric
            objEntidad.HULTAC = HelpClass.NowNumeric
            objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            objEntidad.SESTRG = strEstado
            objLogical.Mantenimiento_Factor_Pago_AVC(objEntidad)
            AccionCancelar()
            Me.ListaFactorPagoAVC()
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
        End Try

    End Sub

    Private Sub AccionCancelar()
        If gEnum_Mantenimiento = Mantenimiento.EDITAR Or gEnum_Mantenimiento = Mantenimiento.EDITAR Or gEnum_Mantenimiento = Mantenimiento.NUEVO Then
            Estado_Controles(False, Panel2)
            If Me.dtgFactorPagoAVC.Rows.Count > 0 Then
                Me.dtgFactorPagoAVC.CurrentRow.Selected = False
            End If
        End If
        gEnum_Mantenimiento = Mantenimiento.NEUTRAL
        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnEliminar.Enabled = False
    End Sub

  Private Sub Cargar_Combos()
    Dim objEntidadTracto As New ENTIDADES.mantenimientos.TransportistaTracto
    Try
      Dim objMedioTransporte As New NEGOCIO.MedioTransporte_BLL
      With Me.cmbMedioTransporte
        .DataSource = objMedioTransporte.Lista_Medio_Transporte()
        .ValueMember = "CTPMDT"
        .DisplayMember = "TTPMDT"
      End With
    Catch ex As Exception
    End Try

  End Sub
#End Region


   
End Class
