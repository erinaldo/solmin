
Public Class TreeViewNodosBE
    Public _IdPrincipal As String
    Public _Nombre As String
    Public _IdSecundario As String
    Public _IdTerciario As String
    Public _Cheked As Boolean
    Public Property IdPrincipal() As String
        Get
            Return _IdPrincipal
        End Get
        Set(ByVal value As String)
            _IdPrincipal = value
        End Set
    End Property
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property
    Public Property IdSecundario() As String
        Get
            Return _IdSecundario
        End Get
        Set(ByVal value As String)
            _IdSecundario = value
        End Set
    End Property
    Public Property IdTerciario() As String
        Get
            Return _IdTerciario
        End Get
        Set(ByVal value As String)
            _IdTerciario = value
        End Set
    End Property
    Public Property Cheked() As Boolean
        Get
            Return _Cheked
        End Get
        Set(ByVal value As Boolean)
            _Cheked = value
        End Set
    End Property
End Class 