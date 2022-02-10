
Public Class frmCentroCosto
    Private dtView As New DataView
    Public nCodigo As Integer = 0
    Public sDescripcion As String = String.Empty
    Public oDtCentroCosto As New DataTable

    Private Sub frmCentroCosto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtgCentroCosto.AutoGenerateColumns = False
        dtView = oDtCentroCosto.DefaultView()
        dtgCentroCosto.DataSource = dtView

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.Handled = False
        Else
            If Char.IsControl(e.KeyChar) Then
                If Asc(e.KeyChar) = 13 Then
                    If txtCodigo.Text.Length > 0 Then
                        dtView.RowFilter = "   CCNTCS =" & txtCodigo.Text
                    Else
                        txtDescripcion_TextChanged(Nothing, Nothing)
                    End If
                Else
                    e.Handled = False
                End If

            Else

                e.Handled = True
            End If
        End If
    End Sub

    Private Sub dtgCentroCosto_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgCentroCosto.DoubleClick

        Dim lnFila As Integer = dtgCentroCosto.CurrentCell.RowIndex

        nCodigo = dtgCentroCosto("CCNTCS", lnFila).Value
        sDescripcion = dtgCentroCosto("CCNBNS", lnFila).Value

        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub

    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged
        dtView.RowFilter = "    CCNBNS LIKE '%" & txtDescripcion.Text.Trim & "%'"
    End Sub

    Private Sub txtDescripcion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If Asc(e.KeyChar) = 13 Then

            dtView.RowFilter = "    CCNBNS LIKE '%" & txtDescripcion.Text.Trim & "%'"
       
        End If
    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged
        If txtCodigo.Text.Length = 0 Then txtDescripcion_TextChanged(Nothing, Nothing)
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class
