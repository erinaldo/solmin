Imports SOLMIN_SC.Negocio
Public Class frmLogTracking
    Public pNORSCI As Decimal = 0
    Public pCCMPN As String = ""

    Private Sub frmBuscarOC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dtgBusqueda.AutoGenerateColumns = False
            Dim oclsEmbarqueAduana As New clsEmbarque
            Dim dt As New DataTable
            txtEmbarque.Text = pNORSCI
            dt = oclsEmbarqueAduana.ListarLogTracking(pCCMPN, pNORSCI)
            dtgBusqueda.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    
 
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class
