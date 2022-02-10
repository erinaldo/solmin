Imports SOLMIN_ST.DATOS.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
'****************************************************************************************************
'** Autor: Anddy Ramos
'** Modificaci�n: Rafael Gamboa
'** Fecha de Creaci�n: 30/07/2009 
'** Descripci�n: capa de negocio.
'****************************************************************************************************
Namespace mantenimientos
    Public Class Vacunas_BLL

        Dim objDataAccessLayer As New Vacunas_DAL

        Public Function Registrar_Vacunas(ByVal objEntidad As Vacunas) As Vacunas
            Return objDataAccessLayer.Registrar_Vacunas(objEntidad)
        End Function

        Public Function Modificar_Vacunas(ByVal objEntidad As Vacunas) As Vacunas
            Return objDataAccessLayer.Modificar_Vacunas(objEntidad)
        End Function

        Public Function Eliminar_Vacunas(ByVal objEntidad As Vacunas) As Vacunas
            Return objDataAccessLayer.Eliminar_Vacunas(objEntidad)
        End Function

        Public Function Listar_Vacunas(ByVal objEntidad As Vacunas) As List(Of Vacunas)
            'Try
            Return objDataAccessLayer.Listar_Vacunas(objEntidad)
            'Catch
            '    Return New List(Of Vacunas)
            'End Try
        End Function

    End Class

End Namespace