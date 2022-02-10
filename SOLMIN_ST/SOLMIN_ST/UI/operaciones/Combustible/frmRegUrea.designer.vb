<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegUrea
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
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.txtRefDoc = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtUreaAsignado = New Ransa.Utilitario.clsTextBoxNumero()
        Me.txtCostoGln = New Ransa.Utilitario.clsTextBoxNumero()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.dtpFechaCarga = New System.Windows.Forms.DateTimePicker()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.MenuBar = New System.Windows.Forms.ToolStrip()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btnProcesar = New System.Windows.Forms.ToolStripButton()
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.cboMoneda)
        Me.KryptonPanel.Controls.Add(Me.txtRefDoc)
        Me.KryptonPanel.Controls.Add(Me.txtUreaAsignado)
        Me.KryptonPanel.Controls.Add(Me.txtCostoGln)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel14)
        Me.KryptonPanel.Controls.Add(Me.dtpFechaCarga)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel6)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel.Controls.Add(Me.MenuBar)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003
        Me.KryptonPanel.Size = New System.Drawing.Size(773, 165)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(19, 73)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(68, 24)
        Me.KryptonLabel1.TabIndex = 39
        Me.KryptonLabel1.Text = "Moneda"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Moneda"
        '
        'cboMoneda
        '
        Me.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Location = New System.Drawing.Point(184, 73)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(175, 24)
        Me.cboMoneda.TabIndex = 2
        '
        'txtRefDoc
        '
        Me.txtRefDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRefDoc.Location = New System.Drawing.Point(184, 41)
        Me.txtRefDoc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRefDoc.MaxLength = 12
        Me.txtRefDoc.Name = "txtRefDoc"
        Me.txtRefDoc.Size = New System.Drawing.Size(175, 26)
        Me.txtRefDoc.TabIndex = 0
        Me.txtRefDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUreaAsignado
        '
        Me.txtUreaAsignado.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.txtUreaAsignado.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtUreaAsignado.Location = New System.Drawing.Point(184, 107)
        Me.txtUreaAsignado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUreaAsignado.MaxLength = 15
        Me.txtUreaAsignado.Name = "txtUreaAsignado"
        Me.txtUreaAsignado.NUMDECIMALES = 2
        Me.txtUreaAsignado.NUMENTEROS = 10
        Me.txtUreaAsignado.Size = New System.Drawing.Size(175, 22)
        Me.txtUreaAsignado.TabIndex = 3
        '
        'txtCostoGln
        '
        Me.txtCostoGln.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.txtCostoGln.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtCostoGln.Location = New System.Drawing.Point(571, 107)
        Me.txtCostoGln.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCostoGln.MaxLength = 15
        Me.txtCostoGln.Name = "txtCostoGln"
        Me.txtCostoGln.NUMDECIMALES = 2
        Me.txtCostoGln.NUMENTEROS = 10
        Me.txtCostoGln.Size = New System.Drawing.Size(116, 22)
        Me.txtCostoGln.TabIndex = 4
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(380, 105)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(135, 24)
        Me.KryptonLabel2.TabIndex = 33
        Me.KryptonLabel2.Text = "Costo Úrea( x Gln)"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Costo Úrea( x Gln)"
        '
        'KryptonLabel14
        '
        Me.KryptonLabel14.Location = New System.Drawing.Point(19, 105)
        Me.KryptonLabel14.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel14.Name = "KryptonLabel14"
        Me.KryptonLabel14.Size = New System.Drawing.Size(104, 24)
        Me.KryptonLabel14.TabIndex = 4
        Me.KryptonLabel14.Text = "Cant. Úrea(Lt)"
        Me.KryptonLabel14.Values.ExtraText = ""
        Me.KryptonLabel14.Values.Image = Nothing
        Me.KryptonLabel14.Values.Text = "Cant. Úrea(Lt)"
        '
        'dtpFechaCarga
        '
        Me.dtpFechaCarga.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCarga.Location = New System.Drawing.Point(571, 45)
        Me.dtpFechaCarga.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaCarga.Name = "dtpFechaCarga"
        Me.dtpFechaCarga.Size = New System.Drawing.Size(116, 22)
        Me.dtpFechaCarga.TabIndex = 1
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(380, 43)
        Me.KryptonLabel6.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(98, 24)
        Me.KryptonLabel6.TabIndex = 1
        Me.KryptonLabel6.Text = "Fecha Carga."
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Fecha Carga."
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(19, 43)
        Me.KryptonLabel3.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(122, 24)
        Me.KryptonLabel3.TabIndex = 31
        Me.KryptonLabel3.Text = "Nro Documento"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Nro Documento"
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.btnProcesar})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(773, 27)
        Me.MenuBar.TabIndex = 12
        Me.MenuBar.TabStop = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources._stop
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 24)
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnProcesar
        '
        Me.btnProcesar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnProcesar.Image = Global.SOLMIN_ST.My.Resources.Resources.filesave
        Me.btnProcesar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(86, 24)
        Me.btnProcesar.Text = "Guardar"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Acción"
        Me.DataGridViewImageColumn1.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 91
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nro Liquidación"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 91
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre Cliente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 91
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Ruta"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 91
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nombre Imagen"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 92
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Extensión Archivo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 91
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Acción"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 91
        '
        'frmRegUrea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(773, 165)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmRegUrea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro Úrea"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnProcesar As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents dtpFechaCarga As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCostoGln As Ransa.Utilitario.clsTextBoxNumero
    Friend WithEvents txtUreaAsignado As Ransa.Utilitario.clsTextBoxNumero
    Friend WithEvents txtRefDoc As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
