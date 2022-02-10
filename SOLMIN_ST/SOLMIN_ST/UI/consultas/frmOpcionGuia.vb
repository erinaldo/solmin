Public Class frmOpcionGuia

#Region "Atributo"
  Private _OPCION As String
#End Region

#Region "Propiedades"

  Public ReadOnly Property OPCION() As String
    Get
      Return _OPCION
    End Get
  End Property

#End Region

  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    If Me.rbtnAnular.Checked = True Then
      Me._OPCION = "A"
    Else
      Me._OPCION = "E"
    End If
    Me.DialogResult = Windows.Forms.DialogResult.OK
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click, btnCerrar.Click, btnCerrar.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub
End Class
