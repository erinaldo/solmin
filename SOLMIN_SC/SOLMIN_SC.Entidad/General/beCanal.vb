Public Class beCanal
    Private _PSNCANAL As String = ""
    Private _PSTCANAL As String = ""
    Private _PSTCANAL_ING As String = ""

    Public Property PSNCANAL() As String
        Get
            Return _PSNCANAL
        End Get
        Set(ByVal value As String)
            _PSNCANAL = value
        End Set
    End Property
    Public Property PSTCANAL() As String
        Get
            Return _PSTCANAL
        End Get
        Set(ByVal value As String)
            _PSTCANAL = value
        End Set
    End Property
    Public Property PSTCANAL_ING() As String
        Get
            Return _PSTCANAL_ING
        End Get
        Set(ByVal value As String)
            _PSTCANAL_ING = value
        End Set
    End Property

End Class
