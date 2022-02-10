Imports System.Runtime.InteropServices

Namespace mantenimientos
    ''' <summary>
    ''' Primary Key Tabla RZTR96 - Guias de Transportista
    ''' </summary>
    <StructLayout(LayoutKind.Sequential)> _
    Public Class TD_GuiaTransportistaPK
#Region " Atributos "
        Public pCTRMNC_CodigoTransportista As Int32 = 0
        Public pNGUIRM_NroGuiaTransportista As Int64 = 0
        Public pCCMPN_Ccompania As String
#End Region
#Region " Métodos "
        Sub New()
            pCTRMNC_CodigoTransportista = 0
            pNGUIRM_NroGuiaTransportista = 0
        End Sub

        Sub New(ByVal Operacion As Int64, ByVal GuiaTransportista As Int64)
            pCTRMNC_CodigoTransportista = Operacion
            pNGUIRM_NroGuiaTransportista = GuiaTransportista
        End Sub

        Public Sub pClear()
            pCTRMNC_CodigoTransportista = 0
            pNGUIRM_NroGuiaTransportista = 0
        End Sub
#End Region
    End Class

    ''' <summary>
    ''' Tabla RZTR96K - Guia de Remision asociada a la Guiaa de Transportista
    ''' </summary>
    <StructLayout(LayoutKind.Sequential)> _
    Public Class TD_Obj_GuiaRemisionGTransp
#Region " Atributos "
        'Public pCTRMNC_CodigoTransportista As Int32 = 0
        'Public pNGUIRM_NroGuiaTransportista As Int64 = 0
        'Public pNRGUCL_NroGuiaRemision As Int64 = 0
        'Public pFCGUCL_FechaGuiaRemision As Date
        'Public pCCLNT_CodigoCliente As Int64 = 0
        'Public pTCMPCL_RazonSocialCliente As String = ""
        'Public NGUIRS As String = ""


        Private _pCTRMNC_CodigoTransportista As Int32 = 0
        Public Property pCTRMNC_CodigoTransportista() As Int32
            Get
                Return (_pCTRMNC_CodigoTransportista)
            End Get
            Set(ByVal value As Int32)
                _pCTRMNC_CodigoTransportista = value
            End Set
        End Property

        Private _pNGUIRM_NroGuiaTransportista As Int64 = 0
        Public Property pNGUIRM_NroGuiaTransportista() As Int64
            Get
                Return (_pNGUIRM_NroGuiaTransportista)
            End Get
            Set(ByVal value As Int64)
                _pNGUIRM_NroGuiaTransportista = value
            End Set
        End Property

        Private _pNRGUCL_NroGuiaRemision As Int64 = 0
        Public Property pNRGUCL_NroGuiaRemision() As Int64
            Get
                Return (_pNRGUCL_NroGuiaRemision)
            End Get
            Set(ByVal value As Int64)
                _pNRGUCL_NroGuiaRemision = value
            End Set
        End Property

        Private _pCCLNT_CodigoCliente As Int64 = 0
        Public Property pCCLNT_CodigoCliente() As Int64
            Get
                Return (_pCCLNT_CodigoCliente)
            End Get
            Set(ByVal value As Int64)
                _pCCLNT_CodigoCliente = value
            End Set
        End Property


        Private _pTCMPCL_RazonSocialCliente As String = ""
        Public Property pTCMPCL_RazonSocialCliente() As String
            Get
                Return (_pTCMPCL_RazonSocialCliente)
            End Get
            Set(ByVal value As String)
                _pTCMPCL_RazonSocialCliente = value
            End Set
        End Property

        Private _pNGUIRS As String = ""
        Public Property pNGUIRS() As String
            Get
                Return (_pNGUIRS)
            End Get
            Set(ByVal value As String)
                _pNGUIRS = value
            End Set
        End Property

        Private _pFCGUCL_FechaGuiaRemision As Date
        Public Property pFCGUCL_FechaGuiaRemision() As Date
            Get
                Return (_pFCGUCL_FechaGuiaRemision)
            End Get
            Set(ByVal value As Date)
                _pFCGUCL_FechaGuiaRemision = value
            End Set
        End Property


#End Region
#Region " Métodos "
        Sub New()
            Call pClear()
        End Sub

        Public Sub pClear()
            pCTRMNC_CodigoTransportista = 0
            pNGUIRM_NroGuiaTransportista = 0
            pNRGUCL_NroGuiaRemision = 0
            pFCGUCL_FechaGuiaRemision = New Date
            pCCLNT_CodigoCliente = 0
            pTCMPCL_RazonSocialCliente = ""
        End Sub
#End Region
    End Class


    ''' <summary>
    ''' Primary Key Tabla RZTR06 - Guias de Remisión de la Guia de Transportista
    ''' </summary>
    <StructLayout(LayoutKind.Sequential)> _
    Public Class TD_GRemCargadasGTranspLiqPK
#Region " Atributos "
        Public pNOPRCN_NroOperacion As Int64 = 0
        Public pNGUIRM_NroGuiaTransportista As Int64 = 0
        Public pCCMPN_Compania As String = ""
#End Region
#Region " Métodos "
        Sub New()
            pNOPRCN_NroOperacion = 0
            pNGUIRM_NroGuiaTransportista = 0
        End Sub

        Sub New(ByVal Operacion As Int64, ByVal GuiaTransportista As Int64)
            pNOPRCN_NroOperacion = Operacion
            pNGUIRM_NroGuiaTransportista = GuiaTransportista
        End Sub

        Public Sub pClear()
            pNOPRCN_NroOperacion = 0
            pNGUIRM_NroGuiaTransportista = 0
        End Sub
#End Region
    End Class

    ''' <summary>
    ''' Información de la Guia de Remision Cargada a la Guia Transportista Liquidación
    ''' </summary>
    <StructLayout(LayoutKind.Sequential)> _
    Public Class TD_Obj_GRemCargadasGTranspLiq
