Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad
Imports Ransa.Utilitario
Public Class clsPais
    Public Function Lista_Pais() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager

        dt = lobjSql.ExecuteDataTable("SP_SOLSC_PAIS", Nothing)
        Return dt
    End Function

    Public Function Listar_Pais() As List(Of bePais)
        Dim dt As DataTable
        Dim obePais As bePais
        Dim oListPais As New List(Of bePais)
        Dim lobjSql As New SqlManager
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_PAIS", Nothing)
        For Each Item As DataRow In dt.Rows
            obePais = New bePais
            obePais.PNCPAIS = Item("CPAIS")
            obePais.PSTCMPPS = HelpClass.ToStringCvr(Item("TCMPPS"))
            oListPais.Add(obePais)
        Next
        Return oListPais
    End Function
End Class
