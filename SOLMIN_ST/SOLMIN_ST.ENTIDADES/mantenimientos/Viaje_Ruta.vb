Namespace mantenimientos

  Public Class Viaje_Ruta
    Private _PNNPRGVJ As Double = 0
    Private _PNNCRRRT As Double = 0
    Private _PNCLCLOR As Double = 0
    Private _PNCLCLDS As Double = 0
    Private _PSCLCLOR As String = ""
    Private _PSCLCLDS As String = ""
    Private _PNFSLDRT As Double = 0
    Private _PSFSLDRT As String = ""
    Private _PNHSLDRT As Double = 0
    Private _PSHSLDRT As String = ""
    Private _PNQCPSDS As Double = 0
    Private _PNQCPSUT As Double = 0
    Private _PSSESTRG As String = ""
    Private _PSCUSCRT As String = ""
    Private _PNFCHCRT As Double = 0
    Private _PNHRACRT As Double = 0
    Private _PSNTRMCR As String = ""
    Private _PSCULUSA As String = ""
    Private _PNFULTAC As Double = 0
    Private _PNHULTAC As Double = 0
    Private _PSNTRMNL As String = ""
    Private _PNUPDATE_IDENT As Double = 0
    Private _RUTA As String = ""
    Private _PNNCRRIN As Double = 0
    Private _PSNMBPER As String = ""
    Private _PSCCMPN As String = ""
    Private _PNCTRMNC As Double = 0
    Private _PNNGUITR As Double = 0

    Public Property PNCTRMNC() As Double
      Get
        Return _PNCTRMNC
      End Get
      Set(ByVal value As Double)
        _PNCTRMNC = value
      End Set
    End Property

    Public Property PNNGUITR() As Double
      Get
        Return _PNNGUITR
      End Get
      Set(ByVal value As Double)
        _PNNGUITR = value
      End Set
    End Property

    Public Property PSCCMPN() As String
      Get
        Return _PSCCMPN
      End Get
      Set(ByVal Value As String)
        _PSCCMPN = Value
      End Set
    End Property

    Public Property PSNMBPER() As String
      Get
        Return (_PSNMBPER)
      End Get
      Set(ByVal value As String)
        _PSNMBPER = value
      End Set
    End Property
    Public Property PNNCRRIN() As Double
      Get
        Return (_PNNCRRIN)
      End Get
      Set(ByVal value As Double)
        _PNNCRRIN = value
      End Set
    End Property
    Public Property PSFSLDRT() As String
      Get
        Return _PSFSLDRT
      End Get
      Set(ByVal Value As String)
        _PSFSLDRT = Value
      End Set
    End Property
    Public Property PSHSLDRT() As String
      Get
        Return _PSHSLDRT
      End Get
      Set(ByVal Value As String)
        _PSHSLDRT = Value
      End Set
    End Property
    Public Property RUTA() As String
      Get
        Return _RUTA
      End Get
      Set(ByVal Value As String)
        _RUTA = Value
      End Set
    End Property
    Public Property PNNPRGVJ() As Double
      Get
        Return (_PNNPRGVJ)
      End Get
      Set(ByVal value As Double)
        _PNNPRGVJ = value
      End Set
    End Property
    Public Property PNNCRRRT() As Double
      Get
        Return (_PNNCRRRT)
      End Get
      Set(ByVal value As Double)
        _PNNCRRRT = value
      End Set
    End Property
    Public Property PNCLCLOR() As Double
      Get
        Return (_PNCLCLOR)
      End Get
      Set(ByVal value As Double)
        _PNCLCLOR = value
      End Set
    End Property
    Public Property PNCLCLDS() As Double
      Get
        Return (_PNCLCLDS)
      End Get
      Set(ByVal value As Double)
        _PNCLCLDS = value
      End Set
    End Property
    Public Property PNFSLDRT() As Double
      Get
        Return (_PNFSLDRT)
      End Get
      Set(ByVal value As Double)
        _PNFSLDRT = value
      End Set
    End Property
    Public Property PSCLCLOR() As String
      Get
        Return (_PSCLCLOR)
      End Get
      Set(ByVal value As String)
        _PSCLCLOR = value
      End Set
    End Property
    Public Property PSCLCLDS() As String
      Get
        Return (_PSCLCLDS)
      End Get
      Set(ByVal value As String)
        _PSCLCLDS = value
      End Set
    End Property
    Public Property PNHSLDRT() As Double
      Get
        Return (_PNHSLDRT)
      End Get
      Set(ByVal value As Double)
        _PNHSLDRT = value
      End Set
    End Property
    Public Property PNQCPSDS() As Double
      Get
        Return (_PNQCPSDS)
      End Get
      Set(ByVal value As Double)
        _PNQCPSDS = value
      End Set
    End Property
    Public Property PNQCPSUT() As Double
      Get
        Return (_PNQCPSUT)
      End Get
      Set(ByVal value As Double)
        _PNQCPSUT = value
      End Set
    End Property
    Public Property PSSESTRG() As String
      Get
        Return (_PSSESTRG)
      End Get
      Set(ByVal value As String)
        _PSSESTRG = value
      End Set
    End Property
    Public Property PSCUSCRT() As String
      Get
        Return (_PSCUSCRT)
      End Get
      Set(ByVal value As String)
        _PSCUSCRT = value
      End Set
    End Property
    Public Property PNFCHCRT() As Double
      Get
        Return (_PNFCHCRT)
      End Get
      Set(ByVal value As Double)
        _PNFCHCRT = value
      End Set
    End Property
    Public Property PNHRACRT() As Double
      Get
        Return (_PNHRACRT)
      End Get
      Set(ByVal value As Double)
        _PNHRACRT = value
      End Set
    End Property
    Public Property PSNTRMCR() As String
      Get
        Return (_PSNTRMCR)
      End Get
      Set(ByVal value As String)
        _PSNTRMCR = value
      End Set
    End Property
    Public Property PSCULUSA() As String
      Get
        Return (_PSCULUSA)
      End Get
      Set(ByVal value As String)
        _PSCULUSA = value
      End Set
    End Property
    Public Property PNFULTAC() As Double
      Get
        Return (_PNFULTAC)
      End Get
      Set(ByVal value As Double)
        _PNFULTAC = value
      End Set
    End Property
    Public Property PNHULTAC() As Double
      Get
        Return (_PNHULTAC)
      End Get
      Set(ByVal value As Double)
        _PNHULTAC = value
      End Set
    End Property
    Public Property PSNTRMNL() As String
      Get
        Return (_PSNTRMNL)
      End Get
      Set(ByVal value As String)
        _PSNTRMNL = value
      End Set
    End Property
    Public Property PNUPDATE_IDENT() As Double
      Get
        Return (_PNUPDATE_IDENT)
      End Get
      Set(ByVal value As Double)
        _PNUPDATE_IDENT = value
      End Set
    End Property
  End Class

End Namespace
