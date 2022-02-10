Imports Ransa.DAO.Unidad
Imports Ransa.NEGO
Imports Ransa.TypeDef
Imports Ransa.Utilitario

Public Class frmImportarPedidoABB

#Region "Atributos y Propiedades "

    Private _CodCliente As Decimal
    ''' <summary>
    ''' Código de Cliente a Migrar
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CodCliente() As Decimal
        Get
            Return _CodCliente
        End Get
        Set(ByVal value As Decimal)
            _CodCliente = value
        End Set
    End Property

#End Region
    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        Try
            ImportarPedido()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#Region "Metodos"

    Private Sub ImportarPedido()

        'Try
        Dim oDs As New DataSet
        Dim oDtPedido As New DataTable
        Dim oDtDetallePedido As New DataTable
        Dim strError As String = String.Empty

        oDs = New brIntegracion().Integracion_Lista_Pedidos_Pendientes(_CodCliente)

        If oDs.Tables(0).TableName.Equals("Error_Table") Then
            Throw New Exception(oDs.Tables(0).Rows(0).Item("Error").ToString)
        End If

        oDtPedido = oDs.Tables(0)
        oDtDetallePedido = oDs.Tables(1)
        'Me.dtgPedido.DataSource = oDs.Tables(0)
        ' Me.dtgItemPedido.DataSource = oDs.Tables(1)

        Dim obePedido As New bePedidoPorPlanta
        Dim obrProveedor As New blProveedor()
        Dim obeProveedor As beProveedor
        Dim olbePedido As New List(Of bePedidoPorPlanta)

        For Each oDr As DataRow In oDtPedido.Rows
            obePedido = New bePedidoPorPlanta
            obePedido.PNCCLNT = _CodCliente
            obePedido.PSCODPEDIDO = oDr.Item("CodPedido").ToString.Trim
            obePedido.PSNRFTPD = oDr.Item("TipoPedido").ToString.Trim
            obePedido.PSNRFRPD = oDr.Item("Pedido").ToString.Trim
            obePedido.PSTOBSMD = oDr.Item("MotivoPedido").ToString.Trim 
            obePedido.PNFCHSPE = HelpClass.CFecha_a_Numero8Digitos(oDr.Item("FechaSolicitud"))

            obeProveedor = New beProveedor
            obeProveedor.CCLNT_CodigoCliente = _CodCliente
            If IsNumeric(oDr.Item("RucClienteTercero")) Then
                obeProveedor.NRUCPR_RucProveedor = oDr.Item("RucClienteTercero")
            Else
                obeProveedor.NRUCPR_RucProveedor = 0
            End If
            If oDr.Item("DirClienteTercero").ToString.Trim.Length > 35 Then
                Dim intDir As Integer = ("" & oDr.Item("DirClienteTercero").ToString.Trim).ToString.Trim.Length


                obeProveedor.PSTDRPRC = HelpClass.validaCaracter(("" & oDr.Item("DirClienteTercero").ToString.Trim).ToString.Trim.Substring(0, 35) & "", strError)
                obeProveedor.PSTPRSCN = HelpClass.validaCaracter(("" & oDr.Item("DirClienteTercero")).ToString.Trim.Substring(35, intDir - 35), strError)
            Else
                obeProveedor.PSTDRPRC = HelpClass.validaCaracter(("" & oDr.Item("DirClienteTercero")).ToString.Trim, strError)
                obeProveedor.PSTPRSCN = ""
            End If


            If ("" & oDr.Item("NombreClienteTercero")).ToString.Trim.Length > 30 Then
                Dim intDir As Integer = ("" & oDr.Item("NombreClienteTercero")).ToString.Trim.Length
                obeProveedor.PSTPRVCL = HelpClass.validaCaracter(("" & oDr.Item("NombreClienteTercero")).ToString.Trim.Substring(0, 30), strError)
                obeProveedor.PSTPRCL1 = HelpClass.validaCaracter(("" & oDr.Item("NombreClienteTercero")).ToString.Trim.Substring(30, intDir - 30), strError)
            Else
                obeProveedor.PSTPRVCL = HelpClass.validaCaracter(("" & oDr.Item("NombreClienteTercero")).ToString.Trim, strError)
                obeProveedor.PSTPRCL1 = ""
            End If
            obeProveedor.CPRPCL_CodigoClienteProveedor = ("" & oDr.Item("CodClienteTercero")).ToString.Trim
            ''Para Planta
            If ("" & oDr.Item("DirClienteTercero")).ToString.Trim.Length > 35 Then
                obeProveedor.PSTDRPCP = HelpClass.validaCaracter(("" & oDr.Item("DirClienteTercero")).ToString.Trim.Substring(0, 35), strError)
                obeProveedor.PSTDRDST = HelpClass.validaCaracter(("" & oDr.Item("DirClienteTercero")).ToString.Trim.Substring(35, ("" & oDr.Item("DirClienteTercero")).ToString.Trim.Length - 35), strError)
            Else
                obeProveedor.PSTDRPCP = HelpClass.validaCaracter(("" & oDr.Item("DirClienteTercero")).ToString.Trim, strError)
                obeProveedor.PSTDRDST = ""
            End If
            'CÓDIGO DE PLANTA SI ES QUE TIENE CENTRO DE COSTO
            obeProveedor.CREAR_RELACION_CrearRelacionClientevsProveedor = "C"
            'Datos para el centro de costo
            obeProveedor.PSTDSCNT = HelpClass.validaCaracter((("" & oDr.Item("NombreClienteTercero")).ToString.Trim), strError)
            obeProveedor.PSCCTCST = (("" & oDr.Item("CentroCosto")).ToString.Trim)
            obeProveedor.PSCDUNNG = (("" & oDr.Item("Bu")).ToString.Trim)
            obeProveedor.PSCDGALM = (("" & oDr.Item("Almacen")).ToString.Trim)
            obeProveedor.PSCCLTTM = (("" & oDr.Item("CodClienteTercero")).ToString.Trim)
            obeProveedor.PSNTRMNL = objSeguridadBN.pstrPCName()
            If obePedido.PSNRFTPD = "Bono" Then
                obeProveedor.PSINTERNO = "1"
            Else
                obeProveedor.PSINTERNO = (("" & oDr.Item("Interno")).ToString.Trim)
            End If

            obeProveedor.CULUSA_UsuarioAct = objSeguridadBN.pUsuario
            obeProveedor.CUSCRT_UsuarioCre = objSeguridadBN.pUsuario

            If strError.Length > 0 Then
                HelpClass.ErrorMsgBox()
                Exit Sub
            End If
            obeProveedor = obrProveedor.fblnRegistrar_Proveedor_de_ABB(obeProveedor)
            If obeProveedor.CPRVCL_CodClienteTercero.ToString.Trim.Equals("0") Then
                obePedido.PNCPLNCL = obeProveedor.CPLCLP_CodPlanta
                If obePedido.PNCPLNCL.ToString.Trim.Equals("0") Then
                    HelpClass.ErrorMsgBox()
                    Exit Sub
                End If
            Else
                obePedido.PNCPRVCL = obeProveedor.CPRVCL_CodClienteTercero
                obePedido.PNCPLCLP = obeProveedor.CPLCLP_CodPlanta
            End If
            obePedido.PSCLIENTE = HelpClass.validaCaracter((("" & oDr.Item("NombreClienteTercero")).ToString.Trim), strError)
            obePedido.PSDIRECCION = HelpClass.validaCaracter(("" & oDr.Item("DirClienteTercero")).ToString, strError)

            obePedido.CHECK = True
            olbePedido.Add(obePedido)
        Next
        dtgPedidos.AutoGenerateColumns = False
        '===========Detalle de pedido ==================
        LLenarDetallePedido(oDs.Tables(1))
        '==============================================
        Me.dtgPedidos.DataSource = olbePedido

       

        'Falta enlazar el pedido con la Cantidad Orden Servicio


        'Catch ex As Exception
        'End Try


    End Sub

    Private olbeDetallePedido As New List(Of bePedidoPorPlanta)

    Private Sub LLenarDetallePedido(ByVal oDt As DataTable)
        Dim obePedido As bePedidoPorPlanta
        'Try
        Dim dtOrdenServicio As New DataTable()
        Dim Filas As Int64 = dtgItemPedido.Rows.Count
        For Each odr As DataRow In oDt.Rows
            obePedido = New bePedidoPorPlanta

            Dim ohtPedido As New Hashtable
            ohtPedido.Add("PNCCLNT2", _CodCliente)
            ohtPedido.Add("PSCMRCLR", "" & odr.Item("CodMercaderia") & "")
            'dtOrdenServicio = New brPedido().ObtenerOrdeDeServicioXMercaderia(ohtPedido).Tables(0)
            dtOrdenServicio = New brPedido().ListarOrdenServicio_X_SKU_ValidaPedido(ohtPedido)
            obePedido.PNCANT_OS_X_SKU = dtOrdenServicio.Rows.Count

            If dtOrdenServicio.Rows.Count = 1 Then
                obePedido.PSCUNCN6 = ("" & dtOrdenServicio.Rows(0).Item("CUNCN5")).ToString.Trim
                obePedido.PNNORDSR = Val("" & dtOrdenServicio.Rows(0).Item("NORDSR"))
                obePedido.PSMERCADERIA = ("" & dtOrdenServicio.Rows(0).Item("TMRCD2")).ToString.Trim

                obePedido.ESTADO = True
            Else
                obePedido.ESTADO = False
            End If
            If dtOrdenServicio.Rows.Count = 0 Then
                obePedido.PSTOBS_CARGA_ITEM = "Sin O/S"
            End If
            If dtOrdenServicio.Rows.Count > 1 Then
                obePedido.PSTOBS_CARGA_ITEM = "con más de 1 Orden Servicio asignado (" & dtOrdenServicio.Rows.Count & ")"
            End If

            'If (dtOrdenServicio.Rows.Count > 0) Then
            '    obePedido.PSCUNCN6 = ("" & dtOrdenServicio.Rows(0).Item("CUNCN5")).ToString.Trim
            '    obePedido.PNNORDSR = Val("" & dtOrdenServicio.Rows(0).Item("NORDSR"))
            '    obePedido.PSMERCADERIA = ("" & dtOrdenServicio.Rows(0).Item("TMRCD2")).ToString.Trim

            '    obePedido.ESTADO = True
            'Else
            '    obePedido.ESTADO = False
            'End If
            obePedido.PSCODPEDIDO = odr.Item("CodPedido").ToString.Trim
            obePedido.PSCMRCLR = "" & odr.Item("CodMercaderia") & ""
            obePedido.PNQSRVC = odr.Item("Cantidad")
            obePedido.PSNLTECL = odr.Item("OrderLine")
            obePedido.PSTCTCST = odr.Item("CentroCosto")
            obePedido.PNNRITOC = odr.Item("NumberLine")
            obePedido.PSNRFRPD = odr.Item("Pedido")
            obePedido.PSNRFTPD = odr.Item("TipoPedido")
            obePedido.PSTOBSGS = ("" & odr.Item("DescripcionExtendida")).ToString

            olbeDetallePedido.Add(obePedido)
        Next
        'Catch ex As Exception
        'End Try
        dtgItemPedido.AutoGenerateColumns = False
    End Sub


