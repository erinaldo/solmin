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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.lblStatusBar = New System.Windows.Forms.ToolStripStatusLabel
        Me.ImgListaGlobal = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AdministracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CotizacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.TarifarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReiniciarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SolminToolBar1 = New SOLMIN.MENUBAR.SolminToolBar
        Me.MenuSolmin1 = New SOLMIN.MENUBAR.MenuSolmin
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatusBar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 363)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(541, 22)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatusBar
        '
        Me.lblStatusBar.Image = Global.SOLMIN_CT.My.Resources.Resources.desktop
        Me.lblStatusBar.Name = "lblStatusBar"
        Me.lblStatusBar.Size = New System.Drawing.Size(31, 17)
        Me.lblStatusBar.Text = "[]"
        '
        'ImgListaGlobal
        '
        Me.ImgListaGlobal.ImageStream = CType(resources.GetObject("ImgListaGlobal.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgListaGlobal.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgListaGlobal.Images.SetKeyName(0, "greenled.png")
        Me.ImgListaGlobal.Images.SetKeyName(1, "redled.png")
        Me.ImgListaGlobal.Images.SetKeyName(2, "")
        Me.ImgListaGlobal.Images.SetKeyName(3, "")
        Me.ImgListaGlobal.Images.SetKeyName(4, "")
        Me.ImgListaGlobal.Images.SetKeyName(5, "")
        Me.ImgListaGlobal.Images.SetKeyName(6, "")
        Me.ImgListaGlobal.Images.SetKeyName(7, "")
        Me.ImgListaGlobal.Images.SetKeyName(8, "")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(22, 22)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministracionToolStripMenuItem, Me.OperacionesToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.SistemaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(541, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'AdministracionToolStripMenuItem
        '
        Me.AdministracionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CotizacionesToolStripMenuItem, Me.ToolStripMenuItem1, Me.TarifarioToolStripMenuItem})
        Me.AdministracionToolStripMenuItem.Name = "AdministracionToolStripMenuItem"
        Me.AdministracionToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.AdministracionToolStripMenuItem.Text = "Administracion"
        '
        'CotizacionesToolStripMenuItem
        '
        Me.CotizacionesToolStripMenuItem.Name = "CotizacionesToolStripMenuItem"
        Me.CotizacionesToolStripMenuItem.Size = New System.Drawing.Size(128, 28)
        Me.CotizacionesToolStripMenuItem.Text = "Contratos"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(125, 6)
        '
        'TarifarioToolStripMenuItem
        '
        Me.TarifarioToolStripMenuItem.Image = Global.SOLMIN_CT.My.Resources.Resources.kexi_kexi
        Me.TarifarioToolStripMenuItem.Name = "TarifarioToolStripMenuItem"
        Me.TarifarioToolStripMenuItem.Size = New System.Drawing.Size(128, 28)
        Me.TarifarioToolStripMenuItem.Text = "Servicios"
        '
        'OperacionesToolStripMenuItem
        '
        Me.OperacionesToolStripMenuItem.Name = "OperacionesToolStripMenuItem"
        Me.OperacionesToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.OperacionesToolStripMenuItem.Text = "Operaciones"
        Me.OperacionesToolStripMenuItem.Visible = False
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesToolStripMenuItem1})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(119, 20)
        Me.ReportesToolStripMenuItem.Text = "Consultas y Reportes"
        Me.ReportesToolStripMenuItem.Visible = False
        '
        'ReportesToolStripMenuItem1
        '
        Me.ReportesToolStripMenuItem1.Image = Global.SOLMIN_CT.My.Resources.Resources.spreadsheet
        Me.ReportesToolStripMenuItem1.Name = "ReportesToolStripMenuItem1"
        Me.ReportesToolStripMenuItem1.Size = New System.Drawing.Size(126, 28)
        Me.ReportesToolStripMenuItem1.Text = "Reportes"
        Me.ReportesToolStripMenuItem1.Visible = False
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReiniciarSesiónToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.SistemaToolStripMenuItem.Text = "Sistema"
        '
        'ReiniciarSesiónToolStripMenuItem
        '
        Me.ReiniciarSesiónToolStripMenuItem.Image = Global.SOLMIN_CT.My.Resources.Resources.agt_reload
        Me.ReiniciarSesiónToolStripMenuItem.Name = "ReiniciarSesiónToolStripMenuItem"
        Me.ReiniciarSesiónToolStripMenuItem.Size = New System.Drawing.Size(159, 28)
        Me.ReiniciarSesiónToolStripMenuItem.Text = "Reiniciar Sesión"
        Me.ReiniciarSesiónToolStripMenuItem.Visible = False
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = Global.SOLMIN_CT.My.Resources.Resources.salir
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(159, 28)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'SolminToolBar1
        '
        Me.SolminToolBar1.AcercaDe = ""
        Me.SolminToolBar1.DataBind = False
        Me.SolminToolBar1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.SolminToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.SolminToolBar1.Name = "SolminToolBar1"
        Me.SolminToolBar1.Size = New System.Drawing.Size(541, 24)
        Me.SolminToolBar1.TabIndex = 19
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
        Me.MenuSolmin1.Size = New System.Drawing.Size(270, 339)
        Me.MenuSolmin1.TabIndex = 20
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
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.SOLMIN_CT.My.Resources.Resources.FondoPantalla1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(541, 385)
        Me.Controls.Add(Me.MenuSolmin1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.SolminToolBar1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.SolminToolBar1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "[]"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatusBar As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ImgListaGlobal As System.Windows.Forms.ImageList
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdministracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CotizacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OperacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SistemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReiniciarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TarifarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SolminToolBar1 As SOLMIN.MENUBAR.SolminToolBar
    Friend WithEvents MenuSolmin1 As SOLMIN.MENUBAR.MenuSolmin
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class
