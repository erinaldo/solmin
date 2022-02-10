Public Class frmAjustarImporte
    Public pDescMoned As String = ""
    Public pServicio As String = ""
    Public pOper As Decimal = 0
    Public pNRLQD As Decimal = 0
    Public pTIPOPL As String = ""
    Public pCCMPN As String = ""
    Public pCMNDA1 As Decimal = 0
    Public pImpoPendiente As Decimal = 0
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        Exit Sub
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            Dim maxCantidad As Decimal = 0
            If Val(txtAjuste.Text.Trim) = 0 Then
                MessageBox.Show("Ingrese número válido , mayor a 0")
                Exit Sub
            End If
            maxCantidad = txtAjuste.Text.Trim

            Dim msg As String = ""
            Dim bePreDoc As New PreDoc_BE
            Dim obePreDoc As New clsPreDoc_BL

            bePreDoc = New PreDoc_BE
            bePreDoc.PSCCMPN = pCCMPN
            bePreDoc.PNNRCTRL = pNRLQD
            bePreDoc.PSTIPOPL = pTIPOPL
            bePreDoc.PNAJUSTE = maxCantidad
            bePreDoc.PNCMNDA1 = pCMNDA1
            bePreDoc.PNIMPOPEND = pImpoPendiente
            msg = obePreDoc.ValidarAjuste(bePreDoc)
            If msg.Length > 0 Then
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub frmAjustarImporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtMoned.Text = pDescMoned
        txtServicio.Text = pServicio
        txtOperacion.Text = pOper

    End Sub
    Public Sub NumerosyDecimal(ByVal CajaTexto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtAjuste_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAjuste.KeyPress
        NumerosyDecimal(txtAjuste, e)

    End Sub
End Class