#Region " Atributos "



        Private _pNOPRCN_NroOperacion As Decimal = 0
        Public Property pNOPRCN_NroOperacion() As Decimal
            Get
                Return (_pNOPRCN_NroOperacion)
            End Get
            Set(ByVal value As Decimal)
                _pNOPRCN_NroOperacion = value
            End Set
        End Property

        Private _pNGUIRM_NroGuiaTransportista As Decimal = 0
        Public Property pNGUIRM_NroGuiaTransportista() As Decimal
            Get
                Return (_pNGUIRM_NroGuiaTransportista)
            End Get
            Set(ByVal value As Decimal)
                _pNGUIRM_NroGuiaTransportista = value
            End Set
        End Property


        Private _pNGUITR_GuiaRemisionCargada As Decimal = 0
        Public Property pNGUITR_GuiaRemisionCargada() As Decimal
            Get
                Return (_pNGUITR_GuiaRemisionCargada)
            End Get
            Set(ByVal value As Decimal)
                _pNGUITR_GuiaRemisionCargada = value
            End Set
        End Property


        Private _pNGUIRS_GuiaRemisionCargada As String = ""
        Public Property pNGUIRS_GuiaRemisionCargada() As String
            Get
                Return (_pNGUIRS_GuiaRemisionCargada)
            End Get
            Set(ByVal value As String)
                _pNGUIRS_GuiaRemisionCargada = value
            End Set
        End Property


        Private _pFGUITR_FechaGuiaRemision As Date
        Public Property pFGUITR_FechaGuiaRemision() As Date
            Get
                Return (_pFGUITR_FechaGuiaRemision)
            End Get
            Set(ByVal value As Date)
                _pFGUITR_FechaGuiaRemision = value
            End Set
        End Property

        Private _pCTRSPT_Transportista As Decimal
        Public Property pCTRSPT_Transportista() As Decimal
            Get
                Return (_pCTRSPT_Transportista)
            End Get
            Set(ByVal value As Decimal)
                _pCTRSPT_Transportista = value
            End Set
        End Property

        Private _pTCMTRT_RazSocialTransportista As String = ""
        Public Property pTCMTRT_RazSocialTransportista() As String
            Get
                Return (_pTCMTRT_RazSocialTransportista)
            End Get
            Set(ByVal value As String)
                _pTCMTRT_RazSocialTransportista = value
            End Set
        End Property

        Private _pNPLVHT_Tracto As String = ""
        Public Property pNPLVHT_Tracto() As String
            Get
                Return (_pNPLVHT_Tracto)
            End Get
            Set(ByVal value As String)
                _pNPLVHT_Tracto = value
            End Set
        End Property

        Private _pCBRCNT_Brevete As String = ""
        Public Property pCBRCNT_Brevete() As String
            Get
                Return (_pCBRCNT_Brevete)
            End Get
            Set(ByVal value As String)
                _pCBRCNT_Brevete = value
            End Set
        End Property

        Private _pTNMCMC_NomApeChofer As String = ""
        Public Property pTNMCMC_NomApeChofer() As String
            Get
                Return (_pTNMCMC_NomApeChofer)
            End Get
            Set(ByVal value As String)
                _pTNMCMC_NomApeChofer = value
            End Set
        End Property


        Private _pQCNDTG_CantServicioGuia As Decimal = 0
        Public Property pQCNDTG_CantServicioGuia() As Decimal
            Get
                Return (_pQCNDTG_CantServicioGuia)
            End Get
            Set(ByVal value As Decimal)
                _pQCNDTG_CantServicioGuia = value
            End Set
        End Property


        Private _pCUNDSR_Unidad As String = ""
        Public Property pCUNDSR_Unidad() As String
            Get
                Return (_pCUNDSR_Unidad)
            End Get
            Set(ByVal value As String)
                _pCUNDSR_Unidad = value
            End Set
        End Property


        Private _pNLQDCN_NroLiquidacion As Decimal = 0
        Public Property pNLQDCN_NroLiquidacion() As Decimal
            Get
                Return (_pNLQDCN_NroLiquidacion)
            End Get
            Set(ByVal value As Decimal)
                _pNLQDCN_NroLiquidacion = value
            End Set
        End Property

        Private _pSGUIFC_StatusFacturado As String = ""
        Public Property pSGUIFC_StatusFacturado() As String
            Get
                Return (_pSGUIFC_StatusFacturado)
            End Get
            Set(ByVal value As String)
                _pSGUIFC_StatusFacturado = value
            End Set
        End Property


        Private _pPSOVOL_PesoVolumen As Decimal = 0
        Public Property pPSOVOL_PesoVolumen() As Decimal
            Get
                Return (_pPSOVOL_PesoVolumen)
            End Get
            Set(ByVal value As Decimal)
                _pPSOVOL_PesoVolumen = value
            End Set
        End Property

        Private _pPMRCMC_PesoNeto As Decimal = 0
        Public Property pPMRCMC_PesoNeto() As Decimal
            Get
                Return (_pPMRCMC_PesoNeto)
            End Get
            Set(ByVal value As Decimal)
                _pPMRCMC_PesoNeto = value
            End Set
        End Property

        Private _pPBRTOR_PesoBruto As Decimal = 0
        Public Property pPBRTOR_PesoBruto() As Decimal
            Get
                Return (_pPBRTOR_PesoBruto)
            End Get
            Set(ByVal value As Decimal)
                _pPBRTOR_PesoBruto = value
            End Set
        End Property


        Private _pTCMTRT_Proveedor As String = ""
        Public Property pTCMTRT_Proveedor() As String
            Get
                Return (_pTCMTRT_Proveedor)
            End Get
            Set(ByVal value As String)
                _pTCMTRT_Proveedor = value
            End Set
        End Property


        Private _pCantLiq As Decimal = 0
        Public Property pCantLiq() As Decimal
            Get
                Return (_pCantLiq)
            End Get
            Set(ByVal value As Decimal)
                _pCantLiq = value
            End Set
        End Property


        Private _pNUMEROCO As Decimal = 0
        Public Property pNUMEROCO() As Decimal
            Get
                Return (_pNUMEROCO)
            End Get
            Set(ByVal value As Decimal)
                _pNUMEROCO = value
            End Set
        End Property

        Private _pNCRDCO As Decimal = 0
        Public Property pNCRDCO() As Decimal
            Get
                Return (_pNCRDCO)
            End Get
            Set(ByVal value As Decimal)
                _pNCRDCO = value
            End Set
        End Property

        Private _pPlanta As String = ""
        Public Property pPlanta() As String
            Get
                Return (_pPlanta)
            End Get
            Set(ByVal value As String)
                _pPlanta = value
            End Set
        End Property


        Private _pCPLNDV As Decimal = 0
        Public Property pCPLNDV() As Decimal
            Get
                Return (_pCPLNDV)
            End Get
            Set(ByVal value As Decimal)
                _pCPLNDV = value
            End Set
        End Property


        'Public pNOPRCN_NroOperacion As Int64 = 0
        'Public pNGUIRM_NroGuiaTransportista As Int64 = 0
        'Public pNGUITR_GuiaRemisionCargada As Int64 = 0
        'Public pFGUITR_FechaGuiaRemision As Date
        'Public pCTRSPT_Transportista As Int32 = 0
        'Public pTCMTRT_RazSocialTransportista As String = ""
        'Public pNPLVHT_Tracto As String = ""
        'Public pCBRCNT_Brevete As String = ""
        'Public pTNMCMC_NomApeChofer As String = ""
        'Public pQCNDTG_CantServicioGuia As Decimal = 0
        'Public pCUNDSR_Unidad As String = ""
        'Public pNLQDCN_NroLiquidacion As Int64 = 0
        'Public pSGUIFC_StatusFacturado As String = ""
        'Public pPSOVOL_PesoVolumen As Decimal = 0
        'Public pPMRCMC_PesoNeto As Decimal = 0
        'Public pPBRTOR_PesoBruto As Decimal = 0
        'Public pTCMTRT_Proveedor As String = ""
        'Public pCantLiq As Int32 = 0
        'Public pNUMEROCO As Decimal
        'Public pNCRDCO As Decimal
        'Public pPlanta As String = ""
        'Public pCPLNDV As Decimal = 0
