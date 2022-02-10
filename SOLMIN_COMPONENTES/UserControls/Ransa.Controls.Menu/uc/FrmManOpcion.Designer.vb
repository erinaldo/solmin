<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManOpcion
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmManOpcion))
    Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.txtFuncion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.Uc_CboMenu = New Ransa.Controls.Menu.uc_CboMenu
    Me.mnuAplicacionMenu = New System.Windows.Forms.ToolStrip
    Me.btnCancelar = New System.Windows.Forms.ToolStripButton
    Me.btnAceptar = New System.Windows.Forms.ToolStripButton
    Me.LabelOpcion = New System.Windows.Forms.ToolStripLabel
    Me.cboTipoOpcion = New System.Windows.Forms.ComboBox
    Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.Uc_CboAplicacion = New Ransa.Controls.Menu.uc_CboAplicacion
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtProgramaVB = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.txtProceso = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.txtDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtTipoVariable = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.txtDireccion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.lblNomPrograma = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtCodigo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.KryptonManager1 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.KryptonManager2 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel2.SuspendLayout()
    CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel1.SuspendLayout()
    Me.mnuAplicacionMenu.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.KryptonPanel2)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(470, 275)
    Me.KryptonPanel.TabIndex = 0
    '
    'KryptonPanel2
    '
    Me.KryptonPanel2.Controls.Add(Me.KryptonPanel1)
    Me.KryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel2.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel2.Name = "KryptonPanel2"
    Me.KryptonPanel2.Size = New System.Drawing.Size(470, 275)
    Me.KryptonPanel2.TabIndex = 1
    '
    'KryptonPanel1
    '
    Me.KryptonPanel1.Controls.Add(Me.txtFuncion)
    Me.KryptonPanel1.Controls.Add(Me.Uc_CboMenu)
    Me.KryptonPanel1.Controls.Add(Me.mnuAplicacionMenu)
    Me.KryptonPanel1.Controls.Add(Me.cboTipoOpcion)
    Me.KryptonPanel1.Controls.Add(Me.KryptonLabel5)
    Me.KryptonPanel1.Controls.Add(Me.Uc_CboAplicacion)
    Me.KryptonPanel1.Controls.Add(Me.KryptonLabel2)
    Me.KryptonPanel1.Controls.Add(Me.txtProgramaVB)
    Me.KryptonPanel1.Controls.Add(Me.txtProceso)
    Me.KryptonPanel1.Controls.Add(Me.txtDescripcion)
    Me.KryptonPanel1.Controls.Add(Me.KryptonLabel10)
    Me.KryptonPanel1.Controls.Add(Me.txtTipoVariable)
    Me.KryptonPanel1.Controls.Add(Me.txtDireccion)
    Me.KryptonPanel1.Controls.Add(Me.lblNomPrograma)
    Me.KryptonPanel1.Controls.Add(Me.KryptonLabel9)
    Me.KryptonPanel1.Controls.Add(Me.KryptonLabel4)
    Me.KryptonPanel1.Controls.Add(Me.KryptonLabel1)
    Me.KryptonPanel1.Controls.Add(Me.KryptonLabel3)
    Me.KryptonPanel1.Controls.Add(Me.KryptonLabel8)
    Me.KryptonPanel1.Controls.Add(Me.KryptonLabel7)
    Me.KryptonPanel1.Controls.Add(Me.txtCodigo)
    Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel1.Name = "KryptonPanel1"
    Me.KryptonPanel1.Size = New System.Drawing.Size(470, 275)
    Me.KryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White
    Me.KryptonPanel1.TabIndex = 1
    '
    'txtFuncion
    '
    Me.txtFuncion.Enabled = False
    Me.txtFuncion.Location = New System.Drawing.Point(131, 136)
    Me.txtFuncion.MaxLength = 10
    Me.txtFuncion.Name = "txtFuncion"
    Me.txtFuncion.Size = New System.Drawing.Size(96, 21)
    Me.txtFuncion.TabIndex = 4
    '
    'Uc_CboMenu
    '
    Me.Uc_CboMenu.Enabled = False
    Me.Uc_CboMenu.Location = New System.Drawing.Point(131, 188)
    Me.Uc_CboMenu.Name = "Uc_CboMenu"
    Me.Uc_CboMenu.pPSMMCAPL = ""
    Me.Uc_CboMenu.Size = New System.Drawing.Size(207, 22)
    Me.Uc_CboMenu.TabIndex = 7
    '
    'mnuAplicacionMenu
    '
    Me.mnuAplicacionMenu.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.mnuAplicacionMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.mnuAplicacionMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.btnAceptar, Me.LabelOpcion})
    Me.mnuAplicacionMenu.Location = New System.Drawing.Point(0, 0)
    Me.mnuAplicacionMenu.Name = "mnuAplicacionMenu"
    Me.mnuAplicacionMenu.Size = New System.Drawing.Size(470, 25)
    Me.mnuAplicacionMenu.TabIndex = 10
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
    'btnAceptar
    '
    Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
    Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnAceptar.Name = "btnAceptar"
    Me.btnAceptar.Size = New System.Drawing.Size(66, 22)
    Me.btnAceptar.Text = "Aceptar"
    '
    'LabelOpcion
    '
    Me.LabelOpcion.Name = "LabelOpcion"
    Me.LabelOpcion.Size = New System.Drawing.Size(0, 22)
    '
    'cboTipoOpcion
    '
    Me.cboTipoOpcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipoOpcion.FormattingEnabled = True
    Me.cboTipoOpcion.Location = New System.Drawing.Point(275, 47)
    Me.cboTipoOpcion.Name = "cboTipoOpcion"
    Me.cboTipoOpcion.Size = New System.Drawing.Size(177, 21)
    Me.cboTipoOpcion.TabIndex = 1
    '
    'KryptonLabel5
    '
    Me.KryptonLabel5.Location = New System.Drawing.Point(28, 49)
    Me.KryptonLabel5.Name = "KryptonLabel5"
    Me.KryptonLabel5.Size = New System.Drawing.Size(47, 19)
    Me.KryptonLabel5.TabIndex = 60
    Me.KryptonLabel5.Text = "Código"
    Me.KryptonLabel5.Values.ExtraText = ""
    Me.KryptonLabel5.Values.Image = Nothing
    Me.KryptonLabel5.Values.Text = "Código"
    '
    'Uc_CboAplicacion
    '
    Me.Uc_CboAplicacion.Enabled = False
    Me.Uc_CboAplicacion.Location = New System.Drawing.Point(131, 163)
    Me.Uc_CboAplicacion.Name = "Uc_CboAplicacion"
    Me.Uc_CboAplicacion.Size = New System.Drawing.Size(207, 22)
    Me.Uc_CboAplicacion.TabIndex = 6
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(194, 47)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(75, 19)
    Me.KryptonLabel2.TabIndex = 60
    Me.KryptonLabel2.Text = "Tipo opción :"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "Tipo opción :"
    '
    'txtProgramaVB
    '
    Me.txtProgramaVB.Enabled = False
    Me.txtProgramaVB.Location = New System.Drawing.Point(131, 74)
    Me.txtProgramaVB.MaxLength = 40
    Me.txtProgramaVB.Name = "txtProgramaVB"
    Me.txtProgramaVB.Size = New System.Drawing.Size(321, 21)
    Me.txtProgramaVB.TabIndex = 2
    '
    'txtProceso
    '
    Me.txtProceso.Enabled = False
    Me.txtProceso.Location = New System.Drawing.Point(359, 136)
    Me.txtProceso.MaxLength = 10
    Me.txtProceso.Name = "txtProceso"
    Me.txtProceso.Size = New System.Drawing.Size(93, 21)
    Me.txtProceso.TabIndex = 5
    '
    'txtDescripcion
    '
    Me.txtDescripcion.Enabled = False
    Me.txtDescripcion.Location = New System.Drawing.Point(131, 101)
    Me.txtDescripcion.MaxLength = 25
    Me.txtDescripcion.Name = "txtDescripcion"
    Me.txtDescripcion.Size = New System.Drawing.Size(321, 21)
    Me.txtDescripcion.TabIndex = 3
    '
    'KryptonLabel10
    '
    Me.KryptonLabel10.Location = New System.Drawing.Point(28, 138)
    Me.KryptonLabel10.Name = "KryptonLabel10"
    Me.KryptonLabel10.Size = New System.Drawing.Size(55, 19)
    Me.KryptonLabel10.TabIndex = 66
    Me.KryptonLabel10.Text = "Función :"
    Me.KryptonLabel10.Values.ExtraText = ""
    Me.KryptonLabel10.Values.Image = Nothing
    Me.KryptonLabel10.Values.Text = "Función :"
    '
    'txtTipoVariable
    '
    Me.txtTipoVariable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtTipoVariable.Enabled = False
    Me.txtTipoVariable.Location = New System.Drawing.Point(131, 214)
    Me.txtTipoVariable.MaxLength = 1
    Me.txtTipoVariable.Name = "txtTipoVariable"
    Me.txtTipoVariable.Size = New System.Drawing.Size(47, 21)
    Me.txtTipoVariable.TabIndex = 8
    '
    'txtDireccion
    '
    Me.txtDireccion.Enabled = False
    Me.txtDireccion.Location = New System.Drawing.Point(131, 241)
    Me.txtDireccion.MaxLength = 60
    Me.txtDireccion.Name = "txtDireccion"
    Me.txtDireccion.Size = New System.Drawing.Size(279, 21)
    Me.txtDireccion.TabIndex = 9
    '
    'lblNomPrograma
    '
    Me.lblNomPrograma.Location = New System.Drawing.Point(28, 74)
    Me.lblNomPrograma.Name = "lblNomPrograma"
    Me.lblNomPrograma.Size = New System.Drawing.Size(64, 19)
    Me.lblNomPrograma.TabIndex = 62
    Me.lblNomPrograma.Text = "Formulario"
    Me.lblNomPrograma.Values.ExtraText = ""
    Me.lblNomPrograma.Values.Image = Nothing
    Me.lblNomPrograma.Values.Text = "Formulario"
    '
    'KryptonLabel9
    '
    Me.KryptonLabel9.Location = New System.Drawing.Point(28, 241)
    Me.KryptonLabel9.Name = "KryptonLabel9"
    Me.KryptonLabel9.Size = New System.Drawing.Size(63, 19)
    Me.KryptonLabel9.TabIndex = 62
    Me.KryptonLabel9.Text = "Dirección :"
    Me.KryptonLabel9.Values.ExtraText = ""
    Me.KryptonLabel9.Values.Image = Nothing
    Me.KryptonLabel9.Values.Text = "Dirección :"
    '
    'KryptonLabel4
    '
    Me.KryptonLabel4.Location = New System.Drawing.Point(28, 216)
    Me.KryptonLabel4.Name = "KryptonLabel4"
    Me.KryptonLabel4.Size = New System.Drawing.Size(80, 19)
    Me.KryptonLabel4.TabIndex = 62
    Me.KryptonLabel4.Text = "Tipo variable :"
    Me.KryptonLabel4.Values.ExtraText = ""
    Me.KryptonLabel4.Values.Image = Nothing
    Me.KryptonLabel4.Values.Text = "Tipo variable :"
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(28, 103)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(96, 19)
    Me.KryptonLabel1.TabIndex = 62
    Me.KryptonLabel1.Text = "Título Formulario"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Título Formulario"
    '
    'KryptonLabel3
    '
    Me.KryptonLabel3.Location = New System.Drawing.Point(259, 138)
    Me.KryptonLabel3.Name = "KryptonLabel3"
    Me.KryptonLabel3.Size = New System.Drawing.Size(55, 19)
    Me.KryptonLabel3.TabIndex = 62
    Me.KryptonLabel3.Text = "Proceso :"
    Me.KryptonLabel3.Values.ExtraText = ""
    Me.KryptonLabel3.Values.Image = Nothing
    Me.KryptonLabel3.Values.Text = "Proceso :"
    '
    'KryptonLabel8
    '
    Me.KryptonLabel8.Location = New System.Drawing.Point(28, 191)
    Me.KryptonLabel8.Name = "KryptonLabel8"
    Me.KryptonLabel8.Size = New System.Drawing.Size(76, 19)
    Me.KryptonLabel8.TabIndex = 62
    Me.KryptonLabel8.Text = "Menú inicial :"
    Me.KryptonLabel8.Values.ExtraText = ""
    Me.KryptonLabel8.Values.Image = Nothing
    Me.KryptonLabel8.Values.Text = "Menú inicial :"
    '
    'KryptonLabel7
    '
    Me.KryptonLabel7.Location = New System.Drawing.Point(28, 166)
    Me.KryptonLabel7.Name = "KryptonLabel7"
    Me.KryptonLabel7.Size = New System.Drawing.Size(99, 19)
    Me.KryptonLabel7.TabIndex = 62
    Me.KryptonLabel7.Text = "Aplicacion inicial :"
    Me.KryptonLabel7.Values.ExtraText = ""
    Me.KryptonLabel7.Values.Image = Nothing
    Me.KryptonLabel7.Values.Text = "Aplicacion inicial :"
    '
    'txtCodigo
    '
    Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtCodigo.Enabled = False
    Me.txtCodigo.Location = New System.Drawing.Point(131, 47)
    Me.txtCodigo.MaxLength = 2
    Me.txtCodigo.Name = "txtCodigo"
    Me.txtCodigo.Size = New System.Drawing.Size(47, 21)
    Me.txtCodigo.TabIndex = 0
    '
    'FrmManOpcion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(470, 275)
    Me.Controls.Add(Me.KryptonPanel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.Name = "FrmManOpcion"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Mantenimiento Opción"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel2.ResumeLayout(False)
    CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel1.ResumeLayout(False)
    Me.KryptonPanel1.PerformLayout()
    Me.mnuAplicacionMenu.ResumeLayout(False)
    Me.mnuAplicacionMenu.PerformLayout()
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
  Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
  Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
  Friend WithEvents txtDescripcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtCodigo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents mnuAplicacionMenu As System.Windows.Forms.ToolStrip
  Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
  Friend WithEvents KryptonManager1 As ComponentFactory.Krypton.Toolkit.KryptonManager
  Friend WithEvents KryptonManager2 As ComponentFactory.Krypton.Toolkit.KryptonManager
  Friend WithEvents LabelOpcion As System.Windows.Forms.ToolStripLabel
  Friend WithEvents txtProgramaVB As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents lblNomPrograma As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtTipoVariable As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents txtProceso As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtDireccion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents Uc_CboMenu As Ransa.Controls.Menu.uc_CboMenu
  Friend WithEvents Uc_CboAplicacion As Ransa.Controls.Menu.uc_CboAplicacion
  Friend WithEvents cboTipoOpcion As System.Windows.Forms.ComboBox
  Friend WithEvents txtFuncion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
