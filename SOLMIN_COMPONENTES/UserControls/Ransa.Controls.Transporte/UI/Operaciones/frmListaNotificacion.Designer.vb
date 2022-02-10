<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaNotificacion
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
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dgvDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NCRRSG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NUMREQT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SESREQT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FDSGDC_S = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HDSGDC_S = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.URSPDC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TOBSSG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUSCRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FCHCRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HRACRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NTRMCR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgvDatos)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(587, 266)
        Me.KryptonPanel.TabIndex = 0
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowUserToAddRows = False
        Me.dgvDatos.AllowUserToDeleteRows = False
        Me.dgvDatos.AllowUserToOrderColumns = True
        Me.dgvDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDatos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dgvDatos.ColumnHeadersHeight = 30
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NCRRSG, Me.NUMREQT, Me.SESREQT, Me.FDSGDC_S, Me.HDSGDC_S, Me.URSPDC, Me.TOBSSG, Me.SESTRG, Me.CUSCRT, Me.FCHCRT, Me.HRACRT, Me.NTRMCR})
        Me.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDatos.Location = New System.Drawing.Point(0, 0)
        Me.dgvDatos.MultiSelect = False
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.dgvDatos.RowHeadersWidth = 10
        Me.dgvDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvDatos.RowTemplate.Height = 16
        Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatos.Size = New System.Drawing.Size(587, 266)
        Me.dgvDatos.StandardTab = True
        Me.dgvDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvDatos.TabIndex = 12
        '
        'NCRRSG
        '
        Me.NCRRSG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NCRRSG.DataPropertyName = "NCRRSG"
        Me.NCRRSG.HeaderText = "Nro. "
        Me.NCRRSG.MinimumWidth = 50
        Me.NCRRSG.Name = "NCRRSG"
        Me.NCRRSG.ReadOnly = True
        Me.NCRRSG.Width = 62
        '
        'NUMREQT
        '
        Me.NUMREQT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NUMREQT.DataPropertyName = "NUMREQT"
        Me.NUMREQT.HeaderText = "Nro Req."
        Me.NUMREQT.MinimumWidth = 50
        Me.NUMREQT.Name = "NUMREQT"
        Me.NUMREQT.ReadOnly = True
        Me.NUMREQT.Visible = False
        Me.NUMREQT.Width = 82
        '
        'SESREQT
        '
        Me.SESREQT.DataPropertyName = "SESREQT"
        Me.SESREQT.HeaderText = "Área"
        Me.SESREQT.Name = "SESREQT"
        Me.SESREQT.ReadOnly = True
        '
        'FDSGDC_S
        '
        Me.FDSGDC_S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FDSGDC_S.DataPropertyName = "FDSGDC_S"
        Me.FDSGDC_S.HeaderText = "Fecha Envío"
        Me.FDSGDC_S.Name = "FDSGDC_S"
        Me.FDSGDC_S.ReadOnly = True
        Me.FDSGDC_S.Width = 99
        '
        'HDSGDC_S
        '
        Me.HDSGDC_S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.HDSGDC_S.DataPropertyName = "HDSGDC_S"
        Me.HDSGDC_S.HeaderText = "Hora Envío"
        Me.HDSGDC_S.MinimumWidth = 100
        Me.HDSGDC_S.Name = "HDSGDC_S"
        Me.HDSGDC_S.ReadOnly = True
        '
        'URSPDC
        '
        Me.URSPDC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.URSPDC.DataPropertyName = "URSPDC"
        Me.URSPDC.HeaderText = "Responsable"
        Me.URSPDC.Name = "URSPDC"
        Me.URSPDC.ReadOnly = True
        Me.URSPDC.Width = 102
        '
        'TOBSSG
        '
        Me.TOBSSG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TOBSSG.DataPropertyName = "TOBSSG"
        Me.TOBSSG.HeaderText = "Observación"
        Me.TOBSSG.Name = "TOBSSG"
        Me.TOBSSG.ReadOnly = True
        Me.TOBSSG.Width = 102
        '
        'SESTRG
        '
        Me.SESTRG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SESTRG.DataPropertyName = "SESTRG"
        Me.SESTRG.HeaderText = "Estado"
        Me.SESTRG.MinimumWidth = 100
        Me.SESTRG.Name = "SESTRG"
        Me.SESTRG.ReadOnly = True
        '
        'CUSCRT
        '
        Me.CUSCRT.DataPropertyName = "CUSCRT"
        Me.CUSCRT.HeaderText = "Usuario Reg."
        Me.CUSCRT.Name = "CUSCRT"
        Me.CUSCRT.ReadOnly = True
        Me.CUSCRT.Visible = False
        '
        'FCHCRT
        '
        Me.FCHCRT.DataPropertyName = "FCHCRT"
        Me.FCHCRT.HeaderText = "Fecha Reg."
        Me.FCHCRT.Name = "FCHCRT"
        Me.FCHCRT.ReadOnly = True
        Me.FCHCRT.Visible = False
        '
        'HRACRT
        '
        Me.HRACRT.DataPropertyName = "HRACRT"
        Me.HRACRT.HeaderText = "Hora Reg."
        Me.HRACRT.Name = "HRACRT"
        Me.HRACRT.ReadOnly = True
        Me.HRACRT.Visible = False
        '
        'NTRMCR
        '
        Me.NTRMCR.DataPropertyName = "NTRMCR"
        Me.NTRMCR.HeaderText = "Nro. Terminal"
        Me.NTRMCR.Name = "NTRMCR"
        Me.NTRMCR.ReadOnly = True
        Me.NTRMCR.Visible = False
        '
        'frmListaNotificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 266)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmListaNotificacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notificaciones"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents NCRRSG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUMREQT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESREQT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FDSGDC_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HDSGDC_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents URSPDC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOBSSG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUSCRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FCHCRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HRACRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NTRMCR As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
