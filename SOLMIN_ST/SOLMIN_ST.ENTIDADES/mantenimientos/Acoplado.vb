Namespace mantenimientos

    Public Class Acoplado

        Private _NPLCAC As String = ""
        Private _TCLRUN As String = ""
        Private _QPSTRA As Double = 0
        Private _NEJSUN As Double = 0
        Private _NCPCRU As Double = 0
        Private _NSRCHU As String = ""
        Private _QLNGAC As Double = 0
        Private _QANCAC As Double = 0
        Private _QALTAC As Double = 0
        Private _CTIACP As String = ""
        Private _SESTRG As String = ""
        Private _NRGMT2 As String = ""
        Private _TCNFG2 As String = ""
        Private _TMRCVH As String = ""
        Private _CUSCRT As String = ""
        Private _FCHCRT As Double = 0
        Private _HRACRT As Double = 0
        Private _NTRMCR As String = ""
        Private _CULUSA As String = ""
        Private _FULTAC As Double = 0
        Private _HULTAC As Double = 0
        Private _NTRMNL As String = ""
        Private _TDEACP As String = ""
        Private _CTRSPT As Double = 0
        Private _CCMPN As String = ""
        Private _TOBS As String = ""
        Private _CDVSN As String = ""
        Private _NRUCTR As String = ""
        Private _STPACP As String = ""
        Private _STPACP_S As String = ""
        Private _CPLNDV As Decimal = 0D
        Private _CONDICION As String = ""
        Private _FVALIN As String = ""
        Private _FVALFI As String = ""

        Private _NRALQT As String = ""
        Public Property CPLNDV() As Decimal
            Get
                Return _CPLNDV
            End Get
            Set(ByVal value As Decimal)
                _CPLNDV = value
            End Set
        End Property

        Public Property STPACP() As String
            Get
                Return _STPACP
            End Get
            Set(ByVal value As String)
                _STPACP = value
            End Set
        End Property

        Public Property STPACP_S() As String
            Get
                Return _STPACP_S
            End Get
            Set(ByVal value As String)
                _STPACP_S = value
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

        Public Property CDVSN() As String
            Get
                Return _CDVSN
            End Get
            Set(ByVal value As String)
                _CDVSN = value
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

        Public Property CCMPN() As String
            Get
                Return _CCMPN
            End Get
            Set(ByVal value As String)
                _CCMPN = value
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

        Public Property TDEACP() As String
            Get
                Return _TDEACP
            End Get
            Set(ByVal Value As String)
                _TDEACP = Value
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

        Public Property TCLRUN() As String
            Get
                Return _TCLRUN
            End Get
            Set(ByVal Value As String)
                _TCLRUN = Value
            End Set
        End Property

        Public Property QPSTRA() As Double
            Get
                Return _QPSTRA
            End Get
            Set(ByVal Value As Double)
                _QPSTRA = Value
            End Set
        End Property

        Public Property NEJSUN() As Double
            Get
                Return _NEJSUN
            End Get
            Set(ByVal Value As Double)
                _NEJSUN = Value
            End Set
        End Property

        Public Property NCPCRU() As Double
            Get
                Return _NCPCRU
            End Get
            Set(ByVal Value As Double)
                _NCPCRU = Value
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

        Public Property QLNGAC() As Double
            Get
                Return _QLNGAC
            End Get
            Set(ByVal Value As Double)
                _QLNGAC = Value
            End Set
        End Property

        Public Property QANCAC() As Double
            Get
                Return _QANCAC
            End Get
            Set(ByVal Value As Double)
                _QANCAC = Value
            End Set
        End Property

        Public Property QALTAC() As Double
            Get
                Return _QALTAC
            End Get
            Set(ByVal Value As Double)
                _QALTAC = Value
            End Set
        End Property

        Public Property CTIACP() As String
            Get
                Return _CTIACP
            End Get
            Set(ByVal Value As String)
                _CTIACP = Value
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

        Public Property NRGMT2() As String
            Get
                Return _NRGMT2
            End Get
            Set(ByVal Value As String)
                _NRGMT2 = Value
            End Set
        End Property

        Public Property TCNFG2() As String
            Get
                Return _TCNFG2
            End Get
            Set(ByVal Value As String)
                _TCNFG2 = Value
            End Set
        End Property

        Public Property TMRCVH() As String
            Get
                Return _TMRCVH
            End Get
            Set(ByVal Value As String)
                _TMRCVH = Value
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


        Public Property CONDICION() As String
            Get
                Return _CONDICION
            End Get
            Set(ByVal Value As String)
                _CONDICION = Value
            End Set
        End Property

        Public Property FVALIN() As String
            Get
                Return _FVALIN
            End Get
            Set(ByVal Value As String)
                _FVALIN = Value
            End Set
        End Property

        Public Property FVALFI() As String
            Get
                Return _FVALFI
            End Get
            Set(ByVal Value As String)
                _FVALFI = Value
            End Set
        End Property

        Public Property NRALQT() As String
            Get
                Return _NRALQT
            End Get
            Set(ByVal Value As String)
                _NRALQT = Value
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
        Public Property PAGENUMBER() As Decimal
            Get
                Return _PAGENUMBER
            End Get
            Set(ByVal value As Decimal)
                _PAGENUMBER = value
            End Set
        End Property

        

    End Class

End Namespace