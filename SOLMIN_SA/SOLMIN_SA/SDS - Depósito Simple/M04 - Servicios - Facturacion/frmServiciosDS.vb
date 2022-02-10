Public Class frmServiciosDS
    Private Sub frmServiciosDS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        UcServicioAtendido1.pUsuario = objSeguridadBN.pUsuario
        UcServicioAtendido1.pDivision = Ransa.Controls.ServicioOperacion.eDivision.Almacen
        UcServicioAtendido1.pTipoAlmacen = RANSA.Controls.ServicioOperacion.Comun.eTipoAlmacen.DepSimple
        UcServicioAtendido1.ServicioEstado = Ransa.Controls.ServicioOperacion.Comun.eServicioEstado.Pendiente
        UcServicioAtendido1.pCompaniaActual = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        UcServicioAtendido1.pCargaInicial()
    End Sub
End Class
