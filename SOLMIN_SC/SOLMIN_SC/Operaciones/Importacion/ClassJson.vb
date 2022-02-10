Public Class ClassJson

    Private _orden_compra_sap As String = ""
    Private _bl As String = ""
    Private _id_tracking As Integer = 0
    Private _fecha_tracking As String = ""
    Private _tipo_despacho As String = ""
    Private _tipo_carga As String = ""
    Private _cantidad_bultos As Integer = 0
    Private _cantidad_contenedores As Integer = 0
    Private _fob As Decimal = 0
    Private _flete As Decimal = 0
    Private _seguro As Decimal = 0
    Private _cif As Decimal = 0
    Private _total_derechos As Integer = 0

    Private _canal As String = ""
    Private _dua As String = ""




    Public Property orden_compra_sap() As String
        Get
            Return (_orden_compra_sap)
        End Get
        Set(ByVal value As String)
            _orden_compra_sap = value
        End Set
    End Property
    Public Property bl() As String
        Get
            Return (_bl)
        End Get
        Set(ByVal value As String)
            _bl = value
        End Set
    End Property
    Public Property id_tracking() As Integer
        Get
            Return (_id_tracking)
        End Get
        Set(ByVal value As Integer)
            _id_tracking = value
        End Set
    End Property
    Public Property fecha_tracking() As String
        Get
            Return (_fecha_tracking)
        End Get
        Set(ByVal value As String)
            _fecha_tracking = value
        End Set
    End Property

    Public Property tipo_despacho() As String
        Get
            Return (_tipo_despacho)
        End Get
        Set(ByVal value As String)
            _tipo_despacho = value
        End Set
    End Property
    Public Property tipo_carga() As String
        Get
            Return (_tipo_carga)
        End Get
        Set(ByVal value As String)
            _tipo_carga = value
        End Set
    End Property
    Public Property cantidad_bultos() As Integer
        Get
            Return (_cantidad_bultos)
        End Get
        Set(ByVal value As Integer)
            _cantidad_bultos = value
        End Set
    End Property
    Public Property cantidad_contenedores() As Integer
        Get
            Return (_cantidad_contenedores)
        End Get
        Set(ByVal value As Integer)
            _cantidad_contenedores = value
        End Set
    End Property
    Public Property fob() As Decimal
        Get
            Return (_fob)
        End Get
        Set(ByVal value As Decimal)
            _fob = value
        End Set
    End Property
    Public Property flete() As Decimal
        Get
            Return (_flete)
        End Get
        Set(ByVal value As Decimal)
            _flete = value
        End Set
    End Property

    Public Property seguro() As Decimal
        Get
            Return (_seguro)
        End Get
        Set(ByVal value As Decimal)
            _seguro = value
        End Set
    End Property
    Public Property cif() As Decimal
        Get
            Return (_cif)
        End Get
        Set(ByVal value As Decimal)
            _cif = value
        End Set
    End Property

    Public Property total_derechos() As Integer
        Get
            Return (_total_derechos)
        End Get
        Set(ByVal value As Integer)
            _total_derechos = value
        End Set
    End Property

    Public Property canal() As String
        Get
            Return (_canal)
        End Get
        Set(ByVal value As String)
            _canal = value
        End Set
    End Property
    Public Property dua() As String
        Get
            Return (_dua)
        End Get
        Set(ByVal value As String)
            _dua = value
        End Set
    End Property

End Class
