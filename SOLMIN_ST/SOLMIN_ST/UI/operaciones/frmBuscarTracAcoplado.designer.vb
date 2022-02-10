<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarTracAcoplado
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
        Me.hgReasignarRecurso = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.cboArtefacto = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.cboEmpujador = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.cboAcoplado = New Ransa.Controls.Transportista.ucAcopladoTransportista_TxtF01()
        Me.cboTracto = New Ransa.Controls.Transportista.ucTractoTransportista_TxtF01()
        Me.cboTransportista = New Ransa.Controls.Transportista.ucTransportista_TxtF01()
        Me.lblAcoplado = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblTracto = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblTransportista = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.tlsBarraHerramienta = New System.Windows.Forms.ToolStrip()
        Me.btnProcesar = New System.Windows.Forms.ToolStripButton()
        Me.tlsSeparador = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
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
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.cboArtefacto)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.cboEmpujador)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.cboAcoplado)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.cboTracto)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.cboTransportista)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.lblAcoplado)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.lblTracto)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.lblTransportista)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.tlsBarraHerramienta)
        Me.hgReasignarRecurso.Size = New System.Drawing.Size(579, 286)
        Me.hgReasignarRecurso.TabIndex = 0
        Me.hgReasignarRecurso.Text = "    "
        Me.hgReasignarRecurso.ValuesPrimary.Description = ""
        Me.hgReasignarRecurso.ValuesPrimary.Heading = "    "
        Me.hgReasignarRecurso.ValuesPrimary.Image = Nothing
        Me.hgReasignarRecurso.ValuesSecondary.Description = ""
        Me.hgReasignarRecurso.ValuesSecondary.Heading = "     "
        Me.hgReasignarRecurso.ValuesSecondary.Image = Nothing
        '
        'cboArtefacto
        '
        Me.cboArtefacto.DropDownWidth = 267
        Me.cboArtefacto.FormattingEnabled = False
        Me.cboArtefacto.ItemHeight = 20
        Me.cboArtefacto.Location = New System.Drawing.Point(160, 121)
        Me.cboArtefacto.Margin = New System.Windows.Forms.Padding(4)
        Me.cboArtefacto.Name = "cboArtefacto"
        Me.cboArtefacto.Size = New System.Drawing.Size(356, 28)
        Me.cboArtefacto.TabIndex = 158
        Me.cboArtefacto.Visible = False
        '
        'cboEmpujador
        '
        Me.cboEmpujador.DropDownWidth = 267
        Me.cboEmpujador.FormattingEnabled = False
        Me.cboEmpujador.ItemHeight = 20
        Me.cboEmpujador.Location = New System.Drawing.Point(160, 81)
        Me.cboEmpujador.Margin = New System.Windows.Forms.Padding(4)
        Me.cboEmpujador.MaxDropDownItems = 100
        Me.cboEmpujador.Name = "cboEmpujador"
        Me.cboEmpujador.Size = New System.Drawing.Size(356, 28)
        Me.cboEmpujador.TabIndex = 157
        Me.cboEmpujador.Visible = False
        '
        'cboAcoplado
        '
        Me.cboAcoplado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cboAcoplado.BackColor = System.Drawing.Color.Transparent
        Me.cboAcoplado.Location = New System.Drawing.Point(160, 122)
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
        Me.cboTracto.Location = New System.Drawing.Point(160, 81)
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
        Me.cboTransportista.Location = New System.Drawing.Point(160, 42)
        Me.cboTransportista.Margin = New System.Windows.Forms.Padding(5)
        Me.cboTransportista.Name = "cboTransportista"
        Me.cboTransportista.pNroRegPorPaginas = 0
        Me.cboTransportista.pRequerido = False
        Me.cboTransportista.Size = New System.Drawing.Size(356, 26)
        Me.cboTransportista.TabIndex = 7
        '
        'lblAcoplado
        '
        Me.lblAcoplado.Location = New System.Drawing.Point(15, 121)
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
        Me.lblTracto.Location = New System.Drawing.Point(11, 81)
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
        Me.lblTransportista.Location = New System.Drawing.Point(4, 42)
        Me.lblTransportista.Margin = New System.Windows.Forms.Padding(4)
        Me.lblTransportista.Name = "lblTransportista"
        Me.lblTransportista.Size = New System.Drawing.Size(100, 26)
        Me.lblTransportista.TabIndex = 6
        Me.lblTransportista.Text = "Transportista"
        Me.lblTransportista.Values.ExtraText = ""
        Me.lblTransportista.Values.Image = Nothing
        Me.lblTransportista.Values.Text = "Transportista"
        '
        'tlsBarraHerramienta
        '
        Me.tlsBarraHerramienta.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.tlsBarraHerramienta.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tlsBarraHerramienta.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tlsBarraHerramienta.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnProcesar, Me.tlsSeparador, Me.btnCancelar, Me.ToolStripSeparator1})
        Me.tlsBarraHerramienta.Location = New System.Drawing.Point(0, 0)
        Me.tlsBarraHerramienta.Name = "tlsBarraHerramienta"
        Me.tlsBarraHerramienta.Size = New System.Drawing.Size(577, 27)
        Me.tlsBarraHerramienta.TabIndex = 0
        Me.tlsBarraHerramienta.TabStop = True
        Me.tlsBarraHerramienta.Text = "ToolStrip1"
        '
        'btnProcesar
        '
        Me.btnProcesar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok
        Me.btnProcesar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(85, 24)
        Me.btnProcesar.Text = "Aceptar"
        '
        'tlsSeparador
        '
        Me.tlsSeparador.Name = "tlsSeparador"
        Me.tlsSeparador.Size = New System.Drawing.Size(6, 27)
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources._stop
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 24)
        Me.btnCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.hgReasignarRecurso)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(579, 286)
        Me.KryptonPanel.TabIndex = 3
        '
        'frmBuscarTracAcoplado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 286)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(726, 664)
        Me.MinimumSize = New System.Drawing.Size(581, 333)
        Me.Name = "frmBuscarTracAcoplado"
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
    Friend WithEvents hgReasignarRecurso As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents lblAcoplado As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTracto As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTransportista As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents tlsBarraHerramienta As System.Windows.Forms.ToolStrip
    Friend WithEvents btnProcesar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlsSeparador As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents cboTransportista As Ransa.Controls.Transportista.ucTransportista_TxtF01
    Friend WithEvents cboTracto As Ransa.Controls.Transportista.ucTractoTransportista_TxtF01
    Friend WithEvents cboAcoplado As Ransa.Controls.Transportista.ucAcopladoTransportista_TxtF01
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cboArtefacto As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents cboEmpujador As ComponentFactory.Krypton.Toolkit.KryptonComboBox
End Class
