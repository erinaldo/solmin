<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLeyenda
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
    Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.HeaderSolicitud = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.btnSalir = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
    Me.PictureBox4 = New System.Windows.Forms.PictureBox
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.PictureBox3 = New System.Windows.Forms.PictureBox
    Me.PictureBox2 = New System.Windows.Forms.PictureBox
    Me.PictureBox1 = New System.Windows.Forms.PictureBox
    Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    CType(Me.HeaderSolicitud, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.HeaderSolicitud.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.HeaderSolicitud.Panel.SuspendLayout()
    Me.HeaderSolicitud.SuspendLayout()
    CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonGroup1.Panel.SuspendLayout()
    Me.KryptonGroup1.SuspendLayout()
    CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.HeaderSolicitud)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(320, 241)
    Me.KryptonPanel.TabIndex = 0
    '
    'HeaderSolicitud
    '
    Me.HeaderSolicitud.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnSalir})
    Me.HeaderSolicitud.CollapseTarget = ComponentFactory.Krypton.Toolkit.HeaderGroupCollapsedTarget.CollapsedToBoth
    Me.HeaderSolicitud.Dock = System.Windows.Forms.DockStyle.Fill
    Me.HeaderSolicitud.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.HeaderSolicitud.HeaderVisibleSecondary = False
    Me.HeaderSolicitud.Location = New System.Drawing.Point(0, 0)
    Me.HeaderSolicitud.Name = "HeaderSolicitud"
    '
    'HeaderSolicitud.Panel
    '
    Me.HeaderSolicitud.Panel.Controls.Add(Me.KryptonGroup1)
    Me.HeaderSolicitud.Size = New System.Drawing.Size(320, 241)
    Me.HeaderSolicitud.StateCommon.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Form
    Me.HeaderSolicitud.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Rounded
    Me.HeaderSolicitud.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[True]
    Me.HeaderSolicitud.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
    Me.HeaderSolicitud.TabIndex = 107
    Me.HeaderSolicitud.ValuesPrimary.Description = ""
    Me.HeaderSolicitud.ValuesPrimary.Heading = ""
    Me.HeaderSolicitud.ValuesPrimary.Image = Nothing
    Me.HeaderSolicitud.ValuesSecondary.Description = ""
    Me.HeaderSolicitud.ValuesSecondary.Heading = ""
    Me.HeaderSolicitud.ValuesSecondary.Image = Nothing
    '
    'btnSalir
    '
    Me.btnSalir.ExtraText = ""
    Me.btnSalir.Image = Global.SOLMIN_ST.My.Resources.Resources._exit
    Me.btnSalir.Text = "Salir"
    Me.btnSalir.ToolTipBody = "Salir"
    Me.btnSalir.ToolTipImage = Nothing
    Me.btnSalir.UniqueName = "27D941CF936C4FCB27D941CF936C4FCB"
    '
    'KryptonGroup1
    '
    Me.KryptonGroup1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonGroup1.Location = New System.Drawing.Point(0, 0)
    Me.KryptonGroup1.Name = "KryptonGroup1"
    '
    'KryptonGroup1.Panel
    '
    Me.KryptonGroup1.Panel.Controls.Add(Me.PictureBox4)
    Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel2)
    Me.KryptonGroup1.Panel.Controls.Add(Me.PictureBox3)
    Me.KryptonGroup1.Panel.Controls.Add(Me.PictureBox2)
    Me.KryptonGroup1.Panel.Controls.Add(Me.PictureBox1)
    Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel3)
    Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel1)
    Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel5)
    Me.KryptonGroup1.Size = New System.Drawing.Size(318, 213)
    Me.KryptonGroup1.TabIndex = 9
    '
    'PictureBox4
    '
    Me.PictureBox4.Image = Global.SOLMIN_ST.My.Resources.Resources.Leyenda4
    Me.PictureBox4.Location = New System.Drawing.Point(26, 125)
    Me.PictureBox4.Name = "PictureBox4"
    Me.PictureBox4.Size = New System.Drawing.Size(25, 25)
    Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    Me.PictureBox4.TabIndex = 109
    Me.PictureBox4.TabStop = False
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(57, 131)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(113, 19)
    Me.KryptonLabel2.TabIndex = 108
    Me.KryptonLabel2.TabStop = False
    Me.KryptonLabel2.Text = "Vehículos Asignados"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "Vehículos Asignados"
    '
    'PictureBox3
    '
    Me.PictureBox3.Image = Global.SOLMIN_ST.My.Resources.Resources.Leyenda03
    Me.PictureBox3.Location = New System.Drawing.Point(26, 92)
    Me.PictureBox3.Name = "PictureBox3"
    Me.PictureBox3.Size = New System.Drawing.Size(25, 25)
    Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    Me.PictureBox3.TabIndex = 107
    Me.PictureBox3.TabStop = False
    '
    'PictureBox2
    '
    Me.PictureBox2.Image = Global.SOLMIN_ST.My.Resources.Resources.Leyenda021
    Me.PictureBox2.Location = New System.Drawing.Point(26, 59)
    Me.PictureBox2.Name = "PictureBox2"
    Me.PictureBox2.Size = New System.Drawing.Size(24, 25)
    Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    Me.PictureBox2.TabIndex = 106
    Me.PictureBox2.TabStop = False
    '
    'PictureBox1
    '
    Me.PictureBox1.Image = Global.SOLMIN_ST.My.Resources.Resources.Leyeda05
    Me.PictureBox1.Location = New System.Drawing.Point(26, 26)
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
    Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    Me.PictureBox1.TabIndex = 105
    Me.PictureBox1.TabStop = False
    '
    'KryptonLabel3
    '
    Me.KryptonLabel3.Location = New System.Drawing.Point(56, 98)
    Me.KryptonLabel3.Name = "KryptonLabel3"
    Me.KryptonLabel3.Size = New System.Drawing.Size(243, 19)
    Me.KryptonLabel3.TabIndex = 104
    Me.KryptonLabel3.TabStop = False
    Me.KryptonLabel3.Text = "Unidad Solictada  mayor que Unidad Asignada"
    Me.KryptonLabel3.Values.ExtraText = ""
    Me.KryptonLabel3.Values.Image = Nothing
    Me.KryptonLabel3.Values.Text = "Unidad Solictada  mayor que Unidad Asignada"
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(56, 65)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(235, 19)
    Me.KryptonLabel1.TabIndex = 102
    Me.KryptonLabel1.TabStop = False
    Me.KryptonLabel1.Target = Me
    Me.KryptonLabel1.Text = "Unidad Solicitada igual que Unidad Asignada"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Unidad Solicitada igual que Unidad Asignada"
    '
    'KryptonLabel5
    '
    Me.KryptonLabel5.Location = New System.Drawing.Point(56, 32)
    Me.KryptonLabel5.Name = "KryptonLabel5"
    Me.KryptonLabel5.Size = New System.Drawing.Size(244, 19)
    Me.KryptonLabel5.TabIndex = 101
    Me.KryptonLabel5.TabStop = False
    Me.KryptonLabel5.Text = "Unidad Solicitada menor que Unidad Asignada"
    Me.KryptonLabel5.Values.ExtraText = ""
    Me.KryptonLabel5.Values.Image = Nothing
    Me.KryptonLabel5.Values.Text = "Unidad Solicitada menor que Unidad Asignada"
    '
    'frmLeyenda
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(320, 241)
    Me.ControlBox = False
    Me.Controls.Add(Me.KryptonPanel)
    Me.Cursor = System.Windows.Forms.Cursors.Default
    Me.Name = "frmLeyenda"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Leyenda"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    CType(Me.HeaderSolicitud.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderSolicitud.Panel.ResumeLayout(False)
    CType(Me.HeaderSolicitud, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderSolicitud.ResumeLayout(False)
    CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonGroup1.Panel.ResumeLayout(False)
    Me.KryptonGroup1.Panel.PerformLayout()
    CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonGroup1.ResumeLayout(False)
    CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents HeaderSolicitud As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
