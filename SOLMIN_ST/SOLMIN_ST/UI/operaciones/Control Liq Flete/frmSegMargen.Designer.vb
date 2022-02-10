<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSegMargen
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
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.dgMargenes = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.FCHCRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HRACRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NGUIRM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FLGSTA_DESC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ARE_RESP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TOBS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUSCRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgMargenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgMargenes)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(696, 320)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(696, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'dgMargenes
        '
        Me.dgMargenes.AllowUserToAddRows = False
        Me.dgMargenes.AllowUserToDeleteRows = False
        Me.dgMargenes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FCHCRT, Me.HRACRT, Me.NGUIRM, Me.FLGSTA_DESC, Me.ARE_RESP, Me.TOBS, Me.CUSCRT})
        Me.dgMargenes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMargenes.Location = New System.Drawing.Point(0, 25)
        Me.dgMargenes.Name = "dgMargenes"
        Me.dgMargenes.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.dgMargenes.ReadOnly = True
        Me.dgMargenes.Size = New System.Drawing.Size(696, 295)
        Me.dgMargenes.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgMargenes.TabIndex = 3
        '
        'FCHCRT
        '
        Me.FCHCRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FCHCRT.DataPropertyName = "FCHCRT"
        Me.FCHCRT.HeaderText = "Fecha"
        Me.FCHCRT.Name = "FCHCRT"
        Me.FCHCRT.ReadOnly = True
        Me.FCHCRT.Width = 67
        '
        'HRACRT
        '
        Me.HRACRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.HRACRT.DataPropertyName = "HRACRT"
        Me.HRACRT.HeaderText = "Hora"
        Me.HRACRT.Name = "HRACRT"
        Me.HRACRT.ReadOnly = True
        Me.HRACRT.Width = 62
        '
        'NGUIRM
        '
        Me.NGUIRM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NGUIRM.DataPropertyName = "NGUIRM"
        Me.NGUIRM.HeaderText = "Guía Transporte"
        Me.NGUIRM.Name = "NGUIRM"
        Me.NGUIRM.ReadOnly = True
        Me.NGUIRM.Width = 120
        '
        'FLGSTA_DESC
        '
        Me.FLGSTA_DESC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FLGSTA_DESC.DataPropertyName = "FLGSTA_DESC"
        Me.FLGSTA_DESC.HeaderText = "Seg. Status"
        Me.FLGSTA_DESC.Name = "FLGSTA_DESC"
        Me.FLGSTA_DESC.ReadOnly = True
        Me.FLGSTA_DESC.Width = 93
        '
        'ARE_RESP
        '
        Me.ARE_RESP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ARE_RESP.DataPropertyName = "ARE_RESP"
        Me.ARE_RESP.HeaderText = "Área responsable"
        Me.ARE_RESP.Name = "ARE_RESP"
        Me.ARE_RESP.ReadOnly = True
        Me.ARE_RESP.Width = 126
        '
        'TOBS
        '
        Me.TOBS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TOBS.DataPropertyName = "TOBS"
        Me.TOBS.HeaderText = "Observación"
        Me.TOBS.Name = "TOBS"
        Me.TOBS.ReadOnly = True
        Me.TOBS.Width = 102
        '
        'CUSCRT
        '
        Me.CUSCRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CUSCRT.DataPropertyName = "CUSCRT"
        Me.CUSCRT.HeaderText = "Usuario"
        Me.CUSCRT.Name = "CUSCRT"
        Me.CUSCRT.ReadOnly = True
        Me.CUSCRT.Width = 76
        '
        'frmSegMargen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 320)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmSegMargen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Seguimiento Margen"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dgMargenes, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents dgMargenes As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents FCHCRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HRACRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NGUIRM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FLGSTA_DESC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ARE_RESP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOBS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUSCRT As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
