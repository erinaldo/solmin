Imports RANSA.DATA
Imports RANSA.TYPEDEF
Public Class blTomaInvertario

    Public Function ProcesarTomaInvertario(ByVal CCLNT As String) As DataTable
        Return New daTomaInvertario().ProcesarTomaInvertario(CCLNT)
    End Function
    Public Function InicializarInvertario(ByVal CCLNT As String)
        Return New daTomaInvertario().InicializarInvertario(CCLNT)
    End Function
End Class
