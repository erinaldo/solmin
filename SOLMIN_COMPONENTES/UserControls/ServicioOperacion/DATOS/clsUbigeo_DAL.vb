 

Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsUbigeo_DAL

    Public Function ListarUbigeo() As DataTable

        Dim output As DataTable

        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter
        output = sqlManager.ExecuteDataTable("SP_SOLMIN_CT_LISTA_UBIGEO", Nothing)


        Return output





    End Function


End Class
