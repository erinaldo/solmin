Public Class GR_JSON_RPTA_PACASMAYO

    Private _resultado As Integer = 0
    Public Property resultado() As Integer
        Get
            Return _resultado
        End Get
        Set(ByVal value As Integer)
            _resultado = value
        End Set
    End Property

    Private _mensaje_error As String = ""
    Public Property mensaje_error() As String
        Get
            Return _mensaje_error
        End Get
        Set(ByVal value As String)
            _mensaje_error = value
        End Set
    End Property

End Class
