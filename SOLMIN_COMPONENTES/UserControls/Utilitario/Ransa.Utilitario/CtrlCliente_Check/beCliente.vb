Public Class beCliente

    Private _Codigo As String
    Public Property Codigo() As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
        End Set
    End Property

    Private _Descripcion As String
    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property

    Private _RUC As String
    Public Property RUC() As String
        Get
            Return _RUC
        End Get
        Set(ByVal value As String)
            _RUC = value
        End Set
    End Property

    Private _Estado As Integer
    Public Property Estado() As Integer
        Get
            Return _Estado
        End Get
        Set(ByVal value As Integer)
            _Estado = value
        End Set
    End Property

End Class
