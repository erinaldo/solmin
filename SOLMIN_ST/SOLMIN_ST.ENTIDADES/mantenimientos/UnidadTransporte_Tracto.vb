Namespace mantenimientos

    Public Class UnidadTransporte_Tracto

        Private _CTRSPT As Long = 0
        Private _NPLCUN As String = ""
        Private _NEJSUN As Long = 0
        Private _NSRCHU As String = ""
        Private _NSRMTU As String = ""
        Private _FFBRUN As Long = 0
        Private _TCLRUN As String = ""
        Private _TCRRUN As String = ""
        Private _NCPCRU As Long = 0
        Private _FINPUN As Long = 0
        Private _SINPUN As String = ""
        Private _TOBSIN As String = ""
        Private _FPRXDS As Long = 0
        Private _STPOUN As String = ""
        Private _SESTUN As String = ""
        Private _QPSOTR As Long = 0
        Private _QVLTTR As Long = 0
        Private _STMFRA As String = ""
        Private _TMRCTR As String = ""
        Private _NPLCAC As String = ""
        Private _CBRCNT As String = ""
        Private _FULASG As Long = 0
        Private _SDCMPR As String = ""
        Private _SUNVNR As String = ""
        Private _FULTAC As Long = 0
        Private _HULTAC As Long = 0
        Private _CULUSA As String = ""
        Private _NTRMNL As String = ""
        Private _CUSCRT As String = ""
        Private _FCHCRT As Long = 0
        Private _HRACRT As Long = 0
        Private _NTRMCR As String = ""
        Private _CIDMVL As Long = 0
        Private _STPVHT As String = ""
        Private _QTCACT As Long = 0
        Private _QTCANT As Long = 0
        Private _NULGUN As Long = 0
        Private _NRGMT1 As String = ""
        Private _TCNFG1 As String = ""
        Private _HRAINR As Long = 0
        Private _SUSOVH As String = ""
        Private _CTPUNV As String = ""
        Private _CLVVEH As Long = 0
        Private _NCRHB1 As String = ""
        Private _NORINS As Long = 0
        Private _CCMPN As String = ""
        Public Property CCMPN() As String
            Get
                Return _CCMPN
            End Get
            Set(ByVal value As String)
                _CCMPN = value
            End Set
        End Property
        Public Property CTRSPT() As Long
            Get
                Return _CTRSPT
            End Get
            Set(ByVal Value As Long)
                _CTRSPT = Value
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

        Public Property NEJSUN() As Long
            Get
                Return _NEJSUN
            End Get
            Set(ByVal Value As Long)
                _NEJSUN = Value
            End Set
        End Property

        Public Property NSRCHU() As String
            Get
                Return _NSRCHU
            End Get
            Set(ByVal Value As String)
                _NSRCHU = Value
            End Set
        End Property

        Public Property NSRMTU() As String
            Get
                Return _NSRMTU
            End Get
            Set(ByVal Value As String)
                _NSRMTU = Value
            End Set
        End Property

        Public Property FFBRUN() As Long
            Get
                Return _FFBRUN
            End Get
            Set(ByVal Value As Long)
                _FFBRUN = Value
            End Set
        End Property

        Public Property TCLRUN() As String
            Get
                Return _TCLRUN
            End Get
            Set(ByVal Value As String)
                _TCLRUN = Value
            End Set
        End Property

        Public Property TCRRUN() As String
            Get
                Return _TCRRUN
            End Get
            Set(ByVal Value As String)
                _TCRRUN = Value
            End Set
        End Property

        Public Property NCPCRU() As Long
            Get
                Return _NCPCRU
            End Get
            Set(ByVal Value As Long)
                _NCPCRU = Value
            End Set
        End Property

        Public Property FINPUN() As Long
            Get
                Return _FINPUN
            End Get
            Set(ByVal Value As Long)
                _FINPUN = Value
            End Set
        End Property

        Public Property SINPUN() As String
            Get
                Return _SINPUN
            End Get
            Set(ByVal Value As String)
                _SINPUN = Value
            End Set
        End Property

        Public Property TOBSIN() As String
            Get
                Return _TOBSIN
            End Get
            Set(ByVal Value As String)
                _TOBSIN = Value
            End Set
        End Property

        Public Property FPRXDS() As Long
            Get
                Return _FPRXDS
            End Get
            Set(ByVal Value As Long)
                _FPRXDS = Value
            End Set
        End Property

        Public Property STPOUN() As String
            Get
                Return _STPOUN
            End Get
            Set(ByVal Value As String)
                _STPOUN = Value
            End Set
        End Property

        Public Property SESTUN() As String
            Get
                Return _SESTUN
            End Get
            Set(ByVal Value As String)
                _SESTUN = Value
            End Set
        End Property

        Public Property QPSOTR() As Long
            Get
                Return _QPSOTR
            End Get
            Set(ByVal Value As Long)
                _QPSOTR = Value
            End Set
        End Property

        Public Property QVLTTR() As Long
            Get
                Return _QVLTTR
            End Get
            Set(ByVal Value As Long)
                _QVLTTR = Value
            End Set
        End Property

        Public Property STMFRA() As String
            Get
                Return _STMFRA
            End Get
            Set(ByVal Value As String)
                _STMFRA = Value
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

        Public Property FULASG() As Long
            Get
                Return _FULASG
            End Get
            Set(ByVal Value As Long)
                _FULASG = Value
            End Set
        End Property

        Public Property SDCMPR() As String
            Get
                Return _SDCMPR
            End Get
            Set(ByVal Value As String)
                _SDCMPR = Value
            End Set
        End Property

        Public Property SUNVNR() As String
            Get
                Return _SUNVNR
            End Get
            Set(ByVal Value As String)
                _SUNVNR = Value
            End Set
        End Property

        Public Property FULTAC() As Long
            Get
                Return _FULTAC
            End Get
            Set(ByVal Value As Long)
                _FULTAC = Value
            End Set
        End Property

        Public Property HULTAC() As Long
            Get
                Return _HULTAC
            End Get
            Set(ByVal Value As Long)
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

        Public Property CUSCRT() As String
            Get
                Return _CUSCRT
            End Get
            Set(ByVal Value As String)
                _CUSCRT = Value
            End Set
        End Property

        Public Property FCHCRT() As Long
            Get
                Return _FCHCRT
            End Get
            Set(ByVal Value As Long)
                _FCHCRT = Value
            End Set
        End Property

        Public Property HRACRT() As Long
            Get
                Return _HRACRT
            End Get
            Set(ByVal Value As Long)
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

        Public Property CIDMVL() As Long
            Get
                Return _CIDMVL
            End Get
            Set(ByVal Value As Long)
                _CIDMVL = Value
            End Set
        End Property

        Public Property STPVHT() As String
            Get
                Return _STPVHT
            End Get
            Set(ByVal Value As String)
                _STPVHT = Value
            End Set
        End Property

        Public Property QTCACT() As Long
            Get
                Return _QTCACT
            End Get
            Set(ByVal Value As Long)
                _QTCACT = Value
            End Set
        End Property

        Public Property QTCANT() As Long
            Get
                Return _QTCANT
            End Get
            Set(ByVal Value As Long)
                _QTCANT = Value
            End Set
        End Property

        Public Property NULGUN() As Long
            Get
                Return _NULGUN
            End Get
            Set(ByVal Value As Long)
                _NULGUN = Value
            End Set
        End Property

        Public Property NRGMT1() As String
            Get
                Return _NRGMT1
            End Get
            Set(ByVal Value As String)
                _NRGMT1 = Value
            End Set
        End Property

        Public Property TCNFG1() As String
            Get
                Return _TCNFG1
            End Get
            Set(ByVal Value As String)
                _TCNFG1 = Value
            End Set
        End Property

        Public Property HRAINR() As Long
            Get
                Return _HRAINR
            End Get
            Set(ByVal Value As Long)
                _HRAINR = Value
            End Set
        End Property

        Public Property SUSOVH() As String
            Get
                Return _SUSOVH
            End Get
            Set(ByVal Value As String)
                _SUSOVH = Value
            End Set
        End Property

        Public Property CTPUNV() As String
            Get
                Return _CTPUNV
            End Get
            Set(ByVal Value As String)
                _CTPUNV = Value
            End Set
        End Property

        Public Property CLVVEH() As Long
            Get
                Return _CLVVEH
            End Get
            Set(ByVal Value As Long)
                _CLVVEH = Value
            End Set
        End Property

        Public Property NCRHB1() As String
            Get
                Return _NCRHB1
            End Get
            Set(ByVal Value As String)
                _NCRHB1 = Value
            End Set
        End Property

        Public Property NORINS() As Long
            Get
                Return _NORINS
            End Get
            Set(ByVal Value As Long)
                _NORINS = Value
            End Set
        End Property


    End Class

End Namespace