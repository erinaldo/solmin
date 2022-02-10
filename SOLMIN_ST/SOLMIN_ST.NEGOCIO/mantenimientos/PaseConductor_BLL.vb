'*********************************************************************'
'** Autor: Juan De Dios Leon                                        **'
'** Fecha de Creación: 31/07/2009                                   **'
'** Descripción: CAPA DE NEGOCIO                                    **'
'*********************************************************************'
Imports SOLMIN_ST.DATOS.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Namespace mantenimientos

    'tabla RZST10
    Public Class PaseConductor_BLL

        Private objDataAccessLayer As New PaseConductor_DAL

        Public Function Registra_Pases(ByVal objEntidad As PaseConductor) As PaseConductor
            Return objDataAccessLayer.Registrar_PaseConductor(objEntidad)
        End Function

        Public Function Modifica_Pases(ByVal objEntidad As PaseConductor) As PaseConductor
            Return objDataAccessLayer.Modificar_PaseConductor(objEntidad)
        End Function

        Public Function Elimina_Pases(ByVal objEntidad As PaseConductor) As PaseConductor
            Return objDataAccessLayer.Eliminar_PaseConductor(objEntidad)
        End Function

        Public Function Lista_Pases(ByVal objEntidad As PaseConductor) As List(Of PaseConductor)
            'Try
            Return objDataAccessLayer.Listar_PaseConductor(objEntidad)
            'Catch
            '    Return New List(Of PaseConductor)
            'End Try
        End Function

        Public Function Lista_Pases_Chofer_DT(ByVal objEntidad As PaseConductor) As DataTable
            Return objDataAccessLayer.Listado_Pases_x_Conductor_DT(objEntidad)
        End Function

        Public Function Listar_VencimientoPase_Reporte(ByVal ht As Hashtable) As List(Of PaseConductor)
            Return objDataAccessLayer.Listar_VencimientoPase_Reporte(ht)
        End Function

    End Class

End Namespace
