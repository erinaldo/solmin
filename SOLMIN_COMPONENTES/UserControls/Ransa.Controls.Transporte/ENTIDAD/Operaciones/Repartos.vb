Namespace Operaciones
  Public Class Repartos

#Region "Atributo"
    Private _CCMPN As String = ""
    Private _NMOPRP As Double = 0
    Private _FECREP As Double = 0
    Private _CDVSN As String = ""
    Private _CPLNDV As Double = 0
    Private _CCLNT As Double = 0
    Private _NRUCTR As String = ""
    Private _NPLCUN As String = ""
    Private _TREFCL As String = ""
    Private _SESTSO As String = ""
    Private _SESTRG As String = ""
    Private _CUSCRT As String = ""
    Private _FCHCRT As Double = 0
    Private _HRACRT As Double = 0
    Private _NTRMCR As String = ""
    Private _CULUSA As String = ""
    Private _FULTAC As Double = 0
    Private _HULTAC As Double = 0
    Private _NTRMNL As String = ""
    Private _FECREP_S As String = ""
    Private _TCMPCL As String = ""
    Private _NOPRCN As Int64 = 0
        Private _NGUITR As Int64 = 0
        Private _TIPO As Int64 = 0

#End Region

#Region "Properties"
    Public Property CCMPN() As String
      Get
        Return (_CCMPN)
      End Get
      Set(ByVal value As String)
        _CCMPN = value
      End Set
    End Property

    Public Property NMOPRP() As Double
      Get
        Return (_NMOPRP)
      End Get
      Set(ByVal value As Double)
        _NMOPRP = value
      End Set
    End Property

    Public Property FECREP() As Double
      Get
        Return (_FECREP)
      End Get
      Set(ByVal value As Double)
        _FECREP = value
      End Set
    End Property

    Public Property CDVSN() As String
      Get
        Return (_CDVSN)
      End Get
      Set(ByVal value As String)
        _CDVSN = value
      End Set
    End Property

    Public Property CPLNDV() As Double
      Get
        Return (_CPLNDV)
      End Get
      Set(ByVal value As Double)
        _CPLNDV = value
      End Set
    End Property

    Public Property CCLNT() As Double
      Get
        Return (_CCLNT)
      End Get
      Set(ByVal value As Double)
        _CCLNT = value
      End Set
    End Property

    Public Property NRUCTR() As String
      Get
        Return (_NRUCTR)
      End Get
      Set(ByVal value As String)
        _NRUCTR = value
      End Set
    End Property

    Public Property NPLCUN() As String
      Get
        Return (_NPLCUN)
      End Get
      Set(ByVal value As String)
        _NPLCUN = value
      End Set
    End Property

    Public Property TREFCL() As String
      Get
        Return (_TREFCL)
      End Get
      Set(ByVal value As String)
        _TREFCL = value
      End Set
    End Property

    Public Property SESTSO() As String
      Get
        Return (_SESTSO)
      End Get
      Set(ByVal value As String)
        _SESTSO = value
      End Set
    End Property

    Public Property SESTRG() As String
      Get
        Return (_SESTRG)
      End Get
      Set(ByVal value As String)
        _SESTRG = value
      End Set
    End Property

    Public Property CUSCRT() As String
      Get
        Return (_CUSCRT)
      End Get
      Set(ByVal value As String)
        _CUSCRT = value
      End Set
    End Property

    Public Property FCHCRT() As Double
      Get
        Return (_FCHCRT)
      End Get
      Set(ByVal value As Double)
        _FCHCRT = value
      End Set
    End Property

    Public Property HRACRT() As Double
      Get
        Return (_HRACRT)
      End Get
      Set(ByVal value As Double)
        _HRACRT = value
      End Set
    End Property

    Public Property NTRMCR() As String
      Get
        Return (_NTRMCR)
      End Get
      Set(ByVal value As String)
        _NTRMCR = value
      End Set
    End Property

    Public Property CULUSA() As String
      Get
        Return (_CULUSA)
      End Get
      Set(ByVal value As String)
        _CULUSA = value
      End Set
    End Property

    Public Property FULTAC() As Double
      Get
        Return (_FULTAC)
      End Get
      Set(ByVal value As Double)
        _FULTAC = value
      End Set
    End Property

    Public Property HULTAC() As Double
      Get
        Return (_HULTAC)
      End Get
      Set(ByVal value As Double)
        _HULTAC = value
      End Set
    End Property

    Public Property NTRMNL() As String
      Get
        Return (_NTRMNL)
      End Get
      Set(ByVal value As String)
        _NTRMNL = value
      End Set
    End Property

    Public Property FECREP_S() As String
      Get
        Return (_FECREP_S)
      End Get
      Set(ByVal value As String)
        _FECREP_S = value
      End Set
    End Property

    Public Property TCMPCL() As String
      Get
        Return (_TCMPCL)
      End Get
      Set(ByVal value As String)
        _TCMPCL = value
      End Set
    End Property

    Public Property NOPRCN() As Int64
      Get
        Return _NOPRCN
      End Get
      Set(ByVal Value As Int64)
        _NOPRCN = Value
      End Set
    End Property

    Public Property NGUITR() As Int64
      Get
        Return _NGUITR
      End Get
      Set(ByVal Value As Int64)
        _NGUITR = Value
      End Set
    End Property

        Public Property TIPO() As Int64
            Get
                Return _TIPO
            End Get
            Set(ByVal Value As Int64)
                _TIPO = Value
            End Set
        End Property


#End Region

  End Class
End Namespace
