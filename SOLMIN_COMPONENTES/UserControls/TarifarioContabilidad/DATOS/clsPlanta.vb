Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsPlanta

    Public Function Lista_Planta_X_Usuario(ByVal usuario As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSMMCUSR", usuario)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_PLANTA_X_USUARIO", lobjParams)
        Return dt
    End Function
End Class

