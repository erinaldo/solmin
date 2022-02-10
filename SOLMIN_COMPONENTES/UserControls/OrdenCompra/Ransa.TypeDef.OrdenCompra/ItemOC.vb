Imports System.Runtime.InteropServices

Namespace ItemOC
    <StructLayout(LayoutKind.Sequential)> _
    Public Class TD_ItemOCPK
        Public pCCLNT_CodigoCliente As Int64 = 0
        Public pNORCML_NroOrdenCompra As String = ""
        Public pNRITOC_NroItemOC As Int32 = 0
        Public pCREFFW_FrdForw As String = ""
        Public pCIDPAQ_CodIndentificacionPaquete As String = ""
        Public pCCMPN_Compania As String = ""
        Public pCDVSN_Division As String = ""
        Public pCPLNDV_Planta As Decimal = 0
        Public pNTRMNL_Terminal As String = ""
        Public pTDITES_DescripcionItems As String = ""
    End Class

    <StructLayout(LayoutKind.Sequential)> _
    Public Class TD_ItemOC
        Public pCCMPN_Compania As String = ""
        Public pCDVSN_Division As String = ""
        Public pCPLNDV_Planta As Decimal = 0
        Public pCCLNT_CodigoCliente As Int64 = 0
        Public pNORCML_NroOrdenCompra As String = ""
        Public pNRITOC_NroItemOC As Int32 = 0
        Public pTCITCL_CodigoCliente As String = ""
        Public pTCITPR_CodigoProveedor As String = ""
        Public pTDITES_DescripcionES As String = ""
        Public pTDITIN_DescripcionIN As String = ""
        Public pCPTDAR_PartidaArancelaria As String = ""
        Public pQCNTIT_Cantidad As Decimal = 0
        Public pTUNDIT_Unidad As String = ""
        Public pIVUNIT_ImporteUnitario As Decimal = 0
        Public pIVTOIT_ImporteTotal As Decimal = 0
        Public pQTOLMAX_ToleranciaMax As Decimal = 0
        Public pQTOLMIN_ToleranciaMin As Decimal = 0
        Public pFMPDME_FechaEstEntregaDte As Date
        Public pFMPIME_FechaReqPlantaDte As Date
        Public pTLUGOR_LugarOrigen As String = ""
        Public pTLUGEN_LugarEntrega As String = ""
        Public pFLGPEN_FlagSeguimiento As String = ""
        Public pTCTCST_CentroDeCosto As String = ""

        Public pTRFRN_RefSolicitante As String = ""
        Public pNTRMNL_NrTerminal As String = ""


        '    Public PTRFRN_RefSolicitante As String = ""
        'Public PTRFRNA_RefSolicitanteOA As String = ""
        'Public PTRFRNA_RefA As String = ""
        Public PTRFRNB_RefB As String = ""
        Public PTRFRN1_CentroDestino As String = ""
        Public PTRFRN2_AlmDestino As String = ""
        Public PTRFRN3_Ref3 As String = ""
        Public PTRFRN4_AlmProcedencia As String = ""
        Public PTRFRN5_Direccion5 As String = ""
        Public PTRFRN6_ClaseValoracion As String = ""

        'Agregado para el código sunat
        Public pUNSPSC_Sunat As String = ""

        Public ReadOnly Property pFMPDME_FechaEstEntregaInt() As Int32
            Get
                Dim intTemp As Int32 = 0
                If pFMPDME_FechaEstEntregaDte.Year > 1 Then Int32.TryParse(pFMPDME_FechaEstEntregaDte.ToString("yyyyMMdd"), intTemp)
                Return intTemp
            End Get
        End Property

        Public ReadOnly Property pFMPIME_FechaReqPlantaInt() As Int32
            Get
                Dim intTemp As Int32 = 0
                If pFMPIME_FechaReqPlantaDte.Year > 1 Then Int32.TryParse(pFMPIME_FechaReqPlantaDte.ToString("yyyyMMdd"), intTemp)
                Return intTemp
            End Get
        End Property
    End Class

    <StructLayout(LayoutKind.Sequential)> _
     Public Class TD_ItemOCForWayBill
