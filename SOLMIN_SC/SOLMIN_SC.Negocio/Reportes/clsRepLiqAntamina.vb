Imports System.Text
Public Class clsRepLiqAntamina
    Private oReporte As Datos.clsRepLiqAntamina

    Private Sub fdtFormatoRepLiqAntamina(ByRef pobjDt As DataTable)
        pobjDt = New DataTable
        pobjDt.Columns.Add(New DataColumn("TPRCL1", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("NUMFAC", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("NORCML", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("TNMAGC", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("TNRODU", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("FOB", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("FLETE", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("SEGURO", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("ADVALOREM", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("IGV", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("IPM", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("TAMEX", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("PNNMOS", GetType(System.String)))
    End Sub

    Public Function fLista_factura(ByVal pobjDt As DataTable) As String
        Dim lintCont As Integer
        Dim lstrLista As String

        lstrLista = ""
        For lintCont = 0 To pobjDt.Rows.Count - 1
            If lintCont > 0 Then
                lstrLista = lstrLista & "/"
            End If
            lstrLista = lstrLista & pobjDt.Rows(lintCont).Item("NDOCLI").ToString.Trim
        Next lintCont

        Return lstrLista
    End Function

    Private Function ResumenOrdenCompra(ByVal dtOrdenCompra As DataTable) As String
        Dim ListOC As New List(Of String)
        Dim sbOrdenOC As New StringBuilder
        Dim NORCML As String = ""
        Dim strOC As String = ""
        For Each Item As DataRow In dtOrdenCompra.Rows
            NORCML = Item("NORCML").ToString.Trim
            If Not ListOC.Contains(NORCML) Then
                ListOC.Add(NORCML)
                sbOrdenOC.Append(NORCML)
                sbOrdenOC.Append(",")
            End If
        Next
        strOC = sbOrdenOC.ToString.Trim
        If strOC.Length > 0 Then
            strOC = strOC.Substring(0, strOC.LastIndexOf(",") - 1)
        End If
        Return strOC
    End Function

    Public Function dtRepLiqAntamina(ByVal PSCCMPN As String, ByVal pdblOS As Double, ByVal PSTPSRVA As String) As DataTable
        Dim lobjDtRep As DataTable
        Dim ds As New DataSet
        Dim lobjDt As DataTable
        Dim lobjDt_Aux As DataTable
        Dim lobjDr As DataRow
        Dim dtOrdenCompra As New DataTable

        fdtFormatoRepLiqAntamina(lobjDtRep)
        oReporte = New Datos.clsRepLiqAntamina
        ds = oReporte.dtRepLiqAntamina(PSCCMPN, pdblOS, PSTPSRVA)
        lobjDt = ds.Tables(0).Copy
        dtOrdenCompra = ds.Tables(1).Copy

        Dim norcml As String = ResumenOrdenCompra(dtOrdenCompra)


        If lobjDt.Rows.Count > 0 Then
            lobjDt_Aux = oReporte.dtLista_Factura(CType(lobjDt.Rows(0).Item("NORSCI").ToString, Double))
            lobjDr = lobjDtRep.NewRow
            'lobjDr.Item("TPRCL1") = lobjDt.Rows(0).Item("TPRCL1")
            lobjDr.Item("TPRCL1") = norcml
            If lobjDt_Aux.Rows.Count > 0 Then
                lobjDr.Item("NUMFAC") = fLista_factura(lobjDt_Aux)
            Else
                lobjDr.Item("NUMFAC") = ""
            End If
            'lobjDr.Item("NORCML") = lobjDt.Rows(0).Item("REFDO1")
            lobjDr.Item("NORCML") = norcml
            lobjDr.Item("TNMAGC") = lobjDt.Rows(0).Item("TNMAGC")
            lobjDr.Item("TNRODU") = lobjDt.Rows(0).Item("TNRODU")
            lobjDr.Item("FOB") = IIf(lobjDt.Rows(0).Item("FOB") Is DBNull.Value, 0, lobjDt.Rows(0).Item("FOB"))
            lobjDr.Item("FLETE") = IIf(lobjDt.Rows(0).Item("FLETE") Is DBNull.Value, 0, lobjDt.Rows(0).Item("FLETE"))
            lobjDr.Item("SEGURO") = IIf(lobjDt.Rows(0).Item("SEGURO") Is DBNull.Value, 0, lobjDt.Rows(0).Item("SEGURO"))
            lobjDr.Item("ADVALOREM") = IIf(lobjDt.Rows(0).Item("ADVALOREM") Is DBNull.Value, 0, lobjDt.Rows(0).Item("ADVALOREM"))
            lobjDr.Item("IGV") = IIf(lobjDt.Rows(0).Item("IGV") Is DBNull.Value, 0, lobjDt.Rows(0).Item("IGV"))
            lobjDr.Item("IPM") = IIf(lobjDt.Rows(0).Item("IPM") Is DBNull.Value, 0, lobjDt.Rows(0).Item("IPM"))
            lobjDr.Item("TAMEX") = IIf(lobjDt.Rows(0).Item("TASA") Is DBNull.Value, 0, lobjDt.Rows(0).Item("TASA"))
            lobjDr.Item("PNNMOS") = pdblOS.ToString.Substring(4, 5)
            lobjDtRep.Rows.Add(lobjDr)
        End If

        Return lobjDtRep
    End Function
End Class
