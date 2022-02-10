Imports Ransa.TYPEDEF

Public Class beUbicacion
    Inherits beBase(Of beUbicacion)


    Private _PSCTPALM As String
    Private _PSCALMC As String
    Private _PSCSECTR As String
    Private _PSCPSCN As String
    Private _PNNORDSR As Decimal
    Private _PNNCRRIN As Decimal
    Private _PNNSLCSR As Decimal
    Private _PNFTRNS As Decimal
    Private _PNQTRMC1 As Decimal
    Private _PSCCMPN As String
    Private _PSCDVSN As String
    Private _PNCSRVC As Decimal
    Private _PSCUSCRT As String
    Private _PNFCHCRT As Decimal
    Private _PNHRACRT As Decimal
    Private _PSNTRMCR As String
    Private _PNFULTAC As Decimal
    Private _PNHULTAC As Decimal
    Private _PSCULUSA As String
    Private _PSNTRMNL As String
    Private _PSSESTRG As String
    Private _PNUPDATE_IDENT As Decimal
    Private _PNQSLETQ As Decimal
    Private _PNSSCPOS As String
    Private _PNNGUIRN As Decimal
    Private _PSCZNALM As String

    Public Property PSCTPALM() As String
        Get
            Return (_PSCTPALM)
        End Get
        Set(ByVal value As String)
            _PSCTPALM = value
        End Set
    End Property
    Public Property PSCALMC() As String
        Get
            Return (_PSCALMC)
        End Get
        Set(ByVal value As String)
            _PSCALMC = value
        End Set
    End Property
    Public Property PSCZNALM() As String
        Get
            Return (_PSCZNALM)
        End Get
        Set(ByVal value As String)
            _PSCZNALM = value
        End Set
    End Property
    Public Property PSCSECTR() As String
        Get
            Return (_PSCSECTR)
        End Get
        Set(ByVal value As String)
            _PSCSECTR = value
        End Set
    End Property
    Public Property PSCPSCN() As String
        Get
            Return (_PSCPSCN)
        End Get
        Set(ByVal value As String)
            _PSCPSCN = value
        End Set
    End Property
    Public Property PNNORDSR() As Decimal
        Get
            Return (_PNNORDSR)
        End Get
        Set(ByVal value As Decimal)
            _PNNORDSR = value
        End Set
    End Property
    Public Property PNNCRRIN() As Decimal
        Get
            Return (_PNNCRRIN)
        End Get
        Set(ByVal value As Decimal)
            _PNNCRRIN = value
        End Set
    End Property
    Public Property PNNSLCSR() As Decimal
        Get
            Return (_PNNSLCSR)
        End Get
        Set(ByVal value As Decimal)
            _PNNSLCSR = value
        End Set
    End Property
    Public Property PNFTRNS() As Decimal
        Get
            Return (_PNFTRNS)
        End Get
        Set(ByVal value As Decimal)
            _PNFTRNS = value
        End Set
    End Property
    Public Property PNQTRMC1() As Decimal
        Get
            Return (_PNQTRMC1)
        End Get
        Set(ByVal value As Decimal)
            _PNQTRMC1 = value
        End Set
    End Property
    Public Property PSCCMPN() As String
        Get
            Return (_PSCCMPN)
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property
    Public Property PSCDVSN() As String
        Get
            Return (_PSCDVSN)
        End Get
        Set(ByVal value As String)
            _PSCDVSN = value
        End Set
    End Property
    Public Property PNCSRVC() As Decimal
        Get
            Return (_PNCSRVC)
        End Get
        Set(ByVal value As Decimal)
            _PNCSRVC = value
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

    Public Property PNNGUIRN() As String
        Get
            Return (_PNNGUIRN)
        End Get
        Set(ByVal value As String)
            _PNNGUIRN = value
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
    Public Property PSNTRMCR() As String
        Get
            Return (_PSNTRMCR)
        End Get
        Set(ByVal value As String)
            _PSNTRMCR = value
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

    Public Property PNQSLETQ() As Decimal
        Get
            Return _PNQSLETQ
        End Get
        Set(ByVal value As Decimal)
            _PNQSLETQ = value
        End Set
    End Property

    Public Property PNSSCPOS() As String
        Get
            Return _PNSSCPOS
        End Get
        Set(ByVal value As String)
            _PNSSCPOS = value
        End Set
    End Property
End Class