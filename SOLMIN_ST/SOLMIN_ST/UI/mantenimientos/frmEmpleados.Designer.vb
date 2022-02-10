<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpleados))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.tsMenuNavegacion = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripTextBox3 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.dtgEmpleado = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.COBRR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TNMBOB = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCATEG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SCATEG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TABREM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDRCEM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TLCLEM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDPTEM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCECOE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCMPN1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCLNT5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CSCDSP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PERNR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCENPL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDSCTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HeaderDatos = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtCodEmpleado = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCod3 = New System.Windows.Forms.TextBox
        Me.txtCod2 = New System.Windows.Forms.TextBox
        Me.txtCod1 = New System.Windows.Forms.TextBox
        Me.KryptonTextBox1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCodCompa = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtDpto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtLocalidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtDirecc = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonBorderEdge1 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.txtAbre = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel16 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.MenuBar = New System.Windows.Forms.ToolStrip
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.cboPaginas = New System.Windows.Forms.ToolStripComboBox
        Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnImprimir = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnBuscar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.cboTipoEmpleado = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.cboCompania = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNombreBusqueda = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.btnIrInicio = New System.Windows.Forms.ToolStripButton
        Me.tssSep_001 = New System.Windows.Forms.ToolStripSeparator
        Me.btnIrAnterior = New System.Windows.Forms.ToolStripButton
        Me.tssSep_002 = New System.Windows.Forms.ToolStripSeparator
        Me.txtPaginaActual = New System.Windows.Forms.ToolStripTextBox
        Me.tssSep_003 = New System.Windows.Forms.ToolStripSeparator
        Me.btnIrSiguiente = New System.Windows.Forms.ToolStripButton
        Me.tssSep_004 = New System.Windows.Forms.ToolStripSeparator
        Me.btnIrFinal = New System.Windows.Forms.ToolStripButton
        Me.tssSep_005 = New System.Windows.Forms.ToolStripSeparator
        Me.txtNroTotalPagina = New System.Windows.Forms.ToolStripTextBox
        Me.tssSep_006 = New System.Windows.Forms.ToolStripSeparator
        Me.lblNroRegPagina = New System.Windows.Forms.ToolStripLabel
        Me.txtNroRegPorPagina = New System.Windows.Forms.ToolStripTextBox
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
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.tsMenuNavegacion.SuspendLayout()
        CType(Me.dtgEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderDatos.Panel.SuspendLayout()
        Me.HeaderDatos.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFiltros.Panel.SuspendLayout()
        Me.PanelFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Controls.Add(Me.HeaderDatos)
        Me.KryptonPanel.Controls.Add(Me.PanelFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1197, 659)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup1.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 71)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.tsMenuNavegacion)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtgEmpleado)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(1197, 383)
        Me.KryptonHeaderGroup1.TabIndex = 5
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'tsMenuNavegacion
        '
        Me.tsMenuNavegacion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMenuNavegacion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.tsMenuNavegacion.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuNavegacion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator5, Me.ToolStripButton2, Me.ToolStripSeparator7, Me.ToolStripTextBox3, Me.ToolStripSeparator8, Me.ToolStripButton3, Me.ToolStripSeparator9, Me.ToolStripButton4, Me.ToolStripSeparator10, Me.ToolStripTextBox2, Me.ToolStripSeparator11, Me.ToolStripLabel2, Me.ToolStripTextBox1})
        Me.tsMenuNavegacion.Location = New System.Drawing.Point(0, 356)
        Me.tsMenuNavegacion.Name = "tsMenuNavegacion"
        Me.tsMenuNavegacion.Size = New System.Drawing.Size(1195, 25)
        Me.tsMenuNavegacion.TabIndex = 64
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(27, 22)
        Me.ToolStripButton1.Text = "<<"
        Me.ToolStripButton1.ToolTipText = "Ir al Inicio"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "<"
        Me.ToolStripButton2.ToolTipText = "Ir al Anterior"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox3
        '
        Me.ToolStripTextBox3.Name = "ToolStripTextBox3"
        Me.ToolStripTextBox3.Size = New System.Drawing.Size(40, 25)
        Me.ToolStripTextBox3.Text = "1"
        Me.ToolStripTextBox3.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = ">"
        Me.ToolStripButton3.ToolTipText = "Ir Siguiente"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(27, 22)
        Me.ToolStripButton4.Text = ">>"
        Me.ToolStripButton4.ToolTipText = "Ir al Final"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.ReadOnly = True
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(40, 25)
        Me.ToolStripTextBox2.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolStripTextBox2.ToolTipText = "Total de Páginas para la Consulta realizada"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(89, 22)
        Me.ToolStripLabel2.Text = "Nro. Reg. Pág. : "
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(40, 25)
        Me.ToolStripTextBox1.Text = "20"
        Me.ToolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolStripTextBox1.ToolTipText = "Página Actual"
        '
        'dtgEmpleado
        '
        Me.dtgEmpleado.AllowUserToAddRows = False
        Me.dtgEmpleado.AllowUserToDeleteRows = False
        Me.dtgEmpleado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgEmpleado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgEmpleado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COBRR, Me.TNMBOB, Me.TCATEG, Me.SCATEG, Me.TABREM, Me.TDRCEM, Me.TLCLEM, Me.TDPTEM, Me.CCECOE, Me.CCMPN1, Me.CCLNT5, Me.CSCDSP, Me.PERNR, Me.CCENPL, Me.TDSCTR, Me.SESTRG})
        Me.dtgEmpleado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgEmpleado.Location = New System.Drawing.Point(-2, -1)
        Me.dtgEmpleado.MultiSelect = False
        Me.dtgEmpleado.Name = "dtgEmpleado"
        Me.dtgEmpleado.ReadOnly = True
        Me.dtgEmpleado.RowHeadersWidth = 20
        Me.dtgEmpleado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtgEmpleado.RowTemplate.Height = 20
        Me.dtgEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgEmpleado.Size = New System.Drawing.Size(1195, 353)
        Me.dtgEmpleado.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgEmpleado.TabIndex = 63
        '
        'COBRR
        '
        Me.COBRR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.COBRR.DataPropertyName = "CTPOEM"
        Me.COBRR.HeaderText = "Código Tipo Empleado"
        Me.COBRR.Name = "COBRR"
        Me.COBRR.ReadOnly = True
        Me.COBRR.Visible = False
        '
        'TNMBOB
        '
        Me.TNMBOB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TNMBOB.DataPropertyName = "CTPPTA"
        Me.TNMBOB.HeaderText = "Codigo Tipo Planta"
        Me.TNMBOB.Name = "TNMBOB"
        Me.TNMBOB.ReadOnly = True
        Me.TNMBOB.Visible = False
        '
        'TCATEG
        '
        Me.TCATEG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCATEG.DataPropertyName = "CEMPC"
        Me.TCATEG.HeaderText = "Cod Empleado Compañia"
        Me.TCATEG.Name = "TCATEG"
        Me.TCATEG.ReadOnly = True
        Me.TCATEG.Width = 172
        '
        'SCATEG
        '
        Me.SCATEG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SCATEG.DataPropertyName = "TCMPEM"
        Me.SCATEG.HeaderText = "Apellidos y nombres"
        Me.SCATEG.Name = "SCATEG"
        Me.SCATEG.ReadOnly = True
        '
        'TABREM
        '
        Me.TABREM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TABREM.DataPropertyName = "TABREM"
        Me.TABREM.HeaderText = "Descripcion Abreviada"
        Me.TABREM.Name = "TABREM"
        Me.TABREM.ReadOnly = True
        Me.TABREM.Visible = False
        '
        'TDRCEM
        '
        Me.TDRCEM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TDRCEM.DataPropertyName = "TDRCEM"
        Me.TDRCEM.HeaderText = "Direccion"
        Me.TDRCEM.Name = "TDRCEM"
        Me.TDRCEM.ReadOnly = True
        Me.TDRCEM.Width = 86
        '
        'TLCLEM
        '
        Me.TLCLEM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TLCLEM.DataPropertyName = "TLCLEM"
        Me.TLCLEM.HeaderText = "Descripcion Localidad"
        Me.TLCLEM.Name = "TLCLEM"
        Me.TLCLEM.ReadOnly = True
        Me.TLCLEM.Width = 152
        '
        'TDPTEM
        '
        Me.TDPTEM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TDPTEM.DataPropertyName = "TDPTEM"
        Me.TDPTEM.HeaderText = "Descripcion Dpto"
        Me.TDPTEM.Name = "TDPTEM"
        Me.TDPTEM.ReadOnly = True
        Me.TDPTEM.Width = 127
        '
        'CCECOE
        '
        Me.CCECOE.DataPropertyName = "CCECOE"
        Me.CCECOE.HeaderText = "Cod Centro Costo"
        Me.CCECOE.Name = "CCECOE"
        Me.CCECOE.ReadOnly = True
        Me.CCECOE.Visible = False
        Me.CCECOE.Width = 128
        '
        'CCMPN1
        '
        Me.CCMPN1.DataPropertyName = "CCMPN1"
        Me.CCMPN1.HeaderText = "Codigo Compañia"
        Me.CCMPN1.Name = "CCMPN1"
        Me.CCMPN1.ReadOnly = True
        Me.CCMPN1.Visible = False
        Me.CCMPN1.Width = 129
        '
        'CCLNT5
        '
        Me.CCLNT5.DataPropertyName = "CCLNT5"
        Me.CCLNT5.HeaderText = "Codigo Cliente"
        Me.CCLNT5.Name = "CCLNT5"
        Me.CCLNT5.ReadOnly = True
        Me.CCLNT5.Visible = False
        Me.CCLNT5.Width = 113
        '
        'CSCDSP
        '
        Me.CSCDSP.DataPropertyName = "CSCDSP"
        Me.CSCDSP.HeaderText = "Codigo SAP"
        Me.CSCDSP.Name = "CSCDSP"
        Me.CSCDSP.ReadOnly = True
        Me.CSCDSP.Visible = False
        Me.CSCDSP.Width = 96
        '
        'PERNR
        '
        Me.PERNR.DataPropertyName = "PERNR"
        Me.PERNR.HeaderText = "Numero de Personal"
        Me.PERNR.Name = "PERNR"
        Me.PERNR.ReadOnly = True
        Me.PERNR.Width = 144
        '
        'CCENPL
        '
        Me.CCENPL.DataPropertyName = "CCENPL"
        Me.CCENPL.HeaderText = "CENPLA"
        Me.CCENPL.Name = "CCENPL"
        Me.CCENPL.ReadOnly = True
        Me.CCENPL.Visible = False
        Me.CCENPL.Width = 75
        '
        'TDSCTR
        '
        Me.TDSCTR.DataPropertyName = "TDSCTR"
        Me.TDSCTR.HeaderText = "Descripcion Control"
        Me.TDSCTR.Name = "TDSCTR"
        Me.TDSCTR.ReadOnly = True
        Me.TDSCTR.Visible = False
        Me.TDSCTR.Width = 138
        '
        'SESTRG
        '
        Me.SESTRG.DataPropertyName = "SESTRG"
        Me.SESTRG.HeaderText = "Estado"
        Me.SESTRG.Name = "SESTRG"
        Me.SESTRG.ReadOnly = True
        Me.SESTRG.Visible = False
        Me.SESTRG.Width = 71
        '
        'HeaderDatos
        '
        Me.HeaderDatos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.HeaderDatos.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HeaderDatos.HeaderVisibleSecondary = False
        Me.HeaderDatos.Location = New System.Drawing.Point(0, 454)
        Me.HeaderDatos.Name = "HeaderDatos"
        '
        'HeaderDatos.Panel
        '
        Me.HeaderDatos.Panel.Controls.Add(Me.Panel1)
        Me.HeaderDatos.Panel.Controls.Add(Me.MenuBar)
        Me.HeaderDatos.Size = New System.Drawing.Size(1197, 205)
        Me.HeaderDatos.TabIndex = 4
        Me.HeaderDatos.Text = "Información del Empleado"
        Me.HeaderDatos.ValuesPrimary.Description = ""
        Me.HeaderDatos.ValuesPrimary.Heading = "Información del Empleado"
        Me.HeaderDatos.ValuesPrimary.Image = Nothing
        Me.HeaderDatos.ValuesSecondary.Description = ""
        Me.HeaderDatos.ValuesSecondary.Heading = "Description"
        Me.HeaderDatos.ValuesSecondary.Image = Nothing
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtCodEmpleado)
        Me.Panel1.Controls.Add(Me.KryptonLabel9)
        Me.Panel1.Controls.Add(Me.txtCod3)
        Me.Panel1.Controls.Add(Me.txtCod2)
        Me.Panel1.Controls.Add(Me.txtCod1)
        Me.Panel1.Controls.Add(Me.KryptonTextBox1)
        Me.Panel1.Controls.Add(Me.KryptonLabel4)
        Me.Panel1.Controls.Add(Me.txtCodCompa)
        Me.Panel1.Controls.Add(Me.txtDpto)
        Me.Panel1.Controls.Add(Me.txtLocalidad)
        Me.Panel1.Controls.Add(Me.txtDescripcion)
        Me.Panel1.Controls.Add(Me.txtDirecc)
        Me.Panel1.Controls.Add(Me.KryptonLabel1)
        Me.Panel1.Controls.Add(Me.KryptonBorderEdge1)
        Me.Panel1.Controls.Add(Me.txtAbre)
        Me.Panel1.Controls.Add(Me.KryptonLabel16)
        Me.Panel1.Controls.Add(Me.KryptonLabel5)
        Me.Panel1.Controls.Add(Me.KryptonLabel6)
        Me.Panel1.Controls.Add(Me.KryptonLabel12)
        Me.Panel1.Controls.Add(Me.KryptonLabel8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1195, 155)
        Me.Panel1.TabIndex = 61
        '
        'txtCodEmpleado
        '
        Me.txtCodEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodEmpleado.Enabled = False
        Me.txtCodEmpleado.Location = New System.Drawing.Point(130, 16)
        Me.txtCodEmpleado.MaxLength = 6
        Me.txtCodEmpleado.Name = "txtCodEmpleado"
        Me.txtCodEmpleado.Size = New System.Drawing.Size(161, 22)
        Me.txtCodEmpleado.TabIndex = 1
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(11, 17)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(50, 22)
        Me.KryptonLabel9.TabIndex = 0
        Me.KryptonLabel9.Text = "Código"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Código"
        '
        'txtCod3
        '
        Me.txtCod3.Location = New System.Drawing.Point(1173, 118)
        Me.txtCod3.Name = "txtCod3"
        Me.txtCod3.Size = New System.Drawing.Size(0, 20)
        Me.txtCod3.TabIndex = 56
        Me.txtCod3.Visible = False
        '
        'txtCod2
        '
        Me.txtCod2.Location = New System.Drawing.Point(1150, 117)
        Me.txtCod2.Name = "txtCod2"
        Me.txtCod2.Size = New System.Drawing.Size(0, 20)
        Me.txtCod2.TabIndex = 55
        Me.txtCod2.Visible = False
        '
        'txtCod1
        '
        Me.txtCod1.Location = New System.Drawing.Point(1134, 117)
        Me.txtCod1.Name = "txtCod1"
        Me.txtCod1.Size = New System.Drawing.Size(0, 20)
        Me.txtCod1.TabIndex = 54
        Me.txtCod1.Visible = False
        '
        'KryptonTextBox1
        '
        Me.KryptonTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.KryptonTextBox1.Enabled = False
        Me.KryptonTextBox1.Location = New System.Drawing.Point(520, 16)
        Me.KryptonTextBox1.MaxLength = 17
        Me.KryptonTextBox1.Name = "KryptonTextBox1"
        Me.KryptonTextBox1.Size = New System.Drawing.Size(161, 22)
        Me.KryptonTextBox1.TabIndex = 53
        Me.KryptonTextBox1.Visible = False
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(410, 17)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(58, 22)
        Me.KryptonLabel4.TabIndex = 52
        Me.KryptonLabel4.Text = "Cod SAP"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Cod SAP"
        Me.KryptonLabel4.Visible = False
        '
        'txtCodCompa
        '
        Me.txtCodCompa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodCompa.Enabled = False
        Me.txtCodCompa.Location = New System.Drawing.Point(520, 109)
        Me.txtCodCompa.MaxLength = 17
        Me.txtCodCompa.Name = "txtCodCompa"
        Me.txtCodCompa.Size = New System.Drawing.Size(161, 22)
        Me.txtCodCompa.TabIndex = 50
        Me.txtCodCompa.Visible = False
        '
        'txtDpto
        '
        Me.txtDpto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDpto.Enabled = False
        Me.txtDpto.Location = New System.Drawing.Point(520, 78)
        Me.txtDpto.MaxLength = 15
        Me.txtDpto.Name = "txtDpto"
        Me.txtDpto.Size = New System.Drawing.Size(239, 22)
        Me.txtDpto.TabIndex = 11
        '
        'txtLocalidad
        '
        Me.txtLocalidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLocalidad.Enabled = False
        Me.txtLocalidad.Location = New System.Drawing.Point(520, 47)
        Me.txtLocalidad.MaxLength = 15
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(239, 22)
        Me.txtLocalidad.TabIndex = 9
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(130, 47)
        Me.txtDescripcion.MaxLength = 30
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(250, 22)
        Me.txtDescripcion.TabIndex = 3
        '
        'txtDirecc
        '
        Me.txtDirecc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDirecc.Enabled = False
        Me.txtDirecc.Location = New System.Drawing.Point(130, 109)
        Me.txtDirecc.MaxLength = 35
        Me.txtDirecc.Name = "txtDirecc"
        Me.txtDirecc.Size = New System.Drawing.Size(250, 22)
        Me.txtDirecc.TabIndex = 7
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(11, 48)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(124, 22)
        Me.KryptonLabel1.TabIndex = 2
        Me.KryptonLabel1.Text = "Apellidos y Nombres"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Apellidos y Nombres"
        '
        'KryptonBorderEdge1
        '
        Me.KryptonBorderEdge1.Location = New System.Drawing.Point(394, 10)
        Me.KryptonBorderEdge1.Name = "KryptonBorderEdge1"
        Me.KryptonBorderEdge1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge1.Size = New System.Drawing.Size(1, 140)
        Me.KryptonBorderEdge1.TabIndex = 33
        Me.KryptonBorderEdge1.Text = "KryptonBorderEdge1"
        '
        'txtAbre
        '
        Me.txtAbre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbre.Enabled = False
        Me.txtAbre.Location = New System.Drawing.Point(130, 78)
        Me.txtAbre.MaxLength = 15
        Me.txtAbre.Name = "txtAbre"
        Me.txtAbre.Size = New System.Drawing.Size(250, 22)
        Me.txtAbre.TabIndex = 5
        '
        'KryptonLabel16
        '
        Me.KryptonLabel16.Location = New System.Drawing.Point(11, 110)
        Me.KryptonLabel16.Name = "KryptonLabel16"
        Me.KryptonLabel16.Size = New System.Drawing.Size(62, 22)
        Me.KryptonLabel16.TabIndex = 6
        Me.KryptonLabel16.Text = "Dirección"
        Me.KryptonLabel16.Values.ExtraText = ""
        Me.KryptonLabel16.Values.Image = Nothing
        Me.KryptonLabel16.Values.Text = "Dirección"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(411, 48)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(62, 22)
        Me.KryptonLabel5.TabIndex = 8
        Me.KryptonLabel5.Text = "Localidad"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Localidad"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(411, 79)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(89, 22)
        Me.KryptonLabel6.TabIndex = 10
        Me.KryptonLabel6.Text = "Departamento"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Departamento"
        '
        'KryptonLabel12
        '
        Me.KryptonLabel12.Location = New System.Drawing.Point(411, 110)
        Me.KryptonLabel12.Name = "KryptonLabel12"
        Me.KryptonLabel12.Size = New System.Drawing.Size(66, 22)
        Me.KryptonLabel12.TabIndex = 17
        Me.KryptonLabel12.Text = "Compañia"
        Me.KryptonLabel12.Values.ExtraText = ""
        Me.KryptonLabel12.Values.Image = Nothing
        Me.KryptonLabel12.Values.Text = "Compañia"
        Me.KryptonLabel12.Visible = False
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(11, 79)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(65, 22)
        Me.KryptonLabel8.TabIndex = 4
        Me.KryptonLabel8.Text = "Abreviada"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Abreviada"
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.ToolStripSeparator1, Me.btnGuardar, Me.ToolStripSeparator2, Me.btnCancelar, Me.ToolStripSeparator3, Me.btnEliminar, Me.ToolStripSeparator4, Me.ToolStripLabel1, Me.cboPaginas})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(1195, 25)
        Me.MenuBar.TabIndex = 0
        Me.MenuBar.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(62, 22)
        Me.btnNuevo.Text = "Nuevo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(69, 22)
        Me.btnGuardar.Text = "&Guardar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources._stop
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(73, 22)
        Me.btnCancelar.Text = "&Cancelar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.SOLMIN_ST.My.Resources.Resources.db_remove
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(70, 22)
        Me.btnEliminar.Text = "&Eliminar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(48, 22)
        Me.ToolStripLabel1.Text = "Paginas"
        Me.ToolStripLabel1.Visible = False
        '
        'cboPaginas
        '
        Me.cboPaginas.Name = "cboPaginas"
        Me.cboPaginas.Size = New System.Drawing.Size(121, 25)
        Me.cboPaginas.Visible = False
        '
        'PanelFiltros
        '
        Me.PanelFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnImprimir, Me.btnBuscar})
        Me.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFiltros.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.PanelFiltros.HeaderVisiblePrimary = False
        Me.PanelFiltros.Location = New System.Drawing.Point(0, 0)
        Me.PanelFiltros.Name = "PanelFiltros"
        '
        'PanelFiltros.Panel
        '
        Me.PanelFiltros.Panel.Controls.Add(Me.cboTipoEmpleado)
        Me.PanelFiltros.Panel.Controls.Add(Me.cboCompania)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel7)
        Me.PanelFiltros.Panel.Controls.Add(Me.txtNombreBusqueda)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel3)
        Me.PanelFiltros.Size = New System.Drawing.Size(1197, 71)
        Me.PanelFiltros.TabIndex = 2
        Me.PanelFiltros.ValuesPrimary.Description = ""
        Me.PanelFiltros.ValuesPrimary.Heading = ""
        Me.PanelFiltros.ValuesPrimary.Image = Nothing
        Me.PanelFiltros.ValuesSecondary.Description = ""
        Me.PanelFiltros.ValuesSecondary.Heading = "Lista de Empleados"
        Me.PanelFiltros.ValuesSecondary.Image = Nothing
        '
        'btnImprimir
        '
        Me.btnImprimir.ExtraText = ""
        Me.btnImprimir.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnImprimir.Image = Global.SOLMIN_ST.My.Resources.Resources.printer2
        Me.btnImprimir.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.ToolTipBody = "Imprimir"
        Me.btnImprimir.ToolTipImage = Nothing
        Me.btnImprimir.UniqueName = "DF44F8FC66B148BCDF44F8FC66B148BC"
        '
        'btnBuscar
        '
        Me.btnBuscar.ExtraText = ""
        Me.btnBuscar.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnBuscar.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.btnBuscar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.ToolTipImage = Nothing
        Me.btnBuscar.UniqueName = "1C2A7D5FDF6E451A1C2A7D5FDF6E451A"
        '
        'cboTipoEmpleado
        '
        Me.cboTipoEmpleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoEmpleado.DropDownWidth = 232
        Me.cboTipoEmpleado.FormattingEnabled = False
        Me.cboTipoEmpleado.ItemHeight = 15
        Me.cboTipoEmpleado.Location = New System.Drawing.Point(433, 10)
        Me.cboTipoEmpleado.Name = "cboTipoEmpleado"
        Me.cboTipoEmpleado.Size = New System.Drawing.Size(208, 23)
        Me.cboTipoEmpleado.TabIndex = 3
        Me.cboTipoEmpleado.TabStop = False
        '
        'cboCompania
        '
        Me.cboCompania.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCompania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompania.DropDownWidth = 248
        Me.cboCompania.FormattingEnabled = False
        Me.cboCompania.ItemHeight = 15
        Me.cboCompania.Location = New System.Drawing.Point(81, 10)
        Me.cboCompania.Name = "cboCompania"
        Me.cboCompania.Size = New System.Drawing.Size(248, 23)
        Me.cboCompania.TabIndex = 1
        Me.cboCompania.TabStop = False
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(341, 11)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(92, 22)
        Me.KryptonLabel2.TabIndex = 2
        Me.KryptonLabel2.Text = "Tipo Empleado"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Tipo Empleado"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(11, 11)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(66, 22)
        Me.KryptonLabel7.TabIndex = 0
        Me.KryptonLabel7.Text = "Compañía"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Compañía"
        '
        'txtNombreBusqueda
        '
        Me.txtNombreBusqueda.AcceptsReturn = True
        Me.txtNombreBusqueda.Location = New System.Drawing.Point(771, 10)
        Me.txtNombreBusqueda.MaxLength = 45
        Me.txtNombreBusqueda.Name = "txtNombreBusqueda"
        Me.txtNombreBusqueda.Size = New System.Drawing.Size(248, 22)
        Me.txtNombreBusqueda.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNombreBusqueda.TabIndex = 5
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(664, 11)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(111, 22)
        Me.KryptonLabel3.TabIndex = 4
        Me.KryptonLabel3.Text = "Codigo Empleado:"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Codigo Empleado:"
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'btnIrInicio
        '
        Me.btnIrInicio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnIrInicio.Image = CType(resources.GetObject("btnIrInicio.Image"), System.Drawing.Image)
        Me.btnIrInicio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnIrInicio.Name = "btnIrInicio"
        Me.btnIrInicio.Size = New System.Drawing.Size(23, 22)
        Me.btnIrInicio.Text = "<<"
        Me.btnIrInicio.ToolTipText = "Ir al Inicio"
        '
        'tssSep_001
        '
        Me.tssSep_001.Name = "tssSep_001"
        Me.tssSep_001.Size = New System.Drawing.Size(6, 25)
        '
        'btnIrAnterior
        '
        Me.btnIrAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnIrAnterior.Image = CType(resources.GetObject("btnIrAnterior.Image"), System.Drawing.Image)
        Me.btnIrAnterior.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnIrAnterior.Name = "btnIrAnterior"
        Me.btnIrAnterior.Size = New System.Drawing.Size(23, 22)
        Me.btnIrAnterior.Text = "<"
        Me.btnIrAnterior.ToolTipText = "Ir al Anterior"
        '
        'tssSep_002
        '
        Me.tssSep_002.Name = "tssSep_002"
        Me.tssSep_002.Size = New System.Drawing.Size(6, 25)
        '
        'txtPaginaActual
        '
        Me.txtPaginaActual.Name = "txtPaginaActual"
        Me.txtPaginaActual.Size = New System.Drawing.Size(40, 25)
        Me.txtPaginaActual.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPaginaActual.ToolTipText = "Página Actual"
        '
        'tssSep_003
        '
        Me.tssSep_003.Name = "tssSep_003"
        Me.tssSep_003.Size = New System.Drawing.Size(6, 25)
        '
        'btnIrSiguiente
        '
        Me.btnIrSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnIrSiguiente.Image = CType(resources.GetObject("btnIrSiguiente.Image"), System.Drawing.Image)
        Me.btnIrSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnIrSiguiente.Name = "btnIrSiguiente"
        Me.btnIrSiguiente.Size = New System.Drawing.Size(23, 22)
        Me.btnIrSiguiente.Text = ">"
        Me.btnIrSiguiente.ToolTipText = "Ir Siguiente"
        '
        'tssSep_004
        '
        Me.tssSep_004.Name = "tssSep_004"
        Me.tssSep_004.Size = New System.Drawing.Size(6, 25)
        '
        'btnIrFinal
        '
        Me.btnIrFinal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnIrFinal.Image = CType(resources.GetObject("btnIrFinal.Image"), System.Drawing.Image)
        Me.btnIrFinal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnIrFinal.Name = "btnIrFinal"
        Me.btnIrFinal.Size = New System.Drawing.Size(23, 22)
        Me.btnIrFinal.Text = ">>"
        Me.btnIrFinal.ToolTipText = "Ir al Final"
        '
        'tssSep_005
        '
        Me.tssSep_005.Name = "tssSep_005"
        Me.tssSep_005.Size = New System.Drawing.Size(6, 25)
        '
        'txtNroTotalPagina
        '
        Me.txtNroTotalPagina.Name = "txtNroTotalPagina"
        Me.txtNroTotalPagina.ReadOnly = True
        Me.txtNroTotalPagina.Size = New System.Drawing.Size(40, 25)
        Me.txtNroTotalPagina.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtNroTotalPagina.ToolTipText = "Total de Páginas para la Consulta realizada"
        '
        'tssSep_006
        '
        Me.tssSep_006.Name = "tssSep_006"
        Me.tssSep_006.Size = New System.Drawing.Size(6, 25)
        '
        'lblNroRegPagina
        '
        Me.lblNroRegPagina.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroRegPagina.Name = "lblNroRegPagina"
        Me.lblNroRegPagina.Size = New System.Drawing.Size(89, 22)
        Me.lblNroRegPagina.Text = "Nro. Reg. Pág. : "
        '
        'txtNroRegPorPagina
        '
        Me.txtNroRegPorPagina.Name = "txtNroRegPorPagina"
        Me.txtNroRegPorPagina.Size = New System.Drawing.Size(40, 25)
        Me.txtNroRegPorPagina.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "COBRR"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TNMBOB"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TCATEG"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Categoria Chofer"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "SCATEG"
        Me.DataGridViewTextBoxColumn4.HeaderText = "SCATEG"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SACTIN"
        Me.DataGridViewTextBoxColumn5.HeaderText = "SACTIN"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "FINGCH"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Fecha de Ingreso "
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "FVNCCR"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Fecha Vencimiento Contrato"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CMTCDS"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Matchcode SAP"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "CCMPN"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Compañia"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        Me.DataGridViewTextBoxColumn9.Width = 119
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CDVSN"
        Me.DataGridViewTextBoxColumn10.HeaderText = "División"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        Me.DataGridViewTextBoxColumn10.Width = 119
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "CPLNDV"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Planta"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        Me.DataGridViewTextBoxColumn11.Width = 104
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "CSCDSP"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Codigo SAP"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        Me.DataGridViewTextBoxColumn12.Width = 89
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "PERNR"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Numero de Personal"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 90
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "CCENPL"
        Me.DataGridViewTextBoxColumn14.HeaderText = "CENPLA"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        Me.DataGridViewTextBoxColumn14.Width = 90
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "TDSCTR"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Descripcion Control"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        Me.DataGridViewTextBoxColumn15.Width = 90
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "SESTRG"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        Me.DataGridViewTextBoxColumn16.Width = 90
        '
        'frmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 659)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmEmpleados"
        Me.Text = "Empleados"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        Me.tsMenuNavegacion.ResumeLayout(False)
        Me.tsMenuNavegacion.PerformLayout()
        CType(Me.dtgEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderDatos.Panel.ResumeLayout(False)
        Me.HeaderDatos.Panel.PerformLayout()
        CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderDatos.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.Panel.ResumeLayout(False)
        Me.PanelFiltros.Panel.PerformLayout()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.ResumeLayout(False)
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
    Friend WithEvents PanelFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnBuscar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnImprimir As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents cboTipoEmpleado As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents cboCompania As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNombreBusqueda As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents HeaderDatos As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
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
    Friend WithEvents KryptonTextBox5 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cboPaginas As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Private WithEvents btnIrInicio As System.Windows.Forms.ToolStripButton
    Private WithEvents tssSep_001 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents btnIrAnterior As System.Windows.Forms.ToolStripButton
    Private WithEvents tssSep_002 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents txtPaginaActual As System.Windows.Forms.ToolStripTextBox
    Private WithEvents tssSep_003 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents btnIrSiguiente As System.Windows.Forms.ToolStripButton
    Private WithEvents tssSep_004 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents btnIrFinal As System.Windows.Forms.ToolStripButton
    Private WithEvents tssSep_005 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents txtNroTotalPagina As System.Windows.Forms.ToolStripTextBox
    Private WithEvents tssSep_006 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents lblNroRegPagina As System.Windows.Forms.ToolStripLabel
    Private WithEvents txtNroRegPorPagina As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtCodEmpleado As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCod3 As System.Windows.Forms.TextBox
    Friend WithEvents txtCod2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCod1 As System.Windows.Forms.TextBox
    Friend WithEvents KryptonTextBox1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCodCompa As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtDpto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtLocalidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtDescripcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtDirecc As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonBorderEdge1 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents txtAbre As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel16 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Private WithEvents tsMenuNavegacion As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Private WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Private WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Private WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Private WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Private WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Private WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Private WithEvents ToolStripTextBox3 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents dtgEmpleado As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents COBRR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TNMBOB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCATEG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SCATEG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TABREM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDRCEM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TLCLEM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDPTEM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCECOE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCMPN1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNT5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CSCDSP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PERNR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCENPL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDSCTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
