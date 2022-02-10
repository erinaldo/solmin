'Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class MainForm
    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Desactivar para las pruebas internas
        'If ConfigurationWizard.LoginFileExists = False Then
        '    MessageBox.Show("Debe de iniciar la sesion desde el aplicativo LOGIN", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Application.Exit()
        '    Me.Close()
        '    Exit Sub
        'End If
        Me.Text = HelpUtil.getSetting("Titulo")
        Me.lblStatusBar.Text = HelpUtil.getSetting("Titulo")
        Me.MenuSolmin1.ImageBind = Me.ImageList1
        Me.SolminToolBar1.DataBind = True
        Me.MenuSolmin1.DataBind = True
        Ransa.Utilitario.SetQueryStringParametersDeploy()
        'Ransa.Utilitario.IdCompaniaDeploy = "EZ"
    End Sub

End Class
