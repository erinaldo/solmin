Public Class frmVisorCarteraClientes
    Public Sub New(ByVal objCarteraCliente As rptCarteraCliente)
        InitializeComponent()
        CrystalReportViewer1.ReportSource = objCarteraCliente
    End Sub
    Private Sub frmVisorCarteraClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
