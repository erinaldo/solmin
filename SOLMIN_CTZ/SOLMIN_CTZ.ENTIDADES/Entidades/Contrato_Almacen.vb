Public Class Contrato_Almacen
    Private _CCLNT1 As Double = 0
    Private _CHLGC1 As String = ""
    Private _NCNTR As Double = 0
    Private _NCNTRF As String = ""
    Private _CTPPR1 As String = ""
    Private _CTIGVA As String = ""
    Private _CMNDA1 As Double = 0
    Private _CTPDP3 As String = ""
    Private _SESTCT As String = ""
    Private _FCNTR As Double = 0
    Private _FTRMCN As Double = 0
    Private _NTRMNL As String = ""
    Private _CULUSA As String = ""
    Private _FULTAC As Double = 0
    Private _HULTAC As Double = 0

    Property FTRMCN() As Double
        Get
            Return _FTRMCN
        End Get
        Set(ByVal value As Double)
            _FTRMCN = value
        End Set
    End Property

    Property NTRMNL() As String
        Get
            Return _NTRMNL
        End Get
        Set(ByVal value As String)
            _NTRMNL = value
        End Set
    End Property

    Property FCNTR() As Double
        Get
            Return _FCNTR
        End Get
        Set(ByVal value As Double)
            _FCNTR = value
        End Set
    End Property

    Property SESTCT() As String
        Get
            Return _SESTCT
        End Get
        Set(ByVal value As String)
            _SESTCT = value
        End Set
    End Property

    Property CTPDP3() As String
        Get
            Return _CTPDP3
        End Get
        Set(ByVal value As String)
            _CTPDP3 = value
        End Set
    End Property

    Property CMNDA1() As Double
        Get
            Return _CMNDA1
        End Get
        Set(ByVal value As Double)
            _CMNDA1 = value
        End Set
    End Property

    Property CTIGVA() As String
        Get
            Return _CTIGVA
        End Get
        Set(ByVal value As String)
            _CTIGVA = value
        End Set
    End Property

    Property CTPPR1() As String
        Get
            Return _CTPPR1
        End Get
        Set(ByVal value As String)
            _CTPPR1 = value
        End Set
    End Property

    Property NCNTRF() As String
        Get
            Return _NCNTRF
        End Get
        Set(ByVal value As String)
            _NCNTRF = value
        End Set
    End Property

    Property NCNTR() As Double
        Get
            Return _NCNTR
        End Get
        Set(ByVal value As Double)
            _NCNTR = value
        End Set
    End Property

    Property CCLNT1() As Double
        Get
            Return _CCLNT1
        End Get
        Set(ByVal value As Double)
            _CCLNT1 = value
        End Set
    End Property

    Property CHLGC1() As String
        Get
            Return _CHLGC1
        End Get
        Set(ByVal value As String)
            _CHLGC1 = value
        End Set
    End Property
End Class
