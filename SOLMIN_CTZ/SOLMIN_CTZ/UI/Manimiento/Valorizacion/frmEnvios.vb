Imports Db2Manager.RansaData.iSeries.DataObjects

Imports Ransa.Utilitario
Imports System.Windows.Forms
Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades

Public Class frmEnvios
    Public pCCMPN As String = ""
    Public pNROVLR As Decimal = 0
    Public pNROSGV As Decimal = 0

    Public pDialogResult As Boolean = False
    Private Sub frmEnvios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dtgenvios.AutoGenerateColumns = False
            dtgNroSeguimiento.AutoGenerateColumns = False

            ListarDocSEguimiento()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ListarDocSEguimiento()
        Dim obrValorizacion As New clsMantValorizacion
        Dim oValorizacion As New beMantValorizacion
        oValorizacion.CCMPN = pCCMPN
        oValorizacion.NROVLR = pNROVLR
        oValorizacion.NROSGV = pNROSGV
        Dim dt As New DataTable
        'dt = obrValorizacion.ListarDocSeguimiento_x_Valorizacion(oValorizacion)
        dtgNroSeguimiento.DataSource = dt
    End Sub

   
    Private Sub btnAnularSeg_Click(sender As Object, e As EventArgs) Handles btnAnularSeg.Click
        Try
            If dtgNroSeguimiento.CurrentRow Is Nothing Then
                Exit Sub
            End If

            Dim obrValorizacion As New clsMantValorizacion
            If dtgenvios Is Nothing Then
                Exit Sub
            End If
            If MessageBox.Show("Está seguro de eliminar el documento de seguimiento?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim obeMantValorizacion As New beMantValorizacion
                Dim strResultado As String = ""
                obeMantValorizacion.CCMPN = dtgNroSeguimiento.CurrentRow.Cells("CCMPN").Value
                obeMantValorizacion.NROVLR = dtgNroSeguimiento.CurrentRow.Cells("NROVLR").Value
                obeMantValorizacion.NROSGV = dtgNroSeguimiento.CurrentRow.Cells("NROSGV_DS").Value
                obeMantValorizacion.CULUSA = ConfigurationWizard.UserName
                strResultado = obrValorizacion.EliminarDocumentoSeguimiento(obeMantValorizacion)
                If strResultado.Length > 0 Then
                    MessageBox.Show(strResultado, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    'pCambios = True
                    pDialogResult = True
                    ListarDocSEguimiento()
                End If
               
            End If
         
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnAnularEnvio_Click(sender As Object, e As EventArgs) Handles btnAnularEnvio.Click
        Try
            If dtgNroSeguimiento.CurrentRow Is Nothing Then
                Exit Sub
            End If

            Dim obrValorizacion As New clsMantValorizacion
            If dtgenvios Is Nothing Then
                Exit Sub
            End If
            If MessageBox.Show("Está seguro de eliminar el envío", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Dim obeMantValorizacion As New beMantValorizacion
                Dim strResultado As String = ""
                obeMantValorizacion.CCMPN = pCCMPN
                obeMantValorizacion.NROVLR = pNROVLR
                obeMantValorizacion.NROSGV = pNROSGV
                obeMantValorizacion.NCRRDT = dtgenvios.CurrentRow.Cells("NCRRDT").Value
                obeMantValorizacion.CULUSA = ConfigurationWizard.UserName
                strResultado = obrValorizacion.EliminarEnvioxDocSEg(obeMantValorizacion)
                If strResultado.Length > 0 Then
                    MessageBox.Show(strResultado, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    'pCambios = True
                    pDialogResult = True
                    ListarEnvio()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub ListarEnvio()
        Dim obrValorizacion As New clsMantValorizacion

        Dim oValorizacion As New beMantValorizacion
        oValorizacion.CCMPN = dtgNroSeguimiento.CurrentRow.Cells("CCMPN").Value
        oValorizacion.NROVLR = dtgNroSeguimiento.CurrentRow.Cells("NROVLR").Value
        oValorizacion.NROSGV = dtgNroSeguimiento.CurrentRow.Cells("NROSGV_DS").Value
        Dim dt As New DataTable
        dt = obrValorizacion.ListarEnvioxDocSEg(oValorizacion)
        dtgenvios.DataSource = dt
    End Sub

    Private Sub dtgNroSeguimiento_SelectionChanged(sender As Object, e As EventArgs) Handles dtgNroSeguimiento.SelectionChanged
        Try
            ListarEnvio()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    'Private Sub btnLiberar_Click(sender As Object, e As EventArgs) Handles btnLiberar.Click
    '    Try
    '        If dtgNroSeguimiento.CurrentRow Is Nothing Then
    '            Exit Sub
    '        End If
    '        Dim obrValorizacion As New clsMantValorizacion
    '        Dim strmsg As String = ""
    '        Dim oValorizacion As New beMantValorizacion
    '        oValorizacion.CCMPN = dtgNroSeguimiento.CurrentRow.Cells("CCMPN").Value
    '        oValorizacion.NROVLR = dtgNroSeguimiento.CurrentRow.Cells("NROVLR").Value
    '        oValorizacion.NROSGV = dtgNroSeguimiento.CurrentRow.Cells("NROSGV_DS").Value
    '        If MessageBox.Show("¿ Está seguro de liberar Doc. de Envío?", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
    '            Exit Sub
    '        End If
    '        'End If
    '        strmsg = obrValorizacion.LiberarDocumentoEnvio(oValorizacion)

    '        If strmsg.Length > 0 Then
    '            MessageBox.Show(strmsg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            Exit Sub
    '        Else
    '            pDialogResult = True
    '            MessageBox.Show("Valorización liberada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub
End Class


