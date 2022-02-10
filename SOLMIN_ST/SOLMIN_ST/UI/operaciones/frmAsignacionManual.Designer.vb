<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignacionManual
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
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cmbSegundoConductor = New Ransa.Controls.Transportista.ucConductorTransportista_TxtF01()
        Me.cmbConductor = New Ransa.Controls.Transportista.ucConductorTransportista_TxtF01()
        Me.dtpFechaAtencionServicio = New System.Windows.Forms.DateTimePicker()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.ckbOSAgenciaRansa = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.pnlAgenciasRansa = New System.Windows.Forms.GroupBox()
        Me.txtNroOperacionAgenciasRansa = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtOrdenServicioMineria = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnAsignarOSAgencias = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtOsAgenciasRansa = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.cboAcoplado = New Ransa.Controls.Transportista.ucAcopladoTransportista_TxtF01()
        Me.cboTracto = New Ransa.Controls.Transportista.ucTractoTransportista_TxtF01()
        Me.cboTransportista = New Ransa.Controls.Transportista.ucTransportista_TxtF01()
        Me.btnNuevoContudtor2 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnNuevoContudtor1 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnNuevoAcoplado = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnNuevoTracto = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnNuevoCia = New ComponentFactory.Krypton.Toolkit.KryptonButton()
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
        Me.tlsSeparador = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnVerPreAsignacionUnid = New System.Windows.Forms.ToolStripButton()
        Me.btnUnidProgramadas = New System.Windows.Forms.ToolStripButton()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.txtHoraInicio = New System.Windows.Forms.MaskedTextBox()
        CType(Me.hgReasignarRecurso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgReasignarRecurso.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgReasignarRecurso.Panel.SuspendLayout()
        Me.hgReasignarRecurso.SuspendLayout()
        Me.pnlAgenciasRansa.SuspendLayout()
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
        Me.lblConductor.Location = New System.Drawing.Point(7, 218)
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
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.txtHoraInicio)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.KryptonLabel5)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.cmbSegundoConductor)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.cmbConductor)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.dtpFechaAtencionServicio)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.KryptonLabel4)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.ckbOSAgenciaRansa)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.pnlAgenciasRansa)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.cboAcoplado)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.cboTracto)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.cboTransportista)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.btnNuevoContudtor2)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.btnNuevoContudtor1)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.btnNuevoAcoplado)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.btnNuevoTracto)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.btnNuevoCia)
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
        Me.hgReasignarRecurso.Size = New System.Drawing.Size(584, 488)
        Me.hgReasignarRecurso.TabIndex = 0
        Me.hgReasignarRecurso.Text = "    "
        Me.hgReasignarRecurso.ValuesPrimary.Description = ""
        Me.hgReasignarRecurso.ValuesPrimary.Heading = "    "
        Me.hgReasignarRecurso.ValuesPrimary.Image = Nothing
        Me.hgReasignarRecurso.ValuesSecondary.Description = ""
        Me.hgReasignarRecurso.ValuesSecondary.Heading = "     "
        Me.hgReasignarRecurso.ValuesSecondary.Image = Nothing
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(284, 76)
        Me.KryptonLabel5.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(148, 26)
        Me.KryptonLabel5.TabIndex = 164
        Me.KryptonLabel5.Text = "H. Atención Servicio"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "H. Atención Servicio"
        '
        'cmbSegundoConductor
        '
        Me.cmbSegundoConductor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmbSegundoConductor.BackColor = System.Drawing.Color.Transparent
        Me.cmbSegundoConductor.Location = New System.Drawing.Point(156, 249)
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
        Me.cmbConductor.Location = New System.Drawing.Point(156, 217)
        Me.cmbConductor.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbConductor.Name = "cmbConductor"
        Me.cmbConductor.pRequerido = False
        Me.cmbConductor.Size = New System.Drawing.Size(356, 26)
        Me.cmbConductor.TabIndex = 161
        '
        'dtpFechaAtencionServicio
        '
        Me.dtpFechaAtencionServicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAtencionServicio.Location = New System.Drawing.Point(159, 79)
        Me.dtpFechaAtencionServicio.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaAtencionServicio.Name = "dtpFechaAtencionServicio"
        Me.dtpFechaAtencionServicio.Size = New System.Drawing.Size(119, 22)
        Me.dtpFechaAtencionServicio.TabIndex = 160
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(8, 75)
        Me.KryptonLabel4.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(144, 26)
        Me.KryptonLabel4.TabIndex = 159
        Me.KryptonLabel4.Text = "F. Atención Servicio"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "F. Atención Servicio"
        '
        'ckbOSAgenciaRansa
        '
        Me.ckbOSAgenciaRansa.Checked = False
        Me.ckbOSAgenciaRansa.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.ckbOSAgenciaRansa.Location = New System.Drawing.Point(372, 282)
        Me.ckbOSAgenciaRansa.Margin = New System.Windows.Forms.Padding(4)
        Me.ckbOSAgenciaRansa.Name = "ckbOSAgenciaRansa"
        Me.ckbOSAgenciaRansa.Size = New System.Drawing.Size(188, 26)
        Me.ckbOSAgenciaRansa.TabIndex = 21
        Me.ckbOSAgenciaRansa.Text = "Órdenes Agencia Ransa"
        Me.ckbOSAgenciaRansa.Values.ExtraText = ""
        Me.ckbOSAgenciaRansa.Values.Image = Nothing
        Me.ckbOSAgenciaRansa.Values.Text = "Órdenes Agencia Ransa"
        '
        'pnlAgenciasRansa
        '
        Me.pnlAgenciasRansa.BackColor = System.Drawing.Color.Transparent
        Me.pnlAgenciasRansa.Controls.Add(Me.txtNroOperacionAgenciasRansa)
        Me.pnlAgenciasRansa.Controls.Add(Me.KryptonLabel3)
        Me.pnlAgenciasRansa.Controls.Add(Me.txtOrdenServicioMineria)
        Me.pnlAgenciasRansa.Controls.Add(Me.KryptonLabel1)
        Me.pnlAgenciasRansa.Controls.Add(Me.KryptonLabel2)
        Me.pnlAgenciasRansa.Controls.Add(Me.btnAsignarOSAgencias)
        Me.pnlAgenciasRansa.Controls.Add(Me.txtOsAgenciasRansa)
        Me.pnlAgenciasRansa.Location = New System.Drawing.Point(5, 306)
        Me.pnlAgenciasRansa.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlAgenciasRansa.Name = "pnlAgenciasRansa"
        Me.pnlAgenciasRansa.Padding = New System.Windows.Forms.Padding(4)
        Me.pnlAgenciasRansa.Size = New System.Drawing.Size(555, 118)
        Me.pnlAgenciasRansa.TabIndex = 22
        Me.pnlAgenciasRansa.TabStop = False
        Me.pnlAgenciasRansa.Text = "Orden de Servicio de Agencias Ransa"
        Me.pnlAgenciasRansa.Visible = False
        '
        'txtNroOperacionAgenciasRansa
        '
        Me.txtNroOperacionAgenciasRansa.Location = New System.Drawing.Point(197, 59)
        Me.txtNroOperacionAgenciasRansa.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroOperacionAgenciasRansa.Name = "txtNroOperacionAgenciasRansa"
        Me.txtNroOperacionAgenciasRansa.ReadOnly = True
        Me.txtNroOperacionAgenciasRansa.Size = New System.Drawing.Size(277, 26)
        Me.txtNroOperacionAgenciasRansa.TabIndex = 4
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(11, 94)
        Me.KryptonLabel3.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(160, 26)
        Me.KryptonLabel3.TabIndex = 5
        Me.KryptonLabel3.Text = "O/S Minería y Energía"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "O/S Minería y Energía"
        '
        'txtOrdenServicioMineria
        '
        Me.txtOrdenServicioMineria.Location = New System.Drawing.Point(197, 89)
        Me.txtOrdenServicioMineria.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOrdenServicioMineria.Name = "txtOrdenServicioMineria"
        Me.txtOrdenServicioMineria.ReadOnly = True
        Me.txtOrdenServicioMineria.Size = New System.Drawing.Size(277, 26)
        Me.txtOrdenServicioMineria.TabIndex = 6
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(11, 34)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(147, 26)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Text = "O/S Agencias Ransa"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "O/S Agencias Ransa"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(11, 64)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(184, 26)
        Me.KryptonLabel2.TabIndex = 3
        Me.KryptonLabel2.Text = "Nro Operacion Ag. Ransa"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Nro Operacion Ag. Ransa"
        '
        'btnAsignarOSAgencias
        '
        Me.btnAsignarOSAgencias.Location = New System.Drawing.Point(475, 30)
        Me.btnAsignarOSAgencias.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAsignarOSAgencias.Name = "btnAsignarOSAgencias"
        Me.btnAsignarOSAgencias.OverrideDefault.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.btnAsignarOSAgencias.Size = New System.Drawing.Size(32, 25)
        Me.btnAsignarOSAgencias.StateDisabled.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.btnAsignarOSAgencias.StateDisabled.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnAsignarOSAgencias.StateNormal.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.btnAsignarOSAgencias.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnAsignarOSAgencias.StatePressed.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.btnAsignarOSAgencias.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnAsignarOSAgencias.StateTracking.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.btnAsignarOSAgencias.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnAsignarOSAgencias.TabIndex = 2
        Me.btnAsignarOSAgencias.Values.ExtraText = ""
        Me.btnAsignarOSAgencias.Values.Image = Nothing
        Me.btnAsignarOSAgencias.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAsignarOSAgencias.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAsignarOSAgencias.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAsignarOSAgencias.Values.Text = ""
        '
        'txtOsAgenciasRansa
        '
        Me.txtOsAgenciasRansa.Location = New System.Drawing.Point(197, 30)
        Me.txtOsAgenciasRansa.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOsAgenciasRansa.Name = "txtOsAgenciasRansa"
        Me.txtOsAgenciasRansa.ReadOnly = True
        Me.txtOsAgenciasRansa.Size = New System.Drawing.Size(277, 26)
        Me.txtOsAgenciasRansa.TabIndex = 1
        '
        'cboAcoplado
        '
        Me.cboAcoplado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cboAcoplado.BackColor = System.Drawing.Color.Transparent
        Me.cboAcoplado.Location = New System.Drawing.Point(156, 184)
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
        Me.cboTracto.Location = New System.Drawing.Point(156, 152)
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
        Me.cboTransportista.Location = New System.Drawing.Point(156, 119)
        Me.cboTransportista.Margin = New System.Windows.Forms.Padding(5)
        Me.cboTransportista.Name = "cboTransportista"
        Me.cboTransportista.pNroRegPorPaginas = 0
        Me.cboTransportista.pRequerido = False
        Me.cboTransportista.Size = New System.Drawing.Size(356, 26)
        Me.cboTransportista.TabIndex = 7
        '
        'btnNuevoContudtor2
        '
        Me.btnNuevoContudtor2.Location = New System.Drawing.Point(515, 245)
        Me.btnNuevoContudtor2.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevoContudtor2.Name = "btnNuevoContudtor2"
        Me.btnNuevoContudtor2.OverrideDefault.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevoContudtor2.Size = New System.Drawing.Size(40, 31)
        Me.btnNuevoContudtor2.StateDisabled.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevoContudtor2.StateDisabled.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnNuevoContudtor2.StateNormal.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevoContudtor2.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnNuevoContudtor2.StatePressed.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevoContudtor2.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnNuevoContudtor2.StateTracking.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevoContudtor2.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnNuevoContudtor2.TabIndex = 20
        Me.btnNuevoContudtor2.Values.ExtraText = ""
        Me.btnNuevoContudtor2.Values.Image = Nothing
        Me.btnNuevoContudtor2.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnNuevoContudtor2.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnNuevoContudtor2.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnNuevoContudtor2.Values.Text = ""
        Me.btnNuevoContudtor2.Visible = False
        '
        'btnNuevoContudtor1
        '
        Me.btnNuevoContudtor1.Location = New System.Drawing.Point(515, 211)
        Me.btnNuevoContudtor1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevoContudtor1.Name = "btnNuevoContudtor1"
        Me.btnNuevoContudtor1.OverrideDefault.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevoContudtor1.Size = New System.Drawing.Size(40, 31)
        Me.btnNuevoContudtor1.StateDisabled.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevoContudtor1.StateDisabled.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnNuevoContudtor1.StateNormal.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevoContudtor1.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnNuevoContudtor1.StatePressed.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevoContudtor1.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnNuevoContudtor1.StateTracking.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevoContudtor1.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnNuevoContudtor1.TabIndex = 17
        Me.btnNuevoContudtor1.Values.ExtraText = ""
        Me.btnNuevoContudtor1.Values.Image = Nothing
        Me.btnNuevoContudtor1.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnNuevoContudtor1.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnNuevoContudtor1.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnNuevoContudtor1.Values.Text = ""
        Me.btnNuevoContudtor1.Visible = False
        '
        'btnNuevoAcoplado
        '
        Me.btnNuevoAcoplado.Location = New System.Drawing.Point(515, 179)
        Me.btnNuevoAcoplado.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevoAcoplado.Name = "btnNuevoAcoplado"
        Me.btnNuevoAcoplado.OverrideDefault.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevoAcoplado.Size = New System.Drawing.Size(40, 31)
        Me.btnNuevoAcoplado.StateDisabled.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevoAcoplado.StateDisabled.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnNuevoAcoplado.StateNormal.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevoAcoplado.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnNuevoAcoplado.StatePressed.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevoAcoplado.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnNuevoAcoplado.StateTracking.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevoAcoplado.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnNuevoAcoplado.TabIndex = 14
        Me.btnNuevoAcoplado.Values.ExtraText = ""
        Me.btnNuevoAcoplado.Values.Image = Nothing
        Me.btnNuevoAcoplado.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnNuevoAcoplado.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnNuevoAcoplado.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnNuevoAcoplado.Values.Text = ""
        Me.btnNuevoAcoplado.Visible = False
        '
        'btnNuevoTracto
        '
        Me.btnNuevoTracto.Location = New System.Drawing.Point(516, 144)
        Me.btnNuevoTracto.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevoTracto.Name = "btnNuevoTracto"
        Me.btnNuevoTracto.OverrideDefault.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevoTracto.Size = New System.Drawing.Size(40, 31)
        Me.btnNuevoTracto.StateDisabled.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevoTracto.StateDisabled.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnNuevoTracto.StateNormal.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevoTracto.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnNuevoTracto.StatePressed.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevoTracto.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnNuevoTracto.StateTracking.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevoTracto.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnNuevoTracto.TabIndex = 11
        Me.btnNuevoTracto.Values.ExtraText = ""
        Me.btnNuevoTracto.Values.Image = Nothing
        Me.btnNuevoTracto.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnNuevoTracto.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnNuevoTracto.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnNuevoTracto.Values.Text = ""
        Me.btnNuevoTracto.Visible = False
        '
        'btnNuevoCia
        '
        Me.btnNuevoCia.Location = New System.Drawing.Point(515, 112)
        Me.btnNuevoCia.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevoCia.Name = "btnNuevoCia"
        Me.btnNuevoCia.OverrideDefault.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevoCia.Size = New System.Drawing.Size(40, 31)
        Me.btnNuevoCia.StateDisabled.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevoCia.StateDisabled.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnNuevoCia.StateNormal.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevoCia.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnNuevoCia.StatePressed.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevoCia.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnNuevoCia.StateTracking.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevoCia.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnNuevoCia.TabIndex = 8
        Me.btnNuevoCia.Values.ExtraText = ""
        Me.btnNuevoCia.Values.Image = Nothing
        Me.btnNuevoCia.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnNuevoCia.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnNuevoCia.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnNuevoCia.Values.Text = ""
        Me.btnNuevoCia.Visible = False
        '
        'lblSegundoConductor
        '
        Me.lblSegundoConductor.Location = New System.Drawing.Point(7, 252)
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
        Me.lblAcoplado.Location = New System.Drawing.Point(7, 188)
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
        Me.lblTracto.Location = New System.Drawing.Point(7, 153)
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
        Me.lblTransportista.Location = New System.Drawing.Point(7, 119)
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
        Me.beSeparador.Location = New System.Drawing.Point(9, 109)
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
        Me.tlsBarraHerramienta.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnProcesar, Me.tlsSeparador, Me.btnCancelar, Me.ToolStripSeparator1, Me.btnVerPreAsignacionUnid, Me.btnUnidProgramadas})
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
        'btnVerPreAsignacionUnid
        '
        Me.btnVerPreAsignacionUnid.Image = Global.SOLMIN_ST.My.Resources.Resources.ark_selectall
        Me.btnVerPreAsignacionUnid.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnVerPreAsignacionUnid.Name = "btnVerPreAsignacionUnid"
        Me.btnVerPreAsignacionUnid.Size = New System.Drawing.Size(245, 24)
        Me.btnVerPreAsignacionUnid.Text = "Ver Pre-Asignación de Unidades"
        Me.btnVerPreAsignacionUnid.Visible = False
        '
        'btnUnidProgramadas
        '
        Me.btnUnidProgramadas.Image = Global.SOLMIN_ST.My.Resources.Resources.ark_selectall
        Me.btnUnidProgramadas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUnidProgramadas.Name = "btnUnidProgramadas"
        Me.btnUnidProgramadas.Size = New System.Drawing.Size(212, 24)
        Me.btnUnidProgramadas.Text = "Ver Unidades Programadas"
        Me.btnUnidProgramadas.Visible = False
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.hgReasignarRecurso)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(584, 488)
        Me.KryptonPanel.TabIndex = 3
        '
        'txtHoraInicio
        '
        Me.txtHoraInicio.Location = New System.Drawing.Point(435, 77)
        Me.txtHoraInicio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHoraInicio.Mask = "00:00"
        Me.txtHoraInicio.Name = "txtHoraInicio"
        Me.txtHoraInicio.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txtHoraInicio.Size = New System.Drawing.Size(88, 22)
        Me.txtHoraInicio.TabIndex = 165
        Me.txtHoraInicio.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'frmAsignacionManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 488)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(727, 666)
        Me.MinimumSize = New System.Drawing.Size(581, 334)
        Me.Name = "frmAsignacionManual"
        Me.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignación Manual"
        CType(Me.hgReasignarRecurso.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgReasignarRecurso.Panel.ResumeLayout(False)
        Me.hgReasignarRecurso.Panel.PerformLayout()
        CType(Me.hgReasignarRecurso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgReasignarRecurso.ResumeLayout(False)
        Me.pnlAgenciasRansa.ResumeLayout(False)
        Me.pnlAgenciasRansa.PerformLayout()
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
    Friend WithEvents tlsSeparador As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents lblSegundoConductor As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnNuevoCia As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnNuevoContudtor2 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnNuevoContudtor1 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnNuevoAcoplado As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnNuevoTracto As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cboTransportista As Ransa.Controls.Transportista.ucTransportista_TxtF01
    Friend WithEvents cboTracto As Ransa.Controls.Transportista.ucTractoTransportista_TxtF01
    Friend WithEvents cboAcoplado As Ransa.Controls.Transportista.ucAcopladoTransportista_TxtF01
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnAsignarOSAgencias As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtOsAgenciasRansa As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents pnlAgenciasRansa As System.Windows.Forms.GroupBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtOrdenServicioMineria As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtNroOperacionAgenciasRansa As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ckbOSAgenciaRansa As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaAtencionServicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnVerPreAsignacionUnid As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnUnidProgramadas As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbSegundoConductor As Ransa.Controls.Transportista.ucConductorTransportista_TxtF01
    Friend WithEvents cmbConductor As Ransa.Controls.Transportista.ucConductorTransportista_TxtF01
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtHoraInicio As System.Windows.Forms.MaskedTextBox
End Class
