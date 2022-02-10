Public Class beSector 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT

    Private _cdscsp As String = String.Empty

    ''' <summary>
    ''' código
    ''' </summary>
    Property Cdscsp() As String
        Get
            Return _cdscsp
        End Get
        Set(ByVal value As String)
            _cdscsp = value
        End Set
    End Property

    Private _tdscsp As String = String.Empty
    ''' <summary>
    ''' Descripción
    ''' </summary>
    Property Tdscsp() As String
        Get
            Return _tdscsp
        End Get
        Set(ByVal value As String)
            _tdscsp = value
        End Set
    End Property

End Class
