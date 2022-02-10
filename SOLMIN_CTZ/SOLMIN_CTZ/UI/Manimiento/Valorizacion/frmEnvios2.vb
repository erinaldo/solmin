Imports Db2Manager.RansaData.iSeries.DataObjects

Imports Ransa.Utilitario
Imports System.Windows.Forms
Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades

Public Class frmEnvios2
    Public pCCMPN As String = ""
    Public pNROVLR As Decimal = 0
    Public pNROSGV As Decimal = 0
    Public pNCRRDE_EnvioActivo As Decimal = 0
    Public pDialogResult As Boolean = False
    Private Sub frmEnvios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dtgenvios.AutoGenerateColumns = False
            ListarEnvio()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub ListarEnvio()
        Dim obrValorizacion As New clsMantValorizacion
        Dim oValorizacion As New beMantValorizacion
        oValorizacion.CCMPN = pCCMPN
        oValorizacion.NROVLR = pNROVLR
        oValorizacion.NROSGV = pNROSGV
        Dim dt As New DataTable
        dt = obrValorizacion.ListarEnvioxDocSEg(oValorizacion)
        dtgenvios.DataSource = dt
    End Sub

    Private Sub dtgNroSeguimiento_SelectionChanged(sender As Object, e As EventArgs)
        Try
            ListarEnvio()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAnularSeg_Click(sender As Object, e As EventArgs) Handles btnAnularSeg.Click
        Try

            Dim obrValorizacion As New clsMantValorizacion
            If dtgenvios.CurrentRow Is Nothing Then
                Exit Sub
            End If
         
            Dim msg As String = ""
            If dtgenvios.CurrentRow.Cells("NCRRDT").Value = pNCRRDE_EnvioActivo Then
                Dim pdestino As String = dtgenvios.CurrentRow.Cells("COD_DESTINO").Value.ToString.Trim
                Dim pEstadoAprob As String = dtgenvios.CurrentRow.Cells("ESTADO_APROB").Value.ToString.Trim
                If pdestino = "C" And pEstadoAprob = "A" Then
                    'Dim dtUsuarioAutorizado As New DataTable
                    'dtUsuarioAutorizado = obrValorizacion.ListarUsuarioValorizacionAnulacion
                    'If dtUsuarioAutorizado.Rows.Count = 0 Then
                    '    msg = "No cuenta con autorización para anular envíos aprobados cliente."
                    '    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    '    Exit Sub
                    'Else
                    '    msg = "El envío se encuentra aprobado en Cliente, está seguro de eliminar el envío?"

                    'End If
                    MessageBox.Show("Envío no puede ser anulado. Se encuentra aprobado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If
            If msg = "" Then
                msg = "Está seguro de eliminar el envío?"
            End If
         
            If MessageBox.Show(msg, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Dim obeMantValorizacion As New beMantValorizacion
                Dim strResultado As String = ""
                obeMantValorizacion.CCMPN = pCCMPN
                obeMantValorizacion.NROVLR = pNROVLR
                obeMantValorizacion.NROSGV = pNROSGV
                obeMantValorizacion.NCRRDT = dtgenvios.CurrentRow.Cells("NCRRDT").Value
                obeMantValorizacion.CULUSA = ConfigurationWizard.UserName
                obeMantValorizacion.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                strResultado = obrValorizacion.EliminarEnvioxDocSEg(obeMantValorizacion)
                If strResultado.Length > 0 Then
                    MessageBox.Show(strResultado, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    pDialogResult = True
                    ListarEnvio()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class


