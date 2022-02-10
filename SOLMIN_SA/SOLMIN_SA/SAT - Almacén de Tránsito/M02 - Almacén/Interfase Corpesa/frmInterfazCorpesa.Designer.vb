<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInterfazCorpesa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInterfazCorpesa))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.btnGrabar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnCerrar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtNroDocumentoES = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.btnGrabar)
        Me.KryptonPanel.Controls.Add(Me.btnCerrar)
        Me.KryptonPanel.Controls.Add(Me.txtNroDocumentoES)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(310, 92)
        Me.KryptonPanel.TabIndex = 0
        '
        'btnGrabar
        '
        Me.btnGrabar.AutoSize = True
        Me.btnGrabar.Location = New System.Drawing.Point(98, 47)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(90, 28)
        Me.btnGrabar.TabIndex = 36
        Me.btnGrabar.Text = "    Grabar"
        Me.btnGrabar.Values.ExtraText = ""
        Me.btnGrabar.Values.Image = CType(resources.GetObject("btnGrabar.Values.Image"), System.Drawing.Image)
        Me.btnGrabar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnGrabar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnGrabar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnGrabar.Values.Text = "    Grabar"
        '
        'btnCerrar
        '
        Me.btnCerrar.AutoSize = True
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Location = New System.Drawing.Point(194, 47)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(90, 28)
        Me.btnCerrar.TabIndex = 37
        Me.btnCerrar.Text = "    Cerrar"
        Me.btnCerrar.Values.ExtraText = ""
        Me.btnCerrar.Values.Image = CType(resources.GetObject("btnCerrar.Values.Image"), System.Drawing.Image)
        Me.btnCerrar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCerrar.Values.Text = "    Cerrar"
        '
        'txtNroDocumentoES
        '
        Me.txtNroDocumentoES.Location = New System.Drawing.Point(94, 22)
        Me.txtNroDocumentoES.MaxLength = 35
        Me.txtNroDocumentoES.Name = "txtNroDocumentoES"
        Me.txtNroDocumentoES.Size = New System.Drawing.Size(194, 21)
        Me.txtNroDocumentoES.TabIndex = 35
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(25, 22)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(70, 19)
        Me.KryptonLabel1.TabIndex = 34
        Me.KryptonLabel1.Text = "Nro. Bulto  : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Nro. Bulto  : "
        '
        'frmInterfazCorpesa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 92)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmInterfazCorpesa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Bulto - Interfase Corpesa"
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
    Friend WithEvents btnGrabar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnCerrar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtNroDocumentoES As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
