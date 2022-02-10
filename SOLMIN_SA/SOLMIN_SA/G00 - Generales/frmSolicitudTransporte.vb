Public Class frmSolicitudTransporte

    Private Sub frmSolicitudTransporte_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        UcSolicitudTransporte1.pUsuario = objSeguridadBN.pUsuario
        UcSolicitudTransporte1.pInicializar()
    End Sub
End Class
