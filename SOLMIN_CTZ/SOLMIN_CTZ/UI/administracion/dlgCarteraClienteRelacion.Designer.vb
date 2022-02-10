<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCarteraClienteRelacion
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
        Me.txtCodGrupoCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.btnCancelarRelacion = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnGuardarRelacion = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.txtGrupoCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.txtGrupoCliente)
        Me.KryptonPanel.Controls.Add(Me.txtCodGrupoCliente)
        Me.KryptonPanel.Controls.Add(Me.btnCancelarRelacion)
        Me.KryptonPanel.Controls.Add(Me.btnGuardarRelacion)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.UcCliente)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(431, 126)
        Me.KryptonPanel.TabIndex = 0
        '
        'txtCodGrupoCliente
        '
        Me.txtCodGrupoCliente.Enabled = False
        Me.txtCodGrupoCliente.Location = New System.Drawing.Point(63, 12)
        Me.txtCodGrupoCliente.Name = "txtCodGrupoCliente"
        Me.txtCodGrupoCliente.Size = New System.Drawing.Size(51, 21)
        Me.txtCodGrupoCliente.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodGrupoCliente.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodGrupoCliente.TabIndex = 45
        Me.txtCodGrupoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCancelarRelacion
        '
        Me.btnCancelarRelacion.Location = New System.Drawing.Point(217, 65)
        Me.btnCancelarRelacion.Name = "btnCancelarRelacion"
        Me.btnCancelarRelacion.Size = New System.Drawing.Size(90, 37)
        Me.btnCancelarRelacion.TabIndex = 5
        Me.btnCancelarRelacion.Text = "Cancelar"
        Me.btnCancelarRelacion.Values.ExtraText = ""
        Me.btnCancelarRelacion.Values.Image = Nothing
        Me.btnCancelarRelacion.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelarRelacion.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelarRelacion.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelarRelacion.Values.Text = "Cancelar"
        '
        'btnGuardarRelacion
        '
        Me.btnGuardarRelacion.Location = New System.Drawing.Point(117, 65)
        Me.btnGuardarRelacion.Name = "btnGuardarRelacion"
        Me.btnGuardarRelacion.Size = New System.Drawing.Size(90, 37)
        Me.btnGuardarRelacion.TabIndex = 4
        Me.btnGuardarRelacion.Text = "Guardar"
        Me.btnGuardarRelacion.Values.ExtraText = ""
        Me.btnGuardarRelacion.Values.Image = Nothing
        Me.btnGuardarRelacion.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnGuardarRelacion.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnGuardarRelacion.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnGuardarRelacion.Values.Text = "Guardar"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(11, 41)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(45, 19)
        Me.KryptonLabel2.TabIndex = 3
        Me.KryptonLabel2.Text = "Cliente"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Cliente"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(12, 11)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(42, 19)
        Me.KryptonLabel1.TabIndex = 2
        Me.KryptonLabel1.Text = "Grupo"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Grupo"
        '
        'UcCliente
        '
        Me.UcCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcCliente.BackColor = System.Drawing.Color.Transparent
        Me.UcCliente.CCMPN = "EZ"
        Me.UcCliente.Location = New System.Drawing.Point(63, 38)
        Me.UcCliente.Name = "UcCliente"
        Me.UcCliente.pAccesoPorUsuario = False
        Me.UcCliente.pRequerido = False
        Me.UcCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.UcCliente.Size = New System.Drawing.Size(356, 21)
        Me.UcCliente.TabIndex = 0
        '
        'txtGrupoCliente
        '
        Me.txtGrupoCliente.Enabled = False
        Me.txtGrupoCliente.Location = New System.Drawing.Point(120, 12)
        Me.txtGrupoCliente.Name = "txtGrupoCliente"
        Me.txtGrupoCliente.Size = New System.Drawing.Size(299, 21)
        Me.txtGrupoCliente.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtGrupoCliente.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrupoCliente.TabIndex = 46
        '
        'dlgCarteraClienteRelacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 126)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCarteraClienteRelacion"
        Me.Text = "Agregar Relación Cartera Cliente"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
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
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents btnCancelarRelacion As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnGuardarRelacion As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtCodGrupoCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtGrupoCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
End Class
