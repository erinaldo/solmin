Public Class TipoDato_BLL
    Public Function ListarAlmacenLocaL(ByVal obeAlmacen As TipoDato_Info_BE) As List(Of TipoDato_BE)
        Dim odaAlmacenLocal As New TipoDato_DAL
        Dim oListAlmacenLocal As New List(Of TipoDato_BE)
        oListAlmacenLocal = odaAlmacenLocal.ListarAlmacenLocaL(obeAlmacen)
        Return oListAlmacenLocal
    End Function
End Class
