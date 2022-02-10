
Imports System.Windows.Forms
Imports System.Text
Imports SOLMIN_SC.Entidad
Imports Ransa.Utilitario
Public Class clsEmbarqueAduanas
    Public Function Buscar_Doc_Pendiente(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow
        oDr = poDt.Select("NTPODT = 12 AND NCODRG = 1 AND NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            strCadena = HelpClass.ToStringCvr(oDr(0)("TXT01"))
        End If
        Return strCadena
    End Function
    Public Function Buscar_Proforma(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow

        oDr = poDt.Select("NTPODT = 11 AND NCODRG = 1 AND NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            strCadena = HelpClass.ToStringCvr(oDr(0)("TXT01"))
        End If
        Return strCadena
    End Function


    Public Function DespachoDesc_X_Embarque(ByVal oListDespacho As List(Of beTipoDato), ByVal poDt As DataTable, ByVal NORSCI As Decimal) As String
        Dim strCadena As String = ""
        Dim NCODRG As Decimal = 0
        Dim oDr() As DataRow
        oDr = poDt.Select("NTPODT=8 AND NORSCI=" & NORSCI)
        If oDr.Length > 0 Then
            NCODRG = oDr(0).Item("NCODRG")
            strCadena = DespachoDesc_X_Codigo(oListDespacho, NCODRG)
        End If
        Return strCadena
    End Function

    Public Function DespachoDesc_X_Codigo(ByVal oListDespacho As List(Of beTipoDato), ByVal COD_DESPACHO As Decimal) As String
        Dim oFindRegimen As New beTipoDato
        Dim PSTDSCRG_DESPACHO As String = ""
        For Each Item As beTipoDato In oListDespacho
            If Item.PNNTPODT = 8 AndAlso Item.PNNCODRG = COD_DESPACHO Then
                PSTDSCRG_DESPACHO = Item.PSTDSCRG
                Exit For
            End If
        Next
        Return PSTDSCRG_DESPACHO
    End Function


    Public Function DespachoCodigo_X_Descripcion(ByVal oListDespacho As List(Of beTipoDato), ByVal DESC_DESPACHO As String) As Decimal
        Dim oFindRegimen As New beTipoDato
        Dim PNNCODRG As Decimal = 0
        For Each Item As beTipoDato In oListDespacho
            If Item.PNNTPODT = 8 AndAlso Item.PSTDSCRG = DESC_DESPACHO Then
                PNNCODRG = Item.PNNCODRG
                Exit For
            End If
        Next
        Return PNNCODRG
    End Function




  




    Public Function RegimenCodigo_X_Descripcion(ByVal oListRegimen As List(Of beRegimen), ByVal DESC_REGIMEN As String) As Decimal
        Dim PNNCODRG As Decimal = 0
        Dim obeRegimen As beRegimen
        Dim pred As New Predicate(Of beRegimen)(AddressOf BuscaCodigoRegimenxDescripcion)
        Me.desc_regimen = DESC_REGIMEN
        obeRegimen = oListRegimen.Find(pred)
        If obeRegimen IsNot Nothing Then
            PNNCODRG = obeRegimen.PNTPORGE
        End If
        Return PNNCODRG
    End Function

  

    Public Function RegimenDesc_X_Embarque(ByVal oListRegimen As List(Of beRegimen), ByVal poDt As DataTable, ByVal NORSCI As Decimal) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow
        oDr = poDt.Select("NTPODT=3 AND NORSCI=" & NORSCI)
        Dim obeRegimen As beRegimen
        Dim pred As New Predicate(Of beRegimen)(AddressOf BuscaRegimenxCodigo)
        If oDr.Length > 0 Then
            cod_regimen = oDr(0)("NCODRG")
            obeRegimen = oListRegimen.Find(pred)
            If obeRegimen IsNot Nothing Then
                strCadena = obeRegimen.PSTCMRGA
            End If
        End If
        Return strCadena
    End Function

    Private cod_regimen As Decimal = 0
    Private desc_regimen As String = ""
    Private Function BuscaRegimenxCodigo(ByVal obeRegimen As beRegimen) As Boolean
        Return obeRegimen.PNTPORGE = cod_regimen
    End Function
    Private Function BuscaCodigoRegimenxDescripcion(ByVal obeRegimen As beRegimen) As Boolean
        Return obeRegimen.PSTCMRGA = desc_regimen
    End Function


    Public Function Llenar_Factura(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim strCadena As String = ""
        Dim intCont As Integer
        Dim oDr() As DataRow
        oDr = poDt.Select("NDOCIN = 2 AND NORSCI=" & pdblEmbarque)
        For intCont = 0 To oDr.Length - 1
            strCadena = strCadena & HelpClass.ToStringCvr(oDr(intCont)("NDOCLI"))
            If intCont < oDr.Length - 1 Then
                strCadena = strCadena & vbCrLf
            End If
        Next
        Return strCadena
    End Function


    Public Function Fecha_Llegada_Material_Al_Emb(ByVal poDt As DataTable, ByVal NORSCI As Decimal) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow
        oDr = poDt.Select("NESTDO = 143 AND NORSCI=" & NORSCI)
        If oDr.Length > 0 Then
            strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("DFECREA"))
        End If
        Return strCadena
    End Function


    Public Function Fecha_RecojoMaterial(ByVal poDt As DataTable, ByVal NORSCI As Decimal) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow
        oDr = poDt.Select("NESTDO = 103 AND NORSCI=" & NORSCI)
        If oDr.Length > 0 Then
            strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("DFECREA"))
        End If
        Return strCadena
    End Function


    Public Function Fecha_EntregaProv(ByVal poDt As DataTable, ByVal NORSCI As Decimal) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow
        oDr = poDt.Select("NESTDO = 102 AND NORSCI=" & NORSCI)
        If oDr.Length > 0 Then
            strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("DFECREA"))
        End If
        Return strCadena
    End Function


    Public Function Fecha_AprobacionDocs(ByVal poDt As DataTable, ByVal NORSCI As Decimal) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow

        oDr = poDt.Select("NESTDO = 146 AND NORSCI=" & NORSCI)
        If oDr.Length > 0 Then
            strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("DFECREA"))
        End If
        Return strCadena
    End Function

    Public Function Buscar_Tipo_Entrega(ByVal dtItemOC As DataTable, ByVal NORSCI As Double) As String
        Dim oEmbarque As New clsEmbarque
        Dim oDt As DataTable
        Dim intCont As Integer
        Dim dblTotalOC As Double = 0
        Dim dblTotalEmb As Double = 0
        Dim dr() As DataRow
        oDt = oEmbarque.Lista_Unidades_X_Embarque(NORSCI)
        dblTotalOC = CType(oDt.Rows(0).Item("TOTAL"), Double)
        dr = dtItemOC.Select("NORSCI=" & NORSCI)
        For intCont = 0 To dr.Length - 1
            dblTotalEmb = dblTotalEmb + dr(intCont)("QRLCSC")
        Next intCont
        If dblTotalEmb <> dblTotalOC Then
            Return "PARCIAL"
        End If
        Return "TOTAL"
    End Function


    Public Function Buscar_Doc_Emb(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim strCadena As String = ""
        Dim sbcad As New StringBuilder
        Dim oDr() As DataRow
        Dim listVisit As New List(Of String)
        oDr = poDt.Select("NDOCIN IN (4,5,15)  AND NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            For index As Integer = 0 To oDr.Length - 1
                strCadena = HelpClass.ToStringCvr(oDr(index)("NDOCLI"))
                If strCadena.Length > 0 AndAlso (Not listVisit.Contains(strCadena)) Then
                    sbcad.Append(strCadena)
                    listVisit.Add(strCadena)
                    If index < oDr.Length - 1 Then
                        sbcad.Append(Chr(10))
                    End If
                End If
            Next
        End If
        Return sbcad.ToString.Trim
    End Function

    Public Function Fecha_Factura_Copia(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim oDr() As DataRow
        Dim strCadena As String = ""
        Dim sbcad As New StringBuilder
        Dim listVisit As New List(Of String)
        oDr = poDt.Select("NDOCIN = 2 AND NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            'strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FCDCCP"))
            For index As Integer = 0 To oDr.Length - 1
                strCadena = HelpClass.FechaNum_a_Fecha(oDr(index)("FCDCCP"))
                If strCadena.Length > 0 AndAlso (Not listVisit.Contains(strCadena)) Then
                    sbcad.Append(strCadena)
                    listVisit.Add(strCadena)
                    If index < oDr.Length - 1 Then
                        sbcad.Append(Chr(10))
                    End If
                End If
            Next
        End If
        Return sbcad.ToString.Trim
    End Function


    Public Function Fecha_Factura_Original(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow
        Dim sbcad As New StringBuilder
        Dim listVisit As New List(Of String)

        oDr = poDt.Select("NDOCIN = 2 AND NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            'strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FCDCOR"))
            For index As Integer = 0 To oDr.Length - 1
                strCadena = HelpClass.FechaNum_a_Fecha(oDr(index)("FCDCOR"))
                If strCadena.Length > 0 AndAlso (Not listVisit.Contains(strCadena)) Then
                    sbcad.Append(strCadena)
                    listVisit.Add(strCadena)
                    If index < oDr.Length - 1 Then
                        sbcad.Append(Chr(10))
                    End If
                End If
            Next
        End If
        Return sbcad.ToString.Trim
    End Function



    Public Function Fecha_DocEmbarque_Copia(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow
        Dim sbcad As New StringBuilder
        Dim listVisit As New List(Of String)

        oDr = poDt.Select("NDOCIN IN (4,5,15) AND NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            'strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FCDCCP"))
            For index As Integer = 0 To oDr.Length - 1
                strCadena = HelpClass.FechaNum_a_Fecha(oDr(index)("FCDCCP"))
                If strCadena.Length > 0 AndAlso (Not listVisit.Contains(strCadena)) Then
                    sbcad.Append(strCadena)
                    listVisit.Add(strCadena)
                    If index < oDr.Length - 1 Then
                        sbcad.Append(Chr(10))
                    End If
                End If
            Next
        End If
        Return sbcad.ToString.Trim
    End Function


    Public Function Fecha_DocEmbarque_Original(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow
        Dim sbcad As New StringBuilder
        Dim listVisit As New List(Of String)

        oDr = poDt.Select("NDOCIN IN (4,5,15) AND NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            'strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FCDCOR"))
            For index As Integer = 0 To oDr.Length - 1
                strCadena = HelpClass.FechaNum_a_Fecha(oDr(index)("FCDCOR"))
                If strCadena.Length > 0 AndAlso (Not listVisit.Contains(strCadena)) Then
                    sbcad.Append(strCadena)
                    listVisit.Add(strCadena)
                    If index < oDr.Length - 1 Then
                        sbcad.Append(Chr(10))
                    End If
                End If
            Next
        End If
        Return sbcad.ToString.Trim
    End Function




    Public Function Fecha_Traduccion_Copia(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim strCadena As String = ""
        Dim sbcad As New StringBuilder
        Dim listVisit As New List(Of String)

        Dim oDr() As DataRow

        oDr = poDt.Select("NDOCIN = 13 AND NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            'strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FCDCCP"))
            For index As Integer = 0 To oDr.Length - 1
                strCadena = HelpClass.FechaNum_a_Fecha(oDr(index)("FCDCCP"))
                If strCadena.Length > 0 AndAlso (Not listVisit.Contains(strCadena)) Then
                    sbcad.Append(strCadena)
                    listVisit.Add(strCadena)
                    If index < oDr.Length - 1 Then
                        sbcad.Append(Chr(10))
                    End If
                End If
            Next
        End If
        Return sbcad.ToString.Trim
    End Function



    Public Function Fecha_Traduccion_Original(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow
        Dim sbcad As New StringBuilder
        Dim listVisit As New List(Of String)

        oDr = poDt.Select("NDOCIN = 13 AND NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            'strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FCDCOR"))
            For index As Integer = 0 To oDr.Length - 1
                strCadena = HelpClass.FechaNum_a_Fecha(oDr(index)("FCDCOR"))
                If strCadena.Length > 0 AndAlso (Not listVisit.Contains(strCadena)) Then
                    sbcad.Append(strCadena)
                    listVisit.Add(strCadena)
                    If index < oDr.Length - 1 Then
                        sbcad.Append(Chr(10))
                    End If
                End If
            Next
        End If
        Return sbcad.ToString.Trim
    End Function


    Public Function Fecha_Volante_Copia(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow
        Dim sbcad As New StringBuilder
        Dim listVisit As New List(Of String)

        oDr = poDt.Select("NDOCIN = 6 AND NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            'strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FCDCCP"))
            For index As Integer = 0 To oDr.Length - 1
                strCadena = HelpClass.FechaNum_a_Fecha(oDr(index)("FCDCCP"))
                If strCadena.Length > 0 AndAlso (Not listVisit.Contains(strCadena)) Then
                    sbcad.Append(strCadena)
                    listVisit.Add(strCadena)
                    If index < oDr.Length - 1 Then
                        sbcad.Append(Chr(10))
                    End If
                End If
            Next
        End If
        Return sbcad.ToString.Trim
    End Function

    Public Function Fecha_Volante_Original(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow
        Dim sbcad As New StringBuilder
        Dim listVisit As New List(Of String)

        oDr = poDt.Select("NDOCIN = 6 AND NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            'strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FCDCOR"))
            For index As Integer = 0 To oDr.Length - 1
                strCadena = HelpClass.FechaNum_a_Fecha(oDr(index)("FCDCOR"))
                If strCadena.Length > 0 AndAlso (Not listVisit.Contains(strCadena)) Then
                    sbcad.Append(strCadena)
                    listVisit.Add(strCadena)
                    If index < oDr.Length - 1 Then
                        sbcad.Append(Chr(10))
                    End If
                End If
            Next
        End If
        Return sbcad.ToString.Trim
    End Function


    Public Function Fecha_Doc_Completos(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow

        oDr = poDt.Select("NESTDO = 120 AND NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FRETES"))
        End If
        Return strCadena
    End Function


    Public Function Fecha_Numeracion(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow

        oDr = poDt.Select("NESTDO = 121 AND NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FRETES"))
        End If
        Return strCadena
    End Function


    Public Function Fecha_Pago_Derechos(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow

        oDr = poDt.Select("NESTDO = 122 AND NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FRETES"))
        End If
        Return strCadena
    End Function


    Public Function Fecha_Levante(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow

        oDr = poDt.Select("NESTDO = 123 AND NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FRETES"))
        End If
        Return strCadena
    End Function


    Public Function Fecha_Entrega_Factura(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow

        oDr = poDt.Select("NESTDO = 149 AND NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FRETES"))
        End If
        Return strCadena
    End Function



    Public Function Fecha_Entrega_Alm_Cliente(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow

        oDr = poDt.Select("NESTDO = 124 AND NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FRETES"))
        End If
        Return strCadena
    End Function

    Public Function Fecha_Previo(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow

        oDr = poDt.Select("NESTDO = 117 AND NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FRETES"))
        End If
        Return strCadena
    End Function

    Public Function Fecha_AforoFisico(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow

        oDr = poDt.Select("NESTDO = 150 AND NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FRETES"))
        End If
        Return strCadena
    End Function

    Public Function Fecha_RetiroCarga(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow

        oDr = poDt.Select("NESTDO = 151 AND NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FRETES"))
        End If
        Return strCadena
    End Function

    Public Function Fecha_Inspeccion(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow

        oDr = poDt.Select("NESTDO = 155 AND NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FRETES"))
        End If
        Return strCadena
    End Function


    Public Function Calcula_Total_Derechos(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As Double
        Dim oDr() As DataRow
        Dim ldblMonto As Double = 0
        oDr = poDt.Select("NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            ldblMonto = Double.Parse(oDr(0)("ITTADV").ToString.Trim)
            ldblMonto = ldblMonto + Double.Parse(oDr(0)("ITTIGV").ToString.Trim)
            ldblMonto = ldblMonto + Double.Parse(oDr(0)("ITTIPM").ToString.Trim)
            ldblMonto = ldblMonto + Double.Parse(oDr(0)("ITTOGS").ToString.Trim)
        End If
        Return ldblMonto
    End Function


    Public Function Fecha_Seguro_Copia(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow
        Dim sbcad As New StringBuilder
        Dim listVisit As New List(Of String)

        oDr = poDt.Select("NDOCIN = 10 AND NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            'strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FCDCCP"))
            For index As Integer = 0 To oDr.Length - 1
                strCadena = HelpClass.FechaNum_a_Fecha(oDr(index)("FCDCCP"))
                If strCadena.Length > 0 AndAlso (Not listVisit.Contains(strCadena)) Then
                    sbcad.Append(strCadena)
                    listVisit.Add(strCadena)
                    If index < oDr.Length - 1 Then
                        sbcad.Append(Chr(10))
                    End If
                End If
            Next

        End If
        Return sbcad.ToString.Trim
    End Function


    Public Function Fecha_Seguro_Original(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow
        Dim sbcad As New StringBuilder
        Dim listVisit As New List(Of String)

        oDr = poDt.Select("NDOCIN = 10 AND NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            'strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FCDCOR"))
            For index As Integer = 0 To oDr.Length - 1
                strCadena = HelpClass.FechaNum_a_Fecha(oDr(index)("FCDCOR"))
                If strCadena.Length > 0 AndAlso (Not listVisit.Contains(strCadena)) Then
                    sbcad.Append(strCadena)
                    listVisit.Add(strCadena)
                    If index < oDr.Length - 1 Then
                        sbcad.Append(Chr(10))
                    End If
                End If
            Next
        End If
        Return sbcad.ToString.Trim
    End Function


    Public Function Buscar_Seguro(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow
        Dim sbcad As New StringBuilder
        Dim listVisit As New List(Of String)

        oDr = poDt.Select("NDOCIN = 10  AND NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            'strCadena = HelpClass.ToStringCvr(oDr(0)("NDOCLI"))
            For index As Integer = 0 To oDr.Length - 1
                strCadena = HelpClass.ToStringCvr(oDr(index)("NDOCLI"))
                If strCadena.Length > 0 AndAlso (Not listVisit.Contains(strCadena)) Then
                    sbcad.Append(strCadena)
                    listVisit.Add(strCadena)
                    If index < oDr.Length - 1 Then
                        sbcad.Append(Chr(10))
                    End If
                End If
            Next
        End If
        Return sbcad.ToString.Trim
    End Function


    Public Function Fecha_Proforma(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow

        oDr = poDt.Select("NESTDO = 137 AND NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FRETES"))
        End If
        Return strCadena
    End Function


    Public Function Fecha_Pago_Proforma(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow

        oDr = poDt.Select("NESTDO = 138 AND NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FRETES"))
        End If
        Return strCadena
    End Function


    Public Function Fecha_Certificado_Origen_Copia(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow
        Dim sbcad As New StringBuilder
        Dim listVisit As New List(Of String)

        oDr = poDt.Select("NDOCIN = 14 AND NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            'strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FCDCCP"))

            For index As Integer = 0 To oDr.Length - 1
                strCadena = HelpClass.FechaNum_a_Fecha(oDr(index)("FCDCCP"))
                If strCadena.Length > 0 AndAlso (Not listVisit.Contains(strCadena)) Then
                    sbcad.Append(strCadena)
                    listVisit.Add(strCadena)
                    If index < oDr.Length - 1 Then
                        sbcad.Append(Chr(10))
                    End If
                End If
            Next


        End If
        Return sbcad.ToString.Trim
    End Function

    Public Function Fecha_Otro_Documento_Original(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow
        Dim sbcad As New StringBuilder
        Dim listVisit As New List(Of String)

        oDr = poDt.Select("NDOCIN = 0 AND NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            'strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FCDCOR"))
            For index As Integer = 0 To oDr.Length - 1
                strCadena = HelpClass.FechaNum_a_Fecha(oDr(index)("FCDCOR"))
                If strCadena.Length > 0 AndAlso (Not listVisit.Contains(strCadena)) Then
                    sbcad.Append(strCadena)
                    listVisit.Add(strCadena)
                    If index < oDr.Length - 1 Then
                        sbcad.Append(Chr(10))
                    End If
                End If
            Next

        End If
        Return sbcad.ToString.Trim
    End Function


    Public Function Fecha_Certificado_Origen_Original(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow
        Dim sbcad As New StringBuilder
        Dim listVisit As New List(Of String)

        oDr = poDt.Select("NDOCIN = 14 AND NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            'strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FCDCOR"))
            For index As Integer = 0 To oDr.Length - 1
                strCadena = HelpClass.FechaNum_a_Fecha(oDr(index)("FCDCOR"))
                If strCadena.Length > 0 AndAlso (Not listVisit.Contains(strCadena)) Then
                    sbcad.Append(strCadena)
                    listVisit.Add(strCadena)
                    If index < oDr.Length - 1 Then
                        sbcad.Append(Chr(10))
                    End If
                End If
            Next
        End If
        Return sbcad.ToString.Trim
    End Function

    Public Function AlmacenDestinoLocalDesc_X_Codigo(ByVal oListAlmacenDestinoLocal As List(Of beTipoDato), ByVal COD_ALMACEN_DESTINO As Decimal, ByVal CCLNT As Decimal) As String
        Dim oFindRegimen As New beTipoDato
        Dim PSTDSCRG_REGIMEN As String = ""
        For Each Item As beTipoDato In oListAlmacenDestinoLocal
            If Item.PNNTPODT = 28 AndAlso Item.PNNCODRG = COD_ALMACEN_DESTINO AndAlso Item.PNCCLNT = CCLNT Then
                PSTDSCRG_REGIMEN = Item.PSTDSCRG
                Exit For
            End If
        Next
        Return PSTDSCRG_REGIMEN
    End Function

    Public Function AlmacenDestinoLocalCodigo_X_Descripcion(ByVal oListAlmacenDestinoLocal As List(Of beTipoDato), ByVal DESC_ALMACEN_DESTINO As String, ByVal CCLNT As Decimal) As Decimal
        Dim oFindRegimen As New beTipoDato
        Dim PNNCODRG As Decimal = 0
        For Each Item As beTipoDato In oListAlmacenDestinoLocal
            If Item.PNNTPODT = 28 AndAlso Item.PSTDSCRG = DESC_ALMACEN_DESTINO AndAlso Item.PNCCLNT = CCLNT Then
                PNNCODRG = Item.PNNCODRG
                Exit For
            End If
        Next
        Return PNNCODRG
    End Function

    Public Function AlmacenDestinoLocalDesc_X_Embarque(ByVal oListAlmacenDestinoLocal As List(Of beTipoDato), ByVal poDt As DataTable, ByVal NORSCI As Decimal, ByVal CCLNT As Decimal) As String
        Dim strCadena As String = ""
        Dim NCODRG As Decimal = 0
        Dim oDr() As DataRow
        oDr = poDt.Select("NTPODT = 28 AND NORSCI = " & NORSCI)
        If oDr.Length > 0 Then
            NCODRG = oDr(0)("NCODRG")
            strCadena = AlmacenDestinoLocalDesc_X_Codigo(oListAlmacenDestinoLocal, NCODRG, CCLNT)
        End If
        Return strCadena
    End Function


    Private PNCPAIS As Decimal = 0
    Private Function Puerto_x_CPAIS(ByVal obePuerto As bePuerto) As Boolean
        Return obePuerto.PNCPAIS1 = PNCPAIS
    End Function

    Public Function Puerto_x_Pais(ByVal oListPuerto As List(Of bePuerto), ByVal CPAIS As Decimal) As List(Of bePuerto)
        Dim oLisPuertoFind As New List(Of bePuerto)
        PNCPAIS = CPAIS
        oLisPuertoFind = oListPuerto.FindAll(AddressOf Puerto_x_CPAIS)
        Return oLisPuertoFind
    End Function


    Public Function MedioTransporteDesc_X_Codigo(ByVal oListMedioTransporte As List(Of beMedioTransporte), ByVal CMEDTR As Decimal) As String
        Dim DESC_BUSQUEDA As String = ""
        For Each Item As beMedioTransporte In oListMedioTransporte
            If Item.PNCMEDTR = CMEDTR Then
                DESC_BUSQUEDA = Item.PSTNMMDT
                Exit For
            End If
        Next
        Return DESC_BUSQUEDA
    End Function

    Public Function MedioTransporteCodigo_X_Descripcion(ByVal oListMedioTransporte As List(Of beMedioTransporte), ByVal DESC_TNMMDT As String) As Decimal
        Dim COD_BUSQUEDA As Decimal = 0
        For Each Item As beMedioTransporte In oListMedioTransporte
            If Item.PSTNMMDT = DESC_TNMMDT Then
                COD_BUSQUEDA = Item.PNCMEDTR
                Exit For
            End If
        Next
        Return COD_BUSQUEDA
    End Function


    Public Function BuscarMedioTransporteAgencia(ByVal oDtTransporteAgencia As DataTable, ByVal COD As Decimal) As String
        Dim medio_transporte As String = ""
        Dim dr() As DataRow
        dr = oDtTransporteAgencia.Select("COD=" & COD)
        If (dr.Length > 0) Then
            medio_transporte = HelpClass.ToStringCvr(dr(0)("TEX"))
        End If
        Return medio_transporte
    End Function


    Public Function Fecha_EntregaOrigen(ByVal poDtCI As DataTable, ByVal NORSCI As Decimal) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow
        oDr = poDtCI.Select("NESTDO = 84 AND NORSCI=" & NORSCI)
        If oDr.Length > 0 Then
            strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("DFECREA"))
        End If
        Return strCadena
    End Function


    Public Function Buscar_Partidas_Arancelarias(ByVal dtItemOC As DataTable, ByVal NORSCI As Double) As String
        Dim CPTDAR As String = ""
        Dim sbCPTDAR As New StringBuilder
        Dim intCont As Integer
        Dim dr() As DataRow
        dr = dtItemOC.Select("NORSCI=" & NORSCI)
        For intCont = 0 To dr.Length - 1
            CPTDAR = HelpClass.ToStringCvr(dr(intCont)("CPTDAR"))
            If CPTDAR.Length > 0 Then
                sbCPTDAR.Append(CPTDAR)
                If intCont < dr.Length - 1 Then
                    sbCPTDAR.Append(Chr(10))
                End If
            End If
        Next intCont
        Return sbCPTDAR.ToString.Trim
    End Function

    Public Function Buscar_Forma_Pago(ByVal dtItemOC As DataTable, ByVal NORSCI As Double) As String
        Dim oListTPAGME As New List(Of String)
        Dim sbTPAGME As New StringBuilder
        Dim TPAGME As String = ""
        Dim intCont As Integer
        Dim dr() As DataRow
        dr = dtItemOC.Select("NORSCI=" & NORSCI)
        For intCont = 0 To dr.Length - 1
            TPAGME = HelpClass.ToStringCvr(dr(intCont)("TPAGME"))
            If TPAGME.Length > 0 Then
                If Not oListTPAGME.Contains(TPAGME) Then
                    sbTPAGME.Append(TPAGME)
                    oListTPAGME.Add(TPAGME)
                    If intCont < dr.Length - 1 Then
                        sbTPAGME.Append(Chr(10))
                    End If
                End If
            End If
        Next intCont
        Return sbTPAGME.ToString.Trim
    End Function

    Public Function Buscar_Moneda_OC(ByVal dtItemOC As DataTable, ByVal NORSCI As Double) As String
        Dim oListmoneda As New List(Of String)
        Dim sbmoneda As New StringBuilder
        Dim moneda As String = ""
        Dim intCont As Integer
        Dim dr() As DataRow
        dr = dtItemOC.Select("NORSCI=" & NORSCI)
        For intCont = 0 To dr.Length - 1
            moneda = HelpClass.ToStringCvr(dr(intCont)("NMONOC"))
            If moneda.Length > 0 Then
                If Not oListmoneda.Contains(moneda) Then
                    sbmoneda.Append(moneda)
                    oListmoneda.Add(moneda)
                    If intCont < dr.Length - 1 Then
                        sbmoneda.Append(Chr(10))
                    End If
                End If
            End If
        Next intCont
        Return sbmoneda.ToString.Trim
    End Function


    Public Function Buscar_Referencia_Cliente_SegunOC(ByVal dtItemOC As DataTable, ByVal NORSCI As Double) As String
        Dim oListNREFCL As New List(Of String)
        Dim sbNREFCL As New StringBuilder
        Dim NREFCL As String = ""
        Dim intCont As Integer
        Dim dr() As DataRow
        dr = dtItemOC.Select("NORSCI=" & NORSCI)
        For intCont = 0 To dr.Length - 1
            NREFCL = HelpClass.ToStringCvr(dr(intCont)("NREFCL"))
            If NREFCL.Length > 0 Then
                If Not oListNREFCL.Contains(NREFCL) Then
                    sbNREFCL.Append(NREFCL)
                    oListNREFCL.Add(NREFCL)
                    If intCont < dr.Length - 1 Then
                        sbNREFCL.Append(Chr(10))
                    End If
                End If
            End If
        Next intCont
        Return sbNREFCL.ToString.Trim
    End Function



    Public Function Buscar_ICOTERM(ByVal dtItemOC As DataTable, ByVal NORSCI As Double) As String
        Dim oListTTINTC As New List(Of String)
        Dim sbTTINTC As New StringBuilder
        Dim TTINTC As String = ""
        Dim intCont As Integer
        Dim dr() As DataRow
        dr = dtItemOC.Select("NORSCI=" & NORSCI)
        For intCont = 0 To dr.Length - 1
            TTINTC = HelpClass.ToStringCvr(dr(intCont)("TTINTC"))
            If TTINTC.Length > 0 Then
                If Not oListTTINTC.Contains(TTINTC) Then
                    sbTTINTC.Append(TTINTC)
                    sbTTINTC.Append("-" & ("" & dr(intCont)("ICOTERM_DES")).ToString.Trim)
                    oListTTINTC.Add(TTINTC)
                    If intCont < dr.Length - 1 Then
                        sbTTINTC.Append(Chr(10))
                    End If
                End If
            End If
        Next intCont
        Return sbTTINTC.ToString.Trim
    End Function

    Public Function Buscar_FECHA_OC(ByVal dtItemOC As DataTable, ByVal NORSCI As Double) As String
        Dim oListFORCML As New List(Of String)
        Dim sbFORCML As New StringBuilder
        Dim FORCML As String = ""
        Dim intCont As Integer
        Dim dr() As DataRow
        dr = dtItemOC.Select("NORSCI=" & NORSCI)
        For intCont = 0 To dr.Length - 1
            FORCML = HelpClass.ToStringCvr(dr(intCont)("FORCML"))
            If FORCML.Length > 0 Then
                If Not oListFORCML.Contains(FORCML) Then
                    sbFORCML.Append(FORCML)
                    oListFORCML.Add(FORCML)
                    If intCont < dr.Length - 1 Then
                        sbFORCML.Append(Chr(10))
                    End If
                End If
            End If
        Next intCont
        Return sbFORCML.ToString.Trim
    End Function



    Public Function Buscar_Porcentajes_Arancel_X_Embarque(ByVal odtMaestroPartidasArancel As DataTable, ByVal dtItemOC As DataTable, ByVal PNNORSCI As Decimal)
        Dim sbListaAranceles As New StringBuilder
        Dim Valor_Arancel As String = ""
        Dim oListaPorCientoArancel As New List(Of String)
        Dim oEmbarque As New clsEmbarque
        Dim PSCPTDAR As String = ""
        Dim drItem() As DataRow
        drItem = dtItemOC.Select("NORSCI=" & PNNORSCI)
        Dim dr() As DataRow
        Dim i As Int32 = 0
        If (drItem.Length > 0 AndAlso odtMaestroPartidasArancel.Rows.Count > 0) Then
            For Each Item As DataRow In drItem
                PSCPTDAR = HelpClass.ToStringCvr(Item("CPTDAR"))
                dr = odtMaestroPartidasArancel.Select("CPTDAR='" & PSCPTDAR & "'")
                If (dr.Length > 0) Then
                    Valor_Arancel = dr(0)("PRARAN").ToString
                    If (Not oListaPorCientoArancel.Contains(Valor_Arancel)) Then
                        sbListaAranceles.Append(Valor_Arancel)
                        If (i < drItem.Length - 1) Then
                            sbListaAranceles.Append(Chr(10))
                        End If
                    End If
                End If
                i += 1
            Next
        End If
        Return sbListaAranceles.ToString
    End Function




    Public Function Buscar_TPN(ByVal dtItemOC As DataTable, ByVal NORSCI As Double) As String
        Dim CODTPN As String = ""
        Dim sbCODTPN As New StringBuilder
        Dim intCont As Integer
        Dim dr() As DataRow
        dr = dtItemOC.Select("NORSCI=" & NORSCI)
        For intCont = 0 To dr.Length - 1
            CODTPN = HelpClass.ToStringCvr(dr(intCont)("CODTPN"))
            If CODTPN.Length > 0 Then
                sbCODTPN.Append(CODTPN)
                If intCont < dr.Length - 1 Then
                    sbCODTPN.Append(Chr(10))
                End If
            End If
        Next
        Return sbCODTPN.ToString.Trim
    End Function



    Public Function Buscar_Observaciones_NoDiferenciado(ByVal poDtCI As DataTable, ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim sbObservacion As New StringBuilder
        Dim intCont As Integer
        Dim oDr() As DataRow
        Dim oDrCI() As DataRow
        Dim TOBS As String = ""
        Dim FECOBS As String = ""
        oDrCI = poDtCI.Select("NORSCI=" & pdblEmbarque)
        If oDrCI.Length > 0 Then
            For intCont = 0 To oDrCI.Length - 1
                TOBS = HelpClass.ToStringCvr(oDrCI(intCont)("TOBS"))
                FECOBS = HelpClass.FechaNum_a_Fecha(oDrCI(intCont)("FECOBS"))
                If TOBS.Length > 0 Then
                    sbObservacion.Append(FECOBS & "  " & TOBS)
                    sbObservacion.Append(Chr(10))
                End If
            Next intCont
        End If

        oDr = poDt.Select("NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            For intCont = 0 To oDr.Length - 1
                TOBS = HelpClass.ToStringCvr(oDr(intCont)("TOBS"))
                FECOBS = HelpClass.FechaNum_a_Fecha(oDr(intCont)("FECOBS"))
                If TOBS.Length > 0 Then
                    sbObservacion.Append(FECOBS & "  " & TOBS)
                    If intCont < oDr.Length - 1 Then
                        sbObservacion.Append(Chr(10))
                    End If
                End If
            Next intCont
        End If
        Return sbObservacion.ToString.Trim
    End Function


    'Observaciones All:muestra observaciones Carga Internaciona y Aduanas diferenciados
    Public Function Buscar_Observaciones_Diferenciado(ByVal poDtCI As DataTable, ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim sbObservacion As New StringBuilder
        Dim intCont As Integer
        Dim oDr() As DataRow
        Dim oDrCI() As DataRow
        Dim TOBS As String = ""
        Dim FECOBS As String = ""
        sbObservacion.Append("---Carga Internacional---")
        sbObservacion.Append(Chr(10))
        oDrCI = poDtCI.Select("NORSCI=" & pdblEmbarque)
        If oDrCI.Length > 0 Then
            For intCont = 0 To oDrCI.Length - 1
                TOBS = HelpClass.ToStringCvr(oDrCI(intCont).Item("TOBS"))
                FECOBS = HelpClass.FechaNum_a_Fecha(oDrCI(intCont)("FECOBS"))
                If TOBS.Length > 0 Then
                    sbObservacion.Append(FECOBS & "  " & TOBS)
                    If intCont < oDrCI.Length - 1 Then
                        sbObservacion.Append(Chr(10))
                    End If

                End If
            Next intCont
        End If

        sbObservacion.Append("---Embarque Aduanas---")
        sbObservacion.Append(Chr(10))
        oDr = poDt.Select("NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            For intCont = 0 To oDr.Length - 1
                TOBS = HelpClass.ToStringCvr(oDr(intCont)("TOBS"))
                FECOBS = HelpClass.FechaNum_a_Fecha(oDr(intCont)("FECOBS"))
                If TOBS.Length > 0 Then
                    sbObservacion.Append(FECOBS & "  " & TOBS)
                    If intCont < oDr.Length - 1 Then
                        sbObservacion.Append(Chr(10))
                    End If
                End If
            Next intCont
        End If
        Return sbObservacion.ToString.Trim
    End Function

    'Observaciones All:muestra observaciones solo Aduanas 
    Public Function Buscar_Observaciones_Embarque(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim sbObservacion As New StringBuilder
        Dim intCont As Integer
        Dim oDr() As DataRow
        oDr = poDt.Select("NORSCI=" & pdblEmbarque)
        Dim TOBS As String = ""
        Dim FECOBS As String = ""
        If oDr.Length > 0 Then
            For intCont = 0 To oDr.Length - 1
                TOBS = HelpClass.ToStringCvr(oDr(intCont)("TOBS"))
                FECOBS = HelpClass.FechaNum_a_Fecha(oDr(intCont)("FECOBS"))
                If TOBS.Length > 0 Then
                    sbObservacion.Append(FECOBS & "  " & TOBS)
                    If intCont < oDr.Length - 1 Then
                        sbObservacion.Append(Chr(10))
                    End If
                End If
            Next intCont
        End If
        Return sbObservacion.ToString.Trim
    End Function




    Public Function TipoCargaDesc_X_Codigo(ByVal oListTipoCarga As List(Of beTipoDato), ByVal COD_TIPO_CARGA As Decimal) As String
        Dim PSTDSCRG As String = ""
        For Each Item As beTipoDato In oListTipoCarga
            If Item.PNNTPODT = 9 AndAlso Item.PNNCODRG = COD_TIPO_CARGA Then
                PSTDSCRG = Item.PSTDSCRG
                Exit For
            End If
        Next
        Return PSTDSCRG
    End Function


    Public Function TipoCargaCodigo_X_Descripcion(ByVal oListTipoCarga As List(Of beTipoDato), ByVal DESC_TIPO_CARGA As String) As Decimal
        Dim PNNCODRG As Decimal = 0
        For Each Item As beTipoDato In oListTipoCarga
            If Item.PNNTPODT = 9 AndAlso Item.PSTDSCRG = DESC_TIPO_CARGA Then
                PNNCODRG = Item.PNNCODRG
                Exit For
            End If
        Next
        Return PNNCODRG
    End Function

   

    Public Function TipoCargaDesc_X_Embarque(ByVal oListTipoCarga As List(Of beTipoDato), ByVal poDt As DataTable, ByVal NORSCI As Decimal) As String
        Dim NCODRG As Decimal = 0
        Dim strCadena As String = ""
        Dim intCont As Integer
        Dim oDr() As DataRow
        oDr = poDt.Select("NTPODT=9 AND NORSCI=" & NORSCI)
        If oDr.Length > 0 Then
            For intCont = 0 To oDr.Length - 1
                NCODRG = oDr(intCont)("NCODRG").ToString.Trim
                If intCont > 0 Then
                    strCadena = strCadena & vbCrLf
                End If
                strCadena = strCadena & TipoCargaDesc_X_Codigo(oListTipoCarga, NCODRG)
            Next intCont
        End If
        Return strCadena
    End Function

    Public Function TipoCargaCantidad_X_Embarque(ByVal poDt As DataTable, ByVal NORSCI As Decimal) As String
        Dim NCODRG As Decimal = 0
        Dim strCant As String = ""
        Dim intCont As Integer
        Dim oDr() As DataRow
        oDr = poDt.Select("NTPODT=9 AND NORSCI=" & NORSCI)
        If oDr.Length > 0 Then
            For intCont = 0 To oDr.Length - 1
                NCODRG = oDr(intCont)("NCODRG").ToString.Trim
                If intCont > 0 Then
                    strCant = strCant & vbCrLf
                End If
                strCant = strCant & Double.Parse(oDr(intCont)("QCANTI")).ToString.Trim
            Next intCont
        End If
        Return strCant
    End Function





    Public Enum TipoCodItemOC
        LIST_OC_CODITEM
        LIST_OC_NUMITEM
        LIST_QITEM_SEGUNOC
        LIST_QITEM_EMBARCADO
    End Enum

    Public Function Buscar_VariosCodigos_ItemOC(ByVal dtItemOC As DataTable, ByVal NORSCI As Double, ByVal oTipoCodItemOC As TipoCodItemOC) As String
        Dim strListaDevolver As String = ""
        Dim sbJoinAll As New StringBuilder
        Dim sbTCITCL As New StringBuilder
        Dim sbQCNTITOC As New StringBuilder
        Dim sbQRLCSC As New StringBuilder
        Dim sbNumeroItem As New StringBuilder
        Dim NORCML As String = ""
        Dim TCITCL As String = ""
        Dim NRITOC As String = ""
        Dim SBITOC As String = ""
        Dim QRLCSC As String = ""
        Dim QCNTITOC As String = ""
        Dim intCont As Integer
        Dim oDr() As DataRow
        oDr = dtItemOC.Select("NORSCI=" & NORSCI)
        For intCont = 0 To oDr.Length - 1
            NORCML = HelpClass.ToStringCvr(oDr(intCont)("NORCML"))
            TCITCL = HelpClass.ToStringCvr(oDr(intCont)("TCITCL"))
            QCNTITOC = ("" & oDr(intCont)("QCNTIT")).ToString.Trim
            QRLCSC = ("" & oDr(intCont)("QRLCSC")).ToString.Trim
            NRITOC = ("" & oDr(intCont)("NRITEM")).ToString.Trim
            SBITOC = HelpClass.ToStringCvr(oDr(intCont)("SBITOC"))
            sbTCITCL.Append(NORCML & " - " & TCITCL)

            sbNumeroItem.Append(NORCML & " - " & NRITOC)
            If SBITOC.Length > 0 Then
                sbNumeroItem.Append(" - " & SBITOC)
            End If

            sbQCNTITOC.Append(QCNTITOC)
            sbQRLCSC.Append(QRLCSC)
            sbJoinAll.Append(NORCML & " - " & TCITCL & " - " & QCNTITOC & " - " & QRLCSC)
            If intCont < oDr.Length - 1 Then
                sbJoinAll.Append(Chr(10))
                sbTCITCL.Append(Chr(10))
                sbQCNTITOC.Append(Chr(10))
                sbQRLCSC.Append(Chr(10))
                sbNumeroItem.Append(Chr(10))
            End If
        Next
        Select Case oTipoCodItemOC
            Case TipoCodItemOC.LIST_OC_CODITEM 'Lista de Codigo de Items
                strListaDevolver = sbTCITCL.ToString.Trim
            Case TipoCodItemOC.LIST_OC_NUMITEM ' Lista del numero de Items
                strListaDevolver = sbNumeroItem.ToString.Trim
            Case TipoCodItemOC.LIST_QITEM_SEGUNOC 'Lista de cantidades segun OC
                strListaDevolver = sbQCNTITOC.ToString.Trim
            Case TipoCodItemOC.LIST_QITEM_EMBARCADO 'Lista de cantidades embarcadas
                strListaDevolver = sbQRLCSC.ToString.Trim
        End Select
        Return strListaDevolver
    End Function


    Public Function BuscarFechaEntregaOC(ByVal poDtCHKCargaInt As DataTable, ByVal NORSCI As Decimal) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow
        oDr = poDtCHKCargaInt.Select("NESTDO = 100 AND NORSCI=" & NORSCI)
        If oDr.Length > 0 Then
            strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("DFECREA"))
        End If
        Return strCadena
    End Function



    Public Function BuscarFechaEmbarque(ByVal poDtCHKCargaInt As DataTable, ByVal NORSCI As Decimal) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow
        oDr = poDtCHKCargaInt.Select("NESTDO = 107 AND NORSCI=" & NORSCI)
        If oDr.Length > 0 Then
            strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("DFECREA"))
        End If
        Return strCadena
    End Function



    Public Function BuscarFechaLlegada(ByVal poDtCHKCargaInt As DataTable, ByVal NORSCI As Decimal) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow
        oDr = poDtCHKCargaInt.Select("NESTDO = 108 AND NORSCI=" & NORSCI)
        If oDr.Length > 0 Then
            strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("DFECREA"))
        End If
        Return strCadena
    End Function

  
    Public Function Buscar_Costo_Total_X_Embarque(ByVal PNNORSCI As Decimal, ByVal strgCodVariable As String, ByVal oDt As DataTable) As String
        Dim intRow As Integer
        Dim strResultado As String = ""
        Dim CODVAR As String = ""
        Dim NORSCI As Decimal = 0
        For intRow = 0 To oDt.Rows.Count - 1
            CODVAR = oDt.Rows(intRow)("CODVAR").ToString.Trim
            NORSCI = oDt.Rows(intRow)("NORSCI")
            If NORSCI = PNNORSCI AndAlso CODVAR = strgCodVariable Then
                strResultado = Val("" & oDt.Rows(intRow)("IVLDOL"))
            End If
        Next
        Return strResultado
    End Function

    Public Function Buscar_Total_Orden_Embarcada_X_Embarque_Origen(ByVal oDtOrdenEmbarcada As DataTable, ByVal NORSCI As Decimal) As Decimal
        Dim Total_Moneda_Origen As Decimal = 0.0
        Dim drOC() As DataRow
        drOC = oDtOrdenEmbarcada.Select("NORSCI=" & NORSCI)
        For Each Item As DataRow In drOC
            Total_Moneda_Origen = Total_Moneda_Origen + Item("COSTO_ORIGEN")
        Next
        Total_Moneda_Origen = Math.Round(Total_Moneda_Origen, 2)
        Return Total_Moneda_Origen
    End Function

    Public Function Buscar_Total_Orden_Embarcada_X_Embarque_Equiv_Dolares(ByVal oDtOrdenEmbarcada As DataTable, ByVal NORSCI As Decimal) As Decimal
        Dim Total_Moneda_Equiv_Dolar As Decimal = 0.0
        Dim drOC() As DataRow
        drOC = oDtOrdenEmbarcada.Select("NORSCI=" & NORSCI)
        For Each Item As DataRow In drOC
            Total_Moneda_Equiv_Dolar = Total_Moneda_Equiv_Dolar + Item("COSTO_EQUIV_DOL")
        Next
        Total_Moneda_Equiv_Dolar = Math.Round(Total_Moneda_Equiv_Dolar, 2)
        Return Total_Moneda_Equiv_Dolar
    End Function


    Public Function ObtenerCalculoImportesBase_Origen(ByVal ImporteOrigenDolar As Decimal, ByVal ImporteOrigenSoles As Decimal, ByVal P100IGV As Decimal, ByVal origenIGV As String) As beCalculoImporte
        Dim obebeCalculo As New beCalculoImporte
        Dim IGV As Decimal = 0
        Dim ImporteBase_Dol As Decimal = 0
        Dim ImporteBase_Sol As Decimal = 0
        Dim FactorIGV As Decimal = 0

        Select Case origenIGV
            Case "COMISION"
                ' CASO DE LA COMISION AGENCIAS ,
                'la comision y su igv viene por separado 
                IGV = P100IGV / 100
                obebeCalculo.PNIMPORTE_IGV_DOL = Math.Round(ImporteOrigenDolar * IGV, 5)
                obebeCalculo.PNIMPORTE_BASE_DOL = ImporteOrigenDolar
                obebeCalculo.PNIMPORTE_TOTAL_DOL = obebeCalculo.PNIMPORTE_BASE_DOL + obebeCalculo.PNIMPORTE_IGV_DOL

                obebeCalculo.PNIMPORTE_IGV_SOL = Math.Round(ImporteOrigenSoles * IGV, 5)
                obebeCalculo.PNIMPORTE_BASE_SOL = ImporteOrigenSoles
                obebeCalculo.PNIMPORTE_TOTAL_SOL = obebeCalculo.PNIMPORTE_BASE_SOL + obebeCalculo.PNIMPORTE_IGV_SOL


            Case Else
                'CASO DE GASTOS ADMINISTRATIVOS (AVISO DE DEBITO)
                'los gastos incluyen su igv(no está separado) 

                IGV = P100IGV / 100
                FactorIGV = 1 + IGV
                ImporteBase_Dol = Math.Round(ImporteOrigenDolar / FactorIGV, 5)
                obebeCalculo.PNIMPORTE_BASE_DOL = ImporteBase_Dol
                obebeCalculo.PNIMPORTE_IGV_DOL = Math.Round(ImporteBase_Dol * IGV, 5)
                obebeCalculo.PNIMPORTE_TOTAL_DOL = obebeCalculo.PNIMPORTE_IGV_DOL + obebeCalculo.PNIMPORTE_BASE_DOL


                ImporteBase_Sol = Math.Round(ImporteOrigenSoles / FactorIGV, 5)
                obebeCalculo.PNIMPORTE_BASE_SOL = ImporteBase_Sol
                obebeCalculo.PNIMPORTE_IGV_SOL = Math.Round(ImporteBase_Sol * IGV, 5)
                obebeCalculo.PNIMPORTE_TOTAL_SOL = obebeCalculo.PNIMPORTE_BASE_SOL + obebeCalculo.PNIMPORTE_IGV_SOL

        End Select

        Return obebeCalculo
    End Function


    Public Function ObtenerCalculoImportesBase_Base(ByVal ImporteBaseDolar As Decimal, ByVal ImporteBaseSoles As Decimal, ByVal P100IGV As Decimal) As beCalculoImporte
        Dim obebeCalculo As New beCalculoImporte
        Dim IGV As Decimal = 0
        Dim ImporteBase_Dol As Decimal = 0
        Dim ImporteBase_Sol As Decimal = 0
        Dim FactorIGV As Decimal = 0

        IGV = P100IGV / 100
        obebeCalculo.PNIMPORTE_IGV_DOL = Math.Round(ImporteBaseDolar * IGV, 5)
        obebeCalculo.PNIMPORTE_BASE_DOL = ImporteBaseDolar
        obebeCalculo.PNIMPORTE_TOTAL_DOL = obebeCalculo.PNIMPORTE_BASE_DOL + obebeCalculo.PNIMPORTE_IGV_DOL

        obebeCalculo.PNIMPORTE_IGV_SOL = Math.Round(ImporteBaseSoles * IGV, 5)
        obebeCalculo.PNIMPORTE_BASE_SOL = ImporteBaseSoles
        obebeCalculo.PNIMPORTE_TOTAL_SOL = obebeCalculo.PNIMPORTE_BASE_SOL + obebeCalculo.PNIMPORTE_IGV_SOL

        Return obebeCalculo
    End Function

   
    Public Function FormarDatosResumenInicialEmbarque(ByVal dtEmbarques As DataTable, ByVal CCLNT As Decimal, ByVal odtDatosTotal As DataTable) As DataTable
        Dim odtResumEmb As New DataTable
        Dim odtEmbarqueTEMP As New DataTable
        Dim dr() As DataRow
        Dim drFilaResum As DataRow
        odtEmbarqueTEMP = odtDatosTotal.Copy
        odtResumEmb.Columns.Add("NORSCI")
        odtResumEmb.Columns.Add("NORCML")
        odtResumEmb.Columns.Add("TNOMCOM")

        ''*****ADICION DE ICOTERM
        ''
        Dim oHasListaEmbarque As New Hashtable
        Dim oListTNOMCOM As New List(Of String)
        Dim oListTTINTC As New List(Of String)
        Dim NORSCI As Decimal = 0
        Dim NRPARC As Decimal = 0
        Dim NORCML As String = ""
        Dim TNOMCOM As String = ""
        Dim TTINTC As String = ""
        Dim sbNORCML As New StringBuilder
        Dim sbTNOMCOM As New StringBuilder
        For Each Item As DataRow In dtEmbarques.Rows
            NORSCI = Item("NORSCI")
            sbNORCML.Length = 0
            sbTNOMCOM.Length = 0
            oListTNOMCOM.Clear()
            If (Not oHasListaEmbarque.Contains(NORSCI)) Then
                oHasListaEmbarque.Add(NORSCI, NORSCI)
                dr = odtEmbarqueTEMP.Select("NORSCI=" & NORSCI)
                drFilaResum = odtResumEmb.NewRow
                drFilaResum("NORSCI") = NORSCI
                For FilaItem As Integer = 0 To dr.Length - 1
                    NRPARC = dr(FilaItem)("NRPARC")
                    NORCML = HelpClass.ToStringCvr(dr(FilaItem)("NORCML"))
                    TNOMCOM = HelpClass.ToStringCvr(dr(FilaItem)("TNOMCOM")).ToUpper
                    If (TNOMCOM.Length <> 0 AndAlso Not oListTNOMCOM.Contains(TNOMCOM)) Then
                        oListTNOMCOM.Add(TNOMCOM)
                        sbTNOMCOM.Append(TNOMCOM)
                        If (FilaItem < dr.Length - 1) Then
                            sbTNOMCOM.Append(Chr(10))
                        End If
                    End If
                    If (NORCML.Length <> 0) Then
                        sbNORCML.Append(FormatearOCParcial(CCLNT, NORCML, NRPARC))
                        If (FilaItem < dr.Length - 1) Then
                            sbNORCML.Append(Chr(10))
                        End If
                    End If
                Next
                drFilaResum("NORCML") = sbNORCML.ToString.Trim
                drFilaResum("TNOMCOM") = sbTNOMCOM.ToString.Trim
                odtResumEmb.Rows.Add(drFilaResum)
            End If
        Next
        Return odtResumEmb
    End Function


    Private Function FormatearOCParcial(ByVal CCLNT As Decimal, ByVal NORCML As String, ByVal NRPARC As Decimal) As String
        Dim OC_Format As String = ""
        Select Case CCLNT
            Case 48622
                If NRPARC > 1 Then
                    OC_Format = NORCML & "(SCN" & NRPARC.ToString.PadLeft(3, "0") & ")"
                Else
                    OC_Format = NORCML & "(SCN001)"
                End If
            Case Else
                If NRPARC > 1 Then
                    OC_Format = NORCML & "(P" & NRPARC.ToString & ")"
                Else
                    OC_Format = NORCML
                End If
        End Select
        Return OC_Format
    End Function



    Public Function Fecha_Volante(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow

        oDr = poDt.Select("NESTDO = 116 AND NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FRETES"))
        End If
        Return strCadena
    End Function


    Public Function Fecha_CargaOK(ByVal poDt As DataTable, ByVal NORSCI As Decimal) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow
        oDr = poDt.Select("NESTDO = 106 AND NORSCI=" & NORSCI)
        If oDr.Length > 0 Then
            strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("DFECREA"))
        End If
        Return strCadena
    End Function


    Public Function Fecha_Carga_Discrepancia(ByVal poDt As DataTable, ByVal NORSCI As Decimal) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow
        oDr = poDt.Select("NESTDO = 105 AND NORSCI=" & NORSCI)
        If oDr.Length > 0 Then
            strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("DFECREA"))
        End If
        Return strCadena
    End Function


    Public Function EsTransporteAgAduana(ByVal COD_TRANS_AG As Decimal) As String
        Dim strCadena As String = ""
        If COD_TRANS_AG = 0 Then
            strCadena = ""
        ElseIf COD_TRANS_AG = 1 Then
            strCadena = "SI"
        Else
            strCadena = "NO"
        End If
        Return strCadena
    End Function

    Public Function Fecha_EntregaFacImportaciones(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow

        oDr = poDt.Select("NESTDO = 153 AND NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FRETES"))
        End If
        Return strCadena
    End Function

    Public Function Fecha_EntregaFacContabilidad(ByVal poDt As DataTable, ByVal pdblEmbarque As Double) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow

        oDr = poDt.Select("NESTDO = 154 AND NORSCI=" & pdblEmbarque)
        If oDr.Length > 0 Then
            strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FRETES"))
        End If
        Return strCadena
    End Function


    Public Function FormatearPuerto(ByVal Pais As String, ByVal Puerto As String) As String
        Dim strOrigen As String = ""
        If Puerto.Trim.Length > 0 Then
            strOrigen = String.Format("{0} - {1}", Pais.Trim, Puerto.Trim)
        Else
            strOrigen = Pais.Trim
        End If
        Return strOrigen
    End Function


    Public Function Buscar_Condicion_Pago(ByVal dtItemOC As DataTable, ByVal NORSCI As Double) As String
        Dim oListTCNDPG As New List(Of String)
        Dim sbTCNDPG As New StringBuilder
        Dim TCNDPG As String = ""
        Dim intCont As Integer
        Dim dr() As DataRow
        dr = dtItemOC.Select("NORSCI=" & NORSCI)
        For intCont = 0 To dr.Length - 1            
            TCNDPG = HelpClass.ToStringCvr(dr(intCont)("TCNDPG"))
            If TCNDPG.Length > 0 Then
                If Not oListTCNDPG.Contains(TCNDPG) Then
                    sbTCNDPG.Append(TCNDPG)
                    oListTCNDPG.Add(TCNDPG)
                    If intCont < dr.Length - 1 Then
                        sbTCNDPG.Append(Chr(10))
                    End If
                End If
            End If
        Next intCont
        Return sbTCNDPG.ToString.Trim
    End Function


    Public Function Buscar_UltimaFechaActualizacion(ByVal FCHCRT_EMB As Decimal, ByVal FULTAC_EMB As Decimal, ByVal dtObsEmb As DataTable, ByVal dtCHKEmb As DataTable, ByVal dtCosto As DataTable, ByVal NORSCI As Double) As String
        If FULTAC_EMB = 0 Then
            FULTAC_EMB = FCHCRT_EMB
        End If
        Dim FechaMax As Decimal = FULTAC_EMB
        Dim ob As Object
        If dtObsEmb.Rows.Count > 0 Then
            ob = dtObsEmb.Compute("MAX(FULTAC)", String.Format("NORSCI='{0}'", NORSCI))
            If ("" & ob).ToString.Trim.Length > 0 AndAlso ob > FechaMax Then
                FechaMax = ob
            End If
        End If
        If dtCHKEmb.Rows.Count > 0 Then
            ob = dtCHKEmb.Compute("MAX(FULTAC)", String.Format("NORSCI='{0}'", NORSCI))
            If ("" & ob).ToString.Trim.Length AndAlso ob > FechaMax Then
                FechaMax = ob
            End If
        End If
        If dtCosto.Rows.Count > 0 Then
            ob = dtCosto.Compute("MAX(FULTAC)", String.Format("NORSCI='{0}'", NORSCI))
            If ("" & ob).ToString.Trim.Length AndAlso ob > FechaMax Then
                FechaMax = ob
            End If
        End If

        Return HelpClass.FechaNum_a_Fecha(FechaMax)
    End Function



    Public Function FormatOrdenServicio(ByVal PNNMOS As Decimal) As String
        Dim strPNNMOS As String = ""
        If PNNMOS = 0 Then
            strPNNMOS = ""
        Else
            strPNNMOS = PNNMOS.ToString.Trim
        End If
        Return strPNNMOS
    End Function

    Public Function isValidFecha(ByVal Fecha As String) As Boolean
        Dim FechaValida As Date
        Dim IsValid As Boolean = False
        Fecha = Fecha.Trim
        If (Date.TryParse(Fecha, FechaValida) = False) Then
            IsValid = False
        Else
            If FechaValida.Year > 1000 Then
                IsValid = True
            Else
                IsValid = False
            End If
        End If
        Return IsValid
    End Function


    Public Function IsRegimenTemporal(ByVal PNREGIMEN As Decimal)
        Dim isTemporal As Boolean = False
        If PNREGIMEN = 2 OrElse PNREGIMEN = 5 OrElse PNREGIMEN = 15 OrElse PNREGIMEN = 18 Then
            isTemporal = True
        Else
            isTemporal = False
        End If
        Return isTemporal
    End Function


    Public Function ObtieneChkCI(ByVal dtChk As DataTable, ByVal NRPEMB As Decimal, ByVal NESTDO As Decimal) As String
        Dim dr() As DataRow
        Dim result As String = ""
        dr = dtChk.Select("NRPEMB='" & NRPEMB & "' AND NESTDO='" & NESTDO & "'")
        If dr.Length > 0 Then
            result = HelpClass.FechaNum_a_Fecha(dr(0)("FRETES"))
        End If
        Return result
    End Function


    Public Function ObtieneChkEmb(ByVal dtChk As DataTable, ByVal NORSCI As Decimal, ByVal NESTDO As Decimal) As String
        Dim dr() As DataRow
        Dim result As String = ""
        dr = dtChk.Select("NORSCI='" & NORSCI & "' AND NESTDO='" & NESTDO & "'")
        If dr.Length > 0 Then
            result = HelpClass.FechaNum_a_Fecha(dr(0)("FRETES"))
        End If
        Return result
    End Function

    

End Class
