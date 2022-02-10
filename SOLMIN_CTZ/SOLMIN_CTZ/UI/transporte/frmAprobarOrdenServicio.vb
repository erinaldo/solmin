

Public Class frmAprobarOrdenServicio

    Private Sub frmAprobarOrdenServicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        UcAprobarOrdenServicio1.pSystem_Prefix = HelpClass.getSetting("System_prefix")
        UcAprobarOrdenServicio1.pUsuario = Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.UserName
        UcAprobarOrdenServicio1.pNameFormulario = Me.Name
        UcAprobarOrdenServicio1.pInicializar()


    End Sub
End Class
