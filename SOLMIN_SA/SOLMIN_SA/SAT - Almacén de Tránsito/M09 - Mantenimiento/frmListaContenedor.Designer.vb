<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaContenedor
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaContenedor))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dgContenedores = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.PSCPRPCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNSRECN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSDESCMTRCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCMTRCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSDESCCLOR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCCLOR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSDESCTPOC1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCTPOC1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCDMNCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNQTRACN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNQPSMXC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNQCPCBC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DESFFACCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DESFINCSC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSDESSESCN1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TPLNTA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CREFFW = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FREFFW = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NGRPRV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FSLFFW = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NGUIRM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMTRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GUIA_TRANS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMLCL_OR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMLCL_DES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TNMMDT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UBICACION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.tss04 = New System.Windows.Forms.ToolStripSeparator
        Me.btnExportarExcel = New System.Windows.Forms.ToolStripButton
        Me.tss03 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.tss02 = New System.Windows.Forms.ToolStripSeparator
        Me.btnModificar = New System.Windows.Forms.ToolStripButton
        Me.tss01 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAgregar = New System.Windows.Forms.ToolStripButton
        Me.lblTitulo = New System.Windows.Forms.ToolStripLabel
        Me.khgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cboEstado = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.txtNumero = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtSigla = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcCompania = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnProcesar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgContenedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.khgFiltros.Panel.SuspendLayout()
        Me.khgFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgContenedores)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Controls.Add(Me.khgFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1101, 508)
        Me.KryptonPanel.TabIndex = 0
        '
        'dgContenedores
        '
        Me.dgContenedores.AllowUserToAddRows = False
        Me.dgContenedores.AllowUserToDeleteRows = False
        Me.dgContenedores.AllowUserToResizeColumns = False
        Me.dgContenedores.AllowUserToResizeRows = False
        Me.dgContenedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgContenedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PSCPRPCN, Me.PSNSRECN, Me.PSDESCMTRCN, Me.PSCMTRCN, Me.PSDESCCLOR, Me.PSCCLOR, Me.PSDESCTPOC1, Me.PSCTPOC1, Me.PSCDMNCN, Me.PNQTRACN, Me.PNQPSMXC, Me.PNQCPCBC, Me.DESFFACCN, Me.DESFINCSC, Me.PSDESSESCN1, Me.TPLNTA, Me.CREFFW, Me.FREFFW, Me.NGRPRV, Me.FSLFFW, Me.NGUIRM, Me.TCMTRT, Me.GUIA_TRANS, Me.TCMLCL_OR, Me.TCMLCL_DES, Me.TNMMDT, Me.UBICACION})
        Me.dgContenedores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgContenedores.Location = New System.Drawing.Point(0, 140)
        Me.dgContenedores.MultiSelect = False
        Me.dgContenedores.Name = "dgContenedores"
        Me.dgContenedores.ReadOnly = True
        Me.dgContenedores.RowHeadersWidth = 20
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgContenedores.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgContenedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgContenedores.Size = New System.Drawing.Size(1101, 368)
        Me.dgContenedores.StandardTab = True
        Me.dgContenedores.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgContenedores.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgContenedores.TabIndex = 76
        '
        'PSCPRPCN
        '
        Me.PSCPRPCN.DataPropertyName = "PSCPRPCN"
        Me.PSCPRPCN.HeaderText = "Sigla"
        Me.PSCPRPCN.Name = "PSCPRPCN"
        Me.PSCPRPCN.ReadOnly = True
        Me.PSCPRPCN.Width = 61
        '
        'PSNSRECN
        '
        Me.PSNSRECN.DataPropertyName = "PSNSRECN"
        Me.PSNSRECN.HeaderText = "Número"
        Me.PSNSRECN.Name = "PSNSRECN"
        Me.PSNSRECN.ReadOnly = True
        Me.PSNSRECN.Width = 77
        '
        'PSDESCMTRCN
        '
        Me.PSDESCMTRCN.DataPropertyName = "PSDESCMTRCN"
        Me.PSDESCMTRCN.HeaderText = "Material de Construcción"
        Me.PSDESCMTRCN.Name = "PSDESCMTRCN"
        Me.PSDESCMTRCN.ReadOnly = True
        Me.PSDESCMTRCN.Width = 165
        '
        'PSCMTRCN
        '
        Me.PSCMTRCN.DataPropertyName = "PSCMTRCN"
        Me.PSCMTRCN.HeaderText = "PSCMTRCN"
        Me.PSCMTRCN.Name = "PSCMTRCN"
        Me.PSCMTRCN.ReadOnly = True
        Me.PSCMTRCN.Visible = False
        Me.PSCMTRCN.Width = 92
        '
        'PSDESCCLOR
        '
        Me.PSDESCCLOR.DataPropertyName = "PSDESCCLOR"
        Me.PSDESCCLOR.HeaderText = "Color"
        Me.PSDESCCLOR.Name = "PSDESCCLOR"
        Me.PSDESCCLOR.ReadOnly = True
        '
        'PSCCLOR
        '
        Me.PSCCLOR.DataPropertyName = "PSCCLOR"
        Me.PSCCLOR.HeaderText = "PSCCLOR"
        Me.PSCCLOR.Name = "PSCCLOR"
        Me.PSCCLOR.ReadOnly = True
        Me.PSCCLOR.Visible = False
        Me.PSCCLOR.Width = 83
        '
        'PSDESCTPOC1
        '
        Me.PSDESCTPOC1.DataPropertyName = "PSDESCTPOC1"
        Me.PSDESCTPOC1.HeaderText = "Tipo"
        Me.PSDESCTPOC1.Name = "PSDESCTPOC1"
        Me.PSDESCTPOC1.ReadOnly = True
        Me.PSDESCTPOC1.Width = 120
        '
        'PSCTPOC1
        '
        Me.PSCTPOC1.DataPropertyName = "PSCTPOC1"
        Me.PSCTPOC1.HeaderText = "PSCTPOC1"
        Me.PSCTPOC1.Name = "PSCTPOC1"
        Me.PSCTPOC1.ReadOnly = True
        Me.PSCTPOC1.Visible = False
        Me.PSCTPOC1.Width = 88
        '
        'PSCDMNCN
        '
        Me.PSCDMNCN.DataPropertyName = "PSCDMNCN"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.PSCDMNCN.DefaultCellStyle = DataGridViewCellStyle1
        Me.PSCDMNCN.HeaderText = "Dimensión"
        Me.PSCDMNCN.Name = "PSCDMNCN"
        Me.PSCDMNCN.ReadOnly = True
        Me.PSCDMNCN.Width = 65
        '
        'PNQTRACN
        '
        Me.PNQTRACN.DataPropertyName = "PNQTRACN"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.PNQTRACN.DefaultCellStyle = DataGridViewCellStyle2
        Me.PNQTRACN.HeaderText = "Tara"
        Me.PNQTRACN.Name = "PNQTRACN"
        Me.PNQTRACN.ReadOnly = True
        Me.PNQTRACN.Width = 57
        '
        'PNQPSMXC
        '
        Me.PNQPSMXC.DataPropertyName = "PNQPSMXC"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.PNQPSMXC.DefaultCellStyle = DataGridViewCellStyle3
        Me.PNQPSMXC.HeaderText = "Carga Util"
        Me.PNQPSMXC.Name = "PNQPSMXC"
        Me.PNQPSMXC.ReadOnly = True
        Me.PNQPSMXC.Width = 67
        '
        'PNQCPCBC
        '
        Me.PNQCPCBC.DataPropertyName = "PNQCPCBC"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.PNQCPCBC.DefaultCellStyle = DataGridViewCellStyle4
        Me.PNQCPCBC.HeaderText = "Capacidad Cubica"
        Me.PNQCPCBC.Name = "PNQCPCBC"
        Me.PNQCPCBC.ReadOnly = True
        '
        'DESFFACCN
        '
        Me.DESFFACCN.DataPropertyName = "PSDESFFACCN"
        Me.DESFFACCN.HeaderText = "Fecha fabricación"
        Me.DESFFACCN.Name = "DESFFACCN"
        Me.DESFFACCN.ReadOnly = True
        Me.DESFFACCN.Width = 126
        '
        'DESFINCSC
        '
        Me.DESFINCSC.DataPropertyName = "PSDESFINCSC"
        Me.DESFINCSC.HeaderText = "Fecha Inspección"
        Me.DESFINCSC.Name = "DESFINCSC"
        Me.DESFINCSC.ReadOnly = True
        Me.DESFINCSC.Width = 124
        '
        'PSDESSESCN1
        '
        Me.PSDESSESCN1.DataPropertyName = "PSDESSESCN1"
        Me.PSDESSESCN1.HeaderText = "Estado"
        Me.PSDESSESCN1.Name = "PSDESSESCN1"
        Me.PSDESSESCN1.ReadOnly = True
        '
        'TPLNTA
        '
        Me.TPLNTA.DataPropertyName = "PSTPLNTA"
        Me.TPLNTA.HeaderText = "Planta"
        Me.TPLNTA.Name = "TPLNTA"
        Me.TPLNTA.ReadOnly = True
        '
        'CREFFW
        '
        Me.CREFFW.DataPropertyName = "PSCREFFW"
        Me.CREFFW.HeaderText = "Bulto"
        Me.CREFFW.Name = "CREFFW"
        Me.CREFFW.ReadOnly = True
        '
        'FREFFW
        '
        Me.FREFFW.DataPropertyName = "PSFechaIngreso"
        Me.FREFFW.HeaderText = "Fecha Ingreso"
        Me.FREFFW.Name = "FREFFW"
        Me.FREFFW.ReadOnly = True
        '
        'NGRPRV
        '
        Me.NGRPRV.DataPropertyName = "PSNGRPRV"
        Me.NGRPRV.HeaderText = "Guía Proveedor"
        Me.NGRPRV.Name = "NGRPRV"
        Me.NGRPRV.ReadOnly = True
        '
        'FSLFFW
        '
        Me.FSLFFW.DataPropertyName = "PSFechaSalida"
        Me.FSLFFW.HeaderText = "Fecha Salida"
        Me.FSLFFW.Name = "FSLFFW"
        Me.FSLFFW.ReadOnly = True
        '
        'NGUIRM
        '
        Me.NGUIRM.DataPropertyName = "PSNGUIRM"
        Me.NGUIRM.HeaderText = "Guía Remisión"
        Me.NGUIRM.Name = "NGUIRM"
        Me.NGUIRM.ReadOnly = True
        '
        'TCMTRT
        '
        Me.TCMTRT.DataPropertyName = "PSTCMTRT"
        Me.TCMTRT.HeaderText = "Transportista"
        Me.TCMTRT.Name = "TCMTRT"
        Me.TCMTRT.ReadOnly = True
        '
        'GUIA_TRANS
        '
        Me.GUIA_TRANS.DataPropertyName = "PSGUIA_TRANS"
        Me.GUIA_TRANS.HeaderText = "Guía Transporte"
        Me.GUIA_TRANS.Name = "GUIA_TRANS"
        Me.GUIA_TRANS.ReadOnly = True
        '
        'TCMLCL_OR
        '
        Me.TCMLCL_OR.DataPropertyName = "PSTCMLCL_OR"
        Me.TCMLCL_OR.HeaderText = "Origén"
        Me.TCMLCL_OR.Name = "TCMLCL_OR"
        Me.TCMLCL_OR.ReadOnly = True
        '
        'TCMLCL_DES
        '
        Me.TCMLCL_DES.DataPropertyName = "PSTCMLCL_DES"
        Me.TCMLCL_DES.HeaderText = "Destino"
        Me.TCMLCL_DES.Name = "TCMLCL_DES"
        Me.TCMLCL_DES.ReadOnly = True
        '
        'TNMMDT
        '
        Me.TNMMDT.DataPropertyName = "PSTNMMDT"
        Me.TNMMDT.HeaderText = "Medio"
        Me.TNMMDT.Name = "TNMMDT"
        Me.TNMMDT.ReadOnly = True
        '
        'UBICACION
        '
        Me.UBICACION.DataPropertyName = "PSUBICACION"
        Me.UBICACION.HeaderText = "Ubicación"
        Me.UBICACION.Name = "UBICACION"
        Me.UBICACION.ReadOnly = True
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss04, Me.btnExportarExcel, Me.tss03, Me.btnEliminar, Me.tss02, Me.btnModificar, Me.tss01, Me.btnAgregar, Me.lblTitulo})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 115)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(1101, 25)
        Me.tsMenuOpciones.TabIndex = 75
        '
        'tss04
        '
        Me.tss04.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss04.Name = "tss04"
        Me.tss04.Size = New System.Drawing.Size(6, 25)
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExportarExcel.Image = Global.SOLMIN_SA.My.Resources.Resources.excelicon
        Me.btnExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(98, 22)
        Me.btnExportarExcel.Text = "Exportar Excel"
        '
        'tss03
        '
        Me.tss03.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss03.Name = "tss03"
        Me.tss03.Size = New System.Drawing.Size(6, 25)
        '
        'btnEliminar
        '
        Me.btnEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminar.Image = Global.SOLMIN_SA.My.Resources.Resources.button_cancel
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(68, 22)
        Me.btnEliminar.Text = "Eliminar"
        '
        'tss02
        '
        Me.tss02.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss02.Name = "tss02"
        Me.tss02.Size = New System.Drawing.Size(6, 25)
        '
        'btnModificar
        '
        Me.btnModificar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnModificar.Image = Global.SOLMIN_SA.My.Resources.Resources.retencion
        Me.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(76, 22)
        Me.btnModificar.Text = "Modificar"
        '
        'tss01
        '
        Me.tss01.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss01.Name = "tss01"
        Me.tss01.Size = New System.Drawing.Size(6, 25)
        '
        'btnAgregar
        '
        Me.btnAgregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAgregar.Image = Global.SOLMIN_SA.My.Resources.Resources.edit_add
        Me.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(68, 22)
        Me.btnAgregar.Text = "Agregar"
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(85, 22)
        Me.lblTitulo.Text = "Contenedores"
        '
        'khgFiltros
        '
        Me.khgFiltros.AutoSize = True
        Me.khgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaOcultarFiltros, Me.bsaCerrar})
        Me.khgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.khgFiltros.HeaderVisibleSecondary = False
        Me.khgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.khgFiltros.Name = "khgFiltros"
        '
        'khgFiltros.Panel
        '
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.khgFiltros.Panel.Controls.Add(Me.cboEstado)
        Me.khgFiltros.Panel.Controls.Add(Me.txtNumero)
        Me.khgFiltros.Panel.Controls.Add(Me.txtSigla)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel3)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.khgFiltros.Panel.Controls.Add(Me.UcCompania)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.khgFiltros.Panel.Controls.Add(Me.btnProcesar)
        Me.khgFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel4)
        Me.khgFiltros.Size = New System.Drawing.Size(1101, 115)
        Me.khgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.khgFiltros.TabIndex = 74
        Me.khgFiltros.Text = "Filtros"
        Me.khgFiltros.ValuesPrimary.Description = ""
        Me.khgFiltros.ValuesPrimary.Heading = "Filtros"
        Me.khgFiltros.ValuesPrimary.Image = Nothing
        Me.khgFiltros.ValuesSecondary.Description = ""
        Me.khgFiltros.ValuesSecondary.Heading = "Resultado"
        Me.khgFiltros.ValuesSecondary.Image = Nothing
        '
        'bsaOcultarFiltros
        '
        Me.bsaOcultarFiltros.ExtraText = ""
        Me.bsaOcultarFiltros.Image = Nothing
        Me.bsaOcultarFiltros.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaOcultarFiltros.Text = "Ocultar"
        Me.bsaOcultarFiltros.ToolTipImage = Nothing
        Me.bsaOcultarFiltros.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaOcultarFiltros.UniqueName = "4FD0578D687F46FC4FD0578D687F46FC"
        '
        'bsaCerrar
        '
        Me.bsaCerrar.ExtraText = ""
        Me.bsaCerrar.Image = Nothing
        Me.bsaCerrar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaCerrar.Text = "Cerrar"
        Me.bsaCerrar.ToolTipImage = Nothing
        Me.bsaCerrar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.bsaCerrar.UniqueName = "C90E4396C7B04154C90E4396C7B04154"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(339, 50)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(52, 19)
        Me.KryptonLabel5.TabIndex = 78
        Me.KryptonLabel5.Text = "Estado  : "
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Estado  : "
        '
        'cboEstado
        '
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.DropDownWidth = 121
        Me.cboEstado.FormattingEnabled = False
        Me.cboEstado.ItemHeight = 13
        Me.cboEstado.Items.AddRange(New Object() {"-- Todos --", "Disponible", "No Disponible"})
        Me.cboEstado.Location = New System.Drawing.Point(396, 45)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(121, 21)
        Me.cboEstado.TabIndex = 4
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(208, 47)
        Me.txtNumero.MaxLength = 7
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 21)
        Me.txtNumero.TabIndex = 3
        '
        'txtSigla
        '
        Me.txtSigla.Location = New System.Drawing.Point(79, 47)
        Me.txtSigla.MaxLength = 4
        Me.txtSigla.Name = "txtSigla"
        Me.txtSigla.Size = New System.Drawing.Size(71, 21)
        Me.txtSigla.TabIndex = 2
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(152, 50)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(60, 19)
        Me.KryptonLabel3.TabIndex = 76
        Me.KryptonLabel3.Text = "Numero  : "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Numero  : "
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(11, 50)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(43, 19)
        Me.KryptonLabel2.TabIndex = 75
        Me.KryptonLabel2.Text = "Sigla  : "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Sigla  : "
        '
        'UcCompania
        '
        Me.UcCompania.BackColor = System.Drawing.SystemColors.Window
        Me.UcCompania.CCMPN_ANTERIOR = Nothing
        Me.UcCompania.CCMPN_CodigoCompania = Nothing
        Me.UcCompania.CCMPN_Descripcion = Nothing
        Me.UcCompania.Location = New System.Drawing.Point(79, 14)
        Me.UcCompania.MinimumSize = New System.Drawing.Size(150, 23)
        Me.UcCompania.Name = "UcCompania"
        Me.UcCompania.Size = New System.Drawing.Size(230, 23)
        Me.UcCompania.TabIndex = 0
        Me.UcCompania.Usuario = ""
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(11, 19)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(70, 19)
        Me.KryptonLabel1.TabIndex = 74
        Me.KryptonLabel1.Text = "Compañia  :"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Compañia  :"
        '
        'btnProcesar
        '
        Me.btnProcesar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcesar.Location = New System.Drawing.Point(973, 5)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(115, 78)
        Me.btnProcesar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnProcesar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnProcesar.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnProcesar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnProcesar.TabIndex = 5
        Me.btnProcesar.Text = "&Procesar"
        Me.btnProcesar.Values.ExtraText = "Consulta"
        Me.btnProcesar.Values.Image = CType(resources.GetObject("btnProcesar.Values.Image"), System.Drawing.Image)
        Me.btnProcesar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnProcesar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnProcesar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnProcesar.Values.Text = "&Procesar"
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.Location = New System.Drawing.Point(395, 15)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(381, 21)
        Me.txtCliente.TabIndex = 1
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(342, 18)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(50, 19)
        Me.KryptonLabel4.TabIndex = 63
        Me.KryptonLabel4.Text = "Cliente : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Cliente : "
        '
        'frmListaContenedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 508)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmListaContenedor"
        Me.Text = "Listado de Contenedores"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dgContenedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.Panel.ResumeLayout(False)
        Me.khgFiltros.Panel.PerformLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.ResumeLayout(False)
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
    Friend WithEvents khgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaOcultarFiltros As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaCerrar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents UcCompania As RANSA.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dgContenedores As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Friend WithEvents tss04 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblTitulo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtNumero As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtSigla As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnProcesar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboEstado As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents btnExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss03 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tss02 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tss01 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PSCPRPCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNSRECN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSDESCMTRCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCMTRCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSDESCCLOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCCLOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSDESCTPOC1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCTPOC1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCDMNCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQTRACN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQPSMXC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQCPCBC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESFFACCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESFINCSC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSDESSESCN1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TPLNTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NGRPRV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FSLFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NGUIRM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMTRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GUIA_TRANS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMLCL_OR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMLCL_DES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TNMMDT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UBICACION As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
