Imports RANSA.DATA
Imports RANSA.TYPEDEF

Public Class brPosicion
    Dim oDatos As New daPosicion

    Public Function ListarPosicionPorSector(ByVal opbePosicion As bePosicion) As List(Of bePosicion)
        Return oDatos.ListarPosicionPorSector(opbePosicion)
    End Function

End Class