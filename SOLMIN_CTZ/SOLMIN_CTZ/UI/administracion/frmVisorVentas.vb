Public Class frmVisorVentas

    Public Sub New(ByVal objCuentaCorriente As rptVentasGeneral)
        InitializeComponent()
        CrystalReportViewer1.ReportSource = objCuentaCorriente
    End Sub

    Private Sub frmVisorVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
