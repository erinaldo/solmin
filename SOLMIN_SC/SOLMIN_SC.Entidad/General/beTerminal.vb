Public Class beTerminal
    Private _PSCTRMAL As String = ""
    Public Property PSCTRMAL() As String
        Get
            Return (_PSCTRMAL)
        End Get
        Set(ByVal value As String)
            _PSCTRMAL = value
        End Set
    End Property
    Private _PSTTRMAL As String = ""
    Public Property PSTTRMAL() As String
        Get
            Return (_PSTTRMAL)
        End Get
        Set(ByVal value As String)
            _PSTTRMAL = value
        End Set
    End Property
End Class
