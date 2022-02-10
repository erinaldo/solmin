<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmObtenerVolumenBulto
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
        Me.HeaderSolicitud = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.txtAltura = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.btnSalir = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtLargo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtAncho = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnCerrar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.HeaderSolicitud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderSolicitud.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderSolicitud.Panel.SuspendLayout()
        Me.HeaderSolicitud.SuspendLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.HeaderSolicitud)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(218, 155)
        Me.KryptonPanel.TabIndex = 0
        '
        'HeaderSolicitud
        '
        Me.HeaderSolicitud.CollapseTarget = ComponentFactory.Krypton.Toolkit.HeaderGroupCollapsedTarget.CollapsedToBoth
        Me.HeaderSolicitud.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderSolicitud.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HeaderSolicitud.HeaderVisibleSecondary = False
        Me.HeaderSolicitud.Location = New System.Drawing.Point(0, 0)
        Me.HeaderSolicitud.Name = "HeaderSolicitud"
        '
        'HeaderSolicitud.Panel
        '
        Me.HeaderSolicitud.Panel.Controls.Add(Me.KryptonGroup1)
        Me.HeaderSolicitud.Size = New System.Drawing.Size(218, 155)
        Me.HeaderSolicitud.StateCommon.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Form
        Me.HeaderSolicitud.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Rounded
        Me.HeaderSolicitud.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[True]
        Me.HeaderSolicitud.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.HeaderSolicitud.TabIndex = 110
        Me.HeaderSolicitud.ValuesPrimary.Description = ""
        Me.HeaderSolicitud.ValuesPrimary.Heading = ""
        Me.HeaderSolicitud.ValuesPrimary.Image = Nothing
        Me.HeaderSolicitud.ValuesSecondary.Description = ""
        Me.HeaderSolicitud.ValuesSecondary.Heading = ""
        Me.HeaderSolicitud.ValuesSecondary.Image = Nothing
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtAltura)
        Me.KryptonGroup1.Panel.Controls.Add(Me.btnSalir)
        Me.KryptonGroup1.Panel.Controls.Add(Me.btnAceptar)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtLargo)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtAncho)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonGroup1.Panel.Controls.Add(Me.btnCerrar)
        Me.KryptonGroup1.Size = New System.Drawing.Size(216, 150)
        Me.KryptonGroup1.TabIndex = 9
        '
        'txtAltura
        '
        Me.TypeValidator.SetDecimales(Me.txtAltura, 2)
        Me.TypeValidator.SetEnterTAB(Me.txtAltura, True)
        Me.txtAltura.Location = New System.Drawing.Point(51, 19)
        Me.txtAltura.MaxLength = 7
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(145, 21)
        Me.txtAltura.TabIndex = 22
        Me.txtAltura.Text = "0.00"
        Me.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtAltura, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(141, 103)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(55, 25)
        Me.btnSalir.TabIndex = 21
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.Values.ExtraText = ""
        Me.btnSalir.Values.Image = Nothing
        Me.btnSalir.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnSalir.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnSalir.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnSalir.Values.Text = "Salir"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(73, 103)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(55, 25)
        Me.btnAceptar.TabIndex = 20
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.Values.ExtraText = ""
        Me.btnAceptar.Values.Image = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAceptar.Values.Text = "Aceptar"
        '
        'txtLargo
        '
        Me.TypeValidator.SetDecimales(Me.txtLargo, 2)
        Me.TypeValidator.SetEnterTAB(Me.txtLargo, True)
        Me.txtLargo.Location = New System.Drawing.Point(51, 69)
        Me.txtLargo.MaxLength = 7
        Me.txtLargo.Name = "txtLargo"
        Me.txtLargo.Size = New System.Drawing.Size(145, 21)
        Me.txtLargo.TabIndex = 3
        Me.txtLargo.Text = "0.00"
        Me.txtLargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtLargo, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'txtAncho
        '
        Me.TypeValidator.SetDecimales(Me.txtAncho, 2)
        Me.TypeValidator.SetEnterTAB(Me.txtAncho, True)
        Me.txtAncho.Location = New System.Drawing.Point(51, 43)
        Me.txtAncho.MaxLength = 7
        Me.txtAncho.Name = "txtAncho"
        Me.txtAncho.Size = New System.Drawing.Size(145, 21)
        Me.txtAncho.TabIndex = 2
        Me.txtAncho.Text = "0.00"
        Me.txtAncho.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtAncho, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(6, 71)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(39, 19)
        Me.KryptonLabel3.TabIndex = 1
        Me.KryptonLabel3.Text = "Largo"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Largo"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(5, 45)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(42, 19)
        Me.KryptonLabel2.TabIndex = 1
        Me.KryptonLabel2.Text = "Ancho"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Ancho"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(5, 19)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(40, 19)
        Me.KryptonLabel1.TabIndex = 1
        Me.KryptonLabel1.Text = "Altura"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Altura"
        '
        'btnCerrar
        '
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Location = New System.Drawing.Point(320, 17)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(8, 8)
        Me.btnCerrar.TabIndex = 19
        Me.btnCerrar.Text = "Cerrar Ventana"
        Me.btnCerrar.Values.ExtraText = ""
        Me.btnCerrar.Values.Image = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCerrar.Values.Text = "Cerrar Ventana"
        '
        'frmObtenerVolumenBulto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(218, 155)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmObtenerVolumenBulto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Volumen de Bulto"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.HeaderSolicitud.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderSolicitud.Panel.ResumeLayout(False)
        CType(Me.HeaderSolicitud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderSolicitud.ResumeLayout(False)
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        Me.KryptonGroup1.Panel.PerformLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
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
    Friend WithEvents HeaderSolicitud As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnCerrar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtLargo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtAncho As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtAltura As ComponentFactory.Krypton.Toolkit.KryptonTextBox
End Class
