<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManCliente
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmManCliente))
    Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.lblUsuario = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtUsuario = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.txtReferencia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.UcCliente_TxtF011 = New Ransa.Controls.Cliente.ucCliente_TxtF01
    Me.GroupBox2 = New System.Windows.Forms.GroupBox
    Me.UcAyudaPlanta = New Ransa.Utilitario.ucAyuda
    Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtCodigoInterno = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.lblDivision = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.tsCabecera = New System.Windows.Forms.ToolStrip
    Me.btnCancelar = New System.Windows.Forms.ToolStripButton
    Me.btnGuardar = New System.Windows.Forms.ToolStripButton
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.tsCabecera.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.GroupBox1)
    Me.KryptonPanel.Controls.Add(Me.GroupBox2)
    Me.KryptonPanel.Controls.Add(Me.tsCabecera)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(579, 205)
    Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
    Me.KryptonPanel.TabIndex = 0
    '
    'GroupBox1
    '
    Me.GroupBox1.BackColor = System.Drawing.Color.White
    Me.GroupBox1.Controls.Add(Me.lblUsuario)
    Me.GroupBox1.Controls.Add(Me.KryptonLabel1)
    Me.GroupBox1.Controls.Add(Me.txtUsuario)
    Me.GroupBox1.Controls.Add(Me.txtReferencia)
    Me.GroupBox1.Controls.Add(Me.lblCliente)
    Me.GroupBox1.Controls.Add(Me.UcCliente_TxtF011)
    Me.GroupBox1.Location = New System.Drawing.Point(23, 40)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(536, 90)
    Me.GroupBox1.TabIndex = 0
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Usuario / Cliente"
    '
    'lblUsuario
    '
    Me.lblUsuario.Location = New System.Drawing.Point(6, 32)
    Me.lblUsuario.Name = "lblUsuario"
    Me.lblUsuario.Size = New System.Drawing.Size(54, 19)
    Me.lblUsuario.TabIndex = 76
    Me.lblUsuario.Text = "Usuario :"
    Me.lblUsuario.Values.ExtraText = ""
    Me.lblUsuario.Values.Image = Nothing
    Me.lblUsuario.Values.Text = "Usuario :"
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(6, 57)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(106, 19)
    Me.KryptonLabel1.TabIndex = 76
    Me.KryptonLabel1.Text = "Referencia Cliente :"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Referencia Cliente :"
    '
    'txtUsuario
    '
    Me.txtUsuario.Location = New System.Drawing.Point(113, 28)
    Me.txtUsuario.MaxLength = 25
    Me.txtUsuario.Name = "txtUsuario"
    Me.txtUsuario.Size = New System.Drawing.Size(103, 21)
    Me.txtUsuario.TabIndex = 0
    '
    'txtReferencia
    '
    Me.txtReferencia.Location = New System.Drawing.Point(113, 55)
    Me.txtReferencia.MaxLength = 35
    Me.txtReferencia.Name = "txtReferencia"
    Me.txtReferencia.Size = New System.Drawing.Size(412, 21)
    Me.txtReferencia.TabIndex = 2
    '
    'lblCliente
    '
    Me.lblCliente.Location = New System.Drawing.Point(222, 30)
    Me.lblCliente.Name = "lblCliente"
    Me.lblCliente.Size = New System.Drawing.Size(50, 19)
    Me.lblCliente.TabIndex = 76
    Me.lblCliente.Text = "Cliente :"
    Me.lblCliente.Values.ExtraText = ""
    Me.lblCliente.Values.Image = Nothing
    Me.lblCliente.Values.Text = "Cliente :"
    '
    'UcCliente_TxtF011
    '
    Me.UcCliente_TxtF011.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.UcCliente_TxtF011.BackColor = System.Drawing.Color.Transparent
    Me.UcCliente_TxtF011.CCMPN = "EZ"
    Me.UcCliente_TxtF011.Location = New System.Drawing.Point(278, 28)
    Me.UcCliente_TxtF011.Name = "UcCliente_TxtF011"
    Me.UcCliente_TxtF011.pAccesoPorUsuario = False
    Me.UcCliente_TxtF011.pRequerido = False
    Me.UcCliente_TxtF011.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
    Me.UcCliente_TxtF011.Size = New System.Drawing.Size(247, 21)
    Me.UcCliente_TxtF011.TabIndex = 1
    '
    'GroupBox2
    '
    Me.GroupBox2.BackColor = System.Drawing.Color.White
    Me.GroupBox2.Controls.Add(Me.UcAyudaPlanta)
    Me.GroupBox2.Controls.Add(Me.KryptonLabel4)
    Me.GroupBox2.Controls.Add(Me.txtCodigoInterno)
    Me.GroupBox2.Controls.Add(Me.lblDivision)
    Me.GroupBox2.Location = New System.Drawing.Point(23, 136)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(536, 52)
    Me.GroupBox2.TabIndex = 1
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Información"
    '
    'UcAyudaPlanta
    '
    Me.UcAyudaPlanta.BackColor = System.Drawing.Color.Transparent
    Me.UcAyudaPlanta.DataSource = Nothing
    Me.UcAyudaPlanta.DispleyMember = ""
    Me.UcAyudaPlanta.ListColumnas = Nothing
    Me.UcAyudaPlanta.Location = New System.Drawing.Point(278, 17)
    Me.UcAyudaPlanta.Name = "UcAyudaPlanta"
    Me.UcAyudaPlanta.Obligatorio = False
    Me.UcAyudaPlanta.Size = New System.Drawing.Size(247, 21)
    Me.UcAyudaPlanta.TabIndex = 1
    Me.UcAyudaPlanta.ValueMember = ""
    '
    'KryptonLabel4
    '
    Me.KryptonLabel4.Location = New System.Drawing.Point(6, 19)
    Me.KryptonLabel4.Name = "KryptonLabel4"
    Me.KryptonLabel4.Size = New System.Drawing.Size(91, 19)
    Me.KryptonLabel4.TabIndex = 76
    Me.KryptonLabel4.Text = "Código Interno :"
    Me.KryptonLabel4.Values.ExtraText = ""
    Me.KryptonLabel4.Values.Image = Nothing
    Me.KryptonLabel4.Values.Text = "Código Interno :"
    '
    'txtCodigoInterno
    '
    Me.txtCodigoInterno.Location = New System.Drawing.Point(113, 17)
    Me.txtCodigoInterno.MaxLength = 15
    Me.txtCodigoInterno.Name = "txtCodigoInterno"
    Me.txtCodigoInterno.Size = New System.Drawing.Size(103, 21)
    Me.txtCodigoInterno.TabIndex = 0
    '
    'lblDivision
    '
    Me.lblDivision.Location = New System.Drawing.Point(225, 19)
    Me.lblDivision.Name = "lblDivision"
    Me.lblDivision.Size = New System.Drawing.Size(47, 19)
    Me.lblDivision.TabIndex = 76
    Me.lblDivision.Text = "Planta :"
    Me.lblDivision.Values.ExtraText = ""
    Me.lblDivision.Values.Image = Nothing
    Me.lblDivision.Values.Text = "Planta :"
    '
    'tsCabecera
    '
    Me.tsCabecera.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.tsCabecera.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.tsCabecera.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.btnGuardar})
    Me.tsCabecera.Location = New System.Drawing.Point(0, 0)
    Me.tsCabecera.Name = "tsCabecera"
    Me.tsCabecera.Size = New System.Drawing.Size(579, 25)
    Me.tsCabecera.TabIndex = 78
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
    'FrmManCliente
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(579, 205)
    Me.Controls.Add(Me.KryptonPanel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.Name = "FrmManCliente"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Nuevo Acceso Cliente"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    Me.KryptonPanel.PerformLayout()
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
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
  Friend WithEvents UcCliente_TxtF011 As Ransa.Controls.Cliente.ucCliente_TxtF01
  Friend WithEvents txtUsuario As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents lblUsuario As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents tsCabecera As System.Windows.Forms.ToolStrip
  Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
  Friend WithEvents lblDivision As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtReferencia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtCodigoInterno As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents UcAyudaPlanta As Ransa.Utilitario.ucAyuda
End Class
