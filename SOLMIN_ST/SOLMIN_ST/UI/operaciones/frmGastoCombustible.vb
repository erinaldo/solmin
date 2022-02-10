Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones

Public Class frmGastoCombustible

#Region "Atributo"
  Private mNKMRCR As Double
  Private mNLQGST As Double
  Private mNOPRCN As Double
#End Region

#Region "Properties"

  Public WriteOnly Property NLQGST() As Double
    Set(ByVal value As Double)
      mNLQGST = value
    End Set
  End Property

  Public WriteOnly Property NOPRCN() As Double
    Set(ByVal value As Double)
      mNOPRCN = value
    End Set
  End Property

  Public WriteOnly Property NKMRCR() As Double
    Set(ByVal value As Double)
      mNKMRCR = value
    End Set
  End Property

#End Region

#Region "Eventos Gasto Combustible"

  Private Sub frmGastoCombustible_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.Limpiar_Controles_Gasto_Combustible()
    Me.Estado_Controles_Gasto_Combustible(True)
    Me.Listar_Grifo()
    Me.Listar_Tipo_Combustible()
    Me.txtKmRecorrer.Text = Me.mNKMRCR.ToString
    Me.ctbTipoCombustible.Codigo = "D2"
  End Sub

  Private Sub btnGuardarGastoCombustible_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarGastoCombustible.Click
    If Me.validar_inputs_Gasto_Combustible = True Then Exit Sub
    Me.Nuevo_Registro_Gasto_Combustible()
    Me.DialogResult = Windows.Forms.DialogResult.OK
  End Sub

  Private Sub btnCancelarGastoCombustible_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarGastoCombustible.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

  Private Sub txtValeRansa_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValeRansa.KeyPress, txtValeGrifo.KeyPress
    If e.KeyChar = "." Then
      e.Handled = True
      Exit Sub
    End If
    If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
  End Sub

#End Region

