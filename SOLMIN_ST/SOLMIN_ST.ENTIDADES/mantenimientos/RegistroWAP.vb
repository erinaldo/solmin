Public Class RegistroWAP

  Private _CICLO As String = ""
  Private _NPLCTR As String = ""
  Private _NCOEVT As String = ""
  Private _TNMEV As String = ""
  Private _FRGTRO As String = ""
  Private _HRGTRO As String = ""
  Private _FCHCRT As String = ""
  Private _HRACRT As String = ""
  Private _TOBS As String = ""

  Private _CULUSA As String = ""
  Private _FULTAC As String = ""
  Private _HULTAC As String = ""
  Private _NTRMNL As String = ""



    Private _CCMPN As String
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property

  Public Property CICLO() As String
    Get
      Return _CICLO
    End Get
    Set(ByVal Value As String)
      _CICLO = Value
    End Set
  End Property

  Public Property NPLCTR() As String
    Get
      Return _NPLCTR
    End Get
    Set(ByVal Value As String)
      _NPLCTR = Value
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

  Public Property TNMEV() As String
    Get
      Return _TNMEV
    End Get
    Set(ByVal Value As String)
      _TNMEV = Value
    End Set
  End Property

  Public Property FRGTRO() As String
    Get
      Return _FRGTRO
    End Get
    Set(ByVal Value As String)
      _FRGTRO = Value
    End Set
  End Property

  Public Property HRGTRO() As String
    Get
      Return _HRGTRO
    End Get
    Set(ByVal Value As String)
      _HRGTRO = Value
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

  Public Property CULUSA() As String
    Get
      Return _CULUSA
    End Get
    Set(ByVal Value As String)
      _CULUSA = Value
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

  Public Property NTRMNL() As String
    Get
      Return _NTRMNL
    End Get
    Set(ByVal Value As String)
      _NTRMNL = Value
    End Set
  End Property

  Public Property FCHCRT() As String
    Get
      Return _FCHCRT
    End Get
    Set(ByVal Value As String)
      _FCHCRT = Value
    End Set
  End Property

  Public Property HRACRT() As String
    Get
      Return _HRACRT
    End Get
    Set(ByVal Value As String)
      _HRACRT = Value
    End Set
  End Property


End Class