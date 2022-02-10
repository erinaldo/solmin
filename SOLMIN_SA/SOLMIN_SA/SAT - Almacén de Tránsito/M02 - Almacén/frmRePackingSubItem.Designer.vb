<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRePackingSubItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRePackingSubItem))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dgSubItemOC = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.lblItemOC = New System.Windows.Forms.ToolStripLabel
        Me.btnCerrar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CREFFW = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NORCML = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRITOC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CIDPAQ = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SBITOC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDITES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QCNRCP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QREPAC = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        Me.KryptonPanel.Size = New System.Drawing.Size(692, 216)
        Me.KryptonPanel.TabIndex = 0
        '
        'dgSubItemOC
        '
        Me.dgSubItemOC.AllowUserToAddRows = False
        Me.dgSubItemOC.AllowUserToDeleteRows = False
        Me.dgSubItemOC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgSubItemOC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CCLNT, Me.CREFFW, Me.NORCML, Me.NRITOC, Me.CIDPAQ, Me.SBITOC, Me.TDITES, Me.QCNRCP, Me.QREPAC})
        Me.dgSubItemOC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgSubItemOC.Location = New System.Drawing.Point(0, 25)
        Me.dgSubItemOC.MultiSelect = False
        Me.dgSubItemOC.Name = "dgSubItemOC"
        Me.dgSubItemOC.RowHeadersWidth = 20
        Me.dgSubItemOC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgSubItemOC.Size = New System.Drawing.Size(692, 191)
        Me.dgSubItemOC.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgSubItemOC.TabIndex = 49
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblItemOC, Me.btnCerrar, Me.ToolStripSeparator1, Me.btnAceptar})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(692, 25)
        Me.tsMenuOpciones.TabIndex = 48
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnAceptar
        '
        Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAceptar.Image = Global.SOLMIN_SA.My.Resources.Resources.retencion
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(66, 22)
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.ToolTipText = "Aceptar"
        '
        'CCLNT
        '
        Me.CCLNT.DataPropertyName = "CCLNT"
        Me.CCLNT.HeaderText = "CCLNT"
        Me.CCLNT.Name = "CCLNT"
        Me.CCLNT.Visible = False
        '
        'CREFFW
        '
        Me.CREFFW.DataPropertyName = "CREFFW"
        Me.CREFFW.HeaderText = "CREFFW"
        Me.CREFFW.Name = "CREFFW"
        Me.CREFFW.Visible = False
        '
        'NORCML
        '
        Me.NORCML.DataPropertyName = "NORCML"
        Me.NORCML.HeaderText = "NORCML"
        Me.NORCML.Name = "NORCML"
        Me.NORCML.Visible = False
        '
        'NRITOC
        '
        Me.NRITOC.DataPropertyName = "NRITOC"
        Me.NRITOC.HeaderText = "NRITOC"
        Me.NRITOC.Name = "NRITOC"
        Me.NRITOC.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NRITOC.Visible = False
        Me.NRITOC.Width = 78
        '
        'CIDPAQ
        '
        Me.CIDPAQ.DataPropertyName = "CIDPAQ"
        Me.CIDPAQ.HeaderText = "Nro. Item"
        Me.CIDPAQ.Name = "CIDPAQ"
        Me.CIDPAQ.ReadOnly = True
        '
        'SBITOC
        '
        Me.SBITOC.DataPropertyName = "SBITOC"
        Me.SBITOC.HeaderText = "Nro. Sub Item"
        Me.SBITOC.Name = "SBITOC"
        Me.SBITOC.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'TDITES
        '
        Me.TDITES.DataPropertyName = "TDITES"
        Me.TDITES.HeaderText = "Descripcion"
        Me.TDITES.Name = "TDITES"
        Me.TDITES.ReadOnly = True
        '
        'QCNRCP
        '
        Me.QCNRCP.DataPropertyName = "QCNRCP"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.QCNRCP.DefaultCellStyle = DataGridViewCellStyle1
        Me.QCNRCP.HeaderText = "Cant. en Bulto"
        Me.QCNRCP.Name = "QCNRCP"
        Me.QCNRCP.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'QREPAC
        '
        Me.QREPAC.DataPropertyName = "QREPAC"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.QREPAC.DefaultCellStyle = DataGridViewCellStyle2
        Me.QREPAC.HeaderText = "Re-Packing"
        Me.QREPAC.Name = "QREPAC"
        '
        'frmRePackingSubItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 216)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(700, 250)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(700, 250)
        Me.Name = "frmRePackingSubItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Re-Packing de SubItem"
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
    Private WithEvents dgSubItemOC As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NORCML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRITOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CIDPAQ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SBITOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDITES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QCNRCP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QREPAC As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
