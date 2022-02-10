Public Class ExportarExcel
    Public Sub mpGenerarXLS(ByVal strReporteseleccionado As String, ByVal dtTemp As DataTable)
        Dim oQProRansa As cQProRansa = New cQProRansa()
        If strReporteseleccionado = "001" Then
            Call oQProRansa.pExportarToXLS(Application.StartupPath & "\ExportToXLS\xltTarifario.xlt", 2, 8, dtTemp)
        ElseIf strReporteseleccionado = "002" Then
            Call oQProRansa.pExportarToXLS(Application.StartupPath & "\ExportToXLS\xltEstructura.xlt", 2, 8, dtTemp)
        ElseIf strReporteseleccionado = "003" Then
            Call oQProRansa.pExportarToXLS(Application.StartupPath & "\ExportToXLS\xltEstructuraTarifa.xlt", 2, 8, dtTemp)
        ElseIf strReporteseleccionado = "004" Then
            'Excel Orden Interna Control
            Call oQProRansa.pExportarToXLS(Application.StartupPath & "\ExportToXLS\xltOIControl.xlt", 2, 5, dtTemp)
        ElseIf strReporteseleccionado = "005" Then
            'Excel Orden Interna Cierre
            Call oQProRansa.pExportarToXLS(Application.StartupPath & "\ExportToXLS\xltOICierre.xlt", 2, 5, dtTemp)
        ElseIf strReporteseleccionado = "006" Then
            'Excel Orden Interna Detalles
            Call oQProRansa.pExportarToXLS(Application.StartupPath & "\ExportToXLS\xltOIDetalles.xlt", 2, 5, dtTemp)
        ElseIf strReporteseleccionado = "007" Then
            'Excel Orden Interna V1
            Call oQProRansa.pExportarToXLS(Application.StartupPath & "\ExportToXLS\xltOrdenInternaV1.xlt", 2, 10, dtTemp)
        ElseIf strReporteseleccionado = "008" Then
            'Excel Orden Interna V2
            Call oQProRansa.pExportarToXLS(Application.StartupPath & "\ExportToXLS\xltOrdenInternaV2.xlt", 2, 10, dtTemp)
        ElseIf strReporteseleccionado = "009" Then
            'Reporte Consistencia
            Call oQProRansa.pExportarToXLS(Application.StartupPath & "\ExportToXLS\xltConsistencia.xlt", 2, 5, dtTemp)
        ElseIf strReporteseleccionado = "010" Then
            'Reporte Pre facturacion
            Call oQProRansa.pExportarToXLS(Application.StartupPath & "\ExportToXLS\xltFacturacion.xlt", 2, 5, dtTemp)
        ElseIf strReporteseleccionado = "011" Then
            'Reporte Detalle Facturacion
            Call oQProRansa.pExportarToXLS(Application.StartupPath & "\ExportToXLS\xltDetFacturacion.xlt", 2, 5, dtTemp)
        Else
            MsgBox("No ha seleccionado ningun reporte")
        End If

        oQProRansa.Dispose()
        oQProRansa = Nothing
        cMemory.ClearMemory()
    End Sub
End Class
