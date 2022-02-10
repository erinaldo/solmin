Public Class Acceso_DirectoBE
  Private _MMCUSR As String
  Private _MMCAPL As String
  Private _MMCMNU As String
  Private _MMCOPC As String
  Private _MMDOPC As String
  Private _MMNPVB As String
  Private _NJERAC As String
  Private _SESTRG As String
  Private _CULUSA As String
  Private _FULTAC As String
  Private _HULTAC As String
  Private _NTRMNL As String
  Public Property MMCUSR() As String
    Get
      Return _MMCUSR
    End Get
    Set(ByVal value As String)
      _MMCUSR = value
    End Set
  End Property
  Public Property MMCAPL() As String
    Get
      Return _MMCAPL
    End Get
    Set(ByVal value As String)
      _MMCAPL = value
    End Set
  End Property
  Public Property MMCMNU() As String
    Get
      Return _MMCMNU
    End Get
    Set(ByVal value As String)
      _MMCMNU = value
    End Set
  End Property
  Public Property MMCOPC() As String
    Get
      Return _MMCOPC
    End Get
    Set(ByVal value As String)
      _MMCOPC = value
    End Set
  End Property
  Public Property MMDOPC() As String
    Get
      Return _MMDOPC
    End Get
    Set(ByVal value As String)
      _MMDOPC = value
    End Set
  End Property
  Public Property MMNPVB() As String
    Get
      Return _MMNPVB
    End Get
    Set(ByVal value As String)
      _MMNPVB = value
    End Set
  End Property
  Public Property NJERAC() As String
    Get
      Return _NJERAC
    End Get
    Set(ByVal value As String)
      _NJERAC = value
    End Set
  End Property
  Public Property SESTRG() As String
    Get
      Return _SESTRG
    End Get
    Set(ByVal value As String)
      _SESTRG = value
    End Set
  End Property
  Public Property CULUSA() As String
    Get
      Return _CULUSA
    End Get
    Set(ByVal value As String)
      _CULUSA = value
    End Set
  End Property
  Public Property FULTAC() As String
    Get
      Return _FULTAC
    End Get
    Set(ByVal value As String)
      _FULTAC = value
    End Set
  End Property
  Public Property HULTAC() As String
    Get
      Return _HULTAC
    End Get
    Set(ByVal value As String)
      _HULTAC = value
    End Set
  End Property
  Public Property NTRMNL() As String
    Get
      Return _NTRMNL
    End Get
    Set(ByVal value As String)
      _NTRMNL = value
    End Set
  End Property
End Class