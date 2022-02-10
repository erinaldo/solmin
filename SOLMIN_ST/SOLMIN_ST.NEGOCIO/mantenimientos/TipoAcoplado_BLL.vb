Imports SOLMIN_ST.DATOS.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos

'****************************************************************************************************
'** Autor: Anddy Ramos
'** Fecha de Creación: 16/07/2009 
'** Descripción: capa de negocio.
'****************************************************************************************************

Namespace mantenimientos

    Public Class TipoAcoplado_BLL

        Dim objDataAccessLayer As New TipoAcoplado_DAL

        Public Function Registrar_Tipo_Acoplado(ByVal objEntidad As TipoAcoplado) As TipoAcoplado
            Return objDataAccessLayer.Registrar_Tipo_Acoplado(objEntidad)
        End Function

        Public Function Modificar_Tipo_Acoplado(ByVal objEntidad As TipoAcoplado) As TipoAcoplado
            Return objDataAccessLayer.Modificar_Tipo_Acoplado(objEntidad)
        End Function

        Public Function Eliminar_Tipo_Acoplado(ByVal objEntidad As TipoAcoplado) As TipoAcoplado
            Return objDataAccessLayer.Eliminar_Tipo_Acoplado(objEntidad)
        End Function

        Public Function Listar_Tipo_Acoplado(ByVal objEntidad As TipoAcoplado) As List(Of TipoAcoplado)
            'Try
            Return objDataAccessLayer.Listar_Tipo_Acoplado(objEntidad)
            'Catch
            '    Return New List(Of TipoAcoplado)
            'End Try
        End Function

        Public Function Listar_Tipo_Acoplado_Seleccion(ByVal CCMPN As String) As DataTable
            Return objDataAccessLayer.Listar_Tipo_Acoplado_Seleccion(CCMPN)
        End Function


    End Class

End Namespace