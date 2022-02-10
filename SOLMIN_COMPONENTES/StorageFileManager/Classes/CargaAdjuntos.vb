
Public Class CargaAdjuntos
    Private _TIPPROC As String = ""
    Private _IMTVIM As String = ""
    Private _MTVIMG As String = ""
    Private _NMRGIM As Integer = 0
    Private _NCRIMG As String = ""
    Private _TNMBAR As String = ""
    Private _REFDOC As String = ""
    Private _VERIMG As String = ""

    Private _DSTIMG As String = ""
    Private _TIPODC As String = ""
    Private _CCLNTO As Integer = 0
    Private _CCMPN As String = ""
    Private _MMCAPL As String = ""
    Private _CUSCRT As String = ""
    Private _STATUS As String = ""
    Private _OBSRESULT As String = ""

    Private _NRCTSL As Integer = 0
    Private _NRTFSV As Integer = 0

    Private _TIPIMG As String = ""
    Private _TPFILE As String = ""
    Private _TOBS As String = ""

    Private _NOPRCN As Decimal = 0

    Private _NLQCMB As Decimal = 0

    Private _NCSOTR As Decimal = 0

    Private _CCLNT As Decimal = 0
    Private _NROPLT As Decimal = 0

    Private _CDVSN As String = ""
    Private _CREFFW As String = ""
    Private _NRCTRL As Decimal = 0


    Private _CPLNDV As Decimal = 0
    Private _NSEQIN As Decimal = 0
    Private _NGUIRM As Decimal = 0

    Private _NROVLR As Decimal = 0

    Private _TPCTRL As String = ""

    Private _NLQDCN As Decimal = 0
    Public Property TIPPROC() As String
        Get
            Return _TIPPROC
        End Get
        Set(ByVal Value As String)
            _TIPPROC = Value
        End Set
    End Property

    Public Property IMTVIM() As String
        Get
            Return _IMTVIM
        End Get
        Set(ByVal Value As String)
            _IMTVIM = Value
        End Set
    End Property

    Public Property NMRGIM() As Integer
        Get
            Return _NMRGIM
        End Get
        Set(ByVal Value As Integer)
            _NMRGIM = Value
        End Set
    End Property
    Public Property NCRIMG() As String
        Get
            Return _NCRIMG
        End Get
        Set(ByVal Value As String)
            _NCRIMG = Value
        End Set
    End Property
    Public Property TNMBAR() As String
        Get
            Return _TNMBAR
        End Get
        Set(ByVal Value As String)
            _TNMBAR = Value
        End Set
    End Property
    Public Property REFDOC() As String
        Get
            Return _REFDOC
        End Get
        Set(ByVal Value As String)
            _REFDOC = Value
        End Set
    End Property
    Public Property VERIMG() As String
        Get
            Return _VERIMG
        End Get
        Set(ByVal Value As String)
            _VERIMG = Value
        End Set
    End Property
    Public Property DSTIMG() As String
        Get
            Return _DSTIMG
        End Get
        Set(ByVal Value As String)
            _DSTIMG = Value
        End Set
    End Property
    Public Property TIPODC() As String
        Get
            Return _TIPODC
        End Get
        Set(ByVal Value As String)
            _TIPODC = Value
        End Set
    End Property
    Public Property CCLNTO() As Integer
        Get
            Return _CCLNTO
        End Get
        Set(ByVal Value As Integer)
            _CCLNTO = Value
        End Set
    End Property
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal Value As String)
            _CCMPN = Value
        End Set
    End Property
    Public Property MMCAPL() As String
        Get
            Return _MMCAPL
        End Get
        Set(ByVal Value As String)
            _MMCAPL = Value
        End Set
    End Property
    Public Property CUSCRT() As String
        Get
            Return _CUSCRT
        End Get
        Set(ByVal Value As String)
            _CUSCRT = Value
        End Set
    End Property
    Public Property STATUS() As String
        Get
            Return _STATUS
        End Get
        Set(ByVal Value As String)
            _STATUS = Value
        End Set
    End Property
    Public Property OBSRESULT() As String
        Get
            Return _OBSRESULT
        End Get
        Set(ByVal Value As String)
            _OBSRESULT = Value
        End Set
    End Property
    Public Property NRCTSL() As Integer
        Get
            Return _NRCTSL
        End Get
        Set(ByVal Value As Integer)
            _NRCTSL = Value
        End Set
    End Property
    Public Property NRTFSV() As Integer
        Get
            Return _NRTFSV
        End Get
        Set(ByVal Value As Integer)
            _NRTFSV = Value
        End Set
    End Property
    Public Property TIPIMG() As String
        Get
            Return _TIPIMG
        End Get
        Set(ByVal Value As String)
            _TIPIMG = Value
        End Set
    End Property
    Public Property TPFILE() As String
        Get
            Return _TPFILE
        End Get
        Set(ByVal Value As String)
            _TPFILE = Value
        End Set
    End Property
    Public Property TOBS() As String
        Get
            Return _TOBS
        End Get
        Set(ByVal Value As String)
            _TOBS = Value
        End Set
    End Property

    Public Property NOPRCN() As Decimal
        Get
            Return _NOPRCN
        End Get
        Set(ByVal Value As Decimal)
            _NOPRCN = Value
        End Set
    End Property

    Public Property NLQCMB() As Decimal
        Get
            Return _NLQCMB
        End Get
        Set(ByVal Value As Decimal)
            _NLQCMB = Value
        End Set
    End Property

    Public Property NCSOTR() As Decimal
        Get
            Return _NCSOTR
        End Get
        Set(ByVal Value As Decimal)
            _NCSOTR = Value
        End Set
    End Property

    Public Property CCLNT() As Decimal
        Get
            Return _CCLNT
        End Get
        Set(ByVal Value As Decimal)
            _CCLNT = Value
        End Set
    End Property
    Public Property NROPLT() As Decimal
        Get
            Return _NROPLT
        End Get
        Set(ByVal Value As Decimal)
            _NROPLT = Value
        End Set
    End Property

    Public Property CDVSN() As String
        Get
            Return _CDVSN
        End Get
        Set(ByVal Value As String)
            _CDVSN = Value
        End Set
    End Property

    Public Property CREFFW() As String
        Get
            Return _CREFFW
        End Get
        Set(ByVal Value As String)
            _CREFFW = Value
        End Set
    End Property

    Public Property NRCTRL() As Decimal
        Get
            Return _NRCTRL
        End Get
        Set(ByVal Value As Decimal)
            _NRCTRL = Value
        End Set
    End Property

    Public Property NSEQIN() As Decimal
        Get
            Return _NSEQIN
        End Get
        Set(ByVal Value As Decimal)
            _NSEQIN = Value
        End Set
    End Property

    Public Property CPLNDV() As Decimal
        Get
            Return _CPLNDV
        End Get
        Set(ByVal Value As Decimal)
            _CPLNDV = Value
        End Set
    End Property

    Public Property NGUIRM() As Decimal
        Get
            Return _NGUIRM
        End Get
        Set(ByVal Value As Decimal)
            _NGUIRM = Value
        End Set
    End Property

    Public Property NROVLR() As Decimal
        Get
            Return _NROVLR
        End Get
        Set(ByVal Value As Decimal)
            _NROVLR = Value
        End Set
    End Property

    Public Property TPCTRL() As String
        Get
            Return _TPCTRL
        End Get
        Set(ByVal Value As String)
            _TPCTRL = Value
        End Set
    End Property


    Public Property NLQDCN() As Decimal
        Get
            Return _NLQDCN
        End Get
        Set(ByVal Value As Decimal)
            _NLQDCN = Value
        End Set
    End Property





End Class

