
Public Class TipoDatoGeneral

    Private _CODIGO_TIPO As String = ""
    Public Property CODIGO_TIPO() As String
        Get
            Return _CODIGO_TIPO
        End Get
        Set(ByVal value As String)
            _CODIGO_TIPO = value
        End Set
    End Property

    Private _DESC_TIPO As String = ""
    Public Property DESC_TIPO() As String
        Get
            Return _DESC_TIPO
        End Get
        Set(ByVal value As String)
            _DESC_TIPO = value
        End Set
    End Property
End Class
