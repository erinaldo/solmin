Imports SOLMIN_CTZ.NEGOCIO

Public Class frmGestionPT 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
    Public TipoDoc As String = String.Empty, NumeroDoc As String = String.Empty
    Public Ccmpn As String = String.Empty, Ctpodc As String = String.Empty, Ndcctc As String = String.Empty
    Dim ParteTransferencia As New clsParteTransferenciaBL

    Private Sub frmGestionPT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtTipoDoc.Text = TipoDoc
            txtNumero.Text = NumeroDoc

            dgvCabecera.AutoGenerateColumns = False
            dgvHistorial.AutoGenerateColumns = False

            dgvCabecera.DataSource = ParteTransferencia.ListarCabecera(Ccmpn, Ctpodc, Ndcctc)
            dgvHistorial.DataSource = ParteTransferencia.ListarHitorial(Ccmpn, Ctpodc, Ndcctc)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnEnviarAnulacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarAnulacion.Click
        Try

            If dgvCabecera.DataSource Is Nothing OrElse dgvCabecera.DataSource.rows.count = 0 Then 'ECM-ActualizacionTarifario[RF003]-160516
                Exit Sub
            End If
            Dim TienePTEnSAP As Boolean = False

            For Each Item As DataGridViewRow In dgvCabecera.Rows

                If ("" & Item.Cells("NDCMSP").Value).ToString.Trim <> "" Then

                    TienePTEnSAP = True

                    Exit For

                End If

            Next


            With frmAnulacionDetalleSAP
                .TipoDoc = TipoDoc
                .NumeroDoc = NumeroDoc
                .Ccmpn = Ccmpn
                .Ctpodc = Ctpodc
                .Ndcctc = Ndcctc
                .ShowDialog()
                dgvCabecera.DataSource = ParteTransferencia.ListarCabecera(Ccmpn, Ctpodc, Ndcctc)
                dgvHistorial.DataSource = ParteTransferencia.ListarHitorial(Ccmpn, Ctpodc, Ndcctc)

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class