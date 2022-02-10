Public Class clsRptMenCI
    Private strCliente As String
    Private oReporte As Datos.clsRptMenCI
    Private oDtTotalEnvio As DataTable

    Property TotalEnvio()
        Get
            Return oDtTotalEnvio
        End Get
        Set(ByVal value)
            oDtTotalEnvio = value
        End Set
    End Property

    Private Sub fdtFormatoTotalEnvio(ByRef pobjDt As DataTable)
        Dim objDr As DataRow
        pobjDt = New DataTable
        pobjDt.Columns.Add(New DataColumn("TCMPCL", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("TCOURIER", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("TAEREO", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("TMARITIMO", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("TTERRESTRE", GetType(System.Int32)))
        objDr = pobjDt.NewRow
        objDr("TCMPCL") = strCliente
        objDr("TCOURIER") = 0
        objDr("TAEREO") = 0
        objDr("TMARITIMO") = 0
        objDr("TTERRESTRE") = 0
        pobjDt.Rows.Add(objDr)
    End Sub

    Private Sub fdtFormatoRepMenCI(ByRef pobjDt As DataTable)
        pobjDt = New DataTable
        pobjDt.Columns.Add(New DataColumn("TCMPCL", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("NORCML", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("NRPARC", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("TPRVCL", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("TDITES", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("FSOLIC", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("FENTPV", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("FRJAPV", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("FIALEM", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("NBLTAR", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("QPSOAR", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("TNMMDT", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("TTINTC", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("NUMFAC", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("TLGEMB", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("FAPREV", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("TNMAGC", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("TCMPVP", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("FAPRAR", GetType(System.String)))
    End Sub

    Private Sub Cuenta_Envio(ByVal pstrCadena As String)
        Select Case pstrCadena
            Case "POSTAL"
                oDtTotalEnvio.Rows(0).Item("TCOURIER") = oDtTotalEnvio.Rows(0).Item("TCOURIER") + 1
            Case "AEREO"
                oDtTotalEnvio.Rows(0).Item("TAEREO") = oDtTotalEnvio.Rows(0).Item("TAEREO") + 1
            Case "MARITIMO"
                oDtTotalEnvio.Rows(0).Item("TMARITIMO") = oDtTotalEnvio.Rows(0).Item("TMARITIMO") + 1
            Case "TERRESTRE"
                oDtTotalEnvio.Rows(0).Item("TTERRESTRE") = oDtTotalEnvio.Rows(0).Item("TTERRESTRE") + 1
        End Select
    End Sub

    Public Function dtRepMenCI(ByVal PSCCMPN As String, ByVal pstrCliente As String, ByVal pdblCodCli As Double, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double, ByVal PSTPSRVA As String, ByVal PNNESTDO As Decimal, ByVal PSESTADO_EMB As String) As DataTable
        Dim lobjDtRep As DataTable
        Dim lobjDt As DataTable
        Dim lintcont As Integer
        Dim lobjDr As DataRow

        strCliente = pstrCliente
        fdtFormatoTotalEnvio(oDtTotalEnvio)
        fdtFormatoRepMenCI(lobjDtRep)
        oReporte = New Datos.clsRptMenCI()
        lobjDt = oReporte.dtRepMenCI(PSCCMPN, pdblCodCli, pdblFecIni, pdblFecFin, PSTPSRVA, PNNESTDO, PSESTADO_EMB)

        For lintcont = 0 To lobjDt.Rows.Count - 1
            lobjDr = lobjDtRep.NewRow
            lobjDr.Item("TCMPCL") = strCliente
            lobjDr.Item("NORCML") = lobjDt.Rows(lintcont).Item("NORCML")
            lobjDr.Item("NRPARC") = lobjDt.Rows(lintcont).Item("NRPARC")
            lobjDr.Item("TPRVCL") = lobjDt.Rows(lintcont).Item("TPRVCL")
            lobjDr.Item("TDITES") = "MERCADERIA"
            lobjDr.Item("FSOLIC") = lobjDt.Rows(lintcont).Item("FSOLIC")
            lobjDr.Item("FENTPV") = lobjDt.Rows(lintcont).Item("FENTPV")
            lobjDr.Item("FRJAPV") = lobjDt.Rows(lintcont).Item("FRJAPV")
            lobjDr.Item("FIALEM") = lobjDt.Rows(lintcont).Item("FIALEM")
            lobjDr.Item("NBLTAR") = lobjDt.Rows(lintcont).Item("NBLTAR")
            lobjDr.Item("QPSOAR") = Format(lobjDt.Rows(lintcont).Item("QPSOAR"), "###,###.00")
            Cuenta_Envio(Trim(lobjDt.Rows(lintcont).Item("TNMMDT")))
            lobjDr.Item("TNMMDT") = lobjDt.Rows(lintcont).Item("TNMMDT")
            lobjDr.Item("TTINTC") = lobjDt.Rows(lintcont).Item("TTINTC")
            lobjDr.Item("NUMFAC") = lobjDt.Rows(lintcont).Item("NUMFAC")
            lobjDr.Item("TLGEMB") = lobjDt.Rows(lintcont).Item("TCMPR1")
            lobjDr.Item("FAPREV") = lobjDt.Rows(lintcont).Item("FAPREV")
            lobjDr.Item("TNMAGC") = lobjDt.Rows(lintcont).Item("TNMAGC")
            lobjDr.Item("TCMPVP") = lobjDt.Rows(lintcont).Item("TCMPVP")
            lobjDr.Item("FAPRAR") = lobjDt.Rows(lintcont).Item("FAPRAR")
            lobjDtRep.Rows.Add(lobjDr)
        Next lintcont

        Return lobjDtRep
    End Function
End Class
