Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF
Public Class daInventarioMercaderia
    Inherits daBase(Of beMercaderia)

    Public Function ListarInventarioMercaderiaxSerie(ByVal obeMercaderia As beMercaderia) As DataSet
        Dim oDs As New DataSet
        Dim objParam As New Parameter
        Dim objSql As New SqlManager
        'Try
        objParam.Add("IN_NORDSR", obeMercaderia.PNNORDSR)
        oDs = objSql.ExecuteDataSet("SP_SOLMIN_SA_INVENTARIO_SERIE_CLIENTE", objParam)
        'Catch ex As Exception
        '    oDs = Nothing
        'End Try
        Return oDs
    End Function

    Public Function ListarMercaderiaxClientexGrupoxFamilia(ByVal obeMercaderia As beMercaderia) As List(Of beMercaderia)

        Dim objParam As New Parameter
        Dim objSql As New SqlManager
        'Try
        objParam.Add("IN_CCLNT", obeMercaderia.PNCCLNT)
        objParam.Add("IN_CGRCLR", obeMercaderia.PSCGRCLR)
        objParam.Add("IN_CFMCLR", obeMercaderia.PSCFMCLR)
        objParam.Add("IN_TMRCD2", obeMercaderia.PSTMRCD2)
        objParam.Add("IN_CMRCLR", obeMercaderia.PSCMRCLR)
        objParam.Add("PAGESIZE", obeMercaderia.PageSize)
        objParam.Add("PAGENUMBER", obeMercaderia.PageNumber)
        objParam.Add("PAGECOUNT", 0, ParameterDirection.Output)
        Return Listar("SP_SOLMIN_SA_LISTAR_MERCADERIA_CLIENTE_GRUPO_FAMILIA_V2", objParam)
        'Catch ex As Exception
        '    Return Nothing
        'End Try
        'Return Nothing
    End Function

    Public Function ListarInventarioMercaderiaxUbicacion(ByVal obeMercaderia As beMercaderia) As DataSet
        Dim oDs As New DataSet
        Dim objParam As New Parameter
        Dim objSql As New SqlManager
        'Try
        objParam.Add("IN_NORDSR", obeMercaderia.PNNORDSR)
        oDs = objSql.ExecuteDataSet("SP_SOLMIN_SA_INVENTARIO_UBICACION_CLIENTE", objParam)
        'Catch ex As Exception
        '    oDs = Nothing
        'End Try
        Return oDs
    End Function
    Public Function Lista_Orden_Servicio_por_Cliente(ByVal obeMercaderia As beMercaderia) As List(Of beMercaderia)
        Dim oDs As New DataSet
        Dim objParam As New Parameter
        Dim objSql As New SqlManager
        'Try
        objParam.Add("IN_CCLNT", obeMercaderia.PNCCLNT)
        objParam.Add("IN_CMRCLR", obeMercaderia.PSCMRCLR)
        Return Listar("SP_SOLMIN_SA_LISTA_ORDEN_SERVICIO_POR_CLIENTE_V1", objParam)
        'Catch ex As Exception
        '    Return New List(Of beMercaderia)
        'End Try
    End Function

    Public Function Lista_Solicitud_Servicio_por_Cliente(ByVal obeMercaderia As beMercaderia) As List(Of beMercaderia)
        Dim objParam As New Parameter
        Dim objSql As New SqlManager
        'Try
        objParam.Add("PNNORDSR", obeMercaderia.PNNORDSR)
        objParam.Add("PAGESIZE", obeMercaderia.PageSize)
        objParam.Add("PAGENUMBER", obeMercaderia.PageNumber)
        objParam.Add("PAGECOUNT", 0, ParameterDirection.Output)
        Return Listar("SP_SA_SDS_SOLMIN_LISTA_SOLICITUD_SERVICIO", objParam)
        'Catch ex As Exception
        '    Return New List(Of beMercaderia)
        'End Try
    End Function


    Public Function Lista_Solicitud_Servicio_por_Lote(ByVal obeMercaderia As beMercaderia) As List(Of beMercaderia)
        Dim objParam As New Parameter
        Dim objSql As New SqlManager
        'Try
        objParam.Add("PNNORDSR", obeMercaderia.PNNORDSR)
        objParam.Add("PNNCRRIN", obeMercaderia.PNNCRRIN)
        '
        Return Listar("SP_SA_SDS_SOLMIN_LISTA_SOLICITUD_SERVICIO_LOTE", objParam)
        'Catch ex As Exception
        '    Return New List(Of beMercaderia)
        'End Try
    End Function

    Public Function Lista_Solicitud_Servicio_Pendiente_por_Lote(ByVal obeMercaderia As beMercaderia) As List(Of beMercaderia)
        Dim objParam As New Parameter
        Dim objSql As New SqlManager
        'Try
        objParam.Add("PNNORDSR", obeMercaderia.PNNORDSR)
        '
        Return Listar("SP_SA_SDS_SOLMIN_LISTA_SOLICITUD_SERVICIO_PENDIENTE_LOTE", objParam)
        'Catch ex As Exception
        '    Return New List(Of beMercaderia)
        'End Try
    End Function


    Public Function Lista_Movimiento_por_Posicion(ByVal obeAlmacen As beAlmacen) As DataSet
        Dim oDs As New DataSet
        Dim objParam As New Parameter
        Dim objSql As New SqlManager
        'Try
        objParam.Add("IN_CTPALM", obeAlmacen.PSCTPALM)
        objParam.Add("IN_CALMC", obeAlmacen.PSCALMC)
        objParam.Add("IN_CSECTR", obeAlmacen.PSCSECTR)
        objParam.Add("IN_CPSCN", obeAlmacen.PSCPSCN)
        objParam.Add("IN_NORDSR", obeAlmacen.PNNORDSR)
        oDs = objSql.ExecuteDataSet("SP_SOLMIN_SA_LISTA_MOVIMIENTOS_X_POSICION", objParam)
        'Catch ex As Exception
        '    oDs = Nothing
        'End Try
        Return oDs
    End Function

    Public Function Lista_Inventario_por_Posicion(ByVal obeAlmacen As beAlmacen) As DataSet
        Dim oDs As New DataSet
        Dim objParam As New Parameter
        Dim objSql As New SqlManager

        'Try

        objParam.Add("PNCCLNT", obeAlmacen.PNNCLNT)
        objParam.Add("PSCTPALM", obeAlmacen.PSCTPALM)
        objParam.Add("PSCALMC", obeAlmacen.PSCALMC)
        objParam.Add("PSCZNALM", obeAlmacen.PSCZNALM)
        objParam.Add("PNORDENACION", obeAlmacen.PNORDENACION)
        'oDs = objSql.ExecuteDataSet("SP_SOLMIN_SA_SDS_INVENTARIO_X_POSICION", objParam)
        oDs = objSql.ExecuteDataSet("SP_SOLMIN_SA_SDS_INVENTARIO_X_POSICION_X_ZONA", objParam)

        'Catch ex As Exception
        '    oDs = Nothing
        'End Try

        Return oDs
    End Function

    Public Function Lista_Solicitud_Servicio_por_Cliente_Exportar(ByVal obeMercaderia As beMercaderia) As List(Of beMercaderia)
        Dim objParam As New Parameter
        Dim objSql As New SqlManager
        'Try
        objParam.Add("PNNORDSR", obeMercaderia.PNNORDSR)
        Return Listar("SP_SA_SDS_SOLMIN_LISTA_SOLICITUD_SERVICIO_EXPORTAR", objParam)
        'Catch ex As Exception
        '    Return New List(Of beMercaderia)
        'End Try
    End Function

    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As TYPEDEF.beMercaderia)

    End Sub
End Class
