Namespace Operaciones
  Public Class Combustible

#Region "Atributo"

    Private _NSLCMB As Double = 0
    Private _FSLCMB As Double = 0
    Private _CCMPN As String = ""
    Private _CDVSN As String = ""
    Private _CPLNDV As Double = 0
    Private _NRUCTR As String = ""
    Private _TCMTRT As String = ""
    Private _NPLCUN As String = ""
    Private _CBRCNT As String = ""
    Private _CGRFO As Double = 0
    Private _FCRCMB As Double = 0
    Private _NVLGRF As Double = 0
    Private _QGLNCM As Double = 0
    Private _CSTGLN As Double = 0
    Private _CTPCMB As String = ""
    Private _NLQGST As Double = 0
    Private _FCHLQD As Double = 0
    Private _HRALQD As Double = 0
    Private _USRLQD As String = ""
    Private _SESSLC As String = ""
    Private _SESTRG As String = ""
    Private _FCHCRT As Double = 0
    Private _HRACRT As Double = 0
    Private _CUSCRT As String = ""
    Private _FULTAC As Double = 0
    Private _HULTAC As Double = 0
    Private _CULUSA As String = ""
    Private _NTRMNL As String = ""
    Private _FSLCMB_S As String = ""
    Private _FSLCMB_D As Date
    Private _FCHLQD_S As String = ""
    Private _FCRCMB_S As String = ""
    Private _FCRCMB_D As Date
    Private _HRALQD_S As String = ""
    Private _CBRCND As String = ""
    Private _TGRFO As String = ""
    Private _NLQCMB As Double = 0
    Private _NPRCN1 As String = ""
    Private _NPRCN2 As String = ""
    Private _NPRCN3 As String = ""
    Private _NRSCVL As Double = 0
    Private _CTRSPT As Double = 0
    Private _CTPOD1 As Int32 = 0
    Private _NDCCT1 As Int64 = 0
    Private _FDCCT1 As Int64 = 0
        Private _FDCCT1_S As String = ""
        Private _NOPRCN As String = ""
        Private _NGUIRM As Int64 = 0
        Private _NMVJCS As Double = 0

#End Region

