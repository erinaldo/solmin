<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaIncidenciaPorMes
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
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.khgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.cmbReportado = New DevExpress.XtraEditors.CheckedComboBoxEdit
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbNegocio = New DevExpress.XtraEditors.CheckedComboBoxEdit
        Me.cmbIncPara = New System.Windows.Forms.ComboBox
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbPlanta = New DevExpress.XtraEditors.CheckedComboBoxEdit
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.cmbArea = New DevExpress.XtraEditors.CheckedComboBoxEdit
        Me.cmbMes = New DevExpress.XtraEditors.CheckedComboBoxEdit
        Me.txtAnio = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFechaInicial = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tss05 = New System.Windows.Forms.ToolStripSeparator
        Me.tss03 = New System.Windows.Forms.ToolStripSeparator
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.bgwGifAnimado = New System.ComponentModel.BackgroundWorker
        Me.pcxEspera = New System.Windows.Forms.PictureBox
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton
        Me.tsbGenerarReporte = New System.Windows.Forms.ToolStripButton
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.khgFiltros.Panel.SuspendLayout()
        Me.khgFiltros.SuspendLayout()
        CType(Me.cmbReportado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNegocio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPlanta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.pcxEspera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.khgFiltros)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(585, 205)
        Me.KryptonPanel.TabIndex = 0
        '
        'khgFiltros
        '
        Me.khgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaCerrar})
        Me.khgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.khgFiltros.HeaderVisiblePrimary = False
        Me.khgFiltros.HeaderVisibleSecondary = False
        Me.khgFiltros.Location = New System.Drawing.Point(0, 25)
        Me.khgFiltros.Name = "khgFiltros"
        '
        'khgFiltros.Panel
        '
        Me.khgFiltros.Panel.Controls.Add(Me.pcxEspera)
        Me.khgFiltros.Panel.Controls.Add(Me.cmbReportado)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel7)
        Me.khgFiltros.Panel.Controls.Add(Me.cmbNegocio)
        Me.khgFiltros.Panel.Controls.Add(Me.cmbIncPara)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel4)
        Me.khgFiltros.Panel.Controls.Add(Me.cmbPlanta)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.khgFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.khgFiltros.Panel.Controls.Add(Me.cmbArea)
        Me.khgFiltros.Panel.Controls.Add(Me.cmbMes)
        Me.khgFiltros.Panel.Controls.Add(Me.txtAnio)
        Me.khgFiltros.Panel.Controls.Add(Me.lblCliente)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel6)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel3)
        Me.khgFiltros.Panel.Controls.Add(Me.lblFechaInicial)
        Me.khgFiltros.Size = New System.Drawing.Size(585, 204)
        Me.khgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.khgFiltros.TabIndex = 66
        Me.khgFiltros.Text = "Filtros"
        Me.khgFiltros.ValuesPrimary.Description = ""
        Me.khgFiltros.ValuesPrimary.Heading = "Filtros"
        Me.khgFiltros.ValuesPrimary.Image = Nothing
        Me.khgFiltros.ValuesSecondary.Description = ""
        Me.khgFiltros.ValuesSecondary.Heading = "Resultado"
        Me.khgFiltros.ValuesSecondary.Image = Nothing
        '
        'bsaCerrar
        '
        Me.bsaCerrar.ExtraText = ""
        Me.bsaCerrar.Image = Nothing
        Me.bsaCerrar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaCerrar.Text = "Cerrar"
        Me.bsaCerrar.ToolTipImage = Nothing
        Me.bsaCerrar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.bsaCerrar.UniqueName = "C90E4396C7B04154C90E4396C7B04154"
        '
        'cmbReportado
        '
        Me.cmbReportado.EditValue = ""
        Me.cmbReportado.Location = New System.Drawing.Point(315, 65)
        Me.cmbReportado.Name = "cmbReportado"
        Me.cmbReportado.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbReportado.Properties.Appearance.Options.UseBackColor = True
        Me.cmbReportado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbReportado.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.cmbReportado.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmbReportado.Properties.SelectAllItemCaption = "Todos"
        Me.cmbReportado.Size = New System.Drawing.Size(251, 22)
        Me.cmbReportado.TabIndex = 9
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(21, 307)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(6, 2)
        Me.KryptonLabel7.TabIndex = 150
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = ""
        '
        'cmbNegocio
        '
        Me.cmbNegocio.EditValue = ""
        Me.cmbNegocio.Location = New System.Drawing.Point(314, 107)
        Me.cmbNegocio.Name = "cmbNegocio"
        Me.cmbNegocio.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbNegocio.Properties.Appearance.Options.UseBackColor = True
        Me.cmbNegocio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbNegocio.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.cmbNegocio.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmbNegocio.Properties.SelectAllItemCaption = "Todos"
        Me.cmbNegocio.Size = New System.Drawing.Size(251, 22)
        Me.cmbNegocio.TabIndex = 13
        '
        'cmbIncPara
        '
        Me.cmbIncPara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIncPara.FormattingEnabled = True
        Me.cmbIncPara.Location = New System.Drawing.Point(20, 105)
        Me.cmbIncPara.Name = "cmbIncPara"
        Me.cmbIncPara.Size = New System.Drawing.Size(269, 21)
        Me.cmbIncPara.TabIndex = 11
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(15, 87)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(56, 20)
        Me.KryptonLabel5.TabIndex = 10
        Me.KryptonLabel5.Text = "Inc. Para"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Inc. Para"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(310, 89)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(57, 20)
        Me.KryptonLabel4.TabIndex = 12
        Me.KryptonLabel4.Text = "Negocio "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Negocio "
        '
        'cmbPlanta
        '
        Me.cmbPlanta.EditValue = ""
        Me.cmbPlanta.Location = New System.Drawing.Point(315, 29)
        Me.cmbPlanta.Name = "cmbPlanta"
        Me.cmbPlanta.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbPlanta.Properties.Appearance.Options.UseBackColor = True
        Me.cmbPlanta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbPlanta.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.cmbPlanta.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmbPlanta.Properties.SelectAllItemCaption = "TODOS"
        Me.cmbPlanta.Size = New System.Drawing.Size(251, 22)
        Me.cmbPlanta.TabIndex = 3
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(310, 12)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(44, 20)
        Me.KryptonLabel1.TabIndex = 2
        Me.KryptonLabel1.Text = "Planta"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Planta"
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.CCMPN = "EZ"
        Me.txtCliente.Location = New System.Drawing.Point(20, 145)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pRequerido = False
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(271, 22)
        Me.txtCliente.TabIndex = 15
        '
        'cmbArea
        '
        Me.cmbArea.EditValue = ""
        Me.cmbArea.Location = New System.Drawing.Point(19, 28)
        Me.cmbArea.Name = "cmbArea"
        Me.cmbArea.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbArea.Properties.Appearance.Options.UseBackColor = True
        Me.cmbArea.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbArea.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.cmbArea.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmbArea.Properties.SelectAllItemCaption = "Todos"
        Me.cmbArea.Size = New System.Drawing.Size(271, 22)
        Me.cmbArea.TabIndex = 1
        '
        'cmbMes
        '
        Me.cmbMes.EditValue = ""
        Me.cmbMes.Location = New System.Drawing.Point(117, 64)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbMes.Properties.Appearance.Options.UseBackColor = True
        Me.cmbMes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbMes.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.cmbMes.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmbMes.Properties.SelectAllItemCaption = "Todos"
        Me.cmbMes.Size = New System.Drawing.Size(173, 22)
        Me.cmbMes.TabIndex = 7
        '
        'txtAnio
        '
        Me.txtAnio.Location = New System.Drawing.Point(19, 64)
        Me.txtAnio.MaxLength = 4
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(66, 22)
        Me.txtAnio.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAnio.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAnio.TabIndex = 5
        Me.txtAnio.Text = "0"
        Me.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(15, 127)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(48, 20)
        Me.lblCliente.TabIndex = 14
        Me.lblCliente.Text = "Cliente"
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(15, 12)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(36, 20)
        Me.KryptonLabel2.TabIndex = 0
        Me.KryptonLabel2.Text = "Área"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Área"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(310, 49)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(90, 20)
        Me.KryptonLabel6.TabIndex = 8
        Me.KryptonLabel6.Text = "Reportado por"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Reportado por"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(112, 48)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(33, 20)
        Me.KryptonLabel3.TabIndex = 6
        Me.KryptonLabel3.Text = "Mes"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Mes"
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.Location = New System.Drawing.Point(14, 48)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(33, 20)
        Me.lblFechaInicial.TabIndex = 4
        Me.lblFechaInicial.Text = "Año"
        Me.lblFechaInicial.Values.ExtraText = ""
        Me.lblFechaInicial.Values.Image = Nothing
        Me.lblFechaInicial.Values.Text = "Año"
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.tsbCancelar, Me.tss05, Me.tsbGenerarReporte, Me.tss03})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(585, 25)
        Me.tsMenuOpciones.TabIndex = 65
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tss05
        '
        Me.tss05.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss05.Name = "tss05"
        Me.tss05.Size = New System.Drawing.Size(6, 25)
        '
        'tss03
        '
        Me.tss03.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss03.Name = "tss03"
        Me.tss03.Size = New System.Drawing.Size(6, 25)
        '
        'bgwGifAnimado
        '
        '
        'pcxEspera
        '
        Me.pcxEspera.BackColor = System.Drawing.Color.Transparent
        Me.pcxEspera.Image = Global.Ransa.Controls.Incidencia.My.Resources.Resources.iconoEspera
        Me.pcxEspera.Location = New System.Drawing.Point(421, 129)
        Me.pcxEspera.Name = "pcxEspera"
        Me.pcxEspera.Size = New System.Drawing.Size(51, 49)
        Me.pcxEspera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcxEspera.TabIndex = 67
        Me.pcxEspera.TabStop = False
        Me.pcxEspera.Visible = False
        '
        'tsbCancelar
        '
        Me.tsbCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbCancelar.Image = Global.Ransa.Controls.Incidencia.My.Resources.Resources.button_cancel
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(73, 22)
        Me.tsbCancelar.Text = "Cancelar"
        '
        'tsbGenerarReporte
        '
        Me.tsbGenerarReporte.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbGenerarReporte.Image = Global.Ransa.Controls.Incidencia.My.Resources.Resources.GenerarReporte
        Me.tsbGenerarReporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGenerarReporte.Name = "tsbGenerarReporte"
        Me.tsbGenerarReporte.Size = New System.Drawing.Size(112, 22)
        Me.tsbGenerarReporte.Text = "Generar Reporte"
        '
        'frmConsultaIncidenciaPorMes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 205)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmConsultaIncidenciaPorMes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Incidencia Por Mes"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.Panel.ResumeLayout(False)
        Me.khgFiltros.Panel.PerformLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.ResumeLayout(False)
        CType(Me.cmbReportado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNegocio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPlanta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        CType(Me.pcxEspera, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Friend WithEvents tss03 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tss05 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bgwGifAnimado As System.ComponentModel.BackgroundWorker
    'Friend WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents tsbGenerarReporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents khgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaCerrar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Private WithEvents pcxEspera As System.Windows.Forms.PictureBox
    Friend WithEvents cmbArea As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents cmbMes As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents txtAnio As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFechaInicial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbPlanta As DevExpress.XtraEditors.CheckedComboBoxEdit
    Private WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbIncPara As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbNegocio As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents cmbReportado As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
