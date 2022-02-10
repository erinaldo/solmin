Public Class Planta
    Private _codigoplanta
    Private _descripcionplanta


    Property codigoplanta() As Integer
        Get
            Return _codigoplanta
        End Get
        Set(ByVal value As Integer)
            _codigoplanta = value
        End Set
    End Property

    Property descripcionplanta() As String
        Get
            Return _descripcionplanta
        End Get
        Set(ByVal value As String)
            _descripcionplanta = value
        End Set
    End Property

End Class
