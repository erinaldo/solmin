Public Class beDetInfzPedidoOuototec

    Private _nordpe As String
    Private _norden As Short
    Private _citems As String
    Private _ditems As String
    Private _cunico As String
    Private _qitems As Decimal
    Private _ipruni As Decimal
    Private _ndiaen As Short
    Private _qitegu As Decimal
    Private _ccosto As String
    Private _sstcom As String
    Private _frepro As DateTime
    Private _cmtrep As String

    Public Property nordpe() As String
        Get
            Return (_nordpe)
        End Get
        Set(ByVal value As String)
            _nordpe = value
        End Set
    End Property
    Public Property norden() As Short
        Get
            Return (_norden)
        End Get
        Set(ByVal value As Short)
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
    Public Property cunico() As String
        Get
            Return (_cunico)
        End Get
        Set(ByVal value As String)
            _cunico = value
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
    Public Property ipruni() As Decimal
        Get
            Return (_ipruni)
        End Get
        Set(ByVal value As Decimal)
            _ipruni = value
        End Set
    End Property
    Public Property ndiaen() As Short
        Get
            Return (_ndiaen)
        End Get
        Set(ByVal value As Short)
            _ndiaen = value
        End Set
    End Property
    Public Property qitegu() As Decimal
        Get
            Return (_qitegu)
        End Get
        Set(ByVal value As Decimal)
            _qitegu = value
        End Set
    End Property
    Public Property ccosto() As String
        Get
            Return (_ccosto)
        End Get
        Set(ByVal value As String)
            _ccosto = value
        End Set
    End Property
    Public Property sstcom() As String
        Get
            Return (_sstcom)
        End Get
        Set(ByVal value As String)
            _sstcom = value
        End Set
    End Property
    Public Property frepro() As DateTime
        Get
            Return (_frepro)
        End Get
        Set(ByVal value As DateTime)
            _frepro = value
        End Set
    End Property
    Public Property cmtrep() As String
        Get
            Return (_cmtrep)
        End Get
        Set(ByVal value As String)
            _cmtrep = value
        End Set
    End Property

    Private _codcli As Integer
    Public Property codcli() As Integer
        Get
            Return _codcli
        End Get
        Set(ByVal value As Integer)
            _codcli = value
        End Set
    End Property


    Private _usuario As String
    Public Property usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

End Class