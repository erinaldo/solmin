Imports Ransa.DAO.Unidad
Imports Ransa.NEGO
Imports Ransa.TypeDef
Imports Ransa.Utilitario
Public Class frmImportarPedido
    Public pedidoImportado As Boolean = False
    Public pedidoSistema As Boolean = False
    Private opdtUnidad As DataTable
    Private sDefault_Peso As String = ""
    Public Event ErrorMessage(ByVal strMensaje As String)
    Public CCLNT As Int64 = 0
    Private odtPedidoCabecera As DataTable
    Private odtPedidoDetalle As DataTable
    Public pSinOrdenServicioAsociado As Int64 = 0
    Public CodigoPedido_CDPEPL As Int64 = 0


    Private Sub CargarUnidad()
        'Dim oUnidad As cUnidad = New cUnidad
        Dim oUnidad As Ransa.Controls.Unidad.cUnidad = New Ransa.Controls.Unidad.cUnidad
        opdtUnidad = oUnidad.fdtListar("", sDefault_Peso)
    End Sub
    Private Function RetornaPosicionInicioNumero(ByVal lstr_Cadena As String) As Int32
        lstr_Cadena = lstr_Cadena.Trim
        Dim EsNumero As Boolean = False
        Dim Posicion As Int32 = 0
        'Try
        For lint_Contador As Integer = 0 To lstr_Cadena.Trim.Length - 1
            Posicion = lint_Contador
            If Char.IsNumber(lstr_Cadena.Substring(lint_Contador, 1).Trim) Then
                EsNumero = True
                Exit For
            End If
        Next
        'Catch ex As Exception
        'End Try
        Return Posicion
    End Function
    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        Try
            If txtReferenciaPedido.Text.Trim.Equals("") Or txtNumeroPedido.Text.Trim.Equals("") Then
                Exit Sub
            End If
            txtNumeroPedido_Validating(txtNumeroPedido, Nothing)
            If (CodigoPedido_CDPEPL <> 0) Then
                MessageBox.Show(" El pedido ya fue importado anteriormente " & Chr(13) & "No se puede importar otra vez", "Verificación Pedido", MessageBoxButtons.OK)
                Exit Sub
            End If
            ImportarPedido()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ImportarPedido()
        'Try
        odtPedidoCabecera = New DataTable()
        odtPedidoDetalle = New DataTable()
        Dim obeProveedor As New beProveedor()
        Dim oblProveedor As New blProveedor()
        Dim oParameter As New Db2Manager.RansaData.iSeries.DataObjects.Parameter()

        oParameter.Add("in_vc_OrderType", txtReferenciaPedido.Text)
        oParameter.Add("in_vc_OrderNumber", txtNumeroPedido.Text)
        oParameter.Add("vc_Usuario", objSeguridadBN.pUsuario)

        odtPedidoCabecera = New brIntegracion().Integracion_Obtener_Pedido_Cabecera(Me.CCLNT, oParameter)

        If odtPedidoCabecera.TableName.Equals("Error_Table") Then
            Throw New Exception(odtPedidoCabecera.Rows(0).Item("Error").ToString)
        End If

        If odtPedidoCabecera.Rows.Count > 0 Then
            pedidoImportado = True

            If (DBNull.Value IsNot odtPedidoCabecera.Rows(0).Item("dt_OrderDate")) Then
                dtpFecha.Value = odtPedidoCabecera.Rows(0).Item("dt_OrderDate")
            Else
                dtpFecha.Value = Date.Now
            End If
            txtMotivoSalida.Text = ("" & odtPedidoCabecera.Rows(0).Item("vc_OutputGround")).ToString.Trim
            'txtLugarOrigen.Text = ("" & odtPedidoCabecera.Rows(0).Item("vc_HomeName")).ToString.Trim
            'txtDireccionOrigen.Text = ("" & odtPedidoCabecera.Rows(0).Item("vc_HomeAddress")).ToString.Trim

            ''------------------insercion del provvedor de ABB -> en caso no se encontrara(rzol05)----------------
            obeProveedor.CPRVCL_CodClienteTercero = 0
            If (IsNumeric(("" & odtPedidoCabecera.Rows(0).Item("vc_CustomerFiscalCodeDeliver")).ToString.Trim) = True) Then
                obeProveedor.NRUCPR_RucProveedor = Val(("" & odtPedidoCabecera.Rows(0).Item("vc_CustomerFiscalCodeDeliver")).ToString.Trim)
            Else
                obeProveedor.NRUCPR_RucProveedor = 0
            End If

            If ("" & odtPedidoCabecera.Rows(0).Item("Direccion")).ToString.Trim.Length > 35 Then
                Dim intDir As Integer = ("" & odtPedidoCabecera.Rows(0).Item("Direccion")).ToString.Trim.Length
                obeProveedor.PSTDRPRC = ("" & odtPedidoCabecera.Rows(0).Item("Direccion")).ToString.Trim.Substring(0, 35)
                obeProveedor.PSTPRSCN = ("" & odtPedidoCabecera.Rows(0).Item("Direccion")).ToString.Trim.Substring(35, intDir - 35)
            Else
                obeProveedor.PSTDRPRC = ("" & odtPedidoCabecera.Rows(0).Item("Direccion")).ToString.Trim
                obeProveedor.PSTPRSCN = ""
            End If

            If ("" & odtPedidoCabecera.Rows(0).Item("vc_CustomerFiscalName")).ToString.Trim.Length > 30 Then
                Dim intDir As Integer = ("" & odtPedidoCabecera.Rows(0).Item("vc_CustomerFiscalName")).ToString.Trim.Length
                obeProveedor.PSTPRVCL = ("" & odtPedidoCabecera.Rows(0).Item("vc_CustomerFiscalName")).ToString.Trim.Substring(0, 30)
                obeProveedor.PSTPRCL1 = ("" & odtPedidoCabecera.Rows(0).Item("vc_CustomerFiscalName")).ToString.Trim.Substring(30, intDir - 30)
            Else
                obeProveedor.PSTPRVCL = ("" & odtPedidoCabecera.Rows(0).Item("vc_CustomerFiscalName")).ToString.Trim
                obeProveedor.PSTPRCL1 = ""
            End If
            obeProveedor.TNROFX_NroFax = "" '("" & odtPedidoCabecera.Rows(0).Item("vc_Fax")).ToString.Trim
            obeProveedor.TLFN02_FonoContacto = "" ' ("" & odtPedidoCabecera.Rows(0).Item("vc_Telefono")).ToString.Trim
            obeProveedor.TMAI03_EmailContacto = ""
            obeProveedor.CULUSA_UsuarioAct = objSeguridadBN.pUsuario
            obeProveedor.CUSCRT_UsuarioCre = objSeguridadBN.pUsuario
            obeProveedor.CCLNT_CodigoCliente = Me.CCLNT
            obeProveedor.CPRPCL_CodigoClienteProveedor = ("" & odtPedidoCabecera.Rows(0).Item("vc_CustomerCodeDeliver")).ToString.Trim
            ''Para Planta
            If ("" & odtPedidoCabecera.Rows(0).Item("Direccion")).ToString.Trim.Length > 35 Then
                obeProveedor.PSTDRPCP = ("" & odtPedidoCabecera.Rows(0).Item("Direccion")).ToString.Trim.Substring(0, 35)
                obeProveedor.PSTDRDST = ("" & odtPedidoCabecera.Rows(0).Item("Direccion")).ToString.Trim.Substring(35, ("" & odtPedidoCabecera.Rows(0).Item("Direccion")).ToString.Trim.Length - 35)
            Else
                obeProveedor.PSTDRPCP = ("" & odtPedidoCabecera.Rows(0).Item("Direccion")).ToString.Trim
                obeProveedor.PSTDRDST = ""
            End If
            'CÓDIGO DE PLANTA SI ES QUE TIENE CENTRO DE COSTO
            obeProveedor.PSNTLFPL = "" '("" & odtPedidoCabecera.Rows(0).Item("Telefono")).ToString.Trim
            obeProveedor.CREAR_RELACION_CrearRelacionClientevsProveedor = "C"
            'Datos para el centro de costo
            obeProveedor.PSCCTCST = (("" & odtPedidoCabecera.Rows(0).Item("vc_CentroCosto")).ToString.Trim)
            obeProveedor.PSTDSCNT = (("" & odtPedidoCabecera.Rows(0).Item("vc_CustomerFiscalName")).ToString.Trim)
            obeProveedor.PSCDIVSU = ""
            obeProveedor.PSCDUNNG = (("" & odtPedidoCabecera.Rows(0).Item("vc_Bu")).ToString.Trim)
            obeProveedor.PSCDGALM = (("" & odtPedidoCabecera.Rows(0).Item("vc_Almacen")).ToString.Trim)
            obeProveedor.PSCCLTTM = (("" & odtPedidoCabecera.Rows(0).Item("vc_CustomerCodeDeliver")).ToString.Trim)
            obeProveedor.PSNTRMNL = objSeguridadBN.pstrPCName()
            obeProveedor.PSINTERNO = (("" & odtPedidoCabecera.Rows(0).Item("ch_Interno")).ToString.Trim)
            obeProveedor = oblProveedor.fblnRegistrar_Proveedor_de_ABB(obeProveedor)

            If obeProveedor.CPRVCL_CodClienteTercero <> 0 Then
                Tercero()
                Dim obePlantaDeEntregaC As New PlantaDeEntrega.bePlantaDeEntrega
                With obePlantaDeEntregaC
                    .TIPOCLIENTE = False  'propio o tercero
                    .PNCCLNT = Me.CCLNT
                    .PNCPRVCL = obeProveedor.CPRVCL_CodClienteTercero
                    .PSTPRVCL = ""
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

            Else
                Propio()
                Dim obePlantaDeEntrega As New PlantaDeEntrega.bePlantaDeEntrega
                With obePlantaDeEntrega
                    .TIPOCLIENTE = True  'propio o tercero
                    .PNCCLNT = Me.CCLNT
                    .PNCPRVCL = 0 'cliente tercero
                    .PNCPLNCL = obeProveedor.CPLCLP_CodPlanta
                    .PSTCMPPL = "" ' descripcion opciona
                End With
                UcPlantaDeEntrega_TxtF011.pCargar(obePlantaDeEntrega)

            End If


            ''---------------------Cargar Tipo CLiente------------------------------------------------------------


            ''---------------------
            odtPedidoDetalle = New brIntegracion().Integracion_Obtener_Pedido_Detalle(Me.CCLNT, oParameter)

            If odtPedidoDetalle.TableName.Equals("Error_Table") Then
                Throw New Exception(odtPedidoDetalle.Rows(0).Item("Error").ToString)
            End If

            dgItemPedido.DataSource = odtPedidoDetalle
            ValidarMercaderiaRelacionada()
            If (pSinOrdenServicioAsociado > 0) Then
                MessageBox.Show(" Cantidad de Mercaderías sin Orden de Servicio: " & pSinOrdenServicioAsociado & Chr(13) & " No será posible guardar el pedido hasta que todas las mercadería  a importar " & Chr(13) & " tengan su Orden de Servicio", "Verificación Orden Servicio", MessageBoxButtons.OK)
            End If
            pedidoImportado = True
            txtNumeroPedido.CausesValidation = False
        End If
        'Catch ex As Exception

        'End Try

    End Sub
    Private Function fblnValidarCabecera() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True
        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnResultado = False
        End If
        Return blnResultado
    End Function
    Private Function ValidarDetalle() As Boolean
        Dim strMensajeError As String = ""
        Dim blnEstado As Boolean = True
        Dim intNumRow As Integer = 0
        'Try
        For Each oDr As DataGridViewRow In Me.dgItemPedido.Rows
            If ("" & oDr.Cells("CUNCN6").Value).ToString.Trim = "" Then
                strMensajeError &= "Debe ingresar las unidades de medida." & Convert.ToChar(10) & Convert.ToChar(13)
            End If
            If strMensajeError <> "" Then
                MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                dgItemPedido.Rows(intNumRow).ErrorText = strMensajeError
                blnEstado = False
                Exit Function
            Else
                dgItemPedido.Rows(intNumRow).ErrorText = ""
            End If
            intNumRow += 1
        Next
        'Catch ex As Exception

        'End Try

        Return blnEstado
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try

            If (dgItemPedido.Rows.Count = 0) Then
                MessageBox.Show(".No exiten datos." & Chr(13) & "No se puede realizar la operación", " Verificación Datos", MessageBoxButtons.OK)
                Exit Sub
            End If
            If (pedidoImportado = False) Then
                txtNumeroPedido_Validating(txtNumeroPedido, Nothing)
            End If
            If (CodigoPedido_CDPEPL <> 0) Then
                MessageBox.Show(" El pedido ya fue importado anteriormente " & Chr(13) & "No se puede realizar la operación", "Verificación Pedido", MessageBoxButtons.OK)
                Exit Sub
            End If
            If (pSinOrdenServicioAsociado > 0 And pedidoImportado = True) Then
                MessageBox.Show(" Cantidad de Mercaderías sin Orden de Servicio: " & pSinOrdenServicioAsociado & Chr(13) & " No es posible realizar la operación hasta que todas las mercadería a importar" & Chr(13) & " tengan su Orden de Servicio", "Verificación Orden Servicio", MessageBoxButtons.OK)
                Exit Sub
            End If

            If Not fblnValidarCabecera() Then Exit Sub
            If Not ValidarDetalle() Then Exit Sub
            GuardarPedido()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GuardarPedido()
        'Try
        Dim obePedidoPlanta As New bePedidoPorPlanta
        Dim olbePedidoPlanta As New List(Of bePedidoPorPlanta)
        Dim CPLNCL_CodigoPlantaCliente As Int64 = 0
        Dim CPLCLP_CodigoPlantaClienteTercero As Int64 = 0
        Dim obrPedidoPlanta As New brDespacho
        Dim intRow As Integer = 1
        For Each oDrMercaderia As DataGridViewRow In Me.dgItemPedido.Rows
            obePedidoPlanta = New bePedidoPorPlanta
            With obePedidoPlanta
                .PNCDREGP = intRow
                .PNNORDSR = oDrMercaderia.Cells("NORDSR").Value
                .PSCMRCLR = ("" & oDrMercaderia.Cells("vc_StockCode").Value).ToString.Trim
                .PNFCHSPE = HelpClass.CDate_a_Numero8Digitos(odtPedidoCabecera.Rows(0).Item("dt_OrderDate"))
                .PNHRASPE = "000000"
                .PNCCLNT = Me.CCLNT
                If UcPlantaDeEntrega_TxtF011.TipoPlantaDeEntrega Then
                    .PNCPLNCL = Me.UcPlantaDeEntrega_TxtF011.ItemActual.PNCPLNCL
                    .PNCPRVCL = 0
                    .PNCPLCLP = 0
                Else
                    .PNCPLNCL = 0
                    .PNCPRVCL = UcClienteTercero_xtF011.ItemActual.PNCPRVCL
                    .PNCPLCLP = Me.UcPlantaDeEntrega_TxtF011.ItemActual.PNCPLNCL
                End If
                .PNQSRVC = Val("" & oDrMercaderia.Cells("fl_Quantity").Value)
                .PSCUNCN6 = ("" & oDrMercaderia.Cells("CUNCN6").Value).ToString.Trim
                .PSTCTCST = ("" & oDrMercaderia.Cells("vc_CentroCosto").Value).ToString.Trim
                .PNPSRVC = 0
                .PSCUNPS6 = ""
                .PSSATSLS = "P"
                .PSSATNAL = "P"
                .PSNRFTPD = txtReferenciaPedido.Text
                .PSNRFRPD = txtNumeroPedido.Text
                .PSFLGAPR = ""
                .PSFLGURG = ""
                .PSSBCKRD = ""
                .PSNORCML = txtOrdenDeCompra.Text
                .PNFDSPAL = "00000000"
                .PSTOBSMD = ("" & odtPedidoCabecera.Rows(0).Item("vc_OutputGround")).ToString.Trim
                .PNNRITOC = oDrMercaderia.Cells("vc_OrderNumberLine").Value
                .PSNLTECL = ("" & oDrMercaderia.Cells("in_OrderLine").Value).ToString.Trim
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
        Next
        Dim intResultado As Double = 0
        intResultado = obrPedidoPlanta.GuardarPedidoPlanta(olbePedidoPlanta)
        If intResultado <> 0 Then
            HelpClass.MsgBox("Se ha creado el Pedido N° " & intResultado, MessageBoxIcon.Information)
            Me.Close()
        Else
            HelpClass.ErrorMsgBox()
        End If
        'Catch ex As Exception
        'End Try
    End Sub
    Private Sub frmImportarPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dgItemPedido.AutoGenerateColumns = False
            LimpiarControl()
            Propio()
            CargarUnidad()
            txtNumeroPedido.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
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

    Private Sub txtTipoOrden_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            If (e.KeyChar = ChrW(13)) Then
                txtNumeroPedido.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dgItemPedido_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgItemPedido.EditingControlShowing
        Try
            If TypeOf e.Control Is TextBox Then
                If dgItemPedido.CurrentCell.ColumnIndex = 3 Then ' Checking Whether the Editing Control Column Index is 1 or not if 1 Then Enabling Auto Complete Extender
                    With DirectCast(e.Control, TextBox)
                        If opdtUnidad.Rows.Count > 0 Then
                            Dim rwTemp As DataRow
                            For Each rwTemp In opdtUnidad.Rows
                                .AutoCompleteCustomSource.Add(("" & rwTemp.Item(0)).ToString.Trim)
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

            Else
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    Public Sub ValidarMercaderiaRelacionada()
        pSinOrdenServicioAsociado = 0
        'Try
        Dim dtOrdenServicio As New DataTable()
        Dim Filas As Int64 = dgItemPedido.Rows.Count
        For Each odr As DataGridViewRow In dgItemPedido.Rows
            Dim ohtPedido As New Hashtable
            ohtPedido.Add("PNCCLNT2", Me.CCLNT)
            ohtPedido.Add("PSCMRCLR", "" & odr.Cells("vc_StockCode").Value & "")
            dtOrdenServicio = New brPedido().ObtenerOrdeDeServicioXMercaderia(ohtPedido).Tables(0)
            If (dtOrdenServicio.Rows.Count > 0) Then
                odr.Cells("CUNCN6").Value = ("" & dtOrdenServicio.Rows(0).Item("CUNCN5")).ToString.Trim
                odr.Cells("NORDSR").Value = Val("" & dtOrdenServicio.Rows(0).Item("NORDSR"))
                odr.Cells("vc_LineDescriptionLine1").Value = ("" & dtOrdenServicio.Rows(0).Item("TMRCD2")).ToString.Trim
                odr.Cells("CONOS").Value = My.Resources.button_ok
            Else
                pSinOrdenServicioAsociado += 1
                odr.Cells("CUNCN6").Value = ""
                odr.Cells("CONOS").Value = My.Resources.button_cancel
            End If
        Next
        'Catch ex As Exception
        'End Try

    End Sub


    Private Sub dgItemPedido_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgItemPedido.CellEndEdit
        Dim strMensajeError As String = ""
        Dim blUnidadMedida As New blUnidadMedida()
        Try
            Dim descripcionUnidadMedida As String = ""
            With dgItemPedido
                Select Case .Columns(e.ColumnIndex).Name
                    Case "CUNCN6"
                        descripcionUnidadMedida = .CurrentCell.Value.ToString
                        descripcionUnidadMedida = descripcionUnidadMedida.ToUpper()
                        Dim dt As New DataTable()
                        Dim strResultado As String = ""
                        dt = blUnidadMedida.Obtener_Obtener_UnidadMedida_x_Descripcion(descripcionUnidadMedida)
                        If (dt.Rows.Count > 0) Then
                            strResultado = ("" & dt.Rows(0).Item("CUNDMD")).ToString.Trim
                        End If
                        If (strResultado = "" And descripcionUnidadMedida.Length > 3) Then
                            .CurrentCell.Value = descripcionUnidadMedida.Substring(0, 3)
                        End If
                        If Not strResultado.ToString.Trim.Equals("") Then
                            .CurrentCell.Value = strResultado
                        End If
                End Select
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtNumeroPedido_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumeroPedido.TextChanged
        Try
            txtNumeroPedido.CausesValidation = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtNumeroPedido_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNumeroPedido.Validating
        Try
            If Not (Me.txtReferenciaPedido.Text.Trim.Equals("") And Me.txtNumeroPedido.Text.Trim.Equals("")) Then
                CargarPedido(Me.txtReferenciaPedido.Text, Me.txtNumeroPedido.Text)
            End If
            txtNumeroPedido.CausesValidation = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarPedido(ByVal TipoReferenci_NRFTPD As String, ByVal NroReferencia_NRFRPD As String)
        'Try
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
            If Val("" & odtPedido.Rows(0).Item("CPRVCL")) <> 0 Then
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

            Else
                Dim obePlantaDeEntrega As New PlantaDeEntrega.bePlantaDeEntrega
                With obePlantaDeEntrega
                    .TIPOCLIENTE = True  'propio o tercero
                    .PNCCLNT = Me.CCLNT
                    .PNCPRVCL = 0 'cliente tercero
                    .PNCPLNCL = "" & odtPedido.Rows(0).Item("CPLNCL") & ""
                    .PSTCMPPL = "" ' descripcion opciona 
                End With
                UcPlantaDeEntrega_TxtF011.pCargar(obePlantaDeEntrega)
                Propio()
            End If
            dgItemPedido.DataSource = odtPedido
            pedidoSistema = True
        Else
            LimpiarContenido()
        End If
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub LimpiarControl()
        UcPlantaDeEntrega_TxtF011.CodCliente = Me.CCLNT
        UcClienteTercero_xtF011.CodCliente = Me.CCLNT
        UcPlantaDeEntrega_TxtF011.pClear()
        UcClienteTercero_xtF011.pClear()
    End Sub

    Private Sub UcClienteTercero_xtF011_TextChanged()
        UcPlantaDeEntrega_TxtF011.pClear()
        UcPlantaDeEntrega_TxtF011.CodClienteTercero = UcClienteTercero_xtF011.ItemActual.PNCPRVCL
    End Sub

    Private Sub Propio()
        UcPlantaDeEntrega_TxtF011.TipoPlantaDeEntrega = True
        UcClienteTercero_xtF011.Visible = False
        lblClienteTercero.Visible = False
        Me.lblPlantaTercero.Location = New System.Drawing.Point(19, 169)
        Me.UcPlantaDeEntrega_TxtF011.Location = New System.Drawing.Point(141, 170)
        LimpiarControl()
    End Sub

    Private Sub Tercero()
        UcPlantaDeEntrega_TxtF011.TipoPlantaDeEntrega = False
        UcClienteTercero_xtF011.Visible = True
        lblClienteTercero.Visible = True
        Me.lblPlantaTercero.Location = New System.Drawing.Point(19, 194)
        Me.UcPlantaDeEntrega_TxtF011.Location = New System.Drawing.Point(141, 196)
        LimpiarControl()
    End Sub


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


   
End Class


