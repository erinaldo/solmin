Imports System.Windows.Forms
Imports Ransa.Utilitario

Public Class frmRegistroRutaContratos

#Region "Atributos"

    Enum MANTENIMIENTO
        NEUTRAL = 0
        NUEVO = 1
        EDITAR = 2
        ELIMINAR = 3
        MODIFICAR = 4
    End Enum

    Dim objMercaderia As New mantenimientos.MercaderiaTransportes_BLL
    Dim objTipoServicioTransporte As New TipoServicioTransporte_BLL
    Private objServicioCotizacion As New ServicioCotizacion_BLL
    Dim objUnidadServicio As New UnidadMedida_BLL
    Dim objLocalidad As New Localidad_BLL
    Dim objMoneda As New Moneda_BLL
    Private gEnum_Mantenimiento As mantenimiento
    Dim lbooEstado As Boolean = True  ' Estado modificacion del mantenimiento
    Public objEntidadAcceso As New mantenimientos.ClaseGeneral
    Private bs As New Windows.Forms.BindingSource
#End Region

#Region "Propiedades"


    Private _pUsuario As String
    Public Property pUsuario() As String
        Get
            Return _pUsuario
        End Get
        Set(ByVal value As String)
            _pUsuario = value
        End Set
    End Property


    Private _mNCTZCN As Double = 0

    Public Property mNCTZCN() As Double
        Get
            Return _mNCTZCN
        End Get
        Set(ByVal value As Double)
            _mNCTZCN = value
        End Set
    End Property


    Private _mNCRRCT As Double = 0
    Public Property mNCRRCT() As Double
        Get
            Return _mNCRRCT
        End Get
        Set(ByVal value As Double)
            _mNCRRCT = value
        End Set
    End Property


    Private _mNCRRSR As Double
    Public Property mNCRRSR() As Double
        Get
            Return _mNCRRSR
        End Get
        Set(ByVal value As Double)
            _mNCRRSR = value
        End Set
    End Property


    Private _mCCLNT As Double = 0
    Public Property mCCLNT() As Double
        Get
            Return _mCCLNT
        End Get
        Set(ByVal value As Double)
            _mCCLNT = value
        End Set
    End Property
    '.mQMRCDR
    Private _mQMRCDR As Double = 0

    Public Property mQMRCDR() As Double
        Get
            Return _mQMRCDR
        End Get
        Set(ByVal value As Double)
            _mQMRCDR = value
        End Set
    End Property

    Private _mPMRCDR As Double = 0
    Public Property mPMRCDR() As Double
        Get
            Return _mPMRCDR
        End Get
        Set(ByVal value As Double)
            _mPMRCDR = value
        End Set
    End Property


    Private _mCMRCDR As String = ""
    Public Property mCMRCDR() As String
        Get
            Return _mCMRCDR
        End Get
        Set(ByVal value As String)
            _mCMRCDR = value
        End Set
    End Property


    Private _mCTPOSR As String = ""
    Public Property mCTPOSR() As String
        Get
            Return _mCTPOSR
        End Get
        Set(ByVal value As String)
            _mCTPOSR = value
        End Set
    End Property


    Private _mCTPSBS As String

    Public Property mCTPSBS() As String
        Get
            Return _mCTPSBS
        End Get
        Set(ByVal value As String)
            _mCTPSBS = value
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

    Private odtServiciosflete As DataTable
    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub frmRegistroRutaContratos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Carga la Lista de Servicios Tipo Flete
        Dim objNegocios As New ServicioMercaderia_BLL
        Dim objEntidad As New Hashtable
        objEntidad.Add("PSCCMPN", _mCCMPN)
        objEntidad.Add("PSCDVSN", _mCDVSN)
        odtServiciosflete = objNegocios.ListaServicioFlete(objEntidad)
        Alinear_Columnas_Grilla()
        CargarCombo()
        Me.txtCotizacion.Text = Me._mNCTZCN & " - " & _mNCRRCT
        Me.txtCliente.CCMPN = Me._mCCMPN
        Me.txtCliente.pCargar(Me._mCCLNT)
        Me.txtMercaderia.Codigo = _mCMRCDR
        Me.txtTipoServicio.Codigo = _mCTPOSR
        Listar_SubServicios()
        ListaServicioMercaderia()
        gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL

        Estado_Controles(False, PanelMantenimiento)
        EstadoGeneradoOS(mSESTCT.ToString.Trim.Equals("P"))
        '  EstadoGeneradoOS(True)
        Me.txtTipoSubServicio.Codigo = _mCTPSBS
        btnCancelar.Enabled = False
        btnGuardar.Enabled = False

        If Me.dtgServicio_Mercaderia.RowCount > 0 Then
            gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
            btnGuardar.Enabled = True
            btnGuardar.Text = "Modificar"
        End If


    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
        btnNuevo.Enabled = False
        btnGuardar.Text = "Guardar"
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnEliminar.Enabled = False
        Limpiar_Controles(Me.KryptonHeaderGroup1.Panel)
        Estado_Controles(True, PanelMantenimiento)
        tbPlanRuta.Parent = Nothing
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        'If Validar() Then
        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
            If Validar() Then
                If Not ValidarFleteRuta() Then
                    HelpClass.MsgBox("Existe una Ruta Asignada")
                    Exit Sub
                End If
                Guardar_Servicio_Mercaderia()
                tbPlanRuta.Parent = Nothing
                Limpiar_Controles(Me.KryptonHeaderGroup1.Panel)
            End If
           
        ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            If Validar() Then
                If Not (Me.txtServicioCotizacion.Codigo = dtgServicio_Mercaderia.CurrentRow.Cells("CSRCTZ").Value _
                             And dtgServicio_Mercaderia.CurrentRow.Cells("CLCLOR").Value = Me.txtLocalidadOrigen.Codigo _
                              And dtgServicio_Mercaderia.CurrentRow.Cells("CLCLDS").Value = Me.txtLocalidadDestino.Codigo) Then

                    If Not ValidarFleteRuta() Then
                        HelpClass.MsgBox("Existe una Ruta Asignada")
                        Exit Sub
                    End If
                End If

                Modificar_Servicio_Mercadia()
                EstadoGeneradoOS(mSESTCT.ToString.Trim.Equals("P"))
            End If

        ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
            Me.Estado_Controles(True, PanelMantenimiento, 0)
            btnGuardar.Text = "Guardar"
            btnNuevo.Enabled = False
            btnCancelar.Enabled = True
            btnEliminar.Enabled = False
            Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
        End If
        'End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If HelpClass.RspMsgBox("Desea eliminar este registro?") = MsgBoxResult.Yes Then
            Limpiar_Controles(Me.KryptonHeaderGroup1.Panel)
            Eliminar()
            If Me.dtgServicio_Mercaderia.RowCount = 0 Then
                btnEliminar.Enabled = False
                btnGuardar.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        AccionCancelar()
    End Sub

    Private Sub txtDistancia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDistancia.KeyPress, txtCostoPorTonelada.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(HelpClass.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        ListaServicioMercaderia()
    End Sub

    Private Sub txtServicioCotizacion_Texto_KeyEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtServicioCotizacion.Texto_KeyEnter
    If txtServicioCotizacion.NoHayCodigo Then Exit Sub
    Dim objNegocios As New ServicioMercaderia_BLL
    Dim objEntidadExiste As New ServicioMercaderia

    objEntidadExiste.CCMPN = Me._mCCMPN
    objEntidadExiste.CDVSN = Me._mCDVSN
    objEntidadExiste.CSRCTZ = Me.txtServicioCotizacion.Codigo

        If Not (objNegocios.Existe_Servicio(objEntidadExiste) = 1) Then 'Me.txtServicioCotizacion.Descripcion.ToString.Trim.Equals("FLETE") OrElse Me.txtServicioCotizacion.Descripcion.ToString.Trim.Equals("FLETES")) Then
            ValidarServicio(False)
        Else
            ValidarServicio(True)
        End If
  End Sub

    Private Sub txtTarifaServicio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTarifaServicio.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(HelpClass.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtImportePagarTransportista_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImportePagarTransportista.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(HelpClass.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub dtgServicio_Mercaderia_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgServicio_Mercaderia.CellClick
        If Me.dtgServicio_Mercaderia.CurrentCellAddress.Y < 0 Then Exit Sub
        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            If Me.dtgServicio_Mercaderia.Rows.Count > 0 Then
                lbooEstado = False
                Me.dtgServicio_Mercaderia.CurrentRow.Selected = False
            End If
            HelpClass.MsgBox("Debe guardar o cancelar.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        btnGuardar.Text = "Modificar"
        Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
        Limpiar_Controles(Me.KryptonHeaderGroup1.Panel)
        ListaDetalleServicioMercaderia()
        lbooEstado = True
        btnGuardar.Enabled = True
        EstadoGeneradoOS(mSESTCT.ToString.Trim.Equals("P"))
    End Sub

    Private Sub dtgServicio_Mercaderia_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgServicio_Mercaderia.SelectionChanged
        If Me.dtgServicio_Mercaderia.CurrentCellAddress.Y < 0 Then Exit Sub
        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            lbooEstado = False
        End If
        If lbooEstado Then ListaDetalleServicioMercaderia()
        Me.ListaPlanRuta()
    End Sub

    Private Sub TabSolicitudFlete_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabServicios.SelectedIndexChanged
        Select Case Me.TabServicios.SelectedIndex
            Case 0
                AccionCancelar()
                Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
                btnNuevoPlanRuta.Visible = False
                btnEliminarPlanRuta.Visible = False
                Separator4.Visible = False
                btnModificarPlanRuta.Visible = False
                Separator5.Visible = False
                Separator1.Visible = True
                Separator2.Visible = True
                Separator3.Visible = True
                btnNuevo.Visible = True
                btnGuardar.Visible = True
                btnGuardar.Enabled = True
                btnCancelar.Visible = True
                btnEliminar.Visible = True
                btnExportar.Visible = False
            Case 1
                Separator1.Visible = False
                Separator2.Visible = False
                Separator3.Visible = False
                btnNuevo.Visible = False
                btnGuardar.Visible = False
                btnCancelar.Visible = False
                btnEliminar.Visible = False
                btnNuevoPlanRuta.Visible = True
                btnEliminarPlanRuta.Visible = True
                Separator4.Visible = True
                btnModificarPlanRuta.Visible = True
                btnModificarPlanRuta.Enabled = False
                btnEliminarPlanRuta.Enabled = False
                Separator5.Visible = True
                btnExportar.Visible = True
                Me.ListaPlanRuta()
        End Select
    End Sub

    Private Sub ListaPlanRuta()
        If dtgServicio_Mercaderia.RowCount = 0 Then Exit Sub
        Dim objPlanRuta As New PlanRuta_BLL
        Dim objEntidad As New Operaciones.PlanRuta
        objEntidad.PNNCTZCN = mNCTZCN
        objEntidad.PNNCRRCT = mNCRRCT
        objEntidad.PNNCRRSR = dtgServicio_Mercaderia.CurrentRow.Cells("NCRRSR").Value
        objEntidad.PSCCMPN = _mCCMPN
        dtgPlanruta.AutoGenerateColumns = False
        dtgPlanruta.DataSource = objPlanRuta.Listar_PlanRutaInicial(objEntidad)
    End Sub
#End Region

#Region "Metodos"

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
            Me.Separator3.Visible = False
        End If
        If objEntidadAcceso.STSELI = "" Then
            Me.btnEliminar.Visible = False
            Me.Separator3.Visible = False
        End If
    End Sub

    Private Sub Alinear_Columnas_Grilla()
        For lint_contador As Integer = 0 To Me.dtgServicio_Mercaderia.ColumnCount - 1
            Me.dtgServicio_Mercaderia.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub

    Private Sub CargarCombo()
        Dim dtTableMoneda As New DataTable
        Dim dtTableLocalidad As New DataTable
        Dim objDt As New DataTable
        dtTableMoneda = objMoneda.Listar_Monedas_Combo(_mCCMPN)
        dtTableLocalidad = objLocalidad.Listar_Localidades_Combo(_mCCMPN)
        Dim obj_Logica_Ubigeo As New mantenimientos.LocalidadRuta_BLL

        With Me.txtMercaderia
            .DataSource = objMercaderia.Busca_MercaderiaTransportesBuscar(_mCCMPN)
            .KeyField = "CMRCDR"
            .ValueField = "TCMRCD"
            .DataBind()
        End With

        With Me.txtTipoServicio
            .DataSource = objTipoServicioTransporte.Listar_Tipo_Servicio_Combo(_mCCMPN)
            .KeyField = "CTPOSR"
            .ValueField = "TCMTPS"
            .DataBind()
        End With

        Dim objentidad As New mantenimientos.ServicioCotizacion
        objentidad.CCMPN = _mCCMPN
        objentidad.CDVSN = _mCDVSN
        With Me.txtServicioCotizacion
            .DataSource = objServicioCotizacion.Listar_Servicio_Cotizacion(objentidad)
            .KeyField = "CSRVNV"
            .ValueField = "TCMTRF"
            .DataBind()
        End With

        With Me.txtUnidadServicioAdicional
            .DataSource = objUnidadServicio.Listar_Unidad_Medida_Combo(_mCCMPN)
            .KeyField = "CUNDMD"
            .ValueField = "TCMPUN"
            .DataBind()
        End With

        With Me.txtLocalidadDestino
            .DataSource = dtTableLocalidad.Copy
            .KeyField = "CLCLD"
            .ValueField = "TCMLCL"
            .DataBind()
        End With

        With Me.txtLocalidadOrigen
            .DataSource = dtTableLocalidad.Copy
            .KeyField = "CLCLD"
            .ValueField = "TCMLCL"
            .DataBind()
        End With

        With Me.txtMonedaLiquidacion
            .DataSource = dtTableMoneda.Copy
            .KeyField = "CMNDA1"
            .ValueField = "TMNDA"
            .DataBind()
        End With

        With Me.txtMonedaLiquidacionTransportista
            .DataSource = dtTableMoneda.Copy
            .KeyField = "CMNDA1"
            .ValueField = "TMNDA"
            .DataBind()
        End With

        objDt = obj_Logica_Ubigeo.Listar_Ubigeo(_mCCMPN) 'Me.cboCompania.SelectedValue.ToString.Trim)

      With Me.cboOrigenUbigeo
        .DataSource = objDt.Copy
        .KeyField = "UBIGEO"
        .ValueField = "DESCRIPCION"
        .DataBind()
      End With

        With Me.cboDestinoUbigeo
            .DataSource = objDt.Copy
            .KeyField = "UBIGEO"
            .ValueField = "DESCRIPCION"
            .DataBind()
        End With

    End Sub

    Private Sub Listar_SubServicios()
        Dim objEntidad As New TipoServicioTransporte
        Dim objSubServicio As New TipoSubServicioTransporte_BLL

        objEntidad.CTPOSR = Me.txtTipoServicio.Codigo
        objEntidad.CCMPN = _mCCMPN
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
        'objEntidad = Nothing
        'objSubServicio = Nothing
    End Sub

    '================METODOS DE MANTENIMIENTO=============

    Private Function ValidarFleteRuta() As Boolean



            'Valida si el Servicio Seleccionado es de Tipo Flete
            Dim dr As DataRow()
            dr = odtServiciosflete.Select("CSRVC =" & Me.txtServicioCotizacion.Codigo)
            Dim EsPlanRuta As Boolean = False
            For Each drItem As DataRow In dr
                EsPlanRuta = True
            Next

            If dr.Length > 0 Then
                'Valida que el servicio Flete sean de rutas distintas
                Dim objNegocios As New ServicioMercaderia_BLL
                Dim objEntidad, objEntidadExiste As New ServicioMercaderia
                objEntidad.CCMPN = Me._mCCMPN
                objEntidad.NCTZCN = Me._mNCTZCN
                objEntidad.NCRRCT = Me._mNCRRCT
                objEntidad.CLCLOR = Me.txtLocalidadOrigen.Codigo
                objEntidad.CLCLDS = Me.txtLocalidadDestino.Codigo

                If EsPlanRuta Then
                    'Valida que el servicio Flete sean de rutas distintas
                    If objNegocios.Existe_FleteRuta(objEntidad) = 1 Then
                        Return False
                    Else
                        Return True
                    End If
                Else
                    Return True
                End If
            Else
                Return True
            End If


    End Function

    Private Function Validar() As Boolean
        Dim strError As String = "DEBE DE INGRESAR: " & Chr(13)

        If Me.mNCTZCN = 0 Then
            strError += "* Cotizacion"
        End If
        If Me._mNCRRCT.ToString.Trim.Equals(0) = True Then
            strError += "* Detalle "
        End If
        If Me.txtServicioCotizacion.NoHayCodigo = True Then
            strError += "* Servicio de cotización" & Chr(13)
        End If
        If txtServicioCotizacion.NoHayCodigo OrElse txtServicioCotizacion.Codigo = 1 Then
            If Me.txtLocalidadOrigen.NoHayCodigo = True OrElse txtLocalidadOrigen.Codigo = 0 Then
                strError += "* Localidad de origen" & Chr(13)
            End If
            If Me.txtLocalidadDestino.NoHayCodigo = True OrElse Me.txtLocalidadDestino.Codigo = 0 Then
                strError += "* Localidad de destino" & Chr(13)
            End If
            If Me.cboOrigenUbigeo.NoHayCodigo = True OrElse cboOrigenUbigeo.Codigo = 0 Then
                strError += "* Ubigeo Origen" & Chr(13)
            End If

            If Me.cboDestinoUbigeo.NoHayCodigo = True OrElse cboDestinoUbigeo.Codigo = 0 Then
                strError += "* Ubigeo Destino" & Chr(13)
            End If
            If txtDistancia.Text.Trim.Length = 0 OrElse txtDistancia.Text.Trim.Equals("0") Then
                strError += "* Distancia virtual" & Chr(13)
            End If
        End If

        If Me.txtUnidadServicioAdicional.NoHayCodigo = True Then
            strError += "* Unidad de servicio adicional" & Chr(13)
        End If

        If Me.txtTarifaServicio.Text.Equals("") = True Or IsNumeric(Me.txtTarifaServicio.Text) = False Then
            strError += "* Importe de Tarifa de servicios" & Chr(13)
        End If
        If Me.txtMonedaLiquidacion.NoHayCodigo = True Then
            strError += "* Moneda de Tarifa de servicios" & Chr(13)
        End If
        If txtServicioCotizacion.NoHayCodigo OrElse txtServicioCotizacion.Codigo = 1 Then
            If Me.txtImportePagarTransportista.Text.Equals("") = True OrElse IsNumeric(Me.txtImportePagarTransportista.Text) = False Then
                strError += "* Importe de liquidación " & Chr(13)
            End If
            If Me.txtMonedaLiquidacionTransportista.NoHayCodigo = True Then
                strError += "* Moneda de importe de liquidación" & Chr(13)
            End If
        End If
        If strError.Trim.Length > 17 Then
            HelpClass.MsgBox(strError, MessageBoxIcon.Warning)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub AccionCancelar()
        Select Case Me.gEnum_Mantenimiento
            Case MANTENIMIENTO.NUEVO
                tbPlanRuta.Parent = Nothing
                If Me.dtgServicio_Mercaderia.Rows.Count > 0 Then
                    Me.dtgServicio_Mercaderia.CurrentRow.Selected = False
                End If
                Estado_Controles(False, PanelMantenimiento)
                gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
                btnNuevo.Enabled = True
                btnGuardar.Enabled = False
                btnCancelar.Enabled = False
                btnEliminar.Enabled = False
            Case MANTENIMIENTO.EDITAR
                Estado_Controles(False, PanelMantenimiento)
                gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
                btnNuevo.Enabled = True
                btnGuardar.Enabled = True
                btnGuardar.Text = "Modificar"
                btnCancelar.Enabled = False
                EstadoGeneradoOS(mSESTCT.ToString.Trim.Equals("P"))
            Case Else
        End Select
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

    Public Sub Limpiar_Controles(ByVal Contenedor As Object, Optional ByVal intTipo As Integer = 0)
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
                If TypeOf X Is ComponentFactory.Krypton.Toolkit.KryptonRadioButton Then CType(X, ComponentFactory.Krypton.Toolkit.KryptonRadioButton).Checked = False
                If TypeOf X Is RadioButton Then CType(X, RadioButton).Checked = False
                If TypeOf X Is ComboBox Then CType(X, ComboBox).SelectedIndex = -1
                If TypeOf X Is DateTimePicker Then CType(X, DateTimePicker).Value = Now
            Next
        End If
        Me.rbtFijo.Checked = True
    End Sub

    Private Sub Guardar_Servicio_Mercaderia()
        Dim objNegocios As New ServicioMercaderia_BLL
        Dim objEntidad, objEntidadExiste As New ServicioMercaderia

        objEntidad.NCTZCN = Me._mNCTZCN
        objEntidad.NCRRCT = Me._mNCRRCT
        objEntidad.CSRCTZ = Me.txtServicioCotizacion.Codigo
        objEntidad.CMRCDR = Me.txtMercaderia.Codigo
        objEntidad.TOBSSR = Me.txtObservaciones.Text

        objEntidadExiste.CCMPN = Me._mCCMPN
        objEntidadExiste.CDVSN = Me._mCDVSN
        objEntidadExiste.CSRCTZ = Me.txtServicioCotizacion.Codigo

        If objNegocios.Existe_Servicio(objEntidadExiste) = 1 Then 'Me.txtServicioCotizacion.Descripcion.ToString.Trim.Equals("FLETE") OrElse Me.txtServicioCotizacion.Descripcion.ToString.Trim.Equals("FLETES")) Then

            objEntidad.CUBORI = Me.cboOrigenUbigeo.Codigo
            objEntidad.CUBDES = Me.cboDestinoUbigeo.Codigo
            objEntidad.CLCLOR = Me.txtLocalidadOrigen.Codigo
            objEntidad.CLCLDS = Me.txtLocalidadDestino.Codigo
            objEntidad.QDSTVR = Me.txtDistancia.Text
            objEntidad.CSTNDT = IIf(IsNumeric(Me.txtCostoPorTonelada.Text.Trim), txtCostoPorTonelada.Text, 0)
            objEntidad.ILCFTR = IIf(Me.txtImportePagarTransportista.Text.Trim.Length = 0, 0, Me.txtImportePagarTransportista.Text)
            objEntidad.ILQFMX = IIf(Me.txtImportePagarTransportista.Text.Trim.Length = 0, 0, Me.txtImportePagarTransportista.Text)
            objEntidad.ILQSMT = IIf(Me.txtImportePagarTransportista.Text.Trim.Length = 0, 0, Me.txtImportePagarTransportista.Text)
            objEntidad.SFCRTV = IIf(Me.ckbRetornoVacio.Checked = True, "I", "V")
        End If
        objEntidad.ITRSRT = Me.txtTarifaServicio.Text
        objEntidad.CMNTRN = Me.txtMonedaLiquidacion.Codigo
        objEntidad.QIMFCD = 0
        objEntidad.QIMFCS = 0
        objEntidad.CMNLQT = IIf(Me.txtMonedaLiquidacionTransportista.Codigo = vbNullString, 0, txtMonedaLiquidacionTransportista.Codigo)
        objEntidad.ILSFTR = IIf(Me.txtImportePagarTransportista.Text.Trim.Length = 0, 0, Me.txtImportePagarTransportista.Text)
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.CULUSA = _pUsuario
        objEntidad.NTRMNL = HelpClass.NombreMaquina
        objEntidad.CUSCRT = _pUsuario
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = HelpClass.NombreMaquina
        objEntidad.CUNSRA = Me.txtUnidadServicioAdicional.Codigo
        objEntidad.SSRVCB = IIf(txtTarifaServicio.Text.Trim.Length > 0, "X", "")
        objEntidad.SSRVPG = IIf(txtImportePagarTransportista.Text.Trim.Length > 0, "X", "")
        objEntidad.SSRVFE = IIf(Me.rbtFijo.Checked, "F", "E")
        objEntidad.CCMPN = _mCCMPN

        If objNegocios.Guardar_Servicio_Mercadia(objEntidad).NCTZCN.ToString.Trim.Equals("0") Then
            HelpClass.MsgBox("Error al guardar")
        Else
            ListaServicioMercaderia()
            Me.AccionCancelar()
        End If
    End Sub

    Private Sub Modificar_Servicio_Mercadia()
        Dim objNegocios As New ServicioMercaderia_BLL
        Dim objEntidad, objEntidadExiste As New ServicioMercaderia

        objEntidad.NCTZCN = Me._mNCTZCN
        objEntidad.NCRRCT = Me._mNCRRCT
        objEntidad.NCRRSR = Me._mNCRRSR
        objEntidad.CSRCTZ = Me.txtServicioCotizacion.Codigo
        objEntidad.CMRCDR = Me.txtMercaderia.Codigo
        objEntidad.TOBSSR = Me.txtObservaciones.Text

        objEntidadExiste.CCMPN = Me._mCCMPN
        objEntidadExiste.CDVSN = Me._mCDVSN
        objEntidadExiste.CSRCTZ = Me.txtServicioCotizacion.Codigo

        If objNegocios.Existe_Servicio(objEntidadExiste) = 1 Then '(Me.txtServicioCotizacion.Descripcion.ToString.Trim.Equals("FLETE") OrElse Me.txtServicioCotizacion.Descripcion.ToString.Trim.Equals("FLETES")) Then
            objEntidad.CLCLOR = Me.txtLocalidadOrigen.Codigo
            objEntidad.CLCLDS = Me.txtLocalidadDestino.Codigo
            objEntidad.CUBORI = Me.cboOrigenUbigeo.Codigo
            objEntidad.CUBDES = Me.cboDestinoUbigeo.Codigo

            objEntidad.QDSTVR = Me.txtDistancia.Text
            objEntidad.CSTNDT = IIf(IsNumeric(Me.txtCostoPorTonelada.Text.Trim), txtCostoPorTonelada.Text, 0)
            objEntidad.ILCFTR = IIf(Me.txtImportePagarTransportista.Text.Trim.Length = 0, 0, Me.txtImportePagarTransportista.Text)
            objEntidad.ILQFMX = IIf(Me.txtImportePagarTransportista.Text.Trim.Length = 0, 0, Me.txtImportePagarTransportista.Text)
            objEntidad.ILQSMT = IIf(Me.txtImportePagarTransportista.Text.Trim.Length = 0, 0, Me.txtImportePagarTransportista.Text)
            objEntidad.SFCRTV = IIf(Me.ckbRetornoVacio.Checked = True, "I", "V")
        End If
        objEntidad.ITRSRT = Me.txtTarifaServicio.Text
        objEntidad.CMNTRN = Me.txtMonedaLiquidacion.Codigo
        objEntidad.CMNLQT = Me.txtMonedaLiquidacionTransportista.Codigo
        objEntidad.ILSFTR = Me.txtImportePagarTransportista.Text
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.CULUSA = _pUsuario
        objEntidad.NTRMNL = HelpClass.NombreMaquina
        objEntidad.CUNSRA = Me.txtUnidadServicioAdicional.Codigo
        objEntidad.SSRVFE = IIf(Me.rbtFijo.Checked, "F", "E")
        objEntidad.SSRVCB = IIf(txtTarifaServicio.Text.Trim.Length > 0, "X", "")
        objEntidad.SSRVPG = IIf(txtImportePagarTransportista.Text.Trim.Length > 0, "X", "")
        objEntidad.CCMPN = _mCCMPN
        objEntidad.CUSCRT = _pUsuario
        If objNegocios.Modificar_Servicio_Mercadia(objEntidad).Trim.Equals("0") Then
            HelpClass.MsgBox("Error al guardar ")
        Else
            ListaServicioMercaderia()
            Me.AccionCancelar()
        End If
    End Sub

    '===============FIN METODO MANTENIMIENTO =====================

    Private Sub EstadoGeneradoOS(ByVal bolEstado As Boolean)
        btnEliminar.Enabled = bolEstado
        Validar_Acceso_Opciones_Usuario()
    End Sub

    Private Sub ValidarServicio(ByVal bolEstado As Boolean)
        Me.txtLocalidadOrigen.Visible = bolEstado
        Me.txtLocalidadDestino.Visible = bolEstado
        Me.txtDistancia.Visible = bolEstado
        Me.txtCostoPorTonelada.Visible = bolEstado
        Me.ckbRetornoVacio.Visible = bolEstado
        Me.lblLocalidadOrigen.Visible = bolEstado
        Me.lblLocalidadDestino.Visible = bolEstado
        Me.lblDistanciaKM.Visible = bolEstado
        Me.lblDetraccion.Visible = bolEstado
        Me.cboOrigenUbigeo.Visible = bolEstado
        Me.cboDestinoUbigeo.Visible = bolEstado
        Me.KryptonLabel1.Visible = bolEstado
        Me.KryptonLabel44.Visible = bolEstado

    End Sub

    Private Sub ListaServicioMercaderia()
        Dim objNegocios As New ServicioMercaderia_BLL
        Dim objEntidad As New Hashtable
        objEntidad.Add("NCTZCN", _mNCTZCN)
        objEntidad.Add("NCRRCT", _mNCRRCT)
        objEntidad.Add("CCMPN", _mCCMPN)
        dtgServicio_Mercaderia.AutoGenerateColumns = False
        bs.DataSource = HelpClass.GetDataSetNative(objNegocios.ListaDetalleCotizacion(objEntidad))
        dtgServicio_Mercaderia.DataSource = bs 'HelpClass.GetDataSetNative(objNegocios.ListaDetalleCotizacion(objEntidad))
    End Sub

    Private Sub ListaDetalleServicioMercaderia()

        With dtgServicio_Mercaderia.CurrentRow
            Me.HeaderDatos.ValuesPrimary.Heading = "Número de cotización :" & Me._mNCTZCN & " - " & _mNCRRCT & " - " & .Cells("NCRRSR").Value & " / Cliente :" & txtCliente.pRazonSocial
            _mNCRRSR = .Cells("NCRRSR").Value
            Me.txtServicioCotizacion.Codigo = IIf(.Cells("CSRCTZ").Value.ToString.Equals("") = True, "0", .Cells("CSRCTZ").Value)
            Me.txtObservaciones.Text = .Cells("TOBSSR").Value
            Me.txtLocalidadOrigen.Codigo = IIf(.Cells("CLCLOR").Value.ToString.Equals("") = True, "0", .Cells("CLCLOR").Value)
            Me.txtLocalidadDestino.Codigo = IIf(.Cells("CLCLDS").Value.ToString.Equals("") = True, "0", .Cells("CLCLDS").Value)
            Me.txtTarifaServicio.Text = .Cells("ITRSRT").Value
            Me.txtMonedaLiquidacion.Codigo = IIf(.Cells("CMNTRN").Value.ToString.Equals("") = True, "0", .Cells("CMNTRN").Value)
            Me.txtMonedaLiquidacionTransportista.Codigo = IIf(.Cells("CMNLQT").Value.ToString.Equals("") = True, "0", .Cells("CMNLQT").Value)
            Me.txtImportePagarTransportista.Text = .Cells("ILSFTR").Value
            Me.txtUnidadServicioAdicional.Codigo = IIf(.Cells("CUNSRA").Value.Equals("") = True, "0", .Cells("CUNSRA").Value)
            Me.txtDistancia.Text = .Cells("QDSTVR").Value
            Me.txtCostoPorTonelada.Text = .Cells("CSTNDT").Value
            Me.ckbRetornoVacio.Checked = IIf(.Cells("SFCRTV").Value.Equals("I"), True, False)
            Me.rbtFijo.Checked = .Cells("SSRVFE").Value.ToString.Equals("F")
            Me.rbtEventual.Checked = .Cells("SSRVFE").Value.ToString.Equals("E")

            Me.cboOrigenUbigeo.Codigo = IIf(.Cells("CUBORI").Value.ToString.Equals("") = True, "0", .Cells("CUBORI").Value)
            Me.cboDestinoUbigeo.Codigo = IIf(.Cells("CUBDES").Value.ToString.Equals("") = True, "0", .Cells("CUBDES").Value)

        End With

        'Valida si el Servicio Seleccionado es de Tipo Flete
        Dim dr As DataRow()
        dr = odtServiciosflete.Select("CSRVC =" & Me.txtServicioCotizacion.Codigo)
        Dim EsPlanRuta As Boolean = False
        For Each drItem As DataRow In dr
            EsPlanRuta = True
        Next

        If EsPlanRuta Then
            tbPlanRuta.Parent = TabServicios
        Else
            tbPlanRuta.Parent = Nothing
        End If
    End Sub

    Private Sub Eliminar()
        Dim oblServicioMercaderia As New ServicioMercaderia_BLL
        Dim obeServicioMercaderia As New ServicioMercaderia
        With Me.dtgServicio_Mercaderia.CurrentRow
            obeServicioMercaderia.NCTZCN = mNCTZCN
            obeServicioMercaderia.NCRRCT = mNCRRCT
            obeServicioMercaderia.NCRRSR = .Cells("NCRRSR").Value
            obeServicioMercaderia.CCMPN = _mCCMPN
        End With
        If oblServicioMercaderia.Eliminar(obeServicioMercaderia) = 0 Then
            ListaServicioMercaderia()
        Else
            HelpClass.ErrorMsgBox()
        End If
    End Sub

#End Region


    Private Sub btnNuevoPlanRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoPlanRuta.Click
        Try
            Dim frm As New frmAsignarPlanRuta()
            Dim obeServicioMercaderia As New ServicioMercaderia
            With Me.dtgServicio_Mercaderia.CurrentRow
                obeServicioMercaderia.NCTZCN = mNCTZCN
                obeServicioMercaderia.NCRRCT = mNCRRCT
                obeServicioMercaderia.NCRRSR = .Cells("NCRRSR").Value
                obeServicioMercaderia.CCMPN = _mCCMPN
            End With
            frm.ObjServicioMercaderia = obeServicioMercaderia
            frm.TipoOperacion = frmAsignarPlanRuta.TIPO.ASIGNAR
            frm.TipoPlanRuta = frmAsignarPlanRuta.TIPO_PLAN.INICIAL
            frm.pUsuario = _pUsuario

            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.ListaPlanRuta()
                btnModificarPlanRuta.Enabled = False
                btnEliminarPlanRuta.Enabled = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dtgRecursosAsignados_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgPlanruta.CellClick
        If Me.dtgPlanruta.CurrentCellAddress.Y < 0 Then Exit Sub
        btnModificarPlanRuta.Text = "Modificar"
        btnModificarPlanRuta.Enabled = True
        btnEliminarPlanRuta.Enabled = True

    End Sub

    Private Sub btnModificarPlanRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarPlanRuta.Click
        Try
            Dim frm As New frmAsignarPlanRuta()
            Dim ObjPlanruta As New Operaciones.PlanRuta
            With Me.dtgPlanruta.CurrentRow
                ObjPlanruta.PNNCTZCN = mNCTZCN
                ObjPlanruta.PNNCRRCT = mNCRRCT
                ObjPlanruta.PNNCRRSR = Me.dtgServicio_Mercaderia.CurrentRow.Cells("NCRRSR").Value
                ObjPlanruta.PSCCMPN = _mCCMPN
                ObjPlanruta.PNNCRRIT = .Cells("NCRRIT").Value

                ObjPlanruta.PNCLCLD = .Cells("CLCLD").Value
                ObjPlanruta.PNFECSEG = .Cells("_FECSEG").Value
                ObjPlanruta.PNHRASEG = .Cells("_HRASEG").Value
                ObjPlanruta.PNQDSTVR = .Cells("QDSTVR_D").Value
                ObjPlanruta.PSTOBS = .Cells("_TOBS").Value
                ObjPlanruta.PSSIDAVL = "I"
                ObjPlanruta.PSTPOREG = "P"
            End With

            frm.ObjPlanRuta = ObjPlanruta
            frm.TipoOperacion = frmAsignarPlanRuta.TIPO.MODIFICAR
            frm.TipoPlanRuta = frmAsignarPlanRuta.TIPO_PLAN.INICIAL
            frm.pUsuario = _pUsuario
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.ListaPlanRuta()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnEliminarPlanRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarPlanRuta.Click
        If HelpClass.RspMsgBox("Desea eliminar este registro?") = MsgBoxResult.Yes Then
            Dim ObjPlanruta As New Operaciones.PlanRuta
            With Me.dtgPlanruta.CurrentRow
                ObjPlanruta.PNNCTZCN = mNCTZCN
                ObjPlanruta.PNNCRRCT = mNCRRCT
                ObjPlanruta.PNNCRRSR = Me.dtgServicio_Mercaderia.CurrentRow.Cells("NCRRSR").Value
                ObjPlanruta.PSCCMPN = _mCCMPN
                ObjPlanruta.PNNCRRIT = .Cells("NCRRIT").Value
                ObjPlanruta.PSUSRCRT = _pUsuario
                ObjPlanruta.PSNTRMCR = HelpClass.NombreMaquina
            End With

            Dim objPlanRuta_Bl As New PlanRuta_BLL
            If objPlanRuta_Bl.Elimina_PlanRutaInicial(ObjPlanruta) = 1 Then
                Me.ListaPlanRuta()
                If Me.dtgPlanruta.RowCount = 0 Then
                    btnEliminarPlanRuta.Enabled = False
                End If
            Else
                HelpClass.ErrorMsgBox()
            End If
        End If
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Try
            If dtgPlanruta.Rows.Count <= 0 Then
                MessageBox.Show("No hay datos para procesar. Primero debe de procesar su reporte", "Mostrar Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim ODs As New DataSet
            Dim objDt As New DataTable
            Dim loEncabezados As New Generic.List(Of Encabezados)
            'Envia los Parametros para la exportacion
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "PLAN DE RUTA INICIAL"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "PLAN DE RUTA INICIAL"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "PLAN DE RUTA - INICIAL"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
            objDt = CType(Me.dtgPlanruta.DataSource, DataTable).Copy
            ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(Me.dtgPlanruta, objDt))
            For Each dc As DataColumn In ODs.Tables(0).Columns
                Select Case dc.Caption
                    Case "TCMLCL", "TOBS", "TPOREG"
                        dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)
                    Case "QDSTVR_STRG"
                        dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_INTEGER)
                End Select
            Next
            HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)

        Catch ex As Exception
        End Try
    End Sub
End Class
