<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCotizacion_X_Cliente
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
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnOk = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnSalir = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.lblBuscar = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtBuscarCotizacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.dtgCotizacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NCTZCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CMNDA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MONEDA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FCTZCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FVGCTZ = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCNCLC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NCNTRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CPLNFC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SFLZNP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SCBRMD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SFSANF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SCTZTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SESTCT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCMPN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CDVSN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CPLNDV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.dtgCotizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(722, 286)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnOk, Me.btnSalir})
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup1.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblBuscar)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtBuscarCotizacion)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtgCotizacion)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(722, 286)
        Me.KryptonHeaderGroup1.TabIndex = 2
        Me.KryptonHeaderGroup1.Text = "Lista de Cotizaciones por cliente"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Lista de Cotizaciones por cliente"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'btnOk
        '
        Me.btnOk.ExtraText = ""
        Me.btnOk.Image = My.Resources.Resources.button_ok1
        Me.btnOk.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.btnOk.Text = "Aceptar"
        Me.btnOk.ToolTipImage = Nothing
        Me.btnOk.UniqueName = "0BF1FCD5EB6142060BF1FCD5EB614206"
        '
        'btnSalir
        '
        Me.btnSalir.ExtraText = ""
        Me.btnSalir.Image = My.Resources.Resources._exit
        Me.btnSalir.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.ToolTipImage = Nothing
        Me.btnSalir.UniqueName = "69551245008940E969551245008940E9"
        '
        'lblBuscar
        '
        Me.lblBuscar.Location = New System.Drawing.Point(3, 6)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(95, 16)
        Me.lblBuscar.TabIndex = 3
        Me.lblBuscar.Text = "N° de Cotización"
        Me.lblBuscar.Values.ExtraText = ""
        Me.lblBuscar.Values.Image = Nothing
        Me.lblBuscar.Values.Text = "N° de Cotización"
        '
        'txtBuscarCotizacion
        '
        Me.txtBuscarCotizacion.Location = New System.Drawing.Point(104, 6)
        Me.txtBuscarCotizacion.Name = "txtBuscarCotizacion"
        Me.txtBuscarCotizacion.Size = New System.Drawing.Size(210, 19)
        Me.txtBuscarCotizacion.TabIndex = 2
        '
        'dtgCotizacion
        '
        Me.dtgCotizacion.AllowUserToAddRows = False
        Me.dtgCotizacion.AllowUserToDeleteRows = False
        Me.dtgCotizacion.AllowUserToOrderColumns = True
        Me.dtgCotizacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgCotizacion.ColumnHeadersHeight = 35
        Me.dtgCotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgCotizacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NCTZCN, Me.CCLNT, Me.CLIENTE, Me.CMNDA, Me.MONEDA, Me.FCTZCN, Me.FVGCTZ, Me.TCNCLC, Me.NCNTRT, Me.CPLNFC, Me.SFLZNP, Me.SCBRMD, Me.SFSANF, Me.SCTZTR, Me.SESTCT, Me.CCMPN, Me.CDVSN, Me.CPLNDV})
        Me.dtgCotizacion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgCotizacion.Location = New System.Drawing.Point(-1, 31)
        Me.dtgCotizacion.MultiSelect = False
        Me.dtgCotizacion.Name = "dtgCotizacion"
        Me.dtgCotizacion.ReadOnly = True
        Me.dtgCotizacion.RowHeadersWidth = 20
        Me.dtgCotizacion.RowTemplate.Height = 16
        Me.dtgCotizacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgCotizacion.Size = New System.Drawing.Size(722, 224)
        Me.dtgCotizacion.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgCotizacion.TabIndex = 1
        Me.dtgCotizacion.TabStop = False
        '
        'NCTZCN
        '
        Me.NCTZCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NCTZCN.DataPropertyName = "NCTZCN"
        Me.NCTZCN.Frozen = True
        Me.NCTZCN.HeaderText = "N° Cotización"
        Me.NCTZCN.Name = "NCTZCN"
        Me.NCTZCN.ReadOnly = True
        Me.NCTZCN.Width = 92
        '
        'CCLNT
        '
        Me.CCLNT.DataPropertyName = "CCLNT"
        Me.CCLNT.Frozen = True
        Me.CCLNT.HeaderText = "CCLNT"
        Me.CCLNT.Name = "CCLNT"
        Me.CCLNT.ReadOnly = True
        Me.CCLNT.Visible = False
        '
        'CLIENTE
        '
        Me.CLIENTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CLIENTE.DataPropertyName = "CLIENTE"
        Me.CLIENTE.Frozen = True
        Me.CLIENTE.HeaderText = "Cliente"
        Me.CLIENTE.Name = "CLIENTE"
        Me.CLIENTE.ReadOnly = True
        Me.CLIENTE.Width = 68
        '
        'CMNDA
        '
        Me.CMNDA.DataPropertyName = "CMNDA"
        Me.CMNDA.Frozen = True
        Me.CMNDA.HeaderText = "CMNDA"
        Me.CMNDA.Name = "CMNDA"
        Me.CMNDA.ReadOnly = True
        Me.CMNDA.Visible = False
        '
        'MONEDA
        '
        Me.MONEDA.DataPropertyName = "MONEDA"
        Me.MONEDA.Frozen = True
        Me.MONEDA.HeaderText = "Moneda"
        Me.MONEDA.Name = "MONEDA"
        Me.MONEDA.ReadOnly = True
        '
        'FCTZCN
        '
        Me.FCTZCN.DataPropertyName = "FCTZCN"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FCTZCN.DefaultCellStyle = DataGridViewCellStyle1
        Me.FCTZCN.Frozen = True
        Me.FCTZCN.HeaderText = "Fecha Cotización"
        Me.FCTZCN.Name = "FCTZCN"
        Me.FCTZCN.ReadOnly = True
        '
        'FVGCTZ
        '
        Me.FVGCTZ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FVGCTZ.DataPropertyName = "FVGCTZ"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FVGCTZ.DefaultCellStyle = DataGridViewCellStyle2
        Me.FVGCTZ.Frozen = True
        Me.FVGCTZ.HeaderText = "Fecha de Vigencia"
        Me.FVGCTZ.Name = "FVGCTZ"
        Me.FVGCTZ.ReadOnly = True
        Me.FVGCTZ.Width = 115
        '
        'TCNCLC
        '
        Me.TCNCLC.DataPropertyName = "TCNCLC"
        Me.TCNCLC.Frozen = True
        Me.TCNCLC.HeaderText = "TCNCLC"
        Me.TCNCLC.Name = "TCNCLC"
        Me.TCNCLC.ReadOnly = True
        Me.TCNCLC.Visible = False
        '
        'NCNTRT
        '
        Me.NCNTRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NCNTRT.DataPropertyName = "NCNTRT"
        Me.NCNTRT.Frozen = True
        Me.NCNTRT.HeaderText = "Número de contrato"
        Me.NCNTRT.Name = "NCNTRT"
        Me.NCNTRT.ReadOnly = True
        Me.NCNTRT.Width = 119
        '
        'CPLNFC
        '
        Me.CPLNFC.DataPropertyName = "CPLNFC"
        Me.CPLNFC.Frozen = True
        Me.CPLNFC.HeaderText = "CPLNFC"
        Me.CPLNFC.Name = "CPLNFC"
        Me.CPLNFC.ReadOnly = True
        Me.CPLNFC.Visible = False
        '
        'SFLZNP
        '
        Me.SFLZNP.DataPropertyName = "SFLZNP"
        Me.SFLZNP.Frozen = True
        Me.SFLZNP.HeaderText = "SFLZNP"
        Me.SFLZNP.Name = "SFLZNP"
        Me.SFLZNP.ReadOnly = True
        Me.SFLZNP.Visible = False
        '
        'SCBRMD
        '
        Me.SCBRMD.DataPropertyName = "SCBRMD"
        Me.SCBRMD.Frozen = True
        Me.SCBRMD.HeaderText = "SCBRMD"
        Me.SCBRMD.Name = "SCBRMD"
        Me.SCBRMD.ReadOnly = True
        Me.SCBRMD.Visible = False
        '
        'SFSANF
        '
        Me.SFSANF.DataPropertyName = "SFSANF"
        Me.SFSANF.Frozen = True
        Me.SFSANF.HeaderText = "SFSANF"
        Me.SFSANF.Name = "SFSANF"
        Me.SFSANF.ReadOnly = True
        Me.SFSANF.Visible = False
        '
        'SCTZTR
        '
        Me.SCTZTR.DataPropertyName = "SCTZTR"
        Me.SCTZTR.Frozen = True
        Me.SCTZTR.HeaderText = "SCTZTR"
        Me.SCTZTR.Name = "SCTZTR"
        Me.SCTZTR.ReadOnly = True
        Me.SCTZTR.Visible = False
        '
        'SESTCT
        '
        Me.SESTCT.DataPropertyName = "SESTCT"
        Me.SESTCT.Frozen = True
        Me.SESTCT.HeaderText = "SESTCT"
        Me.SESTCT.Name = "SESTCT"
        Me.SESTCT.ReadOnly = True
        Me.SESTCT.Visible = False
        '
        'CCMPN
        '
        Me.CCMPN.DataPropertyName = "CCMPN"
        Me.CCMPN.Frozen = True
        Me.CCMPN.HeaderText = "CCMPN"
        Me.CCMPN.Name = "CCMPN"
        Me.CCMPN.ReadOnly = True
        Me.CCMPN.Visible = False
        '
        'CDVSN
        '
        Me.CDVSN.DataPropertyName = "CDVSN"
        Me.CDVSN.Frozen = True
        Me.CDVSN.HeaderText = "CDVSN"
        Me.CDVSN.Name = "CDVSN"
        Me.CDVSN.ReadOnly = True
        Me.CDVSN.Visible = False
        '
        'CPLNDV
        '
        Me.CPLNDV.DataPropertyName = "CPLNDV"
        Me.CPLNDV.Frozen = True
        Me.CPLNDV.HeaderText = "CPLNDV"
        Me.CPLNDV.Name = "CPLNDV"
        Me.CPLNDV.ReadOnly = True
        Me.CPLNDV.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NCTZCN"
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "N° Cotización"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CCLNT"
        Me.DataGridViewTextBoxColumn2.Frozen = True
        Me.DataGridViewTextBoxColumn2.HeaderText = "CCLNT"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CLIENTE"
        Me.DataGridViewTextBoxColumn3.Frozen = True
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CMNDA"
        Me.DataGridViewTextBoxColumn4.Frozen = True
        Me.DataGridViewTextBoxColumn4.HeaderText = "CMNDA"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "MONEDA"
        Me.DataGridViewTextBoxColumn5.Frozen = True
        Me.DataGridViewTextBoxColumn5.HeaderText = "Moneda"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "FCTZCN"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn6.Frozen = True
        Me.DataGridViewTextBoxColumn6.HeaderText = "Fecha Cotización"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "FVGCTZ"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn7.Frozen = True
        Me.DataGridViewTextBoxColumn7.HeaderText = "Fecha de Vigencia"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "TCNCLC"
        Me.DataGridViewTextBoxColumn8.Frozen = True
        Me.DataGridViewTextBoxColumn8.HeaderText = "TCNCLC"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "NCNTRT"
        Me.DataGridViewTextBoxColumn9.Frozen = True
        Me.DataGridViewTextBoxColumn9.HeaderText = "Número de contrato"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CPLNFC"
        Me.DataGridViewTextBoxColumn10.Frozen = True
        Me.DataGridViewTextBoxColumn10.HeaderText = "CPLNFC"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "SFLZNP"
        Me.DataGridViewTextBoxColumn11.Frozen = True
        Me.DataGridViewTextBoxColumn11.HeaderText = "SFLZNP"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "SCBRMD"
        Me.DataGridViewTextBoxColumn12.Frozen = True
        Me.DataGridViewTextBoxColumn12.HeaderText = "SCBRMD"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "SFSANF"
        Me.DataGridViewTextBoxColumn13.Frozen = True
        Me.DataGridViewTextBoxColumn13.HeaderText = "SFSANF"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "SCTZTR"
        Me.DataGridViewTextBoxColumn14.Frozen = True
        Me.DataGridViewTextBoxColumn14.HeaderText = "SCTZTR"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "SESTCT"
        Me.DataGridViewTextBoxColumn15.Frozen = True
        Me.DataGridViewTextBoxColumn15.HeaderText = "SESTCT"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "CCMPN"
        Me.DataGridViewTextBoxColumn16.Frozen = True
        Me.DataGridViewTextBoxColumn16.HeaderText = "CCMPN"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "CDVSN"
        Me.DataGridViewTextBoxColumn17.Frozen = True
        Me.DataGridViewTextBoxColumn17.HeaderText = "CDVSN"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "CPLNDV"
        Me.DataGridViewTextBoxColumn18.Frozen = True
        Me.DataGridViewTextBoxColumn18.HeaderText = "CPLNDV"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Visible = False
        '
        'frmCotizacion_X_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 286)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(730, 320)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(730, 320)
        Me.Name = "frmCotizacion_X_Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cotización por Cliente"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.dtgCotizacion, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dtgCotizacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnOk As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents NCTZCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMNDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MONEDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FCTZCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FVGCTZ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCNCLC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCNTRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPLNFC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SFLZNP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SCBRMD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SFSANF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SCTZTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESTCT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCMPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CDVSN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPLNDV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblBuscar As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtBuscarCotizacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
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
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
