Imports SOLMIN_ST.DATOS.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Namespace mantenimientos

    Public Class LocalidadRuta_BLL
        Dim objDataAccessLayer As New LocalidadRuta_DAL

        Public Function Registrar_LocalidadRuta(ByVal objEntidad As LocalidadRuta) As LocalidadRuta
            Return objDataAccessLayer.Registrar_LocalidadRuta(objEntidad)
        End Function

        Public Function Modificar_LocalidadRuta(ByVal objEntidad As LocalidadRuta) As LocalidadRuta
            Return objDataAccessLayer.Modificar_LocalidadRuta(objEntidad)
        End Function

        Public Function Eliminar_LocalidadRuta(ByVal objEntidad As LocalidadRuta) As LocalidadRuta
            Return objDataAccessLayer.Eliminar_LocalidadRuta(objEntidad)
        End Function

        Public Function Listar_LocalidadRuta(ByVal objEntidad As LocalidadRuta) As List(Of LocalidadRuta)
            'Try
            Return objDataAccessLayer.Listar_LocalidadRuta(objEntidad)
            'Catch
            '    Return New List(Of LocalidadRuta)
            'End Try
        End Function

        Public Function Listar_Ubigeo(ByVal lstr_CCMPN As String) As DataTable
            'Try
            Return objDataAccessLayer.Listar_Ubigeo(lstr_CCMPN)
            'Catch
            '    Return New DataTable
            'End Try
        End Function
        Public Function Listar_Ubigeo_Todos(ByVal lstr_CCMPN As String) As List(Of LocalidadRuta)
            Return objDataAccessLayer.Listar_Ubigeo_Todos(lstr_CCMPN)
        End Function

    End Class

End Namespace