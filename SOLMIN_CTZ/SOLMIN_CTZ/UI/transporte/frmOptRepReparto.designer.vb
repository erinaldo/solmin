<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptRepReparto
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
        Me.cboTipoDocumento = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.panel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnImprimirSustento = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnProcesarConsulta = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.txtNroFactura = New Ransa.Utilitario.Texto
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblOrdenServicio = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.SuspendLayout()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFiltros.Panel.SuspendLayout()
        Me.PanelFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDocumento.DropDownWidth = 150
        Me.cboTipoDocumento.FormattingEnabled = False
        Me.cboTipoDocumento.ItemHeight = 15
        Me.cboTipoDocumento.Location = New System.Drawing.Point(130, 39)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(150, 23)
        Me.cboTipoDocumento.TabIndex = 20
        '
        'panel
        '
        Me.panel.Controls.Add(Me.PanelFiltros)
        Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(294, 66)
        Me.panel.TabIndex = 1
        '
        'PanelFiltros
        '
        Me.PanelFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnImprimirSustento, Me.btnProcesarConsulta, Me.btnCancelar})
        Me.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFiltros.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.PanelFiltros.HeaderVisiblePrimary = False
        Me.PanelFiltros.Location = New System.Drawing.Point(0, 0)
        Me.PanelFiltros.Name = "PanelFiltros"
        '
        'PanelFiltros.Panel
        '
        Me.PanelFiltros.Panel.Controls.Add(Me.txtNroFactura)
        Me.PanelFiltros.Panel.Controls.Add(Me.cboTipoDocumento)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.PanelFiltros.Panel.Controls.Add(Me.lblOrdenServicio)
        Me.PanelFiltros.Size = New System.Drawing.Size(294, 66)
        Me.PanelFiltros.TabIndex = 24
        Me.PanelFiltros.ValuesPrimary.Description = ""
        Me.PanelFiltros.ValuesPrimary.Heading = ""
        Me.PanelFiltros.ValuesPrimary.Image = Nothing
        Me.PanelFiltros.ValuesSecondary.Description = ""
        Me.PanelFiltros.ValuesSecondary.Heading = ""
        Me.PanelFiltros.ValuesSecondary.Image = Nothing
        '
        'btnImprimirSustento
        '
        Me.btnImprimirSustento.ExtraText = ""
        Me.btnImprimirSustento.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnImprimirSustento.Image = Global.SOLMIN_CT.My.Resources.Resources.printer2
        Me.btnImprimirSustento.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnImprimirSustento.Text = "Imprimir Sustento"
        Me.btnImprimirSustento.ToolTipImage = Nothing
        Me.btnImprimirSustento.UniqueName = "713DBEEF2892406A713DBEEF2892406A"
        '
        'btnProcesarConsulta
        '
        Me.btnProcesarConsulta.ExtraText = ""
        Me.btnProcesarConsulta.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnProcesarConsulta.Image = Global.SOLMIN_CT.My.Resources.Resources.excel1
        Me.btnProcesarConsulta.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnProcesarConsulta.Text = "Exportar"
        Me.btnProcesarConsulta.ToolTipImage = Nothing
        Me.btnProcesarConsulta.UniqueName = "1E7B5DC088DB4E1F1E7B5DC088DB4E1F"
        '
        'btnCancelar
        '
        Me.btnCancelar.ExtraText = ""
        Me.btnCancelar.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnCancelar.Image = Global.SOLMIN_CT.My.Resources.Resources._exit
        Me.btnCancelar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnCancelar.Text = "Salir"
        Me.btnCancelar.ToolTipImage = Nothing
        Me.btnCancelar.UniqueName = "978C187575614E31978C187575614E31"
        '
        'txtNroFactura
        '
        Me.txtNroFactura.Location = New System.Drawing.Point(130, 8)
        Me.txtNroFactura.MaxLength = 10
        Me.txtNroFactura.Name = "txtNroFactura"
        Me.txtNroFactura.SigControl = Nothing
        Me.txtNroFactura.Size = New System.Drawing.Size(138, 20)
        Me.txtNroFactura.TabIndex = 21
        Me.txtNroFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(11, 40)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(102, 20)
        Me.KryptonLabel1.TabIndex = 19
        Me.KryptonLabel1.Text = "Tipo Documento"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Tipo Documento"
        '
        'lblOrdenServicio
        '
        Me.lblOrdenServicio.Location = New System.Drawing.Point(10, 10)
        Me.lblOrdenServicio.Name = "lblOrdenServicio"
        Me.lblOrdenServicio.Size = New System.Drawing.Size(116, 20)
        Me.lblOrdenServicio.TabIndex = 17
        Me.lblOrdenServicio.Text = "Número de Factura"
        Me.lblOrdenServicio.Values.ExtraText = ""
        Me.lblOrdenServicio.Values.Image = Nothing
        Me.lblOrdenServicio.Values.Text = "Número de Factura"
        '
        'frmOptRepReparto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 66)
        Me.ControlBox = False
        Me.Controls.Add(Me.panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(300, 90)
        Me.MinimumSize = New System.Drawing.Size(300, 90)
        Me.Name = "frmOptRepReparto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exportar"
        CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.ResumeLayout(False)
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.Panel.ResumeLayout(False)
        Me.PanelFiltros.Panel.PerformLayout()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents cboTipoDocumento As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents panel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents PanelFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnImprimirSustento As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnProcesarConsulta As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents txtNroFactura As Ransa.Utilitario.Texto
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblOrdenServicio As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
End Class
