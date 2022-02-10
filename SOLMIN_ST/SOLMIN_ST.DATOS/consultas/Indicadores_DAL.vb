Imports Db2Manager.RansaData.iSeries.DataObjects


Namespace Consultas
  Public Class Indicadores_DAL
    Private objSql As New SqlManager
    Public Function Indicador_Operativo_km_Recorrido(ByVal objParametro As Hashtable) As DataTable
      Dim dt As DataTable = Nothing
      Dim objParam As New Parameter
      Try
        objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
        objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
        objParam.Add("PNCPLNDV", objParametro("PNCPLNDV"))
        objParam.Add("PNFECINI", objParametro("PNFECINI"))
        objParam.Add("PNFECFIN", objParametro("PNFECFIN"))
        objParam.Add("PNCCLNT", objParametro("PNCCLNT"))
        objParam.Add("PNCTRMNC", objParametro("PNCTRMNC"))
        objParam.Add("PSNPLCUN", objParametro("PSNPLCUN"))
        objParam.Add("PNESTADO", objParametro("PNESTADO"))
        objParam.Add("PNCMEDTR", objParametro("PNCMEDTR"))

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_INDICADOR_OPERATIVO_KM_RECORRIDO", objParam)
                'dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_INDICADOR_OPERATIVO_KM_RECORRIDO_PRD", objParam)
      Catch ex As Exception
      End Try
      Return dt
    End Function
    Public Function Indicador_Operativo_Peso_Traslado(ByVal objParametro As Hashtable) As DataTable
      Dim dt As DataTable = Nothing
      Dim objParam As New Parameter
      Try
        objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
        objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
        objParam.Add("PNCPLNDV", objParametro("PNCPLNDV"))
        objParam.Add("PNFECINI", objParametro("PNFECINI"))
        objParam.Add("PNFECFIN", objParametro("PNFECFIN"))
        objParam.Add("PNCCLNT", objParametro("PNCCLNT"))
        objParam.Add("PNCTRMNC", objParametro("PNCTRMNC"))
        objParam.Add("PSNPLCUN", objParametro("PSNPLCUN"))
        objParam.Add("PNESTADO", objParametro("PNESTADO"))
objParam.Add("PNCMEDTR", objParametro("PNCMEDTR"))

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_INDICADOR_OPERATIVO_PESO_TRASLADADO", objParam)
                'dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_INDICADOR_OPERATIVO_PESO_TRASLADADO_PRD", objParam)
      Catch ex As Exception
      End Try
      Return dt
    End Function
    Public Function Indicador_Operativo_Cantidad_Traslado(ByVal objParametro As Hashtable) As DataTable
      Dim dt As DataTable = Nothing
      Dim objParam As New Parameter
      Try
        objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
        objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
        objParam.Add("PNCPLNDV", objParametro("PNCPLNDV"))
        objParam.Add("PNFECINI", objParametro("PNFECINI"))
        objParam.Add("PNFECFIN", objParametro("PNFECFIN"))
        objParam.Add("PNCCLNT", objParametro("PNCCLNT"))
        objParam.Add("PNCTRMNC", objParametro("PNCTRMNC"))
        objParam.Add("PSNPLCUN", objParametro("PSNPLCUN"))
        objParam.Add("PNESTADO", objParametro("PNESTADO"))
objParam.Add("PNCMEDTR", objParametro("PNCMEDTR"))

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_INDICADOR_OPERATIVO_CANTIDAD_TRASLADADO", objParam)
                'dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_INDICADOR_OPERATIVO_CANTIDAD_TRASLADADO_PRD", objParam)
      Catch ex As Exception
      End Try
      Return dt
    End Function
    Public Function Indicador_Operativo_Viajes_Realizado(ByVal objParametro As Hashtable) As DataTable
      Dim dt As DataTable = Nothing
      Dim objParam As New Parameter
      Try
        objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
        objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
        objParam.Add("PNCPLNDV", objParametro("PNCPLNDV"))
        objParam.Add("PNFECINI", objParametro("PNFECINI"))
        objParam.Add("PNFECFIN", objParametro("PNFECFIN"))
        objParam.Add("PNCCLNT", objParametro("PNCCLNT"))
        objParam.Add("PNCTRMNC", objParametro("PNCTRMNC"))
        objParam.Add("PSNPLCUN", objParametro("PSNPLCUN"))
        objParam.Add("PNESTADO", objParametro("PNESTADO"))
objParam.Add("PNCMEDTR", objParametro("PNCMEDTR"))

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_INDICADOR_OPERATIVO_VIAJES_REALIZADO", objParam)
                'dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_INDICADOR_OPERATIVO_VIAJES_REALIZADO_PRD", objParam)
      Catch ex As Exception
      End Try
      Return dt
    End Function
     Public Function Indicador_Operativo_Rutas(ByVal objParametro As Hashtable) As DataTable
      Dim dt As DataTable = Nothing
      Dim objParam As New Parameter
      Try
        objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
        objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
        objParam.Add("PNCPLNDV", objParametro("PNCPLNDV"))
        objParam.Add("PNFECINI", objParametro("PNFECINI"))
        objParam.Add("PNFECFIN", objParametro("PNFECFIN"))
        objParam.Add("PNCCLNT", objParametro("PNCCLNT"))
        objParam.Add("PNCTRMNC", objParametro("PNCTRMNC"))
        objParam.Add("PSNPLCUN", objParametro("PSNPLCUN"))
        objParam.Add("PNESTADO", objParametro("PNESTADO"))
objParam.Add("PNCMEDTR", objParametro("PNCMEDTR"))

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_INDICADOR_OPERATIVO_RUTA", objParam)
                'dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_INDICADOR_OPERATIVO_RUTA_PRD", objParam)
      Catch ex As Exception
      End Try
      Return dt
    End Function
  End Class
End Namespace
