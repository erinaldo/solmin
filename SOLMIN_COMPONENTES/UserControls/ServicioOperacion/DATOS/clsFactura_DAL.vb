Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class clsFactura_DAL
    Public Function Estimacion_Ingreso_Revertir(ByVal pobjFiltro As Filtro_BE) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pobjFiltro.Parametro1)
        lobjParams.Add("PNCTPODC", pobjFiltro.Parametro12)
        lobjParams.Add("PNNDCFCC", pobjFiltro.Parametro13)
        lobjParams.Add("PNNSECFC", pobjFiltro.Parametro14)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_LISTA_ESTIMACION_INGRESO_REVERTIR", lobjParams)
        Return dt
    End Function

    Public Function Estimacion_Ingreso_RevertirMasivo(tipo As String, oServ As Servicio_BE) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", oServ.CCMPN)
        lobjParams.Add("PSTIPO", tipo)
        lobjParams.Add("PNCTPODC", oServ.CTPODC)
        lobjParams.Add("PNNDCFCC", oServ.NDCCTC)
        lobjParams.Add("PSLISTJSON", oServ.LISTJSON)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_LISTA_ESTIMACION_INGRESO_REVERTIRMASIVO", lobjParams)
        Return dt
    End Function

End Class
