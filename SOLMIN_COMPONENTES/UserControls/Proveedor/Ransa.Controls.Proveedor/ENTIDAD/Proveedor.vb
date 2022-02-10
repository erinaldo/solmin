Imports System.Runtime.InteropServices

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Obj_Proveedor_F01
#Region " Atributos "
    Public pCPRVCL_Proveedor As Int32 = 0
    Public pTPRVCL_DescripcionProveedor As String = ""
    Public pTPRCL1_DescripcionAdicional As String = ""
    Public pNRUCPR_NroRUC As Int64 = 0
    Public pTNACPR_ProvinciaDistrito As String = ""
    Public pTDRPRC_DireccionProveedor As String = ""
    Public pCPAIS_Pais As Int32 = 0
    Public pTNROFX_NroFAX As String = ""
    Public pTLFNO1_TelefonoProveedor As String = ""
    Public pTEMAI2_EmailProveedor As String = ""
    Public pTPRSCN_ContactoProveedor As String = ""
    Public pTLFNO2_TelefonoContacto As String = ""
    Public pTEMAI3_EmailContacto As String = ""
    Public pNDSDMP_NroDiasDemoraPago As Int32 = 0
    Public pSESTRG_Situacion As String = ""
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCPRVCL_Proveedor = 0
        pTPRVCL_DescripcionProveedor = ""
        pTPRCL1_DescripcionAdicional = ""
        pNRUCPR_NroRUC = 0
        pTNACPR_ProvinciaDistrito = ""
        pTDRPRC_DireccionProveedor = ""
        pCPAIS_Pais = 0
        pTNROFX_NroFAX = ""
        pTLFNO1_TelefonoProveedor = ""
        pTEMAI2_EmailProveedor = ""
        pTPRSCN_ContactoProveedor = ""
        pTLFNO2_TelefonoContacto = ""
        pTEMAI3_EmailContacto = ""
        pNDSDMP_NroDiasDemoraPago = 0
        pSESTRG_Situacion = ""
    End Sub
#End Region
End Class

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Qry_LstProveedor_F02
#Region " Atributos "
    Public pCPRVCL_Proveedor As Int64 = 0
    Public pTPRVCL_DescripcionProveedor As String = ""
    Public pNRUCPR_NroRUC As Int64 = 0
    Public pNRUCPR_NroRUC_STR As String = ""
    Public pCPRVCL_Proveedor_STR As String = ""
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCPRVCL_Proveedor = 0
        pTPRVCL_DescripcionProveedor = ""
        pNRUCPR_NroRUC = 0
        pCPRVCL_Proveedor_STR = ""
        pNRUCPR_NroRUC_STR = ""
    End Sub
#End Region
End Class

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Inf_LstProveedor_F02
#Region " Atributos "
    Public pCPRVCL_Proveedor As Int64 = 0
    Public pTPRVCL_DescripcionProveedor As String = ""
    Public pNRUCPR_NroRUC As Int64 = 0
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCPRVCL_Proveedor = 0
        pTPRVCL_DescripcionProveedor = ""
        pNRUCPR_NroRUC = 0
    End Sub
#End Region
End Class

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Inf_Proveedor_F01
#Region " Atributos "
    Public pCPRVCL_Proveedor As Int32 = 0
    Public pTPRVCL_DescripcionProveedor As String = ""
    Public pTPRCL1_DescripcionAdicional As String = ""
    Public pNRUCPR_NroRUC As Int64 = 0
    Public pTNACPR_ProvinciaDistrito As String = ""
    Public pTDRPRC_DireccionProveedor As String = ""
    Public pCPAIS_Pais As Int32 = 0
    Public pTNROFX_NroFAX As String = ""
    Public pTLFNO1_TelefonoProveedor As String = ""
    Public pTEMAI2_EmailProveedor As String = ""
    Public pTPRSCN_ContactoProveedor As String = ""
    Public pTLFNO2_TelefonoContacto As String = ""
    Public pTEMAI3_EmailContacto As String = ""
    Public pNDSDMP_NroDiasDemoraPago As Int32 = 0
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCPRVCL_Proveedor = 0
        pTPRVCL_DescripcionProveedor = ""
        pTPRCL1_DescripcionAdicional = ""
        pNRUCPR_NroRUC = 0
        pTNACPR_ProvinciaDistrito = ""
        pTDRPRC_DireccionProveedor = ""
        pCPAIS_Pais = 0
        pTNROFX_NroFAX = ""
        pTLFNO1_TelefonoProveedor = ""
        pTEMAI2_EmailProveedor = ""
        pTPRSCN_ContactoProveedor = ""
        pTLFNO2_TelefonoContacto = ""
        pTEMAI3_EmailContacto = ""
        pNDSDMP_NroDiasDemoraPago = 0
    End Sub
#End Region
End Class









<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Proveedor
#Region " Atributos "
    Public pCPRVCL_Proveedor As Int32 = 0
    Public pTPRVCL_DescripcionProveedor As String = ""
    Public pTPRCL1_DescripcionAdicional As String = ""
    Public pNRUCPR_NroRUC As Int64 = 0
    Public pTNACPR_ProvinciaDistrito As String = ""
    Public pTDRPRC_DireccionProveedor As String = ""
    Public pCPAIS_Pais As Int32 = 0
    Public pTNROFX_NroFAX As String = ""
    Public pTLFNO1_TelefonoProveedor As String = ""
    Public pTEMAI2_EmailProveedor As String = ""
    Public pTPRSCN_ContactoProveedor As String = ""
    Public pTLFNO2_TelefonoContacto As String = ""
    Public pTEMAI3_EmailContacto As String = ""
    Public pNDSDMP_NroDiasDemoraPago As Int32 = 0
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCPRVCL_Proveedor = 0
        pTPRVCL_DescripcionProveedor = ""
        pTPRCL1_DescripcionAdicional = ""
        pNRUCPR_NroRUC = 0
        pTNACPR_ProvinciaDistrito = ""
        pTDRPRC_DireccionProveedor = ""
        pCPAIS_Pais = 0
        pTNROFX_NroFAX = ""
        pTLFNO1_TelefonoProveedor = ""
        pTEMAI2_EmailProveedor = ""
        pTPRSCN_ContactoProveedor = ""
        pTLFNO2_TelefonoContacto = ""
        pTEMAI3_EmailContacto = ""
        pNDSDMP_NroDiasDemoraPago = 0
    End Sub
#End Region
End Class

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_ProveedorPK
    Public pCPRVCL_Proveedor As Int32 = 0
End Class

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_ProveedorL01
#Region " Atributos "
    Public pCPRVCL_Proveedor As String = ""
    Public pTPRVCL_DescripcionProveedor As String = ""
    Public pNRUCPR_NroRUC As String = ""
    Public pNROPAG_NroPagina As Int32 = 0
    Public pREGPAG_NroRegPorPagina As Int32 = 0
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCPRVCL_Proveedor = ""
        pTPRVCL_DescripcionProveedor = ""
        pNRUCPR_NroRUC = ""
        pNROPAG_NroPagina = 0
        pREGPAG_NroRegPorPagina = 0
    End Sub
#End Region
End Class

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_InfBas_Proveedor
#Region " Atributos "
    Public pCPRVCL_Proveedor As Int32 = 0
    Public pTPRVCL_DescripcionProveedor As String = ""
    Public pNRUCPR_NroRUC As Int64 = 0
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCPRVCL_Proveedor = 0
        pTPRVCL_DescripcionProveedor = ""
        pNRUCPR_NroRUC = 0
    End Sub
#End Region
End Class

