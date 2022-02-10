<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActLiGastos
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
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonTextBox3 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel16 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.FecideCheckBox = New System.Windows.Forms.CheckBox
        Me.FecideDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel15 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.NLiquidacionKryptonTextBox = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel17 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnGrabar = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(373, 149)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.KryptonTextBox3)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel16)
        Me.KryptonPanel1.Controls.Add(Me.FecideCheckBox)
        Me.KryptonPanel1.Controls.Add(Me.FecideDateTimePicker)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel15)
        Me.KryptonPanel1.Controls.Add(Me.NLiquidacionKryptonTextBox)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel17)
        Me.KryptonPanel1.Controls.Add(Me.ToolStrip2)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(373, 149)
        Me.KryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel1.TabIndex = 0
        '
        'KryptonTextBox3
        '
        Me.KryptonTextBox3.Enabled = False
        Me.KryptonTextBox3.Location = New System.Drawing.Point(123, 76)
        Me.KryptonTextBox3.Name = "KryptonTextBox3"
        Me.KryptonTextBox3.Size = New System.Drawing.Size(221, 19)
        Me.KryptonTextBox3.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonTextBox3.TabIndex = 32
        '
        'KryptonLabel16
        '
        Me.KryptonLabel16.Location = New System.Drawing.Point(13, 73)
        Me.KryptonLabel16.Name = "KryptonLabel16"
        Me.KryptonLabel16.Size = New System.Drawing.Size(68, 20)
        Me.KryptonLabel16.TabIndex = 31
        Me.KryptonLabel16.TabStop = False
        Me.KryptonLabel16.Text = "Conductor"
        Me.KryptonLabel16.Values.ExtraText = ""
        Me.KryptonLabel16.Values.Image = Nothing
        Me.KryptonLabel16.Values.Text = "Conductor"
        '
        'FecideCheckBox
        '
        Me.FecideCheckBox.AutoSize = True
        Me.FecideCheckBox.Location = New System.Drawing.Point(123, 107)
        Me.FecideCheckBox.Name = "FecideCheckBox"
        Me.FecideCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.FecideCheckBox.TabIndex = 30
        Me.FecideCheckBox.UseVisualStyleBackColor = True
        '
        'FecideDateTimePicker
        '
        Me.FecideDateTimePicker.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FecideDateTimePicker.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FecideDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FecideDateTimePicker.Location = New System.Drawing.Point(148, 102)
        Me.FecideDateTimePicker.Name = "FecideDateTimePicker"
        Me.FecideDateTimePicker.Size = New System.Drawing.Size(88, 21)
        Me.FecideDateTimePicker.TabIndex = 29
        '
        'KryptonLabel15
        '
        Me.KryptonLabel15.Location = New System.Drawing.Point(15, 101)
        Me.KryptonLabel15.Name = "KryptonLabel15"
        Me.KryptonLabel15.Size = New System.Drawing.Size(102, 20)
        Me.KryptonLabel15.TabIndex = 28
        Me.KryptonLabel15.TabStop = False
        Me.KryptonLabel15.Text = "Fecha Recepción"
        Me.KryptonLabel15.Values.ExtraText = ""
        Me.KryptonLabel15.Values.Image = Nothing
        Me.KryptonLabel15.Values.Text = "Fecha Recepción"
        '
        'NLiquidacionKryptonTextBox
        '
        Me.NLiquidacionKryptonTextBox.Enabled = False
        Me.NLiquidacionKryptonTextBox.Location = New System.Drawing.Point(123, 47)
        Me.NLiquidacionKryptonTextBox.MaxLength = 15
        Me.NLiquidacionKryptonTextBox.Name = "NLiquidacionKryptonTextBox"
        Me.NLiquidacionKryptonTextBox.ReadOnly = True
        Me.NLiquidacionKryptonTextBox.Size = New System.Drawing.Size(113, 20)
        Me.NLiquidacionKryptonTextBox.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.NLiquidacionKryptonTextBox.TabIndex = 27
        Me.NLiquidacionKryptonTextBox.TabStop = False
        Me.NLiquidacionKryptonTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'KryptonLabel17
        '
        Me.KryptonLabel17.Location = New System.Drawing.Point(12, 45)
        Me.KryptonLabel17.Name = "KryptonLabel17"
        Me.KryptonLabel17.Size = New System.Drawing.Size(105, 20)
        Me.KryptonLabel17.TabIndex = 26
        Me.KryptonLabel17.TabStop = False
        Me.KryptonLabel17.Text = "N° Liquidación G."
        Me.KryptonLabel17.Values.ExtraText = ""
        Me.KryptonLabel17.Values.Image = Nothing
        Me.KryptonLabel17.Values.Text = "N° Liquidación G."
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.ToolStripSeparator1, Me.btnGrabar})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(373, 25)
        Me.ToolStrip2.TabIndex = 24
        Me.ToolStrip2.TabStop = True
        Me.ToolStrip2.Text = "ToolStrip1"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(73, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnGrabar
        '
        Me.btnGrabar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGrabar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(62, 22)
        Me.btnGrabar.Text = "Grabar"
        '
        'frmActLiGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 149)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmActLiGastos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Datos liquidación"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
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
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonTextBox3 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel16 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents FecideCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FecideDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel15 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents NLiquidacionKryptonTextBox As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel17 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
