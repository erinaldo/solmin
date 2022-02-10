<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManPlanta
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmManPlanta))
    Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.GroupBox2 = New System.Windows.Forms.GroupBox
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.lblAplicacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtSociedadSAP = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.txtRegionVenta = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.UcAyudaPlanta = New Ransa.Utilitario.ucAyuda
    Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.UcAyudaDivision = New Ransa.Utilitario.ucAyuda
    Me.txtUsuario = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.UcAyudaCompania = New Ransa.Utilitario.ucAyuda
    Me.lblCompañia = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.lblPlanta = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.lblDivision = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.tsCabecera = New System.Windows.Forms.ToolStrip
    Me.btnCancelar = New System.Windows.Forms.ToolStripButton
    Me.btnGuardar = New System.Windows.Forms.ToolStripButton
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.Uc_CboAplicacion1 = New Ransa.Controls.Menu.uc_CboAplicacion
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
    Me.KryptonPanel.Size = New System.Drawing.Size(629, 250)
    Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
    Me.KryptonPanel.TabIndex = 0
    '
    'GroupBox2
    '
    Me.GroupBox2.BackColor = System.Drawing.Color.White
    Me.GroupBox2.Controls.Add(Me.KryptonLabel1)
    Me.GroupBox2.Controls.Add(Me.lblAplicacion)
    Me.GroupBox2.Controls.Add(Me.KryptonLabel2)
    Me.GroupBox2.Controls.Add(Me.Uc_CboAplicacion1)
    Me.GroupBox2.Controls.Add(Me.txtSociedadSAP)
    Me.GroupBox2.Controls.Add(Me.txtRegionVenta)
    Me.GroupBox2.Location = New System.Drawing.Point(31, 162)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(573, 68)
    Me.GroupBox2.TabIndex = 88
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Información"
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(244, 16)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(83, 33)
    Me.KryptonLabel1.TabIndex = 75
    Me.KryptonLabel1.Text = "Código " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Región Venta :"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Código " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Región Venta :"
    '
    'lblAplicacion
    '
    Me.lblAplicacion.Location = New System.Drawing.Point(6, 16)
    Me.lblAplicacion.Name = "lblAplicacion"
    Me.lblAplicacion.Size = New System.Drawing.Size(62, 33)
    Me.lblAplicacion.TabIndex = 77
    Me.lblAplicacion.Text = "Aplicación " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Inicial :"
    Me.lblAplicacion.Values.ExtraText = ""
    Me.lblAplicacion.Values.Image = Nothing
    Me.lblAplicacion.Values.Text = "Aplicación " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Inicial :"
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(400, 16)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(84, 33)
    Me.KryptonLabel2.TabIndex = 77
    Me.KryptonLabel2.Text = "Código " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sociedad SAP :"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "Código " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sociedad SAP :"
    '
    'txtSociedadSAP
    '
    Me.txtSociedadSAP.Location = New System.Drawing.Point(490, 19)
    Me.txtSociedadSAP.MaxLength = 4
    Me.txtSociedadSAP.Name = "txtSociedadSAP"
    Me.txtSociedadSAP.Size = New System.Drawing.Size(61, 21)
    Me.txtSociedadSAP.TabIndex = 2
    '
    'txtRegionVenta
    '
    Me.txtRegionVenta.Location = New System.Drawing.Point(333, 22)
    Me.txtRegionVenta.MaxLength = 3
    Me.txtRegionVenta.Name = "txtRegionVenta"
    Me.txtRegionVenta.Size = New System.Drawing.Size(61, 21)
    Me.txtRegionVenta.TabIndex = 1
    '
    'GroupBox1
    '
    Me.GroupBox1.BackColor = System.Drawing.Color.White
    Me.GroupBox1.Controls.Add(Me.UcAyudaPlanta)
    Me.GroupBox1.Controls.Add(Me.KryptonLabel3)
    Me.GroupBox1.Controls.Add(Me.UcAyudaDivision)
    Me.GroupBox1.Controls.Add(Me.txtUsuario)
    Me.GroupBox1.Controls.Add(Me.UcAyudaCompania)
    Me.GroupBox1.Controls.Add(Me.lblCompañia)
    Me.GroupBox1.Controls.Add(Me.lblPlanta)
    Me.GroupBox1.Controls.Add(Me.lblDivision)
    Me.GroupBox1.Location = New System.Drawing.Point(31, 38)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(573, 118)
    Me.GroupBox1.TabIndex = 87
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Usuario / Planta"
    '
    'UcAyudaPlanta
    '
    Me.UcAyudaPlanta.BackColor = System.Drawing.Color.Transparent
    Me.UcAyudaPlanta.DataSource = Nothing
    Me.UcAyudaPlanta.DispleyMember = ""
    Me.UcAyudaPlanta.ListColumnas = Nothing
    Me.UcAyudaPlanta.Location = New System.Drawing.Point(311, 84)
    Me.UcAyudaPlanta.Name = "UcAyudaPlanta"
    Me.UcAyudaPlanta.Obligatorio = False
    Me.UcAyudaPlanta.Size = New System.Drawing.Size(240, 21)
    Me.UcAyudaPlanta.TabIndex = 2
    Me.UcAyudaPlanta.ValueMember = ""
    '
    'KryptonLabel3
    '
    Me.KryptonLabel3.Location = New System.Drawing.Point(6, 21)
    Me.KryptonLabel3.Name = "KryptonLabel3"
    Me.KryptonLabel3.Size = New System.Drawing.Size(54, 19)
    Me.KryptonLabel3.TabIndex = 75
    Me.KryptonLabel3.Text = "Usuario :"
    Me.KryptonLabel3.Values.ExtraText = ""
    Me.KryptonLabel3.Values.Image = Nothing
    Me.KryptonLabel3.Values.Text = "Usuario :"
    '
    'UcAyudaDivision
    '
    Me.UcAyudaDivision.BackColor = System.Drawing.Color.Transparent
    Me.UcAyudaDivision.DataSource = Nothing
    Me.UcAyudaDivision.DispleyMember = ""
    Me.UcAyudaDivision.ListColumnas = Nothing
    Me.UcAyudaDivision.Location = New System.Drawing.Point(311, 50)
    Me.UcAyudaDivision.Name = "UcAyudaDivision"
    Me.UcAyudaDivision.Obligatorio = False
    Me.UcAyudaDivision.Size = New System.Drawing.Size(240, 21)
    Me.UcAyudaDivision.TabIndex = 1
    Me.UcAyudaDivision.ValueMember = ""
    '
    'txtUsuario
    '
    Me.txtUsuario.Location = New System.Drawing.Point(70, 20)
    Me.txtUsuario.MaxLength = 25
    Me.txtUsuario.Name = "txtUsuario"
    Me.txtUsuario.Size = New System.Drawing.Size(130, 21)
    Me.txtUsuario.TabIndex = 0
    '
    'UcAyudaCompania
    '
    Me.UcAyudaCompania.BackColor = System.Drawing.Color.Transparent
    Me.UcAyudaCompania.DataSource = Nothing
    Me.UcAyudaCompania.DispleyMember = ""
    Me.UcAyudaCompania.ListColumnas = Nothing
    Me.UcAyudaCompania.Location = New System.Drawing.Point(311, 19)
    Me.UcAyudaCompania.Name = "UcAyudaCompania"
    Me.UcAyudaCompania.Obligatorio = False
    Me.UcAyudaCompania.Size = New System.Drawing.Size(240, 21)
    Me.UcAyudaCompania.TabIndex = 0
    Me.UcAyudaCompania.ValueMember = ""
    '
    'lblCompañia
    '
    Me.lblCompañia.Location = New System.Drawing.Point(234, 20)
    Me.lblCompañia.Name = "lblCompañia"
    Me.lblCompañia.Size = New System.Drawing.Size(66, 19)
    Me.lblCompañia.TabIndex = 76
    Me.lblCompañia.Text = "Compañia :"
    Me.lblCompañia.Values.ExtraText = ""
    Me.lblCompañia.Values.Image = Nothing
    Me.lblCompañia.Values.Text = "Compañia :"
    '
    'lblPlanta
    '
    Me.lblPlanta.Location = New System.Drawing.Point(234, 82)
    Me.lblPlanta.Name = "lblPlanta"
    Me.lblPlanta.Size = New System.Drawing.Size(47, 19)
    Me.lblPlanta.TabIndex = 75
    Me.lblPlanta.Text = "Planta :"
    Me.lblPlanta.Values.ExtraText = ""
    Me.lblPlanta.Values.Image = Nothing
    Me.lblPlanta.Values.Text = "Planta :"
    '
    'lblDivision
    '
    Me.lblDivision.Location = New System.Drawing.Point(234, 51)
    Me.lblDivision.Name = "lblDivision"
    Me.lblDivision.Size = New System.Drawing.Size(55, 19)
    Me.lblDivision.TabIndex = 78
    Me.lblDivision.Text = "División :"
    Me.lblDivision.Values.ExtraText = ""
    Me.lblDivision.Values.Image = Nothing
    Me.lblDivision.Values.Text = "División :"
    '
    'tsCabecera
    '
    Me.tsCabecera.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.tsCabecera.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.tsCabecera.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.btnGuardar})
    Me.tsCabecera.Location = New System.Drawing.Point(0, 0)
    Me.tsCabecera.Name = "tsCabecera"
    Me.tsCabecera.Size = New System.Drawing.Size(629, 25)
    Me.tsCabecera.TabIndex = 85
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
    'Uc_CboAplicacion1
    '
    Me.Uc_CboAplicacion1.Location = New System.Drawing.Point(68, 19)
    Me.Uc_CboAplicacion1.Name = "Uc_CboAplicacion1"
    Me.Uc_CboAplicacion1.Size = New System.Drawing.Size(164, 22)
    Me.Uc_CboAplicacion1.TabIndex = 0
    '
    'FrmManPlanta
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(629, 250)
    Me.Controls.Add(Me.KryptonPanel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.Name = "FrmManPlanta"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Nuevo Acceso Planta"
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
  Friend WithEvents lblAplicacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents Uc_CboAplicacion1 As Ransa.Controls.Menu.uc_CboAplicacion
  Friend WithEvents txtSociedadSAP As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents txtRegionVenta As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents tsCabecera As System.Windows.Forms.ToolStrip
  Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtUsuario As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents lblCompañia As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents lblPlanta As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents lblDivision As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents UcAyudaPlanta As Ransa.Utilitario.ucAyuda
  Friend WithEvents UcAyudaDivision As Ransa.Utilitario.ucAyuda
  Friend WithEvents UcAyudaCompania As Ransa.Utilitario.ucAyuda
End Class
