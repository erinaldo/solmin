Public Class frmServicioSAT

    Private Sub frmServicioSAT_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        UcServicioAtendido1.pUsuario = objSeguridadBN.pUsuario
        UcServicioAtendido1.pDivision = Ransa.Controls.ServicioOperacion.eDivision.Todos
        UcServicioAtendido1.pTipoAlmacen = Ransa.Controls.ServicioOperacion.Comun.eTipoAlmacen.AlmTransito
        UcServicioAtendido1.ServicioEstado = Ransa.Controls.ServicioOperacion.Comun.eServicioEstado.Pendiente
        'UcServicioAtendido1.MostrarBotonFactura = False
        UcServicioAtendido1.pCompaniaActual = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        UcServicioAtendido1.pCargaInicial()
    End Sub

  
End Class
