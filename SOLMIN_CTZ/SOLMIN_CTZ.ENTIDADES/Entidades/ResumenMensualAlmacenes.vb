Public Class ResumenMensualAlmacenes
    Private _PSCCMPN As String
    Private _PSCDVSN As String
    Private _PSCCLNT As String

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

    Public Property PSCCLNT() As String
        Get
            Return (_PSCCLNT)
        End Get
        Set(ByVal value As String)
            _PSCCLNT = value
        End Set
    End Property


    Private _PNFMOVI As Decimal
    Public Property PNFMOVI() As Decimal
        Get
            Return _PNFMOVI
        End Get
        Set(ByVal value As Decimal)
            _PNFMOVI = value
        End Set
    End Property


    Private _PNFMOVF As Decimal
    Public Property PNFMOVF() As Decimal
        Get
            Return _PNFMOVF
        End Get
        Set(ByVal value As Decimal)
            _PNFMOVF = value
        End Set
    End Property


    Private _PSCTPOAT As String
    Public Property PSCTPOAT() As String
        Get
            Return _PSCTPOAT
        End Get
        Set(ByVal value As String)
            _PSCTPOAT = value
        End Set
    End Property


    Private _PSSTPODP As String
    Public Property PSSTPODP() As String
        Get
            Return _PSSTPODP
        End Get
        Set(ByVal value As String)
            _PSSTPODP = value
        End Set
    End Property

    Private _PNFECFIN As Decimal
    Public Property PNFECFIN() As Decimal
        Get
            Return _PNFECFIN
        End Get
        Set(ByVal value As Decimal)
            _PNFECFIN = value
        End Set
    End Property


    Private _PSCTPDP6 As String
    Public Property PSCTPDP6() As String
        Get
            Return _PSCTPDP6
        End Get
        Set(ByVal value As String)
            _PSCTPDP6 = value
        End Set
    End Property

    Private _PNFECINV As Decimal
    Public Property PNFECINV() As Decimal
        Get
            Return _PNFECINV
        End Get
        Set(ByVal value As Decimal)
            _PNFECINV = value
        End Set
    End Property


End Class
