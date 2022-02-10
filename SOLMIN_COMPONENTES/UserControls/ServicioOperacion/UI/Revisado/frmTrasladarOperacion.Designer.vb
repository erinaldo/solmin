<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrasladarOperacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrasladarOperacion))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.UCtxtRevision = New Ransa.Utilitario.UCtxtSoloDecimales
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblRevision = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip2)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(375, 136)
        Me.KryptonPanel.TabIndex = 0
        '
        'UCtxtRevision
        '
        Me.UCtxtRevision.AllowDrop = True
        Me.UCtxtRevision.BackColor = System.Drawing.Color.Transparent
        Me.UCtxtRevision.Location = New System.Drawing.Point(119, 70)
        Me.UCtxtRevision.Name = "UCtxtRevision"
        Me.UCtxtRevision.NumerosDecimales = 0
        Me.UCtxtRevision.NumerosEnteros = 10
        Me.UCtxtRevision.Size = New System.Drawing.Size(95, 22)
        Me.UCtxtRevision.TabIndex = 10
      
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(9, 70)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(92, 19)
        Me.KryptonLabel4.TabIndex = 9
        Me.KryptonLabel4.Text = "Nueva Revisión : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Nueva Revisión : "
        '
        'lblRevision
        '
        Me.lblRevision.Location = New System.Drawing.Point(117, 45)
        Me.lblRevision.Name = "lblRevision"
        Me.lblRevision.Size = New System.Drawing.Size(64, 19)
        Me.lblRevision.TabIndex = 8
        Me.lblRevision.Text = "lblRevision"
        Me.lblRevision.Values.ExtraText = ""
        Me.lblRevision.Values.Image = Nothing
        Me.lblRevision.Values.Text = "lblRevision"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(9, 45)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(95, 19)
        Me.KryptonLabel2.TabIndex = 7
        Me.KryptonLabel2.Text = "Nro de Revisión : "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Nro de Revisión : "
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(117, 20)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(57, 19)
        Me.lblCliente.TabIndex = 6
        Me.lblCliente.Text = "lblCliente"
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "lblCliente"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(9, 20)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(50, 19)
        Me.KryptonLabel1.TabIndex = 5
        Me.KryptonLabel1.Text = "Cliente : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Cliente : "
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.btnCancelar, Me.btnAceptar})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(375, 25)
        Me.ToolStrip2.TabIndex = 4
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(10, 22)
        Me.ToolStripLabel3.Text = " "
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.salir
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(71, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAceptar.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.button_ok
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(66, 22)
        Me.btnAceptar.Text = "Aceptar"
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup1.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 25)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.UCtxtRevision)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCliente)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblRevision)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(375, 111)
        Me.KryptonHeaderGroup1.TabIndex = 11
        Me.KryptonHeaderGroup1.Text = "Heading"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup1.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'frmTrasladarOperacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 136)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmTrasladarOperacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Trasladar Operación"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
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
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents UCtxtRevision As Ransa.Utilitario.UCtxtSoloDecimales
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblRevision As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
End Class
