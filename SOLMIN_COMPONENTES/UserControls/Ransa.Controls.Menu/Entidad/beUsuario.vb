Public Class beUsuario
  Private _PSMMCAPL_CodApl As String = ""
  Private _PSMMCMNU_CodMnu As String = ""
  Private _PNMMCOPC_CodOpc As Int32
  Private _PSMMCUSR As String = ""
  Private _PSMMNUSR As String = ""
  Private _PSSESTRG As String = ""

  Private _PSMMCAII As String = "" ' codigo aplicacion inicial
  Private _PSMMCMII As String = "" ' codigo menu inicial
  Private _PSCOROCC As Char = ""  ' codigo de operaciones cuenta corriente
  Private _PSCCMPOR As String = "" 'codigo compañia usuario
  Private _PSCDVSNU As String = ""  'codigo division usuario
  Private _PSMMTUSR As Char = ""  'tipo de usuario (D/F)
  Private _PNCNVUSR As Int32 = 0  'codigo de nivel de usuario
  Private _PSSORGZN As Char = ""  'flag de origen zona

  Private _OPCIONES As Int32 = 0
  Private _CLIENTES As Int32 = 0
  Private _PLANTAS As Int32 = 0

  Private _SESTRG_DESC As String = ""

  Private _PageSize As Integer
  Private _PageCount As Integer
  Private _PageNumber As Integer




  Public Property SESTRG_DESC() As String
    Get
      Return _SESTRG_DESC
    End Get
    Set(ByVal value As String)
      _SESTRG_DESC = value
    End Set
  End Property


  Public Property OPCIONES() As Integer
    Get
      Return _OPCIONES
    End Get
    Set(ByVal value As Integer)
      _OPCIONES = value
    End Set
  End Property

  Public Property CLIENTES() As Integer
    Get
      Return _CLIENTES
    End Get
    Set(ByVal value As Integer)
      _CLIENTES = value
    End Set
  End Property

  Public Property PLANTAS() As Integer
    Get
      Return _PLANTAS
    End Get
    Set(ByVal value As Integer)
      _PLANTAS = value
    End Set
  End Property


  Public Property PageSize() As Integer
    Get
      Return _PageSize
    End Get
    Set(ByVal value As Integer)
      _PageSize = value
    End Set
  End Property

  Public Property PageCount() As Integer
    Get
      Return _PageCount
    End Get
    Set(ByVal value As Integer)
      _PageCount = value
    End Set
  End Property

  Public Property PageNumber() As Integer
    Get
      Return _PageNumber
    End Get
    Set(ByVal value As Integer)
      _PageNumber = value
    End Set
  End Property

  Public Property PSCDVSNU() As Char
    Get
      Return _PSCDVSNU
    End Get
    Set(ByVal value As Char)
      _PSCDVSNU = value
    End Set
  End Property

  Public Property PSMMTUSR() As Char
    Get
      Return _PSMMTUSR
    End Get
    Set(ByVal value As Char)
      _PSMMTUSR = value
    End Set
  End Property
  Public Property PNCNVUSR() As Int32
    Get
      Return _PNCNVUSR
    End Get
    Set(ByVal value As Int32)
      _PNCNVUSR = value
    End Set
  End Property

  Public Property PSSORGZN() As Char
    Get
      Return _PSSORGZN
    End Get
    Set(ByVal value As Char)
      _PSSORGZN = value
    End Set
  End Property


  '*-----------------------------------------------------------------------
  Public Property PSMMCAII() As String
    Get
      Return _PSMMCAII
    End Get
    Set(ByVal value As String)
      _PSMMCAII = value
    End Set
  End Property

  Public Property PSMMCMII() As String
    Get
      Return _PSMMCMII
    End Get
    Set(ByVal value As String)
      _PSMMCMII = value
    End Set
  End Property

  Public Property PSCOROCC() As Char
    Get
      Return _PSCOROCC
    End Get
    Set(ByVal value As Char)
      _PSCOROCC = value
    End Set
  End Property

  Public Property PSCCMPOR() As String
    Get
      Return _PSCCMPOR
    End Get
    Set(ByVal value As String)
      _PSCCMPOR = value
    End Set
  End Property


  '*************************************************************************


    Public Property PSMMCAPL_CodApl() As String
        Get
            Return _PSMMCAPL_CodApl
        End Get
        Set(ByVal value As String)
            _PSMMCAPL_CodApl = value
        End Set
  End Property


    Public Property PSMMCMNU_CodMnu() As String
        Get
            Return _PSMMCMNU_CodMnu
        End Get
        Set(ByVal value As String)
            _PSMMCMNU_CodMnu = value
        End Set
    End Property

    Public Property PNMMCOPC_CodOpc() As Int32
        Get
            Return _PNMMCOPC_CodOpc
        End Get
        Set(ByVal value As Int32)
            _PNMMCOPC_CodOpc = value
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

  Public Property PSMMNUSR() As String
    Get
      Return _PSMMNUSR
    End Get
    Set(ByVal value As String)
      _PSMMNUSR = value
    End Set
  End Property

  Public Property PSSESTRG() As String
    Get
      Return _PSSESTRG
    End Get
    Set(ByVal value As String)
      _PSSESTRG = value
    End Set
  End Property

End Class
