Imports SOLMIN_ST.DATOS.Mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports System.Collections.Generic
Namespace mantenimientos
    Public Class TipoCapacitacionConductor_BLL
        Dim objDataAccessLayer As New TipoCapacitacionConductor_DAL

        Public Function Registrar_TipoCapacitacionConductor(ByVal objEntidad As TipoCapacitacionConductor) As TipoCapacitacionConductor
            Return objDataAccessLayer.Registrar_TipoCapacitacionConductor(objEntidad)
        End Function

        Public Function Modificar_TipoCapacitacionConductor(ByVal objEntidad As TipoCapacitacionConductor) As TipoCapacitacionConductor
            Return objDataAccessLayer.Modificar_TipoCapacitacionConductor(objEntidad)
        End Function

        Public Function Eliminar_TipoCapacitacionConductor(ByVal objEntidad As TipoCapacitacionConductor) As TipoCapacitacionConductor
            Return objDataAccessLayer.Eliminar_TipoCapacitacionConductor(objEntidad)
        End Function

        Public Function Listar_TipoCapacitacionConductor(ByVal objEntidad As TipoCapacitacionConductor) As List(Of TipoCapacitacionConductor)
            'Try
            Return objDataAccessLayer.Listar_TipoCapacitacionConductor(objEntidad)
            'Catch
            '    Return New List(Of TipoCapacitacionConductor)
            'End Try
        End Function
    End Class
End Namespace

