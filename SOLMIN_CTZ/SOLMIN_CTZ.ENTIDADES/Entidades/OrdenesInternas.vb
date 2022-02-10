Public Class OrdenesInternas
    Inherits Base_BE
    
    Private _CCNTCS As String = ""
    Private _STPFLT As String = ""
    Private _CCLORI As String = ""
    Private _TCLORS As String = ""
    Private _NRNINS As String = ""
    Private _NRNFNS As String = ""
    Private _NULCTR As String = ""
    Private _CSCDSP As String = ""
    Private _NORDIN As String = ""
    Private _SACORI As String = ""
    Private _TORDIN As String = ""
    Private _NORDEX As String = ""
    Private _NORSRS As String = ""
    Private _NOPRSP As String = ""
    Private _NSGSRC As String = ""
    Private _CRTANG As String = ""
    Private _CTPUNS As String = ""
    Private _CTPFLS As String = ""
    Private _CPLCMS As String = ""
    Private _CORGVT As String = ""
    Private _CCNLDS As String = ""
    Private _CSCTR As String = ""
    Private _INI_ORDEN As String = ""
    Private _FIN_ORDEN As String = ""
    'xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    Private _TCMTPD As String = ""
    Private _NDCCTC As String = ""
    Private _FDCCTC As Double = 0
    Private _ITTFCS As Double = 0
    Private _ITTFCD As Double = 0
    Private _CCLNT As String = ""
    Private _TCMPCL As String = ""
    Private _SABOPN As String = ""
    Private _SESTRG As String = ""
    Private _SAPP As String = ""

    Private _TSGNMN As String = ""

    Private _INI_FECHA As String = ""
    Private _FIN_FECHA As String = ""

    Property INI_FECHA() As String
        Get
            Return _INI_FECHA
        End Get
        Set(ByVal value As String)
            _INI_FECHA = value
        End Set
    End Property

    Property FIN_FECHA() As String
        Get
            Return _FIN_FECHA
        End Get
        Set(ByVal value As String)
            _FIN_FECHA = value
        End Set
    End Property

    Property INI_ORDEN() As String
        Get
            Return _INI_ORDEN
        End Get
        Set(ByVal value As String)
            _INI_ORDEN = value
        End Set
    End Property
    Property FIN_ORDEN() As String
        Get
            Return _FIN_ORDEN
        End Get
        Set(ByVal value As String)
            _FIN_ORDEN = value
        End Set
    End Property


    Property CCNTCS() As String
        Get
            Return _CCNTCS
        End Get
        Set(ByVal value As String)
            _CCNTCS = value
        End Set
    End Property
    Property STPFLT() As String
        Get
            Return _STPFLT
        End Get
        Set(ByVal value As String)
            _STPFLT = value
        End Set
    End Property
    Property CCLORI() As String
        Get
            Return _CCLORI
        End Get
        Set(ByVal value As String)
            _CCLORI = value
        End Set
    End Property
    Property TCLORS() As String
        Get
            Return _TCLORS
        End Get
        Set(ByVal value As String)
            _TCLORS = value
        End Set
    End Property
    Property NRNINS() As String
        Get
            Return _NRNINS
        End Get
        Set(ByVal value As String)
            _NRNINS = value
        End Set
    End Property
    Property NRNFNS() As String
        Get
            Return _NRNFNS
        End Get
        Set(ByVal value As String)
            _NRNFNS = value
        End Set
    End Property
    Property NULCTR() As String
        Get
            Return _NULCTR
        End Get
        Set(ByVal value As String)
            _NULCTR = value
        End Set
    End Property
    Property CSCDSP() As String
        Get
            Return _CSCDSP
        End Get
        Set(ByVal value As String)
            _CSCDSP = value
        End Set
    End Property
    Property NORDIN() As String
        Get
            Return _NORDIN
        End Get
        Set(ByVal value As String)
            _NORDIN = value
        End Set
    End Property

    Property SACORI() As String
        Get
            Return _SACORI
        End Get
        Set(ByVal value As String)
            _SACORI = value
        End Set
    End Property
    Property TORDIN() As String
        Get
            Return _TORDIN
        End Get
        Set(ByVal value As String)
            _TORDIN = value
        End Set
    End Property
    Property NORDEX() As String
        Get
            Return _NORDEX
        End Get
        Set(ByVal value As String)
            _NORDEX = value
        End Set
    End Property
    Property NORSRS() As String
        Get
            Return _NORSRS
        End Get
        Set(ByVal value As String)
            _NORSRS = value
        End Set
    End Property
    Property NOPRSP() As String
        Get
            Return _NOPRSP
        End Get
        Set(ByVal value As String)
            _NOPRSP = value
        End Set
    End Property
    Property NSGSRC() As String
        Get
            Return _NSGSRC
        End Get
        Set(ByVal value As String)
            _NSGSRC = value
        End Set
    End Property
    Property CRTANG() As String
        Get
            Return _CRTANG
        End Get
        Set(ByVal value As String)
            _CRTANG = value
        End Set
    End Property
    Property CTPUNS() As String
        Get
            Return _CTPUNS
        End Get
        Set(ByVal value As String)
            _CTPUNS = value
        End Set
    End Property
    Property CTPFLS() As String
        Get
            Return _CTPFLS
        End Get
        Set(ByVal value As String)
            _CTPFLS = value
        End Set
    End Property
    Property CPLCMS() As String
        Get
            Return _CPLCMS
        End Get
        Set(ByVal value As String)
            _CPLCMS = value
        End Set
    End Property
    Property CORGVT() As String
        Get
            Return _CORGVT
        End Get
        Set(ByVal value As String)
            _CORGVT = value
        End Set
    End Property
    Property CCNLDS() As String
        Get
            Return _CCNLDS
        End Get
        Set(ByVal value As String)
            _CCNLDS = value
        End Set
    End Property
    Property CSCTR() As String
        Get
            Return _CSCTR
        End Get
        Set(ByVal value As String)
            _CSCTR = value
        End Set
    End Property


    Property TSGNMN() As String
        Get
            Return _TSGNMN
        End Get
        Set(ByVal value As String)
            _TSGNMN = value
        End Set
    End Property

    Property TCMTPD() As String
        Get
            Return _TCMTPD
        End Get
        Set(ByVal value As String)
            _TCMTPD = value
        End Set
    End Property

    Property NDCCTC() As String
        Get
            Return _NDCCTC
        End Get
        Set(ByVal value As String)
            _NDCCTC = value
        End Set
    End Property

    Property FDCCTC() As Double
        Get
            Return _FDCCTC
        End Get
        Set(ByVal value As Double)
            _FDCCTC = value
        End Set
    End Property

    Property ITTFCS() As Double
        Get
            Return _ITTFCS
        End Get
        Set(ByVal value As Double)
            _ITTFCS = value
        End Set
    End Property

    Property ITTFCD() As Double
        Get
            Return _ITTFCD
        End Get
        Set(ByVal value As Double)
            _ITTFCD = value
        End Set
    End Property

    Property CCLNT() As String
        Get
            Return _CCLNT
        End Get
        Set(ByVal value As String)
            _CCLNT = value
        End Set
    End Property

    Property TCMPCL() As String
        Get
            Return _TCMPCL
        End Get
        Set(ByVal value As String)
            _TCMPCL = value
        End Set
    End Property

    Property SABOPN() As String
        Get
            Return _SABOPN
        End Get
        Set(ByVal value As String)
            _SABOPN = value
        End Set
    End Property

    Property SESTRG() As String
        Get
            Return _SESTRG
        End Get
        Set(ByVal value As String)
            _SESTRG = value
        End Set
    End Property

    Property SAPP() As String
        Get
            Return _SAPP
        End Get
        Set(ByVal value As String)
            _SAPP = value
        End Set
    End Property

End Class
