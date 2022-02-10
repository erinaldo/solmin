<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarProveedor
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
        Me.txtCampo03 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblCampo03 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCampo02 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblCampo02 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCampo01 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblCampo01 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtgListaProveedores = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.CPRVCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTPRVCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNNRUCPR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UcPaginacion1 = New Ransa.Utilitario.UCPaginacion
        Me.KryptonDataGridView1 = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.dgProveedor = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dtgListaProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dtgListaProveedores)
        Me.KryptonPanel.Controls.Add(Me.txtCampo03)
        Me.KryptonPanel.Controls.Add(Me.lblCampo03)
        Me.KryptonPanel.Controls.Add(Me.txtCampo02)
        Me.KryptonPanel.Controls.Add(Me.lblCampo02)
        Me.KryptonPanel.Controls.Add(Me.txtCampo01)
        Me.KryptonPanel.Controls.Add(Me.lblCampo01)
        Me.KryptonPanel.Controls.Add(Me.UcPaginacion1)
        Me.KryptonPanel.Controls.Add(Me.KryptonDataGridView1)
        Me.KryptonPanel.Controls.Add(Me.dgProveedor)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(492, 366)
        Me.KryptonPanel.TabIndex = 0
        '
        'txtCampo03
        '
        Me.txtCampo03.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCampo03.CausesValidation = False
        Me.txtCampo03.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCampo03.Location = New System.Drawing.Point(102, 60)
        Me.txtCampo03.Name = "txtCampo03"
        Me.txtCampo03.Size = New System.Drawing.Size(313, 21)
        Me.txtCampo03.TabIndex = 35
        '
        'lblCampo03
        '
        Me.lblCampo03.Location = New System.Drawing.Point(0, 63)
        Me.lblCampo03.Name = "lblCampo03"
        Me.lblCampo03.Size = New System.Drawing.Size(33, 16)
        Me.lblCampo03.StateCommon.ShortText.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCampo03.TabIndex = 34
        Me.lblCampo03.Text = "Ruc :"
        Me.lblCampo03.Values.ExtraText = ""
        Me.lblCampo03.Values.Image = Nothing
        Me.lblCampo03.Values.Text = "Ruc :"
        '
        'txtCampo02
        '
        Me.txtCampo02.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCampo02.CausesValidation = False
        Me.txtCampo02.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCampo02.Location = New System.Drawing.Point(102, 35)
        Me.txtCampo02.Name = "txtCampo02"
        Me.txtCampo02.Size = New System.Drawing.Size(313, 21)
        Me.txtCampo02.TabIndex = 33
        '
        'lblCampo02
        '
        Me.lblCampo02.Location = New System.Drawing.Point(0, 38)
        Me.lblCampo02.Name = "lblCampo02"
        Me.lblCampo02.Size = New System.Drawing.Size(72, 16)
        Me.lblCampo02.StateCommon.ShortText.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCampo02.TabIndex = 32
        Me.lblCampo02.Text = "Descripción  : "
        Me.lblCampo02.Values.ExtraText = ""
        Me.lblCampo02.Values.Image = Nothing
        Me.lblCampo02.Values.Text = "Descripción  : "
        '
        'txtCampo01
        '
        Me.txtCampo01.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCampo01.CausesValidation = False
        Me.txtCampo01.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCampo01.Location = New System.Drawing.Point(102, 10)
        Me.txtCampo01.Name = "txtCampo01"
        Me.txtCampo01.Size = New System.Drawing.Size(313, 21)
        Me.txtCampo01.TabIndex = 31
        '
        'lblCampo01
        '
        Me.lblCampo01.Location = New System.Drawing.Point(0, 13)
        Me.lblCampo01.Name = "lblCampo01"
        Me.lblCampo01.Size = New System.Drawing.Size(48, 16)
        Me.lblCampo01.StateCommon.ShortText.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCampo01.TabIndex = 30
        Me.lblCampo01.Text = "Código :"
        Me.lblCampo01.Values.ExtraText = ""
        Me.lblCampo01.Values.Image = Nothing
        Me.lblCampo01.Values.Text = "Código :"
        '
        'dtgListaProveedores
        '
        Me.dtgListaProveedores.AllowUserToAddRows = False
        Me.dtgListaProveedores.AllowUserToDeleteRows = False
        Me.dtgListaProveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgListaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgListaProveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CPRVCL, Me.PSTPRVCL, Me.PNNRUCPR})
        Me.dtgListaProveedores.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtgListaProveedores.Location = New System.Drawing.Point(0, 93)
        Me.dtgListaProveedores.Name = "dtgListaProveedores"
        Me.dtgListaProveedores.ReadOnly = True
        Me.dtgListaProveedores.Size = New System.Drawing.Size(492, 248)
        Me.dtgListaProveedores.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgListaProveedores.TabIndex = 28
        '
        'CPRVCL
        '
        Me.CPRVCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CPRVCL.DataPropertyName = "PNCPRVCL"
        Me.CPRVCL.HeaderText = "Código"
        Me.CPRVCL.Name = "CPRVCL"
        Me.CPRVCL.ReadOnly = True
        Me.CPRVCL.Width = 74
        '
        'PSTPRVCL
        '
        Me.PSTPRVCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PSTPRVCL.DataPropertyName = "PSTPRVCL"
        Me.PSTPRVCL.HeaderText = "Proveedor"
        Me.PSTPRVCL.Name = "PSTPRVCL"
        Me.PSTPRVCL.ReadOnly = True
        '
        'PNNRUCPR
        '
        Me.PNNRUCPR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PNNRUCPR.DataPropertyName = "PNNRUCPR"
        Me.PNNRUCPR.HeaderText = "Ruc"
        Me.PNNRUCPR.Name = "PNNRUCPR"
        Me.PNNRUCPR.ReadOnly = True
        Me.PNNRUCPR.Width = 55
        '
        'UcPaginacion1
        '
        Me.UcPaginacion1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcPaginacion1.Location = New System.Drawing.Point(0, 341)
        Me.UcPaginacion1.Name = "UcPaginacion1"
        Me.UcPaginacion1.PageCount = 0
        Me.UcPaginacion1.PageNumber = 1
        Me.UcPaginacion1.PageSize = 20
        Me.UcPaginacion1.Size = New System.Drawing.Size(492, 25)
        Me.UcPaginacion1.TabIndex = 29
        '
        'KryptonDataGridView1
        '
        Me.KryptonDataGridView1.AllowUserToAddRows = False
        Me.KryptonDataGridView1.AllowUserToDeleteRows = False
        Me.KryptonDataGridView1.AllowUserToResizeColumns = False
        Me.KryptonDataGridView1.AllowUserToResizeRows = False
        Me.KryptonDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.KryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.KryptonDataGridView1.DataMember = "dtProveedor"
        Me.KryptonDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonDataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonDataGridView1.MultiSelect = False
        Me.KryptonDataGridView1.Name = "KryptonDataGridView1"
        Me.KryptonDataGridView1.ReadOnly = True
        Me.KryptonDataGridView1.RowHeadersWidth = 20
        Me.KryptonDataGridView1.RowTemplate.ReadOnly = True
        Me.KryptonDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.KryptonDataGridView1.Size = New System.Drawing.Size(492, 366)
        Me.KryptonDataGridView1.StandardTab = True
        Me.KryptonDataGridView1.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.KryptonDataGridView1.TabIndex = 27
        '
        'dgProveedor
        '
        Me.dgProveedor.AllowUserToAddRows = False
        Me.dgProveedor.AllowUserToDeleteRows = False
        Me.dgProveedor.AllowUserToResizeColumns = False
        Me.dgProveedor.AllowUserToResizeRows = False
        Me.dgProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgProveedor.DataMember = "dtProveedor"
        Me.dgProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgProveedor.Location = New System.Drawing.Point(0, 0)
        Me.dgProveedor.MultiSelect = False
        Me.dgProveedor.Name = "dgProveedor"
        Me.dgProveedor.ReadOnly = True
        Me.dgProveedor.RowHeadersWidth = 20
        Me.dgProveedor.RowTemplate.ReadOnly = True
        Me.dgProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgProveedor.Size = New System.Drawing.Size(492, 366)
        Me.dgProveedor.StandardTab = True
        Me.dgProveedor.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgProveedor.TabIndex = 26
        '
        'frmBuscarProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 366)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBuscarProveedor"
        Me.Text = "BUSQUEDA : "
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dtgListaProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgProveedor, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents KryptonDataGridView1 As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Private WithEvents dgProveedor As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dtgListaProveedores As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents UcPaginacion1 As Ransa.Utilitario.UCPaginacion
    Private WithEvents txtCampo03 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblCampo03 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtCampo02 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblCampo02 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtCampo01 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblCampo01 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents CPRVCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTPRVCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNNRUCPR As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
