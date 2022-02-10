Imports System.Runtime.InteropServices

''' <summary>
''' Primary Key Tabla RZST18 - Acoplados por Transportista
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_AcopladoTransportistaPK
#Region " Atributos "
    Public pCCMPN_Compania As String = ""
    Public pCDVSN_Division As String = ""
    Public pCPLNDV_Planta As Int32 = 0
    Public pNRUCTR_RucTransportista As String = ""
    Public pNPLCAC_NroAcoplado As String = ""
    Public pUsuario As String = ""
#End Region
#Region " Métodos "
    Sub New()
        pCCMPN_Compania = ""
        pCDVSN_Division = ""
        pCPLNDV_Planta = 0
        pNRUCTR_RucTransportista = ""
        pNRUCTR_RucTransportista = ""
        pNPLCAC_NroAcoplado = ""
        pUsuario = ""
    End Sub

    Sub New(ByVal Compania As String, ByVal Division As String, ByVal Planta As Int32, ByVal Transportista As String, ByVal NroAcoplado As String, ByVal Usuario As String)
        pCCMPN_Compania = Compania
        pCDVSN_Division = Division
        pCPLNDV_Planta = Planta
        pNRUCTR_RucTransportista = Transportista
        pNPLCAC_NroAcoplado = NroAcoplado
        pUsuario = Usuario
    End Sub

    Public Sub pClear()
        pNPLCAC_NroAcoplado = ""
        pUsuario = ""
    End Sub

    Public Sub pClearAll()
        pCCMPN_Compania = ""
        pCDVSN_Division = ""
        pCPLNDV_Planta = 0
        pNRUCTR_RucTransportista = ""
        Call MyClass.pClear()
    End Sub
#End Region
End Class

''' <summary>
''' Información completa del Acoplado por Transportista
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Obj_AcopladoTransportista
#Region " Atributos "
    Public pCCMPN_Compania As String = ""
    Public pCDVSN_Division As String = ""
    Public pCPLNDV_Planta As Int32 = 0
    Public pNRUCTR_RucTransportista As String = ""
    Public pNPLCAC_NroAcoplado As String = ""
    Public pFECINI_FechaInicio As Date
    Public pFECFIN_FechaFinal As Date
    Public pTOBS_Observaciones As String = ""
    Public pSESTAC_StatusCamion As String = ""
    Public pSESTRG_StatusRegistro As String = ""
    Public pTMRCVH_Marca As String = ""
    Public pTDEACP_DetTipoAcoplado As String = ""
#End Region
#Region " Métodos "
    Public Sub pClear()
        pNPLCAC_NroAcoplado = ""
        pFECINI_FechaInicio = New Date
        pFECFIN_FechaFinal = New Date
        pTOBS_Observaciones = ""
        pSESTAC_StatusCamion = ""
        pSESTRG_StatusRegistro = ""
        pTMRCVH_Marca = ""
        pTDEACP_DetTipoAcoplado = ""
    End Sub

    Public Sub pClearAll()
        pCCMPN_Compania = ""
        pCDVSN_Division = ""
        pCPLNDV_Planta = 0
        pNRUCTR_RucTransportista = ""
        Call MyClass.pClear()
    End Sub
#End Region
End Class

''' <summary>
''' Información Básica del Acoplado por Transportista
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Inf_AcopladoTransportista_L01
#Region " Atributos "
    Public pCCMPN_Compania As String = ""
    Public pCDVSN_Division As String = ""
    Public pCPLNDV_Planta As Int32 = 0
    Public pNRUCTR_RucTransportista As String = ""
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
        pCDVSN_Division = ""
        pCPLNDV_Planta = 0
        pNRUCTR_RucTransportista = ""
        Call MyClass.pClear()
    End Sub
#End Region
End Class

''' <summary>
''' Filtro para el Listado de Acoplados por Transportista para ser utilizadas en un DataGrid con opciones de Paginación
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Qry_AcopladoTransportista_L01
#Region " Atributos "
    Public pCCMPN_Compania As String = ""
    Public pCDVSN_Division As String = ""
    Public pCPLNDV_Planta As Int32 = 0
    Public pNRUCTR_RucTransportista As String = ""
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
        pCDVSN_Division = ""
        pCPLNDV_Planta = 0
        pNRUCTR_RucTransportista = ""
        Call MyClass.pClear()
    End Sub
#End Region
End Class