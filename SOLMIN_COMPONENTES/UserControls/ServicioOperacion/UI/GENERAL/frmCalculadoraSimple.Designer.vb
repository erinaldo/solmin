<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculadoraSimple
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
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCampo1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtMontoCalcular = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtTipoCambio = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtResultado = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.cmbOpcionCambio = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.ButtonSpecHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.ButtonSpecHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
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
        Me.KryptonPanel.Size = New System.Drawing.Size(307, 156)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnAceptar, Me.btnCancelar})
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCampo1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtMontoCalcular)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtTipoCambio)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtResultado)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbOpcionCambio)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(307, 156)
        Me.KryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'btnAceptar
        '
        Me.btnAceptar.ExtraText = ""
        Me.btnAceptar.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.button_ok
        Me.btnAceptar.Text = "Calcular"
        Me.btnAceptar.ToolTipImage = Nothing
        Me.btnAceptar.ToolTipTitle = "Calcular"
        Me.btnAceptar.UniqueName = "F0F005CB39814782F0F005CB39814782"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(11, 38)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(110, 19)
        Me.KryptonLabel3.TabIndex = 2
        Me.KryptonLabel3.Text = "Tipo Cambio Dolar :"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Tipo Cambio Dolar :"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(11, 64)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(92, 19)
        Me.KryptonLabel2.TabIndex = 4
        Me.KryptonLabel2.Text = "Monto Calcular :"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Monto Calcular :"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(11, 90)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(65, 19)
        Me.KryptonLabel1.TabIndex = 6
        Me.KryptonLabel1.Text = "Resultado :"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Resultado :"
        '
        'lblCampo1
        '
        Me.lblCampo1.Location = New System.Drawing.Point(11, 12)
        Me.lblCampo1.Name = "lblCampo1"
        Me.lblCampo1.Size = New System.Drawing.Size(72, 19)
        Me.lblCampo1.TabIndex = 0
        Me.lblCampo1.Text = "Conversión :"
        Me.lblCampo1.Values.ExtraText = ""
        Me.lblCampo1.Values.Image = Nothing
        Me.lblCampo1.Values.Text = "Conversión :"
        '
        'txtMontoCalcular
        '
        Me.txtMontoCalcular.Location = New System.Drawing.Point(130, 66)
        Me.txtMontoCalcular.MaxLength = 12
        Me.txtMontoCalcular.Name = "txtMontoCalcular"
        Me.txtMontoCalcular.Size = New System.Drawing.Size(100, 21)
        Me.txtMontoCalcular.TabIndex = 5
        Me.txtMontoCalcular.Text = "0"
        Me.txtMontoCalcular.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.Location = New System.Drawing.Point(130, 39)
        Me.txtTipoCambio.MaxLength = 10
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.Size = New System.Drawing.Size(100, 21)
        Me.txtTipoCambio.TabIndex = 3
        Me.txtTipoCambio.Text = "1"
        Me.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtResultado
        '
        Me.txtResultado.Enabled = False
        Me.txtResultado.Location = New System.Drawing.Point(130, 93)
        Me.txtResultado.MaxLength = 14
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(100, 21)
        Me.txtResultado.TabIndex = 7
        Me.txtResultado.Text = "0"
        Me.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbOpcionCambio
        '
        Me.cmbOpcionCambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOpcionCambio.DropDownWidth = 165
        Me.cmbOpcionCambio.FormattingEnabled = False
        Me.cmbOpcionCambio.ItemHeight = 13
        Me.cmbOpcionCambio.Items.AddRange(New Object() {"1 - Soles a Dolares", "2 - Dolares a Soles"})
        Me.cmbOpcionCambio.Location = New System.Drawing.Point(130, 12)
        Me.cmbOpcionCambio.Name = "cmbOpcionCambio"
        Me.cmbOpcionCambio.Size = New System.Drawing.Size(165, 21)
        Me.cmbOpcionCambio.TabIndex = 1
        '
        'ButtonSpecHeaderGroup1
        '
        Me.ButtonSpecHeaderGroup1.ExtraText = ""
        Me.ButtonSpecHeaderGroup1.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.button_ok
        Me.ButtonSpecHeaderGroup1.Text = "Calcular"
        Me.ButtonSpecHeaderGroup1.ToolTipImage = Nothing
        Me.ButtonSpecHeaderGroup1.ToolTipTitle = "Calcular"
        Me.ButtonSpecHeaderGroup1.UniqueName = "F0F005CB39814782F0F005CB39814782"
        '
        'ButtonSpecHeaderGroup2
        '
        Me.ButtonSpecHeaderGroup2.ExtraText = ""
        Me.ButtonSpecHeaderGroup2.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.button_ok
        Me.ButtonSpecHeaderGroup2.Text = "Calcular"
        Me.ButtonSpecHeaderGroup2.ToolTipImage = Nothing
        Me.ButtonSpecHeaderGroup2.ToolTipTitle = "Calcular"
        Me.ButtonSpecHeaderGroup2.UniqueName = "F0F005CB39814782F0F005CB39814782"
        '
        'btnCancelar
        '
        Me.btnCancelar.ExtraText = ""
        Me.btnCancelar.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.salir
        Me.btnCancelar.Text = "Calcenlar"
        Me.btnCancelar.ToolTipImage = Nothing
        Me.btnCancelar.UniqueName = "9F9B7ADCFD684CBE9F9B7ADCFD684CBE"
        '
        'frmCalculadoraSimple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 156)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCalculadoraSimple"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simple Calculadora"
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
    Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents txtResultado As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents cmbOpcionCambio As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents lblCampo1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtMontoCalcular As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtTipoCambio As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ButtonSpecHeaderGroup1 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents ButtonSpecHeaderGroup2 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
End Class
