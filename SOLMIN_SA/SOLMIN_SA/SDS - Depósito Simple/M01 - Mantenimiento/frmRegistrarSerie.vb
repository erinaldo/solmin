Public Class frmRegistrarSerie
    Public PNNGUIRN As Int64 = 0
    Public PNNORDSR As Int64 = 0
    Public PNNRITOC As Int64 = 0
    Public PNCANTIDAD As Decimal = 0 'CSR-HUNDRED-080916-SOPORTE-ALMACENES
    Public PNCCLNT As Int64 = 0
    Public PSUSUARIO As String = ""
    Public PNFILA_REG As Int64 = 0

    Private Sub frmRegistrarSerie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Me.UcSerie_Lista.IngresoSeries(PNNORDSR, PNNRITOC, PNCANTIDAD, PNCCLNT, PNNGUIRN, PSUSUARIO)
            Me.UcSerie_Lista.IngresoSeries_V2(PNNORDSR, PNFILA_REG, PNNRITOC, PNCANTIDAD, PNCCLNT, PNNGUIRN, PSUSUARIO)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            UcSerie_Lista.Guardar(0, Nothing)
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class
