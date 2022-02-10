Public Class beEstadoEmb
    Private _COD As String = ""
    Private _TEX As String = ""
    Public Property COD() As String
        Get
            Return _COD
        End Get
        Set(ByVal value As String)
            _COD = value
        End Set
    End Property

    Public Property TEX() As String
        Get
            Return _TEX
        End Get
        Set(ByVal value As String)
            _TEX = value
        End Set
    End Property
End Class
