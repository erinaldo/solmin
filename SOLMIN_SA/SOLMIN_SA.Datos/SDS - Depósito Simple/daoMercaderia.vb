
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF
Imports RANSA.TYPEDEF.Mercaderia

Imports RANSA.TYPEDEF.beMercaderia
Imports Ransa.Utilitario

Namespace slnSOLMIN_SDS.DAO.Mercaderia
    Public Class daoMercaderia
        Inherits daBase(Of TYPEDEF.beMercaderia)



#Region " Tipos de Datos "

#End Region
#Region " Atributos "

#End Region
#Region " Propiedades "

#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Métodos "
        

        ''' <summary>
        ''' Listado del Stock de Productos a una determinada fecha distribuidos por Almacén
        ''' </summary>
        Public Shared Function fdtListar_StockProductosPorUbicacion_R01(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_Qry_StockProductosPorUbicacionF01, _
                                                                        ByRef strMensajeError As String) As DataTable
            Dim dtTemp As DataTable
            Dim objParametros As Parameter = New Parameter
            ' Ingresamos los parametros del Procedure
            With objParametros
                .Add("IN_CCLNT", TD_Filtro.pCCLNT_CodigoCliente)
                .Add("IN_CTPDP6", TD_Filtro.pCTPDP6_TipoDeposito)
                .Add("IN_CTPALM", TD_Filtro.pCTPALM_TipoAlmacen)
                .Add("IN_CALMC", TD_Filtro.pCALMC_Almacen)
                .Add("IN_CZNALM", TD_Filtro.pCZNALM_ZonaAlmacen)
                .Add("IN_STQRY", TD_Filtro.pSTQRY_StatusValorizado)
            End With
            'Try
            strMensajeError = ""
            dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_SDS_ORDEN_SERV_RZIM07_R01", objParametros)
            'Catch ex As Exception
            '    dtTemp = New DataTable
            '    strMensajeError = "Error producido en la funcion : << fdtListar_StockProductosPorAlmacen_R01 >> de la clase << daoMercaderia >> " & vbNewLine & _
            '                      "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SDS_ORDEN_SERV_RZIM07_R01 >> " & vbNewLine & _
            '                      "Motivo del Error : " & ex.Message
            'Finally
            'objSqlManager = Nothing
            'objParametros = Nothing
            'End Try
            Return dtTemp
        End Function

        ''' <summary>
        ''' Listado de los movimientos (I y S) de mercaderias comprendido en un determinado intervalo de tiempo - Agrupado por Fecha
        ''' </summary>
        Public Shared Function fdtListar_MovimientoProductos_R01(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_FiltroRepMovProductos, _
                                                                 ByRef strMensajeError As String) As DataTable
            Dim dtTemp As DataTable
            Dim objParametros As Parameter = New Parameter
            ' Ingresamos los parametros del Procedure
            With objParametros
                .Add("IN_CCLNT", TD_Filtro.pCCLNT_CodigoCliente)
                .Add("IN_FMOVI", TD_Filtro.pFMOVI_FechaInventarioInt)
                .Add("IN_FMOVF", TD_Filtro.pFMOVF_FechaInventarioInt)
                .Add("IN_STPODP", TD_Filtro.pSTPODP_TipoDeposito)
                .Add("IN_STQRY", TD_Filtro.pSTQRY_StatusValorizado)
                .Add("IN_CMRCLR", TD_Filtro.pSCMRCLR_CodigoMercaderia)
                .Add("IN_TMRCD2", TD_Filtro.pSTMRCD2_DetalleMercaderia)
            End With
            'Try
            strMensajeError = ""
            dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_SDS_SOLIC_SERV_RZIT06_R01", objParametros)
            'Catch ex As Exception
            '    dtTemp = New DataTable
            '    strMensajeError = "Error producido en la funcion : << fdtListar_MovimientoProductos_R01 >> de la clase << daoMercaderia >> " & vbNewLine & _
            '                      "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SDS_SOLIC_SERV_RZIT06_R01 >> " & vbNewLine & _
            '                      "Motivo del Error : " & ex.Message
            'Finally
            '    objSqlManager = Nothing
            '    objParametros = Nothing
            'End Try
            Return dtTemp
        End Function

        ''' <summary>
        ''' Listado de los movimientos (I y S) de mercaderias comprendido en un determinado intervalo de tiempo - Agrupado por Código Cliente
        ''' </summary>
        Public Shared Function fdtListar_MovimientoProductos_R02(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_FiltroRepMovProductos, _
                                                                 ByRef strMensajeError As String) As DataTable
            Dim dtTemp As DataTable
            Dim objParametros As Parameter = New Parameter
            ' Ingresamos los parametros del Procedure
            With objParametros
                .Add("IN_CCLNT", TD_Filtro.pCCLNT_CodigoCliente)
                .Add("IN_FMOVI", TD_Filtro.pFMOVI_FechaInventarioInt)
                .Add("IN_FMOVF", TD_Filtro.pFMOVF_FechaInventarioInt)
                .Add("IN_STPODP", TD_Filtro.pSTPODP_TipoDeposito)
            End With
            'Try
            strMensajeError = ""
            dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_SDS_SOLIC_SERV_RZIT06_R02", objParametros)
            'Catch ex As Exception
            '    dtTemp = New DataTable
            '    strMensajeError = "Error producido en la funcion : << fdtListar_MovimientoProductos_R02 >> de la clase << daoMercaderia >> " & vbNewLine & _
            '                      "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SDS_SOLIC_SERV_RZIT06_R02 >> " & vbNewLine & _
            '                      "Motivo del Error : " & ex.Message
            'Finally
            '    objSqlManager = Nothing
            '    objParametros = Nothing
            'End Try
            Return dtTemp
        End Function

        ''' <summary>
        ''' Listado de los Movimientos (I y S) de mercaderias por Ubicación comprendido en un determinado intervalo de tiempo - Agrupado por Fecha
        ''' </summary>
        Public Shared Function fdtListar_MovimientoProductosPorUbicacion_R01(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_FiltroRepMovProductosPorUbicacion, _
                                                                             ByRef strMensajeError As String) As DataTable
            Dim dtTemp As DataTable
            Dim objParametros As Parameter = New Parameter
            ' Ingresamos los parametros del Procedure
            With objParametros
                .Add("IN_CCLNT", TD_Filtro.pCCLNT_CodigoCliente)
                .Add("IN_FMOVI", TD_Filtro.pFMOVI_FechaInventarioInt)
                .Add("IN_FMOVF", TD_Filtro.pFMOVF_FechaInventarioInt)
                .Add("IN_STPODP", TD_Filtro.pSTPODP_TipoDeposito)
                .Add("IN_CTPALM", TD_Filtro.pCTPALM_TipoAlmacen)
                .Add("IN_CALMC", TD_Filtro.pCALMC_Almacen)
                .Add("IN_CZNALM", TD_Filtro.pCZNALM_ZonaAlmacen)
                .Add("IN_STQRY", TD_Filtro.pSTQRY_StatusValorizado)
            End With
            Try
                strMensajeError = ""
                dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_SDS_SOLIC_SERV_RZIT07_R01", objParametros)
            Catch ex As Exception
                dtTemp = New DataTable
                strMensajeError = "Error producido en la funcion : << fdtListar_MovimientoProductosPorUbicacion_R01 >> de la clase << daoMercaderia >> " & vbNewLine & _
                                  "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SDS_SOLIC_SERV_RZIT07_R01 >> " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return dtTemp
        End Function

        Public Function ListarMercaderiaPorCliente(ByVal obeMercaderia As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)

            Dim oDt As New DataTable
            Dim objSqlManager As New SqlManager
            Dim objMercaderia As TYPEDEF.beMercaderia
            Dim olbeMercaderia As New List(Of TYPEDEF.beMercaderia)
            Dim objParam As New Parameter
            'Try

            objParam.Add("PNCCLNT", obeMercaderia.PNCCLNT)
            If Not (obeMercaderia.PSCMRCLR.Trim.Equals("")) Then
                objParam.Add("PSCMRCLR", obeMercaderia.PSCMRCLR)
            End If
            objParam.Add("PAGESIZE", obeMercaderia.PageSize)
            objParam.Add("PAGENUMBER", obeMercaderia.PageNumber)
            objParam.Add("PAGECOUNT", 0, ParameterDirection.Output)
            oDt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_LISTAR_MERCADERIA_POR_CLIENTE", objParam)
            Dim pPageCount As Decimal = objSqlManager.ParameterCollection("PAGECOUNT")
            For Each item As DataRow In oDt.Rows
                objMercaderia = New TYPEDEF.beMercaderia
                objMercaderia.PSTGRCLR = ("" & item("TGRCLR")).ToString.Trim
                objMercaderia.PSTFMCLR = ("" & item("TFMCLR")).ToString.Trim
                objMercaderia.PSCFMCLR = ("" & item("CFMCLR")).ToString.Trim
                objMercaderia.PSCGRCLR = ("" & item("CGRCLR")).ToString.Trim
                objMercaderia.PSCMRCLR = ("" & item("CMRCLR")).ToString.Trim
                objMercaderia.PSTMRCD2 = ("" & item("TMRCD2")).ToString.Trim
                objMercaderia.PSCMRCD = ("" & item("CMRCD")).ToString.Trim
                objMercaderia.PSMARCRE = ("" & item("MARCRE")).ToString.Trim
                objMercaderia.PNQSLMC = item("QSLMC")
                objMercaderia.PNQSLMP = item("QSLMP")
                objMercaderia.PSCUNCN5 = ("" & item("CUNCN5")).ToString.Trim
                objMercaderia.PSCUNPS5 = ("" & item("CUNPS5")).ToString.Trim
                objMercaderia.PSFUNDS2 = ("" & item("FUNDS2")).ToString.Trim
                objMercaderia.PNNORDSR = item("NORDSR")
                objMercaderia.PNQCMMC = item("QCMMC")
                objMercaderia.PNQCMMP = item("QCMMP")
                objMercaderia.PNQCMMV = item("QCMMV")
                objMercaderia.PNSALDO = item("SALDO")
                objMercaderia.PSSESTRG = ("" & item("SESTRG")).ToString.Trim
                obeMercaderia.PSDEPOSITO = ("" & item("DEPOSITO")).ToString.Trim
                obeMercaderia.PSSITUAC = ("" & item("SITUAC")).ToString.Trim
                obeMercaderia.PNCANT_OS = item("CANT_OS")
                '
                olbeMercaderia.Add(objMercaderia)
            Next
            '  Return Listar("SP_SOLMIN_SA_LISTAR_MERCADERIA_POR_CLIENTE", objParam)
            ' obj.PageCount = Me.PageCount
            'Catch ex As Exception
            '    Return Nothing
            'End Try
            Return olbeMercaderia
        End Function

        Public Function ListaKardex(ByVal obeKardex As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
            Dim oDt As New DataTable
            Dim objSqlManager As New SqlManager
            Dim olbeKardex As New List(Of TYPEDEF.beMercaderia)
            Dim objParam As New Parameter
            'Try

            objParam.Add("PNNORDSR", obeKardex.PNNORDSR)
            Return Listar("SP_SOLMIN_SA_SDS_LISTA_KARDEX", objParam)
            'Catch ex As Exception
            '    Return Nothing
            'End Try

        End Function


        Public Function ListaKardexAlmacen(ByVal obeKardex As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
            Dim oDt As New DataTable
            Dim objSqlManager As New SqlManager
            Dim olbeKardex As New List(Of TYPEDEF.beMercaderia)
            Dim objParam As New Parameter
            'Try

            objParam.Add("PSCTPALM", obeKardex.PSCTPALM)
            objParam.Add("PSCALMC", obeKardex.PSCALMC)
            objParam.Add("PSCZNALM", obeKardex.PSCZNALM) 'CSR-HUNDRED
            objParam.Add("PNNORDSR", obeKardex.PNNORDSR)
            Return Listar("SP_SOLMIN_SA_SDS_LISTA_KARDEX_X_ALMACEN_ZONA", objParam)
            'Catch ex As Exception
            '    Return Nothing
            'End Try

        End Function


        Public Function ListaKardexPorSolicitudServicio(ByVal obeKardex As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
            Dim oDt As New DataTable
            Dim objSqlManager As New SqlManager
            Dim olbeKardex As New List(Of TYPEDEF.beMercaderia)
            Dim objParam As New Parameter
            'Try

            objParam.Add("PNNORDSR", obeKardex.PNNORDSR)
            objParam.Add("PNNSLCSR", obeKardex.PNNSLCSR)
            Return Listar("SP_SOLMIN_SA_SDS_KARDEX_POR_SOLICITUD_SERVICIO", objParam)
            'Catch ex As Exception
            '    Return Nothing
            'End Try

        End Function


        Public Function ListaSeriePorSolicitudServicio(ByVal obeKardex As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
            Dim oDt As New DataTable
            Dim objSqlManager As New SqlManager
            Dim olbeKardex As New List(Of TYPEDEF.beMercaderia)
            Dim objParam As New Parameter
            'Try

            objParam.Add("PNNORDSR", obeKardex.PNNORDSR)
            objParam.Add("PNNSLCSR", obeKardex.PNNSLCSR)
            If obeKardex.PSTIPO = "I" Then
                Return Listar("SP_SOLMIN_SA_SERIE_POR_SOLICITUD_SERVICIO_ING", objParam)
            Else
                Return Listar("SP_SOLMIN_SA_SERIE_POR_SOLICITUD_SERVICIO_SAL", objParam)
            End If

            'Catch ex As Exception
            '    Return Nothing
            'End Try

        End Function

        Public Function ListaUbicacionPorSolicitudServicio(ByVal obeKardex As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
            Dim oDt As New DataTable
            Dim objSqlManager As New SqlManager
            Dim olbeKardex As New List(Of TYPEDEF.beMercaderia)
            Dim objParam As New Parameter
            'Try

            objParam.Add("PNNORDSR", obeKardex.PNNORDSR)
            objParam.Add("PNNSLCSR", obeKardex.PNNSLCSR)
            Return Listar("SP_SOLMIN_SA_UBICACION_POR_SOLICITUD_SERVICIO", objParam)
            'Catch ex As Exception
            '    Return Nothing
            'End Try

        End Function

        Public Function ListaLotesPorSolicitudServicio(ByVal obeKardex As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
            Dim oDt As New DataTable
            Dim objSqlManager As New SqlManager
            Dim objParam As New Parameter
            'Try

            objParam.Add("PNNORDSR", obeKardex.PNNORDSR)
            objParam.Add("PNNSLCSR", obeKardex.PNNSLCSR)
            Return Listar("SP_SOLMIN_SA_LOTE_POR_SOLICITUD_SERVICIO", objParam)
            'Catch ex As Exception
            '    Return Nothing
            'End Try

        End Function


        Public Function ListaLotesPorOSPosicion(ByVal obeKardex As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
            Dim oDt As New DataTable
            Dim objSqlManager As New SqlManager
            Dim olbeKardex As New List(Of TYPEDEF.beMercaderia)
            Dim objParam As New Parameter
            'Try

            objParam.Add("PNNORDSR", obeKardex.PNNORDSR)
            objParam.Add("PSCTPALM", obeKardex.PSCTPALM)
            objParam.Add("PSCALMC", obeKardex.PSCALMC)
            objParam.Add("PSCSECTR", obeKardex.PSCSECTR)
            objParam.Add("PSCPSCN", obeKardex.PSCPSCN)

            Return Listar("SP_SOLMIN_SA_LOTE_POR_OS_POSICION", objParam)
            'Catch ex As Exception
            '    Return Nothing
            'End Try

        End Function


        '
        Public Function ListaPedidoPorOrdenDeCompra(ByVal obeKardex As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
            Dim oDt As New DataTable
            Dim objSqlManager As New SqlManager
            Dim olbeKardex As New List(Of TYPEDEF.beMercaderia)
            Dim objParam As New Parameter
            'Try

            objParam.Add("PNNORDSR", obeKardex.PNNORDSR)
            objParam.Add("PNCCLNT", obeKardex.PNCCLNT)
            objParam.Add("PAGESIZE", obeKardex.PageSize)
            objParam.Add("PAGENUMBER", obeKardex.PageNumber)
            objParam.Add("PAGECOUNT", 0, ParameterDirection.Output)

            Return Listar("SP_SOLMIN_SA_LISTA_PEDIDOS_POR_ORDEN_DE_SERVICIO", objParam)
            'Catch ex As Exception
            '    olbeKardex.Clear()
            '    Return olbeKardex
            'End Try

        End Function

        Public Function ListarInventarioMercaderiaxSerie(ByVal obeMercaderia As beMercaderia) As DataSet
            Dim oDs As New DataSet
            Dim objParam As New Parameter
            Dim objSql As New SqlManager
            'Try
            objParam.Add("IN_CCLNT", obeMercaderia.PNCCLNT)
            objParam.Add("IN_CTPDP6", obeMercaderia.PSCTPDP6)
            objParam.Add("IN_CGRCLR", obeMercaderia.PSCGRCLR)
            objParam.Add("IN_CFMCLR", obeMercaderia.PSCFMCLR)
            objParam.Add("IN_CSRECL", obeMercaderia.PSCSRECL)
            objParam.Add("IN_TMRCD2", obeMercaderia.PSTMRCD2)
            oDs = objSql.ExecuteDataSet("SP_SOLMIN_SA_INVENTARIO_SERIE_CLIENTE", objParam)
            'Catch ex As Exception
            '    oDs = Nothing
            'End Try
            Return oDs
        End Function

        'Public Shared Function fdtListar_PedidoDeposito(ByVal TD_Filtro As TD_FiltroRepPedDeposito) As DataTable
        '    Dim dtTemp As DataTable
        '    Dim objSql As New SqlManager
        '    Dim objParametros As Parameter = New Parameter
        '    With objParametros
        '        .Add("IN_CCLNT", TD_Filtro.pCCLNT_CodigoCliente)
        '        .Add("IN_FSLLAD_INI", TD_Filtro.pFSLLAD_FecNumPedAduanaIni)
        '        .Add("IN_FSLLAD_FIN", TD_Filtro.pFSLLAD_FecNumPedAduanaFin)
        '        .Add("IN_FVNPDD", TD_Filtro.pFVNPDD_FecVenPedido)
        '        .Add("IN_CAGNAD", TD_Filtro.pCAGNAD_CodigoAgenteAduana)
        '        .Add("IN_NPDDPA", TD_Filtro.pNPDDPA_NumPedDepAduana)
        '        .Add("IN_NCNCEM", TD_Filtro.pNCNCEM_B2AWB)
        '        .Add("IN_NFCTCM", TD_Filtro.pNFCTCM_NumFacComercial)
        '        .Add("PAGESIZE", TD_Filtro.PageSize)
        '        .Add("PAGENUMBER", TD_Filtro.PageNumber)
        '        .Add("PAGECOUNT", 0, ParameterDirection.Output)

        '    End With
        '    Try
        '        dtTemp = objSql.ExecuteDataTable("SP_SOLMIN_SA_LISTA_PEDIDO_DEPOSITO", objParametros)
        '    Catch ex As Exception
        '        dtTemp = New DataTable
        '    Finally
        '        objSql = Nothing
        '        objParametros = Nothing
        '    End Try
        '    Return dtTemp
        'End Function

        Public Function ListaMercaderiaPorClienteItem(ByVal obeMercaderia As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
            Dim oDt As New DataTable
            Dim objSqlManager As New SqlManager
            Dim olbeMercaderia As New List(Of TYPEDEF.beMercaderia)
            Dim objParam As New Parameter
            Try

                objParam.Add("PNCCLNT", obeMercaderia.PNCCLNT)
                objParam.Add("PSCMRCLR", obeMercaderia.PSCMRCLR)

                Return Listar("SP_SOLMIN_SA_OBTENER_MERCADERIA_ITEM_OC", objParam)
            Catch ex As Exception
                olbeMercaderia.Clear()
                Return olbeMercaderia
            End Try
        End Function

        Public Function flistStockMercaderiaPorCliente(ByVal obeMercaderia As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)

            Dim oDt As New DataTable
            Dim objSqlManager As New SqlManager
            Dim olbeMercaderia As New List(Of TYPEDEF.beMercaderia)
            Dim objParam As New Parameter
            'Try

            objParam.Add("PNCCLNT", obeMercaderia.PNCCLNT)
            objParam.Add("PSCMRCLR", obeMercaderia.PSCMRCLR)
            objParam.Add("PAGESIZE", obeMercaderia.PageSize)
            objParam.Add("PAGENUMBER", obeMercaderia.PageNumber)
            objParam.Add("PAGECOUNT", 0, ParameterDirection.Output)
            Return Listar("SP_SOLMIN_SA_LISTAR_STOCK_MERCADERIA_POR_CLIENTE", objParam)

            'Catch ex As Exception
            '    Return Nothing
            'End Try
        End Function

#Region "Deposito Simple por OS"

        ''' <summary>
        ''' Lista de Mercaderia por orden de servicios
        ''' </summary>
        ''' <param name="obeMercaderia"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ''' 
        Public Function flistListarMercaderiaOSNew(ByVal obeMercaderia As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
            Dim objParam As New Parameter
            'Try

            objParam.Add("PNCCLNT", obeMercaderia.PNCCLNT)
            objParam.Add("PSCTPDP6", obeMercaderia.PSCTPDP6)
            objParam.Add("PNCMRCA", obeMercaderia.PNCMRCA)
            objParam.Add("PNNORDSR", obeMercaderia.PNNORDSR)
            objParam.Add("PSTCMPMR", obeMercaderia.PSTCMPMR)

            Return Listar("SP_SOLMIN_SA_SDS_LISTA_MERCADERIA_PARA_AJUSTE_INVENTARIO", objParam)

            'Catch ex As Exception
            '    Return New List(Of beMercaderia)
            'End Try
        End Function
        Public Function flistListarMercaderiaOS(ByVal obeMercaderia As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
            Dim objParam As New Parameter
            'Try

            objParam.Add("PNCCLNT", obeMercaderia.PNCCLNT)
            objParam.Add("PSCTPDP6", obeMercaderia.PSCTPDP6)
            objParam.Add("PNCMRCA", obeMercaderia.PNCMRCA)
            objParam.Add("PNNORDSR", obeMercaderia.PNNORDSR)
            objParam.Add("PSTCMPMR", obeMercaderia.PSTCMPMR)

            Return Listar("SP_SOLMIN_SA_SDS_MERCADERIA_POR_OS_LISTAR", objParam)

            'Catch ex As Exception
            '    Return New List(Of beMercaderia)
            'End Try
        End Function

        Public Function fCargarPrimerRegistro(ByVal obeMercaderia As TypeDef.beMercaderia) As List(Of TypeDef.beMercaderia)
            Dim objParam As New Parameter
            'Try

            objParam.Add("PNNCNTR", obeMercaderia.PNNCNTR)

            Return Listar("SP_SOLMIN_SA_CARGAR_PRIMER_REGISTRO", objParam)

            'Catch ex As Exception
            '    Return New List(Of beMercaderia)
            'End Try
        End Function

        Public Function flistListarMercaderiRansa(ByVal obeMercaderia As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
            Dim objParam As New Parameter
            Try
                objParam.Add("PSCFMLA", obeMercaderia.PSCFMLA)
                objParam.Add("PSCGRPO", obeMercaderia.PSCGRPO)
                objParam.Add("PSCMRCD", obeMercaderia.PSCMRCD)
                objParam.Add("PSTCMPMR", obeMercaderia.PSTCMPMR)

                Return Listar("SP_SOLMIN_SA_SDS_MERCADERIA_LISTAR", objParam)
            Catch ex As Exception
                Return New List(Of beMercaderia)
            End Try
        End Function

        Public Function ListaContratosVigentes(ByVal obeContrato As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
            Dim objParam As New Parameter
            'Try
            objParam.Add("PNCCLNT", obeContrato.PNCCLNT)
            objParam.Add("PSCTPDP3", obeContrato.PSCTPDP3)
            Return Listar("SP_SOLMIN_SA_CONTRATO_VIGENTE_LISTAR", objParam)
            'Catch ex As Exception
            '    Return New List(Of beMercaderia)
            'End Try
        End Function


        Public Function ListaFamiliaDeMercaderia(ByVal obeMercaderia As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
            Dim objParam As New Parameter
            'Try

            objParam.Add("PSCFMLA", obeMercaderia.PSCFMLA.Trim)
            objParam.Add("PSTCMPFM", obeMercaderia.PSTCMPFM.Trim)
            Return Listar("SP_SOLMIN_SA_FAMILIA_MERCADERIA_LISTAR", objParam)
            'Catch ex As Exception
            '    Return New List(Of beMercaderia)
            'End Try
        End Function

        Public Function ListaGrupoDeMercaderia(ByVal obeMercaderia As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
            Dim objParam As New Parameter
            'Try
            objParam.Add("PSCFMLA", obeMercaderia.PSCFMLA)
            objParam.Add("PSCGRPO", obeMercaderia.PSCGRPO)
            objParam.Add("PSTCMPGM", obeMercaderia.PSTCMPGM)
            Return Listar("SP_SOLMIN_SA_GRUPO_MERCADERIA_LISTAR", objParam)
            'Catch ex As Exception
            '    Return New List(Of beMercaderia)
            'End Try
        End Function


        Public Function ListaMarca(ByVal obeParam As beMercaderia) As List(Of beMercaderia)
            Dim lobjParams As New Parameter
            'Try
            lobjParams.Add("PSSTPOUN", obeParam.PNCMRCA)
            lobjParams.Add("PSCUNDMD", obeParam.PSTCMMRC)

            lobjParams.Add("PAGESIZE", obeParam.PageSize)
            lobjParams.Add("PAGENUMBER", obeParam.PageNumber)
            lobjParams.Add("PAGECOUNT", 0, ParameterDirection.Output)
            Return Listar("SP_SOLMIN_SA_MARCA_MERCADERIA_LISTAR", lobjParams)
            'Catch ex As Exception
            '    Return New List(Of beMercaderia)
            'End Try
        End Function


        Public Function fintCrearOrdenServicio(ByVal objOrdenServicio As beMercaderia) As Integer
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim blnResultado As Boolean = True
            Dim retorno As Integer = 0
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            With objOrdenServicio
                objParametros.Add("IN_CCLNT", .PNCCLNT)
                objParametros.Add("IN_NCNTR", .PNNCNTR)
                objParametros.Add("IN_CTPDP3", .PSCTPDP3)
                objParametros.Add("IN_CTPPR1", .PSCTPPR1)
                objParametros.Add("IN_QMRCD", .PNQMRCD)
                objParametros.Add("IN_CUNCND", .PSCUNCND)
                objParametros.Add("IN_QPSMR", .PNQPSMR)
                objParametros.Add("IN_CUNPS0", .PSCUNPS0)
                objParametros.Add("IN_QVLMR", .PNQVLMR)
                objParametros.Add("IN_CUNVLR", .PSCUNVLR)
                objParametros.Add("IN_FUNCTL", .PSFUNCTL)
                objParametros.Add("IN_FUNDS", .PSFUNDS)
                objParametros.Add("IN_CMRCD", .PSCMRCD)
                objParametros.Add("IN_CMRCA", .PNCMRCA)
                objParametros.Add("IN_NTRMNL", .PSNTRMNL)
                objParametros.Add("IN_USUARI", .PSUSUARIO)
            End With
            'Try

            Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDS_ORDEN_SERVICIO_INSERT", objParametros)
            objSqlManager = Nothing
            objParametros = Nothing
            retorno = 1
            Return retorno
            'Return 1
            'Catch ex As Exception
            '    Return 0
            'Finally
            '    objSqlManager = Nothing
            '    objParametros = Nothing
            'End Try
            'Return blnResultado
        End Function

        Public Function fintActualizarOrdenServicio(ByVal objOrdenServicio As beMercaderia) As Integer
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            objSqlManager.TransactionController(TransactionType.Automatic)
            Dim retorno As Integer = 0
            ' Ingresamos los parametros del Procedure
            With objOrdenServicio
                objParametros.Add("IN_CCLNT", .PNCCLNT)
                objParametros.Add("IN_NORDSR", .PNNORDSR)
                objParametros.Add("IN_QMRCD1", .PNQMRCD)
                objParametros.Add("IN_QPSMR1", .PNQPSMR)
                objParametros.Add("IN_QVLMR1", .PNQVLMR)
                objParametros.Add("IN_USUARI", .PSUSUARIO)
                objParametros.Add("IN_NTRMNL", .PSNTRMNL)
            End With
            'Try

            Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDS_ACTUALIZAR_ORDEN_SERVICIO", objParametros)
            retorno = 1
            'Catch ex As Exception
            '    Return 0
            'Finally
            objSqlManager = Nothing
            objParametros = Nothing
            'End Try
            'Return 0
            Return retorno
        End Function

        Public Function fintObtener_NroGuiaRansa(ByVal ObeMercaderia As beMercaderia) As Decimal
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            ' variables para recuperar la información de parámetro de salida
            ObeMercaderia.PSSTADEF = "N"
            If ObeMercaderia.blnStatusDefinitivo Then ObeMercaderia.PSSTADEF = "S"
            objSqlManager.TransactionController(TransactionType.Automatic)

            ' Ingresamos los parametros del Procedure
            objParametros.Add("IN_CSRVC", ObeMercaderia.PNCSRVC)
            objParametros.Add("IN_STPODP", ObeMercaderia.PSSTPODP)
            objParametros.Add("IN_STADEF", ObeMercaderia.PSSTADEF)
            objParametros.Add("IN_USUARI", ObeMercaderia.PSUSUARIO)
            objParametros.Add("OU_NGUIRN", 0, ParameterDirection.Output)
            Try

                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDS_ALMACEN_NGUIRN", objParametros)
                ' Obteniendo los valores devueltos
                Return objSqlManager.ParameterCollection.Item("OU_NGUIRN")
            Catch ex As Exception
            Finally
                objSqlManager = Nothing
                objParametros = Nothing

            End Try
            Return 0
        End Function

        Public Function fintRecepcionMercaderia(ByRef olbeMercaderia As List(Of beMercaderia)) As Integer
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter
            Dim blnResultado As Boolean = True
            objSqlManager.TransactionController(TransactionType.Automatic)
            Dim strTemp1, strTemp2, strTemp3 As String
            Dim retorno As Integer = 0
            'Try
            ' ---------------------------------------------------------'
            ' Primer Paso - Ingresar las Observaciones de la Recepción '
            ' ---------------------------------------------------------'
            ' Separando las observaciones en las Tres (3) cadenas respectivas
            Select Case olbeMercaderia.Item(0).PSTOBSER.Length
                Case Is > 120
                    strTemp1 = olbeMercaderia.Item(0).PSTOBSER.Substring(0, 60)
                    strTemp2 = olbeMercaderia.Item(0).PSTOBSER.Substring(60, 60)
                    strTemp3 = olbeMercaderia.Item(0).PSTOBSER.Substring(120)
                Case Is > 60
                    strTemp1 = olbeMercaderia.Item(0).PSTOBSER.Substring(0, 60)
                    strTemp2 = olbeMercaderia.Item(0).PSTOBSER.Substring(60)
                    strTemp3 = ""
                Case Else
                    strTemp1 = olbeMercaderia.Item(0).PSTOBSER
                    strTemp2 = ""
                    strTemp3 = ""
            End Select

            objParametros = New Parameter
            With objParametros
                .Add("IN_TPODOC", olbeMercaderia.Item(0).PNCSRVC)
                .Add("IN_NGUIIS", olbeMercaderia.Item(0).PNNGUIRN)
                .Add("IN_TOBSG1", strTemp1)
                .Add("IN_TOBSG2", strTemp2)
                .Add("IN_TOBSG3", strTemp3)
                .Add("IN_NTRMNL", olbeMercaderia.Item(0).PSNTRMNL)
                .Add("IN_USUARI", olbeMercaderia.Item(0).PSUSUARIO)
            End With
            Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDS_ALMACEN_OBSERV_INS", objParametros)
            ' -------------------------------------------------'
            ' Segundo Paso - Recorremos los Item recepcionados '
            ' -------------------------------------------------'
            For Each obeMercaderia As beMercaderia In olbeMercaderia
                objParametros = New Parameter
                With objParametros
                    .Add("IN_CCLNT", olbeMercaderia.Item(0).PNCCLNT)
                    .Add("IN_NORDSR", obeMercaderia.PNNORDSR)
                    .Add("IN_NCNTR", obeMercaderia.PNNCNTR)
                    .Add("IN_NAUTR", obeMercaderia.PNNAUTR)
                    .Add("IN_NCRCTC", obeMercaderia.PNNCRCTC)
                    .Add("IN_NRITOC", obeMercaderia.PNNRITOC)
                    .Add("IN_CCMPN", olbeMercaderia.Item(0).PSCCMPN)
                    .Add("IN_CDVSN", olbeMercaderia.Item(0).PSCDVSN)
                    .Add("IN_CSRVC", olbeMercaderia.Item(0).PNCSRVC)
                    .Add("IN_CTRSP", olbeMercaderia.Item(0).PNCTRSP)
                    .Add("IN_NPLCCM", olbeMercaderia.Item(0).PSNPLCCM)
                    .Add("IN_NBRVCH", olbeMercaderia.Item(0).PSNBRVCH)
                    .Add("IN_CTPALM", obeMercaderia.PSCTPALM)
                    .Add("IN_CALMC", obeMercaderia.PSCALMC)
                    .Add("IN_CZNALM", obeMercaderia.PSCZNALM)
                    .Add("IN_NGUIRN", olbeMercaderia.Item(0).PNNGUIRN)

                    .Add("IN_QTRMC", obeMercaderia.PNQTRMC)
                    .Add("IN_QTRMP", obeMercaderia.PNQTRMP)

                    .Add("IN_CUNCN6", obeMercaderia.PSCUNCNT)
                    .Add("IN_CUNPS6", obeMercaderia.PSCUNPST)
                    .Add("IN_CUNVL6", obeMercaderia.pSCUNVLT)

                    .Add("IN_STPODP", obeMercaderia.PSCTPDPS)
                    .Add("IN_CTPOCN", obeMercaderia.PSCTPOCN)
                    .Add("IN_TOBSRV", obeMercaderia.PSTOBSRV)
                    .Add("IN_NGUICL", obeMercaderia.PSNGUICL)
                    .Add("IN_NORCCL", obeMercaderia.PSNORCCL)
                    .Add("IN_NRUCLL", obeMercaderia.PSNRUCLL)
                    .Add("IN_CCNTD", obeMercaderia.PSCCNTD)

                    .Add("IN_FUNDS3", obeMercaderia.PSFUNDS2)
                    .Add("IN_STPING", obeMercaderia.PSSTPING)
                    .Add("IN_NSLCRF", obeMercaderia.PNNSLCRF)
                    .Add("IN_TIPORG", obeMercaderia.PSTIPORG)
                    .Add("IN_TIPORI", obeMercaderia.PSTIPORI)
                    .Add("IN_CPRVCL", obeMercaderia.PSCPRVCL)
                    .Add("IN_SCNEMB", obeMercaderia.PSSCNEMB)
                    .Add("IN_FRLZSR", obeMercaderia.PNFRLZSR)
                    .Add("IN_NTRMNL", olbeMercaderia.Item(0).PSNTRMNL)
                    .Add("IN_USUARI", olbeMercaderia.Item(0).PSUSUARIO)
                    .Add("OU_NSLCSR", 0, ParameterDirection.Output)

                End With
                Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDS_ALMACEN_INS", objParametros)
                obeMercaderia.PNNSLCSR = objSqlManager.ParameterCollection("OU_NSLCSR")



            Next
            objSqlManager = Nothing
            objParametros = Nothing

            retorno = 1
            'Return 1
            'Catch ex As Exception
            'Finally
            'End Try
            'Return 0
            Return retorno
        End Function

        Public Function fdsObtenerGuiaRecepcion(ByVal ObeMercaderia As beMercaderia) As DataSet
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            With ObeMercaderia
                objParametros.Add("PNNGUIRN", .PNNGUIRN)
            End With
            'Try
            Return objSqlManager.ExecuteDataSet("SOLMIN_SA_SDS_GUIA_INGRESO", objParametros)
            'Catch ex As Exception
            '    Return Nothing
            'Finally
            '    objSqlManager = Nothing
            '    objParametros = Nothing
            'End Try
            'Return Nothing
        End Function

        Public Function fdsObtenerGuiaSalida(ByVal ObeMercaderia As beMercaderia) As DataSet
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            With ObeMercaderia
                objParametros.Add("PNCCLNT", .PNCCLNT)
                objParametros.Add("PNNGUIRN", .PNNGUIRN)
            End With
            Try
                Return objSqlManager.ExecuteDataSet("SOLMIN_SA_SDS_GUIA_SALIDA", objParametros)
            Catch ex As Exception
                Return Nothing
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return Nothing
        End Function

        Public Function fintDespachoMercaderia(ByRef olbeMercaderia As List(Of beMercaderia)) As Integer
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter
            Dim blnResultado As Boolean = True
            objSqlManager.TransactionController(TransactionType.Automatic)
            Dim strTemp1, strTemp2, strTemp3 As String
            Try
                ' ---------------------------------------------------------'
                ' Primer Paso - Ingresar las Observaciones de la Recepción '
                ' ---------------------------------------------------------'
                ' Separando las observaciones en las Tres (3) cadenas respectivas
                Select Case olbeMercaderia.Item(0).PSTOBSER.Length
                    Case Is > 120
                        strTemp1 = olbeMercaderia.Item(0).PSTOBSER.Substring(0, 60)
                        strTemp2 = olbeMercaderia.Item(0).PSTOBSER.Substring(60, 60)
                        strTemp3 = olbeMercaderia.Item(0).PSTOBSER.Substring(120)
                    Case Is > 60
                        strTemp1 = olbeMercaderia.Item(0).PSTOBSER.Substring(0, 60)
                        strTemp2 = olbeMercaderia.Item(0).PSTOBSER.Substring(60)
                        strTemp3 = ""
                    Case Else
                        strTemp1 = olbeMercaderia.Item(0).PSTOBSER
                        strTemp2 = ""
                        strTemp3 = ""
                End Select

                objParametros = New Parameter
                With objParametros
                    .Add("IN_TPODOC", olbeMercaderia.Item(0).PNCSRVC)
                    .Add("IN_NGUIIS", olbeMercaderia.Item(0).PNNGUIRN)
                    .Add("IN_TOBSG1", strTemp1)
                    .Add("IN_TOBSG2", strTemp2)
                    .Add("IN_TOBSG3", strTemp3)
                    .Add("IN_NTRMNL", olbeMercaderia.Item(0).PSNTRMNL)
                    .Add("IN_USUARI", olbeMercaderia.Item(0).PSUSUARIO)
                End With
                Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDS_ALMACEN_OBSERV_INS", objParametros)
                ' -------------------------------------------------'
                ' Segundo Paso - Recorremos los Item recepcionados '
                ' -------------------------------------------------'
                For Each obeMercaderia As beMercaderia In olbeMercaderia
                    objParametros = New Parameter
                    With objParametros
                        .Add("IN_CCLNT", olbeMercaderia.Item(0).PNCCLNT)
                        .Add("IN_NORDSR", obeMercaderia.PNNORDSR)
                        .Add("IN_NCNTR", obeMercaderia.PNNCNTR)

                        .Add("IN_NCRCTC", obeMercaderia.PNNCRCTC)
                        .Add("IN_QDSVGN", obeMercaderia.PNQDSVGN)
                        .Add("IN_FTRMN", (Now.AddDays(obeMercaderia.PNQDSVGN - 1)).ToString("yyyyMMdd"))
                        .Add("IN_CCMPN", olbeMercaderia.Item(0).PSCCMPN)
                        .Add("IN_CDVSN", olbeMercaderia.Item(0).PSCDVSN)
                        .Add("IN_CSRVC", olbeMercaderia.Item(0).PNCSRVC)
                        .Add("IN_CTRSP", olbeMercaderia.Item(0).PNCTRSP)
                        .Add("IN_NPLCCM", olbeMercaderia.Item(0).PSNPLCCM)
                        .Add("IN_NBRVCH", olbeMercaderia.Item(0).PSNBRVCH)

                        .Add("IN_CTPALM", obeMercaderia.PSCTPALM)
                        .Add("IN_CALMC", obeMercaderia.PSCALMC)
                        .Add("IN_CZNALM", obeMercaderia.PSCZNALM)

                        .Add("IN_NGUIRN", olbeMercaderia.Item(0).PNNGUIRN)

                        'CANTIDAD TOTAL POR MOVIMIENTO
                        .Add("IN_QTRMC", obeMercaderia.PNQTRMC)
                        .Add("IN_QTRMP", obeMercaderia.PNQTRMP)

                        .Add("IN_CUNCN6", obeMercaderia.PSCUNCNT)
                        .Add("IN_CUNPS6", obeMercaderia.PSCUNPST)
                        .Add("IN_CUNVL6", obeMercaderia.pSCUNVLT)

                        .Add("IN_STPODP", obeMercaderia.PSCTPDPS)
                        .Add("IN_TOBSRV", obeMercaderia.PSTOBSRV)
                        .Add("IN_NGUICL", obeMercaderia.PSNGUICL)
                        .Add("IN_NORCCL", obeMercaderia.PSNORCCL)
                        .Add("IN_NRUCLL", obeMercaderia.PSNRUCLL)

                        .Add("IN_FUNDS3", obeMercaderia.PSFUNDS2)
                        .Add("IN_STPING", obeMercaderia.PSSTPING)

                        .Add("IN_NTRMNL", olbeMercaderia.Item(0).PSNTRMNL)

                        .Add("IN_CDPEPL", obeMercaderia.PNCDPEPL)
                        .Add("IN_CDREGP", obeMercaderia.PNCDREGP)

                        .Add("IN_USUARI", olbeMercaderia.Item(0).PSUSUARIO)

                        .Add("IN_CORREL", obeMercaderia.CORRELATIVO)
                        'PNQSLMC2
                        'PNQSLMC2

                        .Add("IN_CANT", obeMercaderia.PNQSLMC2)
                        .Add("IN_PESO", obeMercaderia.PNQSLMP2)
                        .Add("IN_TIPORG", obeMercaderia.PSTIPORG.Trim)
                        .Add("IN_TIPORI", obeMercaderia.PSTIPORI.Trim)
                        .Add("IN_CPRVCL", obeMercaderia.PSCPRVCL.Trim)
                        .Add("IN_FRLZSR", obeMercaderia.PNFRLZSR)
                        .Add("O_NSLCSR", 0, ParameterDirection.Output)

                    End With
                    Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDS_ALMACEN_SAL", objParametros)
                    obeMercaderia.PNNSLCSR = objSqlManager.ParameterCollection("O_NSLCSR")
                Next
                Return 1
            Catch ex As Exception
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return 0
        End Function

        Public Shared Function frptListar_MovMercaderias_x_CentroCosto(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_FiltroRepMovProductos, _
                                                        ByRef strMensajeError As String) As DataSet
            'Dim oResultado As TD_Rpt_Resultado = New TD_Rpt_Resultado
            Dim ds As New DataSet

            Try
                Dim objParametros As Parameter = New Parameter
                ' Ingresamos los parametros del Procedure
                With objParametros
                    .Add("PNCCLNT", TD_Filtro.pCCLNT_CodigoCliente)
                    .Add("PNFECINI", TD_Filtro.pFMOVI_FechaInventarioInt)
                    .Add("PNFECFIN", TD_Filtro.pFMOVF_FechaInventarioInt)
                End With
                strMensajeError = ""
                ds = objSqlManager.ExecuteDataSet("SP_SOLMIN_SA_SDS_REPORTE_MOVIMIENTOS_X_CENTRO_COSTO", objParametros)

            Catch ex As Exception
                'strMensajeError = "Error producido en la funcion : << frptListar_MovMercaderias_x_CentroCosto >> de la clase << rMercaderia >> " & vbNewLine & _
                '                  "Tipo de Operación : << Llamada Procedimiento : frptListar_MovMercaderias_x_CentroCosto >> " & vbNewLine & _
                '                  "Motivo del Error : " & ex.Message
                strMensajeError = ex.Message
            End Try
            Return ds
        End Function

        Public Shared Function frptListar_MovMercaderias_x_LugarEntrega(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_FiltroRepMovProductos, _
                                                        ByRef strMensajeError As String) As DataSet


            Dim objParametros As Parameter = New Parameter
            Dim ds As New DataSet
            Try

                ' Ingresamos los parametros del Procedure
                With objParametros
                    .Add("PNCCLNT", TD_Filtro.pCCLNT_CodigoCliente)
                    .Add("PNFECINI", TD_Filtro.pFMOVI_FechaInventarioInt)
                    .Add("PNFECFIN", TD_Filtro.pFMOVF_FechaInventarioInt)
                End With
                strMensajeError = ""
                ds = objSqlManager.ExecuteDataSet("SP_SOLMIN_SA_SDS_REPORTE_MOVIMIENTO_DESPACHO", objParametros)

            Catch ex As Exception
                'strMensajeError = "Error producido en la funcion : << frptListar_MovMercaderias_x_lugarEntrega >> de la clase << rMercaderia >> " & vbNewLine & _
                '                  "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_SDS_REPORTE_MOVIMIENTO_DESPACHO >> " & vbNewLine & _
                '                  "Motivo del Error : " & ex.Message
                strMensajeError = ex.Message
            End Try
            Return ds
        End Function



        Public Shared Function frptListar_Inventario_x_Posicion(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_Qry_StockProductosPorUbicacionF01, _
                                                         ByRef strMensajeError As String) As DataSet
            'Dim oResultado As TD_Rpt_Resultado = New TD_Rpt_Resultado
            Dim ds As New DataSet

            Try
                Dim objParametros As Parameter = New Parameter
                ' Ingresamos los parametros del Procedure
                With objParametros
                    .Add("PNCCLNT", TD_Filtro.psCCLNT_CodigoCliente)
                    .Add("PSCTPALM", TD_Filtro.pCTPALM_TipoAlmacen)
                    .Add("PSCALMC", TD_Filtro.pCALMC_Almacen)
                    .Add("PSCZNALM", TD_Filtro.pCZNALM_ZonaAlmacen)
                    '.Add("PNORDENACION", TD_Filtro.pORDENACION)
                End With
                strMensajeError = ""
                ds = objSqlManager.ExecuteDataSet("SP_SOLMIN_SA_SDS_INVENTARIO_X_POSICION_V2", objParametros)
                'oResultado.TableAdd(ds.Tables(0).Copy)
            Catch ex As Exception
                'strMensajeError = "Error producido en la funcion : << frptListar_Inventario_x_Posicion >> de la clase << rMercaderia >> " & vbNewLine & _
                '                  "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_SDS_INVENTARIO_X_POSICION >> " & vbNewLine & _
                '                  "Motivo del Error : " & ex.Message
                strMensajeError = ex.Message
            End Try
            Return ds
        End Function



        Public Shared Function frptListar_Resumen_Indicador_Mensual(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As beMercaderia, _
                                                         ByRef strMensajeError As String) As DataSet
            'Dim oResultado As TD_Rpt_Resultado = New TD_Rpt_Resultado
            Dim ds As New DataSet
            Dim dt As New DataTable
            Dim Monto As Decimal = 0
            dt.Columns.Add("Item", Type.GetType("System.String"))
            dt.Columns.Add("Total", Type.GetType("System.Decimal"))

            Dim odtSKU As New DataTable
            Dim odtERISKU As New DataTable

            Dim odtUBICACION As New DataTable
            Dim odtERIUBICACION As New DataTable

            Dim odtOCUPACION As New DataTable
            Dim odtNIVELOCUPACION As New DataTable

            Dim dr1 As DataRow
            Dim dr2 As DataRow
            Dim dr3 As DataRow


            Try
                Dim objParametros As Parameter = New Parameter
                With objParametros
                    .Add("PNCCLNT", TD_Filtro.PNCCLNT)
                    .Add("PSCCMPN", TD_Filtro.PSCCMPN)
                    .Add("PSCDVSN", TD_Filtro.PSCDVSN)
                    .Add("PNANIO", TD_Filtro.PNANIOEMI)
                    .Add("PNMES", TD_Filtro.PNMESEMI)
                    .Add("PNMAXDIAS", TD_Filtro.PNMAXDIAS)
                End With
                strMensajeError = ""
                Dim dtResumenGrafico As New DataTable
                Dim dtDatos As DataTable = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_LISTA_INDICADORES_DIARIOS_PIVOT_RPT", objParametros)
                ds.Tables.Add(dtDatos)

                dtResumenGrafico = frptListar_Resumen_Indicador_UnPivot(objSqlManager, TD_Filtro)
                dtResumenGrafico.TableName = "dtGrafico"
                ds.Tables.Add(dtResumenGrafico)


                Dim odsGraficoResumen As New DataSet
                odsGraficoResumen = frptGraficosResumen(objSqlManager, TD_Filtro)
                odtSKU = odsGraficoResumen.Tables(0).Copy
                odtSKU.TableName = "dtGraficoSKU"
                ds.Tables.Add(odtSKU)


                odtERISKU = dt.Clone()
                odtERISKU.TableName = "dtGraficoERISKU"
                If (odtSKU.Select("CTPOIN=11").Length > 0) Then
                    dr1 = odtERISKU.NewRow()
                    dr1("Item") = "ERI SKU"
                    Monto = IIf(odtSKU.Select("CTPOIN=12")(0).Item("QAINSM") = 0, 0, Math.Round((odtSKU.Select("CTPOIN=11")(0).Item("QAINSM") / odtSKU.Select("CTPOIN=12")(0).Item("QAINSM")) * 100, 2))
                    dr1("Total") = Monto
                    odtERISKU.Rows.Add(dr1)
                    odtERISKU.Rows.Add("Total", 100 - Monto)
                End If
                ds.Tables.Add(odtERISKU)
                '--------------------------------------------

                'Ubicacion----------------------------------

                odtUBICACION.TableName = "dtGraficoUbicacion"
                odtUBICACION = odsGraficoResumen.Tables(1).Copy
                ds.Tables.Add(odtUBICACION)


                odtERIUBICACION = dt.Clone()
                odtERIUBICACION.TableName = "dtGraficoERIUbicacion"
                If (odtUBICACION.Select("CTPOIN=21").Length > 0) Then
                    dr2 = odtERIUBICACION.NewRow()
                    dr2("Item") = "ERI UBICACION"
                    Monto = IIf(odtUBICACION.Select("CTPOIN=22")(0).Item("QAINSM") = 0, 0, Math.Round((odtUBICACION.Select("CTPOIN=21")(0).Item("QAINSM") / odtUBICACION.Select("CTPOIN=22")(0).Item("QAINSM")) * 100, 2))
                    dr2("Total") = Monto
                    odtERIUBICACION.Rows.Add(dr2)
                    odtERIUBICACION.Rows.Add("Total", 100 - Monto)
                End If
                ds.Tables.Add(odtERIUBICACION)

                'Ocupacion-------------------------------------------

                odtOCUPACION = odsGraficoResumen.Tables(2).Copy
                odtOCUPACION.TableName = "dtGraficoOcupacion"
                ds.Tables.Add(odtOCUPACION)


                odtNIVELOCUPACION = dt.Clone()
                odtNIVELOCUPACION.TableName = "dtGraficoNivelOcupacion"
                If (odtOCUPACION.Select("CTPOIN=31").Length > 0) Then
                    dr3 = odtNIVELOCUPACION.NewRow()
                    dr3("Item") = "POSICIONES OCUPADAS"
                    Monto = IIf(odtOCUPACION.Select("CTPOIN=32")(0).Item("QAINSM") = 0, 0, Math.Round((odtOCUPACION.Select("CTPOIN=31")(0).Item("QAINSM") / odtOCUPACION.Select("CTPOIN=32")(0).Item("QAINSM")) * 100, 2))
                    dr3("Total") = Monto
                    odtNIVELOCUPACION.Rows.Add(dr3)
                    odtNIVELOCUPACION.Rows.Add("Total", 100 - Monto)
                End If
                ds.Tables.Add(odtNIVELOCUPACION)


            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << frptListar_Resumen_Indicador_Mensual >> de la clase << rMercaderia >> " & vbNewLine & _
                                  "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_LISTA_INDICADORES_DIARIOS_PIVOT_RPT >> " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
            End Try
            Return ds
        End Function


        Private Shared Function frptListar_Resumen_Indicador_UnPivot(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As beMercaderia _
                                                        ) As DataTable
            Dim odt As New DataTable

            'Try
            Dim objParametros As Parameter = New Parameter
            With objParametros
                .Add("PNCCLNT", TD_Filtro.PNCCLNT)
                .Add("PSCCMPN", TD_Filtro.PSCCMPN)
                .Add("PSCDVSN", TD_Filtro.PSCDVSN)
                .Add("PNANIO", TD_Filtro.PNANIOEMI)
                .Add("PNMES", TD_Filtro.PNMESEMI)
            End With
            odt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_LISTA_INDICADORES_DIARIOS_UNPIVOT", objParametros)
            'Catch ex As Exception

            'End Try
            Return odt
        End Function


        Private Shared Function frptGraficosResumen(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As beMercaderia) As DataSet
            Dim objParametros As Parameter = New Parameter
            Dim ods As New DataSet
            With objParametros
                .Add("PNCCLNT", TD_Filtro.PNCCLNT)
                .Add("PSCCMPN", TD_Filtro.PSCCMPN)
                .Add("PSCDVSN", TD_Filtro.PSCDVSN)
                .Add("PNANIO", TD_Filtro.PNANIOEMI)
                .Add("PNMES", TD_Filtro.PNMESEMI)
            End With
            ods = objSqlManager.ExecuteDataSet("SP_SOLMIN_SA_LISTA_INDICADORES_DIARIOS_PIVOT_RPT_GRAFICO", objParametros)
            Return ods
        End Function

        Public Shared Function frptListar_Resumen_Anual(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As beMercaderia, _
                                                          ByRef strMensajeError As String) As DataTable
            'Dim oResultado As TD_Rpt_Resultado = New TD_Rpt_Resultado

            Dim odt As New DataTable
            Dim MaxMes As Int32 = 12
            Dim nomColumnaMes As String = ""
            Dim CTPOIN As Int32 = 0
            Dim FLAG_PORCENTUAL As Boolean = False
            Dim TOTAL As String = ""
            Try
                odt = frptListar_Resumen_Anual_Pivot(objSqlManager, TD_Filtro)
                For Each dr As DataRow In odt.Rows
                    CTPOIN = HelpClass.ObjectToInt32(dr.Item("CTPOIN"))
                    FLAG_PORCENTUAL = False
                    Select Case CTPOIN
                        Case 10 Or 20 Or 30
                            FLAG_PORCENTUAL = True
                        Case 11, 12, 21, 22
                            dr.Item("TTPOIN") = "    " & HelpClass.ObjectToString(dr.Item("TTPOIN"))
                            FLAG_PORCENTUAL = False
                        Case Else
                            FLAG_PORCENTUAL = False
                    End Select

                    If (FLAG_PORCENTUAL = True) Then
                        For index As Integer = 1 To 12
                            nomColumnaMes = FormatoNombreColumnaMes(index)
                            If (dr.Item(nomColumnaMes) IsNot Nothing And dr.Item(nomColumnaMes) IsNot DBNull.Value) Then
                                dr.Item(nomColumnaMes) = dr.Item(nomColumnaMes) & "%"
                            End If
                        Next
                    End If
                Next
                'oResultado.TableAdd(odt.Copy)
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << frptListar_Resumen_Indicador_Anual>> de la clase << rMercaderia >> " & vbNewLine & _
                                  "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_LISTA_INDICADORES_ANUAL_PIVOT >> " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
            End Try
            Return odt
        End Function

        Private Shared Function frptListar_Resumen_Anual_Pivot(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As beMercaderia _
                                                      ) As DataTable
            Dim dt As New DataTable


            'Try
            Dim objParametros As Parameter = New Parameter
            ' Ingresamos los parametros del Procedure
            With objParametros
                .Add("PNCCLNT", TD_Filtro.PNCCLNT)
                .Add("PSCCMPN", TD_Filtro.PSCCMPN)
                .Add("PSCDVSN", TD_Filtro.PSCDVSN)
                .Add("PNANIO", TD_Filtro.PNANIOEMI)
            End With
            dt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_LISTA_INDICADORES_ANUAL_PIVOT", objParametros)
            'Catch ex As Exception
            'End Try
            Return dt
        End Function

        Private Shared Function FormatoNombreColumnaMes(ByVal numeroMes As Int32) As String
            Dim retorno As String = "MES"
            Dim strDia As String = ""
            strDia = numeroMes.ToString.Trim
            If (strDia.Length <= 1) Then
                strDia = "0" & strDia
            End If
            retorno = retorno & strDia
            Return retorno
        End Function


        Public Shared Function frptListar_MovMercaderias_R03(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_FiltroRepMovProductos, _
                                                       ByRef strMensajeError As String) As DataTable
            'Dim oResultado As TD_Rpt_Resultado = New TD_Rpt_Resultado
            Dim objParametros As Parameter = New Parameter
            Dim dtTemp As New DataTable
            ' Ingresamos los parametros del Procedure
            With objParametros
                .Add("IN_CCLNT", TD_Filtro.pCCLNT_CodigoCliente)
                .Add("IN_FMOVI", TD_Filtro.pFMOVI_FechaInventarioInt)
                .Add("IN_FMOVF", TD_Filtro.pFMOVF_FechaInventarioInt)
                .Add("IN_STPODP", TD_Filtro.pSTPODP_TipoDeposito)
            End With
            Try
                strMensajeError = ""
                dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_SDS_SOLIC_SERV_RZIT06_R03", objParametros)
                dtTemp.TableName = "dtMovMercaderias_F03"


            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << frptListar_MovMercaderias_R03 >> de la clase << rMercaderia >> " & vbNewLine & _
                                  "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SDS_SOLIC_SERV_RZIT06_R03 >> " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
            End Try
            Return dtTemp
        End Function


        Public Function flistListarMercaderiaPorPedido(ByVal obeMercaderia As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
            Dim oDt As New DataTable
            Dim objSqlManager As New SqlManager
            Dim olbeKardex As New List(Of TYPEDEF.beMercaderia)
            Dim objParam As New Parameter
            'Try

            objParam.Add("PNCCLNT", obeMercaderia.PNCCLNT)
            objParam.Add("PSNRFRPD", obeMercaderia.PSNRFRPD)
            objParam.Add("PSCMRCLR", obeMercaderia.PSCMRCLR)
            Return Listar("SP_SOLMIN_SA_SDS_LISTAR_MERCADERIA_POR_PEDIDO", objParam)
            'Catch ex As Exception
            '    olbeKardex.Clear()
            '    Return olbeKardex
            'End Try

        End Function

        Public Function flistListarDetallePedidoPorOc(ByVal obeMercaderia As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
            Dim oDt As New DataTable
            Dim objSqlManager As New SqlManager
            Dim olbeKardex As New List(Of TYPEDEF.beMercaderia)
            Dim objParam As New Parameter
            'Try

            objParam.Add("PNCCLNT", obeMercaderia.PNCCLNT)
            objParam.Add("PNNORDSR", obeMercaderia.PNNORDSR)
            objParam.Add("PSNRFRPD", obeMercaderia.PSNRFRPD)
            Return Listar("SP_SOLMIN_SA_SDS_LISTAR_PEDIDOS_POR_ITEM", objParam)
            'Catch ex As Exception
            '    olbeKardex.Clear()
            '    Return olbeKardex
            'End Try

        End Function


        Public Function fdtListaParaExportarOutotecRecepcion(ByVal pbeFiltro As beDespacho) As DataSet
            Dim objParam As New Parameter
            Dim olbeDespacho As New List(Of beDespacho)
            Dim intResultado As Integer = 1
            Dim objSql As New SqlManager
            'Try
            objParam.Add("PNCCLNT", pbeFiltro.PNCCLNT)
            objParam.Add("PNNGUIRN", pbeFiltro.PNNGUIRN)
            Return objSql.ExecuteDataSet("SP_SOLMIN_SA_SDS_LISTADO_RECEPCION_PARA_EXPORTAR", objParam)
            'Catch ex As Exception
            '    Return New DataSet
            'End Try

        End Function


        Public Function fListContratosVigentesxCliente(ByVal obeMercaderia As TypeDef.beMercaderia) As DataTable
            Dim objParam As New Parameter
            Dim dt As New DataTable
            Dim objSql As New SqlManager
            objParam.Add("PNCCLNT", obeMercaderia.PNCCLNT)
            objParam.Add("PSCTPDP3", obeMercaderia.PSCTPDP3)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_SA_SDS_LISTAR_CONTRATO_VIGENTES_X_CLIENTE", objParam)
            Return dt
        End Function

        Public Function fListOrdenServicioxSKU(ByVal obeMercaderia As TypeDef.beMercaderia) As DataTable
            Dim objParam As New Parameter
            Dim dt As New DataTable
            Dim objSql As New SqlManager
            objParam.Add("PNCCLNT", obeMercaderia.PNCCLNT)
            objParam.Add("PSCMRCLR", obeMercaderia.PSCMRCLR)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_SA_SDS_LISTAR_ORDEN_SERVICIO_X_SKU", objParam)
            Return dt
        End Function

        Public Function fListUnidadesMedidaOS() As DataSet
            Dim objParam As New Parameter
            Dim ds As New DataSet
            Dim objSql As New SqlManager
            ds = objSql.ExecuteDataSet("SP_SOLMIN_SA_SDS_LISTAR_TABLA_UNIDADES_MEDIDA_OS", Nothing)
            Return ds
        End Function

        Public Function fListValidarCrearOS_SKU(ByVal obeMercaderia As TypeDef.beMercaderia) As String
            Dim objParam As New Parameter
            Dim dt As New DataTable
            Dim objSql As New SqlManager
            Dim msg As String = ""
            objParam.Add("PNCCLNT", obeMercaderia.PNCCLNT)
            objParam.Add("PSCMRCLR", obeMercaderia.PSCMRCLR)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_SA_SDS_VALIDAR_CREACION_ORDEN_SERVICIO_SKU", objParam)
            For Each item As DataRow In dt.Rows
                If item("STATUS") = "E" Then
                    msg = msg & item("OBSRESULT") & Chr(10)
                End If
            Next
            Return msg
        End Function

        Public Function fListOrdenServicioSKU_Ubicacion(ByVal obeMercaderia As TypeDef.beMercaderia) As DataSet
            Dim objParam As New Parameter
            Dim ds As New DataSet
            Dim objSql As New SqlManager
            objParam.Add("PNCCLNT", obeMercaderia.PNCCLNT)
            objParam.Add("PSCMRCLR", obeMercaderia.PSCMRCLR)
            objParam.Add("PSCTPALM", obeMercaderia.PSCTPALM)
            objParam.Add("PSCALMC", obeMercaderia.PSCALMC)
            objParam.Add("PSCZNALM", obeMercaderia.PSCZNALM)
            'objParam.Add("PSCSECTR", obeMercaderia.PSCSECTR)
            objParam.Add("PSCPSCN", obeMercaderia.PSCPSCN)
            ds = objSql.ExecuteDataSet("SP_SOLMIN_SA_SDS_LISTAR_ORDEN_SERVICIO_SKU_UBICACION", objParam)
            Return ds
        End Function

#Region "Ubicación de mercadería"

        Public Function flistUbicacionesPorOSKardex(ByVal obeMercaderia As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
            Dim objParam As New Parameter
            Dim olbeDespacho As New List(Of beDespacho)
            Dim intResultado As Integer = 1
            Dim objSql As New SqlManager
            'Try
            objParam.Add("PNNORDSR", obeMercaderia.PNNORDSR)
            objParam.Add("PSCTPALM", obeMercaderia.PSCTPALM)
            objParam.Add("PSCALMC", obeMercaderia.PSCALMC)
            Return Listar("SP_SOLMIN_SA_MOVIMIENTO_UBICACION_X_KARDEX_LISTAR", objParam)
            'Catch ex As Exception
            '    Return Nothing
            'End Try
        End Function


        Public Function fintInsertarPosicionMercaderia(ByVal obeUbicacionMerca As beMercaderia) As Integer
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            With obeUbicacionMerca
                objParametros.Add("PSCTPALM", .PSCTPALM)
                objParametros.Add("PSCALMC", .PSCALMC)
                objParametros.Add("PSCSECTR", .PSCSECTR)
                objParametros.Add("PSCPSCN", .PSCPSCN)
                objParametros.Add("PNNORDSR", .PNNORDSR)
                objParametros.Add("PNNSLCSR", .PNNSLCSR)
                objParametros.Add("PNFTRNS", .PNFTRNS)
                objParametros.Add("PNQTRMC1", .PNQTRMC1)
                objParametros.Add("PNCSRVC", .PNCSRVC)
                objParametros.Add("PSUSUARIO", .PSUSUARIO)
                objParametros.Add("PSNTRMNL", .PSNTRMNL)
                objParametros.Add("PNNGUIRN", .PNNGUIRN)
            End With
            Try

                Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_POSICION_MERCADERIA_INSERT", objParametros)
                Return 1
            Catch ex As Exception
                Return -1
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return 1
        End Function


#End Region

#Region "Serie mercadería"

        Public Function flistSeriePorOS(ByVal obeMercaderia As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
            Dim objParam As New Parameter
            Dim olbeDespacho As New List(Of beDespacho)
            Dim intResultado As Integer = 1
            Dim objSql As New SqlManager
            'Try
            objParam.Add("PNNORDSR", obeMercaderia.PNNORDSR)
            Return Listar("SP_SOLMIN_SA_SDS_MERCADERIA_SERIE_LISTA", objParam)
            'Catch ex As Exception
            '    Return Nothing
            'End Try
        End Function


        Public Function fintInsertarSerieMercaderia(ByVal obeUbicacionMerca As beMercaderia) As Integer
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            With obeUbicacionMerca
                objParametros.Add("PNNORDSR", .PNNORDSR)
                objParametros.Add("PNNSLCSS", .PNNSLCSR)
                objParametros.Add("PSCSRECL", .PSCSRECL)
                objParametros.Add("PNNCRPLL", .PNNCRPLL)
                objParametros.Add("PNCCLNT", .PNCCLNT)
                objParametros.Add("PSTDSMDL", .PSTDSMDL)
                objParametros.Add("PNFINGAL", .PSFINGAL)
                objParametros.Add("PNHINGAL", .PNHINGAL)
                objParametros.Add("PNFSLDAL", .PSFSLDAL)
                objParametros.Add("PNHSLDAL", .PNHSLDAL)
                objParametros.Add("PSTOBSRV", .PSTOBSRV)
                objParametros.Add("PNNGUIRN", .PNNGUIRN)
                objParametros.Add("PNNGUIRM", .PNNGUIRM)
                objParametros.Add("PSSTPING", .PSSTPING)
                objParametros.Add("PSSSTINV", .PSSSTINV)
                objParametros.Add("PSUSUARIO", .PSUSUARIO)
            End With
            Try
                Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDS_MERCADERIA_SERIE_INSERT", objParametros)
                Return 1
            Catch ex As Exception
                Return -1
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return 1
        End Function
#End Region

#End Region

#End Region

        Public Overrides Sub SetStoredprocedures()

        End Sub

        Public Overrides Sub ToParameters(ByVal obj As TYPEDEF.beMercaderia)

        End Sub
    End Class
End Namespace