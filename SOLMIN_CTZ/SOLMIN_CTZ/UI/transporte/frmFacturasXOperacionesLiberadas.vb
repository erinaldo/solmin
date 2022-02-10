Public Class frmFacturasXOperacionesLiberadas
    Private dblDocumentoOrigen As Double = 0
    Private dblTipoDocumentoOrigen As Double = 0
    Private dblFechaDocumentoOrigen As Double = 0
    Public Sub setDataSource(ByVal table As DataTable)
        Me.dgvFacturas.DataSource = table
    End Sub
    Public Function DocumentoOrigen() As Double
        Return dblDocumentoOrigen
    End Function
    Public Function TipoDocumentoOrigen() As Double
        Return dblTipoDocumentoOrigen
    End Function
    Public Function FechaDocumentoOrigen() As Double
        Return dblFechaDocumentoOrigen
    End Function

    Private Sub dgvFacturas_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFacturas.CellDoubleClick
        dblDocumentoOrigen = Convert.ToDouble(Me.dgvFacturas.Item("NDCMOR", e.RowIndex).Value.ToString)
        dblTipoDocumentoOrigen = Convert.ToDouble(Me.dgvFacturas.Item("CTPDCO", e.RowIndex).Value.ToString)
        dblFechaDocumentoOrigen = Convert.ToDouble(Me.dgvFacturas.Item("FDCMOR", e.RowIndex).Value.ToString)
        Me.Close()
    End Sub
End Class

