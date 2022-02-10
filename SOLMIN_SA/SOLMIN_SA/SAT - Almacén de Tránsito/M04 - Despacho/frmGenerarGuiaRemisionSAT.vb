' Librer�as del Framework  
Imports System.IO
Imports System
Imports System.Text

Imports Ransa.TYPEDEF
Imports RANSA.Utilitario
Imports Ransa.NEGO
Imports RANSA.NEGO.DespachoSAT
Imports Ransa.NEGO.slnSOLMIN_SAT.Despacho.Reportes
Imports CrystalDecisions.CrystalReports.Engine
'Imports WSBrokers.Operaciones.Despacho.EsbIntminsurSolminDespachoService
'Imports WSBrokers.Operaciones.Despacho.ITEM


Public Class frmGenerarGuiaRemisionSAT

#Region " Atributos "

    Private strNRGUIA As String = 0
    Private strNMNFTF As String = ""
    Private strSMTRCP As String = ""
    Private strSMTRCP_DET As String = ""
    Private strCTRSPT As String = ""
    Private strNPLCUN As String = ""
    Private strEmpresaDeTransporte As String = ""
    Private strNPLCAC As String = ""
    Private strCBRCNT As String = ""
    ' Validar Controles
    Private blnResultadoValidar As Boolean = True
    Private booValidarTicket As Boolean = False
    Private booValidarDespachoRemision As Boolean = False
    Private booValidarPlacaAcoplado As Boolean = False
    Private booValidarClienteTercero As Boolean = False
    Private _strNroRUCTransportisdta As String = ""
    Private _strDriver As String = ""
    Private _strDireccionTransportista As String = ""
    Private strOrderType As String = ""
    Private strOrderNumber As String = ""
    Private _pintCodigoPedido_CDPEPL As Decimal = 0
    Private _intFactura As Decimal = 0
    Private _intCodPlanta_CPLCLP As Decimal = 0
    Private _intCodigoClienteTercero_CPRVCL As Decimal = 0
    Private bolGuiaAutoGenerado As Boolean = False
    Private strTipoMovIntfz As String = ""
    Private pstrMTC As String
    Private olUnidadeCantidad As New List(Of beGeneral)
    Private olUnidadePeso As New List(Of beGeneral)
    Public nTipoGuia As Integer = 1

    Private bGenerar_Electronico_Default As Boolean = False
#End Region

#Region "Propiedades"
    Private objCopiarPegar As clsCopiar_Pegar
    Public Property pCopiarPegar() As clsCopiar_Pegar
        Get
            Return objCopiarPegar
        End Get
        Set(ByVal value As clsCopiar_Pegar)
            objCopiarPegar = value
        End Set
    End Property

    Private _PSCCMPN As String
    ''' <summary>
    ''' Compania 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property


    Private _PSCREFFW As String
    ''' <summary>
    ''' C�digo de Bulto
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSCREFFW() As String
        Get
            Return _PSCREFFW
        End Get
        Set(ByVal value As String)
            _PSCREFFW = value
        End Set
    End Property

    Private _PSCDVSN As String
    ''' <summary>
    ''' Division
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSCDVSN() As String
        Get
            Return _PSCDVSN
        End Get
        Set(ByVal value As String)
            _PSCDVSN = value
        End Set
    End Property

    Private _PNCPLNDV As Decimal
    Public Property PNCPLNDV() As Decimal
        Get
            Return _PNCPLNDV
        End Get
        Set(ByVal value As Decimal)
            _PNCPLNDV = value
        End Set
    End Property

    Private _PNCCLNT As Decimal = 0
    ''' <summary>
    ''' C�digo del cliente
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PNCCLNT() As Decimal
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property

    Private _EsRecojo As Boolean = False
    Public WriteOnly Property EsRecojo() As Boolean
        Set(ByVal value As Boolean)
            _EsRecojo = value
        End Set
    End Property

    Private _EsPredespacho As Boolean
    ''' <summary>
    ''' Cuando se crea gu�a de remisi�n desde predespacho
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    Public WriteOnly Property EsPredespacho() As Boolean
        Set(ByVal value As Boolean)
            _EsPredespacho = value
        End Set
    End Property

    Private _PNNROCTL As Decimal = 0
    ''' <summary>
    ''' C�digo de Predespacho
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    Public WriteOnly Property PNNROCTL() As Decimal
        Set(ByVal value As Decimal)
            _PNNROCTL = value
        End Set
    End Property

    Public WriteOnly Property pintCodigoClienteTercero_CPRVCL() As Decimal
        Set(ByVal value As Decimal)
            _intCodigoClienteTercero_CPRVCL = value
        End Set
    End Property
    '
    Public WriteOnly Property pintCodigoPedido_CDPEPL() As Decimal
        Set(ByVal value As Decimal)
            _pintCodigoPedido_CDPEPL = value
        End Set
    End Property

    Public WriteOnly Property pintFactura_NDCFCC() As Decimal
        Set(ByVal value As Decimal)
            _intFactura = value
        End Set
    End Property

    Public WriteOnly Property pNroGuia_NRGUIA() As String
        Set(ByVal value As String)
            strNRGUIA = value
        End Set
    End Property

    Public WriteOnly Property pManifiesto_NMNFTF() As String
        Set(ByVal value As String)
            strNMNFTF = value
        End Set
    End Property

    Public WriteOnly Property pMotivo_SMTRCP() As String
        Set(ByVal value As String)
            strSMTRCP = value
        End Set
    End Property

    Public WriteOnly Property pMotivo_SMTRCP_DET() As String
        Set(ByVal value As String)
            strSMTRCP_DET = value
        End Set
    End Property

    Public WriteOnly Property pstrEmpresaTransporte_CTRSPT() As String
        Set(ByVal value As String)
            strCTRSPT = value
        End Set
    End Property

    Public WriteOnly Property pstrEmpresaTransporte_Descripcion() As String
        Set(ByVal value As String)
            strEmpresaDeTransporte = value
        End Set
    End Property

    Public WriteOnly Property pstrPlacaUnidad_NPLCUN() As String
        Set(ByVal value As String)
            strNPLCUN = value
        End Set
    End Property

    Public WriteOnly Property pstrPlacaAcoplado_NPLCAC() As String
        Set(ByVal value As String)
            strNPLCAC = value
        End Set
    End Property

    Public WriteOnly Property pstrBrevete_CBRCNT() As String
        Set(ByVal value As String)
            strCBRCNT = value
        End Set
    End Property

    Public WriteOnly Property pstrOrderType() As String
        Set(ByVal value As String)
            strOrderType = value
        End Set
    End Property

    Public WriteOnly Property pstrOrderNumber() As String
        Set(ByVal value As String)
            strOrderNumber = value
        End Set
    End Property

#End Region

