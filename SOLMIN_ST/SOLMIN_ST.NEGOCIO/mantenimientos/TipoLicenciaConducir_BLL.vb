Imports SOLMIN_ST.DATOS.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos

'****************************************************************************************************
'** Autor: Anddy Ramos
'** Fecha de Creación: 16/07/2009 
'** Descripción: capa de negocio.
'****************************************************************************************************

Namespace mantenimientos
    
    Public Class TipoLicenciaConducir_BLL

        Dim objDataAccessLayer As New TipoLicenciaConducir_DAL

        Public Function Registrar_Tipo_Licencia_Conducir(ByVal objEntidad As TipoLicenciaConducir) As TipoLicenciaConducir
            Return objDataAccessLayer.Registrar_Tipo_Licencia_Conducir(objEntidad)
        End Function

        Public Function Modificar_Tipo_Licencia_Conducir(ByVal objEntidad As TipoLicenciaConducir) As TipoLicenciaConducir
            Return objDataAccessLayer.Modificar_Tipo_Licencia_Conducir(objEntidad)
        End Function

        Public Function Eliminar_Tipo_Licencia_Conducir(ByVal objEntidad As TipoLicenciaConducir) As TipoLicenciaConducir
            Return objDataAccessLayer.Eliminar_Tipo_Licencia_Conducir(objEntidad)
        End Function

        Public Function Listar_Tipo_Licencia_Conducir(ByVal objEntidad As TipoLicenciaConducir) As List(Of TipoLicenciaConducir)
            'Try
            Return objDataAccessLayer.Listar_Tipo_Licencia_Conducir(objEntidad)
            'Catch
            '    Return New List(Of TipoLicenciaConducir)
            'End Try
        End Function

    End Class

End Namespace
