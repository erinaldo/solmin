<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantServicio
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
        Me.grpMantServicio = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.txtPorcentajeDetraccion = New System.Windows.Forms.TextBox
        Me.txtMontoDetraccion = New System.Windows.Forms.TextBox
        Me.txtCodMaterial = New System.Windows.Forms.TextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCodMaterial = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ucRubroDeVenta = New Ransa.Utilitario.ucAyuda
        Me.txtServicio = New System.Windows.Forms.TextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.lslTituloMantServicios = New System.Windows.Forms.ToolStripLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtMacroServicio = New System.Windows.Forms.TextBox
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.grpMantServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpMantServicio.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMantServicio.Panel.SuspendLayout()
        Me.grpMantServicio.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.grpMantServicio)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(469, 199)
        Me.KryptonPanel.TabIndex = 0
        '
        'grpMantServicio
        '
        Me.grpMantServicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpMantServicio.Location = New System.Drawing.Point(0, 0)
        Me.grpMantServicio.Name = "grpMantServicio"
        '
        'grpMantServicio.Panel
        '
        Me.grpMantServicio.Panel.Controls.Add(Me.txtMacroServicio)
        Me.grpMantServicio.Panel.Controls.Add(Me.KryptonLabel5)
        Me.grpMantServicio.Panel.Controls.Add(Me.txtPorcentajeDetraccion)
        Me.grpMantServicio.Panel.Controls.Add(Me.txtMontoDetraccion)
        Me.grpMantServicio.Panel.Controls.Add(Me.txtCodMaterial)
        Me.grpMantServicio.Panel.Controls.Add(Me.KryptonLabel1)
        Me.grpMantServicio.Panel.Controls.Add(Me.KryptonLabel4)
        Me.grpMantServicio.Panel.Controls.Add(Me.lblCodMaterial)
        Me.grpMantServicio.Panel.Controls.Add(Me.ucRubroDeVenta)
        Me.grpMantServicio.Panel.Controls.Add(Me.txtServicio)
        Me.grpMantServicio.Panel.Controls.Add(Me.KryptonLabel2)
        Me.grpMantServicio.Panel.Controls.Add(Me.KryptonLabel3)
        Me.grpMantServicio.Panel.Controls.Add(Me.ToolStrip3)
        Me.grpMantServicio.Size = New System.Drawing.Size(469, 199)
        Me.grpMantServicio.TabIndex = 31
        '
        'txtPorcentajeDetraccion
        '
        Me.txtPorcentajeDetraccion.BackColor = System.Drawing.Color.White
        Me.txtPorcentajeDetraccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorcentajeDetraccion.Location = New System.Drawing.Point(150, 135)
        Me.txtPorcentajeDetraccion.MaxLength = 250
        Me.txtPorcentajeDetraccion.Multiline = True
        Me.txtPorcentajeDetraccion.Name = "txtPorcentajeDetraccion"
        Me.txtPorcentajeDetraccion.ReadOnly = True
        Me.txtPorcentajeDetraccion.Size = New System.Drawing.Size(117, 20)
        Me.txtPorcentajeDetraccion.TabIndex = 4
        Me.txtPorcentajeDetraccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMontoDetraccion
        '
        Me.txtMontoDetraccion.BackColor = System.Drawing.Color.White
        Me.txtMontoDetraccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoDetraccion.Location = New System.Drawing.Point(150, 111)
        Me.txtMontoDetraccion.MaxLength = 250
        Me.txtMontoDetraccion.Multiline = True
        Me.txtMontoDetraccion.Name = "txtMontoDetraccion"
        Me.txtMontoDetraccion.ReadOnly = True
        Me.txtMontoDetraccion.Size = New System.Drawing.Size(117, 20)
        Me.txtMontoDetraccion.TabIndex = 3
        Me.txtMontoDetraccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCodMaterial
        '
        Me.txtCodMaterial.BackColor = System.Drawing.Color.White
        Me.txtCodMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodMaterial.Location = New System.Drawing.Point(150, 87)
        Me.txtCodMaterial.MaxLength = 250
        Me.txtCodMaterial.Multiline = True
        Me.txtCodMaterial.Name = "txtCodMaterial"
        Me.txtCodMaterial.ReadOnly = True
        Me.txtCodMaterial.Size = New System.Drawing.Size(277, 20)
        Me.txtCodMaterial.TabIndex = 2
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(21, 137)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(135, 20)
        Me.KryptonLabel1.TabIndex = 63
        Me.KryptonLabel1.Text = "Porcentaje detracción :"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Porcentaje detracción :"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(40, 112)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(114, 20)
        Me.KryptonLabel4.TabIndex = 62
        Me.KryptonLabel4.Text = "Monto detracción :"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Monto detracción :"
        '
        'lblCodMaterial
        '
        Me.lblCodMaterial.Location = New System.Drawing.Point(49, 87)
        Me.lblCodMaterial.Name = "lblCodMaterial"
        Me.lblCodMaterial.Size = New System.Drawing.Size(104, 20)
        Me.lblCodMaterial.TabIndex = 61
        Me.lblCodMaterial.Text = "Código material :"
        Me.lblCodMaterial.Values.ExtraText = ""
        Me.lblCodMaterial.Values.Image = Nothing
        Me.lblCodMaterial.Values.Text = "Código material :"
        '
        'ucRubroDeVenta
        '
        Me.ucRubroDeVenta.BackColor = System.Drawing.Color.Transparent
        Me.ucRubroDeVenta.DataSource = Nothing
        Me.ucRubroDeVenta.DispleyMember = ""
        Me.ucRubroDeVenta.Etiquetas_Form = Nothing
        Me.ucRubroDeVenta.ListColumnas = Nothing
        Me.ucRubroDeVenta.Location = New System.Drawing.Point(150, 62)
        Me.ucRubroDeVenta.Name = "ucRubroDeVenta"
        Me.ucRubroDeVenta.Obligatorio = False
        Me.ucRubroDeVenta.PopupHeight = 0
        Me.ucRubroDeVenta.PopupWidth = 0
        Me.ucRubroDeVenta.Size = New System.Drawing.Size(275, 21)
        Me.ucRubroDeVenta.TabIndex = 1
        Me.ucRubroDeVenta.ValueMember = ""
        '
        'txtServicio
        '
        Me.txtServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServicio.Location = New System.Drawing.Point(150, 37)
        Me.txtServicio.MaxLength = 100
        Me.txtServicio.Name = "txtServicio"
        Me.txtServicio.Size = New System.Drawing.Size(275, 18)
        Me.txtServicio.TabIndex = 0
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(11, 37)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(146, 20)
        Me.KryptonLabel2.TabIndex = 59
        Me.KryptonLabel2.Text = "Descripción del Servicio :"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Descripción del Servicio :"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(51, 62)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(102, 20)
        Me.KryptonLabel3.TabIndex = 56
        Me.KryptonLabel3.Text = "Rubro de Venta :"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Rubro de Venta :"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator3, Me.lslTituloMantServicios})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(467, 25)
        Me.ToolStrip3.TabIndex = 5
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(0, 22)
        Me.ToolStripLabel3.Tag = ""
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton3.Image = Global.SOLMIN_CT.My.Resources.Resources.salir
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButton3.Text = "&Salir"
        Me.ToolStripButton3.ToolTipText = "Salir"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton4.Image = Global.SOLMIN_CT.My.Resources.Resources.save_all
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripButton4.Text = "&Grabar"
        Me.ToolStripButton4.ToolTipText = "Grabar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'lslTituloMantServicios
        '
        Me.lslTituloMantServicios.Name = "lslTituloMantServicios"
        Me.lslTituloMantServicios.Size = New System.Drawing.Size(0, 22)
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(60, 161)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(93, 20)
        Me.KryptonLabel5.TabIndex = 64
        Me.KryptonLabel5.Text = "MacroServicio :"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "MacroServicio :"
        '
        'txtMacroServicio
        '
        Me.txtMacroServicio.BackColor = System.Drawing.Color.White
        Me.txtMacroServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMacroServicio.Location = New System.Drawing.Point(150, 161)
        Me.txtMacroServicio.MaxLength = 250
        Me.txtMacroServicio.Name = "txtMacroServicio"
        Me.txtMacroServicio.ReadOnly = True
        Me.txtMacroServicio.Size = New System.Drawing.Size(275, 18)
        Me.txtMacroServicio.TabIndex = 65
        '
        'frmMantServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 199)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMantServicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Servicios Especificos"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.grpMantServicio.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMantServicio.Panel.ResumeLayout(False)
        Me.grpMantServicio.Panel.PerformLayout()
        CType(Me.grpMantServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMantServicio.ResumeLayout(False)
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
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
    Friend WithEvents grpMantServicio As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents txtServicio As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lslTituloMantServicios As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ucRubroDeVenta As Ransa.Utilitario.ucAyuda
    Friend WithEvents txtPorcentajeDetraccion As System.Windows.Forms.TextBox
    Friend WithEvents txtMontoDetraccion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodMaterial As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCodMaterial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtMacroServicio As System.Windows.Forms.TextBox
End Class
