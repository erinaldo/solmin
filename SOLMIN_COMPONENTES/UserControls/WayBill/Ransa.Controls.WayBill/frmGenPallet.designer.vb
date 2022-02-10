<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenPallet
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGenPallet))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonGroup()
        Me.chkAuto = New System.Windows.Forms.CheckBox()
        Me.txtNroPallet = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblPallet = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip()
        Me.tsbCerrar = New System.Windows.Forms.ToolStripButton()
        Me.btnGenPallet = New System.Windows.Forms.ToolStripButton()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup2.Panel.SuspendLayout()
        Me.KryptonGroup2.SuspendLayout()
        Me.tsMenuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonGroup2)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(468, 130)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonGroup2
        '
        Me.KryptonGroup2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonGroup2.Location = New System.Drawing.Point(0, 27)
        Me.KryptonGroup2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonGroup2.Name = "KryptonGroup2"
        '
        'KryptonGroup2.Panel
        '
        Me.KryptonGroup2.Panel.Controls.Add(Me.chkAuto)
        Me.KryptonGroup2.Panel.Controls.Add(Me.txtNroPallet)
        Me.KryptonGroup2.Panel.Controls.Add(Me.lblPallet)
        Me.KryptonGroup2.Size = New System.Drawing.Size(468, 103)
        Me.KryptonGroup2.TabIndex = 110
        '
        'chkAuto
        '
        Me.chkAuto.AutoSize = True
        Me.chkAuto.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkAuto.Location = New System.Drawing.Point(18, 15)
        Me.chkAuto.Name = "chkAuto"
        Me.chkAuto.Size = New System.Drawing.Size(178, 21)
        Me.chkAuto.TabIndex = 13
        Me.chkAuto.Text = "Generación Automática"
        Me.chkAuto.UseVisualStyleBackColor = False
        '
        'txtNroPallet
        '
        Me.txtNroPallet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroPallet.Location = New System.Drawing.Point(114, 45)
        Me.txtNroPallet.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroPallet.MaxLength = 10
        Me.txtNroPallet.Name = "txtNroPallet"
        Me.txtNroPallet.Size = New System.Drawing.Size(208, 26)
        Me.txtNroPallet.StateActive.Back.Color1 = System.Drawing.Color.White
        Me.txtNroPallet.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtNroPallet.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.txtNroPallet.StateDisabled.Border.Color1 = System.Drawing.Color.CornflowerBlue
        Me.txtNroPallet.StateDisabled.Border.Color2 = System.Drawing.Color.CornflowerBlue
        Me.txtNroPallet.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtNroPallet.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroPallet.TabIndex = 0
        '
        'lblPallet
        '
        Me.lblPallet.Location = New System.Drawing.Point(12, 46)
        Me.lblPallet.Margin = New System.Windows.Forms.Padding(4)
        Me.lblPallet.Name = "lblPallet"
        Me.lblPallet.Size = New System.Drawing.Size(82, 24)
        Me.lblPallet.TabIndex = 12
        Me.lblPallet.Text = "Nro Pallet:"
        Me.lblPallet.Values.ExtraText = ""
        Me.lblPallet.Values.Image = Nothing
        Me.lblPallet.Values.Text = "Nro Pallet:"
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbCerrar, Me.btnGenPallet})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(468, 27)
        Me.tsMenuOpciones.TabIndex = 109
        '
        'tsbCerrar
        '
        Me.tsbCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbCerrar.Image = CType(resources.GetObject("tsbCerrar.Image"), System.Drawing.Image)
        Me.tsbCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCerrar.Name = "tsbCerrar"
        Me.tsbCerrar.Size = New System.Drawing.Size(73, 24)
        Me.tsbCerrar.Text = "Cerrar"
        '
        'btnGenPallet
        '
        Me.btnGenPallet.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGenPallet.Image = Global.Ransa.Controls.WayBill.My.Resources.Resources.button_ok
        Me.btnGenPallet.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGenPallet.Name = "btnGenPallet"
        Me.btnGenPallet.Size = New System.Drawing.Size(125, 24)
        Me.btnGenPallet.Text = "Generar Pallet"
        '
        'frmGenPallet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 130)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGenPallet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pallet"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup2.Panel.ResumeLayout(False)
        Me.KryptonGroup2.Panel.PerformLayout()
        CType(Me.KryptonGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup2.ResumeLayout(False)
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager


    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonGroup2 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents txtNroPallet As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblPallet As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents chkAuto As System.Windows.Forms.CheckBox
    Friend WithEvents btnGenPallet As System.Windows.Forms.ToolStripButton
End Class
