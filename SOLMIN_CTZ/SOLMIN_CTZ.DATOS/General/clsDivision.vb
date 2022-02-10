Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades

Public Class clsDivision
    'Public Function Lista_Division() As DataTable
    '    Dim dt As DataTable
    '    Dim lobjSql As New SqlManager

    '    dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_DIVISION", Nothing)
    '    Return dt
    'End Function

    Public Function Lista_Division_X_Usuario() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSMMCUSR", ConfigurationWizard.UserName)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_DIVISION_X_USUARIO", lobjParams)
        Return dt
    End Function

    Public Function Lista_Division_X_CompaniaUsuario(Cccmpn As String, Usuario As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSMMCUSR", ConfigurationWizard.UserName)
        lobjParams.Add("PSCCMPN", Cccmpn)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_LISTA_DIVISION_X_USUARIO_V2", lobjParams)
        Return dt
    End Function

    Public Function Lista_Division_X_CompaniaUsuario_OS(Cccmpn As String, Usuario As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSMMCUSR", ConfigurationWizard.UserName)
        lobjParams.Add("PSCCMPN", Cccmpn)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_LISTA_DIVISION_X_USUARIO_OS", lobjParams)
        Return dt
    End Function

    '
End Class

