

Public Class frmListaRegistroIncidencias

    Private Sub frmListaRegistroIncidencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UcRegistroDeIncidencias1.pUsuario = objSeguridadBN.pUsuario
        UcRegistroDeIncidencias1.pCompaniaActual = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        UcRegistroDeIncidencias1.pInicializar()
    End Sub
End Class
