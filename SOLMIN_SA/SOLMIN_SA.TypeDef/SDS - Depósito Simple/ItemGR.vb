Imports System.Runtime.InteropServices

Namespace ItemGR
    <StructLayout(LayoutKind.Sequential)> _
    Public Class TD_ItemGRPK

        Public _PSCCMPN As String = ""
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
        Public Class TD_ItemGR
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


        'Public PTRFRN_RefSolicitante As String = ""
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
        Public Class TD_ItemGRForWayBill
#Region " Atributos "
        Public _NGUIRM As Int32 = 0
        Public _CCLNT As Int32 = 0
        Public _NORCML As String = ""
        Public _NRITOC As Int32 = 0
        Public _CREEFW As String = ""
        Public _CIDPAD As Decimal = 0D
        Public _DESCWB As String = ""
        Public _QCNGU As Int32 = 0
        Public _QPSOBL As Decimal = 0
        Public _TUNPSO As String = ""
        Public _QVLBTO As Decimal = 0
        Public _QCNPEN As String = ""
        Public _CMRCD As String = ""
        Public _NORDSR As String = ""
        Public _FUNCTL As String = ""
        Public _CUNCN5 As String = ""
        Public _CUNPS5 As String = ""
        Public _CUNVL5 As String = ""
        Public _NCNTR As String = ""
        Public _NCRCTC As String = ""
        Public _NAUTR As String = ""
        Public _FUNDS2 As String = ""
        Public _QCNREC As Int32 = 0
        Public _CTPDPS As String = ""
        Public _FCHCRT As String = ""
        Public _CMRCLR As String = ""
#End Region
#Region " Métodos "
        Public Sub pClear()
            _NORCML = 0
            _CREEFW = ""
            _CIDPAD = 0D
            _DESCWB = ""
            _QCNGU = 0
            _QPSOBL = 0
            _TUNPSO = ""
            _QVLBTO = 0
            _QCNPEN = ""
            _CMRCD = ""
            _NORDSR = ""
        
        End Sub
#End Region
        End Class
End Namespace