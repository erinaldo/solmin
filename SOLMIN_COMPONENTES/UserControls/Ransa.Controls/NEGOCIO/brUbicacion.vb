'Imports Ransa.NEGO


Public Class brUbicacion

    Inherits brBase(Of beUbicacion, daUbicacion)

    'CSR-HUNDRED
    Public Function ListarDespachos(ByVal nOrdenServicio As Int32, ByVal sTipoAlmacen As String, ByVal sAlmacen As String, ByVal sZona As String, ByVal nPedido As Int32, ByVal nLote As Int32) As List(Of beUbicacion)
        Return TryCast(oData, daUbicacion).ListarDespachos(nOrdenServicio, sTipoAlmacen, sAlmacen, sZona, nPedido, nLote)
    End Function


    Public Sub RegistrarInventario_X_Ubicacion(ByVal obj As beUbicacion)
        Dim odaUbicacion As New daUbicacion
        odaUbicacion.RegistrarInventario_X_Ubicacion(obj)
    End Sub

End Class
