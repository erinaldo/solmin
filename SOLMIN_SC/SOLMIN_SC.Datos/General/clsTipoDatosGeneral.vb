Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad
Imports Ransa.Utilitario
Public Class clsTipoDatosGeneral
    Public Function Listar_Tipo_Dato_X_Codigo(ByVal cadena As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCODVAR", cadena)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTAR_TIPO_DATO_X_CODIGO", lobjParams)
        Return dt
    End Function

    Public Sub RegistrarLog(ByVal oDatosLog As BEDatosLog)
        Dim objSql As New SqlManager
        Dim objParam As New Parameter
        objParam.Add("IN_SISTEMA", oDatosLog.Sistema)
        objParam.Add("IN_MODULO", oDatosLog.Modulo)
        objParam.Add("IN_RUTINA", oDatosLog.Rutina)
        objParam.Add("IN_RESULTADO", oDatosLog.Codigo & " > " & oDatosLog.Mensaje & " : " & oDatosLog.ErrorDescriptor & " | " & oDatosLog.observaciones)
        objParam.Add("IN_TRACESTREAM", oDatosLog.lstr_request_stream)

        objSql.ExecuteNonQuery("SP_SOLMIN_SC_LOG_INSERT", objParam)


    End Sub

    Public Sub RegistraEnvioRespuestaTracking(ByVal obeEnvioInterfazLog As beEnvioInterfazLog)
        Dim objParam As New Parameter
        Dim objSql As New SqlManager
        objParam.Add("PSCMMPN", obeEnvioInterfazLog.CMMPN)
        objParam.Add("PNNORSCI", obeEnvioInterfazLog.NORSCI)
        objParam.Add("PSFSTENV", obeEnvioInterfazLog.FSTENV)
        objParam.Add("PSMSTENV", obeEnvioInterfazLog.MSTENV)
        objParam.Add("PSMSTEN2", obeEnvioInterfazLog.MSTEN2)
        objParam.Add("PSUSUENV", obeEnvioInterfazLog.USUENV)
        objSql.ExecuteNonQuery("SP_SOLMIN_SC_ACTUALIZAR_INFO_ENVIO_CLIENTE", objParam)

    End Sub


End Class
