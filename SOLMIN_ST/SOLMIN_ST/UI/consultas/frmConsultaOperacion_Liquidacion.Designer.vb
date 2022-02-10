<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaOperacion_Liquidacion
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dtgLiquidacionSAP = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.CTRSPT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMTRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FCHCRT_S = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NCRRRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NGUITR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CSRVC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TABTRF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NORINS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRFSAP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NENMRS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MenuBar = New System.Windows.Forms.ToolStrip
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnProcesar = New System.Windows.Forms.ToolStripButton
        Me.lblTitulo = New System.Windows.Forms.ToolStripLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dtgLiquidacionSAP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dtgLiquidacionSAP)
        Me.KryptonPanel.Controls.Add(Me.MenuBar)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(844, 326)
        Me.KryptonPanel.TabIndex = 0
        '
        'dtgLiquidacionSAP
        '
        Me.dtgLiquidacionSAP.AllowUserToAddRows = False
        Me.dtgLiquidacionSAP.AllowUserToDeleteRows = False
        Me.dtgLiquidacionSAP.ColumnHeadersHeight = 30
        Me.dtgLiquidacionSAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgLiquidacionSAP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CTRSPT, Me.TCMTRT, Me.FCHCRT_S, Me.NCRRRT, Me.NGUITR, Me.CSRVC, Me.TABTRF, Me.NORINS, Me.NRFSAP, Me.NENMRS})
        Me.dtgLiquidacionSAP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgLiquidacionSAP.Location = New System.Drawing.Point(0, 25)
        Me.dtgLiquidacionSAP.Name = "dtgLiquidacionSAP"
        Me.dtgLiquidacionSAP.RowHeadersVisible = False
        Me.dtgLiquidacionSAP.RowHeadersWidth = 30
        Me.dtgLiquidacionSAP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtgLiquidacionSAP.Size = New System.Drawing.Size(844, 301)
        Me.dtgLiquidacionSAP.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgLiquidacionSAP.TabIndex = 4
        '
        'CTRSPT
        '
        Me.CTRSPT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CTRSPT.DataPropertyName = "CTRSPT"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CTRSPT.DefaultCellStyle = DataGridViewCellStyle1
        Me.CTRSPT.HeaderText = "Codigo Transporte"
        Me.CTRSPT.Name = "CTRSPT"
        Me.CTRSPT.Visible = False
        Me.CTRSPT.Width = 135
        '
        'TCMTRT
        '
        Me.TCMTRT.DataPropertyName = "TCMTRT"
        Me.TCMTRT.HeaderText = "Transportista"
        Me.TCMTRT.Name = "TCMTRT"
        Me.TCMTRT.Width = 200
        '
        'FCHCRT_S
        '
        Me.FCHCRT_S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FCHCRT_S.DataPropertyName = "FCHCRT_S"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FCHCRT_S.DefaultCellStyle = DataGridViewCellStyle2
        Me.FCHCRT_S.HeaderText = "Fecha"
        Me.FCHCRT_S.Name = "FCHCRT_S"
        Me.FCHCRT_S.Width = 67
        '
        'NCRRRT
        '
        Me.NCRRRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NCRRRT.DataPropertyName = "NCRRRT"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NCRRRT.DefaultCellStyle = DataGridViewCellStyle3
        Me.NCRRRT.HeaderText = "N° Correlativo"
        Me.NCRRRT.Name = "NCRRRT"
        Me.NCRRRT.ReadOnly = True
        Me.NCRRRT.Width = 111
        '
        'NGUITR
        '
        Me.NGUITR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NGUITR.DataPropertyName = "NGUITR"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NGUITR.DefaultCellStyle = DataGridViewCellStyle4
        Me.NGUITR.HeaderText = "Guía Remisión"
        Me.NGUITR.Name = "NGUITR"
        Me.NGUITR.ReadOnly = True
        Me.NGUITR.Width = 112
        '
        'CSRVC
        '
        Me.CSRVC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CSRVC.DataPropertyName = "CSRVC"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CSRVC.DefaultCellStyle = DataGridViewCellStyle5
        Me.CSRVC.HeaderText = "Codigo Servicio"
        Me.CSRVC.Name = "CSRVC"
        Me.CSRVC.ReadOnly = True
        Me.CSRVC.Visible = False
        Me.CSRVC.Width = 119
        '
        'TABTRF
        '
        Me.TABTRF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TABTRF.DataPropertyName = "TABTRF"
        Me.TABTRF.HeaderText = "Servicio"
        Me.TABTRF.Name = "TABTRF"
        Me.TABTRF.ReadOnly = True
        Me.TABTRF.Width = 77
        '
        'NORINS
        '
        Me.NORINS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NORINS.DataPropertyName = "NORINS"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NORINS.DefaultCellStyle = DataGridViewCellStyle6
        Me.NORINS.HeaderText = "Orden Interna"
        Me.NORINS.Name = "NORINS"
        Me.NORINS.ReadOnly = True
        Me.NORINS.Width = 109
        '
        'NRFSAP
        '
        Me.NRFSAP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRFSAP.DataPropertyName = "NRFSAP"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NRFSAP.DefaultCellStyle = DataGridViewCellStyle7
        Me.NRFSAP.HeaderText = "Referencia SAP"
        Me.NRFSAP.Name = "NRFSAP"
        Me.NRFSAP.ReadOnly = True
        Me.NRFSAP.Width = 115
        '
        'NENMRS
        '
        Me.NENMRS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NENMRS.DataPropertyName = "NENMRS"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.NENMRS.DefaultCellStyle = DataGridViewCellStyle8
        Me.NENMRS.HeaderText = "Entrada Mercadería"
        Me.NENMRS.Name = "NENMRS"
        Me.NENMRS.ReadOnly = True
        Me.NENMRS.Width = 138
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.ToolStripSeparator1, Me.btnProcesar, Me.lblTitulo})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(844, 25)
        Me.MenuBar.TabIndex = 3
        Me.MenuBar.Text = "ToolStrip1"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(73, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnProcesar
        '
        Me.btnProcesar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnProcesar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnProcesar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(72, 22)
        Me.btnProcesar.Text = "Procesar"
        '
        'lblTitulo
        '
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(12, 22)
        Me.lblTitulo.Text = "?"
        '
        'frmConsultaOperacion_Liquidacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 326)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(850, 350)
        Me.MinimumSize = New System.Drawing.Size(850, 350)
        Me.Name = "frmConsultaOperacion_Liquidacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dtgLiquidacionSAP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
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
  Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
  Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnProcesar As System.Windows.Forms.ToolStripButton
  Friend WithEvents dtgLiquidacionSAP As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents lblTitulo As System.Windows.Forms.ToolStripLabel
  Friend WithEvents CTRSPT As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TCMTRT As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FCHCRT_S As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NCRRRT As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NGUITR As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CSRVC As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TABTRF As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NORINS As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NRFSAP As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NENMRS As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
