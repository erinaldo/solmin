Public Class frmServiciosxRevisar

    Private Sub frmServiciosxRevisar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UcServicioAtendido.pUsuario = HelpUtil.UserName
        UcServicioAtendido.pDivision = Ransa.Controls.ServicioOperacion.eDivision.Sil
        'UcServicioAtendido.pDivision = Ransa.Controls.ServicioOperacion.eDivision.Todos
        UcServicioAtendido.ServicioEstado = Ransa.Controls.ServicioOperacion.Comun.eServicioEstado.Pendiente
        UcServicioAtendido.MostrarBotonFactura = False
        UcServicioAtendido.pCompaniaActual = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        UcServicioAtendido.pCargaInicial()

    End Sub
End Class
