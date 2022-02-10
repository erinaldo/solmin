<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcFrmConsistencia
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
        Me.cmbEstadoFactura = New System.Windows.Forms.ComboBox
        Me.lblFacturacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.chkFecha = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.dtFeInicial = New System.Windows.Forms.DateTimePicker
        Me.dtFeFinal = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbOc = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.rbItem = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.chkDetallado = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.lblBusqueda = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtBusqueda = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbCriterioReporte = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.cmbTipoServicio = New System.Windows.Forms.ComboBox
        Me.cmbTipoAlmacenaje = New System.Windows.Forms.ComboBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbCompania = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.cmbDivision = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.cmbEstadoPendiente = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.btnSalir = New System.Windows.Forms.ToolStripButton
        Me.btnPantalla = New System.Windows.Forms.ToolStripButton
        Me.btnExcel = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.cmbPlanta = New Ransa.Controls.ServicioOperacion.CheckComboBoxTest.CheckedComboBox
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.cmbPlanta)
        Me.KryptonPanel.Controls.Add(Me.cmbEstadoFactura)
        Me.KryptonPanel.Controls.Add(Me.lblFacturacion)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel10)
        Me.KryptonPanel.Controls.Add(Me.chkFecha)
        Me.KryptonPanel.Controls.Add(Me.dtFeInicial)
        Me.KryptonPanel.Controls.Add(Me.dtFeFinal)
        Me.KryptonPanel.Controls.Add(Me.GroupBox1)
        Me.KryptonPanel.Controls.Add(Me.cmbTipoServicio)
        Me.KryptonPanel.Controls.Add(Me.cmbTipoAlmacenaje)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.cmbCompania)
        Me.KryptonPanel.Controls.Add(Me.cmbDivision)
        Me.KryptonPanel.Controls.Add(Me.cmbEstadoPendiente)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel9)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel8)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel7)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel6)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(521, 416)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 0
        '
        'cmbEstadoFactura
        '
        Me.cmbEstadoFactura.BackColor = System.Drawing.Color.White
        Me.cmbEstadoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstadoFactura.FormattingEnabled = True
        Me.cmbEstadoFactura.Location = New System.Drawing.Point(139, 146)
        Me.cmbEstadoFactura.Name = "cmbEstadoFactura"
        Me.cmbEstadoFactura.Size = New System.Drawing.Size(333, 21)
        Me.cmbEstadoFactura.TabIndex = 78
        '
        'lblFacturacion
        '
        Me.lblFacturacion.Location = New System.Drawing.Point(15, 146)
        Me.lblFacturacion.Name = "lblFacturacion"
        Me.lblFacturacion.Size = New System.Drawing.Size(102, 19)
        Me.lblFacturacion.TabIndex = 77
        Me.lblFacturacion.Text = "Estado Facturado :"
        Me.lblFacturacion.Values.ExtraText = ""
        Me.lblFacturacion.Values.Image = Nothing
        Me.lblFacturacion.Values.Text = "Estado Facturado :"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(159, 231)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(30, 19)
        Me.KryptonLabel3.TabIndex = 25
        Me.KryptonLabel3.Text = "De :"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "De :"
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(280, 231)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(23, 19)
        Me.KryptonLabel10.TabIndex = 29
        Me.KryptonLabel10.Text = "A :"
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "A :"
        '
        'chkFecha
        '
        Me.chkFecha.AutoSize = False
        Me.chkFecha.Checked = False
        Me.chkFecha.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chkFecha.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkFecha.Location = New System.Drawing.Point(-2, 223)
        Me.chkFecha.Name = "chkFecha"
        Me.chkFecha.Size = New System.Drawing.Size(153, 31)
        Me.chkFecha.TabIndex = 28
        Me.chkFecha.Text = "Rango Operación :"
        Me.chkFecha.Values.ExtraText = ""
        Me.chkFecha.Values.Image = Nothing
        Me.chkFecha.Values.Text = "Rango Operación :"
        '
        'dtFeInicial
        '
        Me.dtFeInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFeInicial.Location = New System.Drawing.Point(196, 229)
        Me.dtFeInicial.Name = "dtFeInicial"
        Me.dtFeInicial.Size = New System.Drawing.Size(81, 20)
        Me.dtFeInicial.TabIndex = 26
        '
        'dtFeFinal
        '
        Me.dtFeFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFeFinal.Location = New System.Drawing.Point(308, 229)
        Me.dtFeFinal.Name = "dtFeFinal"
        Me.dtFeFinal.Size = New System.Drawing.Size(82, 20)
        Me.dtFeFinal.TabIndex = 27
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbOc)
        Me.GroupBox1.Controls.Add(Me.rbItem)
        Me.GroupBox1.Controls.Add(Me.chkDetallado)
        Me.GroupBox1.Controls.Add(Me.lblBusqueda)
        Me.GroupBox1.Controls.Add(Me.txtBusqueda)
        Me.GroupBox1.Controls.Add(Me.KryptonLabel1)
        Me.GroupBox1.Controls.Add(Me.UcCliente)
        Me.GroupBox1.Controls.Add(Me.KryptonLabel4)
        Me.GroupBox1.Controls.Add(Me.cmbCriterioReporte)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 262)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(458, 127)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Criterio de Reporte :"
        '
        'rbOc
        '
        Me.rbOc.Location = New System.Drawing.Point(269, 100)
        Me.rbOc.Name = "rbOc"
        Me.rbOc.Size = New System.Drawing.Size(56, 19)
        Me.rbOc.TabIndex = 21
        Me.rbOc.Text = "Por Oc"
        Me.rbOc.Values.ExtraText = ""
        Me.rbOc.Values.Image = Nothing
        Me.rbOc.Values.Text = "Por Oc"
        Me.rbOc.Visible = False
        '
        'rbItem
        '
        Me.rbItem.Checked = True
        Me.rbItem.Location = New System.Drawing.Point(203, 100)
        Me.rbItem.Name = "rbItem"
        Me.rbItem.Size = New System.Drawing.Size(65, 19)
        Me.rbItem.TabIndex = 20
        Me.rbItem.Text = "Por Item"
        Me.rbItem.Values.ExtraText = ""
        Me.rbItem.Values.Image = Nothing
        Me.rbItem.Values.Text = "Por Item"
        Me.rbItem.Visible = False
        '
        'chkDetallado
        '
        Me.chkDetallado.Checked = False
        Me.chkDetallado.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkDetallado.Location = New System.Drawing.Point(111, 100)
        Me.chkDetallado.Name = "chkDetallado"
        Me.chkDetallado.Size = New System.Drawing.Size(71, 19)
        Me.chkDetallado.TabIndex = 19
        Me.chkDetallado.Text = "Detallado"
        Me.chkDetallado.Values.ExtraText = ""
        Me.chkDetallado.Values.Image = Nothing
        Me.chkDetallado.Values.Text = "Detallado"
        '
        'lblBusqueda
        '
        Me.lblBusqueda.Location = New System.Drawing.Point(-3, 74)
        Me.lblBusqueda.Name = "lblBusqueda"
        Me.lblBusqueda.Size = New System.Drawing.Size(92, 19)
        Me.lblBusqueda.TabIndex = 17
        Me.lblBusqueda.Text = "Nro. Operación :"
        Me.lblBusqueda.Values.ExtraText = ""
        Me.lblBusqueda.Values.Image = Nothing
        Me.lblBusqueda.Values.Text = "Nro. Operación :"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(111, 73)
        Me.txtBusqueda.MaxLength = 10
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(211, 21)
        Me.txtBusqueda.TabIndex = 18
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(39, 46)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(50, 19)
        Me.KryptonLabel1.TabIndex = 15
        Me.KryptonLabel1.Text = "Cliente :"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Cliente :"
        '
        'UcCliente
        '
        Me.UcCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcCliente.BackColor = System.Drawing.Color.Transparent
        Me.UcCliente.Location = New System.Drawing.Point(111, 45)
        Me.UcCliente.Name = "UcCliente"
        Me.UcCliente.pAccesoPorUsuario = False
        Me.UcCliente.pRequerido = False
        Me.UcCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.UcCliente.Size = New System.Drawing.Size(328, 21)
        Me.UcCliente.TabIndex = 16
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(8, 19)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(83, 19)
        Me.KryptonLabel4.TabIndex = 13
        Me.KryptonLabel4.Text = "Buscar Según :"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Buscar Según :"
        '
        'cmbCriterioReporte
        '
        Me.cmbCriterioReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCriterioReporte.DropDownWidth = 341
        Me.cmbCriterioReporte.FormattingEnabled = False
        Me.cmbCriterioReporte.ItemHeight = 13
        Me.cmbCriterioReporte.Location = New System.Drawing.Point(111, 17)
        Me.cmbCriterioReporte.MaxDropDownItems = 4
        Me.cmbCriterioReporte.Name = "cmbCriterioReporte"
        Me.cmbCriterioReporte.Size = New System.Drawing.Size(328, 21)
        Me.cmbCriterioReporte.TabIndex = 14
        '
        'cmbTipoServicio
        '
        Me.cmbTipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoServicio.FormattingEnabled = True
        Me.cmbTipoServicio.Location = New System.Drawing.Point(138, 202)
        Me.cmbTipoServicio.Name = "cmbTipoServicio"
        Me.cmbTipoServicio.Size = New System.Drawing.Size(334, 21)
        Me.cmbTipoServicio.TabIndex = 12
        '
        'cmbTipoAlmacenaje
        '
        Me.cmbTipoAlmacenaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoAlmacenaje.FormattingEnabled = True
        Me.cmbTipoAlmacenaje.Location = New System.Drawing.Point(138, 175)
        Me.cmbTipoAlmacenaje.Name = "cmbTipoAlmacenaje"
        Me.cmbTipoAlmacenaje.Size = New System.Drawing.Size(334, 21)
        Me.cmbTipoAlmacenaje.TabIndex = 10
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(2, 173)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(115, 19)
        Me.KryptonLabel2.TabIndex = 9
        Me.KryptonLabel2.Text = "Tipo De Almacenaje :"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Tipo De Almacenaje :"
        '
        'cmbCompania
        '
        Me.cmbCompania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCompania.DropDownWidth = 341
        Me.cmbCompania.FormattingEnabled = False
        Me.cmbCompania.ItemHeight = 13
        Me.cmbCompania.Location = New System.Drawing.Point(138, 37)
        Me.cmbCompania.MaxDropDownItems = 4
        Me.cmbCompania.Name = "cmbCompania"
        Me.cmbCompania.Size = New System.Drawing.Size(334, 21)
        Me.cmbCompania.TabIndex = 2
        '
        'cmbDivision
        '
        Me.cmbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDivision.DropDownWidth = 341
        Me.cmbDivision.FormattingEnabled = False
        Me.cmbDivision.ItemHeight = 13
        Me.cmbDivision.Location = New System.Drawing.Point(138, 64)
        Me.cmbDivision.MaxDropDownItems = 4
        Me.cmbDivision.Name = "cmbDivision"
        Me.cmbDivision.Size = New System.Drawing.Size(334, 21)
        Me.cmbDivision.TabIndex = 4
        '
        'cmbEstadoPendiente
        '
        Me.cmbEstadoPendiente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstadoPendiente.DropDownWidth = 341
        Me.cmbEstadoPendiente.FormattingEnabled = False
        Me.cmbEstadoPendiente.ItemHeight = 13
        Me.cmbEstadoPendiente.Location = New System.Drawing.Point(138, 120)
        Me.cmbEstadoPendiente.MaxDropDownItems = 4
        Me.cmbEstadoPendiente.Name = "cmbEstadoPendiente"
        Me.cmbEstadoPendiente.Size = New System.Drawing.Size(334, 21)
        Me.cmbEstadoPendiente.TabIndex = 8
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(38, 201)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(79, 19)
        Me.KryptonLabel9.TabIndex = 11
        Me.KryptonLabel9.Text = "Tipo Servicio :"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Tipo Servicio :"
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(23, 120)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(94, 19)
        Me.KryptonLabel8.TabIndex = 7
        Me.KryptonLabel8.Text = "Estado Revisión :"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Estado Revisión :"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(70, 92)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(47, 19)
        Me.KryptonLabel7.TabIndex = 5
        Me.KryptonLabel7.Text = "Planta :"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Planta :"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(51, 37)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(66, 19)
        Me.KryptonLabel6.TabIndex = 1
        Me.KryptonLabel6.Text = "Compañia :"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Compañia :"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(62, 64)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(55, 19)
        Me.KryptonLabel5.TabIndex = 3
        Me.KryptonLabel5.Text = "División :"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "División :"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.btnSalir, Me.btnPantalla, Me.btnExcel})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(521, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(132, 22)
        Me.ToolStripLabel1.Text = "Reporte de Consistencia"
        '
        'btnSalir
        '
        Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalir.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.salir
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(49, 22)
        Me.btnSalir.Text = "Salir"
        '
        'btnPantalla
        '
        Me.btnPantalla.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnPantalla.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.printer2
        Me.btnPantalla.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPantalla.Name = "btnPantalla"
        Me.btnPantalla.Size = New System.Drawing.Size(68, 22)
        Me.btnPantalla.Text = "Reporte"
        Me.btnPantalla.Visible = False
        '
        'btnExcel
        '
        Me.btnExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExcel.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.icono_exp_excel
        Me.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(52, 22)
        Me.btnExcel.Text = "Excel"
        '
        'cmbPlanta
        '
        Me.cmbPlanta.CheckOnClick = True
        Me.cmbPlanta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbPlanta.DropDownHeight = 1
        Me.cmbPlanta.FormattingEnabled = True
        Me.cmbPlanta.IntegralHeight = False
        Me.cmbPlanta.Location = New System.Drawing.Point(138, 92)
        Me.cmbPlanta.Name = "cmbPlanta"
        Me.cmbPlanta.Size = New System.Drawing.Size(334, 21)
        Me.cmbPlanta.TabIndex = 96
        Me.cmbPlanta.ValueSeparator = ", "
        '
        'UcFrmConsistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 416)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(529, 450)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(529, 450)
        Me.Name = "UcFrmConsistencia"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consistencia"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
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
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtBusqueda As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblBusqueda As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnPantalla As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents UcCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents cmbCriterioReporte As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbCompania As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents cmbDivision As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents cmbEstadoPendiente As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbTipoAlmacenaje As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTipoServicio As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkDetallado As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents rbOc As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbItem As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents chkFecha As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents dtFeInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFeFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbEstadoFactura As System.Windows.Forms.ComboBox
    Friend WithEvents lblFacturacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbPlanta As Ransa.Controls.ServicioOperacion.CheckComboBoxTest.CheckedComboBox
End Class
