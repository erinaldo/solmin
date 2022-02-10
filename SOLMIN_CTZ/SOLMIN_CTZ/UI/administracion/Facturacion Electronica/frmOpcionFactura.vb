Public Class frmOpcionFactura
    Public CodTipoOpcion As String = "0"
    Private Sub frmOpcionFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dt As New DataTable
            dt.Columns.Add("COD")
            dt.Columns.Add("DESC")
            Dim dr As DataRow
            dr = dt.NewRow
            dr("COD") = "1"
            dr("DESC") = "Resumido"
            dt.Rows.Add(dr)

            dr = dt.NewRow
            dr("COD") = "2"
            dr("DESC") = "Detallado"
            dt.Rows.Add(dr)

            cbpOpcion.DataSource = dt
            cbpOpcion.DisplayMember = "DESC"
            cbpOpcion.ValueMember = "COD"

            cbpOpcion.SelectedValue = "1"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        CodTipoOpcion = cbpOpcion.SelectedValue
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class