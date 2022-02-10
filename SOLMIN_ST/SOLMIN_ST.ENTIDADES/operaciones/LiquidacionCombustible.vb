Namespace Operaciones

  Public Class LiquidacionCombustible

    Private _NLQCMB As Double = 0
    Private _FLQDCN As Double = 0
    Private _FLQDCN_S As String = ""
    Private _FLQDCN_D As Date
    Private _CTPCMB As String = ""
    Private _QGLNSA As Double = 0
    Private _QTGLIN As Double = 0
    Private _QGLNUT As Double = 0
    Private _CCMPN As String = ""
    Private _CDVSN As String = ""
    Private _CPLNDV As Double = 0
    Private _SESTRG As String = ""
    Private _FCHCRT As Double = 0
    Private _HRACRT As Double = 0
    Private _USRCRT As String = ""
    Private _FULTAC As Double = 0
    Private _HULTAC As Double = 0
    Private _CULUSA As String = ""
    Private _NTRMNL As String = ""

    Private _NOPRCN As Double = 0
    Private _NKMRCR As Double = 0
    Private _QGLNCM As Double = 0
    Private _CBRCNT As String = ""
    Private _CBRCND As String = ""
    Private _CCLNT As Double = 0
    Private _TCMPCL As String = ""
    Private _QTCSDA As Double = 0
    Private _QTCLLG As Double = 0
    Private _RUTA As String = ""
    Private _NPLCUN As String = ""
    Private _NRUCTR As String = ""
    Private _FCRCMB As Int64 = 0
    Private _FCRCMB_S As String = ""
    Private _NVLGRF As Int64 = 0
    Private _CGRFO As Int64 = 0
    Private _CSTGLN As Double = 0
    Private _ICSTOS As Double = 0

        Private _IMG As String = ""
        Private _EXT As String = ""
        Private _NIMPRT As Double = 0
        Private _TMRCTR As String = ""
        Private _ESTADO As String = ""
 
        Private _QGUREA As Decimal = 0
 
        Private _NRUCGR As Decimal = 0
        Private _TGRFO As String = ""

        Private _PMRCDR As Double = 0
        Private _TRFMRC As String = ""
        Private _NSLCMB As Double = 0
        Private _NPLCAC As String = ""
        Private _TCNFVH As String = ""

        Private _CENCOS As String = ""
        Private _CONDUCTOR As String = ""
        Private _NURRCR As Double = 0
        Private _NRNDUR As Double = 0
        Private _SENTIDO As String = ""

        Private _CTUREA As Decimal = 0
        Private _CSTTCB As Decimal = 0

        Public REF_GRIFO As String = ""
        Public NRUCPR As String = ""
        Public NVLGRS As String = ""
        Public GRIFO As String = ""
        Public NPRCN1 As String = ""
        Public NPRCN2 As String = ""
        Public NPRCN3 As String = ""
        Public PLACA As String = ""

