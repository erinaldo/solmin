<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPerfilOpciones
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
    Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPerfilOpciones))
    Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.dgvPerfilOpciones = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.CHK_OPCION = New System.Windows.Forms.DataGridViewCheckBoxColumn
    Me.MMCAPL = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.MMCMNU = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.MMCOPC = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.MMCUSR1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DES_APLC = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DES_MENU = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DES_OPCN = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.STSVIS = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.STSADI = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.STSCHG = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.STSELI = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.STSOP1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.STSOP2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.STSOP3 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
    Me.btncheck = New System.Windows.Forms.ToolStripButton
    Me.btnManBuscar = New System.Windows.Forms.ToolStripButton
    Me.btnManGuardar = New System.Windows.Forms.ToolStripButton
    Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.Uc_CboUsuario = New Ransa.Controls.Menu.uc_CboUsuario
    Me.Uc_CboMenu1 = New Ransa.Controls.Menu.uc_CboMenu
    Me.Uc_CboAplicacion1 = New Ransa.Controls.Menu.uc_CboAplicacion
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    CType(Me.dgvPerfilOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.ToolStrip1.SuspendLayout()
    CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonHeaderGroup1.Panel.SuspendLayout()
    Me.KryptonHeaderGroup1.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.dgvPerfilOpciones)
    Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
    Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(968, 520)
    Me.KryptonPanel.TabIndex = 0
    '
    'dgvPerfilOpciones
    '
    Me.dgvPerfilOpciones.AllowUserToAddRows = False
    Me.dgvPerfilOpciones.AllowUserToDeleteRows = False
    Me.dgvPerfilOpciones.AllowUserToResizeColumns = False
    Me.dgvPerfilOpciones.AllowUserToResizeRows = False
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dgvPerfilOpciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
    Me.dgvPerfilOpciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
    Me.dgvPerfilOpciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
    Me.dgvPerfilOpciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CHK_OPCION, Me.MMCAPL, Me.MMCMNU, Me.MMCOPC, Me.MMCUSR1, Me.DES_APLC, Me.DES_MENU, Me.DES_OPCN, Me.STSVIS, Me.STSADI, Me.STSCHG, Me.STSELI, Me.STSOP1, Me.STSOP2, Me.STSOP3})
    Me.dgvPerfilOpciones.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dgvPerfilOpciones.Location = New System.Drawing.Point(0, 77)
    Me.dgvPerfilOpciones.MultiSelect = False
    Me.dgvPerfilOpciones.Name = "dgvPerfilOpciones"
    Me.dgvPerfilOpciones.RowHeadersWidth = 10
    DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    Me.dgvPerfilOpciones.RowsDefaultCellStyle = DataGridViewCellStyle12
    Me.dgvPerfilOpciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvPerfilOpciones.Size = New System.Drawing.Size(968, 443)
    Me.dgvPerfilOpciones.StateCommon.Background.Color1 = System.Drawing.Color.White
    Me.dgvPerfilOpciones.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.dgvPerfilOpciones.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.SystemColors.WindowText
    Me.dgvPerfilOpciones.TabIndex = 76
    '
    'CHK_OPCION
    '
    Me.CHK_OPCION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.CHK_OPCION.HeaderText = "Check"
    Me.CHK_OPCION.Name = "CHK_OPCION"
    Me.CHK_OPCION.Width = 48
    '
    'MMCAPL
    '
    Me.MMCAPL.DataPropertyName = "MMCAPL"
    Me.MMCAPL.HeaderText = "MMCAPL"
    Me.MMCAPL.Name = "MMCAPL"
    Me.MMCAPL.ReadOnly = True
    Me.MMCAPL.Visible = False
    '
    'MMCMNU
    '
    Me.MMCMNU.DataPropertyName = "MMCMNU"
    Me.MMCMNU.HeaderText = "MMCMNU"
    Me.MMCMNU.Name = "MMCMNU"
    Me.MMCMNU.ReadOnly = True
    Me.MMCMNU.Visible = False
    '
    'MMCOPC
    '
    Me.MMCOPC.DataPropertyName = "MMCOPC"
    Me.MMCOPC.HeaderText = "MMCOPC"
    Me.MMCOPC.Name = "MMCOPC"
    Me.MMCOPC.ReadOnly = True
    Me.MMCOPC.Visible = False
    '
    'MMCUSR1
    '
    Me.MMCUSR1.DataPropertyName = "MMCUSR"
    Me.MMCUSR1.HeaderText = "MMCUSR"
    Me.MMCUSR1.Name = "MMCUSR1"
    Me.MMCUSR1.ReadOnly = True
    Me.MMCUSR1.Visible = False
    '
    'DES_APLC
    '
    Me.DES_APLC.DataPropertyName = "DES_APLC"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    Me.DES_APLC.DefaultCellStyle = DataGridViewCellStyle2
    Me.DES_APLC.HeaderText = "Aplicación"
    Me.DES_APLC.MinimumWidth = 200
    Me.DES_APLC.Name = "DES_APLC"
    Me.DES_APLC.ReadOnly = True
    '
    'DES_MENU
    '
    Me.DES_MENU.DataPropertyName = "DES_MENU"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    Me.DES_MENU.DefaultCellStyle = DataGridViewCellStyle3
    Me.DES_MENU.HeaderText = "Menú"
    Me.DES_MENU.MinimumWidth = 200
    Me.DES_MENU.Name = "DES_MENU"
    Me.DES_MENU.ReadOnly = True
    '
    'DES_OPCN
    '
    Me.DES_OPCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
    Me.DES_OPCN.DataPropertyName = "DES_OPCN"
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    Me.DES_OPCN.DefaultCellStyle = DataGridViewCellStyle4
    Me.DES_OPCN.HeaderText = "Opción"
    Me.DES_OPCN.MinimumWidth = 200
    Me.DES_OPCN.Name = "DES_OPCN"
    Me.DES_OPCN.ReadOnly = True
    Me.DES_OPCN.Width = 200
    '
    'STSVIS
    '
    Me.STSVIS.DataPropertyName = "STSVIS"
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.STSVIS.DefaultCellStyle = DataGridViewCellStyle5
    Me.STSVIS.HeaderText = "Visualizar"
    Me.STSVIS.MinimumWidth = 70
    Me.STSVIS.Name = "STSVIS"
    Me.STSVIS.ReadOnly = True
    '
    'STSADI
    '
    Me.STSADI.DataPropertyName = "STSADI"
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.STSADI.DefaultCellStyle = DataGridViewCellStyle6
    Me.STSADI.HeaderText = "Adicionar"
    Me.STSADI.MinimumWidth = 70
    Me.STSADI.Name = "STSADI"
    Me.STSADI.ReadOnly = True
    '
    'STSCHG
    '
    Me.STSCHG.DataPropertyName = "STSCHG"
    DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.STSCHG.DefaultCellStyle = DataGridViewCellStyle7
    Me.STSCHG.HeaderText = "Cambiar"
    Me.STSCHG.MinimumWidth = 70
    Me.STSCHG.Name = "STSCHG"
    Me.STSCHG.ReadOnly = True
    '
    'STSELI
    '
    Me.STSELI.DataPropertyName = "STSELI"
    DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.STSELI.DefaultCellStyle = DataGridViewCellStyle8
    Me.STSELI.HeaderText = "Eliminar"
    Me.STSELI.MinimumWidth = 70
    Me.STSELI.Name = "STSELI"
    Me.STSELI.ReadOnly = True
    '
    'STSOP1
    '
    Me.STSOP1.DataPropertyName = "STSOP1"
    DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.STSOP1.DefaultCellStyle = DataGridViewCellStyle9
    Me.STSOP1.HeaderText = "Opción 1"
    Me.STSOP1.MinimumWidth = 70
    Me.STSOP1.Name = "STSOP1"
    Me.STSOP1.ReadOnly = True
    '
    'STSOP2
    '
    Me.STSOP2.DataPropertyName = "STSOP2"
    DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.STSOP2.DefaultCellStyle = DataGridViewCellStyle10
    Me.STSOP2.HeaderText = "Opción 2"
    Me.STSOP2.MinimumWidth = 70
    Me.STSOP2.Name = "STSOP2"
    Me.STSOP2.ReadOnly = True
    '
    'STSOP3
    '
    Me.STSOP3.DataPropertyName = "STSOP3"
    DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.STSOP3.DefaultCellStyle = DataGridViewCellStyle11
    Me.STSOP3.HeaderText = "Opción 3"
    Me.STSOP3.MinimumWidth = 70
    Me.STSOP3.Name = "STSOP3"
    Me.STSOP3.ReadOnly = True
    '
    'ToolStrip1
    '
    Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btncheck, Me.btnManBuscar, Me.btnManGuardar})
    Me.ToolStrip1.Location = New System.Drawing.Point(0, 52)
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.Size = New System.Drawing.Size(968, 25)
    Me.ToolStrip1.TabIndex = 75
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
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Uc_CboMenu1)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Uc_CboAplicacion1)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel3)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel2)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
    Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(968, 52)
    Me.KryptonHeaderGroup1.TabIndex = 0
    Me.KryptonHeaderGroup1.Text = "Heading"
    Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
    Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Heading"
    Me.KryptonHeaderGroup1.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup1.ValuesPrimary.Image"), System.Drawing.Image)
    Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
    Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
    Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
    '
    'KryptonLabel3
    '
    Me.KryptonLabel3.Location = New System.Drawing.Point(650, 15)
    Me.KryptonLabel3.Name = "KryptonLabel3"
    Me.KryptonLabel3.Size = New System.Drawing.Size(45, 19)
    Me.KryptonLabel3.TabIndex = 67
    Me.KryptonLabel3.Text = "Menú :"
    Me.KryptonLabel3.Values.ExtraText = ""
    Me.KryptonLabel3.Values.Image = Nothing
    Me.KryptonLabel3.Values.Text = "Menú :"
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(332, 18)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(67, 19)
    Me.KryptonLabel2.TabIndex = 67
    Me.KryptonLabel2.Text = "Aplicación :"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "Aplicación :"
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(15, 18)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(91, 19)
    Me.KryptonLabel1.TabIndex = 67
    Me.KryptonLabel1.Text = "Usuario Origen :"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Usuario Origen :"
    '
    'Uc_CboUsuario
    '
    Me.Uc_CboUsuario.Location = New System.Drawing.Point(112, 15)
    Me.Uc_CboUsuario.Name = "Uc_CboUsuario"
    Me.Uc_CboUsuario.pPSMMCUSR = ""
    Me.Uc_CboUsuario.pPSMMNUSR = ""
    Me.Uc_CboUsuario.Size = New System.Drawing.Size(201, 22)
    Me.Uc_CboUsuario.TabIndex = 0
    '
    'Uc_CboMenu1
    '
    Me.Uc_CboMenu1.Location = New System.Drawing.Point(701, 12)
    Me.Uc_CboMenu1.Name = "Uc_CboMenu1"
    Me.Uc_CboMenu1.pPSMMCAPL = ""
    Me.Uc_CboMenu1.Size = New System.Drawing.Size(237, 22)
    Me.Uc_CboMenu1.TabIndex = 2
    '
    'Uc_CboAplicacion1
    '
    Me.Uc_CboAplicacion1.Location = New System.Drawing.Point(405, 15)
    Me.Uc_CboAplicacion1.Name = "Uc_CboAplicacion1"
    Me.Uc_CboAplicacion1.Size = New System.Drawing.Size(232, 22)
    Me.Uc_CboAplicacion1.TabIndex = 1
    '
    'FrmPerfilOpciones
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(968, 520)
    Me.Controls.Add(Me.KryptonPanel)
    Me.Name = "FrmPerfilOpciones"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Perfil Opciones"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    Me.KryptonPanel.PerformLayout()
    CType(Me.dgvPerfilOpciones, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents Uc_CboMenu1 As Ransa.Controls.Menu.uc_CboMenu
  Friend WithEvents Uc_CboAplicacion1 As Ransa.Controls.Menu.uc_CboAplicacion
  Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents dgvPerfilOpciones As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents CHK_OPCION As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents MMCAPL As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents MMCMNU As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents MMCOPC As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents MMCUSR1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DES_APLC As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DES_MENU As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DES_OPCN As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents STSVIS As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents STSADI As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents STSCHG As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents STSELI As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents STSOP1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents STSOP2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents STSOP3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
  Friend WithEvents btncheck As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnManBuscar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnManGuardar As System.Windows.Forms.ToolStripButton
  Friend WithEvents Uc_CboUsuario As Ransa.Controls.Menu.uc_CboUsuario
End Class
