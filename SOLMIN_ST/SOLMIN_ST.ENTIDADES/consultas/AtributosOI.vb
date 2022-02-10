Namespace Consultas

    Public Class AtributosOI

        Private _Tipo As String
        Public Property Tipo() As String
            Get
                Return _Tipo
            End Get
            Set(ByVal value As String)
                _Tipo = value
            End Set
        End Property

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

    End Class

End Namespace
