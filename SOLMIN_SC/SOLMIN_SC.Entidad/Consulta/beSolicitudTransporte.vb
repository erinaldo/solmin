Public Class beSolicitudTransporte
    Private _PNNORSRT As Decimal = 0
    Private _PNNCSOTR As Decimal = 0
    Private _PSFECOST As String = ""
    Private _PNCCLNT As Decimal = 0
    Private _PSCCMPN As String = ""
    Private _PSCDVSN As String = ""
    Private _PNCPLNDV As Decimal = 0
    Private _PNCMEDTR As Decimal = 0
    Private _PSTCMCRA As String = "" 'TIPO VEHICULO
    Private _PSTCMTPS As String = "" 'TIPO SERVICIO
    Private _PSTCMPUN As String = "" 'UNIDAD MEDIDA
    Private _PSTCMRCD As String = "" 'MERCADERIA TRANSPORTE
    Private _PSTIPO_SOLICITUD As String = "" ' TIPO SOLICITUD
    Private _PSTNMMDT As String = "" ' MEDIO TRANSPORTE
    Private _PSTCMLCL_ORIGEN As String = ""
    Private _PSTCMLCL_DESTINO As String = ""
    Private _PSSESTRG As String = ""
    Private _PNQSLCIT As Decimal = 0
    Private _PNQATNAN As Decimal = 0
    Private _PSCTPOSR As String = ""
    Private _PNCUNDVH As Decimal = 0
    Private _PNCMRCDR As Decimal = 0
    Private _PNQMRCDR As Decimal = 0
    Private _PSCUNDMD As String = ""
    Private _PSFINCRG As String = ""
    Private _PSHINCIN As String = ""
    Private _PSTOBS As String = ""
    Private _PSTDRENT As String = ""
    Private _PSTDRCOR As String = ""
    Private _PSFENTCL As String = ""
    Private _PSHRAENT As String = ""
    Private _PSCCTCSC As String = ""

    Public Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal Value As String)
            _PSCCMPN = Value
        End Set
    End Property

    Public Property PSCDVSN() As String
        Get
            Return _PSCDVSN
        End Get
        Set(ByVal Value As String)
            _PSCDVSN = Value
        End Set
    End Property

    Public Property PNCPLNDV() As Decimal
        Get
            Return _PNCPLNDV
        End Get
        Set(ByVal Value As Decimal)
            _PNCPLNDV = Value
        End Set
    End Property

    Public Property PNCMEDTR() As Decimal
        Get
            Return _PNCMEDTR
        End Get
        Set(ByVal value As Decimal)
            _PNCMEDTR = value
        End Set
    End Property


    Public Property PSTCMCRA() As String
        Get
            Return _PSTCMCRA
        End Get
        Set(ByVal value As String)
            _PSTCMCRA = value
        End Set
    End Property

    Public Property PSTCMTPS() As String
        Get
            Return _PSTCMTPS
        End Get
        Set(ByVal value As String)
            _PSTCMTPS = value
        End Set
    End Property

    Public Property PSTCMPUN() As String
        Get
            Return _PSTCMPUN
        End Get
        Set(ByVal value As String)
            _PSTCMPUN = value
        End Set
    End Property


    Public Property PSTCMRCD() As String
        Get
            Return _PSTCMRCD
        End Get
        Set(ByVal value As String)
            _PSTCMRCD = value
        End Set

    End Property

    Public Property PSTIPO_SOLICITUD() As String
        Get
            Return _PSTIPO_SOLICITUD
        End Get
        Set(ByVal value As String)
            _PSTIPO_SOLICITUD = value
        End Set

    End Property

    Public Property PSTNMMDT() As String
        Get
            Return _PSTNMMDT
        End Get
        Set(ByVal value As String)
            _PSTNMMDT = value
        End Set
    End Property

    Public Property PSTCMLCL_ORIGEN() As String
        Get
            Return _PSTCMLCL_ORIGEN
        End Get
        Set(ByVal value As String)
            _PSTCMLCL_ORIGEN = value
        End Set
    End Property


    Public Property PSTCMLCL_DESTINO() As String
        Get
            Return _PSTCMLCL_DESTINO
        End Get
        Set(ByVal value As String)
            _PSTCMLCL_DESTINO = value
        End Set
    End Property

    Public Property PNNCSOTR() As Decimal
        Get
            Return _PNNCSOTR
        End Get
        Set(ByVal value As Decimal)
            _PNNCSOTR = value
        End Set
    End Property


    Public Property PSFECOST() As String
        Get
            Return _PSFECOST
        End Get
        Set(ByVal value As String)
            _PSFECOST = value
        End Set
    End Property

   

    Public Property PNCCLNT() As Decimal
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property

    Public Property PNNORSRT() As Decimal
        Get
            Return _PNNORSRT
        End Get
        Set(ByVal value As Decimal)
            _PNNORSRT = value
        End Set
    End Property

    Public Property PSSESTRG() As String
        Get
            Return _PSSESTRG
        End Get
        Set(ByVal value As String)
            _PSSESTRG = value
        End Set

    End Property

    Public Property PNQSLCIT() As Decimal
        Get
            Return _PNQSLCIT
        End Get
        Set(ByVal value As Decimal)
            _PNQSLCIT = value
        End Set
    End Property

    Public Property PNQATNAN() As Decimal
        Get
            Return _PNQATNAN
        End Get
        Set(ByVal value As Decimal)
            _PNQATNAN = value
        End Set
    End Property
    Public Property PSCTPOSR() As String
        Get
            Return _PSCTPOSR
        End Get
        Set(ByVal value As String)
            _PSCTPOSR = value
        End Set
    End Property

    Public Property PNCUNDVH() As Decimal
        Get
            Return _PNCUNDVH
        End Get
        Set(ByVal value As Decimal)
            _PNCUNDVH = value
        End Set

    End Property

    Public Property PNCMRCDR() As Decimal
        Get
            Return _PNCMRCDR
        End Get
        Set(ByVal value As Decimal)
            _PNCMRCDR = value
        End Set
    End Property
    Public Property PNQMRCDR() As Decimal
        Get
            Return _PNQMRCDR
        End Get
        Set(ByVal value As Decimal)
            _PNQMRCDR = value
        End Set

    End Property

    Public Property PSCUNDMD() As String
        Get
            Return _PSCUNDMD
        End Get
        Set(ByVal value As String)
            _PSCUNDMD = value
        End Set
    End Property


    Public Property PSFINCRG() As String
        Get
            Return _PSFINCRG
        End Get
        Set(ByVal value As String)
            _PSFINCRG = value
        End Set
    End Property


    Public Property PSHINCIN() As String
        Get
            Return _PSHINCIN
        End Get
        Set(ByVal value As String)
            _PSHINCIN = value
        End Set
    End Property

    Public Property PSTOBS() As String
        Get
            Return _PSTOBS
        End Get
        Set(ByVal value As String)
            _PSTOBS = value
        End Set
    End Property


    Public Property PSTDRENT() As String
        Get
            Return _PSTDRENT
        End Get
        Set(ByVal value As String)
            _PSTDRENT = value
        End Set
    End Property


    Public Property PSTDRCOR() As String
        Get
            Return _PSTDRCOR
        End Get
        Set(ByVal value As String)
            _PSTDRCOR = value
        End Set
    End Property


    Public Property PSFENTCL() As String
        Get
            Return _PSFENTCL
        End Get
        Set(ByVal value As String)
            _PSFENTCL = value
        End Set

    End Property


    Public Property PSHRAENT() As String
        Get
            Return _PSHRAENT
        End Get
        Set(ByVal value As String)
            _PSHRAENT = value
        End Set

    End Property


    Public Property PSCCTCSC() As String
        Get
            Return _PSCCTCSC
        End Get
        Set(ByVal value As String)
            _PSCCTCSC = value
        End Set

    End Property

  




End Class
