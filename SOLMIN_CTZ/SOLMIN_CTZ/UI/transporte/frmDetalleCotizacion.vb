Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.Entidades.mantenimientos
Imports SOLMIN_CTZ.Entidades.Operaciones
Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.NEGOCIO.Operaciones
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class frmDetalleCotizacion

#Region "Variables"
    Public obeDetalleCotizacion As New Detalle_Cotizacion
    Private gEnum_Mantenimiento As MANTENIMIENTO
    Dim lbooEstado As Boolean = True  ' Estado modificacion del mantenimiento
    Private bs As New BindingSource
    Public objEntidadAcceso As New ClaseGeneral
#End Region

#Region "Propiedades"

    Private _mNCTZCN As Double

    Public Property mNCTZCN() As Double
        Get
            Return _mNCTZCN
        End Get
        Set(ByVal value As Double)
            _mNCTZCN = value
        End Set
    End Property

    Private _mCCLNT As Double

    Public Property mCCLNT() As Double
        Get
            Return _mCCLNT
        End Get
        Set(ByVal value As Double)
            _mCCLNT = value
        End Set
    End Property

    Private _mESTADO As String
    Public Property mESTADO() As String
        Get
            Return _mESTADO
        End Get
        Set(ByVal value As String)
            _mESTADO = value
        End Set
    End Property


    Private _mFVGCTZ As String
    Public Property mFVGCTZ() As String
        Get
            Return _mFVGCTZ
        End Get
        Set(ByVal value As String)
            _mFVGCTZ = value
        End Set
    End Property
    Private _mCCMPN As String
    Private _mCDVSN As String

    Public Property mCCMPN() As String
        Get
            Return _mCCMPN
        End Get
        Set(ByVal value As String)
            _mCCMPN = value
        End Set
    End Property

    Public Property mCDVSN() As String
        Get
            Return _mCDVSN
        End Get
        Set(ByVal value As String)
            _mCDVSN = value
        End Set
    End Property

    Private _mSESTCT As String

    Public Property mSESTCT() As String
        Get
            Return _mSESTCT
        End Get
        Set(ByVal value As String)
            _mSESTCT = value
        End Set
    End Property



#End Region

