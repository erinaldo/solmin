<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerUnidadesProgramadas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.kgvUnidadProgramada = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.DataGridViewTextBoxColumn65 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn66 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FPLNJT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HPLNJT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TRSPAT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QCNASI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QANPRG_JUNTA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn67 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDSCPL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn68 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn69 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn70 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.kgvUnidadProgramada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'kgvUnidadProgramada
        '
        Me.kgvUnidadProgramada.AllowUserToAddRows = False
        Me.kgvUnidadProgramada.AllowUserToDeleteRows = False
        Me.kgvUnidadProgramada.AllowUserToOrderColumns = True
        Me.kgvUnidadProgramada.AllowUserToResizeRows = False
        Me.kgvUnidadProgramada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.kgvUnidadProgramada.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.kgvUnidadProgramada.ColumnHeadersHeight = 30
        Me.kgvUnidadProgramada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.kgvUnidadProgramada.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn65, Me.DataGridViewTextBoxColumn66, Me.FPLNJT, Me.HPLNJT, Me.TRSPAT, Me.QCNASI, Me.QANPRG_JUNTA, Me.DataGridViewTextBoxColumn67, Me.TDSCPL, Me.DataGridViewTextBoxColumn68, Me.DataGridViewTextBoxColumn69, Me.DataGridViewTextBoxColumn70})
        Me.kgvUnidadProgramada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kgvUnidadProgramada.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.kgvUnidadProgramada.Location = New System.Drawing.Point(0, 0)
        Me.kgvUnidadProgramada.MultiSelect = False
        Me.kgvUnidadProgramada.Name = "kgvUnidadProgramada"
        Me.kgvUnidadProgramada.ReadOnly = True
        Me.kgvUnidadProgramada.RowHeadersVisible = False
        Me.kgvUnidadProgramada.RowHeadersWidth = 20
        Me.kgvUnidadProgramada.RowTemplate.Height = 16
        Me.kgvUnidadProgramada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.kgvUnidadProgramada.Size = New System.Drawing.Size(1004, 195)
        Me.kgvUnidadProgramada.StandardTab = True
        Me.kgvUnidadProgramada.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.kgvUnidadProgramada.TabIndex = 10
        '
        'DataGridViewTextBoxColumn65
        '
        Me.DataGridViewTextBoxColumn65.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn65.DataPropertyName = "NPLNJT"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DataGridViewTextBoxColumn65.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn65.HeaderText = "N° Junta"
        Me.DataGridViewTextBoxColumn65.MaxInputLength = 15
        Me.DataGridViewTextBoxColumn65.Name = "DataGridViewTextBoxColumn65"
        Me.DataGridViewTextBoxColumn65.ReadOnly = True
        Me.DataGridViewTextBoxColumn65.Width = 81
        '
        'DataGridViewTextBoxColumn66
        '
        Me.DataGridViewTextBoxColumn66.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn66.DataPropertyName = "NCRRPL"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DataGridViewTextBoxColumn66.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn66.HeaderText = "N° Correlativo"
        Me.DataGridViewTextBoxColumn66.MaxInputLength = 10
        Me.DataGridViewTextBoxColumn66.Name = "DataGridViewTextBoxColumn66"
        Me.DataGridViewTextBoxColumn66.ReadOnly = True
        Me.DataGridViewTextBoxColumn66.Width = 111
        '
        'FPLNJT
        '
        Me.FPLNJT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FPLNJT.DataPropertyName = "FPLNJT"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.FPLNJT.DefaultCellStyle = DataGridViewCellStyle3
        Me.FPLNJT.HeaderText = "Fecha Junta"
        Me.FPLNJT.MaxInputLength = 10
        Me.FPLNJT.Name = "FPLNJT"
        Me.FPLNJT.ReadOnly = True
        Me.FPLNJT.Width = 98
        '
        'HPLNJT
        '
        Me.HPLNJT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.HPLNJT.DataPropertyName = "HPLNJT"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.HPLNJT.DefaultCellStyle = DataGridViewCellStyle4
        Me.HPLNJT.HeaderText = "Hora Junta"
        Me.HPLNJT.MaxInputLength = 8
        Me.HPLNJT.Name = "HPLNJT"
        Me.HPLNJT.ReadOnly = True
        Me.HPLNJT.Width = 93
        '
        'TRSPAT
        '
        Me.TRSPAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TRSPAT.DataPropertyName = "TRSPAT"
        Me.TRSPAT.HeaderText = "Responsable Junta"
        Me.TRSPAT.MaxInputLength = 40
        Me.TRSPAT.Name = "TRSPAT"
        Me.TRSPAT.ReadOnly = True
        Me.TRSPAT.Width = 133
        '
        'QCNASI
        '
        Me.QCNASI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QCNASI.DataPropertyName = "QCNASI"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "N0"
        Me.QCNASI.DefaultCellStyle = DataGridViewCellStyle5
        Me.QCNASI.HeaderText = "Cantidad Asistentes"
        Me.QCNASI.MaxInputLength = 8
        Me.QCNASI.Name = "QCNASI"
        Me.QCNASI.ReadOnly = True
        Me.QCNASI.Width = 140
        '
        'QANPRG_JUNTA
        '
        Me.QANPRG_JUNTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QANPRG_JUNTA.DataPropertyName = "QANPRG"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Format = "N0"
        Me.QANPRG_JUNTA.DefaultCellStyle = DataGridViewCellStyle6
        Me.QANPRG_JUNTA.HeaderText = "Unidades Programadas"
        Me.QANPRG_JUNTA.Name = "QANPRG_JUNTA"
        Me.QANPRG_JUNTA.ReadOnly = True
        Me.QANPRG_JUNTA.Width = 158
        '
        'DataGridViewTextBoxColumn67
        '
        Me.DataGridViewTextBoxColumn67.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn67.DataPropertyName = "SESPLN"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DataGridViewTextBoxColumn67.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn67.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn67.MaxInputLength = 2
        Me.DataGridViewTextBoxColumn67.Name = "DataGridViewTextBoxColumn67"
        Me.DataGridViewTextBoxColumn67.ReadOnly = True
        Me.DataGridViewTextBoxColumn67.Width = 71
        '
        'TDSCPL
        '
        Me.TDSCPL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TDSCPL.DataPropertyName = "TDSCPL"
        Me.TDSCPL.HeaderText = "Observación"
        Me.TDSCPL.MaxInputLength = 50
        Me.TDSCPL.Name = "TDSCPL"
        Me.TDSCPL.ReadOnly = True
        '
        'DataGridViewTextBoxColumn68
        '
        Me.DataGridViewTextBoxColumn68.DataPropertyName = "CCMPN"
        Me.DataGridViewTextBoxColumn68.HeaderText = "Compañia"
        Me.DataGridViewTextBoxColumn68.Name = "DataGridViewTextBoxColumn68"
        Me.DataGridViewTextBoxColumn68.ReadOnly = True
        Me.DataGridViewTextBoxColumn68.Visible = False
        '
        'DataGridViewTextBoxColumn69
        '
        Me.DataGridViewTextBoxColumn69.DataPropertyName = "CDVSN"
        Me.DataGridViewTextBoxColumn69.HeaderText = "División"
        Me.DataGridViewTextBoxColumn69.Name = "DataGridViewTextBoxColumn69"
        Me.DataGridViewTextBoxColumn69.ReadOnly = True
        Me.DataGridViewTextBoxColumn69.Visible = False
        '
        'DataGridViewTextBoxColumn70
        '
        Me.DataGridViewTextBoxColumn70.DataPropertyName = "CPLNDV"
        Me.DataGridViewTextBoxColumn70.HeaderText = "Planta"
        Me.DataGridViewTextBoxColumn70.Name = "DataGridViewTextBoxColumn70"
        Me.DataGridViewTextBoxColumn70.ReadOnly = True
        Me.DataGridViewTextBoxColumn70.Visible = False
        '
        'frmVerUnidadesProgramadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 195)
        Me.Controls.Add(Me.kgvUnidadProgramada)
        Me.Name = "frmVerUnidadesProgramadas"
        Me.Text = "frmVerUnidadesProgramadas"
        CType(Me.kgvUnidadProgramada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents kgvUnidadProgramada As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents DataGridViewTextBoxColumn65 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn66 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FPLNJT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HPLNJT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRSPAT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QCNASI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QANPRG_JUNTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn67 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDSCPL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn68 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn69 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn70 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