#End Region
#Region " Métodos "
        Public Sub pClear()
            pNOPRCN_NroOperacion = 0
            pNGUIRM_NroGuiaTransportista = 0
            pNGUITR_GuiaRemisionCargada = 0
            pFGUITR_FechaGuiaRemision = Nothing
            pCTRSPT_Transportista = 0
            pTCMTRT_RazSocialTransportista = ""
            pNPLVHT_Tracto = ""
            pCBRCNT_Brevete = ""
            pTNMCMC_NomApeChofer = ""
            pQCNDTG_CantServicioGuia = 0
            pCUNDSR_Unidad = ""
            pNLQDCN_NroLiquidacion = 0
            pSGUIFC_StatusFacturado = ""
            pPSOVOL_PesoVolumen = 0
            pPMRCMC_PesoNeto = 0
            pPBRTOR_PesoBruto = 0
            pTCMTRT_Proveedor = ""
            pCantLiq = 0
            pNUMEROCO = 0
        End Sub
#End Region
    End Class


    ''' <summary>
    ''' Primary Key Tabla RZTR15 - Guias de Remisión Hija de la Guia de Remision cargada a la Guia de Transportista
    ''' </summary>
    <StructLayout(LayoutKind.Sequential)> _
    Public Class TD_GRemHijasCargadasGTranspLiqPK
#Region " Atributos "
        Public pNOPRCN_NroOperacion As Int64 = 0
        Public pNGUITR_GuiaRemisionCargada As Int64 = 0
        Public pNGUIRF_NroDocumentoReferencia As Int64 = 0
        Public pCCMPN_Compania As String
#End Region
#Region " Métodos "
        Sub New()
            pNOPRCN_NroOperacion = 0
            pNGUITR_GuiaRemisionCargada = 0
            pNGUIRF_NroDocumentoReferencia = 0
        End Sub

        Sub New(ByVal Operacion As Int64, ByVal GuiaRemision As Int64, ByVal GuiaReferencial As Int64)
            pNOPRCN_NroOperacion = Operacion
            pNGUITR_GuiaRemisionCargada = GuiaRemision
            pNGUIRF_NroDocumentoReferencia = GuiaReferencial
        End Sub

        Public Sub pClear()
            pNOPRCN_NroOperacion = 0
            pNGUITR_GuiaRemisionCargada = 0
            pNGUIRF_NroDocumentoReferencia = 0
        End Sub
#End Region
    End Class

    ''' <summary>
    ''' Información Tabla RZTR15 - Guias de Remisión Hija de la Guia de Remision cargada a la Guia de Transportista
    ''' </summary>
    <StructLayout(LayoutKind.Sequential)> _
    Public Class TD_Obj_GRemHijasCargadasGTranspLiq
#Region " Atributos "
        Public pNOPRCN_NroOperacion As Int64 = 0
        Public pNGUITR_GuiaRemisionCargada As Int64 = 0
        Public pNGUIRF_NroDocumentoReferencia As Int64 = 0
        Public pQCCMP1_CantidadComponente1Gsl As Decimal = 0
        Public pQCCMP2_CantidadComponente2Dsl As Decimal = 0
        Public pTDSEXO_Observacion As String = ""
        Public pCCLNT1_CodigoCliente As Int64 = 0
#End Region
#Region " Métodos "
        Public Sub pClear()
            pNOPRCN_NroOperacion = 0
            pNGUITR_GuiaRemisionCargada = 0
            pNGUIRF_NroDocumentoReferencia = 0
            pQCCMP1_CantidadComponente1Gsl = 0
            pQCCMP2_CantidadComponente2Dsl = 0
            pTDSEXO_Observacion = ""
            pCCLNT1_CodigoCliente = 0
        End Sub
#End Region
    End Class


    ''' <summary>
    ''' Primary Key Tabla RZTR32 - Servicios asociados a la Guia de Remisión de la Guia de Transportista
    ''' </summary>
    <StructLayout(LayoutKind.Sequential)> _
    Public Class TD_GRemServCargadasGTranspLiqPK
#Region " Atributos "
        Public pCTRMNC_CodigoTransportista As Int32 = 0
        Public pNGUIRM_NroGuiaTransportista As Int64 = 0
        Public pNOPRCN_NroOperacion As Int64 = 0
        Public pNGUITR_NroGuiaRemision As Int64 = 0
        Public pMMCUSR_Usuario As String = ""
        Public pNTRMNL_Terminal As String = ""
        Public pCCMPN_Compania As String = ""

#End Region
#Region " Métodos "
        Sub New()
            pCTRMNC_CodigoTransportista = 0
            pNGUIRM_NroGuiaTransportista = 0
            pNOPRCN_NroOperacion = 0
            pNGUITR_NroGuiaRemision = 0
            pMMCUSR_Usuario = ""
            pNTRMNL_Terminal = ""
        End Sub

        Sub New(ByVal Transportista As Int32, ByVal GuiaTransportista As Int64, ByVal Operacion As Int64, ByVal GuiaRemision As Int64, ByVal Usuario As String, ByVal Terminal As String)
            pCTRMNC_CodigoTransportista = Transportista
            pNGUIRM_NroGuiaTransportista = GuiaTransportista
            pNOPRCN_NroOperacion = Operacion
            pNGUITR_NroGuiaRemision = GuiaRemision
            pMMCUSR_Usuario = Usuario
            pNTRMNL_Terminal = Terminal
        End Sub

        Public Sub pClear()
            pCTRMNC_CodigoTransportista = 0
            pNGUIRM_NroGuiaTransportista = 0
            pNOPRCN_NroOperacion = 0
            pNGUITR_NroGuiaRemision = 0
            pMMCUSR_Usuario = ""
            pNTRMNL_Terminal = ""
        End Sub
#End Region
    End Class

    ''' <summary>
    ''' Información de los Servicios de la Guia de Remision Cargada a la Guia Transportista Liquidación
    ''' </summary>
    <StructLayout(LayoutKind.Sequential)> _
    Public Class TD_Obj_GRemServCargadasGTranspLiq
