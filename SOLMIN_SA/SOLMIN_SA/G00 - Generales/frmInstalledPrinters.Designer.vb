<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInstalledPrinters
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
        Me.grpImpresoras = New System.Windows.Forms.GroupBox
        Me.cbxImpresoras = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnSeleccionar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.grpImpresoras.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.grpImpresoras)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(481, 135)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 0
        '
        'grpImpresoras
        '
        Me.grpImpresoras.BackColor = System.Drawing.Color.Transparent
        Me.grpImpresoras.Controls.Add(Me.cbxImpresoras)
        Me.grpImpresoras.Controls.Add(Me.btnCancelar)
        Me.grpImpresoras.Controls.Add(Me.btnSeleccionar)
        Me.grpImpresoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpImpresoras.Location = New System.Drawing.Point(12, 12)
        Me.grpImpresoras.Name = "grpImpresoras"
        Me.grpImpresoras.Size = New System.Drawing.Size(457, 105)
        Me.grpImpresoras.TabIndex = 1
        Me.grpImpresoras.TabStop = False
        Me.grpImpresoras.Text = "Selecciones una Impresora"
        '
        'cbxImpresoras
        '
        Me.cbxImpresoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxImpresoras.DropDownWidth = 445
        Me.cbxImpresoras.FormattingEnabled = False
        Me.cbxImpresoras.ItemHeight = 13
        Me.cbxImpresoras.Location = New System.Drawing.Point(6, 19)
        Me.cbxImpresoras.Name = "cbxImpresoras"
        Me.cbxImpresoras.Size = New System.Drawing.Size(445, 21)
        Me.cbxImpresoras.TabIndex = 2
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(361, 64)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 25)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "&Cancelar"
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSeleccionar.Location = New System.Drawing.Point(265, 64)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(90, 25)
        Me.btnSeleccionar.TabIndex = 3
        Me.btnSeleccionar.Text = "&Seleccionar"
        Me.btnSeleccionar.Values.ExtraText = ""
        Me.btnSeleccionar.Values.Image = Nothing
        Me.btnSeleccionar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnSeleccionar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnSeleccionar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnSeleccionar.Values.Text = "&Seleccionar"
        '
        'frmInstalledPrinters
        '
        Me.AcceptButton = Me.btnSeleccionar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(481, 135)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmInstalledPrinters"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresoras Instaladas"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.grpImpresoras.ResumeLayout(False)
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
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnSeleccionar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents grpImpresoras As System.Windows.Forms.GroupBox
    Friend WithEvents cbxImpresoras As ComponentFactory.Krypton.Toolkit.KryptonComboBox
End Class
