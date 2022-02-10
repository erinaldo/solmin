
Public Class clsPartidaArancelaria
    Private oPartida As Datos.clsPartidaArancelaria

    Sub New()
        oPartida = New Datos.clsPartidaArancelaria
    End Sub

    Public Function Lista_Partidas() As DataTable
        Return oPartida.Lista_Partidas()
    End Function

    Public Function Lista_Partidas_Item(ByVal pdblCliente As Double, ByVal pstrSKU As String) As DataTable
        Return oPartida.Lista_Partidas_Item(pdblCliente, pstrSKU)
    End Function

    Public Function Lista_Partidas_Arancelarias(ByVal obePartidas As Entidad.bePartidaArancelaria) As DataTable
        Return oPartida.Lista_Partidas_Arancelarias(obePartidas)
    End Function

    Public Sub Guardar_Partidas_Arancelarias(ByVal obePartidas As Entidad.bePartidaArancelaria)
        oPartida.Guardar_Partidas_Arancelarias(obePartidas)
    End Sub
    Public Sub Elimina_Partidas_Arancelarias(ByVal obePartidas As Entidad.bePartidaArancelaria)
        oPartida.Elimina_Partidas_Arancelarias(obePartidas)
    End Sub
End Class
