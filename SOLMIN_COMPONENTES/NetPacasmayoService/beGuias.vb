Public Class beGuias
    Private _NGUIRM As String = ""
    Private _NGUIRS As String = ""

    Public Property NGUIRM() As String
        Get
            Return _NGUIRM
        End Get
        Set(ByVal value As String)
            _NGUIRM = value
        End Set
    End Property

    Public Property NGUIRS() As String
        Get
            Return _NGUIRS
        End Get
        Set(ByVal value As String)
            _NGUIRS = value
        End Set
    End Property

End Class
