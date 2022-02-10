<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarDetallePedido
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
        Me.dgItemPedido = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.tstCodMercaderia = New System.Windows.Forms.ToolStripTextBox
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton
        Me.tss001 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbAceptar = New System.Windows.Forms.ToolStripButton
        Me.tss002 = New System.Windows.Forms.ToolStripSeparator
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.CHK = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
        Me.CMRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TMRCD2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUNCN5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QSLMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SALDO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QCMMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNQSRVC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NORDSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgItemPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgItemPedido)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip2)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(696, 257)
        Me.KryptonPanel.TabIndex = 0
        '
        'dgItemPedido
        '
        Me.dgItemPedido.AllowUserToAddRows = False
        Me.dgItemPedido.AllowUserToDeleteRows = False
        Me.dgItemPedido.ColumnHeadersHeight = 35
        Me.dgItemPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgItemPedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CHK, Me.CMRCLR, Me.TMRCD2, Me.CUNCN5, Me.QSLMC, Me.SALDO, Me.QCMMC, Me.PNQSRVC, Me.NORDSR})
        Me.dgItemPedido.DataMember = "dtItemOC"
        Me.dgItemPedido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgItemPedido.Location = New System.Drawing.Point(0, 25)
        Me.dgItemPedido.MultiSelect = False
        Me.dgItemPedido.Name = "dgItemPedido"
        Me.dgItemPedido.RowHeadersWidth = 20
        Me.dgItemPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgItemPedido.Size = New System.Drawing.Size(696, 232)
        Me.dgItemPedido.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgItemPedido.TabIndex = 5
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.tstCodMercaderia, Me.tsbCancelar, Me.tss001, Me.tsbAceptar, Me.tss002})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(696, 25)
        Me.ToolStrip2.TabIndex = 4
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(114, 22)
        Me.ToolStripLabel1.Text = "Código Mercadería : "
        '
        'tstCodMercaderia
        '
        Me.tstCodMercaderia.Name = "tstCodMercaderia"
        Me.tstCodMercaderia.Size = New System.Drawing.Size(100, 25)
        '
        'tsbCancelar
        '
        Me.tsbCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbCancelar.Image = Global.SOLMIN_SA.My.Resources.Resources._exit
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(71, 22)
        Me.tsbCancelar.Text = "Cancelar"
        '
        'tss001
        '
        Me.tss001.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss001.Name = "tss001"
        Me.tss001.Size = New System.Drawing.Size(6, 25)
        '
        'tsbAceptar
        '
        Me.tsbAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbAceptar.Image = Global.SOLMIN_SA.My.Resources.Resources.retencion
        Me.tsbAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAceptar.Name = "tsbAceptar"
        Me.tsbAceptar.Size = New System.Drawing.Size(66, 22)
        Me.tsbAceptar.Text = "Aceptar"
        '
        'tss002
        '
        Me.tss002.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss002.Name = "tss002"
        Me.tss002.Size = New System.Drawing.Size(6, 25)
        '
        'CHK
        '
        Me.CHK.DataPropertyName = "CHK"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = False
        Me.CHK.DefaultCellStyle = DataGridViewCellStyle1
        Me.CHK.FalseValue = Nothing
        Me.CHK.HeaderText = "Seleccione"
        Me.CHK.IndeterminateValue = Nothing
        Me.CHK.Name = "CHK"
        Me.CHK.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CHK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CHK.TrueValue = Nothing
        '
        'CMRCLR
        '
        Me.CMRCLR.DataPropertyName = "PSCMRCLR"
        Me.CMRCLR.HeaderText = "Mercadería"
        Me.CMRCLR.Name = "CMRCLR"
        Me.CMRCLR.ReadOnly = True
        '
        'TMRCD2
        '
        Me.TMRCD2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TMRCD2.DataPropertyName = "PSTMRCD2"
        Me.TMRCD2.HeaderText = "Descripción"
        Me.TMRCD2.MinimumWidth = 100
        Me.TMRCD2.Name = "TMRCD2"
        Me.TMRCD2.ReadOnly = True
        '
        'CUNCN5
        '
        Me.CUNCN5.DataPropertyName = "PSCUNCN5"
        Me.CUNCN5.HeaderText = "Unidad Medida"
        Me.CUNCN5.Name = "CUNCN5"
        Me.CUNCN5.ReadOnly = True
        '
        'QSLMC
        '
        Me.QSLMC.DataPropertyName = "PNQSLMC"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.QSLMC.DefaultCellStyle = DataGridViewCellStyle2
        Me.QSLMC.HeaderText = "Saldo Cant."
        Me.QSLMC.Name = "QSLMC"
        Me.QSLMC.ReadOnly = True
        '
        'SALDO
        '
        Me.SALDO.DataPropertyName = "PNSALDO"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.SALDO.DefaultCellStyle = DataGridViewCellStyle3
        Me.SALDO.HeaderText = "Saldo Disponible"
        Me.SALDO.Name = "SALDO"
        Me.SALDO.ReadOnly = True
        '
        'QCMMC
        '
        Me.QCMMC.DataPropertyName = "PNQCMMC"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.QCMMC.DefaultCellStyle = DataGridViewCellStyle4
        Me.QCMMC.HeaderText = "             Cant. " & Global.Microsoft.VisualBasic.ChrW(10) & " Comprometida"
        Me.QCMMC.Name = "QCMMC"
        Me.QCMMC.ReadOnly = True
        '
        'PNQSRVC
        '
        Me.PNQSRVC.DataPropertyName = "PNQSRVC"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.PNQSRVC.DefaultCellStyle = DataGridViewCellStyle5
        Me.PNQSRVC.HeaderText = "Cantidad Solicitada"
        Me.PNQSRVC.Name = "PNQSRVC"
        Me.PNQSRVC.ReadOnly = True
        '
        'NORDSR
        '
        Me.NORDSR.DataPropertyName = "PNNORDSR"
        Me.NORDSR.HeaderText = "Orden de Servicio"
        Me.NORDSR.Name = "NORDSR"
        Me.NORDSR.ReadOnly = True
        '
        'frmAgregarDetallePedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 257)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmAgregarDetallePedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Agregar detalle Pedido"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dgItemPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
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
    Private WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Private WithEvents dgItemPedido As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents tstCodMercaderia As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsbAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss001 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tss002 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CHK As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
    Friend WithEvents CMRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMRCD2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUNCN5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QSLMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SALDO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QCMMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQSRVC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NORDSR As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
