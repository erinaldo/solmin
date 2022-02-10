<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManUserOption
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManUserOption))
    Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.tsCabecera = New System.Windows.Forms.ToolStrip
    Me.btnCancelar = New System.Windows.Forms.ToolStripButton
    Me.btnGuardar = New System.Windows.Forms.ToolStripButton
    Me.GroupBox2 = New System.Windows.Forms.GroupBox
    Me.chkVisualizar = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Me.chkCambiar = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Me.chkOpcion3 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Me.chkAdicionar = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Me.chkOpcion2 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Me.chkEliminar = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Me.chkOpcion1 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.txtOpcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.txtMenu = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.txtAplicacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.Uc_CboUsuario1 = New Ransa.Controls.Menu.uc_CboUsuario
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    Me.tsCabecera.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.tsCabecera)
    Me.KryptonPanel.Controls.Add(Me.GroupBox2)
    Me.KryptonPanel.Controls.Add(Me.GroupBox1)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(668, 284)
    Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
    Me.KryptonPanel.TabIndex = 0
    '
    'tsCabecera
    '
    Me.tsCabecera.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.tsCabecera.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.tsCabecera.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.btnGuardar})
    Me.tsCabecera.Location = New System.Drawing.Point(0, 0)
    Me.tsCabecera.Name = "tsCabecera"
    Me.tsCabecera.Size = New System.Drawing.Size(668, 25)
    Me.tsCabecera.TabIndex = 73
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
    Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption
    Me.GroupBox2.Location = New System.Drawing.Point(12, 164)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(644, 105)
    Me.GroupBox2.TabIndex = 1
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Información :"
    '
    'chkVisualizar
    '
    Me.chkVisualizar.Checked = False
    Me.chkVisualizar.CheckState = System.Windows.Forms.CheckState.Unchecked
    Me.chkVisualizar.Location = New System.Drawing.Point(38, 32)
    Me.chkVisualizar.Name = "chkVisualizar"
    Me.chkVisualizar.Size = New System.Drawing.Size(70, 19)
    Me.chkVisualizar.TabIndex = 7
    Me.chkVisualizar.Text = "Visualizar"
    Me.chkVisualizar.Values.ExtraText = ""
    Me.chkVisualizar.Values.Image = Nothing
    Me.chkVisualizar.Values.Text = "Visualizar"
    '
    'chkCambiar
    '
    Me.chkCambiar.Checked = False
    Me.chkCambiar.CheckState = System.Windows.Forms.CheckState.Unchecked
    Me.chkCambiar.Location = New System.Drawing.Point(335, 32)
    Me.chkCambiar.Name = "chkCambiar"
    Me.chkCambiar.Size = New System.Drawing.Size(65, 19)
    Me.chkCambiar.TabIndex = 9
    Me.chkCambiar.Text = "Cambiar"
    Me.chkCambiar.Values.ExtraText = ""
    Me.chkCambiar.Values.Image = Nothing
    Me.chkCambiar.Values.Text = "Cambiar"
    '
    'chkOpcion3
    '
    Me.chkOpcion3.Checked = False
    Me.chkOpcion3.CheckState = System.Windows.Forms.CheckState.Unchecked
    Me.chkOpcion3.Location = New System.Drawing.Point(335, 62)
    Me.chkOpcion3.Name = "chkOpcion3"
    Me.chkOpcion3.Size = New System.Drawing.Size(69, 19)
    Me.chkOpcion3.TabIndex = 13
    Me.chkOpcion3.Text = "Opción 3"
    Me.chkOpcion3.Values.ExtraText = ""
    Me.chkOpcion3.Values.Image = Nothing
    Me.chkOpcion3.Values.Text = "Opción 3"
    '
    'chkAdicionar
    '
    Me.chkAdicionar.Checked = False
    Me.chkAdicionar.CheckState = System.Windows.Forms.CheckState.Unchecked
    Me.chkAdicionar.Location = New System.Drawing.Point(189, 32)
    Me.chkAdicionar.Name = "chkAdicionar"
    Me.chkAdicionar.Size = New System.Drawing.Size(71, 19)
    Me.chkAdicionar.TabIndex = 8
    Me.chkAdicionar.Text = "Adicionar"
    Me.chkAdicionar.Values.ExtraText = ""
    Me.chkAdicionar.Values.Image = Nothing
    Me.chkAdicionar.Values.Text = "Adicionar"
    '
    'chkOpcion2
    '
    Me.chkOpcion2.Checked = False
    Me.chkOpcion2.CheckState = System.Windows.Forms.CheckState.Unchecked
    Me.chkOpcion2.Location = New System.Drawing.Point(189, 62)
    Me.chkOpcion2.Name = "chkOpcion2"
    Me.chkOpcion2.Size = New System.Drawing.Size(69, 19)
    Me.chkOpcion2.TabIndex = 12
    Me.chkOpcion2.Text = "Opción 2"
    Me.chkOpcion2.Values.ExtraText = ""
    Me.chkOpcion2.Values.Image = Nothing
    Me.chkOpcion2.Values.Text = "Opción 2"
    '
    'chkEliminar
    '
    Me.chkEliminar.Checked = False
    Me.chkEliminar.CheckState = System.Windows.Forms.CheckState.Unchecked
    Me.chkEliminar.Location = New System.Drawing.Point(483, 32)
    Me.chkEliminar.Name = "chkEliminar"
    Me.chkEliminar.Size = New System.Drawing.Size(63, 19)
    Me.chkEliminar.TabIndex = 10
    Me.chkEliminar.Text = "Eliminar"
    Me.chkEliminar.Values.ExtraText = ""
    Me.chkEliminar.Values.Image = Nothing
    Me.chkEliminar.Values.Text = "Eliminar"
    '
    'chkOpcion1
    '
    Me.chkOpcion1.Checked = False
    Me.chkOpcion1.CheckState = System.Windows.Forms.CheckState.Unchecked
    Me.chkOpcion1.Location = New System.Drawing.Point(38, 62)
    Me.chkOpcion1.Name = "chkOpcion1"
    Me.chkOpcion1.Size = New System.Drawing.Size(69, 19)
    Me.chkOpcion1.TabIndex = 11
    Me.chkOpcion1.Text = "Opción 1"
    Me.chkOpcion1.Values.ExtraText = ""
    Me.chkOpcion1.Values.Image = Nothing
    Me.chkOpcion1.Values.Text = "Opción 1"
    '
    'GroupBox1
    '
    Me.GroupBox1.BackColor = System.Drawing.Color.White
    Me.GroupBox1.Controls.Add(Me.txtOpcion)
    Me.GroupBox1.Controls.Add(Me.txtMenu)
    Me.GroupBox1.Controls.Add(Me.txtAplicacion)
    Me.GroupBox1.Controls.Add(Me.KryptonLabel4)
    Me.GroupBox1.Controls.Add(Me.KryptonLabel3)
    Me.GroupBox1.Controls.Add(Me.KryptonLabel2)
    Me.GroupBox1.Controls.Add(Me.KryptonLabel1)
    Me.GroupBox1.Controls.Add(Me.Uc_CboUsuario1)
    Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption
    Me.GroupBox1.Location = New System.Drawing.Point(12, 37)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(644, 121)
    Me.GroupBox1.TabIndex = 0
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Usuario / Opción"
    '
    'txtOpcion
    '
    Me.txtOpcion.Enabled = False
    Me.txtOpcion.Location = New System.Drawing.Point(426, 84)
    Me.txtOpcion.Name = "txtOpcion"
    Me.txtOpcion.Size = New System.Drawing.Size(202, 21)
    Me.txtOpcion.TabIndex = 7
    '
    'txtMenu
    '
    Me.txtMenu.Enabled = False
    Me.txtMenu.Location = New System.Drawing.Point(426, 59)
    Me.txtMenu.Name = "txtMenu"
    Me.txtMenu.Size = New System.Drawing.Size(202, 21)
    Me.txtMenu.TabIndex = 6
    '
    'txtAplicacion
    '
    Me.txtAplicacion.Enabled = False
    Me.txtAplicacion.Location = New System.Drawing.Point(426, 32)
    Me.txtAplicacion.Name = "txtAplicacion"
    Me.txtAplicacion.Size = New System.Drawing.Size(202, 21)
    Me.txtAplicacion.TabIndex = 5
    '
    'KryptonLabel4
    '
    Me.KryptonLabel4.Location = New System.Drawing.Point(353, 34)
    Me.KryptonLabel4.Name = "KryptonLabel4"
    Me.KryptonLabel4.Size = New System.Drawing.Size(67, 19)
    Me.KryptonLabel4.TabIndex = 4
    Me.KryptonLabel4.Text = "Aplicación :"
    Me.KryptonLabel4.Values.ExtraText = ""
    Me.KryptonLabel4.Values.Image = Nothing
    Me.KryptonLabel4.Values.Text = "Aplicación :"
    '
    'KryptonLabel3
    '
    Me.KryptonLabel3.Location = New System.Drawing.Point(353, 59)
    Me.KryptonLabel3.Name = "KryptonLabel3"
    Me.KryptonLabel3.Size = New System.Drawing.Size(45, 19)
    Me.KryptonLabel3.TabIndex = 3
    Me.KryptonLabel3.Text = "Menú :"
    Me.KryptonLabel3.Values.ExtraText = ""
    Me.KryptonLabel3.Values.Image = Nothing
    Me.KryptonLabel3.Values.Text = "Menú :"
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(353, 84)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(52, 19)
    Me.KryptonLabel2.TabIndex = 2
    Me.KryptonLabel2.Text = "Opción :"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "Opción :"
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(17, 59)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(54, 19)
    Me.KryptonLabel1.TabIndex = 1
    Me.KryptonLabel1.Text = "Usuario :"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Usuario :"
    '
    'Uc_CboUsuario1
    '
    Me.Uc_CboUsuario1.Location = New System.Drawing.Point(77, 56)
    Me.Uc_CboUsuario1.Name = "Uc_CboUsuario1"
    Me.Uc_CboUsuario1.pPSMMCUSR = ""
    Me.Uc_CboUsuario1.pPSMMNUSR = ""
    Me.Uc_CboUsuario1.Size = New System.Drawing.Size(247, 22)
    Me.Uc_CboUsuario1.TabIndex = 0
    '
    'frmManUserOption
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(668, 284)
    Me.Controls.Add(Me.KryptonPanel)
    Me.MaximizeBox = False
    Me.Name = "frmManUserOption"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Mantenimiento"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    Me.KryptonPanel.PerformLayout()
    Me.tsCabecera.ResumeLayout(False)
    Me.tsCabecera.PerformLayout()
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
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
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents Uc_CboUsuario1 As Ransa.Controls.Menu.uc_CboUsuario
  Friend WithEvents txtOpcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents txtMenu As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents txtAplicacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents chkVisualizar As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
  Friend WithEvents chkCambiar As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
  Friend WithEvents chkOpcion3 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
  Friend WithEvents chkAdicionar As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
  Friend WithEvents chkOpcion2 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
  Friend WithEvents chkEliminar As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
  Friend WithEvents chkOpcion1 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
  Friend WithEvents tsCabecera As System.Windows.Forms.ToolStrip
  Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
End Class
