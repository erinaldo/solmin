Public Class AccionWap
    Private _NCOACC As String
    Private _NCOEVT As String
  Private _TABACT As String
  Private _NCOROL As String
  Private _TOBS As String
  Private _NCOPAD As String
  Private _SESTRG As String
  Private _FULTAC As String
  Private _HULTAC As String
  Private _CULUSA As String
    Private _NTRMNL As String
    Private _TNMCEV As String
    Private _CCMPN As String = ""
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property

    Public Property TNMCEV() As String
        Get
            Return _TNMCEV
        End Get
        Set(ByVal Value As String)
            _TNMCEV = Value
        End Set
    End Property

    Public Property NCOEVT() As String
        Get
            Return _NCOEVT
        End Get
        Set(ByVal Value As String)
            _NCOEVT = Value
        End Set
    End Property

  Public Property NCOROL() As String
    Get
      Return _NCOROL
    End Get
    Set(ByVal Value As String)
      _NCOROL = Value
    End Set
  End Property

  Public Property TOBS() As String
    Get
      Return _TOBS
    End Get
    Set(ByVal Value As String)
      _TOBS = Value
    End Set
  End Property

  Public Property TABACT() As String
    Get
      Return _TABACT
    End Get
    Set(ByVal Value As String)
      _TABACT = Value
    End Set
  End Property

  Public Property NCOACC() As String
    Get
      Return _NCOACC
    End Get
    Set(ByVal Value As String)
      _NCOACC = Value
    End Set
  End Property

  Public Property NCOPAD() As String
    Get
      Return _NCOPAD
    End Get
    Set(ByVal Value As String)
      _NCOPAD = Value
    End Set
  End Property

  Public Property SESTRG() As String
    Get
      Return _SESTRG
    End Get
    Set(ByVal Value As String)
      _SESTRG = Value
    End Set
  End Property

  Public Property FULTAC() As String
    Get
      Return _FULTAC
    End Get
    Set(ByVal Value As String)
      _FULTAC = Value
    End Set
  End Property

  Public Property HULTAC() As String
    Get
      Return _HULTAC
    End Get
    Set(ByVal Value As String)
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
End Class
