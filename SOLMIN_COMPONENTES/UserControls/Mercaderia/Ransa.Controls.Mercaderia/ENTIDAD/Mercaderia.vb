Imports System.Runtime.InteropServices

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_MercaderiaPK
#Region " Atributos "
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pCMRCLR_Mercaderia As String = ""
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCLNT_CodigoCliente = 0
        pCMRCLR_Mercaderia = ""
    End Sub
#End Region
End Class

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Inf_Mercaderia_L01
#Region " Atributos "
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pCFMCLR_Familia As String = ""
    Public pCGRCLR_Grupo As String = ""
    Public pCMRCLR_Mercaderia As String = ""
    Public pCMRCD_CodigoRansa As String = ""
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCLNT_CodigoCliente = 0
        pCFMCLR_Familia = ""
        pCGRCLR_Grupo = ""
        pCMRCLR_Mercaderia = ""
        pCMRCD_CodigoRansa = ""
    End Sub
#End Region
End Class

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Qry_Mercaderia_L01
#Region " Atributos "
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pCFMCLR_Familia As String = ""
    Public pCGRCLR_Grupo As String = ""
    Public pCMRCLR_Mercaderia As String = ""
    Public pUsuario As String = ""

    Public pNROPAG_NroPagina As Int32 = 1
    Public pREGPAG_NroRegPorPagina As Int32 = 0
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCLNT_CodigoCliente = 0
        pCFMCLR_Familia = ""
        pCGRCLR_Grupo = ""
        pCMRCLR_Mercaderia = ""

        pNROPAG_NroPagina = 1
        pREGPAG_NroRegPorPagina = 0
    End Sub
#End Region
End Class