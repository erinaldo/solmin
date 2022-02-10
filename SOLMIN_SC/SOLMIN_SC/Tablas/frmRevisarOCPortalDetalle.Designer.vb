<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRevisarOCPortalDetalle
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.HGDetalles = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnActualizar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dtgDetallesOC = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.HGCabecera = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.ButtonSpecHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.palito = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.txtCantidadOC = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCantidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ver = New System.Windows.Forms.DataGridViewImageColumn
        Me.SNROOC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SNROITE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pendiente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cerrado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Status = New System.Windows.Forms.DataGridViewImageColumn
        Me.IrAlmacen = New System.Windows.Forms.DataGridViewImageColumn
        Me.IrCliente = New System.Windows.Forms.DataGridViewImageColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.HGDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HGDetalles.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HGDetalles.Panel.SuspendLayout()
        Me.HGDetalles.SuspendLayout()
        CType(Me.dtgDetallesOC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HGCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HGCabecera.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HGCabecera.Panel.SuspendLayout()
        Me.HGCabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.HGDetalles)
        Me.KryptonPanel.Controls.Add(Me.HGCabecera)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(728, 480)
        Me.KryptonPanel.TabIndex = 0
        '
        'HGDetalles
        '
        Me.HGDetalles.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnActualizar})
        Me.HGDetalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HGDetalles.HeaderVisibleSecondary = False
        Me.HGDetalles.Location = New System.Drawing.Point(0, 146)
        Me.HGDetalles.Name = "HGDetalles"
        '
        'HGDetalles.Panel
        '
        Me.HGDetalles.Panel.Controls.Add(Me.dtgDetallesOC)
        Me.HGDetalles.Size = New System.Drawing.Size(728, 334)
        Me.HGDetalles.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HGDetalles.TabIndex = 1
        Me.HGDetalles.Text = "Detalles"
        Me.HGDetalles.ValuesPrimary.Description = ""
        Me.HGDetalles.ValuesPrimary.Heading = "Detalles"
        Me.HGDetalles.ValuesPrimary.Image = Nothing
        Me.HGDetalles.ValuesSecondary.Description = ""
        Me.HGDetalles.ValuesSecondary.Heading = "Description"
        Me.HGDetalles.ValuesSecondary.Image = Nothing
        '
        'btnActualizar
        '
        Me.btnActualizar.ExtraText = ""
        Me.btnActualizar.Image = Global.SOLMIN_SC.My.Resources.Resources.agt_update_product
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.ToolTipImage = Nothing
        Me.btnActualizar.UniqueName = "7D375C8CEC9844EA7D375C8CEC9844EA"
        '
        'dtgDetallesOC
        '
        Me.dtgDetallesOC.AllowUserToAddRows = False
        Me.dtgDetallesOC.AllowUserToDeleteRows = False
        Me.dtgDetallesOC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgDetallesOC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ver, Me.SNROOC, Me.SNROITE, Me.CANTIDAD, Me.Pendiente, Me.Cerrado, Me.Status, Me.IrAlmacen, Me.IrCliente})
        Me.dtgDetallesOC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgDetallesOC.Location = New System.Drawing.Point(0, 0)
        Me.dtgDetallesOC.Name = "dtgDetallesOC"
        Me.dtgDetallesOC.ReadOnly = True
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgDetallesOC.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dtgDetallesOC.Size = New System.Drawing.Size(726, 301)
        Me.dtgDetallesOC.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgDetallesOC.TabIndex = 0
        '
        'HGCabecera
        '
        Me.HGCabecera.AutoSize = True
        Me.HGCabecera.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.ButtonSpecHeaderGroup1, Me.palito, Me.btnCerrar})
        Me.HGCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.HGCabecera.HeaderVisibleSecondary = False
        Me.HGCabecera.Location = New System.Drawing.Point(0, 0)
        Me.HGCabecera.Name = "HGCabecera"
        '
        'HGCabecera.Panel
        '
        Me.HGCabecera.Panel.Controls.Add(Me.txtCantidadOC)
        Me.HGCabecera.Panel.Controls.Add(Me.KryptonLabel3)
        Me.HGCabecera.Panel.Controls.Add(Me.txtCantidad)
        Me.HGCabecera.Panel.Controls.Add(Me.KryptonLabel2)
        Me.HGCabecera.Panel.Controls.Add(Me.txtCliente)
        Me.HGCabecera.Panel.Controls.Add(Me.KryptonLabel1)
        Me.HGCabecera.Size = New System.Drawing.Size(728, 146)
        Me.HGCabecera.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HGCabecera.TabIndex = 0
        Me.HGCabecera.Text = "[]"
        Me.HGCabecera.ValuesPrimary.Description = ""
        Me.HGCabecera.ValuesPrimary.Heading = "[]"
        Me.HGCabecera.ValuesPrimary.Image = Nothing
        Me.HGCabecera.ValuesSecondary.Description = ""
        Me.HGCabecera.ValuesSecondary.Heading = "Description"
        Me.HGCabecera.ValuesSecondary.Image = Nothing
        '
        'ButtonSpecHeaderGroup1
        '
        Me.ButtonSpecHeaderGroup1.ExtraText = ""
        Me.ButtonSpecHeaderGroup1.Image = Nothing
        Me.ButtonSpecHeaderGroup1.Text = ""
        Me.ButtonSpecHeaderGroup1.ToolTipImage = Nothing
        Me.ButtonSpecHeaderGroup1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp
        Me.ButtonSpecHeaderGroup1.UniqueName = "A2535B8499334C2EA2535B8499334C2E"
        '
        'palito
        '
        Me.palito.ExtraText = ""
        Me.palito.Image = Nothing
        Me.palito.Text = "|"
        Me.palito.ToolTipImage = Nothing
        Me.palito.UniqueName = "49DFE28AF5B0402749DFE28AF5B04027"
        '
        'btnCerrar
        '
        Me.btnCerrar.ExtraText = ""
        Me.btnCerrar.Image = Nothing
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.ToolTipImage = Nothing
        Me.btnCerrar.UniqueName = "A41D962268DE41F1A41D962268DE41F1"
        '
        'txtCantidadOC
        '
        Me.txtCantidadOC.Location = New System.Drawing.Point(149, 48)
        Me.txtCantidadOC.Name = "txtCantidadOC"
        Me.txtCantidadOC.ReadOnly = True
        Me.txtCantidadOC.Size = New System.Drawing.Size(100, 21)
        Me.txtCantidadOC.TabIndex = 5
        Me.txtCantidadOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.AutoSize = False
        Me.KryptonLabel3.Location = New System.Drawing.Point(32, 47)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(90, 23)
        Me.KryptonLabel3.TabIndex = 4
        Me.KryptonLabel3.Text = "Cantidad O/C :"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Cantidad O/C :"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(149, 86)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.ReadOnly = True
        Me.txtCantidad.Size = New System.Drawing.Size(100, 21)
        Me.txtCantidad.TabIndex = 3
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.AutoSize = False
        Me.KryptonLabel2.Location = New System.Drawing.Point(32, 82)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(102, 34)
        Me.KryptonLabel2.TabIndex = 2
        Me.KryptonLabel2.Text = "Cantidad Item's:"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Cantidad Item's:"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(149, 14)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(356, 21)
        Me.txtCliente.TabIndex = 1
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(35, 15)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(50, 19)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Text = "Cliente :"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Cliente :"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.HeaderText = "Orden Interna"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nro Item"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 60
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn4.HeaderText = "Pendiente"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cerrado"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn6.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 60
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn7.HeaderText = "***"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 60
        '
        'ver
        '
        Me.ver.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ver.HeaderText = "Ver"
        Me.ver.Name = "ver"
        Me.ver.ReadOnly = True
        Me.ver.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ver.Width = 30
        '
        'SNROOC
        '
        Me.SNROOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.SNROOC.HeaderText = "Orden de Compra"
        Me.SNROOC.Name = "SNROOC"
        Me.SNROOC.ReadOnly = True
        Me.SNROOC.Width = 120
        '
        'SNROITE
        '
        Me.SNROITE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.SNROITE.DefaultCellStyle = DataGridViewCellStyle1
        Me.SNROITE.HeaderText = "Nro Item"
        Me.SNROITE.Name = "SNROITE"
        Me.SNROITE.ReadOnly = True
        Me.SNROITE.Width = 60
        '
        'CANTIDAD
        '
        Me.CANTIDAD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CANTIDAD.DefaultCellStyle = DataGridViewCellStyle2
        Me.CANTIDAD.HeaderText = "Cantidad"
        Me.CANTIDAD.Name = "CANTIDAD"
        Me.CANTIDAD.ReadOnly = True
        '
        'Pendiente
        '
        Me.Pendiente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.NullValue = "0"
        Me.Pendiente.DefaultCellStyle = DataGridViewCellStyle3
        Me.Pendiente.HeaderText = "Pendiente"
        Me.Pendiente.Name = "Pendiente"
        Me.Pendiente.ReadOnly = True
        '
        'Cerrado
        '
        Me.Cerrado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.NullValue = "0"
        Me.Cerrado.DefaultCellStyle = DataGridViewCellStyle4
        Me.Cerrado.HeaderText = "Cerrado"
        Me.Cerrado.Name = "Cerrado"
        Me.Cerrado.ReadOnly = True
        '
        'Status
        '
        Me.Status.HeaderText = "Estado Registro" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SOLMIN"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'IrAlmacen
        '
        Me.IrAlmacen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IrAlmacen.HeaderText = "Enviar Al" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Almacen"
        Me.IrAlmacen.Name = "IrAlmacen"
        Me.IrAlmacen.ReadOnly = True
        Me.IrAlmacen.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IrAlmacen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'IrCliente
        '
        Me.IrCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IrCliente.HeaderText = "Enviar Al" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cliente"
        Me.IrCliente.Name = "IrCliente"
        Me.IrCliente.ReadOnly = True
        Me.IrCliente.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IrCliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'frmRevisarOCPortalDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 480)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRevisarOCPortalDetalle"
        Me.Text = "Detalle O/C Portal - (YRC-RANSA)"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.HGDetalles.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGDetalles.Panel.ResumeLayout(False)
        CType(Me.HGDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGDetalles.ResumeLayout(False)
        CType(Me.dtgDetallesOC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HGCabecera.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGCabecera.Panel.ResumeLayout(False)
        Me.HGCabecera.Panel.PerformLayout()
        CType(Me.HGCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGCabecera.ResumeLayout(False)
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
    Friend WithEvents HGCabecera As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents HGDetalles As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ButtonSpecHeaderGroup1 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dtgDetallesOC As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCantidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnActualizar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCantidadOC As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents palito As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnCerrar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents ver As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents SNROOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SNROITE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pendiente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cerrado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents IrAlmacen As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents IrCliente As System.Windows.Forms.DataGridViewImageColumn
End Class
