Public Class beCabeceraERI
    Private _IN_CCMPN As String
    Private _IN_CRGVTA As String
    Private _IN_CPLNDV As Decimal
    Private _IN_CCLNT As Decimal
    Private _IN_FECINVINI As Decimal
    Private _IN_FECINVFIN As Decimal

    Public Property IN_CCMPN() As String
        Get
            Return (_IN_CCMPN)
        End Get
        Set(ByVal value As String)
            _IN_CCMPN = value
        End Set
    End Property

    Public Property IN_CRGVTA() As String
        Get
            Return (_IN_CRGVTA)
        End Get
        Set(ByVal value As String)
            _IN_CRGVTA = value
        End Set
    End Property

    Public Property IN_CPLNDV() As Decimal
        Get
            Return (_IN_CPLNDV)
        End Get
        Set(ByVal value As Decimal)
            _IN_CPLNDV = value
        End Set
    End Property

    Public Property IN_CCLNT() As Decimal
        Get
            Return (_IN_CCLNT)
        End Get
        Set(ByVal value As Decimal)
            _IN_CCLNT = value
        End Set
    End Property

    Public Property IN_FECINVINI() As Decimal
        Get
            Return (_IN_FECINVINI)
        End Get
        Set(ByVal value As Decimal)
            _IN_FECINVINI = value
        End Set
    End Property

    Public Property IN_FECINVFIN() As Decimal
        Get
            Return (_IN_FECINVFIN)
        End Get
        Set(ByVal value As Decimal)
            _IN_FECINVFIN = value
        End Set
    End Property
End Class
