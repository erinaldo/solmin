Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class DAL_CheckPoint
    Public Function Lista_Datos_CheckPoint_PreEmbarque_Envio_Email(ByVal PSCCMPN As String, ByVal PNCCLNT As Decimal, ByVal PNFECHA_REFERENCIA As Decimal) As DataSet
        Dim ds As New DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNFECHA_REFERENCIA", PNFECHA_REFERENCIA)
        ds = lobjSql.ExecuteDataSet("SP_SOLSC_LISTA_DATOS_ITEM_ENVIO_EMAIL_SEGUIMIENTO_INTERNACIONAL", lobjParams)
        ds.Tables(0).TableName = "dtDatosItemOC"
        ds.Tables(1).TableName = "dtDatosCheckPoint"
        ds.Tables(2).TableName = "dtCliente"
        lobjSql.Dispose()
        lobjSql = Nothing
        Return ds.Copy
    End Function
End Class
