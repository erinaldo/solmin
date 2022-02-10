Public Class frmVisorFacturacionSIL
    Public Sub New(ByVal objFacturaSIL As rptFacturaSIL)
        InitializeComponent()
        CrystalReportViewer1.ReportSource = objFacturaSIL
    End Sub

End Class
