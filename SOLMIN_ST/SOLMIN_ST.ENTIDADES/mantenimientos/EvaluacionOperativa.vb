Public Class EvaluacionOperativa

    Private _NSEQIN As Decimal = 0
    Private _CCMPN As String = ""
    Private _NRUCTR As String = ""
    Private _CODCAT As Decimal = 0
    Private _CODSCT As Decimal = 0
    Private _FOPRCN As Decimal = 0
    Private _NOPRCN As Decimal = 0
    Private _NGUITR As Decimal = 0
    Private _QAINSM As Decimal = 0
    Private _TOBS As String = ""
    Private _FCHCRT As Decimal = 0
    Private _HRACRT As Decimal = 0
    Private _CUSCRT As String = ""
    Private _NTRMCR As String = ""
    Private _FULTAC As Decimal = 0
    Private _HULTAC As Decimal = 0
    Private _CULUSA As String = ""
    Private _SESTRG As String = ""

    Private _DESCAT As String = ""
    Private _DESSCT As String = ""

    Private _FACCAT As Decimal = 0
    Private _FACSCT As Decimal = 0
    Private _TCMTRT As String = ""

    Private _NTRMNL As String = ""
    Private _TIPCAT As Decimal = 0

    Private _NOMMES As String = ""

    Private _FOPRCN_S As String = ""
    Private _FCHCRT_S As String = ""
    Private _HRACRT_S As String = ""
    Private _FULTAC_S As String = ""
    Private _HULTAC_S As String = ""



    Private _CRGVTA As String
    Public Property CRGVTA() As String
        Get
            Return _CRGVTA
        End Get
        Set(ByVal value As String)
            _CRGVTA = value
        End Set
    End Property


    Private _TCRVTA As String
    Public Property TCRVTA() As String
        Get
            Return _TCRVTA
        End Get
        Set(ByVal value As String)
            _TCRVTA = value
        End Set
    End Property

    Public Property NSEQIN() As Decimal
        Get
            Return _NSEQIN
        End Get
        Set(ByVal value As Decimal)
            _NSEQIN = value
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

    Public Property NRUCTR() As String
        Get
            Return _NRUCTR
        End Get
        Set(ByVal value As String)
            _NRUCTR = value
        End Set
    End Property

    Public Property CODCAT() As Decimal
        Get
            Return _CODCAT
        End Get
        Set(ByVal value As Decimal)
            _CODCAT = value
        End Set
    End Property

    Public Property CODSCT() As Decimal
        Get
            Return _CODSCT
        End Get
        Set(ByVal value As Decimal)
            _CODSCT = value
        End Set
    End Property

    Public Property FOPRCN() As Decimal
        Get
            Return _FOPRCN
        End Get
        Set(ByVal value As Decimal)
            _FOPRCN = value
        End Set
    End Property
    Public Property FOPRCN_S() As String
        Get
            Return _FOPRCN_S
        End Get
        Set(ByVal value As String)
            _FOPRCN_S = value
        End Set
    End Property

    Public Property NOPRCN() As Decimal
        Get
            Return _NOPRCN
        End Get
        Set(ByVal value As Decimal)
            _NOPRCN = value
        End Set
    End Property

    Public Property NGUITR() As Decimal
        Get
            Return _NGUITR
        End Get
        Set(ByVal value As Decimal)
            _NGUITR = value
        End Set
    End Property

    Public Property QAINSM() As Decimal
        Get
            Return _QAINSM
        End Get
        Set(ByVal value As Decimal)
            _QAINSM = value
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
    Public Property NOMMES() As String
        Get
            Return _NOMMES
        End Get
        Set(ByVal value As String)
            _NOMMES = value
        End Set
    End Property
    Public Property FCHCRT() As Decimal
        Get
            Return _FCHCRT
        End Get
        Set(ByVal value As Decimal)
            _FCHCRT = value
        End Set
    End Property

    Public Property FCHCRT_S() As String
        Get
            Return _FCHCRT_S
        End Get
        Set(ByVal value As String)
            _FCHCRT_S = value
        End Set
    End Property

    Public Property HRACRT() As Decimal
        Get
            Return _HRACRT
        End Get
        Set(ByVal value As Decimal)
            _HRACRT = value
        End Set
    End Property

    Public Property HRACRT_S() As String
        Get
            Return _HRACRT_S
        End Get
        Set(ByVal value As String)
            _HRACRT_S = value
        End Set
    End Property

    Public Property CUSCRT() As String
        Get
            Return _CUSCRT
        End Get
        Set(ByVal value As String)
            _CUSCRT = value
        End Set
    End Property

    Public Property FULTAC() As Decimal
        Get
            Return _FULTAC
        End Get
        Set(ByVal value As Decimal)
            _FULTAC = value
        End Set
    End Property

    Public Property FULTAC_S() As String
        Get
            Return _FULTAC_S
        End Get
        Set(ByVal value As String)
            _FULTAC_S = value
        End Set
    End Property

    Public Property HULTAC() As Decimal
        Get
            Return _HULTAC
        End Get
        Set(ByVal value As Decimal)
            _HULTAC = value
        End Set
    End Property

    Public Property HULTAC_S() As String
        Get
            Return _HULTAC_S
        End Get
        Set(ByVal value As String)
            _HULTAC_S = value
        End Set
    End Property

    Public Property CULUSA() As String
        Get
            Return _CULUSA
        End Get
        Set(ByVal value As String)
            _CULUSA = value
        End Set
    End Property

    Public Property SESTRG() As String
        Get
            Return _SESTRG
        End Get
        Set(ByVal value As String)
            _SESTRG = value
        End Set
    End Property

    Public Property DESCAT() As String
        Get
            Return _DESCAT
        End Get
        Set(ByVal value As String)
            _DESCAT = value
        End Set
    End Property

    Public Property DESSCT() As String
        Get
            Return _DESSCT
        End Get
        Set(ByVal value As String)
            _DESSCT = value
        End Set
    End Property

    Public Property FACCAT() As Decimal
        Get
            Return _FACCAT
        End Get
        Set(ByVal value As Decimal)
            _FACCAT = value
        End Set
    End Property
    Public Property FACSCT() As Decimal
        Get
            Return _FACSCT
        End Get
        Set(ByVal value As Decimal)
            _FACSCT = value
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

    Public Property NTRMCR() As String
        Get
            Return _NTRMCR
        End Get
        Set(ByVal value As String)
            _NTRMCR = value
        End Set
    End Property


    Public Property NTRMNL() As String
        Get
            Return _NTRMNL
        End Get
        Set(ByVal value As String)
            _NTRMNL = value
        End Set
    End Property

    Public Property TIPCAT() As Decimal
        Get
            Return _TIPCAT
        End Get
        Set(ByVal value As Decimal)
            _TIPCAT = value

        End Set
    End Property

