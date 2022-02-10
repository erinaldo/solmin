Public Class Obrero
  Private _COBRR As String = "0"
  Private _TNMBOB As String = ""
  Private _SCATEG As String = ""
  Private _SACTIN As String = ""
  Private _FULTAC As Double = 0
  Private _HULTAC As Double = 0
  Private _CULUSA As String = ""
  Private _NTRMNL As String = ""
  Private _FINGCH As String = 0
  Private _FVNCCR As String = 0
  Private _CMTCDS As String = ""
  Private _SESTRG As String = ""
  Private _CCMPN As String = ""
  Private _CDVSN As String = ""
  Private _CPLNDV As Double = 0


#Region "Properties"

  Public Property SESTRG() As String
    Get
      Return _SESTRG
    End Get
    Set(ByVal value As String)
      _SESTRG = value
    End Set
  End Property

  Public Property COBRR() As String
    Get
      Return _COBRR
    End Get
    Set(ByVal Value As String)
      _COBRR = Value
    End Set
  End Property

  Public Property TNMBOB() As String
    Get
      Return _TNMBOB
    End Get
    Set(ByVal Value As String)
      _TNMBOB = Value
    End Set
  End Property

  Public Property SCATEG() As String
    Get
      Return _SCATEG
    End Get
    Set(ByVal Value As String)
      _SCATEG = Value
    End Set
  End Property

  Public Property SACTIN() As String
    Get
      Return _SACTIN
    End Get
    Set(ByVal Value As String)
      _SACTIN = Value
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

  Public Property CULUSA() As String
    Get
      Return _CULUSA
    End Get
    Set(ByVal Value As String)
      _CULUSA = Value
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

  Public Property FINGCH() As String
    Get
      Return _FINGCH
    End Get
    Set(ByVal Value As String)
      _FINGCH = Value
    End Set
  End Property

  Public Property FVNCCR() As String
    Get
      Return _FVNCCR
    End Get
    Set(ByVal Value As String)
      _FVNCCR = Value
    End Set
  End Property

  Public Property CMTCDS() As String
    Get
      Return _CMTCDS
    End Get
    Set(ByVal Value As String)
      _CMTCDS = Value
    End Set
  End Property

  Private _TCATEG As String
  Public Property TCATEG() As String
    Get
      Return _TCATEG
    End Get
    Set(ByVal value As String)
      _TCATEG = value
    End Set
  End Property

  Public Property CCMPN() As String
    Get
      Return _CCMPN
    End Get
    Set(ByVal Value As String)
      _CCMPN = Value
    End Set
  End Property

  Public Property CDVSN() As String
    Get
      Return _CDVSN
    End Get
    Set(ByVal Value As String)
      _CDVSN = Value
    End Set
  End Property

  Public Property CPLNDV() As Double
    Get
      Return _CPLNDV
    End Get
    Set(ByVal Value As Double)
      _CPLNDV = Value
    End Set
  End Property

#End Region

End Class
