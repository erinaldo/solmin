Public Class GuiaOCManifiestoCarga

#Region "Atributo"

  Private _NORCMC As String = ""
  Private _FULTAC As Double = 0
  Private _HULTAC As Double = 0
  Private _CULUSA As String = ""
  Private _NTRMNL As String = ""
  Private _CCMPN As String = ""
  Private _CDVSN As String = ""
  Private _CPLNDV As Int32 = 0
  Private _CTRMNC As Int32 = 0
  Private _NGUIRM As Int64 = 0
  Private _CCLNT As Int32 = 0
  Private _NRGUCL As Int64 = 0
  Private _NRITOC As Int32 = 0
  Private _QCNTIT As Double = 0
  Private _TDITES As String = ""
  Private _TUNDIT As String = ""
  'ACD
  Private _CREFFW As String = ""
  Private _TCMPCL As String = ""
  Private _CTPMDT As Int32 = 0
  Private _NSEQIN As Int32 = 0
  Private _NCRRGR As Int32 = 0
  Private _NOPRCN As Double = 0
    Private _NGUIRS As String = ""
    Private _DNGUIRS As String = ""
#End Region

#Region "Properties"

  Public Property NOPRCN() As Double
    Get
      Return _NOPRCN
    End Get
    Set(ByVal Value As Double)
      _NOPRCN = Value
    End Set
  End Property

  Public Property NCRRGR() As Int32
    Get
      Return _NCRRGR
    End Get
    Set(ByVal value As Int32)
      _NCRRGR = value
    End Set
  End Property

  Public Property NSEQIN() As Int32
    Get
      Return _NSEQIN
    End Get
    Set(ByVal value As Int32)
      _NSEQIN = value
    End Set
  End Property

  'ACD
  Public Property CREFFW() As String
    Get
      Return _CREFFW
    End Get
    Set(ByVal value As String)
      _CREFFW = value
    End Set
  End Property

  Public Property TCMPCL() As String
    Get
      Return _TCMPCL
    End Get
    Set(ByVal value As String)
      _TCMPCL = value
    End Set
  End Property

  Public Property CTPMDT() As Int32
    Get
      Return _CTPMDT
    End Get
    Set(ByVal value As Int32)
      _CTPMDT = value
    End Set
  End Property
  '-------------------------------------

  Public Property TUNDIT() As String
    Get
      Return _TUNDIT
    End Get
    Set(ByVal value As String)
      _TUNDIT = value
    End Set
  End Property

  Public Property TDITES() As String
    Get
      Return _TDITES
    End Get
    Set(ByVal value As String)
      _TDITES = value
    End Set
  End Property

  Public Property CTRMNC() As Int32
    Get
      Return _CTRMNC
    End Get
    Set(ByVal value As Int32)
      _CTRMNC = value
    End Set
  End Property

  Public Property CCLNT() As Int32
    Get
      Return _CCLNT
    End Get
    Set(ByVal value As Int32)
      _CCLNT = value
    End Set
  End Property

  Public Property NRITOC() As Int32
    Get
      Return _NRITOC
    End Get
    Set(ByVal value As Int32)
      _NRITOC = value
    End Set
  End Property

  Public Property QCNTIT() As Double
    Get
      Return _QCNTIT
    End Get
    Set(ByVal value As Double)
      _QCNTIT = value
    End Set
  End Property

  Public Property CCMPN() As String
    Get
      Return _CCMPN
    End Get
    Set(ByVal value As String)
      _CCMPN = value
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

  Public Property CPLNDV() As Int32
    Get
      Return (_CPLNDV)
    End Get
    Set(ByVal value As Int32)
      _CPLNDV = value
    End Set
  End Property

  Public Property NGUIRM() As Double
    Get
      Return _NGUIRM
    End Get
    Set(ByVal Value As Double)
      _NGUIRM = Value
    End Set
  End Property

  Public Property NRGUCL() As Int64
    Get
      Return _NRGUCL
    End Get
    Set(ByVal Value As Int64)
      _NRGUCL = Value
    End Set
  End Property

  Public Property NORCMC() As String
    Get
      Return _NORCMC
    End Get
    Set(ByVal Value As String)
      _NORCMC = Value
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

    Public Property NGUIRS() As String
        Get
            Return _NGUIRS
        End Get
        Set(ByVal Value As String)
            _NGUIRS = Value
        End Set
    End Property

    Public Property DNGUIRS() As String
        Get
            Return _DNGUIRS
        End Get
        Set(ByVal Value As String)
            _DNGUIRS = Value
        End Set
    End Property
  
#End Region

End Class
