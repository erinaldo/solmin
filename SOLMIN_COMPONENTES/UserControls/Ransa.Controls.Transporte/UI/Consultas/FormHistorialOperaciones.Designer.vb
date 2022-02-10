<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHistorialOperaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHistorialOperaciones))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.dgwDocumentosEmitidos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NOPRCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NGUIRM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMTPD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NDCMFC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FECFAC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMTRF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QCNDTG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUNDSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ISRVGU = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TMNDA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.dgwDocumentosEmitidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1064, 348)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dgwDocumentosEmitidos)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(1064, 348)
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.Text = "Historial de Operaciones"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Historial de Operaciones"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup1.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'dgwDocumentosEmitidos
        '
        Me.dgwDocumentosEmitidos.AllowUserToAddRows = False
        Me.dgwDocumentosEmitidos.AllowUserToDeleteRows = False
        Me.dgwDocumentosEmitidos.AllowUserToResizeColumns = False
        Me.dgwDocumentosEmitidos.AllowUserToResizeRows = False
        Me.dgwDocumentosEmitidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgwDocumentosEmitidos.ColumnHeadersHeight = 25
        Me.dgwDocumentosEmitidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgwDocumentosEmitidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NOPRCN, Me.NGUIRM, Me.TCMTPD, Me.NDCMFC, Me.FECFAC, Me.TCMTRF, Me.QCNDTG, Me.CUNDSR, Me.ISRVGU, Me.TMNDA})
        Me.dgwDocumentosEmitidos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwDocumentosEmitidos.Location = New System.Drawing.Point(0, 0)
        Me.dgwDocumentosEmitidos.MultiSelect = False
        Me.dgwDocumentosEmitidos.Name = "dgwDocumentosEmitidos"
        Me.dgwDocumentosEmitidos.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.dgwDocumentosEmitidos.ReadOnly = True
        Me.dgwDocumentosEmitidos.RowHeadersVisible = False
        Me.dgwDocumentosEmitidos.RowHeadersWidth = 20
        Me.dgwDocumentosEmitidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwDocumentosEmitidos.Size = New System.Drawing.Size(1062, 295)
        Me.dgwDocumentosEmitidos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgwDocumentosEmitidos.TabIndex = 2
        '
        'NOPRCN
        '
        Me.NOPRCN.DataPropertyName = "NOPRCN"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NOPRCN.DefaultCellStyle = DataGridViewCellStyle1
        Me.NOPRCN.HeaderText = "Nro Operación"
        Me.NOPRCN.Name = "NOPRCN"
        Me.NOPRCN.ReadOnly = True
        Me.NOPRCN.Width = 114
        '
        'NGUIRM
        '
        Me.NGUIRM.DataPropertyName = "NGUIRM"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NGUIRM.DefaultCellStyle = DataGridViewCellStyle2
        Me.NGUIRM.HeaderText = "Guía Remisión"
        Me.NGUIRM.Name = "NGUIRM"
        Me.NGUIRM.ReadOnly = True
        Me.NGUIRM.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NGUIRM.Width = 112
        '
        'TCMTPD
        '
        Me.TCMTPD.DataPropertyName = "TCMTPD"
        Me.TCMTPD.HeaderText = "Tipo Documento"
        Me.TCMTPD.Name = "TCMTPD"
        Me.TCMTPD.ReadOnly = True
        Me.TCMTPD.Width = 126
        '
        'NDCMFC
        '
        Me.NDCMFC.DataPropertyName = "NDCMFC"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NDCMFC.DefaultCellStyle = DataGridViewCellStyle3
        Me.NDCMFC.HeaderText = "Nro Documento"
        Me.NDCMFC.Name = "NDCMFC"
        Me.NDCMFC.ReadOnly = True
        Me.NDCMFC.Width = 122
        '
        'FECFAC
        '
        Me.FECFAC.DataPropertyName = "FECFAC"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FECFAC.DefaultCellStyle = DataGridViewCellStyle4
        Me.FECFAC.HeaderText = "Fecha Documento"
        Me.FECFAC.Name = "FECFAC"
        Me.FECFAC.ReadOnly = True
        Me.FECFAC.Width = 133
        '
        'TCMTRF
        '
        Me.TCMTRF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TCMTRF.DataPropertyName = "TCMTRF"
        Me.TCMTRF.HeaderText = "Servicio"
        Me.TCMTRF.Name = "TCMTRF"
        Me.TCMTRF.ReadOnly = True
        '
        'QCNDTG
        '
        Me.QCNDTG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QCNDTG.DataPropertyName = "QCNDTG"
        Me.QCNDTG.HeaderText = "Cantidad"
        Me.QCNDTG.Name = "QCNDTG"
        Me.QCNDTG.ReadOnly = True
        Me.QCNDTG.Width = 84
        '
        'CUNDSR
        '
        Me.CUNDSR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CUNDSR.DataPropertyName = "CUNDSR"
        Me.CUNDSR.HeaderText = "Unidad"
        Me.CUNDSR.Name = "CUNDSR"
        Me.CUNDSR.ReadOnly = True
        Me.CUNDSR.Width = 74
        '
        'ISRVGU
        '
        Me.ISRVGU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ISRVGU.DataPropertyName = "ISRVGU"
        Me.ISRVGU.HeaderText = "Tarifa"
        Me.ISRVGU.Name = "ISRVGU"
        Me.ISRVGU.ReadOnly = True
        Me.ISRVGU.Width = 66
        '
        'TMNDA
        '
        Me.TMNDA.DataPropertyName = "TMNDA"
        Me.TMNDA.HeaderText = "Moneda"
        Me.TMNDA.Name = "TMNDA"
        Me.TMNDA.ReadOnly = True
        Me.TMNDA.Width = 80
        '
        'FormHistorialOperaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 348)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormHistorialOperaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial Operaciones"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.dgwDocumentosEmitidos, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents dgwDocumentosEmitidos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents NOPRCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NGUIRM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMTPD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NDCMFC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECFAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMTRF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QCNDTG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUNDSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ISRVGU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMNDA As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
