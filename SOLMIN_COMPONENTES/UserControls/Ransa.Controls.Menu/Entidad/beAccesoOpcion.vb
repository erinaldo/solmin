Public Class beAccesoOpcion
  Private _PSMMCAPL As String = ""
  Private _PSMMCMNU As String = ""
  Private _PNMMCOPC As Int32 = 0
  Private _PSMMCUSR As String = ""

  Private _PSSTSVIS As String = ""
  Private _PSSTSADI As String = ""
  Private _PSSTSCHG As String = ""
  Private _PSSTSELI As String = ""

  Private _DES_APLC As String = ""
  Private _DES_MENU As String = ""
  Private _DES_OPCN As String = ""

  Private _PSSTSOP1 As String = ""
  Private _PSSTSOP2 As String = ""
  Private _PSSTSOP3 As String = ""

  Private _PageSize As Integer
  Private _PageCount As Integer
  Private _PageNumber As Integer

  Private _DES_APLI As String = ""


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


  Public Property DES_APLC() As String
    Get
      Return _DES_APLC
    End Get
    Set(ByVal value As String)
      _DES_APLC = value
    End Set
  End Property

  Public Property DES_MENU() As String
    Get
      Return _DES_MENU
    End Get
    Set(ByVal value As String)
      _DES_MENU = value
    End Set
  End Property

  Public Property DES_OPCN() As String
    Get
      Return _DES_OPCN
    End Get
    Set(ByVal value As String)
      _DES_OPCN = value
    End Set
  End Property


  Public Property PSSTSOP1() As String
    Get
      Return _PSSTSOP1
    End Get
    Set(ByVal value As String)
      _PSSTSOP1 = value
    End Set
  End Property

  Public Property PSSTSOP2() As String
    Get
      Return _PSSTSOP2
    End Get
    Set(ByVal value As String)
      _PSSTSOP2 = value
    End Set
  End Property

  Public Property PSSTSOP3() As String
    Get
      Return _PSSTSOP3
    End Get
    Set(ByVal value As String)
      _PSSTSOP3 = value
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

  Public Property PSMMCMNU() As String
    Get
      Return _PSMMCMNU
    End Get
    Set(ByVal value As String)
      _PSMMCMNU = value
    End Set
  End Property

  Public Property PNMMCOPC() As Int32
    Get
      Return _PNMMCOPC
    End Get
    Set(ByVal value As Int32)
      _PNMMCOPC = value
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

  Public Property PSSTSVIS() As String
    Get
      Return _PSSTSVIS
    End Get
    Set(ByVal value As String)
      _PSSTSVIS = value
    End Set
  End Property

  Public Property PSSTSADI() As String
    Get
      Return _PSSTSADI
    End Get
    Set(ByVal value As String)
      _PSSTSADI = value
    End Set
  End Property

  Public Property PSSTSCHG() As String
    Get
      Return _PSSTSCHG
    End Get
    Set(ByVal value As String)
      _PSSTSCHG = value
    End Set
  End Property

  Public Property PSSTSELI() As String
    Get
      Return _PSSTSELI
    End Get
    Set(ByVal value As String)
      _PSSTSELI = value
    End Set
  End Property

End Class
