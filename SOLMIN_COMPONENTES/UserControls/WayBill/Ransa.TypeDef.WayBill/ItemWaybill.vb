Imports System.Runtime.InteropServices

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Obj_ItemBulto
#Region "Atributos"
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pCREFFW_CodigoBulto As String = ""
    Public pNORCML_NroOrdenCompra As String = ""
    Public pNRITOC_NroItemOC As Int32 = 0
    Public pNFACPR_NroFacturaProveedor As String = ""
    Public pFFACPR_FechaFacturaProveedor As Date
    Public pNGRPRV_NroGuiaRemisionProveedor As String = ""
    Public pQBLTSR_CantidadRecibida As Decimal = 0.0
    Public pQPEPQT_PesoCantRecibida As Decimal = 0.0

    Public pTUNPSO_UnidadPeso As String = ""

    Public pCCMPN_CodigoCompania As String = ""
    Public pCDVSN_CodigoDivision As String = ""
    Public pCPLNDV_CodigoPlanta As Double = 0

    Public pQVOPQT_VolumenCantRecibida As Decimal = 0.0
    Public pTUNVOL_UnidadVolumen As String = ""
    Public pCIDPAQ_CodItentificadorPaquetes As String = ""
    Public pMARRET_MarcaRetencion As String = ""
    Public pCULUSA_UsuarioActualizador As String
    '-- Adicionales 
    Public pTDAITM_Observaciones As String = ""
    Public pESTADO_estado As String = ""
    Public PNSEQIN_NrCorrelativo As Decimal = 0


    'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-INICIO
    Public pCMATPE_CboCondicionGrilla As String = ""
    Public pFGIQBF_CheckGrilla As String = ""
    Public pCCLMAT_CboValorGrilla As String = ""
    Public pCPRFUN_DesUnGrilla As String = ""
    Public pCUNMAT_CodUnGrilla As String = ""
    Public pFCHCAD_FechaGrilla As Decimal = 0
    'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-FIN.

#End Region
#Region "Propiedades"


    Public ReadOnly Property pFFACPR_FechaFacturaProveedor_FFec() As String
        Get
            Dim strResultado As String = ""
            If pFFACPR_FechaFacturaProveedor.Year > 1 Then _
                strResultado = pFFACPR_FechaFacturaProveedor.ToString("dd/MM/yyyy")
            Return strResultado
        End Get
    End Property

    Public ReadOnly Property pFFACPR_FechaFacturaProveedor_FNum() As String
        Get
            Dim strResultado As String = ""
            If pFFACPR_FechaFacturaProveedor.Year > 1 Then _
                strResultado = pFFACPR_FechaFacturaProveedor.ToString("yyyyMMdd")
            Return strResultado
        End Get
    End Property

    Public ReadOnly Property pFFACPR_FechaFacturaProveedor_Num() As Integer
        Get
            Dim intResultado As Integer = 0
            If pFFACPR_FechaFacturaProveedor.Year > 1 Then _
                Integer.TryParse(pFFACPR_FechaFacturaProveedor.ToString("yyyyMMdd"), intResultado)
            Return intResultado
        End Get
    End Property
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCLNT_CodigoCliente = 0
        pCREFFW_CodigoBulto = ""
        pNORCML_NroOrdenCompra = ""
        pNRITOC_NroItemOC = 0
        pNFACPR_NroFacturaProveedor = ""
        pFFACPR_FechaFacturaProveedor = New Date
        pNGRPRV_NroGuiaRemisionProveedor = ""
        pQBLTSR_CantidadRecibida = 0.0
        pQPEPQT_PesoCantRecibida = 0.0
        pTUNPSO_UnidadPeso = ""
        pQVOPQT_VolumenCantRecibida = 0.0
        pTUNVOL_UnidadVolumen = ""
        pTDAITM_Observaciones = ""
        pESTADO_estado = ""

    End Sub
#End Region
End Class