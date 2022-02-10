Imports System.Runtime.InteropServices

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_ControlOperacionPK01
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pFTRMOP_FechaCierre As Date
    Public pSTPODP_TipoAlmacen As String = ""
    Public pCTPOAT_TipoOperacion As String = ""

    Public ReadOnly Property pFTRMOP_FechaCierre_Int() As Int32
        Get
            Dim intTemp As Int32 = 0
            If pFTRMOP_FechaCierre.Year > 1 Then Int32.TryParse(pFTRMOP_FechaCierre.ToString("yyyyMMdd"), intTemp)
            Return intTemp
        End Get
    End Property
End Class

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_ControlOperacionPK02
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pSTPODP_TipoAlmacen As String = ""
    Public pCTPOAT_TipoOperacion As String = ""
    Public pNOPRSP_NroOperacion As Int64 = 0
End Class

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_ControlOperacion
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pFTRMOP_FechaCierre As Date
    Public pSTPODP_TipoAlmacen As String = ""
    Public pCTPOAT_TipoOperacion As String = ""
    Public pNOPRSP_NroOperacion As Int64 = 0
    Public pQTAMOV_TotalMovimiento As Decimal = 0
    Public pQQBLTO_TotalBultos As Decimal = 0
    Public pQQPESO_TotalPeso As Decimal = 0

    Public ReadOnly Property pFTRMOP_FechaCierre_Int() As Int32
        Get
            Dim intTemp As Int32 = 0
            If pFTRMOP_FechaCierre.Year > 1 Then Int32.TryParse(pFTRMOP_FechaCierre.ToString("yyyyMMdd"), intTemp)
            Return intTemp
        End Get
    End Property
End Class

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Qry_CtrlOperacion
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pFTRMOP_FechaCierre As Date
    Public pSTPODP_TipoAlmacen As String = ""
    Public pCTPOAT_TipoOperacion As String = ""

    Public ReadOnly Property pFTRMOP_FechaCierre_Int() As Int32
        Get
            Dim intTemp As Int32 = 0
            If pFTRMOP_FechaCierre.Year > 1 Then Int32.TryParse(pFTRMOP_FechaCierre.ToString("yyyyMMdd"), intTemp)
            Return intTemp
        End Get
    End Property
End Class