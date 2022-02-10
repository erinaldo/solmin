Imports Ransa.TypeDef.Proveedor
Public Class frmProveedor_MDatos
    Public IsNuevo As Boolean = False
    Public oInfoProveedor As New beProveedor
    Public pUsuario As String = ""
    Private _dialogResult As Boolean = False

    Public ReadOnly Property myDialogResult() As Boolean
        Get
            Return _dialogResult
        End Get
    End Property



    Private Sub frmProveedor_MDatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UcProveedor_MDato.Tag = Me.Tag
        UcProveedor_MDato.pUsuario = pUsuario
        UcProveedor_MDato.ShowForm(IsNuevo)
    End Sub

    Private Sub UcProveedor_MDato_CerrarForm() Handles UcProveedor_MDato.CerrarForm
        oInfoProveedor = UcProveedor_MDato.oInfoProveedor
        _dialogResult = UcProveedor_MDato.myDialogResult
        Me.Close()
    End Sub
End Class
