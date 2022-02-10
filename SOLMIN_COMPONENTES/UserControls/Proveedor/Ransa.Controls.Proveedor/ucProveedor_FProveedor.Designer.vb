<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucProveedor_FProveedor
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
        Me.dgProveedor = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.PNCPRVCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNNRUCPR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTPRVCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UcPaginacion = New Ransa.Utilitario.UCPaginacion
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.lblProveedor = New System.Windows.Forms.ToolStripLabel
        Me.khgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.chkEnLaCadena = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.btnSalir = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtCodigo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.chkMientrasEscribe = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.lblCodigo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtRUC = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblRUC = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.khgFiltros.Panel.SuspendLayout()
        Me.khgFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgProveedor)
        Me.KryptonPanel.Controls.Add(Me.UcPaginacion)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Controls.Add(Me.khgFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(519, 478)
        Me.KryptonPanel.TabIndex = 0
        '
        'dgProveedor
        '
        Me.dgProveedor.AllowUserToAddRows = False
        Me.dgProveedor.AllowUserToDeleteRows = False
        Me.dgProveedor.AllowUserToResizeColumns = False
        Me.dgProveedor.AllowUserToResizeRows = False
        Me.dgProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgProveedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PNCPRVCL, Me.PNNRUCPR, Me.PSTPRVCL})
        Me.dgProveedor.DataMember = "dtCliente"
        Me.dgProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgProveedor.Location = New System.Drawing.Point(0, 152)
        Me.dgProveedor.MultiSelect = False
        Me.dgProveedor.Name = "dgProveedor"
        Me.dgProveedor.ReadOnly = True
        Me.dgProveedor.RowHeadersWidth = 20
        Me.dgProveedor.RowTemplate.ReadOnly = True
        Me.dgProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgProveedor.Size = New System.Drawing.Size(519, 301)
        Me.dgProveedor.StandardTab = True
        Me.dgProveedor.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgProveedor.TabIndex = 31
        '
        'PNCPRVCL
        '
        Me.PNCPRVCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PNCPRVCL.DataPropertyName = "PNCPRVCL"
        Me.PNCPRVCL.HeaderText = "Proveedor"
        Me.PNCPRVCL.Name = "PNCPRVCL"
        Me.PNCPRVCL.ReadOnly = True
        Me.PNCPRVCL.Width = 88
        '
        'PNNRUCPR
        '
        Me.PNNRUCPR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PNNRUCPR.DataPropertyName = "PNNRUCPR"
        Me.PNNRUCPR.HeaderText = "Nro RUC"
        Me.PNNRUCPR.Name = "PNNRUCPR"
        Me.PNNRUCPR.ReadOnly = True
        Me.PNNRUCPR.Width = 80
        '
        'PSTPRVCL
        '
        Me.PSTPRVCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PSTPRVCL.DataPropertyName = "PSTPRVCL"
        Me.PSTPRVCL.HeaderText = "Descripción"
        Me.PSTPRVCL.Name = "PSTPRVCL"
        Me.PSTPRVCL.ReadOnly = True
        '
        'UcPaginacion
        '
        Me.UcPaginacion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcPaginacion.Location = New System.Drawing.Point(0, 453)
        Me.UcPaginacion.Name = "UcPaginacion"
        Me.UcPaginacion.PageCount = 0
        Me.UcPaginacion.PageNumber = 1
        Me.UcPaginacion.PageSize = 20
        Me.UcPaginacion.Size = New System.Drawing.Size(519, 25)
        Me.UcPaginacion.TabIndex = 30
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblProveedor})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 127)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(519, 25)
        Me.tsMenuOpciones.TabIndex = 26
        '
        'lblProveedor
        '
        Me.lblProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(84, 22)
        Me.lblProveedor.Text = "PROVEEDOR"
        '
        'khgFiltros
        '
        Me.khgFiltros.AutoSize = True
        Me.khgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.khgFiltros.HeaderVisibleSecondary = False
        Me.khgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.khgFiltros.Name = "khgFiltros"
        '
        'khgFiltros.Panel
        '
        Me.khgFiltros.Panel.Controls.Add(Me.chkEnLaCadena)
        Me.khgFiltros.Panel.Controls.Add(Me.btnSalir)
        Me.khgFiltros.Panel.Controls.Add(Me.txtCodigo)
        Me.khgFiltros.Panel.Controls.Add(Me.chkMientrasEscribe)
        Me.khgFiltros.Panel.Controls.Add(Me.lblCodigo)
        Me.khgFiltros.Panel.Controls.Add(Me.txtRUC)
        Me.khgFiltros.Panel.Controls.Add(Me.lblDescripcion)
        Me.khgFiltros.Panel.Controls.Add(Me.lblRUC)
        Me.khgFiltros.Panel.Controls.Add(Me.txtDescripcion)
        Me.khgFiltros.Size = New System.Drawing.Size(519, 127)
        Me.khgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.khgFiltros.TabIndex = 4
        Me.khgFiltros.ValuesPrimary.Description = ""
        Me.khgFiltros.ValuesPrimary.Heading = ""
        Me.khgFiltros.ValuesPrimary.Image = Nothing
        Me.khgFiltros.ValuesSecondary.Description = ""
        Me.khgFiltros.ValuesSecondary.Heading = "Resultado"
        Me.khgFiltros.ValuesSecondary.Image = Nothing
        '
        'chkEnLaCadena
        '
        Me.chkEnLaCadena.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEnLaCadena.Location = New System.Drawing.Point(91, 92)
        Me.chkEnLaCadena.Name = "chkEnLaCadena"
        Me.chkEnLaCadena.Size = New System.Drawing.Size(86, 19)
        Me.chkEnLaCadena.TabIndex = 80
        Me.chkEnLaCadena.TabStop = False
        Me.chkEnLaCadena.Text = "En la cadena"
        Me.chkEnLaCadena.Values.ExtraText = ""
        Me.chkEnLaCadena.Values.Image = Nothing
        Me.chkEnLaCadena.Values.Text = "En la cadena"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(447, 95)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(59, 25)
        Me.btnSalir.TabIndex = 82
        Me.btnSalir.Text = "&Cerrar"
        Me.btnSalir.Values.ExtraText = ""
        Me.btnSalir.Values.Image = Nothing
        Me.btnSalir.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnSalir.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnSalir.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnSalir.Values.Text = "&Cerrar"
        '
        'txtCodigo
        '
        Me.txtCodigo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodigo.CausesValidation = False
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Location = New System.Drawing.Point(91, 13)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(391, 21)
        Me.txtCodigo.TabIndex = 75
        '
        'chkMientrasEscribe
        '
        Me.chkMientrasEscribe.Checked = False
        Me.chkMientrasEscribe.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkMientrasEscribe.Location = New System.Drawing.Point(186, 92)
        Me.chkMientrasEscribe.Name = "chkMientrasEscribe"
        Me.chkMientrasEscribe.Size = New System.Drawing.Size(119, 19)
        Me.chkMientrasEscribe.TabIndex = 81
        Me.chkMientrasEscribe.TabStop = False
        Me.chkMientrasEscribe.Text = "Mientras se escribe"
        Me.chkMientrasEscribe.Values.ExtraText = ""
        Me.chkMientrasEscribe.Values.Image = Nothing
        Me.chkMientrasEscribe.Values.Text = "Mientras se escribe"
        '
        'lblCodigo
        '
        Me.lblCodigo.Location = New System.Drawing.Point(5, 16)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(54, 16)
        Me.lblCodigo.StateCommon.ShortText.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.TabIndex = 74
        Me.lblCodigo.Text = "CODIGO : "
        Me.lblCodigo.Values.ExtraText = ""
        Me.lblCodigo.Values.Image = Nothing
        Me.lblCodigo.Values.Text = "CODIGO : "
        '
        'txtRUC
        '
        Me.txtRUC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRUC.CausesValidation = False
        Me.txtRUC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRUC.Location = New System.Drawing.Point(91, 63)
        Me.txtRUC.Name = "txtRUC"
        Me.txtRUC.Size = New System.Drawing.Size(391, 21)
        Me.txtRUC.TabIndex = 79
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(5, 41)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(80, 16)
        Me.lblDescripcion.StateCommon.ShortText.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblDescripcion.TabIndex = 76
        Me.lblDescripcion.Text = "DESCRIPCIÓN : "
        Me.lblDescripcion.Values.ExtraText = ""
        Me.lblDescripcion.Values.Image = Nothing
        Me.lblDescripcion.Values.Text = "DESCRIPCIÓN : "
        '
        'lblRUC
        '
        Me.lblRUC.Location = New System.Drawing.Point(5, 66)
        Me.lblRUC.Name = "lblRUC"
        Me.lblRUC.Size = New System.Drawing.Size(44, 16)
        Me.lblRUC.StateCommon.ShortText.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblRUC.TabIndex = 78
        Me.lblRUC.Text = "R.U.C. :"
        Me.lblRUC.Values.ExtraText = ""
        Me.lblRUC.Values.Image = Nothing
        Me.lblRUC.Values.Text = "R.U.C. :"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.CausesValidation = False
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(91, 38)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(391, 21)
        Me.txtDescripcion.TabIndex = 77
        '
        'ucProveedor_FProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 478)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximumSize = New System.Drawing.Size(527, 512)
        Me.MinimumSize = New System.Drawing.Size(527, 512)
        Me.Name = "ucProveedor_FProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Búsqueda:"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dgProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.Panel.ResumeLayout(False)
        Me.khgFiltros.Panel.PerformLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.ResumeLayout(False)
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
    Friend WithEvents khgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Private WithEvents chkEnLaCadena As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Private WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents txtCodigo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents chkMientrasEscribe As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Private WithEvents lblCodigo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtRUC As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblDescripcion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblRUC As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtDescripcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents lblProveedor As System.Windows.Forms.ToolStripLabel
    Friend WithEvents UcPaginacion As Ransa.Utilitario.UCPaginacion
    Private WithEvents dgProveedor As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents PNCPRVCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNNRUCPR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTPRVCL As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
