Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Datos
Public Class clsCostoItem
    Private oCostoItem As Datos.clsCostoItem

    Sub New()
        oCostoItem = New Datos.clsCostoItem
    End Sub


    Public Function Lista_Costo_Item_Resumido(ByVal PSCCMPN As String, ByVal CCLNT As Decimal, ByVal NORCML As String, ByVal PNPNNMOS As Decimal, ByVal FECHA_INI As Decimal, ByVal FECHA_FIN As Decimal, ByVal PSTPSRVA As String, ByVal PSSESTRG As String) As DataTable
        Return oCostoItem.Lista_Costo_Item_Resumido(PSCCMPN, CCLNT, NORCML, PNPNNMOS, FECHA_INI, FECHA_FIN, PSTPSRVA, PSSESTRG)
    End Function

    Public Function Lista_Ordenes_Embarcadas_A_Distribuir(ByVal PNCCLNT As Decimal, ByVal NORSCI As Decimal) As DataTable
        Return oCostoItem.Lista_Ordenes_Embarcadas_A_Distribuir(PNCCLNT, NORSCI)
    End Function

    'Public Function Lista_Costo_Item_OC(ByVal pdblCli As Double, ByVal pstrOC As String, ByVal pdblOS As Double) As DataTable
    '    Return oCostoItem.Lista_Costo_Item_OC(pdblCli, pstrOC, pdblOS)
    'End Function

    'Public Sub Distribuir_Costos_Ordenes_Embarcadas(ByVal PNCCLNT As Decimal, ByVal NORSCI As Decimal, ByVal ListCost As List(Of String))
    '    Dim odtOrdenesEmbarcadas As New DataTable
    '    Dim brCostoItem As New Datos.clsCostoItem
    '    Dim odtCostoTotales As New DataTable
    '    Dim oDocApertura As New clsDocApertura
    '    Dim MontoTotalOC As Decimal = 0
    '    Dim CODVARCOSTO As String = ""
    '    Dim PNFECHA As Decimal = Format(Now, "yyyyMMdd")
    '    Dim PNHORA As Decimal = Format(Now, "HHmmss")
    '    odtOrdenesEmbarcadas = oCostoItem.Lista_Ordenes_Embarcadas_A_Distribuir(PNCCLNT, NORSCI)

    '    For Each ItemCosto As String In ListCost
    '        odtOrdenesEmbarcadas.Columns.Add("COSTO_ORIGEN_" & ItemCosto, Type.GetType("System.Decimal"))
    '        odtOrdenesEmbarcadas.Columns.Add("COSTO_DOLAR_" & ItemCosto, Type.GetType("System.Decimal"))
    '    Next

    '    odtCostoTotales = oDocApertura.Lista_Costos_Totales_Embarque(NORSCI).Tables("dtCosto")
    '    Dim drCosto() As DataRow
    '    Dim MontoDolar As Decimal = 0
    '    Dim MontoOrigen As Decimal = 0
    '    Dim obeDistribucionCostoxItemOC As beDistribucionCostoxItemOC

    '    For Each Item As DataRow In odtOrdenesEmbarcadas.Rows
    '        MontoTotalOC = MontoTotalOC + (Item("IVUNIT") * Item("QRLCSC") * Item("QTPCM2"))
    '    Next
    '    If (MontoTotalOC > 0) Then
    '        'los costos (<> cif ,se distribuyen en base a su factor (Monto x Item / Monto Total OC) x Monto del respectivo costo
    '        For Each Item As DataRow In odtOrdenesEmbarcadas.Rows
    '            For Each ItemConcepto As String In ListCost
    '                If ItemConcepto <> "CIF" AndAlso ItemConcepto <> "OTSGAS" Then
    '                    drCosto = odtCostoTotales.Select("CODVAR='" & ItemConcepto & "'")

    '                    MontoOrigen = Math.Round((Item("IVUNIT") / MontoTotalOC) * Item("QRLCSC") * Item("QTPCM2") * drCosto(0)("IVLORG"), 5)
    '                    MontoDolar = Math.Round((Item("IVUNIT") / MontoTotalOC) * Item("QRLCSC") * Item("QTPCM2") * drCosto(0)("IVLDOL"), 5)

    '                    Item("COSTO_ORIGEN_" & ItemConcepto) = MontoOrigen
    '                    Item("COSTO_DOLAR_" & ItemConcepto) = MontoDolar


    '                    'obeDistribucionCostoxItemOC = New beDistribucionCostoxItemOC
    '                    'obeDistribucionCostoxItemOC.PNNORSCI = NORSCI
    '                    'obeDistribucionCostoxItemOC.PNCCLNT = PNCCLNT
    '                    'obeDistribucionCostoxItemOC.PSNORCML = Item("NORCML").ToString.Trim
    '                    'obeDistribucionCostoxItemOC.PNNRITEM = Item("NRITOC")
    '                    'obeDistribucionCostoxItemOC.PNNRPEMB = Item("NRPEMB")
    '                    'obeDistribucionCostoxItemOC.PSCODVAR = ItemConcepto
    '                    'obeDistribucionCostoxItemOC.PNIVLDOL = MontoDolar
    '                    'obeDistribucionCostoxItemOC.PNIVLORG = MontoOrigen
    '                    'obeDistribucionCostoxItemOC.PNCMNDA1 = 100
    '                    'obeDistribucionCostoxItemOC.PSNMONOC = "USD"
    '                    'obeDistribucionCostoxItemOC.PNQRLCSC = Item("QRLCSC")
    '                    'obeDistribucionCostoxItemOC.PNFULTAC = PNFECHA
    '                    'obeDistribucionCostoxItemOC.PNHULTAC = PNHORA
    '                    'brCostoItem.Distribuir_Concepto_x_Item(obeDistribucionCostoxItemOC)
    '                End If
    '            Next
    '        Next

    '        'para los otros conceptos es necesario que realice en orden la distribucion
    '        'primero :CIF ,luegos los demas
    '        Dim odtCostosDistribuidos As New DataTable
    '        Dim NORCML As String = ""
    '        Dim NRITOC As Decimal = 0
    '        Dim NRPEMB As Decimal = 0

    '        If (ListCost.Contains("CIF")) Then
    '            odtCostosDistribuidos = oDocApertura.Lista_Costos_Distribuidos_Embarque(NORSCI)
    '            CODVARCOSTO = "CIF"
    '            NORCML = ""
    '            NRITOC = 0
    '            NRPEMB = 0
    '            For Each Item As DataRow In odtOrdenesEmbarcadas.Rows
    '                NORCML = Item("NORCML").ToString.Trim
    '                NRITOC = Item("NRITOC")
    '                NRPEMB = Item("NRPEMB")
    '                MontoOrigen = 0
    '                MontoDolar = 0
    '                'drCosto = odtCostosDistribuidos.Select("NORCML='" & NORCML & "' AND NRITEM=" & NRITOC & " AND NRPEMB=" & NRPEMB & " AND CODVAR IN ('ITTEXW','GFOB','FOB','FLETE','SEGURO')")
    '                drCosto = odtCostosDistribuidos.Select("NORCML='" & NORCML & "' AND NRITEM=" & NRITOC & " AND NRPEMB=" & NRPEMB & " AND CODVAR IN ('FOB','FLETE','SEGURO')")
    '                For Each ItemCosto As DataRow In drCosto
    '                    MontoOrigen = MontoOrigen + ItemCosto("IVLORG")
    '                    MontoDolar = MontoDolar + ItemCosto("IVLDOL")
    '                Next
    '                obeDistribucionCostoxItemOC = New beDistribucionCostoxItemOC
    '                obeDistribucionCostoxItemOC.PNNORSCI = NORSCI
    '                obeDistribucionCostoxItemOC.PNCCLNT = PNCCLNT
    '                obeDistribucionCostoxItemOC.PSNORCML = Item("NORCML").ToString.Trim
    '                obeDistribucionCostoxItemOC.PNNRITEM = Item("NRITOC")
    '                obeDistribucionCostoxItemOC.PNNRPEMB = Item("NRPEMB")
    '                obeDistribucionCostoxItemOC.PSCODVAR = CODVARCOSTO
    '                obeDistribucionCostoxItemOC.PNIVLDOL = MontoDolar
    '                obeDistribucionCostoxItemOC.PNIVLORG = MontoOrigen
    '                obeDistribucionCostoxItemOC.PNCMNDA1 = 100
    '                obeDistribucionCostoxItemOC.PSNMONOC = "USD"
    '                obeDistribucionCostoxItemOC.PNQRLCSC = Item("QRLCSC")
    '                obeDistribucionCostoxItemOC.PNFULTAC = PNFECHA
    '                obeDistribucionCostoxItemOC.PNHULTAC = PNHORA
    '                brCostoItem.Distribuir_Concepto_x_Item(obeDistribucionCostoxItemOC)
    '            Next
    '        End If
    '        If (ListCost.Contains("OTSGAS")) Then
    '            Dim drCostoCIF() As DataRow
    '            Dim drCostoOTSGAS() As DataRow
    '            odtCostosDistribuidos = oDocApertura.Lista_Costos_Distribuidos_Embarque(NORSCI)
    '            drCostoCIF = odtCostoTotales.Select("CODVAR='CIF'")
    '            drCostoOTSGAS = odtCostoTotales.Select("CODVAR='OTSGAS'")
    '            CODVARCOSTO = "OTSGAS"
    '            NORCML = ""
    '            NRITOC = 0
    '            NRPEMB = 0
    '            For Each Item As DataRow In odtOrdenesEmbarcadas.Rows
    '                NORCML = Item("NORCML").ToString.Trim
    '                NRITOC = Item("NRITOC")
    '                NRPEMB = Item("NRPEMB")
    '                MontoOrigen = 0
    '                MontoDolar = 0
    '                drCosto = odtCostosDistribuidos.Select("NORCML='" & NORCML & "' AND NRITEM=" & NRITOC & " AND NRPEMB=" & NRPEMB & " AND CODVAR ='CIF'")

    '                If drCostoCIF.Length > 0 AndAlso drCosto.Length > 0 Then
    '                    MontoOrigen = Math.Round((drCosto(0)("IVLORG") / drCostoCIF(0)("IVLORG")) * drCostoOTSGAS(0)("IVLORG"), 5)
    '                    MontoDolar = Math.Round((drCosto(0)("IVLDOL") / drCostoCIF(0)("IVLORG")) * drCostoOTSGAS(0)("IVLORG"), 5)
    '                Else
    '                    MontoOrigen = 0
    '                    MontoDolar = 0
    '                End If

    '                obeDistribucionCostoxItemOC = New beDistribucionCostoxItemOC
    '                obeDistribucionCostoxItemOC.PNNORSCI = NORSCI
    '                obeDistribucionCostoxItemOC.PNCCLNT = PNCCLNT
    '                obeDistribucionCostoxItemOC.PSNORCML = Item("NORCML").ToString.Trim
    '                obeDistribucionCostoxItemOC.PNNRITEM = Item("NRITOC")
    '                obeDistribucionCostoxItemOC.PNNRPEMB = Item("NRPEMB")
    '                obeDistribucionCostoxItemOC.PSCODVAR = CODVARCOSTO
    '                obeDistribucionCostoxItemOC.PNIVLDOL = MontoDolar
    '                obeDistribucionCostoxItemOC.PNIVLORG = MontoOrigen
    '                obeDistribucionCostoxItemOC.PNCMNDA1 = 100
    '                obeDistribucionCostoxItemOC.PSNMONOC = "USD"
    '                obeDistribucionCostoxItemOC.PNQRLCSC = Item("QRLCSC")
    '                obeDistribucionCostoxItemOC.PNFULTAC = PNFECHA
    '                obeDistribucionCostoxItemOC.PNHULTAC = PNHORA
    '                brCostoItem.Distribuir_Concepto_x_Item(obeDistribucionCostoxItemOC)
    '            Next
    '        End If
    '    End If
    'End Sub


    'Public Sub Distribuir_Costos_Ordenes_Embarcadas(ByVal PNCCLNT As Decimal, ByVal NORSCI As Decimal, ByVal ListCost As List(Of String))
    '    Dim odtOrdenesEmbarcadas As New DataTable
    '    Dim brCostoItem As New Datos.clsCostoItem
    '    Dim odtCostoTotales As New DataTable
    '    Dim oDocApertura As New clsDocApertura
    '    Dim MontoTotalOC As Decimal = 0
    '    Dim PNFECHA As Decimal = Format(Now, "yyyyMMdd")
    '    Dim PNHORA As Decimal = Format(Now, "HHmmss")
    '    Dim Fila_Ajuste As Int32 = 0
    '    Dim Monto_Ajuste_Mayor As Decimal = 0
    '    Dim Columna_Costo_Origen As String = ""
    '    Dim Columna_Costo_Dolar As String = ""
    '    Dim msgValidacion As String = ""
    '    Dim ListCostPostCIF As New List(Of String)


    '    ListCostPostCIF.Add("TASDES")
    '    ListCostPostCIF.Add("SOBTAS")
    '    ListCostPostCIF.Add("DERESP")
    '    ListCostPostCIF.Add("ANTDUM")
    '    ListCostPostCIF.Add("IMSECO")
    '    ListCostPostCIF.Add("INTCOM")
    '    ListCostPostCIF.Add("MORA")

    '    odtOrdenesEmbarcadas = oCostoItem.Lista_Ordenes_Embarcadas_A_Distribuir(PNCCLNT, NORSCI)
    '    odtOrdenesEmbarcadas.Columns.Add("IMPORTE_PARCIAL", Type.GetType("System.Decimal"))
    '    For Each ItemCosto As String In ListCost
    '        odtOrdenesEmbarcadas.Columns.Add("COSTO_ORIGEN_" & ItemCosto, Type.GetType("System.Decimal"))
    '        odtOrdenesEmbarcadas.Columns.Add("COSTO_DOLAR_" & ItemCosto, Type.GetType("System.Decimal"))
    '    Next

    '    odtCostoTotales = oDocApertura.Lista_Costos_Totales_Embarque(NORSCI).Tables("dtCosto")
    '    Dim drCosto() As DataRow
    '    Dim MontoDolar As Decimal = 0
    '    Dim MontoOrigen As Decimal = 0
    '    Dim obeDistribucionCostoxItemOC As beDistribucionCostoxItemOC
    '    Dim SubTotal As Decimal = 0

    '    Monto_Ajuste_Mayor = 0
    '    For Fila As Integer = 0 To odtOrdenesEmbarcadas.Rows.Count - 1
    '        SubTotal = (odtOrdenesEmbarcadas.Rows(Fila)("IVUNIT") * odtOrdenesEmbarcadas.Rows(Fila)("QRLCSC") * odtOrdenesEmbarcadas.Rows(Fila)("QTPCM2"))
    '        'If SubTotal = 0 Then
    '        '    msgValidacion = "No se puede costear.Verificar el valor unitario o cantidad del item(>0)."
    '        '    Exit For
    '        'End If
    '        MontoTotalOC = MontoTotalOC + SubTotal
    '        ' odtOrdenesEmbarcadas.Rows(Fila)("IMPORTE_PARCIAL") = odtOrdenesEmbarcadas.Rows(Fila)("IVUNIT") * odtOrdenesEmbarcadas.Rows(Fila)("QRLCSC") * odtOrdenesEmbarcadas.Rows(Fila)("QTPCM2")
    '        odtOrdenesEmbarcadas.Rows(Fila)("IMPORTE_PARCIAL") = SubTotal
    '        If odtOrdenesEmbarcadas.Rows(Fila)("IMPORTE_PARCIAL") > Monto_Ajuste_Mayor Then
    '            Fila_Ajuste = Fila
    '        End If
    '    Next
    '    'If msgValidacion.Length > 0 Then
    '    '    Exit Sub
    '    'End If
    '    Dim MontoCostoVarOrigen As Decimal = 0
    '    Dim MontoCostoVarDolar As Decimal = 0

    '    Dim odtCostosDistribuidos As New DataTable
    '    'Dim NRPEMB As Decimal = 0


    '    Dim drCostoCIF() As DataRow
    '    Dim drCostoOTSGAS() As DataRow

    '    If (MontoTotalOC > 0) Then
    '        'los costos (<> cif ,se distribuyen en base a su factor (Monto x Item / Monto Total OC) x Monto del respectivo costo
    '        For Each ItemConcepto As String In ListCost

    '            Columna_Costo_Origen = "COSTO_ORIGEN_" & ItemConcepto
    '            Columna_Costo_Dolar = "COSTO_DOLAR_" & ItemConcepto

    '            'ListCostPostCIF

    '            'If ItemConcepto <> "CIF" AndAlso ItemConcepto <> "OTSGAS" Then
    '            If ItemConcepto <> "CIF" AndAlso Not ListCostPostCIF.Contains(ItemConcepto) Then
    '                drCosto = odtCostoTotales.Select("CODVAR='" & ItemConcepto & "'")
    '                For Each Item As DataRow In odtOrdenesEmbarcadas.Rows
    '                    MontoOrigen = Math.Round((Item("IVUNIT") / MontoTotalOC) * Item("QRLCSC") * Item("QTPCM2") * drCosto(0)("IVLORG"), 5)
    '                    MontoDolar = Math.Round((Item("IVUNIT") / MontoTotalOC) * Item("QRLCSC") * Item("QTPCM2") * drCosto(0)("IVLDOL"), 5)
    '                    Item(Columna_Costo_Origen) = MontoOrigen
    '                    Item(Columna_Costo_Dolar) = MontoDolar
    '                Next

    '                MontoCostoVarOrigen = odtOrdenesEmbarcadas.Compute("SUM(" & Columna_Costo_Origen & ")", "")
    '                MontoCostoVarDolar = odtOrdenesEmbarcadas.Compute("SUM(" & Columna_Costo_Dolar & ")", "")
    '                odtOrdenesEmbarcadas.Rows(Fila_Ajuste)(Columna_Costo_Origen) = odtOrdenesEmbarcadas.Rows(Fila_Ajuste)("COSTO_ORIGEN_" & ItemConcepto) + (drCosto(0)("IVLORG") - MontoCostoVarOrigen)
    '                odtOrdenesEmbarcadas.Rows(Fila_Ajuste)(Columna_Costo_Dolar) = odtOrdenesEmbarcadas.Rows(Fila_Ajuste)("COSTO_DOLAR_" & ItemConcepto) + (drCosto(0)("IVLORG") - MontoCostoVarDolar)

    '                For Each Item As DataRow In odtOrdenesEmbarcadas.Rows
    '                    obeDistribucionCostoxItemOC = New beDistribucionCostoxItemOC
    '                    obeDistribucionCostoxItemOC.PNNORSCI = NORSCI
    '                    obeDistribucionCostoxItemOC.PNCCLNT = PNCCLNT
    '                    obeDistribucionCostoxItemOC.PSNORCML = Item("NORCML").ToString.Trim
    '                    obeDistribucionCostoxItemOC.PNNRITEM = Item("NRITOC")
    '                    obeDistribucionCostoxItemOC.PNNRPEMB = Item("NRPEMB")
    '                    obeDistribucionCostoxItemOC.PSCODVAR = ItemConcepto
    '                    obeDistribucionCostoxItemOC.PNIVLDOL = Item(Columna_Costo_Dolar)
    '                    obeDistribucionCostoxItemOC.PNIVLORG = Item(Columna_Costo_Origen)
    '                    obeDistribucionCostoxItemOC.PNCMNDA1 = 100
    '                    obeDistribucionCostoxItemOC.PSNMONOC = "USD"
    '                    obeDistribucionCostoxItemOC.PNQRLCSC = Item("QRLCSC")
    '                    obeDistribucionCostoxItemOC.PNFULTAC = PNFECHA
    '                    obeDistribucionCostoxItemOC.PNHULTAC = PNHORA
    '                    brCostoItem.Distribuir_Concepto_x_Item(obeDistribucionCostoxItemOC)
    '                Next
    '            End If

    '            If ItemConcepto = "CIF" Then
    '                odtCostosDistribuidos = oDocApertura.Lista_Costos_Distribuidos_Embarque(NORSCI)
    '                'CODVARCOSTO = "CIF"
    '                'NRPEMB = 0
    '                For Each Item As DataRow In odtOrdenesEmbarcadas.Rows
    '                    'NRPEMB = Item("NRPEMB")
    '                    MontoOrigen = odtCostosDistribuidos.Compute("SUM(IVLORG)", "NRPEMB=" & Item("NRPEMB") & " AND CODVAR IN ('FOB','FLETE','SEGURO')")
    '                    MontoDolar = odtCostosDistribuidos.Compute("SUM(IVLDOL)", "NRPEMB=" & Item("NRPEMB") & " AND CODVAR IN ('FOB','FLETE','SEGURO')")
    '                    obeDistribucionCostoxItemOC = New beDistribucionCostoxItemOC
    '                    obeDistribucionCostoxItemOC.PNNORSCI = NORSCI
    '                    obeDistribucionCostoxItemOC.PNCCLNT = PNCCLNT
    '                    obeDistribucionCostoxItemOC.PSNORCML = Item("NORCML").ToString.Trim
    '                    obeDistribucionCostoxItemOC.PNNRITEM = Item("NRITOC")
    '                    obeDistribucionCostoxItemOC.PNNRPEMB = Item("NRPEMB")
    '                    obeDistribucionCostoxItemOC.PSCODVAR = ItemConcepto
    '                    obeDistribucionCostoxItemOC.PNIVLDOL = MontoDolar
    '                    obeDistribucionCostoxItemOC.PNIVLORG = MontoOrigen
    '                    obeDistribucionCostoxItemOC.PNCMNDA1 = 100
    '                    obeDistribucionCostoxItemOC.PSNMONOC = "USD"
    '                    obeDistribucionCostoxItemOC.PNQRLCSC = Item("QRLCSC")
    '                    obeDistribucionCostoxItemOC.PNFULTAC = PNFECHA
    '                    obeDistribucionCostoxItemOC.PNHULTAC = PNHORA
    '                    brCostoItem.Distribuir_Concepto_x_Item(obeDistribucionCostoxItemOC)
    '                Next
    '            End If

    '            'If ItemConcepto = "OTSGAS" Then
    '            If ListCostPostCIF.Contains(ItemConcepto) Then

    '                odtCostosDistribuidos = oDocApertura.Lista_Costos_Distribuidos_Embarque(NORSCI)
    '                drCostoCIF = odtCostoTotales.Select("CODVAR='CIF'")
    '                'drCostoOTSGAS = odtCostoTotales.Select("CODVAR='OTSGAS'")
    '                drCostoOTSGAS = odtCostoTotales.Select("CODVAR='" & ItemConcepto & "'")

    '                If drCostoOTSGAS.Length > 0 Then
    '                    'CODVARCOSTO = "OTSGAS"
    '                    'CODVARCOSTO = ItemConcepto
    '                    'NRPEMB = 0
    '                    For Each Item As DataRow In odtOrdenesEmbarcadas.Rows
    '                        'NRPEMB = Item("NRPEMB")
    '                        drCosto = odtCostosDistribuidos.Select("NRPEMB=" & Item("NRPEMB") & " AND CODVAR ='CIF'")
    '                        If drCostoCIF.Length > 0 AndAlso drCosto.Length > 0 Then
    '                            MontoOrigen = Math.Round((drCosto(0)("IVLORG") / drCostoCIF(0)("IVLORG")) * drCostoOTSGAS(0)("IVLORG"), 5)
    '                            MontoDolar = Math.Round((drCosto(0)("IVLDOL") / drCostoCIF(0)("IVLDOL")) * drCostoOTSGAS(0)("IVLDOL"), 5)
    '                        Else
    '                            MontoOrigen = 0
    '                            MontoDolar = 0
    '                        End If

    '                        Item(Columna_Costo_Origen) = MontoOrigen
    '                        Item(Columna_Costo_Dolar) = MontoDolar
    '                    Next

    '                    MontoCostoVarOrigen = odtOrdenesEmbarcadas.Compute("SUM(" & Columna_Costo_Origen & ")", "")
    '                    MontoCostoVarDolar = odtOrdenesEmbarcadas.Compute("SUM(" & Columna_Costo_Dolar & ")", "")
    '                    odtOrdenesEmbarcadas.Rows(Fila_Ajuste)(Columna_Costo_Origen) = odtOrdenesEmbarcadas.Rows(Fila_Ajuste)("COSTO_ORIGEN_" & ItemConcepto) + (drCostoOTSGAS(0)("IVLORG") - MontoCostoVarOrigen)
    '                    odtOrdenesEmbarcadas.Rows(Fila_Ajuste)(Columna_Costo_Dolar) = odtOrdenesEmbarcadas.Rows(Fila_Ajuste)("COSTO_DOLAR_" & ItemConcepto) + (drCostoOTSGAS(0)("IVLDOL") - MontoCostoVarDolar)

    '                    For Each Item As DataRow In odtOrdenesEmbarcadas.Rows
    '                        obeDistribucionCostoxItemOC = New beDistribucionCostoxItemOC
    '                        obeDistribucionCostoxItemOC.PNNORSCI = NORSCI
    '                        obeDistribucionCostoxItemOC.PNCCLNT = PNCCLNT
    '                        obeDistribucionCostoxItemOC.PSNORCML = Item("NORCML").ToString.Trim
    '                        obeDistribucionCostoxItemOC.PNNRITEM = Item("NRITOC")
    '                        obeDistribucionCostoxItemOC.PNNRPEMB = Item("NRPEMB")
    '                        obeDistribucionCostoxItemOC.PSCODVAR = ItemConcepto
    '                        obeDistribucionCostoxItemOC.PNIVLDOL = Item(Columna_Costo_Dolar)
    '                        obeDistribucionCostoxItemOC.PNIVLORG = Item(Columna_Costo_Origen)
    '                        obeDistribucionCostoxItemOC.PNCMNDA1 = 100
    '                        obeDistribucionCostoxItemOC.PSNMONOC = "USD"
    '                        obeDistribucionCostoxItemOC.PNQRLCSC = Item("QRLCSC")
    '                        obeDistribucionCostoxItemOC.PNFULTAC = PNFECHA
    '                        obeDistribucionCostoxItemOC.PNHULTAC = PNHORA
    '                        brCostoItem.Distribuir_Concepto_x_Item(obeDistribucionCostoxItemOC)
    '                    Next

    '                End If

    '            End If

    '        Next


    '    End If
    'End Sub


    Public Sub Distribuir_Costos_Ordenes_Embarcadas(ByVal PNCCLNT As Decimal, ByVal NORSCI As Decimal, ByVal ListCost As List(Of String))
        Dim odtOrdenesEmbarcadas As New DataTable
        Dim brCostoItem As New Datos.clsCostoItem
        Dim odtCostoTotales As New DataTable
        Dim oDocApertura As New clsDocApertura
        Dim MontoTotalOC As Decimal = 0
        Dim PNFECHA As Decimal = Format(Now, "yyyyMMdd")
        Dim PNHORA As Decimal = Format(Now, "HHmmss")
        Dim Fila_Ajuste As Int32 = 0
        Dim Monto_Ajuste_Mayor As Decimal = 0
        Dim Columna_Costo_Origen As String = ""
        Dim Columna_Costo_Dolar As String = ""
        Dim msgValidacion As String = ""
        'Dim ListCostPostCIF As New List(Of String)


        'ListCostPostCIF.Add("TASDES")
        'ListCostPostCIF.Add("SOBTAS")
        'ListCostPostCIF.Add("DERESP")
        'ListCostPostCIF.Add("ANTDUM")
        'ListCostPostCIF.Add("IMSECO")
        'ListCostPostCIF.Add("INTCOM")
        'ListCostPostCIF.Add("MORA")

        odtOrdenesEmbarcadas = oCostoItem.Lista_Ordenes_Embarcadas_A_Distribuir(PNCCLNT, NORSCI)
        odtOrdenesEmbarcadas.Columns.Add("IMPORTE_PARCIAL", Type.GetType("System.Decimal"))
        For Each ItemCosto As String In ListCost
            odtOrdenesEmbarcadas.Columns.Add("COSTO_ORIGEN_" & ItemCosto, Type.GetType("System.Decimal"))
            odtOrdenesEmbarcadas.Columns.Add("COSTO_DOLAR_" & ItemCosto, Type.GetType("System.Decimal"))
        Next

        odtCostoTotales = oDocApertura.Lista_Costos_Totales_Embarque(NORSCI).Tables("dtCosto")
        Dim drCosto() As DataRow
        Dim MontoDolar As Decimal = 0
        Dim MontoOrigen As Decimal = 0
        Dim obeDistribucionCostoxItemOC As beDistribucionCostoxItemOC
        Dim SubTotal As Decimal = 0

        Monto_Ajuste_Mayor = 0
        For Fila As Integer = 0 To odtOrdenesEmbarcadas.Rows.Count - 1
            SubTotal = (odtOrdenesEmbarcadas.Rows(Fila)("IVUNIT") * odtOrdenesEmbarcadas.Rows(Fila)("QRLCSC") * odtOrdenesEmbarcadas.Rows(Fila)("QTPCM2"))
            MontoTotalOC = MontoTotalOC + SubTotal
            odtOrdenesEmbarcadas.Rows(Fila)("IMPORTE_PARCIAL") = SubTotal
            If odtOrdenesEmbarcadas.Rows(Fila)("IMPORTE_PARCIAL") > Monto_Ajuste_Mayor Then
                Fila_Ajuste = Fila
            End If
        Next
     
        Dim MontoCostoVarOrigen As Decimal = 0
        Dim MontoCostoVarDolar As Decimal = 0

        Dim odtCostosDistribuidos As New DataTable

        Dim drCostoCIF() As DataRow
        Dim drCostoOTSGAS() As DataRow

        If (MontoTotalOC > 0) Then
            'los costos (<> cif ,se distribuyen en base a su factor (Monto x Item / Monto Total OC) x Monto del respectivo costo
            For Each ItemConcepto As String In ListCost
                Columna_Costo_Origen = "COSTO_ORIGEN_" & ItemConcepto
                Columna_Costo_Dolar = "COSTO_DOLAR_" & ItemConcepto
                'If ItemConcepto <> "CIF" AndAlso Not ListCostPostCIF.Contains(ItemConcepto) Then
                If ItemConcepto <> "CIF" AndAlso (ItemConcepto = "ITTEXW" OrElse ItemConcepto = "GFOB" OrElse ItemConcepto = "FOB" OrElse ItemConcepto = "FLETE" OrElse ItemConcepto = "SEGURO") Then
                    drCosto = odtCostoTotales.Select("CODVAR='" & ItemConcepto & "'")
                    For Each Item As DataRow In odtOrdenesEmbarcadas.Rows
                        MontoOrigen = Math.Round((Item("IVUNIT") / MontoTotalOC) * Item("QRLCSC") * Item("QTPCM2") * drCosto(0)("IVLORG"), 5)
                        MontoDolar = Math.Round((Item("IVUNIT") / MontoTotalOC) * Item("QRLCSC") * Item("QTPCM2") * drCosto(0)("IVLDOL"), 5)
                        Item(Columna_Costo_Origen) = MontoOrigen
                        Item(Columna_Costo_Dolar) = MontoDolar
                    Next
                    MontoCostoVarOrigen = odtOrdenesEmbarcadas.Compute("SUM(" & Columna_Costo_Origen & ")", "")
                    MontoCostoVarDolar = odtOrdenesEmbarcadas.Compute("SUM(" & Columna_Costo_Dolar & ")", "")
                    odtOrdenesEmbarcadas.Rows(Fila_Ajuste)(Columna_Costo_Origen) = odtOrdenesEmbarcadas.Rows(Fila_Ajuste)("COSTO_ORIGEN_" & ItemConcepto) + (drCosto(0)("IVLORG") - MontoCostoVarOrigen)
                    odtOrdenesEmbarcadas.Rows(Fila_Ajuste)(Columna_Costo_Dolar) = odtOrdenesEmbarcadas.Rows(Fila_Ajuste)("COSTO_DOLAR_" & ItemConcepto) + (drCosto(0)("IVLORG") - MontoCostoVarDolar)

                    For Each Item As DataRow In odtOrdenesEmbarcadas.Rows
                        obeDistribucionCostoxItemOC = New beDistribucionCostoxItemOC
                        obeDistribucionCostoxItemOC.PNNORSCI = NORSCI
                        obeDistribucionCostoxItemOC.PNCCLNT = PNCCLNT
                        obeDistribucionCostoxItemOC.PSNORCML = Item("NORCML").ToString.Trim
                        obeDistribucionCostoxItemOC.PNNRITEM = Item("NRITOC")
                        obeDistribucionCostoxItemOC.PNNRPEMB = Item("NRPEMB")
                        obeDistribucionCostoxItemOC.PSCODVAR = ItemConcepto
                        obeDistribucionCostoxItemOC.PNIVLDOL = Item(Columna_Costo_Dolar)
                        obeDistribucionCostoxItemOC.PNIVLORG = Item(Columna_Costo_Origen)
                        obeDistribucionCostoxItemOC.PNCMNDA1 = 100
                        obeDistribucionCostoxItemOC.PSNMONOC = "USD"
                        obeDistribucionCostoxItemOC.PNQRLCSC = Item("QRLCSC")
                        obeDistribucionCostoxItemOC.PNFULTAC = PNFECHA
                        obeDistribucionCostoxItemOC.PNHULTAC = PNHORA
                        brCostoItem.Distribuir_Concepto_x_Item(obeDistribucionCostoxItemOC)
                    Next

                ElseIf ItemConcepto = "CIF" Then
                    odtCostosDistribuidos = oDocApertura.Lista_Costos_Distribuidos_Embarque(NORSCI)

                    Dim MontoOr As Object
                    Dim MontoDolarObj As Object
                    For Each Item As DataRow In odtOrdenesEmbarcadas.Rows
                        MontoOr = odtCostosDistribuidos.Compute("SUM(IVLORG)", "NRPEMB=" & Item("NRPEMB") & " AND CODVAR IN ('FOB','FLETE','SEGURO')")
                        MontoDolarObj = odtCostosDistribuidos.Compute("SUM(IVLDOL)", "NRPEMB=" & Item("NRPEMB") & " AND CODVAR IN ('FOB','FLETE','SEGURO')")
                        If MontoOr Is DBNull.Value Then
                            MontoOrigen = 0
                        Else
                            MontoOrigen = MontoOr
                        End If
                        If MontoDolarObj Is DBNull.Value Then
                            MontoDolar = 0
                        Else
                            MontoDolar = MontoDolarObj
                        End If
                        obeDistribucionCostoxItemOC = New beDistribucionCostoxItemOC
                        obeDistribucionCostoxItemOC.PNNORSCI = NORSCI
                        obeDistribucionCostoxItemOC.PNCCLNT = PNCCLNT
                        obeDistribucionCostoxItemOC.PSNORCML = Item("NORCML").ToString.Trim
                        obeDistribucionCostoxItemOC.PNNRITEM = Item("NRITOC")
                        obeDistribucionCostoxItemOC.PNNRPEMB = Item("NRPEMB")
                        obeDistribucionCostoxItemOC.PSCODVAR = ItemConcepto
                        obeDistribucionCostoxItemOC.PNIVLDOL = MontoDolar
                        obeDistribucionCostoxItemOC.PNIVLORG = MontoOrigen
                        obeDistribucionCostoxItemOC.PNCMNDA1 = 100
                        obeDistribucionCostoxItemOC.PSNMONOC = "USD"
                        obeDistribucionCostoxItemOC.PNQRLCSC = Item("QRLCSC")
                        obeDistribucionCostoxItemOC.PNFULTAC = PNFECHA
                        obeDistribucionCostoxItemOC.PNHULTAC = PNHORA
                        brCostoItem.Distribuir_Concepto_x_Item(obeDistribucionCostoxItemOC)
                    Next
                Else
                    'If ListCostPostCIF.Contains(ItemConcepto) Then
                    odtCostosDistribuidos = oDocApertura.Lista_Costos_Distribuidos_Embarque(NORSCI)
                    drCostoCIF = odtCostoTotales.Select("CODVAR='CIF'")
                    drCostoOTSGAS = odtCostoTotales.Select("CODVAR='" & ItemConcepto & "'")
                    If drCostoOTSGAS.Length > 0 Then
                        For Each Item As DataRow In odtOrdenesEmbarcadas.Rows
                            drCosto = odtCostosDistribuidos.Select("NRPEMB=" & Item("NRPEMB") & " AND CODVAR ='CIF'")
                            If drCostoCIF.Length > 0 AndAlso drCosto.Length > 0 Then
                                MontoOrigen = Math.Round((drCosto(0)("IVLORG") / drCostoCIF(0)("IVLORG")) * drCostoOTSGAS(0)("IVLORG"), 5)
                                MontoDolar = Math.Round((drCosto(0)("IVLDOL") / drCostoCIF(0)("IVLDOL")) * drCostoOTSGAS(0)("IVLDOL"), 5)
                            Else
                                MontoOrigen = 0
                                MontoDolar = 0
                            End If

                            Item(Columna_Costo_Origen) = MontoOrigen
                            Item(Columna_Costo_Dolar) = MontoDolar
                        Next
                        MontoCostoVarOrigen = odtOrdenesEmbarcadas.Compute("SUM(" & Columna_Costo_Origen & ")", "")
                        MontoCostoVarDolar = odtOrdenesEmbarcadas.Compute("SUM(" & Columna_Costo_Dolar & ")", "")
                        odtOrdenesEmbarcadas.Rows(Fila_Ajuste)(Columna_Costo_Origen) = odtOrdenesEmbarcadas.Rows(Fila_Ajuste)("COSTO_ORIGEN_" & ItemConcepto) + (drCostoOTSGAS(0)("IVLORG") - MontoCostoVarOrigen)
                        odtOrdenesEmbarcadas.Rows(Fila_Ajuste)(Columna_Costo_Dolar) = odtOrdenesEmbarcadas.Rows(Fila_Ajuste)("COSTO_DOLAR_" & ItemConcepto) + (drCostoOTSGAS(0)("IVLDOL") - MontoCostoVarDolar)

                        For Each Item As DataRow In odtOrdenesEmbarcadas.Rows
                            obeDistribucionCostoxItemOC = New beDistribucionCostoxItemOC
                            obeDistribucionCostoxItemOC.PNNORSCI = NORSCI
                            obeDistribucionCostoxItemOC.PNCCLNT = PNCCLNT
                            obeDistribucionCostoxItemOC.PSNORCML = Item("NORCML").ToString.Trim
                            obeDistribucionCostoxItemOC.PNNRITEM = Item("NRITOC")
                            obeDistribucionCostoxItemOC.PNNRPEMB = Item("NRPEMB")
                            obeDistribucionCostoxItemOC.PSCODVAR = ItemConcepto
                            obeDistribucionCostoxItemOC.PNIVLDOL = Item(Columna_Costo_Dolar)
                            obeDistribucionCostoxItemOC.PNIVLORG = Item(Columna_Costo_Origen)
                            obeDistribucionCostoxItemOC.PNCMNDA1 = 100
                            obeDistribucionCostoxItemOC.PSNMONOC = "USD"
                            obeDistribucionCostoxItemOC.PNQRLCSC = Item("QRLCSC")
                            obeDistribucionCostoxItemOC.PNFULTAC = PNFECHA
                            obeDistribucionCostoxItemOC.PNHULTAC = PNHORA
                            brCostoItem.Distribuir_Concepto_x_Item(obeDistribucionCostoxItemOC)
                        Next
                    End If
                End If
            Next
        End If
    End Sub


    'Public Sub Distribuir_Costos_Ordenes_Embarcadas_Masivo(ByVal PNCCLNT As Decimal)
    '    Dim ListCost As New List(Of String)
    '    Dim odtOrdenesEmbarcadas As New DataTable
    '    Dim odtEmbarqueDistribuir As New DataTable
    '    Dim brCostoItem As New Datos.clsCostoItem
    '    Dim odtCostoTotales As New DataTable
    '    Dim oDocApertura As New clsDocApertura
    '    Dim MontoTotalOC As Decimal = 0
    '    Dim PNFECHA As Decimal = Format(Now, "yyyyMMdd")
    '    Dim PNHORA As Decimal = Format(Now, "HHmmss")
    '    ListCost.Add("ADVALO")
    '    ListCost.Add("CIF")
    '    ListCost.Add("FLETE")
    '    ListCost.Add("FOB")
    '    ListCost.Add("IGV")
    '    ListCost.Add("IPM")
    '    ListCost.Add("ITTCAG")
    '    ListCost.Add("ITTGOA")
    '    ListCost.Add("OTSGAS")
    '    ListCost.Add("SEGURO")
    '    ListCost.Add("ITTRAC")

    '    odtEmbarqueDistribuir = brCostoItem.Lista_Embarques_A_Distribuir(PNCCLNT)
    '    Dim NORSCI As Decimal = 0
    '    For Each ItemEmbarque As DataRow In odtEmbarqueDistribuir.Rows
    '        NORSCI = ItemEmbarque("NORSCI")
    '        odtOrdenesEmbarcadas = oCostoItem.Lista_Ordenes_Embarcadas_A_Distribuir(PNCCLNT, NORSCI)
    '        odtCostoTotales = oDocApertura.Lista_Costos_Totales_Embarque(NORSCI).Tables("dtCosto")
    '        Dim drCosto() As DataRow
    '        Dim MontoDolar As Decimal = 0
    '        Dim MontoOrigen As Decimal = 0
    '        Dim obeDistribucionCostoxItemOC As beDistribucionCostoxItemOC
    '        For Each Item As DataRow In odtOrdenesEmbarcadas.Rows
    '            MontoTotalOC = MontoTotalOC + (Item("IVUNIT") * Item("QRLCSC") * Item("QTPCM2"))
    '        Next
    '        If (MontoTotalOC > 0) Then
    '            For Each Item As DataRow In odtOrdenesEmbarcadas.Rows
    '                For Each ItemConcepto As String In ListCost
    '                    If ItemConcepto <> "CIF" Then
    '                        drCosto = odtCostoTotales.Select("CODVAR='" & ItemConcepto & "'")
    '                        MontoOrigen = Math.Round((Item("IVUNIT") / MontoTotalOC) * Item("QRLCSC") * Item("QTPCM2") * drCosto(0)("IVLORG"), 5)
    '                        MontoDolar = Math.Round((Item("IVUNIT") / MontoTotalOC) * Item("QRLCSC") * Item("QTPCM2") * drCosto(0)("IVLDOL"), 5)

    '                        obeDistribucionCostoxItemOC = New beDistribucionCostoxItemOC
    '                        obeDistribucionCostoxItemOC.PNNORSCI = NORSCI
    '                        obeDistribucionCostoxItemOC.PNCCLNT = PNCCLNT
    '                        obeDistribucionCostoxItemOC.PSNORCML = Item("NORCML").ToString.Trim
    '                        obeDistribucionCostoxItemOC.PNNRITEM = Item("NRITOC")
    '                        obeDistribucionCostoxItemOC.PNNRPEMB = Item("NRPEMB")
    '                        obeDistribucionCostoxItemOC.PSCODVAR = ItemConcepto
    '                        obeDistribucionCostoxItemOC.PNIVLDOL = MontoDolar
    '                        obeDistribucionCostoxItemOC.PNIVLORG = MontoOrigen
    '                        obeDistribucionCostoxItemOC.PNCMNDA1 = 100
    '                        obeDistribucionCostoxItemOC.PSNMONOC = "USD"
    '                        obeDistribucionCostoxItemOC.PNQRLCSC = Item("QRLCSC")
    '                        obeDistribucionCostoxItemOC.PNFULTAC = PNFECHA
    '                        obeDistribucionCostoxItemOC.PNHULTAC = PNHORA
    '                        brCostoItem.Distribuir_Concepto_x_Item(obeDistribucionCostoxItemOC)
    '                    End If
    '                Next
    '            Next

    '            If (ListCost.Contains("CIF")) Then
    '                Dim odtCostosDistribuidos As New DataTable
    '                Dim NORCML As String = ""
    '                Dim NRITOC As Decimal = 0
    '                Dim NRPEMB As Decimal = 0
    '                odtCostosDistribuidos = oDocApertura.Lista_Costos_Distribuidos_Embarque(NORSCI)
    '                For Each Item As DataRow In odtOrdenesEmbarcadas.Rows
    '                    NORCML = Item("NORCML").ToString.Trim
    '                    NRITOC = Item("NRITOC")
    '                    NRPEMB = Item("NRPEMB")
    '                    MontoOrigen = 0
    '                    MontoDolar = 0
    '                    drCosto = odtCostosDistribuidos.Select("NORCML='" & NORCML & "' AND NRITEM=" & NRITOC & " AND NRPEMB=" & NRPEMB & " AND CODVAR IN ('ITTEXW','GFOB','FOB','FLETE','SEGURO')")
    '                    For Each ItemCosto As DataRow In drCosto
    '                        MontoOrigen = MontoOrigen + ItemCosto("IVLORG")
    '                        MontoDolar = MontoDolar + ItemCosto("IVLDOL")
    '                    Next
    '                    obeDistribucionCostoxItemOC = New beDistribucionCostoxItemOC
    '                    obeDistribucionCostoxItemOC.PNNORSCI = NORSCI
    '                    obeDistribucionCostoxItemOC.PNCCLNT = PNCCLNT
    '                    obeDistribucionCostoxItemOC.PSNORCML = Item("NORCML").ToString.Trim
    '                    obeDistribucionCostoxItemOC.PNNRITEM = Item("NRITOC")
    '                    obeDistribucionCostoxItemOC.PNNRPEMB = Item("NRPEMB")
    '                    obeDistribucionCostoxItemOC.PSCODVAR = "CIF"
    '                    obeDistribucionCostoxItemOC.PNIVLDOL = MontoDolar
    '                    obeDistribucionCostoxItemOC.PNIVLORG = MontoOrigen
    '                    obeDistribucionCostoxItemOC.PNCMNDA1 = 100
    '                    obeDistribucionCostoxItemOC.PSNMONOC = "USD"
    '                    obeDistribucionCostoxItemOC.PNQRLCSC = Item("QRLCSC")
    '                    obeDistribucionCostoxItemOC.PNFULTAC = PNFECHA
    '                    obeDistribucionCostoxItemOC.PNHULTAC = PNHORA
    '                    brCostoItem.Distribuir_Concepto_x_Item(obeDistribucionCostoxItemOC)
    '                Next
    '            End If


    '        End If

    '    Next
    'End Sub

    Public Function Lista_Costos_Agencias_X_OS(ByVal PSCCMPN As String, ByVal PNCCLNT As Decimal, ByVal PNPNNMOS As Decimal) As DataSet
        Return oCostoItem.Lista_Costos_Agencias_X_OS(PSCCMPN, PNCCLNT, PNPNNMOS)
    End Function

    Public Function Lista_Item_Cierre_Orden_Compra(ByVal PSCCMPN As String, ByVal PNCCLNT As Decimal, ByVal PSNORCML As String) As DataTable
        Dim ds As New DataSet
        Dim dtJoin As New DataTable

        dtJoin.Columns.Add("CCLNT", Type.GetType("System.Decimal"))
        dtJoin.Columns.Add("NORCML", Type.GetType("System.String"))
        dtJoin.Columns.Add("NRITEM", Type.GetType("System.Decimal"))

        dtJoin.Columns.Add("QCNTIT", Type.GetType("System.Decimal"))
        dtJoin.Columns.Add("IVUNIT", Type.GetType("System.Decimal"))
      
        dtJoin.Columns.Add("PNNMOS", Type.GetType("System.Decimal"))
        dtJoin.Columns.Add("TNRODU", Type.GetType("System.String"))
        dtJoin.Columns.Add("NSERIE", Type.GetType("System.Decimal"))
        dtJoin.Columns.Add("NDOCEM", Type.GetType("System.String")) 'BL,AWB
        dtJoin.Columns.Add("TDITES", Type.GetType("System.String"))
        dtJoin.Columns.Add("NFCTCM", Type.GetType("System.String"))
        dtJoin.Columns.Add("TTINTC", Type.GetType("System.String"))
        dtJoin.Columns.Add("VALMRC", Type.GetType("System.Decimal"))
        dtJoin.Columns.Add("GFOB", Type.GetType("System.Decimal"))
        dtJoin.Columns.Add("TOTFOB", Type.GetType("System.Decimal"))
        dtJoin.Columns.Add("TOTFLT", Type.GetType("System.Decimal"))
        dtJoin.Columns.Add("TOTSEG", Type.GetType("System.Decimal"))
        dtJoin.Columns.Add("TOTCIF", Type.GetType("System.Decimal"))
        dtJoin.Columns.Add("TOTADV", Type.GetType("System.Decimal"))
        dtJoin.Columns.Add("TOTIGV", Type.GetType("System.Decimal"))
        dtJoin.Columns.Add("TOTIPM", Type.GetType("System.Decimal"))

        Dim dtItemOC As New DataTable
        Dim dtItemEmb As New DataTable
        Dim dtCosto As New DataTable
        ds = oCostoItem.Lista_Item_Cierre_Orden_Compra(PSCCMPN, PNCCLNT, PSNORCML)
        dtItemOC = ds.Tables("dtItemOC")
        dtItemEmb = ds.Tables("dtItemEmb")
        dtItemEmb.Columns.Add("COD_UNICO")

        Dim oList As New List(Of String)
        Dim Cod_Item_NDUA As String = ""
        Dim NRITOC As Decimal = 0
        Dim NRODUA As String = ""
        For Fila As Integer = 0 To dtItemEmb.Rows.Count - 1
            dtItemEmb.Rows(Fila)("COD_UNICO") = dtItemEmb.Rows(Fila)("NRITEM") & "_" & ("" & dtItemEmb.Rows(Fila)("TNRODU")).ToString.Trim
        Next

        Dim TotalFilas As Int32 = dtItemEmb.Rows.Count - 1
        For Fila As Integer = 0 To TotalFilas
            If Fila <= TotalFilas Then
                Cod_Item_NDUA = dtItemEmb.Rows(Fila)("COD_UNICO")
                If Not oList.Contains(Cod_Item_NDUA) Then
                    oList.Add(Cod_Item_NDUA)
                    dtItemEmb.Rows(Fila)("TOTFOB") = dtItemEmb.Compute("Sum(TOTFOB)", "COD_UNICO='" & Cod_Item_NDUA & "'")
                    dtItemEmb.Rows(Fila)("TOTFLT") = dtItemEmb.Compute("Sum(TOTFLT)", "COD_UNICO='" & Cod_Item_NDUA & "'")
                    dtItemEmb.Rows(Fila)("TOTSEG") = dtItemEmb.Compute("Sum(TOTSEG)", "COD_UNICO='" & Cod_Item_NDUA & "'")
                    dtItemEmb.Rows(Fila)("TOTCIF") = dtItemEmb.Compute("Sum(TOTCIF)", "COD_UNICO='" & Cod_Item_NDUA & "'")
                    dtItemEmb.Rows(Fila)("TOTADV") = dtItemEmb.Compute("Sum(TOTADV)", "COD_UNICO='" & Cod_Item_NDUA & "'")
                    dtItemEmb.Rows(Fila)("TOTIGV") = dtItemEmb.Compute("Sum(TOTIGV)", "COD_UNICO='" & Cod_Item_NDUA & "'")
                    dtItemEmb.Rows(Fila)("TOTIPM") = dtItemEmb.Compute("Sum(TOTIPM)", "COD_UNICO='" & Cod_Item_NDUA & "'")
                    dtItemEmb.Rows(Fila)("TOTOGS") = dtItemEmb.Compute("Sum(TOTOGS)", "COD_UNICO='" & Cod_Item_NDUA & "'")
                    dtItemEmb.Rows(Fila)("GFOB") = dtItemEmb.Compute("Sum(GFOB)", "COD_UNICO='" & Cod_Item_NDUA & "'")
                    dtItemEmb.Rows(Fila)("ITTEXW") = dtItemEmb.Compute("Sum(ITTEXW)", "COD_UNICO='" & Cod_Item_NDUA & "'")
                Else
                    dtItemEmb.Rows.RemoveAt(Fila)
                    Fila = Fila - 1
                    TotalFilas = TotalFilas - 1
                End If
            End If          
        Next
        dtItemEmb.Columns.Remove("SBITOC")

        Dim dr() As DataRow
        Dim drNew As DataRow
        TotalFilas = dtItemOC.Rows.Count - 1
        For Fila As Integer = 0 To TotalFilas
            NRITOC = dtItemOC.Rows(Fila)("NRITOC")
            dr = dtItemEmb.Select("NRITEM='" & NRITOC & "'")
            If dr.Length > 0 Then
                For Each Item As DataRow In dr
                    drNew = dtJoin.NewRow
                    drNew("CCLNT") = dtItemOC.Rows(Fila)("CCLNT")
                    drNew("NORCML") = ("" & dtItemOC.Rows(Fila)("NORCML")).ToString.Trim
                    drNew("NRITEM") = dtItemOC.Rows(Fila)("NRITOC")
                    drNew("QCNTIT") = dtItemOC.Rows(Fila)("QCNTIT")
                    drNew("IVUNIT") = dtItemOC.Rows(Fila)("IVUNIT")
                    drNew("PNNMOS") = Item("PNNMOS")
                    drNew("TNRODU") = ("" & Item("TNRODU")).ToString.Trim
                    drNew("NSERIE") = 0
                    drNew("TDITES") = ("" & dtItemOC.Rows(Fila)("TDITES")).ToString.Trim
                    drNew("NFCTCM") = ""
                    drNew("TTINTC") = ("" & dtItemOC.Rows(Fila)("TTINTC")).ToString.Trim
                    drNew("NDOCEM") = Item("NDOCEM")
                    drNew("VALMRC") = 0
                    drNew("GFOB") = Item("GFOB")
                    drNew("TOTFOB") = Item("TOTFOB")
                    drNew("TOTFLT") = Item("TOTFLT")
                    drNew("TOTSEG") = Item("TOTSEG")
                    drNew("TOTCIF") = Item("TOTCIF")
                    drNew("TOTADV") = Item("TOTADV")
                    drNew("TOTIGV") = Item("TOTIGV")
                    drNew("TOTIPM") = Item("TOTIPM")
                    dtJoin.Rows.Add(drNew)
                Next
            Else
                drNew = dtJoin.NewRow
                drNew("CCLNT") = dtItemOC.Rows(Fila)("CCLNT")
                drNew("NORCML") = ("" & dtItemOC.Rows(Fila)("NORCML")).ToString.Trim
                drNew("NRITEM") = dtItemOC.Rows(Fila)("NRITOC")
                drNew("QCNTIT") = dtItemOC.Rows(Fila)("QCNTIT")
                drNew("IVUNIT") = dtItemOC.Rows(Fila)("IVUNIT")
                drNew("PNNMOS") = 0
                drNew("TNRODU") = ""
                drNew("NSERIE") = 0
                drNew("TDITES") = ("" & dtItemOC.Rows(Fila)("TDITES")).ToString.Trim
                drNew("NFCTCM") = ""
                drNew("TTINTC") = ("" & dtItemOC.Rows(Fila)("TTINTC")).ToString.Trim
                drNew("NDOCEM") = ""
                drNew("VALMRC") = 0
                drNew("GFOB") = 0
                drNew("TOTFOB") = 0
                drNew("TOTFLT") = 0
                drNew("TOTSEG") = 0
                drNew("TOTCIF") = 0
                drNew("TOTADV") = 0
                drNew("TOTIGV") = 0
                drNew("TOTIPM") = 0
                dtJoin.Rows.Add(drNew)

            
            End If
        Next

        Return dtJoin
    End Function

    Public Function Lista_Item_Cierre_Orden_Compra_Embarcado(ByVal PSCCMPN As String, ByVal PNCCLNT As Decimal, ByVal PSNORCML As String) As DataTable
        Dim dtItemEmb As New DataTable
        dtItemEmb = oCostoItem.Lista_Item_Cierre_Orden_Compra_Embarcado(PSCCMPN, PNCCLNT, PSNORCML)
        dtItemEmb.Columns.Add("COD_UNICO")
        Dim oList As New List(Of String)
        Dim Cod_Item_NDUA As String = ""
        Dim NRITOC As Decimal = 0
        Dim NRODUA As String = ""
        Dim PNNMOS As String = ""
        For Fila As Integer = 0 To dtItemEmb.Rows.Count - 1
            PNNMOS = ("" & dtItemEmb.Rows(Fila)("PNNMOS")).ToString.Trim
            If PNNMOS = "0" Then
                dtItemEmb.Rows(Fila)("PNNMOS") = ""
            End If
            dtItemEmb.Rows(Fila)("COD_UNICO") = dtItemEmb.Rows(Fila)("NRITEM") & "_" & ("" & dtItemEmb.Rows(Fila)("TNRODU")).ToString.Trim
        Next
        Dim TotalFilas As Int32 = dtItemEmb.Rows.Count - 1
        For Fila As Integer = 0 To TotalFilas
            If Fila <= TotalFilas Then
                Cod_Item_NDUA = dtItemEmb.Rows(Fila)("COD_UNICO")
                If Not oList.Contains(Cod_Item_NDUA) Then
                    oList.Add(Cod_Item_NDUA)
                    dtItemEmb.Rows(Fila)("VAL_MERCAD_FACTURA") = dtItemEmb.Compute("Sum(VAL_MERCAD_FACTURA)", "COD_UNICO='" & Cod_Item_NDUA & "'")
                    dtItemEmb.Rows(Fila)("TOTFOB") = dtItemEmb.Compute("Sum(TOTFOB)", "COD_UNICO='" & Cod_Item_NDUA & "'")
                    dtItemEmb.Rows(Fila)("TOTFLT") = dtItemEmb.Compute("Sum(TOTFLT)", "COD_UNICO='" & Cod_Item_NDUA & "'")
                    dtItemEmb.Rows(Fila)("TOTSEG") = dtItemEmb.Compute("Sum(TOTSEG)", "COD_UNICO='" & Cod_Item_NDUA & "'")
                    dtItemEmb.Rows(Fila)("TOTCIF") = dtItemEmb.Compute("Sum(TOTCIF)", "COD_UNICO='" & Cod_Item_NDUA & "'")
                    dtItemEmb.Rows(Fila)("TOTADV") = dtItemEmb.Compute("Sum(TOTADV)", "COD_UNICO='" & Cod_Item_NDUA & "'")
                    dtItemEmb.Rows(Fila)("TOTIGV") = dtItemEmb.Compute("Sum(TOTIGV)", "COD_UNICO='" & Cod_Item_NDUA & "'")
                    dtItemEmb.Rows(Fila)("TOTIPM") = dtItemEmb.Compute("Sum(TOTIPM)", "COD_UNICO='" & Cod_Item_NDUA & "'")
                    'dtItemEmb.Rows(Fila)("TOTOGS") = dtItemEmb.Compute("Sum(TOTOGS)", "COD_UNICO='" & Cod_Item_NDUA & "'")
                    dtItemEmb.Rows(Fila)("TASDES") = dtItemEmb.Compute("Sum(TASDES)", "COD_UNICO='" & Cod_Item_NDUA & "'")
                    dtItemEmb.Rows(Fila)("GFOB") = dtItemEmb.Compute("Sum(GFOB)", "COD_UNICO='" & Cod_Item_NDUA & "'")
                    dtItemEmb.Rows(Fila)("ITTEXW") = dtItemEmb.Compute("Sum(ITTEXW)", "COD_UNICO='" & Cod_Item_NDUA & "'")
                Else
                    dtItemEmb.Rows.RemoveAt(Fila)
                    Fila = Fila - 1
                    TotalFilas = TotalFilas - 1
                End If
            End If
        Next
        dtItemEmb.Columns.Remove("SBITOC")
        Return dtItemEmb
    End Function

End Class
