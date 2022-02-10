<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSegNotificacion
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim BeCompania2 As Ransa.Controls.UbicacionPlanta.Compania.beCompania = New Ransa.Controls.UbicacionPlanta.Compania.beCompania
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TPCheckPoints = New System.Windows.Forms.TabPage
        Me.dgvCheckPointsNotificacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.Chk = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
        Me.NESTDO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DES_TIPOCHK = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CHK_DES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CHK_DES_SEG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCOLUM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NOTIFICAR_CHK = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VER_CHK = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FLGEST = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NSEPRE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FLGNTE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CEMB = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CFCHK = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TPNotifCliente = New System.Windows.Forms.TabPage
        Me.dgvNotificacionCliente = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.Chek = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
        Me.EMAILTO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TNMYAP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TIPPROC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.N_CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_NLTECL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.N_NCRRIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_TCMPCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.tbnEliminar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.tbnModicar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.tbnAgregar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.tbnActualizarOrden = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.tbnCopiarPerfil = New System.Windows.Forms.ToolStripButton
        Me.tbnExportar = New System.Windows.Forms.ToolStripButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.dgvSegNotificacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.COCNTF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DESC_TIPPROC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMPCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CODFMT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DES_CODFMT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.COD_TIPPROC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCMPN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CDVSN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PARA_FORMATO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tbnCab_Buscar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.tbnCab_Eliminar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tbnCab_Agregar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tbnCab_Formato = New System.Windows.Forms.ToolStripButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cbmFormato = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcProcNotificacion = New Ransa.Utilitario.ucAyuda
        Me.UcDivision_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
        Me.UcCompania_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnExportarCab = New System.Windows.Forms.ToolStripButton
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TPCheckPoints.SuspendLayout()
        CType(Me.dgvCheckPointsNotificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPNotifCliente.SuspendLayout()
        CType(Me.dgvNotificacionCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvSegNotificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.Panel3)
        Me.KryptonPanel.Controls.Add(Me.Panel2)
        Me.KryptonPanel.Controls.Add(Me.Panel1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(928, 558)
        Me.KryptonPanel.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.TabControl1)
        Me.Panel3.Controls.Add(Me.ToolStrip2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 303)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(928, 255)
        Me.Panel3.TabIndex = 5
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TPCheckPoints)
        Me.TabControl1.Controls.Add(Me.TPNotifCliente)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(928, 230)
        Me.TabControl1.TabIndex = 1
        '
        'TPCheckPoints
        '
        Me.TPCheckPoints.Controls.Add(Me.dgvCheckPointsNotificacion)
        Me.TPCheckPoints.Location = New System.Drawing.Point(4, 22)
        Me.TPCheckPoints.Name = "TPCheckPoints"
        Me.TPCheckPoints.Padding = New System.Windows.Forms.Padding(3)
        Me.TPCheckPoints.Size = New System.Drawing.Size(920, 204)
        Me.TPCheckPoints.TabIndex = 0
        Me.TPCheckPoints.Text = "CheckPoints"
        Me.TPCheckPoints.UseVisualStyleBackColor = True
        '
        'dgvCheckPointsNotificacion
        '
        Me.dgvCheckPointsNotificacion.AllowUserToAddRows = False
        Me.dgvCheckPointsNotificacion.AllowUserToDeleteRows = False
        Me.dgvCheckPointsNotificacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Chk, Me.NESTDO, Me.DES_TIPOCHK, Me.CHK_DES, Me.CHK_DES_SEG, Me.TCOLUM, Me.NOTIFICAR_CHK, Me.VER_CHK, Me.FLGEST, Me.NSEPRE, Me.Column3, Me.FLGNTE, Me.CEMB, Me.CFCHK, Me.Column1})
        Me.dgvCheckPointsNotificacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCheckPointsNotificacion.Location = New System.Drawing.Point(3, 3)
        Me.dgvCheckPointsNotificacion.Name = "dgvCheckPointsNotificacion"
        Me.dgvCheckPointsNotificacion.Size = New System.Drawing.Size(914, 198)
        Me.dgvCheckPointsNotificacion.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvCheckPointsNotificacion.TabIndex = 0
        '
        'Chk
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.NullValue = False
        Me.Chk.DefaultCellStyle = DataGridViewCellStyle7
        Me.Chk.FalseValue = Nothing
        Me.Chk.HeaderText = "Chk"
        Me.Chk.IndeterminateValue = Nothing
        Me.Chk.Name = "Chk"
        Me.Chk.TrueValue = Nothing
        Me.Chk.Width = 40
        '
        'NESTDO
        '
        Me.NESTDO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NESTDO.DataPropertyName = "NESTDO"
        Me.NESTDO.HeaderText = "Cod. Chk"
        Me.NESTDO.Name = "NESTDO"
        Me.NESTDO.ReadOnly = True
        Me.NESTDO.Width = 85
        '
        'DES_TIPOCHK
        '
        Me.DES_TIPOCHK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DES_TIPOCHK.DataPropertyName = "DES_TIPOCHK"
        Me.DES_TIPOCHK.HeaderText = "Tipo"
        Me.DES_TIPOCHK.Name = "DES_TIPOCHK"
        Me.DES_TIPOCHK.ReadOnly = True
        Me.DES_TIPOCHK.Width = 60
        '
        'CHK_DES
        '
        Me.CHK_DES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CHK_DES.DataPropertyName = "CHK_DES"
        Me.CHK_DES.HeaderText = "CheckPoint"
        Me.CHK_DES.Name = "CHK_DES"
        Me.CHK_DES.ReadOnly = True
        Me.CHK_DES.Width = 97
        '
        'CHK_DES_SEG
        '
        Me.CHK_DES_SEG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CHK_DES_SEG.DataPropertyName = "CHK_DES_SEG"
        Me.CHK_DES_SEG.HeaderText = "Título en Seg."
        Me.CHK_DES_SEG.Name = "CHK_DES_SEG"
        Me.CHK_DES_SEG.ReadOnly = True
        Me.CHK_DES_SEG.Width = 108
        '
        'TCOLUM
        '
        Me.TCOLUM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCOLUM.DataPropertyName = "TCOLUM"
        Me.TCOLUM.HeaderText = "Título en Email"
        Me.TCOLUM.Name = "TCOLUM"
        Me.TCOLUM.ReadOnly = True
        Me.TCOLUM.Width = 115
        '
        'NOTIFICAR_CHK
        '
        Me.NOTIFICAR_CHK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NOTIFICAR_CHK.DataPropertyName = "NOTIFICAR_CHK"
        Me.NOTIFICAR_CHK.HeaderText = "Notificar"
        Me.NOTIFICAR_CHK.Name = "NOTIFICAR_CHK"
        Me.NOTIFICAR_CHK.ReadOnly = True
        Me.NOTIFICAR_CHK.Width = 82
        '
        'VER_CHK
        '
        Me.VER_CHK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.VER_CHK.DataPropertyName = "VER_CHK"
        Me.VER_CHK.HeaderText = "Visualizar"
        Me.VER_CHK.Name = "VER_CHK"
        Me.VER_CHK.ReadOnly = True
        Me.VER_CHK.Width = 85
        '
        'FLGEST
        '
        Me.FLGEST.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FLGEST.DataPropertyName = "FLGEST"
        Me.FLGEST.HeaderText = "FLGEST"
        Me.FLGEST.Name = "FLGEST"
        Me.FLGEST.ReadOnly = True
        Me.FLGEST.Visible = False
        '
        'NSEPRE
        '
        Me.NSEPRE.DataPropertyName = "NSEPRE"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.NSEPRE.DefaultCellStyle = DataGridViewCellStyle8
        Me.NSEPRE.HeaderText = "Orden"
        Me.NSEPRE.Name = "NSEPRE"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = ""
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'FLGNTE
        '
        Me.FLGNTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FLGNTE.DataPropertyName = "FLGNTE"
        Me.FLGNTE.HeaderText = "FLGNTE"
        Me.FLGNTE.Name = "FLGNTE"
        Me.FLGNTE.ReadOnly = True
        Me.FLGNTE.Visible = False
        '
        'CEMB
        '
        Me.CEMB.DataPropertyName = "CEMB"
        Me.CEMB.HeaderText = "CEMB"
        Me.CEMB.Name = "CEMB"
        Me.CEMB.ReadOnly = True
        Me.CEMB.Visible = False
        '
        'CFCHK
        '
        Me.CFCHK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CFCHK.DataPropertyName = "CFCHK"
        Me.CFCHK.HeaderText = "CFCHK"
        Me.CFCHK.Name = "CFCHK"
        Me.CFCHK.ReadOnly = True
        Me.CFCHK.Visible = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'TPNotifCliente
        '
        Me.TPNotifCliente.Controls.Add(Me.dgvNotificacionCliente)
        Me.TPNotifCliente.Location = New System.Drawing.Point(4, 22)
        Me.TPNotifCliente.Name = "TPNotifCliente"
        Me.TPNotifCliente.Padding = New System.Windows.Forms.Padding(3)
        Me.TPNotifCliente.Size = New System.Drawing.Size(920, 204)
        Me.TPNotifCliente.TabIndex = 1
        Me.TPNotifCliente.Text = "Notificación Cliente"
        Me.TPNotifCliente.UseVisualStyleBackColor = True
        '
        'dgvNotificacionCliente
        '
        Me.dgvNotificacionCliente.AllowUserToAddRows = False
        Me.dgvNotificacionCliente.AllowUserToDeleteRows = False
        Me.dgvNotificacionCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Chek, Me.EMAILTO, Me.TNMYAP, Me.TIPPROC, Me.N_CCLNT, Me.S_NLTECL, Me.N_NCRRIT, Me.S_TCMPCL, Me.Column10})
        Me.dgvNotificacionCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvNotificacionCliente.Location = New System.Drawing.Point(3, 3)
        Me.dgvNotificacionCliente.Name = "dgvNotificacionCliente"
        Me.dgvNotificacionCliente.Size = New System.Drawing.Size(914, 198)
        Me.dgvNotificacionCliente.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvNotificacionCliente.TabIndex = 0
        '
        'Chek
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.NullValue = False
        Me.Chek.DefaultCellStyle = DataGridViewCellStyle9
        Me.Chek.FalseValue = Nothing
        Me.Chek.HeaderText = "Chk"
        Me.Chek.IndeterminateValue = Nothing
        Me.Chek.Name = "Chek"
        Me.Chek.TrueValue = Nothing
        Me.Chek.Width = 40
        '
        'EMAILTO
        '
        Me.EMAILTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EMAILTO.DataPropertyName = "EMAILTO"
        Me.EMAILTO.HeaderText = "Email"
        Me.EMAILTO.Name = "EMAILTO"
        Me.EMAILTO.ReadOnly = True
        Me.EMAILTO.Width = 65
        '
        'TNMYAP
        '
        Me.TNMYAP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TNMYAP.DataPropertyName = "TNMYAP"
        Me.TNMYAP.HeaderText = "Nombres"
        Me.TNMYAP.Name = "TNMYAP"
        Me.TNMYAP.ReadOnly = True
        Me.TNMYAP.Width = 85
        '
        'TIPPROC
        '
        Me.TIPPROC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TIPPROC.DataPropertyName = "TIPPROC"
        Me.TIPPROC.HeaderText = "Div. Notificacion"
        Me.TIPPROC.Name = "TIPPROC"
        Me.TIPPROC.ReadOnly = True
        Me.TIPPROC.Width = 124
        '
        'N_CCLNT
        '
        Me.N_CCLNT.DataPropertyName = "CCLNT"
        Me.N_CCLNT.HeaderText = "N_CCLNT"
        Me.N_CCLNT.Name = "N_CCLNT"
        Me.N_CCLNT.Visible = False
        '
        'S_NLTECL
        '
        Me.S_NLTECL.DataPropertyName = "NLTECL"
        Me.S_NLTECL.HeaderText = "S_NLTECL"
        Me.S_NLTECL.Name = "S_NLTECL"
        Me.S_NLTECL.Visible = False
        '
        'N_NCRRIT
        '
        Me.N_NCRRIT.DataPropertyName = "NCRRIT"
        Me.N_NCRRIT.HeaderText = "N_NCRRIT"
        Me.N_NCRRIT.Name = "N_NCRRIT"
        Me.N_NCRRIT.Visible = False
        '
        'S_TCMPCL
        '
        Me.S_TCMPCL.DataPropertyName = "TCMPCL"
        Me.S_TCMPCL.HeaderText = "TCMPCL"
        Me.S_TCMPCL.Name = "S_TCMPCL"
        Me.S_TCMPCL.Visible = False
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column10.HeaderText = ""
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbnEliminar, Me.ToolStripSeparator5, Me.tbnModicar, Me.ToolStripSeparator7, Me.tbnAgregar, Me.ToolStripSeparator6, Me.tbnActualizarOrden, Me.ToolStripSeparator4, Me.tbnCopiarPerfil, Me.tbnExportar})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(928, 25)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tbnEliminar
        '
        Me.tbnEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tbnEliminar.Image = Global.SOLMIN_SC.My.Resources.Resources.db_remove
        Me.tbnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbnEliminar.Name = "tbnEliminar"
        Me.tbnEliminar.Size = New System.Drawing.Size(70, 22)
        Me.tbnEliminar.Text = "eliminar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'tbnModicar
        '
        Me.tbnModicar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tbnModicar.Image = Global.SOLMIN_SC.My.Resources.Resources.agt_action_success
        Me.tbnModicar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbnModicar.Name = "tbnModicar"
        Me.tbnModicar.Size = New System.Drawing.Size(78, 22)
        Me.tbnModicar.Text = "Modificar"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'tbnAgregar
        '
        Me.tbnAgregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tbnAgregar.Image = Global.SOLMIN_SC.My.Resources.Resources.db_add
        Me.tbnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbnAgregar.Name = "tbnAgregar"
        Me.tbnAgregar.Size = New System.Drawing.Size(69, 22)
        Me.tbnAgregar.Text = "Agregar"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'tbnActualizarOrden
        '
        Me.tbnActualizarOrden.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tbnActualizarOrden.Image = Global.SOLMIN_SC.My.Resources.Resources.flecha
        Me.tbnActualizarOrden.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbnActualizarOrden.Name = "tbnActualizarOrden"
        Me.tbnActualizarOrden.Size = New System.Drawing.Size(84, 22)
        Me.tbnActualizarOrden.Text = "Act. Orden"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'tbnCopiarPerfil
        '
        Me.tbnCopiarPerfil.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tbnCopiarPerfil.Image = Global.SOLMIN_SC.My.Resources.Resources.ark_selectall
        Me.tbnCopiarPerfil.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbnCopiarPerfil.Name = "tbnCopiarPerfil"
        Me.tbnCopiarPerfil.Size = New System.Drawing.Size(92, 22)
        Me.tbnCopiarPerfil.Text = "Copiar Perfil"
        '
        'tbnExportar
        '
        Me.tbnExportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tbnExportar.Image = Global.SOLMIN_SC.My.Resources.Resources.excelicon
        Me.tbnExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbnExportar.Name = "tbnExportar"
        Me.tbnExportar.Size = New System.Drawing.Size(70, 22)
        Me.tbnExportar.Text = "Exportar"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.dgvSegNotificacion)
        Me.Panel2.Controls.Add(Me.ToolStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 93)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(928, 210)
        Me.Panel2.TabIndex = 2
        '
        'dgvSegNotificacion
        '
        Me.dgvSegNotificacion.AllowUserToAddRows = False
        Me.dgvSegNotificacion.AllowUserToDeleteRows = False
        Me.dgvSegNotificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSegNotificacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COCNTF, Me.DESC_TIPPROC, Me.CCLNT, Me.TCMPCL, Me.CODFMT, Me.DES_CODFMT, Me.COD_TIPPROC, Me.Column2, Me.CCMPN, Me.CDVSN, Me.PARA_FORMATO})
        Me.dgvSegNotificacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSegNotificacion.Location = New System.Drawing.Point(0, 25)
        Me.dgvSegNotificacion.Name = "dgvSegNotificacion"
        Me.dgvSegNotificacion.ReadOnly = True
        Me.dgvSegNotificacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSegNotificacion.Size = New System.Drawing.Size(928, 185)
        Me.dgvSegNotificacion.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvSegNotificacion.TabIndex = 1
        '
        'COCNTF
        '
        Me.COCNTF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.COCNTF.DataPropertyName = "COCNTF"
        Me.COCNTF.HeaderText = "Cod."
        Me.COCNTF.Name = "COCNTF"
        Me.COCNTF.ReadOnly = True
        Me.COCNTF.Width = 61
        '
        'DESC_TIPPROC
        '
        Me.DESC_TIPPROC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DESC_TIPPROC.DataPropertyName = "DESC_TIPPROC"
        Me.DESC_TIPPROC.HeaderText = "Proc. Notificación"
        Me.DESC_TIPPROC.Name = "DESC_TIPPROC"
        Me.DESC_TIPPROC.ReadOnly = True
        Me.DESC_TIPPROC.Width = 120
        '
        'CCLNT
        '
        Me.CCLNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CCLNT.DataPropertyName = "CCLNT"
        Me.CCLNT.HeaderText = "Cod. Cliente"
        Me.CCLNT.Name = "CCLNT"
        Me.CCLNT.ReadOnly = True
        Me.CCLNT.Width = 93
        '
        'TCMPCL
        '
        Me.TCMPCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCMPCL.DataPropertyName = "TCMPCL"
        Me.TCMPCL.HeaderText = "Cliente"
        Me.TCMPCL.Name = "TCMPCL"
        Me.TCMPCL.ReadOnly = True
        Me.TCMPCL.Width = 73
        '
        'CODFMT
        '
        Me.CODFMT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CODFMT.DataPropertyName = "CODFMT"
        Me.CODFMT.HeaderText = "Formato"
        Me.CODFMT.Name = "CODFMT"
        Me.CODFMT.ReadOnly = True
        Me.CODFMT.Width = 81
        '
        'DES_CODFMT
        '
        Me.DES_CODFMT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DES_CODFMT.DataPropertyName = "DES_CODFMT"
        Me.DES_CODFMT.HeaderText = "Descripción formato"
        Me.DES_CODFMT.Name = "DES_CODFMT"
        Me.DES_CODFMT.ReadOnly = True
        Me.DES_CODFMT.Width = 132
        '
        'COD_TIPPROC
        '
        Me.COD_TIPPROC.DataPropertyName = "COD_TIPPROC"
        Me.COD_TIPPROC.HeaderText = "COD_TIPPROC"
        Me.COD_TIPPROC.Name = "COD_TIPPROC"
        Me.COD_TIPPROC.ReadOnly = True
        Me.COD_TIPPROC.Visible = False
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = ""
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'CCMPN
        '
        Me.CCMPN.DataPropertyName = "CCMPN"
        Me.CCMPN.HeaderText = "CCMPN"
        Me.CCMPN.Name = "CCMPN"
        Me.CCMPN.ReadOnly = True
        Me.CCMPN.Visible = False
        '
        'CDVSN
        '
        Me.CDVSN.DataPropertyName = "CDVSN"
        Me.CDVSN.HeaderText = "CDVSN"
        Me.CDVSN.Name = "CDVSN"
        Me.CDVSN.ReadOnly = True
        Me.CDVSN.Visible = False
        '
        'PARA_FORMATO
        '
        Me.PARA_FORMATO.DataPropertyName = "PARA_FORMATO"
        Me.PARA_FORMATO.HeaderText = "PARA_FORMATO"
        Me.PARA_FORMATO.Name = "PARA_FORMATO"
        Me.PARA_FORMATO.ReadOnly = True
        Me.PARA_FORMATO.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbnCab_Buscar, Me.ToolStripSeparator3, Me.tbnCab_Eliminar, Me.ToolStripSeparator2, Me.tbnCab_Agregar, Me.ToolStripSeparator1, Me.tbnCab_Formato, Me.btnExportarCab})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(928, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tbnCab_Buscar
        '
        Me.tbnCab_Buscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tbnCab_Buscar.Image = Global.SOLMIN_SC.My.Resources.Resources.search
        Me.tbnCab_Buscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbnCab_Buscar.Name = "tbnCab_Buscar"
        Me.tbnCab_Buscar.Size = New System.Drawing.Size(62, 22)
        Me.tbnCab_Buscar.Text = "Buscar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tbnCab_Eliminar
        '
        Me.tbnCab_Eliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tbnCab_Eliminar.Image = Global.SOLMIN_SC.My.Resources.Resources.db_remove
        Me.tbnCab_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbnCab_Eliminar.Name = "tbnCab_Eliminar"
        Me.tbnCab_Eliminar.Size = New System.Drawing.Size(70, 22)
        Me.tbnCab_Eliminar.Text = "Eliminar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tbnCab_Agregar
        '
        Me.tbnCab_Agregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tbnCab_Agregar.Image = Global.SOLMIN_SC.My.Resources.Resources.db_add
        Me.tbnCab_Agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbnCab_Agregar.Name = "tbnCab_Agregar"
        Me.tbnCab_Agregar.Size = New System.Drawing.Size(69, 22)
        Me.tbnCab_Agregar.Text = "Agregar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tbnCab_Formato
        '
        Me.tbnCab_Formato.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tbnCab_Formato.Image = Global.SOLMIN_SC.My.Resources.Resources.txt1
        Me.tbnCab_Formato.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbnCab_Formato.Name = "tbnCab_Formato"
        Me.tbnCab_Formato.Size = New System.Drawing.Size(72, 22)
        Me.tbnCab_Formato.Text = "Formato"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.cbmFormato)
        Me.Panel1.Controls.Add(Me.KryptonLabel4)
        Me.Panel1.Controls.Add(Me.txtCliente)
        Me.Panel1.Controls.Add(Me.KryptonLabel3)
        Me.Panel1.Controls.Add(Me.UcProcNotificacion)
        Me.Panel1.Controls.Add(Me.UcDivision_Cmb011)
        Me.Panel1.Controls.Add(Me.UcCompania_Cmb011)
        Me.Panel1.Controls.Add(Me.KryptonLabel1)
        Me.Panel1.Controls.Add(Me.KryptonLabel6)
        Me.Panel1.Controls.Add(Me.KryptonLabel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(928, 93)
        Me.Panel1.TabIndex = 0
        '
        'cbmFormato
        '
        Me.cbmFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmFormato.DropDownWidth = 181
        Me.cbmFormato.FormattingEnabled = False
        Me.cbmFormato.ItemHeight = 15
        Me.cbmFormato.Location = New System.Drawing.Point(712, 55)
        Me.cbmFormato.Name = "cbmFormato"
        Me.cbmFormato.Size = New System.Drawing.Size(181, 23)
        Me.cbmFormato.TabIndex = 67
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(648, 55)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(63, 20)
        Me.KryptonLabel4.TabIndex = 66
        Me.KryptonLabel4.Text = "Formato :"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Formato :"
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.White
        Me.txtCliente.CCMPN = "EZ"
        Me.txtCliente.Location = New System.Drawing.Point(90, 55)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pRequerido = False
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(239, 22)
        Me.txtCliente.TabIndex = 65
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(12, 55)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(54, 20)
        Me.KryptonLabel3.TabIndex = 64
        Me.KryptonLabel3.Text = "Cliente :"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Cliente :"
        '
        'UcProcNotificacion
        '
        Me.UcProcNotificacion.BackColor = System.Drawing.Color.Transparent
        Me.UcProcNotificacion.DataSource = Nothing
        Me.UcProcNotificacion.DispleyMember = ""
        Me.UcProcNotificacion.Etiquetas_Form = Nothing
        Me.UcProcNotificacion.ListColumnas = Nothing
        Me.UcProcNotificacion.Location = New System.Drawing.Point(422, 55)
        Me.UcProcNotificacion.Name = "UcProcNotificacion"
        Me.UcProcNotificacion.Obligatorio = False
        Me.UcProcNotificacion.PopupHeight = 0
        Me.UcProcNotificacion.PopupWidth = 0
        Me.UcProcNotificacion.Size = New System.Drawing.Size(200, 25)
        Me.UcProcNotificacion.TabIndex = 63
        Me.UcProcNotificacion.ValueMember = ""
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
        Me.UcDivision_Cmb011.Location = New System.Drawing.Point(422, 14)
        Me.UcDivision_Cmb011.MinimumSize = New System.Drawing.Size(150, 21)
        Me.UcDivision_Cmb011.Name = "UcDivision_Cmb011"
        Me.UcDivision_Cmb011.obeDivision = Nothing
        Me.UcDivision_Cmb011.pHabilitado = True
        Me.UcDivision_Cmb011.pRequerido = False
        Me.UcDivision_Cmb011.Size = New System.Drawing.Size(200, 23)
        Me.UcDivision_Cmb011.TabIndex = 2
        Me.UcDivision_Cmb011.Usuario = ""
        '
        'UcCompania_Cmb011
        '
        Me.UcCompania_Cmb011.BackColor = System.Drawing.SystemColors.Window
        Me.UcCompania_Cmb011.CCMPN_ANTERIOR = Nothing
        Me.UcCompania_Cmb011.CCMPN_CodigoCompania = ""
        Me.UcCompania_Cmb011.CCMPN_CompaniaDefault = Nothing
        Me.UcCompania_Cmb011.CCMPN_Descripcion = Nothing
        Me.UcCompania_Cmb011.Habilitar = True
        Me.UcCompania_Cmb011.Location = New System.Drawing.Point(90, 14)
        Me.UcCompania_Cmb011.MinimumSize = New System.Drawing.Size(150, 23)
        Me.UcCompania_Cmb011.Name = "UcCompania_Cmb011"
        BeCompania2.CCMPN_CodigoCompania = ""
        BeCompania2.Orden = -1
        BeCompania2.TCMPCM_DescripcionCompania = ""
        Me.UcCompania_Cmb011.oBeCompania = BeCompania2
        Me.UcCompania_Cmb011.Size = New System.Drawing.Size(239, 26)
        Me.UcCompania_Cmb011.TabIndex = 1
        Me.UcCompania_Cmb011.Usuario = ""
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(12, 14)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(72, 20)
        Me.KryptonLabel1.TabIndex = 9
        Me.KryptonLabel1.Text = "Compañia : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Compañia : "
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(335, 14)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(60, 20)
        Me.KryptonLabel6.TabIndex = 60
        Me.KryptonLabel6.Text = "Division : "
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Division : "
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(335, 55)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(74, 20)
        Me.KryptonLabel2.TabIndex = 1
        Me.KryptonLabel2.Text = "Proc. Notif :"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Proc. Notif :"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CFCHK"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cod Check"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TCOLUM"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tipo CheckPoint"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FLGNTE"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre en Seguimiento"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CEMB"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Notificar"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NSEPRE"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn5.HeaderText = ""
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CEMB"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn6.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NESTDO"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Nombres"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CEMB"
        Me.DataGridViewTextBoxColumn8.HeaderText = "BU"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "COCNTF"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn9.HeaderText = ""
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CCLNT"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "TCMPCL"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Proc. Notificación"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "DESC_TIPPROC"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Formato"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "CODFMT"
        Me.DataGridViewTextBoxColumn13.HeaderText = ""
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "DES_CODFMT"
        Me.DataGridViewTextBoxColumn14.HeaderText = ""
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "COD_TIPPROC"
        Me.DataGridViewTextBoxColumn15.HeaderText = ""
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "NCRRIT"
        Me.DataGridViewTextBoxColumn16.HeaderText = "NCRRIT"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "COD_TIPPROC"
        Me.DataGridViewTextBoxColumn17.HeaderText = "COD_TIPPROC"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "CCMPN"
        Me.DataGridViewTextBoxColumn18.HeaderText = "CCMPN"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Visible = False
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "CDVSN"
        Me.DataGridViewTextBoxColumn19.HeaderText = "CDVSN"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Visible = False
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "CCMPN"
        Me.DataGridViewTextBoxColumn20.HeaderText = "CCMPN"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Visible = False
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "CDVSN"
        Me.DataGridViewTextBoxColumn21.HeaderText = "CDVSN"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Visible = False
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "DES_CODFMT"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "COD_TIPPROC"
        Me.DataGridViewTextBoxColumn23.HeaderText = "COD_TIPPROC"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Visible = False
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "CCMPN"
        Me.DataGridViewTextBoxColumn24.HeaderText = "CCMPN"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Visible = False
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "CDVSN"
        Me.DataGridViewTextBoxColumn25.HeaderText = "CDVSN"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Visible = False
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "CCMPN"
        Me.DataGridViewTextBoxColumn26.HeaderText = "CCMPN"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.Visible = False
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "CDVSN"
        Me.DataGridViewTextBoxColumn27.HeaderText = "CDVSN"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.Visible = False
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "PARA_FORMATO"
        Me.DataGridViewTextBoxColumn28.HeaderText = "PARA_FORMATO"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.Visible = False
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "CCMPN"
        Me.DataGridViewTextBoxColumn29.HeaderText = "CCMPN"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.Visible = False
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "CDVSN"
        Me.DataGridViewTextBoxColumn30.HeaderText = "CDVSN"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.Visible = False
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "PARA_FORMATO"
        Me.DataGridViewTextBoxColumn31.HeaderText = "PARA_FORMATO"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.Visible = False
        '
        'btnExportarCab
        '
        Me.btnExportarCab.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExportarCab.Image = Global.SOLMIN_SC.My.Resources.Resources.excelicon
        Me.btnExportarCab.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportarCab.Name = "btnExportarCab"
        Me.btnExportarCab.Size = New System.Drawing.Size(70, 22)
        Me.btnExportarCab.Text = "Exportar"
        '
        'frmSegNotificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 558)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmSegNotificacion"
        Me.Text = "Seguimiento Notificacion"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TPCheckPoints.ResumeLayout(False)
        CType(Me.dgvCheckPointsNotificacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPNotifCliente.ResumeLayout(False)
        CType(Me.dgvNotificacionCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvSegNotificacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcDivision_Cmb011 As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Friend WithEvents UcCompania_Cmb011 As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Private WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TPCheckPoints As System.Windows.Forms.TabPage
    Friend WithEvents TPNotifCliente As System.Windows.Forms.TabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tbnCab_Buscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbnCab_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbnCab_Agregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbnModicar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbnAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbnExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvCheckPointsNotificacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dgvNotificacionCliente As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dgvSegNotificacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UcProcNotificacion As Ransa.Utilitario.ucAyuda
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbmFormato As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tbnCopiarPerfil As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbnCab_Formato As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbnActualizarOrden As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COCNTF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESC_TIPPROC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMPCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODFMT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DES_CODFMT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COD_TIPPROC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCMPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CDVSN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PARA_FORMATO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Chk As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
    Friend WithEvents NESTDO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DES_TIPOCHK As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CHK_DES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CHK_DES_SEG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCOLUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOTIFICAR_CHK As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VER_CHK As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FLGEST As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NSEPRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FLGNTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CEMB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CFCHK As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Chek As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
    Friend WithEvents EMAILTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TNMYAP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPPROC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents N_CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_NLTECL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents N_NCRRIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_TCMPCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnExportarCab As System.Windows.Forms.ToolStripButton
End Class
