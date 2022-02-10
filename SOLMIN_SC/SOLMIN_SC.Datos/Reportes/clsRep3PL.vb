Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsRep3PL
    Public Function dtRep3PLMontosMensuales(ByVal PSCCMPN As String, ByVal PNCCLNT As Double, ByVal PNFECINI As Double, ByVal PNFECFIN As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNFECINI", PNFECINI)
        lobjParams.Add("PNFECFIN", PNFECFIN)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_REP3PL_MONTOS", lobjParams)
        Return dt
    End Function

    Public Function dtRep3PLOrdenesMensuales(ByVal PSCCMPN As String, ByVal PNCCLNT As Double, ByVal PNFECINI As Double, ByVal PNFECFIN As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNFECINI", PNFECINI)
        lobjParams.Add("PNFECFIN", PNFECFIN)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_REP3PL_ORDENES", lobjParams)
        Return dt
    End Function


    Public Function dtRep3PLDatosAduanas(ByVal PNCCLNT As Double, ByVal PNFECINI As Double, ByVal PNFECFIN As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNFECINI", PNFECINI)
        lobjParams.Add("PNFECFIN", PNFECFIN)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_REP3PL_CUSTOMS", lobjParams)
        Return dt
    End Function

  

    Public Function dtRep3PLDatosAduanasGeneral(ByVal PNCCLNT As Double, ByVal PNFECINI As Double, ByVal PNFECFIN As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNFECINI", PNFECINI)
        lobjParams.Add("PNFECFIN", PNFECFIN)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_REP3PL_CUSTOMS_GENERAL", lobjParams)
        Return dt
    End Function

    Public Function dtRep3PLOrdenesDatos(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal PNCCLNT As Double, ByVal PNANOALF As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PSCDVSN", PSCDVSN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNANOALF", PNANOALF)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_REP3PL_DATOS", lobjParams)
        Return dt
    End Function

    Public Sub Registro_Datos_Mensuales(ByRef oSqlMan As SqlManager, ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal PNCCLNT As Double, ByVal PNANOALF As Double, ByVal PNMESALF As Double, ByVal PNCMEDTR As Double, ByVal pdblCantOC As Double, ByVal pdblTFlete As Double, ByVal pdblTPeso As Double, ByVal pdblTDias As Double, ByVal pdblTOper As Double)
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PSCDVSN", PSCDVSN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNANOALF", PNANOALF)
        lobjParams.Add("PNMESALF", PNMESALF)
        lobjParams.Add("PNCMEDTR", PNCMEDTR)
        lobjParams.Add("PNNUMOCO", pdblCantOC)
        lobjParams.Add("PNIVLFLT", pdblTFlete)
        lobjParams.Add("PNQPSOAR", pdblTPeso)
        lobjParams.Add("PNTTLDIA", pdblTDias)
        lobjParams.Add("PNTTLOPR", pdblTOper)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        oSqlMan.ExecuteNonQuery("SP_SOLSC_REP3PL_REG_DATOS_MENSUALES", lobjParams)
    End Sub

    Public Sub Eliminar_Datos_Mensuales(ByRef oSqlMan As SqlManager, ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal PNCCLNT As Double, ByVal PNANOALF As Double, ByVal PNMESALF As Double)

        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PSCDVSN", PSCDVSN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNANOALF", PNANOALF)
        lobjParams.Add("PNMESALF", PNMESALF)
        oSqlMan.ExecuteNonQuery("SP_SOLSC_REP3PL_DEL_DATOS_MENSUALES", lobjParams)
       
    End Sub

    Public Function dtRep3PLPesosMensualesXOrigen(ByVal PNCCLNT As Double, ByVal PNFECINI As Double, ByVal PNFECFIN As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNFECINI", PNFECINI)
        lobjParams.Add("PNFECFIN", PNFECFIN)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_REP3PL_PESOS_X_ORIGEN", lobjParams)
        Return dt
    End Function

   
    Public Function dtRep3PLOrdenesMensualesXOrigen(ByVal PNCCLNT As Double, ByVal PNFECINI As Double, ByVal PNFECFIN As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNFECINI", PNFECINI)
        lobjParams.Add("PNFECFIN", PNFECFIN)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_REP3PL_ORDENES_X_ORIGEN", lobjParams)
        Return dt
    End Function

    Public Function dtRep3PLOperacionMensual(ByVal PSCCMPN As String, ByVal PNCCLNT As Double, ByVal PNFECINI As Double, ByVal PNFECFIN As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNFECINI", PNFECINI)
        lobjParams.Add("PNFECFIN", PNFECFIN)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_REP3PL_OPERACION_MENSUAL", lobjParams)
        Return dt
    End Function

    Public Function dtNoLaborables(ByVal PNFECINI As Double, ByVal PNFECFIN As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNFECINI", PNFECINI)
        lobjParams.Add("PNFECFIN", PNFECFIN)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_NOLABORABLE", lobjParams)
        Return dt
    End Function


    Public Function dtRep3PLDatosEnvio(ByVal PSCCMPN As String, ByVal PNCCLNT As Double, ByVal PNFECINI As Double, ByVal PNFECFIN As Double, ByVal PSLISTAREGIMEN As String) As DataSet
        Dim ds As New DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNFECINI", PNFECINI)
        lobjParams.Add("PNFECFIN", PNFECFIN)
        lobjParams.Add("PSLISTAREGIMEN", PSLISTAREGIMEN)
        ds = lobjSql.ExecuteDataSet("SP_SOLSC_REP3PL_DATOS_ENVIO", lobjParams)
        ds.Tables(0).TableName = "DTMONTOMENSUAL"
        ds.Tables(1).TableName = "DTORDENMENSUAL"
        ds.Tables(2).TableName = "DTFERIADO"
        ds.Tables(3).TableName = "DTOPERACIONMENSUAL"

        Return ds.Copy
    End Function

    Public Function Obtener_Datos_3PL_Unificado(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal PNCCLNT As Decimal, ByVal PNANOALF As Decimal, ByVal PNFECINI As Decimal, ByVal PNFECFIN As Decimal, ByVal PNFECINI_ANIO As Decimal, ByVal PSLISTAREGIMEN As String) As DataSet

        Dim ds As New DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PSCDVSN", PSCDVSN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNANOALF", PNANOALF)
        lobjParams.Add("PNFECINI", PNFECINI)
        lobjParams.Add("PNFECFIN", PNFECFIN)
        lobjParams.Add("PNFECINI_ANIO", PNFECINI_ANIO)
        lobjParams.Add("PSLISTAREGIMEN", PSLISTAREGIMEN)
        ds = lobjSql.ExecuteDataSet("SP_SOLSC_REP3PL_DATOS_UNIFICADO", lobjParams)
        ds.Tables(0).TableName = "DTORDENDATO"
        ds.Tables(1).TableName = "DTORDENMENSUALORIGEN"
        ds.Tables(2).TableName = "DTPESOMENSUALORIGEN"
        ds.Tables(3).TableName = "DTDATOADUANA"
        ds.Tables(4).TableName = "DTADUANAGENERAL"
        ds.Tables(5).TableName = "DTADUANAGENERAL_AD"
        Return ds.Copy

    End Function


End Class