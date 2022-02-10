Public Class ExportarExcel
    Public Sub mpGenerarXLS(ByVal strReporteseleccionado As String, ByVal dtTemp As DataTable)
        Dim oQProRansa As cQProRansa = New cQProRansa()
        If strReporteseleccionado = "001" Then
            '         Call oQProRansa.pExportarToXLS(Application.StartupPath & "\xltTarifario.xlt", 2, 8, dtTemp)
        ElseIf strReporteseleccionado = "002" Then
            '          Call oQProRansa.pExportarToXLS(Application.StartupPath & "\xltEstructura.xlt", 2, 8, dtTemp)
        ElseIf strReporteseleccionado = "003" Then
            '         Call oQProRansa.pExportarToXLS(Application.StartupPath & "\xltEstructuraTarifa.xlt", 2, 8, dtTemp)
        Else
            MsgBox("No ha seleccionado ningun reporte")
        End If

        oQProRansa.Dispose()
        oQProRansa = Nothing
        cMemory.ClearMemory()
    End Sub
End Class
