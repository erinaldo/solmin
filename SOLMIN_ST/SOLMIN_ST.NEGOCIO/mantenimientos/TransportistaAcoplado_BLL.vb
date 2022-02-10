Imports SOLMIN_ST.DATOS.Mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports System.Collections.Generic
Namespace mantenimientos
    Public Class TransportistaAcoplado_BLL
        Dim objDataAccessLayer As New TransportistaAcoplado_DAL

        Public Function Registrar_TransportistaAcoplado(ByVal objEntidad As TransportistaAcoplado) As TransportistaAcoplado
            Return objDataAccessLayer.Registrar_TransportistaAcoplado(objEntidad)
        End Function

        Public Sub Eliminar_TransportistaAcoplado(ByVal objEntidad As TransportistaAcoplado)
            ' Return objDataAccessLayer.Eliminar_TransportistaAcoplado(objEntidad)
            objDataAccessLayer.Eliminar_TransportistaAcoplado(objEntidad)
        End Sub

        Public Function Listar_AcopladosPorTransportista(ByVal objEntidad As TransportistaAcoplado, IN_NROPAG As Decimal, PAGESIZE As Decimal, ByRef TOTPAG As Decimal) As List(Of TransportistaAcoplado)
            'Try
            Return objDataAccessLayer.Listar_AcopladosPorTransportista(objEntidad, IN_NROPAG, PAGESIZE, TOTPAG)
            'Catch
            '    Return New List(Of TransportistaAcoplado)
            'End Try
        End Function

        Public Function Listar_AcopladosPorTransportista_Reporte(ByVal objEntidad As TransportistaAcoplado) As DataTable
            Return objDataAccessLayer.Listar_AcopladosPorTransportista_Reporte(objEntidad)
        End Function

        Public Function Listar_Transportista_x_Acoplado(ByVal objEntidad As Acoplado) As List(Of TransportistaAcoplado)
            Return objDataAccessLayer.Listar_Transportista_x_Acoplado(objEntidad)
        End Function


        Public Function Listar_AcopladosPorTransportista_Reporte_Propio(ByVal objEntidad As TransportistaAcoplado) As DataTable
            Return objDataAccessLayer.Listar_AcopladosPorTransportista_Reporte_Propio(objEntidad)
        End Function

        Public Function Registrar_TransportistaAcoplado_V2(ByVal objEntidad As TransportistaAcoplado) As TransportistaAcoplado
            Return objDataAccessLayer.Registrar_TransportistaAcoplado_V2(objEntidad)
        End Function

    End Class
End Namespace