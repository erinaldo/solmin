Public Class beOpcion
  Private _PSMMCAPL_CodApl As String = ""
  Private _PSMMCMNU_CodMnu As String = ""
  Private _PNMMCOPC_CodOpc As Decimal = 0
  Private _PNMMCOPC_CodOpc_Ini As Int32
  Private _PNMMCOPC_CodOpc_Fin As Int32
  Private _PSSESTRG_Opc As String = ""
  Private _PSMMDOPC_DesOpc As String = ""
  Private _PSMMNPVB As String = ""

  Private _PSMMTOPC As String = "" 'tipo de opción (Menú, Función)
  Private _PSMMTVAR As String = "" 'tipo de variable enviar
  Private _PSMMNPRO As String = "" 'nombre del proceso
  Private _PSMMNFUN As String = "" 'nombre de programa
  Private _PSURLIMG As String = "" 'Direcion
  Private _PSMMNPGM As String = ""

  Private _PSMMCAIN As String = ""
  Private _PSMMCMIN As String = ""


  Public Property PSMMNPGM() As String
    Get
      Return _PSMMNPGM
    End Get
    Set(ByVal value As String)
      _PSMMNPGM = value
    End Set
  End Property

  Public Property PSMMCAIN() As String
    Get
      Return _PSMMCAIN
    End Get
    Set(ByVal value As String)
      _PSMMCAIN = value
    End Set
  End Property

  Public Property PSMMCMIN() As String
    Get
      Return _PSMMCMIN
    End Get
    Set(ByVal value As String)
      _PSMMCMIN = value
    End Set
  End Property



  Public Property PSMMTOPC() As String
    Get
      Return _PSMMTOPC
    End Get
    Set(ByVal value As String)
      _PSMMTOPC = value
    End Set
  End Property

  Public Property PSMMTVAR() As String
    Get
      Return _PSMMTVAR
    End Get
    Set(ByVal value As String)
      _PSMMTVAR = value
    End Set
  End Property

  Public Property PSMMNPRO() As String
    Get
      Return _PSMMNPRO
    End Get
    Set(ByVal value As String)
      _PSMMNPRO = value
    End Set
  End Property

  Public Property PSMMNFUN() As String
    Get
      Return _PSMMNFUN
    End Get
    Set(ByVal value As String)
      _PSMMNFUN = value
    End Set
  End Property

  Public Property PSURLIMG() As String
    Get
      Return _PSURLIMG
    End Get
    Set(ByVal value As String)
      _PSURLIMG = value
    End Set
  End Property

  Public Property PSMMNPVB() As String
    Get
      Return _PSMMNPVB
    End Get
    Set(ByVal value As String)
      _PSMMNPVB = value
    End Set
  End Property

  Public Property PSMMCAPL_CodApl() As String
    Get
      Return _PSMMCAPL_CodApl
    End Get
    Set(ByVal value As String)
      _PSMMCAPL_CodApl = value
    End Set
  End Property

  Public Property PSSESTRG_Opc() As String
    Get
      Return _PSSESTRG_Opc
    End Get
    Set(ByVal value As String)
      _PSSESTRG_Opc = value
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

  Public Property PNMMCOPC_CodOpc_Ini() As Int32
    Get
      Return _PNMMCOPC_CodOpc_Ini
    End Get
    Set(ByVal value As Int32)
      _PNMMCOPC_CodOpc_Ini = value
    End Set
  End Property

  Public Property PNMMCOPC_CodOpc_Fin() As Int32
    Get
      Return _PNMMCOPC_CodOpc_Fin
    End Get
    Set(ByVal value As Int32)
      _PNMMCOPC_CodOpc_Fin = value
    End Set
  End Property

  Public Property PSMMDOPC_DesOpc() As String
    Get
      Return _PSMMDOPC_DesOpc
    End Get
    Set(ByVal value As String)
      _PSMMDOPC_DesOpc = value
    End Set
  End Property
End Class
