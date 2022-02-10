Public Class bePedidoTrasladoxBulto 'ECM-HUNDRED-PRE-DESPACHOS-POR-PEDIDO-DE-TRASLADO(PYP_000221)

    Private _Pncclnt As Decimal
    ''' <summary>
    ''' Cliente
    ''' </summary>
    Public Property Pncclnt() As Decimal
        Get
            Return _Pncclnt
        End Get
        Set(ByVal value As Decimal)
            _Pncclnt = value
        End Set
    End Property

    Private _Psccmpn As String
    ''' <summary>
    ''' Compañía
    ''' </summary>
    Public Property Psccmpn() As String
        Get
            Return _Psccmpn
        End Get
        Set(ByVal value As String)
            _Psccmpn = value
        End Set
    End Property

    Private _Pscdvsn As String
    ''' <summary>
    ''' División
    ''' </summary>
    Public Property Pscdvsn() As String
        Get
            Return _Pscdvsn
        End Get
        Set(ByVal value As String)
            _Pscdvsn = value
        End Set
    End Property

    Private _Pncplndv As Decimal
    ''' <summary>
    ''' Planta
    ''' </summary>
    Public Property Pncplndv() As Decimal
        Get
            Return _Pncplndv
        End Get
        Set(ByVal value As Decimal)
            _Pncplndv = value
        End Set
    End Property

    Private _Pscreffw As String
    ''' <summary>
    ''' Código bulto
    ''' </summary>
    Public Property Pscreffw() As String
        Get
            Return _Pscreffw
        End Get
        Set(ByVal value As String)
            _Pscreffw = value
        End Set
    End Property

    Private _Pnnseqin As Decimal
    ''' <summary>
    ''' Número de secuencia
    ''' </summary>
    Public Property Pnnseqin() As Decimal
        Get
            Return _Pnnseqin
        End Get
        Set(ByVal value As Decimal)
            _Pnnseqin = value
        End Set
    End Property

    Private _Nrpdts As String
    ''' <summary>
    ''' Número de pedido
    ''' </summary>
    Public Property psnrpdts() As String
        Get
            Return _Nrpdts
        End Get
        Set(ByVal value As String)
            _Nrpdts = value
        End Set
    End Property

    Private _pnnroctl As String
    ''' <summary>
    ''' Número de despacho
    ''' </summary>
    Public Property pnnroctl() As String
        Get
            Return _pnnroctl
        End Get
        Set(ByVal value As String)
            _pnnroctl = value
        End Set
    End Property


End Class
