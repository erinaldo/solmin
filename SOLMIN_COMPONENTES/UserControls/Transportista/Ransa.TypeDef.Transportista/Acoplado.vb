Imports System.Runtime.InteropServices

''' <summary>
''' Primary Key Tabla RZST05 - Acoplados
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_AcopladoPK
#Region " Atributos "
    Public pCCMPN_Compania As String = ""
    Public pNPLCAC_NroAcoplado As String = ""
    Public pUsuario As String = ""
#End Region
#Region " Métodos "
    Sub New()
        pCCMPN_Compania = ""
        pNPLCAC_NroAcoplado = ""
        pUsuario = ""
    End Sub

    Sub New(ByVal Compania As String, ByVal NroAcoplado As String, ByVal Usuario As String)
        pCCMPN_Compania = Compania
        pNPLCAC_NroAcoplado = NroAcoplado
        pUsuario = Usuario
    End Sub

    Public Sub pClear()
        pNPLCAC_NroAcoplado = ""
        pUsuario = ""
    End Sub

    Public Sub pClearAll()
        pCCMPN_Compania = ""
        Call MyClass.pClear()
    End Sub
#End Region
End Class

''' <summary>
''' Información completa del Acoplado
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Obj_Acoplado
#Region " Atributos "
    Public pCCMPN_Compania As String = ""
    Public pNPLCAC_NroAcoplado As String = ""
    Public pTCLRUN_Color As String = ""
    Public pQPSTRA_PesoTara As Int32 = 0
    Public pNEJSUN_NroEjes As Int32 = 0
    Public pNCPCRU_CapacidadCarga As Int32 = 0
    Public pNSRCHU_NroChasis As String = ""
    Public pQLNGAC_Longitud As Decimal = 0
    Public pQANCAC_Ancho As Decimal = 0
    Public pQALTAC_Alto As Decimal = 0
    Public pCTIACP_TipoAcoplado As Int32 = 0
    Public pTDEACP_DetTipoAcoplado As String = ""
    Public pSESTRG_StatusRegistro As String = ""
    Public pNRGMT2_NroMTC As String = ""
    Public pTCNFG2_ConfigEjeAcoplado As String = ""
    Public pTMRCVH_Marca As String = ""
#End Region
#Region " Métodos "
    Public Sub pClear()
        pNPLCAC_NroAcoplado = ""
        pTCLRUN_Color = ""
        pQPSTRA_PesoTara = 0
        pNEJSUN_NroEjes = 0
        pNCPCRU_CapacidadCarga = 0
        pNSRCHU_NroChasis = ""
        pQLNGAC_Longitud = 0
        pQANCAC_Ancho = 0
        pQALTAC_Alto = 0
        pCTIACP_TipoAcoplado = 0
        pTDEACP_DetTipoAcoplado = ""
        pSESTRG_StatusRegistro = ""
        pNRGMT2_NroMTC = ""
        pTCNFG2_ConfigEjeAcoplado = ""
        pTMRCVH_Marca = ""
    End Sub

    Public Sub pClearAll()
        pCCMPN_Compania = ""
        Call MyClass.pClear()
    End Sub
#End Region
End Class

''' <summary>
''' Información Básica del Acoplado
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Inf_Acoplado_L01
#Region " Atributos "
    Public pCCMPN_Compania As String = ""
    Public pNPLCAC_NroAcoplado As String = ""
    Public pTMRCVH_Marca As String = ""
    Public pTDEACP_DetTipoAcoplado As String = ""
#End Region
#Region " Métodos "
    Public Sub pClear()
        pNPLCAC_NroAcoplado = ""
        pTMRCVH_Marca = ""
        pTDEACP_DetTipoAcoplado = ""
    End Sub

    Public Sub pClearAll()
        pCCMPN_Compania = ""
        Call MyClass.pClear()
    End Sub
#End Region
End Class

''' <summary>
''' Filtro para el Listado de Acoplados para ser utilizadas en un DataGrid con opciones de Paginación
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Qry_Acoplado_L01
#Region " Atributos "
    Public pCCMPN_Compania As String = ""
    Public pNPLCAC_NroAcoplado As String = ""
    Public pTMRCVH_Marca As String = ""
    Public pTDEACP_DetTipoAcoplado As String = ""
    Public pUsuario As String = ""
    Public pNROPAG_NroPagina As Int32 = 0
    Public pREGPAG_NroRegPorPagina As Int32 = 0
#End Region
#Region " Métodos "
    Public Sub pClear()
        pNPLCAC_NroAcoplado = ""
        pTMRCVH_Marca = ""
        pTDEACP_DetTipoAcoplado = ""
        pUsuario = ""
        pNROPAG_NroPagina = 0
        pREGPAG_NroRegPorPagina = 0
    End Sub

    Public Sub pClearAll()
        pCCMPN_Compania = ""
        Call MyClass.pClear()
    End Sub
#End Region
End Class