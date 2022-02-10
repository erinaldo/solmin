Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Namespace mantenimientos
  Public Class Viajes_Ruta_DAL
    Private objSql As New SqlManager

    Public Function Actualizar_Viaje_Ruta(ByVal ObeViaje_Ruta As Viaje_Ruta) As Integer
      Try

        Dim objParam As New Parameter

        objParam.Add("PNNPRGVJ", ObeViaje_Ruta.PNNPRGVJ)
        objParam.Add("PNNCRRRT", ObeViaje_Ruta.PNNCRRRT)

        objParam.Add("PNCLCLOR", ObeViaje_Ruta.PNCLCLOR)
        objParam.Add("PNCLCLDS", ObeViaje_Ruta.PNCLCLDS)
        objParam.Add("PNFSLDRT", ObeViaje_Ruta.PNFSLDRT)
        objParam.Add("PNHSLDRT", ObeViaje_Ruta.PNHSLDRT)
        objParam.Add("PNQCPSDS", ObeViaje_Ruta.PNQCPSDS)

        objParam.Add("PSCULUSA", ObeViaje_Ruta.PSCULUSA)
        objParam.Add("PNFULTAC", ObeViaje_Ruta.PNFULTAC)
        objParam.Add("PNHULTAC", ObeViaje_Ruta.PNHULTAC)
        objParam.Add("PSNTRMNL", ObeViaje_Ruta.PSNTRMNL)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_VIAJE_RUTA", objParam)
        Return 1
      Catch ex As Exception
        Return 0
      End Try
    End Function



    Public Function Insertar_Viaje_Ruta(ByVal ObeViaje_Ruta As Viaje_Ruta) As Integer
      Try
        Dim objParam As New Parameter

        objParam.Add("PNNPRGVJ", ObeViaje_Ruta.PNNPRGVJ)
        'objParam.Add("PNNCRRRT", ObeViaje_Ruta.PNNCRRRT)
        objParam.Add("PNCLCLOR", ObeViaje_Ruta.PNCLCLOR)
        objParam.Add("PNCLCLDS", ObeViaje_Ruta.PNCLCLDS)
        objParam.Add("PNFSLDRT", ObeViaje_Ruta.PNFSLDRT)
        objParam.Add("PNHSLDRT", ObeViaje_Ruta.PNHSLDRT)
        objParam.Add("PNQCPSDS", ObeViaje_Ruta.PNQCPSDS)
        objParam.Add("PSSESTRG", ObeViaje_Ruta.PSSESTRG)
        objParam.Add("PSCUSCRT", ObeViaje_Ruta.PSCUSCRT)
        objParam.Add("PNFCHCRT", ObeViaje_Ruta.PNFCHCRT)
        objParam.Add("PNHRACRT", ObeViaje_Ruta.PNHRACRT)
        objParam.Add("PSNTRMCR", ObeViaje_Ruta.PSNTRMCR)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_VIAJE_RUTA", objParam)
        Return 1
      Catch ex As Exception
        Return 0
      End Try
    End Function

    Public Function Listar_Viaje_Ruta(ByVal ObeViaje_Ruta As Viaje_Ruta) As List(Of Viaje_Ruta)
      Dim oDt As New DataTable
      Dim loViaje_Ruta As New List(Of Viaje_Ruta)
      Dim objParam As New Parameter
      Try
        objParam.Add("PNNPRGVJ", ObeViaje_Ruta.PNNPRGVJ)
        oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_VIAJE_RUTA", objParam)
        For Each objDataRow As DataRow In oDt.Rows
          Dim objEntidad As New Viaje_Ruta
          objEntidad.PNNPRGVJ = objDataRow("NPRGVJ").ToString.Trim
          objEntidad.PNNCRRRT = objDataRow("NCRRRT").ToString.Trim
          objEntidad.PSCLCLOR = objDataRow("ORIGEN").ToString.Trim
          objEntidad.PSCLCLDS = objDataRow("DESTINO").ToString.Trim
                    objEntidad.PSFSLDRT = Validacion.CFecha_a_Numero10Digitos(objDataRow("FSLDRT").ToString.Trim)
          objEntidad.PSHSLDRT = objDataRow("HSLDRT").ToString.Trim
          objEntidad.PNFSLDRT = objDataRow("FSLDRT_1").ToString.Trim
          objEntidad.PNHSLDRT = objDataRow("HSLDRT_1").ToString.Trim
          objEntidad.PNQCPSDS = objDataRow("QCPSDS").ToString.Trim
          objEntidad.PNQCPSUT = objDataRow("QCPSUT").ToString.Trim
          objEntidad.PNCLCLOR = objDataRow("CLCLOR").ToString.Trim
          objEntidad.PNCLCLDS = objDataRow("CLCLDS").ToString.Trim
          loViaje_Ruta.Add(objEntidad)
        Next
      Catch ex As Exception
      End Try
      Return loViaje_Ruta
    End Function

    Public Function Eliminar_Viaje_Ruta(ByVal ObeViaje_Ruta As Viaje_Ruta) As Integer
      Dim objParam As New Parameter
      Try
        objParam.Add("PNNPRGVJ", ObeViaje_Ruta.PNNPRGVJ)
        objParam.Add("PNNCRRRT", ObeViaje_Ruta.PNNCRRRT)
        objParam.Add("PSSESTRG", ObeViaje_Ruta.PSSESTRG)
        objParam.Add("PSCULUSA", ObeViaje_Ruta.PSCULUSA)
        objParam.Add("PNFULTAC", ObeViaje_Ruta.PNFULTAC)
        objParam.Add("PNHULTAC", ObeViaje_Ruta.PNHULTAC)
        objParam.Add("PSNTRMNL", ObeViaje_Ruta.PSNTRMNL)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_VIAJE_RUTA", objParam)
        Return 1
      Catch ex As Exception
        Return 0
      End Try
    End Function

  End Class
End Namespace



