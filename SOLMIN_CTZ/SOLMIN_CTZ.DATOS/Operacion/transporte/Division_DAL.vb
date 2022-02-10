Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades.mantenimientos

Public Class Division_DAL
    Public Function Lista_Division() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager

        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_DIVISION", Nothing)
        Return dt
    End Function

    Public Function Lista_Division_X_Usuario(ByVal strCompania As String) As List(Of ClaseGeneral)
        Dim objDataTable As DataTable
        Dim objLisClaseGeneral As New List(Of ClaseGeneral)
        Dim objClaseGeneral As ClaseGeneral
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Try
            lobjParams.Add("PSMMCUSR", ConfigurationWizard.UserName)
            'lobjSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCompania)
            objDataTable = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_DIVISION_X_USUARIO", lobjParams)

            For Each objDataRow As DataRow In objDataTable.Rows
                objClaseGeneral = New ClaseGeneral
                objClaseGeneral.CDVSN = objDataRow("CDVSN").ToString.Trim
                objClaseGeneral.TCMPDV = objDataRow("TCMPDV").ToString.Trim
                objClaseGeneral.CCMPN = objDataRow("CCMPN").ToString.Trim
                objLisClaseGeneral.Add(objClaseGeneral)
            Next
        Catch ex As Exception
        End Try
        Return objLisClaseGeneral
    End Function
End Class

