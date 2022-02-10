Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades

Public Class clsRubroXDivision
    Public Sub Agregar_Rubro_Division(ByRef oSqlMan As SqlManager, ByVal pobjRubro_X_Division As Rubro_X_Division)
        Try
            Dim lobjParams As New Parameter

            lobjParams.Add("PSCCMPN", pobjRubro_X_Division.CCMPN)
            lobjParams.Add("PSCDVSN", pobjRubro_X_Division.CDVSN)
            lobjParams.Add("PNNRRUBR", pobjRubro_X_Division.NRRUBR)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
            lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
            oSqlMan.ExecuteNonQuery("SP_SOLCT_AGREGAR_RUBRO_DIVISION", lobjParams)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
