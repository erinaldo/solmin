Public Class beEmbarqueEntidad
  Private _PNCCLNT As Decimal = 0
  Private _PSCCMPN As String = ""
  Private _PSNORCML As String = ""
  Private _PNNRITEM_INI As Decimal = 0
  Private _PNNRITEM_FIN As Decimal = 0
  Private _PNNRPARC As Decimal = 0
  Private _PSCEMB As String = ""
  Private _PSSESTRG As String = ""

  Private _PSDFECEST As String = ""
  Private _PSDFECREA As String = ""

  Private _PSCDVSN As String = ""
  Private _PNNORSCI As Decimal = 0

  Public Property PNCCLNT() As Decimal
    Get
      Return (_PNCCLNT)
    End Get
    Set(ByVal value As Decimal)
      _PNCCLNT = value
    End Set
  End Property

  Public Property PSCCMPN() As String
    Get
      Return (_PSCCMPN)
    End Get
    Set(ByVal value As String)
      _PSCCMPN = value
    End Set
  End Property

  Public Property PSNORCML() As String
    Get
      Return (_PSNORCML)
    End Get
    Set(ByVal value As String)
      _PSNORCML = value
    End Set
  End Property

  Public Property PNNRITEM_INI() As Decimal
    Get
      Return (_PNNRITEM_INI)
    End Get
    Set(ByVal value As Decimal)
      _PNNRITEM_INI = value
    End Set
  End Property

  Public Property PNNRITEM_FIN() As Decimal
    Get
      Return (_PNNRITEM_FIN)
    End Get
    Set(ByVal value As Decimal)
      _PNNRITEM_FIN = value
    End Set
  End Property

  Public Property PNNRPARC() As Decimal
    Get
      Return (_PNNRPARC)
    End Get
    Set(ByVal value As Decimal)
      _PNNRPARC = value
    End Set
  End Property

  Public Property PSCEMB() As String
    Get
      Return (_PSCEMB)
    End Get
    Set(ByVal value As String)
      _PSCEMB = value
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

  Public Property PSCDVSN() As String
    Get
      Return (_PSCDVSN)
    End Get
    Set(ByVal value As String)
      _PSCDVSN = value
    End Set
  End Property

  Public Property PNNORSCI() As Decimal
    Get
      Return (_PNNORSCI)
    End Get
    Set(ByVal value As Decimal)
      _PNNORSCI = value
    End Set
  End Property

  Public Property PSDFECEST() As String
    Get
      Return _PSDFECEST
    End Get
    Set(ByVal value As String)
      _PSDFECEST = value
    End Set
  End Property

  Public Property PSDFECREA() As String
    Get
      Return _PSDFECREA
    End Get
    Set(ByVal value As String)
      _PSDFECREA = value
    End Set
  End Property


End Class
