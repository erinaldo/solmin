Public Class beImputCeCo 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT

    Private _ccmpn As String = String.Empty
    ''' <summary>
    ''' 
    ''' </summary>
    Public Property CCMPN() As String
        Get
            Return (_ccmpn)
        End Get
        Set(ByVal value As String)
            _ccmpn = value
        End Set
    End Property

    Private _codCeBe As String = String.Empty
    ''' <summary>
    ''' Código CeBe
    ''' </summary>
    Public Property CODCEBE() As String
        Get
            Return (_codCeBe)
        End Get
        Set(ByVal value As String)
            _codCeBe = value
        End Set
    End Property

    Private _codigo As String = String.Empty
    ''' <summary>
    ''' Código
    ''' </summary>
    Public Property Codigo() As String
        Get
            Return (_codigo)
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    Private _descripcion As String = String.Empty
    ''' <summary>
    ''' Descripción
    ''' </summary>
    Public Property Descripcion() As String
        Get
            Return (_descripcion)
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Private _codigoSAP As String = String.Empty
    ''' <summary>
    ''' Código SAP
    ''' </summary>
    Public Property CodigoSAP() As String
        Get
            Return (_codigoSAP)
        End Get
        Set(ByVal value As String)
            _codigoSAP = value
        End Set
    End Property

End Class
