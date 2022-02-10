Public Class RequerimientoServicio_BLL

    Dim oDatos As New RequerimientoServicio_DAL


    Public Function Lista_Requerimiento_Servicio(ByVal ObjEntidad As RequerimientoServicio) As DataTable

        Return oDatos.Lista_Requerimiento_Servicio(ObjEntidad)

    End Function

    Public Function Lista_Tipo_Mercaderia() As DataTable
        Dim dt As New DataTable

        dt = oDatos.Lista_Tipo_Mercaderia()

        Return dt
    End Function


    Public Function intInsertarRequerimientoServicio(ByVal ObjEntidad As RequerimientoServicio) As Decimal

        Return oDatos.intInsertarRequerimientoServicio(ObjEntidad)

    End Function


    Public Sub intActualizarRequerimientoServicio(ByVal ObjEntidad As RequerimientoServicio)

        oDatos.intActualizarRequerimientoServicio(ObjEntidad)

    End Sub

    Public Function intEliminarRequerimientoServicio(ByVal ObjEntidad As RequerimientoServicio) As Integer

        Return oDatos.intEliminarRequerimientoServicio(ObjEntidad)

    End Function


    'Public Function intRevisarRequerimientoServicio(ByVal ObjEntidad As RequerimientoServicio) As Integer

    '    Return oDatos.intRevisarRequerimientoServicio(ObjEntidad)

    'End Function


    Public Function intActualizarRequerimientoSolicitud(ByVal ObjEntidad As RequerimientoServicio) As Integer

        Return oDatos.intActualizarRequerimientoSolicitud(ObjEntidad)

    End Function


    Public Function Registrar_Solicitud_Transporte_Requerimiento(ByVal objEntidad As Operaciones.Solicitud_Transporte) As Operaciones.Solicitud_Transporte
        Return oDatos.Registrar_Solicitud_Transporte_Requerimiento(objEntidad)
    End Function

    Public Function Lista_Requerimiento_Servicio_Estado_Actual(ByVal ObjEntidad As RequerimientoServicio) As RequerimientoServicio

        Return oDatos.Lista_Requerimiento_Servicio_Estado_Actual(ObjEntidad)

    End Function

    Public Function Lista_Negocio(ByVal CCMPN As String) As DataTable
        Dim dt As New DataTable

        dt = oDatos.Lista_Negocio(CCMPN)

        Return dt
    End Function

    Public Function olisListarResponsables(ByVal obeResponsable As beDestinatario) As List(Of beDestinatario)
        Return oDatos.olisListarResponsables(obeResponsable)
    End Function

    Public Function Listar_Solicitud_Transporte_Estado_Requerimiento(ByVal objEntidad As Operaciones.Solicitud_Transporte) As List(Of Operaciones.Solicitud_Transporte)
        Return oDatos.Listar_Solicitudes_Transporte_Estado_Requerimiento(objEntidad)
    End Function


    Public Function Obtener_Detalle_Solicitud_Asignada(ByVal objentidad As mantenimientos.ClaseGeneral) As List(Of mantenimientos.ClaseGeneral)
        Return oDatos.Obtener_Detalle_Solicitud_Asignada(objentidad)
    End Function

    Public Function Lista_Unidades_Programadas(ByVal CCMPN As String, ByVal NUMREQT As Decimal, ByVal SESASG As String) As List(Of Programacion_Unidad)

        Return oDatos.Lista_Unidades_Programadas(CCMPN, NUMREQT, SESASG)

    End Function

    Public Function Listar_Estado_Solicitud_Requerimiento(ByVal objEntidad As Operaciones.Solicitud_Transporte) As List(Of Operaciones.Solicitud_Transporte)
        Return oDatos.Listar_Estado_Solicitud_Requerimiento(objEntidad)
    End Function

    Public Function Obtener_Detalle_Solicitud_Asignada_X_Requerimiento(ByVal objentidad As mantenimientos.ClaseGeneral) As List(Of mantenimientos.ClaseGeneral)
        Return oDatos.Obtener_Detalle_Solicitud_Asignada_X_Requerimiento(objentidad)
    End Function

    Public Function Obtener_NroImagen_X_Requerimiento_Servicio(ByVal ObjEntidad As RequerimientoServicio) As List(Of RequerimientoServicio)
        Return oDatos.Obtener_NroImagen_X_Requerimiento_Servicio(ObjEntidad)
    End Function
    Public Function Lista_Prioridad_Requerimiento() As DataTable
        Return oDatos.Lista_Prioridad_Requerimiento()
    End Function

    'Public Function Lista_Requerimiento_Servicio_Exportar(ByVal ObjEntidad As RequerimientoServicio) As DataTable
    '    Return oDatos.Lista_Requerimiento_Servicio_Exportar(ObjEntidad)
    'End Function

    Public Function Lista_Requerimiento_Servicio_Detalle_Exportar(ByVal ObjEntidad As RequerimientoServicio) As DataTable
        Return oDatos.Lista_Requerimiento_Servicio_Detalle_Exportar(ObjEntidad)
    End Function

End Class