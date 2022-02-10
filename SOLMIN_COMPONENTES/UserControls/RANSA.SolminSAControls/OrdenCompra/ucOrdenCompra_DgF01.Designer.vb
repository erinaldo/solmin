<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucOrdenCompra_DgF01
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucOrdenCompra_DgF01))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
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
        Me.dstOrdenCompra = New System.Data.DataSet
        Me.dtOrdenCompra = New System.Data.DataTable
        Me.NORCML = New System.Data.DataColumn
        Me.TPRVCL = New System.Data.DataColumn
        Me.FORCML = New System.Data.DataColumn
        Me.TDSCML = New System.Data.DataColumn
        Me.TDEFIN = New System.Data.DataColumn
        Me.CMNDA1 = New System.Data.DataColumn
        Me.TTINTC = New System.Data.DataColumn
        Me.IVCOTO = New System.Data.DataColumn
        Me.IVTOCO = New System.Data.DataColumn
        Me.IVTOIM = New System.Data.DataColumn
        Me.SESTRG = New System.Data.DataColumn
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.lblOrdenCompra = New System.Windows.Forms.ToolStripLabel
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.tssSep_02 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEditar = New System.Windows.Forms.ToolStripButton
        Me.tssSep_01 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAgregar = New System.Windows.Forms.ToolStripButton
        Me.dgOrdenesCompras = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.M_NORCML = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TPRVCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_FORCML = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TDSCML = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TDEFIN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CMNDA1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TTINTC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_IVCOTO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_IVTOCO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_IVTOIM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tsMenuNavegacion.SuspendLayout()
        CType(Me.dstOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.dgOrdenesCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMenuNavegacion
        '
        Me.tsMenuNavegacion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMenuNavegacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tsMenuNavegacion.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuNavegacion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnIrInicio, Me.tssSep_001, Me.btnIrAnterior, Me.tssSep_002, Me.txtPaginaActual, Me.tssSep_003, Me.btnIrSiguiente, Me.tssSep_004, Me.btnIrFinal, Me.tssSep_005, Me.txtNroTotalPagina, Me.tssSep_006, Me.lblNroRegPagina, Me.txtNroRegPorPagina})
        Me.tsMenuNavegacion.Location = New System.Drawing.Point(0, 210)
        Me.tsMenuNavegacion.Name = "tsMenuNavegacion"
        Me.tsMenuNavegacion.Size = New System.Drawing.Size(442, 25)
        Me.tsMenuNavegacion.TabIndex = 0
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
        Me.txtNroRegPorPagina.ReadOnly = True
        Me.txtNroRegPorPagina.Size = New System.Drawing.Size(40, 25)
        Me.txtNroRegPorPagina.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dstOrdenCompra
        '
        Me.dstOrdenCompra.DataSetName = "dstOrdenCompra"
        Me.dstOrdenCompra.RemotingFormat = System.Data.SerializationFormat.Binary
        Me.dstOrdenCompra.Tables.AddRange(New System.Data.DataTable() {Me.dtOrdenCompra})
        '
        'dtOrdenCompra
        '
        Me.dtOrdenCompra.Columns.AddRange(New System.Data.DataColumn() {Me.NORCML, Me.TPRVCL, Me.FORCML, Me.TDSCML, Me.TDEFIN, Me.CMNDA1, Me.TTINTC, Me.IVCOTO, Me.IVTOCO, Me.IVTOIM, Me.SESTRG})
        Me.dtOrdenCompra.RemotingFormat = System.Data.SerializationFormat.Binary
        Me.dtOrdenCompra.TableName = "dtOrdenCompra"
        '
        'NORCML
        '
        Me.NORCML.ColumnName = "NORCML"
        Me.NORCML.DefaultValue = ""
        Me.NORCML.ReadOnly = True
        '
        'TPRVCL
        '
        Me.TPRVCL.ColumnName = "TPRVCL"
        Me.TPRVCL.DefaultValue = ""
        Me.TPRVCL.ReadOnly = True
        '
        'FORCML
        '
        Me.FORCML.ColumnName = "FORCML"
        Me.FORCML.DefaultValue = ""
        Me.FORCML.ReadOnly = True
        '
        'TDSCML
        '
        Me.TDSCML.ColumnName = "TDSCML"
        Me.TDSCML.DefaultValue = ""
        Me.TDSCML.ReadOnly = True
        '
        'TDEFIN
        '
        Me.TDEFIN.ColumnName = "TDEFIN"
        Me.TDEFIN.DefaultValue = ""
        Me.TDEFIN.ReadOnly = True
        '
        'CMNDA1
        '
        Me.CMNDA1.ColumnName = "CMNDA1"
        Me.CMNDA1.DefaultValue = ""
        Me.CMNDA1.ReadOnly = True
        '
        'TTINTC
        '
        Me.TTINTC.ColumnName = "TTINTC"
        Me.TTINTC.DefaultValue = ""
        Me.TTINTC.ReadOnly = True
        '
        'IVCOTO
        '
        Me.IVCOTO.ColumnName = "IVCOTO"
        Me.IVCOTO.DataType = GetType(Decimal)
        Me.IVCOTO.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.IVCOTO.ReadOnly = True
        '
        'IVTOCO
        '
        Me.IVTOCO.ColumnName = "IVTOCO"
        Me.IVTOCO.DataType = GetType(Decimal)
        Me.IVTOCO.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.IVTOCO.ReadOnly = True
        '
        'IVTOIM
        '
        Me.IVTOIM.ColumnName = "IVTOIM"
        Me.IVTOIM.DataType = GetType(Decimal)
        Me.IVTOIM.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.IVTOIM.ReadOnly = True
        '
        'SESTRG
        '
        Me.SESTRG.ColumnName = "SESTRG"
        Me.SESTRG.DefaultValue = ""
        Me.SESTRG.ReadOnly = True
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblOrdenCompra, Me.btnEliminar, Me.tssSep_02, Me.btnEditar, Me.tssSep_01, Me.btnAgregar})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(442, 25)
        Me.tsMenuOpciones.TabIndex = 21
        '
        'lblOrdenCompra
        '
        Me.lblOrdenCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrdenCompra.Name = "lblOrdenCompra"
        Me.lblOrdenCompra.Size = New System.Drawing.Size(128, 22)
        Me.lblOrdenCompra.Tag = "ORDEN DE COMPRA"
        Me.lblOrdenCompra.Text = "ORDEN DE COMPRA"
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
        'dgOrdenesCompras
        '
        Me.dgOrdenesCompras.AllowUserToAddRows = False
        Me.dgOrdenesCompras.AllowUserToDeleteRows = False
        Me.dgOrdenesCompras.AllowUserToResizeColumns = False
        Me.dgOrdenesCompras.AllowUserToResizeRows = False
        Me.dgOrdenesCompras.AutoGenerateColumns = False
        Me.dgOrdenesCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgOrdenesCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgOrdenesCompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_NORCML, Me.M_TPRVCL, Me.M_FORCML, Me.M_TDSCML, Me.M_TDEFIN, Me.M_CMNDA1, Me.M_TTINTC, Me.M_IVCOTO, Me.M_IVTOCO, Me.M_IVTOIM, Me.M_SESTRG})
        Me.dgOrdenesCompras.DataMember = "dtOrdenCompra"
        Me.dgOrdenesCompras.DataSource = Me.dstOrdenCompra
        Me.dgOrdenesCompras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgOrdenesCompras.Location = New System.Drawing.Point(0, 25)
        Me.dgOrdenesCompras.MultiSelect = False
        Me.dgOrdenesCompras.Name = "dgOrdenesCompras"
        Me.dgOrdenesCompras.ReadOnly = True
        Me.dgOrdenesCompras.RowHeadersWidth = 20
        Me.dgOrdenesCompras.RowTemplate.ReadOnly = True
        Me.dgOrdenesCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgOrdenesCompras.Size = New System.Drawing.Size(442, 185)
        Me.dgOrdenesCompras.StandardTab = True
        Me.dgOrdenesCompras.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgOrdenesCompras.TabIndex = 22
        '
        'M_NORCML
        '
        Me.M_NORCML.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_NORCML.DataPropertyName = "NORCML"
        Me.M_NORCML.HeaderText = "Orden Compra"
        Me.M_NORCML.Name = "M_NORCML"
        Me.M_NORCML.ReadOnly = True
        Me.M_NORCML.Width = 104
        '
        'M_TPRVCL
        '
        Me.M_TPRVCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TPRVCL.DataPropertyName = "TPRVCL"
        Me.M_TPRVCL.HeaderText = "Proveedor"
        Me.M_TPRVCL.Name = "M_TPRVCL"
        Me.M_TPRVCL.ReadOnly = True
        Me.M_TPRVCL.Width = 85
        '
        'M_FORCML
        '
        Me.M_FORCML.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_FORCML.DataPropertyName = "FORCML"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.M_FORCML.DefaultCellStyle = DataGridViewCellStyle1
        Me.M_FORCML.HeaderText = "Fecha"
        Me.M_FORCML.Name = "M_FORCML"
        Me.M_FORCML.ReadOnly = True
        Me.M_FORCML.Width = 66
        '
        'M_TDSCML
        '
        Me.M_TDSCML.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TDSCML.DataPropertyName = "TDSCML"
        Me.M_TDSCML.HeaderText = "Descripción"
        Me.M_TDSCML.Name = "M_TDSCML"
        Me.M_TDSCML.ReadOnly = True
        Me.M_TDSCML.Width = 92
        '
        'M_TDEFIN
        '
        Me.M_TDEFIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TDEFIN.DataPropertyName = "TDEFIN"
        Me.M_TDEFIN.HeaderText = "Destino Final"
        Me.M_TDEFIN.Name = "M_TDEFIN"
        Me.M_TDEFIN.ReadOnly = True
        Me.M_TDEFIN.Width = 97
        '
        'M_CMNDA1
        '
        Me.M_CMNDA1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_CMNDA1.DataPropertyName = "CMNDA1"
        Me.M_CMNDA1.HeaderText = "Moneda"
        Me.M_CMNDA1.Name = "M_CMNDA1"
        Me.M_CMNDA1.ReadOnly = True
        Me.M_CMNDA1.Visible = False
        '
        'M_TTINTC
        '
        Me.M_TTINTC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TTINTC.DataPropertyName = "TTINTC"
        Me.M_TTINTC.HeaderText = "Term. Internacional"
        Me.M_TTINTC.Name = "M_TTINTC"
        Me.M_TTINTC.ReadOnly = True
        Me.M_TTINTC.Width = 127
        '
        'M_IVCOTO
        '
        Me.M_IVCOTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_IVCOTO.DataPropertyName = "IVCOTO"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.M_IVCOTO.DefaultCellStyle = DataGridViewCellStyle2
        Me.M_IVCOTO.HeaderText = "Costo Total"
        Me.M_IVCOTO.Name = "M_IVCOTO"
        Me.M_IVCOTO.ReadOnly = True
        Me.M_IVCOTO.Width = 90
        '
        'M_IVTOCO
        '
        Me.M_IVTOCO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_IVTOCO.DataPropertyName = "IVTOCO"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.M_IVTOCO.DefaultCellStyle = DataGridViewCellStyle3
        Me.M_IVTOCO.HeaderText = "Costo Compra"
        Me.M_IVTOCO.Name = "M_IVTOCO"
        Me.M_IVTOCO.ReadOnly = True
        Me.M_IVTOCO.Width = 102
        '
        'M_IVTOIM
        '
        Me.M_IVTOIM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_IVTOIM.DataPropertyName = "IVTOIM"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.M_IVTOIM.DefaultCellStyle = DataGridViewCellStyle4
        Me.M_IVTOIM.HeaderText = "Impuesto"
        Me.M_IVTOIM.Name = "M_IVTOIM"
        Me.M_IVTOIM.ReadOnly = True
        Me.M_IVTOIM.Width = 79
        '
        'M_SESTRG
        '
        Me.M_SESTRG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_SESTRG.DataPropertyName = "SESTRG"
        Me.M_SESTRG.HeaderText = "Estado"
        Me.M_SESTRG.Name = "M_SESTRG"
        Me.M_SESTRG.ReadOnly = True
        Me.M_SESTRG.Visible = False
        '
        'ucOrdenCompra_DgF01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.dgOrdenesCompras)
        Me.Controls.Add(Me.tsMenuOpciones)
        Me.Controls.Add(Me.tsMenuNavegacion)
        Me.Name = "ucOrdenCompra_DgF01"
        Me.Size = New System.Drawing.Size(442, 235)
        Me.tsMenuNavegacion.ResumeLayout(False)
        Me.tsMenuNavegacion.PerformLayout()
        CType(Me.dstOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        CType(Me.dgOrdenesCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents dstOrdenCompra As System.Data.DataSet
    Private WithEvents dtOrdenCompra As System.Data.DataTable
    Private WithEvents NORCML As System.Data.DataColumn
    Private WithEvents TPRVCL As System.Data.DataColumn
    Private WithEvents FORCML As System.Data.DataColumn
    Private WithEvents TDSCML As System.Data.DataColumn
    Private WithEvents TDEFIN As System.Data.DataColumn
    Private WithEvents CMNDA1 As System.Data.DataColumn
    Private WithEvents TTINTC As System.Data.DataColumn
    Private WithEvents IVCOTO As System.Data.DataColumn
    Private WithEvents IVTOCO As System.Data.DataColumn
    Private WithEvents IVTOIM As System.Data.DataColumn
    Private WithEvents SESTRG As System.Data.DataColumn
    Private WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
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
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents dgOrdenesCompras As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Private WithEvents M_NORCML As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents M_TPRVCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents M_FORCML As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents M_TDSCML As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents M_TDEFIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents M_CMNDA1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents M_TTINTC As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents M_IVCOTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents M_IVTOCO As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents M_IVTOIM As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents M_SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents lblOrdenCompra As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_02 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_01 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton

End Class
