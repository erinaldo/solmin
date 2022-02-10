<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimientoPosicion
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
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dgDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NCRRIN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FTRNS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QTRMC1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMTRF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.auditoria = New System.Windows.Forms.DataGridViewImageColumn
        Me.CUSCRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FCHCRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HRACRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NTRMCR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FULTAC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HULTAC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CULUSA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NTRMNL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.hgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnSalir = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.txtPosicion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtSector = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtZona = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtTipoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lbl3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblt2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtOS = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lbl1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgFiltros.Panel.SuspendLayout()
        Me.hgFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgDatos)
        Me.KryptonPanel.Controls.Add(Me.hgFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(539, 439)
        Me.KryptonPanel.TabIndex = 0
        '
        'dgDatos
        '
        Me.dgDatos.AllowUserToAddRows = False
        Me.dgDatos.AllowUserToDeleteRows = False
        Me.dgDatos.AllowUserToResizeColumns = False
        Me.dgDatos.AllowUserToResizeRows = False
        Me.dgDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NCRRIN, Me.FTRNS, Me.QTRMC1, Me.TCMTRF, Me.auditoria, Me.CUSCRT, Me.FCHCRT, Me.HRACRT, Me.NTRMCR, Me.FULTAC, Me.HULTAC, Me.CULUSA, Me.NTRMNL})
        Me.dgDatos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgDatos.Location = New System.Drawing.Point(0, 127)
        Me.dgDatos.MultiSelect = False
        Me.dgDatos.Name = "dgDatos"
        Me.dgDatos.RowHeadersWidth = 20
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDatos.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgDatos.Size = New System.Drawing.Size(539, 312)
        Me.dgDatos.StandardTab = True
        Me.dgDatos.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgDatos.TabIndex = 10
        '
        'NCRRIN
        '
        Me.NCRRIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NCRRIN.DataPropertyName = "NCRRIN"
        Me.NCRRIN.HeaderText = "Correlativo"
        Me.NCRRIN.Name = "NCRRIN"
        Me.NCRRIN.Width = 92
        '
        'FTRNS
        '
        Me.FTRNS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FTRNS.DataPropertyName = "FTRNS"
        Me.FTRNS.HeaderText = "Fecha"
        Me.FTRNS.Name = "FTRNS"
        Me.FTRNS.Width = 66
        '
        'QTRMC1
        '
        Me.QTRMC1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QTRMC1.DataPropertyName = "QTRMC1"
        Me.QTRMC1.HeaderText = "Cantidad"
        Me.QTRMC1.Name = "QTRMC1"
        Me.QTRMC1.Width = 83
        '
        'TCMTRF
        '
        Me.TCMTRF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCMTRF.DataPropertyName = "TCMTRF"
        Me.TCMTRF.HeaderText = "Movimiento"
        Me.TCMTRF.Name = "TCMTRF"
        Me.TCMTRF.Width = 97
        '
        'auditoria
        '
        Me.auditoria.HeaderText = "Auditoría"
        Me.auditoria.Image = Global.SOLMIN_SA.My.Resources.Resources.icono_verdetalle
        Me.auditoria.Name = "auditoria"
        Me.auditoria.Width = 65
        '
        'CUSCRT
        '
        Me.CUSCRT.DataPropertyName = "CUSCRT"
        Me.CUSCRT.HeaderText = "CUSCRT"
        Me.CUSCRT.Name = "CUSCRT"
        Me.CUSCRT.Visible = False
        Me.CUSCRT.Width = 80
        '
        'FCHCRT
        '
        Me.FCHCRT.DataPropertyName = "FCHCRT"
        Me.FCHCRT.HeaderText = "FCHCRT"
        Me.FCHCRT.Name = "FCHCRT"
        Me.FCHCRT.Visible = False
        Me.FCHCRT.Width = 79
        '
        'HRACRT
        '
        Me.HRACRT.DataPropertyName = "HRACRT"
        Me.HRACRT.HeaderText = "HRACRT"
        Me.HRACRT.Name = "HRACRT"
        Me.HRACRT.Visible = False
        Me.HRACRT.Width = 81
        '
        'NTRMCR
        '
        Me.NTRMCR.DataPropertyName = "NTRMCR"
        Me.NTRMCR.HeaderText = "NTRMCR"
        Me.NTRMCR.Name = "NTRMCR"
        Me.NTRMCR.Visible = False
        Me.NTRMCR.Width = 83
        '
        'FULTAC
        '
        Me.FULTAC.DataPropertyName = "FULTAC"
        Me.FULTAC.HeaderText = "FULTAC"
        Me.FULTAC.Name = "FULTAC"
        Me.FULTAC.Visible = False
        Me.FULTAC.Width = 77
        '
        'HULTAC
        '
        Me.HULTAC.DataPropertyName = "HULTAC"
        Me.HULTAC.HeaderText = "HULTAC"
        Me.HULTAC.Name = "HULTAC"
        Me.HULTAC.Visible = False
        Me.HULTAC.Width = 79
        '
        'CULUSA
        '
        Me.CULUSA.DataPropertyName = "CULUSA"
        Me.CULUSA.HeaderText = "CULUSA"
        Me.CULUSA.Name = "CULUSA"
        Me.CULUSA.Visible = False
        Me.CULUSA.Width = 79
        '
        'NTRMNL
        '
        Me.NTRMNL.DataPropertyName = "NTRMNL"
        Me.NTRMNL.HeaderText = "NTRMNL"
        Me.NTRMNL.Name = "NTRMNL"
        Me.NTRMNL.Visible = False
        Me.NTRMNL.Width = 82
        '
        'hgFiltros
        '
        Me.hgFiltros.AutoSize = True
        Me.hgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnSalir})
        Me.hgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.hgFiltros.HeaderVisibleSecondary = False
        Me.hgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.hgFiltros.Name = "hgFiltros"
        '
        'hgFiltros.Panel
        '
        Me.hgFiltros.Panel.Controls.Add(Me.txtPosicion)
        Me.hgFiltros.Panel.Controls.Add(Me.txtAlmacen)
        Me.hgFiltros.Panel.Controls.Add(Me.txtSector)
        Me.hgFiltros.Panel.Controls.Add(Me.txtZona)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel3)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.hgFiltros.Panel.Controls.Add(Me.txtTipoAlmacen)
        Me.hgFiltros.Panel.Controls.Add(Me.lbl3)
        Me.hgFiltros.Panel.Controls.Add(Me.lblt2)
        Me.hgFiltros.Panel.Controls.Add(Me.txtOS)
        Me.hgFiltros.Panel.Controls.Add(Me.lbl1)
        Me.hgFiltros.Size = New System.Drawing.Size(539, 126)
        Me.hgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgFiltros.TabIndex = 9
        Me.hgFiltros.Text = "Información"
        Me.hgFiltros.ValuesPrimary.Description = ""
        Me.hgFiltros.ValuesPrimary.Heading = "Información"
        Me.hgFiltros.ValuesPrimary.Image = Nothing
        Me.hgFiltros.ValuesSecondary.Description = ""
        Me.hgFiltros.ValuesSecondary.Heading = "Resultado"
        Me.hgFiltros.ValuesSecondary.Image = Nothing
        '
        'btnSalir
        '
        Me.btnSalir.ExtraText = ""
        Me.btnSalir.Image = Nothing
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.ToolTipImage = Nothing
        Me.btnSalir.UniqueName = "F3151CC958C042ACF3151CC958C042AC"
        '
        'txtPosicion
        '
        Me.txtPosicion.Location = New System.Drawing.Point(82, 75)
        Me.txtPosicion.MaxLength = 10
        Me.txtPosicion.Name = "txtPosicion"
        Me.txtPosicion.Size = New System.Drawing.Size(160, 21)
        Me.txtPosicion.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPosicion.TabIndex = 42
        '
        'txtAlmacen
        '
        Me.txtAlmacen.Location = New System.Drawing.Point(308, 26)
        Me.txtAlmacen.MaxLength = 10
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.Size = New System.Drawing.Size(208, 21)
        Me.txtAlmacen.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAlmacen.TabIndex = 41
        '
        'txtSector
        '
        Me.txtSector.Location = New System.Drawing.Point(308, 52)
        Me.txtSector.MaxLength = 10
        Me.txtSector.Name = "txtSector"
        Me.txtSector.Size = New System.Drawing.Size(208, 21)
        Me.txtSector.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSector.TabIndex = 40
        '
        'txtZona
        '
        Me.txtZona.Location = New System.Drawing.Point(82, 52)
        Me.txtZona.MaxLength = 10
        Me.txtZona.Name = "txtZona"
        Me.txtZona.Size = New System.Drawing.Size(160, 21)
        Me.txtZona.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtZona.TabIndex = 39
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(3, 75)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(52, 19)
        Me.KryptonLabel3.TabIndex = 38
        Me.KryptonLabel3.Text = "Posición"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Posición"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(248, 55)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(42, 19)
        Me.KryptonLabel2.TabIndex = 37
        Me.KryptonLabel2.Text = "Sector"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Sector"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(3, 52)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(35, 19)
        Me.KryptonLabel1.TabIndex = 36
        Me.KryptonLabel1.Text = "Zona"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Zona"
        '
        'txtTipoAlmacen
        '
        Me.txtTipoAlmacen.Location = New System.Drawing.Point(82, 30)
        Me.txtTipoAlmacen.MaxLength = 10
        Me.txtTipoAlmacen.Name = "txtTipoAlmacen"
        Me.txtTipoAlmacen.Size = New System.Drawing.Size(160, 21)
        Me.txtTipoAlmacen.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTipoAlmacen.TabIndex = 32
        '
        'lbl3
        '
        Me.lbl3.Location = New System.Drawing.Point(248, 29)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(53, 19)
        Me.lbl3.TabIndex = 31
        Me.lbl3.Text = "Almacén"
        Me.lbl3.Values.ExtraText = ""
        Me.lbl3.Values.Image = Nothing
        Me.lbl3.Values.Text = "Almacén"
        '
        'lblt2
        '
        Me.lblt2.Location = New System.Drawing.Point(3, 29)
        Me.lblt2.Name = "lblt2"
        Me.lblt2.Size = New System.Drawing.Size(78, 19)
        Me.lblt2.TabIndex = 29
        Me.lblt2.Text = "Tipo Almacén"
        Me.lblt2.Values.ExtraText = ""
        Me.lblt2.Values.Image = Nothing
        Me.lblt2.Values.Text = "Tipo Almacén"
        '
        'txtOS
        '
        Me.txtOS.Location = New System.Drawing.Point(82, 4)
        Me.txtOS.MaxLength = 10
        Me.txtOS.Name = "txtOS"
        Me.txtOS.Size = New System.Drawing.Size(160, 21)
        Me.txtOS.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtOS.TabIndex = 1
        '
        'lbl1
        '
        Me.lbl1.Location = New System.Drawing.Point(3, 6)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(28, 19)
        Me.lbl1.TabIndex = 2
        Me.lbl1.Text = "O S"
        Me.lbl1.Values.ExtraText = ""
        Me.lbl1.Values.Image = Nothing
        Me.lbl1.Values.Text = "O S"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Auditoría"
        Me.DataGridViewImageColumn1.Image = Global.SOLMIN_SA.My.Resources.Resources.icono_verdetalle1
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 60
        '
        'frmMovimientoPosicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 439)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(547, 473)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(547, 473)
        Me.Name = "frmMovimientoPosicion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Movimiento por Posición"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgFiltros.Panel.ResumeLayout(False)
        Me.hgFiltros.Panel.PerformLayout()
        CType(Me.hgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgFiltros.ResumeLayout(False)
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
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents hgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTipoAlmacen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lbl3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblt2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtOS As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lbl1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPosicion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtAlmacen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtSector As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtZona As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dgDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents NCRRIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FTRNS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QTRMC1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMTRF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents auditoria As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents CUSCRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FCHCRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HRACRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NTRMCR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FULTAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HULTAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CULUSA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NTRMNL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
End Class
