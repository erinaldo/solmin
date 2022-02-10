<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaColumna
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
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dtgColumna = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.CHK_COLUMNA = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.tsbAceptar = New System.Windows.Forms.ToolStripButton
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton
        Me.btnChecks = New System.Windows.Forms.ToolStripButton
        Me.headerFiltroCliente = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnSalir = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.KryptonLabel24 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbCompania = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.cmbCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NMRCRL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TNMBCM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NSEPRE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCOLUM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDITIN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.STPCRE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QANCOL = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dtgColumna, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.headerFiltroCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.headerFiltroCliente.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.headerFiltroCliente.Panel.SuspendLayout()
        Me.headerFiltroCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dtgColumna)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Controls.Add(Me.headerFiltroCliente)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(927, 805)
        Me.KryptonPanel.TabIndex = 0
        '
        'dtgColumna
        '
        Me.dtgColumna.AllowUserToAddRows = False
        Me.dtgColumna.AllowUserToDeleteRows = False
        Me.dtgColumna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgColumna.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CHK_COLUMNA, Me.NMRCRL, Me.TNMBCM, Me.NSEPRE, Me.TCOLUM, Me.TDITIN, Me.STPCRE, Me.QANCOL})
        Me.dtgColumna.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgColumna.Location = New System.Drawing.Point(0, 95)
        Me.dtgColumna.MultiSelect = False
        Me.dtgColumna.Name = "dtgColumna"
        Me.dtgColumna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgColumna.Size = New System.Drawing.Size(927, 710)
        Me.dtgColumna.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dtgColumna.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgColumna.TabIndex = 41
        '
        'CHK_COLUMNA
        '
        Me.CHK_COLUMNA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = False
        Me.CHK_COLUMNA.DefaultCellStyle = DataGridViewCellStyle1
        Me.CHK_COLUMNA.FalseValue = Nothing
        Me.CHK_COLUMNA.HeaderText = ""
        Me.CHK_COLUMNA.IndeterminateValue = Nothing
        Me.CHK_COLUMNA.Name = "CHK_COLUMNA"
        Me.CHK_COLUMNA.TrueValue = Nothing
        Me.CHK_COLUMNA.Width = 7
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnChecks, Me.ToolStripLabel2, Me.btnBuscar, Me.tsbAceptar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 70)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(927, 25)
        Me.ToolStrip1.TabIndex = 40
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(130, 22)
        Me.ToolStripLabel2.Tag = ""
        Me.ToolStripLabel2.Text = "      Listado Columnas"
        '
        'tsbAceptar
        '
        Me.tsbAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbAceptar.Image = Global.SOLMIN_SC.My.Resources.Resources.button_ok
        Me.tsbAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAceptar.Name = "tsbAceptar"
        Me.tsbAceptar.Size = New System.Drawing.Size(69, 22)
        Me.tsbAceptar.Text = "&Guardar"
        '
        'btnBuscar
        '
        Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar.Image = Global.SOLMIN_SC.My.Resources.Resources.search
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(61, 22)
        Me.btnBuscar.Text = "&Buscar"
        '
        'btnChecks
        '
        Me.btnChecks.Image = Global.SOLMIN_SC.My.Resources.Resources.btnNoMarcarItems
        Me.btnChecks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnChecks.Name = "btnChecks"
        Me.btnChecks.Size = New System.Drawing.Size(92, 22)
        Me.btnChecks.Text = "Check Todos"
        '
        'headerFiltroCliente
        '
        Me.headerFiltroCliente.AutoSize = True
        Me.headerFiltroCliente.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnSalir})
        Me.headerFiltroCliente.Dock = System.Windows.Forms.DockStyle.Top
        Me.headerFiltroCliente.Location = New System.Drawing.Point(0, 0)
        Me.headerFiltroCliente.Name = "headerFiltroCliente"
        '
        'headerFiltroCliente.Panel
        '
        Me.headerFiltroCliente.Panel.AutoScroll = True
        Me.headerFiltroCliente.Panel.Controls.Add(Me.KryptonLabel24)
        Me.headerFiltroCliente.Panel.Controls.Add(Me.cmbCompania)
        Me.headerFiltroCliente.Panel.Controls.Add(Me.cmbCliente)
        Me.headerFiltroCliente.Panel.Controls.Add(Me.lblCliente)
        Me.headerFiltroCliente.Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.headerFiltroCliente.Size = New System.Drawing.Size(927, 70)
        Me.headerFiltroCliente.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerFiltroCliente.TabIndex = 39
        Me.headerFiltroCliente.Text = "Filtros"
        Me.headerFiltroCliente.ValuesPrimary.Description = ""
        Me.headerFiltroCliente.ValuesPrimary.Heading = "Filtros"
        Me.headerFiltroCliente.ValuesPrimary.Image = Nothing
        Me.headerFiltroCliente.ValuesSecondary.Description = ""
        Me.headerFiltroCliente.ValuesSecondary.Heading = ""
        Me.headerFiltroCliente.ValuesSecondary.Image = Nothing
        '
        'btnSalir
        '
        Me.btnSalir.ExtraText = ""
        Me.btnSalir.Image = Global.SOLMIN_SC.My.Resources.Resources._exit
        Me.btnSalir.Text = "Cancelar"
        Me.btnSalir.ToolTipImage = Nothing
        Me.btnSalir.UniqueName = "4F4B4A3EF9BD42604F4B4A3EF9BD4260"
        '
        'KryptonLabel24
        '
        Me.KryptonLabel24.Location = New System.Drawing.Point(8, 8)
        Me.KryptonLabel24.Name = "KryptonLabel24"
        Me.KryptonLabel24.Size = New System.Drawing.Size(63, 19)
        Me.KryptonLabel24.TabIndex = 54
        Me.KryptonLabel24.Text = "Compañía:"
        Me.KryptonLabel24.Values.ExtraText = ""
        Me.KryptonLabel24.Values.Image = Nothing
        Me.KryptonLabel24.Values.Text = "Compañía:"
        '
        'cmbCompania
        '
        Me.cmbCompania.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCompania.CCMPN_ANTERIOR = Nothing
        Me.cmbCompania.CCMPN_CodigoCompania = Nothing
        Me.cmbCompania.CCMPN_CompaniaDefault = Nothing
        Me.cmbCompania.CCMPN_Descripcion = Nothing
        Me.cmbCompania.Location = New System.Drawing.Point(77, 8)
        Me.cmbCompania.MinimumSize = New System.Drawing.Size(150, 23)
        Me.cmbCompania.Name = "cmbCompania"
        Me.cmbCompania.Size = New System.Drawing.Size(276, 23)
        Me.cmbCompania.TabIndex = 53
        Me.cmbCompania.Usuario = ""
        '
        'cmbCliente
        '
        Me.cmbCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmbCliente.BackColor = System.Drawing.Color.Transparent
        Me.cmbCliente.CCMPN = "EZ"
        Me.cmbCliente.Location = New System.Drawing.Point(426, 10)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.pAccesoPorUsuario = True
        Me.cmbCliente.pRequerido = True
        Me.cmbCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.cmbCliente.Size = New System.Drawing.Size(256, 21)
        Me.cmbCliente.TabIndex = 39
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(370, 10)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(50, 19)
        Me.lblCliente.TabIndex = 12
        Me.lblCliente.Text = "Cliente :"
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente :"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NMRCRL"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 55
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TNMBCM"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Código Columna"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 94
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NSEPRE"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Orden"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn3.Width = 50
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TCOLUM"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Descripción(Español)"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn4.Width = 124
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TDITIN"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Descripción(Inglés)"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn5.Width = 114
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "STPCRE"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Visible"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn6.Width = 51
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "QANCOL"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Tamaño"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 76
        '
        'NMRCRL
        '
        Me.NMRCRL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NMRCRL.DataPropertyName = "NMRCRL"
        Me.NMRCRL.HeaderText = "Código"
        Me.NMRCRL.Name = "NMRCRL"
        Me.NMRCRL.ReadOnly = True
        Me.NMRCRL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NMRCRL.Width = 55
        '
        'TNMBCM
        '
        Me.TNMBCM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TNMBCM.DataPropertyName = "TNMBCM"
        Me.TNMBCM.HeaderText = "Código Columna"
        Me.TNMBCM.Name = "TNMBCM"
        Me.TNMBCM.ReadOnly = True
        Me.TNMBCM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TNMBCM.Width = 94
        '
        'NSEPRE
        '
        Me.NSEPRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NSEPRE.DataPropertyName = "NSEPRE"
        Me.NSEPRE.HeaderText = "Orden"
        Me.NSEPRE.Name = "NSEPRE"
        Me.NSEPRE.ReadOnly = True
        Me.NSEPRE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NSEPRE.Width = 50
        '
        'TCOLUM
        '
        Me.TCOLUM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCOLUM.DataPropertyName = "TCOLUM"
        Me.TCOLUM.HeaderText = "Descripción(Español)"
        Me.TCOLUM.Name = "TCOLUM"
        Me.TCOLUM.ReadOnly = True
        Me.TCOLUM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TCOLUM.Width = 124
        '
        'TDITIN
        '
        Me.TDITIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TDITIN.DataPropertyName = "TDITIN"
        Me.TDITIN.HeaderText = "Descripción(Inglés)"
        Me.TDITIN.Name = "TDITIN"
        Me.TDITIN.ReadOnly = True
        Me.TDITIN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TDITIN.Width = 114
        '
        'STPCRE
        '
        Me.STPCRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.STPCRE.DataPropertyName = "STPCRE"
        Me.STPCRE.HeaderText = "Visible"
        Me.STPCRE.Name = "STPCRE"
        Me.STPCRE.ReadOnly = True
        Me.STPCRE.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.STPCRE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.STPCRE.Width = 51
        '
        'QANCOL
        '
        Me.QANCOL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QANCOL.DataPropertyName = "QANCOL"
        Me.QANCOL.HeaderText = "Tamaño"
        Me.QANCOL.Name = "QANCOL"
        Me.QANCOL.Width = 76
        '
        'frmListaColumna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 805)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmListaColumna"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Lista Columna"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dtgColumna, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.headerFiltroCliente.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.headerFiltroCliente.Panel.ResumeLayout(False)
        Me.headerFiltroCliente.Panel.PerformLayout()
        CType(Me.headerFiltroCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.headerFiltroCliente.ResumeLayout(False)
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
  Friend WithEvents dtgColumna As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
  Private WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents tsbAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents headerFiltroCliente As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonLabel24 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbCompania As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
  Friend WithEvents cmbCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents CHK_COLUMNA As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
    Friend WithEvents NMRCRL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TNMBCM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NSEPRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCOLUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDITIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STPCRE As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents QANCOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnChecks As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
