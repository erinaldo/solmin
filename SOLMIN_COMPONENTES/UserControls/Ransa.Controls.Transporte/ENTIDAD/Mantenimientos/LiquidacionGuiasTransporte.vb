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
        Public pCTRMNC_CodigoTransportista As Int32 = 0
        Public pNGUIRM_NroGuiaTransportista As Int64 = 0
        Public pNRGUCL_NroGuiaRemision As Int64 = 0
        Public pFCGUCL_FechaGuiaRemision As Date
        Public pCCLNT_CodigoCliente As Int64 = 0
        Public pTCMPCL_RazonSocialCliente As String = ""
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
    Public pNOPRCN_NroOperacion As Int64 = 0
    Public pNGUIRM_NroGuiaTransportista As Int64 = 0
    Public pNGUITR_GuiaRemisionCargada As Int64 = 0
    Public pFGUITR_FechaGuiaRemision As Date
    Public pCTRSPT_Transportista As Int32 = 0
    Public pTCMTRT_RazSocialTransportista As String = ""
    Public pNPLVHT_Tracto As String = ""
    Public pCBRCNT_Brevete As String = ""
    Public pTNMCMC_NomApeChofer As String = ""
    Public pQCNDTG_CantServicioGuia As Decimal = 0
    Public pCUNDSR_Unidad As String = ""
    Public pNLQDCN_NroLiquidacion As Int64 = 0
    Public pSGUIFC_StatusFacturado As String = ""
    Public pPSOVOL_PesoVolumen As Decimal = 0
    Public pPMRCMC_PesoNeto As Decimal = 0
    Public pPBRTOR_PesoBruto As Decimal = 0
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
    Public pNOPRCN_NroOperacion As Int64 = 0
    Public pNGUITR_NroGuiaRemision As Int64 = 0
    Public pNCRRGU_CorrServ As Int32 = 0
    Public pCSRVC_Servicio As Int32 = 0
    Public pTCMTRF_DetalleServicio As String = ""
    Public pISRVGU_importeServicio As Decimal = 0
    Public pCMNDGU_MonedaGuia As Int32 = 0
    Public pCMNDGU_MonedaGuia_S As String = ""
    Public pQCNDTG_CantidadServicio As Decimal = 0
    Public pCUNDSR_Unidad As String = ""
    Public pSFCTTR_StatusFacturado As String = ""
    Public pILQDTR_ImporteLiquidacionTransp As Decimal = 0
    Public pQCNDLG_CantidadServicioLiquidacion As Decimal = 0
    Public pCUNDTR_Unidad As String = ""
    Public pSLQDTR_StatusLiquTransporte As String = ""
    Public pTRFSRG_RefrenciaServicioGuia As String = ""
    Public pCMNLQT_Moneda As Int32 = 0
    Public pCMNLQT_Moneda_S As String = ""
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
    End Sub
#End Region
    End Class

    <StructLayout(LayoutKind.Sequential)> _
    Public Class TD_Obj_InfGRemCargada
#Region " Atributos "
    Public pCTRMNC_CodigoTransportista As Int32 = 0
    Public pNGUIRM_NroGuiaTransportista As Int64 = 0
    Public pNGUITR_GuiaRemisionCargada As Int64 = 0
    Public pFGUITR_FechaGuiaRemision As Date
    Public pRELGUI_RelacionGuiaHijas As String = ""

    Public pNOPRCN_NroOperacion As Int64 = 0
    Public pNLQDCN_NroLiquidacion As Int64 = 0
    Public pCTRSPT_Transportista As Int32 = 0
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
        Public pTipo As Int64 = 0
        Public pCTRSPT As Int64 = 0
        Public pNGUITR As Int64 = 0
        Public pNMOPRP As Int64 = 0
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
End Namespace