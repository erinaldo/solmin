Public Class SolicitudEfectivoSAP
    Private _CCMPN As String = ""
    Private _ICTMYS As String = ""
    Private _NMSLPE As Double = 0
    Private _FCSLPE As Double = 0
    Private _CMSLPE As Double = 0
    Private _IMTPOC As Double = 0
    Private _TCBDCS As String = ""
    Private _CMTCDS As String = ""
    Private _ISLPES As Double = 0
    Private _FVENDP As Double = 0
    Private _NORINS As Double = 0
    Private _TADSAP As String = ""
    Private _NRFSAP As Double = 0
    Private _AEJINS As Double = 0
    Private _STERSP As String = ""
    Private _TSTERS As String = ""
    Private _FSTTRS As String = ""
    Private _CUSCRT As String = ""
    Private _FCHCRT As Double = 0
    Private _HRACRT As Double = 0
    Private _NTRMCR As String = ""
    Private _CULUSA As String = ""
    Private _FULTAC As Double = 0
    Private _HULTAC As Double = 0
    Private _NTRMNL As String = ""
    Private _CDVSN As String = ""
    Private _NPLCUN As String = ""
    Private _NOPRCN As Double = 0
    Private _RUTA As String
    Private _NORSRT As Double
    Private _CCLNT As Double
    Private _CBRCNT As String
    Private _CONDUCTOR1 As String
    Private _CBRCN2 As String
    Private _CONDUCTOR2 As String
    Private _COMENTARIO As String
    Private _CODSAP As String = ""

    Private _CODSAP2 As String = ""


    Public Property CODSAP2() As String
        Get
            Return _CODSAP2
        End Get
        Set(ByVal value As String)
            _CODSAP2 = value
        End Set
    End Property

    Public Property CCLNT() As Double
        Get
            Return _CCLNT
        End Get
        Set(ByVal value As Double)
            _CCLNT = value
        End Set
    End Property


    Public Property NORSRT() As Double
        Get
            Return _NORSRT
        End Get
        Set(ByVal value As Double)
            _NORSRT = value
        End Set
    End Property

    Public Property RUTA() As String
        Get
            Return _RUTA
        End Get
        Set(ByVal value As String)
            _RUTA = value
        End Set
    End Property


    Private _CLCLOR As Double
    Public Property CLCLOR() As Double
        Get
            Return _CLCLOR
        End Get
        Set(ByVal value As Double)
            _CLCLOR = value
        End Set
    End Property


    Private _CLCLDS As Double
    Public Property CLCLDS() As Double
        Get
            Return _CLCLDS
        End Get
        Set(ByVal value As Double)
            _CLCLDS = value
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

    Public Property ICTMYS() As String
        Get
            Return _ICTMYS
        End Get
        Set(ByVal Value As String)
            _ICTMYS = Value
        End Set
    End Property

    Public Property NMSLPE() As Double
        Get
            Return _NMSLPE
        End Get
        Set(ByVal Value As Double)
            _NMSLPE = Value
        End Set
    End Property

    Public Property FCSLPE() As Double
        Get
            Return _FCSLPE
        End Get
        Set(ByVal Value As Double)
            _FCSLPE = Value
        End Set
    End Property

    Public Property CMSLPE() As Double
        Get
            Return _CMSLPE
        End Get
        Set(ByVal Value As Double)
            _CMSLPE = Value
        End Set
    End Property

    Public Property IMTPOC() As Double
        Get
            Return _IMTPOC
        End Get
        Set(ByVal Value As Double)
            _IMTPOC = Value
        End Set
    End Property

    Public Property TCBDCS() As String
        Get
            Return _TCBDCS
        End Get
        Set(ByVal Value As String)
            _TCBDCS = Value
        End Set
    End Property

    Public Property CMTCDS() As String
        Get
            Return _CMTCDS
        End Get
        Set(ByVal Value As String)
            _CMTCDS = Value
        End Set
    End Property

    Public Property ISLPES() As Double
        Get
            Return _ISLPES
        End Get
        Set(ByVal Value As Double)
            _ISLPES = Value
        End Set
    End Property

    Public Property FVENDP() As Double
        Get
            Return _FVENDP
        End Get
        Set(ByVal Value As Double)
            _FVENDP = Value
        End Set
    End Property

    Public Property NORINS() As Double
        Get
            Return _NORINS
        End Get
        Set(ByVal Value As Double)
            _NORINS = Value
        End Set
    End Property

    Public Property TADSAP() As String
        Get
            Return _TADSAP
        End Get
        Set(ByVal Value As String)
            _TADSAP = Value
        End Set
    End Property

    Public Property NRFSAP() As Double
        Get
            Return _NRFSAP
        End Get
        Set(ByVal Value As Double)
            _NRFSAP = Value
        End Set
    End Property

    Public Property AEJINS() As Double
        Get
            Return _AEJINS
        End Get
        Set(ByVal Value As Double)
            _AEJINS = Value
        End Set
    End Property

    Public Property STERSP() As String
        Get
            Return _STERSP
        End Get
        Set(ByVal Value As String)
            _STERSP = Value
        End Set
    End Property

    Public Property TSTERS() As String
        Get
            Return _TSTERS
        End Get
        Set(ByVal Value As String)
            _TSTERS = Value
        End Set
    End Property

    Public Property FSTTRS() As String
        Get
            Return _FSTTRS
        End Get
        Set(ByVal Value As String)
            _FSTTRS = Value
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

    Public Property FCHCRT() As Double
        Get
            Return _FCHCRT
        End Get
        Set(ByVal Value As Double)
            _FCHCRT = Value
        End Set
    End Property

    Public Property HRACRT() As Double
        Get
            Return _HRACRT
        End Get
        Set(ByVal Value As Double)
            _HRACRT = Value
        End Set
    End Property

    Public Property NTRMCR() As String
        Get
            Return _NTRMCR
        End Get
        Set(ByVal Value As String)
            _NTRMCR = Value
        End Set
    End Property

    Public Property CULUSA() As String
        Get
            Return _CULUSA
        End Get
        Set(ByVal Value As String)
            _CULUSA = Value
        End Set
    End Property

    Public Property FULTAC() As Double
        Get
            Return _FULTAC
        End Get
        Set(ByVal Value As Double)
            _FULTAC = Value
        End Set
    End Property

    Public Property HULTAC() As Double
        Get
            Return _HULTAC
        End Get
        Set(ByVal Value As Double)
            _HULTAC = Value
        End Set
    End Property

    Public Property NTRMNL() As String
        Get
            Return _NTRMNL
        End Get
        Set(ByVal Value As String)
            _NTRMNL = Value
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

    Public Property NPLCUN() As String
        Get
            Return _NPLCUN
        End Get
        Set(ByVal Value As String)
            _NPLCUN = Value
        End Set
    End Property

    Public Property NOPRCN() As Double
        Get
            Return _NOPRCN
        End Get
        Set(ByVal Value As Double)
            _NOPRCN = Value
        End Set
    End Property

    Public Property CBRCNT() As String
        Get
            Return _CBRCNT
        End Get
        Set(ByVal value As String)
            _CBRCNT = value
        End Set
    End Property


    Public Property CONDUCTOR1() As String
        Get
            Return _CONDUCTOR1
        End Get
        Set(ByVal value As String)
            _CONDUCTOR1 = value
        End Set
    End Property


    Public Property CBRCN2() As String
        Get
            Return _CBRCN2
        End Get
        Set(ByVal value As String)
            _CBRCN2 = value
        End Set
    End Property


    Public Property CONDUCTOR2() As String
        Get
            Return _CONDUCTOR2
        End Get
        Set(ByVal value As String)
            _CONDUCTOR2 = value
        End Set
    End Property


    Public Property COMENTARIO() As String
        Get
            Return _COMENTARIO
        End Get
        Set(ByVal value As String)
            _COMENTARIO = value
        End Set
    End Property

    Public Property CODSAP() As String
        Get
            Return _CODSAP
        End Get
        Set(ByVal value As String)
            _CODSAP = value
        End Set
    End Property

End Class
