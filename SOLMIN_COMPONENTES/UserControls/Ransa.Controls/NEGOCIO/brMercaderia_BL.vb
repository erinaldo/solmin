Public Class brMercaderia_BL
    Public Function ListaMarca(ByVal obeMercaderia As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
        Dim odaMercaderia As New brMercaderia_DAL
        Return odaMercaderia.ListaMarca(obeMercaderia)
    End Function
End Class
