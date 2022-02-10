Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos

Public Class frmConfiguracionVehicular

#Region "Variables"
  Private gEnum_Mantenimiento As MANTENIMIENTO
#End Region

#Region "Metodos y Funciones"

  Private Sub Estado_Controles(ByVal lbool_Estado As Boolean)
    Me.txtConfigTracto.Enabled = lbool_Estado
    Me.txtConfigAcoplado.Enabled = lbool_Estado
    Me.nudColumnaAsignada.Enabled = lbool_Estado
    Me.btnElegirImagen.Enabled = lbool_Estado
  End Sub

  Private Sub Limpiar_Controles()
    Me.txtConfigTracto.Text = ""
    Me.txtConfigAcoplado.Text = ""
    Me.nudColumnaAsignada.Value = 0
    Me.HeaderDatos.ValuesPrimary.Heading = "Información de Junta Transportista"
  End Sub

  Private Sub AccionCancelar()
    Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
    Me.Limpiar_Controles()
    Me.Estado_Controles(False)
    If Me.gwdDatos.Rows.Count > 0 Then
      Me.gwdDatos.CurrentRow.Selected = False
    End If
    Me.btnNuevo.Enabled = True
    Me.btnGuardar.Enabled = False
    Me.btnCancelar.Enabled = False
   
  End Sub

  Private Sub Alinear_Columnas_Grilla()
    Me.gwdDatos.AutoGenerateColumns = False
    Me.gwdDatos.AutoGenerateColumns = False
    For lint_contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
      Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
  End Sub

  Private Sub Listar()
    Dim obj_Logica As New ConfiguracionVehicular_BLL
    Dim objetoParametro As New Hashtable
    objetoParametro.Add("PSTCNFGV", Me.txtConfiguracionVehicular.Text.Trim)
    Me.gwdDatos.DataSource = obj_Logica.Listar_Configuracion_Vehicular(objetoParametro)

    For Each objeto As ConfiguracionVehicular In obj_Logica.Listar_Configuracion_Vehicular(objetoParametro)

    Next
  End Sub

  Private Sub Cargar_Datos_Grilla()
    Me.Limpiar_Controles()
    Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
    Me.txtConfiguracion.Text = Me.gwdDatos.Item("TCNFGV", lint_indice).Value
    Me.txtConfigTracto.Text = Me.gwdDatos.Item("TCNFG1", lint_indice).Value
    Me.txtConfigAcoplado.Text = Me.gwdDatos.Item("TCNFG2", lint_indice).Value
        Me.nudColumnaAsignada.Value = Me.gwdDatos.Item("CCLNAS", lint_indice).Value

  End Sub

  Private Sub Nuevo_Registro()
    'Procedimiento para registrar una nuevo tipo de acoplado
    Dim objEntidad As New ConfiguracionVehicular
    Dim objLogica As New ConfiguracionVehicular_BLL

    objEntidad.CCLNAS = Me.nudColumnaAsignada.Value
    objEntidad.TCNFGV = Me.txtConfiguracion.Text.Trim
    objEntidad.TCNFG1 = Me.txtConfigTracto.Text.Trim
    objEntidad.TCNFG2 = Me.txtConfigAcoplado.Text.Trim
    objEntidad.CULUSA = MainModule.USUARIO
    objEntidad.FULTAC = HelpClass.TodayNumeric
    objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
    objEntidad = objLogica.Registrar_Configuracion_Vehicular(objEntidad)

    If objEntidad.CCLNAS = 0 Then
      HelpClass.ErrorMsgBox()
      Exit Sub
    Else
      Me.Listar()
    End If
  End Sub

  Private Function validar_inputs() As Boolean
    Dim lstr_validacion As String = ""
    Dim lbool_existe_error As Boolean = False
   
    If Me.txtConfigTracto.Text.Trim = "" Then
      lstr_validacion += "* CONFIGURACION TRACTO" & Chr(13)
    End If
    If Me.txtConfigAcoplado.Text.Trim = "" Then
      lstr_validacion += "* CONFIGURACION ACOPLADO" & Chr(13)
    End If
    If Me.nudColumnaAsignada.Value = 0 Then
      lstr_validacion += "* COLUMNA ASIGNADA" & Chr(13)
    End If
    If lstr_validacion <> "" Then
      HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & lstr_validacion)
      lbool_existe_error = True
    End If
    Return lbool_existe_error
  End Function

#End Region

#Region "Eventos"

  Private Sub frmConfiguracionVehicular_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
    btnGuardar.Enabled = False
    btnCancelar.Enabled = False


    Me.Alinear_Columnas_Grilla()
    Me.Estado_Controles(False)
    Me.Listar()
  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Me.Listar()
  End Sub

  Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
    gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
    Me.btnNuevo.Enabled = False
    Me.btnGuardar.Enabled = True

    Me.btnCancelar.Enabled = True
    Me.Limpiar_Controles()
    Me.Estado_Controles(True)
  End Sub

  Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
    If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
      If validar_inputs() = True Then Exit Sub
      'codigo autogenerado en el procedure
      Me.Nuevo_Registro()
      Me.AccionCancelar()

    End If
   
  End Sub

  Private Sub btnElegirImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnElegirImagen.Click
    If Me.txtConfiguracion.Text <> "" Then
      Dim objformLoad As New frmUploadImagen
      objformLoad.ShowForm("configuracion", Me.txtConfiguracion.Text.Trim & ".jpg", Me)
    End If
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.AccionCancelar()
  End Sub

  Private Sub gwdDatos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick
    If e.RowIndex < 0 Then Exit Sub
    Me.Cargar_Datos_Grilla()
  End Sub

  Private Sub gwdDatos_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gwdDatos.KeyUp
    If Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
    Me.Cargar_Datos_Grilla()
  End Sub

  Private Sub gwdDatos_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gwdDatos.DataBindingComplete
    If Me.gwdDatos.Rows.Count > 0 Then
      Me.gwdDatos.CurrentRow.Selected = False
    End If
  End Sub

#End Region
  
 
End Class
