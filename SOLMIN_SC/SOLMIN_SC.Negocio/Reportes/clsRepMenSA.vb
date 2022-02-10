Public Class clsRepMenSA
    Private strCliente As String
    Private oReporte As Datos.clsRepMenSA

    Private Sub fdtFormatoRepMenAD(ByRef pobjDt As DataTable)
        pobjDt = New DataTable
        pobjDt.Columns.Add(New DataColumn("TCMPCL", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("NORCML", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("PNNMOS", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("FAPOPE", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("FAPRAR", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("LEVANTE", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("ALMCLI", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("PERIODO", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("DIF_DIA1", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("DIF_DIA2", GetType(System.String)))
    End Sub

    Private Function fstDiferencia_Dia(ByVal pstrDiaFinal As String, ByVal pstrDiaInicio As String) As String
        Dim lintDif As Integer
        If IsDBNull(pstrDiaFinal) Or pstrDiaFinal = vbNullString Or IsDBNull(pstrDiaInicio) Or pstrDiaInicio = vbNullString Then
            Return ""
        End If
        lintDif = DateDiff(DateInterval.Day, CType(pstrDiaInicio, Date), CType(pstrDiaFinal, Date))
        Return CType(lintDif, String)
    End Function

    Public Function dtRepMenAD(ByVal PSCCMPN As String, ByVal pstrCliente As String, ByVal pdblCodCli As Double, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double, ByVal pstrPeriodo As String, ByVal PSTPSRVA As String, ByVal PNNESTDO As Decimal, ByVal PSESTADO_EMB As String) As DataTable
        Dim lobjDtRep As DataTable
        Dim lobjDt As DataTable
        Dim lintcont As Integer
        Dim lstrDias As String
        Dim lobjDr As DataRow

        strCliente = pstrCliente
        fdtFormatoRepMenAD(lobjDtRep)
        oReporte = New Datos.clsRepMenSA
        lobjDt = oReporte.dtRepMenAdn(PSCCMPN, pdblCodCli, pdblFecIni, pdblFecFin, PSTPSRVA, PNNESTDO, PSESTADO_EMB)

        For lintcont = 0 To lobjDt.Rows.Count - 1
            lobjDr = lobjDtRep.NewRow
            lobjDr.Item("TCMPCL") = strCliente
            lobjDr.Item("NORCML") = lobjDt.Rows(lintcont).Item("NORCML")
            lobjDr.Item("PNNMOS") = lobjDt.Rows(lintcont).Item("PNNMOS")
            lobjDr.Item("FAPOPE") = lobjDt.Rows(lintcont).Item("FAPOPE")
            lobjDr.Item("FAPRAR") = lobjDt.Rows(lintcont).Item("FAPRAR")
            lobjDr.Item("LEVANTE") = lobjDt.Rows(lintcont).Item("LEVANTE")
            lobjDr.Item("ALMCLI") = lobjDt.Rows(lintcont).Item("ALMCLI")
            lstrDias = fstDiferencia_Dia(lobjDt.Rows(lintcont).Item("LEVANTE"), lobjDt.Rows(lintcont).Item("FAPRAR"))
            lobjDr.Item("DIF_DIA1") = lstrDias
            lstrDias = fstDiferencia_Dia(lobjDt.Rows(lintcont).Item("ALMCLI"), lobjDt.Rows(lintcont).Item("LEVANTE"))
            lobjDr.Item("DIF_DIA2") = lstrDias
            lobjDr.Item("PERIODO") = pstrPeriodo
            lobjDtRep.Rows.Add(lobjDr)
        Next lintcont

        Return lobjDtRep
    End Function
End Class
