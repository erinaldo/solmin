Public Class beForol
    Private strOS As String
    Private strCliente As String
    Private strProveedor As String
    Private strMercaderia As String
    Private strRefCliente As String
    Private strMedio As String
    Private strRegimen As String
    Private strDespacho As String
    Private strBeneficio As String
    Private strTercero As String
    Private strTransporte As String
    Private strDireccion As String
    Private strHorario As String
    Private strContacto As String
    Private strObservacion1 As String
    Private strObservacion2 As String
    Private oDtDocumentos As DataTable

    Property Documentos()
        Get
            Return Me.oDtDocumentos
        End Get
        Set(ByVal value)
            Me.oDtDocumentos = value
        End Set
    End Property

    Property Tercero()
        Get
            Return Me.strTercero
        End Get
        Set(ByVal value)
            Me.strTercero = value
        End Set
    End Property

    Property Mercaderia()
        Get
            Return Me.strMercaderia
        End Get
        Set(ByVal value)
            Me.strMercaderia = value
        End Set
    End Property

    Property Observacion2()
        Get
            Return Me.strObservacion2
        End Get
        Set(ByVal value)
            Me.strObservacion2 = value
        End Set
    End Property

    Property Observacion1()
        Get
            Return Me.strObservacion1
        End Get
        Set(ByVal value)
            Me.strObservacion1 = value
        End Set
    End Property

    Property Contacto()
        Get
            Return Me.strContacto
        End Get
        Set(ByVal value)
            Me.strContacto = value
        End Set
    End Property

    Property Horario()
        Get
            Return Me.strHorario
        End Get
        Set(ByVal value)
            Me.strHorario = value
        End Set
    End Property

    Property Direccion()
        Get
            Return Me.strDireccion
        End Get
        Set(ByVal value)
            Me.strDireccion = value
        End Set
    End Property

    Property Transporte()
        Get
            Return Me.strTransporte
        End Get
        Set(ByVal value)
            Me.strTransporte = value
        End Set
    End Property

    Property Beneficio()
        Get
            Return Me.strBeneficio
        End Get
        Set(ByVal value)
            Me.strBeneficio = value
        End Set
    End Property

    Property Despacho()
        Get
            Return strDespacho
        End Get
        Set(ByVal value)
            Me.strDespacho = value
        End Set
    End Property

    Property Regimen()
        Get
            Return Me.strRegimen
        End Get
        Set(ByVal value)
            Me.strRegimen = value
        End Set
    End Property

    Property Medio()
        Get
            Return strMedio
        End Get
        Set(ByVal value)
            Me.strMedio = value
        End Set
    End Property

    Property RefCliente()
        Get
            Return Me.strRefCliente
        End Get
        Set(ByVal value)
            Me.strRefCliente = value
        End Set
    End Property

    Property Proveedor()
        Get
            Return Me.strProveedor
        End Get
        Set(ByVal value)
            Me.strProveedor = value
        End Set
    End Property

    Property Cliente()
        Get
            Return Me.strCliente
        End Get
        Set(ByVal value)
            Me.strCliente = value
        End Set
    End Property

    Property OS()
        Get
            Return Me.strOS
        End Get
        Set(ByVal value)
            Me.strOS = value
        End Set
    End Property
End Class
