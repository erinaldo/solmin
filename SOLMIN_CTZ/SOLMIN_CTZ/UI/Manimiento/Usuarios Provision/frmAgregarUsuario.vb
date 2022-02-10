Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades.mantenimientos
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class frmAgregarUsuario

    Private Sub btnGrabarTarifa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabarTarifa.Click
        Dim obrGeneral As New clsClaseGeneral
        Dim obeGeneral As New ClaseGeneral
        With obeGeneral
            .USUARIO = Uc_CboUsuario1.pPSMMCUSR
            .CUSCRT = ConfigurationWizard.UserName
        End With
        If obrGeneral.intInsertarUsuarioReversionProvision(obeGeneral) = -1 Then
            Ransa.Utilitario.HelpClass.ErrorMsgBox()
            Exit Sub
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelarTarifa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarTarifa.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class
