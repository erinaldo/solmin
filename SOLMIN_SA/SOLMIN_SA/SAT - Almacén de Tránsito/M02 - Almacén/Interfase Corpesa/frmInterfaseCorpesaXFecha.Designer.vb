<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInterfaseCorpesaXFecha
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
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.dtgBultos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.Idmovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.origen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Destino = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fechamovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Horamovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tipotransporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Modelo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Placa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Primernombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Segundonombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Apellidopaterno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Apellidomaterno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tipodocumento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dtgDetalleBulto = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.IdDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdMovimiento1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodBarra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NroOrden = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NroGuia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Importar = New System.Windows.Forms.DataGridViewImageColumn
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.khgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaCerrarVentana = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFecFin = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFecIni = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tssSep_01 = New System.Windows.Forms.ToolStripSeparator
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonManager1 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.dtgBultos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgDetalleBulto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.khgFiltros.Panel.SuspendLayout()
        Me.khgFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(745, 419)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.KryptonSplitContainer1)
        Me.KryptonPanel1.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel1.Controls.Add(Me.khgFiltros)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(745, 419)
        Me.KryptonPanel1.TabIndex = 1
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 102)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        Me.KryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.dtgBultos)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.dtgDetalleBulto)
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(745, 317)
        Me.KryptonSplitContainer1.SplitterDistance = 122
        Me.KryptonSplitContainer1.TabIndex = 45
        '
        'dtgBultos
        '
        Me.dtgBultos.AllowUserToAddRows = False
        Me.dtgBultos.AllowUserToDeleteRows = False
        Me.dtgBultos.ColumnHeadersHeight = 30
        Me.dtgBultos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Idmovimiento, Me.origen, Me.Destino, Me.Fechamovimiento, Me.Horamovimiento, Me.Tipotransporte, Me.Marca, Me.Modelo, Me.Placa, Me.Primernombre, Me.Segundonombre, Me.Apellidopaterno, Me.Apellidomaterno, Me.Tipodocumento})
        Me.dtgBultos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgBultos.Location = New System.Drawing.Point(0, 0)
        Me.dtgBultos.Name = "dtgBultos"
        Me.dtgBultos.ReadOnly = True
        Me.dtgBultos.RowHeadersWidth = 20
        Me.dtgBultos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.dtgBultos.Size = New System.Drawing.Size(745, 122)
        Me.dtgBultos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgBultos.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dtgBultos.TabIndex = 39
        '
        'Idmovimiento
        '
        Me.Idmovimiento.HeaderText = "Idmovimiento"
        Me.Idmovimiento.Name = "Idmovimiento"
        Me.Idmovimiento.ReadOnly = True
        Me.Idmovimiento.Visible = False
        '
        'origen
        '
        Me.origen.DataPropertyName = "origen"
        Me.origen.HeaderText = "Origen"
        Me.origen.Name = "origen"
        Me.origen.ReadOnly = True
        '
        'Destino
        '
        Me.Destino.DataPropertyName = "Destino"
        Me.Destino.HeaderText = "Destino"
        Me.Destino.Name = "Destino"
        Me.Destino.ReadOnly = True
        '
        'Fechamovimiento
        '
        Me.Fechamovimiento.DataPropertyName = "Fechamovimiento"
        Me.Fechamovimiento.HeaderText = "Fecha de movimiento"
        Me.Fechamovimiento.Name = "Fechamovimiento"
        Me.Fechamovimiento.ReadOnly = True
        '
        'Horamovimiento
        '
        Me.Horamovimiento.DataPropertyName = "Horamovimiento"
        Me.Horamovimiento.HeaderText = "Hora"
        Me.Horamovimiento.Name = "Horamovimiento"
        Me.Horamovimiento.ReadOnly = True
        '
        'Tipotransporte
        '
        Me.Tipotransporte.DataPropertyName = "Tipotransporte"
        Me.Tipotransporte.HeaderText = "Tipo de transporte"
        Me.Tipotransporte.Name = "Tipotransporte"
        Me.Tipotransporte.ReadOnly = True
        '
        'Marca
        '
        Me.Marca.DataPropertyName = "Marca"
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        Me.Marca.ReadOnly = True
        '
        'Modelo
        '
        Me.Modelo.DataPropertyName = "Modelo"
        Me.Modelo.HeaderText = "Modelo"
        Me.Modelo.Name = "Modelo"
        Me.Modelo.ReadOnly = True
        '
        'Placa
        '
        Me.Placa.DataPropertyName = "Placa"
        Me.Placa.HeaderText = "Placa"
        Me.Placa.Name = "Placa"
        Me.Placa.ReadOnly = True
        '
        'Primernombre
        '
        Me.Primernombre.DataPropertyName = "Primernombre"
        Me.Primernombre.HeaderText = "Primer Nombre Conductor"
        Me.Primernombre.Name = "Primernombre"
        Me.Primernombre.ReadOnly = True
        '
        'Segundonombre
        '
        Me.Segundonombre.DataPropertyName = "Segundonombre"
        Me.Segundonombre.HeaderText = "Segundo Nombre Conductor"
        Me.Segundonombre.Name = "Segundonombre"
        Me.Segundonombre.ReadOnly = True
        '
        'Apellidopaterno
        '
        Me.Apellidopaterno.DataPropertyName = "Apellidopaterno"
        Me.Apellidopaterno.HeaderText = "Apellido paterno conductor"
        Me.Apellidopaterno.Name = "Apellidopaterno"
        Me.Apellidopaterno.ReadOnly = True
        '
        'Apellidomaterno
        '
        Me.Apellidomaterno.DataPropertyName = "Apellidomaterno"
        Me.Apellidomaterno.HeaderText = "Apellido materno conductor"
        Me.Apellidomaterno.Name = "Apellidomaterno"
        Me.Apellidomaterno.ReadOnly = True
        '
        'Tipodocumento
        '
        Me.Tipodocumento.DataPropertyName = "Tipodocumento"
        Me.Tipodocumento.HeaderText = "Tipo documento"
        Me.Tipodocumento.Name = "Tipodocumento"
        Me.Tipodocumento.ReadOnly = True
        '
        'dtgDetalleBulto
        '
        Me.dtgDetalleBulto.AllowUserToAddRows = False
        Me.dtgDetalleBulto.AllowUserToDeleteRows = False
        Me.dtgDetalleBulto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgDetalleBulto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDetalle, Me.IdMovimiento1, Me.CodBarra, Me.NroOrden, Me.Tipo, Me.Cantidad, Me.NroGuia, Me.Importar, Me.Estado})
        Me.dtgDetalleBulto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgDetalleBulto.Location = New System.Drawing.Point(0, 0)
        Me.dtgDetalleBulto.Name = "dtgDetalleBulto"
        Me.dtgDetalleBulto.ReadOnly = True
        Me.dtgDetalleBulto.RowHeadersWidth = 20
        Me.dtgDetalleBulto.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.dtgDetalleBulto.Size = New System.Drawing.Size(745, 190)
        Me.dtgDetalleBulto.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgDetalleBulto.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dtgDetalleBulto.TabIndex = 43
        '
        'IdDetalle
        '
        Me.IdDetalle.DataPropertyName = "IdDetalle"
        Me.IdDetalle.HeaderText = "IdDetalle"
        Me.IdDetalle.Name = "IdDetalle"
        Me.IdDetalle.ReadOnly = True
        Me.IdDetalle.Visible = False
        '
        'IdMovimiento1
        '
        Me.IdMovimiento1.DataPropertyName = "IdMovimiento"
        Me.IdMovimiento1.HeaderText = "IdMovimiento"
        Me.IdMovimiento1.Name = "IdMovimiento1"
        Me.IdMovimiento1.ReadOnly = True
        Me.IdMovimiento1.Visible = False
        '
        'CodBarra
        '
        Me.CodBarra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CodBarra.DataPropertyName = "CodBarra"
        Me.CodBarra.HeaderText = "Codigo de Barra copesa"
        Me.CodBarra.Name = "CodBarra"
        Me.CodBarra.ReadOnly = True
        '
        'NroOrden
        '
        Me.NroOrden.DataPropertyName = "NroOrden"
        Me.NroOrden.HeaderText = "Nro. Orden"
        Me.NroOrden.Name = "NroOrden"
        Me.NroOrden.ReadOnly = True
        '
        'Tipo
        '
        Me.Tipo.DataPropertyName = "Tipo"
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "Cantidad"
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'NroGuia
        '
        Me.NroGuia.DataPropertyName = "NroGuia"
        Me.NroGuia.HeaderText = "Nro Guía"
        Me.NroGuia.Name = "NroGuia"
        Me.NroGuia.ReadOnly = True
        '
        'Importar
        '
        Me.Importar.HeaderText = "Importar"
        Me.Importar.Image = Global.SOLMIN_SA.My.Resources.Resources.Interface_Grilla
        Me.Importar.Name = "Importar"
        Me.Importar.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Visible = False
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 77)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(745, 25)
        Me.tsMenuOpciones.TabIndex = 44
        '
        'khgFiltros
        '
        Me.khgFiltros.AutoSize = True
        Me.khgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaCerrarVentana})
        Me.khgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.khgFiltros.HeaderVisibleSecondary = False
        Me.khgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.khgFiltros.Name = "khgFiltros"
        '
        'khgFiltros.Panel
        '
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.khgFiltros.Panel.Controls.Add(Me.dtpFecFin)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.khgFiltros.Panel.Controls.Add(Me.dtpFecIni)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.khgFiltros.Size = New System.Drawing.Size(745, 77)
        Me.khgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.khgFiltros.TabIndex = 43
        Me.khgFiltros.Text = "Filtros"
        Me.khgFiltros.ValuesPrimary.Description = ""
        Me.khgFiltros.ValuesPrimary.Heading = "Filtros"
        Me.khgFiltros.ValuesPrimary.Image = Nothing
        Me.khgFiltros.ValuesSecondary.Description = ""
        Me.khgFiltros.ValuesSecondary.Heading = "Resultado"
        Me.khgFiltros.ValuesSecondary.Image = Nothing
        '
        'bsaCerrarVentana
        '
        Me.bsaCerrarVentana.ExtraText = ""
        Me.bsaCerrarVentana.Image = Nothing
        Me.bsaCerrarVentana.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaCerrarVentana.Text = "Cerrar"
        Me.bsaCerrarVentana.ToolTipImage = Nothing
        Me.bsaCerrarVentana.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.bsaCerrarVentana.UniqueName = "43B34B10206C4BD743B34B10206C4BD7"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.AutoSize = False
        Me.KryptonLabel5.Location = New System.Drawing.Point(426, 3)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(67, 42)
        Me.KryptonLabel5.TabIndex = 41
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = ""
        '
        'dtpFecFin
        '
        Me.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecFin.Location = New System.Drawing.Point(293, 14)
        Me.dtpFecFin.Name = "dtpFecFin"
        Me.dtpFecFin.Size = New System.Drawing.Size(94, 20)
        Me.dtpFecFin.TabIndex = 40
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(225, 15)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(62, 19)
        Me.KryptonLabel2.TabIndex = 42
        Me.KryptonLabel2.Text = "Fecha Fin :"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Fecha Fin :"
        '
        'dtpFecIni
        '
        Me.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecIni.Location = New System.Drawing.Point(103, 15)
        Me.dtpFecIni.Name = "dtpFecIni"
        Me.dtpFecIni.Size = New System.Drawing.Size(94, 20)
        Me.dtpFecIni.TabIndex = 39
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(23, 16)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(74, 19)
        Me.KryptonLabel1.TabIndex = 34
        Me.KryptonLabel1.Text = "Fecha Inicio : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Fecha Inicio : "
        '
        'tssSep_01
        '
        Me.tssSep_01.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_01.Name = "tssSep_01"
        Me.tssSep_01.Size = New System.Drawing.Size(6, 25)
        '
        'btnBuscar
        '
        Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar.Image = Global.SOLMIN_SA.My.Resources.Resources.search1
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(61, 22)
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.ToolTipText = "Buscar"
        '
        'frmInterfaseCorpesaXFecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 419)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInterfaseCorpesaXFecha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Interfaz Corpesa por Fecha"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.dtgBultos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgDetalleBulto, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents dtpFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonManager1 As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents khgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaCerrarVentana As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents dtgBultos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dtgDetalleBulto As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Idmovimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents origen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Destino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fechamovimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Horamovimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipotransporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Placa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Primernombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Segundonombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellidopaterno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellidomaterno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipodocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tssSep_01 As System.Windows.Forms.ToolStripSeparator

    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents IdDetalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdMovimiento1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodBarra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NroOrden As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NroGuia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton

End Class