#Region "Parametros de Bussqueda"
    Private _ANIO As Decimal = 0
    Private _ANIOMES As Decimal = 0
    Private _MES As Decimal = 0
    Public Property ANIO() As Decimal
        Get
            Return _ANIO
        End Get
        Set(ByVal value As Decimal)
            _ANIO = value

        End Set
    End Property

    Public Property ANIOMES() As Decimal
        Get
            Return _ANIOMES
        End Get
        Set(ByVal value As Decimal)
            _ANIOMES = value

        End Set
    End Property


    Private _MESES As String
    Public Property MESES() As String
        Get
            Return _MESES
        End Get
        Set(ByVal value As String)
            _MESES = value
        End Set
    End Property


    Public Property MES() As Decimal
        Get
            Return _MES
        End Get
        Set(ByVal value As Decimal)
            _MES = value

        End Set
    End Property
#End Region

#Region "EVALUACION FINAL"
    Private _EVAOP As Decimal = 0
    Private _EVAADM As Decimal = 0
    Private _EVAFIN As Decimal = 0
    Private _S_EVAOP As String = ""
    Private _S_EVAADM As String = ""
    Private _S_EVAFIN As String = ""


    Public Property EVAOP() As Decimal
        Get
            Return _EVAOP
        End Get
        Set(ByVal value As Decimal)
            _EVAOP = value

        End Set
    End Property
    Public Property S_EVAOP() As String
        Get
            Return _S_EVAOP
        End Get
        Set(ByVal value As String)
            _S_EVAOP = value

        End Set
    End Property

    Public Property EVAADM() As Decimal
        Get
            Return _EVAADM
        End Get
        Set(ByVal value As Decimal)
            _EVAADM = value

        End Set
    End Property
    Public Property S_EVAADM() As String
        Get
            Return _S_EVAADM
        End Get
        Set(ByVal value As String)
            _S_EVAADM = value

        End Set
    End Property

    Public Property EVAFIN() As Decimal
        Get
            Return _EVAFIN
        End Get
        Set(ByVal value As Decimal)
            _EVAFIN = value

        End Set
    End Property
    Public Property S_EVAFIN() As String
        Get
            Return _S_EVAFIN
        End Get
        Set(ByVal value As String)
            _S_EVAFIN = value

        End Set
    End Property


#End Region


End Class
