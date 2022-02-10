Imports SOLMIN_ST.DATOS.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Namespace mantenimientos
  Public Class VacacionesConductor_BLL
    Dim objDataAccessLayer As New VacacionesConductor_DAL

    Public Function Registrar_Vacaciones_Conductor(ByVal objEntidad As VacacionesConductor) As VacacionesConductor
      Return objDataAccessLayer.Registrar_Vacaciones_Conductor(objEntidad)
    End Function

    Public Function Modificar_Vacaciones_Conductor(ByVal objEntidad As VacacionesConductor) As VacacionesConductor
      Return objDataAccessLayer.Modificar_Vacaciones_Conductor(objEntidad)
    End Function

    Public Function Eliminar_Vacaciones_Conductor(ByVal objEntidad As VacacionesConductor) As VacacionesConductor
      Return objDataAccessLayer.Eliminar_Vacaciones_Conductor(objEntidad)
    End Function

    Public Function Listar_Vacaciones_Conductor(ByVal objEntidad As VacacionesConductor) As DataTable
      Return objDataAccessLayer.Listar_Vacaciones_Conductor(objEntidad)
    End Function

        Public Function Reporte_Vacaciones_Conductor(ByVal objEntidad As VacacionesConductor) As DataTable
            Return objDataAccessLayer.Reporte_Vacaciones_Conductor(objEntidad)
        End Function

        Public Function Listar_Vacaciones_Conductor_Rpt(ByVal objEntidad As VacacionesConductor) As DataTable
            Return objDataAccessLayer.Listar_Vacaciones_Conductor_Rpt(objEntidad)
        End Function

  End Class

End Namespace
