Public Class frmGenerarSecuencia
    Private intCliente As Int64 = 0

    Public Property pintCliente() As Int64
        Get
            Return intCliente
        End Get
        Set(ByVal value As Int64)
            intCliente = value
        End Set
    End Property

    Private Sub txtNroInicial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroInicial.TextChanged
        Dim intNroFinal As Int64
        If Int64.TryParse(txtNroInicial.Text, intNroFinal) Then
            intNroFinal += txtNroEtiquetas.Text
            txtNroFinal.Text = intNroFinal
        End If
    End Sub

    Private Sub txtNroEtiquetas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroEtiquetas.TextChanged
        Dim intNroFinal As Int64
        If Int64.TryParse(txtNroEtiquetas.Text, intNroFinal) Then
            intNroFinal += Int64.Parse("0" & txtNroInicial.Text)
            txtNroFinal.Text = intNroFinal
        End If
    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        Dim intNroCopias As Int16 = 0
        If Int16.TryParse(txtNroCopias.Text, intNroCopias) Then
            Call mpImprimir_EtiquetaSecuenciaBultos(intCliente, txtPrefijoInicial.Text, txtNroInicial.Text, txtNroFinal.Text, intNroCopias)
        End If
        Me.Close()
    End Sub

    Private Sub txtPrefijoInicial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrefijoInicial.TextChanged
        txtPrefijoFinal.Text = txtPrefijoInicial.Text
    End Sub
End Class
