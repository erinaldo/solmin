<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerUnidadesProgramadas
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
        Me.dgvPreAsignacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NPLNJT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NCRRPL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FPRASG_D = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NOPRCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn120 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NCRRPA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRUCTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMTRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NPLCUN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NPLCAC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCBRCNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TNMCMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CBRCN2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TNMCMC2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SESASG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SESASG_D = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgvPreAsignacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgvPreAsignacion)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(867, 266)
        Me.KryptonPanel.TabIndex = 0
        '
        'dgvPreAsignacion
        '
        Me.dgvPreAsignacion.AllowUserToAddRows = False
        Me.dgvPreAsignacion.AllowUserToDeleteRows = False
        Me.dgvPreAsignacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPreAsignacion.ColumnHeadersHeight = 30
        Me.dgvPreAsignacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPreAsignacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NPLNJT, Me.NCRRPL, Me.FPRASG_D, Me.NOPRCN, Me.DataGridViewTextBoxColumn120, Me.NCRRPA, Me.NRUCTR, Me.TCMTRT, Me.NPLCUN, Me.NPLCAC, Me.PSCBRCNT, Me.TNMCMC, Me.CBRCN2, Me.TNMCMC2, Me.SESASG, Me.SESASG_D})
        Me.dgvPreAsignacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPreAsignacion.Location = New System.Drawing.Point(0, 0)
        Me.dgvPreAsignacion.MultiSelect = False
        Me.dgvPreAsignacion.Name = "dgvPreAsignacion"
        Me.dgvPreAsignacion.ReadOnly = True
        Me.dgvPreAsignacion.RowHeadersWidth = 10
        Me.dgvPreAsignacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPreAsignacion.Size = New System.Drawing.Size(867, 266)
        Me.dgvPreAsignacion.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvPreAsignacion.TabIndex = 184
        '
        'NPLNJT
        '
        Me.NPLNJT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NPLNJT.DataPropertyName = "NPLNJT"
        Me.NPLNJT.HeaderText = "Nro Junta"
        Me.NPLNJT.MinimumWidth = 50
        Me.NPLNJT.Name = "NPLNJT"
        Me.NPLNJT.ReadOnly = True
        Me.NPLNJT.Width = 87
        '
        'NCRRPL
        '
        Me.NCRRPL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NCRRPL.DataPropertyName = "NCRRPL"
        Me.NCRRPL.HeaderText = "Corr. Junta"
        Me.NCRRPL.MinimumWidth = 50
        Me.NCRRPL.Name = "NCRRPL"
        Me.NCRRPL.ReadOnly = True
        Me.NCRRPL.Width = 93
        '
        'FPRASG_D
        '
        Me.FPRASG_D.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FPRASG_D.DataPropertyName = "FPRASG_D"
        Me.FPRASG_D.HeaderText = "Fecha Prog."
        Me.FPRASG_D.MinimumWidth = 90
        Me.FPRASG_D.Name = "FPRASG_D"
        Me.FPRASG_D.ReadOnly = True
        Me.FPRASG_D.Width = 98
        '
        'NOPRCN
        '
        Me.NOPRCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NOPRCN.DataPropertyName = "NOPRCN"
        Me.NOPRCN.HeaderText = "Operación"
        Me.NOPRCN.Name = "NOPRCN"
        Me.NOPRCN.ReadOnly = True
        Me.NOPRCN.Width = 91
        '
        'DataGridViewTextBoxColumn120
        '
        Me.DataGridViewTextBoxColumn120.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn120.DataPropertyName = "NUMREQT"
        Me.DataGridViewTextBoxColumn120.HeaderText = "Nro Req."
        Me.DataGridViewTextBoxColumn120.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn120.Name = "DataGridViewTextBoxColumn120"
        Me.DataGridViewTextBoxColumn120.ReadOnly = True
        Me.DataGridViewTextBoxColumn120.Visible = False
        Me.DataGridViewTextBoxColumn120.Width = 82
        '
        'NCRRPA
        '
        Me.NCRRPA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NCRRPA.DataPropertyName = "NCRRPA"
        Me.NCRRPA.HeaderText = "NCRRPA"
        Me.NCRRPA.Name = "NCRRPA"
        Me.NCRRPA.ReadOnly = True
        Me.NCRRPA.Visible = False
        Me.NCRRPA.Width = 82
        '
        'NRUCTR
        '
        Me.NRUCTR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRUCTR.DataPropertyName = "NRUCTR"
        Me.NRUCTR.HeaderText = "RUC"
        Me.NRUCTR.Name = "NRUCTR"
        Me.NRUCTR.ReadOnly = True
        Me.NRUCTR.Width = 59
        '
        'TCMTRT
        '
        Me.TCMTRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TCMTRT.DataPropertyName = "TCMTRT"
        Me.TCMTRT.HeaderText = "Transportista"
        Me.TCMTRT.MinimumWidth = 150
        Me.TCMTRT.Name = "TCMTRT"
        Me.TCMTRT.ReadOnly = True
        '
        'NPLCUN
        '
        Me.NPLCUN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NPLCUN.DataPropertyName = "NPLCUN"
        Me.NPLCUN.HeaderText = "Tracto"
        Me.NPLCUN.Name = "NPLCUN"
        Me.NPLCUN.ReadOnly = True
        Me.NPLCUN.Width = 70
        '
        'NPLCAC
        '
        Me.NPLCAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NPLCAC.DataPropertyName = "NPLCAC"
        Me.NPLCAC.HeaderText = "Acoplado"
        Me.NPLCAC.Name = "NPLCAC"
        Me.NPLCAC.ReadOnly = True
        Me.NPLCAC.Width = 87
        '
        'PSCBRCNT
        '
        Me.PSCBRCNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSCBRCNT.DataPropertyName = "CBRCNT"
        Me.PSCBRCNT.HeaderText = "Brevete Conductor"
        Me.PSCBRCNT.Name = "PSCBRCNT"
        Me.PSCBRCNT.ReadOnly = True
        Me.PSCBRCNT.Width = 135
        '
        'TNMCMC
        '
        Me.TNMCMC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TNMCMC.DataPropertyName = "TNMCMC"
        Me.TNMCMC.HeaderText = "Conductor 1"
        Me.TNMCMC.Name = "TNMCMC"
        Me.TNMCMC.ReadOnly = True
        Me.TNMCMC.Width = 102
        '
        'CBRCN2
        '
        Me.CBRCN2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CBRCN2.DataPropertyName = "CBRCN2"
        Me.CBRCN2.HeaderText = "Brevete Conductor 2"
        Me.CBRCN2.Name = "CBRCN2"
        Me.CBRCN2.ReadOnly = True
        Me.CBRCN2.Width = 144
        '
        'TNMCMC2
        '
        Me.TNMCMC2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TNMCMC2.DataPropertyName = "TNMCMC2"
        Me.TNMCMC2.HeaderText = "Conductor 2"
        Me.TNMCMC2.Name = "TNMCMC2"
        Me.TNMCMC2.ReadOnly = True
        Me.TNMCMC2.Width = 102
        '
        'SESASG
        '
        Me.SESASG.DataPropertyName = "SESASG"
        Me.SESASG.HeaderText = "SESASG"
        Me.SESASG.Name = "SESASG"
        Me.SESASG.ReadOnly = True
        Me.SESASG.Visible = False
        Me.SESASG.Width = 76
        '
        'SESASG_D
        '
        Me.SESASG_D.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SESASG_D.DataPropertyName = "SESASG_D"
        Me.SESASG_D.HeaderText = "Estado"
        Me.SESASG_D.MinimumWidth = 50
        Me.SESASG_D.Name = "SESASG_D"
        Me.SESASG_D.ReadOnly = True
        Me.SESASG_D.Width = 71
        '
        'frmVerUnidadesProgramadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 266)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmVerUnidadesProgramadas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unidades Programadas"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.dgvPreAsignacion, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvPreAsignacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents NPLNJT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCRRPL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FPRASG_D As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOPRCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn120 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCRRPA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRUCTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMTRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLCUN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLCAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCBRCNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TNMCMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CBRCN2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TNMCMC2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESASG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESASG_D As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
