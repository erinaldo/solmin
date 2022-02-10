Public Class beAccesoCliente
  Private _PSMMCUSR As String = ""
  Private _PNCCLNT As Double = 0
  Private _PNCPLNDV As Decimal = 0
  Private _PSTCMPCL As String = ""
  Private _PSTRFRCL As String = ""
  Private _PSCINTER As String = ""
  Private _PSTPLNTA As String = ""

  Public Property PSTPLNTA() As String
    Get
      Return _PSTPLNTA
    End Get
    Set(ByVal value As String)
      _PSTPLNTA = value
    End Set
  End Property



  Public Property PSTRFRCL() As String
    Get
      Return _PSTRFRCL
    End Get
    Set(ByVal value As String)
      _PSTRFRCL = value
    End Set
  End Property

  Public Property PSCINTER() As String
    Get
      Return _PSCINTER
    End Get
    Set(ByVal value As String)
      _PSCINTER = value
    End Set
  End Property

  Public Property PSMMCUSR() As String
    Get
      Return _PSMMCUSR
    End Get
    Set(ByVal value As String)
      _PSMMCUSR = value
    End Set
  End Property

  Public Property PNCCLNT() As Double
    Get
      Return _PNCCLNT
    End Get
    Set(ByVal value As Double)
      _PNCCLNT = value
    End Set
  End Property

  Public Property PNCPLNDV() As Decimal
    Get
      Return _PNCPLNDV
    End Get
    Set(ByVal value As Decimal)
      _PNCPLNDV = value
    End Set
  End Property
  Public Property PSTCMPCL() As String
    Get
      Return _PSTCMPCL
    End Get
    Set(ByVal value As String)
      _PSTCMPCL = value
    End Set

  End Property
End Class
