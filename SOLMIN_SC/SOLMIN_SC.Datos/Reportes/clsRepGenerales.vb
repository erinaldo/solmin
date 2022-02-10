Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad
Public Class clsRepGenerales

    Public Function Lista_Datos_Resumen_Mensual_Emb_Facturados(ByVal obeServicioConsulta As beServicioConsulta) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", obeServicioConsulta.PSSCCLNT)
        lobjParams.Add("PNFECINI", obeServicioConsulta.PNFECINI)
        lobjParams.Add("PNFECFIN", obeServicioConsulta.PNFECFIN)
        lobjParams.Add("PSFLAG_SEG", obeServicioConsulta.PSSESTRG_SEG)
        lobjParams.Add("PSFLAG_SERV", obeServicioConsulta.PSFLGFAC_SERV)
        lobjParams.Add("PSFLAG_SECUENCIA", obeServicioConsulta.PSFLAG_SECUENCIA)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_DATOS_RPT_RESUMEN_MENSUAL_EMBARQUES_FACTURADOS", lobjParams)
        Return dt
    End Function


    Public Function Lista_Datos_PreEmbarque_Embarque(ByVal PNCCLNT As Decimal) As DataSet

        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", PNCCLNT)

        Return lobjSql.ExecuteDataSet("SP_SOLSC_REPORTE_RESUMEN_PREEMBARUQE_EMBARQUE", lobjParams)
    End Function

End Class
