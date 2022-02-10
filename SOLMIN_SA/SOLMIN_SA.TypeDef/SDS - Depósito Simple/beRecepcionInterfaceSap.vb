Public Class beRecepcionInterfaceSap

    Inherits beBase(Of beRecepcionInterfaceSap)

    Public Sub New()
        Me.InicializeProperty(Me)
    End Sub


    Private _CCMPN As String = ""
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property


    Private _CCLNT As Decimal = 0
    Public Property CCLNT() As Decimal
        Get
            Return _CCLNT
        End Get
        Set(ByVal value As Decimal)
            _CCLNT = value
        End Set
    End Property



    Private _CRGVTA As String = ""
    Public Property CRGVTA() As String
        Get
            Return _CRGVTA
        End Get
        Set(ByVal value As String)
            _CRGVTA = value
        End Set
    End Property


    Private _DCENSA As String = ""
    Public Property DCENSA() As String
        Get
            Return _DCENSA
        End Get
        Set(ByVal value As String)
            _DCENSA = value
        End Set
    End Property


    Private _USUARIO As String = ""
    Public Property USUARIO() As String
        Get
            Return _USUARIO
        End Get
        Set(ByVal value As String)
            _USUARIO = value
        End Set
    End Property


    Private _ERRORS As String = ""
    Public Property ERRORS() As String
        Get
            Return _ERRORS
        End Get
        Set(ByVal value As String)
            _ERRORS = value
        End Set
    End Property


    Private _NORDSR As Decimal
    Public Property NORDSR() As Decimal
        Get
            Return _NORDSR
        End Get
        Set(ByVal value As Decimal)
            _NORDSR = value
        End Set
    End Property


    Private _NCRRIN As Decimal
    Public Property NCRRIN() As Decimal
        Get
            Return _NCRRIN
        End Get
        Set(ByVal value As Decimal)
            _NCRRIN = value
        End Set
    End Property




End Class
