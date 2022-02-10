Imports System.Runtime.InteropServices

Namespace SubItemOC
    <StructLayout(LayoutKind.Sequential)> _
    Public Class TD_SubItemOCPK
        Public pCCLNT_CodigoCliente As Int64 = 0
        Public pNORCML_NroOrdenCompra As String = ""
        Public pNRITOC_NroItemOC As Int32 = 0
        Public pCREFFW_FrdForw As String = ""
        Public pSBITOC_NroSubItemOC As String = ""
        Public pCIDPAQ_CodIndentificacionPaquete As String = ""
        Public pQCNREC_QtaRecibida As Decimal = 0
        Public pCCMPN_Compania As String = ""
        Public pCDVSN_Division As String = ""
        Public pCPLNDV_Planta As Decimal = 0
    End Class

    <StructLayout(LayoutKind.Sequential)> _
    Public Class TD_SubItemOC
        Public pCCMPN_Compania As String = ""
        Public pCDVSN_Division As String = ""
        Public pCPLNDV_Planta As Decimal = 0
        Public pCCLNT_CodigoCliente As Int64 = 0
        Public pNORCML_NroOrdenCompra As String = ""
        Public pNRITOC_NroItemOC As Int32 = 0
        Public pSBITOC_NroSubItemOC As String = ""
        Public pTCITCL_CodigoCliente As String = ""
        Public pTCITPR_CodigoProveedor As String = ""
        Public pTDITES_DescripcionES As String = ""
        Public pCPTDAR_PartidaArancelaria As String = ""
        Public pCODTPN_TratoPreferencial As String = ""
        Public pQCNTIT_Cantidad As Decimal = 0
        Public pTUNDIT_Unidad As String = ""
        Public pIVUNIT_ImporteUnitario As Decimal = 0
        Public pIVTOIT_ImporteTotal As Decimal = 0
        Public pCREFFW_FrdForw As String = ""
        Public pCIDPAQ_CodIndentificacionPaquete As String = ""
        Public pQCNRP_CantidaItemRecepcionado As Int64 = 0
        Public pQCNPEN_CantidadPendiente As Int64 = 0
        Public pQTOLMAX_CantidadToleranciaMaxima As Int64 = 0
        Public pQTOLMIN_CantidadTolenciaMinima As Int64 = 0
        Public pTDAITM_Observacion As String = ""
        Public pQPEPQT_Peso As Decimal = 0
        Public pQVOPQT_Volumen As Decimal = 0
        Public pCHK As Boolean = False
        Public pQCNREC_QtaRecibida As Decimal = 0
        Public pTDAITM_Observaciones As String = ""
        Public pQPEPQT_QtaPeso As Decimal = 0
        Public pTUNPSO_UnidadPeso As String = ""
        Public pQVOPQT_QtaVolumen As Decimal = 0
        Public pTUNVOL_UnidadVolumen As String = ""



    End Class

End Namespace

