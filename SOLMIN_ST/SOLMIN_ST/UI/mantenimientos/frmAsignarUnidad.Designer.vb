<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarUnidad
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
        Me.KryptonLabel15 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel16 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel17 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbConductor_1 = New Ransa.Controls.Transportista.ucConductor_TxtF01
        Me.ctbTracto_1 = New Ransa.Controls.Transportista.ucTractoTransportista_TxtF01
        Me.ctbTransportista_1 = New Ransa.Controls.Transportista.ucTransportista_TxtF01
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel15)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel16)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel17)
        Me.KryptonPanel.Controls.Add(Me.cmbConductor_1)
        Me.KryptonPanel.Controls.Add(Me.ctbTracto_1)
        Me.KryptonPanel.Controls.Add(Me.ctbTransportista_1)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(440, 142)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonLabel15
        '
        Me.KryptonLabel15.Location = New System.Drawing.Point(12, 98)
        Me.KryptonLabel15.Name = "KryptonLabel15"
        Me.KryptonLabel15.Size = New System.Drawing.Size(68, 20)
        Me.KryptonLabel15.TabIndex = 158
        Me.KryptonLabel15.Text = "Conductor"
        Me.KryptonLabel15.Values.ExtraText = ""
        Me.KryptonLabel15.Values.Image = Nothing
        Me.KryptonLabel15.Values.Text = "Conductor"
        '
        'KryptonLabel16
        '
        Me.KryptonLabel16.Location = New System.Drawing.Point(12, 70)
        Me.KryptonLabel16.Name = "KryptonLabel16"
        Me.KryptonLabel16.Size = New System.Drawing.Size(45, 20)
        Me.KryptonLabel16.TabIndex = 157
        Me.KryptonLabel16.Text = "Tracto"
        Me.KryptonLabel16.Values.ExtraText = ""
        Me.KryptonLabel16.Values.Image = Nothing
        Me.KryptonLabel16.Values.Text = "Tracto"
        '
        'KryptonLabel17
        '
        Me.KryptonLabel17.Location = New System.Drawing.Point(12, 42)
        Me.KryptonLabel17.Name = "KryptonLabel17"
        Me.KryptonLabel17.Size = New System.Drawing.Size(82, 20)
        Me.KryptonLabel17.TabIndex = 156
        Me.KryptonLabel17.Text = "Transportista"
        Me.KryptonLabel17.Values.ExtraText = ""
        Me.KryptonLabel17.Values.Image = Nothing
        Me.KryptonLabel17.Values.Text = "Transportista"
        '
        'cmbConductor_1
        '
        Me.cmbConductor_1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmbConductor_1.BackColor = System.Drawing.Color.Transparent
        Me.cmbConductor_1.Enabled = False
        Me.cmbConductor_1.Location = New System.Drawing.Point(100, 99)
        Me.cmbConductor_1.Name = "cmbConductor_1"
        Me.cmbConductor_1.pRequerido = False
        Me.cmbConductor_1.Size = New System.Drawing.Size(311, 22)
        Me.cmbConductor_1.TabIndex = 155
        '
        'ctbTracto_1
        '
        Me.ctbTracto_1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ctbTracto_1.BackColor = System.Drawing.Color.Transparent
        Me.ctbTracto_1.Enabled = False
        Me.ctbTracto_1.Location = New System.Drawing.Point(100, 70)
        Me.ctbTracto_1.Name = "ctbTracto_1"
        Me.ctbTracto_1.pRequerido = False
        Me.ctbTracto_1.Size = New System.Drawing.Size(311, 22)
        Me.ctbTracto_1.TabIndex = 154
        '
        'ctbTransportista_1
        '
        Me.ctbTransportista_1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ctbTransportista_1.BackColor = System.Drawing.Color.Transparent
        Me.ctbTransportista_1.Enabled = False
        Me.ctbTransportista_1.Location = New System.Drawing.Point(100, 42)
        Me.ctbTransportista_1.Name = "ctbTransportista_1"
        Me.ctbTransportista_1.pNroRegPorPaginas = 0
        Me.ctbTransportista_1.pRequerido = False
        Me.ctbTransportista_1.Size = New System.Drawing.Size(311, 22)
        Me.ctbTransportista_1.TabIndex = 153
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.btnAceptar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(440, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources._exit
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(73, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAceptar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(68, 22)
        Me.btnAceptar.Text = "Aceptar"
        '
        'frmAsignarUnidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 142)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmAsignarUnidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Asignación unidad"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
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
    Friend WithEvents cmbConductor_1 As Ransa.Controls.Transportista.ucConductor_TxtF01
    Friend WithEvents ctbTracto_1 As Ransa.Controls.Transportista.ucTractoTransportista_TxtF01
    Friend WithEvents ctbTransportista_1 As Ransa.Controls.Transportista.ucTransportista_TxtF01
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents KryptonLabel15 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel16 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel17 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
End Class
