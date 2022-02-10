Imports RANSA.NEGO.slnSOLMIN_SDS
Imports RANSA.NEGO
Imports RANSA.TYPEDEF
Imports RANSA.Utilitario

Public Class frmSolicInforRecTransferencia

#Region " Tipo de Datos "

#End Region
#Region " Atributos Nuevos"


 
#End Region

#Region " Atributos "
    Private bolEsClienteOutotec As Boolean = False
 
#End Region

#Region " Propiedades "

    Private _intCCLNT As Integer
    Public Property pintCCLNT() As Integer
        Get
            Return _intCCLNT
        End Get
        Set(ByVal value As Integer)
            _intCCLNT = value
        End Set
    End Property

    Private _pintServicio_CSRVC As Integer
    Public Property pintServicio_CSRVC() As Integer
        Get
            Return _pintServicio_CSRVC
        End Get
        Set(ByVal value As Integer)
            _pintServicio_CSRVC = value
        End Set
    End Property
    Private strTCMPCL As String
    ' Razon Social del Cliente
    ''' <summary>
    ''' Razón social del cliente
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    Public WriteOnly Property pstrRazonSocialCliente() As String
        Set(ByVal value As String)
            strTCMPCL = value
        End Set
    End Property

    Private strCCMPN As String
    ''' <summary>
    ''' compañia
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    Public WriteOnly Property pstrCCMPN() As String
        Set(ByVal value As String)
            strCCMPN = value
        End Set
    End Property

    Private strCDVSN As String
    ''' <summary>
    ''' División
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    Public WriteOnly Property pstrCDVSN() As String
        Set(ByVal value As String)
            strCDVSN = value
        End Set
    End Property

    Private _PNNORSCI As Decimal = 0
    Private intNroGuiaRansa As Decimal = 0
#End Region

