Imports SOLMIN_ST.DATOS.Operaciones
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Namespace Operaciones
  Public Class Junta_Transporte_BLL
    Dim objDataAccessLayer As New Junta_Transporte_DAL

    Public Function Existe_Junta_Pendiente_Transporte(ByVal objEntidad As Junta_Transporte) As Junta_Transporte
      Return objDataAccessLayer.Existe_Junta_Pendiente_Transporte(objEntidad)
    End Function

    Public Function Registrar_Junta_Transporte(ByVal objEntidad As Junta_Transporte) As Junta_Transporte
      Return objDataAccessLayer.Registrar_Junta_Transporte(objEntidad)
    End Function

        'Public Function Registrar_Junta_Transporte_Manual(ByVal objEntidad As Detalle_Solicitud_Transporte) As Detalle_Solicitud_Transporte
        '  Return objDataAccessLayer.Registrar_Junta_Transporte_Manual(objEntidad)
        'End Function

        Public Function Registrar_Detalle_Solicitud_Transporte(ByVal objEntidad As Detalle_Solicitud_Transporte, ByRef msg As String) As beRespuestaOperacion
            Return objDataAccessLayer.Registrar_Detalle_Solicitud_Transporte(objEntidad, msg)
        End Function

    Public Function Modificar_Junta_Transporte(ByVal objEntidad As Junta_Transporte) As Junta_Transporte
      Return objDataAccessLayer.Modificar_Junta_Transporte(objEntidad)
    End Function

    Public Function Eliminar_Junta_Transporte(ByVal objEntidad As Junta_Transporte) As Junta_Transporte
      Return objDataAccessLayer.Eliminar_Junta_Transporte(objEntidad)
    End Function

    Public Function Actualizar_Solicitud_Detalle(ByVal objEntidad As Junta_Transporte) As Junta_Transporte
      Return objDataAccessLayer.Actualizar_Detalle_Solicitud(objEntidad)
    End Function

    Public Function Listar_Junta_Transporte(ByVal objParamList As List(Of String)) As List(Of Junta_Transporte)
      Return objDataAccessLayer.Listar_Junta_Transporte(objParamList)
    End Function

    Public Function Actualizar_Junta_Transporte(ByVal objEntidad As Junta_Transporte) As Junta_Transporte
      Return objDataAccessLayer.Actualizar_Junta_Transporte(objEntidad)
    End Function

    Public Function Listar_Junta_Transporte_Detalle(ByVal objParamList As List(Of String)) As List(Of ClaseGeneral)
      Return objDataAccessLayer.Listar_Junta_Transporte_Detalle(objParamList)
    End Function

    Public Function Listar_Operaciones_Asignadas(ByVal objEntidad As Junta_Transporte) As List(Of ClaseGeneral)
      Return objDataAccessLayer.Listar_Operaciones_Asignadas(objEntidad)
    End Function

    Public Sub RollBack_Junta_Transportista(ByVal objEntidad As Junta_Transporte)
      objDataAccessLayer.RollBack_Junta_Transportista(objEntidad)
    End Sub

    Public Sub RollBack_Solicitud_Detalle(ByVal objEntidad As Junta_Transporte)
      objDataAccessLayer.RollBack_Detalle_Solicitud(objEntidad)
    End Sub

    Public Function Listar_Solicitudes_x_Junta(ByVal objEntidad As Junta_Transporte) As List(Of Object)
      Return objDataAccessLayer.Listar_Solicitudes_x_Junta_Transporte(objEntidad)
    End Function

    Public Function Lista_Reporte_Junta_Transporte(ByVal objParamList As List(Of String)) As List(Of ClaseGeneral)
      Return objDataAccessLayer.Lista_Reporte_Junta_Transporte(objParamList)
    End Function

    Public Function Lista_Viajes_Realizados(ByVal objParamList As Hashtable) As List(Of ClaseGeneral)
      Return objDataAccessLayer.Lista_Viajes_Realizados(objParamList)
    End Function

        Public Function Lista_Solicitud_Programas_x_Junta(ByVal obj As Junta_Transporte) As DataTable
            Return objDataAccessLayer.Lista_Solicitud_Programas_x_Junta(obj)
        End Function
        Public Sub Guardar_Junta_Solicitud_Programado(ByVal obj As Detalle_Junta_Transporte)
            objDataAccessLayer.Guardar_Junta_Solicitud_Programado(obj)
        End Sub
        Public Sub Eliminar_Junta_Solicitud_Programado(ByVal obj As Detalle_Junta_Transporte)
            objDataAccessLayer.Eliminar_Junta_Solicitud_Programado(obj)
        End Sub

    End Class

End Namespace

