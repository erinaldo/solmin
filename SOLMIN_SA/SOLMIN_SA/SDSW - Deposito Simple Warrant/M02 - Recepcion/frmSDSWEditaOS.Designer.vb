<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSDSWEditaOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSDSWEditaOS))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.btnCancelarCrearOS = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnProcesarCrearOS = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtPeso = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblPeso = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCantidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblCantidad = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtUnidadPeso = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaListarUnidadPeso = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.lblUnidadPeso = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtUnidadCantidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaListarUnidadCantidad = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.lblUnidadCantidad = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.btnCancelarCrearOS)
        Me.KryptonPanel.Controls.Add(Me.btnProcesarCrearOS)
        Me.KryptonPanel.Controls.Add(Me.txtPeso)
        Me.KryptonPanel.Controls.Add(Me.lblPeso)
        Me.KryptonPanel.Controls.Add(Me.txtCantidad)
        Me.KryptonPanel.Controls.Add(Me.lblCantidad)
        Me.KryptonPanel.Controls.Add(Me.txtUnidadPeso)
        Me.KryptonPanel.Controls.Add(Me.lblUnidadPeso)
        Me.KryptonPanel.Controls.Add(Me.txtUnidadCantidad)
        Me.KryptonPanel.Controls.Add(Me.lblUnidadCantidad)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(349, 105)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 0
        '
        'btnCancelarCrearOS
        '
        Me.btnCancelarCrearOS.Location = New System.Drawing.Point(242, 74)
        Me.btnCancelarCrearOS.Name = "btnCancelarCrearOS"
        Me.btnCancelarCrearOS.Size = New System.Drawing.Size(100, 25)
        Me.btnCancelarCrearOS.TabIndex = 72
        Me.btnCancelarCrearOS.Text = "Cancelar"
        Me.btnCancelarCrearOS.Values.ExtraText = ""
        Me.btnCancelarCrearOS.Values.Image = CType(resources.GetObject("btnCancelarCrearOS.Values.Image"), System.Drawing.Image)
        Me.btnCancelarCrearOS.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelarCrearOS.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelarCrearOS.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelarCrearOS.Values.Text = "Cancelar"
        '
        'btnProcesarCrearOS
        '
        Me.btnProcesarCrearOS.Location = New System.Drawing.Point(136, 74)
        Me.btnProcesarCrearOS.Name = "btnProcesarCrearOS"
        Me.btnProcesarCrearOS.Size = New System.Drawing.Size(100, 25)
        Me.btnProcesarCrearOS.TabIndex = 71
        Me.btnProcesarCrearOS.Text = "Procesar"
        Me.btnProcesarCrearOS.Values.ExtraText = ""
        Me.btnProcesarCrearOS.Values.Image = CType(resources.GetObject("btnProcesarCrearOS.Values.Image"), System.Drawing.Image)
        Me.btnProcesarCrearOS.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnProcesarCrearOS.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnProcesarCrearOS.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnProcesarCrearOS.Values.Text = "Procesar"
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(79, 37)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(88, 21)
        Me.txtPeso.TabIndex = 67
        Me.txtPeso.Text = "0.00"
        Me.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPeso
        '
        Me.lblPeso.Location = New System.Drawing.Point(11, 40)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(39, 19)
        Me.lblPeso.TabIndex = 66
        Me.lblPeso.Text = "Peso : "
        Me.lblPeso.Values.ExtraText = ""
        Me.lblPeso.Values.Image = Nothing
        Me.lblPeso.Values.Text = "Peso : "
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(79, 12)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(88, 21)
        Me.txtCantidad.TabIndex = 63
        Me.txtCantidad.Text = "0.00"
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCantidad
        '
        Me.lblCantidad.Location = New System.Drawing.Point(11, 15)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(61, 19)
        Me.lblCantidad.TabIndex = 62
        Me.lblCantidad.Text = "Cantidad : "
        Me.lblCantidad.Values.ExtraText = ""
        Me.lblCantidad.Values.Image = Nothing
        Me.lblCantidad.Values.Text = "Cantidad : "
        '
        'txtUnidadPeso
        '
        Me.txtUnidadPeso.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaListarUnidadPeso})
        Me.txtUnidadPeso.Location = New System.Drawing.Point(242, 37)
        Me.txtUnidadPeso.MaxLength = 10
        Me.txtUnidadPeso.Name = "txtUnidadPeso"
        Me.txtUnidadPeso.Size = New System.Drawing.Size(100, 21)
        Me.txtUnidadPeso.TabIndex = 69
        Me.txtUnidadPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bsaListarUnidadPeso
        '
        Me.bsaListarUnidadPeso.ExtraText = ""
        Me.bsaListarUnidadPeso.Image = Nothing
        Me.bsaListarUnidadPeso.Text = ""
        Me.bsaListarUnidadPeso.ToolTipImage = Nothing
        Me.bsaListarUnidadPeso.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaListarUnidadPeso.UniqueName = "2D4EDDA325914A122D4EDDA325914A12"
        '
        'lblUnidadPeso
        '
        Me.lblUnidadPeso.Location = New System.Drawing.Point(184, 40)
        Me.lblUnidadPeso.Name = "lblUnidadPeso"
        Me.lblUnidadPeso.Size = New System.Drawing.Size(52, 19)
        Me.lblUnidadPeso.TabIndex = 68
        Me.lblUnidadPeso.Text = "Unidad :"
        Me.lblUnidadPeso.Values.ExtraText = ""
        Me.lblUnidadPeso.Values.Image = Nothing
        Me.lblUnidadPeso.Values.Text = "Unidad :"
        '
        'txtUnidadCantidad
        '
        Me.txtUnidadCantidad.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaListarUnidadCantidad})
        Me.txtUnidadCantidad.Location = New System.Drawing.Point(242, 12)
        Me.txtUnidadCantidad.MaxLength = 10
        Me.txtUnidadCantidad.Name = "txtUnidadCantidad"
        Me.txtUnidadCantidad.Size = New System.Drawing.Size(100, 21)
        Me.txtUnidadCantidad.TabIndex = 65
        Me.txtUnidadCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bsaListarUnidadCantidad
        '
        Me.bsaListarUnidadCantidad.ExtraText = ""
        Me.bsaListarUnidadCantidad.Image = Nothing
        Me.bsaListarUnidadCantidad.Text = ""
        Me.bsaListarUnidadCantidad.ToolTipImage = Nothing
        Me.bsaListarUnidadCantidad.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaListarUnidadCantidad.UniqueName = "33BE470ED3D044A133BE470ED3D044A1"
        '
        'lblUnidadCantidad
        '
        Me.lblUnidadCantidad.Location = New System.Drawing.Point(184, 15)
        Me.lblUnidadCantidad.Name = "lblUnidadCantidad"
        Me.lblUnidadCantidad.Size = New System.Drawing.Size(52, 19)
        Me.lblUnidadCantidad.TabIndex = 64
        Me.lblUnidadCantidad.Text = "Unidad : "
        Me.lblUnidadCantidad.Values.ExtraText = ""
        Me.lblUnidadCantidad.Values.Image = Nothing
        Me.lblUnidadCantidad.Values.Text = "Unidad : "
        '
        'frmEditaOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 105)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmEditaOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edita O/S"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
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
    Friend WithEvents txtPeso As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblPeso As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCantidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblCantidad As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtUnidadPeso As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaListarUnidadPeso As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents lblUnidadPeso As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtUnidadCantidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaListarUnidadCantidad As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents lblUnidadCantidad As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnCancelarCrearOS As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnProcesarCrearOS As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
