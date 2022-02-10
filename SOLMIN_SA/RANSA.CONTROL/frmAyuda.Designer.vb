<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAyuda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAyuda))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.cmdAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.cmdCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.dtgAyuda = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dtgAyuda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.cmdAceptar)
        Me.KryptonPanel.Controls.Add(Me.cmdCancelar)
        Me.KryptonPanel.Controls.Add(Me.dtgAyuda)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(484, 377)
        Me.KryptonPanel.TabIndex = 0
        '
        'cmdAceptar
        '
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdAceptar.Location = New System.Drawing.Point(290, 342)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(90, 25)
        Me.cmdAceptar.TabIndex = 6
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.Values.ExtraText = ""
        Me.cmdAceptar.Values.Image = CType(resources.GetObject("cmdAceptar.Values.Image"), System.Drawing.Image)
        Me.cmdAceptar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.cmdAceptar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.cmdAceptar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.cmdAceptar.Values.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(386, 342)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(90, 25)
        Me.cmdCancelar.TabIndex = 7
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.Values.ExtraText = ""
        Me.cmdCancelar.Values.Image = CType(resources.GetObject("cmdCancelar.Values.Image"), System.Drawing.Image)
        Me.cmdCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.cmdCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.cmdCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.cmdCancelar.Values.Text = "Cancelar"
        '
        'dtgAyuda
        '
        Me.dtgAyuda.AllowUserToAddRows = False
        Me.dtgAyuda.AllowUserToDeleteRows = False
        Me.dtgAyuda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgAyuda.Location = New System.Drawing.Point(12, 12)
        Me.dtgAyuda.Name = "dtgAyuda"
        Me.dtgAyuda.ReadOnly = True
        Me.dtgAyuda.Size = New System.Drawing.Size(464, 324)
        Me.dtgAyuda.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgAyuda.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dtgAyuda.TabIndex = 0
        '
        'frmAyuda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 377)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAyuda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.dtgAyuda, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dtgAyuda As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents cmdAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cmdCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
