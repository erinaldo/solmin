<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultiUploader
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
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.BtnQuitar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.EntityFileStorageDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntityFileStorageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnGuardar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnSeleccionar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.EntityFileStorageDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EntityFileStorageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.BtnQuitar})
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup1.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.AutoScroll = True
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.EntityFileStorageDataGridView)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonButton1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.btnGuardar)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.btnSeleccionar)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(625, 302)
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.Text = "Guardar Archivos"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Guardar Archivos"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Global.StorageFileManager.My.Resources.Resources.txt1
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = " "
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'BtnQuitar
        '
        Me.BtnQuitar.ExtraText = ""
        Me.BtnQuitar.Image = Global.StorageFileManager.My.Resources.Resources.db_remove1
        Me.BtnQuitar.Text = "Eliminar"
        Me.BtnQuitar.ToolTipImage = Nothing
        Me.BtnQuitar.UniqueName = "CC9FFBDD10BB469FCC9FFBDD10BB469F"
        '
        'EntityFileStorageDataGridView
        '
        Me.EntityFileStorageDataGridView.AllowUserToAddRows = False
        Me.EntityFileStorageDataGridView.AllowUserToDeleteRows = False
        Me.EntityFileStorageDataGridView.AutoGenerateColumns = False
        Me.EntityFileStorageDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.EntityFileStorageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EntityFileStorageDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn1})
        Me.EntityFileStorageDataGridView.DataSource = Me.EntityFileStorageBindingSource
        Me.EntityFileStorageDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.EntityFileStorageDataGridView.Name = "EntityFileStorageDataGridView"
        Me.EntityFileStorageDataGridView.ReadOnly = True
        Me.EntityFileStorageDataGridView.RowHeadersVisible = False
        Me.EntityFileStorageDataGridView.RowTemplate.Height = 24
        Me.EntityFileStorageDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EntityFileStorageDataGridView.Size = New System.Drawing.Size(614, 190)
        Me.EntityFileStorageDataGridView.TabIndex = 23
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Archivo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Archivo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 76
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TipoArchivo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 65
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Tamanho"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tamaño"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 89
        '
        'EntityFileStorageBindingSource
        '
        Me.EntityFileStorageBindingSource.DataSource = GetType(StorageFileManager.Classes.EntityFileStorage)
        '
        'KryptonButton1
        '
        Me.KryptonButton1.Location = New System.Drawing.Point(471, 200)
        Me.KryptonButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonButton1.Name = "KryptonButton1"
        Me.KryptonButton1.Size = New System.Drawing.Size(127, 37)
        Me.KryptonButton1.TabIndex = 23
        Me.KryptonButton1.Text = "Cancelar"
        Me.KryptonButton1.Values.ExtraText = ""
        Me.KryptonButton1.Values.Image = Global.StorageFileManager.My.Resources.Resources._stop
        Me.KryptonButton1.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.KryptonButton1.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.KryptonButton1.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.KryptonButton1.Values.Text = "Cancelar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(318, 200)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(133, 37)
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
        Me.btnSeleccionar.Location = New System.Drawing.Point(171, 200)
        Me.btnSeleccionar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(127, 37)
        Me.btnSeleccionar.TabIndex = 21
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.Values.ExtraText = ""
        Me.btnSeleccionar.Values.Image = Global.StorageFileManager.My.Resources.Resources.search
        Me.btnSeleccionar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnSeleccionar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnSeleccionar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnSeleccionar.Values.Text = "Seleccionar"
        '
        'MultiUploader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonHeaderGroup1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MultiUploader"
        Me.Size = New System.Drawing.Size(625, 302)
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.EntityFileStorageDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EntityFileStorageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnGuardar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnSeleccionar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents EntityFileStorageDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents EntityFileStorageBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnQuitar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup

End Class
