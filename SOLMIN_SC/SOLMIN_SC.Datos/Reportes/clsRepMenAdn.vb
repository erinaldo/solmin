Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.Utilitario
Imports System.Text
Public Class clsRepMenAdn

    Public Function dtRepMenAduanero(ByVal PSCCMPN As String, ByVal PNCCLNT As Double, ByVal PNFECINI As Double, ByVal PNFECFIN As Double, ByVal PSTPSRVA As String, ByVal PNNESTDO As Decimal, ByVal PSESTADO_EMB As String) As DataSet
        Dim dt As New DataTable
        Dim dsResult As New DataSet

        Dim dtCheckPointAduana As New DataTable
        Dim dtOrdenCompra As New DataTable
        Dim dtCarga As New DataTable
        Dim NORSCI As Decimal = 0


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

       
        ds = lobjSql.ExecuteDataSet("SP_SOLSC_REPMENSA_AJUSTE", lobjParams)
        dt = ds.Tables(0).Copy
        dt.Columns.Add("NORCML")
        dt.Columns.Add("ALMCLI")
        dt.Columns.Add("LEVANTE")
        dt.Columns.Add("VOLANTE")
        dt.Columns.Add("DOCUMENTOS")
        dt.Columns.Add("NUMERACION")
        dt.Columns.Add("DERECHOS")
        dtCarga = ds.Tables(1).Copy
        dtCheckPointAduana = ds.Tables(2).Copy
        dtOrdenCompra = ds.Tables(3).Copy

        For Each Item As DataRow In dt.Rows
            NORSCI = Item("NORSCI")
            Item("TPRVCL") = HelpClass.ToStringCvr(Item("TPRVCL"))
            Item("MERCADERIA") = HelpClass.ToStringCvr(Item("MERCADERIA"))
            Item("BL") = HelpClass.ToStringCvr(Item("BL"))
            Item("REGIMEN") = HelpClass.ToStringCvr(Item("REGIMEN"))
            Item("FORSCI") = HelpClass.FechaNum_a_Fecha(Item("FORSCI"))
            Item("DESPACHO") = HelpClass.ToStringCvr(Item("DESPACHO"))
            Item("TNMMDT") = HelpClass.ToStringCvr(Item("TNMMDT"))
            Item("DUA") = HelpClass.ToStringCvr(Item("DUA"))
            Item("SESTRG") = HelpClass.ToStringCvr(Item("SESTRG"))
            Item("TCANAL") = HelpClass.ToStringCvr(Item("TCANAL"))
            'Item("ALMCLI") = HelpClass.FechaNum_a_Fecha(Item("ALMCLI"))
            Item("FAPRAR") = HelpClass.FechaNum_a_Fecha(Item("FAPRAR"))
            'Item("VOLANTE") = HelpClass.FechaNum_a_Fecha(Item("VOLANTE"))
            'Item("LEVANTE") = HelpClass.FechaNum_a_Fecha(Item("LEVANTE"))
            'Item("DOCUMENTOS") = HelpClass.FechaNum_a_Fecha(Item("DOCUMENTOS"))
            'Item("NUMERACION") = HelpClass.FechaNum_a_Fecha(Item("NUMERACION"))
            'Item("DERECHOS") = HelpClass.FechaNum_a_Fecha(Item("DERECHOS"))
            Item("TCMPVP") = HelpClass.ToStringCvr(Item("TCMPVP"))
            Item("TNMAGC") = HelpClass.ToStringCvr(Item("TNMAGC"))
            Item("TTRMAL") = HelpClass.ToStringCvr(Item("TTRMAL"))
            Item("TCMPPS") = HelpClass.ToStringCvr(Item("TCMPPS"))
            Item("DES_CPRTOE") = HelpClass.ToStringCvr(Item("DES_CPRTOE"))
            Item("TCMTRT") = HelpClass.ToStringCvr(Item("TCMTRT"))
            Item("DES_ALMLOCAL") = HelpClass.ToStringCvr(Item("DES_ALMLOCAL"))
            Item("REFDO1") = HelpClass.ToStringCvr(Item("REFDO1"))

            Item("NORCML") = DistinctOrdenCompra(dtOrdenCompra, NORSCI)
            Item("ALMCLI") = BuscarCheckPointAduana(dtCheckPointAduana, NORSCI, EnumCheckPoint.Entrega_Almacen)
            Item("LEVANTE") = BuscarCheckPointAduana(dtCheckPointAduana, NORSCI, EnumCheckPoint.Levante)
            Item("VOLANTE") = BuscarCheckPointAduana(dtCheckPointAduana, NORSCI, EnumCheckPoint.Volante)
            Item("DOCUMENTOS") = BuscarCheckPointAduana(dtCheckPointAduana, NORSCI, EnumCheckPoint.Documentos)
            Item("NUMERACION") = BuscarCheckPointAduana(dtCheckPointAduana, NORSCI, EnumCheckPoint.Numeracion)
            Item("DERECHOS") = BuscarCheckPointAduana(dtCheckPointAduana, NORSCI, EnumCheckPoint.Derechos)


        Next
        dsResult.Tables.Add(dt.Copy)
        dsResult.Tables.Add(dtCarga.Copy)

        Return dsResult
    End Function

    Enum EnumCheckPoint
        Entrega_Almacen = 124
        Levante = 123
        Volante = 116
        Documentos = 120
        Numeracion = 121
        Derechos = 122
    End Enum



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

    Public Function dtNoLaborables(ByVal PNFECINI As Double, ByVal PNFECFIN As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNFECINI", PNFECINI)
        lobjParams.Add("PNFECFIN", PNFECFIN)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_NOLABORABLE", lobjParams)
        Return dt
    End Function
End Class
