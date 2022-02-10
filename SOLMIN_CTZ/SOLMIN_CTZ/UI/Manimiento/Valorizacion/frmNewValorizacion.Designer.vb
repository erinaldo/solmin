<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewValorizacion
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewValorizacion))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.dtgOperaciones = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.chkColumn = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn()
        Me.Division = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TPOPER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Planta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOPRCN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NGUIRM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NDCPRF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NPRLQD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NSECFC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMPORTE_S = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMPORTE_D = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SESTOP_DESC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPLNDV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CDVSN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btnProcesar = New System.Windows.Forms.ToolStripButton()
        Me.btnCheck = New System.Windows.Forms.ToolStripButton()
        Me.HGFiltro = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.txtoperacion = New System.Windows.Forms.TextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cboDivision2 = New Ransa.Utilitario.CheckComboBoxGeneral.CheckedComboBoxGeneral()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.TypeValidator1 = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dtgOperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.HGFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HGFiltro.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HGFiltro.Panel.SuspendLayout()
        Me.HGFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dtgOperaciones)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Controls.Add(Me.HGFiltro)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1254, 643)
        Me.KryptonPanel.TabIndex = 0
        '
        'dtgOperaciones
        '
        Me.dtgOperaciones.AllowUserToAddRows = False
        Me.dtgOperaciones.AllowUserToDeleteRows = False
        Me.dtgOperaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgOperaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chkColumn, Me.Division, Me.TPOPER, Me.Planta, Me.NOPRCN, Me.NGUIRM, Me.NDCPRF, Me.NPRLQD, Me.NSECFC, Me.IMPORTE_S, Me.IMPORTE_D, Me.SESTOP_DESC, Me.CPLNDV, Me.CDVSN})
        Me.dtgOperaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgOperaciones.Location = New System.Drawing.Point(0, 111)
        Me.dtgOperaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgOperaciones.Name = "dtgOperaciones"
        Me.dtgOperaciones.Size = New System.Drawing.Size(1254, 532)
        Me.dtgOperaciones.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dtgOperaciones.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgOperaciones.TabIndex = 8
        '
        'chkColumn
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.NullValue = False
        Me.chkColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.chkColumn.FalseValue = Nothing
        Me.chkColumn.HeaderText = "chk"
        Me.chkColumn.IndeterminateValue = Nothing
        Me.chkColumn.Name = "chkColumn"
        Me.chkColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.chkColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.chkColumn.TrueValue = Nothing
        Me.chkColumn.Width = 50
        '
        'Division
        '
        Me.Division.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Division.DataPropertyName = "DIVISION"
        Me.Division.HeaderText = "División"
        Me.Division.Name = "Division"
        Me.Division.ReadOnly = True
        Me.Division.Width = 95
        '
        'TPOPER
        '
        Me.TPOPER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TPOPER.DataPropertyName = "TPOPER"
        Me.TPOPER.HeaderText = "Tipo"
        Me.TPOPER.Name = "TPOPER"
        Me.TPOPER.ReadOnly = True
        Me.TPOPER.Width = 72
        '
        'Planta
        '
        Me.Planta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Planta.DataPropertyName = "PLANTA"
        Me.Planta.HeaderText = "Planta"
        Me.Planta.Name = "Planta"
        Me.Planta.ReadOnly = True
        Me.Planta.Width = 83
        '
        'NOPRCN
        '
        Me.NOPRCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NOPRCN.DataPropertyName = "NOPRCN"
        Me.NOPRCN.HeaderText = "Operación"
        Me.NOPRCN.Name = "NOPRCN"
        Me.NOPRCN.ReadOnly = True
        Me.NOPRCN.Width = 111
        '
        'NGUIRM
        '
        Me.NGUIRM.DataPropertyName = "NGUIRM"
        Me.NGUIRM.HeaderText = "Guía Transporte"
        Me.NGUIRM.Name = "NGUIRM"
        Me.NGUIRM.ReadOnly = True
        Me.NGUIRM.Visible = False
        '
        'NDCPRF
        '
        Me.NDCPRF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NDCPRF.DataPropertyName = "NDCPRF"
        Me.NDCPRF.HeaderText = "Pre-Factura"
        Me.NDCPRF.Name = "NDCPRF"
        Me.NDCPRF.ReadOnly = True
        Me.NDCPRF.Width = 116
        '
        'NPRLQD
        '
        Me.NPRLQD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NPRLQD.DataPropertyName = "NPRLQD"
        Me.NPRLQD.HeaderText = "Pre-Liquidación"
        Me.NPRLQD.Name = "NPRLQD"
        Me.NPRLQD.ReadOnly = True
        Me.NPRLQD.Visible = False
        '
        'NSECFC
        '
        Me.NSECFC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NSECFC.DataPropertyName = "NSECFC"
        Me.NSECFC.HeaderText = "Nro. Consistencia"
        Me.NSECFC.Name = "NSECFC"
        Me.NSECFC.ReadOnly = True
        Me.NSECFC.Width = 156
        '
        'IMPORTE_S
        '
        Me.IMPORTE_S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IMPORTE_S.DataPropertyName = "IMPORTE_S"
        Me.IMPORTE_S.HeaderText = "Importe S/"
        Me.IMPORTE_S.Name = "IMPORTE_S"
        Me.IMPORTE_S.ReadOnly = True
        Me.IMPORTE_S.Width = 113
        '
        'IMPORTE_D
        '
        Me.IMPORTE_D.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IMPORTE_D.DataPropertyName = "IMPORTE_D"
        Me.IMPORTE_D.HeaderText = "Importe U$"
        Me.IMPORTE_D.Name = "IMPORTE_D"
        Me.IMPORTE_D.ReadOnly = True
        Me.IMPORTE_D.Width = 117
        '
        'SESTOP_DESC
        '
        Me.SESTOP_DESC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SESTOP_DESC.DataPropertyName = "SESTOP_DESC"
        Me.SESTOP_DESC.HeaderText = "Estado OP"
        Me.SESTOP_DESC.Name = "SESTOP_DESC"
        Me.SESTOP_DESC.ReadOnly = True
        Me.SESTOP_DESC.Width = 110
        '
        'CPLNDV
        '
        Me.CPLNDV.DataPropertyName = "CPLNDV"
        Me.CPLNDV.HeaderText = "CPLNDV"
        Me.CPLNDV.Name = "CPLNDV"
        Me.CPLNDV.ReadOnly = True
        Me.CPLNDV.Visible = False
        '
        'CDVSN
        '
        Me.CDVSN.DataPropertyName = "CDVSN"
        Me.CDVSN.HeaderText = "CDVSN"
        Me.CDVSN.Name = "CDVSN"
        Me.CDVSN.ReadOnly = True
        Me.CDVSN.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnCancelar, Me.btnProcesar, Me.btnCheck})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 84)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1254, 27)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnBuscar
        '
        Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(95, 24)
        Me.btnBuscar.Text = "Consultar"
        Me.btnBuscar.ToolTipText = "Consultar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_CT.My.Resources.Resources.anular1
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 24)
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnProcesar
        '
        Me.btnProcesar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnProcesar.Image = Global.SOLMIN_CT.My.Resources.Resources.effect
        Me.btnProcesar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(83, 24)
        Me.btnProcesar.Text = "Asignar"
        '
        'btnCheck
        '
        Me.btnCheck.Image = Global.SOLMIN_CT.My.Resources.Resources.descargar_banco
        Me.btnCheck.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(72, 24)
        Me.btnCheck.Text = "Check"
        '
        'HGFiltro
        '
        Me.HGFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.HGFiltro.HeaderVisibleSecondary = False
        Me.HGFiltro.Location = New System.Drawing.Point(0, 0)
        Me.HGFiltro.Margin = New System.Windows.Forms.Padding(4)
        Me.HGFiltro.Name = "HGFiltro"
        '
        'HGFiltro.Panel
        '
        Me.HGFiltro.Panel.Controls.Add(Me.txtoperacion)
        Me.HGFiltro.Panel.Controls.Add(Me.KryptonLabel1)
        Me.HGFiltro.Panel.Controls.Add(Me.cboDivision2)
        Me.HGFiltro.Panel.Controls.Add(Me.KryptonLabel5)
        Me.HGFiltro.Size = New System.Drawing.Size(1254, 84)
        Me.HGFiltro.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HGFiltro.TabIndex = 2
        Me.HGFiltro.Text = "Filtro"
        Me.HGFiltro.ValuesPrimary.Description = ""
        Me.HGFiltro.ValuesPrimary.Heading = "Filtro"
        Me.HGFiltro.ValuesPrimary.Image = Nothing
        Me.HGFiltro.ValuesSecondary.Description = ""
        Me.HGFiltro.ValuesSecondary.Heading = "Description"
        Me.HGFiltro.ValuesSecondary.Image = Nothing
        '
        'txtoperacion
        '
        Me.txtoperacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtoperacion.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtoperacion.Location = New System.Drawing.Point(487, 10)
        Me.txtoperacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtoperacion.MaxLength = 10
        Me.txtoperacion.Multiline = True
        Me.txtoperacion.Name = "txtoperacion"
        Me.txtoperacion.Size = New System.Drawing.Size(186, 24)
        Me.txtoperacion.TabIndex = 24
        Me.txtoperacion.Visible = False
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(389, 9)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(90, 24)
        Me.KryptonLabel1.TabIndex = 23
        Me.KryptonLabel1.Text = "Operación :"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Operación :"
        Me.KryptonLabel1.Visible = False
        '
        'cboDivision2
        '
        Me.cboDivision2.CheckOnClick = True
        Me.cboDivision2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboDivision2.DropDownHeight = 1
        Me.cboDivision2.FormattingEnabled = True
        Me.cboDivision2.IntegralHeight = False
        Me.cboDivision2.Location = New System.Drawing.Point(87, 11)
        Me.cboDivision2.Margin = New System.Windows.Forms.Padding(4)
        Me.cboDivision2.Name = "cboDivision2"
        Me.cboDivision2.Size = New System.Drawing.Size(273, 23)
        Me.cboDivision2.TabIndex = 21
        Me.cboDivision2.ValueSeparator = ", "
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(4, 6)
        Me.KryptonLabel5.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(73, 24)
        Me.KryptonLabel5.TabIndex = 4
        Me.KryptonLabel5.Text = "División :"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "División :"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "DIVISION"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Division"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TPOPER"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PLANTA"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Planta"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NOPRCN"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Operacion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NDCPRF"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Pre-Factura"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NPRLQD"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Pre-Liquidacion"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NSECFC"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Nro. Consistencia"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "IMPORTE_S"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Importe S/"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "IMPORTE_D"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Importe U$"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "SESTOP_DESC"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Estado OP"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'frmNewValorizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 643)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmNewValorizacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Asignar operaciones"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dtgOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.HGFiltro.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGFiltro.Panel.ResumeLayout(False)
        Me.HGFiltro.Panel.PerformLayout()
        CType(Me.HGFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGFiltro.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents HGFiltro As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnProcesar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TypeValidator1 As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents cboDivision As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtgOperaciones As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cboDivision2 As Ransa.Utilitario.CheckComboBoxGeneral.CheckedComboBoxGeneral
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtoperacion As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnCheck As System.Windows.Forms.ToolStripButton
    Friend WithEvents chkColumn As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
    Friend WithEvents Division As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TPOPER As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Planta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOPRCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NGUIRM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NDCPRF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPRLQD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NSECFC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPORTE_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPORTE_D As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESTOP_DESC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPLNDV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CDVSN As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
