Namespace consultas
    Public Class TipoTransporte
        Private _TIPO As String = ""
        Private _DESCRIPCION As String = ""
        Private _CANTIDAD As Double = 0

        Sub New(ByVal _TIPO, ByVal _DESCRIPCION, ByVal _CANTIDAD)

            TIPO = _TIPO
            DESCRIPCION = _DESCRIPCION
            CANTIDAD = _CANTIDAD
        End Sub

        Public Property TIPO() As String
            Get
                Return _TIPO
            End Get
            Set(ByVal value As String)
                _TIPO = value
            End Set
        End Property

        Public Property DESCRIPCION() As String
            Get
                Return _DESCRIPCION
            End Get
            Set(ByVal Value As String)
                _DESCRIPCION = Value
            End Set
        End Property

        Public Property CANTIDAD() As Double
            Get
                Return _CANTIDAD
            End Get
            Set(ByVal Value As Double)
                _CANTIDAD = Value
            End Set
        End Property
    End Class
End Namespace