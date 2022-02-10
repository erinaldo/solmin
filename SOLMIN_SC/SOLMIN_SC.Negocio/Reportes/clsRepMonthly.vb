Imports System.Text
Imports Ransa.Utilitario
Public Class clsRepMonthly
    Private oReporte As Datos.clsRepMonthly
    Private oDtNaviera As DataTable
    Private oDtEntregaDoc As DataTable
    Private oDtOperaciones As DataTable
    Private oDtDetDebito As DataTable
    Private oDtFactAduana As DataTable
    Private oDtContenedor As DataTable
    Private oDtNoLab As DataTable
    Private oDtOper As DataTable
    Private dblPromNor As Double
    Private dblPromAnt As Double

    Private dsReporte As New DataSet


    Sub New()
        oReporte = New Datos.clsRepMonthly
        oDtNaviera = New DataTable
        oDtOperaciones = New DataTable
        oDtDetDebito = New DataTable
        oDtFactAduana = New DataTable
        oDtContenedor = New DataTable
    End Sub

    Property Promedio_Anticipado()
        Get
            Return dblPromAnt
        End Get
        Set(ByVal value)
            dblPromAnt = value
        End Set
    End Property

    Property Promedio_Normal()
        Get
            Return dblPromNor
        End Get
        Set(ByVal value)
            dblPromNor = value
        End Set
    End Property

    Private Sub Formato_Entrega_Documento()
        Dim intCont As Integer

        oDtEntregaDoc.Columns.Add(New DataColumn("FECFAC", GetType(System.String)))
        oDtEntregaDoc.Columns.Add(New DataColumn("FECDOC", GetType(System.String)))
        oDtEntregaDoc.Columns.Add(New DataColumn("FECTRA", GetType(System.String)))
        oDtEntregaDoc.Columns.Add(New DataColumn("DIAFAC", GetType(System.Int32)))
        oDtEntregaDoc.Columns.Add(New DataColumn("DIADOC", GetType(System.Int32)))
        oDtEntregaDoc.Columns.Add(New DataColumn("DIATRA", GetType(System.Int32)))
        oDtEntregaDoc.Columns.Add(New DataColumn("NORCML_1", GetType(System.String)))
        For intCont = 0 To oDtEntregaDoc.Rows.Count - 1
            With oDtEntregaDoc.Rows(intCont)
                .Item("FECFAC") = ""
                .Item("FECDOC") = ""
                .Item("FECTRA") = ""
                .Item("DIAFAC") = 0
                .Item("DIADOC") = 0
                .Item("DIATRA") = 0
                .Item("NORCML_1") = ""
            End With
        Next intCont
    End Sub

    Private Sub Formato_Naviera()
        oDtNaviera.Columns.Add(New DataColumn("TNMCIN", GetType(System.String)))
        oDtNaviera.Columns.Add(New DataColumn("CONT20", GetType(System.Int32)))
        oDtNaviera.Columns.Add(New DataColumn("CONT40", GetType(System.Int32)))
    End Sub

    Private Sub Formato_Operaciones()
        oDtOperaciones.Columns.Add(New DataColumn("NORSCI", GetType(System.String)))
        oDtOperaciones.Columns.Add(New DataColumn("NORCML", GetType(System.String)))
        oDtOperaciones.Columns.Add(New DataColumn("PNNMOS", GetType(System.String)))
        oDtOperaciones.Columns.Add(New DataColumn("TDSCRG", GetType(System.String)))
        oDtOperaciones.Columns.Add(New DataColumn("QPSOAR", GetType(System.Double)))
        oDtOperaciones.Columns.Add(New DataColumn("IVFOBD", GetType(System.Double)))
        oDtOperaciones.Columns.Add(New DataColumn("IVLFLT", GetType(System.Double)))
        oDtOperaciones.Columns.Add(New DataColumn("IVLSGR", GetType(System.Double)))
        oDtOperaciones.Columns.Add(New DataColumn("ITTCIF", GetType(System.Double)))
        oDtOperaciones.Columns.Add(New DataColumn("ITTADV", GetType(System.Double)))
        oDtOperaciones.Columns.Add(New DataColumn("IGVIPM", GetType(System.Double)))
        oDtOperaciones.Columns.Add(New DataColumn("TOTAL", GetType(System.Double)))
        oDtOperaciones.Columns.Add(New DataColumn("ITTOGS", GetType(System.Double)))
        oDtOperaciones.Columns.Add(New DataColumn("ITTFOB", GetType(System.Double)))
        oDtOperaciones.Columns.Add(New DataColumn("VALFLT", GetType(System.Double)))
        oDtOperaciones.Columns.Add(New DataColumn("VALSEG", GetType(System.Double)))
        oDtOperaciones.Columns.Add(New DataColumn("IMPCIF", GetType(System.Double)))
        oDtOperaciones.Columns.Add(New DataColumn("VALADV", GetType(System.Double)))
        oDtOperaciones.Columns.Add(New DataColumn("IIGVPM", GetType(System.Double)))
        oDtOperaciones.Columns.Add(New DataColumn("VALOGS", GetType(System.Double)))
        oDtOperaciones.Columns.Add(New DataColumn("VALTOT", GetType(System.Double)))
        oDtOperaciones.Columns.Add(New DataColumn("IVLEXW", GetType(System.Double)))
        oDtOperaciones.Columns.Add(New DataColumn("IVGFOB", GetType(System.Double)))

        oDtOperaciones.Columns.Add(New DataColumn("REGIMEN", GetType(System.String)))
    End Sub

    Public Function dtRepMonthlyOperaciones(ByVal PSCCMPN As String, ByVal pdblCodCli As Double, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double, ByVal ListaRegimen As String, ByVal PSTPSRVA As String, ByVal PNNESTDO As Decimal, ByVal PSESTADO_EMB As String) As DataTable
        Dim oDt As DataTable
        Dim oDtNew As New DataTable
        Dim intCont As Integer
        Dim intRow As Integer
        Dim oDr As DataRow

        oDtOper = oReporte.dtRepMonthlyOperaciones(PSCCMPN, pdblCodCli, pdblFecIni, pdblFecFin, ListaRegimen, PSTPSRVA, PNNESTDO, PSESTADO_EMB)
        oDt = oDtOper.Copy
        Formato_Operaciones()
        For intCont = 0 To oDt.Rows.Count - 1
            oDtNew.Rows.Clear()
            If Not IsDBNull(oDt.Rows(intCont).Item("CPLNDV")) Then
                oDtNew = oReporte.dtRepMonthlyOperacionesAgencias(oDt.Rows(intCont).Item("PNNMOS").ToString, oDt.Rows(intCont).Item("CZNFCC").ToString, oDt.Rows(intCont).Item("TPSRVA").ToString, oDt.Rows(intCont).Item("CPLNDV").ToString)
            End If
            If oDtNew.Rows.Count = 0 Then
                oDr = oDtOperaciones.NewRow
                oDr.Item("NORSCI") = oDt.Rows(intCont).Item("NORSCI").ToString
                oDr.Item("PNNMOS") = oDt.Rows(intCont).Item("PNNMOS").ToString
                oDr.Item("TDSCRG") = oDt.Rows(intCont).Item("TDSCRG").ToString
                oDr.Item("QPSOAR") = oDt.Rows(intCont).Item("QPSOAR").ToString
                oDr.Item("IVLFLT") = oDt.Rows(intCont).Item("IVLFLT").ToString
                oDr.Item("IVLSGR") = oDt.Rows(intCont).Item("IVLSGR").ToString
                oDr.Item("ITTCIF") = oDt.Rows(intCont).Item("ITTCIF").ToString
                oDr.Item("ITTADV") = oDt.Rows(intCont).Item("ITTADV").ToString
                oDr.Item("IGVIPM") = oDt.Rows(intCont).Item("IGVIPM").ToString
                oDr.Item("TOTAL") = oDt.Rows(intCont).Item("TOTAL").ToString
                oDr.Item("ITTOGS") = oDt.Rows(intCont).Item("ITTOGS").ToString
                oDr.Item("ITTFOB") = oDt.Rows(intCont).Item("ITTFOB").ToString
                oDr.Item("IVLEXW") = oDt.Rows(intCont).Item("IVLEXW").ToString
                oDr.Item("IVGFOB") = oDt.Rows(intCont).Item("IVGFOB").ToString
                oDr.Item("NORCML") = oDt.Rows(intCont).Item("NORCML").ToString
                oDr.Item("IVFOBD") = 0.0
                oDr.Item("VALFLT") = 0.0
                oDr.Item("VALSEG") = 0.0
                oDr.Item("IMPCIF") = 0.0
                oDr.Item("VALADV") = 0.0
                oDr.Item("IIGVPM") = 0.0
                oDr.Item("VALOGS") = 0.0
                oDr.Item("VALTOT") = 0.0

                oDr.Item("REGIMEN") = oDt.Rows(intCont).Item("REGIMEN").ToString

                oDtOperaciones.Rows.Add(oDr)
            Else
                For intRow = 0 To oDtNew.Rows.Count - 1
                    oDr = oDtOperaciones.NewRow
                    oDr.Item("NORSCI") = oDt.Rows(intCont).Item("NORSCI").ToString
                    oDr.Item("PNNMOS") = oDt.Rows(intCont).Item("PNNMOS").ToString
                    oDr.Item("TDSCRG") = oDt.Rows(intCont).Item("TDSCRG").ToString
                    oDr.Item("QPSOAR") = oDt.Rows(intCont).Item("QPSOAR").ToString
                    oDr.Item("IVLFLT") = oDt.Rows(intCont).Item("IVLFLT").ToString
                    oDr.Item("IVLSGR") = oDt.Rows(intCont).Item("IVLSGR").ToString
                    oDr.Item("ITTCIF") = oDt.Rows(intCont).Item("ITTCIF").ToString
                    oDr.Item("ITTADV") = oDt.Rows(intCont).Item("ITTADV").ToString
                    oDr.Item("IGVIPM") = oDt.Rows(intCont).Item("IGVIPM").ToString
                    oDr.Item("TOTAL") = oDt.Rows(intCont).Item("TOTAL").ToString
                    oDr.Item("ITTOGS") = oDt.Rows(intCont).Item("ITTOGS").ToString
                    oDr.Item("ITTFOB") = oDt.Rows(intCont).Item("ITTFOB").ToString
                    oDr.Item("IVLEXW") = oDt.Rows(intCont).Item("IVLEXW").ToString
                    oDr.Item("IVGFOB") = oDt.Rows(intCont).Item("IVGFOB").ToString
                    oDr.Item("NORCML") = oDt.Rows(intCont).Item("NORCML").ToString
                    oDr.Item("IVFOBD") = oDtNew.Rows(intRow).Item("IVFOBD").ToString
                    oDr.Item("VALFLT") = oDtNew.Rows(intRow).Item("VALFLT").ToString
                    oDr.Item("VALSEG") = oDtNew.Rows(intRow).Item("VALSEG").ToString
                    oDr.Item("IMPCIF") = oDtNew.Rows(intRow).Item("IMPCIF").ToString
                    oDr.Item("VALADV") = oDtNew.Rows(intRow).Item("VALADV").ToString
                    oDr.Item("IIGVPM") = oDtNew.Rows(intRow).Item("IIGVPM").ToString
                    oDr.Item("VALOGS") = oDtNew.Rows(intRow).Item("VALOGS").ToString
                    oDr.Item("VALTOT") = oDtNew.Rows(intRow).Item("VALTOT").ToString

                    oDr.Item("REGIMEN") = oDt.Rows(intCont).Item("REGIMEN").ToString
                    oDtOperaciones.Rows.Add(oDr)
                Next intRow
            End If
        Next intCont
        Return oDtOperaciones
    End Function


    Private Function SumarizarCostosxOrdenCompra(ByVal NORSCI As Decimal, ByVal dtOrdenEmbarcada As DataTable) As DataTable

        Dim dtCostosDetalleOC As New DataTable
        dtCostosDetalleOC.Columns.Add("NORCML", Type.GetType("System.String"))
        dtCostosDetalleOC.Columns.Add("IVFOBD", Type.GetType("System.Decimal"))
        dtCostosDetalleOC.Columns.Add("VALFLT", Type.GetType("System.Decimal"))
        dtCostosDetalleOC.Columns.Add("VALSEG", Type.GetType("System.Decimal"))
        dtCostosDetalleOC.Columns.Add("IMPCIF", Type.GetType("System.Decimal"))
        dtCostosDetalleOC.Columns.Add("VALADV", Type.GetType("System.Decimal"))
        dtCostosDetalleOC.Columns.Add("VALIGV", Type.GetType("System.Decimal"))
        dtCostosDetalleOC.Columns.Add("VALIPM", Type.GetType("System.Decimal"))
        dtCostosDetalleOC.Columns.Add("IIGVPM", Type.GetType("System.Decimal"))
        dtCostosDetalleOC.Columns.Add("VALOGS", Type.GetType("System.Decimal"))
        dtCostosDetalleOC.Columns.Add("VALTOT", Type.GetType("System.Decimal"))


        Dim dr() As DataRow
        Dim strNorcml As String = ""
        Dim listOCVisit As New List(Of String)
        dr = dtOrdenEmbarcada.Select("NORSCI='" & NORSCI & "'")
        For Each Item As DataRow In dr
            strNorcml = ("" & Item("NORCML")).ToString.Trim
            If strNorcml.Length > 0 Then
                If Not listOCVisit.Contains(strNorcml) Then
                    listOCVisit.Add(strNorcml)
                End If
            End If
        Next
        Dim drCost As DataRow
        
        For Each Item As String In listOCVisit
            strNorcml = Item
            drCost = dtCostosDetalleOC.NewRow
            drCost("NORCML") = strNorcml
            drCost("IVFOBD") = dtOrdenEmbarcada.Compute("SUM(IVLDOL)", "NORSCI='" & NORSCI & "' AND NORCML='" & strNorcml & "' AND CODVAR='FOB'")
            drCost("VALFLT") = dtOrdenEmbarcada.Compute("SUM(IVLDOL)", "NORSCI='" & NORSCI & "' AND NORCML='" & strNorcml & "' AND CODVAR='FLETE'")
            drCost("VALSEG") = dtOrdenEmbarcada.Compute("SUM(IVLDOL)", "NORSCI='" & NORSCI & "' AND NORCML='" & strNorcml & "' AND CODVAR='SEGURO'")
            drCost("VALIGV") = dtOrdenEmbarcada.Compute("SUM(IVLDOL)", "NORSCI='" & NORSCI & "' AND NORCML='" & strNorcml & "' AND CODVAR='IGV'")
            drCost("VALIPM") = dtOrdenEmbarcada.Compute("SUM(IVLDOL)", "NORSCI='" & NORSCI & "' AND NORCML='" & strNorcml & "' AND CODVAR='IPM'")
            drCost("IMPCIF") = dtOrdenEmbarcada.Compute("SUM(IVLDOL)", "NORSCI='" & NORSCI & "' AND NORCML='" & strNorcml & "' AND CODVAR='CIF'")
            drCost("VALADV") = dtOrdenEmbarcada.Compute("SUM(IVLDOL)", "NORSCI='" & NORSCI & "' AND NORCML='" & strNorcml & "' AND CODVAR='ADVALO'")
            drCost("VALOGS") = dtOrdenEmbarcada.Compute("SUM(IVLDOL)", "NORSCI='" & NORSCI & "' AND NORCML='" & strNorcml & "' AND CODVAR='OTSGAS'")


            If drCost("IVFOBD") Is DBNull.Value Then drCost("IVFOBD") = 0
            If drCost("VALFLT") Is DBNull.Value Then drCost("VALFLT") = 0
            If drCost("VALSEG") Is DBNull.Value Then drCost("VALSEG") = 0
            If drCost("VALIGV") Is DBNull.Value Then drCost("VALIGV") = 0
            If drCost("VALIPM") Is DBNull.Value Then drCost("VALIPM") = 0
            If drCost("IMPCIF") Is DBNull.Value Then drCost("IMPCIF") = 0
            If drCost("VALADV") Is DBNull.Value Then drCost("VALADV") = 0
            If drCost("VALOGS") Is DBNull.Value Then drCost("VALOGS") = 0

            drCost("IIGVPM") = drCost("VALIGV") + drCost("VALIPM")
            drCost("VALTOT") = drCost("VALADV") + drCost("VALIGV") + drCost("VALIPM") + drCost("VALOGS")
            dtCostosDetalleOC.Rows.Add(drCost)
        Next
        Return dtCostosDetalleOC
        '        SUM ( VALFOB ) AS IVFOBD ,
        'SUM ( VALFLT ) AS VALFLT ,
        'SUM ( VALSEG ) AS VALSEG ,
        'SUM ( IMPCIF ) AS IMPCIF ,
        'SUM ( VALADV ) AS VALADV ,
        'SUM ( VALIGV ) + SUM ( VALIPM ) AS IIGVPM ,
        'SUM ( VALRNP ) AS VALOGS ,
        'SUM ( VALADV ) + SUM ( VALIGV ) + SUM ( VALIPM ) + SUM ( VALRNP ) AS VALTOT

    End Function

    Public Function dtRepMonthlyOperacionesUnificado(ByVal dtOperaciones As DataTable, ByVal dtOrdenCompra As DataTable, ByVal dtOrdenesEmbarcados As DataTable) As DataTable
        Dim oDt As DataTable
        Dim oDtNew As New DataTable
        Dim intCont As Integer
        Dim intRow As Integer
        Dim oDr As DataRow
        Dim dtOp As New DataTable
        Dim NORSCI As Decimal = 0

        'oDtOper = oReporte.dtRepMonthlyOperaciones(PSCCMPN, pdblCodCli, pdblFecIni, pdblFecFin, ListaRegimen, PSTPSRVA, PNNESTDO, PSESTADO_EMB)

        dtOperaciones.Columns.Add("NORCML")
        For Each Item As DataRow In dtOperaciones.Rows
            NORSCI = Item("NORSCI")
            Item("NORCML") = DistinctOrdenCompra(dtOrdenCompra, NORSCI)
        Next
        oDtOper = dtOperaciones.Copy

        oDt = dtOperaciones.Copy
        Formato_Operaciones()
        '    Item("NORCML") = DistinctOrdenCompra(dtOC, NORSCI)
        'Dim NORCML As String = ""
        For intCont = 0 To oDt.Rows.Count - 1
            oDtNew.Rows.Clear()
            NORSCI = oDt.Rows(intCont).Item("NORSCI")
            'NORCML = DistinctOrdenCompra(dtOrdenCompra, NORSCI)
            If Not IsDBNull(oDt.Rows(intCont).Item("CPLNDV")) Then
                oDtNew = oReporte.dtRepMonthlyOperacionesAgencias(oDt.Rows(intCont).Item("PNNMOS").ToString, oDt.Rows(intCont).Item("CZNFCC").ToString, oDt.Rows(intCont).Item("TPSRVA").ToString, oDt.Rows(intCont).Item("CPLNDV").ToString)
            End If
            'oDtNew = SumarizarCostosxOrdenCompra(NORSCI, dtOrdenesEmbarcados)
            If oDtNew.Rows.Count = 0 Then
                oDr = oDtOperaciones.NewRow
                oDr.Item("NORSCI") = oDt.Rows(intCont).Item("NORSCI").ToString
                oDr.Item("PNNMOS") = oDt.Rows(intCont).Item("PNNMOS").ToString
                oDr.Item("TDSCRG") = oDt.Rows(intCont).Item("TDSCRG").ToString
                oDr.Item("QPSOAR") = oDt.Rows(intCont).Item("QPSOAR").ToString
                oDr.Item("IVLFLT") = oDt.Rows(intCont).Item("IVLFLT").ToString
                oDr.Item("IVLSGR") = oDt.Rows(intCont).Item("IVLSGR").ToString
                oDr.Item("ITTCIF") = oDt.Rows(intCont).Item("ITTCIF").ToString
                oDr.Item("ITTADV") = oDt.Rows(intCont).Item("ITTADV").ToString
                oDr.Item("IGVIPM") = oDt.Rows(intCont).Item("IGVIPM").ToString
                oDr.Item("TOTAL") = oDt.Rows(intCont).Item("TOTAL").ToString
                oDr.Item("ITTOGS") = oDt.Rows(intCont).Item("ITTOGS").ToString
                oDr.Item("ITTFOB") = oDt.Rows(intCont).Item("ITTFOB").ToString
                oDr.Item("IVLEXW") = oDt.Rows(intCont).Item("IVLEXW").ToString
                oDr.Item("IVGFOB") = oDt.Rows(intCont).Item("IVGFOB").ToString
                oDr.Item("NORCML") = oDt.Rows(intCont).Item("NORCML").ToString
                'oDr.Item("NORCML") = ""
                oDr.Item("IVFOBD") = 0.0
                oDr.Item("VALFLT") = 0.0
                oDr.Item("VALSEG") = 0.0
                oDr.Item("IMPCIF") = 0.0
                oDr.Item("VALADV") = 0.0
                oDr.Item("IIGVPM") = 0.0
                oDr.Item("VALOGS") = 0.0
                oDr.Item("VALTOT") = 0.0

                oDr.Item("REGIMEN") = oDt.Rows(intCont).Item("REGIMEN").ToString

                oDtOperaciones.Rows.Add(oDr)
            Else
                For intRow = 0 To oDtNew.Rows.Count - 1
                    oDr = oDtOperaciones.NewRow
                    oDr.Item("NORSCI") = oDt.Rows(intCont).Item("NORSCI").ToString
                    oDr.Item("PNNMOS") = oDt.Rows(intCont).Item("PNNMOS").ToString
                    oDr.Item("TDSCRG") = oDt.Rows(intCont).Item("TDSCRG").ToString
                    oDr.Item("QPSOAR") = oDt.Rows(intCont).Item("QPSOAR").ToString
                    oDr.Item("IVLFLT") = oDt.Rows(intCont).Item("IVLFLT").ToString
                    oDr.Item("IVLSGR") = oDt.Rows(intCont).Item("IVLSGR").ToString
                    oDr.Item("ITTCIF") = oDt.Rows(intCont).Item("ITTCIF").ToString
                    oDr.Item("ITTADV") = oDt.Rows(intCont).Item("ITTADV").ToString
                    oDr.Item("IGVIPM") = oDt.Rows(intCont).Item("IGVIPM").ToString
                    oDr.Item("TOTAL") = oDt.Rows(intCont).Item("TOTAL").ToString
                    oDr.Item("ITTOGS") = oDt.Rows(intCont).Item("ITTOGS").ToString
                    oDr.Item("ITTFOB") = oDt.Rows(intCont).Item("ITTFOB").ToString
                    oDr.Item("IVLEXW") = oDt.Rows(intCont).Item("IVLEXW").ToString
                    oDr.Item("IVGFOB") = oDt.Rows(intCont).Item("IVGFOB").ToString
                    'oDr.Item("NORCML") = oDt.Rows(intCont).Item("NORCML").ToString
                    oDr.Item("NORCML") = oDt.Rows(intCont).Item("NORCML").ToString
                    oDr.Item("IVFOBD") = oDtNew.Rows(intRow).Item("IVFOBD").ToString
                    oDr.Item("VALFLT") = oDtNew.Rows(intRow).Item("VALFLT").ToString
                    oDr.Item("VALSEG") = oDtNew.Rows(intRow).Item("VALSEG").ToString
                    oDr.Item("IMPCIF") = oDtNew.Rows(intRow).Item("IMPCIF").ToString
                    oDr.Item("VALADV") = oDtNew.Rows(intRow).Item("VALADV").ToString
                    oDr.Item("IIGVPM") = oDtNew.Rows(intRow).Item("IIGVPM").ToString
                    oDr.Item("VALOGS") = oDtNew.Rows(intRow).Item("VALOGS").ToString
                    oDr.Item("VALTOT") = oDtNew.Rows(intRow).Item("VALTOT").ToString
                    oDr.Item("REGIMEN") = oDt.Rows(intCont).Item("REGIMEN").ToString
                    oDtOperaciones.Rows.Add(oDr)
                Next intRow
            End If
        Next intCont
        Return oDtOperaciones
    End Function


    Public Function RepMonthlyAduanas(ByVal PSCCMPN As String, ByVal PNCCLNT As Double, ByVal PNFECINI As Double, ByVal PNFECFIN As Double, ByVal ListaRegimen As String, ByVal PSTPSRVA As String, ByVal PNNESTDO As Decimal, ByVal PSESTADO_EMB As String) As DataSet
        dsReporte = oReporte.RepMonthlyAduanasUnificado(PSCCMPN, PNCCLNT, PNFECINI, PNFECFIN, ListaRegimen, PSTPSRVA, PNNESTDO, PSESTADO_EMB)
        dsReporte.Tables(0).TableName = "DTOPERACION"
        dsReporte.Tables(1).TableName = "DTORDENCOMPRA"
        dsReporte.Tables(2).TableName = "DTCONTENEDOR"
        dsReporte.Tables(3).TableName = "DTNAVIERRA"
        dsReporte.Tables(4).TableName = "DTTIEMPOENTREGA"
        dsReporte.Tables(5).TableName = "DTFECHADOCUMENTOS"
        dsReporte.Tables(6).TableName = "DTTFECHAADUANA"
        dsReporte.Tables(7).TableName = "DTCHECKADUANA"
        dsReporte.Tables(8).TableName = "DTFERIADO"
        dsReporte.Tables(9).TableName = "DTORDENEMBARCADO"
        Return dsReporte
    End Function


    Private Sub Formato_Facturacion()
        oDtFactAduana.Columns.Add(New DataColumn("NORDSR", GetType(System.String)))
        oDtFactAduana.Columns.Add(New DataColumn("TDSCRG", GetType(System.String)))
        oDtFactAduana.Columns.Add(New DataColumn("DEVITO", GetType(System.Double)))
        oDtFactAduana.Columns.Add(New DataColumn("GSTVAR", GetType(System.Double)))
        oDtFactAduana.Columns.Add(New DataColumn("COMISI", GetType(System.Double)))
        oDtFactAduana.Columns.Add(New DataColumn("OTROS", GetType(System.Double)))
        oDtFactAduana.Columns.Add(New DataColumn("TOTAL", GetType(System.Double)))
        oDtFactAduana.Columns.Add(New DataColumn("NORCML_1", GetType(System.String)))
        oDtFactAduana.Columns.Add(New DataColumn("NORCML", GetType(System.String)))
        oDtFactAduana.Columns.Add(New DataColumn("REGIMEN", GetType(System.String)))
    End Sub

    Public Function dtRepMonthlyFacturacion(ByVal pdblCodCli As Double, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double) As DataTable
        Dim oDt As DataTable
        Dim oDtNew As New DataTable
        Dim intCont As Integer
        Dim intRow As Integer
        Dim oDr As DataRow

        oDt = oDtOper.Copy
        Formato_Facturacion()
        For intCont = 0 To oDt.Rows.Count - 1
            oDtNew.Rows.Clear()
            If Not IsDBNull(oDt.Rows(intCont).Item("CPLNDV")) Then
                oDtNew = oReporte.dtRepMonthlyFacturacion(pdblCodCli, oDt.Rows(intCont).Item("PNNMOS").ToString, oDt.Rows(intCont).Item("CZNFCC").ToString, oDt.Rows(intCont).Item("TPSRVA").ToString, oDt.Rows(intCont).Item("CPLNDV").ToString)
            End If
            If oDtNew.Rows.Count = 0 Then
                Dim CPLNDV As String = oDt.Rows(intCont).Item("CPLNDV").ToString
                If (CPLNDV = "" AndAlso Not IsNumeric(CPLNDV)) Then
                    CPLNDV = "0"
                End If
                oDr = oDtFactAduana.NewRow
                oDr.Item("NORDSR") = oDt.Rows(intCont).Item("PNNMOS").ToString
                oDr.Item("TDSCRG") = oDt.Rows(intCont).Item("TDSCRG").ToString
                oDr.Item("DEVITO") = 0.0
                oDr.Item("GSTVAR") = 0.0
                oDr.Item("COMISI") = 0.0
                oDr.Item("OTROS") = 0.0
                oDr.Item("TOTAL") = 0.0
                oDr.Item("NORCML_1") = oDt.Rows(intCont).Item("NORCML").ToString
                oDr.Item("NORCML") = oDt.Rows(intCont).Item("NORCML").ToString
                oDr.Item("REGIMEN") = oDt.Rows(intCont).Item("REGIMEN").ToString
                oDtFactAduana.Rows.Add(oDr)
            Else
                For intRow = 0 To oDtNew.Rows.Count - 1
                    oDr = oDtFactAduana.NewRow
                    oDr.Item("NORDSR") = oDtNew.Rows(intRow).Item("NORDSR").ToString
                    oDr.Item("TDSCRG") = oDt.Rows(intCont).Item("TDSCRG").ToString
                    oDr.Item("DEVITO") = oDtNew.Rows(intRow).Item("DEVITO").ToString
                    oDr.Item("GSTVAR") = oDtNew.Rows(intRow).Item("GSTVAR").ToString
                    oDr.Item("COMISI") = oDtNew.Rows(intRow).Item("COMISI").ToString
                    oDr.Item("OTROS") = oDtNew.Rows(intRow).Item("OTROS").ToString
                    oDr.Item("TOTAL") = oDtNew.Rows(intRow).Item("TOTAL").ToString
                    oDr.Item("NORCML_1") = oDt.Rows(intCont).Item("NORCML").ToString
                    oDr.Item("NORCML") = oDt.Rows(intCont).Item("NORCML").ToString
                    oDr.Item("REGIMEN") = oDt.Rows(intCont).Item("REGIMEN").ToString
                    oDtFactAduana.Rows.Add(oDr)
                Next intRow
            End If
        Next intCont
        Return oDtFactAduana
    End Function

    Private Sub Formato_Detalle_Debito()
        oDtDetDebito.Columns.Add(New DataColumn("NORDSR", GetType(System.String)))
        oDtDetDebito.Columns.Add(New DataColumn("CSRVRL", GetType(System.String)))
        oDtDetDebito.Columns.Add(New DataColumn("TCMTRF", GetType(System.String)))
        oDtDetDebito.Columns.Add(New DataColumn("MONTO", GetType(System.Double)))
        oDtDetDebito.Columns.Add(New DataColumn("TABTPD", GetType(System.String)))
        oDtDetDebito.Columns.Add(New DataColumn("NDCCT1", GetType(System.String)))
        oDtDetDebito.Columns.Add(New DataColumn("FDCCT1", GetType(System.String)))
        oDtDetDebito.Columns.Add(New DataColumn("NOMPRO", GetType(System.String)))
        oDtDetDebito.Columns.Add(New DataColumn("TDSCRG", GetType(System.String)))
        oDtDetDebito.Columns.Add(New DataColumn("TOTDEB", GetType(System.Double)))
        oDtDetDebito.Columns.Add(New DataColumn("NORCML_1", GetType(System.String)))
        oDtDetDebito.Columns.Add(New DataColumn("NORCML", GetType(System.String)))
        oDtDetDebito.Columns.Add(New DataColumn("TOTCO", GetType(System.Double)))
        oDtDetDebito.Columns.Add(New DataColumn("IND_CO", GetType(System.String)))
        oDtDetDebito.Columns.Add(New DataColumn("CHECK_CO", GetType(System.String)))
        oDtDetDebito.Columns.Add(New DataColumn("REGIMEN", GetType(System.String)))

    End Sub

    Private Sub FormatoCotenedores()
        oDtContenedor.Columns.Add(New DataColumn("PNNMOS", GetType(System.String)))
        oDtContenedor.Columns.Add(New DataColumn("TCMPPS", GetType(System.String)))
        oDtContenedor.Columns.Add(New DataColumn("NDOCEM", GetType(System.String)))
        oDtContenedor.Columns.Add(New DataColumn("TPRCL1", GetType(System.String)))
        oDtContenedor.Columns.Add(New DataColumn("TCMPVP", GetType(System.String)))
        oDtContenedor.Columns.Add(New DataColumn("TNMCIN", GetType(System.String)))
        oDtContenedor.Columns.Add(New DataColumn("QCANTI", GetType(System.Double)))
        oDtContenedor.Columns.Add(New DataColumn("TDSCRG", GetType(System.String)))
        oDtContenedor.Columns.Add(New DataColumn("QPSOAR", GetType(System.Double)))
        oDtContenedor.Columns.Add(New DataColumn("FAPRAR", GetType(System.String)))
        oDtContenedor.Columns.Add(New DataColumn("NORCML_1", GetType(System.String)))
        oDtContenedor.Columns.Add(New DataColumn("NORCML", GetType(System.String)))
        oDtContenedor.Columns.Add(New DataColumn("REGIMEN", GetType(System.String)))
    End Sub

    Public Function dtRepMonthlyDetalleDebito(ByVal pdblCodCli As Double, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double) As DataTable
        Dim intCont As Integer
        Dim intRow As Integer
        Dim intPos As Integer
        Dim oDt As DataTable
        Dim oDtNew As New DataTable
        Dim oDr As DataRow
        Dim oHasOS As New Hashtable
        Dim OS As String = ""
        Dim MontoCostoOperativo As Decimal = 0
        Dim chk_CostoOperativo As String = ""

        oDt = oDtOper.Copy
        Formato_Detalle_Debito()
        For intCont = 0 To oDt.Rows.Count - 1
            oDtNew.Rows.Clear()
            If Not IsDBNull(oDt.Rows(intCont).Item("CPLNDV")) Then
                oDtNew = oReporte.dtRepMonthlyDetalleDebito(oDt.Rows(intCont).Item("PNNMOS").ToString, oDt.Rows(intCont).Item("CZNFCC").ToString, oDt.Rows(intCont).Item("TPSRVA").ToString, oDt.Rows(intCont).Item("CPLNDV").ToString)
            End If
            If oDtNew.Rows.Count = 0 Then
                Dim CPLNDV As String = oDt.Rows(intCont).Item("CPLNDV").ToString
                If (CPLNDV = "" AndAlso Not IsNumeric(CPLNDV)) Then
                    CPLNDV = "0"
                End If
                oDr = oDtDetDebito.NewRow
                oDr.Item("NORDSR") = oDt.Rows(intCont).Item("PNNMOS").ToString
                oDr.Item("CSRVRL") = ""
                oDr.Item("TCMTRF") = ""
                oDr.Item("MONTO") = 0.0
                oDr.Item("TABTPD") = ""
                oDr.Item("NDCCT1") = ""
                oDr.Item("FDCCT1") = ""
                oDr.Item("NOMPRO") = ""
                oDr.Item("TDSCRG") = oDt.Rows(intCont).Item("TDSCRG").ToString
                oDr.Item("TOTDEB") = 0.0
                oDr.Item("NORCML_1") = oDt.Rows(intCont).Item("NORCML").ToString
                oDr.Item("NORCML") = oDt.Rows(intCont).Item("NORCML").ToString
                oDr.Item("TOTCO") = 0.0
                oDr.Item("IND_CO") = ""
                oDr.Item("CHECK_CO") = ""

                oDr.Item("REGIMEN") = oDt.Rows(intCont).Item("REGIMEN").ToString
                oDtDetDebito.Rows.Add(oDr)
            Else
                For intRow = 0 To oDtNew.Rows.Count - 1
                    oDr = oDtDetDebito.NewRow
                    oDr.Item("NORDSR") = oDtNew.Rows(intRow).Item("NORDSR").ToString
                    oDr.Item("CSRVRL") = oDtNew.Rows(intRow).Item("CSRVRL").ToString
                    oDr.Item("TCMTRF") = oDtNew.Rows(intRow).Item("TCMTRF").ToString
                    oDr.Item("MONTO") = oDtNew.Rows(intRow).Item("MONTO").ToString
                    oDr.Item("TABTPD") = oDtNew.Rows(intRow).Item("TABTPD").ToString
                    oDr.Item("NDCCT1") = oDtNew.Rows(intRow).Item("NDCCT1").ToString
                    oDr.Item("FDCCT1") = oDtNew.Rows(intRow).Item("FDCCT1").ToString
                    oDr.Item("NOMPRO") = oDtNew.Rows(intRow).Item("NOMPRO").ToString
                    oDr.Item("TDSCRG") = oDt.Rows(intCont).Item("TDSCRG").ToString
                    oDr.Item("TOTDEB") = 0.0
                    oDr.Item("NORCML_1") = oDt.Rows(intCont).Item("NORCML").ToString
                    oDr.Item("NORCML") = oDt.Rows(intCont).Item("NORCML").ToString
                    oDr.Item("REGIMEN") = oDt.Rows(intCont).Item("REGIMEN").ToString


                    oDr.Item("TOTCO") = 0.0
                    oDr.Item("IND_CO") = oDtNew.Rows(intRow).Item("IND_CO").ToString.Trim
                    If (oDtNew.Rows(intRow).Item("IND_CO").ToString.Trim = "0") Then
                        oDr.Item("CHECK_CO") = "-"
                    Else
                        oDr.Item("CHECK_CO") = ""
                    End If

                    oDtDetDebito.Rows.Add(oDr)
                Next intRow
            End If
        Next intCont
        For intCont = 0 To oDtDetDebito.Rows.Count - 1
            intPos = Buscar_Posicion(oDtFactAduana, oDtDetDebito.Rows(intCont).Item("NORDSR").ToString.Trim)
            If intPos > -1 Then
                oDtDetDebito.Rows(intCont).Item("TOTDEB") = oDtFactAduana.Rows(intPos).Item("DEVITO")
            End If
        Next intCont

        'ALGORITMO PARA HALLAR LOS COSTOS OPERATIVOS
        'DE ACUERDO AL INDICADOR SI ES CERO ES CONSIDERADO COMO COSTO OPERATIVO
        oHasOS.Clear()
        OS = ""
        For FILA As Integer = 0 To oDtDetDebito.Rows.Count - 1
            OS = oDtDetDebito.Rows(FILA).Item("NORDSR").ToString.Trim

            If (oHasOS.ContainsKey(OS)) Then
                oDtDetDebito.Rows(FILA).Item("TOTCO") = oHasOS(OS)
            Else
                MontoCostoOperativo = 0
                For FILA_IN As Integer = 0 To oDtDetDebito.Rows.Count - 1
                    If (oDtDetDebito.Rows(FILA_IN).Item("NORDSR") = OS And oDtDetDebito.Rows(FILA_IN).Item("IND_CO") = "0") Then
                        MontoCostoOperativo += oDtDetDebito.Rows(FILA_IN).Item("MONTO")
                    End If
                Next
                oHasOS(OS) = MontoCostoOperativo
                oDtDetDebito.Rows(FILA).Item("TOTCO") = oHasOS(OS)
            End If
        Next

        Return oDtDetDebito
    End Function

    Public Function Buscar_Posicion(ByVal poDt As DataTable, ByVal pstrOS As String) As Integer
        Dim intCont As Integer
        Dim intPos As Integer = -1

        For intCont = 0 To poDt.Rows.Count - 1
            If poDt.Rows(intCont).Item("NORDSR").ToString.Trim = pstrOS.Trim Then
                intPos = intCont
                Exit For
            End If
        Next intCont

        Return intPos
    End Function

    Public Function dtRepMonthlyContenedores(ByVal PSCCMPN As String, ByVal pdblCodCli As Double, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double, ByVal PSLISTAREGIMEN As String, ByVal PSTPSRVA As String, ByVal PNNESTDO As Decimal, ByVal PSESTADO_EMB As String) As DataTable
        Dim intCont As Integer
        Dim oDt As DataTable
        Dim oDtNew As New DataTable
        Dim oDr As DataRow
        oDt = oReporte.dtRepMonthlyContenedores(PSCCMPN, pdblCodCli, pdblFecIni, pdblFecFin, PSLISTAREGIMEN, PSTPSRVA, PNNESTDO, PSESTADO_EMB)
        FormatoCotenedores()
        For intCont = 0 To oDt.Rows.Count - 1
            With oDt.Rows(intCont)
                oDtNew.Rows.Clear()
                oDr = oDtContenedor.NewRow
                oDr.Item("PNNMOS") = oDt.Rows(intCont).Item("PNNMOS").ToString
                oDr.Item("TCMPPS") = oDt.Rows(intCont).Item("TCMPPS").ToString
                oDr.Item("NDOCEM") = oDt.Rows(intCont).Item("NDOCEM").ToString
                oDr.Item("TPRCL1") = ("" & oDt.Rows(intCont).Item("TPRCL1")).ToString.Trim
                oDr.Item("TCMPVP") = ("" & oDt.Rows(intCont).Item("TCMPVP")).ToString.Trim
                oDr.Item("TNMCIN") = ("" & oDt.Rows(intCont).Item("TNMCIN")).ToString.Trim
                oDr.Item("QCANTI") = oDt.Rows(intCont).Item("QCANTI")
                oDr.Item("TDSCRG") = ("" & oDt.Rows(intCont).Item("TDSCRG")).ToString.Trim
                oDr.Item("QPSOAR") = oDt.Rows(intCont).Item("QPSOAR")
                oDr.Item("FAPRAR") = oDt.Rows(intCont).Item("FAPRAR").ToString
                oDr.Item("NORCML_1") = oDt.Rows(intCont).Item("NORCML").ToString
                oDr.Item("NORCML") = oDt.Rows(intCont).Item("NORCML").ToString
                oDr.Item("REGIMEN") = oDt.Rows(intCont).Item("REGIMEN").ToString
                oDtContenedor.Rows.Add(oDr)
            End With
        Next
        Return oDtContenedor
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

    Public Function dtRepMonthlyContenedoresUnificado(ByVal dtContenedor As DataTable, ByVal dtOrdenCompra As DataTable) As DataTable
        Dim intCont As Integer
        Dim oDt As DataTable
        Dim oDtNew As New DataTable
        Dim oDr As DataRow
        'oDt = oReporte.dtRepMonthlyContenedores(PSCCMPN, pdblCodCli, pdblFecIni, pdblFecFin, PSLISTAREGIMEN, PSTPSRVA, PNNESTDO, PSESTADO_EMB)
        oDt = dtContenedor.Copy
        FormatoCotenedores()
        For intCont = 0 To oDt.Rows.Count - 1
            'With oDt.Rows(intCont)
            oDtNew.Rows.Clear()
            oDr = oDtContenedor.NewRow
            oDr.Item("PNNMOS") = oDt.Rows(intCont).Item("PNNMOS").ToString
            oDr.Item("TCMPPS") = HelpClass.ToStringCvr(oDt.Rows(intCont).Item("TCMPPS"))
            oDr.Item("NDOCEM") = HelpClass.ToStringCvr(oDt.Rows(intCont).Item("NDOCEM"))
            oDr.Item("TPRCL1") = HelpClass.ToStringCvr(oDt.Rows(intCont).Item("TPRCL1"))
            oDr.Item("TCMPVP") = HelpClass.ToStringCvr(oDt.Rows(intCont).Item("TCMPVP"))
            oDr.Item("TNMCIN") = HelpClass.ToStringCvr(oDt.Rows(intCont).Item("TNMCIN"))
            oDr.Item("QCANTI") = oDt.Rows(intCont).Item("QCANTI")
            oDr.Item("TDSCRG") = HelpClass.ToStringCvr(oDt.Rows(intCont).Item("TDSCRG"))
            oDr.Item("QPSOAR") = oDt.Rows(intCont).Item("QPSOAR")
            'oDr.Item("FAPRAR") = oDt.Rows(intCont).Item("FAPRAR").ToString
            oDr.Item("FAPRAR") = HelpClass.FechaNum_a_Fecha(oDt.Rows(intCont).Item("FAPRAR").ToString)
            'oDr.Item("NORCML_1") = oDt.Rows(intCont).Item("NORCML").ToString
            oDr.Item("NORCML_1") = DistinctOrdenCompra(dtOrdenCompra, oDt.Rows(intCont).Item("NORSCI"))
            oDr.Item("NORCML") = DistinctOrdenCompra(dtOrdenCompra, oDt.Rows(intCont).Item("NORSCI"))
            oDr.Item("REGIMEN") = HelpClass.ToStringCvr(oDt.Rows(intCont).Item("REGIMEN"))
            oDtContenedor.Rows.Add(oDr)
            'End With
        Next
        Return oDtContenedor
    End Function


    Public Function dtRepMonthlyTiempoEntrega(ByVal PSCCMPN As String, ByVal pdblCodCli As Double, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double, ByVal PSLISTAREGIMEN As String, ByVal PSTPSRVA As String, ByVal PNNESTDO As Decimal, ByVal PSESTADO_EMB As String) As DataTable
        Dim oDtDoc As DataTable
        Dim intCont As Integer
        Dim intDias As Integer
        Dim strFecha As String
        Dim strETA As String
        Dim lobjDrList() As DataRow

        oDtEntregaDoc = oReporte.dtRepMonthlyTiempoEntrega(PSCCMPN, pdblCodCli, pdblFecIni, pdblFecFin, PSLISTAREGIMEN, PSTPSRVA, PNNESTDO, PSESTADO_EMB)
        oDtDoc = oReporte.dtRepMonthlyFechaDocumentos(PSCCMPN, pdblCodCli, pdblFecIni, pdblFecFin, PSLISTAREGIMEN, PSTPSRVA, PNNESTDO, PSESTADO_EMB)
        oDtNoLab = oReporte.dtNoLaborables(20080101, pdblFecFin)
        Formato_Entrega_Documento()
        For intCont = 0 To oDtEntregaDoc.Rows.Count - 1
            With oDtEntregaDoc.Rows(intCont)
                .Item("NORCML_1") = oDtEntregaDoc.Rows(intCont)("NORCML").ToString
                strETA = .Item("FAPRAR").ToString.Trim
                strFecha = Fecha_Factura(.Item("NORSCI").ToString.Trim, oDtDoc)
                .Item("FECFAC") = strFecha
                If Not (strETA = "" Or strFecha = "---") Then
                    lobjDrList = oDtNoLab.Select("FFRDO >= " & Format(CType(strFecha, Date), "yyyyMMdd") & " AND FFRDO <= " & Format(CType(strETA, Date), "yyyyMMdd"))
                    intDias = fintDiferencia_Dia(strFecha, strETA, lobjDrList.Length)
                    .Item("DIAFAC") = intDias
                End If
                strFecha = Fecha_Doc_Embarque(.Item("NORSCI").ToString.Trim, oDtDoc)
                .Item("FECDOC") = strFecha
                If Not (strETA = "" Or strFecha = "---") Then
                    lobjDrList = oDtNoLab.Select("FFRDO >= " & Format(CType(strFecha, Date), "yyyyMMdd") & " AND FFRDO <= " & Format(CType(strETA, Date), "yyyyMMdd"))
                    intDias = fintDiferencia_Dia(strFecha, strETA, lobjDrList.Length)
                    .Item("DIADOC") = intDias
                End If
                strFecha = Fecha_Traduccion(.Item("NORSCI").ToString.Trim, oDtDoc)
                .Item("FECTRA") = strFecha
                If Not (strETA = "" Or strFecha = "---") Then
                    lobjDrList = oDtNoLab.Select("FFRDO >= " & Format(CType(strFecha, Date), "yyyyMMdd") & " AND FFRDO <= " & Format(CType(strETA, Date), "yyyyMMdd"))
                    intDias = fintDiferencia_Dia(strFecha, strETA, lobjDrList.Length)
                    .Item("DIATRA") = intDias
                End If
            End With
        Next intCont

        Return oDtEntregaDoc
    End Function


    Public Function dtRepMonthlyTiempoEntregaUnificado(ByVal dtTiempoEntrega As DataTable, ByVal dtFechaDocumento As DataTable, ByVal dtOrdenCompra As DataTable, ByVal dtFeriados As DataTable) As DataTable
        Dim oDtDoc As DataTable
        Dim intCont As Integer
        Dim intDias As Integer
        Dim strFecha As String
        Dim strETA As String
        Dim lobjDrList() As DataRow

        ' oDtEntregaDoc = oReporte.dtRepMonthlyTiempoEntrega(PSCCMPN, pdblCodCli, pdblFecIni, pdblFecFin, PSLISTAREGIMEN, PSTPSRVA, PNNESTDO, PSESTADO_EMB)
        oDtEntregaDoc = dtTiempoEntrega.Copy
        oDtEntregaDoc.Columns.Add("NORCML")
        'oDtDoc = oReporte.dtRepMonthlyFechaDocumentos(PSCCMPN, pdblCodCli, pdblFecIni, pdblFecFin, PSLISTAREGIMEN, PSTPSRVA, PNNESTDO, PSESTADO_EMB)
        oDtDoc = dtFechaDocumento.Copy
        'oDtNoLab = oReporte.dtNoLaborables(20080101, pdblFecFin)
        oDtNoLab = dtFeriados.Copy
        Formato_Entrega_Documento()

        'Item("FAPRAR") = HelpClass.FechaNum_a_Fecha(Item("FAPRAR"))
        'Item("NORCML") = DistinctOrdenCompra(dtOC, NORSCI)

     

        For intCont = 0 To oDtEntregaDoc.Rows.Count - 1
            oDtEntregaDoc.Rows(intCont).Item("FAPRAR") = HelpClass.FechaNum_a_Fecha(oDtEntregaDoc.Rows(intCont).Item("FAPRAR"))
            oDtEntregaDoc.Rows(intCont)("NORCML") = DistinctOrdenCompra(dtOrdenCompra, oDtEntregaDoc.Rows(intCont).Item("NORSCI"))

            'With oDtEntregaDoc.Rows(intCont)
            oDtEntregaDoc.Rows(intCont).Item("NORCML_1") = oDtEntregaDoc.Rows(intCont)("NORCML").ToString
            strETA = oDtEntregaDoc.Rows(intCont).Item("FAPRAR").ToString.Trim
            strFecha = Fecha_Factura(oDtEntregaDoc.Rows(intCont).Item("NORSCI").ToString.Trim, oDtDoc)
            oDtEntregaDoc.Rows(intCont).Item("FECFAC") = strFecha
            If Not (strETA = "" Or strFecha = "---") Then
                lobjDrList = oDtNoLab.Select("FFRDO >= " & Format(CType(strFecha, Date), "yyyyMMdd") & " AND FFRDO <= " & Format(CType(strETA, Date), "yyyyMMdd"))
                intDias = fintDiferencia_Dia(strFecha, strETA, lobjDrList.Length)
                oDtEntregaDoc.Rows(intCont).Item("DIAFAC") = intDias
            End If
            strFecha = Fecha_Doc_Embarque(oDtEntregaDoc.Rows(intCont).Item("NORSCI").ToString.Trim, oDtDoc)
            oDtEntregaDoc.Rows(intCont).Item("FECDOC") = strFecha
            If Not (strETA = "" Or strFecha = "---") Then
                lobjDrList = oDtNoLab.Select("FFRDO >= " & Format(CType(strFecha, Date), "yyyyMMdd") & " AND FFRDO <= " & Format(CType(strETA, Date), "yyyyMMdd"))
                intDias = fintDiferencia_Dia(strFecha, strETA, lobjDrList.Length)
                oDtEntregaDoc.Rows(intCont).Item("DIADOC") = intDias
            End If
            strFecha = Fecha_Traduccion(oDtEntregaDoc.Rows(intCont).Item("NORSCI").ToString.Trim, oDtDoc)
            oDtEntregaDoc.Rows(intCont).Item("FECTRA") = strFecha
            If Not (strETA = "" Or strFecha = "---") Then
                lobjDrList = oDtNoLab.Select("FFRDO >= " & Format(CType(strFecha, Date), "yyyyMMdd") & " AND FFRDO <= " & Format(CType(strETA, Date), "yyyyMMdd"))
                intDias = fintDiferencia_Dia(strFecha, strETA, lobjDrList.Length)
                oDtEntregaDoc.Rows(intCont).Item("DIATRA") = intDias
            End If
            'End With
        Next intCont

        Return oDtEntregaDoc
    End Function

    Private Function fintDiferencia_Dia(ByVal pstrDiaFinal As String, ByVal pstrDiaInicio As String, ByVal pintDia As Integer) As Integer
        Dim lintDif As Integer
        If IsDBNull(pstrDiaFinal) Or pstrDiaFinal = vbNullString Or IsDBNull(pstrDiaInicio) Or pstrDiaInicio = vbNullString Then
            Return 0
        End If
        lintDif = DateDiff(DateInterval.Day, CType(pstrDiaInicio, Date), CType(pstrDiaFinal, Date))
        If lintDif >= 0 Then
            lintDif = lintDif - pintDia
        Else
            lintDif = lintDif + pintDia
        End If
        Return lintDif
    End Function

    Private Function Fecha_Traduccion(ByVal pstrEmb As String, ByVal poDt As DataTable) As String
        Dim intCont As Integer
        Dim strFecha As String = "---"

        For intCont = 0 To poDt.Rows.Count - 1
            If poDt.Rows(intCont).Item("NORSCI").ToString.Trim = pstrEmb And poDt.Rows(intCont).Item("NDOCIN").ToString.Trim = "13" Then
                If poDt.Rows(intCont).Item("FECHA").ToString.Trim <> "0" Then
                    strFecha = Mid(poDt.Rows(intCont).Item("FECHA").ToString.Trim, 7, 2) & "/" & Mid(poDt.Rows(intCont).Item("FECHA").ToString.Trim, 5, 2) & "/" & Mid(poDt.Rows(intCont).Item("FECHA").ToString.Trim, 1, 4)
                    Return strFecha
                Else
                    Exit For
                End If
            End If
        Next intCont

        Return strFecha
    End Function

    Private Function Fecha_Doc_Embarque(ByVal pstrEmb As String, ByVal poDt As DataTable) As String
        Dim intCont As Integer
        Dim strFecha As String = "---"

        For intCont = 0 To poDt.Rows.Count - 1
            If poDt.Rows(intCont).Item("NORSCI").ToString.Trim = pstrEmb And (poDt.Rows(intCont).Item("NDOCIN").ToString.Trim = "4" Or _
              poDt.Rows(intCont).Item("NDOCIN").ToString.Trim = "5" Or poDt.Rows(intCont).Item("NDOCIN").ToString.Trim = "15") Then
                If poDt.Rows(intCont).Item("FECHA").ToString.Trim <> "0" Then
                    strFecha = Mid(poDt.Rows(intCont).Item("FECHA").ToString.Trim, 7, 2) & "/" & Mid(poDt.Rows(intCont).Item("FECHA").ToString.Trim, 5, 2) & "/" & Mid(poDt.Rows(intCont).Item("FECHA").ToString.Trim, 1, 4)
                    Return strFecha
                Else
                    Exit For
                End If
            End If
        Next intCont

        Return strFecha
    End Function

    Private Function Fecha_Factura(ByVal pstrEmb As String, ByVal poDt As DataTable) As String
        Dim intCont As Integer
        Dim strFecha As String = "---"

        For intCont = 0 To poDt.Rows.Count - 1
            If poDt.Rows(intCont).Item("NORSCI").ToString.Trim = pstrEmb And poDt.Rows(intCont).Item("NDOCIN").ToString.Trim = "2" Then
                If poDt.Rows(intCont).Item("FECHA").ToString.Trim <> "0" Then
                    strFecha = Mid(poDt.Rows(intCont).Item("FECHA").ToString.Trim, 7, 2) & "/" & Mid(poDt.Rows(intCont).Item("FECHA").ToString.Trim, 5, 2) & "/" & Mid(poDt.Rows(intCont).Item("FECHA").ToString.Trim, 1, 4)
                    Return strFecha
                Else
                    Exit For
                End If
            End If
        Next intCont

        Return strFecha
    End Function

    Public Function dtRepMonthlyNavieras(ByVal PSCCMPN As String, ByVal pdblCodCli As Double, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double, ByVal PSLISTAREGIMEN As String, ByVal PSTPSRVA As String, ByVal PNNESTDO As Decimal, ByVal PSESTADO_EMB As String) As DataTable
        Dim oDt As DataTable
        Dim intCont As Integer = 0
        Dim intPos As Integer
        Dim oDr As DataRow
        Formato_Naviera()
        oDt = oReporte.dtRepMonthlyNavieras(PSCCMPN, pdblCodCli, pdblFecIni, pdblFecFin, PSLISTAREGIMEN, PSTPSRVA, PNNESTDO, PSESTADO_EMB)
        For intCont = 0 To oDt.Rows.Count - 1
            intPos = 0
            If intCont = 0 Then
                oDr = oDtNaviera.NewRow
                oDr.Item("CONT20") = 0
                oDr.Item("CONT40") = 0
                oDr.Item("TNMCIN") = oDt.Rows(intCont).Item("TNMCIN").ToString.Trim
                Select Case oDt.Rows(intCont).Item("NCODRG").ToString.Trim
                    Case "2", "4", "6", "9"
                        oDr.Item("CONT20") = Double.Parse(oDr.Item("CONT20").ToString) + Double.Parse(oDt.Rows(intCont).Item("QCANTI").ToString.Trim)
                    Case "3", "5", "7", "8", "10"
                        oDr.Item("CONT40") = Double.Parse(oDr.Item("CONT40").ToString) + Double.Parse(oDt.Rows(intCont).Item("QCANTI").ToString.Trim)
                End Select
                oDtNaviera.Rows.Add(oDr)
            Else
                If Not Existe_Nave(oDtNaviera, oDt.Rows(intCont).Item("TNMCIN"), intPos) Then
                    oDr = oDtNaviera.NewRow
                    oDr.Item("CONT20") = 0
                    oDr.Item("CONT40") = 0
                    oDr.Item("TNMCIN") = oDt.Rows(intCont).Item("TNMCIN").ToString.Trim
                    Select Case oDt.Rows(intCont).Item("NCODRG").ToString.Trim
                        Case "2", "4", "6", "9"
                            oDr.Item("CONT20") = Double.Parse(oDr.Item("CONT20").ToString) + Double.Parse(oDt.Rows(intCont).Item("QCANTI").ToString.Trim)
                        Case "3", "5", "7", "8", "10"
                            oDr.Item("CONT40") = Double.Parse(oDr.Item("CONT40").ToString) + Double.Parse(oDt.Rows(intCont).Item("QCANTI").ToString.Trim)
                    End Select
                    oDtNaviera.Rows.Add(oDr)
                Else
                    Select Case oDt.Rows(intCont).Item("NCODRG").ToString.Trim
                        Case "2", "4", "6", "9"
                            oDtNaviera.Rows(intPos).Item("CONT20") = Double.Parse(oDtNaviera.Rows(intPos).Item("CONT20").ToString) + Double.Parse(oDt.Rows(intCont).Item("QCANTI").ToString.Trim)
                        Case "3", "5", "7", "8", "10"
                            oDtNaviera.Rows(intPos).Item("CONT40") = Double.Parse(oDtNaviera.Rows(intPos).Item("CONT40").ToString) + Double.Parse(oDt.Rows(intCont).Item("QCANTI").ToString.Trim)
                    End Select
                End If
            End If
        Next intCont

        Return oDtNaviera
    End Function


    Public Function dtRepMonthlyNavierasUnificado(ByVal dtNaviera As DataTable) As DataTable
        Dim oDt As DataTable
        Dim intCont As Integer = 0
        Dim intPos As Integer
        Dim oDr As DataRow
        Formato_Naviera()
        'oDt = oReporte.dtRepMonthlyNavieras(PSCCMPN, pdblCodCli, pdblFecIni, pdblFecFin, PSLISTAREGIMEN, PSTPSRVA, PNNESTDO, PSESTADO_EMB)
        oDt = dtNaviera.Copy
        For intCont = 0 To oDt.Rows.Count - 1
            intPos = 0
            If intCont = 0 Then
                oDr = oDtNaviera.NewRow
                oDr.Item("CONT20") = 0
                oDr.Item("CONT40") = 0
                oDr.Item("TNMCIN") = oDt.Rows(intCont).Item("TNMCIN").ToString.Trim
                Select Case oDt.Rows(intCont).Item("NCODRG").ToString.Trim
                    Case "2", "4", "6", "9"
                        oDr.Item("CONT20") = Double.Parse(oDr.Item("CONT20").ToString) + Double.Parse(oDt.Rows(intCont).Item("QCANTI").ToString.Trim)
                    Case "3", "5", "7", "8", "10"
                        oDr.Item("CONT40") = Double.Parse(oDr.Item("CONT40").ToString) + Double.Parse(oDt.Rows(intCont).Item("QCANTI").ToString.Trim)
                End Select
                oDtNaviera.Rows.Add(oDr)
            Else
                If Not Existe_Nave(oDtNaviera, oDt.Rows(intCont).Item("TNMCIN"), intPos) Then
                    oDr = oDtNaviera.NewRow
                    oDr.Item("CONT20") = 0
                    oDr.Item("CONT40") = 0
                    oDr.Item("TNMCIN") = oDt.Rows(intCont).Item("TNMCIN").ToString.Trim
                    Select Case oDt.Rows(intCont).Item("NCODRG").ToString.Trim
                        Case "2", "4", "6", "9"
                            oDr.Item("CONT20") = Double.Parse(oDr.Item("CONT20").ToString) + Double.Parse(oDt.Rows(intCont).Item("QCANTI").ToString.Trim)
                        Case "3", "5", "7", "8", "10"
                            oDr.Item("CONT40") = Double.Parse(oDr.Item("CONT40").ToString) + Double.Parse(oDt.Rows(intCont).Item("QCANTI").ToString.Trim)
                    End Select
                    oDtNaviera.Rows.Add(oDr)
                Else
                    Select Case oDt.Rows(intCont).Item("NCODRG").ToString.Trim
                        Case "2", "4", "6", "9"
                            oDtNaviera.Rows(intPos).Item("CONT20") = Double.Parse(oDtNaviera.Rows(intPos).Item("CONT20").ToString) + Double.Parse(oDt.Rows(intCont).Item("QCANTI").ToString.Trim)
                        Case "3", "5", "7", "8", "10"
                            oDtNaviera.Rows(intPos).Item("CONT40") = Double.Parse(oDtNaviera.Rows(intPos).Item("CONT40").ToString) + Double.Parse(oDt.Rows(intCont).Item("QCANTI").ToString.Trim)
                    End Select
                End If
            End If
        Next intCont

        Return oDtNaviera
    End Function

    Public Function Existe_Nave(ByVal poDt As DataTable, ByVal pstrNave As String, ByRef pintPos As Integer) As Boolean
        Dim intCont As Integer

        For intCont = 0 To poDt.Rows.Count - 1
            If poDt.Rows(intCont).Item("TNMCIN").ToString.Trim = pstrNave.Trim Then
                pintPos = intCont
                Return True
            End If
        Next intCont

        Return False
    End Function

    Public Sub RepMonthlyTiempoAduanas(ByVal PSCCMPN As String, ByVal pdblCodCli As Double, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double, ByVal PSLISTAREGIMEN As String, ByVal PSTPSRVA As String, ByVal PNNESTDO As Decimal, ByVal PSESTADO_EMB As String)
        Dim oDt As DataTable
        Dim oDr() As DataRow
        Dim lobjDrList() As DataRow
        Dim intCont As Integer
        Dim intDias As Integer
        Dim strFecFin As String
        Dim strFecIni As String

        oDt = oReporte.dtRepMonthlyTiempoAduanas(PSCCMPN, pdblCodCli, pdblFecIni, pdblFecFin, PSLISTAREGIMEN, PSTPSRVA, PNNESTDO, PSESTADO_EMB)
        dblPromNor = 0
        dblPromAnt = 0
        oDr = oDt.Select("NCODRG = 1")
        For intCont = 0 To oDr.Length - 1
            strFecFin = oDr(intCont).Item("ALMCLI").ToString.Trim
            strFecIni = oDr(intCont).Item("DOCCOM").ToString.Trim
            If strFecIni <> "" And strFecFin <> "" Then
                lobjDrList = oDtNoLab.Select("FFRDO >= " & Format(CType(strFecIni, Date), "yyyyMMdd") & " AND FFRDO <= " & Format(CType(strFecFin, Date), "yyyyMMdd"))
                intDias = fintDiferencia_Dia(strFecFin, strFecIni, lobjDrList.Length)
                dblPromNor = dblPromNor + intDias
            End If
        Next intCont
        If oDr.Length > 0 Then
            dblPromNor = dblPromAnt / oDr.Length
        Else
            dblPromNor = 0
        End If

        oDr = oDt.Select("NCODRG <> 1")
        For intCont = 0 To oDr.Length - 1
            strFecFin = oDr(intCont).Item("ALMCLI").ToString.Trim
            strFecIni = oDr(intCont).Item("FAPRAR").ToString.Trim
            If strFecIni <> "" And strFecFin <> "" Then
                lobjDrList = oDtNoLab.Select("FFRDO >= " & Format(CType(strFecIni, Date), "yyyyMMdd") & " AND FFRDO <= " & Format(CType(strFecFin, Date), "yyyyMMdd"))
                intDias = fintDiferencia_Dia(strFecFin, strFecIni, lobjDrList.Length)
                dblPromAnt = dblPromAnt + intDias
            End If
        Next intCont
        If oDr.Length > 0 Then
            dblPromAnt = dblPromAnt / oDr.Length
        Else
            dblPromAnt = 0
        End If

    End Sub

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

    Public Sub RepMonthlyTiempoAduanasUnificado(ByVal dtTiempoAduana As DataTable, ByVal dtOrdenCompra As DataTable, ByVal dtCheckPoint As DataTable)
        Dim oDt As DataTable
        Dim oDr() As DataRow
        Dim lobjDrList() As DataRow
        Dim intCont As Integer
        Dim intDias As Integer
        Dim strFecFin As String
        Dim strFecIni As String
       
        oDt = dtTiempoAduana.Copy
        oDt.Columns.Add("DOCCOM")
        oDt.Columns.Add("ALMCLI")

        For Each Item As DataRow In oDt.Rows
            Item("FAPRAR") = HelpClass.FechaNum_a_Fecha(Item("FAPRAR"))
            Item("DOCCOM") = BuscarCheckPointAduana(dtCheckPoint, Item("NORSCI"), EnumCheckPoint.Documentos)
            Item("ALMCLI") = BuscarCheckPointAduana(dtCheckPoint, Item("NORSCI"), EnumCheckPoint.Entrega_Almacen)
        Next

        dblPromNor = 0
        dblPromAnt = 0
        oDr = oDt.Select("NCODRG = 1")
        For intCont = 0 To oDr.Length - 1


            strFecFin = oDr(intCont).Item("ALMCLI").ToString.Trim
            strFecIni = oDr(intCont).Item("DOCCOM").ToString.Trim
            If strFecIni <> "" And strFecFin <> "" Then
                lobjDrList = oDtNoLab.Select("FFRDO >= " & Format(CType(strFecIni, Date), "yyyyMMdd") & " AND FFRDO <= " & Format(CType(strFecFin, Date), "yyyyMMdd"))
                intDias = fintDiferencia_Dia(strFecFin, strFecIni, lobjDrList.Length)
                dblPromNor = dblPromNor + intDias
            End If
        Next intCont
        If oDr.Length > 0 Then
            dblPromNor = dblPromAnt / oDr.Length
        Else
            dblPromNor = 0
        End If

        oDr = oDt.Select("NCODRG <> 1")
        For intCont = 0 To oDr.Length - 1
            strFecFin = oDr(intCont).Item("ALMCLI").ToString.Trim
            strFecIni = oDr(intCont).Item("FAPRAR").ToString.Trim
            If strFecIni <> "" And strFecFin <> "" Then
                lobjDrList = oDtNoLab.Select("FFRDO >= " & Format(CType(strFecIni, Date), "yyyyMMdd") & " AND FFRDO <= " & Format(CType(strFecFin, Date), "yyyyMMdd"))
                intDias = fintDiferencia_Dia(strFecFin, strFecIni, lobjDrList.Length)
                dblPromAnt = dblPromAnt + intDias
            End If
        Next intCont
        If oDr.Length > 0 Then
            dblPromAnt = dblPromAnt / oDr.Length
        Else
            dblPromAnt = 0
        End If

    End Sub

    Public Function dtRepMonthlyDetalleDebito_Costo_Operativo(ByVal pdblOS As Double, ByVal pstrZona As String, ByVal pstrTipoImp As String, ByVal pdblPlanta As Double) As DataTable
        Dim odt As New DataTable
        odt = oReporte.dtRepMonthlyDetalleDebito_Costo_Operativo(pdblOS, pstrZona, pstrTipoImp, pdblPlanta)
        Return odt
    End Function


End Class
