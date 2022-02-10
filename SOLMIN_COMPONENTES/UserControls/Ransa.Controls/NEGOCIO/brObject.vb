'Imports Ransa.DATA
'Imports Ransa.NEGO
Imports Ransa.Utilitario
Imports Ransa.TYPEDEF

Public Class brObject
    Inherits brBase(Of beObject, daObject)

    Public Function TraerConsultaPaginada(ByVal tabla As String, ByVal campos As String, ByVal where As String, ByVal ucp As UCPaginacion) As DataTable
        Dim dt As New DataTable

        dt = oData.TraerDataTable("GET_TABLA_PAGINADA", tabla, campos, where, ucp)
        Return dt
    End Function

End Class

Public Class daObject
    Inherits daBase(Of beObject)

    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As beObject)

    End Sub
End Class

Public Class beObject
    Inherits beBase(Of beObject)

End Class
