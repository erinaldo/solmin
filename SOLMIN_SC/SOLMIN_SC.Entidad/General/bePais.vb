Public Class bePais
    Private _PNCPAIS As Decimal = 0
    Private _PSTCMPPS As String = ""
    Private _PSTABRPS As String = ""
    Private _PSTMNDA1 As String = ""
    Private _PSCPAISR As String = ""

    Public Property PNCPAIS() As Decimal
        Get
            Return (_PNCPAIS)
        End Get
        Set(ByVal value As Decimal)
            _PNCPAIS = value
        End Set
    End Property
    Public Property PSTCMPPS() As String
        Get
            Return (_PSTCMPPS)
        End Get
        Set(ByVal value As String)
            _PSTCMPPS = value
        End Set
    End Property
    Public Property PSTABRPS() As String
        Get
            Return (_PSTABRPS)
        End Get
        Set(ByVal value As String)
            _PSTABRPS = value
        End Set
    End Property
    Public Property PSTMNDA1() As String
        Get
            Return (_PSTMNDA1)
        End Get
        Set(ByVal value As String)
            _PSTMNDA1 = value
        End Set
    End Property
    Public Property PSCPAISR() As String
        Get
            Return (_PSCPAISR)
        End Get
        Set(ByVal value As String)
            _PSCPAISR = value
        End Set
    End Property
  
End Class
