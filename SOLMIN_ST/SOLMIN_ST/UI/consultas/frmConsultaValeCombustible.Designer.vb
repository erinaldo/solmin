<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaValeCombustible
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
    Me.Panel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.gwDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.NRSCVL_A = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CTPCMB_A = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.QGLNSL_A = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.NPLCUN_A = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CBRCND_A = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.SSVLCM_A = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.MenuBar = New System.Windows.Forms.ToolStrip
    Me.btnCancelar = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.btnProcesar = New System.Windows.Forms.ToolStripButton
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
    CType(Me.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel.SuspendLayout()
    CType(Me.gwDatos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.MenuBar.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel
    '
    Me.Panel.Controls.Add(Me.gwDatos)
    Me.Panel.Controls.Add(Me.MenuBar)
    Me.Panel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel.Location = New System.Drawing.Point(0, 0)
    Me.Panel.Name = "Panel"
    Me.Panel.Size = New System.Drawing.Size(440, 204)
    Me.Panel.StateCommon.Color1 = System.Drawing.Color.White
    Me.Panel.TabIndex = 0
    '
    'gwDatos
    '
    Me.gwDatos.AllowUserToAddRows = False
    Me.gwDatos.AllowUserToDeleteRows = False
    Me.gwDatos.AllowUserToOrderColumns = True
    Me.gwDatos.AllowUserToResizeRows = False
    Me.gwDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
    Me.gwDatos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
    Me.gwDatos.ColumnHeadersHeight = 30
    Me.gwDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    Me.gwDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NRSCVL_A, Me.CTPCMB_A, Me.QGLNSL_A, Me.NPLCUN_A, Me.CBRCND_A, Me.SSVLCM_A})
    Me.gwDatos.Dock = System.Windows.Forms.DockStyle.Fill
    Me.gwDatos.Location = New System.Drawing.Point(0, 25)
    Me.gwDatos.MultiSelect = False
    Me.gwDatos.Name = "gwDatos"
    Me.gwDatos.ReadOnly = True
    Me.gwDatos.RowHeadersVisible = False
    Me.gwDatos.RowHeadersWidth = 30
    Me.gwDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.gwDatos.Size = New System.Drawing.Size(440, 179)
    Me.gwDatos.StandardTab = True
    Me.gwDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.gwDatos.TabIndex = 1
    '
    'NRSCVL_A
    '
    Me.NRSCVL_A.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.NRSCVL_A.DataPropertyName = "NRSCVL"
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    Me.NRSCVL_A.DefaultCellStyle = DataGridViewCellStyle1
    Me.NRSCVL_A.HeaderText = "N° Vale combustible"
    Me.NRSCVL_A.Name = "NRSCVL_A"
    Me.NRSCVL_A.ReadOnly = True
    Me.NRSCVL_A.Width = 131
    '
    'CTPCMB_A
    '
    Me.CTPCMB_A.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.CTPCMB_A.DataPropertyName = "CTPCMB"
    Me.CTPCMB_A.HeaderText = "Tipo Combustible"
    Me.CTPCMB_A.Name = "CTPCMB_A"
    Me.CTPCMB_A.ReadOnly = True
    '
    'QGLNSL_A
    '
    Me.QGLNSL_A.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.QGLNSL_A.DataPropertyName = "QGLNSL"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
    Me.QGLNSL_A.DefaultCellStyle = DataGridViewCellStyle2
    Me.QGLNSL_A.HeaderText = "Cantidad Galones"
    Me.QGLNSL_A.Name = "QGLNSL_A"
    Me.QGLNSL_A.ReadOnly = True
    Me.QGLNSL_A.Width = 120
    '
    'NPLCUN_A
    '
    Me.NPLCUN_A.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.NPLCUN_A.DataPropertyName = "NPLCUN"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    Me.NPLCUN_A.DefaultCellStyle = DataGridViewCellStyle3
    Me.NPLCUN_A.HeaderText = "Tracto"
    Me.NPLCUN_A.Name = "NPLCUN_A"
    Me.NPLCUN_A.ReadOnly = True
    Me.NPLCUN_A.Visible = False
    Me.NPLCUN_A.Width = 67
    '
    'CBRCND_A
    '
    Me.CBRCND_A.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.CBRCND_A.DataPropertyName = "CBRCND"
    Me.CBRCND_A.HeaderText = "Conductor"
    Me.CBRCND_A.Name = "CBRCND_A"
    Me.CBRCND_A.ReadOnly = True
    Me.CBRCND_A.Visible = False
    '
    'SSVLCM_A
    '
    Me.SSVLCM_A.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.SSVLCM_A.DataPropertyName = "SSVLCM"
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    Me.SSVLCM_A.DefaultCellStyle = DataGridViewCellStyle4
    Me.SSVLCM_A.HeaderText = "Estado"
    Me.SSVLCM_A.Name = "SSVLCM_A"
    Me.SSVLCM_A.ReadOnly = True
    Me.SSVLCM_A.Width = 69
    '
    'MenuBar
    '
    Me.MenuBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
    Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.ToolStripSeparator1, Me.btnProcesar})
    Me.MenuBar.Location = New System.Drawing.Point(0, 0)
    Me.MenuBar.Name = "MenuBar"
    Me.MenuBar.Size = New System.Drawing.Size(440, 25)
    Me.MenuBar.TabIndex = 2
    Me.MenuBar.TabStop = True
    '
    'btnCancelar
    '
    Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources._stop
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
    'btnProcesar
    '
    Me.btnProcesar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnProcesar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
    Me.btnProcesar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnProcesar.Name = "btnProcesar"
    Me.btnProcesar.Size = New System.Drawing.Size(62, 22)
    Me.btnProcesar.Text = "Asignar"
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn1.DataPropertyName = "NRSCVL"
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle5
    Me.DataGridViewTextBoxColumn1.HeaderText = "N° Vale combustible"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    Me.DataGridViewTextBoxColumn1.ReadOnly = True
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.DataGridViewTextBoxColumn2.DataPropertyName = "CTPCMB"
    Me.DataGridViewTextBoxColumn2.HeaderText = "Tipo Combustible"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    Me.DataGridViewTextBoxColumn2.ReadOnly = True
    '
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn3.DataPropertyName = "QGLNSL"
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
    Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle6
    Me.DataGridViewTextBoxColumn3.HeaderText = "Cantidad Galones"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    Me.DataGridViewTextBoxColumn3.ReadOnly = True
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn4.DataPropertyName = "NPLCUN"
    DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle7
    Me.DataGridViewTextBoxColumn4.HeaderText = "Tracto"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    Me.DataGridViewTextBoxColumn4.ReadOnly = True
    Me.DataGridViewTextBoxColumn4.Visible = False
    '
    'DataGridViewTextBoxColumn5
    '
    Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.DataGridViewTextBoxColumn5.DataPropertyName = "CBRCND"
    Me.DataGridViewTextBoxColumn5.HeaderText = "Conductor"
    Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
    Me.DataGridViewTextBoxColumn5.ReadOnly = True
    Me.DataGridViewTextBoxColumn5.Visible = False
    '
    'DataGridViewTextBoxColumn6
    '
    Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn6.DataPropertyName = "SESSLC"
    DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle8
    Me.DataGridViewTextBoxColumn6.HeaderText = "Estado"
    Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
    Me.DataGridViewTextBoxColumn6.ReadOnly = True
    '
    'frmConsultaValeCombustible
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(440, 204)
    Me.ControlBox = False
    Me.Controls.Add(Me.Panel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.MaximumSize = New System.Drawing.Size(446, 228)
    Me.MinimumSize = New System.Drawing.Size(446, 228)
    Me.Name = "frmConsultaValeCombustible"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Consulta Vale Combustible"
    CType(Me.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel.ResumeLayout(False)
    Me.Panel.PerformLayout()
    CType(Me.gwDatos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.MenuBar.ResumeLayout(False)
    Me.MenuBar.PerformLayout()
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
  Friend WithEvents gwDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
  Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnProcesar As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NRSCVL_A As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CTPCMB_A As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents QGLNSL_A As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NPLCUN_A As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CBRCND_A As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents SSVLCM_A As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