#End Region

    Private Sub dtgItemPedido_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dtgItemPedido.DataBindingComplete
        For intRow As Integer = 0 To Me.dtgItemPedido.Rows.Count - 1
            If Me.dtgItemPedido.Rows(intRow).DataBoundItem.ESTADO Then
                Me.dtgItemPedido.Rows(intRow).Cells("CONOS").Value = My.Resources.button_ok
            Else
                Me.dtgItemPedido.Rows(intRow).Cells("CONOS").Value = My.Resources.button_cancel
            End If
        Next
    End Sub

    Private Sub dtgPedidos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgPedidos.SelectionChanged

        Try
            strTipoRef = Me.dtgPedidos.CurrentRow.DataBoundItem.PSNRFTPD
            strNrRef = Me.dtgPedidos.CurrentRow.DataBoundItem.PSNRFRPD
            strCodPedido = Me.dtgPedidos.CurrentRow.DataBoundItem.PSCODPEDIDO
            Me.dtgItemPedido.DataSource = olbeDetallePedido.FindAll(MatchItemPedido)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

#Region "Búsqueda de Item"
    Private strTipoRef As String = ""
    Private strNrRef As String = ""
    Private strCodPedido As String = ""

    Private MatchItemPedido As New Predicate(Of bePedidoPorPlanta)(AddressOf BuscarItemPedido)

    Public Function BuscarItemPedido(ByVal pbePedidoPorPlanta As bePedidoPorPlanta) As Boolean
        'If (pbePedidoPorPlanta.PSNRFTPD = strTipoRef) And (pbePedidoPorPlanta.PSNRFRPD = strNrRef) Then
        '    Return True
        'Else
        '    Return False
        'End If
        If (pbePedidoPorPlanta.PSNRFTPD = strTipoRef) And (pbePedidoPorPlanta.PSNRFRPD = strNrRef) And (pbePedidoPorPlanta.PSCODPEDIDO = strCodPedido) Then
            Return True
        Else
            Return False
        End If

    End Function

    Private MatchItemOkPedido As New Predicate(Of bePedidoPorPlanta)(AddressOf BuscarItemOkPedido)

    Public Function BuscarItemOkPedido(ByVal pbePedidoPorPlanta As bePedidoPorPlanta) As Boolean
        'If (pbePedidoPorPlanta.PSNRFTPD = strTipoRef) And (pbePedidoPorPlanta.PSNRFRPD = strNrRef) And (pbePedidoPorPlanta.ESTADO) Then
        '    Return True
        'Else
        '    Return False
        'End If
        If (pbePedidoPorPlanta.PSNRFTPD = strTipoRef) And (pbePedidoPorPlanta.PSNRFRPD = strNrRef) And (pbePedidoPorPlanta.ESTADO) And (pbePedidoPorPlanta.PSCODPEDIDO = strCodPedido) Then
            Return True
        Else
            Return False
        End If
    End Function

