Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad
Public Class clsVapores
  Private objSql As New SqlManager

  Public Function Buscar_Vapores(ByVal oVapores As beVapores)
    Dim dt As New DataTable
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PSCVPRCN", oVapores.PSCVPRCN)
    lobjParams.Add("PSTCMPVP", oVapores.PSTCMPVP)
    lobjParams.Add("PSSESTRG", oVapores.PSSESTRG)
    dt = lobjSql.ExecuteDataTable("SP_SOLSC_BUSCAR_VAPORES", lobjParams)
    Return dt
  End Function

  Public Function Registrar_Vapores(ByVal oVapores As beVapores)
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PSCVPRCN", oVapores.PSCVPRCN)
    lobjParams.Add("PSTCMPVP", oVapores.PSTCMPVP)
    lobjParams.Add("PSNTRMNL", oVapores.PSNTRMNL)
    lobjParams.Add("PSTABRVP", oVapores.PSTABRVP)
    lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
    lobjParams.Add("PSQTNLBR", oVapores.PNQTNLBR)
    lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
    lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
    lobjParams.Add("PSRESULT", 0, ParameterDirection.Output)
    objSql.ExecuteNonQuery("SP_SOLSC_INSERTA_VAPOR", lobjParams)
    Return objSql.ParameterCollection("PSRESULT")
  End Function

  Public Function Eliminar_Vapores(ByVal CVPRCN As String) As Integer
    Dim retorno As Int32 = 0
    Dim objParam As New Parameter
    objParam.Add("PSCVPRCN", CVPRCN)
        objSql.ExecuteNonQuery("SP_SOLSC_ELIMINAR_VAPOR", objParam)
    retorno = 1
    Return retorno
  End Function

  Public Function Restablecer_Vapores(ByVal CVPRCN As String) As Integer
    Dim retorno As Int32 = 0
    Dim objParam As New Parameter
    objParam.Add("PSCVPRCN", CVPRCN)
        objSql.ExecuteNonQuery("SP_SOLSC_RESTABLECER_VAPOR", objParam)
    retorno = 1
    Return retorno
  End Function

  Public Function Actualizar_Vapores(ByVal oVapores As beVapores) As Integer
    Dim retorno As Int32 = 0
    Dim objParam As New Parameter
    objParam.Add("PSCVPRCN", oVapores.PSCVPRCN)
    objParam.Add("PSTCMPVP", oVapores.PSTCMPVP)
    objParam.Add("PSTABRVP", oVapores.PSTABRVP)
    objParam.Add("PSNTRMNL", oVapores.PSNTRMNL)
    objParam.Add("PSQTNLBR", oVapores.PNQTNLBR)
    objParam.Add("PSCUSCRT", ConfigurationWizard.UserName)
    objParam.Add("PNFECHA", Format(Now, "yyyyMMdd"))
    objParam.Add("PNHORA", Format(Now, "HHmmss"))
        objSql.ExecuteNonQuery("SP_SOLSC_ACTUALIZAR_VAPOR", objParam)
    retorno = 1
    Return retorno
  End Function
End Class
