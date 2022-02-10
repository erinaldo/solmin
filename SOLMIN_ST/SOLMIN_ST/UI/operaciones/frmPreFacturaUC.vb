Public Class frmPreFacturaUC

    Private Sub frmPreFacturaUC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            UcPreFactura1.pSystem_Prefix = HelpClass.getSetting("System_prefix")
            UcPreFactura1.pUsuario = Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.UserName
            UcPreFactura1.pNameFormulario = Me.Name
            UcPreFactura1.pInicializar()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
