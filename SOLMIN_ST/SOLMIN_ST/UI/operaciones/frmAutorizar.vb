Public Class frmAutorizarPedidoEfectivo

  Public Sub New(ByVal objEntidad As Hashtable)

    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()
    Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue
    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    Me.txtNroSolEfectivo.Text = objEntidad("NMSLPE")
    Me.txtImporteSolEfectivo.Text = Format(objEntidad("ISLPES"), "###,###,##0.00")
    Me.txtNroOperacion.Text = objEntidad("NORDSR")
    Me.txtMotivoGiro.Text = objEntidad("MOTIVO")

  End Sub
#Region "Eventos"
  Private Sub btnBuscarGastosRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
    Me.DialogResult = Windows.Forms.DialogResult.OK
  End Sub

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub
#End Region
End Class
