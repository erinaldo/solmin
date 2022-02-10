Public Class beMaestroRuta
    Inherits beBase(Of beMaestroRuta)

    Private _PSCRUTAT As String
    Private _PSTABRUT As String
    Private _PNFULTAC As Decimal
    Private _PNHULTAC As Decimal
    Private _PSCULUSA As String
    Private _PSSESTRG As String
    Private _PNUPDATE_IDENT As Decimal

    Public Property PSCRUTAT() As String
        Get
            Return (_PSCRUTAT)
        End Get
        Set(ByVal value As String)
            _PSCRUTAT = value
        End Set
    End Property
    Public Property PSTABRUT() As String
        Get
            Return (_PSTABRUT)
        End Get
        Set(ByVal value As String)
            _PSTABRUT = value
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