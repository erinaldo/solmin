Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class clsCliente_DAL
    Public Function PerteneceASalmon(ByVal PSCMCPN As String) As DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim dt As New DataTable
        lobjParams.Add("IN_CODVAR", "SALMON")
        lobjParams.Add("IN_CCMPRN", PSCMCPN)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_LISTA_TABLA_AYUDA", lobjParams)
        Return dt
    End Function
    Public Function Validar_Cliente_Interno_v2(ByVal CCMPN As String, ByVal PNNRCTSL As Decimal) As List(Of Cliente_BE)
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        lobjParams.Add("CCMPN", CCMPN)
        lobjParams.Add("PNNRCTSL", PNNRCTSL)
        Dim dt As New DataTable
        Dim oList As New List(Of Cliente_BE)
        Dim obeCliente As Cliente_BE
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_VALIDAR_CLIENTE_INTERNO", lobjParams)
        For Each item As DataRow In dt.Rows
            obeCliente = New Cliente_BE
            obeCliente.CCLNT = item("CCLNT")
            obeCliente.TCMPCL = ("" & item("TCMPCL")).ToString.Trim
            oList.Add(obeCliente)
        Next
        Return oList
        'Return Listar("SP_SOLMIN_CT_VALIDAR_CLIENTE_INTERNO", lobjParams)
    End Function

End Class
