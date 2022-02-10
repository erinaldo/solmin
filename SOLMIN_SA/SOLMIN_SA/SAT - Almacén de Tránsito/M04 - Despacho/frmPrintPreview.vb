Public Class frmPrintPreview

    Public PrnDocumento As New Printing.PrintDocument

    Private Sub PrintPreview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PrintPreviewControl.StartPage = 0
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click


        PrintPreviewControl.Document.Print()
    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        Dim Pagina As Int32 = 0
        Pagina = PrintPreviewControl.StartPage - 1
        If (Pagina >= 0) Then
            PrintPreviewControl.StartPage = Pagina
            PrintPreviewControl.Refresh()
        End If
    End Sub

    Private Sub btnSig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSig.Click
        PrintPreviewControl.StartPage = PrintPreviewControl.StartPage + 1
        PrintPreviewControl.Refresh()
    End Sub

    Private Sub ComboBoxZoom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxZoom.SelectedIndexChanged
        PrintPreviewControl.Zoom = Double.Parse(ComboBoxZoom.Text)
        PrintPreviewControl.Refresh()
    End Sub
End Class
