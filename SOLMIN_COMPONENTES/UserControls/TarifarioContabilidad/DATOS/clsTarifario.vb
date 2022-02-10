Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsTarifario
    'Public Function Lista_Tarifario() As DataTable
    '    Dim dt As DataTable
    '    Dim lobjSql As New SqlManager
    '    Dim lobjParams As New Parameter

    '    dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_TARIFARIO", lobjParams)
    '    Return dt
    'End Function

    Public Sub Crear_Tarifario(ByVal pobjTarifario As Tarifario)
        Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PNNRCTCL", pobjTarifario.NRCTCL)
            lobjParams.Add("PNCMNDA1", pobjTarifario.CMNDA1)
            lobjParams.Add("PSTOBS", pobjTarifario.TOBS)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
            lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
            lobjSql.ExecuteNonQuery("SP_SOLCT_CREAR_TARIFARIO", lobjParams)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function Lista_Tarifario(ByVal pobjFiltro As Filtro) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pobjFiltro.Parametro1)
        lobjParams.Add("PSCDVSN", pobjFiltro.Parametro2)
        lobjParams.Add("PNNRCTCL", pobjFiltro.Parametro3)
        lobjParams.Add("PNCMNDA1", pobjFiltro.Parametro4)
        lobjParams.Add("PNCPLNDV", pobjFiltro.Parametro5)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_TARIFARIO", lobjParams)
        Return dt
    End Function

    Public Function Busca_Cliente_Grupo(ByVal CodigoGrupo As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNRCTCL", CodigoGrupo)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_BUSCA_CLIENTE_GRUPO", lobjParams)
        Return dt
    End Function

End Class


