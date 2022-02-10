Imports SOLMIN_ST.DATOS
Imports SOLMIN_ST.ENTIDADES
Namespace mantenimientos
    Public Class AsignacionRuta_BLL

        Dim objDataAccessLayer As New AsignacionRuta_DAL

        Public Function ListarAsignacion_Km_AVC_Ruta(ByVal objEntidad As AsignacionRuta) As List(Of AsignacionRuta)
            Return objDataAccessLayer.ListarAsignacion_Km_AVC_Ruta(objEntidad)
        End Function

        Public Sub MantenimientoAsignacion_Km_AVC_Ruta(ByVal objEntidad As AsignacionRuta)
            Try
                objDataAccessLayer.MantenimientoAsignacion_Km_AVC_Ruta(objEntidad)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try


        End Sub

    End Class

End Namespace
