<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarAcoplado_Conductor
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
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnProcesar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.cmbConductor = New Ransa.Controls.Transportista.ucConductor_TxtF01
        Me.ctbAcoplado = New Ransa.Controls.Transportista.ucAcopladoTransportista_TxtF01
        Me.KryptonLabel22 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFiltros.Panel.SuspendLayout()
        Me.PanelFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelFiltros
        '
        Me.PanelFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnProcesar, Me.btnCancelar})
        Me.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFiltros.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.PanelFiltros.HeaderVisiblePrimary = False
        Me.PanelFiltros.Location = New System.Drawing.Point(0, 0)
        Me.PanelFiltros.Name = "PanelFiltros"
        '
        'PanelFiltros.Panel
        '
        Me.PanelFiltros.Panel.Controls.Add(Me.cmbConductor)
        Me.PanelFiltros.Panel.Controls.Add(Me.ctbAcoplado)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel22)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel11)
        Me.PanelFiltros.Size = New System.Drawing.Size(460, 95)
        Me.PanelFiltros.TabIndex = 8
        Me.PanelFiltros.ValuesPrimary.Description = ""
        Me.PanelFiltros.ValuesPrimary.Heading = ""
        Me.PanelFiltros.ValuesPrimary.Image = Nothing
        Me.PanelFiltros.ValuesSecondary.Description = ""
        Me.PanelFiltros.ValuesSecondary.Heading = ""
        Me.PanelFiltros.ValuesSecondary.Image = Nothing
        '
        'btnProcesar
        '
        Me.btnProcesar.ExtraText = ""
        Me.btnProcesar.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnProcesar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.ToolTipImage = Nothing
        Me.btnProcesar.UniqueName = "1E7B5DC088DB4E1F1E7B5DC088DB4E1F"
        '
        'btnCancelar
        '
        Me.btnCancelar.ExtraText = ""
        Me.btnCancelar.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources._exit
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.ToolTipImage = Nothing
        Me.btnCancelar.UniqueName = "096C58D1AE4B4989096C58D1AE4B4989"
        '
        'cmbConductor
        '
        Me.cmbConductor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmbConductor.BackColor = System.Drawing.Color.Transparent
        Me.cmbConductor.Enabled = False
        Me.cmbConductor.Location = New System.Drawing.Point(107, 10)
        Me.cmbConductor.Name = "cmbConductor"
        Me.cmbConductor.pRequerido = False
        Me.cmbConductor.Size = New System.Drawing.Size(341, 19)
        Me.cmbConductor.TabIndex = 153
        '
        'ctbAcoplado
        '
        Me.ctbAcoplado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ctbAcoplado.BackColor = System.Drawing.Color.Transparent
        Me.ctbAcoplado.Location = New System.Drawing.Point(107, 39)
        Me.ctbAcoplado.Name = "ctbAcoplado"
        Me.ctbAcoplado.pRequerido = False
        Me.ctbAcoplado.Size = New System.Drawing.Size(341, 19)
        Me.ctbAcoplado.TabIndex = 13
        '
        'KryptonLabel22
        '
        Me.KryptonLabel22.Location = New System.Drawing.Point(4, 10)
        Me.KryptonLabel22.Name = "KryptonLabel22"
        Me.KryptonLabel22.Size = New System.Drawing.Size(104, 16)
        Me.KryptonLabel22.TabIndex = 9
        Me.KryptonLabel22.TabStop = False
        Me.KryptonLabel22.Text = "Brevete Conductor"
        Me.KryptonLabel22.Values.ExtraText = ""
        Me.KryptonLabel22.Values.Image = Nothing
        Me.KryptonLabel22.Values.Text = "Brevete Conductor"
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(4, 42)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(89, 16)
        Me.KryptonLabel11.TabIndex = 10
        Me.KryptonLabel11.TabStop = False
        Me.KryptonLabel11.Text = "Placa Acoplado"
        Me.KryptonLabel11.Values.ExtraText = ""
        Me.KryptonLabel11.Values.Image = Nothing
        Me.KryptonLabel11.Values.Text = "Placa Acoplado"
        '
        'frmBuscarAcoplado_Conductor
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(460, 95)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelFiltros)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBuscarAcoplado_Conductor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Busqueda de Acoplados - Conductor"
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.Panel.ResumeLayout(False)
        Me.PanelFiltros.Panel.PerformLayout()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
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
    Friend WithEvents btnProcesar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents KryptonLabel22 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ctbAcoplado As Ransa.Controls.Transportista.ucAcopladoTransportista_TxtF01
    Friend WithEvents cmbConductor As Ransa.Controls.Transportista.ucConductor_TxtF01
End Class
