<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddCheckCliente
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
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dtgCheckpoint = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        Me.btnCheck = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.cmbCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.cmbTipoCheck = New System.Windows.Forms.ComboBox
        Me.lblTipoCheck = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CHK_COLUMNA = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.NESTDO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CEMB = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TIPO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CHECPOINT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCOLUM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NPRESENTACION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCMPN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CDVSN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dtgCheckpoint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dtgCheckpoint)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(790, 521)
        Me.KryptonPanel.TabIndex = 0
        '
        'dtgCheckpoint
        '
        Me.dtgCheckpoint.AllowUserToAddRows = False
        Me.dtgCheckpoint.AllowUserToDeleteRows = False
        Me.dtgCheckpoint.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CHK_COLUMNA, Me.NESTDO, Me.CEMB, Me.TIPO, Me.CHECPOINT, Me.SESTRG, Me.TCOLUM, Me.NPRESENTACION, Me.CCMPN, Me.CDVSN, Me.CCLNT})
        Me.dtgCheckpoint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgCheckpoint.Location = New System.Drawing.Point(0, 87)
        Me.dtgCheckpoint.Name = "dtgCheckpoint"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dtgCheckpoint.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgCheckpoint.Size = New System.Drawing.Size(790, 434)
        Me.dtgCheckpoint.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dtgCheckpoint.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgCheckpoint.TabIndex = 41
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnGuardar, Me.btnCheck, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 62)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(790, 25)
        Me.ToolStrip1.TabIndex = 39
        '
        'btnBuscar
        '
        Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar.Image = Global.SOLMIN_SC.My.Resources.Resources.search
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(61, 22)
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.ToolTipText = "Buscar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGuardar.Image = Global.SOLMIN_SC.My.Resources.Resources.db_add
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(69, 22)
        Me.btnGuardar.Text = "Guardar"
        '
        'btnCheck
        '
        Me.btnCheck.Image = Global.SOLMIN_SC.My.Resources.Resources.btnNoMarcarItems
        Me.btnCheck.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(92, 22)
        Me.btnCheck.Text = "Check Todos"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(84, 22)
        Me.ToolStripLabel2.Tag = "CheckPoint"
        Me.ToolStripLabel2.Text = "   CheckPoint"
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.AutoSize = True
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.AutoScroll = True
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbCliente)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbTipoCheck)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblTipoCheck)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCliente)
        Me.KryptonHeaderGroup1.Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(790, 62)
        Me.KryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.TabIndex = 38
        Me.KryptonHeaderGroup1.Text = "Filtros"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Filtros"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'cmbCliente
        '
        Me.cmbCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmbCliente.BackColor = System.Drawing.Color.Transparent
        Me.cmbCliente.CCMPN = "EZ"
        Me.cmbCliente.Location = New System.Drawing.Point(64, 8)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.pAccesoPorUsuario = False
        Me.cmbCliente.pRequerido = False
        Me.cmbCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.cmbCliente.Size = New System.Drawing.Size(320, 21)
        Me.cmbCliente.TabIndex = 44
        '
        'cmbTipoCheck
        '
        Me.cmbTipoCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbTipoCheck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoCheck.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoCheck.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cmbTipoCheck.FormattingEnabled = True
        Me.cmbTipoCheck.Location = New System.Drawing.Point(518, 10)
        Me.cmbTipoCheck.Name = "cmbTipoCheck"
        Me.cmbTipoCheck.Size = New System.Drawing.Size(139, 22)
        Me.cmbTipoCheck.TabIndex = 25
        '
        'lblTipoCheck
        '
        Me.lblTipoCheck.Location = New System.Drawing.Point(399, 10)
        Me.lblTipoCheck.Name = "lblTipoCheck"
        Me.lblTipoCheck.Size = New System.Drawing.Size(113, 19)
        Me.lblTipoCheck.TabIndex = 33
        Me.lblTipoCheck.Text = "Tipo de Checkpoint :"
        Me.lblTipoCheck.Values.ExtraText = ""
        Me.lblTipoCheck.Values.Image = Nothing
        Me.lblTipoCheck.Values.Text = "Tipo de Checkpoint :"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(8, 8)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(50, 19)
        Me.lblCliente.TabIndex = 12
        Me.lblCliente.Text = "Cliente :"
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente :"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NESTDO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CEMB"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CEMB"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NOMVAR"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TDESES"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Checkpoints"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ASIGNADO"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Estado Checkpoint"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TCOLUM"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Nombre en el Seguimiento"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "SESTRG"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Mostrar en el Seguimiento"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "NSEPRE"
        Me.DataGridViewTextBoxColumn8.HeaderText = "N° Presentación"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "CCMPN"
        Me.DataGridViewTextBoxColumn9.HeaderText = "CCMPN"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CDVSN"
        Me.DataGridViewTextBoxColumn10.HeaderText = "CDVSN"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "CCLNT"
        Me.DataGridViewTextBoxColumn11.HeaderText = " CCLNT"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'CHK_COLUMNA
        '
        Me.CHK_COLUMNA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CHK_COLUMNA.HeaderText = "Chk"
        Me.CHK_COLUMNA.Name = "CHK_COLUMNA"
        Me.CHK_COLUMNA.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CHK_COLUMNA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CHK_COLUMNA.Width = 56
        '
        'NESTDO
        '
        Me.NESTDO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NESTDO.DataPropertyName = "NESTDO"
        Me.NESTDO.HeaderText = "Código"
        Me.NESTDO.Name = "NESTDO"
        Me.NESTDO.ReadOnly = True
        Me.NESTDO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NESTDO.Width = 55
        '
        'CEMB
        '
        Me.CEMB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CEMB.DataPropertyName = "CEMB"
        Me.CEMB.HeaderText = "CEMB"
        Me.CEMB.Name = "CEMB"
        Me.CEMB.ReadOnly = True
        Me.CEMB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CEMB.Visible = False
        Me.CEMB.Width = 47
        '
        'TIPO
        '
        Me.TIPO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TIPO.DataPropertyName = "NOMVAR"
        Me.TIPO.HeaderText = "Tipo"
        Me.TIPO.Name = "TIPO"
        Me.TIPO.ReadOnly = True
        Me.TIPO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TIPO.Width = 39
        '
        'CHECPOINT
        '
        Me.CHECPOINT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CHECPOINT.DataPropertyName = "TDESES"
        Me.CHECPOINT.HeaderText = "Checkpoints"
        Me.CHECPOINT.Name = "CHECPOINT"
        Me.CHECPOINT.ReadOnly = True
        Me.CHECPOINT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CHECPOINT.Width = 81
        '
        'SESTRG
        '
        Me.SESTRG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SESTRG.DataPropertyName = "ASIGNADO"
        Me.SESTRG.HeaderText = "Estado Checkpoint"
        Me.SESTRG.Name = "SESTRG"
        Me.SESTRG.ReadOnly = True
        Me.SESTRG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SESTRG.Visible = False
        Me.SESTRG.Width = 114
        '
        'TCOLUM
        '
        Me.TCOLUM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCOLUM.DataPropertyName = "TCOLUM"
        Me.TCOLUM.HeaderText = "Nombre en el Seguimiento"
        Me.TCOLUM.Name = "TCOLUM"
        Me.TCOLUM.ReadOnly = True
        Me.TCOLUM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TCOLUM.Width = 154
        '
        'NPRESENTACION
        '
        Me.NPRESENTACION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NPRESENTACION.DataPropertyName = "NSEPRE"
        Me.NPRESENTACION.HeaderText = "N° Presentación"
        Me.NPRESENTACION.Name = "NPRESENTACION"
        Me.NPRESENTACION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NPRESENTACION.Width = 98
        '
        'CCMPN
        '
        Me.CCMPN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CCMPN.DataPropertyName = "CCMPN"
        Me.CCMPN.HeaderText = "CCMPN"
        Me.CCMPN.Name = "CCMPN"
        Me.CCMPN.ReadOnly = True
        Me.CCMPN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CCMPN.Visible = False
        Me.CCMPN.Width = 55
        '
        'CDVSN
        '
        Me.CDVSN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CDVSN.DataPropertyName = "CDVSN"
        Me.CDVSN.HeaderText = "CDVSN"
        Me.CDVSN.Name = "CDVSN"
        Me.CDVSN.ReadOnly = True
        Me.CDVSN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CDVSN.Visible = False
        Me.CDVSN.Width = 53
        '
        'CCLNT
        '
        Me.CCLNT.DataPropertyName = "CCLNT"
        Me.CCLNT.HeaderText = " CCLNT"
        Me.CCLNT.Name = "CCLNT"
        Me.CCLNT.ReadOnly = True
        Me.CCLNT.Visible = False
        '
        'FrmAddCheckCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 521)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "FrmAddCheckCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Check Point Asignación"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dtgCheckpoint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
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
    Friend WithEvents dtgCheckpoint As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents cmbCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents cmbTipoCheck As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoCheck As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCheck As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CHK_COLUMNA As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NESTDO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CEMB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CHECPOINT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCOLUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPRESENTACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCMPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CDVSN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
