Public Class Detalle_Junta_Transporte

    Private _NPLNJT As Decimal = 0
    Public Property NPLNJT() As Decimal
        Get
            Return _NPLNJT
        End Get
        Set(ByVal value As Decimal)
            _NPLNJT = value
        End Set
    End Property
    Private _NCRRPL As Decimal = 0
    Public Property NCRRPL() As Decimal
        Get
            Return _NCRRPL
        End Get
        Set(ByVal value As Decimal)
            _NCRRPL = value
        End Set
    End Property
    Private _NCSOTR As Decimal = 0
    Public Property NCSOTR() As Decimal
        Get
            Return _NCSOTR
        End Get
        Set(ByVal value As Decimal)
            _NCSOTR = value
        End Set
    End Property

    Private _QANPRG As Decimal = 0
    Public Property QANPRG() As Decimal
        Get
            Return _QANPRG
        End Get
        Set(ByVal value As Decimal)
            _QANPRG = value
        End Set
    End Property

    Private _CULUSA As String = ""
    Public Property CULUSA() As String
        Get
            Return _CULUSA
        End Get
        Set(ByVal value As String)
            _CULUSA = value
        End Set
    End Property
    Private _NTRMNL As String = ""
    Public Property NTRMNL() As String
        Get
            Return _NTRMNL
        End Get
        Set(ByVal value As String)
            _NTRMNL = value
        End Set
    End Property
    Private _CCMPN As String = ""
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property



End Class
