Imports SOLMIN_ST.DATOS.Mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports System.Collections.Generic
Namespace mantenimientos

    Public Class TransportistaTracto_BLL
        Dim objDataAccessLayer As New TransportistaTracto_DAL

        Public Function Existe_TransportistaTracto(ByVal objEntidad As TransportistaTracto) As TransportistaTracto
            Return objDataAccessLayer.Existe_TransportistaTracto(objEntidad)
        End Function

        Public Function Registrar_TransportistaTracto(ByVal objEntidad As TransportistaTracto) As TransportistaTracto
            Return objDataAccessLayer.Registrar_TransportistaTracto(objEntidad)
        End Function

        Public Function Registrar_TransportistaTracto_Acoplado_Conductor_TipoCarroceris(ByVal objEntidad As TransportistaTracto) As TransportistaTracto
            Return objDataAccessLayer.Registrar_Transportista_Tracto_Acoplado_Conductor_Carroceria(objEntidad)
        End Function

        Public Sub Eliminar_TransportistaTracto(ByVal objEntidad As TransportistaTracto)
            'Return objDataAccessLayer.Eliminar_TransportistaTracto(objEntidad)
            objDataAccessLayer.Eliminar_TransportistaTracto(objEntidad)
        End Sub

        Public Function Modificar_TransportistaTracto(ByVal objEntidad As TransportistaTracto) As TransportistaTracto
            Return objDataAccessLayer.Modificar_TransportistaTracto(objEntidad)
        End Function

        Public Function Listar_TractosPorTransportista(ByVal objEntidad As TransportistaTracto, IN_NROPAG As Decimal, PAGESIZE As Decimal, ByRef TOTPAG As Decimal) As DataTable 'List(Of TransportistaTracto)
            'Try
            Return objDataAccessLayer.Listar_TractosPorTransportista(objEntidad, IN_NROPAG, PAGESIZE, TOTPAG)
            'Catch
            '    Return New DataTable
            'End Try
        End Function

        Public Function Listar_TractosPorTransportista_Reporte(ByVal objEntidad As TransportistaTracto) As DataTable
            Return objDataAccessLayer.Listar_TractosPorTransportista_Reporte(objEntidad)
        End Function

        Public Function Listar_Transportista_x_Tracto(ByVal objEntidad As Tracto) As List(Of TransportistaTracto)
            Return objDataAccessLayer.Listar_Transportista_x_Tracto(objEntidad)
        End Function

        Public Function Listar_Tracto_X_Transportista(ByVal objEntidad As TransportistaTracto) As List(Of TransportistaTracto)
            Return objDataAccessLayer.Listar_Tracto_X_Transportista(objEntidad)
        End Function

        Public Function Obtener_Informacion_Tracto(ByVal objEntidad As TransportistaTracto) As TransportistaTracto
            Return objDataAccessLayer.Obtener_Informacion_Tracto(objEntidad)
        End Function

        Public Function Listar_Transportista_X_Vehiculo(ByVal objEntidad As TransportistaTracto) As List(Of TransportistaTracto)
            Return objDataAccessLayer.Listar_Transportista_X_Vehiculo(objEntidad)
        End Function

        Public Function Listar_TractosPorTransportista_Propio(ByVal objEntidad As TransportistaTracto) As DataTable 'List(Of TransportistaTracto)
            Try
                Return objDataAccessLayer.Listar_TractosPorTransportista_Propio(objEntidad)
            Catch
                Return New DataTable
            End Try
        End Function

        Public Function Registrar_TransportistaTracto_V2(ByVal objEntidad As TransportistaTracto) As TransportistaTracto
            Return objDataAccessLayer.Registrar_TransportistaTracto_V2(objEntidad)
        End Function

    End Class
End Namespace