#Region "Eventos"

    Private Sub frmDetalleCotizacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue
        Me.Cargar_Combos()
        If obeDetalleCotizacion.NCRRCT = 0 Then
            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            btnGuardar.Enabled = False
            btnCancelar.Enabled = False
            Estado_Controles(False, PanelMantenimiento)
            'EstadoGeneradoOS(_mSESTCT.ToString.Trim.Equals("P"))
            EstadoGeneradoOS(True)
            Validar_Acceso_Opciones_Usuario()
        Else
            Me.Estado_Controles(True, PanelMantenimiento, 0)
            btnGuardar.Text = "Guardar"
            btnNuevo.Enabled = False
            btnCancelar.Enabled = True
            Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
            DetalleCotizacion()
        End If
    End Sub

    Private Sub Validar_Acceso_Opciones_Usuario()
        If objEntidadAcceso.STSADI = "" Then
            Me.btnNuevo.Visible = False
            Me.Separator1.Visible = False
        End If
        If objEntidadAcceso.STSCHG = "" Then
            Me.btnGuardar.Visible = False
            Me.Separator2.Visible = False
        End If
        If objEntidadAcceso.STSADI = "" And objEntidadAcceso.STSCHG = "" Then
            Me.btnCancelar.Visible = False
        End If
        'If objEntidadAcceso.STSELI = "" Then
        '    Me.btnEliminar.Visible = False
        '    Me.Separator4.Visible = False
        'End If

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
        btnNuevo.Enabled = False
        btnGuardar.Text = "Guardar"
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        Limpiar_Controles(Me.PanelMantenimiento)
        Estado_Controles(True, PanelMantenimiento)
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
            If Validar() Then
                Guardar_DetalleCotizacion()
            End If
        ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            If Validar() Then
                Modificar_Detalle_Cotizacion()
            End If
        ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
            Me.Estado_Controles(True, PanelMantenimiento, 0)
            btnGuardar.Text = "Guardar"
            btnNuevo.Enabled = False
            btnCancelar.Enabled = True
            Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        AccionCancelar()
    End Sub

    'Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If HelpClass.RspMsgBox("Desea eliminar este registro?") = MsgBoxResult.Yes Then
    '        Eliminar()
    '        Limpiar_Controles(PanelMantenimiento)
    '    End If
    'End Sub

    'Private Sub dtgDetalleCotizacion_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    '    If Me.dtgDetalleCotizacion.CurrentCellAddress.Y < 0 Then Exit Sub
    '    If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
    '        If Me.dtgDetalleCotizacion.Rows.Count > 0 Then
    '            lbooEstado = False
    '            Me.dtgDetalleCotizacion.CurrentRow.Selected = False
    '        End If
    '        HelpClass.MsgBox("Debe guardar o cancelar.", MsgBoxStyle.Exclamation)
    '        Exit Sub
    '    End If
    '    btnGuardar.Text = "Modificar"
    '    btnGuardar.Enabled = True
    '    btnEliminar.Enabled = True
    '    btnDetalleCotizacion.Enabled = True
    '    Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
    '    Limpiar_Controles(Me.PanelMantenimiento)
    '    Me.DetalleCotizacion()
    '    lbooEstado = True
    'End Sub

    Private Sub txtPolizaSeguro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVolumenMercaderia.KeyPress, txtValorMercaderia.KeyPress, txtPolizaSeguro.KeyPress, txtPesoMercaderia.KeyPress, txtCantidadMercaderia.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(HelpClass.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTipoServicio_Texto_KeyEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoServicio.Texto_KeyEnter
        If txtTipoServicio.NoHayCodigo = False Then
            Listar_SubServicios()
        Else
            Me.txtTipoSubServicio.DataSource = Nothing
            Me.txtTipoSubServicio.Limpiar()
        End If
    End Sub



#End Region

#Region "Metodos"

    Private Sub Cargar_Combos()
        Dim objCompaniaSeguro As New CompaniaSeguro_BLL
        Dim objCondicionRuta As New CondicionRuta_BLL
        Dim objMercaderia As New SOLMIN_CTZ.NEGOCIO.mantenimientos.MercaderiaTransportes_BLL
        Dim objParametroFacturacion As New ParametroFacturacion_BLL
        Dim objParametroPagar As New ParametroFacturacion_BLL
        Dim objTipoServicioTransporte As New TipoServicioTransporte_BLL
        Dim objUnidadMedida As New UnidadMedida_BLL
        Dim objUnidadTransporte As New SOLMIN_CTZ.NEGOCIO.mantenimientos.UnidadesTransporte_BLL
        Dim objNave As New Naves_BLL
        Dim objCompania As New Compania_BLL
        Dim objDivision As New Division_BLL
        Dim objPlanta As New Planta_BLL
        Dim objMoneda As New Moneda_BLL
        Dim objPlantaFacturacion As New PlantaFacturacion_BLL
        Dim objLocalidad As New Localidad_BLL
        Dim objUnidadServicio As New UnidadMedida_BLL


        With Me.txtCiaSeguro
            .DataSource = objCompaniaSeguro.Listar_Compania_Seguro_Combo(_mCCMPN)
            .KeyField = "CCMPSG"
            .ValueField = "TCMPSG"
            .DataBind()
        End With

        With Me.txtMercaderia
            .DataSource = objMercaderia.Busca_MercaderiaTransportesBuscar(_mCCMPN)
            .KeyField = "CMRCDR"
            .ValueField = "TCMRCD"
            .DataBind()
        End With

        With Me.txtParametroFacturacion
            .DataSource = objParametroFacturacion.Listar_Parametros_Facturacion_Combo(_mCCMPN)
            .KeyField = "CFRMPG"
            .ValueField = "TCMFRP"
            .DataBind()
        End With

        With Me.txtParametroPagar
            .DataSource = objParametroFacturacion.Listar_Parametros_Facturacion_Combo(_mCCMPN)
            .KeyField = "CFRMPG"
            .ValueField = "TCMFRP"
            .DataBind()
        End With

        With Me.txtTipoServicio
            .DataSource = objTipoServicioTransporte.Listar_Tipo_Servicio_Combo(_mCCMPN)
            .KeyField = "CTPOSR"
            .ValueField = "TCMTPS"
            .DataBind()
        End With

        With Me.txtUnidadMedida
            .DataSource = objUnidadMedida.Listar_Unidad_Medida_Combo(_mCCMPN)
            .KeyField = "CUNDMD"
            .ValueField = "TCMPUN"
            .DataBind()
        End With

        With Me.txtUnidadVehicular
            .DataSource = objUnidadTransporte.Listar_Unidad_Transporte_Combo(_mCCMPN)
            .KeyField = "CTPUNV"
            .ValueField = "TUNDVH"
            .DataBind()
        End With

        ' Agregando un Datatable a el tipo de seguro de cotizacion
        Dim objParam As New Collection
        Dim valores1 As New Collection
        Dim valores2 As New Collection
        Dim valores3 As New Collection
        objParam.Add("CODIGO")
        objParam.Add("VALOR")
        valores1.Add("C")
        valores1.Add("CLIENTE")
        valores2.Add("T")
        valores2.Add("RANSA")
        valores3.Add("P")
        valores3.Add("TERCERO")
        Me.txtSeguroCotizacion.Columnas_DataTable(objParam)
        Me.txtSeguroCotizacion.AgregarDataTableItem(valores1)
        Me.txtSeguroCotizacion.AgregarDataTableItem(valores2)
        Me.txtSeguroCotizacion.AgregarDataTableItem(valores3)
        txtSeguroCotizacion.KeyField = "CODIGO"
        txtSeguroCotizacion.ValueField = "VALOR"
        Me.txtSeguroCotizacion.DataBind()

    End Sub

    Private Sub Listar_SubServicios()
        Dim objEntidad As New TipoServicioTransporte
        Dim objSubServicio As New TipoSubServicioTransporte_BLL

        objEntidad.CTPOSR = Me.txtTipoServicio.Codigo
        Dim objResultado As DataTable = objSubServicio.Listar_Tipo_SubServicio(objEntidad)
        Dim dr As DataRow = objResultado.NewRow
        dr("CTPSBS") = "0"
        dr("TABSBS") = "--- Escoja Elemento ---"
        'Agrega la fila al datatable
        objResultado.Rows.InsertAt(dr, 0)
        Me.txtTipoSubServicio.DataSource = Nothing
        Me.txtTipoSubServicio.DataBind()
        Me.txtTipoSubServicio.DataSource = objResultado
        Me.txtTipoSubServicio.KeyField = "CTPSBS"
        Me.txtTipoSubServicio.ValueField = "TCMSBS"
        Me.txtTipoSubServicio.DataBind()
        objEntidad = Nothing
        objSubServicio = Nothing
    End Sub

    Private Function Existe_Ventana(ByVal pstrForm As String) As Boolean
        Dim intCont As Integer

        For intCont = 0 To Me.ParentForm.MdiChildren.Length - 1
            If Me.ParentForm.MdiChildren(intCont).Name.Trim = pstrForm.Trim Then
                Me.ParentForm.MdiChildren(intCont).WindowState = FormWindowState.Maximized
                Me.ParentForm.MdiChildren(intCont).Show()
                Return True
            End If
        Next intCont

        Return False
    End Function

    Private Sub DetalleCotizacion()
        Me.txtMercaderia.Codigo = obeDetalleCotizacion.CMRCDR
        Me.txtUnidadMedida.Codigo = obeDetalleCotizacion.CUNDMD
        Me.txtParametroFacturacion.Codigo = obeDetalleCotizacion.CFRMPG
        Me.txtSeguroCotizacion.Codigo = obeDetalleCotizacion.SSGRCT
        Me.txtCiaSeguro.Codigo = IIf(obeDetalleCotizacion.CCMPSG.ToString.Trim.Equals("") = True, "0", obeDetalleCotizacion.CCMPSG.ToString.Trim)
        Me.txtPolizaSeguro.Text = obeDetalleCotizacion.NPLSGC
        Me.txtRecargoSeguro.Text = obeDetalleCotizacion.QPRCS1
        Me.txtCantidadMercaderia.Text = obeDetalleCotizacion.QMRCDR
        Me.txtPesoMercaderia.Text = obeDetalleCotizacion.PMRCDR
        Me.txtValorMercaderia.Text = obeDetalleCotizacion.VMRCDR
        Me.txtVolumenMercaderia.Text = obeDetalleCotizacion.LMRCDR
        Me.txtReferenciaMercaderia.Text = obeDetalleCotizacion.TRFMRC
        Me.txtTipoServicio.Codigo = IIf(obeDetalleCotizacion.CTPOSR.Trim.ToString.Equals("") = True, "0", obeDetalleCotizacion.CTPOSR)
        Listar_SubServicios()
        Me.txtTipoSubServicio.Codigo = IIf(obeDetalleCotizacion.CTPSBS.ToString.Equals("") = True, "0", obeDetalleCotizacion.CTPSBS)
        Me.txtUnidadVehicular.Codigo = IIf(obeDetalleCotizacion.CTPUNV.ToString.Equals("") = True, "0", obeDetalleCotizacion.CTPUNV)
        Me.txtParametroPagar.Codigo = IIf(obeDetalleCotizacion.CFRAPG.Equals("") = True, "0", obeDetalleCotizacion.CFRAPG)
    End Sub

    Private Sub Limpiar_Controles(ByVal Contenedor As Object, Optional ByVal intTipo As Integer = 0)
        Dim X As Control
        If intTipo = 0 Then
            For Each X In Contenedor.Controls
                If TypeOf X Is CodeTextBox.CodeTextBox Then CType(X, CodeTextBox.CodeTextBox).Limpiar()
                If TypeOf X Is TextBox Then CType(X, TextBox).Clear()
                If TypeOf X Is ComponentFactory.Krypton.Toolkit.KryptonTextBox Then CType(X, ComponentFactory.Krypton.Toolkit.KryptonTextBox).Clear()
                If TypeOf X Is ComponentFactory.Krypton.Toolkit.KryptonComboBox Then CType(X, ComponentFactory.Krypton.Toolkit.KryptonComboBox).SelectedIndex = -1
                If TypeOf X Is DateTimePicker Then CType(X, DateTimePicker).Value = Now
                If TypeOf X Is CheckBox Then CType(X, CheckBox).Checked = False
                If TypeOf X Is ComponentFactory.Krypton.Toolkit.KryptonCheckBox Then CType(X, ComponentFactory.Krypton.Toolkit.KryptonCheckBox).Checked = False
                If TypeOf X Is RadioButton Then CType(X, RadioButton).Checked = False
                If TypeOf X Is ComboBox Then CType(X, ComboBox).SelectedIndex = -1
                If TypeOf X Is DateTimePicker Then CType(X, DateTimePicker).Value = Now
                If TypeOf X Is NumericUpDown Then CType(X, NumericUpDown).Text = 0
            Next
        End If
    End Sub

    Private Sub AccionCancelar()
        If gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Or gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Or gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
            Estado_Controles(False, PanelMantenimiento)
        End If
        gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
    End Sub

    Private Sub Estado_Controles(ByVal lbool_estado As Boolean, ByVal Contenedor As Object, Optional ByVal intEstado As Integer = 0)
        Dim X As Control
        If intEstado = 0 Then
            If Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Or MANTENIMIENTO.NUEVO Or MANTENIMIENTO.MODIFICAR Then
                For Each X In Contenedor.Controls
                    If Not (TypeOf X Is ComponentFactory.Krypton.Toolkit.KryptonLabel) Then
                        X.Enabled = lbool_estado
                    End If
                Next
            End If
        End If
    End Sub

    Private Function Validar() As Boolean
        Dim strError As String = "DEBE DE INGRESAR: " & Chr(13)

        If Me.txtMercaderia.NoHayCodigo = True Then
            strError += "*  Tipo de mercadería" & Chr(13)
        End If
        If Me.txtTipoServicio.NoHayCodigo = True Then
            strError += "*  Tipo de servicio" & Chr(13)
        End If
        If Me.txtTipoSubServicio.NoHayCodigo = True Then
            strError += "*  Tipo de sub servicio" & Chr(13)
        End If
        If Me.txtUnidadVehicular.NoHayCodigo = True Then
            strError += "*  Unidad vehicular" & Chr(13)
        End If
        If Me.txtParametroFacturacion.NoHayCodigo = True Then
            strError += "*  Parametro de facturación" & Chr(13)
        End If
        If Me.txtParametroPagar.NoHayCodigo = True Then
            strError += "*  Parametro de pagar" & Chr(13)
        End If
        If Me.txtSeguroCotizacion.NoHayCodigo = True Then
            strError += "*  Seguro de cotización" & Chr(13)
        ElseIf Me.txtSeguroCotizacion.Codigo = "C" Then
            If (Me.txtPolizaSeguro.Text.Length = 0 OrElse Not IsNumeric(Me.txtPolizaSeguro.Text) OrElse Me.txtPolizaSeguro.Text = 0) Then
                strError += "*  Número de poliza" & Chr(13)
            End If
            If Me.txtCiaSeguro.Codigo.ToString.Trim = "0" OrElse Me.txtCiaSeguro.NoHayCodigo = True Then
                strError += "*  Compañía de seguros" & Chr(13)
            End If
        End If
        If Me.txtUnidadMedida.NoHayCodigo = True Then
            strError += "*  Unidad de medida" & Chr(13)
        End If
        If txtCantidadMercaderia.Text.Length = 0 OrElse Not IsNumeric(Me.txtCantidadMercaderia.Text) OrElse Me.txtCantidadMercaderia.Text = 0 Then
            strError += "*  Cantidad de mercadería" & Chr(13)
        End If
        If strError.Trim.Length > 17 Then
            HelpClass.MsgBox(strError, MessageBoxIcon.Warning)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Guardar_DetalleCotizacion()
        Dim objEntidad As New Detalle_Cotizacion
        Dim objNegocios As New DetalleCotizacion_BLL

        objEntidad.NCTZCN = _mNCTZCN
        objEntidad.CMRCDR = Me.txtMercaderia.Codigo
        objEntidad.CTPOSR = Me.txtTipoServicio.Codigo
        objEntidad.CTPSBS = Me.txtTipoSubServicio.Codigo
        objEntidad.CUNDMD = Me.txtUnidadMedida.Codigo
        objEntidad.CFRMPG = Me.txtParametroFacturacion.Codigo
        objEntidad.SSGRCT = Me.txtSeguroCotizacion.Codigo
        objEntidad.CCMPSG = IIf(Me.txtCiaSeguro.Codigo.Trim.Equals(""), 0, Me.txtCiaSeguro.Codigo)
        objEntidad.NPLSGC = IIf(Me.txtPolizaSeguro.Text.Trim.Equals("") = True, "0", Me.txtPolizaSeguro.Text)
        objEntidad.QPRCS1 = IIf(Me.txtRecargoSeguro.Text = "", "0", Me.txtRecargoSeguro.Text)
        objEntidad.QMRCDR = IIf(Me.txtCantidadMercaderia.Text.Equals("") = True, "0", txtCantidadMercaderia.Text)
        objEntidad.PMRCDR = IIf(Me.txtPesoMercaderia.Text.Equals("") = True, "0", Me.txtPesoMercaderia.Text)
        objEntidad.VMRCDR = IIf(Me.txtValorMercaderia.Text.Trim.Equals("") = True, "0", Me.txtValorMercaderia.Text)
        objEntidad.LMRCDR = IIf(Me.txtVolumenMercaderia.Text.Trim.Equals("") = True, "0", Me.txtVolumenMercaderia.Text)
        objEntidad.TRFMRC = IIf(Me.txtReferenciaMercaderia.Text.Trim.Length <= 40, Me.txtReferenciaMercaderia.Text.Trim, "")
        objEntidad.FINCSR = HelpClass.CtypeDate(Now)
        objEntidad.FCRGMR = HelpClass.CtypeDate(Now)
        objEntidad.FENTMR = HelpClass.CtypeDate(Now)
        objEntidad.SCNDTR = ""
        objEntidad.SRSTRC = ""
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.CULUSA = ConfigurationWizard.UserName
        objEntidad.NTRMNL = HelpClass.NombreMaquina
        objEntidad.CUSCRT = ConfigurationWizard.UserName
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = HelpClass.NombreMaquina
        objEntidad.CTPUNV = Me.txtUnidadVehicular.Codigo
        objEntidad.CFRAPG = Me.txtParametroPagar.Codigo
        objEntidad.CCMPN = mCCMPN

        Dim olbeDetalle_Cotizacion As Detalle_Cotizacion
        olbeDetalle_Cotizacion = objNegocios.Guardar_Detalle_Cotizacion(objEntidad)
        If olbeDetalle_Cotizacion.NCTZCN <> 0 Then
            ' Me.ListaDetalleCotizacion()
            Me.AccionCancelar()
            If HelpClass.RspMsgBox("¿Desea Cargar Servicios?") = MsgBoxResult.Yes Then
                Dim objfrmRegistroRutaContratos As New frmRegistroRutaContratos()
                With objfrmRegistroRutaContratos
                    .mNCTZCN = olbeDetalle_Cotizacion.NCTZCN
                    .mCCLNT = _mCCLNT
                    .mQMRCDR = olbeDetalle_Cotizacion.QMRCDR
                    .mPMRCDR = olbeDetalle_Cotizacion.PMRCDR
                    .mCMRCDR = olbeDetalle_Cotizacion.CMRCDR
                    .mCTPOSR = olbeDetalle_Cotizacion.CTPOSR
                    .mCTPSBS = olbeDetalle_Cotizacion.CTPSBS
                    .mNCRRCT = olbeDetalle_Cotizacion.NCRRCT
                    .mCCMPN = _mCCMPN
                    .mCDVSN = _mCDVSN
                    .mSESTCT = _mSESTCT
                    .HeaderDatos.Visible = Me.HeaderDatos.Visible
                    .objEntidadAcceso = objEntidadAcceso
                    .ShowDialog()
                End With
            End If
        Else
            HelpClass.ErrorMsgBox()
        End If
    End Sub

    Private Sub Modificar_Detalle_Cotizacion()
        Dim objEntidad As New Detalle_Cotizacion
        Dim objNegocios As New DetalleCotizacion_BLL

        objEntidad.NCTZCN = _mNCTZCN
        objEntidad.NCRRCT = obeDetalleCotizacion.NCRRCT
        objEntidad.CMRCDR = Me.txtMercaderia.Codigo
        objEntidad.CUNDMD = Me.txtUnidadMedida.Codigo
        objEntidad.CFRMPG = Me.txtParametroFacturacion.Codigo
        objEntidad.SSGRCT = Me.txtSeguroCotizacion.Codigo
        objEntidad.CCMPSG = IIf(Me.txtCiaSeguro.Codigo.ToString.Trim.Equals(""), 0, Me.txtCiaSeguro.Codigo)
        objEntidad.NPLSGC = IIf(Me.txtPolizaSeguro.Text.Equals("") = True, "0", Me.txtPolizaSeguro.Text)
        objEntidad.QPRCS1 = IIf(Me.txtRecargoSeguro.Text = "", "0", Me.txtRecargoSeguro.Text)
        objEntidad.QMRCDR = IIf(Me.txtCantidadMercaderia.Text.Equals("") = True, "0", txtCantidadMercaderia.Text)
        objEntidad.PMRCDR = IIf(Me.txtPesoMercaderia.Text.Equals("") = True, "0", Me.txtPesoMercaderia.Text)
        objEntidad.VMRCDR = IIf(Me.txtValorMercaderia.Text.Equals("") = True, "0", Me.txtValorMercaderia.Text)
        objEntidad.LMRCDR = IIf(Me.txtVolumenMercaderia.Text.Equals("") = True, "0", Me.txtVolumenMercaderia.Text)
        objEntidad.TRFMRC = Me.txtReferenciaMercaderia.Text
        objEntidad.SCNDTR = ""
        objEntidad.SRSTRC = ""
        objEntidad.CTPOSR = Me.txtTipoServicio.Codigo
        objEntidad.CTPSBS = Me.txtTipoSubServicio.Codigo
        objEntidad.CVPRCN = ""
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.CULUSA = ConfigurationWizard.UserName
        objEntidad.NTRMNL = HelpClass.NombreMaquina
        objEntidad.CUSCRT = ConfigurationWizard.UserName
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = HelpClass.NombreMaquina
        objEntidad.CTPUNV = Me.txtUnidadVehicular.Codigo
        objEntidad.CFRAPG = txtParametroPagar.Codigo
        objEntidad.CCMPN = mCCMPN
        Dim mensaje = objNegocios.Modificar_Detalle_Cotizacion(objEntidad)

        If mensaje.Trim.Equals("0") Then
            'Me.ListaDetalleCotizacion()
            Me.AccionCancelar()
        Else
            HelpClass.ErrorMsgBox()
        End If

    End Sub

    Private Sub EstadoGeneradoOS(ByVal bolEstado As Boolean)
        btnNuevo.Visible = bolEstado
        Separator1.Visible = bolEstado
        btnGuardar.Visible = bolEstado
        Separator2.Visible = bolEstado
        btnCancelar.Visible = bolEstado
    End Sub
#End Region

    Private Sub btnCerrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class
