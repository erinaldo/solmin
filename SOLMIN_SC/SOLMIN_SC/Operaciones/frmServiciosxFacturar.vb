Public Class frmServiciosxFacturar

    Private Sub frmServiciosxFacturar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UcServicioAtendido.pUsuario = HelpUtil.UserName
        UcServicioAtendido.pDivision = Ransa.Controls.ServicioOperacion.eDivision.Sil
        'UcServicioAtendido.pDivision = Ransa.Controls.ServicioOperacion.eDivision.Todos
        Me.UcServicioAtendido.ServicioEstado = Ransa.Controls.ServicioOperacion.Comun.eServicioEstado.PorFacturar
        UcServicioAtendido.MostrarBotonFactura = True
        UcServicioAtendido.pCompaniaActual = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        UcServicioAtendido.pCargaInicial()

    End Sub
End Class
