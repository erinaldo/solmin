<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVistaRegistros
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dtgIncidencias = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnSalir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnExportar = New System.Windows.Forms.ToolStripButton
        Me.txtIncidencia = New System.Windows.Forms.ToolStripLabel
        Me.PSCDVSN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNCPLNDV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNNINCSI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMPCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTPLNTA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNCCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTRDCCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTINCSI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FRGTRO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Hora = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TINCDT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSSNVINC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNIVEL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSSORINC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSREPORTADO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TALMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMPAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMZNA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TPRVCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDRPCP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QAINSM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUNDCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSMEDIDA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ICSTOS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TMNDA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSMONEDA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TIRALC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PRSCNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNNMRGIM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IMAGEN = New System.Windows.Forms.DataGridViewImageColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dtgIncidencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dtgIncidencias)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1079, 376)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 0
        '
        'dtgIncidencias
        '
        Me.dtgIncidencias.AllowUserToAddRows = False
        Me.dtgIncidencias.AllowUserToDeleteRows = False
        Me.dtgIncidencias.AllowUserToResizeColumns = False
        Me.dtgIncidencias.AllowUserToResizeRows = False
        Me.dtgIncidencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgIncidencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PSCDVSN, Me.PNCPLNDV, Me.PNNINCSI, Me.TCMPCL, Me.PSTPLNTA, Me.PNCCLNT, Me.PSTRDCCL, Me.PSTINCSI, Me.FRGTRO, Me.Hora, Me.TINCDT, Me.PSSNVINC, Me.PSNIVEL, Me.PSSORINC, Me.PSREPORTADO, Me.TALMC, Me.TCMPAL, Me.TCMZNA, Me.TPRVCL, Me.TDRPCP, Me.QAINSM, Me.CUNDCN, Me.PSMEDIDA, Me.ICSTOS, Me.TMNDA, Me.PSMONEDA, Me.TIRALC, Me.PRSCNT, Me.PNNMRGIM, Me.IMAGEN})
        Me.dtgIncidencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgIncidencias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgIncidencias.Location = New System.Drawing.Point(0, 25)
        Me.dtgIncidencias.MultiSelect = False
        Me.dtgIncidencias.Name = "dtgIncidencias"
        Me.dtgIncidencias.ReadOnly = True
        Me.dtgIncidencias.RowHeadersWidth = 20
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgIncidencias.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dtgIncidencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgIncidencias.Size = New System.Drawing.Size(1079, 351)
        Me.dtgIncidencias.StandardTab = True
        Me.dtgIncidencias.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dtgIncidencias.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgIncidencias.TabIndex = 67
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSalir, Me.ToolStripSeparator1, Me.btnExportar, Me.txtIncidencia})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1079, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnSalir
        '
        Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalir.Image = Global.Ransa.Controls.Incidencia.My.Resources.Resources._exit
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(49, 22)
        Me.btnSalir.Text = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnExportar
        '
        Me.btnExportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExportar.Image = Global.Ransa.Controls.Incidencia.My.Resources.Resources.excelicon
        Me.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(70, 22)
        Me.btnExportar.Text = "Exportar"
        '
        'txtIncidencia
        '
        Me.txtIncidencia.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncidencia.Name = "txtIncidencia"
        Me.txtIncidencia.Size = New System.Drawing.Size(72, 22)
        Me.txtIncidencia.Text = "Incidencia : "
        '
        'PSCDVSN
        '
        Me.PSCDVSN.DataPropertyName = "PSCDVSN"
        Me.PSCDVSN.HeaderText = "PSCDVSN"
        Me.PSCDVSN.Name = "PSCDVSN"
        Me.PSCDVSN.ReadOnly = True
        Me.PSCDVSN.Visible = False
        Me.PSCDVSN.Width = 87
        '
        'PNCPLNDV
        '
        Me.PNCPLNDV.HeaderText = "PNCPLNDV"
        Me.PNCPLNDV.Name = "PNCPLNDV"
        Me.PNCPLNDV.ReadOnly = True
        Me.PNCPLNDV.Visible = False
        Me.PNCPLNDV.Width = 97
        '
        'PNNINCSI
        '
        Me.PNNINCSI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PNNINCSI.DataPropertyName = "PNNINCSI"
        Me.PNNINCSI.HeaderText = "Nro. Inc."
        Me.PNNINCSI.MinimumWidth = 50
        Me.PNNINCSI.Name = "PNNINCSI"
        Me.PNNINCSI.ReadOnly = True
        Me.PNNINCSI.Width = 81
        '
        'TCMPCL
        '
        Me.TCMPCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCMPCL.DataPropertyName = "PSTCMPCL"
        Me.TCMPCL.HeaderText = "Cliente"
        Me.TCMPCL.MinimumWidth = 100
        Me.TCMPCL.Name = "TCMPCL"
        Me.TCMPCL.ReadOnly = True
        '
        'PSTPLNTA
        '
        Me.PSTPLNTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSTPLNTA.DataPropertyName = "PSTPLNTA"
        Me.PSTPLNTA.HeaderText = "Planta"
        Me.PSTPLNTA.MinimumWidth = 80
        Me.PSTPLNTA.Name = "PSTPLNTA"
        Me.PSTPLNTA.ReadOnly = True
        Me.PSTPLNTA.Width = 80
        '
        'PNCCLNT
        '
        Me.PNCCLNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PNCCLNT.DataPropertyName = "PNCCLNT"
        Me.PNCCLNT.HeaderText = "Código"
        Me.PNCCLNT.MinimumWidth = 50
        Me.PNCCLNT.Name = "PNCCLNT"
        Me.PNCCLNT.ReadOnly = True
        Me.PNCCLNT.Visible = False
        Me.PNCCLNT.Width = 75
        '
        'PSTRDCCL
        '
        Me.PSTRDCCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSTRDCCL.DataPropertyName = "PSTRDCCL"
        Me.PSTRDCCL.HeaderText = "Doc. Ref. Cliente"
        Me.PSTRDCCL.MinimumWidth = 100
        Me.PSTRDCCL.Name = "PSTRDCCL"
        Me.PSTRDCCL.ReadOnly = True
        Me.PSTRDCCL.Width = 123
        '
        'PSTINCSI
        '
        Me.PSTINCSI.DataPropertyName = "PSTINCSI"
        Me.PSTINCSI.HeaderText = "Tipo Incidencia"
        Me.PSTINCSI.Name = "PSTINCSI"
        Me.PSTINCSI.ReadOnly = True
        Me.PSTINCSI.Width = 117
        '
        'FRGTRO
        '
        Me.FRGTRO.DataPropertyName = "FechaRegistro"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FRGTRO.DefaultCellStyle = DataGridViewCellStyle1
        Me.FRGTRO.HeaderText = "Fecha Registro"
        Me.FRGTRO.Name = "FRGTRO"
        Me.FRGTRO.ReadOnly = True
        Me.FRGTRO.Width = 113
        '
        'Hora
        '
        Me.Hora.DataPropertyName = "HoraRegistro"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Hora.DefaultCellStyle = DataGridViewCellStyle2
        Me.Hora.HeaderText = "Hora"
        Me.Hora.Name = "Hora"
        Me.Hora.ReadOnly = True
        Me.Hora.Width = 62
        '
        'TINCDT
        '
        Me.TINCDT.DataPropertyName = "PSTINCDT"
        Me.TINCDT.HeaderText = "Detalle Incidencia"
        Me.TINCDT.Name = "TINCDT"
        Me.TINCDT.ReadOnly = True
        Me.TINCDT.Width = 129
        '
        'PSSNVINC
        '
        Me.PSSNVINC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSSNVINC.DataPropertyName = "PSSNVINC"
        Me.PSSNVINC.HeaderText = "Cod Nivel"
        Me.PSSNVINC.MinimumWidth = 150
        Me.PSSNVINC.Name = "PSSNVINC"
        Me.PSSNVINC.ReadOnly = True
        Me.PSSNVINC.Visible = False
        Me.PSSNVINC.Width = 150
        '
        'PSNIVEL
        '
        Me.PSNIVEL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSNIVEL.DataPropertyName = "PSNIVEL"
        Me.PSNIVEL.HeaderText = "Nivel"
        Me.PSNIVEL.MinimumWidth = 40
        Me.PSNIVEL.Name = "PSNIVEL"
        Me.PSNIVEL.ReadOnly = True
        Me.PSNIVEL.Width = 63
        '
        'PSSORINC
        '
        Me.PSSORINC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSSORINC.DataPropertyName = "PSSORINC"
        Me.PSSORINC.HeaderText = "Cod Reportado"
        Me.PSSORINC.MinimumWidth = 150
        Me.PSSORINC.Name = "PSSORINC"
        Me.PSSORINC.ReadOnly = True
        Me.PSSORINC.Visible = False
        Me.PSSORINC.Width = 150
        '
        'PSREPORTADO
        '
        Me.PSREPORTADO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSREPORTADO.DataPropertyName = "PSREPORTADO"
        Me.PSREPORTADO.HeaderText = "Reportado"
        Me.PSREPORTADO.MinimumWidth = 40
        Me.PSREPORTADO.Name = "PSREPORTADO"
        Me.PSREPORTADO.ReadOnly = True
        Me.PSREPORTADO.Width = 91
        '
        'TALMC
        '
        Me.TALMC.DataPropertyName = "PSTALMC"
        Me.TALMC.HeaderText = "Tipo Almacén"
        Me.TALMC.Name = "TALMC"
        Me.TALMC.ReadOnly = True
        Me.TALMC.Width = 110
        '
        'TCMPAL
        '
        Me.TCMPAL.DataPropertyName = "PSTCMPAL"
        Me.TCMPAL.HeaderText = "Almacén"
        Me.TCMPAL.Name = "TCMPAL"
        Me.TCMPAL.ReadOnly = True
        Me.TCMPAL.Width = 83
        '
        'TCMZNA
        '
        Me.TCMZNA.DataPropertyName = "PSTCMZNA"
        Me.TCMZNA.HeaderText = "Zona Ubicación"
        Me.TCMZNA.Name = "TCMZNA"
        Me.TCMZNA.ReadOnly = True
        Me.TCMZNA.Width = 119
        '
        'TPRVCL
        '
        Me.TPRVCL.DataPropertyName = "PSTPRVCL"
        Me.TPRVCL.HeaderText = "Proveedor/Cliente"
        Me.TPRVCL.Name = "TPRVCL"
        Me.TPRVCL.ReadOnly = True
        Me.TPRVCL.Width = 132
        '
        'TDRPCP
        '
        Me.TDRPCP.DataPropertyName = "PSTDRPCP"
        Me.TDRPCP.HeaderText = "Planta"
        Me.TDRPCP.Name = "TDRPCP"
        Me.TDRPCP.ReadOnly = True
        Me.TDRPCP.Visible = False
        Me.TDRPCP.Width = 69
        '
        'QAINSM
        '
        Me.QAINSM.DataPropertyName = "PNQAINSM"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.QAINSM.DefaultCellStyle = DataGridViewCellStyle3
        Me.QAINSM.HeaderText = "Cantidad"
        Me.QAINSM.Name = "QAINSM"
        Me.QAINSM.ReadOnly = True
        Me.QAINSM.Width = 84
        '
        'CUNDCN
        '
        Me.CUNDCN.DataPropertyName = "PSCUNDCN"
        Me.CUNDCN.HeaderText = "Cod Unidad Medida"
        Me.CUNDCN.Name = "CUNDCN"
        Me.CUNDCN.ReadOnly = True
        Me.CUNDCN.Visible = False
        Me.CUNDCN.Width = 142
        '
        'PSMEDIDA
        '
        Me.PSMEDIDA.DataPropertyName = "PSMEDIDA"
        Me.PSMEDIDA.HeaderText = "Unidad Medida"
        Me.PSMEDIDA.Name = "PSMEDIDA"
        Me.PSMEDIDA.ReadOnly = True
        Me.PSMEDIDA.Width = 117
        '
        'ICSTOS
        '
        Me.ICSTOS.DataPropertyName = "PNICSTOS"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ICSTOS.DefaultCellStyle = DataGridViewCellStyle4
        Me.ICSTOS.HeaderText = "Importe"
        Me.ICSTOS.Name = "ICSTOS"
        Me.ICSTOS.ReadOnly = True
        Me.ICSTOS.Width = 78
        '
        'TMNDA
        '
        Me.TMNDA.DataPropertyName = "PSTMNDA"
        Me.TMNDA.HeaderText = "Cod Moneda"
        Me.TMNDA.Name = "TMNDA"
        Me.TMNDA.ReadOnly = True
        Me.TMNDA.Visible = False
        Me.TMNDA.Width = 105
        '
        'PSMONEDA
        '
        Me.PSMONEDA.DataPropertyName = "PSMONEDA"
        Me.PSMONEDA.HeaderText = "Moneda"
        Me.PSMONEDA.Name = "PSMONEDA"
        Me.PSMONEDA.ReadOnly = True
        Me.PSMONEDA.Width = 80
        '
        'TIRALC
        '
        Me.TIRALC.DataPropertyName = "PSTIRALC"
        Me.TIRALC.HeaderText = "Responsable"
        Me.TIRALC.Name = "TIRALC"
        Me.TIRALC.ReadOnly = True
        Me.TIRALC.Width = 102
        '
        'PRSCNT
        '
        Me.PRSCNT.DataPropertyName = "PSPRSCNT"
        Me.PRSCNT.HeaderText = "Contacto"
        Me.PRSCNT.Name = "PRSCNT"
        Me.PRSCNT.ReadOnly = True
        Me.PRSCNT.Width = 85
        '
        'PNNMRGIM
        '
        Me.PNNMRGIM.DataPropertyName = "PNNMRGIM"
        Me.PNNMRGIM.HeaderText = "PNNMRGIM"
        Me.PNNMRGIM.Name = "PNNMRGIM"
        Me.PNNMRGIM.ReadOnly = True
        Me.PNNMRGIM.Visible = False
        Me.PNNMRGIM.Width = 101
        '
        'IMAGEN
        '
        Me.IMAGEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IMAGEN.DataPropertyName = "IMAGEN"
        Me.IMAGEN.HeaderText = "Doc."
        Me.IMAGEN.Image = Global.Ransa.Controls.Incidencia.My.Resources.Resources.CuadradoBlanco
        Me.IMAGEN.MinimumWidth = 20
        Me.IMAGEN.Name = "IMAGEN"
        Me.IMAGEN.ReadOnly = True
        Me.IMAGEN.Visible = False
        Me.IMAGEN.Width = 41
        '
        'frmVistaRegistros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 376)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmVistaRegistros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Incidencias por mes"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dtgIncidencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtIncidencia As System.Windows.Forms.ToolStripLabel
    Friend WithEvents dtgIncidencias As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents PSCDVSN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNCPLNDV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNNINCSI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMPCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTPLNTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNCCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTRDCCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTINCSI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FRGTRO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TINCDT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSSNVINC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNIVEL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSSORINC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSREPORTADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TALMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMPAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMZNA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TPRVCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDRPCP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QAINSM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUNDCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSMEDIDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ICSTOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMNDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSMONEDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIRALC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRSCNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNNMRGIM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMAGEN As System.Windows.Forms.DataGridViewImageColumn
End Class
