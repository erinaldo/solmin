<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedorAsignado
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
        Me.gwdDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.CCMPN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRUCTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMTRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CTRSPT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SINDRC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SINDRC_S = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnConsultar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.txtRazonSocial = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtRUC = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFiltros.Panel.SuspendLayout()
        Me.PanelFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.gwdDatos)
        Me.KryptonPanel.Controls.Add(Me.PanelFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(705, 456)
        Me.KryptonPanel.TabIndex = 0
        '
        'gwdDatos
        '
        Me.gwdDatos.AllowUserToAddRows = False
        Me.gwdDatos.AllowUserToDeleteRows = False
        Me.gwdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gwdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gwdDatos.ColumnHeadersHeight = 30
        Me.gwdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gwdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CCMPN, Me.NRUCTR, Me.TCMTRT, Me.CTRSPT, Me.SINDRC, Me.SINDRC_S, Me.Column1})
        Me.gwdDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gwdDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.gwdDatos.Location = New System.Drawing.Point(0, 100)
        Me.gwdDatos.MultiSelect = False
        Me.gwdDatos.Name = "gwdDatos"
        Me.gwdDatos.ReadOnly = True
        Me.gwdDatos.RowHeadersWidth = 20
        Me.gwdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.gwdDatos.RowTemplate.Height = 20
        Me.gwdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gwdDatos.Size = New System.Drawing.Size(705, 356)
        Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwdDatos.TabIndex = 3
        '
        'CCMPN
        '
        Me.CCMPN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CCMPN.DataPropertyName = "CCMPN"
        Me.CCMPN.HeaderText = "CCMPN"
        Me.CCMPN.Name = "CCMPN"
        Me.CCMPN.ReadOnly = True
        Me.CCMPN.Visible = False
        Me.CCMPN.Width = 79
        '
        'NRUCTR
        '
        Me.NRUCTR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRUCTR.DataPropertyName = "NRUCTR"
        Me.NRUCTR.HeaderText = "RUC"
        Me.NRUCTR.Name = "NRUCTR"
        Me.NRUCTR.ReadOnly = True
        Me.NRUCTR.Width = 59
        '
        'TCMTRT
        '
        Me.TCMTRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCMTRT.DataPropertyName = "TCMTRT"
        Me.TCMTRT.HeaderText = "Razón Social"
        Me.TCMTRT.Name = "TCMTRT"
        Me.TCMTRT.ReadOnly = True
        Me.TCMTRT.Width = 102
        '
        'CTRSPT
        '
        Me.CTRSPT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CTRSPT.DataPropertyName = "CTRSPT"
        Me.CTRSPT.HeaderText = "Código RNS"
        Me.CTRSPT.Name = "CTRSPT"
        Me.CTRSPT.ReadOnly = True
        '
        'SINDRC
        '
        Me.SINDRC.HeaderText = "SINDRC"
        Me.SINDRC.Name = "SINDRC"
        Me.SINDRC.ReadOnly = True
        Me.SINDRC.Visible = False
        '
        'SINDRC_S
        '
        Me.SINDRC_S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SINDRC_S.DataPropertyName = "SINDRC_S"
        Me.SINDRC_S.HeaderText = "Tipo"
        Me.SINDRC_S.Name = "SINDRC_S"
        Me.SINDRC_S.ReadOnly = True
        Me.SINDRC_S.Width = 60
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = " "
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'PanelFiltros
        '
        Me.PanelFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnAceptar, Me.btnConsultar})
        Me.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFiltros.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.PanelFiltros.HeaderVisiblePrimary = False
        Me.PanelFiltros.Location = New System.Drawing.Point(0, 0)
        Me.PanelFiltros.Name = "PanelFiltros"
        '
        'PanelFiltros.Panel
        '
        Me.PanelFiltros.Panel.Controls.Add(Me.txtRazonSocial)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.PanelFiltros.Panel.Controls.Add(Me.txtRUC)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel7)
        Me.PanelFiltros.Size = New System.Drawing.Size(705, 100)
        Me.PanelFiltros.TabIndex = 2
        Me.PanelFiltros.Text = "TRACTOS"
        Me.PanelFiltros.ValuesPrimary.Description = ""
        Me.PanelFiltros.ValuesPrimary.Heading = "TRACTOS"
        Me.PanelFiltros.ValuesPrimary.Image = Nothing
        Me.PanelFiltros.ValuesSecondary.Description = ""
        Me.PanelFiltros.ValuesSecondary.Heading = ""
        Me.PanelFiltros.ValuesSecondary.Image = Nothing
        '
        'btnAceptar
        '
        Me.btnAceptar.ExtraText = ""
        Me.btnAceptar.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnAceptar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnAceptar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.ToolTipImage = Nothing
        Me.btnAceptar.UniqueName = "FF7E6E5B1D5E460CFF7E6E5B1D5E460C"
        '
        'btnConsultar
        '
        Me.btnConsultar.ExtraText = ""
        Me.btnConsultar.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnConsultar.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.btnConsultar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnConsultar.Text = "Buscar"
        Me.btnConsultar.ToolTipImage = Nothing
        Me.btnConsultar.UniqueName = "1C2A7D5FDF6E451A1C2A7D5FDF6E451A"
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Location = New System.Drawing.Point(107, 39)
        Me.txtRazonSocial.MaxLength = 40
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(252, 22)
        Me.txtRazonSocial.TabIndex = 137
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(19, 41)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(79, 20)
        Me.KryptonLabel1.TabIndex = 136
        Me.KryptonLabel1.Text = "Razón Social"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Razón Social"
        '
        'txtRUC
        '
        Me.txtRUC.Location = New System.Drawing.Point(107, 13)
        Me.txtRUC.MaxLength = 15
        Me.txtRUC.Name = "txtRUC"
        Me.txtRUC.Size = New System.Drawing.Size(132, 22)
        Me.txtRUC.TabIndex = 135
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(19, 13)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(34, 20)
        Me.KryptonLabel7.TabIndex = 134
        Me.KryptonLabel7.Text = "RUC"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "RUC"
        '
        'frmProveedorAsignado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 456)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmProveedorAsignado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proveedor Asignados"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.Panel.ResumeLayout(False)
        Me.PanelFiltros.Panel.PerformLayout()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.ResumeLayout(False)
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
    Friend WithEvents PanelFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnConsultar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents txtRazonSocial As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtRUC As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents gwdDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents CCMPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRUCTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMTRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTRSPT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SINDRC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SINDRC_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
