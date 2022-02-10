Public Class bePlanta    'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO

    Private _cplndv As String = String.Empty
    ''' <summary>
    ''' Código
    ''' </summary>
    Property Cplndv() As String
        Get
            Return _cplndv
        End Get
        Set(ByVal value As String)
            _cplndv = value
        End Set
    End Property

    Private _tplnta As String = String.Empty
    ''' <summary>
    ''' Descripción
    ''' </summary>
    Property Tplnta() As String
        Get
            Return _tplnta
        End Get
        Set(ByVal value As String)
            _tplnta = value
        End Set
    End Property

    Private _cdspsp As String = String.Empty
    ''' <summary>
    ''' Sede
    ''' </summary>
    Property Cdspsp() As String
        Get
            Return _cdspsp
        End Get
        Set(ByVal value As String)
            _cdspsp = value
        End Set
    End Property
End Class
