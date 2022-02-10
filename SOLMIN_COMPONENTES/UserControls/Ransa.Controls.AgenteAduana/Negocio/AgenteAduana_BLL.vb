Public Class AgenteAduana_BLL
  Public Function ListarAgenteAduana(ByVal obeTransportista As AgenteAduana_Info_BE) As List(Of AgenteAduana_BE)
    Dim odaAgenteAduana As New AgenteAduana_DAL
    Dim oListAgenteAduana As New List(Of AgenteAduana_BE)
    oListAgenteAduana = odaAgenteAduana.ListarAgenteAduana(obeTransportista)
    Return oListAgenteAduana
  End Function
End Class