#Region " Atributos "
        'Public pNOPRCN_NroOperacion As Int64 = 0
        Public _pNOPRCN_NroOperacion As Int64 = 0
        Public Property pNOPRCN_NroOperacion() As Int64
            Get
                Return _pNOPRCN_NroOperacion
            End Get
            Set(ByVal value As Int64)
                _pNOPRCN_NroOperacion = value
            End Set
        End Property


        'Public pNGUITR_NroGuiaRemision As Int64 = 0
        'Public pNCRRGU_CorrServ As Int32 = 0
        'Public pCSRVC_Servicio As Int32 = 0
        'Public pTCMTRF_DetalleServicio As String = ""
        'Public pISRVGU_importeServicio As Decimal = 0
        'Public pCMNDGU_MonedaGuia As Int32 = 0
        'Public pCMNDGU_MonedaGuia_S As String = ""
        'Public pQCNDTG_CantidadServicio As Decimal = 0
        'Public pCUNDSR_Unidad As String = ""
        'Public pSFCTTR_StatusFacturado As String = ""
        'Public pILQDTR_ImporteLiquidacionTransp As Decimal = 0
        'Public pQCNDLG_CantidadServicioLiquidacion As Decimal = 0
        'Public pCUNDTR_Unidad As String = ""
        'Public pSLQDTR_StatusLiquTransporte As String = ""
        'Public pTRFSRG_RefrenciaServicioGuia As String = ""
        'Public pCMNLQT_Moneda As Int32 = 0
        'Public pCMNLQT_Moneda_S As String = ""
        'Public pTCMTRT_Proveedor As String = ""
        'Public pCTRSPT_CodProveedor As Decimal = 0
        'Public pNRUCTR_RucProveedor As String = ""
        'Public pNLQDCN_NroLiquidacion As Decimal = 0
        'Public pVLRFDT_ValReferencia As Decimal = 0
        'Public pSFCTOP_SERV As String = ""
        'Public pSFLGTI_StTarifaInterna As String = String.Empty
        'Public pQCNDTI_CantidadTarifaInterna As Decimal
        'Public pCUNDTI_UnidadTarifaInterna As String = String.Empty
        'Public pISRVTI_ImporteTarifaInt As Decimal
        'Public pCMNDTI_DESC_Moneda As String
        'Public pNUMEROCO_NroTarifaInterna As Decimal
        'Public pCMNDTI As String = String.Empty
        'Public pSENITEM As Decimal = 0

        'Public COBRO_S As Decimal = 0
        'Public PAGO_S As Decimal = 0
        'Public MARGEN_S As Decimal = 0
        'Public MARGEN_POR As Decimal = 0


        Private _pNGUITR_NroGuiaRemision As Int64 = 0

        Public Property pNGUITR_NroGuiaRemision() As Int64
            Get
                Return _pNGUITR_NroGuiaRemision
            End Get
            Set(ByVal value As Int64)
                _pNGUITR_NroGuiaRemision = value
            End Set
        End Property

        Private _pNCRRGU_CorrServ As Int32 = 0

        Public Property pNCRRGU_CorrServ() As Int32
            Get
                Return _pNCRRGU_CorrServ
            End Get
            Set(ByVal value As Int32)
                _pNCRRGU_CorrServ = value
            End Set
        End Property

        Private _pCSRVC_Servicio As Int32 = 0

        Public Property pCSRVC_Servicio() As Int32
            Get
                Return _pCSRVC_Servicio
            End Get
            Set(ByVal value As Int32)
                _pCSRVC_Servicio = value
            End Set
        End Property

        Private _pTCMTRF_DetalleServicio As String = ""

        Public Property pTCMTRF_DetalleServicio() As String
            Get
                Return _pTCMTRF_DetalleServicio
            End Get
            Set(ByVal value As String)
                _pTCMTRF_DetalleServicio = value
            End Set
        End Property


        Private _pISRVGU_importeServicio As Decimal = 0

        Public Property pISRVGU_importeServicio() As Decimal
            Get
                Return _pISRVGU_importeServicio
            End Get
            Set(ByVal value As Decimal)
                _pISRVGU_importeServicio = value
            End Set
        End Property


        Private _pCMNDGU_MonedaGuia As Int32 = 0

        Public Property pCMNDGU_MonedaGuia() As Int32
            Get
                Return _pCMNDGU_MonedaGuia
            End Get
            Set(ByVal value As Int32)
                _pCMNDGU_MonedaGuia = value
            End Set
        End Property


        Private _pCMNDGU_MonedaGuia_S As String = ""

        Public Property pCMNDGU_MonedaGuia_S() As String
            Get
                Return _pCMNDGU_MonedaGuia_S
            End Get
            Set(ByVal value As String)
                _pCMNDGU_MonedaGuia_S = value
            End Set
        End Property


        Private _pQCNDTG_CantidadServicio As Decimal = 0

        Public Property pQCNDTG_CantidadServicio() As Decimal
            Get
                Return _pQCNDTG_CantidadServicio
            End Get
            Set(ByVal value As Decimal)
                _pQCNDTG_CantidadServicio = value
            End Set
        End Property

        Private _pCUNDSR_Unidad As String = ""

        Public Property pCUNDSR_Unidad() As String
            Get
                Return _pCUNDSR_Unidad
            End Get
            Set(ByVal value As String)
                _pCUNDSR_Unidad = value
            End Set
        End Property

        Private _pSFCTTR_StatusFacturado As String = ""

        Public Property pSFCTTR_StatusFacturado() As String
            Get
                Return _pSFCTTR_StatusFacturado
            End Get
            Set(ByVal value As String)
                _pSFCTTR_StatusFacturado = value
            End Set
        End Property

        Private _pILQDTR_ImporteLiquidacionTransp As Decimal = 0

        Public Property pILQDTR_ImporteLiquidacionTransp() As Decimal
            Get
                Return _pILQDTR_ImporteLiquidacionTransp
            End Get
            Set(ByVal value As Decimal)
                _pILQDTR_ImporteLiquidacionTransp = value
            End Set
        End Property

        Private _pQCNDLG_CantidadServicioLiquidacion As Decimal = 0

        Public Property pQCNDLG_CantidadServicioLiquidacion() As Decimal
            Get
                Return _pQCNDLG_CantidadServicioLiquidacion
            End Get
            Set(ByVal value As Decimal)
                _pQCNDLG_CantidadServicioLiquidacion = value
            End Set
        End Property

        Private _pCUNDTR_Unidad As String = ""

        Public Property pCUNDTR_Unidad() As String
            Get
                Return _pCUNDTR_Unidad
            End Get
            Set(ByVal value As String)
                _pCUNDTR_Unidad = value
            End Set
        End Property


        Private _pSLQDTR_StatusLiquTransporte As String = ""

        Public Property pSLQDTR_StatusLiquTransporte() As String
            Get
                Return _pSLQDTR_StatusLiquTransporte
            End Get
            Set(ByVal value As String)
                _pSLQDTR_StatusLiquTransporte = value
            End Set
        End Property


        Private _pTRFSRG_RefrenciaServicioGuia As String = ""

        Public Property pTRFSRG_RefrenciaServicioGuia() As String
            Get
                Return _pTRFSRG_RefrenciaServicioGuia
            End Get
            Set(ByVal value As String)
                _pTRFSRG_RefrenciaServicioGuia = value
            End Set
        End Property


        Private _pCMNLQT_Moneda As Int32 = 0

        Public Property pCMNLQT_Moneda() As Int32
            Get
                Return _pCMNLQT_Moneda
            End Get
            Set(ByVal value As Int32)
                _pCMNLQT_Moneda = value
            End Set
        End Property


        Private _pCMNLQT_Moneda_S As String = ""

        Public Property pCMNLQT_Moneda_S() As String
            Get
                Return _pCMNLQT_Moneda_S
            End Get
            Set(ByVal value As String)
                _pCMNLQT_Moneda_S = value
            End Set
        End Property

        Private _pTCMTRT_Proveedor As String = ""

        Public Property pTCMTRT_Proveedor() As String
            Get
                Return _pTCMTRT_Proveedor
            End Get
            Set(ByVal value As String)
                _pTCMTRT_Proveedor = value
            End Set
        End Property

        Private _pCTRSPT_CodProveedor As Decimal = 0

        Public Property pCTRSPT_CodProveedor() As Decimal
            Get
                Return _pCTRSPT_CodProveedor
            End Get
            Set(ByVal value As Decimal)
                _pCTRSPT_CodProveedor = value
            End Set
        End Property

        Private _pNRUCTR_RucProveedor As String = ""

        Public Property pNRUCTR_RucProveedor() As String
            Get
                Return _pNRUCTR_RucProveedor
            End Get
            Set(ByVal value As String)
                _pNRUCTR_RucProveedor = value
            End Set
        End Property

        Private _pNLQDCN_NroLiquidacion As Decimal = 0

        Public Property pNLQDCN_NroLiquidacion() As Decimal
            Get
                Return _pNLQDCN_NroLiquidacion
            End Get
            Set(ByVal value As Decimal)
                _pNLQDCN_NroLiquidacion = value
            End Set
        End Property

        Private _pVLRFDT_ValReferencia As Decimal = 0

        Public Property pVLRFDT_ValReferencia() As Decimal
            Get
                Return _pVLRFDT_ValReferencia
            End Get
            Set(ByVal value As Decimal)
                _pVLRFDT_ValReferencia = value
            End Set
        End Property

        Private _pSFCTOP_SERV As String = ""

        Public Property pSFCTOP_SERV() As String
            Get
                Return _pSFCTOP_SERV
            End Get
            Set(ByVal value As String)
                _pSFCTOP_SERV = value
            End Set
        End Property

        Private _pSFLGTI_StTarifaInterna As String = ""

        Public Property pSFLGTI_StTarifaInterna() As String
            Get
                Return _pSFLGTI_StTarifaInterna
            End Get
            Set(ByVal value As String)
                _pSFLGTI_StTarifaInterna = value
            End Set
        End Property

        Private _pQCNDTI_CantidadTarifaInterna As Decimal = 0

        Public Property pQCNDTI_CantidadTarifaInterna() As Decimal
            Get
                Return _pQCNDTI_CantidadTarifaInterna
            End Get
            Set(ByVal value As Decimal)
                _pQCNDTI_CantidadTarifaInterna = value
            End Set
        End Property

        Private _pCUNDTI_UnidadTarifaInterna As String = ""

        Public Property pCUNDTI_UnidadTarifaInterna() As String
            Get
                Return _pCUNDTI_UnidadTarifaInterna
            End Get
            Set(ByVal value As String)
                _pCUNDTI_UnidadTarifaInterna = value
            End Set
        End Property

        Private _pISRVTI_ImporteTarifaInt As Decimal = 0

        Public Property pISRVTI_ImporteTarifaInt() As Decimal
            Get
                Return _pISRVTI_ImporteTarifaInt
            End Get
            Set(ByVal value As Decimal)
                _pISRVTI_ImporteTarifaInt = value
            End Set
        End Property


        Private _pCMNDTI_DESC_Moneda As String = ""

        Public Property pCMNDTI_DESC_Moneda() As String
            Get
                Return _pCMNDTI_DESC_Moneda
            End Get
            Set(ByVal value As String)
                _pCMNDTI_DESC_Moneda = value
            End Set
        End Property


        Private _pNUMEROCO_NroTarifaInterna As Decimal = 0

        Public Property pNUMEROCO_NroTarifaInterna() As Decimal
            Get
                Return _pNUMEROCO_NroTarifaInterna
            End Get
            Set(ByVal value As Decimal)
                _pNUMEROCO_NroTarifaInterna = value
            End Set
        End Property

        Private _pCMNDTI As String = ""

        Public Property pCMNDTI() As String
            Get
                Return _pCMNDTI
            End Get
            Set(ByVal value As String)
                _pCMNDTI = value
            End Set
        End Property

        Private _pSENITEM As Decimal = 0

        Public Property pSENITEM() As Decimal
            Get
                Return _pSENITEM
            End Get
            Set(ByVal value As Decimal)
                _pSENITEM = value
            End Set
        End Property


        Private _COBRO_S As Decimal = 0

        Public Property COBRO_S() As Decimal
            Get
                Return _COBRO_S
            End Get
            Set(ByVal value As Decimal)
                _COBRO_S = value
            End Set
        End Property

        Private _PAGO_S As Decimal = 0

        Public Property PAGO_S() As Decimal
            Get
                Return _PAGO_S
            End Get
            Set(ByVal value As Decimal)
                _PAGO_S = value
            End Set
        End Property


        Private _MARGEN_S As Decimal = 0

        Public Property MARGEN_S() As Decimal
            Get
                Return _MARGEN_S
            End Get
            Set(ByVal value As Decimal)
                _MARGEN_S = value
            End Set
        End Property

        Private _MARGEN_POR As Decimal = 0

        Public Property MARGEN_POR() As Decimal
            Get
                Return _MARGEN_POR
            End Get
            Set(ByVal value As Decimal)
                _MARGEN_POR = value
            End Set
        End Property


        Private _pFLGOTF_FlagTarifaOS As String = ""

        Public Property pFLGOTF_FlagTarifaOS As String
            Get
                Return _pFLGOTF_FlagTarifaOS
            End Get
            Set(ByVal value As String)
                _pFLGOTF_FlagTarifaOS = value
            End Set
        End Property


 

