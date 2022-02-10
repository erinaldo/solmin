Public Class beVapores
  Inherits beBase
  Private _PSCVPRCN As String = ""
  Private _PSTCMPVP As String = ""
  Private _PSTABRVP As String = ""
  Private _PNQTNLBR As Decimal = 0
  Private _PSNTRMNL As String = "" ' NUMERO DE TERMINAL USADO 
  Private _PSCUSCRT As String = "" ' USUARIO CREADOR
  'Private _PNFCHCRT As Decimal = 0 ' FECHA CREACION
  'Private _PNHRACRT As Decimal = 0 ' HORA DE CREACION
  Private _PSCULUSA As String = "" 'CODIGO ULTIMO USUARIO ACTUALIZADOR
  'Private _PNFULTAC As Decimal = 0 ' FECHA ULTIMA ACTUALIZACION
  'Private _PNHULTAC As Decimal = 0 ' HORA ULTIMA DE ACTUALIZACION
  Private _PSSESTRG As String = "" 'FLG ESTADO DE REGISTRO

  Public Property PSCVPRCN() As String
    Get
      Return _PSCVPRCN
    End Get
    Set(ByVal value As String)
      _PSCVPRCN = value

    End Set
  End Property

  Public Property PSTCMPVP() As String
    Get
      Return _PSTCMPVP
    End Get
    Set(ByVal value As String)
      _PSTCMPVP = value
    End Set
  End Property

  Public Property PSTABRVP() As String
    Get
      Return _PSTABRVP
    End Get
    Set(ByVal value As String)
      _PSTABRVP = value

    End Set
  End Property

  Public Property PNQTNLBR() As Decimal
    Get
      Return _PNQTNLBR
    End Get
    Set(ByVal value As Decimal)
      _PNQTNLBR = value
    End Set
  End Property

  Public Property PSCUSCRT() As String
    Get

      Return _PSCUSCRT
    End Get
    Set(ByVal value As String)

      _PSCUSCRT = value
    End Set
  End Property

  'Public Property PNFCHCRT() As Decimal
  '  Get
  '    Return _PNFCHCRT
  '  End Get
  '  Set(ByVal value As Decimal)

  '    _PNFCHCRT = value
  '  End Set
  'End Property

  'Public Property PNHRACRT() As Decimal
  '  Get
  '    Return _PNHRACRT
  '  End Get
  '  Set(ByVal value As Decimal)
  '    _PNHRACRT = value
  '  End Set
  'End Property

  Public Property PSCULUSA() As String
    Get
      Return _PSCULUSA
    End Get
    Set(ByVal value As String)
      _PSCULUSA = value
    End Set
  End Property

  'Public Property PNFULTAC() As Decimal
  '  Get
  '    Return _PNFULTAC
  '  End Get
  '  Set(ByVal value As Decimal)
  '    _PNFULTAC = value
  '  End Set
  'End Property

  'Public Property PNHULTAC() As Decimal
  '  Get
  '    Return _PNHULTAC
  '  End Get
  '  Set(ByVal value As Decimal)
  '    _PNHULTAC = value
  '  End Set
  'End Property

  Public Property PSSESTRG() As String
    Get
      Return _PSSESTRG
    End Get
    Set(ByVal value As String)
      _PSSESTRG = value
    End Set
  End Property

  Public Property PSNTRMNL() As String
    Get
      Return _PSNTRMNL
    End Get
    Set(ByVal value As String)

      _PSNTRMNL = value
    End Set
  End Property

End Class
