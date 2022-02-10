Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO.seguimiento_wap
Imports System.Data
Imports System.IO
Imports System.Reflection
Imports System.Text

Public Class frmSeguimientoVehiculoTransporte
  Private gEnum_Mantenimiento As MANTENIMIENTO
  Private bolBuscar As Boolean = False

  Public Sub ShowForm(ByVal CodigoTrasportista As String, ByVal CodigoUnidad As String, ByVal owner As IWin32Window)
    'Pone el flag en neutral
    gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
    Cargar_Compania()
    Alinear_Columnas_Grilla()
    'Establece el trasportista
    Me.ctbTransportista.Enabled = False
  End Sub

  Private Function Asignar_Valor(ByVal lint_Codigo As Integer) As String
    Dim lstr_Valor As String = ""
    Select Case lint_Codigo
      Case 0
        lstr_Valor = "A"
      Case 1
        lstr_Valor = "*"
    End Select
    Return lstr_Valor
  End Function

  Private Sub Alinear_Columnas_Grilla()
    Me.gwdDatos.AutoGenerateColumns = False
    For lint_contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
      Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
  End Sub

  Private Sub frmConsultarVehiculo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      Cargar_Compania()
    Catch : End Try
  End Sub

  'Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
  '  If Not Me.ctbTransportista.pRucTransportista.Trim.Equals("") Then 'OrElse Me.ctbEvento.Texto.TextLength > 0 Then
  '    Me.Lista()
  '    If gwdDatos.Rows.Count > 0 Then
  '      If _vCodTransportista <> ctbTransportista.pRucTransportista Then
  '        _vCodTransportista = ctbTransportista.pRucTransportista
  '        Me.Cargar_Combo_Acoplado()
  '      End If
  '    End If
  '  Else
  '    Me.gwdDatos.Rows.Clear()
  '  End If
  'End Sub

  Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
    Dim frmAsignarUbicacion As New frmAsignarUbicacionUnidad
    With frmAsignarUbicacion
      .ShowDialog()
    End With
  End Sub


#Region "COMPAÑIA DIVISION Y PLANTA"

  Private Sub Cargar_Compania()
    Try
      Dim objCompaniaBLL As New NEGOCIO.Compania_BLL
      bolBuscar = False
      objCompaniaBLL.Crea_Lista()
      cmbCompania.DataSource = objCompaniaBLL.Lista
      cmbCompania.ValueMember = "CCMPN"
      cmbCompania.DisplayMember = "TCMPCM"
            'cmbCompania.SelectedIndex = 0
            bolBuscar = True

            Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(Me.cmbCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
      cmbCompania_SelectedIndexChanged(Nothing, Nothing)
    Catch ex As Exception
    End Try
  End Sub

  Private Sub Cargar_Division()
    Dim objDivision As New NEGOCIO.Division_BLL
    Try
      If (bolBuscar = True And Me.cmbCompania.SelectedValue IsNot Nothing) Then
        bolBuscar = False
        objDivision.Crea_Lista()
        cmbDivision.DataSource = objDivision.Lista_Division(Me.cmbCompania.SelectedValue.ToString.Trim)
        cmbDivision.ValueMember = "CDVSN"
        bolBuscar = True
        cmbDivision.DisplayMember = "TCMPDV"
        Me.cmbDivision.SelectedValue = "T"
        If Me.cmbDivision.SelectedIndex = -1 Then
          Me.cmbDivision.SelectedIndex = 0
        End If
        cmbDivision_SelectedIndexChanged(Nothing, Nothing)
      End If
    Catch ex As Exception

      HelpClass.MsgBox(ex.Message)
    End Try
  End Sub

  Private Sub Cargar_Planta()
    Dim objPlanta As New NEGOCIO.Planta_BLL
    Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
    Try
      If (bolBuscar = True And Me.cmbCompania.SelectedValue IsNot Nothing And Me.cmbDivision.SelectedValue IsNot Nothing) Then
        bolBuscar = False
        objPlanta.Crea_Lista()
        objLisEntidad = objPlanta.Lista_Planta(Me.cmbCompania.SelectedValue, Me.cmbDivision.SelectedValue)
        cmbPlanta.DataSource = objLisEntidad
        cmbPlanta.ValueMember = "CPLNDV"
        cmbPlanta.DisplayMember = "TPLNTA"
        bolBuscar = True
        cmbPlanta.SelectedIndex = 0
        cmbPlanta_SelectedIndexChanged(Nothing, Nothing)

      End If
    Catch ex As Exception

      HelpClass.MsgBox(ex.Message)
    End Try

  End Sub

  Private Sub cmbCompania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCompania.SelectedIndexChanged
    If bolBuscar = True Then
      Cargar_Division()
      If Me.cmbCompania.SelectedValue <> "EZ" Then Me.ctbTransportista.pClearAll()
    End If
  End Sub

  Private Sub cmbDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDivision.SelectedIndexChanged
    If bolBuscar = True Then
      Cargar_Planta()
    End If
  End Sub

  Private Sub cmbPlanta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlanta.SelectedIndexChanged
    If bolBuscar = True Then
      InicializarFormulario()
    End If
  End Sub

  Private Sub InicializarFormulario()
    gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
    ctbTransportista.pClear()
    If Me.cmbCompania.SelectedValue <> "EZ" Then Me.ctbTransportista.pClearAll()
    Me.gwdDatos.Rows.Clear()
  End Sub
#End Region

End Class