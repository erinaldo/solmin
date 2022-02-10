<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarAcopladoxTransportista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsignarAcopladoxTransportista))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnGuardar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtObsAcopladoTransportista = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cboAcoplados = New CodeTextBox.CodeTextBox
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel.Controls.Add(Me.btnGuardar)
        Me.KryptonPanel.Controls.Add(Me.txtObsAcopladoTransportista)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel10)
        Me.KryptonPanel.Controls.Add(Me.cboAcoplados)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel11)
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
        'txtObsAcopladoTransportista
        '
        Me.txtObsAcopladoTransportista.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtObsAcopladoTransportista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObsAcopladoTransportista.Location = New System.Drawing.Point(107, 48)
        Me.txtObsAcopladoTransportista.MaxLength = 250
        Me.txtObsAcopladoTransportista.Multiline = True
        Me.txtObsAcopladoTransportista.Name = "txtObsAcopladoTransportista"
        Me.txtObsAcopladoTransportista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObsAcopladoTransportista.Size = New System.Drawing.Size(394, 79)
        Me.txtObsAcopladoTransportista.TabIndex = 15
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(4, 44)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(86, 16)
        Me.KryptonLabel10.TabIndex = 14
        Me.KryptonLabel10.Text = "Observaciones"
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "Observaciones"
        '
        'cboAcoplados
        '
        Me.cboAcoplados.Codigo = ""
        Me.cboAcoplados.ControlHeight = 23
        Me.cboAcoplados.ControlImage = True
        Me.cboAcoplados.ControlReadOnly = True
        Me.cboAcoplados.Descripcion = ""
        Me.cboAcoplados.DisplayColumnVisible = True
        Me.cboAcoplados.DisplayMember = ""
        Me.cboAcoplados.KeyColumnWidth = 100
        Me.cboAcoplados.KeyField = ""
        Me.cboAcoplados.KeySearch = True
        Me.cboAcoplados.Location = New System.Drawing.Point(107, 12)
        Me.cboAcoplados.Name = "cboAcoplados"
        Me.cboAcoplados.Size = New System.Drawing.Size(236, 23)
        Me.cboAcoplados.TabIndex = 10
        Me.cboAcoplados.TextBackColor = System.Drawing.Color.Empty
        Me.cboAcoplados.TextForeColor = System.Drawing.Color.Empty
        Me.cboAcoplados.ValueColumnVisible = True
        Me.cboAcoplados.ValueColumnWidth = 600
        Me.cboAcoplados.ValueField = ""
        Me.cboAcoplados.ValueMember = ""
        Me.cboAcoplados.ValueSearch = True
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(7, 14)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(63, 16)
        Me.KryptonLabel11.TabIndex = 11
        Me.KryptonLabel11.Text = "Acoplados"
        Me.KryptonLabel11.Values.ExtraText = ""
        Me.KryptonLabel11.Values.Image = Nothing
        Me.KryptonLabel11.Values.Text = "Acoplados"
        '
        'frmAsignarAcopladoxTransportista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 169)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAsignarAcopladoxTransportista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Asignar acoplado transportista"
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
    Friend WithEvents cboAcoplados As CodeTextBox.CodeTextBox
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtObsAcopladoTransportista As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnGuardar As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
