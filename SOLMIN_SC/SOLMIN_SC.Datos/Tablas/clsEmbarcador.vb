Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad

Public Class clsEmbarcador
  Private objSql As New SqlManager

  Public Function Buscar_Embarador(ByVal oEmbarcador As beEmbarcador) As DataTable
    Dim dt As New DataTable
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PNCAGNCR_INI", oEmbarcador.PNCAGNCR_INI)
    lobjParams.Add("PNCAGNCR_FIN", oEmbarcador.PNCAGNCR_FIN)
    lobjParams.Add("PSTNMAGC", oEmbarcador.PSTNMAGC)
    lobjParams.Add("PSSESTRG", oEmbarcador.PSSESTRG)
    dt = lobjSql.ExecuteDataTable("SP_SOLSC_BUSCAR_EMBARCADOR", lobjParams)
    Return dt
  End Function

  Public Function Registrar_Embarcador(ByVal oEmbarcador As beEmbarcador) As Integer
    Dim retorno As Integer = 0
    Dim objParam As New Parameter
    objParam.Add("PNCAGNCR", 5)
    objParam.Add("PSTNMAGC", oEmbarcador.PSTNMAGC)
    objParam.Add("PSTDIRAC", oEmbarcador.PSTDIRAC)
    objParam.Add("PNCPAIS", oEmbarcador.PNCPAIS)
    objParam.Add("PSCUSCRT", ConfigurationWizard.UserName)
    objParam.Add("PNFECHA", Format(Now, "yyyyMMdd"))
    objParam.Add("PNHORA", Format(Now, "HHmmss"))
    objParam.Add("PSSESTRG", "A")
    objSql.ExecuteNonQuery("SP_SOLSC_INSERTA_EMBARCADOR", objParam)
    retorno = 1
    Return retorno
  End Function

  Public Function Eliminar_Embarcador(ByVal CAGNCR As Int32) As Integer
    Dim retorno As Int32 = 0
    Dim objParam As New Parameter
    objParam.Add("PSCAGNCR", CAGNCR)
    objSql.ExecuteNonQuery("SP_SOLSC_ELIMINAR_EMBARCADOR", objParam)
    retorno = 1
    Return retorno
  End Function

  Public Function Restablecer_Embarcador(ByVal CAGNCR As Int32) As Integer
    Dim retorno As Int32 = 0
    Dim objParam As New Parameter
    objParam.Add("PSCAGNCR", CAGNCR)
    objSql.ExecuteNonQuery("SP_SOLSC_RESTABLECER_EMBARCADOR", objParam)
    retorno = 1
    Return retorno
  End Function

  Public Function Actualizar_Embarcador(ByVal oEmbarcador As beEmbarcador) As Integer
    Dim retorno As Int32 = 0
    Dim objParam As New Parameter
    objParam.Add("PSCAGNCR", oEmbarcador.PNCAGNCR)
    objParam.Add("PSTNMAGC", oEmbarcador.PSTNMAGC)
    objParam.Add("PSTDIRAC", oEmbarcador.PSTDIRAC)
    objParam.Add("PNCPAIS", oEmbarcador.PNCPAIS)
    objParam.Add("PSCUSCRT", ConfigurationWizard.UserName)
    objParam.Add("PNFECHA", Format(Now, "yyyyMMdd"))
    objParam.Add("PNHORA", Format(Now, "HHmmss"))
        objSql.ExecuteNonQuery("SP_SOLSC_ACTUALIZAR_EMBARCADOR", objParam)
    retorno = 1
    Return retorno
  End Function
End Class
