<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReasignarRecurso
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
        Me.lblAcoplado = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.tlsSeparador = New System.Windows.Forms.ToolStripSeparator()
        Me.btnProcesar = New System.Windows.Forms.ToolStripButton()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.hgReasignarRecurso = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.cmbSegundoConductor = New Ransa.Controls.Transportista.ucConductor_TxtF01()
        Me.cmbConductor = New Ransa.Controls.Transportista.ucConductor_TxtF01()
        Me.ctbAcoplado = New Ransa.Controls.Transportista.ucAcopladoTransportista_TxtF01()
        Me.ctbTracto = New Ransa.Controls.Transportista.ucTractoTransportista_TxtF01()
        Me.ctbTransportista = New Ransa.Controls.Transportista.ucTransportista_TxtF01()
        Me.lblSegundoConductor = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblConductor = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtItemJunta = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblGuion_0 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtJunta = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblJunta = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblTracto = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblTransportista = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtItemSolicitud = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtNroSolicitud = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblGuion_1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.beSeparador = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge()
        Me.lblSolicitud = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.tlsBarraHerramienta = New System.Windows.Forms.ToolStrip()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.hgReasignarRecurso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgReasignarRecurso.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgReasignarRecurso.Panel.SuspendLayout()
        Me.hgReasignarRecurso.SuspendLayout()
        Me.tlsBarraHerramienta.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'lblAcoplado
        '
        Me.lblAcoplado.Location = New System.Drawing.Point(8, 136)
        Me.lblAcoplado.Name = "lblAcoplado"
        Me.lblAcoplado.Size = New System.Drawing.Size(76, 26)
        Me.lblAcoplado.TabIndex = 113
        Me.lblAcoplado.Text = "Acoplado"
        Me.lblAcoplado.Values.ExtraText = ""
        Me.lblAcoplado.Values.Image = Nothing
        Me.lblAcoplado.Values.Text = "Acoplado"
        '
        'tlsSeparador
        '
        Me.tlsSeparador.Name = "tlsSeparador"
        Me.tlsSeparador.Size = New System.Drawing.Size(6, 27)
        '
        'btnProcesar
        '
        Me.btnProcesar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnProcesar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(89, 24)
        Me.btnProcesar.Text = "Procesar"
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.hgReasignarRecurso)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(593, 270)
        Me.KryptonPanel.TabIndex = 2
        '
        'hgReasignarRecurso
        '
        Me.hgReasignarRecurso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgReasignarRecurso.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.hgReasignarRecurso.HeaderVisiblePrimary = False
        Me.hgReasignarRecurso.Location = New System.Drawing.Point(0, 0)
        Me.hgReasignarRecurso.Name = "hgReasignarRecurso"
        '
        'hgReasignarRecurso.Panel
        '
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.cmbSegundoConductor)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.cmbConductor)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.ctbAcoplado)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.ctbTracto)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.ctbTransportista)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.lblSegundoConductor)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.lblConductor)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.txtItemJunta)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.lblGuion_0)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.txtJunta)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.lblJunta)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.lblAcoplado)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.lblTracto)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.lblTransportista)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.txtItemSolicitud)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.txtNroSolicitud)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.lblGuion_1)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.beSeparador)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.lblSolicitud)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.tlsBarraHerramienta)
        Me.hgReasignarRecurso.Size = New System.Drawing.Size(593, 270)
        Me.hgReasignarRecurso.TabIndex = 0
        Me.hgReasignarRecurso.Text = "    "
        Me.hgReasignarRecurso.ValuesPrimary.Description = ""
        Me.hgReasignarRecurso.ValuesPrimary.Heading = "    "
        Me.hgReasignarRecurso.ValuesPrimary.Image = Nothing
        Me.hgReasignarRecurso.ValuesSecondary.Description = ""
        Me.hgReasignarRecurso.ValuesSecondary.Heading = "     "
        Me.hgReasignarRecurso.ValuesSecondary.Image = Nothing
        '
        'cmbSegundoConductor
        '
        Me.cmbSegundoConductor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmbSegundoConductor.BackColor = System.Drawing.Color.Transparent
        Me.cmbSegundoConductor.Location = New System.Drawing.Point(154, 190)
        Me.cmbSegundoConductor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbSegundoConductor.Name = "cmbSegundoConductor"
        Me.cmbSegundoConductor.pRequerido = False
        Me.cmbSegundoConductor.Size = New System.Drawing.Size(378, 26)
        Me.cmbSegundoConductor.TabIndex = 158
        '
        'cmbConductor
        '
        Me.cmbConductor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmbConductor.BackColor = System.Drawing.Color.Transparent
        Me.cmbConductor.Location = New System.Drawing.Point(154, 163)
        Me.cmbConductor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbConductor.Name = "cmbConductor"
        Me.cmbConductor.pRequerido = False
        Me.cmbConductor.Size = New System.Drawing.Size(378, 26)
        Me.cmbConductor.TabIndex = 157
        '
        'ctbAcoplado
        '
        Me.ctbAcoplado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ctbAcoplado.BackColor = System.Drawing.Color.Transparent
        Me.ctbAcoplado.Location = New System.Drawing.Point(154, 133)
        Me.ctbAcoplado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ctbAcoplado.Name = "ctbAcoplado"
        Me.ctbAcoplado.pRequerido = False
        Me.ctbAcoplado.Size = New System.Drawing.Size(271, 26)
        Me.ctbAcoplado.TabIndex = 125
        '
        'ctbTracto
        '
        Me.ctbTracto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ctbTracto.BackColor = System.Drawing.Color.Transparent
        Me.ctbTracto.Location = New System.Drawing.Point(154, 108)
        Me.ctbTracto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ctbTracto.Name = "ctbTracto"
        Me.ctbTracto.pRequerido = False
        Me.ctbTracto.Size = New System.Drawing.Size(271, 26)
        Me.ctbTracto.TabIndex = 124
        '
        'ctbTransportista
        '
        Me.ctbTransportista.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ctbTransportista.BackColor = System.Drawing.Color.Transparent
        Me.ctbTransportista.Location = New System.Drawing.Point(155, 77)
        Me.ctbTransportista.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ctbTransportista.Name = "ctbTransportista"
        Me.ctbTransportista.pNroRegPorPaginas = 0
        Me.ctbTransportista.pRequerido = False
        Me.ctbTransportista.Size = New System.Drawing.Size(377, 26)
        Me.ctbTransportista.TabIndex = 123
        '
        'lblSegundoConductor
        '
        Me.lblSegundoConductor.Location = New System.Drawing.Point(8, 189)
        Me.lblSegundoConductor.Name = "lblSegundoConductor"
        Me.lblSegundoConductor.Size = New System.Drawing.Size(118, 26)
        Me.lblSegundoConductor.TabIndex = 118
        Me.lblSegundoConductor.Text = "Conductor N° 2"
        Me.lblSegundoConductor.Values.ExtraText = ""
        Me.lblSegundoConductor.Values.Image = Nothing
        Me.lblSegundoConductor.Values.Text = "Conductor N° 2"
        '
        'lblConductor
        '
        Me.lblConductor.Location = New System.Drawing.Point(8, 163)
        Me.lblConductor.Name = "lblConductor"
        Me.lblConductor.Size = New System.Drawing.Size(118, 26)
        Me.lblConductor.TabIndex = 118
        Me.lblConductor.Text = "Conductor N° 1"
        Me.lblConductor.Values.ExtraText = ""
        Me.lblConductor.Values.Image = Nothing
        Me.lblConductor.Values.Text = "Conductor N° 1"
        '
        'txtItemJunta
        '
        Me.txtItemJunta.Enabled = False
        Me.txtItemJunta.Location = New System.Drawing.Point(250, 34)
        Me.txtItemJunta.Name = "txtItemJunta"
        Me.txtItemJunta.Size = New System.Drawing.Size(40, 26)
        Me.txtItemJunta.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtItemJunta.StateDisabled.Border.Color1 = System.Drawing.Color.Blue
        Me.txtItemJunta.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtItemJunta.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtItemJunta.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtItemJunta.TabIndex = 117
        Me.txtItemJunta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblGuion_0
        '
        Me.lblGuion_0.Location = New System.Drawing.Point(227, 37)
        Me.lblGuion_0.Name = "lblGuion_0"
        Me.lblGuion_0.Size = New System.Drawing.Size(18, 26)
        Me.lblGuion_0.TabIndex = 116
        Me.lblGuion_0.Text = "-"
        Me.lblGuion_0.Values.ExtraText = ""
        Me.lblGuion_0.Values.Image = Nothing
        Me.lblGuion_0.Values.Text = "-"
        '
        'txtJunta
        '
        Me.txtJunta.Enabled = False
        Me.txtJunta.Location = New System.Drawing.Point(159, 34)
        Me.txtJunta.Name = "txtJunta"
        Me.txtJunta.Size = New System.Drawing.Size(64, 26)
        Me.txtJunta.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtJunta.StateDisabled.Border.Color1 = System.Drawing.Color.Blue
        Me.txtJunta.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtJunta.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtJunta.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtJunta.TabIndex = 115
        Me.txtJunta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblJunta
        '
        Me.lblJunta.Location = New System.Drawing.Point(5, 37)
        Me.lblJunta.Name = "lblJunta"
        Me.lblJunta.Size = New System.Drawing.Size(147, 26)
        Me.lblJunta.TabIndex = 114
        Me.lblJunta.Text = "N° Junta Transporte"
        Me.lblJunta.Values.ExtraText = ""
        Me.lblJunta.Values.Image = Nothing
        Me.lblJunta.Values.Text = "N° Junta Transporte"
        '
        'lblTracto
        '
        Me.lblTracto.Location = New System.Drawing.Point(8, 109)
        Me.lblTracto.Name = "lblTracto"
        Me.lblTracto.Size = New System.Drawing.Size(54, 26)
        Me.lblTracto.TabIndex = 14
        Me.lblTracto.Text = "Tracto"
        Me.lblTracto.Values.ExtraText = ""
        Me.lblTracto.Values.Image = Nothing
        Me.lblTracto.Values.Text = "Tracto"
        '
        'lblTransportista
        '
        Me.lblTransportista.Location = New System.Drawing.Point(8, 77)
        Me.lblTransportista.Name = "lblTransportista"
        Me.lblTransportista.Size = New System.Drawing.Size(129, 26)
        Me.lblTransportista.TabIndex = 13
        Me.lblTransportista.Text = "Cia. Transportista"
        Me.lblTransportista.Values.ExtraText = ""
        Me.lblTransportista.Values.Image = Nothing
        Me.lblTransportista.Values.Text = "Cia. Transportista"
        '
        'txtItemSolicitud
        '
        Me.txtItemSolicitud.Enabled = False
        Me.txtItemSolicitud.Location = New System.Drawing.Point(492, 34)
        Me.txtItemSolicitud.Name = "txtItemSolicitud"
        Me.txtItemSolicitud.Size = New System.Drawing.Size(40, 26)
        Me.txtItemSolicitud.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtItemSolicitud.StateDisabled.Border.Color1 = System.Drawing.Color.Blue
        Me.txtItemSolicitud.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtItemSolicitud.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtItemSolicitud.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtItemSolicitud.TabIndex = 12
        Me.txtItemSolicitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNroSolicitud
        '
        Me.txtNroSolicitud.Enabled = False
        Me.txtNroSolicitud.Location = New System.Drawing.Point(410, 34)
        Me.txtNroSolicitud.Name = "txtNroSolicitud"
        Me.txtNroSolicitud.Size = New System.Drawing.Size(76, 26)
        Me.txtNroSolicitud.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNroSolicitud.StateDisabled.Border.Color1 = System.Drawing.Color.Blue
        Me.txtNroSolicitud.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNroSolicitud.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtNroSolicitud.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtNroSolicitud.TabIndex = 11
        Me.txtNroSolicitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblGuion_1
        '
        Me.lblGuion_1.Location = New System.Drawing.Point(421, 37)
        Me.lblGuion_1.Name = "lblGuion_1"
        Me.lblGuion_1.Size = New System.Drawing.Size(18, 26)
        Me.lblGuion_1.TabIndex = 9
        Me.lblGuion_1.Text = "-"
        Me.lblGuion_1.Values.ExtraText = ""
        Me.lblGuion_1.Values.Image = Nothing
        Me.lblGuion_1.Values.Text = "-"
        '
        'beSeparador
        '
        Me.beSeparador.Location = New System.Drawing.Point(10, 64)
        Me.beSeparador.Name = "beSeparador"
        Me.beSeparador.Size = New System.Drawing.Size(450, 1)
        Me.beSeparador.TabIndex = 8
        Me.beSeparador.Text = "KryptonBorderEdge1"
        '
        'lblSolicitud
        '
        Me.lblSolicitud.Location = New System.Drawing.Point(314, 35)
        Me.lblSolicitud.Name = "lblSolicitud"
        Me.lblSolicitud.Size = New System.Drawing.Size(92, 26)
        Me.lblSolicitud.TabIndex = 6
        Me.lblSolicitud.Text = "N° Solicitud"
        Me.lblSolicitud.Values.ExtraText = ""
        Me.lblSolicitud.Values.Image = Nothing
        Me.lblSolicitud.Values.Text = "N° Solicitud"
        '
        'tlsBarraHerramienta
        '
        Me.tlsBarraHerramienta.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.tlsBarraHerramienta.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tlsBarraHerramienta.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnProcesar, Me.tlsSeparador, Me.btnCancelar})
        Me.tlsBarraHerramienta.Location = New System.Drawing.Point(0, 0)
        Me.tlsBarraHerramienta.Name = "tlsBarraHerramienta"
        Me.tlsBarraHerramienta.Size = New System.Drawing.Size(591, 27)
        Me.tlsBarraHerramienta.TabIndex = 7
        Me.tlsBarraHerramienta.TabStop = True
        Me.tlsBarraHerramienta.Text = "ToolStrip1"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources._stop
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 24)
        Me.btnCancelar.Text = "Cancelar"
        '
        'frmReasignarRecurso
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(593, 270)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmReasignarRecurso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reasignación de  Recursos"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.hgReasignarRecurso.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgReasignarRecurso.Panel.ResumeLayout(False)
        Me.hgReasignarRecurso.Panel.PerformLayout()
        CType(Me.hgReasignarRecurso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgReasignarRecurso.ResumeLayout(False)
        Me.tlsBarraHerramienta.ResumeLayout(False)
        Me.tlsBarraHerramienta.PerformLayout()
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
    Friend WithEvents lblAcoplado As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents tlsSeparador As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnProcesar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents hgReasignarRecurso As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents lblTracto As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTransportista As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtItemSolicitud As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtNroSolicitud As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblGuion_1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents beSeparador As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents lblSolicitud As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents tlsBarraHerramienta As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtJunta As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblJunta As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtItemJunta As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblGuion_0 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblConductor As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblSegundoConductor As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ctbTransportista As Ransa.Controls.Transportista.ucTransportista_TxtF01
    Friend WithEvents ctbTracto As Ransa.Controls.Transportista.ucTractoTransportista_TxtF01
    Friend WithEvents ctbAcoplado As Ransa.Controls.Transportista.ucAcopladoTransportista_TxtF01
    Friend WithEvents cmbSegundoConductor As Ransa.Controls.Transportista.ucConductor_TxtF01
    Friend WithEvents cmbConductor As Ransa.Controls.Transportista.ucConductor_TxtF01
End Class
