Imports System.Runtime.InteropServices

Namespace OrdenCompra
    <StructLayout(LayoutKind.Sequential)> _
     Public Class TD_OrdenCompraPK
#Region " Atributos "
        Public pCCLNT_CodigoCliente As Int64 = 0
        Public pNORCML_NroOrdenCompra As String = ""
        Public pCCLIENT_CodigoClinteYRC As Int64 = 0
        Public pNRUCPR_NroRucProveedor As String = ""
        Public pNOMBPR_NombreProveedor As String = ""
        Public pdtImportacionOCABB As DataTable
        Public pbolImportadoOCABB As Boolean = False
        Public pTTINTC_TerminoIntern As String = ""
        Public PAGESIZE As Double = 0
        Public PAGENUMBER As Double = 0
        Public PAGECOUNT As Double = 0
        Public pCCMPN_CodCompania As String = ""
        Public pCDVSN_CodDivision As String = ""
        Public pCPLNDV_CodPlanta As Decimal = 0
        Public pNTRMNL_Terminal As String = ""
        Public pTDITES_DescripcionItems As String = ""
        Public pTPOOCM_TipoOC As String = ""
        Public pCPRPCL_CodProvCliente As String = ""
        Public pSTPORL_TipoRelacion As String = ""
        Public pCPRVCL_CodProveedor As Decimal = 0D
        Public pSFLGES_FlagEstado As String = ""
        'Public pTCNDPG_CondicionPago As String = ""
        Private _pTCNDPG_CondicionPago As String = ""
        Public Property pTCNDPG_CondicionPago() As String
            Get
                Return _pTCNDPG_CondicionPago
            End Get
            Set(ByVal value As String)
                _pTCNDPG_CondicionPago = value
            End Set
        End Property

#End Region
#Region " Métodos "
        Public Sub pClear()
            pCCLNT_CodigoCliente = 0
            pNORCML_NroOrdenCompra = ""
            pNRUCPR_NroRucProveedor = ""
            pNOMBPR_NombreProveedor = ""
        End Sub
#End Region
    End Class

    Public Class TD_OrdenCompra
        Public pCCLNT_CodigoCliente As Int64 = 0
        Public pNORCML_NroOrdenCompra As String = ""
        Public pTPOOCM_TipoOC As String = ""
        Public pCPRVCL_CodigoClienteTercero As Int32 = 0
        Public pFORCML_FechaOCDte As Date
        Public pFSOLIC_FechaSolicOCDte As Date
        Public pFSOLIC_FechaSolicOCstr As String = ""

        Public pTDSCML_Descripcion As String = ""
        Public pTCMAEM_DescAreaEmpresa As String = ""
        Public pTTINTC_TerminoIntern As String = ""
        Public pNREFCL_ReferenciaCliente As String = ""
        Public pTPAGME_TerminoPago As String = ""
        Public pREFDO1_ReferenciaDocumento As String = ""
        Public pNTPDES_Prioridad As Integer = 0
        Public pCMNDA1_Moneda As Int32 = 0
        Public pTEMPFAC_EmpresaFacturar As String = ""
        Public pTNOMCOM_NombreComprador As String = ""
        Public pTCTCST_CentroCosto As String = ""
        Public pCREGEMB_RegEmbarque As String = ""
        Public pCMEDTR_MedioTransporte As Int32 = 0
        Public pTDEFIN_DestinoFinal As String = ""
        Public pIVCOTO_ImporteCostoTotal As Decimal = 0.0
        Public pIVTOCO_ImporteTotalCompra As Decimal = 0.0
        Public pIVTOIM_ImporteTotalImpuesto As Decimal = 0.0
        Public pTDAITM_Observaciones As String = ""
        Public pNTRMNL_Terminal As String = ""
        Private _pTCNDPG_CondicionPago As String = ""
        Public pTRSCN_NombreContacto As String = ""
        Public pTLFNO2_TelefonoContacto As String = ""
        Public pTEMAI3_EmailContacto As String = ""
        Public pTPRVCL_Proveedor As String = ""
        Public Property pTCNDPG_CondicionPago() As String
            Get
                Return _pTCNDPG_CondicionPago
            End Get
            Set(ByVal value As String)
                _pTCNDPG_CondicionPago = value
            End Set
        End Property



        Public ReadOnly Property pFORCML_FechaOCInt() As Int32
            Get
                Dim intTemp As Int32 = 0
                If pFORCML_FechaOCDte.Year > 1 Then Int32.TryParse(pFORCML_FechaOCDte.ToString("yyyyMMdd"), intTemp)
                Return intTemp
            End Get
        End Property

        Public ReadOnly Property pFSOLIC_FechaSolicOCInt() As Int32
            Get
                Dim intTemp As Int32 = 0
                If pFSOLIC_FechaSolicOCDte.Year > 1 Then Int32.TryParse(pFSOLIC_FechaSolicOCDte.ToString("yyyyMMdd"), intTemp)
                Return intTemp
            End Get
        End Property
    End Class

  <StructLayout(LayoutKind.Sequential)> _
  Public Class TD_Qry_OrdenCompra_L01
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pNORCML_NroOrdenCompra As String = ""
    Public pCPRVCL_Proveedor As Int32 = 0
    Public pFORCML_FechaOC_Inicio As Date
    Public pFORCML_FechaOC_Final As Date
    Public pTCMPCL_DescripcionCliente As String = ""
    Public pTTINTC_TermInterCarga As String = ""
    Public pCMEDTR_MedioTransporte As Int32 = 0
    Public pNREFCL_ReferenciaCliente As String = ""
    Public pREFDO1_ReferenciaDocumento As String = ""
    Public pNTPDES_Prioridad As Integer = 0
    Public pTDSCML_DescripcionOC As String = ""
    Public pSITUOC_SituacionOC As String = ""
    Public pNROPAG_NroPagina As Int32 = 0
    Public pREGPAG_NroRegPorPagina As Int32 = 0

        Public pNTRMNL_Terminal As String = ""
    Public ReadOnly Property pFORCML_FechaOC_Inicio_FNum() As Int32
      Get
        Dim intTemp As Int32 = 0
        If pFORCML_FechaOC_Inicio.Year > 1 Then Int32.TryParse(pFORCML_FechaOC_Inicio.ToString("yyyyMMdd"), intTemp)
        Return intTemp
      End Get
    End Property

    Public ReadOnly Property pFORCML_FechaOC_Final_FNum() As Int32
      Get
        Dim intTemp As Int32 = 0
        If pFORCML_FechaOC_Final.Year > 1 Then Int32.TryParse(pFORCML_FechaOC_Final.ToString("yyyyMMdd"), intTemp)
        Return intTemp
      End Get
    End Property
  End Class
End Namespace