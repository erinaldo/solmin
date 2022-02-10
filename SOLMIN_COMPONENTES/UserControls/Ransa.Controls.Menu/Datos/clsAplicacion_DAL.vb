Imports Db2Manager.RansaData.iSeries.DataObjects
'Imports Ransa.Controls.Menu.beAplicacion
Public Class clsAplicacion_DAL

  Public Function Listar_Aplicaciones(ByVal objbeAplicacionMenu As beAplicacion) As DataTable
    Dim dt As New DataTable
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PSMMCAPL", objbeAplicacionMenu.PSMMCAPL_CodApl) 'codigo aplicación
    lobjParams.Add("PSMMDAPL", objbeAplicacionMenu.PSMMDAPL_DesApl) 'descripción aplicación
    dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SD_LISTA_APLICACIONES", lobjParams)
    Return dt
  End Function

  Public Function Registrar_Aplicaciones(ByVal objbeAplicacionMenu As beAplicacion)
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PSMMCAPL", objbeAplicacionMenu.PSMMCAPL_CodApl) 'codigo aplicación
    lobjParams.Add("PSMMDAPL", objbeAplicacionMenu.PSMMDAPL_DesApl) 'descripción aplicación
    lobjParams.Add("PSMMCCIA", "") 'codigo de compañia
    lobjParams.Add("PNFCHCRT", Format(Now, "yyyyMMdd")) 'fecha de creación
    lobjParams.Add("PNHRACRT", Format(Now, "HHmmss")) 'hora de creación
    lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName) 'usuario creador
    lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd")) 'fecha de actualización
    lobjParams.Add("PNHULTAC", Format(Now, "HHmmss")) 'hora de actualización
    lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName) 'usuario (actualización)
    lobjParams.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result
    lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_INSERT_APLICACIONES", lobjParams)
    Return lobjSql.ParameterCollection("PSRESULT")
  End Function

  Public Function Modificar_Aplicaciones(ByVal objbeAplicacionMenu As beAplicacion)

    Dim resultado As Int32 = 0
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PSMMCAPL", objbeAplicacionMenu.PSMMCAPL_CodApl) 'codigo aplicación
    lobjParams.Add("PSMMDAPL", objbeAplicacionMenu.PSMMDAPL_DesApl) 'descripción aplicación
    lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd")) 'fecha de actualización
    lobjParams.Add("PNHULTAC", Format(Now, "HHmmss")) 'hora de actualización
    lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName) 'usuario (actualización)
    lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_UPDATE_APLICACIONES", lobjParams)
    resultado = 1
    Return resultado
  End Function

  Public Function Eliminar_Aplicaciones(ByVal objbeAplicacionMenu As beAplicacion)
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PSMMCAPL", objbeAplicacionMenu.PSMMCAPL_CodApl) 'codigo
    lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd")) 'fecha de actualización
    lobjParams.Add("PNHULTAC", Format(Now, "HHmmss")) 'hora de actualización
    lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName) 'usuario (actualización)
    lobjParams.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result
    lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_DELETE_APLICACIONES", lobjParams)
    Return lobjSql.ParameterCollection("PSRESULT")
  End Function

  Public Function Restaurar_Aplicaciones(ByVal objbeAplicacionMenu As beAplicacion)
    Dim resultado As Int32 = 0
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PSMMCAPL", objbeAplicacionMenu.PSMMCAPL_CodApl) 'codigo aplicación
    lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_RESTABLECER_APLICACIONES", lobjParams)
    resultado = 1
    Return resultado
  End Function

End Class
