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
        Me.components = New System.ComponentModel.Container()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.panelOpcion = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.groupElegir = New ComponentFactory.Krypton.Toolkit.KryptonGroup()
        Me.txtOperacion = New System.Windows.Forms.TextBox()
        Me.cboTipoDoc = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtImporteDolares = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblImporteDolares = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtImporteSoles = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblImporteSoles = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtMotivo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblMotivo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtOrganizacionVenta = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblOrgVenta = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblFactura = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblOperacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtFactura = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.btnCerrar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton()
        Me.chkSap = New System.Windows.Forms.CheckBox()
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
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.panelOpcion)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(628, 346)
        Me.KryptonPanel.TabIndex = 0
        '
        'panelOpcion
        '
        Me.panelOpcion.Controls.Add(Me.groupElegir)
        Me.panelOpcion.Controls.Add(Me.ToolStrip1)
        Me.panelOpcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelOpcion.Location = New System.Drawing.Point(0, 0)
        Me.panelOpcion.Margin = New System.Windows.Forms.Padding(4)
        Me.panelOpcion.Name = "panelOpcion"
        Me.panelOpcion.Size = New System.Drawing.Size(628, 346)
        Me.panelOpcion.StateCommon.Color1 = System.Drawing.Color.White
        Me.panelOpcion.TabIndex = 7
        '
        'groupElegir
        '
        Me.groupElegir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupElegir.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonStandalone
        Me.groupElegir.Location = New System.Drawing.Point(0, 27)
        Me.groupElegir.Margin = New System.Windows.Forms.Padding(4)
        Me.groupElegir.Name = "groupElegir"
        Me.groupElegir.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        '
        'groupElegir.Panel
        '
        Me.groupElegir.Panel.Controls.Add(Me.chkSap)
        Me.groupElegir.Panel.Controls.Add(Me.txtOperacion)
        Me.groupElegir.Panel.Controls.Add(Me.cboTipoDoc)
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
        Me.groupElegir.Panel.Controls.Add(Me.lblCliente)
        Me.groupElegir.Panel.Controls.Add(Me.txtCliente)
        Me.groupElegir.Panel.Controls.Add(Me.btnCerrar)
        Me.groupElegir.Size = New System.Drawing.Size(628, 319)
        Me.groupElegir.TabIndex = 1
        '
        'txtOperacion
        '
        Me.txtOperacion.Enabled = False
        Me.txtOperacion.Location = New System.Drawing.Point(160, 47)
        Me.txtOperacion.Name = "txtOperacion"
        Me.txtOperacion.Size = New System.Drawing.Size(437, 22)
        Me.txtOperacion.TabIndex = 22
        '
        'cboTipoDoc
        '
        Me.cboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDoc.DropDownWidth = 205
        Me.cboTipoDoc.FormattingEnabled = False
        Me.cboTipoDoc.ItemHeight = 20
        Me.cboTipoDoc.Location = New System.Drawing.Point(160, 114)
        Me.cboTipoDoc.Margin = New System.Windows.Forms.Padding(4)
        Me.cboTipoDoc.Name = "cboTipoDoc"
        Me.cboTipoDoc.Size = New System.Drawing.Size(273, 28)
        Me.cboTipoDoc.StateActive.Back.Color1 = System.Drawing.Color.White
        Me.cboTipoDoc.TabIndex = 21
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(7, 115)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(147, 26)
        Me.KryptonLabel1.TabIndex = 10
        Me.KryptonLabel1.Text = "Tipo de Documento"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Tipo de Documento"
        '
        'txtImporteDolares
        '
        Me.txtImporteDolares.Enabled = False
        Me.txtImporteDolares.Location = New System.Drawing.Point(457, 219)
        Me.txtImporteDolares.Margin = New System.Windows.Forms.Padding(4)
        Me.txtImporteDolares.Name = "txtImporteDolares"
        Me.txtImporteDolares.Size = New System.Drawing.Size(140, 26)
        Me.txtImporteDolares.TabIndex = 19
        Me.txtImporteDolares.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblImporteDolares
        '
        Me.lblImporteDolares.Location = New System.Drawing.Point(315, 221)
        Me.lblImporteDolares.Margin = New System.Windows.Forms.Padding(4)
        Me.lblImporteDolares.Name = "lblImporteDolares"
        Me.lblImporteDolares.Size = New System.Drawing.Size(143, 26)
        Me.lblImporteDolares.TabIndex = 18
        Me.lblImporteDolares.Text = "Importe en Dólares"
        Me.lblImporteDolares.Values.ExtraText = ""
        Me.lblImporteDolares.Values.Image = Nothing
        Me.lblImporteDolares.Values.Text = "Importe en Dólares"
        '
        'txtImporteSoles
        '
        Me.txtImporteSoles.Enabled = False
        Me.txtImporteSoles.Location = New System.Drawing.Point(160, 221)
        Me.txtImporteSoles.Margin = New System.Windows.Forms.Padding(4)
        Me.txtImporteSoles.Name = "txtImporteSoles"
        Me.txtImporteSoles.Size = New System.Drawing.Size(140, 26)
        Me.txtImporteSoles.TabIndex = 17
        Me.txtImporteSoles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblImporteSoles
        '
        Me.lblImporteSoles.Location = New System.Drawing.Point(7, 222)
        Me.lblImporteSoles.Margin = New System.Windows.Forms.Padding(4)
        Me.lblImporteSoles.Name = "lblImporteSoles"
        Me.lblImporteSoles.Size = New System.Drawing.Size(127, 26)
        Me.lblImporteSoles.TabIndex = 16
        Me.lblImporteSoles.Text = "Importe en Soles"
        Me.lblImporteSoles.Values.ExtraText = ""
        Me.lblImporteSoles.Values.Image = Nothing
        Me.lblImporteSoles.Values.Text = "Importe en Soles"
        '
        'txtMotivo
        '
        Me.txtMotivo.Location = New System.Drawing.Point(160, 183)
        Me.txtMotivo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMotivo.MaxLength = 25
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(437, 26)
        Me.txtMotivo.TabIndex = 15
        '
        'lblMotivo
        '
        Me.lblMotivo.Location = New System.Drawing.Point(7, 185)
        Me.lblMotivo.Margin = New System.Windows.Forms.Padding(4)
        Me.lblMotivo.Name = "lblMotivo"
        Me.lblMotivo.Size = New System.Drawing.Size(151, 26)
        Me.lblMotivo.TabIndex = 14
        Me.lblMotivo.Text = "Motivo de la Factura"
        Me.lblMotivo.Values.ExtraText = ""
        Me.lblMotivo.Values.Image = Nothing
        Me.lblMotivo.Values.Text = "Motivo de la Factura"
        '
        'txtOrganizacionVenta
        '
        Me.txtOrganizacionVenta.Enabled = False
        Me.txtOrganizacionVenta.Location = New System.Drawing.Point(160, 79)
        Me.txtOrganizacionVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOrganizacionVenta.Name = "txtOrganizacionVenta"
        Me.txtOrganizacionVenta.Size = New System.Drawing.Size(273, 26)
        Me.txtOrganizacionVenta.TabIndex = 9
        Me.txtOrganizacionVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblOrgVenta
        '
        Me.lblOrgVenta.Location = New System.Drawing.Point(5, 84)
        Me.lblOrgVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.lblOrgVenta.Name = "lblOrgVenta"
        Me.lblOrgVenta.Size = New System.Drawing.Size(145, 26)
        Me.lblOrgVenta.TabIndex = 8
        Me.lblOrgVenta.Text = "Organización Venta"
        Me.lblOrgVenta.Values.ExtraText = ""
        Me.lblOrgVenta.Values.Image = Nothing
        Me.lblOrgVenta.Values.Text = "Organización Venta"
        '
        'lblFactura
        '
        Me.lblFactura.Location = New System.Drawing.Point(5, 149)
        Me.lblFactura.Margin = New System.Windows.Forms.Padding(4)
        Me.lblFactura.Name = "lblFactura"
        Me.lblFactura.Size = New System.Drawing.Size(83, 26)
        Me.lblFactura.TabIndex = 12
        Me.lblFactura.Text = "N° Factura"
        Me.lblFactura.Values.ExtraText = ""
        Me.lblFactura.Values.Image = Nothing
        Me.lblFactura.Values.Text = "N° Factura"
        '
        'lblOperacion
        '
        Me.lblOperacion.Location = New System.Drawing.Point(5, 47)
        Me.lblOperacion.Margin = New System.Windows.Forms.Padding(4)
        Me.lblOperacion.Name = "lblOperacion"
        Me.lblOperacion.Size = New System.Drawing.Size(104, 26)
        Me.lblOperacion.TabIndex = 6
        Me.lblOperacion.Text = "N° Operación"
        Me.lblOperacion.Values.ExtraText = ""
        Me.lblOperacion.Values.Image = Nothing
        Me.lblOperacion.Values.Text = "N° Operación"
        '
        'txtFactura
        '
        Me.txtFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFactura.Location = New System.Drawing.Point(160, 147)
        Me.txtFactura.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFactura.MaxLength = 10
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(140, 26)
        Me.txtFactura.TabIndex = 13
        Me.txtFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(5, 10)
        Me.lblCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(59, 26)
        Me.lblCliente.TabIndex = 0
        Me.lblCliente.Text = "Cliente"
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente"
        '
        'txtCliente
        '
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(160, 9)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(437, 26)
        Me.txtCliente.TabIndex = 1
        '
        'btnCerrar
        '
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Location = New System.Drawing.Point(53, -39)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(11, 31)
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
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.ToolStripSeparator1, Me.btnAceptar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(628, 27)
        Me.ToolStrip1.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 24)
        Me.btnCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'btnAceptar
        '
        Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAceptar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(85, 24)
        Me.btnAceptar.Text = "Aceptar"
        '
        'chkSap
        '
        Me.chkSap.AutoSize = True
        Me.chkSap.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkSap.Location = New System.Drawing.Point(315, 149)
        Me.chkSap.Name = "chkSap"
        Me.chkSap.Size = New System.Drawing.Size(133, 21)
        Me.chkSap.TabIndex = 23
        Me.chkSap.Text = "Documento SAP"
        Me.chkSap.UseVisualStyleBackColor = False
        '
        'frmOpcionFacturacionLibre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 346)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
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
    Friend WithEvents cboTipoDoc As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents txtOperacion As System.Windows.Forms.TextBox
    Friend WithEvents chkSap As System.Windows.Forms.CheckBox
End Class
