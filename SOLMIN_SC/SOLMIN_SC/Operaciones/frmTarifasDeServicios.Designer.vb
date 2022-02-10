<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTarifasDeServicios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTarifasDeServicios))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dtgTarifaPorEmbarque = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NRTFSV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.STPTRA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUNDMD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VALCTE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRRUBR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CMNDA1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCNTCS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCNTCS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IVLSRV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DESTAR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KryptonHeaderGroup16 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnBuscar = New System.Windows.Forms.PictureBox
        Me.txtUbigeo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtDireccion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtFechaServicio = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbPlanta = New System.Windows.Forms.ComboBox
        Me.lblPlanta = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcClienteFacturacion = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.lblClienteFacturacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblClienteOperacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcClienteOperacion = New Ransa.Controls.Cliente.ucCliente_TxtF01
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
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dtgTarifaPorEmbarque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup16.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup16.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.btnBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dtgTarifaPorEmbarque)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup16)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(906, 302)
        Me.KryptonPanel.TabIndex = 0
        '
        'dtgTarifaPorEmbarque
        '
        Me.dtgTarifaPorEmbarque.AllowUserToAddRows = False
        Me.dtgTarifaPorEmbarque.AllowUserToDeleteRows = False
        Me.dtgTarifaPorEmbarque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgTarifaPorEmbarque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgTarifaPorEmbarque.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NRTFSV, Me.STPTRA, Me.CUNDMD, Me.VALCTE, Me.NRRUBR, Me.CMNDA1, Me.CCNTCS, Me.TCNTCS, Me.IVLSRV, Me.DESTAR})
        Me.dtgTarifaPorEmbarque.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgTarifaPorEmbarque.Location = New System.Drawing.Point(0, 142)
        Me.dtgTarifaPorEmbarque.Name = "dtgTarifaPorEmbarque"
        Me.dtgTarifaPorEmbarque.ReadOnly = True
        Me.dtgTarifaPorEmbarque.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtgTarifaPorEmbarque.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtgTarifaPorEmbarque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgTarifaPorEmbarque.Size = New System.Drawing.Size(906, 160)
        Me.dtgTarifaPorEmbarque.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dtgTarifaPorEmbarque.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgTarifaPorEmbarque.TabIndex = 0
        '
        'NRTFSV
        '
        Me.NRTFSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.NRTFSV.DataPropertyName = "NRTFSV"
        Me.NRTFSV.Frozen = True
        Me.NRTFSV.HeaderText = "Tarifa"
        Me.NRTFSV.MinimumWidth = 50
        Me.NRTFSV.Name = "NRTFSV"
        Me.NRTFSV.ReadOnly = True
        Me.NRTFSV.Width = 50
        '
        'STPTRA
        '
        Me.STPTRA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.STPTRA.DataPropertyName = "STPTRA"
        Me.STPTRA.HeaderText = "Tipo" & Global.Microsoft.VisualBasic.ChrW(10) & "Tarifa"
        Me.STPTRA.Name = "STPTRA"
        Me.STPTRA.ReadOnly = True
        Me.STPTRA.Width = 40
        '
        'CUNDMD
        '
        Me.CUNDMD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CUNDMD.DataPropertyName = "CUNDMD"
        Me.CUNDMD.HeaderText = "Unidad"
        Me.CUNDMD.MinimumWidth = 50
        Me.CUNDMD.Name = "CUNDMD"
        Me.CUNDMD.ReadOnly = True
        Me.CUNDMD.Width = 60
        '
        'VALCTE
        '
        Me.VALCTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.VALCTE.DataPropertyName = "VALCTE"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.VALCTE.DefaultCellStyle = DataGridViewCellStyle1
        Me.VALCTE.HeaderText = "Valor"
        Me.VALCTE.MinimumWidth = 50
        Me.VALCTE.Name = "VALCTE"
        Me.VALCTE.ReadOnly = True
        Me.VALCTE.Width = 63
        '
        'NRRUBR
        '
        Me.NRRUBR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.NRRUBR.DataPropertyName = "NRRUBR"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.NRRUBR.DefaultCellStyle = DataGridViewCellStyle2
        Me.NRRUBR.HeaderText = "Rubro"
        Me.NRRUBR.MinimumWidth = 45
        Me.NRRUBR.Name = "NRRUBR"
        Me.NRRUBR.ReadOnly = True
        Me.NRRUBR.Width = 45
        '
        'CMNDA1
        '
        Me.CMNDA1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CMNDA1.DataPropertyName = "CMNDA1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CMNDA1.DefaultCellStyle = DataGridViewCellStyle3
        Me.CMNDA1.HeaderText = "Moneda"
        Me.CMNDA1.MinimumWidth = 50
        Me.CMNDA1.Name = "CMNDA1"
        Me.CMNDA1.ReadOnly = True
        Me.CMNDA1.Width = 50
        '
        'CCNTCS
        '
        Me.CCNTCS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CCNTCS.DataPropertyName = "CCNTCS"
        Me.CCNTCS.HeaderText = "Cód. Centro De Beneficio"
        Me.CCNTCS.MinimumWidth = 50
        Me.CCNTCS.Name = "CCNTCS"
        Me.CCNTCS.ReadOnly = True
        Me.CCNTCS.Width = 70
        '
        'TCNTCS
        '
        Me.TCNTCS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCNTCS.DataPropertyName = "TCNTCS"
        Me.TCNTCS.HeaderText = "Centro de Beneficio"
        Me.TCNTCS.MinimumWidth = 50
        Me.TCNTCS.Name = "TCNTCS"
        Me.TCNTCS.ReadOnly = True
        Me.TCNTCS.Width = 128
        '
        'IVLSRV
        '
        Me.IVLSRV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IVLSRV.DataPropertyName = "IVLSRV"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.IVLSRV.DefaultCellStyle = DataGridViewCellStyle4
        Me.IVLSRV.HeaderText = "Valor de" & Global.Microsoft.VisualBasic.ChrW(10) & "Servicio"
        Me.IVLSRV.MinimumWidth = 50
        Me.IVLSRV.Name = "IVLSRV"
        Me.IVLSRV.ReadOnly = True
        Me.IVLSRV.Width = 79
        '
        'DESTAR
        '
        Me.DESTAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DESTAR.DataPropertyName = "DESTAR"
        Me.DESTAR.HeaderText = "Desc. Servicio"
        Me.DESTAR.MinimumWidth = 230
        Me.DESTAR.Name = "DESTAR"
        Me.DESTAR.ReadOnly = True
        Me.DESTAR.Width = 230
        '
        'KryptonHeaderGroup16
        '
        Me.KryptonHeaderGroup16.AutoSize = True
        Me.KryptonHeaderGroup16.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnAceptar, Me.btnCancelar})
        Me.KryptonHeaderGroup16.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup16.Location = New System.Drawing.Point(0, 110)
        Me.KryptonHeaderGroup16.Name = "KryptonHeaderGroup16"
        Me.KryptonHeaderGroup16.Size = New System.Drawing.Size(906, 32)
        Me.KryptonHeaderGroup16.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup16.TabIndex = 33
        Me.KryptonHeaderGroup16.Text = "Tarifas-Seleccione la tarifa correspodiente"
        Me.KryptonHeaderGroup16.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup16.ValuesPrimary.Heading = "Tarifas-Seleccione la tarifa correspodiente"
        Me.KryptonHeaderGroup16.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup16.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup16.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup16.ValuesSecondary.Image = Nothing
        '
        'btnAceptar
        '
        Me.btnAceptar.ExtraText = ""
        Me.btnAceptar.Image = Global.SOLMIN_SC.My.Resources.Resources.button_ok1
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.ToolTipImage = Nothing
        Me.btnAceptar.UniqueName = "948B02FEA5174CE9948B02FEA5174CE9"
        '
        'btnCancelar
        '
        Me.btnCancelar.ExtraText = ""
        Me.btnCancelar.Image = Global.SOLMIN_SC.My.Resources.Resources._exit
        Me.btnCancelar.Text = "Salir"
        Me.btnCancelar.ToolTipImage = Nothing
        Me.btnCancelar.UniqueName = "D7017A3E116A48AAD7017A3E116A48AA"
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup1.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.UcClienteOperacion)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.btnBuscar)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtUbigeo)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtDireccion)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtFechaServicio)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbPlanta)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblPlanta)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.UcClienteFacturacion)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblClienteFacturacion)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblClienteOperacion)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(906, 110)
        Me.KryptonHeaderGroup1.TabIndex = 32
        Me.KryptonHeaderGroup1.Text = "Heading"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup1.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.ErrorImage = Global.SOLMIN_SC.My.Resources.Resources.lupa_10
        Me.btnBuscar.Image = Global.SOLMIN_SC.My.Resources.Resources.search
        Me.btnBuscar.Location = New System.Drawing.Point(740, 68)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(22, 22)
        Me.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnBuscar.TabIndex = 46
        Me.btnBuscar.TabStop = False
        '
        'txtUbigeo
        '
        Me.txtUbigeo.Enabled = False
        Me.txtUbigeo.Location = New System.Drawing.Point(427, 68)
        Me.txtUbigeo.MaxLength = 100
        Me.txtUbigeo.Name = "txtUbigeo"
        Me.txtUbigeo.Size = New System.Drawing.Size(310, 22)
        Me.txtUbigeo.TabIndex = 45
        '
        'txtDireccion
        '
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(125, 68)
        Me.txtDireccion.MaxLength = 100
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(296, 22)
        Me.txtDireccion.TabIndex = 44
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(31, 68)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(97, 20)
        Me.KryptonLabel2.TabIndex = 43
        Me.KryptonLabel2.Text = "Dir. del Servicio:"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Dir. del Servicio:"
        '
        'txtFechaServicio
        '
        Me.txtFechaServicio.Location = New System.Drawing.Point(498, 40)
        Me.txtFechaServicio.Name = "txtFechaServicio"
        Me.txtFechaServicio.ReadOnly = True
        Me.txtFechaServicio.Size = New System.Drawing.Size(98, 22)
        Me.txtFechaServicio.TabIndex = 18
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(402, 42)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(90, 20)
        Me.KryptonLabel1.TabIndex = 17
        Me.KryptonLabel1.Text = "Fecha Servicio:"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Fecha Servicio:"
        '
        'cmbPlanta
        '
        Me.cmbPlanta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlanta.FormattingEnabled = True
        Me.cmbPlanta.Location = New System.Drawing.Point(498, 13)
        Me.cmbPlanta.Name = "cmbPlanta"
        Me.cmbPlanta.Size = New System.Drawing.Size(230, 21)
        Me.cmbPlanta.TabIndex = 16
        '
        'lblPlanta
        '
        Me.lblPlanta.Location = New System.Drawing.Point(402, 15)
        Me.lblPlanta.Name = "lblPlanta"
        Me.lblPlanta.Size = New System.Drawing.Size(50, 20)
        Me.lblPlanta.TabIndex = 15
        Me.lblPlanta.Text = "Planta : "
        Me.lblPlanta.Values.ExtraText = ""
        Me.lblPlanta.Values.Image = Nothing
        Me.lblPlanta.Values.Text = "Planta : "
        '
        'UcClienteFacturacion
        '
        Me.UcClienteFacturacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcClienteFacturacion.BackColor = System.Drawing.Color.Transparent
        Me.UcClienteFacturacion.CCMPN = "EZ"
        Me.UcClienteFacturacion.Location = New System.Drawing.Point(125, 40)
        Me.UcClienteFacturacion.Name = "UcClienteFacturacion"
        Me.UcClienteFacturacion.pAccesoPorUsuario = False
        Me.UcClienteFacturacion.pCDDRSP_CodClienteSAP = ""
        Me.UcClienteFacturacion.pRequerido = False
        Me.UcClienteFacturacion.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.UcClienteFacturacion.pVisualizaNegocio = False
        Me.UcClienteFacturacion.Size = New System.Drawing.Size(256, 22)
        Me.UcClienteFacturacion.TabIndex = 1
        '
        'lblClienteFacturacion
        '
        Me.lblClienteFacturacion.Location = New System.Drawing.Point(11, 42)
        Me.lblClienteFacturacion.Name = "lblClienteFacturacion"
        Me.lblClienteFacturacion.Size = New System.Drawing.Size(117, 20)
        Me.lblClienteFacturacion.TabIndex = 14
        Me.lblClienteFacturacion.Text = "Cliente Facturación:"
        Me.lblClienteFacturacion.Values.ExtraText = ""
        Me.lblClienteFacturacion.Values.Image = Nothing
        Me.lblClienteFacturacion.Values.Text = "Cliente Facturación:"
        '
        'lblClienteOperacion
        '
        Me.lblClienteOperacion.Location = New System.Drawing.Point(17, 15)
        Me.lblClienteOperacion.Name = "lblClienteOperacion"
        Me.lblClienteOperacion.Size = New System.Drawing.Size(111, 20)
        Me.lblClienteOperacion.TabIndex = 13
        Me.lblClienteOperacion.Text = "Cliente Operación:"
        Me.lblClienteOperacion.Values.ExtraText = ""
        Me.lblClienteOperacion.Values.Image = Nothing
        Me.lblClienteOperacion.Values.Text = "Cliente Operación:"
        '
        'UcClienteOperacion
        '
        Me.UcClienteOperacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcClienteOperacion.BackColor = System.Drawing.Color.Transparent
        Me.UcClienteOperacion.CCMPN = "EZ"
        Me.UcClienteOperacion.Location = New System.Drawing.Point(125, 15)
        Me.UcClienteOperacion.Name = "UcClienteOperacion"
        Me.UcClienteOperacion.pAccesoPorUsuario = False
        Me.UcClienteOperacion.pCDDRSP_CodClienteSAP = ""
        Me.UcClienteOperacion.pRequerido = False
        Me.UcClienteOperacion.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.UcClienteOperacion.pVisualizaNegocio = False
        Me.UcClienteOperacion.Size = New System.Drawing.Size(256, 22)
        Me.UcClienteOperacion.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NRTFSV"
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tarifa"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 55
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "STPTRA"
        Me.DataGridViewTextBoxColumn2.HeaderText = "STPTRA"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 72
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CUNDMD"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "VALCTE"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn4.HeaderText = "Valor"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CCNTCS"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cod Centro" & Global.Microsoft.VisualBasic.ChrW(10) & "Costo"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 65
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TCNTCS"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn6.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "IVLSRV"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = "0"
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn7.HeaderText = "Valor de" & Global.Microsoft.VisualBasic.ChrW(10) & "Servicio"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 50
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "DESTAR"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Desc." & Global.Microsoft.VisualBasic.ChrW(10) & "Servicio"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "IVLSRV"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = "0"
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn9.HeaderText = "Valor de" & Global.Microsoft.VisualBasic.ChrW(10) & "Servicio"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 65
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "DESTAR"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Desc." & Global.Microsoft.VisualBasic.ChrW(10) & "Servicio"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'frmTarifasDeServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 302)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTarifasDeServicios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tarifas por embarque"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dtgTarifaPorEmbarque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonHeaderGroup16.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonHeaderGroup16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup16.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.btnBuscar, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents KryptonHeaderGroup16 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents dtgTarifaPorEmbarque As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents UcClienteOperacion As Ransa.Controls.Cliente.ucCliente_TxtF01
  Friend WithEvents UcClienteFacturacion As Ransa.Controls.Cliente.ucCliente_TxtF01
  Friend WithEvents lblClienteFacturacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents lblClienteOperacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbPlanta As System.Windows.Forms.ComboBox
    Private WithEvents lblPlanta As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtFechaServicio As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents NRTFSV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STPTRA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUNDMD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VALCTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRRUBR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMNDA1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCNTCS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCNTCS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IVLSRV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESTAR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnBuscar As System.Windows.Forms.PictureBox
    Friend WithEvents txtUbigeo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtDireccion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
