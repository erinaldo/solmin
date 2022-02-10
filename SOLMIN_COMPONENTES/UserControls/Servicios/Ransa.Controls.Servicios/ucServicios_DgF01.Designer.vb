<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucServicios_DgF01
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucServicios_DgF01))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
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
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.lblServicio = New System.Windows.Forms.ToolStripLabel
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.tssSep_03 = New System.Windows.Forms.ToolStripSeparator
        Me.btnModificar = New System.Windows.Forms.ToolStripButton
        Me.tssSep_02 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAgregar = New System.Windows.Forms.ToolStripButton
        Me.tssSep_01 = New System.Windows.Forms.ToolStripSeparator
        Me.cbxPlanta = New System.Windows.Forms.ToolStripComboBox
        Me.lblPlanta = New System.Windows.Forms.ToolStripLabel
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        Me.dgServicio = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.M_NOPRCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NRTFSV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NOMSER = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_FOPRCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CCMPN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CDVSN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QCNESP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TUNDIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_STIPPR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CCLNFC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TCMPFC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QATNAN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CPRCN1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NSRCN1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_FECINI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_FECFIN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dstServicio = New System.Data.DataSet
        Me.dtRZSC30 = New System.Data.DataTable
        Me.NOPRCN = New System.Data.DataColumn
        Me.NRTFSV = New System.Data.DataColumn
        Me.NOMSER = New System.Data.DataColumn
        Me.FOPRCN = New System.Data.DataColumn
        Me.CCMPN = New System.Data.DataColumn
        Me.CDVSN = New System.Data.DataColumn
        Me.QCNESP = New System.Data.DataColumn
        Me.TUNDIT = New System.Data.DataColumn
        Me.STIPPR = New System.Data.DataColumn
        Me.CCLNFC = New System.Data.DataColumn
        Me.TCMPFC = New System.Data.DataColumn
        Me.QATNAN = New System.Data.DataColumn
        Me.CPRCN1 = New System.Data.DataColumn
        Me.NSRCN1 = New System.Data.DataColumn
        Me.FECINI = New System.Data.DataColumn
        Me.FECFIN = New System.Data.DataColumn
        Me.SESTRG = New System.Data.DataColumn
        Me.tsMenuNavegacion.SuspendLayout()
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.dgServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtRZSC30, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMenuNavegacion
        '
        Me.tsMenuNavegacion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMenuNavegacion.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsMenuNavegacion.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuNavegacion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnIrInicio, Me.tssSep_001, Me.btnIrAnterior, Me.tssSep_002, Me.txtPaginaActual, Me.tssSep_003, Me.btnIrSiguiente, Me.tssSep_004, Me.btnIrFinal, Me.tssSep_005, Me.txtNroTotalPagina, Me.tssSep_006, Me.lblNroRegPagina, Me.txtNroRegPorPagina})
        Me.tsMenuNavegacion.Location = New System.Drawing.Point(0, 210)
        Me.tsMenuNavegacion.Name = "tsMenuNavegacion"
        Me.tsMenuNavegacion.Size = New System.Drawing.Size(589, 25)
        Me.tsMenuNavegacion.TabIndex = 23
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
        Me.txtNroRegPorPagina.Size = New System.Drawing.Size(40, 25)
        Me.txtNroRegPorPagina.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblServicio, Me.btnEliminar, Me.tssSep_03, Me.btnModificar, Me.tssSep_02, Me.btnAgregar, Me.tssSep_01, Me.cbxPlanta, Me.lblPlanta})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(589, 25)
        Me.tsMenuOpciones.TabIndex = 24
        '
        'lblServicio
        '
        Me.lblServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicio.Name = "lblServicio"
        Me.lblServicio.Size = New System.Drawing.Size(73, 22)
        Me.lblServicio.Tag = "SERVICIOS"
        Me.lblServicio.Text = "SERVICIOS"
        '
        'btnEliminar
        '
        Me.btnEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(68, 22)
        Me.btnEliminar.Text = "&Eliminar"
        '
        'tssSep_03
        '
        Me.tssSep_03.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_03.Name = "tssSep_03"
        Me.tssSep_03.Size = New System.Drawing.Size(6, 25)
        '
        'btnModificar
        '
        Me.btnModificar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(76, 22)
        Me.btnModificar.Text = "&Modificar"
        '
        'tssSep_02
        '
        Me.tssSep_02.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_02.Name = "tssSep_02"
        Me.tssSep_02.Size = New System.Drawing.Size(6, 25)
        '
        'btnAgregar
        '
        Me.btnAgregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(68, 22)
        Me.btnAgregar.Text = "&Agregar"
        '
        'tssSep_01
        '
        Me.tssSep_01.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_01.Name = "tssSep_01"
        Me.tssSep_01.Size = New System.Drawing.Size(6, 25)
        '
        'cbxPlanta
        '
        Me.cbxPlanta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cbxPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPlanta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cbxPlanta.Name = "cbxPlanta"
        Me.cbxPlanta.Size = New System.Drawing.Size(150, 25)
        '
        'lblPlanta
        '
        Me.lblPlanta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblPlanta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPlanta.Name = "lblPlanta"
        Me.lblPlanta.Size = New System.Drawing.Size(55, 22)
        Me.lblPlanta.Text = "Planta : "
        '
        'dgServicio
        '
        Me.dgServicio.AllowUserToAddRows = False
        Me.dgServicio.AllowUserToDeleteRows = False
        Me.dgServicio.AllowUserToResizeColumns = False
        Me.dgServicio.AllowUserToResizeRows = False
        Me.dgServicio.AutoGenerateColumns = False
        Me.dgServicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgServicio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_NOPRCN, Me.M_NRTFSV, Me.M_NOMSER, Me.M_FOPRCN, Me.M_CCMPN, Me.M_CDVSN, Me.M_QCNESP, Me.M_TUNDIT, Me.M_STIPPR, Me.M_CCLNFC, Me.M_TCMPFC, Me.M_QATNAN, Me.M_CPRCN1, Me.M_NSRCN1, Me.M_FECINI, Me.M_FECFIN, Me.M_SESTRG})
        Me.dgServicio.DataMember = "dtRZSC30"
        Me.dgServicio.DataSource = Me.dstServicio
        Me.dgServicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgServicio.Location = New System.Drawing.Point(0, 25)
        Me.dgServicio.MultiSelect = False
        Me.dgServicio.Name = "dgServicio"
        Me.dgServicio.ReadOnly = True
        Me.dgServicio.RowHeadersWidth = 20
        Me.dgServicio.RowTemplate.ReadOnly = True
        Me.dgServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgServicio.Size = New System.Drawing.Size(589, 185)
        Me.dgServicio.StandardTab = True
        Me.dgServicio.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgServicio.TabIndex = 25
        '
        'M_NOPRCN
        '
        Me.M_NOPRCN.DataPropertyName = "NOPRCN"
        Me.M_NOPRCN.HeaderText = "Operación"
        Me.M_NOPRCN.Name = "M_NOPRCN"
        Me.M_NOPRCN.ReadOnly = True
        Me.M_NOPRCN.Width = 90
        '
        'M_NRTFSV
        '
        Me.M_NRTFSV.DataPropertyName = "NRTFSV"
        Me.M_NRTFSV.HeaderText = "Tarifa"
        Me.M_NRTFSV.Name = "M_NRTFSV"
        Me.M_NRTFSV.ReadOnly = True
        Me.M_NRTFSV.Visible = False
        Me.M_NRTFSV.Width = 63
        '
        'M_NOMSER
        '
        Me.M_NOMSER.DataPropertyName = "NOMSER"
        Me.M_NOMSER.HeaderText = "Servicio"
        Me.M_NOMSER.Name = "M_NOMSER"
        Me.M_NOMSER.ReadOnly = True
        Me.M_NOMSER.Width = 75
        '
        'M_FOPRCN
        '
        Me.M_FOPRCN.DataPropertyName = "FOPRCN"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.M_FOPRCN.DefaultCellStyle = DataGridViewCellStyle1
        Me.M_FOPRCN.HeaderText = "Fecha"
        Me.M_FOPRCN.Name = "M_FOPRCN"
        Me.M_FOPRCN.ReadOnly = True
        Me.M_FOPRCN.Width = 66
        '
        'M_CCMPN
        '
        Me.M_CCMPN.DataPropertyName = "CCMPN"
        Me.M_CCMPN.HeaderText = "Compañía"
        Me.M_CCMPN.Name = "M_CCMPN"
        Me.M_CCMPN.ReadOnly = True
        Me.M_CCMPN.Visible = False
        Me.M_CCMPN.Width = 85
        '
        'M_CDVSN
        '
        Me.M_CDVSN.DataPropertyName = "CDVSN"
        Me.M_CDVSN.HeaderText = "División"
        Me.M_CDVSN.Name = "M_CDVSN"
        Me.M_CDVSN.ReadOnly = True
        Me.M_CDVSN.Visible = False
        Me.M_CDVSN.Width = 73
        '
        'M_QCNESP
        '
        Me.M_QCNESP.DataPropertyName = "QCNESP"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.M_QCNESP.DefaultCellStyle = DataGridViewCellStyle2
        Me.M_QCNESP.HeaderText = "Cant. Base"
        Me.M_QCNESP.Name = "M_QCNESP"
        Me.M_QCNESP.ReadOnly = True
        Me.M_QCNESP.Width = 90
        '
        'M_TUNDIT
        '
        Me.M_TUNDIT.DataPropertyName = "TUNDIT"
        Me.M_TUNDIT.HeaderText = "Unidad"
        Me.M_TUNDIT.Name = "M_TUNDIT"
        Me.M_TUNDIT.ReadOnly = True
        Me.M_TUNDIT.Width = 74
        '
        'M_STIPPR
        '
        Me.M_STIPPR.DataPropertyName = "STIPPR"
        Me.M_STIPPR.HeaderText = "Proceso"
        Me.M_STIPPR.Name = "M_STIPPR"
        Me.M_STIPPR.ReadOnly = True
        Me.M_STIPPR.Width = 76
        '
        'M_CCLNFC
        '
        Me.M_CCLNFC.DataPropertyName = "CCLNFC"
        Me.M_CCLNFC.HeaderText = "Cliente a Facturar"
        Me.M_CCLNFC.Name = "M_CCLNFC"
        Me.M_CCLNFC.ReadOnly = True
        Me.M_CCLNFC.Visible = False
        Me.M_CCLNFC.Width = 119
        '
        'M_TCMPFC
        '
        Me.M_TCMPFC.DataPropertyName = "TCMPFC"
        Me.M_TCMPFC.HeaderText = "Cliente a Facturar"
        Me.M_TCMPFC.Name = "M_TCMPFC"
        Me.M_TCMPFC.ReadOnly = True
        Me.M_TCMPFC.Width = 126
        '
        'M_QATNAN
        '
        Me.M_QATNAN.DataPropertyName = "QATNAN"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N4"
        DataGridViewCellStyle3.NullValue = "0.0000"
        Me.M_QATNAN.DefaultCellStyle = DataGridViewCellStyle3
        Me.M_QATNAN.HeaderText = "Cant. Atendida"
        Me.M_QATNAN.Name = "M_QATNAN"
        Me.M_QATNAN.ReadOnly = True
        Me.M_QATNAN.Width = 113
        '
        'M_CPRCN1
        '
        Me.M_CPRCN1.DataPropertyName = "CPRCN1"
        Me.M_CPRCN1.HeaderText = "Contenedor"
        Me.M_CPRCN1.Name = "M_CPRCN1"
        Me.M_CPRCN1.ReadOnly = True
        Me.M_CPRCN1.Width = 98
        '
        'M_NSRCN1
        '
        Me.M_NSRCN1.DataPropertyName = "NSRCN1"
        Me.M_NSRCN1.HeaderText = "Serie"
        Me.M_NSRCN1.Name = "M_NSRCN1"
        Me.M_NSRCN1.ReadOnly = True
        Me.M_NSRCN1.Width = 61
        '
        'M_FECINI
        '
        Me.M_FECINI.DataPropertyName = "FECINI"
        Me.M_FECINI.HeaderText = "Inicio Serv."
        Me.M_FECINI.Name = "M_FECINI"
        Me.M_FECINI.ReadOnly = True
        Me.M_FECINI.Width = 91
        '
        'M_FECFIN
        '
        Me.M_FECFIN.DataPropertyName = "FECFIN"
        Me.M_FECFIN.HeaderText = "Final Serv."
        Me.M_FECFIN.Name = "M_FECFIN"
        Me.M_FECFIN.ReadOnly = True
        Me.M_FECFIN.Width = 88
        '
        'M_SESTRG
        '
        Me.M_SESTRG.DataPropertyName = "SESTRG"
        Me.M_SESTRG.HeaderText = "Situación"
        Me.M_SESTRG.Name = "M_SESTRG"
        Me.M_SESTRG.ReadOnly = True
        Me.M_SESTRG.Width = 84
        '
        'dstServicio
        '
        Me.dstServicio.DataSetName = "dstServicio"
        Me.dstServicio.Tables.AddRange(New System.Data.DataTable() {Me.dtRZSC30})
        '
        'dtRZSC30
        '
        Me.dtRZSC30.Columns.AddRange(New System.Data.DataColumn() {Me.NOPRCN, Me.NRTFSV, Me.NOMSER, Me.FOPRCN, Me.CCMPN, Me.CDVSN, Me.QCNESP, Me.TUNDIT, Me.STIPPR, Me.CCLNFC, Me.TCMPFC, Me.QATNAN, Me.CPRCN1, Me.NSRCN1, Me.FECINI, Me.FECFIN, Me.SESTRG})
        Me.dtRZSC30.TableName = "dtRZSC30"
        '
        'NOPRCN
        '
        Me.NOPRCN.ColumnName = "NOPRCN"
        Me.NOPRCN.DataType = GetType(Long)
        Me.NOPRCN.DefaultValue = CType(0, Long)
        '
        'NRTFSV
        '
        Me.NRTFSV.ColumnName = "NRTFSV"
        Me.NRTFSV.DataType = GetType(Long)
        Me.NRTFSV.DefaultValue = CType(0, Long)
        '
        'NOMSER
        '
        Me.NOMSER.ColumnName = "NOMSER"
        Me.NOMSER.DefaultValue = ""
        '
        'FOPRCN
        '
        Me.FOPRCN.ColumnName = "FOPRCN"
        Me.FOPRCN.DataType = GetType(Date)
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
        'QCNESP
        '
        Me.QCNESP.ColumnName = "QCNESP"
        Me.QCNESP.DataType = GetType(Decimal)
        Me.QCNESP.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'TUNDIT
        '
        Me.TUNDIT.ColumnName = "TUNDIT"
        Me.TUNDIT.DefaultValue = ""
        '
        'STIPPR
        '
        Me.STIPPR.ColumnName = "STIPPR"
        Me.STIPPR.DefaultValue = ""
        '
        'CCLNFC
        '
        Me.CCLNFC.ColumnName = "CCLNFC"
        Me.CCLNFC.DataType = GetType(Long)
        Me.CCLNFC.DefaultValue = CType(0, Long)
        '
        'TCMPFC
        '
        Me.TCMPFC.ColumnName = "TCMPFC"
        Me.TCMPFC.DefaultValue = ""
        '
        'QATNAN
        '
        Me.QATNAN.ColumnName = "QATNAN"
        Me.QATNAN.DataType = GetType(Decimal)
        Me.QATNAN.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'CPRCN1
        '
        Me.CPRCN1.ColumnName = "CPRCN1"
        Me.CPRCN1.DefaultValue = ""
        '
        'NSRCN1
        '
        Me.NSRCN1.ColumnName = "NSRCN1"
        Me.NSRCN1.DefaultValue = ""
        '
        'FECINI
        '
        Me.FECINI.ColumnName = "FECINI"
        Me.FECINI.DataType = GetType(Date)
        '
        'FECFIN
        '
        Me.FECFIN.ColumnName = "FECFIN"
        Me.FECFIN.DataType = GetType(Date)
        '
        'SESTRG
        '
        Me.SESTRG.ColumnName = "SESTRG"
        Me.SESTRG.DefaultValue = ""
        '
        'ucServicios_DgF01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.dgServicio)
        Me.Controls.Add(Me.tsMenuNavegacion)
        Me.Controls.Add(Me.tsMenuOpciones)
        Me.Name = "ucServicios_DgF01"
        Me.Size = New System.Drawing.Size(589, 235)
        Me.tsMenuNavegacion.ResumeLayout(False)
        Me.tsMenuNavegacion.PerformLayout()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        CType(Me.dgServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtRZSC30, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents lblServicio As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_02 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_01 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAgregar As System.Windows.Forms.ToolStripButton
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Private WithEvents dgServicio As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dstServicio As System.Data.DataSet
    Friend WithEvents dtRZSC30 As System.Data.DataTable
    Friend WithEvents NOPRCN As System.Data.DataColumn
    Friend WithEvents NRTFSV As System.Data.DataColumn
    Friend WithEvents NOMSER As System.Data.DataColumn
    Friend WithEvents FOPRCN As System.Data.DataColumn
    Friend WithEvents CCMPN As System.Data.DataColumn
    Friend WithEvents CDVSN As System.Data.DataColumn
    Friend WithEvents QCNESP As System.Data.DataColumn
    Friend WithEvents TUNDIT As System.Data.DataColumn
    Friend WithEvents STIPPR As System.Data.DataColumn
    Friend WithEvents CCLNFC As System.Data.DataColumn
    Friend WithEvents TCMPFC As System.Data.DataColumn
    Friend WithEvents QATNAN As System.Data.DataColumn
    Friend WithEvents CPRCN1 As System.Data.DataColumn
    Friend WithEvents NSRCN1 As System.Data.DataColumn
    Friend WithEvents tssSep_03 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cbxPlanta As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents lblPlanta As System.Windows.Forms.ToolStripLabel
    Friend WithEvents FECINI As System.Data.DataColumn
    Friend WithEvents FECFIN As System.Data.DataColumn
    Friend WithEvents SESTRG As System.Data.DataColumn
    Friend WithEvents M_NOPRCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NRTFSV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NOMSER As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FOPRCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CCMPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CDVSN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QCNESP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TUNDIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_STIPPR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CCLNFC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TCMPFC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QATNAN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CPRCN1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NSRCN1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FECINI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FECFIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