#End Region
#Region " Métodos "
        Public Sub pClear()
            pNOPRCN_NroOperacion = 0
            pNGUITR_NroGuiaRemision = 0
            pNCRRGU_CorrServ = 0
            pCSRVC_Servicio = 0
            pTCMTRF_DetalleServicio = ""
            pISRVGU_importeServicio = 0
            pQCNDTG_CantidadServicio = 0
            pQCNDTG_CantidadServicio = 0
            pCUNDSR_Unidad = ""
            pSFCTTR_StatusFacturado = ""

            pILQDTR_ImporteLiquidacionTransp = 0
            pQCNDLG_CantidadServicioLiquidacion = 0
            pCUNDTR_Unidad = ""
            pSLQDTR_StatusLiquTransporte = ""

            pTRFSRG_RefrenciaServicioGuia = ""
            pCMNLQT_Moneda = 0
            pCMNLQT_Moneda_S = ""
            pTCMTRT_Proveedor = ""
            pCTRSPT_CodProveedor = 0
            pNRUCTR_RucProveedor = ""
            pNLQDCN_NroLiquidacion = 0
            pVLRFDT_ValReferencia = 0
            pSFCTOP_SERV = ""
            pSENITEM = 0
        End Sub
#End Region
    End Class

    <StructLayout(LayoutKind.Sequential)> _
    Public Class TD_Obj_InfGRemCargada
