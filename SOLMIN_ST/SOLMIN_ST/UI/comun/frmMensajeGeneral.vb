Public Class frmMensajeGeneral

#Region "Atributo"
  Private pmensaje As String

  Public WriteOnly Property Mensaje() As String
    Set(ByVal value As String)
      pmensaje = value
    End Set
  End Property

#End Region

#Region "Eventos"

  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    Me.DialogResult = Windows.Forms.DialogResult.OK
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

  Private Sub frmMensajeGeneral_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.txtMensaje.Text = pmensaje
  End Sub

#End Region

End Class
