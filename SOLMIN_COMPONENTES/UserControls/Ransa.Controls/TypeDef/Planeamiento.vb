
Public Class Planeamiento

    Private _NPLNMT As Double = 0
    Private _NCRRPL As Double = 0
    Private _TOBSRC As String = ""
    Private _TOBSRC_S As String = ""
    Private _SESTRC As String = ""
    Private _SESTRC_S As String = ""
    Private _CTRSPT As Double = 0
    Private _NPLCTR As String = ""
    Private _NPLCAC As String = ""
    Private _CBRCNT As String = ""
    Private _TNMBCH As String = ""
    Private _CCMPN As String = ""
    Private _CDVSN As String = ""
    Private _CPLNDV As Double = 0
    Private _NORINS As Int64 = 0
    Private _NSBCRP As Integer = 0
    Private _CRCRSO As Integer = 0
    Private _CRCRSO_S As String = ""
    Private _CCLNT As Integer = 0
    Private _FINCPL As Integer = 0
    Private _TDSCPL As String = ""
    Private _SDSCPL As String = ""
    Private _SESPLN As String = ""
    Private _QTTLTM As Integer = 0
    Private _NVJDAO As Integer = 0
    Private _NDSOPR As Integer = 0
    Private _NUNDOP As Integer = 0
    Private _QPSPRU As Integer = 0
    Private _SCNTR As String = ""
    Private _FULTAC As Integer = 0
    Private _HULTAC As Integer = 0
    Private _CULUSA As String = ""
    Private _NTRMNL As String = ""
    Private _CUSCRT As String = ""
    Private _FCHCRT As Integer = 0
    Private _HRACRT As Integer = 0
    Private _NTRMCR As String = ""
    Private _NORSRT As String = ""
    Private _NOPRCN As String = ""
    Private _NRUCTR As String = ""
    Private _TCMTRT As String = ""
    Private _CLCLOR As String = ""
    Private _CLCLDS As String = ""
    Private _NCTZCN As String = ""
    Private _NCRRCT As String = ""
    Private _NCRRSR As String = ""
    Private _TCNFVH As String = ""
    Private _SRCRSO As String = ""
    Private _CUNDMD As String = ""
    Private _CMNTRN As String = ""
    Private _MAXSUBCORRELATIVO As Int32
    Public Property MAXSUBCORRELATIVO() As Int32
        Get
            Return _MAXSUBCORRELATIVO
        End Get
        Set(ByVal value As Int32)
            _MAXSUBCORRELATIVO = value
        End Set
    End Property
    Public Property CMNTRN() As String
        Get
            Return _CMNTRN
        End Get
        Set(ByVal value As String)
            _CMNTRN = value
        End Set
    End Property
    Public Property CUNDMD() As String
        Get
            Return _CUNDMD
        End Get
        Set(ByVal value As String)
            _CUNDMD = value
        End Set
    End Property
    Public Property SRCRSO() As String
        Get
            Return _SRCRSO
        End Get
        Set(ByVal value As String)
            _SRCRSO = value
        End Set
    End Property
    Public Property TCNFVH() As String
        Get
            Return _TCNFVH
        End Get
        Set(ByVal value As String)
            _TCNFVH = value
        End Set
    End Property
    Public Property NCRRSR() As String
        Get
            Return _NCRRSR
        End Get
        Set(ByVal value As String)
            _NCRRSR = value
        End Set
    End Property
    Public Property NCRRCT() As String
        Get
            Return _NCRRCT
        End Get
        Set(ByVal value As String)
            _NCRRCT = value
        End Set
    End Property
    Public Property NCTZCN() As String
        Get
            Return _NCTZCN
        End Get
        Set(ByVal value As String)
            _NCTZCN = value
        End Set
    End Property
    Public Property CLCLDS() As String
        Get
            Return _CLCLDS
        End Get
        Set(ByVal value As String)
            _CLCLDS = value
        End Set
    End Property
    Public Property CLCLOR() As String
        Get
            Return _CLCLOR
        End Get
        Set(ByVal value As String)
            _CLCLOR = value
        End Set
    End Property
    Public Property TCMTRT() As String
        Get
            Return _TCMTRT
        End Get
        Set(ByVal value As String)
            _TCMTRT = value
        End Set
    End Property
    Public Property NRUCTR() As String
        Get
            Return _NRUCTR
        End Get
        Set(ByVal value As String)
            _NRUCTR = value
        End Set
    End Property
    Public Property NORSRT() As String
        Get
            Return _NORSRT
        End Get
        Set(ByVal value As String)
            _NORSRT = value
        End Set
    End Property
    Public Property NOPRCN() As String
        Get
            Return _NOPRCN
        End Get
        Set(ByVal value As String)
            _NOPRCN = value
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

    Public Property HRACRT() As Integer
        Get
            Return _HRACRT
        End Get
        Set(ByVal Value As Integer)
            _HRACRT = Value
        End Set
    End Property

    Public Property FCHCRT() As Integer
        Get
            Return _FCHCRT
        End Get
        Set(ByVal Value As Integer)
            _FCHCRT = Value
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

    Public Property NTRMNL() As String
        Get
            Return _NTRMNL
        End Get
        Set(ByVal Value As String)
            _NTRMNL = Value
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

    Public Property HULTAC() As Integer
        Get
            Return _HULTAC
        End Get
        Set(ByVal Value As Integer)
            _HULTAC = Value
        End Set
    End Property

    Public Property FULTAC() As Integer
        Get
            Return _FULTAC
        End Get
        Set(ByVal Value As Integer)
            _FULTAC = Value
        End Set
    End Property

    Public Property SCNTR() As String
        Get
            Return _SCNTR
        End Get
        Set(ByVal Value As String)
            _SCNTR = Value
        End Set
    End Property

    Public Property QPSPRU() As Integer
        Get
            Return _QPSPRU
        End Get
        Set(ByVal Value As Integer)
            _QPSPRU = Value
        End Set
    End Property

    Public Property NUNDOP() As Integer
        Get
            Return _NUNDOP
        End Get
        Set(ByVal Value As Integer)
            _NUNDOP = Value
        End Set
    End Property

    Public Property NDSOPR() As Integer
        Get
            Return _NDSOPR
        End Get
        Set(ByVal Value As Integer)
            _NDSOPR = Value
        End Set
    End Property

    Public Property NVJDAO() As Integer
        Get
            Return _NVJDAO
        End Get
        Set(ByVal Value As Integer)
            _NVJDAO = Value
        End Set
    End Property

    Public Property QTTLTM() As Integer
        Get
            Return _QTTLTM
        End Get
        Set(ByVal Value As Integer)
            _QTTLTM = Value
        End Set
    End Property

    Public Property SESPLN() As String
        Get
            Return _SESPLN
        End Get
        Set(ByVal Value As String)
            _SESPLN = Value
        End Set
    End Property

    Public Property TDSCPL() As String
        Get
            Return _TDSCPL
        End Get
        Set(ByVal Value As String)
            _TDSCPL = Value
        End Set
    End Property

    Public Property FINCPL() As Integer
        Get
            Return _FINCPL
        End Get
        Set(ByVal Value As Integer)
            _FINCPL = Value
        End Set
    End Property

    Public Property CCLNT() As Integer
        Get
            Return _CCLNT
        End Get
        Set(ByVal Value As Integer)
            _CCLNT = Value
        End Set
    End Property

    Public Property NORINS() As Int64
        Get
            Return _NORINS
        End Get
        Set(ByVal value As Int64)
            _NORINS = value
        End Set
    End Property

    Public Property CRCRSO() As Integer
        Get
            Return _CRCRSO
        End Get
        Set(ByVal value As Integer)
            _CRCRSO = value
        End Set
    End Property

    Public Property NSBCRP() As Integer
        Get
            Return _NSBCRP
        End Get
        Set(ByVal value As Integer)
            _NSBCRP = value
        End Set
    End Property


    Public Property NPLNMT() As Double
        Get
            Return _NPLNMT
        End Get
        Set(ByVal value As Double)
            _NPLNMT = value
        End Set
    End Property

    Public Property NCRRPL() As Double
        Get
            Return _NCRRPL
        End Get
        Set(ByVal value As Double)
            _NCRRPL = value
        End Set
    End Property

    Public Property TOBSRC() As Double
        Get
            Return _TOBSRC
        End Get
        Set(ByVal value As Double)
            _TOBSRC = value
        End Set
    End Property

    Public Property TOBSRC_S() As String
        Get
            Return _TOBSRC_S
        End Get
        Set(ByVal value As String)
            _TOBSRC_S = value
        End Set
    End Property

    Public Property SESTRC() As Double
        Get
            Return _SESTRC
        End Get
        Set(ByVal value As Double)
            _SESTRC = value
        End Set
    End Property

    Public Property CTRSPT() As Double
        Get
            Return _CTRSPT
        End Get
        Set(ByVal value As Double)
            _CTRSPT = value
        End Set
    End Property

    Public Property NPLCTR() As String
        Get
            Return _NPLCTR
        End Get
        Set(ByVal value As String)
            _NPLCTR = value
        End Set
    End Property

    Public Property NPLCAC() As String
        Get
            Return _NPLCAC
        End Get
        Set(ByVal value As String)
            _NPLCAC = value
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

    Public Property TNMBCH() As String
        Get
            Return _TNMBCH
        End Get
        Set(ByVal value As String)
            _TNMBCH = value
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
    Public Property SESTRC_S() As String
        Get
            Return _SESTRC_S
        End Get
        Set(ByVal Value As String)
            _SESTRC_S = Value
        End Set
    End Property

    Public Property CRCRSO_S() As String
        Get
            Return _CRCRSO_S
        End Get
        Set(ByVal Value As String)
            _CRCRSO_S = Value
        End Set
    End Property


End Class
