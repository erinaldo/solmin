<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReubicacionConsulta
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.dgMercaderiaUbicacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.tsMenuOpcionesDetalle = New System.Windows.Forms.ToolStrip()
        Me.lblDetalle = New System.Windows.Forms.ToolStripLabel()
        Me.btnSalir = New System.Windows.Forms.ToolStripButton()
        Me.btnReubicar = New System.Windows.Forms.ToolStripButton()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TALMC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCMPAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCMZNA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TNMSCT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPSCN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QSLETQ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOBSRV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DETALLE = New System.Windows.Forms.DataGridViewImageColumn()
        Me.AUDITORIA = New System.Windows.Forms.DataGridViewImageColumn()
        Me.NORDSR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CALMC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTPALM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CSECTR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CZNALM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSCRT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FCHCRT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HRACRT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NTRMCR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FULTAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HULTAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CULUSA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NTRMNL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCLNT2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgMercaderiaUbicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpcionesDetalle.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgMercaderiaUbicacion)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpcionesDetalle)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1300, 601)
        Me.KryptonPanel.TabIndex = 0
        '
        'dgMercaderiaUbicacion
        '
        Me.dgMercaderiaUbicacion.AllowUserToAddRows = False
        Me.dgMercaderiaUbicacion.AllowUserToDeleteRows = False
        Me.dgMercaderiaUbicacion.AllowUserToResizeColumns = False
        Me.dgMercaderiaUbicacion.AllowUserToResizeRows = False
        Me.dgMercaderiaUbicacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgMercaderiaUbicacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TALMC, Me.TCMPAL, Me.TCMZNA, Me.TNMSCT, Me.CPSCN, Me.QSLETQ, Me.TOBSRV, Me.DETALLE, Me.AUDITORIA, Me.NORDSR, Me.CALMC, Me.CTPALM, Me.CSECTR, Me.CZNALM, Me.CUSCRT, Me.FCHCRT, Me.HRACRT, Me.NTRMCR, Me.FULTAC, Me.HULTAC, Me.CULUSA, Me.NTRMNL, Me.SESTRG, Me.CCLNT2})
        Me.dgMercaderiaUbicacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMercaderiaUbicacion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgMercaderiaUbicacion.Location = New System.Drawing.Point(0, 27)
        Me.dgMercaderiaUbicacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgMercaderiaUbicacion.MultiSelect = False
        Me.dgMercaderiaUbicacion.Name = "dgMercaderiaUbicacion"
        Me.dgMercaderiaUbicacion.RowHeadersWidth = 20
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMercaderiaUbicacion.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgMercaderiaUbicacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMercaderiaUbicacion.Size = New System.Drawing.Size(1300, 574)
        Me.dgMercaderiaUbicacion.StandardTab = True
        Me.dgMercaderiaUbicacion.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgMercaderiaUbicacion.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgMercaderiaUbicacion.TabIndex = 78
        '
        'tsMenuOpcionesDetalle
        '
        Me.tsMenuOpcionesDetalle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpcionesDetalle.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpcionesDetalle.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMenuOpcionesDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblDetalle, Me.btnSalir, Me.btnReubicar})
        Me.tsMenuOpcionesDetalle.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpcionesDetalle.Name = "tsMenuOpcionesDetalle"
        Me.tsMenuOpcionesDetalle.Size = New System.Drawing.Size(1300, 27)
        Me.tsMenuOpcionesDetalle.TabIndex = 77
        '
        'lblDetalle
        '
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(159, 24)
        Me.lblDetalle.Text = "Información Ubicación"
        '
        'btnSalir
        '
        Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalir.Image = Global.SOLMIN_SA.My.Resources.Resources._exit
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(62, 24)
        Me.btnSalir.Text = "Salir"
        '
        'btnReubicar
        '
        Me.btnReubicar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnReubicar.Image = Global.SOLMIN_SA.My.Resources.Resources.retencion
        Me.btnReubicar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnReubicar.Name = "btnReubicar"
        Me.btnReubicar.Size = New System.Drawing.Size(91, 24)
        Me.btnReubicar.Text = "Reubicar"
        '
        'TALMC
        '
        Me.TALMC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TALMC.DataPropertyName = "TALMC"
        Me.TALMC.HeaderText = "Tipo Almacén"
        Me.TALMC.Name = "TALMC"
        Me.TALMC.Width = 134
        '
        'TCMPAL
        '
        Me.TCMPAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCMPAL.DataPropertyName = "TCMPAL"
        Me.TCMPAL.HeaderText = "Almacén"
        Me.TCMPAL.Name = "TCMPAL"
        '
        'TCMZNA
        '
        Me.TCMZNA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCMZNA.DataPropertyName = "TCMZNA"
        Me.TCMZNA.HeaderText = "Zona"
        Me.TCMZNA.Name = "TCMZNA"
        Me.TCMZNA.Visible = False
        Me.TCMZNA.Width = 76
        '
        'TNMSCT
        '
        Me.TNMSCT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TNMSCT.DataPropertyName = "TNMSCT"
        Me.TNMSCT.HeaderText = "Sector"
        Me.TNMSCT.Name = "TNMSCT"
        Me.TNMSCT.Width = 84
        '
        'CPSCN
        '
        Me.CPSCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CPSCN.DataPropertyName = "CPSCN"
        Me.CPSCN.HeaderText = "Posición"
        Me.CPSCN.Name = "CPSCN"
        Me.CPSCN.Width = 96
        '
        'QSLETQ
        '
        Me.QSLETQ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.QSLETQ.DataPropertyName = "QSLETQ"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.NullValue = Nothing
        Me.QSLETQ.DefaultCellStyle = DataGridViewCellStyle1
        Me.QSLETQ.HeaderText = "Saldo"
        Me.QSLETQ.Name = "QSLETQ"
        Me.QSLETQ.Width = 80
        '
        'TOBSRV
        '
        Me.TOBSRV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TOBSRV.DataPropertyName = "TOBSRV"
        Me.TOBSRV.HeaderText = "Observación"
        Me.TOBSRV.Name = "TOBSRV"
        '
        'DETALLE
        '
        Me.DETALLE.HeaderText = "Movimientos"
        Me.DETALLE.Image = Global.SOLMIN_SA.My.Resources.Resources.cell_layout
        Me.DETALLE.Name = "DETALLE"
        Me.DETALLE.Visible = False
        Me.DETALLE.Width = 105
        '
        'AUDITORIA
        '
        Me.AUDITORIA.HeaderText = "Auditoría"
        Me.AUDITORIA.Image = Global.SOLMIN_SA.My.Resources.Resources.icono_verdetalle
        Me.AUDITORIA.Name = "AUDITORIA"
        Me.AUDITORIA.Visible = False
        Me.AUDITORIA.Width = 81
        '
        'NORDSR
        '
        Me.NORDSR.DataPropertyName = "NORDSR"
        Me.NORDSR.HeaderText = "NORDSR"
        Me.NORDSR.Name = "NORDSR"
        Me.NORDSR.Visible = False
        Me.NORDSR.Width = 101
        '
        'CALMC
        '
        Me.CALMC.DataPropertyName = "CALMC"
        Me.CALMC.HeaderText = "CALMC"
        Me.CALMC.Name = "CALMC"
        Me.CALMC.Visible = False
        Me.CALMC.Width = 90
        '
        'CTPALM
        '
        Me.CTPALM.DataPropertyName = "CTPALM"
        Me.CTPALM.HeaderText = "CTPALM"
        Me.CTPALM.Name = "CTPALM"
        Me.CTPALM.Visible = False
        Me.CTPALM.Width = 96
        '
        'CSECTR
        '
        Me.CSECTR.DataPropertyName = "CSECTR"
        Me.CSECTR.HeaderText = "CSECTR"
        Me.CSECTR.Name = "CSECTR"
        Me.CSECTR.Visible = False
        Me.CSECTR.Width = 93
        '
        'CZNALM
        '
        Me.CZNALM.DataPropertyName = "CZNALM"
        Me.CZNALM.HeaderText = "CZNALM"
        Me.CZNALM.Name = "CZNALM"
        Me.CZNALM.Visible = False
        Me.CZNALM.Width = 101
        '
        'CUSCRT
        '
        Me.CUSCRT.DataPropertyName = "CUSCRT"
        Me.CUSCRT.HeaderText = "CUSCRT"
        Me.CUSCRT.Name = "CUSCRT"
        Me.CUSCRT.Visible = False
        Me.CUSCRT.Width = 94
        '
        'FCHCRT
        '
        Me.FCHCRT.DataPropertyName = "FCHCRT"
        Me.FCHCRT.HeaderText = "FCHCRT"
        Me.FCHCRT.Name = "FCHCRT"
        Me.FCHCRT.Visible = False
        Me.FCHCRT.Width = 94
        '
        'HRACRT
        '
        Me.HRACRT.DataPropertyName = "HRACRT"
        Me.HRACRT.HeaderText = "HRACRT"
        Me.HRACRT.Name = "HRACRT"
        Me.HRACRT.Visible = False
        Me.HRACRT.Width = 97
        '
        'NTRMCR
        '
        Me.NTRMCR.DataPropertyName = "NTRMCR"
        Me.NTRMCR.HeaderText = "NTRMCR"
        Me.NTRMCR.Name = "NTRMCR"
        Me.NTRMCR.Visible = False
        Me.NTRMCR.Width = 101
        '
        'FULTAC
        '
        Me.FULTAC.DataPropertyName = "FULTAC"
        Me.FULTAC.HeaderText = "FULTAC"
        Me.FULTAC.Name = "FULTAC"
        Me.FULTAC.Visible = False
        Me.FULTAC.Width = 91
        '
        'HULTAC
        '
        Me.HULTAC.DataPropertyName = "HULTAC"
        Me.HULTAC.HeaderText = "HULTAC"
        Me.HULTAC.Name = "HULTAC"
        Me.HULTAC.Visible = False
        Me.HULTAC.Width = 95
        '
        'CULUSA
        '
        Me.CULUSA.DataPropertyName = "CULUSA"
        Me.CULUSA.HeaderText = "CULUSA"
        Me.CULUSA.Name = "CULUSA"
        Me.CULUSA.Visible = False
        Me.CULUSA.Width = 96
        '
        'NTRMNL
        '
        Me.NTRMNL.DataPropertyName = "NTRMNL"
        Me.NTRMNL.HeaderText = "NTRMNL"
        Me.NTRMNL.Name = "NTRMNL"
        Me.NTRMNL.Visible = False
        Me.NTRMNL.Width = 101
        '
        'SESTRG
        '
        Me.SESTRG.DataPropertyName = "SESTRG"
        Me.SESTRG.HeaderText = "SESTRG"
        Me.SESTRG.Name = "SESTRG"
        Me.SESTRG.Visible = False
        Me.SESTRG.Width = 93
        '
        'CCLNT2
        '
        Me.CCLNT2.DataPropertyName = "CCLNT2"
        Me.CCLNT2.HeaderText = "CCLNT2"
        Me.CCLNT2.Name = "CCLNT2"
        Me.CCLNT2.Visible = False
        Me.CCLNT2.Width = 94
        '
        'frmReubicacionConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 601)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReubicacionConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Consulta Reubicación"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dgMercaderiaUbicacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpcionesDetalle.ResumeLayout(False)
        Me.tsMenuOpcionesDetalle.PerformLayout()
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
    Private WithEvents tsMenuOpcionesDetalle As System.Windows.Forms.ToolStrip
    Friend WithEvents lblDetalle As System.Windows.Forms.ToolStripLabel
    Friend WithEvents dgMercaderiaUbicacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnReubicar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TALMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMPAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMZNA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TNMSCT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPSCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QSLETQ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOBSRV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DETALLE As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents AUDITORIA As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents NORDSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CALMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTPALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CSECTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CZNALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUSCRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FCHCRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HRACRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NTRMCR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FULTAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HULTAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CULUSA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NTRMNL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNT2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
