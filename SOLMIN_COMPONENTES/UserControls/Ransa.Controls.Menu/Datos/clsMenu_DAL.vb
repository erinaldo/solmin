Imports Db2Manager.RansaData.iSeries.DataObjects
'Imports Ransa.Controls.Menu.beAplicacion

Public Class clsMenu_DAL
  Public Function Listar_MenuXAplicacion(ByVal obeMenu As beMenu) As DataTable
    Dim dt As New DataTable
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PSMMCAPL", obeMenu.PSMMCAPL_CodApl) 'codigo aplicación
    lobjParams.Add("PSMMCMNU", obeMenu.PSMMCMNU_CodMnu) 'codigo menú
    lobjParams.Add("PSMMTMNU", obeMenu.PSMMTMNU_DesMnu) 'descripcion menú
    dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SD_LISTA_MENUXAPLICACION", lobjParams)
    Return dt
  End Function

  Public Function Registrar_Menus(ByVal objbeMenu As beMenu)

    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PSMMCAPL", objbeMenu.PSMMCAPL_CodApl) 'codigo aplicación
    lobjParams.Add("PSMMCMNU", objbeMenu.PSMMCMNU_CodMnu) 'codigo menú
    lobjParams.Add("PSMMTMNU", objbeMenu.PSMMTMNU_DesMnu) 'descripcion menú
    lobjParams.Add("PNFCHCRT", Format(Now, "yyyyMMdd")) 'fecha de creación
    lobjParams.Add("PNHRACRT", Format(Now, "HHmmss")) 'hora de creación
    lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName) 'usuario creador
    lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd")) 'fecha de actualización
    lobjParams.Add("PNHULTAC", Format(Now, "HHmmss")) 'hora de actualización
    lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName) 'usuario (actualización)
    lobjParams.Add("PSRESULT", 0, ParameterDirection.Output)
    lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_INSERT_MENUXAPLICACION", lobjParams)
    Return lobjSql.ParameterCollection("PSRESULT")
  End Function

  Public Function Modificar_Menus(ByVal objbeMenu As beMenu)
    Dim resultado As Int32 = 0
    Dim dt As New DataTable
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PSMMCAPL", objbeMenu.PSMMCAPL_CodApl) 'codigo aplicación
    lobjParams.Add("PSMMCMNU", objbeMenu.PSMMCMNU_CodMnu) 'codigo menú
    lobjParams.Add("PSMMTMNU", objbeMenu.PSMMTMNU_DesMnu) 'descripcion menú
    lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd")) 'fecha de actualización
    lobjParams.Add("PNHULTAC", Format(Now, "HHmmss")) 'hora de actualización
    lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName) 'usuario (actualización)
    lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_UPDATE_MENUXAPLICACION", lobjParams)
    resultado = 1
    Return resultado
  End Function

  Public Function Eliminar_Menus(ByVal objbeMenu As beMenu)
    Dim resultado As Int32 = 0
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PSMMCMNU", objbeMenu.PSMMCMNU_CodMnu) 'codigo menú
    lobjParams.Add("PSMMCAPL", objbeMenu.PSMMCAPL_CodApl) 'codigo aplicación
    lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd")) 'fecha de actualización
    lobjParams.Add("PNHULTAC", Format(Now, "HHmmss")) 'hora de actualización
    lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName) 'usuario (actualización)
    lobjParams.Add("PSRESULT", 0, ParameterDirection.Output)
    lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_DELETE_MENUXAPLICACION", lobjParams)
    Return lobjSql.ParameterCollection("PSRESULT")
  End Function

  Public Function Restaurar_Menus(ByVal objbeMenu As beMenu)
    Dim resultado As Int32 = 0
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PSMMCMNU", objbeMenu.PSMMCMNU_CodMnu) 'codigo menú
    lobjParams.Add("PSMMCAPL", objbeMenu.PSMMCAPL_CodApl) 'codigo aplicación
    lobjParams.Add("PSMMTMNU", objbeMenu.PSMMTMNU_DesMnu) 'descripcion menú
    lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd")) 'fecha de actualización
    lobjParams.Add("PNHULTAC", Format(Now, "HHmmss")) 'hora de actualización
    lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName) 'usuario (actualización)
    lobjParams.Add("PSRESULT", 0, ParameterDirection.Output)
    lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_RESTAURAR_MENUXAPLICACION", lobjParams)
    Return lobjSql.ParameterCollection("PSRESULT")
  End Function

End Class
