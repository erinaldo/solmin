<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarCombustible
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsignarCombustible))
        Me.panel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dtpFechaDocumento = New System.Windows.Forms.DateTimePicker
        Me.txtNroDocumento = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cboTipoDocumento = New CodeTextBox.CodeTextBox
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.gpbVale = New System.Windows.Forms.GroupBox
        Me.rbtnValePropio = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.rbtnValeTercero = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.gpbPrecinto = New System.Windows.Forms.GroupBox
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtPrecinto_3 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtPrecinto_2 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtPrecinto_1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.btnBuscarVale = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.chkValidarVale = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.dtpFechaCargaComb = New System.Windows.Forms.DateTimePicker
        Me.txtValeCombustible = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtCostocombustible = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCombAsignado = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.cboTipocombustible = New CodeTextBox.CodeTextBox
        Me.lblCombAsignado = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCombustible = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblPapeleta = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblGrifo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cboGrifo = New CodeTextBox.CodeTextBox
        Me.lblGalones = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.MenuBar = New System.Windows.Forms.ToolStrip
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnProcesar = New System.Windows.Forms.ToolStripButton
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.SuspendLayout()
        Me.gpbVale.SuspendLayout()
        Me.gpbPrecinto.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel
        '
        Me.panel.Controls.Add(Me.dtpFechaDocumento)
        Me.panel.Controls.Add(Me.txtNroDocumento)
        Me.panel.Controls.Add(Me.KryptonLabel9)
        Me.panel.Controls.Add(Me.KryptonLabel8)
        Me.panel.Controls.Add(Me.cboTipoDocumento)
        Me.panel.Controls.Add(Me.KryptonLabel7)
        Me.panel.Controls.Add(Me.gpbVale)
        Me.panel.Controls.Add(Me.gpbPrecinto)
        Me.panel.Controls.Add(Me.btnBuscarVale)
        Me.panel.Controls.Add(Me.chkValidarVale)
        Me.panel.Controls.Add(Me.dtpFechaCargaComb)
        Me.panel.Controls.Add(Me.txtValeCombustible)
        Me.panel.Controls.Add(Me.txtCostocombustible)
        Me.panel.Controls.Add(Me.KryptonLabel2)
        Me.panel.Controls.Add(Me.KryptonLabel4)
        Me.panel.Controls.Add(Me.KryptonLabel1)
        Me.panel.Controls.Add(Me.txtCombAsignado)
        Me.panel.Controls.Add(Me.cboTipocombustible)
        Me.panel.Controls.Add(Me.lblCombAsignado)
        Me.panel.Controls.Add(Me.lblCombustible)
        Me.panel.Controls.Add(Me.lblPapeleta)
        Me.panel.Controls.Add(Me.lblGrifo)
        Me.panel.Controls.Add(Me.cboGrifo)
        Me.panel.Controls.Add(Me.lblGalones)
        Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(418, 335)
        Me.panel.StateCommon.Color1 = System.Drawing.Color.White
        Me.panel.TabIndex = 0
        '
        'dtpFechaDocumento
        '
        Me.dtpFechaDocumento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDocumento.Location = New System.Drawing.Point(304, 119)
        Me.dtpFechaDocumento.Name = "dtpFechaDocumento"
        Me.dtpFechaDocumento.Size = New System.Drawing.Size(88, 20)
        Me.dtpFechaDocumento.TabIndex = 11
        '
        'txtNroDocumento
        '
        Me.txtNroDocumento.Location = New System.Drawing.Point(130, 120)
        Me.txtNroDocumento.MaxLength = 10
        Me.txtNroDocumento.Name = "txtNroDocumento"
        Me.txtNroDocumento.Size = New System.Drawing.Size(88, 22)
        Me.txtNroDocumento.TabIndex = 9
        Me.txtNroDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(225, 121)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(87, 22)
        Me.KryptonLabel9.TabIndex = 10
        Me.KryptonLabel9.Text = "F. Documento"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "F. Documento"
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(5, 121)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(99, 22)
        Me.KryptonLabel8.TabIndex = 8
        Me.KryptonLabel8.Text = "Nro Documento"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Nro Documento"
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.BackColor = System.Drawing.Color.White
        Me.cboTipoDocumento.Codigo = ""
        Me.cboTipoDocumento.ControlHeight = 23
        Me.cboTipoDocumento.ControlImage = True
        Me.cboTipoDocumento.ControlReadOnly = False
        Me.cboTipoDocumento.Descripcion = ""
        Me.cboTipoDocumento.DisplayColumnVisible = True
        Me.cboTipoDocumento.DisplayMember = ""
        Me.cboTipoDocumento.KeyColumnWidth = 100
        Me.cboTipoDocumento.KeyField = ""
        Me.cboTipoDocumento.KeySearch = True
        Me.cboTipoDocumento.Location = New System.Drawing.Point(128, 87)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(264, 23)
        Me.cboTipoDocumento.TabIndex = 7
        Me.cboTipoDocumento.TextBackColor = System.Drawing.Color.Empty
        Me.cboTipoDocumento.TextForeColor = System.Drawing.Color.Empty
        Me.cboTipoDocumento.ValueColumnVisible = True
        Me.cboTipoDocumento.ValueColumnWidth = 600
        Me.cboTipoDocumento.ValueField = ""
        Me.cboTipoDocumento.ValueMember = ""
        Me.cboTipoDocumento.ValueSearch = True
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(5, 90)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(102, 22)
        Me.KryptonLabel7.TabIndex = 6
        Me.KryptonLabel7.Text = "Tipo Documento"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Tipo Documento"
        '
        'gpbVale
        '
        Me.gpbVale.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gpbVale.Controls.Add(Me.rbtnValePropio)
        Me.gpbVale.Controls.Add(Me.rbtnValeTercero)
        Me.gpbVale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbVale.ForeColor = System.Drawing.SystemColors.Highlight
        Me.gpbVale.Location = New System.Drawing.Point(256, 209)
        Me.gpbVale.Name = "gpbVale"
        Me.gpbVale.Size = New System.Drawing.Size(136, 55)
        Me.gpbVale.TabIndex = 19
        Me.gpbVale.TabStop = False
        Me.gpbVale.Text = "Vale"
        '
        'rbtnValePropio
        '
        Me.rbtnValePropio.Checked = True
        Me.rbtnValePropio.Location = New System.Drawing.Point(8, 24)
        Me.rbtnValePropio.Name = "rbtnValePropio"
        Me.rbtnValePropio.Size = New System.Drawing.Size(59, 22)
        Me.rbtnValePropio.TabIndex = 0
        Me.rbtnValePropio.Text = "Propio"
        Me.rbtnValePropio.Values.ExtraText = ""
        Me.rbtnValePropio.Values.Image = Nothing
        Me.rbtnValePropio.Values.Text = "Propio"
        '
        'rbtnValeTercero
        '
        Me.rbtnValeTercero.Location = New System.Drawing.Point(72, 24)
        Me.rbtnValeTercero.Name = "rbtnValeTercero"
        Me.rbtnValeTercero.Size = New System.Drawing.Size(62, 22)
        Me.rbtnValeTercero.TabIndex = 1
        Me.rbtnValeTercero.Text = "En ruta"
        Me.rbtnValeTercero.Values.ExtraText = ""
        Me.rbtnValeTercero.Values.Image = Nothing
        Me.rbtnValeTercero.Values.Text = "En ruta"
        '
        'gpbPrecinto
        '
        Me.gpbPrecinto.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gpbPrecinto.Controls.Add(Me.txtPrecinto_1)
        Me.gpbPrecinto.Controls.Add(Me.KryptonLabel5)
        Me.gpbPrecinto.Controls.Add(Me.txtPrecinto_3)
        Me.gpbPrecinto.Controls.Add(Me.KryptonLabel3)
        Me.gpbPrecinto.Controls.Add(Me.txtPrecinto_2)
        Me.gpbPrecinto.Controls.Add(Me.KryptonLabel6)
        Me.gpbPrecinto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbPrecinto.ForeColor = System.Drawing.SystemColors.Highlight
        Me.gpbPrecinto.Location = New System.Drawing.Point(8, 270)
        Me.gpbPrecinto.Name = "gpbPrecinto"
        Me.gpbPrecinto.Size = New System.Drawing.Size(384, 55)
        Me.gpbPrecinto.TabIndex = 23
        Me.gpbPrecinto.TabStop = False
        Me.gpbPrecinto.Text = "Precinto"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(252, 26)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(34, 22)
        Me.KryptonLabel5.TabIndex = 4
        Me.KryptonLabel5.Text = "N° 3"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "N° 3"
        '
        'txtPrecinto_3
        '
        Me.txtPrecinto_3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrecinto_3.Location = New System.Drawing.Point(288, 25)
        Me.txtPrecinto_3.MaxLength = 10
        Me.txtPrecinto_3.Name = "txtPrecinto_3"
        Me.txtPrecinto_3.Size = New System.Drawing.Size(88, 22)
        Me.txtPrecinto_3.TabIndex = 5
        Me.txtPrecinto_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(126, 26)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(34, 22)
        Me.KryptonLabel3.TabIndex = 2
        Me.KryptonLabel3.Text = "N° 2"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "N° 2"
        '
        'txtPrecinto_2
        '
        Me.txtPrecinto_2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrecinto_2.Location = New System.Drawing.Point(162, 25)
        Me.txtPrecinto_2.MaxLength = 10
        Me.txtPrecinto_2.Name = "txtPrecinto_2"
        Me.txtPrecinto_2.Size = New System.Drawing.Size(88, 22)
        Me.txtPrecinto_2.TabIndex = 3
        Me.txtPrecinto_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(4, 26)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(34, 22)
        Me.KryptonLabel6.TabIndex = 0
        Me.KryptonLabel6.Text = "N° 1"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "N° 1"
        '
        'txtPrecinto_1
        '
        Me.txtPrecinto_1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrecinto_1.Location = New System.Drawing.Point(36, 25)
        Me.txtPrecinto_1.MaxLength = 10
        Me.txtPrecinto_1.Name = "txtPrecinto_1"
        Me.txtPrecinto_1.Size = New System.Drawing.Size(88, 22)
        Me.txtPrecinto_1.TabIndex = 1
        Me.txtPrecinto_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBuscarVale
        '
        Me.btnBuscarVale.Location = New System.Drawing.Point(216, 34)
        Me.btnBuscarVale.Name = "btnBuscarVale"
        Me.btnBuscarVale.Size = New System.Drawing.Size(24, 22)
        Me.btnBuscarVale.TabIndex = 2
        Me.btnBuscarVale.Values.ExtraText = ""
        Me.btnBuscarVale.Values.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.btnBuscarVale.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnBuscarVale.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnBuscarVale.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnBuscarVale.Values.Text = ""
        '
        'chkValidarVale
        '
        Me.chkValidarVale.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkValidarVale.Location = New System.Drawing.Point(249, 35)
        Me.chkValidarVale.Name = "chkValidarVale"
        Me.chkValidarVale.Size = New System.Drawing.Size(160, 22)
        Me.chkValidarVale.TabIndex = 3
        Me.chkValidarVale.TabStop = False
        Me.chkValidarVale.Text = "Validar Vale Combustible"
        Me.chkValidarVale.Values.ExtraText = ""
        Me.chkValidarVale.Values.Image = Nothing
        Me.chkValidarVale.Values.Text = "Validar Vale Combustible"
        '
        'dtpFechaCargaComb
        '
        Me.dtpFechaCargaComb.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCargaComb.Location = New System.Drawing.Point(128, 61)
        Me.dtpFechaCargaComb.Name = "dtpFechaCargaComb"
        Me.dtpFechaCargaComb.Size = New System.Drawing.Size(88, 20)
        Me.dtpFechaCargaComb.TabIndex = 5
        '
        'txtValeCombustible
        '
        Me.txtValeCombustible.Location = New System.Drawing.Point(128, 34)
        Me.txtValeCombustible.MaxLength = 10
        Me.txtValeCombustible.Name = "txtValeCombustible"
        Me.txtValeCombustible.Size = New System.Drawing.Size(88, 22)
        Me.txtValeCombustible.TabIndex = 1
        Me.txtValeCombustible.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCostocombustible
        '
        Me.txtCostocombustible.Location = New System.Drawing.Point(128, 243)
        Me.txtCostocombustible.MaxLength = 10
        Me.txtCostocombustible.Name = "txtCostocombustible"
        Me.txtCostocombustible.Size = New System.Drawing.Size(88, 22)
        Me.txtCostocombustible.StateDisabled.Back.Color1 = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtCostocombustible.StateDisabled.Border.Color1 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtCostocombustible.StateDisabled.Border.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtCostocombustible.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtCostocombustible.StateDisabled.Content.Color1 = System.Drawing.SystemColors.WindowText
        Me.txtCostocombustible.TabIndex = 21
        Me.txtCostocombustible.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(5, 244)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(114, 22)
        Me.KryptonLabel2.TabIndex = 20
        Me.KryptonLabel2.Text = "Costo Combustible"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Costo Combustible"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(210, 249)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(43, 22)
        Me.KryptonLabel4.TabIndex = 22
        Me.KryptonLabel4.Text = " x Gal."
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = " x Gal."
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(5, 63)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(116, 22)
        Me.KryptonLabel1.TabIndex = 4
        Me.KryptonLabel1.Text = "Fecha Carga Comb."
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Fecha Carga Comb."
        '
        'txtCombAsignado
        '
        Me.txtCombAsignado.Location = New System.Drawing.Point(128, 215)
        Me.txtCombAsignado.MaxLength = 10
        Me.txtCombAsignado.Name = "txtCombAsignado"
        Me.txtCombAsignado.Size = New System.Drawing.Size(88, 22)
        Me.txtCombAsignado.TabIndex = 17
        Me.txtCombAsignado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboTipocombustible
        '
        Me.cboTipocombustible.BackColor = System.Drawing.Color.White
        Me.cboTipocombustible.Codigo = ""
        Me.cboTipocombustible.ControlHeight = 23
        Me.cboTipocombustible.ControlImage = True
        Me.cboTipocombustible.ControlReadOnly = False
        Me.cboTipocombustible.Descripcion = ""
        Me.cboTipocombustible.DisplayColumnVisible = True
        Me.cboTipocombustible.DisplayMember = ""
        Me.cboTipocombustible.KeyColumnWidth = 100
        Me.cboTipocombustible.KeyField = ""
        Me.cboTipocombustible.KeySearch = True
        Me.cboTipocombustible.Location = New System.Drawing.Point(128, 182)
        Me.cboTipocombustible.Name = "cboTipocombustible"
        Me.cboTipocombustible.Size = New System.Drawing.Size(264, 23)
        Me.cboTipocombustible.TabIndex = 15
        Me.cboTipocombustible.TextBackColor = System.Drawing.Color.White
        Me.cboTipocombustible.TextForeColor = System.Drawing.Color.Black
        Me.cboTipocombustible.ValueColumnVisible = True
        Me.cboTipocombustible.ValueColumnWidth = 600
        Me.cboTipocombustible.ValueField = ""
        Me.cboTipocombustible.ValueMember = ""
        Me.cboTipocombustible.ValueSearch = True
        '
        'lblCombAsignado
        '
        Me.lblCombAsignado.Location = New System.Drawing.Point(5, 216)
        Me.lblCombAsignado.Name = "lblCombAsignado"
        Me.lblCombAsignado.Size = New System.Drawing.Size(132, 22)
        Me.lblCombAsignado.TabIndex = 16
        Me.lblCombAsignado.Text = "Cantidad Combustible"
        Me.lblCombAsignado.Values.ExtraText = ""
        Me.lblCombAsignado.Values.Image = Nothing
        Me.lblCombAsignado.Values.Text = "Cantidad Combustible"
        '
        'lblCombustible
        '
        Me.lblCombustible.Location = New System.Drawing.Point(5, 185)
        Me.lblCombustible.Name = "lblCombustible"
        Me.lblCombustible.Size = New System.Drawing.Size(107, 22)
        Me.lblCombustible.TabIndex = 14
        Me.lblCombustible.Text = "Tipo Combustible"
        Me.lblCombustible.Values.ExtraText = ""
        Me.lblCombustible.Values.Image = Nothing
        Me.lblCombustible.Values.Text = "Tipo Combustible"
        '
        'lblPapeleta
        '
        Me.lblPapeleta.Location = New System.Drawing.Point(5, 35)
        Me.lblPapeleta.Name = "lblPapeleta"
        Me.lblPapeleta.Size = New System.Drawing.Size(124, 22)
        Me.lblPapeleta.TabIndex = 0
        Me.lblPapeleta.Text = "N° Vale Combustible"
        Me.lblPapeleta.Values.ExtraText = ""
        Me.lblPapeleta.Values.Image = Nothing
        Me.lblPapeleta.Values.Text = "N° Vale Combustible"
        '
        'lblGrifo
        '
        Me.lblGrifo.Location = New System.Drawing.Point(5, 152)
        Me.lblGrifo.Name = "lblGrifo"
        Me.lblGrifo.Size = New System.Drawing.Size(37, 22)
        Me.lblGrifo.TabIndex = 12
        Me.lblGrifo.Text = "Grifo"
        Me.lblGrifo.Values.ExtraText = ""
        Me.lblGrifo.Values.Image = Nothing
        Me.lblGrifo.Values.Text = "Grifo"
        '
        'cboGrifo
        '
        Me.cboGrifo.BackColor = System.Drawing.Color.White
        Me.cboGrifo.Codigo = ""
        Me.cboGrifo.ControlHeight = 23
        Me.cboGrifo.ControlImage = True
        Me.cboGrifo.ControlReadOnly = False
        Me.cboGrifo.Descripcion = ""
        Me.cboGrifo.DisplayColumnVisible = True
        Me.cboGrifo.DisplayMember = ""
        Me.cboGrifo.KeyColumnWidth = 100
        Me.cboGrifo.KeyField = ""
        Me.cboGrifo.KeySearch = True
        Me.cboGrifo.Location = New System.Drawing.Point(128, 149)
        Me.cboGrifo.Name = "cboGrifo"
        Me.cboGrifo.Size = New System.Drawing.Size(264, 23)
        Me.cboGrifo.TabIndex = 13
        Me.cboGrifo.TextBackColor = System.Drawing.Color.Empty
        Me.cboGrifo.TextForeColor = System.Drawing.Color.Empty
        Me.cboGrifo.ValueColumnVisible = True
        Me.cboGrifo.ValueColumnWidth = 600
        Me.cboGrifo.ValueField = ""
        Me.cboGrifo.ValueMember = ""
        Me.cboGrifo.ValueSearch = True
        '
        'lblGalones
        '
        Me.lblGalones.Location = New System.Drawing.Point(210, 220)
        Me.lblGalones.Name = "lblGalones"
        Me.lblGalones.Size = New System.Drawing.Size(40, 22)
        Me.lblGalones.TabIndex = 18
        Me.lblGalones.Text = " Gals."
        Me.lblGalones.Values.ExtraText = ""
        Me.lblGalones.Values.Image = Nothing
        Me.lblGalones.Values.Text = " Gals."
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.ToolStripSeparator1, Me.btnProcesar, Me.btnGuardar})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(418, 25)
        Me.MenuBar.TabIndex = 0
        Me.MenuBar.TabStop = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources._stop
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(73, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnProcesar
        '
        Me.btnProcesar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnProcesar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnProcesar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(67, 22)
        Me.btnProcesar.Text = "Asignar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGuardar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(69, 22)
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.Visible = False
        '
        'frmAsignarCombustible
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 335)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuBar)
        Me.Controls.Add(Me.panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MinimumSize = New System.Drawing.Size(420, 300)
        Me.Name = "frmAsignarCombustible"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignación de Combustible"
        CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        Me.gpbVale.ResumeLayout(False)
        Me.gpbVale.PerformLayout()
        Me.gpbPrecinto.ResumeLayout(False)
        Me.gpbPrecinto.PerformLayout()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
  Friend WithEvents panel As ComponentFactory.Krypton.Toolkit.KryptonPanel
  Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

  Public Sub New()

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub
  Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
  Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnProcesar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
  Friend WithEvents txtCostocombustible As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtCombAsignado As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents cboTipocombustible As CodeTextBox.CodeTextBox
  Friend WithEvents lblCombAsignado As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents lblCombustible As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents lblPapeleta As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents lblGrifo As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents cboGrifo As CodeTextBox.CodeTextBox
  Friend WithEvents lblGalones As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents gpbPrecinto As System.Windows.Forms.GroupBox
  Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtPrecinto_3 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtPrecinto_2 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtPrecinto_1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents btnBuscarVale As ComponentFactory.Krypton.Toolkit.KryptonButton
  Friend WithEvents chkValidarVale As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
  Friend WithEvents dtpFechaCargaComb As System.Windows.Forms.DateTimePicker
  Friend WithEvents txtValeCombustible As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents gpbVale As System.Windows.Forms.GroupBox
  Friend WithEvents rbtnValePropio As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
  Friend WithEvents rbtnValeTercero As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
  Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents cboTipoDocumento As CodeTextBox.CodeTextBox
  Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents dtpFechaDocumento As System.Windows.Forms.DateTimePicker
  Friend WithEvents txtNroDocumento As ComponentFactory.Krypton.Toolkit.KryptonTextBox
End Class
