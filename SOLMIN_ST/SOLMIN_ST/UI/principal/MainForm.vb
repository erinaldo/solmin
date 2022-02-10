Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.ENTIDADES
Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class MainForm

    Private Sub MainForm_ClientSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ClientSizeChanged
        Try
            For Each objKryptonform As Form In Me.MdiChildren
                CType(CType(objKryptonform, ComponentFactory.Krypton.Toolkit.KryptonForm).Controls("KryptonManager"), Object).GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue
            Next
        Catch : End Try
    End Sub

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Desactivar para las pruebas internas
        'If ConfigurationWizard.LoginFileExists = False Then
        '    MsgBox("Debe de iniciar la sesion desde el aplicativo LOGIN")
        '    Application.Exit()
        '    Me.Close()
        '    Exit Sub
        'End If

        Me.BackColor = Color.White
 

        'preverificando que exista un login
        If MenuSolmin1.LoginExists() = False Then
            Dim objLogin As New frmLogin
            objLogin.ShowDialog(Me)
            If objLogin.ProcesoValidacion = False Then
                Me.Close()
                Exit Sub
            End If
        End If

        Ransa.Utilitario.SetQueryStringParametersDeploy()
        Ransa.Utilitario.IdCompaniaDeploy = "EZ" 'JM  descomentar al final del desarrollo 22/12/2015

        'Enlazando los Menu del Sistema
        Me.MenuSolmin1.DataBind = True
        Me.MenuSolmin1.ImageBind = Me.ImageList1
        Me.SolminToolBar1.DataBind = True

        'Iniciando el pre cargado de tablas generales
        '  Dim objProceso As New Threading.Thread(AddressOf MainModule.PreCargarDatos)
        'objProceso.Start()
        MainModule.CargarTablasGlobales()
        ' objProceso.Abort()

        ClearMemory()

        'Levantando el nombre del Usuario
        MainModule.USUARIO = Autenticacion_BLL.GetUserName
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue

        Ransa.Utilitario.MainModuleDeploy.SetQueryStringParametersDeploy()

        'Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy = "EZ"

        ''Prueba del formulario frmConsultarOperación
        'frmConsultarOperacion.MdiParent = Me
        'frmConsultarOperacion.Show()
        'frmConfiguracionDeltasEventosWAP.MdiParent = Me
        'frmConfiguracionDeltasEventosWAP.Show()

    End Sub

    Private Sub MainForm_MdiChildActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MdiChildActivate
        Try
            For Each objKryptonform As Object In Me.MdiChildren
                If TypeOf objKryptonform Is ComponentFactory.Krypton.Toolkit.KryptonForm Then

                    Dim components As System.ComponentModel.IContainer
                    components = New System.ComponentModel.Container
                    Dim objManager As New ComponentFactory.Krypton.Toolkit.KryptonManager(components)
                    objManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue

                End If
            Next
        Catch : End Try
    End Sub

  Private Sub SolminToolBar1_CascadaToolStripMenuItem_Click() Handles SolminToolBar1.CascadaToolStripMenuItem_Click
    LayoutMdi(MdiLayout.Cascade)
  End Sub

  Private Sub SolminToolBar1_HorizontalToolStripMenuItem_Click() Handles SolminToolBar1.HorizontalToolStripMenuItem_Click
    LayoutMdi(MdiLayout.TileHorizontal)
  End Sub

  Private Sub SolminToolBar1_VerticalToolStripMenuItem_Click() Handles SolminToolBar1.VerticalToolStripMenuItem_Click
    LayoutMdi(MdiLayout.TileVertical)
  End Sub

  Private Sub SolminToolBar1_CerrarVentanasToolStripMenuItem_Click() Handles SolminToolBar1.CerrarVentanasToolStripMenuItem_Click
    While ActiveMdiChild IsNot Nothing
      ActiveMdiChild.Close()
    End While
  End Sub

  Private Sub SolminToolBar1_CerrarVentanaActivaToolStripMenuItem_Click() Handles SolminToolBar1.CerrarVentanaActivaToolStripMenuItem_Click
    If (ActiveMdiChild IsNot Nothing) Then
      ActiveMdiChild.Close()
    End If
  End Sub

  'Private Sub SolminToolBar1_SalirToolStripMenuItem_Click() Handles SolminToolBar1.SalirToolStripMenuItem_Click
  '  Me.Close()
  'End Sub

  Private Sub MenuSolmin1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuSolmin1.Load

  End Sub
End Class
