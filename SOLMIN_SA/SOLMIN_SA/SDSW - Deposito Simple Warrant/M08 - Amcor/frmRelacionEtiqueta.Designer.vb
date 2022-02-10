<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelacionEtiqueta
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
        Me.btnProcesar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtRuta = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaBuscar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.btnProcesar)
        Me.KryptonPanel.Controls.Add(Me.txtRuta)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(368, 62)
        Me.KryptonPanel.TabIndex = 0
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(303, 21)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(58, 25)
        Me.btnProcesar.TabIndex = 2
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.Values.ExtraText = ""
        Me.btnProcesar.Values.Image = Nothing
        Me.btnProcesar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnProcesar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnProcesar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnProcesar.Values.Text = "Procesar"
        '
        'txtRuta
        '
        Me.txtRuta.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaBuscar})
        Me.txtRuta.Location = New System.Drawing.Point(94, 21)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Size = New System.Drawing.Size(197, 21)
        Me.txtRuta.TabIndex = 1
        '
        'bsaBuscar
        '
        Me.bsaBuscar.ExtraText = ""
        Me.bsaBuscar.Image = Nothing
        Me.bsaBuscar.Text = ""
        Me.bsaBuscar.ToolTipImage = Nothing
        Me.bsaBuscar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context
        Me.bsaBuscar.UniqueName = "DECED5CA7F00464ADECED5CA7F00464A"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(12, 21)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(76, 19)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Text = "Ruta Archivo:"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Ruta Archivo:"
        '
        'frmRelacionEtiqueta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 62)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmRelacionEtiqueta"
        Me.Text = "Relacion Etiqueta"
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
    Friend WithEvents txtRuta As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaBuscar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnProcesar As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