#Region " Atributos "
        Public pCTRMNC_CodigoTransportista As Int32 = 0
        Public pNGUIRM_NroGuiaTransportista As Int64 = 0
        'Public pNGUITS_NroGuiaTransportistaTXT As Int64 = 0
        Public pNGUITS_NroGuiaTransportistaTXT As String = ""


        Public pNGUITR_GuiaRemisionCargada As Int64 = 0
        Public pNGUITR_GuiaRemisionCargadaTXT As String = ""
        Public pFGUITR_FechaGuiaRemision As Date
        Public pRELGUI_RelacionGuiaHijas As String = ""

        Public pNOPRCN_NroOperacion As Int64 = 0
        Public pNLQDCN_NroLiquidacion As Int64 = 0
        Public pCTRSPT_Transportista As Int32 = 0
        Public pNRUCTR_Transportista As String = ""
        Public pTCMTRT_RazSocialTransportista As String = ""
        Public pNPLVHT_Tracto As String = ""
        Public pCBRCNT_Brevete As String = ""
        Public pCMRCDR_Mercaderia As Int32 = 0
        Public pTAMRCD_DetalleMercaderia As String = ""
        Public pFRCGRM_FechaRecepGuiaRemision As Date

        Public pCCLNT1_CodigoCliente As Int64 = 0
        Public pCLCLOR_CodigoLocalidadOrigen As Int32 = 0
        Public pTCMLCO_LocalidadOrigen As String = ""
        Public pCLCLDS_CodigoLocalidadDestino As Int32 = 0
        Public pTCMLCD_LocalidadDestino As String = ""

        Public pQGLGSL_CantidadGlsGasolina As Decimal = 0
        Public pQGLDSL_CantidadGlsDiesel As Decimal = 0
        Public pNRHJCR_NroHojasCargui As Int32 = 0
        Public pCPRCN1_CodigoPropietarioContenedor1 As String = ""
        Public pNSRCN1_SerieContenedor1 As String = ""
        Public pCPRCN2_CodigoPropietarioContenedor2 As String = ""
        Public pNSRCN2_SerieContenedor2 As String = ""
        Public pFLLGCM_FechaLlegadaCamion As Date
        'Public pFLLGCM_sFechaLlegadaCamion As String = ""
        Public pFSLDCM_FechaSalidaCamion As Date
        Public pQKLMRC_KilometrosRecorridos As Int64 = 0
        Public pQHRSRV_CantidadHorasServicio As Decimal = 0
        Public pCCMPN_Compania As String

        Public pQBLRMS_CantidadBultosRemision As Decimal = 0
        Public pPBRTOR_PesoBrutoRemision As Int64 = 0
        Public pPTRAOR_PesoTaraRemision As Int64 = 0
        Public pQVLMOR_VolumenRemision As Decimal = 0

        Public pQBLRCP_CantidadBultosRecepcion As Decimal = 0
        Public pPBRDST_PesoBrutoRecepcion As Int64 = 0
        Public pPTRDST_PesoTaraRecepcion As Int64 = 0
        Public pQVLMDS_VolumenRecepcion As Decimal = 0
        Public pNOREMB_OrdenEmbarcador As String = ""

        Public pSSINVJ_FlagSiniestroViaje As String = ""
        Public pMMCUSR_Usuario As String = ""
        Public pNTRMNL_Terminal As String = ""

        Public pCRGVTA As String = "" 'ECM-HUNDRED-20150821

        'Codigo agregado por MREATEGUIP - Ajuste Moneda
        '----- Ini -----
        Public pMONEDA_OS As Decimal = 0
        Public pBLQ_MONEDA As String = ""
        Public SESGRP As String = ""
        Public SGUIFC As String = ""
        Public FLGSTA As String = ""
        '----- Fin -----
#End Region
#Region " Propiedades "
        Public ReadOnly Property pFGUITR_FechaGuiaRemisionFNum() As Int32
            Get
                Dim iFNum As Int32 = 0
                If pFGUITR_FechaGuiaRemision.Year > 1 Then
                    Int32.TryParse(pFGUITR_FechaGuiaRemision.ToString("yyyyMMdd"), iFNum)
                End If
                Return iFNum
            End Get
        End Property

        Public ReadOnly Property pFRCGRM_FechaRecepGuiaRemisionFNum() As Int32
            Get
                Dim iFNum As Int32 = 0
                If pFRCGRM_FechaRecepGuiaRemision.Year > 1 Then
                    Int32.TryParse(pFRCGRM_FechaRecepGuiaRemision.ToString("yyyyMMdd"), iFNum)
                End If
                Return iFNum
            End Get
        End Property

        Public ReadOnly Property pFLLGCM_FechaLlegadaCamionFNum() As Int32
            Get
                Dim iFNum As Int32 = 0
                If pFLLGCM_FechaLlegadaCamion.Year > 1 Then
                    Int32.TryParse(pFLLGCM_FechaLlegadaCamion.ToString("yyyyMMdd"), iFNum)
                End If
                Return iFNum
            End Get
        End Property

        Public ReadOnly Property pFSLDCM_FechaSalidaCamionFNum() As Int32
            Get
                Dim iFNum As Int32 = 0
                If pFSLDCM_FechaSalidaCamion.Year > 1 Then
                    Int32.TryParse(pFSLDCM_FechaSalidaCamion.ToString("yyyyMMdd"), iFNum)
                End If
                Return iFNum
            End Get
        End Property
