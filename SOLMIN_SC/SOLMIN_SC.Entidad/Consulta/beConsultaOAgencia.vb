Public Class beConsultaOAgencia

  Private _PSCCMPN As String = "" 'Compañia
  Private _PNCCLNT As String = "" 'Cliente
  Private _PSCDVSN As String = "" 'Division
  Private _PSCPLNDV As String = "" 'Planta
  Private _PSPNNMOS As String = "" 'orden servicio
  Private _PNFINGRESO_MIN As Double = 0 'Fecha Minima
  Private _PNFINGRESO_MAX As Double = 0 'Fecha Maxima
  Private _PSBL As String = "" 'B/L
  Private _PSPNCDTR As String = "" 'codigo orden servicio 

  Public Property PSCCMPN() As String
    Get
      Return _PSCCMPN
    End Get
    Set(ByVal value As String)
      _PSCCMPN = value
    End Set
  End Property
  Public Property PNCCLNT() As String
    Get
      Return _PNCCLNT
    End Get
    Set(ByVal value As String)
      _PNCCLNT = value
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
  Public Property PSCPLNDV() As String
    Get
      Return _PSCPLNDV
    End Get
    Set(ByVal value As String)
      _PSCPLNDV = value
    End Set
  End Property

  Public Property PSPNNMOS() As String
    Get
      Return _PSPNNMOS
    End Get
    Set(ByVal value As String)
      _PSPNNMOS = value
    End Set
  End Property
  Public Property PNFINGRESO_MIN() As Double
    Get
      Return _PNFINGRESO_MIN
    End Get
    Set(ByVal value As Double)
      _PNFINGRESO_MIN = value
    End Set
  End Property
  Public Property PNFINGRESO_MAX() As Double
    Get
      Return _PNFINGRESO_MAX
    End Get
    Set(ByVal value As Double)
      _PNFINGRESO_MAX = value
    End Set
  End Property
  Public Property PSBL() As String
    Get
      Return _PSBL
    End Get
    Set(ByVal value As String)
      _PSBL = value
    End Set
  End Property
  Public Property PSPNCDTR() As String
    Get
      Return _PSPNCDTR
    End Get
    Set(ByVal value As String)
      _PSPNCDTR = value
    End Set
  End Property

End Class