Imports SOLMIN_ST.DATOS.Mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports System.Collections.Generic

Namespace mantenimientos
    Public Class TransportistaConductor_BLL
        Dim objDataAccessLayer As New TransportistaConductor_DAL

        Public Function Registrar_TransportistaConductor(ByVal objEntidad As TransportistaConductor) As TransportistaConductor
            Return objDataAccessLayer.Registrar_TransportistaConductor(objEntidad)
        End Function

        Public Sub Eliminar_TransportistaConductor(ByVal objEntidad As TransportistaConductor)
            objDataAccessLayer.Eliminar_TransportistaConductor(objEntidad)
        End Sub

        Public Function Listar_ConductoresPorTransportista(ByVal objEntidad As TransportistaConductor, IN_NROPAG As Decimal, PAGESIZE As Decimal, ByRef TOTPAG As Decimal) As List(Of TransportistaConductor)
            'Try
            Return objDataAccessLayer.Listar_TransportistaConductor(objEntidad, IN_NROPAG, PAGESIZE, TOTPAG)
            'Catch
            '    Return New List(Of TransportistaConductor)
            'End Try
        End Function

        Public Function Listar_ConductoresPorTransportista_Reporte(ByVal objEntidad As TransportistaConductor) As DataTable
            Return objDataAccessLayer.Listar_TransportistaConductor_Reporte(objEntidad)
        End Function

        Public Function Listar_Transportista_x_Conductor(ByVal objEntidad As Chofer) As List(Of TransportistaConductor)
            Return objDataAccessLayer.Listar_Transportista_x_Conductor(objEntidad)
        End Function

        Public Function Listar_TransportistaConductor_Historial(ByVal objEntidad As TransportistaConductor) As DataTable
            Return objDataAccessLayer.Listar_TransportistaConductor_Historial(objEntidad)
        End Function

        Public Function Listar_TransportistaConductor_Historial_Rpt(ByVal objEntidad As TransportistaConductor) As DataTable
            Return objDataAccessLayer.Listar_TransportistaConductor_Historial_Rpt(objEntidad)
        End Function

    End Class
End Namespace

