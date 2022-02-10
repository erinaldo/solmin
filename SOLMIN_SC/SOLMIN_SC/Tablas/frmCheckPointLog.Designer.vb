<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckPointLog
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dtgCheckPointLog = New System.Windows.Forms.DataGridView
        Me.FECHALOG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HORALOG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUSCRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FESEST = New SOLMIN_SC.CalendarColumn
        Me.FRETES = New SOLMIN_SC.CalendarColumn
        Me.tsOpcion = New System.Windows.Forms.ToolStrip
        Me.btnCerrar = New System.Windows.Forms.ToolStripButton
        Me.lblCheckPoint = New System.Windows.Forms.ToolStripLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CalendarColumn1 = New SOLMIN_SC.CalendarColumn
        Me.CalendarColumn2 = New SOLMIN_SC.CalendarColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dtgCheckPointLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsOpcion.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dtgCheckPointLog)
        Me.KryptonPanel.Controls.Add(Me.tsOpcion)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(432, 431)
        Me.KryptonPanel.TabIndex = 0
        '
        'dtgCheckPointLog
        '
        Me.dtgCheckPointLog.AllowUserToAddRows = False
        Me.dtgCheckPointLog.AllowUserToDeleteRows = False
        Me.dtgCheckPointLog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgCheckPointLog.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgCheckPointLog.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgCheckPointLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgCheckPointLog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FECHALOG, Me.HORALOG, Me.CUSCRT, Me.FESEST, Me.FRETES})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = "0"
        DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgCheckPointLog.DefaultCellStyle = DataGridViewCellStyle7
        Me.dtgCheckPointLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgCheckPointLog.GridColor = System.Drawing.Color.CornflowerBlue
        Me.dtgCheckPointLog.Location = New System.Drawing.Point(0, 25)
        Me.dtgCheckPointLog.Name = "dtgCheckPointLog"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgCheckPointLog.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dtgCheckPointLog.RowHeadersWidth = 20
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = "0"
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(2)
        Me.dtgCheckPointLog.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dtgCheckPointLog.Size = New System.Drawing.Size(432, 406)
        Me.dtgCheckPointLog.TabIndex = 28
        '
        'FECHALOG
        '
        Me.FECHALOG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FECHALOG.DataPropertyName = "FECHALOG"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FECHALOG.DefaultCellStyle = DataGridViewCellStyle2
        Me.FECHALOG.HeaderText = "Fecha"
        Me.FECHALOG.Name = "FECHALOG"
        Me.FECHALOG.ReadOnly = True
        Me.FECHALOG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.FECHALOG.Width = 49
        '
        'HORALOG
        '
        Me.HORALOG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.HORALOG.DataPropertyName = "HORALOG"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.HORALOG.DefaultCellStyle = DataGridViewCellStyle3
        Me.HORALOG.HeaderText = "Hora"
        Me.HORALOG.Name = "HORALOG"
        Me.HORALOG.ReadOnly = True
        Me.HORALOG.Width = 61
        '
        'CUSCRT
        '
        Me.CUSCRT.DataPropertyName = "CUSCRT"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.CUSCRT.DefaultCellStyle = DataGridViewCellStyle4
        Me.CUSCRT.HeaderText = "Usuario"
        Me.CUSCRT.Name = "CUSCRT"
        Me.CUSCRT.ReadOnly = True
        '
        'FESEST
        '
        Me.FESEST.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FESEST.DataPropertyName = "FESEST"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "d"
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FESEST.DefaultCellStyle = DataGridViewCellStyle5
        Me.FESEST.HeaderText = "Fecha Estimada"
        Me.FESEST.Name = "FESEST"
        Me.FESEST.ReadOnly = True
        Me.FESEST.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FESEST.Width = 102
        '
        'FRETES
        '
        Me.FRETES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FRETES.DataPropertyName = "FRETES"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Format = "d"
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FRETES.DefaultCellStyle = DataGridViewCellStyle6
        Me.FRETES.HeaderText = "Fecha Real"
        Me.FRETES.Name = "FRETES"
        Me.FRETES.ReadOnly = True
        Me.FRETES.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FRETES.Width = 75
        '
        'tsOpcion
        '
        Me.tsOpcion.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsOpcion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCerrar, Me.lblCheckPoint})
        Me.tsOpcion.Location = New System.Drawing.Point(0, 0)
        Me.tsOpcion.Name = "tsOpcion"
        Me.tsOpcion.Size = New System.Drawing.Size(432, 25)
        Me.tsOpcion.TabIndex = 0
        '
        'btnCerrar
        '
        Me.btnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCerrar.Image = Global.SOLMIN_SC.My.Resources.Resources._exit
        Me.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(49, 22)
        Me.btnCerrar.Text = "Salir"
        '
        'lblCheckPoint
        '
        Me.lblCheckPoint.Name = "lblCheckPoint"
        Me.lblCheckPoint.Size = New System.Drawing.Size(0, 22)
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "FECHALOG"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Fecha Incidencia"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "HORALOG"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Hora Incidencia"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CUSCRT"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Usuario"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'CalendarColumn1
        '
        Me.CalendarColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CalendarColumn1.DataPropertyName = "FESEST"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Format = "d"
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CalendarColumn1.DefaultCellStyle = DataGridViewCellStyle10
        Me.CalendarColumn1.HeaderText = "Fecha Estimada"
        Me.CalendarColumn1.Name = "CalendarColumn1"
        Me.CalendarColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'CalendarColumn2
        '
        Me.CalendarColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CalendarColumn2.DataPropertyName = "FRETES"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.Format = "d"
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CalendarColumn2.DefaultCellStyle = DataGridViewCellStyle11
        Me.CalendarColumn2.HeaderText = "Fecha Real"
        Me.CalendarColumn2.Name = "CalendarColumn2"
        Me.CalendarColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'frmCheckPointLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 431)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(440, 465)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(440, 465)
        Me.Name = "frmCheckPointLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Incidencias CheckPoint"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dtgCheckPointLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsOpcion.ResumeLayout(False)
        Me.tsOpcion.PerformLayout()
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
    Friend WithEvents dtgCheckPointLog As System.Windows.Forms.DataGridView
    Friend WithEvents tsOpcion As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CalendarColumn1 As SOLMIN_SC.CalendarColumn
    Friend WithEvents CalendarColumn2 As SOLMIN_SC.CalendarColumn
    Friend WithEvents lblCheckPoint As System.Windows.Forms.ToolStripLabel
    Friend WithEvents FECHALOG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORALOG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUSCRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FESEST As SOLMIN_SC.CalendarColumn
    Friend WithEvents FRETES As SOLMIN_SC.CalendarColumn
End Class
