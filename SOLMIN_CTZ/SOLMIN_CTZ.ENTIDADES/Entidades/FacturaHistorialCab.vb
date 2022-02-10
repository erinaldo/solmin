Public Class FacturaHistorialCab

    Private _PSCCMPN As String = ""
    Private _PSCDVSN As String = ""
    Private _PNCCLNT As Decimal = 0
    Private _PNNOPRCN As Decimal = 0
    Private _PNNCRRFC As Decimal = 0
    Private _PNCTPODC As Decimal = 0
    Private _PNNDCFCC As Decimal = 0
    Private _PNFDCFCC As Decimal = 0
    Private _PNCMNDA1 As Decimal = 0
    Private _PNIVLSRV As Decimal = 0
    Private _LISTJSON As String = ""
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


    Public Property PNCMNDA1() As Decimal
        Get
            Return _PNCMNDA1
        End Get
        Set(ByVal value As Decimal)
            _PNCMNDA1 = value
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


    Private _PSSDCMLQ As String
    Public Property PSSDCMLQ() As String
        Get
            Return _PSSDCMLQ
        End Get
        Set(ByVal value As String)
            _PSSDCMLQ = value
        End Set
    End Property


    Private _PNNDSPGD As Decimal
    Public Property PNNDSPGD() As Decimal
        Get
            Return _PNNDSPGD
        End Get
        Set(ByVal value As Decimal)
            _PNNDSPGD = value
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



End Class
