Imports RANSA.DATA
Imports RANSA.TypeDef

Public Class blPoliza
    Dim oDatos As New daPoliza

    Public Function ListarPoliza(ByVal obePoliza As bePoliza) As List(Of bePoliza)
        Return oDatos.ListarPoliza(obePoliza)
    End Function
End Class