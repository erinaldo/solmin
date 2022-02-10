Public Class frmOpRegistroOperacion

  Private _NroOperacion As String
  Private _NroPlaneamiento As String
  Private _respuesta As String



  Public Property NroOperacion() As String
    Get
      Return _NroOperacion
    End Get
    Set(ByVal value As String)
      _NroOperacion = value
    End Set
  End Property

  Public Property NroPlaneamiento() As String
    Get
      Return _NroPlaneamiento
    End Get
    Set(ByVal value As String)
      _NroPlaneamiento = value
    End Set
  End Property

  Public ReadOnly Property Respuesta() As String
    Get
      Return _respuesta
    End Get
  End Property

  Private Sub rbtnReutilizar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnReutilizar.CheckedChanged, rbtnGenerarNuevo.CheckedChanged

    If rbtnReutilizar.Checked = True Then
      _respuesta = "REUTILIZAR"
    Else
      _respuesta = "NUEVO"
    End If

  End Sub

 

  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    Me.DialogResult = Windows.Forms.DialogResult.OK
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

  Private Sub frmOpRegistroOperacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    _respuesta = "REUTILIZAR"
    Me.rbtnReutilizar.Text = "Deseo reutilizar el mismo número de Operación y Planeamiento de los anteriores items de la solicitud"
  End Sub
End Class
