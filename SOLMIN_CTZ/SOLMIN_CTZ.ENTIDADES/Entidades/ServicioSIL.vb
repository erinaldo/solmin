Public Class ServicioSIL
    Private _NOPRCN As Double = 0
    Private _CCLNT As Double = 0
    Private _CCLNFC As Double = 0
    Private _FOPRCN As Double = 0
    Private _NRTFSV As Double = 0
    Private _CCMPN As String = ""
    Private _CDVSN As String = ""
    Private _QATNAN As Double = 0
    Private _FECINI As Double = 0
    Private _FECFIN As Double = 0
    Private _TOBS As String = ""
    Private _TIPO As String = ""
    Private _NORSCI As Double = 0
    Private _NORCML As String = ""
    Private _FLGFAC As String = ""


    Private _FECSER As Integer = 0
    Public Property FECSER() As Integer
        Get
            Return _FECSER
        End Get
        Set(ByVal value As Integer)
            _FECSER = value
        End Set
    End Property

    Private _CPLNDV As Double = 0D
    Public Property CPLNDV() As Double
        Get
            Return _CPLNDV
        End Get
        Set(ByVal value As Double)
            _CPLNDV = value
        End Set
    End Property

    Property FLGFAC() As String
        Get
            Return _FLGFAC
        End Get
        Set(ByVal value As String)
            _FLGFAC = value
        End Set
    End Property

    Property TIPO() As String
        Get
            Return _TIPO
        End Get
        Set(ByVal value As String)
            _TIPO = value
        End Set
    End Property

    Property NOPRCN() As Double
        Get
            Return _NOPRCN
        End Get
        Set(ByVal value As Double)
            _NOPRCN = value
        End Set
    End Property

    Property CCLNT() As Double
        Get
            Return _CCLNT
        End Get
        Set(ByVal value As Double)
            _CCLNT = value
        End Set
    End Property

    Property CCLNFC() As Double
        Get
            Return _CCLNFC
        End Get
        Set(ByVal value As Double)
            _CCLNFC = value
        End Set
    End Property

    Property FOPRCN() As Double
        Get
            Return _FOPRCN
        End Get
        Set(ByVal value As Double)
            _FOPRCN = value
        End Set
    End Property
    Property NRTFSV() As Double
        Get
            Return _NRTFSV
        End Get
        Set(ByVal value As Double)
            _NRTFSV = value
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

    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal Value As String)
            _CCMPN = Value
        End Set
    End Property

    Property QATNAN() As Double
        Get
            Return _QATNAN
        End Get
        Set(ByVal value As Double)
            _QATNAN = value
        End Set
    End Property

    Property FECINI() As Double
        Get
            Return _FECINI
        End Get
        Set(ByVal value As Double)
            _FECINI = value
        End Set
    End Property

    Property FECFIN() As Double
        Get
            Return _FECFIN
        End Get
        Set(ByVal value As Double)
            _FECFIN = value
        End Set
    End Property

    Property TOBS() As String
        Get
            Return _TOBS
        End Get
        Set(ByVal value As String)
            _TOBS = value
        End Set
    End Property

    Property NORSCI() As Double
        Get
            Return _NORSCI
        End Get
        Set(ByVal value As Double)
            _NORSCI = value
        End Set
    End Property

    Property NORCML() As String
        Get
            Return _NORCML
        End Get
        Set(ByVal value As String)
            _NORCML = value
        End Set
    End Property

End Class
