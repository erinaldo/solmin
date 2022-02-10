Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class brLote_DAL
    Public Function ListaDeLotesPorOC(ByVal obeLote As Ransa.TYPEDEF.beLote) As DataTable
        Dim objSqlManager As New SqlManager
        Dim objParam As New Parameter
        Dim oDt As New DataTable("LOTES")
        'Try
        With objParam
            .Add("PNNORDSR", obeLote.NORDSR)
        End With
        oDt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_OBTENER_LISTA_LOTES_OS", objParam)
        oDt.Columns.Add("CANTIDAD", Type.GetType("System.Decimal"))
        oDt.Columns.Add("SF_FINGAL", Type.GetType("System.String"))
        oDt.Columns.Add("SF_FPRDMR", Type.GetType("System.String"))
        oDt.Columns.Add("SF_FVNLTE", Type.GetType("System.String"))

        For Each row As DataRow In oDt.Rows
            row("CANTIDAD") = 0
            row("SF_FINGAL") = IIf(row("FINGAL") = 0, "", HelpClass.CNumero8Digitos_a_Fecha(row("FINGAL")))
            row("SF_FPRDMR") = IIf(row("FPRDMR") = 0, "", HelpClass.CNumero8Digitos_a_Fecha(row("FPRDMR")))
            row("SF_FVNLTE") = IIf(row("FVNLTE") = 0, "", HelpClass.CNumero8Digitos_a_Fecha(row("FVNLTE")))

        Next
        'Catch ex As Exception
        '    oDt = Nothing
        'End Try
        Return oDt
    End Function

    Public Function RegistrarDespachoLote(ByVal lista As List(Of Ransa.TYPEDEF.beLote)) As Boolean
        Dim resultado As Boolean = False
        Dim objParam As Parameter
        Dim objSqlManager As New SqlManager


        For Each obeLote As Ransa.TYPEDEF.beLote In lista
            objParam = New Parameter
            With objParam
                .Add("PNNORDSR", obeLote.NORDSR)
                .Add("PNNCRRIN", obeLote.NCRRIN)
                .Add("PNQTRMC", obeLote.QCMMC1)
                .Add("PNQTRMP", obeLote.QCMMP1)
                .Add("PSCTPOAT", obeLote.CTPOAT)
                .Add("PNNGUIRN", obeLote.NGUIRN)
                .Add("PNNSLCS1", obeLote.NSLCS1)
                .Add("PSCTPALM", obeLote.CTPALM)
                .Add("PSCALMC", obeLote.CALMC)
                .Add("PSCZNALM", obeLote.CZNALM)
                .Add("PSCULUSA", obeLote.CULUSA)
            End With
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDS_DESPACHO_LOTE_MERCADERIA", objParam)
        Next

        resultado = True
       


        Return resultado
    End Function

End Class
