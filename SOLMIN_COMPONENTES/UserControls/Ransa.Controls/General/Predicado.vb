Public Class Predicado(Of T)
    Private Criterio As String
    Private Dato As String
    Public Predicado As Predicate(Of T)

    Public Sub New(ByVal mCriterio As String, ByVal mDato As Object)
        Criterio = mCriterio
        Dato = mDato
        Predicado = AddressOf Filtrar
    End Sub

    Public Function Filtrar(ByVal oBE As T) As Boolean
        Dim oVal As Object = oBE.GetType.GetProperty(Criterio).GetValue(oBE, Nothing).ToString.Trim.ToUpper
        Return (oVal Like Dato & "*")
    End Function
End Class
