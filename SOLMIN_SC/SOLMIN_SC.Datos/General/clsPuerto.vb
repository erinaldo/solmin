Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad
Imports Ransa.Utilitario
Public Class clsPuerto
    Public Function Lista_Puerto() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_PUERTO", Nothing)
        Return dt
    End Function
    Public Function Listar_Puerto() As List(Of bePuerto)
        Dim obePuerto As bePuerto
        Dim oListPuerto As New List(Of bePuerto)
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_PUERTO", Nothing)
        For Each Item As DataRow In dt.Rows
            obePuerto = New bePuerto
            obePuerto.PNCPAIS1 = Item("CPAIS1")
            obePuerto.PSCPRTOR = HelpClass.ToStringCvr(Item("CPRTOR"))
            obePuerto.PSTCMPR1 = HelpClass.ToStringCvr(Item("TCMPR1"))
            oListPuerto.Add(obePuerto)
        Next
        Return oListPuerto
    End Function
End Class
