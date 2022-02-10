Imports System.Runtime.InteropServices
''' <summary>
''' Modified: Dagnino 09/25/2015
''' </summary>
''' <remarks></remarks>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_BultoPK
#Region " Atributos "
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pCREFFW_CodigoBulto As String = ""
    Public pCCMPN_Compania As String = ""
    Public pCDVSN_Division As String = ""
    Public pCPLNDV_Planta As Int32 = 0
    Public pNSEQIN_NrSecuencia As Decimal = 0
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCLNT_CodigoCliente = 0
        pCREFFW_CodigoBulto = ""
    End Sub
#End Region
End Class

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_ItemBultoPK
#Region " Atributos "
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pCREFFW_CodigoBulto As String = ""
    Public pCIDPAQ_CodigoIdentificacion As String = ""
    Public pNORCML_NroOrdenCompra As String = ""
    Public pNRITOC_NroItemOrdenCompra As Int32 = 0
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCLNT_CodigoCliente = 0
        pCREFFW_CodigoBulto = ""
        pCIDPAQ_CodigoIdentificacion = ""
        pNORCML_NroOrdenCompra = ""
        pNRITOC_NroItemOrdenCompra = 0
    End Sub
#End Region
End Class

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Sel_Bulto_L01
#Region " Atributos "
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pCREFFW_CodigoBulto As String = ""
    Public pQREFFW_CantidadRecibida As Decimal = 0.0
    Public pNROPLT_NroPaletizado As Int64 = 0
    Public pCTPALM_CodTipoAlmacen As String = ""
    Public pTALMC_DesTipoAlmacen As String = ""
    Public pCALMC_CodAlmacen As String = ""
    Public pTCMPAL_DesAlmacen As String = ""
    Public pCZNALM_CodZona As String = ""
    Public pTCMZNA_DesZona As String = ""
    Public pCCMPN_Compania As String = ""
    Public pCDVSN_Division As String = ""
    Public pCPLNDV_Planta As Decimal = 0
    Public pNSEQIN_NrSecuencia As Decimal = 0
    Public pCBLTOR_CodigoBultoOrigen As String = ""
    Public pNSEQIO_NrSecuenciaOrigen As Decimal = 0
    Public pNMRGIM_NrImagen As Decimal = 0

    'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-INICIO
    Public pCODMAT_CodigoMaterial As String = ""
    Public pDESMAT_DescripcionMaterial As String = ""
    Public pFechaInicio As Decimal = 0
    Public pFechaFin As Decimal = 0
    'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-FIN.

#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCLNT_CodigoCliente = 0
        pCREFFW_CodigoBulto = ""
        pQREFFW_CantidadRecibida = 0.0
        pNROPLT_NroPaletizado = 0
    End Sub
#End Region
End Class

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Sel_ItemBulto_L01
#Region " Atributos "
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pCREFFW_CodigoBulto As String = ""
    Public pCIDPAQ_CodigoIdentificacion As String = ""
    Public pNORCML_NroOrdenCompra As String = ""
    Public pNRITOC_NroItemOrdenCompra As Int32 = 0
    Public pQBLTSR_pCantidadRecibida As Decimal = 0.0

    Public pQPEPQT_QtaPeso As Decimal = 0
    Public pTUNPSO_UnidadPeso As String = ""
    Public pQVOPQT_QtaVolumen As Decimal = 0
    Public pTUNVOL_UnidadVolumen As String = ""

    Public pTDITES_DescripcionES As String = ""
    Public pTLUGEN_LugarEntrega As String = ""
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCLNT_CodigoCliente = 0
        pCREFFW_CodigoBulto = ""
        pCIDPAQ_CodigoIdentificacion = ""
        pNORCML_NroOrdenCompra = ""
        pNRITOC_NroItemOrdenCompra = 0
        pQBLTSR_pCantidadRecibida = 0.0

        pQPEPQT_QtaPeso = 0
        pTUNPSO_UnidadPeso = ""
        pQVOPQT_QtaVolumen = 0
        pTUNVOL_UnidadVolumen = ""

        pTDITES_DescripcionES = ""
        pTLUGEN_LugarEntrega = ""
    End Sub
#End Region
End Class

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Inf_Bulto_L01
#Region " Atributos "
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pCREFFW_CodigoBulto As String = ""
    Public pQREFFW_CantidadRecibida As Decimal = 0.0
    Public pNROPLT_NroPaletizado As Int64 = 0
    Public pNROPLT_NroPaletizado_str As String = ""
    Public pTLUGEN_LugarEntrega As String = ""
    Public pNOCURR_NroOcurrencia As Int32 = 0
    Public pCTPALM_CodTipoAlmacen As String = ""
    Public pTALMC_DesTipoAlmacen As String = ""
    Public pCALMC_CodAlmacen As String = ""
    Public pTCMPAL_DesAlmacen As String = ""
    Public pCZNALM_CodZona As String = ""
    Public pTCMZNA_DesZona As String = ""
    Public pNSEQIN_NrSecuencia As Decimal = 0

#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCLNT_CodigoCliente = 0
        pCREFFW_CodigoBulto = ""
        pQREFFW_CantidadRecibida = 0.0
        pNROPLT_NroPaletizado = 0
        pTLUGEN_LugarEntrega = ""
        pNOCURR_NroOcurrencia = 0
    End Sub
