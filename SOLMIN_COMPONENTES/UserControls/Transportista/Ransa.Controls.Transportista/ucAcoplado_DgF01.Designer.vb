﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucAcoplado_DgF01
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucAcoplado_DgF01))
    Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
    Me.lblAcoplado = New System.Windows.Forms.ToolStripLabel
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
    Me.dstAcoplado = New System.Data.DataSet
    Me.dtAcoplado = New System.Data.DataTable
    Me.NPLCAC = New System.Data.DataColumn
    Me.TMRCVH = New System.Data.DataColumn
    Me.TDEACP = New System.Data.DataColumn
    Me.dgAcoplado = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.M_NPLCAC = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.M_TMRCVH = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.M_TDEACP = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.tsMenuOpciones.SuspendLayout()
    Me.tsMenuNavegacion.SuspendLayout()
    CType(Me.dstAcoplado, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dtAcoplado, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dgAcoplado, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'tsMenuOpciones
    '
    Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblAcoplado, Me.btnEliminar, Me.tssSep_02, Me.btnEditar, Me.tssSep_01, Me.btnAgregar})
    Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
    Me.tsMenuOpciones.Name = "tsMenuOpciones"
    Me.tsMenuOpciones.Size = New System.Drawing.Size(442, 25)
    Me.tsMenuOpciones.TabIndex = 25
    '
    'lblAcoplado
    '
    Me.lblAcoplado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAcoplado.Name = "lblAcoplado"
    Me.lblAcoplado.Size = New System.Drawing.Size(60, 22)
    Me.lblAcoplado.Text = "Acoplado"
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
    'dstAcoplado
    '
    Me.dstAcoplado.DataSetName = "dstAcoplado"
    Me.dstAcoplado.Tables.AddRange(New System.Data.DataTable() {Me.dtAcoplado})
    '
    'dtAcoplado
    '
    Me.dtAcoplado.Columns.AddRange(New System.Data.DataColumn() {Me.NPLCAC, Me.TMRCVH, Me.TDEACP})
    Me.dtAcoplado.TableName = "dtAcoplado"
    '
    'NPLCAC
    '
    Me.NPLCAC.ColumnName = "NPLCAC"
    Me.NPLCAC.DefaultValue = ""
    '
    'TMRCVH
    '
    Me.TMRCVH.ColumnName = "TMRCVH"
    Me.TMRCVH.DefaultValue = ""
    '
    'TDEACP
    '
    Me.TDEACP.ColumnName = "TDEACP"
    Me.TDEACP.DefaultValue = ""
    '
    'dgAcoplado
    '
    Me.dgAcoplado.AllowUserToAddRows = False
    Me.dgAcoplado.AllowUserToDeleteRows = False
    Me.dgAcoplado.AllowUserToResizeColumns = False
    Me.dgAcoplado.AllowUserToResizeRows = False
    Me.dgAcoplado.AutoGenerateColumns = False
    Me.dgAcoplado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
    Me.dgAcoplado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    Me.dgAcoplado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_NPLCAC, Me.M_TMRCVH, Me.M_TDEACP})
    Me.dgAcoplado.DataMember = "dtAcoplado"
    Me.dgAcoplado.DataSource = Me.dstAcoplado
    Me.dgAcoplado.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dgAcoplado.Location = New System.Drawing.Point(0, 25)
    Me.dgAcoplado.MultiSelect = False
    Me.dgAcoplado.Name = "dgAcoplado"
    Me.dgAcoplado.ReadOnly = True
    Me.dgAcoplado.RowHeadersWidth = 20
    Me.dgAcoplado.RowTemplate.ReadOnly = True
    Me.dgAcoplado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
    Me.dgAcoplado.Size = New System.Drawing.Size(442, 185)
    Me.dgAcoplado.StandardTab = True
    Me.dgAcoplado.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.dgAcoplado.TabIndex = 27
    '
    'M_NPLCAC
    '
    Me.M_NPLCAC.DataPropertyName = "NPLCAC"
    Me.M_NPLCAC.HeaderText = "Acoplado"
    Me.M_NPLCAC.Name = "M_NPLCAC"
    Me.M_NPLCAC.ReadOnly = True
    Me.M_NPLCAC.Width = 85
    '
    'M_TMRCVH
    '
    Me.M_TMRCVH.DataPropertyName = "TMRCVH"
    Me.M_TMRCVH.HeaderText = "Marca/Modelo"
    Me.M_TMRCVH.Name = "M_TMRCVH"
    Me.M_TMRCVH.ReadOnly = True
    Me.M_TMRCVH.Width = 111
    '
    'M_TDEACP
    '
    Me.M_TDEACP.DataPropertyName = "TDEACP"
    Me.M_TDEACP.HeaderText = "Tipo de Acoplado"
    Me.M_TDEACP.Name = "M_TDEACP"
    Me.M_TDEACP.ReadOnly = True
    Me.M_TDEACP.Width = 126
    '
    'ucAcoplado_DgF01
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Transparent
    Me.Controls.Add(Me.dgAcoplado)
    Me.Controls.Add(Me.tsMenuNavegacion)
    Me.Controls.Add(Me.tsMenuOpciones)
    Me.Name = "ucAcoplado_DgF01"
    Me.Size = New System.Drawing.Size(442, 235)
    Me.tsMenuOpciones.ResumeLayout(False)
    Me.tsMenuOpciones.PerformLayout()
    Me.tsMenuNavegacion.ResumeLayout(False)
    Me.tsMenuNavegacion.PerformLayout()
    CType(Me.dstAcoplado, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dtAcoplado, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dgAcoplado, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Private WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents lblAcoplado As System.Windows.Forms.ToolStripLabel
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
    Friend WithEvents dstAcoplado As System.Data.DataSet
    Private WithEvents dtAcoplado As System.Data.DataTable
    Friend WithEvents NPLCAC As System.Data.DataColumn
    Friend WithEvents TMRCVH As System.Data.DataColumn
    Friend WithEvents TDEACP As System.Data.DataColumn
    Private WithEvents dgAcoplado As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents M_NPLCAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TMRCVH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TDEACP As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
