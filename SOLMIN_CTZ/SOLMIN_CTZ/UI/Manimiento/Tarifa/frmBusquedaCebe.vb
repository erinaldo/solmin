Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Web
Imports IBM.Data.DB2
Imports Ransa.Utilitario
Imports SOLMIN_CTZ.Entidades.mantenimientos
Imports System.Xml
Imports System.Text

Public Class frmBusquedaCebe

    Public imputCebe As beImputCeBe
    Public codCeBe As String = String.Empty
    Public DescCeBe As String = String.Empty

    Private Sub frmBusquedaCebe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dgvCentroBeneficio.AutoGenerateColumns = False
            Call btnBuscar_Click(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Dim negocio As New clsClaseGeneral
            imputCebe.Codigo = Val(txtCodigo.Text.Trim)
            imputCebe.Descripcion = Trim(txtDescripcion.Text)
            imputCebe.CodigoSAP = Trim(txtCodCeBeSAP.Text)
            dgvCentroBeneficio.DataSource = negocio.Buscar_CeBe(imputCebe)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
     
    End Sub

    Private Sub dgvCentroBeneficio_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCentroBeneficio.CellDoubleClick
        Try
            If dgvCentroBeneficio.RowCount > 0 Then
                codCeBe = dgvCentroBeneficio.CurrentRow.Cells("CCNTCS").Value.ToString
                DescCeBe = dgvCentroBeneficio.CurrentRow.Cells("CEBE").Value.ToString
                DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            'DialogResult = Windows.Forms.DialogResult.Cancel
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Me.Close()
    End Sub
End Class