<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpRptLiquidacionGasto
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
        Me.ctbVehiculo = New Ransa.Controls.Transportista.ucTracto_TxtF01
        Me.ctbConductor = New Ransa.Controls.Transportista.ucConductor_TxtF01
        Me.rbtnTodos = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.MenuBar = New System.Windows.Forms.ToolStrip
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.Separator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton
        Me.txtClienteFiltro = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpLimiteFinal = New System.Windows.Forms.DateTimePicker
        Me.dtpLimiteInicial = New System.Windows.Forms.DateTimePicker
        Me.rbtnTracto = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.rbtnConductor = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.rbtnCliente = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.btnCerrar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel
        '
        Me.panel.Controls.Add(Me.ctbVehiculo)
        Me.panel.Controls.Add(Me.ctbConductor)
        Me.panel.Controls.Add(Me.rbtnTodos)
        Me.panel.Controls.Add(Me.MenuBar)
        Me.panel.Controls.Add(Me.txtClienteFiltro)
        Me.panel.Controls.Add(Me.KryptonLabel2)
        Me.panel.Controls.Add(Me.KryptonLabel1)
        Me.panel.Controls.Add(Me.dtpLimiteFinal)
        Me.panel.Controls.Add(Me.dtpLimiteInicial)
        Me.panel.Controls.Add(Me.rbtnTracto)
        Me.panel.Controls.Add(Me.rbtnConductor)
        Me.panel.Controls.Add(Me.rbtnCliente)
        Me.panel.Controls.Add(Me.btnCerrar)
        Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(384, 186)
        Me.panel.StateCommon.Color1 = System.Drawing.SystemColors.Control
        Me.panel.TabIndex = 0
        '
        'ctbVehiculo
        '
        Me.ctbVehiculo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ctbVehiculo.BackColor = System.Drawing.Color.Transparent
        Me.ctbVehiculo.Enabled = False
        Me.ctbVehiculo.Location = New System.Drawing.Point(88, 109)
        Me.ctbVehiculo.Name = "ctbVehiculo"
        Me.ctbVehiculo.pNroRegPorPaginas = 0
        Me.ctbVehiculo.pRequerido = False
        Me.ctbVehiculo.Size = New System.Drawing.Size(279, 22)
        Me.ctbVehiculo.TabIndex = 130
        '
        'ctbConductor
        '
        Me.ctbConductor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ctbConductor.BackColor = System.Drawing.Color.Transparent
        Me.ctbConductor.Enabled = False
        Me.ctbConductor.Location = New System.Drawing.Point(88, 84)
        Me.ctbConductor.Name = "ctbConductor"
        Me.ctbConductor.pRequerido = False
        Me.ctbConductor.Size = New System.Drawing.Size(279, 22)
        Me.ctbConductor.TabIndex = 129
        '
        'rbtnTodos
        '
        Me.rbtnTodos.Checked = True
        Me.rbtnTodos.Location = New System.Drawing.Point(12, 32)
        Me.rbtnTodos.Name = "rbtnTodos"
        Me.rbtnTodos.Size = New System.Drawing.Size(56, 20)
        Me.rbtnTodos.TabIndex = 128
        Me.rbtnTodos.Tag = "1"
        Me.rbtnTodos.Text = "Todos"
        Me.rbtnTodos.Values.ExtraText = ""
        Me.rbtnTodos.Values.Image = Nothing
        Me.rbtnTodos.Values.Text = "Todos"
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.Separator1, Me.btnAceptar})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(384, 25)
        Me.MenuBar.TabIndex = 126
        Me.MenuBar.Text = "ToolStrip1"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(76, 22)
        Me.btnCancelar.Text = " Cancelar"
        '
        'Separator1
        '
        Me.Separator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Separator1.Name = "Separator1"
        Me.Separator1.Size = New System.Drawing.Size(6, 25)
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
        'txtClienteFiltro
        '
        Me.txtClienteFiltro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtClienteFiltro.BackColor = System.Drawing.Color.Transparent
        Me.txtClienteFiltro.CCMPN = "EZ"
        Me.txtClienteFiltro.Location = New System.Drawing.Point(88, 59)
        Me.txtClienteFiltro.Name = "txtClienteFiltro"
        Me.txtClienteFiltro.pAccesoPorUsuario = False
        Me.txtClienteFiltro.pRequerido = False
        Me.txtClienteFiltro.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtClienteFiltro.Size = New System.Drawing.Size(280, 22)
        Me.txtClienteFiltro.TabIndex = 81
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(231, 154)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(41, 20)
        Me.KryptonLabel2.TabIndex = 78
        Me.KryptonLabel2.Text = "Hasta"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Hasta"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(86, 154)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(45, 20)
        Me.KryptonLabel1.TabIndex = 77
        Me.KryptonLabel1.Text = "Desde"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Desde"
        '
        'dtpLimiteFinal
        '
        Me.dtpLimiteFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpLimiteFinal.Location = New System.Drawing.Point(277, 152)
        Me.dtpLimiteFinal.Name = "dtpLimiteFinal"
        Me.dtpLimiteFinal.Size = New System.Drawing.Size(90, 20)
        Me.dtpLimiteFinal.TabIndex = 76
        '
        'dtpLimiteInicial
        '
        Me.dtpLimiteInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpLimiteInicial.Location = New System.Drawing.Point(135, 152)
        Me.dtpLimiteInicial.Name = "dtpLimiteInicial"
        Me.dtpLimiteInicial.Size = New System.Drawing.Size(90, 20)
        Me.dtpLimiteInicial.TabIndex = 75
        '
        'rbtnTracto
        '
        Me.rbtnTracto.Location = New System.Drawing.Point(12, 119)
        Me.rbtnTracto.Name = "rbtnTracto"
        Me.rbtnTracto.Size = New System.Drawing.Size(57, 20)
        Me.rbtnTracto.TabIndex = 74
        Me.rbtnTracto.Tag = "3"
        Me.rbtnTracto.Text = "Tracto"
        Me.rbtnTracto.Values.ExtraText = ""
        Me.rbtnTracto.Values.Image = Nothing
        Me.rbtnTracto.Values.Text = "Tracto"
        '
        'rbtnConductor
        '
        Me.rbtnConductor.Location = New System.Drawing.Point(12, 89)
        Me.rbtnConductor.Name = "rbtnConductor"
        Me.rbtnConductor.Size = New System.Drawing.Size(80, 20)
        Me.rbtnConductor.TabIndex = 73
        Me.rbtnConductor.Tag = "2"
        Me.rbtnConductor.Text = "Conductor"
        Me.rbtnConductor.Values.ExtraText = ""
        Me.rbtnConductor.Values.Image = Nothing
        Me.rbtnConductor.Values.Text = "Conductor"
        '
        'rbtnCliente
        '
        Me.rbtnCliente.Location = New System.Drawing.Point(12, 60)
        Me.rbtnCliente.Name = "rbtnCliente"
        Me.rbtnCliente.Size = New System.Drawing.Size(60, 20)
        Me.rbtnCliente.TabIndex = 72
        Me.rbtnCliente.Tag = "1"
        Me.rbtnCliente.Text = "Cliente"
        Me.rbtnCliente.Values.ExtraText = ""
        Me.rbtnCliente.Values.Image = Nothing
        Me.rbtnCliente.Values.Text = "Cliente"
        '
        'btnCerrar
        '
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Location = New System.Drawing.Point(375, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(8, 25)
        Me.btnCerrar.TabIndex = 127
        Me.btnCerrar.Text = "."
        Me.btnCerrar.Values.ExtraText = ""
        Me.btnCerrar.Values.Image = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCerrar.Values.Text = "."
        '
        'frmOpRptLiquidacionGasto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(384, 186)
        Me.ControlBox = False
        Me.Controls.Add(Me.panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmOpRptLiquidacionGasto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opción Liquidacion Gasto"
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
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpLimiteFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpLimiteInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbtnTracto As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtnConductor As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtnCliente As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents txtClienteFiltro As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Separator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCerrar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents rbtnTodos As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents ctbConductor As Ransa.Controls.Transportista.ucConductor_TxtF01
    Friend WithEvents ctbVehiculo As Ransa.Controls.Transportista.ucTracto_TxtF01
End Class
