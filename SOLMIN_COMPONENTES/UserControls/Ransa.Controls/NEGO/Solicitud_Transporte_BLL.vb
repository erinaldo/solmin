Public Class Solicitud_Transporte_BLL
    Dim objDataAccessLayer As New Solicitud_Transporte_DAL

    Public Function Lista_Destinatarios(ByVal objEntidad As Solicitud_Transporte) As String
        Dim dt As DataTable = objDataAccessLayer.Lista_Destinatarios(objEntidad)
        Dim sb As New System.Text.StringBuilder
        For row As Integer = 0 To dt.Rows.Count - 1
            sb.Append(dt.Rows(row).Item("MAIL"))
            If row < dt.Rows.Count - 1 Then
                sb.Append(";")
            End If
        Next
        Return sb.ToString
    End Function

    Public Function Lista_ObtenerSolicitud_Envio(ByVal objEntidad As Solicitud_Transporte) As DataTable
        Return objDataAccessLayer.Lista_ObtenerSolicitud_Envio(objEntidad)
    End Function

    Public Function Registrar_Solicitud_Transporte(ByVal objEntidad As Solicitud_Transporte) As Solicitud_Transporte
        Return objDataAccessLayer.Registrar_Solicitud_Transporte(objEntidad)
    End Function

    Public Function Modificar_Solicitud_Transporte(ByVal objEntidad As Solicitud_Transporte) As Solicitud_Transporte
        Return objDataAccessLayer.Modificar_Solicitud_Transporte(objEntidad)
    End Function

    Public Function Modificar_Solicitud_Transporte_Centro_Costo(ByVal objEntidad As Solicitud_Transporte) As Solicitud_Transporte
        Return objDataAccessLayer.Modificar_Solicitud_Transporte_Centro_Costo(objEntidad)
    End Function

    Public Function Cambiar_Estado_Solicitud_Transporte(ByVal objEntidad As Solicitud_Transporte) As Solicitud_Transporte
        Return objDataAccessLayer.Cambiar_Estado_Solicitud_Transporte(objEntidad)
    End Function

    Public Function Eliminar_Solicitud_Transporte_Reparto(ByVal objEntidad As Solicitud_Transporte) As List(Of String)
        ' Return objDataAccessLayer.Eliminar_Solicitud_Transporte_Reparto(objEntidad)
        Dim strResult As New List(Of String)
        Select Case objDataAccessLayer.Eliminar_Solicitud_Transporte_Reparto(objEntidad).NCRRSR
            Case 1
                strResult.Add("LA OPERACION SE ANULO SATISFACTORIAMENTE")
                strResult.Add(1)
            Case 2
                strResult.Add("LA OPERACION TIENE GUIA DE REMISION CARGADA")
                strResult.Add(2)
            Case 3
                strResult.Add("LA OPERACION ESTA LIQUIDADA")
                strResult.Add(3)
            Case 4
                strResult.Add("LA OPERACION ESTA PREFACTURADO / FACTURADO")
                strResult.Add(4)
            Case 5
                strResult.Add("LA OPERACION ESTA ANULADO")
                strResult.Add(5)
            Case 6
                strResult.Add("LA OPERACION TIENE ASIGNADO AVC Y/O GASTOS")
                strResult.Add(6)
        End Select
        Return strResult
    End Function

    'Public Function Listar_Solicitud_Transporte_Estado(ByVal objEntidad As List(Of String)) As List(Of Solicitud_Transporte)
    '  Return objDataAccessLayer.Listar_Solicitudes_Transporte_Estado(objEntidad)
    'End Function

    Public Function Listar_Solicitud_Transporte_Estado(ByVal objEntidad As Solicitud_Transporte) As List(Of Solicitud_Transporte)
        Return objDataAccessLayer.Listar_Solicitudes_Transporte_Estado(objEntidad)
    End Function

    Public Function Listar_Solicitudes_Transporte_Export(ByVal objParametros As Solicitud_Transporte) As DataTable
        Return objDataAccessLayer.Listar_Solicitudes_Transporte_Export(objParametros)
    End Function

    Public Function Listar_Solicitudes_Transporte_Export_Solicitudes_Programadas_Urgentes(ByVal objParametros As Solicitud_Transporte) As DataTable
        Return objDataAccessLayer.Listar_Solicitudes_Transporte_Export_Solicitudes_Programadas_Urgentes(objParametros)
    End Function

    Public Function Listar_Guia_Transporte_Estado(ByVal objEntidad As Hashtable) As List(Of GuiaTransportista)
        Return objDataAccessLayer.Listar_Guia_Transporte_Estado(objEntidad)
    End Function

    Public Function Listar_Solicitudes_Transporte_Multimodal(ByVal objEntidad As Multimodal) As List(Of Solicitud_Transporte)
        Return objDataAccessLayer.Listar_Solicitudes_Transporte_Multimodal(objEntidad)
    End Function

    Public Function Listar_Solicitudes_Transporte_Reparto(ByVal objEntidad As Repartos) As List(Of Solicitud_Transporte)
        Return objDataAccessLayer.Listar_Solicitudes_Transporte_Reparto(objEntidad)
    End Function

    Public Function Obtener_Solicitud_Transporte(ByVal objEntidad As Solicitud_Transporte) As Solicitud_Transporte
        Return objDataAccessLayer.Obtener_Datos_Solicitud_Transporte(objEntidad)
    End Function

    Public Function Obtener_Datos_Exclusivos(ByVal objEntidad As Solicitud_Transporte) As Solicitud_Transporte
        Return objDataAccessLayer.Obtener_Datos_Exclusivos(objEntidad)
    End Function

    Public Function Lista_Solicitudes_Transporte(ByVal objentidad As List(Of String)) As DataTable
        Return objDataAccessLayer.Listar_Solicitudes_Transporte(objentidad)
    End Function

    Public Function Lista_Solicitudes_Transporte2(ByVal objentidad As List(Of String)) As DataTable
        Return objDataAccessLayer.Listar_Solicitudes_Transporte2(objentidad)
    End Function

    Public Function Listar_Solicitudes_Vehiculo(ByVal objentidad As List(Of String)) As DataTable
        Return objDataAccessLayer.Listar_Solicitudes_Vehiculo(objentidad)
    End Function

    Public Function Obtener_Detalle_Solicitud_Asignada(ByVal objentidad As ClaseGeneral) As List(Of ClaseGeneral)
        Return objDataAccessLayer.Obtener_Detalle_Solicitud_Asignada(objentidad)
    End Function

    Public Function Lista_Unidad_Asignada_Multimodal(ByVal objEntidad As Multimodal) As List(Of ClaseGeneral)
        Return objDataAccessLayer.Lista_Unidad_Asignada_Multimodal(objEntidad)
    End Function

    Public Function Verificar_Existencia_Guia_Transportista(ByVal obj_Entidad As ClaseGeneral) As ClaseGeneral
        Return objDataAccessLayer.Verificar_Existencia_Guia_Transportista(obj_Entidad)
    End Function

    Public Function Actualizar_Fechas_Servicio_Almacen(ByVal obj_Entidad As Detalle_Solicitud_Transporte) As Detalle_Solicitud_Transporte
        Return objDataAccessLayer.Actualizar_Fechas_Servicio_Almacen(obj_Entidad)
    End Function

    Public Function Actualizar_Salida_Avion(ByVal obj_Entidad As Detalle_Solicitud_Transporte) As Int32
        Return objDataAccessLayer.Actualizar_Salida_Avion(obj_Entidad)
    End Function

    Public Function Asignar_Orden_Servicio_A_Solicitud(ByVal obj_Entidad As Solicitud_Transporte) As Solicitud_Transporte
        Return objDataAccessLayer.Asignar_Orden_Servicio_A_Solicitud(obj_Entidad)
    End Function

    Public Function Lista_Solicitud_X_Cliente(ByVal objentidad As List(Of String)) As List(Of ClaseGeneral)
        Return objDataAccessLayer.Lista_Solicitud_X_Cliente(objentidad)
    End Function

    Public Function Reporte_Mensual_Vehiculo(ByVal objParametros As Hashtable) As List(Of ClaseGeneral)
        Return objDataAccessLayer.Reporte_Mensual_Vehiculo(objParametros)
    End Function

    Public Function Reporte_Mensual_Conductor(ByVal objParametros As Hashtable) As List(Of ClaseGeneral)
        Return objDataAccessLayer.Reporte_Mensual_Conductor(objParametros)
    End Function

    Public Function Reporte_Mensual_Transportista(ByVal objParametros As Hashtable) As List(Of ClaseGeneral)
        Return objDataAccessLayer.Reporte_Mensual_Transportista(objParametros)
    End Function

    Public Function Reporte_Mensual_Acoplado(ByVal objParametros As Hashtable) As List(Of ClaseGeneral)
        Return objDataAccessLayer.Reporte_Mensual_Acoplado(objParametros)
    End Function

    Public Function Auditoria(ByVal objEntidad As Solicitud_Transporte) As Solicitud_Transporte
        Return objDataAccessLayer.Auditoria(objEntidad)
    End Function

    Public Function Anulacion_Operacion_Transporte(ByVal objEntidad As Solicitud_Transporte) As List(Of String)
        Dim strResult As New List(Of String)
        Select Case objDataAccessLayer.Anulacion_Operacion_Transporte(objEntidad)
            Case 1
                strResult.Add("LA OPERACION SE ANULO SATISFACTORIAMENTE")
                strResult.Add(1)
            Case 2
                strResult.Add("LA OPERACION TIENE GUIA DE REMISION CARGADA")
                strResult.Add(2)
            Case 3
                strResult.Add("LA OPERACION ESTA LIQUIDADA")
                strResult.Add(3)
            Case 4
                strResult.Add("LA OPERACION ESTA PREFACTURADO / FACTURADO")
                strResult.Add(4)
            Case 5
                strResult.Add("LA OPERACION ESTA ANULADO")
                strResult.Add(5)
            Case 6
                strResult.Add("LA OPERACION TIENE ASIGNADO AVC Y/O GASTOS")
                strResult.Add(6)
        End Select
        Return strResult
    End Function



    Public Function Anulacion_Operacion_Transporte_Multimodal(ByVal objEntidad As Solicitud_Transporte) As List(Of String)
        Dim strResult As New List(Of String)
        Select Case objDataAccessLayer.Anulacion_Operacion_Transporte_Multimodal(objEntidad)
            Case 1
                strResult.Add("LA OPERACION SE ANULO SATISFACTORIAMENTE")
                strResult.Add(1)
            Case 2
                strResult.Add("LA OPERACION TIENE GUIA DE REMISION CARGADA")
                strResult.Add(2)
            Case 3
                strResult.Add("LA OPERACION ESTA LIQUIDADA")
                strResult.Add(3)
            Case 4
                strResult.Add("LA OPERACION ESTA PREFACTURADO / FACTURADO")
                strResult.Add(4)
            Case 5
                strResult.Add("LA OPERACION ESTA ANULADO")
                strResult.Add(5)
            Case 6
                strResult.Add("LA OPERACION TIENE ASIGNADO AVC Y/O GASTOS")
                strResult.Add(6)
            Case 7
                strResult.Add("LA OPERACION SE ANULO SATISFACTORIAMENTE")
                strResult.Add(7)
        End Select
        Return strResult
    End Function


    Public Function Listar_Solicitud_Transporte_Selva(ByVal objEntidad As List(Of String)) As List(Of ClaseGeneral)
        Return objDataAccessLayer.Listar_Solicitud_Transporte_Selva(objEntidad)
    End Function

    Public Function Exportar_Reporte_Cargo_Plan_Terrestre(ByVal objEntidad As Solicitud_Transporte) As DataSet
        Return objDataAccessLayer.Exportar_Reporte_Cargo_Plan_Terrestre(objEntidad)
    End Function

    Public Function Exportar_Reporte_Cargo_Plan_Aereo(ByVal objEntidad As Solicitud_Transporte) As DataSet
        Return objDataAccessLayer.Exportar_Reporte_Cargo_Plan_Aereo(objEntidad)
    End Function

    Public Function Actualizar_Bulto(ByVal objParametros As Hashtable) As Int32
        Return objDataAccessLayer.Actualizar_Bulto(objParametros)
    End Function

    Public Function Listar_Guia_Remision_Cliente_CargoPlan(ByVal objParametros As Hashtable) As DataTable
        Return objDataAccessLayer.Listar_Guia_Remision_Cliente_CargoPlan(objParametros)
    End Function

    Public Function Listar_Guia_Orden_Compra_CargoPlan(ByVal objParametros As Hashtable) As DataTable
        Return objDataAccessLayer.Listar_Guia_Orden_Compra_CargoPlan(objParametros)
    End Function

    Public Function Listar_Guia_Anexa_CargoPlan(ByVal objParametros As Hashtable) As DataTable
        Return objDataAccessLayer.Listar_Guia_Anexa_CargoPlan(objParametros)
    End Function

    Public Function Actualizar_Peso_Volumen__CargoPlan(ByVal objParametros As Hashtable) As Int32
        Return objDataAccessLayer.Actualizar_Peso_Volumen__CargoPlan(objParametros)
    End Function

    Public Function Exportar_Reporte_Cargo_Plan_Fluvial(ByVal objEntidad As Solicitud_Transporte) As DataSet
        Dim oDs As New DataSet
        oDs = objDataAccessLayer.Exportar_Reporte_Cargo_Plan_Fluvial(objEntidad)
        Return oDs
    End Function

    Public Function Exportar_Reporte_Cargo_Plan_Terrestre_All(ByVal objEntidad As Solicitud_Transporte) As DataSet
        Return objDataAccessLayer.Exportar_Reporte_Cargo_Plan_Terrestre_All(objEntidad)
    End Function

    Public Function Exportar_Reporte_Cargo_Plan_Aereo_ALL(ByVal objEntidad As Solicitud_Transporte) As DataSet
        Return objDataAccessLayer.Exportar_Reporte_Cargo_Plan_Aereo_ALL(objEntidad)
    End Function

    Public Function Exportar_Reporte_Cargo_Plan_Fluvial_ALL(ByVal objEntidad As Solicitud_Transporte) As DataSet
        Return objDataAccessLayer.Exportar_Reporte_Cargo_Plan_Fluvial_ALL(objEntidad)
    End Function

    Public Function Verificar_Pesos_Volumen_Por_Solicitud(ByVal objEntidad As Solicitud_Transporte) As DataTable
        Return objDataAccessLayer.Verificar_Pesos_Volumen_Por_Solicitud(objEntidad)
    End Function

    Public Function Verificar_Pesos_Volumen_Por_Solicitud_Det(ByVal objEntidad As Solicitud_Transporte) As DataTable
        Return objDataAccessLayer.Verificar_Pesos_Volumen_Por_Solicitud_Det(objEntidad)
    End Function

    Public Function Actualizar_Fecha_Guia_Transportista(ByVal objParametros As Hashtable) As Int16
        Return objDataAccessLayer.Actualizar_Fecha_Guia_Transportista(objParametros)
    End Function

    Public Function TipoBusquedaDocumento() As DataTable
        Dim oDtTip As New DataTable
        Dim oDr As DataRow
        oDtTip.Columns.Add("COD", GetType(System.String))
        oDtTip.Columns.Add("TEX", GetType(System.String))
        oDr = oDtTip.NewRow
        oDr("COD") = "SOL"
        oDr("TEX") = "NRO.SOLICITUD"
        oDtTip.Rows.Add(oDr)
        oDr = oDtTip.NewRow
        oDr("COD") = "OPE"
        oDr("TEX") = "NRO. OPERACIÓN"
        oDtTip.Rows.Add(oDr)
        oDr = oDtTip.NewRow
        oDr("COD") = "GTR"
        oDr("TEX") = "NRO. GUÍA TRANSPORTE"
        oDtTip.Rows.Add(oDr)
        oDr = oDtTip.NewRow
        oDr("COD") = "GRM"
        oDr("TEX") = "NRO. GUÍA REMISIÓN"
        oDtTip.Rows.Add(oDr)
        oDr = oDtTip.NewRow
        oDr("COD") = "PRF"
        oDr("TEX") = "NRO. PRE FACTURA"
        oDtTip.Rows.Add(oDr)
        oDr = oDtTip.NewRow
        oDr("COD") = "PRL"
        oDr("TEX") = "NRO. PRE LIQUIDACIÓN"
        oDtTip.Rows.Add(oDr)
        oDr = oDtTip.NewRow
        oDr("COD") = "FAC"
        oDr("TEX") = "NRO. FACTURA"
        oDtTip.Rows.Add(oDr)
        Return oDtTip
    End Function

    Public Function Obtener_Validacion_Homologacion_Proveedor(ByVal objParametros As Hashtable) As String
        Dim strResultado As String = ""
        Dim strCodigoSAP As String = ""
        Dim objHashTable As Hashtable

        objHashTable = New Hashtable
        objHashTable.Add("CCMPN", objParametros("CCMPN"))
        objHashTable.Add("NRUCTR", objParametros("NRUCTR"))
        strCodigoSAP = Obtener_Codigo_SAP_Proveedor(objHashTable)
        If strCodigoSAP = "" Then
            strResultado = "Proveedor no cuenta con su Código SAP"
        Else
            strCodigoSAP = strCodigoSAP.Trim.PadLeft(10, "0")
            objHashTable = New Hashtable
            objHashTable.Add("LIFNR", strCodigoSAP)
            objHashTable.Add("FECVRF", objParametros("FECVRF"))
            objHashTable.Add("CCMPN", objParametros("CCMPN"))
            Dim objHashResultado As Hashtable = objDataAccessLayer.Obtener_Validacion_Homologacion_Proveedor(objHashTable)
            Select Case objHashResultado("STSASF")
                Case 0, 4
                    strResultado = ""
                Case Else
                    strResultado = objHashResultado("STSERR").ToString.Trim
            End Select
        End If

        Return strResultado
    End Function

    Public Function Obtener_Codigo_SAP_Proveedor(ByVal objParametros As Hashtable) As String
        Return objDataAccessLayer.Obtener_Codigo_SAP_Proveedor(objParametros)
    End Function

    Public Function Validar_Unidades_Atendidas(ByVal lintNroSolicitud As Int64, ByVal lstrCompania As String) As Integer
        Return objDataAccessLayer.Validar_Unidades_Atendidas(lintNroSolicitud, lstrCompania)
    End Function

    Public Function Validar_Unidades_Asignadas(ByVal lintNroSolicitud As Int64, ByVal lstrCompania As String) As Integer
        Return objDataAccessLayer.Validar_Unidades_Asignadas(lintNroSolicitud, lstrCompania)
    End Function

    Public Function Actualizar_Peso_Volumen_Viaje_Consolidado(ByVal objParametros As Hashtable) As Int32
        Return objDataAccessLayer.Actualizar_Peso_Volumen_Viaje_Consolidado(objParametros)
    End Function

    Public Function Cerrar_Solicitud_Transporte(ByVal objEntidad As Solicitud_Transporte) As Solicitud_Transporte
        Return objDataAccessLayer.Cerrar_Solicitud_Transporte(objEntidad)
    End Function

    Public Function Validar_Solicitud_Transporte(ByVal lintNroSolicitud As Int64, ByVal lstrCompania As String) As Integer
        Return objDataAccessLayer.Validar_Solicitud_Transporte(lintNroSolicitud, lstrCompania)
    End Function
End Class
