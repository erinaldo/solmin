Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades
Public Class clsAyudaGeneral


    Public Function ListaTablaAyudaGeneral(ByVal PSCODVAR As String, ByVal PSCCMPRN As String) As List(Of beAyudaGeneral)
        Dim objParam As New Parameter
        Dim sqlManager As New SqlManager
        Dim oListAyudaGeneral As New List(Of beAyudaGeneral)
        Dim obeayudageneral As New beAyudaGeneral
        Dim dt As New DataTable
        objParam.Add("PSCODVAR", PSCODVAR)
        objParam.Add("PSCCMPRN", PSCCMPRN)
        dt = sqlManager.ExecuteDataTable("SP_SOLMIN_SA_LISTA_TABLA_AYUDA", objParam)

        For Each Item As DataRow In dt.Rows
            obeayudageneral = New beAyudaGeneral
            obeayudageneral.PSCODIGO = Item("CCMPRN").ToString.Trim
            obeayudageneral.PSDESCRIPCION = Item("TDSDES").ToString.Trim
            oListAyudaGeneral.Add(obeayudageneral)
        Next
        Return oListAyudaGeneral
    End Function

End Class
