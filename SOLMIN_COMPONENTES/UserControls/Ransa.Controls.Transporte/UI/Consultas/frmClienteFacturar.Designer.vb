<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClienteFacturar
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
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.MenuBar = New System.Windows.Forms.ToolStrip
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.Separador = New System.Windows.Forms.ToolStripSeparator
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.lblNIT = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.panelOpcion = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.groupElegir = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.cboPlanta = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.btnCerrar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.MenuBar.SuspendLayout()
        CType(Me.panelOpcion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelOpcion.SuspendLayout()
        CType(Me.groupElegir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupElegir.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupElegir.Panel.SuspendLayout()
        Me.groupElegir.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.Separador, Me.btnAceptar, Me.ToolStripLabel1})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(406, 25)
        Me.MenuBar.TabIndex = 5
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.Ransa.Controls.Transporte.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(73, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'Separador
        '
        Me.Separador.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Separador.Name = "Separador"
        Me.Separador.Size = New System.Drawing.Size(6, 25)
        '
        'btnAceptar
        '
        Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAceptar.Image = Global.Ransa.Controls.Transporte.My.Resources.Resources.button_ok1
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(68, 22)
        Me.btnAceptar.Text = "Aceptar"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(172, 22)
        Me.ToolStripLabel1.Text = " CAMBIAR CLIENTE FACTURAR"
        '
        'lblNIT
        '
        Me.lblNIT.Location = New System.Drawing.Point(4, 47)
        Me.lblNIT.Name = "lblNIT"
        Me.lblNIT.Size = New System.Drawing.Size(44, 20)
        Me.lblNIT.TabIndex = 15
        Me.lblNIT.Text = "Planta"
        Me.lblNIT.Values.ExtraText = ""
        Me.lblNIT.Values.Image = Nothing
        Me.lblNIT.Values.Text = "Planta"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(4, 13)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(48, 20)
        Me.lblCliente.TabIndex = 12
        Me.lblCliente.Text = "Cliente"
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente"
        '
        'panelOpcion
        '
        Me.panelOpcion.Controls.Add(Me.groupElegir)
        Me.panelOpcion.Controls.Add(Me.MenuBar)
        Me.panelOpcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelOpcion.Location = New System.Drawing.Point(0, 0)
        Me.panelOpcion.Name = "panelOpcion"
        Me.panelOpcion.Size = New System.Drawing.Size(406, 110)
        Me.panelOpcion.StateCommon.Color1 = System.Drawing.Color.White
        Me.panelOpcion.TabIndex = 3
        '
        'groupElegir
        '
        Me.groupElegir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupElegir.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonStandalone
        Me.groupElegir.Location = New System.Drawing.Point(0, 25)
        Me.groupElegir.Name = "groupElegir"
        Me.groupElegir.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        '
        'groupElegir.Panel
        '
        Me.groupElegir.Panel.Controls.Add(Me.cboPlanta)
        Me.groupElegir.Panel.Controls.Add(Me.txtCliente)
        Me.groupElegir.Panel.Controls.Add(Me.lblNIT)
        Me.groupElegir.Panel.Controls.Add(Me.lblCliente)
        Me.groupElegir.Panel.Controls.Add(Me.btnCerrar)
        Me.groupElegir.Size = New System.Drawing.Size(406, 85)
        Me.groupElegir.TabIndex = 426
        '
        'cboPlanta
        '
        Me.cboPlanta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPlanta.DropDownWidth = 232
        Me.cboPlanta.FormattingEnabled = False
        Me.cboPlanta.ItemHeight = 15
        Me.cboPlanta.Location = New System.Drawing.Point(56, 45)
        Me.cboPlanta.Name = "cboPlanta"
        Me.cboPlanta.Size = New System.Drawing.Size(336, 23)
        Me.cboPlanta.TabIndex = 104
        Me.cboPlanta.TabStop = False
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.CCMPN = "EZ"
        Me.txtCliente.Location = New System.Drawing.Point(56, 12)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = False
        Me.txtCliente.pRequerido = False
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(336, 22)
        Me.txtCliente.TabIndex = 103
        '
        'btnCerrar
        '
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Location = New System.Drawing.Point(40, -32)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(8, 25)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "."
        Me.btnCerrar.Values.ExtraText = ""
        Me.btnCerrar.Values.Image = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCerrar.Values.Text = "."
        '
        'frmClienteFacturar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 110)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelOpcion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmClienteFacturar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
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
  Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
  Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
  Friend WithEvents Separador As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents lblNIT As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents panelOpcion As ComponentFactory.Krypton.Toolkit.KryptonPanel
  Friend WithEvents groupElegir As ComponentFactory.Krypton.Toolkit.KryptonGroup
  Friend WithEvents btnCerrar As ComponentFactory.Krypton.Toolkit.KryptonButton
  Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
  Friend WithEvents cboPlanta As ComponentFactory.Krypton.Toolkit.KryptonComboBox
End Class
