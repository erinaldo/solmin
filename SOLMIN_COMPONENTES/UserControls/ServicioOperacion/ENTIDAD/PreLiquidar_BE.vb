Public Class PreLiquidar_BE

    Public FSECFC As String = ""
    Public TPLNTA As String = ""
    Public TCMPCL As String = ""
    Public DESCLIFAC As String = ""
    Public TCMPDV As String = ""
    Public TOTAL_TI As Decimal = 0
    Public DIVISION As String = ""
    Public CPLNDV1 As String = ""
    Public CMNDA As Decimal = 0
    Public CCNTCS As String = ""
    Public STPODP As String = ""
    Public DESSTPODP As String = ""
    Public TLUGEN As String = ""
    Public CRGVTA As String = ""
    Public CMNDA1 As Decimal = 0
    Public CCLNFC As String = ""
    Public CTPALJ2 As String = ""
    Public TIPO_REV As String = ""
    Public NDCFCC As Decimal = 0




    Private _CULUSA As String = ""
    Public Property CULUSA() As String
        Get
            Return _CULUSA
        End Get
        Set(ByVal value As String)
            _CULUSA = value
        End Set
    End Property
    Private _NSECFC As Decimal
    Public Property NSECFC() As Decimal
        Get
            Return _NSECFC
        End Get
        Set(ByVal value As Decimal)
            _NSECFC = value
        End Set
    End Property

    Private _TSGNMN As String = ""
    Public Property TSGNMN() As String
        Get
            Return _TSGNMN
        End Get
        Set(ByVal value As String)
            _TSGNMN = value
        End Set
    End Property



    Private _TOTAL1 As Decimal = 0
    Public Property TOTAL1() As Decimal
        Get
            Return _TOTAL1
        End Get
        Set(ByVal value As Decimal)
            _TOTAL1 = value
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
    Private _CCMPN As String = ""
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property
    Private _CDVSN As String = ""
    Public Property CDVSN() As String
        Get
            Return _CDVSN
        End Get
        Set(ByVal value As String)
            _CDVSN = value
        End Set
    End Property

    Private _CPLNCL As Decimal = 0
    Public Property CPLNCL() As Decimal
        Get
            Return _CPLNCL
        End Get
        Set(ByVal value As Decimal)
            _CPLNCL = value
        End Set
    End Property

    Private _TPDCPE As String = ""
    Public Property TPDCPE() As String
        Get
            Return _TPDCPE
        End Get
        Set(ByVal value As String)
            _TPDCPE = value
        End Set
    End Property
  
    


    Private _DCCLNT As String = ""
    Public Property DCCLNT() As String
        Get
            Return _DCCLNT
        End Get
        Set(ByVal value As String)
            _DCCLNT = value
        End Set
    End Property

    Private _SBCLNT As String = ""
    Public Property SBCLNT() As String
        Get
            Return _SBCLNT
        End Get
        Set(ByVal value As String)
            _SBCLNT = value
        End Set
    End Property

    Private _NDCPRF As String
    Public Property NDCPRF() As String
        Get
            Return _NDCPRF
        End Get
        Set(ByVal value As String)
            _NDCPRF = value
        End Set
    End Property
    Private _ACCION As String = ""
    Public Property ACCION() As String
        Get
            Return _ACCION
        End Get
        Set(ByVal value As String)
            _ACCION = value
        End Set
    End Property
    Private _FDCPRF As String
    Public Property FDCPRF() As String
        Get
            Return _FDCPRF
        End Get
        Set(ByVal value As String)
            _FDCPRF = value
        End Set
    End Property

    Private _CCLNT As String
    Public Property CCLNT() As String
        Get
            Return _CCLNT
        End Get
        Set(ByVal value As String)
            _CCLNT = value
        End Set
    End Property
    Private _CPLNDV As String
    Public Property CPLNDV() As String
        Get
            Return _CPLNDV
        End Get
        Set(ByVal value As String)
            _CPLNDV = value
        End Set
    End Property

   

    Private _NPRLCF As String
    Public Property NPRLCF() As String
        Get
            Return _NPRLCF
        End Get
        Set(ByVal value As String)
            _NPRLCF = value
        End Set
    End Property




End Class