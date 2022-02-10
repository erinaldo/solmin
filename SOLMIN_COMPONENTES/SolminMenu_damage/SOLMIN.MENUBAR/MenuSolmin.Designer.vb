<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuSolmin
    Inherits System.Windows.Forms.UserControl

    'UserControl1 reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuSolmin))
    Me.Lista = New System.Windows.Forms.ImageList(Me.components)
    Me.NodeMenu = New System.Windows.Forms.TreeView
    Me.PopupMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.AgregarComoFavoritoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
    Me.EliminarComoFavoritoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
    Me.HGSolminBar = New ComponentFactory.Krypton.Toolkit.KryptonHeader
    Me.btnwindowSize = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Me.KryptonHeader1 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
    Me.pnlBotones = New System.Windows.Forms.Panel
    Me.HeaderOptionalButton = New ComponentFactory.Krypton.Toolkit.KryptonHeader
    Me.OptionButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton
    Me.OptionButton2 = New ComponentFactory.Krypton.Toolkit.KryptonButton
    Me.OptionButton3 = New ComponentFactory.Krypton.Toolkit.KryptonButton
    Me.OptionButton4 = New ComponentFactory.Krypton.Toolkit.KryptonButton
    Me.OptionButton5 = New ComponentFactory.Krypton.Toolkit.KryptonButton
    Me.PopupMenu.SuspendLayout()
    Me.pnlBotones.SuspendLayout()
    Me.SuspendLayout()
    '
    'Lista
    '
    Me.Lista.ImageStream = CType(resources.GetObject("Lista.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.Lista.TransparentColor = System.Drawing.Color.Transparent
    Me.Lista.Images.SetKeyName(0, "descarga (4).jpg")
    Me.Lista.Images.SetKeyName(1, "imagen(20).jpg")
    '
    'NodeMenu
    '
    Me.NodeMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.NodeMenu.ContextMenuStrip = Me.PopupMenu
    Me.NodeMenu.Cursor = System.Windows.Forms.Cursors.Hand
    Me.NodeMenu.Dock = System.Windows.Forms.DockStyle.Fill
    Me.NodeMenu.Font = New System.Drawing.Font("Tahoma", 8.0!)
    Me.NodeMenu.ImageIndex = 1
    Me.NodeMenu.ImageList = Me.Lista
    Me.NodeMenu.Location = New System.Drawing.Point(0, 26)
    Me.NodeMenu.Name = "NodeMenu"
    Me.NodeMenu.SelectedImageIndex = 0
    Me.NodeMenu.Size = New System.Drawing.Size(252, 510)
    Me.NodeMenu.TabIndex = 5
    '
    'PopupMenu
    '
    Me.PopupMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
    Me.PopupMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarComoFavoritoToolStripMenuItem, Me.ToolStripMenuItem1, Me.EliminarComoFavoritoToolStripMenuItem, Me.ToolStripMenuItem2})
    Me.PopupMenu.Name = "PopupMenu"
    Me.PopupMenu.Size = New System.Drawing.Size(185, 60)
    '
    'AgregarComoFavoritoToolStripMenuItem
    '
    Me.AgregarComoFavoritoToolStripMenuItem.Image = Global.SOLMIN.MENUBAR.My.Resources.Resources.edit_add
    Me.AgregarComoFavoritoToolStripMenuItem.Name = "AgregarComoFavoritoToolStripMenuItem"
    Me.AgregarComoFavoritoToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
    Me.AgregarComoFavoritoToolStripMenuItem.Text = "Agregar como Favorito"
    '
    'ToolStripMenuItem1
    '
    Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
    Me.ToolStripMenuItem1.Size = New System.Drawing.Size(181, 6)
    '
    'EliminarComoFavoritoToolStripMenuItem
    '
    Me.EliminarComoFavoritoToolStripMenuItem.Image = Global.SOLMIN.MENUBAR.My.Resources.Resources.button_cancel
    Me.EliminarComoFavoritoToolStripMenuItem.Name = "EliminarComoFavoritoToolStripMenuItem"
    Me.EliminarComoFavoritoToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
    Me.EliminarComoFavoritoToolStripMenuItem.Text = "Eliminar como Favorito"
    '
    'ToolStripMenuItem2
    '
    Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
    Me.ToolStripMenuItem2.Size = New System.Drawing.Size(181, 6)
    '
    'HGSolminBar
    '
    Me.HGSolminBar.AutoSize = False
    Me.HGSolminBar.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnwindowSize})
    Me.HGSolminBar.Dock = System.Windows.Forms.DockStyle.Top
    Me.HGSolminBar.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.HGSolminBar.Location = New System.Drawing.Point(0, 0)
    Me.HGSolminBar.Name = "HGSolminBar"
    Me.HGSolminBar.Size = New System.Drawing.Size(270, 26)
    Me.HGSolminBar.TabIndex = 6
    Me.HGSolminBar.Text = "Solmin"
    Me.HGSolminBar.Values.Description = ""
    Me.HGSolminBar.Values.Heading = "Solmin"
    Me.HGSolminBar.Values.Image = Nothing
    '
    'btnwindowSize
    '
    Me.btnwindowSize.ExtraText = ""
    Me.btnwindowSize.Image = Nothing
    Me.btnwindowSize.Text = ""
    Me.btnwindowSize.ToolTipImage = Nothing
    Me.btnwindowSize.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowLeft
    Me.btnwindowSize.UniqueName = "F16D7EA46A94469FF16D7EA46A94469F"
    '
    'KryptonHeader1
    '
    Me.KryptonHeader1.Dock = System.Windows.Forms.DockStyle.Right
    Me.KryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.KryptonHeader1.Location = New System.Drawing.Point(252, 26)
    Me.KryptonHeader1.Name = "KryptonHeader1"
    Me.KryptonHeader1.Orientation = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
    Me.KryptonHeader1.Size = New System.Drawing.Size(18, 653)
    Me.KryptonHeader1.TabIndex = 8
    Me.KryptonHeader1.Text = "Menú de Opciones"
    Me.KryptonHeader1.Values.Description = ""
    Me.KryptonHeader1.Values.Heading = "Menú de Opciones"
    Me.KryptonHeader1.Values.Image = Nothing
    '
    'pnlBotones
    '
    Me.pnlBotones.AutoSize = True
    Me.pnlBotones.Controls.Add(Me.HeaderOptionalButton)
    Me.pnlBotones.Controls.Add(Me.OptionButton1)
    Me.pnlBotones.Controls.Add(Me.OptionButton2)
    Me.pnlBotones.Controls.Add(Me.OptionButton3)
    Me.pnlBotones.Controls.Add(Me.OptionButton4)
    Me.pnlBotones.Controls.Add(Me.OptionButton5)
    Me.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.pnlBotones.Location = New System.Drawing.Point(0, 536)
    Me.pnlBotones.Name = "pnlBotones"
    Me.pnlBotones.Size = New System.Drawing.Size(252, 143)
    Me.pnlBotones.TabIndex = 9
    Me.pnlBotones.Visible = False
    '
    'HeaderOptionalButton
    '
    Me.HeaderOptionalButton.Dock = System.Windows.Forms.DockStyle.Top
    Me.HeaderOptionalButton.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.HeaderOptionalButton.Location = New System.Drawing.Point(0, 0)
    Me.HeaderOptionalButton.Name = "HeaderOptionalButton"
    Me.HeaderOptionalButton.Size = New System.Drawing.Size(252, 18)
    Me.HeaderOptionalButton.TabIndex = 5
    Me.HeaderOptionalButton.Text = "Mis Accesos Directos"
    Me.HeaderOptionalButton.Values.Description = ""
    Me.HeaderOptionalButton.Values.Heading = "Mis Accesos Directos"
    Me.HeaderOptionalButton.Values.Image = Nothing
    '
    'OptionButton1
    '
    Me.OptionButton1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.OptionButton1.Location = New System.Drawing.Point(0, 20)
    Me.OptionButton1.Name = "OptionButton1"
    Me.OptionButton1.Size = New System.Drawing.Size(252, 24)
    Me.OptionButton1.TabIndex = 1
    Me.OptionButton1.Text = "Option button 1"
    Me.OptionButton1.Values.ExtraText = ""
    Me.OptionButton1.Values.Image = Nothing
    Me.OptionButton1.Values.ImageStates.ImageCheckedNormal = Nothing
    Me.OptionButton1.Values.ImageStates.ImageCheckedPressed = Nothing
    Me.OptionButton1.Values.ImageStates.ImageCheckedTracking = Nothing
    Me.OptionButton1.Values.Text = "Option button 1"
    '
    'OptionButton2
    '
    Me.OptionButton2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.OptionButton2.Location = New System.Drawing.Point(0, 44)
    Me.OptionButton2.Name = "OptionButton2"
    Me.OptionButton2.Size = New System.Drawing.Size(252, 24)
    Me.OptionButton2.TabIndex = 2
    Me.OptionButton2.Text = "Option Button 2"
    Me.OptionButton2.Values.ExtraText = ""
    Me.OptionButton2.Values.Image = Nothing
    Me.OptionButton2.Values.ImageStates.ImageCheckedNormal = Nothing
    Me.OptionButton2.Values.ImageStates.ImageCheckedPressed = Nothing
    Me.OptionButton2.Values.ImageStates.ImageCheckedTracking = Nothing
    Me.OptionButton2.Values.Text = "Option Button 2"
    '
    'OptionButton3
    '
    Me.OptionButton3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.OptionButton3.Location = New System.Drawing.Point(0, 68)
    Me.OptionButton3.Name = "OptionButton3"
    Me.OptionButton3.Size = New System.Drawing.Size(252, 24)
    Me.OptionButton3.TabIndex = 3
    Me.OptionButton3.Text = "Option Button 3"
    Me.OptionButton3.Values.ExtraText = ""
    Me.OptionButton3.Values.Image = Nothing
    Me.OptionButton3.Values.ImageStates.ImageCheckedNormal = Nothing
    Me.OptionButton3.Values.ImageStates.ImageCheckedPressed = Nothing
    Me.OptionButton3.Values.ImageStates.ImageCheckedTracking = Nothing
    Me.OptionButton3.Values.Text = "Option Button 3"
    '
    'OptionButton4
    '
    Me.OptionButton4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.OptionButton4.Location = New System.Drawing.Point(0, 92)
    Me.OptionButton4.Name = "OptionButton4"
    Me.OptionButton4.Size = New System.Drawing.Size(252, 24)
    Me.OptionButton4.TabIndex = 4
    Me.OptionButton4.Text = "Option Button 4"
    Me.OptionButton4.Values.ExtraText = ""
    Me.OptionButton4.Values.Image = Nothing
    Me.OptionButton4.Values.ImageStates.ImageCheckedNormal = Nothing
    Me.OptionButton4.Values.ImageStates.ImageCheckedPressed = Nothing
    Me.OptionButton4.Values.ImageStates.ImageCheckedTracking = Nothing
    Me.OptionButton4.Values.Text = "Option Button 4"
    '
    'OptionButton5
    '
    Me.OptionButton5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.OptionButton5.Location = New System.Drawing.Point(0, 116)
    Me.OptionButton5.Name = "OptionButton5"
    Me.OptionButton5.Size = New System.Drawing.Size(252, 24)
    Me.OptionButton5.TabIndex = 5
    Me.OptionButton5.Text = "Option Button5"
    Me.OptionButton5.Values.ExtraText = ""
    Me.OptionButton5.Values.Image = Nothing
    Me.OptionButton5.Values.ImageStates.ImageCheckedNormal = Nothing
    Me.OptionButton5.Values.ImageStates.ImageCheckedPressed = Nothing
    Me.OptionButton5.Values.ImageStates.ImageCheckedTracking = Nothing
    Me.OptionButton5.Values.Text = "Option Button5"
    '
    'MenuSolmin
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.NodeMenu)
    Me.Controls.Add(Me.pnlBotones)
    Me.Controls.Add(Me.KryptonHeader1)
    Me.Controls.Add(Me.HGSolminBar)
    Me.Name = "MenuSolmin"
    Me.Size = New System.Drawing.Size(270, 679)
    Me.PopupMenu.ResumeLayout(False)
    Me.pnlBotones.ResumeLayout(False)
    Me.pnlBotones.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
    Friend WithEvents Lista As System.Windows.Forms.ImageList
    Public WithEvents NodeMenu As System.Windows.Forms.TreeView
    Friend WithEvents HGSolminBar As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents PopupMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AgregarComoFavoritoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EliminarComoFavoritoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnwindowSize As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents KryptonHeader1 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents pnlBotones As System.Windows.Forms.Panel
    Friend WithEvents HeaderOptionalButton As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Public WithEvents OptionButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Public WithEvents OptionButton2 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Public WithEvents OptionButton3 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Public WithEvents OptionButton4 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Public WithEvents OptionButton5 As ComponentFactory.Krypton.Toolkit.KryptonButton

End Class
