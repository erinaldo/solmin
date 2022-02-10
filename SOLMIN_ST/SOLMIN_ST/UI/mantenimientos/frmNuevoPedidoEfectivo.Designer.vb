<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevoPedidoEfectivo
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuevoPedidoEfectivo))
    Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.btnGuardar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.btnSalir = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.cmbPlaca = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Me.btnBuscaOrdenServicio = New System.Windows.Forms.Button
    Me.ctbObrero = New CodeTextBox.CodeTextBox
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtOperacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.txtMotivo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel26 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.dtpFechaAvc = New System.Windows.Forms.DateTimePicker
    Me.txtImporte = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.txtMoneda = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.txtPedido = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel15 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelFiltros.Panel.SuspendLayout()
    Me.PanelFiltros.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.PanelFiltros)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(537, 226)
    Me.KryptonPanel.TabIndex = 0
    '
    'PanelFiltros
    '
    Me.PanelFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnGuardar, Me.btnSalir})
    Me.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PanelFiltros.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
    Me.PanelFiltros.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.PanelFiltros.HeaderVisiblePrimary = False
    Me.PanelFiltros.Location = New System.Drawing.Point(0, 0)
    Me.PanelFiltros.Name = "PanelFiltros"
    '
    'PanelFiltros.Panel
    '
    Me.PanelFiltros.Panel.Controls.Add(Me.cmbPlaca)
    Me.PanelFiltros.Panel.Controls.Add(Me.btnBuscaOrdenServicio)
    Me.PanelFiltros.Panel.Controls.Add(Me.ctbObrero)
    Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel2)
    Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel1)
    Me.PanelFiltros.Panel.Controls.Add(Me.txtOperacion)
    Me.PanelFiltros.Panel.Controls.Add(Me.txtMotivo)
    Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel26)
    Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel5)
    Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel3)
    Me.PanelFiltros.Panel.Controls.Add(Me.dtpFechaAvc)
    Me.PanelFiltros.Panel.Controls.Add(Me.txtImporte)
    Me.PanelFiltros.Panel.Controls.Add(Me.txtMoneda)
    Me.PanelFiltros.Panel.Controls.Add(Me.txtPedido)
    Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel15)
    Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel9)
    Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel7)
    Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel4)
    Me.PanelFiltros.Size = New System.Drawing.Size(537, 226)
    Me.PanelFiltros.TabIndex = 0
    Me.PanelFiltros.Text = "Datos Generales"
    Me.PanelFiltros.ValuesPrimary.Description = "Datos Generales"
    Me.PanelFiltros.ValuesPrimary.Heading = "Datos Generales"
    Me.PanelFiltros.ValuesPrimary.Image = Nothing
    Me.PanelFiltros.ValuesSecondary.Description = ""
    Me.PanelFiltros.ValuesSecondary.Heading = "Datos Generales"
    Me.PanelFiltros.ValuesSecondary.Image = Nothing
    '
    'btnGuardar
    '
    Me.btnGuardar.ExtraText = ""
    Me.btnGuardar.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
    Me.btnGuardar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
    Me.btnGuardar.Text = "Guardar "
    Me.btnGuardar.ToolTipImage = Nothing
    Me.btnGuardar.UniqueName = "1E7B5DC088DB4E1F1E7B5DC088DB4E1F"
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
    'cmbPlaca
    '
    Me.cmbPlaca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cmbPlaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cmbPlaca.DropDownWidth = 156
    Me.cmbPlaca.FormattingEnabled = False
    Me.cmbPlaca.ItemHeight = 13
    Me.cmbPlaca.Location = New System.Drawing.Point(128, 161)
    Me.cmbPlaca.Name = "cmbPlaca"
    Me.cmbPlaca.Size = New System.Drawing.Size(396, 21)
    Me.cmbPlaca.TabIndex = 7
    '
    'btnBuscaOrdenServicio
    '
    Me.btnBuscaOrdenServicio.Image = Global.SOLMIN_ST.My.Resources.Resources.cell_layout
    Me.btnBuscaOrdenServicio.Location = New System.Drawing.Point(257, 131)
    Me.btnBuscaOrdenServicio.Name = "btnBuscaOrdenServicio"
    Me.btnBuscaOrdenServicio.Size = New System.Drawing.Size(25, 24)
    Me.btnBuscaOrdenServicio.TabIndex = 5
    Me.btnBuscaOrdenServicio.UseVisualStyleBackColor = True
    '
    'ctbObrero
    '
    Me.ctbObrero.BackColor = System.Drawing.SystemColors.Control
    Me.ctbObrero.Codigo = ""
    Me.ctbObrero.ControlHeight = 23
    Me.ctbObrero.ControlImage = True
    Me.ctbObrero.ControlReadOnly = False
    Me.ctbObrero.Descripcion = ""
    Me.ctbObrero.DisplayColumnVisible = True
    Me.ctbObrero.DisplayMember = ""
    Me.ctbObrero.KeyColumnWidth = 100
    Me.ctbObrero.KeyField = ""
    Me.ctbObrero.KeySearch = True
    Me.ctbObrero.Location = New System.Drawing.Point(128, 25)
    Me.ctbObrero.Name = "ctbObrero"
    Me.ctbObrero.Size = New System.Drawing.Size(396, 23)
    Me.ctbObrero.TabIndex = 0
    Me.ctbObrero.Tag = ""
    Me.ctbObrero.TextBackColor = System.Drawing.Color.Empty
    Me.ctbObrero.TextForeColor = System.Drawing.Color.Empty
    Me.ctbObrero.ValueColumnVisible = True
    Me.ctbObrero.ValueColumnWidth = 600
    Me.ctbObrero.ValueField = ""
    Me.ctbObrero.ValueMember = ""
    Me.ctbObrero.ValueSearch = True
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(11, 166)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(42, 19)
    Me.KryptonLabel2.TabIndex = 17
    Me.KryptonLabel2.Text = "Placa :"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "Placa :"
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(11, 139)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(71, 19)
    Me.KryptonLabel1.TabIndex = 15
    Me.KryptonLabel1.Text = "Operación  :"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Operación  :"
    '
    'txtOperacion
    '
    Me.txtOperacion.Location = New System.Drawing.Point(128, 136)
    Me.txtOperacion.MaxLength = 10
    Me.txtOperacion.Name = "txtOperacion"
    Me.txtOperacion.Size = New System.Drawing.Size(123, 21)
    Me.txtOperacion.StateDisabled.Back.Color1 = System.Drawing.Color.White
    Me.txtOperacion.StateDisabled.Content.Color1 = System.Drawing.Color.Black
    Me.txtOperacion.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtOperacion.TabIndex = 4
    '
    'txtMotivo
    '
    Me.txtMotivo.Location = New System.Drawing.Point(128, 108)
    Me.txtMotivo.MaxLength = 30
    Me.txtMotivo.Name = "txtMotivo"
    Me.txtMotivo.Size = New System.Drawing.Size(396, 21)
    Me.txtMotivo.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtMotivo.StateDisabled.Back.Color1 = System.Drawing.Color.White
    Me.txtMotivo.StateDisabled.Content.Color1 = System.Drawing.Color.Black
    Me.txtMotivo.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMotivo.TabIndex = 8
    '
    'KryptonLabel26
    '
    Me.KryptonLabel26.Location = New System.Drawing.Point(11, 111)
    Me.KryptonLabel26.Name = "KryptonLabel26"
    Me.KryptonLabel26.Size = New System.Drawing.Size(51, 19)
    Me.KryptonLabel26.TabIndex = 9
    Me.KryptonLabel26.Text = "Motivo :"
    Me.KryptonLabel26.Values.ExtraText = ""
    Me.KryptonLabel26.Values.Image = Nothing
    Me.KryptonLabel26.Values.Text = "Motivo :"
    '
    'KryptonLabel5
    '
    Me.KryptonLabel5.Location = New System.Drawing.Point(3, 3)
    Me.KryptonLabel5.Name = "KryptonLabel5"
    Me.KryptonLabel5.Size = New System.Drawing.Size(154, 18)
    Me.KryptonLabel5.StateNormal.ShortText.Color1 = System.Drawing.Color.Navy
    Me.KryptonLabel5.StateNormal.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.KryptonLabel5.TabIndex = 0
    Me.KryptonLabel5.Text = "Solicitud Pedido Efectivo"
    Me.KryptonLabel5.Values.ExtraText = ""
    Me.KryptonLabel5.Values.Image = Nothing
    Me.KryptonLabel5.Values.Text = "Solicitud Pedido Efectivo"
    '
    'KryptonLabel3
    '
    Me.KryptonLabel3.Location = New System.Drawing.Point(300, 58)
    Me.KryptonLabel3.Name = "KryptonLabel3"
    Me.KryptonLabel3.Size = New System.Drawing.Size(48, 19)
    Me.KryptonLabel3.TabIndex = 3
    Me.KryptonLabel3.Text = "Fecha  :"
    Me.KryptonLabel3.Values.ExtraText = ""
    Me.KryptonLabel3.Values.Image = Nothing
    Me.KryptonLabel3.Values.Text = "Fecha  :"
    '
    'dtpFechaAvc
    '
    Me.dtpFechaAvc.BackColor = System.Drawing.Color.White
    Me.dtpFechaAvc.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpFechaAvc.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonHighlight
    Me.dtpFechaAvc.Enabled = False
    Me.dtpFechaAvc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
    Me.dtpFechaAvc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaAvc.Location = New System.Drawing.Point(383, 53)
    Me.dtpFechaAvc.Name = "dtpFechaAvc"
    Me.dtpFechaAvc.Size = New System.Drawing.Size(140, 20)
    Me.dtpFechaAvc.TabIndex = 3
    '
    'txtImporte
    '
    Me.txtImporte.Location = New System.Drawing.Point(383, 81)
    Me.txtImporte.MaxLength = 15
    Me.txtImporte.Name = "txtImporte"
    Me.txtImporte.Size = New System.Drawing.Size(140, 21)
    Me.txtImporte.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtImporte.StateDisabled.Back.Color1 = System.Drawing.Color.White
    Me.txtImporte.StateDisabled.Content.Color1 = System.Drawing.Color.Black
    Me.txtImporte.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtImporte.TabIndex = 6
    Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'txtMoneda
    '
    Me.txtMoneda.Enabled = False
    Me.txtMoneda.Location = New System.Drawing.Point(128, 81)
    Me.txtMoneda.Name = "txtMoneda"
    Me.txtMoneda.ReadOnly = True
    Me.txtMoneda.Size = New System.Drawing.Size(154, 21)
    Me.txtMoneda.StateDisabled.Back.Color1 = System.Drawing.Color.White
    Me.txtMoneda.StateDisabled.Content.Color1 = System.Drawing.Color.Black
    Me.txtMoneda.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMoneda.TabIndex = 2
    Me.txtMoneda.Text = "Nuevos Soles"
    '
    'txtPedido
    '
    Me.txtPedido.Enabled = False
    Me.txtPedido.Location = New System.Drawing.Point(128, 54)
    Me.txtPedido.Name = "txtPedido"
    Me.txtPedido.ReadOnly = True
    Me.txtPedido.Size = New System.Drawing.Size(154, 21)
    Me.txtPedido.StateDisabled.Back.Color1 = System.Drawing.Color.White
    Me.txtPedido.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
    Me.txtPedido.StateDisabled.Content.Color1 = System.Drawing.Color.Black
    Me.txtPedido.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtPedido.TabIndex = 1
    '
    'KryptonLabel15
    '
    Me.KryptonLabel15.Location = New System.Drawing.Point(11, 33)
    Me.KryptonLabel15.Name = "KryptonLabel15"
    Me.KryptonLabel15.Size = New System.Drawing.Size(51, 19)
    Me.KryptonLabel15.TabIndex = 11
    Me.KryptonLabel15.Text = "Obrero :"
    Me.KryptonLabel15.Values.ExtraText = ""
    Me.KryptonLabel15.Values.Image = Nothing
    Me.KryptonLabel15.Values.Text = "Obrero :"
    '
    'KryptonLabel9
    '
    Me.KryptonLabel9.Location = New System.Drawing.Point(300, 85)
    Me.KryptonLabel9.Name = "KryptonLabel9"
    Me.KryptonLabel9.Size = New System.Drawing.Size(59, 19)
    Me.KryptonLabel9.TabIndex = 5
    Me.KryptonLabel9.Text = "Importe  :"
    Me.KryptonLabel9.Values.ExtraText = ""
    Me.KryptonLabel9.Values.Image = Nothing
    Me.KryptonLabel9.Values.Text = "Importe  :"
    '
    'KryptonLabel7
    '
    Me.KryptonLabel7.Location = New System.Drawing.Point(11, 85)
    Me.KryptonLabel7.Name = "KryptonLabel7"
    Me.KryptonLabel7.Size = New System.Drawing.Size(60, 19)
    Me.KryptonLabel7.TabIndex = 13
    Me.KryptonLabel7.Text = "Moneda  :"
    Me.KryptonLabel7.Values.ExtraText = ""
    Me.KryptonLabel7.Values.Image = Nothing
    Me.KryptonLabel7.Values.Text = "Moneda  :"
    '
    'KryptonLabel4
    '
    Me.KryptonLabel4.Location = New System.Drawing.Point(11, 58)
    Me.KryptonLabel4.Name = "KryptonLabel4"
    Me.KryptonLabel4.Size = New System.Drawing.Size(108, 19)
    Me.KryptonLabel4.TabIndex = 1
    Me.KryptonLabel4.Text = "Número de Pedido:"
    Me.KryptonLabel4.Values.ExtraText = ""
    Me.KryptonLabel4.Values.Image = Nothing
    Me.KryptonLabel4.Values.Text = "Número de Pedido:"
    '
    'frmNuevoPedidoEfectivo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(537, 226)
    Me.ControlBox = False
    Me.Controls.Add(Me.KryptonPanel)
    Me.MaximizeBox = False
    Me.MaximumSize = New System.Drawing.Size(545, 260)
    Me.MinimizeBox = False
    Me.MinimumSize = New System.Drawing.Size(545, 260)
    Me.Name = "frmNuevoPedidoEfectivo"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Nuevo Solicitud Pedido Efectivo"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelFiltros.Panel.ResumeLayout(False)
    Me.PanelFiltros.Panel.PerformLayout()
    CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelFiltros.ResumeLayout(False)
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
    Friend WithEvents PanelFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnGuardar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents KryptonLabel26 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaAvc As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtImporte As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtMoneda As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtPedido As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel15 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtOperacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtMotivo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents ctbObrero As CodeTextBox.CodeTextBox
    Friend WithEvents btnBuscaOrdenServicio As System.Windows.Forms.Button
    Friend WithEvents cmbPlaca As ComponentFactory.Krypton.Toolkit.KryptonComboBox
End Class
