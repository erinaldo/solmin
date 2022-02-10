Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsRep3PL
    Private oReporte As Datos.clsRep3PL
    Private oDt As DataTable
    Private oDt_Origen As DataTable
    Private oDt_Aduanas As DataTable
    Private oDt_POMes As DataTable
    Private dblOCMaritimo As Double
    Private dblOCAereo As Double
    Private dblOCTerrestre As Double
    Private dblFleteMaritimo As Double
    Private dblFleteAereo As Double
    Private dblFleteTerrestre As Double
    Private dblPesoMaritimo As Double
    Private dblPesoAereo As Double
    Private dblPesoTerrestre As Double
    Private dblAduanasMaritimo As Double
    Private dblAduanasAereo As Double
    Private dblAduanasTerrestre As Double
    Private dblOperacionesMaritimo As Double
    Private dblOperacionesAereo As Double
    Private dblOperacionesTerrestre As Double
    Private strMenError As String
    Private dblTotalOC As Double
    Private dblTotalFlete As Double
    Private dblTotalPeso As Double
    Private dblRed As Double
    Private dblOrange As Double
    Private dblGreen As Double
    Private dblUrgent As Double
    Private dblAnticipated As Double
    Private dblNormal As Double
    Private oDt_General As DataTable

    Sub New()
        oReporte = New Datos.clsRep3PL
        oDt = New DataTable
        oDt_POMes = New DataTable
        oDt_General = New DataTable
    End Sub

    Property Datos_Anual()
        Get
            Return oDt
        End Get
        Set(ByVal value)
            oDt = value
        End Set
    End Property

    Property Normal()
        Get
            Return dblNormal
        End Get
        Set(ByVal value)
            dblNormal = value
        End Set
    End Property

    Property Anticipated()
        Get
            Return dblAnticipated
        End Get
        Set(ByVal value)
            dblAnticipated = value
        End Set
    End Property

    Property Urgent()
        Get
            Return dblUrgent
        End Get
        Set(ByVal value)
            dblUrgent = value
        End Set
    End Property

    Property Green()
        Get
            Return dblGreen
        End Get
        Set(ByVal value)
            dblGreen = value
        End Set
    End Property

    Property Orange()
        Get
            Return dblOrange
        End Get
        Set(ByVal value)
            dblOrange = value
        End Set
    End Property

    Property Red()
        Get
            Return dblRed
        End Get
        Set(ByVal value)
            dblRed = value
        End Set
    End Property

    Property TotalPeso()
        Get
            Return dblTotalPeso
        End Get
        Set(ByVal value)
            dblTotalPeso = value
        End Set
    End Property

    Property TotalFlete()
        Get
            Return dblTotalFlete
        End Get
        Set(ByVal value)
            dblTotalFlete = value
        End Set
    End Property

    Property TotalOC()
        Get
            Return dblTotalOC
        End Get
        Set(ByVal value)
            dblTotalOC = value
        End Set
    End Property

    Property Mensaje()
        Get
            Return strMenError
        End Get
        Set(ByVal value)
            strMenError = value
        End Set
    End Property

    Property Aduanas()
        Get
            Return oDt_Aduanas
        End Get
        Set(ByVal value)
            oDt_Aduanas = value
        End Set
    End Property

    Property AduanasGeneral()
        Get
            Return oDt_General
        End Get
        Set(ByVal value)
            oDt_General = value
        End Set
    End Property

