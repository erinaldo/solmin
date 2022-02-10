Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsCompania
    'Public Function Lista_Compania() As DataTable
    '    Dim dt As DataTable
    '    Dim lobjSql As New SqlManager

    '    dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_COMPANIA", Nothing)
    '    Return dt
    'End Function

    Public Function Lista_Compania_X_Usuario(ByVal usuario As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        'Falta Default Schema y Cadena de Conexion
        lobjParams.Add("PSMMCUSR", usuario)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_COMPANIA_X_USUARIO", lobjParams)
        Return dt
    End Function
End Class

