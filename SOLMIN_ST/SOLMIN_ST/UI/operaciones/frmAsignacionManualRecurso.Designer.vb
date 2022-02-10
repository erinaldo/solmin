<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignacionManualRecurso
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
        Me.lblConductor = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.hgReasignarRecurso = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtnro_viajes = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.cmbSegundoConductor = New Ransa.Controls.Transportista.ucConductorTransportista_TxtF01()
        Me.cmbConductor = New Ransa.Controls.Transportista.ucConductorTransportista_TxtF01()
        Me.cboAcoplado = New Ransa.Controls.Transportista.ucAcopladoTransportista_TxtF01()
        Me.cboTracto = New Ransa.Controls.Transportista.ucTractoTransportista_TxtF01()
        Me.cboTransportista = New Ransa.Controls.Transportista.ucTransportista_TxtF01()
        Me.lblSegundoConductor = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblAcoplado = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblTracto = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblTransportista = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtItemSolicitud = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtNroSolicitud = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblGuion_1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.beSeparador = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge()
        Me.lblSolicitud = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.tlsBarraHerramienta = New System.Windows.Forms.ToolStrip()
        Me.btnProcesar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        CType(Me.hgReasignarRecurso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgReasignarRecurso.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgReasignarRecurso.Panel.SuspendLayout()
        Me.hgReasignarRecurso.SuspendLayout()
        Me.tlsBarraHerramienta.SuspendLayout()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'lblConductor
        '
        Me.lblConductor.Location = New System.Drawing.Point(11, 188)
        Me.lblConductor.Margin = New System.Windows.Forms.Padding(4)
        Me.lblConductor.Name = "lblConductor"
        Me.lblConductor.Size = New System.Drawing.Size(118, 26)
        Me.lblConductor.TabIndex = 15
        Me.lblConductor.Text = "Conductor N° 1"
        Me.lblConductor.Values.ExtraText = ""
        Me.lblConductor.Values.Image = Nothing
        Me.lblConductor.Values.Text = "Conductor N° 1"
        '
        'hgReasignarRecurso
        '
        Me.hgReasignarRecurso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgReasignarRecurso.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.hgReasignarRecurso.HeaderVisiblePrimary = False
        Me.hgReasignarRecurso.Location = New System.Drawing.Point(0, 0)
        Me.hgReasignarRecurso.Margin = New System.Windows.Forms.Padding(4)
        Me.hgReasignarRecurso.Name = "hgReasignarRecurso"
        '
        'hgReasignarRecurso.Panel
        '
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.KryptonLabel4)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.txtnro_viajes)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.cmbSegundoConductor)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.cmbConductor)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.cboAcoplado)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.cboTracto)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.cboTransportista)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.lblSegundoConductor)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.lblConductor)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.lblAcoplado)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.lblTracto)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.lblTransportista)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.txtItemSolicitud)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.txtNroSolicitud)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.lblGuion_1)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.beSeparador)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.lblSolicitud)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.tlsBarraHerramienta)
        Me.hgReasignarRecurso.Size = New System.Drawing.Size(584, 340)
        Me.hgReasignarRecurso.TabIndex = 0
        Me.hgReasignarRecurso.Text = "    "
        Me.hgReasignarRecurso.ValuesPrimary.Description = ""
        Me.hgReasignarRecurso.ValuesPrimary.Heading = "    "
        Me.hgReasignarRecurso.ValuesPrimary.Image = Nothing
        Me.hgReasignarRecurso.ValuesSecondary.Description = ""
        Me.hgReasignarRecurso.ValuesSecondary.Heading = "     "
        Me.hgReasignarRecurso.ValuesSecondary.Image = Nothing
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(13, 254)
        Me.KryptonLabel4.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(85, 26)
        Me.KryptonLabel4.TabIndex = 164
        Me.KryptonLabel4.Text = "Nro Viajes:"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Nro Viajes:"
        '
        'txtnro_viajes
        '
        Me.txtnro_viajes.Location = New System.Drawing.Point(160, 254)
        Me.txtnro_viajes.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnro_viajes.Name = "txtnro_viajes"
        Me.txtnro_viajes.ReadOnly = True
        Me.txtnro_viajes.Size = New System.Drawing.Size(147, 26)
        Me.txtnro_viajes.TabIndex = 163
        '
        'cmbSegundoConductor
        '
        Me.cmbSegundoConductor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmbSegundoConductor.BackColor = System.Drawing.Color.Transparent
        Me.cmbSegundoConductor.Location = New System.Drawing.Point(160, 219)
        Me.cmbSegundoConductor.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbSegundoConductor.Name = "cmbSegundoConductor"
        Me.cmbSegundoConductor.pRequerido = False
        Me.cmbSegundoConductor.Size = New System.Drawing.Size(356, 26)
        Me.cmbSegundoConductor.TabIndex = 162
        '
        'cmbConductor
        '
        Me.cmbConductor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmbConductor.BackColor = System.Drawing.Color.Transparent
        Me.cmbConductor.Location = New System.Drawing.Point(160, 187)
        Me.cmbConductor.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbConductor.Name = "cmbConductor"
        Me.cmbConductor.pRequerido = False
        Me.cmbConductor.Size = New System.Drawing.Size(356, 26)
        Me.cmbConductor.TabIndex = 161
        '
        'cboAcoplado
        '
        Me.cboAcoplado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cboAcoplado.BackColor = System.Drawing.Color.Transparent
        Me.cboAcoplado.Location = New System.Drawing.Point(160, 154)
        Me.cboAcoplado.Margin = New System.Windows.Forms.Padding(5)
        Me.cboAcoplado.Name = "cboAcoplado"
        Me.cboAcoplado.pRequerido = False
        Me.cboAcoplado.Size = New System.Drawing.Size(356, 26)
        Me.cboAcoplado.TabIndex = 13
        '
        'cboTracto
        '
        Me.cboTracto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cboTracto.BackColor = System.Drawing.Color.Transparent
        Me.cboTracto.Location = New System.Drawing.Point(160, 118)
        Me.cboTracto.Margin = New System.Windows.Forms.Padding(5)
        Me.cboTracto.Name = "cboTracto"
        Me.cboTracto.pRequerido = False
        Me.cboTracto.Size = New System.Drawing.Size(356, 26)
        Me.cboTracto.TabIndex = 10
        '
        'cboTransportista
        '
        Me.cboTransportista.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cboTransportista.BackColor = System.Drawing.Color.Transparent
        Me.cboTransportista.Location = New System.Drawing.Point(160, 89)
        Me.cboTransportista.Margin = New System.Windows.Forms.Padding(5)
        Me.cboTransportista.Name = "cboTransportista"
        Me.cboTransportista.pNroRegPorPaginas = 0
        Me.cboTransportista.pRequerido = False
        Me.cboTransportista.Size = New System.Drawing.Size(356, 26)
        Me.cboTransportista.TabIndex = 7
        '
        'lblSegundoConductor
        '
        Me.lblSegundoConductor.Location = New System.Drawing.Point(11, 222)
        Me.lblSegundoConductor.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSegundoConductor.Name = "lblSegundoConductor"
        Me.lblSegundoConductor.Size = New System.Drawing.Size(118, 26)
        Me.lblSegundoConductor.TabIndex = 18
        Me.lblSegundoConductor.Text = "Conductor N° 2"
        Me.lblSegundoConductor.Values.ExtraText = ""
        Me.lblSegundoConductor.Values.Image = Nothing
        Me.lblSegundoConductor.Values.Text = "Conductor N° 2"
        '
        'lblAcoplado
        '
        Me.lblAcoplado.Location = New System.Drawing.Point(11, 158)
        Me.lblAcoplado.Margin = New System.Windows.Forms.Padding(4)
        Me.lblAcoplado.Name = "lblAcoplado"
        Me.lblAcoplado.Size = New System.Drawing.Size(76, 26)
        Me.lblAcoplado.TabIndex = 12
        Me.lblAcoplado.Text = "Acoplado"
        Me.lblAcoplado.Values.ExtraText = ""
        Me.lblAcoplado.Values.Image = Nothing
        Me.lblAcoplado.Values.Text = "Acoplado"
        '
        'lblTracto
        '
        Me.lblTracto.Location = New System.Drawing.Point(11, 121)
        Me.lblTracto.Margin = New System.Windows.Forms.Padding(4)
        Me.lblTracto.Name = "lblTracto"
        Me.lblTracto.Size = New System.Drawing.Size(54, 26)
        Me.lblTracto.TabIndex = 9
        Me.lblTracto.Text = "Tracto"
        Me.lblTracto.Values.ExtraText = ""
        Me.lblTracto.Values.Image = Nothing
        Me.lblTracto.Values.Text = "Tracto"
        '
        'lblTransportista
        '
        Me.lblTransportista.Location = New System.Drawing.Point(11, 89)
        Me.lblTransportista.Margin = New System.Windows.Forms.Padding(4)
        Me.lblTransportista.Name = "lblTransportista"
        Me.lblTransportista.Size = New System.Drawing.Size(100, 26)
        Me.lblTransportista.TabIndex = 6
        Me.lblTransportista.Text = "Transportista"
        Me.lblTransportista.Values.ExtraText = ""
        Me.lblTransportista.Values.Image = Nothing
        Me.lblTransportista.Values.Text = "Transportista"
        '
        'txtItemSolicitud
        '
        Me.txtItemSolicitud.Enabled = False
        Me.txtItemSolicitud.Location = New System.Drawing.Point(213, 44)
        Me.txtItemSolicitud.Margin = New System.Windows.Forms.Padding(4)
        Me.txtItemSolicitud.Name = "txtItemSolicitud"
        Me.txtItemSolicitud.Size = New System.Drawing.Size(53, 26)
        Me.txtItemSolicitud.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtItemSolicitud.StateDisabled.Border.Color1 = System.Drawing.Color.Blue
        Me.txtItemSolicitud.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtItemSolicitud.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtItemSolicitud.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtItemSolicitud.TabIndex = 4
        Me.txtItemSolicitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNroSolicitud
        '
        Me.txtNroSolicitud.Enabled = False
        Me.txtNroSolicitud.Location = New System.Drawing.Point(104, 44)
        Me.txtNroSolicitud.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroSolicitud.Name = "txtNroSolicitud"
        Me.txtNroSolicitud.Size = New System.Drawing.Size(85, 26)
        Me.txtNroSolicitud.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNroSolicitud.StateDisabled.Border.Color1 = System.Drawing.Color.Blue
        Me.txtNroSolicitud.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNroSolicitud.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtNroSolicitud.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtNroSolicitud.TabIndex = 2
        Me.txtNroSolicitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblGuion_1
        '
        Me.lblGuion_1.Location = New System.Drawing.Point(192, 46)
        Me.lblGuion_1.Margin = New System.Windows.Forms.Padding(4)
        Me.lblGuion_1.Name = "lblGuion_1"
        Me.lblGuion_1.Size = New System.Drawing.Size(18, 26)
        Me.lblGuion_1.TabIndex = 3
        Me.lblGuion_1.Text = "-"
        Me.lblGuion_1.Values.ExtraText = ""
        Me.lblGuion_1.Values.Image = Nothing
        Me.lblGuion_1.Values.Text = "-"
        '
        'beSeparador
        '
        Me.beSeparador.Location = New System.Drawing.Point(13, 79)
        Me.beSeparador.Margin = New System.Windows.Forms.Padding(4)
        Me.beSeparador.Name = "beSeparador"
        Me.beSeparador.Size = New System.Drawing.Size(547, 1)
        Me.beSeparador.TabIndex = 5
        Me.beSeparador.Text = "KryptonBorderEdge1"
        '
        'lblSolicitud
        '
        Me.lblSolicitud.Location = New System.Drawing.Point(8, 46)
        Me.lblSolicitud.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSolicitud.Name = "lblSolicitud"
        Me.lblSolicitud.Size = New System.Drawing.Size(92, 26)
        Me.lblSolicitud.TabIndex = 1
        Me.lblSolicitud.Text = "N° Solicitud"
        Me.lblSolicitud.Values.ExtraText = ""
        Me.lblSolicitud.Values.Image = Nothing
        Me.lblSolicitud.Values.Text = "N° Solicitud"
        '
        'tlsBarraHerramienta
        '
        Me.tlsBarraHerramienta.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.tlsBarraHerramienta.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tlsBarraHerramienta.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tlsBarraHerramienta.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnProcesar, Me.btnCancelar})
        Me.tlsBarraHerramienta.Location = New System.Drawing.Point(0, 0)
        Me.tlsBarraHerramienta.Name = "tlsBarraHerramienta"
        Me.tlsBarraHerramienta.Size = New System.Drawing.Size(582, 27)
        Me.tlsBarraHerramienta.TabIndex = 0
        Me.tlsBarraHerramienta.TabStop = True
        Me.tlsBarraHerramienta.Text = "ToolStrip1"
        '
        'btnProcesar
        '
        Me.btnProcesar.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnProcesar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(89, 24)
        Me.btnProcesar.Text = "Procesar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources._stop
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 24)
        Me.btnCancelar.Text = "Cancelar"
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.hgReasignarRecurso)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(584, 340)
        Me.KryptonPanel.TabIndex = 3
        '
        'frmAsignacionManualRecurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 340)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(727, 666)
        Me.MinimumSize = New System.Drawing.Size(581, 334)
        Me.Name = "frmAsignacionManualRecurso"
        Me.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignación Manual"
        CType(Me.hgReasignarRecurso.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgReasignarRecurso.Panel.ResumeLayout(False)
        Me.hgReasignarRecurso.Panel.PerformLayout()
        CType(Me.hgReasignarRecurso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgReasignarRecurso.ResumeLayout(False)
        Me.tlsBarraHerramienta.ResumeLayout(False)
        Me.tlsBarraHerramienta.PerformLayout()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager



    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents lblConductor As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents hgReasignarRecurso As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents lblAcoplado As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTracto As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTransportista As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtItemSolicitud As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtNroSolicitud As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblGuion_1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents beSeparador As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents lblSolicitud As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents tlsBarraHerramienta As System.Windows.Forms.ToolStrip
    Friend WithEvents btnProcesar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents lblSegundoConductor As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboTransportista As Ransa.Controls.Transportista.ucTransportista_TxtF01
    Friend WithEvents cboTracto As Ransa.Controls.Transportista.ucTractoTransportista_TxtF01
    Friend WithEvents cboAcoplado As Ransa.Controls.Transportista.ucAcopladoTransportista_TxtF01
    Friend WithEvents cmbSegundoConductor As Ransa.Controls.Transportista.ucConductorTransportista_TxtF01
    Friend WithEvents cmbConductor As Ransa.Controls.Transportista.ucConductorTransportista_TxtF01
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtnro_viajes As ComponentFactory.Krypton.Toolkit.KryptonTextBox
End Class
