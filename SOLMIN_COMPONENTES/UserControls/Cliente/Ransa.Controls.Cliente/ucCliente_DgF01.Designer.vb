<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucCliente_DgF01
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucCliente_DgF01))
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.lblCliente = New System.Windows.Forms.ToolStripLabel
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
        Me.dstCliente = New System.Data.DataSet
        Me.dtCliente = New System.Data.DataTable
        Me.CCLNT = New System.Data.DataColumn
        Me.TCMPCL = New System.Data.DataColumn
        Me.NRUC = New System.Data.DataColumn
        Me.TDRCOR = New System.Data.DataColumn
        Me.NLBTEL = New System.Data.DataColumn
        Me.CRGVTA = New System.Data.DataColumn
        Me.TCRVTA = New System.Data.DataColumn
        Me.CDSCSP = New System.Data.DataColumn
        Me.dgCliente = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.CDDRSP = New System.Data.DataColumn
        Me.M_CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TCMPCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NRUC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TMTVBJ = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TDRCOR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NLBTEL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TCRVTA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CRGVTA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CDSCSP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CDDRSP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tsMenuOpciones.SuspendLayout()
        Me.tsMenuNavegacion.SuspendLayout()
        CType(Me.dstCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblCliente, Me.btnEliminar, Me.tssSep_02, Me.btnEditar, Me.tssSep_01, Me.btnAgregar})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(442, 25)
        Me.tsMenuOpciones.TabIndex = 25
        '
        'lblCliente
        '
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(59, 22)
        Me.lblCliente.Text = "CLIENTE"
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
        Me.tsMenuNavegacion.Size = New System.Drawing.Size(442, 25)
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
        'dstCliente
        '
        Me.dstCliente.DataSetName = "dstCliente"
        Me.dstCliente.Tables.AddRange(New System.Data.DataTable() {Me.dtCliente})
        '
        'dtCliente
        '
        Me.dtCliente.Columns.AddRange(New System.Data.DataColumn() {Me.CCLNT, Me.TCMPCL, Me.NRUC, Me.TDRCOR, Me.NLBTEL, Me.CRGVTA, Me.TCRVTA, Me.CDSCSP, Me.CDDRSP})
        Me.dtCliente.TableName = "dtCliente"
        '
        'CCLNT
        '
        Me.CCLNT.ColumnName = "CCLNT"
        Me.CCLNT.DataType = GetType(Long)
        Me.CCLNT.DefaultValue = CType(0, Long)
        '
        'TCMPCL
        '
        Me.TCMPCL.ColumnName = "TCMPCL"
        Me.TCMPCL.DefaultValue = ""
        '
        'NRUC
        '
        Me.NRUC.ColumnName = "NRUC"
        Me.NRUC.DataType = GetType(Long)
        Me.NRUC.DefaultValue = CType(0, Long)
        '
        'TDRCOR
        '
        Me.TDRCOR.ColumnName = "TDRCOR"
        Me.TDRCOR.DefaultValue = ""
        '
        'NLBTEL
        '
        Me.NLBTEL.ColumnName = "NLBTEL"
        Me.NLBTEL.DefaultValue = ""
        '
        'CRGVTA
        '
        Me.CRGVTA.ColumnName = "CRGVTA"
        Me.CRGVTA.DefaultValue = ""
        '
        'TCRVTA
        '
        Me.TCRVTA.Caption = "TCRVTA"
        Me.TCRVTA.ColumnName = "TCRVTA"
        Me.TCRVTA.DefaultValue = ""
        '
        'CDSCSP
        '
        Me.CDSCSP.Caption = "CDSCSP"
        Me.CDSCSP.ColumnName = "CDSCSP"
        Me.CDSCSP.DefaultValue = ""
        '
        'dgCliente
        '
        Me.dgCliente.AllowUserToAddRows = False
        Me.dgCliente.AllowUserToDeleteRows = False
        Me.dgCliente.AllowUserToResizeColumns = False
        Me.dgCliente.AllowUserToResizeRows = False
        Me.dgCliente.AutoGenerateColumns = False
        Me.dgCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_CCLNT, Me.M_TCMPCL, Me.M_NRUC, Me.TMTVBJ, Me.M_TDRCOR, Me.M_NLBTEL, Me.M_TCRVTA, Me.M_CRGVTA, Me.M_CDSCSP, Me.M_CDDRSP})
        Me.dgCliente.DataMember = "dtCliente"
        Me.dgCliente.DataSource = Me.dstCliente
        Me.dgCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCliente.Location = New System.Drawing.Point(0, 25)
        Me.dgCliente.MultiSelect = False
        Me.dgCliente.Name = "dgCliente"
        Me.dgCliente.ReadOnly = True
        Me.dgCliente.RowHeadersWidth = 20
        Me.dgCliente.RowTemplate.ReadOnly = True
        Me.dgCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgCliente.Size = New System.Drawing.Size(442, 185)
        Me.dgCliente.StandardTab = True
        Me.dgCliente.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgCliente.TabIndex = 27
        '
        'CDDRSP
        '
        Me.CDDRSP.ColumnName = "CDDRSP"
        '
        'M_CCLNT
        '
        Me.M_CCLNT.DataPropertyName = "CCLNT"
        Me.M_CCLNT.HeaderText = "Cliente"
        Me.M_CCLNT.Name = "M_CCLNT"
        Me.M_CCLNT.ReadOnly = True
        Me.M_CCLNT.Width = 73
        '
        'M_TCMPCL
        '
        Me.M_TCMPCL.DataPropertyName = "TCMPCL"
        Me.M_TCMPCL.HeaderText = "Razón Social"
        Me.M_TCMPCL.Name = "M_TCMPCL"
        Me.M_TCMPCL.ReadOnly = True
        Me.M_TCMPCL.Width = 102
        '
        'M_NRUC
        '
        Me.M_NRUC.DataPropertyName = "NRUC"
        Me.M_NRUC.HeaderText = "Nro. RUC"
        Me.M_NRUC.Name = "M_NRUC"
        Me.M_NRUC.ReadOnly = True
        Me.M_NRUC.Width = 85
        '
        'TMTVBJ
        '
        Me.TMTVBJ.DataPropertyName = "TMTVBJ"
        Me.TMTVBJ.HeaderText = "Descripción"
        Me.TMTVBJ.Name = "TMTVBJ"
        Me.TMTVBJ.ReadOnly = True
        Me.TMTVBJ.Width = 98
        '
        'M_TDRCOR
        '
        Me.M_TDRCOR.DataPropertyName = "TDRCOR"
        Me.M_TDRCOR.HeaderText = "Dirección Origen"
        Me.M_TDRCOR.Name = "M_TDRCOR"
        Me.M_TDRCOR.ReadOnly = True
        Me.M_TDRCOR.Visible = False
        Me.M_TDRCOR.Width = 125
        '
        'M_NLBTEL
        '
        Me.M_NLBTEL.DataPropertyName = "NLBTEL"
        Me.M_NLBTEL.HeaderText = "Doc. Identidad"
        Me.M_NLBTEL.Name = "M_NLBTEL"
        Me.M_NLBTEL.ReadOnly = True
        Me.M_NLBTEL.Visible = False
        Me.M_NLBTEL.Width = 113
        '
        'M_TCRVTA
        '
        Me.M_TCRVTA.DataPropertyName = "TCRVTA"
        Me.M_TCRVTA.HeaderText = "Negocio"
        Me.M_TCRVTA.Name = "M_TCRVTA"
        Me.M_TCRVTA.ReadOnly = True
        Me.M_TCRVTA.Width = 81
        '
        'M_CRGVTA
        '
        Me.M_CRGVTA.DataPropertyName = "CRGVTA"
        Me.M_CRGVTA.HeaderText = "Cod.Negocio"
        Me.M_CRGVTA.Name = "M_CRGVTA"
        Me.M_CRGVTA.ReadOnly = True
        Me.M_CRGVTA.Visible = False
        Me.M_CRGVTA.Width = 106
        '
        'M_CDSCSP
        '
        Me.M_CDSCSP.DataPropertyName = "CDSCSP"
        Me.M_CDSCSP.HeaderText = "Cod.Sector"
        Me.M_CDSCSP.Name = "M_CDSCSP"
        Me.M_CDSCSP.ReadOnly = True
        Me.M_CDSCSP.Visible = False
        Me.M_CDSCSP.Width = 94
        '
        'M_CDDRSP
        '
        Me.M_CDDRSP.DataPropertyName = "CDDRSP"
        Me.M_CDDRSP.HeaderText = "CDDRSP"
        Me.M_CDDRSP.Name = "M_CDDRSP"
        Me.M_CDDRSP.ReadOnly = True
        Me.M_CDDRSP.Visible = False
        Me.M_CDDRSP.Width = 80
        '
        'ucCliente_DgF01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.dgCliente)
        Me.Controls.Add(Me.tsMenuNavegacion)
        Me.Controls.Add(Me.tsMenuOpciones)
        Me.Name = "ucCliente_DgF01"
        Me.Size = New System.Drawing.Size(442, 235)
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        Me.tsMenuNavegacion.ResumeLayout(False)
        Me.tsMenuNavegacion.PerformLayout()
        CType(Me.dstCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Private WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents lblCliente As System.Windows.Forms.ToolStripLabel
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
    Friend WithEvents dstCliente As System.Data.DataSet
    Private WithEvents dtCliente As System.Data.DataTable
    Friend WithEvents CCLNT As System.Data.DataColumn
    Friend WithEvents TCMPCL As System.Data.DataColumn
    Friend WithEvents NRUC As System.Data.DataColumn
    Friend WithEvents TDRCOR As System.Data.DataColumn
    Friend WithEvents NLBTEL As System.Data.DataColumn
    Private WithEvents dgCliente As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents CRGVTA As System.Data.DataColumn
    Friend WithEvents TCRVTA As System.Data.DataColumn
    Friend WithEvents CDSCSP As System.Data.DataColumn
    Friend WithEvents CDDRSP As System.Data.DataColumn
    Friend WithEvents M_CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TCMPCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NRUC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMTVBJ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TDRCOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NLBTEL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TCRVTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CRGVTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CDSCSP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CDDRSP As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
