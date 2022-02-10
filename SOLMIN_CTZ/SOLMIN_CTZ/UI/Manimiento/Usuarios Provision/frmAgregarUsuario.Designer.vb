<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarUsuario
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
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.Uc_CboUsuario1 = New Ransa.Controls.Menu.uc_CboUsuario
        Me.lblUsuario = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.btnCancelarTarifa = New System.Windows.Forms.ToolStripButton
        Me.tsSep_05 = New System.Windows.Forms.ToolStripSeparator
        Me.btnGrabarTarifa = New System.Windows.Forms.ToolStripButton
        Me.tssSep_02 = New System.Windows.Forms.ToolStripSeparator
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.tsMenuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Controls.Add(Me.lblUsuario)
        Me.KryptonPanel.Controls.Add(Me.Uc_CboUsuario1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(317, 104)
        Me.KryptonPanel.TabIndex = 0
        '
        'Uc_CboUsuario1
        '
        Me.Uc_CboUsuario1.Location = New System.Drawing.Point(82, 53)
        Me.Uc_CboUsuario1.Name = "Uc_CboUsuario1"
        Me.Uc_CboUsuario1.pPSMMCUSR = ""
        Me.Uc_CboUsuario1.pPSMMNUSR = ""
        Me.Uc_CboUsuario1.Size = New System.Drawing.Size(198, 22)
        Me.Uc_CboUsuario1.TabIndex = 0
        '
        'lblUsuario
        '
        Me.lblUsuario.Location = New System.Drawing.Point(24, 53)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(52, 20)
        Me.lblUsuario.TabIndex = 1
        Me.lblUsuario.Text = "Usuario"
        Me.lblUsuario.Values.ExtraText = ""
        Me.lblUsuario.Values.Image = Nothing
        Me.lblUsuario.Values.Text = "Usuario"
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelarTarifa, Me.tsSep_05, Me.btnGrabarTarifa, Me.tssSep_02})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(317, 25)
        Me.tsMenuOpciones.TabIndex = 2
        '
        'btnCancelarTarifa
        '
        Me.btnCancelarTarifa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelarTarifa.Image = Global.SOLMIN_CT.My.Resources.Resources._exit
        Me.btnCancelarTarifa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelarTarifa.Name = "btnCancelarTarifa"
        Me.btnCancelarTarifa.Size = New System.Drawing.Size(73, 22)
        Me.btnCancelarTarifa.Text = "Cancelar"
        '
        'tsSep_05
        '
        Me.tsSep_05.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsSep_05.Name = "tsSep_05"
        Me.tsSep_05.Size = New System.Drawing.Size(6, 25)
        '
        'btnGrabarTarifa
        '
        Me.btnGrabarTarifa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGrabarTarifa.Image = Global.SOLMIN_CT.My.Resources.Resources.save_all
        Me.btnGrabarTarifa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGrabarTarifa.Name = "btnGrabarTarifa"
        Me.btnGrabarTarifa.Size = New System.Drawing.Size(69, 22)
        Me.btnGrabarTarifa.Text = "Guardar"
        '
        'tssSep_02
        '
        Me.tssSep_02.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_02.Name = "tssSep_02"
        Me.tssSep_02.Size = New System.Drawing.Size(6, 25)
        '
        'frmAgregarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 104)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximumSize = New System.Drawing.Size(400, 300)
        Me.Name = "frmAgregarUsuario"
        Me.Text = "Agregar Usuario"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
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
    Friend WithEvents lblUsuario As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Uc_CboUsuario1 As Ransa.Controls.Menu.uc_CboUsuario
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCancelarTarifa As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSep_05 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGrabarTarifa As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_02 As System.Windows.Forms.ToolStripSeparator
End Class
