<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevoConductor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuevoConductor))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.HeaderDatos = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.imgConductor = New System.Windows.Forms.PictureBox
        Me.chkTercero = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.txtDatObservaciones = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpDatFecVencLic = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpDatFecIng = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpDatFecEmLic = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpDatFecVencDNI = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonBorderEdge6 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonBorderEdge5 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.CboTipoLicenciaConducir = New CodeTextBox.CodeTextBox
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNombres = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtApellidoPaterno = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtApellidoMaterno = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtDni = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtSeguroSocial = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel36 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtGrupoSanguineo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtDatRPM = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtDatDireccion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel34 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel35 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDatCodSAP = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel29 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel32 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel31 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel33 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel30 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.MenuBar = New System.Windows.Forms.ToolStrip
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnModificar = New System.Windows.Forms.ToolStripButton
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.btnSalir = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.txtCodigoBrevete = New SOLMIN_ST.TextField
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderDatos.Panel.SuspendLayout()
        Me.HeaderDatos.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.imgConductor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.HeaderDatos)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(844, 331)
        Me.KryptonPanel.TabIndex = 0
        '
        'HeaderDatos
        '
        Me.HeaderDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderDatos.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HeaderDatos.HeaderVisibleSecondary = False
        Me.HeaderDatos.Location = New System.Drawing.Point(0, 0)
        Me.HeaderDatos.Name = "HeaderDatos"
        '
        'HeaderDatos.Panel
        '
        Me.HeaderDatos.Panel.Controls.Add(Me.Panel1)
        Me.HeaderDatos.Panel.Controls.Add(Me.MenuBar)
        Me.HeaderDatos.Size = New System.Drawing.Size(844, 331)
        Me.HeaderDatos.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.HeaderDatos.StateNormal.HeaderPrimary.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.HeaderDatos.StateNormal.HeaderPrimary.Content.LongText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeaderDatos.TabIndex = 5
        Me.HeaderDatos.Text = "Información del Conductor"
        Me.HeaderDatos.ValuesPrimary.Description = ""
        Me.HeaderDatos.ValuesPrimary.Heading = "Información del Conductor"
        Me.HeaderDatos.ValuesPrimary.Image = Nothing
        Me.HeaderDatos.ValuesSecondary.Description = ""
        Me.HeaderDatos.ValuesSecondary.Heading = "Description"
        Me.HeaderDatos.ValuesSecondary.Image = Nothing
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.chkTercero)
        Me.Panel1.Controls.Add(Me.txtDatObservaciones)
        Me.Panel1.Controls.Add(Me.KryptonLabel2)
        Me.Panel1.Controls.Add(Me.dtpDatFecVencLic)
        Me.Panel1.Controls.Add(Me.KryptonLabel3)
        Me.Panel1.Controls.Add(Me.dtpDatFecIng)
        Me.Panel1.Controls.Add(Me.KryptonLabel4)
        Me.Panel1.Controls.Add(Me.dtpDatFecEmLic)
        Me.Panel1.Controls.Add(Me.KryptonLabel5)
        Me.Panel1.Controls.Add(Me.dtpDatFecVencDNI)
        Me.Panel1.Controls.Add(Me.KryptonLabel6)
        Me.Panel1.Controls.Add(Me.KryptonBorderEdge6)
        Me.Panel1.Controls.Add(Me.KryptonLabel7)
        Me.Panel1.Controls.Add(Me.KryptonBorderEdge5)
        Me.Panel1.Controls.Add(Me.CboTipoLicenciaConducir)
        Me.Panel1.Controls.Add(Me.KryptonLabel8)
        Me.Panel1.Controls.Add(Me.txtNombres)
        Me.Panel1.Controls.Add(Me.txtApellidoPaterno)
        Me.Panel1.Controls.Add(Me.txtApellidoMaterno)
        Me.Panel1.Controls.Add(Me.txtDni)
        Me.Panel1.Controls.Add(Me.txtSeguroSocial)
        Me.Panel1.Controls.Add(Me.KryptonLabel36)
        Me.Panel1.Controls.Add(Me.txtGrupoSanguineo)
        Me.Panel1.Controls.Add(Me.txtDatRPM)
        Me.Panel1.Controls.Add(Me.txtCodigoBrevete)
        Me.Panel1.Controls.Add(Me.txtDatDireccion)
        Me.Panel1.Controls.Add(Me.KryptonLabel1)
        Me.Panel1.Controls.Add(Me.KryptonLabel34)
        Me.Panel1.Controls.Add(Me.KryptonLabel35)
        Me.Panel1.Controls.Add(Me.txtDatCodSAP)
        Me.Panel1.Controls.Add(Me.KryptonLabel29)
        Me.Panel1.Controls.Add(Me.KryptonLabel32)
        Me.Panel1.Controls.Add(Me.KryptonLabel31)
        Me.Panel1.Controls.Add(Me.KryptonLabel33)
        Me.Panel1.Controls.Add(Me.KryptonLabel30)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(842, 281)
        Me.Panel1.TabIndex = 120
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.KryptonPanel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(673, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(169, 281)
        Me.Panel2.TabIndex = 121
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.KryptonButton1)
        Me.KryptonPanel1.Controls.Add(Me.imgConductor)
        Me.KryptonPanel1.Location = New System.Drawing.Point(13, 6)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(145, 193)
        Me.KryptonPanel1.TabIndex = 0
        '
        'KryptonButton1
        '
        Me.KryptonButton1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonButton1.Location = New System.Drawing.Point(0, 169)
        Me.KryptonButton1.Name = "KryptonButton1"
        Me.KryptonButton1.Size = New System.Drawing.Size(145, 24)
        Me.KryptonButton1.TabIndex = 0
        Me.KryptonButton1.Text = "Escoja Imagen"
        Me.KryptonButton1.Values.ExtraText = ""
        Me.KryptonButton1.Values.Image = Nothing
        Me.KryptonButton1.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.KryptonButton1.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.KryptonButton1.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.KryptonButton1.Values.Text = "Escoja Imagen"
        '
        'imgConductor
        '
        Me.imgConductor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgConductor.Location = New System.Drawing.Point(6, 6)
        Me.imgConductor.Name = "imgConductor"
        Me.imgConductor.Size = New System.Drawing.Size(134, 160)
        Me.imgConductor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgConductor.TabIndex = 118
        Me.imgConductor.TabStop = False
        '
        'chkTercero
        '
        Me.chkTercero.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTercero.Enabled = False
        Me.chkTercero.Location = New System.Drawing.Point(592, 8)
        Me.chkTercero.Name = "chkTercero"
        Me.chkTercero.Size = New System.Drawing.Size(79, 22)
        Me.chkTercero.TabIndex = 15
        Me.chkTercero.Text = "Es Tercero"
        Me.chkTercero.Values.ExtraText = ""
        Me.chkTercero.Values.Image = Nothing
        Me.chkTercero.Values.Text = "Es Tercero"
        '
        'txtDatObservaciones
        '
        Me.txtDatObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDatObservaciones.Location = New System.Drawing.Point(353, 165)
        Me.txtDatObservaciones.MaxLength = 250
        Me.txtDatObservaciones.Multiline = True
        Me.txtDatObservaciones.Name = "txtDatObservaciones"
        Me.txtDatObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDatObservaciones.Size = New System.Drawing.Size(307, 58)
        Me.txtDatObservaciones.TabIndex = 17
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(6, 146)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(64, 22)
        Me.KryptonLabel2.TabIndex = 67
        Me.KryptonLabel2.Text = "Nombres:"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Nombres:"
        '
        'dtpDatFecVencLic
        '
        Me.dtpDatFecVencLic.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDatFecVencLic.Location = New System.Drawing.Point(115, 67)
        Me.dtpDatFecVencLic.Name = "dtpDatFecVencLic"
        Me.dtpDatFecVencLic.Size = New System.Drawing.Size(89, 20)
        Me.dtpDatFecVencLic.TabIndex = 2
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(6, 94)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(104, 22)
        Me.KryptonLabel3.TabIndex = 64
        Me.KryptonLabel3.Text = "Apellido Paterno:"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Apellido Paterno:"
        '
        'dtpDatFecIng
        '
        Me.dtpDatFecIng.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDatFecIng.Location = New System.Drawing.Point(477, 8)
        Me.dtpDatFecIng.Name = "dtpDatFecIng"
        Me.dtpDatFecIng.Size = New System.Drawing.Size(89, 20)
        Me.dtpDatFecIng.TabIndex = 10
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(6, 123)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(108, 22)
        Me.KryptonLabel4.TabIndex = 65
        Me.KryptonLabel4.Text = "Apellido Materno:"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Apellido Materno:"
        '
        'dtpDatFecEmLic
        '
        Me.dtpDatFecEmLic.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDatFecEmLic.Location = New System.Drawing.Point(115, 40)
        Me.dtpDatFecEmLic.Name = "dtpDatFecEmLic"
        Me.dtpDatFecEmLic.Size = New System.Drawing.Size(89, 20)
        Me.dtpDatFecEmLic.TabIndex = 1
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(6, 175)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(40, 22)
        Me.KryptonLabel5.TabIndex = 72
        Me.KryptonLabel5.Text = "D.N.I:"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "D.N.I:"
        '
        'dtpDatFecVencDNI
        '
        Me.dtpDatFecVencDNI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDatFecVencDNI.Location = New System.Drawing.Point(115, 200)
        Me.dtpDatFecVencDNI.Name = "dtpDatFecVencDNI"
        Me.dtpDatFecVencDNI.Size = New System.Drawing.Size(89, 20)
        Me.dtpDatFecVencDNI.TabIndex = 7
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(353, 91)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(87, 22)
        Me.KryptonLabel6.TabIndex = 74
        Me.KryptonLabel6.Text = "Seguro Social:"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Seguro Social:"
        '
        'KryptonBorderEdge6
        '
        Me.KryptonBorderEdge6.Location = New System.Drawing.Point(676, 3)
        Me.KryptonBorderEdge6.Name = "KryptonBorderEdge6"
        Me.KryptonBorderEdge6.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge6.Size = New System.Drawing.Size(1, 280)
        Me.KryptonBorderEdge6.TabIndex = 117
        Me.KryptonBorderEdge6.Text = "KryptonBorderEdge6"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(353, 117)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(107, 22)
        Me.KryptonLabel7.TabIndex = 76
        Me.KryptonLabel7.Text = "Grupo sanguíneo:"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Grupo sanguíneo:"
        '
        'KryptonBorderEdge5
        '
        Me.KryptonBorderEdge5.Location = New System.Drawing.Point(333, 6)
        Me.KryptonBorderEdge5.Name = "KryptonBorderEdge5"
        Me.KryptonBorderEdge5.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge5.Size = New System.Drawing.Size(1, 280)
        Me.KryptonBorderEdge5.TabIndex = 116
        Me.KryptonBorderEdge5.Text = "KryptonBorderEdge5"
        '
        'CboTipoLicenciaConducir
        '
        Me.CboTipoLicenciaConducir.Codigo = ""
        Me.CboTipoLicenciaConducir.ControlHeight = 23
        Me.CboTipoLicenciaConducir.ControlImage = True
        Me.CboTipoLicenciaConducir.ControlReadOnly = True
        Me.CboTipoLicenciaConducir.Descripcion = ""
        Me.CboTipoLicenciaConducir.DisplayColumnVisible = True
        Me.CboTipoLicenciaConducir.DisplayMember = ""
        Me.CboTipoLicenciaConducir.KeyColumnWidth = 100
        Me.CboTipoLicenciaConducir.KeyField = ""
        Me.CboTipoLicenciaConducir.KeySearch = True
        Me.CboTipoLicenciaConducir.Location = New System.Drawing.Point(115, 228)
        Me.CboTipoLicenciaConducir.Name = "CboTipoLicenciaConducir"
        Me.CboTipoLicenciaConducir.Size = New System.Drawing.Size(203, 23)
        Me.CboTipoLicenciaConducir.TabIndex = 8
        Me.CboTipoLicenciaConducir.TextBackColor = System.Drawing.Color.White
        Me.CboTipoLicenciaConducir.TextForeColor = System.Drawing.Color.Empty
        Me.CboTipoLicenciaConducir.ValueColumnVisible = True
        Me.CboTipoLicenciaConducir.ValueColumnWidth = 600
        Me.CboTipoLicenciaConducir.ValueField = ""
        Me.CboTipoLicenciaConducir.ValueMember = ""
        Me.CboTipoLicenciaConducir.ValueSearch = True
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(6, 232)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(112, 22)
        Me.KryptonLabel8.TabIndex = 79
        Me.KryptonLabel8.Text = "Tipo de Licencia C:"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Tipo de Licencia C:"
        '
        'txtNombres
        '
        Me.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombres.Location = New System.Drawing.Point(115, 145)
        Me.txtNombres.MaxLength = 20
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(202, 22)
        Me.txtNombres.TabIndex = 5
        '
        'txtApellidoPaterno
        '
        Me.txtApellidoPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(115, 92)
        Me.txtApellidoPaterno.MaxLength = 16
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(202, 22)
        Me.txtApellidoPaterno.TabIndex = 3
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(115, 120)
        Me.txtApellidoMaterno.MaxLength = 16
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(202, 22)
        Me.txtApellidoMaterno.TabIndex = 4
        '
        'txtDni
        '
        Me.txtDni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDni.Location = New System.Drawing.Point(115, 175)
        Me.txtDni.MaxLength = 8
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(202, 22)
        Me.txtDni.TabIndex = 6
        '
        'txtSeguroSocial
        '
        Me.txtSeguroSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSeguroSocial.Location = New System.Drawing.Point(477, 88)
        Me.txtSeguroSocial.MaxLength = 15
        Me.txtSeguroSocial.Name = "txtSeguroSocial"
        Me.txtSeguroSocial.Size = New System.Drawing.Size(133, 22)
        Me.txtSeguroSocial.TabIndex = 13
        '
        'KryptonLabel36
        '
        Me.KryptonLabel36.Location = New System.Drawing.Point(353, 143)
        Me.KryptonLabel36.Name = "KryptonLabel36"
        Me.KryptonLabel36.Size = New System.Drawing.Size(93, 22)
        Me.KryptonLabel36.TabIndex = 16
        Me.KryptonLabel36.Text = "Observaciones:"
        Me.KryptonLabel36.Values.ExtraText = ""
        Me.KryptonLabel36.Values.Image = Nothing
        Me.KryptonLabel36.Values.Text = "Observaciones:"
        '
        'txtGrupoSanguineo
        '
        Me.txtGrupoSanguineo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGrupoSanguineo.Location = New System.Drawing.Point(477, 115)
        Me.txtGrupoSanguineo.MaxLength = 5
        Me.txtGrupoSanguineo.Name = "txtGrupoSanguineo"
        Me.txtGrupoSanguineo.Size = New System.Drawing.Size(133, 22)
        Me.txtGrupoSanguineo.TabIndex = 14
        '
        'txtDatRPM
        '
        Me.txtDatRPM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDatRPM.Location = New System.Drawing.Point(477, 62)
        Me.txtDatRPM.MaxLength = 12
        Me.txtDatRPM.Name = "txtDatRPM"
        Me.txtDatRPM.Size = New System.Drawing.Size(133, 22)
        Me.txtDatRPM.TabIndex = 12
        '
        'txtDatDireccion
        '
        Me.txtDatDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDatDireccion.Location = New System.Drawing.Point(477, 36)
        Me.txtDatDireccion.MaxLength = 45
        Me.txtDatDireccion.Name = "txtDatDireccion"
        Me.txtDatDireccion.Size = New System.Drawing.Size(193, 22)
        Me.txtDatDireccion.TabIndex = 11
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(6, 15)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(54, 22)
        Me.KryptonLabel1.TabIndex = 90
        Me.KryptonLabel1.Text = "Brevete:"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Brevete:"
        '
        'KryptonLabel34
        '
        Me.KryptonLabel34.Location = New System.Drawing.Point(353, 65)
        Me.KryptonLabel34.Name = "KryptonLabel34"
        Me.KryptonLabel34.Size = New System.Drawing.Size(125, 22)
        Me.KryptonLabel34.TabIndex = 106
        Me.KryptonLabel34.Text = "N° Teléfono / RPM   :"
        Me.KryptonLabel34.Values.ExtraText = ""
        Me.KryptonLabel34.Values.Image = Nothing
        Me.KryptonLabel34.Values.Text = "N° Teléfono / RPM   :"
        '
        'KryptonLabel35
        '
        Me.KryptonLabel35.Location = New System.Drawing.Point(353, 39)
        Me.KryptonLabel35.Name = "KryptonLabel35"
        Me.KryptonLabel35.Size = New System.Drawing.Size(64, 22)
        Me.KryptonLabel35.TabIndex = 105
        Me.KryptonLabel35.Text = "Dirección:"
        Me.KryptonLabel35.Values.ExtraText = ""
        Me.KryptonLabel35.Values.Image = Nothing
        Me.KryptonLabel35.Values.Text = "Dirección:"
        '
        'txtDatCodSAP
        '
        Me.txtDatCodSAP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDatCodSAP.Location = New System.Drawing.Point(115, 257)
        Me.txtDatCodSAP.MaxLength = 8
        Me.txtDatCodSAP.Name = "txtDatCodSAP"
        Me.txtDatCodSAP.Size = New System.Drawing.Size(202, 22)
        Me.txtDatCodSAP.TabIndex = 9
        Me.txtDatCodSAP.Visible = False
        '
        'KryptonLabel29
        '
        Me.KryptonLabel29.Location = New System.Drawing.Point(6, 202)
        Me.KryptonLabel29.Name = "KryptonLabel29"
        Me.KryptonLabel29.Size = New System.Drawing.Size(102, 22)
        Me.KryptonLabel29.TabIndex = 94
        Me.KryptonLabel29.Text = "Fecha Venc. DNI:"
        Me.KryptonLabel29.Values.ExtraText = ""
        Me.KryptonLabel29.Values.Image = Nothing
        Me.KryptonLabel29.Values.Text = "Fecha Venc. DNI:"
        '
        'KryptonLabel32
        '
        Me.KryptonLabel32.Location = New System.Drawing.Point(353, 13)
        Me.KryptonLabel32.Name = "KryptonLabel32"
        Me.KryptonLabel32.Size = New System.Drawing.Size(89, 22)
        Me.KryptonLabel32.TabIndex = 102
        Me.KryptonLabel32.Text = "Fecha Ingreso:"
        Me.KryptonLabel32.Values.ExtraText = ""
        Me.KryptonLabel32.Values.Image = Nothing
        Me.KryptonLabel32.Values.Text = "Fecha Ingreso:"
        '
        'KryptonLabel31
        '
        Me.KryptonLabel31.Location = New System.Drawing.Point(6, 40)
        Me.KryptonLabel31.Name = "KryptonLabel31"
        Me.KryptonLabel31.Size = New System.Drawing.Size(102, 22)
        Me.KryptonLabel31.TabIndex = 97
        Me.KryptonLabel31.Text = "Emisión Licencia:"
        Me.KryptonLabel31.Values.ExtraText = ""
        Me.KryptonLabel31.Values.Image = Nothing
        Me.KryptonLabel31.Values.Text = "Emisión Licencia:"
        '
        'KryptonLabel33
        '
        Me.KryptonLabel33.Location = New System.Drawing.Point(6, 260)
        Me.KryptonLabel33.Name = "KryptonLabel33"
        Me.KryptonLabel33.Size = New System.Drawing.Size(78, 22)
        Me.KryptonLabel33.TabIndex = 101
        Me.KryptonLabel33.Text = "Código SAP:"
        Me.KryptonLabel33.Values.ExtraText = ""
        Me.KryptonLabel33.Values.Image = Nothing
        Me.KryptonLabel33.Values.Text = "Código SAP:"
        Me.KryptonLabel33.Visible = False
        '
        'KryptonLabel30
        '
        Me.KryptonLabel30.Location = New System.Drawing.Point(6, 69)
        Me.KryptonLabel30.Name = "KryptonLabel30"
        Me.KryptonLabel30.Size = New System.Drawing.Size(89, 22)
        Me.KryptonLabel30.TabIndex = 98
        Me.KryptonLabel30.Text = "Venc. Licencia:"
        Me.KryptonLabel30.Values.ExtraText = ""
        Me.KryptonLabel30.Values.Image = Nothing
        Me.KryptonLabel30.Values.Text = "Venc. Licencia:"
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.ToolStripSeparator1, Me.btnModificar, Me.btnGuardar, Me.ToolStripSeparator2, Me.btnCancelar, Me.ToolStripSeparator3, Me.btnEliminar, Me.ToolStripSeparator4, Me.btnSalir})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(842, 25)
        Me.MenuBar.TabIndex = 1
        Me.MenuBar.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(62, 22)
        Me.btnNuevo.Text = "Nuevo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnModificar
        '
        Me.btnModificar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(78, 22)
        Me.btnModificar.Text = "Modificar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(69, 22)
        Me.btnGuardar.Text = "Guardar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources._stop
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(73, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator3.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.SOLMIN_ST.My.Resources.Resources.db_remove
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(70, 22)
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.Visible = False
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator4.Visible = False
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
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'txtCodigoBrevete
        '
        Me.txtCodigoBrevete.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoBrevete.Location = New System.Drawing.Point(115, 13)
        Me.txtCodigoBrevete.MaxLength = 15
        Me.txtCodigoBrevete.Name = "txtCodigoBrevete"
        Me.txtCodigoBrevete.Size = New System.Drawing.Size(202, 22)
        Me.txtCodigoBrevete.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodigoBrevete.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodigoBrevete.TabIndex = 0
        Me.txtCodigoBrevete.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'frmNuevoConductor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 331)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(860, 370)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(860, 370)
        Me.Name = "frmNuevoConductor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nuevo Conductor"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderDatos.Panel.ResumeLayout(False)
        Me.HeaderDatos.Panel.PerformLayout()
        CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderDatos.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        CType(Me.imgConductor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents HeaderDatos As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents chkTercero As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents txtDatObservaciones As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpDatFecVencLic As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpDatFecIng As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpDatFecEmLic As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpDatFecVencDNI As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonBorderEdge6 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonBorderEdge5 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents CboTipoLicenciaConducir As CodeTextBox.CodeTextBox
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNombres As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtApellidoPaterno As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtApellidoMaterno As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtDni As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtSeguroSocial As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel36 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtGrupoSanguineo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtDatRPM As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCodigoBrevete As SOLMIN_ST.TextField
    Friend WithEvents txtDatDireccion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel34 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel35 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDatCodSAP As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel29 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel32 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel31 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel33 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel30 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents imgConductor As System.Windows.Forms.PictureBox
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnModificar As System.Windows.Forms.ToolStripButton
End Class
