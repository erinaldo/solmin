Public Class bePlanta

  Private _PSMMCUSR As String = ""
  Private _PSCODCIA As String = ""
  Private _PSCODDIV As String = ""
  Private _PNCODIGO As Decimal = 0
  Private _PSDESCRIPCION As String = ""

  Public Property PSMMCUSR() As String
    Get
      Return _PSMMCUSR
    End Get
    Set(ByVal value As String)
      _PSMMCUSR = value
    End Set
  End Property


  Public Property PSCODCIA() As String
    Get
      Return _PSCODCIA
    End Get
    Set(ByVal value As String)
      _PSCODCIA = value
    End Set
  End Property

  Public Property PSCODDIV() As String
    Get
      Return _PSCODDIV
    End Get
    Set(ByVal value As String)
      _PSCODDIV = value
    End Set
  End Property

  Public Property PNCODIGO() As Decimal
    Get
      Return _PNCODIGO
    End Get
    Set(ByVal value As Decimal)
      _PNCODIGO = value
    End Set
  End Property

  Public Property PSDESCRIPCION() As String
    Get
      Return _PSDESCRIPCION
    End Get
    Set(ByVal value As String)
      _PSDESCRIPCION = value
    End Set
  End Property

End Class