#Region " Funciones y Procedimientos "

    Private Function fblnValidarInfItemRecepcion() As Boolean
        Dim strResultado As String = ""

        Dim blnResultado As Boolean = True
        Dim obrGeneral As New Ransa.NEGO.brGeneral


        If txtNroGuiaCliente.Text.Trim = "" Or txtNroGuiaCliente.Text.Trim = "0" Then strResultado &= "- Debe ingresar Nro." & vbNewLine
        If txtTipoAlmacen.Resultado Is Nothing Then strResultado &= "- Debe seleccionar un Tipo de Almacén." & vbNewLine
        If txtAlmacen.Resultado Is Nothing Then strResultado &= "- Debe seleccionar un Almacén" & vbNewLine
        If txtZonaAlmacen.Resultado Is Nothing Then strResultado &= "- Debe seleccionar una Zona de Almacén." & vbNewLine
        If txtTipoMovimientoIng.Resultado Is Nothing Then strResultado &= "- Debe seleccionar el Tipo de Recepción." & vbNewLine
        If dtgMovimientos.RowCount = 0 Then strResultado &= "- No cuenta con mercadería para la transferencia ." & vbNewLine

        'Validamos si es devolucion
       

        If txtOrigen.Resultado Is Nothing Then strResultado &= "- Debe seleccionar el Tipo de Origen." & vbNewLine
        If txtTipoDoc.Resultado Is Nothing Then strResultado &= "- Debe seleccionar el Tipo de Doc. de origen." & vbNewLine
        If txtEmpresaTransporte.Resultado Is Nothing Then strResultado &= "- Debe seleccionar Empresa de Transporte. " & vbNewLine
        'Validamos que el clientes sea Outotec
        If txtZonaAlmacen.Text <> "" AndAlso bolEsClienteOutotec AndAlso Not txtTipoDoc.Resultado Is Nothing AndAlso Not txtOrigen.Resultado Is Nothing Then
            If UcClienteTerceroOrigen.ItemActual.PNCPRVCL = 0 OrElse UcClienteTerceroOrigen.ItemActual.PSCPRPCL = Nothing Then _
                        strResultado &= "- Debe de seleccionar el Ruc" & vbNewLine

            If UcClienteTerceroOrigen.ItemActual.PNCPRVCL <> 0 Then
                If CType(UcClienteTerceroOrigen.ItemActual, PlantaDeEntrega.bePlantaDeEntrega).PSCPRPCL.ToString.Trim = "" Then
                    strResultado &= "- El Ruc no cuenta con su equivalencia en la interfaz" & vbNewLine
                End If
            End If

            If CType(txtOrigen.Resultado, beGeneral).PSCCMPRN.Trim = "P" AndAlso UcClienteTerceroOrigen.ItemActual.PSCPRPCL <> Nothing Then
                Dim obrInterfaz As New brInterfazOutoTec
                Dim obeInterfaz As New beCabInfzOutotec
                With obeInterfaz
                    .cprove = CType(UcClienteTerceroOrigen.ItemActual, PlantaDeEntrega.bePlantaDeEntrega).PSCPRPCL.Trim
                    .calmac = obrGeneral.fstrAlmacenVituralOutotec(_intCCLNT, txtZonaAlmacen.Text.Trim.Substring(0, 2))
                End With
                If Not obrInterfaz.fintProveedorPerteneceAlmacen(obeInterfaz) Then
                    strResultado &= "- La Zona de Almacén no pertenece al proveedor. " & vbNewLine
                End If
            End If

        End If


        If strResultado <> "" Then
            MessageBox.Show(strResultado, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnResultado = False
        End If
        Return blnResultado
    End Function


    Private Sub CargarControles()

        Dim obrGeneral As New Ransa.NEGO.brGeneral
        bolEsClienteOutotec = obrGeneral.bolElClienteEsOutotec(_intCCLNT)

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "STPING"
        oColumnas.DataPropertyName = "PSSTPING"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TTPING"
        oColumnas.DataPropertyName = "PSTTPING"
        oColumnas.HeaderText = "Tipo Movimiento"
        oListColum.Add(2, oColumnas)


        txtTipoMovimientoIng.DataSource = obrGeneral.floListaTipoMovimientoRecepcionCliente(_intCCLNT)
        txtTipoMovimientoIng.ListColumnas = oListColum
        txtTipoMovimientoIng.Cargas()
        txtTipoMovimientoIng.ValueMember = "PSSTPING"
        txtTipoMovimientoIng.DispleyMember = "PSTTPING"
        txtTipoMovimientoIng.Valor = "T"


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

        txtOrigen.DataSource = obrGeneral.olTipoOrigen(_intCCLNT)
        txtOrigen.ListColumnas = oListColum
        txtOrigen.Cargas()
        txtOrigen.ValueMember = "PSCCMPRN"
        txtOrigen.DispleyMember = "PSTDSDES"
        txtOrigen.Valor = "A"
        txtOrigen.Refresh()


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
        oColumnas.HeaderText = "Documento de Origen"
        oListColum.Add(2, oColumnas)

        txtTipoDoc.DataSource = obrGeneral.olTipoDocumentoOrigen(_intCCLNT)
        txtTipoDoc.ListColumnas = oListColum
        txtTipoDoc.Cargas()
        txtTipoDoc.ValueMember = "PSCCMPRN"
        txtTipoDoc.DispleyMember = "PSTDSDES"
        txtTipoDoc.Valor = "PS"
        txtTipoDoc.Refresh()

        UcClienteTerceroOrigen.MostrarRuc = True
        UcClienteTerceroOrigen.CodCliente = _intCCLNT
        UcClienteTerceroOrigen.TipoRelacion = CType(Me.txtOrigen.Resultado, beGeneral).PSCCMPRN.Trim


        Dim obrTransportista As New brTransportista

        ''Tipo Documento origen
        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CTRSP"
        oColumnas.DataPropertyName = "PNCTRSP"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMPTR"
        oColumnas.DataPropertyName = "PSTCMPTR"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oColumnas.HeaderText = "Descripción Transportista"
        oListColum.Add(2, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TDRCTR"
        oColumnas.DataPropertyName = "PSTDRCTR"
        oColumnas.HeaderText = "Dirección"
        oListColum.Add(3, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "NRUCT"
        oColumnas.DataPropertyName = "PNNRUCT"
        oColumnas.HeaderText = "RUC"
        oListColum.Add(4, oColumnas)

        txtEmpresaTransporte.DataSource = obrTransportista.flstListarTodosTransportistaDS()
        txtEmpresaTransporte.ListColumnas = oListColum
        txtEmpresaTransporte.Cargas()
        txtEmpresaTransporte.ValueMember = "PNCTRSP"
        txtEmpresaTransporte.DispleyMember = "PSTCMPTR"
        txtEmpresaTransporte.PopupWidth = 650
        txtEmpresaTransporte.PopupHeight = 400

       




    End Sub

#End Region

#Region " Eventos "

    Private Sub frmSolicInforRecOCAlmacen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Container1.SuspendLayout()
        Container1.FixedPanel = FixedPanel.Panel2
        Container1.IsSplitterFixed = True
        Container1.Panel2MinSize = 0
        Container1.SplitterDistance = Me.Width - 25
        ToolStrip1.Visible = False
        Container1.ResumeLayout()
        CargarControles()
        CargarControlTipoAlmacen()

    End Sub


    Private Sub txtTipoAlmacen_CambioDeTexto(ByVal objData As Object) Handles txtTipoAlmacen.CambioDeTexto
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CALMC"
        oColumnas.DataPropertyName = "PSCALMC"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMPAL"
        oColumnas.DataPropertyName = "PSTCMPAL"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oColumnas.HeaderText = "Almacén "
        oListColum.Add(2, oColumnas)
        Dim obrAlmacen As New brAlmacen
        If Not objData Is Nothing Then
            CType(objData, beAlmacen).PNCPLNFC = 1
            txtAlmacen.DataSource = obrAlmacen.ListaAlmacen(objData)
        Else
            txtAlmacen.DataSource = Nothing
        End If
        txtAlmacen.ListColumnas = oListColum
        txtAlmacen.Cargas()
        txtAlmacen.Limpiar()
        txtAlmacen.ValueMember = "PSCALMC"
        txtAlmacen.DispleyMember = "PSTCMPAL"
    End Sub

    Private Sub txtAlmacen_CambioDeTexto(ByVal objData As Object) Handles txtAlmacen.CambioDeTexto
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CZNALM"
        oColumnas.DataPropertyName = "PSCZNALM"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMZNA"
        oColumnas.DataPropertyName = "PSTCMZNA"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oColumnas.HeaderText = "Zona Almacén "
        oListColum.Add(2, oColumnas)
        Dim obrAlmacen As New brAlmacen
        If Not objData Is Nothing Then
            txtZonaAlmacen.DataSource = obrAlmacen.ListaZonaDeAlmacen(objData)
        Else
            txtZonaAlmacen.DataSource = Nothing
        End If
        txtZonaAlmacen.ListColumnas = oListColum
        txtZonaAlmacen.Cargas()
        txtZonaAlmacen.Limpiar()
        txtZonaAlmacen.ValueMember = "PSCZNALM".Trim()
        txtZonaAlmacen.DispleyMember = "PSTCMZNA"
    End Sub

    Private Sub btnAgregarRecepcionItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strValidarCodEmb As String = ""
        If Not fblnValidarInfItemRecepcion() Then Exit Sub
        Me.pProcesarRegistroInfCabecera()
        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub



    Private Sub btnAdjuntarEmbarque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdjuntarEmbarque.Click
        Dim ofrmEmbarque As New frmEmbarqueAsociadosOC
        ofrmEmbarque.Cliente = _intCCLNT
        ofrmEmbarque.OrdeDeCompra = txtNroOrdenCompra.Text
        If ofrmEmbarque.ShowDialog = Windows.Forms.DialogResult.OK Then
            _PNNORSCI = ofrmEmbarque.Embarque
            Me.txtEmbarque.Text = ofrmEmbarque.Embarque
        End If
    End Sub



    Private Sub txtEmbarque_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmbarque.KeyPress
        If e.KeyChar = Chr(13) Then
            BuscarOcEnEmbarque()
        End If
    End Sub

    Private Sub BuscarOcEnEmbarque()
        Dim obeOrdenCompra As New beOrdenCompra
        Dim obrOrdenDeCompra As New brOrdenDeCompra
        With obeOrdenCompra
            .PNCCLNT = _intCCLNT
            .PSNORCML = txtNroOrdenCompra.Text
            .PNNORSCI = Val(txtEmbarque.Text)
        End With
        Dim olistOC As New List(Of beOrdenCompra)
        With obrOrdenDeCompra
            If .ListaEmbarquePorOC(obeOrdenCompra).Count = 0 Then
                Me.txtEmbarque.Text = 0
                MessageBox.Show("Embarque no Existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End With
    End Sub


   

    Private Sub txtOrigen_CambioDeTexto(ByVal objData As Object) Handles txtOrigen.CambioDeTexto
        If Not objData Is Nothing Then
            UcClienteTerceroOrigen.CodCliente = _intCCLNT
            UcClienteTerceroOrigen.TipoRelacion = CType(Me.txtOrigen.Resultado, beGeneral).PSCCMPRN.Trim
            UcClienteTerceroOrigen.pClear()
        End If
    End Sub

    Private Sub txtNroGuiaCliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroGuiaCliente.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(txtNroGuiaCliente.Text) = 0 Then Exit Sub
            Dim obeDespacho As New beDespacho
            With obeDespacho
                .PNCCLNT = _intCCLNT
                .PNNGUIRN = txtNroGuiaCliente.Text
            End With
            Dim obrDespacho As New brDespacho
            dtgMovimientos.AutoGenerateColumns = False
            Me.dtgMovimientos.DataSource = obrDespacho.flstListaItemsXGuiaRansaDespacho(obeDespacho)

        End If
    End Sub

    Private Sub txtEmpresaTransporte_CambioDeTexto(ByVal objData As System.Object) Handles txtEmpresaTransporte.CambioDeTexto

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn


        ''Tipo Documento origen
        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "NPLCCM"
        oColumnas.DataPropertyName = "PSNPLCCM"
        oColumnas.HeaderText = "Placa "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TMRCCM"
        oColumnas.DataPropertyName = "PSTMRCCM"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oColumnas.HeaderText = "Marca"
        oListColum.Add(2, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "NANOCM"
        oColumnas.DataPropertyName = "PNNANOCM"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oColumnas.HeaderText = "Año"
        oListColum.Add(3, oColumnas)

        If Not objData Is Nothing Then
            Dim obrCamion As New brCamion
            Dim obeCamionFiltro As New beCamionFiltro
            obeCamionFiltro.CTRSPSTR = CType(objData, beTransportista).PNCTRSP
            txtUnidad.DataSource = obrCamion.flisListarCamionxTransportista(obeCamionFiltro)
        Else
            txtUnidad.DataSource = Nothing
        End If
        txtUnidad.ListColumnas = oListColum
        txtUnidad.Cargas()
        txtUnidad.Limpiar()
        txtUnidad.ValueMember = "PSNPLCCM"
        txtUnidad.DispleyMember = "PSTMRCCM"



        ''Tipo Documento origen
        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "NBRVCH"
        oColumnas.DataPropertyName = "PSNBRVCH"
        oColumnas.HeaderText = "Brevete "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TNMBCH"
        oColumnas.DataPropertyName = "PSTNMBCH"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oColumnas.HeaderText = "Nombre Chofer"
        oListColum.Add(2, oColumnas)

        If Not objData Is Nothing Then
            Dim obrCamion As New brChofer
            Dim obeCamionFiltro As New beChoferFiltro
            obeCamionFiltro.CTRSPSTR = CType(objData, beTransportista).PNCTRSP
            txtBrevete.DataSource = obrCamion.flstListarChoferesxTransportista(obeCamionFiltro)
        Else
            txtBrevete.DataSource = Nothing
        End If
        txtBrevete.ListColumnas = oListColum
        txtBrevete.Cargas()
        txtBrevete.Limpiar()
        txtBrevete.ValueMember = "PSNBRVCH"
        txtBrevete.DispleyMember = "PSTNMBCH"


    End Sub

    Private Sub txtNroGuiaCliente_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNroGuiaCliente.Validating
        Try
            If Val(txtNroGuiaCliente.Text) = 0 Then
                txtNroGuiaCliente.Text = 0
                Exit Sub
            End If
            Dim obeDespacho As New beDespacho
            With obeDespacho
                .PNCCLNT = _intCCLNT
                .PNNGUIRN = txtNroGuiaCliente.Text
            End With
            Dim obrDespacho As New brDespacho
            dtgMovimientos.AutoGenerateColumns = False
            Me.dtgMovimientos.DataSource = obrDespacho.flstListaItemsXGuiaRansaDespacho(obeDespacho)

            If Me.dtgMovimientos.DataSource.Count = 0 Then
                MessageBox.Show("El no existe el Nro. Guía de Salida :" & txtNroGuiaCliente.Text, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                e.Cancel = True
            End If

        Catch : End Try
    End Sub

#End Region
#Region " Métodos "
    Private Sub pProcesarRegistroInfCabecera()
        Dim olistMercaderia As New List(Of beMercaderia)

        For Each obeDespacho As beDespacho In Me.dtgMovimientos.DataSource
            Dim obeMercaderia As New beMercaderia
            With obeDespacho
                obeMercaderia.PSCMRCD = .PSCMRCD
                obeMercaderia.PNNORDSR = .PNNORDSR
                obeMercaderia.PNNCNTR = .PNNCNTR
                obeMercaderia.PNNCRCTC = .PNNCRCTC
                obeMercaderia.PNNAUTR = .PNNAUTR
                obeMercaderia.PSCUNCNT = .PSCUNCN5
                obeMercaderia.PSCUNPST = .PSCUNPS5
                obeMercaderia.pSCUNVLT = .PSCUNVL5
                obeMercaderia.PSNORCCL = txtNroOrdenCompra.Text
                obeMercaderia.PSNGUICL = txtNroGuiaCliente.Text
                obeMercaderia.PSNRUCLL = CType(UcClienteTerceroOrigen.ItemActual, PlantaDeEntrega.bePlantaDeEntrega).PNNRUCPR
                obeMercaderia.PSSTPING = CType(txtTipoMovimientoIng.Resultado, beGeneral).PSSTPING
                obeMercaderia.PSCTPALM = "" & CType(txtTipoAlmacen.Resultado, beAlmacen).PSCTPALM
                obeMercaderia.PSTALMC = "" & CType(txtAlmacen.Resultado, beAlmacen).PSTCMPAL
                obeMercaderia.PSCALMC = "" & CType(txtAlmacen.Resultado, beAlmacen).PSCALMC
                obeMercaderia.PSTCMPAL = "" & CType(txtAlmacen.Resultado, beAlmacen).PSTCMPAL
                obeMercaderia.PSCZNALM = "" & CType(txtZonaAlmacen.Resultado, beAlmacen).PSCZNALM
                obeMercaderia.PSTCMZNA = "" & CType(txtZonaAlmacen.Resultado, beAlmacen).PSTCMZNA
                obeMercaderia.PNQTRMC = obeDespacho.PNQTRMC
                obeMercaderia.PNQTRMP = obeDespacho.PNQTRMP
                obeMercaderia.PSCCNTD = txtContenedor.Text
                obeMercaderia.PSCTPOCN = IIf(Me.chkDesglose.Checked = True, "SI", "NO")
                obeMercaderia.PSFUNDS2 = .PSFUNDS2
                obeMercaderia.PSCTPDPS = .PSCTPDP6
                obeMercaderia.PSTOBSRV = txtObservaciones.Text

                If txtUnidad.Resultado IsNot Nothing Then
                    obeMercaderia.PNNANOCM = CType(txtUnidad.Resultado, beCamion).PNNANOCM
                    obeMercaderia.PSTMRCCM = CType(txtUnidad.Resultado, beCamion).PSTMRCCM
                    obeMercaderia.PSNPLCCM = CType(txtUnidad.Resultado, beCamion).PSNPLCCM
                End If

                If txtBrevete.Resultado IsNot Nothing Then
                    obeMercaderia.PNNLELCH = Val(CType(txtBrevete.Resultado, beChofer).PSNLELCHSTR)
                    obeMercaderia.PSTNMBCH = CType(txtBrevete.Resultado, beChofer).PSTNMBCH
                    obeMercaderia.PSNBRVCH = CType(txtBrevete.Resultado, beChofer).PSNBRVCH
                End If
                obeMercaderia.PNCCLNT = _intCCLNT
                obeMercaderia.PNCTRSP = CType(txtEmpresaTransporte.Resultado, beTransportista).PNCTRSP
                obeMercaderia.PNNRUCT = CType(txtEmpresaTransporte.Resultado, beTransportista).PNNRUCT
                obeMercaderia.PNCSRVC = pintServicio_CSRVC
                obeMercaderia.PSCCMPN = strCCMPN
                obeMercaderia.PSCDVSN = strCDVSN
                obeMercaderia.PSTOBSER = txtObservaciones.Text
                obeMercaderia.PSTCMPCL = strTCMPCL
                obeMercaderia.PSTCMPTR = CType(txtEmpresaTransporte.Resultado, beTransportista).PSTCMPTR
                obeMercaderia.GenerarServicio = False
                obeMercaderia.PSUSUARIO = objSeguridadBN.pUsuario
                obeMercaderia.PNFRLZSR = HelpClass.CFecha_a_Numero8Digitos(dteFechaRecepcion.Value)
                obeMercaderia.PNNSLCRF = _PNNORSCI
                obeMercaderia.PSTIPORG = CType(Me.txtOrigen.Resultado, beGeneral).PSCCMPRN
                obeMercaderia.PSTIPORI = CType(Me.txtTipoDoc.Resultado, beGeneral).PSCCMPRN
                obeMercaderia.PSSCNEMB = IIf(chkSi.Checked, "S", "N")
                obeMercaderia.PSNTRMNL = objSeguridadBN.pstrPCName
            End With
            olistMercaderia.Add(obeMercaderia)
        Next

        Dim obrMercaderia As New brMercaderia
        olistMercaderia.Item(0).PNNGUIRN = obrMercaderia.fintRecepcionMercaderia(olistMercaderia)
        If olistMercaderia.Item(0).PNNGUIRN = 0 Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        End If
       

        intNroGuiaRansa = olistMercaderia.Item(0).PNNGUIRN
        Dim objFiltro As New beDespacho
        With objFiltro
            .PNCCLNT = olistMercaderia.Item(0).PNCCLNT
            .PNNGUIRN = olistMercaderia.Item(0).PNNGUIRN
            .pRazonSocial = olistMercaderia.Item(0).PSTCMPCL
        End With
        mReporteIngSalRansa(objFiltro)


        KryptonPanel.Enabled = False
        btnAceptar.Enabled = False
        tsbCancelar.Enabled = False

        Container1.SuspendLayout()
        ToolStrip1.Visible = True
        Container1.FixedPanel = FixedPanel.None
        Container1.IsSplitterFixed = False
        Container1.Panel2MinSize = 180
        Container1.SplitterDistance = 500
        Container1.ResumeLayout()
        'Ejecutamos el evento CurrentCell
        dtgMovimientos_CurrentCellChanged(Nothing, Nothing)
    End Sub


    Private Sub CargarControlTipoAlmacen()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CTPALM"
        oColumnas.DataPropertyName = "PSCTPALM"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TALMC"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oColumnas.DataPropertyName = "PSTALMC"
        oColumnas.HeaderText = "Tipo Almacén "
        oListColum.Add(2, oColumnas)
        Dim obrAlmacen As New brAlmacen
        txtTipoAlmacen.DataSource = obrAlmacen.ListaTipoDeAlmacen()
        txtTipoAlmacen.ListColumnas = oListColum
        txtTipoAlmacen.Cargas()
        txtTipoAlmacen.ValueMember = "PSCTPALM"
        txtTipoAlmacen.DispleyMember = "PSTALMC"
    End Sub
#End Region


    Private Sub txtEmbarque_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEmbarque.Validating
        BuscarOcEnEmbarque()
    End Sub

    Private Sub btnAnularItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim strValidarCodEmb As String = ""
        If Not fblnValidarInfItemRecepcion() Then Exit Sub
        Me.pProcesarRegistroInfCabecera()
        'Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub


    Private Sub tsbCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub dtgMovimientos_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgMovimientos.CurrentCellChanged

        If dtgMovimientos.RowCount = 0 OrElse dtgMovimientos.CurrentCellAddress.Y < 0 Or intNroGuiaRansa = 0 Then Exit Sub
        Dim FilaReg As Int64 = dtgMovimientos.CurrentRow.Index
        Dim OS As Decimal = Me.dtgMovimientos.CurrentRow.Cells("PNNORDSR").Value
        Dim CantTrx As Decimal = Me.dtgMovimientos.CurrentRow.Cells("PNQTRMC").Value
        Dim SKU As String = ("" & Me.dtgMovimientos.CurrentRow.Cells("CMRCLR").Value).ToString.Trim
        'Me.UcSerie_Lista.IngresoSeries(Me.dtgMovimientos.CurrentRow.Cells("PNNORDSR").Value, Me.dtgMovimientos.CurrentRow.Cells("PNNSLCSR").Value, Me.dtgMovimientos.CurrentRow.Cells("PNQTRMC").Value, _intCCLNT, Me.intNroGuiaRansa, objSeguridadBN.pUsuario)
        Me.UcSerie_Lista.IngresoSeries_V2(OS, FilaReg, Me.dtgMovimientos.CurrentRow.Cells("PNNSLCSR").Value, CantTrx, _intCCLNT, Me.intNroGuiaRansa, objSeguridadBN.pUsuario)

        If txtTipoAlmacen.Resultado Is Nothing Then Exit Sub
        If txtAlmacen.Resultado Is Nothing Then Exit Sub

        Dim CodTipoAlmacen As String = ("" & CType(txtTipoAlmacen.Resultado, beAlmacen).PSCTPALM).Trim
        Dim CodAlmacen As String = ("" & CType(txtAlmacen.Resultado, beAlmacen).PSCALMC).Trim
        Dim CodZona As String = ("" & CType(txtZonaAlmacen.Resultado, beAlmacen).PSCZNALM).Trim

        'Me.UcUbicaciones_Lista.ConsultarIngresos(Me.dtgMovimientos.CurrentRow.Cells("PNNORDSR").Value, _intCCLNT, Me.dtgMovimientos.CurrentRow.Cells("CMRCLR").Value, "" & CType(txtTipoAlmacen.Resultado, beAlmacen).PSCTPALM, "" & CType(txtAlmacen.Resultado, beAlmacen).PSCALMC, "" & CType(txtZonaAlmacen.Resultado, beAlmacen).PSCZNALM, dtgMovimientos.CurrentRow.Cells("PNQTRMC").Value, objSeguridadBN.pUsuario, False, 0, 0)
        Me.UcUbicaciones_Lista.ConsultarIngresos(OS, _intCCLNT, SKU, CodTipoAlmacen, CodAlmacen, CodZona, CantTrx, objSeguridadBN.pUsuario, False, 0, 0)


    End Sub

    Private Sub tsbProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbProcesar.Click
        'Inserta las series
        UcSerie_Lista.Guardar(intNroGuiaRansa, Nothing)

        'Inserta las ubicaciones
        UcUbicaciones_Lista.Guardar(intNroGuiaRansa)
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub


    Private Sub tsbCancelarProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCancelarProcesar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class
