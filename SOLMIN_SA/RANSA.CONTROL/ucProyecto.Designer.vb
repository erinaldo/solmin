<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucProyecto
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucProyecto))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonBorderEdge2 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.KryptonBorderEdge1 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.dgProyecto = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.btnAgregar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.KryptonBorderEdge3 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.kheTitulo = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.btnEliminar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.statusBar = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.ButtonSpecAny1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.pnlMensaje = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblError = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonHeader1 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNRFRPD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNQCNTIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QCNRCP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QCNDPC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNQCNTIT2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgProyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.pnlMensaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlMensaje.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMensaje.Panel.SuspendLayout()
        Me.pnlMensaje.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonBorderEdge2
        '
        Me.KryptonBorderEdge2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonBorderEdge2.Location = New System.Drawing.Point(1, 209)
        Me.KryptonBorderEdge2.Name = "KryptonBorderEdge2"
        Me.KryptonBorderEdge2.Size = New System.Drawing.Size(564, 1)
        Me.KryptonBorderEdge2.TabIndex = 4
        Me.KryptonBorderEdge2.Text = "KryptonBorderEdge2"
        '
        'KryptonBorderEdge1
        '
        Me.KryptonBorderEdge1.Dock = System.Windows.Forms.DockStyle.Left
        Me.KryptonBorderEdge1.Location = New System.Drawing.Point(0, 29)
        Me.KryptonBorderEdge1.Name = "KryptonBorderEdge1"
        Me.KryptonBorderEdge1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge1.Size = New System.Drawing.Size(1, 181)
        Me.KryptonBorderEdge1.TabIndex = 3
        Me.KryptonBorderEdge1.Text = "KryptonBorderEdge1"
        '
        'dgProyecto
        '
        Me.dgProyecto.AllowUserToAddRows = False
        Me.dgProyecto.AllowUserToDeleteRows = False
        Me.dgProyecto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PSNRFRPD, Me.PNQCNTIT, Me.QCNRCP, Me.QCNDPC, Me.PNQCNTIT2})
        Me.dgProyecto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgProyecto.Location = New System.Drawing.Point(0, 29)
        Me.dgProyecto.Name = "dgProyecto"
        Me.dgProyecto.Size = New System.Drawing.Size(565, 181)
        Me.dgProyecto.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgProyecto.TabIndex = 2
        '
        'btnAgregar
        '
        Me.btnAgregar.ExtraText = ""
        Me.btnAgregar.Image = Nothing
        Me.btnAgregar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.btnAgregar.Text = "Agregar "
        Me.btnAgregar.ToolTipImage = Nothing
        Me.btnAgregar.UniqueName = "1AA2DFE4ACB545461AA2DFE4ACB54546"
        '
        'KryptonBorderEdge3
        '
        Me.KryptonBorderEdge3.Dock = System.Windows.Forms.DockStyle.Right
        Me.KryptonBorderEdge3.Location = New System.Drawing.Point(564, 29)
        Me.KryptonBorderEdge3.Name = "KryptonBorderEdge3"
        Me.KryptonBorderEdge3.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge3.Size = New System.Drawing.Size(1, 180)
        Me.KryptonBorderEdge3.TabIndex = 5
        Me.KryptonBorderEdge3.Text = "KryptonBorderEdge3"
        '
        'kheTitulo
        '
        Me.kheTitulo.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnAgregar, Me.btnEliminar})
        Me.kheTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.kheTitulo.Location = New System.Drawing.Point(0, 0)
        Me.kheTitulo.Name = "kheTitulo"
        Me.kheTitulo.Size = New System.Drawing.Size(565, 29)
        Me.kheTitulo.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kheTitulo.TabIndex = 1
        Me.kheTitulo.Text = "Registro de Proyecto"
        Me.kheTitulo.Values.Description = ""
        Me.kheTitulo.Values.Heading = "Registro de Proyecto"
        Me.kheTitulo.Values.Image = Nothing
        '
        'btnEliminar
        '
        Me.btnEliminar.ExtraText = ""
        Me.btnEliminar.Image = Nothing
        Me.btnEliminar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.ToolTipImage = Nothing
        Me.btnEliminar.UniqueName = "16386E7086244C0616386E7086244C06"
        '
        'statusBar
        '
        Me.statusBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.statusBar.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form
        Me.statusBar.Location = New System.Drawing.Point(1, 205)
        Me.statusBar.Name = "statusBar"
        Me.statusBar.Size = New System.Drawing.Size(563, 4)
        Me.statusBar.TabIndex = 7
        Me.statusBar.Values.Description = ""
        Me.statusBar.Values.Heading = ""
        Me.statusBar.Values.Image = Nothing
        '
        'ButtonSpecAny1
        '
        Me.ButtonSpecAny1.ExtraText = ""
        Me.ButtonSpecAny1.Image = Nothing
        Me.ButtonSpecAny1.Text = ""
        Me.ButtonSpecAny1.ToolTipImage = Nothing
        Me.ButtonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.ButtonSpecAny1.UniqueName = "69E255AA8AE44A1B69E255AA8AE44A1B"
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.statusBar)
        Me.KryptonPanel1.Controls.Add(Me.pnlMensaje)
        Me.KryptonPanel1.Controls.Add(Me.KryptonBorderEdge3)
        Me.KryptonPanel1.Controls.Add(Me.KryptonBorderEdge2)
        Me.KryptonPanel1.Controls.Add(Me.KryptonBorderEdge1)
        Me.KryptonPanel1.Controls.Add(Me.dgProyecto)
        Me.KryptonPanel1.Controls.Add(Me.kheTitulo)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(565, 210)
        Me.KryptonPanel1.TabIndex = 2
        '
        'pnlMensaje
        '
        Me.pnlMensaje.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.pnlMensaje.Location = New System.Drawing.Point(63, 63)
        Me.pnlMensaje.Name = "pnlMensaje"
        '
        'pnlMensaje.Panel
        '
        Me.pnlMensaje.Panel.Controls.Add(Me.KryptonLabel4)
        Me.pnlMensaje.Panel.Controls.Add(Me.lblError)
        Me.pnlMensaje.Panel.Controls.Add(Me.KryptonLabel2)
        Me.pnlMensaje.Panel.Controls.Add(Me.KryptonLabel1)
        Me.pnlMensaje.Panel.Controls.Add(Me.KryptonHeader1)
        Me.pnlMensaje.Size = New System.Drawing.Size(213, 111)
        Me.pnlMensaje.TabIndex = 6
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(145, 60)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(48, 19)
        Me.KryptonLabel4.TabIndex = 4
        Me.KryptonLabel4.Text = "errores."
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "errores."
        '
        'lblError
        '
        Me.lblError.Location = New System.Drawing.Point(132, 59)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(6, 2)
        Me.lblError.TabIndex = 3
        Me.lblError.Values.ExtraText = ""
        Me.lblError.Values.Image = Nothing
        Me.lblError.Values.Text = ""
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(12, 60)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(113, 19)
        Me.KryptonLabel2.TabIndex = 2
        Me.KryptonLabel2.Text = "Este listado presenta "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Este listado presenta "
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(12, 35)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(91, 19)
        Me.KryptonLabel1.TabIndex = 1
        Me.KryptonLabel1.Text = "Error al guardar."
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Error al guardar."
        '
        'KryptonHeader1
        '
        Me.KryptonHeader1.AllowButtonSpecToolTips = True
        Me.KryptonHeader1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.ButtonSpecAny1})
        Me.KryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeader1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeader1.Name = "KryptonHeader1"
        Me.KryptonHeader1.Size = New System.Drawing.Size(211, 29)
        Me.KryptonHeader1.TabIndex = 0
        Me.KryptonHeader1.Text = "Error"
        Me.KryptonHeader1.Values.Description = ""
        Me.KryptonHeader1.Values.Heading = "Error"
        Me.KryptonHeader1.Values.Image = CType(resources.GetObject("KryptonHeader1.Values.Image"), System.Drawing.Image)
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PNNCRPLL"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Item"
        Me.DataGridViewTextBoxColumn1.MaxInputLength = 10
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PSCSRECL"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = "0"
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn2.HeaderText = "Serie"
        Me.DataGridViewTextBoxColumn2.MaxInputLength = 20
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PNQCNRCP"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = "0"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cantidad Recibidad"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PNQCNDPC"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N0"
        DataGridViewCellStyle7.NullValue = "0"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cantidad Despachada"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PNQCNTIT2"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N0"
        DataGridViewCellStyle8.NullValue = "0"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cantidad Recibir"
        Me.DataGridViewTextBoxColumn5.MaxInputLength = 21
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 106
        '
        'PSNRFRPD
        '
        Me.PSNRFRPD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PSNRFRPD.DataPropertyName = "PSNRFRPD"
        Me.PSNRFRPD.HeaderText = "Numero Proyecto"
        Me.PSNRFRPD.MaxInputLength = 10
        Me.PSNRFRPD.Name = "PSNRFRPD"
        Me.PSNRFRPD.ReadOnly = True
        '
        'PNQCNTIT
        '
        Me.PNQCNTIT.DataPropertyName = "PNQCNTIT"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = "0"
        Me.PNQCNTIT.DefaultCellStyle = DataGridViewCellStyle1
        Me.PNQCNTIT.HeaderText = "Cantidad Solicitada"
        Me.PNQCNTIT.MaxInputLength = 21
        Me.PNQCNTIT.Name = "PNQCNTIT"
        Me.PNQCNTIT.ReadOnly = True
        Me.PNQCNTIT.Width = 105
        '
        'QCNRCP
        '
        Me.QCNRCP.DataPropertyName = "PNQCNRCP"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = "0"
        Me.QCNRCP.DefaultCellStyle = DataGridViewCellStyle2
        Me.QCNRCP.HeaderText = "Cantidad Recibidad"
        Me.QCNRCP.Name = "QCNRCP"
        '
        'QCNDPC
        '
        Me.QCNDPC.DataPropertyName = "PNQCNDPC"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = "0"
        Me.QCNDPC.DefaultCellStyle = DataGridViewCellStyle3
        Me.QCNDPC.HeaderText = "Cantidad Despachada"
        Me.QCNDPC.Name = "QCNDPC"
        '
        'PNQCNTIT2
        '
        Me.PNQCNTIT2.DataPropertyName = "PNQCNTIT2"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = "0"
        Me.PNQCNTIT2.DefaultCellStyle = DataGridViewCellStyle4
        Me.PNQCNTIT2.HeaderText = "Cantidad Recibir"
        Me.PNQCNTIT2.MaxInputLength = 21
        Me.PNQCNTIT2.Name = "PNQCNTIT2"
        Me.PNQCNTIT2.Width = 106
        '
        'ucProyecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Name = "ucProyecto"
        Me.Size = New System.Drawing.Size(565, 210)
        CType(Me.dgProyecto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.pnlMensaje.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMensaje.Panel.ResumeLayout(False)
        Me.pnlMensaje.Panel.PerformLayout()
        CType(Me.pnlMensaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMensaje.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonBorderEdge2 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents KryptonBorderEdge1 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents dgProyecto As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAgregar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents KryptonBorderEdge3 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents kheTitulo As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents statusBar As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents ButtonSpecAny1 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents pnlMensaje As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblError As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonHeader1 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNRFRPD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQCNTIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QCNRCP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QCNDPC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQCNTIT2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnEliminar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
