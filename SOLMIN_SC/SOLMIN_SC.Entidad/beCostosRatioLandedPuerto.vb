Public Class beCostosRatioLandedPuerto
    Private _PSCPAIS As String = ""
    Private _PSTCMPPS As String = ""
    Private _PSCODZONA As String = ""
    Private _PSDESZONA As String = ""
    Private _PSCODPUERTO As String = ""
    Private _PSDESPUERTO As String = ""
    Private _PNMARITMO As New beCostosRatio
    Private _PNAEREO As New beCostosRatio
    Private _PNTERRESTRE As New beCostosRatio
    Public Property PSCPAIS() As String
        Get
            Return _PSCPAIS
        End Get
        Set(ByVal value As String)
            _PSCPAIS = value
        End Set
    End Property


    Public Property PSTCMPPS() As String
        Get
            Return _PSTCMPPS
        End Get
        Set(ByVal value As String)
            _PSTCMPPS = value
        End Set
    End Property

    Public Property PSCODZONA() As String
        Get
            Return _PSCODZONA
        End Get
        Set(ByVal value As String)
            _PSCODZONA = value
        End Set
    End Property

    Public Property PSDESZONA() As String
        Get
            Return _PSDESZONA
        End Get
        Set(ByVal value As String)
            _PSDESZONA = value
        End Set
    End Property
    Public Property PSCODPUERTO() As String
        Get
            Return _PSCODPUERTO
        End Get
        Set(ByVal value As String)
            _PSCODPUERTO = value
        End Set
    End Property
    Public Property PSDESPUERTO() As String
        Get
            Return _PSDESPUERTO
        End Get
        Set(ByVal value As String)
            _PSDESPUERTO = value
        End Set
    End Property

    Public Property PNMARITMO() As beCostosRatio
        Get
            Return _PNMARITMO
        End Get
        Set(ByVal value As beCostosRatio)
            _PNMARITMO = value
        End Set
    End Property


    Public Property PNAEREO() As beCostosRatio
        Get
            Return _PNAEREO
        End Get
        Set(ByVal value As beCostosRatio)
            _PNAEREO = value
        End Set
    End Property


    Public Property PNTERRESTRE() As beCostosRatio
        Get
            Return _PNTERRESTRE
        End Get
        Set(ByVal value As beCostosRatio)
            _PNTERRESTRE = value
        End Set
    End Property

End Class
