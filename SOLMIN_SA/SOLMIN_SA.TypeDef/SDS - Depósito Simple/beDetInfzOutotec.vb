
Public Class beDetInfzOutotec
    Inherits beBase(Of beDetInfzOutotec)

    Private _ctpdoc As String
    Private _npensa As Integer
    Private _norden As Integer
    Private _citems As String
    Private _nserie As String
    Private _cunmed As String
    Private _qitems As Decimal
    Private _qunida As Integer
    Private _icosmn As Double
    Private _icosme As Double
    Private _cubica As String
    Private _norped As Short

    Public Property ctpdoc() As String
        Get
            Return (_ctpdoc)
        End Get
        Set(ByVal value As String)
            _ctpdoc = value
        End Set
    End Property
    Public Property npensa() As Integer
        Get
            Return (_npensa)
        End Get
        Set(ByVal value As Integer)
            _npensa = value
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
    Public Property icosmn() As Double
        Get
            Return (_icosmn)
        End Get
        Set(ByVal value As Double)
            _icosmn = value
        End Set
    End Property
    Public Property icosme() As Double
        Get
            Return (_icosme)
        End Get
        Set(ByVal value As Double)
            _icosme = value
        End Set
    End Property
    Public Property cubica() As String
        Get
            Return (_cubica)
        End Get
        Set(ByVal value As String)
            _cubica = value
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


    Private _nordpr As String
    Public Property nordpr() As String
        Get
            Return _nordpr
        End Get
        Set(ByVal value As String)
            _nordpr = value
        End Set
    End Property


    Private _nordsr As Int64
    Public Property nordsr() As Int64
        Get
            Return _nordsr
        End Get
        Set(ByVal value As Int64)
            _nordsr = value
        End Set
    End Property


    Private _NSLCSR As Int64
    Public Property NSLCSR() As Int64
        Get
            Return _NSLCSR
        End Get
        Set(ByVal value As Int64)
            _NSLCSR = value
        End Set
    End Property


    Private _nritoc As Int32
    Public Property nritoc() As Int32
        Get
            Return _nritoc
        End Get
        Set(ByVal value As Int32)
            _nritoc = value
        End Set
    End Property

    Public Sub New()
        Me.InicializeProperty(Me)
    End Sub



    Private _olistaProyecto As List(Of beProyecto)
    Public Property olistaProyecto() As List(Of beProyecto)
        Get
            Return _olistaProyecto
        End Get
        Set(ByVal value As List(Of beProyecto))
            _olistaProyecto = value
        End Set
    End Property

End Class