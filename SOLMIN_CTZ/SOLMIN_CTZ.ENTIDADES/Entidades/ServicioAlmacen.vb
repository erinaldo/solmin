Public Class ServicioAlmacen
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

    Private _STIPPR As String = ""
    Public Property STIPPR() As String
        Get
            Return _STIPPR
        End Get
        Set(ByVal value As String)
            _STIPPR = value
        End Set
    End Property


    Public Property CCLNFC() As Integer
        Get
            Return _CCLNFC
        End Get
        Set(ByVal value As Integer)
            _CCLNFC = value
        End Set
    End Property


    Private _NGUIRM As Integer = 0
    Public Property NGUIRM() As Integer
        Get
            Return _NGUIRM
        End Get
        Set(ByVal value As Integer)
            _NGUIRM = value
        End Set
    End Property

    Private _NRGUSA As Integer = 0
    Public Property NRGUSA() As Integer
        Get
            Return _NRGUSA
        End Get
        Set(ByVal value As Integer)
            _NRGUSA = value
        End Set
    End Property

    Private _NROCTL As Integer = 0
    Public Property NROCTL() As Integer
        Get
            Return _NROCTL
        End Get
        Set(ByVal value As Integer)
            _NROCTL = value
        End Set
    End Property

    Private _NROPLT As Integer = 0
    Public Property NROPLT() As Integer
        Get
            Return _NROPLT
        End Get
        Set(ByVal value As Integer)
            _NROPLT = value
        End Set
    End Property

    Private _CREFFW As String = ""
    Public Property CREFFW() As String
        Get
            Return _CREFFW
        End Get
        Set(ByVal value As String)
            _CREFFW = value
        End Set
    End Property

    Private _CPLNDV As Integer = 0
    Public Property CPLNDV() As Integer
        Get
            Return _CPLNDV
        End Get
        Set(ByVal value As Integer)
            _CPLNDV = value
        End Set
    End Property

    Private _NOMSER As String = ""
    Public Property NOMSER() As String
        Get
            Return _NOMSER
        End Get
        Set(ByVal value As String)
            _NOMSER = value
        End Set
    End Property

    Private _QCNESP As Double = 0D
    Public Property QCNESP() As Double
        Get
            Return _QCNESP
        End Get
        Set(ByVal value As Double)
            _QCNESP = value
        End Set
    End Property

    Private _TUNDIT = ""
    Public Property TUNDIT() As String
        Get
            Return _TUNDIT
        End Get
        Set(ByVal value As String)
            _TUNDIT = value
        End Set
    End Property

    Private _TIPOALM As Integer = 0
    Public Property TIPOALM() As Integer
        Get
            Return _TIPOALM
        End Get
        Set(ByVal value As Integer)
            _TIPOALM = value
        End Set
    End Property

    Private _CPRCN1 As String = ""
    Public Property CPRCN1() As String
        Get
            Return _CPRCN1
        End Get
        Set(ByVal value As String)
            _CPRCN1 = value
        End Set
    End Property

    Private _NSRCN1 As String = ""
    Public Property NSRCN1() As String
        Get
            Return _NSRCN1
        End Get
        Set(ByVal value As String)
            _NSRCN1 = value
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

End Class