#End Region
#Region " Métodos "
        Public Sub pClear()
            pCTRMNC_CodigoTransportista = 0
            pNGUIRM_NroGuiaTransportista = 0
            pNGUITR_GuiaRemisionCargada = 0
            pFGUITR_FechaGuiaRemision = New Date
            pRELGUI_RelacionGuiaHijas = ""
            pCCLNT1_CodigoCliente = 0
            pCLCLOR_CodigoLocalidadOrigen = 0
            pTCMLCO_LocalidadOrigen = ""
            pCLCLDS_CodigoLocalidadDestino = 0
            pTCMLCD_LocalidadDestino = ""

            pNOPRCN_NroOperacion = 0
            pNLQDCN_NroLiquidacion = 0
            pCTRSPT_Transportista = 0
            pTCMTRT_RazSocialTransportista = ""
            pNPLVHT_Tracto = ""
            pCBRCNT_Brevete = ""
            pCMRCDR_Mercaderia = 0
            pTAMRCD_DetalleMercaderia = ""

            pQGLGSL_CantidadGlsGasolina = 0
            pQGLDSL_CantidadGlsDiesel = 0
            pNRHJCR_NroHojasCargui = 0
            pCPRCN1_CodigoPropietarioContenedor1 = ""
            pNSRCN1_SerieContenedor1 = ""
            pCPRCN2_CodigoPropietarioContenedor2 = ""
            pNSRCN2_SerieContenedor2 = ""
            pFLLGCM_FechaLlegadaCamion = New Date
            pFSLDCM_FechaSalidaCamion = New Date
            pQKLMRC_KilometrosRecorridos = 0
            pQHRSRV_CantidadHorasServicio = 0

            pQBLRMS_CantidadBultosRemision = 0
            pPBRTOR_PesoBrutoRemision = 0
            pPTRAOR_PesoTaraRemision = 0
            pQVLMOR_VolumenRemision = 0

            pQBLRCP_CantidadBultosRecepcion = 0
            pPBRDST_PesoBrutoRecepcion = 0
            pPTRDST_PesoTaraRecepcion = 0
            pQVLMDS_VolumenRecepcion = 0

            pMMCUSR_Usuario = ""
            pNTRMNL_Terminal = ""

            'Codigo agregado por MREATEGUIP - Ajuste Moneda
            '----- Ini -----
            pMONEDA_OS = 0
            pBLQ_MONEDA = ""
            '----- Fin -----
        End Sub
#End Region
    End Class

    <StructLayout(LayoutKind.Sequential)> _
    Public Class TD_Obj_LiquidacionGuiaRemision
#Region " Atributos "
        Public pNOPRCN_NroOperacion As Int64 = 0
        Public pNGUIRM_NroGuiaTransportista As Int64 = 0
        Public pFTRMOP_FechaOperacion As Date
        Public pMMCUSR_Usuario As String = ""
        Public pNTRMNL_Terminal As String = ""
        Public pCCMPN_Compania As String = ""
        'JMC
        Public pTOBS_Observacion As String = ""
        Public pTipo As Int64 = 0
        Public pCTRSPT As Int64 = 0
        Public pNGUITR As Int64 = 0
        Public pNMOPRP As Int64 = 0
        Public pMRGPOR As Decimal = 0
        Public pNLBFLT As Decimal = 0
        Public pCDVSN_Division As String = ""
        Public pTIPVIAJ As String = ""
        Public pNROVIAJ As Decimal = 0
#End Region
#Region " Propiedades "
        Public ReadOnly Property pFTRMOP_FechaOperacionFNum() As Int32
            Get
                Dim iFNum As Int32 = 0
                If pFTRMOP_FechaOperacion.Year > 1 Then
                    Int32.TryParse(pFTRMOP_FechaOperacion.ToString("yyyyMMdd"), iFNum)
                End If
                Return iFNum
            End Get
        End Property
#End Region
#Region " Métodos "
        Public Sub pClear()
            pNOPRCN_NroOperacion = 0
            pNGUIRM_NroGuiaTransportista = 0
            pFTRMOP_FechaOperacion = New Date
            pMMCUSR_Usuario = ""
            pNTRMNL_Terminal = ""
            'JMC
            pTOBS_Observacion = ""
        End Sub
#End Region
    End Class

    <StructLayout(LayoutKind.Sequential)> _
    Public Class TD_Obj_GRemAgregarServCargadasGTranspLiq
#Region " Atributos "
        Public pNOPRCN_NroOperacion As Int64 = 0
        Public pNGUITR_NroGuiaRemision As Int64 = 0
        Public pNCRRGU_CorrServ As Int32 = 0
        Public pCSRVC_Servicio As Int32 = 0
        Public pTRFSRG_RefrenciaServicioGuia As String = ""
        Public pCMNDGU_MonedaGuia As Int32 = 0
        Public pISRVGU_importeServicio As Decimal = 0
        Public pQCNDTG_CantServicioGuia As Decimal = 0
        Public pCUNDSR_Unidad As String = ""
        Public pSFCTTR_StatusFacturado As String = ""
        Public pMMCUSR_Usuario As String = ""
        Public pNTRMNL_Terminal As String = ""
        Public pCCMPN_Compania As String = ""
        Public pCTRSPT_CodigoProveedor As Decimal = 0
        Public pNRUCTR_RucProveedor As String = ""
        Public pNLQDCN_NroLiquidacion As Decimal = 0

        'JMC
        Public pSLQDTR_StatusLiquTransporte As String = ""
        Public pCMNLQT_Moneda As Decimal = 0
        Public pILQDTR_ImporteLiquidacionTransp As Decimal = 0
        Public pQCNDLG_CantidadServicioLiquidacion As Decimal = 0
        'VER
        Public pNCRRDT_CorrDetalle As Int32 = 0

        'VENTA INTERNA
        Public pSSFLGTI_StatusLiquTransporteTI As String = String.Empty
        Public pNQCNDTI_CantidadServicioLiquidacionTI As Decimal = 0
        Public pCUNDTI_UnidadMedidaTI As String = String.Empty
        Public pNISRVTI_ImporteLiquidacionTranspTI As Decimal = 0
        Public pNCMNDTI_MonedaTI As Decimal = 0
        Public pSESTRG As String = ""

#End Region
#Region " Métodos "
        Public Sub pClear()
            pNOPRCN_NroOperacion = 0
            pNGUITR_NroGuiaRemision = 0
            pNCRRGU_CorrServ = 0
            pCSRVC_Servicio = 0
            pTRFSRG_RefrenciaServicioGuia = ""
            pCMNDGU_MonedaGuia = 0
            pISRVGU_importeServicio = 0
            pQCNDTG_CantServicioGuia = 0
            pCUNDSR_Unidad = ""
            pSFCTTR_StatusFacturado = ""
            pMMCUSR_Usuario = ""
            pNTRMNL_Terminal = ""
            pCTRSPT_CodigoProveedor = 0
            pNRUCTR_RucProveedor = ""
            pNLQDCN_NroLiquidacion = 0
            'JMC
            pSLQDTR_StatusLiquTransporte = ""
            pCMNLQT_Moneda = 0
            pILQDTR_ImporteLiquidacionTransp = 0
            pQCNDLG_CantidadServicioLiquidacion = 0
            'VER
            pNCRRDT_CorrDetalle = 0

            pSSFLGTI_StatusLiquTransporteTI = String.Empty
            pNQCNDTI_CantidadServicioLiquidacionTI = 0
            pCUNDTI_UnidadMedidaTI = String.Empty
            pNISRVTI_ImporteLiquidacionTranspTI = 0
            pNCMNDTI_MonedaTI = 0
        End Sub
