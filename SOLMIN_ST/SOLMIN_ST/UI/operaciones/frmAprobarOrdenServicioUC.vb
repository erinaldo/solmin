Public Class frmAprobarOrdenServicioUC

    Private Sub frmAprobarOrdenServicioUC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try



            UcAprobarOrdenServicio1.pSystem_Prefix = HelpClass.getSetting("System_prefix")
            UcAprobarOrdenServicio1.pUsuario = Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.UserName
            UcAprobarOrdenServicio1.pNameFormulario = Me.Name
            UcAprobarOrdenServicio1.pInicializar()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
