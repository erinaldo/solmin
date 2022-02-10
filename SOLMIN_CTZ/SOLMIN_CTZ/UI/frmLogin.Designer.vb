<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.sstAtributos = New System.Windows.Forms.StatusStrip
        Me.tssBlanco = New System.Windows.Forms.ToolStripStatusLabel
        Me.tssBD = New System.Windows.Forms.ToolStripStatusLabel
        Me.tssVersion = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblUsuario = New System.Windows.Forms.Label
        Me.lblPassword = New System.Windows.Forms.Label
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.ttpTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.pbxLogin = New System.Windows.Forms.PictureBox
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.sstAtributos.SuspendLayout()
        CType(Me.pbxLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sstAtributos
        '
        Me.sstAtributos.BackColor = System.Drawing.Color.Green
        Me.sstAtributos.GripMargin = New System.Windows.Forms.Padding(0)
        Me.sstAtributos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssBlanco, Me.tssBD, Me.tssVersion})
        Me.sstAtributos.Location = New System.Drawing.Point(0, 207)
        Me.sstAtributos.Name = "sstAtributos"
        Me.sstAtributos.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.sstAtributos.Size = New System.Drawing.Size(243, 24)
        Me.sstAtributos.SizingGrip = False
        Me.sstAtributos.TabIndex = 6
        '
        'tssBlanco
        '
        Me.tssBlanco.AutoSize = False
        Me.tssBlanco.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold)
        Me.tssBlanco.ForeColor = System.Drawing.Color.DarkOrange
        Me.tssBlanco.Name = "tssBlanco"
        Me.tssBlanco.Size = New System.Drawing.Size(108, 19)
        Me.tssBlanco.Spring = True
        Me.tssBlanco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tssBD
        '
        Me.tssBD.AutoToolTip = True
        Me.tssBD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tssBD.ForeColor = System.Drawing.Color.White
        Me.tssBD.Name = "tssBD"
        Me.tssBD.Size = New System.Drawing.Size(76, 19)
        Me.tssBD.Text = "Base de Datos"
        Me.tssBD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tssBD.ToolTipText = "Base de Datos"
        '
        'tssVersion
        '
        Me.tssVersion.AutoToolTip = True
        Me.tssVersion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tssVersion.ForeColor = System.Drawing.Color.White
        Me.tssVersion.Name = "tssVersion"
        Me.tssVersion.Size = New System.Drawing.Size(42, 19)
        Me.tssVersion.Text = "Versión"
        Me.tssVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tssVersion.ToolTipText = "Versión"
        '
        'lblUsuario
        '
        Me.lblUsuario.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblUsuario.Image = CType(resources.GetObject("lblUsuario.Image"), System.Drawing.Image)
        Me.lblUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblUsuario.Location = New System.Drawing.Point(13, 89)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(103, 22)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "     Usuario :"
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPassword
        '
        Me.lblPassword.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblPassword.Image = CType(resources.GetObject("lblPassword.Image"), System.Drawing.Image)
        Me.lblPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPassword.Location = New System.Drawing.Point(13, 122)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(103, 22)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Contraseña :"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUsuario
        '
        Me.txtUsuario.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtUsuario.Location = New System.Drawing.Point(122, 89)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(104, 20)
        Me.txtUsuario.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtPassword.Location = New System.Drawing.Point(122, 122)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(104, 20)
        Me.txtPassword.TabIndex = 3
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(136, 160)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 31)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.ttpTip.SetToolTip(Me.btnCancelar, "Cancelar")
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = Global.SOLMIN_CT.My.Resources.Resources.redled
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(26, 160)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 31)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Ingresar"
        Me.ttpTip.SetToolTip(Me.btnAceptar, "Ingresar")
        Me.btnAceptar.Values.ExtraText = ""
        Me.btnAceptar.Values.Image = Global.SOLMIN_CT.My.Resources.Resources.greenled
        Me.btnAceptar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAceptar.Values.Text = "Ingresar"
        '
        'pbxLogin
        '
        Me.pbxLogin.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbxLogin.Image = CType(resources.GetObject("pbxLogin.Image"), System.Drawing.Image)
        Me.pbxLogin.InitialImage = Nothing
        Me.pbxLogin.Location = New System.Drawing.Point(0, 0)
        Me.pbxLogin.Name = "pbxLogin"
        Me.pbxLogin.Size = New System.Drawing.Size(243, 70)
        Me.pbxLogin.TabIndex = 10
        Me.pbxLogin.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(243, 231)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.pbxLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.sstAtributos)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seguimiento Logístico Minero"
        Me.sstAtributos.ResumeLayout(False)
        Me.sstAtributos.PerformLayout()
        CType(Me.pbxLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents sstAtributos As System.Windows.Forms.StatusStrip
    Friend WithEvents tssBlanco As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssBD As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssVersion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents ttpTip As System.Windows.Forms.ToolTip
    Friend WithEvents pbxLogin As System.Windows.Forms.PictureBox
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
