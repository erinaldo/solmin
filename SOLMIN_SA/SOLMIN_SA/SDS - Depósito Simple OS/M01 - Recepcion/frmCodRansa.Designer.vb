<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCodRansa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCodRansa))
        Me.txtGrupo = New RANSA.Utilitario.ucAyuda
        Me.txtFamilia = New RANSA.Utilitario.ucAyuda
        Me.lblFamilia = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblGrupo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblBuscar = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cboBuscar = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.txtDato = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.KryptonGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.dtgRansa = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.PSCMRCD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTCMPMR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        CType(Me.KryptonGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup2.Panel.SuspendLayout()
        Me.KryptonGroup2.SuspendLayout()
        CType(Me.dtgRansa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtGrupo
        '
        Me.txtGrupo.BackColor = System.Drawing.Color.Transparent
        Me.txtGrupo.DataSource = Nothing
        Me.txtGrupo.DispleyMember = ""
        Me.txtGrupo.ListColumnas = Nothing
        Me.txtGrupo.Location = New System.Drawing.Point(86, 41)
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.Obligatorio = False
        Me.txtGrupo.Size = New System.Drawing.Size(269, 27)
        Me.txtGrupo.TabIndex = 87
        Me.txtGrupo.ValueMember = ""
        '
        'txtFamilia
        '
        Me.txtFamilia.BackColor = System.Drawing.Color.Transparent
        Me.txtFamilia.DataSource = Nothing
        Me.txtFamilia.DispleyMember = ""
        Me.txtFamilia.ListColumnas = Nothing
        Me.txtFamilia.Location = New System.Drawing.Point(87, 15)
        Me.txtFamilia.Name = "txtFamilia"
        Me.txtFamilia.Obligatorio = False
        Me.txtFamilia.Size = New System.Drawing.Size(268, 33)
        Me.txtFamilia.TabIndex = 86
        Me.txtFamilia.ValueMember = ""
        '
        'lblFamilia
        '
        Me.lblFamilia.Location = New System.Drawing.Point(17, 15)
        Me.lblFamilia.Name = "lblFamilia"
        Me.lblFamilia.Size = New System.Drawing.Size(55, 20)
        Me.lblFamilia.TabIndex = 85
        Me.lblFamilia.Text = "Familia : "
        Me.lblFamilia.Values.ExtraText = ""
        Me.lblFamilia.Values.Image = Nothing
        Me.lblFamilia.Values.Text = "Familia : "
        '
        'lblGrupo
        '
        Me.lblGrupo.Location = New System.Drawing.Point(18, 41)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(51, 20)
        Me.lblGrupo.TabIndex = 84
        Me.lblGrupo.Text = "Grupo : "
        Me.lblGrupo.Values.ExtraText = ""
        Me.lblGrupo.Values.Image = Nothing
        Me.lblGrupo.Values.Text = "Grupo : "
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(26, 95)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(43, 20)
        Me.KryptonLabel1.TabIndex = 84
        Me.KryptonLabel1.Text = "Dato : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Dato : "
        '
        'lblBuscar
        '
        Me.lblBuscar.Location = New System.Drawing.Point(17, 67)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(52, 20)
        Me.lblBuscar.TabIndex = 84
        Me.lblBuscar.Text = "Buscar : "
        Me.lblBuscar.Values.ExtraText = ""
        Me.lblBuscar.Values.Image = Nothing
        Me.lblBuscar.Values.Text = "Buscar : "
        '
        'cboBuscar
        '
        Me.cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBuscar.DropDownWidth = 151
        Me.cboBuscar.FormattingEnabled = False
        Me.cboBuscar.ItemHeight = 15
        Me.cboBuscar.Location = New System.Drawing.Point(87, 67)
        Me.cboBuscar.Name = "cboBuscar"
        Me.cboBuscar.Size = New System.Drawing.Size(151, 23)
        Me.cboBuscar.TabIndex = 88
        '
        'txtDato
        '
        Me.txtDato.Location = New System.Drawing.Point(87, 95)
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(269, 22)
        Me.txtDato.TabIndex = 89
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Location = New System.Drawing.Point(13, 12)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.lblFamilia)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtDato)
        Me.KryptonGroup1.Panel.Controls.Add(Me.lblGrupo)
        Me.KryptonGroup1.Panel.Controls.Add(Me.cboBuscar)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtGrupo)
        Me.KryptonGroup1.Panel.Controls.Add(Me.lblBuscar)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtFamilia)
        Me.KryptonGroup1.Size = New System.Drawing.Size(383, 136)
        Me.KryptonGroup1.TabIndex = 90
        '
        'KryptonGroup2
        '
        Me.KryptonGroup2.Location = New System.Drawing.Point(13, 154)
        Me.KryptonGroup2.Name = "KryptonGroup2"
        '
        'KryptonGroup2.Panel
        '
        Me.KryptonGroup2.Panel.Controls.Add(Me.dtgRansa)
        Me.KryptonGroup2.Size = New System.Drawing.Size(383, 192)
        Me.KryptonGroup2.TabIndex = 91
        '
        'dtgRansa
        '
        Me.dtgRansa.AllowUserToAddRows = False
        Me.dtgRansa.AllowUserToDeleteRows = False
        Me.dtgRansa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgRansa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PSCMRCD, Me.PSTCMPMR})
        Me.dtgRansa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgRansa.Location = New System.Drawing.Point(0, 0)
        Me.dtgRansa.Name = "dtgRansa"
        Me.dtgRansa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgRansa.Size = New System.Drawing.Size(381, 190)
        Me.dtgRansa.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgRansa.TabIndex = 0
        '
        'PSCMRCD
        '
        Me.PSCMRCD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSCMRCD.DataPropertyName = "PSCMRCD"
        Me.PSCMRCD.HeaderText = "Código"
        Me.PSCMRCD.Name = "PSCMRCD"
        Me.PSCMRCD.Width = 75
        '
        'PSTCMPMR
        '
        Me.PSTCMPMR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PSTCMPMR.DataPropertyName = "PSTCMPMR"
        Me.PSTCMPMR.HeaderText = "Descripción"
        Me.PSTCMPMR.Name = "PSTCMPMR"
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Location = New System.Drawing.Point(13, 352)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(189, 25)
        Me.btnAceptar.TabIndex = 92
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.Values.ExtraText = ""
        Me.btnAceptar.Values.Image = CType(resources.GetObject("btnAceptar.Values.Image"), System.Drawing.Image)
        Me.btnAceptar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAceptar.Values.Text = "Aceptar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(217, 352)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(177, 25)
        Me.btnCancelar.TabIndex = 93
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = CType(resources.GetObject("btnCancelar.Values.Image"), System.Drawing.Image)
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "Cancelar"
        '
        'frmCodRansa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(413, 389)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.KryptonGroup2)
        Me.Controls.Add(Me.KryptonGroup1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCodRansa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Código Ransa"
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        Me.KryptonGroup1.Panel.PerformLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
        CType(Me.KryptonGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup2.Panel.ResumeLayout(False)
        CType(Me.KryptonGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup2.ResumeLayout(False)
        CType(Me.dtgRansa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtGrupo As RANSA.Utilitario.ucAyuda
    Friend WithEvents txtFamilia As RANSA.Utilitario.ucAyuda
    Friend WithEvents lblFamilia As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblGrupo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblBuscar As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboBuscar As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents txtDato As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents KryptonGroup2 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents dtgRansa As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents PSCMRCD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTCMPMR As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
