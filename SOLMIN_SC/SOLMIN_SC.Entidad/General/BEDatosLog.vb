Public Class BEDatosLog
    Private _Sistema As String
    Private _Modulo As String
    Private _Rutina As String
    Private _Codigo As String
    Private _Mensaje As String
    Private _ErrorDescriptor As String
    Private _observaciones As String
    Private _lstr_request_stream As String
    Private _Resultado As String

    Private _FechaInicial As Integer
    Private _FechaFinal As Integer
    Private _NUM_PAG As Integer
    Private _NUM_FIL As Integer

    Private _TotalPages As Integer
    Private _TotalRows As Integer

    Public Property Sistema() As String
        Get
            Return _Sistema
        End Get
        Set(ByVal value As String)
            _Sistema = value
        End Set
    End Property
    Public Property Modulo() As String
        Get
            Return _Modulo
        End Get
        Set(ByVal value As String)
            _Modulo = value
        End Set
    End Property
    Public Property Rutina() As String
        Get
            Return _Rutina
        End Get
        Set(ByVal value As String)
            _Rutina = value
        End Set
    End Property
    Public Property Codigo() As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
        End Set
    End Property
    Public Property Mensaje() As String
        Get
            Return _Mensaje
        End Get
        Set(ByVal value As String)
            _Mensaje = value
        End Set
    End Property
    Public Property ErrorDescriptor() As String
        Get
            Return _ErrorDescriptor
        End Get
        Set(ByVal value As String)
            _ErrorDescriptor = value
        End Set
    End Property
    Public Property observaciones() As String
        Get
            Return _observaciones
        End Get
        Set(ByVal value As String)
            _observaciones = value
        End Set
    End Property
    Public Property lstr_request_stream() As String
        Get
            Return _lstr_request_stream
        End Get
        Set(ByVal value As String)
            _lstr_request_stream = value
        End Set
    End Property
    Public Property Resultado() As String
        Get
            Return _Resultado
        End Get
        Set(ByVal value As String)
            _Resultado = value
        End Set
    End Property

    Public Property FechaInicial() As Integer
        Get
            Return _FechaInicial
        End Get
        Set(ByVal value As Integer)
            _FechaInicial = value
        End Set
    End Property
    Public Property FechaFinal() As Integer
        Get
            Return _FechaFinal
        End Get
        Set(ByVal value As Integer)
            _FechaFinal = value
        End Set
    End Property
    Public Property NUM_PAG() As Integer
        Get
            Return _NUM_PAG
        End Get
        Set(ByVal value As Integer)
            _NUM_PAG = value
        End Set
    End Property
    Public Property NUM_FIL() As Integer
        Get
            Return _NUM_FIL
        End Get
        Set(ByVal value As Integer)
            _NUM_FIL = value
        End Set
    End Property

    Public Property TotalPages() As Integer
        Get
            Return _TotalPages
        End Get
        Set(ByVal value As Integer)
            _TotalPages = value
        End Set
    End Property
    Public Property TotalRows() As Integer
        Get
            Return _TotalRows
        End Get
        Set(ByVal value As Integer)
            _TotalRows = value
        End Set
    End Property
End Class