#End Region
    End Class

    <StructLayout(LayoutKind.Sequential)> _
    Public Class TD_Obj_GRemLiquServCargadasGTranspLiq
#Region " Atributos "
        Public pNOPRCN_NroOperacion As Int64 = 0
        Public pNGUITR_NroGuiaRemision As Int64 = 0
        Public pNCRRGU_CorrServ As Int32 = 0

        Public pCSRVC_Servicio As Int32 = 0
        Public pTCMTRF_DetalleServicio As String = ""

        Public pCMNLQT_Moneda As Int32 = 0

        Public pILQDTR_ImporteLiquidacionTransp As Decimal = 0
        Public pQCNDLG_CantidadServicioLiquidacion As Decimal = 0
        Public pCUNDTR_Unidad As String = ""
        Public pSLQDTR_StatusLiquTransporte As String = ""
        Public pMMCUSR_Usuario As String = ""
        Public pNTRMNL_Terminal As String = ""
        Public pCCMPN_Compania As String = ""
        Public pNRUCTR_RucProveedor As Decimal = 0

        'Codigo agregado por MREATEGUIP - Ajuste Moneda
        '----- Ini -----
        Public pMONEDA_OS As Decimal = 0
        Public pBLQ_MONEDA As String = ""
        '----- Fin -----
#End Region
#Region " Métodos "
        Public Sub pClear()
            pNOPRCN_NroOperacion = 0
            pNGUITR_NroGuiaRemision = 0
            pNCRRGU_CorrServ = 0
            pCSRVC_Servicio = 0
            pTCMTRF_DetalleServicio = ""
            pCMNLQT_Moneda = 0
            pILQDTR_ImporteLiquidacionTransp = 0
            pQCNDLG_CantidadServicioLiquidacion = 0
            pCUNDTR_Unidad = ""
            pSLQDTR_StatusLiquTransporte = ""
            pMMCUSR_Usuario = ""
            pNTRMNL_Terminal = ""
            pNRUCTR_RucProveedor = 0

            'Codigo agregado por MREATEGUIP - Ajuste Moneda
            '----- Ini -----
            pMONEDA_OS = 0
            pBLQ_MONEDA = ""
            '----- Fin -----
        End Sub
#End Region
    End Class

    <StructLayout(LayoutKind.Sequential)> _
    Public Class TD_Obj_GRemLiquServCargadasGTranspLiqPK
#Region " Atributos "
        Public pNOPRCN_NroOperacion As Int64 = 0
        Public pNGUITR_NroGuiaRemision As Int64 = 0
        Public pNCRRGU_CorrServ As Int32 = 0
        Public pMMCUSR_Usuario As String = ""
        Public pNTRMNL_Terminal As String = ""
        Public pCCMPN_Compania As String = ""
#End Region
#Region " Métodos "
        Public Sub pClear()
            pNOPRCN_NroOperacion = 0
            pNGUITR_NroGuiaRemision = 0
            pNCRRGU_CorrServ = 0
            pMMCUSR_Usuario = ""
            pNTRMNL_Terminal = ""
        End Sub
#End Region
    End Class

    Public Class TD_Qry_ServiciosFijosPorCliente
#Region " Atributos "
        Public pCCMPN_Compania As String = ""
        Public pCDVSN_Division As String = ""
        Public pCPLNDV_Planta As Int32 = 0
        Public pCCLNT_CodigoCliente As Int64 = 0
        Public pNORSRT_OrdenServicio As Int64 = 0
#End Region
#Region " Métodos "
        Public Sub pClear()
            pCCMPN_Compania = ""
            pCDVSN_Division = ""
            pCPLNDV_Planta = 0
            pCCLNT_CodigoCliente = 0
            pNORSRT_OrdenServicio = 0
        End Sub
#End Region


    End Class

    Public Class TD_obj_ListarServicioXViaje
#Region " Atributos "
        Public pCCMPN As String = ""
        Public pCDVSN As String = ""
        Public pCTRMNC As String = ""
        Public pNGUITR As String = ""
        Public pTIPVIAJ As String = ""
        Public pNROVIAJ As String = ""
#End Region
#Region " Métodos "
        Public Sub pClear()
            pCCMPN = ""
            pCDVSN = ""
            pCTRMNC = ""
            pNGUITR = ""
            pTIPVIAJ = ""
            pNROVIAJ = ""
        End Sub
#End Region
    End Class
    Public Class TD_obj_ActualizarStatusSeguinientoAprobacion
#Region " Atributos "

        Public pCCMPN As String = ""
        Public pCDVSN As String = ""
        Public pCTRMNC As String = ""
        Public pNGUITR As String = ""
        Public pTIPVIAJ As String = ""
        Public pNROVIAJ As String = ""
        Public pAPRBOP As String = ""
        Public pFCHAPR As String = ""
        Public pOBSAPR As String = ""
#End Region
#Region " Métodos "
        Public Sub pClear()
            pCCMPN = ""
            pCDVSN = ""
            pCTRMNC = ""
            pNGUITR = ""
            pTIPVIAJ = ""
            pNROVIAJ = ""
            pAPRBOP = ""
            pFCHAPR = ""
            pOBSAPR = ""
        End Sub
#End Region



    End Class


    'Nuevo
    Public Class TD_obj_Historial_Liquidacion
#Region " Atributos "
        Public pTIPO_LISTADO As String = ""
        Public pCCMPN As String = ""
        Public pCDVSN As String = ""
        Public pNOPRCN As String = ""
        Public pFINCOP_INI As String = ""
        Public pFINCOP_FIN As String = ""

        Public pCDUPSP As String = ""
        Public pCCLNT As Decimal = 0
 

#End Region
#Region " Métodos "
        Public Sub pClear()
            pTIPO_LISTADO = ""
            pCCMPN = ""
            pCDVSN = ""
            pNOPRCN = ""
            pFINCOP_INI = ""
            pFINCOP_FIN = ""
        End Sub
#End Region
    End Class

    Public Class TD_obj_Detalle_Liquidacion
#Region " Atributos "
        'Public pTIPO_LISTADO As String = ""
        Public pCCMPN As String = ""
        Public pCDVSN As String = ""
        Public pNOPRCN As String = ""
        Public pFECHA_INI As String = ""
        Public pFECHA_FIN As String = ""
        Public pCPLNDV As Decimal = 0
        Public pCDUPSP As String = ""
        Public pCCLNT As Decimal = 0
      
#End Region
#Region " Métodos "
        Public Sub pClear()
            'pTIPO_LISTADO = ""
            pCCMPN = ""
            pCDVSN = ""
            pNOPRCN = ""
            pFECHA_INI = ""
            pFECHA_FIN = ""
        End Sub
#End Region
    End Class




End Namespace