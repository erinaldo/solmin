<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManUsuario
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmManUsuario))
    Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.GroupBox2 = New System.Windows.Forms.GroupBox
    Me.UcAyudaDivision = New Ransa.Utilitario.ucAyuda
    Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.UcAyudaCompania = New Ransa.Utilitario.ucAyuda
    Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.Uc_CboMenu1 = New Ransa.Controls.Menu.uc_CboMenu
    Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.Uc_CboAplicacion1 = New Ransa.Controls.Menu.uc_CboAplicacion
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtCodNivelUsuario = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.txtCuentaCorriente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtFlag = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.txtTipoUsuario = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.lblUsuario = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.lblNombre = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtUsuario = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.txtNombre = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.tsCabecera = New System.Windows.Forms.ToolStrip
    Me.btnCancelar = New System.Windows.Forms.ToolStripButton
    Me.btnGuardar = New System.Windows.Forms.ToolStripButton
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    Me.tsCabecera.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.GroupBox2)
    Me.KryptonPanel.Controls.Add(Me.GroupBox1)
    Me.KryptonPanel.Controls.Add(Me.tsCabecera)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(617, 281)
    Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
    Me.KryptonPanel.TabIndex = 0
    '
    'GroupBox2
    '
    Me.GroupBox2.BackColor = System.Drawing.Color.White
    Me.GroupBox2.Controls.Add(Me.UcAyudaDivision)
    Me.GroupBox2.Controls.Add(Me.KryptonLabel3)
    Me.GroupBox2.Controls.Add(Me.UcAyudaCompania)
    Me.GroupBox2.Controls.Add(Me.KryptonLabel6)
    Me.GroupBox2.Controls.Add(Me.KryptonLabel8)
    Me.GroupBox2.Controls.Add(Me.KryptonLabel1)
    Me.GroupBox2.Controls.Add(Me.Uc_CboMenu1)
    Me.GroupBox2.Controls.Add(Me.KryptonLabel7)
    Me.GroupBox2.Controls.Add(Me.Uc_CboAplicacion1)
    Me.GroupBox2.Controls.Add(Me.KryptonLabel2)
    Me.GroupBox2.Controls.Add(Me.KryptonLabel4)
    Me.GroupBox2.Controls.Add(Me.txtCodNivelUsuario)
    Me.GroupBox2.Controls.Add(Me.txtCuentaCorriente)
    Me.GroupBox2.Controls.Add(Me.KryptonLabel5)
    Me.GroupBox2.Controls.Add(Me.txtFlag)
    Me.GroupBox2.Controls.Add(Me.txtTipoUsuario)
    Me.GroupBox2.Location = New System.Drawing.Point(18, 106)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(577, 158)
    Me.GroupBox2.TabIndex = 88
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Detalle de Usuario"
    '
    'UcAyudaDivision
    '
    Me.UcAyudaDivision.BackColor = System.Drawing.Color.Transparent
    Me.UcAyudaDivision.DataSource = Nothing
    Me.UcAyudaDivision.DispleyMember = ""
    Me.UcAyudaDivision.ListColumnas = Nothing
    Me.UcAyudaDivision.Location = New System.Drawing.Point(336, 112)
    Me.UcAyudaDivision.Name = "UcAyudaDivision"
    Me.UcAyudaDivision.Obligatorio = False
    Me.UcAyudaDivision.Size = New System.Drawing.Size(227, 21)
    Me.UcAyudaDivision.TabIndex = 7
    Me.UcAyudaDivision.ValueMember = ""
    '
    'KryptonLabel3
    '
    Me.KryptonLabel3.Location = New System.Drawing.Point(15, 39)
    Me.KryptonLabel3.Name = "KryptonLabel3"
    Me.KryptonLabel3.Size = New System.Drawing.Size(140, 19)
    Me.KryptonLabel3.TabIndex = 78
    Me.KryptonLabel3.Text = "Código Cuenta Corriente :"
    Me.KryptonLabel3.Values.ExtraText = ""
    Me.KryptonLabel3.Values.Image = Nothing
    Me.KryptonLabel3.Values.Text = "Código Cuenta Corriente :"
    '
    'UcAyudaCompania
    '
    Me.UcAyudaCompania.BackColor = System.Drawing.Color.Transparent
    Me.UcAyudaCompania.DataSource = Nothing
    Me.UcAyudaCompania.DispleyMember = ""
    Me.UcAyudaCompania.ListColumnas = Nothing
    Me.UcAyudaCompania.Location = New System.Drawing.Point(336, 85)
    Me.UcAyudaCompania.Name = "UcAyudaCompania"
    Me.UcAyudaCompania.Obligatorio = False
    Me.UcAyudaCompania.Size = New System.Drawing.Size(227, 21)
    Me.UcAyudaCompania.TabIndex = 6
    Me.UcAyudaCompania.ValueMember = ""
    '
    'KryptonLabel6
    '
    Me.KryptonLabel6.Location = New System.Drawing.Point(15, 89)
    Me.KryptonLabel6.Name = "KryptonLabel6"
    Me.KryptonLabel6.Size = New System.Drawing.Size(122, 19)
    Me.KryptonLabel6.TabIndex = 78
    Me.KryptonLabel6.Text = "Tipo de Usuario (D/F) :"
    Me.KryptonLabel6.Values.ExtraText = ""
    Me.KryptonLabel6.Values.Image = Nothing
    Me.KryptonLabel6.Values.Text = "Tipo de Usuario (D/F) :"
    '
    'KryptonLabel8
    '
    Me.KryptonLabel8.Location = New System.Drawing.Point(15, 64)
    Me.KryptonLabel8.Name = "KryptonLabel8"
    Me.KryptonLabel8.Size = New System.Drawing.Size(122, 19)
    Me.KryptonLabel8.TabIndex = 78
    Me.KryptonLabel8.Text = "Código Nivel Usuario :"
    Me.KryptonLabel8.Values.ExtraText = ""
    Me.KryptonLabel8.Values.Image = Nothing
    Me.KryptonLabel8.Values.Text = "Código Nivel Usuario :"
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(231, 35)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(99, 19)
    Me.KryptonLabel1.TabIndex = 78
    Me.KryptonLabel1.Text = "Aplicación Inicial :"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Aplicación Inicial :"
    '
    'Uc_CboMenu1
    '
    Me.Uc_CboMenu1.Location = New System.Drawing.Point(336, 57)
    Me.Uc_CboMenu1.Name = "Uc_CboMenu1"
    Me.Uc_CboMenu1.pPSMMCAPL = ""
    Me.Uc_CboMenu1.Size = New System.Drawing.Size(227, 22)
    Me.Uc_CboMenu1.TabIndex = 5
    '
    'KryptonLabel7
    '
    Me.KryptonLabel7.Location = New System.Drawing.Point(15, 114)
    Me.KryptonLabel7.Name = "KryptonLabel7"
    Me.KryptonLabel7.Size = New System.Drawing.Size(102, 19)
    Me.KryptonLabel7.TabIndex = 78
    Me.KryptonLabel7.Text = "Flag Origen Zona :"
    Me.KryptonLabel7.Values.ExtraText = ""
    Me.KryptonLabel7.Values.Image = Nothing
    Me.KryptonLabel7.Values.Text = "Flag Origen Zona :"
    '
    'Uc_CboAplicacion1
    '
    Me.Uc_CboAplicacion1.Location = New System.Drawing.Point(336, 32)
    Me.Uc_CboAplicacion1.Name = "Uc_CboAplicacion1"
    Me.Uc_CboAplicacion1.Size = New System.Drawing.Size(227, 22)
    Me.Uc_CboAplicacion1.TabIndex = 4
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(231, 60)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(76, 19)
    Me.KryptonLabel2.TabIndex = 78
    Me.KryptonLabel2.Text = "Menú Inicial :"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "Menú Inicial :"
    '
    'KryptonLabel4
    '
    Me.KryptonLabel4.Location = New System.Drawing.Point(231, 114)
    Me.KryptonLabel4.Name = "KryptonLabel4"
    Me.KryptonLabel4.Size = New System.Drawing.Size(55, 19)
    Me.KryptonLabel4.TabIndex = 78
    Me.KryptonLabel4.Text = "División :"
    Me.KryptonLabel4.Values.ExtraText = ""
    Me.KryptonLabel4.Values.Image = Nothing
    Me.KryptonLabel4.Values.Text = "División :"
    '
    'txtCodNivelUsuario
    '
    Me.txtCodNivelUsuario.Location = New System.Drawing.Point(161, 64)
    Me.txtCodNivelUsuario.MaxLength = 1
    Me.txtCodNivelUsuario.Name = "txtCodNivelUsuario"
    Me.txtCodNivelUsuario.Size = New System.Drawing.Size(31, 21)
    Me.txtCodNivelUsuario.TabIndex = 1
    Me.txtCodNivelUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'txtCuentaCorriente
    '
    Me.txtCuentaCorriente.Location = New System.Drawing.Point(161, 35)
    Me.txtCuentaCorriente.MaxLength = 1
    Me.txtCuentaCorriente.Name = "txtCuentaCorriente"
    Me.txtCuentaCorriente.Size = New System.Drawing.Size(31, 21)
    Me.txtCuentaCorriente.TabIndex = 0
    Me.txtCuentaCorriente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'KryptonLabel5
    '
    Me.KryptonLabel5.Location = New System.Drawing.Point(231, 89)
    Me.KryptonLabel5.Name = "KryptonLabel5"
    Me.KryptonLabel5.Size = New System.Drawing.Size(66, 19)
    Me.KryptonLabel5.TabIndex = 78
    Me.KryptonLabel5.Text = "Compañia :"
    Me.KryptonLabel5.Values.ExtraText = ""
    Me.KryptonLabel5.Values.Image = Nothing
    Me.KryptonLabel5.Values.Text = "Compañia :"
    '
    'txtFlag
    '
    Me.txtFlag.Location = New System.Drawing.Point(161, 116)
    Me.txtFlag.MaxLength = 1
    Me.txtFlag.Name = "txtFlag"
    Me.txtFlag.Size = New System.Drawing.Size(31, 21)
    Me.txtFlag.TabIndex = 3
    Me.txtFlag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'txtTipoUsuario
    '
    Me.txtTipoUsuario.Location = New System.Drawing.Point(161, 89)
    Me.txtTipoUsuario.MaxLength = 1
    Me.txtTipoUsuario.Name = "txtTipoUsuario"
    Me.txtTipoUsuario.Size = New System.Drawing.Size(31, 21)
    Me.txtTipoUsuario.TabIndex = 2
    Me.txtTipoUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'GroupBox1
    '
    Me.GroupBox1.BackColor = System.Drawing.Color.White
    Me.GroupBox1.Controls.Add(Me.lblUsuario)
    Me.GroupBox1.Controls.Add(Me.lblNombre)
    Me.GroupBox1.Controls.Add(Me.txtUsuario)
    Me.GroupBox1.Controls.Add(Me.txtNombre)
    Me.GroupBox1.Location = New System.Drawing.Point(18, 35)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(577, 62)
    Me.GroupBox1.TabIndex = 87
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Datos de Usuario"
    '
    'lblUsuario
    '
    Me.lblUsuario.Location = New System.Drawing.Point(15, 30)
    Me.lblUsuario.Name = "lblUsuario"
    Me.lblUsuario.Size = New System.Drawing.Size(54, 19)
    Me.lblUsuario.TabIndex = 78
    Me.lblUsuario.Text = "Usuario :"
    Me.lblUsuario.Values.ExtraText = ""
    Me.lblUsuario.Values.Image = Nothing
    Me.lblUsuario.Values.Text = "Usuario :"
    '
    'lblNombre
    '
    Me.lblNombre.Location = New System.Drawing.Point(231, 30)
    Me.lblNombre.Name = "lblNombre"
    Me.lblNombre.Size = New System.Drawing.Size(57, 19)
    Me.lblNombre.TabIndex = 78
    Me.lblNombre.Text = "Nombre :"
    Me.lblNombre.Values.ExtraText = ""
    Me.lblNombre.Values.Image = Nothing
    Me.lblNombre.Values.Text = "Nombre :"
    '
    'txtUsuario
    '
    Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtUsuario.Location = New System.Drawing.Point(75, 28)
    Me.txtUsuario.MaxLength = 10
    Me.txtUsuario.Name = "txtUsuario"
    Me.txtUsuario.Size = New System.Drawing.Size(113, 21)
    Me.txtUsuario.TabIndex = 0
    '
    'txtNombre
    '
    Me.txtNombre.Location = New System.Drawing.Point(294, 28)
    Me.txtNombre.MaxLength = 20
    Me.txtNombre.Name = "txtNombre"
    Me.txtNombre.Size = New System.Drawing.Size(266, 21)
    Me.txtNombre.TabIndex = 1
    '
    'tsCabecera
    '
    Me.tsCabecera.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.tsCabecera.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.tsCabecera.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.btnGuardar})
    Me.tsCabecera.Location = New System.Drawing.Point(0, 0)
    Me.tsCabecera.Name = "tsCabecera"
    Me.tsCabecera.Size = New System.Drawing.Size(617, 25)
    Me.tsCabecera.TabIndex = 86
    Me.tsCabecera.Text = "ToolStrip1"
    '
    'btnCancelar
    '
    Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
    Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(71, 22)
    Me.btnCancelar.Text = "Cancelar"
    '
    'btnGuardar
    '
    Me.btnGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnGuardar.Image = Global.Ransa.Controls.Menu.My.Resources.Resources.button_ok1
    Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnGuardar.Name = "btnGuardar"
    Me.btnGuardar.Size = New System.Drawing.Size(69, 22)
    Me.btnGuardar.Text = "Guardar"
    '
    'FrmManUsuario
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(617, 281)
    Me.ControlBox = False
    Me.Controls.Add(Me.KryptonPanel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "FrmManUsuario"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Mantenimiento de Usuario"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    Me.KryptonPanel.PerformLayout()
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.tsCabecera.ResumeLayout(False)
    Me.tsCabecera.PerformLayout()
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
  Friend WithEvents txtNombre As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents txtUsuario As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents lblNombre As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents lblUsuario As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents tsCabecera As System.Windows.Forms.ToolStrip
  Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
  Friend WithEvents Uc_CboMenu1 As Ransa.Controls.Menu.uc_CboMenu
  Friend WithEvents Uc_CboAplicacion1 As Ransa.Controls.Menu.uc_CboAplicacion
  Friend WithEvents txtCuentaCorriente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  'Friend WithEvents UcDivision As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
  'Friend WithEvents UcCompania As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
  Friend WithEvents txtFlag As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents txtTipoUsuario As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents txtCodNivelUsuario As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents UcAyudaDivision As Ransa.Utilitario.ucAyuda
  Friend WithEvents UcAyudaCompania As Ransa.Utilitario.ucAyuda
End Class
