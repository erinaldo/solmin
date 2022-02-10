Public Class beLocalidad
    Private _CLCLD As Integer
    Private _TCMLCL As String


    Public Property TCMLCL() As String
        Get
            Return _TCMLCL
        End Get
        Set(ByVal value As String)
            _TCMLCL = value
        End Set
    End Property


    Public Property CLCLD() As Integer
        Get
            Return _CLCLD
        End Get
        Set(ByVal value As Integer)
            _CLCLD = value
        End Set
    End Property

End Class
