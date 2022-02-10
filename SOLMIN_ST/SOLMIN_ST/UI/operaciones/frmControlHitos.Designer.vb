<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControlHitos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtHoraInicio = New System.Windows.Forms.MaskedTextBox
        Me.txtHito = New System.Windows.Forms.TextBox
        Me.txtLugarEntrega = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.lblGuiaTransp = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblOperacion = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dtgGuias = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.CHKGUIA = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.GUIA_REM_CLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FECHA_DESTINO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LUGAR_DESTINO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FLGCNL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txthoraparcial = New System.Windows.Forms.MaskedTextBox
        Me.txtLugarParcial = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.dtpFechaParcial = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtObservacion = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cboIncidencia = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.ckbEntregaParcial = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtgDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
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
        Me.NESTDO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCOLUM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FRETES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HRAREA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.INCIDENCIA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.INCVJE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TOBEST = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ENVIA_GR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.REQUIERE_GT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ASIG_UNID_ESPERA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnEliminar = New System.Windows.Forms.DataGridViewImageColumn
        Me.ES_HORA_OBLIGAT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dtgGuias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.txtHoraInicio)
        Me.GroupBox2.Controls.Add(Me.txtHito)
        Me.GroupBox2.Controls.Add(Me.txtLugarEntrega)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.ToolStrip1)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtObservacion)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cboIncidencia)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.dtpFecha)
        Me.GroupBox2.Controls.Add(Me.ckbEntregaParcial)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 219)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(911, 336)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'txtHoraInicio
        '
        Me.txtHoraInicio.Location = New System.Drawing.Point(195, 151)
        Me.txtHoraInicio.Mask = "00:00"
        Me.txtHoraInicio.Name = "txtHoraInicio"
        Me.txtHoraInicio.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txtHoraInicio.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraInicio.TabIndex = 71
        Me.txtHoraInicio.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'txtHito
        '
        Me.txtHito.Enabled = False
        Me.txtHito.Location = New System.Drawing.Point(88, 121)
        Me.txtHito.Name = "txtHito"
        Me.txtHito.Size = New System.Drawing.Size(159, 20)
        Me.txtHito.TabIndex = 0
        '
        'txtLugarEntrega
        '
        Me.txtLugarEntrega.Location = New System.Drawing.Point(88, 177)
        Me.txtLugarEntrega.MaxLength = 50
        Me.txtLugarEntrega.Name = "txtLugarEntrega"
        Me.txtLugarEntrega.Size = New System.Drawing.Size(255, 20)
        Me.txtLugarEntrega.TabIndex = 4
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblGuiaTransp)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.lblOperacion)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Location = New System.Drawing.Point(3, 41)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(352, 69)
        Me.GroupBox4.TabIndex = 26
        Me.GroupBox4.TabStop = False
        '
        'lblGuiaTransp
        '
        Me.lblGuiaTransp.AutoSize = True
        Me.lblGuiaTransp.Location = New System.Drawing.Point(126, 41)
        Me.lblGuiaTransp.Name = "lblGuiaTransp"
        Me.lblGuiaTransp.Size = New System.Drawing.Size(28, 13)
        Me.lblGuiaTransp.TabIndex = 3
        Me.lblGuiaTransp.Text = "[GT]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Guía Transporte"
        '
        'lblOperacion
        '
        Me.lblOperacion.AutoSize = True
        Me.lblOperacion.Location = New System.Drawing.Point(126, 21)
        Me.lblOperacion.Name = "lblOperacion"
        Me.lblOperacion.Size = New System.Drawing.Size(76, 13)
        Me.lblOperacion.TabIndex = 1
        Me.lblOperacion.Text = "[OPERACION]"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Número de Operación"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGuardar, Me.ToolStripSeparator1, Me.btnCancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(352, 25)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(69, 22)
        Me.btnGuardar.Text = "Guardar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(73, 22)
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtgGuias)
        Me.GroupBox3.Controls.Add(Me.Panel1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox3.Location = New System.Drawing.Point(355, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(553, 317)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        '
        'dtgGuias
        '
        Me.dtgGuias.AllowUserToAddRows = False
        Me.dtgGuias.AllowUserToDeleteRows = False
        Me.dtgGuias.AllowUserToResizeColumns = False
        Me.dtgGuias.AllowUserToResizeRows = False
        Me.dtgGuias.ColumnHeadersHeight = 30
        Me.dtgGuias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgGuias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CHKGUIA, Me.GUIA_REM_CLIENTE, Me.ESTADO, Me.FECHA_DESTINO, Me.LUGAR_DESTINO, Me.FLGCNL})
        Me.dtgGuias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgGuias.Location = New System.Drawing.Point(3, 59)
        Me.dtgGuias.MultiSelect = False
        Me.dtgGuias.Name = "dtgGuias"
        Me.dtgGuias.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.dtgGuias.RowHeadersVisible = False
        Me.dtgGuias.RowHeadersWidth = 20
        Me.dtgGuias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dtgGuias.Size = New System.Drawing.Size(547, 255)
        Me.dtgGuias.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgGuias.TabIndex = 19
        '
        'CHKGUIA
        '
        Me.CHKGUIA.HeaderText = ""
        Me.CHKGUIA.Name = "CHKGUIA"
        Me.CHKGUIA.Width = 40
        '
        'GUIA_REM_CLIENTE
        '
        Me.GUIA_REM_CLIENTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.GUIA_REM_CLIENTE.DataPropertyName = "GUIA_REM_CLIENTE"
        Me.GUIA_REM_CLIENTE.HeaderText = "Guía"
        Me.GUIA_REM_CLIENTE.Name = "GUIA_REM_CLIENTE"
        Me.GUIA_REM_CLIENTE.ReadOnly = True
        Me.GUIA_REM_CLIENTE.Width = 60
        '
        'ESTADO
        '
        Me.ESTADO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ESTADO.DataPropertyName = "ESTADO"
        Me.ESTADO.HeaderText = "Estado Entrega"
        Me.ESTADO.Name = "ESTADO"
        Me.ESTADO.ReadOnly = True
        Me.ESTADO.Width = 114
        '
        'FECHA_DESTINO
        '
        Me.FECHA_DESTINO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FECHA_DESTINO.DataPropertyName = "FECHA_DESTINO"
        Me.FECHA_DESTINO.HeaderText = "Fecha Entrega"
        Me.FECHA_DESTINO.Name = "FECHA_DESTINO"
        Me.FECHA_DESTINO.ReadOnly = True
        Me.FECHA_DESTINO.Width = 110
        '
        'LUGAR_DESTINO
        '
        Me.LUGAR_DESTINO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.LUGAR_DESTINO.DataPropertyName = "LUGAR_DESTINO"
        Me.LUGAR_DESTINO.HeaderText = "Lugar entrega"
        Me.LUGAR_DESTINO.Name = "LUGAR_DESTINO"
        Me.LUGAR_DESTINO.ReadOnly = True
        Me.LUGAR_DESTINO.Width = 109
        '
        'FLGCNL
        '
        Me.FLGCNL.DataPropertyName = "FLGCNL"
        Me.FLGCNL.HeaderText = "FLGCNL"
        Me.FLGCNL.Name = "FLGCNL"
        Me.FLGCNL.ReadOnly = True
        Me.FLGCNL.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txthoraparcial)
        Me.Panel1.Controls.Add(Me.txtLugarParcial)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.dtpFechaParcial)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(547, 43)
        Me.Panel1.TabIndex = 18
        '
        'txthoraparcial
        '
        Me.txthoraparcial.Location = New System.Drawing.Point(179, 7)
        Me.txthoraparcial.Mask = "00:00"
        Me.txthoraparcial.Name = "txthoraparcial"
        Me.txthoraparcial.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txthoraparcial.Size = New System.Drawing.Size(63, 20)
        Me.txthoraparcial.TabIndex = 72
        Me.txthoraparcial.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'txtLugarParcial
        '
        Me.txtLugarParcial.Location = New System.Drawing.Point(323, 7)
        Me.txtLugarParcial.MaxLength = 50
        Me.txtLugarParcial.Name = "txtLugarParcial"
        Me.txtLugarParcial.Size = New System.Drawing.Size(218, 20)
        Me.txtLugarParcial.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(248, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Lugar Parcial"
        '
        'dtpFechaParcial
        '
        Me.dtpFechaParcial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaParcial.Location = New System.Drawing.Point(73, 7)
        Me.dtpFechaParcial.Name = "dtpFechaParcial"
        Me.dtpFechaParcial.Size = New System.Drawing.Size(102, 20)
        Me.dtpFechaParcial.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Fecha parcial"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Lugar Final"
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(88, 238)
        Me.txtObservacion.MaxLength = 250
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacion.Size = New System.Drawing.Size(255, 74)
        Me.txtObservacion.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Observación"
        '
        'cboIncidencia
        '
        Me.cboIncidencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIncidencia.FormattingEnabled = True
        Me.cboIncidencia.Location = New System.Drawing.Point(88, 208)
        Me.cboIncidencia.Name = "cboIncidencia"
        Me.cboIncidencia.Size = New System.Drawing.Size(255, 21)
        Me.cboIncidencia.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Incidencia"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(88, 151)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(102, 20)
        Me.dtpFecha.TabIndex = 1
        '
        'ckbEntregaParcial
        '
        Me.ckbEntregaParcial.AutoSize = True
        Me.ckbEntregaParcial.Enabled = False
        Me.ckbEntregaParcial.Location = New System.Drawing.Point(251, 124)
        Me.ckbEntregaParcial.Name = "ckbEntregaParcial"
        Me.ckbEntregaParcial.Size = New System.Drawing.Size(98, 17)
        Me.ckbEntregaParcial.TabIndex = 3
        Me.ckbEntregaParcial.Text = "Entrega Parcial"
        Me.ckbEntregaParcial.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha Final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hito de Control"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.dtgDatos)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(911, 219)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'dtgDatos
        '
        Me.dtgDatos.AllowUserToAddRows = False
        Me.dtgDatos.AllowUserToDeleteRows = False
        Me.dtgDatos.AllowUserToResizeColumns = False
        Me.dtgDatos.AllowUserToResizeRows = False
        Me.dtgDatos.ColumnHeadersHeight = 30
        Me.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NESTDO, Me.TCOLUM, Me.FRETES, Me.HRAREA, Me.INCIDENCIA, Me.INCVJE, Me.TOBEST, Me.ENVIA_GR, Me.REQUIERE_GT, Me.ASIG_UNID_ESPERA, Me.btnEliminar, Me.ES_HORA_OBLIGAT})
        Me.dtgDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgDatos.Location = New System.Drawing.Point(3, 16)
        Me.dtgDatos.Name = "dtgDatos"
        Me.dtgDatos.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.dtgDatos.ReadOnly = True
        Me.dtgDatos.RowHeadersVisible = False
        Me.dtgDatos.RowHeadersWidth = 20
        Me.dtgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgDatos.Size = New System.Drawing.Size(905, 200)
        Me.dtgDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgDatos.TabIndex = 6
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NESTDO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Hito"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FESEST"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FESEST"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Hora"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "FESEST"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Incidencia"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TOBEST"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Observación"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "INCIDENCIA"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Guias"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TOBEST"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Estado Entrega"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "TOBEST"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ESTADO"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Lugar Entrega"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "FECHA_DESTINO"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "LUGAR_DESTINO"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Lugar Entrega"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "FLGCNL"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Lugar Entrega"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "FECHA_DESTINO"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Fecha Entrega"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "LUGAR_DESTINO"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Lugar entrega"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "FLGCNL"
        Me.DataGridViewTextBoxColumn15.HeaderText = "FLGCNL"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'NESTDO
        '
        Me.NESTDO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NESTDO.DataPropertyName = "NESTDO"
        Me.NESTDO.HeaderText = "CODHITO"
        Me.NESTDO.Name = "NESTDO"
        Me.NESTDO.ReadOnly = True
        Me.NESTDO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NESTDO.Visible = False
        Me.NESTDO.Width = 69
        '
        'TCOLUM
        '
        Me.TCOLUM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCOLUM.DataPropertyName = "DESCRIPCION"
        Me.TCOLUM.HeaderText = "Hito"
        Me.TCOLUM.Name = "TCOLUM"
        Me.TCOLUM.ReadOnly = True
        Me.TCOLUM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TCOLUM.Width = 40
        '
        'FRETES
        '
        Me.FRETES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FRETES.DataPropertyName = "FECHA"
        Me.FRETES.HeaderText = "Fecha"
        Me.FRETES.Name = "FRETES"
        Me.FRETES.ReadOnly = True
        Me.FRETES.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.FRETES.Width = 48
        '
        'HRAREA
        '
        Me.HRAREA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.HRAREA.DataPropertyName = "HORA"
        Me.HRAREA.HeaderText = "Hora"
        Me.HRAREA.Name = "HRAREA"
        Me.HRAREA.ReadOnly = True
        Me.HRAREA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.HRAREA.Width = 43
        '
        'INCIDENCIA
        '
        Me.INCIDENCIA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.INCIDENCIA.DataPropertyName = "DESC_INC_VJE"
        Me.INCIDENCIA.HeaderText = "Incidencia"
        Me.INCIDENCIA.Name = "INCIDENCIA"
        Me.INCIDENCIA.ReadOnly = True
        Me.INCIDENCIA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.INCIDENCIA.Width = 71
        '
        'INCVJE
        '
        Me.INCVJE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.INCVJE.DataPropertyName = "COD_INC_VJE"
        Me.INCVJE.HeaderText = "INCVJE"
        Me.INCVJE.Name = "INCVJE"
        Me.INCVJE.ReadOnly = True
        Me.INCVJE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.INCVJE.Visible = False
        Me.INCVJE.Width = 54
        '
        'TOBEST
        '
        Me.TOBEST.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TOBEST.DataPropertyName = "OBS"
        Me.TOBEST.HeaderText = "Observación"
        Me.TOBEST.Name = "TOBEST"
        Me.TOBEST.ReadOnly = True
        Me.TOBEST.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ENVIA_GR
        '
        Me.ENVIA_GR.DataPropertyName = "ENVIA_GR"
        Me.ENVIA_GR.HeaderText = "ENVIA_GR"
        Me.ENVIA_GR.Name = "ENVIA_GR"
        Me.ENVIA_GR.ReadOnly = True
        Me.ENVIA_GR.Visible = False
        '
        'REQUIERE_GT
        '
        Me.REQUIERE_GT.DataPropertyName = "REQUIERE_GT"
        Me.REQUIERE_GT.HeaderText = "REQUIERE_GT"
        Me.REQUIERE_GT.Name = "REQUIERE_GT"
        Me.REQUIERE_GT.ReadOnly = True
        Me.REQUIERE_GT.Visible = False
        '
        'ASIG_UNID_ESPERA
        '
        Me.ASIG_UNID_ESPERA.DataPropertyName = "ASIG_UNID_ESPERA"
        Me.ASIG_UNID_ESPERA.HeaderText = "ASIG_UNID_ESPERA"
        Me.ASIG_UNID_ESPERA.Name = "ASIG_UNID_ESPERA"
        Me.ASIG_UNID_ESPERA.ReadOnly = True
        Me.ASIG_UNID_ESPERA.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.btnEliminar.HeaderText = "Anul."
        Me.btnEliminar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.ReadOnly = True
        Me.btnEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.btnEliminar.Width = 45
        '
        'ES_HORA_OBLIGAT
        '
        Me.ES_HORA_OBLIGAT.DataPropertyName = "ES_HORA_OBLIGAT"
        Me.ES_HORA_OBLIGAT.HeaderText = "ES_HORA_OBLIGAT"
        Me.ES_HORA_OBLIGAT.Name = "ES_HORA_OBLIGAT"
        Me.ES_HORA_OBLIGAT.ReadOnly = True
        Me.ES_HORA_OBLIGAT.Visible = False
        '
        'frmControlHitos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 555)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmControlHitos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Control de Hitos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dtgGuias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dtgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboIncidencia As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents ckbEntregaParcial As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtLugarEntrega As System.Windows.Forms.TextBox
    Friend WithEvents lblOperacion As System.Windows.Forms.Label
    Friend WithEvents txtHito As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents lblGuiaTransp As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtgDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents txtHoraInicio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents dtgGuias As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents CHKGUIA As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GUIA_REM_CLIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHA_DESTINO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LUGAR_DESTINO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FLGCNL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtLugarParcial As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaParcial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txthoraparcial As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NESTDO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCOLUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FRETES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HRAREA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents INCIDENCIA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents INCVJE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOBEST As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ENVIA_GR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REQUIERE_GT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ASIG_UNID_ESPERA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnEliminar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ES_HORA_OBLIGAT As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
