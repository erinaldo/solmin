Namespace mantenimientos

  Public Class CentroCosto

#Region "Atributo"
    Private _CCMPN As String = ""
    Private _CCNTCS As Double = 0
    Private _TCNTCS As String = ""
    Private _CCNBNS As String = ""
    Private _CRGVTA As String = ""
    Private _CULUSA As String = ""
    Private _FULTAC As Double = 0
    Private _HULTAC As Double = 0
    Private _NTRMNL As String = ""
#End Region

#Region "Properties"

    Public Property CCMPN() As String
      Get
        Return _CCMPN
      End Get
      Set(ByVal Value As String)
        _CCMPN = Value
      End Set
    End Property

        Private _TCRVTA As String
        Public Property TCRVTA() As String
            Get
                Return _TCRVTA
            End Get
            Set(ByVal value As String)
                _TCRVTA = value
            End Set
        End Property

        Public Property CCNTCS() As Double
            Get
                Return _CCNTCS
            End Get
            Set(ByVal Value As Double)
                _CCNTCS = Value
            End Set
        End Property

        Public Property TCNTCS() As String
            Get
                Return _TCNTCS
            End Get
            Set(ByVal Value As String)
                _TCNTCS = Value
            End Set
        End Property

        Public Property CCNBNS() As String
            Get
                Return _CCNBNS
            End Get
            Set(ByVal Value As String)
                _CCNBNS = Value
            End Set
        End Property

        Private _IDCORRELATIVO As Integer
        Public Property IDCORRELATIVO() As Integer
            Get
                Return _IDCORRELATIVO
            End Get
            Set(ByVal value As Integer)
                _IDCORRELATIVO = value
            End Set
        End Property

        Public Property CRGVTA() As String
            Get
                Return _CRGVTA
            End Get
            Set(ByVal Value As String)
                _CRGVTA = Value
            End Set
        End Property

        Public Property CULUSA() As String
            Get
                Return _CULUSA
            End Get
            Set(ByVal Value As String)
                _CULUSA = Value
            End Set
        End Property

        Public Property FULTAC() As Double
            Get
                Return _FULTAC
            End Get
            Set(ByVal Value As Double)
                _FULTAC = Value
            End Set
        End Property

        Public Property HULTAC() As Double
            Get
                Return _HULTAC
            End Get
            Set(ByVal Value As Double)
                _HULTAC = Value
            End Set
        End Property

        Public Property NTRMNL() As String
            Get
                Return _NTRMNL
            End Get
            Set(ByVal Value As String)
                _NTRMNL = Value
            End Set
        End Property

#End Region

    End Class


End Namespace