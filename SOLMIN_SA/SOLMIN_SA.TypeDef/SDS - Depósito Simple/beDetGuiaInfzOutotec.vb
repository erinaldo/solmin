Public Class beDetGuiaInfzOutotec

    Private _nguias As Integer
    Private _norden As Integer
    Private _citems As String
    Private _ditems As String
    Private _nserie As String
    Private _cunmed As String
    Private _qitems As Decimal
    Private _qunida As Integer
    Private _qsaldo As Decimal
    Private _norped As Short
    Private _norocc As Short
    Private _calmac As String

    Public Property nguias() As Integer
        Get
            Return (_nguias)
        End Get
        Set(ByVal value As Integer)
            _nguias = value
        End Set
    End Property
    Public Property norden() As Integer
        Get
            Return (_norden)
        End Get
        Set(ByVal value As Integer)
            _norden = value
        End Set
    End Property
    Public Property citems() As String
        Get
            Return (_citems)
        End Get
        Set(ByVal value As String)
            _citems = value
        End Set
    End Property
    Public Property ditems() As String
        Get
            Return (_ditems)
        End Get
        Set(ByVal value As String)
            _ditems = value
        End Set
    End Property
    Public Property nserie() As String
        Get
            Return (_nserie)
        End Get
        Set(ByVal value As String)
            _nserie = value
        End Set
    End Property
    Public Property cunmed() As String
        Get
            Return (_cunmed)
        End Get
        Set(ByVal value As String)
            _cunmed = value
        End Set
    End Property
    Public Property qitems() As Decimal
        Get
            Return (_qitems)
        End Get
        Set(ByVal value As Decimal)
            _qitems = value
        End Set
    End Property
    Public Property qunida() As Integer
        Get
            Return (_qunida)
        End Get
        Set(ByVal value As Integer)
            _qunida = value
        End Set
    End Property
    Public Property qsaldo() As Decimal
        Get
            Return (_qsaldo)
        End Get
        Set(ByVal value As Decimal)
            _qsaldo = value
        End Set
    End Property
    Public Property norped() As Short
        Get
            Return (_norped)
        End Get
        Set(ByVal value As Short)
            _norped = value
        End Set
    End Property
    Public Property norocc() As Short
        Get
            Return (_norocc)
        End Get
        Set(ByVal value As Short)
            _norocc = value
        End Set
    End Property
    Public Property calmac() As String
        Get
            Return (_calmac)
        End Get
        Set(ByVal value As String)
            _calmac = value
        End Set
    End Property


    Private _codcli As String
    Public Property codcli() As String
        Get
            Return _codcli
        End Get
        Set(ByVal value As String)
            _codcli = value
        End Set
    End Property

End Class
