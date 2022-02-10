<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTractoTransportista_DgF01
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucTractoTransportista_DgF01))
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.lblTractoTransportista = New System.Windows.Forms.ToolStripLabel
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
        Me.dstTractoTransportista = New System.Data.DataSet
        Me.dtTractoTransportista = New System.Data.DataTable
        Me.NRUCTR = New System.Data.DataColumn
        Me.NPLCUN = New System.Data.DataColumn
        Me.TMRCTR = New System.Data.DataColumn
        Me.NRGMT1 = New System.Data.DataColumn
        Me.NPLACP = New System.Data.DataColumn
        Me.CBRCND = New System.Data.DataColumn
        Me.CCMPN = New System.Data.DataColumn
        Me.CDVSN = New System.Data.DataColumn
        Me.CPLNDV = New System.Data.DataColumn
        Me.CONDICION = New System.Data.DataColumn
        Me.VIGENCIA = New System.Data.DataColumn
        Me.NRALQT = New System.Data.DataColumn
        Me.FVALIN = New System.Data.DataColumn
        Me.FVALFI = New System.Data.DataColumn
        Me.dgTractoTransportista = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.M_NRUCTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NPLCUN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TMRCTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NRGMT1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NPLACP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CBRCND = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CCMPN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CDVSN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CPLNDV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tsMenuOpciones.SuspendLayout()
        Me.tsMenuNavegacion.SuspendLayout()
        CType(Me.dstTractoTransportista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTractoTransportista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTractoTransportista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTractoTransportista, Me.btnEliminar, Me.tssSep_02, Me.btnEditar, Me.tssSep_01, Me.btnAgregar})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(722, 25)
        Me.tsMenuOpciones.TabIndex = 25
        '
        'lblTractoTransportista
        '
        Me.lblTractoTransportista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTractoTransportista.Name = "lblTractoTransportista"
        Me.lblTractoTransportista.Size = New System.Drawing.Size(118, 22)
        Me.lblTractoTransportista.Text = "TractoTransportista"
        '
        'btnEliminar
        '
        Me.btnEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(70, 22)
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.Visible = False
        '
        'tssSep_02
        '
        Me.tssSep_02.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_02.Name = "tssSep_02"
        Me.tssSep_02.Size = New System.Drawing.Size(6, 25)
        Me.tssSep_02.Visible = False
        '
        'btnEditar
        '
        Me.btnEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(78, 22)
        Me.btnEditar.Text = "&Modificar"
        Me.btnEditar.Visible = False
        '
        'tssSep_01
        '
        Me.tssSep_01.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_01.Name = "tssSep_01"
        Me.tssSep_01.Size = New System.Drawing.Size(6, 25)
        Me.tssSep_01.Visible = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(69, 22)
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.Visible = False
        '
        'tsMenuNavegacion
        '
        Me.tsMenuNavegacion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMenuNavegacion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuNavegacion.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuNavegacion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnIrInicio, Me.tssSep_001, Me.btnIrAnterior, Me.tssSep_002, Me.txtPaginaActual, Me.tssSep_003, Me.btnIrSiguiente, Me.tssSep_004, Me.btnIrFinal, Me.tssSep_005, Me.txtNroTotalPagina, Me.tssSep_006, Me.lblNroRegPagina, Me.txtNroRegPorPagina})
        Me.tsMenuNavegacion.Location = New System.Drawing.Point(0, 210)
        Me.tsMenuNavegacion.Name = "tsMenuNavegacion"
        Me.tsMenuNavegacion.Size = New System.Drawing.Size(722, 25)
        Me.tsMenuNavegacion.TabIndex = 26
        '
        'btnIrInicio
        '
        Me.btnIrInicio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnIrInicio.Image = CType(resources.GetObject("btnIrInicio.Image"), System.Drawing.Image)
        Me.btnIrInicio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnIrInicio.Name = "btnIrInicio"
        Me.btnIrInicio.Size = New System.Drawing.Size(27, 22)
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
        Me.btnIrFinal.Size = New System.Drawing.Size(27, 22)
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
        'dstTractoTransportista
        '
        Me.dstTractoTransportista.DataSetName = "dstTractoTransportista"
        Me.dstTractoTransportista.Tables.AddRange(New System.Data.DataTable() {Me.dtTractoTransportista})
        '
        'dtTractoTransportista
        '
        Me.dtTractoTransportista.Columns.AddRange(New System.Data.DataColumn() {Me.NRUCTR, Me.NPLCUN, Me.TMRCTR, Me.NRGMT1, Me.NPLACP, Me.CBRCND, Me.CCMPN, Me.CDVSN, Me.CPLNDV, Me.CONDICION, Me.VIGENCIA, Me.NRALQT, Me.FVALIN, Me.FVALFI})
        Me.dtTractoTransportista.TableName = "dtTractoTransportista"
        '
        'NRUCTR
        '
        Me.NRUCTR.ColumnName = "NRUCTR"
        Me.NRUCTR.DefaultValue = ""
        '
        'NPLCUN
        '
        Me.NPLCUN.ColumnName = "NPLCUN"
        Me.NPLCUN.DefaultValue = ""
        '
        'TMRCTR
        '
        Me.TMRCTR.ColumnName = "TMRCTR"
        Me.TMRCTR.DefaultValue = ""
        '
        'NRGMT1
        '
        Me.NRGMT1.ColumnName = "NRGMT1"
        Me.NRGMT1.DefaultValue = ""
        '
        'NPLACP
        '
        Me.NPLACP.ColumnName = "NPLACP"
        Me.NPLACP.DefaultValue = ""
        '
        'CBRCND
        '
        Me.CBRCND.ColumnName = "CBRCND"
        Me.CBRCND.DefaultValue = ""
        '
        'CCMPN
        '
        Me.CCMPN.ColumnName = "CCMPN"
        Me.CCMPN.DefaultValue = ""
        '
        'CDVSN
        '
        Me.CDVSN.ColumnName = "CDVSN"
        Me.CDVSN.DefaultValue = ""
        '
        'CPLNDV
        '
        Me.CPLNDV.ColumnName = "CPLNDV"
        Me.CPLNDV.DefaultValue = ""
        '
        'CONDICION
        '
        Me.CONDICION.ColumnName = "CONDICION"
        '
        'VIGENCIA
        '
        Me.VIGENCIA.ColumnName = "VIGENCIA"
        '
        'NRALQT
        '
        Me.NRALQT.ColumnName = "NRALQT"
        '
        'FVALIN
        '
        Me.FVALIN.ColumnName = "FVALIN"
        '
        'FVALFI
        '
        Me.FVALFI.ColumnName = "FVALFI"
        '
        'dgTractoTransportista
        '
        Me.dgTractoTransportista.AllowUserToAddRows = False
        Me.dgTractoTransportista.AllowUserToDeleteRows = False
        Me.dgTractoTransportista.AllowUserToResizeColumns = False
        Me.dgTractoTransportista.AllowUserToResizeRows = False
        Me.dgTractoTransportista.AutoGenerateColumns = False
        Me.dgTractoTransportista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgTractoTransportista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgTractoTransportista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_NRUCTR, Me.M_NPLCUN, Me.M_TMRCTR, Me.M_NRGMT1, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.M_NPLACP, Me.M_CBRCND, Me.M_CCMPN, Me.M_CDVSN, Me.M_CPLNDV})
        Me.dgTractoTransportista.DataMember = "dtTractoTransportista"
        Me.dgTractoTransportista.DataSource = Me.dstTractoTransportista
        Me.dgTractoTransportista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTractoTransportista.Location = New System.Drawing.Point(0, 25)
        Me.dgTractoTransportista.MultiSelect = False
        Me.dgTractoTransportista.Name = "dgTractoTransportista"
        Me.dgTractoTransportista.ReadOnly = True
        Me.dgTractoTransportista.RowHeadersWidth = 20
        Me.dgTractoTransportista.RowTemplate.ReadOnly = True
        Me.dgTractoTransportista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgTractoTransportista.Size = New System.Drawing.Size(722, 185)
        Me.dgTractoTransportista.StandardTab = True
        Me.dgTractoTransportista.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgTractoTransportista.TabIndex = 27
        '
        'M_NRUCTR
        '
        Me.M_NRUCTR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_NRUCTR.DataPropertyName = "NRUCTR"
        Me.M_NRUCTR.HeaderText = "N° RUC Transp."
        Me.M_NRUCTR.Name = "M_NRUCTR"
        Me.M_NRUCTR.ReadOnly = True
        Me.M_NRUCTR.Visible = False
        Me.M_NRUCTR.Width = 118
        '
        'M_NPLCUN
        '
        Me.M_NPLCUN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_NPLCUN.DataPropertyName = "NPLCUN"
        Me.M_NPLCUN.HeaderText = "TractoTransportista"
        Me.M_NPLCUN.Name = "M_NPLCUN"
        Me.M_NPLCUN.ReadOnly = True
        Me.M_NPLCUN.Width = 139
        '
        'M_TMRCTR
        '
        Me.M_TMRCTR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TMRCTR.DataPropertyName = "TMRCTR"
        Me.M_TMRCTR.HeaderText = "Modelo"
        Me.M_TMRCTR.Name = "M_TMRCTR"
        Me.M_TMRCTR.ReadOnly = True
        Me.M_TMRCTR.Width = 77
        '
        'M_NRGMT1
        '
        Me.M_NRGMT1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_NRGMT1.DataPropertyName = "NRGMT1"
        Me.M_NRGMT1.HeaderText = "Nro. MTC"
        Me.M_NRGMT1.Name = "M_NRGMT1"
        Me.M_NRGMT1.ReadOnly = True
        Me.M_NRGMT1.Width = 88
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CONDICION"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Condición"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 91
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "VIGENCIA"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Vigencia"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 81
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FVALIN"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Vigencia inicio"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 113
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "FVALFI"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Vigencia fin"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 98
        '
        'M_NPLACP
        '
        Me.M_NPLACP.DataPropertyName = "NPLACP"
        Me.M_NPLACP.HeaderText = "Acoplado"
        Me.M_NPLACP.Name = "M_NPLACP"
        Me.M_NPLACP.ReadOnly = True
        Me.M_NPLACP.Visible = False
        Me.M_NPLACP.Width = 87
        '
        'M_CBRCND
        '
        Me.M_CBRCND.DataPropertyName = "CBRCND"
        Me.M_CBRCND.HeaderText = "Brevete"
        Me.M_CBRCND.Name = "M_CBRCND"
        Me.M_CBRCND.ReadOnly = True
        Me.M_CBRCND.Visible = False
        Me.M_CBRCND.Width = 75
        '
        'M_CCMPN
        '
        Me.M_CCMPN.DataPropertyName = "CCMPN"
        Me.M_CCMPN.HeaderText = "Compañía"
        Me.M_CCMPN.Name = "M_CCMPN"
        Me.M_CCMPN.ReadOnly = True
        Me.M_CCMPN.Visible = False
        Me.M_CCMPN.Width = 91
        '
        'M_CDVSN
        '
        Me.M_CDVSN.DataPropertyName = "CDVSN"
        Me.M_CDVSN.HeaderText = "División"
        Me.M_CDVSN.Name = "M_CDVSN"
        Me.M_CDVSN.ReadOnly = True
        Me.M_CDVSN.Visible = False
        Me.M_CDVSN.Width = 78
        '
        'M_CPLNDV
        '
        Me.M_CPLNDV.DataPropertyName = "CPLNDV"
        Me.M_CPLNDV.HeaderText = "Planta"
        Me.M_CPLNDV.Name = "M_CPLNDV"
        Me.M_CPLNDV.ReadOnly = True
        Me.M_CPLNDV.Visible = False
        Me.M_CPLNDV.Width = 69
        '
        'ucTractoTransportista_DgF01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.dgTractoTransportista)
        Me.Controls.Add(Me.tsMenuNavegacion)
        Me.Controls.Add(Me.tsMenuOpciones)
        Me.Name = "ucTractoTransportista_DgF01"
        Me.Size = New System.Drawing.Size(722, 235)
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        Me.tsMenuNavegacion.ResumeLayout(False)
        Me.tsMenuNavegacion.PerformLayout()
        CType(Me.dstTractoTransportista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTractoTransportista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTractoTransportista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Private WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents lblTractoTransportista As System.Windows.Forms.ToolStripLabel
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
    Friend WithEvents dstTractoTransportista As System.Data.DataSet
    Private WithEvents dtTractoTransportista As System.Data.DataTable
    Friend WithEvents NRUCTR As System.Data.DataColumn
    Friend WithEvents NPLCUN As System.Data.DataColumn
    Friend WithEvents TMRCTR As System.Data.DataColumn
    Friend WithEvents NRGMT1 As System.Data.DataColumn
    Friend WithEvents NPLACP As System.Data.DataColumn
    Friend WithEvents CBRCND As System.Data.DataColumn
    Friend WithEvents CCMPN As System.Data.DataColumn
    Friend WithEvents CDVSN As System.Data.DataColumn
    Friend WithEvents CPLNDV As System.Data.DataColumn
    Private WithEvents dgTractoTransportista As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents CONDICION As System.Data.DataColumn
    Friend WithEvents VIGENCIA As System.Data.DataColumn
    Friend WithEvents NRALQT As System.Data.DataColumn
    Friend WithEvents FVALIN As System.Data.DataColumn
    Friend WithEvents FVALFI As System.Data.DataColumn
    Friend WithEvents M_NRUCTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NPLCUN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TMRCTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NRGMT1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NPLACP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CBRCND As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CCMPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CDVSN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CPLNDV As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
