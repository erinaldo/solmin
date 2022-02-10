Imports Ransa.Controls.Operaciones
Imports Ransa.Controls.mantenimientos
Imports System.Windows.Forms

Public Class frmCrearOsManual

#Region "Variables"


    Private _pUsuario As String
    Public Property pUsuario() As String
        Get
            Return _pUsuario
        End Get
        Set(ByVal value As String)
            _pUsuario = value
        End Set
    End Property


    Public obeCotizacion As New Cotizacion
    Private objMoneda As New Moneda_BLL
    Public obeDetalleCotizacion As New Detalle_Cotizacion
    Private gEnum_Mantenimiento As MANTENIMIENTO

    Enum MANTENIMIENTO
        NEUTRAL = 0
        NUEVO = 1
        EDITAR = 2
        ELIMINAR = 3
        MODIFICAR = 4
    End Enum

#End Region

#Region "Propiedades"
  Private _NORSRT As Double = 0

  ''' <summary>
  ''' Orden de Servicio
  ''' </summary>
  ''' <remarks></remarks>
  ''' 

  Public ReadOnly Property NORSRT() As Double
    Get
      Return _NORSRT
    End Get
  End Property

#End Region

  Private Sub frmCrearOsManual_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue
        txtCliente.pUsuario = _pUsuario
    txtCliente.pCargar(obeCotizacion.CCLNT)
    CargarCombo_Cotizacion()
    Cargar_Combos_Mercaderia()
    CargarCombo_Servicio_Cotizacion()
    Me.HeaderGroupDealleCcotizacion.Enabled = False
  End Sub

  Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoCotizacion.Click
    EstadoCotizacion()
    NuevaCotizacion()
    gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
    btnNuevoCotizacion.Enabled = True
    btnGuardarCotizacion.Enabled = False
    btnCancelarCotizacion.Enabled = False
  End Sub

  Private Sub NuevaCotizacion(Optional ByVal intTipo As Integer = 0)
    If intTipo = 0 Then
      obeCotizacion.CCLNT = Me.txtCliente.pCodigo
      txtNrCotizacion.Text = ""
      txtPlantaFacturacion.Codigo = 1
      cmbMoneda.Codigo = 1
      txtNroContrato.Text = ""
      txtContacto.Text = ""
      cmbTipoCobro.SelectedValue = "R"
    Else
      txtNrCotizacion.Text = ""
      txtPlantaFacturacion.Limpiar()
      cmbMoneda.Limpiar()
      txtNroContrato.Text = ""
      txtContacto.Text = ""
      cmbTipoCobro.SelectedIndex = -1
    End If
  End Sub

  Private Sub EstadoCotizacion(Optional ByVal boEstado As Boolean = True)
    Me.txtCliente.Enabled = True
    btnBuscarCotizacion.Enabled = Not boEstado
    txtNrCotizacion.Enabled = Not boEstado
    txtPlantaFacturacion.Enabled = boEstado
    cmbMoneda.Enabled = boEstado
    txtNroContrato.Enabled = boEstado
    txtContacto.Enabled = boEstado
    cmbTipoCobro.Enabled = boEstado
  End Sub

  Private Sub btnGuardarCotizacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarCotizacion.Click
    obeCotizacion.CCLNT = Me.txtCliente.pCodigo
    If Validar_Cotizacion() Then
      GuardarCotizacion()
    End If

  End Sub

  Private Sub GuardarCotizacion()
    Dim objNegocios As New Cotizacion_BLL

    With obeCotizacion

      .CMNDA = Me.cmbMoneda.Codigo
      .FCTZCN = HelpClass.CtypeDate(Now.Date)
      .FVGCTZ = HelpClass.CtypeDate(Now.Date)
      .TCNCLC = Me.txtContacto.Text
      .NCNTRT = Me.txtNroContrato.Text
      .FULTAC = HelpClass.TodayNumeric
      .HULTAC = HelpClass.NowNumeric
            .CULUSA = _pUsuario
      .NTRMNL = HelpClass.NombreMaquina
            .CUSCRT = _pUsuario
      .FCHCRT = HelpClass.TodayNumeric
      .HRACRT = HelpClass.NowNumeric
      .NTRMCR = HelpClass.NombreMaquina
      .CPLNFC = Me.txtPlantaFacturacion.Codigo
      .SFSANF = 1
      .SCBRMD = IIf(Me.cmbTipoCobro.SelectedIndex = 0, "R", "D")
    End With
    Dim olbeCotizacion As List(Of Cotizacion)
    olbeCotizacion = objNegocios.Guardar_Cotizacion(obeCotizacion)
    If olbeCotizacion.Count > 0 Then
      EstadoCotizacion(False)
      Me.txtNrCotizacion.Text = olbeCotizacion.Item(0).NCTZCN.ToString
      Me.HeaderGroupDealleCcotizacion.Enabled = True
      Me.HeaderGroupCotizacion.Panel.Enabled = False
      btnNuevoCotizacion.Enabled = True
      btnCancelarCotizacion.Enabled = True
      btnGuardarCotizacion.Enabled = True
      Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
    Else
      HelpClass.ErrorMsgBox()
    End If
  End Sub

  Private Function Validar_Cotizacion() As Boolean
    Dim strError As String = "DEBE DE INGRESAR: " & Chr(13)
    If Me.cmbMoneda.NoHayCodigo = True Then
      strError += "* Moneda" & Chr(13)
    End If
    If obeCotizacion.CCLNT.Trim.Equals("0") Then
      strError += "* Cliente" & Chr(13)
    End If
    If Me.txtPlantaFacturacion.NoHayCodigo Then
      strError += "* Planta Facturación" & Chr(13)
    End If
    If Me.cmbTipoCobro.SelectedValue = Nothing Then
      strError += "* Tipo de cobro" & Chr(13)
    End If
    If strError.Trim.Length > 17 Then
      HelpClass.MsgBox(strError, MessageBoxIcon.Warning)
      Return False
    Else
      Return True
    End If
  End Function

  Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
    Guardar()
  End Sub

  Private Sub Guardar()
    If Validar() Then
      Guardar_DetalleCotizacion()
    End If
  End Sub

  Private Sub Guardar_DetalleCotizacion()
    Dim objEntidad As New Detalle_Cotizacion
    Dim objNegocios As New DetalleCotizacion_BLL

    objEntidad.NCTZCN = Me.txtNrCotizacion.Text
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
        objEntidad.CULUSA = _pUsuario
    objEntidad.NTRMNL = HelpClass.NombreMaquina
        objEntidad.CUSCRT = _pUsuario
    objEntidad.FCHCRT = HelpClass.TodayNumeric
    objEntidad.HRACRT = HelpClass.NowNumeric
    objEntidad.NTRMCR = HelpClass.NombreMaquina
    objEntidad.CTPUNV = Me.txtUnidadVehicular.Codigo
    objEntidad.CFRAPG = Me.txtParametroPagar.Codigo

    Dim obeDetalle_Cotizacion As New Detalle_Cotizacion
    obeDetalle_Cotizacion = objNegocios.Guardar_Detalle_Cotizacion(objEntidad)
    If obeDetalle_Cotizacion.NCTZCN <> 0 Then
      Guardar_Servicio_Mercaderia(obeDetalle_Cotizacion)
    Else
      HelpClass.ErrorMsgBox()
    End If
  End Sub

  Private Sub Guardar_Servicio_Mercaderia(ByVal obeDetalle_Cotizacion As Detalle_Cotizacion)
    Dim objNegocios As New ServicioMercaderia_BLL
    Dim objEntidad As New ServicioMercaderia

    objEntidad.NCTZCN = obeDetalle_Cotizacion.NCTZCN
    objEntidad.NCRRCT = obeDetalle_Cotizacion.NCRRCT
    objEntidad.CSRCTZ = Me.txtServicioCotizacion.Codigo
    objEntidad.CMRCDR = Me.txtMercaderia.Codigo
    objEntidad.TOBSSR = ""
    If Me.txtServicioCotizacion.Codigo = 1 Then
      objEntidad.CLCLOR = Me.txtLocalidadOrigen.Codigo
      objEntidad.CLCLDS = Me.txtLocalidadDestino.Codigo
      objEntidad.QDSTVR = Me.txtDistancia.Text
      objEntidad.CSTNDT = IIf(IsNumeric(Me.txtCostoPorTonelada.Text.Trim), txtCostoPorTonelada.Text, 0)
      objEntidad.ILCFTR = IIf(Me.txtImportePagarTransportista.Text.Trim.Length = 0, 0, Me.txtImportePagarTransportista.Text)
      objEntidad.ILQFMX = IIf(Me.txtImportePagarTransportista.Text.Trim.Length = 0, 0, Me.txtImportePagarTransportista.Text)
      objEntidad.ILQSMT = IIf(Me.txtImportePagarTransportista.Text.Trim.Length = 0, 0, Me.txtImportePagarTransportista.Text)
      objEntidad.SFCRTV = "V"
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
    objEntidad.SSRVFE = "E"
    objEntidad = objNegocios.Guardar_Servicio_Mercadia(objEntidad)
    If objEntidad.NCTZCN.ToString.Equals("0") Then
      HelpClass.ErrorMsgBox()
    Else
      GenerarOS(obeDetalle_Cotizacion)
    End If
  End Sub

  Private Sub GenerarOS(ByVal obeDetalle_Cotizacion As Detalle_Cotizacion)
    Dim objNegocios As New ServicioMercaderia_BLL()

    Dim lobjEntidad As New ServicioMercaderia
    lobjEntidad.NCTZCN = Me.txtNrCotizacion.Text
    Dim dblCantidad As Integer = objNegocios.Cantidad_Detalle_Cotizacion(lobjEntidad)
    If dblCantidad > 0 Then
      Dim objEntidad As New OrdenServicioTransporte
      objEntidad.NCTZCN = Me.txtNrCotizacion.Text
      objEntidad.CCMPN = obeCotizacion.CCMPN
      objEntidad.CDVSN = obeCotizacion.CDVSN
      objEntidad.CPLNDV = obeCotizacion.CPLNDV
      objEntidad.CCLNT = obeCotizacion.CCLNT
      Dim objfrmGenerarOS As New frmGenerarOS(objEntidad)
      If objfrmGenerarOS.ShowDialog = Windows.Forms.DialogResult.OK Then
        Dim oblDetalleCotizacion As New DetalleCotizacion_BLL
        _NORSRT = oblDetalleCotizacion.Buscar_Detalle_Cotizacion(obeDetalle_Cotizacion).NORSRT
        Me.DialogResult = Windows.Forms.DialogResult.OK
      End If
    ElseIf dblCantidad = -1 Then
      HelpClass.ErrorMsgBox()
    Else
      HelpClass.MsgBox("No puede Generar orden de servicio, " & Chr(10) & " porque uno o más mercaderías no tienen servicio de cotización")
    End If
  End Sub

  Private Sub txtNrCotizacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNrCotizacion.KeyPress
    If e.KeyChar = Chr(13) Then
      BuscarCotizacion()
    End If
  End Sub

  Private Sub BuscarCotizacion()
    Dim objNegocios As New Cotizacion_BLL
    obeCotizacion.NCTZCN = Me.txtNrCotizacion.Text
    obeCotizacion.CCLNT = Me.txtCliente.pCodigo
    Dim olbeCotizacion As New List(Of Cotizacion)
    olbeCotizacion = objNegocios.Buscar_Cotizacion(obeCotizacion)
    If olbeCotizacion.Count > 0 Then
      EstadoCotizacion(False)
      Me.cmbMoneda.Codigo = olbeCotizacion.Item(0).CMNDA
      Me.txtNrCotizacion.Text = olbeCotizacion.Item(0).NCTZCN
      Me.txtNroContrato.Text = olbeCotizacion.Item(0).NCNTRT
      Me.txtContacto.Text = olbeCotizacion.Item(0).TCNCLC
      Me.txtPlantaFacturacion.Codigo = olbeCotizacion.Item(0).CPLNFC
      Me.cmbTipoCobro.SelectedValue = olbeCotizacion.Item(0).SCBRMD
      Me.HeaderGroupDealleCcotizacion.Enabled = True
      Me.HeaderGroupCotizacion.Panel.Enabled = False
      btnNuevoCotizacion.Enabled = True
      btnCancelarCotizacion.Enabled = True
      btnGuardarCotizacion.Enabled = True
      Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
    Else
      NuevaCotizacion(1)
    End If
  End Sub

  Private Sub btnCancelarCotizacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarCotizacion.Click
    AccionCancelar()
  End Sub

  Private Sub AccionCancelar()
    If gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Or gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
      EstadoCotizacion(False)
    End If
    gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
    btnNuevoCotizacion.Enabled = False
    btnGuardarCotizacion.Enabled = True
    btnCancelarCotizacion.Enabled = True
  End Sub

  Private Sub CargarCombo_Cotizacion()
    Dim objPlantaFacturacion As New PlantaFacturacion_BLL

    With Me.txtPlantaFacturacion
      .DataSource = objPlantaFacturacion.Listar_Planta_Facturacion_Combo(obeCotizacion.CCMPN)
      .KeyField = "CZNFCC"
      .ValueField = "TZNFCC"
      .DataBind()
    End With
    With Me.cmbMoneda
      .DataSource = objMoneda.Listar_Monedas_Combo(obeCotizacion.CCMPN)
      .KeyField = "CMNDA1"
      .ValueField = "TMNDA"
      .DataBind()
    End With

    Dim oDt As New DataTable
    Dim oDr As DataRow
    oDt.Columns.Add("COD")
    oDt.Columns.Add("DES")
    oDr = oDt.NewRow

    oDr.Item(0) = "R"
    oDr.Item(1) = "REMITENTE"
    oDt.Rows.Add(oDr)

    oDr = oDt.NewRow
    oDr.Item(0) = "D"
    oDr.Item(1) = "DESTINATARIO"
    oDt.Rows.Add(oDr)

    With Me.cmbTipoCobro
      .DataSource = oDt
      .ValueMember = "COD"
      .DisplayMember = "DES"
    End With
    Me.cmbTipoCobro.SelectedValue = -1
  End Sub

  Private Sub CargarCombo_Servicio_Cotizacion()
        Dim objMercaderia As New MercaderiaTransportes_BLL
    Dim objTipoServicioTransporte As New TipoServicioTransporte_BLL
    Dim objServicioCotizacion As New ServicioCotizacion_BLL
    Dim objUnidadServicio As New UnidadMedida_BLL
    Dim objLocalidad As New Localidad_BLL
    With Me.txtMercaderia
      .DataSource = objMercaderia.Busca_MercaderiaTransportesBuscar(obeCotizacion.CCMPN)
      .KeyField = "CMRCDR"
      .ValueField = "TCMRCD"
      .DataBind()
    End With

    With Me.txtTipoServicio
      .DataSource = objTipoServicioTransporte.Listar_Tipo_Servicio_Combo(obeCotizacion.CCMPN)
      .KeyField = "CTPOSR"
      .ValueField = "TCMTPS"
      .DataBind()
    End With

        Dim objentidad As New ServicioCotizacion
    objentidad.CCMPN = obeCotizacion.CCMPN
    objentidad.CDVSN = obeCotizacion.CDVSN
    With Me.txtServicioCotizacion
      .DataSource = objServicioCotizacion.Listar_Servicio_Cotizacion(objentidad)
      .KeyField = "CSRVNV"
      .ValueField = "TCMTRF"
      .DataBind()
    End With

    With Me.txtUnidadServicioAdicional
      .DataSource = objUnidadServicio.Listar_Unidad_Medida_Combo(obeCotizacion.CCMPN)
      .KeyField = "CUNDMD"
      .ValueField = "TCMPUN"
      .DataBind()
    End With

    With Me.txtLocalidadDestino
      .DataSource = objLocalidad.Listar_Localidades_Combo(obeCotizacion.CCMPN)
      .KeyField = "CLCLD"
      .ValueField = "TCMLCL"
      .DataBind()
    End With

    With Me.txtLocalidadOrigen
      .DataSource = objLocalidad.Listar_Localidades_Combo(obeCotizacion.CCMPN)
      .KeyField = "CLCLD"
      .ValueField = "TCMLCL"
      .DataBind()
    End With

    With Me.txtMonedaLiquidacion
      .DataSource = objMoneda.Listar_Monedas_Combo(obeCotizacion.CCMPN)
      .KeyField = "CMNDA1"
      .ValueField = "TMNDA"
      .DataBind()
    End With

    With Me.txtMonedaLiquidacionTransportista
      .DataSource = objMoneda.Listar_Monedas_Combo(obeCotizacion.CCMPN)
      .KeyField = "CMNDA1"
      .ValueField = "TMNDA"
      .DataBind()
    End With
  End Sub

  Private Sub Cargar_Combos_Mercaderia()
    Dim objCompaniaSeguro As New CompaniaSeguro_BLL
    Dim objCondicionRuta As New CondicionRuta_BLL
        Dim objMercaderia As New MercaderiaTransportes_BLL
    Dim objParametroFacturacion As New ParametroFacturacion_BLL
    Dim objParametroPagar As New ParametroFacturacion_BLL
    Dim objTipoServicioTransporte As New TipoServicioTransporte_BLL
    Dim objUnidadMedida As New UnidadMedida_BLL
        Dim objUnidadTransporte As New UnidadesTransporte_BLL
    Dim objNave As New Naves_BLL
    Dim objCompania As New Compania_BLL
    Dim objDivision As New Division_BLL
    Dim objPlanta As New Planta_BLL
    Dim objMoneda As New Moneda_BLL
    Dim objPlantaFacturacion As New PlantaFacturacion_BLL
    Dim objLocalidad As New Localidad_BLL
    Dim objUnidadServicio As New UnidadMedida_BLL

    With Me.txtCiaSeguro
      .DataSource = objCompaniaSeguro.Listar_Compania_Seguro_Combo(obeCotizacion.CCMPN)
      .KeyField = "CCMPSG"
      .ValueField = "TCMPSG"
      .DataBind()
    End With

    With Me.txtMercaderia
      .DataSource = objMercaderia.Busca_MercaderiaTransportesBuscar(obeCotizacion.CCMPN)
      .KeyField = "CMRCDR"
      .ValueField = "TCMRCD"
      .DataBind()
    End With

    With Me.txtParametroFacturacion
      .DataSource = objParametroFacturacion.Listar_Parametros_Facturacion_Combo(obeCotizacion.CCMPN)
      .KeyField = "CFRMPG"
      .ValueField = "TCMFRP"
      .DataBind()
    End With

    With Me.txtParametroPagar
      .DataSource = objParametroFacturacion.Listar_Parametros_Facturacion_Combo(obeCotizacion.CCMPN)
      .KeyField = "CFRMPG"
      .ValueField = "TCMFRP"
      .DataBind()
    End With

    With Me.txtTipoServicio
      .DataSource = objTipoServicioTransporte.Listar_Tipo_Servicio_Combo(obeCotizacion.CCMPN)
      .KeyField = "CTPOSR"
      .ValueField = "TCMTPS"
      .DataBind()
    End With

    With Me.txtUnidadMedida
      .DataSource = objUnidadMedida.Listar_Unidad_Medida_Combo(obeCotizacion.CCMPN)
      .KeyField = "CUNDMD"
      .ValueField = "TCMPUN"
      .DataBind()
    End With

    With Me.txtUnidadVehicular
      .DataSource = objUnidadTransporte.Listar_Unidad_Transporte_Combo(obeCotizacion.CCMPN)
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

  Private Function Validar() As Boolean
    Dim strError As String = "DEBE DE INGRESAR: " & Chr(13)
    ''MERCADERIA
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
    ''servicio
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

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.HeaderGroupDealleCcotizacion.Enabled = False
    Me.HeaderGroupCotizacion.Panel.Enabled = True
    EstadoCotizacion(False)
    AccionCancelar()
  End Sub

  Private Sub txtServicioCotizacion_Texto_KeyEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtServicioCotizacion.Texto_KeyEnter
    If txtServicioCotizacion.NoHayCodigo Then Exit Sub
    If Me.txtServicioCotizacion.Codigo <> 1 Then
      ValidarServicio(False)
    Else
      ValidarServicio(True)
    End If
  End Sub

  Private Sub ValidarServicio(ByVal bolEstado As Boolean)
    Me.txtLocalidadOrigen.Visible = bolEstado
    Me.txtLocalidadDestino.Visible = bolEstado
    Me.txtDistancia.Visible = bolEstado
    Me.txtCostoPorTonelada.Visible = bolEstado
    Me.lblLocalidadOrigen.Visible = bolEstado
    Me.lblLocalidadDestino.Visible = bolEstado
    Me.lblDistanciaKM.Visible = bolEstado
    Me.lblDetraccion.Visible = bolEstado
  End Sub

  Private Sub txtTipoServicio_Texto_KeyEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoServicio.Texto_KeyEnter
    If txtTipoServicio.NoHayCodigo = False Then
      Listar_SubServicios()
    Else
      Me.txtTipoSubServicio.DataSource = Nothing
      Me.txtTipoSubServicio.Limpiar()
    End If
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

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

  Private Sub btnBuscarCotizacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCotizacion.Click
    If txtCliente.pCodigo = 0 Then Exit Sub
    Dim ofrmBuscarCotizacion As New frmCotizacion_X_Cliente
    With ofrmBuscarCotizacion
      obeCotizacion.CCLNT = Me.txtCliente.pCodigo
      .obeCotizacion = obeCotizacion
      If .ShowDialog() = Windows.Forms.DialogResult.OK Then
        EstadoCotizacion(False)
        Me.cmbMoneda.Codigo = .obeCotizacion.CMNDA
        Me.txtNrCotizacion.Text = .obeCotizacion.NCTZCN
        Me.txtNroContrato.Text = obeCotizacion.NCNTRT
        Me.txtContacto.Text = obeCotizacion.TCNCLC
        Me.txtPlantaFacturacion.Codigo = obeCotizacion.CPLNFC
        Me.cmbTipoCobro.SelectedValue = obeCotizacion.SCBRMD
        Me.HeaderGroupDealleCcotizacion.Enabled = True
        Me.HeaderGroupCotizacion.Panel.Enabled = False
        btnNuevoCotizacion.Enabled = True
        btnCancelarCotizacion.Enabled = True
        btnGuardarCotizacion.Enabled = True
        Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
      End If
    End With
  End Sub
End Class
