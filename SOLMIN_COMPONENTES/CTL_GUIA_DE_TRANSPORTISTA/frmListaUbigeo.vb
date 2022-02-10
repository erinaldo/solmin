Imports SOLMIN_ST.NEGOCIO
Public Class frmListaUbigeo

    Public cod_ubigeo As Decimal = 0
    Public desc_ubigeo As String = ""

    Private Sub dtgUbigeo_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgUbigeo.CellDoubleClick
        Try
            cod_ubigeo = dtgUbigeo.CurrentRow.Cells("CUBGEO").Value
            desc_ubigeo = dtgUbigeo.CurrentRow.Cells("UBIGEO").Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private dt_list_ubigeo As New DataTable
    Private Sub frmListaUbigeo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim obrUbigeo As New Ubigeo_BLL
            'Dim dt As New DataTable
            dt_list_ubigeo = obrUbigeo.Listar_Ubigeo
            dtgUbigeo.DataSource = dt_list_ubigeo
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged, txtDescripcion.TextChanged
        Try
            Buscar_Ubigeo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Buscar_Ubigeo()
        Dim drFilter() As DataRow
        Dim dt_filtro As New DataTable
        dt_filtro = dt_list_ubigeo.Clone
        drFilter = dt_list_ubigeo.Select("CUBGEO LIKE '%" & txtCodigo.Text.Trim.ToUpper & "%'  AND UBIGEO LIKE '%" & txtDescripcion.Text.ToUpper & "%'")
        For Each dr As DataRow In drFilter
            dt_filtro.ImportRow(dr)
        Next
        'dt_filtro = drFilter.CopyToDataTable
        dtgUbigeo.DataSource = dt_filtro

    End Sub

End Class