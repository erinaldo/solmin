Imports System.Runtime.InteropServices

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_TransportistaPK
#Region " Atributos "
    Public pCCMPN_Compania As String = ""
    Public pNRUCTR_RucTransportista As String = ""
    Public pUsuario As String = ""
#End Region
#Region " Métodos "
    Sub New()
        pCCMPN_Compania = ""
        pNRUCTR_RucTransportista = ""
        pUsuario = ""
    End Sub

    Sub New(ByVal Compania As String, ByVal RucEmpTransporte As String, ByVal Usuario As String)
        pCCMPN_Compania = Compania
        pNRUCTR_RucTransportista = RucEmpTransporte
        pUsuario = Usuario
    End Sub

    Public Sub pClear()
        pNRUCTR_RucTransportista = ""
        pUsuario = ""
    End Sub

    Public Sub pClearAll()
        pCCMPN_Compania = ""
        Call MyClass.pClear()
    End Sub
#End Region
End Class

''' <summary>
''' Información completa de la Empresa de Transporte
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Obj_Transportista
#Region " Atributos "
    Public pCCMPN_Compania As String = ""
    Public pNRUCTR_RucTransportista As String = ""
    Public pCTRSPT_CodTransportista As Int32 = 0
    Public pTCMTRT_RazonSocial As String = ""
    Public pTABTRT_DescAbrevRazonSocial As String = ""
    Public pTDRCTR_Direccion As String = ""
    Public pTLFTRP_Telefono As String = ""
    Public pSINDRC_IndicadorRecurso As String = ""
    Public pSESTRG_StatusRegistro As String = ""
    Public pSINDRC_PropioTercero As String = ""
#End Region
#Region " Métodos "
    Public Sub pClear()
        pNRUCTR_RucTransportista = ""
        pCTRSPT_CodTransportista = 0
        pTCMTRT_RazonSocial = ""
        pTABTRT_DescAbrevRazonSocial = ""
        pTDRCTR_Direccion = ""
        pTLFTRP_Telefono = ""
        pSINDRC_IndicadorRecurso = ""
        pSESTRG_StatusRegistro = ""
        pSINDRC_PropioTercero = ""
    End Sub

    Public Sub pClearAll()
        pCCMPN_Compania = ""
        Call MyClass.pClear()
    End Sub
#End Region
End Class

''' <summary>
''' Información Básica de la Empresa de Transporte
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Inf_Transportista_L01
#Region " Atributos "
    Public pCCMPN_Compania As String = ""
    Public pNRUCTR_RucTransportista As String = ""
    Public pCTRSPT_CodTransportista As Int32 = 0
    Public pTCMTRT_RazonSocial As String = ""
    Public pSINDRC_PropioTercero As String = ""
#End Region
#Region " Métodos "
    Public Sub pClear()
        pNRUCTR_RucTransportista = ""
        pCTRSPT_CodTransportista = 0
        pTCMTRT_RazonSocial = ""
        pSINDRC_PropioTercero = ""
    End Sub

    Public Sub pClearAll()
        pCCMPN_Compania = ""
        pNRUCTR_RucTransportista = ""
        pCTRSPT_CodTransportista = 0
        pTCMTRT_RazonSocial = ""
        pSINDRC_PropioTercero = ""
        Call MyClass.pClear()
    End Sub
#End Region
End Class

''' <summary>
''' Filtro para el Listado de Transportistas para ser utilizadas en un DataGrid con opciones de Paginación
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Qry_Transportista_L01
#Region " Atributos "
    Public pCCMPN_Compania As String = ""
    Public pNRUCTR_RucTransportista As String = ""
    Public pCTRSPT_CodTransportista As String = ""
    Public pTCMTRT_RazonSocial As String = ""
    Public pSINDRC_PropioTercero As String = ""
    Public pUsuario As String = ""
    Public pNROPAG_NroPagina As Int32 = 0
    Public pREGPAG_NroRegPorPagina As Int32 = 0
#End Region
#Region " Métodos "
    Public Sub pClear()
        pNRUCTR_RucTransportista = ""
        pCTRSPT_CodTransportista = ""
        pTCMTRT_RazonSocial = ""
        pSINDRC_PropioTercero = ""
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