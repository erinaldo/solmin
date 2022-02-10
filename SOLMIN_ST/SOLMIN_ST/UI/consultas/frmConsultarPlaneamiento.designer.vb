<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarPlaneamiento
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
        Me.HeaderGroupTabs = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.gwdDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.MenuBar = New System.Windows.Forms.ToolStrip
        Me.btnProcesarReporte = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.btnExportarExcel = New System.Windows.Forms.ToolStripButton
        Me.HeaderGroupFiltro = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel20 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroPlaneamiento = New System.Windows.Forms.TextBox
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel19 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFechaInicioPlaneamiento = New System.Windows.Forms.DateTimePicker
        Me.cboEstado = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.dtpFechaFinPlaneamiento = New System.Windows.Forms.DateTimePicker
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.cboPlanta = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.cboDivision = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.cboCia = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
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
        Me.KryptonPanel.Size = New System.Drawing.Size(822, 523)
        Me.KryptonPanel.TabIndex = 0
        '
        'HeaderGroupTabs
        '
        Me.HeaderGroupTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderGroupTabs.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HeaderGroupTabs.Location = New System.Drawing.Point(0, 124)
        Me.HeaderGroupTabs.Name = "HeaderGroupTabs"
        '
        'HeaderGroupTabs.Panel
        '
        Me.HeaderGroupTabs.Panel.Controls.Add(Me.TabControl1)
        Me.HeaderGroupTabs.Panel.Controls.Add(Me.Panel2)
        Me.HeaderGroupTabs.Size = New System.Drawing.Size(822, 399)
        Me.HeaderGroupTabs.TabIndex = 2
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
        Me.TabControl1.Location = New System.Drawing.Point(0, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(820, 352)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gwdDatos)
        Me.TabPage1.ImageIndex = 4
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(812, 326)
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
        Me.gwdDatos.Size = New System.Drawing.Size(806, 320)
        Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwdDatos.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.Controls.Add(Me.MenuBar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(820, 25)
        Me.Panel2.TabIndex = 4
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnProcesarReporte, Me.ToolStripSeparator1, Me.btnImprimir, Me.ToolStripSeparator4, Me.btnExportarExcel})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(820, 25)
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
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel3)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel1)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel20)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.txtNroPlaneamiento)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel4)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel19)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.dtpFechaInicioPlaneamiento)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.cboEstado)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.dtpFechaFinPlaneamiento)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.txtCliente)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.cboPlanta)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.cboDivision)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.cboCia)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel5)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel6)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel2)
        Me.HeaderGroupFiltro.Size = New System.Drawing.Size(822, 124)
        Me.HeaderGroupFiltro.TabIndex = 0
        Me.HeaderGroupFiltro.Text = "Opciones de filtro"
        Me.HeaderGroupFiltro.ValuesPrimary.Description = ""
        Me.HeaderGroupFiltro.ValuesPrimary.Heading = "Opciones de filtro"
        Me.HeaderGroupFiltro.ValuesPrimary.Image = Nothing
        Me.HeaderGroupFiltro.ValuesSecondary.Description = ""
        Me.HeaderGroupFiltro.ValuesSecondary.Heading = ""
        Me.HeaderGroupFiltro.ValuesSecondary.Image = Nothing
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(584, 21)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(41, 17)
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 103
        Me.KryptonLabel3.Text = "Planta"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Planta"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(320, 21)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(49, 17)
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 103
        Me.KryptonLabel1.Text = "División"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "División"
        '
        'KryptonLabel20
        '
        Me.KryptonLabel20.Location = New System.Drawing.Point(11, 75)
        Me.KryptonLabel20.Name = "KryptonLabel20"
        Me.KryptonLabel20.Size = New System.Drawing.Size(26, 17)
        Me.KryptonLabel20.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel20.TabIndex = 105
        Me.KryptonLabel20.Text = "Del"
        Me.KryptonLabel20.Values.ExtraText = ""
        Me.KryptonLabel20.Values.Image = Nothing
        Me.KryptonLabel20.Values.Text = "Del"
        '
        'txtNroPlaneamiento
        '
        Me.txtNroPlaneamiento.Location = New System.Drawing.Point(441, 50)
        Me.txtNroPlaneamiento.Name = "txtNroPlaneamiento"
        Me.txtNroPlaneamiento.Size = New System.Drawing.Size(122, 20)
        Me.txtNroPlaneamiento.TabIndex = 4
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(128, 75)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(20, 17)
        Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 105
        Me.KryptonLabel4.Text = "Al"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Al"
        '
        'KryptonLabel19
        '
        Me.KryptonLabel19.Location = New System.Drawing.Point(11, 21)
        Me.KryptonLabel19.Name = "KryptonLabel19"
        Me.KryptonLabel19.Size = New System.Drawing.Size(60, 17)
        Me.KryptonLabel19.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel19.TabIndex = 103
        Me.KryptonLabel19.Text = "Compañía"
        Me.KryptonLabel19.Values.ExtraText = ""
        Me.KryptonLabel19.Values.Image = Nothing
        Me.KryptonLabel19.Values.Text = "Compañía"
        '
        'dtpFechaInicioPlaneamiento
        '
        Me.dtpFechaInicioPlaneamiento.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicioPlaneamiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicioPlaneamiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicioPlaneamiento.Location = New System.Drawing.Point(44, 73)
        Me.dtpFechaInicioPlaneamiento.Name = "dtpFechaInicioPlaneamiento"
        Me.dtpFechaInicioPlaneamiento.Size = New System.Drawing.Size(84, 21)
        Me.dtpFechaInicioPlaneamiento.TabIndex = 6
        '
        'cboEstado
        '
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.DropDownWidth = 121
        Me.cboEstado.FormattingEnabled = False
        Me.cboEstado.ItemHeight = 13
        Me.cboEstado.Items.AddRange(New Object() {"A", "P"})
        Me.cboEstado.Location = New System.Drawing.Point(705, 48)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(95, 21)
        Me.cboEstado.TabIndex = 5
        '
        'dtpFechaFinPlaneamiento
        '
        Me.dtpFechaFinPlaneamiento.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFinPlaneamiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFinPlaneamiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinPlaneamiento.Location = New System.Drawing.Point(152, 73)
        Me.dtpFechaFinPlaneamiento.Name = "dtpFechaFinPlaneamiento"
        Me.dtpFechaFinPlaneamiento.Size = New System.Drawing.Size(84, 21)
        Me.dtpFechaFinPlaneamiento.TabIndex = 7
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.Location = New System.Drawing.Point(133, 48)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = False
        Me.txtCliente.pRequerido = False
        Me.txtCliente.Size = New System.Drawing.Size(176, 19)
        Me.txtCliente.TabIndex = 3
        '
        'cboPlanta
        '
        Me.cboPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPlanta.DropDownWidth = 121
        Me.cboPlanta.FormattingEnabled = False
        Me.cboPlanta.ItemHeight = 13
        Me.cboPlanta.Location = New System.Drawing.Point(631, 17)
        Me.cboPlanta.Name = "cboPlanta"
        Me.cboPlanta.Size = New System.Drawing.Size(169, 21)
        Me.cboPlanta.TabIndex = 2
        '
        'cboDivision
        '
        Me.cboDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDivision.DropDownWidth = 121
        Me.cboDivision.FormattingEnabled = False
        Me.cboDivision.ItemHeight = 13
        Me.cboDivision.Location = New System.Drawing.Point(375, 17)
        Me.cboDivision.Name = "cboDivision"
        Me.cboDivision.Size = New System.Drawing.Size(188, 21)
        Me.cboDivision.TabIndex = 1
        '
        'cboCia
        '
        Me.cboCia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCia.DropDownWidth = 121
        Me.cboCia.FormattingEnabled = False
        Me.cboCia.ItemHeight = 13
        Me.cboCia.Location = New System.Drawing.Point(133, 17)
        Me.cboCia.Name = "cboCia"
        Me.cboCia.Size = New System.Drawing.Size(176, 21)
        Me.cboCia.TabIndex = 0
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(11, 48)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(98, 17)
        Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.TabIndex = 105
        Me.KryptonLabel5.Text = "Código de Cliente"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Código de Cliente"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(320, 50)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(115, 17)
        Me.KryptonLabel6.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel6.TabIndex = 105
        Me.KryptonLabel6.Text = "Nro de Planeamiento"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Nro de Planeamiento"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(584, 50)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(115, 17)
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 105
        Me.KryptonLabel2.Text = "Estado Planeamiento"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Estado Planeamiento"
        '
        'frmConsultarPlaneamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 523)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmConsultarPlaneamiento"
        Me.Text = "Consultar Planeamiento"
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

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents HeaderGroupFiltro As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents dtpFechaInicioPlaneamiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaFinPlaneamiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel20 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel19 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboCia As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents HeaderGroupTabs As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents gwdDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnProcesarReporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboPlanta As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents cboDivision As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboEstado As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents txtNroPlaneamiento As System.Windows.Forms.TextBox
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
End Class
