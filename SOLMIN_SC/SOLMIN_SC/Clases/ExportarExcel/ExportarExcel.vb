Public Class ExportarExcel
    Public Sub mpGenerarXLS(ByVal strReporteseleccionado As String, ByVal dtTemp As DataTable)
        Dim oQProRansa As cQProRansa = New cQProRansa()
        If strReporteseleccionado = "Pendientes" Then
            Call oQProRansa.pExportarToXLS(Application.StartupPath & "\PlantillasExcel\xltCargaInternacionalPendientes.xlt", 2, 8, dtTemp)
        ElseIf strReporteseleccionado = "002" Then
            Call oQProRansa.pExportarToXLS(Application.StartupPath & "\PlantillasExcel\xltEstructura.xlt", 2, 8, dtTemp)
        ElseIf strReporteseleccionado = "003" Then
            Call oQProRansa.pExportarToXLS(Application.StartupPath & "\PlantillasExcel\xltEstructuraTarifa.xlt", 2, 8, dtTemp)
        ElseIf strReporteseleccionado = "004" Then
            'Excel Orden Interna Control
            Call oQProRansa.pExportarToXLS(Application.StartupPath & "\PlantillasExcel\xltOIControl.xlt", 2, 5, dtTemp)
        ElseIf strReporteseleccionado = "005" Then
            'Excel Orden Interna Cierre
            Call oQProRansa.pExportarToXLS(Application.StartupPath & "\PlantillasExcel\xltOICierre.xlt", 2, 5, dtTemp)
        ElseIf strReporteseleccionado = "006" Then
            'Excel Orden Interna Detalles
            Call oQProRansa.pExportarToXLS(Application.StartupPath & "\PlantillasExcel\xltOIDetalles.xlt", 2, 5, dtTemp)
        Else
            MsgBox("No ha seleccionado ningun reporte")
        End If

        oQProRansa.Dispose()
        oQProRansa = Nothing
        cMemory.ClearMemory()
    End Sub
End Class
