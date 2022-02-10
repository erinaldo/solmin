<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubItemEnAlmacen
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dstSubItemOC = New System.Data.DataSet
        Me.dtItemOC = New System.Data.DataTable
        Me.NRITOC = New System.Data.DataColumn
        Me.TCITCL = New System.Data.DataColumn
        Me.TCITPR = New System.Data.DataColumn
        Me.TDITES = New System.Data.DataColumn
        Me.TDITIN = New System.Data.DataColumn
        Me.CPTDAR = New System.Data.DataColumn
        Me.QCNTIT = New System.Data.DataColumn
        Me.TUNDIT = New System.Data.DataColumn
        Me.IVUNIT = New System.Data.DataColumn
        Me.IVTOIT = New System.Data.DataColumn
        Me.QTOLMAX = New System.Data.DataColumn
        Me.QTOLMIN = New System.Data.DataColumn
        Me.FMPDME = New System.Data.DataColumn
        Me.FMPIME = New System.Data.DataColumn
        Me.TLUGOR = New System.Data.DataColumn
        Me.TLUGEN = New System.Data.DataColumn
        Me.QCNPEN = New System.Data.DataColumn
        Me.DataColumn1 = New System.Data.DataColumn
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KryptonManager1 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.UcSubItemOcEnAlmacen_DgF = New Ransa.Controls.OrdenCompra.ucSubItemOcEnAlmacen_DgF01
        CType(Me.dstSubItemOC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtItemOC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'dstSubItemOC
        '
        Me.dstSubItemOC.DataSetName = "dstOrdenCompra"
        Me.dstSubItemOC.RemotingFormat = System.Data.SerializationFormat.Binary
        Me.dstSubItemOC.Tables.AddRange(New System.Data.DataTable() {Me.dtItemOC})
        '
        'dtItemOC
        '
        Me.dtItemOC.Columns.AddRange(New System.Data.DataColumn() {Me.NRITOC, Me.TCITCL, Me.TCITPR, Me.TDITES, Me.TDITIN, Me.CPTDAR, Me.QCNTIT, Me.TUNDIT, Me.IVUNIT, Me.IVTOIT, Me.QTOLMAX, Me.QTOLMIN, Me.FMPDME, Me.FMPIME, Me.TLUGOR, Me.TLUGEN, Me.QCNPEN, Me.DataColumn1})
        Me.dtItemOC.RemotingFormat = System.Data.SerializationFormat.Binary
        Me.dtItemOC.TableName = "dtItemOC"
        '
        'NRITOC
        '
        Me.NRITOC.ColumnName = "NRITOC"
        Me.NRITOC.DataType = GetType(Integer)
        Me.NRITOC.DefaultValue = 0
        '
        'TCITCL
        '
        Me.TCITCL.ColumnName = "TCITCL"
        Me.TCITCL.DefaultValue = ""
        '
        'TCITPR
        '
        Me.TCITPR.ColumnName = "TCITPR"
        Me.TCITPR.DefaultValue = ""
        '
        'TDITES
        '
        Me.TDITES.ColumnName = "TDITES"
        Me.TDITES.DefaultValue = ""
        '
        'TDITIN
        '
        Me.TDITIN.ColumnName = "TDITIN"
        '
        'CPTDAR
        '
        Me.CPTDAR.ColumnName = "CPTDAR"
        Me.CPTDAR.DefaultValue = ""
        '
        'QCNTIT
        '
        Me.QCNTIT.ColumnName = "QCNTIT"
        Me.QCNTIT.DataType = GetType(Decimal)
        Me.QCNTIT.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'TUNDIT
        '
        Me.TUNDIT.ColumnName = "TUNDIT"
        Me.TUNDIT.DefaultValue = ""
        '
        'IVUNIT
        '
        Me.IVUNIT.ColumnName = "IVUNIT"
        Me.IVUNIT.DataType = GetType(Decimal)
        Me.IVUNIT.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'IVTOIT
        '
        Me.IVTOIT.ColumnName = "IVTOIT"
        Me.IVTOIT.DataType = GetType(Decimal)
        Me.IVTOIT.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'QTOLMAX
        '
        Me.QTOLMAX.ColumnName = "QTOLMAX"
        Me.QTOLMAX.DataType = GetType(Decimal)
        Me.QTOLMAX.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'QTOLMIN
        '
        Me.QTOLMIN.ColumnName = "QTOLMIN"
        Me.QTOLMIN.DataType = GetType(Decimal)
        Me.QTOLMIN.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'FMPDME
        '
        Me.FMPDME.ColumnName = "FMPDME"
        Me.FMPDME.DataType = GetType(Date)
        '
        'FMPIME
        '
        Me.FMPIME.ColumnName = "FMPIME"
        Me.FMPIME.DataType = GetType(Date)
        '
        'TLUGOR
        '
        Me.TLUGOR.ColumnName = "TLUGOR"
        Me.TLUGOR.DefaultValue = ""
        '
        'TLUGEN
        '
        Me.TLUGEN.ColumnName = "TLUGEN"
        Me.TLUGEN.DefaultValue = ""
        '
        'QCNPEN
        '
        Me.QCNPEN.ColumnName = "QCNPEN"
        Me.QCNPEN.DataType = GetType(Decimal)
        Me.QCNPEN.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "SBITOC"
        Me.DataColumn1.DefaultValue = ""
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NRITOC"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Item"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 78
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "SBITOC"
        Me.DataGridViewTextBoxColumn2.HeaderText = "SubItem"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 78
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "IVTOIT"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "N2"
        DataGridViewCellStyle13.NullValue = "0.00"
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn14.HeaderText = "Imp. Total"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TCITCL"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cód. Cliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "QTOLMAX"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "N2"
        DataGridViewCellStyle14.NullValue = "0.00"
        Me.DataGridViewTextBoxColumn15.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn15.HeaderText = "Tolerancia Máx."
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "IVUNIT"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "N2"
        DataGridViewCellStyle15.NullValue = "0.00"
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn13.HeaderText = "Imp. Unitario"
        Me.DataGridViewTextBoxColumn13.MaxInputLength = 10
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "QTOLMIN"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Format = "N2"
        DataGridViewCellStyle16.NullValue = "0.00"
        Me.DataGridViewTextBoxColumn16.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn16.HeaderText = "Tolerancia Mín."
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "NORCML"
        Me.DataGridViewTextBoxColumn19.HeaderText = "NORCML"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "QTOLMIN"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle17.Format = "N2"
        DataGridViewCellStyle17.NullValue = "0.00"
        Me.DataGridViewTextBoxColumn17.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn17.HeaderText = "Tolerancia Mín."
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "TDAITM"
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn12.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn12.MaxInputLength = 300
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "CREFFW"
        Me.DataGridViewTextBoxColumn18.HeaderText = "CREFFW"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TDITES"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "QVOPQT"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle19.Format = "N2"
        DataGridViewCellStyle19.NullValue = "0.00"
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridViewTextBoxColumn11.HeaderText = "Volumen"
        Me.DataGridViewTextBoxColumn11.MaxInputLength = 10
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "QCNTIT"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle20.Format = "N2"
        DataGridViewCellStyle20.NullValue = "0.00"
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TCITPR"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cód. Proveedor"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TUNDIT"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle21.Format = "N2"
        DataGridViewCellStyle21.NullValue = "0.00"
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle21
        Me.DataGridViewTextBoxColumn7.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "QPEPQT"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle22.Format = "N2"
        DataGridViewCellStyle22.NullValue = "0.00"
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle22
        Me.DataGridViewTextBoxColumn10.HeaderText = "Peso"
        Me.DataGridViewTextBoxColumn10.MaxInputLength = 10
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "QCNPEN"
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle23.Format = "N2"
        DataGridViewCellStyle23.NullValue = "0.00"
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle23
        Me.DataGridViewTextBoxColumn8.HeaderText = "Cant. Pendiente"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "QCNREC"
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle24.Format = "N2"
        DataGridViewCellStyle24.NullValue = "0.00"
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle24
        Me.DataGridViewTextBoxColumn9.HeaderText = "Cant. Recibida"
        Me.DataGridViewTextBoxColumn9.MaxInputLength = 10
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "CCLNT"
        Me.DataGridViewTextBoxColumn20.HeaderText = "CCLNT"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Visible = False
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.UcSubItemOcEnAlmacen_DgF)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(692, 216)
        Me.KryptonPanel.TabIndex = 0
        '
        'UcSubItemOcEnAlmacen_DgF
        '
        Me.UcSubItemOcEnAlmacen_DgF.Agregar = True
        Me.UcSubItemOcEnAlmacen_DgF.BackColor = System.Drawing.Color.Transparent
        Me.UcSubItemOcEnAlmacen_DgF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcSubItemOcEnAlmacen_DgF.Eliminar = True
        Me.UcSubItemOcEnAlmacen_DgF.Location = New System.Drawing.Point(0, 0)
        Me.UcSubItemOcEnAlmacen_DgF.Name = "UcSubItemOcEnAlmacen_DgF"
        Me.UcSubItemOcEnAlmacen_DgF.Size = New System.Drawing.Size(692, 216)
        Me.UcSubItemOcEnAlmacen_DgF.TabIndex = 0
        '
        'frmSubItemEnAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 216)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(700, 250)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(700, 250)
        Me.Name = "frmSubItemEnAlmacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SubItems En Almacén"
        CType(Me.dstSubItemOC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtItemOC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
  Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
  End Sub
  Private WithEvents dstSubItemOC As System.Data.DataSet
  Private WithEvents dtItemOC As System.Data.DataTable
  Private WithEvents NRITOC As System.Data.DataColumn
  Private WithEvents TCITCL As System.Data.DataColumn
  Private WithEvents TCITPR As System.Data.DataColumn
  Private WithEvents TDITES As System.Data.DataColumn
  Private WithEvents TDITIN As System.Data.DataColumn
  Private WithEvents CPTDAR As System.Data.DataColumn
  Private WithEvents QCNTIT As System.Data.DataColumn
  Private WithEvents TUNDIT As System.Data.DataColumn
  Private WithEvents IVUNIT As System.Data.DataColumn
  Private WithEvents IVTOIT As System.Data.DataColumn
  Private WithEvents QTOLMAX As System.Data.DataColumn
  Private WithEvents QTOLMIN As System.Data.DataColumn
  Private WithEvents FMPDME As System.Data.DataColumn
  Private WithEvents FMPIME As System.Data.DataColumn
  Private WithEvents TLUGOR As System.Data.DataColumn
  Private WithEvents TLUGEN As System.Data.DataColumn
  Private WithEvents QCNPEN As System.Data.DataColumn
  Friend WithEvents DataColumn1 As System.Data.DataColumn
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
  Private WithEvents KryptonManager1 As ComponentFactory.Krypton.Toolkit.KryptonManager
  Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
  Friend WithEvents UcSubItemOcEnAlmacen_DgF011 As Ransa.Controls.OrdenCompra.ucSubItemOcEnAlmacen_DgF01
  Friend WithEvents UcSubItemOcEnAlmacen_DgF As Ransa.Controls.OrdenCompra.ucSubItemOcEnAlmacen_DgF01
End Class
