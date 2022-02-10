<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRutas
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
        Me.PanelRutas = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.dgZonas = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.CRUTAT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TABRUT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FULTAC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HULTAC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CULUSA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NTRMNL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tsMenuOpcionZonas = New System.Windows.Forms.ToolStrip
        Me.lblDetalle = New System.Windows.Forms.ToolStripLabel
        Me.btnSalir = New System.Windows.Forms.ToolStripButton
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.btnModificar = New System.Windows.Forms.ToolStripButton
        Me.btnAgregar = New System.Windows.Forms.ToolStripButton
        Me.dgClientexZona = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMPCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.V_TCMPPL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TPRVCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.V_TDRPCP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CPLNCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CPRVCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CPLCLP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CRUTAT_S = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NCRRRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HRAINI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HRAFIN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GPSLAT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GPSLON = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FULTAC_S = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HULTAC_S = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CULUSA_S = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NTRMNL_S = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUSCRT_S = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FCHCRT_S = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HRACRT_S = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NTRMCR_S = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UPDATE_IDENT_S = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SESTRG_S = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SEGUIMIENTO = New System.Windows.Forms.DataGridViewImageColumn
        Me.tsMenuOpcionClientexZona = New System.Windows.Forms.ToolStrip
        Me.lblDetalleCZ = New System.Windows.Forms.ToolStripLabel
        Me.btnEliminarCZ = New System.Windows.Forms.ToolStripButton
        Me.btnModificarCZ = New System.Windows.Forms.ToolStripButton
        Me.btnSalirCZ = New System.Windows.Forms.ToolStripButton
        Me.btnAgregarCZ = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.PanelRutas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRutas.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.dgZonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpcionZonas.SuspendLayout()
        CType(Me.dgClientexZona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpcionClientexZona.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelRutas
        '
        Me.PanelRutas.Controls.Add(Me.KryptonSplitContainer1)
        Me.PanelRutas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelRutas.Location = New System.Drawing.Point(0, 0)
        Me.PanelRutas.Name = "PanelRutas"
        Me.PanelRutas.Size = New System.Drawing.Size(1129, 611)
        Me.PanelRutas.TabIndex = 0
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        Me.KryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.dgZonas)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.tsMenuOpcionZonas)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.dgClientexZona)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.tsMenuOpcionClientexZona)
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(1129, 611)
        Me.KryptonSplitContainer1.SplitterDistance = 170
        Me.KryptonSplitContainer1.TabIndex = 0
        '
        'dgZonas
        '
        Me.dgZonas.AllowUserToAddRows = False
        Me.dgZonas.AllowUserToDeleteRows = False
        Me.dgZonas.AllowUserToResizeColumns = False
        Me.dgZonas.AllowUserToResizeRows = False
        Me.dgZonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgZonas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgZonas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CRUTAT, Me.TABRUT, Me.FULTAC, Me.HULTAC, Me.CULUSA, Me.NTRMNL, Me.SESTRG})
        Me.dgZonas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgZonas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgZonas.Location = New System.Drawing.Point(0, 25)
        Me.dgZonas.MultiSelect = False
        Me.dgZonas.Name = "dgZonas"
        Me.dgZonas.RowHeadersWidth = 20
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgZonas.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgZonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgZonas.Size = New System.Drawing.Size(1129, 145)
        Me.dgZonas.StandardTab = True
        Me.dgZonas.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgZonas.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgZonas.TabIndex = 81
        '
        'CRUTAT
        '
        Me.CRUTAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CRUTAT.DataPropertyName = "PSCRUTAT"
        Me.CRUTAT.HeaderText = "Codigo de Rutas"
        Me.CRUTAT.Name = "CRUTAT"
        Me.CRUTAT.Width = 122
        '
        'TABRUT
        '
        Me.TABRUT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TABRUT.DataPropertyName = "PSTABRUT"
        Me.TABRUT.HeaderText = "Descripcion Ruta"
        Me.TABRUT.Name = "TABRUT"
        Me.TABRUT.Width = 123
        '
        'FULTAC
        '
        Me.FULTAC.DataPropertyName = "PNFULTAC"
        Me.FULTAC.HeaderText = "FULTAC"
        Me.FULTAC.Name = "FULTAC"
        Me.FULTAC.Visible = False
        Me.FULTAC.Width = 74
        '
        'HULTAC
        '
        Me.HULTAC.DataPropertyName = "PNHULTAC"
        Me.HULTAC.HeaderText = "HULTAC"
        Me.HULTAC.Name = "HULTAC"
        Me.HULTAC.Visible = False
        Me.HULTAC.Width = 77
        '
        'CULUSA
        '
        Me.CULUSA.DataPropertyName = "PSCULUSA"
        Me.CULUSA.HeaderText = "CULUSA"
        Me.CULUSA.Name = "CULUSA"
        Me.CULUSA.Visible = False
        Me.CULUSA.Width = 76
        '
        'NTRMNL
        '
        Me.NTRMNL.DataPropertyName = "PSNTRMNL"
        Me.NTRMNL.HeaderText = "NTRMNL"
        Me.NTRMNL.Name = "NTRMNL"
        Me.NTRMNL.Visible = False
        Me.NTRMNL.Width = 79
        '
        'SESTRG
        '
        Me.SESTRG.DataPropertyName = "PSSESTRG"
        Me.SESTRG.HeaderText = "SESTRG"
        Me.SESTRG.Name = "SESTRG"
        Me.SESTRG.Visible = False
        Me.SESTRG.Width = 72
        '
        'tsMenuOpcionZonas
        '
        Me.tsMenuOpcionZonas.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsMenuOpcionZonas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpcionZonas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblDetalle, Me.btnSalir, Me.btnEliminar, Me.btnModificar, Me.btnAgregar})
        Me.tsMenuOpcionZonas.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpcionZonas.Name = "tsMenuOpcionZonas"
        Me.tsMenuOpcionZonas.Size = New System.Drawing.Size(1129, 25)
        Me.tsMenuOpcionZonas.TabIndex = 80
        '
        'lblDetalle
        '
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(103, 22)
        Me.lblDetalle.Text = "Información Zonas"
        '
        'btnSalir
        '
        Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalir.Image = Global.SOLMIN_SA.My.Resources.Resources._exit
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(49, 22)
        Me.btnSalir.Text = "Salir"
        '
        'btnEliminar
        '
        Me.btnEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminar.Image = Global.SOLMIN_SA.My.Resources.Resources.button_cancel
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(68, 22)
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnModificar
        '
        Me.btnModificar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnModificar.Image = Global.SOLMIN_SA.My.Resources.Resources.retencion
        Me.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(76, 22)
        Me.btnModificar.Text = "Modificar"
        '
        'btnAgregar
        '
        Me.btnAgregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAgregar.Image = Global.SOLMIN_SA.My.Resources.Resources.edit_add
        Me.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(68, 22)
        Me.btnAgregar.Text = "Agregar"
        '
        'dgClientexZona
        '
        Me.dgClientexZona.AllowUserToAddRows = False
        Me.dgClientexZona.AllowUserToDeleteRows = False
        Me.dgClientexZona.AllowUserToResizeColumns = False
        Me.dgClientexZona.AllowUserToResizeRows = False
        Me.dgClientexZona.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgClientexZona.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgClientexZona.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CCLNT, Me.TCMPCL, Me.V_TCMPPL, Me.TPRVCL, Me.V_TDRPCP, Me.CPLNCL, Me.CPRVCL, Me.CPLCLP, Me.CRUTAT_S, Me.NCRRRT, Me.HRAINI, Me.HRAFIN, Me.GPSLAT, Me.GPSLON, Me.FULTAC_S, Me.HULTAC_S, Me.CULUSA_S, Me.NTRMNL_S, Me.CUSCRT_S, Me.FCHCRT_S, Me.HRACRT_S, Me.NTRMCR_S, Me.UPDATE_IDENT_S, Me.SESTRG_S, Me.SEGUIMIENTO})
        Me.dgClientexZona.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgClientexZona.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgClientexZona.Location = New System.Drawing.Point(0, 25)
        Me.dgClientexZona.MultiSelect = False
        Me.dgClientexZona.Name = "dgClientexZona"
        Me.dgClientexZona.RowHeadersWidth = 20
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgClientexZona.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgClientexZona.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgClientexZona.Size = New System.Drawing.Size(1129, 411)
        Me.dgClientexZona.StandardTab = True
        Me.dgClientexZona.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgClientexZona.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgClientexZona.TabIndex = 83
        '
        'CCLNT
        '
        Me.CCLNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CCLNT.DataPropertyName = "PNCCLNT"
        Me.CCLNT.HeaderText = "Codigo Cliente"
        Me.CCLNT.Name = "CCLNT"
        Me.CCLNT.Width = 113
        '
        'TCMPCL
        '
        Me.TCMPCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCMPCL.DataPropertyName = "PSTCMPCL"
        Me.TCMPCL.HeaderText = "Cliente"
        Me.TCMPCL.Name = "TCMPCL"
        Me.TCMPCL.Width = 72
        '
        'V_TCMPPL
        '
        Me.V_TCMPPL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.V_TCMPPL.DataPropertyName = "PSV_TCMPPL"
        Me.V_TCMPPL.HeaderText = " Planta Propia"
        Me.V_TCMPPL.Name = "V_TCMPPL"
        Me.V_TCMPPL.Width = 107
        '
        'TPRVCL
        '
        Me.TPRVCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TPRVCL.DataPropertyName = "PSTPRVCL"
        Me.TPRVCL.HeaderText = "Cliente Tercero"
        Me.TPRVCL.Name = "TPRVCL"
        Me.TPRVCL.Width = 112
        '
        'V_TDRPCP
        '
        Me.V_TDRPCP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.V_TDRPCP.DataPropertyName = "PSV_TDRPCP"
        Me.V_TDRPCP.HeaderText = "Planta Tercero"
        Me.V_TDRPCP.Name = "V_TDRPCP"
        Me.V_TDRPCP.Width = 108
        '
        'CPLNCL
        '
        Me.CPLNCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CPLNCL.DataPropertyName = "PNCPLNCL"
        Me.CPLNCL.HeaderText = "Codigo Planta Cliente"
        Me.CPLNCL.Name = "CPLNCL"
        Me.CPLNCL.Visible = False
        '
        'CPRVCL
        '
        Me.CPRVCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CPRVCL.DataPropertyName = "PNCPRVCL"
        Me.CPRVCL.HeaderText = "Codigo Cliente Tercero"
        Me.CPRVCL.Name = "CPRVCL"
        Me.CPRVCL.Visible = False
        '
        'CPLCLP
        '
        Me.CPLCLP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CPLCLP.DataPropertyName = "PNCPLCLP"
        Me.CPLCLP.HeaderText = "Codigo Planta Tercero"
        Me.CPLCLP.Name = "CPLCLP"
        Me.CPLCLP.Visible = False
        '
        'CRUTAT_S
        '
        Me.CRUTAT_S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CRUTAT_S.DataPropertyName = "PSCRUTAT"
        Me.CRUTAT_S.HeaderText = "Codigo de Ruta"
        Me.CRUTAT_S.Name = "CRUTAT_S"
        Me.CRUTAT_S.Width = 117
        '
        'NCRRRT
        '
        Me.NCRRRT.DataPropertyName = "PNNCRRRT"
        Me.NCRRRT.HeaderText = "Correlativo ruta"
        Me.NCRRRT.Name = "NCRRRT"
        Me.NCRRRT.Width = 116
        '
        'HRAINI
        '
        Me.HRAINI.DataPropertyName = "PNHRAINI_D"
        Me.HRAINI.HeaderText = "Hora de Inicio"
        Me.HRAINI.Name = "HRAINI"
        Me.HRAINI.Width = 108
        '
        'HRAFIN
        '
        Me.HRAFIN.DataPropertyName = "PNHRAFIN_D"
        Me.HRAFIN.HeaderText = "Hora Fin"
        Me.HRAFIN.Name = "HRAFIN"
        Me.HRAFIN.Width = 80
        '
        'GPSLAT
        '
        Me.GPSLAT.DataPropertyName = "PSGPSLAT"
        Me.GPSLAT.HeaderText = "Latitud"
        Me.GPSLAT.Name = "GPSLAT"
        Me.GPSLAT.Width = 72
        '
        'GPSLON
        '
        Me.GPSLON.DataPropertyName = "PSGPSLON"
        Me.GPSLON.HeaderText = "Longitud"
        Me.GPSLON.Name = "GPSLON"
        Me.GPSLON.Width = 83
        '
        'FULTAC_S
        '
        Me.FULTAC_S.DataPropertyName = "PNFULTAC"
        Me.FULTAC_S.HeaderText = "FULTAC"
        Me.FULTAC_S.Name = "FULTAC_S"
        Me.FULTAC_S.Visible = False
        Me.FULTAC_S.Width = 74
        '
        'HULTAC_S
        '
        Me.HULTAC_S.DataPropertyName = "PNHULTAC"
        Me.HULTAC_S.HeaderText = "HULTAC"
        Me.HULTAC_S.Name = "HULTAC_S"
        Me.HULTAC_S.Visible = False
        Me.HULTAC_S.Width = 76
        '
        'CULUSA_S
        '
        Me.CULUSA_S.DataPropertyName = "PSCULUSA"
        Me.CULUSA_S.HeaderText = "CULUSA"
        Me.CULUSA_S.Name = "CULUSA_S"
        Me.CULUSA_S.Visible = False
        Me.CULUSA_S.Width = 77
        '
        'NTRMNL_S
        '
        Me.NTRMNL_S.DataPropertyName = "PSNTRMNL"
        Me.NTRMNL_S.HeaderText = "NTRMNL"
        Me.NTRMNL_S.Name = "NTRMNL_S"
        Me.NTRMNL_S.Visible = False
        Me.NTRMNL_S.Width = 79
        '
        'CUSCRT_S
        '
        Me.CUSCRT_S.DataPropertyName = "PSCUSCRT"
        Me.CUSCRT_S.HeaderText = "CUSCRT"
        Me.CUSCRT_S.Name = "CUSCRT_S"
        Me.CUSCRT_S.Visible = False
        Me.CUSCRT_S.Width = 76
        '
        'FCHCRT_S
        '
        Me.FCHCRT_S.DataPropertyName = "PNFCHCRT"
        Me.FCHCRT_S.HeaderText = "FCHCRT"
        Me.FCHCRT_S.Name = "FCHCRT_S"
        Me.FCHCRT_S.Visible = False
        Me.FCHCRT_S.Width = 76
        '
        'HRACRT_S
        '
        Me.HRACRT_S.DataPropertyName = "PNHRACRT"
        Me.HRACRT_S.HeaderText = "HRACRT"
        Me.HRACRT_S.Name = "HRACRT_S"
        Me.HRACRT_S.Visible = False
        Me.HRACRT_S.Width = 77
        '
        'NTRMCR_S
        '
        Me.NTRMCR_S.DataPropertyName = "PSNTRMCR"
        Me.NTRMCR_S.HeaderText = "NTRMCR"
        Me.NTRMCR_S.Name = "NTRMCR_S"
        Me.NTRMCR_S.Visible = False
        Me.NTRMCR_S.Width = 80
        '
        'UPDATE_IDENT_S
        '
        Me.UPDATE_IDENT_S.DataPropertyName = "PNUPDATE_IDENT"
        Me.UPDATE_IDENT_S.HeaderText = "UPDATE_IDENT"
        Me.UPDATE_IDENT_S.Name = "UPDATE_IDENT_S"
        Me.UPDATE_IDENT_S.Visible = False
        Me.UPDATE_IDENT_S.Width = 111
        '
        'SESTRG_S
        '
        Me.SESTRG_S.DataPropertyName = "PSSESTRG"
        Me.SESTRG_S.HeaderText = "SESTRG"
        Me.SESTRG_S.Name = "SESTRG_S"
        Me.SESTRG_S.Visible = False
        Me.SESTRG_S.Width = 74
        '
        'SEGUIMIENTO
        '
        Me.SEGUIMIENTO.HeaderText = "SEGUIMIENTO"
        Me.SEGUIMIENTO.Image = Global.SOLMIN_SA.My.Resources.Resources.button_ok1
        Me.SEGUIMIENTO.Name = "SEGUIMIENTO"
        Me.SEGUIMIENTO.Width = 89
        '
        'tsMenuOpcionClientexZona
        '
        Me.tsMenuOpcionClientexZona.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsMenuOpcionClientexZona.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpcionClientexZona.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblDetalleCZ, Me.btnEliminarCZ, Me.btnModificarCZ, Me.btnSalirCZ, Me.btnAgregarCZ})
        Me.tsMenuOpcionClientexZona.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpcionClientexZona.Name = "tsMenuOpcionClientexZona"
        Me.tsMenuOpcionClientexZona.Size = New System.Drawing.Size(1129, 25)
        Me.tsMenuOpcionClientexZona.TabIndex = 82
        '
        'lblDetalleCZ
        '
        Me.lblDetalleCZ.Name = "lblDetalleCZ"
        Me.lblDetalleCZ.Size = New System.Drawing.Size(158, 22)
        Me.lblDetalleCZ.Text = "Información Cliente por Zona"
        '
        'btnEliminarCZ
        '
        Me.btnEliminarCZ.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminarCZ.Image = Global.SOLMIN_SA.My.Resources.Resources.button_cancel
        Me.btnEliminarCZ.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminarCZ.Name = "btnEliminarCZ"
        Me.btnEliminarCZ.Size = New System.Drawing.Size(68, 22)
        Me.btnEliminarCZ.Text = "Eliminar"
        '
        'btnModificarCZ
        '
        Me.btnModificarCZ.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnModificarCZ.Image = Global.SOLMIN_SA.My.Resources.Resources.retencion
        Me.btnModificarCZ.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificarCZ.Name = "btnModificarCZ"
        Me.btnModificarCZ.Size = New System.Drawing.Size(76, 22)
        Me.btnModificarCZ.Text = "Modificar"
        '
        'btnSalirCZ
        '
        Me.btnSalirCZ.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalirCZ.Image = Global.SOLMIN_SA.My.Resources.Resources._exit
        Me.btnSalirCZ.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalirCZ.Name = "btnSalirCZ"
        Me.btnSalirCZ.Size = New System.Drawing.Size(49, 22)
        Me.btnSalirCZ.Text = "Salir"
        Me.btnSalirCZ.Visible = False
        '
        'btnAgregarCZ
        '
        Me.btnAgregarCZ.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAgregarCZ.Image = Global.SOLMIN_SA.My.Resources.Resources.edit_add
        Me.btnAgregarCZ.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgregarCZ.Name = "btnAgregarCZ"
        Me.btnAgregarCZ.Size = New System.Drawing.Size(68, 22)
        Me.btnAgregarCZ.Text = "Agregar"
        '
        'frmRutas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 611)
        Me.Controls.Add(Me.PanelRutas)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRutas"
        Me.Text = "Rutas"
        CType(Me.PanelRutas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRutas.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel2.PerformLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.dgZonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpcionZonas.ResumeLayout(False)
        Me.tsMenuOpcionZonas.PerformLayout()
        CType(Me.dgClientexZona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpcionClientexZona.ResumeLayout(False)
        Me.tsMenuOpcionClientexZona.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelRutas As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Private WithEvents tsMenuOpcionZonas As System.Windows.Forms.ToolStrip
    Friend WithEvents lblDetalle As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgZonas As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dgClientexZona As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Private WithEvents tsMenuOpcionClientexZona As System.Windows.Forms.ToolStrip
    Friend WithEvents lblDetalleCZ As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnSalirCZ As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEliminarCZ As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnModificarCZ As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAgregarCZ As System.Windows.Forms.ToolStripButton
    Friend WithEvents CRUTAT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TABRUT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FULTAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HULTAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CULUSA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NTRMNL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMPCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents V_TCMPPL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TPRVCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents V_TDRPCP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPLNCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPRVCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPLCLP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CRUTAT_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCRRRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HRAINI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HRAFIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GPSLAT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GPSLON As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FULTAC_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HULTAC_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CULUSA_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NTRMNL_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUSCRT_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FCHCRT_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HRACRT_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NTRMCR_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UPDATE_IDENT_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESTRG_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SEGUIMIENTO As System.Windows.Forms.DataGridViewImageColumn
End Class
