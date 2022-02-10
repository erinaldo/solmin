Imports SOLMIN_ST.DATOS.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
'****************************************************************************************************
'** Autor: Anddy Ramos
'** Fecha de Creación: 16/07/2009 
'** Descripción: capa de negocio.
'****************************************************************************************************
Namespace mantenimientos

    Public Class Acoplado_BLL

        Dim objDataAccessLayer As New Acoplado_DAL

        Public Function Registrar_Acoplado(ByVal objEntidad As Acoplado) As Acoplado
            Return objDataAccessLayer.Registrar_Acoplado(objEntidad)
        End Function

        Public Function Registrar_Acoplado_Antiguo(ByVal objEntidad As Acoplado) As Acoplado
            Return objDataAccessLayer.Registrar_Acoplado_Antiguo(objEntidad)
        End Function

        Public Function Modificar_Acoplado(ByVal objEntidad As Acoplado) As Acoplado
            Return objDataAccessLayer.Modificar_Acoplado(objEntidad)
        End Function

        Public Function Eliminar_Acoplado(ByVal objEntidad As Acoplado) As Acoplado
            Return objDataAccessLayer.Eliminar_Acoplado(objEntidad)
        End Function

        Public Function Listar_Acoplado(ByVal objEntidad As Acoplado) As List(Of Acoplado)
            'Try
            Return objDataAccessLayer.Listar_Acoplado(objEntidad)
            'Catch
            '    Return New List(Of Acoplado)
            'End Try
        End Function

        Public Function BuscarAcoplado(ByVal objEntidad As Acoplado) As List(Of Acoplado)
            Return objDataAccessLayer.BuscarAcoplado(objEntidad)
        End Function

        Public Function Lista_Artefacto_Fluviales(ByVal objEntidad As Acoplado) As DataTable
            Return objDataAccessLayer.Lista_Artefacto_Fluviales(objEntidad)
        End Function

        Public Function Modificar_Asignacion_Acoplado_Transportista(ByVal objEntidad As Acoplado) As Int32
            Return objDataAccessLayer.Modificar_Asignacion_Acoplado_Transportista(objEntidad)
        End Function

        Public Function Obtener_Datos_Asignacion_Acoplado_Transportista(ByVal objEntidad As Acoplado) As List(Of Acoplado)
            Return objDataAccessLayer.Obtener_Datos_Asignacion_Acoplado_Transportista(objEntidad)
        End Function
        Public Function Listar_AcopladoPaginado(ByVal objEntidad As Acoplado, ByRef TotalPaginas As Decimal) As DataTable
            Return objDataAccessLayer.Listar_AcopladoPaginado(objEntidad, TotalPaginas)
        End Function


        'Modificar_Asignacion_Acoplado_Transportista
        'Obtener_Datos_Asignacion_Acoplado_Transportista


    End Class

End Namespace