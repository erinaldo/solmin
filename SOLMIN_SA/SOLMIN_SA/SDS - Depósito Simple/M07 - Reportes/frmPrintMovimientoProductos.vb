Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmPrintMovimientoProductos

    Private Sub frmPrintMovimientoProductos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.crvReporte.ShowGroupTreeButton = False
        Me.crvReporte.DisplayGroupTree = False
        Me.crvReporte.Zoom(90)

    End Sub

    Public Sub ShowForm(ByVal rpt As ReportDocument, ByVal owner As IWin32Window)
        crvReporte.Visible = True
        Me.crvReporte.ReportSource = rpt

        'Forzando destruccion de memoria
        'ClearMemory()

        'Mostrando el formulario
        Me.ShowDialog(owner)

    End Sub

    Public Sub ShowFormClearingCache(ByVal rpt As ReportDocument, ByVal owner As IWin32Window)
        crvReporte.Visible = True
        rpt.ReportDefinition.ReportObjects.Reset()

        Me.crvReporte.ReportSource = rpt

        'Forzando destruccion de memoria
        'ClearMemory()

        Me.crvReporte.ReportSource = Nothing

        'Forzando destruccion de memoria
        'ClearMemory()

        rpt.ReportDefinition.ReportObjects.Reset()

        Me.crvReporte.RefreshReport()
        Me.crvReporte.Refresh()
        Me.crvReporte.RefreshReport()
        Me.crvReporte.ReportSource = rpt
        Me.crvReporte.Refresh()
        Me.crvReporte.RefreshReport()

        'Forzando destruccion de memoria
        'ClearMemory()

        'Mostrando el formulario
        'Me.ShowDialog(owner)
        Me.Show()

    End Sub
End Class
