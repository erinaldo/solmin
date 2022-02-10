Public Class frmSeguimientoOrdenDeCompra

    Private Sub frmSeguimientoOrdenDeCompra_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strUsuario As String = ""
        strUsuario = objSeguridadBN.pUsuario
        Dim lstr_navigate As String = ""
        lstr_navigate = ("https://secure.ransa.net/WebSegLog/index.aspx?IDCLIENTE=0&x_solmin=true&x_launcher=true&IDAPLICACION=ALMACEN&IDOPCION=OPT4&IDUSUARIO=" & objSeguridadBN.pUsuario)
        Me.WBrowser.Navigate(lstr_navigate)
        Chr(10)
    End Sub
End Class
