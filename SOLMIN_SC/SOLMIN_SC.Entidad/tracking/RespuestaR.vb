Public Class RespuestaR
    Private _message As String
    Private _resultado As String
    Private _error_code As String
    Private _error_message As String

    Public Property message() As String
        Get
            Return (_message)
        End Get
        Set(ByVal value As String)
            _message = value
        End Set
    End Property


    Public Property resultado() As String
        Get
            Return (_resultado)
        End Get
        Set(ByVal value As String)
            _resultado = value
        End Set
    End Property
    Public Property error_code() As String
        Get
            Return (_error_code)
        End Get
        Set(ByVal value As String)
            _error_code = value
        End Set
    End Property

    Public Property error_message() As String
        Get
            Return (_error_message)
        End Get
        Set(ByVal value As String)
            _error_message = value
        End Set
    End Property








End Class
