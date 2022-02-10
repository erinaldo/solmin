Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine

Public Class PrintForm 

    Private Sub PrintForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.ReportViewer.ShowGroupTreeButton = False
        Me.ReportViewer.DisplayGroupTree = False
        Me.ReportViewer.Zoom(90)

        'Forzando destruccion de memoria
        ClearMemory()

    End Sub

    Public Sub ShowForm(ByVal rpt As ReportDocument, ByVal owner As IWin32Window)

        Me.ReportViewer.ReportSource = rpt

        'Forzando destruccion de memoria
        ClearMemory()

        'Mostrando el formulario
        Me.ShowDialog(owner)

    End Sub

    Public Sub ShowFormClearingCache(ByVal rpt As ReportDocument, ByVal owner As IWin32Window)

        rpt.ReportDefinition.ReportObjects.Reset()

        Me.ReportViewer.ReportSource = rpt

        'Forzando destruccion de memoria
        ClearMemory()

        Me.ReportViewer.ReportSource = Nothing

        'Forzando destruccion de memoria
        ClearMemory()

        rpt.ReportDefinition.ReportObjects.Reset()

        Me.ReportViewer.RefreshReport()
        Me.ReportViewer.Refresh()
        Me.ReportViewer.RefreshReport()
        Me.ReportViewer.ReportSource = rpt
        Me.ReportViewer.Refresh()
        Me.ReportViewer.RefreshReport()

        'Forzando destruccion de memoria
        ClearMemory()

        'Mostrando el formulario
        'Me.ShowDialog(owner)
        Me.Show()

    End Sub

End Class
