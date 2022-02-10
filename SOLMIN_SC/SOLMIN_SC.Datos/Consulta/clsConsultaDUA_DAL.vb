Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsConsultaDUA_DAL

    Function Load_Data_General(ByVal DUA As String) As DataTable

        Dim dtGeneral As New DataTable

        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSDUA", DUA)

        dtGeneral = lobjSql.ExecuteDataTable("SP_SOLMIN_SC_CONSULTA_DUA_LOAD_GENERAL", lobjParams)

        Return dtGeneral

    End Function

    Function Load_Data_Detail(ByVal CODI_ADUAN As Decimal, ByVal ANO_PRESE As Decimal, ByVal CODI_REGI As Decimal, ByVal NUME_ORDEN As Decimal) As DataSet

        Dim dsDetail As New DataSet

        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCODI_ADUAN", CODI_ADUAN)
        lobjParams.Add("PNANO_PRESE", ANO_PRESE)
        lobjParams.Add("PNCODI_REGI", CODI_REGI)
        lobjParams.Add("PNNUME_ORDEN", NUME_ORDEN)

        dsDetail = lobjSql.ExecuteDataSet("SP_SOLMIN_SC_CONSULTA_DUA_LOAD_DETAIL", lobjParams)
        Return dsDetail

    End Function


End Class
