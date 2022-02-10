Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class clsTipoDocumento_DAL
    Public Function Lista_TipoDocumento() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_TIPODOCUMENTO", Nothing)
        Return dt
    End Function
End Class


