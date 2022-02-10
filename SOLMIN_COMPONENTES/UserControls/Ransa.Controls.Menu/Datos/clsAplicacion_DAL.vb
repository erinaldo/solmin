Imports Db2Manager.RansaData.iSeries.DataObjects
'Imports Ransa.Controls.Menu.beAplicacion
Public Class clsAplicacion_DAL

  Public Function Listar_Aplicaciones(ByVal objbeAplicacionMenu As beAplicacion) As DataTable
    Dim dt As New DataTable
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PSMMCAPL", objbeAplicacionMenu.PSMMCAPL_CodApl) 'codigo aplicaci�n
    lobjParams.Add("PSMMDAPL", objbeAplicacionMenu.PSMMDAPL_DesApl) 'descripci�n aplicaci�n
    dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SD_LISTA_APLICACIONES", lobjParams)
    Return dt
  End Function

  Public Function Registrar_Aplicaciones(ByVal objbeAplicacionMenu As beAplicacion)
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PSMMCAPL", objbeAplicacionMenu.PSMMCAPL_CodApl) 'codigo aplicaci�n
    lobjParams.Add("PSMMDAPL", objbeAplicacionMenu.PSMMDAPL_DesApl) 'descripci�n aplicaci�n
    lobjParams.Add("PSMMCCIA", "") 'codigo de compa�ia
    lobjParams.Add("PNFCHCRT", Format(Now, "yyyyMMdd")) 'fecha de creaci�n
    lobjParams.Add("PNHRACRT", Format(Now, "HHmmss")) 'hora de creaci�n
    lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName) 'usuario creador
    lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd")) 'fecha de actualizaci�n
    lobjParams.Add("PNHULTAC", Format(Now, "HHmmss")) 'hora de actualizaci�n
    lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName) 'usuario (actualizaci�n)
    lobjParams.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result
    lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_INSERT_APLICACIONES", lobjParams)
    Return lobjSql.ParameterCollection("PSRESULT")
  End Function

  Public Function Modificar_Aplicaciones(ByVal objbeAplicacionMenu As beAplicacion)

    Dim resultado As Int32 = 0
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PSMMCAPL", objbeAplicacionMenu.PSMMCAPL_CodApl) 'codigo aplicaci�n
    lobjParams.Add("PSMMDAPL", objbeAplicacionMenu.PSMMDAPL_DesApl) 'descripci�n aplicaci�n
    lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd")) 'fecha de actualizaci�n
    lobjParams.Add("PNHULTAC", Format(Now, "HHmmss")) 'hora de actualizaci�n
    lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName) 'usuario (actualizaci�n)
    lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_UPDATE_APLICACIONES", lobjParams)
    resultado = 1
    Return resultado
  End Function

  Public Function Eliminar_Aplicaciones(ByVal objbeAplicacionMenu As beAplicacion)
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PSMMCAPL", objbeAplicacionMenu.PSMMCAPL_CodApl) 'codigo
    lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd")) 'fecha de actualizaci�n
    lobjParams.Add("PNHULTAC", Format(Now, "HHmmss")) 'hora de actualizaci�n
    lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName) 'usuario (actualizaci�n)
    lobjParams.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result
    lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_DELETE_APLICACIONES", lobjParams)
    Return lobjSql.ParameterCollection("PSRESULT")
  End Function

  Public Function Restaurar_Aplicaciones(ByVal objbeAplicacionMenu As beAplicacion)
    Dim resultado As Int32 = 0
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PSMMCAPL", objbeAplicacionMenu.PSMMCAPL_CodApl) 'codigo aplicaci�n
    lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_RESTABLECER_APLICACIONES", lobjParams)
    resultado = 1
    Return resultado
  End Function

End Class
