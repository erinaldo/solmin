Public Class frmFacturacionTransporteUC

    Private Sub frmFacturacionTransporteUC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            UcFacturacionTransporte1.pSystem_Prefix = HelpClass.getSetting("System_prefix")
            UcFacturacionTransporte1.pUsuario = Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.UserName
            UcFacturacionTransporte1.pNameFormulario = Me.Name
            UcFacturacionTransporte1.pInicializar()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
