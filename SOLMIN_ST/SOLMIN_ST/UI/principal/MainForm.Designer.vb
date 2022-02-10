<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.SolminToolBar1 = New SOLMIN.MENUBAR.SolminToolBar
    Me.MenuSolmin1 = New SOLMIN.MENUBAR.MenuSolmin
    Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
    Me.SuspendLayout()
    '
    'SolminToolBar1
    '
    Me.SolminToolBar1.AcercaDe = ""
    Me.SolminToolBar1.DataBind = False
    Me.SolminToolBar1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.SolminToolBar1.Location = New System.Drawing.Point(0, 0)
    Me.SolminToolBar1.Name = "SolminToolBar1"
    Me.SolminToolBar1.Size = New System.Drawing.Size(594, 24)
    Me.SolminToolBar1.TabIndex = 1
    Me.SolminToolBar1.Text = "SolminToolBar1"
    '
    'MenuSolmin1
    '
    Me.MenuSolmin1.DataBind = False
    Me.MenuSolmin1.DescripcionMenu = ""
    Me.MenuSolmin1.Dock = System.Windows.Forms.DockStyle.Left
    Me.MenuSolmin1.Location = New System.Drawing.Point(0, 24)
    Me.MenuSolmin1.MenuVisibleState = False
    Me.MenuSolmin1.Name = "MenuSolmin1"
    Me.MenuSolmin1.Size = New System.Drawing.Size(228, 409)
    Me.MenuSolmin1.TabIndex = 2
    Me.MenuSolmin1.TituloMenu = "Solmin"
    '
    'ImageList1
    '
    Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
    Me.ImageList1.Images.SetKeyName(0, "WinXPSetV4 Icon 20.ico")
    Me.ImageList1.Images.SetKeyName(1, "imagen(20).jpg")
    '
    'MainForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.White
    Me.BackgroundImage = Global.SOLMIN_ST.My.Resources.Resources.FondoPantalla
    Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
    Me.ClientSize = New System.Drawing.Size(594, 433)
    Me.Controls.Add(Me.MenuSolmin1)
    Me.Controls.Add(Me.SolminToolBar1)
    Me.DoubleBuffered = True
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.IsMdiContainer = True
    Me.MainMenuStrip = Me.SolminToolBar1
    Me.Name = "MainForm"
    Me.StateActive.Back.Color1 = System.Drawing.Color.White
    Me.StateActive.Back.Color2 = System.Drawing.Color.White
    Me.StateCommon.Back.Color1 = System.Drawing.Color.White
    Me.StateCommon.Back.Color2 = System.Drawing.Color.White
    Me.StateInactive.Back.Color1 = System.Drawing.Color.White
    Me.StateInactive.Back.Color2 = System.Drawing.Color.White
    Me.Text = "SOLMIN - Módulo de Transporte"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

  Public Sub New()

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub
  Friend WithEvents SolminToolBar1 As SOLMIN.MENUBAR.SolminToolBar
  Friend WithEvents MenuSolmin1 As SOLMIN.MENUBAR.MenuSolmin
  Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class
