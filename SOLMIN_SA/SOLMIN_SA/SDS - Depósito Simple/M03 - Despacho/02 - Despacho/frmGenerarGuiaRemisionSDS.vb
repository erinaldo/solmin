Imports Ransa.TYPEDEF
Imports RANSA.Utilitario
Imports Ransa.NEGO
Imports RANSA.NEGO.DespachoSAT
Imports Ransa.NEGO.slnSOLMIN_SAT.Despacho.Reportes
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmGenerarGuiaRemisionSDS

#Region " Atributos "
    'Private intCCLNT As Int64 = 0
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
    ''' Código de Bulto
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
    ''' Código del cliente
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
    ''' Cuando se crea guía de remisión desde predespacho
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
    ''' Código de Predespacho
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

    Public WriteOnly Property pintCodPlanta_CPLCLP() As String
        Set(ByVal value As String)
            _intCodPlanta_CPLCLP = value
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

    'Public WriteOnly Property pCodigoCliente_CCLNT() As Int64
    '    Set(ByVal value As Int64)
    '        intCCLNT = value
    '    End Set
    'End Property

    Private intCantidaLineas As Integer = 0
    Public WriteOnly Property pintCantidaLineas() As Integer
        Set(ByVal value As Integer)
            intCantidaLineas = value
        End Set
    End Property

#End Region

