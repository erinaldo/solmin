
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades.mantenimientos

Public Class Planta_DAL

    Public Function Lista_Planta_X_Usuario(ByVal strCompania As String) As List(Of ClaseGeneral)
        Dim objDataTable As DataTable
        Dim objLisClaseGeneral As New List(Of ClaseGeneral)
        Dim objClaseGeneral As ClaseGeneral
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Try
            lobjParams.Add("PSMMCUSR", ConfigurationWizard.UserName)
            'lobjSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCompania)
            objDataTable = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_PLANTA_X_USUARIO", lobjParams)
            For Each objDataRow As DataRow In objDataTable.Rows
                objClaseGeneral = New ClaseGeneral
                objClaseGeneral.CPLNDV = objDataRow("CPLNDV").ToString.Trim
                objClaseGeneral.TPLNTA = objDataRow("TPLNTA").ToString.Trim
                objClaseGeneral.CDVSN = objDataRow("CDVSN").ToString.Trim
                objClaseGeneral.CCMPN = objDataRow("CCMPN").ToString.Trim
                objClaseGeneral.CRGVTA = objDataRow("CRGVTA").ToString.Trim
                objLisClaseGeneral.Add(objClaseGeneral)
            Next

        Catch ex As Exception
        End Try
        Return objLisClaseGeneral

    End Function
End Class
