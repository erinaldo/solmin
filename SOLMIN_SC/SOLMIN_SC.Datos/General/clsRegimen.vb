Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad
Imports Ransa.Utilitario
Public Class clsRegimen
  
    Public Function ListarRegimen() As List(Of beRegimen)
        Dim dT As New DataTable
        Dim obeRegimen As beRegimen
        Dim oListRegimen As New List(Of beRegimen)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        dT = lobjSql.ExecuteDataTable("SP_SOLSC_LISTAR_REGIMEN", lobjParams)
        For Each Item As DataRow In dT.Rows
            obeRegimen = New beRegimen
            obeRegimen.PSCCMPN = HelpClass.ToStringCvr(Item("CCMPN"))
            obeRegimen.PSTPSRVA = HelpClass.ToStringCvr(Item("TPSRVA"))
            obeRegimen.PNTPORGE = Item("TPORGE")
            obeRegimen.PSTCMRGA = HelpClass.ToStringCvr(Item("TCMRGA"))
            obeRegimen.PSTCMRGI = HelpClass.ToStringCvr(Item("TCMRGI"))
            obeRegimen.PSVIGENCIA = HelpClass.ToStringCvr(Item("SESTVG"))
            oListRegimen.Add(obeRegimen)
        Next
        Return oListRegimen
    End Function

    Public Function ListarOperacionRegimen() As List(Of beOperacionRegimen)
        Dim dT As New DataTable
        Dim obeOpRegimen As beOperacionRegimen
        Dim oListOPRegimen As New List(Of beOperacionRegimen)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        dT = lobjSql.ExecuteDataTable("SP_SOLSC_LISTAR_OPERACIONES_REGIMEN", lobjParams)
        For Each Item As DataRow In dT.Rows
            obeOpRegimen = New beOperacionRegimen
            obeOpRegimen.PSCCMPN = HelpClass.ToStringCvr(Item("CCMPN"))
            obeOpRegimen.PNTPORGE = Item("TPORGE")
            obeOpRegimen.PNTPOPRG = Item("TPOPRG")
            obeOpRegimen.PSTCMPRO = HelpClass.ToStringCvr(Item("TCMPRO"))
            oListOPRegimen.Add(obeOpRegimen)
        Next
        Return oListOPRegimen
    End Function

End Class
