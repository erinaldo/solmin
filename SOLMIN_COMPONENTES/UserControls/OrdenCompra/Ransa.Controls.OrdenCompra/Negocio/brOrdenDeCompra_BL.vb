Imports Ransa.TypeDef
Public Class brOrdenDeCompra_BL
    Private oDatos As New brOrdenDeCompra_DAL
    Public Function InsertarOrdenDeCompra(ByVal obeOrdenDeCompra As beOrdenCompra) As Integer
        Return oDatos.InsertarOrdenDeCompra(obeOrdenDeCompra)
    End Function

    Public Function InsertarDetalleOrdenDeCompra(ByVal obeOrdenDeCompra As beOrdenCompra) As Integer
        Return oDatos.InsertarDetalleOrdenDeCompra(obeOrdenDeCompra)
    End Function

    Public Function ActualizarDetalleOrdenDeCompra(ByVal obeOrdenDeCompra As beOrdenCompra) As Integer
        Return oDatos.ActualizarDetalleOrdenDeCompra(obeOrdenDeCompra)
    End Function

    Public Function ListarDetalleOrdenDeCompra(ByVal obeOrdenDeCompra As beOrdenCompra) As List(Of beOrdenCompra)
        Return oDatos.ListarDetalleOrdenDeCompra(obeOrdenDeCompra)
    End Function

    Public Function InsertarObservacionOrdenDeCompra(ByVal obeOrdenDeCompra As beOrdenCompra) As Integer
        Return oDatos.InsertarObservacionOrdenDeCompra(obeOrdenDeCompra)
    End Function

    'Public Function ListarObservacionOrdenDeCompra(ByVal obeOrdenDeCompra As beOrdenCompra) As List(Of beOrdenCompra)
    '    Return oDatos.ListarObservacionOrdenDeCompra(obeOrdenDeCompra)
    'End Function
    Public Function EliminarObservacionOrdenDeCompra(ByVal obeOrdenCompra As beOrdenCompra) As Integer
        Return oDatos.EliminarObservacionOrdenDeCompra(obeOrdenCompra)
    End Function

    'Public Function ListarDetalleOrdenDeCompraPendientes(ByVal obeOrdenCompra As beOrdenCompra) As List(Of beOrdenCompra)
    '    Return oDatos.ListarDetalleOrdenDeCompraPendientes(obeOrdenCompra)
    'End Function


End Class
