Imports Ransa.TYPEDEF
Imports RANSA.Utilitario
Imports Ransa.NEGO
Imports RANSA.NEGO.DespachoSAT
Imports Ransa.NEGO.slnSOLMIN_SAT.Despacho.Reportes

Public Class frmGenerarGuiaRemisionManual
    'hOOHOLA MUNDFO
    'hiii



#Region " Atributos "
    Private intCCLNT As Int64 = 0
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


    'Private _PNCPRVCO As Decimal = 485
    '''' <summary>
    '''' Código del Código Cliente Tercero Origen  
    '''' </summary>
    '''' <value></value>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Public Property PNCPRVCO() As Decimal
    '    Get
    '        Return _PNCPRVCO
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _PNCPRVCO = value
    '    End Set
    'End Property
#Region "Propiedades"



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




    Private Sub CargarControles()
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
        Dim obrGeneral As New RANSA.NEGO.brGeneral
        txtMotivoTraslado.DataSource = obrGeneral.floListaMovimientoGuiaRemisionCliente(_PNCCLNT)
        txtMotivoTraslado.ListColumnas = oListColum
        txtMotivoTraslado.Cargas()
        txtMotivoTraslado.ValueMember = "PSSTPING"
        txtMotivoTraslado.DispleyMember = "PSTDSDES"


        Dim oListColumTD As New Hashtable
        Dim oColumnasTD As New DataGridViewTextBoxColumn

        ''==========tipo Origen
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

        bolGuiaAutoGenerado = obrGeneral.bolElClienteEsOutotec(_PNCCLNT)
        Me.chkAutoGenerar.Checked = bolGuiaAutoGenerado
        fAutoGenerarGuiaRemision(bolGuiaAutoGenerado)

        Dim obeGeneral As New beGeneral
        obeGeneral.PSSTPOUN = "C"
        olUnidadeCantidad = obrGeneral.ListaUnidadDeMedida(obeGeneral)
        obeGeneral.PSSTPOUN = "P"
        olUnidadePeso = obrGeneral.ListaUnidadDeMedida(obeGeneral)

    End Sub

    Private Sub CargarControl()
        If _EsRecojo Then
            UcClienteTerceroOrigen.Visible = True
            lblClienteOrigen.Visible = True
            UcClienteTerceroOrigen.CodCliente = _PNCCLNT

            'vualisamos el cliente tercero en la posicion siguiente
            lblPlantaOrigen.Location = New Point(509, 17)
            UcPlantaDeEntregaOrigen.Location = New Point(610, 19)

            lblClienteOrigen.Location = New Point(18, 19)
            UcClienteTerceroOrigen.Location = New Point(107, 17)

            'Planta tercero
            UcPlantaDeEntregaOrigen.TipoPlantaDeEntrega = False
            UcPlantaDeEntregaOrigen.CodCliente = _PNCCLNT
            UcPlantaDeEntregaOrigen.pClear()

            UcPlantaDeEntregaPropioDestino.TipoPlantaDeEntrega = True
            UcPlantaDeEntregaPropioDestino.CodCliente = _PNCCLNT
            UcPlantaDeEntregaPropioDestino.pClear()

            UcClienteTerceroDestino.CodCliente = _PNCCLNT
            UcClienteTerceroDestino.pClear()

            UcPlantaDeEntregaDestino.TipoPlantaDeEntrega = False
            UcPlantaDeEntregaDestino.CodCliente = _PNCCLNT
            UcPlantaDeEntregaDestino.pClear()


        Else
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

        End If
        txtCliente.pCargar(_PNCCLNT)
        txtCliente.Refresh()
    End Sub

    Private Sub CargarTipoPedido()
        Dim oDt As New DataTable

        oDt.Columns.Add("COD")
        oDt.Columns.Add("DESC")
        Dim oDr As DataRow

        oDr = oDt.NewRow()
        oDr.Item("COD") = ""
        oDr.Item("DESC") = ""
        oDt.Rows.Add(oDr)

        oDr = oDt.NewRow()
        oDr.Item("COD") = "P"
        oDr.Item("DESC") = "PP"
        oDt.Rows.Add(oDr)

        oDr = oDt.NewRow()
        oDr.Item("COD") = "S"
        oDr.Item("DESC") = "PS"
        oDt.Rows.Add(oDr)

        oDr = oDt.NewRow()
        oDr.Item("COD") = "O"
        oDr.Item("DESC") = "PR"
        oDt.Rows.Add(oDr)
        Me.cmbTipoPedido.DataSource = oDt
        Me.cmbTipoPedido.ValueMember = "COD"
        Me.cmbTipoPedido.DisplayMember = "DESC"
    End Sub

    Private Sub PrecargarControles()
        ' Habilitar Opciones según el Sistema que se haya cargado
        Select Case objSeguridadBN.pstrTipoSistema
            Case "01"
                dtpFechaEmision.Enabled = True
                dtpFechaTraslado.Enabled = True
                txtNroFactura.Enabled = False
                dtpFechaFactura.Enabled = False
                txtPlacaAcoplado.Enabled = True
                '-- Inicializamos los valores según Sistema
 
                '-- Motivo del Traslado
                txtMotivoTraslado.Text = strSMTRCP_DET
                txtMotivoTraslado.Tag = strSMTRCP
                '-- Manifiesto
                txtObservaciones.Text = strNMNFTF
            Case "03"
                dtpFechaEmision.Enabled = True
                dtpFechaTraslado.Enabled = True
                txtNroFactura.Enabled = True
                dtpFechaFactura.Enabled = True
                txtPlacaAcoplado.Enabled = False
                '-- Inicializamos los valores según Sistema

        End Select

        Me.txtMedioSugerido.Refrescar(4)
        ' Empresa de Transporte
        rbtPlantaCliente.Checked = True
        txtEmpresaTransporte.Tag = strCTRSPT
        mfblnObtenerDetalle_EmpresaTransporte(txtEmpresaTransporte.Tag, txtEmpresaTransporte.Text, "")
        If strCTRSPT <> "" Then
            Call mfblnBuscar_EmpresaTransporte(txtEmpresaTransporte.Tag, txtEmpresaTransporte.Text, _strNroRUCTransportisdta, _strDireccionTransportista)
        End If

        ' Placa de la Unidad
        txtPlacaUnidad.Text = strNPLCUN
        txtPlacaUnidad.Tag = strNPLCUN
        ' Placa del Acoplado
        txtPlacaAcoplado.Text = strNPLCAC
        txtPlacaAcoplado.Tag = strNPLCAC
        ' Nro. Brevete
        txtNroBrevete.Text = strCBRCNT
        txtNroBrevete.Tag = strCBRCNT
        Me.txtNroFactura.Text = IIf(_intFactura = 0, "", _intFactura)
    End Sub

    Private Sub UcClienteTerceroOrigen_TextChanged() Handles UcClienteTerceroOrigen.TextChanged
        UcPlantaDeEntregaOrigen.pClear()
        UcPlantaDeEntregaOrigen.CodClienteTercero = UcClienteTerceroOrigen.ItemActual.PNCPRVCL

        'UcPlantaDeEntregaPropioDestino.pClear()
        'UcPlantaDeEntregaPropioDestino.CodClienteTercero = UcClienteTerceroOrigen.ItemActual.PNCPRVCL

    End Sub

    Private Sub UcClienteTerceroDestino_TextChanged() Handles UcClienteTerceroDestino.TextChanged
        UcPlantaDeEntregaDestino.pClear()
        UcPlantaDeEntregaDestino.CodClienteTercero = UcClienteTerceroDestino.ItemActual.PNCPRVCL

    End Sub


    Private Sub frmGenerarGuiaRemision_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarTipoPedido()
        PrecargarControles()
        CargarControl()
        CargarControles()
    End Sub

    Private Sub txtMedioSugerido_ActivarAyuda(ByRef objData As Object) Handles txtMedioSugerido.ActivarAyuda
        Dim obrMedioTransporte As New RANSA.NEGO.brGeneral
        Dim obeMedioTransporte As New RANSA.TYPEDEF.beGeneral
        objData = obrMedioTransporte.ListaMedioTransporte(obeMedioTransporte)
    End Sub


    Private Sub txtMedioSugerido_CambioDeTexto1(ByVal strData As String, ByRef objData As Object) Handles txtMedioSugerido.CambioDeTexto
        If Not strData.Trim.Equals("") Then
            Dim obrMedioTransporte As New Ransa.NEGO.brGeneral
            Dim obeMedioTransporte As New Ransa.TYPEDEF.beGeneral
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
                ' Call mfblnBuscar_EmpresaTransporte(txtEmpresaTransporte.Tag(1), txtEmpresaTransporte.Text, txtEmpresaTransporte.Tag(2))
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
            txtPlacaAcoplado.Text = "0"
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

   
    Private Function fblnValidaContenedor() As Boolean

        Return fblnValidaContenedor
    End Function

    Private Function fblnValidarControles() As Boolean
        Dim strMensajeError As String = ""
        Dim codMedioEnvio As String = "0"
        Dim intQlineas As Integer
        Dim bolEsOutotec As Boolean = False
        Me.dtgDetalleGuia.EndEdit()
        ' Reiniciamos la variable del estado de la validación
        blnResultadoValidar = True
        ' Realizamos la validación de los campos
        'If dtpFechaTraslado.Value < dtpFechaEmision.Value Then _
        '    strMensajeError &= "- La Fecha de Traslado debe ser mayor o igual a la Fecha de Emisión" & vbNewLine
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
            codMedioEnvio = CType(txtMedioSugerido.objResult, RANSA.TYPEDEF.beGeneral).PNCMEDTR
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
                If txtPlacaAcoplado.Enabled And txtPlacaAcoplado.Text = "" Then _
                               strMensajeError &= "- Debe seleccionar el Acoplado de la Unidad" & vbNewLine
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

        Dim intContRow As Integer = 0D
        If Me.dtgDetalleGuia.RowCount = 0 Then
            strMensajeError &= "- La guía de remsión debe de tener detalle" & vbNewLine
        Else
            For Each obeGui As beGuiaRemision In Me.dtgDetalleGuia.DataSource
                'OrElse obeGui.PNQPSGU = 0 OrElse obeGui.PSCUNPS = ""
                If obeGui.PNQCNGU = 0 OrElse obeGui.PSCUNCN = "" Then
                    strMensajeError &= "- Detalle de la guía debe de tener datos consistentes" & vbNewLine
                    Exit For
                End If
                If obeGui.PSTDITEM.Trim.Length > 60 Then
                    intQlineas = Math.Ceiling(obeGui.PSTDITEM.Trim.Length / 60)
                    intContRow = intContRow + intQlineas
                Else
                    intContRow = intContRow + 1
                End If
                If obeGui.PSTOBDGS.Trim.Length > 0 Then
                    intContRow = intContRow + 1
                End If
            Next
        End If

        For intRow As Integer = 0 To Me.dtgObservacion.Rows.Count - 2
            intContRow = intContRow + 1
        Next
        If bolEsOutotec Then
            If intContRow > 20 Then
                strMensajeError &= "- La Guía de remisión excede la cantidad de líneas por guía" & vbNewLine
            End If
        End If
        Dim obrGeneral As New Ransa.NEGO.brGeneral
        bolEsOutotec = obrGeneral.bolElClienteEsOutotec(_PNCCLNT)
        'Validamos que el clientes sea Outotec
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

        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            blnResultadoValidar = False
        End If
        Return blnResultadoValidar
    End Function

    Private Sub pGenerarGuiaDeRemision()

        Me.dtgDetalleGuia.EndEdit()
        If MessageBox.Show("Desea generar la guía de remisión??", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
        'Select Case objSeguridadBN.pstrTipoSistema
        '    Case "01"
        Dim obeGuiaRemision As beGuiaRemision = New beGuiaRemision 'clsPARAM_GuiaRemisionAT
        ' Filtros
        With obeGuiaRemision

            .PNCCLNT = _PNCCLNT
            .PNCCLNGR = Me.txtCliente.pCodigo
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
                .PSORIGEN = UcPlantaDeEntregaOrigen.ItemActual.PSTDRCPL.Trim
            Else
                .PNCPLNOR = UcPlantaDeEntregaOrigen.ItemActual.PNCPLNCL
                .PSORIGEN = UcPlantaDeEntregaOrigen.ItemActual.PSTDRCPL.Trim  '& UcPlantaDeEntregaOrigen.ItemActual.PSTPRSCN
            End If

            If rbtPlantaCliente.Checked Then
                .PNCPLNCL = UcPlantaDeEntregaPropioDestino.ItemActual.PNCPLNCL '  Codigo Planta Cliente   
                .PSDESTINO = UcPlantaDeEntregaPropioDestino.ItemActual.PSTDRCPL.Trim
                .PSTIPORG = "I"
                .PSCORIDE = UcPlantaDeEntregaPropioDestino.ItemActual.PSCPRPCL
            Else
                .PNCPRVCL = UcClienteTerceroDestino.ItemActual.PNCPRVCL '     Codigo Cliente Tercero           
                .PSTIPORG = UcClienteTerceroDestino.ItemActual.PSSTPORL.Trim
                .PSCORIDE = UcClienteTerceroDestino.ItemActual.PSCPRPCL.Trim
                .PNCPLCLP = UcPlantaDeEntregaDestino.ItemActual.PNCPLNCL ' Codigo Planta Tercero    
                .PSDESTINO = UcPlantaDeEntregaDestino.ItemActual.PSTDRCPL.Trim
            End If

            .PSSMTGRM = CType(txtMotivoTraslado.Resultado, beGeneral).PSSTPING
            .PSTOBORM = txtObsOtrosMotivos.Text
            .PSNGUIRM = txtNroGuiaRemision.Text
            Int64.TryParse(txtEmpresaTransporte.Tag, .PNCTRSPT)
            .PSNPLCCM = txtPlacaUnidad.Text
            .PSNPLACP = txtPlacaAcoplado.Text
            .PSNBRVCH = txtNroBrevete.Text
            .PSTOBSRM = txtObservaciones.Text

            If txtObservaciones.Text.Trim.Length > 30 Then
                .PSTOBSRM = txtObservaciones.Text.Trim.Substring(0, 30)
                .PSTOBCLI = txtObservaciones.Text.Trim.Substring(30, txtObservaciones.Text.Trim.Length - 30)
            Else
                .PSTOBSRM = txtObservaciones.Text.Trim
                .PSTOBCLI = ""
            End If


            If txtNroFactura.Text <> "" Then
                .PNTDCFCC = CType(txtTipoDoc.Resultado, beGeneral).PNCTPODC
                .PNNDCFCC = Val(txtNroFactura.Text)
                .FechaDocumento = Me.dtpFechaFactura.Value
            Else
                .PNTDCFCC = 0
                .PNNDCFCC = 0
                .PNFDCFCC = 0
            End If
            If chkDosTramos.Checked Then _
                .PNNDCMRF = txtEmpresaTransporte2doTramo.Tag
            If Not txtMedioSugerido.objResult Is Nothing Then
                .PNCMEDTR = CType(txtMedioSugerido.objResult, Ransa.TYPEDEF.beGeneral).PNCMEDTR
            End If
            .strAplicacion = Application.StartupPath
            .PSCPRCN1 = txtSigla.Text.Trim
            .PSNSRCN1 = txtNumeroContenedor.Text.Trim
            .pstrTipoMovIntfz = strTipoMovIntfz

            .PSTCMPTR = txtEmpresaTransporte.Text
            .PNNRUCT = _strNroRUCTransportisdta
            .PSTNMBCH = _strDriver
            .PSUSUARIO = objSeguridadBN.pUsuario
            .PSNTRMNL = objSeguridadBN.pstrPCName
            .PSNRGMT1 = pstrMTC

            .PSNRFTPD = Me.cmbTipoPedido.Text
            .PSNRFRPD = txtNumeroPedido.Text
            .PSNORCML = Me.txtOrdenDeCompra.Text
        End With

        Dim obelistDetGui As New List(Of beGuiaRemision)
        Dim intQlineas As Integer = 0
        Dim intItemGuia As Int32 = 0
        Dim strMercaderia As String = ""
        For Each obeDetGuia As beGuiaRemision In Me.dtgDetalleGuia.DataSource
            obeDetGuia.PNCCLNT = Me.txtCliente.pCodigo
            obeDetGuia.PSNGUIRM = Me.txtNroGuiaRemision.Text
            If obeDetGuia.PSTDITEM.Trim.Length > 60 Then
                Dim obeDetGuiaRemision As beGuiaRemision
                intQlineas = Math.Ceiling(obeDetGuia.PSTDITEM.Trim.Length / 60)
                strMercaderia = obeDetGuia.PSTDITEM.Trim
                For intLine As Integer = 1 To intQlineas
                    obeDetGuiaRemision = New beGuiaRemision
                    obeDetGuiaRemision.PSCMRCLR = obeDetGuia.PSCMRCLR
                    obeDetGuiaRemision.PNCCLNT = obeDetGuia.PNCCLNT
                    obeDetGuiaRemision.PSNGUIRM = obeDetGuia.PSNGUIRM
                    obeDetGuiaRemision.PNQCNGU = obeDetGuia.PNQCNGU
                    obeDetGuiaRemision.PSCUNCN = obeDetGuia.PSCUNCN
                    obeDetGuiaRemision.PNQPSGU = obeDetGuia.PNQPSGU
                    obeDetGuiaRemision.PSCUNPS = obeDetGuia.PSCUNPS
                    obeDetGuiaRemision.PSCMRCLR = obeDetGuia.PSCMRCLR
                    obeDetGuiaRemision.PSCSRECL = obeDetGuia.PSCSRECL
          obeDetGuiaRemision.PSCUNPS = obeDetGuia.PSCUNPS
          obeDetGuiaRemision.PSTOBDGS = obeDetGuia.PSTOBDGS  'Observación
                    If intLine = intQlineas Then
                        obeDetGuiaRemision.PSTDITEM = strMercaderia.Trim.Substring(60 * (intLine - 1), strMercaderia.Trim.Length - 60 * (intLine - 1))
                    Else
                        obeDetGuiaRemision.PSTDITEM = strMercaderia.Trim.Substring(60 * (intLine - 1), 60)
                    End If
                    obeDetGuiaRemision.PNNSLCSR = intItemGuia
                    obeDetGuiaRemision.PSNORCML = Me.txtOrdenDeCompra.Text
                    obeDetGuiaRemision.PSUSUARIO = objSeguridadBN.pUsuario
                    obelistDetGui.Add(obeDetGuiaRemision)
                Next
                intItemGuia = intItemGuia + 1
            Else
                obeDetGuia.PNNSLCSR = intItemGuia
                obeDetGuia.PSUSUARIO = objSeguridadBN.pUsuario
                obeDetGuia.PSNORCML = Me.txtOrdenDeCompra.Text
                obelistDetGui.Add(obeDetGuia)
                intItemGuia = intItemGuia + 1
            End If
        Next

        'Observacion

        Dim obeListaObservacion As New List(Of beGuiaRemision)
        Dim obeObervacion As beGuiaRemision
        For intRow As Integer = 0 To Me.dtgObservacion.Rows.Count - 2
            obeObervacion = New beGuiaRemision
            With obeObervacion
                .PNCCLNGR = obeGuiaRemision.PNCCLNGR
                .PSNGUIRM = obeGuiaRemision.PSNGUIRM
                .PSUSUARIO = objSeguridadBN.pUsuario
                .PSNTRMNL = objSeguridadBN.pstrPCName
                .PSTOBDGS = "" & dtgObservacion.Rows(intRow).Cells("TOBSGS").Value & ""
            End With
            obeListaObservacion.Add(obeObervacion)
        Next

        Dim obrGuiaRemision As New brGuiasRemision
        Dim oDs As New DataSet
        oDs = obrGuiaRemision.fdsGenerarGuiaRemisionManual(obeGuiaRemision, obeListaObservacion, obelistDetGui, objSeguridadBN.pstrTipoSistema, _EsRecojo)
        If Not ("" & obeGuiaRemision.PSERROR & "").ToString.Equals("") Then
            HelpClass.MsgBox(obeGuiaRemision.PSERROR)
            Exit Sub
        End If
        Select Case objSeguridadBN.pstrTipoSistema
            Case "01"
                VistraPreviaGuiaRemisionAT(oDs, obeGuiaRemision.PSMODELO)
            Case "03", "04"
                VistraPreviaGuiaRemisionDS(oDs, obeGuiaRemision.PSMODELO)
        End Select
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

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


    Private Sub VistraPreviaGuiaRemisionDS(ByVal oDs As DataSet, ByVal strModeloGuia As String)
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
        End With
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
            If UcClienteTerceroOrigen.ItemActual.PNCPRVCL = 0 Then
                UcPlantaDeEntregaPropioDestino.Enabled = False
            End If
            'UcPlantaDeEntregaPropioDestino.CodClienteTercero = UcClienteTerceroOrigen.ItemActual.PNCPRVCL

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

  


    Private Sub tsbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAceptar.Click
        Try

            BeGuiaRemisionBindingSource.EndEdit()
            dtgObservacion.EndEdit()
            If Not fblnValidarControles() Then Exit Sub
            Call pGenerarGuiaDeRemision()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub tsbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub chkRecojo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRecojo.CheckedChanged
        _EsRecojo = Me.chkRecojo.Checked
        CargarControl()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim obeGuias As New beGuiaRemision
        BeGuiaRemisionBindingSource.Add(obeGuias)
    End Sub

    Private Sub dtgDetalleGuia_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dtgDetalleGuia.DataError
        HelpClass.MsgBox(e.Exception.Message)
    End Sub

    Private Sub cmbTipoPedido_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoPedido.SelectedValueChanged
        If Me.cmbTipoPedido.DataSource IsNot Nothing Then
            If Me.cmbTipoPedido.SelectedValue.ToString <> "" Then
                Me.txtNumeroPedido.ReadOnly = False
                Me.txtNumeroPedido.Text = ""
            Else
                Me.txtNumeroPedido.ReadOnly = True
                Me.txtNumeroPedido.Text = ""
            End If
        End If

    End Sub

    Private Sub dtgDetalleGuia_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtgDetalleGuia.EditingControlShowing
        If TypeOf e.Control Is TextBox Then
            If dtgDetalleGuia.CurrentCell.ColumnIndex = 4 Then
                With (DirectCast(e.Control, TextBox))
                    If olUnidadeCantidad.Count > 0 Then
                        For Each obeUnidad As beGeneral In olUnidadeCantidad
                            .AutoCompleteCustomSource.Add(obeUnidad.PSCUNDMD)
                        Next
                    End If
                    .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                    .AutoCompleteSource = AutoCompleteSource.CustomSource
                End With
            ElseIf dtgDetalleGuia.CurrentCell.ColumnIndex = 6 Then
                With DirectCast(e.Control, TextBox)
                    If olUnidadePeso.Count > 0 Then
                        For Each obeUnidad As beGeneral In olUnidadePeso
                            .AutoCompleteCustomSource.Add(obeUnidad.PSCUNDMD)
                        Next
                    End If
                    .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                    .AutoCompleteSource = AutoCompleteSource.CustomSource
                End With
            Else
                With DirectCast(e.Control, TextBox)
                    .AutoCompleteMode = AutoCompleteMode.None
                End With
            End If
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
                    tsbAceptar.Enabled = False
                Else
                    tsbAceptar.Enabled = True
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
                    tsbAceptar.Enabled = False
                Else
                    tsbAceptar.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub dtpFechaEmision_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpFechaEmision.Validating
        ValidarFechaGuiaRemision()
    End Sub

    Private Sub dtpFechaEmision_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaEmision.ValueChanged
        ValidarFechaGuiaRemision()
    End Sub


    Private Sub chkDosTramos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDosTramos.CheckedChanged
        If chkDosTramos.Checked Then
            txtEmpresaTransporte2doTramo.Enabled = True
        Else
            txtEmpresaTransporte2doTramo.Text = ""
            txtEmpresaTransporte2doTramo.Tag = ""
            txtEmpresaTransporte2doTramo.Enabled = False
        End If
    End Sub
End Class