#Region "Properties"

    Public Property NPLCUN() As String
      Get
        Return _NPLCUN
      End Get
      Set(ByVal value As String)
        _NPLCUN = value
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

    Public Property QTCSDA() As Double
      Get
        Return _QTCSDA
      End Get
      Set(ByVal value As Double)
        _QTCSDA = value
      End Set
    End Property

    Public Property QTCLLG() As Double
      Get
        Return _QTCLLG
      End Get
      Set(ByVal value As Double)
        _QTCLLG = value
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

    Public Property FLQDCN() As Double
      Get
        Return _FLQDCN
      End Get
      Set(ByVal Value As Double)
        _FLQDCN = Value
      End Set
    End Property

    Public Property FLQDCN_S() As String
      Get
        Return _FLQDCN_S
      End Get
      Set(ByVal Value As String)
        _FLQDCN_S = Value
      End Set
    End Property

    Public Property FLQDCN_D() As Date
      Get
        Return _FLQDCN_D
      End Get
      Set(ByVal Value As Date)
        _FLQDCN_D = Value
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

    Public Property QGLNSA() As Double
      Get
        Return _QGLNSA
      End Get
      Set(ByVal Value As Double)
        _QGLNSA = Value
      End Set
    End Property

    Public Property QTGLIN() As Double
      Get
        Return _QTGLIN
      End Get
      Set(ByVal Value As Double)
        _QTGLIN = Value
      End Set
    End Property

    Public Property QGLNUT() As Double
      Get
        Return _QGLNUT
      End Get
      Set(ByVal Value As Double)
        _QGLNUT = Value
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

    Public Property USRCRT() As String
      Get
        Return _USRCRT
      End Get
      Set(ByVal Value As String)
        _USRCRT = Value
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

    Public Property NOPRCN() As Double
      Get
        Return _NOPRCN
      End Get
      Set(ByVal Value As Double)
        _NOPRCN = Value
      End Set
    End Property

    Public Property NKMRCR() As Double
      Get
        Return _NKMRCR
      End Get
      Set(ByVal Value As Double)
        _NKMRCR = Value
      End Set
    End Property

        'Public Property QGLNCM() As Double
        '  Get
        '    Return _QGLNCM
        '  End Get
        '  Set(ByVal Value As Double)
        '    _QGLNCM = Value
        '  End Set
        'End Property

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

    Public Property CCLNT() As Double
      Get
        Return _CCLNT
      End Get
      Set(ByVal Value As Double)
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

    Public Property RUTA() As String
      Get
        Return _RUTA
      End Get
      Set(ByVal Value As String)
        _RUTA = Value
      End Set
    End Property

    Public Property FCRCMB() As Int64
      Get
        Return _FCRCMB
      End Get
      Set(ByVal value As Int64)
        _FCRCMB = value
      End Set
    End Property

    Public Property FCRCMB_S() As String
      Get
        Return _FCRCMB_S
      End Get
      Set(ByVal value As String)
        _FCRCMB_S = value
      End Set
    End Property

    Public Property NVLGRF() As Int64
      Get
        Return _NVLGRF
      End Get
      Set(ByVal value As Int64)
        _NVLGRF = value
      End Set
    End Property

    Public Property CGRFO() As Int64
      Get
        Return _CGRFO
      End Get
      Set(ByVal value As Int64)
        _CGRFO = value
      End Set
    End Property

    Public Property CSTGLN() As Double
      Get
        Return _CSTGLN
      End Get
      Set(ByVal value As Double)
        _CSTGLN = value
      End Set
    End Property

    Public Property ICSTOS() As Double
      Get
        Return _ICSTOS
      End Get
      Set(ByVal value As Double)
        _ICSTOS = value
      End Set
    End Property

        Public Property IMG() As String
            Get
                Return _IMG
            End Get
            Set(ByVal Value As String)
                _IMG = Value
            End Set
        End Property
        Public Property EXT() As String
            Get
                Return _EXT
            End Get
            Set(ByVal Value As String)
                _EXT = Value
            End Set
        End Property

        Public Property NIMPRT() As Double
            Get
                Return _NIMPRT
            End Get
            Set(ByVal Value As Double)
                _NIMPRT = Value
            End Set
        End Property
        Public Property TMRCTR() As String
            Get
                Return _TMRCTR
            End Get
            Set(VALUE As String)
                _TMRCTR = VALUE
            End Set
        End Property

        Public Property ESTADO() As String
            Get
                Return _ESTADO
            End Get
            Set(value As String)
                _ESTADO = value
            End Set
        End Property

        Public Property QGLNCM() As Decimal
            Get
                Return _QGLNCM
            End Get
            Set(ByVal Value As Decimal)
                _QGLNCM = Value
            End Set
        End Property

      
        Public Property QGUREA() As Decimal
            Get
                Return _QGUREA
            End Get
            Set(ByVal Value As Decimal)
                _QGUREA = Value
            End Set
        End Property

      
        Public Property NRUCGR() As Decimal
            Get
                Return _NRUCGR
            End Get
            Set(ByVal Value As Decimal)
                _NRUCGR = Value
            End Set
        End Property
         
     

        Public Property TCNFVH() As String
            Get
                Return _TCNFVH
            End Get
            Set(value As String)
                _TCNFVH = value
            End Set
        End Property
        Public Property NPLCAC() As String
            Get
                Return _NPLCAC
            End Get
            Set(value As String)
                _NPLCAC = value
            End Set
        End Property
        Public Property NSLCMB() As Double
            Get
                Return _NSLCMB
            End Get
            Set(value As Double)
                _NSLCMB = value
            End Set
        End Property
        Public Property TRFMRC() As String
            Get
                Return _TRFMRC
            End Get
            Set(value As String)
                _TRFMRC = value
            End Set
        End Property
        Public Property TGRFO() As String
            Get
                Return _TGRFO
            End Get
            Set(value As String)
                _TGRFO = value
            End Set
        End Property
        Public Property PMRCDR() As Double
            Get
                Return _PMRCDR
            End Get
            Set(value As Double)
                _PMRCDR = value
            End Set
        End Property

        Public Property SENTIDO() As String
            Get
                Return _SENTIDO
            End Get
            Set(value As String)
                _SENTIDO = value
            End Set
        End Property
        Public Property NRNDUR() As Double
            Get
                Return _NRNDUR
            End Get
            Set(value As Double)
                _NRNDUR = value
            End Set
        End Property
        Public Property NURRCR() As Double
            Get
                Return _NURRCR
            End Get
            Set(value As Double)
                _NURRCR = value
            End Set
        End Property
        Public Property CENCOS() As String
            Get
                Return _CENCOS
            End Get
            Set(value As String)
                _CENCOS = value
            End Set
        End Property

        Public Property CONDUCTOR() As String
            Get
                Return _CONDUCTOR
            End Get
            Set(ByVal value As String)
                _CONDUCTOR = value
            End Set
        End Property


        Public Property CTUREA() As Decimal
            Get
                Return _CTUREA
            End Get
            Set(value As Decimal)
                _CTUREA = value
            End Set
        End Property
        Public Property CSTTCB() As Decimal
            Get
                Return _CSTTCB
            End Get
            Set(value As Decimal)
                _CSTTCB = value
            End Set
        End Property

 
#End Region

  End Class

End Namespace
