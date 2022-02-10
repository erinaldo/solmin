Imports RANSA.DATA
Imports RANSA.TypeDef
Public Class blOrdenCompra
    Public Function ListaPendienteRecepcionOrdenCompra(ByVal obeOrdenCompra As beOrdenCompra) As DataSet
        Return New daOrdenCompra().ListaPendienteRecepcionOrdenCompra(obeOrdenCompra)
    End Function

End Class
