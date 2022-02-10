 
Imports Ransa.Controls.ServicioOperacion

Public Class frmAsigMonedaPreDoc

    Public pCodMoneda As Decimal = 0
    Public pDescMoneda As String = ""

    Sub Cargar_Moneda()

        Dim objMoneda As New Ransa.Controls.ServicioOperacion.clsMoneda_BL
        Dim dt As New DataTable
        dt = objMoneda.Lista_Moneda_Sol_Dol
        Me.cboMoneda.DataSource = dt
        Me.cboMoneda.ValueMember = "CMNDA1"
        Me.cboMoneda.DisplayMember = "TMNDA"

        If pCodMoneda = 1 Or pCodMoneda = 100 Then
            Me.cboMoneda.SelectedValue = pCodMoneda
        Else
            Me.cboMoneda.SelectedValue = 1
        End If


    End Sub


    Private Sub frmAsigMonedaPreDoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Cargar_Moneda()
            
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            pCodMoneda = cboMoneda.SelectedValue
            pDescMoneda = cboMoneda.Text
           
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click


        Me.Close()
        
        Exit Sub
    End Sub
End Class
