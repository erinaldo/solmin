<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarOs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarOs))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.hgTitulo = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.txtBusqueda = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonHeaderGroup3 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.dtgMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CPRCN2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NSRCN2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TPRVCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NGUICL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NORCCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TOPMOV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NGUIRN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NCRRDC1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnEliminarTermino = New System.Windows.Forms.ToolStripButton
        Me.cmbTerminoBusqueda = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
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
        CType(Me.dtgMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.hgTitulo)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(585, 252)
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
        Me.hgTitulo.Size = New System.Drawing.Size(585, 252)
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
        Me.txtBusqueda.Size = New System.Drawing.Size(127, 22)
        Me.txtBusqueda.TabIndex = 1
        Me.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonHeaderGroup3
        '
        Me.KryptonHeaderGroup3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonHeaderGroup3.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Left
        Me.KryptonHeaderGroup3.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup3.Location = New System.Drawing.Point(0, 59)
        Me.KryptonHeaderGroup3.Name = "KryptonHeaderGroup3"
        '
        'KryptonHeaderGroup3.Panel
        '
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.dtgMercaderia)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.ToolStrip1)
        Me.KryptonHeaderGroup3.Size = New System.Drawing.Size(583, 160)
        Me.KryptonHeaderGroup3.TabIndex = 53
        Me.KryptonHeaderGroup3.Text = "Heading"
        Me.KryptonHeaderGroup3.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup3.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup3.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup3.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup3.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup3.ValuesSecondary.Heading = "Bultos"
        Me.KryptonHeaderGroup3.ValuesSecondary.Image = Nothing
        '
        'dtgMercaderia
        '
        Me.dtgMercaderia.AllowUserToAddRows = False
        Me.dtgMercaderia.AllowUserToDeleteRows = False
        Me.dtgMercaderia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgMercaderia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.CPRCN2, Me.NSRCN2, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42, Me.TPRVCL, Me.NGUICL, Me.NORCCL, Me.TOPMOV, Me.NGUIRN, Me.NCRRDC1})
        Me.dtgMercaderia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgMercaderia.Location = New System.Drawing.Point(0, 25)
        Me.dtgMercaderia.Name = "dtgMercaderia"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgMercaderia.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dtgMercaderia.Size = New System.Drawing.Size(560, 133)
        Me.dtgMercaderia.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgMercaderia.TabIndex = 2
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "CMRCLR"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Mercadería"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        Me.DataGridViewTextBoxColumn31.Width = 80
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "TMRCD2"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        '
        'CPRCN2
        '
        Me.CPRCN2.DataPropertyName = "CPRCN1"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CPRCN2.DefaultCellStyle = DataGridViewCellStyle1
        Me.CPRCN2.HeaderText = "Nro. Contenedor"
        Me.CPRCN2.MaxInputLength = 4
        Me.CPRCN2.Name = "CPRCN2"
        '
        'NSRCN2
        '
        Me.NSRCN2.DataPropertyName = "NSRCN1"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NSRCN2.DefaultCellStyle = DataGridViewCellStyle2
        Me.NSRCN2.HeaderText = "Serie Contenedor"
        Me.NSRCN2.MaxInputLength = 7
        Me.NSRCN2.Name = "NSRCN2"
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "QTRMC"
        Me.DataGridViewTextBoxColumn37.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.ReadOnly = True
        Me.DataGridViewTextBoxColumn37.Width = 60
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "CUNCN6"
        Me.DataGridViewTextBoxColumn38.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.ReadOnly = True
        Me.DataGridViewTextBoxColumn38.Width = 75
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "QTRMP"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.DataGridViewTextBoxColumn39.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn39.HeaderText = "Peso"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.ReadOnly = True
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "CUNPS6"
        Me.DataGridViewTextBoxColumn40.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.ReadOnly = True
        Me.DataGridViewTextBoxColumn40.Width = 60
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "QVLBTO"
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.DataGridViewTextBoxColumn41.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn41.HeaderText = "Volumen"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.ReadOnly = True
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "TUNVOL"
        Me.DataGridViewTextBoxColumn42.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.ReadOnly = True
        Me.DataGridViewTextBoxColumn42.Width = 60
        '
        'TPRVCL
        '
        Me.TPRVCL.DataPropertyName = "TPRVCL"
        Me.TPRVCL.HeaderText = "Proveedor"
        Me.TPRVCL.Name = "TPRVCL"
        '
        'NGUICL
        '
        Me.NGUICL.DataPropertyName = "NGUICL"
        Me.NGUICL.HeaderText = "Guía Proveedor"
        Me.NGUICL.Name = "NGUICL"
        '
        'NORCCL
        '
        Me.NORCCL.DataPropertyName = "NORCCL"
        Me.NORCCL.HeaderText = "Orden de Compra"
        Me.NORCCL.Name = "NORCCL"
        '
        'TOPMOV
        '
        Me.TOPMOV.DataPropertyName = "TOPMOV"
        Me.TOPMOV.HeaderText = "Proceso"
        Me.TOPMOV.Name = "TOPMOV"
        '
        'NGUIRN
        '
        Me.NGUIRN.DataPropertyName = "NGUIRN"
        Me.NGUIRN.HeaderText = "Guía Ransa"
        Me.NGUIRN.Name = "NGUIRN"
        '
        'NCRRDC1
        '
        Me.NCRRDC1.DataPropertyName = "NCRRDC"
        DataGridViewCellStyle5.NullValue = "0"
        Me.NCRRDC1.DefaultCellStyle = DataGridViewCellStyle5
        Me.NCRRDC1.HeaderText = "NCRRDC"
        Me.NCRRDC1.Name = "NCRRDC1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnEliminarTermino})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(560, 25)
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
        Me.cmbTerminoBusqueda.ItemHeight = 15
        Me.cmbTerminoBusqueda.Items.AddRange(New Object() {"P - Nro. Guía Proveedor", "I -  Nro. Guía Ingreso", "S - Nro. Guía Salida", "R - Nro. Guía Remisión"})
        Me.cmbTerminoBusqueda.Location = New System.Drawing.Point(102, 16)
        Me.cmbTerminoBusqueda.Name = "cmbTerminoBusqueda"
        Me.cmbTerminoBusqueda.Size = New System.Drawing.Size(259, 23)
        Me.cmbTerminoBusqueda.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbTerminoBusqueda.TabIndex = 0
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(11, 18)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(92, 20)
        Me.KryptonLabel4.TabIndex = 51
        Me.KryptonLabel4.Text = "Búsqueda por : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Búsqueda por : "
        '
        'frmBuscarOs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 252)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBuscarOs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar "
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
        CType(Me.dtgMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents txtBusqueda As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents BtnEliminarTermino As System.Windows.Forms.ToolStripButton
    Friend WithEvents dtgMercaderia As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPRCN2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NSRCN2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TPRVCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NGUICL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NORCCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOPMOV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NGUIRN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCRRDC1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
