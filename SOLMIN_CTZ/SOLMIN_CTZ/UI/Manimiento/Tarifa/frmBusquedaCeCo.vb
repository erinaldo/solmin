Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Web
Imports IBM.Data.DB2
Imports Ransa.Utilitario
Imports SOLMIN_CTZ.Entidades.mantenimientos
Imports System.Xml
Imports System.Text

Public Class frmBusquedaCeCo

    Public imputCeCo As beImputCeCo
    Public codCeCo As String = String.Empty
    Public DescCeCo As String = String.Empty

    Private Sub frmBusquedaCeCo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dgvCentroCostos.AutoGenerateColumns = False
            Call btnBuscar_Click(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Dim negocio As New clsClaseGeneral
            imputCeCo.Codigo = Val(txtCodigo.Text.Trim)
            imputCeCo.Descripcion = Trim(txtDescripcion.Text)
            imputCeCo.CodigoSAP = Trim(txtCodCeCoSAP.Text)
            dgvCentroCostos.DataSource = negocio.Buscar_CeCo(imputCeCo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub dgvCentroCostos_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCentroCostos.CellContentDoubleClick
        Try
            If dgvCentroCostos.RowCount > 0 Then
                codCeCo = dgvCentroCostos.CurrentRow.Cells("CCNTCS").Value.ToString
                DescCeCo = dgvCentroCostos.CurrentRow.Cells("CECO").Value.ToString
                DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'DialogResult = Windows.Forms.DialogResult.Cancel
        End Try
        Me.Close()
    End Sub
End Class