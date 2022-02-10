Imports System.Runtime.InteropServices

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Qry_LstOrdenServPorMercaderia_F01
#Region " Atributos "
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pCMRCLR_Mercaderia As String = ""
    Public pCTPDPS_TipoDeposito As String = ""
    Public pNTRMNL_NombreTerminal As String = ""
    Public pUsuario As String = ""
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCLNT_CodigoCliente = 0
        pCMRCLR_Mercaderia = ""
        pCTPDPS_TipoDeposito = ""
        pNTRMNL_NombreTerminal = ""
        pUsuario = ""
    End Sub
#End Region
End Class

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Qry_LstSolicOrdenServ_F01
#Region " Atributos "
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pCMRCLR_Mercaderia As String = ""
    Public pCTPDPS_TipoDeposito As String = ""
    Public pNORDSR_OrdenServicio As Int64 = 0
    Public pNTRMNL_NombreTerminal As String = ""
    Public pUsuario As String = ""
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCLNT_CodigoCliente = 0
        pCMRCLR_Mercaderia = ""
        pCTPDPS_TipoDeposito = ""
        pNORDSR_OrdenServicio = 0
        pNTRMNL_NombreTerminal = ""
        pUsuario = ""
    End Sub
#End Region
End Class

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Inf_DeleteOrdenServicio_F01
#Region " Atributos "
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pNORDSR_OrdenServicio As Int64 = 0
    Public pNSLCSR_NroSolicitud As Int32 = 0
    Public pCTPDPS_TipoDeposito As String = ""
    Public pNroDiasLimite As Integer = 0
    Public pNTRMNL_NombreTerminal As String = ""
    Public pUsuario As String = ""
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCLNT_CodigoCliente = 0
        pNORDSR_OrdenServicio = 0
        pNSLCSR_NroSolicitud = 0
        pCTPDPS_TipoDeposito = ""
        pNroDiasLimite = 0
        pNTRMNL_NombreTerminal = ""
        pUsuario = ""
    End Sub
#End Region
End Class

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Inf_LstOrdenServPorMercaderia_F01
#Region " Atributos "
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pNORDSR_OrdenServicio As Int64 = 0
    Public pCMRCLR_Mercaderia As String = ""
    Public pCTPDPS_TipoDeposito As String = ""
    Public pQMRCD1_CantidadDeclarada As Decimal = 0.0
    Public pQPSMR1_PesoDeclarado As Decimal = 0.0
    Public pQVLMR1_ValorDeclarado As Decimal = 0.0
    Public pFUNDS2_UnidadDespacho As String = ""
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCLNT_CodigoCliente = 0
        pNORDSR_OrdenServicio = 0
        pCMRCLR_Mercaderia = ""
        pCTPDPS_TipoDeposito = ""
        pQMRCD1_CantidadDeclarada = 0.0
        pQPSMR1_PesoDeclarado = 0.0
        pQVLMR1_ValorDeclarado = 0.0
        pFUNDS2_UnidadDespacho = ""
    End Sub
#End Region
End Class

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Inf_LstSolicOrdenServPorMercaderia_F01
#Region " Atributos "
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pCMRCLR_Mercaderia As String = ""
    Public pCTPDPS_TipoDeposito As String = ""
    Public pNORDSR_OrdenServicio As Int64 = 0
    Public pNSLCSR_NroSolicitud As Int32 = 0
    Public pFRLZSR_FechaSolcitud As DateTime
    Public pCMRCD_CodigoRansa As String = ""
    Public pCTPALM_TipoAlmacen As String = ""
    Public pCALMC_Almacen As String = ""
    Public pQTRMC_Cantidad As Decimal = 0.0
    Public pCUNCN5_Unidad As String = ""
    Public pQTRMP_Peso As Decimal = 0.0
    Public pCUNPS5_Unidad As String = ""
    Public pNGUIRN_NroGuiaRansa As Int64 = 0
    Public pNGUICL_NroGuiaCliente As String = ""
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCLNT_CodigoCliente = 0
        pCMRCLR_Mercaderia = ""
        pCTPDPS_TipoDeposito = ""
        pNORDSR_OrdenServicio = 0
        pNSLCSR_NroSolicitud = 0
        pFRLZSR_FechaSolcitud = Nothing
        pCMRCD_CodigoRansa = ""
        pCTPALM_TipoAlmacen = ""
        pCALMC_Almacen = ""
        pQTRMC_Cantidad = 0.0
        pCUNCN5_Unidad = ""
        pQTRMP_Peso = 0.0
        pCUNPS5_Unidad = ""
        pNGUIRN_NroGuiaRansa = 0
        pNGUICL_NroGuiaCliente = ""
    End Sub
#End Region
End Class