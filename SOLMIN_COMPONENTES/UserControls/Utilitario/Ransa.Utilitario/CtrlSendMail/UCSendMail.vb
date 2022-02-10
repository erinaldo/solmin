Public Class UCSendMail
    Public Event Salir()
    Public Event SendMail()

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If validarDatos() Then
            RaiseEvent SendMail()
        End If

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        RaiseEvent Salir()
    End Sub

    Private Function validarDatos() As Boolean
        If txtDe.Text.Trim.Length = 0 Then
            MessageBox.Show("Debe ingresar un correo Origen", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        If txtPara.Text.Trim.Length = 0 Then
            MessageBox.Show("Debe ingresar un correo destino", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If


        If Not HelpClass.validar_Mail(txtDe.Text) Then
            MessageBox.Show("Ingrese un Mail de origen válido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Return False
        End If



        Dim MailsAdress() As String = txtPara.Text.Split(";")

        For i As Integer = 0 To MailsAdress.Length - 1
            If Not HelpClass.validar_Mail(MailsAdress(i)) Then
                MessageBox.Show("Ingrese un Mail destino válido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
        Next

        Dim MailsCo() As String = txtCopia.Text.Split(";")

        If txtCopia.Text.Trim.Length > 0 Then

            For i As Integer = 0 To MailsCo.Length - 1
                If Not HelpClass.validar_Mail(MailsCo(i)) Then
                    MessageBox.Show("Ingrese un Mail Copia válido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End If
            Next
        End If

        Return True
    End Function
End Class
