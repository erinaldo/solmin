<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnviarValorizacion
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
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.HGFiltro = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.txtaprobador = New System.Windows.Forms.TextBox()
        Me.txtdocseg = New System.Windows.Forms.TextBox()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtEnvio = New System.Windows.Forms.TextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtHoraEnvio = New System.Windows.Forms.MaskedTextBox()
        Me.dtpFechaEnvio = New System.Windows.Forms.DateTimePicker()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.lblObservacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblAprobador = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblDestino = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cboAreaDestino = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.cboAprobadores = New Ransa.Utilitario.ucAyuda()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.lblDiasAprob = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblSoles = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.TypeValidator1 = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.HGFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HGFiltro.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HGFiltro.Panel.SuspendLayout()
        Me.HGFiltro.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.HGFiltro)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.SeparatorLowProfile
        Me.KryptonPanel.Size = New System.Drawing.Size(701, 280)
        Me.KryptonPanel.TabIndex = 0
        '
        'HGFiltro
        '
        Me.HGFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.HGFiltro.HeaderVisibleSecondary = False
        Me.HGFiltro.Location = New System.Drawing.Point(0, 0)
        Me.HGFiltro.Margin = New System.Windows.Forms.Padding(4)
        Me.HGFiltro.Name = "HGFiltro"
        '
        'HGFiltro.Panel
        '
        Me.HGFiltro.Panel.Controls.Add(Me.txtaprobador)
        Me.HGFiltro.Panel.Controls.Add(Me.txtdocseg)
        Me.HGFiltro.Panel.Controls.Add(Me.KryptonLabel2)
        Me.HGFiltro.Panel.Controls.Add(Me.txtEnvio)
        Me.HGFiltro.Panel.Controls.Add(Me.KryptonLabel1)
        Me.HGFiltro.Panel.Controls.Add(Me.txtHoraEnvio)
        Me.HGFiltro.Panel.Controls.Add(Me.dtpFechaEnvio)
        Me.HGFiltro.Panel.Controls.Add(Me.txtObservacion)
        Me.HGFiltro.Panel.Controls.Add(Me.lblObservacion)
        Me.HGFiltro.Panel.Controls.Add(Me.lblAprobador)
        Me.HGFiltro.Panel.Controls.Add(Me.lblDestino)
        Me.HGFiltro.Panel.Controls.Add(Me.cboAreaDestino)
        Me.HGFiltro.Panel.Controls.Add(Me.cboAprobadores)
        Me.HGFiltro.Panel.Controls.Add(Me.ToolStrip1)
        Me.HGFiltro.Panel.Controls.Add(Me.lblDiasAprob)
        Me.HGFiltro.Panel.Controls.Add(Me.lblSoles)
        Me.HGFiltro.Size = New System.Drawing.Size(701, 308)
        Me.HGFiltro.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HGFiltro.TabIndex = 2
        Me.HGFiltro.ValuesPrimary.Description = ""
        Me.HGFiltro.ValuesPrimary.Heading = ""
        Me.HGFiltro.ValuesPrimary.Image = Nothing
        Me.HGFiltro.ValuesSecondary.Description = ""
        Me.HGFiltro.ValuesSecondary.Heading = "Description"
        Me.HGFiltro.ValuesSecondary.Image = Nothing
        '
        'txtaprobador
        '
        Me.txtaprobador.BackColor = System.Drawing.SystemColors.Window
        Me.txtaprobador.Enabled = False
        Me.txtaprobador.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtaprobador.Location = New System.Drawing.Point(140, 131)
        Me.txtaprobador.Margin = New System.Windows.Forms.Padding(4)
        Me.txtaprobador.MaxLength = 1000
        Me.txtaprobador.Name = "txtaprobador"
        Me.txtaprobador.Size = New System.Drawing.Size(311, 22)
        Me.txtaprobador.TabIndex = 15
        '
        'txtdocseg
        '
        Me.txtdocseg.BackColor = System.Drawing.SystemColors.Window
        Me.txtdocseg.Enabled = False
        Me.txtdocseg.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtdocseg.Location = New System.Drawing.Point(140, 35)
        Me.txtdocseg.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdocseg.MaxLength = 1000
        Me.txtdocseg.Name = "txtdocseg"
        Me.txtdocseg.Size = New System.Drawing.Size(129, 22)
        Me.txtdocseg.TabIndex = 14
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(14, 37)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(124, 24)
        Me.KryptonLabel2.TabIndex = 13
        Me.KryptonLabel2.Text = "Nro. Doc. Envío :"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Nro. Doc. Envío :"
        '
        'txtEnvio
        '
        Me.txtEnvio.BackColor = System.Drawing.SystemColors.Window
        Me.txtEnvio.Enabled = False
        Me.txtEnvio.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtEnvio.Location = New System.Drawing.Point(376, 37)
        Me.txtEnvio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEnvio.MaxLength = 1000
        Me.txtEnvio.Name = "txtEnvio"
        Me.txtEnvio.Size = New System.Drawing.Size(90, 22)
        Me.txtEnvio.TabIndex = 8
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(316, 37)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(52, 24)
        Me.KryptonLabel1.TabIndex = 7
        Me.KryptonLabel1.Text = "Envío:"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Envío:"
        '
        'txtHoraEnvio
        '
        Me.txtHoraEnvio.Location = New System.Drawing.Point(378, 67)
        Me.txtHoraEnvio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHoraEnvio.Mask = "00:00"
        Me.txtHoraEnvio.Name = "txtHoraEnvio"
        Me.txtHoraEnvio.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txtHoraEnvio.Size = New System.Drawing.Size(88, 22)
        Me.txtHoraEnvio.TabIndex = 12
        Me.txtHoraEnvio.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'dtpFechaEnvio
        '
        Me.dtpFechaEnvio.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaEnvio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaEnvio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEnvio.Location = New System.Drawing.Point(140, 65)
        Me.dtpFechaEnvio.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaEnvio.Name = "dtpFechaEnvio"
        Me.dtpFechaEnvio.Size = New System.Drawing.Size(129, 24)
        Me.dtpFechaEnvio.TabIndex = 10
        '
        'txtObservacion
        '
        Me.txtObservacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservacion.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtObservacion.Location = New System.Drawing.Point(140, 162)
        Me.txtObservacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObservacion.MaxLength = 70
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(553, 59)
        Me.txtObservacion.TabIndex = 5
        '
        'lblObservacion
        '
        Me.lblObservacion.Location = New System.Drawing.Point(13, 168)
        Me.lblObservacion.Margin = New System.Windows.Forms.Padding(4)
        Me.lblObservacion.Name = "lblObservacion"
        Me.lblObservacion.Size = New System.Drawing.Size(104, 24)
        Me.lblObservacion.TabIndex = 4
        Me.lblObservacion.Text = "Observación :"
        Me.lblObservacion.Values.ExtraText = ""
        Me.lblObservacion.Values.Image = Nothing
        Me.lblObservacion.Values.Text = "Observación :"
        '
        'lblAprobador
        '
        Me.lblAprobador.Location = New System.Drawing.Point(13, 132)
        Me.lblAprobador.Margin = New System.Windows.Forms.Padding(4)
        Me.lblAprobador.Name = "lblAprobador"
        Me.lblAprobador.Size = New System.Drawing.Size(93, 24)
        Me.lblAprobador.TabIndex = 2
        Me.lblAprobador.Text = "Aprobador :"
        Me.lblAprobador.Values.ExtraText = ""
        Me.lblAprobador.Values.Image = Nothing
        Me.lblAprobador.Values.Text = "Aprobador :"
        '
        'lblDestino
        '
        Me.lblDestino.Location = New System.Drawing.Point(13, 99)
        Me.lblDestino.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDestino.Name = "lblDestino"
        Me.lblDestino.Size = New System.Drawing.Size(71, 24)
        Me.lblDestino.TabIndex = 0
        Me.lblDestino.Text = "Destino :"
        Me.lblDestino.Values.ExtraText = ""
        Me.lblDestino.Values.Image = Nothing
        Me.lblDestino.Values.Text = "Destino :"
        '
        'cboAreaDestino
        '
        Me.cboAreaDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAreaDestino.DropDownWidth = 162
        Me.cboAreaDestino.FormattingEnabled = False
        Me.cboAreaDestino.ItemHeight = 20
        Me.cboAreaDestino.Location = New System.Drawing.Point(140, 97)
        Me.cboAreaDestino.Margin = New System.Windows.Forms.Padding(4)
        Me.cboAreaDestino.Name = "cboAreaDestino"
        Me.cboAreaDestino.Size = New System.Drawing.Size(344, 28)
        Me.cboAreaDestino.TabIndex = 1
        '
        'cboAprobadores
        '
        Me.cboAprobadores.BackColor = System.Drawing.Color.Transparent
        Me.cboAprobadores.DataSource = Nothing
        Me.cboAprobadores.DispleyMember = ""
        Me.cboAprobadores.Etiquetas_Form = Nothing
        Me.cboAprobadores.ListColumnas = Nothing
        Me.cboAprobadores.Location = New System.Drawing.Point(451, 131)
        Me.cboAprobadores.Margin = New System.Windows.Forms.Padding(5)
        Me.cboAprobadores.Name = "cboAprobadores"
        Me.cboAprobadores.Obligatorio = True
        Me.cboAprobadores.PopupHeight = 0
        Me.cboAprobadores.PopupWidth = 0
        Me.cboAprobadores.Size = New System.Drawing.Size(33, 23)
        Me.cboAprobadores.SizeFont = 0
        Me.cboAprobadores.TabIndex = 3
        Me.cboAprobadores.ValueMember = ""
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnCancelar, Me.btnGuardar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(699, 27)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.SOLMIN_CT.My.Resources.Resources.button_ok
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(116, 24)
        Me.btnNuevo.Text = "Nuevo Envío"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_CT.My.Resources.Resources.anular1
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 24)
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGuardar.Image = Global.SOLMIN_CT.My.Resources.Resources.save_all
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(86, 24)
        Me.btnGuardar.Text = "Guardar"
        '
        'lblDiasAprob
        '
        Me.lblDiasAprob.Location = New System.Drawing.Point(277, 65)
        Me.lblDiasAprob.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDiasAprob.Name = "lblDiasAprob"
        Me.lblDiasAprob.Size = New System.Drawing.Size(93, 24)
        Me.lblDiasAprob.TabIndex = 11
        Me.lblDiasAprob.Text = "Hora Envío :"
        Me.lblDiasAprob.Values.ExtraText = ""
        Me.lblDiasAprob.Values.Image = Nothing
        Me.lblDiasAprob.Values.Text = "Hora Envío :"
        '
        'lblSoles
        '
        Me.lblSoles.Location = New System.Drawing.Point(13, 65)
        Me.lblSoles.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSoles.Name = "lblSoles"
        Me.lblSoles.Size = New System.Drawing.Size(95, 24)
        Me.lblSoles.TabIndex = 9
        Me.lblSoles.Text = "Fecha Envío:"
        Me.lblSoles.Values.ExtraText = ""
        Me.lblSoles.Values.Image = Nothing
        Me.lblSoles.Values.Text = "Fecha Envío:"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Division"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Planta"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Operacion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Pre-Factura"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Pre-Liquidacion"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Nro. Consistencia"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Importe S/"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Importe U$"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Estado OP"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'frmEnviarValorizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 280)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmEnviarValorizacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Enviar Valorización"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.HGFiltro.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGFiltro.Panel.ResumeLayout(False)
        Me.HGFiltro.Panel.PerformLayout()
        CType(Me.HGFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGFiltro.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents TypeValidator1 As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents cboDivision As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HGFiltro As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblDiasAprob As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblSoles As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cboAprobadores As Ransa.Utilitario.ucAyuda
    Friend WithEvents cboAreaDestino As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents lblObservacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblAprobador As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblDestino As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaEnvio As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtHoraEnvio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtEnvio As System.Windows.Forms.TextBox
    Friend WithEvents txtdocseg As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtaprobador As System.Windows.Forms.TextBox
End Class
