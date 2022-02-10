
Public Class beProyecto
    Inherits beBase(Of beProyecto)
    Public Sub New()
        InicializeProperty(Me)
    End Sub

    Private _PNCCNLT As Decimal
    Private _PSNORCML As String
    Private _PNNRITOC As Decimal
    Private _PSNRFRPD As String
    Private _PNQCNTIT As Decimal
    Private _PNQCNTIT2 As Decimal
    Private _PNQTRMC As Decimal
    Private _PSCMRCLR As String


    Private _PSSTPING As String
    Public Property PSSTPING() As String
        Get
            Return _PSSTPING
        End Get
        Set(ByVal value As String)
            _PSSTPING = value
        End Set
    End Property


    Private _PNQCNRCP As Decimal
    Public Property PNQCNRCP() As Decimal
        Get
            Return _PNQCNRCP
        End Get
        Set(ByVal value As Decimal)
            _PNQCNRCP = value
        End Set
    End Property



    Private _PNQCNDPC As Decimal
    Public Property PNQCNDPC() As Decimal
        Get
            Return _PNQCNDPC
        End Get
        Set(ByVal value As Decimal)
            _PNQCNDPC = value
        End Set
    End Property


    Private _PNQPENDI As Decimal
    Public Property PNQPENDI() As Decimal
        Get
            Return _PNQPENDI
        End Get
        Set(ByVal value As Decimal)
            _PNQPENDI = value
        End Set
    End Property

    Public Property PNCCLNT() As Decimal
        Get
            Return (_PNCCNLT)
        End Get
        Set(ByVal value As Decimal)
            _PNCCNLT = value
        End Set
    End Property

    Public Property PSNORCML() As String
        Get
            Return (_PSNORCML)
        End Get
        Set(ByVal value As String)
            _PSNORCML = value
        End Set
    End Property

    Public Property PNNRITOC() As Decimal
        Get
            Return (_PNNRITOC)
        End Get
        Set(ByVal value As Decimal)
            _PNNRITOC = value
        End Set
    End Property

    ''' <summary>
    ''' Nr Proyecto o pedido
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSNRFRPD() As String
        Get
            Return (_PSNRFRPD)
        End Get
        Set(ByVal value As String)
            _PSNRFRPD = value
        End Set
    End Property


    Private _PNNCRRDT As Decimal
    Public Property PNNCRRDT() As Decimal
        Get
            Return _PNNCRRDT
        End Get
        Set(ByVal value As Decimal)
            _PNNCRRDT = value
        End Set
    End Property


    Public Property PNQCNTIT() As Decimal
        Get
            Return (_PNQCNTIT)
        End Get
        Set(ByVal value As Decimal)
            _PNQCNTIT = value
        End Set
    End Property

    Public Property PNQCNTIT2() As Decimal
        Get
            Return (_PNQCNTIT2)
        End Get
        Set(ByVal value As Decimal)
            _PNQCNTIT2 = value
        End Set
    End Property

    Public Property PNQTRMC() As Decimal
        Get
            Return (_PNQTRMC)
        End Get
        Set(ByVal value As Decimal)
            _PNQTRMC = value
        End Set
    End Property

    Public Property PSCMRCLR() As String
        Get
            Return (_PSCMRCLR)
        End Get
        Set(ByVal value As String)
            _PSCMRCLR = value
        End Set
    End Property

    Private _PNNORDSR As Decimal
    Public Property PNNORDSR() As Decimal
        Get
            Return _PNNORDSR
        End Get
        Set(ByVal value As Decimal)
            _PNNORDSR = value
        End Set
    End Property

    Private _PNNSLCSR As Decimal
    Public Property PNNSLCSR() As Decimal
        Get
            Return _PNNSLCSR
        End Get
        Set(ByVal value As Decimal)
            _PNNSLCSR = value
        End Set
    End Property


    Private _PNNSLCSS As Decimal
    Public Property PNNSLCSS() As Decimal
        Get
            Return _PNNSLCSS
        End Get
        Set(ByVal value As Decimal)
            _PNNSLCSS = value
        End Set
    End Property


    Private _PNCSRVC As Decimal
    Public Property PNCSRVC() As Decimal
        Get
            Return _PNCSRVC
        End Get
        Set(ByVal value As Decimal)
            _PNCSRVC = value
        End Set
    End Property

    Private _QCNTIT_ITEM As Decimal
    Public Property PNQCNTIT_ITEM() As Decimal
        Get
            Return _QCNTIT_ITEM
        End Get
        Set(ByVal value As Decimal)
            _QCNTIT_ITEM = value
        End Set
    End Property


    Private _PNQINMC2 As Decimal
    Public Property PNQINMC2() As Decimal
        Get
            Return _PNQINMC2
        End Get
        Set(ByVal value As Decimal)
            _PNQINMC2 = value
        End Set
    End Property


    Private _PNQSTKIT As Decimal
    Public Property PNQSTKIT() As Decimal
        Get
            Return _PNQSTKIT
        End Get
        Set(ByVal value As Decimal)
            _PNQSTKIT = value
        End Set
    End Property


End Class
