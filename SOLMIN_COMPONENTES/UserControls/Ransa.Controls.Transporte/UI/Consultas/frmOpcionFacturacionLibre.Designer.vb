<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpcionFacturacionLibre
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
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.panelOpcion = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.groupElegir = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.txtTipoDoc = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtImporteDolares = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblImporteDolares = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtImporteSoles = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblImporteSoles = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtMotivo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblMotivo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtOrganizacionVenta = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblOrgVenta = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFactura = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblOperacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtFactura = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtOperacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblNIT = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDireccion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblDireccion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNIT = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.btnCerrar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.panelOpcion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelOpcion.SuspendLayout()
        CType(Me.groupElegir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupElegir.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupElegir.Panel.SuspendLayout()
        Me.groupElegir.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.panelOpcion)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(471, 300)
        Me.KryptonPanel.TabIndex = 0
        '
        'panelOpcion
        '
        Me.panelOpcion.Controls.Add(Me.groupElegir)
        Me.panelOpcion.Controls.Add(Me.ToolStrip1)
        Me.panelOpcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelOpcion.Location = New System.Drawing.Point(0, 0)
        Me.panelOpcion.Name = "panelOpcion"
        Me.panelOpcion.Size = New System.Drawing.Size(471, 300)
        Me.panelOpcion.StateCommon.Color1 = System.Drawing.Color.White
        Me.panelOpcion.TabIndex = 7
        '
        'groupElegir
        '
        Me.groupElegir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupElegir.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonStandalone
        Me.groupElegir.Location = New System.Drawing.Point(0, 25)
        Me.groupElegir.Name = "groupElegir"
        Me.groupElegir.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        '
        'groupElegir.Panel
        '
        Me.groupElegir.Panel.Controls.Add(Me.txtTipoDoc)
        Me.groupElegir.Panel.Controls.Add(Me.KryptonLabel1)
        Me.groupElegir.Panel.Controls.Add(Me.txtImporteDolares)
        Me.groupElegir.Panel.Controls.Add(Me.lblImporteDolares)
        Me.groupElegir.Panel.Controls.Add(Me.txtImporteSoles)
        Me.groupElegir.Panel.Controls.Add(Me.lblImporteSoles)
        Me.groupElegir.Panel.Controls.Add(Me.txtMotivo)
        Me.groupElegir.Panel.Controls.Add(Me.lblMotivo)
        Me.groupElegir.Panel.Controls.Add(Me.txtOrganizacionVenta)
        Me.groupElegir.Panel.Controls.Add(Me.lblOrgVenta)
        Me.groupElegir.Panel.Controls.Add(Me.lblFactura)
        Me.groupElegir.Panel.Controls.Add(Me.lblOperacion)
        Me.groupElegir.Panel.Controls.Add(Me.txtFactura)
        Me.groupElegir.Panel.Controls.Add(Me.txtOperacion)
        Me.groupElegir.Panel.Controls.Add(Me.lblNIT)
        Me.groupElegir.Panel.Controls.Add(Me.txtDireccion)
        Me.groupElegir.Panel.Controls.Add(Me.lblDireccion)
        Me.groupElegir.Panel.Controls.Add(Me.lblCliente)
        Me.groupElegir.Panel.Controls.Add(Me.txtNIT)
        Me.groupElegir.Panel.Controls.Add(Me.txtCliente)
        Me.groupElegir.Panel.Controls.Add(Me.btnCerrar)
        Me.groupElegir.Size = New System.Drawing.Size(471, 275)
        Me.groupElegir.TabIndex = 1
        '
        'txtTipoDoc
        '
        Me.txtTipoDoc.Enabled = False
        Me.txtTipoDoc.Location = New System.Drawing.Point(120, 149)
        Me.txtTipoDoc.MaxLength = 10
        Me.txtTipoDoc.Name = "txtTipoDoc"
        Me.txtTipoDoc.Size = New System.Drawing.Size(105, 22)
        Me.txtTipoDoc.StateDisabled.Border.Color1 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtTipoDoc.StateDisabled.Border.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtTipoDoc.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtTipoDoc.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtTipoDoc.TabIndex = 11
        Me.txtTipoDoc.Tag = "1"
        Me.txtTipoDoc.Text = "FACTURA"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(5, 151)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(119, 20)
        Me.KryptonLabel1.TabIndex = 10
        Me.KryptonLabel1.Text = "Tipo de Documento"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Tipo de Documento"
        '
        'txtImporteDolares
        '
        Me.txtImporteDolares.Enabled = False
        Me.txtImporteDolares.Location = New System.Drawing.Point(343, 236)
        Me.txtImporteDolares.Name = "txtImporteDolares"
        Me.txtImporteDolares.Size = New System.Drawing.Size(105, 22)
        Me.txtImporteDolares.StateDisabled.Border.Color1 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtImporteDolares.StateDisabled.Border.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtImporteDolares.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtImporteDolares.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtImporteDolares.TabIndex = 19
        Me.txtImporteDolares.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblImporteDolares
        '
        Me.lblImporteDolares.Location = New System.Drawing.Point(236, 237)
        Me.lblImporteDolares.Name = "lblImporteDolares"
        Me.lblImporteDolares.Size = New System.Drawing.Size(115, 20)
        Me.lblImporteDolares.TabIndex = 18
        Me.lblImporteDolares.Text = "Importe en Dólares"
        Me.lblImporteDolares.Values.ExtraText = ""
        Me.lblImporteDolares.Values.Image = Nothing
        Me.lblImporteDolares.Values.Text = "Importe en Dólares"
        '
        'txtImporteSoles
        '
        Me.txtImporteSoles.Enabled = False
        Me.txtImporteSoles.Location = New System.Drawing.Point(120, 237)
        Me.txtImporteSoles.Name = "txtImporteSoles"
        Me.txtImporteSoles.Size = New System.Drawing.Size(105, 22)
        Me.txtImporteSoles.StateDisabled.Border.Color1 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtImporteSoles.StateDisabled.Border.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtImporteSoles.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtImporteSoles.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtImporteSoles.TabIndex = 17
        Me.txtImporteSoles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblImporteSoles
        '
        Me.lblImporteSoles.Location = New System.Drawing.Point(5, 238)
        Me.lblImporteSoles.Name = "lblImporteSoles"
        Me.lblImporteSoles.Size = New System.Drawing.Size(103, 20)
        Me.lblImporteSoles.TabIndex = 16
        Me.lblImporteSoles.Text = "Importe en Soles"
        Me.lblImporteSoles.Values.ExtraText = ""
        Me.lblImporteSoles.Values.Image = Nothing
        Me.lblImporteSoles.Values.Text = "Importe en Soles"
        '
        'txtMotivo
        '
        Me.txtMotivo.Location = New System.Drawing.Point(120, 206)
        Me.txtMotivo.MaxLength = 29
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(328, 22)
        Me.txtMotivo.StateDisabled.Border.Color1 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtMotivo.StateDisabled.Border.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtMotivo.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtMotivo.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtMotivo.TabIndex = 15
        '
        'lblMotivo
        '
        Me.lblMotivo.Location = New System.Drawing.Point(5, 208)
        Me.lblMotivo.Name = "lblMotivo"
        Me.lblMotivo.Size = New System.Drawing.Size(122, 20)
        Me.lblMotivo.TabIndex = 14
        Me.lblMotivo.Text = "Motivo de la Factura"
        Me.lblMotivo.Values.ExtraText = ""
        Me.lblMotivo.Values.Image = Nothing
        Me.lblMotivo.Values.Text = "Motivo de la Factura"
        '
        'txtOrganizacionVenta
        '
        Me.txtOrganizacionVenta.Enabled = False
        Me.txtOrganizacionVenta.Location = New System.Drawing.Point(120, 122)
        Me.txtOrganizacionVenta.Name = "txtOrganizacionVenta"
        Me.txtOrganizacionVenta.Size = New System.Drawing.Size(205, 22)
        Me.txtOrganizacionVenta.StateDisabled.Border.Color1 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtOrganizacionVenta.StateDisabled.Border.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtOrganizacionVenta.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtOrganizacionVenta.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtOrganizacionVenta.TabIndex = 9
        Me.txtOrganizacionVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblOrgVenta
        '
        Me.lblOrgVenta.Location = New System.Drawing.Point(4, 126)
        Me.lblOrgVenta.Name = "lblOrgVenta"
        Me.lblOrgVenta.Size = New System.Drawing.Size(117, 20)
        Me.lblOrgVenta.TabIndex = 8
        Me.lblOrgVenta.Text = "Organización Venta"
        Me.lblOrgVenta.Values.ExtraText = ""
        Me.lblOrgVenta.Values.Image = Nothing
        Me.lblOrgVenta.Values.Text = "Organización Venta"
        '
        'lblFactura
        '
        Me.lblFactura.Location = New System.Drawing.Point(4, 179)
        Me.lblFactura.Name = "lblFactura"
        Me.lblFactura.Size = New System.Drawing.Size(68, 20)
        Me.lblFactura.TabIndex = 12
        Me.lblFactura.Text = "N° Factura"
        Me.lblFactura.Values.ExtraText = ""
        Me.lblFactura.Values.Image = Nothing
        Me.lblFactura.Values.Text = "N° Factura"
        '
        'lblOperacion
        '
        Me.lblOperacion.Location = New System.Drawing.Point(4, 96)
        Me.lblOperacion.Name = "lblOperacion"
        Me.lblOperacion.Size = New System.Drawing.Size(84, 20)
        Me.lblOperacion.TabIndex = 6
        Me.lblOperacion.Text = "N° Operación"
        Me.lblOperacion.Values.ExtraText = ""
        Me.lblOperacion.Values.Image = Nothing
        Me.lblOperacion.Values.Text = "N° Operación"
        '
        'txtFactura
        '
        Me.txtFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFactura.Location = New System.Drawing.Point(120, 177)
        Me.txtFactura.MaxLength = 10
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(105, 22)
        Me.txtFactura.StateDisabled.Border.Color1 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtFactura.StateDisabled.Border.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtFactura.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtFactura.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtFactura.TabIndex = 13
        Me.txtFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOperacion
        '
        Me.txtOperacion.Enabled = False
        Me.txtOperacion.Location = New System.Drawing.Point(120, 93)
        Me.txtOperacion.Multiline = True
        Me.txtOperacion.Name = "txtOperacion"
        Me.txtOperacion.Size = New System.Drawing.Size(328, 21)
        Me.txtOperacion.StateDisabled.Border.Color1 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtOperacion.StateDisabled.Border.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtOperacion.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtOperacion.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtOperacion.TabIndex = 7
        '
        'lblNIT
        '
        Me.lblNIT.Location = New System.Drawing.Point(4, 36)
        Me.lblNIT.Name = "lblNIT"
        Me.lblNIT.Size = New System.Drawing.Size(57, 20)
        Me.lblNIT.TabIndex = 2
        Me.lblNIT.Text = "N°  N I T"
        Me.lblNIT.Values.ExtraText = ""
        Me.lblNIT.Values.Image = Nothing
        Me.lblNIT.Values.Text = "N°  N I T"
        '
        'txtDireccion
        '
        Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(120, 64)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(328, 22)
        Me.txtDireccion.StateDisabled.Border.Color1 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtDireccion.StateDisabled.Border.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtDireccion.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtDireccion.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtDireccion.TabIndex = 5
        '
        'lblDireccion
        '
        Me.lblDireccion.Location = New System.Drawing.Point(4, 65)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(62, 20)
        Me.lblDireccion.TabIndex = 4
        Me.lblDireccion.Text = "Dirección"
        Me.lblDireccion.Values.ExtraText = ""
        Me.lblDireccion.Values.Image = Nothing
        Me.lblDireccion.Values.Text = "Dirección"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(4, 8)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(48, 20)
        Me.lblCliente.TabIndex = 0
        Me.lblCliente.Text = "Cliente"
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente"
        '
        'txtNIT
        '
        Me.txtNIT.Enabled = False
        Me.txtNIT.Location = New System.Drawing.Point(120, 35)
        Me.txtNIT.Name = "txtNIT"
        Me.txtNIT.Size = New System.Drawing.Size(105, 22)
        Me.txtNIT.StateDisabled.Border.Color1 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtNIT.StateDisabled.Border.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtNIT.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtNIT.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtNIT.TabIndex = 3
        Me.txtNIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCliente
        '
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(120, 7)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(328, 22)
        Me.txtCliente.StateDisabled.Border.Color1 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtCliente.StateDisabled.Border.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtCliente.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtCliente.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtCliente.TabIndex = 1
        '
        'btnCerrar
        '
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Location = New System.Drawing.Point(40, -32)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(8, 25)
        Me.btnCerrar.TabIndex = 20
        Me.btnCerrar.Text = "."
        Me.btnCerrar.Values.ExtraText = ""
        Me.btnCerrar.Values.Image = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCerrar.Values.Text = "."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.ToolStripSeparator1, Me.btnAceptar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(471, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.Ransa.Controls.Transporte.My.Resources.Resources.button_cancel
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
        'btnAceptar
        '
        Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAceptar.Image = Global.Ransa.Controls.Transporte.My.Resources.Resources.button_ok1
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(68, 22)
        Me.btnAceptar.Text = "Aceptar"
        '
        'frmOpcionFacturacionLibre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmOpcionFacturacionLibre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FACTURACIÓN LIBRE"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.panelOpcion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelOpcion.ResumeLayout(False)
        Me.panelOpcion.PerformLayout()
        CType(Me.groupElegir.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupElegir.Panel.ResumeLayout(False)
        Me.groupElegir.Panel.PerformLayout()
        CType(Me.groupElegir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupElegir.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
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
    Friend WithEvents panelOpcion As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents groupElegir As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents lblMotivo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtOrganizacionVenta As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblOrgVenta As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFactura As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblOperacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtFactura As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtOperacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblNIT As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDireccion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblDireccion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNIT As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnCerrar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblImporteDolares As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtImporteSoles As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblImporteSoles As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtMotivo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtImporteDolares As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTipoDoc As ComponentFactory.Krypton.Toolkit.KryptonTextBox
End Class
