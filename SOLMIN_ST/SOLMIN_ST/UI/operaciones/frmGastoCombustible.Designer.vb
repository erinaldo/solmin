<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGastoCombustible
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGastoCombustible))
    Me.panel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.MenuBar_1 = New System.Windows.Forms.ToolStrip
    Me.btnCancelarGastoCombustible = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
    Me.btnGuardarGastoCombustible = New System.Windows.Forms.ToolStripButton
    Me.txtImporteGasto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.txtKmRecorrer = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonBorderEdge2 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Me.ctbTipoCombustible = New CodeTextBox.CodeTextBox
    Me.dtpFechaCarga = New System.Windows.Forms.DateTimePicker
    Me.ctbGrifo = New CodeTextBox.CodeTextBox
    Me.txtValeRansa = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.txtCantidadGalones = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.txtValeGrifo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel22 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel21 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel19 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel18 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel16 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel20 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel17 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.panel.SuspendLayout()
    Me.MenuBar_1.SuspendLayout()
    Me.SuspendLayout()
    '
    'panel
    '
    Me.panel.Controls.Add(Me.MenuBar_1)
    Me.panel.Controls.Add(Me.txtImporteGasto)
    Me.panel.Controls.Add(Me.txtKmRecorrer)
    Me.panel.Controls.Add(Me.KryptonBorderEdge2)
    Me.panel.Controls.Add(Me.ctbTipoCombustible)
    Me.panel.Controls.Add(Me.dtpFechaCarga)
    Me.panel.Controls.Add(Me.ctbGrifo)
    Me.panel.Controls.Add(Me.txtValeRansa)
    Me.panel.Controls.Add(Me.txtCantidadGalones)
    Me.panel.Controls.Add(Me.txtValeGrifo)
    Me.panel.Controls.Add(Me.KryptonLabel13)
    Me.panel.Controls.Add(Me.KryptonLabel22)
    Me.panel.Controls.Add(Me.KryptonLabel21)
    Me.panel.Controls.Add(Me.KryptonLabel19)
    Me.panel.Controls.Add(Me.KryptonLabel18)
    Me.panel.Controls.Add(Me.KryptonLabel16)
    Me.panel.Controls.Add(Me.KryptonLabel20)
    Me.panel.Controls.Add(Me.KryptonLabel17)
    Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.panel.Location = New System.Drawing.Point(0, 0)
    Me.panel.Name = "panel"
    Me.panel.Size = New System.Drawing.Size(611, 155)
    Me.panel.StateCommon.Color1 = System.Drawing.Color.White
    Me.panel.TabIndex = 0
    '
    'MenuBar_1
    '
    Me.MenuBar_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
    Me.MenuBar_1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.MenuBar_1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelarGastoCombustible, Me.ToolStripSeparator2, Me.btnGuardarGastoCombustible})
    Me.MenuBar_1.Location = New System.Drawing.Point(0, 0)
    Me.MenuBar_1.Name = "MenuBar_1"
    Me.MenuBar_1.Size = New System.Drawing.Size(611, 25)
    Me.MenuBar_1.TabIndex = 86
    Me.MenuBar_1.TabStop = True
    Me.MenuBar_1.Text = "ToolStrip1"
    '
    'btnCancelarGastoCombustible
    '
    Me.btnCancelarGastoCombustible.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnCancelarGastoCombustible.Image = CType(resources.GetObject("btnCancelarGastoCombustible.Image"), System.Drawing.Image)
    Me.btnCancelarGastoCombustible.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnCancelarGastoCombustible.Name = "btnCancelarGastoCombustible"
    Me.btnCancelarGastoCombustible.Size = New System.Drawing.Size(69, 22)
    Me.btnCancelarGastoCombustible.Text = "Cancelar"
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
    '
    'btnGuardarGastoCombustible
    '
    Me.btnGuardarGastoCombustible.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnGuardarGastoCombustible.Image = CType(resources.GetObject("btnGuardarGastoCombustible.Image"), System.Drawing.Image)
    Me.btnGuardarGastoCombustible.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnGuardarGastoCombustible.Name = "btnGuardarGastoCombustible"
    Me.btnGuardarGastoCombustible.Size = New System.Drawing.Size(65, 22)
    Me.btnGuardarGastoCombustible.Text = "Guardar"
    '
    'txtImporteGasto
    '
    Me.txtImporteGasto.Location = New System.Drawing.Point(419, 126)
    Me.txtImporteGasto.MaxLength = 10
    Me.txtImporteGasto.Name = "txtImporteGasto"
    Me.txtImporteGasto.Size = New System.Drawing.Size(98, 19)
    Me.txtImporteGasto.TabIndex = 83
    Me.txtImporteGasto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'txtKmRecorrer
    '
    Me.txtKmRecorrer.Location = New System.Drawing.Point(419, 98)
    Me.txtKmRecorrer.MaxLength = 6
    Me.txtKmRecorrer.Name = "txtKmRecorrer"
    Me.txtKmRecorrer.Size = New System.Drawing.Size(98, 19)
    Me.txtKmRecorrer.TabIndex = 81
    Me.txtKmRecorrer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'KryptonBorderEdge2
    '
    Me.KryptonBorderEdge2.Location = New System.Drawing.Point(306, 31)
    Me.KryptonBorderEdge2.Name = "KryptonBorderEdge2"
    Me.KryptonBorderEdge2.Orientation = System.Windows.Forms.Orientation.Vertical
    Me.KryptonBorderEdge2.Size = New System.Drawing.Size(1, 120)
    Me.KryptonBorderEdge2.TabIndex = 65
    Me.KryptonBorderEdge2.TabStop = False
    Me.KryptonBorderEdge2.Text = "KryptonBorderEdge2"
    '
    'ctbTipoCombustible
    '
    Me.ctbTipoCombustible.BackColor = System.Drawing.Color.White
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
    Me.ctbTipoCombustible.Location = New System.Drawing.Point(419, 40)
    Me.ctbTipoCombustible.Name = "ctbTipoCombustible"
    Me.ctbTipoCombustible.Size = New System.Drawing.Size(185, 23)
    Me.ctbTipoCombustible.TabIndex = 77
    Me.ctbTipoCombustible.TabStop = True
    Me.ctbTipoCombustible.TextBackColor = System.Drawing.Color.Empty
    Me.ctbTipoCombustible.TextForeColor = System.Drawing.Color.Empty
    Me.ctbTipoCombustible.ValueColumnVisible = True
    Me.ctbTipoCombustible.ValueColumnWidth = 600
    Me.ctbTipoCombustible.ValueField = ""
    Me.ctbTipoCombustible.ValueMember = ""
    Me.ctbTipoCombustible.ValueSearch = True
    '
    'dtpFechaCarga
    '
    Me.dtpFechaCarga.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaCarga.Location = New System.Drawing.Point(107, 125)
    Me.dtpFechaCarga.Name = "dtpFechaCarga"
    Me.dtpFechaCarga.Size = New System.Drawing.Size(88, 20)
    Me.dtpFechaCarga.TabIndex = 75
    '
    'ctbGrifo
    '
    Me.ctbGrifo.BackColor = System.Drawing.Color.White
    Me.ctbGrifo.Codigo = ""
    Me.ctbGrifo.ControlHeight = 23
    Me.ctbGrifo.ControlImage = True
    Me.ctbGrifo.ControlReadOnly = False
    Me.ctbGrifo.Descripcion = ""
    Me.ctbGrifo.DisplayColumnVisible = True
    Me.ctbGrifo.DisplayMember = ""
    Me.ctbGrifo.KeyColumnWidth = 100
    Me.ctbGrifo.KeyField = ""
    Me.ctbGrifo.KeySearch = True
    Me.ctbGrifo.Location = New System.Drawing.Point(107, 96)
    Me.ctbGrifo.Name = "ctbGrifo"
    Me.ctbGrifo.Size = New System.Drawing.Size(185, 23)
    Me.ctbGrifo.TabIndex = 71
    Me.ctbGrifo.TabStop = True
    Me.ctbGrifo.TextBackColor = System.Drawing.Color.Empty
    Me.ctbGrifo.TextForeColor = System.Drawing.Color.Empty
    Me.ctbGrifo.ValueColumnVisible = True
    Me.ctbGrifo.ValueColumnWidth = 600
    Me.ctbGrifo.ValueField = ""
    Me.ctbGrifo.ValueMember = ""
    Me.ctbGrifo.ValueSearch = True
    '
    'txtValeRansa
    '
    Me.txtValeRansa.Location = New System.Drawing.Point(107, 42)
    Me.txtValeRansa.MaxLength = 10
    Me.txtValeRansa.Name = "txtValeRansa"
    Me.txtValeRansa.Size = New System.Drawing.Size(88, 19)
    Me.txtValeRansa.TabIndex = 67
    Me.txtValeRansa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'txtCantidadGalones
    '
    Me.txtCantidadGalones.Location = New System.Drawing.Point(419, 70)
    Me.txtCantidadGalones.MaxLength = 5
    Me.txtCantidadGalones.Name = "txtCantidadGalones"
    Me.txtCantidadGalones.Size = New System.Drawing.Size(98, 19)
    Me.txtCantidadGalones.TabIndex = 79
    Me.txtCantidadGalones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'txtValeGrifo
    '
    Me.txtValeGrifo.Location = New System.Drawing.Point(107, 70)
    Me.txtValeGrifo.MaxLength = 10
    Me.txtValeGrifo.Name = "txtValeGrifo"
    Me.txtValeGrifo.Size = New System.Drawing.Size(88, 19)
    Me.txtValeGrifo.TabIndex = 69
    Me.txtValeGrifo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'KryptonLabel13
    '
    Me.KryptonLabel13.Location = New System.Drawing.Point(7, 71)
    Me.KryptonLabel13.Name = "KryptonLabel13"
    Me.KryptonLabel13.Size = New System.Drawing.Size(76, 16)
    Me.KryptonLabel13.TabIndex = 68
    Me.KryptonLabel13.TabStop = False
    Me.KryptonLabel13.Text = "N° Vale Grifo"
    Me.KryptonLabel13.Values.ExtraText = ""
    Me.KryptonLabel13.Values.Image = Nothing
    Me.KryptonLabel13.Values.Text = "N° Vale Grifo"
    '
    'KryptonLabel22
    '
    Me.KryptonLabel22.Location = New System.Drawing.Point(319, 127)
    Me.KryptonLabel22.Name = "KryptonLabel22"
    Me.KryptonLabel22.Size = New System.Drawing.Size(97, 16)
    Me.KryptonLabel22.TabIndex = 82
    Me.KryptonLabel22.TabStop = False
    Me.KryptonLabel22.Text = "Importe de Gasto"
    Me.KryptonLabel22.Values.ExtraText = ""
    Me.KryptonLabel22.Values.Image = Nothing
    Me.KryptonLabel22.Values.Text = "Importe de Gasto"
    '
    'KryptonLabel21
    '
    Me.KryptonLabel21.Location = New System.Drawing.Point(319, 99)
    Me.KryptonLabel21.Name = "KryptonLabel21"
    Me.KryptonLabel21.Size = New System.Drawing.Size(79, 16)
    Me.KryptonLabel21.TabIndex = 80
    Me.KryptonLabel21.TabStop = False
    Me.KryptonLabel21.Text = "Km Recorrido"
    Me.KryptonLabel21.Values.ExtraText = ""
    Me.KryptonLabel21.Values.Image = Nothing
    Me.KryptonLabel21.Values.Text = "Km Recorrido"
    '
    'KryptonLabel19
    '
    Me.KryptonLabel19.Location = New System.Drawing.Point(319, 71)
    Me.KryptonLabel19.Name = "KryptonLabel19"
    Me.KryptonLabel19.Size = New System.Drawing.Size(101, 16)
    Me.KryptonLabel19.TabIndex = 78
    Me.KryptonLabel19.TabStop = False
    Me.KryptonLabel19.Text = "Cantidad Galones"
    Me.KryptonLabel19.Values.ExtraText = ""
    Me.KryptonLabel19.Values.Image = Nothing
    Me.KryptonLabel19.Values.Text = "Cantidad Galones"
    '
    'KryptonLabel18
    '
    Me.KryptonLabel18.Location = New System.Drawing.Point(7, 127)
    Me.KryptonLabel18.Name = "KryptonLabel18"
    Me.KryptonLabel18.Size = New System.Drawing.Size(90, 16)
    Me.KryptonLabel18.TabIndex = 74
    Me.KryptonLabel18.TabStop = False
    Me.KryptonLabel18.Text = "Fecha Carga C."
    Me.KryptonLabel18.Values.ExtraText = ""
    Me.KryptonLabel18.Values.Image = Nothing
    Me.KryptonLabel18.Values.Text = "Fecha Carga C."
    '
    'KryptonLabel16
    '
    Me.KryptonLabel16.Location = New System.Drawing.Point(7, 43)
    Me.KryptonLabel16.Name = "KryptonLabel16"
    Me.KryptonLabel16.Size = New System.Drawing.Size(91, 16)
    Me.KryptonLabel16.TabIndex = 66
    Me.KryptonLabel16.TabStop = False
    Me.KryptonLabel16.Text = "N° Vale RANSA"
    Me.KryptonLabel16.Values.ExtraText = ""
    Me.KryptonLabel16.Values.Image = Nothing
    Me.KryptonLabel16.Values.Text = "N° Vale RANSA"
    '
    'KryptonLabel20
    '
    Me.KryptonLabel20.Location = New System.Drawing.Point(319, 43)
    Me.KryptonLabel20.Name = "KryptonLabel20"
    Me.KryptonLabel20.Size = New System.Drawing.Size(98, 16)
    Me.KryptonLabel20.TabIndex = 76
    Me.KryptonLabel20.TabStop = False
    Me.KryptonLabel20.Text = "Tipo Combustible"
    Me.KryptonLabel20.Values.ExtraText = ""
    Me.KryptonLabel20.Values.Image = Nothing
    Me.KryptonLabel20.Values.Text = "Tipo Combustible"
    '
    'KryptonLabel17
    '
    Me.KryptonLabel17.Location = New System.Drawing.Point(7, 99)
    Me.KryptonLabel17.Name = "KryptonLabel17"
    Me.KryptonLabel17.Size = New System.Drawing.Size(35, 16)
    Me.KryptonLabel17.TabIndex = 70
    Me.KryptonLabel17.TabStop = False
    Me.KryptonLabel17.Text = "Grifo"
    Me.KryptonLabel17.Values.ExtraText = ""
    Me.KryptonLabel17.Values.Image = Nothing
    Me.KryptonLabel17.Values.Text = "Grifo"
    '
    'frmGastoCombustible
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(611, 155)
    Me.ControlBox = False
    Me.Controls.Add(Me.panel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "frmGastoCombustible"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = " Gasto Combustible"
    CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.panel.ResumeLayout(False)
    Me.panel.PerformLayout()
    Me.MenuBar_1.ResumeLayout(False)
    Me.MenuBar_1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents panel As ComponentFactory.Krypton.Toolkit.KryptonPanel
  Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

  Public Sub New()

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub
  Friend WithEvents txtImporteGasto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents txtKmRecorrer As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonBorderEdge2 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
  Friend WithEvents ctbTipoCombustible As CodeTextBox.CodeTextBox
  Friend WithEvents dtpFechaCarga As System.Windows.Forms.DateTimePicker
  Friend WithEvents ctbGrifo As CodeTextBox.CodeTextBox
  Friend WithEvents txtValeRansa As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents txtCantidadGalones As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents txtValeGrifo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel22 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel21 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel19 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel18 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel16 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel20 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel17 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents MenuBar_1 As System.Windows.Forms.ToolStrip
  Friend WithEvents btnGuardarGastoCombustible As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnCancelarGastoCombustible As System.Windows.Forms.ToolStripButton
End Class
