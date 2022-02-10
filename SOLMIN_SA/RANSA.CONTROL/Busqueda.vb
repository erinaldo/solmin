Public Class Buscar(Of T)

    Private _pstrBuscar As String
    Public Property pstrBuscar() As String
        Get
            Return _pstrBuscar
        End Get
        Set(ByVal value As String)
            _pstrBuscar = value
        End Set
    End Property

    Private _DataValue As String
    Public Property DataValue() As String
        Get
            Return _DataValue
        End Get
        Set(ByVal value As String)
            _DataValue = value
        End Set
    End Property

    Public MatchBuscar As New Predicate(Of T)(AddressOf Buscar)

    Public Function Buscar(ByVal Y As T) As Boolean
        If (Y.GetType.GetProperty(_DataValue).GetValue(Y, Nothing).ToString.IndexOf(_pstrBuscar.Trim) <> -1) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class


