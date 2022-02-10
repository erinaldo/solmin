<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSDSWConsultaVehiculo_Temporal
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
        Me.hgConsulta = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.dgvVehiculos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NCHSVHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TMARCADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TMDLODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CALMCMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CALMAUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FECESTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ORIGENDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DESTINODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ESTADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dstVehiculos = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.VNCHSVH = New System.Data.DataColumn
        Me.VTMARCA = New System.Data.DataColumn
        Me.VTMDLO = New System.Data.DataColumn
        Me.VCALMCM = New System.Data.DataColumn
        Me.VCALMAU = New System.Data.DataColumn
        Me.VFINMOV = New System.Data.DataColumn
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.hgConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgConsulta.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgConsulta.Panel.SuspendLayout()
        Me.hgConsulta.SuspendLayout()
        CType(Me.dgvVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.hgConsulta)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(752, 475)
        Me.KryptonPanel.TabIndex = 0
        '
        'hgConsulta
        '
        Me.hgConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgConsulta.Location = New System.Drawing.Point(0, 0)
        Me.hgConsulta.Name = "hgConsulta"
        '
        'hgConsulta.Panel
        '
        Me.hgConsulta.Panel.Controls.Add(Me.dgvVehiculos)
        Me.hgConsulta.Size = New System.Drawing.Size(752, 475)
        Me.hgConsulta.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgConsulta.TabIndex = 2
        Me.hgConsulta.Text = "Consulta"
        Me.hgConsulta.ValuesPrimary.Description = ""
        Me.hgConsulta.ValuesPrimary.Heading = "Consulta"
        '   Me.hgConsulta.ValuesPrimary.Image = Global.SOLMIN_SA.My.Resources.Resources.clipboard_list
        Me.hgConsulta.ValuesSecondary.Description = ""
        Me.hgConsulta.ValuesSecondary.Heading = ""
        Me.hgConsulta.ValuesSecondary.Image = Nothing
        '
        'dgvVehiculos
        '
        Me.dgvVehiculos.AllowUserToAddRows = False
        Me.dgvVehiculos.AllowUserToDeleteRows = False
        Me.dgvVehiculos.AllowUserToResizeRows = False
        Me.dgvVehiculos.AutoGenerateColumns = False
        Me.dgvVehiculos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NCHSVHDataGridViewTextBoxColumn, Me.TMARCADataGridViewTextBoxColumn, Me.TMDLODataGridViewTextBoxColumn, Me.CALMCMDataGridViewTextBoxColumn, Me.CALMAUDataGridViewTextBoxColumn, Me.FECESTDataGridViewTextBoxColumn, Me.ORIGENDataGridViewTextBoxColumn, Me.DESTINODataGridViewTextBoxColumn, Me.ESTADODataGridViewTextBoxColumn})
        Me.dgvVehiculos.DataMember = "Vehiculo"
        Me.dgvVehiculos.DataSource = Me.dstVehiculos
        Me.dgvVehiculos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvVehiculos.Location = New System.Drawing.Point(0, 0)
        Me.dgvVehiculos.MultiSelect = False
        Me.dgvVehiculos.Name = "dgvVehiculos"
        Me.dgvVehiculos.ReadOnly = True
        Me.dgvVehiculos.RowHeadersWidth = 20
        Me.dgvVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVehiculos.Size = New System.Drawing.Size(750, 450)
        Me.dgvVehiculos.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgvVehiculos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvVehiculos.TabIndex = 0
        '
        'NCHSVHDataGridViewTextBoxColumn
        '
        Me.NCHSVHDataGridViewTextBoxColumn.DataPropertyName = "NCHSVH"
        Me.NCHSVHDataGridViewTextBoxColumn.HeaderText = "VIN"
        Me.NCHSVHDataGridViewTextBoxColumn.Name = "NCHSVHDataGridViewTextBoxColumn"
        Me.NCHSVHDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TMARCADataGridViewTextBoxColumn
        '
        Me.TMARCADataGridViewTextBoxColumn.DataPropertyName = "TMARCA"
        Me.TMARCADataGridViewTextBoxColumn.HeaderText = "TMARCA"
        Me.TMARCADataGridViewTextBoxColumn.Name = "TMARCADataGridViewTextBoxColumn"
        Me.TMARCADataGridViewTextBoxColumn.ReadOnly = True
        Me.TMARCADataGridViewTextBoxColumn.Visible = False
        '
        'TMDLODataGridViewTextBoxColumn
        '
        Me.TMDLODataGridViewTextBoxColumn.DataPropertyName = "TMDLO"
        Me.TMDLODataGridViewTextBoxColumn.HeaderText = "TMDLO"
        Me.TMDLODataGridViewTextBoxColumn.Name = "TMDLODataGridViewTextBoxColumn"
        Me.TMDLODataGridViewTextBoxColumn.ReadOnly = True
        Me.TMDLODataGridViewTextBoxColumn.Visible = False
        '
        'CALMCMDataGridViewTextBoxColumn
        '
        Me.CALMCMDataGridViewTextBoxColumn.DataPropertyName = "CALMCM"
        Me.CALMCMDataGridViewTextBoxColumn.HeaderText = "Codigo de Almacen"
        Me.CALMCMDataGridViewTextBoxColumn.Name = "CALMCMDataGridViewTextBoxColumn"
        Me.CALMCMDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CALMAUDataGridViewTextBoxColumn
        '
        Me.CALMAUDataGridViewTextBoxColumn.DataPropertyName = "CALMAU"
        Me.CALMAUDataGridViewTextBoxColumn.HeaderText = "CALMAU"
        Me.CALMAUDataGridViewTextBoxColumn.Name = "CALMAUDataGridViewTextBoxColumn"
        Me.CALMAUDataGridViewTextBoxColumn.ReadOnly = True
        Me.CALMAUDataGridViewTextBoxColumn.Visible = False
        '
        'FECESTDataGridViewTextBoxColumn
        '
        Me.FECESTDataGridViewTextBoxColumn.DataPropertyName = "FECEST"
        Me.FECESTDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FECESTDataGridViewTextBoxColumn.Name = "FECESTDataGridViewTextBoxColumn"
        Me.FECESTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ORIGENDataGridViewTextBoxColumn
        '
        Me.ORIGENDataGridViewTextBoxColumn.DataPropertyName = "ORIGEN"
        Me.ORIGENDataGridViewTextBoxColumn.HeaderText = "ORIGEN"
        Me.ORIGENDataGridViewTextBoxColumn.Name = "ORIGENDataGridViewTextBoxColumn"
        Me.ORIGENDataGridViewTextBoxColumn.ReadOnly = True
        Me.ORIGENDataGridViewTextBoxColumn.Visible = False
        '
        'DESTINODataGridViewTextBoxColumn
        '
        Me.DESTINODataGridViewTextBoxColumn.DataPropertyName = "DESTINO"
        Me.DESTINODataGridViewTextBoxColumn.HeaderText = "Destino"
        Me.DESTINODataGridViewTextBoxColumn.Name = "DESTINODataGridViewTextBoxColumn"
        Me.DESTINODataGridViewTextBoxColumn.ReadOnly = True
        '
        'ESTADODataGridViewTextBoxColumn
        '
        Me.ESTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO"
        Me.ESTADODataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.ESTADODataGridViewTextBoxColumn.Name = "ESTADODataGridViewTextBoxColumn"
        Me.ESTADODataGridViewTextBoxColumn.ReadOnly = True
        '
        'dstVehiculos
        '
        Me.dstVehiculos.DataSetName = "NewDataSet"
        Me.dstVehiculos.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.VNCHSVH, Me.VTMARCA, Me.VTMDLO, Me.VCALMCM, Me.VCALMAU, Me.VFINMOV, Me.DataColumn1, Me.DataColumn2, Me.DataColumn3})
        Me.DataTable1.TableName = "Vehiculo"
        '
        'VNCHSVH
        '
        Me.VNCHSVH.ColumnName = "NCHSVH"
        '
        'VTMARCA
        '
        Me.VTMARCA.ColumnName = "TMARCA"
        '
        'VTMDLO
        '
        Me.VTMDLO.ColumnName = "TMDLO"
        '
        'VCALMCM
        '
        Me.VCALMCM.ColumnName = "CALMCM"
        '
        'VCALMAU
        '
        Me.VCALMAU.ColumnName = "CALMAU"
        '
        'VFINMOV
        '
        Me.VFINMOV.Caption = "FECEST"
        Me.VFINMOV.ColumnName = "FECEST"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "ORIGEN"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "DESTINO"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "ESTADO"
        '
        'frmConsultaVehiculo_Temporal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 475)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmConsultaVehiculo_Temporal"
        Me.Text = "Consulta"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.hgConsulta.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgConsulta.Panel.ResumeLayout(False)
        CType(Me.hgConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgConsulta.ResumeLayout(False)
        CType(Me.dgvVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents hgConsulta As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents dgvVehiculos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dstVehiculos As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents VNCHSVH As System.Data.DataColumn
    Friend WithEvents VTMARCA As System.Data.DataColumn
    Friend WithEvents VTMDLO As System.Data.DataColumn
    Friend WithEvents VCALMCM As System.Data.DataColumn
    Friend WithEvents VCALMAU As System.Data.DataColumn
    Friend WithEvents VFINMOV As System.Data.DataColumn
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents NCHSVHDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMARCADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMDLODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CALMCMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CALMAUDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECESTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ORIGENDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESTINODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTADODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
