Public Class beCheckPointFecha
    Private _PSDFECEST As String = ""
    Private _PSDFECREA As String = ""

    Public Property PSDFECEST() As String
        Get
            Return _PSDFECEST
        End Get
        Set(ByVal value As String)
            _PSDFECEST = value
        End Set
    End Property

    Public Property PSDFECREA() As String
        Get
            Return _PSDFECREA
        End Get
        Set(ByVal value As String)
            _PSDFECREA = value
        End Set
    End Property

End Class
