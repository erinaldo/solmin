Public Class Programacion_Unidad


    Private _NPLNJT As Decimal = 0D  '10,0    NUM PLANEAMIENTO DE JUNTA
    Public Property NPLNJT() As Decimal
        Get
            Return _NPLNJT
        End Get
        Set(ByVal value As Decimal)
            _NPLNJT = value
        End Set
    End Property


    Private _NCRRPL As Decimal = 0D '5,0   NUM CORRELATIVO DEL PLANEAMIENTO
    Public Property NCRRPL() As Decimal
        Get
            Return _NCRRPL
        End Get
        Set(ByVal value As Decimal)
            _NCRRPL = value
        End Set
    End Property


    Private _NUMREQT As Decimal = 0D ' 10,0  NUM DE REQUERIMIENTO
    Public Property NUMREQT() As Decimal
        Get
            Return _NUMREQT
        End Get
        Set(ByVal value As Decimal)
            _NUMREQT = value
        End Set
    End Property


    Private _NCRRPA As Decimal = 0D ' 4,0  NUM CORRELATIVO PREASIGNACION UNIDAD 
    Public Property NCRRPA() As Decimal
        Get
            Return _NCRRPA
        End Get
        Set(ByVal value As Decimal)
            _NCRRPA = value
        End Set
    End Property


    Private _FPRASG As Decimal = 0D  '8 FECHA DE PRE-ASIGNACION
    Public Property FPRASG() As Decimal
        Get
            Return _FPRASG
        End Get
        Set(ByVal value As Decimal)
            _FPRASG = value
        End Set
    End Property


    Private _FPRASG_D As String = ""  ' FECHA DE PRE-ASIGNACION
    Public Property FPRASG_D() As String
        Get
            Return _FPRASG_D
        End Get
        Set(ByVal value As String)
            _FPRASG_D = value
        End Set
    End Property

    Private _NRUCTR As String = ""   ' 15 RUC TRANSPORTISTA
    Public Property NRUCTR() As String
        Get
            Return _NRUCTR
        End Get
        Set(ByVal value As String)
            _NRUCTR = value
        End Set
    End Property

    Private _TCMTRT As String = ""  '   transportista
    Public Property TCMTRT() As String
        Get
            Return _TCMTRT
        End Get
        Set(ByVal value As String)
            _TCMTRT = value
        End Set
    End Property

    Private _NPLCUN As String = "" ' 6  NUM PLACA UNIDAD
    Public Property NPLCUN() As String
        Get
            Return _NPLCUN
        End Get
        Set(ByVal value As String)
            _NPLCUN = value
        End Set
    End Property


    Private _NPLCAC As String = "" ' 6 NUM PLACA ACOPLADO
    Public Property NPLCAC() As String
        Get
            Return _NPLCAC
        End Get
        Set(ByVal value As String)
            _NPLCAC = value
        End Set
    End Property

    Private _CBRCNT As String = "" ' 15
    Public Property CBRCNT() As String
        Get
            Return _CBRCNT
        End Get
        Set(ByVal value As String)
            _CBRCNT = value
        End Set
    End Property

    Private _TNMCMC As String = ""  'conductor 1
    Public Property TNMCMC() As String
        Get
            Return _TNMCMC
        End Get
        Set(ByVal value As String)
            _TNMCMC = value
        End Set
    End Property

    Private _CBRCN2 As String = "" ' 15 
    Public Property CBRCN2() As String
        Get
            Return _CBRCN2
        End Get
        Set(ByVal value As String)
            _CBRCN2 = value
        End Set
    End Property

    Private _TNMCMC2 As String
    Public Property TNMCMC2() As String
        Get
            Return _TNMCMC2
        End Get
        Set(ByVal value As String)
            _TNMCMC2 = value
        End Set
    End Property

    Private _TOBS As String = "" ' 250
    Public Property TOBS() As String
        Get
            Return _TOBS
        End Get
        Set(ByVal value As String)
            _TOBS = value
        End Set
    End Property


    Private _SESASG As String = "" ' 1
    Public Property SESASG() As String
        Get
            Return _SESASG
        End Get
        Set(ByVal value As String)
            _SESASG = value
        End Set
    End Property

    Private _SESASG_D As String = "" ' 1
    Public Property SESASG_D() As String
        Get
            Return _SESASG_D
        End Get
        Set(ByVal value As String)
            _SESASG_D = value
        End Set
    End Property


    Private _SESTRG As String = ""
    Public Property SESTRG() As String
        Get
            Return _SESTRG
        End Get
        Set(ByVal value As String)
            _SESTRG = value
        End Set
    End Property



    Private _CUSCRT As String = ""
    Public Property CUSCRT() As String
        Get
            Return _CUSCRT
        End Get
        Set(ByVal value As String)
            _CUSCRT = value
        End Set
    End Property

    Private _FCHCRT As Decimal = 0D
    Public Property FCHCRT() As Decimal
        Get
            Return _FCHCRT
        End Get
        Set(ByVal value As Decimal)
            _FCHCRT = value
        End Set
    End Property

    Private _HRACRT As Decimal = 0D
    Public Property HRACRT() As Decimal
        Get
            Return _HRACRT
        End Get
        Set(ByVal value As Decimal)
            _HRACRT = value
        End Set
    End Property

    Private _NTRMCR As String = ""
    Public Property NTRMCR() As String
        Get
            Return _NTRMCR
        End Get
        Set(ByVal value As String)
            _NTRMCR = value
        End Set
    End Property

    Private _CULUSA As String = ""
    Public Property CULUSA() As String
        Get
            Return _CULUSA
        End Get
        Set(ByVal value As String)
            _CULUSA = value
        End Set
    End Property

    Private _FULTAC As Decimal = 0D
    Public Property FULTAC() As Decimal
        Get
            Return _FULTAC
        End Get
        Set(ByVal value As Decimal)
            _FULTAC = value
        End Set
    End Property

    Private _HULTAC As Decimal = 0D
    Public Property HULTAC() As Decimal
        Get
            Return _HULTAC
        End Get
        Set(ByVal value As Decimal)
            _HULTAC = value
        End Set
    End Property

    Private _NTRMNL As String = ""
    Public Property NTRMNL() As String
        Get
            Return _NTRMNL
        End Get
        Set(ByVal value As String)
            _NTRMNL = value
        End Set
    End Property


    Private _NOPRCN As Decimal = 0D
    Public Property NOPRCN() As Decimal
        Get
            Return _NOPRCN
        End Get
        Set(ByVal value As Decimal)
            _NOPRCN = value
        End Set
    End Property



End Class
