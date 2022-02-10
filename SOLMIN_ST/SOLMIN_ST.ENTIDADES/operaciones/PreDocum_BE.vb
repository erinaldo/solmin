Public Class PreDocum_BE



    Public PSCCMPN As String = ""
    Public PNNRCTRL As Decimal = 0 'NRLQD
    Public PSTIPOPL As String = ""


    Public PNCMNDA1 As Decimal = 0  ' codMoneda
    Public PSTPCTRL As String = ""
    Public PNNCRRPD As Decimal = 0
    Public PSNTRMNL As String = ""
    Public PSCULUSA As String = ""
    Public PSTPDCPE As String = ""  '---
    Public PSDCCLNT As String = ""
    Public PSSBCLNT As String = ""
    Public PSTOBS As String = ""
    Public PNCCNLT As Decimal = 0
    Public ADETDOC As String = ""
    Public PDETDOC As Decimal = 0
    Public IGVDOC As Decimal = 0

    Public PNNGUIRM As Decimal = 0
    Public PNNCRROP As Decimal = 0
    Public PNNGUITR As Decimal = 0
    Public PNNCRRGU As Decimal = 0
    Public PSCDVSN As String = ""
    Public PNCPLNDV As Decimal = 0

    Public PNQATNAN As Decimal = 0

    Public PSFAJIMP As String = ""


    Private _PSTPOPER As String
    Public Property PSTPOPER() As String
        Get
            Return _PSTPOPER
        End Get
        Set(ByVal value As String)
            _PSTPOPER = value
        End Set
    End Property


    Private _PNIVLSRV As String
    Public Property PNIVLSRV() As String
        Get
            Return _PNIVLSRV
        End Get
        Set(ByVal value As String)
            _PNIVLSRV = value
        End Set
    End Property


    Private _MONEDA As String
    Public Property MONEDA() As String
        Get
            Return _MONEDA
        End Get
        Set(ByVal value As String)
            _MONEDA = value
        End Set
    End Property

    Private _SERVICIO As String
    Public Property SERVICIO() As String
        Get
            Return _SERVICIO
        End Get
        Set(ByVal value As String)
            _SERVICIO = value
        End Set
    End Property


    Private _PNNRLQD As Decimal
    Public Property PNNRLQD As Decimal
        Get
            Return _PNNRLQD
        End Get
        Set(ByVal value As Decimal)
            _PNNRLQD = value
        End Set
    End Property


    Private _PNCMNDGU As Decimal
    Public Property PNCMNDGU() As Decimal
        Get
            Return _PNCMNDGU
        End Get
        Set(ByVal value As Decimal)
            _PNCMNDGU = value
        End Set
    End Property


    Private _PNIMPODOC As Decimal = 0
    Public Property PNIMPODOC() As Decimal
        Get
            Return _PNIMPODOC
        End Get
        Set(ByVal value As Decimal)
            _PNIMPODOC = value
        End Set
    End Property


    Private _PNNOPRCN As Decimal
    Public Property PNNOPRCN() As Decimal
        Get
            Return _PNNOPRCN
        End Get
        Set(ByVal value As Decimal)
            _PNNOPRCN = value
        End Set
    End Property

    Private _PNCSRVC As Decimal
    Public Property PNCSRVC() As Decimal
        Get
            Return _PNCSRVC
        End Get
        Set(ByVal value As Decimal)
            _PNCSRVC = value
        End Set
    End Property



    Private _IMPORTE As Decimal
    Public Property IMPORTE() As Decimal
        Get
            Return _IMPORTE
        End Get
        Set(ByVal value As Decimal)
            _IMPORTE = value
        End Set
    End Property




End Class




