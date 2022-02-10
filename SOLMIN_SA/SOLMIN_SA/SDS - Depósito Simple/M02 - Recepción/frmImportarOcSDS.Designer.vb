<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportarOcSDS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImportarOcSDS))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dgOCD2 = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.in_PurchaseOrderLine_2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.in_PurchaseOrder_2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_PurchaseOrder_2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_PurchaseOrderLine_2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_StockCode_2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fl_QuantityOrdered_2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_LineDescriptionLine1_2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_LineDescriptionLine2_2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_ItemComment_2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_MDFCode_2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_CentroCosto_2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_CreatedBy_2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_ModifiedBy_2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dt_CreatedDate_2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dt_ModifiedDate_2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ch_Flag_2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dt_Fecha_2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_Usuario_2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_BU_2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fl_UnitPrice_2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fl_TotalPrice_2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_Filtro_2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_unidad_medida_2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dt_EstimatedDate_2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_SupplierAddressLine1_2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_SupplierAddressLine2_2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_SupplierAddressLine3_2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.dgOCtodo = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.Image = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IMG = New System.Windows.Forms.DataGridViewImageColumn
        Me.PNCCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNORCML = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNCPRVCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaOCDte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pFSOLIC_FechaSolicOCDte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pTDSCML_Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pNMONOC_MonedaDeOC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pTCMAEM_DescAreaEmpresa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pTTINTC_TerminoIntern = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pNREFCL_ReferenciaCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pTPAGME_TerminoPago = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pREFDO1_ReferenciaDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pNTPDES_Prioridad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pCMNDA1_Moneda = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pTEMPFAC_EmpresaFacturar = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pTNOMCOM_NombreComprador = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pTCTCST_CentroCosto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pCREGEMB_RegEmbarque = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pCMEDTR_MedioTransporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pTDEFIN_DestinoFinal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pIVCOTO_ImporteCostoTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pIVTOCO_ImporteTotalCompra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pIVTOIM_ImporteTotalImpuesto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pTDAITM_Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pCPRVCL_CodigoProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PCPRPCL_CodigoClienteProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pNRUCPR_RucProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pTPRVCL_DescripcionProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pTLFN01_TelefonoProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pTNROFX_FaxProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pTPDRPRC_DireccionProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pTPRSCN_ContactoProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pTLFN02_TelefonoContacto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pTEAMI3_EmailContacto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pEXISTE_FechaOCDte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pFORCML_INI_FechaOCInicial = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pFORCML_FIN_FechaOCFin = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pTNOMCOM_Nombre_Del_Comprador = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.in_PurchaseOrder = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.dgOCdetalle = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.in_PurchaseOrderLine = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.in_PurchaseOrder_1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_PurchaseOrder_1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_PurchaseOrderLine = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_StockCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fl_QuantityOrdered = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_LineDescriptionLine1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_LineDescriptionLine2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_ItemComment = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_MDFCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_CentroCosto_1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_CreatedBy_1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_ModifiedBy_1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dt_CreatedDate_1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dt_ModifiedDate_1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ch_Flag_1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dt_Fecha_1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_Usuario_1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_BU = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fl_UnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fl_TotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_Filtro = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_unidad_medida = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dt_EstimatedDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_SupplierAddressLine1_1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_SupplierAddressLine2_1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_SupplierAddressLine3_1 = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn59 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn60 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn61 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn62 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn63 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn64 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn65 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn66 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn67 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn68 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgOCD2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgOCtodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.dgOCdetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgOCD2)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Controls.Add(Me.dgOCtodo)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Controls.Add(Me.dgOCdetalle)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(876, 515)
        Me.KryptonPanel.TabIndex = 0
        '
        'dgOCD2
        '
        Me.dgOCD2.AllowUserToAddRows = False
        Me.dgOCD2.AllowUserToDeleteRows = False
        Me.dgOCD2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOCD2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.in_PurchaseOrderLine_2, Me.in_PurchaseOrder_2, Me.vc_PurchaseOrder_2, Me.vc_PurchaseOrderLine_2, Me.vc_StockCode_2, Me.fl_QuantityOrdered_2, Me.vc_LineDescriptionLine1_2, Me.vc_LineDescriptionLine2_2, Me.vc_ItemComment_2, Me.vc_MDFCode_2, Me.vc_CentroCosto_2, Me.vc_CreatedBy_2, Me.vc_ModifiedBy_2, Me.dt_CreatedDate_2, Me.dt_ModifiedDate_2, Me.ch_Flag_2, Me.dt_Fecha_2, Me.vc_Usuario_2, Me.vc_BU_2, Me.fl_UnitPrice_2, Me.fl_TotalPrice_2, Me.vc_Filtro_2, Me.vc_unidad_medida_2, Me.dt_EstimatedDate_2, Me.vc_SupplierAddressLine1_2, Me.vc_SupplierAddressLine2_2, Me.vc_SupplierAddressLine3_2})
        Me.dgOCD2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgOCD2.Location = New System.Drawing.Point(0, 275)
        Me.dgOCD2.Name = "dgOCD2"
        Me.dgOCD2.ReadOnly = True
        Me.dgOCD2.Size = New System.Drawing.Size(876, 240)
        Me.dgOCD2.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgOCD2.TabIndex = 5
        '
        'in_PurchaseOrderLine_2
        '
        Me.in_PurchaseOrderLine_2.DataPropertyName = "in_PurchaseOrderLine"
        Me.in_PurchaseOrderLine_2.HeaderText = "in_PurchaseOrderLine"
        Me.in_PurchaseOrderLine_2.Name = "in_PurchaseOrderLine_2"
        Me.in_PurchaseOrderLine_2.ReadOnly = True
        Me.in_PurchaseOrderLine_2.Visible = False
        '
        'in_PurchaseOrder_2
        '
        Me.in_PurchaseOrder_2.DataPropertyName = "in_PurchaseOrder"
        Me.in_PurchaseOrder_2.HeaderText = "Codigo Orden Compra"
        Me.in_PurchaseOrder_2.Name = "in_PurchaseOrder_2"
        Me.in_PurchaseOrder_2.ReadOnly = True
        Me.in_PurchaseOrder_2.Visible = False
        '
        'vc_PurchaseOrder_2
        '
        Me.vc_PurchaseOrder_2.DataPropertyName = "vc_PurchaseOrder"
        Me.vc_PurchaseOrder_2.HeaderText = "N° Orden Compra"
        Me.vc_PurchaseOrder_2.Name = "vc_PurchaseOrder_2"
        Me.vc_PurchaseOrder_2.ReadOnly = True
        '
        'vc_PurchaseOrderLine_2
        '
        Me.vc_PurchaseOrderLine_2.DataPropertyName = "vc_PurchaseOrderLine"
        Me.vc_PurchaseOrderLine_2.HeaderText = "N° Item"
        Me.vc_PurchaseOrderLine_2.Name = "vc_PurchaseOrderLine_2"
        Me.vc_PurchaseOrderLine_2.ReadOnly = True
        '
        'vc_StockCode_2
        '
        Me.vc_StockCode_2.DataPropertyName = "vc_StockCode"
        Me.vc_StockCode_2.HeaderText = "Codigo de Item "
        Me.vc_StockCode_2.Name = "vc_StockCode_2"
        Me.vc_StockCode_2.ReadOnly = True
        Me.vc_StockCode_2.Visible = False
        '
        'fl_QuantityOrdered_2
        '
        Me.fl_QuantityOrdered_2.DataPropertyName = "fl_QuantityOrdered"
        Me.fl_QuantityOrdered_2.HeaderText = "Cantidad "
        Me.fl_QuantityOrdered_2.Name = "fl_QuantityOrdered_2"
        Me.fl_QuantityOrdered_2.ReadOnly = True
        '
        'vc_LineDescriptionLine1_2
        '
        Me.vc_LineDescriptionLine1_2.DataPropertyName = "vc_LineDescriptionLine1"
        Me.vc_LineDescriptionLine1_2.HeaderText = "Descripcion"
        Me.vc_LineDescriptionLine1_2.Name = "vc_LineDescriptionLine1_2"
        Me.vc_LineDescriptionLine1_2.ReadOnly = True
        '
        'vc_LineDescriptionLine2_2
        '
        Me.vc_LineDescriptionLine2_2.DataPropertyName = "vc_LineDescriptionLine2"
        Me.vc_LineDescriptionLine2_2.HeaderText = "Descripcion Ingles"
        Me.vc_LineDescriptionLine2_2.Name = "vc_LineDescriptionLine2_2"
        Me.vc_LineDescriptionLine2_2.ReadOnly = True
        '
        'vc_ItemComment_2
        '
        Me.vc_ItemComment_2.DataPropertyName = "vc_ItemComment"
        Me.vc_ItemComment_2.HeaderText = "Comentario"
        Me.vc_ItemComment_2.Name = "vc_ItemComment_2"
        Me.vc_ItemComment_2.ReadOnly = True
        Me.vc_ItemComment_2.Visible = False
        '
        'vc_MDFCode_2
        '
        Me.vc_MDFCode_2.DataPropertyName = "vc_MDFCode"
        Me.vc_MDFCode_2.HeaderText = "vc_MDFCode"
        Me.vc_MDFCode_2.Name = "vc_MDFCode_2"
        Me.vc_MDFCode_2.ReadOnly = True
        Me.vc_MDFCode_2.Visible = False
        '
        'vc_CentroCosto_2
        '
        Me.vc_CentroCosto_2.DataPropertyName = "vc_CentroCosto"
        Me.vc_CentroCosto_2.HeaderText = "Centro de Costo"
        Me.vc_CentroCosto_2.Name = "vc_CentroCosto_2"
        Me.vc_CentroCosto_2.ReadOnly = True
        '
        'vc_CreatedBy_2
        '
        Me.vc_CreatedBy_2.DataPropertyName = "vc_CreatedBy"
        Me.vc_CreatedBy_2.HeaderText = "vc_CreatedBy"
        Me.vc_CreatedBy_2.Name = "vc_CreatedBy_2"
        Me.vc_CreatedBy_2.ReadOnly = True
        Me.vc_CreatedBy_2.Visible = False
        '
        'vc_ModifiedBy_2
        '
        Me.vc_ModifiedBy_2.DataPropertyName = "vc_ModifiedBy"
        Me.vc_ModifiedBy_2.HeaderText = "vc_ModifiedBy"
        Me.vc_ModifiedBy_2.Name = "vc_ModifiedBy_2"
        Me.vc_ModifiedBy_2.ReadOnly = True
        Me.vc_ModifiedBy_2.Visible = False
        '
        'dt_CreatedDate_2
        '
        Me.dt_CreatedDate_2.DataPropertyName = "dt_CreatedDate"
        Me.dt_CreatedDate_2.HeaderText = "dt_CreatedDate"
        Me.dt_CreatedDate_2.Name = "dt_CreatedDate_2"
        Me.dt_CreatedDate_2.ReadOnly = True
        Me.dt_CreatedDate_2.Visible = False
        '
        'dt_ModifiedDate_2
        '
        Me.dt_ModifiedDate_2.DataPropertyName = "dt_ModifiedDate"
        Me.dt_ModifiedDate_2.HeaderText = "dt_ModifiedDate"
        Me.dt_ModifiedDate_2.Name = "dt_ModifiedDate_2"
        Me.dt_ModifiedDate_2.ReadOnly = True
        Me.dt_ModifiedDate_2.Visible = False
        '
        'ch_Flag_2
        '
        Me.ch_Flag_2.DataPropertyName = "ch_Flag"
        Me.ch_Flag_2.HeaderText = "ch_Flag"
        Me.ch_Flag_2.Name = "ch_Flag_2"
        Me.ch_Flag_2.ReadOnly = True
        Me.ch_Flag_2.Visible = False
        '
        'dt_Fecha_2
        '
        Me.dt_Fecha_2.DataPropertyName = "dt_Fecha"
        Me.dt_Fecha_2.HeaderText = "dt_Fecha"
        Me.dt_Fecha_2.Name = "dt_Fecha_2"
        Me.dt_Fecha_2.ReadOnly = True
        Me.dt_Fecha_2.Visible = False
        '
        'vc_Usuario_2
        '
        Me.vc_Usuario_2.DataPropertyName = "vc_Usuario"
        Me.vc_Usuario_2.HeaderText = "vc_Usuario"
        Me.vc_Usuario_2.Name = "vc_Usuario_2"
        Me.vc_Usuario_2.ReadOnly = True
        Me.vc_Usuario_2.Visible = False
        '
        'vc_BU_2
        '
        Me.vc_BU_2.DataPropertyName = "vc_BU"
        Me.vc_BU_2.HeaderText = "vc_BU"
        Me.vc_BU_2.Name = "vc_BU_2"
        Me.vc_BU_2.ReadOnly = True
        Me.vc_BU_2.Visible = False
        '
        'fl_UnitPrice_2
        '
        Me.fl_UnitPrice_2.DataPropertyName = "fl_UnitPrice"
        Me.fl_UnitPrice_2.HeaderText = "Importe Unitario"
        Me.fl_UnitPrice_2.Name = "fl_UnitPrice_2"
        Me.fl_UnitPrice_2.ReadOnly = True
        '
        'fl_TotalPrice_2
        '
        Me.fl_TotalPrice_2.DataPropertyName = "fl_TotalPrice"
        Me.fl_TotalPrice_2.HeaderText = "Importe Total "
        Me.fl_TotalPrice_2.Name = "fl_TotalPrice_2"
        Me.fl_TotalPrice_2.ReadOnly = True
        '
        'vc_Filtro_2
        '
        Me.vc_Filtro_2.DataPropertyName = "vc_Filtro"
        Me.vc_Filtro_2.HeaderText = "vc_Filtro"
        Me.vc_Filtro_2.Name = "vc_Filtro_2"
        Me.vc_Filtro_2.ReadOnly = True
        Me.vc_Filtro_2.Visible = False
        '
        'vc_unidad_medida_2
        '
        Me.vc_unidad_medida_2.DataPropertyName = "vc_unidad_medida"
        Me.vc_unidad_medida_2.HeaderText = "Unidad de Medida"
        Me.vc_unidad_medida_2.Name = "vc_unidad_medida_2"
        Me.vc_unidad_medida_2.ReadOnly = True
        '
        'dt_EstimatedDate_2
        '
        Me.dt_EstimatedDate_2.DataPropertyName = "dt_EstimatedDate"
        Me.dt_EstimatedDate_2.HeaderText = "Fecha max Proveedor Despachara"
        Me.dt_EstimatedDate_2.Name = "dt_EstimatedDate_2"
        Me.dt_EstimatedDate_2.ReadOnly = True
        Me.dt_EstimatedDate_2.Visible = False
        '
        'vc_SupplierAddressLine1_2
        '
        Me.vc_SupplierAddressLine1_2.DataPropertyName = "vc_SupplierAddressLine1"
        Me.vc_SupplierAddressLine1_2.HeaderText = "Lugar de Entrega"
        Me.vc_SupplierAddressLine1_2.Name = "vc_SupplierAddressLine1_2"
        Me.vc_SupplierAddressLine1_2.ReadOnly = True
        '
        'vc_SupplierAddressLine2_2
        '
        Me.vc_SupplierAddressLine2_2.DataPropertyName = "vc_SupplierAddressLine2"
        Me.vc_SupplierAddressLine2_2.HeaderText = "vc_SupplierAddressLine2"
        Me.vc_SupplierAddressLine2_2.Name = "vc_SupplierAddressLine2_2"
        Me.vc_SupplierAddressLine2_2.ReadOnly = True
        Me.vc_SupplierAddressLine2_2.Visible = False
        '
        'vc_SupplierAddressLine3_2
        '
        Me.vc_SupplierAddressLine3_2.DataPropertyName = "vc_SupplierAddressLine3"
        Me.vc_SupplierAddressLine3_2.HeaderText = "vc_SupplierAddressLine3"
        Me.vc_SupplierAddressLine3_2.Name = "vc_SupplierAddressLine3_2"
        Me.vc_SupplierAddressLine3_2.ReadOnly = True
        Me.vc_SupplierAddressLine3_2.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.ToolStripButton1, Me.ToolStripSeparator4, Me.ToolStripButton2, Me.ToolStripSeparator5, Me.ToolStripButton3, Me.ToolStripSeparator6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 250)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(876, 25)
        Me.ToolStrip1.TabIndex = 3
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(126, 22)
        Me.ToolStripLabel2.Tag = "ITEMS A IMPORTAR"
        Me.ToolStripLabel2.Text = "ITEMS A IMPORTAR"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.Image = Global.SOLMIN_SA.My.Resources.Resources._exit
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButton1.Text = "&Salir"
        Me.ToolStripButton1.ToolTipText = "Salir"
        Me.ToolStripButton1.Visible = False
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator4.Visible = False
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(68, 22)
        Me.ToolStripButton2.Text = "&Eliminar"
        Me.ToolStripButton2.Visible = False
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator5.Visible = False
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton3.Image = Global.SOLMIN_SA.My.Resources.Resources.filesave
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripButton3.Text = "&Grabar"
        Me.ToolStripButton3.ToolTipText = "Grabar"
        Me.ToolStripButton3.Visible = False
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator6.Visible = False
        '
        'dgOCtodo
        '
        Me.dgOCtodo.AllowUserToAddRows = False
        Me.dgOCtodo.AllowUserToDeleteRows = False
        Me.dgOCtodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOCtodo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Image, Me.IMG, Me.PNCCLNT, Me.PSNORCML, Me.PNCPRVCL, Me.FechaOCDte, Me.pFSOLIC_FechaSolicOCDte, Me.pTDSCML_Descripcion, Me.pNMONOC_MonedaDeOC, Me.pTCMAEM_DescAreaEmpresa, Me.pTTINTC_TerminoIntern, Me.pNREFCL_ReferenciaCliente, Me.pTPAGME_TerminoPago, Me.pREFDO1_ReferenciaDocumento, Me.pNTPDES_Prioridad, Me.pCMNDA1_Moneda, Me.pTEMPFAC_EmpresaFacturar, Me.pTNOMCOM_NombreComprador, Me.pTCTCST_CentroCosto, Me.pCREGEMB_RegEmbarque, Me.pCMEDTR_MedioTransporte, Me.pTDEFIN_DestinoFinal, Me.pIVCOTO_ImporteCostoTotal, Me.pIVTOCO_ImporteTotalCompra, Me.pIVTOIM_ImporteTotalImpuesto, Me.pTDAITM_Observaciones, Me.pCPRVCL_CodigoProveedor, Me.PCPRPCL_CodigoClienteProveedor, Me.pNRUCPR_RucProveedor, Me.pTPRVCL_DescripcionProveedor, Me.pTLFN01_TelefonoProveedor, Me.pTNROFX_FaxProveedor, Me.pTPDRPRC_DireccionProveedor, Me.pTPRSCN_ContactoProveedor, Me.pTLFN02_TelefonoContacto, Me.pTEAMI3_EmailContacto, Me.pEXISTE_FechaOCDte, Me.pFORCML_INI_FechaOCInicial, Me.pFORCML_FIN_FechaOCFin, Me.pTNOMCOM_Nombre_Del_Comprador, Me.in_PurchaseOrder})
        Me.dgOCtodo.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgOCtodo.Location = New System.Drawing.Point(0, 25)
        Me.dgOCtodo.Name = "dgOCtodo"
        Me.dgOCtodo.ReadOnly = True
        Me.dgOCtodo.Size = New System.Drawing.Size(876, 225)
        Me.dgOCtodo.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgOCtodo.TabIndex = 2
        '
        'Image
        '
        Me.Image.DataPropertyName = "Image"
        Me.Image.HeaderText = "a"
        Me.Image.Name = "Image"
        Me.Image.ReadOnly = True
        Me.Image.Visible = False
        '
        'IMG
        '
        Me.IMG.DataPropertyName = "IMG"
        Me.IMG.HeaderText = ""
        Me.IMG.Name = "IMG"
        Me.IMG.ReadOnly = True
        '
        'PNCCLNT
        '
        Me.PNCCLNT.DataPropertyName = "PNCCLNT"
        Me.PNCCLNT.HeaderText = "CodigoCliente"
        Me.PNCCLNT.Name = "PNCCLNT"
        Me.PNCCLNT.ReadOnly = True
        Me.PNCCLNT.Visible = False
        '
        'PSNORCML
        '
        Me.PSNORCML.DataPropertyName = "PSNORCML"
        Me.PSNORCML.HeaderText = "NroOrden Compra"
        Me.PSNORCML.Name = "PSNORCML"
        Me.PSNORCML.ReadOnly = True
        '
        'PNCPRVCL
        '
        Me.PNCPRVCL.DataPropertyName = "PNCPRVCL"
        Me.PNCPRVCL.HeaderText = "CodigoClienteTercero"
        Me.PNCPRVCL.Name = "PNCPRVCL"
        Me.PNCPRVCL.ReadOnly = True
        Me.PNCPRVCL.Visible = False
        '
        'FechaOCDte
        '
        Me.FechaOCDte.DataPropertyName = "FechaOCDte"
        Me.FechaOCDte.HeaderText = "Fecha OC"
        Me.FechaOCDte.Name = "FechaOCDte"
        Me.FechaOCDte.ReadOnly = True
        '
        'pFSOLIC_FechaSolicOCDte
        '
        Me.pFSOLIC_FechaSolicOCDte.DataPropertyName = "PNFSOLIC "
        Me.pFSOLIC_FechaSolicOCDte.HeaderText = "FechaSolicOCDte"
        Me.pFSOLIC_FechaSolicOCDte.Name = "pFSOLIC_FechaSolicOCDte"
        Me.pFSOLIC_FechaSolicOCDte.ReadOnly = True
        Me.pFSOLIC_FechaSolicOCDte.Visible = False
        '
        'pTDSCML_Descripcion
        '
        Me.pTDSCML_Descripcion.DataPropertyName = "PSTDSCML"
        Me.pTDSCML_Descripcion.HeaderText = "Descripcion "
        Me.pTDSCML_Descripcion.Name = "pTDSCML_Descripcion"
        Me.pTDSCML_Descripcion.ReadOnly = True
        '
        'pNMONOC_MonedaDeOC
        '
        Me.pNMONOC_MonedaDeOC.DataPropertyName = "PSNMONOC"
        Me.pNMONOC_MonedaDeOC.HeaderText = "MonedaDeOC"
        Me.pNMONOC_MonedaDeOC.Name = "pNMONOC_MonedaDeOC"
        Me.pNMONOC_MonedaDeOC.ReadOnly = True
        '
        'pTCMAEM_DescAreaEmpresa
        '
        Me.pTCMAEM_DescAreaEmpresa.DataPropertyName = "PSTCMAEM"
        Me.pTCMAEM_DescAreaEmpresa.HeaderText = "DescAreaEmpresa"
        Me.pTCMAEM_DescAreaEmpresa.Name = "pTCMAEM_DescAreaEmpresa"
        Me.pTCMAEM_DescAreaEmpresa.ReadOnly = True
        Me.pTCMAEM_DescAreaEmpresa.Visible = False
        '
        'pTTINTC_TerminoIntern
        '
        Me.pTTINTC_TerminoIntern.DataPropertyName = "PSTTINTC"
        Me.pTTINTC_TerminoIntern.HeaderText = "Termino Interno"
        Me.pTTINTC_TerminoIntern.Name = "pTTINTC_TerminoIntern"
        Me.pTTINTC_TerminoIntern.ReadOnly = True
        '
        'pNREFCL_ReferenciaCliente
        '
        Me.pNREFCL_ReferenciaCliente.DataPropertyName = "PSNREFCL"
        Me.pNREFCL_ReferenciaCliente.HeaderText = "ReferenciaCliente"
        Me.pNREFCL_ReferenciaCliente.Name = "pNREFCL_ReferenciaCliente"
        Me.pNREFCL_ReferenciaCliente.ReadOnly = True
        Me.pNREFCL_ReferenciaCliente.Visible = False
        '
        'pTPAGME_TerminoPago
        '
        Me.pTPAGME_TerminoPago.DataPropertyName = "PSTPAGME"
        Me.pTPAGME_TerminoPago.HeaderText = "TerminoPago"
        Me.pTPAGME_TerminoPago.Name = "pTPAGME_TerminoPago"
        Me.pTPAGME_TerminoPago.ReadOnly = True
        Me.pTPAGME_TerminoPago.Visible = False
        '
        'pREFDO1_ReferenciaDocumento
        '
        Me.pREFDO1_ReferenciaDocumento.DataPropertyName = "PSREFDO1"
        Me.pREFDO1_ReferenciaDocumento.HeaderText = "ReferenciaDocumento"
        Me.pREFDO1_ReferenciaDocumento.Name = "pREFDO1_ReferenciaDocumento"
        Me.pREFDO1_ReferenciaDocumento.ReadOnly = True
        Me.pREFDO1_ReferenciaDocumento.Visible = False
        '
        'pNTPDES_Prioridad
        '
        Me.pNTPDES_Prioridad.DataPropertyName = "PNNTPDES"
        Me.pNTPDES_Prioridad.HeaderText = "Prioridad"
        Me.pNTPDES_Prioridad.Name = "pNTPDES_Prioridad"
        Me.pNTPDES_Prioridad.ReadOnly = True
        Me.pNTPDES_Prioridad.Visible = False
        '
        'pCMNDA1_Moneda
        '
        Me.pCMNDA1_Moneda.DataPropertyName = "PNCMNDA1"
        Me.pCMNDA1_Moneda.HeaderText = "Moneda"
        Me.pCMNDA1_Moneda.Name = "pCMNDA1_Moneda"
        Me.pCMNDA1_Moneda.ReadOnly = True
        Me.pCMNDA1_Moneda.Visible = False
        '
        'pTEMPFAC_EmpresaFacturar
        '
        Me.pTEMPFAC_EmpresaFacturar.DataPropertyName = "PSTEMPFAC"
        Me.pTEMPFAC_EmpresaFacturar.HeaderText = "EmpresaFacturar"
        Me.pTEMPFAC_EmpresaFacturar.Name = "pTEMPFAC_EmpresaFacturar"
        Me.pTEMPFAC_EmpresaFacturar.ReadOnly = True
        Me.pTEMPFAC_EmpresaFacturar.Visible = False
        '
        'pTNOMCOM_NombreComprador
        '
        Me.pTNOMCOM_NombreComprador.DataPropertyName = "PSTNOMCOM"
        Me.pTNOMCOM_NombreComprador.HeaderText = "NombreComprador"
        Me.pTNOMCOM_NombreComprador.Name = "pTNOMCOM_NombreComprador"
        Me.pTNOMCOM_NombreComprador.ReadOnly = True
        Me.pTNOMCOM_NombreComprador.Visible = False
        '
        'pTCTCST_CentroCosto
        '
        Me.pTCTCST_CentroCosto.DataPropertyName = "PSTCTCST"
        Me.pTCTCST_CentroCosto.HeaderText = "Centro de Costo"
        Me.pTCTCST_CentroCosto.Name = "pTCTCST_CentroCosto"
        Me.pTCTCST_CentroCosto.ReadOnly = True
        '
        'pCREGEMB_RegEmbarque
        '
        Me.pCREGEMB_RegEmbarque.DataPropertyName = "PSCREGEMB"
        Me.pCREGEMB_RegEmbarque.HeaderText = "RegEmbarque"
        Me.pCREGEMB_RegEmbarque.Name = "pCREGEMB_RegEmbarque"
        Me.pCREGEMB_RegEmbarque.ReadOnly = True
        Me.pCREGEMB_RegEmbarque.Visible = False
        '
        'pCMEDTR_MedioTransporte
        '
        Me.pCMEDTR_MedioTransporte.DataPropertyName = "PNCMEDTR"
        Me.pCMEDTR_MedioTransporte.HeaderText = "MedioTransporte"
        Me.pCMEDTR_MedioTransporte.Name = "pCMEDTR_MedioTransporte"
        Me.pCMEDTR_MedioTransporte.ReadOnly = True
        Me.pCMEDTR_MedioTransporte.Visible = False
        '
        'pTDEFIN_DestinoFinal
        '
        Me.pTDEFIN_DestinoFinal.DataPropertyName = "PSTDEFIN"
        Me.pTDEFIN_DestinoFinal.HeaderText = "DestinoFinal"
        Me.pTDEFIN_DestinoFinal.Name = "pTDEFIN_DestinoFinal"
        Me.pTDEFIN_DestinoFinal.ReadOnly = True
        Me.pTDEFIN_DestinoFinal.Visible = False
        '
        'pIVCOTO_ImporteCostoTotal
        '
        Me.pIVCOTO_ImporteCostoTotal.DataPropertyName = "PNIVCOTO"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.pIVCOTO_ImporteCostoTotal.DefaultCellStyle = DataGridViewCellStyle1
        Me.pIVCOTO_ImporteCostoTotal.HeaderText = "Costo Total"
        Me.pIVCOTO_ImporteCostoTotal.Name = "pIVCOTO_ImporteCostoTotal"
        Me.pIVCOTO_ImporteCostoTotal.ReadOnly = True
        Me.pIVCOTO_ImporteCostoTotal.Visible = False
        '
        'pIVTOCO_ImporteTotalCompra
        '
        Me.pIVTOCO_ImporteTotalCompra.DataPropertyName = "PNIVTOCO"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.pIVTOCO_ImporteTotalCompra.DefaultCellStyle = DataGridViewCellStyle2
        Me.pIVTOCO_ImporteTotalCompra.HeaderText = "Total Compra"
        Me.pIVTOCO_ImporteTotalCompra.Name = "pIVTOCO_ImporteTotalCompra"
        Me.pIVTOCO_ImporteTotalCompra.ReadOnly = True
        Me.pIVTOCO_ImporteTotalCompra.Visible = False
        '
        'pIVTOIM_ImporteTotalImpuesto
        '
        Me.pIVTOIM_ImporteTotalImpuesto.DataPropertyName = "PNIVTOIM"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.pIVTOIM_ImporteTotalImpuesto.DefaultCellStyle = DataGridViewCellStyle3
        Me.pIVTOIM_ImporteTotalImpuesto.HeaderText = "Total Impuesto "
        Me.pIVTOIM_ImporteTotalImpuesto.Name = "pIVTOIM_ImporteTotalImpuesto"
        Me.pIVTOIM_ImporteTotalImpuesto.ReadOnly = True
        Me.pIVTOIM_ImporteTotalImpuesto.Visible = False
        '
        'pTDAITM_Observaciones
        '
        Me.pTDAITM_Observaciones.DataPropertyName = "pTDAITM_Observaciones"
        Me.pTDAITM_Observaciones.HeaderText = "Observaciones"
        Me.pTDAITM_Observaciones.Name = "pTDAITM_Observaciones"
        Me.pTDAITM_Observaciones.ReadOnly = True
        Me.pTDAITM_Observaciones.Visible = False
        '
        'pCPRVCL_CodigoProveedor
        '
        Me.pCPRVCL_CodigoProveedor.DataPropertyName = "PSCPRPCL"
        Me.pCPRVCL_CodigoProveedor.HeaderText = "Codigo Proveedor "
        Me.pCPRVCL_CodigoProveedor.Name = "pCPRVCL_CodigoProveedor"
        Me.pCPRVCL_CodigoProveedor.ReadOnly = True
        Me.pCPRVCL_CodigoProveedor.Visible = False
        '
        'PCPRPCL_CodigoClienteProveedor
        '
        Me.PCPRPCL_CodigoClienteProveedor.DataPropertyName = "PSCPRPCL"
        Me.PCPRPCL_CodigoClienteProveedor.HeaderText = "Codigo Cliente Proveedor"
        Me.PCPRPCL_CodigoClienteProveedor.Name = "PCPRPCL_CodigoClienteProveedor"
        Me.PCPRPCL_CodigoClienteProveedor.ReadOnly = True
        Me.PCPRPCL_CodigoClienteProveedor.Visible = False
        '
        'pNRUCPR_RucProveedor
        '
        Me.pNRUCPR_RucProveedor.DataPropertyName = "PSRUCPR"
        Me.pNRUCPR_RucProveedor.HeaderText = "Ruc Proveedor"
        Me.pNRUCPR_RucProveedor.Name = "pNRUCPR_RucProveedor"
        Me.pNRUCPR_RucProveedor.ReadOnly = True
        '
        'pTPRVCL_DescripcionProveedor
        '
        Me.pTPRVCL_DescripcionProveedor.DataPropertyName = "PSTPRVCL"
        Me.pTPRVCL_DescripcionProveedor.HeaderText = "Descripcion Proveedor"
        Me.pTPRVCL_DescripcionProveedor.Name = "pTPRVCL_DescripcionProveedor"
        Me.pTPRVCL_DescripcionProveedor.ReadOnly = True
        '
        'pTLFN01_TelefonoProveedor
        '
        Me.pTLFN01_TelefonoProveedor.DataPropertyName = "PSTLFN01"
        Me.pTLFN01_TelefonoProveedor.HeaderText = "Telefono Proveedor"
        Me.pTLFN01_TelefonoProveedor.Name = "pTLFN01_TelefonoProveedor"
        Me.pTLFN01_TelefonoProveedor.ReadOnly = True
        Me.pTLFN01_TelefonoProveedor.Visible = False
        '
        'pTNROFX_FaxProveedor
        '
        Me.pTNROFX_FaxProveedor.DataPropertyName = "PSTNROFX"
        Me.pTNROFX_FaxProveedor.HeaderText = "Fax Proveedor"
        Me.pTNROFX_FaxProveedor.Name = "pTNROFX_FaxProveedor"
        Me.pTNROFX_FaxProveedor.ReadOnly = True
        '
        'pTPDRPRC_DireccionProveedor
        '
        Me.pTPDRPRC_DireccionProveedor.DataPropertyName = "PSTPRCL1"
        Me.pTPDRPRC_DireccionProveedor.HeaderText = "Direccion Proveedor"
        Me.pTPDRPRC_DireccionProveedor.Name = "pTPDRPRC_DireccionProveedor"
        Me.pTPDRPRC_DireccionProveedor.ReadOnly = True
        '
        'pTPRSCN_ContactoProveedor
        '
        Me.pTPRSCN_ContactoProveedor.DataPropertyName = "PSTPRSCN"
        Me.pTPRSCN_ContactoProveedor.HeaderText = "Contacto Proveedor"
        Me.pTPRSCN_ContactoProveedor.Name = "pTPRSCN_ContactoProveedor"
        Me.pTPRSCN_ContactoProveedor.ReadOnly = True
        Me.pTPRSCN_ContactoProveedor.Visible = False
        '
        'pTLFN02_TelefonoContacto
        '
        Me.pTLFN02_TelefonoContacto.DataPropertyName = "PSTLFN02"
        Me.pTLFN02_TelefonoContacto.HeaderText = "Telefono Contacto"
        Me.pTLFN02_TelefonoContacto.Name = "pTLFN02_TelefonoContacto"
        Me.pTLFN02_TelefonoContacto.ReadOnly = True
        '
        'pTEAMI3_EmailContacto
        '
        Me.pTEAMI3_EmailContacto.DataPropertyName = "PSTEAMI3"
        Me.pTEAMI3_EmailContacto.HeaderText = "Email Contacto"
        Me.pTEAMI3_EmailContacto.Name = "pTEAMI3_EmailContacto"
        Me.pTEAMI3_EmailContacto.ReadOnly = True
        Me.pTEAMI3_EmailContacto.Visible = False
        '
        'pEXISTE_FechaOCDte
        '
        Me.pEXISTE_FechaOCDte.DataPropertyName = "PSEXISTE"
        Me.pEXISTE_FechaOCDte.HeaderText = "FechaOCDte "
        Me.pEXISTE_FechaOCDte.Name = "pEXISTE_FechaOCDte"
        Me.pEXISTE_FechaOCDte.ReadOnly = True
        Me.pEXISTE_FechaOCDte.Visible = False
        '
        'pFORCML_INI_FechaOCInicial
        '
        Me.pFORCML_INI_FechaOCInicial.DataPropertyName = "PSFORCML_INI"
        Me.pFORCML_INI_FechaOCInicial.HeaderText = "FechaOCInicial "
        Me.pFORCML_INI_FechaOCInicial.Name = "pFORCML_INI_FechaOCInicial"
        Me.pFORCML_INI_FechaOCInicial.ReadOnly = True
        Me.pFORCML_INI_FechaOCInicial.Visible = False
        '
        'pFORCML_FIN_FechaOCFin
        '
        Me.pFORCML_FIN_FechaOCFin.DataPropertyName = "PSFORCML_FIN"
        Me.pFORCML_FIN_FechaOCFin.HeaderText = "FechaOCFin"
        Me.pFORCML_FIN_FechaOCFin.Name = "pFORCML_FIN_FechaOCFin"
        Me.pFORCML_FIN_FechaOCFin.ReadOnly = True
        Me.pFORCML_FIN_FechaOCFin.Visible = False
        '
        'pTNOMCOM_Nombre_Del_Comprador
        '
        Me.pTNOMCOM_Nombre_Del_Comprador.DataPropertyName = "PSTNOMCOM"
        Me.pTNOMCOM_Nombre_Del_Comprador.HeaderText = "Nombre Del Comprador"
        Me.pTNOMCOM_Nombre_Del_Comprador.Name = "pTNOMCOM_Nombre_Del_Comprador"
        Me.pTNOMCOM_Nombre_Del_Comprador.ReadOnly = True
        Me.pTNOMCOM_Nombre_Del_Comprador.Visible = False
        '
        'in_PurchaseOrder
        '
        Me.in_PurchaseOrder.DataPropertyName = "CodOC"
        Me.in_PurchaseOrder.HeaderText = "in_PurchaseOrder"
        Me.in_PurchaseOrder.Name = "in_PurchaseOrder"
        Me.in_PurchaseOrder.ReadOnly = True
        Me.in_PurchaseOrder.Visible = False
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.tsbSalir, Me.ToolStripSeparator1, Me.tsbEliminar, Me.ToolStripSeparator3, Me.tsbGrabar, Me.ToolStripSeparator2})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(876, 25)
        Me.tsMenuOpciones.TabIndex = 1
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(225, 22)
        Me.ToolStripLabel1.Tag = "ORDENES DE COMPRA A IMPORTAR"
        Me.ToolStripLabel1.Text = "ORDENES DE COMPRA A IMPORTAR"
        '
        'tsbSalir
        '
        Me.tsbSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbSalir.Image = Global.SOLMIN_SA.My.Resources.Resources._exit
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(49, 22)
        Me.tsbSalir.Text = "&Salir"
        Me.tsbSalir.ToolTipText = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbEliminar
        '
        Me.tsbEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbEliminar.Image = CType(resources.GetObject("tsbEliminar.Image"), System.Drawing.Image)
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(68, 22)
        Me.tsbEliminar.Text = "&Eliminar"
        Me.tsbEliminar.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator3.Visible = False
        '
        'tsbGrabar
        '
        Me.tsbGrabar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbGrabar.Image = Global.SOLMIN_SA.My.Resources.Resources.filesave
        Me.tsbGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGrabar.Name = "tsbGrabar"
        Me.tsbGrabar.Size = New System.Drawing.Size(62, 22)
        Me.tsbGrabar.Text = "&Grabar"
        Me.tsbGrabar.ToolTipText = "Grabar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'dgOCdetalle
        '
        Me.dgOCdetalle.AllowUserToAddRows = False
        Me.dgOCdetalle.AllowUserToDeleteRows = False
        Me.dgOCdetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOCdetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.in_PurchaseOrderLine, Me.in_PurchaseOrder_1, Me.vc_PurchaseOrder_1, Me.vc_PurchaseOrderLine, Me.vc_StockCode, Me.fl_QuantityOrdered, Me.vc_LineDescriptionLine1, Me.vc_LineDescriptionLine2, Me.vc_ItemComment, Me.vc_MDFCode, Me.vc_CentroCosto_1, Me.vc_CreatedBy_1, Me.vc_ModifiedBy_1, Me.dt_CreatedDate_1, Me.dt_ModifiedDate_1, Me.ch_Flag_1, Me.dt_Fecha_1, Me.vc_Usuario_1, Me.vc_BU, Me.fl_UnitPrice, Me.fl_TotalPrice, Me.vc_Filtro, Me.vc_unidad_medida, Me.dt_EstimatedDate, Me.vc_SupplierAddressLine1_1, Me.vc_SupplierAddressLine2_1, Me.vc_SupplierAddressLine3_1})
        Me.dgOCdetalle.Location = New System.Drawing.Point(0, 436)
        Me.dgOCdetalle.Name = "dgOCdetalle"
        Me.dgOCdetalle.ReadOnly = True
        Me.dgOCdetalle.Size = New System.Drawing.Size(876, 159)
        Me.dgOCdetalle.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgOCdetalle.TabIndex = 4
        '
        'in_PurchaseOrderLine
        '
        Me.in_PurchaseOrderLine.DataPropertyName = "in_PurchaseOrderLine"
        Me.in_PurchaseOrderLine.HeaderText = "in_PurchaseOrderLine"
        Me.in_PurchaseOrderLine.Name = "in_PurchaseOrderLine"
        Me.in_PurchaseOrderLine.ReadOnly = True
        Me.in_PurchaseOrderLine.Visible = False
        '
        'in_PurchaseOrder_1
        '
        Me.in_PurchaseOrder_1.DataPropertyName = "in_PurchaseOrder"
        Me.in_PurchaseOrder_1.HeaderText = "Codigo Orden Compra"
        Me.in_PurchaseOrder_1.Name = "in_PurchaseOrder_1"
        Me.in_PurchaseOrder_1.ReadOnly = True
        Me.in_PurchaseOrder_1.Visible = False
        '
        'vc_PurchaseOrder_1
        '
        Me.vc_PurchaseOrder_1.DataPropertyName = "vc_PurchaseOrder"
        Me.vc_PurchaseOrder_1.HeaderText = "N° Orden Compra"
        Me.vc_PurchaseOrder_1.Name = "vc_PurchaseOrder_1"
        Me.vc_PurchaseOrder_1.ReadOnly = True
        '
        'vc_PurchaseOrderLine
        '
        Me.vc_PurchaseOrderLine.DataPropertyName = "vc_PurchaseOrderLine"
        Me.vc_PurchaseOrderLine.HeaderText = "Numero de Item"
        Me.vc_PurchaseOrderLine.Name = "vc_PurchaseOrderLine"
        Me.vc_PurchaseOrderLine.ReadOnly = True
        '
        'vc_StockCode
        '
        Me.vc_StockCode.DataPropertyName = "vc_StockCode"
        Me.vc_StockCode.HeaderText = "Codigo de Item Cliente"
        Me.vc_StockCode.Name = "vc_StockCode"
        Me.vc_StockCode.ReadOnly = True
        '
        'fl_QuantityOrdered
        '
        Me.fl_QuantityOrdered.DataPropertyName = "fl_QuantityOrdered"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.fl_QuantityOrdered.DefaultCellStyle = DataGridViewCellStyle4
        Me.fl_QuantityOrdered.HeaderText = "Cantidad de Item"
        Me.fl_QuantityOrdered.Name = "fl_QuantityOrdered"
        Me.fl_QuantityOrdered.ReadOnly = True
        '
        'vc_LineDescriptionLine1
        '
        Me.vc_LineDescriptionLine1.DataPropertyName = "vc_LineDescriptionLine1"
        Me.vc_LineDescriptionLine1.HeaderText = "Descripcion de Item"
        Me.vc_LineDescriptionLine1.Name = "vc_LineDescriptionLine1"
        Me.vc_LineDescriptionLine1.ReadOnly = True
        '
        'vc_LineDescriptionLine2
        '
        Me.vc_LineDescriptionLine2.DataPropertyName = "vc_LineDescriptionLine2"
        Me.vc_LineDescriptionLine2.HeaderText = "Descripcion Item Ingles"
        Me.vc_LineDescriptionLine2.Name = "vc_LineDescriptionLine2"
        Me.vc_LineDescriptionLine2.ReadOnly = True
        '
        'vc_ItemComment
        '
        Me.vc_ItemComment.DataPropertyName = "vc_ItemComment"
        Me.vc_ItemComment.HeaderText = "vc_ItemComment"
        Me.vc_ItemComment.Name = "vc_ItemComment"
        Me.vc_ItemComment.ReadOnly = True
        Me.vc_ItemComment.Visible = False
        '
        'vc_MDFCode
        '
        Me.vc_MDFCode.DataPropertyName = "vc_MDFCode"
        Me.vc_MDFCode.HeaderText = "vc_MDFCode"
        Me.vc_MDFCode.Name = "vc_MDFCode"
        Me.vc_MDFCode.ReadOnly = True
        Me.vc_MDFCode.Visible = False
        '
        'vc_CentroCosto_1
        '
        Me.vc_CentroCosto_1.DataPropertyName = "vc_CentroCosto"
        Me.vc_CentroCosto_1.HeaderText = "Centro de Costo"
        Me.vc_CentroCosto_1.Name = "vc_CentroCosto_1"
        Me.vc_CentroCosto_1.ReadOnly = True
        '
        'vc_CreatedBy_1
        '
        Me.vc_CreatedBy_1.DataPropertyName = "vc_CreatedBy"
        Me.vc_CreatedBy_1.HeaderText = "vc_CreatedBy"
        Me.vc_CreatedBy_1.Name = "vc_CreatedBy_1"
        Me.vc_CreatedBy_1.ReadOnly = True
        Me.vc_CreatedBy_1.Visible = False
        '
        'vc_ModifiedBy_1
        '
        Me.vc_ModifiedBy_1.DataPropertyName = "vc_ModifiedBy"
        Me.vc_ModifiedBy_1.HeaderText = "vc_ModifiedBy"
        Me.vc_ModifiedBy_1.Name = "vc_ModifiedBy_1"
        Me.vc_ModifiedBy_1.ReadOnly = True
        Me.vc_ModifiedBy_1.Visible = False
        '
        'dt_CreatedDate_1
        '
        Me.dt_CreatedDate_1.DataPropertyName = "dt_CreatedDate"
        Me.dt_CreatedDate_1.HeaderText = "dt_CreatedDate"
        Me.dt_CreatedDate_1.Name = "dt_CreatedDate_1"
        Me.dt_CreatedDate_1.ReadOnly = True
        Me.dt_CreatedDate_1.Visible = False
        '
        'dt_ModifiedDate_1
        '
        Me.dt_ModifiedDate_1.DataPropertyName = "dt_ModifiedDate"
        Me.dt_ModifiedDate_1.HeaderText = "dt_ModifiedDate"
        Me.dt_ModifiedDate_1.Name = "dt_ModifiedDate_1"
        Me.dt_ModifiedDate_1.ReadOnly = True
        Me.dt_ModifiedDate_1.Visible = False
        '
        'ch_Flag_1
        '
        Me.ch_Flag_1.DataPropertyName = "ch_Flag"
        Me.ch_Flag_1.HeaderText = "ch_Flag"
        Me.ch_Flag_1.Name = "ch_Flag_1"
        Me.ch_Flag_1.ReadOnly = True
        Me.ch_Flag_1.Visible = False
        '
        'dt_Fecha_1
        '
        Me.dt_Fecha_1.DataPropertyName = "dt_Fecha"
        Me.dt_Fecha_1.HeaderText = "dt_Fecha"
        Me.dt_Fecha_1.Name = "dt_Fecha_1"
        Me.dt_Fecha_1.ReadOnly = True
        Me.dt_Fecha_1.Visible = False
        '
        'vc_Usuario_1
        '
        Me.vc_Usuario_1.DataPropertyName = "vc_Usuario"
        Me.vc_Usuario_1.HeaderText = "vc_Usuario"
        Me.vc_Usuario_1.Name = "vc_Usuario_1"
        Me.vc_Usuario_1.ReadOnly = True
        Me.vc_Usuario_1.Visible = False
        '
        'vc_BU
        '
        Me.vc_BU.DataPropertyName = "vc_BU"
        Me.vc_BU.HeaderText = "vc_BU"
        Me.vc_BU.Name = "vc_BU"
        Me.vc_BU.ReadOnly = True
        Me.vc_BU.Visible = False
        '
        'fl_UnitPrice
        '
        Me.fl_UnitPrice.DataPropertyName = "fl_UnitPrice"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.fl_UnitPrice.DefaultCellStyle = DataGridViewCellStyle5
        Me.fl_UnitPrice.HeaderText = "Importe Unitario"
        Me.fl_UnitPrice.Name = "fl_UnitPrice"
        Me.fl_UnitPrice.ReadOnly = True
        '
        'fl_TotalPrice
        '
        Me.fl_TotalPrice.DataPropertyName = "fl_TotalPrice"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.fl_TotalPrice.DefaultCellStyle = DataGridViewCellStyle6
        Me.fl_TotalPrice.HeaderText = "Importe Total "
        Me.fl_TotalPrice.Name = "fl_TotalPrice"
        Me.fl_TotalPrice.ReadOnly = True
        '
        'vc_Filtro
        '
        Me.vc_Filtro.DataPropertyName = "vc_Filtro"
        Me.vc_Filtro.HeaderText = "vc_Filtro"
        Me.vc_Filtro.Name = "vc_Filtro"
        Me.vc_Filtro.ReadOnly = True
        Me.vc_Filtro.Visible = False
        '
        'vc_unidad_medida
        '
        Me.vc_unidad_medida.DataPropertyName = "vc_unidad_medida"
        Me.vc_unidad_medida.HeaderText = "Unidad de Medida"
        Me.vc_unidad_medida.Name = "vc_unidad_medida"
        Me.vc_unidad_medida.ReadOnly = True
        '
        'dt_EstimatedDate
        '
        Me.dt_EstimatedDate.DataPropertyName = "dt_EstimatedDate"
        Me.dt_EstimatedDate.HeaderText = "Fecha max Proveedor Despachara"
        Me.dt_EstimatedDate.Name = "dt_EstimatedDate"
        Me.dt_EstimatedDate.ReadOnly = True
        Me.dt_EstimatedDate.Visible = False
        '
        'vc_SupplierAddressLine1_1
        '
        Me.vc_SupplierAddressLine1_1.DataPropertyName = "vc_SupplierAddressLine1"
        Me.vc_SupplierAddressLine1_1.HeaderText = "Lugar de Entrega"
        Me.vc_SupplierAddressLine1_1.Name = "vc_SupplierAddressLine1_1"
        Me.vc_SupplierAddressLine1_1.ReadOnly = True
        '
        'vc_SupplierAddressLine2_1
        '
        Me.vc_SupplierAddressLine2_1.DataPropertyName = "vc_SupplierAddressLine2"
        Me.vc_SupplierAddressLine2_1.HeaderText = "vc_SupplierAddressLine2"
        Me.vc_SupplierAddressLine2_1.Name = "vc_SupplierAddressLine2_1"
        Me.vc_SupplierAddressLine2_1.ReadOnly = True
        Me.vc_SupplierAddressLine2_1.Visible = False
        '
        'vc_SupplierAddressLine3_1
        '
        Me.vc_SupplierAddressLine3_1.DataPropertyName = "vc_SupplierAddressLine3"
        Me.vc_SupplierAddressLine3_1.HeaderText = "vc_SupplierAddressLine3"
        Me.vc_SupplierAddressLine3_1.Name = "vc_SupplierAddressLine3_1"
        Me.vc_SupplierAddressLine3_1.ReadOnly = True
        Me.vc_SupplierAddressLine3_1.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "in_PurchaseOrderLine"
        Me.DataGridViewTextBoxColumn1.HeaderText = "in_PurchaseOrderLine"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "in_PurchaseOrder"
        Me.DataGridViewTextBoxColumn2.HeaderText = "in_PurchaseOrder"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "vc_PurchaseOrderLine"
        Me.DataGridViewTextBoxColumn3.HeaderText = "vc_PurchaseOrderLine"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "vc_StockCode"
        Me.DataGridViewTextBoxColumn4.HeaderText = "vc_StockCode"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "fl_QuantityOrdered"
        Me.DataGridViewTextBoxColumn5.HeaderText = "fl_QuantityOrdered"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "vc_UnitMeasureCode"
        Me.DataGridViewTextBoxColumn6.HeaderText = "vc_UnitMeasureCode"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "vc_LineDescriptionLine1"
        Me.DataGridViewTextBoxColumn7.HeaderText = "vc_LineDescriptionLine1"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "vc_LineDescriptionLine2"
        Me.DataGridViewTextBoxColumn8.HeaderText = "vc_LineDescriptionLine2"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "vc_ItemComment"
        Me.DataGridViewTextBoxColumn9.HeaderText = "vc_ItemComment"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "vc_MDFCode"
        Me.DataGridViewTextBoxColumn10.HeaderText = "vc_MDFCode"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "vc_CentroCosto"
        Me.DataGridViewTextBoxColumn11.HeaderText = "vc_CentroCosto"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "vc_CreatedBy"
        Me.DataGridViewTextBoxColumn12.HeaderText = "vc_CreatedBy"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "vc_ModifiedBy"
        Me.DataGridViewTextBoxColumn13.HeaderText = "vc_ModifiedBy"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "dt_CreatedDate"
        Me.DataGridViewTextBoxColumn14.HeaderText = "dt_CreatedDate"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "dt_ModifiedDate"
        Me.DataGridViewTextBoxColumn15.HeaderText = "dt_ModifiedDate"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "ch_Flag"
        Me.DataGridViewTextBoxColumn16.HeaderText = "ch_Flag"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "dt_Fecha"
        Me.DataGridViewTextBoxColumn17.HeaderText = "dt_Fecha"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "vc_Usuario"
        Me.DataGridViewTextBoxColumn18.HeaderText = "vc_Usuario"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "vc_BU"
        Me.DataGridViewTextBoxColumn19.HeaderText = "vc_BU"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "vc_PurchaseOrder"
        Me.DataGridViewTextBoxColumn20.HeaderText = "vc_PurchaseOrder"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "fl_UnitPrice"
        Me.DataGridViewTextBoxColumn21.HeaderText = "fl_UnitPrice"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "fl_TotalPrice"
        Me.DataGridViewTextBoxColumn22.HeaderText = "fl_TotalPrice"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "vc_Filtro"
        Me.DataGridViewTextBoxColumn23.HeaderText = "vc_Filtro"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "vc_unidad_medida"
        Me.DataGridViewTextBoxColumn24.HeaderText = "vc_unidad_medida"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "dt_EstimatedDate"
        Me.DataGridViewTextBoxColumn25.HeaderText = "dt_EstimatedDate"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "vc_SupplierAddressLine1"
        Me.DataGridViewTextBoxColumn26.HeaderText = "vc_SupplierAddressLine1"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "vc_SupplierAddressLine2"
        Me.DataGridViewTextBoxColumn27.HeaderText = "vc_SupplierAddressLine2"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "vc_SupplierAddressLine3"
        Me.DataGridViewTextBoxColumn28.HeaderText = "vc_SupplierAddressLine3"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "pCCLNT_CodigoCliente"
        Me.DataGridViewTextBoxColumn29.HeaderText = "pCCLNT_CodigoCliente"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.Visible = False
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "pNORCML_NroOrdenCompra"
        Me.DataGridViewTextBoxColumn30.HeaderText = "pNORCML_NroOrdenCompra"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "pCPRVCL_CodigoClienteTercero"
        Me.DataGridViewTextBoxColumn31.HeaderText = "pCPRVCL_CodigoClienteTercero"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "pFORCML_FechaOCDte"
        Me.DataGridViewTextBoxColumn32.HeaderText = "pFORCML_FechaOCDte"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "pFSOLIC_FechaSolicOCDte"
        Me.DataGridViewTextBoxColumn33.HeaderText = "pFSOLIC_FechaSolicOCDte"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "pTDSCML_Descripcion"
        Me.DataGridViewTextBoxColumn34.HeaderText = "pTDSCML_Descripcion "
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.ReadOnly = True
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "pNMONOC_MonedaDeOC"
        Me.DataGridViewTextBoxColumn35.HeaderText = "pNMONOC_MonedaDeOC"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.ReadOnly = True
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "pTCMAEM_DescAreaEmpresa"
        Me.DataGridViewTextBoxColumn36.HeaderText = "pTCMAEM_DescAreaEmpresa"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.ReadOnly = True
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "pTTINTC_TerminoIntern"
        Me.DataGridViewTextBoxColumn37.HeaderText = "pTTINTC_TerminoIntern"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.ReadOnly = True
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "pNREFCL_ReferenciaCliente"
        Me.DataGridViewTextBoxColumn38.HeaderText = "pNREFCL_ReferenciaCliente"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.ReadOnly = True
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "pTPAGME_TerminoPago"
        Me.DataGridViewTextBoxColumn39.HeaderText = "pTPAGME_TerminoPago"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.ReadOnly = True
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "pREFDO1_ReferenciaDocumento"
        Me.DataGridViewTextBoxColumn40.HeaderText = "pREFDO1_ReferenciaDocumento"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.ReadOnly = True
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "pNTPDES_Prioridad"
        Me.DataGridViewTextBoxColumn41.HeaderText = "pNTPDES_Prioridad"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.ReadOnly = True
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "pCMNDA1_Moneda"
        Me.DataGridViewTextBoxColumn42.HeaderText = "pCMNDA1_Moneda"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.ReadOnly = True
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "pTEMPFAC_EmpresaFacturar"
        Me.DataGridViewTextBoxColumn43.HeaderText = "pTEMPFAC_EmpresaFacturar"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.ReadOnly = True
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "pTNOMCOM_NombreComprador"
        Me.DataGridViewTextBoxColumn44.HeaderText = "pTNOMCOM_NombreComprador"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        Me.DataGridViewTextBoxColumn44.ReadOnly = True
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "pTCTCST_CentroCosto"
        Me.DataGridViewTextBoxColumn45.HeaderText = "pTCTCST_CentroCosto"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        Me.DataGridViewTextBoxColumn45.ReadOnly = True
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "pCREGEMB_RegEmbarque"
        Me.DataGridViewTextBoxColumn46.HeaderText = "pCREGEMB_RegEmbarque"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        Me.DataGridViewTextBoxColumn46.ReadOnly = True
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "pCMEDTR_MedioTransporte"
        Me.DataGridViewTextBoxColumn47.HeaderText = "pCMEDTR_MedioTransporte"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        Me.DataGridViewTextBoxColumn47.ReadOnly = True
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "pTDEFIN_DestinoFinal"
        Me.DataGridViewTextBoxColumn48.HeaderText = "pTDEFIN_DestinoFinal"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        Me.DataGridViewTextBoxColumn48.ReadOnly = True
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "pIVCOTO_ImporteCostoTotal"
        Me.DataGridViewTextBoxColumn49.HeaderText = "pIVCOTO_ImporteCostoTotal"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        Me.DataGridViewTextBoxColumn49.ReadOnly = True
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "pIVTOCO_ImporteTotalCompra"
        Me.DataGridViewTextBoxColumn50.HeaderText = "pIVTOCO_ImporteTotalCompra"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        Me.DataGridViewTextBoxColumn50.ReadOnly = True
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "pIVTOIM_ImporteTotalImpuesto"
        Me.DataGridViewTextBoxColumn51.HeaderText = "pIVTOIM_ImporteTotalImpuesto "
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        Me.DataGridViewTextBoxColumn51.ReadOnly = True
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "pTDAITM_Observaciones"
        Me.DataGridViewTextBoxColumn52.HeaderText = "pTDAITM_Observaciones"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        Me.DataGridViewTextBoxColumn52.ReadOnly = True
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "pCPRVCL_CodigoProveedor"
        Me.DataGridViewTextBoxColumn53.HeaderText = "pCPRVCL_CodigoProveedor "
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        Me.DataGridViewTextBoxColumn53.ReadOnly = True
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "PCPRPCL_CodigoClienteProveedor"
        Me.DataGridViewTextBoxColumn54.HeaderText = "PCPRPCL_CodigoClienteProveedor"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        Me.DataGridViewTextBoxColumn54.ReadOnly = True
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "pNRUCPR_RucProveedor"
        Me.DataGridViewTextBoxColumn55.HeaderText = "pNRUCPR_RucProveedor"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        Me.DataGridViewTextBoxColumn55.ReadOnly = True
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "pTPRVCL_DescripcionProveedor"
        Me.DataGridViewTextBoxColumn56.HeaderText = "pTPRVCL_DescripcionProveedor"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        Me.DataGridViewTextBoxColumn56.ReadOnly = True
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.DataPropertyName = "pTLFN01_TelefonoProveedor"
        Me.DataGridViewTextBoxColumn57.HeaderText = "pTLFN01_TelefonoProveedor"
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        Me.DataGridViewTextBoxColumn57.ReadOnly = True
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.DataPropertyName = "pTNROFX_FaxProveedor"
        Me.DataGridViewTextBoxColumn58.HeaderText = "pTNROFX_FaxProveedor"
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        Me.DataGridViewTextBoxColumn58.ReadOnly = True
        '
        'DataGridViewTextBoxColumn59
        '
        Me.DataGridViewTextBoxColumn59.DataPropertyName = "pTPDRPRC_DireccionProveedor"
        Me.DataGridViewTextBoxColumn59.HeaderText = "pTPDRPRC_DireccionProveedor"
        Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
        Me.DataGridViewTextBoxColumn59.ReadOnly = True
        '
        'DataGridViewTextBoxColumn60
        '
        Me.DataGridViewTextBoxColumn60.DataPropertyName = "pTPRSCN_ContactoProveedor"
        Me.DataGridViewTextBoxColumn60.HeaderText = "pTPRSCN_ContactoProveedor"
        Me.DataGridViewTextBoxColumn60.Name = "DataGridViewTextBoxColumn60"
        Me.DataGridViewTextBoxColumn60.ReadOnly = True
        '
        'DataGridViewTextBoxColumn61
        '
        Me.DataGridViewTextBoxColumn61.DataPropertyName = "pTLFN02_TelefonoContacto"
        Me.DataGridViewTextBoxColumn61.HeaderText = "pTLFN02_TelefonoContacto"
        Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
        Me.DataGridViewTextBoxColumn61.ReadOnly = True
        '
        'DataGridViewTextBoxColumn62
        '
        Me.DataGridViewTextBoxColumn62.DataPropertyName = "pTEAMI3_EmailContacto"
        Me.DataGridViewTextBoxColumn62.HeaderText = "pTEAMI3_EmailContacto"
        Me.DataGridViewTextBoxColumn62.Name = "DataGridViewTextBoxColumn62"
        Me.DataGridViewTextBoxColumn62.ReadOnly = True
        '
        'DataGridViewTextBoxColumn63
        '
        Me.DataGridViewTextBoxColumn63.DataPropertyName = "pEXISTE_FechaOCDte"
        Me.DataGridViewTextBoxColumn63.HeaderText = "pEXISTE_FechaOCDte "
        Me.DataGridViewTextBoxColumn63.Name = "DataGridViewTextBoxColumn63"
        Me.DataGridViewTextBoxColumn63.ReadOnly = True
        '
        'DataGridViewTextBoxColumn64
        '
        Me.DataGridViewTextBoxColumn64.DataPropertyName = "pFORCML_INI_FechaOCInicial"
        Me.DataGridViewTextBoxColumn64.HeaderText = "pFORCML_INI_FechaOCInicial "
        Me.DataGridViewTextBoxColumn64.Name = "DataGridViewTextBoxColumn64"
        Me.DataGridViewTextBoxColumn64.ReadOnly = True
        '
        'DataGridViewTextBoxColumn65
        '
        Me.DataGridViewTextBoxColumn65.DataPropertyName = "pFORCML_FIN_FechaOCFin"
        Me.DataGridViewTextBoxColumn65.HeaderText = "pFORCML_FIN_FechaOCFin"
        Me.DataGridViewTextBoxColumn65.Name = "DataGridViewTextBoxColumn65"
        Me.DataGridViewTextBoxColumn65.ReadOnly = True
        '
        'DataGridViewTextBoxColumn66
        '
        Me.DataGridViewTextBoxColumn66.DataPropertyName = "pTPRCL1_DescripcionProveedor"
        Me.DataGridViewTextBoxColumn66.HeaderText = "pTPRCL1_DescripcionProveedor"
        Me.DataGridViewTextBoxColumn66.Name = "DataGridViewTextBoxColumn66"
        Me.DataGridViewTextBoxColumn66.ReadOnly = True
        '
        'DataGridViewTextBoxColumn67
        '
        Me.DataGridViewTextBoxColumn67.DataPropertyName = "pTNOMCOM_Nombre_Del_Comprador"
        Me.DataGridViewTextBoxColumn67.HeaderText = "pTNOMCOM_Nombre_Del_Comprador"
        Me.DataGridViewTextBoxColumn67.Name = "DataGridViewTextBoxColumn67"
        Me.DataGridViewTextBoxColumn67.ReadOnly = True
        '
        'DataGridViewTextBoxColumn68
        '
        Me.DataGridViewTextBoxColumn68.DataPropertyName = "PSTNOMCOM"
        Me.DataGridViewTextBoxColumn68.HeaderText = "pTNOMCOM_Nombre_Del_Comprador"
        Me.DataGridViewTextBoxColumn68.Name = "DataGridViewTextBoxColumn68"
        Me.DataGridViewTextBoxColumn68.ReadOnly = True
        '
        'frmImportarOcSDS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 515)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImportarOcSDS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importar Ordenes de Compra Masiva"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dgOCD2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgOCtodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        CType(Me.dgOCdetalle, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dgOCtodo As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dgOCdetalle As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
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
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn59 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn60 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn61 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn62 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn63 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn64 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn65 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn66 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn67 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn68 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgOCD2 As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents in_PurchaseOrderLine_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents in_PurchaseOrder_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_PurchaseOrder_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_PurchaseOrderLine_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_StockCode_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fl_QuantityOrdered_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_LineDescriptionLine1_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_LineDescriptionLine2_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_ItemComment_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_MDFCode_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_CentroCosto_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_CreatedBy_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_ModifiedBy_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dt_CreatedDate_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dt_ModifiedDate_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ch_Flag_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dt_Fecha_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_Usuario_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_BU_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fl_UnitPrice_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fl_TotalPrice_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_Filtro_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_unidad_medida_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dt_EstimatedDate_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_SupplierAddressLine1_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_SupplierAddressLine2_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_SupplierAddressLine3_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Image As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMG As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents PNCCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNORCML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNCPRVCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaOCDte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pFSOLIC_FechaSolicOCDte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pTDSCML_Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pNMONOC_MonedaDeOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pTCMAEM_DescAreaEmpresa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pTTINTC_TerminoIntern As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pNREFCL_ReferenciaCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pTPAGME_TerminoPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pREFDO1_ReferenciaDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pNTPDES_Prioridad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pCMNDA1_Moneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pTEMPFAC_EmpresaFacturar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pTNOMCOM_NombreComprador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pTCTCST_CentroCosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pCREGEMB_RegEmbarque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pCMEDTR_MedioTransporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pTDEFIN_DestinoFinal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pIVCOTO_ImporteCostoTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pIVTOCO_ImporteTotalCompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pIVTOIM_ImporteTotalImpuesto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pTDAITM_Observaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pCPRVCL_CodigoProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PCPRPCL_CodigoClienteProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pNRUCPR_RucProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pTPRVCL_DescripcionProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pTLFN01_TelefonoProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pTNROFX_FaxProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pTPDRPRC_DireccionProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pTPRSCN_ContactoProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pTLFN02_TelefonoContacto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pTEAMI3_EmailContacto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pEXISTE_FechaOCDte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pFORCML_INI_FechaOCInicial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pFORCML_FIN_FechaOCFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pTNOMCOM_Nombre_Del_Comprador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents in_PurchaseOrder As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents in_PurchaseOrderLine As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents in_PurchaseOrder_1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_PurchaseOrder_1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_PurchaseOrderLine As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_StockCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fl_QuantityOrdered As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_LineDescriptionLine1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_LineDescriptionLine2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_ItemComment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_MDFCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_CentroCosto_1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_CreatedBy_1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_ModifiedBy_1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dt_CreatedDate_1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dt_ModifiedDate_1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ch_Flag_1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dt_Fecha_1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_Usuario_1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_BU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fl_UnitPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fl_TotalPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_Filtro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_unidad_medida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dt_EstimatedDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_SupplierAddressLine1_1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_SupplierAddressLine2_1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_SupplierAddressLine3_1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
