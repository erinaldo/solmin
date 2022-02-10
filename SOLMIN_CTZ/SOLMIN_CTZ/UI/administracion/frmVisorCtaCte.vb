Public Class frmVisorCtaCte

    Public Sub New(ByVal objCuentaCorriente As rptCuentaCorriente)
        InitializeComponent()
        CrystalReportViewer1.ReportSource = objCuentaCorriente
    End Sub

    Private Sub frmVisorCtaCte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
