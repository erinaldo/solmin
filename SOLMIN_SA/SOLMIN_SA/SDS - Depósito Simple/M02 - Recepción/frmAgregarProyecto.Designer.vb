<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarProyecto
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
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dgItemPedido = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.CHK = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.PSNRFRPD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNQCNTIT2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.tss0 = New System.Windows.Forms.ToolStripSeparator
        Me.btnGrabar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.txtNroPedido = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton
        Me.tss1 = New System.Windows.Forms.ToolStripSeparator
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgItemPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgItemPedido)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(538, 266)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 0
        '
        'dgItemPedido
        '
        Me.dgItemPedido.AllowUserToAddRows = False
        Me.dgItemPedido.AllowUserToDeleteRows = False
        Me.dgItemPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgItemPedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CHK, Me.PSNRFRPD, Me.PNQCNTIT2})
        Me.dgItemPedido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgItemPedido.Location = New System.Drawing.Point(0, 25)
        Me.dgItemPedido.Name = "dgItemPedido"
        Me.dgItemPedido.Size = New System.Drawing.Size(538, 241)
        Me.dgItemPedido.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgItemPedido.TabIndex = 3
        '
        'CHK
        '
        Me.CHK.DataPropertyName = "CHK"
        Me.CHK.HeaderText = "Seleccione"
        Me.CHK.Name = "CHK"
        Me.CHK.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CHK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'PSNRFRPD
        '
        Me.PSNRFRPD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PSNRFRPD.DataPropertyName = "nordpe"
        Me.PSNRFRPD.HeaderText = "Numero Proyecto"
        Me.PSNRFRPD.MaxInputLength = 10
        Me.PSNRFRPD.Name = "PSNRFRPD"
        Me.PSNRFRPD.ReadOnly = True
        '
        'PNQCNTIT2
        '
        Me.PNQCNTIT2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PNQCNTIT2.DataPropertyName = "qitems"
        Me.PNQCNTIT2.HeaderText = "Cantidad Solicitada"
        Me.PNQCNTIT2.MaxInputLength = 21
        Me.PNQCNTIT2.Name = "PNQCNTIT2"
        Me.PNQCNTIT2.ReadOnly = True
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.tss0, Me.btnGrabar, Me.ToolStripLabel1, Me.txtNroPedido, Me.ToolStripSeparator1, Me.btnBuscar, Me.tss1})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(538, 25)
        Me.tsMenuOpciones.TabIndex = 4
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_SA.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(73, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'tss0
        '
        Me.tss0.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss0.Name = "tss0"
        Me.tss0.Size = New System.Drawing.Size(6, 25)
        '
        'btnGrabar
        '
        Me.btnGrabar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGrabar.Image = Global.SOLMIN_SA.My.Resources.Resources.filesave
        Me.btnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(62, 22)
        Me.btnGrabar.Text = "&Grabar"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(83, 22)
        Me.ToolStripLabel1.Text = "Nro. Proyecto."
        '
        'txtNroPedido
        '
        Me.txtNroPedido.Name = "txtNroPedido"
        Me.txtNroPedido.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnBuscar
        '
        Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar.Image = Global.SOLMIN_SA.My.Resources.Resources.runprog
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(62, 22)
        Me.btnBuscar.Text = "Buscar"
        '
        'tss1
        '
        Me.tss1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss1.Name = "tss1"
        Me.tss1.Size = New System.Drawing.Size(6, 25)
        '
        'frmAgregarProyecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 266)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAgregarProyecto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Proyecto"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dgItemPedido, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgItemPedido As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Friend WithEvents btnGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtNroPedido As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss0 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tss1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CHK As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PSNRFRPD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQCNTIT2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