#Region "Métodos y Funciones Gasto Combustible"

  Private Sub Limpiar_Controles_Gasto_Combustible()
    Me.txtValeGrifo.Text = ""
    Me.txtValeRansa.Text = ""
    Me.ctbTipoCombustible.Limpiar()
    'Me.txtDireccionGrifo.Text = ""
    Me.ctbGrifo.Limpiar()
    Me.dtpFechaCarga.Value = Date.Today
    Me.txtCantidadGalones.Text = ""
    Me.txtImporteGasto.Text = ""
    Me.txtKmRecorrer.Text = ""
  End Sub

  Private Sub Estado_Controles_Gasto_Combustible(ByVal lbool_Estado As Boolean)
    Me.txtValeGrifo.Enabled = lbool_Estado
    Me.txtValeRansa.Enabled = lbool_Estado
    Me.ctbTipoCombustible.Enabled = lbool_Estado
    'Me.txtDireccionGrifo.Enabled = lbool_Estado
    Me.ctbGrifo.Enabled = lbool_Estado
    Me.dtpFechaCarga.Enabled = lbool_Estado
    Me.txtCantidadGalones.Enabled = lbool_Estado
    Me.txtImporteGasto.Enabled = lbool_Estado
    Me.txtKmRecorrer.Enabled = lbool_Estado
  End Sub

  Private Sub Nuevo_Registro_Gasto_Combustible()
    Dim obj_Entidad As New LiquidacionGastos
    Dim obj_Logica As New LiquidacionGastos_BLL
    Try
      obj_Entidad.NLQGST = Me.mNLQGST
      obj_Entidad.NOPRCN = Me.mNOPRCN
      obj_Entidad.NVLRNS = Me.txtValeRansa.Text.Trim
      obj_Entidad.NVLGRF = IIf(Me.txtValeGrifo.Text.Trim = "", 0, Me.txtValeGrifo.Text.Trim)
      obj_Entidad.CGRFO = IIf(Me.ctbGrifo.Codigo.Trim = "", 0, Me.ctbGrifo.Codigo.Trim)
      'obj_Entidad.TGRIFO = Me.txtDireccionGrifo.Text.Trim
      obj_Entidad.FCRCMB = HelpClass.CDate_a_Numero8Digitos((Me.dtpFechaCarga.Value))
      obj_Entidad.QGLNCM = IIf(Me.txtCantidadGalones.Text.Trim = "", 0, Me.txtCantidadGalones.Text.Trim)
      obj_Entidad.CTPCMB = Me.ctbTipoCombustible.Codigo
      obj_Entidad.NKMRCR = IIf(Me.txtKmRecorrer.Text.Trim = "", 0, Me.txtKmRecorrer.Text.Trim)
      obj_Entidad.ICSTOS = IIf(Me.txtImporteGasto.Text.Trim = "", 0, Me.txtImporteGasto.Text.Trim)
      'obj_Entidad.IVNTAS = IIf(Me.txtImporteVenta.Text.Trim = "", 0, Me.txtImporteVenta.Text.Trim)
      obj_Entidad.CULUSA = MainModule.USUARIO
      obj_Entidad.FULTAC = HelpClass.TodayNumeric
      obj_Entidad.HULTAC = HelpClass.NowNumeric
            obj_Entidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
      obj_Entidad.NLQGST = obj_Logica.Registrar_Gasto_Combustible(obj_Entidad).NLQGST
      If obj_Entidad.NLQGST = 0 Then
        HelpClass.ErrorMsgBox()
        Exit Sub
      Else
        HelpClass.MsgBox("Se Registró Satisfactoriamente")
      End If
    Catch ex As Exception
    End Try
  End Sub

  Private Function validar_inputs_Gasto_Combustible() As Boolean
    Dim lstr_validacion As String = ""
    Dim lbool_existe_error As Boolean = False
    If Me.txtValeRansa.TextLength = 0 OrElse Me.txtValeRansa.Text = 0 Then
      lstr_validacion += "* VALE RANSA " & Chr(13)
    End If
    If Me.txtValeGrifo.TextLength = 0 OrElse Me.txtValeGrifo.Text = 0 Then
      lstr_validacion += "* VALE GRIFO " & Chr(13)
    End If
    If Me.ctbGrifo.NoHayCodigo = True Then
      lstr_validacion += "* GRIFO" & Chr(13)
    End If
    'If Me.txtDireccionGrifo.TextLength = 0 Then
    '  lstr_validacion += "* DIRECCION GRIFO " & Chr(13)
    'End If
    If Me.ctbTipoCombustible.NoHayCodigo = True Then
      lstr_validacion += "* TIPO COMBUSTIBLE " & Chr(13)
    End If
    If Me.txtCantidadGalones.TextLength = 0 OrElse Me.txtCantidadGalones.Text = 0 Then
      lstr_validacion += "* CANTIDAD GALONES " & Chr(13)
    End If
    If Me.txtKmRecorrer.TextLength = 0 OrElse Me.txtKmRecorrer.Text = 0 Then
      lstr_validacion += "* KILOMETROS RECORRER " & Chr(13)
    End If
    If Me.txtImporteGasto.TextLength = 0 OrElse Me.txtImporteGasto.Text = 0 Then
      lstr_validacion += "* IMPORTE GASTO " & Chr(13)
    End If
    If lstr_validacion <> "" Then
      HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & lstr_validacion)
      lbool_existe_error = True
    End If
    Return lbool_existe_error
  End Function

  Private Sub Listar_Tipo_Combustible()
    Dim obj_Logica As New TipoCombustible_BLL
    With Me.ctbTipoCombustible
      .DataSource = HelpClass.GetDataSetNative(obj_Logica.Listar_TipoCombustible)
      .KeyField = "CTPCMB"
      .ValueField = "TDSCMB"
      .DataBind()
    End With
  End Sub

  Private Sub Listar_Grifo()
    Dim obj_Logica As New Grifo_BLL
    With Me.ctbGrifo
      .DataSource = HelpClass.GetDataSetNative(obj_Logica.Listar_Grifos())
      .KeyField = "CGRFO"
      .ValueField = "TGRFO"
      .DataBind()
    End With
  End Sub

#End Region

End Class
