Imports SOLMIN_ST.NEGOCIO

Public Class frmCambioRuta
#Region "Eventos"

  Private Sub frmCambioRuta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue
    Me.CargarRutas()
  End Sub

  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    If ctlLocalidadOrigen.NoHayCodigo OrElse ctlLocalidadDestino.NoHayCodigo Then
      HelpClass.MsgBox("Ingrese las dos Rutas")
    Else
      _CLCLOR = ctlLocalidadOrigen.Codigo
      _CLCLDS = ctlLocalidadDestino.Codigo
      _ORIGEN = ctlLocalidadOrigen.Descripcion
      _DESTINO = ctlLocalidadDestino.Descripcion
      Me.DialogResult = Windows.Forms.DialogResult.OK
    End If
  End Sub

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

#End Region

#Region "Propiedades"

  Private _CLCLOR As Double
  Public Property CLCLOR() As Double
    Get
      Return _CLCLOR
    End Get
    Set(ByVal value As Double)
      _CLCLOR = value
    End Set
  End Property


  Private _CLCLDS As Double
  Public Property CLCLDS() As Double
    Get
      Return _CLCLDS
    End Get
    Set(ByVal value As Double)
      _CLCLDS = value
    End Set
  End Property


  Private _ORIGEN As String
  Public Property ORIGEN() As String
    Get
      Return _ORIGEN
    End Get
    Set(ByVal value As String)
      _ORIGEN = value
    End Set
  End Property


  Private _DESTINO As String
  Public Property DESTINO() As String
    Get
      Return _DESTINO
    End Get
    Set(ByVal value As String)
      _DESTINO = value
    End Set
  End Property

  Private _COMPANIA As String
  Public Property COMPANIA() As String
    Get
      Return _COMPANIA
    End Get
    Set(ByVal value As String)
      _COMPANIA = value
    End Set
  End Property


#End Region

#Region "Metodos"
  Private Sub CargarRutas()
    Dim obj_Logica_Localidad As New Localidad_BLL
    Dim objDt As DataTable
    objDt = obj_Logica_Localidad.Listar_Localidades_Combo(COMPANIA)

    With Me.ctlLocalidadOrigen
      .DataSource = objDt.Copy 'CType(MainModule.gobj_TablasGeneralesdelSistema("LOCALIDADES"), DataTable).Copy()
      .KeyField = "CLCLD"
      .ValueField = "TCMLCL"
      .DataBind()
    End With

    With Me.ctlLocalidadDestino
      .DataSource = objDt.Copy 'CType(MainModule.gobj_TablasGeneralesdelSistema("LOCALIDADES"), DataTable).Copy()
      .KeyField = "CLCLD"
      .ValueField = "TCMLCL"
      .DataBind()
    End With
  End Sub

#End Region


End Class
