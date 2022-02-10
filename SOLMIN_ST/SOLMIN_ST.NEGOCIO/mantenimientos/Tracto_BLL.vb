Imports SOLMIN_ST.DATOS.Mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports System.Collections.Generic

Namespace mantenimientos
    Public Class Tracto_BLL
        Dim objDataAccessLayer As New Tracto_DAL

        Public Function Registrar_Tracto(ByVal objEntidad As Tracto) As Tracto
            Return objDataAccessLayer.Registrar_Tracto(objEntidad)
        End Function
       

        Public Function Registrar_Tracto_Antiguo(ByVal objEntidad As Tracto) As Tracto
            Return objDataAccessLayer.Registrar_Tracto_Antiguo(objEntidad)
        End Function

        Public Function Modificar_Tracto(ByVal objEntidad As Tracto) As Tracto
            Return objDataAccessLayer.Modificar_Tracto(objEntidad)
        End Function

        Public Function Cambiar_Estado_Tracto(ByVal objEntidad As Tracto) As Tracto
            Return objDataAccessLayer.Cambiar_Estado_Tracto(objEntidad)
        End Function

        Public Function Eliminar_Tracto(ByVal objEntidad As Tracto) As Tracto
            Return objDataAccessLayer.Eliminar_Tracto(objEntidad)
        End Function

        Public Function Listar_Tracto(ByVal objEntidad As Tracto) As List(Of Tracto)
            'Try
            Return objDataAccessLayer.Listar_Tracto(objEntidad)
            'Catch
            '    Return New List(Of Tracto)
            'End Try
        End Function

        Public Function Listar_Tracto_X_Transportista(ByVal objEntidad As TransportistaTracto) As List(Of Tracto)
            'Try
            Return objDataAccessLayer.Listar_Tracto_X_Transportista(objEntidad)
            'Catch
            '    Return New List(Of Tracto)
            'End Try
        End Function

        Public Function Listar_Tracto_X_Transportista_AS400(ByVal objetoParametro As Hashtable) As List(Of Tracto)
            'Try
            Return objDataAccessLayer.Listar_Tracto_x_Transportista_AS400(objetoParametro)
            'Catch
            '    Return New List(Of Tracto)
            'End Try
        End Function

        Public Function Listar_Tractos_Transportista_Propio(ByVal strCompania As String) As DataTable
            Return objDataAccessLayer.Listar_Posicion_GPS_Flota_Propia(strCompania)
        End Function

        Public Function Busca_Tracto(ByVal objEntidad As Tracto) As List(Of Tracto)
            'Try
            Return objDataAccessLayer.Buscar_Tracto(objEntidad)
            'Catch
            '    Return New List(Of Tracto)
            'End Try
        End Function

        Public Function Obtener_Tracto(ByVal objEntidad As Tracto) As List(Of Tracto)
            Return objDataAccessLayer.Obtener_Tracto(objEntidad)
        End Function

        Public Function Lista_Vehiculos_Fluviales(ByVal objEntidad As Tracto) As DataTable
            Return objDataAccessLayer.Lista_Vehiculos_Fluviales(objEntidad)
        End Function

        Public Function Registrar_Bitacora_Vehiculo(ByVal objEntidad As Tracto) As Tracto
            Return objDataAccessLayer.Registrar_Bitacora_Vehiculo(objEntidad)
        End Function

        Public Function Listar_Bitacora_Vehiculo(ByVal objEntidad As Tracto) As List(Of Tracto)
            'Try
            Return objDataAccessLayer.Listar_Bitacora_Vehiculo(objEntidad)
            'Catch
            '    Return New List(Of Tracto)
            'End Try
        End Function

        Public Function Eliminar_Bitacora_Vehiculo(ByVal objEntidad As Tracto) As Tracto
            Return objDataAccessLayer.Eliminar_Bitacora_Vehiculo(objEntidad)
        End Function

        Public Function Listar_Control_Flota(ByVal objEntidad As Tracto) As List(Of Tracto)
            'Try
            Return objDataAccessLayer.Listar_Control_Flota(objEntidad)
            'Catch
            '    Return New List(Of Tracto)
            'End Try
        End Function

        Public Function Modificar_Asignacion_Tracto_Transportista(ByVal objEntidad As Tracto) As Int32
            Return objDataAccessLayer.Modificar_Asignacion_Tracto_Transportista(objEntidad)
        End Function

        Public Function Obtener_Asignacion_Tracto_Transportista(ByVal objEntidad As Tracto) As List(Of Tracto)
            Return objDataAccessLayer.Obtener_Asignacion_Tracto_Transportista(objEntidad)
        End Function

        Public Function Buscar_Tracto_Paginado(ByVal objEntidad As Tracto, ByRef TotalPaginas As Decimal) As DataTable
            Return objDataAccessLayer.Buscar_Tracto_Paginado(objEntidad, TotalPaginas)
        End Function

    End Class
End Namespace