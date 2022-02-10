Public Class FacturaHistorialDet
    Private _PSCCMPN As String = ""
    Private _PSCDVSN As String = ""
    Private _PNCCLNT As Decimal = 0
    Private _PNNOPRCN As Decimal = 0
    Private _PNNCRRFC As Decimal = 0
    Private _PNNCRROP As Decimal = 0
    Private _PNNRTFSV As Decimal = 0
    Private _PNQATNAN As Decimal = 0
    Private _PSCUNDMD As String = ""
    Private _PNIVLSRV As Decimal = 0
    Private _PNCTPODC As Decimal = 0
    Private _PNNDCFCC As Decimal = 0
    Private _PNFDCFCC As Decimal = 0
    Private _PNNCRDCC As Decimal = 0
    Private _PSNTRMNL As String = ""
    Private _PNNPRLQD As Decimal = 0
    Private _PNNPREDOC As Decimal = 0
    Private _LISTJSON As String = ""
    Private _PNCMNDA1 As Decimal = 0

    Private _PNCSRVNV As Decimal = 0
    Private _PNCCNTCS As Decimal = 0
     


    Public Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property

    Public Property PSCDVSN() As String
        Get
            Return _PSCDVSN
        End Get
        Set(ByVal value As String)
            _PSCDVSN = value
        End Set
    End Property



    Public Property PNCCLNT() As Decimal
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property

    Public Property PNNOPRCN() As Decimal
        Get
            Return _PNNOPRCN
        End Get
        Set(ByVal value As Decimal)
            _PNNOPRCN = value
        End Set
    End Property

    Public Property PNNCRRFC() As Decimal
        Get
            Return _PNNCRRFC
        End Get
        Set(ByVal value As Decimal)
            _PNNCRRFC = value
        End Set
    End Property

    Public Property PNNCRROP() As Decimal
        Get
            Return _PNNCRROP
        End Get
        Set(ByVal value As Decimal)
            _PNNCRROP = value
        End Set
    End Property

    Public Property PNNRTFSV() As Decimal
        Get
            Return _PNNRTFSV
        End Get
        Set(ByVal value As Decimal)
            _PNNRTFSV = value
        End Set
    End Property

    Public Property PNQATNAN() As Decimal
        Get
            Return _PNQATNAN
        End Get
        Set(ByVal value As Decimal)
            _PNQATNAN = value
        End Set
    End Property

    Public Property PSCUNDMD() As String
        Get
            Return _PSCUNDMD
        End Get
        Set(ByVal value As String)
            _PSCUNDMD = value
        End Set
    End Property

    Public Property PNIVLSRV() As Decimal
        Get
            Return _PNIVLSRV
        End Get
        Set(ByVal value As Decimal)
            _PNIVLSRV = value
        End Set
    End Property
    Public Property PNCTPODC() As Decimal
        Get
            Return _PNCTPODC
        End Get
        Set(ByVal value As Decimal)
            _PNCTPODC = value
        End Set
    End Property


    Public Property PNNDCFCC() As Decimal
        Get
            Return _PNNDCFCC
        End Get
        Set(ByVal value As Decimal)
            _PNNDCFCC = value
        End Set
    End Property


    Public Property PNFDCFCC() As Decimal
        Get
            Return _PNFDCFCC
        End Get
        Set(ByVal value As Decimal)
            _PNFDCFCC = value
        End Set
    End Property

    Public Property PNNCRDCC() As Decimal
        Get
            Return _PNNCRDCC
        End Get
        Set(ByVal value As Decimal)
            _PNNCRDCC = value
        End Set
    End Property

    Public Property PSNTRMNL() As String
        Get
            Return _PSNTRMNL
        End Get
        Set(ByVal value As String)
            _PSNTRMNL = value
        End Set
    End Property


    'JM
    Private _PSFLGAPR As String = ""
    Public Property PSFLGAPR() As String
        Get
            Return _PSFLGAPR
        End Get
        Set(ByVal value As String)
            _PSFLGAPR = value
        End Set
    End Property

    Private _PSUSRCCO As String = ""
    Public Property PSUSRCCO() As String
        Get
            Return _PSUSRCCO
        End Get
        Set(ByVal value As String)
            _PSUSRCCO = value
        End Set
    End Property

    Private _PSNOMUAP As String
    Public Property PSNOMUAP() As String
        Get
            Return _PSNOMUAP
        End Get
        Set(ByVal value As String)
            _PSNOMUAP = value
        End Set
    End Property


    Public Property PNNPRLQD() As Decimal
        Get
            Return _PNNPRLQD
        End Get
        Set(ByVal value As Decimal)
            _PNNPRLQD = value
        End Set
    End Property

    Public Property PNNPREDOC() As Decimal
        Get
            Return _PNNPREDOC
        End Get
        Set(ByVal value As Decimal)
            _PNNPREDOC = value
        End Set
    End Property


    Public Property LISTJSON() As String
        Get
            Return _LISTJSON
        End Get
        Set(ByVal value As String)
            _LISTJSON = value
        End Set
    End Property
  

    Public Property PNCMNDA1() As Decimal
        Get
            Return _PNCMNDA1
        End Get
        Set(ByVal value As Decimal)
            _PNCMNDA1 = value
        End Set
    End Property


    Public Property PNCSRVNV() As Decimal
        Get
            Return _PNCSRVNV
        End Get
        Set(ByVal value As Decimal)
            _PNCSRVNV = value
        End Set
    End Property
    Public Property PNCCNTCS() As Decimal
        Get
            Return _PNCCNTCS
        End Get
        Set(ByVal value As Decimal)
            _PNCCNTCS = value
        End Set
    End Property

 

End Class
