<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManPaisxZona
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
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.cmbPais = New System.Windows.Forms.ComboBox
        Me.cmbPuertoOrg = New System.Windows.Forms.ComboBox
        Me.lblPuertoOrg = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtZona = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonGroup1)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(443, 136)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonGroup1.Location = New System.Drawing.Point(0, 25)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.cmbPais)
        Me.KryptonGroup1.Panel.Controls.Add(Me.cmbPuertoOrg)
        Me.KryptonGroup1.Panel.Controls.Add(Me.lblPuertoOrg)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtZona)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonGroup1.Size = New System.Drawing.Size(443, 111)
        Me.KryptonGroup1.TabIndex = 11
        '
        'cmbPais
        '
        Me.cmbPais.BackColor = System.Drawing.Color.White
        Me.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPais.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPais.ForeColor = System.Drawing.SystemColors.Highlight
        Me.cmbPais.FormattingEnabled = True
        Me.cmbPais.Location = New System.Drawing.Point(76, 41)
        Me.cmbPais.Name = "cmbPais"
        Me.cmbPais.Size = New System.Drawing.Size(326, 19)
        Me.cmbPais.TabIndex = 72
        '
        'cmbPuertoOrg
        '
        Me.cmbPuertoOrg.BackColor = System.Drawing.Color.White
        Me.cmbPuertoOrg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPuertoOrg.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPuertoOrg.ForeColor = System.Drawing.SystemColors.Highlight
        Me.cmbPuertoOrg.FormattingEnabled = True
        Me.cmbPuertoOrg.Location = New System.Drawing.Point(76, 67)
        Me.cmbPuertoOrg.Name = "cmbPuertoOrg"
        Me.cmbPuertoOrg.Size = New System.Drawing.Size(326, 19)
        Me.cmbPuertoOrg.TabIndex = 71
        '
        'lblPuertoOrg
        '
        Me.lblPuertoOrg.Location = New System.Drawing.Point(23, 66)
        Me.lblPuertoOrg.Name = "lblPuertoOrg"
        Me.lblPuertoOrg.Size = New System.Drawing.Size(49, 19)
        Me.lblPuertoOrg.TabIndex = 70
        Me.lblPuertoOrg.Text = "Puerto :"
        Me.lblPuertoOrg.Values.ExtraText = ""
        Me.lblPuertoOrg.Values.Image = Nothing
        Me.lblPuertoOrg.Values.Text = "Puerto :"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(23, 41)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(32, 19)
        Me.KryptonLabel3.TabIndex = 21
        Me.KryptonLabel3.Text = "País:"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "País:"
        '
        'txtZona
        '
        Me.txtZona.Enabled = False
        Me.txtZona.Location = New System.Drawing.Point(76, 16)
        Me.txtZona.Name = "txtZona"
        Me.txtZona.ReadOnly = True
        Me.txtZona.Size = New System.Drawing.Size(326, 21)
        Me.txtZona.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtZona.TabIndex = 19
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(23, 18)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(38, 19)
        Me.KryptonLabel1.TabIndex = 16
        Me.KryptonLabel1.Text = "Zona:"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Zona:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.btnAceptar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(443, 25)
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_SC.My.Resources.Resources._exit
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(49, 22)
        Me.btnCancelar.Text = "Salir"
        '
        'btnAceptar
        '
        Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAceptar.Image = Global.SOLMIN_SC.My.Resources.Resources.button_ok
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(66, 22)
        Me.btnAceptar.Text = "Aceptar"
        '
        'frmManPaisxZona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 136)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(451, 170)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(451, 170)
        Me.Name = "frmManPaisxZona"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Asignar País - Puerto"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        Me.KryptonGroup1.Panel.PerformLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
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
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtZona As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbPuertoOrg As System.Windows.Forms.ComboBox
    Friend WithEvents lblPuertoOrg As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbPais As System.Windows.Forms.ComboBox
End Class
