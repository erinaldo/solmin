
Imports SOLMIN_ST.ENTIDADES
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsPreDocum_DAL
    Public Function ListarPLDocumentosS(ByVal obePreDoc As PreDocum_BE) As DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim dt As New DataTable
        lobjParams.Add("PSCCMPN", obePreDoc.PSCCMPN)
        lobjParams.Add("PNNRCTRL", obePreDoc.PNNRCTRL)
        lobjParams.Add("PSTIPOPL", obePreDoc.PSTIPOPL)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_CAB_PRE_DOCPL", lobjParams)
        For Each item As DataRow In dt.Rows
            item("IMPORTE") = Val("" & item("IMPORTE"))
        Next


        Return dt
    End Function
End Class
