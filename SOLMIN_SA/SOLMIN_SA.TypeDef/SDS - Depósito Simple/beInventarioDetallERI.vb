Public Class beInventarioDetallERI
    Private _IN_CCMPN As String
    Private _IN_CRGVTA As String
    Private _IN_CPLNDV As Decimal
    Private _IN_CCLNT As Decimal
    Private _IN_NROERI As Decimal

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

    Public Property IN_NROERI() As Decimal
        Get
            Return (_IN_NROERI)
        End Get
        Set(ByVal value As Decimal)
            _IN_NROERI = value
        End Set
    End Property
End Class
