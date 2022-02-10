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
    Private listOCGuardar As New Hashtable

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

    Private _strTerminal As String = ""

    Public Property pTerminal() As String
        Get
            Return _strTerminal
        End Get
        Set(ByVal value As String)
            _strTerminal = value
        End Set
    End Property


    Private Sub frmImportarOcSDS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            OC()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'CargarOCtodos()
    End Sub

    Private oDs As New DataSet

    Private Sub OC()
        'Try
        'Dim oDs As New DataSet
        Dim obrIntegracion As New brIntegracion
        Dim lstr_Cadena As String = ""
        Dim EsNumero As Boolean = True
        Dim i As Integer
        Me.dgOCtodo.AutoGenerateColumns = False
        oDs = obrIntegracion.Integracion_Lista_Orden_Compra_Cabecera_Todo(Cod_Cliente)

        If oDs.Tables(0).TableName.Equals("Error_Table") Then
            Throw New Exception(oDs.Tables(0).Rows(0).Item("Error").ToString)
        End If

        CargarOrdenDeCompra(oDs.Tables(0))
        For i = 0 To Me.dgOCtodo.Rows.Count - 1
            If (dgOCtodo.Rows(i).Cells("Image").Value.ToString().Trim = "0") Then
                dgOCtodo.Rows(i).Cells("IMG").Value = My.Resources.button_cancel
            Else
                dgOCtodo.Rows(i).Cells("IMG").Value = My.Resources.button_ok1
            End If

            If (dgOCtodo.Rows(i).Cells("Image").Value = "1") Then
                dgOCtodo.Rows(i).Cells("CHK").Value = True
                dgOCtodo.Rows(i).Cells("CHK").ReadOnly = False
            Else
                dgOCtodo.Rows(i).Cells("CHK").ReadOnly = True
            End If
        Next
        dgOCtodo.EndEdit()
        'CargarItemstodos(obrIntegracion._Cad)
        Me.dgOCdetalle.DataSource = oDs.Tables(1)
        'Catch ex As Exception
        'End Try

    End Sub


    '=========================mODIFICADO POOR ABARHAM ZORRILLAP=========================
    Public Sub CargarOrdenDeCompra(ByVal oDt As DataTable)
        Dim olbeOrdenCompra As New List(Of beOrdenCompra)
        Dim Cont As Integer
        Dim Fecha As Date


        For i As Integer = 0 To oDt.Rows.Count - 1
            Dim obeOrdenCompra As New beOrdenCompra

            'If (oDt.Rows(i).Item(28).ToString() = "") Then 'Moneda
            '    Cont = 1
            'End If
            If (oDt.Rows(i).Item("vc_Currency").ToString() = "") Then 'Moneda
                Cont = 1
            End If
            'If (oDt.Rows(i).Item(26).ToString() = "") Then 'incoterm
            '    Cont = 1
            'End If
            If (oDt.Rows(i).Item("vc_Incoterm").ToString() = "") Then 'incoterm
                Cont = 1
            End If
            'If (oDt.Rows(i).Item(7).ToString() = "") Then ' codigo proveedor
            '    Cont = 1
            'End If
            If (oDt.Rows(i).Item("vc_SupplierCode").ToString() = "") Then ' codigo proveedor
                Cont = 1
            End If
            'If (oDt.Rows(i).Item(1).ToString() = "") Then ' Orden de Compra
            '    Cont = 1
            'End If
            If (oDt.Rows(i).Item("vc_PurchaseOrder").ToString() = "") Then ' Orden de Compra
                Cont = 1
            End If

            If (Cont = 1) Then
                Cont = 0
                obeOrdenCompra.Image = "0"
                obeOrdenCompra.CodOC = (oDt.Rows(i).Item("in_PurchaseOrder")).ToString.Trim
                obeOrdenCompra.PSNORCML = (oDt.Rows(i).Item("vc_PurchaseOrder")).ToString.Trim
                obeOrdenCompra.PSTDSCML = (oDt.Rows(i).Item("vc_OrderDescripcion")).ToString.Trim
                If (oDt.Rows(i).Item("vc_Currency")).ToString.Trim = "PEN" Then
                    obeOrdenCompra.PSNMONOC = "S/."
                Else
                    obeOrdenCompra.PSNMONOC = (oDt.Rows(i).Item("vc_Currency")).ToString.Trim
                End If
                If (oDt.Rows(i).Item("bi_Origen").ToString() <> "") Then

                    Select Case oDt.Rows(i).Item("bi_Origen")

                        Case True : obeOrdenCompra.PSTTINTC = (oDt.Rows(i).Item("vc_Incoterm")).ToString.Trim

                        Case False : obeOrdenCompra.PSTTINTC = "LOC"
                    End Select
                End If
                obeOrdenCompra.PSTNOMCOM = (oDt.Rows(i).Item("vc_Purchaser")).ToString.Trim

                If (oDt.Rows(i).Item("dt_OrderDate") IsNot DBNull.Value) Then
                    Fecha = Convert.ToDateTime(Convert.ToDateTime(oDt.Rows(i).Item("dt_OrderDate")).Day & "/" & Convert.ToDateTime(oDt.Rows(i).Item("dt_OrderDate")).Month & "/" & Convert.ToDateTime(oDt.Rows(i).Item("dt_OrderDate")).Year)
                    'obeOrdenCompra.FechaOCDte = True
                Else
                    Fecha = Convert.ToDateTime("01/01/01")
                    'obeOrdenCompra.FechaOCDte = False
                End If
                obeOrdenCompra.FechaOCDte = Fecha
                obeOrdenCompra.PSTCTCST = (oDt.Rows(i).Item("vc_CentroCosto")).ToString.Trim

                obeOrdenCompra.PSSFLGES = (oDt.Rows(i).Item("si_OperadorLogistico")).ToString.Trim()

                obeOrdenCompra.PNNTPDES = IIf(oDt.Rows(i).Item("vc_UrgencyLevel") Is DBNull.Value Or oDt.Rows(0).Item("vc_UrgencyLevel") = "", 0, oDt.Rows.Item(0).Item("vc_UrgencyLevel"))
                obeOrdenCompra.PSCPRPCL = ("" & oDt.Rows(i).Item("vc_SupplierCode")).ToString.Trim
                obeOrdenCompra.PSRUCPR = Val(oDt.Rows(i).Item("vc_SupplierFiscalCode"))
                obeOrdenCompra.PSTNROFX = ("" & oDt.Rows(i).Item("vc_SupplierFax")).ToString.Trim
                obeOrdenCompra.PSTLFN02 = ("" & oDt.Rows(i).Item("vc_SupplierReferenceTelephone")).ToString.Trim
                obeOrdenCompra.PSTPRSCN = ("" & oDt.Rows(i).Item("vc_SupplierReference")).ToString.Trim
                obeOrdenCompra.PSTPRVCL = ("" & oDt.Rows(i).Item("vc_SupplierFiscalName")).ToString.Trim
                obeOrdenCompra.PSTEAMI3 = ("" & oDt.Rows(i).Item("vc_SupplierReferenceEmail")).ToString.Trim
                obeOrdenCompra.PSTPRCL1 = ("" & oDt.Rows(i).Item("vc_SupplierAddressLine1")).ToString.Trim & ("" & oDt.Rows.Item(0).Item("vc_SupplierAddressLine2")).ToString.Trim & ("" & oDt.Rows.Item(0).Item("vc_SupplierAddressLine3")).ToString.Trim
                'obeOrdenCompra.pTDSCML_Descripcion = ("" & oDs.Tables(0).Rows.Item(0).Item("vc_SupplierFiscalName")).ToString.Trim
            Else
                Cont = 0
                obeOrdenCompra.Image = "1"
                obeOrdenCompra.CodOC = (oDt.Rows(i).Item("in_PurchaseOrder")).ToString.Trim
                obeOrdenCompra.PSNORCML = (oDt.Rows(i).Item("vc_PurchaseOrder")).ToString.Trim
                obeOrdenCompra.PSTDSCML = (oDt.Rows(i).Item("vc_OrderDescripcion")).ToString.Trim
                If (oDt.Rows(i).Item("vc_Currency")).ToString.Trim = "PEN" Then
                    obeOrdenCompra.PSNMONOC = "S/"
                Else
                    obeOrdenCompra.PSNMONOC = (oDt.Rows(i).Item("vc_Currency")).ToString.Trim
                End If
                Select Case oDt.Rows(i).Item("bi_Origen")

                    Case True : obeOrdenCompra.PSTTINTC = (oDt.Rows(i).Item("vc_Incoterm")).ToString.Trim

                    Case False : obeOrdenCompra.PSTTINTC = "LOC"
                End Select
                obeOrdenCompra.PSTNOMCOM = (oDt.Rows(i).Item("vc_Purchaser")).ToString.Trim

                If (oDt.Rows(i).Item("dt_OrderDate") IsNot DBNull.Value) Then
                    Fecha = Convert.ToDateTime(Convert.ToDateTime(oDt.Rows(i).Item("dt_OrderDate")).Day & "/" & Convert.ToDateTime(oDt.Rows(i).Item("dt_OrderDate")).Month & "/" & Convert.ToDateTime(oDt.Rows(i).Item("dt_OrderDate")).Year)
                    ' obeOrdenCompra.FechaOCDte = True
                Else
                    Fecha = Convert.ToDateTime("01/01/01")
                    ' obeOrdenCompra.FechaOCDte = False
                End If
                obeOrdenCompra.FechaOCDte = Fecha

                obeOrdenCompra.PSSFLGES = (oDt.Rows(i).Item("si_OperadorLogistico")).ToString.Trim()
             

                obeOrdenCompra.PSTCTCST = (oDt.Rows(i).Item("vc_CentroCosto")).ToString.Trim
                obeOrdenCompra.PNNTPDES = IIf(oDt.Rows(i).Item("vc_UrgencyLevel") Is DBNull.Value OrElse oDt.Rows(i).Item("vc_UrgencyLevel") = "", 0, oDt.Rows(0).Item("vc_UrgencyLevel"))
                obeOrdenCompra.PSCPRPCL = ("" & oDt.Rows(i).Item("vc_SupplierCode")).ToString.Trim
                obeOrdenCompra.PSRUCPR = Val(oDt.Rows(i).Item("vc_SupplierFiscalCode"))
                obeOrdenCompra.PSTNROFX = ("" & oDt.Rows(i).Item("vc_SupplierFax")).ToString.Trim
                obeOrdenCompra.PSTLFN02 = ("" & oDt.Rows(i).Item("vc_SupplierReferenceTelephone")).ToString.Trim
                obeOrdenCompra.PSTPRSCN = ("" & oDt.Rows(i).Item("vc_SupplierReference")).ToString.Trim
                obeOrdenCompra.PSTPRVCL = ("" & oDt.Rows(i).Item("vc_SupplierFiscalName")).ToString.Trim
                obeOrdenCompra.PSTEAMI3 = ("" & oDt.Rows(i).Item("vc_SupplierReferenceEmail")).ToString.Trim
                obeOrdenCompra.PSTPRCL1 = ("" & oDt.Rows(i).Item("vc_SupplierAddressLine1")).ToString.Trim & ("" & oDt.Rows.Item(0).Item("vc_SupplierAddressLine2")).ToString.Trim & ("" & oDt.Rows.Item(0).Item("vc_SupplierAddressLine3")).ToString.Trim
            End If
            olbeOrdenCompra.Add(obeOrdenCompra)
        Next

        Me.dgOCtodo.AutoGenerateColumns = False
        Me.dgOCtodo.DataSource = olbeOrdenCompra
       


    End Sub

    '==========================MODIFICADO POR ABRAHAM ZORRILLA =============================================
    'Private Sub CargarItemstodos(ByVal Cadena As String)
    '    Dim obrIntegracion As New brIntegracion
    '    Me.dgOCdetalle.AutoGenerateColumns = False
    '    Me.dgOCdetalle.DataSource = obrIntegracion.Integracion_Lista_Orden_Compra_Detalle_Todo(Cadena, strUsuario).Tables(0)
    'End Sub
    Private Sub CambiarEstadoOC(ByVal Cadena As String)
        Try
            Dim obrIntegracion As New brIntegracion
            obrIntegracion.Integracion_Actualizar_Orden_Compra_Cabecera_Estado(Cod_Cliente, Cadena, strUsuario)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub CambiarEstadoOCdetalle(ByVal Cadena As String)
        Try
            Dim obrIntegracion As New brIntegracion
            obrIntegracion.Integracion_Actualizar_Orden_Compra_Detalle_Estado(Cod_Cliente, Cadena, strUsuario)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    'Private Sub GrabarOC()

    'End Sub

    Public Sub GrabarProveedor(ByVal i As Integer)
        Dim oblProveedor As New blProveedor()
        Dim obeProveedor As New beProveedor()
        Dim PSERROR As String = ""

        Cod_Cliente_Tercero = "0"
        obeProveedor.CPRVCL_CodClienteTercero = 0

        If IsNumeric(dgOCtodo.Rows(i).Cells("pNRUCPR_RucProveedor").Value) Then
            obeProveedor.NRUCPR_RucProveedor = "" & dgOCtodo.Rows(i).Cells("pNRUCPR_RucProveedor").Value & ""
        Else
            obeProveedor.NRUCPR_RucProveedor = 0
        End If

        If dgOCtodo.Rows(i).Cells("pTPDRPRC_DireccionProveedor").Value.ToString.Trim.Length > 35 Then
            Dim intDir As Integer = dgOCtodo.Rows(i).Cells("pTPDRPRC_DireccionProveedor").Value.ToString.Trim.Length
            obeProveedor.PSTDRPRC = ValidarCaracter.validaCaracter(("" & dgOCtodo.Rows(i).Cells("pTPDRPRC_DireccionProveedor").Value).ToString.Trim.Substring(0, 35), PSERROR)
            obeProveedor.PSTPRSCN = ValidarCaracter.validaCaracter(("" & dgOCtodo.Rows(i).Cells("pTPDRPRC_DireccionProveedor").Value).ToString.Trim.Substring(35, intDir - 35), PSERROR)
        Else
            obeProveedor.PSTDRPRC = ValidarCaracter.validaCaracter(("" & dgOCtodo.Rows(i).Cells("pTPDRPRC_DireccionProveedor").Value).ToString.Trim, PSERROR)
            obeProveedor.PSTPRSCN = ""
        End If

        If dgOCtodo.Rows(i).Cells("pTPRVCL_DescripcionProveedor").Value.ToString.Trim.Length > 30 Then
            Dim intDir As Integer = dgOCtodo.Rows(i).Cells("pTPRVCL_DescripcionProveedor").Value.ToString.Trim.Length
            obeProveedor.PSTPRVCL = ValidarCaracter.validaCaracter(("" & dgOCtodo.Rows(i).Cells("pTPRVCL_DescripcionProveedor").Value).ToString.Trim.Substring(0, 30), PSERROR)
            obeProveedor.PSTPRCL1 = ValidarCaracter.validaCaracter(("" & dgOCtodo.Rows(i).Cells("pTPRVCL_DescripcionProveedor").Value).ToString.Trim.Substring(30, intDir - 30), PSERROR)
        Else
            obeProveedor.PSTPRVCL = ValidarCaracter.validaCaracter(("" & dgOCtodo.Rows(i).Cells("pTPRVCL_DescripcionProveedor").Value).ToString.Trim, PSERROR)
            obeProveedor.PSTPRCL1 = ""
        End If


        Dim lon As Int32 = dgOCtodo.Rows(i).Cells("pTPRVCL_DescripcionProveedor").Value.ToString.Trim.Length
        obeProveedor.TNROFX_NroFax = ValidarCaracter.validaCaracter(("" & dgOCtodo.Rows(i).Cells("pTNROFX_FaxProveedor").Value).ToString.Trim, PSERROR)
        obeProveedor.TPRSCN_PersonaContacto = ValidarCaracter.validaCaracter(("" & dgOCtodo.Rows(i).Cells("pTPRSCN_ContactoProveedor").Value).ToString.Trim, PSERROR)
        obeProveedor.TLFN02_FonoContacto = ValidarCaracter.validaCaracter(("" & dgOCtodo.Rows(i).Cells("pTLFN02_TelefonoContacto").Value).ToString.Trim, PSERROR)
        obeProveedor.TMAI03_EmailContacto = ValidarCaracter.validaCaracter(("" & dgOCtodo.Rows(i).Cells("pTEAMI3_EmailContacto").Value).ToString.Trim, PSERROR)
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

    Private Sub GrabarOCDetalle(ByRef OCDet As String, ByRef ItemDet As String)
        Dim i As Integer
        Dim olbeOrdenCompra As New List(Of beOrdenCompra)
        Dim obeOrdenCompra As New beOrdenCompra
        For i = 0 To Me.dgOCdetalle.Rows.Count - 1

            obeOrdenCompra.PNCCLNT = Decimal.Parse(Cod_Cliente)
            obeOrdenCompra.PSNORCML = dgOCdetalle.Rows(i).Cells("vc_PurchaseOrder_1").Value.ToString.Trim()

            OCDet = obeOrdenCompra.PSNORCML

            If listOCGuardar.Contains(obeOrdenCompra.PSNORCML) Then

                If IsNumeric(dgOCdetalle.Rows(i).Cells("vc_PurchaseOrderLine").Value.ToString.Trim()) Then
                    obeOrdenCompra.PNNRITOC = IIf(dgOCdetalle.Rows(i).Cells("vc_PurchaseOrderLine").Value = "", 0, dgOCdetalle.Rows(i).Cells("vc_PurchaseOrderLine").Value)
                End If
                ItemDet = obeOrdenCompra.PNNRITOC

                obeOrdenCompra.PSTDITES = ValidarCaracter.validaCaracter("" & dgOCdetalle.Rows(i).Cells("vc_LineDescriptionLine1").Value & dgOCdetalle.Rows(i).Cells("vc_LineDescriptionLine2").Value & "", obeOrdenCompra.PSERROR)

                If IsNumeric(dgOCdetalle.Rows(i).Cells("fl_QuantityOrdered").Value) Then
                    obeOrdenCompra.PNQCNTIT = Decimal.Parse(dgOCdetalle.Rows(i).Cells("fl_QuantityOrdered").Value)
                End If
                obeOrdenCompra.PSTDITIN = ValidarCaracter.validaCaracter("" & dgOCdetalle.Rows(i).Cells("vc_LineDescriptionLine1").Value & dgOCdetalle.Rows(i).Cells("vc_LineDescriptionLine2").Value & "", obeOrdenCompra.PSERROR)
                obeOrdenCompra.PSTCITCL = ValidarCaracter.validaCaracter(("" & dgOCdetalle.Rows(i).Cells("vc_StockCode").Value.ToString.Trim.Replace("-!", "-")).Trim, obeOrdenCompra.PSERROR)

                If Not dgOCdetalle.Rows(i).Cells("dt_EstimatedDate").Value Is DBNull.Value Then
                    obeOrdenCompra.PNFMPDME = HelpClass.CFecha_a_Numero8Digitos(dgOCdetalle.Rows(i).Cells("dt_EstimatedDate").Value) 'IIf(dgOCdetalle.Rows(i).Cells("dt_EstimatedDate").Value = "", 0, dgOCdetalle.Rows(i).Cells("dt_EstimatedDate").Value)
                End If

                obeOrdenCompra.PSTLUGEN = ValidarCaracter.validaCaracter(("" & dgOCdetalle.Rows(i).Cells("vc_SupplierAddressLine1_1").Value & dgOCdetalle.Rows(i).Cells("vc_SupplierAddressLine2_1").Value & dgOCdetalle.Rows(i).Cells("vc_SupplierAddressLine3_1").Value).ToString.Trim.Replace("ø", "Nr"), obeOrdenCompra.PSERROR)
                If obeOrdenCompra.PSTLUGEN.ToString().Trim().Length > 50 Then
                    obeOrdenCompra.PSTLUGEN = obeOrdenCompra.PSTLUGEN.Substring(0, 50)
                End If

                'Dim oUnidad As cUnidad = New cUnidad
                Dim oUnidad As Ransa.Controls.Unidad.cUnidad = New Ransa.Controls.Unidad.cUnidad
                Dim strResultado = oUnidad.fsBuscarAbreviatura(" " & dgOCdetalle.Rows(i).Cells("vc_unidad_medida").Value & "", sDefault_Peso)
                If Not strResultado.ToString.Trim.Equals("") Then
                    obeOrdenCompra.PSTUNDIT = strResultado
                Else
                    obeOrdenCompra.PSTUNDIT = ""
                End If

                obeOrdenCompra.PSTCTCST = ValidarCaracter.validaCaracter(("" & dgOCdetalle.Rows(i).Cells("vc_CentroCosto_1").Value).ToString.Trim, obeOrdenCompra.PSERROR)

                obeOrdenCompra.PSTRFRN1 = ValidarCaracter.validaCaracter(("" & dgOCdetalle.Rows(i).Cells("vc_BU").Value).ToString.Trim, obeOrdenCompra.PSERROR)
                'Try
                '    obeOrdenCompra.PSTRFRN2 = ValidarCaracter.validaCaracter(("" & dgOCdetalle.Rows(i).Cells("vc_almacen").Value).ToString.Trim, obeOrdenCompra.PSERROR)
                'Catch ex As Exception
                'End Try
                obeOrdenCompra.PSTRFRN2 = ValidarCaracter.validaCaracter(("" & dgOCdetalle.Rows(i).Cells("vc_almacen").Value).ToString.Trim, obeOrdenCompra.PSERROR)

                obeOrdenCompra.PNIVUNIT = Decimal.Parse(dgOCdetalle.Rows(i).Cells("fl_UnitPrice").Value) 'IIf(dgOCdetalle.Rows(i).Cells("fl_UnitPrice").Value = "", 0, dgOCdetalle.Rows(i).Cells("fl_UnitPrice").Value)
                obeOrdenCompra.PNIVTOIT = Decimal.Parse(dgOCdetalle.Rows(i).Cells("fl_TotalPrice").Value) 'IIf(dgOCdetalle.Rows(i).Cells("fl_TotalPrice").Value = "", 0, dgOCdetalle.Rows(i).Cells("fl_TotalPrice").Value)
                obeOrdenCompra.PSTCITPR = ""
                obeOrdenCompra.PSCPTDAR = ""
                obeOrdenCompra.PNFMPIME = 0
                obeOrdenCompra.PSTLUGOR = ""
                obeOrdenCompra.PNQTOLMIN = 0
                obeOrdenCompra.PNQTOLMAX = 0
                obeOrdenCompra.PSCUSCRT = strUsuario
                obeOrdenCompra.PSCULUSA = strUsuario

                Dim obrOrdenDeCompra As New brOrdenDeCompra
                If obrOrdenDeCompra.InsertarDetalleOrdenDeCompra(obeOrdenCompra) Then
                    CambiarEstadoOCdetalle(dgOCdetalle.Rows(i).Cells("in_PurchaseOrderLine").Value)
                End If
                'If cItemOrdenCompra.GrabarABB(objSqlManager, obeOrdenCompra, strUsuario, strMensajeError) Then
                '    CambiarEstadoOCdetalle(dgOCdetalle.Rows(i).Cells("in_PurchaseOrderLine").Value)
                'End If

            End If
        Next
    End Sub

    'Private Function FiltrarCaracteresEspeciales(ByVal strCaracteres As String) As String

    '    For Each Item As chr In strCaracteres

    '    Next

    'End Function

    Private Sub tsbGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGrabar.Click
        Dim strOC As String = ""
        Dim strItemOC As String = ""
        Try
            'GrabarOC()
            dgOCtodo.EndEdit()
            Dim i As Integer
            Dim obj As New ucMoneda_CmbF01
            Dim CantOC As Integer = 0
            Dim olbeOrdenCompra As New List(Of beOrdenCompra)
            Dim obeOrdenCompra As New beOrdenCompra
            For i = 0 To Me.dgOCtodo.Rows.Count - 1
                'If (dgOCtodo.Rows(i).Cells("Image").Value = "1") Then
                If (dgOCtodo.Rows(i).Cells("Image").Value = "1" And dgOCtodo.Rows(i).Cells("CHK").Value = True) Then
                    ' dgOCtodo.Rows(i).Cells("CHK").Value
                    strOC = dgOCtodo.Rows(i).Cells("PSNORCML").Value.ToString.Trim()
                    CantOC = CantOC + 1
                    GrabarProveedor(i)
                    obeOrdenCompra.PNCCLNT = Decimal.Parse(Cod_Cliente)
                    'obeOrdenCompra.CodOC = dgOCtodo.Rows(i).Cells("in_PurchaseOrder").Value.ToString.Trim()
                    obeOrdenCompra.PSNORCML = dgOCtodo.Rows(i).Cells("PSNORCML").Value.ToString.Trim()
                    listOCGuardar(obeOrdenCompra.PSNORCML) = obeOrdenCompra.PSNORCML
                    obeOrdenCompra.PNCPRVCL = Cod_Cliente_Tercero
                    obeOrdenCompra.PNFORCML = HelpClass.CFecha_a_Numero8Digitos(dgOCtodo.Rows(i).Cells("FechaOCDte").Value.ToString.Trim) 'Fecha OC
                    obeOrdenCompra.PNFSOLIC = HelpClass.CFecha_a_Numero8Digitos(dgOCtodo.Rows(i).Cells("FechaOCDte").Value.ToString.Trim)  'Fecha Solicitante

                    obeOrdenCompra.PSTDSCML = ValidarCaracter.validaCaracter(("" & dgOCtodo.Rows(i).Cells("pTDSCML_Descripcion").Value).ToString.Trim, obeOrdenCompra.PSERROR)
                    ' obeOrdenCompra.PSTDSCML = dgOCtodo.Rows(i).Cells("pTDSCML_Descripcion").Value.ToString.Trim()

                    obeOrdenCompra.PSTCMAEM = ValidarCaracter.validaCaracter(("" & dgOCtodo.Rows(i).Cells("pTCMAEM_DescAreaEmpresa").Value).ToString.Trim, obeOrdenCompra.PSERROR)

                    ' obeOrdenCompra.PSTCMAEM = "" & dgOCtodo.Rows(i).Cells("pTCMAEM_DescAreaEmpresa").Value & ""

                    obeOrdenCompra.PSTTINTC = ValidarCaracter.validaCaracter(("" & dgOCtodo.Rows(i).Cells("pTTINTC_TerminoIntern").Value).ToString.Trim, obeOrdenCompra.PSERROR)

                    'obeOrdenCompra.PSTTINTC = "" & dgOCtodo.Rows(i).Cells("pTTINTC_TerminoIntern").Value & ""

                    obeOrdenCompra.PSNREFCL = ValidarCaracter.validaCaracter(("" & dgOCtodo.Rows(i).Cells("pNREFCL_ReferenciaCliente").Value).ToString.Trim, obeOrdenCompra.PSERROR)

                    ' obeOrdenCompra.PSNREFCL = "" & dgOCtodo.Rows(i).Cells("pNREFCL_ReferenciaCliente").Value & ""

                    obeOrdenCompra.PSTPAGME = ValidarCaracter.validaCaracter(("" & dgOCtodo.Rows(i).Cells("pTPAGME_TerminoPago").Value).ToString.Trim, obeOrdenCompra.PSERROR)

                    ' obeOrdenCompra.PSTPAGME = "" & dgOCtodo.Rows(i).Cells("pTPAGME_TerminoPago").Value & ""
                    obeOrdenCompra.PSREFDO1 = ValidarCaracter.validaCaracter(("" & dgOCtodo.Rows(i).Cells("pREFDO1_ReferenciaDocumento").Value).ToString.Trim, obeOrdenCompra.PSERROR)
                    'obeOrdenCompra.PSREFDO1 = "" & dgOCtodo.Rows(i).Cells("pREFDO1_ReferenciaDocumento").Value & ""
                    ' obeOrdenCompra.PNNTPDES = Decimal.Parse(dgOCtodo.Rows(i).Cells("pNTPDES_Prioridad").Value)
                    Select Case dgOCtodo.Rows(i).Cells("pNTPDES_Prioridad").Value
                        Case 0
                            obeOrdenCompra.PNNTPDES = 1
                        Case 1
                            obeOrdenCompra.PNNTPDES = 3
                        Case 2
                            obeOrdenCompra.PNNTPDES = 4
                    End Select

                    obj.pCargarPorAbreviatura = ValidarCaracter.validaCaracter(dgOCtodo.Rows(i).Cells("pNMONOC_MonedaDeOC").Value, obeOrdenCompra.PSERROR)
                    obeOrdenCompra.PNCMNDA1 = Val("" & obj.pInformacionSelec.pCMNDA1_Codigo)

                    obeOrdenCompra.PSTEMPFAC = ValidarCaracter.validaCaracter(("" & dgOCtodo.Rows(i).Cells("pTEMPFAC_EmpresaFacturar").Value).ToString.Trim, obeOrdenCompra.PSERROR)
                    obeOrdenCompra.PSTNOMCOM = ValidarCaracter.validaCaracter(("" & dgOCtodo.Rows(i).Cells("pTNOMCOM_NombreComprador").Value).ToString.Trim, obeOrdenCompra.PSERROR)
                    obeOrdenCompra.PSTCTCST = ValidarCaracter.validaCaracter(("" & dgOCtodo.Rows(i).Cells("pTCTCST_CentroCosto").Value).ToString.Trim, obeOrdenCompra.PSERROR)
                    obeOrdenCompra.PSCREGEMB = ValidarCaracter.validaCaracter(("" & dgOCtodo.Rows(i).Cells("pCREGEMB_RegEmbarque").Value).ToString.Trim, obeOrdenCompra.PSERROR)
                    obeOrdenCompra.PNCMEDTR = Decimal.Parse(dgOCtodo.Rows(i).Cells("pCMEDTR_MedioTransporte").Value.ToString.Trim())
                    obeOrdenCompra.PNIVCOTO = Decimal.Parse(dgOCtodo.Rows(i).Cells("pIVCOTO_ImporteCostoTotal").Value.ToString.Trim())
                    obeOrdenCompra.PNIVTOCO = Decimal.Parse(dgOCtodo.Rows(i).Cells("pIVTOCO_ImporteTotalCompra").Value.ToString.Trim())
                    obeOrdenCompra.PNIVTOIM = Decimal.Parse(dgOCtodo.Rows(i).Cells("pIVTOIM_ImporteTotalImpuesto").Value.ToString.Trim())
                    obeOrdenCompra.PSTDEFIN = ValidarCaracter.validaCaracter("" & dgOCtodo.Rows(i).Cells("pTDEFIN_DestinoFinal").Value & "", obeOrdenCompra.PSERROR)
                    obeOrdenCompra.PSTDAITM = ""
                    obeOrdenCompra.PSNTRMNL = "WS"
                    obeOrdenCompra.PSSFLGES = ValidarCaracter.validaCaracter(dgOCtodo.Rows(i).Cells("PSSFLGES").Value.ToString.Trim, obeOrdenCompra.PSERROR)
                    Dim obrOrdenDeCompra As New brOrdenDeCompra
                    If obrOrdenDeCompra.InsertarOrdenDeCompra(obeOrdenCompra) Then
                        CambiarEstadoOC(dgOCtodo.Rows(i).Cells("in_PurchaseOrder").Value)
                    End If
                End If
            Next

            strOC = ""
            If CantOC > 0 Then
                GrabarOCDetalle(strOC, strItemOC)
            Else
                MessageBox.Show("No ha seleccionado ninguna orden de compra", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            MessageBox.Show("Registro Satisfactorio.")
            Me.Close()

        Catch ex As Exception
            Dim strError As String = ""
            If strOC <> "" Then
                strError = "Error en OC : " & strOC
            End If
            If strItemOC <> "" Then
                strError = strError & " Item :" & strItemOC
            End If
            MessageBox.Show(strError & Chr(13) & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub


    Private Sub CargarItemstodosxCodigo(ByVal Cadena As Integer)
        Dim obrIntegracion As New brIntegracion
        Me.dgOCD2.AutoGenerateColumns = False
        Dim dr() As DataRow
        Dim dtdetalle As DataTable
        If dgOCtodo.CurrentRow IsNot Nothing Then
            Dim in_PurchaseOrderVal As String = dgOCtodo.CurrentRow.Cells("in_PurchaseOrder").Value
            dtdetalle = oDs.Tables(1).Copy
            dtdetalle.Clear()
            dr = oDs.Tables(1).Select("in_PurchaseOrder='" & in_PurchaseOrderVal & "'")
            For Each Item As DataRow In dr
                dtdetalle.ImportRow(Item)
            Next
            Me.dgOCD2.DataSource = dtdetalle
        End If
        'Me.dgOCD2.DataSource = obrIntegracion.Integracion_Lista_Orden_Compra_Detalle_x_Codigo(Cadena, strUsuario).Tables(0)
    End Sub


    Private Sub dgOCtodo_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgOCtodo.CellClick
        Try
            CargarItemstodosxCodigo(Integer.Parse(dgOCtodo.CurrentRow.Cells("in_PurchaseOrder").Value))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private SelChk As Boolean = True
    Private Sub btnsell_Click(sender As Object, e As EventArgs) Handles btnsell.Click
        Dim i As Integer = 0
        SelChk = Not SelChk
        For i = 0 To Me.dgOCtodo.Rows.Count - 1
            If (dgOCtodo.Rows(i).Cells("Image").Value = "1") Then
                dgOCtodo.Rows(i).Cells("CHK").Value = SelChk
            End If
        Next
        dgOCtodo.EndEdit()

    End Sub
End Class
