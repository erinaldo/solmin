Partial Class EstructuraDespachoSDSW
    Partial Class dtTicketOrdenServicioDataTable

        Private Sub dtTicketOrdenServicioDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.CTPOATColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

End Class
