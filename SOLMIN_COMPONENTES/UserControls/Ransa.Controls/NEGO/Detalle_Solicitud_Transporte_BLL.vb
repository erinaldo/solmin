

Public Class Detalle_Solicitud_Transporte_BLL
    Dim objDataAccessLayer As New Detalle_Solicitud_Transporte_DAL

    Public Function Listar_Detalle_Solicitud(ByVal objParametro As Hashtable) As List(Of Detalle_Solicitud_Transporte)
        Return objDataAccessLayer.Listar_Detalle_Solicitud(objParametro)
    End Function

    Public Function Listar_Cliente_Solicitud(ByVal objParamList As List(Of String)) As List(Of Solicitud_Transporte)
        Return objDataAccessLayer.Listar_Cliente_Solicitud(objParamList)
    End Function

    Public Function Listar_Transportista_Solicitud() As List(Of mantenimiento.Transportista)
        Return objDataAccessLayer.Listar_Transportista_Solicitud()
    End Function

    Public Function Listar_Vehiculo_Solicitud(ByVal objParamList As List(Of String)) As List(Of Detalle_Solicitud_Transporte)
        Return objDataAccessLayer.Listar_Vehículo_Solicitud(objParamList)
    End Function

    Public Function Listar_Vehiculo_Solicitud(ByVal objEntidad As Detalle_Solicitud_Transporte) As List(Of Detalle_Solicitud_Transporte)
        Return objDataAccessLayer.Listar_Vehículo_Solicitud(objEntidad)
    End Function

    Public Function Listar_Acoplado_Solicitud(ByVal lstr_transportista As String) As List(Of TransportistaAcoplado)
        Return objDataAccessLayer.Listar_Acoplado_Solicitud(lstr_transportista)
    End Function

    Public Function Listar_Conductor_Solicitud(ByVal lstr_transportista As String, ByVal strCompania As String) As List(Of TransportistaConductor)
        Return objDataAccessLayer.Listar_Conductor_Solicitud(lstr_transportista, strCompania)
    End Function

    Public Function Filtrar_Solicitud_Atendida(ByVal objEntidad As Detalle_Solicitud_Transporte) As List(Of Detalle_Solicitud_Transporte)
        Return objDataAccessLayer.Filtrar_Solicitud_Atendida(objEntidad)
    End Function

    Public Function Registra_Solicitud_Detalle(ByVal llist_Entidad As List(Of Detalle_Solicitud_Transporte)) As Detalle_Solicitud_Transporte
        Dim obj_Entidad As New Detalle_Solicitud_Transporte
        Try
            For Each objEntidad As Detalle_Solicitud_Transporte In llist_Entidad
                obj_Entidad.NCSOTR = objDataAccessLayer.Registrar_Detalle_Solicitud(objEntidad).NCSOTR
            Next
        Catch ex As Exception
            obj_Entidad.NCSOTR = "0"
        End Try
        Return obj_Entidad
    End Function

    Public Function Registra_Solicitud_Detalle(ByVal objEntidad As Detalle_Solicitud_Transporte) As Detalle_Solicitud_Transporte
        Return objDataAccessLayer.Registrar_Detalle_Solicitud(objEntidad)
    End Function

    Public Function Modifica_Solicitud_Detalle(ByVal objEntidad As Detalle_Solicitud_Transporte) As Detalle_Solicitud_Transporte
        Return objDataAccessLayer.Modificar_Detalle_Solicitud(objEntidad)
    End Function

    Public Function Elimina_Solicitud_Detalle(ByVal objEntidad As Detalle_Solicitud_Transporte) As Detalle_Solicitud_Transporte
        Return objDataAccessLayer.Eliminar_Detalle_Solicitud(objEntidad)
    End Function

    Public Function Actualizar_Solicitud_Transporte(ByVal objEntidad As Detalle_Solicitud_Transporte) As Detalle_Solicitud_Transporte
        Return objDataAccessLayer.Actualizar_Solicitud_Transporte(objEntidad)
    End Function

    Public Function Actualizar_Vehiculo(ByVal objEntidad As Detalle_Solicitud_Transporte) As Detalle_Solicitud_Transporte
        Return objDataAccessLayer.Actualizar_Vehiculo(objEntidad)
    End Function

    Public Function Actualizar_Recursos_Asignados_Solicitud(ByVal objEntidad As Detalle_Solicitud_Transporte) As Detalle_Solicitud_Transporte
        Return objDataAccessLayer.Actualizar_Recursos_Asignados_Solicitud(objEntidad)
    End Function

    Public Function Validar_Existencias_PAG(ByVal objEntidad As Detalle_Solicitud_Transporte) As Detalle_Solicitud_Transporte
        Return objDataAccessLayer.Validar_Existencias_PAG(objEntidad)
    End Function
    Public Function Listar_Cliente_Solicitud_Programacion(ByVal objEntidad As Solicitud_Transporte) As DataTable
        Return objDataAccessLayer.Listar_Cliente_Solicitud_Programacion(objEntidad)
    End Function
    Public Function Listar_Datos_Solicitud_Validacion(ByVal objEntidad As Detalle_Solicitud_Transporte) As DataSet
        Return objDataAccessLayer.Listar_Datos_Solicitud_Validacion(objEntidad)
    End Function
    Public Function Listar_Juntas_x_Solicitud(ByVal NCSOTR As Decimal, ByVal CCMPN As String) As DataTable
        Return objDataAccessLayer.Listar_Juntas_x_Solicitud(NCSOTR, CCMPN)
    End Function
End Class
