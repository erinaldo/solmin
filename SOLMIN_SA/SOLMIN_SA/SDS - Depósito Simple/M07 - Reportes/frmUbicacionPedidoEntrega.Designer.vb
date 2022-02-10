<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUbicacionPedidoEntrega
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
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnProcesar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnImprimir = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dgMercaderiaGuia = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.Guia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.khgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.txtNroPedidoEntrega = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblNroPedidoEntrega = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.lblFechaFinal = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFechaInicial = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.dgMercaderiaGuia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.khgFiltros.Panel.SuspendLayout()
        Me.khgFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Controls.Add(Me.khgFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1010, 613)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnProcesar, Me.btnImprimir})
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 83)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dgMercaderiaGuia)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(1010, 530)
        Me.KryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.LongText.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.TabIndex = 3
        Me.KryptonHeaderGroup1.Text = "Pedido de Entrega"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Pedido de Entrega"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'btnProcesar
        '
        Me.btnProcesar.ExtraText = ""
        Me.btnProcesar.Image = Nothing
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.ToolTipImage = Nothing
        Me.btnProcesar.UniqueName = "8EB70FA2076846E38EB70FA2076846E3"
        '
        'btnImprimir
        '
        Me.btnImprimir.ExtraText = ""
        Me.btnImprimir.Image = Nothing
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.ToolTipImage = Nothing
        Me.btnImprimir.UniqueName = "FEB3CD6863B9423FFEB3CD6863B9423F"
        '
        'dgMercaderiaGuia
        '
        Me.dgMercaderiaGuia.AllowUserToAddRows = False
        Me.dgMercaderiaGuia.AllowUserToDeleteRows = False
        Me.dgMercaderiaGuia.AllowUserToResizeRows = False
        Me.dgMercaderiaGuia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgMercaderiaGuia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Guia, Me.Column11, Me.Column12, Me.Column1, Me.Column2, Me.Column8, Me.Column3, Me.Column4, Me.Column5, Me.Column9, Me.Column10})
        Me.dgMercaderiaGuia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMercaderiaGuia.Location = New System.Drawing.Point(0, 0)
        Me.dgMercaderiaGuia.MultiSelect = False
        Me.dgMercaderiaGuia.Name = "dgMercaderiaGuia"
        Me.dgMercaderiaGuia.RowHeadersWidth = 20
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMercaderiaGuia.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgMercaderiaGuia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMercaderiaGuia.Size = New System.Drawing.Size(1008, 500)
        Me.dgMercaderiaGuia.StandardTab = True
        Me.dgMercaderiaGuia.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgMercaderiaGuia.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgMercaderiaGuia.TabIndex = 7
        '
        'Guia
        '
        Me.Guia.HeaderText = "Nro Pedido Entrega"
        Me.Guia.Name = "Guia"
        Me.Guia.Width = 129
        '
        'Column11
        '
        Me.Column11.HeaderText = "Codigo Mercaderia"
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 125
        '
        'Column12
        '
        Me.Column12.HeaderText = "Mercaderia"
        Me.Column12.Name = "Column12"
        Me.Column12.Width = 89
        '
        'Column1
        '
        Me.Column1.HeaderText = "Tipo Almacen"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 101
        '
        'Column2
        '
        Me.Column2.HeaderText = "Codigo Tipo Almacen"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 137
        '
        'Column8
        '
        Me.Column8.HeaderText = "Almacen"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 77
        '
        'Column3
        '
        Me.Column3.HeaderText = "Codigo Almacen"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 113
        '
        'Column4
        '
        Me.Column4.HeaderText = "Codigo Zona Almacen"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 141
        '
        'Column5
        '
        Me.Column5.HeaderText = "Zona Almacen"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 105
        '
        'Column9
        '
        Me.Column9.HeaderText = "Sector"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 67
        '
        'Column10
        '
        Me.Column10.HeaderText = "Posicion"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 76
        '
        'khgFiltros
        '
        Me.khgFiltros.AutoSize = True
        Me.khgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaOcultarFiltros, Me.bsaCerrar})
        Me.khgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.khgFiltros.HeaderVisibleSecondary = False
        Me.khgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.khgFiltros.Name = "khgFiltros"
        '
        'khgFiltros.Panel
        '
        Me.khgFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.khgFiltros.Panel.Controls.Add(Me.txtNroPedidoEntrega)
        Me.khgFiltros.Panel.Controls.Add(Me.lblNroPedidoEntrega)
        Me.khgFiltros.Panel.Controls.Add(Me.dtpFechaFinal)
        Me.khgFiltros.Panel.Controls.Add(Me.dtpFechaInicial)
        Me.khgFiltros.Panel.Controls.Add(Me.lblFechaFinal)
        Me.khgFiltros.Panel.Controls.Add(Me.lblFechaInicial)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.khgFiltros.Size = New System.Drawing.Size(1010, 83)
        Me.khgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.khgFiltros.TabIndex = 2
        Me.khgFiltros.Text = "Filtros"
        Me.khgFiltros.ValuesPrimary.Description = ""
        Me.khgFiltros.ValuesPrimary.Heading = "Filtros"
        Me.khgFiltros.ValuesPrimary.Image = Nothing
        Me.khgFiltros.ValuesSecondary.Description = ""
        Me.khgFiltros.ValuesSecondary.Heading = "Resultado"
        Me.khgFiltros.ValuesSecondary.Image = Nothing
        '
        'bsaOcultarFiltros
        '
        Me.bsaOcultarFiltros.ExtraText = ""
        Me.bsaOcultarFiltros.Image = Nothing
        Me.bsaOcultarFiltros.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaOcultarFiltros.Text = "Ocultar"
        Me.bsaOcultarFiltros.ToolTipImage = Nothing
        Me.bsaOcultarFiltros.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaOcultarFiltros.UniqueName = "4FD0578D687F46FC4FD0578D687F46FC"
        '
        'bsaCerrar
        '
        Me.bsaCerrar.ExtraText = ""
        Me.bsaCerrar.Image = Nothing
        Me.bsaCerrar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaCerrar.Text = "Cerrar"
        Me.bsaCerrar.ToolTipImage = Nothing
        Me.bsaCerrar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.bsaCerrar.UniqueName = "C90E4396C7B04154C90E4396C7B04154"
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.Location = New System.Drawing.Point(127, 7)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pRequerido = True
        Me.txtCliente.Size = New System.Drawing.Size(278, 19)
        Me.txtCliente.TabIndex = 2
        '
        'txtNroPedidoEntrega
        '
        Me.txtNroPedidoEntrega.Location = New System.Drawing.Point(127, 35)
        Me.txtNroPedidoEntrega.Name = "txtNroPedidoEntrega"
        Me.txtNroPedidoEntrega.Size = New System.Drawing.Size(147, 19)
        Me.txtNroPedidoEntrega.TabIndex = 6
        '
        'lblNroPedidoEntrega
        '
        Me.lblNroPedidoEntrega.Location = New System.Drawing.Point(11, 35)
        Me.lblNroPedidoEntrega.Name = "lblNroPedidoEntrega"
        Me.lblNroPedidoEntrega.Size = New System.Drawing.Size(119, 16)
        Me.lblNroPedidoEntrega.TabIndex = 5
        Me.lblNroPedidoEntrega.Text = "Nro. Pedido Entrega : "
        Me.lblNroPedidoEntrega.Values.ExtraText = ""
        Me.lblNroPedidoEntrega.Values.Image = Nothing
        Me.lblNroPedidoEntrega.Values.Text = "Nro. Pedido Entrega : "
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(713, 10)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.ShowCheckBox = True
        Me.dtpFechaFinal.Size = New System.Drawing.Size(101, 20)
        Me.dtpFechaFinal.TabIndex = 14
        Me.dtpFechaFinal.Value = New Date(2008, 12, 18, 0, 0, 0, 0)
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(529, 10)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.ShowCheckBox = True
        Me.dtpFechaInicial.Size = New System.Drawing.Size(96, 20)
        Me.dtpFechaInicial.TabIndex = 12
        Me.dtpFechaInicial.Value = New Date(2008, 12, 18, 0, 0, 0, 0)
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.Location = New System.Drawing.Point(631, 12)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(76, 16)
        Me.lblFechaFinal.TabIndex = 13
        Me.lblFechaFinal.Text = "Fecha Final : "
        Me.lblFechaFinal.Values.ExtraText = ""
        Me.lblFechaFinal.Values.Image = Nothing
        Me.lblFechaFinal.Values.Text = "Fecha Final : "
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.Location = New System.Drawing.Point(434, 10)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(77, 16)
        Me.lblFechaInicial.TabIndex = 11
        Me.lblFechaInicial.Text = "Fecha Inicio : "
        Me.lblFechaInicial.Values.ExtraText = ""
        Me.lblFechaInicial.Values.Image = Nothing
        Me.lblFechaInicial.Values.Text = "Fecha Inicio : "
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(11, 16)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(52, 16)
        Me.KryptonLabel1.TabIndex = 1
        Me.KryptonLabel1.Text = "Cliente : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Cliente : "
        '
        'frmUbicacionPedidoEntrega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 613)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmUbicacionPedidoEntrega"
        Me.Text = "Ubicación Sugerida Pedido de Entrega"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.dgMercaderiaGuia, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents bsaOcultarFiltros As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaCerrar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents txtNroPedidoEntrega As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblNroPedidoEntrega As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFinal As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFechaInicial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents dgMercaderiaGuia As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btnProcesar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnImprimir As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents Guia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
