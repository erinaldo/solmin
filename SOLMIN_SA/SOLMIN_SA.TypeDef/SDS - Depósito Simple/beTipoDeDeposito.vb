Public Class beTipoDeDeposito
    Inherits beBase(Of beTipoDeDeposito)

    Private _PSCTPDPS As String
    Private _PSTABDPS As String
    Private _PSTCMDPS As String
    Private _PSTOBDPS As String
    Private _PNFULTAC As Decimal
    Private _PNHULTAC As Decimal
    Private _PSCULUSA As String
    Private _PSNTRMNL As String
    Private _PSSESTRG As String
    Private _PNUPDATE_IDENT As Decimal

    Public Property PSCTPDPS() As String
        Get
            Return (_PSCTPDPS)
        End Get
        Set(ByVal value As String)
            _PSCTPDPS = value
        End Set
    End Property
    Public Property PSTABDPS() As String
        Get
            Return (_PSTABDPS)
        End Get
        Set(ByVal value As String)
            _PSTABDPS = value
        End Set
    End Property
    Public Property PSTCMDPS() As String
        Get
            Return (_PSTCMDPS)
        End Get
        Set(ByVal value As String)
            _PSTCMDPS = value
        End Set
    End Property
    Public Property PSTOBDPS() As String
        Get
            Return (_PSTOBDPS)
        End Get
        Set(ByVal value As String)
            _PSTOBDPS = value
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
    Public Property PSSESTRG() As String
        Get
            Return (_PSSESTRG)
        End Get
        Set(ByVal value As String)
            _PSSESTRG = value
        End Set
    End Property
    Public Property PNUPDATE_IDENT() As Decimal
        Get
            Return (_PNUPDATE_IDENT)
        End Get
        Set(ByVal value As Decimal)
            _PNUPDATE_IDENT = value
        End Set
    End Property
End Class