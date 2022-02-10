<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleLiquidacionCombustible
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.panel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.hgValeLiquidado = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.dtgVales = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.NSLCMB_V = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.NVLGRF_V = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.FSLCMB_V = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.TGRFO_V = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CTPCMB_V = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.FCRCMB_V = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.QGLNCM_V = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CSTGLN_V = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.SESSLC_V = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.hgOperacionLiquidado = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.dtgOperacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.MenuBar = New System.Windows.Forms.ToolStrip
    Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
    Me.btnCancelar = New System.Windows.Forms.ToolStripButton
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.NLQCMB = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.TCMPCL = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.NOPRCN = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.RUTA = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CTPCMB = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.NKMRCR = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.QGLNCM = New System.Windows.Forms.DataGridViewTextBoxColumn
    CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.panel.SuspendLayout()
    CType(Me.hgValeLiquidado, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.hgValeLiquidado.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.hgValeLiquidado.Panel.SuspendLayout()
    Me.hgValeLiquidado.SuspendLayout()
    CType(Me.dtgVales, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.hgOperacionLiquidado, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.hgOperacionLiquidado.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.hgOperacionLiquidado.Panel.SuspendLayout()
    Me.hgOperacionLiquidado.SuspendLayout()
    CType(Me.dtgOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.MenuBar.SuspendLayout()
    Me.SuspendLayout()
    '
    'panel
    '
    Me.panel.Controls.Add(Me.hgValeLiquidado)
    Me.panel.Controls.Add(Me.hgOperacionLiquidado)
    Me.panel.Controls.Add(Me.MenuBar)
    Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.panel.Location = New System.Drawing.Point(0, 0)
    Me.panel.Name = "panel"
    Me.panel.Size = New System.Drawing.Size(825, 365)
    Me.panel.StateCommon.Color1 = System.Drawing.Color.White
    Me.panel.TabIndex = 0
    '
    'hgValeLiquidado
    '
    Me.hgValeLiquidado.Dock = System.Windows.Forms.DockStyle.Fill
    Me.hgValeLiquidado.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form
    Me.hgValeLiquidado.HeaderVisibleSecondary = False
    Me.hgValeLiquidado.Location = New System.Drawing.Point(0, 25)
    Me.hgValeLiquidado.Name = "hgValeLiquidado"
    '
    'hgValeLiquidado.Panel
    '
    Me.hgValeLiquidado.Panel.Controls.Add(Me.dtgVales)
    Me.hgValeLiquidado.Size = New System.Drawing.Size(825, 159)
    Me.hgValeLiquidado.TabIndex = 5
    Me.hgValeLiquidado.Text = "Lista de Vales Liquidados"
    Me.hgValeLiquidado.ValuesPrimary.Description = ""
    Me.hgValeLiquidado.ValuesPrimary.Heading = "Lista de Vales Liquidados"
    Me.hgValeLiquidado.ValuesPrimary.Image = Nothing
    Me.hgValeLiquidado.ValuesSecondary.Description = ""
    Me.hgValeLiquidado.ValuesSecondary.Heading = "Description"
    Me.hgValeLiquidado.ValuesSecondary.Image = Nothing
    '
    'dtgVales
    '
    Me.dtgVales.AllowUserToAddRows = False
    Me.dtgVales.AllowUserToDeleteRows = False
    Me.dtgVales.AllowUserToOrderColumns = True
    Me.dtgVales.ColumnHeadersHeight = 30
    Me.dtgVales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    Me.dtgVales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NSLCMB_V, Me.NVLGRF_V, Me.FSLCMB_V, Me.TGRFO_V, Me.CTPCMB_V, Me.FCRCMB_V, Me.QGLNCM_V, Me.CSTGLN_V, Me.SESSLC_V})
    Me.dtgVales.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dtgVales.Location = New System.Drawing.Point(0, 0)
    Me.dtgVales.Name = "dtgVales"
    Me.dtgVales.ReadOnly = True
    Me.dtgVales.RowHeadersVisible = False
    Me.dtgVales.RowHeadersWidth = 30
    Me.dtgVales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.dtgVales.Size = New System.Drawing.Size(823, 137)
    Me.dtgVales.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.dtgVales.TabIndex = 1
    '
    'NSLCMB_V
    '
    Me.NSLCMB_V.DataPropertyName = "NSLCMB"
    Me.NSLCMB_V.HeaderText = "N° Asignación Combustible"
    Me.NSLCMB_V.Name = "NSLCMB_V"
    Me.NSLCMB_V.ReadOnly = True
    Me.NSLCMB_V.Visible = False
    '
    'NVLGRF_V
    '
    Me.NVLGRF_V.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
    Me.NVLGRF_V.DataPropertyName = "NVLGRF"
    Me.NVLGRF_V.HeaderText = "N° Vale Combustible"
    Me.NVLGRF_V.Name = "NVLGRF_V"
    Me.NVLGRF_V.ReadOnly = True
    Me.NVLGRF_V.Width = 120
    '
    'FSLCMB_V
    '
    Me.FSLCMB_V.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
    Me.FSLCMB_V.DataPropertyName = "FSLCMB_S"
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    Me.FSLCMB_V.DefaultCellStyle = DataGridViewCellStyle1
    Me.FSLCMB_V.HeaderText = "Fecha Asignación"
    Me.FSLCMB_V.Name = "FSLCMB_V"
    Me.FSLCMB_V.ReadOnly = True
    Me.FSLCMB_V.Width = 105
    '
    'TGRFO_V
    '
    Me.TGRFO_V.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.TGRFO_V.DataPropertyName = "TGRFO"
    Me.TGRFO_V.HeaderText = "Grifo"
    Me.TGRFO_V.Name = "TGRFO_V"
    Me.TGRFO_V.ReadOnly = True
    '
    'CTPCMB_V
    '
    Me.CTPCMB_V.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
    Me.CTPCMB_V.DataPropertyName = "CTPCMB"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    Me.CTPCMB_V.DefaultCellStyle = DataGridViewCellStyle2
    Me.CTPCMB_V.HeaderText = "Tipo Combustible"
    Me.CTPCMB_V.Name = "CTPCMB_V"
    Me.CTPCMB_V.ReadOnly = True
    '
    'FCRCMB_V
    '
    Me.FCRCMB_V.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
    Me.FCRCMB_V.DataPropertyName = "FCRCMB_S"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    Me.FCRCMB_V.DefaultCellStyle = DataGridViewCellStyle3
    Me.FCRCMB_V.HeaderText = "Fecha Carga Comb."
    Me.FCRCMB_V.Name = "FCRCMB_V"
    Me.FCRCMB_V.ReadOnly = True
    Me.FCRCMB_V.Width = 110
    '
    'QGLNCM_V
    '
    Me.QGLNCM_V.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
    Me.QGLNCM_V.DataPropertyName = "QGLNCM"
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
    Me.QGLNCM_V.DefaultCellStyle = DataGridViewCellStyle4
    Me.QGLNCM_V.HeaderText = "Galones Asignados"
    Me.QGLNCM_V.Name = "QGLNCM_V"
    Me.QGLNCM_V.ReadOnly = True
    Me.QGLNCM_V.Width = 110
    '
    'CSTGLN_V
    '
    Me.CSTGLN_V.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
    Me.CSTGLN_V.DataPropertyName = "CSTGLN"
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
    Me.CSTGLN_V.DefaultCellStyle = DataGridViewCellStyle5
    Me.CSTGLN_V.HeaderText = "Costo Galón"
    Me.CSTGLN_V.Name = "CSTGLN_V"
    Me.CSTGLN_V.ReadOnly = True
    Me.CSTGLN_V.Width = 90
    '
    'SESSLC_V
    '
    Me.SESSLC_V.DataPropertyName = "SESSLC"
    Me.SESSLC_V.HeaderText = "Estatus"
    Me.SESSLC_V.Name = "SESSLC_V"
    Me.SESSLC_V.ReadOnly = True
    Me.SESSLC_V.Visible = False
    '
    'hgOperacionLiquidado
    '
    Me.hgOperacionLiquidado.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.hgOperacionLiquidado.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form
    Me.hgOperacionLiquidado.HeaderVisibleSecondary = False
    Me.hgOperacionLiquidado.Location = New System.Drawing.Point(0, 184)
    Me.hgOperacionLiquidado.Name = "hgOperacionLiquidado"
    '
    'hgOperacionLiquidado.Panel
    '
    Me.hgOperacionLiquidado.Panel.Controls.Add(Me.dtgOperacion)
    Me.hgOperacionLiquidado.Size = New System.Drawing.Size(825, 181)
    Me.hgOperacionLiquidado.TabIndex = 4
    Me.hgOperacionLiquidado.Text = "Lista de Operaciones Liquidadas"
    Me.hgOperacionLiquidado.ValuesPrimary.Description = ""
    Me.hgOperacionLiquidado.ValuesPrimary.Heading = "Lista de Operaciones Liquidadas"
    Me.hgOperacionLiquidado.ValuesPrimary.Image = Nothing
    Me.hgOperacionLiquidado.ValuesSecondary.Description = ""
    Me.hgOperacionLiquidado.ValuesSecondary.Heading = "Description"
    Me.hgOperacionLiquidado.ValuesSecondary.Image = Nothing
    '
    'dtgOperacion
    '
    Me.dtgOperacion.AllowUserToAddRows = False
    Me.dtgOperacion.AllowUserToDeleteRows = False
    Me.dtgOperacion.AllowUserToOrderColumns = True
    Me.dtgOperacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
    Me.dtgOperacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
    Me.dtgOperacion.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
    Me.dtgOperacion.ColumnHeadersHeight = 30
    Me.dtgOperacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    Me.dtgOperacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NLQCMB, Me.TCMPCL, Me.NOPRCN, Me.RUTA, Me.CTPCMB, Me.NKMRCR, Me.QGLNCM})
    Me.dtgOperacion.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dtgOperacion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.dtgOperacion.Location = New System.Drawing.Point(0, 0)
    Me.dtgOperacion.MultiSelect = False
    Me.dtgOperacion.Name = "dtgOperacion"
    Me.dtgOperacion.ReadOnly = True
    Me.dtgOperacion.RowHeadersVisible = False
    Me.dtgOperacion.RowHeadersWidth = 20
    Me.dtgOperacion.RowTemplate.Height = 16
    Me.dtgOperacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dtgOperacion.Size = New System.Drawing.Size(823, 159)
    Me.dtgOperacion.StandardTab = True
    Me.dtgOperacion.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.dtgOperacion.TabIndex = 2
    Me.dtgOperacion.TabStop = False
    '
    'MenuBar
    '
    Me.MenuBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
    Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.btnCancelar})
    Me.MenuBar.Location = New System.Drawing.Point(0, 0)
    Me.MenuBar.Name = "MenuBar"
    Me.MenuBar.Size = New System.Drawing.Size(825, 25)
    Me.MenuBar.TabIndex = 3
    Me.MenuBar.Text = "ToolStrip1"
    '
    'ToolStripLabel1
    '
    Me.ToolStripLabel1.Name = "ToolStripLabel1"
    Me.ToolStripLabel1.Size = New System.Drawing.Size(0, 22)
    '
    'btnCancelar
    '
    Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
    Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(69, 22)
    Me.btnCancelar.Text = "Cancelar"
    '
    'NLQCMB
    '
    Me.NLQCMB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.NLQCMB.DataPropertyName = "NLQCMB"
    Me.NLQCMB.HeaderText = "N° Liquidación Combustible"
    Me.NLQCMB.MaxInputLength = 150
    Me.NLQCMB.Name = "NLQCMB"
    Me.NLQCMB.ReadOnly = True
    Me.NLQCMB.Visible = False
    Me.NLQCMB.Width = 165
    '
    'TCMPCL
    '
    Me.TCMPCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.TCMPCL.DataPropertyName = "TCMPCL"
    Me.TCMPCL.HeaderText = "Cliente"
    Me.TCMPCL.Name = "TCMPCL"
    Me.TCMPCL.ReadOnly = True
    '
    'NOPRCN
    '
    Me.NOPRCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.NOPRCN.DataPropertyName = "NOPRCN"
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    Me.NOPRCN.DefaultCellStyle = DataGridViewCellStyle6
    Me.NOPRCN.HeaderText = "N° Operación"
    Me.NOPRCN.Name = "NOPRCN"
    Me.NOPRCN.ReadOnly = True
    '
    'RUTA
    '
    Me.RUTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.RUTA.DataPropertyName = "RUTA"
    Me.RUTA.HeaderText = "Ruta"
    Me.RUTA.Name = "RUTA"
    Me.RUTA.ReadOnly = True
    '
    'CTPCMB
    '
    Me.CTPCMB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.CTPCMB.DataPropertyName = "CTPCMB"
    DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    Me.CTPCMB.DefaultCellStyle = DataGridViewCellStyle7
    Me.CTPCMB.HeaderText = "Tipo Combustible"
    Me.CTPCMB.Name = "CTPCMB"
    Me.CTPCMB.ReadOnly = True
    Me.CTPCMB.Width = 117
    '
    'NKMRCR
    '
    Me.NKMRCR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.NKMRCR.DataPropertyName = "NKMRCR"
    DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
    Me.NKMRCR.DefaultCellStyle = DataGridViewCellStyle8
    Me.NKMRCR.HeaderText = "Kilometro Recorrido"
    Me.NKMRCR.Name = "NKMRCR"
    Me.NKMRCR.ReadOnly = True
    Me.NKMRCR.Width = 128
    '
    'QGLNCM
    '
    Me.QGLNCM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.QGLNCM.DataPropertyName = "QGLNCM"
    DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
    Me.QGLNCM.DefaultCellStyle = DataGridViewCellStyle9
    Me.QGLNCM.HeaderText = "Galones Utilizados"
    Me.QGLNCM.Name = "QGLNCM"
    Me.QGLNCM.ReadOnly = True
    Me.QGLNCM.Width = 123
    '
    'frmDetalleLiquidacionCombustible
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(825, 365)
    Me.ControlBox = False
    Me.Controls.Add(Me.panel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.MinimumSize = New System.Drawing.Size(650, 290)
    Me.Name = "frmDetalleLiquidacionCombustible"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "  Detalle Liquidación Combustible"
    CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.panel.ResumeLayout(False)
    Me.panel.PerformLayout()
    CType(Me.hgValeLiquidado.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.hgValeLiquidado.Panel.ResumeLayout(False)
    CType(Me.hgValeLiquidado, System.ComponentModel.ISupportInitialize).EndInit()
    Me.hgValeLiquidado.ResumeLayout(False)
    CType(Me.dtgVales, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.hgOperacionLiquidado.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.hgOperacionLiquidado.Panel.ResumeLayout(False)
    CType(Me.hgOperacionLiquidado, System.ComponentModel.ISupportInitialize).EndInit()
    Me.hgOperacionLiquidado.ResumeLayout(False)
    CType(Me.dtgOperacion, System.ComponentModel.ISupportInitialize).EndInit()
    Me.MenuBar.ResumeLayout(False)
    Me.MenuBar.PerformLayout()
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
  Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
  Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
  Friend WithEvents dtgOperacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents hgValeLiquidado As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents hgOperacionLiquidado As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents dtgVales As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents NSLCMB_V As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NVLGRF_V As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FSLCMB_V As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TGRFO_V As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CTPCMB_V As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FCRCMB_V As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents QGLNCM_V As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CSTGLN_V As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents SESSLC_V As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NLQCMB As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TCMPCL As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NOPRCN As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents RUTA As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CTPCMB As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NKMRCR As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents QGLNCM As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
