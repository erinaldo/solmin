<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmZonaAlmacen
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
        'Dim BePlanta1 As Ransa.TypeDef.UbicacionPlanta.Planta.bePlanta = New Ransa.TypeDef.UbicacionPlanta.Planta.bePlanta
        'Dim BeCompania1 As Ransa.TypeDef.UbicacionPlanta.Compania.beCompania = New Ransa.TypeDef.UbicacionPlanta.Compania.beCompania
        Dim BePlanta1 As Ransa.Controls.UbicacionPlanta.Planta.bePlanta = New Ransa.Controls.UbicacionPlanta.Planta.bePlanta
        Dim BeCompania1 As Ransa.Controls.UbicacionPlanta.Compania.beCompania = New Ransa.Controls.UbicacionPlanta.Compania.beCompania
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dgvZonas = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.PSCZNALM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTCMZNA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCTPALM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCALMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTABZNA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNQARMTS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSSDISAT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnModificar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAgregar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btBuscar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcDivision_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
        Me.UcPLanta_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
        Me.UcCompania_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.lblalmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblTipoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtAlmacen = New Ransa.Utilitario.ucAyuda
        Me.txtTipoAlmacen = New Ransa.Utilitario.ucAyuda
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgvZonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgvZonas)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(876, 450)
        Me.KryptonPanel.TabIndex = 0
        '
        'dgvZonas
        '
        Me.dgvZonas.AllowUserToAddRows = False
        Me.dgvZonas.AllowUserToDeleteRows = False
        Me.dgvZonas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PSCZNALM, Me.PSTCMZNA, Me.PSCTPALM, Me.PSCALMC, Me.PSTABZNA, Me.PNQARMTS, Me.PSSDISAT})
        Me.dgvZonas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvZonas.Location = New System.Drawing.Point(0, 138)
        Me.dgvZonas.Name = "dgvZonas"
        Me.dgvZonas.ReadOnly = True
        Me.dgvZonas.Size = New System.Drawing.Size(876, 312)
        Me.dgvZonas.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvZonas.TabIndex = 2
        '
        'PSCZNALM
        '
        Me.PSCZNALM.DataPropertyName = "PSCZNALM"
        Me.PSCZNALM.HeaderText = "Codigo"
        Me.PSCZNALM.Name = "PSCZNALM"
        Me.PSCZNALM.ReadOnly = True
        '
        'PSTCMZNA
        '
        Me.PSTCMZNA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PSTCMZNA.DataPropertyName = "PSTCMZNA"
        Me.PSTCMZNA.HeaderText = "Descripción"
        Me.PSTCMZNA.Name = "PSTCMZNA"
        Me.PSTCMZNA.ReadOnly = True
        '
        'PSCTPALM
        '
        Me.PSCTPALM.DataPropertyName = "PSCTPALM"
        Me.PSCTPALM.HeaderText = "PSCTPALM"
        Me.PSCTPALM.Name = "PSCTPALM"
        Me.PSCTPALM.ReadOnly = True
        Me.PSCTPALM.Visible = False
        '
        'PSCALMC
        '
        Me.PSCALMC.DataPropertyName = "PSCALMC"
        Me.PSCALMC.HeaderText = "PSCALMC"
        Me.PSCALMC.Name = "PSCALMC"
        Me.PSCALMC.ReadOnly = True
        Me.PSCALMC.Visible = False
        '
        'PSTABZNA
        '
        Me.PSTABZNA.DataPropertyName = "PSTABZNA"
        Me.PSTABZNA.HeaderText = "PSTABZNA"
        Me.PSTABZNA.Name = "PSTABZNA"
        Me.PSTABZNA.ReadOnly = True
        Me.PSTABZNA.Visible = False
        '
        'PNQARMTS
        '
        Me.PNQARMTS.DataPropertyName = "PNQARMTS"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.PNQARMTS.DefaultCellStyle = DataGridViewCellStyle1
        Me.PNQARMTS.HeaderText = "Cantidad"
        Me.PNQARMTS.Name = "PNQARMTS"
        Me.PNQARMTS.ReadOnly = True
        '
        'PSSDISAT
        '
        Me.PSSDISAT.DataPropertyName = "PSSDISAT"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PSSDISAT.DefaultCellStyle = DataGridViewCellStyle2
        Me.PSSDISAT.HeaderText = "Disponible"
        Me.PSSDISAT.Name = "PSSDISAT"
        Me.PSSDISAT.ReadOnly = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btBuscar, Me.ToolStripSeparator4, Me.btnEliminar, Me.ToolStripSeparator1, Me.btnModificar, Me.ToolStripSeparator2, Me.btnAgregar, Me.ToolStripSeparator3, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 113)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(876, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnEliminar
        '
        Me.btnEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminar.Image = Global.SOLMIN_SA.My.Resources.Resources.AnularItem
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(70, 22)
        Me.btnEliminar.Text = "Eliminar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnModificar
        '
        Me.btnModificar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnModificar.Image = Global.SOLMIN_SA.My.Resources.Resources.edit_add
        Me.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(78, 22)
        Me.btnModificar.Text = "Modificar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnAgregar
        '
        Me.btnAgregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAgregar.Image = Global.SOLMIN_SA.My.Resources.Resources.db_add
        Me.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(69, 22)
        Me.btnAgregar.Text = "Agregar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btBuscar
        '
        Me.btBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btBuscar.Image = Global.SOLMIN_SA.My.Resources.Resources.search1
        Me.btBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(62, 22)
        Me.btBuscar.Text = "Buscar"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(45, 22)
        Me.ToolStripLabel1.Text = "Zonas"
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.UcDivision_Cmb011)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.UcPLanta_Cmb011)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.UcCompania_Cmb011)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblalmacen)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblTipoAlmacen)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtAlmacen)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtTipoAlmacen)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(876, 113)
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.Text = "Filtros"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Filtros"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(610, 19)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(50, 20)
        Me.KryptonLabel3.TabIndex = 63
        Me.KryptonLabel3.Text = "Planta : "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Planta : "
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(325, 21)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(60, 20)
        Me.KryptonLabel2.TabIndex = 62
        Me.KryptonLabel2.Text = "Division : "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Division : "
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(2, 21)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(72, 20)
        Me.KryptonLabel4.TabIndex = 61
        Me.KryptonLabel4.Text = "Compañia : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Compañia : "
        '
        'UcDivision_Cmb011
        '
        Me.UcDivision_Cmb011.BackColor = System.Drawing.Color.Transparent
        Me.UcDivision_Cmb011.CDVSN_ANTERIOR = Nothing
        Me.UcDivision_Cmb011.Compania = ""
        Me.UcDivision_Cmb011.Division = Nothing
        Me.UcDivision_Cmb011.DivisionDefault = Nothing
        Me.UcDivision_Cmb011.DivisionDescripcion = Nothing
        Me.UcDivision_Cmb011.ItemTodos = False
        Me.UcDivision_Cmb011.Location = New System.Drawing.Point(386, 17)
        Me.UcDivision_Cmb011.MinimumSize = New System.Drawing.Size(150, 21)
        Me.UcDivision_Cmb011.Name = "UcDivision_Cmb011"
        Me.UcDivision_Cmb011.obeDivision = Nothing
        Me.UcDivision_Cmb011.pHabilitado = True
        Me.UcDivision_Cmb011.pRequerido = False
        Me.UcDivision_Cmb011.Size = New System.Drawing.Size(205, 23)
        Me.UcDivision_Cmb011.TabIndex = 59
        Me.UcDivision_Cmb011.Usuario = ""
        '
        'UcPLanta_Cmb011
        '
        Me.UcPLanta_Cmb011.BackColor = System.Drawing.Color.Transparent
        Me.UcPLanta_Cmb011.CodigoCompania = ""
        Me.UcPLanta_Cmb011.CodigoDivision = ""
        Me.UcPLanta_Cmb011.CPLNDV_ANTERIOR = Nothing
        Me.UcPLanta_Cmb011.DescripcionPlanta = ""
        Me.UcPLanta_Cmb011.ItemTodos = False
        Me.UcPLanta_Cmb011.Location = New System.Drawing.Point(661, 15)
        Me.UcPLanta_Cmb011.MinimumSize = New System.Drawing.Size(150, 21)
        Me.UcPLanta_Cmb011.Name = "UcPLanta_Cmb011"
        BePlanta1.CCMPN_CodigoCompania = ""
        BePlanta1.CDVSN_CodigoDivision = ""
        BePlanta1.CPLNDV_CodigoPlanta = 0
        BePlanta1.Orden = -1
        BePlanta1.TPLNTA_DescripcionPlanta = ""
        Me.UcPLanta_Cmb011.obePlanta = BePlanta1
        Me.UcPLanta_Cmb011.pHabilitado = True
        Me.UcPLanta_Cmb011.Planta = 0
        Me.UcPLanta_Cmb011.PlantaDefault = -1
        Me.UcPLanta_Cmb011.pRequerido = False
        Me.UcPLanta_Cmb011.Size = New System.Drawing.Size(207, 23)
        Me.UcPLanta_Cmb011.TabIndex = 60
        Me.UcPLanta_Cmb011.Usuario = ""
        '
        'UcCompania_Cmb011
        '
        Me.UcCompania_Cmb011.BackColor = System.Drawing.SystemColors.Window
        Me.UcCompania_Cmb011.CCMPN_ANTERIOR = Nothing
        Me.UcCompania_Cmb011.CCMPN_CodigoCompania = Nothing
        Me.UcCompania_Cmb011.CCMPN_CompaniaDefault = Nothing
        Me.UcCompania_Cmb011.CCMPN_Descripcion = Nothing
        Me.UcCompania_Cmb011.Habilitar = True
        Me.UcCompania_Cmb011.Location = New System.Drawing.Point(74, 17)
        Me.UcCompania_Cmb011.MinimumSize = New System.Drawing.Size(150, 23)
        Me.UcCompania_Cmb011.Name = "UcCompania_Cmb011"
        BeCompania1.CCMPN_CodigoCompania = ""
        BeCompania1.Orden = -1
        BeCompania1.TCMPCM_DescripcionCompania = ""
        Me.UcCompania_Cmb011.oBeCompania = BeCompania1
        Me.UcCompania_Cmb011.Size = New System.Drawing.Size(219, 23)
        Me.UcCompania_Cmb011.TabIndex = 58
        Me.UcCompania_Cmb011.Usuario = ""
        '
        'lblalmacen
        '
        Me.lblalmacen.Location = New System.Drawing.Point(325, 50)
        Me.lblalmacen.Name = "lblalmacen"
        Me.lblalmacen.Size = New System.Drawing.Size(60, 20)
        Me.lblalmacen.TabIndex = 8
        Me.lblalmacen.Text = "Almacen:"
        Me.lblalmacen.Values.ExtraText = ""
        Me.lblalmacen.Values.Image = Nothing
        Me.lblalmacen.Values.Text = "Almacen:"
        '
        'lblTipoAlmacen
        '
        Me.lblTipoAlmacen.Location = New System.Drawing.Point(31, 49)
        Me.lblTipoAlmacen.Name = "lblTipoAlmacen"
        Me.lblTipoAlmacen.Size = New System.Drawing.Size(37, 20)
        Me.lblTipoAlmacen.TabIndex = 7
        Me.lblTipoAlmacen.Text = "Tipo:"
        Me.lblTipoAlmacen.Values.ExtraText = ""
        Me.lblTipoAlmacen.Values.Image = Nothing
        Me.lblTipoAlmacen.Values.Text = "Tipo:"
        '
        'txtAlmacen
        '
        Me.txtAlmacen.BackColor = System.Drawing.Color.White
        Me.txtAlmacen.DataSource = Nothing
        Me.txtAlmacen.DispleyMember = ""
        Me.txtAlmacen.ListColumnas = Nothing
        Me.txtAlmacen.Location = New System.Drawing.Point(386, 46)
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.Obligatorio = False
        Me.txtAlmacen.Size = New System.Drawing.Size(205, 21)
        Me.txtAlmacen.TabIndex = 6
        Me.txtAlmacen.ValueMember = ""
        '
        'txtTipoAlmacen
        '
        Me.txtTipoAlmacen.BackColor = System.Drawing.Color.White
        Me.txtTipoAlmacen.DataSource = Nothing
        Me.txtTipoAlmacen.DispleyMember = ""
        Me.txtTipoAlmacen.ListColumnas = Nothing
        Me.txtTipoAlmacen.Location = New System.Drawing.Point(74, 46)
        Me.txtTipoAlmacen.Name = "txtTipoAlmacen"
        Me.txtTipoAlmacen.Obligatorio = False
        Me.txtTipoAlmacen.Size = New System.Drawing.Size(219, 21)
        Me.txtTipoAlmacen.TabIndex = 5
        Me.txtTipoAlmacen.ValueMember = ""
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'frmZonaAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 450)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmZonaAlmacen"
        Me.Text = "Zona Almacen"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dgvZonas, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvZonas As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblalmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTipoAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtAlmacen As Ransa.Utilitario.ucAyuda
    Friend WithEvents txtTipoAlmacen As Ransa.Utilitario.ucAyuda
    Private WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcDivision_Cmb011 As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Friend WithEvents UcPLanta_Cmb011 As Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Friend WithEvents UcCompania_Cmb011 As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents PSCZNALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTCMZNA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCTPALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCALMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTABZNA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQARMTS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSSDISAT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
End Class
