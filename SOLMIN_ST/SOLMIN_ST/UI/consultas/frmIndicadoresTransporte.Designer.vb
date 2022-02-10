<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIndicadoresTransporte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIndicadoresTransporte))
        Me.panel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.HeaderGroupTabs = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.pbxBuscar = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.MenuBar = New System.Windows.Forms.ToolStrip
        Me.btnProcesarReporte = New System.Windows.Forms.ToolStripButton
        Me.btnSalir = New System.Windows.Forms.ToolStripButton
        Me.HeaderGroupFiltro = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.KryptonLabel32 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cboMedioTransporte = New System.Windows.Forms.ComboBox
        Me.dbMes = New System.Windows.Forms.ComboBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ndAnio = New System.Windows.Forms.NumericUpDown
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cboTracto = New Ransa.Controls.Transportista.ucTractoTransportista_TxtF01
        Me.lblVehiculo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbPlanta = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
        Me.cmbDivision = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
        Me.cmbCompania = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.cboTransportista = New Ransa.Controls.Transportista.ucTransportista_TxtF01
        Me.lblTransportista = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblPlanta = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCompania = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.ControlVisorCliente = New SOLMIN_ST.Control_Visor_Reporte
        Me.chkcbxPlanta = New SOLMIN_ST.CheckComboBoxTest.CheckedComboBox
        CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.SuspendLayout()
        CType(Me.HeaderGroupTabs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderGroupTabs.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderGroupTabs.Panel.SuspendLayout()
        Me.HeaderGroupTabs.SuspendLayout()
        CType(Me.pbxBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        CType(Me.HeaderGroupFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderGroupFiltro.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderGroupFiltro.Panel.SuspendLayout()
        Me.HeaderGroupFiltro.SuspendLayout()
        CType(Me.ndAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel
        '
        Me.panel.Controls.Add(Me.HeaderGroupTabs)
        Me.panel.Controls.Add(Me.HeaderGroupFiltro)
        Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(1079, 732)
        Me.panel.StateCommon.Color1 = System.Drawing.SystemColors.ActiveCaptionText
        Me.panel.TabIndex = 0
        '
        'HeaderGroupTabs
        '
        Me.HeaderGroupTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderGroupTabs.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HeaderGroupTabs.Location = New System.Drawing.Point(0, 120)
        Me.HeaderGroupTabs.Name = "HeaderGroupTabs"
        '
        'HeaderGroupTabs.Panel
        '
        Me.HeaderGroupTabs.Panel.Controls.Add(Me.pbxBuscar)
        Me.HeaderGroupTabs.Panel.Controls.Add(Me.ControlVisorCliente)
        Me.HeaderGroupTabs.Panel.Controls.Add(Me.Panel2)
        Me.HeaderGroupTabs.Size = New System.Drawing.Size(1079, 612)
        Me.HeaderGroupTabs.TabIndex = 5
        Me.HeaderGroupTabs.Text = "Resultados"
        Me.HeaderGroupTabs.ValuesPrimary.Description = ""
        Me.HeaderGroupTabs.ValuesPrimary.Heading = "Resultados"
        Me.HeaderGroupTabs.ValuesPrimary.Image = Nothing
        Me.HeaderGroupTabs.ValuesSecondary.Description = ""
        Me.HeaderGroupTabs.ValuesSecondary.Heading = ""
        Me.HeaderGroupTabs.ValuesSecondary.Image = Nothing
        '
        'pbxBuscar
        '
        Me.pbxBuscar.BackColor = System.Drawing.Color.White
        Me.pbxBuscar.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbxBuscar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxBuscar.Enabled = False
        Me.pbxBuscar.Image = CType(resources.GetObject("pbxBuscar.Image"), System.Drawing.Image)
        Me.pbxBuscar.ImageLocation = ""
        Me.pbxBuscar.InitialImage = Nothing
        Me.pbxBuscar.Location = New System.Drawing.Point(0, 25)
        Me.pbxBuscar.Name = "pbxBuscar"
        Me.pbxBuscar.Size = New System.Drawing.Size(1077, 562)
        Me.pbxBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxBuscar.TabIndex = 14
        Me.pbxBuscar.TabStop = False
        Me.pbxBuscar.Visible = False
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.Controls.Add(Me.MenuBar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1077, 25)
        Me.Panel2.TabIndex = 4
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnProcesarReporte, Me.btnSalir})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(1077, 25)
        Me.MenuBar.TabIndex = 2
        Me.MenuBar.Text = "ToolStrip1"
        '
        'btnProcesarReporte
        '
        Me.btnProcesarReporte.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnProcesarReporte.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.btnProcesarReporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProcesarReporte.Name = "btnProcesarReporte"
        Me.btnProcesarReporte.Size = New System.Drawing.Size(61, 22)
        Me.btnProcesarReporte.Text = "Buscar"
        '
        'btnSalir
        '
        Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalir.Image = Global.SOLMIN_ST.My.Resources.Resources._exit
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(52, 22)
        Me.btnSalir.Text = " Salir"
        Me.btnSalir.Visible = False
        '
        'HeaderGroupFiltro
        '
        Me.HeaderGroupFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderGroupFiltro.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HeaderGroupFiltro.Location = New System.Drawing.Point(0, 0)
        Me.HeaderGroupFiltro.Name = "HeaderGroupFiltro"
        '
        'HeaderGroupFiltro.Panel
        '
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.chkcbxPlanta)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel32)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.cboMedioTransporte)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.dbMes)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel3)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.ndAnio)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel6)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.cboTracto)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.lblVehiculo)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.cmbPlanta)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.cmbDivision)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.cmbCompania)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.cboTransportista)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.lblTransportista)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.lblPlanta)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.lblCompania)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel1)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.txtCliente)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel5)
        Me.HeaderGroupFiltro.Size = New System.Drawing.Size(1079, 120)
        Me.HeaderGroupFiltro.TabIndex = 4
        Me.HeaderGroupFiltro.Text = "Opciones de filtro"
        Me.HeaderGroupFiltro.ValuesPrimary.Description = ""
        Me.HeaderGroupFiltro.ValuesPrimary.Heading = "Opciones de filtro"
        Me.HeaderGroupFiltro.ValuesPrimary.Image = Nothing
        Me.HeaderGroupFiltro.ValuesSecondary.Description = ""
        Me.HeaderGroupFiltro.ValuesSecondary.Heading = ""
        Me.HeaderGroupFiltro.ValuesSecondary.Image = Nothing
        '
        'KryptonLabel32
        '
        Me.KryptonLabel32.Location = New System.Drawing.Point(326, 66)
        Me.KryptonLabel32.Name = "KryptonLabel32"
        Me.KryptonLabel32.Size = New System.Drawing.Size(99, 19)
        Me.KryptonLabel32.TabIndex = 126
        Me.KryptonLabel32.Text = "Medio Transporte"
        Me.KryptonLabel32.Values.ExtraText = ""
        Me.KryptonLabel32.Values.Image = Nothing
        Me.KryptonLabel32.Values.Text = "Medio Transporte"
        '
        'cboMedioTransporte
        '
        Me.cboMedioTransporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMedioTransporte.FormattingEnabled = True
        Me.cboMedioTransporte.Location = New System.Drawing.Point(430, 65)
        Me.cboMedioTransporte.Name = "cboMedioTransporte"
        Me.cboMedioTransporte.Size = New System.Drawing.Size(135, 21)
        Me.cboMedioTransporte.TabIndex = 127
        '
        'dbMes
        '
        Me.dbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dbMes.FormattingEnabled = True
        Me.dbMes.Location = New System.Drawing.Point(203, 65)
        Me.dbMes.Name = "dbMes"
        Me.dbMes.Size = New System.Drawing.Size(113, 21)
        Me.dbMes.TabIndex = 125
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(162, 66)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(31, 19)
        Me.KryptonLabel3.TabIndex = 124
        Me.KryptonLabel3.Text = "Mes "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Mes "
        '
        'ndAnio
        '
        Me.ndAnio.Location = New System.Drawing.Point(85, 65)
        Me.ndAnio.Maximum = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.ndAnio.Minimum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.ndAnio.Name = "ndAnio"
        Me.ndAnio.ReadOnly = True
        Me.ndAnio.Size = New System.Drawing.Size(53, 20)
        Me.ndAnio.TabIndex = 123
        Me.ndAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ndAnio.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(16, 66)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(31, 19)
        Me.KryptonLabel6.TabIndex = 122
        Me.KryptonLabel6.Text = "Año "
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Año "
        '
        'cboTracto
        '
        Me.cboTracto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cboTracto.BackColor = System.Drawing.Color.Transparent
        Me.cboTracto.Location = New System.Drawing.Point(765, 37)
        Me.cboTracto.Name = "cboTracto"
        Me.cboTracto.pRequerido = False
        Me.cboTracto.Size = New System.Drawing.Size(214, 21)
        Me.cboTracto.TabIndex = 121
        '
        'lblVehiculo
        '
        Me.lblVehiculo.Location = New System.Drawing.Point(706, 38)
        Me.lblVehiculo.Name = "lblVehiculo"
        Me.lblVehiculo.Size = New System.Drawing.Size(53, 19)
        Me.lblVehiculo.TabIndex = 120
        Me.lblVehiculo.Text = "Vehículo "
        Me.lblVehiculo.Values.ExtraText = ""
        Me.lblVehiculo.Values.Image = Nothing
        Me.lblVehiculo.Values.Text = "Vehículo "
        '
        'cmbPlanta
        '
        Me.cmbPlanta.BackColor = System.Drawing.Color.Transparent
        Me.cmbPlanta.CodigoCompania = ""
        Me.cmbPlanta.CodigoDivision = ""
        Me.cmbPlanta.CPLNDV_ANTERIOR = Nothing
        Me.cmbPlanta.DescripcionPlanta = ""
        Me.cmbPlanta.ItemTodos = False
        Me.cmbPlanta.Location = New System.Drawing.Point(765, 63)
        Me.cmbPlanta.MinimumSize = New System.Drawing.Size(150, 21)
        Me.cmbPlanta.Name = "cmbPlanta"
        Me.cmbPlanta.Planta = 0
        Me.cmbPlanta.PlantaDefault = -1
        Me.cmbPlanta.pRequerido = False
        Me.cmbPlanta.Size = New System.Drawing.Size(214, 21)
        Me.cmbPlanta.TabIndex = 118
        Me.cmbPlanta.Usuario = ""
        Me.cmbPlanta.Visible = False
        '
        'cmbDivision
        '
        Me.cmbDivision.BackColor = System.Drawing.Color.Transparent
        Me.cmbDivision.CDVSN_ANTERIOR = Nothing
        Me.cmbDivision.Compania = ""
        Me.cmbDivision.Division = Nothing
        Me.cmbDivision.DivisionDefault = Nothing
        Me.cmbDivision.DivisionDescripcion = Nothing
        Me.cmbDivision.ItemTodos = False
        Me.cmbDivision.Location = New System.Drawing.Point(430, 9)
        Me.cmbDivision.MinimumSize = New System.Drawing.Size(150, 21)
        Me.cmbDivision.Name = "cmbDivision"
        Me.cmbDivision.Size = New System.Drawing.Size(231, 21)
        Me.cmbDivision.TabIndex = 117
        Me.cmbDivision.Usuario = ""
        '
        'cmbCompania
        '
        Me.cmbCompania.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCompania.CCMPN_ANTERIOR = Nothing
        Me.cmbCompania.CCMPN_CodigoCompania = Nothing
        Me.cmbCompania.CCMPN_CompaniaDefault = Nothing
        Me.cmbCompania.CCMPN_Descripcion = Nothing
        Me.cmbCompania.Location = New System.Drawing.Point(84, 8)
        Me.cmbCompania.MinimumSize = New System.Drawing.Size(150, 23)
        Me.cmbCompania.Name = "cmbCompania"
        Me.cmbCompania.Size = New System.Drawing.Size(232, 23)
        Me.cmbCompania.TabIndex = 116
        Me.cmbCompania.Usuario = ""
        '
        'cboTransportista
        '
        Me.cboTransportista.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cboTransportista.BackColor = System.Drawing.Color.Transparent
        Me.cboTransportista.Location = New System.Drawing.Point(430, 37)
        Me.cboTransportista.Name = "cboTransportista"
        Me.cboTransportista.pNroRegPorPaginas = 0
        Me.cboTransportista.pRequerido = False
        Me.cboTransportista.Size = New System.Drawing.Size(231, 21)
        Me.cboTransportista.TabIndex = 115
        '
        'lblTransportista
        '
        Me.lblTransportista.Location = New System.Drawing.Point(326, 38)
        Me.lblTransportista.Name = "lblTransportista"
        Me.lblTransportista.Size = New System.Drawing.Size(75, 19)
        Me.lblTransportista.TabIndex = 114
        Me.lblTransportista.Text = "Transportista "
        Me.lblTransportista.Values.ExtraText = ""
        Me.lblTransportista.Values.Image = Nothing
        Me.lblTransportista.Values.Text = "Transportista "
        '
        'lblPlanta
        '
        Me.lblPlanta.Location = New System.Drawing.Point(706, 10)
        Me.lblPlanta.Name = "lblPlanta"
        Me.lblPlanta.Size = New System.Drawing.Size(41, 19)
        Me.lblPlanta.TabIndex = 110
        Me.lblPlanta.Text = "Planta "
        Me.lblPlanta.Values.ExtraText = ""
        Me.lblPlanta.Values.Image = Nothing
        Me.lblPlanta.Values.Text = "Planta "
        '
        'lblCompania
        '
        Me.lblCompania.Location = New System.Drawing.Point(16, 10)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(61, 19)
        Me.lblCompania.TabIndex = 106
        Me.lblCompania.Text = "Compañia "
        Me.lblCompania.Values.ExtraText = ""
        Me.lblCompania.Values.Image = Nothing
        Me.lblCompania.Values.Text = "Compañia "
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(326, 10)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(50, 19)
        Me.KryptonLabel1.TabIndex = 108
        Me.KryptonLabel1.Text = "División "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "División "
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.CCMPN = "EZ"
        Me.txtCliente.Location = New System.Drawing.Point(85, 37)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = False
        Me.txtCliente.pRequerido = False
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(231, 21)
        Me.txtCliente.TabIndex = 3
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.KryptonLabel5.Location = New System.Drawing.Point(16, 39)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(44, 17)
        Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.TabIndex = 105
        Me.KryptonLabel5.Text = "Cliente "
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Cliente "
        '
        'ControlVisorCliente
        '
        Me.ControlVisorCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlVisorCliente.Location = New System.Drawing.Point(0, 25)
        Me.ControlVisorCliente.Name = "ControlVisorCliente"
        Me.ControlVisorCliente.Size = New System.Drawing.Size(1077, 562)
        Me.ControlVisorCliente.TabIndex = 3
        '
        'chkcbxPlanta
        '
        Me.chkcbxPlanta.CheckOnClick = True
        Me.chkcbxPlanta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.chkcbxPlanta.DropDownHeight = 1
        Me.chkcbxPlanta.FormattingEnabled = True
        Me.chkcbxPlanta.IntegralHeight = False
        Me.chkcbxPlanta.Location = New System.Drawing.Point(765, 9)
        Me.chkcbxPlanta.Name = "chkcbxPlanta"
        Me.chkcbxPlanta.Size = New System.Drawing.Size(214, 21)
        Me.chkcbxPlanta.TabIndex = 128
        Me.chkcbxPlanta.ValueSeparator = ", "
        '
        'frmIndicadoresTransporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 732)
        Me.Controls.Add(Me.panel)
        Me.MinimumSize = New System.Drawing.Size(900, 480)
        Me.Name = "frmIndicadoresTransporte"
        Me.Text = "Indicadores de Transporte"
        CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.ResumeLayout(False)
        CType(Me.HeaderGroupTabs.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderGroupTabs.Panel.ResumeLayout(False)
        Me.HeaderGroupTabs.Panel.PerformLayout()
        CType(Me.HeaderGroupTabs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderGroupTabs.ResumeLayout(False)
        CType(Me.pbxBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        CType(Me.HeaderGroupFiltro.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderGroupFiltro.Panel.ResumeLayout(False)
        Me.HeaderGroupFiltro.Panel.PerformLayout()
        CType(Me.HeaderGroupFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderGroupFiltro.ResumeLayout(False)
        CType(Me.ndAnio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents HeaderGroupFiltro As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblPlanta As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCompania As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboTransportista As Ransa.Controls.Transportista.ucTransportista_TxtF01
    Friend WithEvents lblTransportista As ComponentFactory.Krypton.Toolkit.KryptonLabel

    Friend WithEvents cmbPlanta As Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Friend WithEvents cmbDivision As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Friend WithEvents cmbCompania As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents lblVehiculo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboTracto As Ransa.Controls.Transportista.ucTractoTransportista_TxtF01
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents HeaderGroupTabs As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnProcesarReporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents ControlVisorCliente As SOLMIN_ST.Control_Visor_Reporte
    Friend WithEvents pbxBuscar As System.Windows.Forms.PictureBox
    Friend WithEvents dbMes As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ndAnio As System.Windows.Forms.NumericUpDown
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonLabel32 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboMedioTransporte As System.Windows.Forms.ComboBox
    Friend WithEvents chkcbxPlanta As SOLMIN_ST.CheckComboBoxTest.CheckedComboBox


End Class
