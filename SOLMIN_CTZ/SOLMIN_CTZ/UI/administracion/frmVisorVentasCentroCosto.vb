Public Class frmVisorVentasCentroCosto

    Public Sub New(ByVal objCuentaCorriente As rptVentasCentroCosto)
        InitializeComponent()
        CrystalReportViewer1.ReportSource = objCuentaCorriente
    End Sub

    Private Sub frmVisorVentasCentroCosto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
