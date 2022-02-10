<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCopiarPerfil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCopiarPerfil))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dtgIncidencias = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCopiarPerfil = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCheck = New System.Windows.Forms.ToolStripButton
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.txtCompania = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtClienteDestino = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtClienteOrigen = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.cmbDivision1 = New Ransa.Utilitario.CheckComboBoxGeneral.CheckedComboBoxGeneral
        Me.CHECK = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.CDVSN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMPDV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CINCID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TINCSI = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dtgIncidencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dtgIncidencias)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(759, 461)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 0
        '
        'dtgIncidencias
        '
        Me.dtgIncidencias.AllowUserToAddRows = False
        Me.dtgIncidencias.AllowUserToDeleteRows = False
        Me.dtgIncidencias.AllowUserToResizeColumns = False
        Me.dtgIncidencias.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgIncidencias.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgIncidencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgIncidencias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgIncidencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CHECK, Me.CDVSN, Me.TCMPDV, Me.CINCID, Me.TINCSI})
        Me.dtgIncidencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgIncidencias.Location = New System.Drawing.Point(0, 103)
        Me.dtgIncidencias.MultiSelect = False
        Me.dtgIncidencias.Name = "dtgIncidencias"
        Me.dtgIncidencias.RowHeadersWidth = 10
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dtgIncidencias.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgIncidencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgIncidencias.Size = New System.Drawing.Size(759, 358)
        Me.dtgIncidencias.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dtgIncidencias.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgIncidencias.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.SystemColors.WindowText
        Me.dtgIncidencias.TabIndex = 79
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.ToolStripSeparator2, Me.btnCopiarPerfil, Me.ToolStripSeparator1, Me.btnCheck})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 78)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(759, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnBuscar
        '
        Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar.Image = Global.Ransa.Controls.Incidencia.My.Resources.Resources.search1
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(62, 22)
        Me.btnBuscar.Text = "Buscar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnCopiarPerfil
        '
        Me.btnCopiarPerfil.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCopiarPerfil.Image = Global.Ransa.Controls.Incidencia.My.Resources.Resources.button_ok
        Me.btnCopiarPerfil.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCopiarPerfil.Name = "btnCopiarPerfil"
        Me.btnCopiarPerfil.Size = New System.Drawing.Size(69, 22)
        Me.btnCopiarPerfil.Text = "Guardar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnCheck
        '
        Me.btnCheck.Image = Global.Ransa.Controls.Incidencia.My.Resources.Resources.btnNoMarcarItems
        Me.btnCheck.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(93, 22)
        Me.btnCheck.Text = "Check todos"
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup1.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeaderGroup1.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbDivision1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCompania)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtClienteDestino)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtClienteOrigen)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCliente)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(759, 78)
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.Text = "Heading"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup1.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'txtCompania
        '
        Me.txtCompania.Enabled = False
        Me.txtCompania.Location = New System.Drawing.Point(108, 12)
        Me.txtCompania.Name = "txtCompania"
        Me.txtCompania.Size = New System.Drawing.Size(250, 22)
        Me.txtCompania.TabIndex = 93
        '
        'txtClienteDestino
        '
        Me.txtClienteDestino.Enabled = False
        Me.txtClienteDestino.Location = New System.Drawing.Point(483, 42)
        Me.txtClienteDestino.Name = "txtClienteDestino"
        Me.txtClienteDestino.Size = New System.Drawing.Size(248, 22)
        Me.txtClienteDestino.TabIndex = 93
        '
        'txtClienteOrigen
        '
        Me.txtClienteOrigen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtClienteOrigen.BackColor = System.Drawing.Color.Transparent
        Me.txtClienteOrigen.CCMPN = "EZ"
        Me.txtClienteOrigen.Location = New System.Drawing.Point(108, 40)
        Me.txtClienteOrigen.Name = "txtClienteOrigen"
        Me.txtClienteOrigen.pAccesoPorUsuario = True
        Me.txtClienteOrigen.pRequerido = False
        Me.txtClienteOrigen.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtClienteOrigen.Size = New System.Drawing.Size(250, 22)
        Me.txtClienteOrigen.TabIndex = 92
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(379, 14)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(60, 20)
        Me.KryptonLabel3.TabIndex = 90
        Me.KryptonLabel3.Text = "División :"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "División :"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(11, 14)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(72, 20)
        Me.KryptonLabel1.TabIndex = 90
        Me.KryptonLabel1.Text = "Compañia :"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Compañia :"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(11, 40)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(93, 20)
        Me.lblCliente.TabIndex = 90
        Me.lblCliente.Text = "Cliente origen :"
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente origen :"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(379, 44)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(98, 20)
        Me.KryptonLabel2.TabIndex = 89
        Me.KryptonLabel2.Text = "Cliente destino :"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Cliente destino :"
        '
        'cmbDivision1
        '
        Me.cmbDivision1.CheckOnClick = True
        Me.cmbDivision1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbDivision1.DropDownHeight = 1
        Me.cmbDivision1.FormattingEnabled = True
        Me.cmbDivision1.IntegralHeight = False
        Me.cmbDivision1.Location = New System.Drawing.Point(483, 11)
        Me.cmbDivision1.Name = "cmbDivision1"
        Me.cmbDivision1.Size = New System.Drawing.Size(248, 21)
        Me.cmbDivision1.TabIndex = 94
        Me.cmbDivision1.ValueSeparator = ", "
        '
        'CHECK
        '
        Me.CHECK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CHECK.HeaderText = "Check"
        Me.CHECK.MinimumWidth = 50
        Me.CHECK.Name = "CHECK"
        Me.CHECK.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CHECK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CHECK.Width = 69
        '
        'CDVSN
        '
        Me.CDVSN.DataPropertyName = "CDVSN"
        Me.CDVSN.HeaderText = "CDVSN"
        Me.CDVSN.Name = "CDVSN"
        Me.CDVSN.Visible = False
        '
        'TCMPDV
        '
        Me.TCMPDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCMPDV.DataPropertyName = "TCMPDV"
        Me.TCMPDV.HeaderText = "División"
        Me.TCMPDV.MinimumWidth = 100
        Me.TCMPDV.Name = "TCMPDV"
        '
        'CINCID
        '
        Me.CINCID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CINCID.DataPropertyName = "CINCID"
        Me.CINCID.HeaderText = "Código"
        Me.CINCID.MinimumWidth = 50
        Me.CINCID.Name = "CINCID"
        Me.CINCID.Width = 75
        '
        'TINCSI
        '
        Me.TINCSI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TINCSI.DataPropertyName = "TINCSI"
        Me.TINCSI.HeaderText = "Descripción"
        Me.TINCSI.MinimumWidth = 200
        Me.TINCSI.Name = "TINCSI"
        '
        'frmCopiarPerfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 461)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCopiarPerfil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StateActive.Back.Color1 = System.Drawing.Color.White
        Me.Text = "Copiar perfil"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dtgIncidencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
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
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents txtClienteOrigen As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtClienteDestino As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCopiarPerfil As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCheck As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCompania As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents dtgIncidencias As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents cmbDivision1 As Ransa.Utilitario.CheckComboBoxGeneral.CheckedComboBoxGeneral
    Friend WithEvents CHECK As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CDVSN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMPDV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CINCID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TINCSI As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
