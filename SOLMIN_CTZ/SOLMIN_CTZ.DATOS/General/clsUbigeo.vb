
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsUbigeo

    Public Function ListarUbigeo() As DataTable

        Dim output As DataTable
        Try
            Dim sqlManager As New SqlManager
            Dim parameter As New Parameter
            output = sqlManager.ExecuteDataTable("SP_SOLMIN_CT_LISTA_UBIGEO", Nothing)
        Catch ex As Exception
            output = Nothing
        End Try

        Return output





    End Function

End Class
