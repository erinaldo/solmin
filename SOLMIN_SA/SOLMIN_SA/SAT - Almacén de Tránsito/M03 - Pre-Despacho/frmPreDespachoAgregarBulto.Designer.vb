<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreDespachoAgregarBulto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPreDespachoAgregarBulto))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.cmdCerrar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.cmdGrabar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCodigoBulto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(339, 96)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.cmdCerrar)
        Me.KryptonGroup1.Panel.Controls.Add(Me.cmdGrabar)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtCodigoBulto)
        Me.KryptonGroup1.Size = New System.Drawing.Size(339, 96)
        Me.KryptonGroup1.TabIndex = 40
        '
        'cmdCerrar
        '
        Me.cmdCerrar.AutoSize = True
        Me.cmdCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCerrar.Location = New System.Drawing.Point(226, 48)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(90, 28)
        Me.cmdCerrar.TabIndex = 37
        Me.cmdCerrar.Text = "    Cerrar"
        Me.cmdCerrar.Values.ExtraText = ""
        Me.cmdCerrar.Values.Image = CType(resources.GetObject("cmdCerrar.Values.Image"), System.Drawing.Image)
        Me.cmdCerrar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.cmdCerrar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.cmdCerrar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.cmdCerrar.Values.Text = "    Cerrar"
        '
        'cmdGrabar
        '
        Me.cmdGrabar.AutoSize = True
        Me.cmdGrabar.Location = New System.Drawing.Point(130, 48)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(90, 28)
        Me.cmdGrabar.TabIndex = 36
        Me.cmdGrabar.Text = "    Grabar"
        Me.cmdGrabar.Values.ExtraText = ""
        Me.cmdGrabar.Values.Image = CType(resources.GetObject("cmdGrabar.Values.Image"), System.Drawing.Image)
        Me.cmdGrabar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.cmdGrabar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.cmdGrabar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.cmdGrabar.Values.Text = "    Grabar"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(11, 11)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(97, 19)
        Me.KryptonLabel1.TabIndex = 34
        Me.KryptonLabel1.Text = "Código de Bulto : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Código de Bulto : "
        '
        'txtCodigoBulto
        '
        Me.txtCodigoBulto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoBulto.Location = New System.Drawing.Point(130, 11)
        Me.txtCodigoBulto.MaxLength = 10
        Me.txtCodigoBulto.Name = "txtCodigoBulto"
        Me.txtCodigoBulto.Size = New System.Drawing.Size(186, 21)
        Me.txtCodigoBulto.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodigoBulto.TabIndex = 35
        '
        'frmPreDespachoAgregarBulto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 96)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(345, 120)
        Me.MinimumSize = New System.Drawing.Size(345, 120)
        Me.Name = "frmPreDespachoAgregarBulto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Bulto"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
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
    Friend WithEvents cmdGrabar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cmdCerrar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtCodigoBulto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
End Class
