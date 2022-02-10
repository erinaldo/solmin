Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsDivision
    'Public Function Lista_Division() As DataTable
    '    Dim dt As DataTable
    '    Dim lobjSql As New SqlManager

    '    dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_DIVISION", Nothing)
    '    Return dt
    'End Function

    Public Function Lista_Division_X_Usuario(ByVal usuario As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSMMCUSR", usuario)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_DIVISION_X_USUARIO", lobjParams)
        Return dt
    End Function
End Class

