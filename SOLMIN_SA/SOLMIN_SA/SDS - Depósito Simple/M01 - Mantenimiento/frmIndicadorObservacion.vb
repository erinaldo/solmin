Imports RANSA.NEGO
Imports RANSA.TypeDef
Public Class frmIndicadorObservacion
    Public oInfoIndicador As New beIndicador
    Public CTPOIN_DESCRIPCION As String = ""
    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmIndicadorObservacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            lblObservacion.Text = CTPOIN_DESCRIPCION
            Dim oblIndicador As New brIndicador
            Dim oIndicador As New beIndicador
            oIndicador = oblIndicador.ListarDatosIndicador(oInfoIndicador)
            txtObservacion.Text = oIndicador.PSTOBACT

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Try
            Dim retorno As Int32 = 0
            Dim oblIndicador As New brIndicador
            oInfoIndicador.PSTOBACT = txtObservacion.Text.Trim
            retorno = oblIndicador.ActualizarDatosIndicador(oInfoIndicador)
            If (retorno = 1) Then
                Me.Close()
            Else
                MessageBox.Show("No se pudo realizar", "Incidencias", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
