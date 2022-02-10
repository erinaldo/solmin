Namespace mantenimientos

    Public Class Tracto
        Private _NPLCUN As String = ""
        Private _NEJSUN As String = ""
        Private _NSRCHU As String = ""
        Private _NSRMTU As String = ""
        Private _FFBRUN As String = ""
        Private _TCLRUN As String = ""
        Private _TCRRUN As String = ""
        Private _NCPCRU As String = ""
        Private _CTITRA As String = ""
        Private _QPSOTR As String = ""
        Private _TMRCTR As String = ""
        Private _NRGMT1 As String = ""
        Private _NTERPM As String = ""
        Private _SESOPV As String = ""
        Private _SESTRG As String = ""
        Private _CUSCRT As String = ""
        Private _FCHCRT As Double = 0
        Private _HRACRT As Double = 0
        Private _NTRMCR As String = ""
        Private _CULUSA As String = ""
        Private _FULTAC As Double = 0
        Private _HULTAC As Double = 0
        Private _NTRMNL As String = ""
        Private _TOBS As String = ""
        Private _NPLCAC As String = ""
        Private _CBRCNT As String = ""
        Private _CBRCND As String = ""
        Private _TDETRA As String = ""
        Private _CTRSPT As Double = 0
        Private _CCMPN As String
        Private _CDVSN As String
        Private _CPLNDV As Double
        Private _NRUCTR As String = ""
        Private _TCMCND As String = ""
        Private _FECSEG As Double = 0
        Private _HRASEG As Double = 0
        Private _TDSDES As String = ""
        Private _NMRCRL As Double = 0
        Private _FECSEG_S As String = ""
        Private _CTPCRA As Double = 0
        Private _FECGPS As String = ""
        Private _SEGWAP As String = ""
        Private _GPSLAT As String = ""
        Private _GPSLON As String = ""
        Private _HORGPS As String = ""
        Private _NRITEM As Double = 0

        Private _STPVHP As String = ""
        Private _STPVHP_S As String = ""

        Public Property STPVHP() As String
            Get
                Return _STPVHP
            End Get
            Set(ByVal value As String)
                _STPVHP = value
            End Set
        End Property

        Public Property STPVHP_S() As String
            Get
                Return _STPVHP_S
            End Get
            Set(ByVal value As String)
                _STPVHP_S = value
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

        Public Property CCMPN() As String
            Get
                Return _CCMPN
            End Get
            Set(ByVal value As String)
                _CCMPN = value
            End Set
        End Property

        Public Property CDVSN() As String
            Get
                Return _CDVSN
            End Get
            Set(ByVal value As String)
                _CDVSN = value
            End Set
        End Property

        Public Property CPLNDV() As Double
            Get
                Return _CPLNDV
            End Get
            Set(ByVal value As Double)
                _CPLNDV = value
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

        Public Property TDETRA() As String
            Get
                Return _TDETRA
            End Get
            Set(ByVal value As String)
                _TDETRA = value
            End Set
        End Property

        Public Property TOBS() As String
            Get
                Return _TOBS
            End Get
            Set(ByVal value As String)
                _TOBS = value
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

        Public Property NEJSUN() As String
            Get
                Return _NEJSUN
            End Get
            Set(ByVal Value As String)
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

        Public Property FFBRUN() As String
            Get
                Return _FFBRUN
            End Get
            Set(ByVal Value As String)
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

        Public Property NCPCRU() As String
            Get
                Return _NCPCRU
            End Get
            Set(ByVal Value As String)
                _NCPCRU = Value
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

        Public Property QPSOTR() As String
            Get
                Return _QPSOTR
            End Get
            Set(ByVal Value As String)
                _QPSOTR = Value
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

        Public Property NRGMT1() As String
            Get
                Return _NRGMT1
            End Get
            Set(ByVal Value As String)
                _NRGMT1 = Value
            End Set
        End Property

        Public Property NTERPM() As String
            Get
                Return _NTERPM
            End Get
            Set(ByVal Value As String)
                _NTERPM = Value
            End Set
        End Property

        Public Property SESOPV() As String
            Get
                Return _SESOPV
            End Get
            Set(ByVal Value As String)
                _SESOPV = Value
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

        Public Property CBRCND() As String
            Get
                Return _CBRCND
            End Get
            Set(ByVal Value As String)
                _CBRCND = Value
            End Set
        End Property

        Public Property TCMCND() As String
            Get
                Return _TCMCND
            End Get
            Set(ByVal value As String)
                _TCMCND = value
            End Set
        End Property

        Public Property FECSEG() As Double
            Get
                Return _FECSEG
            End Get
            Set(ByVal value As Double)
                _FECSEG = value
            End Set
        End Property

        Public Property HRASEG() As Double
            Get
                Return _HRASEG
            End Get
            Set(ByVal value As Double)
                _HRASEG = value
            End Set
        End Property

        Public Property TDSDES() As String
            Get
                Return _TDSDES
            End Get
            Set(ByVal value As String)
                _TDSDES = value
            End Set
        End Property

        Public Property NMRCRL() As Double
            Get
                Return _NMRCRL
            End Get
            Set(ByVal value As Double)
                _NMRCRL = value
            End Set
        End Property

        Public Property FECSEG_S() As String
            Get
                Return _FECSEG_S
            End Get
            Set(ByVal Value As String)
                _FECSEG_S = Value
            End Set
        End Property

        Public Property CTPCRA() As Double
            Get
                Return _CTPCRA
            End Get
            Set(ByVal value As Double)
                _CTPCRA = value
            End Set
        End Property

        Public Property FECGPS() As String
            Get
                Return _FECGPS
            End Get
            Set(ByVal value As String)
                _FECGPS = value
            End Set
        End Property

        Public Property SEGWAP() As String
            Get
                Return _SEGWAP
            End Get
            Set(ByVal value As String)
                _SEGWAP = value
            End Set
        End Property

        Public Property GPSLAT() As String
            Get
                Return _GPSLAT
            End Get
            Set(ByVal value As String)
                _GPSLAT = value
            End Set
        End Property

        Public Property GPSLON() As String
            Get
                Return _GPSLON
            End Get
            Set(ByVal value As String)
                _GPSLON = value
            End Set
        End Property

        Public Property HORGPS() As String
            Get
                Return _HORGPS
            End Get
            Set(ByVal value As String)
                _HORGPS = value
            End Set
        End Property

        Public Property NRITEM() As Double
            Get
                Return _NRITEM
            End Get
            Set(ByVal value As Double)
                _NRITEM = value
            End Set
        End Property


        Private _PAGESIZE As Decimal = 0
        Public Property PAGESIZE() As Decimal
            Get
                Return _PAGESIZE
            End Get
            Set(ByVal value As Decimal)
                _PAGESIZE = value
            End Set
        End Property
        Private _PAGENUMBER As Decimal = 0
        Public Property PAGENUMBER() As String
            Get
                Return _PAGENUMBER
            End Get
            Set(ByVal value As String)
                _PAGENUMBER = value
            End Set
        End Property

    End Class


    

    

End Namespace