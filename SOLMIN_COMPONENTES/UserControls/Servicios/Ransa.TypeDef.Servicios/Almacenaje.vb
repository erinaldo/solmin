Imports System.Runtime.InteropServices

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Qry_Almacenaje_L01
#Region " Atributos "
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pCREFFW_CodigoBulto As String = ""
    Public pNROPLT_NroPaletizado As String = ""
    Public pFREFFW_FechaRecep_Ini As Date
    Public pFREFFW_FechaRecep_Fin As Date
    Public pFSLFFW_FechaDesp_Ini As Date
    Public pFSLFFW_FechaDesp_Fin As Date
    Public pTTINTC_TermInterCarga As String = ""
    Public pTUBRFR_Ubicacion As String = ""
    Public pSTPING_TipoMovimiento As String = ""
    Public pCRTLTE_CriterioLote As String = ""

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
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCLNT_CodigoCliente = 0
        pCREFFW_CodigoBulto = ""
        pFREFFW_FechaRecep_Ini = Nothing
        pFREFFW_FechaRecep_Fin = Nothing
        pFSLFFW_FechaDesp_Ini = Nothing
        pFSLFFW_FechaDesp_Fin = Nothing
        pTTINTC_TermInterCarga = ""
        pTUBRFR_Ubicacion = ""
        pNROPLT_NroPaletizado = ""
        pCRTLTE_CriterioLote = ""
    End Sub
#End Region
End Class

Namespace Almacenaje
    <StructLayout(LayoutKind.Sequential)> _
    Public Class TD_Qry_LstAlmacenaje_L01
#Region " Atributos "
        Public pCCMPN_Compania As String = ""
        Public pCDVSN_Division As String = ""
        Public pCPLNDV_Planta As Int32 = 0
        Public pSTPODP_TipoSistAlm As String = ""
        Public pCCLNT_CodigoCliente As Int64 = 0
        Public pNPRALM_NroOperacion As Int64 = 0
        Public pNANPRC_AnoProceso As Int32 = 0
        Public pNMES_MesProceso As Int32 = 0
        Public pUsuario As String = ""
#End Region
#Region " Métodos "
        Public Sub pClear()
            pCCMPN_Compania = ""
            pCDVSN_Division = ""
            pCPLNDV_Planta = 0
            pSTPODP_TipoSistAlm = ""
            pCCLNT_CodigoCliente = 0
            pNPRALM_NroOperacion = 0
            pNANPRC_AnoProceso = 0
            pNMES_MesProceso = 0
            pUsuario = ""
        End Sub
#End Region
    End Class

    <StructLayout(LayoutKind.Sequential)> _
    Public Class TD_Qry_LstItemAlmacenaje_L01
#Region " Atributos "
        Public pNPRALM_NroOperacion As Int64 = 0
        Public pCCLNT_CodigoCliente As Int64 = 0
        Public pUsuario As String = ""
#End Region
#Region " Métodos "
        Public Sub pClear()
            pNPRALM_NroOperacion = 0
            pCCLNT_CodigoCliente = 0
            pUsuario = ""
        End Sub
#End Region
    End Class

    <StructLayout(LayoutKind.Sequential)> _
    Public Class TD_Inf_LstAlmacenaje_L01
#Region " Atributos "
        Public pNPRALM_NroOperacion As Int64 = 0
        Public pCCLNT_CodigoCliente As Int64 = 0
        Public pNANPRC_AnoProceso As Int32 = 0
        Public pNMES_MesProceso As Int32 = 0
#End Region
#Region " Métodos "
        Public Sub pClear()
            pNPRALM_NroOperacion = 0
            pCCLNT_CodigoCliente = 0
            pNANPRC_AnoProceso = 0
            pNMES_MesProceso = 0
        End Sub
#End Region
    End Class

    <StructLayout(LayoutKind.Sequential)> _
    Public Class TD_Inf_LstItemAlmacenaje_L01
#Region " Atributos "
        Public pNPRALM_NroOperacion As Int64 = 0
        Public pCCLNT_CodigoCliente As Int64 = 0
        Public pCREFFW_CodigoBulto As String = ""
#End Region
#Region " Métodos "
        Public Sub pClear()
            pNPRALM_NroOperacion = 0
            pCCLNT_CodigoCliente = 0
        End Sub
#End Region
    End Class

    <StructLayout(LayoutKind.Sequential)> _
    Public Class TD_Inf_DeleteAlmacenaje_L01
#Region " Atributos "
        Public pNPRALM_NroOperacion As Int64 = 0
        Public pCCLNT_CodigoCliente As Int64 = 0
        Public pUsuario As String = ""
#End Region
#Region " Métodos "
        Public Sub pClear()
            pNPRALM_NroOperacion = 0
            pCCLNT_CodigoCliente = 0
            pUsuario = ""
        End Sub
#End Region
    End Class

    <StructLayout(LayoutKind.Sequential)> _
    Public Class TD_Inf_DeleteItemAlmacenaje_L01
#Region " Atributos "
        Public pNPRALM_NroOperacion As Int64 = 0
        Public pCCLNT_CodigoCliente As Int64 = 0
        Public pCREFFW_CodigoBulto As String = ""
        Public pUsuario As String = ""
