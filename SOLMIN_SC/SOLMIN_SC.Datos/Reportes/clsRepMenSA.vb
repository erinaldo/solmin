Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Text
Imports Ransa.Utilitario
Public Class clsRepMenSA
    Public Function dtRepMenAdn(ByVal PSCCMPN As String, ByVal PNCCLNT As Double, ByVal PNFECINI As Double, ByVal PNFECFIN As Double, ByVal PSTPSRVA As String, ByVal PNNESTDO As Decimal, ByVal PSESTADO_EMB As String) As DataTable
        Dim dt As DataTable
        Dim dtOC As New DataTable
        Dim dtCheck As New DataTable
        Dim ds As New DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNFECINI", PNFECINI)
        lobjParams.Add("PNFECFIN", PNFECFIN)
        lobjParams.Add("PSTPSRVA", PSTPSRVA)
        lobjParams.Add("PNNESTDO", PNNESTDO)
        lobjParams.Add("PSESTADO_EMB", PSESTADO_EMB)
        ds = lobjSql.ExecuteDataSet("SP_SOLSC_REPMENADN", lobjParams)
        dt = ds.Tables(0).Copy
        dtOC = ds.Tables(1).Copy
        dtCheck = ds.Tables(2).Copy
        dt.Columns.Add("NORCML")
        dt.Columns.Add("FAPOPE")
        dt.Columns.Add("LEVANTE")
        dt.Columns.Add("ALMCLI")

        Dim NORSCI As Decimal = 0
        For Each Item As DataRow In dt.Rows
            NORSCI = Item("NORSCI")
            Item("NORCML") = DistinctOrdenCompra(dtOC, NORSCI)
            Item("FAPOPE") = HelpClass.FechaNum_a_Fecha(Item("FORSCI"))
            Item("FAPRAR") = HelpClass.FechaNum_a_Fecha(Item("FAPRAR"))

            Item("LEVANTE") = BuscarCheckPointAduana(dtCheck, NORSCI, EnumCheckPoint.Levante)
            Item("ALMCLI") = BuscarCheckPointAduana(dtCheck, NORSCI, EnumCheckPoint.Entrega_Almacen)
        Next


        Return dt
    End Function

    Private Function BuscarCheckPointAduana(ByVal dtCheckPoint As DataTable, ByVal NORSCI As Decimal, ByVal pNESTDO As EnumCheckPoint) As String
        Dim dr() As DataRow
        Dim chk As String = ""
        Dim NESTDO As Decimal = pNESTDO
        dr = dtCheckPoint.Select("NORSCI='" & NORSCI & "' AND NESTDO='" & NESTDO & "'")
        If dr.Length > 0 Then
            chk = HelpClass.FechaNum_a_Fecha(dr(0)("FRETES"))
        End If
        Return chk
    End Function

    Enum EnumCheckPoint
        Entrega_Almacen = 124
        Levante = 123
    End Enum
    Private Function DistinctOrdenCompra(ByVal dtOrdenCompra As DataTable, ByVal NORSCI As Decimal) As String
        Dim dr() As DataRow
        Dim sbOC As New StringBuilder
        Dim norcml As String = ""
        Dim listVisitados As New List(Of String)
        dr = dtOrdenCompra.Select("NORSCI='" & NORSCI & "'")
        For Each Item As DataRow In dr
            norcml = HelpClass.ToStringCvr(Item("NORCML"))
            If norcml.Length > 0 AndAlso (Not listVisitados.Contains(norcml)) Then
                listVisitados.Add(norcml)
                sbOC.Append(norcml)
                sbOC.Append(",")
            End If
        Next
        norcml = sbOC.ToString.Trim
        If norcml.Length > 0 Then
            norcml = norcml.Substring(0, norcml.LastIndexOf(","))
        End If
        Return norcml
    End Function

End Class
