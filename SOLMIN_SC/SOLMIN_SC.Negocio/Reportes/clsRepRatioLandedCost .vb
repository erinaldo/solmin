Imports SOLMIN_SC.Entidad
Imports System.Reflection
Imports Ransa.Utilitario
Imports System.Text
Public Class clsRepRatioLandedCost

    Enum ICOTERM_BASE
        ICOTERM_BASE_EXW
        ICOTERM_BASE_FOB
        ICOTERM_BASE_CIF
    End Enum

    Private oReporteRatioLand As New Datos.clsRepRatioLandedCost
    Public obeTotCostosRatio As beCostosRatioTotales
    Private PNCPAIS As Decimal = 0
    Private PSCODZONA As String = ""
    Private PSCODPUERTO As String = ""

    Public odtCuadroCostosXZona As New DataTable
    Public odtCuadroCostosXPuerto As New DataTable
    Public oListCostosRatioLandedZona As New List(Of beCostosRatioLandedZona)
    Public oListCostosRatioLandedPuerto As New List(Of beCostosRatioLandedPuerto)
    Public lobjDtRep As New DataTable


    Private _pICOTERM_BASE As ICOTERM_BASE = ICOTERM_BASE.ICOTERM_BASE_FOB
    Private ListaCostos As New SortedList
    Private oListZonaEmbarque As New List(Of ZonaEmbarque_BE)
    Public Property pICOTERM_BASE() As ICOTERM_BASE
        Get
            Return _pICOTERM_BASE
        End Get
        Set(ByVal value As ICOTERM_BASE)
            _pICOTERM_BASE = value
        End Set
    End Property

    Private _PNCCLNT As Decimal = 0
    Sub New()
        pICOTERM_BASE = ICOTERM_BASE.ICOTERM_BASE_FOB 'ICOTERM POR DEFECTO
        Dim olistaColumnaPais As New SortedList
        Dim oListaColumnaZona As New SortedList
        Dim oListaColumnaPuerto As New SortedList

        olistaColumnaPais.Clear()
        oListaColumnaZona.Clear()

        oListaColumnaZona("A") = "CODIGO_ZONA/System.String"
        oListaColumnaZona("B") = "ZONA/System.String"
        oListaColumnaZona("C") = "CODIGO_COSTO/System.String"
        oListaColumnaZona("D") = "COSTO/System.String"
        oListaColumnaZona("F") = "MARITIMO/System.Decimal"
        oListaColumnaZona("G") = "AEREO/System.Decimal"
        oListaColumnaZona("H") = "TERRESTRE/System.Decimal"
        oListaColumnaZona("I") = "QMARITIMO/System.Decimal"
        oListaColumnaZona("J") = "QAEREO/System.Decimal"
        oListaColumnaZona("K") = "QTERRESTRE/System.Decimal"


        olistaColumnaPais("A") = "CODIGO_PAIS/System.String"
        olistaColumnaPais("B") = "PAIS/System.String"
        olistaColumnaPais("C") = "CODIGO_COSTO/System.String"
        olistaColumnaPais("D") = "COSTO/System.String"
        olistaColumnaPais("F") = "MARITIMO/System.Decimal"
        olistaColumnaPais("G") = "AEREO/System.Decimal"
        olistaColumnaPais("H") = "TERRESTRE/System.Decimal"
        olistaColumnaPais("I") = "QMARITIMO/System.Decimal"
        olistaColumnaPais("J") = "QAEREO/System.Decimal"
        olistaColumnaPais("K") = "QTERRESTRE/System.Decimal"

        oListaColumnaPuerto("A") = "CODIGO_ZONA/System.String"
        oListaColumnaPuerto("B") = "ZONA/System.String"
        oListaColumnaPuerto("C") = "CODIGO_PAIS/System.String"
        oListaColumnaPuerto("D") = "PAIS/System.String"
        oListaColumnaPuerto("E") = "CODIGO_PUERTO/System.String"
        oListaColumnaPuerto("F") = "PUERTO/System.String"
        oListaColumnaPuerto("G") = "CODIGO_COSTO/System.String"
        oListaColumnaPuerto("H") = "COSTO/System.String"
        oListaColumnaPuerto("J") = "MARITIMO/System.Decimal"
        oListaColumnaPuerto("K") = "AEREO/System.Decimal"
        oListaColumnaPuerto("L") = "TERRESTRE/System.Decimal"
        oListaColumnaPuerto("M") = "QMARITIMO/System.Decimal"
        oListaColumnaPuerto("N") = "QAEREO/System.Decimal"
        oListaColumnaPuerto("O") = "QTERRESTRE/System.Decimal"


        ListaCostos("A") = "INLAD/Inlad Freight"
        ListaCostos("B") = "GFOB/Costos Ad-Origen"
        ListaCostos("C") = "FLETE/Flete"
        ListaCostos("D") = "DUTIES/Duties"
        ListaCostos("E") = "COSTOS_ADICIONAL/Costos Adicionales"


        Dim COSTOS() As String
        For Each e As DictionaryEntry In oListaColumnaZona
            COSTOS = e.Value.ToString.Split("/")
            odtCuadroCostosXZona.Columns.Add(COSTOS(0), Type.GetType(COSTOS(1)))
        Next
        For Each e As DictionaryEntry In oListaColumnaPuerto
            COSTOS = e.Value.ToString.Split("/")
            odtCuadroCostosXPuerto.Columns.Add(COSTOS(0), Type.GetType(COSTOS(1)))
        Next
        obeTotCostosRatio = New beCostosRatioTotales
        fdtFormatoRepMenAD(lobjDtRep)
    End Sub
    Private Sub fdtFormatoRepMenAD(ByRef pobjDt As DataTable)
        pobjDt = New DataTable
        pobjDt.Columns.Add(New DataColumn("NORSCI", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("TCMPCL", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("NORCML", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("PNNMOS", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("REGIMEN", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("FDCCMP", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("DESPACHO", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("TNMMDT", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("NBLTAR", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("QPSOAR", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("FOB", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("FLETE", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("SEGURO", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("CIF", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("ADVALOREM", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("IGVPM", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("DUA", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("CANAL", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("NDIADN", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("DIFATETA", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("EXW", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("GFOB", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("OGASTOS", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("FAPRAR", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("FECALM", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("NCONTEN", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("TOTDER", GetType(System.Double)))
        '-----------------------------------------------------------------------
        pobjDt.Columns.Add(New DataColumn("DOCUMENTOS", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("DIFDOCUMENTOS", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("NUMERACION", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("DIFNUMERACION", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("DERECHOS", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("DIFDERECHOS", GetType(System.String)))

        pobjDt.Columns.Add(New DataColumn("ITTCAG", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("ITTGOA", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("INLAD", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("COSTOS_ADICIONAL", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("DUTIES", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("TCMPPS", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("CPAIS", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("CPRTOE", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("TCMPR1", GetType(System.String)))
    End Sub

    Private Function Sort_X_Pais(ByVal obeRatioLanded As beCostosRatioLanded, ByVal obeRatioLanded2 As beCostosRatioLanded) As Int32
        Return obeRatioLanded.PSTCMPPS.CompareTo(obeRatioLanded2.PSTCMPPS)
    End Function
  
    Private Function FindRatiolanded_X_Zona(ByVal obeRatioLanded As beCostosRatioLandedZona) As Boolean
        Return obeRatioLanded.PSCODZONA = PSCODZONA
    End Function

    Private Function Sort_X_Zona(ByVal obeRatioLanded As beCostosRatioLandedZona, ByVal obeRatioLanded2 As beCostosRatioLandedZona) As Int32
        Return obeRatioLanded.PSDESZONA.CompareTo(obeRatioLanded2.PSDESZONA)
    End Function

    Private Function SearchPais(ByVal obePaisEmb As ZonaEmbarque_BE) As Boolean
        Return (obePaisEmb.PNCPAIS = PNCPAIS)
    End Function

    Private Function FindRatiolanded_X_Puerto(ByVal obeCostosRatioLandedPuerto As beCostosRatioLandedPuerto) As Boolean
        Return (obeCostosRatioLandedPuerto.PSCODPUERTO = PSCODPUERTO And obeCostosRatioLandedPuerto.PSCPAIS = PNCPAIS.ToString)
    End Function


    Private Sub CalculoSumatoria_Costo(ByVal odtListaSeguimiento As DataTable)
        Dim odaZonasEmbarque As New Datos.clsZonasEmbarque
        Dim PNCPAIS_FIND As Decimal = 0
        Dim PSCODPUERTO_FIND As String = ""
        Dim PSTNMMDT_FIND As String = ""
        Dim obeZona As ZonaEmbarque_BE
        Dim obePuerto As ZonaEmbarque_BE
        Dim obePais As ZonaEmbarque_BE

        oListZonaEmbarque = odaZonasEmbarque.Lista_Zonas_X_Cliente(_PNCCLNT)

        Dim obeCostoFindratioZona As New beCostosRatioLandedZona
        Dim obeCostoFindratioPuerto As New beCostosRatioLandedPuerto

        For Each dr As DataRow In odtListaSeguimiento.Rows

            obeTotCostosRatio.PNTOT_ITTEXW += dr("EXW")
            obeTotCostosRatio.PNTOT_ITTFOB += dr("FOB")
            obeTotCostosRatio.PNTOT_ITTCIF += dr("CIF")

            obeTotCostosRatio.PNTOT_ITTINLAD += dr("INLAD")
            obeTotCostosRatio.PNTOT_ITTGFOB += dr("GFOB")
            obeTotCostosRatio.PNTOT_ITTFLETE += dr("FLETE")
            obeTotCostosRatio.PNTOT_ITTDUTIES += dr("DUTIES")
            obeTotCostosRatio.PNTOT_ITTCOSTOS_ADICIONAL += dr("COSTOS_ADICIONAL")

            PNCPAIS_FIND = dr("CPAIS")
            PSTNMMDT_FIND = dr("TNMMDT").ToString.Trim
            PSCODPUERTO_FIND = dr("CPRTOE").ToString.Trim

            PNCPAIS = PNCPAIS_FIND
            obeZona = oListZonaEmbarque.Find(AddressOf SearchPais)
            '*****************************************************************************************
            If (obeZona IsNot Nothing) Then
                PSCODZONA = obeZona.PSCZNAEM
            Else
                obeZona = New ZonaEmbarque_BE
                obeZona.PSCZNAEM = "Z-SIN"
                obeZona.PSTZNAEM = "SIN ZONA"
                PSCODZONA = obeZona.PSCZNAEM
            End If
            obeCostoFindratioZona = oListCostosRatioLandedZona.Find(AddressOf FindRatiolanded_X_Zona)
            If (obeCostoFindratioZona IsNot Nothing) Then
                obeCostoFindratioZona = Calculo_X_Medio_X_Zona(PSTNMMDT_FIND, obeCostoFindratioZona, dr)
            Else
                obeCostoFindratioZona = New beCostosRatioLandedZona
                obeCostoFindratioZona.PSCODZONA = obeZona.PSCZNAEM
                obeCostoFindratioZona.PSDESZONA = obeZona.PSTZNAEM
                obeCostoFindratioZona = Calculo_X_Medio_X_Zona(PSTNMMDT_FIND, obeCostoFindratioZona, dr)
                oListCostosRatioLandedZona.Add(obeCostoFindratioZona)
            End If
            '****************************************************************************************
            '************MODIFICACION POR PAIS*******************************************************
            obePais = New ZonaEmbarque_BE
            If (PNCPAIS_FIND = 0) Then
                obePais.PNCPAIS = 999999
                obePais.PSTCMPPS = "SIN PAIS"
                PNCPAIS = obePais.PNCPAIS  'ADICIONADO 
            Else
                obePais.PNCPAIS = dr("CPAIS")
                obePais.PSTCMPPS = dr("TCMPPS").ToString.Trim
                PNCPAIS = obePais.PNCPAIS
            End If
            '****************************************************************************************
            '*********modificacion por puerto***************************************************9****

            obePuerto = New ZonaEmbarque_BE
            If (PSCODPUERTO_FIND = "") Then
                obePuerto.PSCPRTOE = "Z-SINP"
                obePuerto.PSTCMPR1 = "SIN PUERTO"
                PSCODPUERTO = obePuerto.PSCPRTOE
            Else
                obePuerto.PSCPRTOE = dr("CPRTOE").ToString.Trim
                obePuerto.PSTCMPR1 = dr("TCMPR1").ToString.Trim
                PSCODPUERTO = obePuerto.PSCPRTOE
            End If
            obeCostoFindratioPuerto = oListCostosRatioLandedPuerto.Find(AddressOf FindRatiolanded_X_Puerto)
            If (obeCostoFindratioPuerto IsNot Nothing) Then
                obeCostoFindratioPuerto = Calculo_X_Medio_X_Puerto(PSTNMMDT_FIND, obeCostoFindratioPuerto, dr)
            Else
                obeCostoFindratioPuerto = New beCostosRatioLandedPuerto
                obeCostoFindratioPuerto.PSCODZONA = obeZona.PSCZNAEM
                obeCostoFindratioPuerto.PSDESZONA = obeZona.PSTZNAEM
                obeCostoFindratioPuerto.PSCODPUERTO = obePuerto.PSCPRTOE
                obeCostoFindratioPuerto.PSDESPUERTO = obePuerto.PSTCMPR1
                obeCostoFindratioPuerto.PSCPAIS = obePais.PNCPAIS
                obeCostoFindratioPuerto.PSTCMPPS = obePais.PSTCMPPS
                obeCostoFindratioPuerto = Calculo_X_Medio_X_Puerto(PSTNMMDT_FIND, obeCostoFindratioPuerto, dr)
                oListCostosRatioLandedPuerto.Add(obeCostoFindratioPuerto)
            End If         
            '*********************************************************************************************
        Next
        oListCostosRatioLandedZona.Sort(AddressOf Sort_X_Zona)
    End Sub

    Private Function Calculo_X_Medio_X_Puerto(ByVal PSTNMMDT As String, ByVal obeCostoFindratioPuerto As beCostosRatioLandedPuerto, ByVal dr As DataRow) As beCostosRatioLandedPuerto
        Select Case PSTNMMDT
            Case "MARITIMO"
                obeCostoFindratioPuerto.PNMARITMO.PNINLAD += dr("INLAD")
                obeCostoFindratioPuerto.PNMARITMO.PNGFOB += dr("GFOB")
                obeCostoFindratioPuerto.PNMARITMO.PNFLETE += dr("FLETE")
                obeCostoFindratioPuerto.PNMARITMO.PNDUTIES += dr("DUTIES")
                obeCostoFindratioPuerto.PNMARITMO.PNCOSTOS_ADICIONAL += dr("COSTOS_ADICIONAL")
            Case "AEREO"
                obeCostoFindratioPuerto.PNAEREO.PNINLAD += dr("INLAD")
                obeCostoFindratioPuerto.PNAEREO.PNGFOB += dr("GFOB")
                obeCostoFindratioPuerto.PNAEREO.PNFLETE += dr("FLETE")
                obeCostoFindratioPuerto.PNAEREO.PNDUTIES += dr("DUTIES")
                obeCostoFindratioPuerto.PNAEREO.PNCOSTOS_ADICIONAL += dr("COSTOS_ADICIONAL")
            Case "TERRESTRE"
                obeCostoFindratioPuerto.PNTERRESTRE.PNINLAD += dr("INLAD")
                obeCostoFindratioPuerto.PNTERRESTRE.PNGFOB += dr("GFOB")
                obeCostoFindratioPuerto.PNTERRESTRE.PNFLETE += dr("FLETE")
                obeCostoFindratioPuerto.PNTERRESTRE.PNDUTIES += dr("DUTIES")
                obeCostoFindratioPuerto.PNTERRESTRE.PNCOSTOS_ADICIONAL += dr("COSTOS_ADICIONAL")
        End Select
        Return obeCostoFindratioPuerto
    End Function

    Private Function Calculo_X_Medio_X_Zona(ByVal PSTNMMDT As String, ByVal obeCostoFindratioZona As beCostosRatioLandedZona, ByVal dr As DataRow) As beCostosRatioLandedZona
        Select Case PSTNMMDT
            Case "MARITIMO"
                obeCostoFindratioZona.PNMARITMO.PNINLAD += dr("INLAD")
                obeCostoFindratioZona.PNMARITMO.PNGFOB += dr("GFOB")
                obeCostoFindratioZona.PNMARITMO.PNFLETE += dr("FLETE")
                obeCostoFindratioZona.PNMARITMO.PNDUTIES += dr("DUTIES")
                obeCostoFindratioZona.PNMARITMO.PNCOSTOS_ADICIONAL += dr("COSTOS_ADICIONAL")
            Case "AEREO"
                obeCostoFindratioZona.PNAEREO.PNINLAD += dr("INLAD")
                obeCostoFindratioZona.PNAEREO.PNGFOB += dr("GFOB")
                obeCostoFindratioZona.PNAEREO.PNFLETE += dr("FLETE")
                obeCostoFindratioZona.PNAEREO.PNDUTIES += dr("DUTIES")
                obeCostoFindratioZona.PNAEREO.PNCOSTOS_ADICIONAL += dr("COSTOS_ADICIONAL")
            Case "TERRESTRE"
                obeCostoFindratioZona.PNTERRESTRE.PNINLAD += dr("INLAD")
                obeCostoFindratioZona.PNTERRESTRE.PNGFOB += dr("GFOB")
                obeCostoFindratioZona.PNTERRESTRE.PNFLETE += dr("FLETE")
                obeCostoFindratioZona.PNTERRESTRE.PNDUTIES += dr("DUTIES")
                obeCostoFindratioZona.PNTERRESTRE.PNCOSTOS_ADICIONAL += dr("COSTOS_ADICIONAL")
        End Select
        Return obeCostoFindratioZona
    End Function


    Private Sub ElborarCuadroCosto_X_Puerto()
        Dim dr As DataRow
        odtCuadroCostosXPuerto.Rows.Clear()
        Dim numDecimales As Int32 = 2
        Dim COSTOS() As String
        For Each itemCosto As beCostosRatioLandedPuerto In oListCostosRatioLandedPuerto
            For Each e As DictionaryEntry In ListaCostos
                COSTOS = e.Value.ToString.Split("/")
                dr = odtCuadroCostosXPuerto.NewRow
                dr("CODIGO_ZONA") = itemCosto.PSCODZONA
                dr("ZONA") = itemCosto.PSDESZONA
                dr("CODIGO_PAIS") = itemCosto.PSCPAIS
                dr("PAIS") = itemCosto.PSTCMPPS
                dr("CODIGO_PUERTO") = itemCosto.PSCODPUERTO
                dr("PUERTO") = itemCosto.PSDESPUERTO
                dr("CODIGO_COSTO") = COSTOS(0)
                dr("COSTO") = COSTOS(1)
                Select Case COSTOS(0)
                    Case "INLAD"
                        dr("MARITIMO") = Math.Round(itemCosto.PNMARITMO.PNINLAD_X100, numDecimales)
                        dr("AEREO") = Math.Round(itemCosto.PNAEREO.PNINLAD_X100, numDecimales)
                        dr("TERRESTRE") = Math.Round(itemCosto.PNTERRESTRE.PNINLAD_X100, numDecimales)

                        dr("QMARITIMO") = Math.Round(itemCosto.PNMARITMO.PNINLAD, numDecimales)
                        dr("QAEREO") = Math.Round(itemCosto.PNAEREO.PNINLAD, numDecimales)
                        dr("QTERRESTRE") = Math.Round(itemCosto.PNTERRESTRE.PNINLAD, numDecimales)

                    Case "GFOB"
                        dr("MARITIMO") = Math.Round(itemCosto.PNMARITMO.PNGFOB_X100, numDecimales)
                        dr("AEREO") = Math.Round(itemCosto.PNAEREO.PNGFOB_X100, numDecimales)
                        dr("TERRESTRE") = Math.Round(itemCosto.PNTERRESTRE.PNGFOB_X100, numDecimales)

                        dr("QMARITIMO") = Math.Round(itemCosto.PNMARITMO.PNGFOB, numDecimales)
                        dr("QAEREO") = Math.Round(itemCosto.PNAEREO.PNGFOB, numDecimales)
                        dr("QTERRESTRE") = Math.Round(itemCosto.PNTERRESTRE.PNGFOB, numDecimales)

                    Case "FLETE"
                        dr("MARITIMO") = Math.Round(itemCosto.PNMARITMO.PNFLETE_X100, numDecimales)
                        dr("AEREO") = Math.Round(itemCosto.PNAEREO.PNFLETE_X100, numDecimales)
                        dr("TERRESTRE") = Math.Round(itemCosto.PNTERRESTRE.PNFLETE_X100, numDecimales)

                        dr("QMARITIMO") = Math.Round(itemCosto.PNMARITMO.PNFLETE, numDecimales)
                        dr("QAEREO") = Math.Round(itemCosto.PNAEREO.PNFLETE, numDecimales)
                        dr("QTERRESTRE") = Math.Round(itemCosto.PNTERRESTRE.PNFLETE, numDecimales)

                    Case "DUTIES"
                        dr("MARITIMO") = Math.Round(itemCosto.PNMARITMO.PNDUTIES_X100, numDecimales)
                        dr("AEREO") = Math.Round(itemCosto.PNAEREO.PNDUTIES_X100, numDecimales)
                        dr("TERRESTRE") = Math.Round(itemCosto.PNTERRESTRE.PNDUTIES_X100, numDecimales)

                        dr("QMARITIMO") = Math.Round(itemCosto.PNMARITMO.PNDUTIES, numDecimales)
                        dr("QAEREO") = Math.Round(itemCosto.PNAEREO.PNDUTIES, numDecimales)
                        dr("QTERRESTRE") = Math.Round(itemCosto.PNTERRESTRE.PNDUTIES, numDecimales)

                    Case "COSTOS_ADICIONAL"
                        dr("MARITIMO") = Math.Round(itemCosto.PNMARITMO.PNCOSTOS_ADICIONAL_X100, numDecimales)
                        dr("AEREO") = Math.Round(itemCosto.PNAEREO.PNCOSTOS_ADICIONAL_X100, numDecimales)
                        dr("TERRESTRE") = Math.Round(itemCosto.PNTERRESTRE.PNCOSTOS_ADICIONAL_X100, numDecimales)

                        dr("QMARITIMO") = Math.Round(itemCosto.PNMARITMO.PNCOSTOS_ADICIONAL, numDecimales)
                        dr("QAEREO") = Math.Round(itemCosto.PNAEREO.PNCOSTOS_ADICIONAL, numDecimales)
                        dr("QTERRESTRE") = Math.Round(itemCosto.PNTERRESTRE.PNCOSTOS_ADICIONAL, numDecimales)

                End Select
                odtCuadroCostosXPuerto.Rows.Add(dr)
            Next
        Next
    End Sub

    Private Sub ElborarCuadroCosto_X_Zona()
        Dim dr As DataRow
        odtCuadroCostosXZona.Rows.Clear()
        Dim numDecimales As Int32 = 2
        Dim COSTOS() As String
        For Each itemCosto As beCostosRatioLandedZona In oListCostosRatioLandedZona
            For Each e As DictionaryEntry In ListaCostos
                COSTOS = e.Value.ToString.Split("/")
                dr = odtCuadroCostosXZona.NewRow
                dr("CODIGO_ZONA") = itemCosto.PSCODZONA
                dr("ZONA") = itemCosto.PSDESZONA
                dr("CODIGO_COSTO") = COSTOS(0)
                dr("COSTO") = COSTOS(1)
                Select Case COSTOS(0)
                    Case "INLAD"
                        dr("MARITIMO") = Math.Round(itemCosto.PNMARITMO.PNINLAD_X100, numDecimales)
                        dr("AEREO") = Math.Round(itemCosto.PNAEREO.PNINLAD_X100, numDecimales)
                        dr("TERRESTRE") = Math.Round(itemCosto.PNTERRESTRE.PNINLAD_X100, numDecimales)

                        dr("QMARITIMO") = Math.Round(itemCosto.PNMARITMO.PNINLAD, numDecimales)
                        dr("QAEREO") = Math.Round(itemCosto.PNAEREO.PNINLAD, numDecimales)
                        dr("QTERRESTRE") = Math.Round(itemCosto.PNTERRESTRE.PNINLAD, numDecimales)

                    Case "GFOB"
                        dr("MARITIMO") = Math.Round(itemCosto.PNMARITMO.PNGFOB_X100, numDecimales)
                        dr("AEREO") = Math.Round(itemCosto.PNAEREO.PNGFOB_X100, numDecimales)
                        dr("TERRESTRE") = Math.Round(itemCosto.PNTERRESTRE.PNGFOB_X100, numDecimales)

                        dr("QMARITIMO") = Math.Round(itemCosto.PNMARITMO.PNGFOB, numDecimales)
                        dr("QAEREO") = Math.Round(itemCosto.PNAEREO.PNGFOB, numDecimales)
                        dr("QTERRESTRE") = Math.Round(itemCosto.PNTERRESTRE.PNGFOB, numDecimales)

                    Case "FLETE"
                        dr("MARITIMO") = Math.Round(itemCosto.PNMARITMO.PNFLETE_X100, numDecimales)
                        dr("AEREO") = Math.Round(itemCosto.PNAEREO.PNFLETE_X100, numDecimales)
                        dr("TERRESTRE") = Math.Round(itemCosto.PNTERRESTRE.PNFLETE_X100, numDecimales)

                        dr("QMARITIMO") = Math.Round(itemCosto.PNMARITMO.PNFLETE, numDecimales)
                        dr("QAEREO") = Math.Round(itemCosto.PNAEREO.PNFLETE, numDecimales)
                        dr("QTERRESTRE") = Math.Round(itemCosto.PNTERRESTRE.PNFLETE, numDecimales)

                    Case "DUTIES"
                        dr("MARITIMO") = Math.Round(itemCosto.PNMARITMO.PNDUTIES_X100, numDecimales)
                        dr("AEREO") = Math.Round(itemCosto.PNAEREO.PNDUTIES_X100, numDecimales)
                        dr("TERRESTRE") = Math.Round(itemCosto.PNTERRESTRE.PNDUTIES_X100, numDecimales)

                        dr("QMARITIMO") = Math.Round(itemCosto.PNMARITMO.PNDUTIES, numDecimales)
                        dr("QAEREO") = Math.Round(itemCosto.PNAEREO.PNDUTIES, numDecimales)
                        dr("QTERRESTRE") = Math.Round(itemCosto.PNTERRESTRE.PNDUTIES, numDecimales)

                    Case "COSTOS_ADICIONAL"
                        dr("MARITIMO") = Math.Round(itemCosto.PNMARITMO.PNCOSTOS_ADICIONAL_X100, numDecimales)
                        dr("AEREO") = Math.Round(itemCosto.PNAEREO.PNCOSTOS_ADICIONAL_X100, numDecimales)
                        dr("TERRESTRE") = Math.Round(itemCosto.PNTERRESTRE.PNCOSTOS_ADICIONAL_X100, numDecimales)

                        dr("QMARITIMO") = Math.Round(itemCosto.PNMARITMO.PNCOSTOS_ADICIONAL, numDecimales)
                        dr("QAEREO") = Math.Round(itemCosto.PNAEREO.PNCOSTOS_ADICIONAL, numDecimales)
                        dr("QTERRESTRE") = Math.Round(itemCosto.PNTERRESTRE.PNCOSTOS_ADICIONAL, numDecimales)

                End Select
                odtCuadroCostosXZona.Rows.Add(dr)
            Next
        Next
    End Sub

    'Private Function fValidaContenedorBulto(ByVal oDr As DataRow) As Boolean
    '    If oDr.Item("NCODRG").ToString.Trim = "1" Or oDr.Item("NCODRG").ToString.Trim = "11" _
    '        Or oDr.Item("NCODRG").ToString.Trim = "12" Or oDr.Item("NCODRG").ToString.Trim = "13" _
    '        Or oDr.Item("NCODRG").ToString.Trim = "14" Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function
    Private Function fValidaContenedorBulto(ByVal NCODRG As Decimal) As Boolean
        If NCODRG = 1 OrElse NCODRG = 11 _
            OrElse NCODRG = 12 OrElse NCODRG = 13 _
            OrElse NCODRG = 14 Then
            Return True
        Else
            Return False
        End If
    End Function

    'Private Sub PasarDatosAEstructuraReporte(ByVal lobjDt As DataTable)

    '    Dim lintcont As Integer = 0
    '    Dim dblEmbarque As Double = 0
    '    Dim lobjDr As DataRow
    '    For lintcont = 0 To lobjDt.Rows.Count - 1

    '        If dblEmbarque = Double.Parse(lobjDt.Rows(lintcont).Item("NORSCI").ToString) Then

    '            If IsDBNull(lobjDt.Rows(lintcont).Item("TCARGA")) Then
    '                If lobjDr.Item("NBLTAR") = vbNullString Then
    '                    lobjDr.Item("NBLTAR") = lobjDt.Rows(lintcont).Item("NBLTAR")
    '                Else
    '                    If Not IsDBNull(lobjDt.Rows(lintcont).Item("NBLTAR")) Then
    '                        lobjDr.Item("NBLTAR") = Double.Parse(lobjDr.Item("NBLTAR")) + Double.Parse(lobjDt.Rows(lintcont).Item("NBLTAR"))
    '                    End If
    '                End If
    '            Else
    '                If fValidaContenedorBulto(lobjDt.Rows(lintcont)) Then
    '                    If lobjDr.Item("NBLTAR").ToString = vbNullString Then
    '                        lobjDr.Item("NBLTAR") = lobjDt.Rows(lintcont).Item("NBLTAR")
    '                    Else
    '                        lobjDr.Item("NBLTAR") = Double.Parse(lobjDr.Item("NBLTAR").ToString) + Double.Parse(lobjDt.Rows(lintcont).Item("NBLTAR"))
    '                    End If
    '                Else
    '                    If lobjDr.Item("NCONTEN").ToString = vbNullString Then
    '                        lobjDr.Item("NCONTEN") = lobjDt.Rows(lintcont).Item("NBLTAR")
    '                    Else
    '                        lobjDr.Item("NCONTEN") = Double.Parse(lobjDr.Item("NCONTEN").ToString) + Double.Parse(lobjDt.Rows(lintcont).Item("NBLTAR"))
    '                    End If
    '                End If
    '            End If
    '            If lintcont = lobjDt.Rows.Count - 1 Then
    '                lobjDtRep.Rows.Add(lobjDr)
    '            End If
    '        Else
    '            dblEmbarque = Double.Parse(lobjDt.Rows(lintcont).Item("NORSCI").ToString)
    '            If lintcont > 0 Then
    '                lobjDtRep.Rows.Add(lobjDr)
    '            End If
    '            lobjDr = lobjDtRep.NewRow
    '            lobjDr.Item("TCMPCL") = ""
    '            lobjDr.Item("NORSCI") = lobjDt.Rows(lintcont).Item("NORSCI")
    '            lobjDr.Item("NORCML") = lobjDt.Rows(lintcont).Item("NORCML")
    '            lobjDr.Item("PNNMOS") = lobjDt.Rows(lintcont).Item("PNNMOS")
    '            lobjDr.Item("REGIMEN") = lobjDt.Rows(lintcont).Item("REGIMEN")
    '            lobjDr.Item("FDCCMP") = lobjDt.Rows(lintcont).Item("FDCCMP")
    '            lobjDr.Item("DESPACHO") = lobjDt.Rows(lintcont).Item("DESPACHO")
    '            lobjDr.Item("TNMMDT") = lobjDt.Rows(lintcont).Item("TNMMDT")
    '            If IsDBNull(lobjDt.Rows(lintcont).Item("TCARGA")) Then
    '                lobjDr.Item("NBLTAR") = lobjDt.Rows(lintcont).Item("NBLTAR")
    '            Else
    '                If fValidaContenedorBulto(lobjDt.Rows(lintcont)) Then
    '                    lobjDr.Item("NBLTAR") = lobjDt.Rows(lintcont).Item("NBLTAR")
    '                Else
    '                    lobjDr.Item("NCONTEN") = lobjDt.Rows(lintcont).Item("NBLTAR")
    '                End If
    '            End If
    '            lobjDr.Item("QPSOAR") = lobjDt.Rows(lintcont).Item("QPSOAR")
    '            lobjDr.Item("EXW") = lobjDt.Rows(lintcont).Item("ITTEXW")
    '            lobjDr.Item("GFOB") = lobjDt.Rows(lintcont).Item("ITGFOB")
    '            lobjDr.Item("FOB") = lobjDt.Rows(lintcont).Item("ITTFOB")
    '            lobjDr.Item("FLETE") = lobjDt.Rows(lintcont).Item("IVLFLT")
    '            lobjDr.Item("SEGURO") = lobjDt.Rows(lintcont).Item("IVLSGR")
    '            lobjDr.Item("CIF") = lobjDt.Rows(lintcont).Item("ITTCIF")
    '            lobjDr.Item("ADVALOREM") = lobjDt.Rows(lintcont).Item("ITTADV")
    '            lobjDr.Item("IGVPM") = lobjDt.Rows(lintcont).Item("IGVPM")
    '            lobjDr.Item("OGASTOS") = lobjDt.Rows(lintcont).Item("ITTOGS")
    '            lobjDr.Item("DUA") = lobjDt.Rows(lintcont).Item("DUA")
    '            lobjDr.Item("CANAL") = lobjDt.Rows(lintcont).Item("TCANAL")
    '            lobjDr.Item("FAPRAR") = lobjDt.Rows(lintcont).Item("FAPRAR")
    '            lobjDr.Item("FECALM") = lobjDt.Rows(lintcont).Item("ALMCLI")
    '            lobjDr.Item("TOTDER") = lobjDt.Rows(lintcont).Item("TOTAL")
    '            lobjDr.Item("DOCUMENTOS") = lobjDt.Rows(lintcont).Item("DOCUMENTOS")
    '            lobjDr.Item("NUMERACION") = lobjDt.Rows(lintcont).Item("NUMERACION")
    '            lobjDr.Item("DERECHOS") = lobjDt.Rows(lintcont).Item("DERECHOS")
    '            lobjDr.Item("CPAIS") = lobjDt.Rows(lintcont).Item("CPAIS")
    '            lobjDr.Item("TCMPPS") = lobjDt.Rows(lintcont).Item("TCMPPS")

    '            lobjDr.Item("ITTCAG") = lobjDt.Rows(lintcont).Item("ITTCAG")
    '            lobjDr.Item("ITTGOA") = lobjDt.Rows(lintcont).Item("ITTGOA")

    '            lobjDr.Item("INLAD") = lobjDt.Rows(lintcont).Item("INLAD")

    '            lobjDr.Item("COSTOS_ADICIONAL") = lobjDt.Rows(lintcont).Item("ITTOGS") + _
    '                                              lobjDt.Rows(lintcont).Item("ITTCAG") + _
    '                                              lobjDt.Rows(lintcont).Item("ITTGOA")

    '            lobjDr.Item("DUTIES") = lobjDt.Rows(lintcont).Item("ITTADV") + _
    '                                    lobjDt.Rows(lintcont).Item("IGVPM")

    '            lobjDr.Item("CPRTOE") = lobjDt.Rows(lintcont).Item("CPRTOE").ToString.Trim
    '            lobjDr.Item("TCMPR1") = lobjDt.Rows(lintcont).Item("TCMPR1").ToString.Trim

    '            If lintcont = lobjDt.Rows.Count - 1 Then
    '                lobjDtRep.Rows.Add(lobjDr)
    '            End If
    '        End If
    '    Next lintcont
    'End Sub




    Private Sub PasarDatosAEstructuraReporte(ByVal lobjDt As DataTable, ByVal dtCargaContenedor As DataTable)

        Dim lintcont As Integer = 0
        Dim NORSCI As Decimal = 0
        Dim lobjDr As DataRow
        Dim drCarga() As DataRow

        Dim numBultos As Int32 = 0
        Dim numContenedor As Int32 = 0

        For lintcont = 0 To lobjDt.Rows.Count - 1

            'If dblEmbarque = Double.Parse(lobjDt.Rows(lintcont).Item("NORSCI").ToString) Then

            'If IsDBNull(lobjDt.Rows(lintcont).Item("TCARGA")) Then
            '    If lobjDr.Item("NBLTAR") = vbNullString Then
            '        lobjDr.Item("NBLTAR") = lobjDt.Rows(lintcont).Item("NBLTAR")
            '    Else
            '        If Not IsDBNull(lobjDt.Rows(lintcont).Item("NBLTAR")) Then
            '            lobjDr.Item("NBLTAR") = Double.Parse(lobjDr.Item("NBLTAR")) + Double.Parse(lobjDt.Rows(lintcont).Item("NBLTAR"))
            '        End If
            '    End If
            'Else
            '    If fValidaContenedorBulto(lobjDt.Rows(lintcont)) Then
            '        If lobjDr.Item("NBLTAR").ToString = vbNullString Then
            '            lobjDr.Item("NBLTAR") = lobjDt.Rows(lintcont).Item("NBLTAR")
            '        Else
            '            lobjDr.Item("NBLTAR") = Double.Parse(lobjDr.Item("NBLTAR").ToString) + Double.Parse(lobjDt.Rows(lintcont).Item("NBLTAR"))
            '        End If
            '    Else
            '        If lobjDr.Item("NCONTEN").ToString = vbNullString Then
            '            lobjDr.Item("NCONTEN") = lobjDt.Rows(lintcont).Item("NBLTAR")
            '        Else
            '            lobjDr.Item("NCONTEN") = Double.Parse(lobjDr.Item("NCONTEN").ToString) + Double.Parse(lobjDt.Rows(lintcont).Item("NBLTAR"))
            '        End If
            '    End If
            'End If
            'If lintcont = lobjDt.Rows.Count - 1 Then
            '    lobjDtRep.Rows.Add(lobjDr)
            'End If
            'Else
            NORSCI = lobjDt.Rows(lintcont).Item("NORSCI")
            'If lintcont > 0 Then
            '    lobjDtRep.Rows.Add(lobjDr)
            'End If
            lobjDr = lobjDtRep.NewRow
            lobjDr.Item("TCMPCL") = ""
            lobjDr.Item("NORSCI") = lobjDt.Rows(lintcont).Item("NORSCI")
            lobjDr.Item("NORCML") = lobjDt.Rows(lintcont).Item("NORCML")
            lobjDr.Item("PNNMOS") = lobjDt.Rows(lintcont).Item("PNNMOS")
            lobjDr.Item("REGIMEN") = lobjDt.Rows(lintcont).Item("REGIMEN")
            lobjDr.Item("FDCCMP") = lobjDt.Rows(lintcont).Item("FDCCMP")
            lobjDr.Item("DESPACHO") = lobjDt.Rows(lintcont).Item("DESPACHO")
            lobjDr.Item("TNMMDT") = lobjDt.Rows(lintcont).Item("TNMMDT")
            'If IsDBNull(lobjDt.Rows(lintcont).Item("TCARGA")) Then
            '    lobjDr.Item("NBLTAR") = lobjDt.Rows(lintcont).Item("NBLTAR")
            'Else
            '    If fValidaContenedorBulto(lobjDt.Rows(lintcont)) Then
            '        lobjDr.Item("NBLTAR") = lobjDt.Rows(lintcont).Item("NBLTAR")
            '    Else
            '        lobjDr.Item("NCONTEN") = lobjDt.Rows(lintcont).Item("NBLTAR")
            '    End If
            'End If
            drCarga = dtCargaContenedor.Select("NORSCI='" & NORSCI & "'")
            numBultos = 0
            numContenedor = 0
            For FILA As Integer = 0 To drCarga.Length - 1
                If fValidaContenedorBulto(drCarga(FILA)("NCODRG")) Then
                    numBultos = numBultos + drCarga(FILA)("NBLTAR")
                Else
                    numContenedor = numContenedor + drCarga(FILA)("NBLTAR")
                End If
            Next
            If numBultos = 0 Then
                lobjDr.Item("NBLTAR") = DBNull.Value
            Else
                lobjDr.Item("NBLTAR") = numBultos
            End If
            If numContenedor = 0 Then
                lobjDr.Item("NCONTEN") = DBNull.Value
            Else
                lobjDr.Item("NCONTEN") = numContenedor
            End If
            lobjDr.Item("QPSOAR") = lobjDt.Rows(lintcont).Item("QPSOAR")
            lobjDr.Item("EXW") = lobjDt.Rows(lintcont).Item("ITTEXW")
            lobjDr.Item("GFOB") = lobjDt.Rows(lintcont).Item("ITGFOB")
            lobjDr.Item("FOB") = lobjDt.Rows(lintcont).Item("ITTFOB")
            lobjDr.Item("FLETE") = lobjDt.Rows(lintcont).Item("IVLFLT")
            lobjDr.Item("SEGURO") = lobjDt.Rows(lintcont).Item("IVLSGR")
            lobjDr.Item("CIF") = lobjDt.Rows(lintcont).Item("ITTCIF")
            lobjDr.Item("ADVALOREM") = lobjDt.Rows(lintcont).Item("ITTADV")
            lobjDr.Item("IGVPM") = lobjDt.Rows(lintcont).Item("IGVPM")
            lobjDr.Item("OGASTOS") = lobjDt.Rows(lintcont).Item("ITTOGS")
            lobjDr.Item("DUA") = lobjDt.Rows(lintcont).Item("DUA")
            lobjDr.Item("CANAL") = lobjDt.Rows(lintcont).Item("TCANAL")
            lobjDr.Item("FAPRAR") = lobjDt.Rows(lintcont).Item("FAPRAR")
            lobjDr.Item("FECALM") = lobjDt.Rows(lintcont).Item("ALMCLI")
            lobjDr.Item("TOTDER") = lobjDt.Rows(lintcont).Item("TOTAL")
            'lobjDr.Item("DOCUMENTOS") = lobjDt.Rows(lintcont).Item("DOCUMENTOS")
            'lobjDr.Item("NUMERACION") = lobjDt.Rows(lintcont).Item("NUMERACION")
            'lobjDr.Item("DERECHOS") = lobjDt.Rows(lintcont).Item("DERECHOS")
            lobjDr.Item("CPAIS") = lobjDt.Rows(lintcont).Item("CPAIS")
            lobjDr.Item("TCMPPS") = lobjDt.Rows(lintcont).Item("TCMPPS")

            lobjDr.Item("ITTCAG") = lobjDt.Rows(lintcont).Item("ITTCAG")
            lobjDr.Item("ITTGOA") = lobjDt.Rows(lintcont).Item("ITTGOA")

            lobjDr.Item("INLAD") = lobjDt.Rows(lintcont).Item("INLAD")

            lobjDr.Item("COSTOS_ADICIONAL") = lobjDt.Rows(lintcont).Item("ITTOGS") + _
                                              lobjDt.Rows(lintcont).Item("ITTCAG") + _
                                              lobjDt.Rows(lintcont).Item("ITTGOA")

            lobjDr.Item("DUTIES") = lobjDt.Rows(lintcont).Item("ITTADV") + _
                                    lobjDt.Rows(lintcont).Item("IGVPM")

            lobjDr.Item("CPRTOE") = lobjDt.Rows(lintcont).Item("CPRTOE").ToString.Trim
            lobjDr.Item("TCMPR1") = lobjDt.Rows(lintcont).Item("TCMPR1").ToString.Trim

            lobjDtRep.Rows.Add(lobjDr)
            'If lintcont = lobjDt.Rows.Count - 1 Then
            '    lobjDtRep.Rows.Add(lobjDr)
            'End If
            'End If
        Next lintcont
    End Sub


    Private Function CheckPointAduana(ByVal dtCheckPointAduana As DataTable, ByVal NORSCI As Decimal, ByVal NESTDO As Decimal) As String
        Dim dr() As DataRow
        Dim FechaFormat As String = ""
        dr = dtCheckPointAduana.Select("NORSCI='" & NORSCI & "' AND NESTDO='" & NESTDO & "'")
        If dr.Length > 0 Then
            FechaFormat = HelpClass.FechaNum_a_Fecha(dr(0)("FRETES"))
        End If
        Return FechaFormat
    End Function
    Private Function CostoAduana(ByVal dtCostoAduana As DataTable, ByVal NORSCI As Decimal, ByVal CODVAR As String) As Decimal
        Dim dr() As DataRow
        Dim Costo As Decimal = 0
        dr = dtCostoAduana.Select("NORSCI='" & NORSCI & "' AND CODVAR='" & CODVAR & "'")
        If dr.Length > 0 Then
            Costo = HelpClass.ObjectToDecimal(dr(0)("IVLDOL"))
        End If
        Return Costo
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
    Public Sub dtRepListaSeguimiento(ByVal PSCCMPN As String, ByVal PNCCLNT As Double, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double, ByVal PSTPSRVA As String, ByVal NESTDO As Decimal)
        _PNCCLNT = PNCCLNT
        Dim ds As New DataSet
        Dim lobjDt As New DataTable
        Dim dtCheckPoint As New DataTable
        Dim dtOrdenCompra As New DataTable
        Dim dtCostos As New DataTable
        Dim dtContenedor As New DataTable
        'lobjDt = oReporteRatioLand.dtRepListaSeguimiento(PSCCMPN, PNCCLNT, pdblFecIni, pdblFecFin, PSTPSRVA)

        ds = oReporteRatioLand.dtRepListaSeguimiento(PSCCMPN, PNCCLNT, pdblFecIni, pdblFecFin, PSTPSRVA, NESTDO)
        lobjDt = ds.Tables("DTOPERACION").Copy
        dtCheckPoint = ds.Tables("DTCHECKPOINT").Copy
        dtOrdenCompra = ds.Tables("DTORDENCOMPRA").Copy
        dtCostos = ds.Tables("DTCOSTOS").Copy
        dtContenedor = ds.Tables("DTCONTENEDOR").Copy


        lobjDt.Columns.Add("NORCML")
        lobjDt.Columns.Add("ITTCAG", Type.GetType("System.Decimal"))
        lobjDt.Columns.Add("ITTGOA", Type.GetType("System.Decimal"))
        lobjDt.Columns.Add("ITTEXW", Type.GetType("System.Decimal"))
        lobjDt.Columns.Add("ITGFOB", Type.GetType("System.Decimal"))
        lobjDt.Columns.Add("ITTFOB", Type.GetType("System.Decimal"))
        lobjDt.Columns.Add("IVLFLT", Type.GetType("System.Decimal"))
        lobjDt.Columns.Add("IVLSGR", Type.GetType("System.Decimal"))
        lobjDt.Columns.Add("ITTCIF", Type.GetType("System.Decimal"))
        lobjDt.Columns.Add("ITTADV", Type.GetType("System.Decimal"))
        lobjDt.Columns.Add("ITTOGS", Type.GetType("System.Decimal"))
        lobjDt.Columns.Add("IGVPM", Type.GetType("System.Decimal"))
        lobjDt.Columns.Add("TOTAL", Type.GetType("System.Decimal"))
        lobjDt.Columns.Add("INLAD", Type.GetType("System.Decimal"))

        lobjDt.Columns.Add("ALMCLI")
        lobjDt.Columns.Add("LEVANTE")
        'lobjDt.Columns.Add("VOLANTE")
        'lobjDt.Columns.Add("DOCUMENTOS")
        'lobjDt.Columns.Add("NUMERACION")
        'lobjDt.Columns.Add("DERECHOS")

        Dim NORSCI As Decimal = 0

        Dim OtrosCostos As Decimal = 0
        For Fila As Integer = 0 To lobjDt.Rows.Count - 1
            NORSCI = lobjDt.Rows(Fila)("NORSCI")
            lobjDt.Rows(Fila)("NORCML") = DistinctOrdenCompra(dtOrdenCompra, NORSCI)
            lobjDt.Rows(Fila)("ITTCAG") = CostoAduana(dtCostos, NORSCI, "ITTCAG")
            lobjDt.Rows(Fila)("ITTGOA") = CostoAduana(dtCostos, NORSCI, "ITTGOA")
            lobjDt.Rows(Fila)("ITTEXW") = CostoAduana(dtCostos, NORSCI, "ITTEXW")
            lobjDt.Rows(Fila)("ITGFOB") = CostoAduana(dtCostos, NORSCI, "GFOB")
            lobjDt.Rows(Fila)("ITTFOB") = CostoAduana(dtCostos, NORSCI, "FOB")
            lobjDt.Rows(Fila)("IVLFLT") = CostoAduana(dtCostos, NORSCI, "FLETE")
            lobjDt.Rows(Fila)("IVLSGR") = CostoAduana(dtCostos, NORSCI, "SEGURO")
            lobjDt.Rows(Fila)("ITTCIF") = CostoAduana(dtCostos, NORSCI, "CIF")
            lobjDt.Rows(Fila)("ITTADV") = CostoAduana(dtCostos, NORSCI, "ADVALO")
            OtrosCostos = 0
            OtrosCostos = CostoAduana(dtCostos, NORSCI, "TASDES") + CostoAduana(dtCostos, NORSCI, "DERESP")
            OtrosCostos = OtrosCostos + CostoAduana(dtCostos, NORSCI, "SOBTAS") + CostoAduana(dtCostos, NORSCI, "ANTDUM")
            OtrosCostos = OtrosCostos + CostoAduana(dtCostos, NORSCI, "IMSECO") + CostoAduana(dtCostos, NORSCI, "INTCOM")
            OtrosCostos = OtrosCostos + CostoAduana(dtCostos, NORSCI, "MORA")
            lobjDt.Rows(Fila)("ITTOGS") = OtrosCostos
            lobjDt.Rows(Fila)("IGVPM") = CostoAduana(dtCostos, NORSCI, "IGV") + CostoAduana(dtCostos, NORSCI, "IPM")
            lobjDt.Rows(Fila)("TOTAL") = CostoAduana(dtCostos, NORSCI, "TOLDER")
            lobjDt.Rows(Fila)("INLAD") = CostoAduana(dtCostos, NORSCI, "INLAD")

            lobjDt.Rows(Fila)("FAPRAR") = HelpClass.FechaNum_a_Fecha(lobjDt.Rows(Fila)("FAPRAR"))
            lobjDt.Rows(Fila)("FDCCMP") = HelpClass.FechaNum_a_Fecha(lobjDt.Rows(Fila)("FDCCMP"))

            lobjDt.Rows(Fila)("ALMCLI") = CheckPointAduana(dtCheckPoint, NORSCI, 124)
            lobjDt.Rows(Fila)("LEVANTE") = CheckPointAduana(dtCheckPoint, NORSCI, 123)
            'lobjDt.Rows(Fila)("VOLANTE") = CheckPointAduana(dtCheckPoint, NORSCI, 116)
            'lobjDt.Rows(Fila)("DOCUMENTOS") = CheckPointAduana(dtCheckPoint, NORSCI, 120)
            'lobjDt.Rows(Fila)("NUMERACION") = CheckPointAduana(dtCheckPoint, NORSCI, 121)
            'lobjDt.Rows(Fila)("DERECHOS") = CheckPointAduana(dtCheckPoint, NORSCI, 122)
        Next

        PasarDatosAEstructuraReporte(lobjDt, dtContenedor)
        CalculoSumatoria_Costo(lobjDtRep)
        CalcularPorcentajes_X_Zona()
        CalcularPorcentajes_X_Puerto()
        ElborarCuadroCosto_X_Zona()
        ElborarCuadroCosto_X_Puerto()
    End Sub

    Private Sub CalcularPorcentajes_X_Puerto()
        For Each obeCostoFindratio As beCostosRatioLandedPuerto In oListCostosRatioLandedPuerto
            Select Case _pICOTERM_BASE

                Case ICOTERM_BASE.ICOTERM_BASE_FOB
                    If (obeTotCostosRatio.PNTOT_ITTFOB > 0) Then

                        obeCostoFindratio.PNMARITMO.PNINLAD_X100 = (obeCostoFindratio.PNMARITMO.PNINLAD * 100) / obeTotCostosRatio.PNTOT_ITTFOB
                        obeCostoFindratio.PNMARITMO.PNGFOB_X100 = (obeCostoFindratio.PNMARITMO.PNGFOB * 100) / obeTotCostosRatio.PNTOT_ITTFOB
                        obeCostoFindratio.PNMARITMO.PNFLETE_X100 = (obeCostoFindratio.PNMARITMO.PNFLETE * 100) / obeTotCostosRatio.PNTOT_ITTFOB
                        obeCostoFindratio.PNMARITMO.PNDUTIES_X100 = (obeCostoFindratio.PNMARITMO.PNDUTIES * 100) / obeTotCostosRatio.PNTOT_ITTFOB
                        obeCostoFindratio.PNMARITMO.PNCOSTOS_ADICIONAL_X100 = (obeCostoFindratio.PNMARITMO.PNCOSTOS_ADICIONAL * 100) / obeTotCostosRatio.PNTOT_ITTFOB

                        obeCostoFindratio.PNTERRESTRE.PNINLAD_X100 = (obeCostoFindratio.PNTERRESTRE.PNINLAD * 100) / obeTotCostosRatio.PNTOT_ITTFOB
                        obeCostoFindratio.PNTERRESTRE.PNGFOB_X100 = (obeCostoFindratio.PNTERRESTRE.PNGFOB * 100) / obeTotCostosRatio.PNTOT_ITTFOB
                        obeCostoFindratio.PNTERRESTRE.PNFLETE_X100 = (obeCostoFindratio.PNTERRESTRE.PNFLETE * 100) / obeTotCostosRatio.PNTOT_ITTFOB
                        obeCostoFindratio.PNTERRESTRE.PNDUTIES_X100 = (obeCostoFindratio.PNTERRESTRE.PNDUTIES * 100) / obeTotCostosRatio.PNTOT_ITTFOB
                        obeCostoFindratio.PNTERRESTRE.PNCOSTOS_ADICIONAL_X100 = (obeCostoFindratio.PNTERRESTRE.PNCOSTOS_ADICIONAL * 100) / obeTotCostosRatio.PNTOT_ITTFOB

                        obeCostoFindratio.PNAEREO.PNINLAD_X100 = (obeCostoFindratio.PNAEREO.PNINLAD * 100) / obeTotCostosRatio.PNTOT_ITTFOB
                        obeCostoFindratio.PNAEREO.PNGFOB_X100 = (obeCostoFindratio.PNAEREO.PNGFOB * 100) / obeTotCostosRatio.PNTOT_ITTFOB
                        obeCostoFindratio.PNAEREO.PNFLETE_X100 = (obeCostoFindratio.PNAEREO.PNFLETE * 100) / obeTotCostosRatio.PNTOT_ITTFOB
                        obeCostoFindratio.PNAEREO.PNDUTIES_X100 = (obeCostoFindratio.PNAEREO.PNDUTIES * 100) / obeTotCostosRatio.PNTOT_ITTFOB
                        obeCostoFindratio.PNAEREO.PNCOSTOS_ADICIONAL_X100 = (obeCostoFindratio.PNAEREO.PNCOSTOS_ADICIONAL * 100) / obeTotCostosRatio.PNTOT_ITTFOB

                    End If


                Case ICOTERM_BASE.ICOTERM_BASE_EXW

                    If (obeTotCostosRatio.PNTOT_ITTEXW > 0) Then

                        obeCostoFindratio.PNMARITMO.PNINLAD_X100 = (obeCostoFindratio.PNMARITMO.PNINLAD * 100) / obeTotCostosRatio.PNTOT_ITTEXW
                        obeCostoFindratio.PNMARITMO.PNGFOB_X100 = (obeCostoFindratio.PNMARITMO.PNGFOB * 100) / obeTotCostosRatio.PNTOT_ITTEXW
                        obeCostoFindratio.PNMARITMO.PNFLETE_X100 = (obeCostoFindratio.PNMARITMO.PNFLETE * 100) / obeTotCostosRatio.PNTOT_ITTEXW
                        obeCostoFindratio.PNMARITMO.PNDUTIES_X100 = (obeCostoFindratio.PNMARITMO.PNDUTIES * 100) / obeTotCostosRatio.PNTOT_ITTEXW
                        obeCostoFindratio.PNMARITMO.PNCOSTOS_ADICIONAL_X100 = (obeCostoFindratio.PNMARITMO.PNCOSTOS_ADICIONAL * 100) / obeTotCostosRatio.PNTOT_ITTEXW


                        obeCostoFindratio.PNTERRESTRE.PNINLAD_X100 = (obeCostoFindratio.PNTERRESTRE.PNINLAD * 100) / obeTotCostosRatio.PNTOT_ITTEXW
                        obeCostoFindratio.PNTERRESTRE.PNGFOB_X100 = (obeCostoFindratio.PNTERRESTRE.PNGFOB * 100) / obeTotCostosRatio.PNTOT_ITTEXW
                        obeCostoFindratio.PNTERRESTRE.PNFLETE_X100 = (obeCostoFindratio.PNTERRESTRE.PNFLETE * 100) / obeTotCostosRatio.PNTOT_ITTEXW
                        obeCostoFindratio.PNTERRESTRE.PNDUTIES_X100 = (obeCostoFindratio.PNTERRESTRE.PNDUTIES * 100) / obeTotCostosRatio.PNTOT_ITTEXW
                        obeCostoFindratio.PNTERRESTRE.PNCOSTOS_ADICIONAL_X100 = (obeCostoFindratio.PNTERRESTRE.PNCOSTOS_ADICIONAL * 100) / obeTotCostosRatio.PNTOT_ITTEXW


                        obeCostoFindratio.PNAEREO.PNINLAD_X100 = (obeCostoFindratio.PNAEREO.PNINLAD * 100) / obeTotCostosRatio.PNTOT_ITTEXW
                        obeCostoFindratio.PNAEREO.PNGFOB_X100 = (obeCostoFindratio.PNAEREO.PNGFOB * 100) / obeTotCostosRatio.PNTOT_ITTEXW
                        obeCostoFindratio.PNAEREO.PNFLETE_X100 = (obeCostoFindratio.PNAEREO.PNFLETE * 100) / obeTotCostosRatio.PNTOT_ITTEXW
                        obeCostoFindratio.PNAEREO.PNDUTIES_X100 = (obeCostoFindratio.PNAEREO.PNDUTIES * 100) / obeTotCostosRatio.PNTOT_ITTEXW
                        obeCostoFindratio.PNAEREO.PNCOSTOS_ADICIONAL_X100 = (obeCostoFindratio.PNAEREO.PNCOSTOS_ADICIONAL * 100) / obeTotCostosRatio.PNTOT_ITTEXW


                    End If

                Case ICOTERM_BASE.ICOTERM_BASE_CIF

                    If (obeTotCostosRatio.PNTOT_ITTCIF > 0) Then

                        obeCostoFindratio.PNMARITMO.PNINLAD_X100 = (obeCostoFindratio.PNMARITMO.PNINLAD * 100) / obeTotCostosRatio.PNTOT_ITTCIF
                        obeCostoFindratio.PNMARITMO.PNGFOB_X100 = (obeCostoFindratio.PNMARITMO.PNGFOB * 100) / obeTotCostosRatio.PNTOT_ITTCIF
                        obeCostoFindratio.PNMARITMO.PNFLETE_X100 = (obeCostoFindratio.PNMARITMO.PNFLETE * 100) / obeTotCostosRatio.PNTOT_ITTCIF
                        obeCostoFindratio.PNMARITMO.PNDUTIES_X100 = (obeCostoFindratio.PNMARITMO.PNDUTIES * 100) / obeTotCostosRatio.PNTOT_ITTCIF
                        obeCostoFindratio.PNMARITMO.PNCOSTOS_ADICIONAL_X100 = (obeCostoFindratio.PNMARITMO.PNCOSTOS_ADICIONAL * 100) / obeTotCostosRatio.PNTOT_ITTCIF


                        obeCostoFindratio.PNTERRESTRE.PNINLAD_X100 = (obeCostoFindratio.PNTERRESTRE.PNINLAD * 100) / obeTotCostosRatio.PNTOT_ITTCIF
                        obeCostoFindratio.PNTERRESTRE.PNGFOB_X100 = (obeCostoFindratio.PNTERRESTRE.PNGFOB * 100) / obeTotCostosRatio.PNTOT_ITTCIF
                        obeCostoFindratio.PNTERRESTRE.PNFLETE_X100 = (obeCostoFindratio.PNTERRESTRE.PNFLETE * 100) / obeTotCostosRatio.PNTOT_ITTCIF
                        obeCostoFindratio.PNTERRESTRE.PNDUTIES_X100 = (obeCostoFindratio.PNTERRESTRE.PNDUTIES * 100) / obeTotCostosRatio.PNTOT_ITTCIF
                        obeCostoFindratio.PNTERRESTRE.PNCOSTOS_ADICIONAL_X100 = (obeCostoFindratio.PNTERRESTRE.PNCOSTOS_ADICIONAL * 100) / obeTotCostosRatio.PNTOT_ITTCIF


                        obeCostoFindratio.PNAEREO.PNINLAD_X100 = (obeCostoFindratio.PNAEREO.PNINLAD * 100) / obeTotCostosRatio.PNTOT_ITTCIF
                        obeCostoFindratio.PNAEREO.PNGFOB_X100 = (obeCostoFindratio.PNAEREO.PNGFOB * 100) / obeTotCostosRatio.PNTOT_ITTCIF
                        obeCostoFindratio.PNAEREO.PNFLETE_X100 = (obeCostoFindratio.PNAEREO.PNFLETE * 100) / obeTotCostosRatio.PNTOT_ITTCIF
                        obeCostoFindratio.PNAEREO.PNDUTIES_X100 = (obeCostoFindratio.PNAEREO.PNDUTIES * 100) / obeTotCostosRatio.PNTOT_ITTCIF
                        obeCostoFindratio.PNAEREO.PNCOSTOS_ADICIONAL_X100 = (obeCostoFindratio.PNAEREO.PNCOSTOS_ADICIONAL * 100) / obeTotCostosRatio.PNTOT_ITTCIF

                    End If
            End Select


        Next
    End Sub
    Private Sub CalcularPorcentajes_X_Zona()
        For Each obeCostoFindratio As beCostosRatioLandedZona In oListCostosRatioLandedZona
            Select Case _pICOTERM_BASE

                Case ICOTERM_BASE.ICOTERM_BASE_FOB
                    If (obeTotCostosRatio.PNTOT_ITTFOB > 0) Then

                        obeCostoFindratio.PNMARITMO.PNINLAD_X100 = (obeCostoFindratio.PNMARITMO.PNINLAD * 100) / obeTotCostosRatio.PNTOT_ITTFOB
                        obeCostoFindratio.PNMARITMO.PNGFOB_X100 = (obeCostoFindratio.PNMARITMO.PNGFOB * 100) / obeTotCostosRatio.PNTOT_ITTFOB
                        obeCostoFindratio.PNMARITMO.PNFLETE_X100 = (obeCostoFindratio.PNMARITMO.PNFLETE * 100) / obeTotCostosRatio.PNTOT_ITTFOB
                        obeCostoFindratio.PNMARITMO.PNDUTIES_X100 = (obeCostoFindratio.PNMARITMO.PNDUTIES * 100) / obeTotCostosRatio.PNTOT_ITTFOB
                        obeCostoFindratio.PNMARITMO.PNCOSTOS_ADICIONAL_X100 = (obeCostoFindratio.PNMARITMO.PNCOSTOS_ADICIONAL * 100) / obeTotCostosRatio.PNTOT_ITTFOB

                        obeCostoFindratio.PNTERRESTRE.PNINLAD_X100 = (obeCostoFindratio.PNTERRESTRE.PNINLAD * 100) / obeTotCostosRatio.PNTOT_ITTFOB
                        obeCostoFindratio.PNTERRESTRE.PNGFOB_X100 = (obeCostoFindratio.PNTERRESTRE.PNGFOB * 100) / obeTotCostosRatio.PNTOT_ITTFOB
                        obeCostoFindratio.PNTERRESTRE.PNFLETE_X100 = (obeCostoFindratio.PNTERRESTRE.PNFLETE * 100) / obeTotCostosRatio.PNTOT_ITTFOB
                        obeCostoFindratio.PNTERRESTRE.PNDUTIES_X100 = (obeCostoFindratio.PNTERRESTRE.PNDUTIES * 100) / obeTotCostosRatio.PNTOT_ITTFOB
                        obeCostoFindratio.PNTERRESTRE.PNCOSTOS_ADICIONAL_X100 = (obeCostoFindratio.PNTERRESTRE.PNCOSTOS_ADICIONAL * 100) / obeTotCostosRatio.PNTOT_ITTFOB

                        obeCostoFindratio.PNAEREO.PNINLAD_X100 = (obeCostoFindratio.PNAEREO.PNINLAD * 100) / obeTotCostosRatio.PNTOT_ITTFOB
                        obeCostoFindratio.PNAEREO.PNGFOB_X100 = (obeCostoFindratio.PNAEREO.PNGFOB * 100) / obeTotCostosRatio.PNTOT_ITTFOB
                        obeCostoFindratio.PNAEREO.PNFLETE_X100 = (obeCostoFindratio.PNAEREO.PNFLETE * 100) / obeTotCostosRatio.PNTOT_ITTFOB
                        obeCostoFindratio.PNAEREO.PNDUTIES_X100 = (obeCostoFindratio.PNAEREO.PNDUTIES * 100) / obeTotCostosRatio.PNTOT_ITTFOB
                        obeCostoFindratio.PNAEREO.PNCOSTOS_ADICIONAL_X100 = (obeCostoFindratio.PNAEREO.PNCOSTOS_ADICIONAL * 100) / obeTotCostosRatio.PNTOT_ITTFOB

                    End If


                Case ICOTERM_BASE.ICOTERM_BASE_EXW

                    If (obeTotCostosRatio.PNTOT_ITTEXW > 0) Then

                        obeCostoFindratio.PNMARITMO.PNINLAD_X100 = (obeCostoFindratio.PNMARITMO.PNINLAD * 100) / obeTotCostosRatio.PNTOT_ITTEXW
                        obeCostoFindratio.PNMARITMO.PNGFOB_X100 = (obeCostoFindratio.PNMARITMO.PNGFOB * 100) / obeTotCostosRatio.PNTOT_ITTEXW
                        obeCostoFindratio.PNMARITMO.PNFLETE_X100 = (obeCostoFindratio.PNMARITMO.PNFLETE * 100) / obeTotCostosRatio.PNTOT_ITTEXW
                        obeCostoFindratio.PNMARITMO.PNDUTIES_X100 = (obeCostoFindratio.PNMARITMO.PNDUTIES * 100) / obeTotCostosRatio.PNTOT_ITTEXW
                        obeCostoFindratio.PNMARITMO.PNCOSTOS_ADICIONAL_X100 = (obeCostoFindratio.PNMARITMO.PNCOSTOS_ADICIONAL * 100) / obeTotCostosRatio.PNTOT_ITTEXW


                        obeCostoFindratio.PNTERRESTRE.PNINLAD_X100 = (obeCostoFindratio.PNTERRESTRE.PNINLAD * 100) / obeTotCostosRatio.PNTOT_ITTEXW
                        obeCostoFindratio.PNTERRESTRE.PNGFOB_X100 = (obeCostoFindratio.PNTERRESTRE.PNGFOB * 100) / obeTotCostosRatio.PNTOT_ITTEXW
                        obeCostoFindratio.PNTERRESTRE.PNFLETE_X100 = (obeCostoFindratio.PNTERRESTRE.PNFLETE * 100) / obeTotCostosRatio.PNTOT_ITTEXW
                        obeCostoFindratio.PNTERRESTRE.PNDUTIES_X100 = (obeCostoFindratio.PNTERRESTRE.PNDUTIES * 100) / obeTotCostosRatio.PNTOT_ITTEXW
                        obeCostoFindratio.PNTERRESTRE.PNCOSTOS_ADICIONAL_X100 = (obeCostoFindratio.PNTERRESTRE.PNCOSTOS_ADICIONAL * 100) / obeTotCostosRatio.PNTOT_ITTEXW


                        obeCostoFindratio.PNAEREO.PNINLAD_X100 = (obeCostoFindratio.PNAEREO.PNINLAD * 100) / obeTotCostosRatio.PNTOT_ITTEXW
                        obeCostoFindratio.PNAEREO.PNGFOB_X100 = (obeCostoFindratio.PNAEREO.PNGFOB * 100) / obeTotCostosRatio.PNTOT_ITTEXW
                        obeCostoFindratio.PNAEREO.PNFLETE_X100 = (obeCostoFindratio.PNAEREO.PNFLETE * 100) / obeTotCostosRatio.PNTOT_ITTEXW
                        obeCostoFindratio.PNAEREO.PNDUTIES_X100 = (obeCostoFindratio.PNAEREO.PNDUTIES * 100) / obeTotCostosRatio.PNTOT_ITTEXW
                        obeCostoFindratio.PNAEREO.PNCOSTOS_ADICIONAL_X100 = (obeCostoFindratio.PNAEREO.PNCOSTOS_ADICIONAL * 100) / obeTotCostosRatio.PNTOT_ITTEXW


                    End If

                Case ICOTERM_BASE.ICOTERM_BASE_CIF

                    If (obeTotCostosRatio.PNTOT_ITTCIF > 0) Then

                        obeCostoFindratio.PNMARITMO.PNINLAD_X100 = (obeCostoFindratio.PNMARITMO.PNINLAD * 100) / obeTotCostosRatio.PNTOT_ITTCIF
                        obeCostoFindratio.PNMARITMO.PNGFOB_X100 = (obeCostoFindratio.PNMARITMO.PNGFOB * 100) / obeTotCostosRatio.PNTOT_ITTCIF
                        obeCostoFindratio.PNMARITMO.PNFLETE_X100 = (obeCostoFindratio.PNMARITMO.PNFLETE * 100) / obeTotCostosRatio.PNTOT_ITTCIF
                        obeCostoFindratio.PNMARITMO.PNDUTIES_X100 = (obeCostoFindratio.PNMARITMO.PNDUTIES * 100) / obeTotCostosRatio.PNTOT_ITTCIF
                        obeCostoFindratio.PNMARITMO.PNCOSTOS_ADICIONAL_X100 = (obeCostoFindratio.PNMARITMO.PNCOSTOS_ADICIONAL * 100) / obeTotCostosRatio.PNTOT_ITTCIF


                        obeCostoFindratio.PNTERRESTRE.PNINLAD_X100 = (obeCostoFindratio.PNTERRESTRE.PNINLAD * 100) / obeTotCostosRatio.PNTOT_ITTCIF
                        obeCostoFindratio.PNTERRESTRE.PNGFOB_X100 = (obeCostoFindratio.PNTERRESTRE.PNGFOB * 100) / obeTotCostosRatio.PNTOT_ITTCIF
                        obeCostoFindratio.PNTERRESTRE.PNFLETE_X100 = (obeCostoFindratio.PNTERRESTRE.PNFLETE * 100) / obeTotCostosRatio.PNTOT_ITTCIF
                        obeCostoFindratio.PNTERRESTRE.PNDUTIES_X100 = (obeCostoFindratio.PNTERRESTRE.PNDUTIES * 100) / obeTotCostosRatio.PNTOT_ITTCIF
                        obeCostoFindratio.PNTERRESTRE.PNCOSTOS_ADICIONAL_X100 = (obeCostoFindratio.PNTERRESTRE.PNCOSTOS_ADICIONAL * 100) / obeTotCostosRatio.PNTOT_ITTCIF


                        obeCostoFindratio.PNAEREO.PNINLAD_X100 = (obeCostoFindratio.PNAEREO.PNINLAD * 100) / obeTotCostosRatio.PNTOT_ITTCIF
                        obeCostoFindratio.PNAEREO.PNGFOB_X100 = (obeCostoFindratio.PNAEREO.PNGFOB * 100) / obeTotCostosRatio.PNTOT_ITTCIF
                        obeCostoFindratio.PNAEREO.PNFLETE_X100 = (obeCostoFindratio.PNAEREO.PNFLETE * 100) / obeTotCostosRatio.PNTOT_ITTCIF
                        obeCostoFindratio.PNAEREO.PNDUTIES_X100 = (obeCostoFindratio.PNAEREO.PNDUTIES * 100) / obeTotCostosRatio.PNTOT_ITTCIF
                        obeCostoFindratio.PNAEREO.PNCOSTOS_ADICIONAL_X100 = (obeCostoFindratio.PNAEREO.PNCOSTOS_ADICIONAL * 100) / obeTotCostosRatio.PNTOT_ITTCIF

                    End If
            End Select


        Next
    End Sub
End Class
