'Imports Ransa.DAO.Unidad
Imports Ransa.NEGO
Imports Ransa.TypeDef
Imports Ransa.Utilitario

Public Class frmImportarPedidoSAP

#Region "Variables Privadas"

    Private _oDs As New DataSet
    Private _CCLNT As Decimal = 0

#End Region

#Region "Propiedades Públicas"

    Public Property oDs() As DataSet
        Get
            Return _oDs
        End Get
        Set(ByVal value As DataSet)
            _oDs = value
        End Set
    End Property
    Public Property CCLNT() As Decimal
        Get
            Return _CCLNT
        End Get
        Set(ByVal value As Decimal)
            _CCLNT = value
        End Set
    End Property

#End Region

#Region "Eventos"

    Private Sub frmImportarPedidoSAP_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dgItemPedido.AutoGenerateColumns = False
        ImportarDatosCliente()
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Guardar()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

#End Region

#Region "Métodos"

    Private Sub ImportarDatosCliente()
        Dim strError As String = String.Empty
        Dim obeProveedor As New beProveedor()
        Dim oblProveedor As New blProveedor()



        '------------------insercion del provvedor de ABB -> en caso no se encontrara(rzol05)----------------
        obeProveedor.CPRVCL_CodClienteTercero = 0

        obeProveedor.NRUCPR_RucProveedor = 0

        obeProveedor.PSTDRPRC = HelpClass.validaCaracter(("" & oDs.Tables(0).Rows(0).Item("DESCEN")).ToString.Trim, strError)
        obeProveedor.PSTPRSCN = ""


        If ("" & oDs.Tables(0).Rows(0).Item("DESCEN")).ToString.Trim.Length > 30 Then
            Dim intDir As Integer = ("" & oDs.Tables(0).Rows(0).Item("DESCEN")).ToString.Trim.Length
            obeProveedor.PSTPRVCL = HelpClass.validaCaracter(("" & oDs.Tables(0).Rows(0).Item("DESCEN")).ToString.Trim.Substring(0, 30), strError)
            obeProveedor.PSTPRCL1 = HelpClass.validaCaracter(("" & oDs.Tables(0).Rows(0).Item("DESCEN")).ToString.Trim.Substring(30, intDir - 30), strError)
        Else
            obeProveedor.PSTPRVCL = HelpClass.validaCaracter(("" & oDs.Tables(0).Rows(0).Item("DESCEN")).ToString.Trim, strError)
            obeProveedor.PSTPRCL1 = ""
        End If

        obeProveedor.TNROFX_NroFax = String.Empty
        obeProveedor.TLFN02_FonoContacto = String.Empty
        obeProveedor.TMAI03_EmailContacto = String.Empty
        obeProveedor.CULUSA_UsuarioAct = objSeguridadBN.pUsuario
        obeProveedor.CUSCRT_UsuarioCre = objSeguridadBN.pUsuario
        obeProveedor.CCLNT_CodigoCliente = Me.CCLNT
        '
        obeProveedor.CPRPCL_CodigoClienteProveedor = ("" & oDs.Tables(0).Rows(0).Item("CENSAP")).ToString.Trim

        obeProveedor.PSTDRPCP = String.Empty
        obeProveedor.PSTDRDST = String.Empty

        obeProveedor.PSNTLFPL = String.Empty
        obeProveedor.CREAR_RELACION_CrearRelacionClientevsProveedor = "I"

        obeProveedor.PSTDSCNT = HelpClass.validaCaracter((("" & oDs.Tables(0).Rows(0).Item("DESCEN")).ToString.Trim), "")
        obeProveedor.PSCDIVSU = ""
        obeProveedor.PSNTRMNL = objSeguridadBN.pstrPCName()

        If ("" & oDs.Tables(0).Rows(0).Item("DESCEN")).ToString.Trim.Length > 35 Then
            obeProveedor.PSTDRPCP = HelpClass.validaCaracter(("" & oDs.Tables(0).Rows(0).Item("DESCEN")).ToString.Trim.Substring(0, 35), strError)
            obeProveedor.PSTDRDST = HelpClass.validaCaracter(("" & oDs.Tables(0).Rows(0).Item("DESCEN")).ToString.Trim.Substring(35, ("" & oDs.Tables(0).Rows(0).Item("direccion")).ToString.Trim.Length - 35), strError)
        Else
            obeProveedor.PSTDRPCP = HelpClass.validaCaracter(("" & oDs.Tables(0).Rows(0).Item("DESCEN")).ToString.Trim, "")
            obeProveedor.PSTDRDST = ""
        End If


        If strError.Length > 0 Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        End If
        obeProveedor = oblProveedor.fblnRegistrar_Proveedor_de_ABB(obeProveedor)

        UcClienteTercero_xtF011.MostrarRuc = True
        UcClienteTercero_xtF011.CodCliente = Me.CCLNT
        UcClienteTercero_xtF011.TipoRelacion = "I"
        Dim obePlantaDeEntregaC As New PlantaDeEntrega.bePlantaDeEntrega
        With obePlantaDeEntregaC
            .PNCCLNT = CCLNT
            .PNCPRVCL = obeProveedor.CPRVCL_CodClienteTercero
            .PSSTPORL = "I"
        End With

        UcClienteTercero_xtF011.pCargar(obePlantaDeEntregaC)

        UcPlantaDeEntrega_TxtF011.TipoPlantaDeEntrega = False

        Dim obePlantaDeEntrega As New PlantaDeEntrega.bePlantaDeEntrega
        With obePlantaDeEntrega
            .TIPOCLIENTE = False  'propio o tercero
            .PNCCLNT = Me.CCLNT
            .PNCPRVCL = obeProveedor.CPRVCL_CodClienteTercero
            .PNCPLNCL = obeProveedor.CPLCLP_CodPlanta
            .PSTCMPPL = "" ' descripcion opciona
        End With
        UcPlantaDeEntrega_TxtF011.pCargar(obePlantaDeEntrega)


        UcPlantaDeEntrega_TxtF011.CodCliente = Me.CCLNT
        UcPlantaDeEntrega_TxtF011.CodClienteTercero = obeProveedor.CPRVCL_CodClienteTercero



        'GENERAR TRAMA PARA CABECERA DE PEDIDO
        Dim strFecha As String = String.Empty
        If (DBNull.Value IsNot oDs.Tables(0).Rows(0).Item("FEMSDC")) Then
            strFecha = oDs.Tables(0).Rows(0).Item("FEMSDC").ToString()
            If strFecha.Length = 8 Then
                dtpFecha.Value = String.Format("{0}/{1}/{2}", strFecha.Substring(0, 4), strFecha.Substring(4, 2), strFecha.Substring(6, 2))
            End If
        Else
            dtpFecha.Value = Date.Now
        End If

        txtReferenciaPedido.Text = oDs.Tables(0).Rows(0).Item("TPODES")
        txtNumeroPedido.Text = oDs.Tables(0).Rows(0).Item("NUMDES")
        txtOrdenDeCompra.Text = oDs.Tables(0).Rows(0).Item("DCENSA")
        txtMotivoSalida.Text = oDs.Tables(0).Rows(0).Item("TOBSMD")


        If (DBNull.Value IsNot oDs.Tables(0).Rows(0).Item("FECCSP")) Then
            strFecha = oDs.Tables(0).Rows(0).Item("FECCSP").ToString().Trim
            If strFecha.Length = 8 Then
                dtpFechaContabilizacionSAP.Value = String.Format("{0}/{1}/{2}", strFecha.Substring(0, 4), strFecha.Substring(4, 2), strFecha.Substring(6, 2))
                dtpFechaContabilizacionSAP.Checked = True
            End If
        Else
            dtpFechaContabilizacionSAP.Checked = False
        End If

        'GENERAR TRAMA PARA DETALLE

        Dim olbeMercaderia As New List(Of beMercaderia)
        Dim obeMercaderia As beMercaderia

        For Each oDr As DataRow In oDs.Tables(1).Rows
            obeMercaderia = New beMercaderia
            With obeMercaderia
                .PNCDREGP = oDr.Item("NRITOC")
                .PSCMRCLR = oDr.Item("CODMAT")
                .PSTDITES = oDr.Item("DESMAT")
                .PSCUNCN6 = oDr.Item("UNIMED")
                .PNSALDO = oDr.Item("CANCOM")
            End With
            olbeMercaderia.Add(obeMercaderia)
        Next
        dgItemPedido.DataSource = olbeMercaderia
        ValidarMercaderiaRelacionada()

        If olbeMercaderia.Count = 0 Then
            MessageBox.Show("El pedido no contiene detalle", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnGuardar.Enabled = False
            Exit Sub
        End If

        Dim strMensajeError As String = String.Empty
        For Each obeMercaderia In Me.dgItemPedido.DataSource
            If obeMercaderia.PNNORDSR = 0 Then
                strMensajeError &= " Hay Mercaderías seleccionadas sin Orden de Servicio, No es posible realizar la operación hasta tengan su Orden de Servicio" & vbNewLine
                Exit For
            End If
            If obeMercaderia.PNSALDO = 0 Then
                strMensajeError &= " No se puede crear el pedido con cantidad solicitada cero" & vbNewLine
                Exit For
            End If
        Next

        If strMensajeError <> String.Empty Then
            MessageBox.Show(strMensajeError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnGuardar.Enabled = False
            Exit Sub
        End If

    End Sub

    Private Sub Guardar()
        Dim oblPedido As New brPedido()
        Dim odtPedido As New DataTable()
        Dim strMensajeError As String = ""
        Dim objParametro As New Hashtable

        Dim TipoReferenci_NRFTPD = oDs.Tables(0).Rows(0).Item("TPODES")
        Dim NroReferencia_NRFRPD = oDs.Tables(0).Rows(0).Item("NUMDES")

        objParametro.Add("PSNRFTPD", TipoReferenci_NRFTPD)
        objParametro.Add("PSNRFRPD", NroReferencia_NRFRPD)

        odtPedido = oblPedido.ObtenerPedidoXReferenciaPedido(objParametro).Tables(0)

        If (odtPedido.Rows.Count > 0) Then
            MessageBox.Show("El pedido ya fue registrado anteriormente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnGuardar.Enabled = False
            Exit Sub
        End If
        'VALIDAR SI EL CLIENTE TERCERO Y SU PLANTA ESTA SELECCIONADO
        If UcClienteTercero_xtF011.ItemActual.PNCPRVCL = 0 Then strMensajeError &= "Falta - Cliente Tercero." & vbNewLine
        If UcPlantaDeEntrega_TxtF011.ItemActual.PNCPLNCL = 0 Then strMensajeError &= "Falta - Planta de Entrega." & vbNewLine

        If strMensajeError.Trim.Length > 0 Then
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''


        Try
            Me.dgItemPedido.EndEdit()
            Dim obePedidoPlanta As New bePedidoPorPlanta
            Dim olbePedidoPlanta As New List(Of bePedidoPorPlanta)
            Dim CPLNCL_CodigoPlantaCliente As Int64 = 0
            Dim CPLCLP_CodigoPlantaClienteTercero As Int64 = 0
            Dim obrPedidoPlanta As New brDespacho
            Dim intRow As Integer = 1
            For Each obeMercaderia As beMercaderia In Me.dgItemPedido.DataSource
                obePedidoPlanta = New bePedidoPorPlanta
                With obePedidoPlanta
                    .PNCDREGP = obeMercaderia.PNCDREGP
                    .CORRELATIVO = obeMercaderia.PNCDREGP
                    .PNNORDSR = obeMercaderia.PNNORDSR
                    .PSCMRCLR = obeMercaderia.PSCMRCLR
                    .PNFCHSPE = HelpClass.CDate_a_Numero8Digitos(dtpFecha.Value)
                    If dtpFechaContabilizacionSAP.Checked = True Then
                        .PNFECCSP = HelpClass.CDate_a_Numero8Digitos(dtpFechaContabilizacionSAP.Value)
                    End If
                    .PNHRASPE = "000000"
                    .PNCCLNT = Me.CCLNT

                    .PNCPLNCL = 0 'Me.UcPlantaDeEntrega_TxtF011.ItemActual.PNCPLNCL
                    .PNCPRVCL = UcClienteTercero_xtF011.ItemActual.PNCPRVCL
                    .PNCPLCLP = Me.UcPlantaDeEntrega_TxtF011.ItemActual.PNCPLNCL
                    'End If
                    .PNQSRVC = obeMercaderia.PNSALDO
                    .PSCUNCN6 = obeMercaderia.PSCUNCN6
                    .PSTCTCST = ""
                    .PNPSRVC = 0
                    .PSCUNPS6 = ""
                    .PSSATSLS = "P"
                    .PSSATNAL = "P"
                    .PSNRFTPD = Me.txtReferenciaPedido.Text
                    .PSNRFRPD = txtNumeroPedido.Text
                    .PSFLGAPR = ""
                    .PSFLGURG = ""
                    .PSSBCKRD = ""
                    .PSNORCML = txtOrdenDeCompra.Text.Trim
                    .PNFDSPAL = "00000000"
                    .PSTOBSMD = txtMotivoSalida.Text.Trim
                    .PNNRITOC = obeMercaderia.PNCDREGP
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
                    .PSUSRAUT = oDs.Tables(0).Rows(0).Item("USSLCD")
                    .PSARESOL = oDs.Tables(0).Rows(0).Item("ARESOL")
                    .PNFMPDME = oDs.Tables(0).Rows(0).Item("FMPDME")
                    intRow = intRow + 1
                End With
                olbePedidoPlanta.Add(obePedidoPlanta)
            Next
            Dim intResultado As Double = 0
            If olbePedidoPlanta.Count = 0 Then Exit Sub
            intResultado = obrPedidoPlanta.GuardarPedidoPlanta(olbePedidoPlanta)
            If intResultado <> 0 Then
                ActualizarEstado()
                HelpClass.MsgBox("Se ha creado el Pedido N° " & intResultado, MessageBoxIcon.Information)
                Me.Close()
            Else
                HelpClass.ErrorMsgBox()
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ActualizarEstado()
        Dim objDatos As New beInferfazSapPedido
        Dim obrDespacho As New brDespacho
        objDatos.CCMPN = GLOBAL_COMPANIA
        objDatos.CCLNT = Me.CCLNT
        objDatos.CRGVTA = oDs.Tables(0).Rows(0).Item("CRGVTA")
        objDatos.DCENSA = oDs.Tables(0).Rows(0).Item("DCENSA")
        objDatos.PSCULUSA = objSeguridadBN.pUsuario
        objDatos.PSNTRMNL = objSeguridadBN.pstrPCName

        obrDespacho.ActualizarEstadoTransmisionDocumentoSapInterfaz(objDatos)
    End Sub

    Public Sub ValidarMercaderiaRelacionada()

        Try
            Dim dtOrdenServicio As New DataTable()
            Dim Filas As Int64 = dgItemPedido.Rows.Count
            For Each odr As DataGridViewRow In dgItemPedido.Rows


                Dim ohtPedido As New Hashtable
                ohtPedido.Add("PNCCLNT2", Me.CCLNT)
                ohtPedido.Add("PSCMRCLR", "" & odr.Cells("PSCMRCLR").Value & "")
                dtOrdenServicio = New brPedido().ObtenerOrdeDeServicioXMercaderia(ohtPedido).Tables(0)
                If (dtOrdenServicio.Rows.Count > 0) Then
                    odr.Cells("PSCUNCN6").Value = ("" & dtOrdenServicio.Rows(0).Item("CUNCN5")).ToString.Trim
                    odr.Cells("PNNORDSR").Value = dtOrdenServicio.Rows(0).Item("NORDSR")
                    odr.Cells("PSTDITES").Value = ("" & dtOrdenServicio.Rows(0).Item("TMRCD2")).ToString.Trim
                    odr.Cells("CONOS").Value = My.Resources.button_ok
                Else
                    odr.Cells("CONOS").Value = My.Resources.button_cancel
                End If
            Next

        Catch ex As Exception

        End Try

    End Sub

#End Region

End Class

