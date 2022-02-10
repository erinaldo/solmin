Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades
Public Class clsValorizacion

#Region "Lista Valorizacion"

    'Inherits clsBase(Of Valorizacion)

    Public Function ListarConfCierreValorizacion(ByVal oValorizacion As Valorizacion) As DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim dt As New DataTable
        lobjParams.Add("PSCCMPN", oValorizacion.CCMPN)
        lobjParams.Add("PNCCLNT", CType(oValorizacion.CCLNT, Double))
        lobjParams.Add("PSESTADO", oValorizacion.SESTRG)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTAR_CONF_CIERRE_VALORIZACION", lobjParams)
        For Each item As DataRow In dt.Rows
            item("FCHCRT") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FCHCRT"))
            item("HRACRT") = Ransa.Utilitario.HelpClass.HoraNum_a_Hora_Cadena(item("HRACRT"))

            item("FULTAC") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FULTAC"))
            item("HULTAC") = Ransa.Utilitario.HelpClass.HoraNum_a_Hora_Cadena(item("HULTAC"))

            item("CUSCRT") = item("CUSCRT") & " " & item("FCHCRT") & " " & item("HRACRT")
            item("CULUSA") = item("CULUSA") & " " & item("FULTAC") & " " & item("HULTAC")
            
        Next

        Return dt
    End Function


#End Region

#Region "Operaciones"
    Public Function Actualizar_Valorizacion(ByVal pobjValorizacion As Valorizacion) As DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim dt As New DataTable
        lobjParams.Add("PSCCMPN", pobjValorizacion.CCMPN)
        lobjParams.Add("PNCCLNT", CType(pobjValorizacion.CCLNT, Double))
        lobjParams.Add("PNCNFCVL", CType(pobjValorizacion.CNFCVL, Double))
        lobjParams.Add("PSREFCNT", pobjValorizacion.REFCNT)
        lobjParams.Add("PNQDAPVL", CType(pobjValorizacion.QDAPVL, Double))
        lobjParams.Add("PSTOBSE1", pobjValorizacion.TOBSE1)
        lobjParams.Add("PSNTRMNL", pobjValorizacion.NTRMNL)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_UPD_CONF_CIERRE_VALORIZACION", lobjParams)
        Return dt
    End Function

    Public Function Insertar_Valorizacion(ByVal pobjValorizacion As Valorizacion) As DataTable
        Dim dt As New DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        lobjParams.Add("PSCCMPN", pobjValorizacion.CCMPN)
        lobjParams.Add("PNCCLNT", CType(pobjValorizacion.CCLNT, Double))
        lobjParams.Add("PSREFCNT", pobjValorizacion.REFCNT)
        lobjParams.Add("PNQDAPVL", CType(pobjValorizacion.QDAPVL, Double))
        lobjParams.Add("PSTOBSE1", pobjValorizacion.TOBSE1)
        lobjParams.Add("PSNTRMNL", pobjValorizacion.NTRMNL)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_INSERT_CONF_CIERRE_VALORIZACION", lobjParams)

        Return dt

 

    End Function

    Public Function AnularCerrar_Valorizacion(ByVal pobjValorizacion As Valorizacion) As DataTable
        Dim dt As New DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        lobjParams.Add("PSCCMPN", pobjValorizacion.CCMPN)
        lobjParams.Add("PNCCLNT", CType(pobjValorizacion.CCLNT, Double))
        lobjParams.Add("PNCNFCVL", CType(pobjValorizacion.CNFCVL, Double))
        lobjParams.Add("PSNTRMNL", pobjValorizacion.NTRMNL)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_DEL_CONF_CIERRE_VALORIZACION", lobjParams)
        Return dt
 
    End Function

#End Region

End Class
