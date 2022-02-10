<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAprobacionAlquiler
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
        Me.gwdUnidAlquiler = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.TPLNTA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRUCTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMTRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.dtpFechaAprob = New System.Windows.Forms.DateTimePicker
        Me.txtObservacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtUsuario = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFechaAsignacion = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaVigenciaFin = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaVigenciaInicio = New System.Windows.Forms.DateTimePicker
        Me.txtUnidad = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
        Me.txtProveedor = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
        Me.txtMoneda = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
        Me.txtMonto = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
        Me.txtAlquiler = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.btnCancelarAprobacion = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAceptarAprobacion = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.gwdUnidAlquiler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.gwdUnidAlquiler)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Controls.Add(Me.KryptonGroup1)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip2)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(707, 438)
        Me.KryptonPanel.TabIndex = 0
        '
        'gwdUnidAlquiler
        '
        Me.gwdUnidAlquiler.AllowUserToAddRows = False
        Me.gwdUnidAlquiler.AllowUserToDeleteRows = False
        Me.gwdUnidAlquiler.AllowUserToOrderColumns = True
        Me.gwdUnidAlquiler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gwdUnidAlquiler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gwdUnidAlquiler.ColumnHeadersHeight = 30
        Me.gwdUnidAlquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gwdUnidAlquiler.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TPLNTA, Me.NRUCTR, Me.TCMTRT})
        Me.gwdUnidAlquiler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gwdUnidAlquiler.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.gwdUnidAlquiler.Location = New System.Drawing.Point(0, 310)
        Me.gwdUnidAlquiler.MultiSelect = False
        Me.gwdUnidAlquiler.Name = "gwdUnidAlquiler"
        Me.gwdUnidAlquiler.ReadOnly = True
        Me.gwdUnidAlquiler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.gwdUnidAlquiler.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gwdUnidAlquiler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gwdUnidAlquiler.Size = New System.Drawing.Size(707, 128)
        Me.gwdUnidAlquiler.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwdUnidAlquiler.TabIndex = 16
        '
        'TPLNTA
        '
        Me.TPLNTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TPLNTA.DataPropertyName = "TPLNTA"
        Me.TPLNTA.HeaderText = "Planta"
        Me.TPLNTA.Name = "TPLNTA"
        Me.TPLNTA.ReadOnly = True
        Me.TPLNTA.Width = 69
        '
        'NRUCTR
        '
        Me.NRUCTR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRUCTR.DataPropertyName = "NRUCTR"
        Me.NRUCTR.FillWeight = 80.0!
        Me.NRUCTR.HeaderText = "Ruc"
        Me.NRUCTR.Name = "NRUCTR"
        Me.NRUCTR.ReadOnly = True
        Me.NRUCTR.Width = 56
        '
        'TCMTRT
        '
        Me.TCMTRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TCMTRT.DataPropertyName = "TCMTRT"
        Me.TCMTRT.HeaderText = "Transportista"
        Me.TCMTRT.Name = "TCMTRT"
        Me.TCMTRT.ReadOnly = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 285)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(707, 25)
        Me.ToolStrip1.TabIndex = 15
        Me.ToolStrip1.TabStop = True
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(113, 22)
        Me.ToolStripLabel1.Text = "Asignación de Placa"
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonGroup1.Location = New System.Drawing.Point(0, 25)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.dtpFechaAprob)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtObservacion)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtUsuario)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel10)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel9)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel8)
        Me.KryptonGroup1.Panel.Controls.Add(Me.dtpFechaAsignacion)
        Me.KryptonGroup1.Panel.Controls.Add(Me.dtpFechaVigenciaFin)
        Me.KryptonGroup1.Panel.Controls.Add(Me.dtpFechaVigenciaInicio)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtUnidad)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtProveedor)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtMoneda)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtMonto)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtAlquiler)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel7)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel6)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonGroup1.Size = New System.Drawing.Size(707, 260)
        Me.KryptonGroup1.TabIndex = 14
        '
        'dtpFechaAprob
        '
        Me.dtpFechaAprob.Enabled = False
        Me.dtpFechaAprob.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAprob.Location = New System.Drawing.Point(292, 124)
        Me.dtpFechaAprob.Name = "dtpFechaAprob"
        Me.dtpFechaAprob.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaAprob.TabIndex = 22
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(93, 162)
        Me.txtObservacion.MaxLength = 250
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(582, 78)
        Me.txtObservacion.TabIndex = 21
        '
        'txtUsuario
        '
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(93, 122)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 22)
        Me.txtUsuario.TabIndex = 20
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(10, 190)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(78, 20)
        Me.KryptonLabel10.TabIndex = 19
        Me.KryptonLabel10.Text = "Observación"
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "Observación"
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(204, 124)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(82, 20)
        Me.KryptonLabel9.TabIndex = 18
        Me.KryptonLabel9.Text = "Fecha Aprob."
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Fecha Aprob."
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(10, 124)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(52, 20)
        Me.KryptonLabel8.TabIndex = 17
        Me.KryptonLabel8.Text = "Usuario"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Usuario"
        '
        'dtpFechaAsignacion
        '
        Me.dtpFechaAsignacion.Enabled = False
        Me.dtpFechaAsignacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAsignacion.Location = New System.Drawing.Point(278, 13)
        Me.dtpFechaAsignacion.Name = "dtpFechaAsignacion"
        Me.dtpFechaAsignacion.Size = New System.Drawing.Size(101, 20)
        Me.dtpFechaAsignacion.TabIndex = 15
        '
        'dtpFechaVigenciaFin
        '
        Me.dtpFechaVigenciaFin.Enabled = False
        Me.dtpFechaVigenciaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVigenciaFin.Location = New System.Drawing.Point(576, 15)
        Me.dtpFechaVigenciaFin.Name = "dtpFechaVigenciaFin"
        Me.dtpFechaVigenciaFin.Size = New System.Drawing.Size(99, 20)
        Me.dtpFechaVigenciaFin.TabIndex = 14
        '
        'dtpFechaVigenciaInicio
        '
        Me.dtpFechaVigenciaInicio.Enabled = False
        Me.dtpFechaVigenciaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVigenciaInicio.Location = New System.Drawing.Point(462, 15)
        Me.dtpFechaVigenciaInicio.Name = "dtpFechaVigenciaInicio"
        Me.dtpFechaVigenciaInicio.Size = New System.Drawing.Size(99, 20)
        Me.dtpFechaVigenciaInicio.TabIndex = 13
        '
        'txtUnidad
        '
        Me.txtUnidad.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtUnidad.Enabled = False
        Me.txtUnidad.Location = New System.Drawing.Point(93, 48)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.txtUnidad.Size = New System.Drawing.Size(167, 22)
        Me.txtUnidad.TabIndex = 12
        '
        'txtProveedor
        '
        Me.txtProveedor.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtProveedor.Enabled = False
        Me.txtProveedor.Location = New System.Drawing.Point(340, 48)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.txtProveedor.Size = New System.Drawing.Size(335, 22)
        Me.txtProveedor.TabIndex = 8
        '
        'txtMoneda
        '
        Me.txtMoneda.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtMoneda.Enabled = False
        Me.txtMoneda.Location = New System.Drawing.Point(292, 87)
        Me.txtMoneda.Name = "txtMoneda"
        Me.txtMoneda.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.txtMoneda.Size = New System.Drawing.Size(99, 22)
        Me.txtMoneda.TabIndex = 11
        '
        'txtMonto
        '
        Me.txtMonto.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtMonto.Enabled = False
        Me.txtMonto.Location = New System.Drawing.Point(93, 87)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.txtMonto.Size = New System.Drawing.Size(100, 22)
        Me.txtMonto.TabIndex = 9
        '
        'txtAlquiler
        '
        Me.txtAlquiler.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtAlquiler.Enabled = False
        Me.txtAlquiler.Location = New System.Drawing.Point(93, 13)
        Me.txtAlquiler.Name = "txtAlquiler"
        Me.txtAlquiler.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.txtAlquiler.Size = New System.Drawing.Size(100, 22)
        Me.txtAlquiler.TabIndex = 7
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(390, 13)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(66, 20)
        Me.KryptonLabel7.TabIndex = 6
        Me.KryptonLabel7.Text = "Fecha Vig."
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Fecha Vig."
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(204, 89)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(56, 20)
        Me.KryptonLabel6.TabIndex = 5
        Me.KryptonLabel6.Text = "Moneda"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Moneda"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(10, 50)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(41, 20)
        Me.KryptonLabel5.TabIndex = 4
        Me.KryptonLabel5.Text = "Placa:"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Placa:"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(200, 14)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(72, 20)
        Me.KryptonLabel4.TabIndex = 3
        Me.KryptonLabel4.Text = "Fecha Asig."
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Fecha Asig."
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(10, 89)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(47, 20)
        Me.KryptonLabel3.TabIndex = 2
        Me.KryptonLabel3.Text = "Monto"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Monto"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(267, 50)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(67, 20)
        Me.KryptonLabel2.TabIndex = 1
        Me.KryptonLabel2.Text = "Proveedor"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Proveedor"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(10, 15)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(77, 20)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Text = "Nro Alquiler"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Nro Alquiler"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelarAprobacion, Me.ToolStripSeparator8, Me.btnAceptarAprobacion})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(707, 25)
        Me.ToolStrip2.TabIndex = 13
        Me.ToolStrip2.TabStop = True
        '
        'btnCancelarAprobacion
        '
        Me.btnCancelarAprobacion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelarAprobacion.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
        Me.btnCancelarAprobacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelarAprobacion.Name = "btnCancelarAprobacion"
        Me.btnCancelarAprobacion.Size = New System.Drawing.Size(73, 22)
        Me.btnCancelarAprobacion.Text = "&Cancelar"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'btnAceptarAprobacion
        '
        Me.btnAceptarAprobacion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAceptarAprobacion.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnAceptarAprobacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptarAprobacion.Name = "btnAceptarAprobacion"
        Me.btnAceptarAprobacion.Size = New System.Drawing.Size(68, 22)
        Me.btnAceptarAprobacion.Text = "&Aceptar"
        '
        'frmAprobacionAlquiler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 438)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmAprobacionAlquiler"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Aprobar alquiler"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.gwdUnidAlquiler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        Me.KryptonGroup1.Panel.PerformLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
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
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCancelarAprobacion As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAceptarAprobacion As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents dtpFechaAsignacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaVigenciaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaVigenciaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtUnidad As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents txtProveedor As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents txtMoneda As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents txtMonto As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents txtAlquiler As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaAprob As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtObservacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtUsuario As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents gwdUnidAlquiler As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents TPLNTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRUCTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMTRT As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
