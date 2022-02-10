Public Class FacturaElectronica
    Inherits Base_BE

    Private _CCMPN As String = ""
    Private _CTPODC As Int32 = 0
    Private _NDCCTC As Integer = 0
    Private _NINDRN As Integer = 0
    Private _FDCCTC As Integer = 0
    Private _CTPDCO As Integer = 0
    Private _NDCMOR As Integer = 0
    Private _FDCMOR As Integer = 0
    Private _CDMODN As Integer = 0
    Private _CRGVTA As String = ""
    Private _CTPCTR As Integer = 0
    Private _CCLNT As Integer = 0
    Private _CDDRSP As String = ""
    Private _CGRONG As String = ""
    Private _CZNFCC As String = ""
    Private _IVLDCS As Decimal = 0.0
    Private _PIGVA As Decimal = 0.0
    Private _IVLIGS As Decimal = 0.0
    Private _ITTFCS As Decimal = 0.0
    Private _CMNDA As Integer = 0
    Private _NDSPGD As Integer = 0
    Private _NFORFA As Integer = 0
    Private _CCLNOP As Decimal = 0.0 'Desarrollador 3 JD

    Private _CUBIGE As String = ""


    Private _DIRSEV As String = ""

    Private _OC_CLIENTE As String = ""

    Private _ES_PREDOCUMENTO As String = ""
    Public Property DIRSEV() As String
        Get
            Return _DIRSEV
        End Get
        Set(ByVal value As String)
            _DIRSEV = value
        End Set
    End Property

    Public Property CUBIGE() As String
        Get
            Return _CUBIGE
        End Get
        Set(ByVal value As String)
            _CUBIGE = value
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


    Property CTPODC() As Int32
        Get
            Return _CTPODC
        End Get
        Set(ByVal value As Int32)
            _CTPODC = value
        End Set
    End Property

    Property NDCCTC() As Integer
        Get
            Return _NDCCTC
        End Get
        Set(ByVal value As Integer)
            _NDCCTC = value
        End Set
    End Property

    Property NINDRN() As Integer
        Get
            Return _NINDRN
        End Get
        Set(ByVal value As Integer)
            _NINDRN = value
        End Set
    End Property

    Property FDCCTC() As Integer
        Get
            Return _FDCCTC
        End Get
        Set(ByVal value As Integer)
            _FDCCTC = value
        End Set
    End Property

    Property CRGVTA() As String
        Get
            Return _CRGVTA
        End Get
        Set(ByVal value As String)
            _CRGVTA = value
        End Set
    End Property

    Property CTPCTR() As Integer
        Get
            Return _CTPCTR
        End Get
        Set(ByVal value As Integer)
            _CTPCTR = value
        End Set
    End Property

    Property CCLNT() As Integer
        Get
            Return _CCLNT
        End Get
        Set(ByVal value As Integer)
            _CCLNT = value
        End Set
    End Property

    Property CDDRSP() As String
        Get
            Return _CDDRSP
        End Get
        Set(ByVal value As String)
            _CDDRSP = value
        End Set
    End Property

    Property CGRONG() As String
        Get
            Return _CGRONG
        End Get
        Set(ByVal value As String)
            _CGRONG = value
        End Set
    End Property

    Property CZNFCC() As String
        Get
            Return _CZNFCC
        End Get
        Set(ByVal value As String)
            _CZNFCC = value
        End Set
    End Property

    Property IVLDCS() As Decimal
        Get
            Return _IVLDCS
        End Get
        Set(ByVal value As Decimal)
            _IVLDCS = value
        End Set
    End Property

    Property PIGVA() As Decimal
        Get
            Return _PIGVA
        End Get
        Set(ByVal value As Decimal)
            _PIGVA = value
        End Set
    End Property

    Property IVLIGS() As Decimal
        Get
            Return _IVLIGS
        End Get
        Set(ByVal value As Decimal)
            _IVLIGS = value
        End Set
    End Property

    Property ITTFCS() As Decimal
        Get
            Return _ITTFCS
        End Get
        Set(ByVal value As Decimal)
            _ITTFCS = value
        End Set
    End Property

    Property CMNDA() As Integer
        Get
            Return _CMNDA
        End Get
        Set(ByVal value As Integer)
            _CMNDA = value
        End Set
    End Property

    Property NDSPGD() As Integer
        Get
            Return _NDSPGD
        End Get
        Set(ByVal value As Integer)
            _NDSPGD = value
        End Set
    End Property

    Property NFORFA() As Integer
        Get
            Return _NFORFA
        End Get
        Set(ByVal value As Integer)
            _NFORFA = value
        End Set
    End Property



    Property CTPDCO() As Integer
        Get
            Return _CTPDCO
        End Get
        Set(ByVal value As Integer)
            _CTPDCO = value
        End Set
    End Property

    Property NDCMOR() As Integer
        Get
            Return _NDCMOR
        End Get
        Set(ByVal value As Integer)
            _NDCMOR = value
        End Set
    End Property

    Property FDCMOR() As Integer
        Get
            Return _FDCMOR
        End Get
        Set(ByVal value As Integer)
            _FDCMOR = value
        End Set
    End Property
    Property CDMODN() As Integer
        Get
            Return _CDMODN
        End Get
        Set(ByVal value As Integer)
            _CDMODN = value
        End Set
    End Property
    'Desarrollador 3 JD
    Property CCLNOP() As Decimal
        Get
            Return _CCLNOP
        End Get
        Set(ByVal value As Decimal)
            _CCLNOP = value
        End Set
    End Property

    Property OC_CLIENTE() As String
        Get
            Return _OC_CLIENTE
        End Get
        Set(ByVal value As String)
            _OC_CLIENTE = value
        End Set
    End Property

    Property ES_PREDOCUMENTO() As String
        Get
            Return _ES_PREDOCUMENTO
        End Get
        Set(ByVal value As String)
            _ES_PREDOCUMENTO = value
        End Set
    End Property
     
End Class
