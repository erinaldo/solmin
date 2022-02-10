Public Class TD_TipoTransporte

    Private _CODIGO As String = ""
    Private _DESCRIPCION As String = ""

    Public Property CODIGO() As String
        Get
            Return _CODIGO
        End Get
        Set(ByVal value As String)
            _CODIGO = value
        End Set
    End Property

    Public Property DESCRIPCION() As String
        Get
            Return _DESCRIPCION
        End Get
        Set(ByVal value As String)
            _DESCRIPCION = value
        End Set
    End Property
End Class
