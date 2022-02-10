<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuiaRemision_Facturacion
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.SplitContainer = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Me.gwdGuiasRemision = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.Agregar = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.NRGUCL = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.FCGUCL = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.TCMPCL = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.MenuBar = New System.Windows.Forms.ToolStrip
    Me.btnSalir = New System.Windows.Forms.ToolStripButton
    Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
    Me.txtPesoNeto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtPesoBruto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonBorderEdge1 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
    Me.dtpFechaSalida = New System.Windows.Forms.DateTimePicker
    Me.txtVolumen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtCantidadBultos = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.MenuBar_1 = New System.Windows.Forms.ToolStrip
    Me.btnAgregarGuiaRemision = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.btnCancelar = New System.Windows.Forms.ToolStripButton
    Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
    CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SplitContainer.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainer.Panel1.SuspendLayout()
    CType(Me.SplitContainer.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainer.Panel2.SuspendLayout()
    Me.SplitContainer.SuspendLayout()
    CType(Me.gwdGuiasRemision, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.MenuBar.SuspendLayout()
    Me.MenuBar_1.SuspendLayout()
    Me.SuspendLayout()
    '
    'SplitContainer
    '
    Me.SplitContainer.Cursor = System.Windows.Forms.Cursors.Default
    Me.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SplitContainer.Location = New System.Drawing.Point(0, 0)
    Me.SplitContainer.Name = "SplitContainer"
    Me.SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
    '
    'SplitContainer.Panel1
    '
    Me.SplitContainer.Panel1.Controls.Add(Me.gwdGuiasRemision)
    Me.SplitContainer.Panel1.Controls.Add(Me.MenuBar)
    '
    'SplitContainer.Panel2
    '
    Me.SplitContainer.Panel2.Controls.Add(Me.txtPesoNeto)
    Me.SplitContainer.Panel2.Controls.Add(Me.KryptonLabel1)
    Me.SplitContainer.Panel2.Controls.Add(Me.txtPesoBruto)
    Me.SplitContainer.Panel2.Controls.Add(Me.KryptonLabel5)
    Me.SplitContainer.Panel2.Controls.Add(Me.KryptonBorderEdge1)
    Me.SplitContainer.Panel2.Controls.Add(Me.KryptonLabel6)
    Me.SplitContainer.Panel2.Controls.Add(Me.DateTimePicker1)
    Me.SplitContainer.Panel2.Controls.Add(Me.dtpFechaSalida)
    Me.SplitContainer.Panel2.Controls.Add(Me.txtVolumen)
    Me.SplitContainer.Panel2.Controls.Add(Me.KryptonLabel2)
    Me.SplitContainer.Panel2.Controls.Add(Me.KryptonLabel4)
    Me.SplitContainer.Panel2.Controls.Add(Me.txtCantidadBultos)
    Me.SplitContainer.Panel2.Controls.Add(Me.MenuBar_1)
    Me.SplitContainer.Panel2.Controls.Add(Me.KryptonLabel3)
    Me.SplitContainer.Panel2.StateCommon.Color1 = System.Drawing.Color.White
    Me.SplitContainer.Size = New System.Drawing.Size(514, 386)
    Me.SplitContainer.SplitterDistance = 246
    Me.SplitContainer.TabIndex = 0
    '
    'gwdGuiasRemision
    '
    Me.gwdGuiasRemision.AllowUserToAddRows = False
    Me.gwdGuiasRemision.AllowUserToDeleteRows = False
    Me.gwdGuiasRemision.AllowUserToResizeColumns = False
    Me.gwdGuiasRemision.AllowUserToResizeRows = False
    Me.gwdGuiasRemision.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
    Me.gwdGuiasRemision.ColumnHeadersHeight = 25
    Me.gwdGuiasRemision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    Me.gwdGuiasRemision.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Agregar, Me.DataGridViewTextBoxColumn1, Me.NRGUCL, Me.FCGUCL, Me.TCMPCL, Me.CCLNT})
    Me.gwdGuiasRemision.Dock = System.Windows.Forms.DockStyle.Fill
    Me.gwdGuiasRemision.Location = New System.Drawing.Point(0, 25)
    Me.gwdGuiasRemision.Name = "gwdGuiasRemision"
    Me.gwdGuiasRemision.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
    Me.gwdGuiasRemision.RowHeadersVisible = False
    Me.gwdGuiasRemision.RowHeadersWidth = 20
    Me.gwdGuiasRemision.Size = New System.Drawing.Size(514, 221)
    Me.gwdGuiasRemision.StandardTab = True
    Me.gwdGuiasRemision.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.gwdGuiasRemision.TabIndex = 0
    '
    'Agregar
    '
    Me.Agregar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle1.NullValue = False
    Me.Agregar.DefaultCellStyle = DataGridViewCellStyle1
    Me.Agregar.FalseValue = Nothing
    Me.Agregar.HeaderText = "       "
    Me.Agregar.IndeterminateValue = Nothing
    Me.Agregar.Name = "Agregar"
    Me.Agregar.TrueValue = Nothing
    Me.Agregar.Width = 35
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn1.DataPropertyName = "NGUIRM"
    Me.DataGridViewTextBoxColumn1.HeaderText = "Guia Transportista"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    Me.DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewTextBoxColumn1.Visible = False
    Me.DataGridViewTextBoxColumn1.Width = 122
    '
    'NRGUCL
    '
    Me.NRGUCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.NRGUCL.DataPropertyName = "NRGUCL"
    Me.NRGUCL.HeaderText = "Guia Remision Cliente"
    Me.NRGUCL.Name = "NRGUCL"
    Me.NRGUCL.ReadOnly = True
    Me.NRGUCL.Width = 139
    '
    'FCGUCL
    '
    Me.FCGUCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.FCGUCL.DataPropertyName = "FCGUCL_S"
    Me.FCGUCL.HeaderText = "Fecha Guia Remision"
    Me.FCGUCL.Name = "FCGUCL"
    Me.FCGUCL.ReadOnly = True
    Me.FCGUCL.Width = 137
    '
    'TCMPCL
    '
    Me.TCMPCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.TCMPCL.DataPropertyName = "TCMPCL"
    Me.TCMPCL.HeaderText = "Nombre Cliente"
    Me.TCMPCL.Name = "TCMPCL"
    Me.TCMPCL.ReadOnly = True
    '
    'CCLNT
    '
    Me.CCLNT.DataPropertyName = "CCLNT"
    Me.CCLNT.HeaderText = "Cod. Cliente"
    Me.CCLNT.Name = "CCLNT"
    Me.CCLNT.ReadOnly = True
    Me.CCLNT.Visible = False
    Me.CCLNT.Width = 93
    '
    'MenuBar
    '
    Me.MenuBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
    Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSalir, Me.ToolStripLabel1})
    Me.MenuBar.Location = New System.Drawing.Point(0, 0)
    Me.MenuBar.Name = "MenuBar"
    Me.MenuBar.Size = New System.Drawing.Size(514, 25)
    Me.MenuBar.TabIndex = 8
    '
    'btnSalir
    '
    Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnSalir.Image = Global.SOLMIN_ST.My.Resources.Resources._exit
    Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnSalir.Name = "btnSalir"
    Me.btnSalir.Size = New System.Drawing.Size(47, 22)
    Me.btnSalir.Text = "Salir"
    '
    'ToolStripLabel1
    '
    Me.ToolStripLabel1.Name = "ToolStripLabel1"
    Me.ToolStripLabel1.Size = New System.Drawing.Size(173, 22)
    Me.ToolStripLabel1.Text = "  AGREGAR  G / R  A FACTURAR"
    '
    'txtPesoNeto
    '
    Me.txtPesoNeto.Location = New System.Drawing.Point(264, 67)
    Me.txtPesoNeto.MaxLength = 10
    Me.txtPesoNeto.Name = "txtPesoNeto"
    Me.txtPesoNeto.Size = New System.Drawing.Size(100, 19)
    Me.txtPesoNeto.TabIndex = 3
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(3, 40)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(76, 16)
    Me.KryptonLabel1.TabIndex = 0
    Me.KryptonLabel1.Text = "Fecha Salida"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Fecha Salida"
    '
    'txtPesoBruto
    '
    Me.txtPesoBruto.Location = New System.Drawing.Point(264, 39)
    Me.txtPesoBruto.MaxLength = 10
    Me.txtPesoBruto.Name = "txtPesoBruto"
    Me.txtPesoBruto.Size = New System.Drawing.Size(100, 19)
    Me.txtPesoBruto.TabIndex = 1
    '
    'KryptonLabel5
    '
    Me.KryptonLabel5.Location = New System.Drawing.Point(196, 40)
    Me.KryptonLabel5.Name = "KryptonLabel5"
    Me.KryptonLabel5.Size = New System.Drawing.Size(66, 16)
    Me.KryptonLabel5.TabIndex = 0
    Me.KryptonLabel5.Text = "Peso Bruto"
    Me.KryptonLabel5.Values.ExtraText = ""
    Me.KryptonLabel5.Values.Image = Nothing
    Me.KryptonLabel5.Values.Text = "Peso Bruto"
    '
    'KryptonBorderEdge1
    '
    Me.KryptonBorderEdge1.Location = New System.Drawing.Point(189, 32)
    Me.KryptonBorderEdge1.Name = "KryptonBorderEdge1"
    Me.KryptonBorderEdge1.Orientation = System.Windows.Forms.Orientation.Vertical
    Me.KryptonBorderEdge1.Size = New System.Drawing.Size(1, 90)
    Me.KryptonBorderEdge1.TabIndex = 4
    Me.KryptonBorderEdge1.Text = "KryptonBorderEdge1"
    '
    'KryptonLabel6
    '
    Me.KryptonLabel6.Location = New System.Drawing.Point(196, 68)
    Me.KryptonLabel6.Name = "KryptonLabel6"
    Me.KryptonLabel6.Size = New System.Drawing.Size(63, 16)
    Me.KryptonLabel6.TabIndex = 2
    Me.KryptonLabel6.Text = "Peso Neto"
    Me.KryptonLabel6.Values.ExtraText = ""
    Me.KryptonLabel6.Values.Image = Nothing
    Me.KryptonLabel6.Values.Text = "Peso Neto"
    '
    'DateTimePicker1
    '
    Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.DateTimePicker1.Location = New System.Drawing.Point(89, 66)
    Me.DateTimePicker1.Name = "DateTimePicker1"
    Me.DateTimePicker1.Size = New System.Drawing.Size(88, 20)
    Me.DateTimePicker1.TabIndex = 3
    '
    'dtpFechaSalida
    '
    Me.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaSalida.Location = New System.Drawing.Point(89, 38)
    Me.dtpFechaSalida.Name = "dtpFechaSalida"
    Me.dtpFechaSalida.Size = New System.Drawing.Size(88, 20)
    Me.dtpFechaSalida.TabIndex = 1
    '
    'txtVolumen
    '
    Me.txtVolumen.Location = New System.Drawing.Point(264, 95)
    Me.txtVolumen.MaxLength = 10
    Me.txtVolumen.Name = "txtVolumen"
    Me.txtVolumen.Size = New System.Drawing.Size(100, 19)
    Me.txtVolumen.TabIndex = 7
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(3, 68)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(85, 16)
    Me.KryptonLabel2.TabIndex = 2
    Me.KryptonLabel2.Text = "Fecha Llegada"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "Fecha Llegada"
    '
    'KryptonLabel4
    '
    Me.KryptonLabel4.Location = New System.Drawing.Point(196, 95)
    Me.KryptonLabel4.Name = "KryptonLabel4"
    Me.KryptonLabel4.Size = New System.Drawing.Size(55, 16)
    Me.KryptonLabel4.TabIndex = 6
    Me.KryptonLabel4.Text = "Volumen"
    Me.KryptonLabel4.Values.ExtraText = ""
    Me.KryptonLabel4.Values.Image = Nothing
    Me.KryptonLabel4.Values.Text = "Volumen"
    '
    'txtCantidadBultos
    '
    Me.txtCantidadBultos.Location = New System.Drawing.Point(89, 95)
    Me.txtCantidadBultos.MaxLength = 10
    Me.txtCantidadBultos.Name = "txtCantidadBultos"
    Me.txtCantidadBultos.Size = New System.Drawing.Size(88, 19)
    Me.txtCantidadBultos.TabIndex = 3
    '
    'MenuBar_1
    '
    Me.MenuBar_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
    Me.MenuBar_1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.MenuBar_1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAgregarGuiaRemision, Me.ToolStripSeparator1, Me.btnCancelar})
    Me.MenuBar_1.Location = New System.Drawing.Point(0, 0)
    Me.MenuBar_1.Name = "MenuBar_1"
    Me.MenuBar_1.Size = New System.Drawing.Size(514, 25)
    Me.MenuBar_1.TabIndex = 0
    Me.MenuBar_1.TabStop = True
    Me.MenuBar_1.Text = "ToolStrip1"
    '
    'btnAgregarGuiaRemision
    '
    Me.btnAgregarGuiaRemision.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
    Me.btnAgregarGuiaRemision.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnAgregarGuiaRemision.Name = "btnAgregarGuiaRemision"
    Me.btnAgregarGuiaRemision.Size = New System.Drawing.Size(94, 22)
    Me.btnAgregarGuiaRemision.Text = "Agregar G / R"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
    '
    'btnCancelar
    '
    Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
    Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(106, 22)
    Me.btnCancelar.Text = " Cancelar Check"
    '
    'KryptonLabel3
    '
    Me.KryptonLabel3.Location = New System.Drawing.Point(3, 95)
    Me.KryptonLabel3.Name = "KryptonLabel3"
    Me.KryptonLabel3.Size = New System.Drawing.Size(56, 16)
    Me.KryptonLabel3.TabIndex = 2
    Me.KryptonLabel3.Text = "Cantidad"
    Me.KryptonLabel3.Values.ExtraText = ""
    Me.KryptonLabel3.Values.Image = Nothing
    Me.KryptonLabel3.Values.Text = "Cantidad"
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn2.DataPropertyName = "NRGUCL"
    Me.DataGridViewTextBoxColumn2.HeaderText = "Guia Remision Cliente"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    Me.DataGridViewTextBoxColumn2.ReadOnly = True
    '
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn3.DataPropertyName = "FCGUCL_S"
    Me.DataGridViewTextBoxColumn3.HeaderText = "Fecha Guia Remision"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    Me.DataGridViewTextBoxColumn3.ReadOnly = True
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.DataGridViewTextBoxColumn4.DataPropertyName = "TCMPCL"
    Me.DataGridViewTextBoxColumn4.HeaderText = "Nombre Cliente"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    Me.DataGridViewTextBoxColumn4.ReadOnly = True
    '
    'DataGridViewTextBoxColumn5
    '
    Me.DataGridViewTextBoxColumn5.DataPropertyName = "CCLNT"
    Me.DataGridViewTextBoxColumn5.HeaderText = "Cod. Cliente"
    Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
    Me.DataGridViewTextBoxColumn5.ReadOnly = True
    Me.DataGridViewTextBoxColumn5.Visible = False
    Me.DataGridViewTextBoxColumn5.Width = 93
    '
    'frmGuiaRemision_Facturacion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(514, 386)
    Me.ControlBox = False
    Me.Controls.Add(Me.SplitContainer)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.MaximumSize = New System.Drawing.Size(520, 410)
    Me.MinimumSize = New System.Drawing.Size(520, 410)
    Me.Name = "frmGuiaRemision_Facturacion"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = " "
    CType(Me.SplitContainer.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainer.Panel1.ResumeLayout(False)
    Me.SplitContainer.Panel1.PerformLayout()
    CType(Me.SplitContainer.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainer.Panel2.ResumeLayout(False)
    Me.SplitContainer.Panel2.PerformLayout()
    CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainer.ResumeLayout(False)
    CType(Me.gwdGuiasRemision, System.ComponentModel.ISupportInitialize).EndInit()
    Me.MenuBar.ResumeLayout(False)
    Me.MenuBar.PerformLayout()
    Me.MenuBar_1.ResumeLayout(False)
    Me.MenuBar_1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

  Public Sub New()

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub
  Friend WithEvents SplitContainer As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
  Friend WithEvents gwdGuiasRemision As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
  Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
  Friend WithEvents dtpFechaSalida As System.Windows.Forms.DateTimePicker
  Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents MenuBar_1 As System.Windows.Forms.ToolStrip
  Friend WithEvents btnAgregarGuiaRemision As System.Windows.Forms.ToolStripButton
  Friend WithEvents txtCantidadBultos As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonBorderEdge1 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
  Friend WithEvents txtVolumen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtPesoNeto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents txtPesoBruto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents Agregar As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NRGUCL As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FCGUCL As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TCMPCL As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
End Class
