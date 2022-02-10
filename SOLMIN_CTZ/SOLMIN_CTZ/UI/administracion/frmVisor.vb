Public Class frmVisor

    Public Sub New(ByVal objContrato As rptContrato)
        InitializeComponent()
        CrystalReportViewer1.ReportSource = objContrato
    End Sub

End Class
