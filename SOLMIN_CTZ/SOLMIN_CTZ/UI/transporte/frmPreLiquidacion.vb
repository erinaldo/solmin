

Public Class frmPreLiquidacion

    Private Sub frmPreLiquidacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        UcPreLiquidacion1.pSystem_Prefix = HelpClass.getSetting("System_prefix")
        UcPreLiquidacion1.pUsuario = Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.UserName
        UcPreLiquidacion1.pNameFormulario = Me.Name
        UcPreLiquidacion1.pInicializar()

    End Sub
End Class