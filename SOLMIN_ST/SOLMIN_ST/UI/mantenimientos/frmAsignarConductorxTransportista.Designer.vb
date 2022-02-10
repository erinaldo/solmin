<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarConductorxTransportista
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
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnGuardar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtObsConductorTransportista = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.cmbConductor = New Ransa.Controls.Transportista.ucConductor_TxtF01
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.cmbConductor)
        Me.KryptonPanel.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel.Controls.Add(Me.btnGuardar)
        Me.KryptonPanel.Controls.Add(Me.txtObsConductorTransportista)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel12)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel13)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(511, 169)
        Me.KryptonPanel.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(274, 134)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 25)
        Me.btnCancelar.TabIndex = 17
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "Cancelar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(146, 134)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(90, 25)
        Me.btnGuardar.TabIndex = 16
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.Values.ExtraText = ""
        Me.btnGuardar.Values.Image = Nothing
        Me.btnGuardar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnGuardar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnGuardar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnGuardar.Values.Text = "Guardar"
        '
        'txtObsConductorTransportista
        '
        Me.txtObsConductorTransportista.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObsConductorTransportista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObsConductorTransportista.Location = New System.Drawing.Point(107, 44)
        Me.txtObsConductorTransportista.MaxLength = 250
        Me.txtObsConductorTransportista.Multiline = True
        Me.txtObsConductorTransportista.Name = "txtObsConductorTransportista"
        Me.txtObsConductorTransportista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObsConductorTransportista.Size = New System.Drawing.Size(394, 79)
        Me.txtObsConductorTransportista.TabIndex = 15
        '
        'KryptonLabel12
        '
        Me.KryptonLabel12.Location = New System.Drawing.Point(9, 44)
        Me.KryptonLabel12.Name = "KryptonLabel12"
        Me.KryptonLabel12.Size = New System.Drawing.Size(86, 16)
        Me.KryptonLabel12.TabIndex = 14
        Me.KryptonLabel12.Text = "Observaciones"
        Me.KryptonLabel12.Values.ExtraText = ""
        Me.KryptonLabel12.Values.Image = Nothing
        Me.KryptonLabel12.Values.Text = "Observaciones"
        '
        'KryptonLabel13
        '
        Me.KryptonLabel13.Location = New System.Drawing.Point(9, 12)
        Me.KryptonLabel13.Name = "KryptonLabel13"
        Me.KryptonLabel13.Size = New System.Drawing.Size(74, 16)
        Me.KryptonLabel13.TabIndex = 11
        Me.KryptonLabel13.Text = "Conductores"
        Me.KryptonLabel13.Values.ExtraText = ""
        Me.KryptonLabel13.Values.Image = Nothing
        Me.KryptonLabel13.Values.Text = "Conductores"
        '
        'cmbConductor
        '
        Me.cmbConductor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmbConductor.BackColor = System.Drawing.Color.Transparent
        Me.cmbConductor.Enabled = False
        Me.cmbConductor.Location = New System.Drawing.Point(107, 12)
        Me.cmbConductor.Name = "cmbConductor"
        Me.cmbConductor.pRequerido = False
        Me.cmbConductor.Size = New System.Drawing.Size(394, 19)
        Me.cmbConductor.TabIndex = 154
        '
        'frmAsignarConductorxTransportista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 169)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAsignarConductorxTransportista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Asignar conductor transportista"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New(ByVal ht As Hashtable)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _RUC = ht.Item("RUC")
        _RAZONSOCIAL = ht.Item("RAZONSOCIAL")

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtObsConductorTransportista As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnGuardar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cmbConductor As Ransa.Controls.Transportista.ucConductor_TxtF01
End Class
