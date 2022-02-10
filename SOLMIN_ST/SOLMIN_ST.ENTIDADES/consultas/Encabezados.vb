Public Class Encabezados

    Enum TipoEncabezado
        FILENAME = 0
        HOJA = 1
        TITULO = 2
        FILTRO = 3
        ENCABEZADO = 4
        PIEPAGINA = 5
        HEADER = 6
        DECIMALES = 7
        KEYS = 8
        QUIEBRES = 9
    End Enum

    Sub New(ByVal objIdEncabezado As String, ByVal objTipoEncabezado As TipoEncabezado, _
            ByVal objEncabezado As String, Optional ByVal Lista As List(Of String) = Nothing)
        Me._IdEncabezado = objIdEncabezado
        Me._TipoEncabezado = objTipoEncabezado
        Me._Encabezado = objEncabezado
        Me._ListObject = Lista
    End Sub

    Private _IdEncabezado As String
    Public Property IdEncabezado() As String
        Get
            Return _IdEncabezado
        End Get
        Set(ByVal value As String)
            _IdEncabezado = value
        End Set
    End Property

    Private _TipoEncabezado As TipoEncabezado
    Public Property Tipo() As TipoEncabezado
        Get
            Return _TipoEncabezado
        End Get
        Set(ByVal value As TipoEncabezado)
            _TipoEncabezado = value
        End Set
    End Property

    Private _Encabezado As String
    Public Property Descripcion() As String
        Get
            Return _Encabezado
        End Get
        Set(ByVal value As String)
            _Encabezado = value
        End Set
    End Property

    Private _ListObject As List(Of String)
    Public Property ListObject() As List(Of String)
        Get
            Return _ListObject
        End Get
        Set(ByVal value As List(Of String))
            _ListObject = value
        End Set
    End Property

End Class