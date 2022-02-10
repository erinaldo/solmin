Public Class beCiaTransporte

  Private _PNCCIANV As Int32 = 0
  Private _PSTNMCIN As String = ""
  Private _PSTDIRCN As String = ""
  Private _PNCPAIS As Int32 = 0
  Private _PNSMETRA As Int32 = 0

  Private _PNCAGNCR_INI As Int32 = 0
  Private _PNCAGNCR_FIN As Int32 = 0

  'MEDIO DE TRANSPORTE
  Private _PNCMEDTR As Int32 = 0
  Private _PSTNMMDT As String = ""

  'PAIS
  Private _PNCDPAIS As Int32 = 0
  Private _PSTDPAIS As String = ""

  Private _PSCUSCRT As String = ""  ' USUARIO CREADOR
  'Private _PSFCHCRT As String = ""  ' FECHA CREACION
  'Private _PSHRACRT As String = ""  ' HORA DE CREACION
  Private _PNCULUSA As Int32 = 0    ' CODIGO ULTIMO USUARIO ACTUALIZADOR
  'Private _PSFULTAC As String = ""  ' FECHA ULTIMA ACTUALIZACION
  'Private _PSHULTAC As String = ""  ' HORA ULTIMA DE ACTUALIZACION
  Private _PSSESTRG As String = ""    ' FLG ESTADO DE REGISTRO

  Public Property PNCCIANV() As Int32
    Get
      Return _PNCCIANV
    End Get
    Set(ByVal value As Int32)
      _PNCCIANV = value
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

  Public Property PSTNMCIN() As String
    Get
      Return _PSTNMCIN
    End Get
    Set(ByVal value As String)
      _PSTNMCIN = value
    End Set
  End Property

  Public Property PSTDIRCN() As String
    Get
      Return _PSTDIRCN
    End Get
    Set(ByVal value As String)
      _PSTDIRCN = value

    End Set
  End Property

  Public Property PNCPAIS() As Int32
    Get
      Return _PNCPAIS
    End Get
    Set(ByVal value As Int32)

      _PNCPAIS = value
    End Set
  End Property

  Public Property PNSMETRA() As Int32
    Get
      Return _PNSMETRA
    End Get
    Set(ByVal value As Int32)

      _PNSMETRA = value
    End Set
  End Property

  Public Property PNCUSCRT() As Int32
    Get

      Return _PSCUSCRT
    End Get
    Set(ByVal value As Int32)

      _PSCUSCRT = value
    End Set
  End Property

  'Public Property FCHCRT() As String
  '  Get
  '    Return _PSFCHCRT
  '  End Get
  '  Set(ByVal value As String)

  '    _PSFCHCRT = value
  '  End Set
  'End Property

  'Public Property HRACRT() As String
  '  Get
  '    Return _PSHRACRT
  '  End Get
  '  Set(ByVal value As String)
  '    _PSHRACRT = value
  '  End Set
  'End Property

  Public Property PNCULUSA() As Int32
    Get
      Return _PNCULUSA
    End Get
    Set(ByVal value As Int32)
      _PNCULUSA = value
    End Set
  End Property

  'Public Property FULTAC() As String
  '  Get
  '    Return _PSFULTAC
  '  End Get
  '  Set(ByVal value As String)
  '    _PSFULTAC = value
  '  End Set
  'End Property

  'Public Property HULTAC() As String
  '  Get
  '    Return _PSHULTAC
  '  End Get
  '  Set(ByVal value As String)
  '    _PSHULTAC = value
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

  Public Property PNCMEDTR() As Int32
    Get
      Return _PNCMEDTR
    End Get
    Set(ByVal value As Int32)
      _PNCMEDTR = value
    End Set
  End Property
  Public Property PSTNMMDT() As String
    Get
      Return _PSTNMMDT
    End Get
    Set(ByVal value As String)
      _PSTNMMDT = value
    End Set
  End Property

  Public Property PNCDPAIS() As Int32
    Get
      Return _PNCDPAIS
    End Get
    Set(ByVal value As Int32)
      _PNCDPAIS = value
    End Set
  End Property

  Public Property PSTDPAIS() As String
    Get
      Return _PSTDPAIS
    End Get
    Set(ByVal value As String)
      _PSTDPAIS = value
    End Set
  End Property

End Class


