Imports System.Runtime.InteropServices

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_ServicioPK
#Region " Atributos "
    Public pCCMPN_Compania As String = ""
    Public pCDVSN_Division As String = ""
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pNOPRCN_Operacion As Int64 = 0
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCMPN_Compania = ""
        pCDVSN_Division = ""
        pCCLNT_CodigoCliente = 0
        pNOPRCN_Operacion = 0
    End Sub
#End Region
End Class

''' <summary>
''' TD para referenciar el registro único de los Servicios adquiridos por el cliente para la función -- fblnEliminarServicio -- de la clase daoServicio
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Servicio_AdquiridoPK
#Region " Atributos "
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pNOPRCN_Operacion As Int64 = 0
    Public pNRTFSV_Tarifa_Servicio As Int64 = 0
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCLNT_CodigoCliente = 0
        pNOPRCN_Operacion = 0
        pNRTFSV_Tarifa_Servicio = 0
    End Sub
#End Region
End Class

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_OperacionPK
#Region " Atributos "
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pNOPRCN_Operacion As Int64 = 0
    Public pCCMPN_Compania As String = ""
    Public pCDVSN_Division As String = ""
    Public pCPLNDV_Planta As Int32 = 0
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCLNT_CodigoCliente = 0
        pNOPRCN_Operacion = 0
    End Sub
#End Region
End Class

''' <summary>
''' TD para registrar los Servicios Disponibles adquiridos por el cliente en la función -- AgregarServicioAdquirido -- de la clase daoServicio
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Servicio_Adquirido
#Region " Atributos "
    Public pCCMPN_Compania As String = ""
    Public pCDVSN_Division As String = ""
    Public pCPLNDV_Planta As Int32 = 0
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pNOPRCN_Operacion As Int64 = 0
    Public pFOPRCN_FechaOperacion As Date
    Public pFECINI_Inicio As Date
    Public pFECFIN_Final As Date
    Public pNRTFSV_Tarifa_Servicio As Int64 = 0
    Public pQCNESP_Cantidad_Base As Decimal = 0
    Public pTUNDIT_Unidad As String = ""
    Public pQATNAN_CantAtendida As Decimal = 0
    Public pSTPODP_TipoSistAlm As String = ""
    Public pSTIPPR_Proceso As String = ""
    Public pCCLNFC_ClienteFacturar As Int64 = 0
    Public pCPRCN1_Contenedor As String = ""
    Public pNSRCN1_SerieContenedor As String = ""

    Public ReadOnly Property pFOPRCN_FechaOperacion_FNum() As Int32
        Get
            Dim intTemp As Int32 = 0
            If pFOPRCN_FechaOperacion.Year > 1 Then Int32.TryParse(pFOPRCN_FechaOperacion.ToString("yyyyMMdd"), intTemp)
            Return intTemp
        End Get
    End Property

    Public ReadOnly Property pFECINI_Inicio_FNum() As Int32
        Get
            Dim intTemp As Int32 = 0
            If pFECINI_Inicio.Year > 1 Then Int32.TryParse(pFECINI_Inicio.ToString("yyyyMMdd"), intTemp)
            Return intTemp
        End Get
    End Property

    Public ReadOnly Property pFECFIN_Final_FNum() As Int32
        Get
            Dim intTemp As Int32 = 0
            If pFECFIN_Final.Year > 1 Then Int32.TryParse(pFECFIN_Final.ToString("yyyyMMdd"), intTemp)
            Return intTemp
        End Get
    End Property
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCMPN_Compania = ""
        pCDVSN_Division = ""
        pCPLNDV_Planta = 0
        pCCLNT_CodigoCliente = 0
        pNOPRCN_Operacion = 0
        pFOPRCN_FechaOperacion = New Date
        pFECINI_Inicio = New Date
        pFECFIN_Final = New Date
        pNRTFSV_Tarifa_Servicio = 0
        pQCNESP_Cantidad_Base = 0
        pTUNDIT_Unidad = ""
        pQATNAN_CantAtendida = 0
        pSTPODP_TipoSistAlm = ""
        pSTIPPR_Proceso = ""
        pCCLNFC_ClienteFacturar = 0
        pCPRCN1_Contenedor = ""
        pNSRCN1_SerieContenedor = ""
    End Sub
