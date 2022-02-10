Public Class ServicioReembolso_BE
    Inherits Base_BE(Of ServicioReembolso_BE)

    ''' <summary>
    ''' Inicializa la clase  ServicioReembolso_BE
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        Me.InicializeProperty(Me)
    End Sub
    Private _CCLNT As Integer = 0
    Private _NOPRCN As Double = 0D
    Private _NCRRDC As Double = 0D
    Private _TOBSSR As String = ""
    Private _TPRVD As String = ""
    Private _NRUCPR As Double = 0D
    Private _TPODOC As Double = 0D
    Private _NUMDOC As Double = 0D
    Private _IMPFAC As Double = 0D
    Private _SESTRG As String = ""
    Private _FLGTIPO As String = ""

    Private _CTRMNC As Double = 0D
    Private _NGUITR As Double = 0D
    Public Property CTRMNC() As Double
        Get
            Return _CTRMNC
        End Get
        Set(ByVal value As Double)
            _CTRMNC = value
        End Set
    End Property
    Public Property NGUITR() As Double
        Get
            Return _NGUITR
        End Get
        Set(ByVal value As Double)
            _NGUITR = value
        End Set
    End Property

    Public Property CCLNT() As Integer
        Get
            Return _CCLNT
        End Get
        Set(ByVal value As Integer)
            _CCLNT = value
        End Set
    End Property

    Public Property NOPRCN() As Integer
        Get
            Return _NOPRCN
        End Get
        Set(ByVal value As Integer)
            _NOPRCN = value
        End Set
    End Property

    Public Property NCRRDC() As Integer
        Get
            Return _NCRRDC
        End Get
        Set(ByVal value As Integer)
            _NCRRDC = value
        End Set
    End Property

    Public Property TOBSSR() As String
        Get
            Return _TOBSSR
        End Get
        Set(ByVal value As String)
            _TOBSSR = value
        End Set
    End Property

    Public Property TPRVD() As String
        Get
            Return _TPRVD
        End Get
        Set(ByVal value As String)
            _TPRVD = value
        End Set
    End Property

    Public Property NRUCPR() As Double
        Get
            Return _NRUCPR
        End Get
        Set(ByVal value As Double)
            _NRUCPR = value
        End Set
    End Property

    Public Property TPODOC() As Double
        Get
            Return _TPODOC
        End Get
        Set(ByVal value As Double)
            _TPODOC = value
        End Set
    End Property

    Public Property NUMDOC() As Double
        Get
            Return _NUMDOC
        End Get
        Set(ByVal value As Double)
            _NUMDOC = value
        End Set
    End Property

    Public Property IMPFAC() As Double
        Get
            Return _IMPFAC
        End Get
        Set(ByVal value As Double)
            _IMPFAC = value
        End Set
    End Property

    Private _FCHDOC As Decimal
    Public Property FCHDOC() As Decimal
        Get
            Return _FCHDOC
        End Get
        Set(ByVal value As Decimal)
            _FCHDOC = value
        End Set
    End Property

    Public Property FechaDeDocumento() As String
        Get
            Return NumeroAFecha(_FCHDOC)
        End Get
        Set(ByVal value As String)
            _FCHDOC = CtypeDate(value)
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
    Public Property FLGTIPO() As String
        Get
            Return _FLGTIPO
        End Get
        Set(ByVal value As String)
            _FLGTIPO = value
        End Set
    End Property


    Private _ITPCMT As Decimal
    Public Property ITPCMT() As Decimal
        Get
            Return _ITPCMT
        End Get
        Set(ByVal value As Decimal)
            _ITPCMT = value
        End Set
    End Property

End Class
