Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad
Imports Ransa.Utilitario
Public Class clsMedioTransporte
    Public Function Lista_Medio_Transporte() As List(Of beMedioTransporte)
        Dim dt As New DataTable
        Dim oListMedioTransporte As New List(Of beMedioTransporte)
        Dim obeMedioTransporte As beMedioTransporte
        Dim lobjSql As New SqlManager
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_TIPO_ENVIO", Nothing)
        For Each Item As DataRow In dt.Rows
            obeMedioTransporte = New beMedioTransporte
            obeMedioTransporte.PNCMEDTR = Item("CMEDTR")
            obeMedioTransporte.PSTNMMDT = HelpClass.ToStringCvr(Item("TNMMDT"))
            oListMedioTransporte.Add(obeMedioTransporte)
        Next
        Return oListMedioTransporte
    End Function
End Class
