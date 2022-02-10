Imports Ransa.DAO.WayBill
Imports Ransa.TypeDef.WayBill
Public Class frmTipoTransporte
    Public oInfoTipoTransporte As New TipoTransporte
    Private Sub frmTipoTransporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        oInfoTipoTransporte = UcTipoTransporte.oInfoTipoTransporte
        If (oInfoTipoTransporte.CODIGO.Equals("0")) Then
            MessageBox.Show("Debe seleccionar el tipo Transporte")
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        MessageBox.Show("Para Proseguir debería de seleccionar el tipo Transporte")
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class
