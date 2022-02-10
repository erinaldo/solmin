<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHistorialOperacion
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.TabDetalles = New System.Windows.Forms.TabControl
        Me.TabDocEmi = New System.Windows.Forms.TabPage
        Me.dtgServiciosOperacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.NOPRCN_SERV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TABTPD_SERV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NDCFCC_SERV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FDCCTC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NCRROP_SERV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRTFSV_SERV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DESTAR_SERV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUNDMD_SERV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QATNAN_SERV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TARIFA_SERV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MONTO_SERV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRRUBR_SERV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NCRRFC_SERV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCLNT_SERV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CTPODC_SERV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCLNFC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCMPN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CDVSN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TABTPD = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.TabDetalles.SuspendLayout()
        Me.TabDocEmi.SuspendLayout()
        CType(Me.dtgServiciosOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.TabDetalles)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(875, 310)
        Me.KryptonPanel.TabIndex = 0
        '
        'TabDetalles
        '
        Me.TabDetalles.Controls.Add(Me.TabDocEmi)
        Me.TabDetalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabDetalles.Location = New System.Drawing.Point(0, 0)
        Me.TabDetalles.Name = "TabDetalles"
        Me.TabDetalles.SelectedIndex = 0
        Me.TabDetalles.Size = New System.Drawing.Size(875, 310)
        Me.TabDetalles.TabIndex = 4
        '
        'TabDocEmi
        '
        Me.TabDocEmi.Controls.Add(Me.dtgServiciosOperacion)
        Me.TabDocEmi.Location = New System.Drawing.Point(4, 22)
        Me.TabDocEmi.Name = "TabDocEmi"
        Me.TabDocEmi.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDocEmi.Size = New System.Drawing.Size(867, 284)
        Me.TabDocEmi.TabIndex = 3
        Me.TabDocEmi.Text = "Documentos Emitidos x Operación"
        Me.TabDocEmi.UseVisualStyleBackColor = True
        '
        'dtgServiciosOperacion
        '
        Me.dtgServiciosOperacion.AllowUserToAddRows = False
        Me.dtgServiciosOperacion.AllowUserToDeleteRows = False
        Me.dtgServiciosOperacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgServiciosOperacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NOPRCN_SERV, Me.TABTPD_SERV, Me.NDCFCC_SERV, Me.FDCCTC, Me.NCRROP_SERV, Me.NRTFSV_SERV, Me.DESTAR_SERV, Me.CUNDMD_SERV, Me.QATNAN_SERV, Me.TARIFA_SERV, Me.MONTO_SERV, Me.NRRUBR_SERV, Me.NCRRFC_SERV, Me.CCLNT_SERV, Me.CTPODC_SERV, Me.CCLNT, Me.CCLNFC, Me.CCMPN, Me.CDVSN, Me.TABTPD})
        Me.dtgServiciosOperacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgServiciosOperacion.Location = New System.Drawing.Point(3, 3)
        Me.dtgServiciosOperacion.Name = "dtgServiciosOperacion"
        Me.dtgServiciosOperacion.ReadOnly = True
        Me.dtgServiciosOperacion.RowHeadersWidth = 5
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.dtgServiciosOperacion.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dtgServiciosOperacion.Size = New System.Drawing.Size(861, 278)
        Me.dtgServiciosOperacion.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dtgServiciosOperacion.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgServiciosOperacion.TabIndex = 4
        '
        'NOPRCN_SERV
        '
        Me.NOPRCN_SERV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NOPRCN_SERV.DataPropertyName = "NOPRCN"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NOPRCN_SERV.DefaultCellStyle = DataGridViewCellStyle1
        Me.NOPRCN_SERV.HeaderText = "Operación"
        Me.NOPRCN_SERV.Name = "NOPRCN_SERV"
        Me.NOPRCN_SERV.ReadOnly = True
        Me.NOPRCN_SERV.Width = 90
        '
        'TABTPD_SERV
        '
        Me.TABTPD_SERV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TABTPD_SERV.DataPropertyName = "TABTPD"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TABTPD_SERV.DefaultCellStyle = DataGridViewCellStyle2
        Me.TABTPD_SERV.HeaderText = "Tipo Doc."
        Me.TABTPD_SERV.Name = "TABTPD_SERV"
        Me.TABTPD_SERV.ReadOnly = True
        Me.TABTPD_SERV.Width = 70
        '
        'NDCFCC_SERV
        '
        Me.NDCFCC_SERV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NDCFCC_SERV.DataPropertyName = "NDCFCC"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NDCFCC_SERV.DefaultCellStyle = DataGridViewCellStyle3
        Me.NDCFCC_SERV.HeaderText = "Documento"
        Me.NDCFCC_SERV.Name = "NDCFCC_SERV"
        Me.NDCFCC_SERV.ReadOnly = True
        Me.NDCFCC_SERV.Width = 96
        '
        'FDCCTC
        '
        Me.FDCCTC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FDCCTC.DataPropertyName = "FDCCTC"
        Me.FDCCTC.HeaderText = "Fecha Doc"
        Me.FDCCTC.Name = "FDCCTC"
        Me.FDCCTC.ReadOnly = True
        Me.FDCCTC.Width = 83
        '
        'NCRROP_SERV
        '
        Me.NCRROP_SERV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.NCRROP_SERV.DataPropertyName = "NCRROP"
        Me.NCRROP_SERV.HeaderText = "Corr."
        Me.NCRROP_SERV.Name = "NCRROP_SERV"
        Me.NCRROP_SERV.ReadOnly = True
        Me.NCRROP_SERV.Width = 40
        '
        'NRTFSV_SERV
        '
        Me.NRTFSV_SERV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.NRTFSV_SERV.DataPropertyName = "NRTFSV"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NRTFSV_SERV.DefaultCellStyle = DataGridViewCellStyle4
        Me.NRTFSV_SERV.HeaderText = "Cod Tarifa"
        Me.NRTFSV_SERV.Name = "NRTFSV_SERV"
        Me.NRTFSV_SERV.ReadOnly = True
        Me.NRTFSV_SERV.Width = 70
        '
        'DESTAR_SERV
        '
        Me.DESTAR_SERV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DESTAR_SERV.DataPropertyName = "DESTAR"
        Me.DESTAR_SERV.HeaderText = "Servicio"
        Me.DESTAR_SERV.Name = "DESTAR_SERV"
        Me.DESTAR_SERV.ReadOnly = True
        Me.DESTAR_SERV.Width = 75
        '
        'CUNDMD_SERV
        '
        Me.CUNDMD_SERV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CUNDMD_SERV.DataPropertyName = "CUNDMD"
        Me.CUNDMD_SERV.HeaderText = "Unidad"
        Me.CUNDMD_SERV.Name = "CUNDMD_SERV"
        Me.CUNDMD_SERV.ReadOnly = True
        Me.CUNDMD_SERV.Width = 74
        '
        'QATNAN_SERV
        '
        Me.QATNAN_SERV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QATNAN_SERV.DataPropertyName = "QATNAN"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N5"
        DataGridViewCellStyle5.NullValue = "0"
        Me.QATNAN_SERV.DefaultCellStyle = DataGridViewCellStyle5
        Me.QATNAN_SERV.HeaderText = "Cantidad"
        Me.QATNAN_SERV.Name = "QATNAN_SERV"
        Me.QATNAN_SERV.ReadOnly = True
        Me.QATNAN_SERV.Width = 83
        '
        'TARIFA_SERV
        '
        Me.TARIFA_SERV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TARIFA_SERV.DataPropertyName = "IVLSRV"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N5"
        DataGridViewCellStyle6.NullValue = "0"
        Me.TARIFA_SERV.DefaultCellStyle = DataGridViewCellStyle6
        Me.TARIFA_SERV.HeaderText = "Valor Tarifa"
        Me.TARIFA_SERV.Name = "TARIFA_SERV"
        Me.TARIFA_SERV.ReadOnly = True
        Me.TARIFA_SERV.Width = 87
        '
        'MONTO_SERV
        '
        Me.MONTO_SERV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MONTO_SERV.DataPropertyName = "MONTO"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N5"
        DataGridViewCellStyle7.NullValue = "0"
        Me.MONTO_SERV.DefaultCellStyle = DataGridViewCellStyle7
        Me.MONTO_SERV.HeaderText = "Importe Tarifa"
        Me.MONTO_SERV.Name = "MONTO_SERV"
        Me.MONTO_SERV.ReadOnly = True
        Me.MONTO_SERV.Width = 99
        '
        'NRRUBR_SERV
        '
        Me.NRRUBR_SERV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRRUBR_SERV.DataPropertyName = "NRRUBR"
        Me.NRRUBR_SERV.HeaderText = "NRRUBR"
        Me.NRRUBR_SERV.Name = "NRRUBR_SERV"
        Me.NRRUBR_SERV.ReadOnly = True
        Me.NRRUBR_SERV.Visible = False
        Me.NRRUBR_SERV.Width = 80
        '
        'NCRRFC_SERV
        '
        Me.NCRRFC_SERV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NCRRFC_SERV.DataPropertyName = "NCRRFC"
        Me.NCRRFC_SERV.HeaderText = "Corr. Doc."
        Me.NCRRFC_SERV.Name = "NCRRFC_SERV"
        Me.NCRRFC_SERV.ReadOnly = True
        Me.NCRRFC_SERV.Visible = False
        Me.NCRRFC_SERV.Width = 81
        '
        'CCLNT_SERV
        '
        Me.CCLNT_SERV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CCLNT_SERV.DataPropertyName = "CCLNT"
        Me.CCLNT_SERV.HeaderText = "CCLNT_SERV"
        Me.CCLNT_SERV.Name = "CCLNT_SERV"
        Me.CCLNT_SERV.ReadOnly = True
        Me.CCLNT_SERV.Visible = False
        Me.CCLNT_SERV.Width = 99
        '
        'CTPODC_SERV
        '
        Me.CTPODC_SERV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CTPODC_SERV.DataPropertyName = "CTPODC"
        Me.CTPODC_SERV.HeaderText = "CTPODC"
        Me.CTPODC_SERV.Name = "CTPODC_SERV"
        Me.CTPODC_SERV.ReadOnly = True
        Me.CTPODC_SERV.Visible = False
        Me.CTPODC_SERV.Width = 78
        '
        'CCLNT
        '
        Me.CCLNT.DataPropertyName = "CCLNT"
        Me.CCLNT.HeaderText = "CCLNT"
        Me.CCLNT.Name = "CCLNT"
        Me.CCLNT.ReadOnly = True
        Me.CCLNT.Visible = False
        '
        'CCLNFC
        '
        Me.CCLNFC.DataPropertyName = "CCLNFC"
        Me.CCLNFC.HeaderText = "CCLNFC"
        Me.CCLNFC.Name = "CCLNFC"
        Me.CCLNFC.ReadOnly = True
        Me.CCLNFC.Visible = False
        '
        'CCMPN
        '
        Me.CCMPN.DataPropertyName = "CCMPN"
        Me.CCMPN.HeaderText = "CCMPN"
        Me.CCMPN.Name = "CCMPN"
        Me.CCMPN.ReadOnly = True
        Me.CCMPN.Visible = False
        '
        'CDVSN
        '
        Me.CDVSN.DataPropertyName = "CDVSN"
        Me.CDVSN.HeaderText = "CDVSN"
        Me.CDVSN.Name = "CDVSN"
        Me.CDVSN.ReadOnly = True
        Me.CDVSN.Visible = False
        '
        'TABTPD
        '
        Me.TABTPD.DataPropertyName = "TABTPD"
        Me.TABTPD.HeaderText = "TABTPD"
        Me.TABTPD.Name = "TABTPD"
        Me.TABTPD.ReadOnly = True
        Me.TABTPD.Visible = False
        '
        'FrmHistorialOperacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 310)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "FrmHistorialOperacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Historial Operaciones"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.TabDetalles.ResumeLayout(False)
        Me.TabDocEmi.ResumeLayout(False)
        CType(Me.dtgServiciosOperacion, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TabDetalles As System.Windows.Forms.TabControl
    Friend WithEvents TabDocEmi As System.Windows.Forms.TabPage
    Friend WithEvents dtgServiciosOperacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents NOPRCN_SERV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TABTPD_SERV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NDCFCC_SERV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FDCCTC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCRROP_SERV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRTFSV_SERV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESTAR_SERV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUNDMD_SERV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QATNAN_SERV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TARIFA_SERV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MONTO_SERV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRRUBR_SERV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCRRFC_SERV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNT_SERV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTPODC_SERV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNFC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCMPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CDVSN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TABTPD As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
