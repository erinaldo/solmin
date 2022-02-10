Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.Mantenimientos

Namespace Operaciones
  Public Class Multimodal_DAL
    Private objSql As New SqlManager


        Public Function Listar_Operaciones_Multimodal_Filtro(ByVal objParametro As Hashtable) As DataTable
            Dim objDatatable As New DataTable
            Dim objParam As New Parameter
            objParam.Add("PNNMOPMM", objParametro("NMOPMM"))
            objParam.Add("PNCCLNT", objParametro("CCLNT"))
            objParam.Add("PNFECINI", objParametro("FECINI"))
            objParam.Add("PNFECFIN", objParametro("FECFIN"))
            objParam.Add("PSCCMPN", objParametro("CCMPN"))
            objParam.Add("PSCDVSN", objParametro("CDVSN"))
            objParam.Add("PSCPLNDV", objParametro("CPLNDV"))

            objParam.Add("PNCMEDTR", objParametro("CMEDTR"))
            objParam.Add("PNCTRSPT", objParametro("CTRSPT"))
            objParam.Add("PSNPLCUN", objParametro("NPLCUN"))
            objParam.Add("PSNPLCAC", objParametro("NPLCAC"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("CCMPN"))
            objDatatable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OP_MULTIMODAL_FILTRO_LM", objParam)
            Return objDatatable
        End Function

        Public Function Importar_Operaciones_Multimodal(ByVal objParametro As Hashtable) As Integer
            Try

                Dim objDatatable As New DataTable
                Dim objParam As New Parameter
                objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
                objParam.Add("PSNRUCTR", objParametro("PSNRUCTR"))
                objParam.Add("PNNMVJCS", objParametro("PNNMVJCS"))
                objParam.Add("PNNGUIRM", objParametro("PNNGUIRM"))
                objParam.Add("PNNCSOTR", objParametro("PNNCSOTR"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("CCMPN"))
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_IMPORTAR_OPERACION_MULTIMODAL", objParam)
                Return 1
            Catch ex As Exception
                Return -1
            End Try
        End Function

    Public Function Listar_Operaciones_Multimodal(ByVal objParametros As List(Of String)) As List(Of Multimodal)
      Dim objDataTable As New DataTable
      Dim objDatos As Multimodal
      Dim objGenericCollection As New List(Of Multimodal)
      Dim objParam As New Parameter
      Try
        objParam.Add("PNNMOPMM", objParametros(0))
        objParam.Add("PNCCLNT", objParametros(1))
        objParam.Add("PSSESTOP", objParametros(2))
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
        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OP_MULTIMODAL", objParam)
        'Procesandolos como una Lista
        For Each objData As DataRow In objDataTable.Rows
          objDatos = New Multimodal
          objDatos.NMOPMM = objData("NMOPMM")
          objDatos.CCLNT = objData("CCLNT")
          objDatos.TCMPCL = objData("TCMPCL").ToString.Trim
          objDatos.ITINERA = objData("ITINERA").ToString.Trim
          objDatos.NRORTA = objData("NRORTA")
          objDatos.TOBRCP = objData("TOBS").ToString.Trim
          objDatos.SESTOP = objData("SESTOP").ToString.Trim
          objDatos.FCOPMM_S = objData("FECOST").ToString.Trim
          objGenericCollection.Add(objDatos)
        Next
      Catch ex As Exception
      End Try
      Return objGenericCollection
    End Function

    Public Function Registrar_Operacion_Multimodal(ByVal objEntidad As Multimodal) As Multimodal
      Try
        Dim objParam As New Parameter

        objParam.Add("PARAM_NMOPMM", objEntidad.NMOPMM, ParameterDirection.Output)
        objParam.Add("PARAM_CCMPN", objEntidad.CCMPN)
        objParam.Add("PARAM_FCOPMM", objEntidad.FCOPMM)
        objParam.Add("PARAM_TOBRCP", objEntidad.TOBRCP)
        objParam.Add("PARAM_CCLNT", objEntidad.CCLNT)
        objParam.Add("PARAM_NRORTA", objEntidad.NRORTA)
        objParam.Add("PARAM_CDVSN", objEntidad.CDVSN)
        objParam.Add("PARAM_CPLNDV", objEntidad.CPLNDV)
        objParam.Add("PARAM_SESTOP", objEntidad.SESTOP)
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
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_OP_MULTIMODAL", objParam)
        objEntidad.NMOPMM = objSql.ParameterCollection("PARAM_NMOPMM").ToString()
      Catch ex As Exception
        objEntidad.NMOPMM = 0
      End Try
      Return objEntidad
    End Function

    Public Function Modificar_Operacion_Multimodal(ByVal objEntidad As Multimodal) As Multimodal
      Try
        Dim objParam As New Parameter
        objParam.Add("PARAM_NMOPMM", objEntidad.NMOPMM)
        objParam.Add("PARAM_CCLNT", objEntidad.CCLNT)
        objParam.Add("PARAM_FCOPMM", objEntidad.FCOPMM)
        objParam.Add("PARAM_NRORTA", objEntidad.NRORTA)
        objParam.Add("PARAM_TOBRCP", objEntidad.TOBRCP)
        objParam.Add("PARAM_CULUSA", objEntidad.CULUSA)
        objParam.Add("PARAM_FULTAC", objEntidad.FULTAC)
        objParam.Add("PARAM_HULTAC", objEntidad.HULTAC)
        objParam.Add("PARAM_NTRMNL", objEntidad.NTRMNL)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_OPERACION_MULTIMODAL", objParam)
      Catch ex As Exception
        objEntidad.NMOPMM = 0
      End Try
      Return objEntidad
    End Function

    Public Function Eliminar_Operacion_Multimodal(ByVal objEntidad As Multimodal)
      Try
        Dim objParam As New Parameter
        objParam.Add("PNNMOPMM", objEntidad.NMOPMM)
        objParam.Add("PSSESTRG", objEntidad.SESTRG)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PNFULTAC", objEntidad.FULTAC)
        objParam.Add("PNHULTAC", objEntidad.HULTAC)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_CAMBIAR_ESTADO_OP_MULTIMODAL", objParam)
      Catch ex As Exception
        objEntidad.NMOPMM = 0
      End Try
      Return objEntidad
    End Function

    Public Function Listar_Reporte_Operacion_Multimodal(ByVal objParametros As List(Of String)) As DataSet
      Dim objDataSet As New DataSet
      'Dim objGenericCollection As New List(Of Multimodal)
      Dim objParam As New Parameter
      Try
        objParam.Add("PNNMOPMM", objParametros(0))
        objParam.Add("PNCCLNT", objParametros(1))
        objParam.Add("PSSESTOP", objParametros(2))
        If objParametros(3) <> "" And objParametros(4) <> "" Then
          objParam.Add("PNFECINI", objParametros(3))
          objParam.Add("PNFECFIN", objParametros(4))
        End If
        objParam.Add("PSCCMPN", objParametros(5))
        objParam.Add("PSCDVSN", objParametros(6))
        objParam.Add("PSCPLNDV", objParametros(7))
        objParam.Add("PSREPMODO", objParametros(8))
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros(5))
        objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_REPORTE_OP_MULTIMODAL", objParam)

      Catch ex As Exception

      End Try

      Return objDataSet
    End Function

    Public Function Listar_Reporte_Bulto(ByVal objParametro As Hashtable) As DataSet
      Dim objDataSet As New DataSet
      'Dim objGenericCollection As New List(Of Multimodal)
      Dim objParam As New Parameter
      Try
        objParam.Add("PNNMOPMM", objParametro("NMOPMM"))
        objParam.Add("PSCCMPN", objParametro("CCMPN"))
        objParam.Add("PSCDVSN", objParametro("CDVSN"))
        objParam.Add("PSCPLNDV", objParametro("CPLNDV"))
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("CCMPN"))
        objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_REPORTE_BULTO", objParam)
      Catch ex As Exception
        objDataSet = New DataSet
      End Try

      Return objDataSet
    End Function

    End Class
End Namespace


