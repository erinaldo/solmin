<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpRptCombustible
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
    Me.ctbVehiculo = New Ransa.Controls.Transportista.ucTractoTransportista_TxtF01
    Me.gpbTipoFiltro = New System.Windows.Forms.GroupBox
    Me.rbtFechaRendimiento = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Me.rbtFechaLiquidacion = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Me.rbtFechaAsignacion = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.dtpLimiteFinal = New System.Windows.Forms.DateTimePicker
    Me.dtpLimiteInicial = New System.Windows.Forms.DateTimePicker
    Me.txtClienteFiltro = New Ransa.Controls.Cliente.ucCliente_TxtF01
    Me.rbtnTracto = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Me.rbtnCliente = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Me.MenuBar = New System.Windows.Forms.ToolStrip
    Me.btnCancelar = New System.Windows.Forms.ToolStripButton
    Me.Separator1 = New System.Windows.Forms.ToolStripSeparator
    Me.btnAceptar = New System.Windows.Forms.ToolStripButton
    Me.btnCerrar = New ComponentFactory.Krypton.Toolkit.KryptonButton
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.panel.SuspendLayout()
    Me.gpbTipoFiltro.SuspendLayout()
    Me.MenuBar.SuspendLayout()
    Me.SuspendLayout()
    '
    'panel
    '
    Me.panel.Controls.Add(Me.ctbVehiculo)
    Me.panel.Controls.Add(Me.gpbTipoFiltro)
    Me.panel.Controls.Add(Me.txtClienteFiltro)
    Me.panel.Controls.Add(Me.rbtnTracto)
    Me.panel.Controls.Add(Me.rbtnCliente)
    Me.panel.Controls.Add(Me.MenuBar)
    Me.panel.Controls.Add(Me.btnCerrar)
    Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.panel.Location = New System.Drawing.Point(0, 0)
    Me.panel.Name = "panel"
    Me.panel.Size = New System.Drawing.Size(393, 176)
    Me.panel.StateCommon.Color1 = System.Drawing.Color.White
    Me.panel.TabIndex = 0
    '
    'ctbVehiculo
    '
    Me.ctbVehiculo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.ctbVehiculo.BackColor = System.Drawing.Color.Transparent
    Me.ctbVehiculo.Location = New System.Drawing.Point(82, 65)
    Me.ctbVehiculo.Name = "ctbVehiculo"
    Me.ctbVehiculo.pRequerido = False
    Me.ctbVehiculo.Size = New System.Drawing.Size(302, 21)
    Me.ctbVehiculo.TabIndex = 135
    '
    'gpbTipoFiltro
    '
    Me.gpbTipoFiltro.BackColor = System.Drawing.SystemColors.ActiveCaptionText
    Me.gpbTipoFiltro.Controls.Add(Me.rbtFechaRendimiento)
    Me.gpbTipoFiltro.Controls.Add(Me.rbtFechaLiquidacion)
    Me.gpbTipoFiltro.Controls.Add(Me.rbtFechaAsignacion)
    Me.gpbTipoFiltro.Controls.Add(Me.KryptonLabel2)
    Me.gpbTipoFiltro.Controls.Add(Me.KryptonLabel1)
    Me.gpbTipoFiltro.Controls.Add(Me.dtpLimiteFinal)
    Me.gpbTipoFiltro.Controls.Add(Me.dtpLimiteInicial)
    Me.gpbTipoFiltro.Location = New System.Drawing.Point(82, 96)
    Me.gpbTipoFiltro.Name = "gpbTipoFiltro"
    Me.gpbTipoFiltro.Size = New System.Drawing.Size(302, 72)
    Me.gpbTipoFiltro.TabIndex = 134
    Me.gpbTipoFiltro.TabStop = False
    Me.gpbTipoFiltro.Text = "Filtro Fecha"
    '
    'rbtFechaRendimiento
    '
    Me.rbtFechaRendimiento.Location = New System.Drawing.Point(209, 19)
    Me.rbtFechaRendimiento.Name = "rbtFechaRendimiento"
    Me.rbtFechaRendimiento.Size = New System.Drawing.Size(86, 19)
    Me.rbtFechaRendimiento.TabIndex = 138
    Me.rbtFechaRendimiento.Text = "Rendimiento"
    Me.rbtFechaRendimiento.Values.ExtraText = ""
    Me.rbtFechaRendimiento.Values.Image = Nothing
    Me.rbtFechaRendimiento.Values.Text = "Rendimiento"
    '
    'rbtFechaLiquidacion
    '
    Me.rbtFechaLiquidacion.Location = New System.Drawing.Point(129, 19)
    Me.rbtFechaLiquidacion.Name = "rbtFechaLiquidacion"
    Me.rbtFechaLiquidacion.Size = New System.Drawing.Size(80, 19)
    Me.rbtFechaLiquidacion.TabIndex = 137
    Me.rbtFechaLiquidacion.Text = "Liquidación"
    Me.rbtFechaLiquidacion.Values.ExtraText = ""
    Me.rbtFechaLiquidacion.Values.Image = Nothing
    Me.rbtFechaLiquidacion.Values.Text = "Liquidación"
    '
    'rbtFechaAsignacion
    '
    Me.rbtFechaAsignacion.Checked = True
    Me.rbtFechaAsignacion.Location = New System.Drawing.Point(10, 19)
    Me.rbtFechaAsignacion.Name = "rbtFechaAsignacion"
    Me.rbtFechaAsignacion.Size = New System.Drawing.Size(118, 19)
    Me.rbtFechaAsignacion.TabIndex = 136
    Me.rbtFechaAsignacion.Text = "Carga Combustible"
    Me.rbtFechaAsignacion.Values.ExtraText = ""
    Me.rbtFechaAsignacion.Values.Image = Nothing
    Me.rbtFechaAsignacion.Values.Text = "Carga Combustible"
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(150, 44)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(38, 19)
    Me.KryptonLabel2.TabIndex = 135
    Me.KryptonLabel2.Text = "Hasta"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "Hasta"
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(13, 44)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(41, 19)
    Me.KryptonLabel1.TabIndex = 134
    Me.KryptonLabel1.Text = "Desde"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Desde"
    '
    'dtpLimiteFinal
    '
    Me.dtpLimiteFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpLimiteFinal.Location = New System.Drawing.Point(192, 42)
    Me.dtpLimiteFinal.Name = "dtpLimiteFinal"
    Me.dtpLimiteFinal.Size = New System.Drawing.Size(90, 20)
    Me.dtpLimiteFinal.TabIndex = 133
    '
    'dtpLimiteInicial
    '
    Me.dtpLimiteInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpLimiteInicial.Location = New System.Drawing.Point(58, 42)
    Me.dtpLimiteInicial.Name = "dtpLimiteInicial"
    Me.dtpLimiteInicial.Size = New System.Drawing.Size(90, 20)
    Me.dtpLimiteInicial.TabIndex = 132
    '
    'txtClienteFiltro
    '
    Me.txtClienteFiltro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.txtClienteFiltro.BackColor = System.Drawing.Color.Transparent
    Me.txtClienteFiltro.CCMPN = "EZ"
    Me.txtClienteFiltro.Enabled = False
    Me.txtClienteFiltro.Location = New System.Drawing.Point(82, 36)
    Me.txtClienteFiltro.Name = "txtClienteFiltro"
    Me.txtClienteFiltro.pAccesoPorUsuario = False
    Me.txtClienteFiltro.pRequerido = False
    Me.txtClienteFiltro.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
    Me.txtClienteFiltro.Size = New System.Drawing.Size(302, 21)
    Me.txtClienteFiltro.TabIndex = 132
    '
    'rbtnTracto
    '
    Me.rbtnTracto.Checked = True
    Me.rbtnTracto.Location = New System.Drawing.Point(6, 67)
    Me.rbtnTracto.Name = "rbtnTracto"
    Me.rbtnTracto.Size = New System.Drawing.Size(55, 19)
    Me.rbtnTracto.TabIndex = 127
    Me.rbtnTracto.Tag = "3"
    Me.rbtnTracto.Text = "Tracto"
    Me.rbtnTracto.Values.ExtraText = ""
    Me.rbtnTracto.Values.Image = Nothing
    Me.rbtnTracto.Values.Text = "Tracto"
    '
    'rbtnCliente
    '
    Me.rbtnCliente.Enabled = False
    Me.rbtnCliente.Location = New System.Drawing.Point(6, 37)
    Me.rbtnCliente.Name = "rbtnCliente"
    Me.rbtnCliente.Size = New System.Drawing.Size(57, 19)
    Me.rbtnCliente.TabIndex = 126
    Me.rbtnCliente.Tag = "1"
    Me.rbtnCliente.Text = "Cliente"
    Me.rbtnCliente.Values.ExtraText = ""
    Me.rbtnCliente.Values.Image = Nothing
    Me.rbtnCliente.Values.Text = "Cliente"
    '
    'MenuBar
    '
    Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.Separator1, Me.btnAceptar})
    Me.MenuBar.Location = New System.Drawing.Point(0, 0)
    Me.MenuBar.Name = "MenuBar"
    Me.MenuBar.Size = New System.Drawing.Size(393, 25)
    Me.MenuBar.TabIndex = 0
    Me.MenuBar.Text = "ToolStrip1"
    '
    'btnCancelar
    '
    Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
    Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(74, 22)
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
    Me.btnAceptar.Size = New System.Drawing.Size(66, 22)
    Me.btnAceptar.Text = "Aceptar"
    '
    'btnCerrar
    '
    Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCerrar.Location = New System.Drawing.Point(184, 0)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(8, 25)
    Me.btnCerrar.TabIndex = 3
    Me.btnCerrar.Text = "."
    Me.btnCerrar.Values.ExtraText = ""
    Me.btnCerrar.Values.Image = Nothing
    Me.btnCerrar.Values.ImageStates.ImageCheckedNormal = Nothing
    Me.btnCerrar.Values.ImageStates.ImageCheckedPressed = Nothing
    Me.btnCerrar.Values.ImageStates.ImageCheckedTracking = Nothing
    Me.btnCerrar.Values.Text = "."
    '
    'frmOpRptCombustible
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(393, 176)
    Me.ControlBox = False
    Me.Controls.Add(Me.panel)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "frmOpRptCombustible"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Opción Filtro"
    CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.panel.ResumeLayout(False)
    Me.panel.PerformLayout()
    Me.gpbTipoFiltro.ResumeLayout(False)
    Me.gpbTipoFiltro.PerformLayout()
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
  Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
  Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnCerrar As ComponentFactory.Krypton.Toolkit.KryptonButton
  Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
  Friend WithEvents Separator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtClienteFiltro As Ransa.Controls.Cliente.ucCliente_TxtF01
  Friend WithEvents rbtnTracto As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
  Friend WithEvents rbtnCliente As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
  Friend WithEvents gpbTipoFiltro As System.Windows.Forms.GroupBox
  Friend WithEvents rbtFechaLiquidacion As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
  Friend WithEvents rbtFechaAsignacion As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
  Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents dtpLimiteFinal As System.Windows.Forms.DateTimePicker
  Friend WithEvents dtpLimiteInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbtFechaRendimiento As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents ctbVehiculo As Ransa.Controls.Transportista.ucTractoTransportista_TxtF01
End Class
