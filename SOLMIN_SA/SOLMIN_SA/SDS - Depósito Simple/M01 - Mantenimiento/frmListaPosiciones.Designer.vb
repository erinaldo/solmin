<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaPosiciones
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
        Me.dgPosiciones = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.PNCCLNRN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CPSCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTIPO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSALMACEN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CPSLL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCCLMN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTMRCD2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNQSLETQ = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BTN = New System.Windows.Forms.DataGridViewImageColumn
        Me.tspListadoMercaderia = New System.Windows.Forms.ToolStrip
        Me.btnSalir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnACeptar = New System.Windows.Forms.ToolStripButton
        Me.hgOS = New System.Windows.Forms.ToolStripSeparator
        Me.txtFiltroPosicion = New System.Windows.Forms.ToolStripTextBox
        Me.lblFiltro = New System.Windows.Forms.ToolStripLabel
        Me.tssSeparador01 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.UcPaginacion = New Ransa.Utilitario.UCPaginacion
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgPosiciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tspListadoMercaderia.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgPosiciones)
        Me.KryptonPanel.Controls.Add(Me.tspListadoMercaderia)
        Me.KryptonPanel.Controls.Add(Me.UcPaginacion)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(628, 370)
        Me.KryptonPanel.TabIndex = 0
        '
        'dgPosiciones
        '
        Me.dgPosiciones.AllowUserToAddRows = False
        Me.dgPosiciones.AllowUserToDeleteRows = False
        Me.dgPosiciones.AllowUserToResizeColumns = False
        Me.dgPosiciones.AllowUserToResizeRows = False
        Me.dgPosiciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgPosiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgPosiciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PNCCLNRN, Me.CPSCN, Me.PSTIPO, Me.PSALMACEN, Me.CPSLL, Me.PSCCLMN, Me.PSCLIENTE, Me.PSTMRCD2, Me.PNQSLETQ, Me.BTN})
        Me.dgPosiciones.DataMember = "dtRZSC30"
        Me.dgPosiciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPosiciones.Location = New System.Drawing.Point(0, 25)
        Me.dgPosiciones.MultiSelect = False
        Me.dgPosiciones.Name = "dgPosiciones"
        Me.dgPosiciones.ReadOnly = True
        Me.dgPosiciones.RowHeadersWidth = 20
        Me.dgPosiciones.RowTemplate.ReadOnly = True
        Me.dgPosiciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPosiciones.Size = New System.Drawing.Size(628, 320)
        Me.dgPosiciones.StandardTab = True
        Me.dgPosiciones.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgPosiciones.TabIndex = 63
        '
        'PNCCLNRN
        '
        Me.PNCCLNRN.DataPropertyName = "PNCCLNRN"
        Me.PNCCLNRN.HeaderText = "Código Cliente"
        Me.PNCCLNRN.Name = "PNCCLNRN"
        Me.PNCCLNRN.ReadOnly = True
        Me.PNCCLNRN.Visible = False
        Me.PNCCLNRN.Width = 113
        '
        'CPSCN
        '
        Me.CPSCN.DataPropertyName = "PSCLIENTE"
        Me.CPSCN.HeaderText = "Des. Abrev. del Cliente"
        Me.CPSCN.Name = "CPSCN"
        Me.CPSCN.ReadOnly = True
        Me.CPSCN.Visible = False
        Me.CPSCN.Width = 151
        '
        'PSTIPO
        '
        Me.PSTIPO.DataPropertyName = "PSCPSCN"
        Me.PSTIPO.HeaderText = "Posición"
        Me.PSTIPO.Name = "PSTIPO"
        Me.PSTIPO.ReadOnly = True
        Me.PSTIPO.Width = 79
        '
        'PSALMACEN
        '
        Me.PSALMACEN.DataPropertyName = "PNCSRVPK"
        Me.PSALMACEN.HeaderText = "Srv Pck"
        Me.PSALMACEN.Name = "PSALMACEN"
        Me.PSALMACEN.ReadOnly = True
        Me.PSALMACEN.Width = 71
        '
        'CPSLL
        '
        Me.CPSLL.DataPropertyName = "PSCPSLL"
        Me.CPSLL.HeaderText = "Pasillo"
        Me.CPSLL.Name = "CPSLL"
        Me.CPSLL.ReadOnly = True
        Me.CPSLL.Width = 69
        '
        'PSCCLMN
        '
        Me.PSCCLMN.DataPropertyName = "PSCCLMN"
        Me.PSCCLMN.HeaderText = "Columna"
        Me.PSCCLMN.Name = "PSCCLMN"
        Me.PSCCLMN.ReadOnly = True
        Me.PSCCLMN.Width = 82
        '
        'PSCLIENTE
        '
        Me.PSCLIENTE.DataPropertyName = "PSESTADO"
        Me.PSCLIENTE.HeaderText = "Estado"
        Me.PSCLIENTE.Name = "PSCLIENTE"
        Me.PSCLIENTE.ReadOnly = True
        Me.PSCLIENTE.Width = 71
        '
        'PSTMRCD2
        '
        Me.PSTMRCD2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PSTMRCD2.DataPropertyName = "PSTMRCD2"
        Me.PSTMRCD2.HeaderText = "Producto Descripción"
        Me.PSTMRCD2.Name = "PSTMRCD2"
        Me.PSTMRCD2.ReadOnly = True
        '
        'PNQSLETQ
        '
        Me.PNQSLETQ.DataPropertyName = "PNQSLETQ"
        Me.PNQSLETQ.HeaderText = "Cantidad"
        Me.PNQSLETQ.Name = "PNQSLETQ"
        Me.PNQSLETQ.ReadOnly = True
        Me.PNQSLETQ.Visible = False
        Me.PNQSLETQ.Width = 83
        '
        'BTN
        '
        Me.BTN.HeaderText = "Inventario"
        Me.BTN.Image = Global.SOLMIN_SA.My.Resources.Resources.cell_layout
        Me.BTN.Name = "BTN"
        Me.BTN.ReadOnly = True
        Me.BTN.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BTN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.BTN.Visible = False
        Me.BTN.Width = 88
        '
        'tspListadoMercaderia
        '
        Me.tspListadoMercaderia.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tspListadoMercaderia.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspListadoMercaderia.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSalir, Me.ToolStripSeparator2, Me.btnACeptar, Me.hgOS, Me.txtFiltroPosicion, Me.lblFiltro, Me.tssSeparador01, Me.ToolStripSeparator1})
        Me.tspListadoMercaderia.Location = New System.Drawing.Point(0, 0)
        Me.tspListadoMercaderia.Name = "tspListadoMercaderia"
        Me.tspListadoMercaderia.Size = New System.Drawing.Size(628, 25)
        Me.tspListadoMercaderia.TabIndex = 62
        Me.tspListadoMercaderia.Text = "ToolStrip1"
        '
        'btnSalir
        '
        Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalir.Image = Global.SOLMIN_SA.My.Resources.Resources._exit
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(71, 22)
        Me.btnSalir.Text = "Cancelar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnACeptar
        '
        Me.btnACeptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnACeptar.Image = Global.SOLMIN_SA.My.Resources.Resources.button_ok1
        Me.btnACeptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnACeptar.Name = "btnACeptar"
        Me.btnACeptar.Size = New System.Drawing.Size(66, 22)
        Me.btnACeptar.Text = "Aceptar"
        '
        'hgOS
        '
        Me.hgOS.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.hgOS.Name = "hgOS"
        Me.hgOS.Size = New System.Drawing.Size(6, 25)
        '
        'txtFiltroPosicion
        '
        Me.txtFiltroPosicion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtFiltroPosicion.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtFiltroPosicion.MaxLength = 30
        Me.txtFiltroPosicion.Name = "txtFiltroPosicion"
        Me.txtFiltroPosicion.Size = New System.Drawing.Size(150, 25)
        '
        'lblFiltro
        '
        Me.lblFiltro.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(43, 22)
        Me.lblFiltro.Text = "Filtro :"
        '
        'tssSeparador01
        '
        Me.tssSeparador01.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparador01.Name = "tssSeparador01"
        Me.tssSeparador01.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'UcPaginacion
        '
        Me.UcPaginacion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcPaginacion.Location = New System.Drawing.Point(0, 345)
        Me.UcPaginacion.Name = "UcPaginacion"
        Me.UcPaginacion.PageCount = 0
        Me.UcPaginacion.PageNumber = 1
        Me.UcPaginacion.PageSize = 20
        Me.UcPaginacion.Size = New System.Drawing.Size(628, 25)
        Me.UcPaginacion.TabIndex = 29
        '
        'frmListaPosiciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 370)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListaPosiciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Posiciones"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dgPosiciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tspListadoMercaderia.ResumeLayout(False)
        Me.tspListadoMercaderia.PerformLayout()
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
    Friend WithEvents UcPaginacion As Ransa.Utilitario.UCPaginacion
    Friend WithEvents tspListadoMercaderia As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnACeptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents hgOS As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtFiltroPosicion As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents lblFiltro As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tssSeparador01 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents dgPosiciones As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents PNCCLNRN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPSCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTIPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSALMACEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPSLL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCCLMN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCLIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTMRCD2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQSLETQ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BTN As System.Windows.Forms.DataGridViewImageColumn
End Class
