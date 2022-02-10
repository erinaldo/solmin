'CSR-HUNDRED-feature/151116_Combustibles-INICIO

Public Class Combustible_BE

    Private _CCMPN As String
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property

    Private _CDVSN As String
    Public Property CDVSN() As String
        Get
            Return _CDVSN
        End Get
        Set(ByVal value As String)
            _CDVSN = value
        End Set
    End Property

    Private _CPLNDV As Decimal
    Public Property CPLNDV() As Decimal
        Get
            Return _CPLNDV
        End Get
        Set(ByVal value As Decimal)
            _CPLNDV = value
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

    Private _CRGVTA As String
    Public Property CRGVTA() As String
        Get
            Return _CRGVTA
        End Get
        Set(ByVal value As String)
            _CRGVTA = value
        End Set
    End Property


    Private _CMEDTR As Decimal
    Public Property CMEDTR() As Decimal
        Get
            Return _CMEDTR
        End Get
        Set(ByVal value As Decimal)
            _CMEDTR = value
        End Set
    End Property


    Private _FINIOP As Decimal
    Public Property FINIOP() As Decimal
        Get
            Return _FINIOP
        End Get
        Set(ByVal value As Decimal)
            _FINIOP = value
        End Set
    End Property


    Private _FFINOP As Decimal
    Public Property FFINOP() As Decimal
        Get
            Return _FFINOP
        End Get
        Set(ByVal value As Decimal)
            _FFINOP = value
        End Set
    End Property


    Private _NPLCUN As String
    Public Property NPLCUN() As String
        Get
            Return _NPLCUN
        End Get
        Set(ByVal value As String)
            _NPLCUN = value
        End Set
    End Property

    Private _NOPRCN As Decimal
    Public Property NOPRCN() As Decimal
        Get
            Return _NOPRCN
        End Get
        Set(ByVal value As Decimal)
            _NOPRCN = value
        End Set
    End Property

    Private _NGUIRM As Decimal
    Public Property NGUIRM() As Decimal
        Get
            Return _NGUIRM
        End Get
        Set(ByVal value As Decimal)
            _NGUIRM = value
        End Set
    End Property


    Private _CBRCNT As String
    Public Property CBRCNT() As String
        Get
            Return _CBRCNT
        End Get
        Set(ByVal value As String)
            _CBRCNT = value
        End Set
    End Property

    Private _NLQCMB As Decimal = 0
    Public Property NLQCMB() As Decimal
        Get
            Return _NLQCMB
        End Get
        Set(ByVal value As Decimal)
            _NLQCMB = value
        End Set
    End Property


End Class

'CSR-HUNDRED-feature/151116_Combustibles-FIN
