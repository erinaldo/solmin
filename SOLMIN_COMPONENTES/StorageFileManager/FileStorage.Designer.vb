<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileStorage
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FileStorage))
        Me.lstImagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.HGImages = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.btnAgregar1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.btnEliminarPopup = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.lstFiles = New System.Windows.Forms.ListView()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblArchivo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblTipoArchivo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblTamano = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblFecha = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonBorderEdge1 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge()
        Me.GrpDetalleArchivo = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.HGImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HGImages.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HGImages.Panel.SuspendLayout()
        Me.HGImages.SuspendLayout()
        Me.GrpDetalleArchivo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstImagenes
        '
        Me.lstImagenes.ImageStream = CType(resources.GetObject("lstImagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.lstImagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.lstImagenes.Images.SetKeyName(0, "word")
        Me.lstImagenes.Images.SetKeyName(1, "web")
        Me.lstImagenes.Images.SetKeyName(2, "image")
        Me.lstImagenes.Images.SetKeyName(3, "excel")
        Me.lstImagenes.Images.SetKeyName(4, "pdf")
        Me.lstImagenes.Images.SetKeyName(5, "filex")
        '
        'HGImages
        '
        Me.HGImages.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnAgregar1, Me.btnEliminarPopup})
        Me.HGImages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HGImages.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HGImages.Location = New System.Drawing.Point(0, 92)
        Me.HGImages.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.HGImages.Name = "HGImages"
        '
        'HGImages.Panel
        '
        Me.HGImages.Panel.Controls.Add(Me.lstFiles)
        Me.HGImages.Size = New System.Drawing.Size(724, 635)
        Me.HGImages.TabIndex = 4
        Me.HGImages.Text = "Listado de Archivos"
        Me.HGImages.ValuesPrimary.Description = ""
        Me.HGImages.ValuesPrimary.Heading = "Listado de Archivos"
        Me.HGImages.ValuesPrimary.Image = Global.StorageFileManager.My.Resources.Resources.txt1
        Me.HGImages.ValuesSecondary.Description = ""
        Me.HGImages.ValuesSecondary.Heading = "Description"
        Me.HGImages.ValuesSecondary.Image = Nothing
        '
        'btnAgregar1
        '
        Me.btnAgregar1.ExtraText = ""
        Me.btnAgregar1.Image = Global.StorageFileManager.My.Resources.Resources.db_add1
        Me.btnAgregar1.Text = "Agregar"
        Me.btnAgregar1.ToolTipImage = Nothing
        Me.btnAgregar1.UniqueName = "EE4AE31A2A67438CEE4AE31A2A67438C"
        '
        'btnEliminarPopup
        '
        Me.btnEliminarPopup.ExtraText = ""
        Me.btnEliminarPopup.Image = Global.StorageFileManager.My.Resources.Resources.db_remove1
        Me.btnEliminarPopup.Text = "Eliminar"
        Me.btnEliminarPopup.ToolTipImage = Nothing
        Me.btnEliminarPopup.UniqueName = "C84E23E41F814451C84E23E41F814451"
        '
        'lstFiles
        '
        Me.lstFiles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstFiles.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFiles.LargeImageList = Me.lstImagenes
        Me.lstFiles.Location = New System.Drawing.Point(0, 0)
        Me.lstFiles.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstFiles.MultiSelect = False
        Me.lstFiles.Name = "lstFiles"
        Me.lstFiles.Size = New System.Drawing.Size(722, 577)
        Me.lstFiles.SmallImageList = Me.lstImagenes
        Me.lstFiles.TabIndex = 1
        Me.lstFiles.UseCompatibleStateImageBehavior = False
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(67, 18)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(63, 24)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Text = "Archivo"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Archivo"
        '
        'lblArchivo
        '
        Me.lblArchivo.Location = New System.Drawing.Point(133, 18)
        Me.lblArchivo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblArchivo.Name = "lblArchivo"
        Me.lblArchivo.Size = New System.Drawing.Size(158, 24)
        Me.lblArchivo.TabIndex = 1
        Me.lblArchivo.Text = "[XXXXXXXXXXXXXXX]"
        Me.lblArchivo.Values.ExtraText = ""
        Me.lblArchivo.Values.Image = Nothing
        Me.lblArchivo.Values.Text = "[XXXXXXXXXXXXXXX]"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(67, 49)
        Me.KryptonLabel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(51, 24)
        Me.KryptonLabel4.TabIndex = 2
        Me.KryptonLabel4.Text = "Fecha"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Fecha"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(433, 49)
        Me.KryptonLabel6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(66, 24)
        Me.KryptonLabel6.TabIndex = 4
        Me.KryptonLabel6.Text = "Tamaño"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Tamaño"
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(427, 18)
        Me.KryptonLabel8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(119, 24)
        Me.KryptonLabel8.TabIndex = 6
        Me.KryptonLabel8.Text = "Tipo de Archivo"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Tipo de Archivo"
        '
        'lblTipoArchivo
        '
        Me.lblTipoArchivo.Location = New System.Drawing.Point(547, 18)
        Me.lblTipoArchivo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblTipoArchivo.Name = "lblTipoArchivo"
        Me.lblTipoArchivo.Size = New System.Drawing.Size(158, 24)
        Me.lblTipoArchivo.TabIndex = 7
        Me.lblTipoArchivo.Text = "[XXXXXXXXXXXXXXX]"
        Me.lblTipoArchivo.Values.ExtraText = ""
        Me.lblTipoArchivo.Values.Image = Nothing
        Me.lblTipoArchivo.Values.Text = "[XXXXXXXXXXXXXXX]"
        '
        'lblTamano
        '
        Me.lblTamano.Location = New System.Drawing.Point(553, 49)
        Me.lblTamano.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblTamano.Name = "lblTamano"
        Me.lblTamano.Size = New System.Drawing.Size(158, 24)
        Me.lblTamano.TabIndex = 8
        Me.lblTamano.Text = "[XXXXXXXXXXXXXXX]"
        Me.lblTamano.Values.ExtraText = ""
        Me.lblTamano.Values.Image = Nothing
        Me.lblTamano.Values.Text = "[XXXXXXXXXXXXXXX]"
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(133, 49)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(158, 24)
        Me.lblFecha.TabIndex = 9
        Me.lblFecha.Text = "[XXXXXXXXXXXXXXX]"
        Me.lblFecha.Values.ExtraText = ""
        Me.lblFecha.Values.Image = Nothing
        Me.lblFecha.Values.Text = "[XXXXXXXXXXXXXXX]"
        '
        'KryptonBorderEdge1
        '
        Me.KryptonBorderEdge1.Location = New System.Drawing.Point(407, 18)
        Me.KryptonBorderEdge1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonBorderEdge1.Name = "KryptonBorderEdge1"
        Me.KryptonBorderEdge1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge1.Size = New System.Drawing.Size(1, 62)
        Me.KryptonBorderEdge1.TabIndex = 11
        Me.KryptonBorderEdge1.Text = "KryptonBorderEdge1"
        '
        'GrpDetalleArchivo
        '
        Me.GrpDetalleArchivo.BackColor = System.Drawing.Color.White
        Me.GrpDetalleArchivo.Controls.Add(Me.KryptonBorderEdge1)
        Me.GrpDetalleArchivo.Controls.Add(Me.PictureBox1)
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
        Me.GrpDetalleArchivo.Location = New System.Drawing.Point(0, 0)
        Me.GrpDetalleArchivo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GrpDetalleArchivo.Name = "GrpDetalleArchivo"
        Me.GrpDetalleArchivo.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GrpDetalleArchivo.Size = New System.Drawing.Size(724, 92)
        Me.GrpDetalleArchivo.TabIndex = 3
        Me.GrpDetalleArchivo.TabStop = False
        Me.GrpDetalleArchivo.Text = "Información del Archivo"
        Me.GrpDetalleArchivo.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StorageFileManager.My.Resources.Resources.image
        Me.PictureBox1.Location = New System.Drawing.Point(20, 25)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'FileStorage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.HGImages)
        Me.Controls.Add(Me.GrpDetalleArchivo)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FileStorage"
        Me.Size = New System.Drawing.Size(724, 727)
        CType(Me.HGImages.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGImages.Panel.ResumeLayout(False)
        CType(Me.HGImages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGImages.ResumeLayout(False)
        Me.GrpDetalleArchivo.ResumeLayout(False)
        Me.GrpDetalleArchivo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstImagenes As System.Windows.Forms.ImageList
    Friend WithEvents HGImages As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents lstFiles As System.Windows.Forms.ListView
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblArchivo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTipoArchivo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTamano As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFecha As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents KryptonBorderEdge1 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents GrpDetalleArchivo As System.Windows.Forms.GroupBox
    Friend WithEvents btnEliminarPopup As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnAgregar1 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup

End Class
