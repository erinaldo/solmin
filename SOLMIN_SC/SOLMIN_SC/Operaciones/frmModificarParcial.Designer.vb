<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarParcial
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModificarParcial))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.gvItemParcial = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.tspListadoCargaInt = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.txtParcialNuevo = New Ransa.Utilitario.clsTextBoxNumero
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtParcialAnt = New System.Windows.Forms.TextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtOC = New System.Windows.Forms.TextBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.lblCompania = New System.Windows.Forms.ToolStripLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRPEMB = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NORCML = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRPARC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRITOC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SBITOC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDITES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QRLCSC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnBuscar = New System.Windows.Forms.PictureBox
        Me.btnSalir = New System.Windows.Forms.ToolStripButton
        Me.btnActualizar = New System.Windows.Forms.ToolStripButton
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.gvItemParcial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tspListadoCargaInt.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.btnBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.gvItemParcial)
        Me.KryptonPanel.Controls.Add(Me.tspListadoCargaInt)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(679, 395)
        Me.KryptonPanel.TabIndex = 0
        '
        'gvItemParcial
        '
        Me.gvItemParcial.AllowUserToAddRows = False
        Me.gvItemParcial.AllowUserToDeleteRows = False
        Me.gvItemParcial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvItemParcial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NRPEMB, Me.NORCML, Me.NRPARC, Me.NRITOC, Me.SBITOC, Me.TDITES, Me.QRLCSC})
        Me.gvItemParcial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvItemParcial.Location = New System.Drawing.Point(0, 107)
        Me.gvItemParcial.MultiSelect = False
        Me.gvItemParcial.Name = "gvItemParcial"
        Me.gvItemParcial.ReadOnly = True
        Me.gvItemParcial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvItemParcial.Size = New System.Drawing.Size(679, 288)
        Me.gvItemParcial.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.gvItemParcial.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gvItemParcial.TabIndex = 132
        '
        'tspListadoCargaInt
        '
        Me.tspListadoCargaInt.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tspListadoCargaInt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspListadoCargaInt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.tspListadoCargaInt.Location = New System.Drawing.Point(0, 82)
        Me.tspListadoCargaInt.Name = "tspListadoCargaInt"
        Me.tspListadoCargaInt.Size = New System.Drawing.Size(679, 25)
        Me.tspListadoCargaInt.TabIndex = 71
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(94, 22)
        Me.ToolStripLabel1.Text = "Items a modificar"
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 25)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtParcialNuevo)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtParcialAnt)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtOC)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.btnBuscar)
        Me.KryptonHeaderGroup1.Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(679, 57)
        Me.KryptonHeaderGroup1.StateDisabled.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.KryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.TabIndex = 64
        Me.KryptonHeaderGroup1.Text = "Datos"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Datos"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'txtParcialNuevo
        '
        Me.txtParcialNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtParcialNuevo.Location = New System.Drawing.Point(522, 7)
        Me.txtParcialNuevo.MaxLength = 3
        Me.txtParcialNuevo.Name = "txtParcialNuevo"
        Me.txtParcialNuevo.NUMDECIMALES = 0
        Me.txtParcialNuevo.NUMENTEROS = 3
        Me.txtParcialNuevo.Size = New System.Drawing.Size(58, 20)
        Me.txtParcialNuevo.TabIndex = 130
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(435, 6)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(81, 19)
        Me.KryptonLabel3.TabIndex = 129
        Me.KryptonLabel3.Text = "Nuevo Parcial:"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Nuevo Parcial:"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(261, 7)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(80, 19)
        Me.KryptonLabel1.TabIndex = 128
        Me.KryptonLabel1.Text = "Parcial Actual:"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Parcial Actual:"
        '
        'txtParcialAnt
        '
        Me.txtParcialAnt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtParcialAnt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParcialAnt.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtParcialAnt.Location = New System.Drawing.Point(356, 6)
        Me.txtParcialAnt.MaxLength = 35
        Me.txtParcialAnt.Name = "txtParcialAnt"
        Me.txtParcialAnt.ReadOnly = True
        Me.txtParcialAnt.Size = New System.Drawing.Size(73, 20)
        Me.txtParcialAnt.TabIndex = 127
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(11, 8)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(31, 19)
        Me.KryptonLabel2.TabIndex = 126
        Me.KryptonLabel2.Text = "O.C:"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "O.C:"
        '
        'txtOC
        '
        Me.txtOC.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtOC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOC.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtOC.Location = New System.Drawing.Point(48, 7)
        Me.txtOC.MaxLength = 35
        Me.txtOC.Name = "txtOC"
        Me.txtOC.ReadOnly = True
        Me.txtOC.Size = New System.Drawing.Size(207, 20)
        Me.txtOC.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSalir, Me.btnActualizar, Me.lblCompania})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(679, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'lblCompania
        '
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(0, 22)
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NRPEMB"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PreEmbarque"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 85
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NORCML"
        Me.DataGridViewTextBoxColumn2.HeaderText = "O/C"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 37
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NRPARC"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Parcial"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn3.Width = 50
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NRITOC"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Item"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn4.Width = 39
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SBITOC"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Sub Item"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn5.Width = 62
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TDITES"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "QRLCSC"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn7.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn7.Width = 64
        '
        'NRPEMB
        '
        Me.NRPEMB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRPEMB.DataPropertyName = "NRPEMB"
        Me.NRPEMB.HeaderText = "PreEmbarque"
        Me.NRPEMB.Name = "NRPEMB"
        Me.NRPEMB.ReadOnly = True
        Me.NRPEMB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NRPEMB.Width = 85
        '
        'NORCML
        '
        Me.NORCML.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NORCML.DataPropertyName = "NORCML"
        Me.NORCML.HeaderText = "O/C"
        Me.NORCML.Name = "NORCML"
        Me.NORCML.ReadOnly = True
        Me.NORCML.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NORCML.Width = 37
        '
        'NRPARC
        '
        Me.NRPARC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRPARC.DataPropertyName = "NRPARC"
        Me.NRPARC.HeaderText = "Parcial"
        Me.NRPARC.Name = "NRPARC"
        Me.NRPARC.ReadOnly = True
        Me.NRPARC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NRPARC.Width = 50
        '
        'NRITOC
        '
        Me.NRITOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRITOC.DataPropertyName = "NRITOC"
        Me.NRITOC.HeaderText = "Item"
        Me.NRITOC.Name = "NRITOC"
        Me.NRITOC.ReadOnly = True
        Me.NRITOC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NRITOC.Width = 39
        '
        'SBITOC
        '
        Me.SBITOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SBITOC.DataPropertyName = "SBITOC"
        Me.SBITOC.HeaderText = "Sub Item"
        Me.SBITOC.Name = "SBITOC"
        Me.SBITOC.ReadOnly = True
        Me.SBITOC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SBITOC.Width = 62
        '
        'TDITES
        '
        Me.TDITES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TDITES.DataPropertyName = "TDITES"
        Me.TDITES.HeaderText = "Descripción"
        Me.TDITES.Name = "TDITES"
        Me.TDITES.ReadOnly = True
        Me.TDITES.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'QRLCSC
        '
        Me.QRLCSC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QRLCSC.DataPropertyName = "QRLCSC"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.QRLCSC.DefaultCellStyle = DataGridViewCellStyle4
        Me.QRLCSC.HeaderText = "Cantidad"
        Me.QRLCSC.Name = "QRLCSC"
        Me.QRLCSC.ReadOnly = True
        Me.QRLCSC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.QRLCSC.Width = 64
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.BackColor = System.Drawing.Color.White
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnBuscar.Location = New System.Drawing.Point(891, 5)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(40, 0)
        Me.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnBuscar.TabIndex = 31
        Me.btnBuscar.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalir.Image = Global.SOLMIN_SC.My.Resources.Resources._exit
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(49, 22)
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.ToolTipText = "Salir"
        '
        'btnActualizar
        '
        Me.btnActualizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnActualizar.Image = Global.SOLMIN_SC.My.Resources.Resources.button_ok1
        Me.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(77, 22)
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.ToolTipText = "Embarcar"
        '
        'frmModificarParcial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 395)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmModificarParcial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Actualizar N° Parcial"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.gvItemParcial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tspListadoCargaInt.ResumeLayout(False)
        Me.tspListadoCargaInt.PerformLayout()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.btnBuscar, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnActualizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblCompania As System.Windows.Forms.ToolStripLabel
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtOC As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.PictureBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtParcialAnt As System.Windows.Forms.TextBox
    Friend WithEvents tspListadoCargaInt As System.Windows.Forms.ToolStrip
    Friend WithEvents gvItemParcial As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents NRPEMB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NORCML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRPARC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRITOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SBITOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDITES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QRLCSC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtParcialNuevo As Ransa.Utilitario.clsTextBoxNumero
End Class
