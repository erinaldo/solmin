﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTracto_DgF01
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucTracto_DgF01))
    Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
    Me.lblTracto = New System.Windows.Forms.ToolStripLabel
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
    Me.dstTracto = New System.Data.DataSet
    Me.dtTracto = New System.Data.DataTable
    Me.NPLCUN = New System.Data.DataColumn
    Me.TMRCTR = New System.Data.DataColumn
    Me.NRGMT1 = New System.Data.DataColumn
    Me.dgTracto = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.M_NPLCUN = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.M_TMRCTR = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.M_NRGMT1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.tsMenuOpciones.SuspendLayout()
    Me.tsMenuNavegacion.SuspendLayout()
    CType(Me.dstTracto, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dtTracto, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dgTracto, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'tsMenuOpciones
    '
    Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTracto, Me.btnEliminar, Me.tssSep_02, Me.btnEditar, Me.tssSep_01, Me.btnAgregar})
    Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
    Me.tsMenuOpciones.Name = "tsMenuOpciones"
    Me.tsMenuOpciones.Size = New System.Drawing.Size(442, 25)
    Me.tsMenuOpciones.TabIndex = 25
    '
    'lblTracto
    '
    Me.lblTracto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTracto.Name = "lblTracto"
    Me.lblTracto.Size = New System.Drawing.Size(44, 22)
    Me.lblTracto.Text = "Tracto"
    '
    'btnEliminar
    '
    Me.btnEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
    Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnEliminar.Name = "btnEliminar"
    Me.btnEliminar.Size = New System.Drawing.Size(63, 22)
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
    Me.btnEditar.Size = New System.Drawing.Size(70, 22)
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
    Me.btnAgregar.Size = New System.Drawing.Size(64, 22)
    Me.btnAgregar.Text = "&Agregar"
    Me.btnAgregar.Visible = False
    '
    'tsMenuNavegacion
    '
    Me.tsMenuNavegacion.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.tsMenuNavegacion.Font = New System.Drawing.Font("Segoe UI", 8.25!)
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
    'dstTracto
    '
    Me.dstTracto.DataSetName = "dstTracto"
    Me.dstTracto.Tables.AddRange(New System.Data.DataTable() {Me.dtTracto})
    '
    'dtTracto
    '
    Me.dtTracto.Columns.AddRange(New System.Data.DataColumn() {Me.NPLCUN, Me.TMRCTR, Me.NRGMT1})
    Me.dtTracto.TableName = "dtTracto"
    '
    'NPLCUN
    '
    Me.NPLCUN.ColumnName = "NPLCUN"
    Me.NPLCUN.DefaultValue = "0"
    '
    'TMRCTR
    '
    Me.TMRCTR.ColumnName = "TMRCTR"
    Me.TMRCTR.DefaultValue = ""
    '
    'NRGMT1
    '
    Me.NRGMT1.ColumnName = "NRGMT1"
    Me.NRGMT1.DefaultValue = "0"
    '
    'dgTracto
    '
    Me.dgTracto.AllowUserToAddRows = False
    Me.dgTracto.AllowUserToDeleteRows = False
    Me.dgTracto.AllowUserToResizeColumns = False
    Me.dgTracto.AllowUserToResizeRows = False
    Me.dgTracto.AutoGenerateColumns = False
    Me.dgTracto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
    Me.dgTracto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    Me.dgTracto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_NPLCUN, Me.M_TMRCTR, Me.M_NRGMT1})
    Me.dgTracto.DataMember = "dtTracto"
    Me.dgTracto.DataSource = Me.dstTracto
    Me.dgTracto.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dgTracto.Location = New System.Drawing.Point(0, 25)
    Me.dgTracto.MultiSelect = False
    Me.dgTracto.Name = "dgTracto"
    Me.dgTracto.ReadOnly = True
    Me.dgTracto.RowHeadersWidth = 20
    Me.dgTracto.RowTemplate.ReadOnly = True
    Me.dgTracto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
    Me.dgTracto.Size = New System.Drawing.Size(442, 185)
    Me.dgTracto.StandardTab = True
    Me.dgTracto.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.dgTracto.TabIndex = 27
    '
    'M_NPLCUN
    '
    Me.M_NPLCUN.DataPropertyName = "NPLCUN"
    Me.M_NPLCUN.HeaderText = "Tracto"
    Me.M_NPLCUN.Name = "M_NPLCUN"
    Me.M_NPLCUN.ReadOnly = True
    Me.M_NPLCUN.Width = 67
    '
    'M_TMRCTR
    '
    Me.M_TMRCTR.DataPropertyName = "TMRCTR"
    Me.M_TMRCTR.HeaderText = "Modelo"
    Me.M_TMRCTR.Name = "M_TMRCTR"
    Me.M_TMRCTR.ReadOnly = True
    Me.M_TMRCTR.Width = 76
    '
    'M_NRGMT1
    '
    Me.M_NRGMT1.DataPropertyName = "NRGMT1"
    Me.M_NRGMT1.HeaderText = "Nro. MTC"
    Me.M_NRGMT1.Name = "M_NRGMT1"
    Me.M_NRGMT1.ReadOnly = True
    Me.M_NRGMT1.Width = 83
    '
    'ucTracto_DgF01
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Transparent
    Me.Controls.Add(Me.dgTracto)
    Me.Controls.Add(Me.tsMenuNavegacion)
    Me.Controls.Add(Me.tsMenuOpciones)
    Me.Name = "ucTracto_DgF01"
    Me.Size = New System.Drawing.Size(442, 235)
    Me.tsMenuOpciones.ResumeLayout(False)
    Me.tsMenuOpciones.PerformLayout()
    Me.tsMenuNavegacion.ResumeLayout(False)
    Me.tsMenuNavegacion.PerformLayout()
    CType(Me.dstTracto, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dtTracto, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dgTracto, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Private WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents lblTracto As System.Windows.Forms.ToolStripLabel
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
    Friend WithEvents dstTracto As System.Data.DataSet
    Private WithEvents dtTracto As System.Data.DataTable
    Friend WithEvents NPLCUN As System.Data.DataColumn
    Friend WithEvents TMRCTR As System.Data.DataColumn
    Friend WithEvents NRGMT1 As System.Data.DataColumn
    Private WithEvents dgTracto As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents M_NPLCUN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TMRCTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NRGMT1 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
