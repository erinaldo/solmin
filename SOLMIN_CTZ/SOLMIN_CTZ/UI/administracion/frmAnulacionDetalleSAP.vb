Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO

Public Class frmAnulacionDetalleSAP
    Public Ccmpn As String = String.Empty, Ctpodc As String = String.Empty, Ndcctc As String = String.Empty
    Public TipoDoc As String = String.Empty, NumeroDoc As String = String.Empty
    Dim Aprobador As New clsAprobadorBL
    Dim ParteTransferencia As New clsParteTransferenciaBL
    Public SolicitarAprobador As Boolean = True

    Private Sub frmAnulacionDetalleSAP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtTipoDoc.Text = TipoDoc
            txtDocumento.Text = NumeroDoc
            cboAprobador.DataSource = Aprobador.ListarAprobador(Ccmpn)
            cboAprobador.ListColumnas = Aprobador.ColumnaAprobador()
            cboAprobador.Cargas()
            cboAprobador.Limpiar()
            cboAprobador.ValueMember = "Usuario"
            cboAprobador.DispleyMember = "Nombre"
            cboAprobador.Enabled = SolicitarAprobador

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Try

            If cboAprobador.Resultado Is Nothing AndAlso SolicitarAprobador = True Then

                MessageBox.Show("Debe seleccionar un aprobador.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                Exit Sub

            End If

            Dim Aprobador As String = ""

            If cboAprobador.Resultado IsNot Nothing Then

                Aprobador = CType(cboAprobador.Resultado, beAprobador).Usuario

            End If

            Dim msjAnulacion As String = ParteTransferencia.AnularPT_SAP(Ccmpn, Ctpodc, Ndcctc, Aprobador)

            If Len(msjAnulacion) > 0 Then

                MessageBox.Show(msjAnulacion, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If

            Me.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub



    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub


End Class