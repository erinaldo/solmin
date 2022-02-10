<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuiaRansaXNrParte
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dgGuiasRansa = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.tsReporte = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbCerrar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbExportarExcel = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbVistaPrevia = New System.Windows.Forms.ToolStripButton
        Me.tsb3 = New System.Windows.Forms.ToolStripSeparator
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.FechaAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_NGUIRN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_CTPOAT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_DTPOAT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_CTPALM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_CALMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_CTRSP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_NPLCCM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_NBRVCH = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_STPING = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCPRVD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QITEMS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_STRNSM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_SITUAC = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgGuiasRansa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsReporte.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgGuiasRansa)
        Me.KryptonPanel.Controls.Add(Me.tsReporte)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(836, 402)
        Me.KryptonPanel.TabIndex = 0
        '
        'dgGuiasRansa
        '
        Me.dgGuiasRansa.AllowUserToAddRows = False
        Me.dgGuiasRansa.AllowUserToDeleteRows = False
        Me.dgGuiasRansa.AllowUserToResizeColumns = False
        Me.dgGuiasRansa.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon
        Me.dgGuiasRansa.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgGuiasRansa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgGuiasRansa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaAsignacion, Me.GS_NGUIRN, Me.GS_CTPOAT, Me.GS_DTPOAT, Me.GS_CTPALM, Me.GS_CALMC, Me.GS_CTRSP, Me.GS_NPLCCM, Me.GS_NBRVCH, Me.GS_STPING, Me.GS_SESTRG, Me.PSCPRVD, Me.QITEMS, Me.GS_STRNSM, Me.GS_SITUAC})
        Me.dgGuiasRansa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgGuiasRansa.Location = New System.Drawing.Point(0, 25)
        Me.dgGuiasRansa.MultiSelect = False
        Me.dgGuiasRansa.Name = "dgGuiasRansa"
        Me.dgGuiasRansa.ReadOnly = True
        Me.dgGuiasRansa.RowHeadersWidth = 20
        Me.dgGuiasRansa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgGuiasRansa.Size = New System.Drawing.Size(836, 377)
        Me.dgGuiasRansa.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgGuiasRansa.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dgGuiasRansa.TabIndex = 17
        '
        'tsReporte
        '
        Me.tsReporte.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsReporte.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsReporte.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.tsbCerrar, Me.ToolStripSeparator2, Me.tsbExportarExcel, Me.ToolStripSeparator3, Me.tsbVistaPrevia, Me.tsb3})
        Me.tsReporte.Location = New System.Drawing.Point(0, 0)
        Me.tsReporte.Name = "tsReporte"
        Me.tsReporte.Size = New System.Drawing.Size(836, 25)
        Me.tsReporte.TabIndex = 54
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbCerrar
        '
        Me.tsbCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbCerrar.Image = Global.SOLMIN_SA.My.Resources.Resources._exit
        Me.tsbCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCerrar.Name = "tsbCerrar"
        Me.tsbCerrar.Size = New System.Drawing.Size(59, 22)
        Me.tsbCerrar.Text = "Cerrar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbExportarExcel
        '
        Me.tsbExportarExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbExportarExcel.Image = Global.SOLMIN_SA.My.Resources.Resources.excelicon
        Me.tsbExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportarExcel.Name = "tsbExportarExcel"
        Me.tsbExportarExcel.Size = New System.Drawing.Size(99, 22)
        Me.tsbExportarExcel.Text = "Exportar Excel"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tsbVistaPrevia
        '
        Me.tsbVistaPrevia.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbVistaPrevia.Image = Global.SOLMIN_SA.My.Resources.Resources.impresora_ico
        Me.tsbVistaPrevia.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbVistaPrevia.Name = "tsbVistaPrevia"
        Me.tsbVistaPrevia.Size = New System.Drawing.Size(87, 22)
        Me.tsbVistaPrevia.Text = "Vista Previa"
        '
        'tsb3
        '
        Me.tsb3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsb3.Name = "tsb3"
        Me.tsb3.Size = New System.Drawing.Size(6, 25)
        '
        'FechaAsignacion
        '
        Me.FechaAsignacion.DataPropertyName = "FechaAsignacion"
        Me.FechaAsignacion.HeaderText = "Fecha"
        Me.FechaAsignacion.Name = "FechaAsignacion"
        Me.FechaAsignacion.ReadOnly = True
        Me.FechaAsignacion.Width = 67
        '
        'GS_NGUIRN
        '
        Me.GS_NGUIRN.DataPropertyName = "PNNGUIRN"
        Me.GS_NGUIRN.HeaderText = "Nro. Guía Ransa"
        Me.GS_NGUIRN.Name = "GS_NGUIRN"
        Me.GS_NGUIRN.ReadOnly = True
        Me.GS_NGUIRN.Width = 120
        '
        'GS_CTPOAT
        '
        Me.GS_CTPOAT.DataPropertyName = "PSCTPOAT"
        Me.GS_CTPOAT.HeaderText = "Proceso"
        Me.GS_CTPOAT.Name = "GS_CTPOAT"
        Me.GS_CTPOAT.ReadOnly = True
        Me.GS_CTPOAT.Visible = False
        Me.GS_CTPOAT.Width = 78
        '
        'GS_DTPOAT
        '
        Me.GS_DTPOAT.DataPropertyName = "PSDTPOAT"
        Me.GS_DTPOAT.HeaderText = "Proceso"
        Me.GS_DTPOAT.Name = "GS_DTPOAT"
        Me.GS_DTPOAT.ReadOnly = True
        Me.GS_DTPOAT.Width = 78
        '
        'GS_CTPALM
        '
        Me.GS_CTPALM.DataPropertyName = "PSCTPALM"
        Me.GS_CTPALM.HeaderText = "Tipo Almacén"
        Me.GS_CTPALM.Name = "GS_CTPALM"
        Me.GS_CTPALM.ReadOnly = True
        Me.GS_CTPALM.Width = 110
        '
        'GS_CALMC
        '
        Me.GS_CALMC.DataPropertyName = "PSCALMC"
        Me.GS_CALMC.HeaderText = "Almacén"
        Me.GS_CALMC.Name = "GS_CALMC"
        Me.GS_CALMC.ReadOnly = True
        Me.GS_CALMC.Width = 83
        '
        'GS_CTRSP
        '
        Me.GS_CTRSP.DataPropertyName = "PNCTRSP"
        Me.GS_CTRSP.HeaderText = "Emp. Transporte"
        Me.GS_CTRSP.Name = "GS_CTRSP"
        Me.GS_CTRSP.ReadOnly = True
        Me.GS_CTRSP.Visible = False
        Me.GS_CTRSP.Width = 123
        '
        'GS_NPLCCM
        '
        Me.GS_NPLCCM.DataPropertyName = "PSNPLCCM"
        Me.GS_NPLCCM.HeaderText = "Unidad"
        Me.GS_NPLCCM.Name = "GS_NPLCCM"
        Me.GS_NPLCCM.ReadOnly = True
        Me.GS_NPLCCM.Visible = False
        Me.GS_NPLCCM.Width = 74
        '
        'GS_NBRVCH
        '
        Me.GS_NBRVCH.DataPropertyName = "PSNBRVCH"
        Me.GS_NBRVCH.HeaderText = "Brevete"
        Me.GS_NBRVCH.Name = "GS_NBRVCH"
        Me.GS_NBRVCH.ReadOnly = True
        Me.GS_NBRVCH.Visible = False
        Me.GS_NBRVCH.Width = 75
        '
        'GS_STPING
        '
        Me.GS_STPING.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GS_STPING.DataPropertyName = "PSSTPING"
        Me.GS_STPING.HeaderText = "Movimiento"
        Me.GS_STPING.Name = "GS_STPING"
        Me.GS_STPING.ReadOnly = True
        '
        'GS_SESTRG
        '
        Me.GS_SESTRG.DataPropertyName = "PSSESTRG"
        Me.GS_SESTRG.HeaderText = "Código Situación"
        Me.GS_SESTRG.Name = "GS_SESTRG"
        Me.GS_SESTRG.ReadOnly = True
        Me.GS_SESTRG.Visible = False
        Me.GS_SESTRG.Width = 127
        '
        'PSCPRVD
        '
        Me.PSCPRVD.DataPropertyName = "PSCPRVD"
        Me.PSCPRVD.HeaderText = "GS_CPRVD"
        Me.PSCPRVD.Name = "PSCPRVD"
        Me.PSCPRVD.ReadOnly = True
        Me.PSCPRVD.Visible = False
        Me.PSCPRVD.Width = 92
        '
        'QITEMS
        '
        Me.QITEMS.DataPropertyName = "PNQITEMS"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.QITEMS.DefaultCellStyle = DataGridViewCellStyle2
        Me.QITEMS.HeaderText = "Cant. Items"
        Me.QITEMS.Name = "QITEMS"
        Me.QITEMS.ReadOnly = True
        Me.QITEMS.Width = 96
        '
        'GS_STRNSM
        '
        Me.GS_STRNSM.DataPropertyName = "PSSTRNSM"
        Me.GS_STRNSM.HeaderText = "Est de Trans."
        Me.GS_STRNSM.Name = "GS_STRNSM"
        Me.GS_STRNSM.ReadOnly = True
        Me.GS_STRNSM.Visible = False
        Me.GS_STRNSM.Width = 102
        '
        'GS_SITUAC
        '
        Me.GS_SITUAC.DataPropertyName = "PSSITUAC"
        Me.GS_SITUAC.HeaderText = "Situación"
        Me.GS_SITUAC.Name = "GS_SITUAC"
        Me.GS_SITUAC.ReadOnly = True
        Me.GS_SITUAC.Width = 85
        '
        'frmGuiaRansaXNrParte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 402)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmGuiaRansaXNrParte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guía Ransa Por Nr. de Parte"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dgGuiasRansa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsReporte.ResumeLayout(False)
        Me.tsReporte.PerformLayout()
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
    Friend WithEvents dgGuiasRansa As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents tsReporte As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbVistaPrevia As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsb3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FechaAsignacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_NGUIRN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_CTPOAT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_DTPOAT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_CTPALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_CALMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_CTRSP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_NPLCCM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_NBRVCH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_STPING As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCPRVD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QITEMS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_STRNSM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_SITUAC As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
