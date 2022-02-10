<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarVehiculoxTransportista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsignarVehiculoxTransportista))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnGuardar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtObsTractoTransportista = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.cboVehiculos = New CodeTextBox.CodeTextBox
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel.Controls.Add(Me.btnGuardar)
        Me.KryptonPanel.Controls.Add(Me.txtObsTractoTransportista)
        Me.KryptonPanel.Controls.Add(Me.cboVehiculos)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel6)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel7)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(511, 171)
        Me.KryptonPanel.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(274, 134)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 25)
        Me.btnCancelar.TabIndex = 15
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
        Me.btnGuardar.TabIndex = 15
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.Values.ExtraText = ""
        Me.btnGuardar.Values.Image = Nothing
        Me.btnGuardar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnGuardar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnGuardar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnGuardar.Values.Text = "Guardar"
        '
        'txtObsTractoTransportista
        '
        Me.txtObsTractoTransportista.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtObsTractoTransportista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObsTractoTransportista.Location = New System.Drawing.Point(107, 44)
        Me.txtObsTractoTransportista.MaxLength = 250
        Me.txtObsTractoTransportista.Multiline = True
        Me.txtObsTractoTransportista.Name = "txtObsTractoTransportista"
        Me.txtObsTractoTransportista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObsTractoTransportista.Size = New System.Drawing.Size(394, 79)
        Me.txtObsTractoTransportista.TabIndex = 14
        '
        'cboVehiculos
        '
        Me.cboVehiculos.Codigo = ""
        Me.cboVehiculos.ControlHeight = 23
        Me.cboVehiculos.ControlImage = True
        Me.cboVehiculos.ControlReadOnly = True
        Me.cboVehiculos.Descripcion = ""
        Me.cboVehiculos.DisplayColumnVisible = True
        Me.cboVehiculos.DisplayMember = ""
        Me.cboVehiculos.KeyColumnWidth = 100
        Me.cboVehiculos.KeyField = ""
        Me.cboVehiculos.KeySearch = True
        Me.cboVehiculos.Location = New System.Drawing.Point(107, 12)
        Me.cboVehiculos.Name = "cboVehiculos"
        Me.cboVehiculos.Size = New System.Drawing.Size(200, 23)
        Me.cboVehiculos.TabIndex = 7
        Me.cboVehiculos.TextBackColor = System.Drawing.Color.Empty
        Me.cboVehiculos.TextForeColor = System.Drawing.Color.Empty
        Me.cboVehiculos.ValueColumnVisible = True
        Me.cboVehiculos.ValueColumnWidth = 600
        Me.cboVehiculos.ValueField = ""
        Me.cboVehiculos.ValueMember = ""
        Me.cboVehiculos.ValueSearch = True
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(7, 14)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(102, 16)
        Me.KryptonLabel6.TabIndex = 8
        Me.KryptonLabel6.Text = "Vehiculos (Tracto)"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Vehiculos (Tracto)"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(7, 44)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(86, 16)
        Me.KryptonLabel7.TabIndex = 10
        Me.KryptonLabel7.Text = "Observaciones"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Observaciones"
        '
        'frmAsignarVehiculoxTransportista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 171)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAsignarVehiculoxTransportista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Asignar vehículo a transportista"
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
    Friend WithEvents cboVehiculos As CodeTextBox.CodeTextBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtObsTractoTransportista As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnGuardar As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