#Region "Properties"

    Public Property NSLCMB() As Double
      Get
        Return _NSLCMB
      End Get
      Set(ByVal Value As Double)
        _NSLCMB = Value
      End Set
    End Property

    Public Property FSLCMB() As Double
      Get
        Return _FSLCMB
      End Get
      Set(ByVal Value As Double)
        _FSLCMB = Value
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

    Public Property NRUCTR() As String
      Get
        Return _NRUCTR
      End Get
      Set(ByVal Value As String)
        _NRUCTR = Value
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

    Public Property NPLCUN() As String
      Get
        Return _NPLCUN
      End Get
      Set(ByVal Value As String)
        _NPLCUN = Value
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

    Public Property CGRFO() As Double
      Get
        Return _CGRFO
      End Get
      Set(ByVal Value As Double)
        _CGRFO = Value
      End Set
    End Property

    Public Property FCRCMB() As Double
      Get
        Return _FCRCMB
      End Get
      Set(ByVal Value As Double)
        _FCRCMB = Value
      End Set
    End Property

    Public Property NVLGRF() As Double
      Get
        Return _NVLGRF
      End Get
      Set(ByVal Value As Double)
        _NVLGRF = Value
      End Set
    End Property

    Public Property QGLNCM() As Double
      Get
        Return _QGLNCM
      End Get
      Set(ByVal Value As Double)
        _QGLNCM = Value
      End Set
    End Property

    Public Property CSTGLN() As Double
      Get
        Return _CSTGLN
      End Get
      Set(ByVal Value As Double)
        _CSTGLN = Value
      End Set
    End Property

    Public Property CTPCMB() As String
      Get
        Return _CTPCMB
      End Get
      Set(ByVal Value As String)
        _CTPCMB = Value
      End Set
    End Property

    Public Property NLQGST() As Double
      Get
        Return _NLQGST
      End Get
      Set(ByVal Value As Double)
        _NLQGST = Value
      End Set
    End Property

    Public Property FCHLQD() As Double
      Get
        Return _FCHLQD
      End Get
      Set(ByVal Value As Double)
        _FCHLQD = Value
      End Set
    End Property

    Public Property HRALQD() As Double
      Get
        Return _HRALQD
      End Get
      Set(ByVal Value As Double)
        _HRALQD = Value
      End Set
    End Property

    Public Property USRLQD() As String
      Get
        Return _USRLQD
      End Get
      Set(ByVal Value As String)
        _USRLQD = Value
      End Set
    End Property

    Public Property SESSLC() As String
      Get
        Return _SESSLC
      End Get
      Set(ByVal Value As String)
        _SESSLC = Value
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

    Public Property CUSCRT() As String
      Get
        Return _CUSCRT
      End Get
      Set(ByVal Value As String)
        _CUSCRT = Value
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

    Public Property CULUSA() As String
      Get
        Return _CULUSA
      End Get
      Set(ByVal Value As String)
        _CULUSA = Value
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

    Public Property FSLCMB_S() As String
      Get
        Return _FSLCMB_S
      End Get
      Set(ByVal Value As String)
        _FSLCMB_S = Value
      End Set
    End Property

    Public Property FSLCMB_D() As Date
      Get
        Return _FSLCMB_D
      End Get
      Set(ByVal Value As Date)
        _FSLCMB_D = Value
      End Set
    End Property

    Public Property FCHLQD_S() As String
      Get
        Return _FCHLQD_S
      End Get
      Set(ByVal Value As String)
        _FCHLQD_S = Value
      End Set
    End Property

    Public Property FCRCMB_S() As String
      Get
        Return _FCRCMB_S
      End Get
      Set(ByVal Value As String)
        _FCRCMB_S = Value
      End Set
    End Property

    Public Property FCRCMB_D() As Date
      Get
        Return _FCRCMB_D
      End Get
      Set(ByVal Value As Date)
        _FCRCMB_D = Value
      End Set
    End Property

    Public Property HRALQD_S() As String
      Get
        Return _HRALQD_S
      End Get
      Set(ByVal Value As String)
        _HRALQD_S = Value
      End Set
    End Property

    Public Property CBRCND() As String
      Get
        Return _CBRCND
      End Get
      Set(ByVal Value As String)
        _CBRCND = Value
      End Set
    End Property

    Public Property TGRFO() As String
      Get
        Return _TGRFO
      End Get
      Set(ByVal Value As String)
        _TGRFO = Value
      End Set
    End Property

    Public Property NLQCMB() As Double
      Get
        Return _NLQCMB
      End Get
      Set(ByVal Value As Double)
        _NLQCMB = Value
      End Set
    End Property

    Public Property NRSCVL() As Double
      Get
        Return _NRSCVL
      End Get
      Set(ByVal Value As Double)
        _NRSCVL = Value
      End Set
    End Property

    Public Property NPRCN1() As String
      Get
        Return _NPRCN1
      End Get
      Set(ByVal value As String)
        _NPRCN1 = value
      End Set
    End Property

    Public Property NPRCN2() As String
      Get
        Return _NPRCN2
      End Get
      Set(ByVal value As String)
        _NPRCN2 = value
      End Set
    End Property

    Public Property NPRCN3() As String
      Get
        Return _NPRCN3
      End Get
      Set(ByVal value As String)
        _NPRCN3 = value
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

    Public Property CTPOD1() As Double
      Get
        Return _CTPOD1
      End Get
      Set(ByVal value As Double)
        _CTPOD1 = value
      End Set
    End Property

    Public Property NDCCT1() As Double
      Get
        Return _NDCCT1
      End Get
      Set(ByVal value As Double)
        _NDCCT1 = value
      End Set
    End Property

    Public Property FDCCT1() As Double
      Get
        Return _FDCCT1
      End Get
      Set(ByVal value As Double)
        _FDCCT1 = value
      End Set
    End Property

    Public Property FDCCT1_S() As String
      Get
        Return _FDCCT1_S
      End Get
      Set(ByVal value As String)
        _FDCCT1_S = value
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

        Public Property NGUIRM() As Int64
            Get
                Return _NGUIRM
            End Get
            Set(ByVal Value As Int64)
                _NGUIRM = Value
            End Set
        End Property

        Public Property NMVJCS() As Double
            Get
                Return _NMVJCS
            End Get
            Set(ByVal value As Double)
                _NMVJCS = value
            End Set
        End Property
#End Region

  End Class

End Namespace