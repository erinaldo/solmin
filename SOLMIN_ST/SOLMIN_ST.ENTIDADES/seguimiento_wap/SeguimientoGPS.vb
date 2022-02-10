Public Class SeguimientoGPS


    Private _NCSOTR As Decimal = 0
    Public Property NCSOTR() As Decimal
        Get
            Return _NCSOTR
        End Get
        Set(ByVal value As Decimal)
            _NCSOTR = value
        End Set
    End Property


    Private _NCRRSR As Decimal = 0
    Public Property NCRRSR() As Decimal
        Get
            Return _NCRRSR
        End Get
        Set(ByVal value As Decimal)
            _NCRRSR = value
        End Set
    End Property


    Private _NCOREG As Decimal = 0
    Public Property NCOREG() As Decimal
        Get
            Return _NCOREG
        End Get
        Set(ByVal value As Decimal)
            _NCOREG = value
        End Set
    End Property


    Private _NPLCTR As String = ""
    Public Property NPLCTR() As String
        Get
            Return _NPLCTR
        End Get
        Set(ByVal value As String)
            _NPLCTR = value
        End Set
    End Property

    Private _FECGPS As Decimal = 0
    Public Property FECGPS() As Decimal
        Get
            Return _FECGPS
        End Get
        Set(ByVal value As Decimal)
            _FECGPS = value
        End Set
    End Property

    Private _FECGPS_S As String = ""
    Public Property FECGPS_S() As String
        Get
            Return _FECGPS_S
        End Get
        Set(ByVal value As String)
            _FECGPS_S = value
        End Set
    End Property

    Private _HORA As Decimal = 0
    Public Property HORA() As Decimal
        Get
            Return _HORA
        End Get
        Set(ByVal value As Decimal)
            _HORA = value
        End Set
    End Property

    Private _HORA_S As String = 0
    Public Property HORA_S() As String
        Get
            Return _HORA_S
        End Get
        Set(ByVal value As String)
            _HORA_S = value
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



    Private _FCHCRT As Decimal = 0
    Public Property FCHCRT() As Decimal
        Get
            Return _FCHCRT
        End Get
        Set(ByVal value As Decimal)
            _FCHCRT = value
        End Set
    End Property

    Private _HRACRT As Decimal = 0
    Public Property HRACRT() As Decimal
        Get
            Return _HRACRT
        End Get
        Set(ByVal value As Decimal)
            _HRACRT = value
        End Set
    End Property


    Private _NTRMCR As String = 0
    Public Property NTRMCR() As String
        Get
            Return _NTRMCR
        End Get
        Set(ByVal value As String)
            _NTRMCR = value
        End Set
    End Property

    Private _FULTAC As Decimal = 0
    Public Property FULTAC() As Decimal
        Get
            Return _FULTAC
        End Get
        Set(ByVal value As Decimal)
            _FULTAC = value
        End Set
    End Property


    Private _HULTAC As Decimal = 0
    Public Property HULTAC() As Decimal
        Get
            Return _HULTAC
        End Get
        Set(ByVal value As Decimal)
            _HULTAC = value
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


    Private _NTRMNL As String = ""
    Public Property NTRMNL() As String
        Get
            Return _NTRMNL
        End Get
        Set(ByVal value As String)
            _NTRMNL = value
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

    Private _GPSLAT As String = ""
    Public Property GPSLAT() As String
        Get
            Return _GPSLAT
        End Get
        Set(ByVal value As String)
            _GPSLAT = value
        End Set
    End Property

    Private _GPSLON As String = ""
    Public Property GPSLON() As String
        Get
            Return _GPSLON
        End Get
        Set(ByVal value As String)
            _GPSLON = value
        End Set
    End Property

    Private _KMSVEL As Decimal = 0
    Public Property KMSVEL() As Decimal
        Get
            Return _KMSVEL
        End Get
        Set(ByVal value As Decimal)
            _KMSVEL = value
        End Set
    End Property

    Private _CCMPN As String = ""
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property

    Private _NGSGWP As String = ""
    Public Property NGSGWP() As String
        Get
            Return _NGSGWP
        End Get
        Set(ByVal value As String)
            _NGSGWP = value
        End Set
    End Property

    Public Sub trim()
        NPLCTR = NPLCTR.Trim
        FECGPS_S = FECGPS_S.Trim
        CUSCRT = CUSCRT.Trim
        NTRMCR = NTRMCR.Trim
        CULUSA = CULUSA.Trim
        NTRMNL = NTRMNL.Trim
        SESTRG = SESTRG.Trim
        GPSLAT = GPSLAT.Trim
        GPSLON = GPSLON.Trim
        CCMPN = CCMPN.Trim
        NGSGWP = NGSGWP.Trim
    End Sub

End Class
