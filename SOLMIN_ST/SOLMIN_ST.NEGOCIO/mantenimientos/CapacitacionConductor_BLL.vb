Imports SOLMIN_ST.DATOS.Mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports System.Collections.Generic

Namespace mantenimientos

    Public Class CapacitacionConductor_BLL

        Dim objDataAccessLayer As New CapacitacionConductor_DAL

        Public Function Registrar_CapacitacionConductor(ByVal objEntidad As CapacitacionConductor) As CapacitacionConductor
            Return objDataAccessLayer.Registrar_CapacitacionConductor(objEntidad)
        End Function

        Public Function Modificar_CapacitacionConductor(ByVal objEntidad As CapacitacionConductor) As CapacitacionConductor
            Return objDataAccessLayer.Modificar_CapacitacionConductor(objEntidad)
        End Function

        Public Function Eliminar_CapacitacionConductor(ByVal objEntidad As CapacitacionConductor) As CapacitacionConductor
            Return objDataAccessLayer.Eliminar_CapacitacionConductor(objEntidad)
        End Function

        Public Function Listar_CapacitacionConductor(ByVal objEntidad As CapacitacionConductor) As List(Of CapacitacionConductor)
            'Try
            Return objDataAccessLayer.Listar_CapacitacionConductor(objEntidad)

            'Catch
            '    Return New List(Of CapacitacionConductor)
            'End Try
        End Function

        Public Function Listar_CapacitacionConductor_Reporte(ByVal objEntidad As CapacitacionConductor) As DataTable
            Return objDataAccessLayer.Listar_CapacitacionConductor_Reporte(objEntidad)
        End Function

        Public Function Listar_VencimientoCapacitacion_Reporte(ByVal ht As Hashtable) As List(Of CapacitacionConductor)
            Return objDataAccessLayer.Listar_VencimientoCapacitacion_Reporte(ht)
        End Function

    End Class

End Namespace
