Public Class frmServiciosxFacturar2

    Private Sub frmServiciosxFacturar2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            UcServicioPorFacturar.pUsuario = HelpUtil.UserName
            UcServicioPorFacturar.pDivision = Ransa.Controls.ServicioOperacion.eDivision.Sil
            Me.UcServicioPorFacturar.ServicioEstado = Ransa.Controls.ServicioOperacion.Comun.eServicioEstado.PorFacturar
            'UcServicioPorFacturar.MostrarBotonFactura = True
            UcServicioPorFacturar.pCompaniaActual = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
            UcServicioPorFacturar.pCargaInicial()
        Catch ex As Exception

        End Try

    End Sub
End Class
