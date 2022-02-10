<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarBulto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarBulto))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.hgTitulo = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.txtBusqueda = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonHeaderGroup3 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.dtgBultos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnEliminarTermino = New System.Windows.Forms.ToolStripButton
        Me.cmbTerminoBusqueda = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.CREFFW = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NCRRDC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CPRCN1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NSRCN1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DESCWB = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TUBRFR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QREFFW = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TIPBTO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QPSOBL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TUNPSO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QVLBTO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TUNVOL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QAROCP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.hgTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgTitulo.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgTitulo.Panel.SuspendLayout()
        Me.hgTitulo.SuspendLayout()
        CType(Me.KryptonHeaderGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup3.Panel.SuspendLayout()
        Me.KryptonHeaderGroup3.SuspendLayout()
        CType(Me.dtgBultos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.hgTitulo)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(547, 239)
        Me.KryptonPanel.TabIndex = 0
        '
        'hgTitulo
        '
        Me.hgTitulo.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnAceptar, Me.btnCancelar})
        Me.hgTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgTitulo.HeaderVisibleSecondary = False
        Me.hgTitulo.Location = New System.Drawing.Point(0, 0)
        Me.hgTitulo.Name = "hgTitulo"
        '
        'hgTitulo.Panel
        '
        Me.hgTitulo.Panel.Controls.Add(Me.txtBusqueda)
        Me.hgTitulo.Panel.Controls.Add(Me.KryptonHeaderGroup3)
        Me.hgTitulo.Panel.Controls.Add(Me.cmbTerminoBusqueda)
        Me.hgTitulo.Panel.Controls.Add(Me.KryptonLabel4)
        Me.hgTitulo.Size = New System.Drawing.Size(547, 239)
        Me.hgTitulo.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgTitulo.TabIndex = 4
        Me.hgTitulo.Text = " "
        Me.hgTitulo.ValuesPrimary.Description = " "
        Me.hgTitulo.ValuesPrimary.Heading = " "
        Me.hgTitulo.ValuesPrimary.Image = Nothing
        Me.hgTitulo.ValuesSecondary.Description = ""
        Me.hgTitulo.ValuesSecondary.Heading = "Description"
        Me.hgTitulo.ValuesSecondary.Image = Nothing
        '
        'btnAceptar
        '
        Me.btnAceptar.ExtraText = ""
        Me.btnAceptar.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.button_ok
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.ToolTipImage = Nothing
        Me.btnAceptar.UniqueName = "B05B66968A27484AB05B66968A27484A"
        '
        'btnCancelar
        '
        Me.btnCancelar.ExtraText = ""
        Me.btnCancelar.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.salir
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.ToolTipImage = Nothing
        Me.btnCancelar.UniqueName = "96C39D3CA1D348A696C39D3CA1D348A6"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(377, 16)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(127, 21)
        Me.txtBusqueda.TabIndex = 1
        Me.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonHeaderGroup3
        '
        Me.KryptonHeaderGroup3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonHeaderGroup3.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Left
        Me.KryptonHeaderGroup3.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup3.Location = New System.Drawing.Point(0, 46)
        Me.KryptonHeaderGroup3.Name = "KryptonHeaderGroup3"
        '
        'KryptonHeaderGroup3.Panel
        '
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.dtgBultos)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.ToolStrip1)
        Me.KryptonHeaderGroup3.Size = New System.Drawing.Size(545, 160)
        Me.KryptonHeaderGroup3.TabIndex = 53
        Me.KryptonHeaderGroup3.Text = "Heading"
        Me.KryptonHeaderGroup3.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup3.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup3.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup3.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup3.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup3.ValuesSecondary.Heading = "Bultos"
        Me.KryptonHeaderGroup3.ValuesSecondary.Image = Nothing
        '
        'dtgBultos
        '
        Me.dtgBultos.AllowUserToAddRows = False
        Me.dtgBultos.AllowUserToDeleteRows = False
        Me.dtgBultos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgBultos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CREFFW, Me.NCRRDC, Me.CPRCN1, Me.NSRCN1, Me.DESCWB, Me.TUBRFR, Me.QREFFW, Me.TIPBTO, Me.QPSOBL, Me.TUNPSO, Me.QVLBTO, Me.TUNVOL, Me.QAROCP, Me.SESTRG})
        Me.dtgBultos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgBultos.Location = New System.Drawing.Point(0, 25)
        Me.dtgBultos.Name = "dtgBultos"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgBultos.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dtgBultos.Size = New System.Drawing.Size(523, 133)
        Me.dtgBultos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgBultos.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnEliminarTermino})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(523, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnEliminarTermino
        '
        Me.BtnEliminarTermino.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BtnEliminarTermino.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.button_cancel
        Me.BtnEliminarTermino.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEliminarTermino.Name = "BtnEliminarTermino"
        Me.BtnEliminarTermino.Size = New System.Drawing.Size(60, 22)
        Me.BtnEliminarTermino.Text = "Quitar"
        '
        'cmbTerminoBusqueda
        '
        Me.cmbTerminoBusqueda.AutoCompleteCustomSource.AddRange(New String() {"B - Código BULTO", "P - Nro. PALETA", "D - Nro. PRE-DESPACHO", "S - Nro. GUÍA SALIDA", "G - Nro. GUÍA REMISION"})
        Me.cmbTerminoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTerminoBusqueda.DropDownWidth = 165
        Me.cmbTerminoBusqueda.FormattingEnabled = False
        Me.cmbTerminoBusqueda.ItemHeight = 13
        Me.cmbTerminoBusqueda.Items.AddRange(New Object() {"B - Código BULTO", "P - Nro. PALETA", "D - Nro. PRE-DESPACHO", "S - Nro. GUÍA SALIDA", "G - Nro. GUÍA REMISION"})
        Me.cmbTerminoBusqueda.Location = New System.Drawing.Point(102, 16)
        Me.cmbTerminoBusqueda.Name = "cmbTerminoBusqueda"
        Me.cmbTerminoBusqueda.Size = New System.Drawing.Size(259, 21)
        Me.cmbTerminoBusqueda.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbTerminoBusqueda.TabIndex = 0
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(11, 18)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(85, 19)
        Me.KryptonLabel4.TabIndex = 51
        Me.KryptonLabel4.Text = "Búsqueda por : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Búsqueda por : "
        '
        'CREFFW
        '
        Me.CREFFW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CREFFW.DataPropertyName = "CREFFW"
        Me.CREFFW.HeaderText = "Bulto"
        Me.CREFFW.Name = "CREFFW"
        Me.CREFFW.ReadOnly = True
        Me.CREFFW.Width = 80
        '
        'NCRRDC
        '
        Me.NCRRDC.DataPropertyName = "NCRRDC"
        Me.NCRRDC.HeaderText = "NCRRDC"
        Me.NCRRDC.Name = "NCRRDC"
        Me.NCRRDC.Visible = False
        '
        'CPRCN1
        '
        Me.CPRCN1.DataPropertyName = "CPRCN1"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CPRCN1.DefaultCellStyle = DataGridViewCellStyle1
        Me.CPRCN1.HeaderText = "Nro. Contenedor"
        Me.CPRCN1.MaxInputLength = 4
        Me.CPRCN1.Name = "CPRCN1"
        '
        'NSRCN1
        '
        Me.NSRCN1.DataPropertyName = "NSRCN1"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NSRCN1.DefaultCellStyle = DataGridViewCellStyle2
        Me.NSRCN1.HeaderText = "Serie Contenedor"
        Me.NSRCN1.MaxInputLength = 7
        Me.NSRCN1.Name = "NSRCN1"
        '
        'DESCWB
        '
        Me.DESCWB.DataPropertyName = "DESCWB"
        Me.DESCWB.HeaderText = "Descripción"
        Me.DESCWB.Name = "DESCWB"
        Me.DESCWB.ReadOnly = True
        Me.DESCWB.Width = 80
        '
        'TUBRFR
        '
        Me.TUBRFR.DataPropertyName = "TUBRFR"
        Me.TUBRFR.HeaderText = "Ubicación"
        Me.TUBRFR.Name = "TUBRFR"
        Me.TUBRFR.ReadOnly = True
        '
        'QREFFW
        '
        Me.QREFFW.DataPropertyName = "QREFFW"
        Me.QREFFW.HeaderText = "Cantidad"
        Me.QREFFW.Name = "QREFFW"
        Me.QREFFW.ReadOnly = True
        Me.QREFFW.Width = 60
        '
        'TIPBTO
        '
        Me.TIPBTO.DataPropertyName = "TIPBTO"
        Me.TIPBTO.HeaderText = "Tipo Bulto"
        Me.TIPBTO.Name = "TIPBTO"
        Me.TIPBTO.ReadOnly = True
        Me.TIPBTO.Width = 75
        '
        'QPSOBL
        '
        Me.QPSOBL.DataPropertyName = "QPSOBL"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.QPSOBL.DefaultCellStyle = DataGridViewCellStyle3
        Me.QPSOBL.HeaderText = "Peso"
        Me.QPSOBL.Name = "QPSOBL"
        Me.QPSOBL.ReadOnly = True
        '
        'TUNPSO
        '
        Me.TUNPSO.DataPropertyName = "TUNPSO"
        Me.TUNPSO.HeaderText = "Unidad"
        Me.TUNPSO.Name = "TUNPSO"
        Me.TUNPSO.ReadOnly = True
        Me.TUNPSO.Width = 60
        '
        'QVLBTO
        '
        Me.QVLBTO.DataPropertyName = "QVLBTO"
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.QVLBTO.DefaultCellStyle = DataGridViewCellStyle4
        Me.QVLBTO.HeaderText = "Volumen"
        Me.QVLBTO.Name = "QVLBTO"
        Me.QVLBTO.ReadOnly = True
        '
        'TUNVOL
        '
        Me.TUNVOL.DataPropertyName = "TUNVOL"
        Me.TUNVOL.HeaderText = "Unidad"
        Me.TUNVOL.Name = "TUNVOL"
        Me.TUNVOL.ReadOnly = True
        Me.TUNVOL.Width = 60
        '
        'QAROCP
        '
        Me.QAROCP.DataPropertyName = "QAROCP"
        Me.QAROCP.HeaderText = "Area Ocupada"
        Me.QAROCP.Name = "QAROCP"
        Me.QAROCP.ReadOnly = True
        '
        'SESTRG
        '
        Me.SESTRG.DataPropertyName = "SESTRG"
        Me.SESTRG.HeaderText = "SESTRG"
        Me.SESTRG.Name = "SESTRG"
        Me.SESTRG.ReadOnly = True
        Me.SESTRG.Visible = False
        '
        'frmBuscarBulto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 239)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBuscarBulto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Bulto"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.hgTitulo.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgTitulo.Panel.ResumeLayout(False)
        Me.hgTitulo.Panel.PerformLayout()
        CType(Me.hgTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgTitulo.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup3.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup3.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup3.ResumeLayout(False)
        CType(Me.dtgBultos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
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
    Friend WithEvents hgTitulo As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents cmbTerminoBusqueda As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Private WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonHeaderGroup3 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents dtgBultos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents txtBusqueda As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents BtnEliminarTermino As System.Windows.Forms.ToolStripButton
    Friend WithEvents CREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCRRDC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPRCN1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NSRCN1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCWB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TUBRFR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPBTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QPSOBL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TUNPSO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QVLBTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TUNVOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QAROCP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