#End Region
End Class

''' <summary>
''' TD para grabar los detalle del Servicio Adquirido
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Servicio_Detalle_I01
#Region " Atributos "
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pNOPRCN_Operacion As Int64 = 0
    Public pSTPODP_TipoSistAlm As String = ""
    Public pCREFFW_CodigoBulto As String = ""
    Public pNROPLT_NroPaletizado As Int64 = 0
    Public pNROCTL_NroPreDespacho As Int64 = 0
    Public pNRGUSA_NroGuiaSalida As Int64 = 0
    Public pNGUIRM_NroGuiaRemision As Int64 = 0
    Public pNORDSR_OrdenServicio As Int64 = 0
    Public pNSLCSR_NroSolicitud As Int32 = 0
    Public pNGUIRN_NroGuiaRansa As Int64 = 0
    Public pCCMPN_Compania As String = ""
    Public pCDVSN_Division As String = ""
    Public pCPLNDV_Planta As Int32 = 0
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCLNT_CodigoCliente = 0
        pNOPRCN_Operacion = 0
        pCREFFW_CodigoBulto = ""
        pNROPLT_NroPaletizado = 0
        pNROCTL_NroPreDespacho = 0
        pNRGUSA_NroGuiaSalida = 0
        pNGUIRM_NroGuiaRemision = 0
        pNORDSR_OrdenServicio = 0
        pNSLCSR_NroSolicitud = 0
        pNGUIRN_NroGuiaRansa = 0
        pCCMPN_Compania = ""
        pCDVSN_Division = ""
        pCPLNDV_Planta = 0
    End Sub
#End Region
End Class

''' <summary>
''' TD para eliminar los detalle del Servicio Adquirido
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Servicio_Detalle_E01
#Region " Atributos "
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pNOPRCN_Operacion As Int64 = 0
    Public pSTPODP_TipoSistAlm As String = ""
    Public pCREFFW_CodigoBulto As String = ""
    Public pNORDSR_OrdenServicio As Int64 = 0
    Public pNSLCSR_NroSolicitud As Int32 = 0
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCLNT_CodigoCliente = 0
        pNOPRCN_Operacion = 0
        pCREFFW_CodigoBulto = ""
        pNORDSR_OrdenServicio = 0
        pNSLCSR_NroSolicitud = 0
    End Sub
#End Region
End Class

''' <summary>
''' TD para actualizar los Servicios adquiridos por el cliente en la función -- EditarServicioAdquirido -- de la clase daoServicio
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Servicio_Adquirido_InfGen
#Region " Atributos "
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pNOPRCN_Operacion As Int64 = 0
    Public pSTIPPR_Proceso As String = ""
    Public pCCLNFC_ClienteFacturar As Int64 = 0
    Public pFECINI_Inicio As Date
    Public pFECFIN_Final As Date
    Public pCPRCN1_Contenedor As String = ""
    Public pNSRCN1_SerieContenedor As String = ""

    Public ReadOnly Property pFECINI_Inicio_FNum() As Int32
        Get
            Dim intTemp As Int32 = 0
            If pFECINI_Inicio.Year > 1 Then Int32.TryParse(pFECINI_Inicio.ToString("yyyyMMdd"), intTemp)
            Return intTemp
        End Get
    End Property

    Public ReadOnly Property pFECFIN_Final_FNum() As Int32
        Get
            Dim intTemp As Int32 = 0
            If pFECFIN_Final.Year > 1 Then Int32.TryParse(pFECFIN_Final.ToString("yyyyMMdd"), intTemp)
            Return intTemp
        End Get
    End Property
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCLNT_CodigoCliente = 0
        pNOPRCN_Operacion = 0
        pSTIPPR_Proceso = ""
        pCCLNFC_ClienteFacturar = 0
        pFECINI_Inicio = New Date
        pFECFIN_Final = New Date
        pCPRCN1_Contenedor = ""
        pNSRCN1_SerieContenedor = ""
    End Sub
