Public Class beAccesoPlanta

  Private _PSMMCUSR As String = ""
  Private _PSCCMPN As String = ""
  Private _PSCDVSN As String = ""
  Private _PNCPLNDV As Decimal = 0
  Private _PSMMCAPL As String = ""
  Private _PSCRGVTA As String = ""
  Private _PSCSCDSP As String = ""


  Public Property PSMMCUSR() As String
    Get
      Return _PSMMCUSR
    End Get
    Set(ByVal value As String)
      _PSMMCUSR = value
    End Set
  End Property


  Public Property PSCCMPN() As String
    Get
      Return _PSCCMPN
    End Get
    Set(ByVal value As String)
      _PSCCMPN = value
    End Set
  End Property


  Public Property PSCDVSN() As String
    Get
      Return _PSCDVSN
    End Get
    Set(ByVal value As String)
      _PSCDVSN = value
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


  Public Property PSMMCAPL() As String
    Get
      Return _PSMMCAPL
    End Get
    Set(ByVal value As String)
      _PSMMCAPL = value
    End Set
  End Property


  Public Property PSCRGVTA() As String
    Get
      Return _PSCRGVTA
    End Get
    Set(ByVal value As String)
      _PSCRGVTA = value
    End Set
  End Property

  Public Property PSCSCDSP() As String
    Get
      Return _PSCSCDSP
    End Get
    Set(ByVal value As String)
      _PSCSCDSP = value
    End Set
  End Property



End Class
