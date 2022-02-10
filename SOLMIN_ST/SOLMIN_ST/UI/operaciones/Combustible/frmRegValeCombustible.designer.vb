<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegValeCombustible
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
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.txtNroDocumento = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtValeCombustible = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.cboTipoDocumento = New Ransa.Utilitario.ucAyuda()
        Me.cboTipocombustible = New Ransa.Utilitario.ucAyuda()
        Me.cboGrifo = New Ransa.Utilitario.ucAyuda()
        Me.txtCombAsignado = New Ransa.Utilitario.clsTextBoxNumero()
        Me.txtCostoComb = New Ransa.Utilitario.clsTextBoxNumero()
        Me.txtPrecintoAd = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.dtpFechaCargaComb = New System.Windows.Forms.DateTimePicker()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.dtpFechaDocumento = New System.Windows.Forms.DateTimePicker()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtPrecintoSalida = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtPrecintoLlegada = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblCombustible = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblPapeleta = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblGrifo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.MenuBar = New System.Windows.Forms.ToolStrip()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btnProcesar = New System.Windows.Forms.ToolStripButton()
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.cboMoneda)
        Me.KryptonPanel.Controls.Add(Me.txtNroDocumento)
        Me.KryptonPanel.Controls.Add(Me.txtValeCombustible)
        Me.KryptonPanel.Controls.Add(Me.cboTipoDocumento)
        Me.KryptonPanel.Controls.Add(Me.cboTipocombustible)
        Me.KryptonPanel.Controls.Add(Me.cboGrifo)
        Me.KryptonPanel.Controls.Add(Me.txtCombAsignado)
        Me.KryptonPanel.Controls.Add(Me.txtCostoComb)
        Me.KryptonPanel.Controls.Add(Me.txtPrecintoAd)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel10)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel14)
        Me.KryptonPanel.Controls.Add(Me.dtpFechaCargaComb)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel6)
        Me.KryptonPanel.Controls.Add(Me.dtpFechaDocumento)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel9)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel13)
        Me.KryptonPanel.Controls.Add(Me.txtPrecintoSalida)
        Me.KryptonPanel.Controls.Add(Me.txtPrecintoLlegada)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel7)
        Me.KryptonPanel.Controls.Add(Me.lblCombustible)
        Me.KryptonPanel.Controls.Add(Me.lblPapeleta)
        Me.KryptonPanel.Controls.Add(Me.lblGrifo)
        Me.KryptonPanel.Controls.Add(Me.MenuBar)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003
        Me.KryptonPanel.Size = New System.Drawing.Size(727, 379)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(382, 111)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(68, 24)
        Me.KryptonLabel1.TabIndex = 39
        Me.KryptonLabel1.Text = "Moneda"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Moneda"
        '
        'cboMoneda
        '
        Me.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Location = New System.Drawing.Point(531, 110)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(162, 24)
        Me.cboMoneda.TabIndex = 38
        '
        'txtNroDocumento
        '
        Me.txtNroDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroDocumento.Location = New System.Drawing.Point(184, 225)
        Me.txtNroDocumento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroDocumento.MaxLength = 12
        Me.txtNroDocumento.Name = "txtNroDocumento"
        Me.txtNroDocumento.Size = New System.Drawing.Size(135, 26)
        Me.txtNroDocumento.TabIndex = 37
        Me.txtNroDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtValeCombustible
        '
        Me.txtValeCombustible.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValeCombustible.Location = New System.Drawing.Point(184, 41)
        Me.txtValeCombustible.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValeCombustible.MaxLength = 12
        Me.txtValeCombustible.Name = "txtValeCombustible"
        Me.txtValeCombustible.Size = New System.Drawing.Size(175, 26)
        Me.txtValeCombustible.TabIndex = 36
        Me.txtValeCombustible.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.BackColor = System.Drawing.Color.Transparent
        Me.cboTipoDocumento.DataSource = Nothing
        Me.cboTipoDocumento.DispleyMember = ""
        Me.cboTipoDocumento.Etiquetas_Form = Nothing
        Me.cboTipoDocumento.ListColumnas = Nothing
        Me.cboTipoDocumento.Location = New System.Drawing.Point(184, 185)
        Me.cboTipoDocumento.Margin = New System.Windows.Forms.Padding(5)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Obligatorio = False
        Me.cboTipoDocumento.PopupHeight = 0
        Me.cboTipoDocumento.PopupWidth = 0
        Me.cboTipoDocumento.Size = New System.Drawing.Size(188, 35)
        Me.cboTipoDocumento.SizeFont = 0
        Me.cboTipoDocumento.TabIndex = 6
        Me.cboTipoDocumento.ValueMember = ""
        '
        'cboTipocombustible
        '
        Me.cboTipocombustible.BackColor = System.Drawing.Color.Transparent
        Me.cboTipocombustible.DataSource = Nothing
        Me.cboTipocombustible.DispleyMember = ""
        Me.cboTipocombustible.Etiquetas_Form = Nothing
        Me.cboTipocombustible.ListColumnas = Nothing
        Me.cboTipocombustible.Location = New System.Drawing.Point(184, 110)
        Me.cboTipocombustible.Margin = New System.Windows.Forms.Padding(5)
        Me.cboTipocombustible.Name = "cboTipocombustible"
        Me.cboTipocombustible.Obligatorio = False
        Me.cboTipocombustible.PopupHeight = 0
        Me.cboTipocombustible.PopupWidth = 0
        Me.cboTipocombustible.Size = New System.Drawing.Size(188, 35)
        Me.cboTipocombustible.SizeFont = 0
        Me.cboTipocombustible.TabIndex = 3
        Me.cboTipocombustible.ValueMember = ""
        '
        'cboGrifo
        '
        Me.cboGrifo.BackColor = System.Drawing.Color.Transparent
        Me.cboGrifo.DataSource = Nothing
        Me.cboGrifo.DispleyMember = ""
        Me.cboGrifo.Etiquetas_Form = Nothing
        Me.cboGrifo.ListColumnas = Nothing
        Me.cboGrifo.Location = New System.Drawing.Point(184, 75)
        Me.cboGrifo.Margin = New System.Windows.Forms.Padding(5)
        Me.cboGrifo.Name = "cboGrifo"
        Me.cboGrifo.Obligatorio = False
        Me.cboGrifo.PopupHeight = 0
        Me.cboGrifo.PopupWidth = 0
        Me.cboGrifo.Size = New System.Drawing.Size(503, 35)
        Me.cboGrifo.SizeFont = 0
        Me.cboGrifo.TabIndex = 2
        Me.cboGrifo.ValueMember = ""
        '
        'txtCombAsignado
        '
        Me.txtCombAsignado.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.txtCombAsignado.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtCombAsignado.Location = New System.Drawing.Point(184, 150)
        Me.txtCombAsignado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCombAsignado.MaxLength = 15
        Me.txtCombAsignado.Name = "txtCombAsignado"
        Me.txtCombAsignado.NUMDECIMALES = 2
        Me.txtCombAsignado.NUMENTEROS = 10
        Me.txtCombAsignado.Size = New System.Drawing.Size(134, 22)
        Me.txtCombAsignado.TabIndex = 4
        '
        'txtCostoComb
        '
        Me.txtCostoComb.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.txtCostoComb.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtCostoComb.Location = New System.Drawing.Point(531, 152)
        Me.txtCostoComb.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCostoComb.MaxLength = 15
        Me.txtCostoComb.Name = "txtCostoComb"
        Me.txtCostoComb.NUMDECIMALES = 2
        Me.txtCostoComb.NUMENTEROS = 10
        Me.txtCostoComb.Size = New System.Drawing.Size(162, 22)
        Me.txtCostoComb.TabIndex = 5
        '
        'txtPrecintoAd
        '
        Me.txtPrecintoAd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrecintoAd.Location = New System.Drawing.Point(184, 295)
        Me.txtPrecintoAd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrecintoAd.MaxLength = 10
        Me.txtPrecintoAd.Name = "txtPrecintoAd"
        Me.txtPrecintoAd.Size = New System.Drawing.Size(135, 26)
        Me.txtPrecintoAd.TabIndex = 11
        Me.txtPrecintoAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(15, 295)
        Me.KryptonLabel10.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(80, 24)
        Me.KryptonLabel10.TabIndex = 35
        Me.KryptonLabel10.Text = "Precinto 3"
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "Precinto 3"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(370, 152)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(143, 24)
        Me.KryptonLabel2.TabIndex = 33
        Me.KryptonLabel2.Text = "Costo Comb( x Gal)"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Costo Comb( x Gal)"
        '
        'KryptonLabel14
        '
        Me.KryptonLabel14.Location = New System.Drawing.Point(15, 150)
        Me.KryptonLabel14.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel14.Name = "KryptonLabel14"
        Me.KryptonLabel14.Size = New System.Drawing.Size(147, 24)
        Me.KryptonLabel14.TabIndex = 4
        Me.KryptonLabel14.Text = "Cant. Combust.(Gal)"
        Me.KryptonLabel14.Values.ExtraText = ""
        Me.KryptonLabel14.Values.Image = Nothing
        Me.KryptonLabel14.Values.Text = "Cant. Combust.(Gal)"
        '
        'dtpFechaCargaComb
        '
        Me.dtpFechaCargaComb.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCargaComb.Location = New System.Drawing.Point(531, 44)
        Me.dtpFechaCargaComb.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaCargaComb.Name = "dtpFechaCargaComb"
        Me.dtpFechaCargaComb.Size = New System.Drawing.Size(116, 22)
        Me.dtpFechaCargaComb.TabIndex = 1
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(398, 43)
        Me.KryptonLabel6.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(95, 24)
        Me.KryptonLabel6.TabIndex = 1
        Me.KryptonLabel6.Text = "Fecha Carga "
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Fecha Carga "
        '
        'dtpFechaDocumento
        '
        Me.dtpFechaDocumento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDocumento.Location = New System.Drawing.Point(531, 231)
        Me.dtpFechaDocumento.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaDocumento.Name = "dtpFechaDocumento"
        Me.dtpFechaDocumento.Size = New System.Drawing.Size(103, 22)
        Me.dtpFechaDocumento.TabIndex = 8
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(365, 225)
        Me.KryptonLabel9.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(107, 24)
        Me.KryptonLabel9.TabIndex = 9
        Me.KryptonLabel9.Text = "F. Documento"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "F. Documento"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(15, 227)
        Me.KryptonLabel3.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(122, 24)
        Me.KryptonLabel3.TabIndex = 31
        Me.KryptonLabel3.Text = "Nro Documento"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Nro Documento"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(15, 185)
        Me.KryptonLabel5.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(126, 24)
        Me.KryptonLabel5.TabIndex = 29
        Me.KryptonLabel5.Text = "Tipo Documento"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Tipo Documento"
        '
        'KryptonLabel13
        '
        Me.KryptonLabel13.Location = New System.Drawing.Point(365, 261)
        Me.KryptonLabel13.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel13.Name = "KryptonLabel13"
        Me.KryptonLabel13.Size = New System.Drawing.Size(138, 24)
        Me.KryptonLabel13.TabIndex = 12
        Me.KryptonLabel13.Text = "Precinto 2 ( Salida)"
        Me.KryptonLabel13.Values.ExtraText = ""
        Me.KryptonLabel13.Values.Image = Nothing
        Me.KryptonLabel13.Values.Text = "Precinto 2 ( Salida)"
        '
        'txtPrecintoSalida
        '
        Me.txtPrecintoSalida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrecintoSalida.Location = New System.Drawing.Point(531, 261)
        Me.txtPrecintoSalida.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrecintoSalida.MaxLength = 10
        Me.txtPrecintoSalida.Name = "txtPrecintoSalida"
        Me.txtPrecintoSalida.Size = New System.Drawing.Size(162, 26)
        Me.txtPrecintoSalida.TabIndex = 10
        Me.txtPrecintoSalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPrecintoLlegada
        '
        Me.txtPrecintoLlegada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrecintoLlegada.Location = New System.Drawing.Point(184, 261)
        Me.txtPrecintoLlegada.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrecintoLlegada.MaxLength = 10
        Me.txtPrecintoLlegada.Name = "txtPrecintoLlegada"
        Me.txtPrecintoLlegada.Size = New System.Drawing.Size(135, 26)
        Me.txtPrecintoLlegada.TabIndex = 9
        Me.txtPrecintoLlegada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(15, 261)
        Me.KryptonLabel7.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(151, 24)
        Me.KryptonLabel7.TabIndex = 7
        Me.KryptonLabel7.Text = "Precinto 1 ( Llegada)"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Precinto 1 ( Llegada)"
        '
        'lblCombustible
        '
        Me.lblCombustible.Location = New System.Drawing.Point(15, 111)
        Me.lblCombustible.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCombustible.Name = "lblCombustible"
        Me.lblCombustible.Size = New System.Drawing.Size(132, 24)
        Me.lblCombustible.TabIndex = 25
        Me.lblCombustible.Text = "Tipo Combustible"
        Me.lblCombustible.Values.ExtraText = ""
        Me.lblCombustible.Values.Image = Nothing
        Me.lblCombustible.Values.Text = "Tipo Combustible"
        '
        'lblPapeleta
        '
        Me.lblPapeleta.Location = New System.Drawing.Point(15, 43)
        Me.lblPapeleta.Margin = New System.Windows.Forms.Padding(4)
        Me.lblPapeleta.Name = "lblPapeleta"
        Me.lblPapeleta.Size = New System.Drawing.Size(94, 24)
        Me.lblPapeleta.TabIndex = 21
        Me.lblPapeleta.Text = "N° de Ticket"
        Me.lblPapeleta.Values.ExtraText = ""
        Me.lblPapeleta.Values.Image = Nothing
        Me.lblPapeleta.Values.Text = "N° de Ticket"
        '
        'lblGrifo
        '
        Me.lblGrifo.Location = New System.Drawing.Point(15, 77)
        Me.lblGrifo.Margin = New System.Windows.Forms.Padding(4)
        Me.lblGrifo.Name = "lblGrifo"
        Me.lblGrifo.Size = New System.Drawing.Size(68, 24)
        Me.lblGrifo.TabIndex = 27
        Me.lblGrifo.Text = "Estación"
        Me.lblGrifo.Values.ExtraText = ""
        Me.lblGrifo.Values.Image = Nothing
        Me.lblGrifo.Values.Text = "Estación"
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.btnProcesar})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(727, 27)
        Me.MenuBar.TabIndex = 12
        Me.MenuBar.TabStop = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources._stop
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 24)
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnProcesar
        '
        Me.btnProcesar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnProcesar.Image = Global.SOLMIN_ST.My.Resources.Resources.filesave
        Me.btnProcesar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(86, 24)
        Me.btnProcesar.Text = "Guardar"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nro Liquidación"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 91
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre Cliente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 91
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Ruta"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 91
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nombre Imagen"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 92
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Extensión Archivo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 91
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Acción"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 91
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Acción"
        Me.DataGridViewImageColumn1.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 91
        '
        'frmRegValeCombustible
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(727, 379)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmRegValeCombustible"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro Vale Combustible"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPrecintoSalida As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtPrecintoLlegada As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblCombustible As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblPapeleta As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblGrifo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnProcesar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents dtpFechaDocumento As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaCargaComb As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPrecintoAd As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCostoComb As Ransa.Utilitario.clsTextBoxNumero
    Friend WithEvents txtCombAsignado As Ransa.Utilitario.clsTextBoxNumero
    Friend WithEvents cboGrifo As Ransa.Utilitario.ucAyuda
    Friend WithEvents cboTipoDocumento As Ransa.Utilitario.ucAyuda
    Friend WithEvents cboTipocombustible As Ransa.Utilitario.ucAyuda
    Friend WithEvents txtNroDocumento As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtValeCombustible As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
End Class
