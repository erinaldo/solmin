Public Class bePuerto
    Private _PNFULTAC As Decimal = 0
    Private _PNHULTAC As Decimal = 0
    Private _PSCULUSA As String = ""
    Private _PSNTRMNL As String = ""
    Private _PSCPRTOR As String = ""
    Private _PSSESTRG As String = ""
    Private _PSTCMPR1 As String = ""
    Private _PSTABPR1 As String = ""
    Private _PNCPAIS1 As Decimal = 0
    Private _PNCPRTRL As Decimal = 0
    Private _PSCPRTAS As String = ""

    Public Property PNFULTAC() As Decimal
        Get
            Return (_PNFULTAC)
        End Get
        Set(ByVal value As Decimal)
            _PNFULTAC = value
        End Set
    End Property
    Public Property PNHULTAC() As Decimal
        Get
            Return (_PNHULTAC)
        End Get
        Set(ByVal value As Decimal)
            _PNHULTAC = value
        End Set
    End Property
    Public Property PSCULUSA() As String
        Get
            Return (_PSCULUSA)
        End Get
        Set(ByVal value As String)
            _PSCULUSA = value
        End Set
    End Property
    Public Property PSNTRMNL() As String
        Get
            Return (_PSNTRMNL)
        End Get
        Set(ByVal value As String)
            _PSNTRMNL = value
        End Set
    End Property
    Public Property PSCPRTOR() As String
        Get
            Return (_PSCPRTOR)
        End Get
        Set(ByVal value As String)
            _PSCPRTOR = value
        End Set
    End Property
    Public Property PSSESTRG() As String
        Get
            Return (_PSSESTRG)
        End Get
        Set(ByVal value As String)
            _PSSESTRG = value
        End Set
    End Property
    Public Property PSTCMPR1() As String
        Get
            Return (_PSTCMPR1)
        End Get
        Set(ByVal value As String)
            _PSTCMPR1 = value
        End Set
    End Property
    Public Property PSTABPR1() As String
        Get
            Return (_PSTABPR1)
        End Get
        Set(ByVal value As String)
            _PSTABPR1 = value
        End Set
    End Property
    Public Property PNCPAIS1() As Decimal
        Get
            Return (_PNCPAIS1)
        End Get
        Set(ByVal value As Decimal)
            _PNCPAIS1 = value
        End Set
    End Property
    Public Property PNCPRTRL() As Decimal
        Get
            Return (_PNCPRTRL)
        End Get
        Set(ByVal value As Decimal)
            _PNCPRTRL = value
        End Set
    End Property
    Public Property PSCPRTAS() As String
        Get
            Return (_PSCPRTAS)
        End Get
        Set(ByVal value As String)
            _PSCPRTAS = value
        End Set
    End Property
  
End Class
