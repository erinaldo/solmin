<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventarioProyecto
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dgProyecto = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.tsMenuOpcionesDetalle = New System.Windows.Forms.ToolStrip
        Me.lblDetalle = New System.Windows.Forms.ToolStripLabel
        Me.btnSalir = New System.Windows.Forms.ToolStripButton
        Me.btnaAgregar = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.NORCML = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRITOC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QCNTIT_ITEM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QINMC2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNRFRPD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNQCNTIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QCNRCP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QCNDPC = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgProyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpcionesDetalle.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgProyecto)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpcionesDetalle)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(805, 351)
        Me.KryptonPanel.TabIndex = 0
        '
        'dgProyecto
        '
        Me.dgProyecto.AllowUserToAddRows = False
        Me.dgProyecto.AllowUserToDeleteRows = False
        Me.dgProyecto.ColumnHeadersHeight = 30
        Me.dgProyecto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NORCML, Me.NRITOC, Me.QCNTIT_ITEM, Me.QINMC2, Me.PSNRFRPD, Me.PNQCNTIT, Me.QCNRCP, Me.QCNDPC})
        Me.dgProyecto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgProyecto.Location = New System.Drawing.Point(0, 25)
        Me.dgProyecto.Name = "dgProyecto"
        Me.dgProyecto.Size = New System.Drawing.Size(805, 326)
        Me.dgProyecto.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgProyecto.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgProyecto.TabIndex = 3
        '
        'tsMenuOpcionesDetalle
        '
        Me.tsMenuOpcionesDetalle.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsMenuOpcionesDetalle.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpcionesDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblDetalle, Me.btnSalir, Me.btnaAgregar})
        Me.tsMenuOpcionesDetalle.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpcionesDetalle.Name = "tsMenuOpcionesDetalle"
        Me.tsMenuOpcionesDetalle.Size = New System.Drawing.Size(805, 25)
        Me.tsMenuOpcionesDetalle.TabIndex = 77
        '
        'lblDetalle
        '
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(117, 22)
        Me.lblDetalle.Text = "Información proyecto"
        '
        'btnSalir
        '
        Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalir.Image = Global.SOLMIN_SA.My.Resources.Resources._exit
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(49, 22)
        Me.btnSalir.Text = "Salir"
        '
        'btnaAgregar
        '
        Me.btnaAgregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnaAgregar.Image = Global.SOLMIN_SA.My.Resources.Resources.retencion
        Me.btnaAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnaAgregar.Name = "btnaAgregar"
        Me.btnaAgregar.Size = New System.Drawing.Size(68, 22)
        Me.btnaAgregar.Text = "Agregar"
        '
        'NORCML
        '
        Me.NORCML.DataPropertyName = "PSNORCML"
        Me.NORCML.HeaderText = "Orden de Compra"
        Me.NORCML.Name = "NORCML"
        '
        'NRITOC
        '
        Me.NRITOC.DataPropertyName = "PNNRITOC"
        Me.NRITOC.HeaderText = "Nro. Item"
        Me.NRITOC.Name = "NRITOC"
        '
        'QCNTIT_ITEM
        '
        Me.QCNTIT_ITEM.DataPropertyName = "PNQCNTIT_ITEM"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.QCNTIT_ITEM.DefaultCellStyle = DataGridViewCellStyle1
        Me.QCNTIT_ITEM.HeaderText = "Cantidad Solicitada Item"
        Me.QCNTIT_ITEM.Name = "QCNTIT_ITEM"
        Me.QCNTIT_ITEM.Width = 150
        '
        'QINMC2
        '
        Me.QINMC2.DataPropertyName = "PNQINMC2"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.QINMC2.DefaultCellStyle = DataGridViewCellStyle2
        Me.QINMC2.HeaderText = "Cantidad Recibida Item"
        Me.QINMC2.Name = "QINMC2"
        '
        'PSNRFRPD
        '
        Me.PSNRFRPD.DataPropertyName = "PSNRFRPD"
        Me.PSNRFRPD.HeaderText = "Numero Pedido"
        Me.PSNRFRPD.MaxInputLength = 10
        Me.PSNRFRPD.Name = "PSNRFRPD"
        Me.PSNRFRPD.ReadOnly = True
        Me.PSNRFRPD.Width = 150
        '
        'PNQCNTIT
        '
        Me.PNQCNTIT.DataPropertyName = "PNQCNTIT"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.PNQCNTIT.DefaultCellStyle = DataGridViewCellStyle3
        Me.PNQCNTIT.HeaderText = "Cantidad Solicitada"
        Me.PNQCNTIT.MaxInputLength = 21
        Me.PNQCNTIT.Name = "PNQCNTIT"
        Me.PNQCNTIT.ReadOnly = True
        Me.PNQCNTIT.Width = 150
        '
        'QCNRCP
        '
        Me.QCNRCP.DataPropertyName = "PNQCNRCP"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N0"
        Me.QCNRCP.DefaultCellStyle = DataGridViewCellStyle4
        Me.QCNRCP.HeaderText = "Cantidad Recibida"
        Me.QCNRCP.Name = "QCNRCP"
        Me.QCNRCP.Width = 150
        '
        'QCNDPC
        '
        Me.QCNDPC.DataPropertyName = "PNQCNDPC"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N0"
        Me.QCNDPC.DefaultCellStyle = DataGridViewCellStyle5
        Me.QCNDPC.HeaderText = "Cantidad Despachada"
        Me.QCNDPC.Name = "QCNDPC"
        Me.QCNDPC.Width = 150
        '
        'frmInventarioProyecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 351)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmInventarioProyecto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Inventario Proyecto"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dgProyecto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpcionesDetalle.ResumeLayout(False)
        Me.tsMenuOpcionesDetalle.PerformLayout()
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
    Friend WithEvents dgProyecto As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Private WithEvents tsMenuOpcionesDetalle As System.Windows.Forms.ToolStrip
    Friend WithEvents lblDetalle As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnaAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents NORCML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRITOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QCNTIT_ITEM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QINMC2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNRFRPD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQCNTIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QCNRCP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QCNDPC As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
