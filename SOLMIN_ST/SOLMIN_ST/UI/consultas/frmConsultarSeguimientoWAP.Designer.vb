<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarSeguimientoWAP
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    Public ReportIndex As Integer = 0

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultarSeguimientoWAP))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.HeaderGroupTabs = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.gwdDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.MenuBar = New System.Windows.Forms.ToolStrip
        Me.btnProcesarReporte = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.btnExportarExcel = New System.Windows.Forms.ToolStripButton
        Me.HeaderGroupFiltro = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel21 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel20 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtPlaca = New SOLMIN_ST.TextField
        Me.KryptonLabel19 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cboRolWap = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.KryptonLabel18 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel17 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtUsuarioWap = New CodeTextBox.CodeTextBox
        Me.cboGrupoSeguimiento = New CodeTextBox.CodeTextBox
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.HeaderGroupTabs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderGroupTabs.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderGroupTabs.Panel.SuspendLayout()
        Me.HeaderGroupTabs.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        CType(Me.HeaderGroupFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderGroupFiltro.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderGroupFiltro.Panel.SuspendLayout()
        Me.HeaderGroupFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.HeaderGroupTabs)
        Me.KryptonPanel.Controls.Add(Me.HeaderGroupFiltro)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(954, 378)
        Me.KryptonPanel.TabIndex = 0
        '
        'HeaderGroupTabs
        '
        Me.HeaderGroupTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderGroupTabs.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HeaderGroupTabs.Location = New System.Drawing.Point(0, 83)
        Me.HeaderGroupTabs.Name = "HeaderGroupTabs"
        '
        'HeaderGroupTabs.Panel
        '
        Me.HeaderGroupTabs.Panel.Controls.Add(Me.TabControl1)
        Me.HeaderGroupTabs.Panel.Controls.Add(Me.Panel2)
        Me.HeaderGroupTabs.Size = New System.Drawing.Size(954, 295)
        Me.HeaderGroupTabs.TabIndex = 1
        Me.HeaderGroupTabs.Text = "Resultados"
        Me.HeaderGroupTabs.ValuesPrimary.Description = ""
        Me.HeaderGroupTabs.ValuesPrimary.Heading = "Resultados"
        Me.HeaderGroupTabs.ValuesPrimary.Image = Nothing
        Me.HeaderGroupTabs.ValuesSecondary.Description = ""
        Me.HeaderGroupTabs.ValuesSecondary.Heading = ""
        Me.HeaderGroupTabs.ValuesSecondary.Image = Nothing
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.Location = New System.Drawing.Point(0, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(952, 248)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gwdDatos)
        Me.TabPage1.ImageIndex = 4
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(944, 221)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Consulta en Pantalla"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'gwdDatos
        '
        Me.gwdDatos.AccessibleDescription = ""
        Me.gwdDatos.AllowUserToAddRows = False
        Me.gwdDatos.AllowUserToDeleteRows = False
        Me.gwdDatos.AllowUserToResizeColumns = False
        Me.gwdDatos.AllowUserToResizeRows = False
        Me.gwdDatos.ColumnHeadersHeight = 20
        Me.gwdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gwdDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gwdDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.gwdDatos.Location = New System.Drawing.Point(3, 3)
        Me.gwdDatos.MultiSelect = False
        Me.gwdDatos.Name = "gwdDatos"
        Me.gwdDatos.ReadOnly = True
        Me.gwdDatos.RowHeadersWidth = 20
        Me.gwdDatos.RowTemplate.Height = 16
        Me.gwdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gwdDatos.Size = New System.Drawing.Size(938, 215)
        Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwdDatos.TabIndex = 6
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "1downarrow1.png")
        Me.ImageList1.Images.SetKeyName(1, "1rightarrow.png")
        Me.ImageList1.Images.SetKeyName(2, "1downarrow.png")
        Me.ImageList1.Images.SetKeyName(3, "webexport.png")
        Me.ImageList1.Images.SetKeyName(4, "spreadsheet.png")
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.Controls.Add(Me.MenuBar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(952, 25)
        Me.Panel2.TabIndex = 4
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnProcesarReporte, Me.ToolStripSeparator1, Me.btnImprimir, Me.ToolStripSeparator4, Me.btnExportarExcel})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(952, 25)
        Me.MenuBar.TabIndex = 2
        Me.MenuBar.Text = "ToolStrip1"
        '
        'btnProcesarReporte
        '
        Me.btnProcesarReporte.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnProcesarReporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProcesarReporte.Name = "btnProcesarReporte"
        Me.btnProcesarReporte.Size = New System.Drawing.Size(110, 22)
        Me.btnProcesarReporte.Text = "Procesar Reporte"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.SOLMIN_ST.My.Resources.Resources.printer2
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(103, 22)
        Me.btnImprimir.Text = "Imprimir Reporte"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Image = Global.SOLMIN_ST.My.Resources.Resources.excelicon
        Me.btnExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(95, 22)
        Me.btnExportarExcel.Text = "Exportar Excel"
        '
        'HeaderGroupFiltro
        '
        Me.HeaderGroupFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderGroupFiltro.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HeaderGroupFiltro.Location = New System.Drawing.Point(0, 0)
        Me.HeaderGroupFiltro.Name = "HeaderGroupFiltro"
        '
        'HeaderGroupFiltro.Panel
        '
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.cboGrupoSeguimiento)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel1)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.dtpFechaInicio)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel21)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel2)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.dtpFechaFin)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel20)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.txtPlaca)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel19)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.txtUsuarioWap)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.cboRolWap)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel18)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel17)
        Me.HeaderGroupFiltro.Size = New System.Drawing.Size(954, 83)
        Me.HeaderGroupFiltro.TabIndex = 0
        Me.HeaderGroupFiltro.Text = "Opciones de filtro"
        Me.HeaderGroupFiltro.ValuesPrimary.Description = ""
        Me.HeaderGroupFiltro.ValuesPrimary.Heading = "Opciones de filtro"
        Me.HeaderGroupFiltro.ValuesPrimary.Image = Nothing
        Me.HeaderGroupFiltro.ValuesSecondary.Description = ""
        Me.HeaderGroupFiltro.ValuesSecondary.Heading = ""
        Me.HeaderGroupFiltro.ValuesSecondary.Image = Nothing
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(148, 24)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(84, 21)
        Me.dtpFechaInicio.TabIndex = 106
        '
        'KryptonLabel21
        '
        Me.KryptonLabel21.Location = New System.Drawing.Point(232, 25)
        Me.KryptonLabel21.Name = "KryptonLabel21"
        Me.KryptonLabel21.Size = New System.Drawing.Size(19, 16)
        Me.KryptonLabel21.TabIndex = 109
        Me.KryptonLabel21.Text = "al"
        Me.KryptonLabel21.Values.ExtraText = ""
        Me.KryptonLabel21.Values.Image = Nothing
        Me.KryptonLabel21.Values.Text = "al"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(124, 25)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(25, 16)
        Me.KryptonLabel2.TabIndex = 108
        Me.KryptonLabel2.Text = "del"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "del"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(252, 24)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(84, 21)
        Me.dtpFechaFin.TabIndex = 107
        '
        'KryptonLabel20
        '
        Me.KryptonLabel20.Location = New System.Drawing.Point(128, 4)
        Me.KryptonLabel20.Name = "KryptonLabel20"
        Me.KryptonLabel20.Size = New System.Drawing.Size(112, 17)
        Me.KryptonLabel20.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel20.TabIndex = 105
        Me.KryptonLabel20.Text = "Fecha de Registro"
        Me.KryptonLabel20.Values.ExtraText = ""
        Me.KryptonLabel20.Values.Image = Nothing
        Me.KryptonLabel20.Values.Text = "Fecha de Registro"
        '
        'txtPlaca
        '
        Me.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlaca.Location = New System.Drawing.Point(4, 24)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(108, 19)
        Me.txtPlaca.TabIndex = 104
        Me.txtPlaca.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'KryptonLabel19
        '
        Me.KryptonLabel19.Location = New System.Drawing.Point(4, 4)
        Me.KryptonLabel19.Name = "KryptonLabel19"
        Me.KryptonLabel19.Size = New System.Drawing.Size(80, 17)
        Me.KryptonLabel19.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel19.TabIndex = 103
        Me.KryptonLabel19.Text = "Placa Tracto"
        Me.KryptonLabel19.Values.ExtraText = ""
        Me.KryptonLabel19.Values.Image = Nothing
        Me.KryptonLabel19.Values.Text = "Placa Tracto"
        '
        'cboRolWap
        '
        Me.cboRolWap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRolWap.DropDownWidth = 121
        Me.cboRolWap.FormattingEnabled = False
        Me.cboRolWap.ItemHeight = 13
        Me.cboRolWap.Location = New System.Drawing.Point(832, 28)
        Me.cboRolWap.Name = "cboRolWap"
        Me.cboRolWap.Size = New System.Drawing.Size(56, 21)
        Me.cboRolWap.TabIndex = 101
        Me.cboRolWap.Visible = False
        '
        'KryptonLabel18
        '
        Me.KryptonLabel18.Location = New System.Drawing.Point(888, 12)
        Me.KryptonLabel18.Name = "KryptonLabel18"
        Me.KryptonLabel18.Size = New System.Drawing.Size(54, 17)
        Me.KryptonLabel18.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel18.TabIndex = 100
        Me.KryptonLabel18.Text = "Usuario"
        Me.KryptonLabel18.Values.ExtraText = ""
        Me.KryptonLabel18.Values.Image = Nothing
        Me.KryptonLabel18.Values.Text = "Usuario"
        Me.KryptonLabel18.Visible = False
        '
        'KryptonLabel17
        '
        Me.KryptonLabel17.Location = New System.Drawing.Point(828, 12)
        Me.KryptonLabel17.Name = "KryptonLabel17"
        Me.KryptonLabel17.Size = New System.Drawing.Size(58, 17)
        Me.KryptonLabel17.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel17.TabIndex = 99
        Me.KryptonLabel17.Text = "Rol Wap"
        Me.KryptonLabel17.Values.ExtraText = ""
        Me.KryptonLabel17.Values.Image = Nothing
        Me.KryptonLabel17.Values.Text = "Rol Wap"
        Me.KryptonLabel17.Visible = False
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(344, 4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(166, 17)
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 110
        Me.KryptonLabel1.Text = "Grupo de Seguimiento Wap"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Grupo de Seguimiento Wap"
        '
        'txtUsuarioWap
        '
        Me.txtUsuarioWap.Codigo = ""
        Me.txtUsuarioWap.ControlHeight = 23
        Me.txtUsuarioWap.ControlImage = True
        Me.txtUsuarioWap.ControlReadOnly = False
        Me.txtUsuarioWap.Descripcion = ""
        Me.txtUsuarioWap.DisplayColumnVisible = True
        Me.txtUsuarioWap.DisplayMember = ""
        Me.txtUsuarioWap.KeyColumnWidth = 100
        Me.txtUsuarioWap.KeyField = ""
        Me.txtUsuarioWap.KeySearch = True
        Me.txtUsuarioWap.Location = New System.Drawing.Point(888, 28)
        Me.txtUsuarioWap.Name = "txtUsuarioWap"
        Me.txtUsuarioWap.Size = New System.Drawing.Size(56, 23)
        Me.txtUsuarioWap.TabIndex = 102
        Me.txtUsuarioWap.TextBackColor = System.Drawing.Color.Empty
        Me.txtUsuarioWap.TextForeColor = System.Drawing.Color.Empty
        Me.txtUsuarioWap.ValueColumnVisible = True
        Me.txtUsuarioWap.ValueColumnWidth = 600
        Me.txtUsuarioWap.ValueField = ""
        Me.txtUsuarioWap.ValueMember = ""
        Me.txtUsuarioWap.ValueSearch = True
        Me.txtUsuarioWap.Visible = False
        '
        'cboGrupoSeguimiento
        '
        Me.cboGrupoSeguimiento.Codigo = ""
        Me.cboGrupoSeguimiento.ControlHeight = 23
        Me.cboGrupoSeguimiento.ControlImage = True
        Me.cboGrupoSeguimiento.ControlReadOnly = False
        Me.cboGrupoSeguimiento.Descripcion = ""
        Me.cboGrupoSeguimiento.DisplayColumnVisible = True
        Me.cboGrupoSeguimiento.DisplayMember = ""
        Me.cboGrupoSeguimiento.KeyColumnWidth = 100
        Me.cboGrupoSeguimiento.KeyField = ""
        Me.cboGrupoSeguimiento.KeySearch = True
        Me.cboGrupoSeguimiento.Location = New System.Drawing.Point(348, 24)
        Me.cboGrupoSeguimiento.Name = "cboGrupoSeguimiento"
        Me.cboGrupoSeguimiento.Size = New System.Drawing.Size(200, 23)
        Me.cboGrupoSeguimiento.TabIndex = 111
        Me.cboGrupoSeguimiento.TextBackColor = System.Drawing.Color.Empty
        Me.cboGrupoSeguimiento.TextForeColor = System.Drawing.Color.Empty
        Me.cboGrupoSeguimiento.ValueColumnVisible = True
        Me.cboGrupoSeguimiento.ValueColumnWidth = 600
        Me.cboGrupoSeguimiento.ValueField = ""
        Me.cboGrupoSeguimiento.ValueMember = ""
        Me.cboGrupoSeguimiento.ValueSearch = True
        '
        'frmConsultarSeguimientoWAP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 378)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmConsultarSeguimientoWAP"
        Me.Text = "Consultas Seguimiento WAP"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.HeaderGroupTabs.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderGroupTabs.Panel.ResumeLayout(False)
        Me.HeaderGroupTabs.Panel.PerformLayout()
        CType(Me.HeaderGroupTabs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderGroupTabs.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        CType(Me.HeaderGroupFiltro.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderGroupFiltro.Panel.ResumeLayout(False)
        Me.HeaderGroupFiltro.Panel.PerformLayout()
        CType(Me.HeaderGroupFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderGroupFiltro.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal ReportIndex As Integer)

        Me.ReportIndex = ReportIndex
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents HeaderGroupTabs As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents HeaderGroupFiltro As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnProcesarReporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtUsuarioWap As CodeTextBox.CodeTextBox
    Friend WithEvents cboRolWap As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel18 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel17 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPlaca As SOLMIN_ST.TextField
    Friend WithEvents KryptonLabel19 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel21 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel20 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents gwdDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboGrupoSeguimiento As CodeTextBox.CodeTextBox
End Class
