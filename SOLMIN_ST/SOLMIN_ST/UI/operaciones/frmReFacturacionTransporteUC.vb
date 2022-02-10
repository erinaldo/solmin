Public Class frmReFacturacionTransporteUC

    Private Sub frmReFacturacionTransporteUC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try


            UcRefacturacionTransporte1.pSystem_Prefix = HelpClass.getSetting("System_prefix")
            UcRefacturacionTransporte1.pUsuario = Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.UserName
            UcRefacturacionTransporte1.pNameFormulario = Me.Name
            UcRefacturacionTransporte1.pInicializar()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
