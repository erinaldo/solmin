<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevoTransportista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuevoTransportista))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnGuardar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.cboTranspAS400 = New CodeTextBox.CodeTextBox
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtTelefonoTransportista = New SOLMIN_ST.TextField
        Me.txtDireccionTransportista = New SOLMIN_ST.TextField
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDescripcion = New SOLMIN_ST.TextField
        Me.txtRazonSocial = New SOLMIN_ST.TextField
        Me.txtNroRuc = New SOLMIN_ST.TextField
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(392, 246)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnGuardar, Me.btnCancelar})
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup1.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cboTranspAS400)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel8)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtTelefonoTransportista)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtDireccionTransportista)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel9)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtDescripcion)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtRazonSocial)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtNroRuc)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel14)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(392, 246)
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.Text = "Nuevo Transportista"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Nuevo Transportista"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Global.SOLMIN_ST.My.Resources.Resources.edit_add
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Crear Nuevo Transportista"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'btnGuardar
        '
        Me.btnGuardar.ExtraText = ""
        Me.btnGuardar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnGuardar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.btnGuardar.Text = "Grabar"
        Me.btnGuardar.ToolTipImage = Nothing
        Me.btnGuardar.UniqueName = "3FFE30C8DC46433A3FFE30C8DC46433A"
        '
        'btnCancelar
        '
        Me.btnCancelar.ExtraText = ""
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources._exit
        Me.btnCancelar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.ToolTipImage = Nothing
        Me.btnCancelar.UniqueName = "2946D08299FD45452946D08299FD4545"
        '
        'cboTranspAS400
        '
        Me.cboTranspAS400.Codigo = ""
        Me.cboTranspAS400.ControlHeight = 23
        Me.cboTranspAS400.ControlImage = True
        Me.cboTranspAS400.ControlReadOnly = False
        Me.cboTranspAS400.Descripcion = ""
        Me.cboTranspAS400.DisplayColumnVisible = True
        Me.cboTranspAS400.DisplayMember = ""
        Me.cboTranspAS400.KeyColumnWidth = 100
        Me.cboTranspAS400.KeyField = ""
        Me.cboTranspAS400.KeySearch = True
        Me.cboTranspAS400.Location = New System.Drawing.Point(150, 62)
        Me.cboTranspAS400.Name = "cboTranspAS400"
        Me.cboTranspAS400.Size = New System.Drawing.Size(200, 23)
        Me.cboTranspAS400.TabIndex = 2
        Me.cboTranspAS400.TextBackColor = System.Drawing.Color.Empty
        Me.cboTranspAS400.TextForeColor = System.Drawing.Color.Empty
        Me.cboTranspAS400.ValueColumnVisible = True
        Me.cboTranspAS400.ValueColumnWidth = 600
        Me.cboTranspAS400.ValueField = ""
        Me.cboTranspAS400.ValueMember = ""
        Me.cboTranspAS400.ValueSearch = True
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(32, 146)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(60, 16)
        Me.KryptonLabel8.TabIndex = 34
        Me.KryptonLabel8.Text = "Teléfono :"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Teléfono :"
        '
        'txtTelefonoTransportista
        '
        Me.txtTelefonoTransportista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefonoTransportista.Location = New System.Drawing.Point(150, 143)
        Me.txtTelefonoTransportista.MaxLength = 15
        Me.txtTelefonoTransportista.Name = "txtTelefonoTransportista"
        Me.txtTelefonoTransportista.Size = New System.Drawing.Size(200, 19)
        Me.txtTelefonoTransportista.TabIndex = 5
        Me.txtTelefonoTransportista.Text = "0"
        Me.txtTelefonoTransportista.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'txtDireccionTransportista
        '
        Me.txtDireccionTransportista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccionTransportista.Location = New System.Drawing.Point(150, 118)
        Me.txtDireccionTransportista.MaxLength = 30
        Me.txtDireccionTransportista.Name = "txtDireccionTransportista"
        Me.txtDireccionTransportista.Size = New System.Drawing.Size(200, 19)
        Me.txtDireccionTransportista.TabIndex = 4
        Me.txtDireccionTransportista.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(32, 121)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(64, 16)
        Me.KryptonLabel9.TabIndex = 29
        Me.KryptonLabel9.Text = "Dirección :"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Dirección :"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(150, 90)
        Me.txtDescripcion.MaxLength = 20
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(200, 19)
        Me.txtDescripcion.TabIndex = 3
        Me.txtDescripcion.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRazonSocial.Location = New System.Drawing.Point(150, 42)
        Me.txtRazonSocial.MaxLength = 40
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(200, 19)
        Me.txtRazonSocial.TabIndex = 1
        Me.txtRazonSocial.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'txtNroRuc
        '
        Me.txtNroRuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroRuc.Location = New System.Drawing.Point(150, 18)
        Me.txtNroRuc.MaxLength = 11
        Me.txtNroRuc.Name = "txtNroRuc"
        Me.txtNroRuc.Size = New System.Drawing.Size(200, 19)
        Me.txtNroRuc.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNroRuc.TabIndex = 0
        Me.txtNroRuc.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(32, 93)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(76, 16)
        Me.KryptonLabel4.TabIndex = 24
        Me.KryptonLabel4.Text = "Descripción :"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Descripción :"
        '
        'KryptonLabel14
        '
        Me.KryptonLabel14.Location = New System.Drawing.Point(32, 69)
        Me.KryptonLabel14.Name = "KryptonLabel14"
        Me.KryptonLabel14.Size = New System.Drawing.Size(119, 16)
        Me.KryptonLabel14.TabIndex = 22
        Me.KryptonLabel14.Text = "Cód. Transp. AS400 :"
        Me.KryptonLabel14.Values.ExtraText = ""
        Me.KryptonLabel14.Values.Image = Nothing
        Me.KryptonLabel14.Values.Text = "Cód. Transp. AS400 :"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(32, 45)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(83, 16)
        Me.KryptonLabel3.TabIndex = 23
        Me.KryptonLabel3.Text = "Razón Social :"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Razón Social :"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(32, 21)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(71, 16)
        Me.KryptonLabel1.TabIndex = 20
        Me.KryptonLabel1.Text = "Nro  R.U.C :"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Nro  R.U.C :"
        '
        'frmNuevoTransportista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 246)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 280)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(400, 280)
        Me.Name = "frmNuevoTransportista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Transportista"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
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
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents cboTranspAS400 As CodeTextBox.CodeTextBox
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTelefonoTransportista As SOLMIN_ST.TextField
    Friend WithEvents txtDireccionTransportista As SOLMIN_ST.TextField
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDescripcion As SOLMIN_ST.TextField
    Friend WithEvents txtRazonSocial As SOLMIN_ST.TextField
    Friend WithEvents txtNroRuc As SOLMIN_ST.TextField
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnGuardar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
End Class
