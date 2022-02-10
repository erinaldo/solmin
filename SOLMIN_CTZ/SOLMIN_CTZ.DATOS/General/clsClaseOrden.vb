Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades
Public Class clsClaseOrden

    Public Function Lista_ClaseOrden(ByVal pobjOrdenesInternas As OrdenesInternas) As DataTable
        'No valida
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pobjOrdenesInternas.PSCCMPN)
        lobjParams.Add("PSCDVSN", pobjOrdenesInternas.PSCDVSN)
        lobjParams.Add("PSCPLNDV", pobjOrdenesInternas.PNCPLNDV)

        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_CLASE_ORDEN", lobjParams)

        Return dt
    End Function

    Public Function Datos_ClaseOrden(ByVal pobjOrdenesInternas As OrdenesInternas) As DataTable
        'No valida
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCLORI", pobjOrdenesInternas.CCLORI)

        dt = lobjSql.ExecuteDataTable("SP_SOLCT_BUSCA_CLASE_ORDEN", lobjParams)

        Return dt
    End Function
End Class
