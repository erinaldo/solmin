<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubItems
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSubItems))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dgSubItemOC = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.lblItemOC = New System.Windows.Forms.ToolStripLabel
        Me.btnCerrar = New System.Windows.Forms.ToolStripButton
        Me.tssSep_04 = New System.Windows.Forms.ToolStripSeparator
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.M_NRITOC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_SBITOC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TCITCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TDITES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QCNREC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TUNDIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgSubItemOC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgSubItemOC)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(714, 211)
        Me.KryptonPanel.TabIndex = 0
        '
        'dgSubItemOC
        '
        Me.dgSubItemOC.AllowUserToAddRows = False
        Me.dgSubItemOC.AllowUserToDeleteRows = False
        Me.dgSubItemOC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgSubItemOC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_NRITOC, Me.M_SBITOC, Me.M_TCITCL, Me.M_TDITES, Me.M_QCNREC, Me.M_TUNDIT})
        Me.dgSubItemOC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgSubItemOC.Location = New System.Drawing.Point(0, 25)
        Me.dgSubItemOC.MultiSelect = False
        Me.dgSubItemOC.Name = "dgSubItemOC"
        Me.dgSubItemOC.RowHeadersWidth = 20
        Me.dgSubItemOC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgSubItemOC.Size = New System.Drawing.Size(714, 186)
        Me.dgSubItemOC.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgSubItemOC.TabIndex = 26
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblItemOC, Me.btnCerrar, Me.tssSep_04})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(714, 25)
        Me.tsMenuOpciones.TabIndex = 25
        '
        'lblItemOC
        '
        Me.lblItemOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemOC.Name = "lblItemOC"
        Me.lblItemOC.Size = New System.Drawing.Size(70, 22)
        Me.lblItemOC.Text = "SUBITEMS"
        '
        'btnCerrar
        '
        Me.btnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(58, 22)
        Me.btnCerrar.Text = "Cerrar"
        '
        'tssSep_04
        '
        Me.tssSep_04.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_04.Name = "tssSep_04"
        Me.tssSep_04.Size = New System.Drawing.Size(6, 25)
        '
        'M_NRITOC
        '
        Me.M_NRITOC.HeaderText = "Item"
        Me.M_NRITOC.Name = "M_NRITOC"
        Me.M_NRITOC.Width = 78
        '
        'M_SBITOC
        '
        Me.M_SBITOC.HeaderText = "SubItem"
        Me.M_SBITOC.Name = "M_SBITOC"
        Me.M_SBITOC.ReadOnly = True
        '
        'M_TCITCL
        '
        Me.M_TCITCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TCITCL.HeaderText = "Cód. Cliente"
        Me.M_TCITCL.Name = "M_TCITCL"
        Me.M_TCITCL.ReadOnly = True
        Me.M_TCITCL.Width = 99
        '
        'M_TDITES
        '
        Me.M_TDITES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TDITES.HeaderText = "Descripción"
        Me.M_TDITES.Name = "M_TDITES"
        Me.M_TDITES.ReadOnly = True
        Me.M_TDITES.Width = 96
        '
        'M_QCNREC
        '
        Me.M_QCNREC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0.00"
        Me.M_QCNREC.DefaultCellStyle = DataGridViewCellStyle1
        Me.M_QCNREC.HeaderText = "Cant. Recibida"
        Me.M_QCNREC.MaxInputLength = 10
        Me.M_QCNREC.Name = "M_QCNREC"
        Me.M_QCNREC.ReadOnly = True
        Me.M_QCNREC.Width = 110
        '
        'M_TUNDIT
        '
        Me.M_TUNDIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TUNDIT.HeaderText = "Unidad"
        Me.M_TUNDIT.Name = "M_TUNDIT"
        Me.M_TUNDIT.ReadOnly = True
        Me.M_TUNDIT.Width = 74
        '
        'frmSubItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 211)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSubItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SubItems Seleccionados"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dgSubItemOC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
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
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents lblItemOC As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_04 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents dgSubItemOC As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents M_NRITOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_SBITOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TCITCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TDITES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QCNREC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TUNDIT As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
