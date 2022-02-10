<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcesValorizacion
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
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator1 = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.tss002 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnProcesar = New System.Windows.Forms.ToolStripButton()
        Me.tss003 = New System.Windows.Forms.ToolStripSeparator()
        Me.HGFiltro = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.txtImporteDolares = New System.Windows.Forms.TextBox()
        Me.lblDiasAprob = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblSoles = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtImporteSoles = New System.Windows.Forms.TextBox()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.HGFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HGFiltro.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HGFiltro.Panel.SuspendLayout()
        Me.HGFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.HGFiltro)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.SeparatorLowProfile
        Me.KryptonPanel.Size = New System.Drawing.Size(531, 134)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Division"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Planta"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Operacion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Pre-Factura"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Pre-Liquidacion"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Nro. Consistencia"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Importe S/"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Importe U$"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Estado OP"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.tss002, Me.btnProcesar, Me.tss003})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(531, 27)
        Me.ToolStrip1.TabIndex = 21
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_CT.My.Resources.Resources.anular1
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 24)
        Me.btnCancelar.Text = "Cancelar"
        '
        'tss002
        '
        Me.tss002.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss002.Name = "tss002"
        Me.tss002.Size = New System.Drawing.Size(6, 27)
        '
        'btnProcesar
        '
        Me.btnProcesar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnProcesar.Image = Global.SOLMIN_CT.My.Resources.Resources.effect
        Me.btnProcesar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(89, 24)
        Me.btnProcesar.Text = "Procesar"
        '
        'tss003
        '
        Me.tss003.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss003.Name = "tss003"
        Me.tss003.Size = New System.Drawing.Size(6, 27)
        '
        'HGFiltro
        '
        Me.HGFiltro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HGFiltro.HeaderVisibleSecondary = False
        Me.HGFiltro.Location = New System.Drawing.Point(0, 27)
        Me.HGFiltro.Margin = New System.Windows.Forms.Padding(4)
        Me.HGFiltro.Name = "HGFiltro"
        '
        'HGFiltro.Panel
        '
        Me.HGFiltro.Panel.Controls.Add(Me.txtImporteDolares)
        Me.HGFiltro.Panel.Controls.Add(Me.lblDiasAprob)
        Me.HGFiltro.Panel.Controls.Add(Me.lblSoles)
        Me.HGFiltro.Panel.Controls.Add(Me.txtImporteSoles)
        Me.HGFiltro.Size = New System.Drawing.Size(531, 107)
        Me.HGFiltro.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HGFiltro.TabIndex = 22
        Me.HGFiltro.ValuesPrimary.Description = ""
        Me.HGFiltro.ValuesPrimary.Heading = ""
        Me.HGFiltro.ValuesPrimary.Image = Nothing
        Me.HGFiltro.ValuesSecondary.Description = ""
        Me.HGFiltro.ValuesSecondary.Heading = "Description"
        Me.HGFiltro.ValuesSecondary.Image = Nothing
        '
        'txtImporteDolares
        '
        Me.txtImporteDolares.BackColor = System.Drawing.SystemColors.Window
        Me.txtImporteDolares.Enabled = False
        Me.txtImporteDolares.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtImporteDolares.Location = New System.Drawing.Point(209, 50)
        Me.txtImporteDolares.Margin = New System.Windows.Forms.Padding(4)
        Me.txtImporteDolares.MaxLength = 1000
        Me.txtImporteDolares.Multiline = True
        Me.txtImporteDolares.Name = "txtImporteDolares"
        Me.txtImporteDolares.Size = New System.Drawing.Size(173, 24)
        Me.txtImporteDolares.TabIndex = 18
        '
        'lblDiasAprob
        '
        Me.lblDiasAprob.Location = New System.Drawing.Point(228, 16)
        Me.lblDiasAprob.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDiasAprob.Name = "lblDiasAprob"
        Me.lblDiasAprob.Size = New System.Drawing.Size(170, 26)
        Me.lblDiasAprob.TabIndex = 17
        Me.lblDiasAprob.Text = "Importe Dolares Envio :"
        Me.lblDiasAprob.Values.ExtraText = ""
        Me.lblDiasAprob.Values.Image = Nothing
        Me.lblDiasAprob.Values.Text = "Importe Dolares Envio :"
        '
        'lblSoles
        '
        Me.lblSoles.Location = New System.Drawing.Point(12, 16)
        Me.lblSoles.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSoles.Name = "lblSoles"
        Me.lblSoles.Size = New System.Drawing.Size(154, 26)
        Me.lblSoles.TabIndex = 14
        Me.lblSoles.Text = "Importe Soles Envio :"
        Me.lblSoles.Values.ExtraText = ""
        Me.lblSoles.Values.Image = Nothing
        Me.lblSoles.Values.Text = "Importe Soles Envio :"
        '
        'txtImporteSoles
        '
        Me.txtImporteSoles.BackColor = System.Drawing.SystemColors.Window
        Me.txtImporteSoles.Enabled = False
        Me.txtImporteSoles.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtImporteSoles.Location = New System.Drawing.Point(12, 50)
        Me.txtImporteSoles.Margin = New System.Windows.Forms.Padding(4)
        Me.txtImporteSoles.MaxLength = 1000
        Me.txtImporteSoles.Multiline = True
        Me.txtImporteSoles.Name = "txtImporteSoles"
        Me.txtImporteSoles.Size = New System.Drawing.Size(177, 24)
        Me.txtImporteSoles.TabIndex = 13
        '
        'frmProcesValorizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 134)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmProcesValorizacion"
        Me.Text = "Procesar Valorización"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.HGFiltro.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGFiltro.Panel.ResumeLayout(False)
        Me.HGFiltro.Panel.PerformLayout()
        CType(Me.HGFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGFiltro.ResumeLayout(False)
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
    Friend WithEvents TypeValidator1 As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents cboDivision As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HGFiltro As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents txtImporteDolares As System.Windows.Forms.TextBox
    Friend WithEvents lblDiasAprob As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblSoles As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtImporteSoles As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss002 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnProcesar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss003 As System.Windows.Forms.ToolStripSeparator
End Class
