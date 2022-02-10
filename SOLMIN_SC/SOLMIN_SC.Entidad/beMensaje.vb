Public Class beMensaje
    Private _PBEXITO As Boolean
    Private _PSMENSAJE As String = ""
    Public Property PBEXITO() As Boolean
        Get
            Return _PBEXITO
        End Get
        Set(ByVal value As Boolean)
            _PBEXITO = value
        End Set
    End Property

    Public Property PSMENSAJE() As String
        Get
            Return _PSMENSAJE
        End Get
        Set(ByVal value As String)
            _PSMENSAJE = value
        End Set
    End Property
End Class