#End Region
End Class

''' <summary>
''' TD para Informar el servicio a se agregado o modificado desde el Formulario -- ucServicios_FServF01
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Inf_Servicio_F01
#Region " Atributos "
    Public pCCMPN_Compania As String = ""
    Public pCDVSN_Division As String = ""
    Public pCPLNDV_Planta As Int32 = 0
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pNOPRCN_Operacion As Int64 = 0
    Public pFOPRCN_FechaOperacion As Date
    Public pFECINI_Inicio As Date
    Public pFECFIN_Final As Date
    Public pSTPODP_TipoSistAlm As String = ""
    Public pSTIPPR_Proceso As String = ""
    Public pCCLNFC_ClienteFacturar As Int64 = 0
    Public pCPRCN1_Contenedor As String = ""
    Public pNSRCN1_SerieContenedor As String = ""
    ' Información para la carga adicional a la operación - AT
    Public pCREFFW_CodigoBulto As String = ""
    Public pNROPLT_NroPaletizado As Int64 = 0
    Public pNROCTL_NroPreDespacho As Int64 = 0
    Public pNRGUSA_NroGuiaSalida As Int64 = 0
    Public pNGUIRM_NroGuiaRemision As Int64 = 0
    ' Información para la carga adicional a la operación - DS y DA
    Public pNORDSR_OrdenServicio As Int64 = 0
    Public pNSLCSR_NroSolicitud As Int32 = 0
    Public pNGUIRN_NroGuiaRansa As Int64 = 0
    Public pUsuario As String = ""

    Public ReadOnly Property pFOPRCN_FechaOperacion_FNum() As Int32
        Get
            Dim intTemp As Int32 = 0
            If pFOPRCN_FechaOperacion.Year > 1 Then Int32.TryParse(pFOPRCN_FechaOperacion.ToString("yyyyMMdd"), intTemp)
            Return intTemp
        End Get
    End Property

    Public ReadOnly Property pFECINI_Inicio_FNum() As Int32
        Get
            Dim intTemp As Int32 = 0
            If pFECINI_Inicio.Year > 1 Then Int32.TryParse(pFECINI_Inicio.ToString("yyyyMMdd"), intTemp)
            Return intTemp
        End Get
    End Property

    Public ReadOnly Property pFECFIN_Final_FNum() As Int32
        Get
            Dim intTemp As Int32 = 0
            If pFECFIN_Final.Year > 1 Then Int32.TryParse(pFECFIN_Final.ToString("yyyyMMdd"), intTemp)
            Return intTemp
        End Get
    End Property
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCLNT_CodigoCliente = 0
        pNOPRCN_Operacion = 0
        pFOPRCN_FechaOperacion = New Date
        pFECINI_Inicio = New Date
        pFECFIN_Final = New Date
        pSTPODP_TipoSistAlm = ""
        pSTIPPR_Proceso = ""
        pCCLNFC_ClienteFacturar = 0
        pCPRCN1_Contenedor = ""
        pNSRCN1_SerieContenedor = ""
        pCREFFW_CodigoBulto = ""
        pNROPLT_NroPaletizado = 0
        pNROCTL_NroPreDespacho = 0
        pNRGUSA_NroGuiaSalida = 0
        pNGUIRM_NroGuiaRemision = 0
        pNORDSR_OrdenServicio = 0
        pNSLCSR_NroSolicitud = 0
        pNGUIRN_NroGuiaRansa = 0
        pUsuario = ""
    End Sub
