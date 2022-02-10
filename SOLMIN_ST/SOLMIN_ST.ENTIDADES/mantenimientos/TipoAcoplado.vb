Namespace mantenimientos
   
  Public Class TipoAcoplado

    Private _CTIACP As String = ""
    Private _TDEACP As String = ""
    Private _TABDES As String = ""
    Private _TCNFVH As String = ""
    Private _IMGACP As String = ""
    Private _SESTRG As String = ""
    Private _CUSCRT As String = ""
    Private _FCHCRT As Double = 0
    Private _HRACRT As Double = 0
    Private _NTRMCR As String = ""
    Private _CULUSA As String = ""
    Private _FULTAC As Double = 0
    Private _HULTAC As Double = 0
    Private _NTRMNL As String = ""
    Private _IMAGEN As Byte()
    Private _CCMPN As String = ""

    Public Property CCMPN() As String
      Get
        Return _CCMPN
      End Get
      Set(ByVal value As String)
        _CCMPN = value
      End Set
    End Property

    Public Property CTIACP() As String
      Get
        Return _CTIACP
      End Get
      Set(ByVal Value As String)
        _CTIACP = Value
      End Set
    End Property

    Public Property TDEACP() As String
      Get
        Return _TDEACP
      End Get
      Set(ByVal Value As String)
        _TDEACP = Value
      End Set
    End Property

    Public Property TABDES() As String
      Get
        Return _TABDES
      End Get
      Set(ByVal Value As String)
        _TABDES = Value
      End Set
    End Property

    Public Property TCNFVH() As String
      Get
        Return _TCNFVH
      End Get
      Set(ByVal Value As String)
        _TCNFVH = Value
      End Set
    End Property

    Public Property IMGACP() As String
      Get
        Return _IMGACP
      End Get
      Set(ByVal value As String)
        _IMGACP = value
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

    Public Property CUSCRT() As String
      Get
        Return _CUSCRT
      End Get
      Set(ByVal value As String)
        _CUSCRT = value
      End Set
    End Property

    Public Property FCHCRT() As Double
      Get
        Return _FCHCRT
      End Get
      Set(ByVal value As Double)
        _FCHCRT = value
      End Set
    End Property

    Public Property HRACRT() As Double
      Get
        Return _HRACRT
      End Get
      Set(ByVal value As Double)
        _HRACRT = value
      End Set
    End Property

    Public Property NTRMCR() As String
      Get
        Return _NTRMCR
      End Get
      Set(ByVal value As String)
        _NTRMCR = value
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

    Public Property FULTAC() As Double
      Get
        Return _FULTAC
      End Get
      Set(ByVal value As Double)
        _FULTAC = value
      End Set
    End Property

    Public Property HULTAC() As Double
      Get
        Return _HULTAC
      End Get
      Set(ByVal value As Double)
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

    Public Property IMAGEN() As Byte()
      Get
        Return _IMAGEN
      End Get
      Set(ByVal value As Byte())
        _IMAGEN = value
      End Set
    End Property

  End Class

End Namespace