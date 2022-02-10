<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpRptValeCombustible
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
    Me.Panel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.ctbConductor = New Ransa.Controls.Transportista.ucConductor_TxtF01
    Me.ctbTracto = New Ransa.Controls.Transportista.ucTracto_TxtF01
    Me.ctbTransportista_1 = New Ransa.Controls.Transportista.ucTransportista_TxtF01
    Me.chkTerceros = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Me.chkPropios = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Me.MenuBar = New System.Windows.Forms.ToolStrip
    Me.btnCancelar = New System.Windows.Forms.ToolStripButton
    Me.Separator1 = New System.Windows.Forms.ToolStripSeparator
    Me.btnAceptar = New System.Windows.Forms.ToolStripButton
    Me.rbtnTodos = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Me.rbtnConductor = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Me.gpbTipoFiltro = New System.Windows.Forms.GroupBox
    Me.rbtAsignados = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Me.rbtLiquidado = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Me.rbtPendiente = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Me.rbtTodos = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.dtpLimiteFinal = New System.Windows.Forms.DateTimePicker
    Me.dtpLimiteInicial = New System.Windows.Forms.DateTimePicker
    Me.rbtnTracto = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Me.rbtnTransportista = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    CType(Me.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel.SuspendLayout()
    Me.MenuBar.SuspendLayout()
    Me.gpbTipoFiltro.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel
    '
    Me.Panel.Controls.Add(Me.ctbConductor)
    Me.Panel.Controls.Add(Me.ctbTracto)
    Me.Panel.Controls.Add(Me.ctbTransportista_1)
    Me.Panel.Controls.Add(Me.chkTerceros)
    Me.Panel.Controls.Add(Me.chkPropios)
    Me.Panel.Controls.Add(Me.MenuBar)
    Me.Panel.Controls.Add(Me.rbtnTodos)
    Me.Panel.Controls.Add(Me.rbtnConductor)
    Me.Panel.Controls.Add(Me.gpbTipoFiltro)
    Me.Panel.Controls.Add(Me.rbtnTracto)
    Me.Panel.Controls.Add(Me.rbtnTransportista)
    Me.Panel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel.Location = New System.Drawing.Point(0, 0)
    Me.Panel.Name = "Panel"
    Me.Panel.Size = New System.Drawing.Size(439, 236)
    Me.Panel.StateCommon.Color1 = System.Drawing.SystemColors.ActiveCaptionText
    Me.Panel.TabIndex = 0
    '
    'ctbConductor
    '
    Me.ctbConductor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.ctbConductor.BackColor = System.Drawing.Color.Transparent
    Me.ctbConductor.Enabled = False
    Me.ctbConductor.Location = New System.Drawing.Point(123, 122)
    Me.ctbConductor.Name = "ctbConductor"
    Me.ctbConductor.pRequerido = False
    Me.ctbConductor.Size = New System.Drawing.Size(302, 21)
    Me.ctbConductor.TabIndex = 149
    '
    'ctbTracto
    '
    Me.ctbTracto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.ctbTracto.BackColor = System.Drawing.Color.Transparent
    Me.ctbTracto.Enabled = False
    Me.ctbTracto.Location = New System.Drawing.Point(123, 93)
    Me.ctbTracto.Name = "ctbTracto"
    Me.ctbTracto.pNroRegPorPaginas = 0
    Me.ctbTracto.pRequerido = False
    Me.ctbTracto.Size = New System.Drawing.Size(302, 21)
    Me.ctbTracto.TabIndex = 148
    '
    'ctbTransportista_1
    '
    Me.ctbTransportista_1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.ctbTransportista_1.BackColor = System.Drawing.Color.Transparent
    Me.ctbTransportista_1.Enabled = False
    Me.ctbTransportista_1.Location = New System.Drawing.Point(123, 62)
    Me.ctbTransportista_1.Name = "ctbTransportista_1"
    Me.ctbTransportista_1.pNroRegPorPaginas = 0
    Me.ctbTransportista_1.pRequerido = False
    Me.ctbTransportista_1.Size = New System.Drawing.Size(302, 21)
    Me.ctbTransportista_1.TabIndex = 147
    '
    'chkTerceros
    '
    Me.chkTerceros.Checked = False
    Me.chkTerceros.CheckState = System.Windows.Forms.CheckState.Unchecked
    Me.chkTerceros.Location = New System.Drawing.Point(192, 35)
    Me.chkTerceros.Name = "chkTerceros"
    Me.chkTerceros.Size = New System.Drawing.Size(66, 19)
    Me.chkTerceros.TabIndex = 145
    Me.chkTerceros.Text = "Terceros"
    Me.chkTerceros.Values.ExtraText = ""
    Me.chkTerceros.Values.Image = Nothing
    Me.chkTerceros.Values.Text = "Terceros"
    '
    'chkPropios
    '
    Me.chkPropios.Checked = False
    Me.chkPropios.CheckState = System.Windows.Forms.CheckState.Unchecked
    Me.chkPropios.Location = New System.Drawing.Point(123, 35)
    Me.chkPropios.Name = "chkPropios"
    Me.chkPropios.Size = New System.Drawing.Size(61, 19)
    Me.chkPropios.TabIndex = 144
    Me.chkPropios.Text = "Propios"
    Me.chkPropios.Values.ExtraText = ""
    Me.chkPropios.Values.Image = Nothing
    Me.chkPropios.Values.Text = "Propios"
    '
    'MenuBar
    '
    Me.MenuBar.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
    Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.Separator1, Me.btnAceptar})
    Me.MenuBar.Location = New System.Drawing.Point(0, 0)
    Me.MenuBar.Name = "MenuBar"
    Me.MenuBar.Size = New System.Drawing.Size(439, 25)
    Me.MenuBar.TabIndex = 143
    Me.MenuBar.Text = "ToolStrip1"
    '
    'btnCancelar
    '
    Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
    Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(72, 22)
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
    Me.btnAceptar.Size = New System.Drawing.Size(65, 22)
    Me.btnAceptar.Text = "Aceptar"
    '
    'rbtnTodos
    '
    Me.rbtnTodos.Checked = True
    Me.rbtnTodos.Location = New System.Drawing.Point(8, 35)
    Me.rbtnTodos.Name = "rbtnTodos"
    Me.rbtnTodos.Size = New System.Drawing.Size(53, 19)
    Me.rbtnTodos.TabIndex = 142
    Me.rbtnTodos.Tag = "1"
    Me.rbtnTodos.Text = "Todos"
    Me.rbtnTodos.Values.ExtraText = ""
    Me.rbtnTodos.Values.Image = Nothing
    Me.rbtnTodos.Values.Text = "Todos"
    '
    'rbtnConductor
    '
    Me.rbtnConductor.Location = New System.Drawing.Point(8, 127)
    Me.rbtnConductor.Name = "rbtnConductor"
    Me.rbtnConductor.Size = New System.Drawing.Size(75, 19)
    Me.rbtnConductor.TabIndex = 140
    Me.rbtnConductor.Tag = "2"
    Me.rbtnConductor.Text = "Conductor"
    Me.rbtnConductor.Values.ExtraText = ""
    Me.rbtnConductor.Values.Image = Nothing
    Me.rbtnConductor.Values.Text = "Conductor"
    '
    'gpbTipoFiltro
    '
    Me.gpbTipoFiltro.BackColor = System.Drawing.SystemColors.ActiveCaptionText
    Me.gpbTipoFiltro.Controls.Add(Me.rbtAsignados)
    Me.gpbTipoFiltro.Controls.Add(Me.rbtLiquidado)
    Me.gpbTipoFiltro.Controls.Add(Me.rbtPendiente)
    Me.gpbTipoFiltro.Controls.Add(Me.rbtTodos)
    Me.gpbTipoFiltro.Controls.Add(Me.KryptonLabel2)
    Me.gpbTipoFiltro.Controls.Add(Me.KryptonLabel1)
    Me.gpbTipoFiltro.Controls.Add(Me.dtpLimiteFinal)
    Me.gpbTipoFiltro.Controls.Add(Me.dtpLimiteInicial)
    Me.gpbTipoFiltro.Location = New System.Drawing.Point(123, 153)
    Me.gpbTipoFiltro.Name = "gpbTipoFiltro"
    Me.gpbTipoFiltro.Size = New System.Drawing.Size(302, 74)
    Me.gpbTipoFiltro.TabIndex = 139
    Me.gpbTipoFiltro.TabStop = False
    Me.gpbTipoFiltro.Text = " Fecha"
    '
    'rbtAsignados
    '
    Me.rbtAsignados.Location = New System.Drawing.Point(148, 19)
    Me.rbtAsignados.Name = "rbtAsignados"
    Me.rbtAsignados.Size = New System.Drawing.Size(69, 19)
    Me.rbtAsignados.TabIndex = 137
    Me.rbtAsignados.Text = "Asignado"
    Me.rbtAsignados.Values.ExtraText = ""
    Me.rbtAsignados.Values.Image = Nothing
    Me.rbtAsignados.Values.Text = "Asignado"
    '
    'rbtLiquidado
    '
    Me.rbtLiquidado.Location = New System.Drawing.Point(223, 19)
    Me.rbtLiquidado.Name = "rbtLiquidado"
    Me.rbtLiquidado.Size = New System.Drawing.Size(72, 19)
    Me.rbtLiquidado.TabIndex = 137
    Me.rbtLiquidado.Text = "Liquidado"
    Me.rbtLiquidado.Values.ExtraText = ""
    Me.rbtLiquidado.Values.Image = Nothing
    Me.rbtLiquidado.Values.Text = "Liquidado"
    '
    'rbtPendiente
    '
    Me.rbtPendiente.Location = New System.Drawing.Point(69, 19)
    Me.rbtPendiente.Name = "rbtPendiente"
    Me.rbtPendiente.Size = New System.Drawing.Size(72, 19)
    Me.rbtPendiente.TabIndex = 137
    Me.rbtPendiente.Text = "Pendiente"
    Me.rbtPendiente.Values.ExtraText = ""
    Me.rbtPendiente.Values.Image = Nothing
    Me.rbtPendiente.Values.Text = "Pendiente"
    '
    'rbtTodos
    '
    Me.rbtTodos.Checked = True
    Me.rbtTodos.Location = New System.Drawing.Point(16, 19)
    Me.rbtTodos.Name = "rbtTodos"
    Me.rbtTodos.Size = New System.Drawing.Size(53, 19)
    Me.rbtTodos.TabIndex = 136
    Me.rbtTodos.Text = "Todos"
    Me.rbtTodos.Values.ExtraText = ""
    Me.rbtTodos.Values.Image = Nothing
    Me.rbtTodos.Values.Text = "Todos"
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(158, 49)
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
    Me.KryptonLabel1.Location = New System.Drawing.Point(13, 49)
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
    Me.dtpLimiteFinal.Location = New System.Drawing.Point(204, 47)
    Me.dtpLimiteFinal.Name = "dtpLimiteFinal"
    Me.dtpLimiteFinal.Size = New System.Drawing.Size(90, 20)
    Me.dtpLimiteFinal.TabIndex = 133
    '
    'dtpLimiteInicial
    '
    Me.dtpLimiteInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpLimiteInicial.Location = New System.Drawing.Point(62, 47)
    Me.dtpLimiteInicial.Name = "dtpLimiteInicial"
    Me.dtpLimiteInicial.Size = New System.Drawing.Size(90, 20)
    Me.dtpLimiteInicial.TabIndex = 132
    '
    'rbtnTracto
    '
    Me.rbtnTracto.Location = New System.Drawing.Point(8, 95)
    Me.rbtnTracto.Name = "rbtnTracto"
    Me.rbtnTracto.Size = New System.Drawing.Size(54, 19)
    Me.rbtnTracto.TabIndex = 136
    Me.rbtnTracto.Tag = "3"
    Me.rbtnTracto.Text = "Tracto"
    Me.rbtnTracto.Values.ExtraText = ""
    Me.rbtnTracto.Values.Image = Nothing
    Me.rbtnTracto.Values.Text = "Tracto"
    '
    'rbtnTransportista
    '
    Me.rbtnTransportista.Location = New System.Drawing.Point(8, 63)
    Me.rbtnTransportista.Name = "rbtnTransportista"
    Me.rbtnTransportista.Size = New System.Drawing.Size(108, 19)
    Me.rbtnTransportista.TabIndex = 135
    Me.rbtnTransportista.Tag = "1"
    Me.rbtnTransportista.Text = "Cia. Transportista"
    Me.rbtnTransportista.Values.ExtraText = ""
    Me.rbtnTransportista.Values.Image = Nothing
    Me.rbtnTransportista.Values.Text = "Cia. Transportista"
    '
    'frmOpRptValeCombustible
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(439, 236)
    Me.ControlBox = False
    Me.Controls.Add(Me.Panel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "frmOpRptValeCombustible"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Opciones de Impresión"
    CType(Me.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel.ResumeLayout(False)
    Me.Panel.PerformLayout()
    Me.MenuBar.ResumeLayout(False)
    Me.MenuBar.PerformLayout()
    Me.gpbTipoFiltro.ResumeLayout(False)
    Me.gpbTipoFiltro.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
    Friend WithEvents Panel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents gpbTipoFiltro As System.Windows.Forms.GroupBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpLimiteFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpLimiteInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbtnTracto As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtnTransportista As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtnTodos As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtnConductor As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Separator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents chkTerceros As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkPropios As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents ctbTransportista_1 As Ransa.Controls.Transportista.ucTransportista_TxtF01
    Friend WithEvents ctbConductor As Ransa.Controls.Transportista.ucConductor_TxtF01
    Friend WithEvents ctbTracto As Ransa.Controls.Transportista.ucTracto_TxtF01
    Friend WithEvents rbtAsignados As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtLiquidado As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtPendiente As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtTodos As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
End Class
