Imports System.Runtime.InteropServices

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_ClientePK
#Region " Atributos "
    Public pCCLNT_Cliente As Int64 = 0
    Public pUsuario As String = ""
    Public pCCMPN_CodigoCompania As String
#End Region
#Region " Métodos "
    Sub New()
        pCCLNT_Cliente = 0
        pUsuario = ""
    End Sub

    Sub New(ByVal Cliente As Int64, ByVal Usuario As String)
        pCCLNT_Cliente = Cliente
        pUsuario = Usuario
    End Sub

    Public Sub pClear()
        pCCLNT_Cliente = 0
        pUsuario = ""
    End Sub
#End Region
End Class

''' <summary>
''' Información completa del Cliente
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Obj_Cliente
#Region " Atributos "
    Public pCCLNT_Cliente As Int64 = 0
    'Agregado ACD
    Public pCCLNT_ClienteGrupo As Int64 = 0
    'Fin Agregado ACD
    Public pTCMPCL_DescripcionCliente As String = ""
    Public pTCMCL1_DescripcionAdicional As String = ""
    Public pTDRCOR_DireccionOrigen As String = ""
    Public pCCMPN_CodigoCompania As String = ""
    Public pNRUC_NroRUC As Int64 = 0
    Public pNLBTEL_NroDocIdentidad As Int64 = 0
    '<[AHM]>
    Public pVisualizarNegocio As Boolean = False
    Public pCRGVTA_CodigoRegionVenta As String = ""
    Public pTCRVTA_DescripcionRegionVenta As String = ""
    Public pCDSCSP_CodigoSector As String = ""
    Public pCDDRSP_CodClienteSAP As String = ""
    '</[AHM]>
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCLNT_Cliente = 0
        'Agregado ACD
        pCCLNT_ClienteGrupo = 0
        'Fin Agregado ACD
        pTCMPCL_DescripcionCliente = ""
        pTCMCL1_DescripcionAdicional = ""
        pTDRCOR_DireccionOrigen = ""
        pNRUC_NroRUC = 0
        pCCMPN_CodigoCompania = ""
        pNLBTEL_NroDocIdentidad = 0
        '<[AHM]>
        pVisualizarNegocio = False
        pCRGVTA_CodigoRegionVenta = ""
        pTCRVTA_DescripcionRegionVenta = ""
        pCDSCSP_CodigoSector = ""
        pCDDRSP_CodClienteSAP = ""
        '</[AHM]>
    End Sub
#End Region
End Class

''' <summary>
''' Información Básica del Cliente
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Inf_Cliente_L01
#Region " Atributos "
    Public pCCLNT_Cliente As Int64 = 0
    'Agregado ACD
    Public pCCLNT_ClienteGrupo As Int64 = 0
    'Fin Agregado ACD
    Public pTCMPCL_DescripcionCliente As String = ""
    Public pTDRCOR_DireccionOrigen As String = ""
    Public pNRUC_NroRUC As Int64 = 0
    Public pNLBTEL_NroDocIdentidad As Int64 = 0

    '<[AHM]>
    Public pVisualizarNegocio As Boolean = False
    Public pCRGVTA_CodigoRegionVenta As String = ""
    Public pTCRVTA_DescripcionRegionVenta As String = ""
    Public pCDSCSP_CodigoSector As String = ""
    Public pCDDRSP_CodClienteSAP As String = ""
    '</[AHM]>
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCLNT_Cliente = 0
        'Agregado ACD
        pCCLNT_ClienteGrupo = 0
        'Fin Agregado ACD
        pTCMPCL_DescripcionCliente = ""
        pNRUC_NroRUC = 0
        pTDRCOR_DireccionOrigen = ""
        pNLBTEL_NroDocIdentidad = 0
        '<[AHM]>
        pVisualizarNegocio = False
        pCRGVTA_CodigoRegionVenta = ""
        pTCRVTA_DescripcionRegionVenta = ""
        pCDSCSP_CodigoSector = ""
        pCDDRSP_CodClienteSAP = ""
        '</[AHM]>

    End Sub
#End Region
End Class

''' <summary>
''' Filtro para el Listado de Clientes para ser utilizadas en un DataGrid con opciones de Paginación
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Qry_Cliente_L01
#Region " Atributos "
    Public pCCLNT_Cliente As String = ""
    'ACD
    Public pCCLNT_ClienteGrupo As String = ""
    'Fin ACD
    Public pTCMPCL_DescripcionCliente As String = ""
    Public pNRUC_NroRUC As String = ""
    Public pUsuario As String = ""
    Public pNROPAG_NroPagina As Int32 = 0
    Public pREGPAG_NroRegPorPagina As Int32 = 0
    Public pCCMPN_CodigoCompania As String = ""
    '<[AHM]>
    Public pVisualizarNegocio As Boolean = False
    Public pCRGVTA_CodigoRegionVenta As String = ""
    Public pTCRVTA_DescripcionRegionVenta As String = ""
    Public pCDSCSP_CodigoSector As String = ""
    Public pCDDRSP_CodClienteSAP As String = ""
    '</[AHM]>
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCLNT_Cliente = ""
        'ACD
        pCCLNT_ClienteGrupo = ""
        'Fin ACD
        pTCMPCL_DescripcionCliente = ""
        pNRUC_NroRUC = ""
        pUsuario = ""
        pNROPAG_NroPagina = 0
        pREGPAG_NroRegPorPagina = 0
        pCCMPN_CodigoCompania = ""
        '<[AHM]>
        pVisualizarNegocio = False
        pCRGVTA_CodigoRegionVenta = ""
        pTCRVTA_DescripcionRegionVenta = ""
        pCDSCSP_CodigoSector = ""
        pCDDRSP_CodClienteSAP = ""
        '</[AHM]>
    End Sub
#End Region
End Class