#End Region
End Class

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Qry_Bulto_L01
#Region " Tipo de Datos "
    Enum TipoTransmision
        TodosRegistros
        PenEnvRecep
        PenEnvRecepYEnviados
        PenEnvDesp
        PenEnvDespYEnviados
    End Enum
#End Region
#Region " Atributos "
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pCREFFW_CodigoBulto As String = ""
    Public pFREFFW_FechaRecep_Ini As Date
    Public pFREFFW_FechaRecep_Fin As Date
    Public pFSLFFW_FechaDesp_Ini As Date
    Public pFSLFFW_FechaDesp_Fin As Date
    Public pTTINTC_TermInterCarga As String = ""
    Public pTUBRFR_Ubicacion As String = ""
    Public pNROPLT_NroPaletizado As String = ""
    Public pCRTLTE_CriterioLote As String = ""
    Public pSSTINV_StatusAlmacen As String = ""
    Private pStatusTransmision As TipoTransmision
    Public pSTPING_TipoMovimiento As String = ""
    Public pUsuario As String = ""

    Public pNROPAG_NroPagina As Int32 = 1
    Public pREGPAG_NroRegPorPagina As Int32 = 0


    Public pCCMPN_CodigoCompania As String = ""
    Public pCDVSN_CodigoDivision As String = ""
    Public pCPLNDV_CodigoPlanta As Double = 0
    Public pPlanta As String = ""
    Public pFLGCNL_FlagLlegada As String = ""
    Public pNGRPRV_GuiaProveedor As String = ""
    Public pNORCML_OrdenDeCompra As String = ""
    Public pNGUIRM_GuiaDeRemision As Double = 0
    Public pSSNCRG_Sentido_Carga As String = ""

    Public ReadOnly Property pFREFFW_FechaRecep_Ini_FNum() As Int32
        Get
            Dim intTemp As Int32 = 0
            If pFREFFW_FechaRecep_Ini.Year > 1 Then Int32.TryParse(pFREFFW_FechaRecep_Ini.ToString("yyyyMMdd"), intTemp)
            Return intTemp
        End Get
    End Property

    Public ReadOnly Property pFREFFW_FechaRecep_Fin_FNum() As Int32
        Get
            Dim intTemp As Int32 = 0
            If pFREFFW_FechaRecep_Fin.Year > 1 Then Int32.TryParse(pFREFFW_FechaRecep_Fin.ToString("yyyyMMdd"), intTemp)
            Return intTemp
        End Get
    End Property

    Public ReadOnly Property pFSLFFW_FechaDesp_Ini_FNum() As Int32
        Get
            Dim intTemp As Int32 = 0
            If pFSLFFW_FechaDesp_Ini.Year > 1 Then Int32.TryParse(pFSLFFW_FechaDesp_Ini.ToString("yyyyMMdd"), intTemp)
            Return intTemp
        End Get
    End Property

    Public ReadOnly Property pFSLFFW_FechaDesp_Fin_FNum() As Int32
        Get
            Dim intTemp As Int32 = 0
            If pFSLFFW_FechaDesp_Fin.Year > 1 Then Int32.TryParse(pFSLFFW_FechaDesp_Fin.ToString("yyyyMMdd"), intTemp)
            Return intTemp
        End Get
    End Property

    Public Property pSTRNSM_StatusTransmisionEnum() As TipoTransmision
        Set(ByVal value As TipoTransmision)
            pStatusTransmision = value
        End Set
        Get
            Return pStatusTransmision
        End Get
    End Property

    Public ReadOnly Property pSTRNSM_StatusTransmision() As String
        Get
            Dim sTemp As String = ""
            Select Case pStatusTransmision
                Case TipoTransmision.TodosRegistros
                    sTemp = ""
                Case TipoTransmision.PenEnvRecep
                    sTemp = "P"
                Case TipoTransmision.PenEnvRecepYEnviados
                    sTemp = "R"
                Case TipoTransmision.PenEnvDesp
                    sTemp = "D"
                Case TipoTransmision.PenEnvDespYEnviados
                    sTemp = "E"
            End Select
            Return sTemp
        End Get
    End Property
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCLNT_CodigoCliente = 0
        pCREFFW_CodigoBulto = ""
        pFREFFW_FechaRecep_Ini = New Date
        pFREFFW_FechaRecep_Fin = New Date
        pFSLFFW_FechaDesp_Ini = New Date
        pFSLFFW_FechaDesp_Fin = New Date
        pTTINTC_TermInterCarga = ""
        pTUBRFR_Ubicacion = ""
        pNROPLT_NroPaletizado = ""
        pCRTLTE_CriterioLote = ""
        pSSTINV_StatusAlmacen = ""
        pStatusTransmision = TipoTransmision.TodosRegistros
        pUsuario = ""

        pNROPAG_NroPagina = 1
        pREGPAG_NroRegPorPagina = 0
    End Sub
#End Region
End Class

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Secuencia
#Region " Atributos "
    Public pCTPCTR_TipoSecuencia As String = ""
    Public pSTADEF_StatusDefinitivo As String = "N"
    Public pUSUARI_Usuario As String = ""
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCTPCTR_TipoSecuencia = ""
        pSTADEF_StatusDefinitivo = "N"
        pUSUARI_Usuario = ""
    End Sub
#End Region
End Class