#End Region
End Class

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Inf_Servicio_F02
#Region " Atributos "
    Public pCCMPN_Compania As String = ""
    Public pCDVSN_Division As String = ""
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pNOPRCN_Operacion As Int64 = 0
    Public pFOPRCN_FechaOperacion As Date
    Public pSTIPPR_Proceso As String = ""
    Public pCCLNFC_ClienteFacturar As Int64 = 0
    Public pCPRCN1_Contenedor As String = ""
    Public pNSRCN1_SerieContenedor As String = ""

    Public ReadOnly Property pFOPRCN_FechaOperacion_FNum() As Int32
        Get
            Dim intTemp As Int32 = 0
            If pFOPRCN_FechaOperacion.Year > 1 Then Int32.TryParse(pFOPRCN_FechaOperacion.ToString("yyyyMMdd"), intTemp)
            Return intTemp
        End Get
    End Property
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCLNT_CodigoCliente = 0
        pNOPRCN_Operacion = 0
        pFOPRCN_FechaOperacion = New Date
        pSTIPPR_Proceso = ""
        pCCLNFC_ClienteFacturar = 0
        pCPRCN1_Contenedor = ""
        pNSRCN1_SerieContenedor = ""
    End Sub
#End Region
End Class

''' <summary>
''' TD para leer los Servicios Disponibles Adquiridos por el Cliente registrados en el control -- ucServicios_DgF01 --
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Inf_Servicio_F03
#Region " Atributos "
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pNOPRCN_Operacion As Int64 = 0
    Public pFOPRCN_FechaOperacion As Date
    Public pFECINI_Inicio As Date
    Public pFECFIN_Final As Date
    Public pNRTFSV_Tarifa As Int64 = 0
    Public pSTPODP_TipoSistAlm As String = ""
    Public pSTIPPR_Proceso As String = ""

    Public ReadOnly Property pFOPRCN_FechaOperacion_FNum() As Int32
        Get
            Dim intTemp As Int32 = 0
            If pFOPRCN_FechaOperacion.Year > 1 Then Int32.TryParse(pFOPRCN_FechaOperacion.ToString("yyyyMMdd"), intTemp)
            Return intTemp
        End Get
    End Property

    Public ReadOnly Property pFECINI_Inicio_FNum() As Int32
        Get
            Dim intTemp As Int32 = 0
            If pFECINI_Inicio.Year > 1 Then Int32.TryParse(pFECINI_Inicio.ToString("yyyyMMdd"), intTemp)
            Return intTemp
        End Get
    End Property

    Public ReadOnly Property pFECFIN_Final_FNum() As Int32
        Get
            Dim intTemp As Int32 = 0
            If pFECFIN_Final.Year > 1 Then Int32.TryParse(pFECFIN_Final.ToString("yyyyMMdd"), intTemp)
            Return intTemp
        End Get
    End Property
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCLNT_CodigoCliente = 0
        pNOPRCN_Operacion = 0
        pNRTFSV_Tarifa = 0
        pSTIPPR_Proceso = ""
        pFECINI_Inicio = New Date
        pFECFIN_Final = New Date
    End Sub
#End Region
End Class

''' <summary>
''' TD para leer los Servicios Disponibles de la tabla obtenido del método -- fdtListar_ServiciosDisponibles_L01 -- de la clase daoServicio
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Inf_Servicio_Disponible_F01
#Region " Atributos "
    Public pNRTFSV_Tarifa_Servicio As Int64 = 0
    Public pNOMSER_Descripcion_Servicio As String = ""
    Public pQCNESP_Cantidad_Base As Decimal = 0
    Public pTUNDIT_Unidad As String = ""
#End Region
#Region " Métodos "
    Public Sub pClear()
        pNRTFSV_Tarifa_Servicio = 0
        pNOMSER_Descripcion_Servicio = ""
        pQCNESP_Cantidad_Base = 0
        pTUNDIT_Unidad = ""
    End Sub
#End Region
End Class

''' <summary>
''' TD para leer uno de los Servicios Adquiridos registrados en el datagrid -- ucServicios_DgF02 --
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Inf_Servicio_Adquiridos_F01
#Region " Atributos "
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pNRTFSV_Tarifa As Int64 = 0
    Public pNOMSER_Descripcion_Servicio As String = ""
    Public pQCNESP_CantBase As Decimal = 0
    Public pTUNDIT_Unidad As String = ""
    Public pQATNAN_CantAtendida As Decimal = 0
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCLNT_CodigoCliente = 0
        pNRTFSV_Tarifa = 0
        pNOMSER_Descripcion_Servicio = ""
        pQCNESP_CantBase = 0
        pTUNDIT_Unidad = ""
        pQATNAN_CantAtendida = 0.0
    End Sub
