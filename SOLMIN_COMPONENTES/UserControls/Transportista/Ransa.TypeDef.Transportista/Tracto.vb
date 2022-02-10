Imports System.Runtime.InteropServices

''' <summary>
''' Primary Key Tabla RZST03 - Tractos
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_TractoPK
#Region " Atributos "
    Public pCCMPN_Compania As String = ""
    Public pNPLCUN_NroPlacaUnidad As String = ""
    Public pUsuario As String = ""
#End Region
#Region " Métodos "
    Sub New()
        pCCMPN_Compania = ""
        pNPLCUN_NroPlacaUnidad = ""
        pUsuario = ""
    End Sub

    Sub New(ByVal Compania As String, ByVal NroPlacaUnidad As String, ByVal Usuario As String)
        pCCMPN_Compania = Compania
        pNPLCUN_NroPlacaUnidad = NroPlacaUnidad
        pUsuario = Usuario
    End Sub

    Public Sub pClear()
        pNPLCUN_NroPlacaUnidad = ""
        pUsuario = ""
    End Sub

    Public Sub pClearAll()
        pCCMPN_Compania = ""
        Call MyClass.pClear()
    End Sub
#End Region
End Class

''' <summary>
''' Información completa del Tracto de la Unidad
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Obj_Tracto
#Region " Atributos "
    Public pCCMPN_Compania As String = ""
    Public pNPLCUN_NroPlacaUnidad As String = ""
    Public pNEJSUN As Int64 = 0
    Public pNSRCHU_NroChasis As String = ""
    Public pNSRMTU_NroSerieMotor As String = ""
    Public pFFBRUN_FechaFabricacion As Integer = 0
    Public pTCLRUN_Color As String = ""
    Public pTCRRUN_Carroceria As String = ""
    Public pNCPCRU_CapacidadTracto As Int32 = 0
    Public pCTITRA_TipoTracto As Int32 = 0
    Public pQPSOTR_PesoTracto As Int32 = 0
    Public pTMRCTR_Marca_Modelo As String = ""
    Public pNRGMT1_NroMTC As String = ""
    Public pNTERPM_NroTlfnRPM As String = ""
    Public pSESTRG_StatusRegistro As String = ""
#End Region
#Region " Métodos "
    Public Sub pClear()
        pNPLCUN_NroPlacaUnidad = ""
        pNEJSUN = 0
        pNSRCHU_NroChasis = ""
        pNSRMTU_NroSerieMotor = ""
        pFFBRUN_FechaFabricacion = 0
        pTCLRUN_Color = ""
        pTCRRUN_Carroceria = ""
        pNCPCRU_CapacidadTracto = 0
        pCTITRA_TipoTracto = 0
        pQPSOTR_PesoTracto = 0
        pTMRCTR_Marca_Modelo = ""
        pNRGMT1_NroMTC = ""
        pNTERPM_NroTlfnRPM = ""
        pSESTRG_StatusRegistro = ""
    End Sub

    Public Sub pClearAll()
        pCCMPN_Compania = ""
        Call MyClass.pClear()
    End Sub
#End Region
End Class

''' <summary>
''' Información Básica del Tracto
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Inf_Tracto_L01
#Region " Atributos "
    Public pCCMPN_Compania As String = ""
    Public pNPLCUN_NroPlacaUnidad As String = ""
    Public pTMRCTR_Marca_Modelo As String = ""
    Public pNRGMT1_NroMTC As String = ""
#End Region
#Region " Métodos "
    Public Sub pClear()
        pNPLCUN_NroPlacaUnidad = ""
        pTMRCTR_Marca_Modelo = ""
        pNRGMT1_NroMTC = ""
    End Sub

    Public Sub pClearAll()
        pCCMPN_Compania = ""
        Call MyClass.pClear()
    End Sub
#End Region
End Class

''' <summary>
''' Filtro para el Listado de Tractos para ser utilizadas en un DataGrid con opciones de Paginación
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Qry_Tracto_L01
#Region " Atributos "
    Public pCCMPN_Compania As String = ""
    Public pNPLCUN_NroPlacaUnidad As String = ""
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
        pCCMPN_Compania = ""
        Call MyClass.pClear()
    End Sub
#End Region
End Class