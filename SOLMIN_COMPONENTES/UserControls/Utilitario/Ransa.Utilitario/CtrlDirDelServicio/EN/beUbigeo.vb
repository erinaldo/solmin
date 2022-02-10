Public Class beUbigeo

    Private _codigo As String
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    Private _ubigeo As String
    Public Property Ubigeo() As String
        Get
            Return _ubigeo
        End Get
        Set(ByVal value As String)
            _ubigeo = value
        End Set
    End Property

End Class

