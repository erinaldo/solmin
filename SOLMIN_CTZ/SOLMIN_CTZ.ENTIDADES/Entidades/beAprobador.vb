Public Class beAprobador 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
    Private _usuario As String = String.Empty
    ''' <summary>
    ''' Usuario
    ''' </summary>
    Public Property Usuario() As String
        Get
            Return (_usuario)
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    Private _nombre As String = String.Empty
    ''' <summary>
    ''' Nombre
    ''' </summary>
    Public Property Nombre() As String
        Get
            Return (_nombre)
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property
End Class
