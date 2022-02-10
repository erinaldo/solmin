Public Class frmPreLiquidacionUC

    Private Sub frmPreLiquidacionUC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            UcPreLiquidacion1.pSystem_Prefix = HelpClass.getSetting("System_prefix")
            UcPreLiquidacion1.pUsuario = Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.UserName
            UcPreLiquidacion1.pNameFormulario = Me.Name
            UcPreLiquidacion1.PInicializar()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
