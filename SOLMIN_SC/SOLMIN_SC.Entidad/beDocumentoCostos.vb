Public Class beDocumentoCostos
    Private _PNNORSCI As Decimal = 0
    Private _PNNDOCIN As Decimal = 0
    Private _PNNCRRDC As Decimal = 0
    Private _PSNDOCUM As String = ""
    Private _PNIVLORG As Decimal = 0
    Private _PNIVLDOL As Decimal = 0
    Private _PNCMNDA1 As Decimal = 0
    Private _PSNMONOC As String = ""
    Private _PSTOBS As String = ""
    'Private _PSTNMBAR As String = ""
    'Private _PSURLARC As String = ""
    Private _PSCULUSA As String = ""
    Private _PNFULTAC As Decimal = 0
    Private _PNHULTAC As Decimal = 0
    Private _PSSESTRG As String = ""

    Public Property PNNORSCI() As Decimal
        Get
            Return (_PNNORSCI)
        End Get
        Set(ByVal value As Decimal)
            _PNNORSCI = value
        End Set
    End Property
    Public Property PNNDOCIN() As Decimal
        Get
            Return (_PNNDOCIN)
        End Get
        Set(ByVal value As Decimal)
            _PNNDOCIN = value
        End Set
    End Property
    Public Property PNNCRRDC() As Decimal
        Get
            Return (_PNNCRRDC)
        End Get
        Set(ByVal value As Decimal)
            _PNNCRRDC = value
        End Set
    End Property
    Public Property PSNDOCUM() As String
        Get
            Return (_PSNDOCUM)
        End Get
        Set(ByVal value As String)
            _PSNDOCUM = value
        End Set
    End Property
    Public Property PNIVLORG() As Decimal
        Get
            Return (_PNIVLORG)
        End Get
        Set(ByVal value As Decimal)
            _PNIVLORG = value
        End Set
    End Property
    Public Property PNIVLDOL() As Decimal
        Get
            Return (_PNIVLDOL)
        End Get
        Set(ByVal value As Decimal)
            _PNIVLDOL = value
        End Set
    End Property
    Public Property PNCMNDA1() As Decimal
        Get
            Return (_PNCMNDA1)
        End Get
        Set(ByVal value As Decimal)
            _PNCMNDA1 = value
        End Set
    End Property
    Public Property PSNMONOC() As String
        Get
            Return (_PSNMONOC)
        End Get
        Set(ByVal value As String)
            _PSNMONOC = value
        End Set
    End Property
    Public Property PSTOBS() As String
        Get
            Return (_PSTOBS)
        End Get
        Set(ByVal value As String)
            _PSTOBS = value
        End Set
    End Property
    'Public Property PSTNMBAR() As String
    '    Get
    '        Return (_PSTNMBAR)
    '    End Get
    '    Set(ByVal value As String)
    '        _PSTNMBAR = value
    '    End Set
    'End Property
    'Public Property PSURLARC() As String
    '    Get
    '        Return (_PSURLARC)
    '    End Get
    '    Set(ByVal value As String)
    '        _PSURLARC = value
    '    End Set
    'End Property
 
    Public Property PSCULUSA() As String
        Get
            Return (_PSCULUSA)
        End Get
        Set(ByVal value As String)
            _PSCULUSA = value
        End Set
    End Property
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
    Public Property PSSESTRG() As String
        Get
            Return (_PSSESTRG)
        End Get
        Set(ByVal value As String)
            _PSSESTRG = value
        End Set
    End Property
   

End Class
