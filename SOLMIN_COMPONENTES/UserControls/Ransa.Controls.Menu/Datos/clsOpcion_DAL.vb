Imports Db2Manager.RansaData.iSeries.DataObjects
'Imports Ransa.Controls.Menu.beAplicacion
Public Class clsOpcion_DAL
  Public Function Listar_MenuOpcion(ByVal objbeOpcion As beOpcion) As DataTable
    Dim dt As New DataTable
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PSMMCAPL", objbeOpcion.PSMMCAPL_CodApl) 'codigo aplicaci�n
    lobjParams.Add("PSMMCMNU", objbeOpcion.PSMMCMNU_CodMnu) 'codigo men�
    lobjParams.Add("PSMMCOPC_INI", objbeOpcion.PNMMCOPC_CodOpc_Ini) 'codigo opci�n minimo
    lobjParams.Add("PSMMCOPC_FIN", objbeOpcion.PNMMCOPC_CodOpc_Fin) 'codigo opci�n minimo
    lobjParams.Add("PSMMDOPC", objbeOpcion.PSMMDOPC_DesOpc) 'descripci�n opci�n
    dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SD_LISTA_MENUOPCION", lobjParams)
    Return dt
  End Function

  Public Function Registrar_Opciones(ByVal objbeOpcion As beOpcion)
    Dim dt As New DataTable
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PSMMCAPL", objbeOpcion.PSMMCAPL_CodApl) 'codigo aplicaci�n
    lobjParams.Add("PSMMCMNU", objbeOpcion.PSMMCMNU_CodMnu) 'codigo men�
    lobjParams.Add("PNMMCOPC", objbeOpcion.PNMMCOPC_CodOpc) 'codigo opci�n
    lobjParams.Add("PSMMDOPC", objbeOpcion.PSMMDOPC_DesOpc) 'descripci�n opci�n

    lobjParams.Add("PSMMCAIN", objbeOpcion.PSMMCAIN) 'descripci�n opci�n
    lobjParams.Add("PSMMCMIN", objbeOpcion.PSMMCMIN) 'descripci�n opci�n

    lobjParams.Add("PSMMTOPC", objbeOpcion.PSMMTOPC) 'tipo de opci�n (Men�, Funci�n)
    lobjParams.Add("PSMMTVAR", objbeOpcion.PSMMTVAR) 'tipo de variable enviar
    lobjParams.Add("PSMMNPRO", objbeOpcion.PSMMNPRO) '*LIBL

    'lobjParams.Add("PSMMNPGM", objbeOpcion.PSMMNPGM) 'nombre de programa 
    lobjParams.Add("PSMMNFUN", objbeOpcion.PSMMNFUN) 'VISUAL

    lobjParams.Add("PSMMNPVB", objbeOpcion.PSMMNPVB) 'nombre de programa VBasic
    lobjParams.Add("PSURLIMG", objbeOpcion.PSURLIMG) 'direccion imagen

    lobjParams.Add("PNFCHCRT", Format(Now, "yyyyMMdd")) 'fecha de creaci�n
    lobjParams.Add("PNHRACRT", Format(Now, "HHmmss")) 'hora de creacion
    lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName) 'usuario creador
    lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd")) 'fecha de actualizaci�n
    lobjParams.Add("PNHULTAC", Format(Now, "HHmmss")) 'hora de actualizaci�n
    lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName) 'usuario (actualizaci�n)
    lobjParams.Add("PSRESULT", 0, ParameterDirection.Output)
    lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_INSERT_MENUOPCION", lobjParams)
    Return lobjSql.ParameterCollection("PSRESULT")
  End Function

  Public Function Modificar_Opciones(ByVal objbeOpcion As beOpcion)
    Dim resultado As Int32 = 0
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PSMMCAPL", objbeOpcion.PSMMCAPL_CodApl) 'codigo aplicaci�n
    lobjParams.Add("PSMMCMNU", objbeOpcion.PSMMCMNU_CodMnu) 'codigo men�
    lobjParams.Add("PNMMCOPC", objbeOpcion.PNMMCOPC_CodOpc) 'codigo opci�n
    lobjParams.Add("PSMMDOPC", objbeOpcion.PSMMDOPC_DesOpc) 'descripcion opci�n
    lobjParams.Add("PSMMCAIN", objbeOpcion.PSMMCAIN) 'descripci�n opci�n
    lobjParams.Add("PSMMCMIN", objbeOpcion.PSMMCMIN) 'descripci�n opci�n

    lobjParams.Add("PSMMTOPC", objbeOpcion.PSMMTOPC) 'tipo de opci�n (Men�, Funci�n)
    lobjParams.Add("PSMMTVAR", objbeOpcion.PSMMTVAR) 'tipo de variable enviar
    lobjParams.Add("PSMMNPRO", objbeOpcion.PSMMNPRO) '*LIBL
    'lobjParams.Add("PSMMNPGM", objbeOpcion.PSMMNPGM) 'nombre de programa 
    lobjParams.Add("PSMMNFUN", objbeOpcion.PSMMNFUN) 'VISUAL
    lobjParams.Add("PSMMNPVB", objbeOpcion.PSMMNPVB) 'nombre de programa VBasic
    lobjParams.Add("PSURLIMG", objbeOpcion.PSURLIMG) 'direccion imagen

    lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd")) 'fecha de actualizaci�n
    lobjParams.Add("PNHULTAC", Format(Now, "HHmmss")) 'hora de actualizaci�n
    lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName) 'usuario (actualizaci�n)
    lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_UPDATE_MENUOPCION", lobjParams)
    resultado = 1
    Return resultado
  End Function

  Public Function Eliminar_Opciones(ByVal objbeOpcion As beOpcion)
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PNMMCOPC", objbeOpcion.PNMMCOPC_CodOpc) 'codigo opcion
    lobjParams.Add("PSMMCAPL", objbeOpcion.PSMMCAPL_CodApl) 'codigo aplicaci�n
    lobjParams.Add("PSMMCMNU", objbeOpcion.PSMMCMNU_CodMnu) 'codigo men�

    lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd")) 'fecha de actualizaci�n
    lobjParams.Add("PNHULTAC", Format(Now, "HHmmss")) 'hora de actualizaci�n
    lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName) 'usuario (actualizaci�n)
    lobjParams.Add("PSRESULT", 0, ParameterDirection.Output)
    lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_DELETE_MENUOPCION", lobjParams)
    Return lobjSql.ParameterCollection("PSRESULT")
  End Function

  Public Function Restaurar_Opciones(ByVal objbeOpcion As beOpcion)
    Dim resultado As Int32 = 0
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PNMMCOPC", objbeOpcion.PNMMCOPC_CodOpc) 'codigo opci�n
    lobjParams.Add("PSMMCAPL", objbeOpcion.PSMMCAPL_CodApl) 'codigo aplicaci�n
    lobjParams.Add("PSMMCMNU", objbeOpcion.PSMMCMNU_CodMnu) 'codigo men�

    lobjParams.Add("PSMMDOPC", objbeOpcion.PSMMDOPC_DesOpc) 'descripcion opci�n
    lobjParams.Add("PSMMCAIN", objbeOpcion.PSMMCAIN) 'descripci�n opci�n
    lobjParams.Add("PSMMCMIN", objbeOpcion.PSMMCMIN) 'descripci�n opci�n

    lobjParams.Add("PSMMTOPC", objbeOpcion.PSMMTOPC) 'tipo de opci�n (Men�, Funci�n)
    lobjParams.Add("PSMMTVAR", objbeOpcion.PSMMTVAR) 'tipo de variable enviar
    lobjParams.Add("PSMMNPRO", objbeOpcion.PSMMNPRO) '*LIBL
    'lobjParams.Add("PSMMNPGM", objbeOpcion.PSMMNPGM) 'nombre de programa 
    lobjParams.Add("PSMMNFUN", objbeOpcion.PSMMNFUN) 'VISUAL
    lobjParams.Add("PSMMNPVB", objbeOpcion.PSMMNPVB) 'nombre de programa VBasic
    lobjParams.Add("PSURLIMG", objbeOpcion.PSURLIMG) 'direccion imagen

    lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd")) 'fecha de actualizaci�n
    lobjParams.Add("PNHULTAC", Format(Now, "HHmmss")) 'hora de actualizaci�n
    lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName) 'usuario (actualizaci�n)
    lobjParams.Add("PSRESULT", 0, ParameterDirection.Output)
    lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_RESTAURAR_MENUOPCION", lobjParams)
    Return lobjSql.ParameterCollection("PSRESULT")
  End Function

End Class
