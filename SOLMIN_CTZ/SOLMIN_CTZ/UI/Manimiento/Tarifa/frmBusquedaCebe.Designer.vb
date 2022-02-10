<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaCebe
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.dgvCentroBeneficio = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtCodCeBeSAP = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtCodigo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCodigo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCNTCS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCNTCS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCNBNS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CEBE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.espacio = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvCentroBeneficio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCentroBeneficio
        '
        Me.dgvCentroBeneficio.AllowUserToAddRows = False
        Me.dgvCentroBeneficio.AllowUserToDeleteRows = False
        Me.dgvCentroBeneficio.AllowUserToOrderColumns = True
        Me.dgvCentroBeneficio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCentroBeneficio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CCNTCS, Me.TCNTCS, Me.CCNBNS, Me.CEBE, Me.espacio})
        Me.dgvCentroBeneficio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCentroBeneficio.Location = New System.Drawing.Point(0, 124)
        Me.dgvCentroBeneficio.Name = "dgvCentroBeneficio"
        Me.dgvCentroBeneficio.ReadOnly = True
        Me.dgvCentroBeneficio.Size = New System.Drawing.Size(535, 221)
        Me.dgvCentroBeneficio.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvCentroBeneficio.TabIndex = 8
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 99)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(535, 25)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnBuscar
        '
        Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar.Image = Global.SOLMIN_CT.My.Resources.Resources.search
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(62, 22)
        Me.btnBuscar.Text = "Buscar"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtDescripcion)
        Me.Panel1.Controls.Add(Me.txtCodCeBeSAP)
        Me.Panel1.Controls.Add(Me.txtCodigo)
        Me.Panel1.Controls.Add(Me.KryptonLabel3)
        Me.Panel1.Controls.Add(Me.KryptonLabel2)
        Me.Panel1.Controls.Add(Me.lblCodigo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(535, 99)
        Me.Panel1.TabIndex = 6
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(90, 47)
        Me.txtDescripcion.MaxLength = 35
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(425, 22)
        Me.txtDescripcion.TabIndex = 6
        '
        'txtCodCeBeSAP
        '
        Me.txtCodCeBeSAP.Location = New System.Drawing.Point(331, 14)
        Me.txtCodCeBeSAP.MaxLength = 10
        Me.txtCodCeBeSAP.Name = "txtCodCeBeSAP"
        Me.txtCodCeBeSAP.Size = New System.Drawing.Size(184, 22)
        Me.txtCodCeBeSAP.TabIndex = 4
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(90, 14)
        Me.txtCodigo.MaxLength = 6
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(167, 22)
        Me.txtCodigo.TabIndex = 2
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(266, 16)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(59, 20)
        Me.KryptonLabel3.TabIndex = 3
        Me.KryptonLabel3.Text = "Cod Sap:"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Cod Sap:"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(13, 47)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(77, 20)
        Me.KryptonLabel2.TabIndex = 5
        Me.KryptonLabel2.Text = "Descripción:"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Descripción:"
        '
        'lblCodigo
        '
        Me.lblCodigo.Location = New System.Drawing.Point(16, 16)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(53, 20)
        Me.lblCodigo.TabIndex = 1
        Me.lblCodigo.Text = "Código:"
        Me.lblCodigo.Values.ExtraText = ""
        Me.lblCodigo.Values.Image = Nothing
        Me.lblCodigo.Values.Text = "Código:"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "COD_CEBE"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DESC_CEBE"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CODSAP_CEBE"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cód Sap"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CEBE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CEBE"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 63
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.HeaderText = ""
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'CCNTCS
        '
        Me.CCNTCS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CCNTCS.DataPropertyName = "CCNTCS"
        Me.CCNTCS.HeaderText = "Código"
        Me.CCNTCS.Name = "CCNTCS"
        Me.CCNTCS.ReadOnly = True
        Me.CCNTCS.Width = 75
        '
        'TCNTCS
        '
        Me.TCNTCS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCNTCS.DataPropertyName = "TCNTCS"
        Me.TCNTCS.HeaderText = "Descripción"
        Me.TCNTCS.Name = "TCNTCS"
        Me.TCNTCS.ReadOnly = True
        Me.TCNTCS.Width = 98
        '
        'CCNBNS
        '
        Me.CCNBNS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CCNBNS.DataPropertyName = "CCNBNS"
        Me.CCNBNS.HeaderText = "Cód Sap"
        Me.CCNBNS.Name = "CCNBNS"
        Me.CCNBNS.ReadOnly = True
        Me.CCNBNS.Width = 80
        '
        'CEBE
        '
        Me.CEBE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CEBE.DataPropertyName = "CEBE"
        Me.CEBE.HeaderText = "CEBE"
        Me.CEBE.Name = "CEBE"
        Me.CEBE.ReadOnly = True
        Me.CEBE.Visible = False
        Me.CEBE.Width = 63
        '
        'espacio
        '
        Me.espacio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.espacio.HeaderText = ""
        Me.espacio.Name = "espacio"
        Me.espacio.ReadOnly = True
        '
        'frmBusquedaCebe
        '
        Me.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 345)
        Me.Controls.Add(Me.dgvCentroBeneficio)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.Name = "frmBusquedaCebe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Búsqueda Centro Beneficio"
        CType(Me.dgvCentroBeneficio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCentroBeneficio As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtDescripcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCodCeBeSAP As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCodigo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCodigo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCNTCS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCNTCS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCNBNS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CEBE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents espacio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
