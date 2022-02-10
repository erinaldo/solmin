Public Class BeDocumento

    Inherits beBase(Of BeDocumento)

    Public Sub New()
        Me.InicializeProperty(Me)
    End Sub


    Private _PNCCLNT As Decimal
    Private _PSNDOCUM As String
    Private _PSTIPODC As String
    Private _PNNCRRDC As Decimal
    Private _PSTOBSMD As String
    Private _PSTNMBAR As String
    Private _PSURLARC As String
    Private _PSCUSCRT As String
    Private _PNFCHCRT As Decimal
    Private _PNHRACRT As Decimal
    Private _PSCULUSA As String
    Private _PNFULTAC As Decimal
    Private _PNHULTAC As Decimal
    Private _PSSESTRG As String
    Private _PNUPDATE_IDENT As Decimal

    Public Property PNCCLNT() As Decimal
        Get
            Return (_PNCCLNT)
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
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
    Public Property PSTIPODC() As String
        Get
            Return (_PSTIPODC)
        End Get
        Set(ByVal value As String)
            _PSTIPODC = value
        End Set
    End Property


    Private _PSCTIIMG As String
    Public Property PSCTIIMG() As String
        Get
            Return _PSCTIIMG
        End Get
        Set(ByVal value As String)
            _PSCTIIMG = value
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
    Public Property PSTOBSMD() As String
        Get
            Return (_PSTOBSMD)
        End Get
        Set(ByVal value As String)
            _PSTOBSMD = value
        End Set
    End Property
    Public Property PSTNMBAR() As String
        Get
            Return (_PSTNMBAR)
        End Get
        Set(ByVal value As String)
            _PSTNMBAR = value
        End Set
    End Property
    Public Property PSURLARC() As String
        Get
            Return (_PSURLARC)
        End Get
        Set(ByVal value As String)
            _PSURLARC = value
        End Set
    End Property
    Public Property PSCUSCRT() As String
        Get
            Return (_PSCUSCRT)
        End Get
        Set(ByVal value As String)
            _PSCUSCRT = value
        End Set
    End Property
    Public Property PNFCHCRT() As Decimal
        Get
            Return (_PNFCHCRT)
        End Get
        Set(ByVal value As Decimal)
            _PNFCHCRT = value
        End Set
    End Property
    Public Property PNHRACRT() As Decimal
        Get
            Return (_PNHRACRT)
        End Get
        Set(ByVal value As Decimal)
            _PNHRACRT = value
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
    Public Property PNUPDATE_IDENT() As Decimal
        Get
            Return (_PNUPDATE_IDENT)
        End Get
        Set(ByVal value As Decimal)
            _PNUPDATE_IDENT = value
        End Set
    End Property


    Private _EXTENCION As String
    Public Property EXTENCION() As String
        Get
            Return _EXTENCION
        End Get
        Set(ByVal value As String)
            _EXTENCION = value
        End Set
    End Property


    Private _IMG As Byte()
    Public Property IMG() As Byte()
        Get
            Return _IMG
        End Get
        Set(ByVal value As Byte())
            _IMG = value
        End Set
    End Property

End Class