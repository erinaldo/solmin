<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoProyecto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMantenimientoProyecto))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dgProyecto = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.BeProyectoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAgregar = New System.Windows.Forms.ToolStripButton
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.txtCantidadRecepcionada = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblCantidadRecepcionada = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        Me.txtOS = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtNroItem = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblNroItem = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblOrdenCompra = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtOc = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        Me.PSNRFRPD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNQCNTIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNQCNRCP = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgProyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BeProyectoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.tsMenuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgProyecto)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(568, 272)
        Me.KryptonPanel.TabIndex = 0
        '
        'dgProyecto
        '
        Me.dgProyecto.AllowUserToAddRows = False
        Me.dgProyecto.AllowUserToDeleteRows = False
        Me.dgProyecto.AutoGenerateColumns = False
        Me.dgProyecto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PSNRFRPD, Me.PNQCNTIT, Me.PNQCNRCP})
        Me.dgProyecto.DataSource = Me.BeProyectoBindingSource
        Me.dgProyecto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgProyecto.Location = New System.Drawing.Point(0, 128)
        Me.dgProyecto.Name = "dgProyecto"
        Me.dgProyecto.Size = New System.Drawing.Size(568, 144)
        Me.dgProyecto.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgProyecto.TabIndex = 152
        '
        'BeProyectoBindingSource
        '
        Me.BeProyectoBindingSource.DataSource = GetType(RANSA.TYPEDEF.beProyecto)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.btnEliminar, Me.ToolStripSeparator4, Me.btnAgregar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 103)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(568, 25)
        Me.ToolStrip1.TabIndex = 151
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnEliminar
        '
        Me.btnEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(68, 22)
        Me.btnEliminar.Text = "Eliminar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
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
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.txtCantidadRecepcionada)
        Me.KryptonPanel1.Controls.Add(Me.lblCantidadRecepcionada)
        Me.KryptonPanel1.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel1.Controls.Add(Me.txtOS)
        Me.KryptonPanel1.Controls.Add(Me.txtNroItem)
        Me.KryptonPanel1.Controls.Add(Me.lblNroItem)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel1.Controls.Add(Me.lblOrdenCompra)
        Me.KryptonPanel1.Controls.Add(Me.txtOc)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderForm
        Me.KryptonPanel1.Size = New System.Drawing.Size(568, 103)
        Me.KryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel1.TabIndex = 63
        '
        'txtCantidadRecepcionada
        '
        Me.txtCantidadRecepcionada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCantidadRecepcionada.Location = New System.Drawing.Point(412, 37)
        Me.txtCantidadRecepcionada.MaxLength = 20
        Me.txtCantidadRecepcionada.Name = "txtCantidadRecepcionada"
        Me.txtCantidadRecepcionada.ReadOnly = True
        Me.txtCantidadRecepcionada.Size = New System.Drawing.Size(152, 21)
        Me.txtCantidadRecepcionada.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtCantidadRecepcionada.TabIndex = 151
        Me.TypeValidator.SetTypes(Me.txtCantidadRecepcionada, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblCantidadRecepcionada
        '
        Me.lblCantidadRecepcionada.Location = New System.Drawing.Point(272, 38)
        Me.lblCantidadRecepcionada.Name = "lblCantidadRecepcionada"
        Me.lblCantidadRecepcionada.Size = New System.Drawing.Size(141, 19)
        Me.lblCantidadRecepcionada.TabIndex = 152
        Me.lblCantidadRecepcionada.Text = "Cant. Item Recepcionado :"
        Me.lblCantidadRecepcionada.Values.ExtraText = ""
        Me.lblCantidadRecepcionada.Values.Image = Nothing
        Me.lblCantidadRecepcionada.Values.Text = "Cant. Item Recepcionado :"
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnCancelar, Me.ToolStripSeparator3, Me.btnGuardar})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(568, 25)
        Me.tsMenuOpciones.TabIndex = 150
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(71, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnGuardar
        '
        Me.btnGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(69, 22)
        Me.btnGuardar.Text = "&Guardar"
        '
        'txtOS
        '
        Me.txtOS.Location = New System.Drawing.Point(108, 33)
        Me.txtOS.Name = "txtOS"
        Me.txtOS.ReadOnly = True
        Me.txtOS.Size = New System.Drawing.Size(159, 21)
        Me.txtOS.TabIndex = 144
        Me.TypeValidator.SetTypes(Me.txtOS, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'txtNroItem
        '
        Me.txtNroItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroItem.Location = New System.Drawing.Point(413, 60)
        Me.txtNroItem.MaxLength = 20
        Me.txtNroItem.Name = "txtNroItem"
        Me.txtNroItem.ReadOnly = True
        Me.txtNroItem.Size = New System.Drawing.Size(152, 21)
        Me.txtNroItem.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtNroItem.TabIndex = 148
        Me.TypeValidator.SetTypes(Me.txtNroItem, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblNroItem
        '
        Me.lblNroItem.Location = New System.Drawing.Point(349, 63)
        Me.lblNroItem.Name = "lblNroItem"
        Me.lblNroItem.Size = New System.Drawing.Size(63, 19)
        Me.lblNroItem.TabIndex = 149
        Me.lblNroItem.Text = "Nro. Item :"
        Me.lblNroItem.Values.ExtraText = ""
        Me.lblNroItem.Values.Image = Nothing
        Me.lblNroItem.Values.Text = "Nro. Item :"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(61, 35)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(45, 19)
        Me.KryptonLabel3.TabIndex = 145
        Me.KryptonLabel3.Text = "N° O.S."
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "N° O.S."
        '
        'lblOrdenCompra
        '
        Me.lblOrdenCompra.Location = New System.Drawing.Point(0, 59)
        Me.lblOrdenCompra.Name = "lblOrdenCompra"
        Me.lblOrdenCompra.Size = New System.Drawing.Size(106, 19)
        Me.lblOrdenCompra.TabIndex = 147
        Me.lblOrdenCompra.Text = "Orden de Compra :"
        Me.lblOrdenCompra.Values.ExtraText = ""
        Me.lblOrdenCompra.Values.Image = Nothing
        Me.lblOrdenCompra.Values.Text = "Orden de Compra :"
        '
        'txtOc
        '
        Me.txtOc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOc.Location = New System.Drawing.Point(108, 55)
        Me.txtOc.MaxLength = 20
        Me.txtOc.Name = "txtOc"
        Me.txtOc.ReadOnly = True
        Me.txtOc.Size = New System.Drawing.Size(159, 21)
        Me.txtOc.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtOc.TabIndex = 146
        Me.TypeValidator.SetTypes(Me.txtOc, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'PSNRFRPD
        '
        Me.PSNRFRPD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PSNRFRPD.DataPropertyName = "PSNRFRPD"
        Me.PSNRFRPD.HeaderText = "Numero Proyecto"
        Me.PSNRFRPD.MaxInputLength = 10
        Me.PSNRFRPD.Name = "PSNRFRPD"
        '
        'PNQCNTIT
        '
        Me.PNQCNTIT.DataPropertyName = "PNQCNTIT"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.PNQCNTIT.DefaultCellStyle = DataGridViewCellStyle1
        Me.PNQCNTIT.HeaderText = "Cant. Solicitado"
        Me.PNQCNTIT.MaxInputLength = 21
        Me.PNQCNTIT.Name = "PNQCNTIT"
        Me.PNQCNTIT.Width = 200
        '
        'PNQCNRCP
        '
        Me.PNQCNRCP.DataPropertyName = "PNQCNRCP"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.PNQCNRCP.DefaultCellStyle = DataGridViewCellStyle2
        Me.PNQCNRCP.HeaderText = "Cant.  Recepcionado "
        Me.PNQCNRCP.Name = "PNQCNRCP"
        Me.PNQCNRCP.Width = 150
        '
        'frmMantenimientoProyecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 272)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmMantenimientoProyecto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Proyecto"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dgProyecto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BeProyectoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
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
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents dgProyecto As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAgregar As System.Windows.Forms.ToolStripButton
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Private WithEvents txtOS As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtNroItem As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblNroItem As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblOrdenCompra As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtOc As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents BeProyectoBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents txtCantidadRecepcionada As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblCantidadRecepcionada As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents PSNRFRPD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQCNTIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQCNRCP As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
