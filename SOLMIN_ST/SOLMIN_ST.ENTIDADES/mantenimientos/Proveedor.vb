Public Class Proveedor
    Private _CCMPN As String = ""
    Private _NRUCTR As String = ""
    Private _STPRCS As String = ""
    Private _NPLRCS As String = ""
    Private _FECINI As Decimal = 0
    Private _FECFIN As Decimal = 0
    Private _SESRCS As String = ""
    Private _SESTRG As String = ""
    Private _CUSCRT As String = ""
    Private _FCHCRT As Decimal = 0
    Private _HRACRT As Decimal = 0
    Private _NTRMCR As String = ""
    Private _CULUSA As String = ""
    Private _FULTAC As Decimal = 0
    Private _HULTAC As Decimal = 0
    Private _NTRMNL As String = ""
    Private _TIPO_UNIDAD As String = ""
    Private _FECINI_S As String = ""
    Private _FECFIN_S As String = ""

    Private _PLACA As String = ""
    Private _TDSDES As String = ""
    Private _MARCA As String = ""
    Private _CCMPRN As String = ""
    Private _CTIEQP As Decimal = 0
    Private _TDEEQP As String = ""
    Private _CDVSN As String = ""

#Region " Tipo Tracto"
    Private _CTIACP As String = ""
    Private _TDEACP As String = ""
    Private _TMRCVH As String = ""
#End Region

#Region " Acoplado"
    Private _CTITRA As String = ""
    Private _TDETRA As String = ""
    Private _TMRCTR As String = ""
#End Region

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

    Public Property NRUCTR() As String
        Get
            Return _NRUCTR
        End Get
        Set(ByVal value As String)
            _NRUCTR = value
        End Set
    End Property

    Public Property STPRCS() As String
        Get
            Return _STPRCS
        End Get
        Set(ByVal value As String)
            _STPRCS = value
        End Set
    End Property

    Public Property NPLRCS() As String
        Get
            Return _NPLRCS
        End Get
        Set(ByVal value As String)
            _NPLRCS = value
        End Set
    End Property

    Public Property FECINI() As Decimal
        Get
            Return _FECINI
        End Get
        Set(ByVal value As Decimal)
            _FECINI = value
        End Set
    End Property

    Public Property FECINI_S() As String
        Get
            Return _FECINI_S
        End Get
        Set(ByVal value As String)
            _FECINI_S = value
        End Set
    End Property

    Public Property FECFIN() As Decimal
        Get
            Return _FECFIN
        End Get
        Set(ByVal value As Decimal)
            _FECFIN = value
        End Set
    End Property

    Public Property FECFIN_S() As String
        Get
            Return _FECFIN_S
        End Get
        Set(ByVal value As String)
            _FECFIN_S = value
        End Set
    End Property

    Public Property SESRCS() As String
        Get
            Return _SESRCS
        End Get
        Set(ByVal value As String)
            _SESRCS = value
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

    Public Property CUSCRT() As String
        Get
            Return _CUSCRT
        End Get
        Set(ByVal value As String)
            _CUSCRT = value
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

    Public Property HRACRT() As Decimal
        Get
            Return _HRACRT
        End Get
        Set(ByVal value As Decimal)
            _HRACRT = value
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

    Public Property CULUSA() As String
        Get
            Return _CULUSA
        End Get
        Set(ByVal value As String)
            _CULUSA = value
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

    Public Property HULTAC() As Decimal
        Get
            Return _HULTAC
        End Get
        Set(ByVal value As Decimal)
            _HULTAC = value
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

    Public Property TIPO_UNIDAD() As String
        Get
            Return _TIPO_UNIDAD
        End Get
        Set(ByVal value As String)
            _TIPO_UNIDAD = value
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

    '_PLACA
    Public Property PLACA() As String
        Get
            Return _PLACA
        End Get
        Set(ByVal value As String)
            _PLACA = value
        End Set
    End Property

    Public Property CTIACP() As String
        Get
            Return _CTIACP
        End Get
        Set(ByVal value As String)
            _CTIACP = value
        End Set
    End Property

    'CTIEQP
    Public Property CTIEQP() As Decimal
        Get
            Return _CTIEQP
        End Get
        Set(ByVal value As Decimal)
            _CTIEQP = value
        End Set
    End Property


    Public Property TDEEQP() As String
        Get
            Return _TDEEQP
        End Get
        Set(ByVal value As String)
            _TDEEQP = value
        End Set
    End Property

    Public Property TDEACP() As String
        Get
            Return _TDEACP
        End Get
        Set(ByVal value As String)
            _TDEACP = value
        End Set
    End Property

    Public Property TMRCVH() As String
        Get
            Return _TMRCVH
        End Get
        Set(ByVal value As String)
            _TMRCVH = value
        End Set
    End Property

    Public Property CTITRA() As String
        Get
            Return _CTITRA
        End Get
        Set(ByVal value As String)
            _CTITRA = value
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

    Public Property TMRCTR() As String
        Get
            Return _TMRCTR
        End Get
        Set(ByVal value As String)
            _TMRCTR = value
        End Set
    End Property

    Public Property MARCA() As String
        Get
            Return _MARCA
        End Get
        Set(ByVal value As String)
            _MARCA = value
        End Set
    End Property

    Public Property CCMPRN() As String
        Get
            Return _CCMPRN
        End Get
        Set(ByVal value As String)
            _CCMPRN = value
        End Set
    End Property

End Class
