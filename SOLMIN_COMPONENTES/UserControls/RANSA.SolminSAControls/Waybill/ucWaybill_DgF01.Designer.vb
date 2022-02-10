<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucWaybill_DgF01
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucWaybill_DgF01))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
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
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.lblWaybill = New System.Windows.Forms.ToolStripLabel
        Me.btnEtiqueta = New System.Windows.Forms.ToolStripDropDownButton
        Me.tsmiBulto = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiPaleta = New System.Windows.Forms.ToolStripMenuItem
        Me.tssSep_071 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmiSecuenciaBulto = New System.Windows.Forms.ToolStripMenuItem
        Me.tssSep_07 = New System.Windows.Forms.ToolStripSeparator
        Me.btnPreDespacho = New System.Windows.Forms.ToolStripButton
        Me.tssSep_06 = New System.Windows.Forms.ToolStripSeparator
        Me.btnPaletizar = New System.Windows.Forms.ToolStripButton
        Me.tssSep_05 = New System.Windows.Forms.ToolStripSeparator
        Me.btnInterfase = New System.Windows.Forms.ToolStripButton
        Me.tssSep_04 = New System.Windows.Forms.ToolStripSeparator
        Me.btnRepacking = New System.Windows.Forms.ToolStripButton
        Me.tssSep_03 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.tssSep_02 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEditar = New System.Windows.Forms.ToolStripButton
        Me.tssSep_01 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAgregar = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        Me.dstWayBill = New System.Data.DataSet
        Me.dtWayBill = New System.Data.DataTable
        Me.CHK = New System.Data.DataColumn
        Me.CREFFW = New System.Data.DataColumn
        Me.DESCWB = New System.Data.DataColumn
        Me.TUBRFR = New System.Data.DataColumn
        Me.FREFFW = New System.Data.DataColumn
        Me.NROPLT = New System.Data.DataColumn
        Me.SMTRCP = New System.Data.DataColumn
        Me.QREFFW = New System.Data.DataColumn
        Me.TIPBTO = New System.Data.DataColumn
        Me.QPSOBL = New System.Data.DataColumn
        Me.TUNPSO = New System.Data.DataColumn
        Me.QVLBTO = New System.Data.DataColumn
        Me.TUNVOL = New System.Data.DataColumn
        Me.SSNCRG = New System.Data.DataColumn
        Me.QAROCP = New System.Data.DataColumn
        Me.NORAGN = New System.Data.DataColumn
        Me.NTCKPS = New System.Data.DataColumn
        Me.CRTLTE = New System.Data.DataColumn
        Me.SESTRG = New System.Data.DataColumn
        Me.dgWayBill = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.M_CHK = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.M_CREFFW = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_DESCWB = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TUBRFR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_FREFFW = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NROPLT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_SMTRCP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QREFFW = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TIPBTO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QPSOBL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TUNPSO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QVLBTO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TUNVOL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_SSNCRG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QAROCP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NORAGN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NTCKPS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CRTLTE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tsMenuNavegacion.SuspendLayout()
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.dstWayBill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtWayBill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgWayBill, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tsMenuNavegacion.Size = New System.Drawing.Size(796, 25)
        Me.tsMenuNavegacion.TabIndex = 1
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
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblWaybill, Me.btnEtiqueta, Me.tssSep_07, Me.btnPreDespacho, Me.tssSep_06, Me.btnPaletizar, Me.tssSep_05, Me.btnInterfase, Me.tssSep_04, Me.btnRepacking, Me.tssSep_03, Me.btnEliminar, Me.tssSep_02, Me.btnEditar, Me.tssSep_01, Me.btnAgregar})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(796, 25)
        Me.tsMenuOpciones.TabIndex = 22
        '
        'lblWaybill
        '
        Me.lblWaybill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaybill.Name = "lblWaybill"
        Me.lblWaybill.Size = New System.Drawing.Size(56, 22)
        Me.lblWaybill.Tag = "BULTOS"
        Me.lblWaybill.Text = "BULTOS"
        '
        'btnEtiqueta
        '
        Me.btnEtiqueta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEtiqueta.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiBulto, Me.tsmiPaleta, Me.tssSep_071, Me.tsmiSecuenciaBulto})
        Me.btnEtiqueta.Image = CType(resources.GetObject("btnEtiqueta.Image"), System.Drawing.Image)
        Me.btnEtiqueta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEtiqueta.Name = "btnEtiqueta"
        Me.btnEtiqueta.Size = New System.Drawing.Size(75, 22)
        Me.btnEtiqueta.Text = "E&tiqueta"
        '
        'tsmiBulto
        '
        Me.tsmiBulto.Name = "tsmiBulto"
        Me.tsmiBulto.Size = New System.Drawing.Size(155, 22)
        Me.tsmiBulto.Text = "&Bulto"
        '
        'tsmiPaleta
        '
        Me.tsmiPaleta.Name = "tsmiPaleta"
        Me.tsmiPaleta.Size = New System.Drawing.Size(155, 22)
        Me.tsmiPaleta.Text = "&Paleta"
        '
        'tssSep_071
        '
        Me.tssSep_071.Name = "tssSep_071"
        Me.tssSep_071.Size = New System.Drawing.Size(152, 6)
        '
        'tsmiSecuenciaBulto
        '
        Me.tsmiSecuenciaBulto.Name = "tsmiSecuenciaBulto"
        Me.tsmiSecuenciaBulto.Size = New System.Drawing.Size(155, 22)
        Me.tsmiSecuenciaBulto.Text = "Secuencia Bulto"
        '
        'tssSep_07
        '
        Me.tssSep_07.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_07.Name = "tssSep_07"
        Me.tssSep_07.Size = New System.Drawing.Size(6, 25)
        '
        'btnPreDespacho
        '
        Me.btnPreDespacho.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnPreDespacho.Image = CType(resources.GetObject("btnPreDespacho.Image"), System.Drawing.Image)
        Me.btnPreDespacho.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPreDespacho.Name = "btnPreDespacho"
        Me.btnPreDespacho.Size = New System.Drawing.Size(95, 22)
        Me.btnPreDespacho.Text = "Pre-&Despacho"
        '
        'tssSep_06
        '
        Me.tssSep_06.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_06.Name = "tssSep_06"
        Me.tssSep_06.Size = New System.Drawing.Size(6, 25)
        '
        'btnPaletizar
        '
        Me.btnPaletizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnPaletizar.Image = CType(resources.GetObject("btnPaletizar.Image"), System.Drawing.Image)
        Me.btnPaletizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPaletizar.Name = "btnPaletizar"
        Me.btnPaletizar.Size = New System.Drawing.Size(67, 22)
        Me.btnPaletizar.Text = "&Paletizar"
        '
        'tssSep_05
        '
        Me.tssSep_05.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_05.Name = "tssSep_05"
        Me.tssSep_05.Size = New System.Drawing.Size(6, 25)
        '
        'btnInterfase
        '
        Me.btnInterfase.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnInterfase.Image = CType(resources.GetObject("btnInterfase.Image"), System.Drawing.Image)
        Me.btnInterfase.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInterfase.Name = "btnInterfase"
        Me.btnInterfase.Size = New System.Drawing.Size(68, 22)
        Me.btnInterfase.Text = "&Interfase"
        '
        'tssSep_04
        '
        Me.tssSep_04.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_04.Name = "tssSep_04"
        Me.tssSep_04.Size = New System.Drawing.Size(6, 25)
        '
        'btnRepacking
        '
        Me.btnRepacking.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnRepacking.Image = CType(resources.GetObject("btnRepacking.Image"), System.Drawing.Image)
        Me.btnRepacking.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRepacking.Name = "btnRepacking"
        Me.btnRepacking.Size = New System.Drawing.Size(83, 22)
        Me.btnRepacking.Text = "&Re-Packing"
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
        'dstWayBill
        '
        Me.dstWayBill.DataSetName = "dstWayBill"
        Me.dstWayBill.RemotingFormat = System.Data.SerializationFormat.Binary
        Me.dstWayBill.Tables.AddRange(New System.Data.DataTable() {Me.dtWayBill})
        '
        'dtWayBill
        '
        Me.dtWayBill.Columns.AddRange(New System.Data.DataColumn() {Me.CHK, Me.CREFFW, Me.DESCWB, Me.TUBRFR, Me.FREFFW, Me.NROPLT, Me.SMTRCP, Me.QREFFW, Me.TIPBTO, Me.QPSOBL, Me.TUNPSO, Me.QVLBTO, Me.TUNVOL, Me.SSNCRG, Me.QAROCP, Me.NORAGN, Me.NTCKPS, Me.CRTLTE, Me.SESTRG})
        Me.dtWayBill.RemotingFormat = System.Data.SerializationFormat.Binary
        Me.dtWayBill.TableName = "dtWayBill"
        '
        'CHK
        '
        Me.CHK.ColumnName = "CHK"
        Me.CHK.DataType = GetType(Boolean)
        Me.CHK.DefaultValue = False
        '
        'CREFFW
        '
        Me.CREFFW.ColumnName = "CREFFW"
        Me.CREFFW.DefaultValue = ""
        '
        'DESCWB
        '
        Me.DESCWB.ColumnName = "DESCWB"
        Me.DESCWB.DefaultValue = ""
        '
        'TUBRFR
        '
        Me.TUBRFR.ColumnName = "TUBRFR"
        Me.TUBRFR.DefaultValue = ""
        '
        'FREFFW
        '
        Me.FREFFW.ColumnName = "FREFFW"
        Me.FREFFW.DataType = GetType(Date)
        '
        'NROPLT
        '
        Me.NROPLT.ColumnName = "NROPLT"
        Me.NROPLT.DataType = GetType(Long)
        Me.NROPLT.DefaultValue = CType(0, Long)
        '
        'SMTRCP
        '
        Me.SMTRCP.ColumnName = "SMTRCP"
        Me.SMTRCP.DefaultValue = ""
        '
        'QREFFW
        '
        Me.QREFFW.ColumnName = "QREFFW"
        Me.QREFFW.DataType = GetType(Decimal)
        Me.QREFFW.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'TIPBTO
        '
        Me.TIPBTO.ColumnName = "TIPBTO"
        Me.TIPBTO.DefaultValue = ""
        '
        'QPSOBL
        '
        Me.QPSOBL.ColumnName = "QPSOBL"
        Me.QPSOBL.DataType = GetType(Decimal)
        Me.QPSOBL.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'TUNPSO
        '
        Me.TUNPSO.ColumnName = "TUNPSO"
        Me.TUNPSO.DefaultValue = ""
        '
        'QVLBTO
        '
        Me.QVLBTO.ColumnName = "QVLBTO"
        Me.QVLBTO.DataType = GetType(Decimal)
        Me.QVLBTO.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'TUNVOL
        '
        Me.TUNVOL.ColumnName = "TUNVOL"
        Me.TUNVOL.DefaultValue = ""
        '
        'SSNCRG
        '
        Me.SSNCRG.ColumnName = "SSNCRG"
        Me.SSNCRG.DefaultValue = ""
        '
        'QAROCP
        '
        Me.QAROCP.ColumnName = "QAROCP"
        Me.QAROCP.DataType = GetType(Decimal)
        Me.QAROCP.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'NORAGN
        '
        Me.NORAGN.ColumnName = "NORAGN"
        Me.NORAGN.DataType = GetType(Long)
        Me.NORAGN.DefaultValue = CType(0, Long)
        '
        'NTCKPS
        '
        Me.NTCKPS.ColumnName = "NTCKPS"
        Me.NTCKPS.DataType = GetType(Long)
        Me.NTCKPS.DefaultValue = CType(0, Long)
        '
        'CRTLTE
        '
        Me.CRTLTE.ColumnName = "CRTLTE"
        Me.CRTLTE.DefaultValue = ""
        '
        'SESTRG
        '
        Me.SESTRG.ColumnName = "SESTRG"
        Me.SESTRG.DefaultValue = ""
        '
        'dgWayBill
        '
        Me.dgWayBill.AllowUserToAddRows = False
        Me.dgWayBill.AllowUserToDeleteRows = False
        Me.dgWayBill.AllowUserToResizeColumns = False
        Me.dgWayBill.AllowUserToResizeRows = False
        Me.dgWayBill.AutoGenerateColumns = False
        Me.dgWayBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgWayBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgWayBill.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_CHK, Me.M_CREFFW, Me.M_DESCWB, Me.M_TUBRFR, Me.M_FREFFW, Me.M_NROPLT, Me.M_SMTRCP, Me.M_QREFFW, Me.M_TIPBTO, Me.M_QPSOBL, Me.M_TUNPSO, Me.M_QVLBTO, Me.M_TUNVOL, Me.M_SSNCRG, Me.M_QAROCP, Me.M_NORAGN, Me.M_NTCKPS, Me.M_CRTLTE, Me.M_SESTRG})
        Me.dgWayBill.DataMember = "dtWayBill"
        Me.dgWayBill.DataSource = Me.dstWayBill
        Me.dgWayBill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgWayBill.Location = New System.Drawing.Point(0, 25)
        Me.dgWayBill.MultiSelect = False
        Me.dgWayBill.Name = "dgWayBill"
        Me.dgWayBill.ReadOnly = True
        Me.dgWayBill.RowHeadersWidth = 20
        Me.dgWayBill.RowTemplate.ReadOnly = True
        Me.dgWayBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgWayBill.Size = New System.Drawing.Size(796, 185)
        Me.dgWayBill.StandardTab = True
        Me.dgWayBill.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgWayBill.TabIndex = 23
        '
        'M_CHK
        '
        Me.M_CHK.DataPropertyName = "CHK"
        Me.M_CHK.FalseValue = "False"
        Me.M_CHK.Frozen = True
        Me.M_CHK.HeaderText = "CHK"
        Me.M_CHK.Name = "M_CHK"
        Me.M_CHK.ReadOnly = True
        Me.M_CHK.TrueValue = "True"
        Me.M_CHK.Width = 39
        '
        'M_CREFFW
        '
        Me.M_CREFFW.DataPropertyName = "CREFFW"
        Me.M_CREFFW.Frozen = True
        Me.M_CREFFW.HeaderText = "Bulto"
        Me.M_CREFFW.Name = "M_CREFFW"
        Me.M_CREFFW.ReadOnly = True
        Me.M_CREFFW.Width = 60
        '
        'M_DESCWB
        '
        Me.M_DESCWB.DataPropertyName = "DESCWB"
        Me.M_DESCWB.HeaderText = "Descripción"
        Me.M_DESCWB.Name = "M_DESCWB"
        Me.M_DESCWB.ReadOnly = True
        Me.M_DESCWB.Width = 92
        '
        'M_TUBRFR
        '
        Me.M_TUBRFR.DataPropertyName = "TUBRFR"
        Me.M_TUBRFR.HeaderText = "Ubicación"
        Me.M_TUBRFR.Name = "M_TUBRFR"
        Me.M_TUBRFR.ReadOnly = True
        Me.M_TUBRFR.Width = 84
        '
        'M_FREFFW
        '
        Me.M_FREFFW.DataPropertyName = "FREFFW"
        Me.M_FREFFW.HeaderText = "Fch. Recep."
        Me.M_FREFFW.Name = "M_FREFFW"
        Me.M_FREFFW.ReadOnly = True
        Me.M_FREFFW.Width = 95
        '
        'M_NROPLT
        '
        Me.M_NROPLT.DataPropertyName = "NROPLT"
        DataGridViewCellStyle1.NullValue = "0"
        Me.M_NROPLT.DefaultCellStyle = DataGridViewCellStyle1
        Me.M_NROPLT.HeaderText = "Nro. Paleta"
        Me.M_NROPLT.Name = "M_NROPLT"
        Me.M_NROPLT.ReadOnly = True
        Me.M_NROPLT.Width = 89
        '
        'M_SMTRCP
        '
        Me.M_SMTRCP.DataPropertyName = "SMTRCP"
        Me.M_SMTRCP.HeaderText = "Motivo Recepción"
        Me.M_SMTRCP.Name = "M_SMTRCP"
        Me.M_SMTRCP.ReadOnly = True
        Me.M_SMTRCP.Width = 123
        '
        'M_QREFFW
        '
        Me.M_QREFFW.DataPropertyName = "QREFFW"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.M_QREFFW.DefaultCellStyle = DataGridViewCellStyle2
        Me.M_QREFFW.HeaderText = "Cantidad"
        Me.M_QREFFW.Name = "M_QREFFW"
        Me.M_QREFFW.ReadOnly = True
        Me.M_QREFFW.Width = 78
        '
        'M_TIPBTO
        '
        Me.M_TIPBTO.DataPropertyName = "TIPBTO"
        Me.M_TIPBTO.HeaderText = "Tipo Bulto"
        Me.M_TIPBTO.Name = "M_TIPBTO"
        Me.M_TIPBTO.ReadOnly = True
        Me.M_TIPBTO.Width = 84
        '
        'M_QPSOBL
        '
        Me.M_QPSOBL.DataPropertyName = "QPSOBL"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.M_QPSOBL.DefaultCellStyle = DataGridViewCellStyle3
        Me.M_QPSOBL.HeaderText = "Peso"
        Me.M_QPSOBL.Name = "M_QPSOBL"
        Me.M_QPSOBL.ReadOnly = True
        Me.M_QPSOBL.Width = 60
        '
        'M_TUNPSO
        '
        Me.M_TUNPSO.DataPropertyName = "TUNPSO"
        Me.M_TUNPSO.HeaderText = "Unidad"
        Me.M_TUNPSO.Name = "M_TUNPSO"
        Me.M_TUNPSO.ReadOnly = True
        Me.M_TUNPSO.Width = 70
        '
        'M_QVLBTO
        '
        Me.M_QVLBTO.DataPropertyName = "QVLBTO"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.M_QVLBTO.DefaultCellStyle = DataGridViewCellStyle4
        Me.M_QVLBTO.HeaderText = "Volumen"
        Me.M_QVLBTO.Name = "M_QVLBTO"
        Me.M_QVLBTO.ReadOnly = True
        Me.M_QVLBTO.Width = 77
        '
        'M_TUNVOL
        '
        Me.M_TUNVOL.DataPropertyName = "TUNVOL"
        Me.M_TUNVOL.HeaderText = "Unidad"
        Me.M_TUNVOL.Name = "M_TUNVOL"
        Me.M_TUNVOL.ReadOnly = True
        Me.M_TUNVOL.Width = 70
        '
        'M_SSNCRG
        '
        Me.M_SSNCRG.DataPropertyName = "SSNCRG"
        Me.M_SSNCRG.HeaderText = "Sentido"
        Me.M_SSNCRG.Name = "M_SSNCRG"
        Me.M_SSNCRG.ReadOnly = True
        Me.M_SSNCRG.Width = 72
        '
        'M_QAROCP
        '
        Me.M_QAROCP.DataPropertyName = "QAROCP"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.M_QAROCP.DefaultCellStyle = DataGridViewCellStyle5
        Me.M_QAROCP.HeaderText = "Área Ocupada"
        Me.M_QAROCP.Name = "M_QAROCP"
        Me.M_QAROCP.ReadOnly = True
        Me.M_QAROCP.Width = 105
        '
        'M_NORAGN
        '
        Me.M_NORAGN.DataPropertyName = "NORAGN"
        Me.M_NORAGN.HeaderText = "Nro. O/S"
        Me.M_NORAGN.Name = "M_NORAGN"
        Me.M_NORAGN.ReadOnly = True
        Me.M_NORAGN.Width = 79
        '
        'M_NTCKPS
        '
        Me.M_NTCKPS.DataPropertyName = "NTCKPS"
        Me.M_NTCKPS.HeaderText = "Nro. Ticket"
        Me.M_NTCKPS.Name = "M_NTCKPS"
        Me.M_NTCKPS.ReadOnly = True
        Me.M_NTCKPS.Width = 89
        '
        'M_CRTLTE
        '
        Me.M_CRTLTE.DataPropertyName = "CRTLTE"
        Me.M_CRTLTE.HeaderText = "Criterio"
        Me.M_CRTLTE.Name = "M_CRTLTE"
        Me.M_CRTLTE.ReadOnly = True
        Me.M_CRTLTE.Width = 68
        '
        'M_SESTRG
        '
        Me.M_SESTRG.DataPropertyName = "SESTRG"
        Me.M_SESTRG.HeaderText = "Situación"
        Me.M_SESTRG.Name = "M_SESTRG"
        Me.M_SESTRG.ReadOnly = True
        Me.M_SESTRG.Width = 80
        '
        'ucWaybill_DgF01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.dgWayBill)
        Me.Controls.Add(Me.tsMenuOpciones)
        Me.Controls.Add(Me.tsMenuNavegacion)
        Me.Name = "ucWaybill_DgF01"
        Me.Size = New System.Drawing.Size(796, 235)
        Me.tsMenuNavegacion.ResumeLayout(False)
        Me.tsMenuNavegacion.PerformLayout()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        CType(Me.dstWayBill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtWayBill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgWayBill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Private WithEvents lblWaybill As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_02 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_01 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAgregar As System.Windows.Forms.ToolStripButton
    Private WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Private WithEvents dstWayBill As System.Data.DataSet
    Private WithEvents dtWayBill As System.Data.DataTable
    Friend WithEvents CHK As System.Data.DataColumn
    Friend WithEvents CREFFW As System.Data.DataColumn
    Friend WithEvents DESCWB As System.Data.DataColumn
    Friend WithEvents TUBRFR As System.Data.DataColumn
    Friend WithEvents FREFFW As System.Data.DataColumn
    Friend WithEvents NROPLT As System.Data.DataColumn
    Friend WithEvents SMTRCP As System.Data.DataColumn
    Friend WithEvents QREFFW As System.Data.DataColumn
    Friend WithEvents TIPBTO As System.Data.DataColumn
    Friend WithEvents QPSOBL As System.Data.DataColumn
    Friend WithEvents TUNPSO As System.Data.DataColumn
    Friend WithEvents QVLBTO As System.Data.DataColumn
    Friend WithEvents TUNVOL As System.Data.DataColumn
    Friend WithEvents SSNCRG As System.Data.DataColumn
    Friend WithEvents QAROCP As System.Data.DataColumn
    Friend WithEvents NORAGN As System.Data.DataColumn
    Friend WithEvents NTCKPS As System.Data.DataColumn
    Friend WithEvents CRTLTE As System.Data.DataColumn
    Friend WithEvents SESTRG As System.Data.DataColumn
    Private WithEvents dgWayBill As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents tssSep_03 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnInterfase As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_04 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnRepacking As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPaletizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_05 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents M_CHK As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents M_CREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_DESCWB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TUBRFR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NROPLT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_SMTRCP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TIPBTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QPSOBL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TUNPSO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QVLBTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TUNVOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_SSNCRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QAROCP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NORAGN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NTCKPS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CRTLTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnPreDespacho As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_06 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEtiqueta As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tsmiBulto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiPaleta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssSep_071 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmiSecuenciaBulto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssSep_07 As System.Windows.Forms.ToolStripSeparator

End Class
