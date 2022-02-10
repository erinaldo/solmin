Public Class ClsInformacion

    Private _CODVAR As String
    Private _CCMPRN As String
    Private _TDSDES As String


    Public Property CODVAR() As String
        Get
            Return _CODVAR
        End Get
        Set(ByVal value As String)
            _CODVAR = value
        End Set
    End Property

    Public Property CCMPRN() As String
        Get
            Return _CCMPRN
        End Get
        Set(ByVal value As String)
            _CCMPRN = value
        End Set
    End Property

    Public Property TDSDES() As String
        Get
            Return _TDSDES
        End Get
        Set(ByVal value As String)
            _TDSDES = value
        End Set
    End Property

End Class
