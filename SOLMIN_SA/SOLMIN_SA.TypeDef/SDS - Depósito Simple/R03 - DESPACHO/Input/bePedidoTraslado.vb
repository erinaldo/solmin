Public Class bePedidoTraslado 'ECM-HUNDRED-PRE-DESPACHOS-POR-PEDIDO-DE-TRASLADO(PYP_000221)
    Private _ccmpn As String
    ''' <summary>
    ''' Compañía
    ''' </summary>
    Public Property In_ccmpn() As String
        Get
            Return _ccmpn
        End Get
        Set(ByVal value As String)
            _ccmpn = value
        End Set
    End Property


    Private _cdvsn As String
    ''' <summary>
    ''' División
    ''' </summary>
    Public Property In_cdvsn() As String
        Get
            Return _cdvsn
        End Get
        Set(ByVal value As String)
            _cdvsn = value
        End Set
    End Property

    Private _cplndv As Double
    ''' <summary>
    ''' Planta
    ''' </summary>
    Public Property In_cplndv() As Double
        Get
            Return _cplndv
        End Get
        Set(ByVal value As Double)
            _cplndv = value
        End Set
    End Property

    Private _cclnt As Double
    ''' <summary>
    ''' Cód. Cliente
    ''' </summary>
    Public Property In_cclnt() As Double
        Get
            Return _cclnt
        End Get
        Set(ByVal value As Double)
            _cclnt = value
        End Set
    End Property

    Private _creffw As String
    ''' <summary>
    ''' Bulto
    ''' </summary>
    Public Property In_creffw() As String
        Get
            Return _creffw
        End Get
        Set(ByVal value As String)
            _creffw = value
        End Set
    End Property

    Private _cidpaq As String
    ''' <summary>
    ''' Cód. Identificación de paquete
    ''' </summary>
    Public Property In_cidpaq() As String
        Get
            Return _cidpaq
        End Get
        Set(ByVal value As String)
            _cidpaq = value
        End Set
    End Property

    Private _nseqin As Double
    ''' <summary>
    ''' Nro. Secuencia
    ''' </summary>
    Public Property In_nseqin() As Double
        Get
            Return _nseqin
        End Get
        Set(ByVal value As Double)
            _nseqin = value
        End Set
    End Property

    Private _norcml As String
    ''' <summary>
    ''' Nro. OC
    ''' </summary>
    Public Property In_norcml() As String
        Get
            Return _norcml
        End Get
        Set(ByVal value As String)
            _norcml = value
        End Set
    End Property

    Private _nritoc As String
    ''' <summary>
    ''' Nro. Ítem
    ''' </summary>
    Public Property In_nritoc() As String
        Get
            Return _nritoc
        End Get
        Set(ByVal value As String)
            _nritoc = value
        End Set
    End Property

    Private _nrpdts As Double
    ''' <summary>
    ''' Número de Pedido de traslado
    ''' </summary>
    Public Property In_nrpdts() As Double
        Get
            Return _nrpdts
        End Get
        Set(ByVal value As Double)
            _nrpdts = value
        End Set
    End Property

    Private _nrosec As Double
    ''' <summary>
    ''' Nro. Ítem del Pedido de traslado
    ''' </summary>
    Public Property In_nrosec() As Double
        Get
            Return _nrosec
        End Get
        Set(ByVal value As Double)
            _nrosec = value
        End Set
    End Property

    Private _qbltsr As Double
    ''' <summary>
    ''' Saldo cantidad bulto
    ''' </summary>
    Public Property In_qbltsr() As Double
        Get
            Return _qbltsr
        End Get
        Set(ByVal value As Double)
            _qbltsr = value
        End Set
    End Property

    Private _clarsg As String
    ''' <summary>
    ''' Clase de Riesgo
    ''' </summary>
    Public Property In_clarsg() As String
        Get
            Return _clarsg
        End Get
        Set(ByVal value As String)
            _clarsg = value
        End Set
    End Property

    Private _nroonu As String
    ''' <summary>
    ''' Nro. onu
    ''' </summary>
    Public Property In_nroonu() As String
        Get
            Return _nroonu
        End Get
        Set(ByVal value As String)
            _nroonu = value
        End Set
    End Property

    Private _tpoemb As String
    ''' <summary>
    ''' Tipo Embalaje
    ''' </summary>
    Public Property In_tpoemb() As String
        Get
            Return _tpoemb
        End Get
        Set(ByVal value As String)
            _tpoemb = value
        End Set
    End Property

    Private _usuari As String
    ''' <summary>
    ''' Usuario del sistema
    ''' </summary>
    Public Property In_usuari() As String
        Get
            Return _usuari
        End Get
        Set(ByVal value As String)
            _usuari = value
        End Set
    End Property

    Private _tcitcl As String
    ''' <summary>
    ''' Cód. Material
    ''' </summary>
    Public Property In_tcitcl() As String
        Get
            Return _tcitcl
        End Get
        Set(ByVal value As String)
            _tcitcl = value
        End Set
    End Property

    Private _In_id As String
    ''' <summary>
    ''' Identificador de pedido
    ''' </summary>
    Public Property In_id() As String
        Get
            Return _In_id
        End Get
        Set(ByVal value As String)
            _In_id = value
        End Set
    End Property

End Class
