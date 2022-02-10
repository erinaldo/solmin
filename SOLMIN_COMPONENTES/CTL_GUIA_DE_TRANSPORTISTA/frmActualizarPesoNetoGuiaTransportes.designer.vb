<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActualizarPesoNetoGuiaTransportes
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.dtgGuiaRemisionPesoNeto = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.NGUIRM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTRMNC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NRGUCL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NGUIRS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QPSOBL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCLNGR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PMRCMC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuBar_0 = New System.Windows.Forms.ToolStrip()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnActualizarPesoNetoGT = New System.Windows.Forms.ToolStripButton()
        Me.panelFiltro = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.lbldiferencia = New System.Windows.Forms.Label()
        Me.lblnroop = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.pbimage = New System.Windows.Forms.PictureBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtPesoNetoGT = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtPesoTotalGRAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblNombre = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSinPeso = New System.Windows.Forms.Label()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dtgGuiaRemisionPesoNeto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuBar_0.SuspendLayout()
        CType(Me.panelFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelFiltro.SuspendLayout()
        CType(Me.pbimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dtgGuiaRemisionPesoNeto)
        Me.KryptonPanel.Controls.Add(Me.MenuBar_0)
        Me.KryptonPanel.Controls.Add(Me.panelFiltro)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(903, 501)
        Me.KryptonPanel.TabIndex = 0
        '
        'dtgGuiaRemisionPesoNeto
        '
        Me.dtgGuiaRemisionPesoNeto.AllowUserToAddRows = False
        Me.dtgGuiaRemisionPesoNeto.AllowUserToDeleteRows = False
        Me.dtgGuiaRemisionPesoNeto.AllowUserToResizeColumns = False
        Me.dtgGuiaRemisionPesoNeto.AllowUserToResizeRows = False
        Me.dtgGuiaRemisionPesoNeto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgGuiaRemisionPesoNeto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgGuiaRemisionPesoNeto.ColumnHeadersHeight = 30
        Me.dtgGuiaRemisionPesoNeto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NGUIRM, Me.CTRMNC, Me.CCLNT, Me.NRGUCL, Me.NGUIRS, Me.QPSOBL, Me.CCLNGR, Me.PMRCMC})
        Me.dtgGuiaRemisionPesoNeto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgGuiaRemisionPesoNeto.Location = New System.Drawing.Point(0, 105)
        Me.dtgGuiaRemisionPesoNeto.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgGuiaRemisionPesoNeto.Name = "dtgGuiaRemisionPesoNeto"
        Me.dtgGuiaRemisionPesoNeto.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.dtgGuiaRemisionPesoNeto.RowHeadersVisible = False
        Me.dtgGuiaRemisionPesoNeto.RowHeadersWidth = 20
        Me.dtgGuiaRemisionPesoNeto.Size = New System.Drawing.Size(903, 396)
        Me.dtgGuiaRemisionPesoNeto.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgGuiaRemisionPesoNeto.TabIndex = 0
        '
        'NGUIRM
        '
        Me.NGUIRM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NGUIRM.DataPropertyName = "NGUIRM"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NGUIRM.DefaultCellStyle = DataGridViewCellStyle1
        Me.NGUIRM.HeaderText = "NGUIRM"
        Me.NGUIRM.MinimumWidth = 310
        Me.NGUIRM.Name = "NGUIRM"
        Me.NGUIRM.ReadOnly = True
        Me.NGUIRM.Visible = False
        Me.NGUIRM.Width = 310
        '
        'CTRMNC
        '
        Me.CTRMNC.DataPropertyName = "CTRMNC"
        Me.CTRMNC.HeaderText = "CTRMNC"
        Me.CTRMNC.Name = "CTRMNC"
        Me.CTRMNC.Visible = False
        '
        'CCLNT
        '
        Me.CCLNT.DataPropertyName = "CCLNT"
        Me.CCLNT.HeaderText = "CCLNT"
        Me.CCLNT.Name = "CCLNT"
        Me.CCLNT.Visible = False
        '
        'NRGUCL
        '
        Me.NRGUCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.NRGUCL.DataPropertyName = "NRGUCL"
        Me.NRGUCL.HeaderText = "Id Guía R."
        Me.NRGUCL.MinimumWidth = 290
        Me.NRGUCL.Name = "NRGUCL"
        Me.NRGUCL.Width = 290
        '
        'NGUIRS
        '
        Me.NGUIRS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NGUIRS.DataPropertyName = "NGUIRS"
        Me.NGUIRS.HeaderText = "GR Cliente"
        Me.NGUIRS.Name = "NGUIRS"
        Me.NGUIRS.Width = 111
        '
        'QPSOBL
        '
        Me.QPSOBL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QPSOBL.DataPropertyName = "QPSOBL"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.QPSOBL.DefaultCellStyle = DataGridViewCellStyle2
        Me.QPSOBL.HeaderText = "Peso GR Alm."
        Me.QPSOBL.MinimumWidth = 290
        Me.QPSOBL.Name = "QPSOBL"
        Me.QPSOBL.ReadOnly = True
        Me.QPSOBL.Width = 290
        '
        'CCLNGR
        '
        Me.CCLNGR.DataPropertyName = "CCLNGR"
        Me.CCLNGR.HeaderText = "CCLNGR"
        Me.CCLNGR.Name = "CCLNGR"
        Me.CCLNGR.Visible = False
        '
        'PMRCMC
        '
        Me.PMRCMC.DataPropertyName = "PMRCMC"
        Me.PMRCMC.HeaderText = "PMRCMC"
        Me.PMRCMC.Name = "PMRCMC"
        Me.PMRCMC.Visible = False
        '
        'MenuBar_0
        '
        Me.MenuBar_0.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.MenuBar_0.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar_0.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuBar_0.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.ToolStripSeparator1, Me.btnActualizarPesoNetoGT})
        Me.MenuBar_0.Location = New System.Drawing.Point(0, 78)
        Me.MenuBar_0.Name = "MenuBar_0"
        Me.MenuBar_0.Size = New System.Drawing.Size(903, 27)
        Me.MenuBar_0.TabIndex = 9
        Me.MenuBar_0.Text = "ToolStrip1"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.CTL_GUIA_DE_TRANSPORTISTA.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(91, 24)
        Me.btnCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'btnActualizarPesoNetoGT
        '
        Me.btnActualizarPesoNetoGT.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnActualizarPesoNetoGT.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarPesoNetoGT.Image = Global.CTL_GUIA_DE_TRANSPORTISTA.My.Resources.Resources.button_ok
        Me.btnActualizarPesoNetoGT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnActualizarPesoNetoGT.Name = "btnActualizarPesoNetoGT"
        Me.btnActualizarPesoNetoGT.Size = New System.Drawing.Size(240, 24)
        Me.btnActualizarPesoNetoGT.Text = "Actualizar peso almacén -> GT"
        '
        'panelFiltro
        '
        Me.panelFiltro.Controls.Add(Me.lblSinPeso)
        Me.panelFiltro.Controls.Add(Me.lbldiferencia)
        Me.panelFiltro.Controls.Add(Me.lblnroop)
        Me.panelFiltro.Controls.Add(Me.KryptonLabel3)
        Me.panelFiltro.Controls.Add(Me.pbimage)
        Me.panelFiltro.Controls.Add(Me.KryptonLabel1)
        Me.panelFiltro.Controls.Add(Me.txtPesoNetoGT)
        Me.panelFiltro.Controls.Add(Me.txtPesoTotalGRAlmacen)
        Me.panelFiltro.Controls.Add(Me.lblNombre)
        Me.panelFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelFiltro.Location = New System.Drawing.Point(0, 0)
        Me.panelFiltro.Margin = New System.Windows.Forms.Padding(4)
        Me.panelFiltro.Name = "panelFiltro"
        Me.panelFiltro.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.panelFiltro.Size = New System.Drawing.Size(903, 78)
        Me.panelFiltro.StateCommon.Color1 = System.Drawing.Color.White
        Me.panelFiltro.TabIndex = 2
        '
        'lbldiferencia
        '
        Me.lbldiferencia.AutoSize = True
        Me.lbldiferencia.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbldiferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldiferencia.Location = New System.Drawing.Point(645, 39)
        Me.lbldiferencia.Name = "lbldiferencia"
        Me.lbldiferencia.Size = New System.Drawing.Size(23, 17)
        Me.lbldiferencia.TabIndex = 20
        Me.lbldiferencia.Text = "..."
        '
        'lblnroop
        '
        Me.lblnroop.Location = New System.Drawing.Point(88, 8)
        Me.lblnroop.Margin = New System.Windows.Forms.Padding(4)
        Me.lblnroop.Name = "lblnroop"
        Me.lblnroop.Size = New System.Drawing.Size(22, 26)
        Me.lblnroop.TabIndex = 19
        Me.lblnroop.Text = "..."
        Me.lblnroop.Values.ExtraText = ""
        Me.lblnroop.Values.Image = Nothing
        Me.lblnroop.Values.Text = "..."
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(13, 8)
        Me.KryptonLabel3.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(66, 26)
        Me.KryptonLabel3.TabIndex = 18
        Me.KryptonLabel3.Text = "Nro Op:"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Nro Op:"
        '
        'pbimage
        '
        Me.pbimage.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pbimage.Location = New System.Drawing.Point(525, 31)
        Me.pbimage.Name = "pbimage"
        Me.pbimage.Size = New System.Drawing.Size(54, 35)
        Me.pbimage.TabIndex = 17
        Me.pbimage.TabStop = False
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(220, 39)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(107, 26)
        Me.KryptonLabel1.TabIndex = 12
        Me.KryptonLabel1.Text = "Peso Almacén"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Peso Almacén"
        '
        'txtPesoNetoGT
        '
        Me.txtPesoNetoGT.Enabled = False
        Me.txtPesoNetoGT.Location = New System.Drawing.Point(88, 37)
        Me.txtPesoNetoGT.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPesoNetoGT.MaxLength = 20
        Me.txtPesoNetoGT.Name = "txtPesoNetoGT"
        Me.txtPesoNetoGT.ReadOnly = True
        Me.txtPesoNetoGT.Size = New System.Drawing.Size(124, 26)
        Me.txtPesoNetoGT.TabIndex = 0
        Me.txtPesoNetoGT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPesoTotalGRAlmacen
        '
        Me.txtPesoTotalGRAlmacen.Enabled = False
        Me.txtPesoTotalGRAlmacen.Location = New System.Drawing.Point(351, 37)
        Me.txtPesoTotalGRAlmacen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPesoTotalGRAlmacen.MaxLength = 10
        Me.txtPesoTotalGRAlmacen.Name = "txtPesoTotalGRAlmacen"
        Me.txtPesoTotalGRAlmacen.ReadOnly = True
        Me.txtPesoTotalGRAlmacen.Size = New System.Drawing.Size(128, 26)
        Me.txtPesoTotalGRAlmacen.TabIndex = 1
        Me.txtPesoTotalGRAlmacen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblNombre
        '
        Me.lblNombre.Location = New System.Drawing.Point(13, 39)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(67, 26)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Peso GT"
        Me.lblNombre.Values.ExtraText = ""
        Me.lblNombre.Values.Image = Nothing
        Me.lblNombre.Values.Text = "Peso GT"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "DNGUIRS"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn1.HeaderText = "N° Guía Remisión"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 310
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FGUIRM_S"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha Guía Remisión"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 310
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TCMPCL"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CCLNT"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CCLNT"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 310
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CPRVCL"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn5.HeaderText = "CPRVCL"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 310
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NGUIRM"
        Me.DataGridViewTextBoxColumn6.HeaderText = "NGUIRM"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PMRCMC"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn7.HeaderText = "NGUIRM_S"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "NGUIRS"
        Me.DataGridViewTextBoxColumn8.HeaderText = "NGUIRS"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "CTDGRM"
        Me.DataGridViewTextBoxColumn9.HeaderText = "CTDGRM"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'lblSinPeso
        '
        Me.lblSinPeso.AutoSize = True
        Me.lblSinPeso.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSinPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSinPeso.ForeColor = System.Drawing.Color.Red
        Me.lblSinPeso.Location = New System.Drawing.Point(645, 9)
        Me.lblSinPeso.Name = "lblSinPeso"
        Me.lblSinPeso.Size = New System.Drawing.Size(23, 18)
        Me.lblSinPeso.TabIndex = 21
        Me.lblSinPeso.Text = "..."
        '
        'frmActualizarPesoNetoGuiaTransportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 501)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmActualizarPesoNetoGuiaTransportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar Peso Neto Guia Transportes"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dtgGuiaRemisionPesoNeto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuBar_0.ResumeLayout(False)
        Me.MenuBar_0.PerformLayout()
        CType(Me.panelFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelFiltro.ResumeLayout(False)
        Me.panelFiltro.PerformLayout()
        CType(Me.pbimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents panelFiltro As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents dtgGuiaRemisionPesoNeto As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents MenuBar_0 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnActualizarPesoNetoGT As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPesoNetoGT As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtPesoTotalGRAlmacen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblNombre As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents pbimage As System.Windows.Forms.PictureBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblnroop As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents NGUIRM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTRMNC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRGUCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NGUIRS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QPSOBL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNGR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PMRCMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbldiferencia As System.Windows.Forms.Label
    Friend WithEvents lblSinPeso As System.Windows.Forms.Label
End Class
