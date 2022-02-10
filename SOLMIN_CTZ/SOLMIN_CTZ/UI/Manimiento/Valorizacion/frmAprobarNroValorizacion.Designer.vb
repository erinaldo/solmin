<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAprobarNroValorizacion
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
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cboEstado = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.txtHoraAprobacion = New System.Windows.Forms.MaskedTextBox()
        Me.dtpFechaAprobacion = New System.Windows.Forms.DateTimePicker()
        Me.txtObservacionAprobacion = New System.Windows.Forms.TextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.HGFiltro = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.txtAprobador = New System.Windows.Forms.TextBox()
        Me.txtDestino = New System.Windows.Forms.TextBox()
        Me.lblAprobador = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblDestino = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnAnularAprob = New System.Windows.Forms.ToolStripButton()
        Me.txtHoraEnvio = New System.Windows.Forms.TextBox()
        Me.lblDiasAprob = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblSoles = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtFechaEnvio = New System.Windows.Forms.TextBox()
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
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel.Controls.Add(Me.cboEstado)
        Me.KryptonPanel.Controls.Add(Me.txtHoraAprobacion)
        Me.KryptonPanel.Controls.Add(Me.dtpFechaAprobacion)
        Me.KryptonPanel.Controls.Add(Me.txtObservacionAprobacion)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel.Controls.Add(Me.HGFiltro)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonStandalone
        Me.KryptonPanel.Size = New System.Drawing.Size(700, 304)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(5, 138)
        Me.KryptonLabel4.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(65, 24)
        Me.KryptonLabel4.TabIndex = 105
        Me.KryptonLabel4.Text = "Estado :"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Estado :"
        '
        'cboEstado
        '
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.DropDownWidth = 162
        Me.cboEstado.FormattingEnabled = False
        Me.cboEstado.ItemHeight = 20
        Me.cboEstado.Location = New System.Drawing.Point(174, 136)
        Me.cboEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(221, 28)
        Me.cboEstado.TabIndex = 0
        '
        'txtHoraAprobacion
        '
        Me.txtHoraAprobacion.Location = New System.Drawing.Point(390, 174)
        Me.txtHoraAprobacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHoraAprobacion.Mask = "00:00"
        Me.txtHoraAprobacion.Name = "txtHoraAprobacion"
        Me.txtHoraAprobacion.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txtHoraAprobacion.Size = New System.Drawing.Size(88, 22)
        Me.txtHoraAprobacion.TabIndex = 2
        Me.txtHoraAprobacion.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'dtpFechaAprobacion
        '
        Me.dtpFechaAprobacion.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaAprobacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaAprobacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAprobacion.Location = New System.Drawing.Point(174, 172)
        Me.dtpFechaAprobacion.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaAprobacion.Name = "dtpFechaAprobacion"
        Me.dtpFechaAprobacion.Size = New System.Drawing.Size(105, 24)
        Me.dtpFechaAprobacion.TabIndex = 1
        '
        'txtObservacionAprobacion
        '
        Me.txtObservacionAprobacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservacionAprobacion.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtObservacionAprobacion.Location = New System.Drawing.Point(174, 204)
        Me.txtObservacionAprobacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObservacionAprobacion.MaxLength = 70
        Me.txtObservacionAprobacion.Multiline = True
        Me.txtObservacionAprobacion.Name = "txtObservacionAprobacion"
        Me.txtObservacionAprobacion.Size = New System.Drawing.Size(497, 75)
        Me.txtObservacionAprobacion.TabIndex = 3
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(4, 204)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(151, 24)
        Me.KryptonLabel1.TabIndex = 100
        Me.KryptonLabel1.Text = "Observ Aprobación :"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Observ Aprobación :"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(283, 172)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(99, 24)
        Me.KryptonLabel2.TabIndex = 98
        Me.KryptonLabel2.Text = "Hora Aprob :"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Hora Aprob :"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(5, 172)
        Me.KryptonLabel3.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(105, 24)
        Me.KryptonLabel3.TabIndex = 97
        Me.KryptonLabel3.Text = "Fecha Aprob :"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Fecha Aprob :"
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
        Me.HGFiltro.Panel.Controls.Add(Me.txtAprobador)
        Me.HGFiltro.Panel.Controls.Add(Me.txtDestino)
        Me.HGFiltro.Panel.Controls.Add(Me.lblAprobador)
        Me.HGFiltro.Panel.Controls.Add(Me.lblDestino)
        Me.HGFiltro.Panel.Controls.Add(Me.ToolStrip1)
        Me.HGFiltro.Panel.Controls.Add(Me.txtHoraEnvio)
        Me.HGFiltro.Panel.Controls.Add(Me.lblDiasAprob)
        Me.HGFiltro.Panel.Controls.Add(Me.lblSoles)
        Me.HGFiltro.Panel.Controls.Add(Me.txtFechaEnvio)
        Me.HGFiltro.Size = New System.Drawing.Size(700, 124)
        Me.HGFiltro.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HGFiltro.TabIndex = 2
        Me.HGFiltro.ValuesPrimary.Description = ""
        Me.HGFiltro.ValuesPrimary.Heading = ""
        Me.HGFiltro.ValuesPrimary.Image = Nothing
        Me.HGFiltro.ValuesSecondary.Description = ""
        Me.HGFiltro.ValuesSecondary.Heading = "Description"
        Me.HGFiltro.ValuesSecondary.Image = Nothing
        '
        'txtAprobador
        '
        Me.txtAprobador.BackColor = System.Drawing.SystemColors.Window
        Me.txtAprobador.Enabled = False
        Me.txtAprobador.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtAprobador.Location = New System.Drawing.Point(400, 68)
        Me.txtAprobador.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAprobador.MaxLength = 1000
        Me.txtAprobador.Multiline = True
        Me.txtAprobador.Name = "txtAprobador"
        Me.txtAprobador.Size = New System.Drawing.Size(270, 24)
        Me.txtAprobador.TabIndex = 97
        '
        'txtDestino
        '
        Me.txtDestino.BackColor = System.Drawing.SystemColors.Window
        Me.txtDestino.Enabled = False
        Me.txtDestino.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtDestino.Location = New System.Drawing.Point(131, 68)
        Me.txtDestino.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDestino.MaxLength = 1000
        Me.txtDestino.Multiline = True
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.Size = New System.Drawing.Size(158, 24)
        Me.txtDestino.TabIndex = 96
        '
        'lblAprobador
        '
        Me.lblAprobador.Location = New System.Drawing.Point(297, 68)
        Me.lblAprobador.Margin = New System.Windows.Forms.Padding(4)
        Me.lblAprobador.Name = "lblAprobador"
        Me.lblAprobador.Size = New System.Drawing.Size(93, 24)
        Me.lblAprobador.TabIndex = 93
        Me.lblAprobador.Text = "Aprobador :"
        Me.lblAprobador.Values.ExtraText = ""
        Me.lblAprobador.Values.Image = Nothing
        Me.lblAprobador.Values.Text = "Aprobador :"
        '
        'lblDestino
        '
        Me.lblDestino.Location = New System.Drawing.Point(13, 68)
        Me.lblDestino.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDestino.Name = "lblDestino"
        Me.lblDestino.Size = New System.Drawing.Size(76, 24)
        Me.lblDestino.TabIndex = 92
        Me.lblDestino.Text = "Destino  :"
        Me.lblDestino.Values.ExtraText = ""
        Me.lblDestino.Values.Image = Nothing
        Me.lblDestino.Values.Text = "Destino  :"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.btnGuardar, Me.btnAnularAprob})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(698, 27)
        Me.ToolStrip1.TabIndex = 19
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'btnAnularAprob
        '
        Me.btnAnularAprob.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAnularAprob.Image = Global.SOLMIN_CT.My.Resources.Resources._Red
        Me.btnAnularAprob.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAnularAprob.Name = "btnAnularAprob"
        Me.btnAnularAprob.Size = New System.Drawing.Size(125, 24)
        Me.btnAnularAprob.Text = "Anular Aprob."
        Me.btnAnularAprob.Visible = False
        '
        'txtHoraEnvio
        '
        Me.txtHoraEnvio.BackColor = System.Drawing.SystemColors.Window
        Me.txtHoraEnvio.Enabled = False
        Me.txtHoraEnvio.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtHoraEnvio.Location = New System.Drawing.Point(400, 36)
        Me.txtHoraEnvio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHoraEnvio.MaxLength = 1000
        Me.txtHoraEnvio.Multiline = True
        Me.txtHoraEnvio.Name = "txtHoraEnvio"
        Me.txtHoraEnvio.Size = New System.Drawing.Size(124, 24)
        Me.txtHoraEnvio.TabIndex = 18
        '
        'lblDiasAprob
        '
        Me.lblDiasAprob.Location = New System.Drawing.Point(299, 34)
        Me.lblDiasAprob.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDiasAprob.Name = "lblDiasAprob"
        Me.lblDiasAprob.Size = New System.Drawing.Size(93, 24)
        Me.lblDiasAprob.TabIndex = 17
        Me.lblDiasAprob.Text = "Hora Envío :"
        Me.lblDiasAprob.Values.ExtraText = ""
        Me.lblDiasAprob.Values.Image = Nothing
        Me.lblDiasAprob.Values.Text = "Hora Envío :"
        '
        'lblSoles
        '
        Me.lblSoles.Location = New System.Drawing.Point(13, 34)
        Me.lblSoles.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSoles.Name = "lblSoles"
        Me.lblSoles.Size = New System.Drawing.Size(95, 24)
        Me.lblSoles.TabIndex = 14
        Me.lblSoles.Text = "Fecha Envío:"
        Me.lblSoles.Values.ExtraText = ""
        Me.lblSoles.Values.Image = Nothing
        Me.lblSoles.Values.Text = "Fecha Envío:"
        '
        'txtFechaEnvio
        '
        Me.txtFechaEnvio.BackColor = System.Drawing.SystemColors.Window
        Me.txtFechaEnvio.Enabled = False
        Me.txtFechaEnvio.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtFechaEnvio.Location = New System.Drawing.Point(131, 36)
        Me.txtFechaEnvio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFechaEnvio.MaxLength = 1000
        Me.txtFechaEnvio.Multiline = True
        Me.txtFechaEnvio.Name = "txtFechaEnvio"
        Me.txtFechaEnvio.Size = New System.Drawing.Size(124, 24)
        Me.txtFechaEnvio.TabIndex = 13
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
        'frmAprobarNroValorizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 304)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAprobarNroValorizacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Aprobar Valorización"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
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
    Friend WithEvents txtHoraEnvio As System.Windows.Forms.TextBox
    Friend WithEvents lblDiasAprob As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblSoles As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtFechaEnvio As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblDestino As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtObservacionAprobacion As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaAprobacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtHoraAprobacion As System.Windows.Forms.MaskedTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboEstado As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents txtAprobador As System.Windows.Forms.TextBox
    Friend WithEvents txtDestino As System.Windows.Forms.TextBox
    Friend WithEvents lblAprobador As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnAnularAprob As System.Windows.Forms.ToolStripButton
End Class
