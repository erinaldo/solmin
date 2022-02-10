Public Class bePartidaArancelaria
    Private _PSCPTDAR As String = String.Empty
    Private _PSTDEPTD As String = String.Empty
    Private _PNPRARAN As Decimal = 0
    Private _PSUSUARIO As String = ""
    Public Property PSCPTDAR() As String
        Get
            Return _PSCPTDAR
        End Get
        Set(ByVal value As String)
            _PSCPTDAR = value
        End Set
    End Property


    Public Property PSTDEPTD() As String
        Get
            Return _PSTDEPTD
        End Get
        Set(ByVal value As String)
            _PSTDEPTD = value
        End Set
    End Property


    Public Property PNPRARAN() As Decimal
        Get
            Return _PNPRARAN
        End Get
        Set(ByVal value As Decimal)
            _PNPRARAN = value
        End Set
    End Property

    Public Property PSUSUARIO() As String
        Get
            Return _PSUSUARIO
        End Get
        Set(ByVal value As String)
            _PSUSUARIO = value
        End Set
    End Property
End Class
