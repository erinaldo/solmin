<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVistaGrupoColResumen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton()
        Me.gwLista = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.chk = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn()
        Me.GRUPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODGRUPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.gwLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.btnAceptar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(579, 27)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources._exit
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 24)
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAceptar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(85, 24)
        Me.btnAceptar.Text = "Aceptar"
        '
        'gwLista
        '
        Me.gwLista.AllowUserToAddRows = False
        Me.gwLista.AllowUserToDeleteRows = False
        Me.gwLista.AllowUserToOrderColumns = True
        Me.gwLista.ColumnHeadersHeight = 30
        Me.gwLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gwLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk, Me.GRUPO, Me.CODGRUPO})
        Me.gwLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gwLista.Location = New System.Drawing.Point(0, 27)
        Me.gwLista.Margin = New System.Windows.Forms.Padding(4)
        Me.gwLista.Name = "gwLista"
        Me.gwLista.RowHeadersVisible = False
        Me.gwLista.RowHeadersWidth = 30
        Me.gwLista.Size = New System.Drawing.Size(579, 268)
        Me.gwLista.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwLista.TabIndex = 2
        '
        'chk
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.NullValue = False
        Me.chk.DefaultCellStyle = DataGridViewCellStyle3
        Me.chk.FalseValue = Nothing
        Me.chk.HeaderText = "Chk"
        Me.chk.IndeterminateValue = Nothing
        Me.chk.Name = "chk"
        Me.chk.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.chk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.chk.TrueValue = Nothing
        '
        'GRUPO
        '
        Me.GRUPO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.GRUPO.DataPropertyName = "GRUPO"
        Me.GRUPO.HeaderText = "Vista"
        Me.GRUPO.Name = "GRUPO"
        Me.GRUPO.ReadOnly = True
        Me.GRUPO.Width = 74
        '
        'CODGRUPO
        '
        Me.CODGRUPO.DataPropertyName = "CODGRUPO"
        Me.CODGRUPO.HeaderText = ""
        Me.CODGRUPO.Name = "CODGRUPO"
        Me.CODGRUPO.ReadOnly = True
        Me.CODGRUPO.Visible = False
        '
        'frmVistaGrupoColResumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(579, 295)
        Me.Controls.Add(Me.gwLista)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmVistaGrupoColResumen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Visualización grupo columnas"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.gwLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents gwLista As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents chk As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
    Friend WithEvents GRUPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODGRUPO As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