#Region "Crear Formato"

    Private Sub Formato_Ordenes_Mes()
        oDt_POMes.Columns.Add(New DataColumn("TIPO", GetType(System.String)))
        oDt_POMes.Columns.Add(New DataColumn("NUMOC", GetType(System.Int32)))
    End Sub

    Private Sub Formato_Aduanas_General()
        oDt_General.Columns.Add(New DataColumn("CIFANHO", GetType(System.Double)))
        oDt_General.Columns.Add(New DataColumn("CIFMES", GetType(System.Double)))
        oDt_General.Columns.Add(New DataColumn("OCANHO", GetType(System.Double)))
        oDt_General.Columns.Add(New DataColumn("OCMES", GetType(System.Double)))
    End Sub

    Private Sub Formato_Consolidado_Aduanas(ByRef pobjDt As DataTable, ByVal pdblAno As Double)
        Dim objDr As DataRow

        pobjDt = New DataTable
        pobjDt.Columns.Add(New DataColumn("MES", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("NUMDIA", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("OPERACION", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("TOTALDIA", GetType(System.Int32)))

        objDr = pobjDt.NewRow
        objDr.Item("MES") = "Ene-" & Mid(pdblAno, 3, 2)
        objDr.Item("NUMDIA") = 0
        objDr.Item("OPERACION") = 0
        objDr.Item("TOTALDIA") = 0
        pobjDt.Rows.Add(objDr)

        objDr = pobjDt.NewRow
        objDr.Item("MES") = "Feb-" & Mid(pdblAno, 3, 2)
        objDr.Item("NUMDIA") = 0
        objDr.Item("OPERACION") = 0
        objDr.Item("TOTALDIA") = 0
        pobjDt.Rows.Add(objDr)

        objDr = pobjDt.NewRow
        objDr.Item("MES") = "Mar-" & Mid(pdblAno, 3, 2)
        objDr.Item("NUMDIA") = 0
        objDr.Item("OPERACION") = 0
        objDr.Item("TOTALDIA") = 0
        pobjDt.Rows.Add(objDr)

        objDr = pobjDt.NewRow
        objDr.Item("MES") = "Abr-" & Mid(pdblAno, 3, 2)
        objDr.Item("NUMDIA") = 0
        objDr.Item("OPERACION") = 0
        objDr.Item("TOTALDIA") = 0
        pobjDt.Rows.Add(objDr)

        objDr = pobjDt.NewRow
        objDr.Item("MES") = "May-" & Mid(pdblAno, 3, 2)
        objDr.Item("NUMDIA") = 0
        objDr.Item("OPERACION") = 0
        objDr.Item("TOTALDIA") = 0
        pobjDt.Rows.Add(objDr)

        objDr = pobjDt.NewRow
        objDr.Item("MES") = "Jun-" & Mid(pdblAno, 3, 2)
        objDr.Item("NUMDIA") = 0
        objDr.Item("OPERACION") = 0
        objDr.Item("TOTALDIA") = 0
        pobjDt.Rows.Add(objDr)

        objDr = pobjDt.NewRow
        objDr.Item("MES") = "Jul-" & Mid(pdblAno, 3, 2)
        objDr.Item("NUMDIA") = 0
        objDr.Item("OPERACION") = 0
        objDr.Item("TOTALDIA") = 0
        pobjDt.Rows.Add(objDr)

        objDr = pobjDt.NewRow
        objDr.Item("MES") = "Ago-" & Mid(pdblAno, 3, 2)
        objDr.Item("NUMDIA") = 0
        objDr.Item("OPERACION") = 0
        objDr.Item("TOTALDIA") = 0
        pobjDt.Rows.Add(objDr)

        objDr = pobjDt.NewRow
        objDr.Item("MES") = "Sep-" & Mid(pdblAno, 3, 2)
        objDr.Item("NUMDIA") = 0
        objDr.Item("OPERACION") = 0
        objDr.Item("TOTALDIA") = 0
        pobjDt.Rows.Add(objDr)

        objDr = pobjDt.NewRow
        objDr.Item("MES") = "Oct-" & Mid(pdblAno, 3, 2)
        objDr.Item("NUMDIA") = 0
        objDr.Item("OPERACION") = 0
        objDr.Item("TOTALDIA") = 0
        pobjDt.Rows.Add(objDr)

        objDr = pobjDt.NewRow
        objDr.Item("MES") = "Nov-" & Mid(pdblAno, 3, 2)
        objDr.Item("NUMDIA") = 0
        objDr.Item("OPERACION") = 0
        objDr.Item("TOTALDIA") = 0
        pobjDt.Rows.Add(objDr)

        objDr = pobjDt.NewRow
        objDr.Item("MES") = "Dic-" & Mid(pdblAno, 3, 2)
        objDr.Item("NUMDIA") = 0
        objDr.Item("OPERACION") = 0
        objDr.Item("TOTALDIA") = 0
        pobjDt.Rows.Add(objDr)

    End Sub

    Private Sub Formato_Ordenes_X_Origen(ByRef pobjDt As DataTable)
        pobjDt = New DataTable
        pobjDt.Columns.Add(New DataColumn("NUMOCA", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("NUMOCO", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("NUMOCT", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("PESOA", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("PESOO", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("PESOT", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("ORIGEN", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("TOTOCORI", GetType(System.Double)))
    End Sub

    Private Sub Formato_Consolidado_Mensual(ByRef pobjDt As DataTable, ByVal pdblAno As Double)
        Dim objDr As DataRow

        pobjDt = New DataTable
        pobjDt.Columns.Add(New DataColumn("MES", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("NUMOCA", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("FLETEA", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("PESOA", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("NUMOCO", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("FLETEO", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("PESOO", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("NUMOCT", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("FLETET", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("PESOT", GetType(System.Double)))
        'pobjDt.Columns.Add(New DataColumn("TTOC", GetType(System.Int32)))
        'pobjDt.Columns.Add(New DataColumn("TTFLETE", GetType(System.Double)))
        'pobjDt.Columns.Add(New DataColumn("TTPESO", GetType(System.Double)))

        objDr = pobjDt.NewRow
        objDr.Item("MES") = "Ene-" & Mid(pdblAno, 3, 2)
        objDr.Item("NUMOCA") = 0
        objDr.Item("FLETEA") = 0
        objDr.Item("PESOA") = 0
        objDr.Item("NUMOCO") = 0
        objDr.Item("FLETEO") = 0
        objDr.Item("PESOO") = 0
        objDr.Item("NUMOCT") = 0
        objDr.Item("FLETET") = 0
        objDr.Item("PESOT") = 0
        pobjDt.Rows.Add(objDr)

        objDr = pobjDt.NewRow
        objDr.Item("MES") = "Feb-" & Mid(pdblAno, 3, 2)
        objDr.Item("NUMOCA") = 0
        objDr.Item("FLETEA") = 0
        objDr.Item("PESOA") = 0
        objDr.Item("NUMOCO") = 0
        objDr.Item("FLETEO") = 0
        objDr.Item("PESOO") = 0
        objDr.Item("NUMOCT") = 0
        objDr.Item("FLETET") = 0
        objDr.Item("PESOT") = 0
        pobjDt.Rows.Add(objDr)

        objDr = pobjDt.NewRow
        objDr.Item("MES") = "Mar-" & Mid(pdblAno, 3, 2)
        objDr.Item("NUMOCA") = 0
        objDr.Item("FLETEA") = 0
        objDr.Item("PESOA") = 0
        objDr.Item("NUMOCO") = 0
        objDr.Item("FLETEO") = 0
        objDr.Item("PESOO") = 0
        objDr.Item("NUMOCT") = 0
        objDr.Item("FLETET") = 0
        objDr.Item("PESOT") = 0
        pobjDt.Rows.Add(objDr)

        objDr = pobjDt.NewRow
        objDr.Item("MES") = "Abr-" & Mid(pdblAno, 3, 2)
        objDr.Item("NUMOCA") = 0
        objDr.Item("FLETEA") = 0
        objDr.Item("PESOA") = 0
        objDr.Item("NUMOCO") = 0
        objDr.Item("FLETEO") = 0
        objDr.Item("PESOO") = 0
        objDr.Item("NUMOCT") = 0
        objDr.Item("FLETET") = 0
        objDr.Item("PESOT") = 0
        pobjDt.Rows.Add(objDr)

        objDr = pobjDt.NewRow
        objDr.Item("MES") = "May-" & Mid(pdblAno, 3, 2)
        objDr.Item("NUMOCA") = 0
        objDr.Item("FLETEA") = 0
        objDr.Item("PESOA") = 0
        objDr.Item("NUMOCO") = 0
        objDr.Item("FLETEO") = 0
        objDr.Item("PESOO") = 0
        objDr.Item("NUMOCT") = 0
        objDr.Item("FLETET") = 0
        objDr.Item("PESOT") = 0
        pobjDt.Rows.Add(objDr)

        objDr = pobjDt.NewRow
        objDr.Item("MES") = "Jun-" & Mid(pdblAno, 3, 2)
        objDr.Item("NUMOCA") = 0
        objDr.Item("FLETEA") = 0
        objDr.Item("PESOA") = 0
        objDr.Item("NUMOCO") = 0
        objDr.Item("FLETEO") = 0
        objDr.Item("PESOO") = 0
        objDr.Item("NUMOCT") = 0
        objDr.Item("FLETET") = 0
        objDr.Item("PESOT") = 0
        pobjDt.Rows.Add(objDr)

        objDr = pobjDt.NewRow
        objDr.Item("MES") = "Jul-" & Mid(pdblAno, 3, 2)
        objDr.Item("NUMOCA") = 0
        objDr.Item("FLETEA") = 0
        objDr.Item("PESOA") = 0
        objDr.Item("NUMOCO") = 0
        objDr.Item("FLETEO") = 0
        objDr.Item("PESOO") = 0
        objDr.Item("NUMOCT") = 0
        objDr.Item("FLETET") = 0
        objDr.Item("PESOT") = 0
        pobjDt.Rows.Add(objDr)

        objDr = pobjDt.NewRow
        objDr.Item("MES") = "Ago-" & Mid(pdblAno, 3, 2)
        objDr.Item("NUMOCA") = 0
        objDr.Item("FLETEA") = 0
        objDr.Item("PESOA") = 0
        objDr.Item("NUMOCO") = 0
        objDr.Item("FLETEO") = 0
        objDr.Item("PESOO") = 0
        objDr.Item("NUMOCT") = 0
        objDr.Item("FLETET") = 0
        objDr.Item("PESOT") = 0
        pobjDt.Rows.Add(objDr)

        objDr = pobjDt.NewRow
        objDr.Item("MES") = "Sep-" & Mid(pdblAno, 3, 2)
        objDr.Item("NUMOCA") = 0
        objDr.Item("FLETEA") = 0
        objDr.Item("PESOA") = 0
        objDr.Item("NUMOCO") = 0
        objDr.Item("FLETEO") = 0
        objDr.Item("PESOO") = 0
        objDr.Item("NUMOCT") = 0
        objDr.Item("FLETET") = 0
        objDr.Item("PESOT") = 0
        pobjDt.Rows.Add(objDr)

        objDr = pobjDt.NewRow
        objDr.Item("MES") = "Oct-" & Mid(pdblAno, 3, 2)
        objDr.Item("NUMOCA") = 0
        objDr.Item("FLETEA") = 0
        objDr.Item("PESOA") = 0
        objDr.Item("NUMOCO") = 0
        objDr.Item("FLETEO") = 0
        objDr.Item("PESOO") = 0
        objDr.Item("NUMOCT") = 0
        objDr.Item("FLETET") = 0
        objDr.Item("PESOT") = 0
        pobjDt.Rows.Add(objDr)

        objDr = pobjDt.NewRow
        objDr.Item("MES") = "Nov-" & Mid(pdblAno, 3, 2)
        objDr.Item("NUMOCA") = 0
        objDr.Item("FLETEA") = 0
        objDr.Item("PESOA") = 0
        objDr.Item("NUMOCO") = 0
        objDr.Item("FLETEO") = 0
        objDr.Item("PESOO") = 0
        objDr.Item("NUMOCT") = 0
        objDr.Item("FLETET") = 0
        objDr.Item("PESOT") = 0
        pobjDt.Rows.Add(objDr)

        objDr = pobjDt.NewRow
        objDr.Item("MES") = "Dic-" & Mid(pdblAno, 3, 2)
        objDr.Item("NUMOCA") = 0
        objDr.Item("FLETEA") = 0
        objDr.Item("PESOA") = 0
        objDr.Item("NUMOCO") = 0
        objDr.Item("FLETEO") = 0
        objDr.Item("PESOO") = 0
        objDr.Item("NUMOCT") = 0
        objDr.Item("FLETET") = 0
        objDr.Item("PESOT") = 0
        pobjDt.Rows.Add(objDr)

    End Sub

#End Region

    'CCMPN 
    'CDVSN 
    'CCLNT 
    'ANOALF
    'MESALF
    'CMEDTR
    'NUMOCO
    'TTLOPR
    'IVLFLT
    'QPSOAR
    'TTLDIA

    'Public Function ConsolidarRegistros(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal pdblCliente As Double, ByVal FecIni As Date, ByVal FecFin As Date, ByRef Result As Boolean) As DataTable
    '    Dim dtDatosConsolidado As New DataTable
    '    Dim Resultado As Boolean = False

    '    Dim DtMonto As DataTable
    '    Dim DtOCompra As DataTable
    '    Dim DtNoLaborable As DataTable
    '    Dim DtOperaciones As DataTable
    '    Dim intCont As Integer
    '    Dim lstrETA As String
    '    Dim lstrAlmacen As String
    '    Dim lobjDrList As DataRow()
    '    Dim lintDias As Integer

    '    Dim EsFecha As Date
    '    Dim DifDias As Int32 = 0

    '    dtDatosConsolidado.Columns.Add("CCMPN", Type.GetType("System.String"))
    '    dtDatosConsolidado.Columns.Add("CDVSN", Type.GetType("System.String"))
    '    dtDatosConsolidado.Columns.Add("CCLNT", Type.GetType("System.Decimal"))
    '    dtDatosConsolidado.Columns.Add("ANOALF", Type.GetType("System.Decimal"))
    '    dtDatosConsolidado.Columns.Add("MESALF", Type.GetType("System.Decimal"))
    '    dtDatosConsolidado.Columns.Add("CMEDTR", Type.GetType("System.Decimal"))
    '    dtDatosConsolidado.Columns.Add("NUMOCO", Type.GetType("System.Decimal"))
    '    dtDatosConsolidado.Columns.Add("TTLOPR", Type.GetType("System.Decimal"))
    '    dtDatosConsolidado.Columns.Add("IVLFLT", Type.GetType("System.Decimal"))
    '    dtDatosConsolidado.Columns.Add("QPSOAR", Type.GetType("System.Decimal"))
    '    dtDatosConsolidado.Columns.Add("TTLDIA", Type.GetType("System.Decimal"))

    '    Dim pdblFecIni As Double = 0
    '    Dim pdblFecFin As Double = 0

    '    Dim MesUltimo As Int32 = FecFin.Month
    '    Dim FechaTemp As Date
    '    For Mes As Integer = 1 To MesUltimo
    '        FechaTemp = CType("01" & "/" & Format(Mes, "00") & "/" & FecIni.Year, Date)
    '        pdblFecIni = Format(FechaTemp, "yyyyMMdd")
    '        pdblFecFin = Format(CType("01" & "/" & Format(FechaTemp.AddMonths(1).Month, "00") & "/" & FechaTemp.AddMonths(1).Year, Date).AddDays(-1), "yyyyMMdd")

    '        DtMonto = oReporte.dtRep3PLMontosMensuales(PSCCMPN, pdblCliente, pdblFecIni, pdblFecFin)
    '        DtOCompra = oReporte.dtRep3PLOrdenesMensuales(PSCCMPN, pdblCliente, pdblFecIni, pdblFecFin)
    '        DtNoLaborable = oReporte.dtNoLaborables(20080101, pdblFecFin)
    '        DtOperaciones = oReporte.dtRep3PLOperacionMensual(PSCCMPN, pdblCliente, pdblFecIni, pdblFecFin)

    '        If Validar(DtMonto) = True Then
    '            dblAduanasMaritimo = 0
    '            dblAduanasAereo = 0
    '            dblAduanasTerrestre = 0
    '            dblOperacionesMaritimo = 0
    '            dblOperacionesAereo = 0
    '            dblOperacionesTerrestre = 0

    '            For intCont = 0 To DtMonto.Rows.Count - 1
    '                Select Case DtMonto.Rows(intCont).Item("CMEDTR")
    '                    Case 1
    '                        dblFleteAereo = dblFleteAereo + Double.Parse(DtMonto.Rows(intCont).Item("IVLFLT"))
    '                        dblPesoAereo = dblPesoAereo + Double.Parse(DtMonto.Rows(intCont).Item("QPSOAR"))
    '                    Case 2
    '                        dblFleteMaritimo = dblFleteMaritimo + Double.Parse(DtMonto.Rows(intCont).Item("IVLFLT"))
    '                        dblPesoMaritimo = dblPesoMaritimo + Double.Parse(DtMonto.Rows(intCont).Item("QPSOAR"))
    '                    Case 4
    '                        dblFleteTerrestre = dblFleteTerrestre + Double.Parse(DtMonto.Rows(intCont).Item("IVLFLT"))
    '                        dblPesoTerrestre = dblPesoTerrestre + Double.Parse(DtMonto.Rows(intCont).Item("QPSOAR"))
    '                End Select
    '            Next intCont
    '            For intCont = 0 To DtOCompra.Rows.Count - 1
    '                Select Case DtOCompra.Rows(intCont).Item("CMEDTR")
    '                    Case 1
    '                        dblOCAereo = dblOCAereo + Double.Parse(DtOCompra.Rows(intCont).Item("CANT"))
    '                    Case 2
    '                        dblOCMaritimo = dblOCMaritimo + Double.Parse(DtOCompra.Rows(intCont).Item("CANT"))
    '                    Case 4
    '                        dblOCTerrestre = dblOCTerrestre + Double.Parse(DtOCompra.Rows(intCont).Item("CANT"))
    '                End Select
    '            Next intCont
    '            dblPesoAereo = dblPesoAereo / 1000 'Toneladas
    '            dblPesoMaritimo = dblPesoMaritimo / 1000 'Toneladas
    '            dblPesoTerrestre = dblPesoTerrestre / 1000 'Toneladas


    '            For intCont = 0 To DtOperaciones.Rows.Count - 1
    '                lstrETA = ("" & DtOperaciones.Rows(intCont).Item("FAPRAR")).ToString.Trim
    '                lstrAlmacen = ("" & DtOperaciones.Rows(intCont).Item("ALMCLI")).ToString.Trim

    '                If Date.TryParse(lstrETA, EsFecha) AndAlso Date.TryParse(lstrAlmacen, EsFecha) Then
    '                    If lstrETA = lstrAlmacen Then
    '                        DifDias = 0
    '                    Else
    '                        lobjDrList = DtNoLaborable.Select("FFRDO >= " & Format(CType(lstrETA, Date), "yyyyMMdd") & " AND FFRDO <= " & Format(CType(lstrAlmacen, Date), "yyyyMMdd"))
    '                        DifDias = lobjDrList.Length
    '                    End If
    '                    lintDias = fintDiferencia_Dia(lstrAlmacen, lstrETA, DifDias)
    '                End If

    '                If DtOperaciones.Rows(intCont).Item("CMEDTR").ToString.Trim = "1" Then
    '                    dblOperacionesAereo = dblOperacionesAereo + 1
    '                    dblAduanasAereo = dblAduanasAereo + lintDias
    '                Else
    '                    If DtOperaciones.Rows(intCont).Item("CMEDTR").ToString.Trim = "2" Then
    '                        dblOperacionesMaritimo = dblOperacionesMaritimo + 1
    '                        dblAduanasMaritimo = dblAduanasMaritimo + lintDias
    '                    Else
    '                        If DtOperaciones.Rows(intCont).Item("CMEDTR").ToString.Trim = "4" Then
    '                            dblOperacionesTerrestre = dblOperacionesTerrestre + 1
    '                            dblAduanasTerrestre = dblAduanasTerrestre + lintDias
    '                        End If
    '                    End If
    '                End If
    '            Next intCont

    '            InsertarResumen(dtDatosConsolidado, PSCCMPN, PSCDVSN, pdblCliente, Mid(pdblFecIni, 1, 4), Mid(pdblFecIni, 5, 2), 1, dblOCAereo, dblFleteAereo, dblPesoAereo, dblAduanasAereo, dblOperacionesAereo)
    '            InsertarResumen(dtDatosConsolidado, PSCCMPN, PSCDVSN, pdblCliente, Mid(pdblFecIni, 1, 4), Mid(pdblFecIni, 5, 2), 2, dblOCMaritimo, dblFleteMaritimo, dblPesoMaritimo, dblAduanasMaritimo, dblOperacionesMaritimo)
    '            InsertarResumen(dtDatosConsolidado, PSCCMPN, PSCDVSN, pdblCliente, Mid(pdblFecIni, 1, 4), Mid(pdblFecIni, 5, 2), 4, dblOCTerrestre, dblFleteTerrestre, dblPesoTerrestre, dblAduanasTerrestre, dblOperacionesTerrestre)

    '            Resultado = True
    '            ' Insertar_Información_Mensual(PSCCMPN, PSCDVSN, pdblCliente, Mid(pdblFecIni, 5, 2), Mid(pdblFecIni, 1, 4))
    '        Else
    '            Resultado = False
    '            Exit For
    '        End If
    '    Next
    '    Result = Resultado
    '    Return dtDatosConsolidado
    'End Function

    ' CCMPN , CDVSN , CCLNT , ANOALF , MESALF , CMEDTR , NUMOCO , IVLFLT , QPSOAR , TTLDIA , TTLOPR 

    Private Function InsertarResumen(ByVal dtConsolidado As DataTable, ByVal CCMPN As String, ByVal CDVSN As String, ByVal CCLNT As Decimal, ByVal ANOALF As Decimal, ByVal MES As Decimal, ByVal CMEDTR As Decimal, ByVal NUMOCO As Decimal, ByVal TTLOPR As String, ByVal IVLFLT As Decimal, ByVal QPSOAR As Decimal, ByVal TTLDIA As String) As DataTable
        Dim dr As DataRow
        dr = dtConsolidado.NewRow
        dr("CCMPN") = CCMPN
        dr("CDVSN") = CDVSN
        dr("CCLNT") = CCLNT
        dr("ANOALF") = ANOALF
        dr("CMEDTR") = CMEDTR
        dr("NUMOCO") = NUMOCO
        dr("TTLOPR") = TTLOPR
        dr("IVLFLT") = IVLFLT
        dr("QPSOAR") = QPSOAR
        dr("TTLDIA") = TTLDIA
        dtConsolidado.Rows.Add(dr)
        Return dtConsolidado
    End Function


    'dtDatosConsolidado.Columns.Add("CCMPN", Type.GetType("System.String"))
    'dtDatosConsolidado.Columns.Add("CDVSN", Type.GetType("System.String"))
    'dtDatosConsolidado.Columns.Add("CCLNT", Type.GetType("System.Decimal"))
    'dtDatosConsolidado.Columns.Add("ANOALF", Type.GetType("System.Decimal"))
    'dtDatosConsolidado.Columns.Add("MESALF", Type.GetType("System.Decimal"))
    'dtDatosConsolidado.Columns.Add("CMEDTR", Type.GetType("System.Decimal"))
    'dtDatosConsolidado.Columns.Add("NUMOCO", Type.GetType("System.Decimal"))
    'dtDatosConsolidado.Columns.Add("TTLOPR", Type.GetType("System.Decimal"))
    'dtDatosConsolidado.Columns.Add("IVLFLT", Type.GetType("System.Decimal"))
    'dtDatosConsolidado.Columns.Add("QPSOAR", Type.GetType("System.Decimal"))
    'dtDatosConsolidado.Columns.Add("TTLDIA", Type.GetType("System.Decimal"))


    Public Function Registrar_Datos_Mensuales(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal PNCCLNT As Double, ByVal PNFECINI As Double, ByVal PNFECFIN As Double, ByVal PSLISTAREGIMEN As String) As Boolean


        'dblFecIni = Format(CType("01" & "/" & Format(Me.dtpMesEnvio.Value.Month, "00") & "/" & Me.dtpMesEnvio.Value.Year, Date), "yyyyMMdd")
        'dblFecFin = Format(CType("01" & "/" & Format(Me.dtpMesEnvio.Value.AddMonths(1).Month, "00") & "/" & Me.dtpMesEnvio.Value.AddMonths(1).Year, Date).AddDays(-1), "yyyyMMdd")

        ''creacion de cons

        Dim DtMonto As DataTable
        Dim DtOCompra As DataTable
        Dim DtNoLaborable As DataTable
        Dim DtOperaciones As DataTable
        Dim intCont As Integer
        Dim lstrETA As String
        Dim lstrAlmacen As String
        Dim lobjDrList As DataRow()
        Dim lintDias As Integer

        Dim EsFecha As Date
        Dim DifDias As Int32 = 0

        Dim dsDatosEnvio As New DataSet




        'Public Function dtRep3PLDatosEnvio(ByVal PSCCMPN As String, ByVal PNCCLNT As Double, ByVal PNFECINI As Double, ByVal PNFECFIN As Double, ByVal PSLISTAREGIMEN As String) As DataSet
        '    Dim ds As New DataSet
        '    Dim lobjSql As New SqlManager
        '    Dim lobjParams As New Parameter
        '    lobjParams.Add("PSCCMPN", PSCCMPN)
        '    lobjParams.Add("PNCCLNT", PNCCLNT)
        '    lobjParams.Add("PNFECINI", PNFECINI)
        '    lobjParams.Add("PNFECFIN", PNFECFIN)
        '    lobjParams.Add("PSLISTAREGIMEN", PSLISTAREGIMEN)
        '    ds = lobjSql.ExecuteDataSet("SP_SOLSC_REP3PL_MONTOS", lobjParams)
        '    ds.Tables(0).TableName = "DTMONTOMENSUAL"
        '    ds.Tables(1).TableName = "DTORDENMENSUAL"
        '    ds.Tables(2).TableName = "DTFERIADO"
        '    ds.Tables(3).TableName = "DTOPERACIONMENSUAL"
        '    Return ds.Copy
        'End Function

        dsDatosEnvio = oReporte.dtRep3PLDatosEnvio(PSCCMPN, PNCCLNT, PNFECINI, PNFECFIN, PSLISTAREGIMEN)


        'DtMonto = oReporte.dtRep3PLMontosMensuales(PSCCMPN, pdblCliente, pdblFecIni, pdblFecFin)
        'DtOCompra = oReporte.dtRep3PLOrdenesMensuales(PSCCMPN, pdblCliente, pdblFecIni, pdblFecFin)
        'DtNoLaborable = oReporte.dtNoLaborables(20080101, pdblFecFin)
        'DtOperaciones = oReporte.dtRep3PLOperacionMensual(PSCCMPN, pdblCliente, pdblFecIni, pdblFecFin)

        DtMonto = dsDatosEnvio.Tables("DTMONTOMENSUAL").Copy
        DtOCompra = dsDatosEnvio.Tables("DTORDENMENSUAL").Copy
        DtNoLaborable = dsDatosEnvio.Tables("DTFERIADO").Copy
        DtOperaciones = dsDatosEnvio.Tables("DTOPERACIONMENSUAL").Copy

        If Validar(DtMonto, DtOCompra, DtOperaciones) Then
            ' If Validar(DtMonto) Then
            dblAduanasMaritimo = 0
            dblAduanasAereo = 0
            dblAduanasTerrestre = 0
            dblOperacionesMaritimo = 0
            dblOperacionesAereo = 0
            dblOperacionesTerrestre = 0

            For intCont = 0 To DtMonto.Rows.Count - 1
                Select Case DtMonto.Rows(intCont).Item("CMEDTR")
                    Case 1
                        dblFleteAereo = dblFleteAereo + Double.Parse(DtMonto.Rows(intCont).Item("IVLFLT"))
                        dblPesoAereo = dblPesoAereo + Double.Parse(DtMonto.Rows(intCont).Item("QPSOAR"))
                    Case 2
                        dblFleteMaritimo = dblFleteMaritimo + Double.Parse(DtMonto.Rows(intCont).Item("IVLFLT"))
                        dblPesoMaritimo = dblPesoMaritimo + Double.Parse(DtMonto.Rows(intCont).Item("QPSOAR"))
                    Case 4
                        dblFleteTerrestre = dblFleteTerrestre + Double.Parse(DtMonto.Rows(intCont).Item("IVLFLT"))
                        dblPesoTerrestre = dblPesoTerrestre + Double.Parse(DtMonto.Rows(intCont).Item("QPSOAR"))
                End Select
            Next intCont
            For intCont = 0 To DtOCompra.Rows.Count - 1
                Select Case DtOCompra.Rows(intCont).Item("CMEDTR")
                    Case 1
                        dblOCAereo = dblOCAereo + Double.Parse(DtOCompra.Rows(intCont).Item("CANT"))
                    Case 2
                        dblOCMaritimo = dblOCMaritimo + Double.Parse(DtOCompra.Rows(intCont).Item("CANT"))
                    Case 4
                        dblOCTerrestre = dblOCTerrestre + Double.Parse(DtOCompra.Rows(intCont).Item("CANT"))
                End Select
            Next intCont
            dblPesoAereo = dblPesoAereo / 1000 'Toneladas
            dblPesoMaritimo = dblPesoMaritimo / 1000 'Toneladas
            dblPesoTerrestre = dblPesoTerrestre / 1000 'Toneladas

            For intCont = 0 To DtOperaciones.Rows.Count - 1
                lstrETA = ("" & DtOperaciones.Rows(intCont).Item("FAPRAR")).ToString.Trim
                lstrAlmacen = ("" & DtOperaciones.Rows(intCont).Item("ALMCLI")).ToString.Trim

                If Date.TryParse(lstrETA, EsFecha) AndAlso Date.TryParse(lstrAlmacen, EsFecha) Then
                    If lstrETA = lstrAlmacen Then
                        DifDias = 0
                    Else
                        lobjDrList = DtNoLaborable.Select("FFRDO >= " & Format(CType(lstrETA, Date), "yyyyMMdd") & " AND FFRDO <= " & Format(CType(lstrAlmacen, Date), "yyyyMMdd"))
                        DifDias = lobjDrList.Length
                    End If
                    lintDias = fintDiferencia_Dia(lstrAlmacen, lstrETA, DifDias)
                End If


                Select Case DtOperaciones.Rows(intCont).Item("CMEDTR")
                    Case 1
                        dblOperacionesAereo = dblOperacionesAereo + 1
                        dblAduanasAereo = dblAduanasAereo + lintDias
                    Case 2
                        dblOperacionesMaritimo = dblOperacionesMaritimo + 1
                        dblAduanasMaritimo = dblAduanasMaritimo + lintDias
                    Case 4
                        dblOperacionesTerrestre = dblOperacionesTerrestre + 1
                        dblAduanasTerrestre = dblAduanasTerrestre + lintDias

                End Select

                'If DtOperaciones.Rows(intCont).Item("CMEDTR").ToString.Trim = "1" Then
                '    dblOperacionesAereo = dblOperacionesAereo + 1
                '    dblAduanasAereo = dblAduanasAereo + lintDias
                'Else
                '    If DtOperaciones.Rows(intCont).Item("CMEDTR").ToString.Trim = "2" Then
                '        dblOperacionesMaritimo = dblOperacionesMaritimo + 1
                '        dblAduanasMaritimo = dblAduanasMaritimo + lintDias
                '    Else
                '        If DtOperaciones.Rows(intCont).Item("CMEDTR").ToString.Trim = "4" Then
                '            dblOperacionesTerrestre = dblOperacionesTerrestre + 1
                '            dblAduanasTerrestre = dblAduanasTerrestre + lintDias
                '        End If
                '    End If
                'End If
            Next intCont
            Insertar_Información_Mensual(PSCCMPN, PSCDVSN, PNCCLNT, Mid(PNFECINI, 5, 2), Mid(PNFECINI, 1, 4))
        Else
            Return False
        End If
        Return True

    End Function

    Private Sub Insertar_Información_Mensual(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal pdblCliente As Double, ByVal pdblMes As Double, ByVal pdblAno As Double)
        Dim oSqlMan As New SqlManager
        Try
            oSqlMan.TransactionController(TransactionType.Manual)
            oSqlMan.BeginGlobalTransaction()
            oReporte.Eliminar_Datos_Mensuales(oSqlMan, PSCCMPN, PSCDVSN, pdblCliente, pdblAno, pdblMes)
            oReporte.Registro_Datos_Mensuales(oSqlMan, PSCCMPN, PSCDVSN, pdblCliente, pdblAno, pdblMes, 1, dblOCAereo, dblFleteAereo, dblPesoAereo, dblAduanasAereo, dblOperacionesAereo)
            oReporte.Registro_Datos_Mensuales(oSqlMan, PSCCMPN, PSCDVSN, pdblCliente, pdblAno, pdblMes, 2, dblOCMaritimo, dblFleteMaritimo, dblPesoMaritimo, dblAduanasMaritimo, dblOperacionesMaritimo)
            oReporte.Registro_Datos_Mensuales(oSqlMan, PSCCMPN, PSCDVSN, pdblCliente, pdblAno, pdblMes, 4, dblOCTerrestre, dblFleteTerrestre, dblPesoTerrestre, dblAduanasTerrestre, dblOperacionesTerrestre)

            oSqlMan.CommitGlobalTransaction()
        Catch ex As Exception
            oSqlMan.RollBackGlobalTransaction()
            Throw New Exception(ex.Message)
        Finally
            oSqlMan = Nothing
        End Try
    End Sub



    'Public Function Registrar_Datos_Mensuales(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal pdblCliente As Double, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double) As Boolean


    '    'dblFecIni = Format(CType("01" & "/" & Format(Me.dtpMesEnvio.Value.Month, "00") & "/" & Me.dtpMesEnvio.Value.Year, Date), "yyyyMMdd")
    '    'dblFecFin = Format(CType("01" & "/" & Format(Me.dtpMesEnvio.Value.AddMonths(1).Month, "00") & "/" & Me.dtpMesEnvio.Value.AddMonths(1).Year, Date).AddDays(-1), "yyyyMMdd")

    '    ''creacion de cons

    '    Dim DtMonto As DataTable
    '    Dim DtOCompra As DataTable
    '    Dim DtNoLaborable As DataTable
    '    Dim DtOperaciones As DataTable
    '    Dim intCont As Integer
    '    Dim lstrETA As String
    '    Dim lstrAlmacen As String
    '    Dim lobjDrList As DataRow()
    '    Dim lintDias As Integer

    '    Dim EsFecha As Date
    '    Dim DifDias As Int32 = 0

    '    Dim dsDatosEnvio As New DataSet



    '    'Public Function dtRep3PLDatosEnvio(ByVal PSCCMPN As String, ByVal PNCCLNT As Double, ByVal PNFECINI As Double, ByVal PNFECFIN As Double, ByVal PSLISTAREGIMEN As String) As DataSet
    '    '    Dim ds As New DataSet
    '    '    Dim lobjSql As New SqlManager
    '    '    Dim lobjParams As New Parameter
    '    '    lobjParams.Add("PSCCMPN", PSCCMPN)
    '    '    lobjParams.Add("PNCCLNT", PNCCLNT)
    '    '    lobjParams.Add("PNFECINI", PNFECINI)
    '    '    lobjParams.Add("PNFECFIN", PNFECFIN)
    '    '    lobjParams.Add("PSLISTAREGIMEN", PSLISTAREGIMEN)
    '    '    ds = lobjSql.ExecuteDataSet("SP_SOLSC_REP3PL_MONTOS", lobjParams)
    '    '    ds.Tables(0).TableName = "DTMONTOMENSUAL"
    '    '    ds.Tables(1).TableName = "DTORDENMENSUAL"
    '    '    ds.Tables(2).TableName = "DTFERIADO"
    '    '    ds.Tables(3).TableName = "DTOPERACIONMENSUAL"
    '    '    Return ds.Copy
    '    'End Function

    '    'dsDatosEnvio = oReporte.dtRep3PLDatosEnvio(PSCCMPN, PNCCLNT, PNFECINI, PNFECFIN, PSLISTAREGIMEN)


    '    DtMonto = oReporte.dtRep3PLMontosMensuales(PSCCMPN, pdblCliente, pdblFecIni, pdblFecFin)
    '    DtOCompra = oReporte.dtRep3PLOrdenesMensuales(PSCCMPN, pdblCliente, pdblFecIni, pdblFecFin)
    '    DtNoLaborable = oReporte.dtNoLaborables(20080101, pdblFecFin)
    '    DtOperaciones = oReporte.dtRep3PLOperacionMensual(PSCCMPN, pdblCliente, pdblFecIni, pdblFecFin)
    '    If Validar(DtMonto) Then
    '        dblAduanasMaritimo = 0
    '        dblAduanasAereo = 0
    '        dblAduanasTerrestre = 0
    '        dblOperacionesMaritimo = 0
    '        dblOperacionesAereo = 0
    '        dblOperacionesTerrestre = 0

    '        For intCont = 0 To DtMonto.Rows.Count - 1
    '            Select Case DtMonto.Rows(intCont).Item("CMEDTR")
    '                Case 1
    '                    dblFleteAereo = dblFleteAereo + Double.Parse(DtMonto.Rows(intCont).Item("IVLFLT"))
    '                    dblPesoAereo = dblPesoAereo + Double.Parse(DtMonto.Rows(intCont).Item("QPSOAR"))
    '                Case 2
    '                    dblFleteMaritimo = dblFleteMaritimo + Double.Parse(DtMonto.Rows(intCont).Item("IVLFLT"))
    '                    dblPesoMaritimo = dblPesoMaritimo + Double.Parse(DtMonto.Rows(intCont).Item("QPSOAR"))
    '                Case 4
    '                    dblFleteTerrestre = dblFleteTerrestre + Double.Parse(DtMonto.Rows(intCont).Item("IVLFLT"))
    '                    dblPesoTerrestre = dblPesoTerrestre + Double.Parse(DtMonto.Rows(intCont).Item("QPSOAR"))
    '            End Select
    '        Next intCont
    '        For intCont = 0 To DtOCompra.Rows.Count - 1
    '            Select Case DtOCompra.Rows(intCont).Item("CMEDTR")
    '                Case 1
    '                    dblOCAereo = dblOCAereo + Double.Parse(DtOCompra.Rows(intCont).Item("CANT"))
    '                Case 2
    '                    dblOCMaritimo = dblOCMaritimo + Double.Parse(DtOCompra.Rows(intCont).Item("CANT"))
    '                Case 4
    '                    dblOCTerrestre = dblOCTerrestre + Double.Parse(DtOCompra.Rows(intCont).Item("CANT"))
    '            End Select
    '        Next intCont
    '        dblPesoAereo = dblPesoAereo / 1000 'Toneladas
    '        dblPesoMaritimo = dblPesoMaritimo / 1000 'Toneladas
    '        dblPesoTerrestre = dblPesoTerrestre / 1000 'Toneladas


    '        For intCont = 0 To DtOperaciones.Rows.Count - 1
    '            lstrETA = ("" & DtOperaciones.Rows(intCont).Item("FAPRAR")).ToString.Trim
    '            lstrAlmacen = ("" & DtOperaciones.Rows(intCont).Item("ALMCLI")).ToString.Trim

    '            If Date.TryParse(lstrETA, EsFecha) AndAlso Date.TryParse(lstrAlmacen, EsFecha) Then
    '                If lstrETA = lstrAlmacen Then
    '                    DifDias = 0
    '                Else
    '                    lobjDrList = DtNoLaborable.Select("FFRDO >= " & Format(CType(lstrETA, Date), "yyyyMMdd") & " AND FFRDO <= " & Format(CType(lstrAlmacen, Date), "yyyyMMdd"))
    '                    DifDias = lobjDrList.Length
    '                End If
    '                lintDias = fintDiferencia_Dia(lstrAlmacen, lstrETA, DifDias)
    '            End If

    '            If DtOperaciones.Rows(intCont).Item("CMEDTR").ToString.Trim = "1" Then
    '                dblOperacionesAereo = dblOperacionesAereo + 1
    '                dblAduanasAereo = dblAduanasAereo + lintDias
    '            Else
    '                If DtOperaciones.Rows(intCont).Item("CMEDTR").ToString.Trim = "2" Then
    '                    dblOperacionesMaritimo = dblOperacionesMaritimo + 1
    '                    dblAduanasMaritimo = dblAduanasMaritimo + lintDias
    '                Else
    '                    If DtOperaciones.Rows(intCont).Item("CMEDTR").ToString.Trim = "4" Then
    '                        dblOperacionesTerrestre = dblOperacionesTerrestre + 1
    '                        dblAduanasTerrestre = dblAduanasTerrestre + lintDias
    '                    End If
    '                End If
    '            End If
    '        Next intCont
    '        Insertar_Información_Mensual(PSCCMPN, PSCDVSN, pdblCliente, Mid(pdblFecIni, 5, 2), Mid(pdblFecIni, 1, 4))
    '    Else
    '        Return False
    '    End If
    '    Return True

    'End Function

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


  

    Private Function Validar(ByVal poMonto As DataTable, ByVal DtOCompra As DataTable, ByVal DtOperaciones As DataTable) As Boolean
        Dim bolValida As Boolean
        Dim intCont As Integer
        strMenError = ""
        bolValida = True

        Dim ColumnasFlete As Int32 = 1
        Dim ColumnasPeso As Int32 = 1
        Dim ColumnaMedio As Int32 = 1


        Dim msgFlete As String = ""
        Dim msgPeso As String = ""
        Dim msgMedio As String = ""

        Dim ListVisitTransp As New List(Of String)

        For intCont = 0 To poMonto.Rows.Count - 1

            If poMonto.Rows(intCont).Item("IVLFLT") = 0 Then
                msgFlete = msgFlete & "(Emb:" & ("" & poMonto.Rows(intCont).Item("NORSCI")).ToString.Trim & " Flete=0) "
                ColumnasFlete = ColumnasFlete + 1
                If ColumnasFlete = 3 Then
                    msgFlete = msgFlete & Chr(13)
                    ColumnasFlete = 1
                End If
                bolValida = False
            End If

            If poMonto.Rows(intCont).Item("QPSOAR") = 0 Then
                msgPeso = msgPeso & "(Emb:" & ("" & poMonto.Rows(intCont).Item("NORSCI")).ToString.Trim & " Peso=0) "
                ColumnasPeso = ColumnasPeso + 1
                If ColumnasPeso = 3 Then
                    msgPeso = msgPeso & Chr(13)
                    ColumnasPeso = 1
                End If
                bolValida = False
            End If

            If poMonto.Rows(intCont).Item("CMEDTR") = 0 Then
                If Not ListVisitTransp.Contains(poMonto.Rows(intCont).Item("NORSCI")) Then
                    ListVisitTransp.Add(poMonto.Rows(intCont).Item("NORSCI"))
                    msgMedio = msgMedio & "(Emb:" & ("" & poMonto.Rows(intCont).Item("NORSCI")).ToString.Trim & " Sin Transporte) "
                    ColumnaMedio = ColumnaMedio + 1
                    If ColumnaMedio = 3 Then
                        msgMedio = msgMedio & Chr(13)
                        ColumnaMedio = 1
                    End If
                    bolValida = False
                End If
            End If
        Next intCont

        ColumnaMedio = 1
        For intCont = 0 To DtOCompra.Rows.Count - 1
            If DtOCompra.Rows(intCont).Item("CMEDTR") = 0 Then
                If Not ListVisitTransp.Contains(DtOCompra.Rows(intCont).Item("NORSCI")) Then
                    ListVisitTransp.Add(DtOCompra.Rows(intCont).Item("NORSCI"))
                    msgMedio = msgMedio & "(Emb:" & ("" & DtOCompra.Rows(intCont).Item("NORSCI")).ToString.Trim & " Sin Transporte) "
                    ColumnaMedio = ColumnaMedio + 1
                    If ColumnaMedio = 3 Then
                        msgMedio = msgMedio & Chr(13)
                        ColumnaMedio = 1
                    End If
                    bolValida = False
                End If
            End If
        Next

        ColumnaMedio = 1
        For intCont = 0 To DtOperaciones.Rows.Count - 1
            If DtOperaciones.Rows(intCont).Item("CMEDTR") = 0 Then
                If Not ListVisitTransp.Contains(DtOperaciones.Rows(intCont).Item("NORSCI")) Then
                    ListVisitTransp.Add(DtOperaciones.Rows(intCont).Item("NORSCI"))
                    msgMedio = msgMedio & "(Emb:" & ("" & DtOperaciones.Rows(intCont).Item("NORSCI")).ToString.Trim & " Sin Transporte) "
                    ColumnaMedio = ColumnaMedio + 1
                    If ColumnaMedio = 3 Then
                        msgMedio = msgMedio & Chr(13)
                        ColumnaMedio = 1
                    End If
                    bolValida = False
                End If
            End If
        Next
        strMenError = (msgFlete & Chr(10) & msgPeso & Chr(10) & msgMedio).Trim
        Return bolValida
    End Function


    Public Function Obtener_Datos(ByVal dtOrdenesDatos As DataTable, ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal pdblCliente As Double, ByVal pdblAno As Double, ByVal pdblMes As Double) As DataTable
        Dim oDt_Aux As DataTable
        Dim intCont As Integer
        Dim intFila As Integer

        'oDt_Aux = oReporte.dtRep3PLOrdenesDatos(PSCCMPN, PSCDVSN, pdblCliente, pdblAno)
        oDt_Aux = dtOrdenesDatos.Copy
        Formato_Consolidado_Mensual(oDt, pdblAno)
        Formato_Consolidado_Aduanas(oDt_Aduanas, pdblAno)
        For intCont = 0 To oDt_Aux.Rows.Count - 1
            intFila = Integer.Parse(oDt_Aux.Rows(intCont).Item("MESALF")) - 1
            If intFila < pdblMes Then
                Select Case Integer.Parse(oDt_Aux.Rows(intCont).Item("CMEDTR"))
                    Case 1
                        oDt.Rows(intFila).Item("NUMOCA") = Integer.Parse(oDt_Aux.Rows(intCont).Item("NUMOCO"))
                        oDt.Rows(intFila).Item("FLETEA") = Double.Parse(oDt_Aux.Rows(intCont).Item("IVLFLT"))
                        oDt.Rows(intFila).Item("PESOA") = Double.Parse(oDt_Aux.Rows(intCont).Item("QPSOAR"))
                        dblTotalOC = dblTotalOC + Integer.Parse(oDt_Aux.Rows(intCont).Item("NUMOCO"))
                        dblTotalFlete = dblTotalFlete + Double.Parse(oDt_Aux.Rows(intCont).Item("IVLFLT"))
                        dblTotalPeso = dblTotalPeso + Double.Parse(oDt_Aux.Rows(intCont).Item("QPSOAR"))
                    Case 2
                        oDt.Rows(intFila).Item("NUMOCO") = Integer.Parse(oDt_Aux.Rows(intCont).Item("NUMOCO"))
                        oDt.Rows(intFila).Item("FLETEO") = Double.Parse(oDt_Aux.Rows(intCont).Item("IVLFLT"))
                        oDt.Rows(intFila).Item("PESOO") = Double.Parse(oDt_Aux.Rows(intCont).Item("QPSOAR"))
                        dblTotalOC = dblTotalOC + Integer.Parse(oDt_Aux.Rows(intCont).Item("NUMOCO"))
                        dblTotalFlete = dblTotalFlete + Double.Parse(oDt_Aux.Rows(intCont).Item("IVLFLT"))
                        dblTotalPeso = dblTotalPeso + Double.Parse(oDt_Aux.Rows(intCont).Item("QPSOAR"))
                    Case 4
                        oDt.Rows(intFila).Item("NUMOCT") = Integer.Parse(oDt_Aux.Rows(intCont).Item("NUMOCO"))
                        oDt.Rows(intFila).Item("FLETET") = Double.Parse(oDt_Aux.Rows(intCont).Item("IVLFLT"))
                        oDt.Rows(intFila).Item("PESOT") = Double.Parse(oDt_Aux.Rows(intCont).Item("QPSOAR"))
                        dblTotalOC = dblTotalOC + Integer.Parse(oDt_Aux.Rows(intCont).Item("NUMOCO"))
                        dblTotalFlete = dblTotalFlete + Double.Parse(oDt_Aux.Rows(intCont).Item("IVLFLT"))
                        dblTotalPeso = dblTotalPeso + Double.Parse(oDt_Aux.Rows(intCont).Item("QPSOAR"))
                End Select
            End If
        Next intCont
        For intCont = 0 To oDt_Aux.Rows.Count - 1
            intFila = Integer.Parse(oDt_Aux.Rows(intCont).Item("MESALF")) - 1
            If intFila < pdblMes Then
                oDt_Aduanas.Rows(intFila).Item("OPERACION") = Integer.Parse(oDt_Aduanas.Rows(intFila).Item("OPERACION")) + Integer.Parse(oDt_Aux.Rows(intCont).Item("TTLOPR"))
                oDt_Aduanas.Rows(intFila).Item("TOTALDIA") = Integer.Parse(oDt_Aduanas.Rows(intFila).Item("TOTALDIA")) + Integer.Parse(oDt_Aux.Rows(intCont).Item("TTLDIA"))
            End If
        Next intCont
        For intCont = 0 To oDt_Aduanas.Rows.Count - 1
            If Double.Parse(oDt_Aduanas.Rows(intCont).Item("OPERACION")) > 0 Then
                'oDt_Aduanas.Rows(intCont).Item("NUMDIA") = Format(Integer.Parse(oDt_Aduanas.Rows(intCont).Item("TOTALDIA")) / Integer.Parse(oDt_Aduanas.Rows(intCont).Item("OPERACION")), "###,###")
                oDt_Aduanas.Rows(intCont).Item("NUMDIA") = Math.Round(Integer.Parse(oDt_Aduanas.Rows(intCont).Item("TOTALDIA")) / Integer.Parse(oDt_Aduanas.Rows(intCont).Item("OPERACION")), 2)
            Else
                oDt_Aduanas.Rows(intCont).Item("NUMDIA") = 0
            End If
        Next intCont
        Return oDt
    End Function


    'Public Function Obtener_Datos(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal pdblCliente As Double, ByVal pdblAno As Double, ByVal pdblMes As Double) As DataTable
    '    Dim oDt_Aux As DataTable
    '    Dim intCont As Integer
    '    Dim intFila As Integer

    '    oDt_Aux = oReporte.dtRep3PLOrdenesDatos(PSCCMPN, PSCDVSN, pdblCliente, pdblAno)
    '    Formato_Consolidado_Mensual(oDt, pdblAno)
    '    Formato_Consolidado_Aduanas(oDt_Aduanas, pdblAno)
    '    For intCont = 0 To oDt_Aux.Rows.Count - 1
    '        intFila = Integer.Parse(oDt_Aux.Rows(intCont).Item("MESALF")) - 1
    '        If intFila < pdblMes Then
    '            Select Case Integer.Parse(oDt_Aux.Rows(intCont).Item("CMEDTR"))
    '                Case 1
    '                    oDt.Rows(intFila).Item("NUMOCA") = Integer.Parse(oDt_Aux.Rows(intCont).Item("NUMOCO"))
    '                    oDt.Rows(intFila).Item("FLETEA") = Double.Parse(oDt_Aux.Rows(intCont).Item("IVLFLT"))
    '                    oDt.Rows(intFila).Item("PESOA") = Double.Parse(oDt_Aux.Rows(intCont).Item("QPSOAR"))
    '                    dblTotalOC = dblTotalOC + Integer.Parse(oDt_Aux.Rows(intCont).Item("NUMOCO"))
    '                    dblTotalFlete = dblTotalFlete + Double.Parse(oDt_Aux.Rows(intCont).Item("IVLFLT"))
    '                    dblTotalPeso = dblTotalPeso + Double.Parse(oDt_Aux.Rows(intCont).Item("QPSOAR"))
    '                Case 2
    '                    oDt.Rows(intFila).Item("NUMOCO") = Integer.Parse(oDt_Aux.Rows(intCont).Item("NUMOCO"))
    '                    oDt.Rows(intFila).Item("FLETEO") = Double.Parse(oDt_Aux.Rows(intCont).Item("IVLFLT"))
    '                    oDt.Rows(intFila).Item("PESOO") = Double.Parse(oDt_Aux.Rows(intCont).Item("QPSOAR"))
    '                    dblTotalOC = dblTotalOC + Integer.Parse(oDt_Aux.Rows(intCont).Item("NUMOCO"))
    '                    dblTotalFlete = dblTotalFlete + Double.Parse(oDt_Aux.Rows(intCont).Item("IVLFLT"))
    '                    dblTotalPeso = dblTotalPeso + Double.Parse(oDt_Aux.Rows(intCont).Item("QPSOAR"))
    '                Case 4
    '                    oDt.Rows(intFila).Item("NUMOCT") = Integer.Parse(oDt_Aux.Rows(intCont).Item("NUMOCO"))
    '                    oDt.Rows(intFila).Item("FLETET") = Double.Parse(oDt_Aux.Rows(intCont).Item("IVLFLT"))
    '                    oDt.Rows(intFila).Item("PESOT") = Double.Parse(oDt_Aux.Rows(intCont).Item("QPSOAR"))
    '                    dblTotalOC = dblTotalOC + Integer.Parse(oDt_Aux.Rows(intCont).Item("NUMOCO"))
    '                    dblTotalFlete = dblTotalFlete + Double.Parse(oDt_Aux.Rows(intCont).Item("IVLFLT"))
    '                    dblTotalPeso = dblTotalPeso + Double.Parse(oDt_Aux.Rows(intCont).Item("QPSOAR"))
    '            End Select
    '        End If
    '    Next intCont
    '    For intCont = 0 To oDt_Aux.Rows.Count - 1
    '        intFila = Integer.Parse(oDt_Aux.Rows(intCont).Item("MESALF")) - 1
    '        If intFila < pdblMes Then
    '            oDt_Aduanas.Rows(intFila).Item("OPERACION") = Integer.Parse(oDt_Aduanas.Rows(intFila).Item("OPERACION")) + Integer.Parse(oDt_Aux.Rows(intCont).Item("TTLOPR"))
    '            oDt_Aduanas.Rows(intFila).Item("TOTALDIA") = Integer.Parse(oDt_Aduanas.Rows(intFila).Item("TOTALDIA")) + Integer.Parse(oDt_Aux.Rows(intCont).Item("TTLDIA"))
    '        End If
    '    Next intCont
    '    For intCont = 0 To oDt_Aduanas.Rows.Count - 1
    '        If Double.Parse(oDt_Aduanas.Rows(intCont).Item("OPERACION")) > 0 Then
    '            'oDt_Aduanas.Rows(intCont).Item("NUMDIA") = Format(Integer.Parse(oDt_Aduanas.Rows(intCont).Item("TOTALDIA")) / Integer.Parse(oDt_Aduanas.Rows(intCont).Item("OPERACION")), "###,###")
    '            oDt_Aduanas.Rows(intCont).Item("NUMDIA") = Math.Round(Integer.Parse(oDt_Aduanas.Rows(intCont).Item("TOTALDIA")) / Integer.Parse(oDt_Aduanas.Rows(intCont).Item("OPERACION")), 2)
    '        Else
    '            oDt_Aduanas.Rows(intCont).Item("NUMDIA") = 0
    '        End If
    '    Next intCont
    '    Return oDt
    'End Function

    'ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal pdblCliente As Double, ByVal FecIni As Date, ByVal FecFin As Date

    'Public Function Obtener_Datos(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal pdblCliente As Double, ByVal FecIni As Date, ByVal FecFin As Date) As DataTable
    '    Dim oDt_Aux As DataTable
    '    Dim intCont As Integer
    '    Dim intFila As Integer

    '    'Filtro.Add("Año", Format(Me.dtpFecIni.Value, "yyyy"))
    '    'Filtro.Add("Mes", Format(Me.dtpFecFin.Value, "MM"))

    '    Dim pdblAno As Double = Format(FecIni, "yyyy")
    '    Dim pdblMes As Double = Format(FecFin, "MM")

    '    Dim result As Boolean = False

    '    oDt_Aux = ConsolidarRegistros(PSCCMPN, PSCDVSN, pdblCliente, FecIni, FecFin, result)
    '    'oDt_Aux = oReporte.dtRep3PLOrdenesDatos(PSCCMPN, PSCDVSN, pdblCliente, pdblAno)
    '    Formato_Consolidado_Mensual(oDt, pdblAno)
    '    Formato_Consolidado_Aduanas(oDt_Aduanas, pdblAno)

    '    If ("" & Mensaje).ToString.Trim.Length > 0 Then
    '        Return oDt
    '    End If

    '    For intCont = 0 To oDt_Aux.Rows.Count - 1
    '        intFila = Integer.Parse(oDt_Aux.Rows(intCont).Item("MESALF")) - 1
    '        If intFila < pdblMes Then
    '            Select Case Integer.Parse(oDt_Aux.Rows(intCont).Item("CMEDTR"))
    '                Case 1
    '                    oDt.Rows(intFila).Item("NUMOCA") = Integer.Parse(oDt_Aux.Rows(intCont).Item("NUMOCO"))
    '                    oDt.Rows(intFila).Item("FLETEA") = Double.Parse(oDt_Aux.Rows(intCont).Item("IVLFLT"))
    '                    oDt.Rows(intFila).Item("PESOA") = Double.Parse(oDt_Aux.Rows(intCont).Item("QPSOAR"))
    '                    dblTotalOC = dblTotalOC + Integer.Parse(oDt_Aux.Rows(intCont).Item("NUMOCO"))
    '                    dblTotalFlete = dblTotalFlete + Double.Parse(oDt_Aux.Rows(intCont).Item("IVLFLT"))
    '                    dblTotalPeso = dblTotalPeso + Double.Parse(oDt_Aux.Rows(intCont).Item("QPSOAR"))
    '                Case 2
    '                    oDt.Rows(intFila).Item("NUMOCO") = Integer.Parse(oDt_Aux.Rows(intCont).Item("NUMOCO"))
    '                    oDt.Rows(intFila).Item("FLETEO") = Double.Parse(oDt_Aux.Rows(intCont).Item("IVLFLT"))
    '                    oDt.Rows(intFila).Item("PESOO") = Double.Parse(oDt_Aux.Rows(intCont).Item("QPSOAR"))
    '                    dblTotalOC = dblTotalOC + Integer.Parse(oDt_Aux.Rows(intCont).Item("NUMOCO"))
    '                    dblTotalFlete = dblTotalFlete + Double.Parse(oDt_Aux.Rows(intCont).Item("IVLFLT"))
    '                    dblTotalPeso = dblTotalPeso + Double.Parse(oDt_Aux.Rows(intCont).Item("QPSOAR"))
    '                Case 4
    '                    oDt.Rows(intFila).Item("NUMOCT") = Integer.Parse(oDt_Aux.Rows(intCont).Item("NUMOCO"))
    '                    oDt.Rows(intFila).Item("FLETET") = Double.Parse(oDt_Aux.Rows(intCont).Item("IVLFLT"))
    '                    oDt.Rows(intFila).Item("PESOT") = Double.Parse(oDt_Aux.Rows(intCont).Item("QPSOAR"))
    '                    dblTotalOC = dblTotalOC + Integer.Parse(oDt_Aux.Rows(intCont).Item("NUMOCO"))
    '                    dblTotalFlete = dblTotalFlete + Double.Parse(oDt_Aux.Rows(intCont).Item("IVLFLT"))
    '                    dblTotalPeso = dblTotalPeso + Double.Parse(oDt_Aux.Rows(intCont).Item("QPSOAR"))
    '            End Select
    '        End If
    '    Next intCont
    '    For intCont = 0 To oDt_Aux.Rows.Count - 1
    '        intFila = Integer.Parse(oDt_Aux.Rows(intCont).Item("MESALF")) - 1
    '        If intFila < pdblMes Then
    '            oDt_Aduanas.Rows(intFila).Item("OPERACION") = Integer.Parse(oDt_Aduanas.Rows(intFila).Item("OPERACION")) + Integer.Parse(oDt_Aux.Rows(intCont).Item("TTLOPR"))
    '            oDt_Aduanas.Rows(intFila).Item("TOTALDIA") = Integer.Parse(oDt_Aduanas.Rows(intFila).Item("TOTALDIA")) + Integer.Parse(oDt_Aux.Rows(intCont).Item("TTLDIA"))
    '        End If
    '    Next intCont
    '    For intCont = 0 To oDt_Aduanas.Rows.Count - 1
    '        If Double.Parse(oDt_Aduanas.Rows(intCont).Item("OPERACION")) > 0 Then
    '            'oDt_Aduanas.Rows(intCont).Item("NUMDIA") = Format(Integer.Parse(oDt_Aduanas.Rows(intCont).Item("TOTALDIA")) / Integer.Parse(oDt_Aduanas.Rows(intCont).Item("OPERACION")), "###,###")
    '            oDt_Aduanas.Rows(intCont).Item("NUMDIA") = Integer.Parse(oDt_Aduanas.Rows(intCont).Item("TOTALDIA")) / Integer.Parse(oDt_Aduanas.Rows(intCont).Item("OPERACION"))
    '        Else
    '            oDt_Aduanas.Rows(intCont).Item("NUMDIA") = 0
    '        End If
    '    Next intCont
    '    Return oDt
    'End Function


    'Public Function Obtener_Datos_X_Origen(ByVal pdblCliente As Double, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double, ByVal PSTPSRVA As String) As DataTable
    '    Dim oDt_Aux As DataTable
    '    Dim intCont As Integer
    '    Dim oDr As DataRow
    '    Dim intFila As Integer
    '    'oDt_Aux = oReporte.dtRep3PLOrdenesMensualesXOrigen(pdblCliente, pdblFecIni, pdblFecFin, PSTPSRVA)
    '    oDt_Aux = oReporte.dtRep3PLOrdenesMensualesXOrigen(pdblCliente, pdblFecIni, pdblFecFin)
    '    Formato_Ordenes_X_Origen(oDt_Origen)
    '    For intCont = 0 To oDt_Aux.Rows.Count - 1
    '        If oDt_Origen.Rows.Count = 0 Then
    '            oDr = oDt_Origen.NewRow
    '            If oDt_Aux.Rows(intCont).Item("TCMPPS").ToString.Trim = "ESTADOS UNIDOS" Then
    '                oDr.Item("ORIGEN") = oDt_Aux.Rows(intCont).Item("TCMPR1").ToString
    '            Else
    '                oDr.Item("ORIGEN") = oDt_Aux.Rows(intCont).Item("TCMPPS").ToString
    '            End If
    '            Select Case oDt_Aux.Rows(intCont).Item("CMEDTR").ToString.Trim
    '                Case 1
    '                    oDr.Item("NUMOCA") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '                    oDr.Item("NUMOCO") = 0
    '                    oDr.Item("NUMOCT") = 0
    '                    oDr.Item("PESOA") = 0
    '                    oDr.Item("PESOO") = 0
    '                    oDr.Item("PESOT") = 0
    '                    oDr.Item("TOTOCORI") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '                Case 2
    '                    oDr.Item("NUMOCA") = 0
    '                    oDr.Item("NUMOCO") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '                    oDr.Item("NUMOCT") = 0
    '                    oDr.Item("PESOA") = 0
    '                    oDr.Item("PESOO") = 0
    '                    oDr.Item("PESOT") = 0
    '                    oDr.Item("TOTOCORI") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '                Case 4
    '                    oDr.Item("NUMOCA") = 0
    '                    oDr.Item("NUMOCO") = 0
    '                    oDr.Item("NUMOCT") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '                    oDr.Item("PESOA") = 0
    '                    oDr.Item("PESOO") = 0
    '                    oDr.Item("PESOT") = 0
    '                    oDr.Item("TOTOCORI") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '            End Select
    '            oDt_Origen.Rows.Add(oDr)
    '        Else
    '            intFila = Dame_Fila(oDt_Origen, oDt_Aux.Rows(intCont).Item("TCMPPS").ToString.Trim, oDt_Aux.Rows(intCont).Item("TCMPR1").ToString.Trim)
    '            If intFila = -1 Then
    '                oDr = oDt_Origen.NewRow
    '                If oDt_Aux.Rows(intCont).Item("TCMPPS").ToString.Trim = "ESTADOS UNIDOS" Then
    '                    oDr.Item("ORIGEN") = oDt_Aux.Rows(intCont).Item("TCMPR1").ToString
    '                Else
    '                    oDr.Item("ORIGEN") = oDt_Aux.Rows(intCont).Item("TCMPPS").ToString
    '                End If
    '                Select Case oDt_Aux.Rows(intCont).Item("CMEDTR").ToString.Trim
    '                    Case 1
    '                        oDr.Item("NUMOCA") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '                        oDr.Item("NUMOCO") = 0
    '                        oDr.Item("NUMOCT") = 0
    '                        oDr.Item("PESOA") = 0
    '                        oDr.Item("PESOO") = 0
    '                        oDr.Item("PESOT") = 0
    '                        oDr.Item("TOTOCORI") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '                    Case 2
    '                        oDr.Item("NUMOCA") = 0
    '                        oDr.Item("NUMOCO") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '                        oDr.Item("NUMOCT") = 0
    '                        oDr.Item("PESOA") = 0
    '                        oDr.Item("PESOO") = 0
    '                        oDr.Item("PESOT") = 0
    '                        oDr.Item("TOTOCORI") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '                    Case 4
    '                        oDr.Item("NUMOCA") = 0
    '                        oDr.Item("NUMOCO") = 0
    '                        oDr.Item("NUMOCT") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '                        oDr.Item("PESOA") = 0
    '                        oDr.Item("PESOO") = 0
    '                        oDr.Item("PESOT") = 0
    '                        oDr.Item("TOTOCORI") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '                End Select
    '                oDt_Origen.Rows.Add(oDr)
    '            Else
    '                Select Case oDt_Aux.Rows(intCont).Item("CMEDTR").ToString.Trim
    '                    Case 1
    '                        oDt_Origen.Rows(intFila).Item("NUMOCA") = Integer.Parse(oDt_Origen.Rows(intFila).Item("NUMOCA")) + Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '                        oDt_Origen.Rows(intFila).Item("TOTOCORI") = Integer.Parse(oDt_Origen.Rows(intFila).Item("TOTOCORI")) + Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '                    Case 2
    '                        oDt_Origen.Rows(intFila).Item("NUMOCO") = Integer.Parse(oDt_Origen.Rows(intFila).Item("NUMOCO")) + Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '                        oDt_Origen.Rows(intFila).Item("TOTOCORI") = Integer.Parse(oDt_Origen.Rows(intFila).Item("TOTOCORI")) + Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '                    Case 4
    '                        oDt_Origen.Rows(intFila).Item("NUMOCT") = Integer.Parse(oDt_Origen.Rows(intFila).Item("NUMOCT")) + Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '                        oDt_Origen.Rows(intFila).Item("TOTOCORI") = Integer.Parse(oDt_Origen.Rows(intFila).Item("TOTOCORI")) + Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '                End Select
    '            End If
    '        End If
    '    Next intCont
    '    oDt_Aux = oReporte.dtRep3PLPesosMensualesXOrigen(pdblCliente, pdblFecIni, pdblFecFin)
    '    For intCont = 0 To oDt_Aux.Rows.Count - 1
    '        intFila = Dame_Fila(oDt_Origen, oDt_Aux.Rows(intCont).Item("TCMPPS").ToString.Trim, oDt_Aux.Rows(intCont).Item("TCMPR1").ToString.Trim)
    '        If intFila = -1 Then
    '            oDr = oDt_Origen.NewRow
    '            If oDt_Aux.Rows(intCont).Item("TCMPPS").ToString.Trim = "ESTADOS UNIDOS" Then
    '                oDr.Item("ORIGEN") = oDt_Aux.Rows(intCont).Item("TCMPR1").ToString
    '            Else
    '                oDr.Item("ORIGEN") = oDt_Aux.Rows(intCont).Item("TCMPPS").ToString
    '            End If
    '            Select Case oDt_Aux.Rows(intCont).Item("CMEDTR").ToString.Trim
    '                Case 1
    '                    oDr.Item("NUMOCA") = 0
    '                    oDr.Item("NUMOCO") = 0
    '                    oDr.Item("NUMOCT") = 0
    '                    oDr.Item("PESOA") = Double.Parse(oDt_Aux.Rows(intCont).Item("PESO").ToString)
    '                    oDr.Item("PESOO") = 0
    '                    oDr.Item("PESOT") = 0
    '                    oDr.Item("TOTOCORI") = 0
    '                Case 2
    '                    oDr.Item("NUMOCA") = 0
    '                    oDr.Item("NUMOCO") = 0
    '                    oDr.Item("NUMOCT") = 0
    '                    oDr.Item("PESOA") = 0
    '                    oDr.Item("PESOO") = Double.Parse(oDt_Aux.Rows(intCont).Item("PESO").ToString)
    '                    oDr.Item("PESOT") = 0
    '                    oDr.Item("TOTOCORI") = 0
    '                Case 4
    '                    oDr.Item("NUMOCA") = 0
    '                    oDr.Item("NUMOCO") = 0
    '                    oDr.Item("NUMOCT") = 0
    '                    oDr.Item("PESOA") = 0
    '                    oDr.Item("PESOO") = 0
    '                    oDr.Item("PESOT") = Double.Parse(oDt_Aux.Rows(intCont).Item("PESO").ToString)
    '                    oDr.Item("TOTOCORI") = 0
    '            End Select
    '            oDt_Origen.Rows.Add(oDr)
    '        Else
    '            Select Case oDt_Aux.Rows(intCont).Item("CMEDTR").ToString.Trim
    '                Case 1
    '                    oDt_Origen.Rows(intFila).Item("PESOA") = Double.Parse(oDt_Origen.Rows(intFila).Item("PESOA")) + Double.Parse(oDt_Aux.Rows(intCont).Item("PESO").ToString)
    '                Case 2
    '                    oDt_Origen.Rows(intFila).Item("PESOO") = Double.Parse(oDt_Origen.Rows(intFila).Item("PESOO")) + Double.Parse(oDt_Aux.Rows(intCont).Item("PESO").ToString)
    '                Case 4
    '                    oDt_Origen.Rows(intFila).Item("PESOT") = Double.Parse(oDt_Origen.Rows(intFila).Item("PESOT")) + Double.Parse(oDt_Aux.Rows(intCont).Item("PESO").ToString)
    '            End Select
    '        End If
    '    Next intCont
    '    Return oDt_Origen
    'End Function


    Public Function Obtener_Datos_X_Origen(ByVal dtOrdenMensualOrigen As DataTable, ByVal dtPesoMensualorigen As DataTable, ByVal pdblCliente As Double, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double) As DataTable
        Dim oDt_Aux As DataTable
        Dim intCont As Integer
        Dim oDr As DataRow
        Dim intFila As Integer

        'oDt_Aux = oReporte.dtRep3PLOrdenesMensualesXOrigen(pdblCliente, pdblFecIni, pdblFecFin)
        oDt_Aux = dtOrdenMensualOrigen.Copy
        Formato_Ordenes_X_Origen(oDt_Origen)
        For intCont = 0 To oDt_Aux.Rows.Count - 1
            If oDt_Origen.Rows.Count = 0 Then
                oDr = oDt_Origen.NewRow
                If oDt_Aux.Rows(intCont).Item("TCMPPS").ToString.Trim = "ESTADOS UNIDOS" Then
                    oDr.Item("ORIGEN") = oDt_Aux.Rows(intCont).Item("TCMPR1").ToString
                Else
                    oDr.Item("ORIGEN") = oDt_Aux.Rows(intCont).Item("TCMPPS").ToString
                End If
                Select Case oDt_Aux.Rows(intCont).Item("CMEDTR").ToString.Trim
                    Case 1
                        oDr.Item("NUMOCA") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
                        oDr.Item("NUMOCO") = 0
                        oDr.Item("NUMOCT") = 0
                        oDr.Item("PESOA") = 0
                        oDr.Item("PESOO") = 0
                        oDr.Item("PESOT") = 0
                        oDr.Item("TOTOCORI") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
                    Case 2
                        oDr.Item("NUMOCA") = 0
                        oDr.Item("NUMOCO") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
                        oDr.Item("NUMOCT") = 0
                        oDr.Item("PESOA") = 0
                        oDr.Item("PESOO") = 0
                        oDr.Item("PESOT") = 0
                        oDr.Item("TOTOCORI") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
                    Case 4
                        oDr.Item("NUMOCA") = 0
                        oDr.Item("NUMOCO") = 0
                        oDr.Item("NUMOCT") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
                        oDr.Item("PESOA") = 0
                        oDr.Item("PESOO") = 0
                        oDr.Item("PESOT") = 0
                        oDr.Item("TOTOCORI") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
                End Select
                oDt_Origen.Rows.Add(oDr)
            Else
                intFila = Dame_Fila(oDt_Origen, oDt_Aux.Rows(intCont).Item("TCMPPS").ToString.Trim, oDt_Aux.Rows(intCont).Item("TCMPR1").ToString.Trim)
                If intFila = -1 Then
                    oDr = oDt_Origen.NewRow
                    If oDt_Aux.Rows(intCont).Item("TCMPPS").ToString.Trim = "ESTADOS UNIDOS" Then
                        oDr.Item("ORIGEN") = oDt_Aux.Rows(intCont).Item("TCMPR1").ToString
                    Else
                        oDr.Item("ORIGEN") = oDt_Aux.Rows(intCont).Item("TCMPPS").ToString
                    End If
                    Select Case oDt_Aux.Rows(intCont).Item("CMEDTR").ToString.Trim
                        Case 1
                            oDr.Item("NUMOCA") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
                            oDr.Item("NUMOCO") = 0
                            oDr.Item("NUMOCT") = 0
                            oDr.Item("PESOA") = 0
                            oDr.Item("PESOO") = 0
                            oDr.Item("PESOT") = 0
                            oDr.Item("TOTOCORI") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
                        Case 2
                            oDr.Item("NUMOCA") = 0
                            oDr.Item("NUMOCO") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
                            oDr.Item("NUMOCT") = 0
                            oDr.Item("PESOA") = 0
                            oDr.Item("PESOO") = 0
                            oDr.Item("PESOT") = 0
                            oDr.Item("TOTOCORI") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
                        Case 4
                            oDr.Item("NUMOCA") = 0
                            oDr.Item("NUMOCO") = 0
                            oDr.Item("NUMOCT") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
                            oDr.Item("PESOA") = 0
                            oDr.Item("PESOO") = 0
                            oDr.Item("PESOT") = 0
                            oDr.Item("TOTOCORI") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
                    End Select
                    oDt_Origen.Rows.Add(oDr)
                Else
                    Select Case oDt_Aux.Rows(intCont).Item("CMEDTR").ToString.Trim
                        Case 1
                            oDt_Origen.Rows(intFila).Item("NUMOCA") = Integer.Parse(oDt_Origen.Rows(intFila).Item("NUMOCA")) + Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
                            oDt_Origen.Rows(intFila).Item("TOTOCORI") = Integer.Parse(oDt_Origen.Rows(intFila).Item("TOTOCORI")) + Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
                        Case 2
                            oDt_Origen.Rows(intFila).Item("NUMOCO") = Integer.Parse(oDt_Origen.Rows(intFila).Item("NUMOCO")) + Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
                            oDt_Origen.Rows(intFila).Item("TOTOCORI") = Integer.Parse(oDt_Origen.Rows(intFila).Item("TOTOCORI")) + Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
                        Case 4
                            oDt_Origen.Rows(intFila).Item("NUMOCT") = Integer.Parse(oDt_Origen.Rows(intFila).Item("NUMOCT")) + Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
                            oDt_Origen.Rows(intFila).Item("TOTOCORI") = Integer.Parse(oDt_Origen.Rows(intFila).Item("TOTOCORI")) + Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
                    End Select
                End If
            End If
        Next intCont
        'oDt_Aux = oReporte.dtRep3PLPesosMensualesXOrigen(pdblCliente, pdblFecIni, pdblFecFin)
        oDt_Aux = dtPesoMensualorigen.Copy
        For intCont = 0 To oDt_Aux.Rows.Count - 1
            intFila = Dame_Fila(oDt_Origen, oDt_Aux.Rows(intCont).Item("TCMPPS").ToString.Trim, oDt_Aux.Rows(intCont).Item("TCMPR1").ToString.Trim)
            If intFila = -1 Then
                oDr = oDt_Origen.NewRow
                If oDt_Aux.Rows(intCont).Item("TCMPPS").ToString.Trim = "ESTADOS UNIDOS" Then
                    oDr.Item("ORIGEN") = oDt_Aux.Rows(intCont).Item("TCMPR1").ToString
                Else
                    oDr.Item("ORIGEN") = oDt_Aux.Rows(intCont).Item("TCMPPS").ToString
                End If
                Select Case oDt_Aux.Rows(intCont).Item("CMEDTR").ToString.Trim
                    Case 1
                        oDr.Item("NUMOCA") = 0
                        oDr.Item("NUMOCO") = 0
                        oDr.Item("NUMOCT") = 0
                        oDr.Item("PESOA") = Double.Parse(oDt_Aux.Rows(intCont).Item("PESO").ToString)
                        oDr.Item("PESOO") = 0
                        oDr.Item("PESOT") = 0
                        oDr.Item("TOTOCORI") = 0
                    Case 2
                        oDr.Item("NUMOCA") = 0
                        oDr.Item("NUMOCO") = 0
                        oDr.Item("NUMOCT") = 0
                        oDr.Item("PESOA") = 0
                        oDr.Item("PESOO") = Double.Parse(oDt_Aux.Rows(intCont).Item("PESO").ToString)
                        oDr.Item("PESOT") = 0
                        oDr.Item("TOTOCORI") = 0
                    Case 4
                        oDr.Item("NUMOCA") = 0
                        oDr.Item("NUMOCO") = 0
                        oDr.Item("NUMOCT") = 0
                        oDr.Item("PESOA") = 0
                        oDr.Item("PESOO") = 0
                        oDr.Item("PESOT") = Double.Parse(oDt_Aux.Rows(intCont).Item("PESO").ToString)
                        oDr.Item("TOTOCORI") = 0
                End Select
                oDt_Origen.Rows.Add(oDr)
            Else
                Select Case oDt_Aux.Rows(intCont).Item("CMEDTR").ToString.Trim
                    Case 1
                        oDt_Origen.Rows(intFila).Item("PESOA") = Double.Parse(oDt_Origen.Rows(intFila).Item("PESOA")) + Double.Parse(oDt_Aux.Rows(intCont).Item("PESO").ToString)
                    Case 2
                        oDt_Origen.Rows(intFila).Item("PESOO") = Double.Parse(oDt_Origen.Rows(intFila).Item("PESOO")) + Double.Parse(oDt_Aux.Rows(intCont).Item("PESO").ToString)
                    Case 4
                        oDt_Origen.Rows(intFila).Item("PESOT") = Double.Parse(oDt_Origen.Rows(intFila).Item("PESOT")) + Double.Parse(oDt_Aux.Rows(intCont).Item("PESO").ToString)
                End Select
            End If
        Next intCont
        Return oDt_Origen
    End Function


    'Public Function Obtener_Datos_X_Origen(ByVal pdblCliente As Double, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double) As DataTable
    '    Dim oDt_Aux As DataTable
    '    Dim intCont As Integer
    '    Dim oDr As DataRow
    '    Dim intFila As Integer

    '    oDt_Aux = oReporte.dtRep3PLOrdenesMensualesXOrigen(pdblCliente, pdblFecIni, pdblFecFin)
    '    Formato_Ordenes_X_Origen(oDt_Origen)
    '    For intCont = 0 To oDt_Aux.Rows.Count - 1
    '        If oDt_Origen.Rows.Count = 0 Then
    '            oDr = oDt_Origen.NewRow
    '            If oDt_Aux.Rows(intCont).Item("TCMPPS").ToString.Trim = "ESTADOS UNIDOS" Then
    '                oDr.Item("ORIGEN") = oDt_Aux.Rows(intCont).Item("TCMPR1").ToString
    '            Else
    '                oDr.Item("ORIGEN") = oDt_Aux.Rows(intCont).Item("TCMPPS").ToString
    '            End If
    '            Select Case oDt_Aux.Rows(intCont).Item("CMEDTR").ToString.Trim
    '                Case 1
    '                    oDr.Item("NUMOCA") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '                    oDr.Item("NUMOCO") = 0
    '                    oDr.Item("NUMOCT") = 0
    '                    oDr.Item("PESOA") = 0
    '                    oDr.Item("PESOO") = 0
    '                    oDr.Item("PESOT") = 0
    '                    oDr.Item("TOTOCORI") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '                Case 2
    '                    oDr.Item("NUMOCA") = 0
    '                    oDr.Item("NUMOCO") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '                    oDr.Item("NUMOCT") = 0
    '                    oDr.Item("PESOA") = 0
    '                    oDr.Item("PESOO") = 0
    '                    oDr.Item("PESOT") = 0
    '                    oDr.Item("TOTOCORI") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '                Case 4
    '                    oDr.Item("NUMOCA") = 0
    '                    oDr.Item("NUMOCO") = 0
    '                    oDr.Item("NUMOCT") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '                    oDr.Item("PESOA") = 0
    '                    oDr.Item("PESOO") = 0
    '                    oDr.Item("PESOT") = 0
    '                    oDr.Item("TOTOCORI") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '            End Select
    '            oDt_Origen.Rows.Add(oDr)
    '        Else
    '            intFila = Dame_Fila(oDt_Origen, oDt_Aux.Rows(intCont).Item("TCMPPS").ToString.Trim, oDt_Aux.Rows(intCont).Item("TCMPR1").ToString.Trim)
    '            If intFila = -1 Then
    '                oDr = oDt_Origen.NewRow
    '                If oDt_Aux.Rows(intCont).Item("TCMPPS").ToString.Trim = "ESTADOS UNIDOS" Then
    '                    oDr.Item("ORIGEN") = oDt_Aux.Rows(intCont).Item("TCMPR1").ToString
    '                Else
    '                    oDr.Item("ORIGEN") = oDt_Aux.Rows(intCont).Item("TCMPPS").ToString
    '                End If
    '                Select Case oDt_Aux.Rows(intCont).Item("CMEDTR").ToString.Trim
    '                    Case 1
    '                        oDr.Item("NUMOCA") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '                        oDr.Item("NUMOCO") = 0
    '                        oDr.Item("NUMOCT") = 0
    '                        oDr.Item("PESOA") = 0
    '                        oDr.Item("PESOO") = 0
    '                        oDr.Item("PESOT") = 0
    '                        oDr.Item("TOTOCORI") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '                    Case 2
    '                        oDr.Item("NUMOCA") = 0
    '                        oDr.Item("NUMOCO") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '                        oDr.Item("NUMOCT") = 0
    '                        oDr.Item("PESOA") = 0
    '                        oDr.Item("PESOO") = 0
    '                        oDr.Item("PESOT") = 0
    '                        oDr.Item("TOTOCORI") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '                    Case 4
    '                        oDr.Item("NUMOCA") = 0
    '                        oDr.Item("NUMOCO") = 0
    '                        oDr.Item("NUMOCT") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '                        oDr.Item("PESOA") = 0
    '                        oDr.Item("PESOO") = 0
    '                        oDr.Item("PESOT") = 0
    '                        oDr.Item("TOTOCORI") = Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '                End Select
    '                oDt_Origen.Rows.Add(oDr)
    '            Else
    '                Select Case oDt_Aux.Rows(intCont).Item("CMEDTR").ToString.Trim
    '                    Case 1
    '                        oDt_Origen.Rows(intFila).Item("NUMOCA") = Integer.Parse(oDt_Origen.Rows(intFila).Item("NUMOCA")) + Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '                        oDt_Origen.Rows(intFila).Item("TOTOCORI") = Integer.Parse(oDt_Origen.Rows(intFila).Item("TOTOCORI")) + Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '                    Case 2
    '                        oDt_Origen.Rows(intFila).Item("NUMOCO") = Integer.Parse(oDt_Origen.Rows(intFila).Item("NUMOCO")) + Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '                        oDt_Origen.Rows(intFila).Item("TOTOCORI") = Integer.Parse(oDt_Origen.Rows(intFila).Item("TOTOCORI")) + Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '                    Case 4
    '                        oDt_Origen.Rows(intFila).Item("NUMOCT") = Integer.Parse(oDt_Origen.Rows(intFila).Item("NUMOCT")) + Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '                        oDt_Origen.Rows(intFila).Item("TOTOCORI") = Integer.Parse(oDt_Origen.Rows(intFila).Item("TOTOCORI")) + Integer.Parse(oDt_Aux.Rows(intCont).Item("CANT").ToString)
    '                End Select
    '            End If
    '        End If
    '    Next intCont
    '    oDt_Aux = oReporte.dtRep3PLPesosMensualesXOrigen(pdblCliente, pdblFecIni, pdblFecFin)
    '    For intCont = 0 To oDt_Aux.Rows.Count - 1
    '        intFila = Dame_Fila(oDt_Origen, oDt_Aux.Rows(intCont).Item("TCMPPS").ToString.Trim, oDt_Aux.Rows(intCont).Item("TCMPR1").ToString.Trim)
    '        If intFila = -1 Then
    '            oDr = oDt_Origen.NewRow
    '            If oDt_Aux.Rows(intCont).Item("TCMPPS").ToString.Trim = "ESTADOS UNIDOS" Then
    '                oDr.Item("ORIGEN") = oDt_Aux.Rows(intCont).Item("TCMPR1").ToString
    '            Else
    '                oDr.Item("ORIGEN") = oDt_Aux.Rows(intCont).Item("TCMPPS").ToString
    '            End If
    '            Select Case oDt_Aux.Rows(intCont).Item("CMEDTR").ToString.Trim
    '                Case 1
    '                    oDr.Item("NUMOCA") = 0
    '                    oDr.Item("NUMOCO") = 0
    '                    oDr.Item("NUMOCT") = 0
    '                    oDr.Item("PESOA") = Double.Parse(oDt_Aux.Rows(intCont).Item("PESO").ToString)
    '                    oDr.Item("PESOO") = 0
    '                    oDr.Item("PESOT") = 0
    '                    oDr.Item("TOTOCORI") = 0
    '                Case 2
    '                    oDr.Item("NUMOCA") = 0
    '                    oDr.Item("NUMOCO") = 0
    '                    oDr.Item("NUMOCT") = 0
    '                    oDr.Item("PESOA") = 0
    '                    oDr.Item("PESOO") = Double.Parse(oDt_Aux.Rows(intCont).Item("PESO").ToString)
    '                    oDr.Item("PESOT") = 0
    '                    oDr.Item("TOTOCORI") = 0
    '                Case 4
    '                    oDr.Item("NUMOCA") = 0
    '                    oDr.Item("NUMOCO") = 0
    '                    oDr.Item("NUMOCT") = 0
    '                    oDr.Item("PESOA") = 0
    '                    oDr.Item("PESOO") = 0
    '                    oDr.Item("PESOT") = Double.Parse(oDt_Aux.Rows(intCont).Item("PESO").ToString)
    '                    oDr.Item("TOTOCORI") = 0
    '            End Select
    '            oDt_Origen.Rows.Add(oDr)
    '        Else
    '            Select Case oDt_Aux.Rows(intCont).Item("CMEDTR").ToString.Trim
    '                Case 1
    '                    oDt_Origen.Rows(intFila).Item("PESOA") = Double.Parse(oDt_Origen.Rows(intFila).Item("PESOA")) + Double.Parse(oDt_Aux.Rows(intCont).Item("PESO").ToString)
    '                Case 2
    '                    oDt_Origen.Rows(intFila).Item("PESOO") = Double.Parse(oDt_Origen.Rows(intFila).Item("PESOO")) + Double.Parse(oDt_Aux.Rows(intCont).Item("PESO").ToString)
    '                Case 4
    '                    oDt_Origen.Rows(intFila).Item("PESOT") = Double.Parse(oDt_Origen.Rows(intFila).Item("PESOT")) + Double.Parse(oDt_Aux.Rows(intCont).Item("PESO").ToString)
    '            End Select
    '        End If
    '    Next intCont
    '    Return oDt_Origen
    'End Function

    Private Function Dame_Fila(ByVal pobjDt As DataTable, ByVal pstrPais As String, ByVal pstrCiudad As String) As Double
        Dim intCont As Integer
        Dim intFila As Integer = -1

        For intCont = 0 To pobjDt.Rows.Count - 1
            If pstrPais = "ESTADOS UNIDOS" Then
                If pstrCiudad = pobjDt.Rows(intCont).Item("ORIGEN").ToString.Trim Then
                    intFila = intCont
                    Exit For
                End If
            Else
                If pstrPais = pobjDt.Rows(intCont).Item("ORIGEN").ToString.Trim Then
                    intFila = intCont
                    Exit For
                End If
            End If
        Next intCont
        Return intFila
    End Function

    'Public Sub Obtener_Informacion_General_Aduanas(ByVal pdblCliente As Double, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double, ByVal PSTPSRVA As String)
    '    Dim oAux As DataTable
    '    Dim dblFecIniAnho As Double
    '    Dim dblCant As Double
    '    Dim oDr As DataRow

    '    Formato_Aduanas_General()
    '    oAux = oReporte.dtRep3PLDatosAduanasGeneral(pdblCliente, pdblFecIni, pdblFecFin, PSTPSRVA)
    '    oDr = oDt_General.NewRow
    '    dblCant = oAux.Rows(0).Item("NUMOC")
    '    oDr.Item("OCMES") = dblCant
    '    dblCant = oAux.Rows(0).Item("ITTCIF")
    '    oDr.Item("CIFMES") = dblCant
    '    dblFecIniAnho = Mid(pdblFecFin, 1, 4) & "01" & "01"
    '    oAux = oReporte.dtRep3PLDatosAduanasGeneral(pdblCliente, dblFecIniAnho, pdblFecFin, PSTPSRVA)
    '    dblCant = oAux.Rows(0).Item("NUMOC")
    '    oDr.Item("OCANHO") = dblCant
    '    dblCant = oAux.Rows(0).Item("ITTCIF")
    '    oDr.Item("CIFANHO") = dblCant
    '    oDt_General.Rows.Add(oDr)

    'End Sub

    Public Sub Obtener_Informacion_General_Aduanas(ByVal dtDatosAduana As DataTable, ByVal dtAduanaAdicional As DataTable, ByVal pdblCliente As Double, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double)
        Dim oAux As DataTable
        Dim dblFecIniAnho As Double
        Dim dblCant As Double
        Dim oDr As DataRow

        Formato_Aduanas_General()
        'oAux = oReporte.dtRep3PLDatosAduanasGeneral(pdblCliente, pdblFecIni, pdblFecFin, PSTPSRVA)
        'oAux = oReporte.dtRep3PLDatosAduanasGeneral(pdblCliente, pdblFecIni, pdblFecFin)
        oAux = dtDatosAduana.Copy
        oDr = oDt_General.NewRow
        dblCant = oAux.Rows(0).Item("NUMOC")
        oDr.Item("OCMES") = dblCant
        dblCant = oAux.Rows(0).Item("ITTCIF")
        oDr.Item("CIFMES") = dblCant
        dblFecIniAnho = Mid(pdblFecFin, 1, 4) & "01" & "01"
        'oAux = oReporte.dtRep3PLDatosAduanasGeneral(pdblCliente, dblFecIniAnho, pdblFecFin, PSTPSRVA)
        'oAux = oReporte.dtRep3PLDatosAduanasGeneral(pdblCliente, dblFecIniAnho, pdblFecFin)
        oAux = dtAduanaAdicional.Copy
        dblCant = oAux.Rows(0).Item("NUMOC")
        oDr.Item("OCANHO") = dblCant
        dblCant = oAux.Rows(0).Item("ITTCIF")
        oDr.Item("CIFANHO") = dblCant
        oDt_General.Rows.Add(oDr)

    End Sub

    'Public Sub Obtener_Datos_Aduanas(ByVal pdblCliente As Double, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double, ByVal PSTPSRVA As String)
    '    Dim oDt_Aux As DataTable
    '    Dim intCont As Integer

    '    strMenError = ""
    '    dblNormal = 0
    '    dblAnticipated = 0
    '    dblUrgent = 0
    '    dblGreen = 0
    '    dblOrange = 0
    '    dblRed = 0
    '    oDt_Aux = oReporte.dtRep3PLDatosAduanas(pdblCliente, pdblFecIni, pdblFecFin, PSTPSRVA)
    '    For intCont = 0 To oDt_Aux.Rows.Count - 1
    '        Select Case oDt_Aux.Rows(intCont).Item("NCODRG").ToString.Trim
    '            Case "1"
    '                dblNormal = dblNormal + 1
    '            Case "2"
    '                dblAnticipated = dblAnticipated + 1
    '            Case "3"
    '                dblUrgent = dblUrgent + 1
    '        End Select
    '        If Not IsDBNull(oDt_Aux.Rows(intCont).Item("TCANAL")) Then
    '            Select Case oDt_Aux.Rows(intCont).Item("TCANAL").ToString.Trim
    '                Case "VERDE"
    '                    dblGreen = dblGreen + 1
    '                Case "NARANJA"
    '                    dblOrange = dblOrange + 1
    '                Case "ROJO"
    '                    dblRed = dblRed + 1
    '                Case ""
    '                    If strMenError.Trim = "" Then
    '                        strMenError = "Los sgtes. Embarques no tienen registrado el Canal :" & vbCrLf & oDt_Aux.Rows(intCont).Item("NORSCI")
    '                    Else
    '                        strMenError = strMenError & vbCrLf & oDt_Aux.Rows(intCont).Item("NORSCI")
    '                    End If
    '            End Select
    '        Else
    '            If strMenError.Trim = "" Then
    '                strMenError = "Las sgtes. Embarque no tienen registrado el Canal :" & vbCrLf & oDt_Aux.Rows(intCont).Item("NORSCI")
    '            Else
    '                strMenError = strMenError & vbCrLf & oDt_Aux.Rows(intCont).Item("NORSCI")
    '            End If
    '        End If
    '    Next intCont
    'End Sub

    Public Sub Obtener_Datos_Aduanas(ByVal dtDatosAduana As DataTable, ByVal pdblCliente As Double, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double)
        Dim oDt_Aux As DataTable
        Dim intCont As Integer

        strMenError = ""
        dblNormal = 0
        dblAnticipated = 0
        dblUrgent = 0
        dblGreen = 0
        dblOrange = 0
        dblRed = 0
        ' oDt_Aux = oReporte.dtRep3PLDatosAduanas(pdblCliente, pdblFecIni, pdblFecFin)
        oDt_Aux = dtDatosAduana.Copy
        For intCont = 0 To oDt_Aux.Rows.Count - 1
            Select Case oDt_Aux.Rows(intCont).Item("NCODRG").ToString.Trim
                Case "1"
                    dblNormal = dblNormal + 1
                Case "2"
                    dblAnticipated = dblAnticipated + 1
                Case "3"
                    dblUrgent = dblUrgent + 1
            End Select
            If Not IsDBNull(oDt_Aux.Rows(intCont).Item("TCANAL")) Then
                Select Case oDt_Aux.Rows(intCont).Item("TCANAL").ToString.Trim
                    Case "VERDE"
                        dblGreen = dblGreen + 1
                    Case "NARANJA"
                        dblOrange = dblOrange + 1
                    Case "ROJO"
                        dblRed = dblRed + 1
                    Case ""
                        If strMenError.Trim = "" Then
                            strMenError = "Los sgtes. Embarques no tienen registrado el Canal :" & vbCrLf & oDt_Aux.Rows(intCont).Item("NORSCI")
                        Else
                            strMenError = strMenError & vbCrLf & oDt_Aux.Rows(intCont).Item("NORSCI")
                        End If
                End Select
            Else
                If strMenError.Trim = "" Then
                    strMenError = "Las sgtes. Embarque no tienen registrado el Canal :" & vbCrLf & oDt_Aux.Rows(intCont).Item("NORSCI")
                Else
                    strMenError = strMenError & vbCrLf & oDt_Aux.Rows(intCont).Item("NORSCI")
                End If
            End If
        Next intCont
    End Sub


    Public Function Obtener_Datos_Mes() As DataTable
        Dim oDr() As DataRow
        Dim oDr_New As DataRow

        Formato_Ordenes_Mes()
        oDr = oDt.Select("MES='Dic-08'")
        If oDr.Length > 0 Then
            If Integer.Parse(oDr(0).Item("NUMOCA").ToString.Trim) > 0 Then
                oDr_New = oDt_POMes.NewRow
                oDr_New.Item("TIPO") = "AEREO"
                oDr_New.Item("NUMOC") = Integer.Parse(oDr(0).Item("NUMOCA").ToString.Trim)
                oDt_POMes.Rows.Add(oDr_New)
            End If
            If Integer.Parse(oDr(0).Item("NUMOCO").ToString.Trim) > 0 Then
                oDr_New = oDt_POMes.NewRow
                oDr_New.Item("TIPO") = "MARITIMO"
                oDr_New.Item("NUMOC") = Integer.Parse(oDr(0).Item("NUMOCO").ToString.Trim)
                oDt_POMes.Rows.Add(oDr_New)
            End If
            If Integer.Parse(oDr(0).Item("NUMOCT").ToString.Trim) > 0 Then
                oDr_New = oDt_POMes.NewRow
                oDr_New.Item("TIPO") = "TERRESTRE"
                oDr_New.Item("NUMOC") = Integer.Parse(oDr(0).Item("NUMOCT").ToString.Trim)
                oDt_POMes.Rows.Add(oDr_New)
            End If
        End If
        Return oDt_POMes
    End Function


    Public Function Obtener_Datos_3PL_Unificado(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal PNCCLNT As Decimal, ByVal PNANOALF As Decimal, ByVal PNFECINI As Decimal, ByVal PNFECFIN As Decimal, ByVal PNFECINI_ANIO As Decimal, ByVal PSLISTAREGIMEN As String) As DataSet
        Dim ds As New DataSet
        ds = oReporte.Obtener_Datos_3PL_Unificado(PSCCMPN, PSCDVSN, PNCCLNT, PNANOALF, PNFECINI, PNFECFIN, PNFECINI_ANIO, PSLISTAREGIMEN)
        Return ds.Copy
    End Function
End Class
