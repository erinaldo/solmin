Public Class beOperacionRegimen
    Private _PSCCMPN As String = ""
    Private _PNTPORGE As Decimal = 0
    Private _PNTPOPRG As Decimal = 0
    Private _PSTCMPRO As String = ""

    Public Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property

    Public Property PNTPORGE() As Decimal
        Get
            Return _PNTPORGE
        End Get
        Set(ByVal value As Decimal)
            _PNTPORGE = value
        End Set
    End Property
    Public Property PNTPOPRG() As Decimal
        Get
            Return _PNTPOPRG
        End Get
        Set(ByVal value As Decimal)
            _PNTPOPRG = value
        End Set
    End Property

    Public Property PSTCMPRO() As String
        Get
            Return _PSTCMPRO
        End Get
        Set(ByVal value As String)
            _PSTCMPRO = value
        End Set
    End Property

End Class
