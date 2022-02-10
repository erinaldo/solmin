<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSolicitudEfectivoAVC
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
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.btnBuscarGastosRuta = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.btnSalir = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.cmbObrero = New System.Windows.Forms.ComboBox()
        Me.cmbPlaca = New System.Windows.Forms.ComboBox()
        Me.btnRutas = New System.Windows.Forms.Button()
        Me.btnBuscaOrdenServicio = New System.Windows.Forms.Button()
        Me.txtNroOperacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtComentario = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtMotivoGiro = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtNroSolEfectivo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel26 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel24 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel19 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.ckbGenerarPedidoEfectivo = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtNroBrevete = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.dtpFechaAvc = New System.Windows.Forms.DateTimePicker()
        Me.txtOrigen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtNroAVC = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel15 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.PanelImporte = New System.Windows.Forms.Panel()
        Me.txtImporteSolEfectivo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel22 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonBorderEdge5 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge()
        Me.cmbMedioTransporte = New System.Windows.Forms.ComboBox()
        Me.txtAdelanto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtImporteAVC = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblErrorAVC = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.chkAvcRetorno = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonCheckBox1 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFiltros.Panel.SuspendLayout()
        Me.PanelFiltros.SuspendLayout()
        Me.PanelImporte.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.AutoSize = True
        Me.KryptonPanel.Controls.Add(Me.PanelFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(803, 491)
        Me.KryptonPanel.TabIndex = 0
        '
        'PanelFiltros
        '
        Me.PanelFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnBuscarGastosRuta, Me.btnSalir})
        Me.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFiltros.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.PanelFiltros.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.PanelFiltros.HeaderVisiblePrimary = False
        Me.PanelFiltros.Location = New System.Drawing.Point(0, 0)
        Me.PanelFiltros.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelFiltros.Name = "PanelFiltros"
        '
        'PanelFiltros.Panel
        '
        Me.PanelFiltros.Panel.Controls.Add(Me.cmbObrero)
        Me.PanelFiltros.Panel.Controls.Add(Me.cmbPlaca)
        Me.PanelFiltros.Panel.Controls.Add(Me.btnRutas)
        Me.PanelFiltros.Panel.Controls.Add(Me.btnBuscaOrdenServicio)
        Me.PanelFiltros.Panel.Controls.Add(Me.txtNroOperacion)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel8)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel7)
        Me.PanelFiltros.Panel.Controls.Add(Me.txtComentario)
        Me.PanelFiltros.Panel.Controls.Add(Me.txtMotivoGiro)
        Me.PanelFiltros.Panel.Controls.Add(Me.txtNroSolEfectivo)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel26)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel24)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel19)
        Me.PanelFiltros.Panel.Controls.Add(Me.ckbGenerarPedidoEfectivo)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel3)
        Me.PanelFiltros.Panel.Controls.Add(Me.txtNroBrevete)
        Me.PanelFiltros.Panel.Controls.Add(Me.dtpFechaAvc)
        Me.PanelFiltros.Panel.Controls.Add(Me.txtOrigen)
        Me.PanelFiltros.Panel.Controls.Add(Me.txtNroAVC)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel15)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel14)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel9)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel4)
        Me.PanelFiltros.Panel.Controls.Add(Me.PanelImporte)
        Me.PanelFiltros.Size = New System.Drawing.Size(803, 491)
        Me.PanelFiltros.TabIndex = 0
        Me.PanelFiltros.Text = "Datos Generales"
        Me.PanelFiltros.ValuesPrimary.Description = "Datos Generales"
        Me.PanelFiltros.ValuesPrimary.Heading = "Datos Generales"
        Me.PanelFiltros.ValuesPrimary.Image = Nothing
        Me.PanelFiltros.ValuesSecondary.Description = ""
        Me.PanelFiltros.ValuesSecondary.Heading = "Datos Generales"
        Me.PanelFiltros.ValuesSecondary.Image = Nothing
        '
        'btnBuscarGastosRuta
        '
        Me.btnBuscarGastosRuta.ExtraText = ""
        Me.btnBuscarGastosRuta.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnBuscarGastosRuta.Image = Global.SOLMIN_ST.My.Resources.Resources.edit_add
        Me.btnBuscarGastosRuta.Text = "Guardar AVC "
        Me.btnBuscarGastosRuta.ToolTipImage = Nothing
        Me.btnBuscarGastosRuta.UniqueName = "1E7B5DC088DB4E1F1E7B5DC088DB4E1F"
        '
        'btnSalir
        '
        Me.btnSalir.ExtraText = ""
        Me.btnSalir.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnSalir.Image = Global.SOLMIN_ST.My.Resources.Resources._exit
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.ToolTipImage = Nothing
        Me.btnSalir.UniqueName = "4ABB2086ACE547644ABB2086ACE54764"
        '
        'cmbObrero
        '
        Me.cmbObrero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbObrero.Location = New System.Drawing.Point(200, 112)
        Me.cmbObrero.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbObrero.Name = "cmbObrero"
        Me.cmbObrero.Size = New System.Drawing.Size(556, 24)
        Me.cmbObrero.TabIndex = 42
        '
        'cmbPlaca
        '
        Me.cmbPlaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlaca.Location = New System.Drawing.Point(589, 73)
        Me.cmbPlaca.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbPlaca.Name = "cmbPlaca"
        Me.cmbPlaca.Size = New System.Drawing.Size(167, 24)
        Me.cmbPlaca.TabIndex = 42
        '
        'btnRutas
        '
        Me.btnRutas.Image = Global.SOLMIN_ST.My.Resources.Resources.cell_layout
        Me.btnRutas.Location = New System.Drawing.Point(765, 181)
        Me.btnRutas.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRutas.Name = "btnRutas"
        Me.btnRutas.Size = New System.Drawing.Size(33, 30)
        Me.btnRutas.TabIndex = 41
        Me.btnRutas.UseVisualStyleBackColor = True
        '
        'btnBuscaOrdenServicio
        '
        Me.btnBuscaOrdenServicio.Image = Global.SOLMIN_ST.My.Resources.Resources.cell_layout
        Me.btnBuscaOrdenServicio.Location = New System.Drawing.Point(373, 71)
        Me.btnBuscaOrdenServicio.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscaOrdenServicio.Name = "btnBuscaOrdenServicio"
        Me.btnBuscaOrdenServicio.Size = New System.Drawing.Size(33, 30)
        Me.btnBuscaOrdenServicio.TabIndex = 41
        Me.btnBuscaOrdenServicio.UseVisualStyleBackColor = True
        '
        'txtNroOperacion
        '
        Me.txtNroOperacion.Location = New System.Drawing.Point(200, 75)
        Me.txtNroOperacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroOperacion.MaxLength = 10
        Me.txtNroOperacion.Name = "txtNroOperacion"
        Me.txtNroOperacion.Size = New System.Drawing.Size(165, 26)
        Me.txtNroOperacion.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.txtNroOperacion.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtNroOperacion.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroOperacion.TabIndex = 38
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(407, 79)
        Me.KryptonLabel8.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(129, 24)
        Me.KryptonLabel8.TabIndex = 40
        Me.KryptonLabel8.Text = "Placa de Unidad :"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Placa de Unidad :"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(12, 79)
        Me.KryptonLabel7.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(172, 24)
        Me.KryptonLabel7.TabIndex = 39
        Me.KryptonLabel7.Text = "Número de Operación :"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Número de Operación :"
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(200, 242)
        Me.txtComentario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComentario.MaxLength = 30
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComentario.Size = New System.Drawing.Size(559, 31)
        Me.txtComentario.TabIndex = 10
        Me.txtComentario.Visible = False
        '
        'txtMotivoGiro
        '
        Me.txtMotivoGiro.Enabled = False
        Me.txtMotivoGiro.Location = New System.Drawing.Point(200, 212)
        Me.txtMotivoGiro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMotivoGiro.MaxLength = 30
        Me.txtMotivoGiro.Name = "txtMotivoGiro"
        Me.txtMotivoGiro.ReadOnly = True
        Me.txtMotivoGiro.Size = New System.Drawing.Size(559, 26)
        Me.txtMotivoGiro.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.txtMotivoGiro.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtMotivoGiro.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotivoGiro.TabIndex = 9
        Me.txtMotivoGiro.Visible = False
        '
        'txtNroSolEfectivo
        '
        Me.txtNroSolEfectivo.Enabled = False
        Me.txtNroSolEfectivo.Location = New System.Drawing.Point(589, 44)
        Me.txtNroSolEfectivo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroSolEfectivo.Name = "txtNroSolEfectivo"
        Me.txtNroSolEfectivo.ReadOnly = True
        Me.txtNroSolEfectivo.Size = New System.Drawing.Size(168, 26)
        Me.txtNroSolEfectivo.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.txtNroSolEfectivo.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtNroSolEfectivo.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroSolEfectivo.TabIndex = 1
        Me.txtNroSolEfectivo.Visible = False
        '
        'KryptonLabel26
        '
        Me.KryptonLabel26.Location = New System.Drawing.Point(12, 233)
        Me.KryptonLabel26.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel26.Name = "KryptonLabel26"
        Me.KryptonLabel26.Size = New System.Drawing.Size(95, 24)
        Me.KryptonLabel26.TabIndex = 24
        Me.KryptonLabel26.Text = "Comentario:"
        Me.KryptonLabel26.Values.ExtraText = ""
        Me.KryptonLabel26.Values.Image = Nothing
        Me.KryptonLabel26.Values.Text = "Comentario:"
        Me.KryptonLabel26.Visible = False
        '
        'KryptonLabel24
        '
        Me.KryptonLabel24.Location = New System.Drawing.Point(12, 206)
        Me.KryptonLabel24.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel24.Name = "KryptonLabel24"
        Me.KryptonLabel24.Size = New System.Drawing.Size(187, 24)
        Me.KryptonLabel24.TabIndex = 20
        Me.KryptonLabel24.Text = "Motivo de Giro. Adelanto:"
        Me.KryptonLabel24.Values.ExtraText = ""
        Me.KryptonLabel24.Values.Image = Nothing
        Me.KryptonLabel24.Values.Text = "Motivo de Giro. Adelanto:"
        Me.KryptonLabel24.Visible = False
        '
        'KryptonLabel19
        '
        Me.KryptonLabel19.Location = New System.Drawing.Point(407, 48)
        Me.KryptonLabel19.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel19.Name = "KryptonLabel19"
        Me.KryptonLabel19.Size = New System.Drawing.Size(192, 24)
        Me.KryptonLabel19.TabIndex = 3
        Me.KryptonLabel19.Text = "Número Sol ped. Efectivo :"
        Me.KryptonLabel19.Values.ExtraText = ""
        Me.KryptonLabel19.Values.Image = Nothing
        Me.KryptonLabel19.Values.Text = "Número Sol ped. Efectivo :"
        Me.KryptonLabel19.Visible = False
        '
        'ckbGenerarPedidoEfectivo
        '
        Me.ckbGenerarPedidoEfectivo.Checked = False
        Me.ckbGenerarPedidoEfectivo.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.ckbGenerarPedidoEfectivo.Location = New System.Drawing.Point(563, 10)
        Me.ckbGenerarPedidoEfectivo.Margin = New System.Windows.Forms.Padding(4)
        Me.ckbGenerarPedidoEfectivo.Name = "ckbGenerarPedidoEfectivo"
        Me.ckbGenerarPedidoEfectivo.Size = New System.Drawing.Size(188, 24)
        Me.ckbGenerarPedidoEfectivo.TabIndex = 6
        Me.ckbGenerarPedidoEfectivo.TabStop = False
        Me.ckbGenerarPedidoEfectivo.Text = "Generar Pedido Efectivo"
        Me.ckbGenerarPedidoEfectivo.Values.ExtraText = ""
        Me.ckbGenerarPedidoEfectivo.Values.Image = Nothing
        Me.ckbGenerarPedidoEfectivo.Values.Text = "Generar Pedido Efectivo"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(8, 7)
        Me.KryptonLabel5.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(159, 22)
        Me.KryptonLabel5.StateNormal.ShortText.Color1 = System.Drawing.Color.Navy
        Me.KryptonLabel5.StateNormal.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.TabIndex = 0
        Me.KryptonLabel5.Text = "Información General "
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Información General "
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(12, 116)
        Me.KryptonLabel3.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(68, 24)
        Me.KryptonLabel3.TabIndex = 7
        Me.KryptonLabel3.Text = "Obrero :"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Obrero :"
        '
        'txtNroBrevete
        '
        Me.txtNroBrevete.Enabled = False
        Me.txtNroBrevete.Location = New System.Drawing.Point(200, 145)
        Me.txtNroBrevete.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroBrevete.Name = "txtNroBrevete"
        Me.txtNroBrevete.ReadOnly = True
        Me.txtNroBrevete.Size = New System.Drawing.Size(165, 26)
        Me.txtNroBrevete.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.txtNroBrevete.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtNroBrevete.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroBrevete.TabIndex = 4
        '
        'dtpFechaAvc
        '
        Me.dtpFechaAvc.BackColor = System.Drawing.Color.White
        Me.dtpFechaAvc.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaAvc.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtpFechaAvc.Enabled = False
        Me.dtpFechaAvc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtpFechaAvc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAvc.Location = New System.Drawing.Point(589, 143)
        Me.dtpFechaAvc.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaAvc.Name = "dtpFechaAvc"
        Me.dtpFechaAvc.Size = New System.Drawing.Size(168, 23)
        Me.dtpFechaAvc.TabIndex = 5
        '
        'txtOrigen
        '
        Me.txtOrigen.Enabled = False
        Me.txtOrigen.Location = New System.Drawing.Point(200, 181)
        Me.txtOrigen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.ReadOnly = True
        Me.txtOrigen.Size = New System.Drawing.Size(559, 26)
        Me.txtOrigen.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.txtOrigen.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtOrigen.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrigen.TabIndex = 8
        '
        'txtNroAVC
        '
        Me.txtNroAVC.Enabled = False
        Me.txtNroAVC.Location = New System.Drawing.Point(200, 44)
        Me.txtNroAVC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroAVC.Name = "txtNroAVC"
        Me.txtNroAVC.ReadOnly = True
        Me.txtNroAVC.Size = New System.Drawing.Size(165, 26)
        Me.txtNroAVC.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.txtNroAVC.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtNroAVC.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtNroAVC.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroAVC.TabIndex = 0
        '
        'KryptonLabel15
        '
        Me.KryptonLabel15.Location = New System.Drawing.Point(12, 148)
        Me.KryptonLabel15.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel15.Name = "KryptonLabel15"
        Me.KryptonLabel15.Size = New System.Drawing.Size(152, 24)
        Me.KryptonLabel15.TabIndex = 10
        Me.KryptonLabel15.Text = "Número de Brevete :"
        Me.KryptonLabel15.Values.ExtraText = ""
        Me.KryptonLabel15.Values.Image = Nothing
        Me.KryptonLabel15.Values.Text = "Número de Brevete :"
        '
        'KryptonLabel14
        '
        Me.KryptonLabel14.Location = New System.Drawing.Point(407, 148)
        Me.KryptonLabel14.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel14.Name = "KryptonLabel14"
        Me.KryptonLabel14.Size = New System.Drawing.Size(117, 24)
        Me.KryptonLabel14.TabIndex = 12
        Me.KryptonLabel14.Text = "Fecha del AVC :"
        Me.KryptonLabel14.Values.ExtraText = ""
        Me.KryptonLabel14.Values.Image = Nothing
        Me.KryptonLabel14.Values.Text = "Fecha del AVC :"
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(12, 178)
        Me.KryptonLabel9.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(158, 24)
        Me.KryptonLabel9.TabIndex = 18
        Me.KryptonLabel9.Text = "Ruta Origen Destino :"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Ruta Origen Destino :"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(12, 48)
        Me.KryptonLabel4.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(130, 24)
        Me.KryptonLabel4.TabIndex = 1
        Me.KryptonLabel4.Text = "Número de AVC :"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Número de AVC :"
        '
        'PanelImporte
        '
        Me.PanelImporte.BackColor = System.Drawing.Color.White
        Me.PanelImporte.Controls.Add(Me.txtImporteSolEfectivo)
        Me.PanelImporte.Controls.Add(Me.KryptonLabel22)
        Me.PanelImporte.Controls.Add(Me.KryptonLabel2)
        Me.PanelImporte.Controls.Add(Me.KryptonBorderEdge5)
        Me.PanelImporte.Controls.Add(Me.cmbMedioTransporte)
        Me.PanelImporte.Controls.Add(Me.txtAdelanto)
        Me.PanelImporte.Controls.Add(Me.txtImporteAVC)
        Me.PanelImporte.Controls.Add(Me.KryptonLabel12)
        Me.PanelImporte.Controls.Add(Me.lblErrorAVC)
        Me.PanelImporte.Controls.Add(Me.KryptonLabel11)
        Me.PanelImporte.Controls.Add(Me.KryptonLabel10)
        Me.PanelImporte.Controls.Add(Me.chkAvcRetorno)
        Me.PanelImporte.Location = New System.Drawing.Point(4, 281)
        Me.PanelImporte.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelImporte.Name = "PanelImporte"
        Me.PanelImporte.Size = New System.Drawing.Size(800, 194)
        Me.PanelImporte.TabIndex = 43
        '
        'txtImporteSolEfectivo
        '
        Me.txtImporteSolEfectivo.Location = New System.Drawing.Point(193, 145)
        Me.txtImporteSolEfectivo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtImporteSolEfectivo.MaxLength = 17
        Me.txtImporteSolEfectivo.Name = "txtImporteSolEfectivo"
        Me.txtImporteSolEfectivo.Size = New System.Drawing.Size(167, 26)
        Me.txtImporteSolEfectivo.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.txtImporteSolEfectivo.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtImporteSolEfectivo.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporteSolEfectivo.TabIndex = 37
        Me.txtImporteSolEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtImporteSolEfectivo.Visible = False
        '
        'KryptonLabel22
        '
        Me.KryptonLabel22.Location = New System.Drawing.Point(5, 149)
        Me.KryptonLabel22.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel22.Name = "KryptonLabel22"
        Me.KryptonLabel22.Size = New System.Drawing.Size(189, 24)
        Me.KryptonLabel22.TabIndex = 33
        Me.KryptonLabel22.Text = "Importe Sol. Ped. Efectivo:"
        Me.KryptonLabel22.Values.ExtraText = ""
        Me.KryptonLabel22.Values.Image = Nothing
        Me.KryptonLabel22.Values.Text = "Importe Sol. Ped. Efectivo:"
        Me.KryptonLabel22.Visible = False
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(4, 21)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(176, 22)
        Me.KryptonLabel2.StateNormal.ShortText.Color1 = System.Drawing.Color.Navy
        Me.KryptonLabel2.StateNormal.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 39
        Me.KryptonLabel2.Text = "Importe Generado AVC"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Importe Generado AVC"
        '
        'KryptonBorderEdge5
        '
        Me.KryptonBorderEdge5.Location = New System.Drawing.Point(19, 11)
        Me.KryptonBorderEdge5.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonBorderEdge5.Name = "KryptonBorderEdge5"
        Me.KryptonBorderEdge5.Size = New System.Drawing.Size(733, 1)
        Me.KryptonBorderEdge5.TabIndex = 38
        Me.KryptonBorderEdge5.Text = "KryptonBorderEdge5"
        '
        'cmbMedioTransporte
        '
        Me.cmbMedioTransporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMedioTransporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmbMedioTransporte.FormattingEnabled = True
        Me.cmbMedioTransporte.Location = New System.Drawing.Point(193, 53)
        Me.cmbMedioTransporte.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMedioTransporte.Name = "cmbMedioTransporte"
        Me.cmbMedioTransporte.Size = New System.Drawing.Size(560, 24)
        Me.cmbMedioTransporte.TabIndex = 34
        '
        'txtAdelanto
        '
        Me.txtAdelanto.Enabled = False
        Me.txtAdelanto.Location = New System.Drawing.Point(193, 114)
        Me.txtAdelanto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAdelanto.Name = "txtAdelanto"
        Me.txtAdelanto.ReadOnly = True
        Me.txtAdelanto.Size = New System.Drawing.Size(167, 26)
        Me.txtAdelanto.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.txtAdelanto.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtAdelanto.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdelanto.TabIndex = 36
        Me.txtAdelanto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImporteAVC
        '
        Me.txtImporteAVC.Enabled = False
        Me.txtImporteAVC.Location = New System.Drawing.Point(193, 86)
        Me.txtImporteAVC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtImporteAVC.Name = "txtImporteAVC"
        Me.txtImporteAVC.ReadOnly = True
        Me.txtImporteAVC.Size = New System.Drawing.Size(167, 26)
        Me.txtImporteAVC.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.txtImporteAVC.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtImporteAVC.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporteAVC.TabIndex = 35
        Me.txtImporteAVC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel12
        '
        Me.KryptonLabel12.Location = New System.Drawing.Point(5, 59)
        Me.KryptonLabel12.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel12.Name = "KryptonLabel12"
        Me.KryptonLabel12.Size = New System.Drawing.Size(141, 24)
        Me.KryptonLabel12.TabIndex = 40
        Me.KryptonLabel12.Text = "Medio Transporte :"
        Me.KryptonLabel12.Values.ExtraText = ""
        Me.KryptonLabel12.Values.Image = Nothing
        Me.KryptonLabel12.Values.Text = "Medio Transporte :"
        '
        'lblErrorAVC
        '
        Me.lblErrorAVC.Location = New System.Drawing.Point(387, 90)
        Me.lblErrorAVC.Margin = New System.Windows.Forms.Padding(4)
        Me.lblErrorAVC.Name = "lblErrorAVC"
        Me.lblErrorAVC.Size = New System.Drawing.Size(77, 24)
        Me.lblErrorAVC.StateNormal.ShortText.Color1 = System.Drawing.Color.Red
        Me.lblErrorAVC.StateNormal.ShortText.Color2 = System.Drawing.Color.Red
        Me.lblErrorAVC.TabIndex = 42
        Me.lblErrorAVC.Text = "Warning :"
        Me.lblErrorAVC.Values.ExtraText = ""
        Me.lblErrorAVC.Values.Image = Nothing
        Me.lblErrorAVC.Values.Text = "Warning :"
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(5, 121)
        Me.KryptonLabel11.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(136, 24)
        Me.KryptonLabel11.TabIndex = 43
        Me.KryptonLabel11.Text = "Adelanto de AVC :"
        Me.KryptonLabel11.Values.ExtraText = ""
        Me.KryptonLabel11.Values.Image = Nothing
        Me.KryptonLabel11.Values.Text = "Adelanto de AVC :"
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(5, 90)
        Me.KryptonLabel10.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(142, 24)
        Me.KryptonLabel10.TabIndex = 41
        Me.KryptonLabel10.Text = "Importe Ruta AVC :"
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "Importe Ruta AVC :"
        '
        'chkAvcRetorno
        '
        Me.chkAvcRetorno.Checked = False
        Me.chkAvcRetorno.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkAvcRetorno.Location = New System.Drawing.Point(369, 121)
        Me.chkAvcRetorno.Margin = New System.Windows.Forms.Padding(4)
        Me.chkAvcRetorno.Name = "chkAvcRetorno"
        Me.chkAvcRetorno.Size = New System.Drawing.Size(109, 24)
        Me.chkAvcRetorno.TabIndex = 6
        Me.chkAvcRetorno.TabStop = False
        Me.chkAvcRetorno.Text = "Sin adelanto"
        Me.chkAvcRetorno.Values.ExtraText = ""
        Me.chkAvcRetorno.Values.Image = Nothing
        Me.chkAvcRetorno.Values.Text = "Sin adelanto"
        '
        'KryptonCheckBox1
        '
        Me.KryptonCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.KryptonCheckBox1.Location = New System.Drawing.Point(660, 35)
        Me.KryptonCheckBox1.Name = "KryptonCheckBox1"
        Me.KryptonCheckBox1.Size = New System.Drawing.Size(146, 16)
        Me.KryptonCheckBox1.TabIndex = 12
        Me.KryptonCheckBox1.TabStop = False
        Me.KryptonCheckBox1.Text = "Generar Pedido Efectivo"
        Me.KryptonCheckBox1.Values.ExtraText = ""
        Me.KryptonCheckBox1.Values.Image = Nothing
        Me.KryptonCheckBox1.Values.Text = "Generar Pedido Efectivo"
        '
        'frmSolicitudEfectivoAVC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 491)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(821, 543)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(821, 481)
        Me.Name = "frmSolicitudEfectivoAVC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Generar AVC"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.Panel.ResumeLayout(False)
        Me.PanelFiltros.Panel.PerformLayout()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.ResumeLayout(False)
        Me.PanelImporte.ResumeLayout(False)
        Me.PanelImporte.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents KryptonCheckBox1 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents PanelFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnBuscarGastosRuta As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents txtComentario As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtMotivoGiro As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtNroSolEfectivo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel26 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel24 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel19 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ckbGenerarPedidoEfectivo As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroBrevete As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents dtpFechaAvc As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtOrigen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtNroAVC As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel15 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbPlaca As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscaOrdenServicio As System.Windows.Forms.Button
    Friend WithEvents txtNroOperacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbObrero As System.Windows.Forms.ComboBox
    Friend WithEvents btnRutas As System.Windows.Forms.Button
    Friend WithEvents PanelImporte As System.Windows.Forms.Panel
    Friend WithEvents txtImporteSolEfectivo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel22 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonBorderEdge5 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents cmbMedioTransporte As System.Windows.Forms.ComboBox
    Friend WithEvents txtAdelanto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtImporteAVC As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblErrorAVC As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents chkAvcRetorno As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
End Class
