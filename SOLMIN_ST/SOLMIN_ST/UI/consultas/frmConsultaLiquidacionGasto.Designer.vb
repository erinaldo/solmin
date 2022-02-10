<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaLiquidacionGasto
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
        Me.HeaderGroupTabs = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.ControlVisorLiquidacion = New SOLMIN_ST.Control_Visor_Reporte
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.MenuBar = New System.Windows.Forms.ToolStrip
        Me.btnProcesarReporte = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnPorDetalle = New System.Windows.Forms.ToolStripButton
        Me.HeaderGroupFiltro = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.SuspendLayout()
        CType(Me.HeaderGroupTabs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderGroupTabs.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderGroupTabs.Panel.SuspendLayout()
        Me.HeaderGroupTabs.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        CType(Me.HeaderGroupFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderGroupFiltro.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderGroupFiltro.Panel.SuspendLayout()
        Me.HeaderGroupFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel
        '
        Me.panel.Controls.Add(Me.HeaderGroupTabs)
        Me.panel.Controls.Add(Me.HeaderGroupFiltro)
        Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(1019, 619)
        Me.panel.StateCommon.Color1 = System.Drawing.SystemColors.ActiveCaptionText
        Me.panel.TabIndex = 0
        '
        'HeaderGroupTabs
        '
        Me.HeaderGroupTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderGroupTabs.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HeaderGroupTabs.Location = New System.Drawing.Point(0, 70)
        Me.HeaderGroupTabs.Name = "HeaderGroupTabs"
        '
        'HeaderGroupTabs.Panel
        '
        Me.HeaderGroupTabs.Panel.Controls.Add(Me.ControlVisorLiquidacion)
        Me.HeaderGroupTabs.Panel.Controls.Add(Me.Panel2)
        Me.HeaderGroupTabs.Size = New System.Drawing.Size(1019, 549)
        Me.HeaderGroupTabs.TabIndex = 5
        Me.HeaderGroupTabs.Text = "Resultados"
        Me.HeaderGroupTabs.ValuesPrimary.Description = ""
        Me.HeaderGroupTabs.ValuesPrimary.Heading = "Resultados"
        Me.HeaderGroupTabs.ValuesPrimary.Image = Nothing
        Me.HeaderGroupTabs.ValuesSecondary.Description = ""
        Me.HeaderGroupTabs.ValuesSecondary.Heading = ""
        Me.HeaderGroupTabs.ValuesSecondary.Image = Nothing
        '
        'ControlVisorLiquidacion
        '
        Me.ControlVisorLiquidacion.BackColor = System.Drawing.Color.Transparent
        Me.ControlVisorLiquidacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ControlVisorLiquidacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlVisorLiquidacion.Location = New System.Drawing.Point(0, 25)
        Me.ControlVisorLiquidacion.Name = "ControlVisorLiquidacion"
        Me.ControlVisorLiquidacion.Size = New System.Drawing.Size(1017, 499)
        Me.ControlVisorLiquidacion.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.Controls.Add(Me.MenuBar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1017, 25)
        Me.Panel2.TabIndex = 4
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnProcesarReporte, Me.ToolStripSeparator1, Me.btnPorDetalle})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(1017, 25)
        Me.MenuBar.TabIndex = 2
        Me.MenuBar.Text = "ToolStrip1"
        '
        'btnProcesarReporte
        '
        Me.btnProcesarReporte.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnProcesarReporte.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.btnProcesarReporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProcesarReporte.Name = "btnProcesarReporte"
        Me.btnProcesarReporte.Size = New System.Drawing.Size(61, 22)
        Me.btnProcesarReporte.Text = "Buscar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnPorDetalle
        '
        Me.btnPorDetalle.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnPorDetalle.Image = Global.SOLMIN_ST.My.Resources.Resources.cell_layout
        Me.btnPorDetalle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPorDetalle.Name = "btnPorDetalle"
        Me.btnPorDetalle.Size = New System.Drawing.Size(128, 22)
        Me.btnPorDetalle.Text = "Reporte por Detalle"
        '
        'HeaderGroupFiltro
        '
        Me.HeaderGroupFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderGroupFiltro.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HeaderGroupFiltro.Location = New System.Drawing.Point(0, 0)
        Me.HeaderGroupFiltro.Name = "HeaderGroupFiltro"
        '
        'HeaderGroupFiltro.Panel
        '
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.dtpFechaInicio)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.dtpFechaFin)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel2)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel4)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.txtCliente)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel5)
        Me.HeaderGroupFiltro.Size = New System.Drawing.Size(1019, 70)
        Me.HeaderGroupFiltro.TabIndex = 4
        Me.HeaderGroupFiltro.Text = "Opciones de filtro"
        Me.HeaderGroupFiltro.ValuesPrimary.Description = ""
        Me.HeaderGroupFiltro.ValuesPrimary.Heading = "Opciones de filtro"
        Me.HeaderGroupFiltro.ValuesPrimary.Image = Nothing
        Me.HeaderGroupFiltro.ValuesSecondary.Description = ""
        Me.HeaderGroupFiltro.ValuesSecondary.Heading = ""
        Me.HeaderGroupFiltro.ValuesSecondary.Image = Nothing
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(432, 10)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(84, 21)
        Me.dtpFechaInicio.TabIndex = 5
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(538, 10)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(84, 21)
        Me.dtpFechaFin.TabIndex = 6
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(384, 12)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(40, 17)
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 103
        Me.KryptonLabel2.Text = "Fecha"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Fecha"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(516, 12)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(20, 17)
        Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 105
        Me.KryptonLabel4.Text = "Al"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Al"
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.CCMPN = "EZ"
        Me.txtCliente.Location = New System.Drawing.Point(73, 10)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = False
        Me.txtCliente.pRequerido = False
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(287, 21)
        Me.txtCliente.TabIndex = 3
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.KryptonLabel5.Location = New System.Drawing.Point(12, 12)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(44, 17)
        Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.TabIndex = 105
        Me.KryptonLabel5.Text = "Cliente"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Cliente"
        '
        'frmConsultaLiquidacionGasto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 619)
        Me.Controls.Add(Me.panel)
        Me.MinimumSize = New System.Drawing.Size(900, 480)
        Me.Name = "frmConsultaLiquidacionGasto"
        Me.Text = "Consulta Liquidación Gasto"
        CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.ResumeLayout(False)
        CType(Me.HeaderGroupTabs.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderGroupTabs.Panel.ResumeLayout(False)
        Me.HeaderGroupTabs.Panel.PerformLayout()
        CType(Me.HeaderGroupTabs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderGroupTabs.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        CType(Me.HeaderGroupFiltro.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderGroupFiltro.Panel.ResumeLayout(False)
        Me.HeaderGroupFiltro.Panel.PerformLayout()
        CType(Me.HeaderGroupFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderGroupFiltro.ResumeLayout(False)
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
    Friend WithEvents HeaderGroupFiltro As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents HeaderGroupTabs As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ControlVisorLiquidacion As SOLMIN_ST.Control_Visor_Reporte
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnProcesarReporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPorDetalle As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
