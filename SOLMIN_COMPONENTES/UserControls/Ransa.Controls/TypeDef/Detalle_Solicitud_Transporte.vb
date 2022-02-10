
Public Class Detalle_Solicitud_Transporte

#Region "Atributo"

    Private _NCSOTR As String = ""
    Private _NCRRSR As String = ""
    Private _FASGTR As String = ""
    Private _HASGTR As String = ""
    Private _NPLNJT As String = ""
    Private _NCRRPL As String = ""
    Private _CCLNT As String = ""
    Private _NRUCTR As String = ""
    Private _NPLCUN As String = ""
    Private _NPLCAC As String = ""
    Private _CBRCNT As String = ""
    Private _CBRCN2 As String = ""
    Private _SESTRG As String = ""
    Private _CUSCRT As String = ""
    Private _FCHCRT As String = ""
    Private _HRACRT As String = ""
    Private _NTRMCR As String = ""
    Private _CULUSA As String = ""
    Private _FULTAC As String = ""
    Private _HULTAC As String = ""
    Private _NTRMNL As String = ""

    Private _CTITRA As String = ""
    Private _CTPCRA As String = ""
    Private _TCMCRA As String = ""
    Private _TDETRA As String = ""
    Private _TMRCTR As String = ""
    Private _TCMTRT As String = ""
    Private _CTRSPT As String = ""
    Private _TCMPCL As String = ""
    Private _SESTCM As String = ""
    Private _ESTADO As String = ""
    Private _NOMBRE As String = ""
    Private _SEGUIMIENTO As String = ""
    Private _GPSLAT As String = ""
    Private _GPSLON As String = ""
    Private _FECGPS As String = ""
    Private _HORGPS As String = ""
    Private _FATALM As String = ""
    Private _HATALM As String = ""
    Private _FSLALM As String = ""
    Private _HSLALM As String = ""
    Private _NGUITR As String = ""
    Private _NOPRCN As String = ""
    Private _RUTA As String = ""
    Private _NPLNMT As String = ""
    Private _NORINS As String = ""
    Private _SESTOP As String = ""
    Private _NCTAVC As String = ""
    Private _NCSLPE As String = ""
    Private _NCSLP2 As String = ""
    Private _NCTAV2 As String = ""
    Private _CCMPN As String = ""
    Private _CDVSN As String = ""
    Private _CPLNDV As Double = 0
    Private _NORSRT As Double = 0
    Private _CTPOVJ As String = ""
#End Region

