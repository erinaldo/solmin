Public Class frmOrdenInternaResumen2
    Public MontPETO As Double
    Public MontFATO As Double
    Public MontANTO As Double
    Private Sub frmOrdenInternaResumen2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim MonPETO As Double = CInt(txtMontPELI.Text) + CInt(txtMontPECT.Text) + CInt(txtMontPECI.Text)
        'Dim MontFATO As Double = CDbl(txtMontFALI.Text) + CDbl(txtMontFACT.Text) + CDbl(txtMontFACI.Text)
        'Dim MontANTO As Double = CDbl(txtMontANLI.Text) + CDbl(txtMontANCT.Text) + CDbl(txtMontANCI.Text)

        Dim CantPETO As Double = CDbl(txtCantPELI.Text) + CDbl(txtCantPECT.Text) + CDbl(txtCantPECI.Text)
        Dim CantFATO As Double = CDbl(txtCantFALI.Text) + CDbl(txtCantFACT.Text) + CDbl(txtCantFACI.Text)
        Dim CantANTO As Double = CDbl(txtCantANLI.Text) + CDbl(txtCantANCT.Text) + CDbl(txtCantANCI.Text)

        ' txtMontPETO.Text = Format(MontPETO, "###,###,###,##0.00")
        txtMontFATO.Text = Format(MontFATO, "###,###,###,##0.00")
        txtMontANTO.Text = Format(MontANTO, "###,###,###,##0.00")
        '------------------------
        txtCantPETO.Text = Format(CantPETO, "###########0")
        txtCantFATO.Text = Format(CantFATO, "###########0")
        txtCantANTO.Text = Format(CantANTO, "###########0")
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

End Class
