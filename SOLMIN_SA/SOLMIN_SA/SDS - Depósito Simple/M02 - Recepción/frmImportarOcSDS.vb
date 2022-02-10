Imports Ransa.TypeDef.Cliente
Imports Ransa.TypeDef.OrdenCompra.OrdenCompra
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.OrdenCompra.ItemOC
Imports RANSA.NEGO.slnSOLMIN_SAT.Recepcion
Imports RANSA.NEGO.slnSOLMIN_SDS
Imports RANSA.NEGO
Imports Ransa.DAO.OrdenCompra
Imports Ransa.TypeDef
Imports RANSA.Utilitario
Imports Ransa.DAO.Unidad
Imports Ransa.Controls.Moneda


Public Class frmImportarOcSDS
    Dim Cadena As String = ""
    Dim _Cod_Cliente As String = ""
    Dim _Cod_Cliente_Tercero As String = ""
    Private objSqlManager As New SqlManager
    Private _strUsuario As String = ""
    Private strMensajeError As String = ""
    Private sDefault_Peso As String = ""

    Public Property strUsuario() As String
        Get
            Return _strUsuario
        End Get
        Set(ByVal value As String)
            _strUsuario = value
        End Set
    End Property

    Public Property Cod_Cliente_Tercero() As String
        Get
            Return _Cod_Cliente_Tercero
        End Get
        Set(ByVal value As String)
            _Cod_Cliente_Tercero = value
        End Set
    End Property

    Public Property Cod_Cliente() As String
        Get
            Return _Cod_Cliente
        End Get
        Set(ByVal value As String)
            _Cod_Cliente = value
        End Set
    End Property

    Private Sub frmImportarOcSDS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OC()
        'CargarOCtodos()
    End Sub

    'Private Sub CargarOCtodos()
    '    Try
    '        Dim obrIntegracion As New brIntegracion
    '        Me.dgOCtodo.AutoGenerateColumns = False
    '        Me.dgOCtodo.DataSource = obrIntegracion.Integracion_Lista_Orden_Compra_Cabecera_Todo().Tables(0)

    '    Catch ex As Exception
    '    End Try
    'End Sub
    Private Sub OC()
        Dim obrIntegracion As New brIntegracion
        Dim lstr_Cadena As String = ""
        Dim EsNumero As Boolean = True
        Dim i As Integer
        Me.dgOCtodo.AutoGenerateColumns = False
        Me.dgOCtodo.DataSource = obrIntegracion.Integracion_Lista_Orden_Compra_Cabecera_Todo()

        For i = 0 To Me.dgOCtodo.Rows.Count - 1
            If (dgOCtodo.Rows(i).Cells(0).Value.ToString().Trim = "0") Then
                dgOCtodo.Rows(i).Cells(1).Value = My.Resources.button_cancel
            Else
                dgOCtodo.Rows(i).Cells(1).Value = My.Resources.button_ok1
            End If
        Next
        CargarItemstodos(obrIntegracion._Cad)
    End Sub

    Private Sub CargarItemstodos(ByVal Cadena As String)
        Try
            Dim obrIntegracion As New brIntegracion
            Me.dgOCdetalle.AutoGenerateColumns = False
            Me.dgOCdetalle.DataSource = obrIntegracion.Integracion_Lista_Orden_Compra_Detalle_Todo(Cadena, strUsuario).Tables(0)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CambiarEstadoOC(ByVal Cadena As String)
        Try
            Dim obrIntegracion As New brIntegracion
            obrIntegracion.Integracion_Actualizar_Orden_Compra_Cabecera_Estado(Cadena, strUsuario)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CambiarEstadoOCdetalle(ByVal Cadena As String)
        Try
            Dim obrIntegracion As New brIntegracion
            obrIntegracion.Integracion_Actualizar_Orden_Compra_Detalle_Estado(Cadena, strUsuario)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub GrabarOC()
        Dim i As Integer
        Dim obj As New ucMoneda_CmbF01

        Dim olbeOrdenCompra As New List(Of beOrdenCompra)
        Dim obeOrdenCompra As New beOrdenCompra
        For i = 0 To Me.dgOCtodo.Rows.Count - 1
            If (dgOCtodo.Rows(i).Cells("Image").Value = "1") Then
                GrabarProveedor(i)
                obeOrdenCompra.PNCCLNT = Decimal.Parse(Cod_Cliente)
                'obeOrdenCompra.CodOC = dgOCtodo.Rows(i).Cells("in_PurchaseOrder").Value.ToString.Trim()
                obeOrdenCompra.PSNORCML = dgOCtodo.Rows(i).Cells("PSNORCML").Value.ToString.Trim()
                obeOrdenCompra.PNCPRVCL = Cod_Cliente_Tercero
                obeOrdenCompra.PNFORCML = HelpClass.CFecha_a_Numero8Digitos(dgOCtodo.Rows(i).Cells("FechaOCDte").Value) 'Fecha OC
                obeOrdenCompra.PNFSOLIC = HelpClass.CFecha_a_Numero8Digitos(dgOCtodo.Rows(i).Cells("FechaOCDte").Value)  'Fecha Solicitante
                obeOrdenCompra.PSTDSCML = dgOCtodo.Rows(i).Cells("pTDSCML_Descripcion").Value.ToString.Trim()
                obeOrdenCompra.PSTCMAEM = "" & dgOCtodo.Rows(i).Cells("pTCMAEM_DescAreaEmpresa").Value & ""
                obeOrdenCompra.PSTTINTC = "" & dgOCtodo.Rows(i).Cells("pTTINTC_TerminoIntern").Value & ""
                obeOrdenCompra.PSNREFCL = "" & dgOCtodo.Rows(i).Cells("pNREFCL_ReferenciaCliente").Value & ""
                obeOrdenCompra.PSTPAGME = "" & dgOCtodo.Rows(i).Cells("pTPAGME_TerminoPago").Value & ""
                obeOrdenCompra.PSREFDO1 = "" & dgOCtodo.Rows(i).Cells("pREFDO1_ReferenciaDocumento").Value & ""
                ' obeOrdenCompra.PNNTPDES = Decimal.Parse(dgOCtodo.Rows(i).Cells("pNTPDES_Prioridad").Value)
                Select Case dgOCtodo.Rows(i).Cells("pNTPDES_Prioridad").Value
                    Case 0
                        obeOrdenCompra.PNNTPDES = 1
                    Case 1
                        obeOrdenCompra.PNNTPDES = 3
                    Case 2
                        obeOrdenCompra.PNNTPDES = 4
                End Select

                obj.pCargarPorAbreviatura = dgOCtodo.Rows(i).Cells("pNMONOC_MonedaDeOC").Value
                obeOrdenCompra.PNCMNDA1 = obj.pInformacionSelec.pCMNDA1_Codigo

                obeOrdenCompra.PSTEMPFAC = "" & dgOCtodo.Rows(i).Cells("pTEMPFAC_EmpresaFacturar").Value & ""
                obeOrdenCompra.PSTNOMCOM = "" & dgOCtodo.Rows(i).Cells("pTNOMCOM_NombreComprador").Value & ""
                obeOrdenCompra.PSTCTCST = "" & dgOCtodo.Rows(i).Cells("pTCTCST_CentroCosto").Value & ""
                obeOrdenCompra.PSCREGEMB = "" & dgOCtodo.Rows(i).Cells("pCREGEMB_RegEmbarque").Value & ""
                obeOrdenCompra.PNCMEDTR = Decimal.Parse(dgOCtodo.Rows(i).Cells("pCMEDTR_MedioTransporte").Value.ToString.Trim())
                obeOrdenCompra.PNIVCOTO = Decimal.Parse(dgOCtodo.Rows(i).Cells("pIVCOTO_ImporteCostoTotal").Value.ToString.Trim())
                obeOrdenCompra.PNIVTOCO = Decimal.Parse(dgOCtodo.Rows(i).Cells("pIVTOCO_ImporteTotalCompra").Value.ToString.Trim())
                obeOrdenCompra.PNIVTOIM = Decimal.Parse(dgOCtodo.Rows(i).Cells("pIVTOIM_ImporteTotalImpuesto").Value.ToString.Trim())
                obeOrdenCompra.PSTDEFIN = "" & dgOCtodo.Rows(i).Cells("pTDEFIN_DestinoFinal").Value & ""
                obeOrdenCompra.PSTDAITM = ""
                If cOrdenCompra.GrabarABB(objSqlManager, obeOrdenCompra, strUsuario, strMensajeError) Then
                    CambiarEstadoOC(dgOCtodo.Rows(i).Cells("in_PurchaseOrder").Value)

                End If
            End If
        Next
        GrabarOCDetalle()
    End Sub

    Public Sub GrabarProveedor(ByVal i As Integer)
        Dim oblProveedor As New blProveedor()
        Dim obeProveedor As New beProveedor()

        obeProveedor.CPRVCL_CodClienteTercero = 0

        If IsNumeric(dgOCtodo.Rows(i).Cells("pNRUCPR_RucProveedor").Value) Then
            obeProveedor.NRUCPR_RucProveedor = "" & dgOCtodo.Rows(i).Cells("pNRUCPR_RucProveedor").Value & ""
        Else
            obeProveedor.NRUCPR_RucProveedor = 0
        End If

        If dgOCtodo.Rows(i).Cells("pTPDRPRC_DireccionProveedor").Value.ToString.Trim.Length > 35 Then
            Dim intDir As Integer = dgOCtodo.Rows(i).Cells("pTPDRPRC_DireccionProveedor").Value.ToString.Trim.Length
            obeProveedor.PSTDRPRC = dgOCtodo.Rows(i).Cells("pTPDRPRC_DireccionProveedor").Value.ToString.Trim.Substring(0, 35)
            obeProveedor.PSTPRSCN = dgOCtodo.Rows(i).Cells("pTPDRPRC_DireccionProveedor").Value.ToString.Trim.Substring(35, intDir - 35)
        Else
            obeProveedor.PSTDRPRC = dgOCtodo.Rows(i).Cells("pTPDRPRC_DireccionProveedor").Value.ToString.Trim
            obeProveedor.PSTPRSCN = ""
        End If

        If dgOCtodo.Rows(i).Cells("pTPRVCL_DescripcionProveedor").Value.ToString.Trim.Length > 30 Then
            Dim intDir As Integer = dgOCtodo.Rows(i).Cells("pTPRVCL_DescripcionProveedor").Value.ToString.Trim.Length
            obeProveedor.PSTPRVCL = dgOCtodo.Rows(i).Cells("pTPRVCL_DescripcionProveedor").Value.ToString.Trim.Substring(0, 30)
            obeProveedor.PSTPRCL1 = dgOCtodo.Rows(i).Cells("pTPRVCL_DescripcionProveedor").Value.ToString.Trim.Substring(30, intDir - 30)
        Else
            obeProveedor.PSTPRVCL = "" & dgOCtodo.Rows(i).Cells("pTPRVCL_DescripcionProveedor").Value.ToString.Trim & ""
            obeProveedor.PSTPRCL1 = ""
        End If


        Dim lon As Int32 = dgOCtodo.Rows(i).Cells("pTPRVCL_DescripcionProveedor").Value.ToString.Trim.Length
        obeProveedor.TNROFX_NroFax = "" & dgOCtodo.Rows(i).Cells("pTNROFX_FaxProveedor").Value & ""
        obeProveedor.TPRSCN_PersonaContacto = "" & dgOCtodo.Rows(i).Cells("pTPRSCN_ContactoProveedor").Value & ""
        obeProveedor.TLFN02_FonoContacto = "" & dgOCtodo.Rows(i).Cells("pTLFN02_TelefonoContacto").Value & ""
        obeProveedor.TMAI03_EmailContacto = "" & dgOCtodo.Rows(i).Cells("pTEAMI3_EmailContacto").Value & ""
        obeProveedor.CULUSA_UsuarioAct = strUsuario
        obeProveedor.CUSCRT_UsuarioCre = strUsuario
        obeProveedor.CCLNT_CodigoCliente = Decimal.Parse(Cod_Cliente)
        obeProveedor.CPRPCL_CodigoClienteProveedor = "" & dgOCtodo.Rows(i).Cells("PCPRPCL_CodigoClienteProveedor").Value & ""
        obeProveedor.CREAR_RELACION_CrearRelacionClientevsProveedor = "P"
        obeProveedor = oblProveedor.fblnRegistrar_Proveedor_de_ABB(obeProveedor)
        If (obeProveedor.CPRVCL_CodClienteTercero <> 0) Then
            Cod_Cliente_Tercero = obeProveedor.CPRVCL_CodClienteTercero
        End If


    End Sub

    Private Sub GrabarOCDetalle()
        Dim i As Integer
        Dim olbeOrdenCompra As New List(Of beOrdenCompra)
        Dim obeOrdenCompra As New beOrdenCompra
        For i = 0 To Me.dgOCdetalle.Rows.Count - 1

            obeOrdenCompra.PNCCLNT = Decimal.Parse(Cod_Cliente)
            obeOrdenCompra.PSNORCML = dgOCdetalle.Rows(i).Cells("vc_PurchaseOrder_1").Value.ToString.Trim()
            If IsNumeric(dgOCdetalle.Rows(i).Cells("vc_PurchaseOrderLine").Value.ToString.Trim()) Then
                obeOrdenCompra.PNNRITOC = IIf(dgOCdetalle.Rows(i).Cells("vc_PurchaseOrderLine").Value = "", 0, dgOCdetalle.Rows(i).Cells("vc_PurchaseOrderLine").Value)
            End If
            obeOrdenCompra.PSTDITES = ("" & dgOCdetalle.Rows(i).Cells("vc_LineDescriptionLine1").Value & dgOCdetalle.Rows(i).Cells("vc_LineDescriptionLine2").Value & "")

            If IsNumeric(dgOCdetalle.Rows(i).Cells("fl_QuantityOrdered").Value) Then
                obeOrdenCompra.PNQCNTIT = Decimal.Parse(dgOCdetalle.Rows(i).Cells("fl_QuantityOrdered").Value)
            End If
            obeOrdenCompra.PSTDITIN = dgOCdetalle.Rows(i).Cells("vc_LineDescriptionLine2").Value
            obeOrdenCompra.PSTCITCL = dgOCdetalle.Rows(i).Cells("vc_StockCode").Value
            If Not dgOCdetalle.Rows(i).Cells("dt_EstimatedDate").Value Is DBNull.Value Then
                obeOrdenCompra.PNFMPDME = HelpClass.CFecha_a_Numero8Digitos(dgOCdetalle.Rows(i).Cells("dt_EstimatedDate").Value) 'IIf(dgOCdetalle.Rows(i).Cells("dt_EstimatedDate").Value = "", 0, dgOCdetalle.Rows(i).Cells("dt_EstimatedDate").Value)
            End If

            obeOrdenCompra.PSTLUGEN = ("" & dgOCdetalle.Rows(i).Cells("vc_SupplierAddressLine1_1").Value & dgOCdetalle.Rows(i).Cells("vc_SupplierAddressLine2_1").Value & dgOCdetalle.Rows(i).Cells("vc_SupplierAddressLine3_1").Value)

            Dim oUnidad As cUnidad = New cUnidad
            Dim strResultado = oUnidad.fsBuscarAbreviatura(" " & dgOCdetalle.Rows(i).Cells("vc_unidad_medida").Value & "", sDefault_Peso)
            If Not strResultado.ToString.Trim.Equals("") Then
                obeOrdenCompra.PSTUNDIT = strResultado
            Else
                obeOrdenCompra.PSTUNDIT = ""
            End If

            obeOrdenCompra.PSTCTCST = "" & dgOCdetalle.Rows(i).Cells("vc_CentroCosto_1").Value & ""
            obeOrdenCompra.PNIVUNIT = Decimal.Parse(dgOCdetalle.Rows(i).Cells("fl_UnitPrice").Value) 'IIf(dgOCdetalle.Rows(i).Cells("fl_UnitPrice").Value = "", 0, dgOCdetalle.Rows(i).Cells("fl_UnitPrice").Value)
            obeOrdenCompra.PNIVTOIT = Decimal.Parse(dgOCdetalle.Rows(i).Cells("fl_TotalPrice").Value) 'IIf(dgOCdetalle.Rows(i).Cells("fl_TotalPrice").Value = "", 0, dgOCdetalle.Rows(i).Cells("fl_TotalPrice").Value)
            obeOrdenCompra.PSTCITPR = ""
            obeOrdenCompra.PSCPTDAR = ""
            obeOrdenCompra.PNFMPIME = 0
            obeOrdenCompra.PSTLUGOR = ""
            obeOrdenCompra.PNQTOLMIN = 0
            obeOrdenCompra.PNQTOLMAX = 0

            If cItemOrdenCompra.GrabarABB(objSqlManager, obeOrdenCompra, strUsuario, strMensajeError) Then
                CambiarEstadoOCdetalle(dgOCdetalle.Rows(i).Cells("in_PurchaseOrderLine").Value)
            End If
        Next
    End Sub

    Private Sub tsbGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGrabar.Click
        GrabarOC()
        MessageBox.Show("Registro Satisfactorio.")
        Me.Close()
    End Sub


    Private Sub CargarItemstodosxCodigo(ByVal Cadena As Integer)
        Try
            Dim obrIntegracion As New brIntegracion
            Me.dgOCD2.AutoGenerateColumns = False
            Me.dgOCD2.DataSource = obrIntegracion.Integracion_Lista_Orden_Compra_Detalle_x_Codigo(Cadena, strUsuario).Tables(0)
        Catch ex As Exception
        End Try
    End Sub


    Private Sub dgOCtodo_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgOCtodo.CellClick
        Try
            CargarItemstodosxCodigo(Integer.Parse(dgOCtodo.CurrentRow.Cells("in_PurchaseOrder").Value))
        Catch ex As Exception
        End Try

    End Sub

    Private Sub dgOCtodo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgOCtodo.KeyUp
        If Me.dgOCtodo.CurrentCellAddress.Y < 0 Then Exit Sub
        Select Case e.KeyCode
            Case Keys.Enter, Keys.Up, Keys.Down
                Me.dgOCtodo_CellClick(Nothing, Nothing)
        End Select
    End Sub

    Private Sub dgOCtodo_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgOCtodo.CellEnter
        Try
            CargarItemstodosxCodigo(Integer.Parse(dgOCtodo.CurrentRow.Cells("in_PurchaseOrder").Value))
        Catch ex As Exception
        End Try
    End Sub
End Class
