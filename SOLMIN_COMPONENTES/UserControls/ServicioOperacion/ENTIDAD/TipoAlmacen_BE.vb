Public Class TipoAlmacen_BE

    Private _CTPALM As String
    Public Property CTPALM() As String
        Get
            Return _CTPALM
        End Get
        Set(ByVal value As String)
            _CTPALM = value
        End Set
    End Property

    Private _TALMC As String
    Public Property TALMC() As String
        Get
            Return _TALMC
        End Get
        Set(ByVal value As String)
            _TALMC = value
        End Set
    End Property


End Class
