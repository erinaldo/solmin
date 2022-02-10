Imports SOLMIN_CTZ.Entidades

Public Class frmMantRubro


    Private _obeServicios As New Servicio_X_Rubro

    Public Property bebeServicios() As Servicio_X_Rubro
        Get
            Return _obeServicios
        End Get
        Set(ByVal value As Servicio_X_Rubro)
            _obeServicios = value
        End Set
    End Property


    Private Sub frmMantRubro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If _obeServicios.NRRUBR <> 0 Then
            Me.txtRubro.Text = _obeServicios.NOMRUB
        End If
    End Sub


    Private Sub Guardar()

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Guardar()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class
