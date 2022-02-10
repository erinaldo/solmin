Imports System.Windows.Forms

Public Class frmCantImpresionEtiqueta

    Public InicioEtiqueta As Integer = 1
    Public FinEtiqueta As Integer = 1
    Public CantBulto As Integer = 0
    Public CantCopias As Integer = 0

   
    Private Sub KryptonButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub


 


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            Dim CantInicio As Integer = Val(txtCantInicial.Text.Trim)
            Dim CantFin As Integer = Val(txtCantFinal.Text.Trim)
            If Val(txtCantCopias.Text.Trim) <= 0 Then
                MessageBox.Show("Verificar el número de copias(mínimo 1)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If CantInicio <= 0 Or CantFin <= 0 Or CantBulto <= 0 Then
                MessageBox.Show("Verificar las cantidades, deben ser mayores a 0", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If CantInicio > CantFin Then
                MessageBox.Show("El final debe ser mayor o igual al inicio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If CantFin > CantBulto Then
                MessageBox.Show("El final debe ser menor o igual a la cantidad de Bultos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            InicioEtiqueta = CantInicio
            FinEtiqueta = CantFin
            CantCopias = Val(txtCantCopias.Text.Trim)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmCantImpresionEtiqueta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtCantFinal.Text = "1"
            txtCantCopias.Text = "1"
            txtCantFinal.Text = CantBulto
            txtCantBultos.Text = CantBulto
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
