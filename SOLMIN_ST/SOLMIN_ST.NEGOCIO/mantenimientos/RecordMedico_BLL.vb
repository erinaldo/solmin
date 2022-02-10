Imports SOLMIN_ST.DATOS.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
'****************************************************************************************************
'** Autor: Anddy Ramos
'** Fecha de Creación: 30/07/2009 
'** Descripción: capa de negocio.
'****************************************************************************************************
Namespace mantenimientos
    Public Class RecordMedico_BLL
        Dim objDataAccessLayer As New RecordMedico_DAL

        Public Function Registrar_Record_Medico(ByVal objEntidad As RecordMedico) As RecordMedico
            'Try
            Return objDataAccessLayer.Registrar_Record_Medico(objEntidad)
            'Catch ex As Exception
            '    Throw New Exception(ex.Message)
            'End Try
        End Function

        Public Function Modificar_Record_Medico(ByVal objEntidad As RecordMedico) As RecordMedico
            Return objDataAccessLayer.Modificar_Record_Medico(objEntidad)
        End Function

        Public Function Eliminar_Record_Medico(ByVal objEntidad As RecordMedico) As RecordMedico
            Return objDataAccessLayer.Eliminar_Record_Medico(objEntidad)
        End Function

        Public Function Listar_Record_Medico(ByVal objEntidad As RecordMedico) As List(Of RecordMedico)
            'Try
            Return objDataAccessLayer.Listar_Record_Medico(objEntidad)
            'Catch
            '    Return New List(Of RecordMedico)
            'End Try
        End Function

        Public Function Listar_Record_Medico_DT(ByVal objEntidad As RecordMedico) As DataTable
            Return objDataAccessLayer.Listar_Record_Medico_DT(objEntidad)
        End Function

        Public Function Listar_VencimientoVacuna_Reporte(ByVal ht As Hashtable) As List(Of RecordMedico)
            Return objDataAccessLayer.Listar_VencimientoVacuna_Reporte(ht)
        End Function

    End Class
End Namespace

