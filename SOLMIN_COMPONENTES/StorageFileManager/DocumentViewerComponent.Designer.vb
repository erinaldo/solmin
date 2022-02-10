<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DocumentViewerComponent
    Inherits System.Windows.Forms.UserControl

    'UserControl1 reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DocumentViewerComponent))
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.dtg = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.Tipo = New System.Windows.Forms.DataGridViewImageColumn
        Me.IdFileX = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FileName = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
        Me.Browser = New System.Windows.Forms.WebBrowser
        Me.GrpDetalleArchivo = New System.Windows.Forms.GroupBox
        Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnAgregar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtNomberDir = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.NodeFolder = New System.Windows.Forms.TreeView
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lblFecha = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblTamano = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblTipoArchivo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblArchivo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ToolBarComponent = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnSeleccionar = New System.Windows.Forms.ToolStripButton
        Me.btnguardar = New System.Windows.Forms.ToolStripButton
        Me.Refrescar = New System.Windows.Forms.ToolStripButton
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel2.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpDetalleArchivo.SuspendLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup2.Panel.SuspendLayout()
        Me.KryptonHeaderGroup2.SuspendLayout()
        Me.ToolBarComponent.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(821, 587)
        Me.KryptonPanel1.TabIndex = 0
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup1.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonPanel2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.GrpDetalleArchivo)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.ToolBarComponent)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(821, 587)
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.Text = "Administración de Almacenamiento de Archivos"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Administración de Almacenamiento de Archivos"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Global.StorageFileManager.My.Resources.Resources.kedit
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Solmin"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'KryptonPanel2
        '
        Me.KryptonPanel2.Controls.Add(Me.KryptonSplitContainer1)
        Me.KryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel2.Location = New System.Drawing.Point(0, 90)
        Me.KryptonPanel2.Name = "KryptonPanel2"
        Me.KryptonPanel2.Size = New System.Drawing.Size(819, 450)
        Me.KryptonPanel2.TabIndex = 1
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.AutoScroll = True
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.dtg)
        Me.KryptonSplitContainer1.Panel1MinSize = 305
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.Browser)
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(819, 450)
        Me.KryptonSplitContainer1.SplitterDistance = 305
        Me.KryptonSplitContainer1.TabIndex = 0
        '
        'dtg
        '
        Me.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tipo, Me.IdFileX, Me.FileName})
        Me.dtg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtg.Location = New System.Drawing.Point(0, 0)
        Me.dtg.Name = "dtg"
        Me.dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg.Size = New System.Drawing.Size(305, 450)
        Me.dtg.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtg.TabIndex = 0
        '
        'Tipo
        '
        Me.Tipo.DataPropertyName = "FileIcon"
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Width = 50
        '
        'IdFileX
        '
        Me.IdFileX.DataPropertyName = "IdFileX"
        Me.IdFileX.HeaderText = "IdFileX"
        Me.IdFileX.Name = "IdFileX"
        Me.IdFileX.Visible = False
        '
        'FileName
        '
        Me.FileName.DataPropertyName = "FileName"
        Me.FileName.HeaderText = "Nombre del Archivo"
        Me.FileName.Name = "FileName"
        Me.FileName.ReadOnly = True
        Me.FileName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FileName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.FileName.Width = 200
        '
        'Browser
        '
        Me.Browser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Browser.Location = New System.Drawing.Point(0, 0)
        Me.Browser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Browser.Name = "Browser"
        Me.Browser.Size = New System.Drawing.Size(509, 450)
        Me.Browser.TabIndex = 0
        '
        'GrpDetalleArchivo
        '
        Me.GrpDetalleArchivo.BackColor = System.Drawing.Color.Transparent
        Me.GrpDetalleArchivo.Controls.Add(Me.PictureBox1)
        Me.GrpDetalleArchivo.Controls.Add(Me.KryptonHeaderGroup2)
        Me.GrpDetalleArchivo.Controls.Add(Me.lblFecha)
        Me.GrpDetalleArchivo.Controls.Add(Me.lblTamano)
        Me.GrpDetalleArchivo.Controls.Add(Me.lblTipoArchivo)
        Me.GrpDetalleArchivo.Controls.Add(Me.KryptonLabel8)
        Me.GrpDetalleArchivo.Controls.Add(Me.KryptonLabel6)
        Me.GrpDetalleArchivo.Controls.Add(Me.KryptonLabel4)
        Me.GrpDetalleArchivo.Controls.Add(Me.lblArchivo)
        Me.GrpDetalleArchivo.Controls.Add(Me.KryptonLabel1)
        Me.GrpDetalleArchivo.Dock = System.Windows.Forms.DockStyle.Top
        Me.GrpDetalleArchivo.ForeColor = System.Drawing.Color.SteelBlue
        Me.GrpDetalleArchivo.Location = New System.Drawing.Point(0, 25)
        Me.GrpDetalleArchivo.Name = "GrpDetalleArchivo"
        Me.GrpDetalleArchivo.Size = New System.Drawing.Size(819, 65)
        Me.GrpDetalleArchivo.TabIndex = 2
        Me.GrpDetalleArchivo.TabStop = False
        Me.GrpDetalleArchivo.Text = "Información del Archivo"
        '
        'KryptonHeaderGroup2
        '
        Me.KryptonHeaderGroup2.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(755, 20)
        Me.KryptonHeaderGroup2.Name = "KryptonHeaderGroup2"
        '
        'KryptonHeaderGroup2.Panel
        '
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.btnAgregar)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.txtNomberDir)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.NodeFolder)
        Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(59, 30)
        Me.KryptonHeaderGroup2.TabIndex = 2
        Me.KryptonHeaderGroup2.Text = "Listado de Carpetas"
        Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Heading = "Listado de Carpetas"
        Me.KryptonHeaderGroup2.ValuesPrimary.Image = Global.StorageFileManager.My.Resources.Resources.txt1
        Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Heading = " Listado de Archivos en la Carpeta Seleccionada"
        Me.KryptonHeaderGroup2.ValuesSecondary.Image = Nothing
        Me.KryptonHeaderGroup2.Visible = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(280, 5)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(120, 25)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = "Guardar Carpeta"
        Me.btnAgregar.Values.ExtraText = ""
        Me.btnAgregar.Values.Image = Nothing
        Me.btnAgregar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAgregar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAgregar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAgregar.Values.Text = "Guardar Carpeta"
        '
        'txtNomberDir
        '
        Me.txtNomberDir.Location = New System.Drawing.Point(125, 10)
        Me.txtNomberDir.Name = "txtNomberDir"
        Me.txtNomberDir.Size = New System.Drawing.Size(145, 21)
        Me.txtNomberDir.TabIndex = 2
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(10, 10)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(109, 19)
        Me.KryptonLabel2.TabIndex = 1
        Me.KryptonLabel2.Text = "Nombre de Carpeta"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Nombre de Carpeta"
        '
        'NodeFolder
        '
        Me.NodeFolder.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NodeFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NodeFolder.ImageIndex = 0
        Me.NodeFolder.ImageList = Me.ImageList1
        Me.NodeFolder.Location = New System.Drawing.Point(10, 40)
        Me.NodeFolder.Name = "NodeFolder"
        Me.NodeFolder.SelectedImageIndex = 0
        Me.NodeFolder.Size = New System.Drawing.Size(40, 168)
        Me.NodeFolder.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "fileopen.png")
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(285, 30)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(6, 2)
        Me.lblFecha.TabIndex = 9
        Me.lblFecha.Values.ExtraText = ""
        Me.lblFecha.Values.Image = Nothing
        Me.lblFecha.Values.Text = ""
        '
        'lblTamano
        '
        Me.lblTamano.Location = New System.Drawing.Point(435, 30)
        Me.lblTamano.Name = "lblTamano"
        Me.lblTamano.Size = New System.Drawing.Size(6, 2)
        Me.lblTamano.TabIndex = 8
        Me.lblTamano.Values.ExtraText = ""
        Me.lblTamano.Values.Image = Nothing
        Me.lblTamano.Values.Text = ""
        '
        'lblTipoArchivo
        '
        Me.lblTipoArchivo.Location = New System.Drawing.Point(630, 30)
        Me.lblTipoArchivo.Name = "lblTipoArchivo"
        Me.lblTipoArchivo.Size = New System.Drawing.Size(6, 2)
        Me.lblTipoArchivo.TabIndex = 7
        Me.lblTipoArchivo.Values.ExtraText = ""
        Me.lblTipoArchivo.Values.Image = Nothing
        Me.lblTipoArchivo.Values.Text = ""
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(545, 30)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(89, 19)
        Me.KryptonLabel8.TabIndex = 6
        Me.KryptonLabel8.Text = "Tipo de Archivo"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Tipo de Archivo"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(380, 30)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(50, 19)
        Me.KryptonLabel6.TabIndex = 4
        Me.KryptonLabel6.Text = "Tamaño"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Tamaño"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(250, 30)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(39, 19)
        Me.KryptonLabel4.TabIndex = 2
        Me.KryptonLabel4.Text = "Fecha"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Fecha"
        '
        'lblArchivo
        '
        Me.lblArchivo.Location = New System.Drawing.Point(100, 30)
        Me.lblArchivo.Name = "lblArchivo"
        Me.lblArchivo.Size = New System.Drawing.Size(6, 2)
        Me.lblArchivo.TabIndex = 1
        Me.lblArchivo.Values.ExtraText = ""
        Me.lblArchivo.Values.Image = Nothing
        Me.lblArchivo.Values.Text = ""
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(55, 30)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(48, 19)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Text = "Archivo"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Archivo"
        '
        'ToolBarComponent
        '
        Me.ToolBarComponent.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolBarComponent.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSeleccionar, Me.ToolStripSeparator1, Me.btnguardar, Me.ToolStripSeparator3, Me.Refrescar, Me.ToolStripSeparator2, Me.btnEliminar})
        Me.ToolBarComponent.Location = New System.Drawing.Point(0, 0)
        Me.ToolBarComponent.Name = "ToolBarComponent"
        Me.ToolBarComponent.Size = New System.Drawing.Size(819, 25)
        Me.ToolBarComponent.TabIndex = 0
        Me.ToolBarComponent.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StorageFileManager.My.Resources.Resources.image
        Me.PictureBox1.Location = New System.Drawing.Point(15, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Image = Global.StorageFileManager.My.Resources.Resources.fileopen
        Me.btnSeleccionar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(85, 22)
        Me.btnSeleccionar.Text = "Seleccionar"
        '
        'btnguardar
        '
        Me.btnguardar.Image = Global.StorageFileManager.My.Resources.Resources.save_all
        Me.btnguardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(69, 22)
        Me.btnguardar.Text = "Guardar"
        '
        'Refrescar
        '
        Me.Refrescar.Image = Global.StorageFileManager.My.Resources.Resources.recur
        Me.Refrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Refrescar.Name = "Refrescar"
        Me.Refrescar.Size = New System.Drawing.Size(77, 22)
        Me.Refrescar.Text = "Actualizar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.StorageFileManager.My.Resources.Resources.mail_delete
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(68, 22)
        Me.btnEliminar.Text = "Eliminar"
        '
        'DocumentViewerComponent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Name = "DocumentViewerComponent"
        Me.Size = New System.Drawing.Size(821, 587)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpDetalleArchivo.ResumeLayout(False)
        Me.GrpDetalleArchivo.PerformLayout()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup2.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.ResumeLayout(False)
        Me.ToolBarComponent.ResumeLayout(False)
        Me.ToolBarComponent.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ToolBarComponent As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSeleccionar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnguardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents Browser As System.Windows.Forms.WebBrowser
    Friend WithEvents GrpDetalleArchivo As System.Windows.Forms.GroupBox
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblArchivo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblFecha As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTamano As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTipoArchivo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents KryptonHeaderGroup2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnAgregar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtNomberDir As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents NodeFolder As System.Windows.Forms.TreeView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents dtg As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents IdFileX As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FileName As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Refrescar As System.Windows.Forms.ToolStripButton

End Class
