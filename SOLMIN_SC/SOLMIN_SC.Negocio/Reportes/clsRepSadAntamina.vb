Public Class clsRepSadAntamina
    Private strCliente As String
    Private oReporte As Datos.clsRepSadAntamina

    Private Sub fdtFormatoRepMenADV(ByRef pobjDt As DataTable)
        pobjDt = New DataTable
        pobjDt.Columns.Add(New DataColumn("TPRCL1", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("PNNMOS", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("TNRODU", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("FECNUM", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("FOB", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("NORCML", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("NOMCOM", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("NRITOC", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("TDITES", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("PERIODO", GetType(System.String)))
    End Sub

  Public Function dtRepMenADV(ByVal PSCCMPN As String, ByVal pstrCliente As String, ByVal pdblCodCli As Double, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double, ByVal pstrPeriodo As String, ByVal PSTPSRVA As String) As DataTable
    Dim lobjDtRep As DataTable
    Dim lobjDt As DataTable
    Dim lintcont As Integer
    Dim lobjDr As DataRow

    strCliente = pstrCliente
    fdtFormatoRepMenADV(lobjDtRep)
    oReporte = New Datos.clsRepSadAntamina
    lobjDt = oReporte.dtRepSadAntamina(PSCCMPN, pdblCodCli, pdblFecIni, pdblFecFin, PSTPSRVA)

    For lintcont = 0 To lobjDt.Rows.Count - 1
      lobjDr = lobjDtRep.NewRow
      lobjDr.Item("TPRCL1") = strCliente
      lobjDr.Item("PNNMOS") = lobjDt.Rows(lintcont).Item("PNNMOS")
      lobjDr.Item("TNRODU") = lobjDt.Rows(lintcont).Item("TNRODU")
      lobjDr.Item("FECNUM") = lobjDt.Rows(lintcont).Item("FECNUM")
      lobjDr.Item("FOB") = lobjDt.Rows(lintcont).Item("FOB")
      lobjDr.Item("NORCML") = lobjDt.Rows(lintcont).Item("NORCML")
      lobjDr.Item("NOMCOM") = lobjDt.Rows(lintcont).Item("NOMCOM").ToString.Trim
      lobjDr.Item("NRITOC") = lobjDt.Rows(lintcont).Item("NRITOC")
      lobjDr.Item("TDITES") = lobjDt.Rows(lintcont).Item("TDITES").ToString.Trim
      lobjDr.Item("PERIODO") = pstrPeriodo
      lobjDtRep.Rows.Add(lobjDr)
    Next lintcont

    Return lobjDtRep
  End Function
End Class
