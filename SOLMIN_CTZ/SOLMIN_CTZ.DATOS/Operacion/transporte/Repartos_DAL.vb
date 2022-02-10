Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.ENTIDADES.Operaciones
Imports SOLMIN_CTZ.ENTIDADES.Mantenimientos

Namespace Operaciones
  Public Class Repartos_DAL
    Private objSql As New SqlManager

    Public Function Listar_Operaciones_Reparto(ByVal objParametros As List(Of String)) As List(Of Repartos)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of Repartos)
      Dim objParam As New Parameter
      Try
        objParam.Add("PNNMOPRP", objParametros(0))
        objParam.Add("PNCCLNT", objParametros(1))
        objParam.Add("PSSESTSO", objParametros(2))
        If objParametros(3) <> "" And objParametros(4) <> "" Then
          objParam.Add("PNFECINI", objParametros(3))
          objParam.Add("PNFECFIN", objParametros(4))
        End If
        objParam.Add("PSCCMPN", objParametros(5))
        objParam.Add("PSCDVSN", objParametros(6))
        objParam.Add("PSCPLNDV", objParametros(7))

        'ejecuta el procedimiento almacenado
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros(5))

        'Obteniendo resultados
        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OP_REPARTO", objParam)
        'Procesandolos como una Lista
        For Each objData As DataRow In objDataTable.Rows
          Dim objDatos As New Repartos
          objDatos.NMOPRP = objData("NMOPRP")
          objDatos.CCLNT = objData("CCLNT")
          objDatos.TCMPCL = objData("TCMPCL").ToString.Trim
          objDatos.FECREP_S = objData("FECREP").ToString.Trim
          objDatos.NRUCTR = objData("NRUCTR")
          objDatos.NPLCUN = objData("NPLCUN").ToString.Trim
          objDatos.TREFCL = objData("TREFCL").ToString.Trim
          objDatos.SESTSO = objData("SESTSO").ToString.Trim
          objGenericCollection.Add(objDatos)
        Next
      Catch ex As Exception
      End Try
      Return objGenericCollection
    End Function

    Public Function Registrar_Operacion_Reparto(ByVal objEntidad As Repartos) As Repartos
      Try
        Dim objParam As New Parameter

        objParam.Add("PARAM_NMOPRP", objEntidad.NMOPRP, ParameterDirection.Output)
        objParam.Add("PARAM_CCMPN", objEntidad.CCMPN)
        objParam.Add("PARAM_FECREP", objEntidad.FECREP)
        objParam.Add("PARAM_TREFCL", objEntidad.TREFCL)
        objParam.Add("PARAM_CCLNT", objEntidad.CCLNT)
        objParam.Add("PARAM_NRUCTR", objEntidad.NRUCTR)
        objParam.Add("PARAM_NPLCUN", objEntidad.NPLCUN)
        objParam.Add("PARAM_CDVSN", objEntidad.CDVSN)
        objParam.Add("PARAM_CPLNDV", objEntidad.CPLNDV)
        objParam.Add("PARAM_SESTSO", objEntidad.SESTSO)
        objParam.Add("PARAM_SESTRG", objEntidad.SESTRG)
        objParam.Add("PARAM_CUSCRT", objEntidad.CUSCRT)
        objParam.Add("PARAM_FCHCRT", objEntidad.FCHCRT)
        objParam.Add("PARAM_HRACRT", objEntidad.HRACRT)
        objParam.Add("PARAM_NTRMCR", objEntidad.NTRMCR)
        objParam.Add("PARAM_CULUSA", objEntidad.CULUSA)
        objParam.Add("PARAM_FULTAC", objEntidad.FULTAC)
        objParam.Add("PARAM_HULTAC", objEntidad.HULTAC)
        objParam.Add("PARAM_NTRMNL", objEntidad.NTRMNL)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_OP_REPARTO", objParam)
        objEntidad.NMOPRP = objSql.ParameterCollection("PARAM_NMOPRP").ToString()
      Catch ex As Exception
        objEntidad.NMOPRP = 0
      End Try
      Return objEntidad
    End Function

    Public Function Modificar_Operacion_Reparto(ByVal objEntidad As Repartos) As Repartos
      Try
        Dim objParam As New Parameter
        objParam.Add("PARAM_NMOPRP", objEntidad.NMOPRP)
        objParam.Add("PARAM_CCLNT", objEntidad.CCLNT)
        objParam.Add("PARAM_FECREP", objEntidad.FECREP)
        objParam.Add("PARAM_NRUCTR", objEntidad.NRUCTR)
        objParam.Add("PARAM_NPLCUN", objEntidad.NPLCUN)
        objParam.Add("PARAM_TREFCL", objEntidad.TREFCL)
        objParam.Add("PARAM_CULUSA", objEntidad.CULUSA)
        objParam.Add("PARAM_FULTAC", objEntidad.FULTAC)
        objParam.Add("PARAM_HULTAC", objEntidad.HULTAC)
        objParam.Add("PARAM_NTRMNL", objEntidad.NTRMNL)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_OPERACION_REPARTO", objParam)
      Catch ex As Exception
        objEntidad.NMOPRP = 0
      End Try
      Return objEntidad
    End Function

    Public Function Eliminar_Operacion_Reparto(ByVal objEntidad As Repartos)
      Try
        Dim objParam As New Parameter
        objParam.Add("PNNMOPRP", objEntidad.NMOPRP)
        objParam.Add("PSSESTRG", objEntidad.SESTRG)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PNFULTAC", objEntidad.FULTAC)
        objParam.Add("PNHULTAC", objEntidad.HULTAC)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_CAMBIAR_ESTADO_OP_REPARTOS", objParam)
      Catch ex As Exception
        objEntidad.NMOPRP = 0
      End Try
      Return objEntidad
    End Function

    Public Function Listar_Reporte_Operacion_Reparto(ByVal objParametros As List(Of String)) As DataSet

      Dim objDataSet As New DataSet
      Dim objParam As New Parameter

      Try
        objParam.Add("PNNMOPRP", objParametros(0))
        objParam.Add("PNCCLNT", objParametros(1))
        objParam.Add("PSSESTSO", objParametros(2))
        If objParametros(3) <> "" And objParametros(4) <> "" Then
          objParam.Add("PNFECINI", objParametros(3))
          objParam.Add("PNFECFIN", objParametros(4))
        End If
        objParam.Add("PSCCMPN", objParametros(5))
        objParam.Add("PSCDVSN", objParametros(6))
        objParam.Add("PSCPLNDV", objParametros(7))
        'ejecuta el procedimiento almacenado
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros(5))

        objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_REPORTE_OPE_REPARTO", objParam)

      Catch ex As Exception

      End Try

      Return objDataSet
    End Function

    Public Function Modificar_Estado_Operacion_Reparto(ByVal objEntidad As Repartos) As Repartos
      Try
        Dim objParam As New Parameter
        objParam.Add("PNNMOPRP", objEntidad.NMOPRP)
        objParam.Add("PSSESTSO", objEntidad.SESTSO)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PNFULTAC", objEntidad.FULTAC)
        objParam.Add("PNHULTAC", objEntidad.HULTAC)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_ESTADO_OPERACION_REPARTO", objParam)
      Catch ex As Exception
        objEntidad.NMOPRP = 0
      End Try
      Return objEntidad
    End Function

    'Public Function Listar_Consistencia_Operacion_Reparto(ByVal objEntidad As Hashtable) As DataTable
    '  Dim objDataTable As New DataTable
    '  Dim objParam As New Parameter

    '  Try
    '    objParam.Add("PNCCLNT", objEntidad("PNCCLNT"))
    '    objParam.Add("PNNORSRT", objEntidad("PNNORSRT"))
    '    objParam.Add("PNFECINI", objEntidad("PNFECINI"))
    '    objParam.Add("PNFECFIN", objEntidad("PNFECFIN"))
    '    objParam.Add("PSCCMPN", objEntidad("PSCCMPN"))
    '    objParam.Add("PSCDVSN", objEntidad("PSCDVSN"))
    '    'ejecuta el procedimiento almacenado
    '    objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad("PSCCMPN"))

    '    objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_OPERACION_LIQUIDACION_REPARTO", objParam)

    '  Catch ex As Exception

    '  End Try

    '  Return objDataTable
    'End Function

    'Public Function Imprimir_Consistencia_Operacion_Reparto(ByVal objEntidad As Hashtable) As DataSet
    '  Dim objDataTable As New DataSet
    '  Dim objParam As New Parameter

    '  Try
    '    objParam.Add("PNNOPRCN", objEntidad("PNNOPRCN"))
    '    'ejecuta el procedimiento almacenado
    '    objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad("PSCCMPN"))

    '    objDataTable = objSql.ExecuteDataSet("SP_SOLMIN_ST_REPORTE_OPERACION_LIQUIDACION_REPARTO", objParam)

    '  Catch ex As Exception

    '  End Try

    '  Return objDataTable
    'End Function

    Public Function Eliminar_Operacion_Reparto_Guia_Remision_Servicio(ByVal objEntidad As Repartos)
      Try
        Dim objParam As New Parameter
        objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
        objParam.Add("PNNGUIRM", objEntidad.NGUITR)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_GUIA_REMISION_SERVICIO", objParam)
      Catch ex As Exception
        objEntidad.NMOPRP = 0
      End Try
      Return objEntidad
    End Function

    Public Function Exportar_Factura_Reparto(ByVal objEntidad As Hashtable) As DataTable
      Dim objDataTable As New DataTable
      Dim objParam As New Parameter

      Try
        objParam.Add("PSCCMPN", objEntidad("PSCCMPN"))
        objParam.Add("PSCDVSN", objEntidad("PSCDVSN"))
        objParam.Add("PNNDCMFC", objEntidad("PNNDCMFC"))

        'ejecuta el procedimiento almacenado
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad("PSCCMPN"))

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_EXPORTAR_FACTURA_REPARTO", objParam)

      Catch ex As Exception

      End Try

      Return objDataTable
    End Function

  End Class
End Namespace
