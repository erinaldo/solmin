<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSerie_Dg
    Inherits System.Windows.Forms.UserControl

    'UserControl1 reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucSerie_Dg))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.statusBar = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.pnlMensaje = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblError = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonHeader1 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.ButtonSpecAny1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.KryptonBorderEdge3 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.KryptonBorderEdge2 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.KryptonBorderEdge1 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.dgSerie = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.PNNCRPLL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCSRECL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FSAL = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
        Me.kheTitulo = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnAgregar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.pnlMensaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlMensaje.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMensaje.Panel.SuspendLayout()
        Me.pnlMensaje.SuspendLayout()
        CType(Me.dgSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.statusBar)
        Me.KryptonPanel1.Controls.Add(Me.pnlMensaje)
        Me.KryptonPanel1.Controls.Add(Me.KryptonBorderEdge3)
        Me.KryptonPanel1.Controls.Add(Me.KryptonBorderEdge2)
        Me.KryptonPanel1.Controls.Add(Me.KryptonBorderEdge1)
        Me.KryptonPanel1.Controls.Add(Me.dgSerie)
        Me.KryptonPanel1.Controls.Add(Me.kheTitulo)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(353, 198)
        Me.KryptonPanel1.TabIndex = 1
        '
        'statusBar
        '
        Me.statusBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.statusBar.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form
        Me.statusBar.Location = New System.Drawing.Point(1, 193)
        Me.statusBar.Name = "statusBar"
        Me.statusBar.Size = New System.Drawing.Size(351, 4)
        Me.statusBar.TabIndex = 7
        Me.statusBar.Values.Description = ""
        Me.statusBar.Values.Heading = ""
        Me.statusBar.Values.Image = Nothing
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
        Me.KryptonLabel4.Size = New System.Drawing.Size(49, 16)
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
        Me.KryptonLabel2.Size = New System.Drawing.Size(116, 16)
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
        Me.KryptonLabel1.Size = New System.Drawing.Size(92, 16)
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
        Me.KryptonHeader1.Size = New System.Drawing.Size(211, 26)
        Me.KryptonHeader1.TabIndex = 0
        Me.KryptonHeader1.Text = "Error"
        Me.KryptonHeader1.Values.Description = ""
        Me.KryptonHeader1.Values.Heading = "Error"
        Me.KryptonHeader1.Values.Image = CType(resources.GetObject("KryptonHeader1.Values.Image"), System.Drawing.Image)
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
        'KryptonBorderEdge3
        '
        Me.KryptonBorderEdge3.Dock = System.Windows.Forms.DockStyle.Right
        Me.KryptonBorderEdge3.Location = New System.Drawing.Point(352, 21)
        Me.KryptonBorderEdge3.Name = "KryptonBorderEdge3"
        Me.KryptonBorderEdge3.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge3.Size = New System.Drawing.Size(1, 176)
        Me.KryptonBorderEdge3.TabIndex = 5
        Me.KryptonBorderEdge3.Text = "KryptonBorderEdge3"
        '
        'KryptonBorderEdge2
        '
        Me.KryptonBorderEdge2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonBorderEdge2.Location = New System.Drawing.Point(1, 197)
        Me.KryptonBorderEdge2.Name = "KryptonBorderEdge2"
        Me.KryptonBorderEdge2.Size = New System.Drawing.Size(352, 1)
        Me.KryptonBorderEdge2.TabIndex = 4
        Me.KryptonBorderEdge2.Text = "KryptonBorderEdge2"
        '
        'KryptonBorderEdge1
        '
        Me.KryptonBorderEdge1.Dock = System.Windows.Forms.DockStyle.Left
        Me.KryptonBorderEdge1.Location = New System.Drawing.Point(0, 21)
        Me.KryptonBorderEdge1.Name = "KryptonBorderEdge1"
        Me.KryptonBorderEdge1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge1.Size = New System.Drawing.Size(1, 177)
        Me.KryptonBorderEdge1.TabIndex = 3
        Me.KryptonBorderEdge1.Text = "KryptonBorderEdge1"
        '
        'dgSerie
        '
        Me.dgSerie.AllowUserToAddRows = False
        Me.dgSerie.AllowUserToDeleteRows = False
        Me.dgSerie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSerie.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PNNCRPLL, Me.PSCSRECL, Me.FSAL})
        Me.dgSerie.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgSerie.Location = New System.Drawing.Point(0, 21)
        Me.dgSerie.Name = "dgSerie"
        Me.dgSerie.Size = New System.Drawing.Size(353, 177)
        Me.dgSerie.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgSerie.TabIndex = 2
        '
        'PNNCRPLL
        '
        Me.PNNCRPLL.DataPropertyName = "PNNCRPLL"
        Me.PNNCRPLL.HeaderText = "Item"
        Me.PNNCRPLL.Name = "PNNCRPLL"
        Me.PNNCRPLL.ReadOnly = True
        Me.PNNCRPLL.Width = 60
        '
        'PSCSRECL
        '
        Me.PSCSRECL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PSCSRECL.DataPropertyName = "PSCSRECL"
        Me.PSCSRECL.HeaderText = "Serie"
        Me.PSCSRECL.MaxInputLength = 20
        Me.PSCSRECL.Name = "PSCSRECL"
        '
        'FSAL
        '
        Me.FSAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FSAL.DataPropertyName = "IsDespacho"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.NullValue = "false"
        Me.FSAL.DefaultCellStyle = DataGridViewCellStyle3
        Me.FSAL.FalseValue = Nothing
        Me.FSAL.HeaderText = "Despachar"
        Me.FSAL.IndeterminateValue = Nothing
        Me.FSAL.Name = "FSAL"
        Me.FSAL.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FSAL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FSAL.TrueValue = Nothing
        Me.FSAL.Width = 88
        '
        'kheTitulo
        '
        Me.kheTitulo.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnAgregar})
        Me.kheTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.kheTitulo.Location = New System.Drawing.Point(0, 0)
        Me.kheTitulo.Name = "kheTitulo"
        Me.kheTitulo.Size = New System.Drawing.Size(353, 21)
        Me.kheTitulo.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kheTitulo.TabIndex = 1
        Me.kheTitulo.Text = "Registro de Serie"
        Me.kheTitulo.Values.Description = ""
        Me.kheTitulo.Values.Heading = "Registro de Serie"
        Me.kheTitulo.Values.Image = Nothing
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Item"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Serie"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'btnAgregar
        '
        Me.btnAgregar.ExtraText = ""
        Me.btnAgregar.Image = Global.Ransa.Controls.Serie.My.Resources.Resources.edit_add
        Me.btnAgregar.Text = "Agregar Serie"
        Me.btnAgregar.ToolTipImage = Nothing
        Me.btnAgregar.UniqueName = "1AA2DFE4ACB545461AA2DFE4ACB54546"
        Me.btnAgregar.Visible = False
        '
        'ucSerie_Dg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Name = "ucSerie_Dg"
        Me.Size = New System.Drawing.Size(353, 198)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.pnlMensaje.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMensaje.Panel.ResumeLayout(False)
        Me.pnlMensaje.Panel.PerformLayout()
        CType(Me.pnlMensaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMensaje.ResumeLayout(False)
        CType(Me.dgSerie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents dgSerie As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents kheTitulo As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents KryptonBorderEdge1 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents KryptonBorderEdge3 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents KryptonBorderEdge2 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlMensaje As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblError As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonHeader1 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents ButtonSpecAny1 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents statusBar As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents PNNCRPLL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCSRECL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FSAL As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
    Friend WithEvents btnAgregar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny

End Class
