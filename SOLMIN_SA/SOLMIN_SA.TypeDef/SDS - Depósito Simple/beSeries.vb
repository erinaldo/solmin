Public Class beSeries

    Inherits beBase(Of beSeries)

    Private _PNNPDDPR As Decimal = 0
    Private _PNNSRIE As Decimal = 0
    Private _PSCMRCD As String = ""
    Private _PSTABRMR As String = ""
    Private _PSTMRCSR As String = ""
    Private _PNQBLTS As Decimal = 0

    Private _PSCCLTPB As String = ""
    Private _PNQBLTSB As Decimal = 0
    Private _PNPBRKL As Decimal = 0
    Private _PNPNTKL As Decimal = 0
    Private _PNQBLTSR As Decimal = 0
    Private _PNPBRKLR As Decimal = 0
    Private _PNPNTKLR As Decimal = 0

    Private _PNQTTLBC As Decimal = 0
    Private _PNQTTLBP As Decimal = 0
    Private _PNQTTLBV As Decimal = 0
    'Private _PNNPDDPR As Decimal = 0

    Public Property PNNPDDPR() As Decimal
        Get
            Return (_PNNPDDPR)
        End Get
        Set(ByVal value As Decimal)
            _PNNPDDPR = value
        End Set
    End Property

    Public Property PNNSRIE() As Decimal
        Get
            Return (_PNNSRIE)
        End Get
        Set(ByVal value As Decimal)
            _PNNSRIE = value
        End Set
    End Property

    Public Property PSCMRCD() As String
        Get
            Return (_PSCMRCD)
        End Get
        Set(ByVal value As String)
            _PSCMRCD = value
        End Set
    End Property

    Public Property PSTABRMR() As String
        Get
            Return (_PSTABRMR)
        End Get
        Set(ByVal value As String)
            _PSTABRMR = value
        End Set
    End Property

    Public Property PSTMRCSR() As String
        Get
            Return (_PSTMRCSR)
        End Get
        Set(ByVal value As String)
            _PSTMRCSR = value
        End Set
    End Property

    Public Property PNQBLTS() As Decimal
        Get
            Return (_PNQBLTS)
        End Get
        Set(ByVal value As Decimal)
            _PNQBLTS = value
        End Set
    End Property

    Public Property PSCCLTPB() As String
        Get
            Return (_PSCCLTPB)
        End Get
        Set(ByVal value As String)
            _PSCCLTPB = value
        End Set
    End Property

    Public Property PNQBLTSB() As Decimal
        Get
            Return (_PNQBLTSB)
        End Get
        Set(ByVal value As Decimal)
            _PNQBLTSB = value
        End Set
    End Property

    Public Property PNPBRKL() As Decimal
        Get
            Return (_PNPBRKL)
        End Get
        Set(ByVal value As Decimal)
            _PNPBRKL = value
        End Set
    End Property

    Public Property PNPNTKL() As Decimal
        Get
            Return (_PNPNTKL)
        End Get
        Set(ByVal value As Decimal)
            _PNPNTKL = value
        End Set
    End Property

    Public Property PNQBLTSR() As Decimal
        Get
            Return (_PNQBLTSR)
        End Get
        Set(ByVal value As Decimal)
            _PNQBLTSR = value
        End Set
    End Property

    Public Property PNPBRKLR() As Decimal
        Get
            Return (_PNPBRKLR)
        End Get
        Set(ByVal value As Decimal)
            _PNPBRKLR = value
        End Set
    End Property

    Public Property PNPNTKLR() As Decimal
        Get
            Return (_PNPNTKLR)
        End Get
        Set(ByVal value As Decimal)
            _PNPNTKLR = value
        End Set
    End Property

    Public Property PNQTTLBC() As Decimal
        Get
            Return (_PNQTTLBC)
        End Get
        Set(ByVal value As Decimal)
            _PNQTTLBC = value
        End Set
    End Property

    Public Property PNQTTLBP() As Decimal
        Get
            Return (_PNQTTLBP)
        End Get
        Set(ByVal value As Decimal)
            _PNQTTLBP = value
        End Set
    End Property

    Public Property PNQTTLBV() As Decimal
        Get
            Return (_PNQTTLBV)
        End Get
        Set(ByVal value As Decimal)
            _PNQTTLBV = value
        End Set
    End Property

End Class
