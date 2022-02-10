Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF
Public Class daPedido
    Private objSql As New SqlManager

    Public Function ObtenerPedidoXReferenciaPedido(ByVal objParametro As Hashtable) As DataSet
        Dim oDs As New DataSet
        Dim objParam As New Parameter
        Try
            objParam.Add("PSNRFTPD", objParametro("PSNRFTPD"))
            objParam.Add("PSNRFRPD", objParametro("PSNRFRPD"))
            oDs = objSql.ExecuteDataSet("SP_SOLMIN_SA_OBTENER_PEDIDO_X_REFERENCIA_PEDIDO", objParam)
        Catch ex As Exception
            oDs = Nothing
        End Try
        Return oDs
    End Function

    Public Function ObtenerOrdeDeServicioXMercaderia(ByVal objParametro As Hashtable) As DataSet
        Dim oDs As New DataSet
        Dim objParam As New Parameter
        'Try
        objParam.Add("IN_CCLNT2", objParametro("PNCCLNT2"))
        objParam.Add("IN_CMRCLR", objParametro("PSCMRCLR"))
        oDs = objSql.ExecuteDataSet("SP_SOLMIN_SA_OBTENER_ORDEN_SERVICIO_X_MERCADERIA_RELACIONADA", objParam)
        'Catch ex As Exception
        '    oDs = Nothing
        'End Try
        Return oDs
    End Function

    Public Function ListarOrdenServicio_X_SKU_ValidaPedido(ByVal objParametro As Hashtable) As DataTable
        Dim oDt As New DataTable
        Dim objParam As New Parameter
        'Try
        objParam.Add("IN_CCLNT2", objParametro("PNCCLNT2"))
        objParam.Add("IN_CMRCLR", objParametro("PSCMRCLR"))
        oDt = objSql.ExecuteDataTable("SP_SOLMIN_SA_LISTA_OS_VALIDACON_PEDIDO", objParam)
        'Catch ex As Exception
        '    oDs = Nothing
        'End Try
        Return oDt
    End Function


    Public Function ReporteGuiaDeRemisionXPedido(ByVal objParametro As Hashtable) As DataSet
        Dim odt As New DataSet()
        Try
            Dim lobjParams As New Parameter
            lobjParams.Add("PNCDPEPL", objParametro("PNCDPEPL"))
            Return objSql.ExecuteDataSet("SP_SOLMIN_SA_SDS_REPORTE_GUIA_DE_REMISION_X_PEDIDO", lobjParams)
        Catch ex As Exception
        End Try
        Return odt
    End Function

End Class
