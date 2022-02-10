Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports System.Text

Public Class frmAsignarUbicacionUnidad

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

  Private Sub ckbUbicacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbUbicacion.CheckedChanged
    Me.txtUbicacion.Enabled = Me.ckbUbicacion.Checked
    Me.dtpFecha.Enabled = Me.ckbUbicacion.Checked
    Me.txtHora.Enabled = Me.ckbUbicacion.Checked
  End Sub
End Class