#Region " Funciones y Procedimientos "

    Private Sub PrecargarControles()
        ' Habilitar Opciones según el Sistema que se haya cargado
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
                txtMotivoTraslado.Valor = strSMTRCP
                txtMotivoTraslado.Refresh()
                txtObservaciones.Text = strNMNFTF
                txtObservaciones.MaxLength = 30
            Case "03"
                dtpFechaEmision.Enabled = True
                dtpFechaTraslado.Enabled = True
                txtTipoDoc.Enabled = True
                txtNroFactura.Enabled = True
                dtpFechaFactura.Enabled = True
                txtPlacaAcoplado.Enabled = False
                lblNroGuiaInterna.Text = "Nro. Guía Ransa : "
                txtNroGuiaInterna.Text = strNRGUIA
                txtObservaciones.MaxLength = 120
        End Select
        'Cargar Medio Sugerido
        Me.txtMedioSugerido.Refrescar(4)
        rbtPlantaCliente.Checked = True

        'Empresa de Transporte
        txtEmpresaTransporte.Tag = strCTRSPT
        mfblnObtenerDetalle_EmpresaTransporte(txtEmpresaTransporte.Tag, txtEmpresaTransporte.Text, "")
        If strCTRSPT <> "" Then
            Call mfblnBuscar_EmpresaTransporte(txtEmpresaTransporte.Tag, txtEmpresaTransporte.Text, _strNroRUCTransportisdta, _strDireccionTransportista)
        End If

        If _intCodigoClienteTercero_CPRVCL <> 0 Then
            If _intCodigoClienteTercero_CPRVCL <> _PNCCLNT Then
                Me.rbtClienteTercero.Checked = True
                'UcClienteTerceroDestino.CodCliente = _intCodigoClienteTercero_CPRVCL


                Dim oClienteTerceroDestino As New Ransa.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega
                oClienteTerceroDestino.PNCCLNT = _PNCCLNT
                oClienteTerceroDestino.PNCPRVCL = _intCodigoClienteTercero_CPRVCL
                oClienteTerceroDestino.PSSTPORL = "C"
                UcClienteTerceroDestino.pCargar2(oClienteTerceroDestino)
                UcClienteTerceroDestino.Refresh()

            End If
        End If

        If _intCodPlanta_CPLCLP <> 0 Then
            Dim oPlantaDeEntregaDestino As New Ransa.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega
            oPlantaDeEntregaDestino.PNCCLNT = _PNCCLNT
            oPlantaDeEntregaDestino.PNCPRVCL = _intCodigoClienteTercero_CPRVCL
            oPlantaDeEntregaDestino.PNCPLNCL = _intCodPlanta_CPLCLP
            UcPlantaDeEntregaDestino.pCargar(oPlantaDeEntregaDestino)
            UcPlantaDeEntregaDestino.Refresh()
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
        UcClienteTerceroOrigen.Visible = False
        lblClienteOrigen.Visible = False
        'vualisamos el cliente tercero en la posicion siguiente
        lblPlantaOrigen.Location = New Point(6, 19)
        UcPlantaDeEntregaOrigen.Location = New Point(107, 17)
        'Siempre es Ransa
        UcPlantaDeEntregaOrigen.TipoPlantaDeEntrega = True
        UcPlantaDeEntregaOrigen.CodCliente = 485
        'Lista todas las planta de entrega Propios
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
    End Sub

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
        Dim codMedioEnvio As String = "0"
        Dim bolEsOutotec As Boolean = False
        ' Reiniciamos la variable del estado de la validación
        blnResultadoValidar = True
        ' Realizamos la validación de los campos
        If txtCliente.pCodigo = 0 Then _
                   strMensajeError &= "- Seleccione Cliente" & vbNewLine
        If txtMotivoTraslado.Resultado Is Nothing Then _
            strMensajeError &= "- No ha ingresado Motivo de Despacho" & vbNewLine
        If Not txtMotivoTraslado.Resultado Is Nothing AndAlso CType(txtMotivoTraslado.Resultado, beGeneral).PSSTPING.Trim = "A" AndAlso txtObsOtrosMotivos.Text.Trim = "" Then _
            strMensajeError &= "- Debe ingresar observación cuando el Motivos es " & CType(txtMotivoTraslado.Resultado, beGeneral).PSTDSDES & vbNewLine
        If txtNroGuiaRemision.Text = "" Then _
            strMensajeError &= "- De ingresar el Nro. de la Guía de Remisión" & vbNewLine
        If txtNroGuiaRemision.Text <> "" And txtNroGuiaRemision.Text.Length <> 10 Then _
            strMensajeError &= "- El Nro. de la Guía de Remisión es de 10 dígitos" & vbNewLine
        If txtNroFactura.Text <> "" Then
            If txtTipoDoc.Resultado Is Nothing Then
                strMensajeError &= "-Debe ingresar el Tipo de Documento" & vbNewLine
            End If
        End If
        If _PNCCLNT <> 11232 Then
            If txtNroFactura.Text <> "" Then
                If txtNroFactura.Enabled And txtNroFactura.Text.Length <> 10 Then
                    strMensajeError &= "- El Nro. de la Guía de Factura es de 10 dígitos" & vbNewLine
                End If
            End If
        End If
        If UcPlantaDeEntregaOrigen.ItemActual.PNCPLNCL = 0 Then _
            strMensajeError &= "- Debe ingresar la Planta Origen" & vbNewLine
        If rbtPlantaCliente.Checked Then
            If UcPlantaDeEntregaPropioDestino.ItemActual.PNCPLNCL = 0 Then _
                        strMensajeError &= "- Debe ingresar la Planta Destino" & vbNewLine
        Else
            If UcClienteTerceroDestino.ItemActual.PNCPRVCL = 0 Then _
                        strMensajeError &= "- Debe ingresar el Proveedor" & vbNewLine
            If UcPlantaDeEntregaDestino.ItemActual.PNCPLNCL = 0 Then _
                        strMensajeError &= "- Debe seleccionar una Planta Destino del Cliente" & vbNewLine
        End If
        If txtMedioSugerido.objResult Is Nothing Then
            strMensajeError &= "- Debe seleccionar el Medio de envio" & vbNewLine
        Else
            codMedioEnvio = CType(txtMedioSugerido.objResult, Ransa.TypeDef.beGeneral).PNCMEDTR
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

        If chkDosTramos.Checked Then
            If txtEmpresaTransporte2doTramo.Text = "" Then _
                strMensajeError &= "- Debe seleccionar la Empresa de Transporte para el 2do. Tramo" & vbNewLine
        End If


        If txtSigla.Text.Trim.Length <> 0 And txtNumeroContenedor.Text.Trim.Length = 0 Then
            strMensajeError &= "- Ingrese Número de Contenedor" & vbNewLine
        ElseIf txtSigla.Text.Trim.Length = 0 And txtNumeroContenedor.Text.Trim.Length <> 0 Then
            strMensajeError &= "- Ingrese Sigla Contenedor" & vbNewLine
        End If

        Dim obrGeneral As New Ransa.NEGO.brGeneral
        'Validamos que el clientes sea Outotec
        bolEsOutotec = obrGeneral.bolElClienteEsOutotec(_PNCCLNT)
        If bolEsOutotec Then
            'Validamos que el tipo de movimiento selecciona tenga su equivalencia en outotec
            Dim olbeGeneral As New List(Of beGeneral)
            If Not txtMotivoTraslado.Resultado Is Nothing Then
                olbeGeneral = obrGeneral.olEquivalenteOutotecMotivoDespacho(CType(txtMotivoTraslado.Resultado, beGeneral).PSSTPING)
                If olbeGeneral.Count = 0 Then
                    strMensajeError &= "- El tipo de despacho no cuenta con equivalencia en la interfaz"
                Else
                    strTipoMovIntfz = olbeGeneral.Item(0).PSTDSDES.Trim
                End If

            End If
        End If

        'Contamos la cantidad de lineas que se imprimiran en la observacion 
        For intRow As Integer = 0 To Me.dtgObservacion.Rows.Count - 2
            intCantidaLineas = intCantidaLineas + 1
        Next
        If bolEsOutotec Then
            If intCantidaLineas > 20 Then
                strMensajeError &= "- La Guía de remisión excede la cantidad de líneas por guía" & vbNewLine
            End If
        End If
      
        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            blnResultadoValidar = False
        End If
        Return blnResultadoValidar
    End Function   

    Private Sub VistraPreviaGuiaRemisionAT(ByVal oDs As DataSet, ByVal strModeloGuia As String)
        Dim rdocGuiaRemision As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
        ' Cargamos los valores de los parametros de impresión de la Guia
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
            Case Else
                rdocGuiaRemision = New rptGuiaRemisionM01
        End Select
        rdocGuiaRemision.SetDataSource(oDs)
        rdocGuiaRemision.Refresh()
        'Imprime la Guía de Remisión
        With frmVisorRPT
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill
            .pReportDocument = rdocGuiaRemision
            .ShowDialog()
        End With
    End Sub

    Private Sub VistraPreviaGuiaRemisionDS(ByVal obeGuiaRemision As beGuiaRemision, ByVal oDs As DataSet, ByVal strModeloGuia As String)
        Dim rdocGuiaRemision As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
        ' Cargamos los valores de los parametros de impresión de la Guia
        Select Case strModeloGuia
            Case "M1"
                rdocGuiaRemision = New rptGuiaRemisionSDS_M01
            Case "M2"
                rdocGuiaRemision = New rptGuiaRemisionSDS_M02
            Case "M3"
                rdocGuiaRemision = New rptGuiaRemisionSDS_M03
            Case "M4"
                rdocGuiaRemision = New rptGuiaRemisionSDS_M04
            Case "M5"
                rdocGuiaRemision = New rptGuiaRemisionSDS_M05
            Case "M6"
                rdocGuiaRemision = New rptGuiaRemisionSDS_M06
            Case Else
                rdocGuiaRemision = New rptGuiaRemisionSDS_M01
        End Select
        rdocGuiaRemision.SetDataSource(oDs)
        rdocGuiaRemision.Refresh()
        'Imprime la Guía de Remisión
        With frmVisorRPT
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill
            .pReportDocument = rdocGuiaRemision
            .ShowDialog()
            'Verificar si es ABB
            If obeGuiaRemision.PNCCLNT = 11232 Then
                InsertarCabeceraDespacho(obeGuiaRemision)
            End If
            Dim obrGeneral As New Ransa.NEGO.brGeneral
            If obrGeneral.bolElClienteEsOutotec(obeGuiaRemision.PNCCLNT) Then
                EnviarGuiaRemisionOutotec(obeGuiaRemision)
            End If
        End With
    End Sub

    Private Sub InsertarCabeceraDespacho(ByVal obeGuiaRemision As beGuiaRemision)
        Dim obrDespacho As New Ransa.NEGO.brDespacho
        Dim obeDespacho As New Ransa.TypeDef.beDespacho
        Dim olbeDespacho As New List(Of Ransa.TypeDef.beDespacho)
        obeDespacho.PNCCLNT = obeGuiaRemision.PNCCLNT
        obeDespacho.PNNGUIRN = obeGuiaRemision.PNNGUIRN
        olbeDespacho = obrDespacho.ListaParaExportarABB(obeDespacho)
        If olbeDespacho.Count > 0 Then
            Dim blRecepcion As New Ransa.NEGO.brIntegracion
            Dim objParametros As Db2Manager.RansaData.iSeries.DataObjects.Parameter
            objParametros = New Db2Manager.RansaData.iSeries.DataObjects.Parameter
            With objParametros
                'Cabecera Despacho
                .Add("vc_RansaOutGuide", obeGuiaRemision.PNNGUIRN)
                .Add("dt_ReferralGuideDate", obeGuiaRemision.FechaEmision_FGUIRM)
                .Add("vc_TransferReason", obeGuiaRemision.TransferReason)
                .Add("vc_HomeName", olbeDespacho.Item(0).PSTCMPCL)
                .Add("vc_HomeAddress", olbeDespacho.Item(0).PSTDRCOR)
                .Add("vc_CustomerCodeDeliver", olbeDespacho.Item(0).PSTIPCLI)
                .Add("vc_CustomerFiscalCodeDeliver", olbeDespacho.Item(0).PSNRUCPR)
                .Add("vc_CustomerAddressDeliverLine1", olbeDespacho.Item(0).PSTDRPCP)
                .Add("vc_CustomerAddressDeliverLine2", olbeDespacho.Item(0).PSTDRDST)
                .Add("vc_CustomerAddressLine3", "")
                .Add("vc_CustomerFiscalName", olbeDespacho.Item(0).PSTPRVCL)
                .Add("vc_VehiclePlate", obeGuiaRemision.PSNPLCCM)
                .Add("vc_TransportCarrierName", obeGuiaRemision.PSTCMPTR)
                .Add("vc_TransportCarrierFiscalCode", " " & obeGuiaRemision.TransportCarrierFiscalCode & "")
                .Add("vc_TransportCarrierAddress", " " & obeGuiaRemision.TransportCarrierAddress & " ")
                .Add("vc_Driver", " " & obeGuiaRemision.Driver & " ")
                .Add("vc_DriversLicense", obeGuiaRemision.PSNBRVCH)
                .Add("vc_ReferralGuideComments", obeGuiaRemision.PSTOBORM)
                .Add("vc_Usuario", objSeguridadBN.pUsuario)
                .Add("vc_OrderNumber", olbeDespacho.Item(0).PSNRFRPD)
                .Add("vc_OrderType", olbeDespacho.Item(0).PSNRFTPD)

            End With
            Dim intEstado_C As Int32 = blRecepcion.Integracion_Insertar_Despacho_Cabecera(obeGuiaRemision.PNCCLNT, objParametros)
            If intEstado_C = -1 Then Exit Sub

            For Each obeDespacho In olbeDespacho
                objParametros = New Db2Manager.RansaData.iSeries.DataObjects.Parameter
                With objParametros
                    'Detalle Despacho
                    .Add("in_ReferralGuideNumber", intEstado_C)
                    .Add("vc_OrderNumber", obeDespacho.PSNRFRPD)
                    .Add("vc_OrderType", obeDespacho.PSNRFTPD)
                    .Add("in_OrderLine", obeDespacho.PSNLTECL)
                    .Add("vc_StockCode", obeDespacho.PSCMRCLR)
                    If obeDespacho.PSDEMERCA.Trim.Length > 50 Then
                        .Add("vc_LineDescriptionLine1", obeDespacho.PSDEMERCA.Trim.Substring(0, 50))
                        .Add("vc_LineDescriptionLine2", obeDespacho.PSDEMERCA)
                    Else
                        .Add("vc_LineDescriptionLine1", obeDespacho.PSDEMERCA.Trim)
                        .Add("vc_LineDescriptionLine2", "")
                    End If
                    .Add("vc_UnitMeasure", obeDespacho.PSCUNCN6) 'UNIDA DE MEDIDA
                    .Add("fl_Quantity", obeDespacho.PNQTRMC)
                    .Add("vc_Usuario", objSeguridadBN.pUsuario)
                    .Add("vc_ReferenceGuide", obeDespacho.PSGUIA)

                End With
                Dim intEstado_D As Int32 = blRecepcion.Integracion_Insertar_Despacho_Detalle(obeGuiaRemision.PNCCLNT, objParametros)
                If intEstado_D <> -1 Then
                    Dim olBeSerie As New List(Of Ransa.TypeDef.beDespacho)
                    olBeSerie = obrDespacho.ListaSerieExportarABB(obeDespacho)
                    Dim oloData As New List(Of Hashtable)

                    Dim objData = New System.Collections.Hashtable
                    Dim intCorrelativo As Integer = 0
                    For Each obeSeri As Ransa.TypeDef.beDespacho In olBeSerie
                        intCorrelativo = intCorrelativo + 1
                        objData = New System.Collections.Hashtable
                        With objData
                            '==========Cabecera Despacho
                            .Add("n_IdSerie", intCorrelativo.ToString)
                            .Add("in_ReferralGuideLine", intEstado_D.ToString)
                            .Add("in_ReferralGuideNumber", intEstado_C.ToString)
                            .Add("vc_StockCode", obeSeri.PSCMRCLR)
                            .Add("vc_NumeroSerie", obeSeri.PSCSRECL)
                        End With
                        oloData.Add(objData)
                    Next
                    intEstado_D = blRecepcion.Integracion_Insertar_Serie_Despacho(obeGuiaRemision.PNCCLNT, oloData)
                    'If intEstado_D = -1 Then
                    '    HelpClass.ErrorMsgBox()
                    'End If
                End If
            Next

        End If
    End Sub

    Private Sub EnviarGuiaRemisionOutotec(ByVal obeGuia As beGuiaRemision)
        Dim obrDespacho As New RANSA.NEGO.brDespacho
        Dim obeDespacho As New RANSA.TYPEDEF.beDespacho
        Dim olbeDespacho As New List(Of RANSA.TYPEDEF.beDespacho)
        obeDespacho.PNCCLNT = obeGuia.PNCCLNT
        obeDespacho.PNNGUIRM = obeGuia.PSNGUIRM

        If obeGuia.PSSSTVAL.ToString.Trim.Equals("M") Then
            olbeDespacho = obrDespacho.flistListaExportarGuiaManualOutotec(obeDespacho)
        Else
            olbeDespacho = obrDespacho.flistListaExportarGuiaOutotec(obeDespacho)
        End If

        If olbeDespacho.Count > 0 Then

            ''Proyecto Outotec
            Dim obrInterfaz As New RANSA.NEGO.brInterfazOutoTec
            '================registro de cabecera========================
            Dim obeCabGuiaInfzOutotec As New RANSA.TypeDef.beCabGuiaInfzOutotec
            With obeCabGuiaInfzOutotec
                .nguias = olbeDespacho.Item(0).PNNGUIRM
                .codcli = obeDespacho.PNCCLNT
                .ctpdoc = "PS"
                .nserof = olbeDespacho.Item(0).PSSERIE
                .ndocof = olbeDespacho.Item(0).PSNROFIC
                .npensa = olbeDespacho.Item(0).PNNGUIRN
                .ctpgui = olbeDespacho.Item(0).PSCTPGUI

                If Not olbeDespacho.Item(0).FechaEmisionGuia Is Nothing Then
                    .femisi = olbeDespacho.Item(0).FechaEmisionGuia
                Else
                    .femisi = Nothing
                End If
                If Not olbeDespacho.Item(0).FechaInicioTraslado Is Nothing Then
                    .finitr = olbeDespacho.Item(0).FechaInicioTraslado
                Else
                    .finitr = Nothing
                End If
                .dtpgui = olbeDespacho.Item(0).PSTDSDES

                .ctpope = olbeDespacho.Item(0).PSNRFTPD
                .nordpr = olbeDespacho.Item(0).PSNRFRPD

                .nordcl = olbeDespacho.Item(0).PSTOBSMD.Trim
                .ddiori = olbeDespacho.Item(0).PSORIGEN
                .ctpode = olbeDespacho.Item(0).PSCLADES
                .coride = olbeDespacho.Item(0).PSTIPCLI
                .ddirec01 = olbeDespacho.Item(0).PSDESTINO
                .nconst = olbeDespacho.Item(0).PSNRGMT1
                .nplaca01 = olbeDespacho.Item(0).PSNPLCCM
                .dobser = olbeDespacho.Item(0).PSTOBSRM
                Select Case olbeDespacho.Item(0).PNTDCFCC
                    Case 1
                        .ctpfac = "FA" 'POR MIENTRAS
                    Case 7
                        .ctpfac = "BO" 'POR MIENTRAS
                End Select
                If Not olbeDespacho.Item(0).FechaContrato Is Nothing AndAlso olbeDespacho.Item(0).FechaContrato <> "" Then
                    .fecdoc = olbeDespacho.Item(0).FechaContrato
                    .nfactu01 = olbeDespacho.Item(0).PNNDCFCC
                Else
                    .fecdoc = Nothing
                    .nfactu01 = ""
                End If
                .senlac = "N"
                .sguias = "E"
                .sgepes = "S"
                .clcori = "11" 'temporal
                .cciatr = "22" 'temporal
                .cchofe = "000041" 'tempolar
                .drztra = olbeDespacho.Item(0).PSTCMPTR.Trim
                .cructr = olbeDespacho.Item(0).PNNRUCT
                .dchofe = olbeDespacho.Item(0).PSTNMBCH.Trim
                .nbreve = olbeDespacho.Item(0).PSNBRVCH.Trim
                .qtotpe = olbeDespacho.Item(0).PNQPSGU
                If objSeguridadBN.pUsuario.Length > 6 Then
                    .cusuar = objSeguridadBN.pUsuario.Trim.Substring(1, 6)
                Else
                    .cusuar = objSeguridadBN.pUsuario
                End If
            End With
            If obrInterfaz.fintInsertarCabeceraGuia(obeCabGuiaInfzOutotec) <> -1 Then
                '  ================registro de detalle=========================
                Dim olbeDetGuiaInfzOutotec As New List(Of Ransa.TYPEDEF.beDetGuiaInfzOutotec)
                Dim intNRow As Integer = 1
                Dim olBeSerie As List(Of RANSA.TypeDef.beDespacho)
                Dim obeDetInterfazOutotec As RANSA.TypeDef.beDetGuiaInfzOutotec

                For Each obeDesp As RANSA.TypeDef.beDespacho In olbeDespacho
                    olBeSerie = New List(Of RANSA.TypeDef.beDespacho)
                    olBeSerie = obrDespacho.ListaSerieExportarABB(obeDesp)

                    If olBeSerie.Count > 0 Then
                        If olBeSerie.Count = obeDesp.PNQTRMC Then
                            For Each obeSerie As RANSA.TypeDef.beDespacho In olBeSerie
                                obeDetInterfazOutotec = New RANSA.TypeDef.beDetGuiaInfzOutotec
                                With obeDetInterfazOutotec
                                    .nguias = obeDesp.PNNGUIRM
                                    .codcli = obeDespacho.PNCCLNT
                                    .norden = intNRow
                                    .citems = obeDesp.PSCMRCLR.Trim
                                    .ditems = obeDesp.PSDEMERCA.Trim
                                    .cunmed = obeDesp.PSCUNCN6.Trim
                                    .qitems = 1
                                    .qunida = IIf(obeDesp.PSNRFTPD.Trim.Equals("P"), 0, Val(obeDesp.PSNLTECL.Trim))
                                    .qsaldo = 0
                                    .nserie = obeSerie.PSCSRECL.Trim
                                End With
                                olbeDetGuiaInfzOutotec.Add(obeDetInterfazOutotec)
                                intNRow = intNRow + 1
                            Next
                        Else
                            obeDetInterfazOutotec = New RANSA.TypeDef.beDetGuiaInfzOutotec
                            With obeDetInterfazOutotec
                                .nguias = obeDesp.PNNGUIRM
                                .codcli = obeDespacho.PNCCLNT
                                .norden = intNRow
                                .citems = obeDesp.PSCMRCLR.Trim
                                .ditems = obeDesp.PSDEMERCA.Trim
                                .cunmed = obeDesp.PSCUNCN6.Trim
                                .qitems = obeDesp.PNQTRMC - olBeSerie.Count
                                .qunida = IIf(obeDesp.PSNRFTPD.Trim.Equals("P"), 0, Val(obeDesp.PSNLTECL.Trim))
                                .qsaldo = 0
                            End With
                            olbeDetGuiaInfzOutotec.Add(obeDetInterfazOutotec)
                            intNRow = intNRow + 1

                            For Each obeSerie As RANSA.TypeDef.beDespacho In olBeSerie
                                obeDetInterfazOutotec = New RANSA.TypeDef.beDetGuiaInfzOutotec
                                With obeDetInterfazOutotec
                                    .nguias = obeDesp.PNNGUIRM
                                    .codcli = obeDespacho.PNCCLNT
                                    .norden = intNRow
                                    .citems = obeDesp.PSCMRCLR.Trim
                                    .ditems = obeDesp.PSDEMERCA.Trim
                                    .cunmed = obeDesp.PSCUNCN6.Trim
                                    .qitems = 1
                                    .qunida = IIf(obeDesp.PSNRFTPD.Trim.Equals("P"), 0, Val(obeDesp.PSNLTECL.Trim))
                                    .qsaldo = 0
                                    .nserie = obeSerie.PSCSRECL.Trim
                                End With
                                olbeDetGuiaInfzOutotec.Add(obeDetInterfazOutotec)
                                intNRow = intNRow + 1
                            Next
                        End If
                    Else
                        obeDetInterfazOutotec = New RANSA.TypeDef.beDetGuiaInfzOutotec
                        With obeDetInterfazOutotec
                            .nguias = obeDesp.PNNGUIRM
                            .codcli = obeDespacho.PNCCLNT
                            .norden = intNRow
                            .citems = obeDesp.PSCMRCLR
                            .ditems = obeDesp.PSDEMERCA
                            .cunmed = obeDesp.PSCUNCN6
                            .qitems = obeDesp.PNQTRMC
                            .qunida = IIf(obeDesp.PSNRFTPD.Trim.Equals("P"), 0, Val(obeDesp.PSNLTECL.Trim))
                            .qsaldo = 0
                            .nserie = obeDesp.PSCSRECL 'Solo para el Manual, si es automatico nunca va tener serie en este caso
                        End With
                        olbeDetGuiaInfzOutotec.Add(obeDetInterfazOutotec)
                        intNRow = intNRow + 1
                    End If
                Next


                Dim oucOrdena As UCOrdena(Of Ransa.TYPEDEF.beDetGuiaInfzOutotec)

                oucOrdena = New UCOrdena(Of Ransa.TYPEDEF.beDetGuiaInfzOutotec)("qunida", UCOrdena(Of Ransa.TYPEDEF.beDetGuiaInfzOutotec).TipoOrdenacion.Ascendente)
                olbeDetGuiaInfzOutotec.Sort(oucOrdena)

                For intRow As Integer = 0 To olbeDetGuiaInfzOutotec.Count - 1
                    olbeDetGuiaInfzOutotec.Item(intRow).norden = intRow
                Next

                If obrInterfaz.fintInsertarDetalleGuia(olbeDetGuiaInfzOutotec) = -1 Then
                    MessageBox.Show("Error en el envio a Outotec", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            Else
                MessageBox.Show("Error en el envio a Outotec", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim obrGuia As New DespachoSAT.brGuiasRemision
            With obeGuia
                .PSUSUARIO = objSeguridadBN.pUsuario
            End With
            If Not obrGuia.fintActualizarEnvioGuias(obeGuia) Then
                HelpClass.ErrorMsgBox()
            End If

        End If
    End Sub



    Private Sub fAutoGenerarGuiaRemision(ByVal bolChek As Boolean)
        Dim obrGuia As New DespachoSAT.brGuiasRemision
        If bolChek = True Then
            _PNCCLNT = Me.txtCliente.pCodigo
            Me.txtNroGuiaRemision.Text = obrGuia.fstrUltimoGuiaRemision(_PNCCLNT)
            txtNroGuiaRemision.Enabled = False
        Else
            Me.txtNroGuiaRemision.Text = 0
            txtNroGuiaRemision.Enabled = True
        End If
    End Sub

    Private Sub pGenerarReporte()
        If MessageBox.Show("Desea generar la guía de remisión??", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
 

        Select Case objSeguridadBN.pstrTipoSistema
            Case "03"
                Dim obeGuiaRemision As beGuiaRemision = New beGuiaRemision
                With obeGuiaRemision
                    Decimal.TryParse(_PNCCLNT, .PNCCLNT)
                    .PNNGUIRN = strNRGUIA
                    .FechaEmision_FGUIRM = dtpFechaEmision.Value
                    .FechaTraslado_FINTRA = dtpFechaTraslado.Value
                    .PSSMTGRM = CType(txtMotivoTraslado.Resultado, beGeneral).PSSTPING
                    .PSTOBORM = txtObsOtrosMotivos.Text
                    .PSNGUIRM = txtNroGuiaRemision.Text
                    .PNCPLNOR = UcPlantaDeEntregaOrigen.ItemActual.PNCPLNCL
                    .PNCPLNCL = UcPlantaDeEntregaPropioDestino.ItemActual.PNCPLNCL
                    .PNCPRVCL = UcClienteTerceroDestino.ItemActual.PNCPRVCL
                    .PNCPLCLP = UcPlantaDeEntregaDestino.ItemActual.PNCPLNCL
                    Decimal.TryParse(txtEmpresaTransporte.Tag, .PNCTRSPT)
                    .PSNPLCCM = txtPlacaUnidad.Text
                    .PSNBRVCH = txtNroBrevete.Text
                    If txtObservaciones.Text.Trim.Length > 30 Then
                        .PSTOBSRM = txtObservaciones.Text.Trim.Substring(0, 30)
                        .PSTOBCLI = txtObservaciones.Text.Trim.Substring(30, txtObservaciones.Text.Trim.Length - 30)
                    Else
                        .PSTOBSRM = txtObservaciones.Text.Trim
                        .PSTOBCLI = ""
                    End If
                    If txtNroFactura.Text <> "" Then
                        .PNTDCFCC = CType(txtTipoDoc.Resultado, beGeneral).PNCTPODC
                        .PNNDCFCC = txtNroFactura.Text
                    End If
                    Date.TryParse(Me.dtpFechaFactura.Value, .FechaEmisionDocumento_FDCFCC)
                    If chkDosTramos.Checked Then _
                        .PNNDCMRF = txtEmpresaTransporte2doTramo.Tag
                    .PNCMEDTR = CType(txtMedioSugerido.objResult, Ransa.TypeDef.beGeneral).PNCMEDTR
                    .PSUSUARIO = objSeguridadBN.pUsuario
                    .strAplicacion = Application.StartupPath
                    .pstrTipoMovIntfz = strTipoMovIntfz
                End With

                'Observación
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

                mpGenerarGuiaRemisionDS(obeGuiaRemision, obeListaObservacion)

            Case "04"
                Dim obeGuiaRemision As beGuiaRemision = New beGuiaRemision
                With obeGuiaRemision
                    Decimal.TryParse(_PNCCLNT, .PNCCLNT)
                    .PNNGUIRN = strNRGUIA
                    .FechaEmision_FGUIRM = dtpFechaEmision.Value
                    .FechaTraslado_FINTRA = dtpFechaTraslado.Value
                    .PSSMTGRM = CType(txtMotivoTraslado.Resultado, beGeneral).PSSTPING
                    .PSTOBORM = txtObsOtrosMotivos.Text
                    .PSNGUIRM = txtNroGuiaRemision.Text
                    .PNCPLNOR = UcPlantaDeEntregaOrigen.ItemActual.PNCPLNCL
                    .PNCPLNCL = UcPlantaDeEntregaPropioDestino.ItemActual.PNCPLNCL
                    .PNCPRVCL = UcClienteTerceroDestino.ItemActual.PNCPRVCL
                    .PNCPLCLP = UcPlantaDeEntregaDestino.ItemActual.PNCPLNCL
                    Decimal.TryParse(txtEmpresaTransporte.Tag, .PNCTRSPT)

                    .PSNPLCCM = txtPlacaUnidad.Text
                    .PSNBRVCH = txtNroBrevete.Text
                    If txtObservaciones.Text.Trim.Length > 30 Then
                        .PSTOBSRM = txtObservaciones.Text.Trim.Substring(0, 30)
                        .PSTOBCLI = txtObservaciones.Text.Trim.Substring(30, txtObservaciones.Text.Trim.Length - 30)
                    Else
                        .PSTOBSRM = txtObservaciones.Text.Trim
                        .PSTOBCLI = ""
                    End If
                    If txtNroFactura.Text <> "" Then
                        .PNTDCFCC = CType(txtTipoDoc.Resultado, beGeneral).PNCTPODC
                        .PNNDCFCC = txtNroFactura.Text
                    End If
                    Date.TryParse(Me.dtpFechaFactura.Value, .FechaEmisionDocumento_FDCFCC)

                    .Driver = _strDriver
                    .TransferReason = CType(txtMotivoTraslado.Resultado, beGeneral).PSTDSDES
                    .TransportCarrierFiscalCode = _strNroRUCTransportisdta
                    .TransportCarrierAddress = _strDireccionTransportista
                    .pstrOrderType = strOrderType
                    .pstrOrderNumber = strOrderNumber
                    .PSTCMPTR = txtEmpresaTransporte.Text
                    .PNCDPEPL = _pintCodigoPedido_CDPEPL
                    '.TransportCarrierFiscalCode = _strNroRUCTransportisdta
                    If chkDosTramos.Checked Then _
                        .PNNDCMRF = txtEmpresaTransporte2doTramo.Tag
                    If Not txtMedioSugerido.objResult Is Nothing Then
                        .PNCMEDTR = CType(txtMedioSugerido.objResult, Ransa.TypeDef.beGeneral).PNCMEDTR
                    End If
                    .PSUSUARIO = objSeguridadBN.pUsuario
                    .strAplicacion = Application.StartupPath
                    .pstrTipoMovIntfz = strTipoMovIntfz
                End With



                Dim obeListaObservacion As New List(Of beGuiaRemision)
                Dim obeObervacion As beGuiaRemision
                For intRow As Integer = 0 To Me.dtgObservacion.Rows.Count - 2
                    obeObervacion = New beGuiaRemision
                    With obeObervacion
                        .PNCCLNGR = obeGuiaRemision.PNCCLNT
                        .PSNGUIRM = obeGuiaRemision.PSNGUIRM
                        .PSUSUARIO = objSeguridadBN.pUsuario
                        .PSNTRMNL = objSeguridadBN.pstrPCName
                        .PSTOBDGS = dtgObservacion.Rows(intRow).Cells("TOBSGS").Value
                    End With
                    obeListaObservacion.Add(obeObervacion)
                Next

                mpGenerarGuiaRemisionDS(obeGuiaRemision, obeListaObservacion)
        End Select
    End Sub

    Public Sub mpGenerarGuiaRemisionDS(ByVal obeGuiaRemision As beGuiaRemision, ByVal obeListaObservacion As List(Of beGuiaRemision))
        Dim obrGuiaRemision As New brGuiasRemision
        Dim oDs As New DataSet
        oDs = obrGuiaRemision.fdsGenerarGuiaRemision(obeGuiaRemision, obeListaObservacion, objSeguridadBN.pstrTipoSistema)
        If Not ("" & obeGuiaRemision.PSERROR & "").ToString.Equals("") Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        End If
        Select Case objSeguridadBN.pstrTipoSistema
            'Case "01"
            'VistraPreviaGuiaRemisionAT(oDs, obeGuiaRemision.PSMODELO)
            Case "03", "04"
                VistraPreviaGuiaRemisionDS(obeGuiaRemision, oDs, obeGuiaRemision.PSMODELO)
        End Select
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

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
  
    Private Sub frmGenerarGuiaRemision_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
           

            Dim dt_tipoGR As New DataTable
            Dim objAyuda As New RANSA.Controls.TipoAyuda.TipoAyuda_DAL
            dt_tipoGR = objAyuda.fdtListar_TablaAyuda_L01("TPOGRM", "")
            cboTipoGR.DataSource = dt_tipoGR
            cboTipoGR.DisplayMember = "TDSDES"
            cboTipoGR.ValueMember = "CCMPRN"
            cboTipoGR.SelectedValue = "F"
            cboTipoGR.Enabled = False
            'If bGenerar_Electronico_Default = True Then
            '    cboTipoGR.SelectedValue = "E"
            'End If

            CargarControl()
            PrecargarControles()
            CargarControles()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
      
    End Sub

    Private Sub UcClienteTerceroOrigen_TextChanged() Handles UcClienteTerceroOrigen.TextChanged
        UcPlantaDeEntregaOrigen.pClear()
        UcPlantaDeEntregaOrigen.CodClienteTercero = UcClienteTerceroOrigen.ItemActual.PNCPRVCL
    End Sub

    Private Sub UcClienteTerceroDestino_TextChanged() Handles UcClienteTerceroDestino.TextChanged
        UcPlantaDeEntregaDestino.pClear()
        UcPlantaDeEntregaDestino.CodClienteTercero = UcClienteTerceroDestino.ItemActual.PNCPRVCL
    End Sub

    Private Sub txtMedioSugerido_ActivarAyuda(ByRef objData As Object) Handles txtMedioSugerido.ActivarAyuda
        Dim obrMedioTransporte As New Ransa.NEGO.brGeneral
        Dim obeMedioTransporte As New Ransa.TypeDef.beGeneral
        objData = obrMedioTransporte.ListaMedioTransporte(obeMedioTransporte)
    End Sub

    Private Sub txtMedioSugerido_CambioDeTexto1(ByVal strData As String, ByRef objData As Object) Handles txtMedioSugerido.CambioDeTexto
        If Not strData.Trim.Equals("") Then
            Dim obrMedioTransporte As New Ransa.NEGO.brGeneral
            Dim obeMedioTransporte As New Ransa.TypeDef.beGeneral
            With obeMedioTransporte
                .PNCMEDTR = Val(strData)
                .PSTNMMDT = strData
            End With
            objData = obrMedioTransporte.ListaMedioTransporte(obeMedioTransporte)
        End If
    End Sub

    Private Sub bsaEmpresaTransporteListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaEmpresaTransporteListar.Click
        Call mfblnBuscar_EmpresaTransporte(txtEmpresaTransporte.Tag, txtEmpresaTransporte.Text, _strNroRUCTransportisdta, _strDireccionTransportista)
    End Sub

    Private Sub txtEmpresaTransporte_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmpresaTransporte.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfblnBuscar_EmpresaTransporte(txtEmpresaTransporte.Tag, txtEmpresaTransporte.Text, _strNroRUCTransportisdta, _strDireccionTransportista)
        End If
    End Sub

    Private Sub txtEmpresaTransporte_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmpresaTransporte.TextChanged
        txtEmpresaTransporte.Tag = ""
    End Sub

    Private Sub txtEmpresaTransporte_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEmpresaTransporte.Validating
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
    End Sub

    Private Sub bsaPlacaUnidadListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaPlacaUnidadListar.Click
        Call mfblnBuscar_PlacaUnidad("" & txtEmpresaTransporte.Tag, txtPlacaUnidad.Text, txtPlacaAcoplado.Text, txtNroBrevete.Text, "", "", pstrMTC)
        txtPlacaUnidad.Tag = txtPlacaUnidad.Text
        txtPlacaUnidad.Focus()
    End Sub

    Private Sub txtPlacaUnidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPlacaUnidad.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfblnBuscar_PlacaUnidad("" & txtEmpresaTransporte.Tag, txtPlacaUnidad.Text, txtPlacaAcoplado.Text, txtNroBrevete.Text, "", "", pstrMTC)
        End If
    End Sub

    Private Sub txtPlacaUnidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPlacaUnidad.TextChanged
        txtPlacaUnidad.Tag = ""
    End Sub

    Private Sub txtPlacaUnidad_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPlacaUnidad.Validating
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
    End Sub

    Private Sub bsaNroBreveteListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaNroBreveteListar.Click
        Call mfblnBuscar_Brevete("" & txtEmpresaTransporte.Tag, txtNroBrevete.Text, _strDriver, "")
        txtNroBrevete.Tag = txtNroBrevete.Text
    End Sub

    Private Sub bsaPlacaAcopladoListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaPlacaAcopladoListar.Click
        Call pBuscarPlacaAcoplado(txtEmpresaTransporte.Tag, txtPlacaAcoplado.Text, booValidarPlacaAcoplado)
    End Sub

    Private Sub txtNroBrevete_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNroBrevete.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfblnBuscar_Brevete("" & txtEmpresaTransporte.Tag, txtNroBrevete.Text, _strDriver, "")
            txtNroBrevete.Tag = txtNroBrevete.Text
        End If
    End Sub

    Private Sub txtNroBrevete_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroBrevete.TextChanged
        txtNroBrevete.Tag = ""
    End Sub

    Private Sub txtNroBrevete_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNroBrevete.Validating
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
    End Sub

    Private Sub txtPlacaAcoplado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPlacaAcoplado.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call pBuscarPlacaAcoplado(txtEmpresaTransporte.Tag, txtPlacaAcoplado.Text, booValidarPlacaAcoplado)
        End If
    End Sub

    Private Sub txtPlacaAcoplado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPlacaAcoplado.TextChanged
        booValidarPlacaAcoplado = False
    End Sub

    Private Sub txtPlacaAcoplado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPlacaAcoplado.Validating
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
    End Sub

    Private Sub txtEmpresaTransporte2doTramo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmpresaTransporte2doTramo.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfblnBuscar_EmpresaTransporte(txtEmpresaTransporte2doTramo.Tag, txtEmpresaTransporte2doTramo.Text, _strNroRUCTransportisdta)
        End If
    End Sub

    Private Sub txtEmpresaTransporte2doTramo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmpresaTransporte2doTramo.TextChanged
        txtEmpresaTransporte2doTramo.Tag = ""
    End Sub

    Private Sub txtEmpresaTransporte2doTramo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEmpresaTransporte2doTramo.Validating
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
    End Sub

    Private Sub bsaEmpresaTransporte2doTramoListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaEmpresaTransporte2doTramoListar.Click
        Call mfblnBuscar_EmpresaTransporte(txtEmpresaTransporte2doTramo.Tag, txtEmpresaTransporte2doTramo.Text, "")
    End Sub

    Private Sub rbtPlantaCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtPlantaCliente.CheckedChanged
        UcPlantaDeEntregaPropioDestino.Enabled = True
        UcClienteTerceroDestino.Enabled = False
        UcClienteTerceroDestino.pClear()
        UcPlantaDeEntregaDestino.Enabled = False
        UcPlantaDeEntregaDestino.pClear()
    End Sub

    Private Sub rbtClienteTercero_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtClienteTercero.CheckedChanged
        UcPlantaDeEntregaPropioDestino.Enabled = False
        UcPlantaDeEntregaPropioDestino.pClear()
        UcClienteTerceroDestino.Enabled = True
        UcPlantaDeEntregaDestino.Enabled = True
        If _EsRecojo Then
            If UcPlantaDeEntregaOrigen.ItemActual.PNCPRVCL = 0 Then
                UcPlantaDeEntregaPropioDestino.Enabled = False
            End If
        End If
    End Sub

    Private Sub txtMotivoTraslado_CambioDeTexto(ByVal objData As Object) Handles txtMotivoTraslado.CambioDeTexto
        If objData Is Nothing Then Exit Sub
        If (objSeguridadBN.pstrTipoSistema = "01" And "" & CType(objData, beGeneral).PSSTPING = "A") Or _
        (objSeguridadBN.pstrTipoSistema = "04" And "" & CType(objData, beGeneral).PSSTPING = "A") Or _
              (objSeguridadBN.pstrTipoSistema = "03" And "" & CType(objData, beGeneral).PSSTPING = "8") Then
            txtObsOtrosMotivos.ReadOnly = False
        Else
            txtObsOtrosMotivos.Text = ""
            txtObsOtrosMotivos.ReadOnly = True
        End If
    End Sub

    Private Sub chkAutoGenerar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAutoGenerar.CheckedChanged
        fAutoGenerarGuiaRemision(Me.chkAutoGenerar.Checked)
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            If Not fblnValidarControles() Then Exit Sub
            Call pGenerarReporte()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
      
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopiar.Click
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
            .ptxtClienteOrigenTag = UcPlantaDeEntregaOrigen.ItemActual.PNCCLNT
            .ptxtPlantaOrigenTag = UcPlantaDeEntregaOrigen.ItemActual.PNCPLNCL
            .ptxtPlantaOrigenText = UcPlantaDeEntregaOrigen.ItemActual.PSTDRCPL.Trim
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
        End With
    End Sub

    Private Sub btnPegar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPegar.Click
        If objCopiarPegar Is Nothing Then
            MessageBox.Show("No a realizado copia de Guia de Remision.")
        Else
            With objCopiarPegar
                'GuiaRemision
                dtpFechaEmision.Value = .pdtpFechaEmision
                txtMotivoTraslado.Valor = .ptxtMotivoTrasladoTag
                txtMotivoTraslado.Refresh()
                txtObservaciones.Text = .ptxtObservaciones
                'OrigenDestino
                Dim oPlantaEntrega As New Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega
                oPlantaEntrega.PNCCLNT = .ptxtClienteOrigenTag
                oPlantaEntrega.PNCPLNCL = .ptxtPlantaOrigenTag
                UcPlantaDeEntregaOrigen.pCargar(oPlantaEntrega)

                rbtPlantaCliente.Checked = .prbtPlantaCliente
                'UcPlantaDeEntregaPropioDestino
                If rbtPlantaCliente.Checked = True Then
                    Dim oPlantaEntProDest As New Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega
                    oPlantaEntProDest.PNCCLNT = .ptxtClienteDestinoTag
                    oPlantaEntProDest.PNCPLNCL = .ptxtPlantaClienteTag
                    UcPlantaDeEntregaPropioDestino.pCargar(oPlantaEntProDest)
                End If

                rbtClienteTercero.Checked = .prbtClienteTercero
                If rbtClienteTercero.Checked = True Then
                    'Cliente
                    Dim oClienteTerceroDestino As New Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega
                    oClienteTerceroDestino.PNCCLNT = _PNCCLNT
                    oClienteTerceroDestino.PNCPRVCL = .ptxtProveedor
                    oClienteTerceroDestino.PSTPRVCL = .ptxtClienteTerceroText
                    oClienteTerceroDestino.PSSTPORL = .ptxtTipoRelacionText
                    oClienteTerceroDestino.PNNRUCPR = .ptxtRucProveedorText
                    UcClienteTerceroDestino.pCargar2(oClienteTerceroDestino)
                    UcClienteTerceroDestino.Refresh()

                    'Planta
                    Dim oPlantaDeEntregaDestino As New Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega
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
                txtNroBrevete.Tag = .ptxtNroBreveteTag
                txtNroBrevete.Text = .ptxtNroBreveteText
                txtNroBrevete.Select()
                txtPlacaAcoplado.Tag = .ptxtPlacaAcopladoTag
                txtPlacaAcoplado.Text = .ptxtPlacaAcopladoText
                txtPlacaAcoplado.Select()
                txtObservaciones.Text = .ptxtObservaciones
                chkDosTramos.Checked = .pchkDosTramos
                txtEmpresaTransporte2doTramo.Tag = .ptxtEmpresaTransporte2doTramoTag
                txtEmpresaTransporte2doTramo.Text = .ptxtEmpresaTransporte2doTramoText
                txtEmpresaTransporte2doTramo.Select()
            End With
        End If
    End Sub

    Private Sub txtNroGuiaRemision_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNroGuiaRemision.Validating
        If txtNroGuiaRemision.Text <> "" And "" & txtNroGuiaRemision.Text <> "0" Then
            Dim obrGuiaRemision As New DespachoSDS.brGuiasRemision
            Dim obeguiaremision As New beGuiaRemision
            obeguiaremision.PNCCLNT = Me.txtCliente.pCodigo
            obeguiaremision.PSNGUIRM = Me.txtNroGuiaRemision.Text
            If obrGuiaRemision.fboolExisteGuiaRemision(obeguiaremision) Then
                e.Cancel = True
                HelpClass.MsgBox("La guía Nro. " & Me.txtNroGuiaRemision.Text & _
            " se encuentra registrada, digite guía de remisión correcta ", MessageBoxIcon.Warning)
            End If

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

    Private Sub txtManChoferes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtManChoferes.Click
        If txtEmpresaTransporte.Tag = "0" Or txtEmpresaTransporte.Tag = String.Empty Then Return
        Dim ofrmChofer As New frmChofer
        ofrmChofer.CTRSP = Convert.ToInt32(Me.txtEmpresaTransporte.Tag)
        If ofrmChofer.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.txtNroBrevete.Text = ofrmChofer.Brevete
            txtNroBrevete.Tag = ofrmChofer.Brevete
            txtNroBrevete_Validating(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtMantCamiones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMantCamiones.Click
        If txtEmpresaTransporte.Tag = String.Empty Or txtEmpresaTransporte.Tag = "0" Then Return
        Dim ofrmCamion As New frmCamion
        ofrmCamion.CTRSP = Convert.ToInt32(txtEmpresaTransporte.Tag)
        If ofrmCamion.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.txtPlacaUnidad.Text = ofrmCamion.Placa
            Me.txtPlacaUnidad.Tag = ofrmCamion.Placa
            Me.txtPlacaUnidad_Validating(Nothing, Nothing)
        End If
    End Sub

    Private Sub dtpFechaEmision_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpFechaEmision.Validating
        ValidarFechaGuiaRemision()
    End Sub

    Private Sub dtpFechaEmision_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaEmision.ValueChanged
        ValidarFechaGuiaRemision()
    End Sub

    Private Sub chkDosTramos_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDosTramos.CheckedChanged
        If chkDosTramos.Checked Then
            txtEmpresaTransporte2doTramo.Enabled = True
        Else
            txtEmpresaTransporte2doTramo.Text = ""
            txtEmpresaTransporte2doTramo.Tag = ""
            txtEmpresaTransporte2doTramo.Enabled = False
        End If
    End Sub

#End Region

    'Private Sub cboTipoGR_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboTipoGR.SelectionChangeCommitted

    'End Sub
    Private Sub cboTipoGR_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboTipoGR.SelectionChangeCommitted
        Try
            txtNroGuiaRemision.Text = ""
            chkAutoGenerar.Checked = False
            'txtNroGuiaRemision.Mask = "AAAA-########"

            Dim dt_listserie_gr As New DataTable
            'dt_listserie_gr = dt_Listado_serie.Copy
            txtNroGuiaRemision.Enabled = True

            Dim tipo As String = ("" & cboTipoGR.SelectedValue).ToString.Trim
            Select Case tipo
                Case "F"
                    txtNroGuiaRemision.Mask = "000-0000000"
                    'txtNroGuiaRemision.Text = "00"
                    chkAutoGenerar.Enabled = True
                    'cboTipoSerie.DataSource = Nothing
                Case "E"
                    txtNroGuiaRemision.Mask = "LAAA-00000000" ' Primera caracter : Letra / 3 caracteres alfanumerico/ 8 numericos
                    chkAutoGenerar.Enabled = False
                    'cboTipoSerie.DataSource = dt_listserie_gr
                    'cboTipoSerie.DisplayMember = "TSERIE"
                    'cboTipoSerie.ValueMember = "CSERIE"
                    'Dim seriegr As String = ("" & cboTipoSerie.SelectedValue)
                    'If seriegr <> "" Then
                    '    txtNroGuiaRemision.Enabled = False
                    'End If
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try


    End Sub

End Class
