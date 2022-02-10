Public Class frmAsignacionOperacion

  Dim lstr_resultado

  Public Property Resultado() As String
    Get
      Return lstr_resultado
    End Get
    Set(ByVal value As String)
      lstr_resultado = value
    End Set
  End Property

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.lstr_resultado = "CERRAR"
    Me.Close()
  End Sub

  Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
    Generar_Operacion_Agencias_Ransa()
  End Sub

  Public Sub ShowForm(ByVal OrdenAgencias As String, ByVal OperacionAgencias As String, ByVal owner As IWin32Window)
    Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue
    Me.txtOSAgencias.Text = OrdenAgencias
    Me.txtNroOperacionAgencias.Text = OperacionAgencias
    Me.Show(owner)

  End Sub

  Private Sub txtOrdenServicio_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOrdenServicio.KeyUp

    If e.KeyCode = Keys.Enter Then
      Generar_Operacion_Agencias_Ransa()
    End If

  End Sub

  Private Sub Generar_Operacion_Agencias_Ransa()

    If Me.txtOrdenServicio.Text = "" Then
      HelpClass.MsgBox("Debe de Ingresar el Nro de Orden de Servicio de Trasportes")
      Exit Sub
    End If

    Dim objParametros As New Hashtable
    Dim objAgenciasRansa As New NEGOCIO.Operaciones.OrdenServicioAgenciaRansa_BLL
    objParametros.Add("AGE_NORSRT", Me.txtOSAgencias.Text)
    objParametros.Add("PNCDTR", Me.txtNroOperacionAgencias.Text)
    objParametros.Add("NORSRT", Me.txtOrdenServicio.Text)
    objParametros.Add("HORA", HelpClass.NowNumeric)
    objParametros.Add("HOY", HelpClass.TodayNumeric)
    objParametros.Add("CCLNT", IIf(Me.ckbClientesRansa.Checked = True, "000606", ""))

    Me.lblResultado.Text = objAgenciasRansa.Registrar_Orden_Servicio(objParametros)

    If Me.lblResultado.Text.StartsWith("ERROR") = True Then
      Me.lblResultado.StateCommon.ShortText.Color1 = Color.Red
      Me.lblResultado.StateNormal.ShortText.Color1 = Color.Red
    Else
      Me.lblResultado.StateCommon.ShortText.Color1 = Color.Blue
      Me.lblResultado.StateNormal.ShortText.Color1 = Color.Blue
    End If

    'Deshabilitando los Botones
    Me.txtOrdenServicio.Enabled = False
    Me.btnProcesar.Enabled = False
    Me.btnCancelar.Text = "Cerrar Pantalla"

  End Sub

  Private Sub txtOrdenServicio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

  End Sub
End Class
