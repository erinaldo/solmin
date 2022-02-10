Public Class CtaCte_Observacion
    Inherits CuentaCorriente

    Private _NCRDSC As String = ""
    Private _TOBCTC As String = ""

    Property NCRDSC() As String
        Get
            Return _NCRDSC
        End Get
        Set(ByVal value As String)
            _NCRDSC = value
        End Set
    End Property

    Property TOBCTC() As String
        Get
            Return _TOBCTC
        End Get
        Set(ByVal value As String)
            _TOBCTC = value
        End Set
    End Property

End Class
