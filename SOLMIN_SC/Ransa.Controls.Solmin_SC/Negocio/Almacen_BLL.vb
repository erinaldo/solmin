Public Class Almacen_BLL
    Public Function ListarAlmacen(ByVal obeAlmacen As Almacen_Info_BE) As List(Of Almacen_BE)
        Dim odaAlmacen As New Almacen_DAL
        Dim oListAlmacen As New List(Of Almacen_BE)
        oListAlmacen = odaAlmacen.ListarAlmacen(obeAlmacen)
        Return oListAlmacen
    End Function
End Class
