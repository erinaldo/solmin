Public Class CuentaCorriente
    Inherits Base_BE

    Private _CTPODC As String = ""
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
    Private _NRUC As String = ""
    Private _CZNFCC As String = ""
    Private _CMNDA As String = ""
    Private _TSGNMN As String = ""
    Private _FechaInicio As String = ""
    Private _FechaFin As String = ""
    Private _TZNFCC As String = ""
    Private _NINDRN As Double = 0
    Private _ITTPGS As Double = 0
    Private _ITTPGD As Double = 0
    Private _Mensaje As String = ""
    Private _Estado As String = ""
    Private _PSEST_DOCANT As String = ""
    Private _EstadoSap As String = ""
    Private _CRGVTA As String = ""
    Private _PSEST_DOC As String = ""
    Private _NRLENC As Double = 1
    Private _FENT As Double = 0
    Private _FENCBD As Double = 0
    Private _FENTCL As Double = 0
    Private _CDSGDC As Decimal = 0
    Private _CPLNDV As String = ""
    Private _LISTA_PLANTA As String = ""
    Private _LISTA_REGIONVENTA As String = ""

    Private _PNCTPODC As Decimal = 0
    Private _PNNDCCTC As Decimal = 0
    Private _PSTFNCCR As String = ""
    Private _PNCCLNT As Decimal = 0

    Public Property PSCPLNDV() As String
        Get
            Return _CPLNDV
        End Get
        Set(ByVal value As String)
            _CPLNDV = value
        End Set
    End Property

    Private _ANIO As Decimal
    Public Property PNANIO() As Decimal
        Get
            Return _ANIO
        End Get
        Set(ByVal value As Decimal)
            _ANIO = value
        End Set
    End Property

    Property PNCDSGDC() As Double
        Get
            Return _CDSGDC
        End Get
        Set(ByVal value As Double)
            _CDSGDC = value
        End Set
    End Property

    Property CRGVTA() As String
        Get
            Return _CRGVTA
        End Get
        Set(ByVal value As String)
            _CRGVTA = value
        End Set
    End Property


    Property EstadoSap() As String
        Get
            Return _EstadoSap
        End Get
        Set(ByVal value As String)
            _EstadoSap = value
        End Set
    End Property

    Property ITTPGS() As Double
        Get
            Return _ITTPGS
        End Get
        Set(ByVal value As Double)
            _ITTPGS = value
        End Set
    End Property
    Property ITTPGD() As Double
        Get
            Return _ITTPGD
        End Get
        Set(ByVal value As Double)
            _ITTPGD = value
        End Set
    End Property
    Property NINDRN() As Double
        Get
            Return _NINDRN
        End Get
        Set(ByVal value As Double)
            _NINDRN = value
        End Set
    End Property
    Property Mensaje() As String
        Get
            Return _Mensaje
        End Get
        Set(ByVal value As String)
            _Mensaje = value
        End Set
    End Property
    Property Estado() As String
        Get
            Return _Estado
        End Get
        Set(ByVal value As String)
            _Estado = value
        End Set
    End Property

  

    Property TZNFCC() As String
        Get
            Return _TZNFCC
        End Get
        Set(ByVal value As String)
            _TZNFCC = value
        End Set
    End Property

    Property NRUC() As String
        Get
            Return _NRUC
        End Get
        Set(ByVal value As String)
            _NRUC = value
        End Set
    End Property

    Property FechaInicio() As String
        Get
            Return _FechaInicio
        End Get
        Set(ByVal value As String)
            _FechaInicio = value
        End Set
    End Property

    Property FechaFin() As String
        Get
            Return _FechaFin
        End Get
        Set(ByVal value As String)
            _FechaFin = value
        End Set
    End Property


    Property CZNFCC() As String
        Get
            Return _CZNFCC
        End Get
        Set(ByVal value As String)
            _CZNFCC = value
        End Set
    End Property
    Property CMNDA() As String
        Get
            Return _CMNDA
        End Get
        Set(ByVal value As String)
            _CMNDA = value
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

    Property CTPODC() As String
        Get
            Return _CTPODC
        End Get
        Set(ByVal value As String)
            _CTPODC = value
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


    Private _PSURSPDC As String
    Public Property PSURSPDC() As String
        Get
            Return _PSURSPDC
        End Get
        Set(ByVal value As String)
            _PSURSPDC = value
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

    Property PSEST_DOC() As String
        Get
            Return _PSEST_DOC
        End Get
        Set(ByVal value As String)
            _PSEST_DOC = value
        End Set
    End Property
    Property PSEST_DOCANT() As String
        Get
            Return _PSEST_DOCANT
        End Get
        Set(ByVal value As String)
            _PSEST_DOCANT = value
        End Set
    End Property

    Property NRLENC() As Double
        Get
            Return _NRLENC
        End Get
        Set(ByVal value As Double)
            _NRLENC = value
        End Set
    End Property

    Property FENT() As Double
        Get
            Return _FENT
        End Get
        Set(ByVal value As Double)
            _FENT = value
        End Set
    End Property

    Property FENCBD() As Double
        Get
            Return _FENCBD
        End Get
        Set(ByVal value As Double)
            _FENCBD = value
        End Set
    End Property
    Property FENTCL() As Double
        Get
            Return _FENTCL
        End Get
        Set(ByVal value As Double)
            _FENTCL = value
        End Set
    End Property

    Property CPLNDV() As String
        Get
            Return _CPLNDV
        End Get
        Set(ByVal value As String)
            _CPLNDV = value
        End Set
    End Property

    '_PSTFNCCR


    Property LISTA_PLANTA() As String
        Get
            Return _LISTA_PLANTA
        End Get
        Set(ByVal value As String)
            _LISTA_PLANTA = value
        End Set
    End Property

    Property LISTA_REGIONVENTA() As String
        Get
            Return _LISTA_REGIONVENTA
        End Get
        Set(ByVal value As String)
            _LISTA_REGIONVENTA = value
        End Set
    End Property


    Property PNCTPODC() As Decimal
        Get
            Return _PNCTPODC
        End Get
        Set(ByVal value As Decimal)
            _PNCTPODC = value
        End Set
    End Property

    Property PNNDCCTC() As Decimal
        Get
            Return _PNNDCCTC
        End Get
        Set(ByVal value As Decimal)
            _PNNDCCTC = value
        End Set
    End Property

    Property PSTFNCCR() As String
        Get
            Return _PSTFNCCR
        End Get
        Set(ByVal value As String)
            _PSTFNCCR = value
        End Set
    End Property

    Property PNCCLNT() As Decimal
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property


    Private _CRBCTC As Double
    Public Property CRBCTC() As Double
        Get
            Return _CRBCTC
        End Get
        Set(ByVal value As Double)
            _CRBCTC = value
        End Set
    End Property


End Class
