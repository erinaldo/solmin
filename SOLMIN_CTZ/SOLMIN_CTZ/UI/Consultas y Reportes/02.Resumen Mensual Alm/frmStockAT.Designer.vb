<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockAT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockAT))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.ButtonSpecHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.pcxEspera = New System.Windows.Forms.PictureBox
        Me.UcDivision = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
        Me.lblDivision = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbExportar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.KryptonRadioButton1 = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.rbtOrdenDeCompra = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.rbtItem = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.dteFechaInventario = New System.Windows.Forms.DateTimePicker
        Me.lblFechaInventario = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.lblDestino = New System.Windows.Forms.ToolStripLabel
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.tssSeparador1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        Me.tssSeparador2 = New System.Windows.Forms.ToolStripSeparator
        Me.tslTitulo = New System.Windows.Forms.ToolStripLabel
        Me.bgwGifAnimado = New System.ComponentModel.BackgroundWorker
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.pcxEspera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(353, 154)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.AutoSize = True
        Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.ButtonSpecHeaderGroup1})
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup1.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.pcxEspera)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.UcDivision)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblDivision)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.GroupBox1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dteFechaInventario)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblFechaInventario)
        Me.KryptonHeaderGroup1.Panel.MinimumSize = New System.Drawing.Size(0, 120)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(353, 154)
        Me.KryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.TabIndex = 1
        Me.KryptonHeaderGroup1.Text = "Filtro"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Filtro"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'ButtonSpecHeaderGroup1
        '
        Me.ButtonSpecHeaderGroup1.ExtraText = ""
        Me.ButtonSpecHeaderGroup1.Image = Nothing
        Me.ButtonSpecHeaderGroup1.Text = ""
        Me.ButtonSpecHeaderGroup1.ToolTipImage = Nothing
        Me.ButtonSpecHeaderGroup1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp
        Me.ButtonSpecHeaderGroup1.UniqueName = "753CEA494AAC48DF753CEA494AAC48DF"
        '
        'pcxEspera
        '
        Me.pcxEspera.BackColor = System.Drawing.Color.Transparent
        Me.pcxEspera.Image = CType(resources.GetObject("pcxEspera.Image"), System.Drawing.Image)
        Me.pcxEspera.Location = New System.Drawing.Point(217, 64)
        Me.pcxEspera.Name = "pcxEspera"
        Me.pcxEspera.Size = New System.Drawing.Size(46, 37)
        Me.pcxEspera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcxEspera.TabIndex = 99
        Me.pcxEspera.TabStop = False
        Me.pcxEspera.Visible = False
        '
        'UcDivision
        '
        Me.UcDivision.BackColor = System.Drawing.Color.Transparent
        Me.UcDivision.CDVSN_ANTERIOR = Nothing
        Me.UcDivision.Compania = ""
        Me.UcDivision.Division = Nothing
        Me.UcDivision.DivisionDefault = Nothing
        Me.UcDivision.DivisionDescripcion = Nothing
        Me.UcDivision.ItemTodos = False
        Me.UcDivision.Location = New System.Drawing.Point(118, 35)
        Me.UcDivision.MinimumSize = New System.Drawing.Size(150, 21)
        Me.UcDivision.Name = "UcDivision"
        Me.UcDivision.pHabilitado = True
        Me.UcDivision.pRequerido = True
        Me.UcDivision.Size = New System.Drawing.Size(212, 23)
        Me.UcDivision.TabIndex = 98
        Me.UcDivision.Usuario = ""
        '
        'lblDivision
        '
        Me.lblDivision.Location = New System.Drawing.Point(54, 38)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Size = New System.Drawing.Size(60, 20)
        Me.lblDivision.TabIndex = 97
        Me.lblDivision.Text = "División :"
        Me.lblDivision.Values.ExtraText = ""
        Me.lblDivision.Values.Image = Nothing
        Me.lblDivision.Values.Text = "División :"
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.tsbCancelar, Me.ToolStripSeparator1, Me.tsbExportar, Me.ToolStripSeparator2, Me.ToolStripLabel2})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(351, 25)
        Me.tsMenuOpciones.TabIndex = 88
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(11, 22)
        Me.ToolStripLabel1.Tag = ""
        Me.ToolStripLabel1.Text = " "
        '
        'tsbCancelar
        '
        Me.tsbCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbCancelar.Image = Global.SOLMIN_CT.My.Resources.Resources._exit
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(73, 22)
        Me.tsbCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbExportar
        '
        Me.tsbExportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbExportar.Image = Global.SOLMIN_CT.My.Resources.Resources.icono_exp_excel
        Me.tsbExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportar.Name = "tsbExportar"
        Me.tsbExportar.Size = New System.Drawing.Size(70, 22)
        Me.tsbExportar.Text = "Exportar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(0, 22)
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.KryptonRadioButton1)
        Me.GroupBox1.Controls.Add(Me.rbtOrdenDeCompra)
        Me.GroupBox1.Controls.Add(Me.rbtItem)
        Me.GroupBox1.Location = New System.Drawing.Point(59, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(271, 45)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vista de reporte"
        '
        'KryptonRadioButton1
        '
        Me.KryptonRadioButton1.Location = New System.Drawing.Point(192, 16)
        Me.KryptonRadioButton1.Name = "KryptonRadioButton1"
        Me.KryptonRadioButton1.Size = New System.Drawing.Size(68, 20)
        Me.KryptonRadioButton1.TabIndex = 2
        Me.KryptonRadioButton1.Text = "SubItem"
        Me.KryptonRadioButton1.Values.ExtraText = ""
        Me.KryptonRadioButton1.Values.Image = Nothing
        Me.KryptonRadioButton1.Values.Text = "SubItem"
        '
        'rbtOrdenDeCompra
        '
        Me.rbtOrdenDeCompra.Location = New System.Drawing.Point(21, 16)
        Me.rbtOrdenDeCompra.Name = "rbtOrdenDeCompra"
        Me.rbtOrdenDeCompra.Size = New System.Drawing.Size(119, 20)
        Me.rbtOrdenDeCompra.TabIndex = 0
        Me.rbtOrdenDeCompra.Text = "Orden de compra"
        Me.rbtOrdenDeCompra.Values.ExtraText = ""
        Me.rbtOrdenDeCompra.Values.Image = Nothing
        Me.rbtOrdenDeCompra.Values.Text = "Orden de compra"
        '
        'rbtItem
        '
        Me.rbtItem.Checked = True
        Me.rbtItem.Location = New System.Drawing.Point(142, 16)
        Me.rbtItem.Name = "rbtItem"
        Me.rbtItem.Size = New System.Drawing.Size(47, 20)
        Me.rbtItem.TabIndex = 1
        Me.rbtItem.Text = "Item"
        Me.rbtItem.Values.ExtraText = ""
        Me.rbtItem.Values.Image = Nothing
        Me.rbtItem.Values.Text = "Item"
        '
        'dteFechaInventario
        '
        Me.dteFechaInventario.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaInventario.Location = New System.Drawing.Point(117, 66)
        Me.dteFechaInventario.Name = "dteFechaInventario"
        Me.dteFechaInventario.Size = New System.Drawing.Size(94, 20)
        Me.dteFechaInventario.TabIndex = 8
        '
        'lblFechaInventario
        '
        Me.lblFechaInventario.AutoSize = False
        Me.lblFechaInventario.Location = New System.Drawing.Point(5, 66)
        Me.lblFechaInventario.Name = "lblFechaInventario"
        Me.lblFechaInventario.Size = New System.Drawing.Size(116, 23)
        Me.lblFechaInventario.TabIndex = 7
        Me.lblFechaInventario.Text = "Fecha  Inventario :"
        Me.lblFechaInventario.Values.ExtraText = ""
        Me.lblFechaInventario.Values.Image = Nothing
        Me.lblFechaInventario.Values.Text = "Fecha  Inventario :"
        '
        'lblDestino
        '
        Me.lblDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestino.Name = "lblDestino"
        Me.lblDestino.Size = New System.Drawing.Size(11, 22)
        Me.lblDestino.Tag = ""
        Me.lblDestino.Text = " "
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(33, 22)
        Me.btnCancelar.Text = "Salir"
        '
        'tssSeparador1
        '
        Me.tssSeparador1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparador1.Name = "tssSeparador1"
        Me.tssSeparador1.Size = New System.Drawing.Size(6, 25)
        '
        'btnGuardar
        '
        Me.btnGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(54, 22)
        Me.btnGuardar.Text = "Exportar"
        '
        'tssSeparador2
        '
        Me.tssSeparador2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparador2.Name = "tssSeparador2"
        Me.tssSeparador2.Size = New System.Drawing.Size(6, 25)
        '
        'tslTitulo
        '
        Me.tslTitulo.Name = "tslTitulo"
        Me.tslTitulo.Size = New System.Drawing.Size(0, 22)
        '
        'bgwGifAnimado
        '
        '
        'frmStockAT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 154)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStockAT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Stock Almacén de Tránsito"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.pcxEspera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents ButtonSpecHeaderGroup1 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents KryptonRadioButton1 As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtOrdenDeCompra As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtItem As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents dteFechaInventario As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaInventario As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Private WithEvents lblDestino As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparador1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparador2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tslTitulo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents UcDivision As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Friend WithEvents lblDivision As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents pcxEspera As System.Windows.Forms.PictureBox
    Friend WithEvents bgwGifAnimado As System.ComponentModel.BackgroundWorker
End Class
