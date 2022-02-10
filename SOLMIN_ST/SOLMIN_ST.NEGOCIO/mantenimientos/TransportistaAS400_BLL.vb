Imports SOLMIN_ST.DATOS.Mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos

Namespace mantenimientos

    Public Class TransportistaAS400_BLL

        Dim objDataAccessLayer As New TransportistaAS400_DAL

        Public Function Registrar_TransportistaAS400(ByVal objEntidad As Transportista) As Transportista
            Return objDataAccessLayer.Registrar_TransportistaAS400(objEntidad)
        End Function

        Public Function Listar_TransportistaAS400(ByVal strCompania As String) As List(Of Transportista)
            'Try
            Return objDataAccessLayer.Listar_TransportistaAS400(strCompania)
            'Catch
            '    Return New List(Of Transportista)
            'End Try
        End Function

        Public Function Listar_TransportistaAS400_RZTR10(ByVal objEntidad As Transportista, IN_NROPAG As Decimal, PAGESIZE As Decimal, ByRef TOTPAG As Decimal) As DataTable
            Return objDataAccessLayer.Listar_TransportistaAS400_RZTR10(objEntidad, IN_NROPAG, PAGESIZE, TOTPAG)
        End Function
        Public Function Listar_TransportistaAS400_LIST_RZTR10(ByVal objEntidad As Transportista, IN_NROPAG As Decimal, PAGESIZE As Decimal, ByRef TOTPAG As Decimal) As DataTable
            Return objDataAccessLayer.Listar_TransportistaAS400_LIST_RZTR10(objEntidad, IN_NROPAG, PAGESIZE, TOTPAG)
        End Function

    End Class

End Namespace