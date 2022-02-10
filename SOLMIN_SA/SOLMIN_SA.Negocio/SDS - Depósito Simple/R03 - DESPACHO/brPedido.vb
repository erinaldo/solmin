Imports RANSA.DATA
Public Class brPedido
    Public Function ObtenerPedidoXReferenciaPedido(ByVal objParametro As Hashtable) As DataSet
        Return New daPedido().ObtenerPedidoXReferenciaPedido(objParametro)
    End Function
    Public Function ObtenerOrdeDeServicioXMercaderia(ByVal objParametro As Hashtable) As DataSet
        Return New daPedido().ObtenerOrdeDeServicioXMercaderia(objParametro)
    End Function

    Public Function ListarOrdenServicio_X_SKU_ValidaPedido(ByVal objParametro As Hashtable) As DataTable
        Return New daPedido().ListarOrdenServicio_X_SKU_ValidaPedido(objParametro)
    End Function
    Public Function ReporteGuiaDeRemisionXPedido(ByVal objParametro As Hashtable) As DataSet
        Return New daPedido().ReporteGuiaDeRemisionXPedido(objParametro)
    End Function

End Class
