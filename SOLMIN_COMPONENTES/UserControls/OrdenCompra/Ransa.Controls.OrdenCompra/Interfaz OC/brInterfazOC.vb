Imports Ransa.DAO.OrdenCompra
Imports RANSA.NEGO
Imports RANSA.Utilitario
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.OrdenCompra.OrdenCompra
Imports Ransa.TypeDef.OrdenCompra.ItemOC
Imports Ransa.TypeDef
Imports System.IO
Imports Ransa.DATA

Public Class brInterfazOC


    Private _olbeOc As List(Of beOrdenCompra)
    Public ReadOnly Property ListaOC() As List(Of beOrdenCompra)
        Get
            Return _olbeOc
        End Get
    End Property

    Private _olbeDetOc As List(Of beOrdenCompra)
    Private _olbeDetOcPed As List(Of beOrdenCompra)
    Public ReadOnly Property DetalleOC() As List(Of beOrdenCompra)
        Get
            Return _olbeDetOc
        End Get
    End Property
    Public ReadOnly Property DetalleOCPed() As List(Of beOrdenCompra)
        Get
            Return _olbeDetOcPed
        End Get
    End Property

    Private _olbeOrdenDeCompraNotas As List(Of beOrdenCompra)

    Public ReadOnly Property NotasOC() As List(Of beOrdenCompra)
        Get
            Return _olbeOrdenDeCompraNotas
        End Get
    End Property

    Public Function CargaArchivo(ByVal dblCodCliente As Double) As Boolean
        Dim obeOrdenDeCompra As New beOrdenCompra
        Dim obeOrdenDeCompraDet As New beOrdenCompra
        Dim obeOrdenDeCompraDetPed As New beOrdenCompra
        Dim obeOrdenDeCompraNotas As New beOrdenCompra
        Dim olbeProveedor As New List(Of beProveedor)

        _olbeOc = New List(Of beOrdenCompra)
        _olbeDetOc = New List(Of beOrdenCompra)
        _olbeDetOcPed = New List(Of beOrdenCompra)
        _olbeOrdenDeCompraNotas = New List(Of beOrdenCompra)

        Dim obeProveedor As New beProveedor
        Dim sDato As String = String.Empty
        Dim PSNORCML As String = String.Empty
        Dim PSTCITPR As String = String.Empty
        Dim psPrecio As String = ""
        Dim psCantidad As String = ""
        Dim psToleranciaMinina As String = ""
        Dim psToleranciamaxima As String = ""
        Dim oDtsOc As New DataSet

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Try
            Dim objImportarOC As New OrdenCompra_DAL
            oDtsOc = objImportarOC.fdtsListarOcPendientes(dblCodCliente)
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
            Exit Function
        End Try

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Llenamos las OC 
        Try
            For Each odr As DataRow In oDtsOc.Tables(0).Rows
                obeOrdenDeCompra = New beOrdenCompra
                obeProveedor = New beProveedor
                With obeOrdenDeCompra
                    .PNCCLNT = dblCodCliente
                    .PSNORCML = odr.Item("vc_PurchaseOrder") '  Numero de Orden de Compra
                    .PSTPOOCM = odr.Item("vc_PurchaseOrder") 'Typo de orden de compra
                    .PSTPAISEM = "" 'NPAEMB = pais de embarque    
                    .PNFORCML = HelpClass.CDate_a_Numero8Digitos(odr.Item("dt_OrderDate")) 'DCREPO = Fecha Creación Orden de Compra
                    .PSFORCML_INI = odr.Item("dt_OrderDate")
                    .PSNMONOC = "" & odr.Item("vc_Currency") & "" 'NMONEDA = Moneda
                    .PSTPOOCM = "" & odr.Item("vc_TipoDoc") & "" 'Tipo de Orden de Compra/Tipo de Documento
                    .PSTPAGME = "" ' Termino de Pago
                    .PSTNOMCOM = "" & odr.Item("vc_Purchaser") & ""  '  Nombre de Comprador
                    .PSTCITPR = odr.Item("vc_SupplierCode") 'CCODPRO = Código de Proveedor
                    .PNCPRVCL = 0 ' CODIGO DE CLIENTE TERCERO   - generado
                    .PSCPRPCL = .PSTCITPR ' Codigo del proveedor - Cliente
                    .PSTDSCML = ValidarCaracter.validaCaracter("" & odr.Item("vc_OrderDescripcion") & "", .PSERROR)  'TDESPO = Desc. General Orden de Compra


                    .PSTEMPFAC = "" 'NEMPFAC = Empresa a facturar
                    .PSTCTCST = "" 'CCENCOS = Centro de Costo
                    .PSTTINTC = "" & odr.Item("vc_Incoterm") & ""  'NTERCOM = Termino de la Compra
                    .PNCMEDTR = 0 'FMEDEM = Medio de Embarque  
                    .PSCREGEMB = "" 'CREGEMB = Región de Embarque
                    .PSTLUGEM = "" 'NPTOEMB = Puerto de Embarque
                    .PSTDEFIN = "" 'NPTODES = Puerto de Desembarque Cliente
                    .PNNTPDES = 0 'FURG = Nivel de Urgencia     
                    .PSSESTRG = "A"
                    .PSNSVP = "A"
                    .PSSTRANS = ""
                    .PSSFLGES = "A"

                    'datos del proveedor
                    obeProveedor.PSCPRPCL = .PSTCITPR  ' Codigo de proveedor
                    'obeProveedor.PNCPRVCL = 0     ' Codigo Generado
                    obeProveedor.PNCCLNT = dblCodCliente      ' CLIENTE       PSTPRCL1
                    obeProveedor.PSTPRVCL = "" & odr.Item("vc_SupplierFiscalName") & "" 'NNOMPRO= Nombre Proveedor
                    obeProveedor.PNNRUCPR = Val("" & odr.Item("vc_SupplierFiscalCode") & "") 'Ruc proveedor
                    obeProveedor.PSTNACPR = PSTCITPR
                    If odr.Item("direccionProveedor").ToString.Trim.Length > 80 Then
                        obeProveedor.PSTDRPRC = odr.Item("direccionProveedor").ToString.Substring(0, 80) ' TDRPRC = Direccion        -tamaño 80 segun archivo
                        obeProveedor.PSTDRDST = odr.Item("direccionProveedor").ToString.Substring(80, odr.Item("direccionProveedor").ToString.Length - 80) ' TDRPRC = Direccion        -tamaño 80 segun archivo
                    Else
                        obeProveedor.PSTDRPRC = ("" & odr.Item("direccionProveedor") & "").ToString.Trim  ' TDRPRC = Direccion        -tamaño 80 segun archivo
                    End If
                    obeProveedor.PNCPAIS = 0
                    obeProveedor.PSTNROFX = ""
                    obeProveedor.PSTLFNO1 = "" & odr.Item("vc_SupplierFax") & ""    'NFAXPRO = Fax Proveedor
                    obeProveedor.PSTEMAI2 = "" & odr.Item("vc_SupplierTelephone") & ""  'NTELPRO = Teléfono Proveedor
                    obeProveedor.PSTPRSCN = "" & odr.Item("vc_SupplierReference") & ""   'NCTOPRO = Contacto Proveedor
                    obeProveedor.PSTLFNO2 = ""  'NTCTOPR = Teléfono contacto Proveedor
                    obeProveedor.PSTEMAI3 = "" & odr.Item("vc_SupplierReferenceEmail") & "" 'TMCTOPR = Mail contacto Proveedor
                    obeProveedor.PNNDSDMP = 0
                    .PNCPRVCL = ObtenerCodigoProveedor(obeProveedor)
                End With
                _olbeOc.Add(obeOrdenDeCompra)
            Next

            'LLenamos el detalle OC
            For Each odr As DataRow In oDtsOc.Tables(1).Rows
                obeOrdenDeCompraDet = New beOrdenCompra
                With obeOrdenDeCompraDet
                    .PNCCLNT = dblCodCliente
                    .NrOCCliente = odr.Item("in_PurchaseOrder")
                    .NrItemCliente = odr.Item("in_PurchaseOrderLine")
                    .PSNORCML = odr.Item("vc_PurchaseOrder")     'NNROPO = Numero de Orden de Compra
                    .PSTDITIN = "" ' TDECOIN = Descripción corta en Ingles
                    .PSCPTDAR = "" ' MPDAARA = Numero de Partida Arancelaria

                    .PNQCNTIT = Val(odr.Item("fl_QuantityOrdered")) ' QCANORD= Cantidad Ordenada
                    .PNQSDOIT = 0
                    .PNQINEMP = 0
                    .PSTUNDIT = odr.Item("vc_UnitMeasureCode")   'CUNDMED= Unidad de Medida
                    psPrecio = Val(odr.Item("fl_UnitPrice"))  'SPREUND = Precio Unitario
                    If psPrecio.Length > 1 Then
                        .PNIVTOIT = .PNQCNTIT * Convert.ToDecimal(psPrecio)
                        .PNIVTOIT = Format(.PNIVTOIT, "0000000000.00000")
                        .PNIVUNIT = Val(psPrecio)
                    End If
                    If Not odr.Item("dt_EstimatedDate").ToString.Equals("") Then
                        .PNFMPDME = HelpClass.CFecha_a_Numero8Digitos(odr.Item("dt_EstimatedDate")) ' Fec Máx. Prov. despachará merc.
                    End If
                    .PNFMPIME = 0  'DMATCLI = Fec. Máx. material Req. en Cliente
                    .PSTLUGEN = "" 'TLUGEN = Lugar entrega al cliente
                    .PSTLUGOR = "" 'TLUREC = Lugar recepción (alm. origen) - CONFIRMAR
                    .PSSFLGES = "A"
                    .PSSESTRG = "A"
                    .PNQSTKIT = 0
                    psToleranciaMinina = 0   'QTOLMIN = Cantidad tolerancia mínima
                    .PNQTOLMIN = Val(IIf(psToleranciaMinina.Length > 1, psToleranciaMinina, 0)) 'QTOLMIN = Cantidad tolerancia mínima
                    psToleranciamaxima = 0
                    .PNQTOLMAX = Val(IIf(psToleranciamaxima.Length > 1, psToleranciamaxima, 0))
                    .PSTRFRN = "" 'TREFRN1 = Referencia 1 Cliente (Solicitante)
                    .PSTRFRNA = "" 'TREFRN2 = Referencia 2 Cliente (Lote)
                    .PSTRFRNB = "" 'TREFRN3 = Referencia 3 Cliente (otro.)
                    .PSTRFRN1 = odr.Item("vc_CentroCosto")   'TREFRN4 = Referencia 4 Cliente (Centro Dest.)
                    .PSTRFRN2 = "" 'TREFRN5 = Referencia 5 Cliente (Almacen Dest)
                    .PNNRITOC = odr.Item("vc_PurchaseOrderLine")  ' Nro de Item  MNROITE
                    .PSTCITCL = odr.Item("vc_StockCode") ' CMERCLI = Código de Mercadería (Cliente)
                    .PSTCITPR = ""   'codigo de proveedor    CCODPRO
                    .PSTDITES = ValidarCaracter.validaCaracter("" & odr.Item("DescripcionItem") & "", .PSERROR) ' TDECOCA = Descripción corta en castellano
                    .PNFMPDME = HelpClass.CDate_a_Numero8Digitos(odr.Item("dt_EstimatedDate"))     'DPRODES = Fec Máx. Prov. despachará merc.
                    If .PSERROR.Trim.Length > 0 Then
                        MessageBox.Show(.PSERROR, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Function
                    End If
                    _olbeDetOc.Add(obeOrdenDeCompraDet)
                End With

            Next

            'LLenamos el detalle OC Pedido
            For Each odr As DataRow In oDtsOc.Tables(2).Rows
                obeOrdenDeCompraDetPed = New beOrdenCompra
                With obeOrdenDeCompraDetPed
                    .PNCCLNT = dblCodCliente
                    .PSTPOOCM = "" & odr.Item("vc_TipoDoc") & ""
                    .PSNORCML = "" & odr.Item("vc_PurchaseOrder")     'NNROPO = Numero de Orden de Compra
                    .PNNRITOC = odr.Item("vc_PurchaseOrderLine")
                    .PSNRFRPD = odr.Item("vc_nordpr")
                    .PNQCNTIT = odr.Item("vc_qitems")

                    If .PSERROR.Trim.Length > 0 Then
                        MessageBox.Show(.PSERROR, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Function
                    End If
                    _olbeDetOcPed.Add(obeOrdenDeCompraDetPed)
                End With

            Next

        Catch ex As Exception
            HelpClass.ErrorMsgBox()
        End Try
    End Function


    Public Function CargaArchivoPorOC(ByVal dblCodCliente As Double, ByVal strOc As String) As Boolean
        Dim obeOrdenDeCompra As New beOrdenCompra
        Dim obeOrdenDeCompraDet As New beOrdenCompra
        Dim obeOrdenDeCompraDetPed As New beOrdenCompra
        Dim obeOrdenDeCompraNotas As New beOrdenCompra
        Dim olbeProveedor As New List(Of beProveedor)

        _olbeOc = New List(Of beOrdenCompra)
        _olbeDetOc = New List(Of beOrdenCompra)
        _olbeDetOcPed = New List(Of beOrdenCompra)
        _olbeOrdenDeCompraNotas = New List(Of beOrdenCompra)

        Dim obeProveedor As New beProveedor
        Dim sDato As String = String.Empty
        Dim PSNORCML As String = String.Empty
        Dim PSTCITPR As String = String.Empty
        Dim psPrecio As String = ""
        Dim psCantidad As String = ""
        Dim psToleranciaMinina As String = ""
        Dim psToleranciamaxima As String = ""
        Dim oDtsOc As New DataSet

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Try
            Dim objImportarOC As New OrdenCompra_DAL
            oDtsOc = objImportarOC.fdtsObtenerOc(dblCodCliente, strOc)
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
            Exit Function
        End Try

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Llenamos las OC 
        Try
            For Each odr As DataRow In oDtsOc.Tables(0).Rows
                obeOrdenDeCompra = New beOrdenCompra
                obeProveedor = New beProveedor
                With obeOrdenDeCompra
                    .PNCCLNT = dblCodCliente
                    .PSNORCML = odr.Item("vc_PurchaseOrder") '  Numero de Orden de Compra
                    .PSTPOOCM = odr.Item("vc_PurchaseOrder") 'Typo de orden de compra
                    .PSTPAISEM = "" 'NPAEMB = pais de embarque    
                    .PNFORCML = HelpClass.CDate_a_Numero8Digitos(odr.Item("dt_OrderDate")) 'DCREPO = Fecha Creación Orden de Compra
                    .PSFORCML_INI = odr.Item("dt_OrderDate")
                    .PSNMONOC = "" & odr.Item("vc_Currency") & "" 'NMONEDA = Moneda
                    .PSTPOOCM = "" & odr.Item("vc_TipoDoc") & "" 'Tipo de Orden de Compra/Tipo de Documento
                    .PSTPAGME = "" ' Termino de Pago
                    .PSTNOMCOM = "" & odr.Item("vc_Purchaser") & ""  '  Nombre de Comprador
                    .PSTCITPR = odr.Item("vc_SupplierCode") 'CCODPRO = Código de Proveedor
                    .PNCPRVCL = 0 ' CODIGO DE CLIENTE TERCERO   - generado
                    .PSCPRPCL = .PSTCITPR ' Codigo del proveedor - Cliente
                    .PSTDSCML = ValidarCaracter.validaCaracter("" & odr.Item("vc_OrderDescripcion") & "", .PSERROR)  'TDESPO = Desc. General Orden de Compra


                    .PSTEMPFAC = "" 'NEMPFAC = Empresa a facturar
                    .PSTCTCST = "" 'CCENCOS = Centro de Costo
                    .PSTTINTC = "" & odr.Item("vc_Incoterm") & ""  'NTERCOM = Termino de la Compra
                    .PNCMEDTR = 0 'FMEDEM = Medio de Embarque  
                    .PSCREGEMB = "" 'CREGEMB = Región de Embarque
                    .PSTLUGEM = "" 'NPTOEMB = Puerto de Embarque
                    .PSTDEFIN = "" 'NPTODES = Puerto de Desembarque Cliente
                    .PNNTPDES = 0 'FURG = Nivel de Urgencia     
                    .PSSESTRG = "A"
                    .PSNSVP = "A"
                    .PSSTRANS = ""
                    .PSSFLGES = "A"

                    'datos del proveedor
                    obeProveedor.PSCPRPCL = .PSTCITPR  ' Codigo de proveedor
                    'obeProveedor.PNCPRVCL = 0     ' Codigo Generado
                    obeProveedor.PNCCLNT = dblCodCliente      ' CLIENTE       PSTPRCL1
                    obeProveedor.PSTPRVCL = "" & odr.Item("vc_SupplierFiscalName") & "" 'NNOMPRO= Nombre Proveedor
                    obeProveedor.PNNRUCPR = Val("" & odr.Item("vc_SupplierFiscalCode") & "") 'Ruc proveedor
                    obeProveedor.PSTNACPR = PSTCITPR
                    If odr.Item("direccionProveedor").ToString.Trim.Length > 80 Then
                        obeProveedor.PSTDRPRC = odr.Item("direccionProveedor").ToString.Substring(0, 80) ' TDRPRC = Direccion        -tamaño 80 segun archivo
                        obeProveedor.PSTDRDST = odr.Item("direccionProveedor").ToString.Substring(80, odr.Item("direccionProveedor").ToString.Length - 80) ' TDRPRC = Direccion        -tamaño 80 segun archivo
                    Else
                        obeProveedor.PSTDRPRC = ("" & odr.Item("direccionProveedor") & "").ToString.Trim  ' TDRPRC = Direccion        -tamaño 80 segun archivo
                    End If
                    obeProveedor.PNCPAIS = 0
                    obeProveedor.PSTNROFX = ""
                    obeProveedor.PSTLFNO1 = "" & odr.Item("vc_SupplierFax") & ""    'NFAXPRO = Fax Proveedor
                    obeProveedor.PSTEMAI2 = "" & odr.Item("vc_SupplierTelephone") & ""  'NTELPRO = Teléfono Proveedor
                    obeProveedor.PSTPRSCN = "" & odr.Item("vc_SupplierReference") & ""   'NCTOPRO = Contacto Proveedor
                    obeProveedor.PSTLFNO2 = ""  'NTCTOPR = Teléfono contacto Proveedor
                    obeProveedor.PSTEMAI3 = "" & odr.Item("vc_SupplierReferenceEmail") & "" 'TMCTOPR = Mail contacto Proveedor
                    obeProveedor.PNNDSDMP = 0
                    .PNCPRVCL = ObtenerCodigoProveedor(obeProveedor)
                End With
                _olbeOc.Add(obeOrdenDeCompra)
            Next

            'LLenamos el detalle OC
            For Each odr As DataRow In oDtsOc.Tables(1).Rows
                obeOrdenDeCompraDet = New beOrdenCompra
                With obeOrdenDeCompraDet
                    .PNCCLNT = dblCodCliente
                    .NrOCCliente = odr.Item("in_PurchaseOrder")
                    .NrItemCliente = odr.Item("in_PurchaseOrderLine")
                    .PSNORCML = odr.Item("vc_PurchaseOrder")     'NNROPO = Numero de Orden de Compra
                    .PSTDITIN = "" ' TDECOIN = Descripción corta en Ingles
                    .PSCPTDAR = "" ' MPDAARA = Numero de Partida Arancelaria

                    .PNQCNTIT = Val(odr.Item("fl_QuantityOrdered")) ' QCANORD= Cantidad Ordenada
                    .PNQSDOIT = 0
                    .PNQINEMP = 0
                    .PSTUNDIT = odr.Item("vc_UnitMeasureCode")   'CUNDMED= Unidad de Medida
                    psPrecio = Val(odr.Item("fl_UnitPrice"))  'SPREUND = Precio Unitario
                    If psPrecio.Length > 1 Then
                        .PNIVTOIT = .PNQCNTIT * Convert.ToDecimal(psPrecio)
                        .PNIVTOIT = Format(.PNIVTOIT, "0000000000.00000")
                        .PNIVUNIT = Val(psPrecio)
                    End If
                    If Not odr.Item("dt_EstimatedDate").ToString.Equals("") Then
                        .PNFMPDME = HelpClass.CFecha_a_Numero8Digitos(odr.Item("dt_EstimatedDate")) ' Fec Máx. Prov. despachará merc.
                    End If
                    .PNFMPIME = 0  'DMATCLI = Fec. Máx. material Req. en Cliente
                    .PSTLUGEN = "" 'TLUGEN = Lugar entrega al cliente
                    .PSTLUGOR = "" 'TLUREC = Lugar recepción (alm. origen) - CONFIRMAR
                    .PSSFLGES = "A"
                    .PSSESTRG = "A"
                    .PNQSTKIT = 0
                    psToleranciaMinina = 0   'QTOLMIN = Cantidad tolerancia mínima
                    .PNQTOLMIN = Val(IIf(psToleranciaMinina.Length > 1, psToleranciaMinina, 0)) 'QTOLMIN = Cantidad tolerancia mínima
                    psToleranciamaxima = 0
                    .PNQTOLMAX = Val(IIf(psToleranciamaxima.Length > 1, psToleranciamaxima, 0))
                    .PSTRFRN = "" 'TREFRN1 = Referencia 1 Cliente (Solicitante)
                    .PSTRFRNA = "" 'TREFRN2 = Referencia 2 Cliente (Lote)
                    .PSTRFRNB = "" 'TREFRN3 = Referencia 3 Cliente (otro.)
                    .PSTRFRN1 = odr.Item("vc_CentroCosto")   'TREFRN4 = Referencia 4 Cliente (Centro Dest.)
                    .PSTRFRN2 = "" 'TREFRN5 = Referencia 5 Cliente (Almacen Dest)
                    .PNNRITOC = odr.Item("vc_PurchaseOrderLine")  ' Nro de Item  MNROITE
                    .PSTCITCL = odr.Item("vc_StockCode") ' CMERCLI = Código de Mercadería (Cliente)
                    .PSTCITPR = ""   'codigo de proveedor    CCODPRO
                    .PSTDITES = ValidarCaracter.validaCaracter("" & odr.Item("DescripcionItem") & "", .PSERROR) ' TDECOCA = Descripción corta en castellano
                    .PNFMPDME = HelpClass.CDate_a_Numero8Digitos(odr.Item("dt_EstimatedDate"))     'DPRODES = Fec Máx. Prov. despachará merc.
                    If .PSERROR.Trim.Length > 0 Then
                        MessageBox.Show(.PSERROR, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Function
                    End If
                    _olbeDetOc.Add(obeOrdenDeCompraDet)
                End With

            Next

            'LLenamos el detalle OC Pedido
            For Each odr As DataRow In oDtsOc.Tables(2).Rows
                obeOrdenDeCompraDetPed = New beOrdenCompra
                With obeOrdenDeCompraDetPed
                    .PNCCLNT = dblCodCliente
                    .PSTPOOCM = "" & odr.Item("vc_TipoDoc") & ""
                    .PSNORCML = "" & odr.Item("vc_PurchaseOrder")     'NNROPO = Numero de Orden de Compra
                    .PNNRITOC = odr.Item("vc_PurchaseOrderLine")
                    .PSNRFRPD = odr.Item("vc_nordpr")
                    .PNQCNTIT = odr.Item("vc_qitems")

                    If .PSERROR.Trim.Length > 0 Then
                        MessageBox.Show(.PSERROR, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Function
                    End If
                    _olbeDetOcPed.Add(obeOrdenDeCompraDetPed)
                End With

            Next

        Catch ex As Exception
            HelpClass.ErrorMsgBox()
        End Try
    End Function

    Private Function ObtenerCodigoProveedor(ByVal obeProveedor As beProveedor) As Decimal

        Dim decCodProv As Decimal = 0
        Dim obrProveedor As New brProveedor
        decCodProv = GrabarProveedoCliente(obeProveedor)
        If decCodProv = 0 Then
            Return 0
        End If
        Return decCodProv
    End Function

    Private Function GrabarProveedoCliente(ByVal obeProveedor As beProveedor) As Decimal

        Dim decCodProv As Decimal = 0
        Dim obrProveedor As New brProveedor
        decCodProv = obrProveedor.GrabarProveedorDeCliente_v2(obeProveedor)
        If decCodProv = 0 Then
            HelpClass.ErrorMsgBox()
            Return 0
        End If
        Return decCodProv
    End Function


End Class
