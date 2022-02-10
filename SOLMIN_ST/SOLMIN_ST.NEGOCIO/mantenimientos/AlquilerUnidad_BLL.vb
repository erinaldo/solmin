Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.DATOS

Public Class AlquilerUnidad_BLL
    Dim objDataAccessLayer As New AlquilerUnidad_DAL

    Public Function Listar_Alquiler_Unidad(ByVal objEntidad As AlquilerUnidad) As List(Of AlquilerUnidad)
        Return objDataAccessLayer.Listar_Alquiler_Unidad(objEntidad)
    End Function
    Public Function Listar_Recursos_Asignados(ByVal objEntidad As AlquilerUnidad) As List(Of AlquilerUnidad)
        Return objDataAccessLayer.Listar_Recursos_Asignados(objEntidad)
    End Function
    Public Function Registrar_Alquiler_Unidad(ByVal objEntidad As AlquilerUnidad) As AlquilerUnidad
        Return objDataAccessLayer.Registrar_Alquiler_Unidad(objEntidad)
    End Function

    Public Function Modificar_Alquiler_Unidad(ByVal objEntidad As AlquilerUnidad) As AlquilerUnidad
        Return objDataAccessLayer.Modificar_Alquiler_Unidad(objEntidad)
    End Function

    Public Function Eliminar_Alquiler_Unidad(ByVal objEntidad As AlquilerUnidad) As AlquilerUnidad
        Return objDataAccessLayer.Eliminar_Alquiler_Unidad(objEntidad)
    End Function
    '-2 EJECURA EL STROR PARA CERRAR EL ALQUILER 

    Public Function Cerrar_Alquiler_Unidad(ByVal objEntidad As AlquilerUnidad) As AlquilerUnidad
        Return objDataAccessLayer.Cerrar_Alquiler_Unidad(objEntidad)
    End Function

    Public Function Listar_Operacion_X_Proveedor(ByVal objEntidad As AlquilerUnidad) As List(Of AlquilerUnidad)
        Return objDataAccessLayer.Listar_Operacion_X_Proveedor(objEntidad)
    End Function

    Public Function Validar_Existe_Alquiler_Unidad(ByVal objEntidad As AlquilerUnidad) As List(Of AlquilerUnidad)
        Return objDataAccessLayer.Validar_Existe_Alquiler_Unidad(objEntidad)
    End Function

    Public Function Obtener_Datos_Alquiler_Unidad(ByVal objEntidad As AlquilerUnidad) As AlquilerUnidad
        Return objDataAccessLayer.Obtener_Datos_Alquiler_Unidad(objEntidad)
    End Function

    Public Function Generar_Orden_Interna_Alquiler(ByVal objEntidad As AlquilerUnidad) As AlquilerUnidad
        Return objDataAccessLayer.Generar_Orden_Interna_Alquiler(objEntidad)
    End Function

    Public Function Registrar_Operacion_Transporte_Alquiler(ByVal objEntidad As AlquilerUnidad) As AlquilerUnidad
        Return objDataAccessLayer.Registrar_Operacion_Transporte_Alquiler(objEntidad)
    End Function
    Public Function Procesar_Liquidacion_Alquiler(ByVal objEntidad As AlquilerUnidad) As AlquilerUnidad
        Return objDataAccessLayer.Procesar_Liquidacion_Alquiler(objEntidad)
    End Function
    Public Function Listar_Datos_Liquidacion_Alquiler(ByVal objEntidad As AlquilerUnidad) As DataTable
        Return objDataAccessLayer.Listar_Datos_Liquidacion_Alquiler(objEntidad)
    End Function
    Public Function Obtener_Operacion_Alquiler_Unidad(ByVal objEntidad As AlquilerUnidad) As DataTable
        Return objDataAccessLayer.Obtener_Operacion_Alquiler_Unidad(objEntidad)
    End Function
    Public Function Validar_Configuracion_Servicio_Alquiler(ByVal objEntidad As AlquilerUnidad, ByRef strMensajeError As String) As Boolean
        Return objDataAccessLayer.Validar_Configuracion_Servicio_Alquiler(objEntidad, strMensajeError)
    End Function
    Public Function Listar_Unidad_Alquiler_Operaciones_RPT(ByVal objEntidad As AlquilerUnidad) As DataTable
        Return objDataAccessLayer.Listar_Unidad_Alquiler_Operaciones_RPT(objEntidad)
    End Function

    Public Sub Eliminar_Operaciones_Alquiler(ByVal objEntidad As AlquilerUnidad)
        objDataAccessLayer.Eliminar_Operaciones_Alquiler(objEntidad)
    End Sub

    Public Sub Modificar_Alquiler_Unidad_Vigencia(ByVal objEntidad As AlquilerUnidad)
        objDataAccessLayer.Modificar_Alquiler_Unidad_Vigencia(objEntidad)
    End Sub
    Public Sub Actualizar_Alquiler_Unidad_Liquidacion(ByVal objEntidad As AlquilerUnidad)
        objDataAccessLayer.Actualizar_Alquiler_Unidad_Liquidacion(objEntidad)
    End Sub

End Class
