<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubirArchivo
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
        Me.txtObservaciones = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.UploadBrowser = New System.Windows.Forms.WebBrowser
        Me.tsMenuOpcionesDetalle = New System.Windows.Forms.ToolStrip
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.tssCancelar = New System.Windows.Forms.ToolStripSeparator
        Me.btnVistaPrevia = New System.Windows.Forms.ToolStripButton
        Me.tssCerrar = New System.Windows.Forms.ToolStripSeparator
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.lblObservaciones = New System.Windows.Forms.Label
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.tsMenuOpcionesDetalle.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.txtObservaciones)
        Me.KryptonPanel.Controls.Add(Me.lblObservaciones)
        Me.KryptonPanel.Controls.Add(Me.UploadBrowser)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpcionesDetalle)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(489, 260)
        Me.KryptonPanel.TabIndex = 0
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(87, 215)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(360, 39)
        Me.txtObservaciones.TabIndex = 76
        '
        'UploadBrowser
        '
        Me.UploadBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UploadBrowser.Location = New System.Drawing.Point(0, 25)
        Me.UploadBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.UploadBrowser.Name = "UploadBrowser"
        Me.UploadBrowser.Size = New System.Drawing.Size(489, 235)
        Me.UploadBrowser.TabIndex = 0
        '
        'tsMenuOpcionesDetalle
        '
        Me.tsMenuOpcionesDetalle.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsMenuOpcionesDetalle.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpcionesDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.tssCancelar, Me.btnVistaPrevia, Me.tssCerrar})
        Me.tsMenuOpcionesDetalle.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpcionesDetalle.Name = "tsMenuOpcionesDetalle"
        Me.tsMenuOpcionesDetalle.Size = New System.Drawing.Size(489, 25)
        Me.tsMenuOpcionesDetalle.TabIndex = 75
        Me.tsMenuOpcionesDetalle.Text = "Detalle Guía de Remisión"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_SA.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(71, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'tssCancelar
        '
        Me.tssCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssCancelar.Name = "tssCancelar"
        Me.tssCancelar.Size = New System.Drawing.Size(6, 25)
        '
        'btnVistaPrevia
        '
        Me.btnVistaPrevia.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnVistaPrevia.Image = Global.SOLMIN_SA.My.Resources.Resources.retencion
        Me.btnVistaPrevia.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnVistaPrevia.Name = "btnVistaPrevia"
        Me.btnVistaPrevia.Size = New System.Drawing.Size(66, 22)
        Me.btnVistaPrevia.Text = "Aceptar"
        '
        'tssCerrar
        '
        Me.tssCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssCerrar.Name = "tssCerrar"
        Me.tssCerrar.Size = New System.Drawing.Size(6, 25)
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.BackColor = System.Drawing.Color.White
        Me.lblObservaciones.Location = New System.Drawing.Point(3, 215)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(78, 13)
        Me.lblObservaciones.TabIndex = 79
        Me.lblObservaciones.Text = "Observaciones"
        '
        'frmSubirArchivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 260)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSubirArchivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subir Archivo"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.tsMenuOpcionesDetalle.ResumeLayout(False)
        Me.tsMenuOpcionesDetalle.PerformLayout()
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
    Friend WithEvents UploadBrowser As System.Windows.Forms.WebBrowser
    Private WithEvents tsMenuOpcionesDetalle As System.Windows.Forms.ToolStrip
    Friend WithEvents btnVistaPrevia As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssCerrar As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssCancelar As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtObservaciones As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
End Class
