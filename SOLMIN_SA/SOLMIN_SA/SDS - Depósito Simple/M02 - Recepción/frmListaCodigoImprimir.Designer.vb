<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaCodigoImprimir
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaCodigoImprimir))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dgMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.tssSep02 = New System.Windows.Forms.ToolStripSeparator
        Me.btnModificar = New System.Windows.Forms.ToolStripButton
        Me.tssSep_02 = New System.Windows.Forms.ToolStripSeparator
        Me.btnMarcarItems = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.CHK = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
        Me.PSCMRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSDEMERCA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNQTRMC2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCUNCN6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNNCOPY = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNORCML = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNNRITOC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRFRPD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCPSCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_almacen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CZNALM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMZNA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCRTLTE = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgMercaderia)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(929, 360)
        Me.KryptonPanel.TabIndex = 0
        '
        'dgMercaderia
        '
        Me.dgMercaderia.AllowUserToAddRows = False
        Me.dgMercaderia.AllowUserToDeleteRows = False
        Me.dgMercaderia.AllowUserToResizeColumns = False
        Me.dgMercaderia.AllowUserToResizeRows = False
        Me.dgMercaderia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgMercaderia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CHK, Me.PSCMRCLR, Me.PSDEMERCA, Me.PNQTRMC2, Me.PSCUNCN6, Me.PNNCOPY, Me.PSNORCML, Me.PNNRITOC, Me.NRFRPD, Me.PSCPSCN, Me.vc_almacen, Me.CZNALM, Me.TCMZNA, Me.PSCRTLTE})
        Me.dgMercaderia.DataMember = "dtMercaderiaSeleccionadas"
        Me.dgMercaderia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMercaderia.Location = New System.Drawing.Point(0, 25)
        Me.dgMercaderia.MultiSelect = False
        Me.dgMercaderia.Name = "dgMercaderia"
        Me.dgMercaderia.RowHeadersWidth = 20
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMercaderia.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgMercaderia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMercaderia.Size = New System.Drawing.Size(929, 335)
        Me.dgMercaderia.StandardTab = True
        Me.dgMercaderia.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgMercaderia.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgMercaderia.TabIndex = 25
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnEliminar, Me.tssSep02, Me.btnModificar, Me.tssSep_02, Me.btnMarcarItems})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(929, 25)
        Me.tsMenuOpciones.TabIndex = 26
        '
        'btnEliminar
        '
        Me.btnEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminar.Image = Global.SOLMIN_SA.My.Resources.Resources._exit
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(73, 22)
        Me.btnEliminar.Text = "Cancelar"
        '
        'tssSep02
        '
        Me.tssSep02.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep02.Name = "tssSep02"
        Me.tssSep02.Size = New System.Drawing.Size(6, 25)
        '
        'btnModificar
        '
        Me.btnModificar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnModificar.Image = Global.SOLMIN_SA.My.Resources.Resources.mime_resource
        Me.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(73, 22)
        Me.btnModificar.Text = "Imprimir"
        '
        'tssSep_02
        '
        Me.tssSep_02.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_02.Name = "tssSep_02"
        Me.tssSep_02.Size = New System.Drawing.Size(6, 25)
        '
        'btnMarcarItems
        '
        Me.btnMarcarItems.BackgroundImage = CType(resources.GetObject("btnMarcarItems.BackgroundImage"), System.Drawing.Image)
        Me.btnMarcarItems.CheckOnClick = True
        Me.btnMarcarItems.Image = CType(resources.GetObject("btnMarcarItems.Image"), System.Drawing.Image)
        Me.btnMarcarItems.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMarcarItems.Name = "btnMarcarItems"
        Me.btnMarcarItems.Size = New System.Drawing.Size(103, 22)
        Me.btnMarcarItems.Text = " &Marcar Todos"
        '
        'CHK
        '
        Me.CHK.DataPropertyName = "CHK"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = False
        Me.CHK.DefaultCellStyle = DataGridViewCellStyle1
        Me.CHK.FalseValue = Nothing
        Me.CHK.HeaderText = "Chk"
        Me.CHK.IndeterminateValue = Nothing
        Me.CHK.Name = "CHK"
        Me.CHK.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CHK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CHK.TrueValue = Nothing
        Me.CHK.Width = 57
        '
        'PSCMRCLR
        '
        Me.PSCMRCLR.DataPropertyName = "PSCMRCLR"
        Me.PSCMRCLR.HeaderText = "Código Mercadería"
        Me.PSCMRCLR.Name = "PSCMRCLR"
        Me.PSCMRCLR.ReadOnly = True
        Me.PSCMRCLR.Width = 137
        '
        'PSDEMERCA
        '
        Me.PSDEMERCA.DataPropertyName = "PSDEMERCA"
        Me.PSDEMERCA.HeaderText = "Descripción"
        Me.PSDEMERCA.Name = "PSDEMERCA"
        Me.PSDEMERCA.ReadOnly = True
        Me.PSDEMERCA.Width = 98
        '
        'PNQTRMC2
        '
        Me.PNQTRMC2.DataPropertyName = "PNQTRMC"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = "0"
        Me.PNQTRMC2.DefaultCellStyle = DataGridViewCellStyle2
        Me.PNQTRMC2.HeaderText = "Cantidad"
        Me.PNQTRMC2.Name = "PNQTRMC2"
        Me.PNQTRMC2.Width = 84
        '
        'PSCUNCN6
        '
        Me.PSCUNCN6.DataPropertyName = "PSCUNCN6"
        Me.PSCUNCN6.HeaderText = "Unidad"
        Me.PSCUNCN6.Name = "PSCUNCN6"
        Me.PSCUNCN6.ReadOnly = True
        Me.PSCUNCN6.Width = 74
        '
        'PNNCOPY
        '
        Me.PNNCOPY.DataPropertyName = "PNNCOPY"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = "0"
        Me.PNNCOPY.DefaultCellStyle = DataGridViewCellStyle3
        Me.PNNCOPY.HeaderText = "Nr. Copias"
        Me.PNNCOPY.Name = "PNNCOPY"
        Me.PNNCOPY.Width = 91
        '
        'PSNORCML
        '
        Me.PSNORCML.DataPropertyName = "PSNORCML"
        Me.PSNORCML.HeaderText = "Orden de Compra"
        Me.PSNORCML.Name = "PSNORCML"
        Me.PSNORCML.ReadOnly = True
        Me.PSNORCML.Width = 131
        '
        'PNNRITOC
        '
        Me.PNNRITOC.DataPropertyName = "PNNRITOC"
        Me.PNNRITOC.HeaderText = "Nr. Item"
        Me.PNNRITOC.Name = "PNNRITOC"
        Me.PNNRITOC.ReadOnly = True
        Me.PNNRITOC.Width = 79
        '
        'NRFRPD
        '
        Me.NRFRPD.DataPropertyName = "PSNRFRPD"
        Me.NRFRPD.HeaderText = "Pedido"
        Me.NRFRPD.Name = "NRFRPD"
        Me.NRFRPD.ReadOnly = True
        Me.NRFRPD.Width = 73
        '
        'PSCPSCN
        '
        Me.PSCPSCN.DataPropertyName = "PSCPSCN"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PSCPSCN.DefaultCellStyle = DataGridViewCellStyle4
        Me.PSCPSCN.HeaderText = "Posición"
        Me.PSCPSCN.Name = "PSCPSCN"
        Me.PSCPSCN.ReadOnly = True
        Me.PSCPSCN.Width = 81
        '
        'vc_almacen
        '
        Me.vc_almacen.DataPropertyName = "PSTRFRN2"
        Me.vc_almacen.HeaderText = "Proyecto"
        Me.vc_almacen.Name = "vc_almacen"
        Me.vc_almacen.ReadOnly = True
        Me.vc_almacen.Width = 83
        '
        'CZNALM
        '
        Me.CZNALM.DataPropertyName = "PSCZNALM"
        Me.CZNALM.HeaderText = "Almacén"
        Me.CZNALM.Name = "CZNALM"
        Me.CZNALM.ReadOnly = True
        Me.CZNALM.Width = 83
        '
        'TCMZNA
        '
        Me.TCMZNA.DataPropertyName = "PSTCMZNA"
        Me.TCMZNA.HeaderText = "TCMZNA"
        Me.TCMZNA.Name = "TCMZNA"
        Me.TCMZNA.ReadOnly = True
        Me.TCMZNA.Visible = False
        Me.TCMZNA.Width = 86
        '
        'PSCRTLTE
        '
        Me.PSCRTLTE.DataPropertyName = "PSCRTLTE"
        Me.PSCRTLTE.HeaderText = "Lote"
        Me.PSCRTLTE.Name = "PSCRTLTE"
        Me.PSCRTLTE.Width = 59
        '
        'frmListaCodigoImprimir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 360)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmListaCodigoImprimir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Lista Mercadería Imprimir"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dgMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgMercaderia As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep02 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_02 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnMarcarItems As System.Windows.Forms.ToolStripButton
    Friend WithEvents CHK As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
    Friend WithEvents PSCMRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSDEMERCA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQTRMC2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCUNCN6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNNCOPY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNORCML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNNRITOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRFRPD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCPSCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_almacen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CZNALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMZNA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCRTLTE As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