#End Region
#Region " Métodos "
        Public Sub pClear()
            pNPRALM_NroOperacion = 0
            pCCLNT_CodigoCliente = 0
            pCREFFW_CodigoBulto = ""
            pUsuario = ""
        End Sub
#End Region
    End Class

    Public Class TD_Inf_AddAlmacenaje_L01
#Region " Atributos "
        Public pCCMPN_Compania As String = ""
        Public pCDVSN_Division As String = ""
        Public pCPLNDV_Planta As Int32 = 0
        Public pSTPODP_TipoSistAlm As String = ""
        Public pCCLNT_CodigoCliente As Int64 = 0
        Public pNANPRC_Ano As Int32 = 0
        Public pNMES_Mes As Int32 = 0
        Public pFECINI_FechaInicial As Date
        Public pFECFIN_FechaFinal As Date
        Public pOBSERV_Observacion As String = ""
        Public pNDIALI_NroDiaLibres As Int32 = 0
        Public pNRTFSV_Tarifa_Servicio As Int64 = 0
        Public pQCNESP_Cantidad_Base As Decimal = 0
        Public pTUNDIT_Unidad As String = ""
        Public pSTPOUN_TipoUnidad As String = ""
        Public pCMNDA1_Moneda As Int32 = 0
        Public pVALUNI_ValorUnitario As Decimal = 0.0
        Public pSTPFLT_ConsiderarFiltros As String = ""
        Public pCREFFW_CodigoBulto As String = ""
        Public pNROPLT_NroPaleta As String = ""
        Public pTTINTC_TermInterCarga As String = ""
        Public pTUBRFR_Ubicacion As String = ""
        Public pSTPING_TipoMovimiento As String = ""
        Public pCRTLTE_CriterioLote As String = ""
        Public pUsuario As String = ""

        Public ReadOnly Property pFECINI_FechaInicial_FNum() As Int32
            Get
                Dim intTemp As Int32 = 0
                If pFECINI_FechaInicial.Year > 1 Then Int32.TryParse(pFECINI_FechaInicial.ToString("yyyyMMdd"), intTemp)
                Return intTemp
            End Get
        End Property

        Public ReadOnly Property pFECINI_FechaFinal_FNum() As Int32
            Get
                Dim intTemp As Int32 = 0
                If pFECFIN_FechaFinal.Year > 1 Then Int32.TryParse(pFECFIN_FechaFinal.ToString("yyyyMMdd"), intTemp)
                Return intTemp
            End Get
        End Property
#End Region
#Region " Métodos "
        Public Sub pClear()
            pCCMPN_Compania = ""
            pCDVSN_Division = ""
            pCPLNDV_Planta = 0
            pSTPODP_TipoSistAlm = ""
            pCCLNT_CodigoCliente = 0
            pNANPRC_Ano = 0
            pNMES_Mes = 0
            pFECINI_FechaInicial = Nothing
            pFECFIN_FechaFinal = Nothing
            pOBSERV_Observacion = ""
            pNDIALI_NroDiaLibres = 0

            pNRTFSV_Tarifa_Servicio = 0
            pQCNESP_Cantidad_Base = 0
            pTUNDIT_Unidad = ""
            pSTPOUN_TipoUnidad = ""
            pCMNDA1_Moneda = 0
            pVALUNI_ValorUnitario = 0.0

            pSTPFLT_ConsiderarFiltros = ""
            pCREFFW_CodigoBulto = ""
            pNROPLT_NroPaleta = ""
            pTTINTC_TermInterCarga = ""
            pTUBRFR_Ubicacion = ""
            pSTPING_TipoMovimiento = ""
            pCRTLTE_CriterioLote = ""
            pUsuario = ""
        End Sub
#End Region
    End Class

    Public Class TD_Inf_AddItemAlmacenaje_L01
#Region " Atributos "
        Public pNPRALM_NroOperacion As Int64 = 0
        Public pCCLNT_CodigoCliente As Int64 = 0
        Public pCREFFW_CodigoBulto As String = ""
        Public pNROPLT_NroPaletizado As Int64 = 0
        Public pNROCTL_NroPreDespacho As Int64 = 0
        Public pNRGUSA_NroGuiaSalida As Int64 = 0
        Public pNGUIRM_NroGuiaRemision As Int64 = 0
        Public pUsuario As String = ""
#End Region
#Region " Métodos "
        Public Sub pClear()
            pCCLNT_CodigoCliente = 0
            pNPRALM_NroOperacion = 0
            pCREFFW_CodigoBulto = ""
            pNROPLT_NroPaletizado = 0
            pNROCTL_NroPreDespacho = 0
            pNRGUSA_NroGuiaSalida = 0
            pNGUIRM_NroGuiaRemision = 0
            pUsuario = ""
        End Sub
#End Region
    End Class

    <StructLayout(LayoutKind.Sequential)> _
    Public Class TD_Pkey_Almacenaje
#Region " Atributos "
        Public pCCLNT_CodigoCliente As Int64 = 0
        Public pNPRALM_NroOperacion As Int64 = 0
#End Region
#Region " Métodos "
        Public Sub pClear()
            pCCLNT_CodigoCliente = 0
            pNPRALM_NroOperacion = 0
        End Sub
#End Region
    End Class
End Namespace