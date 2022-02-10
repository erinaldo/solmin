Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsTipoDocumento
    Public Function Lista_TipoDocumento() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager

        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_TIPODOCUMENTO", Nothing)
        Return dt
    End Function

#Region "NC / ND Electronico"
    Public Function Lista_TipoDocumento_Electronico() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SD_LISTA_TIPO_DOCUMENTO", Nothing)
        Return dt
    End Function
#End Region
End Class