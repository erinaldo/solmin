Public Class beCheckPointEnvio
    Private _PSTNMBCM As String = ""
    Private _PSTDESES As String = ""
    Private _PSTDESES_HTML As String = ""
    Private _PNNESTDO As Decimal = 0
    Private _PNORDEN_ANALIZAR As Int32 = 0
    Public Property PSTNMBCM() As String
        Get
            Return _PSTNMBCM
        End Get
        Set(ByVal value As String)
            _PSTNMBCM = value
        End Set
    End Property

    Public Property PSTDESES() As String
        Get
            Return _PSTDESES
        End Get
        Set(ByVal value As String)
            _PSTDESES = value
        End Set
    End Property

    Public Property PSTDESES_HTML() As String
        Get
            Return _PSTDESES_HTML
        End Get
        Set(ByVal value As String)
            _PSTDESES_HTML = value
        End Set
    End Property

    Public Property PNNESTDO() As Decimal
        Get
            Return _PNNESTDO
        End Get
        Set(ByVal value As Decimal)
            _PNNESTDO = value
        End Set
    End Property
    Public Property PNORDEN_ANALIZAR() As Int32
        Get
            Return _PNORDEN_ANALIZAR
        End Get
        Set(ByVal value As Int32)
            _PNORDEN_ANALIZAR = value
        End Set
    End Property


End Class
