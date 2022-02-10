<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarSolicitud
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarSolicitud))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.PanelBuscar = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.gwdDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.Numero_Solicitud = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre_Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tipo_Unidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Servicio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cantidad_Solicitada = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cantidad_Atender = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Destino = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Estado_Solicitud = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnProcesarConsulta = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnSeparador = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnSalir = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.checkFecha = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.rbTodos = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.rbPendiente = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroSolicitud = New SOLMIN_ST.TextField
        Me.dtpFechaCarga = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel20 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel19 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel17 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btn_cerrar = New System.Windows.Forms.Button
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.PanelBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelBuscar.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBuscar.Panel.SuspendLayout()
        Me.PanelBuscar.SuspendLayout()
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFiltros.Panel.SuspendLayout()
        Me.PanelFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.PanelBuscar)
        Me.KryptonPanel.Controls.Add(Me.PanelFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(822, 422)
        Me.KryptonPanel.TabIndex = 0
        '
        'PanelBuscar
        '
        Me.PanelBuscar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBuscar.Location = New System.Drawing.Point(0, 72)
        Me.PanelBuscar.Name = "PanelBuscar"
        '
        'PanelBuscar.Panel
        '
        Me.PanelBuscar.Panel.Controls.Add(Me.gwdDatos)
        Me.PanelBuscar.Size = New System.Drawing.Size(822, 350)
        Me.PanelBuscar.TabIndex = 8
        Me.PanelBuscar.ValuesPrimary.Description = ""
        Me.PanelBuscar.ValuesPrimary.Heading = ""
        Me.PanelBuscar.ValuesPrimary.Image = Nothing
        Me.PanelBuscar.ValuesSecondary.Description = ""
        Me.PanelBuscar.ValuesSecondary.Heading = ""
        Me.PanelBuscar.ValuesSecondary.Image = Nothing
        '
        'gwdDatos
        '
        Me.gwdDatos.AllowUserToAddRows = False
        Me.gwdDatos.AllowUserToDeleteRows = False
        Me.gwdDatos.AllowUserToOrderColumns = True
        Me.gwdDatos.AllowUserToResizeColumns = False
        Me.gwdDatos.AllowUserToResizeRows = False
        Me.gwdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gwdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gwdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gwdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Numero_Solicitud, Me.Cliente, Me.Nombre_Cliente, Me.Tipo_Unidad, Me.Servicio, Me.Cantidad_Solicitada, Me.Cantidad_Atender, Me.Destino, Me.Estado_Solicitud})
        Me.gwdDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gwdDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.gwdDatos.Location = New System.Drawing.Point(0, 0)
        Me.gwdDatos.MultiSelect = False
        Me.gwdDatos.Name = "gwdDatos"
        Me.gwdDatos.ReadOnly = True
        Me.gwdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gwdDatos.Size = New System.Drawing.Size(820, 342)
        Me.gwdDatos.StandardTab = True
        Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwdDatos.TabIndex = 8
        '
        'Numero_Solicitud
        '
        Me.Numero_Solicitud.DataPropertyName = "NCSOTR"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.Numero_Solicitud.DefaultCellStyle = DataGridViewCellStyle1
        Me.Numero_Solicitud.HeaderText = "N° Solicitud"
        Me.Numero_Solicitud.MaxInputLength = 15
        Me.Numero_Solicitud.Name = "Numero_Solicitud"
        Me.Numero_Solicitud.ReadOnly = True
        '
        'Cliente
        '
        Me.Cliente.DataPropertyName = "CCLNT"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.Cliente.DefaultCellStyle = DataGridViewCellStyle2
        Me.Cliente.HeaderText = "N° Cliente"
        Me.Cliente.MaxInputLength = 15
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        Me.Cliente.Visible = False
        '
        'Nombre_Cliente
        '
        Me.Nombre_Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Nombre_Cliente.DataPropertyName = "TCMPCL"
        Me.Nombre_Cliente.HeaderText = "Nombre Cliente"
        Me.Nombre_Cliente.MaxInputLength = 50
        Me.Nombre_Cliente.Name = "Nombre_Cliente"
        Me.Nombre_Cliente.ReadOnly = True
        Me.Nombre_Cliente.Width = 108
        '
        'Tipo_Unidad
        '
        Me.Tipo_Unidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Tipo_Unidad.DataPropertyName = "CUNDVH"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Tipo_Unidad.DefaultCellStyle = DataGridViewCellStyle3
        Me.Tipo_Unidad.HeaderText = "Tipo Carroceria"
        Me.Tipo_Unidad.MaxInputLength = 30
        Me.Tipo_Unidad.Name = "Tipo_Unidad"
        Me.Tipo_Unidad.ReadOnly = True
        Me.Tipo_Unidad.Width = 108
        '
        'Servicio
        '
        Me.Servicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Servicio.DataPropertyName = "CTPOSR"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Servicio.DefaultCellStyle = DataGridViewCellStyle4
        Me.Servicio.HeaderText = "Servicio"
        Me.Servicio.MaxInputLength = 30
        Me.Servicio.Name = "Servicio"
        Me.Servicio.ReadOnly = True
        Me.Servicio.Width = 74
        '
        'Cantidad_Solicitada
        '
        Me.Cantidad_Solicitada.DataPropertyName = "QSLCIT"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Cantidad_Solicitada.DefaultCellStyle = DataGridViewCellStyle5
        Me.Cantidad_Solicitada.HeaderText = "Unidades Solicitadas"
        Me.Cantidad_Solicitada.MaxInputLength = 8
        Me.Cantidad_Solicitada.Name = "Cantidad_Solicitada"
        Me.Cantidad_Solicitada.ReadOnly = True
        '
        'Cantidad_Atender
        '
        Me.Cantidad_Atender.DataPropertyName = "QATNDR"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.Cantidad_Atender.DefaultCellStyle = DataGridViewCellStyle6
        Me.Cantidad_Atender.HeaderText = "Unidades Asignadas"
        Me.Cantidad_Atender.MaxInputLength = 8
        Me.Cantidad_Atender.Name = "Cantidad_Atender"
        Me.Cantidad_Atender.ReadOnly = True
        '
        'Destino
        '
        Me.Destino.DataPropertyName = "CLCLDS"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Destino.DefaultCellStyle = DataGridViewCellStyle7
        Me.Destino.HeaderText = "Destino"
        Me.Destino.MaxInputLength = 30
        Me.Destino.Name = "Destino"
        Me.Destino.ReadOnly = True
        '
        'Estado_Solicitud
        '
        Me.Estado_Solicitud.DataPropertyName = "SESSLC"
        Me.Estado_Solicitud.HeaderText = "Estado"
        Me.Estado_Solicitud.MaxInputLength = 2
        Me.Estado_Solicitud.Name = "Estado_Solicitud"
        Me.Estado_Solicitud.ReadOnly = True
        '
        'PanelFiltros
        '
        Me.PanelFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnProcesarConsulta, Me.btnSeparador, Me.btnSalir})
        Me.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFiltros.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.PanelFiltros.HeaderVisiblePrimary = False
        Me.PanelFiltros.Location = New System.Drawing.Point(0, 0)
        Me.PanelFiltros.Name = "PanelFiltros"
        '
        'PanelFiltros.Panel
        '
        Me.PanelFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.PanelFiltros.Panel.Controls.Add(Me.checkFecha)
        Me.PanelFiltros.Panel.Controls.Add(Me.rbTodos)
        Me.PanelFiltros.Panel.Controls.Add(Me.rbPendiente)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.PanelFiltros.Panel.Controls.Add(Me.txtNroSolicitud)
        Me.PanelFiltros.Panel.Controls.Add(Me.dtpFechaCarga)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel20)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel19)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel17)
        Me.PanelFiltros.Panel.Controls.Add(Me.btn_cerrar)
        Me.PanelFiltros.Size = New System.Drawing.Size(822, 72)
        Me.PanelFiltros.TabIndex = 7
        Me.PanelFiltros.ValuesPrimary.Description = ""
        Me.PanelFiltros.ValuesPrimary.Heading = ""
        Me.PanelFiltros.ValuesPrimary.Image = Nothing
        Me.PanelFiltros.ValuesSecondary.Description = ""
        Me.PanelFiltros.ValuesSecondary.Heading = ""
        Me.PanelFiltros.ValuesSecondary.Image = Nothing
        '
        'btnProcesarConsulta
        '
        Me.btnProcesarConsulta.ExtraText = ""
        Me.btnProcesarConsulta.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnProcesarConsulta.Image = CType(resources.GetObject("btnProcesarConsulta.Image"), System.Drawing.Image)
        Me.btnProcesarConsulta.Text = "Busqueda"
        Me.btnProcesarConsulta.ToolTipImage = Nothing
        Me.btnProcesarConsulta.UniqueName = "1E7B5DC088DB4E1F1E7B5DC088DB4E1F"
        '
        'btnSeparador
        '
        Me.btnSeparador.ExtraText = ""
        Me.btnSeparador.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnSeparador.Image = Nothing
        Me.btnSeparador.Text = ".     "
        Me.btnSeparador.ToolTipImage = Nothing
        Me.btnSeparador.UniqueName = "B1A5439EC14B40F3B1A5439EC14B40F3"
        '
        'btnSalir
        '
        Me.btnSalir.ExtraText = ""
        Me.btnSalir.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnSalir.Image = Global.SOLMIN_ST.My.Resources.Resources._exit
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.ToolTipImage = Nothing
        Me.btnSalir.UniqueName = "E392EF4B74574DC4E392EF4B74574DC4"
        '
        'checkFecha
        '
        Me.checkFecha.Checked = False
        Me.checkFecha.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.checkFecha.Location = New System.Drawing.Point(571, 20)
        Me.checkFecha.Name = "checkFecha"
        Me.checkFecha.Size = New System.Drawing.Size(19, 13)
        Me.checkFecha.TabIndex = 3
        Me.checkFecha.Values.ExtraText = ""
        Me.checkFecha.Values.Image = Nothing
        Me.checkFecha.Values.Text = ""
        '
        'rbTodos
        '
        Me.rbTodos.Location = New System.Drawing.Point(737, 23)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(54, 16)
        Me.rbTodos.TabIndex = 6
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.Values.ExtraText = ""
        Me.rbTodos.Values.Image = Nothing
        Me.rbTodos.Values.Text = "Todos"
        '
        'rbPendiente
        '
        Me.rbPendiente.Checked = True
        Me.rbPendiente.Location = New System.Drawing.Point(736, 3)
        Me.rbPendiente.Name = "rbPendiente"
        Me.rbPendiente.Size = New System.Drawing.Size(73, 16)
        Me.rbPendiente.TabIndex = 5
        Me.rbPendiente.Text = "Pendiente"
        Me.rbPendiente.Values.ExtraText = ""
        Me.rbPendiente.Values.Image = Nothing
        Me.rbPendiente.Values.Text = "Pendiente"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(178, 17)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(46, 16)
        Me.KryptonLabel1.TabIndex = 100
        Me.KryptonLabel1.TabStop = False
        Me.KryptonLabel1.Text = "Cliente"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Cliente"
        '
        'txtNroSolicitud
        '
        Me.txtNroSolicitud.Location = New System.Drawing.Point(95, 17)
        Me.txtNroSolicitud.MaxLength = 10
        Me.txtNroSolicitud.Name = "txtNroSolicitud"
        Me.txtNroSolicitud.Size = New System.Drawing.Size(79, 19)
        Me.txtNroSolicitud.TabIndex = 1
        Me.txtNroSolicitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtNroSolicitud.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'dtpFechaCarga
        '
        Me.dtpFechaCarga.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaCarga.Enabled = False
        Me.dtpFechaCarga.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaCarga.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCarga.Location = New System.Drawing.Point(592, 15)
        Me.dtpFechaCarga.Name = "dtpFechaCarga"
        Me.dtpFechaCarga.Size = New System.Drawing.Size(88, 21)
        Me.dtpFechaCarga.TabIndex = 4
        '
        'KryptonLabel20
        '
        Me.KryptonLabel20.Location = New System.Drawing.Point(486, 17)
        Me.KryptonLabel20.Name = "KryptonLabel20"
        Me.KryptonLabel20.Size = New System.Drawing.Size(91, 16)
        Me.KryptonLabel20.TabIndex = 100
        Me.KryptonLabel20.TabStop = False
        Me.KryptonLabel20.Text = "Fecha de Carga"
        Me.KryptonLabel20.Values.ExtraText = ""
        Me.KryptonLabel20.Values.Image = Nothing
        Me.KryptonLabel20.Values.Text = "Fecha de Carga"
        '
        'KryptonLabel19
        '
        Me.KryptonLabel19.Location = New System.Drawing.Point(688, 15)
        Me.KryptonLabel19.Name = "KryptonLabel19"
        Me.KryptonLabel19.Size = New System.Drawing.Size(45, 16)
        Me.KryptonLabel19.TabIndex = 100
        Me.KryptonLabel19.TabStop = False
        Me.KryptonLabel19.Text = "Estado"
        Me.KryptonLabel19.Values.ExtraText = ""
        Me.KryptonLabel19.Values.Image = Nothing
        Me.KryptonLabel19.Values.Text = "Estado"
        '
        'KryptonLabel17
        '
        Me.KryptonLabel17.Location = New System.Drawing.Point(14, 18)
        Me.KryptonLabel17.Name = "KryptonLabel17"
        Me.KryptonLabel17.Size = New System.Drawing.Size(85, 16)
        Me.KryptonLabel17.TabIndex = 100
        Me.KryptonLabel17.TabStop = False
        Me.KryptonLabel17.Text = "N° de Solicitud"
        Me.KryptonLabel17.Values.ExtraText = ""
        Me.KryptonLabel17.Values.Image = Nothing
        Me.KryptonLabel17.Values.Text = "N° de Solicitud"
        '
        'btn_cerrar
        '
        Me.btn_cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cerrar.Location = New System.Drawing.Point(433, 20)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(16, 16)
        Me.btn_cerrar.TabIndex = 100
        Me.btn_cerrar.TabStop = False
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.Location = New System.Drawing.Point(230, 17)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = False
        Me.txtCliente.pRequerido = False
        Me.txtCliente.Size = New System.Drawing.Size(250, 19)
        Me.txtCliente.TabIndex = 101
        '
        'frmBuscarSolicitud
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelButton = Me.btn_cerrar
        Me.ClientSize = New System.Drawing.Size(822, 422)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBuscarSolicitud"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Busqueda de Solicitud"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.PanelBuscar.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBuscar.Panel.ResumeLayout(False)
        CType(Me.PanelBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBuscar.ResumeLayout(False)
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.Panel.ResumeLayout(False)
        Me.PanelFiltros.Panel.PerformLayout()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.ResumeLayout(False)
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
  Friend WithEvents PanelFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents btnProcesarConsulta As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents txtNroSolicitud As SOLMIN_ST.TextField
  Friend WithEvents dtpFechaCarga As System.Windows.Forms.DateTimePicker
  Friend WithEvents KryptonLabel20 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel19 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel17 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents btn_cerrar As System.Windows.Forms.Button
  Friend WithEvents PanelBuscar As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents gwdDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents rbPendiente As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
  Friend WithEvents rbTodos As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
  Friend WithEvents checkFecha As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents btnSeparador As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents Numero_Solicitud As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Nombre_Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Tipo_Unidad As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Servicio As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Cantidad_Solicitada As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Cantidad_Atender As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Destino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado_Solicitud As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
End Class
