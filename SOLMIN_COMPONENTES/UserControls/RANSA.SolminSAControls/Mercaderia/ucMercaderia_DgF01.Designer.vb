<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMercaderia_DgF01
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucMercaderia_DgF01))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.lblMercadería = New System.Windows.Forms.ToolStripLabel
        Me.btnReporte = New System.Windows.Forms.ToolStripButton
        Me.tssSep_03 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.tssSep_02 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEditar = New System.Windows.Forms.ToolStripButton
        Me.tssSep_01 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAgregar = New System.Windows.Forms.ToolStripButton
        Me.tsMenuNavegacion = New System.Windows.Forms.ToolStrip
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
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        Me.dstMercaderia = New System.Data.DataSet
        Me.dtMercaderia = New System.Data.DataTable
        Me.CMRCLR = New System.Data.DataColumn
        Me.TMRCD2 = New System.Data.DataColumn
        Me.CMRCD = New System.Data.DataColumn
        Me.FPUWEB = New System.Data.DataColumn
        Me.CFMCLR = New System.Data.DataColumn
        Me.TFMCLR = New System.Data.DataColumn
        Me.CGRCLR = New System.Data.DataColumn
        Me.TGRCLR = New System.Data.DataColumn
        Me.IMVTAD = New System.Data.DataColumn
        Me.IMVTAS = New System.Data.DataColumn
        Me.TMRCTR = New System.Data.DataColumn
        Me.FVNCMR = New System.Data.DataColumn
        Me.FINVRN = New System.Data.DataColumn
        Me.CPTDAR = New System.Data.DataColumn
        Me.SESTRG = New System.Data.DataColumn
        Me.dgMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.M_CMRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TMRCD2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CMRCD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_FPUWEB = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.M_CFMCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TFMCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CGRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TGRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_IMVTAD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_IMVTAS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TMRCTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_FVNCMR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_FINVRN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CPTDAR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tsMenuOpciones.SuspendLayout()
        Me.tsMenuNavegacion.SuspendLayout()
        CType(Me.dstMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblMercadería, Me.btnReporte, Me.tssSep_03, Me.btnEliminar, Me.tssSep_02, Me.btnEditar, Me.tssSep_01, Me.btnAgregar})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(796, 25)
        Me.tsMenuOpciones.TabIndex = 23
        '
        'lblMercadería
        '
        Me.lblMercadería.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMercadería.Name = "lblMercadería"
        Me.lblMercadería.Size = New System.Drawing.Size(88, 22)
        Me.lblMercadería.Tag = "MERCADERIA"
        Me.lblMercadería.Text = "MERCADERIA"
        '
        'btnReporte
        '
        Me.btnReporte.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnReporte.Image = CType(resources.GetObject("btnReporte.Image"), System.Drawing.Image)
        Me.btnReporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(65, 22)
        Me.btnReporte.Text = "&Reporte"
        '
        'tssSep_03
        '
        Me.tssSep_03.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_03.Name = "tssSep_03"
        Me.tssSep_03.Size = New System.Drawing.Size(6, 25)
        '
        'btnEliminar
        '
        Me.btnEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(63, 22)
        Me.btnEliminar.Text = "&Eliminar"
        '
        'tssSep_02
        '
        Me.tssSep_02.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_02.Name = "tssSep_02"
        Me.tssSep_02.Size = New System.Drawing.Size(6, 25)
        '
        'btnEditar
        '
        Me.btnEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(70, 22)
        Me.btnEditar.Text = "&Modificar"
        '
        'tssSep_01
        '
        Me.tssSep_01.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_01.Name = "tssSep_01"
        Me.tssSep_01.Size = New System.Drawing.Size(6, 25)
        '
        'btnAgregar
        '
        Me.btnAgregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(64, 22)
        Me.btnAgregar.Text = "&Agregar"
        '
        'tsMenuNavegacion
        '
        Me.tsMenuNavegacion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMenuNavegacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tsMenuNavegacion.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuNavegacion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnIrInicio, Me.tssSep_001, Me.btnIrAnterior, Me.tssSep_002, Me.txtPaginaActual, Me.tssSep_003, Me.btnIrSiguiente, Me.tssSep_004, Me.btnIrFinal, Me.tssSep_005, Me.txtNroTotalPagina, Me.tssSep_006, Me.lblNroRegPagina, Me.txtNroRegPorPagina})
        Me.tsMenuNavegacion.Location = New System.Drawing.Point(0, 210)
        Me.tsMenuNavegacion.Name = "tsMenuNavegacion"
        Me.tsMenuNavegacion.Size = New System.Drawing.Size(796, 25)
        Me.tsMenuNavegacion.TabIndex = 24
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
        'dstMercaderia
        '
        Me.dstMercaderia.DataSetName = "dstMercaderia"
        Me.dstMercaderia.Tables.AddRange(New System.Data.DataTable() {Me.dtMercaderia})
        '
        'dtMercaderia
        '
        Me.dtMercaderia.Columns.AddRange(New System.Data.DataColumn() {Me.CMRCLR, Me.TMRCD2, Me.CMRCD, Me.FPUWEB, Me.CFMCLR, Me.TFMCLR, Me.CGRCLR, Me.TGRCLR, Me.IMVTAD, Me.IMVTAS, Me.TMRCTR, Me.FVNCMR, Me.FINVRN, Me.CPTDAR, Me.SESTRG})
        Me.dtMercaderia.TableName = "dtMercaderia"
        '
        'CMRCLR
        '
        Me.CMRCLR.ColumnName = "CMRCLR"
        Me.CMRCLR.DefaultValue = ""
        '
        'TMRCD2
        '
        Me.TMRCD2.ColumnName = "TMRCD2"
        Me.TMRCD2.DefaultValue = ""
        '
        'CMRCD
        '
        Me.CMRCD.ColumnName = "CMRCD"
        Me.CMRCD.DefaultValue = ""
        '
        'FPUWEB
        '
        Me.FPUWEB.ColumnName = "FPUWEB"
        Me.FPUWEB.DefaultValue = "N"
        '
        'CFMCLR
        '
        Me.CFMCLR.ColumnName = "CFMCLR"
        Me.CFMCLR.DefaultValue = ""
        '
        'TFMCLR
        '
        Me.TFMCLR.ColumnName = "TFMCLR"
        Me.TFMCLR.DefaultValue = ""
        '
        'CGRCLR
        '
        Me.CGRCLR.ColumnName = "CGRCLR"
        Me.CGRCLR.DefaultValue = ""
        '
        'TGRCLR
        '
        Me.TGRCLR.ColumnName = "TGRCLR"
        Me.TGRCLR.DefaultValue = ""
        '
        'IMVTAD
        '
        Me.IMVTAD.ColumnName = "IMVTA$"
        Me.IMVTAD.DataType = GetType(Decimal)
        Me.IMVTAD.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'IMVTAS
        '
        Me.IMVTAS.ColumnName = "IMVTAS"
        Me.IMVTAS.DataType = GetType(Decimal)
        Me.IMVTAS.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'TMRCTR
        '
        Me.TMRCTR.ColumnName = "TMRCTR"
        Me.TMRCTR.DefaultValue = ""
        '
        'FVNCMR
        '
        Me.FVNCMR.ColumnName = "FVNCMR"
        Me.FVNCMR.DataType = GetType(Date)
        '
        'FINVRN
        '
        Me.FINVRN.ColumnName = "FINVRN"
        Me.FINVRN.DataType = GetType(Date)
        '
        'CPTDAR
        '
        Me.CPTDAR.ColumnName = "CPTDAR"
        Me.CPTDAR.DefaultValue = ""
        '
        'SESTRG
        '
        Me.SESTRG.ColumnName = "SESTRG"
        Me.SESTRG.DefaultValue = ""
        '
        'dgMercaderia
        '
        Me.dgMercaderia.AllowUserToAddRows = False
        Me.dgMercaderia.AllowUserToDeleteRows = False
        Me.dgMercaderia.AllowUserToResizeColumns = False
        Me.dgMercaderia.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon
        Me.dgMercaderia.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgMercaderia.AutoGenerateColumns = False
        Me.dgMercaderia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgMercaderia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_CMRCLR, Me.M_TMRCD2, Me.M_CMRCD, Me.M_FPUWEB, Me.M_CFMCLR, Me.M_TFMCLR, Me.M_CGRCLR, Me.M_TGRCLR, Me.M_IMVTAD, Me.M_IMVTAS, Me.M_TMRCTR, Me.M_FVNCMR, Me.M_FINVRN, Me.M_CPTDAR, Me.M_SESTRG})
        Me.dgMercaderia.DataMember = "dtMercaderia"
        Me.dgMercaderia.DataSource = Me.dstMercaderia
        Me.dgMercaderia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMercaderia.Location = New System.Drawing.Point(0, 25)
        Me.dgMercaderia.MultiSelect = False
        Me.dgMercaderia.Name = "dgMercaderia"
        Me.dgMercaderia.ReadOnly = True
        Me.dgMercaderia.RowHeadersWidth = 20
        Me.dgMercaderia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMercaderia.Size = New System.Drawing.Size(796, 185)
        Me.dgMercaderia.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgMercaderia.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dgMercaderia.TabIndex = 25
        '
        'M_CMRCLR
        '
        Me.M_CMRCLR.DataPropertyName = "CMRCLR"
        Me.M_CMRCLR.HeaderText = "Mercadería"
        Me.M_CMRCLR.Name = "M_CMRCLR"
        Me.M_CMRCLR.ReadOnly = True
        Me.M_CMRCLR.Width = 91
        '
        'M_TMRCD2
        '
        Me.M_TMRCD2.DataPropertyName = "TMRCD2"
        Me.M_TMRCD2.HeaderText = "Detalle"
        Me.M_TMRCD2.Name = "M_TMRCD2"
        Me.M_TMRCD2.ReadOnly = True
        Me.M_TMRCD2.Width = 69
        '
        'M_CMRCD
        '
        Me.M_CMRCD.DataPropertyName = "CMRCD"
        Me.M_CMRCD.HeaderText = "Código RANSA"
        Me.M_CMRCD.Name = "M_CMRCD"
        Me.M_CMRCD.ReadOnly = True
        Me.M_CMRCD.Width = 109
        '
        'M_FPUWEB
        '
        Me.M_FPUWEB.DataPropertyName = "FPUWEB"
        Me.M_FPUWEB.FalseValue = "N"
        Me.M_FPUWEB.HeaderText = "Public. WEB"
        Me.M_FPUWEB.Name = "M_FPUWEB"
        Me.M_FPUWEB.ReadOnly = True
        Me.M_FPUWEB.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.M_FPUWEB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.M_FPUWEB.TrueValue = "S"
        Me.M_FPUWEB.Width = 96
        '
        'M_CFMCLR
        '
        Me.M_CFMCLR.DataPropertyName = "CFMCLR"
        Me.M_CFMCLR.HeaderText = "Familia"
        Me.M_CFMCLR.Name = "M_CFMCLR"
        Me.M_CFMCLR.ReadOnly = True
        Me.M_CFMCLR.Width = 68
        '
        'M_TFMCLR
        '
        Me.M_TFMCLR.DataPropertyName = "TFMCLR"
        Me.M_TFMCLR.HeaderText = "Detalle"
        Me.M_TFMCLR.Name = "M_TFMCLR"
        Me.M_TFMCLR.ReadOnly = True
        Me.M_TFMCLR.Width = 69
        '
        'M_CGRCLR
        '
        Me.M_CGRCLR.DataPropertyName = "CGRCLR"
        Me.M_CGRCLR.HeaderText = "Grupo"
        Me.M_CGRCLR.Name = "M_CGRCLR"
        Me.M_CGRCLR.ReadOnly = True
        Me.M_CGRCLR.Width = 65
        '
        'M_TGRCLR
        '
        Me.M_TGRCLR.DataPropertyName = "TGRCLR"
        Me.M_TGRCLR.HeaderText = "Detalle"
        Me.M_TGRCLR.Name = "M_TGRCLR"
        Me.M_TGRCLR.ReadOnly = True
        Me.M_TGRCLR.Width = 69
        '
        'M_IMVTAD
        '
        Me.M_IMVTAD.DataPropertyName = "IMVTA$"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.M_IMVTAD.DefaultCellStyle = DataGridViewCellStyle2
        Me.M_IMVTAD.HeaderText = "Valor US$"
        Me.M_IMVTAD.Name = "M_IMVTAD"
        Me.M_IMVTAD.ReadOnly = True
        Me.M_IMVTAD.Width = 84
        '
        'M_IMVTAS
        '
        Me.M_IMVTAS.DataPropertyName = "IMVTAS"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.M_IMVTAS.DefaultCellStyle = DataGridViewCellStyle3
        Me.M_IMVTAS.HeaderText = "Valor S/."
        Me.M_IMVTAS.Name = "M_IMVTAS"
        Me.M_IMVTAS.ReadOnly = True
        Me.M_IMVTAS.Width = 78
        '
        'M_TMRCTR
        '
        Me.M_TMRCTR.DataPropertyName = "TMRCTR"
        Me.M_TMRCTR.HeaderText = "Marca"
        Me.M_TMRCTR.Name = "M_TMRCTR"
        Me.M_TMRCTR.ReadOnly = True
        Me.M_TMRCTR.Width = 66
        '
        'M_FVNCMR
        '
        Me.M_FVNCMR.DataPropertyName = "FVNCMR"
        Me.M_FVNCMR.HeaderText = "Fch. Vencimiento"
        Me.M_FVNCMR.Name = "M_FVNCMR"
        Me.M_FVNCMR.ReadOnly = True
        Me.M_FVNCMR.Width = 118
        '
        'M_FINVRN
        '
        Me.M_FINVRN.DataPropertyName = "FINVRN"
        Me.M_FINVRN.HeaderText = "Fch. Inventario"
        Me.M_FINVRN.Name = "M_FINVRN"
        Me.M_FINVRN.ReadOnly = True
        Me.M_FINVRN.Width = 107
        '
        'M_CPTDAR
        '
        Me.M_CPTDAR.DataPropertyName = "CPTDAR"
        Me.M_CPTDAR.HeaderText = "Partida Arancelaria"
        Me.M_CPTDAR.Name = "M_CPTDAR"
        Me.M_CPTDAR.ReadOnly = True
        Me.M_CPTDAR.Width = 125
        '
        'M_SESTRG
        '
        Me.M_SESTRG.DataPropertyName = "SESTRG"
        Me.M_SESTRG.HeaderText = "Situación"
        Me.M_SESTRG.Name = "M_SESTRG"
        Me.M_SESTRG.ReadOnly = True
        Me.M_SESTRG.Width = 80
        '
        'ucMercaderia_DgF01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.dgMercaderia)
        Me.Controls.Add(Me.tsMenuNavegacion)
        Me.Controls.Add(Me.tsMenuOpciones)
        Me.Name = "ucMercaderia_DgF01"
        Me.Size = New System.Drawing.Size(796, 235)
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        Me.tsMenuNavegacion.ResumeLayout(False)
        Me.tsMenuNavegacion.PerformLayout()
        CType(Me.dstMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents lblMercadería As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tssSep_03 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_02 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_01 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAgregar As System.Windows.Forms.ToolStripButton
    Private WithEvents tsMenuNavegacion As System.Windows.Forms.ToolStrip
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
    Private WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents btnReporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents dstMercaderia As System.Data.DataSet
    Friend WithEvents dtMercaderia As System.Data.DataTable
    Friend WithEvents CMRCLR As System.Data.DataColumn
    Friend WithEvents TMRCD2 As System.Data.DataColumn
    Friend WithEvents CMRCD As System.Data.DataColumn
    Friend WithEvents FPUWEB As System.Data.DataColumn
    Friend WithEvents dgMercaderia As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents CFMCLR As System.Data.DataColumn
    Friend WithEvents TFMCLR As System.Data.DataColumn
    Friend WithEvents CGRCLR As System.Data.DataColumn
    Friend WithEvents TGRCLR As System.Data.DataColumn
    Friend WithEvents IMVTAD As System.Data.DataColumn
    Friend WithEvents IMVTAS As System.Data.DataColumn
    Friend WithEvents TMRCTR As System.Data.DataColumn
    Friend WithEvents FVNCMR As System.Data.DataColumn
    Friend WithEvents FINVRN As System.Data.DataColumn
    Friend WithEvents CPTDAR As System.Data.DataColumn
    Friend WithEvents SESTRG As System.Data.DataColumn
    Friend WithEvents M_CMRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TMRCD2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CMRCD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FPUWEB As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents M_CFMCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TFMCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CGRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TGRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_IMVTAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_IMVTAS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TMRCTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FVNCMR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FINVRN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CPTDAR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
