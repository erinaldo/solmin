Public Class TipoMaterial_BE

    Private _CCMPRN As String
    Public Property CCMPRN() As String
        Get
            Return _CCMPRN
        End Get
        Set(ByVal value As String)
            _CCMPRN = value
        End Set
    End Property


    Private _TDSDES As String
    Public Property TDSDES() As String
        Get
            Return _TDSDES
        End Get
        Set(ByVal value As String)
            _TDSDES = value
        End Set
    End Property

End Class