#Region "Properties"

    Public Property SESTOP() As String
        Get
            Return _SESTOP
        End Get
        Set(ByVal value As String)
            _SESTOP = value
        End Set
    End Property

    Public Property NORINS() As String
        Get
            Return _NORINS
        End Get
        Set(ByVal value As String)
            _NORINS = value
        End Set
    End Property

    Public Property NPLNMT() As String
        Get
            Return _NPLNMT
        End Get
        Set(ByVal value As String)
            _NPLNMT = value
        End Set

    End Property
    Public Property NCSOTR() As String
        Get
            Return _NCSOTR
        End Get
        Set(ByVal Value As String)
            _NCSOTR = Value
        End Set
    End Property

    Public Property NCRRSR() As String
        Get
            Return _NCRRSR
        End Get
        Set(ByVal Value As String)
            _NCRRSR = Value
        End Set
    End Property

    Public Property FASGTR() As String
        Get
            Return _FASGTR
        End Get
        Set(ByVal Value As String)
            _FASGTR = Value
        End Set
    End Property

    Public Property HASGTR() As String
        Get
            Return _HASGTR
        End Get
        Set(ByVal Value As String)
            _HASGTR = Value
        End Set
    End Property

    Public Property NPLNJT() As String
        Get
            Return _NPLNJT
        End Get
        Set(ByVal Value As String)
            _NPLNJT = Value
        End Set
    End Property

    Public Property NCRRPL() As String
        Get
            Return _NCRRPL
        End Get
        Set(ByVal Value As String)
            _NCRRPL = Value
        End Set
    End Property

    Public Property NRUCTR() As String
        Get
            Return _NRUCTR
        End Get
        Set(ByVal Value As String)
            _NRUCTR = Value
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

    Public Property NPLCAC() As String
        Get
            Return _NPLCAC
        End Get
        Set(ByVal Value As String)
            _NPLCAC = Value
        End Set
    End Property

    Public Property CBRCNT() As String
        Get
            Return _CBRCNT
        End Get
        Set(ByVal Value As String)
            _CBRCNT = Value
        End Set
    End Property

    Public Property CBRCN2() As String
        Get
            Return _CBRCN2
        End Get
        Set(ByVal Value As String)
            _CBRCN2 = Value
        End Set
    End Property

    Public Property SESTRG() As String
        Get
            Return _SESTRG
        End Get
        Set(ByVal Value As String)
            _SESTRG = Value
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

    Public Property FCHCRT() As String
        Get
            Return _FCHCRT
        End Get
        Set(ByVal Value As String)
            _FCHCRT = Value
        End Set
    End Property

    Public Property HRACRT() As String
        Get
            Return _HRACRT
        End Get
        Set(ByVal Value As String)
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

    Public Property FULTAC() As String
        Get
            Return _FULTAC
        End Get
        Set(ByVal Value As String)
            _FULTAC = Value
        End Set
    End Property

    Public Property HULTAC() As String
        Get
            Return _HULTAC
        End Get
        Set(ByVal Value As String)
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

    Public Property CTITRA() As String
        Get
            Return _CTITRA
        End Get
        Set(ByVal Value As String)
            _CTITRA = Value
        End Set
    End Property

    Public Property TDETRA() As String
        Get
            Return _TDETRA
        End Get
        Set(ByVal Value As String)
            _TDETRA = Value
        End Set
    End Property

    Public Property TMRCTR() As String
        Get
            Return _TMRCTR
        End Get
        Set(ByVal Value As String)
            _TMRCTR = Value
        End Set
    End Property

    Public Property TCMTRT() As String
        Get
            Return _TCMTRT
        End Get
        Set(ByVal Value As String)
            _TCMTRT = Value
        End Set
    End Property

    Public Property CTRSPT() As String
        Get
            Return _CTRSPT
        End Get
        Set(ByVal Value As String)
            _CTRSPT = Value
        End Set
    End Property

    Public Property CCLNT() As String
        Get
            Return _CCLNT
        End Get
        Set(ByVal Value As String)
            _CCLNT = Value
        End Set
    End Property

    Public Property TCMPCL() As String
        Get
            Return _TCMPCL
        End Get
        Set(ByVal Value As String)
            _TCMPCL = Value
        End Set
    End Property

    Public Property SESTCM() As String
        Get
            Return _SESTCM
        End Get
        Set(ByVal Value As String)
            _SESTCM = Value
        End Set
    End Property

    Public Property ESTADO() As String
        Get
            Return _ESTADO
        End Get
        Set(ByVal Value As String)
            _ESTADO = Value
        End Set
    End Property

    Public Property NOMBRE() As String
        Get
            Return _NOMBRE
        End Get
        Set(ByVal Value As String)
            _NOMBRE = Value
        End Set
    End Property

    Public Property GPSLAT() As String
        Get
            Return _GPSLAT
        End Get
        Set(ByVal Value As String)
            _GPSLAT = Value
        End Set
    End Property

    Public Property GPSLON() As String
        Get
            Return _GPSLON
        End Get
        Set(ByVal Value As String)
            _GPSLON = Value
        End Set
    End Property

    Public Property SEGUIMIENTO() As String
        Get
            Return _SEGUIMIENTO
        End Get
        Set(ByVal Value As String)
            _SEGUIMIENTO = Value
        End Set
    End Property

    Public Property FECGPS() As String
        Get
            Return _FECGPS
        End Get
        Set(ByVal Value As String)
            _FECGPS = Value
        End Set
    End Property

    Public Property HORGPS() As String
        Get
            Return _HORGPS
        End Get
        Set(ByVal Value As String)
            _HORGPS = Value
        End Set
    End Property

    Public Property CTPCRA() As String
        Get
            Return _CTPCRA
        End Get
        Set(ByVal Value As String)
            _CTPCRA = Value
        End Set
    End Property

    Public Property TCMCRA() As String
        Get
            Return _TCMCRA
        End Get
        Set(ByVal Value As String)
            _TCMCRA = Value
        End Set
    End Property

    Public Property FATALM() As String
        Get
            Return _FATALM
        End Get
        Set(ByVal Value As String)
            _FATALM = Value
        End Set
    End Property

    Public Property HATALM() As String
        Get
            Return _HATALM
        End Get
        Set(ByVal Value As String)
            _HATALM = Value
        End Set
    End Property

    Public Property FSLALM() As String
        Get
            Return _FSLALM
        End Get
        Set(ByVal Value As String)
            _FSLALM = Value
        End Set
    End Property

    Public Property HSLALM() As String
        Get
            Return _HSLALM
        End Get
        Set(ByVal Value As String)
            _HSLALM = Value
        End Set
    End Property

    Public Property NGUITR() As String
        Get
            Return _NGUITR
        End Get
        Set(ByVal Value As String)
            _NGUITR = Value
        End Set
    End Property

    Public Property NOPRCN() As String
        Get
            Return _NOPRCN
        End Get
        Set(ByVal Value As String)
            _NOPRCN = Value
        End Set
    End Property

    Public Property RUTA() As String
        Get
            Return _RUTA
        End Get
        Set(ByVal Value As String)
            _RUTA = Value
        End Set
    End Property

    Public Property NCTAVC() As String
        Get
            Return _NCTAVC
        End Get
        Set(ByVal Value As String)
            _NCTAVC = Value
        End Set
    End Property

    Public Property NCSLPE() As String
        Get
            Return _NCSLPE
        End Get
        Set(ByVal Value As String)
            _NCSLPE = Value
        End Set
    End Property

    Public Property NCTAV2() As String
        Get
            Return _NCTAV2
        End Get
        Set(ByVal value As String)
            _NCTAV2 = value
        End Set
    End Property

    Public Property NCSLP2() As String
        Get
            Return _NCSLP2
        End Get
        Set(ByVal value As String)
            _NCSLP2 = value
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

    Public Property CDVSN() As String
        Get
            Return _CDVSN
        End Get
        Set(ByVal Value As String)
            _CDVSN = Value
        End Set
    End Property

    Public Property CPLNDV() As Double
        Get
            Return _CPLNDV
        End Get
        Set(ByVal Value As Double)
            _CPLNDV = Value
        End Set
    End Property

    Public Property NORSRT() As Double
        Get
            Return _NORSRT
        End Get
        Set(ByVal Value As Double)
            _NORSRT = Value
        End Set
    End Property

    Public Property CTPOVJ() As String
        Get
            Return _CTPOVJ
        End Get
        Set(ByVal Value As String)
            _CTPOVJ = Value
        End Set
    End Property

#End Region
End Class
