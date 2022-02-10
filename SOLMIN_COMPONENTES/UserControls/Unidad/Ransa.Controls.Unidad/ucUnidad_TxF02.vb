Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.DAO.Unidad
Imports Ransa.TypeDef.Unidad

Public Class ucUnidad_TxF02
#Region " Definición Eventos "
  ' Mensaje
  Public Event ErrorMessage(ByVal MsgError As String)
  Public Event Message(ByVal Mensaje As String)
  Public Event Confirm(ByVal Pregunta As String, ByRef Cancelar As Boolean)
  ' Eventos a Procesar
#End Region
#Region " Tipo "
  Structure Registro
    Public Codigo As String
    Public Detalle As String
  End Structure
#End Region
#Region " Atributos "
  '-------------------------------------------------
  ' Manejador de la Información
  '-------------------------------------------------
  Private oUnidad As cUnidad = New cUnidad
  '-------------------------------------------------
  ' Almacenamiento de Información
  '-------------------------------------------------
  Private lstRegistros As List(Of Registro) = New List(Of Registro)
  Private oUnidadActual As TD_Inf_Unidad_L02 = New TD_Inf_Unidad_L02
  Private sTipoUnidad As String = ""
  Private strMensajeError As String = ""
  Private strCompania As String = "EZ"
  '-------------------------------------------------
  ' Información del Estado
  '-------------------------------------------------
  Private blnIsRequired As Boolean = False
  '-------------------------------------------------
  ' Datos de Seguridad 
  '-------------------------------------------------
#End Region
#Region " Propiedades "
  Public Property TipoUnidad() As String
    Get
      Return sTipoUnidad
    End Get
    Set(ByVal value As String)
      sTipoUnidad = value
    End Set
  End Property

  Public ReadOnly Property pUnidad() As String
    Get
      Return oUnidadActual.pCUNDMD_Unidad
    End Get
  End Property

  Public ReadOnly Property pDescripcion() As String
    Get
      Return oUnidadActual.pTABRUN_Descripcion
    End Get
  End Property

  Public Property pIsRequired() As Boolean
    Get
      Return blnIsRequired
    End Get
    Set(ByVal value As Boolean)
      blnIsRequired = value
      If Not blnIsRequired Then
        txtUnidad.StateCommon.Back.Color1 = Nothing
      Else
        txtUnidad.StateCommon.Back.Color1 = Color.PaleGoldenrod
      End If
    End Set
  End Property
 
  Public WriteOnly Property pCompania() As String
    Set(ByVal value As String)
      strCompania = value
    End Set
  End Property

#End Region
#Region " Funciones y Procedimientos "
  Private Sub pCargarInformacion(ByVal sCompania As String)
    Dim sCodigo As String = ""
    Dim sDefault As String = ""
    Dim dtTemp As DataTable = oUnidad.fdtListar(sTipoUnidad, sCodigo, sDefault, sCompania)
    If strMensajeError <> "" Then
      RaiseEvent ErrorMessage(strMensajeError)
      Exit Sub
    Else
      If dtTemp.Rows.Count > 0 Then
        Dim rwTemp As DataRow
        Dim stRegistro As Registro = Nothing
        lstRegistros.Clear()
        For Each rwTemp In dtTemp.Rows
          stRegistro = New Registro
          stRegistro.Codigo = ("" & rwTemp.Item(0)).ToString.Trim
          stRegistro.Detalle = ("" & rwTemp.Item(1)).ToString.Trim
          lstRegistros.Add(stRegistro)
          txtUnidad.AutoCompleteCustomSource.Add(stRegistro.Codigo & " - " & stRegistro.Detalle)
        Next
      End If
    End If
    If Not dtTemp Is Nothing Then dtTemp.Dispose()
    dtTemp = Nothing
  End Sub
#End Region
#Region " Eventos "
  Sub New()
    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()
    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
  End Sub

  Private Sub ucUnidad_TxF02_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
    oUnidad.Dispose()
    oUnidad = Nothing
  End Sub

  Private Sub ucUnidad_TxF02_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Call pCargarInformacion(strCompania)
  End Sub

  'Private Sub ucUnidad_TxF02_CmbF01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
  '    Call pCargarInformacion()
  'End Sub

  Private Sub ucUnidad_TxF02_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
    txtUnidad.Width = Width
    Me.Height = txtUnidad.Height
  End Sub

  Private Sub txtUnidad_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUnidad.GotFocus
    txtUnidad.SelectAll()
  End Sub

  Private Sub txtUnidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUnidad.KeyDown
    If e.KeyCode = Keys.Escape Then
      If oUnidadActual.pTABRUN_Descripcion <> "" Then
        txtUnidad.Text = oUnidadActual.pCUNDMD_Unidad & " - " & oUnidadActual.pTABRUN_Descripcion
      Else
        txtUnidad.Text = ""
      End If
    End If
  End Sub

  Private Sub txtUnidad_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUnidad.Validated
    Dim stRegistro As Registro = Nothing
    For Each stRegistro In lstRegistros
      If (stRegistro.Codigo & " - " & stRegistro.Detalle) = txtUnidad.Text Then
        oUnidadActual.pCUNDMD_Unidad = stRegistro.Codigo
        oUnidadActual.pTABRUN_Descripcion = stRegistro.Detalle
        Exit For
      End If
    Next
  End Sub

  Private Sub txtUnidad_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtUnidad.Validating
    If (oUnidadActual.pCUNDMD_Unidad & " - " & oUnidadActual.pTABRUN_Descripcion).ToUpper.Trim <> txtUnidad.Text.ToUpper.Trim Then
      Dim sTemp As String = ""
      For Each sTemp In txtUnidad.AutoCompleteCustomSource
        If sTemp.ToUpper.Trim = txtUnidad.Text.ToUpper.Trim Then
          txtUnidad.Text = sTemp
          Exit Sub
        End If
      Next
    End If
  End Sub
#End Region
#Region " Métodos "
  Public Sub pClear()
    oUnidadActual.pClear()
    txtUnidad.Text = ""
  End Sub

  Public Sub pCargarPorCodigo(ByVal sCodigo As String)
    Dim stRegistro As Registro = Nothing
    For Each stRegistro In lstRegistros
      If stRegistro.Codigo.ToUpper.Trim = sCodigo.ToUpper.Trim Then
        oUnidadActual.pCUNDMD_Unidad = stRegistro.Codigo
        oUnidadActual.pTABRUN_Descripcion = stRegistro.Detalle
        txtUnidad.Text = oUnidadActual.pCUNDMD_Unidad & " - " & oUnidadActual.pTABRUN_Descripcion
        Exit For
      End If
    Next
  End Sub
#End Region
End Class