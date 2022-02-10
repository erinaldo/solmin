<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrowser
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
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.PanelVisor = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnSalir = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.txtLongitud = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtLatitud = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.HeaderBrowser = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.PanelVisor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelVisor.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelVisor.Panel.SuspendLayout()
        Me.PanelVisor.SuspendLayout()
        CType(Me.HeaderBrowser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderBrowser.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderBrowser.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.PanelVisor)
        Me.KryptonPanel1.Controls.Add(Me.HeaderBrowser)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderSecondary
        Me.KryptonPanel1.Size = New System.Drawing.Size(453, 406)
        Me.KryptonPanel1.TabIndex = 1
        '
        'PanelVisor
        '
        Me.PanelVisor.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnSalir})
        Me.PanelVisor.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelVisor.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.PanelVisor.HeaderStyleSecondary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Primary
        Me.PanelVisor.HeaderVisiblePrimary = False
        Me.PanelVisor.Location = New System.Drawing.Point(0, 0)
        Me.PanelVisor.Name = "PanelVisor"
        '
        'PanelVisor.Panel
        '
        Me.PanelVisor.Panel.Controls.Add(Me.txtLongitud)
        Me.PanelVisor.Panel.Controls.Add(Me.txtLatitud)
        Me.PanelVisor.Panel.Controls.Add(Me.KryptonLabel2)
        Me.PanelVisor.Panel.Controls.Add(Me.KryptonLabel1)
        Me.PanelVisor.Size = New System.Drawing.Size(453, 56)
        Me.PanelVisor.TabIndex = 7
        Me.PanelVisor.ValuesPrimary.Description = ""
        Me.PanelVisor.ValuesPrimary.Heading = ""
        Me.PanelVisor.ValuesPrimary.Image = Nothing
        Me.PanelVisor.ValuesSecondary.Description = ""
        Me.PanelVisor.ValuesSecondary.Heading = ""
        Me.PanelVisor.ValuesSecondary.Image = Nothing
        '
        'btnSalir
        '
        Me.btnSalir.ExtraText = ""
        Me.btnSalir.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnSalir.Image = Global.SOLMIN_ST.My.Resources.Resources._exit
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.ToolTipImage = Nothing
        Me.btnSalir.UniqueName = "1F9FEB7587F44F721F9FEB7587F44F72"
        '
        'txtLongitud
        '
        Me.txtLongitud.Location = New System.Drawing.Point(296, 6)
        Me.txtLongitud.MaxLength = 100
        Me.txtLongitud.Name = "txtLongitud"
        Me.txtLongitud.ReadOnly = True
        Me.txtLongitud.Size = New System.Drawing.Size(128, 19)
        Me.txtLongitud.TabIndex = 3
        '
        'txtLatitud
        '
        Me.txtLatitud.Location = New System.Drawing.Point(75, 6)
        Me.txtLatitud.MaxLength = 100
        Me.txtLatitud.Name = "txtLatitud"
        Me.txtLatitud.ReadOnly = True
        Me.txtLatitud.Size = New System.Drawing.Size(128, 19)
        Me.txtLatitud.TabIndex = 2
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(241, 6)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(54, 16)
        Me.KryptonLabel2.TabIndex = 1
        Me.KryptonLabel2.Text = "Longitud"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Longitud"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(28, 6)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(44, 16)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Text = "Latitud"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Latitud"
        '
        'HeaderBrowser
        '
        Me.HeaderBrowser.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.HeaderBrowser.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Left
        Me.HeaderBrowser.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HeaderBrowser.HeaderVisibleSecondary = False
        Me.HeaderBrowser.Location = New System.Drawing.Point(0, 56)
        Me.HeaderBrowser.Name = "HeaderBrowser"
        '
        'HeaderBrowser.Panel
        '
        Me.HeaderBrowser.Size = New System.Drawing.Size(453, 350)
        Me.HeaderBrowser.TabIndex = 6
        Me.HeaderBrowser.Text = "Localizacion Global"
        Me.HeaderBrowser.ValuesPrimary.Description = ""
        Me.HeaderBrowser.ValuesPrimary.Heading = "Localizacion Global"
        Me.HeaderBrowser.ValuesPrimary.Image = Nothing
        Me.HeaderBrowser.ValuesSecondary.Description = ""
        Me.HeaderBrowser.ValuesSecondary.Heading = "Description"
        Me.HeaderBrowser.ValuesSecondary.Image = Nothing
        '
        'frmBrowser
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(453, 406)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Primary
        Me.Name = "frmBrowser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ubicación del Vahículo"
        Me.TextExtra = ""
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        CType(Me.PanelVisor.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelVisor.Panel.ResumeLayout(False)
        Me.PanelVisor.Panel.PerformLayout()
        CType(Me.PanelVisor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelVisor.ResumeLayout(False)
        CType(Me.HeaderBrowser.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaderBrowser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderBrowser.ResumeLayout(False)
        Me.ResumeLayout(False)

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
  Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
  Friend WithEvents HeaderBrowser As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents PanelVisor As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents txtLongitud As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents txtLatitud As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
