Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Mantenimientos

Public Class Compania_DAL

  Public Function Lista_Compania() As DataTable
    Dim dt As DataTable
    Dim lobjSql As New SqlManager

    dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_COMPANIA", Nothing)
    Return dt
  End Function

  Public Function Lista_Compania_X_Usuario() As List(Of ClaseGeneral)
    Dim objDataTable As DataTable
    Dim objLisClaseGeneral As New List(Of ClaseGeneral)
    Dim objClaseGeneral As ClaseGeneral
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    Try
      lobjParams.Add("PSMMCUSR", ConfigurationWizard.UserName)
            objDataTable = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_COMPANIA_X_USUARIO", lobjParams)

      For Each objDataRow As DataRow In objDataTable.Rows
        objClaseGeneral = New ClaseGeneral
        objClaseGeneral.CCMPN = objDataRow("CCMPN").ToString.Trim
        objClaseGeneral.TCMPCM = objDataRow("TCMPCM").ToString.Trim
        objLisClaseGeneral.Add(objClaseGeneral)
      Next
    Catch ex As Exception
    End Try
    Return objLisClaseGeneral
  End Function

End Class
