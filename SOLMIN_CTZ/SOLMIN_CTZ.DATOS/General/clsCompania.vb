Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades

Public Class clsCompania
    'Public Function Lista_Compania() As DataTable
    '    Dim dt As DataTable
    '    Dim lobjSql As New SqlManager

    '    dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_COMPANIA", Nothing)
    '    Return dt
    'End Function

    Public Function Lista_Compania_X_Usuario() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSMMCUSR", ConfigurationWizard.UserName)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_COMPANIA_X_USUARIO", lobjParams)
        Return dt
    End Function

    Public Function Nombre_Usuario(ByVal strUsuario As String) As String
        Dim objParam As New Parameter
        Dim lobjSql As New SqlManager
        Dim objResult As Object

        Try
            objParam.Add("PSMMCUSR", strUsuario)
            objParam.Add("PSMMNUSR", "", ParameterDirection.Output)

            lobjSql.ExecuteNonQuery("SP_SOLMIN_ST_OBTENER_NOMBRE_USUARIO", objParam)
            objResult = lobjSql.ParameterCollection("PSMMNUSR").ToString.Trim
        Catch ex As Exception
            objResult = ""
        End Try
        Return objResult
    End Function
End Class

