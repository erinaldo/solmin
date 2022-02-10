Public Class Busqueda(Of T)

    Private Criterio1 As String
    Private Dato1 As String
    Public Predicado As Predicate(Of T)

    Public Sub New(ByVal mCriterio1 As String, ByVal mDato1 As Object)
        Criterio1 = mCriterio1
        Dato1 = mDato1
        Predicado = AddressOf Filtrar
    End Sub

    Public Function Filtrar(ByVal oBE As T) As Boolean
        If oBE.GetType.GetProperty(Criterio1).GetValue(oBE, Nothing).ToString.Trim.ToUpper = Dato1.Trim.ToUpper Then
            Return True
        Else
            Return False
        End If
    End Function


End Class
