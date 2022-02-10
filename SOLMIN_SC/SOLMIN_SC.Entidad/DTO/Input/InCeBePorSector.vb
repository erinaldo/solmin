Public Class InCeBePorSector 'ECM-ValidacionSectorCliente[RF001]-160516
    Private _CCMPN As String = String.Empty
    ''' <summary>
    ''' Compañía
    ''' </summary>
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property

    Private _CCNTCS As Decimal = 0
    ''' <summary>
    ''' Cód. Centro de Beneficio
    ''' </summary>
    Public Property CCNTCS() As Decimal
        Get
            Return _CCNTCS
        End Get
        Set(ByVal value As Decimal)
            _CCNTCS = value
        End Set
    End Property

    Private _CDSCSP As String = String.Empty
    ''' <summary>
    ''' Cód. Sector
    ''' </summary>
    Public Property CDSCSP() As String
        Get
            Return _CDSCSP
        End Get
        Set(ByVal value As String)
            _CDSCSP = value
        End Set
    End Property
End Class
