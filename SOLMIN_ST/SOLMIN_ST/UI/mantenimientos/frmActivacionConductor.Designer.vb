<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActivacionConductor
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
    Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.HeaderDatos = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.txtNombres = New SOLMIN_ST.TextField
    Me.txtApellidoMaterno = New SOLMIN_ST.TextField
    Me.txtFecha = New SOLMIN_ST.TextField
    Me.txtEstado = New SOLMIN_ST.TextField
    Me.txtApellidoPaterno = New SOLMIN_ST.TextField
    Me.txtBrevete = New SOLMIN_ST.TextField
    Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtObservacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.MenuBar = New System.Windows.Forms.ToolStrip
    Me.btnAceptar = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
    Me.btnCancelar = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
    Me.btnSalir = New System.Windows.Forms.ToolStripButton
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.HeaderDatos.Panel.SuspendLayout()
    Me.HeaderDatos.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.MenuBar.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.HeaderDatos)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(490, 335)
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
    Me.HeaderDatos.Size = New System.Drawing.Size(490, 335)
    Me.HeaderDatos.TabIndex = 2
    Me.HeaderDatos.Text = "Información de la Acción"
    Me.HeaderDatos.ValuesPrimary.Description = ""
    Me.HeaderDatos.ValuesPrimary.Heading = "Información de la Acción"
    Me.HeaderDatos.ValuesPrimary.Image = Nothing
    Me.HeaderDatos.ValuesSecondary.Description = ""
    Me.HeaderDatos.ValuesSecondary.Heading = "Description"
    Me.HeaderDatos.ValuesSecondary.Image = Nothing
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.Color.White
    Me.Panel1.Controls.Add(Me.txtNombres)
    Me.Panel1.Controls.Add(Me.txtApellidoMaterno)
    Me.Panel1.Controls.Add(Me.txtFecha)
    Me.Panel1.Controls.Add(Me.txtEstado)
    Me.Panel1.Controls.Add(Me.txtApellidoPaterno)
    Me.Panel1.Controls.Add(Me.txtBrevete)
    Me.Panel1.Controls.Add(Me.KryptonLabel3)
    Me.Panel1.Controls.Add(Me.KryptonLabel4)
    Me.Panel1.Controls.Add(Me.KryptonLabel5)
    Me.Panel1.Controls.Add(Me.KryptonLabel6)
    Me.Panel1.Controls.Add(Me.KryptonLabel1)
    Me.Panel1.Controls.Add(Me.KryptonLabel2)
    Me.Panel1.Controls.Add(Me.KryptonLabel7)
    Me.Panel1.Controls.Add(Me.txtObservacion)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(0, 29)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(488, 284)
    Me.Panel1.TabIndex = 35
    '
    'txtNombres
    '
    Me.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtNombres.Location = New System.Drawing.Point(115, 134)
    Me.txtNombres.MaxLength = 15
    Me.txtNombres.Name = "txtNombres"
    Me.txtNombres.Size = New System.Drawing.Size(349, 21)
    Me.txtNombres.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtNombres.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtNombres.TabIndex = 81
    Me.txtNombres.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
    '
    'txtApellidoMaterno
    '
    Me.txtApellidoMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtApellidoMaterno.Location = New System.Drawing.Point(115, 108)
    Me.txtApellidoMaterno.MaxLength = 15
    Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
    Me.txtApellidoMaterno.Size = New System.Drawing.Size(349, 21)
    Me.txtApellidoMaterno.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtApellidoMaterno.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtApellidoMaterno.TabIndex = 80
    Me.txtApellidoMaterno.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
    '
    'txtFecha
    '
    Me.txtFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtFecha.Location = New System.Drawing.Point(315, 16)
    Me.txtFecha.MaxLength = 15
    Me.txtFecha.Name = "txtFecha"
    Me.txtFecha.Size = New System.Drawing.Size(149, 21)
    Me.txtFecha.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtFecha.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtFecha.TabIndex = 79
    Me.txtFecha.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
    '
    'txtEstado
    '
    Me.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtEstado.Location = New System.Drawing.Point(115, 19)
    Me.txtEstado.MaxLength = 15
    Me.txtEstado.Name = "txtEstado"
    Me.txtEstado.Size = New System.Drawing.Size(146, 21)
    Me.txtEstado.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtEstado.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtEstado.TabIndex = 78
    Me.txtEstado.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
    '
    'txtApellidoPaterno
    '
    Me.txtApellidoPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtApellidoPaterno.Location = New System.Drawing.Point(115, 83)
    Me.txtApellidoPaterno.MaxLength = 15
    Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
    Me.txtApellidoPaterno.Size = New System.Drawing.Size(349, 21)
    Me.txtApellidoPaterno.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtApellidoPaterno.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtApellidoPaterno.TabIndex = 77
    Me.txtApellidoPaterno.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
    '
    'txtBrevete
    '
    Me.txtBrevete.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtBrevete.Location = New System.Drawing.Point(115, 51)
    Me.txtBrevete.MaxLength = 15
    Me.txtBrevete.Name = "txtBrevete"
    Me.txtBrevete.Size = New System.Drawing.Size(146, 21)
    Me.txtBrevete.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtBrevete.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtBrevete.TabIndex = 76
    Me.txtBrevete.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
    '
    'KryptonLabel3
    '
    Me.KryptonLabel3.Location = New System.Drawing.Point(16, 51)
    Me.KryptonLabel3.Name = "KryptonLabel3"
    Me.KryptonLabel3.Size = New System.Drawing.Size(48, 19)
    Me.KryptonLabel3.TabIndex = 75
    Me.KryptonLabel3.Text = "Brevete"
    Me.KryptonLabel3.Values.ExtraText = ""
    Me.KryptonLabel3.Values.Image = Nothing
    Me.KryptonLabel3.Values.Text = "Brevete"
    '
    'KryptonLabel4
    '
    Me.KryptonLabel4.Location = New System.Drawing.Point(16, 137)
    Me.KryptonLabel4.Name = "KryptonLabel4"
    Me.KryptonLabel4.Size = New System.Drawing.Size(59, 19)
    Me.KryptonLabel4.TabIndex = 73
    Me.KryptonLabel4.Text = "Nombres:"
    Me.KryptonLabel4.Values.ExtraText = ""
    Me.KryptonLabel4.Values.Image = Nothing
    Me.KryptonLabel4.Values.Text = "Nombres:"
    '
    'KryptonLabel5
    '
    Me.KryptonLabel5.Location = New System.Drawing.Point(16, 83)
    Me.KryptonLabel5.Name = "KryptonLabel5"
    Me.KryptonLabel5.Size = New System.Drawing.Size(94, 19)
    Me.KryptonLabel5.TabIndex = 71
    Me.KryptonLabel5.Text = "Apellido Paterno"
    Me.KryptonLabel5.Values.ExtraText = ""
    Me.KryptonLabel5.Values.Image = Nothing
    Me.KryptonLabel5.Values.Text = "Apellido Paterno"
    '
    'KryptonLabel6
    '
    Me.KryptonLabel6.Location = New System.Drawing.Point(16, 111)
    Me.KryptonLabel6.Name = "KryptonLabel6"
    Me.KryptonLabel6.Size = New System.Drawing.Size(97, 19)
    Me.KryptonLabel6.TabIndex = 72
    Me.KryptonLabel6.Text = "Apellido Materno"
    Me.KryptonLabel6.Values.ExtraText = ""
    Me.KryptonLabel6.Values.Image = Nothing
    Me.KryptonLabel6.Values.Text = "Apellido Materno"
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(267, 17)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(39, 19)
    Me.KryptonLabel1.TabIndex = 1
    Me.KryptonLabel1.Text = "Fecha"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Fecha"
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(16, 16)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(44, 19)
    Me.KryptonLabel2.TabIndex = 3
    Me.KryptonLabel2.Text = "Acción"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "Acción"
    '
    'KryptonLabel7
    '
    Me.KryptonLabel7.Location = New System.Drawing.Point(16, 193)
    Me.KryptonLabel7.Name = "KryptonLabel7"
    Me.KryptonLabel7.Size = New System.Drawing.Size(72, 19)
    Me.KryptonLabel7.TabIndex = 13
    Me.KryptonLabel7.Text = "Observación"
    Me.KryptonLabel7.Values.ExtraText = ""
    Me.KryptonLabel7.Values.Image = Nothing
    Me.KryptonLabel7.Values.Text = "Observación"
    '
    'txtObservacion
    '
    Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtObservacion.Location = New System.Drawing.Point(115, 159)
    Me.txtObservacion.MaxLength = 40
    Me.txtObservacion.Multiline = True
    Me.txtObservacion.Name = "txtObservacion"
    Me.txtObservacion.Size = New System.Drawing.Size(349, 117)
    Me.txtObservacion.TabIndex = 2
    '
    'MenuBar
    '
    Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.MenuBar.ImageScalingSize = New System.Drawing.Size(22, 22)
    Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAceptar, Me.ToolStripSeparator2, Me.btnCancelar, Me.ToolStripSeparator3, Me.btnSalir})
    Me.MenuBar.Location = New System.Drawing.Point(0, 0)
    Me.MenuBar.Name = "MenuBar"
    Me.MenuBar.Size = New System.Drawing.Size(488, 29)
    Me.MenuBar.TabIndex = 0
    Me.MenuBar.Text = "ToolStrip1"
    '
    'btnAceptar
    '
    Me.btnAceptar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok
    Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnAceptar.Name = "btnAceptar"
    Me.btnAceptar.Size = New System.Drawing.Size(72, 26)
    Me.btnAceptar.Text = "Aceptar"
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 29)
    '
    'btnCancelar
    '
    Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources._stop
    Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(77, 26)
    Me.btnCancelar.Text = "Cancelar"
    '
    'ToolStripSeparator3
    '
    Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
    Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 29)
    '
    'btnSalir
    '
    Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnSalir.Image = Global.SOLMIN_ST.My.Resources.Resources._exit
    Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnSalir.Name = "btnSalir"
    Me.btnSalir.Size = New System.Drawing.Size(55, 26)
    Me.btnSalir.Text = "Salir"
    '
    'frmActivacionConductor
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(490, 335)
    Me.ControlBox = False
    Me.Controls.Add(Me.KryptonPanel)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmActivacionConductor"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Habilitar/Deshabilitar Conductor"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderDatos.Panel.ResumeLayout(False)
    Me.HeaderDatos.Panel.PerformLayout()
    CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderDatos.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.MenuBar.ResumeLayout(False)
    Me.MenuBar.PerformLayout()
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
    Friend WithEvents HeaderDatos As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtObservacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNombres As SOLMIN_ST.TextField
    Friend WithEvents txtApellidoMaterno As SOLMIN_ST.TextField
    Friend WithEvents txtFecha As SOLMIN_ST.TextField
    Friend WithEvents txtEstado As SOLMIN_ST.TextField
    Friend WithEvents txtApellidoPaterno As SOLMIN_ST.TextField
    Friend WithEvents txtBrevete As SOLMIN_ST.TextField
End Class
