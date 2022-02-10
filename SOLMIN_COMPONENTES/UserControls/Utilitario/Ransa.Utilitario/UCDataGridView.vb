Public Class UCDataGridView

    Public Shared Sub Alinear_Columnas_Grilla(ByVal dtgGrilla As DataGridView)
        For lint_contador As Integer = 0 To dtgGrilla.ColumnCount - 1
            dtgGrilla.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub

    Public Shared Function paginarDataDridView(ByVal dtPaginar As DataView, ByVal inicial As Integer, ByVal final As Integer)
        Dim oDt As New DataTable
        Dim dtnew As New DataTable
        oDt = dtPaginar.ToTable()
        dtnew = oDt.Clone
        If oDt.Rows.Count <= final Then
            final = oDt.Rows.Count - 1
        End If
        For i As Integer = inicial To final
            dtnew.ImportRow(oDt.Rows(i))
        Next
        Return dtnew
    End Function

End Class
