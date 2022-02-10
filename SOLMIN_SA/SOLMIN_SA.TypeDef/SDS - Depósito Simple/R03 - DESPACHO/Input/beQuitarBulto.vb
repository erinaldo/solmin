Public Class beQuitarBulto 'ECM-HUNDRED-PRE-DESPACHOS-POR-PEDIDO-DE-TRASLADO(PYP_000221)
    Private _cidpaq As String
    ''' <summary>
    ''' Código de identificación de paquete
    ''' </summary>
    Public Property cidpaq() As String
        Get
            Return _cidpaq
        End Get
        Set(ByVal value As String)
            _cidpaq = value
        End Set
    End Property

    Private _norcml As String
    ''' <summary>
    ''' Número OC
    ''' </summary>
    Public Property norcml() As String
        Get
            Return _norcml
        End Get
        Set(ByVal value As String)
            _norcml = value
        End Set
    End Property

    Private _nritoc As String
    ''' <summary>
    ''' Número Ítem
    ''' </summary>
    Public Property nritoc() As String
        Get
            Return _nritoc
        End Get
        Set(ByVal value As String)
            _nritoc = value
        End Set
    End Property

    Private _nrosec As Double
    ''' <summary>
    ''' Número Ítem del Pedido de traslado
    ''' </summary>
    Public Property nrosec() As Double
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
    Public Property qbltsr() As Double
        Get
            Return _qbltsr
        End Get
        Set(ByVal value As Double)
            _qbltsr = value
        End Set
    End Property


    Private _usuari As String
    ''' <summary>
    ''' Usuario del sistema
    ''' </summary>
    Public Property usuari() As String
        Get
            Return _usuari
        End Get
        Set(ByVal value As String)
            _usuari = value
        End Set
    End Property
End Class
