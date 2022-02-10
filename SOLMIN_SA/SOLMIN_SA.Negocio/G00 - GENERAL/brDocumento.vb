Imports RANSA.TYPEDEF
Imports RANSA.DATA

Public Class brDocumento
    Dim oDatos As New daDocumento
    Public Function DocumentoAlmacenInsertar(ByVal obeDocumento As BeDocumento) As Integer
        Return oDatos.DocumentoAlmacenInsertar(obeDocumento)
    End Function
    Public Function DocumentoAlmacenActualizar(ByVal obeDocumento As BeDocumento) As Integer
        Return oDatos.DocumentoAlmacenActualizar(obeDocumento)
    End Function
    Public Function DocumentoAlmacenListar(ByVal obeDocumento As BeDocumento) As List(Of BeDocumento)
        Return oDatos.DocumentoAlmacenListar(obeDocumento)

    End Function
    Public Function ObtenerCorrelativo(ByVal obeDocumento As BeDocumento) As Integer
        Return oDatos.ObtenerCorrelativo(obeDocumento)
    End Function


End Class