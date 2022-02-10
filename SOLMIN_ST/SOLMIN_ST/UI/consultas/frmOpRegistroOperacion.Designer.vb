<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpRegistroOperacion
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
    Me.panel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.MenuBar = New System.Windows.Forms.ToolStrip
    Me.btnCancelar = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.btnAceptar = New System.Windows.Forms.ToolStripButton
    Me.rbtnGenerarNuevo = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Me.rbtnReutilizar = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.panel.SuspendLayout()
    Me.MenuBar.SuspendLayout()
    Me.SuspendLayout()
    '
    'panel
    '
    Me.panel.Controls.Add(Me.MenuBar)
    Me.panel.Controls.Add(Me.rbtnGenerarNuevo)
    Me.panel.Controls.Add(Me.rbtnReutilizar)
    Me.panel.Controls.Add(Me.KryptonLabel1)
    Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.panel.Location = New System.Drawing.Point(0, 0)
    Me.panel.Name = "panel"
    Me.panel.Size = New System.Drawing.Size(422, 108)
    Me.panel.StateCommon.Color1 = System.Drawing.Color.White
    Me.panel.TabIndex = 0
    '
    'MenuBar
    '
    Me.MenuBar.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
    Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.ToolStripSeparator1, Me.btnAceptar})
    Me.MenuBar.Location = New System.Drawing.Point(0, 0)
    Me.MenuBar.Name = "MenuBar"
    Me.MenuBar.Size = New System.Drawing.Size(422, 25)
    Me.MenuBar.TabIndex = 4
    Me.MenuBar.Text = "ToolStrip1"
    '
    'btnCancelar
    '
    Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
    Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(69, 22)
    Me.btnCancelar.Text = "Cancelar"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
    '
    'btnAceptar
    '
    Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnAceptar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok
    Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnAceptar.Name = "btnAceptar"
    Me.btnAceptar.Size = New System.Drawing.Size(65, 22)
    Me.btnAceptar.Text = "Aceptar"
    '
    'rbtnGenerarNuevo
    '
    Me.rbtnGenerarNuevo.Location = New System.Drawing.Point(8, 80)
    Me.rbtnGenerarNuevo.Name = "rbtnGenerarNuevo"
    Me.rbtnGenerarNuevo.Size = New System.Drawing.Size(338, 19)
    Me.rbtnGenerarNuevo.TabIndex = 3
    Me.rbtnGenerarNuevo.Text = "Deseo generar un nuevo número de Operación y Planeamiento"
    Me.rbtnGenerarNuevo.Values.ExtraText = ""
    Me.rbtnGenerarNuevo.Values.Image = Nothing
    Me.rbtnGenerarNuevo.Values.Text = "Deseo generar un nuevo número de Operación y Planeamiento"
    '
    'rbtnReutilizar
    '
    Me.rbtnReutilizar.Checked = True
    Me.rbtnReutilizar.Location = New System.Drawing.Point(8, 56)
    Me.rbtnReutilizar.Name = "rbtnReutilizar"
    Me.rbtnReutilizar.Size = New System.Drawing.Size(18, 12)
    Me.rbtnReutilizar.TabIndex = 1
    Me.rbtnReutilizar.Values.ExtraText = ""
    Me.rbtnReutilizar.Values.Image = Nothing
    Me.rbtnReutilizar.Values.Text = ""
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(8, 32)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(301, 19)
    Me.KryptonLabel1.TabIndex = 0
    Me.KryptonLabel1.Text = "Elija una opción para confirmar la operación de transporte"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Elija una opción para confirmar la operación de transporte"
    '
    'frmOpRegistroOperacion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(422, 108)
    Me.ControlBox = False
    Me.Controls.Add(Me.panel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Name = "frmOpRegistroOperacion"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Opciones de Confirmación de Operación"
    CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.panel.ResumeLayout(False)
    Me.panel.PerformLayout()
    Me.MenuBar.ResumeLayout(False)
    Me.MenuBar.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents panel As ComponentFactory.Krypton.Toolkit.KryptonPanel
  Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

  Public Sub New()

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
  Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
  Friend WithEvents rbtnGenerarNuevo As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
  Friend WithEvents rbtnReutilizar As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
End Class
