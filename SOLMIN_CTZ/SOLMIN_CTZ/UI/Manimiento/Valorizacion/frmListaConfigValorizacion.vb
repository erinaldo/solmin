Imports Db2Manager.RansaData.iSeries.DataObjects

Imports Ransa.Utilitario
Imports System.Windows.Forms
Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades

Public Class frmListaConfigValorizacion
    Public pCCMPN As String = ""
    Public pCCLNT As Decimal = 0
    Public pQDAPVL As Decimal = 0
    Public pREFCNT As String = ""
    Public pCNFCVL As Decimal = 0
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            Seleccionar()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      

    End Sub

    Private Sub frmListaConfigValorizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            dtglistado.AutoGenerateColumns = False
            Dim oValorizacion As New Valorizacion
            Dim obrConfValorizacion As New clsConfValorizacion
            Dim dt As New DataTable
            With oValorizacion
                .CCMPN = pCCMPN
                .CCLNT = pCCLNT
                .SESTRG = "A"
            End With
            dt = obrConfValorizacion.ListarConfCierreValorizacion(oValorizacion)
            dtglistado.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()

    End Sub

    Private Sub dtglistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtglistado.CellDoubleClick
        Try

            Seleccionar()
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Seleccionar()
        pREFCNT = dtglistado.CurrentRow.Cells("REFCNT").Value
        pQDAPVL = dtglistado.CurrentRow.Cells("QDAPVL").Value
        pCNFCVL = dtglistado.CurrentRow.Cells("CNFCVL").Value
    End Sub
End Class