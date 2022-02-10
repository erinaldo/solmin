<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarPersonal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsignarPersonal))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.MenuBar = New System.Windows.Forms.ToolStrip
        Me.btnSalir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        Me.TabContratista = New System.Windows.Forms.TabControl
        Me.TabDatosContratista = New System.Windows.Forms.TabPage
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.txtNroDiaRotacion = New SOLMIN_ST.TextField
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonBorderEdge4 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.cboGradoAcademico = New System.Windows.Forms.ComboBox
        Me.txtComunidad = New SOLMIN_ST.TextField
        Me.txtContratista = New Ransa.Controls.Proveedor.ucProveedor_TxtF01
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtClienteMnto = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.rbComunidadNo = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.KryptonLabel32 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.rbComunidadSI = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.dtpFechaIng = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel31 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtPuesto = New SOLMIN_ST.TextField
        Me.KryptonLabel16 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel17 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDireccion = New SOLMIN_ST.TextField
        Me.KryptonLabel18 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNacionalidad = New SOLMIN_ST.TextField
        Me.KryptonLabel19 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel20 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtApellido = New SOLMIN_ST.TextField
        Me.KryptonLabel21 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNombre = New SOLMIN_ST.TextField
        Me.KryptonLabel26 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cboTipoDocumento = New System.Windows.Forms.ComboBox
        Me.KryptonLabel27 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroDocumento = New SOLMIN_ST.TextField
        Me.KryptonLabel28 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel29 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel30 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
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
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        Me.TabContratista.SuspendLayout()
        Me.TabDatosContratista.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.MenuBar)
        Me.KryptonPanel.Controls.Add(Me.TabContratista)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(935, 341)
        Me.KryptonPanel.TabIndex = 0
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSalir, Me.ToolStripSeparator2, Me.btnGuardar})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(935, 25)
        Me.MenuBar.TabIndex = 0
        Me.MenuBar.Text = "ToolStrip1"
        '
        'btnSalir
        '
        Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalir.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(71, 22)
        Me.btnSalir.Text = "Cancelar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnGuardar
        '
        Me.btnGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGuardar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(69, 22)
        Me.btnGuardar.Text = "Guardar"
        '
        'TabContratista
        '
        Me.TabContratista.Controls.Add(Me.TabDatosContratista)
        Me.TabContratista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabContratista.Location = New System.Drawing.Point(0, 0)
        Me.TabContratista.Name = "TabContratista"
        Me.TabContratista.SelectedIndex = 0
        Me.TabContratista.Size = New System.Drawing.Size(935, 341)
        Me.TabContratista.TabIndex = 141
        '
        'TabDatosContratista
        '
        Me.TabDatosContratista.Controls.Add(Me.KryptonHeaderGroup1)
        Me.TabDatosContratista.ImageIndex = 3
        Me.TabDatosContratista.Location = New System.Drawing.Point(4, 22)
        Me.TabDatosContratista.Name = "TabDatosContratista"
        Me.TabDatosContratista.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDatosContratista.Size = New System.Drawing.Size(927, 315)
        Me.TabDatosContratista.TabIndex = 0
        Me.TabDatosContratista.Text = "Datos del Contratista"
        Me.TabDatosContratista.UseVisualStyleBackColor = True
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup1.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(3, 3)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtNroDiaRotacion)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonBorderEdge4)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cboGradoAcademico)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtComunidad)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtContratista)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtClienteMnto)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.rbComunidadNo)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel32)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.rbComunidadSI)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtpFechaIng)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel31)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtPuesto)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel16)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel17)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtDireccion)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel18)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtNacionalidad)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel19)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtpFechaNac)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel20)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtApellido)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel21)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtNombre)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel26)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cboTipoDocumento)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel27)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtNroDocumento)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel28)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel29)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel30)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(921, 309)
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.Text = "Heading"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup1.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = " "
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'txtNroDiaRotacion
        '
        Me.txtNroDiaRotacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroDiaRotacion.Location = New System.Drawing.Point(602, 229)
        Me.txtNroDiaRotacion.MaxLength = 4
        Me.txtNroDiaRotacion.Name = "txtNroDiaRotacion"
        Me.txtNroDiaRotacion.Size = New System.Drawing.Size(61, 21)
        Me.txtNroDiaRotacion.TabIndex = 19
        Me.txtNroDiaRotacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtNroDiaRotacion.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(483, 230)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(101, 19)
        Me.KryptonLabel2.TabIndex = 18
        Me.KryptonLabel2.Text = "Nro Dias Rotación "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Nro Dias Rotación "
        '
        'KryptonBorderEdge4
        '
        Me.KryptonBorderEdge4.Location = New System.Drawing.Point(459, 1)
        Me.KryptonBorderEdge4.Name = "KryptonBorderEdge4"
        Me.KryptonBorderEdge4.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge4.Size = New System.Drawing.Size(1, 310)
        Me.KryptonBorderEdge4.TabIndex = 7
        Me.KryptonBorderEdge4.Text = "KryptonBorderEdge4"
        '
        'cboGradoAcademico
        '
        Me.cboGradoAcademico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGradoAcademico.FormattingEnabled = True
        Me.cboGradoAcademico.Location = New System.Drawing.Point(601, 49)
        Me.cboGradoAcademico.Name = "cboGradoAcademico"
        Me.cboGradoAcademico.Size = New System.Drawing.Size(121, 21)
        Me.cboGradoAcademico.TabIndex = 12
        '
        'txtComunidad
        '
        Me.txtComunidad.AcceptsReturn = True
        Me.txtComunidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComunidad.Location = New System.Drawing.Point(602, 193)
        Me.txtComunidad.MaxLength = 30
        Me.txtComunidad.Name = "txtComunidad"
        Me.txtComunidad.Size = New System.Drawing.Size(235, 21)
        Me.txtComunidad.TabIndex = 16
        Me.txtComunidad.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'txtContratista
        '
        Me.txtContratista.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtContratista.BackColor = System.Drawing.Color.Transparent
        Me.txtContratista.Enabled = False
        Me.txtContratista.Location = New System.Drawing.Point(114, 50)
        Me.txtContratista.Name = "txtContratista"
        Me.txtContratista.pCodigo = CType(0, Long)
        Me.txtContratista.pMostarBtnNewProv = False
        Me.txtContratista.pRequerido = False
        Me.txtContratista.Size = New System.Drawing.Size(273, 21)
        Me.txtContratista.TabIndex = 4
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(483, 194)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(113, 19)
        Me.KryptonLabel5.TabIndex = 13
        Me.KryptonLabel5.Text = "Nombre Comunidad"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Nombre Comunidad"
        '
        'txtClienteMnto
        '
        Me.txtClienteMnto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtClienteMnto.BackColor = System.Drawing.Color.Transparent
        Me.txtClienteMnto.CCMPN = "EZ"
        Me.txtClienteMnto.Enabled = False
        Me.txtClienteMnto.Location = New System.Drawing.Point(114, 14)
        Me.txtClienteMnto.Name = "txtClienteMnto"
        Me.txtClienteMnto.pAccesoPorUsuario = False
        Me.txtClienteMnto.pRequerido = False
        Me.txtClienteMnto.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtClienteMnto.Size = New System.Drawing.Size(273, 21)
        Me.txtClienteMnto.TabIndex = 3
        '
        'rbComunidadNo
        '
        Me.rbComunidadNo.Checked = True
        Me.rbComunidadNo.Location = New System.Drawing.Point(647, 158)
        Me.rbComunidadNo.Name = "rbComunidadNo"
        Me.rbComunidadNo.Size = New System.Drawing.Size(39, 19)
        Me.rbComunidadNo.TabIndex = 0
        Me.rbComunidadNo.Text = "NO"
        Me.rbComunidadNo.Values.ExtraText = ""
        Me.rbComunidadNo.Values.Image = Nothing
        Me.rbComunidadNo.Values.Text = "NO"
        '
        'KryptonLabel32
        '
        Me.KryptonLabel32.Location = New System.Drawing.Point(483, 158)
        Me.KryptonLabel32.Name = "KryptonLabel32"
        Me.KryptonLabel32.Size = New System.Drawing.Size(103, 19)
        Me.KryptonLabel32.TabIndex = 12
        Me.KryptonLabel32.Text = "Comunidad Nativa"
        Me.KryptonLabel32.Values.ExtraText = ""
        Me.KryptonLabel32.Values.Image = Nothing
        Me.KryptonLabel32.Values.Text = "Comunidad Nativa"
        '
        'rbComunidadSI
        '
        Me.rbComunidadSI.Location = New System.Drawing.Point(601, 158)
        Me.rbComunidadSI.Name = "rbComunidadSI"
        Me.rbComunidadSI.Size = New System.Drawing.Size(31, 19)
        Me.rbComunidadSI.TabIndex = 15
        Me.rbComunidadSI.Text = "SI"
        Me.rbComunidadSI.Values.ExtraText = ""
        Me.rbComunidadSI.Values.Image = Nothing
        Me.rbComunidadSI.Values.Text = "SI"
        '
        'dtpFechaIng
        '
        Me.dtpFechaIng.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIng.Location = New System.Drawing.Point(601, 121)
        Me.dtpFechaIng.Name = "dtpFechaIng"
        Me.dtpFechaIng.Size = New System.Drawing.Size(95, 20)
        Me.dtpFechaIng.TabIndex = 14
        '
        'KryptonLabel31
        '
        Me.KryptonLabel31.Location = New System.Drawing.Point(483, 122)
        Me.KryptonLabel31.Name = "KryptonLabel31"
        Me.KryptonLabel31.Size = New System.Drawing.Size(95, 19)
        Me.KryptonLabel31.TabIndex = 11
        Me.KryptonLabel31.Text = "Fecha de Ingreso"
        Me.KryptonLabel31.Values.ExtraText = ""
        Me.KryptonLabel31.Values.Image = Nothing
        Me.KryptonLabel31.Values.Text = "Fecha de Ingreso"
        '
        'txtPuesto
        '
        Me.txtPuesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPuesto.Location = New System.Drawing.Point(601, 85)
        Me.txtPuesto.MaxLength = 15
        Me.txtPuesto.Name = "txtPuesto"
        Me.txtPuesto.Size = New System.Drawing.Size(121, 21)
        Me.txtPuesto.TabIndex = 13
        Me.txtPuesto.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'KryptonLabel16
        '
        Me.KryptonLabel16.Location = New System.Drawing.Point(483, 87)
        Me.KryptonLabel16.Name = "KryptonLabel16"
        Me.KryptonLabel16.Size = New System.Drawing.Size(44, 19)
        Me.KryptonLabel16.TabIndex = 10
        Me.KryptonLabel16.Text = "Puesto"
        Me.KryptonLabel16.Values.ExtraText = ""
        Me.KryptonLabel16.Values.Image = Nothing
        Me.KryptonLabel16.Values.Text = "Puesto"
        '
        'KryptonLabel17
        '
        Me.KryptonLabel17.Location = New System.Drawing.Point(483, 50)
        Me.KryptonLabel17.Name = "KryptonLabel17"
        Me.KryptonLabel17.Size = New System.Drawing.Size(99, 19)
        Me.KryptonLabel17.TabIndex = 14
        Me.KryptonLabel17.Text = "Grado Académico"
        Me.KryptonLabel17.Values.ExtraText = ""
        Me.KryptonLabel17.Values.Image = Nothing
        Me.KryptonLabel17.Values.Text = "Grado Académico"
        '
        'txtDireccion
        '
        Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion.Location = New System.Drawing.Point(598, 13)
        Me.txtDireccion.MaxLength = 50
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(304, 21)
        Me.txtDireccion.TabIndex = 11
        Me.txtDireccion.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'KryptonLabel18
        '
        Me.KryptonLabel18.Location = New System.Drawing.Point(483, 14)
        Me.KryptonLabel18.Name = "KryptonLabel18"
        Me.KryptonLabel18.Size = New System.Drawing.Size(57, 19)
        Me.KryptonLabel18.TabIndex = 9
        Me.KryptonLabel18.Text = "Dirección"
        Me.KryptonLabel18.Values.ExtraText = ""
        Me.KryptonLabel18.Values.Image = Nothing
        Me.KryptonLabel18.Values.Text = "Dirección"
        '
        'txtNacionalidad
        '
        Me.txtNacionalidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNacionalidad.Location = New System.Drawing.Point(113, 266)
        Me.txtNacionalidad.MaxLength = 15
        Me.txtNacionalidad.Name = "txtNacionalidad"
        Me.txtNacionalidad.Size = New System.Drawing.Size(121, 21)
        Me.txtNacionalidad.TabIndex = 10
        Me.txtNacionalidad.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'KryptonLabel19
        '
        Me.KryptonLabel19.Location = New System.Drawing.Point(10, 267)
        Me.KryptonLabel19.Name = "KryptonLabel19"
        Me.KryptonLabel19.Size = New System.Drawing.Size(76, 19)
        Me.KryptonLabel19.TabIndex = 8
        Me.KryptonLabel19.Text = "Nacionalidad"
        Me.KryptonLabel19.Values.ExtraText = ""
        Me.KryptonLabel19.Values.Image = Nothing
        Me.KryptonLabel19.Values.Text = "Nacionalidad"
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNac.Location = New System.Drawing.Point(114, 230)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(95, 20)
        Me.dtpFechaNac.TabIndex = 9
        '
        'KryptonLabel20
        '
        Me.KryptonLabel20.Location = New System.Drawing.Point(10, 231)
        Me.KryptonLabel20.Name = "KryptonLabel20"
        Me.KryptonLabel20.Size = New System.Drawing.Size(100, 19)
        Me.KryptonLabel20.TabIndex = 6
        Me.KryptonLabel20.Text = "Fecha Nacimiento"
        Me.KryptonLabel20.Values.ExtraText = ""
        Me.KryptonLabel20.Values.Image = Nothing
        Me.KryptonLabel20.Values.Text = "Fecha Nacimiento"
        '
        'txtApellido
        '
        Me.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellido.Location = New System.Drawing.Point(113, 194)
        Me.txtApellido.MaxLength = 50
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(282, 21)
        Me.txtApellido.TabIndex = 8
        Me.txtApellido.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'KryptonLabel21
        '
        Me.KryptonLabel21.Location = New System.Drawing.Point(10, 195)
        Me.KryptonLabel21.Name = "KryptonLabel21"
        Me.KryptonLabel21.Size = New System.Drawing.Size(52, 19)
        Me.KryptonLabel21.TabIndex = 5
        Me.KryptonLabel21.Text = "Apellido"
        Me.KryptonLabel21.Values.ExtraText = ""
        Me.KryptonLabel21.Values.Image = Nothing
        Me.KryptonLabel21.Values.Text = "Apellido"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(113, 158)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(283, 21)
        Me.txtNombre.TabIndex = 7
        Me.txtNombre.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'KryptonLabel26
        '
        Me.KryptonLabel26.Location = New System.Drawing.Point(10, 159)
        Me.KryptonLabel26.Name = "KryptonLabel26"
        Me.KryptonLabel26.Size = New System.Drawing.Size(52, 19)
        Me.KryptonLabel26.TabIndex = 4
        Me.KryptonLabel26.Text = "Nombre"
        Me.KryptonLabel26.Values.ExtraText = ""
        Me.KryptonLabel26.Values.Image = Nothing
        Me.KryptonLabel26.Values.Text = "Nombre"
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDocumento.FormattingEnabled = True
        Me.cboTipoDocumento.Location = New System.Drawing.Point(114, 86)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(121, 21)
        Me.cboTipoDocumento.TabIndex = 5
        '
        'KryptonLabel27
        '
        Me.KryptonLabel27.Location = New System.Drawing.Point(10, 87)
        Me.KryptonLabel27.Name = "KryptonLabel27"
        Me.KryptonLabel27.Size = New System.Drawing.Size(94, 19)
        Me.KryptonLabel27.TabIndex = 2
        Me.KryptonLabel27.Text = "Tipo Documento"
        Me.KryptonLabel27.Values.ExtraText = ""
        Me.KryptonLabel27.Values.Image = Nothing
        Me.KryptonLabel27.Values.Text = "Tipo Documento"
        '
        'txtNroDocumento
        '
        Me.txtNroDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroDocumento.Location = New System.Drawing.Point(114, 122)
        Me.txtNroDocumento.MaxLength = 15
        Me.txtNroDocumento.Name = "txtNroDocumento"
        Me.txtNroDocumento.Size = New System.Drawing.Size(121, 21)
        Me.txtNroDocumento.TabIndex = 6
        Me.txtNroDocumento.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'KryptonLabel28
        '
        Me.KryptonLabel28.Location = New System.Drawing.Point(10, 15)
        Me.KryptonLabel28.Name = "KryptonLabel28"
        Me.KryptonLabel28.Size = New System.Drawing.Size(45, 19)
        Me.KryptonLabel28.TabIndex = 0
        Me.KryptonLabel28.Text = "Cliente"
        Me.KryptonLabel28.Values.ExtraText = ""
        Me.KryptonLabel28.Values.Image = Nothing
        Me.KryptonLabel28.Values.Text = "Cliente"
        '
        'KryptonLabel29
        '
        Me.KryptonLabel29.Location = New System.Drawing.Point(10, 51)
        Me.KryptonLabel29.Name = "KryptonLabel29"
        Me.KryptonLabel29.Size = New System.Drawing.Size(65, 19)
        Me.KryptonLabel29.TabIndex = 17
        Me.KryptonLabel29.Text = "Contratista"
        Me.KryptonLabel29.Values.ExtraText = ""
        Me.KryptonLabel29.Values.Image = Nothing
        Me.KryptonLabel29.Values.Text = "Contratista"
        '
        'KryptonLabel30
        '
        Me.KryptonLabel30.Location = New System.Drawing.Point(10, 123)
        Me.KryptonLabel30.Name = "KryptonLabel30"
        Me.KryptonLabel30.Size = New System.Drawing.Size(91, 19)
        Me.KryptonLabel30.TabIndex = 3
        Me.KryptonLabel30.Text = "Nro Documento"
        Me.KryptonLabel30.Values.ExtraText = ""
        Me.KryptonLabel30.Values.Image = Nothing
        Me.KryptonLabel30.Values.Text = "Nro Documento"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CCLNT"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo Cliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CPRVCL"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Codigo Contratista"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TPDCPE"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tipo de Documento "
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NMDCPE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Numero Documento Persona  "
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NPLACP"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Placa Acoplado"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CBRCNT"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Brevete Conductor"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NOMCHOFER"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Nombre Conductor"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "FECINI"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Fec. Ini. Asignación"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "FECFIN"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Fec. Fin Asignación"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "SESTCM"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Estado Asignación"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "TOBS"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "FCHCRT"
        Me.DataGridViewTextBoxColumn12.HeaderText = "FCHCRT"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "HRACRT"
        Me.DataGridViewTextBoxColumn13.HeaderText = "HRACRT"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'frmAsignarPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 341)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAsignarPersonal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Asignación de Personal"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.TabContratista.ResumeLayout(False)
        Me.TabDatosContratista.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager



    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents txtContratista As Ransa.Controls.Proveedor.ucProveedor_TxtF01
    Friend WithEvents txtClienteMnto As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents TabContratista As System.Windows.Forms.TabControl
    Friend WithEvents TabDatosContratista As System.Windows.Forms.TabPage
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
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
    Friend WithEvents rbComunidadNo As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents KryptonLabel32 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents rbComunidadSI As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents dtpFechaIng As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel31 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPuesto As SOLMIN_ST.TextField
    Friend WithEvents KryptonLabel16 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel17 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDireccion As SOLMIN_ST.TextField
    Friend WithEvents KryptonLabel18 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNacionalidad As SOLMIN_ST.TextField
    Friend WithEvents KryptonLabel19 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel20 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtApellido As SOLMIN_ST.TextField
    Friend WithEvents KryptonLabel21 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNombre As SOLMIN_ST.TextField
    Friend WithEvents KryptonLabel26 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel27 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel28 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel29 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel30 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtComunidad As SOLMIN_ST.TextField
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboTipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents txtNroDocumento As SOLMIN_ST.TextField
    Friend WithEvents cboGradoAcademico As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonBorderEdge4 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtNroDiaRotacion As SOLMIN_ST.TextField
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
