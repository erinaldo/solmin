<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignacionOrdenServicio
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsignacionOrdenServicio))
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.HGDatosOperacion = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.ButtonSpecHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.ctbCompania = New CodeTextBox.CodeTextBox
    Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.ctbPlanta = New CodeTextBox.CodeTextBox
    Me.ctbDivision = New CodeTextBox.CodeTextBox
    Me.ToolBar = New System.Windows.Forms.ToolStrip
    Me.btnGenerarOperacion = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.btnCerrar = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
    Me.gwdDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.NroSolicitud = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.NroOrdenServicio = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.UnidadesAsignadas = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.Status = New System.Windows.Forms.DataGridViewImageColumn
    Me.NroOperacion = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    CType(Me.HGDatosOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.HGDatosOperacion.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.HGDatosOperacion.Panel.SuspendLayout()
    Me.HGDatosOperacion.SuspendLayout()
    Me.ToolBar.SuspendLayout()
    CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.HGDatosOperacion)
    Me.KryptonPanel.Controls.Add(Me.ToolBar)
    Me.KryptonPanel.Controls.Add(Me.gwdDatos)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(885, 452)
    Me.KryptonPanel.TabIndex = 0
    '
    'HGDatosOperacion
    '
    Me.HGDatosOperacion.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.ButtonSpecHeaderGroup1})
    Me.HGDatosOperacion.Dock = System.Windows.Forms.DockStyle.Top
    Me.HGDatosOperacion.HeaderVisiblePrimary = False
    Me.HGDatosOperacion.Location = New System.Drawing.Point(0, 25)
    Me.HGDatosOperacion.Name = "HGDatosOperacion"
    '
    'HGDatosOperacion.Panel
    '
    Me.HGDatosOperacion.Panel.Controls.Add(Me.ctbCompania)
    Me.HGDatosOperacion.Panel.Controls.Add(Me.KryptonLabel3)
    Me.HGDatosOperacion.Panel.Controls.Add(Me.KryptonLabel2)
    Me.HGDatosOperacion.Panel.Controls.Add(Me.KryptonLabel1)
    Me.HGDatosOperacion.Panel.Controls.Add(Me.ctbPlanta)
    Me.HGDatosOperacion.Panel.Controls.Add(Me.ctbDivision)
    Me.HGDatosOperacion.Size = New System.Drawing.Size(885, 70)
    Me.HGDatosOperacion.TabIndex = 2
    Me.HGDatosOperacion.Text = "Heading"
    Me.HGDatosOperacion.ValuesPrimary.Description = ""
    Me.HGDatosOperacion.ValuesPrimary.Heading = "Heading"
    Me.HGDatosOperacion.ValuesPrimary.Image = CType(resources.GetObject("HGDatosOperacion.ValuesPrimary.Image"), System.Drawing.Image)
    Me.HGDatosOperacion.ValuesSecondary.Description = ""
    Me.HGDatosOperacion.ValuesSecondary.Heading = "Description"
    Me.HGDatosOperacion.ValuesSecondary.Image = Nothing
    '
    'ButtonSpecHeaderGroup1
    '
    Me.ButtonSpecHeaderGroup1.ExtraText = ""
    Me.ButtonSpecHeaderGroup1.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
    Me.ButtonSpecHeaderGroup1.Image = Global.SOLMIN_ST.My.Resources.Resources._exit
    Me.ButtonSpecHeaderGroup1.Text = "Cerrar Ventana"
    Me.ButtonSpecHeaderGroup1.ToolTipImage = Nothing
    Me.ButtonSpecHeaderGroup1.UniqueName = "CC61A6A971EF4C02CC61A6A971EF4C02"
    '
    'ctbCompania
    '
    Me.ctbCompania.Codigo = ""
    Me.ctbCompania.ControlHeight = 23
    Me.ctbCompania.ControlImage = True
    Me.ctbCompania.ControlReadOnly = False
    Me.ctbCompania.Descripcion = ""
    Me.ctbCompania.DisplayColumnVisible = True
    Me.ctbCompania.DisplayMember = ""
    Me.ctbCompania.Enabled = False
    Me.ctbCompania.KeyColumnWidth = 100
    Me.ctbCompania.KeyField = ""
    Me.ctbCompania.KeySearch = True
    Me.ctbCompania.Location = New System.Drawing.Point(64, 4)
    Me.ctbCompania.Name = "ctbCompania"
    Me.ctbCompania.Size = New System.Drawing.Size(220, 23)
    Me.ctbCompania.TabIndex = 0
    Me.ctbCompania.TextBackColor = System.Drawing.Color.Empty
    Me.ctbCompania.TextForeColor = System.Drawing.Color.Empty
    Me.ctbCompania.ValueColumnVisible = True
    Me.ctbCompania.ValueColumnWidth = 600
    Me.ctbCompania.ValueField = ""
    Me.ctbCompania.ValueMember = ""
    Me.ctbCompania.ValueSearch = True
    '
    'KryptonLabel3
    '
    Me.KryptonLabel3.Location = New System.Drawing.Point(612, 8)
    Me.KryptonLabel3.Name = "KryptonLabel3"
    Me.KryptonLabel3.Size = New System.Drawing.Size(41, 19)
    Me.KryptonLabel3.TabIndex = 5
    Me.KryptonLabel3.Text = "Planta"
    Me.KryptonLabel3.Values.ExtraText = ""
    Me.KryptonLabel3.Values.Image = Nothing
    Me.KryptonLabel3.Values.Text = "Planta"
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(312, 8)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(50, 19)
    Me.KryptonLabel2.TabIndex = 4
    Me.KryptonLabel2.Text = "División"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "División"
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(4, 8)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(61, 19)
    Me.KryptonLabel1.TabIndex = 3
    Me.KryptonLabel1.Text = "Compañía"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Compañía"
    '
    'ctbPlanta
    '
    Me.ctbPlanta.Codigo = ""
    Me.ctbPlanta.ControlHeight = 23
    Me.ctbPlanta.ControlImage = True
    Me.ctbPlanta.ControlReadOnly = False
    Me.ctbPlanta.Descripcion = ""
    Me.ctbPlanta.DisplayColumnVisible = True
    Me.ctbPlanta.DisplayMember = ""
    Me.ctbPlanta.Enabled = False
    Me.ctbPlanta.KeyColumnWidth = 100
    Me.ctbPlanta.KeyField = ""
    Me.ctbPlanta.KeySearch = True
    Me.ctbPlanta.Location = New System.Drawing.Point(656, 4)
    Me.ctbPlanta.Name = "ctbPlanta"
    Me.ctbPlanta.Size = New System.Drawing.Size(220, 23)
    Me.ctbPlanta.TabIndex = 2
    Me.ctbPlanta.TextBackColor = System.Drawing.Color.Empty
    Me.ctbPlanta.TextForeColor = System.Drawing.Color.Empty
    Me.ctbPlanta.ValueColumnVisible = True
    Me.ctbPlanta.ValueColumnWidth = 600
    Me.ctbPlanta.ValueField = ""
    Me.ctbPlanta.ValueMember = ""
    Me.ctbPlanta.ValueSearch = True
    '
    'ctbDivision
    '
    Me.ctbDivision.Codigo = ""
    Me.ctbDivision.ControlHeight = 23
    Me.ctbDivision.ControlImage = True
    Me.ctbDivision.ControlReadOnly = False
    Me.ctbDivision.Descripcion = ""
    Me.ctbDivision.DisplayColumnVisible = True
    Me.ctbDivision.DisplayMember = ""
    Me.ctbDivision.Enabled = False
    Me.ctbDivision.KeyColumnWidth = 100
    Me.ctbDivision.KeyField = ""
    Me.ctbDivision.KeySearch = True
    Me.ctbDivision.Location = New System.Drawing.Point(364, 4)
    Me.ctbDivision.Name = "ctbDivision"
    Me.ctbDivision.Size = New System.Drawing.Size(220, 23)
    Me.ctbDivision.TabIndex = 1
    Me.ctbDivision.TextBackColor = System.Drawing.Color.Empty
    Me.ctbDivision.TextForeColor = System.Drawing.Color.Empty
    Me.ctbDivision.ValueColumnVisible = True
    Me.ctbDivision.ValueColumnWidth = 600
    Me.ctbDivision.ValueField = ""
    Me.ctbDivision.ValueMember = ""
    Me.ctbDivision.ValueSearch = True
    '
    'ToolBar
    '
    Me.ToolBar.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.ToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.ToolBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGenerarOperacion, Me.ToolStripSeparator1, Me.btnCerrar, Me.ToolStripSeparator2})
    Me.ToolBar.Location = New System.Drawing.Point(0, 0)
    Me.ToolBar.Name = "ToolBar"
    Me.ToolBar.Size = New System.Drawing.Size(885, 25)
    Me.ToolBar.TabIndex = 1
    Me.ToolBar.Text = "ToolStrip1"
    '
    'btnGenerarOperacion
    '
    Me.btnGenerarOperacion.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
    Me.btnGenerarOperacion.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnGenerarOperacion.Name = "btnGenerarOperacion"
    Me.btnGenerarOperacion.Size = New System.Drawing.Size(136, 22)
    Me.btnGenerarOperacion.Text = "Generar Operaciones"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
    '
    'btnCerrar
    '
    Me.btnCerrar.Image = Global.SOLMIN_ST.My.Resources.Resources._stop
    Me.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(71, 22)
    Me.btnCerrar.Text = "Cancelar"
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
    '
    'gwdDatos
    '
    Me.gwdDatos.AllowUserToAddRows = False
    Me.gwdDatos.AllowUserToDeleteRows = False
    Me.gwdDatos.AllowUserToResizeColumns = False
    Me.gwdDatos.ColumnHeadersHeight = 30
    Me.gwdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroSolicitud, Me.Cliente, Me.NroOrdenServicio, Me.UnidadesAsignadas, Me.Status, Me.NroOperacion, Me.CCLNT})
    Me.gwdDatos.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.gwdDatos.Location = New System.Drawing.Point(0, 95)
    Me.gwdDatos.Name = "gwdDatos"
    Me.gwdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
    Me.gwdDatos.Size = New System.Drawing.Size(885, 357)
    Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.gwdDatos.TabIndex = 0
    '
    'NroSolicitud
    '
    Me.NroSolicitud.HeaderText = "Nro Solicitud"
    Me.NroSolicitud.Name = "NroSolicitud"
    Me.NroSolicitud.ReadOnly = True
    '
    'Cliente
    '
    Me.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.Cliente.HeaderText = "Cliente"
    Me.Cliente.Name = "Cliente"
    Me.Cliente.ReadOnly = True
    '
    'NroOrdenServicio
    '
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.NroOrdenServicio.DefaultCellStyle = DataGridViewCellStyle1
    Me.NroOrdenServicio.HeaderText = "Nro Orden Servicio"
    Me.NroOrdenServicio.MaxInputLength = 10
    Me.NroOrdenServicio.Name = "NroOrdenServicio"
    Me.NroOrdenServicio.Width = 120
    '
    'UnidadesAsignadas
    '
    Me.UnidadesAsignadas.HeaderText = "Unidades Asignadas"
    Me.UnidadesAsignadas.Name = "UnidadesAsignadas"
    Me.UnidadesAsignadas.ReadOnly = True
    Me.UnidadesAsignadas.Width = 220
    '
    'Status
    '
    Me.Status.HeaderText = "Status"
    Me.Status.Name = "Status"
    Me.Status.ReadOnly = True
    Me.Status.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.Status.Width = 50
    '
    'NroOperacion
    '
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
    Me.NroOperacion.DefaultCellStyle = DataGridViewCellStyle2
    Me.NroOperacion.HeaderText = "Nro Operacion"
    Me.NroOperacion.Name = "NroOperacion"
    Me.NroOperacion.ReadOnly = True
    '
    'CCLNT
    '
    Me.CCLNT.HeaderText = "CCLNT"
    Me.CCLNT.Name = "CCLNT"
    Me.CCLNT.Visible = False
    '
    'frmAsignacionOrdenServicio
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(885, 452)
    Me.Controls.Add(Me.KryptonPanel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmAsignacionOrdenServicio"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Generación de Número de Operación"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    Me.KryptonPanel.PerformLayout()
    CType(Me.HGDatosOperacion.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HGDatosOperacion.Panel.ResumeLayout(False)
    Me.HGDatosOperacion.Panel.PerformLayout()
    CType(Me.HGDatosOperacion, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HGDatosOperacion.ResumeLayout(False)
    Me.ToolBar.ResumeLayout(False)
    Me.ToolBar.PerformLayout()
    CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ToolBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnGenerarOperacion As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents gwdDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents HGDatosOperacion As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ctbPlanta As CodeTextBox.CodeTextBox
    Friend WithEvents ctbDivision As CodeTextBox.CodeTextBox
    Friend WithEvents ctbCompania As CodeTextBox.CodeTextBox
  Friend WithEvents ButtonSpecHeaderGroup1 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents NroSolicitud As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NroOrdenServicio As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents UnidadesAsignadas As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Status As System.Windows.Forms.DataGridViewImageColumn
  Friend WithEvents NroOperacion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
