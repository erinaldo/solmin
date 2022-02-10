<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarCentroCosto
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
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dgvCentroCostos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cboTipo = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.cboSede = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.cboSector = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.cboUnid = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.cboMacro = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtCodCeCoSAP = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtCodigo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCodigo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.COD_CECO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CODSAP_CECO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DESC_CECO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.COD_CEBE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CODSAP_CEBE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DESC_CEBE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CECO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CEBE = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgvCentroCostos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgvCentroCostos)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Controls.Add(Me.Panel1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(618, 577)
        Me.KryptonPanel.TabIndex = 0
        '
        'dgvCentroCostos
        '
        Me.dgvCentroCostos.AllowUserToAddRows = False
        Me.dgvCentroCostos.AllowUserToDeleteRows = False
        Me.dgvCentroCostos.AllowUserToOrderColumns = True
        Me.dgvCentroCostos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCentroCostos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COD_CECO, Me.CODSAP_CECO, Me.DESC_CECO, Me.COD_CEBE, Me.CODSAP_CEBE, Me.DESC_CEBE, Me.CECO, Me.CEBE})
        Me.dgvCentroCostos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCentroCostos.Location = New System.Drawing.Point(0, 197)
        Me.dgvCentroCostos.Name = "dgvCentroCostos"
        Me.dgvCentroCostos.ReadOnly = True
        Me.dgvCentroCostos.Size = New System.Drawing.Size(618, 380)
        Me.dgvCentroCostos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvCentroCostos.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 172)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(618, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnBuscar
        '
        Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar.Image = Global.SOLMIN_CT.My.Resources.Resources.search
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(62, 22)
        Me.btnBuscar.Text = "Buscar"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.cboTipo)
        Me.Panel1.Controls.Add(Me.cboSede)
        Me.Panel1.Controls.Add(Me.cboSector)
        Me.Panel1.Controls.Add(Me.cboUnid)
        Me.Panel1.Controls.Add(Me.cboMacro)
        Me.Panel1.Controls.Add(Me.KryptonLabel7)
        Me.Panel1.Controls.Add(Me.KryptonLabel6)
        Me.Panel1.Controls.Add(Me.KryptonLabel5)
        Me.Panel1.Controls.Add(Me.KryptonLabel4)
        Me.Panel1.Controls.Add(Me.KryptonLabel1)
        Me.Panel1.Controls.Add(Me.txtDescripcion)
        Me.Panel1.Controls.Add(Me.txtCodCeCoSAP)
        Me.Panel1.Controls.Add(Me.txtCodigo)
        Me.Panel1.Controls.Add(Me.KryptonLabel3)
        Me.Panel1.Controls.Add(Me.KryptonLabel2)
        Me.Panel1.Controls.Add(Me.lblCodigo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(618, 172)
        Me.Panel1.TabIndex = 0
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.DropDownWidth = 167
        Me.cboTipo.FormattingEnabled = False
        Me.cboTipo.ItemHeight = 15
        Me.cboTipo.Location = New System.Drawing.Point(474, 77)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(132, 23)
        Me.cboTipo.TabIndex = 21
        '
        'cboSede
        '
        Me.cboSede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSede.DropDownWidth = 167
        Me.cboSede.FormattingEnabled = False
        Me.cboSede.ItemHeight = 15
        Me.cboSede.Location = New System.Drawing.Point(474, 51)
        Me.cboSede.Name = "cboSede"
        Me.cboSede.Size = New System.Drawing.Size(132, 23)
        Me.cboSede.TabIndex = 20
        '
        'cboSector
        '
        Me.cboSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSector.DropDownWidth = 167
        Me.cboSector.FormattingEnabled = False
        Me.cboSector.ItemHeight = 15
        Me.cboSector.Location = New System.Drawing.Point(97, 74)
        Me.cboSector.Name = "cboSector"
        Me.cboSector.Size = New System.Drawing.Size(338, 23)
        Me.cboSector.TabIndex = 19
        '
        'cboUnid
        '
        Me.cboUnid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnid.DropDownWidth = 167
        Me.cboUnid.FormattingEnabled = False
        Me.cboUnid.ItemHeight = 15
        Me.cboUnid.Location = New System.Drawing.Point(97, 45)
        Me.cboUnid.Name = "cboUnid"
        Me.cboUnid.Size = New System.Drawing.Size(338, 23)
        Me.cboUnid.TabIndex = 18
        '
        'cboMacro
        '
        Me.cboMacro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMacro.DropDownWidth = 167
        Me.cboMacro.FormattingEnabled = False
        Me.cboMacro.ItemHeight = 15
        Me.cboMacro.Location = New System.Drawing.Point(97, 16)
        Me.cboMacro.Name = "cboMacro"
        Me.cboMacro.Size = New System.Drawing.Size(338, 23)
        Me.cboMacro.TabIndex = 17
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(2, 16)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(90, 20)
        Me.KryptonLabel7.TabIndex = 11
        Me.KryptonLabel7.Text = "MacroServicio:"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "MacroServicio:"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(1, 48)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(90, 20)
        Me.KryptonLabel6.TabIndex = 10
        Me.KryptonLabel6.Text = "Unid. Product.:"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Unid. Product.:"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(3, 77)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(48, 20)
        Me.KryptonLabel5.TabIndex = 9
        Me.KryptonLabel5.Text = "Sector:"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Sector:"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(438, 77)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(37, 20)
        Me.KryptonLabel4.TabIndex = 8
        Me.KryptonLabel4.Text = "Tipo:"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Tipo:"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(438, 51)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(40, 20)
        Me.KryptonLabel1.TabIndex = 7
        Me.KryptonLabel1.Text = "Sede:"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Sede:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(97, 134)
        Me.txtDescripcion.MaxLength = 35
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(509, 22)
        Me.txtDescripcion.TabIndex = 6
        '
        'txtCodCeCoSAP
        '
        Me.txtCodCeCoSAP.Location = New System.Drawing.Point(440, 106)
        Me.txtCodCeCoSAP.MaxLength = 10
        Me.txtCodCeCoSAP.Name = "txtCodCeCoSAP"
        Me.txtCodCeCoSAP.Size = New System.Drawing.Size(166, 22)
        Me.txtCodCeCoSAP.TabIndex = 4
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(97, 106)
        Me.txtCodigo.MaxLength = 6
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(145, 22)
        Me.txtCodigo.TabIndex = 2
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(368, 108)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(67, 20)
        Me.KryptonLabel3.TabIndex = 3
        Me.KryptonLabel3.Text = "CeCo SAP:"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "CeCo SAP:"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(3, 134)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(77, 20)
        Me.KryptonLabel2.TabIndex = 5
        Me.KryptonLabel2.Text = "Descripción:"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Descripción:"
        '
        'lblCodigo
        '
        Me.lblCodigo.Location = New System.Drawing.Point(3, 108)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(68, 20)
        Me.lblCodigo.TabIndex = 1
        Me.lblCodigo.Text = "Cód CeCo:"
        Me.lblCodigo.Values.ExtraText = ""
        Me.lblCodigo.Values.Image = Nothing
        Me.lblCodigo.Values.Text = "Cód CeCo:"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "COD_CECO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cód CeCo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 90
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DESC_CECO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 87
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CODSAP_CECO"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cod Ceco SAP"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 119
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "COD_CEBE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cod Cebe"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 82
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DESC_CEBE"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Desc Cebe"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 81
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DESC_CEBE"
        Me.DataGridViewTextBoxColumn6.HeaderText = ""
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CECO"
        Me.DataGridViewTextBoxColumn7.HeaderText = "CECO"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CEBE"
        Me.DataGridViewTextBoxColumn8.HeaderText = "CEBE"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'COD_CECO
        '
        Me.COD_CECO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.COD_CECO.DataPropertyName = "COD_CECO"
        Me.COD_CECO.HeaderText = "Cód CeCo"
        Me.COD_CECO.Name = "COD_CECO"
        Me.COD_CECO.ReadOnly = True
        Me.COD_CECO.Width = 90
        '
        'CODSAP_CECO
        '
        Me.CODSAP_CECO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CODSAP_CECO.DataPropertyName = "CODSAP_CECO"
        Me.CODSAP_CECO.HeaderText = "Ceco SAP"
        Me.CODSAP_CECO.Name = "CODSAP_CECO"
        Me.CODSAP_CECO.ReadOnly = True
        Me.CODSAP_CECO.Width = 87
        '
        'DESC_CECO
        '
        Me.DESC_CECO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DESC_CECO.DataPropertyName = "DESC_CECO"
        Me.DESC_CECO.HeaderText = "Descripción CeCo"
        Me.DESC_CECO.Name = "DESC_CECO"
        Me.DESC_CECO.ReadOnly = True
        Me.DESC_CECO.Width = 119
        '
        'COD_CEBE
        '
        Me.COD_CEBE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.COD_CEBE.DataPropertyName = "COD_CEBE"
        Me.COD_CEBE.HeaderText = "Cod CeBe"
        Me.COD_CEBE.Name = "COD_CEBE"
        Me.COD_CEBE.ReadOnly = True
        Me.COD_CEBE.Width = 82
        '
        'CODSAP_CEBE
        '
        Me.CODSAP_CEBE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CODSAP_CEBE.DataPropertyName = "CODSAP_CEBE"
        Me.CODSAP_CEBE.HeaderText = "CeBe SAP"
        Me.CODSAP_CEBE.Name = "CODSAP_CEBE"
        Me.CODSAP_CEBE.ReadOnly = True
        Me.CODSAP_CEBE.Width = 81
        '
        'DESC_CEBE
        '
        Me.DESC_CEBE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DESC_CEBE.DataPropertyName = "DESC_CEBE"
        Me.DESC_CEBE.HeaderText = "Descripción CeBe"
        Me.DESC_CEBE.Name = "DESC_CEBE"
        Me.DESC_CEBE.ReadOnly = True
        Me.DESC_CEBE.Width = 118
        '
        'CECO
        '
        Me.CECO.DataPropertyName = "CECO"
        Me.CECO.HeaderText = "CECO"
        Me.CECO.Name = "CECO"
        Me.CECO.ReadOnly = True
        Me.CECO.Visible = False
        '
        'CEBE
        '
        Me.CEBE.DataPropertyName = "CEBE"
        Me.CEBE.HeaderText = "CEBE"
        Me.CEBE.Name = "CEBE"
        Me.CEBE.ReadOnly = True
        Me.CEBE.Visible = False
        '
        'frmBuscarCentroCosto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 577)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBuscarCentroCosto"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Búsqueda Centro de Costos"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dgvCentroCostos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCodigo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDescripcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCodCeCoSAP As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCodigo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvCentroCostos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboTipo As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents cboSede As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents cboSector As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents cboUnid As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents cboMacro As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COD_CECO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODSAP_CECO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESC_CECO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COD_CEBE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODSAP_CEBE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESC_CEBE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CECO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CEBE As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
