
Imports Ransa.Utilitario
Imports Ransa.NEGO
Imports Ransa.TypeDef
'Imports Ransa.DAO.Cliente
'Imports Ransa.TypeDef.Cliente
Imports Ransa.DAO.OrdenCompra
Imports Ransa.Controls.Cliente
Imports Ransa.TypeDef.slnSOLMIN_SDS_SIMPLE
'Imports Ransa.TypeDef.OrdenCompra.OrdenCompra
'Imports Ransa.TypeDef.OrdenCompra.ItemOC



Public Class frmDespachoMercaderiaSDS

    Private blnStatusTransportista As Boolean = False
    Private blnStatusUnidad As Boolean = False
    Private blnStatusBrevete As Boolean = False
    'Private objMovimientoMercaderia As slnSOLMIN_SDS.clsMovimientoMercaderia
    Private objMovimientoMercaderia As clsMovimientoMercaderia
    'Private objMovimientoMercaderia As Ransa.Controls.Serie.slnSOLMIN_SDSIMPLE.clsMovimientoMercaderia
    Private intWidth As Int32 = 0
    Private a As Integer = 0
    Private pboolEstadoValidating As Boolean = False
    Private pboolEstadoCargado As Boolean = False
    Private pbolClienteOutotec As Boolean = False
    Private strTipoMovIntfz As String = ""
    Private bolEsClienteOutotec As Boolean = False
    Private pintCantidaLineas As Integer = 0
    Private intCCLNT As Integer = 0
    Private _PSNUMDES As String = String.Empty
    Private SplitDistance As Integer = 0
    Private bolError As Boolean = False

    Private pobePedidoPorPlanta As bePedidoPorPlanta

    Private _pCodigoClienteSAP As String = ""

    Private listaValidacion As New List(Of bePedidoPorPlanta)
    Private pbolClientevalidarDespacho As Boolean = False

    Public Property pCodigoClienteSAP() As String
        Get
            Return _pCodigoClienteSAP
        End Get
        Set(ByVal value As String)
            _pCodigoClienteSAP = value
        End Set
    End Property


    Public Property CCLNT() As Integer
        Get
            Return intCCLNT
        End Get
        Set(ByVal value As Integer)
            intCCLNT = value
        End Set
    End Property
    Public Property PSNUMDES() As String
        Get
            Return _PSNUMDES
        End Get
        Set(ByVal value As String)
            _PSNUMDES = value
        End Set
    End Property



    Public Sub New(ByVal obePedidoPorPlanta As bePedidoPorPlanta)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        dtgListaDespachos.AutoGenerateColumns = False
        pobePedidoPorPlanta = obePedidoPorPlanta
    End Sub

    Public Sub New(ByVal obePedidoPorPlanta As bePedidoPorPlanta, ByVal ReferenciaPedido As String, ByVal CodigoCliente As Long)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        _PSNUMDES = ReferenciaPedido
        intCCLNT = CodigoCliente
        dtgListaDespachos.AutoGenerateColumns = False

        pobePedidoPorPlanta = obePedidoPorPlanta
    End Sub

    'Private Manejo_x_Posicion As String = ""
    'Private Mensaje_posicion_obligatoriedad As String = ""

    Private Manejo_x_Posicion_NivelCliente As String = ""
    Private Mensaje_AlertaDiferencia_x_ManejoPosiciones As String = ""

    Private Sub frmDespachoMercaderiaSDS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim obrGeneral As New brGeneral
            tbpSet.Parent = Nothing
            'Validamos que el clientes sea Outotec
            pbolClienteOutotec = obrGeneral.bolElClienteEsOutotec(pobePedidoPorPlanta.PNCCLNT)
            pbolClientevalidarDespacho = obrGeneral.bolEsClienteRegistradoEnProceso("CLVLPD", pobePedidoPorPlanta.PNCCLNT)


            Dim obeGeneral As New beGeneral
            Dim oListbeGeneral As New List(Of beGeneral)
            obeGeneral.PSCODVAR = "SAMPSD"
            obeGeneral.PSCCMPRN = intCCLNT
            oListbeGeneral = obrGeneral.ListaTablaAyuda(obeGeneral)
            If oListbeGeneral.Count > 0 Then
                'Manejo_x_Posicion = oListbeGeneral(0).PSTDSDES ' manejo de ubicaciones nivel mandatorio a nivel cliente
                'Mensaje_posicion_obligatoriedad = oListbeGeneral(0).PSTDSDES2 'mostrar mensaje alerta
                Manejo_x_Posicion_NivelCliente = oListbeGeneral(0).PSTDSDES ' manejo de ubicaciones nivel mandatorio a nivel cliente
                Mensaje_AlertaDiferencia_x_ManejoPosiciones = oListbeGeneral(0).PSTDSDES2 'mostrar mensaje alerta
            End If



            ListaDespachoMercaderia(pobePedidoPorPlanta)
            CargarDatosGenerales(pobePedidoPorPlanta)
            UCDataGridView.Alinear_Columnas_Grilla(dtgListaDespachos)
            'Inicializa las varibales de los cotroles Transportista, Unidad, Brevete
            InicializarVariables()
            CargarCodigoUsado()
            CargarClientes()
            If txtTipoDesOutotec.Resultado IsNot Nothing Then
                ValidarTipoDespacho()
            Else
                Me.txtCliente.Visible = False
                Me.KryptonLabel3.Visible = False
                pnlPedido.Location = New System.Drawing.Point(483, 38)
            End If

            If pbolClientevalidarDespacho = True Then

                For Each Item As bePedidoPorPlanta In listaValidacion
                    If Item.PSNRFRPD = "" Or Item.PSNLTECL = "" Then
                        MessageBox.Show("Pedido con items manuales - no descargados por interfaz ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit For
                    End If
                Next

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub




    Private Sub CargarClientes()
        Dim objAppConfig As cAppConfig = New cAppConfig
        ' Recuperamos los ultimos valores seleccionados
        Dim intTemp As Int64 = 0

        Dim ClientePK As TD_ClientePK = New TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        ClientePK.pCCMPN_CodigoCompania = GLOBAL_COMPANIA
        txtCliente.pCargar(ClientePK)
    End Sub


    Private Sub ValidarTipoDespacho()
        If CType(txtTipoDesOutotec.Resultado, beGeneral).PSSTPING = "I" Then
            Me.txtCliente.Visible = True
            Me.KryptonLabel3.Visible = True
            txtOrigen.Valor = "A"
            txtOrigen.Refresh()
            txtOrigen.Enabled = False
            txtTipoDoc.Valor = "PE"
            txtTipoDoc.Refresh()
            txtTipoDoc.Enabled = False
            Me.txtCliente.Location = New System.Drawing.Point(566, 38)
            Me.KryptonLabel3.Location = New System.Drawing.Point(478, 38)
            Me.pnlPedido.Location = New System.Drawing.Point(483, 63)
            txtCliente.Focus()
            Me.tbpSet.Parent = Nothing

        Else

            If CType(txtTipoDesOutotec.Resultado, beGeneral).PSSTPING = "Q" Then
                txtOrigen.Valor = "A"
                txtOrigen.Refresh()
                txtOrigen.Enabled = False
                txtTipoDoc.Valor = "PE"
                txtTipoDoc.Refresh()
                txtTipoDoc.Enabled = False
                Me.txtCliente.Visible = False
                Me.KryptonLabel3.Visible = False
                pnlPedido.Location = New System.Drawing.Point(483, 38)
                Me.tbpSet.Parent = tbcDespacho


                UcClienteTerceroDestino.MostrarRuc = True
                UcClienteTerceroDestino.CodCliente = pobePedidoPorPlanta.PNCCLNT
                UcClienteTerceroDestino.TipoRelacion = CType(Me.txtOrigen.Resultado, beGeneral).PSCCMPRN.Trim
                UcClienteTerceroDestino.Enabled = True
                Exit Sub
            End If

            txtOrigen.Valor = IIf(pobePedidoPorPlanta.PSSTPORL.Trim.Equals(""), "C", pobePedidoPorPlanta.PSSTPORL)
            txtOrigen.Refresh()
            'txtOrigen.Valor = "A"
            'txtOrigen.Refresh()
            txtOrigen.Enabled = True
            'txtTipoDoc.Valor = "PE"
            'txtTipoDoc.Refresh()
            txtTipoDoc.Enabled = True
            Me.txtCliente.Visible = False
            Me.KryptonLabel3.Visible = False
            pnlPedido.Location = New System.Drawing.Point(483, 38)
            Me.tbpSet.Parent = Nothing
            'tbcDespacho.TabPages("tbpSet").Parent = Nothing
            UcClienteTerceroDestino.MostrarRuc = True
            UcClienteTerceroDestino.CodCliente = pobePedidoPorPlanta.PNCCLNT
            Dim pTipoRelacion As String = ""
            If txtOrigen.Resultado IsNot Nothing Then
                pTipoRelacion = CType(Me.txtOrigen.Resultado, beGeneral).PSCCMPRN.Trim()
            End If

            'UcClienteTerceroDestino.TipoRelacion = CType(Me.txtOrigen.Resultado, beGeneral).PSCCMPRN.Trim
            UcClienteTerceroDestino.TipoRelacion = pTipoRelacion

            Dim obePlantaDeEntrega As New PlantaDeEntrega.bePlantaDeEntrega
            Dim pPSSTPORL As String = ""
            With obePlantaDeEntrega
                .PNCCLNT = pobePedidoPorPlanta.PNCCLNT
                .PNCPRVCL = pobePedidoPorPlanta.PNCPRVCL
                .TIPOCLIENTE = False
                '.PSSTPORL = CType(Me.txtOrigen.Resultado, beGeneral).PSCCMPRN.Trim
                .PSSTPORL = pTipoRelacion
            End With
            UcClienteTerceroDestino.pCargar(obePlantaDeEntrega)
            UcClienteTerceroDestino.Enabled = False

        End If
    End Sub

    Private Sub CargarControles()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "STPING"
        oColumnas.DataPropertyName = "PSSTPING"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TTPING"
        oColumnas.DataPropertyName = "PSTTPING"
        oColumnas.HeaderText = "Tipo Despacho "
        oListColum.Add(2, oColumnas)
        Dim obrGeneral As New brGeneral
        txtTipoDesOutotec.DataSource = obrGeneral.floListaTipoMovimientoDespachoCliente(pobePedidoPorPlanta.PNCCLNT)
        txtTipoDesOutotec.ListColumnas = oListColum
        txtTipoDesOutotec.Cargas()
        txtTipoDesOutotec.ValueMember = "PSSTPING"
        txtTipoDesOutotec.DispleyMember = "PSTTPING"
        txtTipoDesOutotec.Valor = "N"
        txtTipoDesOutotec.Refresh()


        ''==========tipo Origen
        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CCMPRN"
        oColumnas.DataPropertyName = "PSCCMPRN"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TDSDES"
        oColumnas.DataPropertyName = "PSTDSDES"
        oColumnas.HeaderText = "Origen"
        oListColum.Add(2, oColumnas)

        txtOrigen.DataSource = obrGeneral.olTipoOrigen(pobePedidoPorPlanta.PNCCLNT)
        txtOrigen.ListColumnas = oListColum
        txtOrigen.Cargas()
        txtOrigen.ValueMember = "PSCCMPRN"
        txtOrigen.DispleyMember = "PSTDSDES"

        If Not pbolClienteOutotec Then
            txtOrigen.Valor = IIf(pobePedidoPorPlanta.PSSTPORL.Trim.Equals(""), "C", pobePedidoPorPlanta.PSSTPORL)
            txtOrigen.Refresh()
            txtOrigen.Enabled = False
            UcClienteTerceroDestino.Enabled = False
            txtTipoDoc.Enabled = False
        Else
            txtOrigen.Valor = IIf(pobePedidoPorPlanta.PSSTPORL.Trim.Equals(""), "C", pobePedidoPorPlanta.PSSTPORL)
            txtOrigen.Refresh()
        End If

        ''Tipo Documento origen
        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CCMPRN"
        oColumnas.DataPropertyName = "PSCCMPRN"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TDSDES"
        oColumnas.DataPropertyName = "PSTDSDES"
        oColumnas.HeaderText = "Documento de Referencia"
        oListColum.Add(2, oColumnas)

        txtTipoDoc.DataSource = obrGeneral.olTipoDocumentoOrigen(pobePedidoPorPlanta.PNCCLNT)
        txtTipoDoc.ListColumnas = oListColum
        txtTipoDoc.Cargas()
        txtTipoDoc.ValueMember = "PSCCMPRN"
        txtTipoDoc.DispleyMember = "PSTDSDES"
        txtTipoDoc.Valor = "GR"
        txtTipoDoc.Refresh()

        UcClienteTerceroDestino.MostrarRuc = True
        UcClienteTerceroDestino.CodCliente = pobePedidoPorPlanta.PNCCLNT
        UcClienteTerceroDestino.TipoRelacion = CType(Me.txtOrigen.Resultado, beGeneral).PSCCMPRN.Trim
        Dim obePlantaDeEntrega As New PlantaDeEntrega.bePlantaDeEntrega
        With obePlantaDeEntrega
            .PNCCLNT = pobePedidoPorPlanta.PNCCLNT
            .PNCPRVCL = pobePedidoPorPlanta.PNCPRVCL
            .TIPOCLIENTE = False
            .PSSTPORL = CType(Me.txtOrigen.Resultado, beGeneral).PSCCMPRN.Trim
        End With
        UcClienteTerceroDestino.pCargar(obePlantaDeEntrega)

    End Sub

    Private Sub CargarCodigoUsado()
        CargarControles()
        ' Recuperamos los ultimos valores seleccionados
        Dim objAppConfig As cAppConfig = New cAppConfig
        If Not objAppConfig.GetValue("Despacho_TipoDespacho", GetType(System.String)).ToString.Equals("") Then
            txtTipoDesOutotec.Valor = objAppConfig.GetValue("Despacho_TipoDespacho", GetType(System.String))
            txtTipoDesOutotec.Refresh()
        End If
        objAppConfig = Nothing

    End Sub

    Private Sub InicializarVariables()
        LimpiarTransportista()
        LimpiarUnidad()
        LimpiarBrevete()
    End Sub

    Private Sub LimpiarTransportista()
        Dim lstrTransporte As New List(Of String)
        lstrTransporte.Add("")
        lstrTransporte.Add("")
        lstrTransporte.Add("")
        txtEmpresaTransporte.Tag = lstrTransporte
    End Sub

    Private Sub LimpiarUnidad()
        Dim lstrUnidad As New List(Of String)
        lstrUnidad.Add("")
        lstrUnidad.Add("")
        lstrUnidad.Add("")
        lstrUnidad.Add("")
        Me.txtUnidad.Tag = lstrUnidad
    End Sub

    Private Sub LimpiarBrevete()
        Dim lstrBrevete As New List(Of String)
        lstrBrevete.Add("")
        lstrBrevete.Add("")
        lstrBrevete.Add("")
        Me.txtBrevete.Tag = lstrBrevete
    End Sub

    Private Sub ObtenerInformacionPedidoInterfazSAP()
        Dim strCRGVTA As String = String.Empty
        Dim obrDespacho As New brDespacho
        Dim dsInformacionPedido As New DataSet
        Dim strDCENSA As String = txtNroGuiaCliente.Text
        GLOBAL_COMPANIA = "EZ"


        If Not IsNumeric(txtNroGuiaCliente.Text) Then
            MessageBox.Show("El Número Documento SAP no es válido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim objDatos As New beInferfazSapPedido

        objDatos.CCMPN = GLOBAL_COMPANIA
        objDatos.CCLNT = Me.intCCLNT
        objDatos.CRGVTA = obrDespacho.strObtenerCodigoRegionVenta(objDatos)
        objDatos.DCENSA = txtNroGuiaCliente.Text.Trim
        Dim msgError As String = String.Empty
        dsInformacionPedido = obrDespacho.fdtOntenerInformacionPedidoInterfazSAP(objDatos, msgError)


        If msgError <> String.Empty Then
            'Using frm As New frmImportarPedidoSAP
            '    frm.CCLNT = Me.intCCLNT
            '    frm.oDs = dsInformacionPedido
            '    If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            '        Me.Close()
            '    End If

            'End Using
        Else
            MessageBox.Show("El Número Documento SAP no existe", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub ListarLotes()


        If dtgListaDespachos.CurrentRow Is Nothing Then
            Exit Sub
        End If
        Dim CtrlLote As String = ""
        CtrlLote = ("" & dtgListaDespachos.CurrentRow.Cells("PSFUNCTL").Value).ToString.Trim

        If CtrlLote = "" Then
            UcLote1.LimpiarDatasourse()
        Else

            If dtgListaDespachos.Rows.Count > 0 Then
                UcLote1.OrdenServicio = Me.dtgListaDespachos.CurrentRow.Cells("PNNORDSR").Value
                UcLote1.intIndex = Me.dtgListaDespachos.CurrentRow.Cells("PNCDREGP").Value
                UcLote1.CantidadPedidoPendiente = Me.dtgListaDespachos.CurrentRow.Cells("CANTIDAD").Value
                UcLote1.ListarLotes()
            Else
                UcLote1.OrdenServicio = -1
                'UcLote1.CantidadPedidoPendiente = 0
                UcLote1.ListarLotes()
                btnOcultarLote.Text = "Mostrar"

            End If

        End If

      
    End Sub


    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
    End Sub

    Private Function ObtenerrClientes(ByVal dblCodigo As Double) As String
        Dim oCliente As New cCliente
        'Dim objAppConfig As cAppConfig = New cAppConfig
        ' Recuperamos los ultimos valores seleccionados
        Dim intTemp As Int64 = 0
        'Int64.TryParse(objAppConfig.GetValue("RecepcionOC_CodigoCliente", GetType(System.String)), intTemp)
        Dim ClientePK As TD_ClientePK = New TD_ClientePK(dblCodigo, objSeguridadBN.pUsuario)
        ClientePK.pCCMPN_CodigoCompania = GLOBAL_COMPANIA
        Try
            Return oCliente.Obtener(ClientePK, objSeguridadBN.pUsuario).pTCMPCL_DescripcionCliente
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return String.Empty


    End Function

    Private Sub CargarDatosGenerales(ByVal obePedidoPorPlanta As bePedidoPorPlanta)

        If obePedidoPorPlanta.PNCCLNT = obePedidoPorPlanta.PNCPRVCL Then
            'Me.lblCliente.Text = ObtenerrClientes(obePedidoPorPlanta.PNCCLNT)
            khgFiltros.ValuesPrimary.Heading = "Pedido: " + obePedidoPorPlanta.PNCDPEPL.ToString + " - Cliente : " + ObtenerrClientes(obePedidoPorPlanta.PNCCLNT) + " - Planta :" + obePedidoPorPlanta.PSTCMPPL
        Else
            'Me.lblTituloCliente.Text = "Cliente Tercero :"
            'Me.lblTituloPlanta.Text = "Planta Tercero :"
            'Me.lblCliente.Text = ObtenerrClientes(obePedidoPorPlanta.PNCPRVCL)
            khgFiltros.ValuesPrimary.Heading = "Pedido: " + obePedidoPorPlanta.PNCDPEPL.ToString + "  -  Cliente Tercero : " + ObtenerrClientes(obePedidoPorPlanta.PNCPRVCL) + "  -  Planta Tercero :" + obePedidoPorPlanta.PSTCMPPL
        End If
        'Me.lblPlanta.Text = obePedidoPorPlanta.PSTCMPPL
        'Me.lblPedido.Text = obePedidoPorPlanta.PNCDPEPL
        Me.lblFechaPedido.Text = obePedidoPorPlanta.PNFCHSPE
        Me.lblFechaDespacho.Text = obePedidoPorPlanta.PNFDSPAL
        Me.lblObservaciones.Text = obePedidoPorPlanta.PSTOBSMD
        Me.lblFactura.Text = obePedidoPorPlanta.PNNDCFCC
        Me.lblOrdenDeCompra.Text = obePedidoPorPlanta.PSNORCML
        Me.txtNroOrdenCompra.Text = obePedidoPorPlanta.PSNORCML
        ' btnDespacha.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False

    End Sub

    Private Sub ListaDespachoMercaderia(ByVal obePedidoPorPlanta As bePedidoPorPlanta)
        Dim obrDespacho As New brDespacho
        Dim olbePedidoPorPlanta As New List(Of bePedidoPorPlanta)
        pboolEstadoValidating = False
        Dim lista As New List(Of bePedidoPorPlanta)
        Dim ListaInterfaz As New List(Of bePedidoPorPlanta)



        lista = obrDespacho.ListaDespachoMercaderiaPorClientePorPlanta_V2(obePedidoPorPlanta)

        Dim oListPedido As New CloneObject(Of bePedidoPorPlanta)
        listaValidacion = oListPedido.CloneListObject(lista)
        'oListbeDUAATemp = oCloneList.CloneListObject(oListItemAgenciaOrigen)
        listaValidacion = lista


        'dtgListaDespachos.DataSource = obrDespacho.ListaDespachoMercaderiaPorClientePorPlanta(obePedidoPorPlanta)
        dtgListaDespachos.DataSource = lista
        pboolEstadoValidating = True
        pboolEstadoCargado = True
    End Sub


    Private Sub btnDespacha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDespacha.Click
        Try
            dtgListaDespachos.EndEdit()
            dtgStockAlmacen.EndEdit()

            Dim resultadoEnvioInterfaz As String = ""
            If fblnValidarInfDespacho() Then

                'Dim strMensaje As String = ""

                '<[AHM]>
                GLOBAL_COMPANIA = "EZ"
                'Dim mensajeLimiteCredito As String = ""
                'If (Not (New brBulto).ValidarLimiteCredito(GLOBAL_COMPANIA, intCCLNT, mensajeLimiteCredito)) Then
                '    MessageBox.Show(mensajeLimiteCredito, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    Exit Sub
                'End If
                '</[AHM]>

                'If CType(txtTipoDesOutotec.Resultado, beGeneral).PSSTPING = "I" Then
                '    Dim CliTerGri As String = String.Empty
                '    For Each oDrv As DataGridViewRow In Me.dtgListaDespachos.Rows
                '        If oDrv.Cells("CHK").Value Then
                '            Dim oListKardex As List(Of beKardex)
                '            oListKardex = CType(oDrv.Tag, List(Of beKardex))
                '            CliTerGri = oListKardex.Item(0).PSTCMZNA.ToString.Trim.Substring(0, 2)
                '            Exit For
                '        End If
                '    Next

                '    'Dim CliTerGri = dtgStockAlmacen.Item(6, 0).Value.ToString.Trim.Substring(0, 2)
                '    Dim CliTer As String = UcClienteTerceroDestino.ItemActual.PSCPRPCL.ToString.Trim '& " " & UcClienteTerceroDestino.ItemActual.PSTPRVCL.ToString.Trim
                '    If CliTerGri = "01" Or CliTerGri = "03" Or CliTerGri = "05" Or CliTerGri = "07" Or CliTerGri = "09" Or CliTerGri = "14" Then
                '        If CliTer = "01" Or CliTer = "03" Or CliTer = "05" Or CliTer = "07" Or CliTer = "09" Or CliTer = "14" Then

                '        Else
                '            MessageBox.Show("Ud. no puede hacer traslado de distintas zonas", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '            Exit Sub
                '        End If
                '    End If

                '    If CliTerGri = "02" Or CliTerGri = "04" Or CliTerGri = "06" Or CliTerGri = "08" Or CliTerGri = "10" Or CliTerGri = "13" Then
                '        If CliTer = "02" Or CliTer = "04" Or CliTer = "06" Or CliTer = "08" Or CliTer = "10" Or CliTer = "13" Then

                '        Else
                '            MessageBox.Show("Ud. no puede hacer traslado de distintas zonas", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '            Exit Sub
                '        End If
                '    End If
                'End If

                'PSCTRL_UBICACION

                Dim QDespacho As Decimal = 0
                Dim PesoDespacho As Decimal = 0
                Dim QDespachoAlmacen As Decimal = 0
                Dim PesoDespachoAlmacen As Decimal = 0
                'Dim msgValDescargaUbic As String = ""
                Dim QPendienteDescarga As Decimal = 0
                'Dim msgvalidacion As String = ""
                Dim msgvalidAlmacen As String = ""
                For Each oDrv As DataGridViewRow In Me.dtgListaDespachos.Rows
                    If oDrv.Cells("CHK").Value Then
                        QDespacho = QDespacho + oDrv.Cells("CANTIDAD").Value
                        PesoDespacho = PesoDespacho + Val("" & oDrv.Cells("PESO").Value & "")
                        For Each obeKardex As beKardex In CType(oDrv.Tag, List(Of beKardex))
                            QDespachoAlmacen = QDespachoAlmacen + obeKardex.PNQSLMC2
                            PesoDespachoAlmacen = PesoDespachoAlmacen + obeKardex.PNQSLMP2
                        Next
                    End If

                Next
                QPendienteDescarga = QDespacho - QDespachoAlmacen
                If QPendienteDescarga > 0 Then
                    msgvalidAlmacen = QPendienteDescarga & " productos pendientes de descarga - nivel Almacén"
                ElseIf QPendienteDescarga < 0 Then
                    msgvalidAlmacen = Math.Abs(QPendienteDescarga) & " productos excedidos en descarga  - nivel Almacén"
                End If

                If msgvalidAlmacen.Length > 0 Then
                    MessageBox.Show(msgvalidAlmacen, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                'If msgvalidAlmacen.Length > 0 Then
                '    msgValDescargaUbic = msgvalidacion & Chr(13)
                'End If
                'jj()

                Dim FlagCtrlUbicacion As Boolean = False
                Dim FlagCtrlSerie As Boolean = False
                Dim QTotalTrx As Decimal = 0
                Dim PesoTotTrx As Decimal = 0
                Dim QTotalDespachar As Decimal = 0
                Dim QTotalPesoDespachar As Decimal = 0
                Dim SKU As String = ""
                Dim msg As String = ""
                Dim NroItemPedido As Decimal = 0

                Dim pExisteErrorUbicacion As Boolean = False
                Dim msgAlertaUbicacion As String = ""
                Dim msgErrorUbicacion As String = ""

                Dim pExisteErrorSerie As Boolean = False
                Dim msgAlertaSerie As String = ""
                Dim msgErrorSerie As String = ""

                Dim OrdenServicio As String = ""
                Dim CodTipoAlm As String = ""
                Dim CodAlm As String = ""
                Dim CodZona As String = ""



                For FilaReg As Integer = 0 To dtgListaDespachos.Rows.Count - 1

                    If dtgListaDespachos.Rows(FilaReg).Cells("CHK").Value Then

                        QTotalDespachar = dtgListaDespachos.Rows(FilaReg).Cells("CANTIDAD").Value
                        QTotalPesoDespachar = dtgListaDespachos.Rows(FilaReg).Cells("PESO").Value
                        NroItemPedido = dtgListaDespachos.Rows(FilaReg).Cells("PNCDREGP").Value
                        SKU = ("" & dtgListaDespachos.Rows(FilaReg).Cells("PSCMRCLR").Value)
                        OrdenServicio = ("" & dtgListaDespachos.Rows(FilaReg).Cells("PNNORDSR").Value).ToString.Trim


                        If Manejo_x_Posicion_NivelCliente = "S" Then
                            FlagCtrlUbicacion = True
                        Else
                            If ("" & dtgListaDespachos.Rows(FilaReg).Cells("PSFUBICAC").Value) = "X" Then
                                FlagCtrlUbicacion = True
                            Else
                                FlagCtrlUbicacion = False
                            End If
                        End If

                        If ("" & dtgListaDespachos.Rows(FilaReg).Cells("PSSCNTSR").Value) = "X" Then
                            FlagCtrlSerie = True
                        Else
                            FlagCtrlSerie = False
                        End If


                        If dtgListaDespachos.Rows(FilaReg).Tag IsNot Nothing Then
                            For Each obeKardex As beKardex In CType(dtgListaDespachos.Rows(FilaReg).Tag, List(Of beKardex))

                                QTotalTrx = obeKardex.PNQSLMC2
                                PesoTotTrx = obeKardex.PNQSLMP2
                                CodTipoAlm = obeKardex.PSCTPALM
                                CodAlm = obeKardex.PSCALMC
                                CodZona = obeKardex.PSCZNALM

                                If QTotalTrx > 0 Then
                                    msg = UcUbicacion.Validar_X_Posicion_Despacho(pExisteErrorUbicacion, FlagCtrlUbicacion, QTotalTrx, PesoTotTrx, SKU, OrdenServicio, 0, CodTipoAlm, CodAlm, CodZona, FilaReg)
                                    If pExisteErrorUbicacion = True Then
                                        If msg <> "" Then
                                            msgErrorUbicacion = msgErrorUbicacion & msg & Chr(10)
                                        End If
                                    Else
                                        If msg <> "" Then
                                            msgAlertaUbicacion = msgAlertaUbicacion & msg & Chr(10)
                                        End If
                                    End If
                                End If


                            Next

                        End If


                        msg = ucSerie.ValidarCantidadSerieXOSDespacho(pExisteErrorSerie, FlagCtrlSerie, QTotalDespachar, OrdenServicio, SKU, NroItemPedido, FilaReg)
                        If pExisteErrorSerie = True Then
                            If msg <> "" Then
                                msgErrorSerie = msgErrorSerie & msg & Chr(10)
                            End If
                        Else
                            If msg <> "" Then
                                msgAlertaSerie = msgAlertaSerie & msg & Chr(10)
                            End If
                        End If

                    End If

                Next

                msgErrorUbicacion = msgErrorUbicacion.Trim
                msgAlertaUbicacion = msgAlertaUbicacion.Trim
                msgErrorSerie = msgErrorSerie.Trim
                msgAlertaSerie = msgAlertaSerie.Trim


                If msgErrorUbicacion.Length > 0 Then
                    MessageBox.Show(msgErrorUbicacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                If msgAlertaUbicacion.Length > 0 And Mensaje_AlertaDiferencia_x_ManejoPosiciones = "S" Then
                    If MessageBox.Show(msgAlertaUbicacion & Chr(13) & " ¿Desea continuar?", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If

                If msgErrorSerie.Length > 0 Then
                    MessageBox.Show(msgErrorSerie, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                Dim mensajeLimiteCredito As String = ""
                'If (Not (New brBulto).ValidarLimiteCredito(GLOBAL_COMPANIA, intCCLNT, mensajeLimiteCredito)) Then
                '    MessageBox.Show(mensajeLimiteCredito, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    Exit Sub
                'End If

                'msgValDescargaUbic = msgValDescargaUbic & UcUbicacion.ValidarUbicacionDescarga(Ransa.Controls.ucUbicaciones_Dg.TipoProceso.DESPACHO, QDespacho, PesoDespachoAlmacen)
                'msgValDescargaUbic = Trim(msgValDescargaUbic)


                'If Manejo_x_Posicion = "S" Then
                '    If Mensaje_posicion_obligatoriedad = "S" Then
                '        If msgValDescargaUbic.Length > 0 Then
                '            MessageBox.Show(msgValDescargaUbic, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                '            Exit Sub
                '        End If
                '    Else
                '        If msgValDescargaUbic.Length > 0 Then
                '            If MessageBox.Show(msgValDescargaUbic & Chr(13) & " ¿Desea continuar?", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                '                Exit Sub
                '            End If
                '        End If
                '    End If
                'End If

                '
                ' Obtenemos la información de la cabecera registrada
                'objMovimientoMercaderia = New slnSOLMIN_SDS.clsMovimientoMercaderia
                objMovimientoMercaderia = New clsMovimientoMercaderia
                objMovimientoMercaderia.pintAnioUnidad_NANOCM = Val(Me.txtUnidad.Tag(1))
                objMovimientoMercaderia.pintCodigoCliente_CCLNT = pobePedidoPorPlanta.PNCCLNT
                objMovimientoMercaderia.pintEmpresaTransporte_CTRSP = Me.txtEmpresaTransporte.Tag(1)
                objMovimientoMercaderia.pintNroDocIdentidadChofer_NLELCH = Val(Me.txtBrevete.Tag(2))
                objMovimientoMercaderia.pintNroRUCEmpTransporte_NRUCT = Me.txtEmpresaTransporte.Tag(2)
                objMovimientoMercaderia.pintServicio_CSRVC = 2
                objMovimientoMercaderia.pstrChofer_TNMBCH = Me.txtBrevete.Tag(1) 'Descripcion
                objMovimientoMercaderia.pstrCompania_CCMPN = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
                objMovimientoMercaderia.pstrDivision_CDVSN = "R"
                objMovimientoMercaderia.pstrMarcaUnidad_TMRCCM = Me.txtUnidad.Tag(2)
                objMovimientoMercaderia.pstrNroBrevete_NBRVCH = Me.txtBrevete.Tag(0)
                objMovimientoMercaderia.pstrNroPlacaCamion_NPLCCM = Me.txtUnidad.Tag(0)
                objMovimientoMercaderia.pstrObservaciones_TOBSER = ""
                objMovimientoMercaderia.pstrRazonSocialCliente_TCMPCL = ObtenerrClientes(pobePedidoPorPlanta.PNCCLNT)
                objMovimientoMercaderia.pstrRazonSocialEmpTransporte_TCMPTR = Me.txtEmpresaTransporte.Tag(0)
                objMovimientoMercaderia.pstrFechaRealizacion_FRLZSR = dteFechaDespacho.Value.Date
                objMovimientoMercaderia.pintFechaRealizacion_FRLZSR = HelpClass.CDate_a_Numero8Digitos(dteFechaDespacho.Value.Date)
                'Enviamos Número de pedido
                objMovimientoMercaderia.pintCodigoPedido_CDPEPL = pobePedidoPorPlanta.PNCDPEPL
                ' Recuperamos la información ingresada en el datatable a la Lista de Clases

                Dim intCorrelativo As Integer = 0
                For Each oDrv As DataGridViewRow In Me.dtgListaDespachos.Rows
                    If oDrv.Cells("CHK").Value Then
                        intCorrelativo = 0
                        For Each obeKardex As beKardex In CType(oDrv.Tag, List(Of beKardex))
                            'Dim objTemp As slnSOLMIN_SDS.clsItemMovimientoMercaderia = New slnSOLMIN_SDS.clsItemMovimientoMercaderia
                            Dim objTemp As clsItemMovimientoMercaderia = New clsItemMovimientoMercaderia
                            With objTemp
                                .intCorrelativo = intCorrelativo
                                .PNQTRMC = obeKardex.PNQSLMC2
                                .PNQTRMP = obeKardex.PNQSLMP2
                                .CodPedidoPlanta_CDPEPL = pobePedidoPorPlanta.PNCDPEPL
                                .NrItemPedidoPLanta_CDREGP = oDrv.Cells("PNCDREGP").Value
                                .pintOrdenServicio_NORDSR = oDrv.Cells("PNNORDSR").Value
                                .pintNroContrato_NCNTR = oDrv.Cells("PNNCNTR").Value
                                .pintNroCorrDetalleContrato_NCRCTC = oDrv.Cells("PNNCRCTC").Value
                                .pintNroAutorizacion_NAUTR = oDrv.Cells("PNNAUTR").Value
                                .pstrCodigoMercaderia_CMRCLR = ("" & oDrv.Cells("PSCMRCLR").Value).ToString.Trim
                                .pstrCodigoRANSA_CMRCD = oDrv.Cells("PSCMRCD").Value

                                .pstrNroOrdenCompraCliente_NORCCL = oDrv.Cells("NORCML").Value
                                .pintNroItemOC_NRITOC = oDrv.Cells("NRITOC").Value

                                .pstrNroGuiaCliente_NGUICL = Me.txtNroGuiaCliente.Text
                                If Not UcClienteTerceroDestino.ItemActual Is Nothing Then
                                    .pstrNroRUCCliente_NRUCLL = CType(UcClienteTerceroDestino.ItemActual, PlantaDeEntrega.bePlantaDeEntrega).PNNRUCPR.ToString
                                    .pstrCodigoProveedor_CPRVCL = CType(UcClienteTerceroDestino.ItemActual, PlantaDeEntrega.bePlantaDeEntrega).PNCPRVCL.ToString
                                    .pstrCodProvCliente_CPRPCL = ("" & CType(UcClienteTerceroDestino.ItemActual, PlantaDeEntrega.bePlantaDeEntrega).PSCPRPCL & "").Trim
                                Else
                                    .pstrNroRUCCliente_NRUCLL = ""
                                End If

                                .pstrTipoAlmacen_CTPALM = obeKardex.PSCTPALM 'oDrv.Cells("PSCTPALM").Value
                                .pstrTipoAlmacenDesc_TALMC = obeKardex.PSTALMC
                                .pstrAlmacen_CALMC = obeKardex.PSCALMC 'oDrv.Cells("PSCALMC").Value
                                .pstrZonaAlmacen_CZNALM = obeKardex.PSCZNALM  'oDrv.Cells("PSCZNALM").Value
                                .pstrZonaAlmacen_TCMZNA = obeKardex.PSTCMZNA

                                .pstrAlmacen_TCMPAL = obeKardex.PSTCMPAL

                                .pdecCantidad_QTRMC = oDrv.Cells("CANTIDAD").Value
                                .pdecPeso_QTRMP = Val("" & oDrv.Cells("PESO").Value & "")
                                .pstrUnidadCantidad_CUNCNT = oDrv.Cells("PSCUNCN5").Value
                                .pstrUnidadPeso_CUNPST = oDrv.Cells("PSCUNPS5").Value
                                .pstrUnidadValorTransaccion_CUNVLT = oDrv.Cells("PSCUNVL5").Value

                                .pstrTipoMovimiento_STPING = CType(txtTipoDesOutotec.Resultado, beGeneral).PSSTPING
                                .pintNroDiasVigencia_QDSVGN = CType(txtVigencia.Text, Integer)

                                .pstrSatusUnidadDespacho_FUNDS2 = oDrv.Cells("PSFUNDS2").Value
                                .pstrTipoDeposito_CTPDPS = oDrv.Cells("PSCTPDP6").Value
                                .pstrObservaciones_TOBSRV = txtRecObservacion.Text
                                If pbolClienteOutotec Then
                                    .pstrTipoMovIntfz = strTipoMovIntfz.Trim
                                End If
                                .pbolEsOutotec = pbolClienteOutotec
                                .pstrNrRefPedido_NRFRPD = pobePedidoPorPlanta.PSNRFRPD()
                                .PSTIPORG = CType(Me.txtOrigen.Resultado, beGeneral).PSCCMPRN
                                .PSTIPORI = CType(Me.txtTipoDoc.Resultado, beGeneral).PSCCMPRN
                                .PSNLTECL = "" & oDrv.Cells("PSNLTECL").Value & ""
                            End With

                            objMovimientoMercaderia.AddItemMovimientoMercaderia(objTemp)
                            intCorrelativo += 1
                        Next
                    Else
                        ucSerie.EliminarSeries(oDrv.Cells("PNNORDSR").Value, oDrv.Cells("PNCDREGP").Value)
                        UcUbicacion.EliminarUbicaciones(oDrv.Cells("PNNORDSR").Value, oDrv.Cells("PNCDREGP").Value)
                    End If
                Next

                ' Procedemos con el procesamiento de la información
                Dim strNroGuiaRansa As String = "0"
                Dim intNroGuiaRansa As Int64 = 0

                If pbolClienteOutotec Then
                    Dim IntNroGuiaRansa_Q As Int64 = 0
                    'Dim olbeMov01 As New slnSOLMIN_SDS.clsMovimientoMercaderia
                    'Dim olbeMov02 As New slnSOLMIN_SDS.clsMovimientoMercaderia

                    'Dim olbeDetMov As New List(Of slnSOLMIN_SDS.clsItemMovimientoMercaderia)
                    'Dim oCloneList As New CloneObject(Of slnSOLMIN_SDS.clsMovimientoMercaderia)
                    'Dim oCloneList2 As New CloneObject(Of slnSOLMIN_SDS.clsItemMovimientoMercaderia)

                    'Dim olbeMovDet01 As New List(Of slnSOLMIN_SDS.clsItemMovimientoMercaderia)
                    'Dim olbeMovDet02 As New List(Of slnSOLMIN_SDS.clsItemMovimientoMercaderia)

                    Dim olbeMov01 As New clsMovimientoMercaderia
                    Dim olbeMov02 As New clsMovimientoMercaderia

                    Dim olbeDetMov As New List(Of clsItemMovimientoMercaderia)
                    Dim oCloneList As New CloneObject(Of clsMovimientoMercaderia)
                    Dim oCloneList2 As New CloneObject(Of clsItemMovimientoMercaderia)

                    Dim olbeMovDet01 As New List(Of clsItemMovimientoMercaderia)
                    Dim olbeMovDet02 As New List(Of clsItemMovimientoMercaderia)

                    olbeMov01 = oCloneList.CloneObject(objMovimientoMercaderia)
                    olbeMov02 = oCloneList.CloneObject(objMovimientoMercaderia)

                    olbeDetMov = oCloneList2.CloneListObject(objMovimientoMercaderia.plstItemMovimientoMercaderia)

                    For Each obeItem As clsItemMovimientoMercaderia In olbeDetMov
                        'For Each obeItem As slnSOLMIN_SDS.clsItemMovimientoMercaderia In olbeDetMov
                        If obeItem.pstrZonaAlmacen_TCMZNA.Trim.Substring(0, 2) = "01" Then
                            olbeMovDet01.Add(obeItem)
                        Else
                            olbeMovDet02.Add(obeItem)
                        End If
                    Next

                    intNroGuiaRansa = 0
                    If olbeMovDet01.Count > 0 Then
                        olbeMov01.plstItemMovimientoMercaderia.Clear()
                        For Each obeItem As clsItemMovimientoMercaderia In olbeMovDet01
                            'For Each obeItem As slnSOLMIN_SDS.clsItemMovimientoMercaderia In olbeMovDet01
                            obeItem.intCorrelativo = 0
                            obeItem.pdecCantidad_QTRMC = obeItem.PNQTRMC
                            obeItem.pdecPeso_QTRMP = obeItem.PNQTRMP
                            olbeMov01.AddItemMovimientoMercaderia(obeItem)
                        Next

                        Call pProcesarDespacho(resultadoEnvioInterfaz, chkRegistrarServicio.Checked, intNroGuiaRansa, olbeMov01)
                        strNroGuiaRansa = intNroGuiaRansa.ToString

                        '----------------------*Traslado entre Almacenes*-------------------------------------
                        If CType(txtTipoDesOutotec.Resultado, beGeneral).PSSTPING = "I" Then
                            GenerarOrdenCompra(intNroGuiaRansa)
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                        End If
                        IntNroGuiaRansa_Q = intNroGuiaRansa

                    End If
                    intNroGuiaRansa = 0
                    If olbeMovDet02.Count > 0 Then
                        olbeMov02.plstItemMovimientoMercaderia.Clear()
                        For Each obeItem As clsItemMovimientoMercaderia In olbeMovDet02
                            'For Each obeItem As slnSOLMIN_SDS.clsItemMovimientoMercaderia In olbeMovDet02
                            obeItem.intCorrelativo = 0
                            obeItem.pdecCantidad_QTRMC = obeItem.PNQTRMC
                            obeItem.pdecPeso_QTRMP = obeItem.PNQTRMP
                            olbeMov02.AddItemMovimientoMercaderia(obeItem)
                        Next
                        Call pProcesarDespacho(resultadoEnvioInterfaz, chkRegistrarServicio.Checked, intNroGuiaRansa, olbeMov02)
                        strNroGuiaRansa = IIf(strNroGuiaRansa.Trim.Length > 1, strNroGuiaRansa & "," & intNroGuiaRansa.ToString, intNroGuiaRansa.ToString)
                        '----------------------*Traslado entre Almacenes*-------------------------------------
                        If CType(txtTipoDesOutotec.Resultado, beGeneral).PSSTPING = "I" Then
                            GenerarOrdenCompra(intNroGuiaRansa)
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                        End If
                        IntNroGuiaRansa_Q = intNroGuiaRansa
                    End If

                    '----------------------- CASO: CAMBIO DE CODIGO --------------------------------------
                    If CType(txtTipoDesOutotec.Resultado, beGeneral).PSSTPING = "Q" Then
                        GenerarOrdenCompra_Q(IntNroGuiaRansa_Q)
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If

                    If Not (CType(txtTipoDesOutotec.Resultado, beGeneral).PSSTPING = "Q" OrElse CType(txtTipoDesOutotec.Resultado, beGeneral).PSSTPING = "I") Then

                        If MessageBox.Show("Desea generar Guía Remisión", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                            Dim fGenerarGRemision As frmGenerarGuiaRemisionSDS = New frmGenerarGuiaRemisionSDS
                            With fGenerarGRemision
                                .pintCantidaLineas = pintCantidaLineas
                                .PNCCLNT = pobePedidoPorPlanta.PNCCLNT
                                If Not UcClienteTerceroDestino.ItemActual Is Nothing Then
                                    .pintCodigoClienteTercero_CPRVCL = CType(UcClienteTerceroDestino.ItemActual, PlantaDeEntrega.bePlantaDeEntrega).PNCPRVCL
                                Else
                                    .pintCodigoClienteTercero_CPRVCL = pobePedidoPorPlanta.PNCPRVCL
                                End If
                                .pintCodPlanta_CPLCLP = pobePedidoPorPlanta.PNCPLCLP
                                .pNroGuia_NRGUIA = strNroGuiaRansa
                                ' Información relacionada a la Empresa de Transporte
                                .pstrEmpresaTransporte_CTRSPT = Me.txtEmpresaTransporte.Tag(1)
                                .pstrEmpresaTransporte_Descripcion = Me.txtEmpresaTransporte.Tag(0)
                                .pstrPlacaUnidad_NPLCUN = Me.txtUnidad.Tag(0)
                                .pstrBrevete_CBRCNT = Me.txtBrevete.Tag(0)
                                .pstrOrderType = pobePedidoPorPlanta.PSNRFTPD
                                .pstrOrderNumber = pobePedidoPorPlanta.PSNRFRPD
                                .pintCodigoPedido_CDPEPL = pobePedidoPorPlanta.PNCDPEPL
                                .pintFactura_NDCFCC = pobePedidoPorPlanta.PNNDCFCC
                                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                                End If
                            End With

                        End If

                    End If

                    GuardarControlesUsados()
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else

                    Call pProcesarDespacho(resultadoEnvioInterfaz, chkRegistrarServicio.Checked, intNroGuiaRansa, objMovimientoMercaderia)

                    If CType(txtTipoDesOutotec.Resultado, beGeneral).PSSTPING = "I" Then
                        GenerarOrdenCompra(intNroGuiaRansa)
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    ElseIf CType(txtTipoDesOutotec.Resultado, beGeneral).PSSTPING = "Q" Then
                        GenerarOrdenCompra_Q(intNroGuiaRansa)
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    Else
                        If MessageBox.Show("Desea generar Guía Remisión", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                            Dim fGenerarGRemision As frmGenerarGuiaRemisionSDS = New frmGenerarGuiaRemisionSDS
                            With fGenerarGRemision
                                .PNCCLNT = pobePedidoPorPlanta.PNCCLNT
                                .pintCantidaLineas = pintCantidaLineas
                                If Not UcClienteTerceroDestino.ItemActual Is Nothing Then
                                    .pintCodigoClienteTercero_CPRVCL = CType(UcClienteTerceroDestino.ItemActual, PlantaDeEntrega.bePlantaDeEntrega).PNCPRVCL
                                Else
                                    .pintCodigoClienteTercero_CPRVCL = pobePedidoPorPlanta.PNCPRVCL
                                End If
                                .pintCodPlanta_CPLCLP = pobePedidoPorPlanta.PNCPLCLP
                                .pNroGuia_NRGUIA = intNroGuiaRansa
                                ' Información relacionada a la Empresa de Transporte
                                .pstrEmpresaTransporte_CTRSPT = Me.txtEmpresaTransporte.Tag(1)
                                .pstrEmpresaTransporte_Descripcion = Me.txtEmpresaTransporte.Tag(0)
                                .pstrPlacaUnidad_NPLCUN = Me.txtUnidad.Tag(0)
                                .pstrBrevete_CBRCNT = Me.txtBrevete.Tag(0)
                                .pstrOrderType = pobePedidoPorPlanta.PSNRFTPD
                                .pstrOrderNumber = pobePedidoPorPlanta.PSNRFRPD
                                .pintCodigoPedido_CDPEPL = pobePedidoPorPlanta.PNCDPEPL
                                .pintFactura_NDCFCC = pobePedidoPorPlanta.PNNDCFCC
                                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                                End If
                            End With

                        End If

                        GuardarControlesUsados()
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If

                End If


            End If

            If resultadoEnvioInterfaz.Trim.Length > 0 Then
                MessageBox.Show(resultadoEnvioInterfaz, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub GenerarOrdenCompra(ByVal intNroGuiaRansa As Int64)
        Dim intNroGuiaRansa1 As Int64 = intNroGuiaRansa
        Dim obeOrdenCompra As beOrdenCompra = New beOrdenCompra
        Dim objListOC As New List(Of beOrdenCompra)
        Dim objBrProveedor As brProveedor = New brProveedor
        Dim objBrOC As brOrdenDeCompra = New brOrdenDeCompra
        Dim TD_Item As OrdenCompra.ItemOC.TD_ItemOC = New OrdenCompra.ItemOC.TD_ItemOC
        Dim CodProv As Decimal = 0
        Dim DesItem As String = ""

        obeOrdenCompra.PNCCLNT = pobePedidoPorPlanta.PNCCLNT
        obeOrdenCompra.PNGUIRN = intNroGuiaRansa1
        'Listar Item de Guia Ransa
        objListOC = objBrOC.ListarOrdenDeCompraItems(obeOrdenCompra)

        'Si es mayor a Cero inserta OC e Items
        If objListOC IsNot Nothing AndAlso objListOC.Count > 0 Then
            With obeOrdenCompra
                .PNCCLNT = txtCliente.pCodigo
                .PSNORCML = "GS-" & Convert.ToString(intNroGuiaRansa1)
                .PSTPOOCM = ""
                .FechaOrdenDeCompra = Convert.ToString(dteFechaDespacho.Value.Date)
                .FechaSolicitud = Convert.ToString(dteFechaDespacho.Value.Date)
                .PNCPRVCL = objListOC.Item(0).CODPROV 'CodProv
                .PSTDSCML = objListOC.Item(0).PSTMRCD2.ToString 'DesItem
                .PSTCMAEM = ""
                .PSTTINTC = "LOC"
                .PSNREFCL = ""
                .PSTPAGME = ""
                .PSREFDO1 = ""
                .PNNTPDES = 1
                .PNCMNDA1 = 100
                .PSTEMPFAC = ""
                .PSTNOMCOM = ""
                .PSTCTCST = ""
                .PSCREGEMB = ""
                .PNCMEDTR = 4
                .PSTDEFIN = ""
                .PSTCNDPG = ""
                .PNIVCOTO = 0
                .PNIVTOCO = 0
                .PNIVTOIM = 0
                .PSTDAITM = objSeguridadBN.pUsuario
                .PSCUSCRT = objSeguridadBN.pUsuario
                .PSCULUSA = objSeguridadBN.pUsuario
                .PSTPOOCM = ""
            End With
            Dim obrOrdenDeCompra As New brOrdenDeCompra
            Dim rpta As Integer = obrOrdenDeCompra.InsertarOrdenDeCompra(obeOrdenCompra)

            If rpta = 1 Then
                For Each obOC As beOrdenCompra In objListOC
                    With TD_Item
                        .pCCLNT_CodigoCliente = txtCliente.pCodigo
                        .pNORCML_NroOrdenCompra = "GS-" & Convert.ToString(intNroGuiaRansa1)
                        .pNRITOC_NroItemOC = obOC.NROITEM
                        .pTCITCL_CodigoCliente = obOC.PSCMRCLR.Trim
                        '.pTCITPR_CodigoProveedor = obOC.CODPROV 'txtNroItemOCProveedor.Text.Trim
                        .pTDITES_DescripcionES = obOC.PSTMRCD2 & obOC.PSTMRCD3
                        .pTDITIN_DescripcionIN = obOC.PSTMRCD2.Trim
                        .pQCNTIT_Cantidad = obOC.PNQTRMC
                        .pTUNDIT_Unidad = obOC.PSCUNCN5
                        .pIVUNIT_ImporteUnitario = 0
                        .pIVTOIT_ImporteTotal = 0
                        .pQTOLMAX_ToleranciaMax = 0
                        .pQTOLMIN_ToleranciaMin = 0
                        .pFMPDME_FechaEstEntregaDte = dteFechaDespacho.Value.Date
                        .pFMPIME_FechaReqPlantaDte = dteFechaDespacho.Value.Date
                        .pTLUGOR_LugarOrigen = ""
                        .pTLUGEN_LugarEntrega = ""
                        .pTCTCST_CentroDeCosto = ""
                        .pTRFRN_RefSolicitante = ""
                        .pFLGPEN_FlagSeguimiento = ""
                    End With
                    Dim objSqlManager As Db2Manager.RansaData.iSeries.DataObjects.SqlManager = New Db2Manager.RansaData.iSeries.DataObjects.SqlManager
                    Dim strUsuario As String = objSeguridadBN.pUsuario
                    Dim strMensajeError As String = ""
                    Dim brpta As Boolean = cItemOrdenCompra.Grabar(objSqlManager, TD_Item, strUsuario, strMensajeError)

                    If brpta = False Then
                        MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Next

            Else
                MessageBox.Show("No se registró la OC", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

        'Verificar si existe Codigo de Mercaderia
        Dim obrMercaderia As brMercaderia = New brMercaderia
        Dim obeMercaderia As beMercaderia = New beMercaderia

        For Each obOCItem As beOrdenCompra In objListOC
            obeMercaderia.PNCCLNT = txtCliente.pCodigo
            obeMercaderia.PSCMRCLR = obOCItem.PSCMRCLR.Trim
            Dim oListMercaderia As New List(Of beMercaderia)
            oListMercaderia = obrMercaderia.ListaMercaderiaPorClienteItem(obeMercaderia)
            'Si no existe inserta mercaderia
            If oListMercaderia.Count = 0 Then
                Dim DtFamilia As New DataTable
                Dim DtGrupo As New DataTable
                DtFamilia = slnSOLMIN_SDS.clsGeneral_SDS.fdtBuscar_Familia("", txtCliente.pCodigo, "")
                DtGrupo = slnSOLMIN_SDS.clsGeneral_SDS.fdtBuscar_Grupo("", txtCliente.pCodigo, DtFamilia.Rows(0).Item("FAMILIA").ToString.Trim, "")
                Dim oclsMercaderia As New slnSOLMIN_SDS.MantenimientoSDS.clsMercaderia
                With oclsMercaderia
                    .pintCodigoCliente_CCLNT = txtCliente.pCodigo
                    .pstrCodigoFamilia_CFMCLR = DtFamilia.Rows(0).Item("FAMILIA").ToString.Trim
                    .pstrCodigoGrupo_CGRCLR = DtGrupo.Rows(0).Item("GRUPO").ToString.Trim
                    .pstrCodigoMercaderia_CMRCLR = obOCItem.PSCMRCLR.ToString.Trim
                    .pstrCodigoMercaderiaReemplazo_CMRCRR = ""
                    .pstrCodigoRANSA_CMRCD = "1501390000"
                    .pstrDescripcion_TMRCD2 = obOCItem.PSTMRCD2
                    .pstrDescripcion_TMRCD3 = obOCItem.PSTMRCD3
                    .pintProveedor_CPRVCL = 7988
                    .pintCodigoMoneda_CMNCT = 100
                    Decimal.TryParse(0.0, .pdecImporteCosto_QIMCT)
                    Decimal.TryParse(0.0, .pdecImporteCostoPromedio_QIMCTP)
                    Decimal.TryParse(0.0, .pdecImporteCostoPromedioSoles_QICOPS)
                    .pblnMarcaReembolso_MARCRE = False
                    Decimal.TryParse("0.000", .pdecImporteVentaDolar_IMVTAD)
                    Decimal.TryParse("0.000", .pdecImporteVentaDolar_IMVTAS)
                    Decimal.TryParse("0.000", .pdecImportePorMts2_IMVLM2)
                    Decimal.TryParse("0.00", .pdecPorcentajeDescuento_PDSCTO)
                    .pstrMarcaModelo_TMRCTR = ""
                    .pstrUbicacion_UBICA1 = ""
                    .pstrObservacion_TOBSRV = ""
                    Decimal.TryParse("0.000", .pdecCantidadMinimaReqServicio_QMRSRC)
                    Decimal.TryParse("0.000", .pdecPesoMinimoReqServicio_QMRSRP)
                    Decimal.TryParse("0.000", .pdecCantidadMercaderiaPtoReorden_QMRODC)
                    Decimal.TryParse("0.000", .pdecPesoMercaderiaPtoReorden_QMRODP)
                    Decimal.TryParse("0.000", .pdecLargoMercaderia_QLRGMR)
                    Decimal.TryParse("0.000", .pdecAnchoMercaderia_QANCMR)
                    Decimal.TryParse("0.000", .pdecAlturaMercaderia_QALTMR)
                    Decimal.TryParse("0.000", .pdecAreaMts2_QARMT2)
                    Decimal.TryParse("0.000", .pdecVolumenMts3_QARMT3)
                    Decimal.TryParse("0.000", .pdecVolumenEquivalente_QVOLEQ)
                    Decimal.TryParse("0.000", .pdecCantidadPesoDeclarado_QPSODC)
                    Decimal.TryParse("0.000", .pdecTiempoCargaMercaderia_QTMPCR)
                    Decimal.TryParse("0.000", .pdecTiempoDesargaMercaderia_QTMPDS)
                    .pblnStatusPublicacionWEB_FPUWEB = False
                    .pstrUnidad_CUNCNC = ""
                    .pstrUnidadInventario_CUNCNI = "N"
                    Date.TryParse("0", .pdteFechaVencimiento_FVNCMR)
                    Date.TryParse("0", .pdteFechaInventario_FINVRN)
                    .pstrCodigoPerfumancia_CPRFMR = ""
                    .pstrCodigoInflamabilidad_CINFMR = ""
                    .pstrCodigoRotacion_CROTMR = ""
                    .pstrCodigoApilabilidad_CAPIMR = ""
                    .pstrCodigoDUN14 = ""
                    .pstrCodigoEAN13 = ""
                    Decimal.TryParse("", .pdecCantidadMinimaProducir_QMRPRD)
                    .CPTDAR_PartidaArancelaria = ""
                    .SCNTSR_MarcaControlSerie = IIf(False, "X", "")
                End With

                mfblnGuardar_Mercaderia(oclsMercaderia)
                oclsMercaderia = Nothing
            End If

            'Verificar si existe OS
            Dim blnResultado As Boolean = True
            Dim DtServicio As DataTable = mfdtListar_OrdenesServicioPorMercaderia(txtCliente.pCodigo, obOCItem.PSCMRCLR.Trim)
            If DtServicio.Rows.Count = 0 Then
                'Si no existe OS, verifica si existe Contrato Vigente. Si existe crea OS
                Dim dtTemp As DataTable = mfdtListar_ContratosVigentes(txtCliente.pCodigo, objSeguridadBN.pstrTipoAlmacen)
                If dtTemp.Rows.Count <= 0 Then
                    Call mpMsjeVarios(enumMsjVarios.DATA_NoExisteInformacion)
                Else
                    'Dim objNuevaOrdenServicio As slnSOLMIN_SDS.clsCrearOrdenServicio = New slnSOLMIN_SDS.clsCrearOrdenServicio
                    Dim objNuevaOrdenServicio As clsCrearOrdenServicio = New clsCrearOrdenServicio
                    With objNuevaOrdenServicio
                        .pintCodigoCliente_CCLNT = txtCliente.pCodigo
                        .pstrCodigoMercaderia_CMRCLR = obOCItem.PSCMRCLR.Trim
                        .pintNroContrato_NCNTR = Convert.ToInt64(dtTemp.Rows(0).Item("NCNTR").ToString.Trim)
                        .pstrTipoDeposito_CTPDP3 = dtTemp.Rows(0).Item("CTPDP3").ToString.Trim
                        .pstrProducto_CTPPR1 = dtTemp.Rows(0).Item("CTPPR1").ToString.Trim
                        .pdecCantidadDeclarada_QMRCD = 1
                        .pstrUnidadCantidad_CUNCND = obOCItem.PSCUNCN5.Trim
                        .pdecPesoDeclarado_QPSMR = 1
                        .pstrUnidadPeso_CUNPS0 = "KGS"
                        .pdecValorDeclarado_QVLMR = 1
                        .pstrUnidadValor_CUNVLR = "DOL"
                        .pstrControlLotes_FUNCTL = "N"
                        .pstrUnidadDespacho_FUNDS = "C"
                    End With
                    blnResultado = mfblnCrearOrdenServicio(objNuevaOrdenServicio)
                    objNuevaOrdenServicio = Nothing
                    If blnResultado = False Then
                        MessageBox.Show("No se registró la Orden de Servicio", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If
        Next

        Dim objSqlManager2 As Db2Manager.RansaData.iSeries.DataObjects.SqlManager = New Db2Manager.RansaData.iSeries.DataObjects.SqlManager
        Dim strMensajeError2 As String = ""
        Dim TD_OrdenCompraActual As OrdenCompra.OrdenCompra.TD_OrdenCompraPK = New Ransa.TypeDef.OrdenCompra.OrdenCompra.TD_OrdenCompraPK
        TD_OrdenCompraActual.pCCLNT_CodigoCliente = txtCliente.pCodigo
        TD_OrdenCompraActual.pNORCML_NroOrdenCompra = "GS-" & Convert.ToString(intNroGuiaRansa1)
        TD_OrdenCompraActual.PAGESIZE = 1000
        TD_OrdenCompraActual.PAGENUMBER = 1


        Dim dtItemOC As New DataTable
        dtItemOC = cItemOrdenCompra.fdtListar_ItemsOC_L01(objSqlManager2, TD_OrdenCompraActual, strMensajeError2)

        'Procesar SolicInfoRecOCAlmacen
        'Dim objMovimientoMercaderia As New slnSOLMIN_SDS.clsMovimientoMercaderia
        Dim objMovimientoMercaderia As New clsMovimientoMercaderia
        With objMovimientoMercaderia
            .pintCodigoCliente_CCLNT = txtCliente.pCodigo
            .pstrRazonSocialCliente_TCMPCL = txtCliente.pRazonSocial
            .pintServicio_CSRVC = 1
            .pintEmpresaTransporte_CTRSP = 999999
            .pstrRazonSocialEmpTransporte_TCMPTR = "VARIOS"
            .pintNroRUCEmpTransporte_NRUCT = 1
            .pstrNroPlacaCamion_NPLCCM = ""
            .pstrMarcaUnidad_TMRCCM = ""
            .pintAnioUnidad_NANOCM = 0
            .pstrNroBrevete_NBRVCH = ""
            .pstrChofer_TNMBCH = ""
            .pintNroDocIdentidadChofer_NLELCH = 0
            .pstrObservaciones_TOBSER = "Transf. entre Alm."
            .pstrCompania_CCMPN = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
            .pstrDivision_CDVSN = "R"
            .pstrTipoOrigen_TIPORG = "A"
            .pstrTipoDocumentoOrigen_TIPORI = "PS"  'GR
            .pstrObservaciones_TOBSRV = "Transf. entre Alm."
            .pstrCodigoProveedor_CPRVCL = objListOC.Item(0).CODPROV.ToString.Trim
            .pstrCodigoProveedor_cliente_CPRPCL = objListOC.Item(0).CODPROVOUT.ToString.Trim
            .pstrFechaRealizacion_FRLZSR = dteFechaDespacho.Value.Date

        End With

        Dim intCont As Int32 = 0
        intCont = 0
        Dim objTemp As New OrdenCompra.ItemOC.TD_ItemOCForWayBill
        objTemp = Nothing

        Dim lstItemsSelec As List(Of OrdenCompra.ItemOC.TD_ItemOCForWayBill) = New List(Of OrdenCompra.ItemOC.TD_ItemOCForWayBill)
        While intCont < dtItemOC.Rows.Count
            objTemp = New OrdenCompra.ItemOC.TD_ItemOCForWayBill
            objTemp.pNRITOC_NroItemOC = dtItemOC.Rows(intCont).Item("NRITOC")
            objTemp.pTCITCL_CodigoCliente = dtItemOC.Rows(intCont).Item("TCITCL").ToString.Trim
            objTemp.pQCNREC_QtaRecibida = dtItemOC.Rows(intCont).Item("QCNPEN")
            objTemp.pTUNDIT_UnidadQta = dtItemOC.Rows(intCont).Item("TUNDIT").ToString.Trim
            objTemp.pTDAITM_Observaciones = ""
            objTemp.pQPEPQT_QtaPeso = 0
            objTemp.pTUNPSO_UnidadPeso = ""
            objTemp.pCMRCD_CodigoRANSA = dtItemOC.Rows(intCont).Item("CMRCD").ToString
            objTemp.pTMRCD2_MercaDescripcion = dtItemOC.Rows(intCont).Item("TMRCD2").ToString.Trim
            objTemp.pNORDSR_OrdenServicio = dtItemOC.Rows(intCont).Item("NORDSR")
            objTemp.pNCNTR_NroContrato = dtItemOC.Rows(intCont).Item("NCNTR")
            objTemp.pNCRCTC_NroCorrelativoContrato = dtItemOC.Rows(intCont).Item("NCRCTC")
            objTemp.pNAUTR_NroAutorizacionContrato = dtItemOC.Rows(intCont).Item("NAUTR")
            objTemp.pCTPDPS_TipoDeposito = dtItemOC.Rows(intCont).Item("CTPDPS").ToString.Trim
            objTemp.pFUNDS2_Status = dtItemOC.Rows(intCont).Item("FUNDS2").ToString.Trim
            objTemp.pCUNCN5_UnidadCantidad = dtItemOC.Rows(intCont).Item("CUNCN5")
            objTemp.pCUNPS5_UnidadPeso = dtItemOC.Rows(intCont).Item("CUNPS5").ToString.Trim
            objTemp.pCUNVL5_UnidadValor = dtItemOC.Rows(intCont).Item("CUNVL5").ToString.Trim
            objTemp.pFMPDME_FechaMaxDespacho = dtItemOC.Rows(intCont).Item("FMPDME").ToString.Trim
            lstItemsSelec.Add(objTemp)
            intCont += 1
        End While

        'Movimiento Mercaderia
        Dim objHashTable As Hashtable
        objHashTable = New Hashtable
        Dim fGenerarRecepcion As frmGenerarRecepcion = New frmGenerarRecepcion
        objHashTable.Add("TPOOCM", "")
        objHashTable.Add("NORCCL", objListOC.Item(0).CodOC.ToString.Trim)
        objHashTable.Add("NGUICL", Convert.ToString(intNroGuiaRansa1))
        objHashTable.Add("NRUCLL", "0")
        objHashTable.Add("STPING", "S")
        objHashTable.Add("CTPALM", objListOC.Item(0).PSCTPALM.ToString.Trim) '"AS" 
        objHashTable.Add("TALMC", objListOC.Item(0).PSTCMPAL.ToString.Trim) '"ZONA MINERA INTEMPERIE"
        objHashTable.Add("CALMC", objListOC.Item(0).PSCALMC.ToString.Trim) '"ZM"
        objHashTable.Add("TCMPAL", objListOC.Item(0).PSTALMC.ToString.Trim) '"ALMACEN INTEMPERIE"
        objHashTable.Add("CZNALM", objListOC.Item(0).PSCZNALM.ToString.Trim) '"A1"
        objHashTable.Add("TCMZNA", objListOC.Item(0).PSTCMZNA.ToString.Trim) '"01 OUTSIDE"
        objHashTable.Add("CCNTD", "")
        objHashTable.Add("CTPOCN", False)
        objHashTable.Add("NOMPRO", objListOC.Item(0).PSNRUCPR.ToString.Trim & "-" & objListOC.Item(0).PSTPRVCL.ToString.Trim) 'Nombre del Proveedor "0-OUTSIDE"
        objHashTable.Add("NOMBPR", objListOC.Item(0).PSNRUCPR.ToString.Trim & "<->" & objListOC.Item(0).PSNRUCPR.ToString.Trim & "-" & objListOC.Item(0).PSTPRVCL.ToString.Trim)
        objHashTable.Add("NORSCI", 0)
        objHashTable.Add("CPRPCL", objListOC.Item(0).CODPROVOUT.ToString.Trim)
        objHashTable.Add("TIPORG", "A")
        objHashTable.Add("TIPORI", "PS")
        objHashTable.Add("CPRVCL", objListOC.Item(0).CODPROV.ToString.Trim)
        objHashTable.Add("SCNEMB", "N")

        fGenerarRecepcion.objInformacionIngresada = objMovimientoMercaderia
        fGenerarRecepcion.pHashTable = objHashTable
        fGenerarRecepcion.ItemSelec_List = lstItemsSelec
        fGenerarRecepcion.Cliente_CCLNT = txtCliente.pCodigo
        fGenerarRecepcion.RazonSocial = txtCliente.pRazonSocial
        fGenerarRecepcion.Tipo = "D"
        If fGenerarRecepcion.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            fGenerarRecepcion = Nothing
            Me.Close()
            Exit Sub
        End If
    End Sub


    Private Sub GenerarOrdenCompra_Q(ByVal intNroGuiaRansa As Int64)
        Dim intNroGuiaRansa1 As Int64 = intNroGuiaRansa
        Dim obeOrdenCompra As beOrdenCompra = New beOrdenCompra
        Dim objListOC As New List(Of beOrdenCompra)
        Dim objProveedor As New List(Of beOrdenCompra)
        Dim objBrProveedor As brProveedor = New brProveedor
        Dim objBrOC As brOrdenDeCompra = New brOrdenDeCompra
        Dim TD_Item As OrdenCompra.ItemOC.TD_ItemOC = New OrdenCompra.ItemOC.TD_ItemOC
        Dim CodProv As Decimal = 0
        Dim DesItem As String = ""

        obeOrdenCompra.PNCCLNT = pobePedidoPorPlanta.PNCCLNT
        obeOrdenCompra.PNGUIRN = intNroGuiaRansa1
        'Listar Item de Guia Ransa
        objProveedor = objBrOC.ListarOrdenDeCompraItems(obeOrdenCompra)

        Dim obeoc As beOrdenCompra

        For i As Integer = 0 To Me.dtgSet.Rows.Count - 1
            obeoc = New beOrdenCompra
            With obeoc
                .PNCCLNT = pobePedidoPorPlanta.PNCCLNT
                .PSCMRCLR = dtgSet.Item("PSCMRCLR1", i).Value.ToString.Trim  'codigo
                .PSTMRCD2 = dtgSet.Item("PSTMRCD3", i).Value  'descripcion
                .PSTMRCD3 = "" & dtgSet.Item("PSTMRCD4", i).Value & "" 'descripcion
                .PNQTRMC = dtgSet.Item("PNQTRMC1", i).Value                 'cantidad
                .PSCUNCN5 = dtgSet.Item("PSCUNCN_6", i).Value              'unidad
            End With
            objListOC.Add(obeoc)
        Next

        'Si es mayor a Cero inserta OC e Items
        If objListOC IsNot Nothing AndAlso objListOC.Count > 0 Then
            With obeOrdenCompra
                .PNCCLNT = pobePedidoPorPlanta.PNCCLNT
                .PSNORCML = "GS-" & Convert.ToString(intNroGuiaRansa1)
                .PSTPOOCM = ""
                .FechaOrdenDeCompra = Convert.ToString(dteFechaDespacho.Value.Date)
                .FechaSolicitud = Convert.ToString(dteFechaDespacho.Value.Date)
                .PNCPRVCL = objProveedor.Item(0).CODPROV 'CodProv
                .PSTDSCML = objProveedor.Item(0).PSTMRCD2.ToString 'DesItem
                .PSTCMAEM = ""
                .PSTTINTC = "LOC"
                .PSNREFCL = ""
                .PSTPAGME = ""
                .PSREFDO1 = ""
                .PNNTPDES = 1
                .PNCMNDA1 = 100
                .PSTEMPFAC = ""
                .PSTNOMCOM = ""
                .PSTCTCST = ""
                .PSCREGEMB = ""
                .PNCMEDTR = 4
                .PSTDEFIN = ""
                .PSTCNDPG = ""
                .PNIVCOTO = 0
                .PNIVTOCO = 0
                .PNIVTOIM = 0
                .PSTDAITM = objSeguridadBN.pUsuario
                .PSCUSCRT = objSeguridadBN.pUsuario
                .PSCULUSA = objSeguridadBN.pUsuario
                .PSTPOOCM = ""
            End With
            Dim obrOrdenDeCompra As New brOrdenDeCompra
            Dim rpta As Integer = obrOrdenDeCompra.InsertarOrdenDeCompra(obeOrdenCompra)

            If rpta = 1 Then
                For Each obOC As beOrdenCompra In objListOC
                    With TD_Item
                        .pCCLNT_CodigoCliente = pobePedidoPorPlanta.PNCCLNT
                        .pNORCML_NroOrdenCompra = "GS-" & Convert.ToString(intNroGuiaRansa1)
                        .pNRITOC_NroItemOC = obOC.NROITEM
                        .pTCITCL_CodigoCliente = obOC.PSCMRCLR.Trim
                        '.pTCITPR_CodigoProveedor = obOC.CODPROV 'txtNroItemOCProveedor.Text.Trim
                        .pTDITES_DescripcionES = obOC.PSTMRCD2 & obOC.PSTMRCD3
                        .pTDITIN_DescripcionIN = obOC.PSTMRCD2.Trim
                        .pQCNTIT_Cantidad = obOC.PNQTRMC
                        .pTUNDIT_Unidad = obOC.PSCUNCN5
                        .pIVUNIT_ImporteUnitario = 0
                        .pIVTOIT_ImporteTotal = 0
                        .pQTOLMAX_ToleranciaMax = 0
                        .pQTOLMIN_ToleranciaMin = 0
                        .pFMPDME_FechaEstEntregaDte = dteFechaDespacho.Value.Date
                        .pFMPIME_FechaReqPlantaDte = dteFechaDespacho.Value.Date
                        .pTLUGOR_LugarOrigen = ""
                        .pTLUGEN_LugarEntrega = ""
                        .pTCTCST_CentroDeCosto = ""
                        .pTRFRN_RefSolicitante = ""
                        .pFLGPEN_FlagSeguimiento = ""
                    End With
                    Dim objSqlManager As Db2Manager.RansaData.iSeries.DataObjects.SqlManager = New Db2Manager.RansaData.iSeries.DataObjects.SqlManager
                    Dim strUsuario As String = objSeguridadBN.pUsuario
                    Dim strMensajeError As String = ""
                    Dim brpta As Boolean = cItemOrdenCompra.Grabar(objSqlManager, TD_Item, strUsuario, strMensajeError)

                    If brpta = False Then
                        MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Next

            Else
                MessageBox.Show("No se registró la OC", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

        'Verificar si existe Codigo de Mercaderia
        Dim obrMercaderia As brMercaderia = New brMercaderia
        Dim obeMercaderia As beMercaderia = New beMercaderia

        For Each obOCItem As beOrdenCompra In objListOC
            obeMercaderia.PNCCLNT = pobePedidoPorPlanta.PNCCLNT
            obeMercaderia.PSCMRCLR = obOCItem.PSCMRCLR.Trim
            Dim oListMercaderia As New List(Of beMercaderia)
            oListMercaderia = obrMercaderia.ListaMercaderiaPorClienteItem(obeMercaderia)
            'Si no existe inserta mercaderia
            If oListMercaderia.Count = 0 Then
                Dim DtFamilia As New DataTable
                Dim DtGrupo As New DataTable
                DtFamilia = slnSOLMIN_SDS.clsGeneral_SDS.fdtBuscar_Familia("", pobePedidoPorPlanta.PNCCLNT, "")
                DtGrupo = slnSOLMIN_SDS.clsGeneral_SDS.fdtBuscar_Grupo("", pobePedidoPorPlanta.PNCCLNT, DtFamilia.Rows(0).Item("FAMILIA").ToString.Trim, "")
                Dim oclsMercaderia As New slnSOLMIN_SDS.MantenimientoSDS.clsMercaderia
                With oclsMercaderia
                    .pintCodigoCliente_CCLNT = pobePedidoPorPlanta.PNCCLNT
                    .pstrCodigoFamilia_CFMCLR = DtFamilia.Rows(0).Item("FAMILIA").ToString.Trim
                    .pstrCodigoGrupo_CGRCLR = DtGrupo.Rows(0).Item("GRUPO").ToString.Trim
                    .pstrCodigoMercaderia_CMRCLR = obOCItem.PSCMRCLR.ToString.Trim
                    .pstrCodigoMercaderiaReemplazo_CMRCRR = ""
                    .pstrCodigoRANSA_CMRCD = "1501390000"
                    .pstrDescripcion_TMRCD2 = obOCItem.PSTMRCD2
                    .pstrDescripcion_TMRCD3 = obOCItem.PSTMRCD3
                    .pintProveedor_CPRVCL = 7988
                    .pintCodigoMoneda_CMNCT = 100
                    Decimal.TryParse(0.0, .pdecImporteCosto_QIMCT)
                    Decimal.TryParse(0.0, .pdecImporteCostoPromedio_QIMCTP)
                    Decimal.TryParse(0.0, .pdecImporteCostoPromedioSoles_QICOPS)
                    .pblnMarcaReembolso_MARCRE = False
                    Decimal.TryParse("0.000", .pdecImporteVentaDolar_IMVTAD)
                    Decimal.TryParse("0.000", .pdecImporteVentaDolar_IMVTAS)
                    Decimal.TryParse("0.000", .pdecImportePorMts2_IMVLM2)
                    Decimal.TryParse("0.00", .pdecPorcentajeDescuento_PDSCTO)
                    .pstrMarcaModelo_TMRCTR = ""
                    .pstrUbicacion_UBICA1 = ""
                    .pstrObservacion_TOBSRV = ""
                    Decimal.TryParse("0.000", .pdecCantidadMinimaReqServicio_QMRSRC)
                    Decimal.TryParse("0.000", .pdecPesoMinimoReqServicio_QMRSRP)
                    Decimal.TryParse("0.000", .pdecCantidadMercaderiaPtoReorden_QMRODC)
                    Decimal.TryParse("0.000", .pdecPesoMercaderiaPtoReorden_QMRODP)
                    Decimal.TryParse("0.000", .pdecLargoMercaderia_QLRGMR)
                    Decimal.TryParse("0.000", .pdecAnchoMercaderia_QANCMR)
                    Decimal.TryParse("0.000", .pdecAlturaMercaderia_QALTMR)
                    Decimal.TryParse("0.000", .pdecAreaMts2_QARMT2)
                    Decimal.TryParse("0.000", .pdecVolumenMts3_QARMT3)
                    Decimal.TryParse("0.000", .pdecVolumenEquivalente_QVOLEQ)
                    Decimal.TryParse("0.000", .pdecCantidadPesoDeclarado_QPSODC)
                    Decimal.TryParse("0.000", .pdecTiempoCargaMercaderia_QTMPCR)
                    Decimal.TryParse("0.000", .pdecTiempoDesargaMercaderia_QTMPDS)
                    .pblnStatusPublicacionWEB_FPUWEB = False
                    .pstrUnidad_CUNCNC = ""
                    .pstrUnidadInventario_CUNCNI = "N"
                    Date.TryParse("0", .pdteFechaVencimiento_FVNCMR)
                    Date.TryParse("0", .pdteFechaInventario_FINVRN)
                    .pstrCodigoPerfumancia_CPRFMR = ""
                    .pstrCodigoInflamabilidad_CINFMR = ""
                    .pstrCodigoRotacion_CROTMR = ""
                    .pstrCodigoApilabilidad_CAPIMR = ""
                    .pstrCodigoDUN14 = ""
                    .pstrCodigoEAN13 = ""
                    Decimal.TryParse("", .pdecCantidadMinimaProducir_QMRPRD)
                    .CPTDAR_PartidaArancelaria = ""
                    .SCNTSR_MarcaControlSerie = IIf(False, "X", "")
                    .FUNCTL = "" 'ECM-CorrectivoSolmin(SA_SC_CTZ)-[300516]
                End With

                mfblnGuardar_Mercaderia(oclsMercaderia)
                oclsMercaderia = Nothing
            End If

            'Verificar si existe OS
            Dim blnResultado As Boolean = True
            Dim DtServicio As DataTable = mfdtListar_OrdenesServicioPorMercaderia(pobePedidoPorPlanta.PNCCLNT, obOCItem.PSCMRCLR.Trim)
            If DtServicio.Rows.Count = 0 Then
                'Si no existe OS, verifica si existe Contrato Vigente. Si existe crea OS
                Dim dtTemp As DataTable = mfdtListar_ContratosVigentes(pobePedidoPorPlanta.PNCCLNT, objSeguridadBN.pstrTipoAlmacen)
                If dtTemp.Rows.Count <= 0 Then
                    Call mpMsjeVarios(enumMsjVarios.DATA_NoExisteInformacion)
                Else
                    'Dim objNuevaOrdenServicio As slnSOLMIN_SDS.clsCrearOrdenServicio = New slnSOLMIN_SDS.clsCrearOrdenServicio
                    Dim objNuevaOrdenServicio As clsCrearOrdenServicio = New clsCrearOrdenServicio
                    With objNuevaOrdenServicio
                        .pintCodigoCliente_CCLNT = pobePedidoPorPlanta.PNCCLNT
                        .pstrCodigoMercaderia_CMRCLR = obOCItem.PSCMRCLR.Trim
                        .pintNroContrato_NCNTR = Convert.ToInt64(dtTemp.Rows(0).Item("NCNTR").ToString.Trim)
                        .pstrTipoDeposito_CTPDP3 = dtTemp.Rows(0).Item("CTPDP3").ToString.Trim
                        .pstrProducto_CTPPR1 = dtTemp.Rows(0).Item("CTPPR1").ToString.Trim
                        .pdecCantidadDeclarada_QMRCD = 1
                        .pstrUnidadCantidad_CUNCND = obOCItem.PSCUNCN5.Trim
                        .pdecPesoDeclarado_QPSMR = 1
                        .pstrUnidadPeso_CUNPS0 = "KGS"
                        .pdecValorDeclarado_QVLMR = 1
                        .pstrUnidadValor_CUNVLR = "DOL"
                        .pstrControlLotes_FUNCTL = "N"
                        .pstrUnidadDespacho_FUNDS = "C"
                    End With
                    blnResultado = mfblnCrearOrdenServicio(objNuevaOrdenServicio)
                    objNuevaOrdenServicio = Nothing
                    If blnResultado = False Then
                        MessageBox.Show("No se registró la Orden de Servicio", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If
        Next

        Dim objSqlManager2 As Db2Manager.RansaData.iSeries.DataObjects.SqlManager = New Db2Manager.RansaData.iSeries.DataObjects.SqlManager
        Dim strMensajeError2 As String = ""
        Dim TD_OrdenCompraActual As OrdenCompra.OrdenCompra.TD_OrdenCompraPK = New Ransa.TypeDef.OrdenCompra.OrdenCompra.TD_OrdenCompraPK
        TD_OrdenCompraActual.pCCLNT_CodigoCliente = pobePedidoPorPlanta.PNCCLNT
        TD_OrdenCompraActual.pNORCML_NroOrdenCompra = "GS-" & Convert.ToString(intNroGuiaRansa1)
        TD_OrdenCompraActual.PAGESIZE = 1000
        TD_OrdenCompraActual.PAGENUMBER = 1


        Dim dtItemOC As New DataTable
        dtItemOC = cItemOrdenCompra.fdtListar_ItemsOC_L01(objSqlManager2, TD_OrdenCompraActual, strMensajeError2)

        'Procesar SolicInfoRecOCAlmacen

        Dim objMovimientoMercaderia1 As New clsMovimientoMercaderia
        'Dim objMovimientoMercaderia1 As New slnSOLMIN_SDS.clsMovimientoMercaderia
        With objMovimientoMercaderia1
            .pintCodigoCliente_CCLNT = pobePedidoPorPlanta.PNCCLNT
            .pstrRazonSocialCliente_TCMPCL = ObtenerrClientes(pobePedidoPorPlanta.PNCCLNT) 'txtCliente.pRazonSocial 'pobePedidoPorPlanta.PSTCMPPL
            .pintServicio_CSRVC = 1
            .pintEmpresaTransporte_CTRSP = 999999
            .pstrRazonSocialEmpTransporte_TCMPTR = "VARIOS"
            .pintNroRUCEmpTransporte_NRUCT = 1
            .pstrNroPlacaCamion_NPLCCM = ""
            .pstrMarcaUnidad_TMRCCM = ""
            .pintAnioUnidad_NANOCM = 0
            .pstrNroBrevete_NBRVCH = ""
            .pstrChofer_TNMBCH = ""
            .pintNroDocIdentidadChofer_NLELCH = 0
            .pstrObservaciones_TOBSER = "Cambio de Código"
            .pstrCompania_CCMPN = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
            .pstrDivision_CDVSN = "R"
            .pstrTipoOrigen_TIPORG = "A"
            .pstrTipoDocumentoOrigen_TIPORI = "PS"  'GR
            .pstrObservaciones_TOBSRV = "Cambio de Código"
            .pstrCodigoProveedor_CPRVCL = objProveedor.Item(0).CODPROV.ToString.Trim
            .pstrCodigoProveedor_cliente_CPRPCL = objProveedor.Item(0).CODPROVOUT.ToString.Trim
            .pstrFechaRealizacion_FRLZSR = dteFechaDespacho.Value.Date

        End With

        Dim intCont As Int32 = 0
        intCont = 0
        Dim objTemp As New OrdenCompra.ItemOC.TD_ItemOCForWayBill
        objTemp = Nothing

        Dim lstItemsSelec As List(Of OrdenCompra.ItemOC.TD_ItemOCForWayBill) = New List(Of OrdenCompra.ItemOC.TD_ItemOCForWayBill)
        While intCont < dtItemOC.Rows.Count
            objTemp = New OrdenCompra.ItemOC.TD_ItemOCForWayBill
            objTemp.pNRITOC_NroItemOC = dtItemOC.Rows(intCont).Item("NRITOC")
            objTemp.pTCITCL_CodigoCliente = dtItemOC.Rows(intCont).Item("TCITCL").ToString.Trim
            objTemp.pQCNREC_QtaRecibida = dtItemOC.Rows(intCont).Item("QCNPEN")
            objTemp.pTUNDIT_UnidadQta = dtItemOC.Rows(intCont).Item("TUNDIT").ToString.Trim
            objTemp.pTDAITM_Observaciones = ""
            objTemp.pQPEPQT_QtaPeso = 0
            objTemp.pTUNPSO_UnidadPeso = ""
            objTemp.pCMRCD_CodigoRANSA = dtItemOC.Rows(intCont).Item("CMRCD").ToString
            objTemp.pTMRCD2_MercaDescripcion = dtItemOC.Rows(intCont).Item("TMRCD2").ToString.Trim
            objTemp.pNORDSR_OrdenServicio = dtItemOC.Rows(intCont).Item("NORDSR")
            objTemp.pNCNTR_NroContrato = dtItemOC.Rows(intCont).Item("NCNTR")
            objTemp.pNCRCTC_NroCorrelativoContrato = dtItemOC.Rows(intCont).Item("NCRCTC")
            objTemp.pNAUTR_NroAutorizacionContrato = dtItemOC.Rows(intCont).Item("NAUTR")
            objTemp.pCTPDPS_TipoDeposito = dtItemOC.Rows(intCont).Item("CTPDPS").ToString.Trim
            objTemp.pFUNDS2_Status = dtItemOC.Rows(intCont).Item("FUNDS2").ToString.Trim
            objTemp.pCUNCN5_UnidadCantidad = dtItemOC.Rows(intCont).Item("CUNCN5")
            objTemp.pCUNPS5_UnidadPeso = dtItemOC.Rows(intCont).Item("CUNPS5").ToString.Trim
            objTemp.pCUNVL5_UnidadValor = dtItemOC.Rows(intCont).Item("CUNVL5").ToString.Trim
            objTemp.pFMPDME_FechaMaxDespacho = dtItemOC.Rows(intCont).Item("FMPDME").ToString.Trim
            lstItemsSelec.Add(objTemp)
            intCont += 1
        End While

        'Movimiento Mercaderia
        Dim objHashTable As Hashtable
        objHashTable = New Hashtable
        Dim fGenerarRecepcion As frmGenerarRecepcion = New frmGenerarRecepcion
        objHashTable.Add("TPOOCM", "")
        objHashTable.Add("NORCCL", obeOrdenCompra.PSNORCML)
        objHashTable.Add("NGUICL", Convert.ToString(intNroGuiaRansa1))
        objHashTable.Add("NRUCLL", "0")
        objHashTable.Add("STPING", "K")
        objHashTable.Add("CTPALM", objMovimientoMercaderia.plstItemMovimientoMercaderia.Item(0).pstrTipoAlmacen_CTPALM.ToString.Trim) '"AS" 
        objHashTable.Add("TALMC", objMovimientoMercaderia.plstItemMovimientoMercaderia.Item(0).pstrTipoAlmacenDesc_TALMC) 'objMovimientoMercaderia.plstItemMovimientoMercaderia.Item(0).pstrTipoAlmacen.ToString.Trim) '"ZONA MINERA INTEMPERIE"
        objHashTable.Add("CALMC", objMovimientoMercaderia.plstItemMovimientoMercaderia.Item(0).pstrAlmacen_CALMC.ToString.Trim) '"ZM"
        objHashTable.Add("TCMPAL", objMovimientoMercaderia.plstItemMovimientoMercaderia.Item(0).pstrAlmacen_TCMPAL.ToString.Trim) '"ALMACEN INTEMPERIE"
        objHashTable.Add("CZNALM", objMovimientoMercaderia.plstItemMovimientoMercaderia.Item(0).pstrZonaAlmacen_CZNALM.ToString.Trim) '"A1"
        objHashTable.Add("TCMZNA", objMovimientoMercaderia.plstItemMovimientoMercaderia.Item(0).pstrZonaAlmacen_TCMZNA.ToString.Trim) '"01 OUTSIDE"
        objHashTable.Add("CCNTD", "")
        objHashTable.Add("CTPOCN", False)
        objHashTable.Add("NOMPRO", objProveedor.Item(0).PSNRUCPR.ToString.Trim & "-" & objProveedor.Item(0).PSTPRVCL.ToString.Trim) 'Nombre del Proveedor "0-OUTSIDE"
        objHashTable.Add("NOMBPR", objProveedor.Item(0).PSNRUCPR.ToString.Trim & "<->" & objProveedor.Item(0).PSNRUCPR.ToString.Trim & "-" & objProveedor.Item(0).PSTPRVCL.ToString.Trim)
        objHashTable.Add("NORSCI", 0)
        objHashTable.Add("CPRPCL", objProveedor.Item(0).CODPROVOUT)
        objHashTable.Add("TIPORG", "A")
        objHashTable.Add("TIPORI", "PS")
        objHashTable.Add("CPRVCL", objProveedor.Item(0).CODPROV.ToString.Trim)
        objHashTable.Add("SCNEMB", "N")

        fGenerarRecepcion.objInformacionIngresada = objMovimientoMercaderia1
        fGenerarRecepcion.pHashTable = objHashTable
        fGenerarRecepcion.ItemSelec_List = lstItemsSelec
        fGenerarRecepcion.Cliente_CCLNT = pobePedidoPorPlanta.PNCCLNT
        fGenerarRecepcion.RazonSocial = ObtenerrClientes(pobePedidoPorPlanta.PNCCLNT)
        'se usa para una validacion de cierre de ventana
        fGenerarRecepcion.Tipo = "D"
        If fGenerarRecepcion.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            fGenerarRecepcion = Nothing
            Me.Close()
            Exit Sub
        End If
    End Sub

    Private Sub GuardarControlesUsados()
        '-- Registro los nuevos valores de los campos de los clientes
        Dim objAppConfig As cAppConfig = New cAppConfig
        objAppConfig.ConfigType = 1
        objAppConfig.SetValue("Despacho_CodTransportista", Me.txtEmpresaTransporte.Tag(1))
        objAppConfig.SetValue("Despacho_NomTransportista", Me.txtEmpresaTransporte.Tag(0))
        objAppConfig.SetValue("Despacho_Placa", txtUnidad.Tag(0))
        objAppConfig.SetValue("Despacho_Brevete", txtBrevete.Tag(0))
        objAppConfig.SetValue("Despacho_TipoDespacho", CType(txtTipoDesOutotec.Resultado, beGeneral).PSSTPING)
        objAppConfig = Nothing
        '-- Reinicio las persianas
    End Sub


    Private Function fblnValidarInfDespacho() As Boolean
        Dim strResultado As String = ""


        'Empresa de transporte
        If txtEmpresaTransporte.Tag(0) = "" Then
            strResultado &= "- Debe seleccionar empresa de Transporte. " & vbNewLine
        End If
        'Tipo despacho
        If txtTipoDesOutotec.Resultado Is Nothing Then strResultado &= "- Debe seleccionar Tipo de Despacho." & vbNewLine
        If txtOrigen.Resultado Is Nothing Then strResultado &= "- Debe seleccionar el Tipo de Origen." & vbNewLine
        If txtTipoDoc.Resultado Is Nothing Then strResultado &= "- Debe seleccionar el Tipo de Doc. de origen." & vbNewLine

        strResultado &= ValirCantidad()

        If pbolClienteOutotec AndAlso Me.txtTipoDesOutotec.Resultado Is Nothing Then strResultado &= "- Debe seleccionar tipo de depacho Outotec" & vbNewLine

        If pbolClienteOutotec Then
            '===========SI EL CLIENTE ES OUTOTEC==============
            'Validamos que el tipo de movimiento selecciona tenga su equivalencia en outotec

            If Not txtTipoDesOutotec.Resultado Is Nothing Then
                Dim obrGeneral As New brGeneral
                Dim olbeGeneral As New List(Of beGeneral)
                olbeGeneral = obrGeneral.olEquivalenteOutotecTipoMovimientoDes(CType(txtTipoDesOutotec.Resultado, beGeneral).PSSTPING)
                If olbeGeneral.Count = 0 Then
                    strResultado &= "- El tipo de despacho no cuenta con equivalencia en la interfaz" & vbNewLine
                End If
                strTipoMovIntfz = olbeGeneral.Item(0).PSTDSDES
            End If

            'Validamos que contenga el Ruc

            If UcClienteTerceroDestino.ItemActual.PNCPRVCL = 0 Then _
                       strResultado &= "- Debe de seleccionar el Ruc" & vbNewLine

            If UcClienteTerceroDestino.ItemActual.PNCPRVCL <> 0 Then
                If CType(UcClienteTerceroDestino.ItemActual, PlantaDeEntrega.bePlantaDeEntrega).PSCPRPCL.ToString.Trim = "" Then
                    strResultado &= "- El Ruc no cuenta con su equivalencia en la interfaz" & vbNewLine
                End If
            End If

            'Dim intCorrelativo As Integer = 0
            'Dim objListKardex As New List(Of beKardex)
            'Dim strResultado2 As String = ""
            'For Each oDrv As DataGridViewRow In Me.dtgListaDespachos.Rows
            '  If oDrv.Cells("CHK").Value Then
            '    intCorrelativo = intCorrelativo + 1
            '    If intCorrelativo = 1 Then
            '      objListKardex = oDrv.Tag
            '    Else
            '      For Each obeKardex As beKardex In CType(oDrv.Tag, List(Of beKardex))
            '        If (objListKardex.Count > 0) Then
            '          For Each obeKardex0 As beKardex In objListKardex
            '            If (obeKardex0.PSCALMC <> obeKardex.PSCALMC Or obeKardex0.PSCZNALM <> obeKardex.PSCZNALM) Then
            '              strResultado2 &= "- Los Items de la Mercadería no tienen el mismo Tipo, Almacen y Zona." & vbNewLine
            '            End If
            '            If strResultado2 <> "" Then
            '              MessageBox.Show(strResultado2, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '              Return False
            '            End If
            '          Next
            '        End If

            '      Next
            '    End If
            '  End If

            'Next
        End If

        Dim intCantidad As Integer = ucSerie.dblCantidadSerie
        Dim objEntidad As beObservacionPedido
        Dim objObservaciones As New brObservacionesPedido
        For Each oDrv As DataGridViewRow In Me.dtgListaDespachos.Rows
            If oDrv.Cells("CHK").Value Then
                intCantidad = intCantidad + 1
                objEntidad = New beObservacionPedido
                objEntidad.PNCDPEPL = oDrv.Cells("PNCDPEPL").Value
                objEntidad.PNCDREGP = oDrv.Cells("PNCDREGP").Value
                intCantidad = intCantidad + Val(objObservaciones.Listado_Observaciones(objEntidad).Count)
            End If
        Next
        'If pbolClienteOutotec Then
        '    If intCantidad > 20 Then
        '        strResultado &= "- La cantidad Items a despachar excede a la hoja de la guía de remisión." & vbNewLine
        '    End If
        'Else
        '    If intCantidad > 16 Then
        '        strResultado &= "- La cantidad Items a despachar excede a la hoja de la guía de remisión." & vbNewLine
        '    End If
        'End If
        pintCantidaLineas = intCantidad
        If CType(txtTipoDesOutotec.Resultado, beGeneral).PSSTPING = "Q" Then

            If dtgSet.Rows.Count = 0 Then
                strResultado &= "- Debe registrar como mínimo un producto en la pestaña Set de Materiales"
            Else
                For i As Integer = 0 To dtgSet.Rows.Count - 1

                    If dtgSet.Item("PSCMRCLR1", i).Value = "" OrElse dtgSet.Item("PSTMRCD3", i).Value = "" OrElse dtgSet.Item("PNQTRMC1", i).Value = "" OrElse dtgSet.Item("PSCUNCN_6", i).Value = "" Then

                        strResultado &= "- Debe completar el registro del producto en la pestaña Set - Kit." & vbNewLine
                        Exit For
                    End If
                Next

            End If

        End If


        If strResultado <> "" Then
            MessageBox.Show(strResultado, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function


    'Private Sub pProcesarDespacho(ByRef resultadoEnvioInterfaz As String, ByVal blnCheckServicio As Boolean, ByRef intNroGuiaRansa As Int64, ByVal obeMovMerca As slnSOLMIN_SDS.clsMovimientoMercaderia)
    Private Sub pProcesarDespacho(ByRef resultadoEnvioInterfaz As String, ByVal blnCheckServicio As Boolean, ByRef intNroGuiaRansa As Int64, ByVal obeMovMerca As clsMovimientoMercaderia)
        Try
            If obeMovMerca.plstItemMovimientoMercaderia.Count <= 0 Then
                MessageBox.Show("No se ha agregado Item.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                If mfblnDespacho_Mercaderia(resultadoEnvioInterfaz, obeMovMerca, blnCheckServicio, intNroGuiaRansa) Then

                    'Private Function BuscarSolicitudServicioSalida_NSLCSS(ByVal objMovimientoMercaderia As slnSOLMIN_SDSIMPLE.clsMovimientoMercaderia, ByVal dblOrdenDeServicio As Double, ByVal dblNrItemPedidoPLanta As Double)
                    '    For Each objItemMovimientoMercaderia As slnSOLMIN_SDSIMPLE.clsItemMovimientoMercaderia In objMovimientoMercaderia.plstItemMovimientoMercaderia
                    '        If objItemMovimientoMercaderia.pintOrdenServicio_NORDSR = dblOrdenDeServicio And objItemMovimientoMercaderia.NrItemPedidoPLanta_CDREGP = dblNrItemPedidoPLanta Then
                    '            Return objItemMovimientoMercaderia.pintNroSolicitudSalida_NSLCSS
                    '            Exit Function
                    '        End If
                    '    Next
                    '    Return 0
                    'End Function



                    ucSerie.Guardar(intNroGuiaRansa, obeMovMerca)
                    UcUbicacion.Guardar(intNroGuiaRansa)

                    'INICIO-ECM-HUNDRED-MejoraDespachoAlmacenSimple-[210616]
                    UcLote1.LISTAMM = objMovimientoMercaderia.plstItemMovimientoMercaderia
                    UcLote1.Guardar()
                    'FIN-ECM-HUNDRED-MejoraDespachoAlmacenSimple-[210616]

                    Dim objFiltro As New beDespacho
                    With objFiltro
                        .PNCCLNT = obeMovMerca.pintCodigoCliente_CCLNT
                        .PNNGUIRN = intNroGuiaRansa
                        .pRazonSocial = obeMovMerca.pstrRazonSocialCliente_TCMPCL
                    End With
                    mReporteIngSalRansa(objFiltro)
                    If obeMovMerca.plstItemMovimientoMercaderia.Item(0).pbolEsOutotec Then
                        EnviarDespachoOutotec(obeMovMerca, intNroGuiaRansa, objSeguridadBN.pUsuario)
                    End If
                End If
                'Call ListaDespachoMercaderia(pobePedidoPorPlanta)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    'Private Sub EnviarDespachoOutotec(ByRef objMovimientoMercaderia As slnSOLMIN_SDS.clsMovimientoMercaderia, ByRef intNroGuiaRansa As Int64, ByVal strUsuarioSistema As String)
    Private Sub EnviarDespachoOutotec(ByRef objMovimientoMercaderia As clsMovimientoMercaderia, ByRef intNroGuiaRansa As Int64, ByVal strUsuarioSistema As String)
        Try
            Dim obrGeneral As New brGeneral
            Dim obrInterfaz As New brInterfazOutoTec
            '================registro de cabecera========================
            Dim obeCabInterfazOutotec As New beCabInfzOutotec
            With obeCabInterfazOutotec
                .ctpdoc = "PS"
                .npensa = intNroGuiaRansa '"??"
                .codcli = objMovimientoMercaderia.pintCodigoCliente_CCLNT
                .calmac = obrGeneral.fstrAlmacenVituralOutotec(pobePedidoPorPlanta.PNCCLNT, objMovimientoMercaderia.plstItemMovimientoMercaderia.Item(0).pstrZonaAlmacen_TCMZNA.Trim.Substring(0, 2))
                .femisi = objMovimientoMercaderia.pstrFechaRealizacion_FRLZSR
                .cconce = objMovimientoMercaderia.plstItemMovimientoMercaderia.Item(0).pstrTipoMovIntfz
                .ctpode = objMovimientoMercaderia.plstItemMovimientoMercaderia.Item(0).PSTIPORG.Trim
                .coride = objMovimientoMercaderia.plstItemMovimientoMercaderia.Item(0).pstrCodProvCliente_CPRPCL.Trim
                .ctpref = objMovimientoMercaderia.plstItemMovimientoMercaderia.Item(0).PSTIPORI.Trim  ' PENDIENTE
                .ndcref = objMovimientoMercaderia.plstItemMovimientoMercaderia.Item(0).pstrNroGuiaCliente_NGUICL 'olbeDespacho.Item(0).PSGUIA
                .dobser = objMovimientoMercaderia.plstItemMovimientoMercaderia.Item(0).pstrObservaciones_TOBSRV
                .nordpr = objMovimientoMercaderia.plstItemMovimientoMercaderia.Item(0).pstrNrRefPedido_NRFRPD
                .noccli = pobePedidoPorPlanta.PSTOBSMD 'Nr. Oc Cliente
                .spensa = "E"
                .fstatu = Now.Date
                .sgaran = "N"
                If strUsuarioSistema.Trim.Length > 6 Then
                    .cusuar = strUsuarioSistema.Trim.Substring(1, 6)
                Else
                    .cusuar = strUsuarioSistema
                End If
            End With

            '================registro de detalle=========================
            Dim olbeDetInterfazOutotec As New List(Of beDetInfzOutotec)
            Dim olbeListProyecto As New List(Of beProyecto)
            Dim olbeSerie As New List(Of Ransa.Controls.Serie.beSerie)
            Dim intNRow As Integer = 1
            Dim obeDetInterfazOutotec As beDetInfzOutotec
            Dim obeProyecto As New beProyecto
            For Each objItemMovimientoMercaderia As clsItemMovimientoMercaderia In objMovimientoMercaderia.plstItemMovimientoMercaderia
                'For Each objItemMovimientoMercaderia As slnSOLMIN_SDS.clsItemMovimientoMercaderia In objMovimientoMercaderia.plstItemMovimientoMercaderia
                olbeSerie = ucSerie.ListaSerieXOrdenDeServicioDespacho(objItemMovimientoMercaderia.pintOrdenServicio_NORDSR, objItemMovimientoMercaderia.NrItemPedidoPLanta_CDREGP)
                If olbeSerie.Count > 0 Then
                    If olbeSerie.Count = objItemMovimientoMercaderia.pdecCantidad_QTRMC Then
                        For Each obeSerie As Ransa.Controls.Serie.beSerie In olbeSerie
                            obeDetInterfazOutotec = New beDetInfzOutotec
                            olbeListProyecto = New List(Of beProyecto)
                            obeProyecto = New beProyecto
                            With obeProyecto
                                .PSNRFRPD = objItemMovimientoMercaderia.pstrNrRefPedido_NRFRPD
                                .PNQCNTIT2 = 1 ' va solo Uno
                            End With
                            olbeListProyecto.Add(obeProyecto)
                            With obeDetInterfazOutotec
                                .ctpdoc = "PS"
                                .npensa = obeCabInterfazOutotec.npensa
                                .codcli = objMovimientoMercaderia.pintCodigoCliente_CCLNT
                                .norden = intNRow
                                .citems = objItemMovimientoMercaderia.pstrCodigoMercaderia_CMRCLR
                                .cunmed = objItemMovimientoMercaderia.pstrUnidadCantidad_CUNCNT
                                .qitems = 1 'Va uno
                                .norped = 1 '
                                .nserie = obeSerie.PSCSRECL.Trim
                                .cubica = objItemMovimientoMercaderia.pstrAlmacen_TCMPAL
                                .qunida = IIf(objItemMovimientoMercaderia.pstrNrRefPedido_NRFRPD.Trim.Equals("P"), 0, Val(objItemMovimientoMercaderia.PSNLTECL.Trim))
                                .olistaProyecto = olbeListProyecto
                            End With
                            olbeDetInterfazOutotec.Add(obeDetInterfazOutotec)
                            intNRow = intNRow + 1
                        Next
                    Else
                        obeDetInterfazOutotec = New beDetInfzOutotec
                        olbeListProyecto = New List(Of beProyecto)
                        obeProyecto = New beProyecto
                        With obeProyecto
                            .PSNRFRPD = objItemMovimientoMercaderia.pstrNrRefPedido_NRFRPD
                            .PNQCNTIT2 = objItemMovimientoMercaderia.pdecCantidad_QTRMC - olbeSerie.Count
                        End With
                        olbeListProyecto.Add(obeProyecto)
                        With obeDetInterfazOutotec
                            .ctpdoc = "PS"
                            .npensa = obeCabInterfazOutotec.npensa
                            .codcli = objMovimientoMercaderia.pintCodigoCliente_CCLNT
                            .norden = intNRow
                            .citems = objItemMovimientoMercaderia.pstrCodigoMercaderia_CMRCLR
                            .cunmed = objItemMovimientoMercaderia.pstrUnidadCantidad_CUNCNT
                            .qitems = objItemMovimientoMercaderia.pdecCantidad_QTRMC - olbeSerie.Count
                            .norped = 1 '
                            .cubica = objItemMovimientoMercaderia.pstrAlmacen_TCMPAL
                            .qunida = IIf(objItemMovimientoMercaderia.pstrNrRefPedido_NRFRPD.Trim.Equals("P"), 0, Val(objItemMovimientoMercaderia.PSNLTECL.Trim))
                            .olistaProyecto = olbeListProyecto
                        End With
                        olbeDetInterfazOutotec.Add(obeDetInterfazOutotec)
                        intNRow = intNRow + 1

                        For Each obeSerie As Ransa.Controls.Serie.beSerie In olbeSerie
                            obeDetInterfazOutotec = New beDetInfzOutotec
                            olbeListProyecto = New List(Of beProyecto)
                            obeProyecto = New beProyecto
                            With obeProyecto
                                .PSNRFRPD = objItemMovimientoMercaderia.pstrNrRefPedido_NRFRPD
                                .PNQCNTIT2 = 1 ' va solo Uno
                            End With
                            olbeListProyecto.Add(obeProyecto)
                            With obeDetInterfazOutotec
                                .ctpdoc = "PS"
                                .npensa = obeCabInterfazOutotec.npensa
                                .codcli = objMovimientoMercaderia.pintCodigoCliente_CCLNT
                                .norden = intNRow
                                .citems = objItemMovimientoMercaderia.pstrCodigoMercaderia_CMRCLR
                                .cunmed = objItemMovimientoMercaderia.pstrUnidadCantidad_CUNCNT
                                .qitems = 1 'Va uno
                                .norped = 1 '
                                .cubica = objItemMovimientoMercaderia.pstrAlmacen_TCMPAL
                                .nserie = obeSerie.PSCSRECL
                                .qunida = IIf(objItemMovimientoMercaderia.pstrNrRefPedido_NRFRPD.Trim.Equals("P"), 0, Val(objItemMovimientoMercaderia.PSNLTECL.Trim))
                                .olistaProyecto = olbeListProyecto
                            End With
                            olbeDetInterfazOutotec.Add(obeDetInterfazOutotec)
                            intNRow = intNRow + 1
                        Next
                    End If
                Else
                    obeDetInterfazOutotec = New beDetInfzOutotec
                    olbeListProyecto = New List(Of beProyecto)
                    obeProyecto = New beProyecto
                    With obeProyecto
                        .PSNRFRPD = objItemMovimientoMercaderia.pstrNrRefPedido_NRFRPD
                        .PNQCNTIT2 = objItemMovimientoMercaderia.pdecCantidad_QTRMC 'obeDesp.PNQTRMC
                    End With
                    olbeListProyecto.Add(obeProyecto)
                    With obeDetInterfazOutotec
                        .ctpdoc = "PS"
                        .npensa = obeCabInterfazOutotec.npensa
                        .codcli = objMovimientoMercaderia.pintCodigoCliente_CCLNT
                        .norden = intNRow
                        .citems = objItemMovimientoMercaderia.pstrCodigoMercaderia_CMRCLR
                        .cunmed = objItemMovimientoMercaderia.pstrUnidadCantidad_CUNCNT
                        .qitems = objItemMovimientoMercaderia.pdecCantidad_QTRMC
                        .norped = 1 'obeDesp.PSNRFRPD
                        .cubica = objItemMovimientoMercaderia.pstrAlmacen_TCMPAL
                        .qunida = IIf(objItemMovimientoMercaderia.pstrNrRefPedido_NRFRPD.Trim.Equals("P"), 0, Val(objItemMovimientoMercaderia.PSNLTECL.Trim))
                        .olistaProyecto = olbeListProyecto
                    End With
                    olbeDetInterfazOutotec.Add(obeDetInterfazOutotec)
                    intNRow = intNRow + 1
                End If
            Next

            Dim oucOrdena As UCOrdena(Of Ransa.TypeDef.beDetInfzOutotec)

            oucOrdena = New UCOrdena(Of Ransa.TypeDef.beDetInfzOutotec)("qunida", UCOrdena(Of Ransa.TypeDef.beDetInfzOutotec).TipoOrdenacion.Ascendente)
            olbeDetInterfazOutotec.Sort(oucOrdena)

            For intRow As Integer = 0 To olbeDetInterfazOutotec.Count - 1
                olbeDetInterfazOutotec.Item(intRow).norden = intRow
            Next


            If obrInterfaz.fintInsertarProceso(obeCabInterfazOutotec, olbeDetInterfazOutotec) = -1 Then
                HelpClass.MsgBox("Error en el proceso de envio a Outotec, Notifique este evento al Dpto. de Sistemas.")
            Else
                Dim objDespacho As New brDespacho
                Dim obeDespacho As New beDespacho

                With obeDespacho
                    .PSCTPIS = "S"
                    .PNCCLNT = obeCabInterfazOutotec.codcli
                    .PNNGUIRN = obeCabInterfazOutotec.npensa
                    .PNFRLZSR = HelpClass.CtypeDate(obeCabInterfazOutotec.femisi)
                    .PSSTPODP = objSeguridadBN.pstrTipoAlmacen
                    .PNNPRTIN = 0
                    .PSSTRNSM = "X"
                    .PNFTRNSM = Convert.ToDecimal(HelpClass.CtypeDate(DateTime.Today))
                    .PNHTRNSM = Convert.ToDecimal(HelpClass.NowNumeric())
                    .PSCUSCRT = objSeguridadBN.pUsuario
                    .PNFCHCRT = Convert.ToDecimal(HelpClass.CtypeDate(DateTime.Today))
                    .PNHRACRT = Convert.ToDecimal(HelpClass.NowNumeric())
                    .PSCULUSA = objSeguridadBN.pUsuario
                    .PNFULTAC = Convert.ToDecimal(HelpClass.CtypeDate(DateTime.Today))
                    .PNHULTAC = Convert.ToDecimal(HelpClass.NowNumeric())
                End With

                Dim rpta As Integer = 1
                rpta = objDespacho.fintRegistrarEnvioInterfaz(obeDespacho)
                If rpta = 0 Then
                    MessageBox.Show("Error al Registrar Envio Interfaz", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If MessageBox.Show("Desea anular el registro", "Anular", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If Anular() Then
                    Me.ListaDespachoMercaderia(pobePedidoPorPlanta)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub dtgListaDespachos_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgListaDespachos.CellEndEdit
        Try
            If Me.dtgListaDespachos.CurrentRow.Cells("CHK").Value Then
                'falta tipo de almacen y almacen
                'Me.dtgListaDespachos.CurrentRow.Cells("CANTIDAD").Value = Me.dtgListaDespachos.CurrentRow.Cells("QPENDIN").Value
                ' ucSerie.EliminarSeries(Me.dtgListaDespachos.CurrentRow.Cells("PNNORDSR").Value, dtgListaDespachos.Rows.IndexOf(Me.dtgListaDespachos.CurrentRow))
                ucSerie.DespachoSeries(pobePedidoPorPlanta.PNCDPEPL, Me.dtgListaDespachos.CurrentRow.Cells("PNNORDSR").Value, dtgListaDespachos.CurrentRow.Cells("PNCDREGP").Value, Val(Me.dtgListaDespachos.CurrentRow.Cells("CANTIDAD").Value), objSeguridadBN.pUsuario)
                'UcUbicacion.EliminarUbicaciones(Me.dtgListaDespachos.CurrentRow.Cells("PNNORDSR").Value, dtgListaDespachos.Rows.IndexOf(Me.dtgListaDespachos.CurrentRow))
                If "" & Me.dtgStockAlmacen.CurrentRow.Cells("D_CTPALM").Value & "" <> "" Then
                    UcUbicacion.ConsultarDespachos(pobePedidoPorPlanta.PNCDPEPL, Me.dtgListaDespachos.CurrentRow.Cells("PNNORDSR").Value, "" & Me.dtgStockAlmacen.CurrentRow.Cells("D_CTPALM").Value & "", "" & Me.dtgStockAlmacen.CurrentRow.Cells("D_CALMC").Value & "", "" & Me.dtgStockAlmacen.CurrentRow.Cells("D_CZNALM").Value & "", Val(Me.dtgListaDespachos.CurrentRow.Cells("CANTIDAD").Value), objSeguridadBN.pUsuario, False, dtgListaDespachos.Rows.IndexOf(dtgListaDespachos.CurrentRow))
                End If
                ListaDeAlmacenesConCheckPorOrdenDeServicio(0)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Elimanado por mientras

    'Private Sub dtgListaDespachos_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dtgListaDespachos.ColumnHeaderMouseClick
    '    If e.ColumnIndex = 0 Then Exit Sub
    '    If Me.dtgListaDespachos.RowCount = 0 Then Exit Sub
    '    Dim olbePedidoPorPlanta As New List(Of bePedidoPorPlanta)
    '    olbePedidoPorPlanta = dtgListaDespachos.DataSource
    '    Dim oucOrdena As UCOrdena(Of bePedidoPorPlanta)
    '    oucOrdena = New UCOrdena(Of bePedidoPorPlanta)(Me.dtgListaDespachos.Columns(e.ColumnIndex).Name, UCOrdena(Of bePedidoPorPlanta).TipoOrdenacion.Ascendente)
    '    olbePedidoPorPlanta.Sort(oucOrdena)
    '    Me.dtgListaDespachos.DataSource = olbePedidoPorPlanta
    '    Me.dtgListaDespachos.Refresh()
    'End Sub

    Private Function Anular() As Boolean
        Dim obrDespacho As New brDespacho
        Dim obePedidoPorPlanta As New bePedidoPorPlanta
        Dim intResultado As Integer

        With obePedidoPorPlanta
            .PNCDPEPL = Me.dtgListaDespachos.CurrentRow.Cells("PNCDPEPL").Value
            .PNCDREGP = Me.dtgListaDespachos.CurrentRow.Cells("PNCDREGP").Value
            .PSCULUSA = objSeguridadBN.pUsuario
        End With
        ucSerie.EliminarSeries(Me.dtgListaDespachos.CurrentRow.Cells("PNNORDSR").Value, dtgListaDespachos.CurrentRow.Cells("PNCDREGP").Value)
        intResultado = obrDespacho.AnularDespachoMercaderiaPorClientePorPlanta(obePedidoPorPlanta)
        If intResultado = 0 Then
            Return False
        Else
            MessageBox.Show("Registro Anulado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        End If
    End Function

    Private Sub dtgListaDespachos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgListaDespachos.CellContentClick
        Try
            If e.RowIndex = -1 Then Exit Sub

            ' Mostrar observación
            If Me.dtgListaDespachos.CurrentCellAddress.Y < 0 Then Exit Sub
            Dim ColName As String = dtgListaDespachos.Columns(dtgListaDespachos.CurrentCell.ColumnIndex).Name
            If ColName = "OBSE" Then
                Dim objfrmObservacionesPedido As New frmObservacionesPedido
                'objfrmObservacionesPedido.getData = objListado
                objfrmObservacionesPedido.TipoOperacion = "Modificar"
                objfrmObservacionesPedido.NroPedido = Me.dtgListaDespachos.CurrentRow.Cells("PNCDPEPL").Value
                objfrmObservacionesPedido.NroCorrelativo = Me.dtgListaDespachos.CurrentRow.Cells("PNCDREGP").Value
                objfrmObservacionesPedido.CodigoMercaderia = Me.dtgListaDespachos.CurrentRow.Cells("PSCMRCLR").Value
                objfrmObservacionesPedido.NombreMercaderia = Me.dtgListaDespachos.CurrentRow.Cells("PSTMRCD2").Value
                objfrmObservacionesPedido.CantidadMercaderia = Me.dtgListaDespachos.CurrentRow.Cells("PNSALDO").Value
                If objfrmObservacionesPedido.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                End If
            End If

            If e.ColumnIndex = 0 Then
                Dim intSumCantAtender As Integer = 0
                Me.dtgListaDespachos.EndEdit()
                Me.dtgListaDespachos.CurrentRow.Cells("CANTIDAD").Value = Me.dtgListaDespachos.CurrentRow.Cells("QPENDIN").Value
                UcLote1.CantidadPedidoPendiente = Val(Me.dtgListaDespachos.CurrentRow.Cells("CANTIDAD").Value.ToString())
                If Me.dtgListaDespachos.CurrentRow.Cells("CHK").Value Then
                    UcLote1.CantidadPedidoPendiente = Me.dtgListaDespachos.CurrentRow.Cells("CANTIDAD").Value
                    ListarLotes()
                    For intCont As Integer = 0 To dtgListaDespachos.RowCount - 1
                        If Me.dtgListaDespachos.Rows(intCont).Cells("CHK").Value AndAlso Me.dtgListaDespachos.Rows(intCont).Cells("PSCMRCLR").Value = dtgListaDespachos.CurrentRow.Cells("PSCMRCLR").Value AndAlso dtgListaDespachos.Rows(intCont).Index <> dtgListaDespachos.CurrentRow.Index Then
                            intSumCantAtender = intSumCantAtender + Me.dtgListaDespachos.Rows(intCont).Cells("CANTIDAD").Value
                        End If
                    Next
                    If dtgListaDespachos.CurrentRow.Cells("PNSALDO").Value < (intSumCantAtender + dtgListaDespachos.CurrentRow.Cells("CANTIDAD").Value) Then

                        If (dtgListaDespachos.CurrentRow.Cells("PNSALDO").Value - intSumCantAtender) <= 0 Then
                            Me.dtgListaDespachos.CurrentRow.Cells("CHK").Value = False
                            ucSerie.CheckAll = False
                            ucSerie.DespachoIsReadOnly = True
                            Me.dtgStockAlmacen.Columns("QALMACEN").Visible = False
                            Me.dtgListaDespachos.CurrentRow.Cells("CANTIDAD").Value = 0D
                            MessageBox.Show(" Cantidad a atender excede al saldo en Almacén. ", "Precaución", MessageBoxButtons.OK)
                            Exit Sub
                        Else
                            If MessageBox.Show(" Cantidad a atender excede al saldo en Almacén. " & vbNewLine & " ¿desea atender? ", "Precaución", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                                Me.dtgListaDespachos.CurrentRow.Cells("CHK").Value = False

                                ucSerie.CheckAll = False
                                ucSerie.DespachoIsReadOnly = True
                                Me.dtgStockAlmacen.Columns("QALMACEN").Visible = False
                                Me.dtgListaDespachos.CurrentRow.Cells("CANTIDAD").Value = 0D
                                Exit Sub
                            End If
                            Me.dtgListaDespachos.CurrentRow.Cells("CANTIDAD").Value = (dtgListaDespachos.CurrentRow.Cells("PNSALDO").Value - intSumCantAtender)
                        End If

                    End If
                    ListaDeAlmacenesConCheckPorOrdenDeServicio(0)
                    ucSerie.DespachoIsReadOnly = False
                    Me.dtgStockAlmacen.Columns("QALMACEN").Visible = True
                Else
                    ucSerie.CheckAll = False
                    ucSerie.DespachoIsReadOnly = True
                    Me.dtgStockAlmacen.Columns("QALMACEN").Visible = False
                    Me.dtgListaDespachos.CurrentRow.Cells("CANTIDAD").Value = 0D
                    UcLote1.ResetearCantidades()
                End If
                ' UcUbicacion.ConsultarDespachos(pobePedidoPorPlanta.PNCDPEPL, Me.dtgListaDespachos.CurrentRow.Cells("PNNORDSR").Value, "" & Me.dtgListaDespachos.CurrentRow.Cells("PSCTPALM").Value & "", "" & Me.dtgListaDespachos.CurrentRow.Cells("PSCALMC").Value & "", Val(Me.dtgListaDespachos.CurrentRow.Cells("CANTIDAD").Value), objSeguridadBN.pUsuario, False, dtgListaDespachos.Rows.IndexOf(dtgListaDespachos.CurrentRow))
                ucSerie.DespachoSeries(pobePedidoPorPlanta.PNCDPEPL, Me.dtgListaDespachos.CurrentRow.Cells("PNNORDSR").Value, dtgListaDespachos.CurrentRow.Cells("PNCDREGP").Value, Val(Me.dtgListaDespachos.CurrentRow.Cells("CANTIDAD").Value), objSeguridadBN.pUsuario)
                Activar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Activar()
        'If dtgListaDespachos.CurrentCellAddress.X = 1 OrElse dtgListaDespachos.CurrentCellAddress.X = 2 Then
        Me.dtgListaDespachos.Columns("CANTIDAD").Visible = False
        Me.dtgListaDespachos.Columns("PESO").Visible = False
        'End If
        For Each oDrDespacho As DataGridViewRow In Me.dtgListaDespachos.Rows
            If oDrDespacho.Cells("CHK").Value Then
                Me.dtgListaDespachos.Columns("CANTIDAD").Visible = True
                Me.dtgListaDespachos.Columns("PESO").Visible = True
                oDrDespacho.Cells("CANTIDAD").ReadOnly = False
                oDrDespacho.Cells("PESO").ReadOnly = False
            Else
                oDrDespacho.Cells("PSCTPALM").Value = ""
                oDrDespacho.Cells("PSCALMC").Value = ""
                oDrDespacho.Cells("PSCZNALM").Value = """"
                oDrDespacho.Cells("CANTIDAD").ReadOnly = True
                oDrDespacho.Cells("PESO").ReadOnly = True
            End If
        Next
    End Sub

    Private Function ValirCantidad() As String
        Dim strError As String = ""
        Dim intContRegistro As Integer = 0
        For Each oDrDespacho As DataGridViewRow In Me.dtgListaDespachos.Rows
            If oDrDespacho.Cells("CHK").Value Then

                If (IsNumeric(oDrDespacho.Cells("CANTIDAD").Value) AndAlso CType(oDrDespacho.Cells("CANTIDAD").Value, Decimal) <> 0) Then
                    If oDrDespacho.Cells("SALDOALMACEN").Value < oDrDespacho.Cells("CANTIDAD").Value Then
                        oDrDespacho.Cells("CANTIDAD").ErrorText = "Cantidad atender debe de ser igual a la cantidad a despachar en almacén."
                        Return "-Cantidad atender debe de ser igual a la cantidad a despachar en almacén." & vbNewLine
                    Else
                        oDrDespacho.Cells("CANTIDAD").ErrorText = ""
                    End If
                Else
                    oDrDespacho.Cells("CANTIDAD").ErrorText = "Ingrese cantidades Validos." & vbNewLine
                    Return "- Ingrese cantidades Validos."
                End If

                If (IsNumeric(oDrDespacho.Cells("PESO").Value)) Then
                    If oDrDespacho.Cells("PESOALMACEN").Value < oDrDespacho.Cells("PESO").Value Then
                        oDrDespacho.Cells("PESO").ErrorText = " Peso atender debe de ser igual al Peso a despachar en almacén."
                        Return "- Peso atender debe de ser igual al Peso a despachar en almacén." & vbNewLine
                    Else
                        oDrDespacho.Cells("PESO").ErrorText = ""
                    End If
                ElseIf (Not oDrDespacho.Cells("PESO").Value Is Nothing) Then
                    oDrDespacho.Cells("PESO").ErrorText = "Ingrese cantidades Válidos." & vbNewLine
                    Return "- Ingrese Peso Validos."
                End If

                'PESOALMACEN
                'If oDrDespacho.Cells("PSSCNTSR").Value = "X" Then
                '    If Not ucSerie.IsEqualsCantidadSeriesPorOs(oDrDespacho.Cells("PNNORDSR").Value, oDrDespacho.Cells("PNCDREGP").Value, Val(oDrDespacho.Cells("CANTIDAD").Value)) Then
                '        oDrDespacho.Cells("CANTIDAD").ErrorText = " Cantidad de series seleccionadas " & Chr(10) & "es menor que la cantidad a despachar"
                '        Return ("- Cantidad de series seleccionadas es menor que la cantidad a despachar" & vbNewLine)
                '    Else
                '        oDrDespacho.Cells("CANTIDAD").ErrorText = ""
                '    End If

                'End If
                intContRegistro += 1
            End If
        Next
        If intContRegistro = 0 Then
            Return "- Debe de seleccionar por lo menos un registro." & vbNewLine
        End If
        Return ""
    End Function

    'Private Function ExisteAlmacen() As Boolean
    '    Dim Estado As Boolean = False
    '    ' Dim olbeKardex As List(Of beKardex)
    '    For Each oDrDespacho As DataGridViewRow In Me.dtgListaDespachos.Rows
    '        If oDrDespacho.Cells("CHK").Value Then
    '            'If oDrDespacho.Cells("PSCTPALM").Value <> "" AndAlso oDrDespacho.Cells("PSCALMC").Value <> "" _
    '            '           AndAlso oDrDespacho.Cells("PSCZNALM").Value <> "" Then
    '            Estado = True
    '            If Not (oDrDespacho.Tag Is Nothing) Then
    '                ' olbeKardex = CType(dtgListaDespachos.CurrentRow.Tag, List(Of beKardex))
    '                Estado = True
    '            Else
    '                Estado = False
    '            End If
    '            'Else
    '            '    Return False
    '            'End If
    '        End If
    '    Next
    '    Return Estado
    'End Function



    Private Sub bsaEmpresaTransporteListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaEmpresaTransporteListar.Click
        Try
            blnStatusTransportista = False
            Call mfblnBuscar_EmpresaTransporte(txtEmpresaTransporte.Tag(1), txtEmpresaTransporte.Tag(0), txtEmpresaTransporte.Tag(2))
            txtEmpresaTransporte.Text = txtEmpresaTransporte.Tag(0)
            blnStatusTransportista = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtEmpresaTransporte_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmpresaTransporte.GotFocus
        Try
            blnStatusTransportista = False
            txtEmpresaTransporte.Text = txtEmpresaTransporte.Tag(0)
            txtEmpresaTransporte.SelectAll()
            blnStatusTransportista = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub txtEmpresaTransporte_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmpresaTransporte.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F4
                    blnStatusTransportista = False
                    Call mfblnBuscar_EmpresaTransporte(txtEmpresaTransporte.Tag(1), txtEmpresaTransporte.Tag(0), txtEmpresaTransporte.Tag(2))
                    blnStatusTransportista = False
                    txtEmpresaTransporte.Text = txtEmpresaTransporte.Tag(0)
                    blnStatusTransportista = True
                Case Keys.Delete
                    txtEmpresaTransporte.Text = ""
                    Me.LimpiarTransportista()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub txtEmpresaTransporte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmpresaTransporte.TextChanged
        Try
            If blnStatusTransportista Then
                LimpiarTransportista()
                Me.txtBrevete.Text = ""
                Me.txtUnidad.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub txtEmpresaTransporte_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEmpresaTransporte.Validating
        Try
            If txtEmpresaTransporte.Text = "" Then
                Me.LimpiarTransportista()
            Else
                If txtEmpresaTransporte.Text <> txtEmpresaTransporte.Tag(0) And txtEmpresaTransporte.Tag(0) = "" Then
                    blnStatusTransportista = False
                    Call mfblnBuscar_EmpresaTransporte(txtEmpresaTransporte.Tag(1), txtEmpresaTransporte.Text, txtEmpresaTransporte.Tag(2))
                    txtEmpresaTransporte.Tag(0) = txtEmpresaTransporte.Text
                    blnStatusTransportista = True
                    If txtEmpresaTransporte.Text = "" Then
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub bsaUnidadListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaUnidadListar.Click
        blnStatusUnidad = False
        Call mfblnBuscar_PlacaUnidad("" & txtEmpresaTransporte.Tag(1), txtUnidad.Tag(0), "", "", txtUnidad.Tag(1), txtUnidad.Tag(2), "")
        blnStatusUnidad = False
        txtUnidad.Text = txtUnidad.Tag(0)
        blnStatusUnidad = True
    End Sub

    Private Sub txtUnidad_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUnidad.GotFocus
        blnStatusUnidad = False
        txtUnidad.Text = txtUnidad.Tag(0)
        blnStatusUnidad = True
    End Sub

    Private Sub txtUnidad_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUnidad.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                blnStatusUnidad = False
                Call mfblnBuscar_PlacaUnidad("" & txtEmpresaTransporte.Tag(1), txtUnidad.Text, "", "", txtUnidad.Tag(1), txtUnidad.Tag(2), "")
                txtUnidad.Tag(0) = txtUnidad.Text
                blnStatusUnidad = True
            Case Keys.Delete
                LimpiarUnidad()
        End Select
    End Sub

    Private Sub txtUnidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnidad.TextChanged
        If blnStatusUnidad Then
            LimpiarUnidad()
        End If
    End Sub

    Private Sub txtUnidad_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtUnidad.Validating
        Try
            If txtUnidad.Text = "" Or txtEmpresaTransporte.Text = "" Then
                LimpiarUnidad()
            Else
                If mfblnExiste_PlacaCamion("" & txtEmpresaTransporte.Tag(1), txtUnidad.Text, "") Then
                    If txtUnidad.Text <> txtUnidad.Tag(0) And "" & txtUnidad.Tag(0) = "" Then
                        blnStatusUnidad = False
                        Call mfblnObtenerDetalle_SDSPlacaCamion("" & txtEmpresaTransporte.Tag(1), txtUnidad.Text, txtUnidad.Tag(1), txtUnidad.Tag(2))
                        txtUnidad.Tag(0) = txtUnidad.Text
                        blnStatusUnidad = True
                    End If
                Else
                    If txtUnidad.Tag(0) = "" Then mpMsjeVarios(enumMsjVarios.NOEXIST_Registrar)
                    txtUnidad.Text = ""
                    LimpiarUnidad()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub txtBrevete_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBrevete.GotFocus
        blnStatusBrevete = False
        txtBrevete.Text = txtBrevete.Tag(0)
        txtBrevete.SelectAll()
        blnStatusBrevete = True
    End Sub

    Private Sub txtBrevete_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBrevete.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F4
                    blnStatusBrevete = False
                    Call mfblnBuscar_Brevete("" & txtEmpresaTransporte.Tag(1), txtBrevete.Text, txtBrevete.Tag(1), txtBrevete.Tag(2))
                    blnStatusBrevete = False
                    txtBrevete.Tag(0) = txtBrevete.Text
                    blnStatusBrevete = True
                Case Keys.Delete
                    LimpiarBrevete()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtBrevete_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBrevete.TextChanged
        If blnStatusBrevete Then
            LimpiarBrevete()
        End If
    End Sub

    Private Sub txtBrevete_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBrevete.Validated
        If txtBrevete.Tag(0).ToString.Length > 0 Then
            blnStatusBrevete = False
            txtBrevete.Text = txtBrevete.Tag(0) & " - " & txtBrevete.Tag(1)
            blnStatusBrevete = True
        End If
    End Sub

    Private Sub txtBrevete_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtBrevete.Validating
        If txtBrevete.Text = "" Then
            LimpiarBrevete()
        Else
            If mfblnExiste_Chofer("" & txtEmpresaTransporte.Tag(1), txtBrevete.Text, "") Then
                If txtBrevete.Text <> "" And "" & txtBrevete.Tag(0) = "" Then
                    blnStatusBrevete = False
                    Call mfblnObtenerDetalle_SDSChofer("" & txtEmpresaTransporte.Tag(1), txtBrevete.Text, txtBrevete.Tag(1), txtBrevete.Tag(2))
                    txtBrevete.Tag(0) = txtBrevete.Text
                    blnStatusBrevete = True
                End If
                ' Actualizamos la variable del status de nuevo nro. de brevete
            Else
                If txtBrevete.Tag(0) = "" Then mpMsjeVarios(enumMsjVarios.NOEXIST_Registrar)
                txtBrevete.Text = ""
                LimpiarBrevete()
            End If
        End If
    End Sub

    Private Sub bsaBreveteListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaBreveteListar.Click
        blnStatusBrevete = False
        Call mfblnBuscar_Brevete("" & txtEmpresaTransporte.Tag(1), txtBrevete.Tag(0), txtBrevete.Tag(1), txtBrevete.Tag(2))
        blnStatusBrevete = False
        txtBrevete.Text = txtBrevete.Tag(0) & " - " & txtBrevete.Tag(1)
        blnStatusBrevete = True
    End Sub

    Private Sub txtEmpresaTransporte_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmpresaTransporte.Validated
        If txtEmpresaTransporte.Tag(0).ToString.Length > 0 Then
            blnStatusTransportista = False
            txtEmpresaTransporte.Text = txtEmpresaTransporte.Tag(1) & " - " & txtEmpresaTransporte.Tag(0)
            blnStatusTransportista = True
        End If
    End Sub

    Private Sub txtUnidad_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnidad.Validated
        Try
            If txtUnidad.Tag(0).ToString.Length > 0 Then
                blnStatusUnidad = False
                txtUnidad.Text = txtUnidad.Tag(0) & " - " & txtUnidad.Tag(1)
                blnStatusUnidad = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub dtgListaDespachos_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgListaDespachos.SelectionChanged

        Try
            'If Not pboolEstadoCargado Then Exit Sub
            'tbcDespacho.Visible = True
            pboolEstadoValidating = False
            dtgStockAlmacen.AutoGenerateColumns = False
            dtgStockAlmacen.DataSource = mfdtListar_StockMercaderiasPorAlmacen(Me.dtgListaDespachos.CurrentRow.Cells("PNNORDSR").Value)
            pboolEstadoValidating = True
            ListaDeAlmacenesConCheckPorOrdenDeServicio(0)
            ucSerie.DespachoSeries(pobePedidoPorPlanta.PNCDPEPL, Me.dtgListaDespachos.CurrentRow.Cells("PNNORDSR").Value, dtgListaDespachos.CurrentRow.Cells("PNCDREGP").Value, Val(Me.dtgListaDespachos.CurrentRow.Cells("CANTIDAD").Value), objSeguridadBN.pUsuario)
            If dtgListaDespachos.CurrentRow.Cells("CHK").Value Then
                Me.dtgStockAlmacen.Columns("QALMACEN").Visible = True
            Else
                Me.dtgStockAlmacen.Columns("QALMACEN").Visible = False
            End If


            ListarLotes()

            If UcLote1.RowCount = 0 Then
                btnOcultarLote.Text = "Ocultar"
                btnOcultarLote_Click(sender, e)
                If "" & Me.dtgStockAlmacen.CurrentRow.Cells("D_CTPALM").Value & "" <> "" Then
                    UcUbicacion.ConsultarDespachos(pobePedidoPorPlanta.PNCDPEPL, Me.dtgListaDespachos.CurrentRow.Cells("PNNORDSR").Value, "" & Me.dtgStockAlmacen.CurrentRow.Cells("D_CTPALM").Value & "", "" & Me.dtgStockAlmacen.CurrentRow.Cells("D_CALMC").Value & "", "" & Me.dtgStockAlmacen.CurrentRow.Cells("D_CZNALM").Value & "", Val(Me.dtgListaDespachos.CurrentRow.Cells("CANTIDAD").Value), objSeguridadBN.pUsuario, False, dtgListaDespachos.Rows.IndexOf(dtgListaDespachos.CurrentRow))
                End If

            Else
                btnOcultarLote.Text = "Mostrar"
                UcLote1.Visible = True
                btnOcultarLote_Click(sender, e)
            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub dtgListaDespachos_CellValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dtgListaDespachos.CellValidating
        Try
            If Not pboolEstadoValidating Then Exit Sub
            Dim strError As String = ""
            Dim decQta As Decimal = 0
            Dim decPeso As Decimal = 0
            Dim bolCheck As Boolean = False
            If Not Me.dtgListaDespachos.CurrentRow.Cells("CHK").Value Then
                Exit Sub
            End If
            If dtgListaDespachos.Columns(e.ColumnIndex).Name = "CANTIDAD" Then


                If Not IsNumeric(e.FormattedValue) Then
                    strError = "- Digite cantidad correcta" & Chr(10)
                    '  dtgListaDespachos.CurrentRow.Cells("CANTIDAD").ErrorText = strError
                Else
                    If Val(e.FormattedValue) = 0 Then
                        dtgListaDespachos.CurrentRow.Cells("CANTIDAD").ErrorText = " Digite cantidad mayor a cero"
                    Else
                        dtgListaDespachos.CurrentRow.Cells("CANTIDAD").ErrorText = ""
                    End If
                    If e.FormattedValue > dtgListaDespachos.CurrentRow.Cells("PNQSRVC").Value Then
                        strError = "- Cantidad  digitada excede al pedido " & Chr(10)
                    End If
                    Dim SumCantAtender As Decimal = 0
                    Dim CodMerc As String = ""
                    Dim Saldo As Decimal = 0
                    CodMerc = dtgListaDespachos.CurrentRow.Cells("PSCMRCLR").Value
                    Saldo = dtgListaDespachos.CurrentRow.Cells("PNSALDO").Value
                    SumCantAtender = e.FormattedValue
                    For Each oDrv As DataGridViewRow In Me.dtgListaDespachos.Rows
                        If oDrv.Cells("CHK").Value Then
                            If oDrv.Cells("PSCMRCLR").Value = CodMerc And oDrv.Index <> dtgListaDespachos.CurrentRow.Index Then
                                SumCantAtender += oDrv.Cells(9).Value
                                If SumCantAtender > Saldo Then
                                    Exit For
                                End If
                            End If

                        End If
                    Next
                    If SumCantAtender > Saldo Then
                        SumCantAtender = 0
                        Saldo = 0
                        strError = strError & "-Cantidad a atender excede al saldo en Almacén."
                    Else
                        SumCantAtender = 0
                        Saldo = 0
                    End If

                    If strError = String.Empty And Val(e.FormattedValue) <> Val(dtgListaDespachos.CurrentRow.Cells("CANTIDAD").Value.ToString()) Then
                        UcUbicacion.ResetearDespachosLotes(pobePedidoPorPlanta.PNCDPEPL, _
                        Me.dtgListaDespachos.CurrentRow.Cells("PNNORDSR").Value, _
                        "" & Me.dtgListaDespachos.CurrentRow.Cells("PSCTPALM").Value & "", _
                        "" & Me.dtgListaDespachos.CurrentRow.Cells("PSCALMC").Value & "", _
                         "" & Me.dtgStockAlmacen.CurrentRow.Cells("D_CZNALM").Value & "", _
                        UcLote1.CantidadAtendida, _
                        objSeguridadBN.pUsuario, False, _
                        dtgListaDespachos.Rows.IndexOf(dtgListaDespachos.CurrentRow), UcLote1.RowCount)


                        UcLote1.ResetearCantidades()
                        ListarLotes()
                    End If
                End If

            End If

            If dtgListaDespachos.Columns(e.ColumnIndex).Name = "PESO" Then
                If Not IsNumeric(e.FormattedValue) Then
                    strError = "- Digite cantidad correcta" & Chr(10)
                Else
                    If Val(e.FormattedValue) > dtgListaDespachos.CurrentRow.Cells("PNQSLMP").Value Then
                        strError = "- Digite peso correcto" & Chr(10)
                    End If
                End If
            End If
            If strError.Trim.Length > 0 Then
                e.Cancel = True
                HelpClass.MsgBox(strError, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Sub txtManChoferes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtManChoferes.Click
        Try
            If txtEmpresaTransporte.Tag(1) = String.Empty Or txtEmpresaTransporte.Tag(1) = "0" Then Return
            Dim ofrmCamion As New frmCamion
            ofrmCamion.CTRSP = Convert.ToInt32(Me.txtEmpresaTransporte.Tag(1))
            If ofrmCamion.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.txtUnidad.Text = ofrmCamion.Placa
                Me.txtUnidad.Tag(0) = ofrmCamion.Placa
                Me.txtUnidad_Validating(Nothing, Nothing)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtMantCamiones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMantCamiones.Click
        Try
            If txtEmpresaTransporte.Tag(1) = "0" Or txtEmpresaTransporte.Tag(1) = String.Empty Then Return
            Dim ofrmChofer As New frmChofer
            ofrmChofer.CTRSP = Convert.ToInt32(Me.txtEmpresaTransporte.Tag(1))
            If ofrmChofer.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.txtBrevete.Text = ofrmChofer.Brevete
                txtBrevete.Tag(0) = ofrmChofer.Brevete
                txtBrevete_Validating(Nothing, Nothing)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ucSerie_VizualizarSerie() Handles ucSerie.VizualizarSerie
        Try
            If dtgListaDespachos.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Dim ofrmRegistrarSerie As New frmRegistrarSerie
            Dim index As Int32 = dtgListaDespachos.CurrentCellAddress.Y
            ofrmRegistrarSerie.PNCANTIDAD = dtgListaDespachos.Item("CANTIDAD", index).Value
            ofrmRegistrarSerie.PNCCLNT = pobePedidoPorPlanta.PNCCLNT
            ofrmRegistrarSerie.PNNGUIRN = 0
            ofrmRegistrarSerie.PNNORDSR = dtgListaDespachos.Item("PNNORDSR", index).Value
            ofrmRegistrarSerie.PNNRITOC = 0
            ofrmRegistrarSerie.PSUSUARIO = objSeguridadBN.pUsuario
            ofrmRegistrarSerie.PNFILA_REG = dtgListaDespachos.CurrentRow.Index

            Dim OrdenServicio As Int64 = Me.dtgListaDespachos.CurrentRow.Cells("PNNORDSR").Value
            Dim ItemPedido As Int64 = dtgListaDespachos.CurrentRow.Cells("PNCDREGP").Value
            Dim CantTrx As Decimal = Me.dtgListaDespachos.CurrentRow.Cells("CANTIDAD").Value

            If ofrmRegistrarSerie.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                'ucSerie.EliminarSeries(Me.dtgListaDespachos.CurrentRow.Cells("PNNORDSR").Value, dtgListaDespachos.CurrentRow.Cells("PNCDREGP").Value)
                'ucSerie.DespachoSeries(pobePedidoPorPlanta.PNCDPEPL, Me.dtgListaDespachos.CurrentRow.Cells("PNNORDSR").Value, dtgListaDespachos.CurrentRow.Cells("PNCDREGP").Value, Val(Me.dtgListaDespachos.CurrentRow.Cells("CANTIDAD").Value), objSeguridadBN.pUsuario)
                ucSerie.EliminarSeries(OrdenServicio, ItemPedido)
                ucSerie.DespachoSeries(pobePedidoPorPlanta.PNCDPEPL, OrdenServicio, ItemPedido, Val(CantTrx), objSeguridadBN.pUsuario)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ListaDeAlmacenesConCheckPorOrdenDeServicio(ByVal intTipos As Integer, Optional ByVal dblCantidad As Double = 0)
        Try
            If Me.dtgStockAlmacen.CurrentCellAddress.Y < 0 Then Exit Sub
            Dim olbeKardex As New List(Of beKardex)
            Me.dtgStockAlmacen.EndEdit()
            Dim dblSumaCantidad As Double = 0
            Dim dblSumPeso As Double = 0



            If intTipos = 0 Then
                If dtgStockAlmacen.RowCount = 1 Then
                    If Me.dtgStockAlmacen.Rows(0).Cells("D_QSLMC2").Value >= Me.dtgListaDespachos.CurrentRow.Cells("CANTIDAD").Value AndAlso Me.dtgStockAlmacen.Rows(0).Cells("D_QSLMP2").Value >= Me.dtgListaDespachos.CurrentRow.Cells("PESO").Value Then
                        Me.dtgStockAlmacen.Rows(0).Cells("QALMACEN").Value = Me.dtgListaDespachos.CurrentRow.Cells("CANTIDAD").Value
                        Me.dtgStockAlmacen.Rows(0).Cells("D_QAUTPS").Value = Val("" & Me.dtgListaDespachos.CurrentRow.Cells("PESO").Value & "")
                        olbeKardex = New List(Of beKardex)
                        Dim obeKardex As New beKardex
                        With obeKardex
                            .PSCTPALM = dtgStockAlmacen.Rows(0).Cells("D_CTPALM").Value
                            .PSTALMC = dtgStockAlmacen.Rows(0).Cells("D_TALMC").Value
                            .PSCALMC = dtgStockAlmacen.Rows(0).Cells("D_CALMC").Value

                            .PSTCMPAL = dtgStockAlmacen.Rows(0).Cells("D_TCMPAL").Value

                            .PSCZNALM = dtgStockAlmacen.Rows(0).Cells("D_CZNALM").Value
                            .PNQSLMC2 = dtgStockAlmacen.Rows(0).Cells("QALMACEN").Value
                            .PNQSLMP2 = dtgStockAlmacen.Rows(0).Cells("D_QAUTPS").Value
                            .PSTCMZNA = dtgStockAlmacen.Rows(0).DataBoundItem.Item("TCMZNA")
                            dblSumaCantidad += .PNQSLMC2
                            dblSumPeso += .PNQSLMP2
                            olbeKardex.Add(obeKardex)
                        End With
                        dtgListaDespachos.CurrentRow.Cells("SALDOALMACEN").Value = dblSumaCantidad
                        dtgListaDespachos.CurrentRow.Cells("PESOALMACEN").Value = dblSumPeso
                        dtgListaDespachos.CurrentRow.Tag = olbeKardex
                    End If
                ElseIf Not (dtgListaDespachos.CurrentRow.Tag Is Nothing) Then
                    olbeKardex = CType(dtgListaDespachos.CurrentRow.Tag, List(Of beKardex))
                    For intRow As Integer = 0 To Me.dtgStockAlmacen.Rows.Count - 1
                        For Each obeKardex As beKardex In olbeKardex
                            If obeKardex.PSCTPALM = dtgStockAlmacen.Rows(intRow).Cells("D_CTPALM").Value And _
                                obeKardex.PSCALMC = dtgStockAlmacen.Rows(intRow).Cells("D_CALMC").Value And _
                                obeKardex.PSCZNALM = dtgStockAlmacen.Rows(intRow).Cells("D_CZNALM").Value Then
                                Me.dtgStockAlmacen.Rows(intRow).Cells("QALMACEN").Value = obeKardex.PNQSLMC2
                                Me.dtgStockAlmacen.Rows(intRow).Cells("D_QAUTPS").Value = obeKardex.PNQSLMP2
                                dblSumaCantidad += obeKardex.PNQSLMC2
                                dblSumPeso += obeKardex.PNQSLMP2
                            End If
                        Next
                    Next
                    If dblSumaCantidad > dtgListaDespachos.CurrentRow.Cells("CANTIDAD").Value OrElse dblSumPeso > dtgListaDespachos.CurrentRow.Cells("PESO").Value Then
                        For intRow As Integer = 0 To Me.dtgStockAlmacen.Rows.Count - 1
                            Me.dtgStockAlmacen.Rows(intRow).Cells("QALMACEN").Value = 0D
                            Me.dtgStockAlmacen.Rows(intRow).Cells("D_QAUTPS").Value = 0D
                        Next
                        dblSumaCantidad = 0
                        dblSumPeso = 0
                        dtgListaDespachos.CurrentRow.Tag = Nothing
                    End If

                    dtgListaDespachos.CurrentRow.Cells("SALDOALMACEN").Value = dblSumaCantidad
                    dtgListaDespachos.CurrentRow.Cells("PESOALMACEN").Value = dblSumPeso
                End If
            Else
                olbeKardex = New List(Of beKardex)
                For intRow As Integer = 0 To Me.dtgStockAlmacen.Rows.Count - 1
                    If Me.dtgStockAlmacen.Rows(intRow).Cells("QALMACEN").Value <> 0 Then
                        Dim obeKardex As New beKardex
                        With obeKardex
                            .PSCTPALM = dtgStockAlmacen.Rows(intRow).Cells("D_CTPALM").Value
                            .PSCALMC = dtgStockAlmacen.Rows(intRow).Cells("D_CALMC").Value

                            .PSTCMPAL = dtgStockAlmacen.Rows(intRow).Cells("D_TCMPAL").Value
                            .PSTALMC = dtgStockAlmacen.Rows(intRow).Cells("D_TALMC").Value

                            .PSCZNALM = dtgStockAlmacen.Rows(intRow).Cells("D_CZNALM").Value
                            .PNQSLMC2 = dtgStockAlmacen.Rows(intRow).Cells("QALMACEN").Value
                            .PNQSLMP2 = dtgStockAlmacen.Rows(intRow).Cells("D_QAUTPS").Value
                            .PSTCMZNA = ("" & dtgStockAlmacen.Rows(intRow).DataBoundItem.Item("TCMZNA").ToString.Trim).Trim
                            dblSumaCantidad += .PNQSLMC2
                            dblSumPeso += .PNQSLMP2
                            olbeKardex.Add(obeKardex)
                        End With
                    End If
                Next
                dtgListaDespachos.CurrentRow.Cells("SALDOALMACEN").Value = dblSumaCantidad
                dtgListaDespachos.CurrentRow.Cells("PESOALMACEN").Value = dblSumPeso
                dtgListaDespachos.CurrentRow.Cells("CANTIDAD").ErrorText = ""
                dtgListaDespachos.CurrentRow.Tag = olbeKardex
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub dtgStockAlmacen_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgStockAlmacen.CellEndEdit
        ListaDeAlmacenesConCheckPorOrdenDeServicio(1)
    End Sub

    Private Sub dtgStockAlmacen_CellValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dtgStockAlmacen.CellValidating
        Try
            If Not pboolEstadoValidating Then Exit Sub
            Select Case e.ColumnIndex
                Case 9
                    If Not IsNumeric(e.FormattedValue) Then
                        e.Cancel = True
                        Exit Sub
                    End If
                    If dtgStockAlmacen.CurrentRow.Cells("D_QSLMC2").Value < Val(e.FormattedValue) Then
                        HelpClass.MsgBox("Canitidad  digitada excede al saldo en Almacén", MessageBoxIcon.Warning)
                        e.Cancel = True
                        Exit Sub
                    End If
                    Dim dblSuma As Double = 0
                    For intRows As Integer = 0 To Me.dtgStockAlmacen.RowCount - 1
                        If intRows <> e.RowIndex Then
                            dblSuma = dblSuma + Me.dtgStockAlmacen.Rows(intRows).Cells("QALMACEN").Value
                        End If
                    Next
                    dblSuma = dblSuma + Val(e.FormattedValue)
                    If dblSuma > Me.dtgListaDespachos.CurrentRow.Cells("CANTIDAD").Value Then
                        HelpClass.MsgBox("cantidad despachar excede a cantidad atender.", MessageBoxIcon.Warning)
                        e.Cancel = True
                    End If
                Case 12

                    If Not IsNumeric(e.FormattedValue) Then
                        e.Cancel = True
                        Exit Sub
                    End If
                    If dtgStockAlmacen.CurrentRow.Cells("D_QSLMP2").Value < Val(e.FormattedValue) Then
                        HelpClass.MsgBox("cantidad  digitada excede al Peso en Almacén", MessageBoxIcon.Warning)
                        e.Cancel = True
                        Exit Sub
                    End If
                    Dim dblSuma As Double = 0
                    For intRows As Integer = 0 To Me.dtgStockAlmacen.RowCount - 1
                        If intRows <> e.RowIndex Then
                            dblSuma = dblSuma + Me.dtgStockAlmacen.Rows(intRows).Cells("D_QAUTPS").Value
                        End If
                    Next
                    dblSuma = dblSuma + Val(e.FormattedValue)
                    If dblSuma > Me.dtgListaDespachos.CurrentRow.Cells("PESO").Value Then
                        HelpClass.MsgBox("Peso despachar excede al Peso atender.", MessageBoxIcon.Warning)
                        e.Cancel = True
                    End If

            End Select


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub


    'Private Sub btnObservaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnObservaciones.Click
    'If Me.dtgListaDespachos.CurrentCellAddress.Y < 0 Then Exit Sub

    'Dim objfrmObservacionesPedido As New frmObservacionesPedido
    ''objfrmObservacionesPedido.getData = objListado
    'objfrmObservacionesPedido.TipoOperacion = "Modificar"
    'objfrmObservacionesPedido.NroPedido = Me.dtgListaDespachos.CurrentRow.Cells("PNCDPEPL").Value
    'objfrmObservacionesPedido.NroCorrelativo = Me.dtgListaDespachos.CurrentRow.Cells("PNCDREGP").Value
    'objfrmObservacionesPedido.CodigoMercaderia = Me.dtgListaDespachos.CurrentRow.Cells("PSCMRCLR").Value
    'objfrmObservacionesPedido.NombreMercaderia = Me.dtgListaDespachos.CurrentRow.Cells("PSTMRCD2").Value
    'objfrmObservacionesPedido.CantidadMercaderia = Me.dtgListaDespachos.CurrentRow.Cells("PNSALDO").Value
    'If objfrmObservacionesPedido.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
    'End If
    ' End Sub

    Private Sub txtOrigen_CambioDeTexto(ByVal objData As Object) Handles txtOrigen.CambioDeTexto
        If Not objData Is Nothing Then
            UcClienteTerceroDestino.CodCliente = pobePedidoPorPlanta.PNCCLNT
            UcClienteTerceroDestino.TipoRelacion = CType(Me.txtOrigen.Resultado, beGeneral).PSCCMPRN.Trim
            UcClienteTerceroDestino.pClear()
        End If
    End Sub

    Private Sub txtTipoDesOutotec_CambioDeTexto(ByVal objData As System.Object) Handles txtTipoDesOutotec.CambioDeTexto
        If Not objData Is Nothing Then
            ValidarTipoDespacho()
        Else
            Me.txtCliente.Visible = False
            Me.KryptonLabel3.Visible = False
            txtOrigen.Valor = ""
            txtOrigen.Refresh()
            txtOrigen.Enabled = True
            txtTipoDoc.Valor = ""
            txtTipoDoc.Refresh()
            txtTipoDoc.Enabled = True
            tbpSet.Parent = Nothing
            pnlPedido.Location = New System.Drawing.Point(483, 38)
        End If
    End Sub

    Private Sub dtgSet_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgSet.CellEndEdit
        dtgSet.Rows(e.RowIndex).ErrorText = String.Empty
    End Sub

    Private Sub dtgSet_CellValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dtgSet.CellValidating

        Select Case dtgSet.Columns(e.ColumnIndex).Name
            Case "PNQTRMC1"
                If Not IsNumeric(e.FormattedValue) Then
                    dtgSet.Rows(e.RowIndex).ErrorText = "Ingrese solo números"
                    e.Cancel = True
                    Exit Sub
                End If
            Case "PSCMRCLR1"
                If String.IsNullOrEmpty(e.FormattedValue.ToString.Trim()) Then
                    dtgSet.Rows(e.RowIndex).ErrorText = "Ingrese un codigo"
                    e.Cancel = True
                End If
            Case "PSTMRCD3"
                If String.IsNullOrEmpty(e.FormattedValue.ToString.Trim()) Then
                    dtgSet.Rows(e.RowIndex).ErrorText = "Ingrese una descripción"
                    e.Cancel = True
                End If
            Case "PSCUNCN_6"
                If String.IsNullOrEmpty(e.FormattedValue.ToString.Trim()) Then
                    dtgSet.Rows(e.RowIndex).ErrorText = "Ingrese una unidad"
                    e.Cancel = True
                End If

        End Select
    End Sub

    Private Sub btnAgregarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarProducto.Click

        Dim dtrow As New DataGridViewRow
        dtgSet.Rows.Add(dtrow)


    End Sub

    Private Sub dtgSet_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtgSet.EditingControlShowing

        If dtgSet.CurrentCell.ColumnIndex = 2 Then
            If TypeOf e.Control Is TextBox Then
                Dim txt As TextBox = TryCast(e.Control, TextBox)

                If txt IsNot Nothing Then

                    AddHandler txt.KeyPress, AddressOf dtgSet_KeyPress
                End If

            End If
        End If

    End Sub

    Private Sub dtgSet_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtgSet.KeyPress

        If dtgSet.CurrentCell.ColumnIndex = 3 Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
        End If

    End Sub
    Private Sub bsaEliminarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaEliminarItem.Click
        Try
            If MessageBox.Show("Desea anular el registro", "Anular", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If Anular() Then
                    Me.ListaDespachoMercaderia(pobePedidoPorPlanta)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub UcLote1_CambiarCantidad(ByVal sender As Object, ByVal e As System.EventArgs) Handles UcLote1.CambiarCantidad
        Try
            If "" & Me.dtgStockAlmacen.CurrentRow.Cells("D_CTPALM").Value & "" <> "" Then
                UcUbicacion.ResetearCantidades(pobePedidoPorPlanta.PNCDPEPL, _
                     Me.dtgListaDespachos.CurrentRow.Cells("PNNORDSR").Value, _
                     "" & Me.dtgStockAlmacen.CurrentRow.Cells("D_CTPALM").Value & "", _
                     "" & Me.dtgStockAlmacen.CurrentRow.Cells("D_CALMC").Value & "", _
                    "" & Me.dtgStockAlmacen.CurrentRow.Cells("D_CZNALM").Value & "", _
                     UcLote1.CantidadAtendida, _
                     objSeguridadBN.pUsuario, False, _
                     dtgListaDespachos.Rows.IndexOf(dtgListaDespachos.CurrentRow), UcLote1.NumeroLote.ToString())
                UcLote1_SelectionChanged(sender, e)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Sub UcLote1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UcLote1.SelectionChanged
        Try
            If "" & Me.dtgStockAlmacen.CurrentRow.Cells("D_CTPALM").Value & "" <> "" Then
                UcUbicacion.ConsultarDespachos(pobePedidoPorPlanta.PNCDPEPL, _
                     Me.dtgListaDespachos.CurrentRow.Cells("PNNORDSR").Value, _
                     "" & Me.dtgStockAlmacen.CurrentRow.Cells("D_CTPALM").Value & "", _
                     "" & Me.dtgStockAlmacen.CurrentRow.Cells("D_CALMC").Value & "", _
                       "" & Me.dtgStockAlmacen.CurrentRow.Cells("D_CZNALM").Value & "", _
                     UcLote1.CantidadAtendida, _
                     objSeguridadBN.pUsuario, False, _
                     dtgListaDespachos.Rows.IndexOf(dtgListaDespachos.CurrentRow), UcLote1.NumeroLote.ToString())
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnInterfaz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInterfaz.Click
        Try
            InterfazDespacho()
            SplitDistance = 600
            If dtgListaDespachos.Rows.Count = 0 Then
                btnOcultarLote.Text = "Ocultar"
                btnOcultarLote_Click(sender, e)
                btnDespacha.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                bsaEliminarItem.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            Else
                If Not bolError Then
                    btnDespacha.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                    bsaEliminarItem.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                    UcLote1.Limpiar()
                    ListarLotes()
                    dtgListaDespachos_SelectionChanged(sender, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub InterfazDespacho()
        Dim obrDespacho As New brDespacho
        Dim dsInformacionDespacho As New DataSet

        SplitDistance = KryptonSplitContainer1.SplitterDistance

        Dim objDatos As New beInferfazSapPedido
        GLOBAL_COMPANIA = "EZ"
        objDatos.CCMPN = GLOBAL_COMPANIA
        objDatos.CCLNT = Me.intCCLNT
        objDatos.CRGVTA = obrDespacho.strObtenerCodigoRegionVenta(objDatos)
        objDatos.PSNUMDES = _PSNUMDES
        objDatos.DCENSA = txtNroGuiaCliente.Text.Trim
        Dim msgError As String = String.Empty
        dsInformacionDespacho = obrDespacho.fdtOntenerInformacionDespachoInterfazSAP(objDatos, msgError)
        Dim dt As New DataTable
        If String.IsNullOrEmpty(msgError) Then
            dt = dsInformacionDespacho.Tables(1)
            If dt.Rows.Count > 0 Then
                'ListaDespachoMercaderia(pobePedidoPorPlanta, dt)
                ListaDespachoMercaderia(pobePedidoPorPlanta)
            Else
                btnDespacha.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                MessageBox.Show("No Existe el Nro. Doc. SAP", "Interfaz Pedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show(msgError, "Interfaz Pedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub btnOcultarLote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOcultarLote.Click
        If btnOcultarLote.Text = "Ocultar" Then
            btnOcultarLote.Text = "Mostrar"
            khgOcultarLote.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Left
            btnOcultarLote.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.FixedRight
            'btnOcultarLote.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp


            If UcLote1.RowCount = 0 Then
                khgOcultarLote.ValuesPrimary.Heading = " "
                btnVacio.Visible = True
                btnOcultarLote.Visible = False
                UcLote1.Visible = False
            Else
                khgOcultarLote.ValuesPrimary.Heading = "Lotes"
                btnVacio.Visible = False
                btnOcultarLote.Visible = True
                UcLote1.Visible = True
            End If
            SplitDistance = KryptonSplitContainer1.SplitterDistance
            If KryptonSplitContainer1.SplitterDistance > 700 Then
                SplitDistance = 600
            End If
            KryptonSplitContainer1.SplitterDistance = KryptonSplitContainer1.Width - 28



            KryptonSplitContainer1.SplitterWidth = 0
        Else
            If UcLote1.RowCount = 0 Or dtgListaDespachos.Rows.Count = 0 Then
                khgOcultarLote.ValuesPrimary.Heading = " "
                btnVacio.Visible = True
                btnOcultarLote.Visible = False
                UcLote1.Visible = False
            Else
                khgOcultarLote.ValuesPrimary.Heading = "Lotes"
                btnVacio.Visible = False
                btnOcultarLote.Visible = True
                UcLote1.Visible = True

            End If
            btnOcultarLote.Text = "Ocultar"

            khgOcultarLote.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
            btnOcultarLote.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.Inherit
            'btnOcultarLote.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowLeft
            If SplitDistance > 0 Then KryptonSplitContainer1.SplitterDistance = SplitDistance
            KryptonSplitContainer1.SplitterWidth = 5
        End If
    End Sub

    Private Sub btnReportePrueba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReportePrueba.Click
        Try
            Dim objFiltro As New beDespacho
            With objFiltro
                .PNCCLNT = 16168
                .PNNGUIRN = 1101399830
                .pRazonSocial = "CLIENTE DE PRUEBA"
            End With
            mReporteIngSalRansa(objFiltro)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub dtgStockAlmacen_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgStockAlmacen.SelectionChanged
        Try

            'CSR-HUNDRED-INICIO
            dtgStockAlmacen.EndEdit()
            If dtgListaDespachos.CurrentRow IsNot Nothing And dtgStockAlmacen.CurrentRow IsNot Nothing Then


                Dim CodTipoAlm As String = ("" & dtgStockAlmacen.CurrentRow.Cells("D_CTPALM").Value).ToString.Trim
                Dim CodAlm As String = ("" & dtgStockAlmacen.CurrentRow.Cells("D_CALMC").Value).ToString.Trim
                Dim CodZona As String = ("" & dtgStockAlmacen.CurrentRow.Cells("D_CZNALM").Value).ToString.Trim
                Dim OrdenServ As Int64 = dtgStockAlmacen.CurrentRow.Cells("D_NORDSR").Value
                Dim NumPed As Int64 = Me.dtgListaDespachos.CurrentRow.Cells("PNCDPEPL").Value
                ' se adicionó fecha 201905 '
                ' para recuperar la cantidad de despacho a nivel de almacén
                '-----------------------------------------------
                Dim QCantidadDespacho As Decimal = 0
                Dim PesoDespacho As Decimal = 0
                Dim olbeKardex As New List(Of beKardex)
                olbeKardex = CType(dtgListaDespachos.CurrentRow.Tag, List(Of beKardex))
                If olbeKardex IsNot Nothing Then
                    For Each obeKardex As beKardex In olbeKardex
                        'If obeKardex.PSCTPALM = dtgStockAlmacen.CurrentRow.Cells("D_CTPALM").Value And _
                        '    obeKardex.PSCALMC = dtgStockAlmacen.CurrentRow.Cells("D_CALMC").Value And _
                        '    obeKardex.PSCZNALM = dtgStockAlmacen.CurrentRow.Cells("D_CZNALM").Value Then
                        '    QCantidadDespacho = obeKardex.PNQSLMC2
                        '    PesoDespacho = obeKardex.PNQSLMP2
                        'End If
                        If obeKardex.PSCTPALM = CodTipoAlm And obeKardex.PSCALMC = CodAlm And obeKardex.PSCZNALM = CodZona Then
                            QCantidadDespacho = obeKardex.PNQSLMC2
                            PesoDespacho = obeKardex.PNQSLMP2
                        End If

                    Next
                End If
                '-------------------------------------------------


                Dim QDespachar As Decimal = 0D
                If Me.dtgStockAlmacen.CurrentRow.Cells("QALMACEN").Value IsNot Nothing Then
                    QDespachar = Me.dtgStockAlmacen.CurrentRow.Cells("QALMACEN").Value
                End If

                If QDespachar = 0 Then
                    QDespachar = QCantidadDespacho
                End If


                If UcLote1.NumeroLote.ToString() > 0 Then
                    'UcUbicacion.ConsultarDespachos(Me.dtgListaDespachos.CurrentRow.Cells("PNCDPEPL").Value, _
                    '                                  Me.dtgStockAlmacen.CurrentRow.Cells("D_NORDSR").Value, _
                    '                                  "" & Me.dtgStockAlmacen.CurrentRow.Cells("D_CTPALM").Value & "", _
                    '                                  "" & Me.dtgStockAlmacen.CurrentRow.Cells("D_CALMC").Value & "", _
                    '                                  "" & Me.dtgStockAlmacen.CurrentRow.Cells("D_CZNALM").Value & "", _
                    '                                 QDespachar, _
                    '                                  objSeguridadBN.pUsuario, False, _
                    '                                  dtgListaDespachos.Rows.IndexOf(dtgListaDespachos.CurrentRow), UcLote1.NumeroLote.ToString())

                    UcUbicacion.ConsultarDespachos(NumPed, _
                                                    OrdenServ, _
                                                     "" & CodTipoAlm & "", _
                                                     "" & CodAlm & "", _
                                                     "" & CodZona & "", _
                                                    QDespachar, _
                                                     objSeguridadBN.pUsuario, False, _
                                                     dtgListaDespachos.Rows.IndexOf(dtgListaDespachos.CurrentRow), UcLote1.NumeroLote.ToString())

                Else
                    'UcUbicacion.ConsultarDespachos(Me.dtgListaDespachos.CurrentRow.Cells("PNCDPEPL").Value, _
                    '                           Me.dtgStockAlmacen.CurrentRow.Cells("D_NORDSR").Value, _
                    '                           "" & Me.dtgStockAlmacen.CurrentRow.Cells("D_CTPALM").Value & "", _
                    '                           "" & Me.dtgStockAlmacen.CurrentRow.Cells("D_CALMC").Value & "", _
                    '                           "" & Me.dtgStockAlmacen.CurrentRow.Cells("D_CZNALM").Value & "", _
                    '                          QDespachar, _
                    '                           objSeguridadBN.pUsuario, False, _
                    '                           dtgListaDespachos.Rows.IndexOf(dtgListaDespachos.CurrentRow))

                    UcUbicacion.ConsultarDespachos(NumPed, _
                                          OrdenServ, _
                                           "" & CodTipoAlm & "", _
                                           "" & CodAlm & "", _
                                           "" & CodZona & "", _
                                          QDespachar, _
                                           objSeguridadBN.pUsuario, False, _
                                           dtgListaDespachos.Rows.IndexOf(dtgListaDespachos.CurrentRow))

                End If



            End If
            'CSR-HUNDRED-FIN
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class