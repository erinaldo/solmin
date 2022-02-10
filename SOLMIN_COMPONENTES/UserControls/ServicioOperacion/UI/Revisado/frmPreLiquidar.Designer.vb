<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreLiquidar
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
        Me.HeaderDatos = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.dgwPreFacturacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.NDCPRF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NSECFC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TSGNMN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSubDocCliente = New System.Windows.Forms.TextBox()
        Me.txtDocCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cblTipoDoc = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuBar = New System.Windows.Forms.ToolStrip()
        Me.btnCerrar = New System.Windows.Forms.ToolStripButton()
        Me.Separator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnPreLiquidacion = New System.Windows.Forms.ToolStripButton()
        Me.Separator2 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderDatos.Panel.SuspendLayout()
        Me.HeaderDatos.SuspendLayout()
        CType(Me.dgwPreFacturacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeaderDatos
        '
        Me.HeaderDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderDatos.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HeaderDatos.HeaderVisibleSecondary = False
        Me.HeaderDatos.Location = New System.Drawing.Point(0, 0)
        Me.HeaderDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.HeaderDatos.Name = "HeaderDatos"
        '
        'HeaderDatos.Panel
        '
        Me.HeaderDatos.Panel.Controls.Add(Me.dgwPreFacturacion)
        Me.HeaderDatos.Panel.Controls.Add(Me.Panel1)
        Me.HeaderDatos.Panel.Controls.Add(Me.MenuBar)
        Me.HeaderDatos.Size = New System.Drawing.Size(1155, 321)
        Me.HeaderDatos.TabIndex = 1
        Me.HeaderDatos.Text = "Lista Pre Factura"
        Me.HeaderDatos.ValuesPrimary.Description = ""
        Me.HeaderDatos.ValuesPrimary.Heading = "Lista Pre Factura"
        Me.HeaderDatos.ValuesPrimary.Image = Nothing
        Me.HeaderDatos.ValuesSecondary.Description = ""
        Me.HeaderDatos.ValuesSecondary.Heading = "Description"
        Me.HeaderDatos.ValuesSecondary.Image = Nothing
        '
        'dgwPreFacturacion
        '
        Me.dgwPreFacturacion.AllowUserToAddRows = False
        Me.dgwPreFacturacion.AllowUserToDeleteRows = False
        Me.dgwPreFacturacion.AllowUserToOrderColumns = True
        Me.dgwPreFacturacion.AllowUserToResizeColumns = False
        Me.dgwPreFacturacion.AllowUserToResizeRows = False
        Me.dgwPreFacturacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgwPreFacturacion.ColumnHeadersHeight = 25
        Me.dgwPreFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgwPreFacturacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NDCPRF, Me.NSECFC, Me.TSGNMN, Me.TOTAL1, Me.Column1})
        Me.dgwPreFacturacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwPreFacturacion.Location = New System.Drawing.Point(0, 82)
        Me.dgwPreFacturacion.Margin = New System.Windows.Forms.Padding(4)
        Me.dgwPreFacturacion.MultiSelect = False
        Me.dgwPreFacturacion.Name = "dgwPreFacturacion"
        Me.dgwPreFacturacion.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.dgwPreFacturacion.ReadOnly = True
        Me.dgwPreFacturacion.RowHeadersVisible = False
        Me.dgwPreFacturacion.RowHeadersWidth = 20
        Me.dgwPreFacturacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwPreFacturacion.Size = New System.Drawing.Size(1153, 212)
        Me.dgwPreFacturacion.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgwPreFacturacion.TabIndex = 21
        '
        'NDCPRF
        '
        Me.NDCPRF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NDCPRF.DataPropertyName = "NDCPRF"
        Me.NDCPRF.HeaderText = "Nro de Pre. Factura"
        Me.NDCPRF.Name = "NDCPRF"
        Me.NDCPRF.ReadOnly = True
        Me.NDCPRF.Visible = False
        Me.NDCPRF.Width = 167
        '
        'NSECFC
        '
        Me.NSECFC.DataPropertyName = "NSECFC"
        Me.NSECFC.HeaderText = "NroRevision"
        Me.NSECFC.Name = "NSECFC"
        Me.NSECFC.ReadOnly = True
        Me.NSECFC.Width = 122
        '
        'TSGNMN
        '
        Me.TSGNMN.DataPropertyName = "TSGNMN"
        Me.TSGNMN.HeaderText = "Moneda"
        Me.TSGNMN.Name = "TSGNMN"
        Me.TSGNMN.ReadOnly = True
        Me.TSGNMN.Width = 97
        '
        'TOTAL1
        '
        Me.TOTAL1.DataPropertyName = "TOTAL1"
        Me.TOTAL1.HeaderText = "Total"
        Me.TOTAL1.Name = "TOTAL1"
        Me.TOTAL1.ReadOnly = True
        Me.TOTAL1.Width = 75
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.txtSubDocCliente)
        Me.Panel1.Controls.Add(Me.txtDocCliente)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cblTipoDoc)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1153, 55)
        Me.Panel1.TabIndex = 2
        '
        'txtSubDocCliente
        '
        Me.txtSubDocCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSubDocCliente.Location = New System.Drawing.Point(667, 16)
        Me.txtSubDocCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSubDocCliente.MaxLength = 20
        Me.txtSubDocCliente.Name = "txtSubDocCliente"
        Me.txtSubDocCliente.Size = New System.Drawing.Size(231, 22)
        Me.txtSubDocCliente.TabIndex = 2
        Me.txtSubDocCliente.Visible = False
        '
        'txtDocCliente
        '
        Me.txtDocCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDocCliente.Location = New System.Drawing.Point(313, 16)
        Me.txtDocCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDocCliente.MaxLength = 20
        Me.txtDocCliente.Name = "txtDocCliente"
        Me.txtDocCliente.Size = New System.Drawing.Size(217, 22)
        Me.txtDocCliente.TabIndex = 0
        Me.txtDocCliente.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(541, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Sub Doc. Cliente:"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(219, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Doc. Cliente:"
        Me.Label2.Visible = False
        '
        'cblTipoDoc
        '
        Me.cblTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cblTipoDoc.FormattingEnabled = True
        Me.cblTipoDoc.Location = New System.Drawing.Point(77, 14)
        Me.cblTipoDoc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cblTipoDoc.Name = "cblTipoDoc"
        Me.cblTipoDoc.Size = New System.Drawing.Size(135, 24)
        Me.cblTipoDoc.TabIndex = 4
        Me.cblTipoDoc.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tipo Doc:"
        Me.Label1.Visible = False
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCerrar, Me.Separator1, Me.btnPreLiquidacion, Me.Separator2})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(1153, 27)
        Me.MenuBar.TabIndex = 0
        Me.MenuBar.TabStop = True
        Me.MenuBar.Text = "ToolStrip1"
        '
        'btnCerrar
        '
        Me.btnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCerrar.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.button_cancel1
        Me.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(90, 24)
        Me.btnCerrar.Text = "Cancelar"
        Me.btnCerrar.ToolTipText = "Cancelar"
        '
        'Separator1
        '
        Me.Separator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Separator1.Name = "Separator1"
        Me.Separator1.Size = New System.Drawing.Size(6, 27)
        '
        'btnPreLiquidacion
        '
        Me.btnPreLiquidacion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnPreLiquidacion.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.button_ok
        Me.btnPreLiquidacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPreLiquidacion.Name = "btnPreLiquidacion"
        Me.btnPreLiquidacion.Size = New System.Drawing.Size(112, 24)
        Me.btnPreLiquidacion.Text = " Procesar PL"
        Me.btnPreLiquidacion.ToolTipText = " Pre - Liquidar"
        '
        'Separator2
        '
        Me.Separator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Separator2.Name = "Separator2"
        Me.Separator2.Size = New System.Drawing.Size(6, 27)
        '
        'frmPreLiquidar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1155, 321)
        Me.Controls.Add(Me.HeaderDatos)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPreLiquidar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pre Liquidar"
        CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderDatos.Panel.ResumeLayout(False)
        Me.HeaderDatos.Panel.PerformLayout()
        CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderDatos.ResumeLayout(False)
        CType(Me.dgwPreFacturacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HeaderDatos As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents dgwPreFacturacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtSubDocCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtDocCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cblTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Separator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnPreLiquidacion As System.Windows.Forms.ToolStripButton
    Friend WithEvents Separator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NDCPRF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NSECFC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TSGNMN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTAL1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
