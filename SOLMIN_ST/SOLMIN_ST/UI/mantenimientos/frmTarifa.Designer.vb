<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTarifa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTarifa))
        Me.Panel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.ctbTipoCombustible = New CodeTextBox.CodeTextBox
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtPrecioSoles = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtPrecioDolares = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonBorderEdge1 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.txtNroCorrela = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtGrifo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.MenuBar = New System.Windows.Forms.ToolStrip
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        Me.Separator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel
        '
        Me.Panel.Controls.Add(Me.ctbTipoCombustible)
        Me.Panel.Controls.Add(Me.KryptonLabel5)
        Me.Panel.Controls.Add(Me.txtPrecioSoles)
        Me.Panel.Controls.Add(Me.KryptonLabel4)
        Me.Panel.Controls.Add(Me.txtPrecioDolares)
        Me.Panel.Controls.Add(Me.KryptonLabel3)
        Me.Panel.Controls.Add(Me.KryptonBorderEdge1)
        Me.Panel.Controls.Add(Me.txtNroCorrela)
        Me.Panel.Controls.Add(Me.txtGrifo)
        Me.Panel.Controls.Add(Me.KryptonLabel2)
        Me.Panel.Controls.Add(Me.KryptonLabel1)
        Me.Panel.Controls.Add(Me.MenuBar)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(431, 144)
        Me.Panel.StateCommon.Color1 = System.Drawing.Color.White
        Me.Panel.TabIndex = 0
        '
        'ctbTipoCombustible
        '
        Me.ctbTipoCombustible.Codigo = ""
        Me.ctbTipoCombustible.ControlHeight = 23
        Me.ctbTipoCombustible.ControlImage = True
        Me.ctbTipoCombustible.ControlReadOnly = False
        Me.ctbTipoCombustible.Descripcion = ""
        Me.ctbTipoCombustible.DisplayColumnVisible = True
        Me.ctbTipoCombustible.DisplayMember = ""
        Me.ctbTipoCombustible.KeyColumnWidth = 100
        Me.ctbTipoCombustible.KeyField = ""
        Me.ctbTipoCombustible.KeySearch = True
        Me.ctbTipoCombustible.Location = New System.Drawing.Point(106, 77)
        Me.ctbTipoCombustible.Name = "ctbTipoCombustible"
        Me.ctbTipoCombustible.Size = New System.Drawing.Size(264, 23)
        Me.ctbTipoCombustible.TabIndex = 7
        Me.ctbTipoCombustible.TextBackColor = System.Drawing.Color.Empty
        Me.ctbTipoCombustible.TextForeColor = System.Drawing.Color.Empty
        Me.ctbTipoCombustible.ValueColumnVisible = True
        Me.ctbTipoCombustible.ValueColumnWidth = 600
        Me.ctbTipoCombustible.ValueField = ""
        Me.ctbTipoCombustible.ValueMember = ""
        Me.ctbTipoCombustible.ValueSearch = True
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(5, 80)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(107, 20)
        Me.KryptonLabel5.TabIndex = 6
        Me.KryptonLabel5.Text = "Tipo Combustible"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Tipo Combustible"
        '
        'txtPrecioSoles
        '
        Me.txtPrecioSoles.Location = New System.Drawing.Point(106, 111)
        Me.txtPrecioSoles.MaxLength = 7
        Me.txtPrecioSoles.Name = "txtPrecioSoles"
        Me.txtPrecioSoles.Size = New System.Drawing.Size(86, 22)
        Me.txtPrecioSoles.TabIndex = 9
        Me.txtPrecioSoles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(208, 112)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(64, 20)
        Me.KryptonLabel4.TabIndex = 10
        Me.KryptonLabel4.Text = "Precio ($.)"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Precio ($.)"
        '
        'txtPrecioDolares
        '
        Me.txtPrecioDolares.Location = New System.Drawing.Point(284, 111)
        Me.txtPrecioDolares.MaxLength = 7
        Me.txtPrecioDolares.Name = "txtPrecioDolares"
        Me.txtPrecioDolares.Size = New System.Drawing.Size(86, 22)
        Me.txtPrecioDolares.TabIndex = 11
        Me.txtPrecioDolares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(5, 112)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(69, 20)
        Me.KryptonLabel3.TabIndex = 8
        Me.KryptonLabel3.Text = "Precio (S/.)"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Precio (S/.)"
        '
        'KryptonBorderEdge1
        '
        Me.KryptonBorderEdge1.Location = New System.Drawing.Point(6, 60)
        Me.KryptonBorderEdge1.Name = "KryptonBorderEdge1"
        Me.KryptonBorderEdge1.Size = New System.Drawing.Size(420, 1)
        Me.KryptonBorderEdge1.TabIndex = 5
        Me.KryptonBorderEdge1.Text = "KryptonBorderEdge1"
        '
        'txtNroCorrela
        '
        Me.txtNroCorrela.Enabled = False
        Me.txtNroCorrela.Location = New System.Drawing.Point(356, 35)
        Me.txtNroCorrela.Name = "txtNroCorrela"
        Me.txtNroCorrela.Size = New System.Drawing.Size(65, 17)
        Me.txtNroCorrela.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.txtNroCorrela.StateDisabled.Border.Color1 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtNroCorrela.StateDisabled.Border.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtNroCorrela.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtNroCorrela.TabIndex = 4
        Me.txtNroCorrela.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGrifo
        '
        Me.txtGrifo.Enabled = False
        Me.txtGrifo.Location = New System.Drawing.Point(43, 35)
        Me.txtGrifo.Name = "txtGrifo"
        Me.txtGrifo.Size = New System.Drawing.Size(224, 17)
        Me.txtGrifo.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.txtGrifo.StateDisabled.Border.Color1 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtGrifo.StateDisabled.Border.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtGrifo.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtGrifo.TabIndex = 2
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(272, 35)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(87, 20)
        Me.KryptonLabel2.TabIndex = 3
        Me.KryptonLabel2.Text = "N° Correlativo"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "N° Correlativo"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(5, 35)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(37, 20)
        Me.KryptonLabel1.TabIndex = 1
        Me.KryptonLabel1.Text = "Grifo"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Grifo"
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGuardar, Me.Separator2, Me.btnCancelar})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(431, 25)
        Me.MenuBar.TabIndex = 0
        Me.MenuBar.TabStop = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(69, 22)
        Me.btnGuardar.Text = "Guardar"
        '
        'Separator2
        '
        Me.Separator2.Name = "Separator2"
        Me.Separator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(73, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'frmTarifa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 144)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmTarifa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tarifa"
        CType(Me.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Separator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtPrecioSoles As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPrecioDolares As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonBorderEdge1 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents txtNroCorrela As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtGrifo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ctbTipoCombustible As CodeTextBox.CodeTextBox
  Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
