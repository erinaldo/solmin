Imports System.Windows.Forms

Public Class FRMuPLOADER
    Public Delegate Sub SaveNegocio(ByVal sender As Object)
    Public Event onSaveCampoNegocio As SaveNegocio

    Public Sub ClickonSaveNegocio(ByVal sender As Object)
        RaiseEvent onSaveCampoNegocio(sender)
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Uploader1_onSaveCampoNegocio(ByVal sender As Object) Handles Uploader1.onSaveCampoNegocio
        ClickonSaveNegocio(sender)
    End Sub
End Class
