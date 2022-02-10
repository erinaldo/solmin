<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimientoAT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovimientoAT))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.ButtonSpecHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbtSubitem = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.rbtOrdenDeCompra = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.rbtItem = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbExportar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.dteFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.dteFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.lblFechaFinal = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFechaInicial = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.pcxEspera = New System.Windows.Forms.PictureBox
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.bgwGifAnimado = New System.ComponentModel.BackgroundWorker
        Me.UcDivision = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
        Me.lblDivision = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.pcxEspera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(347, 170)
        Me.KryptonPanel.TabIndex = 1
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
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.UcDivision)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblDivision)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.GroupBox1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dteFechaFinal)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dteFechaInicial)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblFechaFinal)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblFechaInicial)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.pcxEspera)
        Me.KryptonHeaderGroup1.Panel.MinimumSize = New System.Drawing.Size(0, 80)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(347, 170)
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbtSubitem)
        Me.GroupBox1.Controls.Add(Me.rbtOrdenDeCompra)
        Me.GroupBox1.Controls.Add(Me.rbtItem)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 45)
        Me.GroupBox1.TabIndex = 105
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vista de reporte"
        '
        'rbtSubitem
        '
        Me.rbtSubitem.Location = New System.Drawing.Point(188, 16)
        Me.rbtSubitem.Name = "rbtSubitem"
        Me.rbtSubitem.Size = New System.Drawing.Size(73, 20)
        Me.rbtSubitem.TabIndex = 2
        Me.rbtSubitem.Text = "SubItems"
        Me.rbtSubitem.Values.ExtraText = ""
        Me.rbtSubitem.Values.Image = Nothing
        Me.rbtSubitem.Values.Text = "SubItems"
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
        Me.rbtItem.Location = New System.Drawing.Point(137, 16)
        Me.rbtItem.Name = "rbtItem"
        Me.rbtItem.Size = New System.Drawing.Size(47, 20)
        Me.rbtItem.TabIndex = 1
        Me.rbtItem.Text = "Item"
        Me.rbtItem.Values.ExtraText = ""
        Me.rbtItem.Values.Image = Nothing
        Me.rbtItem.Values.Text = "Item"
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.tsbCancelar, Me.ToolStripSeparator1, Me.tsbExportar, Me.ToolStripSeparator2, Me.ToolStripLabel2})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(345, 25)
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
        'dteFechaFinal
        '
        Me.dteFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaFinal.Location = New System.Drawing.Point(122, 82)
        Me.dteFechaFinal.Name = "dteFechaFinal"
        Me.dteFechaFinal.Size = New System.Drawing.Size(94, 20)
        Me.dteFechaFinal.TabIndex = 102
        '
        'dteFechaInicial
        '
        Me.dteFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaInicial.Location = New System.Drawing.Point(122, 57)
        Me.dteFechaInicial.Name = "dteFechaInicial"
        Me.dteFechaInicial.Size = New System.Drawing.Size(94, 20)
        Me.dteFechaInicial.TabIndex = 101
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.Location = New System.Drawing.Point(39, 82)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(77, 20)
        Me.lblFechaFinal.TabIndex = 104
        Me.lblFechaFinal.Text = "Fecha Final : "
        Me.lblFechaFinal.Values.ExtraText = ""
        Me.lblFechaFinal.Values.Image = Nothing
        Me.lblFechaFinal.Values.Text = "Fecha Final : "
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.Location = New System.Drawing.Point(35, 56)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(81, 20)
        Me.lblFechaInicial.TabIndex = 103
        Me.lblFechaInicial.Text = "Fecha Inicio : "
        Me.lblFechaInicial.Values.ExtraText = ""
        Me.lblFechaInicial.Values.Image = Nothing
        Me.lblFechaInicial.Values.Text = "Fecha Inicio : "
        '
        'pcxEspera
        '
        Me.pcxEspera.BackColor = System.Drawing.Color.Transparent
        Me.pcxEspera.Image = CType(resources.GetObject("pcxEspera.Image"), System.Drawing.Image)
        Me.pcxEspera.Location = New System.Drawing.Point(233, 57)
        Me.pcxEspera.Name = "pcxEspera"
        Me.pcxEspera.Size = New System.Drawing.Size(47, 45)
        Me.pcxEspera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcxEspera.TabIndex = 100
        Me.pcxEspera.TabStop = False
        Me.pcxEspera.Visible = False
        '
        'bgwGifAnimado
        '
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
        Me.UcDivision.Location = New System.Drawing.Point(122, 29)
        Me.UcDivision.MinimumSize = New System.Drawing.Size(150, 21)
        Me.UcDivision.Name = "UcDivision"
        Me.UcDivision.pHabilitado = True
        Me.UcDivision.pRequerido = True
        Me.UcDivision.Size = New System.Drawing.Size(212, 23)
        Me.UcDivision.TabIndex = 107
        Me.UcDivision.Usuario = ""
        '
        'lblDivision
        '
        Me.lblDivision.Location = New System.Drawing.Point(56, 31)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Size = New System.Drawing.Size(60, 20)
        Me.lblDivision.TabIndex = 106
        Me.lblDivision.Text = "División :"
        Me.lblDivision.Values.ExtraText = ""
        Me.lblDivision.Values.Image = Nothing
        Me.lblDivision.Values.Text = "División :"
        '
        'frmMovimientoAT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 170)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMovimientoAT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Movimiento Almacén Simple"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        CType(Me.pcxEspera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ButtonSpecHeaderGroup1 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dteFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dteFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFinal As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFechaInicial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents pcxEspera As System.Windows.Forms.PictureBox
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents bgwGifAnimado As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtSubitem As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtOrdenDeCompra As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtItem As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents UcDivision As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Friend WithEvents lblDivision As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
