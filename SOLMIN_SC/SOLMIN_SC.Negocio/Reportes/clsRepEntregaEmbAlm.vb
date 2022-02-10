Public Class clsRepEntregaEmbAlm
    Private strCliente As String
    Private oReporte As Datos.clsRepEntregaEmbAlm
    Private oDtTotalEnvio As DataTable

    Property TotalEnvio()
        Get
            Return oDtTotalEnvio
        End Get
        Set(ByVal value)
            oDtTotalEnvio = value
        End Set
    End Property

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

    Public Function RepEntregaEmbAlm(ByVal pnCliente As Double, ByVal pnFechaIni As Double, ByVal pnFechaFin As Double) As DataTable

        Dim lobjDtRep As New DataTable
        Dim lintcont As Integer
        Dim lobjDr As DataRow
        Dim lobjDt As New DataTable
        Dim oReporte = New Datos.clsRepEntregaEmbAlm
        lobjDt = oReporte.dtRepEntregaEmbAlm(pnCliente, pnFechaIni, pnFechaFin)
        lobjDtRep = lobjDt.Clone
        ':::::::::::::::::::FORMATO AL DATATABLE:::::::::::::::::
        For lintcont = 0 To lobjDt.Rows.Count - 1
            lobjDr = lobjDtRep.NewRow
            lobjDr.Item("CCLNT") = lobjDt.Rows(lintcont).Item("CCLNT")
            lobjDr.Item("TCMPCL") = lobjDt.Rows(lintcont).Item("TCMPCL")
            lobjDr.Item("NORSCI") = lobjDt.Rows(lintcont).Item("NORSCI")
            lobjDr.Item("PNNMOS") = lobjDt.Rows(lintcont).Item("PNNMOS")
            lobjDr.Item("CAGNCR") = lobjDt.Rows(lintcont).Item("CAGNCR")
            lobjDr.Item("TNMAGC") = lobjDt.Rows(lintcont).Item("TNMAGC")
            lobjDr.Item("TCANAL") = lobjDt.Rows(lintcont).Item("TCANAL")
            lobjDr.Item("TNRODU") = lobjDt.Rows(lintcont).Item("TNRODU")
            lobjDr.Item("NDOCEM") = lobjDt.Rows(lintcont).Item("NDOCEM")
            lobjDr.Item("REFDO1") = lobjDt.Rows(lintcont).Item("REFDO1")
            lobjDr.Item("FRETES") = lobjDt.Rows(lintcont).Item("FRETES")
            lobjDr.Item("NORCML") = lobjDt.Rows(lintcont).Item("NORCML")
            lobjDr.Item("CMRCLR") = lobjDt.Rows(lintcont).Item("CMRCLR")
            lobjDr.Item("QRLCSC") = lobjDt.Rows(lintcont).Item("QRLCSC")
            lobjDr.Item("NORDSR") = lobjDt.Rows(lintcont).Item("NORDSR")
            lobjDr.Item("FSLCSR") = lobjDt.Rows(lintcont).Item("FSLCSR")
            lobjDr.Item("QTRMC") = lobjDt.Rows(lintcont).Item("QTRMC")
            lobjDr.Item("NGUIRN") = lobjDt.Rows(lintcont).Item("NGUIRN")
            lobjDr.Item("ETA") = lobjDt.Rows(lintcont).Item("ETA")
            lobjDr.Item("ETD") = lobjDt.Rows(lintcont).Item("ETD")
            lobjDr.Item("TDITES") = lobjDt.Rows(lintcont).Item("TDITES")
            lobjDr.Item("DIF_FECHAS") = Math.Abs(DateDiff(DateInterval.Day, lobjDt.Rows(lintcont).Item("FRETES"), lobjDt.Rows(lintcont).Item("FSLCSR"))) ' lobjDt.Rows(lintcont).Item("DIF_FECHAS")
            lobjDtRep.Rows.Add(lobjDr)
        Next lintcont
        '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        Return lobjDtRep
        'Return lobjDt
    End Function
End Class
