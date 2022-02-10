Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsAgenteCarga
    Public Function Lista_Agente_Carga() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager

        dt = lobjSql.ExecuteDataTable("SP_SOLSC_AGENTE_CARGA", Nothing)
        Return dt
    End Function
End Class
