<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarTipoMoneda
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
        Me.PanelTipoMoneda = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.rbDolares = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.rbSoles = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        CType(Me.PanelTipoMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTipoMoneda.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTipoMoneda
        '
        Me.PanelTipoMoneda.Controls.Add(Me.btnCancelar)
        Me.PanelTipoMoneda.Controls.Add(Me.btnAceptar)
        Me.PanelTipoMoneda.Controls.Add(Me.KryptonLabel1)
        Me.PanelTipoMoneda.Controls.Add(Me.rbDolares)
        Me.PanelTipoMoneda.Controls.Add(Me.rbSoles)
        Me.PanelTipoMoneda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTipoMoneda.Location = New System.Drawing.Point(0, 0)
        Me.PanelTipoMoneda.Name = "PanelTipoMoneda"
        Me.PanelTipoMoneda.Size = New System.Drawing.Size(292, 108)
        Me.PanelTipoMoneda.TabIndex = 0
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(42, 65)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(99, 31)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.Values.ExtraText = ""
        Me.btnAceptar.Values.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnAceptar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAceptar.Values.Text = "Aceptar"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(64, 8)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(167, 19)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Text = "SELECCIONE TIPO DE MONEDA"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "SELECCIONE TIPO DE MONEDA"
        '
        'rbDolares
        '
        Me.rbDolares.Location = New System.Drawing.Point(150, 37)
        Me.rbDolares.Name = "rbDolares"
        Me.rbDolares.Size = New System.Drawing.Size(69, 19)
        Me.rbDolares.TabIndex = 2
        Me.rbDolares.Text = "DOLARES"
        Me.rbDolares.Values.ExtraText = ""
        Me.rbDolares.Values.Image = Nothing
        Me.rbDolares.Values.Text = "DOLARES"
        '
        'rbSoles
        '
        Me.rbSoles.Location = New System.Drawing.Point(73, 37)
        Me.rbSoles.Name = "rbSoles"
        Me.rbSoles.Size = New System.Drawing.Size(53, 19)
        Me.rbSoles.TabIndex = 1
        Me.rbSoles.Text = "SOLES"
        Me.rbSoles.Values.ExtraText = ""
        Me.rbSoles.Values.Image = Nothing
        Me.rbSoles.Values.Text = "SOLES"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(150, 65)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(99, 31)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "Cancelar"
        '
        'frmConsultarTipoMoneda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 108)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelTipoMoneda)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsultarTipoMoneda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo de Moneda"
        CType(Me.PanelTipoMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTipoMoneda.ResumeLayout(False)
        Me.PanelTipoMoneda.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTipoMoneda As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents rbDolares As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbSoles As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
