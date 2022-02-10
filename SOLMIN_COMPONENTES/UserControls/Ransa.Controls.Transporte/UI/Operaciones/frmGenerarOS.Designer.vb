<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerarOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGenerarOS))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnSalir = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.ctbCentroCostoTercero = New CodeTextBox.CodeTextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ctbSectorGasto = New CodeTextBox.CodeTextBox
        Me.ctbCentroCostoPropio = New CodeTextBox.CodeTextBox
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
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
        Me.KryptonPanel.Size = New System.Drawing.Size(464, 162)
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
        Me.PanelFiltros.Panel.Controls.Add(Me.ctbCentroCostoTercero)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.PanelFiltros.Panel.Controls.Add(Me.ctbSectorGasto)
        Me.PanelFiltros.Panel.Controls.Add(Me.ctbCentroCostoPropio)
        Me.PanelFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel7)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel3)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel4)
        Me.PanelFiltros.Size = New System.Drawing.Size(464, 162)
        Me.PanelFiltros.TabIndex = 1
        Me.PanelFiltros.Text = "Generar OS"
        Me.PanelFiltros.ValuesPrimary.Description = "Generar OS"
        Me.PanelFiltros.ValuesPrimary.Heading = "Generar OS"
        Me.PanelFiltros.ValuesPrimary.Image = Nothing
        Me.PanelFiltros.ValuesSecondary.Description = ""
        Me.PanelFiltros.ValuesSecondary.Heading = "Generar OS"
        Me.PanelFiltros.ValuesSecondary.Image = Nothing
        '
        'btnAceptar
        '
        Me.btnAceptar.ExtraText = ""
        Me.btnAceptar.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnAceptar.Image = Global.Ransa.Controls.Transporte.My.Resources.Resources.edit_add
        Me.btnAceptar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.ToolTipImage = Nothing
        Me.btnAceptar.UniqueName = "1E7B5DC088DB4E1F1E7B5DC088DB4E1F"
        '
        'btnSalir
        '
        Me.btnSalir.ExtraText = ""
        Me.btnSalir.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnSalir.Image = Global.Ransa.Controls.Transporte.My.Resources.Resources._exit
        Me.btnSalir.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.ToolTipImage = Nothing
        Me.btnSalir.UniqueName = "4ABB2086ACE547644ABB2086ACE54764"
        '
        'ctbCentroCostoTercero
        '
        Me.ctbCentroCostoTercero.Codigo = ""
        Me.ctbCentroCostoTercero.ControlHeight = 23
        Me.ctbCentroCostoTercero.ControlImage = True
        Me.ctbCentroCostoTercero.ControlReadOnly = False
        Me.ctbCentroCostoTercero.Descripcion = ""
        Me.ctbCentroCostoTercero.DisplayColumnVisible = True
        Me.ctbCentroCostoTercero.DisplayMember = ""
        Me.ctbCentroCostoTercero.KeyColumnWidth = 100
        Me.ctbCentroCostoTercero.KeyField = ""
        Me.ctbCentroCostoTercero.KeySearch = True
        Me.ctbCentroCostoTercero.Location = New System.Drawing.Point(146, 67)
        Me.ctbCentroCostoTercero.Name = "ctbCentroCostoTercero"
        Me.ctbCentroCostoTercero.Size = New System.Drawing.Size(308, 23)
        Me.ctbCentroCostoTercero.TabIndex = 48
        Me.ctbCentroCostoTercero.TextBackColor = System.Drawing.Color.Empty
        Me.ctbCentroCostoTercero.TextForeColor = System.Drawing.Color.Empty
        Me.ctbCentroCostoTercero.ValueColumnVisible = True
        Me.ctbCentroCostoTercero.ValueColumnWidth = 600
        Me.ctbCentroCostoTercero.ValueField = ""
        Me.ctbCentroCostoTercero.ValueMember = ""
        Me.ctbCentroCostoTercero.ValueSearch = True
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(16, 69)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(127, 20)
        Me.KryptonLabel1.TabIndex = 47
        Me.KryptonLabel1.Text = "Centro Costo Tercero"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Centro Costo Tercero"
        '
        'ctbSectorGasto
        '
        Me.ctbSectorGasto.Codigo = ""
        Me.ctbSectorGasto.ControlHeight = 23
        Me.ctbSectorGasto.ControlImage = True
        Me.ctbSectorGasto.ControlReadOnly = False
        Me.ctbSectorGasto.Descripcion = ""
        Me.ctbSectorGasto.DisplayColumnVisible = True
        Me.ctbSectorGasto.DisplayMember = ""
        Me.ctbSectorGasto.KeyColumnWidth = 100
        Me.ctbSectorGasto.KeyField = ""
        Me.ctbSectorGasto.KeySearch = True
        Me.ctbSectorGasto.Location = New System.Drawing.Point(146, 96)
        Me.ctbSectorGasto.Name = "ctbSectorGasto"
        Me.ctbSectorGasto.Size = New System.Drawing.Size(308, 23)
        Me.ctbSectorGasto.TabIndex = 46
        Me.ctbSectorGasto.TextBackColor = System.Drawing.Color.Empty
        Me.ctbSectorGasto.TextForeColor = System.Drawing.Color.Empty
        Me.ctbSectorGasto.ValueColumnVisible = True
        Me.ctbSectorGasto.ValueColumnWidth = 600
        Me.ctbSectorGasto.ValueField = ""
        Me.ctbSectorGasto.ValueMember = ""
        Me.ctbSectorGasto.ValueSearch = True
        '
        'ctbCentroCostoPropio
        '
        Me.ctbCentroCostoPropio.Codigo = ""
        Me.ctbCentroCostoPropio.ControlHeight = 23
        Me.ctbCentroCostoPropio.ControlImage = True
        Me.ctbCentroCostoPropio.ControlReadOnly = False
        Me.ctbCentroCostoPropio.Descripcion = ""
        Me.ctbCentroCostoPropio.DisplayColumnVisible = True
        Me.ctbCentroCostoPropio.DisplayMember = ""
        Me.ctbCentroCostoPropio.KeyColumnWidth = 100
        Me.ctbCentroCostoPropio.KeyField = ""
        Me.ctbCentroCostoPropio.KeySearch = True
        Me.ctbCentroCostoPropio.Location = New System.Drawing.Point(146, 38)
        Me.ctbCentroCostoPropio.Name = "ctbCentroCostoPropio"
        Me.ctbCentroCostoPropio.Size = New System.Drawing.Size(308, 23)
        Me.ctbCentroCostoPropio.TabIndex = 45
        Me.ctbCentroCostoPropio.TextBackColor = System.Drawing.Color.Empty
        Me.ctbCentroCostoPropio.TextForeColor = System.Drawing.Color.Empty
        Me.ctbCentroCostoPropio.ValueColumnVisible = True
        Me.ctbCentroCostoPropio.ValueColumnWidth = 600
        Me.ctbCentroCostoPropio.ValueField = ""
        Me.ctbCentroCostoPropio.ValueMember = ""
        Me.ctbCentroCostoPropio.ValueSearch = True
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.CCMPN = "EZ"
        Me.txtCliente.Location = New System.Drawing.Point(146, 11)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = False
        Me.txtCliente.pRequerido = False
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(308, 22)
        Me.txtCliente.TabIndex = 44
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(16, 40)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(122, 20)
        Me.KryptonLabel7.TabIndex = 39
        Me.KryptonLabel7.Text = "Centro Costo Propio"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Centro Costo Propio"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(16, 98)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(90, 20)
        Me.KryptonLabel3.TabIndex = 7
        Me.KryptonLabel3.Text = "Sector X Gasto"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Sector X Gasto"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(16, 12)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(118, 20)
        Me.KryptonLabel4.TabIndex = 1
        Me.KryptonLabel4.Text = "Cliente  Facturación"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Cliente  Facturación"
        '
        'frmGenerarOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 162)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(480, 200)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(480, 200)
        Me.Name = "frmGenerarOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Generacion de Orden Servicio Operación "
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



  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub
  Friend WithEvents PanelFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
  Friend WithEvents ctbSectorGasto As CodeTextBox.CodeTextBox
  Friend WithEvents ctbCentroCostoPropio As CodeTextBox.CodeTextBox
  Friend WithEvents ctbCentroCostoTercero As CodeTextBox.CodeTextBox
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
