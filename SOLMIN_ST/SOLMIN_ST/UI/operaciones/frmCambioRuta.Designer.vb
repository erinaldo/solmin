<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambioRuta
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCambioRuta))
    Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.btnSalir = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.ctlLocalidadDestino = New CodeTextBox.CodeTextBox
    Me.ctlLocalidadOrigen = New CodeTextBox.CodeTextBox
    Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelFiltros.Panel.SuspendLayout()
    Me.PanelFiltros.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.PanelFiltros)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(382, 111)
    Me.KryptonPanel.TabIndex = 0
    '
    'PanelFiltros
    '
    Me.PanelFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnAceptar, Me.btnSalir})
    Me.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PanelFiltros.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
    Me.PanelFiltros.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.PanelFiltros.HeaderVisiblePrimary = False
    Me.PanelFiltros.Location = New System.Drawing.Point(0, 0)
    Me.PanelFiltros.Name = "PanelFiltros"
    '
    'PanelFiltros.Panel
    '
    Me.PanelFiltros.Panel.Controls.Add(Me.ctlLocalidadDestino)
    Me.PanelFiltros.Panel.Controls.Add(Me.ctlLocalidadOrigen)
    Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel7)
    Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel1)
    Me.PanelFiltros.Size = New System.Drawing.Size(382, 111)
    Me.PanelFiltros.TabIndex = 2
    Me.PanelFiltros.Text = "Cambio de ruta"
    Me.PanelFiltros.ValuesPrimary.Description = "Cambio de ruta"
    Me.PanelFiltros.ValuesPrimary.Heading = "Cambio de ruta"
    Me.PanelFiltros.ValuesPrimary.Image = Nothing
    Me.PanelFiltros.ValuesSecondary.Description = ""
    Me.PanelFiltros.ValuesSecondary.Heading = "Cambio de ruta"
    Me.PanelFiltros.ValuesSecondary.Image = Nothing
    '
    'btnAceptar
    '
    Me.btnAceptar.ExtraText = ""
    Me.btnAceptar.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
    Me.btnAceptar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
    Me.btnAceptar.Text = "Aceptar"
    Me.btnAceptar.ToolTipImage = Nothing
    Me.btnAceptar.UniqueName = "1E7B5DC088DB4E1F1E7B5DC088DB4E1F"
    '
    'btnSalir
    '
    Me.btnSalir.ExtraText = ""
    Me.btnSalir.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
    Me.btnSalir.Image = Global.SOLMIN_ST.My.Resources.Resources._exit
    Me.btnSalir.Text = "Salir"
    Me.btnSalir.ToolTipImage = Nothing
    Me.btnSalir.UniqueName = "4ABB2086ACE547644ABB2086ACE54764"
    '
    'ctlLocalidadDestino
    '
    Me.ctlLocalidadDestino.Codigo = ""
    Me.ctlLocalidadDestino.ControlHeight = 23
    Me.ctlLocalidadDestino.ControlImage = True
    Me.ctlLocalidadDestino.ControlReadOnly = False
    Me.ctlLocalidadDestino.Descripcion = ""
    Me.ctlLocalidadDestino.DisplayColumnVisible = True
    Me.ctlLocalidadDestino.DisplayMember = ""
    Me.ctlLocalidadDestino.KeyColumnWidth = 100
    Me.ctlLocalidadDestino.KeyField = ""
    Me.ctlLocalidadDestino.KeySearch = True
    Me.ctlLocalidadDestino.Location = New System.Drawing.Point(132, 41)
    Me.ctlLocalidadDestino.Name = "ctlLocalidadDestino"
    Me.ctlLocalidadDestino.Size = New System.Drawing.Size(228, 23)
    Me.ctlLocalidadDestino.TabIndex = 65
    Me.ctlLocalidadDestino.TabStop = True
    Me.ctlLocalidadDestino.TextBackColor = System.Drawing.Color.Empty
    Me.ctlLocalidadDestino.TextForeColor = System.Drawing.Color.Empty
    Me.ctlLocalidadDestino.ValueColumnVisible = True
    Me.ctlLocalidadDestino.ValueColumnWidth = 600
    Me.ctlLocalidadDestino.ValueField = ""
    Me.ctlLocalidadDestino.ValueMember = ""
    Me.ctlLocalidadDestino.ValueSearch = True
    '
    'ctlLocalidadOrigen
    '
    Me.ctlLocalidadOrigen.Codigo = ""
    Me.ctlLocalidadOrigen.ControlHeight = 23
    Me.ctlLocalidadOrigen.ControlImage = True
    Me.ctlLocalidadOrigen.ControlReadOnly = False
    Me.ctlLocalidadOrigen.Descripcion = ""
    Me.ctlLocalidadOrigen.DisplayColumnVisible = True
    Me.ctlLocalidadOrigen.DisplayMember = ""
    Me.ctlLocalidadOrigen.KeyColumnWidth = 100
    Me.ctlLocalidadOrigen.KeyField = ""
    Me.ctlLocalidadOrigen.KeySearch = True
    Me.ctlLocalidadOrigen.Location = New System.Drawing.Point(132, 8)
    Me.ctlLocalidadOrigen.Name = "ctlLocalidadOrigen"
    Me.ctlLocalidadOrigen.Size = New System.Drawing.Size(228, 23)
    Me.ctlLocalidadOrigen.TabIndex = 64
    Me.ctlLocalidadOrigen.TabStop = True
    Me.ctlLocalidadOrigen.TextBackColor = System.Drawing.Color.Empty
    Me.ctlLocalidadOrigen.TextForeColor = System.Drawing.Color.Empty
    Me.ctlLocalidadOrigen.ValueColumnVisible = True
    Me.ctlLocalidadOrigen.ValueColumnWidth = 600
    Me.ctlLocalidadOrigen.ValueField = ""
    Me.ctlLocalidadOrigen.ValueMember = ""
    Me.ctlLocalidadOrigen.ValueSearch = True
    '
    'KryptonLabel7
    '
    Me.KryptonLabel7.Location = New System.Drawing.Point(14, 45)
    Me.KryptonLabel7.Name = "KryptonLabel7"
    Me.KryptonLabel7.Size = New System.Drawing.Size(119, 19)
    Me.KryptonLabel7.TabIndex = 67
    Me.KryptonLabel7.Text = "Localidad de destino :"
    Me.KryptonLabel7.Values.ExtraText = ""
    Me.KryptonLabel7.Values.Image = Nothing
    Me.KryptonLabel7.Values.Text = "Localidad de destino :"
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(14, 15)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(111, 19)
    Me.KryptonLabel1.TabIndex = 66
    Me.KryptonLabel1.Text = "Localidad de origen:"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Localidad de origen:"
    '
    'frmCambioRuta
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(382, 111)
    Me.ControlBox = False
    Me.Controls.Add(Me.KryptonPanel)
    Me.MaximizeBox = False
    Me.MaximumSize = New System.Drawing.Size(390, 145)
    Me.MinimizeBox = False
    Me.MinimumSize = New System.Drawing.Size(390, 145)
    Me.Name = "frmCambioRuta"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Cambio de Ruta"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelFiltros.Panel.ResumeLayout(False)
    Me.PanelFiltros.Panel.PerformLayout()
    CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelFiltros.ResumeLayout(False)
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
    Friend WithEvents PanelFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents ctlLocalidadDestino As CodeTextBox.CodeTextBox
    Friend WithEvents ctlLocalidadOrigen As CodeTextBox.CodeTextBox
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
