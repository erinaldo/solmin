<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrifoProveedor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtRazonSocial = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnExportarExcel = New System.Windows.Forms.ToolStripButton()
        Me.TabAsignacionCombustible = New System.Windows.Forms.TabControl()
        Me.tabDatos = New System.Windows.Forms.TabPage()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.MenuBar = New System.Windows.Forms.ToolStrip()
        Me.btnnuevo = New System.Windows.Forms.ToolStripButton()
        Me.btneditar = New System.Windows.Forms.ToolStripButton()
        Me.btnelliminar = New System.Windows.Forms.ToolStripButton()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.gwdProv = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.LINK = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewLinkColumn()
        Me.NLQCMB = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.FLQDCN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NPLCUN2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTPCMB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTGLIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QGLNUT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QGLNSA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NMRGIM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CDVSN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCMPN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabAsignacionCombustible.SuspendLayout()
        Me.tabDatos.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        CType(Me.gwdProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.txtRazonSocial)
        Me.Panel1.Controls.Add(Me.KryptonLabel10)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1170, 84)
        Me.Panel1.TabIndex = 1
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(15, 13)
        Me.KryptonLabel10.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(101, 26)
        Me.KryptonLabel10.TabIndex = 442
        Me.KryptonLabel10.Text = "Razón Social:"
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "Razón Social:"
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRazonSocial.Enabled = False
        Me.txtRazonSocial.Location = New System.Drawing.Point(159, 13)
        Me.txtRazonSocial.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRazonSocial.MaxLength = 10
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(155, 26)
        Me.txtRazonSocial.TabIndex = 443
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnExportarExcel})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 84)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1170, 27)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExportarExcel.Image = Global.SOLMIN_ST.My.Resources.Resources.excel
        Me.btnExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(89, 24)
        Me.btnExportarExcel.Text = "Exportar"
        '
        'TabAsignacionCombustible
        '
        Me.TabAsignacionCombustible.Controls.Add(Me.tabDatos)
        Me.TabAsignacionCombustible.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabAsignacionCombustible.Location = New System.Drawing.Point(0, 338)
        Me.TabAsignacionCombustible.Margin = New System.Windows.Forms.Padding(4)
        Me.TabAsignacionCombustible.Name = "TabAsignacionCombustible"
        Me.TabAsignacionCombustible.SelectedIndex = 0
        Me.TabAsignacionCombustible.Size = New System.Drawing.Size(1170, 227)
        Me.TabAsignacionCombustible.TabIndex = 5
        '
        'tabDatos
        '
        Me.tabDatos.Controls.Add(Me.KryptonLabel1)
        Me.tabDatos.Location = New System.Drawing.Point(4, 25)
        Me.tabDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.tabDatos.Name = "tabDatos"
        Me.tabDatos.Padding = New System.Windows.Forms.Padding(4)
        Me.tabDatos.Size = New System.Drawing.Size(1162, 198)
        Me.tabDatos.TabIndex = 2
        Me.tabDatos.Text = "Mantenimiento"
        Me.tabDatos.UseVisualStyleBackColor = True
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(22, 32)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(101, 26)
        Me.KryptonLabel1.TabIndex = 443
        Me.KryptonLabel1.Text = "Razón Social:"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Razón Social:"
        '
        'MenuBar
        '
        Me.MenuBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btneditar, Me.btnelliminar, Me.btnnuevo})
        Me.MenuBar.Location = New System.Drawing.Point(0, 311)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuBar.Size = New System.Drawing.Size(1170, 27)
        Me.MenuBar.TabIndex = 6
        Me.MenuBar.TabStop = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnnuevo.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok
        Me.btnnuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(76, 24)
        Me.btnnuevo.Text = "Nuevo"
        '
        'btneditar
        '
        Me.btneditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btneditar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok
        Me.btneditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(97, 24)
        Me.btneditar.Text = "Modificar"
        '
        'btnelliminar
        '
        Me.btnelliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnelliminar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
        Me.btnelliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnelliminar.Name = "btnelliminar"
        Me.btnelliminar.Size = New System.Drawing.Size(87, 24)
        Me.btnelliminar.Text = "Eliminar"
        '
        'btnBuscar
        '
        Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(76, 24)
        Me.btnBuscar.Text = "Buscar"
        '
        'gwdProv
        '
        Me.gwdProv.AllowUserToAddRows = False
        Me.gwdProv.AllowUserToDeleteRows = False
        Me.gwdProv.AllowUserToResizeRows = False
        Me.gwdProv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gwdProv.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.gwdProv.ColumnHeadersHeight = 30
        Me.gwdProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gwdProv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LINK, Me.NLQCMB, Me.FLQDCN, Me.NPLCUN2, Me.CTPCMB, Me.QTGLIN, Me.QGLNUT, Me.QGLNSA, Me.NMRGIM, Me.ESTADO, Me.CDVSN, Me.CCMPN, Me.SESTRG, Me.C1})
        Me.gwdProv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gwdProv.Location = New System.Drawing.Point(0, 111)
        Me.gwdProv.Margin = New System.Windows.Forms.Padding(4)
        Me.gwdProv.MultiSelect = False
        Me.gwdProv.Name = "gwdProv"
        Me.gwdProv.ReadOnly = True
        Me.gwdProv.RowHeadersVisible = False
        Me.gwdProv.RowHeadersWidth = 30
        Me.gwdProv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gwdProv.Size = New System.Drawing.Size(1170, 200)
        Me.gwdProv.StandardTab = True
        Me.gwdProv.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwdProv.TabIndex = 7
        '
        'LINK
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.LINK.DefaultCellStyle = DataGridViewCellStyle1
        Me.LINK.HeaderText = ""
        Me.LINK.Name = "LINK"
        Me.LINK.ReadOnly = True
        Me.LINK.Text = "Ver Detalle"
        Me.LINK.Visible = False
        Me.LINK.Width = 70
        '
        'NLQCMB
        '
        Me.NLQCMB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NLQCMB.DataPropertyName = "NLQCMB"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.NLQCMB.DefaultCellStyle = DataGridViewCellStyle2
        Me.NLQCMB.HeaderText = "N° Liquidación"
        Me.NLQCMB.Name = "NLQCMB"
        Me.NLQCMB.ReadOnly = True
        Me.NLQCMB.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NLQCMB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.NLQCMB.Width = 140
        '
        'FLQDCN
        '
        Me.FLQDCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FLQDCN.DataPropertyName = "FLQDCN"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.FLQDCN.DefaultCellStyle = DataGridViewCellStyle3
        Me.FLQDCN.HeaderText = "Fecha Liquidación"
        Me.FLQDCN.Name = "FLQDCN"
        Me.FLQDCN.ReadOnly = True
        Me.FLQDCN.Width = 161
        '
        'NPLCUN2
        '
        Me.NPLCUN2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NPLCUN2.DataPropertyName = "NPLCUN"
        Me.NPLCUN2.HeaderText = "Num. Placa"
        Me.NPLCUN2.Name = "NPLCUN2"
        Me.NPLCUN2.ReadOnly = True
        Me.NPLCUN2.Width = 116
        '
        'CTPCMB
        '
        Me.CTPCMB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CTPCMB.DataPropertyName = "CTPCMB"
        Me.CTPCMB.HeaderText = "Tipo Combustible"
        Me.CTPCMB.Name = "CTPCMB"
        Me.CTPCMB.ReadOnly = True
        Me.CTPCMB.Visible = False
        Me.CTPCMB.Width = 160
        '
        'QTGLIN
        '
        Me.QTGLIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QTGLIN.DataPropertyName = "QTGLIN"
        Me.QTGLIN.HeaderText = "Combustible Ingresado"
        Me.QTGLIN.Name = "QTGLIN"
        Me.QTGLIN.ReadOnly = True
        Me.QTGLIN.Width = 196
        '
        'QGLNUT
        '
        Me.QGLNUT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QGLNUT.DataPropertyName = "QGLNUT"
        Me.QGLNUT.HeaderText = "Combustible Utilizado"
        Me.QGLNUT.Name = "QGLNUT"
        Me.QGLNUT.ReadOnly = True
        Me.QGLNUT.Visible = False
        Me.QGLNUT.Width = 190
        '
        'QGLNSA
        '
        Me.QGLNSA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QGLNSA.DataPropertyName = "QGLNSA"
        Me.QGLNSA.HeaderText = "Combustible Salida"
        Me.QGLNSA.Name = "QGLNSA"
        Me.QGLNSA.ReadOnly = True
        Me.QGLNSA.Visible = False
        Me.QGLNSA.Width = 171
        '
        'NMRGIM
        '
        Me.NMRGIM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NMRGIM.DataPropertyName = "NMRGIM"
        Me.NMRGIM.HeaderText = "Nro Imagen"
        Me.NMRGIM.Name = "NMRGIM"
        Me.NMRGIM.ReadOnly = True
        Me.NMRGIM.Width = 121
        '
        'ESTADO
        '
        Me.ESTADO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ESTADO.DataPropertyName = "ESTADO"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.ESTADO.DefaultCellStyle = DataGridViewCellStyle4
        Me.ESTADO.HeaderText = "Estado"
        Me.ESTADO.Name = "ESTADO"
        Me.ESTADO.ReadOnly = True
        Me.ESTADO.Width = 87
        '
        'CDVSN
        '
        Me.CDVSN.DataPropertyName = "CDVSN"
        Me.CDVSN.HeaderText = "División"
        Me.CDVSN.Name = "CDVSN"
        Me.CDVSN.ReadOnly = True
        Me.CDVSN.Visible = False
        '
        'CCMPN
        '
        Me.CCMPN.DataPropertyName = "CCMPN"
        Me.CCMPN.HeaderText = "CCMPN"
        Me.CCMPN.Name = "CCMPN"
        Me.CCMPN.ReadOnly = True
        Me.CCMPN.Visible = False
        '
        'SESTRG
        '
        Me.SESTRG.DataPropertyName = "SESTRG"
        Me.SESTRG.HeaderText = "SESTRG"
        Me.SESTRG.Name = "SESTRG"
        Me.SESTRG.ReadOnly = True
        Me.SESTRG.Visible = False
        '
        'C1
        '
        Me.C1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.C1.HeaderText = ""
        Me.C1.Name = "C1"
        Me.C1.ReadOnly = True
        '
        'frmGrifoProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1170, 565)
        Me.Controls.Add(Me.gwdProv)
        Me.Controls.Add(Me.MenuBar)
        Me.Controls.Add(Me.TabAsignacionCombustible)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmGrifoProveedor"
        Me.Text = "Proveedor Grifo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabAsignacionCombustible.ResumeLayout(False)
        Me.tabDatos.ResumeLayout(False)
        Me.tabDatos.PerformLayout()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        CType(Me.gwdProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtRazonSocial As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabAsignacionCombustible As System.Windows.Forms.TabControl
    Friend WithEvents tabDatos As System.Windows.Forms.TabPage
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btneditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnelliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnnuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents gwdProv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents LINK As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewLinkColumn
    Friend WithEvents NLQCMB As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents FLQDCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLCUN2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTPCMB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QTGLIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QGLNUT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QGLNSA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NMRGIM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CDVSN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCMPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
