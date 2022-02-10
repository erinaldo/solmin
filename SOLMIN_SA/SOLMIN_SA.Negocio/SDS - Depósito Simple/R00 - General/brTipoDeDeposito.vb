Imports RANSA.DATA
Imports RANSA.TypeDef

Public Class brTipoDeDeposito
    Dim oDatos As New daTipoDeDeposito
    Public Function ListarTipoDeDeposito() As List(Of beTipoDeDeposito)
        Return oDatos.ListarTipoDeDeposito()
    End Function

End Class