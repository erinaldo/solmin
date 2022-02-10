Imports CrystalDecisions.CrystalReports.Engine
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF.Mercaderia
Imports RANSA.TYPEDEF
Imports RANSA.Rpt.Mercaderia
Imports RANSA.DATA.slnSOLMIN_SDS.DAO.Mercaderia
Imports RANSA.Utilitario
Imports System.Drawing


Public Class ReporteSDS
#Region " Tipos de Datos "

#End Region
#Region " Atributos "
    Private strUsuarioSistema As String = ""
#End Region
#Region " Propiedades "

#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Métodos "
    Sub New(ByVal UsuarioSistema As String)
        strUsuarioSistema = UsuarioSistema
    End Sub


    Public Function frptStockProductosPorUbicacionR01(ByVal Filtro As TD_Qry_StockProductosPorUbicacionF01, ByRef strMensajeError As String) As DataTable
        Dim objSqlManager As SqlManager = New SqlManager

        Dim dtTemp As DataTable = Nothing

        dtTemp = daoMercaderia.fdtListar_StockProductosPorUbicacion_R01(objSqlManager, Filtro, strMensajeError)
        Return dtTemp

    End Function

    Public Function frptStockProductosPorUbicacionR02(ByVal Filtro As TD_Qry_StockProductosPorUbicacionF01, ByRef strMensajeError As String) As DataTable
        Dim objSqlManager As SqlManager = New SqlManager
        Dim dtTemp As DataTable = Nothing
        dtTemp = daoMercaderia.fdtListar_StockProductosPorUbicacion_R01(objSqlManager, Filtro, strMensajeError)
        Return dtTemp
    End Function

    Public Function frptMovimientoProductosR01(ByVal Filtro As TD_FiltroRepMovProductos, ByRef strMensajeError As String) As DataTable
        Dim objSqlManager As SqlManager = New SqlManager

        Dim dtTemp As DataTable = Nothing

        dtTemp = daoMercaderia.fdtListar_MovimientoProductos_R01(objSqlManager, Filtro, strMensajeError)
        Return dtTemp

    End Function

    Public Function frptMovimientoProductosR02(ByVal Filtro As TD_FiltroRepMovProductos, ByRef strMensajeError As String) As DataTable
        Dim objSqlManager As SqlManager = New SqlManager
        Dim dtTemp As DataTable = Nothing
        dtTemp = daoMercaderia.fdtListar_MovimientoProductos_R02(objSqlManager, Filtro, strMensajeError)
        Return dtTemp
    End Function

    Public Function frptMovimientoProductosR03(ByVal Filtro As TD_FiltroRepMovProductos, ByRef strMensajeError As String) As DataTable
        Dim objSqlManager As SqlManager = New SqlManager

        Dim dtTemp As DataTable = Nothing

        dtTemp = daoMercaderia.fdtListar_MovimientoProductos_R01(objSqlManager, Filtro, strMensajeError)

        Return dtTemp
    End Function

    Public Function frptMovimientoProductosValorizadoR03(ByVal Filtro As TD_FiltroRepMovProductos, ByRef strMensajeError As String) As DataTable
        Dim objSqlManager As SqlManager = New SqlManager
        Dim dt As New DataTable

        dt = daoMercaderia.frptListar_MovMercaderias_R03(objSqlManager, Filtro, strMensajeError)

        Return dt
    End Function

    Public Function frptListar_Inventario_x_Posicion(ByVal Filtro As TD_Qry_StockProductosPorUbicacionF01, ByRef strMensajeError As String) As DataSet

        Dim objSqlManager As SqlManager = New SqlManager
        Dim ds As New DataSet
        ds = daoMercaderia.frptListar_Inventario_x_Posicion(objSqlManager, Filtro, strMensajeError)

        Return ds
    End Function
    Private Sub MaxDiasAbrevMes(ByVal Anio As Int32, ByVal Mes As Int32, ByRef MaxDiaMes As Int32, ByRef AbrevMes As String)
        Dim odtMeses As New DataTable()
        Dim keymes As String = ""
        Dim filtro As String = ""
        odtMeses = HelpClass.Meses(Anio)
        keymes = Mes.ToString
        If (keymes.Length <= 1) Then
            keymes = "0" & keymes
        End If
        filtro = "key='" & keymes & "'"
        MaxDiaMes = odtMeses.Select(filtro)(0).Item("max")
        AbrevMes = odtMeses.Select(filtro)(0).Item("value2").ToString.Trim
    End Sub
    Private Function FormatoNombreColumna(ByVal numeroDia As Int32) As String
        Dim retorno As String = "DIA"
        Dim strDia As String = ""
        strDia = numeroDia.ToString.Trim
        If (strDia.Length <= 1) Then
            strDia = "0" & strDia
        End If
        retorno = retorno & strDia
        Return retorno
    End Function

    Public Function frptListar_Resumen_Indicador_Mensual(ByVal Filtro As beMercaderia, ByRef strMensajeError As String, ByRef MaxDiaMes As Int32, ByRef AbrevMes As String) As DataSet

        Dim objSqlManager As SqlManager = New SqlManager
        Dim ds As New DataSet

        MaxDiasAbrevMes(Filtro.PNANIOEMI, Filtro.PNMESEMI, MaxDiaMes, AbrevMes)
        Filtro.PNMAXDIAS = MaxDiaMes
        ds = daoMercaderia.frptListar_Resumen_Indicador_Mensual(objSqlManager, Filtro, strMensajeError)



        Return ds
    End Function

    Public Function frptListar_Resumen_Indicador_Anual(ByVal Filtro As beMercaderia, ByRef strMensajeError As String) As DataTable

        Dim objSqlManager As SqlManager = New SqlManager

        Dim DtReporte As New DataTable

        DtReporte = daoMercaderia.frptListar_Resumen_Anual(objSqlManager, Filtro, strMensajeError)

        Return DtReporte
    End Function




    Public Function frptListar_MovMercaderias_x_CentroCosto(ByVal Filtro As TD_FiltroRepMovProductos, ByRef strMensajeError As String) As DataSet

        Dim objSqlManager As SqlManager = New SqlManager
        Dim ds As New DataSet
        ds = daoMercaderia.frptListar_MovMercaderias_x_CentroCosto(objSqlManager, Filtro, strMensajeError)
        Return ds



    End Function

    Public Function frptListar_MovMercaderias_x_LugarEntrega(ByVal Filtro As TD_FiltroRepMovProductos, ByRef strMensajeError As String) As DataSet

        Dim objSqlManager As SqlManager = New SqlManager
        Dim ds As New DataSet
        ds = daoMercaderia.frptListar_MovMercaderias_x_LugarEntrega(objSqlManager, Filtro, strMensajeError)

        Return ds
    End Function



    Public Function frptMovimientoProductosPorUbicacionR01(ByVal Filtro As TD_FiltroRepMovProductosPorUbicacion, ByRef strMensajeError As String) As DataTable
        Dim objSqlManager As SqlManager = New SqlManager
        Dim dtTemp As DataTable = Nothing
        dtTemp = daoMercaderia.fdtListar_MovimientoProductosPorUbicacion_R01(objSqlManager, Filtro, strMensajeError)
        Return dtTemp
    End Function

    Public Function frptMovimientoProductosPorUbicacionR02(ByVal Filtro As TD_FiltroRepMovProductosPorUbicacion, ByRef strMensajeError As String) As TipoDato_ResultaReporte
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objTemp As TipoDato_ResultaReporte = New TipoDato_ResultaReporte
        Dim dtTemp As DataTable = Nothing
        Dim rptTemp As ReportDocument
        dtTemp = daoMercaderia.fdtListar_MovimientoProductosPorUbicacion_R01(objSqlManager, Filtro, strMensajeError)

        If dtTemp.Rows.Count > 0 Then
            rptTemp = New MovProductosPorUbicacionR02
            dtTemp.TableName = "MovProductosPorUbicacionR02"
            rptTemp.SetDataSource(dtTemp)
            rptTemp.Refresh()
            ' Ingresamos parametros adicionales
            rptTemp.SetParameterValue("pUsuario", strUsuarioSistema)
            rptTemp.SetParameterValue("pCliente", Filtro.pCCLNT_CodigoCliente)
            rptTemp.SetParameterValue("pRazonSocial", Filtro.pTCMPCL_RazonSocial)
            rptTemp.SetParameterValue("pFechaInicial", Filtro.pFMOVI_FechaInventarioDte)
            rptTemp.SetParameterValue("pFechaFinal", Filtro.pFMOVF_FechaInventarioDte)
            ' Generamos el Nuevo Tipo de Datos
            objTemp.add_Table(dtTemp)
            objTemp.pReporte = rptTemp
        End If
        Return objTemp
    End Function

    'Public Function frptConsultaPedidoDeposito(ByVal Filtro As TD_FiltroRepPedDeposito) As DataTable
    '    Dim objSqlManager As SqlManager = New SqlManager
    '    Dim dtTemp As DataTable = Nothing
    '    dtTemp = daoMercaderia.fdtListar_PedidoDeposito(Filtro)
    '    Return dtTemp
    'End Function
#End Region
End Class
