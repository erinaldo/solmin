<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPerfilPlanta
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
    Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPerfilPlanta))
    Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.dgvPerfilPlanta = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.MMCUSR3 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CCMPN = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CPLNDV1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CDVSN = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CHK_PLANTA = New System.Windows.Forms.DataGridViewCheckBoxColumn
    Me.COMPANIA = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DIVISION = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.PLANTA = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.MMCAPL1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CRGVTA = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CSCDSP = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
    Me.btncheck = New System.Windows.Forms.ToolStripButton
    Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
    Me.btnManBuscar = New System.Windows.Forms.ToolStripButton
    Me.btnManGuardar = New System.Windows.Forms.ToolStripButton
    Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.UcAyudaDivision = New Ransa.Utilitario.ucAyuda
    Me.UcAyudaCompania = New Ransa.Utilitario.ucAyuda
    Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.Uc_CboUsuario1 = New Ransa.Controls.Menu.uc_CboUsuario
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    CType(Me.dgvPerfilPlanta, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.ToolStrip1.SuspendLayout()
    CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonHeaderGroup1.Panel.SuspendLayout()
    Me.KryptonHeaderGroup1.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.dgvPerfilPlanta)
    Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
    Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(953, 534)
    Me.KryptonPanel.TabIndex = 0
    '
    'dgvPerfilPlanta
    '
    Me.dgvPerfilPlanta.AllowUserToAddRows = False
    Me.dgvPerfilPlanta.AllowUserToDeleteRows = False
    Me.dgvPerfilPlanta.AllowUserToResizeColumns = False
    Me.dgvPerfilPlanta.AllowUserToResizeRows = False
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dgvPerfilPlanta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
    Me.dgvPerfilPlanta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
    Me.dgvPerfilPlanta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
    Me.dgvPerfilPlanta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MMCUSR3, Me.CCMPN, Me.CPLNDV1, Me.CDVSN, Me.CHK_PLANTA, Me.COMPANIA, Me.DIVISION, Me.PLANTA, Me.MMCAPL1, Me.CRGVTA, Me.CSCDSP})
    Me.dgvPerfilPlanta.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dgvPerfilPlanta.Location = New System.Drawing.Point(0, 76)
    Me.dgvPerfilPlanta.MultiSelect = False
    Me.dgvPerfilPlanta.Name = "dgvPerfilPlanta"
    Me.dgvPerfilPlanta.RowHeadersWidth = 10
    DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    Me.dgvPerfilPlanta.RowsDefaultCellStyle = DataGridViewCellStyle8
    Me.dgvPerfilPlanta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvPerfilPlanta.Size = New System.Drawing.Size(953, 458)
    Me.dgvPerfilPlanta.StateCommon.Background.Color1 = System.Drawing.Color.White
    Me.dgvPerfilPlanta.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.dgvPerfilPlanta.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.SystemColors.WindowText
    Me.dgvPerfilPlanta.TabIndex = 77
    '
    'MMCUSR3
    '
    Me.MMCUSR3.DataPropertyName = "MMCUSR"
    Me.MMCUSR3.HeaderText = "MMCUSR"
    Me.MMCUSR3.Name = "MMCUSR3"
    Me.MMCUSR3.ReadOnly = True
    Me.MMCUSR3.Visible = False
    '
    'CCMPN
    '
    Me.CCMPN.DataPropertyName = "CCMPN"
    Me.CCMPN.HeaderText = "CCMPN"
    Me.CCMPN.Name = "CCMPN"
    Me.CCMPN.ReadOnly = True
    Me.CCMPN.Visible = False
    '
    'CPLNDV1
    '
    Me.CPLNDV1.DataPropertyName = "CPLNDV"
    Me.CPLNDV1.HeaderText = "CPLNDV"
    Me.CPLNDV1.Name = "CPLNDV1"
    Me.CPLNDV1.ReadOnly = True
    Me.CPLNDV1.Visible = False
    '
    'CDVSN
    '
    Me.CDVSN.DataPropertyName = "CDVSN"
    Me.CDVSN.HeaderText = "CDVSN"
    Me.CDVSN.Name = "CDVSN"
    Me.CDVSN.ReadOnly = True
    Me.CDVSN.Visible = False
    '
    'CHK_PLANTA
    '
    Me.CHK_PLANTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.CHK_PLANTA.HeaderText = "Check"
    Me.CHK_PLANTA.MinimumWidth = 50
    Me.CHK_PLANTA.Name = "CHK_PLANTA"
    Me.CHK_PLANTA.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.CHK_PLANTA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.CHK_PLANTA.Width = 67
    '
    'COMPANIA
    '
    Me.COMPANIA.DataPropertyName = "COMPANIA"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    Me.COMPANIA.DefaultCellStyle = DataGridViewCellStyle2
    Me.COMPANIA.HeaderText = "Compañia"
    Me.COMPANIA.MinimumWidth = 220
    Me.COMPANIA.Name = "COMPANIA"
    Me.COMPANIA.ReadOnly = True
    '
    'DIVISION
    '
    Me.DIVISION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
    Me.DIVISION.DataPropertyName = "DIVISION"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    Me.DIVISION.DefaultCellStyle = DataGridViewCellStyle3
    Me.DIVISION.HeaderText = "División"
    Me.DIVISION.MinimumWidth = 220
    Me.DIVISION.Name = "DIVISION"
    Me.DIVISION.ReadOnly = True
    Me.DIVISION.Width = 220
    '
    'PLANTA
    '
    Me.PLANTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
    Me.PLANTA.DataPropertyName = "PLANTA"
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    Me.PLANTA.DefaultCellStyle = DataGridViewCellStyle4
    Me.PLANTA.HeaderText = "Planta"
    Me.PLANTA.MinimumWidth = 220
    Me.PLANTA.Name = "PLANTA"
    Me.PLANTA.ReadOnly = True
    Me.PLANTA.Width = 220
    '
    'MMCAPL1
    '
    Me.MMCAPL1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
    Me.MMCAPL1.DataPropertyName = "MMCAPL"
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.MMCAPL1.DefaultCellStyle = DataGridViewCellStyle5
    Me.MMCAPL1.HeaderText = "Código Aplicativo"
    Me.MMCAPL1.MinimumWidth = 120
    Me.MMCAPL1.Name = "MMCAPL1"
    Me.MMCAPL1.ReadOnly = True
    Me.MMCAPL1.Width = 120
    '
    'CRGVTA
    '
    Me.CRGVTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
    Me.CRGVTA.DataPropertyName = "CRGVTA"
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.CRGVTA.DefaultCellStyle = DataGridViewCellStyle6
    Me.CRGVTA.HeaderText = "Código Región Venta"
    Me.CRGVTA.MinimumWidth = 120
    Me.CRGVTA.Name = "CRGVTA"
    Me.CRGVTA.ReadOnly = True
    Me.CRGVTA.Width = 120
    '
    'CSCDSP
    '
    Me.CSCDSP.DataPropertyName = "CSCDSP"
    DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.CSCDSP.DefaultCellStyle = DataGridViewCellStyle7
    Me.CSCDSP.HeaderText = "Código Sociedad SAP"
    Me.CSCDSP.MinimumWidth = 120
    Me.CSCDSP.Name = "CSCDSP"
    Me.CSCDSP.ReadOnly = True
    '
    'ToolStrip1
    '
    Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btncheck, Me.ToolStripLabel1, Me.btnManBuscar, Me.btnManGuardar})
    Me.ToolStrip1.Location = New System.Drawing.Point(0, 51)
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.Size = New System.Drawing.Size(953, 25)
    Me.ToolStrip1.TabIndex = 76
    Me.ToolStrip1.Text = "ToolStrip1"
    '
    'btncheck
    '
    Me.btncheck.Image = Global.Ransa.Controls.Menu.My.Resources.Resources.btnNoMarcarItems
    Me.btncheck.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btncheck.Name = "btncheck"
    Me.btncheck.Size = New System.Drawing.Size(92, 22)
    Me.btncheck.Text = "Check Todos"
    '
    'ToolStripLabel1
    '
    Me.ToolStripLabel1.Name = "ToolStripLabel1"
    Me.ToolStripLabel1.Size = New System.Drawing.Size(50, 22)
    Me.ToolStripLabel1.Text = " Accesos"
    '
    'btnManBuscar
    '
    Me.btnManBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnManBuscar.Image = CType(resources.GetObject("btnManBuscar.Image"), System.Drawing.Image)
    Me.btnManBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnManBuscar.Name = "btnManBuscar"
    Me.btnManBuscar.Size = New System.Drawing.Size(61, 22)
    Me.btnManBuscar.Text = "Buscar"
    '
    'btnManGuardar
    '
    Me.btnManGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnManGuardar.Image = CType(resources.GetObject("btnManGuardar.Image"), System.Drawing.Image)
    Me.btnManGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnManGuardar.Name = "btnManGuardar"
    Me.btnManGuardar.Size = New System.Drawing.Size(69, 22)
    Me.btnManGuardar.Text = "Guardar"
    '
    'KryptonHeaderGroup1
    '
    Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
    Me.KryptonHeaderGroup1.HeaderVisiblePrimary = False
    Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
    Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
    Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
    '
    'KryptonHeaderGroup1.Panel
    '
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Uc_CboUsuario1)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.UcAyudaDivision)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.UcAyudaCompania)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel3)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel2)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
    Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(953, 51)
    Me.KryptonHeaderGroup1.TabIndex = 0
    Me.KryptonHeaderGroup1.Text = "Heading"
    Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
    Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Heading"
    Me.KryptonHeaderGroup1.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup1.ValuesPrimary.Image"), System.Drawing.Image)
    Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
    Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
    Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
    '
    'UcAyudaDivision
    '
    Me.UcAyudaDivision.BackColor = System.Drawing.Color.Transparent
    Me.UcAyudaDivision.DataSource = Nothing
    Me.UcAyudaDivision.DispleyMember = ""
    Me.UcAyudaDivision.ListColumnas = Nothing
    Me.UcAyudaDivision.Location = New System.Drawing.Point(716, 14)
    Me.UcAyudaDivision.Name = "UcAyudaDivision"
    Me.UcAyudaDivision.Obligatorio = False
    Me.UcAyudaDivision.Size = New System.Drawing.Size(215, 21)
    Me.UcAyudaDivision.TabIndex = 2
    Me.UcAyudaDivision.ValueMember = ""
    '
    'UcAyudaCompania
    '
    Me.UcAyudaCompania.BackColor = System.Drawing.Color.Transparent
    Me.UcAyudaCompania.DataSource = Nothing
    Me.UcAyudaCompania.DispleyMember = ""
    Me.UcAyudaCompania.ListColumnas = Nothing
    Me.UcAyudaCompania.Location = New System.Drawing.Point(427, 14)
    Me.UcAyudaCompania.Name = "UcAyudaCompania"
    Me.UcAyudaCompania.Obligatorio = False
    Me.UcAyudaCompania.Size = New System.Drawing.Size(211, 21)
    Me.UcAyudaCompania.TabIndex = 1
    Me.UcAyudaCompania.ValueMember = ""
    '
    'KryptonLabel3
    '
    Me.KryptonLabel3.Location = New System.Drawing.Point(655, 16)
    Me.KryptonLabel3.Name = "KryptonLabel3"
    Me.KryptonLabel3.Size = New System.Drawing.Size(55, 19)
    Me.KryptonLabel3.TabIndex = 69
    Me.KryptonLabel3.Text = "División :"
    Me.KryptonLabel3.Values.ExtraText = ""
    Me.KryptonLabel3.Values.Image = Nothing
    Me.KryptonLabel3.Values.Text = "División :"
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(355, 16)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(66, 19)
    Me.KryptonLabel2.TabIndex = 69
    Me.KryptonLabel2.Text = "Compañia :"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "Compañia :"
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(22, 16)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(91, 19)
    Me.KryptonLabel1.TabIndex = 69
    Me.KryptonLabel1.Text = "Usuario Origen :"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Usuario Origen :"
    '
    'Uc_CboUsuario1
    '
    Me.Uc_CboUsuario1.Location = New System.Drawing.Point(119, 13)
    Me.Uc_CboUsuario1.Name = "Uc_CboUsuario1"
    Me.Uc_CboUsuario1.pPSMMCUSR = ""
    Me.Uc_CboUsuario1.pPSMMNUSR = ""
    Me.Uc_CboUsuario1.Size = New System.Drawing.Size(230, 22)
    Me.Uc_CboUsuario1.TabIndex = 0
    '
    'FrmPerfilPlanta
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(953, 534)
    Me.Controls.Add(Me.KryptonPanel)
    Me.Name = "FrmPerfilPlanta"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Perfil Planta"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    Me.KryptonPanel.PerformLayout()
    CType(Me.dgvPerfilPlanta, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ToolStrip1.ResumeLayout(False)
    Me.ToolStrip1.PerformLayout()
    CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
    Me.KryptonHeaderGroup1.Panel.PerformLayout()
    CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonHeaderGroup1.ResumeLayout(False)
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
  Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents UcAyudaDivision As Ransa.Utilitario.ucAyuda
  Friend WithEvents UcAyudaCompania As Ransa.Utilitario.ucAyuda
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
  Friend WithEvents btncheck As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents btnManBuscar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnManGuardar As System.Windows.Forms.ToolStripButton
  Friend WithEvents dgvPerfilPlanta As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents MMCUSR3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CCMPN As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CPLNDV1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CDVSN As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CHK_PLANTA As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents COMPANIA As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DIVISION As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents PLANTA As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents MMCAPL1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CRGVTA As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CSCDSP As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Uc_CboUsuario1 As Ransa.Controls.Menu.uc_CboUsuario
End Class
