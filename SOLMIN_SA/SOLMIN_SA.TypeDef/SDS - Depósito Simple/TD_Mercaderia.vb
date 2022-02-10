Imports System.Runtime.InteropServices

Namespace Mercaderia
    <StructLayout(LayoutKind.Sequential)> _
    Public Class TD_Qry_StockProductosF01
        Public pCCLNT_CodigoCliente As Int64 = 0
        Public pTCMPCL_RazonSocial As String = ""
        Public pCTPDP6_TipoDeposito As String = ""
    End Class

    <StructLayout(LayoutKind.Sequential)> _
    Public Class TD_Qry_StockProductosPorUbicacionF01
        Public pCCLNT_CodigoCliente As Int64 = 0
        Public pTCMPCL_RazonSocial As String = ""
        Public pCTPDP6_TipoDeposito As String = ""
        Public pCTPALM_TipoAlmacen As String = ""
        Public pCALMC_Almacen As String = ""
        Public pCZNALM_ZonaAlmacen As String = ""
        Public pSTQRY_StatusValorizado As Int32 = 0
        Public pORDENACION As Int64 = 0
        Public psCCLNT_CodigoCliente As String = ""
    End Class

    <StructLayout(LayoutKind.Sequential)> _
    Public Class TD_FiltroRepMovProductos
        Public pCCLNT_CodigoCliente As Int64 = 0
        Public pTCMPCL_RazonSocial As String = ""
        Public pFMOVI_FechaInventarioDte As Date
        Public pFMOVF_FechaInventarioDte As Date
        Public pSTPODP_TipoDeposito As String = ""
        Public pSCMRCLR_CodigoMercaderia As String = ""
        Public pSTMRCD2_DetalleMercaderia As String = ""
        Public pSTQRY_StatusValorizado As Int32 = 0

        Public ReadOnly Property pFMOVI_FechaInventarioInt() As Int32
            Get
                Dim intTemp As Int32 = 0
                If pFMOVI_FechaInventarioDte.Year > 1 Then Int32.TryParse(pFMOVI_FechaInventarioDte.ToString("yyyyMMdd"), intTemp)
                Return intTemp
            End Get
        End Property

        Public ReadOnly Property pFMOVF_FechaInventarioInt() As Int32
            Get
                Dim intTemp As Int32 = 0
                If pFMOVF_FechaInventarioDte.Year > 1 Then Int32.TryParse(pFMOVF_FechaInventarioDte.ToString("yyyyMMdd"), intTemp)
                Return intTemp
            End Get
        End Property
    End Class

    <StructLayout(LayoutKind.Sequential)> _
    Public Class TD_FiltroRepMovProductosPorUbicacion
        Public pCCLNT_CodigoCliente As Int64 = 0
        Public pTCMPCL_RazonSocial As String = ""
        Public pFMOVI_FechaInventarioDte As Date
        Public pFMOVF_FechaInventarioDte As Date
        Public pSTPODP_TipoDeposito As String = ""
        Public pCTPALM_TipoAlmacen As String = ""
        Public pCALMC_Almacen As String = ""
        Public pCZNALM_ZonaAlmacen As String = ""
        Public pSTQRY_StatusValorizado As Int32 = 0

        Public ReadOnly Property pFMOVI_FechaInventarioInt() As Int32
            Get
                Dim intTemp As Int32 = 0
                If pFMOVI_FechaInventarioDte.Year > 1 Then Int32.TryParse(pFMOVI_FechaInventarioDte.ToString("yyyyMMdd"), intTemp)
                Return intTemp
            End Get
        End Property

        Public ReadOnly Property pFMOVF_FechaInventarioInt() As Int32
            Get
                Dim intTemp As Int32 = 0
                If pFMOVF_FechaInventarioDte.Year > 1 Then Int32.TryParse(pFMOVF_FechaInventarioDte.ToString("yyyyMMdd"), intTemp)
                Return intTemp
            End Get
        End Property
    End Class
End Namespace