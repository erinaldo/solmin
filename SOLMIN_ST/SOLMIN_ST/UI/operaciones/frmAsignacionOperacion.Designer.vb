<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignacionOperacion
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
    Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.ckbClientesRansa = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Me.txtNroOperacionAgencias = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonBorderEdge1 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Me.txtOSAgencias = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.lblResultado = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
    Me.btnProcesar = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.btnCancelar = New System.Windows.Forms.ToolStripButton
    Me.txtOrdenServicio = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonHeaderGroup1.Panel.SuspendLayout()
    Me.KryptonHeaderGroup1.SuspendLayout()
    Me.ToolStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(368, 196)
    Me.KryptonPanel.TabIndex = 0
    '
    'KryptonHeaderGroup1
    '
    Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonHeaderGroup1.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.KryptonHeaderGroup1.HeaderVisiblePrimary = False
    Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
    Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
    '
    'KryptonHeaderGroup1.Panel
    '
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.ckbClientesRansa)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtNroOperacionAgencias)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel2)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonBorderEdge1)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtOSAgencias)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel3)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblResultado)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.ToolStrip1)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtOrdenServicio)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
    Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(368, 196)
    Me.KryptonHeaderGroup1.TabIndex = 0
    Me.KryptonHeaderGroup1.Text = "    "
    Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
    Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "    "
    Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
    Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
    Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "     "
    Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
    '
    'ckbClientesRansa
    '
    Me.ckbClientesRansa.CheckState = System.Windows.Forms.CheckState.Checked
    Me.ckbClientesRansa.Location = New System.Drawing.Point(144, 92)
    Me.ckbClientesRansa.Name = "ckbClientesRansa"
    Me.ckbClientesRansa.Size = New System.Drawing.Size(185, 19)
    Me.ckbClientesRansa.TabIndex = 11
    Me.ckbClientesRansa.Text = "Cliente Agencias Ransa (000606)"
    Me.ckbClientesRansa.Values.ExtraText = ""
    Me.ckbClientesRansa.Values.Image = Nothing
    Me.ckbClientesRansa.Values.Text = "Cliente Agencias Ransa (000606)"
    '
    'txtNroOperacionAgencias
    '
    Me.txtNroOperacionAgencias.Enabled = False
    Me.txtNroOperacionAgencias.Location = New System.Drawing.Point(144, 64)
    Me.txtNroOperacionAgencias.Name = "txtNroOperacionAgencias"
    Me.txtNroOperacionAgencias.Size = New System.Drawing.Size(216, 26)
    Me.txtNroOperacionAgencias.StateCommon.Content.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
    Me.txtNroOperacionAgencias.StateNormal.Content.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNroOperacionAgencias.TabIndex = 10
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(4, 72)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(139, 19)
    Me.KryptonLabel2.TabIndex = 9
    Me.KryptonLabel2.Text = "Nro Operación  Ag. Ransa"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "Nro Operación  Ag. Ransa"
    '
    'KryptonBorderEdge1
    '
    Me.KryptonBorderEdge1.Location = New System.Drawing.Point(8, 144)
    Me.KryptonBorderEdge1.Name = "KryptonBorderEdge1"
    Me.KryptonBorderEdge1.Size = New System.Drawing.Size(350, 1)
    Me.KryptonBorderEdge1.TabIndex = 8
    Me.KryptonBorderEdge1.Text = "KryptonBorderEdge1"
    '
    'txtOSAgencias
    '
    Me.txtOSAgencias.Enabled = False
    Me.txtOSAgencias.Location = New System.Drawing.Point(144, 32)
    Me.txtOSAgencias.Name = "txtOSAgencias"
    Me.txtOSAgencias.Size = New System.Drawing.Size(216, 26)
    Me.txtOSAgencias.StateCommon.Content.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
    Me.txtOSAgencias.StateNormal.Content.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtOSAgencias.TabIndex = 7
    '
    'KryptonLabel3
    '
    Me.KryptonLabel3.Location = New System.Drawing.Point(4, 40)
    Me.KryptonLabel3.Name = "KryptonLabel3"
    Me.KryptonLabel3.Size = New System.Drawing.Size(132, 19)
    Me.KryptonLabel3.TabIndex = 6
    Me.KryptonLabel3.Text = "Nro O/S Agencias Ransa"
    Me.KryptonLabel3.Values.ExtraText = ""
    Me.KryptonLabel3.Values.Image = Nothing
    Me.KryptonLabel3.Values.Text = "Nro O/S Agencias Ransa"
    '
    'lblResultado
    '
    Me.lblResultado.Location = New System.Drawing.Point(8, 156)
    Me.lblResultado.Name = "lblResultado"
    Me.lblResultado.Size = New System.Drawing.Size(10, 19)
    Me.lblResultado.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
    Me.lblResultado.TabIndex = 5
    Me.lblResultado.Text = "   "
    Me.lblResultado.Values.ExtraText = ""
    Me.lblResultado.Values.Image = Nothing
    Me.lblResultado.Values.Text = "   "
    '
    'ToolStrip1
    '
    Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnProcesar, Me.ToolStripSeparator1, Me.btnCancelar})
    Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.Size = New System.Drawing.Size(366, 25)
    Me.ToolStrip1.TabIndex = 4
    Me.ToolStrip1.Text = "ToolStrip1"
    '
    'btnProcesar
    '
    Me.btnProcesar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
    Me.btnProcesar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnProcesar.Name = "btnProcesar"
    Me.btnProcesar.Size = New System.Drawing.Size(70, 22)
    Me.btnProcesar.Text = "Procesar"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
    '
    'btnCancelar
    '
    Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources._stop
    Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(71, 22)
    Me.btnCancelar.Text = "Cancelar"
    '
    'txtOrdenServicio
    '
    Me.txtOrdenServicio.Location = New System.Drawing.Point(144, 112)
    Me.txtOrdenServicio.Name = "txtOrdenServicio"
    Me.txtOrdenServicio.Size = New System.Drawing.Size(216, 26)
    Me.txtOrdenServicio.StateCommon.Content.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
    Me.txtOrdenServicio.StateNormal.Content.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtOrdenServicio.TabIndex = 3
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(4, 120)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(128, 19)
    Me.KryptonLabel1.TabIndex = 0
    Me.KryptonLabel1.Text = "Nro O/S Trasportes M.E"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Nro O/S Trasportes M.E"
    '
    'frmAsignacionOperacion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(368, 196)
    Me.Controls.Add(Me.KryptonPanel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmAsignacionOperacion"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Asignacion de Operacion - Agencias Ransa"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
    Me.KryptonHeaderGroup1.Panel.PerformLayout()
    CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonHeaderGroup1.ResumeLayout(False)
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
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnProcesar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtOrdenServicio As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblResultado As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtOSAgencias As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonBorderEdge1 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents txtNroOperacionAgencias As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ckbClientesRansa As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
End Class
