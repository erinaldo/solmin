Public Class beDirecServ

    Private _codigo As String
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property
    Private _direccion As String
    Public Property Direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property
    Private _ubigeo As Int32
    Public Property Ubigeo() As Int32
        Get
            Return _ubigeo
        End Get
        Set(ByVal value As Int32)
            _ubigeo = value
        End Set
    End Property
    Private _referencia As String
    Public Property Referencia() As String
        Get
            Return _referencia
        End Get
        Set(ByVal value As String)
            _referencia = value
        End Set
    End Property
    Private _usuario_creador As String
    Public Property Usuario_creador() As String
        Get
            Return _usuario_creador
        End Get
        Set(ByVal value As String)
            _usuario_creador = value
        End Set
    End Property
    Private _usuario_act As String
    Public Property Usuario_act() As String
        Get
            Return _usuario_act
        End Get
        Set(ByVal value As String)
            _usuario_act = value
        End Set
    End Property
    Private _machinename As String
    Public Property MachineName() As String
        Get
            Return _machinename
        End Get
        Set(ByVal value As String)
            _machinename = value
        End Set
    End Property

End Class