#Region " Funciones y Procedimientos "

    Private Sub PrecargarControles()
        ' Habilitar Opciones seg�n el Sistema que se haya cargado
        Select Case objSeguridadBN.pstrTipoSistema
            Case "01"
                dtpFechaEmision.Enabled = True
                dtpFechaTraslado.Enabled = True
                txtNroFactura.Enabled = False
                txtTipoDoc.Enabled = False
                dtpFechaFactura.Enabled = False
                txtPlacaAcoplado.Enabled = True
                lblNroGuiaInterna.Text = "Nro. Guía Salida : "
                txtNroGuiaInterna.Text = strNRGUIA
                'txtMotivoTraslado.Text = strSMTRCP_DET
                'txtMotivoTraslado.Tag = strSMTRCP
                'txtMotivoTraslado.Refresh()
                txtObservaciones.Text = strNMNFTF
                txtObservaciones.MaxLength = 120
        End Select
        'Cargar Medio Sugerido
        ' Me.txtMedioSugerido.Refrescar(4)
        Dim obrMedioTransporte As New Ransa.NEGO.brGeneral
        Dim obeMedioTransporte As New Ransa.TypeDef.beGeneral
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PNCMEDTR"
        oColumnas.DataPropertyName = "PNCMEDTR"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTNMMDT"
        oColumnas.DataPropertyName = "PSTNMMDT"
        oColumnas.HeaderText = "Descripción "
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oColumnas.Visible = True
        oListColum.Add(2, oColumnas)
        UcAyuda1.DataSource = obrMedioTransporte.ListaMedioTransporte(obeMedioTransporte)
        UcAyuda1.ListColumnas = oListColum
        UcAyuda1.Cargas()
        UcAyuda1.Limpiar()
        UcAyuda1.ValueMember = "PNCMEDTR"
        UcAyuda1.DispleyMember = "PSTNMMDT"




        rbtPlantaCliente.Checked = True

        'Empresa de Transporte
        txtEmpresaTransporte.Tag = strCTRSPT
        mfblnObtenerDetalle_EmpresaTransporte(txtEmpresaTransporte.Tag, txtEmpresaTransporte.Text, "")
        If strCTRSPT <> "" Then
            mfblnBuscar_EmpresaTransporte(txtEmpresaTransporte.Tag, txtEmpresaTransporte.Text, _strNroRUCTransportisdta, _strDireccionTransportista)
        End If

        If _intCodigoClienteTercero_CPRVCL <> 0 Then
            If _intCodigoClienteTercero_CPRVCL <> _PNCCLNT Then
                Me.rbtClienteTercero.Checked = True
                UcClienteTerceroDestino.CodCliente = _intCodigoClienteTercero_CPRVCL
            End If
        End If

        If _intCodPlanta_CPLCLP <> 0 Then
            UcPlantaDeEntregaDestino.CodClienteTercero = _intCodPlanta_CPLCLP
        End If

        'Placa de la Unidad
        txtPlacaUnidad.Text = strNPLCUN
        txtPlacaUnidad.Tag = strNPLCUN
        'Placa del Acoplado
        txtPlacaAcoplado.Text = strNPLCAC
        txtPlacaAcoplado.Tag = strNPLCAC
        'Nro. Brevete
        txtNroBrevete.Text = strCBRCNT
        txtNroBrevete.Tag = strCBRCNT
        'Nro Factura
        Me.txtNroFactura.Text = IIf(_intFactura = 0, "", _intFactura)
        Me.txtNroGuiaRemision.Focus()
    End Sub

    Private Sub CargarControl()
        If _EsRecojo Then
            txtCliente.Enabled = True
            'UcClienteTerceroOrigen.Visible = True
            'lblClienteOrigen.Visible = True
            UcClienteTerceroOrigen.CodCliente = _PNCCLNT

            'vualisamos el cliente tercero en la posicion siguiente
            'lblPlantaOrigen.Location = New Point(509, 17)
            'UcPlantaDeEntregaOrigen.Location = New Point(610, 19)

            'lblClienteOrigen.Location = New Point(18, 19)
            'UcClienteTerceroOrigen.Location = New Point(107, 17)

            'Planta tercero
            UcPlantaDeEntregaOrigen.TipoPlantaDeEntrega = False
            UcPlantaDeEntregaOrigen.CodCliente = _PNCCLNT
            UcPlantaDeEntregaOrigen.pClear()

            'UcPlantaDeEntregaPropioDestino.TipoPlantaDeEntrega = True
            'UcPlantaDeEntregaPropioDestino.CodCliente = _PNCCLNT
            'UcPlantaDeEntregaPropioDestino.pClear()

            'UcClienteTerceroDestino.CodCliente = _PNCCLNT
            'UcClienteTerceroDestino.pClear()

            'UcPlantaDeEntregaDestino.TipoPlantaDeEntrega = False
            'UcPlantaDeEntregaDestino.CodCliente = _PNCCLNT
            'UcPlantaDeEntregaDestino.pClear()




        Else
            txtCliente.Enabled = False
            'UcClienteTerceroOrigen.Visible = False
            'lblClienteOrigen.Visible = False

            'vualisamos el cliente tercero en la posicion siguiente
            'lblPlantaOrigen.Location = New Point(6, 19)
            'UcPlantaDeEntregaOrigen.Location = New Point(107, 17)


            'Siempre es Ransa
            'UcPlantaDeEntregaOrigen.TipoPlantaDeEntrega = True
            'UcPlantaDeEntregaOrigen.CodCliente = 485
            UcPlantaDeEntregaOrigen_Ransa.TipoPlantaDeEntrega = True
            UcPlantaDeEntregaOrigen_Ransa.CodCliente = 485


            'Lista todas las planta de entrega Propios
            'UcPlantaDeEntregaPropioDestino.TipoPlantaDeEntrega = True
            'UcPlantaDeEntregaPropioDestino.CodCliente = _PNCCLNT
            'UcPlantaDeEntregaPropioDestino.pClear()


            'UcClienteTerceroDestino.CodCliente = _PNCCLNT
            'UcClienteTerceroDestino.pClear()

            'UcPlantaDeEntregaDestino.TipoPlantaDeEntrega = False
            'UcPlantaDeEntregaDestino.CodCliente = _PNCCLNT
            'UcPlantaDeEntregaDestino.pClear()



        End If


        UcPlantaDeEntregaPropioDestino.TipoPlantaDeEntrega = True
        UcPlantaDeEntregaPropioDestino.CodCliente = _PNCCLNT
        UcPlantaDeEntregaPropioDestino.pClear()

        UcClienteTerceroDestino.CodCliente = _PNCCLNT
        UcClienteTerceroDestino.pClear()

        UcPlantaDeEntregaDestino.TipoPlantaDeEntrega = False
        UcPlantaDeEntregaDestino.CodCliente = _PNCCLNT
        UcPlantaDeEntregaDestino.pClear()

        txtCliente.pCargar(_PNCCLNT)
        txtCliente.Refresh()


        If _EsRecojo Then
            tab_origen.TabPages.Remove(tpg_origen_ransa)
        Else
            tab_origen.TabPages.Remove(tpg_origen_recojo)
        End If


    End Sub

    'Private Sub CargarControl()
    '    UcClienteTerceroOrigen.Visible = False
    '    lblClienteOrigen.Visible = False
    '    'vualisamos el cliente tercero en la posicion siguiente
    '    lblPlantaOrigen.Location = New Point(6, 19)
    '    UcPlantaDeEntregaOrigen.Location = New Point(107, 17)
    '    'Siempre es Ransa
    '    UcPlantaDeEntregaOrigen.TipoPlantaDeEntrega = True
    '    UcPlantaDeEntregaOrigen.CodCliente = 485
    '    'Lista todas las planta de entrega Propios
    '    UcPlantaDeEntregaPropioDestino.TipoPlantaDeEntrega = True
    '    UcPlantaDeEntregaPropioDestino.CodCliente = _PNCCLNT
    '    UcPlantaDeEntregaPropioDestino.pClear()

    '    UcClienteTerceroDestino.CodCliente = _PNCCLNT
    '    UcClienteTerceroDestino.pClear()

    '    UcPlantaDeEntregaDestino.TipoPlantaDeEntrega = False
    '    UcPlantaDeEntregaDestino.CodCliente = _PNCCLNT
    '    UcPlantaDeEntregaDestino.pClear()

    '    txtCliente.pCargar(_PNCCLNT)
    '    txtCliente.Refresh()
    'End Sub

    Private Sub CargarControles()
        'Cargar Motivo Traslado
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "STPING"
        oColumnas.DataPropertyName = "PSSTPING"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TTPING"
        oColumnas.DataPropertyName = "PSTDSDES"
        oColumnas.HeaderText = "Tipo Movimiento"
        oListColum.Add(2, oColumnas)
        Dim obrGeneral As New Ransa.NEGO.brGeneral
        txtMotivoTraslado.DataSource = obrGeneral.floListaMovimientoGuiaRemisionCliente(_PNCCLNT)
        txtMotivoTraslado.ListColumnas = oListColum
        txtMotivoTraslado.Cargas()
        txtMotivoTraslado.ValueMember = "PSSTPING"
        txtMotivoTraslado.DispleyMember = "PSTDSDES"

        'Cargar Tipo Documento
        Dim oListColumTD As New Hashtable
        Dim oColumnasTD As New DataGridViewTextBoxColumn
        oColumnasTD = New DataGridViewTextBoxColumn
        oColumnasTD.Name = "CTPODC"
        oColumnasTD.DataPropertyName = "PNCTPODC"
        oColumnasTD.HeaderText = "Código "
        oListColumTD.Add(1, oColumnasTD)
        oColumnasTD = New DataGridViewTextBoxColumn
        oColumnasTD.Name = "TCMTPD"
        oColumnasTD.DataPropertyName = "PSTCMTPD"
        oColumnasTD.HeaderText = "Tipo Documento"
        oListColumTD.Add(2, oColumnasTD)
        txtTipoDoc.DataSource = obrGeneral.olTipoDocumento()
        txtTipoDoc.ListColumnas = oListColumTD
        txtTipoDoc.Cargas()
        txtTipoDoc.ValueMember = "PNCTPODC"
        txtTipoDoc.DispleyMember = "PSTCMTPD"
        txtTipoDoc.Valor = 1
        txtTipoDoc.Refresh()

        'Cargar Cliente
        txtCliente.pCargar(_PNCCLNT)
        txtCliente.Refresh()

        Dim obrMedioTransporte As New RANSA.NEGO.brGeneral
        Dim obeMedioTransporte As New RANSA.TypeDef.beGeneral

        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PNCMEDTR"
        oColumnas.DataPropertyName = "PNCMEDTR"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTNMMDT"
        oColumnas.DataPropertyName = "PSTNMMDT"
        oColumnas.HeaderText = "Descripción "
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oColumnas.Visible = True
        oListColum.Add(2, oColumnas)
        UcAyuda1.DataSource = obrMedioTransporte.ListaMedioTransporte(obeMedioTransporte)
        UcAyuda1.ListColumnas = oListColum
        UcAyuda1.Cargas()
        UcAyuda1.Limpiar()
        UcAyuda1.ValueMember = "PNCMEDTR"
        UcAyuda1.DispleyMember = "PSTNMMDT"

        'Autogenera Guia Remision
        bolGuiaAutoGenerado = obrGeneral.bolElClienteEsOutotec(_PNCCLNT)
        Me.chkAutoGenerar.Checked = bolGuiaAutoGenerado
        fAutoGenerarGuiaRemision(bolGuiaAutoGenerado)
    End Sub

    Private Function fblnValidaContenedor() As Boolean

        Return fblnValidaContenedor
    End Function

    Private Function fblnValidarControles() As Boolean
        Dim strMensajeError As String = ""
        Dim Guia As String = txtNroGuiaRemision.Text.Trim
        txtNroGuiaRemision.Text = txtNroGuiaRemision.Text.Trim

        If Guia.Contains(" ") Then
            strMensajeError &= "- Guía no puede tener espacios en blanco." & vbNewLine
        End If


        Dim codMedioEnvio As String = "0"
        ' Reiniciamos la variable del estado de la validaci�n
        blnResultadoValidar = True
        ' Realizamos la validaci�n de los campos
        If txtCliente.pCodigo = 0 Then _
                   strMensajeError &= "- Seleccione Cliente" & vbNewLine
        If txtMotivoTraslado.Resultado Is Nothing Then _
            strMensajeError &= "- No ha ingresado Motivo de Despacho" & vbNewLine
        If Not txtMotivoTraslado.Resultado Is Nothing AndAlso CType(txtMotivoTraslado.Resultado, beGeneral).PSSTPING.Trim = "A" AndAlso txtObsOtrosMotivos.Text.Trim = "" Then _
            strMensajeError &= "- Debe ingresar observación cuando el Motivos es " & CType(txtMotivoTraslado.Resultado, beGeneral).PSTDSDES & vbNewLine

        'Dim CodSerie As String = ("" & cboTipoSerie.SelectedValue).ToString.Trim
        'If CodSerie = "" Then
        '    If txtNroGuiaRemision.Text = "" Then _
        '  strMensajeError &= "- De ingresar el Nro. de la Guía de Remisión" & vbNewLine
        '    If txtNroGuiaRemision.Text <> "" And txtNroGuiaRemision.Text.Length <> 11 Then _
        '        strMensajeError &= "- El Nro. de la Guía de Remisión es de 11 dígitos" & vbNewLine

        '    If txtNroGuiaRemision.Text.Length = 11 Then
        '        Dim serie As String = txtNroGuiaRemision.Text.Substring(1, 10)
        '        If IsNumeric(serie) = False Then
        '            strMensajeError &= "- Verificar serie numérica." & vbNewLine
        '        End If
        '    End If


        'End If

        'Dim TipoGuia As String = ""
        'If rbfisico.Checked = True Then
        '    TipoGuia = "F"
        'End If
        'If rbelectronico.Checked = True Then
        '    TipoGuia = "E"
        'End If

        Dim TipoGuia As String = ("" & cboTipoGR.SelectedValue).ToString.Trim
        Dim serie As String = ("" & cboTipoSerie.SelectedValue).ToString.Trim
        If serie = "" Then
            If txtNroGuiaRemision.Text = "" Then _
                strMensajeError &= "- De ingresar el Nro. de la Guía de Remisión" & vbNewLine
            Select Case TipoGuia
                Case "F"
                    If txtNroGuiaRemision.Text <> "" And txtNroGuiaRemision.Text.Length <> 10 Then _
                      strMensajeError &= "- El Nro. de la Guía de Remisión es de 10 dígitos" & vbNewLine
                Case "E"
                    'If txtNroGuiaRemision.Text <> "" And txtNroGuiaRemision.Text.Length <> 12 Then _
                    '    strMensajeError &= "- El Nro. de la Guía de Remisión es de 12 dígitos" & vbNewLine
                    If txtNroGuiaRemision.Text <> "" And txtNroGuiaRemision.Text.Length < 5 Then _
                      strMensajeError &= "- El Nro. de la Guía de Remisión debe tener al menos 5 dígitos" & vbNewLine
            End Select
        End If

        'FFF()
        '


        'If txtNroGuiaRemision.Text = "" Then _
        '    strMensajeError &= "- De ingresar el Nro. de la Guía de Remisión" & vbNewLine
        'If txtNroGuiaRemision.Text <> "" And txtNroGuiaRemision.Text.Length <> 10 Then _
        '    strMensajeError &= "- El Nro. de la Guía de Remisión es de 10 dígitos" & vbNewLine
        If txtNroFactura.Text <> "" Then
            If txtTipoDoc.Resultado Is Nothing Then
                strMensajeError &= "-Debe ingresar el Tipo de Documento" & vbNewLine
            End If
        End If
        'If _PNCCLNT <> 11232 Then
        If txtNroFactura.Text <> "" Then
            If txtNroFactura.Enabled And txtNroFactura.Text.Length <> 10 Then
                strMensajeError &= "- El Nro. de la Guía de Factura es de 10 dígitos" & vbNewLine
            End If
        End If
        'End If
        If _EsRecojo Then
            If UcPlantaDeEntregaOrigen.ItemActual.PNCPLNCL = 0 Then _
          strMensajeError &= "- Debe ingresar la Planta Origen" & vbNewLine
        Else
            If UcPlantaDeEntregaOrigen_Ransa.ItemActual.PNCPLNCL = 0 Then _
          strMensajeError &= "- Debe ingresar la Planta Origen" & vbNewLine
        End If
        'If UcPlantaDeEntregaOrigen.ItemActual.PNCPLNCL = 0 Then _
        '    strMensajeError &= "- Debe ingresar la Planta Origen" & vbNewLine
        If rbtPlantaCliente.Checked Then
            If UcPlantaDeEntregaPropioDestino.ItemActual.PNCPLNCL = 0 Then _
                        strMensajeError &= "- Debe ingresar la Planta Destino" & vbNewLine
        Else
            If UcClienteTerceroDestino.ItemActual.PNCPRVCL = 0 Then _
                        strMensajeError &= "- Debe ingresar el Proveedor" & vbNewLine
            If UcPlantaDeEntregaDestino.ItemActual.PNCPLNCL = 0 Then _
                        strMensajeError &= "- Debe seleccionar una Planta Destino del Cliente" & vbNewLine
        End If
        '19092018
        'inicio
        'If txtMedioSugerido.objResult Is Nothing Then
        '    strMensajeError &= "- Debe seleccionar el Medio de envio" & vbNewLine
        'Else

        If UcAyuda1.Resultado Is Nothing Then
            strMensajeError &= "- Debe seleccionar el Medio de envio" & vbNewLine

        Else
            codMedioEnvio = CType(UcAyuda1.Resultado, Ransa.TypeDef.beGeneral).PNCMEDTR
        End If

        If txtEmpresaTransporte.Enabled And txtEmpresaTransporte.Tag = "" Then
            strMensajeError &= "- Debe seleccionar el transportista" & vbNewLine
            txtPlacaUnidad.Text = ""
            txtPlacaAcoplado.Text = ""
            txtNroBrevete.Text = ""
        Else
            If txtPlacaUnidad.Enabled And txtPlacaUnidad.Text = "" Then _
             strMensajeError &= "- Debe seleccionar la Placa de la Unidad" & vbNewLine
            If codMedioEnvio.ToString.Equals("4") Then
                'If txtPlacaAcoplado.Enabled And txtPlacaAcoplado.Text = "" Then _
                '               strMensajeError &= "- Debe seleccionar el Acoplado de la Unidad" & vbNewLine
                If txtNroBrevete.Enabled And txtNroBrevete.Text = "" Then _
                    strMensajeError &= "- Debe seleccionar el Brevete" & vbNewLine
            End If

        End If

        'txtPlacaAcoplado

        If chkDosTramos.Checked Then
            If txtEmpresaTransporte2doTramo.Text = "" Then _
                strMensajeError &= "- Debe seleccionar la Empresa de Transporte para el 2do. Tramo" & vbNewLine
        End If


        If txtSigla.Text.Trim.Length <> 0 And txtNumeroContenedor.Text.Trim.Length = 0 Then
            strMensajeError &= "- Ingrese Número de Contenedor" & vbNewLine
        ElseIf txtSigla.Text.Trim.Length = 0 And txtNumeroContenedor.Text.Trim.Length <> 0 Then
            strMensajeError &= "- Ingrese Sigla Contenedor" & vbNewLine
        End If

        'Dim obrGeneral As New Ransa.NEGO.brGeneral
        ''Validamos que el clientes sea Outotec
        'If obrGeneral.bolElClienteEsOutotec(_PNCCLNT) Then
        '    'Validamos que el tipo de movimiento selecciona tenga su equivalencia en outotec
        '    Dim olbeGeneral As New List(Of beGeneral)
        '    If Not txtMotivoTraslado.Resultado Is Nothing Then
        '        olbeGeneral = obrGeneral.olEquivalenteOutotecMotivoDespacho(CType(txtMotivoTraslado.Resultado, beGeneral).PSSTPING)
        '        If olbeGeneral.Count = 0 Then
        '            strMensajeError &= "- El tipo de despacho no cuenta con equivalencia en la interfaz"
        '        Else
        '            strTipoMovIntfz = olbeGeneral.Item(0).PSTDSDES.Trim
        '        End If

        '    End If
        'End If

        If bGenerar_Electronico_Default = True Then
            If _EsRecojo = True Then
                If Val("" & txt_ubigeo_origen_recojo.Tag) = 0 Then
                    strMensajeError &= "- Dirección origen sin Ubigeo." & vbNewLine
                End If
            Else
                If Val("" & txt_ubigeo_origen_ransa.Tag) = 0 Then
                    strMensajeError &= "- Dirección origen sin Ubigeo" & vbNewLine
                End If
            End If

            If rbtPlantaCliente.Checked = True Then
                If Val("" & txt_ubigeo_destino_planta.Tag) = 0 Then
                    strMensajeError &= "- Dirección destino sin Ubigeo" & vbNewLine
                End If
            End If
            If rbtClienteTercero.Checked = True Then
                If Val("" & txt_ubigeo_destino_cliente.Tag) = 0 Then
                    strMensajeError &= "- Dirección destino sin Ubigeo" & vbNewLine
                End If

            End If

            If chkDosTramos.Checked = True Then
                If Val("" & txt_ubigeo_tramos.Tag) = 0 Then
                    strMensajeError &= "- Ubigeo tramo no seleccionado." & vbNewLine
                End If

            End If

        End If
        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            blnResultadoValidar = False
        End If
        Return blnResultadoValidar
    End Function

    Private Sub VistaPreviaGuiaRemisionAT(ByVal oDs As DataSet, ByVal strModeloGuia As String)
        Dim rdocGuiaRemision As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
        ' Cargamos los valores de los parametros de impresi�n de la Guia
        Select Case strModeloGuia
            Case "M1"
                rdocGuiaRemision = New rptGuiaRemisionM01
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M2"
                rdocGuiaRemision = New rptGuiaRemisionM02
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M3"
                rdocGuiaRemision = New rptGuiaRemisionM03
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M4"
                rdocGuiaRemision = New rptGuiaRemisionM04
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M5"
                rdocGuiaRemision = New rptGuiaRemisionM05
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
            Case "M5A"
                rdocGuiaRemision = New rptGuiaRemisionM05A
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M5B"
                rdocGuiaRemision = New rptGuiaRemisionM05B
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M6"
                rdocGuiaRemision = New rptGuiaRemisionM06
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M7"
                rdocGuiaRemision = New rptGuiaRemisionM07
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M9"
                rdocGuiaRemision = New rptGuiaRemisionM09
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
            Case "M9B"
                rdocGuiaRemision = New rptGuiaRemisionM09B
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M10"
                rdocGuiaRemision = New rptGuiaRemisionM10
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
            Case "M12"
                rdocGuiaRemision = New rptGuiaRemisionM012
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
            Case "M13"
                rdocGuiaRemision = New rptGuiaRemisionM013
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
            Case "M14"
                rdocGuiaRemision = New rptGuiaRemisionM14
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4

            Case "M15"
                rdocGuiaRemision = New rptGuiaRemisionM15
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter

            Case "CH2M"
                rdocGuiaRemision = New rptGuiaRemisionCH2M
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4

            Case "M16"
                rdocGuiaRemision = New rptGuiaRemisionM16
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4

            Case "M17"
                rdocGuiaRemision = New rptGuiaRemisionM17
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter

            Case "M18"
                rdocGuiaRemision = New rptGuiaRemisionM18
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
            Case "M19"
                rdocGuiaRemision = New rptGuiaRemisionM19
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter

            Case "M20"
                rdocGuiaRemision = New rptGuiaRemisionM20
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4

            Case Else
                rdocGuiaRemision = New rptGuiaRemisionM01
        End Select
        rdocGuiaRemision.SetDataSource(oDs)
        rdocGuiaRemision.Refresh()
        'Imprime la Gu�a de Remisi�n
        With frmVisorRPT
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill
            .pReportDocument = rdocGuiaRemision
            .ShowDialog()
        End With
    End Sub

    Private Sub fAutoGenerarGuiaRemision(ByVal bolChek As Boolean)
        Dim obrGuia As New DespachoSAT.brGuiasRemision
        If bolChek = True Then
            _PNCCLNT = Me.txtCliente.pCodigo
            Me.txtNroGuiaRemision.Text = obrGuia.fstrUltimoGuiaRemision(_PNCCLNT)
            txtNroGuiaRemision.Enabled = False
        Else
            'Me.txtNroGuiaRemision.Text = 0
            Me.txtNroGuiaRemision.Text = ""
            txtNroGuiaRemision.Enabled = True
        End If
    End Sub

    'Private Sub pGenerarReporte()
    '    If MessageBox.Show("Desea generar la guía de remisión??", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
    '    Select Case objSeguridadBN.pstrTipoSistema
    '        Case "01"
    '            Dim obeGuiaRemision As beGuiaRemision = New beGuiaRemision
    '            With obeGuiaRemision
    '                Decimal.TryParse(_PNCCLNT, .PNCCLNT)
    '                Int64.TryParse(Me.txtCliente.pCodigo, .PNCCLNGR)
    '                .PSCCMPN = _PSCCMPN
    '                .PSCDVSN = _PSCDVSN
    '                .PNCPLNDV = _PNCPLNDV


    '                If _EsPredespacho Then
    '                    .PNNROCTL = _PNNROCTL
    '                Else
    '                    .PNNRGUSA = Val(strNRGUIA)
    '                End If
    '                .PNFGUIRM = HelpClass.CDate_a_Numero8Digitos(Me.dtpFechaEmision.Value)
    '                .PNFINTRA = HelpClass.CDate_a_Numero8Digitos(Me.dtpFechaTraslado.Value)
    '                If _EsRecojo Then
    '                    .PNCPRVCO = UcClienteTerceroOrigen.ItemActual.PNCPRVCL '  Codigo Cliente Tercero Origen    
    '                    .PNCPLCLO = UcPlantaDeEntregaOrigen.ItemActual.PNCPLNCL '  Codigo Planta Tercero Origen    
    '                    .PSCREFFW = _PSCREFFW
    '                Else
    '                    .PNCPLNOR = UcPlantaDeEntregaOrigen.ItemActual.PNCPLNCL
    '                End If
    '                If rbtPlantaCliente.Checked Then
    '                    .PNCPLNCL = UcPlantaDeEntregaPropioDestino.ItemActual.PNCPLNCL '  Codigo Planta Cliente            
    '                Else
    '                    .PNCPRVCL = UcClienteTerceroDestino.ItemActual.PNCPRVCL '     Codigo Cliente Tercero           
    '                    .PNCPLCLP = UcPlantaDeEntregaDestino.ItemActual.PNCPLNCL ' Codigo Planta Tercero    
    '                End If

    '                .PSSMTGRM = CType(txtMotivoTraslado.Resultado, beGeneral).PSSTPING
    '                .PSTOBORM = txtObsOtrosMotivos.Text
    '                '.PSNGUIRM = txtNroGuiaRemision.Text
    '                .PSNGUIRS = txtNroGuiaRemision.Text

    '                Decimal.TryParse(txtEmpresaTransporte.Tag, .PNCTRSPT)
    '                .PSNPLCCM = txtPlacaUnidad.Text
    '                .PSNPLACP = txtPlacaAcoplado.Text
    '                .PSNBRVCH = txtNroBrevete.Text
    '                If txtObservaciones.Text.Trim.Length > 30 Then
    '                    .PSTOBSRM = txtObservaciones.Text.Trim.Substring(0, 30)
    '                    .PSTOBCLI = txtObservaciones.Text.Trim.Substring(30, txtObservaciones.Text.Trim.Length - 30)
    '                Else
    '                    .PSTOBSRM = txtObservaciones.Text.Trim
    '                    .PSTOBCLI = ""
    '                End If

    '                If chkDosTramos.Checked Then _
    '                 .PNNDCMRF = txtEmpresaTransporte2doTramo.Tag
    '                If Not UcAyuda1.Resultado Is Nothing Then
    '                    .PNCMEDTR = CType(UcAyuda1.Resultado, Ransa.TypeDef.beGeneral).PNCMEDTR
    '                End If
    '                'fin
    '                .PSCPRCN1 = txtSigla.Text.Trim
    '                .PSNSRCN1 = txtNumeroContenedor.Text.Trim
    '                .PSUSUARIO = objSeguridadBN.pUsuario
    '                .strAplicacion = Application.StartupPath
    '                .pstrTipoMovIntfz = strTipoMovIntfz
    '                .TipoRep = nTipoGuia

    '                'Agregando los datos de referencia adicional
    '                '.CLCRGA = Me.txtclasificacioncarga.Text
    '                .CLCRGA = (Me.txtclasificacioncarga.SelectedValue & "").ToString.Trim

    '                If Me.txtprogramador.DropDownStyle = ComboBoxStyle.DropDownList Then
    '                    If txtprogramador.SelectedValue <> "" Then
    '                        .UPROGM = Me.txtprogramador.Text.Trim
    '                    End If
    '                Else
    '                    .UPROGM = Me.txtprogramador.Text.Trim
    '                End If

    '                .EMAPRB = Me.txtcorreoaprobacion.Text.Trim
    '                .USLCNT = Me.txtsolicitante.Text.Trim
    '                .APRBDO = Me.txtaprobador.Text.Trim
    '                .GRENCI = Me.txtgerencia.Text.Trim
    '                .AREASL = Me.txtArea.Text.Trim
    '                .SERIEGR = ("" & cboTipoSerie.SelectedValue)
    '                .PSCTDGRM = ("" & cboTipoGR.SelectedValue)



    '            End With
    '            Dim obeListaObservacion As New List(Of beGuiaRemision)
    '            Dim obeObervacion As beGuiaRemision
    '            For intRow As Integer = 0 To Me.dtgObservacion.Rows.Count - 2
    '                obeObervacion = New beGuiaRemision
    '                With obeObervacion
    '                    .PNCCLNGR = obeGuiaRemision.PNCCLNGR
    '                    .PSNGUIRM = obeGuiaRemision.PSNGUIRM
    '                    .PSUSUARIO = objSeguridadBN.pUsuario
    '                    .PSNTRMNL = objSeguridadBN.pstrPCName
    '                    .PSTOBDGS = dtgObservacion.Rows(intRow).Cells("TOBSGS").Value
    '                End With
    '                obeListaObservacion.Add(obeObervacion)
    '            Next

    '            mpGenerarGuiaRemisionAT(obeGuiaRemision, obeListaObservacion)
    '    End Select
    'End Sub

    Public Sub mpGenerarGuiaRemisionAT(ByVal obeGuiaRemision As beGuiaRemision, ByVal obeListaObservacion As List(Of beGuiaRemision))
        Dim obrGuiaRemision As New brGuiasRemision
        Dim oDs As New DataSet
        oDs = obrGuiaRemision.GenerarGuiaRemision(obeGuiaRemision, obeListaObservacion, _EsRecojo)
        If Not obeGuiaRemision.PSERROR.ToString.Equals("") Then
            'HelpClass.ErrorMsgBox()
            MessageBox.Show(obeGuiaRemision.PSERROR, "Aviso", MessageBoxButtons.OK)
            Exit Sub
        End If

        '2 csuistica    
        Dim objGuia As New beGuiaRemision
        With objGuia
            .PNCCLNT = obeGuiaRemision.PNCCLNT
            .PSNGUIRM = obeGuiaRemision.PSNGUIRM
            .PSCUSCRT = objSeguridadBN.pUsuario
        End With


        Dim oDtvTemp As DataView = New DataView(oDs.Tables(0).Copy)
        Dim dt_Listado_GR_generados As New DataTable
        dt_Listado_GR_generados = oDtvTemp.ToTable(True, "NGUIRM", "NGUIRS")



        Dim TipoGuia As String = ("" & cboTipoGR.SelectedValue).ToString.Trim
        Dim serie As String = ("" & cboTipoSerie.SelectedValue).ToString.Trim


        Dim enviar_guia_electronica As String = ""
        Dim grupo_envio As String = ""

        If TipoGuia = "E" And serie <> "" Then

            Dim dt_envio_gr As New DataTable
            dt_envio_gr = obrGuiaRemision.fnValidarCLienteEnvioGuia(obeGuiaRemision)

            Dim msg_validacion As String = ""


            For Each item As DataRow In dt_envio_gr.Rows
                If item("STATUS") = "E" Then
                    msg_validacion = msg_validacion & item("OBSRESULT") & Chr(10)
                End If
            Next
            If dt_envio_gr.Rows.Count > 0 Then
                grupo_envio = dt_envio_gr.Rows(0)("GRUPO_ENVIO")
                enviar_guia_electronica = dt_envio_gr.Rows(0)("STATUS")
            End If
        End If
      

        For Each item As DataRow In oDs.Tables(0).Rows
            item("NGUIRM") = formatear_nro_guia_remision(item("CTDGRM"), item("NGUIRS"))
        Next
        'ActualizarEstadoEnvioGuia_WS(objGuia)
        VistaPreviaGuiaRemisionAT(oDs, obeGuiaRemision.PSMODELO)

        Dim msg_envio As String = ""

        If enviar_guia_electronica = "S" Then
            Dim obrRestGuiaRemision As New br_Rest_Remision_Pacasmayo
            If MessageBox.Show("Cliente habilitado para envío electrónico." & Chr(13) & "Desea enviar las Guías generadas?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim trama As String = ""
                Dim CodRespuestaEmision As String = ""
                For Each item As DataRow In dt_Listado_GR_generados.Rows
                    msg_envio = msg_envio & obrRestGuiaRemision.Enviar_Guia_Remision_Electronica_Pacasmayo_Rest(obeGuiaRemision.PNCCLNT, item("NGUIRM"), item("NGUIRS"), grupo_envio, False, trama, CodRespuestaEmision)
                Next
                If msg_envio.Length > 0 Then
                    MessageBox.Show("Inconvenientes de envía Guía : " & msg_envio, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show("Las Guías fueron enviada con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If


        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    

    Private Function formatear_nro_guia_remision(Tipo As String, Nro_Guia_S As String) As String
        Dim guia_final As String = ""
        Select Case Tipo
            Case "F"
                Nro_Guia_S = Nro_Guia_S.PadLeft(10, "0")
                guia_final = Nro_Guia_S.Substring(0, 3) & "-" & Nro_Guia_S.Substring(3, 7)
            Case "E"
                'Nro_Guia_S = Nro_Guia_S.PadLeft(12, "0")
                'guia_final = Nro_Guia_S.Substring(0, 4) & "-" & Nro_Guia_S.Substring(4, 8)
                guia_final = Nro_Guia_S.Substring(0, 4) & "-" & Nro_Guia_S.Substring(4)
            Case Else
        End Select
        Return guia_final
    End Function

    Private Sub ValidarFechaGuiaRemision()
        If txtNroGuiaRemision.Text <> "" And "" & txtNroGuiaRemision.Text <> "0" Then
            Dim obrGuiaRemision As New DespachoSDS.brGuiasRemision
            Dim obeguiaremision As New beGuiaRemision
            obeguiaremision.PNCCLNT = Me.txtCliente.pCodigo
            obeguiaremision.PSNGUIRM = Me.txtNroGuiaRemision.Text
            Dim objGuiaRemision As New beGuiaRemision
            Dim Fecha As Date
            Dim FechaGR As String
            Dim FechaAnt As Int64
            objGuiaRemision = obrGuiaRemision.fObtenerMaxInferiorGuiaRemision(obeguiaremision)
            If objGuiaRemision IsNot Nothing Then
                Dim obeguiarem As New beGuiaRemision
                Fecha = dtpFechaEmision.Value
                FechaGR = HelpClass.CDate_a_Numero8Digitos(Fecha)
                FechaAnt = objGuiaRemision.PNFGUIRM
                If Convert.ToDecimal(FechaGR) < objGuiaRemision.PNFGUIRM Then
                    HelpClass.MsgBox("No procede, debe ser mayor a la Fecha de la Guía anterior que es el Nro. " & objGuiaRemision.PSNGUIRM & _
                " con Fecha " & HelpClass.CNumero8Digitos_a_FechaDefault(FechaAnt), MessageBoxIcon.Warning)
                    btnAceptar.Enabled = False
                Else
                    btnAceptar.Enabled = True
                End If
            End If
        End If
    End Sub
#End Region

#Region " Métodos "

    Private Sub frmGenerarGuiaRemisionSAT_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Try


            'UcPlantaDeEntregaOrigen.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowOnly
            'UcClienteTerceroOrigen.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowOnly
            'UcPlantaDeEntregaOrigen_Ransa.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowOnly
            'UcPlantaDeEntregaPropioDestino.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowOnly
            'UcClienteTerceroDestino.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowOnly
            'UcPlantaDeEntregaDestino.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowOnly
            bGenerar_Electronico_Default = Evaluar_Generar_GR_Serie_Electronico()

            Dim dt_tipoGR As New DataTable
            Dim objAyuda As New Ransa.Controls.TipoAyuda.TipoAyuda_DAL
            dt_tipoGR = objAyuda.fdtListar_TablaAyuda_L01("TPOGRM", "")
            cboTipoGR.DataSource = dt_tipoGR
            cboTipoGR.DisplayMember = "TDSDES"
            cboTipoGR.ValueMember = "CCMPRN"
            cboTipoGR.SelectedValue = "F"
            If bGenerar_Electronico_Default = True Then
                cboTipoGR.SelectedValue = "E"
            End If


            txtNroGuiaRemision.Text = ""

            PrecargarControles()
            CargarControl()
            CargarControles()

            ListaSerieGR()

            'bGenerar_Electronico_Default
            'cboTipoSerie_SelectionChangeCommitted(cboTipoSerie, Nothing)
            cboTipoGR_SelectionChangeCommitted(cboTipoGR, Nothing)
            'rbfisico_CheckedChanged(Nothing, Nothing)


            Dim dtbDatosAyuda As New DataTable
            'Dim objAyuda As New Ransa.Controls.TipoAyuda.TipoAyuda_DAL



            Dim oblGeneral As New brGeneral
            Dim olistGeneral As New List(Of beGeneral)
            Dim obegeneral As New beGeneral
            obegeneral.PSCODVAR = "SAPRGC"
            obegeneral.PSCCMPRN = _PNCCLNT
            olistGeneral = oblGeneral.ListaTablaAyuda(obegeneral)

            Me.txtprogramador.DropDownStyle = ComboBoxStyle.Simple
            If olistGeneral.Count > 0 Then

                obegeneral = New beGeneral
                obegeneral.PSCCMPRN = ""
                obegeneral.PSTDSDES = ":Seleccione:"
                olistGeneral.Insert(0, obegeneral)

                'obegeneral = New beGeneral
                'obegeneral.PSCCMPRN = ""
                'obegeneral.PSTDSDES = ""
                'olistGeneral.Insert(0, obegeneral)

                With txtprogramador
                    .DataSource = olistGeneral
                    .DisplayMember = "PSTDSDES"
                    .ValueMember = "PSCCMPRN"
                End With
                Me.txtprogramador.DropDownStyle = ComboBoxStyle.DropDownList
            End If

            'Me.txtprogramador.DropDownStyle = ComboBoxStyle.Simple
            'If (txtCliente.pCodigo = "11731" Or txtCliente.pCodigo = "30507") Then

            '    dtbDatosAyuda = objAyuda.fdtListar_TablaAyuda_L01("SAPRGC", "")
            '    With txtprogramador
            '        .DataSource = dtbDatosAyuda
            '        .DisplayMember = "TDSDES"
            '        .ValueMember = "CCMPRN"
            '    End With
            '    Me.txtprogramador.DropDownStyle = ComboBoxStyle.DropDownList
            'End If


            'Me.txtclasificacioncarga.DataSource = Nothing
            'Me.txtclasificacioncarga.DropDownStyle = ComboBoxStyle.Simple
            'If (txtCliente.pCodigo = "11731" Or txtCliente.pCodigo = "30507") Then
            'Dim dtbDatosAyuda As New DataTable

            dtbDatosAyuda = objAyuda.fdtListar_TablaAyuda_L01("SCLCRG", "")
            Dim dr As DataRow
            dr = dtbDatosAyuda.NewRow
            dr("CCMPRN") = ""
            dr("TDSDES") = ":Seleccione:"
            dtbDatosAyuda.Rows.InsertAt(dr, 0)
            With txtclasificacioncarga
                .DataSource = dtbDatosAyuda
                .DisplayMember = "TDSDES"
                .ValueMember = "CCMPRN"
            End With

            btnUbigeo_transporte_tramo.Enabled = False


            If bGenerar_Electronico_Default = True Then ' 2020 solo para Grupo Pacasmayo
                Dim dt_list_email_default As New DataTable
                dt_list_email_default = objAyuda.fdtListar_TablaAyuda_L01("EDFGRE", "")
                Dim email_por_default As String = ""
                Dim dr_email() As DataRow
                dr_email = dt_list_email_default.Select("CCMPRN='" & objSeguridadBN.pUsuario & "'")
                If dr_email.Length > 0 Then
                    txtsolicitante.Text = (dr_email(0)("TDSDES")).ToString.Trim
                End If
            End If

            'txtNroGuiaRemision.Select(0, 0)
          
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try


    End Sub

    'bGenerar_Electronico_Default
    Private Function Evaluar_Generar_GR_Serie_Electronico() As Boolean
        Dim retorno As Boolean = False
        Dim oblEnvioGR As New brGeneral
        Dim olistEnvioGR As New List(Of beGeneral)
        Dim obeParamEnvioGR As New beGeneral
        obeParamEnvioGR.PSCODVAR = "EVGRCL"
        obeParamEnvioGR.PSCCMPRN = ""
        olistEnvioGR = oblEnvioGR.ListaTablaAyuda(obeParamEnvioGR)
        For Each item As beGeneral In olistEnvioGR
            If item.PNCCLNT = _PNCCLNT Then
                retorno = True
                Exit For
            End If
        Next
        Return retorno
    End Function

    'Dim dtControlGR As New DataTable
    Dim dt_Listado_serie As New DataTable

    Private Sub ListaSerieGR()


        Dim obrGuiaRemision As New brGuiasRemision

        Dim dr As DataRow
        dt_Listado_serie = obrGuiaRemision.fdstListaSerieGR_x_Cliente(_PSCCMPN, _PSCDVSN, _PNCCLNT)

        dr = dt_Listado_serie.NewRow
        dr("CSERIE") = ""
        dr("TSERIE") = "Manual"
        dt_Listado_serie.Rows.Add(dr)

        cboTipoSerie.DataSource = dt_Listado_serie
        cboTipoSerie.DisplayMember = "TSERIE"
        cboTipoSerie.ValueMember = "CSERIE"
        If dt_Listado_serie.Rows.Count <= 1 Then
            cboTipoSerie.Enabled = False
        End If
        If dt_Listado_serie.Rows.Count > 1 Then
            cboTipoGR.SelectedValue = "E"

        End If


       


    End Sub
    Private Sub UcClienteTerceroOrigen_TextChanged() Handles UcClienteTerceroOrigen.TextChanged
        Try
            UcPlantaDeEntregaOrigen.pClear()
            UcPlantaDeEntregaOrigen.CodClienteTercero = UcClienteTerceroOrigen.ItemActual.PNCPRVCL
            txt_ubigeo_origen_recojo.Tag = "0"
            txt_ubigeo_origen_recojo.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub UcClienteTerceroDestino_TextChanged() Handles UcClienteTerceroDestino.TextChanged

        Try
            UcPlantaDeEntregaDestino.pClear()
            UcPlantaDeEntregaDestino.CodClienteTercero = UcClienteTerceroDestino.ItemActual.PNCPRVCL
            txt_ubigeo_destino_cliente.Tag = "0"
            txt_ubigeo_destino_cliente.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

      
    End Sub

    Private Sub txtMedioSugerido_ActivarAyuda(ByRef objData As Object) Handles txtMedioSugerido.ActivarAyuda
        Dim obrMedioTransporte As New Ransa.NEGO.brGeneral
        Dim obeMedioTransporte As New Ransa.TypeDef.beGeneral
        objData = obrMedioTransporte.ListaMedioTransporte(obeMedioTransporte)
    End Sub

    Private Sub txtMedioSugerido_CambioDeTexto1(ByVal strData As String, ByRef objData As Object) Handles txtMedioSugerido.CambioDeTexto
        Try
            If Not strData.Trim.Equals("") Then
                Dim obrMedioTransporte As New RANSA.NEGO.brGeneral
                Dim obeMedioTransporte As New RANSA.TYPEDEF.beGeneral
                With obeMedioTransporte
                    .PNCMEDTR = Val(strData)
                    .PSTNMMDT = strData
                End With
                objData = obrMedioTransporte.ListaMedioTransporte(obeMedioTransporte)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    
    End Sub

    Private Sub bsaEmpresaTransporteListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaEmpresaTransporteListar.Click

        Try
            Call mfblnBuscar_EmpresaTransporte(txtEmpresaTransporte.Tag, txtEmpresaTransporte.Text, _strNroRUCTransportisdta, _strDireccionTransportista)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub txtEmpresaTransporte_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmpresaTransporte.KeyDown

        Try
            If e.KeyCode = Keys.F4 Then
                Call mfblnBuscar_EmpresaTransporte(txtEmpresaTransporte.Tag, txtEmpresaTransporte.Text, _strNroRUCTransportisdta, _strDireccionTransportista)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

      
    End Sub

    Private Sub txtEmpresaTransporte_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmpresaTransporte.TextChanged
        txtEmpresaTransporte.Tag = ""
    End Sub

    Private Sub txtEmpresaTransporte_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEmpresaTransporte.Validating

        Try
            If txtEmpresaTransporte.Text = "" Then
                txtEmpresaTransporte.Tag = ""
            Else
                If txtEmpresaTransporte.Text <> "" And "" & txtEmpresaTransporte.Tag = "" Then
                    Call mfblnBuscar_EmpresaTransporte(txtEmpresaTransporte.Tag, txtEmpresaTransporte.Text, _strNroRUCTransportisdta, _strDireccionTransportista)
                    If txtEmpresaTransporte.Text = "" Then
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

       
    End Sub

    Private Sub bsaPlacaUnidadListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaPlacaUnidadListar.Click

        Try
            Call mfblnBuscar_PlacaUnidad("" & txtEmpresaTransporte.Tag, txtPlacaUnidad.Text, txtPlacaAcoplado.Text, txtNroBrevete.Text, "", "", pstrMTC)
            txtPlacaUnidad.Tag = txtPlacaUnidad.Text
            txtPlacaUnidad.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

   
    End Sub

    Private Sub txtPlacaUnidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPlacaUnidad.KeyDown
        Try

            If e.KeyCode = Keys.F4 Then
                Call mfblnBuscar_PlacaUnidad("" & txtEmpresaTransporte.Tag, txtPlacaUnidad.Text, txtPlacaAcoplado.Text, txtNroBrevete.Text, "", "", pstrMTC)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtPlacaUnidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPlacaUnidad.TextChanged
        txtPlacaUnidad.Tag = ""
    End Sub

    Private Sub txtPlacaUnidad_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPlacaUnidad.Validating

        Try
            If txtPlacaUnidad.Text = "" Then
                txtPlacaAcoplado.Text = ""
                txtNroBrevete.Text = ""
            Else
                If txtPlacaUnidad.Text <> "" And "" & txtPlacaUnidad.Tag = "" Then
                    Call mfblnBuscar_PlacaUnidad("" & txtEmpresaTransporte.Tag, txtPlacaUnidad.Text, txtPlacaAcoplado.Text, txtNroBrevete.Text, "", "", pstrMTC)
                    If txtPlacaUnidad.Text = "" Then
                        txtPlacaAcoplado.Text = ""
                        txtNroBrevete.Text = ""
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

   
    End Sub

    Private Sub bsaNroBreveteListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaNroBreveteListar.Click

        Try
            Call mfblnBuscar_Brevete("" & txtEmpresaTransporte.Tag, txtNroBrevete.Text, _strDriver, "")
            txtNroBrevete.Tag = txtNroBrevete.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    
    End Sub

    Private Sub bsaPlacaAcopladoListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaPlacaAcopladoListar.Click
        Try
            Call pBuscarPlacaAcoplado(txtEmpresaTransporte.Tag, txtPlacaAcoplado.Text, booValidarPlacaAcoplado)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub txtNroBrevete_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNroBrevete.KeyDown
        Try
            If e.KeyCode = Keys.F4 Then
                Call mfblnBuscar_Brevete("" & txtEmpresaTransporte.Tag, txtNroBrevete.Text, _strDriver, "")
                txtNroBrevete.Tag = txtNroBrevete.Text
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

      
    End Sub

    Private Sub txtNroBrevete_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroBrevete.TextChanged
        txtNroBrevete.Tag = ""
    End Sub

    Private Sub txtNroBrevete_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNroBrevete.Validating

        Try
            If txtNroBrevete.Text = "0" Or txtNroBrevete.Text = "" Then
                txtNroBrevete.Text = ""
                txtNroBrevete.Tag = ""
            Else
                Call mfblnBuscar_Brevete("" & txtEmpresaTransporte.Tag, txtNroBrevete.Text, _strDriver, "")
                txtNroBrevete.Tag = txtNroBrevete.Text
                If txtNroBrevete.Text = "" Then
                    e.Cancel = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

      
    End Sub

    Private Sub txtPlacaAcoplado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPlacaAcoplado.KeyDown

        Try
            If e.KeyCode = Keys.F4 Then
                Call pBuscarPlacaAcoplado(txtEmpresaTransporte.Tag, txtPlacaAcoplado.Text, booValidarPlacaAcoplado)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

      
    End Sub

    Private Sub txtPlacaAcoplado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPlacaAcoplado.TextChanged
        booValidarPlacaAcoplado = False
    End Sub

    Private Sub txtPlacaAcoplado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPlacaAcoplado.Validating

        Try
            If txtPlacaAcoplado.Text = "0" Or txtPlacaAcoplado.Text = "" Then
                'txtPlacaAcoplado.Text = "0"
                txtPlacaAcoplado.Text = ""
                txtPlacaAcoplado.Tag = ""
            Else
                If Not booValidarPlacaAcoplado Then
                    Call pBuscarPlacaAcoplado(txtEmpresaTransporte.Tag, txtPlacaAcoplado.Text, booValidarPlacaAcoplado)
                    If txtPlacaAcoplado.Text = "" Then
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

      
    End Sub

    Private Sub txtEmpresaTransporte2doTramo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmpresaTransporte2doTramo.KeyDown
        Try
            If e.KeyCode = Keys.F4 Then
                Call mfblnBuscar_EmpresaTransporte(txtEmpresaTransporte2doTramo.Tag, txtEmpresaTransporte2doTramo.Text, _strNroRUCTransportisdta)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

      
    End Sub

    Private Sub txtEmpresaTransporte2doTramo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmpresaTransporte2doTramo.TextChanged
        txtEmpresaTransporte2doTramo.Tag = ""
    End Sub

    Private Sub txtEmpresaTransporte2doTramo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEmpresaTransporte2doTramo.Validating
        Try
            If "" & txtEmpresaTransporte2doTramo.Text = "" Then
                txtEmpresaTransporte2doTramo.Tag = ""
            Else
                If txtEmpresaTransporte2doTramo.Text <> "" And "" & txtEmpresaTransporte2doTramo.Tag = "" Then
                    Call mfblnBuscar_EmpresaTransporte(txtEmpresaTransporte2doTramo.Tag, txtEmpresaTransporte2doTramo.Text, _strNroRUCTransportisdta, _strDireccionTransportista)
                    If txtEmpresaTransporte2doTramo.Text = "" Then
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

      
    End Sub

    Private Sub bsaEmpresaTransporte2doTramoListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaEmpresaTransporte2doTramoListar.Click
        Try
            mfblnBuscar_EmpresaTransporte(txtEmpresaTransporte2doTramo.Tag, txtEmpresaTransporte2doTramo.Text, "")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub rbtPlantaCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtPlantaCliente.CheckedChanged
        'UcPlantaDeEntregaPropioDestino.Enabled = True
        'UcClienteTerceroDestino.Enabled = False
        'UcClienteTerceroDestino.pClear()
        'UcPlantaDeEntregaDestino.Enabled = False
        'UcPlantaDeEntregaDestino.pClear()
        Try
            UcClienteTerceroDestino.pClear()
            UcPlantaDeEntregaDestino.pClear()

            txt_ubigeo_destino_cliente.Tag = "0"
            txt_ubigeo_destino_cliente.Text = ""

            tab_destino.TabPages.Remove(tpg_destino_planta)
            tab_destino.TabPages.Remove(tpg_destino_cliente)
            tab_destino.TabPages.Add(tpg_destino_planta)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try

     
    End Sub

    Private Sub rbtClienteTercero_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtClienteTercero.CheckedChanged
        'UcPlantaDeEntregaPropioDestino.Enabled = False
        'UcPlantaDeEntregaPropioDestino.pClear()
        'UcClienteTerceroDestino.Enabled = True
        'UcPlantaDeEntregaDestino.Enabled = True
        'If _EsRecojo Then
        '    If UcPlantaDeEntregaOrigen.ItemActual.PNCPRVCL = 0 Then
        '        UcPlantaDeEntregaPropioDestino.Enabled = False
        '    End If
        'End If
        Try
            UcPlantaDeEntregaPropioDestino.pClear()

            txt_ubigeo_destino_planta.Tag = "0"
            txt_ubigeo_destino_planta.Text = ""

            tab_destino.TabPages.Remove(tpg_destino_planta)
            tab_destino.TabPages.Remove(tpg_destino_cliente)
            tab_destino.TabPages.Add(tpg_destino_cliente)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try

      

    End Sub

    Private Sub txtMotivoTraslado_CambioDeTexto(ByVal objData As Object) Handles txtMotivoTraslado.CambioDeTexto
        Try
            If objData Is Nothing Then Exit Sub
            If (objSeguridadBN.pstrTipoSistema = "01" And "" & CType(objData, beGeneral).PSSTPING = "A") Or _
            (objSeguridadBN.pstrTipoSistema = "04" And "" & CType(objData, beGeneral).PSSTPING = "A") Or _
                  (objSeguridadBN.pstrTipoSistema = "03" And "" & CType(objData, beGeneral).PSSTPING = "8") Then
                txtObsOtrosMotivos.ReadOnly = False
            Else
                txtObsOtrosMotivos.Text = ""
                txtObsOtrosMotivos.ReadOnly = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub chkAutoGenerar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAutoGenerar.CheckedChanged
        Try
            fAutoGenerarGuiaRemision(Me.chkAutoGenerar.Checked)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Try
            If Not fblnValidarControles() Then Exit Sub

            Dim obrGuiaRemision As New brGuiasRemision
            Dim msg_validacion As String = ""

            Dim pTipoGuia As String = ("" & cboTipoGR.SelectedValue)

            If pTipoGuia = "E" Then
                msg_validacion = obrGuiaRemision.Validar_Registro_GR_Cliente_Electronico(_PSCCMPN, _PSCDVSN, _PNCCLNT)
                If msg_validacion.Length > 0 Then
                    MessageBox.Show(msg_validacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If

            If MessageBox.Show("Desea generar la guía de remisión??", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
            Select Case objSeguridadBN.pstrTipoSistema
                Case "01"
                    Dim obeGuiaRemision As beGuiaRemision = New beGuiaRemision
                    With obeGuiaRemision
                        Decimal.TryParse(_PNCCLNT, .PNCCLNT)
                        Int64.TryParse(Me.txtCliente.pCodigo, .PNCCLNGR)
                        .PSCCMPN = _PSCCMPN
                        .PSCDVSN = _PSCDVSN
                        .PNCPLNDV = _PNCPLNDV


                        If _EsPredespacho Then
                            .PNNROCTL = _PNNROCTL
                        Else
                            .PNNRGUSA = Val(strNRGUIA)
                        End If
                        .PNFGUIRM = HelpClass.CDate_a_Numero8Digitos(Me.dtpFechaEmision.Value)
                        .PNFINTRA = HelpClass.CDate_a_Numero8Digitos(Me.dtpFechaTraslado.Value)
                        If _EsRecojo Then
                            .PNCPRVCO = UcClienteTerceroOrigen.ItemActual.PNCPRVCL '  Codigo Cliente Tercero Origen    
                            .PNCPLCLO = UcPlantaDeEntregaOrigen.ItemActual.PNCPLNCL '  Codigo Planta Tercero Origen    
                            .PSCREFFW = _PSCREFFW
                        Else
                            '.PNCPLNOR = UcPlantaDeEntregaOrigen.ItemActual.PNCPLNCL
                            .PNCPLNOR = UcPlantaDeEntregaOrigen_Ransa.ItemActual.PNCPLNCL
                        End If
                        If rbtPlantaCliente.Checked Then
                            .PNCPLNCL = UcPlantaDeEntregaPropioDestino.ItemActual.PNCPLNCL '  Codigo Planta Cliente            
                        Else
                            .PNCPRVCL = UcClienteTerceroDestino.ItemActual.PNCPRVCL '     Codigo Cliente Tercero           
                            .PNCPLCLP = UcPlantaDeEntregaDestino.ItemActual.PNCPLNCL ' Codigo Planta Tercero    
                        End If

                        .PSSMTGRM = CType(txtMotivoTraslado.Resultado, beGeneral).PSSTPING
                        .PSTOBORM = txtObsOtrosMotivos.Text
                        '.PSNGUIRM = txtNroGuiaRemision.Text
                        .PSNGUIRS = txtNroGuiaRemision.Text

                        Decimal.TryParse(txtEmpresaTransporte.Tag, .PNCTRSPT)
                        .PSNPLCCM = txtPlacaUnidad.Text
                        .PSNPLACP = txtPlacaAcoplado.Text
                        .PSNBRVCH = txtNroBrevete.Text
                        If txtObservaciones.Text.Trim.Length > 30 Then
                            .PSTOBSRM = txtObservaciones.Text.Trim.Substring(0, 30)
                            .PSTOBCLI = txtObservaciones.Text.Trim.Substring(30, txtObservaciones.Text.Trim.Length - 30)
                        Else
                            .PSTOBSRM = txtObservaciones.Text.Trim
                            .PSTOBCLI = ""
                        End If

                        .PNCUBGET = 0
                        If chkDosTramos.Checked Then
                            .PNNDCMRF = txtEmpresaTransporte2doTramo.Tag
                            .PNCUBGET = Val("" & txt_ubigeo_tramos.Tag)
                        End If

                        'If chkDosTramos.Checked Then _
                        ' .PNNDCMRF = txtEmpresaTransporte2doTramo.Tag
                        If Not UcAyuda1.Resultado Is Nothing Then
                            .PNCMEDTR = CType(UcAyuda1.Resultado, RANSA.TypeDef.beGeneral).PNCMEDTR
                        End If



                        'fin
                        .PSCPRCN1 = txtSigla.Text.Trim
                        .PSNSRCN1 = txtNumeroContenedor.Text.Trim
                        .PSUSUARIO = objSeguridadBN.pUsuario
                        .strAplicacion = Application.StartupPath
                        .pstrTipoMovIntfz = strTipoMovIntfz
                        .TipoRep = nTipoGuia

                        'Agregando los datos de referencia adicional
                        '.CLCRGA = Me.txtclasificacioncarga.Text
                        .CLCRGA = (Me.txtclasificacioncarga.SelectedValue & "").ToString.Trim

                        If Me.txtprogramador.DropDownStyle = ComboBoxStyle.DropDownList Then
                            If txtprogramador.SelectedValue <> "" Then
                                .UPROGM = Me.txtprogramador.Text.Trim
                            End If
                        Else
                            .UPROGM = Me.txtprogramador.Text.Trim
                        End If

                        .EMAPRB = Me.txtcorreoaprobacion.Text.Trim
                        .USLCNT = Me.txtsolicitante.Text.Trim
                        .APRBDO = Me.txtaprobador.Text.Trim
                        .GRENCI = Me.txtgerencia.Text.Trim
                        .AREASL = Me.txtArea.Text.Trim
                        .SERIEGR = ("" & cboTipoSerie.SelectedValue)
                        .PSCTDGRM = ("" & cboTipoGR.SelectedValue)

                      
                    End With
                    Dim obeListaObservacion As New List(Of beGuiaRemision)
                    Dim obeObervacion As beGuiaRemision
                    For intRow As Integer = 0 To Me.dtgObservacion.Rows.Count - 2
                        obeObervacion = New beGuiaRemision
                        With obeObervacion
                            .PNCCLNGR = obeGuiaRemision.PNCCLNGR
                            .PSNGUIRM = obeGuiaRemision.PSNGUIRM
                            .PSUSUARIO = objSeguridadBN.pUsuario
                            .PSNTRMNL = objSeguridadBN.pstrPCName
                            .PSTOBDGS = dtgObservacion.Rows(intRow).Cells("TOBSGS").Value
                        End With
                        obeListaObservacion.Add(obeObervacion)
                    Next

                    mpGenerarGuiaRemisionAT(obeGuiaRemision, obeListaObservacion)
            End Select


            'pGenerarReporte()
        Catch ex As Exception
            'MsgBox("se ha producido un error , por favor notifique al área de sistemas")
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopiar.Click
        Try
            If objCopiarPegar Is Nothing Then
                objCopiarPegar = New clsCopiar_Pegar
            End If
            With objCopiarPegar
                'GuiaRemision
                .pdtpFechaEmision = dtpFechaEmision.Value
                .ptxtMotivoTrasladoTag = CType(txtMotivoTraslado.Resultado, beGeneral).PSSTPING
                .ptxtMotivoTrasladoText = txtMotivoTraslado.Text
                .ptxtObsOtrosMotivos = txtObsOtrosMotivos.Text

                'OrigenDestino
                If _EsRecojo = True Then
                    .ptxtClienteOrigenTag = UcPlantaDeEntregaOrigen.ItemActual.PNCCLNT
                    .ptxtPlantaOrigenTag = UcPlantaDeEntregaOrigen.ItemActual.PNCPLNCL
                    .ptxtPlantaOrigenText = UcPlantaDeEntregaOrigen.ItemActual.PSTDRCPL.Trim
                Else
                    .ptxtClienteOrigenTag = UcPlantaDeEntregaOrigen_Ransa.ItemActual.PNCCLNT
                    .ptxtPlantaOrigenTag = UcPlantaDeEntregaOrigen_Ransa.ItemActual.PNCPLNCL
                    .ptxtPlantaOrigenText = UcPlantaDeEntregaOrigen_Ransa.ItemActual.PSTDRCPL.Trim
                End If

                '.ptxtClienteOrigenTag = UcPlantaDeEntregaOrigen.ItemActual.PNCCLNT
                '.ptxtPlantaOrigenTag = UcPlantaDeEntregaOrigen.ItemActual.PNCPLNCL
                '.ptxtPlantaOrigenText = UcPlantaDeEntregaOrigen.ItemActual.PSTDRCPL.Trim
                'OrigenDestino'Planta
                .prbtPlantaCliente = rbtPlantaCliente.Checked
                .ptxtClienteDestinoTag = UcPlantaDeEntregaPropioDestino.ItemActual.PNCCLNT
                .ptxtPlantaClienteTag = UcPlantaDeEntregaPropioDestino.ItemActual.PNCPLNCL
                .ptxtPlantaClienteText = UcPlantaDeEntregaPropioDestino.ItemActual.PSTDRCPL.Trim
                'OrigenDestino'Cliente
                .prbtClienteTercero = rbtClienteTercero.Checked
                'ClienteTercero   
                .ptxtClienteTerceroTag = _PNCCLNT
                .ptxtTipoRelacionText = UcClienteTerceroDestino.ItemActual.PSSTPORL
                .ptxtRucProveedorText = UcClienteTerceroDestino.ItemActual.PNNRUCPR
                .ptxtProveedor = UcClienteTerceroDestino.ItemActual.PNCPRVCL
                .ptxtClienteTerceroText = UcClienteTerceroDestino.ItemActual.PSTPRVCL

                .ptxtProveedorCliente = UcPlantaDeEntregaDestino.ItemActual.PNCCLNT
                .ptxtPlantaClienteTerceroTag = UcPlantaDeEntregaDestino.ItemActual.PNCPLNCL
                'Informacion Transporte
                .ptxtEmpresaTransporteTag = txtEmpresaTransporte.Tag
                .ptxtEmpresaTransporteText = txtEmpresaTransporte.Text
                .ptxtPlacaUnidadTag = txtPlacaUnidad.Tag
                .ptxtPlacaUnidadText = txtPlacaUnidad.Text
                .ptxtNroBreveteTag = txtNroBrevete.Tag
                .ptxtNroBreveteText = txtNroBrevete.Text
                .ptxtPlacaAcopladoTag = txtPlacaAcoplado.Tag
                .ptxtPlacaAcopladoText = txtPlacaAcoplado.Text
                .ptxtObservaciones = txtObservaciones.Text
                .pchkDosTramos = chkDosTramos.Checked
                .ptxtEmpresaTransporte2doTramoTag = txtEmpresaTransporte2doTramo.Tag
                .ptxtEmpresaTransporte2doTramoText = txtEmpresaTransporte2doTramo.Text
                .ptxtSiglatext = txtSigla.Text
                .ptxtNumeroContenedortext = txtNumeroContenedor.Text

                'agregando el contenido de referencias adicionales
                .ptxtClasificacionCarga = txtclasificacioncarga.SelectedValue
                .ptxtProgramador = txtprogramador.Text.Trim
                .ptxtCorreoAprobacion = txtcorreoaprobacion.Text.Trim
                .ptxtSolicitante = txtsolicitante.Text.Trim
                .ptxtAprobacion = txtaprobador.Text.Trim
                .ptxtGerencia = txtgerencia.Text.Trim
                .ptxtArea = txtArea.Text.Trim

                .ptxtMedioSugeridoTag = CType(UcAyuda1.Resultado, beGeneral).PNCMEDTR
                .ptxtMedioSugeridoText = CType(UcAyuda1.Resultado, beGeneral).PSTNMMDT

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub btnPegar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPegar.Click

        Try
            If objCopiarPegar Is Nothing Then
                MessageBox.Show("No a realizado copia de Guia de Remision.")
            Else
                With objCopiarPegar
                    'GuiaRemision
                    dtpFechaEmision.Value = .pdtpFechaEmision
                    txtMotivoTraslado.Valor = .ptxtMotivoTrasladoTag
                    txtMotivoTraslado.Refresh()
                    txtObservaciones.Text = .ptxtObservaciones
                    'Add by MATARAMA, 14-11-2018
                    txtObsOtrosMotivos.Text = .ptxtObsOtrosMotivos

                    'OrigenDestino
                    Dim oPlantaEntrega As New RANSA.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega
                    oPlantaEntrega.PNCCLNT = .ptxtClienteOrigenTag
                    oPlantaEntrega.PNCPLNCL = .ptxtPlantaOrigenTag
                    'UcPlantaDeEntregaOrigen.pCargar(oPlantaEntrega)
                    If _EsRecojo = True Then
                        UcPlantaDeEntregaOrigen.pCargar(oPlantaEntrega)
                    Else
                        UcPlantaDeEntregaOrigen_Ransa.pCargar(oPlantaEntrega)
                    End If

                    rbtPlantaCliente.Checked = .prbtPlantaCliente
                    'UcPlantaDeEntregaPropioDestino
                    If rbtPlantaCliente.Checked = True Then
                        Dim oPlantaEntProDest As New RANSA.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega
                        oPlantaEntProDest.PNCCLNT = .ptxtClienteDestinoTag
                        oPlantaEntProDest.PNCPLNCL = .ptxtPlantaClienteTag
                        UcPlantaDeEntregaPropioDestino.pCargar(oPlantaEntProDest)
                    End If

                    rbtClienteTercero.Checked = .prbtClienteTercero
                    If rbtClienteTercero.Checked = True Then
                        'Cliente
                        Dim oClienteTerceroDestino As New RANSA.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega
                        oClienteTerceroDestino.PNCCLNT = _PNCCLNT
                        oClienteTerceroDestino.PNCPRVCL = .ptxtProveedor
                        oClienteTerceroDestino.PSTPRVCL = .ptxtClienteTerceroText
                        oClienteTerceroDestino.PSSTPORL = .ptxtTipoRelacionText
                        oClienteTerceroDestino.PNNRUCPR = .ptxtRucProveedorText
                        UcClienteTerceroDestino.pCargar2(oClienteTerceroDestino)
                        UcClienteTerceroDestino.Refresh()

                        'Planta
                        Dim oPlantaDeEntregaDestino As New RANSA.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega
                        oPlantaDeEntregaDestino.PNCCLNT = _PNCCLNT
                        oPlantaDeEntregaDestino.PNCPRVCL = .ptxtProveedor
                        oPlantaDeEntregaDestino.PNCPLNCL = .ptxtPlantaClienteTerceroTag
                        oPlantaDeEntregaDestino.PSTCMPPL = UcClienteTerceroDestino.ItemActual.PSTPRVCL
                        UcPlantaDeEntregaDestino.pCargar(oPlantaDeEntregaDestino)
                        UcPlantaDeEntregaDestino.Refresh()
                    End If

                    'Informacion Transporte
                    txtEmpresaTransporte.Tag = .ptxtEmpresaTransporteTag
                    txtEmpresaTransporte.Text = .ptxtEmpresaTransporteText
                    txtEmpresaTransporte.Select()
                    txtPlacaUnidad.Tag = .ptxtPlacaUnidadTag
                    txtPlacaUnidad.Text = .ptxtPlacaUnidadText
                    txtPlacaUnidad.Select()

                    txtPlacaAcoplado.Tag = .ptxtPlacaAcopladoTag
                    txtPlacaAcoplado.Text = .ptxtPlacaAcopladoText
                    txtPlacaAcoplado.Select()
                    txtObservaciones.Text = .ptxtObservaciones
                    chkDosTramos.Checked = .pchkDosTramos
                    txtEmpresaTransporte2doTramo.Tag = .ptxtEmpresaTransporte2doTramoTag
                    txtEmpresaTransporte2doTramo.Text = .ptxtEmpresaTransporte2doTramoText
                    txtEmpresaTransporte2doTramo.Select()

                    txtclasificacioncarga.Text = .ptxtClasificacionCarga
                    txtprogramador.Text = .ptxtProgramador
                    txtcorreoaprobacion.Text = .ptxtCorreoAprobacion
                    txtsolicitante.Text = .ptxtSolicitante
                    txtaprobador.Text = .ptxtAprobacion
                    txtgerencia.Text = .ptxtGerencia
                    txtArea.Text = .ptxtArea


                    txtSigla.Text = .ptxtSiglatext
                    txtNumeroContenedor.Text = .ptxtNumeroContenedortext
                    UcAyuda1.Valor = .ptxtMedioSugeridoTag
                    UcAyuda1.Refresh()
                    txtNroBrevete.Tag = .ptxtNroBreveteTag
                    txtNroBrevete.Text = .ptxtNroBreveteText
                    txtNroBrevete.Select()


                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

       
    End Sub

    Private Sub txtNroGuiaRemision_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNroGuiaRemision.Validating
        Try

            If txtNroGuiaRemision.Text <> "" And "" & txtNroGuiaRemision.Text <> "0" Then
                Dim obrGuiaRemision As New DespachoSDS.brGuiasRemision
                Dim obeguiaremision As New beGuiaRemision
                obeguiaremision.PNCCLNT = Me.txtCliente.pCodigo
                'obeguiaremision.PSNGUIRM = Me.txtNroGuiaRemision.Text
                obeguiaremision.PSNGUIRS = Me.txtNroGuiaRemision.Text.Trim
                obeguiaremision.PSCTDGRM = ("" & cboTipoGR.SelectedValue)

                'If obrGuiaRemision.fboolExisteGuiaRemision(obeguiaremision) Then
                If obrGuiaRemision.fboolExisteGuiaRemision_S(obeguiaremision) Then
                    e.Cancel = True
                    HelpClass.MsgBox("La guía Nro. " & Me.txtNroGuiaRemision.Text & _
                " se encuentra registrada, digite guía de remisión correcta ", MessageBoxIcon.Warning)
                End If

                ' COMENTADO 2020
                'Dim objGuiaRemision As New beGuiaRemision
                'Dim Fecha As Date
                'Dim FechaGR As String
                'Dim FechaAnt As Int64
                'objGuiaRemision = obrGuiaRemision.fObtenerMaxInferiorGuiaRemision(obeguiaremision)
                'If objGuiaRemision IsNot Nothing Then
                '    Dim obeguiarem As New beGuiaRemision
                '    Fecha = dtpFechaEmision.Value
                '    FechaGR = HelpClass.CDate_a_Numero8Digitos(Fecha)
                '    FechaAnt = objGuiaRemision.PNFGUIRM
                '    If Convert.ToDecimal(FechaGR) < objGuiaRemision.PNFGUIRM Then
                '        HelpClass.MsgBox("No procede, debe ser mayor a la Fecha de la Guía anterior que es el Nro. " & objGuiaRemision.PSNGUIRM & _
                '    " con Fecha " & HelpClass.CNumero8Digitos_a_FechaDefault(FechaAnt), MessageBoxIcon.Warning)
                '        btnAceptar.Enabled = False
                '    Else
                '        btnAceptar.Enabled = True
                '    End If
                'End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


      

    End Sub

    Private Sub txtManChoferes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtManChoferes.Click

        Try
            If txtEmpresaTransporte.Tag = "0" Or txtEmpresaTransporte.Tag = String.Empty Then Return
            Dim ofrmMantenimientoChofer As New frmMantenimientoChofer
            ofrmMantenimientoChofer.CTRSPT = Convert.ToInt32(Me.txtEmpresaTransporte.Tag)
            If ofrmMantenimientoChofer.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.txtNroBrevete.Text = ofrmMantenimientoChofer.Brevete
                txtNroBrevete.Tag = ofrmMantenimientoChofer.Brevete
                txtNroBrevete_Validating(Nothing, Nothing)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub txtMantCamiones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMantCamiones.Click

        Try
            If txtEmpresaTransporte.Tag = String.Empty Or txtEmpresaTransporte.Tag = "0" Then Return
            Dim ofrmMantenimientoUnidad As New frmMantenimientoUnidad
            ofrmMantenimientoUnidad.CTRSPT = Convert.ToInt32(txtEmpresaTransporte.Tag)
            If ofrmMantenimientoUnidad.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.txtPlacaUnidad.Text = ofrmMantenimientoUnidad.Placa
                Me.txtPlacaUnidad.Tag = ofrmMantenimientoUnidad.Placa
                Me.txtPlacaUnidad_Validating(Nothing, Nothing)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    'Private Sub dtpFechaEmision_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpFechaEmision.Validating
    '    ValidarFechaGuiaRemision()
    'End Sub

    'Private Sub dtpFechaEmision_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaEmision.ValueChanged
    '    ValidarFechaGuiaRemision()
    'End Sub

    Private Sub chkDosTramos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDosTramos.CheckedChanged
        Try
            If chkDosTramos.Checked Then
                txtEmpresaTransporte2doTramo.Enabled = True

                btnUbigeo_transporte_tramo.Enabled = True
            Else
                txtEmpresaTransporte2doTramo.Text = ""
                txtEmpresaTransporte2doTramo.Tag = ""
                txtEmpresaTransporte2doTramo.Enabled = False

                txt_ubigeo_tramos.Tag = "0"
                txt_ubigeo_tramos.Text = ""
                btnUbigeo_transporte_tramo.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

     
    End Sub

#End Region

    'Private Sub KryptonGroup1_Panel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles KryptonGroup1.Panel.Paint

    'End Sub



    'Private Sub ActualizarEstadoEnvioGuia_WS(ByVal obeGuiaRemision As beGuiaRemision)

    '    Dim ReportEnvio As New WSBrokers.ReportEnvioWsBroker
    '    Dim obrGuiaRemision As New brGuiasRemision
    '    Dim objServicio As New WSBrokers.Operaciones.Despacho.EsbIntminsurSolminDespachoService
    '    Dim objRequest As New WSBrokers.Operaciones.Despacho.DespachoRequestSolmin

    '    Dim itemRequest As New WSBrokers.Operaciones.Despacho.ITEM
    '    Dim dataRequest As New WSBrokers.Operaciones.Despacho.WSDATAREQUEST
    '    Dim HedearRequest2 As New WSBrokers.Operaciones.Despacho.Header
    '    '=================cargamos el Header.=====================
    '    HedearRequest2.Application = ""
    '    HedearRequest2.Channel = ""
    '    HedearRequest2.Client = ""
    '    HedearRequest2.Society = ""
    '    HedearRequest2.TransactionDate = Today.ToString("yyyMMdd")
    '    HedearRequest2.TransactionId = Guid.NewGuid().ToString()
    '    '=========================================================
    '    Dim objwebservice As New WSBrokers.Operaciones.Despacho.WEBSERVICE
    '    Dim objTrasRequest As New WSBrokers.Operaciones.Despacho.TRANSACTIONREQUEST
    '    Dim objDataRequest_ As New WSBrokers.Operaciones.Despacho.DataRequest
    '    Dim objMessaje As New WSBrokers.Operaciones.Despacho.MENSAJE
    '    Dim objResponse As New WSBrokers.Operaciones.Despacho.DespachoResponseSolmin

    '    Dim dt As New DataTable
    '    dt = obrGuiaRemision.ListaGuiaRemisionEnviarWS(obeGuiaRemision)
    '    If dt.Rows.Count > 0 Then
    '        Dim objListaItems(dt.Rows.Count - 1) As WSBrokers.Operaciones.Despacho.ITEM
    '        Dim objRequesROW As New WSBrokers.Operaciones.Despacho.DATAROW

    '        For i As Integer = 0 To dt.Rows.Count - 1
    '            'cargamos  la Data.
    '            objListaItems(i) = New WSBrokers.Operaciones.Despacho.ITEM
    '            objRequesROW.CCLNT = Convert.ToInt32(dt.Rows.Item(i)(0))
    '            objRequesROW.FECDOC = Convert.ToInt32(dt.Rows.Item(i)(1))
    '            objRequesROW.FECCONT = dt.Rows.Item(i)(2).ToString.Trim
    '            objRequesROW.REFDOC = dt.Rows.Item(i)(3).ToString.Trim
    '            objRequesROW.TXTCAB = dt.Rows.Item(i)(4).ToString.Trim

    '            objRequesROW.RUC_TRANSPORTE = dt.Rows.Item(i)(13).ToString.Trim
    '            objRequesROW.PLACA_VEHICULO = dt.Rows.Item(i)(14).ToString.Trim
    '            objRequesROW.COD_BREVETE = dt.Rows.Item(i)(15).ToString.Trim
    '            objRequesROW.NOM_CONDUCTOR = dt.Rows.Item(i)(16).ToString.Trim
    '            objRequesROW.MOT_TRASLADO = dt.Rows.Item(i)(17).ToString.Trim
    '            objRequesROW.TXT_CAB_GUIA = dt.Rows.Item(i)(18).ToString.Trim

    '            'Detalle.

    '            objListaItems(i).NORCML = dt.Rows.Item(i)(6).ToString.Trim
    '            objListaItems(i).NRITOC = Convert.ToInt32(dt.Rows.Item(i)(7))
    '            objListaItems(i).TCITCL = dt.Rows.Item(i)(8).ToString.Trim
    '            objListaItems(i).QCNTIT = Convert.ToDouble(dt.Rows.Item(i)(9))

    '            If (dt.Rows.Item(i)(10).ToString.Trim.Length > 3) Then
    '                dt.Rows.Item(i)(10).ToString.Trim.Substring(0, 3)
    '            Else
    '                dt.Rows.Item(i)(10).ToString.Trim()
    '            End If
    '            objListaItems(i).TRFRN1 = dt.Rows.Item(i)(11).ToString.Trim
    '            objListaItems(i).TRFRN2 = dt.Rows.Item(i)(12).ToString.Trim

    '            objListaItems(i).CENTORT = "" 'dt.Rows.Item(i)(10).ToString.Trim
    '            objListaItems(i).ALMORT = "" ' dt.Rows.Item(i)(10).ToString.Trim

    '            objListaItems(i).TXT_DET_GUIA = dt.Rows.Item(i)(19).ToString.Trim
    '        Next

    '        dataRequest.DATAROW = objRequesROW
    '        dataRequest.DATAROW.DETAIL = objListaItems

    '        objMessaje.WSDATAREQ = dataRequest
    '        objTrasRequest.MENSAJE = objMessaje
    '        objwebservice.TRANSACCION = objTrasRequest
    '        objDataRequest_.WEBSERVICE = objwebservice

    '        objRequest.Header = HedearRequest2
    '        objRequest.Data = objDataRequest_

    '        objResponse = objServicio.OpDespachoSolmin(objRequest)
    '        If objResponse.Data.WSDATARES.TRANSACTION.CODE.Equals("S") Then
    '            If obrGuiaRemision.fintActualizarEnvioGuias(obeGuiaRemision) = True Then
    '                ReportEnvio.GenerarReportEnvioDespachoWsBroker(objRequest, Me.Name.ToString, objSeguridadBN.pUsuario)
    '            Else
    '                MessageBox.Show("Error realizar la operaci�n.")
    '            End If
    '        Else
    '            MessageBox.Show(objResponse.Data.WSDATARES.TRANSACTION.MESSAGE.ToString.Trim, "WsBroker", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End If

    '    Else
    '        MessageBox.Show("Error de WsBroker.")
    '    End If
    'End Sub

    'Private Sub txtclasificacioncarga_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'End Sub

    'Private Sub txtprogramador_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'End Sub

    Private Sub txtCliente_InformationChanged() Handles txtCliente.InformationChanged
        Try
            Me.txtprogramador.DataSource = Nothing
            Me.txtprogramador.DropDownStyle = ComboBoxStyle.Simple
            If (txtCliente.pCodigo = "11731" Or txtCliente.pCodigo = "30507") Then
                Dim dtbDatosAyuda As New DataTable
                Dim objAyuda As New RANSA.Controls.TipoAyuda.TipoAyuda_DAL
                dtbDatosAyuda = objAyuda.fdtListar_TablaAyuda_Filtro("SAPRGC", txtCliente.pCodigo)
                With txtprogramador
                    .DataSource = dtbDatosAyuda
                    .DisplayMember = "TDSDES"
                    .ValueMember = "TDSDES"
                End With

                Me.txtprogramador.DropDownStyle = ComboBoxStyle.DropDownList
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    'Private Sub cboTipoSerie_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboTipoSerie.SelectionChangeCommitted
    '    Try
    '        Dim seriegr As String = ("" & cboTipoSerie.SelectedValue)
    '        If seriegr <> "" Then
    '            chkAutoGenerar.Enabled = False
    '            txtNroGuiaRemision.Enabled = False
    '            txtNroGuiaRemision.Text = ""
    '        Else
    '            chkAutoGenerar.Enabled = True
    '            txtNroGuiaRemision.Enabled = True
    '        End If



    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
    '    End Try
    'End Sub

    'Private Sub txtNroGuiaRemision_TextChanged(sender As Object, e As EventArgs) Handles txtNroGuiaRemision.TextChanged
    '    txtNroGuiaRemision.Text = txtNroGuiaRemision.Text.ToUpper
    'End Sub

    Private Sub txtNroGuiaRemision_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtNroGuiaRemision.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub

    Private Sub cboTipoGR_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboTipoGR.SelectionChangeCommitted
        Try
            txtNroGuiaRemision.Text = ""
            chkAutoGenerar.Checked = False


            Dim dt_listserie_gr As New DataTable
            dt_listserie_gr = dt_Listado_serie.Copy
            txtNroGuiaRemision.Enabled = True

            Dim tipo As String = ("" & cboTipoGR.SelectedValue).ToString.Trim
            Select Case tipo
                Case "F"
                    txtNroGuiaRemision.Mask = "000-0000000"

                    chkAutoGenerar.Enabled = True
                    cboTipoSerie.DataSource = Nothing
                Case "E"

                    txtNroGuiaRemision.Mask = "LAAA-99999999"
                    chkAutoGenerar.Enabled = False
                    cboTipoSerie.DataSource = dt_listserie_gr
                    cboTipoSerie.DisplayMember = "TSERIE"
                    cboTipoSerie.ValueMember = "CSERIE"
                    Dim seriegr As String = ("" & cboTipoSerie.SelectedValue)
                    If seriegr <> "" Then
                        txtNroGuiaRemision.Enabled = False
                    End If
            End Select
            txtNroGuiaRemision.Select(0, 0)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try


    End Sub

    Private Sub UcPlantaDeEntregaOrigen_TextChanged() Handles UcPlantaDeEntregaOrigen.TextChanged
        Try
            txt_ubigeo_origen_recojo.Tag = UcPlantaDeEntregaOrigen.ItemActual.PNCUBGEO
            txt_ubigeo_origen_recojo.Text = UcPlantaDeEntregaOrigen.ItemActual.PSUBIGEO
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
  
    End Sub
    Private Sub UcPlantaDeEntregaOrigen_Ransa_TextChanged() Handles UcPlantaDeEntregaOrigen_Ransa.TextChanged
        Try
            txt_ubigeo_origen_ransa.Tag = UcPlantaDeEntregaOrigen_Ransa.ItemActual.PNCUBGEO
            txt_ubigeo_origen_ransa.Text = UcPlantaDeEntregaOrigen_Ransa.ItemActual.PSUBIGEO
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub UcPlantaDeEntregaDestino_TextChanged() Handles UcPlantaDeEntregaDestino.TextChanged
        Try
            txt_ubigeo_destino_cliente.Tag = UcPlantaDeEntregaDestino.ItemActual.PNCUBGEO
            txt_ubigeo_destino_cliente.Text = UcPlantaDeEntregaDestino.ItemActual.PSUBIGEO
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    
    End Sub
    Private Sub UcPlantaDeEntregaPropioDestino_TextChanged() Handles UcPlantaDeEntregaPropioDestino.TextChanged
        Try
            txt_ubigeo_destino_planta.Tag = UcPlantaDeEntregaPropioDestino.ItemActual.PNCUBGEO
            txt_ubigeo_destino_planta.Text = UcPlantaDeEntregaPropioDestino.ItemActual.PSUBIGEO
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub


    'Private Sub txt_ubigeo_tramos_KeyDown(sender As Object, e As KeyEventArgs) Handles KryptonTextBox1.KeyDown

    'End Sub

    Private Sub btnUbigeo_transporte_tramo_Click(sender As Object, e As EventArgs) Handles btnUbigeo_transporte_tramo.Click
        Try
            'Dim obrGuiaRemision As New brGuiasRemision
            'Dim oDs As New DataSet
            'oDs = obrGuiaRemision.Listar_Ubigeo
            Dim ofrmListaUbigeo As New frmListaUbigeo
            If ofrmListaUbigeo.ShowDialog = Windows.Forms.DialogResult.OK Then
                txt_ubigeo_tramos.Tag = ofrmListaUbigeo.cod_ubigeo
                txt_ubigeo_tramos.Text = ofrmListaUbigeo.desc_ubigeo
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub rbfisico_CheckedChanged(sender As Object, e As EventArgs)
    '    Try
    '        txtNroGuiaRemision.Text = ""
    '        chkAutoGenerar.Checked = False
    '        'txtNroGuiaRemision.Mask = "AAAA-########"

    '        Dim TipoGuia As String = ""
    '        If rbfisico.Checked = True Then
    '            TipoGuia = "F"
    '        End If
    '        If rbelectronico.Checked = True Then
    '            TipoGuia = "E"
    '        End If


    '        Dim dt_listserie_gr As New DataTable
    '        dt_listserie_gr = dt_Listado_serie.Copy
    '        txtNroGuiaRemision.Enabled = True

    '        'Dim tipo As String = ("" & cboTipoGR.SelectedValue).ToString.Trim
    '        Select Case TipoGuia
    '            Case "F"
    '                txtNroGuiaRemision.Mask = "000-0000000"
    '                chkAutoGenerar.Enabled = True
    '                cboTipoSerie.DataSource = Nothing
    '            Case "E"
    '                txtNroGuiaRemision.Mask = "LAAA-00000000" ' Primera caracter : Letra / 3 caracteres alfanumerico/ 8 numericos
    '                chkAutoGenerar.Enabled = False
    '                cboTipoSerie.DataSource = dt_listserie_gr
    '                cboTipoSerie.DisplayMember = "TSERIE"
    '                cboTipoSerie.ValueMember = "CSERIE"
    '                Dim seriegr As String = ("" & cboTipoSerie.SelectedValue)
    '                If seriegr <> "" Then
    '                    txtNroGuiaRemision.Enabled = False
    '                End If
    '        End Select

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
    '    End Try

    'End Sub

    Private Sub cboTipoSerie_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboTipoSerie.SelectionChangeCommitted
        Try

            txtNroGuiaRemision.Text = ""
            chkAutoGenerar.Checked = False
            'Dim dt_listserie_gr As New DataTable
            'dt_listserie_gr = dt_Listado_serie.Copy
            txtNroGuiaRemision.Enabled = True
            Dim tipo As String = ("" & cboTipoGR.SelectedValue).ToString.Trim
            Select Case tipo
                Case "F"
                    txtNroGuiaRemision.Mask = "000-0000000"
                    chkAutoGenerar.Enabled = True
                    'cboTipoSerie.DataSource = Nothing
                Case "E"

                    txtNroGuiaRemision.Mask = "LAAA-99999999"
                    chkAutoGenerar.Enabled = False
                    'cboTipoSerie.DataSource = dt_listserie_gr
                    'cboTipoSerie.DisplayMember = "TSERIE"
                    'cboTipoSerie.ValueMember = "CSERIE"
                    Dim seriegr As String = ("" & cboTipoSerie.SelectedValue)
                    If seriegr <> "" Then
                        txtNroGuiaRemision.Enabled = False
                    End If
            End Select
            txtNroGuiaRemision.Select(0, 0)




        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
