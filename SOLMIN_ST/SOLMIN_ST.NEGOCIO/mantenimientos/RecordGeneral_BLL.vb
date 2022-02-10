Imports SOLMIN_ST.DATOS.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
'****************************************************************************************************
'** Autor: Anddy Ramos
'** Fecha de Creación: 08/08/2009 
'** Descripción: capa de negocio.
'****************************************************************************************************
Namespace mantenimientos
    Public Class RecordGeneral_BLL
        Dim objDataAccessLayer As New RecordGeneral_DAL
        Public Function Registrar_Record_General_Inactivacion_Reactivacion(ByVal objEntidad As RecordGeneral) As Int32
            Return objDataAccessLayer.Registrar_Record_General_Inactivacion_Reactivacion(objEntidad)
        End Function

        Public Function Registrar_Record_General(ByVal objEntidad As RecordGeneral) As RecordGeneral
            Return objDataAccessLayer.Registrar_Record_General(objEntidad)
        End Function

        Public Function Modificar_Record_General(ByVal objEntidad As RecordGeneral) As RecordGeneral
            Return objDataAccessLayer.Modificar_Record_General(objEntidad)
        End Function

        Public Function Eliminar_Record_General(ByVal objEntidad As RecordGeneral) As RecordGeneral
            Return objDataAccessLayer.Eliminar_Record_General(objEntidad)
        End Function

        Public Function Listar_Record_General(ByVal objEntidad As RecordGeneral) As List(Of RecordGeneral)
            'Try
            Return objDataAccessLayer.Listar_Record_General(objEntidad)
            'Catch
            '    Return New List(Of RecordGeneral)
            'End Try
        End Function

        Public Function Listar_Record_General_DT(ByVal objEntidad As RecordGeneral) As DataTable
            Return objDataAccessLayer.Listar_Record_General_DT(objEntidad)
        End Function
    End Class
End Namespace