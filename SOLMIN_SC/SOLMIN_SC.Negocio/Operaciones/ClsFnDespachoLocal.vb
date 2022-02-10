
Imports System.Text
Imports Ransa.Utilitario
Public Class ClsFnDespachoLocal
    Public Function Buscar_Fecha_Ingreso_Almacen(ByVal dtDatos As DataTable, ByVal NORSCI As Decimal) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow
        Dim sbcad As New StringBuilder
        Dim listVisit As New List(Of String)

        oDr = dtDatos.Select("NORSCI=" & NORSCI)
        If oDr.Length > 0 Then
            For index As Integer = 0 To oDr.Length - 1
                strCadena = HelpClass.FechaNum_a_Fecha(oDr(index)("FINGAL"))
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


    Public Function Buscar_Fecha_Salida_Almacen(ByVal dtDatos As DataTable, ByVal NORSCI As Decimal) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow
        Dim sbcad As New StringBuilder
        Dim listVisit As New List(Of String)

        oDr = dtDatos.Select("NORSCI=" & NORSCI)
        If oDr.Length > 0 Then
            For index As Integer = 0 To oDr.Length - 1
                strCadena = HelpClass.FechaNum_a_Fecha(oDr(index)("FSLDAL"))
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




    Public Function Buscar_Proveedor_Embarque(ByVal dtItem As DataTable, ByVal NORSCI As Decimal) As String
        Dim dr() As DataRow
        dr = dtItem.Select("NORSCI='" & NORSCI & "'")
        Dim cad As String = ""
        Dim Visitado As New Hashtable
        Dim documento As String = ""
        For Each Item As DataRow In dr
            documento = ("" & Item("TPRVCL")).ToString.Trim
            If documento.Length > 0 AndAlso Not Visitado.Contains(documento) Then
                Visitado.Add(documento, documento)
                cad = cad & Chr(10) & documento
            End If
        Next
        cad = cad.Trim
        Return cad
    End Function

    Public Function Total_OC_Item(ByVal dtItem As DataTable, ByVal NORSCI As Decimal) As Decimal
        Dim total As Decimal = 0
        Dim dr() As DataRow
        dr = dtItem.Select("NORSCI='" & NORSCI & "'")
        For Each Item As DataRow In dr
            total = total + Item("QRLCSC") * Item("IVUNIT") * Item("QTPCM2")
        Next
        Return total
    End Function
    Public Function Buscar_Doc_Guia_Embarque(ByVal dtItem As DataTable, ByVal NORSCI As Decimal, ByRef TotalGuiasxEmb As Decimal) As String
        Dim dr() As DataRow
        dr = dtItem.Select("NORSCI='" & NORSCI & "'")
        Dim cad As String = ""
        Dim Visitado As New Hashtable
        Dim documento As String = ""
        Dim Tipo As String = ""
        For Each Item As DataRow In dr
            documento = ("" & Item("NUMDCR")).ToString.Trim
            Tipo = ("" & Item("CTPCRG")).ToString.Trim
            If documento.Length > 0 AndAlso documento <> "0" AndAlso Not Visitado.Contains(documento) Then
                Visitado.Add(documento, documento)
                If Tipo = "GR" Then
                    documento = Format_Documento(documento)
                End If
                cad = cad & Chr(10) & documento
            End If
        Next
        cad = cad.Trim
        cad = cad.Replace(Chr(10), ",")
        TotalGuiasxEmb = Visitado.Count
        Return cad
    End Function
    Public Function Format_Documento(ByVal NumDoc As String) As String
        Dim cadFormat As String = ""
        Dim Serie As String = ""
        Dim RefNum As String = ""
        If NumDoc.Length > 0 Then
            NumDoc = NumDoc.PadLeft(10, "0")
            Serie = NumDoc.Substring(0, 3)
            RefNum = NumDoc.Substring(4, NumDoc.Length - 4)
            cadFormat = Serie & "-" & RefNum
        End If
        Return cadFormat
    End Function

    Public Function Buscar_Doc_GuiaProv_Embarque(ByVal dtItem As DataTable, ByVal NORSCI As Decimal) As String
        Dim dr() As DataRow
        dr = dtItem.Select("NORSCI='" & NORSCI & "'")
        Dim cad As String = ""
        Dim Visitado As New Hashtable
        Dim documento As String = ""
        For Each Item As DataRow In dr
            documento = ("" & Item("NGRPRV")).ToString.Trim
            If documento.Length > 0 AndAlso Not Visitado.Contains(documento) Then
                Visitado.Add(documento, documento)
                cad = cad & Chr(10) & documento
            End If
        Next
        cad = cad.Trim
        cad = cad.Replace(Chr(10), ",")
        Return cad
    End Function

    Public Function Buscar_Doc_OC_Embarque(ByVal dtDetalle As DataTable, ByVal NORSCI As Decimal) As String
        Dim dr() As DataRow
        dr = dtDetalle.Select("NORSCI='" & NORSCI & "'")
        Dim cad As String = ""
        Dim Visitado As New Hashtable
        Dim documento As String = ""
        For Each Item As DataRow In dr
            documento = ("" & Item("NORCML")).ToString.Trim
            If documento.Length > 0 AndAlso Not Visitado.Contains(documento) Then
                Visitado.Add(documento, documento)
                cad = cad & Chr(10) & documento
            End If
        Next
        cad = cad.Trim
        cad = cad.Replace(Chr(10), ",")
        Return cad
    End Function

    Public Function Calcular_Peso_Volumen(ByVal Largo_item_cm As Object, ByVal Ancho_item_cm As Object, ByVal Alto_item_cm As Object, ByVal Cantidad_item As Object) As Decimal
        Dim PesoVolumen As Decimal = 0
        Dim Largo As Decimal = Val("" & Largo_item_cm)
        Dim Ancho As Decimal = Val("" & Ancho_item_cm)
        Dim Alto As Decimal = Val("" & Alto_item_cm)
        Dim Cantidad As Decimal = Val("" & Cantidad_item)
        PesoVolumen = Math.Round(Cantidad * Ancho * Alto * Largo / 6000, 2)
        Return PesoVolumen
    End Function
    Public Function Calcular_Peso_Factor_Servicio(ByVal Peso_item_kg As Object, ByVal PesoVolumen_item As Object) As Decimal
        Dim PesoFactor As Decimal = 0
        Dim Peso_item As Decimal = Val("" & Peso_item_kg)
        Dim Peso_Volumen As Decimal = Val("" & PesoVolumen_item)
        If Peso_item > Peso_Volumen Then
            PesoFactor = Peso_item
        Else
            PesoFactor = Peso_Volumen
        End If
        Return PesoFactor
    End Function

    Public Function Buscar_Lista_Orden_Compra(ByVal dtCarga As DataTable, ByVal pEmbarque As Decimal) As String
        Dim cad As String = ""
        Dim Visitado As New Hashtable
        Dim dr() As DataRow
        dr = dtCarga.Select("NORSCI='" & pEmbarque & "'")
        Dim oc As String = ""
        For Each Item As DataRow In dr
            oc = ("" & Item("NORCML")).ToString.Trim
            If oc.Length > 0 AndAlso Not Visitado.Contains(oc) Then
                Visitado.Add(oc, oc)
                cad = cad & Chr(13) & oc & " , "
            End If
        Next
        cad = cad.Trim
        If cad.Length > 0 Then
            cad = cad.Substring(0, cad.Length - 1)
        End If
        Return cad.Trim
    End Function
    'Public Function Buscar_Lista_Documento(ByVal dtCarga As DataTable, ByVal pEmbarque As Decimal) As String
    '    Dim cad As String = ""
    '    Dim Visitado As New Hashtable
    '    Dim dr() As DataRow
    '    dr = dtCarga.Select("NORSCI='" & pEmbarque & "'")
    '    Dim doc As String = ""
    '    For Each Item As DataRow In dr
    '        doc = ("" & Item("NUMDCR")).ToString.Trim
    '        If doc <> "0" AndAlso doc.Length > 0 AndAlso Not Visitado.Contains(doc) Then
    '            Visitado.Add(doc, doc)
    '            cad = cad & Chr(13) & doc & " , "
    '        End If
    '    Next
    '    cad = cad.Trim
    '    If cad.Length > 0 Then
    '        cad = cad.Substring(0, cad.Length - 1)
    '    End If
    '    Return cad.Trim
    'End Function
    Public Function Buscar_Costo_Embarque(ByVal dtCostos As DataTable, ByVal pEmbarque As Decimal, ByVal CodVarCosto As String) As String
        Dim dr() As DataRow
        Dim costo As String = ""
        dr = dtCostos.Select("NORSCI='" & pEmbarque & "' AND CODVAR='" & CodVarCosto & "'")
        If dr.Length > 0 Then
            costo = dr(0)("IVLDOL")
        End If
        Return costo
    End Function

    Public Function Fecha_Ingreso(ByVal poDt As DataTable, ByVal NORSCI As Decimal) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow
        oDr = poDt.Select("NESTDO = 162 AND NORSCI=" & NORSCI)
        If oDr.Length > 0 Then
            strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FRETES"))
        End If
        Return strCadena
    End Function

    Public Function Fecha_Solicitud(ByVal poDt As DataTable, ByVal NORSCI As Decimal) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow
        oDr = poDt.Select("NESTDO = 156 AND NORSCI=" & NORSCI)
        If oDr.Length > 0 Then
            strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FRETES"))
        End If
        Return strCadena
    End Function


    Public Function Fecha_Requerimiento_Transporte(ByVal poDt As DataTable, ByVal NORSCI As Decimal) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow
        oDr = poDt.Select("NESTDO = 159 AND NORSCI=" & NORSCI)
        If oDr.Length > 0 Then
            strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FRETES"))
        End If
        Return strCadena
    End Function

    Public Function Fecha_Salida_Almacen(ByVal poDt As DataTable, ByVal NORSCI As Decimal) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow
        oDr = poDt.Select("NESTDO = 157 AND NORSCI=" & NORSCI)
        If oDr.Length > 0 Then
            strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FRETES"))
        End If
        Return strCadena
    End Function

    Public Function Fecha_Ingreso_Terminal(ByVal poDt As DataTable, ByVal NORSCI As Decimal) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow
        oDr = poDt.Select("NESTDO = 160 AND NORSCI=" & NORSCI)
        If oDr.Length > 0 Then
            strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FRETES"))
        End If
        Return strCadena
    End Function

    Public Function Fecha_Embarque(ByVal poDt As DataTable, ByVal NORSCI As Decimal) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow
        oDr = poDt.Select("NESTDO = 161 AND NORSCI=" & NORSCI)
        If oDr.Length > 0 Then
            strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FRETES"))
        End If
        Return strCadena
    End Function
    Public Function Fecha_Llegada(ByVal poDt As DataTable, ByVal NORSCI As Decimal) As String
        Dim strCadena As String = ""
        Dim oDr() As DataRow
        oDr = poDt.Select("NESTDO = 158  AND NORSCI=" & NORSCI)
        If oDr.Length > 0 Then
            strCadena = HelpClass.FechaNum_a_Fecha(oDr(0)("FRETES"))
        End If
        Return strCadena
    End Function

    '162    FECHA INGRESO
    '156    FECHA SOLICITUD
    '159    REQUERIMIENTO TRANSPORTE
    '157    SALIDA DE ALMACEN
    '160    INGRESO TERMINAL
    '161    FECHA DE EMBARQUE
    '158    FECHA LLEGADA
End Class
