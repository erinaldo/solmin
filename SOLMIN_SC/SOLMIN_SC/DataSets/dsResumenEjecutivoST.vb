

Partial Public Class dsResumenEjecutivoST
    Partial Class dtST_RTipoUnidadDataTable

        Private Sub dtST_RTipoUnidadDataTable_dtST_RTipoUnidadRowChanging(ByVal sender As System.Object, ByVal e As dtST_RTipoUnidadRowChangeEvent) Handles Me.dtST_RTipoUnidadRowChanging

        End Sub

        Private Sub dtST_RTipoUnidadDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.PESOColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

End Class
