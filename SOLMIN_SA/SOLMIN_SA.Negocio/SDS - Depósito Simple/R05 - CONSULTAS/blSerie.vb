Imports RANSA.DATA
Imports RANSA.TypeDef

Public Class blSerie
    Dim oDatos As New daSerie

    Public Function ListarSerie(ByVal obeSerie As beSeries) As List(Of beSeries)
        Return oDatos.ListarSerie(obeSerie)
    End Function
End Class
