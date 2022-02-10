<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm
    'Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.cbxTipoSistema = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.lblSistema = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.grpParametrosGenerales = New System.Windows.Forms.GroupBox
        Me.cbxBaseDatos = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.lblBaseDatos = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cbxServidor = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.lblServidor = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnOpcionesAvanzadas = New ComponentFactory.Krypton.Toolkit.KryptonButton
        ' Me.OleAnimar = New Byteabyte.Windows.Forms.AnimatedColorBar
        Me.pbHead = New System.Windows.Forms.PictureBox
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtUsuario = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtPassword = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblPassword = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblUsuario = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.grpParametrosGenerales.SuspendLayout()
        CType(Me.pbHead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.cbxTipoSistema)
        Me.KryptonPanel.Controls.Add(Me.lblSistema)
        Me.KryptonPanel.Controls.Add(Me.grpParametrosGenerales)
        Me.KryptonPanel.Controls.Add(Me.btnOpcionesAvanzadas)
        ' Me.KryptonPanel.Controls.Add(Me.OleAnimar)
        Me.KryptonPanel.Controls.Add(Me.pbHead)
        Me.KryptonPanel.Controls.Add(Me.btnAceptar)
        Me.KryptonPanel.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel.Controls.Add(Me.txtUsuario)
        Me.KryptonPanel.Controls.Add(Me.txtPassword)
        Me.KryptonPanel.Controls.Add(Me.lblPassword)
        Me.KryptonPanel.Controls.Add(Me.lblUsuario)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(304, 281)
        Me.KryptonPanel.TabIndex = 1
        '
        'cbxTipoSistema
        '
        Me.cbxTipoSistema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoSistema.DropDownWidth = 159
        Me.cbxTipoSistema.FormattingEnabled = False
        Me.cbxTipoSistema.ItemHeight = 13
        Me.cbxTipoSistema.Location = New System.Drawing.Point(84, 128)
        Me.cbxTipoSistema.Name = "cbxTipoSistema"
        Me.cbxTipoSistema.Size = New System.Drawing.Size(208, 21)
        Me.cbxTipoSistema.TabIndex = 6
        '
        'lblSistema
        '
        Me.lblSistema.Location = New System.Drawing.Point(12, 133)
        Me.lblSistema.Name = "lblSistema"
        Me.lblSistema.Size = New System.Drawing.Size(57, 16)
        Me.lblSistema.TabIndex = 5
        Me.lblSistema.Text = "Sistema : "
        Me.lblSistema.Values.ExtraText = ""
        Me.lblSistema.Values.Image = Nothing
        Me.lblSistema.Values.Text = "Sistema : "
        '
        'grpParametrosGenerales
        '
        Me.grpParametrosGenerales.BackColor = System.Drawing.Color.Transparent
        Me.grpParametrosGenerales.Controls.Add(Me.cbxBaseDatos)
        Me.grpParametrosGenerales.Controls.Add(Me.lblBaseDatos)
        Me.grpParametrosGenerales.Controls.Add(Me.cbxServidor)
        Me.grpParametrosGenerales.Controls.Add(Me.lblServidor)
        Me.grpParametrosGenerales.Enabled = False
        Me.grpParametrosGenerales.Location = New System.Drawing.Point(14, 155)
        Me.grpParametrosGenerales.Name = "grpParametrosGenerales"
        Me.grpParametrosGenerales.Size = New System.Drawing.Size(278, 84)
        Me.grpParametrosGenerales.TabIndex = 7
        Me.grpParametrosGenerales.TabStop = False
        Me.grpParametrosGenerales.Text = "Parametros Opcionales"
        '
        'cbxBaseDatos
        '
        Me.cbxBaseDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxBaseDatos.DropDownWidth = 159
        Me.cbxBaseDatos.FormattingEnabled = False
        Me.cbxBaseDatos.ItemHeight = 13
        Me.cbxBaseDatos.Location = New System.Drawing.Point(108, 50)
        Me.cbxBaseDatos.Name = "cbxBaseDatos"
        Me.cbxBaseDatos.Size = New System.Drawing.Size(159, 21)
        Me.cbxBaseDatos.TabIndex = 11
        '
        'lblBaseDatos
        '
        Me.lblBaseDatos.Location = New System.Drawing.Point(15, 55)
        Me.lblBaseDatos.Name = "lblBaseDatos"
        Me.lblBaseDatos.Size = New System.Drawing.Size(90, 16)
        Me.lblBaseDatos.TabIndex = 10
        Me.lblBaseDatos.Text = "Base de Datos :"
        Me.lblBaseDatos.Values.ExtraText = ""
        Me.lblBaseDatos.Values.Image = Nothing
        Me.lblBaseDatos.Values.Text = "Base de Datos :"
        '
        'cbxServidor
        '
        Me.cbxServidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxServidor.DropDownWidth = 159
        Me.cbxServidor.FormattingEnabled = False
        Me.cbxServidor.ItemHeight = 13
        Me.cbxServidor.Location = New System.Drawing.Point(108, 23)
        Me.cbxServidor.Name = "cbxServidor"
        Me.cbxServidor.Size = New System.Drawing.Size(159, 21)
        Me.cbxServidor.TabIndex = 9
        '
        'lblServidor
        '
        Me.lblServidor.Location = New System.Drawing.Point(15, 28)
        Me.lblServidor.Name = "lblServidor"
        Me.lblServidor.Size = New System.Drawing.Size(59, 16)
        Me.lblServidor.TabIndex = 8
        Me.lblServidor.Text = "Servidor :"
        Me.lblServidor.Values.ExtraText = ""
        Me.lblServidor.Values.Image = Nothing
        Me.lblServidor.Values.Text = "Servidor :"
        '
        'btnOpcionesAvanzadas
        '
        Me.btnOpcionesAvanzadas.Location = New System.Drawing.Point(202, 245)
        Me.btnOpcionesAvanzadas.Name = "btnOpcionesAvanzadas"
        Me.btnOpcionesAvanzadas.Size = New System.Drawing.Size(90, 25)
        Me.btnOpcionesAvanzadas.TabIndex = 14
        Me.btnOpcionesAvanzadas.Text = "Opciones..."
        Me.btnOpcionesAvanzadas.Values.ExtraText = ""
        Me.btnOpcionesAvanzadas.Values.Image = Nothing
        Me.btnOpcionesAvanzadas.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnOpcionesAvanzadas.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnOpcionesAvanzadas.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnOpcionesAvanzadas.Values.Text = "Opciones..."
        '
        'OleAnimar
        '
        'Me.OleAnimar.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        'Me.OleAnimar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(251, Byte), Integer))
        'Me.OleAnimar.Location = New System.Drawing.Point(0, 58)
        'Me.OleAnimar.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(159, Byte), Integer))
        'Me.OleAnimar.Name = "OleAnimar"
        'Me.OleAnimar.Size = New System.Drawing.Size(313, 4)
        'Me.OleAnimar.TabIndex = 24
        '
        'pbHead
        '
        Me.pbHead.BackgroundImage = CType(resources.GetObject("pbHead.BackgroundImage"), System.Drawing.Image)
        Me.pbHead.Image = CType(resources.GetObject("pbHead.Image"), System.Drawing.Image)
        Me.pbHead.Location = New System.Drawing.Point(-9, 0)
        Me.pbHead.Name = "pbHead"
        Me.pbHead.Size = New System.Drawing.Size(322, 62)
        Me.pbHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbHead.TabIndex = 27
        Me.pbHead.TabStop = False
        '
        'btnAceptar
        '
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAceptar.Location = New System.Drawing.Point(12, 245)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 25)
        Me.btnAceptar.TabIndex = 12
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.Values.ExtraText = ""
        Me.btnAceptar.Values.Image = CType(resources.GetObject("btnAceptar.Values.Image"), System.Drawing.Image)
        Me.btnAceptar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAceptar.Values.Text = "Aceptar"
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(106, 245)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 25)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = CType(resources.GetObject("btnCancelar.Values.Image"), System.Drawing.Image)
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "Cancelar"
        '
        'txtUsuario
        '
        Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUsuario.Location = New System.Drawing.Point(84, 78)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(208, 19)
        Me.txtUsuario.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.AcceptsTab = True
        Me.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPassword.HideSelection = False
        Me.txtPassword.Location = New System.Drawing.Point(84, 103)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtPassword.Size = New System.Drawing.Size(208, 19)
        Me.txtPassword.StateActive.Content.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtPassword.StateNormal.Content.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtPassword.TabIndex = 4
        '
        'lblPassword
        '
        Me.lblPassword.Location = New System.Drawing.Point(12, 106)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(66, 16)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Password :"
        Me.lblPassword.Values.ExtraText = ""
        Me.lblPassword.Values.Image = Nothing
        Me.lblPassword.Values.Text = "Password :"
        '
        'lblUsuario
        '
        Me.lblUsuario.Location = New System.Drawing.Point(12, 81)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(55, 16)
        Me.lblUsuario.TabIndex = 1
        Me.lblUsuario.Text = "Usuario :"
        Me.lblUsuario.Values.ExtraText = ""
        Me.lblUsuario.Values.Image = Nothing
        Me.lblUsuario.Values.Text = "Usuario :"
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(304, 281)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de sesión..."
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.grpParametrosGenerales.ResumeLayout(False)
        Me.grpParametrosGenerales.PerformLayout()
        CType(Me.pbHead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtUsuario As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtPassword As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblPassword As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblUsuario As ComponentFactory.Krypton.Toolkit.KryptonLabel
    ' Friend WithEvents OleAnimar As Byteabyte.Windows.Forms.AnimatedColorBar
    Friend WithEvents pbHead As System.Windows.Forms.PictureBox
    Friend WithEvents btnOpcionesAvanzadas As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents grpParametrosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents cbxBaseDatos As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents lblBaseDatos As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cbxServidor As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents lblServidor As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cbxTipoSistema As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents lblSistema As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
