Public Class Transportista_BLL
    Public Function ListarTransportista(ByVal obeTransportista As Transportista_Info_BE) As List(Of Transportista_BE)
        Dim odaTransportista As New Transportista_DAL
        Dim oListTransportista As New List(Of Transportista_BE)
        oListTransportista = odaTransportista.ListarTransportista(obeTransportista)
        Return oListTransportista
    End Function
End Class
