Public Class beInputValidarCentroOrigen 'ECM-HUNDRED-DEF-SOLICITUD-DE-CAMBIO-(RF-001)
    ''' <summary>
    ''' Cliente
    ''' </summary>
    Private _cclnt As Double
    Public Property Cclnt() As Double
        Get
            Return _cclnt
        End Get
        Set(ByVal value As Double)
            _cclnt = value
        End Set
    End Property

    ''' <summary>
    ''' Orden de compra
    ''' </summary>
    Private _norcml As String
    Public Property Norcml() As String
        Get
            Return _norcml
        End Get
        Set(ByVal value As String)
            _norcml = value
        End Set
    End Property

    ''' <summary>
    ''' Ítems
    ''' </summary>
    Private _item As String
    Public Property Item() As String
        Get
            Return _item
        End Get
        Set(ByVal value As String)
            _item = value
        End Set
    End Property
End Class
