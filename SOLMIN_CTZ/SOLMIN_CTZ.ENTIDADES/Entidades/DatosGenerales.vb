Public Class DatosGenerales
    Inherits Base(Of DatosGenerales)

    Private _TIPO As String = ""
    Private _CODIGO As String = 0
    Private _DESCRIPCION As String = ""
    Private _CODREL As String = ""

#Region "Properties"

    Public Property TIPO() As String
        Get
            Return _TIPO
        End Get
        Set(ByVal value As String)
            _TIPO = value
        End Set
    End Property

    Public Property CODIGO() As String
        Get
            Return _CODIGO
        End Get
        Set(ByVal Value As String)
            _CODIGO = Value
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

    Public Property CODREL() As String
        Get
            Return _CODREL
        End Get
        Set(ByVal Value As String)
            _CODREL = Value
        End Set
    End Property

#End Region

End Class