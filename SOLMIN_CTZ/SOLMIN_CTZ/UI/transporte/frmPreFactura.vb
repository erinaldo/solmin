

Public Class frmPreFactura


    Private Sub frmPreFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        UcPreFactura1.pSystem_Prefix = HelpClass.getSetting("System_prefix")
        UcPreFactura1.pUsuario = Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.UserName
        UcPreFactura1.pNameFormulario = Me.Name
        UcPreFactura1.pInicializar()

    End Sub
End Class
