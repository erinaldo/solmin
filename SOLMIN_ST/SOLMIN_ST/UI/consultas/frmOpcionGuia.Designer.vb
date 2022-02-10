<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpcionGuia
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
        Me.components = New System.ComponentModel.Container()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.rbtnEliminar = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.Separador = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuBar = New System.Windows.Forms.ToolStrip()
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton()
        Me.panelOpcion = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.groupElegir = New ComponentFactory.Krypton.Toolkit.KryptonGroup()
        Me.btnCerrar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.rbtnAnular = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.MenuBar.SuspendLayout()
        CType(Me.panelOpcion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelOpcion.SuspendLayout()
        CType(Me.groupElegir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupElegir.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupElegir.Panel.SuspendLayout()
        Me.groupElegir.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'rbtnEliminar
        '
        Me.rbtnEliminar.Cursor = System.Windows.Forms.Cursors.Default
        Me.rbtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnEliminar.Location = New System.Drawing.Point(30, 47)
        Me.rbtnEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtnEliminar.Name = "rbtnEliminar"
        Me.rbtnEliminar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.rbtnEliminar.Size = New System.Drawing.Size(206, 24)
        Me.rbtnEliminar.TabIndex = 1
        Me.rbtnEliminar.TabStop = False
        Me.rbtnEliminar.Tag = ""
        Me.rbtnEliminar.Text = "Eliminar Guía Transportista"
        Me.rbtnEliminar.Values.ExtraText = ""
        Me.rbtnEliminar.Values.Image = Nothing
        Me.rbtnEliminar.Values.Text = "Eliminar Guía Transportista"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 24)
        Me.btnCancelar.Text = "Cancelar"
        '
        'Separador
        '
        Me.Separador.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Separador.Name = "Separador"
        Me.Separador.Size = New System.Drawing.Size(6, 27)
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.Separador, Me.btnAceptar})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(336, 27)
        Me.MenuBar.TabIndex = 5
        '
        'btnAceptar
        '
        Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAceptar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(85, 24)
        Me.btnAceptar.Text = "Aceptar"
        '
        'panelOpcion
        '
        Me.panelOpcion.Controls.Add(Me.groupElegir)
        Me.panelOpcion.Controls.Add(Me.MenuBar)
        Me.panelOpcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelOpcion.Location = New System.Drawing.Point(0, 0)
        Me.panelOpcion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelOpcion.Name = "panelOpcion"
        Me.panelOpcion.Size = New System.Drawing.Size(336, 153)
        Me.panelOpcion.StateCommon.Color1 = System.Drawing.Color.White
        Me.panelOpcion.TabIndex = 1
        '
        'groupElegir
        '
        Me.groupElegir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupElegir.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonStandalone
        Me.groupElegir.Location = New System.Drawing.Point(0, 27)
        Me.groupElegir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupElegir.Name = "groupElegir"
        Me.groupElegir.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        '
        'groupElegir.Panel
        '
        Me.groupElegir.Panel.Controls.Add(Me.btnCerrar)
        Me.groupElegir.Panel.Controls.Add(Me.rbtnEliminar)
        Me.groupElegir.Panel.Controls.Add(Me.rbtnAnular)
        Me.groupElegir.Size = New System.Drawing.Size(336, 126)
        Me.groupElegir.TabIndex = 426
        '
        'btnCerrar
        '
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Location = New System.Drawing.Point(332, -36)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(11, 31)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "."
        Me.btnCerrar.Values.ExtraText = ""
        Me.btnCerrar.Values.Image = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCerrar.Values.Text = "."
        '
        'rbtnAnular
        '
        Me.rbtnAnular.Checked = True
        Me.rbtnAnular.Cursor = System.Windows.Forms.Cursors.Default
        Me.rbtnAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnAnular.Location = New System.Drawing.Point(30, 15)
        Me.rbtnAnular.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtnAnular.Name = "rbtnAnular"
        Me.rbtnAnular.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.rbtnAnular.Size = New System.Drawing.Size(196, 24)
        Me.rbtnAnular.TabIndex = 0
        Me.rbtnAnular.TabStop = False
        Me.rbtnAnular.Tag = ""
        Me.rbtnAnular.Text = "Anular Guía Transportista"
        Me.rbtnAnular.Values.ExtraText = ""
        Me.rbtnAnular.Values.Image = Nothing
        Me.rbtnAnular.Values.Text = "Anular Guía Transportista"
        '
        'frmOpcionGuia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(336, 153)
        Me.Controls.Add(Me.panelOpcion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximumSize = New System.Drawing.Size(354, 200)
        Me.MinimumSize = New System.Drawing.Size(354, 200)
        Me.Name = "frmOpcionGuia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opción Guía Transportista"
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        CType(Me.panelOpcion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelOpcion.ResumeLayout(False)
        Me.panelOpcion.PerformLayout()
        CType(Me.groupElegir.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupElegir.Panel.ResumeLayout(False)
        Me.groupElegir.Panel.PerformLayout()
        CType(Me.groupElegir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupElegir.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
  Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
  End Sub
  Friend WithEvents rbtnEliminar As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
  Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
  Friend WithEvents Separador As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
  Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
  Friend WithEvents panelOpcion As ComponentFactory.Krypton.Toolkit.KryptonPanel
  Friend WithEvents groupElegir As ComponentFactory.Krypton.Toolkit.KryptonGroup
  Friend WithEvents rbtnAnular As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
  Friend WithEvents btnCerrar As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
