<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnularOperacion
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
        Me.components = New System.ComponentModel.Container()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBuscar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.cboMotivoAnulacion = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.UcArea = New Ransa.Utilitario.ucAyuda()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtUsuarioSolicitante = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.cmbUsuarioSolicitante = New Ransa.Controls.Menu.uc_CboUsuario()
        Me.UcAutorizadoPor = New Ransa.Utilitario.ucAyuda()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtReemplazo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtObservacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtOpReemplazo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtoperacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtfecha = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.Panel1)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.KryptonPanel.Size = New System.Drawing.Size(620, 511)
        Me.KryptonPanel.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.cboMotivoAnulacion)
        Me.Panel1.Controls.Add(Me.UcArea)
        Me.Panel1.Controls.Add(Me.KryptonLabel9)
        Me.Panel1.Controls.Add(Me.txtUsuarioSolicitante)
        Me.Panel1.Controls.Add(Me.cmbUsuarioSolicitante)
        Me.Panel1.Controls.Add(Me.UcAutorizadoPor)
        Me.Panel1.Controls.Add(Me.KryptonLabel8)
        Me.Panel1.Controls.Add(Me.txtReemplazo)
        Me.Panel1.Controls.Add(Me.KryptonLabel7)
        Me.Panel1.Controls.Add(Me.txtObservacion)
        Me.Panel1.Controls.Add(Me.KryptonLabel6)
        Me.Panel1.Controls.Add(Me.KryptonLabel5)
        Me.Panel1.Controls.Add(Me.KryptonLabel4)
        Me.Panel1.Controls.Add(Me.txtOpReemplazo)
        Me.Panel1.Controls.Add(Me.KryptonLabel3)
        Me.Panel1.Controls.Add(Me.txtoperacion)
        Me.Panel1.Controls.Add(Me.KryptonLabel2)
        Me.Panel1.Controls.Add(Me.txtfecha)
        Me.Panel1.Controls.Add(Me.KryptonLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(620, 484)
        Me.Panel1.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(384, 87)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(39, 27)
        Me.btnBuscar.TabIndex = 0
        Me.btnBuscar.Values.ExtraText = ""
        Me.btnBuscar.Values.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.btnBuscar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnBuscar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnBuscar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnBuscar.Values.Text = ""
        '
        'cboMotivoAnulacion
        '
        Me.cboMotivoAnulacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMotivoAnulacion.DropDownWidth = 332
        Me.cboMotivoAnulacion.FormattingEnabled = False
        Me.cboMotivoAnulacion.ItemHeight = 20
        Me.cboMotivoAnulacion.Location = New System.Drawing.Point(208, 224)
        Me.cboMotivoAnulacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboMotivoAnulacion.Name = "cboMotivoAnulacion"
        Me.cboMotivoAnulacion.Size = New System.Drawing.Size(384, 28)
        Me.cboMotivoAnulacion.TabIndex = 4
        '
        'UcArea
        '
        Me.UcArea.BackColor = System.Drawing.Color.Transparent
        Me.UcArea.DataSource = Nothing
        Me.UcArea.DispleyMember = ""
        Me.UcArea.Etiquetas_Form = Nothing
        Me.UcArea.ListColumnas = Nothing
        Me.UcArea.Location = New System.Drawing.Point(209, 191)
        Me.UcArea.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.UcArea.Name = "UcArea"
        Me.UcArea.Obligatorio = False
        Me.UcArea.PopupHeight = 0
        Me.UcArea.PopupWidth = 0
        Me.UcArea.Size = New System.Drawing.Size(383, 36)
        Me.UcArea.SizeFont = 0
        Me.UcArea.TabIndex = 3
        Me.UcArea.ValueMember = ""
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(25, 190)
        Me.KryptonLabel9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(176, 26)
        Me.KryptonLabel9.TabIndex = 58
        Me.KryptonLabel9.Text = "Área de responsabilidad"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Área de responsabilidad"
        '
        'txtUsuarioSolicitante
        '
        Me.txtUsuarioSolicitante.Location = New System.Drawing.Point(211, 155)
        Me.txtUsuarioSolicitante.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUsuarioSolicitante.MaxLength = 40
        Me.txtUsuarioSolicitante.Name = "txtUsuarioSolicitante"
        Me.txtUsuarioSolicitante.Size = New System.Drawing.Size(357, 26)
        Me.txtUsuarioSolicitante.TabIndex = 2
        '
        'cmbUsuarioSolicitante
        '
        Me.cmbUsuarioSolicitante.Location = New System.Drawing.Point(564, 155)
        Me.cmbUsuarioSolicitante.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cmbUsuarioSolicitante.Name = "cmbUsuarioSolicitante"
        Me.cmbUsuarioSolicitante.pPSMMCUSR = ""
        Me.cmbUsuarioSolicitante.pPSMMNUSR = ""
        Me.cmbUsuarioSolicitante.Size = New System.Drawing.Size(29, 27)
        Me.cmbUsuarioSolicitante.TabIndex = 56
        '
        'UcAutorizadoPor
        '
        Me.UcAutorizadoPor.BackColor = System.Drawing.Color.Transparent
        Me.UcAutorizadoPor.DataSource = Nothing
        Me.UcAutorizadoPor.DispleyMember = ""
        Me.UcAutorizadoPor.Etiquetas_Form = Nothing
        Me.UcAutorizadoPor.ListColumnas = Nothing
        Me.UcAutorizadoPor.Location = New System.Drawing.Point(211, 122)
        Me.UcAutorizadoPor.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.UcAutorizadoPor.Name = "UcAutorizadoPor"
        Me.UcAutorizadoPor.Obligatorio = False
        Me.UcAutorizadoPor.PopupHeight = 0
        Me.UcAutorizadoPor.PopupWidth = 0
        Me.UcAutorizadoPor.Size = New System.Drawing.Size(383, 37)
        Me.UcAutorizadoPor.SizeFont = 0
        Me.UcAutorizadoPor.TabIndex = 1
        Me.UcAutorizadoPor.ValueMember = ""
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(24, 383)
        Me.KryptonLabel8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(87, 26)
        Me.KryptonLabel8.TabIndex = 15
        Me.KryptonLabel8.Text = "Reemplazo"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Reemplazo"
        '
        'txtReemplazo
        '
        Me.txtReemplazo.Enabled = False
        Me.txtReemplazo.Location = New System.Drawing.Point(208, 383)
        Me.txtReemplazo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtReemplazo.Name = "txtReemplazo"
        Me.txtReemplazo.Size = New System.Drawing.Size(385, 26)
        Me.txtReemplazo.TabIndex = 8
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(25, 260)
        Me.KryptonLabel7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(96, 26)
        Me.KryptonLabel7.TabIndex = 13
        Me.KryptonLabel7.Text = "Observación"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Observación"
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(208, 260)
        Me.txtObservacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtObservacion.MaxLength = 100
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacion.Size = New System.Drawing.Size(385, 116)
        Me.txtObservacion.TabIndex = 5
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(24, 224)
        Me.KryptonLabel6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(151, 26)
        Me.KryptonLabel6.TabIndex = 11
        Me.KryptonLabel6.Text = "Motivo de anulación"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Motivo de anulación"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(25, 155)
        Me.KryptonLabel5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(106, 26)
        Me.KryptonLabel5.TabIndex = 9
        Me.KryptonLabel5.Text = "Solicitado por"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Solicitado por"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(25, 121)
        Me.KryptonLabel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(114, 26)
        Me.KryptonLabel4.TabIndex = 7
        Me.KryptonLabel4.Text = "Autorizado por"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Autorizado por"
        '
        'txtOpReemplazo
        '
        Me.txtOpReemplazo.Enabled = False
        Me.txtOpReemplazo.Location = New System.Drawing.Point(211, 87)
        Me.txtOpReemplazo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtOpReemplazo.Name = "txtOpReemplazo"
        Me.txtOpReemplazo.Size = New System.Drawing.Size(168, 26)
        Me.txtOpReemplazo.TabIndex = 6
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(24, 87)
        Me.KryptonLabel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(158, 26)
        Me.KryptonLabel3.TabIndex = 5
        Me.KryptonLabel3.Text = "Operación reemplazo"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Operación reemplazo"
        '
        'txtoperacion
        '
        Me.txtoperacion.Enabled = False
        Me.txtoperacion.Location = New System.Drawing.Point(211, 53)
        Me.txtoperacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtoperacion.Name = "txtoperacion"
        Me.txtoperacion.Size = New System.Drawing.Size(133, 26)
        Me.txtoperacion.TabIndex = 2
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(25, 53)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(82, 26)
        Me.KryptonLabel2.TabIndex = 3
        Me.KryptonLabel2.Text = "Operación"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Operación"
        '
        'txtfecha
        '
        Me.txtfecha.Enabled = False
        Me.txtfecha.Location = New System.Drawing.Point(211, 18)
        Me.txtfecha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(133, 26)
        Me.txtfecha.TabIndex = 1
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(25, 18)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(51, 26)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Text = "Fecha"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Fecha"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.ToolStripSeparator1, Me.btnAceptar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(620, 27)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 24)
        Me.btnCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'btnAceptar
        '
        Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAceptar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(85, 24)
        Me.btnAceptar.Text = "Aceptar"
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'frmAnularOperacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 511)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmAnularOperacion"
        Me.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anulación operación con Gastos/AVC"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
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
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtfecha As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtoperacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtReemplazo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtObservacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtUsuarioSolicitante As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtOpReemplazo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents cboMotivoAnulacion As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents UcAutorizadoPor As Ransa.Utilitario.ucAyuda
    Friend WithEvents cmbUsuarioSolicitante As Ransa.Controls.Menu.uc_CboUsuario
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcArea As Ransa.Utilitario.ucAyuda
    Friend WithEvents btnBuscar As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
