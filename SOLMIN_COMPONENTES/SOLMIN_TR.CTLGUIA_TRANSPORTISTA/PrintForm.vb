Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine

Public Class PrintForm

    Private Sub PrintForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.ReportViewer.ShowGroupTreeButton = False
        Me.ReportViewer.DisplayGroupTree = False
        Me.ReportViewer.Zoom(90)

    End Sub

    Public Sub ShowForm(ByVal rpt As ReportDocument, ByVal owner As IWin32Window)

        Me.ReportViewer.ReportSource = rpt
        'Mostrando el formulario
        Me.ShowDialog(owner)

    End Sub

End Class
