Public Class Contrato

    Inherits Base(Of Contrato)

    Private _NRCTSL As Decimal = 0
    Private _NRCTCL As Decimal = 0
    Private _NCNTRT As String = ""
    Private _CCMPN As String = ""
    Private _TCNCTO As String = ""
    Private _TMACTO As String = ""
    Private _NTLCTO As String = ""
    Private _FECINI As Decimal = 0
    Private _FECFIN As Decimal = 0
    Private _DESCTR As String = ""
    Private _TOBS As String = ""
    Private _CUSCRT As String = ""
    Private _FCHCRT As Decimal = 0
    Private _HRACRT As Decimal = 0
    Private _CULUSA As String = ""
    Private _FULTAC As Decimal = 0
    Private _HULTAC As Decimal = 0
    Private _SESTRG As String = ""
    Private _CRGVTA As String = ""
    Private _NRUC As Decimal
    Private _ORDEN As Decimal = 0
    Private _ESTADO_CONT As String = ""


    Public Property NRUC() As Decimal
        Get
            Return _NRUC
        End Get
        Set(ByVal value As Decimal)
            _NRUC = value
        End Set
    End Property



    Private _TMTVBJ As String
    Public Property TMTVBJ() As String
        Get
            Return _TMTVBJ
        End Get
        Set(ByVal value As String)
            _TMTVBJ = value
        End Set
    End Property

    Private _DESCAR As String
    Public Property DESCAR() As String
        Get
            Return _DESCAR
        End Get
        Set(ByVal value As String)
            _DESCAR = value
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

    Property DESCTR() As String
        Get
            Return _DESCTR
        End Get
        Set(ByVal value As String)
            _DESCTR = value
        End Set
    End Property


    Public Property FechaInicio() As String
        Get
            Return NumeroAFecha(_FECINI)
        End Get
        Set(ByVal value As String)
            _FECINI = CtypeDate(value)
        End Set
    End Property

    Public Property FechaFin() As String
        Get
            Return NumeroAFecha(_FECFIN)
        End Get
        Set(ByVal value As String)
            _FECFIN = CtypeDate(value)
        End Set
    End Property

    Public Property FechaContrato() As String
        Get
            Return NumeroAFecha(_FCHCRT)
        End Get
        Set(ByVal value As String)
            _FCHCRT = CtypeDate(value)
        End Set
    End Property
    Property FECFIN() As Decimal
        Get
            Return _FECFIN
        End Get
        Set(ByVal value As Decimal)
            _FECFIN = value
        End Set
    End Property

    Property FECINI() As Decimal
        Get
            Return _FECINI
        End Get
        Set(ByVal value As Decimal)
            _FECINI = value
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


    Property NTLCTO() As String
        Get
            Return _NTLCTO
        End Get
        Set(ByVal value As String)
            _NTLCTO = value
        End Set
    End Property

    Property TMACTO() As String
        Get
            Return _TMACTO
        End Get
        Set(ByVal value As String)
            _TMACTO = value
        End Set
    End Property

    Property NRCTSL() As Decimal
        Get
            Return _NRCTSL
        End Get
        Set(ByVal value As Decimal)
            _NRCTSL = value
        End Set
    End Property

    Private _CCLNT As Decimal
    Public Property CCLNT() As Decimal
        Get
            Return _CCLNT
        End Get
        Set(ByVal value As Decimal)
            _CCLNT = value
        End Set
    End Property


    Property NRCTCL() As Decimal
        Get
            Return _NRCTCL
        End Get
        Set(ByVal value As Decimal)
            _NRCTCL = value
        End Set
    End Property

    Property NCNTRT() As String
        Get
            Return _NCNTRT
        End Get
        Set(ByVal value As String)
            _NCNTRT = value
        End Set
    End Property

    Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property

    Property TCNCTO() As String
        Get
            Return _TCNCTO
        End Get
        Set(ByVal value As String)
            _TCNCTO = value
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


    Private _NMRGIM As Decimal
    Public Property NMRGIM() As Decimal
        Get
            Return _NMRGIM
        End Get
        Set(ByVal value As Decimal)
            _NMRGIM = value
        End Set
    End Property


    Private _TCMPCL As String
    Public Property TCMPCL() As String
        Get
            Return _TCMPCL
        End Get
        Set(ByVal value As String)
            _TCMPCL = value
        End Set
    End Property

    Public Property CRGVTA() As String
        Get
            Return _CRGVTA
        End Get
        Set(ByVal value As String)
            _CRGVTA = value
        End Set
    End Property

    Public Property ORDEN() As Decimal
        Get
            Return _ORDEN
        End Get
        Set(ByVal value As Decimal)
            _ORDEN = value
        End Set
    End Property

    Public Property ESTADO_CONT() As String
        Get
            Return _ESTADO_CONT
        End Get
        Set(ByVal value As String)
            _ESTADO_CONT = value
        End Set
    End Property


    Public Sub New()
        Me.InicializeProperty(Me)
    End Sub

End Class
