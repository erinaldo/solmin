<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGPSWAP
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
    Me.TabControl1 = New System.Windows.Forms.TabControl
    Me.TABWAP = New System.Windows.Forms.TabPage
    Me.gwdDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.ORDEN = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CICLO = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.NPLCTR = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.NCOEVT = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.TNMEV = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.FRGTRO = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.HRGTRO = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.TOBS = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CULUSA = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.TABGPS = New System.Windows.Forms.TabPage
    Me.gwdDatosGPS = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.NCSOTR = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.NCRRSR = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.NPLCTR_GPS = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.FECGPS_S = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.FECGPS = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.HORA = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.HORA_S = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.GPSLAT = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.GPSLON = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.KMSVEL = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.MenuBar = New System.Windows.Forms.ToolStrip
    Me.btnNuevo = New System.Windows.Forms.ToolStripButton
    Me.Separator1 = New System.Windows.Forms.ToolStripSeparator
    Me.btnModificar = New System.Windows.Forms.ToolStripButton
    Me.Separator2 = New System.Windows.Forms.ToolStripSeparator
    Me.btnEliminar = New System.Windows.Forms.ToolStripButton
    Me.btnAsignar = New System.Windows.Forms.ToolStripButton
    Me.Separator3 = New System.Windows.Forms.ToolStripSeparator
    Me.btnReiniciarCiclo = New System.Windows.Forms.ToolStripButton
    Me.btnSalir = New System.Windows.Forms.ToolStripButton
    Me.Separator4 = New System.Windows.Forms.ToolStripSeparator
    Me.btnImportar = New System.Windows.Forms.ToolStripButton
    Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
    Me.txtCiclo = New System.Windows.Forms.TextBox
    Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtCorrelativo = New System.Windows.Forms.TextBox
    Me.txtSolicitud = New System.Windows.Forms.TextBox
    Me.txtUnidad = New System.Windows.Forms.TextBox
    Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    Me.TabControl1.SuspendLayout()
    Me.TABWAP.SuspendLayout()
    CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TABGPS.SuspendLayout()
    CType(Me.gwdDatosGPS, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.MenuBar.SuspendLayout()
    CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonGroup1.Panel.SuspendLayout()
    Me.KryptonGroup1.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.TabControl1)
    Me.KryptonPanel.Controls.Add(Me.MenuBar)
    Me.KryptonPanel.Controls.Add(Me.KryptonGroup1)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(706, 506)
    Me.KryptonPanel.TabIndex = 0
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TABWAP)
    Me.TabControl1.Controls.Add(Me.TABGPS)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(0, 73)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(706, 433)
    Me.TabControl1.TabIndex = 7
    '
    'TABWAP
    '
    Me.TABWAP.Controls.Add(Me.gwdDatos)
    Me.TABWAP.Location = New System.Drawing.Point(4, 22)
    Me.TABWAP.Name = "TABWAP"
    Me.TABWAP.Padding = New System.Windows.Forms.Padding(3)
    Me.TABWAP.Size = New System.Drawing.Size(698, 407)
    Me.TABWAP.TabIndex = 0
    Me.TABWAP.Text = "WAP"
    Me.TABWAP.UseVisualStyleBackColor = True
    '
    'gwdDatos
    '
    Me.gwdDatos.AllowUserToAddRows = False
    Me.gwdDatos.AllowUserToDeleteRows = False
    Me.gwdDatos.AllowUserToOrderColumns = True
    Me.gwdDatos.AllowUserToResizeColumns = False
    Me.gwdDatos.AllowUserToResizeRows = False
    Me.gwdDatos.ColumnHeadersHeight = 30
    Me.gwdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ORDEN, Me.CICLO, Me.NPLCTR, Me.NCOEVT, Me.TNMEV, Me.FRGTRO, Me.HRGTRO, Me.TOBS, Me.CULUSA})
    Me.gwdDatos.Dock = System.Windows.Forms.DockStyle.Fill
    Me.gwdDatos.Location = New System.Drawing.Point(3, 3)
    Me.gwdDatos.Name = "gwdDatos"
    Me.gwdDatos.ReadOnly = True
    Me.gwdDatos.RowHeadersVisible = False
    Me.gwdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.gwdDatos.Size = New System.Drawing.Size(692, 401)
    Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.gwdDatos.TabIndex = 9
    '
    'ORDEN
    '
    Me.ORDEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ORDEN.HeaderText = "Item"
    Me.ORDEN.Name = "ORDEN"
    Me.ORDEN.ReadOnly = True
    Me.ORDEN.Width = 58
    '
    'CICLO
    '
    Me.CICLO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.CICLO.DataPropertyName = "CICLO"
    Me.CICLO.HeaderText = "N° Ciclo"
    Me.CICLO.Name = "CICLO"
    Me.CICLO.ReadOnly = True
    Me.CICLO.Visible = False
    '
    'NPLCTR
    '
    Me.NPLCTR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.NPLCTR.DataPropertyName = "NPLCTR"
    Me.NPLCTR.HeaderText = "Tracto"
    Me.NPLCTR.Name = "NPLCTR"
    Me.NPLCTR.ReadOnly = True
    Me.NPLCTR.Visible = False
    '
    'NCOEVT
    '
    Me.NCOEVT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.NCOEVT.HeaderText = "Cod. Evento"
    Me.NCOEVT.Name = "NCOEVT"
    Me.NCOEVT.ReadOnly = True
    Me.NCOEVT.Visible = False
    '
    'TNMEV
    '
    Me.TNMEV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.TNMEV.DataPropertyName = "TNMEV"
    Me.TNMEV.HeaderText = "Nombre Evento"
    Me.TNMEV.Name = "TNMEV"
    Me.TNMEV.ReadOnly = True
    '
    'FRGTRO
    '
    Me.FRGTRO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.FRGTRO.DataPropertyName = "FRGTRO"
    Me.FRGTRO.HeaderText = "Fecha Registro"
    Me.FRGTRO.Name = "FRGTRO"
    Me.FRGTRO.ReadOnly = True
    '
    'HRGTRO
    '
    Me.HRGTRO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.HRGTRO.DataPropertyName = "HRGTRO"
    Me.HRGTRO.HeaderText = "Hora Registro"
    Me.HRGTRO.Name = "HRGTRO"
    Me.HRGTRO.ReadOnly = True
    '
    'TOBS
    '
    Me.TOBS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.TOBS.DataPropertyName = "TOBS"
    Me.TOBS.HeaderText = "Observación"
    Me.TOBS.Name = "TOBS"
    Me.TOBS.ReadOnly = True
    '
    'CULUSA
    '
    Me.CULUSA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.CULUSA.DataPropertyName = "CULUSA"
    Me.CULUSA.HeaderText = "Auditoría"
    Me.CULUSA.Name = "CULUSA"
    Me.CULUSA.ReadOnly = True
    '
    'TABGPS
    '
    Me.TABGPS.Controls.Add(Me.gwdDatosGPS)
    Me.TABGPS.Location = New System.Drawing.Point(4, 22)
    Me.TABGPS.Name = "TABGPS"
    Me.TABGPS.Padding = New System.Windows.Forms.Padding(3)
    Me.TABGPS.Size = New System.Drawing.Size(698, 407)
    Me.TABGPS.TabIndex = 1
    Me.TABGPS.Text = "GPS"
    Me.TABGPS.UseVisualStyleBackColor = True
    '
    'gwdDatosGPS
    '
    Me.gwdDatosGPS.AllowUserToAddRows = False
    Me.gwdDatosGPS.AllowUserToDeleteRows = False
    Me.gwdDatosGPS.AllowUserToResizeColumns = False
    Me.gwdDatosGPS.AllowUserToResizeRows = False
    Me.gwdDatosGPS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.gwdDatosGPS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NCSOTR, Me.NCRRSR, Me.NPLCTR_GPS, Me.FECGPS_S, Me.FECGPS, Me.HORA, Me.HORA_S, Me.GPSLAT, Me.GPSLON, Me.KMSVEL})
    Me.gwdDatosGPS.Dock = System.Windows.Forms.DockStyle.Fill
    Me.gwdDatosGPS.Location = New System.Drawing.Point(3, 3)
    Me.gwdDatosGPS.Name = "gwdDatosGPS"
    Me.gwdDatosGPS.ReadOnly = True
    Me.gwdDatosGPS.RowHeadersVisible = False
    Me.gwdDatosGPS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.gwdDatosGPS.Size = New System.Drawing.Size(692, 401)
    Me.gwdDatosGPS.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.gwdDatosGPS.TabIndex = 0
    '
    'NCSOTR
    '
    Me.NCSOTR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.NCSOTR.DataPropertyName = "NCSOTR"
    Me.NCSOTR.HeaderText = "N° Solicitud"
    Me.NCSOTR.Name = "NCSOTR"
    Me.NCSOTR.ReadOnly = True
    Me.NCSOTR.Visible = False
    '
    'NCRRSR
    '
    Me.NCRRSR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.NCRRSR.DataPropertyName = "NCRRSR"
    Me.NCRRSR.HeaderText = "N° Correlativo"
    Me.NCRRSR.Name = "NCRRSR"
    Me.NCRRSR.ReadOnly = True
    Me.NCRRSR.Visible = False
    '
    'NPLCTR_GPS
    '
    Me.NPLCTR_GPS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.NPLCTR_GPS.DataPropertyName = "NPLCTR"
    Me.NPLCTR_GPS.HeaderText = "Vehículo"
    Me.NPLCTR_GPS.Name = "NPLCTR_GPS"
    Me.NPLCTR_GPS.ReadOnly = True
    Me.NPLCTR_GPS.Visible = False
    '
    'FECGPS_S
    '
    Me.FECGPS_S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.FECGPS_S.DataPropertyName = "FECGPS_S"
    Me.FECGPS_S.HeaderText = "Fecha GPS"
    Me.FECGPS_S.Name = "FECGPS_S"
    Me.FECGPS_S.ReadOnly = True
    '
    'FECGPS
    '
    Me.FECGPS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.FECGPS.DataPropertyName = "FECGPS"
    Me.FECGPS.HeaderText = "Fecha"
    Me.FECGPS.Name = "FECGPS"
    Me.FECGPS.ReadOnly = True
    Me.FECGPS.Visible = False
    '
    'HORA
    '
    Me.HORA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.HORA.DataPropertyName = "HORA"
    Me.HORA.HeaderText = "Hora"
    Me.HORA.Name = "HORA"
    Me.HORA.ReadOnly = True
    Me.HORA.Visible = False
    '
    'HORA_S
    '
    Me.HORA_S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.HORA_S.DataPropertyName = "HORA_S"
    Me.HORA_S.HeaderText = "Hora"
    Me.HORA_S.Name = "HORA_S"
    Me.HORA_S.ReadOnly = True
    '
    'GPSLAT
    '
    Me.GPSLAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.GPSLAT.DataPropertyName = "GPSLAT"
    Me.GPSLAT.HeaderText = "Latitud"
    Me.GPSLAT.Name = "GPSLAT"
    Me.GPSLAT.ReadOnly = True
    '
    'GPSLON
    '
    Me.GPSLON.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.GPSLON.DataPropertyName = "GPSLON"
    Me.GPSLON.HeaderText = "Longitud"
    Me.GPSLON.Name = "GPSLON"
    Me.GPSLON.ReadOnly = True
    '
    'KMSVEL
    '
    Me.KMSVEL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.KMSVEL.DataPropertyName = "KMSVEL"
    Me.KMSVEL.HeaderText = "Velocidad"
    Me.KMSVEL.Name = "KMSVEL"
    Me.KMSVEL.ReadOnly = True
    '
    'MenuBar
    '
    Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.Separator1, Me.btnModificar, Me.Separator2, Me.btnEliminar, Me.btnAsignar, Me.Separator3, Me.btnReiniciarCiclo, Me.btnSalir, Me.Separator4, Me.btnImportar})
    Me.MenuBar.Location = New System.Drawing.Point(0, 48)
    Me.MenuBar.Name = "MenuBar"
    Me.MenuBar.Size = New System.Drawing.Size(706, 25)
    Me.MenuBar.TabIndex = 6
    Me.MenuBar.TabStop = True
    '
    'btnNuevo
    '
    Me.btnNuevo.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
    Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnNuevo.Name = "btnNuevo"
    Me.btnNuevo.Size = New System.Drawing.Size(66, 22)
    Me.btnNuevo.Text = "Asignar"
    '
    'Separator1
    '
    Me.Separator1.Name = "Separator1"
    Me.Separator1.Size = New System.Drawing.Size(6, 25)
    '
    'btnModificar
    '
    Me.btnModificar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
    Me.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnModificar.Name = "btnModificar"
    Me.btnModificar.Size = New System.Drawing.Size(57, 22)
    Me.btnModificar.Text = "Editar"
    '
    'Separator2
    '
    Me.Separator2.Name = "Separator2"
    Me.Separator2.Size = New System.Drawing.Size(6, 25)
    '
    'btnEliminar
    '
    Me.btnEliminar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
    Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnEliminar.Name = "btnEliminar"
    Me.btnEliminar.Size = New System.Drawing.Size(68, 22)
    Me.btnEliminar.Text = "Eliminar"
    '
    'btnAsignar
    '
    Me.btnAsignar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
    Me.btnAsignar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnAsignar.Name = "btnAsignar"
    Me.btnAsignar.Size = New System.Drawing.Size(66, 22)
    Me.btnAsignar.Text = "Asignar"
    '
    'Separator3
    '
    Me.Separator3.Name = "Separator3"
    Me.Separator3.Size = New System.Drawing.Size(6, 25)
    '
    'btnReiniciarCiclo
    '
    Me.btnReiniciarCiclo.Image = Global.SOLMIN_ST.My.Resources.Resources.runprog
    Me.btnReiniciarCiclo.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnReiniciarCiclo.Name = "btnReiniciarCiclo"
    Me.btnReiniciarCiclo.Size = New System.Drawing.Size(99, 22)
    Me.btnReiniciarCiclo.Text = "Reiniciar Ciclo"
    '
    'btnSalir
    '
    Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnSalir.Image = Global.SOLMIN_ST.My.Resources.Resources._exit
    Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnSalir.Name = "btnSalir"
    Me.btnSalir.Size = New System.Drawing.Size(49, 22)
    Me.btnSalir.Text = "Salir"
    '
    'Separator4
    '
    Me.Separator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.Separator4.Name = "Separator4"
    Me.Separator4.Size = New System.Drawing.Size(6, 25)
    '
    'btnImportar
    '
    Me.btnImportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnImportar.Image = Global.SOLMIN_ST.My.Resources.Resources.images__2_
    Me.btnImportar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnImportar.Name = "btnImportar"
    Me.btnImportar.Size = New System.Drawing.Size(71, 22)
    Me.btnImportar.Text = "Importar"
    '
    'KryptonGroup1
    '
    Me.KryptonGroup1.Dock = System.Windows.Forms.DockStyle.Top
    Me.KryptonGroup1.Location = New System.Drawing.Point(0, 0)
    Me.KryptonGroup1.Name = "KryptonGroup1"
    '
    'KryptonGroup1.Panel
    '
    Me.KryptonGroup1.Panel.Controls.Add(Me.txtCiclo)
    Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel4)
    Me.KryptonGroup1.Panel.Controls.Add(Me.txtCorrelativo)
    Me.KryptonGroup1.Panel.Controls.Add(Me.txtSolicitud)
    Me.KryptonGroup1.Panel.Controls.Add(Me.txtUnidad)
    Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel3)
    Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel2)
    Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel1)
    Me.KryptonGroup1.Size = New System.Drawing.Size(706, 48)
    Me.KryptonGroup1.TabIndex = 5
    '
    'txtCiclo
    '
    Me.txtCiclo.Location = New System.Drawing.Point(514, 10)
    Me.txtCiclo.Name = "txtCiclo"
    Me.txtCiclo.Size = New System.Drawing.Size(85, 20)
    Me.txtCiclo.TabIndex = 7
    '
    'KryptonLabel4
    '
    Me.KryptonLabel4.Location = New System.Drawing.Point(471, 10)
    Me.KryptonLabel4.Name = "KryptonLabel4"
    Me.KryptonLabel4.Size = New System.Drawing.Size(37, 19)
    Me.KryptonLabel4.TabIndex = 6
    Me.KryptonLabel4.Text = "Ciclo:"
    Me.KryptonLabel4.Values.ExtraText = ""
    Me.KryptonLabel4.Values.Image = Nothing
    Me.KryptonLabel4.Values.Text = "Ciclo:"
    '
    'txtCorrelativo
    '
    Me.txtCorrelativo.Location = New System.Drawing.Point(393, 10)
    Me.txtCorrelativo.Name = "txtCorrelativo"
    Me.txtCorrelativo.Size = New System.Drawing.Size(72, 20)
    Me.txtCorrelativo.TabIndex = 5
    '
    'txtSolicitud
    '
    Me.txtSolicitud.Location = New System.Drawing.Point(222, 11)
    Me.txtSolicitud.Name = "txtSolicitud"
    Me.txtSolicitud.Size = New System.Drawing.Size(92, 20)
    Me.txtSolicitud.TabIndex = 4
    '
    'txtUnidad
    '
    Me.txtUnidad.Location = New System.Drawing.Point(38, 12)
    Me.txtUnidad.Name = "txtUnidad"
    Me.txtUnidad.Size = New System.Drawing.Size(100, 20)
    Me.txtUnidad.TabIndex = 3
    '
    'KryptonLabel3
    '
    Me.KryptonLabel3.Location = New System.Drawing.Point(320, 11)
    Me.KryptonLabel3.Name = "KryptonLabel3"
    Me.KryptonLabel3.Size = New System.Drawing.Size(67, 19)
    Me.KryptonLabel3.TabIndex = 2
    Me.KryptonLabel3.Text = "Correlativo:"
    Me.KryptonLabel3.Values.ExtraText = ""
    Me.KryptonLabel3.Values.Image = Nothing
    Me.KryptonLabel3.Values.Text = "Correlativo:"
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(144, 11)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(72, 19)
    Me.KryptonLabel2.TabIndex = 1
    Me.KryptonLabel2.Text = "N° Solicitud:"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "N° Solicitud:"
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(3, 13)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(38, 19)
    Me.KryptonLabel1.TabIndex = 0
    Me.KryptonLabel1.Text = "Placa:"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Placa:"
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn1.DataPropertyName = "CICLO"
    Me.DataGridViewTextBoxColumn1.HeaderText = "N° Ciclo"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    Me.DataGridViewTextBoxColumn1.ReadOnly = True
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn2.DataPropertyName = "NPLCTR"
    Me.DataGridViewTextBoxColumn2.HeaderText = "Tracto"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    Me.DataGridViewTextBoxColumn2.ReadOnly = True
    '
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn3.HeaderText = "Cod. Evento"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    Me.DataGridViewTextBoxColumn3.ReadOnly = True
    Me.DataGridViewTextBoxColumn3.Visible = False
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn4.DataPropertyName = "TNMEV"
    Me.DataGridViewTextBoxColumn4.HeaderText = "Nombre Evento"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    Me.DataGridViewTextBoxColumn4.ReadOnly = True
    '
    'DataGridViewTextBoxColumn5
    '
    Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn5.DataPropertyName = "FRGTRO"
    Me.DataGridViewTextBoxColumn5.HeaderText = "Fecha Registro"
    Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
    Me.DataGridViewTextBoxColumn5.ReadOnly = True
    '
    'DataGridViewTextBoxColumn6
    '
    Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn6.DataPropertyName = "HRGTRO"
    Me.DataGridViewTextBoxColumn6.HeaderText = "Hora Registro"
    Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
    Me.DataGridViewTextBoxColumn6.ReadOnly = True
    '
    'DataGridViewTextBoxColumn7
    '
    Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn7.DataPropertyName = "TOBS"
    Me.DataGridViewTextBoxColumn7.HeaderText = "Observación"
    Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
    Me.DataGridViewTextBoxColumn7.ReadOnly = True
    '
    'DataGridViewTextBoxColumn8
    '
    Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn8.DataPropertyName = "CULUSA"
    Me.DataGridViewTextBoxColumn8.HeaderText = "Auditoría"
    Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
    Me.DataGridViewTextBoxColumn8.ReadOnly = True
    '
    'DataGridViewTextBoxColumn9
    '
    Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn9.DataPropertyName = "NCSOTR"
    Me.DataGridViewTextBoxColumn9.HeaderText = "N° Solicitud"
    Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
    Me.DataGridViewTextBoxColumn9.ReadOnly = True
    Me.DataGridViewTextBoxColumn9.Visible = False
    '
    'DataGridViewTextBoxColumn10
    '
    Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn10.DataPropertyName = "NCRRSR"
    Me.DataGridViewTextBoxColumn10.HeaderText = "N° Correlativo"
    Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
    Me.DataGridViewTextBoxColumn10.ReadOnly = True
    Me.DataGridViewTextBoxColumn10.Visible = False
    '
    'DataGridViewTextBoxColumn11
    '
    Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn11.DataPropertyName = "NPLCTR"
    Me.DataGridViewTextBoxColumn11.HeaderText = "Vehículo"
    Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
    Me.DataGridViewTextBoxColumn11.ReadOnly = True
    Me.DataGridViewTextBoxColumn11.Visible = False
    '
    'DataGridViewTextBoxColumn12
    '
    Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn12.DataPropertyName = "FECGPS_S"
    Me.DataGridViewTextBoxColumn12.HeaderText = "Fecha GPS"
    Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
    Me.DataGridViewTextBoxColumn12.ReadOnly = True
    '
    'DataGridViewTextBoxColumn13
    '
    Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn13.DataPropertyName = "FECGPS"
    Me.DataGridViewTextBoxColumn13.HeaderText = "Fecha"
    Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
    Me.DataGridViewTextBoxColumn13.ReadOnly = True
    Me.DataGridViewTextBoxColumn13.Visible = False
    '
    'DataGridViewTextBoxColumn14
    '
    Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn14.DataPropertyName = "HORA"
    Me.DataGridViewTextBoxColumn14.HeaderText = "Hora"
    Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
    Me.DataGridViewTextBoxColumn14.ReadOnly = True
    Me.DataGridViewTextBoxColumn14.Visible = False
    '
    'DataGridViewTextBoxColumn15
    '
    Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn15.DataPropertyName = "HORA_S"
    Me.DataGridViewTextBoxColumn15.HeaderText = "Hora"
    Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
    Me.DataGridViewTextBoxColumn15.ReadOnly = True
    '
    'DataGridViewTextBoxColumn16
    '
    Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn16.DataPropertyName = "GPSLAT"
    Me.DataGridViewTextBoxColumn16.HeaderText = "Latitud"
    Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
    Me.DataGridViewTextBoxColumn16.ReadOnly = True
    '
    'DataGridViewTextBoxColumn17
    '
    Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn17.DataPropertyName = "GPSLON"
    Me.DataGridViewTextBoxColumn17.HeaderText = "Longitud"
    Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
    Me.DataGridViewTextBoxColumn17.ReadOnly = True
    '
    'DataGridViewTextBoxColumn18
    '
    Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn18.DataPropertyName = "KMSVEL"
    Me.DataGridViewTextBoxColumn18.HeaderText = "Velocidad"
    Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
    Me.DataGridViewTextBoxColumn18.ReadOnly = True
    '
    'frmGPSWAP
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(706, 506)
    Me.ControlBox = False
    Me.Controls.Add(Me.KryptonPanel)
    Me.MaximizeBox = False
    Me.MaximumSize = New System.Drawing.Size(714, 540)
    Me.MinimizeBox = False
    Me.MinimumSize = New System.Drawing.Size(714, 540)
    Me.Name = "frmGPSWAP"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "WAP - GPS"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    Me.KryptonPanel.PerformLayout()
    Me.TabControl1.ResumeLayout(False)
    Me.TABWAP.ResumeLayout(False)
    CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TABGPS.ResumeLayout(False)
    CType(Me.gwdDatosGPS, System.ComponentModel.ISupportInitialize).EndInit()
    Me.MenuBar.ResumeLayout(False)
    Me.MenuBar.PerformLayout()
    CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonGroup1.Panel.ResumeLayout(False)
    Me.KryptonGroup1.Panel.PerformLayout()
    CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonGroup1.ResumeLayout(False)
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
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAsignar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnReiniciarCiclo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents txtCorrelativo As System.Windows.Forms.TextBox
    Friend WithEvents txtSolicitud As System.Windows.Forms.TextBox
    Friend WithEvents txtUnidad As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TABWAP As System.Windows.Forms.TabPage
    Friend WithEvents gwdDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents TABGPS As System.Windows.Forms.TabPage
    Friend WithEvents gwdDatosGPS As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents NCSOTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCRRSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLCTR_GPS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECGPS_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECGPS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORA_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GPSLAT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GPSLON As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KMSVEL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCiclo As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ORDEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CICLO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLCTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCOEVT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TNMEV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FRGTRO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HRGTRO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOBS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CULUSA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Separator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Separator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Separator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Separator4 As System.Windows.Forms.ToolStripSeparator
End Class
