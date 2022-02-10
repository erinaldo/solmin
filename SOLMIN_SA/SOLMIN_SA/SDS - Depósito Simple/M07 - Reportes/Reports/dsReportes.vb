



Partial Class dsReportes

    'Partial Class DtBultoDataTable

    '    'Private Sub DtBultoDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
    '    '    If (e.Column.ColumnName = Me.Column1Column.ColumnName) Then
    '    '        'Agregar código de usuario aquí
    '    '    End If

    '    'End Sub

    'End Class

    Partial Class dtRepMenCIDataTable

        Private Sub dtRepMenCIDataTable_dtRepMenCIRowChanging(ByVal sender As System.Object, ByVal e As dtRepMenCIRowChangeEvent) Handles Me.dtRepMenCIRowChanging

        End Sub

    End Class

    Partial Class dtRotacionMensualDataTable

        'Private Sub dtRotacionMensualDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
        '    If (e.Column.ColumnName = Me.VLRINI_MES1Column.ColumnName) Then
        '        'Agregar código de usuario aquí
        '    End If

        'End Sub

        'Private Sub dtRotacionMensualDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
        '    If (e.Column.ColumnName = Me.INGRESOS_01Column.ColumnName) Then
        '        'Agregar código de usuario aquí
        '    End If

        'End Sub

    End Class

    Partial Class dtDespachoStockDataTable

        'Private Sub dtDespachoStockDataTable_dtDespachoStockRowChanging(ByVal sender As System.Object, ByVal e As dtDespachoStockRowChangeEvent) Handles Me.dtDespachoStockRowChanging

        'End Sub

        'Private Sub dtDespachoStockDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
        '    'If (e.Column.ColumnName = Me.PROCENTAJEIColumn.ColumnName) Then
        '    '    'Agregar código de usuario aquí
        '    'End If

        'End Sub

    End Class

    Partial Class dtStockDataTable

        'Private Sub dtStockDataTable_dtStockRowChanging(ByVal sender As System.Object, ByVal e As dtStockRowChangeEvent) Handles Me.dtStockRowChanging

        'End Sub

    End Class



    Partial Class dtIngresoDataTable

        'Private Sub dtIngresoDataTable_dtIngresoRowChanging(ByVal sender As System.Object, ByVal e As dtIngresoRowChangeEvent) Handles Me.dtIngresoRowChanging

        'End Sub

    End Class

    Partial Class dtRepEntregaEmbAlmDataTable

        Private Sub dtRepEntregaEmbAlmDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.TCMPCLColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

End Class