#End Region
End Class

''' <summary>
''' TD para leer un Bulto asociado a una operación de servicio registrados en el datagrid -- ucServicios_Waybill_DgF01 --
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Inf_Servicio_Bulto_F01
#Region " Atributos "
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pNOPRCN_Operacion As Int64 = 0
    Public pCREFFW_CodigoBulto As String = ""
    Public pCCMPN_Compania As String = ""
    Public pCDVSN_Division As String = ""
    Public pCPLNDV_Planta As Int32 = 0
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCLNT_CodigoCliente = 0
        pNOPRCN_Operacion = 0
        pCREFFW_CodigoBulto = ""
    End Sub
#End Region
End Class

''' <summary>
''' TD para leer una Mercadería asociado a una operación de servicio registrados en el datagrid -- ucServicios_Mercaderia_DgF01 --
''' </summary>
Public Class TD_Inf_Servicio_Mercaderia_F01
#Region " Atributos "
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pNOPRCN_Operacion As Int64 = 0
    Public pNORDSR_OrdenServicio As Int64 = 0
    Public pNSLCSR_NroSolicitud As Int32 = 0
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCLNT_CodigoCliente = 0
        pNOPRCN_Operacion = 0
        pNORDSR_OrdenServicio = 0
        pNSLCSR_NroSolicitud = 0
    End Sub
#End Region
End Class

''' <summary>
''' TD para consultar los Servicios Adquiridos por el Cliente -- ucServicios_DgF01 --
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Qry_Servicios_Adquiridos_L01
#Region " Atributos "
    Public pCCMPN_Compania As String = ""
    Public pCDVSN_Division As String = ""
    Public pCPLNDV_Planta As Int32 = 0
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pNOPRCN_Operacion As String = ""
    Public pSTPODP_TipoSistAlm As String = ""
    Public pCSRVNV_Servicio As String = ""
    Public pFOPRCN_FechaOperacion_Ini As Date
    Public pFOPRCN_FechaOperacion_Fin As Date
    Public pNROPAG_NroPagina As Int32 = 0
    Public pREGPAG_NroRegPorPagina As Int32 = 0
    Public pUsuario As String = ""

    Public ReadOnly Property pFOPRCN_FechaOperacion_Ini_FNum() As Int32
        Get
            Dim intTemp As Int32 = 0
            If pFOPRCN_FechaOperacion_Ini.Year > 1 Then Int32.TryParse(pFOPRCN_FechaOperacion_Ini.ToString("yyyyMMdd"), intTemp)
            Return intTemp
        End Get
    End Property

    Public ReadOnly Property pFOPRCN_FechaOperacion_Fin_FNum() As Int32
        Get
            Dim intTemp As Int32 = 0
            If pFOPRCN_FechaOperacion_Fin.Year > 1 Then Int32.TryParse(pFOPRCN_FechaOperacion_Fin.ToString("yyyyMMdd"), intTemp)
            Return intTemp
        End Get
    End Property
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCLNT_CodigoCliente = 0
        pNOPRCN_Operacion = ""
        pSTPODP_TipoSistAlm = ""
        pCSRVNV_Servicio = ""
        pFOPRCN_FechaOperacion_Ini = New Date
        pFOPRCN_FechaOperacion_Fin = New Date
        pNROPAG_NroPagina = 0
        pREGPAG_NroRegPorPagina = 0
        pUsuario = ""
    End Sub
#End Region
End Class

''' <summary>
''' TD para consultar los Servicios Adquiridos por el Cliente -- ucServicios_DgF02 --
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Qry_Servicios_Adquiridos_L02
#Region " Atributos "
    Public pCCMPN_Compania As String = ""
    Public pCDVSN_Division As String = ""
    Public pCPLNDV_Planta As Int32 = 0
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pNOPRCN_Operacion As Int64 = 0
    Public pFOPRCN_FechaOperacion As Date
    Public pUsuario As String = ""

    Public ReadOnly Property pFOPRCN_FechaOperacion_FNum() As Int32
        Get
            Dim intTemp As Int32 = 0
            If pFOPRCN_FechaOperacion.Year > 1 Then Int32.TryParse(pFOPRCN_FechaOperacion.ToString("yyyyMMdd"), intTemp)
            Return intTemp
        End Get
    End Property
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCMPN_Compania = ""
        pCDVSN_Division = ""
        pCPLNDV_Planta = 0
        pCCLNT_CodigoCliente = 0
        pNOPRCN_Operacion = 0
        pFOPRCN_FechaOperacion = New Date
    End Sub
#End Region
End Class

''' <summary>
''' TD para consultar los Waybills asociados a un proceos (Recepcion/Pre-Despacho/Despacho/Guia) -- ucServicios_Waybill_DgF01 --
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Qry_Servicio_Bulto_F01
#Region " Atributos "
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pNOPRCN_Operacion As Int64 = 0
    Public pSTPODP_TipoSistAlm As String = ""
    Public pCREFFW_CodigoBulto As String = ""
    Public pNROPLT_NroPaletizado As Int64 = 0
    Public pNROCTL_NroPreDespacho As Int64 = 0
    Public pNRGUSA_NroGuiaSalida As Int64 = 0
    Public pNGUIRM_NroGuiaRemision As Int64 = 0
    Public pUsuario As String = ""
    Public pCCMPN_Compania As String = ""
    Public pCDVSN_Division As String = ""
    Public pCPLNDV_Planta As Int32 = 0
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCLNT_CodigoCliente = 0
        pNOPRCN_Operacion = 0
        pSTPODP_TipoSistAlm = ""
        pCREFFW_CodigoBulto = ""
        pNROPLT_NroPaletizado = 0
        pNROCTL_NroPreDespacho = 0
        pNRGUSA_NroGuiaSalida = 0
        pNGUIRM_NroGuiaRemision = 0
    End Sub
#End Region
End Class

''' <summary>
''' TD para consultar las mercaderías asociados a un proceos (Recepcion/Despacho/Guia) -- ucServicios_Mercaderia_DgF01 --
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Qry_Servicio_Mercaderia_F01
#Region " Atributos "
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pNOPRCN_Operacion As Int64 = 0
    Public pSTPODP_TipoSistAlm As String = ""
    Public pNORDSR_OrdenServicio As Int64 = 0
    Public pNSLCSR_NroSolicitud As Int32 = 0
    Public pNGUIRN_NroGuiaRansa As Int64 = 0
    Public pUsuario As String = ""
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCLNT_CodigoCliente = 0
        pNOPRCN_Operacion = 0
        pSTPODP_TipoSistAlm = ""
        pNORDSR_OrdenServicio = 0
        pNSLCSR_NroSolicitud = 0
        pNGUIRN_NroGuiaRansa = 0
        pUsuario = ""
    End Sub
#End Region
End Class

''' <summary>
''' TD para consultar los Servicios Disponibles y llenar el combo ubicado en el datagrig -- ucServicios_DgF02 --
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Qry_Servicio_Disponible_L01
#Region " Atributos "
    Public pCCMPN_Compania As String = ""
    Public pCDVSN_Division As String = ""
    Public pCPLNDV_Planta As Int32 = 0
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pFOPRCN_FechaOperacion As Date

    Public ReadOnly Property pFOPRCN_FechaOperacion_FNum() As Int32
        Get
            Dim intTemp As Int32 = 0
            If pFOPRCN_FechaOperacion.Year > 1 Then Int32.TryParse(pFOPRCN_FechaOperacion.ToString("yyyyMMdd"), intTemp)
            Return intTemp
        End Get
    End Property
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCMPN_Compania = ""
        pCDVSN_Division = ""
        pCPLNDV_Planta = 0
        pCCLNT_CodigoCliente = 0
        pFOPRCN_FechaOperacion = New Date
    End Sub
#End Region
End Class