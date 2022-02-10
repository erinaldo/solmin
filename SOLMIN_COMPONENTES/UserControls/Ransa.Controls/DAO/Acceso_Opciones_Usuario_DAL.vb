Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Public Class Acceso_Opciones_Usuario_DAL
  Private objSql As New SqlManager

  Public Function Validar_Acceso_Opciones_Usuario(ByVal objetoParametro As Hashtable) As ClaseGeneral
    Dim objParam As New Parameter
    Dim oDt As New DataTable
    Dim objEntidad As New ClaseGeneral
    Try
      objParam.Add("PSMMCAPL", objetoParametro("MMCAPL"))
      objParam.Add("PSMMCUSR", objetoParametro("MMCUSR"))
            objParam.Add("PSMMNPVB", objetoParametro("MMNPVB"))
            '  objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("CCMPN"))
      oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_VALIDAR_ACCESO_OPCIONES_USUARIO", objParam)
      For Each objDataRow As DataRow In oDt.Rows
        objEntidad.STSVIS = objDataRow("STSVIS").ToString.Trim()
        objEntidad.STSADI = objDataRow("STSADI").ToString.Trim()
        objEntidad.STSCHG = objDataRow("STSCHG").ToString.Trim()
        objEntidad.STSELI = objDataRow("STSELI").ToString.Trim()
        objEntidad.STSOP1 = objDataRow("STSOP1").ToString.Trim()
        objEntidad.STSOP2 = objDataRow("STSOP2").ToString.Trim()
        objEntidad.STSOP3 = objDataRow("STSOP3").ToString.Trim()
      Next
      Return objEntidad
    Catch ex As Exception
      Return objEntidad
    End Try
  End Function

  Public Function Nombre_Usuario(ByVal objetoParametro As Hashtable) As String
    Dim objParam As New Parameter
    Dim oDt As New DataTable
    Dim objResult As String = ""
    Try
      objParam.Add("PSMMCUSR", objetoParametro("MMCUSR"))
      objParam.Add("PSMMNUSR", "", ParameterDirection.Output)
      '  objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("CCMPN"))
      objSql.ExecuteNonQuery("SP_SOLMIN_ST_OBTENER_NOMBRE_USUARIO", objParam)
      objResult = objSql.ParameterCollection("PSMMNUSR").ToString.Trim
    Catch ex As Exception
      objResult = ""
    End Try
    Return objResult
  End Function

End Class