#Region " Atributos "
        Public pNORCML_OrdenCompra As String = ""
        Public pNRITOC_NroItemOC As Int32 = 0
        Public pTCITCL_CodigoCliente As String = ""
        Public pQCNREC_QtaRecibida As Decimal = 0D
        Public pTUNDIT_UnidadQta As String = ""
        Public pTDAITM_Observaciones As String = ""
        Public pQPEPQT_QtaPeso As Decimal = 0
        Public pTUNPSO_UnidadPeso As String = ""
        Public pQVOPQT_QtaVolumen As Decimal = 0
        Public pTUNVOL_UnidadVolumen As String = ""
        Public pCMRCD_CodigoRANSA As String = ""
        Public pTMRCD2_MercaDescripcion As String = ""
        Public pNORDSR_OrdenServicio As Int64 = 0
        Public pNCNTR_NroContrato As Int64 = 0
        Public pNCRCTC_NroCorrelativoContrato As Int64 = 0
        Public pNAUTR_NroAutorizacionContrato As Int64 = 0
        Public pFUNDS2_Status As String = ""
        Public pCTPDPS_TipoDeposito As String = ""
        Public pCUNCN5_UnidadCantidad As String = ""
        Public pCUNPS5_UnidadPeso As String = ""
        Public pCUNVL5_UnidadValor As String = ""
        Public pTDITES_DescripcionItem As String = ""
        Public pQCNTIT_CantidadSolicitada As Int64 = 0
        Public pQCNPEN_CantidadPendiente As Int64 = 0
        Public pTLUGEN_LugarDeEntrega As String = ""
        Public pQPEPQT_Peso As Int64 = 0
        Public pTLUGOR_LugarDeOrigen As String = ""
        Public pTPOOCM_TipoOc As String = ""
        Public pFMPDME_FechaMaxDespacho As String
        Public pFUNCTL_FlagControlDeLotes As String = ""
        Public pUNSPSC_CodUn As String = ""
        Public pCPRVCL_IdProveedor As Decimal = 0
        Public pTPRVCL_DescProveedor As String = ""
        Public pFlagControlUbicacion As String = ""
        Public pFlagControlSerie As String = ""
        Public pCantOS_X_SKU As Decimal = 0
#End Region
#Region " Métodos "
        Public Sub pClear()
            pNORCML_OrdenCompra = ""
            pNRITOC_NroItemOC = 0
            pTCITCL_CodigoCliente = ""
            pQCNREC_QtaRecibida = 0D
            pTUNDIT_UnidadQta = ""
            pTDAITM_Observaciones = ""
            pQPEPQT_QtaPeso = 0
            pTUNPSO_UnidadPeso = ""
            pQVOPQT_QtaVolumen = 0
            pTUNVOL_UnidadVolumen = ""
            pCMRCD_CodigoRANSA = ""
            pTMRCD2_MercaDescripcion = ""
            pNORDSR_OrdenServicio = 0
            pNCNTR_NroContrato = 0
            pNCRCTC_NroCorrelativoContrato = 0
            pNAUTR_NroAutorizacionContrato = 0
            pFUNDS2_Status = ""
            pCTPDPS_TipoDeposito = ""
            pCUNCN5_UnidadCantidad = ""
            pCUNPS5_UnidadPeso = ""
            pCUNVL5_UnidadValor = ""
            pTDITES_DescripcionItem = ""
            pTDITES_DescripcionItem = ""
            pQCNTIT_CantidadSolicitada = 0
            pQCNPEN_CantidadPendiente = 0
            pTLUGEN_LugarDeEntrega = ""
            pQPEPQT_Peso = 0
            pFUNCTL_FlagControlDeLotes = ""
            pUNSPSC_CodUn = ""
            pCPRVCL_IdProveedor = 0
            pTPRVCL_DescProveedor = ""
            pFlagControlUbicacion = ""
            pFlagControlSerie = ""
            pCantOS_X_SKU = 0
        End Sub
#End Region
    End Class
End Namespace