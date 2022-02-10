Imports System.Data


Public Class frmPermisosUsuario

    Private Sub frmPermisosUsuario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.NodeMenu.ExpandAll()
        Me.KryptonSplitContainer1.SplitterDistance = 200
    End Sub

    Public Sub SetPanel(ByVal Contenedor As Form)

        Me.KryptonSplitContainer1.Panel2.Controls.Clear()

        Contenedor.TopLevel = False
        Contenedor.Parent = Me.KryptonSplitContainer1.Panel2
        Contenedor.Dock = DockStyle.Fill
        Contenedor.Visible = True

        'Forzando a Destruir Memoria
        ClearMemory()

    End Sub

    Private Sub NodeMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NodeMenu.Click

        If NodeMenu.SelectedNode Is Nothing Then
            Exit Sub
        End If

        If NodeMenu.SelectedNode.Name = "mnuAplicaciones" Then
            SetPanel(New FrmAplicacion())
        ElseIf NodeMenu.SelectedNode.Name = "mnuMenu" Then
            SetPanel(New FrmMenu())
        ElseIf NodeMenu.SelectedNode.Name = "mnuOpciones" Then
            SetPanel(New FrmOpcionUsuario())
        ElseIf NodeMenu.SelectedNode.Name = "mnuOpcionesUsuario" Then
            SetPanel(New FrmOpcion())
        Else
            Me.KryptonSplitContainer1.Panel2.Controls.Clear()
        End If

    End Sub

    Private Sub NodeMenu_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles NodeMenu.AfterSelect

    End Sub
End Class
