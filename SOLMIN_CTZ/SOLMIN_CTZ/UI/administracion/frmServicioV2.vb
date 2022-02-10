Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades
Public Class frmServicioV2
    Private Sub frmServicioV2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UcServicioAtendido.pUsuario = ConfigurationWizard.UserName
        UcServicioAtendido.pDivision = Ransa.Controls.ServicioOperacion.eDivision.Todos
        UcServicioAtendido.ServicioEstado = Ransa.Controls.ServicioOperacion.Comun.eServicioEstado.Pendiente
        'UcServicioAtendido.MostrarBotonFactura = False
        UcServicioAtendido.pCompaniaActual = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        UcServicioAtendido.pCargaInicial()
    End Sub

   
End Class
