Public Class brLote_BL
    Public Function ListaDeLotesPorOC(ByVal obeLote As Ransa.TYPEDEF.beLote) As DataTable
        Dim objDALote As New brLote_DAL
        Return objDALote.ListaDeLotesPorOC(obeLote)

    End Function

    Public Function RegistrarDespachoLote(ByVal lista As List(Of Ransa.TYPEDEF.beLote)) As Boolean
        Dim objDALote As New brLote_DAL
        Return objDALote.RegistrarDespachoLote(lista)
    End Function

End Class
