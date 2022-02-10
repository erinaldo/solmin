Public Class CentroCostoTarifa
    Private _COD_CECO As String = ""
    Private _DESC_CECO As String = ""
    Private _CODSAP_CECO As String = ""
    Private _COD_CEBE As String = ""
    Private _DESC_CEBE As String = ""

    Property COD_CECO() As String
        Get
            Return _COD_CECO
        End Get
        Set(ByVal value As String)
            _COD_CECO = value
        End Set
    End Property

    Property DESC_CECO() As String
        Get
            Return _DESC_CECO
        End Get
        Set(ByVal value As String)
            _DESC_CECO = value
        End Set
    End Property

    Property CODSAP_CECO() As String
        Get
            Return _CODSAP_CECO
        End Get
        Set(ByVal value As String)
            _CODSAP_CECO = value
        End Set
    End Property


    Private _CODSAP_CEBE As String
    Public Property CODSAP_CEBE() As String
        Get
            Return _CODSAP_CEBE
        End Get
        Set(ByVal value As String)
            _CODSAP_CEBE = value
        End Set
    End Property




    Property COD_CEBE() As String
        Get
            Return _COD_CEBE
        End Get
        Set(ByVal value As String)
            _COD_CEBE = value
        End Set
    End Property

    Property DESC_CEBE() As String
        Get
            Return _DESC_CEBE
        End Get
        Set(ByVal value As String)
            _DESC_CEBE = value
        End Set
    End Property

End Class
