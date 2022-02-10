<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManAccesoOpcion
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmManAccesoOpcion))
    Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.lblUsuario = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.lblMenu = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.lblAplicacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.lblOpcion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtUsuario = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.GroupBox2 = New System.Windows.Forms.GroupBox
    Me.chkVisualizar = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Me.chkCambiar = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Me.chkOpcion3 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Me.chkAdicionar = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Me.chkOpcion2 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Me.chkEliminar = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Me.chkOpcion1 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Me.tsCabecera = New System.Windows.Forms.ToolStrip
    Me.btnCancelar = New System.Windows.Forms.ToolStripButton
    Me.btnGuardar = New System.Windows.Forms.ToolStripButton
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.Uc_CboOpcion1 = New Ransa.Controls.Menu.uc_CboOpcion
    Me.Uc_CboAplicacion1 = New Ransa.Controls.Menu.uc_CboAplicacion
    Me.Uc_CboMenu1 = New Ransa.Controls.Menu.uc_CboMenu
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
    Me.KryptonPanel.Size = New System.Drawing.Size(637, 272)
    Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
    Me.KryptonPanel.TabIndex = 0
    '
    'GroupBox1
    '
    Me.GroupBox1.BackColor = System.Drawing.Color.White
    Me.GroupBox1.Controls.Add(Me.Uc_CboOpcion1)
    Me.GroupBox1.Controls.Add(Me.lblUsuario)
    Me.GroupBox1.Controls.Add(Me.lblMenu)
    Me.GroupBox1.Controls.Add(Me.lblAplicacion)
    Me.GroupBox1.Controls.Add(Me.lblOpcion)
    Me.GroupBox1.Controls.Add(Me.txtUsuario)
    Me.GroupBox1.Controls.Add(Me.Uc_CboAplicacion1)
    Me.GroupBox1.Controls.Add(Me.Uc_CboMenu1)
    Me.GroupBox1.Location = New System.Drawing.Point(22, 37)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(594, 111)
    Me.GroupBox1.TabIndex = 0
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Usuario / Opción"
    '
    'lblUsuario
    '
    Me.lblUsuario.Location = New System.Drawing.Point(16, 51)
    Me.lblUsuario.Name = "lblUsuario"
    Me.lblUsuario.Size = New System.Drawing.Size(54, 19)
    Me.lblUsuario.TabIndex = 74
    Me.lblUsuario.Text = "Usuario :"
    Me.lblUsuario.Values.ExtraText = ""
    Me.lblUsuario.Values.Image = Nothing
    Me.lblUsuario.Values.Text = "Usuario :"
    '
    'lblMenu
    '
    Me.lblMenu.Location = New System.Drawing.Point(284, 51)
    Me.lblMenu.Name = "lblMenu"
    Me.lblMenu.Size = New System.Drawing.Size(45, 19)
    Me.lblMenu.TabIndex = 74
    Me.lblMenu.Text = "Menú :"
    Me.lblMenu.Values.ExtraText = ""
    Me.lblMenu.Values.Image = Nothing
    Me.lblMenu.Values.Text = "Menú :"
    '
    'lblAplicacion
    '
    Me.lblAplicacion.Location = New System.Drawing.Point(284, 26)
    Me.lblAplicacion.Name = "lblAplicacion"
    Me.lblAplicacion.Size = New System.Drawing.Size(67, 19)
    Me.lblAplicacion.TabIndex = 74
    Me.lblAplicacion.Text = "Aplicación :"
    Me.lblAplicacion.Values.ExtraText = ""
    Me.lblAplicacion.Values.Image = Nothing
    Me.lblAplicacion.Values.Text = "Aplicación :"
    '
    'lblOpcion
    '
    Me.lblOpcion.Location = New System.Drawing.Point(284, 76)
    Me.lblOpcion.Name = "lblOpcion"
    Me.lblOpcion.Size = New System.Drawing.Size(52, 19)
    Me.lblOpcion.TabIndex = 74
    Me.lblOpcion.Text = "Opción :"
    Me.lblOpcion.Values.ExtraText = ""
    Me.lblOpcion.Values.Image = Nothing
    Me.lblOpcion.Values.Text = "Opción :"
    '
    'txtUsuario
    '
    Me.txtUsuario.Location = New System.Drawing.Point(76, 48)
    Me.txtUsuario.MaxLength = 25
    Me.txtUsuario.Name = "txtUsuario"
    Me.txtUsuario.Size = New System.Drawing.Size(128, 21)
    Me.txtUsuario.TabIndex = 0
    '
    'GroupBox2
    '
    Me.GroupBox2.BackColor = System.Drawing.Color.White
    Me.GroupBox2.Controls.Add(Me.chkVisualizar)
    Me.GroupBox2.Controls.Add(Me.chkCambiar)
    Me.GroupBox2.Controls.Add(Me.chkOpcion3)
    Me.GroupBox2.Controls.Add(Me.chkAdicionar)
    Me.GroupBox2.Controls.Add(Me.chkOpcion2)
    Me.GroupBox2.Controls.Add(Me.chkEliminar)
    Me.GroupBox2.Controls.Add(Me.chkOpcion1)
    Me.GroupBox2.Location = New System.Drawing.Point(22, 163)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(594, 90)
    Me.GroupBox2.TabIndex = 1
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Información"
    '
    'chkVisualizar
    '
    Me.chkVisualizar.Checked = False
    Me.chkVisualizar.CheckState = System.Windows.Forms.CheckState.Unchecked
    Me.chkVisualizar.Location = New System.Drawing.Point(16, 23)
    Me.chkVisualizar.Name = "chkVisualizar"
    Me.chkVisualizar.Size = New System.Drawing.Size(70, 19)
    Me.chkVisualizar.TabIndex = 0
    Me.chkVisualizar.Text = "Visualizar"
    Me.chkVisualizar.Values.ExtraText = ""
    Me.chkVisualizar.Values.Image = Nothing
    Me.chkVisualizar.Values.Text = "Visualizar"
    '
    'chkCambiar
    '
    Me.chkCambiar.Checked = False
    Me.chkCambiar.CheckState = System.Windows.Forms.CheckState.Unchecked
    Me.chkCambiar.Location = New System.Drawing.Point(313, 23)
    Me.chkCambiar.Name = "chkCambiar"
    Me.chkCambiar.Size = New System.Drawing.Size(65, 19)
    Me.chkCambiar.TabIndex = 2
    Me.chkCambiar.Text = "Cambiar"
    Me.chkCambiar.Values.ExtraText = ""
    Me.chkCambiar.Values.Image = Nothing
    Me.chkCambiar.Values.Text = "Cambiar"
    '
    'chkOpcion3
    '
    Me.chkOpcion3.Checked = False
    Me.chkOpcion3.CheckState = System.Windows.Forms.CheckState.Unchecked
    Me.chkOpcion3.Location = New System.Drawing.Point(313, 53)
    Me.chkOpcion3.Name = "chkOpcion3"
    Me.chkOpcion3.Size = New System.Drawing.Size(69, 19)
    Me.chkOpcion3.TabIndex = 6
    Me.chkOpcion3.Text = "Opción 3"
    Me.chkOpcion3.Values.ExtraText = ""
    Me.chkOpcion3.Values.Image = Nothing
    Me.chkOpcion3.Values.Text = "Opción 3"
    '
    'chkAdicionar
    '
    Me.chkAdicionar.Checked = False
    Me.chkAdicionar.CheckState = System.Windows.Forms.CheckState.Unchecked
    Me.chkAdicionar.Location = New System.Drawing.Point(167, 23)
    Me.chkAdicionar.Name = "chkAdicionar"
    Me.chkAdicionar.Size = New System.Drawing.Size(71, 19)
    Me.chkAdicionar.TabIndex = 1
    Me.chkAdicionar.Text = "Adicionar"
    Me.chkAdicionar.Values.ExtraText = ""
    Me.chkAdicionar.Values.Image = Nothing
    Me.chkAdicionar.Values.Text = "Adicionar"
    '
    'chkOpcion2
    '
    Me.chkOpcion2.Checked = False
    Me.chkOpcion2.CheckState = System.Windows.Forms.CheckState.Unchecked
    Me.chkOpcion2.Location = New System.Drawing.Point(167, 53)
    Me.chkOpcion2.Name = "chkOpcion2"
    Me.chkOpcion2.Size = New System.Drawing.Size(69, 19)
    Me.chkOpcion2.TabIndex = 5
    Me.chkOpcion2.Text = "Opción 2"
    Me.chkOpcion2.Values.ExtraText = ""
    Me.chkOpcion2.Values.Image = Nothing
    Me.chkOpcion2.Values.Text = "Opción 2"
    '
    'chkEliminar
    '
    Me.chkEliminar.Checked = False
    Me.chkEliminar.CheckState = System.Windows.Forms.CheckState.Unchecked
    Me.chkEliminar.Location = New System.Drawing.Point(461, 23)
    Me.chkEliminar.Name = "chkEliminar"
    Me.chkEliminar.Size = New System.Drawing.Size(63, 19)
    Me.chkEliminar.TabIndex = 3
    Me.chkEliminar.Text = "Eliminar"
    Me.chkEliminar.Values.ExtraText = ""
    Me.chkEliminar.Values.Image = Nothing
    Me.chkEliminar.Values.Text = "Eliminar"
    '
    'chkOpcion1
    '
    Me.chkOpcion1.Checked = False
    Me.chkOpcion1.CheckState = System.Windows.Forms.CheckState.Unchecked
    Me.chkOpcion1.Location = New System.Drawing.Point(16, 53)
    Me.chkOpcion1.Name = "chkOpcion1"
    Me.chkOpcion1.Size = New System.Drawing.Size(69, 19)
    Me.chkOpcion1.TabIndex = 4
    Me.chkOpcion1.Text = "Opción 1"
    Me.chkOpcion1.Values.ExtraText = ""
    Me.chkOpcion1.Values.Image = Nothing
    Me.chkOpcion1.Values.Text = "Opción 1"
    '
    'tsCabecera
    '
    Me.tsCabecera.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.tsCabecera.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.tsCabecera.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.btnGuardar})
    Me.tsCabecera.Location = New System.Drawing.Point(0, 0)
    Me.tsCabecera.Name = "tsCabecera"
    Me.tsCabecera.Size = New System.Drawing.Size(637, 25)
    Me.tsCabecera.TabIndex = 72
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
    'Uc_CboOpcion1
    '
    Me.Uc_CboOpcion1.Location = New System.Drawing.Point(359, 73)
    Me.Uc_CboOpcion1.Name = "Uc_CboOpcion1"
    Me.Uc_CboOpcion1.pPSMMCAPL = ""
    Me.Uc_CboOpcion1.pPSMMCMNU = ""
    Me.Uc_CboOpcion1.pPSMMCOPC = New Decimal(New Integer() {0, 0, 0, 0})
    Me.Uc_CboOpcion1.pPSMMDOPC = ""
    Me.Uc_CboOpcion1.Size = New System.Drawing.Size(219, 22)
    Me.Uc_CboOpcion1.TabIndex = 3
    '
    'Uc_CboAplicacion1
    '
    Me.Uc_CboAplicacion1.Location = New System.Drawing.Point(359, 23)
    Me.Uc_CboAplicacion1.Name = "Uc_CboAplicacion1"
    Me.Uc_CboAplicacion1.Size = New System.Drawing.Size(218, 22)
    Me.Uc_CboAplicacion1.TabIndex = 1
    '
    'Uc_CboMenu1
    '
    Me.Uc_CboMenu1.Location = New System.Drawing.Point(359, 48)
    Me.Uc_CboMenu1.Name = "Uc_CboMenu1"
    Me.Uc_CboMenu1.pPSMMCAPL = ""
    Me.Uc_CboMenu1.Size = New System.Drawing.Size(219, 22)
    Me.Uc_CboMenu1.TabIndex = 2
    '
    'FrmManAccesoOpcion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(637, 272)
    Me.Controls.Add(Me.KryptonPanel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.Name = "FrmManAccesoOpcion"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Nuevo Acceso Opción"
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
  Friend WithEvents tsCabecera As System.Windows.Forms.ToolStrip
  Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
  Friend WithEvents txtUsuario As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents lblOpcion As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents lblAplicacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents lblMenu As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents lblUsuario As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents chkEliminar As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
  Friend WithEvents chkAdicionar As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
  Friend WithEvents chkVisualizar As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
  Friend WithEvents chkCambiar As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
  Friend WithEvents Uc_CboMenu1 As Ransa.Controls.Menu.uc_CboMenu
  Friend WithEvents Uc_CboAplicacion1 As Ransa.Controls.Menu.uc_CboAplicacion
  Friend WithEvents chkOpcion3 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
  Friend WithEvents chkOpcion2 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
  Friend WithEvents chkOpcion1 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents Uc_CboOpcion1 As Ransa.Controls.Menu.uc_CboOpcion
End Class
