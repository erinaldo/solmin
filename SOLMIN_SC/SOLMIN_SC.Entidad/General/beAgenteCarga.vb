Public Class beAgenteCarga
    Private _PNCAGNCR As Decimal = 0
    Public Property PNCAGNCR() As Decimal
        Get
            Return (_PNCAGNCR)
        End Get
        Set(ByVal value As Decimal)
            _PNCAGNCR = value
        End Set
    End Property
    Private _PSTNMAGC As String = ""
    Public Property PSTNMAGC() As String
        Get
            Return (_PSTNMAGC)
        End Get
        Set(ByVal value As String)
            _PSTNMAGC = value
        End Set
    End Property
End Class
