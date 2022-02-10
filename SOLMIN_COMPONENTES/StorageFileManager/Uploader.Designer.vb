<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Uploader
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
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.KryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnGuardar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnSeleccionar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblFecha = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblTamano = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblTipoArchivo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblArchivo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonButton1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.btnGuardar)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.btnSeleccionar)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.PictureBox1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblFecha)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblTamano)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblTipoArchivo)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel8)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel6)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblArchivo)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(391, 200)
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.Text = "Guardar Archivos"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Guardar Archivos"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Global.StorageFileManager.My.Resources.Resources.txt1
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = " "
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'KryptonButton1
        '
        Me.KryptonButton1.Location = New System.Drawing.Point(280, 120)
        Me.KryptonButton1.Name = "KryptonButton1"
        Me.KryptonButton1.Size = New System.Drawing.Size(95, 30)
        Me.KryptonButton1.TabIndex = 23
        Me.KryptonButton1.Text = "Salir"
        Me.KryptonButton1.Values.ExtraText = ""
        Me.KryptonButton1.Values.Image = Global.StorageFileManager.My.Resources.Resources._stop
        Me.KryptonButton1.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.KryptonButton1.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.KryptonButton1.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.KryptonButton1.Values.Text = "Salir"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(165, 120)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(100, 30)
        Me.btnGuardar.TabIndex = 22
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.Values.ExtraText = ""
        Me.btnGuardar.Values.Image = Global.StorageFileManager.My.Resources.Resources.apply
        Me.btnGuardar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnGuardar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnGuardar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnGuardar.Values.Text = "Guardar"
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Location = New System.Drawing.Point(55, 120)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(95, 30)
        Me.btnSeleccionar.TabIndex = 21
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.Values.ExtraText = ""
        Me.btnSeleccionar.Values.Image = Global.StorageFileManager.My.Resources.Resources.search
        Me.btnSeleccionar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnSeleccionar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnSeleccionar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnSeleccionar.Values.Text = "Seleccionar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StorageFileManager.My.Resources.Resources.image
        Me.PictureBox1.Location = New System.Drawing.Point(10, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(105, 40)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(10, 19)
        Me.lblFecha.TabIndex = 19
        Me.lblFecha.Text = " "
        Me.lblFecha.Values.ExtraText = ""
        Me.lblFecha.Values.Image = Nothing
        Me.lblFecha.Values.Text = " "
        '
        'lblTamano
        '
        Me.lblTamano.Location = New System.Drawing.Point(110, 90)
        Me.lblTamano.Name = "lblTamano"
        Me.lblTamano.Size = New System.Drawing.Size(10, 19)
        Me.lblTamano.TabIndex = 18
        Me.lblTamano.Text = " "
        Me.lblTamano.Values.ExtraText = ""
        Me.lblTamano.Values.Image = Nothing
        Me.lblTamano.Values.Text = " "
        '
        'lblTipoArchivo
        '
        Me.lblTipoArchivo.Location = New System.Drawing.Point(145, 65)
        Me.lblTipoArchivo.Name = "lblTipoArchivo"
        Me.lblTipoArchivo.Size = New System.Drawing.Size(10, 19)
        Me.lblTipoArchivo.TabIndex = 17
        Me.lblTipoArchivo.Text = " "
        Me.lblTipoArchivo.Values.ExtraText = ""
        Me.lblTipoArchivo.Values.Image = Nothing
        Me.lblTipoArchivo.Values.Text = " "
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(55, 65)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(89, 19)
        Me.KryptonLabel8.TabIndex = 16
        Me.KryptonLabel8.Text = "Tipo de Archivo"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Tipo de Archivo"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(55, 90)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(50, 19)
        Me.KryptonLabel6.TabIndex = 15
        Me.KryptonLabel6.Text = "Tamaño"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Tamaño"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(55, 40)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(39, 19)
        Me.KryptonLabel4.TabIndex = 14
        Me.KryptonLabel4.Text = "Fecha"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Fecha"
        '
        'lblArchivo
        '
        Me.lblArchivo.Location = New System.Drawing.Point(105, 15)
        Me.lblArchivo.Name = "lblArchivo"
        Me.lblArchivo.Size = New System.Drawing.Size(10, 19)
        Me.lblArchivo.TabIndex = 13
        Me.lblArchivo.Text = " "
        Me.lblArchivo.Values.ExtraText = ""
        Me.lblArchivo.Values.Image = Nothing
        Me.lblArchivo.Values.Text = " "
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(55, 15)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(48, 19)
        Me.KryptonLabel1.TabIndex = 12
        Me.KryptonLabel1.Text = "Archivo"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Archivo"
        '
        'Uploader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonHeaderGroup1)
        Me.Name = "Uploader"
        Me.Size = New System.Drawing.Size(391, 200)
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnGuardar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnSeleccionar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblFecha As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTamano As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTipoArchivo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblArchivo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton

End Class
