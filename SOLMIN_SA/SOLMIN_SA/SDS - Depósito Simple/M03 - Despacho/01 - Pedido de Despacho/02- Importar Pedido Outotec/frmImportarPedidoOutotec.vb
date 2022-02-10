Imports Ransa.DAO.Unidad
Imports Ransa.NEGO
Imports Ransa.TypeDef
Imports Ransa.Utilitario

Public Class frmImportarPedidoOutotec
    Private pSinOrdenServicioAsociado As Int64 = 0
    Private pedidoSistema As Boolean = False
    Private CodigoPedido_CDPEPL As Int64 = 0
    Private pedidoImportado As Boolean = False
    Private intCCLNT As Decimal

    Private ohtProyectos As New Hashtable
    Public Property CCLNT() As Decimal
        Get
            Return intCCLNT
        End Get
        Set(ByVal value As Decimal)
            intCCLNT = value
        End Set
    End Property

    Private Sub frmImportarPedidoOutotec_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dgDetallePedidoPorOc.AutoGenerateColumns = False
        CargarTipoPedido()
        cmbTipoPedido.SelectedIndex = 0
        dgDetallePedidoPorOc.Visible = False
        tsDet.Visible = False
    End Sub


    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        ImportarPedidoOutotec()
    End Sub

    Private Sub CargarTipoPedido()
        Dim oDt As New DataTable

        oDt.Columns.Add("COD")
        oDt.Columns.Add("DESC")
        Dim oDr As DataRow

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
    Private Sub ImportarPedidoOutotec()
        'If txtReferenciaPedido.Text.Trim.Equals("") Or txtNumeroPedido.Text.Trim.Equals("") Then
        '    Exit Sub
        'End If
        'txtNumeroPedido_Validating(txtNumeroPedido, Nothing)
        'If (CodigoPedido_CDPEPL <> 0) Then
        '    MessageBox.Show(" El pedido ya fue importado anteriormente " & Chr(13) & "No se puede importar otra vez", "Verificación Pedido", MessageBoxButtons.OK)
        '    Exit Sub
        'End If
        ImportarPedido()
    End Sub


    Private Sub ImportarPedido()
        Try
            Dim oDs As New DataSet()
            Dim odtPedidoDetalle As New DataTable()
            Dim obeProveedor As New beProveedor()
            Dim oblProveedor As New blProveedor()
            Dim oParameter As New Db2Manager.RansaData.iSeries.DataObjects.Parameter()
            Dim strError As String = ""

            Dim oParamentros As New beCabInfzPedidoOuototec
            oParamentros.in_CodCliente = intCCLNT
            oParamentros.nordpe = txtNumeroPedido.Text
            oParamentros.ctpope = cmbTipoPedido.SelectedValue

            oDs = New brInterfazOutoTec().flistObtenerPedidoOutotec(oParamentros)
            If oDs.Tables(0).Rows.Count > 0 Then
                pedidoImportado = True
                Me.cmbTipoPedido.SelectedValue = oDs.Tables(0).Rows(0).Item("ctpope")

                If (DBNull.Value IsNot oDs.Tables(0).Rows(0).Item("frecep")) Then
                    dtpFecha.Value = oDs.Tables(0).Rows(0).Item("frecep")
                Else
                    dtpFecha.Value = Date.Now
                End If
                txtMotivoSalida.Text = ("" & oDs.Tables(0).Rows(0).Item("nordcl") & "").ToString.Trim
                'txtLugarOrigen.Text = ("" & odtPedidoCabecera.Rows(0).Item("vc_HomeName")).ToString.Trim
                'txtDireccionOrigen.Text = ("" & odtPedidoCabecera.Rows(0).Item("vc_HomeAddress")).ToString.Trim

                '------------------insercion del provvedor de ABB -> en caso no se encontrara(rzol05)----------------
                obeProveedor.CPRVCL_CodClienteTercero = 0
                If (IsNumeric(("" & oDs.Tables(0).Rows(0).Item("nroruc")).ToString.Trim) = True) Then
                    obeProveedor.NRUCPR_RucProveedor = Val(("" & oDs.Tables(0).Rows(0).Item("nroruc")).ToString.Trim)
                Else
                    obeProveedor.NRUCPR_RucProveedor = 0
                End If

                If ("" & oDs.Tables(0).Rows(0).Item("Direccion")).ToString.Trim.Length > 35 Then
                    Dim intDir As Integer = ("" & oDs.Tables(0).Rows(0).Item("direccion")).ToString.Trim.Length
                    obeProveedor.PSTDRPRC = HelpClass.validaCaracter(("" & oDs.Tables(0).Rows(0).Item("direccion")).ToString.Trim.Substring(0, 35), strError)
                    obeProveedor.PSTPRSCN = HelpClass.validaCaracter(("" & oDs.Tables(0).Rows(0).Item("direccion")).ToString.Trim.Substring(35, intDir - 35), strError)
                Else
                    obeProveedor.PSTDRPRC = HelpClass.validaCaracter(("" & oDs.Tables(0).Rows(0).Item("direccion")).ToString.Trim, strError)
                    obeProveedor.PSTPRSCN = ""
                End If

                If ("" & oDs.Tables(0).Rows(0).Item("vc_descripcion")).ToString.Trim.Length > 30 Then
                    Dim intDir As Integer = ("" & oDs.Tables(0).Rows(0).Item("vc_descripcion")).ToString.Trim.Length
                    obeProveedor.PSTPRVCL = HelpClass.validaCaracter(("" & oDs.Tables(0).Rows(0).Item("vc_descripcion")).ToString.Trim.Substring(0, 30), strError)
                    obeProveedor.PSTPRCL1 = HelpClass.validaCaracter(("" & oDs.Tables(0).Rows(0).Item("vc_descripcion")).ToString.Trim.Substring(30, intDir - 30), strError)
                Else
                    obeProveedor.PSTPRVCL = HelpClass.validaCaracter(("" & oDs.Tables(0).Rows(0).Item("vc_descripcion")).ToString.Trim, strError)
                    obeProveedor.PSTPRCL1 = ""
                End If

                obeProveedor.TNROFX_NroFax = "" '("" & odtPedidoCabecera.Rows(0).Item("vc_Fax")).ToString.Trim
                obeProveedor.TLFN02_FonoContacto = "" ' ("" & odtPedidoCabecera.Rows(0).Item("vc_Telefono")).ToString.Trim
                obeProveedor.TMAI03_EmailContacto = ""
                obeProveedor.CULUSA_UsuarioAct = objSeguridadBN.pUsuario
                obeProveedor.CUSCRT_UsuarioCre = objSeguridadBN.pUsuario
                obeProveedor.CCLNT_CodigoCliente = Me.CCLNT
                '
                obeProveedor.CPRPCL_CodigoClienteProveedor = ("" & oDs.Tables(0).Rows(0).Item("cclien")).ToString.Trim
                ''Para Planta
                If ("" & oDs.Tables(0).Rows(0).Item("direccion")).ToString.Trim.Length > 35 Then
                    obeProveedor.PSTDRPCP = HelpClass.validaCaracter(("" & oDs.Tables(0).Rows(0).Item("direccion")).ToString.Trim.Substring(0, 35), strError)
                    obeProveedor.PSTDRDST = HelpClass.validaCaracter(("" & oDs.Tables(0).Rows(0).Item("direccion")).ToString.Trim.Substring(35, ("" & oDs.Tables(0).Rows(0).Item("direccion")).ToString.Trim.Length - 35), strError)
                Else
                    obeProveedor.PSTDRPCP = HelpClass.validaCaracter(("" & oDs.Tables(0).Rows(0).Item("direccion")).ToString.Trim, "")
                    obeProveedor.PSTDRDST = ""
                End If
                'CÓDIGO DE PLANTA SI ES QUE TIENE CENTRO DE COSTO
                obeProveedor.PSNTLFPL = "" '("" & odtPedidoCabecera.Rows(0).Item("Telefono")).ToString.Trim
                obeProveedor.CREAR_RELACION_CrearRelacionClientevsProveedor = "C"
                'Datos para el centro de costo
                'obeProveedor.PSCCTCST = (("" & odtPedidoCabecera.Rows(0).Item("vc_CentroCosto")).ToString.Trim)
                obeProveedor.PSTDSCNT = HelpClass.validaCaracter((("" & oDs.Tables(0).Rows(0).Item("vc_descripcion")).ToString.Trim), "")
                obeProveedor.PSCDIVSU = ""
                obeProveedor.PSNTRMNL = objSeguridadBN.pstrPCName()



                If strError.Length > 0 Then
                    HelpClass.ErrorMsgBox()
                    Exit Sub
                End If

                obeProveedor = oblProveedor.fblnRegistrar_Proveedor_de_ABB(obeProveedor)

             
                Tercero()

                UcClienteTercero_xtF011.MostrarRuc = True
                UcClienteTercero_xtF011.CodCliente = Me.CCLNT
                UcClienteTercero_xtF011.TipoRelacion = ""
                Dim obePlantaDeEntregaC As New PlantaDeEntrega.bePlantaDeEntrega
                With obePlantaDeEntregaC
                    .PNCCLNT = CCLNT
                    .PNCPRVCL = obeProveedor.CPRVCL_CodClienteTercero
                    .PSSTPORL = ""
                End With

                UcClienteTercero_xtF011.pCargar(obePlantaDeEntregaC)
                Dim obePlantaDeEntrega As New PlantaDeEntrega.bePlantaDeEntrega
                With obePlantaDeEntrega
                    .TIPOCLIENTE = False  'propio o tercero
                    .PNCCLNT = Me.CCLNT
                    .PNCPRVCL = obeProveedor.CPRVCL_CodClienteTercero
                    .PNCPLNCL = obeProveedor.CPLCLP_CodPlanta
                    .PSTCMPPL = "" ' descripcion opciona
                End With
                UcPlantaDeEntrega_TxtF011.pCargar(obePlantaDeEntrega)
                UcPlantaDeEntrega_TxtF011.CodClienteTercero = obeProveedor.CPRVCL_CodClienteTercero
                ''---------------------Cargar Tipo CLiente------------------------------------------------------------

                ''---------------------
                dgItemPedido.AutoGenerateColumns = False

                If Me.cmbTipoPedido.Text <> "PP" Then
                    Dim olbeMercaderia As New List(Of beMercaderia)
                    Dim obeMercaderia As beMercaderia

                    For Each oDr As DataRow In oDs.Tables(1).Rows
                        obeMercaderia = New beMercaderia
                        With obeMercaderia
                            .PNCDREGP = oDr.Item("norden")
                            .PSCMRCLR = oDr.Item("citems")
                            .PSTDITES = oDr.Item("ditems")
                            .PSCUNCN6 = oDr.Item("cunico")
                            '.PNQSRVC = oDr.Item("qitems")
                            .PNSALDO = oDr.Item("qitems")
                        End With
                        olbeMercaderia.Add(obeMercaderia)
                    Next
                    dgItemPedido.DataSource = olbeMercaderia
                    ValidarMercaderiaRelacionada()
                    fAsocialDetallePedidoConProyecto()
                    dgDetallePedidoPorOc.Visible = True
                    dgItemPedido.Columns("CHK").Visible = True
                    tsDet.Visible = True

                    dgItemPedido_SelectionChanged(Nothing, Nothing)
                Else
                    Dim obeMercaderia As New beMercaderia
                    Dim olbeMercaderia As New List(Of beMercaderia)
                    Dim obrMercaderia As New brMercaderia
                    With obeMercaderia
                        .PNCCLNT = intCCLNT
                        .PSNRFRPD = txtNumeroPedido.Text
                    End With
                    dgItemPedido.DataSource = Nothing
                    olbeMercaderia = obrMercaderia.flistListarMercaderiaPorPedido(obeMercaderia)
                    For intRow As Integer = 0 To olbeMercaderia.Count - 1
                        olbeMercaderia.Item(intRow).PNCDREGP = intRow + 1
                    Next
                    dgItemPedido.DataSource = olbeMercaderia
                    ValidarMercaderiaRelacionada()
                    fAsocialDetallePedidoConProyecto()
                    dgItemPedido_SelectionChanged(Nothing, Nothing)
                    dgDetallePedidoPorOc.Visible = False
                    dgItemPedido.Columns("CHK").Visible = False
                    tsDet.Visible = False
                End If
                pedidoImportado = True
                txtNumeroPedido.CausesValidation = False
            Else
                LimpiarControl()
                LimpiarContenido()
                HelpClass.MsgBox("No existe información")

            End If
        Catch ex As Exception
        End Try

    End Sub


    Public Sub ValidarMercaderiaRelacionada()
        pSinOrdenServicioAsociado = 0
        Try
            Dim dtOrdenServicio As New DataTable()
            Dim Filas As Int64 = dgItemPedido.Rows.Count
            For Each odr As DataGridViewRow In dgItemPedido.Rows
                Dim obeMercaderia As New beMercaderia
                Dim olbeMercaderia As New List(Of beMercaderia)
                Dim obrMercaderia As New brMercaderia
                With obeMercaderia
                    .PNCCLNT = Me.CCLNT
                    .PSNRFRPD = txtNumeroPedido.Text
                    .PSCMRCLR = "" & odr.Cells("PSCMRCLR").Value & ""
                End With
                olbeMercaderia = obrMercaderia.flistListarMercaderiaPorPedido(obeMercaderia)
                If (olbeMercaderia.Count > 0) Then
                    odr.Cells("PSCUNCN6").Value = olbeMercaderia.Item(0).PSCUNCN5
                    odr.Cells("PNNORDSR").Value = olbeMercaderia.Item(0).PNNORDSR
                    odr.Cells("PSTDITES").Value = ("" & olbeMercaderia.Item(0).PSTMRCD2).ToString.Trim
                    odr.Cells("PNSALDO").Value = olbeMercaderia.Item(0).PNSALDO
                    odr.Cells("CONOS").Value = My.Resources.button_ok
                Else
                    pSinOrdenServicioAsociado += 1
                    odr.Cells("PSCUNCN6").Value = ""
                    odr.Cells("PNSALDO").Value = 0D
                    odr.Cells("CONOS").Value = My.Resources.button_cancel
                End If
            Next
        Catch ex As Exception
        End Try

    End Sub

    Private Sub txtNumeroPedido_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNumeroPedido.Validating
        Try
            If Not (Me.cmbTipoPedido.Text.Trim.Equals("") And Me.txtNumeroPedido.Text.Trim.Equals("")) Then
                CargarPedido(Me.cmbTipoPedido.Text, Me.txtNumeroPedido.Text)
            End If
            txtNumeroPedido.CausesValidation = False
        Catch ex As Exception
        End Try
    End Sub


    Private Sub CargarPedido(ByVal TipoReferenci_NRFTPD As String, ByVal NroReferencia_NRFRPD As String)
        Try
            CodigoPedido_CDPEPL = 0
            LimpiarControl()
            Dim oblPedido As New brPedido()
            Dim odtPedido As New DataTable()
            Dim objParametro As New Hashtable

            objParametro.Add("PSNRFTPD", TipoReferenci_NRFTPD)
            objParametro.Add("PSNRFRPD", NroReferencia_NRFRPD)

            odtPedido = oblPedido.ObtenerPedidoXReferenciaPedido(objParametro).Tables(0)
            If (odtPedido.Rows.Count > 0) Then
                CodigoPedido_CDPEPL = Val("" & odtPedido.Rows(0).Item("CDPEPL"))
                dtpFecha.Value = HelpClass.CNumero_a_Fecha(odtPedido.Rows(0).Item("FCHSPE"))
                txtMotivoSalida.Text = ("" & odtPedido.Rows(0).Item("TOBSMD")).ToString.Trim
                Tercero()
                Dim obePlantaDeEntregaC As New PlantaDeEntrega.bePlantaDeEntrega
                With obePlantaDeEntregaC
                    .TIPOCLIENTE = False  'propio o tercero
                    .PNCCLNT = Me.CCLNT
                    .PNCPRVCL = Val("" & odtPedido.Rows(0).Item("CPRVCL"))
                    .PSTPRVCL = ""
                End With
                UcClienteTercero_xtF011.pCargar(obePlantaDeEntregaC)

                Dim obePlantaDeEntrega As New PlantaDeEntrega.bePlantaDeEntrega
                With obePlantaDeEntrega
                    .TIPOCLIENTE = False  'propio o tercero
                    .PNCCLNT = Me.CCLNT
                    .PNCPRVCL = Val("" & odtPedido.Rows(0).Item("CPRVCL"))
                    .PNCPLNCL = "" & odtPedido.Rows(0).Item("CPLCLP") & ""
                    .PSTCMPPL = "" ' descripcion opciona
                End With
                UcPlantaDeEntrega_TxtF011.pCargar(obePlantaDeEntrega)
                dgItemPedido.DataSource = odtPedido
                pedidoSistema = True

            Else
                LimpiarContenido()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub LimpiarControl()
        UcPlantaDeEntrega_TxtF011.CodCliente = Me.CCLNT
        UcClienteTercero_xtF011.CodCliente = Me.CCLNT
        UcPlantaDeEntrega_TxtF011.pClear()
        UcClienteTercero_xtF011.pClear()
    End Sub

    Private Sub Tercero()
        UcPlantaDeEntrega_TxtF011.TipoPlantaDeEntrega = False
        UcClienteTercero_xtF011.Visible = True
        lblClienteTercero.Visible = True
        'Me.lblPlantaTercero.Location = New System.Drawing.Point(19, 194)
        'Me.UcPlantaDeEntrega_TxtF011.Location = New System.Drawing.Point(141, 196)
        LimpiarControl()
    End Sub

    Public Sub LimpiarContenido()
        dtpFecha.Value = Date.Now()
        txtMotivoSalida.Text = ""
        'txtLugarOrigen.Text = ""
        'txtDireccionOrigen.Text = ""
        pedidoImportado = False
        dgItemPedido.DataSource = Nothing
        pSinOrdenServicioAsociado = 0
    End Sub



    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try

            Dim strMensajeError As String = ""
            Me.dgItemPedido.EndEdit()

            If (dgItemPedido.Rows.Count = 0) Then
                MessageBox.Show(".No exiten datos." & Chr(13) & "No se puede realizar la operación", " Verificación Datos", MessageBoxButtons.OK)
                Exit Sub
            End If

            Dim IntQSeleccionados As Integer = 0
            For Each obeMercaderia As beMercaderia In Me.dgItemPedido.DataSource
                If obeMercaderia.CHK Then
                    IntQSeleccionados = IntQSeleccionados + 1
                    If obeMercaderia.PNNORDSR = 0 Then
                        strMensajeError &= " Hay Mercaderías seleccionadas sin Orden de Servicio, No es posible realizar la operación hasta tengan su Orden de Servicio" & vbNewLine
                        Exit For
                    End If
                    If obeMercaderia.PNSALDO = 0 Then
                        strMensajeError &= " No se puede crear el pedido con cantidad solicitada cero" & vbNewLine
                        Exit For
                    End If
                End If
            Next
            If strMensajeError.Trim.Length > 0 Then
                MessageBox.Show(strMensajeError, "Verificación", MessageBoxButtons.OK)
                Exit Sub
            End If

            If (IntQSeleccionados = 0) And Me.cmbTipoPedido.SelectedValue <> "P" Then
                MessageBox.Show(".No exiten registros seleccionados." & Chr(13) & "No se puede realizar la operación", " Verificación Datos", MessageBoxButtons.OK)
                Exit Sub
            End If

            If (pedidoImportado = False) Then
                txtNumeroPedido_Validating(txtNumeroPedido, Nothing)
            End If
            If (CodigoPedido_CDPEPL <> 0) Then
                MessageBox.Show(" El pedido ya fue importado anteriormente " & Chr(13) & "No se puede realizar la operación", "Verificación Pedido", MessageBoxButtons.OK)
                Exit Sub
            End If

            If UcClienteTercero_xtF011.ItemActual.PNCPRVCL = 0 Then strMensajeError &= "Falta - Cliente Tercero." & vbNewLine
            If UcPlantaDeEntrega_TxtF011.ItemActual.PNCPLNCL = 0 Then strMensajeError &= "Falta - Planta de Entrega." & vbNewLine

            If strMensajeError.Trim.Length > 0 Then
                MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            'Validar que la cantidad Solicitado esa igual que la cantidad de proyecto
            Dim decSuma As Decimal = 0D
            Dim strError As String = ""
            For Each obeMercaderia As beMercaderia In Me.dgItemPedido.DataSource
                If obeMercaderia.CHK Then
                    Dim key As New KeyValuePair(Of Int64, Int32)(obeMercaderia.PNNORDSR, obeMercaderia.PNCDREGP)
                    decSuma = 0
                    If Not ohtProyectos(key) Is Nothing Then
                        For Each obeProyecto As beMercaderia In ohtProyectos(key)
                            decSuma = obeProyecto.PNQSRVC + decSuma
                        Next
                        If obeMercaderia.PNSALDO <> decSuma Then
                            strError = strError & "  " & obeMercaderia.PSCMRCLR.ToString & Chr(10)
                        End If
                    End If
                End If

            Next
            If (strError <> "") Then
                MessageBox.Show("- La cantidad solicitada del los proyectos debe de ser " & Chr(10) & "  igual que la cantidad solicitada de las mercaderías : " & Chr(10) & strError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            GuardarPedido()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GuardarPedido()
        Try
            Me.dgItemPedido.EndEdit()
            Dim obePedidoPlanta As New bePedidoPorPlanta
            Dim olbePedidoPlanta As New List(Of bePedidoPorPlanta)
            Dim CPLNCL_CodigoPlantaCliente As Int64 = 0
            Dim CPLCLP_CodigoPlantaClienteTercero As Int64 = 0
            Dim obrPedidoPlanta As New brDespacho
            Dim intRow As Integer = 1
            For Each obeMercaderia As beMercaderia In Me.dgItemPedido.DataSource

                If obeMercaderia.CHK Or Me.cmbTipoPedido.SelectedValue = "P" Then
                    Dim key As New KeyValuePair(Of Int64, Int32)(obeMercaderia.PNNORDSR, obeMercaderia.PNCDREGP)
                    For Each obeProyecto As beMercaderia In ohtProyectos(key)
                        If obeProyecto.PNQSRVC > 0 Then
                            obePedidoPlanta = New bePedidoPorPlanta
                            With obePedidoPlanta
                                .PNCDREGP = obeMercaderia.PNCDREGP
                                .CORRELATIVO = obeMercaderia.PNCDREGP
                                .PNNORDSR = obeMercaderia.PNNORDSR
                                .PSCMRCLR = obeMercaderia.PSCMRCLR
                                .PNFCHSPE = HelpClass.CDate_a_Numero8Digitos(dtpFecha.Value)
                                .PNHRASPE = "000000"
                                .PNCCLNT = Me.CCLNT
                                'If UcClienteTercero_xtF011.TipoPlantaDeEntrega Then
                                '    .PNCPLNCL = Me.UcPlantaDeEntrega_TxtF011.ItemActual.PNCPLNCL
                                '    .PNCPRVCL = 0
                                '    .PNCPLCLP = 0
                                'Else
                                .PNCPLNCL = 0 'Me.UcPlantaDeEntrega_TxtF011.ItemActual.PNCPLNCL
                                .PNCPRVCL = UcClienteTercero_xtF011.ItemActual.PNCPRVCL
                                .PNCPLCLP = Me.UcPlantaDeEntrega_TxtF011.ItemActual.PNCPLNCL
                                'End If
                                .PNQSRVC = obeProyecto.PNQSRVC
                                .PSCUNCN6 = obeMercaderia.PSCUNCN6
                                .PSTCTCST = ""
                                .PNPSRVC = 0
                                .PSCUNPS6 = ""
                                .PSSATSLS = "P"
                                .PSSATNAL = "P"
                                .PSNRFTPD = Me.cmbTipoPedido.Text
                                .PSNRFRPD = txtNumeroPedido.Text
                                .PSFLGAPR = ""
                                .PSFLGURG = ""
                                .PSSBCKRD = ""
                                .PSNORCML = obeProyecto.PSNORCML
                                .PNFDSPAL = "00000000"
                                .PSTOBSMD = txtMotivoSalida.Text.Trim
                                .PNNRITOC = obeProyecto.PNNRITOC
                                .PSNLTECL = obeMercaderia.PNCDREGP ' Nr. Item Pedido Outotec
                                .PNNROSEQ = 0
                                .PNFULTAC = HelpClass.CDate_a_Numero8Digitos(Now)
                                .PNHULTAC = HelpClass.NowNumeric
                                .PSCULUSA = objSeguridadBN.pUsuario
                                .PNFCHCRT = HelpClass.CDate_a_Numero8Digitos(Now)
                                .PNHRACRT = HelpClass.NowNumeric
                                .PSCUSCRT = objSeguridadBN.pUsuario
                                .PSSESTRG = "A"
                                .PNNDCFCC = Val(Me.txtFactura.Text)
                                intRow = intRow + 1
                            End With
                            olbePedidoPlanta.Add(obePedidoPlanta)
                        End If
                    Next
                End If
            Next
            Dim intResultado As Double = 0
            If olbePedidoPlanta.Count = 0 Then Exit Sub
            intResultado = obrPedidoPlanta.GuardarPedidoPlanta(olbePedidoPlanta)
            If intResultado <> 0 Then
                'Dim obeDetPedidoOuototec As beDetInfzPedidoOuototec
                'Dim obrInterfazOutoTec As New brInterfazOutoTec
                'For Each obePedidoPorPlanta As bePedidoPorPlanta In olbePedidoPlanta
                '    obeDetPedidoOuototec = New beDetInfzPedidoOuototec
                '    obeDetPedidoOuototec.codcli = obePedidoPorPlanta.PNCCLNT
                '    obeDetPedidoOuototec.nordpe = obePedidoPorPlanta.PSNRFRPD
                '    obeDetPedidoOuototec.norden = obePedidoPorPlanta.CORRELATIVO
                '    obeDetPedidoOuototec.usuario = obePedidoPorPlanta.PSCULUSA
                '    If obrInterfazOutoTec.fintActualizarPedidosOutotec(obeDetPedidoOuototec) Then
                '        HelpClass.ErrorMsgBox()
                '        Exit Sub
                '    End If
                'Next
                HelpClass.MsgBox("Se ha creado el Pedido N° " & intResultado, MessageBoxIcon.Information)
                Me.Close()
            Else
                HelpClass.ErrorMsgBox()
            End If
        Catch ex As Exception
        End Try
    End Sub


    Private Sub dgItemPedido_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgItemPedido.SelectionChanged
        If Me.dgItemPedido.CurrentCellAddress.Y = -1 Then Exit Sub
        Dim key As New KeyValuePair(Of Int64, Int32)(Me.dgItemPedido.CurrentRow.DataBoundItem.PNNORDSR, Me.dgItemPedido.CurrentRow.DataBoundItem.PNCDREGP)
        Me.dgDetallePedidoPorOc.DataSource = ohtProyectos(key)
    End Sub

    Private Sub UcClienteTercero_xtF011_TextChanged() Handles UcClienteTercero_xtF011.TextChanged
        UcPlantaDeEntrega_TxtF011.pClear()
        UcPlantaDeEntrega_TxtF011.CodClienteTercero = UcClienteTercero_xtF011.ItemActual.PNCPRVCL
    End Sub


    Private Sub fAsocialDetallePedidoConProyecto()
        Try
            Dim obrMercaderia As New brMercaderia
            ohtProyectos.Clear()
            For Each obeMerca As beMercaderia In Me.dgItemPedido.DataSource
                Dim key As New KeyValuePair(Of Int64, Int32)(obeMerca.PNNORDSR, obeMerca.PNCDREGP)
                With obeMerca
                    .PNCCLNT = intCCLNT
                    .PSNRFRPD = Me.txtNumeroPedido.Text
                    .PNNORDSR = obeMerca.PNNORDSR
                End With
                Dim olbeProyectoPorOs As New List(Of beMercaderia)
                olbeProyectoPorOs = obrMercaderia.flistListarDetallePedidoPorOc(obeMerca)
                Dim decSuma As Decimal = 0D
                For Each obemercaderi As beMercaderia In olbeProyectoPorOs
                    decSuma = decSuma + obemercaderi.PNSALDO
                Next
                If decSuma = obeMerca.PNSALDO Then
                    For Each obemercaderi As beMercaderia In olbeProyectoPorOs
                        obemercaderi.PNQSRVC = obemercaderi.PNSALDO
                    Next
                End If
                ohtProyectos.Add(key, olbeProyectoPorOs)
            Next
        Catch ex As Exception
        End Try

    End Sub


    Private Sub dgDetallePedidoPorOc_CellValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgDetallePedidoPorOc.CellValidating
        If dgDetallePedidoPorOc.Columns(e.ColumnIndex).Name = "QSRVC" Then
            'SI EL SALDO ES MAYOR QUE LA CANTIDAD SOLICITADA NO PROCEDE 
            If IsNumeric(e.FormattedValue) Then
                If CType(dgDetallePedidoPorOc.CurrentRow.DataBoundItem, beMercaderia).PNQSTKIT < e.FormattedValue Then
                    MessageBox.Show("La cantidad solicitada debe de ser menor o igual que el Saldo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    e.Cancel = True
                End If
            Else
                MessageBox.Show("Digite cantidad valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub cmbTipoPedido_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoPedido.TextChanged

    End Sub

    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click
        If UcClienteTercero_xtF011.ItemActual.PNCPRVCL <> 0 Then
            Dim frm As New frmEPlantaProveedor
            Dim oBE As New bePlantaClienteProveedor
            oBE.PNCPRVCL = UcClienteTercero_xtF011.ItemActual.PNCPRVCL
            frm.Tag = oBE
            frm.IsNuevo = True
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim obePlantaDeEntrega As New PlantaDeEntrega.bePlantaDeEntrega
                With obePlantaDeEntrega
                    .TIPOCLIENTE = False  'propio o tercero
                    .PNCCLNT = Me.CCLNT
                    .PNCPRVCL = UcClienteTercero_xtF011.ItemActual.PNCPRVCL
                    .PNCPLNCL = frm.PNCPLCLP()
                    .PSTCMPPL = "" ' descripcion opciona
                End With
                UcPlantaDeEntrega_TxtF011.pCargar(obePlantaDeEntrega)

            End If
        End If
    End Sub

   
   
End Class

