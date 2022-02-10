Public Class beEmbarcador

  Private _PNCAGNCR As Int32 = 0

  Private _PNCAGNCR_INI As Int32 = 0
  Private _PNCAGNCR_FIN As Int32 = 0

  Private _PSTNMAGC As String = ""
  Private _PSTDIRAC As String = ""
  Private _PNCPAIS As Decimal = -1D

  Private _PSCUSCRT As String = "" ' USUARIO CREADOR
  Private _PSFCHCRT As String = "" ' FECHA CREACION
  Private _PSHRACRT As String = "" ' HORA DE CREACION
  Private _PNCULUSA As Int32 = 0   'CODIGO ULTIMO USUARIO ACTUALIZADOR
  Private _PSFULTAC As String = "" ' FECHA ULTIMA ACTUALIZACION
  Private _PSHULTAC As String = "" ' HORA ULTIMA DE ACTUALIZACION
  Private _PSPSSESTRG As Char = "" 'FLG ESTADO DE REGISTRO

  Public Property PNCAGNCR() As Int32
    Get
      Return _PNCAGNCR
    End Get
    Set(ByVal value As Int32)
      _PNCAGNCR = value
    End Set
  End Property

  Public Property PNCAGNCR_INI() As Int32
    Get
      Return _PNCAGNCR_INI
    End Get
    Set(ByVal value As Int32)
      _PNCAGNCR_INI = value
    End Set
  End Property

  Public Property PNCAGNCR_FIN() As Int32
    Get
      Return _PNCAGNCR_FIN
    End Get
    Set(ByVal value As Int32)
      _PNCAGNCR_FIN = value
    End Set
  End Property


  Public Property PSTNMAGC() As String
    Get
      Return _PSTNMAGC
    End Get
    Set(ByVal value As String)
      _PSTNMAGC = value
    End Set
  End Property

  Public Property PSTDIRAC() As String
    Get
      Return _PSTDIRAC
    End Get
    Set(ByVal value As String)
      _PSTDIRAC = value
    End Set
  End Property

  Public Property PNCPAIS() As Decimal
    Get
      Return _PNCPAIS
    End Get
    Set(ByVal value As Decimal)
      _PNCPAIS = value
    End Set
  End Property


  Public Property PSCUSCRT() As Int32
    Get
      Return _PSCUSCRT
    End Get
    Set(ByVal value As Int32)
      _PSCUSCRT = value
    End Set
  End Property

  Public Property PSFCHCRT() As String
    Get
      Return _PSFCHCRT
    End Get
    Set(ByVal value As String)

      _PSFCHCRT = value
    End Set
  End Property

  Public Property PSHRACRT() As String
    Get
      Return _PSHRACRT
    End Get
    Set(ByVal value As String)
      _PSHRACRT = value
    End Set
  End Property

  Public Property PNCULUSA() As Int32
    Get
      Return _PNCULUSA
    End Get
    Set(ByVal value As Int32)
      _PNCULUSA = value
    End Set
  End Property

  Public Property PSFULTAC() As String
    Get
      Return _PSFULTAC
    End Get
    Set(ByVal value As String)
      _PSFULTAC = value
    End Set
  End Property

  Public Property PSHULTAC() As String
    Get
      Return _PSHULTAC
    End Get
    Set(ByVal value As String)
      _PSHULTAC = value
    End Set
  End Property

  Public Property PSSESTRG() As Char
    Get
      Return _PSPSSESTRG
    End Get
    Set(ByVal value As Char)
      _PSPSSESTRG = value
    End Set
  End Property

End Class
