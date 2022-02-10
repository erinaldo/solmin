Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Mantenimientos

Namespace mantenimientos

  Public Class ConfiguracionVehicular_DAL

    Private objSql As New SqlManager

    Public Function Registrar_Configuracion_Vehicular(ByVal objEntidad As ConfiguracionVehicular) As ConfiguracionVehicular

      Try
        Dim objParam As New Parameter
        objParam.Add("PNCCLNAS", objEntidad.CCLNAS)
        objParam.Add("PSTCNFGV", objEntidad.TCNFGV)
        objParam.Add("PSTCNFG1", objEntidad.TCNFG1)
        objParam.Add("PSTCNFG2", objEntidad.TCNFG2)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PSFULTAC", objEntidad.FULTAC)
        objParam.Add("PNHULTAC", objEntidad.HULTAC)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
        'ejecuta el procedimiento almacenado
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_CONFIGURACION_VEHICULAR", objParam)

      Catch ex As Exception
        objEntidad.CCLNAS = 0
      End Try
      Return objEntidad
    End Function

    Public Function Listar_Configuracion_Vehicular(ByVal objetoParametro As Hashtable) As List(Of ConfiguracionVehicular)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of ConfiguracionVehicular)
      Dim objParam As New Parameter
      Dim objValidacion As New Validacion

      Try
        'Obteniendo resultados
        objParam.Add("PSTCNFGV", objetoParametro("PSTCNFGV"))
        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_CONFIGURACION_VEHICULAR", objParam)

        'Procesandolos como una Lista
        For Each objDataRow As DataRow In objDataTable.Rows
          Dim objDatos As New ConfiguracionVehicular
          objDatos.CCLNAS = objDataRow("CCLNAS").ToString.Trim
          objDatos.TCNFGV = objDataRow("TCNFGV").ToString.Trim
          objDatos.TCNFG1 = objDataRow("TCNFG1").ToString.Trim
          objDatos.TCNFG2 = objDataRow("TCNFG2").ToString.Trim
          objDatos.SESTRG = objDataRow("SESTRG").ToString.Trim
          objDatos.IMAGEN = Validacion.ImageToByte(Validacion.LoadImageFromUrl(My.Settings.DAL_URL + "imagenes/solmin/configuracion/" & objDataRow("TCNFGV").ToString.Trim & ".jpg"))
          objGenericCollection.Add(objDatos)
        Next
      Catch : End Try
      Return objGenericCollection
    End Function

  End Class


End Namespace