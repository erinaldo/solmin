Imports System.Runtime.InteropServices

''' <summary>
''' Primary Key Tabla RZST17 - Tractos por Transportista
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_TractoTransportistaPK
#Region " Atributos "
    Public pCCMPN_Compania As String = ""
    Public pCDVSN_Division As String = ""
    Public pCPLNDV_Planta As Int32 = 0
    Public pNRUCTR_RucTransportista As String = ""
    Public pNPLCUN_NroPlacaUnidad As String = ""
    Public pUsuario As String = ""

    Public psCPLNDV_Planta As String = "" 'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
#End Region
#Region " Métodos "
    Sub New()
        pCCMPN_Compania = ""
        pCDVSN_Division = ""
        pCPLNDV_Planta = 0
        pNRUCTR_RucTransportista = ""
        pNPLCUN_NroPlacaUnidad = ""
        pUsuario = ""
    End Sub

    Sub New(ByVal Compania As String, ByVal Division As String, ByVal Planta As Integer, ByVal Transportista As String, ByVal NroPlacaUnidad As String, ByVal Usuario As String)
        pCCMPN_Compania = Compania
        pCDVSN_Division = Division
        pCPLNDV_Planta = Planta
        pNRUCTR_RucTransportista = Transportista
        pNPLCUN_NroPlacaUnidad = NroPlacaUnidad
        pUsuario = Usuario
    End Sub

    Public Sub pClear()
        pNPLCUN_NroPlacaUnidad = ""
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
''' Información completa del Tracto de la Unidad asociada al Transportista
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Obj_TractoTransportista
#Region " Atributos "
    Public pNRUCTR_RucTransportista As String = ""
    Public pNPLCUN_NroPlacaUnidad As String = ""
    Public pCCMPN_Compania As String = ""
    Public pCDVSN_Division As String = ""
    Public pCPLNDV_Planta As Int32 = 0
    Public pTMRCTR_Marca_Modelo As String = ""
    Public pNRGMT1_NroMTC As String = ""
    Public pFECINI_FechaInicio As Date
    Public pFECFIN_FechaFinal As Date
    Public pNPLACP_NroAcoplado As String = ""
    Public pCBRCND_Brevete As String = ""
    Public pCTPCRA_TipoAcoplado As Int32 = 0
    Public pCCLNT_Cliente As Int64 = 0
    Public pTOBS_Observaciones As String = ""
    Public pSESTCM_StatusCamion As String = ""
    Public pSESTRG_StatusRegistro As String = ""
#End Region
#Region " Métodos "
    Public Sub pClear()
        pNPLCUN_NroPlacaUnidad = ""
        pTMRCTR_Marca_Modelo = ""
        pNRGMT1_NroMTC = ""
        pFECINI_FechaInicio = New Date
        pFECFIN_FechaFinal = New Date
        pNPLACP_NroAcoplado = ""
        pCBRCND_Brevete = ""
        pCTPCRA_TipoAcoplado = 0
        pCCLNT_Cliente = 0
        pTOBS_Observaciones = ""
        pSESTCM_StatusCamion = ""
        pSESTRG_StatusRegistro = ""
    End Sub

    Public Sub pClearAll()
        pNRUCTR_RucTransportista = ""
        pCCMPN_Compania = ""
        pCDVSN_Division = ""
        pCPLNDV_Planta = 0
        Call MyClass.pClear()
    End Sub
#End Region
End Class

''' <summary>
''' Información Básica del Tracto asociada al Transportista
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Inf_TractoTransportista_L01
#Region " Atributos "
    Public pNRUCTR_RucTransportista As String = ""
    Public pNPLCUN_NroPlacaUnidad As String = ""
    Public pCCMPN_Compania As String = ""
    Public pCDVSN_Division As String = ""
    Public pCPLNDV_Planta As Int32 = 0
    Public pTMRCTR_Marca_Modelo As String = ""
    Public pNRGMT1_NroMTC As String = ""
    Public pNPLACP_NroAcoplado As String = ""
    Public pCBRCND_Brevete As String = ""
#End Region
#Region " Métodos "
    Public Sub pClear()
        pNPLCUN_NroPlacaUnidad = ""
        pTMRCTR_Marca_Modelo = ""
        pNRGMT1_NroMTC = ""
        pNPLACP_NroAcoplado = ""
        pCBRCND_Brevete = ""
    End Sub

    Public Sub pClearAll()
        pNRUCTR_RucTransportista = ""
        pCCMPN_Compania = ""
        pCDVSN_Division = ""
        pCPLNDV_Planta = 0
        Call MyClass.pClear()
    End Sub
#End Region
End Class

''' <summary>
''' Filtro para el Listado de Tractos asociados al Transportista para ser utilizadas en un DataGrid con opciones de Paginación
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Qry_TractoTransportista_L01
#Region " Atributos "
    Public pNRUCTR_RucTransportista As String = ""
    Public pNPLCUN_NroPlacaUnidad As String = ""
    Public pCCMPN_Compania As String = ""
    Public pCDVSN_Division As String = ""
    Public pCPLNDV_Planta As Int32 = 0
    Public pTMRCTR_Marca_Modelo As String = ""
    Public pNRGMT1_NroMTC As String = ""
    Public pUsuario As String = ""
    Public pNROPAG_NroPagina As Int32 = 0
    Public pREGPAG_NroRegPorPagina As Int32 = 0
#End Region
#Region " Métodos "
    Public Sub pClear()
        pNPLCUN_NroPlacaUnidad = ""
        pTMRCTR_Marca_Modelo = ""
        pNRGMT1_NroMTC = ""
        pUsuario = ""
        pNROPAG_NroPagina = 0
        pREGPAG_NroRegPorPagina = 0
    End Sub

    Public Sub pClearAll()
        pNRUCTR_RucTransportista = ""
        pCCMPN_Compania = ""
        pCDVSN_Division = ""
        pCPLNDV_Planta = 0
        Call MyClass.pClear()
    End Sub
#End Region
End Class