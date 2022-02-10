Imports System.Runtime.InteropServices

Namespace OrdenCompra
    <StructLayout(LayoutKind.Sequential)> _
    Public Class TD_Qry_SegOC_L01
        Public pCCLNT_CodigoCliente As Int64 = 0
        Public pNORCML_NroOrdenCompra As String = ""
        Public pCPRVCL_Proveedor As Int32 = 0
        Public pTTINTC_TermInterCarga As String = ""
        Public pFORCMI_FechaOCInicial As Date
        Public pFORCMF_FechaOCFinal As Date
        Public pFMPDMI_FechaCompInicial As Date
        Public pFMPDMF_FechaCompFinal As Date
        Public pSTATOC_StatusOC As String = ""

        Public pCCMPN_Compania As String = ""
        Public pCDVSN_Division As String = ""
        Public pCPLNDV_Planta As Decimal = 0

        Public ReadOnly Property pFORCMI_FechaOCInicial_Int() As Int32
            Get
                Dim intTemp As Int32 = 0
                If pFORCMI_FechaOCInicial.Year > 1 Then Int32.TryParse(pFORCMI_FechaOCInicial.ToString("yyyyMMdd"), intTemp)
                Return intTemp
            End Get
        End Property

        Public ReadOnly Property pFORCMF_FechaOCFinal_Int() As Int32
            Get
                Dim intTemp As Int32 = 0
                If pFORCMF_FechaOCFinal.Year > 1 Then Int32.TryParse(pFORCMF_FechaOCFinal.ToString("yyyyMMdd"), intTemp)
                Return intTemp
            End Get
        End Property

        Public ReadOnly Property pFMPDMI_FechaCompInicial_Int() As Int32
            Get
                Dim intTemp As Int32 = 0
                If pFMPDMI_FechaCompInicial.Year > 1 Then Int32.TryParse(pFMPDMI_FechaCompInicial.ToString("yyyyMMdd"), intTemp)
                Return intTemp
            End Get
        End Property

        Public ReadOnly Property pFMPDMF_FechaCompFinal_Int() As Int32
            Get
                Dim intTemp As Int32 = 0
                If pFMPDMF_FechaCompFinal.Year > 1 Then Int32.TryParse(pFMPDMF_FechaCompFinal.ToString("yyyyMMdd"), intTemp)
                Return intTemp
            End Get
        End Property
    End Class

    <StructLayout(LayoutKind.Sequential)> _
    Public Class TD_Qry_MovProValor_L01
        Public pCCLNT_CodigoCliente As Int64 = 0
        Public pFECINI_FechaInicial_Dte As Date
        Public pFECFIN_FechaFinal_Dte As Date
        Public pUsuario As String = ""

        Public ReadOnly Property pFECINI_FechaInicial_Int() As Int32
            Get
                Dim intTemp As Int32 = 0
                If pFECINI_FechaInicial_Dte.Year > 1 Then Int32.TryParse(pFECINI_FechaInicial_Dte.ToString("yyyyMMdd"), intTemp)
                Return intTemp
            End Get
        End Property

        Public ReadOnly Property pFECFIN_FechaFinal_Int() As Int32
            Get
                Dim intTemp As Int32 = 0
                If pFECFIN_FechaFinal_Dte.Year > 1 Then Int32.TryParse(pFECFIN_FechaFinal_Dte.ToString("yyyyMMdd"), intTemp)
                Return intTemp
            End Get
        End Property
    End Class
End Namespace
