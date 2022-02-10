<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_Frm_Almacen_Local
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
        Me.dgvAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.UcPaginacion = New Ransa.Utilitario.UCPaginacion
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.btnSalir = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.lblDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.PSNTPODT_NCODRG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTDSCRG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNNTPODT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNNCODRG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNCCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgvAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgvAlmacen)
        Me.KryptonPanel.Controls.Add(Me.UcPaginacion)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Controls.Add(Me.KryptonGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(397, 344)
        Me.KryptonPanel.TabIndex = 0
        '
        'dgvAlmacen
        '
        Me.dgvAlmacen.AllowUserToAddRows = False
        Me.dgvAlmacen.AllowUserToDeleteRows = False
        Me.dgvAlmacen.AllowUserToResizeColumns = False
        Me.dgvAlmacen.AllowUserToResizeRows = False
        Me.dgvAlmacen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvAlmacen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PSNTPODT_NCODRG, Me.PSTDSCRG, Me.PNNTPODT, Me.PNNCODRG, Me.PNCCLNT})
        Me.dgvAlmacen.DataMember = "dtCliente"
        Me.dgvAlmacen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAlmacen.Location = New System.Drawing.Point(0, 71)
        Me.dgvAlmacen.MultiSelect = False
        Me.dgvAlmacen.Name = "dgvAlmacen"
        Me.dgvAlmacen.ReadOnly = True
        Me.dgvAlmacen.RowHeadersWidth = 20
        Me.dgvAlmacen.RowTemplate.ReadOnly = True
        Me.dgvAlmacen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvAlmacen.Size = New System.Drawing.Size(397, 248)
        Me.dgvAlmacen.StandardTab = True
        Me.dgvAlmacen.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvAlmacen.TabIndex = 50
        '
        'UcPaginacion
        '
        Me.UcPaginacion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcPaginacion.Location = New System.Drawing.Point(0, 319)
        Me.UcPaginacion.Name = "UcPaginacion"
        Me.UcPaginacion.PageCount = 0
        Me.UcPaginacion.PageNumber = 1
        Me.UcPaginacion.PageSize = 20
        Me.UcPaginacion.Size = New System.Drawing.Size(397, 25)
        Me.UcPaginacion.TabIndex = 49
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 46)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(397, 25)
        Me.ToolStrip1.TabIndex = 48
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(65, 22)
        Me.ToolStripLabel1.Text = "ALMACEN"
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.btnSalir)
        Me.KryptonGroup1.Panel.Controls.Add(Me.lblDescripcion)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtDescripcion)
        Me.KryptonGroup1.Size = New System.Drawing.Size(397, 46)
        Me.KryptonGroup1.TabIndex = 45
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(325, 3)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(59, 25)
        Me.btnSalir.TabIndex = 91
        Me.btnSalir.Text = "&Cerrar"
        Me.btnSalir.Values.ExtraText = ""
        Me.btnSalir.Values.Image = Nothing
        Me.btnSalir.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnSalir.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnSalir.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnSalir.Values.Text = "&Cerrar"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(3, 10)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(80, 16)
        Me.lblDescripcion.StateCommon.ShortText.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblDescripcion.TabIndex = 85
        Me.lblDescripcion.Text = "DESCRIPCIÓN : "
        Me.lblDescripcion.Values.ExtraText = ""
        Me.lblDescripcion.Values.Image = Nothing
        Me.lblDescripcion.Values.Text = "DESCRIPCIÓN : "
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.CausesValidation = False
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(92, 7)
        Me.txtDescripcion.MaxLength = 30
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(227, 21)
        Me.txtDescripcion.TabIndex = 86
        '
        'PSNTPODT_NCODRG
        '
        Me.PSNTPODT_NCODRG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSNTPODT_NCODRG.DataPropertyName = "PSNTPODT_NCODRG"
        Me.PSNTPODT_NCODRG.HeaderText = "Codigo"
        Me.PSNTPODT_NCODRG.Name = "PSNTPODT_NCODRG"
        Me.PSNTPODT_NCODRG.ReadOnly = True
        Me.PSNTPODT_NCODRG.Width = 74
        '
        'PSTDSCRG
        '
        Me.PSTDSCRG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PSTDSCRG.DataPropertyName = "PSTDSCRG"
        Me.PSTDSCRG.HeaderText = "Descripción"
        Me.PSTDSCRG.Name = "PSTDSCRG"
        Me.PSTDSCRG.ReadOnly = True
        '
        'PNNTPODT
        '
        Me.PNNTPODT.DataPropertyName = "PNNTPODT"
        Me.PNNTPODT.HeaderText = "PNNTPODT"
        Me.PNNTPODT.Name = "PNNTPODT"
        Me.PNNTPODT.ReadOnly = True
        Me.PNNTPODT.Visible = False
        Me.PNNTPODT.Width = 91
        '
        'PNNCODRG
        '
        Me.PNNCODRG.DataPropertyName = "PNNCODRG"
        Me.PNNCODRG.HeaderText = "PNNCODRG"
        Me.PNNCODRG.Name = "PNNCODRG"
        Me.PNNCODRG.ReadOnly = True
        Me.PNNCODRG.Visible = False
        Me.PNNCODRG.Width = 97
        '
        'PNCCLNT
        '
        Me.PNCCLNT.DataPropertyName = "PNCCLNT"
        Me.PNCCLNT.HeaderText = "PNCCLNT"
        Me.PNCCLNT.Name = "PNCCLNT"
        Me.PNCCLNT.ReadOnly = True
        Me.PNCCLNT.Visible = False
        Me.PNCCLNT.Width = 82
        '
        'uc_Frm_Almacen_Local
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 344)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "uc_Frm_Almacen_Local"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Búsqueda Almacén"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dgvAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        Me.KryptonGroup1.Panel.PerformLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
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
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Private WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents lblDescripcion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtDescripcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents dgvAlmacen As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents UcPaginacion As Ransa.Utilitario.UCPaginacion
    Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents PSNTPODT_NCODRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTDSCRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNNTPODT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNNCODRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNCCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
