Imports SOLMIN_ST.ENTIDADES.mantenimientos

Public Class frmGuiaTransportista

  'Private objGuiaTransporte As New GuiaTransportista

  'Public ReadOnly Property pGuiaTransporte() As GuiaTransportista
  '  Get
  '    Return objGuiaTransporte
  '  End Get
  'End Property

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

End Class
