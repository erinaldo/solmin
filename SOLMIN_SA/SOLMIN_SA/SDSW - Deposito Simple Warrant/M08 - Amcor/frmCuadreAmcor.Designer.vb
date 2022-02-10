<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuadreAmcor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCuadreAmcor))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.khgConsulta = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnActualizar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.khgSalidas = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.dgvSalidas = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.khgIngresos = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.dgvIngresos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.DtCuadre = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.khgConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgConsulta.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.khgConsulta.Panel.SuspendLayout()
        Me.khgConsulta.SuspendLayout()
        CType(Me.khgSalidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgSalidas.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.khgSalidas.Panel.SuspendLayout()
        Me.khgSalidas.SuspendLayout()
        CType(Me.dgvSalidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgIngresos.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.khgIngresos.Panel.SuspendLayout()
        Me.khgIngresos.SuspendLayout()
        CType(Me.dgvIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtCuadre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.khgConsulta)
        Me.KryptonPanel.Controls.Add(Me.khgSalidas)
        Me.KryptonPanel.Controls.Add(Me.khgIngresos)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(768, 548)
        Me.KryptonPanel.TabIndex = 0
        '
        'khgConsulta
        '
        Me.khgConsulta.HeaderVisibleSecondary = False
        Me.khgConsulta.Location = New System.Drawing.Point(0, 3)
        Me.khgConsulta.Name = "khgConsulta"
        '
        'khgConsulta.Panel
        '
        Me.khgConsulta.Panel.Controls.Add(Me.btnActualizar)
        Me.khgConsulta.Panel.Controls.Add(Me.DateTimePicker1)
        Me.khgConsulta.Panel.Controls.Add(Me.KryptonLabel1)
        Me.khgConsulta.Size = New System.Drawing.Size(765, 104)
        Me.khgConsulta.TabIndex = 2
        Me.khgConsulta.Text = "Consulta"
        Me.khgConsulta.ValuesPrimary.Description = ""
        Me.khgConsulta.ValuesPrimary.Heading = "Consulta"
        Me.khgConsulta.ValuesPrimary.Image = CType(resources.GetObject("khgConsulta.ValuesPrimary.Image"), System.Drawing.Image)
        Me.khgConsulta.ValuesSecondary.Description = ""
        Me.khgConsulta.ValuesSecondary.Heading = "Description"
        Me.khgConsulta.ValuesSecondary.Image = Nothing
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.Location = New System.Drawing.Point(683, 3)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(77, 65)
        Me.btnActualizar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnActualizar.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnActualizar.TabIndex = 73
        Me.btnActualizar.Text = "&Procesar"
        Me.btnActualizar.Values.ExtraText = "Consulta"
        Me.btnActualizar.Values.Image = CType(resources.GetObject("btnActualizar.Values.Image"), System.Drawing.Image)
        Me.btnActualizar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnActualizar.Values.Text = "&Procesar"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(65, 14)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(86, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(18, 15)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(41, 19)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Text = "Fecha:"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Fecha:"
        '
        'khgSalidas
        '
        Me.khgSalidas.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.khgSalidas.HeaderVisibleSecondary = False
        Me.khgSalidas.Location = New System.Drawing.Point(0, 367)
        Me.khgSalidas.Name = "khgSalidas"
        '
        'khgSalidas.Panel
        '
        Me.khgSalidas.Panel.Controls.Add(Me.dgvSalidas)
        Me.khgSalidas.Size = New System.Drawing.Size(768, 181)
        Me.khgSalidas.TabIndex = 1
        Me.khgSalidas.Text = "Salidas"
        Me.khgSalidas.ValuesPrimary.Description = ""
        Me.khgSalidas.ValuesPrimary.Heading = "Salidas"
        Me.khgSalidas.ValuesPrimary.Image = CType(resources.GetObject("khgSalidas.ValuesPrimary.Image"), System.Drawing.Image)
        Me.khgSalidas.ValuesSecondary.Description = ""
        Me.khgSalidas.ValuesSecondary.Heading = "Description"
        Me.khgSalidas.ValuesSecondary.Image = Nothing
        '
        'dgvSalidas
        '
        Me.dgvSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalidas.Location = New System.Drawing.Point(11, 15)
        Me.dgvSalidas.Name = "dgvSalidas"
        Me.dgvSalidas.Size = New System.Drawing.Size(744, 89)
        Me.dgvSalidas.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvSalidas.TabIndex = 0
        '
        'khgIngresos
        '
        Me.khgIngresos.HeaderVisibleSecondary = False
        Me.khgIngresos.Location = New System.Drawing.Point(3, 200)
        Me.khgIngresos.Name = "khgIngresos"
        '
        'khgIngresos.Panel
        '
        Me.khgIngresos.Panel.Controls.Add(Me.dgvIngresos)
        Me.khgIngresos.Size = New System.Drawing.Size(750, 161)
        Me.khgIngresos.TabIndex = 0
        Me.khgIngresos.Text = "Ingresos"
        Me.khgIngresos.ValuesPrimary.Description = ""
        Me.khgIngresos.ValuesPrimary.Heading = "Ingresos"
        Me.khgIngresos.ValuesPrimary.Image = CType(resources.GetObject("khgIngresos.ValuesPrimary.Image"), System.Drawing.Image)
        Me.khgIngresos.ValuesSecondary.Description = ""
        Me.khgIngresos.ValuesSecondary.Heading = "Description"
        Me.khgIngresos.ValuesSecondary.Image = Nothing
        '
        'dgvIngresos
        '
        Me.dgvIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIngresos.Location = New System.Drawing.Point(8, 3)
        Me.dgvIngresos.Name = "dgvIngresos"
        Me.dgvIngresos.Size = New System.Drawing.Size(737, 101)
        Me.dgvIngresos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvIngresos.TabIndex = 0
        '
        'DtCuadre
        '
        Me.DtCuadre.DataSetName = "NewDataSet"
        Me.DtCuadre.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5})
        Me.DataTable1.TableName = "dtIngresos"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "NGUIIN"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "CETQWR"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "CARTC"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "NORDS1"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "ISLDFS"
        '
        'frmCuadreAmcor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 548)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmCuadreAmcor"
        Me.Text = "Cuadre Amcor"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.khgConsulta.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgConsulta.Panel.ResumeLayout(False)
        Me.khgConsulta.Panel.PerformLayout()
        CType(Me.khgConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgConsulta.ResumeLayout(False)
        CType(Me.khgSalidas.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgSalidas.Panel.ResumeLayout(False)
        CType(Me.khgSalidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgSalidas.ResumeLayout(False)
        CType(Me.dgvSalidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.khgIngresos.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgIngresos.Panel.ResumeLayout(False)
        CType(Me.khgIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgIngresos.ResumeLayout(False)
        CType(Me.dgvIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtCuadre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents khgSalidas As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents khgIngresos As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents khgConsulta As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dgvSalidas As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dgvIngresos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btnActualizar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents DtCuadre As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
End Class
