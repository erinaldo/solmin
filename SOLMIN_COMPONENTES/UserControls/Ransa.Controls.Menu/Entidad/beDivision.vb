Public Class beDivision

  Private _PSCODCIA As String = ""
  Private _PSCODIGO As String = ""
  Private _PSDESCRIPCION As String = ""

  Public Property PSCODCIA() As String
    Get
      Return _PSCODCIA
    End Get
    Set(ByVal value As String)
      _PSCODCIA = value
    End Set
  End Property

  Public Property PSCODIGO() As String
    Get
      Return _PSCODIGO
    End Get
    Set(ByVal value As String)
      _PSCODIGO = value
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
