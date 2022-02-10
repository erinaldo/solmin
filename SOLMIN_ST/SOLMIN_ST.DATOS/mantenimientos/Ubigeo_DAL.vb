Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class Ubigeo_DAL
    Public Function Listar_Ubigeo() As DataTable
        Dim objSql As New SqlManager
        Dim objData As New DataTable
        Dim objParam As Parameter = New Parameter
        Dim msg As String = ""
        objData = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_UBIGEO", objParam)
        Return objData
    End Function
End Class