#End Region

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            GuardarPedido()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub GuardarPedido()
        'Try
        dtgPedidos.EndEdit()
        Dim strPedidos As String = ""
        'Dim olbePedidoPlanta As New List(Of bePedidoPorPlanta)
        Dim olbeItemsPedido As New List(Of bePedidoPorPlanta)
        Dim obrPedidoPlanta As New brDespacho
        Dim obePedidoPlanta As New bePedidoPorPlanta
        Dim intResultado As Double = 0
        Dim intx As Integer = 0
        'Dim CantRegSel As Integer = 0

        'CHK
        'Dim ListPedido As New Hashtable
        Dim obelistPedido As New List(Of ProxyRansa.WSABB.Integracion.bePedido)
        For Each obePedido As bePedidoPorPlanta In dtgPedidos.DataSource
            ' olbePedidoPlanta = New List(Of bePedidoPorPlanta)
            intx += 1
            olbeItemsPedido = New List(Of bePedidoPorPlanta)
            strTipoRef = obePedido.PSNRFTPD
            strNrRef = obePedido.PSNRFRPD

            If obePedido.CHECK = True Then
                olbeItemsPedido = olbeDetallePedido.FindAll(MatchItemOkPedido)
                'CantRegSel = CantRegSel + 1
            End If
            For Each obeItemPed As bePedidoPorPlanta In olbeItemsPedido
                If obeItemPed.ESTADO Then
                    With obeItemPed
                        .PNFCHSPE = obePedido.PNFCHSPE
                        .PNHRASPE = "000000"
                        .PNCCLNT = _CodCliente
                        'Asiganamos cliente y planta
                        .PNCPLNCL = obePedido.PNCPLNCL
                        .PNCPRVCL = obePedido.PNCPRVCL
                        .PNCPLCLP = obePedido.PNCPLCLP
                        ' .PSTOBSGS = obePedido.PSTOBSGS
                        .PNPSRVC = 0
                        .PSCUNPS6 = ""
                        .PSSATSLS = "P"
                        .PSSATNAL = "P"
                        .PSFLGAPR = ""
                        .PSFLGURG = ""
                        .PSSBCKRD = ""
                        .PSNORCML = ""
                        .PNFDSPAL = "00000000"
                        .PSTOBSMD = obePedido.PSTOBSMD
                        .PNNROSEQ = 0
                        .PNFULTAC = HelpClass.CDate_a_Numero8Digitos(Now)
                        .PNHULTAC = HelpClass.NowNumeric
                        .PSCULUSA = objSeguridadBN.pUsuario
                        .PNFCHCRT = HelpClass.CDate_a_Numero8Digitos(Now)
                        .PNHRACRT = HelpClass.NowNumeric
                        .PSCUSCRT = objSeguridadBN.pUsuario
                        .PSSESTRG = "A"
                        .PNNDCFCC = 0
                    End With
                End If
            Next
            If olbeItemsPedido.Count > 0 Then
                intResultado = obrPedidoPlanta.GuardarPedidoPlanta(olbeItemsPedido)
                If intResultado <> 0 Then
                    strPedidos += intResultado & ","
                    For Each obeItemPedido As bePedidoPorPlanta In olbeItemsPedido

                        Dim obePed As New ProxyRansa.WSABB.Integracion.bePedido
                        With obePed
                            .PSNRFRPD = obeItemPedido.PSNRFRPD
                            .PSNRFTPD = obeItemPedido.PSNRFTPD
                            .PSNLTECL = obeItemPedido.PSNLTECL
                            .Usuario = objSeguridadBN.pUsuario
                        End With
                        obelistPedido.Add(obePed)
                    Next
                Else
                    HelpClass.ErrorMsgBox()
                    Exit Sub
                End If
            End If
        Next
        If Not strPedidos.Trim.Equals("") Then
            Dim obrIntegracion As New brIntegracion

            Dim intRows As Integer = obelistPedido.Count

            Dim intenvios As Integer = Math.Ceiling(intRows / 1000)
            For intCant As Integer = 0 To intenvios - 1
                Dim obelistPedido_1 As New List(Of ProxyRansa.WSABB.Integracion.bePedido)
                If intCant <> (intenvios - 1) Then
                    For intY As Integer = 0 To 1000
                        obelistPedido_1.Add(obelistPedido.Item(intCant * 1000 + intY))
                    Next
                Else
                    For intY As Integer = 0 To (intRows - 1000 * (intenvios - 1)) - 1
                        obelistPedido_1.Add(obelistPedido.Item(1000 * (intenvios - 1) + intY))
                    Next
                End If

                intResultado = obrIntegracion.intIntegracion_Actualizar_Estado_Pedidos(_CodCliente, obelistPedido_1)
                If intResultado = 0 Then
                    HelpClass.MsgBox("Error de comunicación", MessageBoxIcon.Error)
                    Exit Sub
                End If
            Next


            HelpClass.MsgBox("Se han creado los Pedidos: " & strPedidos)

        Else

        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub frmImportarPedidoABB_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            ImportarPedido()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private SelChk As Boolean = True
    Private Sub btnchkall_Click(sender As Object, e As EventArgs) Handles btnchkall.Click
        'btnchkall
        Dim i As Integer = 0
        SelChk = Not SelChk
        For i = 0 To Me.dtgPedidos.Rows.Count - 1
            dtgPedidos.Rows(i).Cells("CHK").Value = SelChk
        Next
        dtgPedidos.EndEdit()
    End Sub
End Class
