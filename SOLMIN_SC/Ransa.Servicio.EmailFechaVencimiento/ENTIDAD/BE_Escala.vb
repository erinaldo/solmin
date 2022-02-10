Public Class BE_Escala

    Private _PSCODIGO As String = ""
    Private _PNMAX As Int32 = 0
    Private _PNMIN As Int32 = 0
    Private _PSDESCRIPCION As String = ""
    Private _PNORDEN As Int32 = 0
    Public Property PSCODIGO() As String
        Get
            Return _PSCODIGO
        End Get
        Set(ByVal value As String)
            _PSCODIGO = value
        End Set
    End Property
    Public Property PNMAX() As Int32
        Get
            Return _PNMAX
        End Get
        Set(ByVal value As Int32)
            _PNMAX = value
        End Set
    End Property
    Public Property PNMIN() As Int32
        Get
            Return _PNMIN
        End Get
        Set(ByVal value As Int32)
            _PNMIN = value
        End Set
    End Property

    Public Property PSDESCRIPCION() As String
        Get
            Return _PSDESCRIPCION
        End Get
        Set(ByVal value As String)
            _PSDESCRIPCION = value
        End Set
    End Property
    Public Property PNORDEN() As Int32
        Get
            Return _PNORDEN
        End Get
        Set(ByVal value As Int32)
            _PNORDEN = value
        End Set
    End Property



End Class
