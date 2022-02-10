Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades

Public Class frmModificaEnvioDocumento


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If Not txtCobrador.Text.Equals("  /  /") Then
            If IsDate(txtCobrador.Text) = False Then
                MessageBox.Show("Formato de fecha incorrecta", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtCobrador.Focus()
                Exit Sub
            Else
                If Not txtCliente.Text.Equals("  /  /") Then
                    If IsDate(txtCliente.Text) = False Then
                        MessageBox.Show("Formato de fecha incorrecta", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtCliente.Focus()
                        Exit Sub
                    End If
                End If
            End If
        Else
            If Not txtCliente.Text.Equals("  /  /") Then
                If IsDate(txtCliente.Text) = False Then
                    MessageBox.Show("Formato de fecha incorrecta", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtCliente.Focus()
                    Exit Sub
                End If
            End If
        End If


        Dim blClsCuentaCorriente As New clsCuentaCorriente
        Dim beClsCuentaCte As New CuentaCorriente
        beClsCuentaCte.NDCCTC = lblNumero.Text
        beClsCuentaCte.Estado = "0"
        beClsCuentaCte.PSEST_DOCANT = IIf(txtCobrador.Text.Equals("  /  /"), "", "R")
        beClsCuentaCte.PSEST_DOC = IIf(txtCliente.Text.Equals("  /  /"), "", "C")

        If txtCobrador.Text.Equals("  /  /") Then
            beClsCuentaCte.FENCBD = 0
        Else
            beClsCuentaCte.FENCBD = HelpClass.CtypeDate(txtCobrador.Text)
        End If


        If txtCliente.Text.Equals("  /  /") Then
            beClsCuentaCte.FENTCL = 0
        Else
            beClsCuentaCte.FENTCL = HelpClass.CtypeDate(txtCliente.Text)
        End If


        blClsCuentaCorriente.ActualizaEstadoDocumento(beClsCuentaCte)

        DialogResult = Windows.Forms.DialogResult.Yes

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub txtCobrador_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCobrador.Validating
        If Not txtCobrador.Text.Equals("  /  /") Then
            If IsDate(txtCobrador.Text) = False Then
                MessageBox.Show("Formato de fecha incorrecta", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtCobrador.Focus()
            End If
        End If
    End Sub

    Private Sub txtCliente_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCliente.Validating
        If Not txtCliente.Text.Equals("  /  /") Then
            If IsDate(txtCliente.Text) = False Then
                MessageBox.Show("Formato de fecha incorrecta", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtCliente.Focus()
            End If
        End If
    End Sub
End Class
