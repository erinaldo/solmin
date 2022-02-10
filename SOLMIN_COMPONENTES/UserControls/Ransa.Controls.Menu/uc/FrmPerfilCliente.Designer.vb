<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPerfilCliente
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
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPerfilCliente))
    Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.dgvPerfilCliente = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.MMCUSR2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CHK_CLIENTE = New System.Windows.Forms.DataGridViewCheckBoxColumn
    Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CPLNDV = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.TCMPCL = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.TRFRCL = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CINTER = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.TPLNTA = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
    Me.btncheck = New System.Windows.Forms.ToolStripButton
    Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
    Me.btnManBuscar = New System.Windows.Forms.ToolStripButton
    Me.btnManGuardar = New System.Windows.Forms.ToolStripButton
    Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.Uc_CboUsuario = New Ransa.Controls.Menu.uc_CboUsuario
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    CType(Me.dgvPerfilCliente, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.ToolStrip1.SuspendLayout()
    CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonHeaderGroup1.Panel.SuspendLayout()
    Me.KryptonHeaderGroup1.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.dgvPerfilCliente)
    Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
    Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(761, 515)
    Me.KryptonPanel.TabIndex = 0
    '
    'dgvPerfilCliente
    '
    Me.dgvPerfilCliente.AllowUserToAddRows = False
    Me.dgvPerfilCliente.AllowUserToDeleteRows = False
    Me.dgvPerfilCliente.AllowUserToResizeColumns = False
    Me.dgvPerfilCliente.AllowUserToResizeRows = False
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dgvPerfilCliente.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
    Me.dgvPerfilCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
    Me.dgvPerfilCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
    Me.dgvPerfilCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MMCUSR2, Me.CHK_CLIENTE, Me.CCLNT, Me.CPLNDV, Me.TCMPCL, Me.TRFRCL, Me.CINTER, Me.TPLNTA})
    Me.dgvPerfilCliente.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dgvPerfilCliente.Location = New System.Drawing.Point(0, 71)
    Me.dgvPerfilCliente.MultiSelect = False
    Me.dgvPerfilCliente.Name = "dgvPerfilCliente"
    Me.dgvPerfilCliente.RowHeadersWidth = 10
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    Me.dgvPerfilCliente.RowsDefaultCellStyle = DataGridViewCellStyle2
    Me.dgvPerfilCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvPerfilCliente.Size = New System.Drawing.Size(761, 444)
    Me.dgvPerfilCliente.StateCommon.Background.Color1 = System.Drawing.Color.White
    Me.dgvPerfilCliente.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.dgvPerfilCliente.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.SystemColors.WindowText
    Me.dgvPerfilCliente.TabIndex = 78
    '
    'MMCUSR2
    '
    Me.MMCUSR2.DataPropertyName = "MMCUSR"
    Me.MMCUSR2.HeaderText = "MMCUSR"
    Me.MMCUSR2.Name = "MMCUSR2"
    Me.MMCUSR2.ReadOnly = True
    Me.MMCUSR2.Visible = False
    '
    'CHK_CLIENTE
    '
    Me.CHK_CLIENTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.CHK_CLIENTE.HeaderText = "Check"
    Me.CHK_CLIENTE.MinimumWidth = 50
    Me.CHK_CLIENTE.Name = "CHK_CLIENTE"
    Me.CHK_CLIENTE.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.CHK_CLIENTE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.CHK_CLIENTE.Width = 67
    '
    'CCLNT
    '
    Me.CCLNT.DataPropertyName = "CCLNT"
    Me.CCLNT.HeaderText = "Código"
    Me.CCLNT.MinimumWidth = 80
    Me.CCLNT.Name = "CCLNT"
    Me.CCLNT.ReadOnly = True
    '
    'CPLNDV
    '
    Me.CPLNDV.DataPropertyName = "CPLNDV"
    Me.CPLNDV.HeaderText = "CPLNDV"
    Me.CPLNDV.Name = "CPLNDV"
    Me.CPLNDV.ReadOnly = True
    Me.CPLNDV.Visible = False
    '
    'TCMPCL
    '
    Me.TCMPCL.DataPropertyName = "TCMPCL"
    Me.TCMPCL.HeaderText = "Descripción"
    Me.TCMPCL.MinimumWidth = 200
    Me.TCMPCL.Name = "TCMPCL"
    Me.TCMPCL.ReadOnly = True
    '
    'TRFRCL
    '
    Me.TRFRCL.DataPropertyName = "TRFRCL"
    Me.TRFRCL.HeaderText = "Referencia"
    Me.TRFRCL.MinimumWidth = 200
    Me.TRFRCL.Name = "TRFRCL"
    Me.TRFRCL.ReadOnly = True
    '
    'CINTER
    '
    Me.CINTER.DataPropertyName = "CINTER"
    Me.CINTER.HeaderText = "Código Interno"
    Me.CINTER.MinimumWidth = 150
    Me.CINTER.Name = "CINTER"
    Me.CINTER.ReadOnly = True
    '
    'TPLNTA
    '
    Me.TPLNTA.DataPropertyName = "TPLNTA"
    Me.TPLNTA.HeaderText = "Planta"
    Me.TPLNTA.MinimumWidth = 80
    Me.TPLNTA.Name = "TPLNTA"
    Me.TPLNTA.ReadOnly = True
    '
    'ToolStrip1
    '
    Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btncheck, Me.ToolStripLabel1, Me.btnManBuscar, Me.btnManGuardar})
    Me.ToolStrip1.Location = New System.Drawing.Point(0, 46)
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.Size = New System.Drawing.Size(761, 25)
    Me.ToolStrip1.TabIndex = 77
    Me.ToolStrip1.Text = "ToolStrip1"
    '
    'btncheck
    '
    Me.btncheck.Image = Global.Ransa.Controls.Menu.My.Resources.Resources.btnNoMarcarItems
    Me.btncheck.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btncheck.Name = "btncheck"
    Me.btncheck.Size = New System.Drawing.Size(92, 22)
    Me.btncheck.Text = "Check Todos"
    '
    'ToolStripLabel1
    '
    Me.ToolStripLabel1.Name = "ToolStripLabel1"
    Me.ToolStripLabel1.Size = New System.Drawing.Size(50, 22)
    Me.ToolStripLabel1.Text = " Accesos"
    '
    'btnManBuscar
    '
    Me.btnManBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnManBuscar.Image = CType(resources.GetObject("btnManBuscar.Image"), System.Drawing.Image)
    Me.btnManBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnManBuscar.Name = "btnManBuscar"
    Me.btnManBuscar.Size = New System.Drawing.Size(61, 22)
    Me.btnManBuscar.Text = "Buscar"
    '
    'btnManGuardar
    '
    Me.btnManGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnManGuardar.Image = CType(resources.GetObject("btnManGuardar.Image"), System.Drawing.Image)
    Me.btnManGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnManGuardar.Name = "btnManGuardar"
    Me.btnManGuardar.Size = New System.Drawing.Size(69, 22)
    Me.btnManGuardar.Text = "Guardar"
    '
    'KryptonHeaderGroup1
    '
    Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
    Me.KryptonHeaderGroup1.HeaderVisiblePrimary = False
    Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
    Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
    Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
    '
    'KryptonHeaderGroup1.Panel
    '
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Uc_CboUsuario)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
    Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(761, 46)
    Me.KryptonHeaderGroup1.TabIndex = 0
    Me.KryptonHeaderGroup1.Text = "Heading"
    Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
    Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Heading"
    Me.KryptonHeaderGroup1.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup1.ValuesPrimary.Image"), System.Drawing.Image)
    Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
    Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
    Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(11, 13)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(91, 19)
    Me.KryptonLabel1.TabIndex = 0
    Me.KryptonLabel1.Text = "Usuario Origen :"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Usuario Origen :"
    '
    'Uc_CboUsuario
    '
    Me.Uc_CboUsuario.Location = New System.Drawing.Point(108, 11)
    Me.Uc_CboUsuario.Name = "Uc_CboUsuario"
    Me.Uc_CboUsuario.pPSMMCUSR = ""
    Me.Uc_CboUsuario.pPSMMNUSR = ""
    Me.Uc_CboUsuario.Size = New System.Drawing.Size(257, 22)
    Me.Uc_CboUsuario.TabIndex = 1
    '
    'FrmPerfilCliente
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(761, 515)
    Me.Controls.Add(Me.KryptonPanel)
    Me.Name = "FrmPerfilCliente"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Perfil Cliente"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    Me.KryptonPanel.PerformLayout()
    CType(Me.dgvPerfilCliente, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
  Friend WithEvents btncheck As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents btnManBuscar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnManGuardar As System.Windows.Forms.ToolStripButton
  Friend WithEvents dgvPerfilCliente As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents MMCUSR2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CHK_CLIENTE As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CPLNDV As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TCMPCL As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TRFRCL As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CINTER As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TPLNTA As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Uc_CboUsuario As Ransa.Controls.Menu.uc_CboUsuario
End Class
