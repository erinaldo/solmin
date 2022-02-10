<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompararOC
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
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.TxtRutaCabecera = New System.Windows.Forms.ToolStripTextBox
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbBuscarArchivo = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbBitacora = New System.Windows.Forms.ToolStripButton
        Me.spcComparativo = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.dtgOCArchivoExcel = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EXISTE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgOcSeguimiento = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NORCML = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRITOC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDITES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNQCNTIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TUNDIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TTINTC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ExisteBitacora = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.spcComparativo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spcComparativo.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcComparativo.Panel1.SuspendLayout()
        CType(Me.spcComparativo.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcComparativo.Panel2.SuspendLayout()
        Me.spcComparativo.SuspendLayout()
        CType(Me.dtgOCArchivoExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgOcSeguimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.ToolStrip2)
        Me.KryptonPanel.Controls.Add(Me.spcComparativo)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1082, 499)
        Me.KryptonPanel.TabIndex = 0
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.TxtRutaCabecera, Me.tsbGuardar, Me.ToolStripSeparator1, Me.tsbBuscarArchivo, Me.ToolStripSeparator2, Me.ToolStripSeparator3, Me.tsbBitacora})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1082, 25)
        Me.ToolStrip2.TabIndex = 36
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(114, 22)
        Me.ToolStripLabel1.Text = "Nombre del Archivo :"
        '
        'TxtRutaCabecera
        '
        Me.TxtRutaCabecera.Name = "TxtRutaCabecera"
        Me.TxtRutaCabecera.Size = New System.Drawing.Size(200, 25)
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbGuardar.Enabled = False
        Me.tsbGuardar.Image = Global.SOLMIN_SC.My.Resources.Resources.agt_update_product
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(70, 22)
        Me.tsbGuardar.Text = "&Procesar"
        Me.tsbGuardar.ToolTipText = "Procesar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbBuscarArchivo
        '
        Me.tsbBuscarArchivo.Image = Global.SOLMIN_SC.My.Resources.Resources.excelicon
        Me.tsbBuscarArchivo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBuscarArchivo.Name = "tsbBuscarArchivo"
        Me.tsbBuscarArchivo.Size = New System.Drawing.Size(102, 22)
        Me.tsbBuscarArchivo.Text = "Cargar Archivo"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tsbBitacora
        '
        Me.tsbBitacora.Image = Global.SOLMIN_SC.My.Resources.Resources.Enviado
        Me.tsbBitacora.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBitacora.Name = "tsbBitacora"
        Me.tsbBitacora.Size = New System.Drawing.Size(106, 22)
        Me.tsbBitacora.Text = "Cargar Archivo"
        Me.tsbBitacora.Visible = False
        '
        'spcComparativo
        '
        Me.spcComparativo.Cursor = System.Windows.Forms.Cursors.Default
        Me.spcComparativo.Location = New System.Drawing.Point(0, 28)
        Me.spcComparativo.Name = "spcComparativo"
        '
        'spcComparativo.Panel1
        '
        Me.spcComparativo.Panel1.Controls.Add(Me.dtgOCArchivoExcel)
        '
        'spcComparativo.Panel2
        '
        Me.spcComparativo.Panel2.Controls.Add(Me.dgOcSeguimiento)
        Me.spcComparativo.Size = New System.Drawing.Size(1079, 471)
        Me.spcComparativo.SplitterDistance = 247
        Me.spcComparativo.TabIndex = 34
        '
        'dtgOCArchivoExcel
        '
        Me.dtgOCArchivoExcel.AllowUserToAddRows = False
        Me.dtgOCArchivoExcel.AllowUserToDeleteRows = False
        Me.dtgOCArchivoExcel.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.EXISTE, Me.Column2})
        Me.dtgOCArchivoExcel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgOCArchivoExcel.Location = New System.Drawing.Point(0, 0)
        Me.dtgOCArchivoExcel.Name = "dtgOCArchivoExcel"
        Me.dtgOCArchivoExcel.ReadOnly = True
        Me.dtgOCArchivoExcel.RowHeadersWidth = 15
        Me.dtgOCArchivoExcel.Size = New System.Drawing.Size(247, 471)
        Me.dtgOCArchivoExcel.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dtgOCArchivoExcel.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgOCArchivoExcel.TabIndex = 35
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PSNORCML"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Orden Compra"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PNNRITOC"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn2.HeaderText = "N° Item"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'EXISTE
        '
        Me.EXISTE.HeaderText = "Existe en Sistema"
        Me.EXISTE.Name = "EXISTE"
        Me.EXISTE.ReadOnly = True
        Me.EXISTE.Visible = False
        Me.EXISTE.Width = 120
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = " "
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'dgOcSeguimiento
        '
        Me.dgOcSeguimiento.AllowUserToAddRows = False
        Me.dgOcSeguimiento.AllowUserToDeleteRows = False
        Me.dgOcSeguimiento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NORCML, Me.NRITOC, Me.TDITES, Me.PNQCNTIT, Me.TUNDIT, Me.TTINTC, Me.ExisteBitacora, Me.Column1})
        Me.dgOcSeguimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgOcSeguimiento.Location = New System.Drawing.Point(0, 0)
        Me.dgOcSeguimiento.Name = "dgOcSeguimiento"
        Me.dgOcSeguimiento.ReadOnly = True
        Me.dgOcSeguimiento.RowHeadersWidth = 15
        Me.dgOcSeguimiento.Size = New System.Drawing.Size(827, 471)
        Me.dgOcSeguimiento.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgOcSeguimiento.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgOcSeguimiento.TabIndex = 34
        '
        'NORCML
        '
        Me.NORCML.DataPropertyName = "PSNORCML"
        Me.NORCML.HeaderText = "Orden Compra"
        Me.NORCML.Name = "NORCML"
        Me.NORCML.ReadOnly = True
        '
        'NRITOC
        '
        Me.NRITOC.DataPropertyName = "PNNRITOC"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.NRITOC.DefaultCellStyle = DataGridViewCellStyle2
        Me.NRITOC.HeaderText = "N° Item"
        Me.NRITOC.MinimumWidth = 50
        Me.NRITOC.Name = "NRITOC"
        Me.NRITOC.ReadOnly = True
        '
        'TDITES
        '
        Me.TDITES.DataPropertyName = "PSTDITES"
        Me.TDITES.HeaderText = "Descripcion"
        Me.TDITES.MinimumWidth = 120
        Me.TDITES.Name = "TDITES"
        Me.TDITES.ReadOnly = True
        Me.TDITES.Width = 120
        '
        'PNQCNTIT
        '
        Me.PNQCNTIT.DataPropertyName = "PNQCNTIT"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.PNQCNTIT.DefaultCellStyle = DataGridViewCellStyle3
        Me.PNQCNTIT.HeaderText = "Cantidad "
        Me.PNQCNTIT.MinimumWidth = 50
        Me.PNQCNTIT.Name = "PNQCNTIT"
        Me.PNQCNTIT.ReadOnly = True
        '
        'TUNDIT
        '
        Me.TUNDIT.DataPropertyName = "PSTUNDIT"
        Me.TUNDIT.HeaderText = "Unidad de Medida"
        Me.TUNDIT.Name = "TUNDIT"
        Me.TUNDIT.ReadOnly = True
        Me.TUNDIT.Width = 150
        '
        'TTINTC
        '
        Me.TTINTC.DataPropertyName = "PSTTINTC"
        Me.TTINTC.HeaderText = "Término Internacional"
        Me.TTINTC.Name = "TTINTC"
        Me.TTINTC.ReadOnly = True
        Me.TTINTC.Width = 150
        '
        'ExisteBitacora
        '
        Me.ExisteBitacora.HeaderText = "Tiene Bitacora"
        Me.ExisteBitacora.Name = "ExisteBitacora"
        Me.ExisteBitacora.ReadOnly = True
        Me.ExisteBitacora.Visible = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Existe en Sistema"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 120
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.HeaderText = " "
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PSNORCML"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Orden Compra"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PNNRITOC"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn6.HeaderText = "N° Item"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PSTDITES"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 120
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PNQCNTIT"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn8.HeaderText = "Cantidad "
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PSTUNDIT"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Unidad de Medida"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 150
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PSTTINTC"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Término Internacional"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 150
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Tiene Bitacora"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn12.HeaderText = ""
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'frmCompararOC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 499)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmCompararOC"
        Me.Text = "Actualizar Ordenes de Compra Local"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.spcComparativo.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcComparativo.Panel1.ResumeLayout(False)
        CType(Me.spcComparativo.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcComparativo.Panel2.ResumeLayout(False)
        CType(Me.spcComparativo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcComparativo.ResumeLayout(False)
        CType(Me.dtgOCArchivoExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgOcSeguimiento, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents spcComparativo As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Private WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents TxtRutaCabecera As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbBuscarArchivo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents dtgOCArchivoExcel As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dgOcSeguimiento As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NORCML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRITOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDITES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQCNTIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TUNDIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TTINTC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExisteBitacora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXISTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tsbBitacora As System.Windows.Forms.ToolStripButton
End Class
