<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportarOcSDSexcel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImportarOcSDSexcel))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dgFlag = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.dgExcelDetalle = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.tbsGuardarDetalle = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.dgExcelCabecera = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.btnEtiquetas = New System.Windows.Forms.ToolStripSplitButton
        Me.btnImprimirPosiciones = New System.Windows.Forms.ToolStripMenuItem
        Me.btnImprimirPasilloFila = New System.Windows.Forms.ToolStripMenuItem
        Me.tsbImprimir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbAgregar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.hgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaStatusOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrarVentana = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.CmbXlsHoja1 = New System.Windows.Forms.ComboBox
        Me.brnAbrirDetalle = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnAbrirCabecera = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.NmCount1 = New System.Windows.Forms.NumericUpDown
        Me.btnExcelDetalle = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnExcelCabecera = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.CmbXlsHoja = New System.Windows.Forms.ComboBox
        Me.NmCount = New System.Windows.Forms.NumericUpDown
        Me.TxtRutaXlsDetalle = New System.Windows.Forms.TextBox
        Me.TxtRutaXlsCabecera = New System.Windows.Forms.TextBox
        Me.lblAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblTipoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgExcelDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgExcelCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.hgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgFiltros.Panel.SuspendLayout()
        Me.hgFiltros.SuspendLayout()
        CType(Me.NmCount1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NmCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgFlag)
        Me.KryptonPanel.Controls.Add(Me.dgExcelDetalle)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Controls.Add(Me.dgExcelCabecera)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Controls.Add(Me.hgFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(992, 696)
        Me.KryptonPanel.TabIndex = 0
        '
        'dgFlag
        '
        Me.dgFlag.AllowUserToAddRows = False
        Me.dgFlag.AllowUserToDeleteRows = False
        Me.dgFlag.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgFlag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFlag.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgFlag.Location = New System.Drawing.Point(0, 461)
        Me.dgFlag.Name = "dgFlag"
        Me.dgFlag.ReadOnly = True
        Me.dgFlag.Size = New System.Drawing.Size(992, 235)
        Me.dgFlag.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgFlag.TabIndex = 30
        '
        'dgExcelDetalle
        '
        Me.dgExcelDetalle.AllowUserToAddRows = False
        Me.dgExcelDetalle.AllowUserToDeleteRows = False
        Me.dgExcelDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgExcelDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgExcelDetalle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgExcelDetalle.Location = New System.Drawing.Point(0, 686)
        Me.dgExcelDetalle.Name = "dgExcelDetalle"
        Me.dgExcelDetalle.ReadOnly = True
        Me.dgExcelDetalle.Size = New System.Drawing.Size(992, 10)
        Me.dgExcelDetalle.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgExcelDetalle.TabIndex = 29
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.ToolStripSplitButton1, Me.ToolStripButton1, Me.ToolStripSeparator5, Me.ToolStripButton2, Me.ToolStripSeparator6, Me.tbsGuardarDetalle, Me.ToolStripSeparator7, Me.ToolStripButton4, Me.ToolStripSeparator8})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 436)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(992, 25)
        Me.ToolStrip1.TabIndex = 28
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(203, 22)
        Me.ToolStripLabel2.Tag = "DETALLE ORDENES DE COMPRA"
        Me.ToolStripLabel2.Text = "DETALLE ORDENES DE COMPRA"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(71, 22)
        Me.ToolStripSplitButton1.Text = "Etiquetas"
        Me.ToolStripSplitButton1.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(202, 22)
        Me.ToolStripMenuItem1.Text = "Etiquetas de Posiciones"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(202, 22)
        Me.ToolStripMenuItem2.Text = "Etiquetas  Pasillo/Fila"
        Me.ToolStripMenuItem2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(69, 22)
        Me.ToolStripButton1.Text = "&Imprimir"
        Me.ToolStripButton1.Visible = False
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator5.Visible = False
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(68, 22)
        Me.ToolStripButton2.Text = "&Eliminar"
        Me.ToolStripButton2.Visible = False
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator6.Visible = False
        '
        'tbsGuardarDetalle
        '
        Me.tbsGuardarDetalle.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tbsGuardarDetalle.Image = Global.SOLMIN_SA.My.Resources.Resources.filesave
        Me.tbsGuardarDetalle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbsGuardarDetalle.Name = "tbsGuardarDetalle"
        Me.tbsGuardarDetalle.Size = New System.Drawing.Size(108, 22)
        Me.tbsGuardarDetalle.Text = "&Guardar Detalle"
        Me.tbsGuardarDetalle.Visible = False
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator7.Visible = False
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(68, 22)
        Me.ToolStripButton4.Text = "&Agregar"
        Me.ToolStripButton4.Visible = False
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator8.Visible = False
        '
        'dgExcelCabecera
        '
        Me.dgExcelCabecera.AllowUserToAddRows = False
        Me.dgExcelCabecera.AllowUserToDeleteRows = False
        Me.dgExcelCabecera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgExcelCabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgExcelCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgExcelCabecera.Location = New System.Drawing.Point(0, 171)
        Me.dgExcelCabecera.Name = "dgExcelCabecera"
        Me.dgExcelCabecera.ReadOnly = True
        Me.dgExcelCabecera.Size = New System.Drawing.Size(992, 265)
        Me.dgExcelCabecera.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgExcelCabecera.TabIndex = 27
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.tsbGuardar, Me.btnEtiquetas, Me.tsbImprimir, Me.ToolStripSeparator1, Me.tsbEliminar, Me.ToolStripSeparator3, Me.ToolStripSeparator2, Me.tsbAgregar, Me.ToolStripSeparator4})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 146)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(992, 25)
        Me.tsMenuOpciones.TabIndex = 26
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(144, 22)
        Me.ToolStripLabel1.Tag = "ORDENES DE COMPRA"
        Me.ToolStripLabel1.Text = "ORDENES DE COMPRA"
        '
        'btnEtiquetas
        '
        Me.btnEtiquetas.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEtiquetas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnImprimirPosiciones, Me.btnImprimirPasilloFila})
        Me.btnEtiquetas.Image = Global.SOLMIN_SA.My.Resources.Resources.mime_resource
        Me.btnEtiquetas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEtiquetas.Name = "btnEtiquetas"
        Me.btnEtiquetas.Size = New System.Drawing.Size(87, 22)
        Me.btnEtiquetas.Text = "Etiquetas"
        Me.btnEtiquetas.Visible = False
        '
        'btnImprimirPosiciones
        '
        Me.btnImprimirPosiciones.Name = "btnImprimirPosiciones"
        Me.btnImprimirPosiciones.Size = New System.Drawing.Size(202, 22)
        Me.btnImprimirPosiciones.Text = "Etiquetas de Posiciones"
        '
        'btnImprimirPasilloFila
        '
        Me.btnImprimirPasilloFila.Name = "btnImprimirPasilloFila"
        Me.btnImprimirPasilloFila.Size = New System.Drawing.Size(202, 22)
        Me.btnImprimirPasilloFila.Text = "Etiquetas  Pasillo/Fila"
        Me.btnImprimirPasilloFila.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tsbImprimir
        '
        Me.tsbImprimir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbImprimir.Image = CType(resources.GetObject("tsbImprimir.Image"), System.Drawing.Image)
        Me.tsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbImprimir.Name = "tsbImprimir"
        Me.tsbImprimir.Size = New System.Drawing.Size(69, 22)
        Me.tsbImprimir.Text = "&Imprimir"
        Me.tsbImprimir.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator1.Visible = False
        '
        'tsbEliminar
        '
        Me.tsbEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbEliminar.Image = CType(resources.GetObject("tsbEliminar.Image"), System.Drawing.Image)
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(68, 22)
        Me.tsbEliminar.Text = "&Eliminar"
        Me.tsbEliminar.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator3.Visible = False
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbGuardar.Image = Global.SOLMIN_SA.My.Resources.Resources.filesave
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(69, 22)
        Me.tsbGuardar.Text = "&Guardar"
        Me.tsbGuardar.ToolTipText = "Guardar "
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbAgregar
        '
        Me.tsbAgregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbAgregar.Image = CType(resources.GetObject("tsbAgregar.Image"), System.Drawing.Image)
        Me.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregar.Name = "tsbAgregar"
        Me.tsbAgregar.Size = New System.Drawing.Size(68, 22)
        Me.tsbAgregar.Text = "&Agregar"
        Me.tsbAgregar.Visible = False
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator4.Visible = False
        '
        'hgFiltros
        '
        Me.hgFiltros.AutoSize = True
        Me.hgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaStatusOcultarFiltros, Me.bsaCerrarVentana})
        Me.hgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.hgFiltros.HeaderVisibleSecondary = False
        Me.hgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.hgFiltros.Name = "hgFiltros"
        '
        'hgFiltros.Panel
        '
        Me.hgFiltros.Panel.Controls.Add(Me.CmbXlsHoja1)
        Me.hgFiltros.Panel.Controls.Add(Me.brnAbrirDetalle)
        Me.hgFiltros.Panel.Controls.Add(Me.btnAbrirCabecera)
        Me.hgFiltros.Panel.Controls.Add(Me.NmCount1)
        Me.hgFiltros.Panel.Controls.Add(Me.btnExcelDetalle)
        Me.hgFiltros.Panel.Controls.Add(Me.btnExcelCabecera)
        Me.hgFiltros.Panel.Controls.Add(Me.CmbXlsHoja)
        Me.hgFiltros.Panel.Controls.Add(Me.NmCount)
        Me.hgFiltros.Panel.Controls.Add(Me.TxtRutaXlsDetalle)
        Me.hgFiltros.Panel.Controls.Add(Me.TxtRutaXlsCabecera)
        Me.hgFiltros.Panel.Controls.Add(Me.lblAlmacen)
        Me.hgFiltros.Panel.Controls.Add(Me.lblTipoAlmacen)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.hgFiltros.Size = New System.Drawing.Size(992, 146)
        Me.hgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgFiltros.TabIndex = 3
        Me.hgFiltros.Text = "Filtros"
        Me.hgFiltros.ValuesPrimary.Description = ""
        Me.hgFiltros.ValuesPrimary.Heading = "Filtros"
        Me.hgFiltros.ValuesPrimary.Image = Nothing
        Me.hgFiltros.ValuesSecondary.Description = ""
        Me.hgFiltros.ValuesSecondary.Heading = "Resultado"
        Me.hgFiltros.ValuesSecondary.Image = Nothing
        '
        'bsaStatusOcultarFiltros
        '
        Me.bsaStatusOcultarFiltros.ExtraText = ""
        Me.bsaStatusOcultarFiltros.Image = Nothing
        Me.bsaStatusOcultarFiltros.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaStatusOcultarFiltros.Text = "Ocultar"
        Me.bsaStatusOcultarFiltros.ToolTipImage = Nothing
        Me.bsaStatusOcultarFiltros.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaStatusOcultarFiltros.UniqueName = "035391BBFC7044C3035391BBFC7044C3"
        '
        'bsaCerrarVentana
        '
        Me.bsaCerrarVentana.ExtraText = ""
        Me.bsaCerrarVentana.Image = Nothing
        Me.bsaCerrarVentana.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaCerrarVentana.Text = "Cerrar"
        Me.bsaCerrarVentana.ToolTipImage = Nothing
        Me.bsaCerrarVentana.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.bsaCerrarVentana.UniqueName = "EC0877FED5AD46CBEC0877FED5AD46CB"
        '
        'CmbXlsHoja1
        '
        Me.CmbXlsHoja1.FormattingEnabled = True
        Me.CmbXlsHoja1.Location = New System.Drawing.Point(874, 61)
        Me.CmbXlsHoja1.Name = "CmbXlsHoja1"
        Me.CmbXlsHoja1.Size = New System.Drawing.Size(104, 21)
        Me.CmbXlsHoja1.TabIndex = 53
        Me.CmbXlsHoja1.Visible = False
        '
        'brnAbrirDetalle
        '
        Me.brnAbrirDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.brnAbrirDetalle.Location = New System.Drawing.Point(713, 62)
        Me.brnAbrirDetalle.Name = "brnAbrirDetalle"
        Me.brnAbrirDetalle.Size = New System.Drawing.Size(74, 44)
        Me.brnAbrirDetalle.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.brnAbrirDetalle.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.brnAbrirDetalle.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.brnAbrirDetalle.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.brnAbrirDetalle.TabIndex = 49
        Me.brnAbrirDetalle.Text = "&Abrir"
        Me.brnAbrirDetalle.Values.ExtraText = "Consulta"
        Me.brnAbrirDetalle.Values.Image = Global.SOLMIN_SA.My.Resources.Resources.cell_layout
        Me.brnAbrirDetalle.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.brnAbrirDetalle.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.brnAbrirDetalle.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.brnAbrirDetalle.Values.Text = "&Abrir"
        '
        'btnAbrirCabecera
        '
        Me.btnAbrirCabecera.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAbrirCabecera.Location = New System.Drawing.Point(713, 3)
        Me.btnAbrirCabecera.Name = "btnAbrirCabecera"
        Me.btnAbrirCabecera.Size = New System.Drawing.Size(74, 44)
        Me.btnAbrirCabecera.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnAbrirCabecera.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnAbrirCabecera.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnAbrirCabecera.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnAbrirCabecera.TabIndex = 48
        Me.btnAbrirCabecera.Text = "&Abrir"
        Me.btnAbrirCabecera.Values.ExtraText = "Consulta"
        Me.btnAbrirCabecera.Values.Image = Global.SOLMIN_SA.My.Resources.Resources.cell_layout
        Me.btnAbrirCabecera.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAbrirCabecera.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAbrirCabecera.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAbrirCabecera.Values.Text = "&Abrir"
        '
        'NmCount1
        '
        Me.NmCount1.BackColor = System.Drawing.SystemColors.Window
        Me.NmCount1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NmCount1.Cursor = System.Windows.Forms.Cursors.NoMoveVert
        Me.NmCount1.Location = New System.Drawing.Point(800, 62)
        Me.NmCount1.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NmCount1.Name = "NmCount1"
        Me.NmCount1.Size = New System.Drawing.Size(68, 20)
        Me.NmCount1.TabIndex = 52
        Me.NmCount1.Visible = False
        '
        'btnExcelDetalle
        '
        Me.btnExcelDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcelDetalle.Location = New System.Drawing.Point(620, 62)
        Me.btnExcelDetalle.Name = "btnExcelDetalle"
        Me.btnExcelDetalle.Size = New System.Drawing.Size(81, 44)
        Me.btnExcelDetalle.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnExcelDetalle.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnExcelDetalle.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnExcelDetalle.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnExcelDetalle.TabIndex = 47
        Me.btnExcelDetalle.Text = "&Cargar"
        Me.btnExcelDetalle.Values.ExtraText = "Consulta"
        Me.btnExcelDetalle.Values.Image = Global.SOLMIN_SA.My.Resources.Resources.excelicon
        Me.btnExcelDetalle.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnExcelDetalle.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnExcelDetalle.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnExcelDetalle.Values.Text = "&Cargar"
        '
        'btnExcelCabecera
        '
        Me.btnExcelCabecera.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcelCabecera.Location = New System.Drawing.Point(620, 3)
        Me.btnExcelCabecera.Name = "btnExcelCabecera"
        Me.btnExcelCabecera.Size = New System.Drawing.Size(81, 44)
        Me.btnExcelCabecera.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnExcelCabecera.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnExcelCabecera.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnExcelCabecera.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnExcelCabecera.TabIndex = 46
        Me.btnExcelCabecera.Text = "&Cargar"
        Me.btnExcelCabecera.Values.ExtraText = "Consulta"
        Me.btnExcelCabecera.Values.Image = Global.SOLMIN_SA.My.Resources.Resources.excelicon
        Me.btnExcelCabecera.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnExcelCabecera.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnExcelCabecera.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnExcelCabecera.Values.Text = "&Cargar"
        '
        'CmbXlsHoja
        '
        Me.CmbXlsHoja.FormattingEnabled = True
        Me.CmbXlsHoja.Location = New System.Drawing.Point(874, 26)
        Me.CmbXlsHoja.Name = "CmbXlsHoja"
        Me.CmbXlsHoja.Size = New System.Drawing.Size(104, 21)
        Me.CmbXlsHoja.TabIndex = 51
        Me.CmbXlsHoja.Visible = False
        '
        'NmCount
        '
        Me.NmCount.BackColor = System.Drawing.SystemColors.Window
        Me.NmCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NmCount.Cursor = System.Windows.Forms.Cursors.NoMoveVert
        Me.NmCount.Location = New System.Drawing.Point(800, 27)
        Me.NmCount.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NmCount.Name = "NmCount"
        Me.NmCount.Size = New System.Drawing.Size(68, 20)
        Me.NmCount.TabIndex = 50
        Me.NmCount.Visible = False
        '
        'TxtRutaXlsDetalle
        '
        Me.TxtRutaXlsDetalle.Location = New System.Drawing.Point(188, 76)
        Me.TxtRutaXlsDetalle.Name = "TxtRutaXlsDetalle"
        Me.TxtRutaXlsDetalle.Size = New System.Drawing.Size(419, 20)
        Me.TxtRutaXlsDetalle.TabIndex = 45
        '
        'TxtRutaXlsCabecera
        '
        Me.TxtRutaXlsCabecera.Location = New System.Drawing.Point(188, 17)
        Me.TxtRutaXlsCabecera.Name = "TxtRutaXlsCabecera"
        Me.TxtRutaXlsCabecera.Size = New System.Drawing.Size(419, 20)
        Me.TxtRutaXlsCabecera.TabIndex = 44
        '
        'lblAlmacen
        '
        Me.lblAlmacen.Location = New System.Drawing.Point(95, 77)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(51, 19)
        Me.lblAlmacen.TabIndex = 43
        Me.lblAlmacen.Text = "Detalle : "
        Me.lblAlmacen.Values.ExtraText = ""
        Me.lblAlmacen.Values.Image = Nothing
        Me.lblAlmacen.Values.Text = "Detalle : "
        '
        'lblTipoAlmacen
        '
        Me.lblTipoAlmacen.Location = New System.Drawing.Point(95, 18)
        Me.lblTipoAlmacen.Name = "lblTipoAlmacen"
        Me.lblTipoAlmacen.Size = New System.Drawing.Size(62, 19)
        Me.lblTipoAlmacen.TabIndex = 42
        Me.lblTipoAlmacen.Text = "Cabecera : "
        Me.lblTipoAlmacen.Values.ExtraText = ""
        Me.lblTipoAlmacen.Values.Image = Nothing
        Me.lblTipoAlmacen.Values.Text = "Cabecera : "
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.AutoSize = False
        Me.KryptonLabel5.Location = New System.Drawing.Point(782, -1)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(31, 115)
        Me.KryptonLabel5.TabIndex = 39
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = ""
        '
        'frmImportarOcSDSexcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 696)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1000, 730)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1000, 730)
        Me.Name = "frmImportarOcSDSexcel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importar Ordenes de Compra Excell"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dgFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgExcelDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgExcelCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        CType(Me.hgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgFiltros.Panel.ResumeLayout(False)
        Me.hgFiltros.Panel.PerformLayout()
        CType(Me.hgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgFiltros.ResumeLayout(False)
        CType(Me.NmCount1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NmCount, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents hgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaStatusOcultarFiltros As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaCerrarVentana As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents lblAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTipoAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnEtiquetas As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents btnImprimirPosiciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnImprimirPasilloFila As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TxtRutaXlsDetalle As System.Windows.Forms.TextBox
    Friend WithEvents TxtRutaXlsCabecera As System.Windows.Forms.TextBox
    Friend WithEvents dgExcelCabecera As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dgExcelDetalle As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btnExcelDetalle As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnExcelCabecera As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents brnAbrirDetalle As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnAbrirCabecera As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents NmCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents CmbXlsHoja As System.Windows.Forms.ComboBox
    Friend WithEvents CmbXlsHoja1 As System.Windows.Forms.ComboBox
    Friend WithEvents NmCount1 As System.Windows.Forms.NumericUpDown
    Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbsGuardarDetalle As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dgFlag As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
End Class
