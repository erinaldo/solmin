<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarEmbarque
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
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.btnQuitar = New System.Windows.Forms.ToolStripButton
        Me.btnAdicionar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.cboBusqueda = New System.Windows.Forms.ToolStripComboBox
        Me.txtBusqueda = New System.Windows.Forms.ToolStripTextBox
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnGuardar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.txtOperacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dtgEmbarque = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NORSCI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRITEM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ETD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ETA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNNMOS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TPRVCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDITES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NDOCEM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CMEDTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCANAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TNRODU = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TNMAGC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.REGIMEN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DESPACHO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FOB = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FLETE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SEGURO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CIF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FLAG_REGISTRO = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.dtgEmbarque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dtgEmbarque)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip2)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(670, 318)
        Me.KryptonPanel.TabIndex = 0
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnQuitar, Me.btnAdicionar, Me.ToolStripLabel2, Me.cboBusqueda, Me.txtBusqueda})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 76)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(670, 25)
        Me.ToolStrip2.TabIndex = 10
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnQuitar
        '
        Me.btnQuitar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnQuitar.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.button_cancel1
        Me.btnQuitar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(60, 22)
        Me.btnQuitar.Text = "Quitar"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAdicionar.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.edit_add
        Me.btnAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(76, 22)
        Me.btnAdicionar.Text = "Adicionar"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(65, 22)
        Me.ToolStripLabel2.Text = "Buscar por:"
        '
        'cboBusqueda
        '
        Me.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBusqueda.Items.AddRange(New Object() {"E - Embarque", "O - Orden Servicio"})
        Me.cboBusqueda.Name = "cboBusqueda"
        Me.cboBusqueda.Size = New System.Drawing.Size(121, 25)
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(100, 25)
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnGuardar, Me.btnCancelar})
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtOperacion)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel7)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(670, 76)
        Me.KryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.TabIndex = 1
        Me.KryptonHeaderGroup1.Text = "Filtro"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Filtro"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'btnGuardar
        '
        Me.btnGuardar.ExtraText = ""
        Me.btnGuardar.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.button_ok
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.ToolTipImage = Nothing
        Me.btnGuardar.UniqueName = "1A84A50EAE574FF81A84A50EAE574FF8"
        '
        'btnCancelar
        '
        Me.btnCancelar.ExtraText = ""
        Me.btnCancelar.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.salir
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.ToolTipImage = Nothing
        Me.btnCancelar.UniqueName = "18AA99E4CDC0480518AA99E4CDC04805"
        '
        'txtOperacion
        '
        Me.txtOperacion.Enabled = False
        Me.txtOperacion.Location = New System.Drawing.Point(99, 13)
        Me.txtOperacion.MaxLength = 6
        Me.txtOperacion.Name = "txtOperacion"
        Me.txtOperacion.Size = New System.Drawing.Size(136, 21)
        Me.txtOperacion.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtOperacion.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtOperacion.TabIndex = 27
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(3, 13)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(90, 19)
        Me.KryptonLabel7.TabIndex = 26
        Me.KryptonLabel7.Text = "Nro Operación :"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Nro Operación :"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.HeaderText = "Embarque"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.HeaderText = "NRITEM"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.HeaderText = "ETD"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.HeaderText = "ETA"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.HeaderText = "AT"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.HeaderText = "OS"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.HeaderText = "Proveedor"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.HeaderText = "Mercadería"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.HeaderText = "BL/AWB"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.HeaderText = "Medio Transporte"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.HeaderText = "Canal"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn12.HeaderText = "Nro DUA"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn13.HeaderText = "Agente de Embarcador"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn14.HeaderText = "Régimen"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn15.HeaderText = "Despacho"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn16.HeaderText = "Transporte"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn17.HeaderText = "FOB"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn18.HeaderText = "FLETE"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn19.HeaderText = "SEGURO"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn20.HeaderText = "CIF"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn21.HeaderText = "FLAG_REGISTRO"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn21.Visible = False
        '
        'dtgEmbarque
        '
        Me.dtgEmbarque.AllowUserToAddRows = False
        Me.dtgEmbarque.AllowUserToDeleteRows = False
        Me.dtgEmbarque.AllowUserToResizeColumns = False
        Me.dtgEmbarque.AllowUserToResizeRows = False
        Me.dtgEmbarque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgEmbarque.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtgEmbarque.CausesValidation = False
        Me.dtgEmbarque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgEmbarque.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NORSCI, Me.NRITEM, Me.ETD, Me.ETA, Me.AT, Me.PNNMOS, Me.TPRVCL, Me.TDITES, Me.NDOCEM, Me.CMEDTR, Me.TCANAL, Me.TNRODU, Me.TNMAGC, Me.REGIMEN, Me.DESPACHO, Me.FOB, Me.FLETE, Me.SEGURO, Me.CIF, Me.ESTADO, Me.FLAG_REGISTRO})
        Me.dtgEmbarque.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgEmbarque.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgEmbarque.Location = New System.Drawing.Point(0, 101)
        Me.dtgEmbarque.MultiSelect = False
        Me.dtgEmbarque.Name = "dtgEmbarque"
        Me.dtgEmbarque.ReadOnly = True
        Me.dtgEmbarque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgEmbarque.Size = New System.Drawing.Size(670, 217)
        Me.dtgEmbarque.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dtgEmbarque.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgEmbarque.TabIndex = 16
        '
        'NORSCI
        '
        Me.NORSCI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NORSCI.HeaderText = "Embarque"
        Me.NORSCI.Name = "NORSCI"
        Me.NORSCI.ReadOnly = True
        Me.NORSCI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NORSCI.Width = 69
        '
        'NRITEM
        '
        Me.NRITEM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRITEM.HeaderText = "NRITEM"
        Me.NRITEM.Name = "NRITEM"
        Me.NRITEM.ReadOnly = True
        Me.NRITEM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NRITEM.Visible = False
        '
        'ETD
        '
        Me.ETD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ETD.HeaderText = "ETD"
        Me.ETD.Name = "ETD"
        Me.ETD.ReadOnly = True
        Me.ETD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ETD.Width = 36
        '
        'ETA
        '
        Me.ETA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ETA.HeaderText = "ETA"
        Me.ETA.Name = "ETA"
        Me.ETA.ReadOnly = True
        Me.ETA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ETA.Width = 35
        '
        'AT
        '
        Me.AT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.AT.HeaderText = "Fecha Entrega " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Almacén"
        Me.AT.Name = "AT"
        Me.AT.ReadOnly = True
        Me.AT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.AT.Width = 93
        '
        'PNNMOS
        '
        Me.PNNMOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PNNMOS.HeaderText = "OS"
        Me.PNNMOS.Name = "PNNMOS"
        Me.PNNMOS.ReadOnly = True
        Me.PNNMOS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PNNMOS.Width = 32
        '
        'TPRVCL
        '
        Me.TPRVCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TPRVCL.HeaderText = "Proveedor"
        Me.TPRVCL.Name = "TPRVCL"
        Me.TPRVCL.ReadOnly = True
        Me.TPRVCL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TPRVCL.Width = 69
        '
        'TDITES
        '
        Me.TDITES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TDITES.HeaderText = "Mercadería"
        Me.TDITES.Name = "TDITES"
        Me.TDITES.ReadOnly = True
        Me.TDITES.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TDITES.Width = 74
        '
        'NDOCEM
        '
        Me.NDOCEM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NDOCEM.HeaderText = "BL/AWB"
        Me.NDOCEM.Name = "NDOCEM"
        Me.NDOCEM.ReadOnly = True
        Me.NDOCEM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NDOCEM.Width = 58
        '
        'CMEDTR
        '
        Me.CMEDTR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CMEDTR.HeaderText = "Medio " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Transporte"
        Me.CMEDTR.Name = "CMEDTR"
        Me.CMEDTR.ReadOnly = True
        Me.CMEDTR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CMEDTR.Width = 72
        '
        'TCANAL
        '
        Me.TCANAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCANAL.HeaderText = "Canal"
        Me.TCANAL.Name = "TCANAL"
        Me.TCANAL.ReadOnly = True
        Me.TCANAL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TCANAL.Width = 46
        '
        'TNRODU
        '
        Me.TNRODU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TNRODU.HeaderText = "Nro DUA"
        Me.TNRODU.Name = "TNRODU"
        Me.TNRODU.ReadOnly = True
        Me.TNRODU.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TNRODU.Width = 56
        '
        'TNMAGC
        '
        Me.TNMAGC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TNMAGC.HeaderText = "Agente " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Embarcador"
        Me.TNMAGC.Name = "TNMAGC"
        Me.TNMAGC.ReadOnly = True
        Me.TNMAGC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TNMAGC.Width = 78
        '
        'REGIMEN
        '
        Me.REGIMEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.REGIMEN.HeaderText = "Régimen"
        Me.REGIMEN.Name = "REGIMEN"
        Me.REGIMEN.ReadOnly = True
        Me.REGIMEN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.REGIMEN.Width = 62
        '
        'DESPACHO
        '
        Me.DESPACHO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DESPACHO.HeaderText = "Despacho"
        Me.DESPACHO.Name = "DESPACHO"
        Me.DESPACHO.ReadOnly = True
        Me.DESPACHO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DESPACHO.Width = 68
        '
        'FOB
        '
        Me.FOB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FOB.HeaderText = "FOB"
        Me.FOB.Name = "FOB"
        Me.FOB.ReadOnly = True
        Me.FOB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.FOB.Width = 39
        '
        'FLETE
        '
        Me.FLETE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FLETE.HeaderText = "FLETE"
        Me.FLETE.Name = "FLETE"
        Me.FLETE.ReadOnly = True
        Me.FLETE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.FLETE.Width = 45
        '
        'SEGURO
        '
        Me.SEGURO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SEGURO.HeaderText = "SEGURO"
        Me.SEGURO.Name = "SEGURO"
        Me.SEGURO.ReadOnly = True
        Me.SEGURO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SEGURO.Width = 61
        '
        'CIF
        '
        Me.CIF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CIF.HeaderText = "CIF"
        Me.CIF.Name = "CIF"
        Me.CIF.ReadOnly = True
        Me.CIF.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CIF.Width = 33
        '
        'ESTADO
        '
        Me.ESTADO.HeaderText = "Estado"
        Me.ESTADO.Name = "ESTADO"
        Me.ESTADO.ReadOnly = True
        Me.ESTADO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ESTADO.Width = 52
        '
        'FLAG_REGISTRO
        '
        Me.FLAG_REGISTRO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FLAG_REGISTRO.HeaderText = "FLAG_REGISTRO"
        Me.FLAG_REGISTRO.Name = "FLAG_REGISTRO"
        Me.FLAG_REGISTRO.ReadOnly = True
        Me.FLAG_REGISTRO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.FLAG_REGISTRO.Visible = False
        '
        'frmBuscarEmbarque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 318)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(678, 352)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(678, 352)
        Me.Name = "frmBuscarEmbarque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Adicionar Embarque"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.dtgEmbarque, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnGuardar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtOperacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnQuitar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAdicionar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboBusqueda As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents txtBusqueda As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtgEmbarque As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents NORSCI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRITEM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ETD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ETA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNNMOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TPRVCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDITES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NDOCEM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMEDTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCANAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TNRODU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TNMAGC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REGIMEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESPACHO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FOB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FLETE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SEGURO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CIF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FLAG_REGISTRO As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
