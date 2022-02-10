Public Class OuCeBePorSector 'ECM-ValidacionSectorCliente[RF001]-160516
    Private _CCNTCS As String = String.Empty
    ''' <summary>
    ''' Cód. Centro de Beneficio
    ''' </summary>
    Public Property CCNTCS() As String
        Get
            Return _CCNTCS
        End Get
        Set(ByVal value As String)
            _CCNTCS = value
        End Set
    End Property

    Private _CCNBNS As String = String.Empty
    ''' <summary>
    ''' Centro Beneficio SAP
    ''' </summary>
    Public Property CCNBNS() As String
        Get
            Return _CCNBNS
        End Get
        Set(ByVal value As String)
            _CCNBNS = value
        End Set
    End Property

    Private _TCNTCS As String = String.Empty
    ''' <summary>
    ''' Descripción Centro Beneficio
    ''' </summary>
    Public Property TCNTCS() As String
        Get
            Return _TCNTCS
        End Get
        Set(ByVal value As String)
            _TCNTCS = value
        End Set
    End Property

    Private _color As Drawing.Color
    ''' <summary>
    ''' Color de registro del texto
    ''' </summary>
    Public Property ColorRegistro() As Drawing.Color
        Get
            Return _color
        End Get
        Set(ByVal value As Drawing.Color)
            _color = value
        End Set
    End Property
End Class
