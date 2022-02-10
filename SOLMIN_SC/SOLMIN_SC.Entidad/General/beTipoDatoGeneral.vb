Public Class beTipoDatoGeneral


    Private _PSCCMPRN As String = ""
    Public Property PSCCMPRN() As String
        Get
            Return (_PSCCMPRN)
        End Get
        Set(ByVal value As String)
            _PSCCMPRN = value
        End Set
    End Property

    Private _PSTDSDES As String = ""
    Public Property PSTDSDES() As String
        Get
            Return (_PSTDSDES)
        End Get
        Set(ByVal value As String)
            _PSTDSDES = value
        End Set
    End Property

End Class
