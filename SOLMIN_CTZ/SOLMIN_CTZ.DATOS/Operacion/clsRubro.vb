Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades

Public Class clsRubro
    Public Sub Crear_Rubro(ByVal pobjRubro As Rubro)
        Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PSCCMPN", pobjRubro.CCMPN)
            lobjParams.Add("PSCDVSN", pobjRubro.CDVSN)
            ' lobjParams.Add("PSCRGVTA", pobjRubro.CRGVTA)
            lobjParams.Add("PSNOMRUB", pobjRubro.NOMRUB)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
            lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
            'lobjSql.ExecuteNonQuery("SP_SOLCT_CREAR_RUBRO", lobjParams)
            lobjSql.ExecuteNonQuery("SP_SOLCT_CREAR_RUBRO_RZSC07", lobjParams)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Actualizar_Rubro(ByVal pobjRubro As Rubro)
        Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PNNRRUBR", pobjRubro.NRRUBR)
            lobjParams.Add("PSNOMRUB", pobjRubro.NOMRUB)
            lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
            lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
            lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
            lobjSql.ExecuteNonQuery("SP_SOLCT_ACTUALIZAR_RUBRO", lobjParams)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Quitar_Rubro_X_Division(ByVal pobjRubro As Rubro)
        Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PNNRRUBR", pobjRubro.NRRUBR)
            lobjParams.Add("PCULUSA", ConfigurationWizard.UserName)
            lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
            lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
            lobjSql.ExecuteNonQuery("SP_SOLCT_BORRAR_RUBRO", lobjParams)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function Verificar_Rubro(ByVal pobjRubro As Rubro) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNRRUBR", pobjRubro.NRRUBR)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_VERIFICA_RUBRO", lobjParams)
        Return dt
    End Function

End Class