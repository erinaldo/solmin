<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpcionSustentoFactura
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
    Me.panel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.btnProcesarConsulta = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.lblSeparador = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.cboEstado = New System.Windows.Forms.ComboBox
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtNroFactura = New SOLMIN_ST.TextField
    Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.dtpFechaGR_2 = New System.Windows.Forms.DateTimePicker
    Me.dtpFechaGR_1 = New System.Windows.Forms.DateTimePicker
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtOrdenServicio = New SOLMIN_ST.TextField
    Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.panel.SuspendLayout()
    CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelFiltros.Panel.SuspendLayout()
    Me.PanelFiltros.SuspendLayout()
    Me.SuspendLayout()
    '
    'panel
    '
    Me.panel.Controls.Add(Me.PanelFiltros)
    Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.panel.Location = New System.Drawing.Point(0, 0)
    Me.panel.Name = "panel"
    Me.panel.Size = New System.Drawing.Size(472, 103)
    Me.panel.TabIndex = 0
    '
    'PanelFiltros
    '
    Me.PanelFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnProcesarConsulta, Me.btnCancelar})
    Me.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PanelFiltros.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.PanelFiltros.HeaderVisiblePrimary = False
    Me.PanelFiltros.Location = New System.Drawing.Point(0, 0)
    Me.PanelFiltros.Name = "PanelFiltros"
    '
    'PanelFiltros.Panel
    '
    Me.PanelFiltros.Panel.Controls.Add(Me.lblSeparador)
    Me.PanelFiltros.Panel.Controls.Add(Me.cboEstado)
    Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel2)
    Me.PanelFiltros.Panel.Controls.Add(Me.txtNroFactura)
    Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel4)
    Me.PanelFiltros.Panel.Controls.Add(Me.dtpFechaGR_2)
    Me.PanelFiltros.Panel.Controls.Add(Me.dtpFechaGR_1)
    Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel1)
    Me.PanelFiltros.Panel.Controls.Add(Me.txtOrdenServicio)
    Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel3)
    Me.PanelFiltros.Size = New System.Drawing.Size(472, 103)
    Me.PanelFiltros.TabIndex = 24
    Me.PanelFiltros.ValuesPrimary.Description = ""
    Me.PanelFiltros.ValuesPrimary.Heading = ""
    Me.PanelFiltros.ValuesPrimary.Image = Nothing
    Me.PanelFiltros.ValuesSecondary.Description = ""
    Me.PanelFiltros.ValuesSecondary.Heading = ""
    Me.PanelFiltros.ValuesSecondary.Image = Nothing
    '
    'btnProcesarConsulta
    '
    Me.btnProcesarConsulta.ExtraText = ""
    Me.btnProcesarConsulta.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
    Me.btnProcesarConsulta.Image = Global.SOLMIN_ST.My.Resources.Resources.excel1
    Me.btnProcesarConsulta.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
    Me.btnProcesarConsulta.Text = "Exportar"
    Me.btnProcesarConsulta.ToolTipImage = Nothing
    Me.btnProcesarConsulta.UniqueName = "1E7B5DC088DB4E1F1E7B5DC088DB4E1F"
    '
    'btnCancelar
    '
    Me.btnCancelar.ExtraText = ""
    Me.btnCancelar.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
    Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
    Me.btnCancelar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
    Me.btnCancelar.Text = "Cancelar"
    Me.btnCancelar.ToolTipImage = Nothing
    Me.btnCancelar.UniqueName = "978C187575614E31978C187575614E31"
    '
    'lblSeparador
    '
    Me.lblSeparador.Location = New System.Drawing.Point(182, 40)
    Me.lblSeparador.Name = "lblSeparador"
    Me.lblSeparador.Size = New System.Drawing.Size(18, 19)
    Me.lblSeparador.TabIndex = 74
    Me.lblSeparador.Text = " - "
    Me.lblSeparador.Values.ExtraText = ""
    Me.lblSeparador.Values.Image = Nothing
    Me.lblSeparador.Values.Text = " - "
    '
    'cboEstado
    '
    Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboEstado.FormattingEnabled = True
    Me.cboEstado.Location = New System.Drawing.Point(60, 39)
    Me.cboEstado.Name = "cboEstado"
    Me.cboEstado.Size = New System.Drawing.Size(118, 21)
    Me.cboEstado.TabIndex = 73
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(8, 40)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(44, 19)
    Me.KryptonLabel2.TabIndex = 72
    Me.KryptonLabel2.Text = "Estado"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "Estado"
    '
    'txtNroFactura
    '
    Me.txtNroFactura.Location = New System.Drawing.Point(205, 40)
    Me.txtNroFactura.MaxLength = 10
    Me.txtNroFactura.Name = "txtNroFactura"
    Me.txtNroFactura.Size = New System.Drawing.Size(105, 19)
    Me.txtNroFactura.StateCommon.Back.Color1 = System.Drawing.Color.White
    Me.txtNroFactura.StateCommon.Content.Color1 = System.Drawing.Color.Black
    Me.txtNroFactura.StateCommon.Content.Font = New System.Drawing.Font("Tahoma", 8.0!)
    Me.txtNroFactura.TabIndex = 18
    Me.txtNroFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtNroFactura.TextValidationType = SOLMIN_ST.ValidationInputType.Alpha
    '
    'KryptonLabel4
    '
    Me.KryptonLabel4.Location = New System.Drawing.Point(346, 10)
    Me.KryptonLabel4.Name = "KryptonLabel4"
    Me.KryptonLabel4.Size = New System.Drawing.Size(19, 19)
    Me.KryptonLabel4.TabIndex = 71
    Me.KryptonLabel4.Text = "al"
    Me.KryptonLabel4.Values.ExtraText = ""
    Me.KryptonLabel4.Values.Image = Nothing
    Me.KryptonLabel4.Values.Text = "al"
    '
    'dtpFechaGR_2
    '
    Me.dtpFechaGR_2.Enabled = False
    Me.dtpFechaGR_2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaGR_2.Location = New System.Drawing.Point(369, 9)
    Me.dtpFechaGR_2.Name = "dtpFechaGR_2"
    Me.dtpFechaGR_2.Size = New System.Drawing.Size(90, 20)
    Me.dtpFechaGR_2.TabIndex = 70
    Me.dtpFechaGR_2.Visible = False
    '
    'dtpFechaGR_1
    '
    Me.dtpFechaGR_1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaGR_1.Location = New System.Drawing.Point(248, 9)
    Me.dtpFechaGR_1.Name = "dtpFechaGR_1"
    Me.dtpFechaGR_1.Size = New System.Drawing.Size(95, 20)
    Me.dtpFechaGR_1.TabIndex = 69
    Me.dtpFechaGR_1.Visible = False
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(8, 10)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(41, 19)
    Me.KryptonLabel1.TabIndex = 23
    Me.KryptonLabel1.Text = "O / S :"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "O / S :"
    '
    'txtOrdenServicio
    '
    Me.txtOrdenServicio.Location = New System.Drawing.Point(60, 10)
    Me.txtOrdenServicio.MaxLength = 10
    Me.txtOrdenServicio.Name = "txtOrdenServicio"
    Me.txtOrdenServicio.Size = New System.Drawing.Size(118, 19)
    Me.txtOrdenServicio.StateCommon.Back.Color1 = System.Drawing.Color.White
    Me.txtOrdenServicio.StateCommon.Content.Color1 = System.Drawing.Color.Black
    Me.txtOrdenServicio.StateCommon.Content.Font = New System.Drawing.Font("Tahoma", 8.0!)
    Me.txtOrdenServicio.TabIndex = 22
    Me.txtOrdenServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtOrdenServicio.TextValidationType = SOLMIN_ST.ValidationInputType.Alpha
    '
    'KryptonLabel3
    '
    Me.KryptonLabel3.Location = New System.Drawing.Point(205, 10)
    Me.KryptonLabel3.Name = "KryptonLabel3"
    Me.KryptonLabel3.Size = New System.Drawing.Size(39, 19)
    Me.KryptonLabel3.TabIndex = 27
    Me.KryptonLabel3.Text = "Fecha"
    Me.KryptonLabel3.Values.ExtraText = ""
    Me.KryptonLabel3.Values.Image = Nothing
    Me.KryptonLabel3.Values.Text = "Fecha"
    '
    'frmOpcionSustentoFactura
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(472, 103)
    Me.ControlBox = False
    Me.Controls.Add(Me.panel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "frmOpcionSustentoFactura"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Exportar - Sustento Factura"
    CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.panel.ResumeLayout(False)
    CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelFiltros.Panel.ResumeLayout(False)
    Me.PanelFiltros.Panel.PerformLayout()
    CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelFiltros.ResumeLayout(False)
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
  Friend WithEvents PanelFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents btnProcesarConsulta As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents txtNroFactura As SOLMIN_ST.TextField
  Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtOrdenServicio As SOLMIN_ST.TextField
  Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents dtpFechaGR_2 As System.Windows.Forms.DateTimePicker
  Friend WithEvents dtpFechaGR_1 As System.Windows.Forms.DateTimePicker
  Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents lblSeparador As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents cboEstado As System.Windows.Forms.ComboBox
End Class
