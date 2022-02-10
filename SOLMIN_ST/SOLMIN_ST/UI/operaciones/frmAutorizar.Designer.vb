<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAutorizarPedidoEfectivo
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
    Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.btnGuardar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.btnSalir = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.txtMotivoGiro = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.txtImporteSolEfectivo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.txtNroSolEfectivo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel22 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel24 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel19 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtNroOperacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
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
    Me.KryptonPanel.Size = New System.Drawing.Size(332, 181)
    Me.KryptonPanel.TabIndex = 0
    '
    'PanelFiltros
    '
    Me.PanelFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnGuardar, Me.btnSalir})
    Me.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PanelFiltros.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
    Me.PanelFiltros.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.PanelFiltros.HeaderVisiblePrimary = False
    Me.PanelFiltros.Location = New System.Drawing.Point(0, 0)
    Me.PanelFiltros.Name = "PanelFiltros"
    '
    'PanelFiltros.Panel
    '
    Me.PanelFiltros.Panel.Controls.Add(Me.txtMotivoGiro)
    Me.PanelFiltros.Panel.Controls.Add(Me.txtImporteSolEfectivo)
    Me.PanelFiltros.Panel.Controls.Add(Me.txtNroSolEfectivo)
    Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel22)
    Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel24)
    Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel19)
    Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel5)
    Me.PanelFiltros.Panel.Controls.Add(Me.txtNroOperacion)
    Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel7)
    Me.PanelFiltros.Size = New System.Drawing.Size(332, 181)
    Me.PanelFiltros.TabIndex = 1
    Me.PanelFiltros.Text = "Datos Generales"
    Me.PanelFiltros.ValuesPrimary.Description = "Datos Generales"
    Me.PanelFiltros.ValuesPrimary.Heading = "Datos Generales"
    Me.PanelFiltros.ValuesPrimary.Image = Nothing
    Me.PanelFiltros.ValuesSecondary.Description = ""
    Me.PanelFiltros.ValuesSecondary.Heading = "Pedido Efectivo"
    Me.PanelFiltros.ValuesSecondary.Image = Nothing
    '
    'btnGuardar
    '
    Me.btnGuardar.ExtraText = ""
    Me.btnGuardar.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
    Me.btnGuardar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
    Me.btnGuardar.Text = "Guardar Ped. Efectivo"
    Me.btnGuardar.ToolTipImage = Nothing
    Me.btnGuardar.UniqueName = "1E7B5DC088DB4E1F1E7B5DC088DB4E1F"
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
    'txtMotivoGiro
    '
    Me.txtMotivoGiro.Enabled = False
    Me.txtMotivoGiro.Location = New System.Drawing.Point(150, 108)
    Me.txtMotivoGiro.MaxLength = 30
    Me.txtMotivoGiro.Multiline = True
    Me.txtMotivoGiro.Name = "txtMotivoGiro"
    Me.txtMotivoGiro.ReadOnly = True
    Me.txtMotivoGiro.Size = New System.Drawing.Size(157, 35)
    Me.txtMotivoGiro.StateDisabled.Back.Color1 = System.Drawing.Color.White
    Me.txtMotivoGiro.StateDisabled.Content.Color1 = System.Drawing.Color.Black
    Me.txtMotivoGiro.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMotivoGiro.TabIndex = 3
    '
    'txtImporteSolEfectivo
    '
    Me.txtImporteSolEfectivo.Enabled = False
    Me.txtImporteSolEfectivo.Location = New System.Drawing.Point(150, 56)
    Me.txtImporteSolEfectivo.Name = "txtImporteSolEfectivo"
    Me.txtImporteSolEfectivo.Size = New System.Drawing.Size(157, 21)
    Me.txtImporteSolEfectivo.StateDisabled.Back.Color1 = System.Drawing.Color.White
    Me.txtImporteSolEfectivo.StateDisabled.Content.Color1 = System.Drawing.Color.Black
    Me.txtImporteSolEfectivo.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtImporteSolEfectivo.TabIndex = 1
    Me.txtImporteSolEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'txtNroSolEfectivo
    '
    Me.txtNroSolEfectivo.Enabled = False
    Me.txtNroSolEfectivo.Location = New System.Drawing.Point(150, 30)
    Me.txtNroSolEfectivo.Name = "txtNroSolEfectivo"
    Me.txtNroSolEfectivo.ReadOnly = True
    Me.txtNroSolEfectivo.Size = New System.Drawing.Size(157, 21)
    Me.txtNroSolEfectivo.StateDisabled.Back.Color1 = System.Drawing.Color.White
    Me.txtNroSolEfectivo.StateDisabled.Content.Color1 = System.Drawing.Color.Black
    Me.txtNroSolEfectivo.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNroSolEfectivo.TabIndex = 0
    '
    'KryptonLabel22
    '
    Me.KryptonLabel22.Location = New System.Drawing.Point(10, 59)
    Me.KryptonLabel22.Name = "KryptonLabel22"
    Me.KryptonLabel22.Size = New System.Drawing.Size(140, 19)
    Me.KryptonLabel22.TabIndex = 1
    Me.KryptonLabel22.Text = "Importe Sol. Ped. Efectivo:"
    Me.KryptonLabel22.Values.ExtraText = ""
    Me.KryptonLabel22.Values.Image = Nothing
    Me.KryptonLabel22.Values.Text = "Importe Sol. Ped. Efectivo:"
    '
    'KryptonLabel24
    '
    Me.KryptonLabel24.Location = New System.Drawing.Point(10, 111)
    Me.KryptonLabel24.Name = "KryptonLabel24"
    Me.KryptonLabel24.Size = New System.Drawing.Size(142, 19)
    Me.KryptonLabel24.TabIndex = 20
    Me.KryptonLabel24.Text = "Motivo de Giro. Adelanto :"
    Me.KryptonLabel24.Values.ExtraText = ""
    Me.KryptonLabel24.Values.Image = Nothing
    Me.KryptonLabel24.Values.Text = "Motivo de Giro. Adelanto :"
    '
    'KryptonLabel19
    '
    Me.KryptonLabel19.Location = New System.Drawing.Point(10, 33)
    Me.KryptonLabel19.Name = "KryptonLabel19"
    Me.KryptonLabel19.Size = New System.Drawing.Size(142, 19)
    Me.KryptonLabel19.TabIndex = 3
    Me.KryptonLabel19.Text = "Número Sol ped. Efectivo :"
    Me.KryptonLabel19.Values.ExtraText = ""
    Me.KryptonLabel19.Values.Image = Nothing
    Me.KryptonLabel19.Values.Text = "Número Sol ped. Efectivo :"
    '
    'KryptonLabel5
    '
    Me.KryptonLabel5.Location = New System.Drawing.Point(6, 6)
    Me.KryptonLabel5.Name = "KryptonLabel5"
    Me.KryptonLabel5.Size = New System.Drawing.Size(129, 18)
    Me.KryptonLabel5.StateNormal.ShortText.Color1 = System.Drawing.Color.Navy
    Me.KryptonLabel5.StateNormal.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.KryptonLabel5.TabIndex = 0
    Me.KryptonLabel5.Text = "Información General "
    Me.KryptonLabel5.Values.ExtraText = ""
    Me.KryptonLabel5.Values.Image = Nothing
    Me.KryptonLabel5.Values.Text = "Información General "
    '
    'txtNroOperacion
    '
    Me.txtNroOperacion.Enabled = False
    Me.txtNroOperacion.Location = New System.Drawing.Point(150, 82)
    Me.txtNroOperacion.Name = "txtNroOperacion"
    Me.txtNroOperacion.ReadOnly = True
    Me.txtNroOperacion.Size = New System.Drawing.Size(157, 21)
    Me.txtNroOperacion.StateDisabled.Back.Color1 = System.Drawing.Color.White
    Me.txtNroOperacion.StateDisabled.Content.Color1 = System.Drawing.Color.Black
    Me.txtNroOperacion.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNroOperacion.TabIndex = 2
    '
    'KryptonLabel7
    '
    Me.KryptonLabel7.Location = New System.Drawing.Point(10, 85)
    Me.KryptonLabel7.Name = "KryptonLabel7"
    Me.KryptonLabel7.Size = New System.Drawing.Size(143, 19)
    Me.KryptonLabel7.TabIndex = 14
    Me.KryptonLabel7.Text = "Número de Operación      :"
    Me.KryptonLabel7.Values.ExtraText = ""
    Me.KryptonLabel7.Values.Image = Nothing
    Me.KryptonLabel7.Values.Text = "Número de Operación      :"
    '
    'frmAutorizarPedidoEfectivo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(332, 181)
    Me.ControlBox = False
    Me.Controls.Add(Me.KryptonPanel)
    Me.MaximizeBox = False
    Me.MaximumSize = New System.Drawing.Size(340, 215)
    Me.MinimizeBox = False
    Me.MinimumSize = New System.Drawing.Size(340, 215)
    Me.Name = "frmAutorizarPedidoEfectivo"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Autorizar Pedido Efectivo"
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
    Friend WithEvents btnGuardar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents txtMotivoGiro As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtImporteSolEfectivo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtNroSolEfectivo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel22 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel24 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel19 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroOperacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
