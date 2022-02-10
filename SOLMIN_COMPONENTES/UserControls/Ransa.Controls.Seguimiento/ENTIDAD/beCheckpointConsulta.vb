Public Class beCheckpointConsulta
  Private _PNCCLNT As Decimal = 0
  Private _PSCCMPN As String = ""
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

End Class

