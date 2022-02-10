Imports RANSA.DATA
Imports System.Data
Imports RANSA.TypeDef

Public Class brDespachoMovimientos
    Dim oDatos As New daDespachoMovimientos
    Enum MedioEnvio
        TERRESTRE = 1
        FLUVIAL = 2
        AEREO = 3
    End Enum
    Public Function ListarMovimientoFecha(ByVal obe_DespachoMovimientos As beDespachoMovimientos) As List(Of beDespachoMovimientos)

        Dim lobe_DespachoMovimientos As New List(Of beDespachoMovimientos)
        lobe_DespachoMovimientos = oDatos.ListarMovimientoFecha(obe_DespachoMovimientos)

        Return lobe_DespachoMovimientos
    End Function
    Public Function EliminaColumnas(ByVal objResumenFin As DataTable) As DataTable
        objResumenFin.Columns.Remove("MEDENVIO")
        objResumenFin.Columns.Remove("GUIATRANS")
        objResumenFin.Columns.Remove("CUENTA")
        objResumenFin.Columns.Remove("FGUIRM")
        objResumenFin.Columns.Remove("IMPORTE")
        objResumenFin.Columns.Remove("FECHA_GUIATARNS")
        objResumenFin.Columns.Remove("TUNDVH")
        objResumenFin.Columns.Remove("RUTA")
        objResumenFin.Columns.Remove("TCMTRT")
        objResumenFin.Columns.Remove("NPLCTR")
        objResumenFin.Columns.Remove("NPLCAC")
        objResumenFin.Columns.Remove("CTRMNC")
        objResumenFin.Columns.Remove("NRUCTR")
        objResumenFin.Columns.Remove("NCSOTR")
        objResumenFin.Columns.Remove("FCHFTR")

        Return objResumenFin
    End Function

    Public Function CrearColumnasTransporte(ByVal objResumenFin As DataTable, ByVal intCantidad As Integer, ByVal i As String) As DataTable
        For j As Integer = 0 To intCantidad - 1
            objResumenFin.Columns.Add(New DataColumn(i + "_MEDENVIO", GetType(System.String)))
            objResumenFin.Columns.Add(New DataColumn(i + "_GUIATRANS", GetType(System.String)))
            objResumenFin.Columns.Add(New DataColumn(i + "_FGUIRM", GetType(System.String)))
            objResumenFin.Columns.Add(New DataColumn(i + "_FECHA_GUIATARNS", GetType(System.String)))
            objResumenFin.Columns.Add(New DataColumn(i + "_TUNDVH", GetType(System.String)))
            objResumenFin.Columns.Add(New DataColumn(i + "_IMPORTE", GetType(System.String)))
            objResumenFin.Columns.Add(New DataColumn(i + "_RUTA", GetType(System.String)))
            objResumenFin.Columns.Add(New DataColumn(i + "_TCMTRT", GetType(System.String)))
            objResumenFin.Columns.Add(New DataColumn(i + "_NPLCTR", GetType(System.String)))
            objResumenFin.Columns.Add(New DataColumn(i + "_NPLCAC", GetType(System.String)))
            objResumenFin.Columns.Add(New DataColumn(i + "_CTRMNC", GetType(System.String)))
            objResumenFin.Columns.Add(New DataColumn(i + "_NRUCTR", GetType(System.String)))
            objResumenFin.Columns.Add(New DataColumn(i + "_CUENTA", GetType(System.String)))
            objResumenFin.Columns.Add(New DataColumn(i + "_NCSOTR", GetType(System.String)))
            objResumenFin.Columns.Add(New DataColumn(i + "_FCHFTR", GetType(System.String)))
            i = i + 1
        Next
        Return objResumenFin
    End Function

    Public Function MedioEnvioConvertInteger(ByVal srtMedio As String) As Integer
        Dim strMedio As Integer
        Select Case srtMedio
            Case "TERRESTRE"
                strMedio = MedioEnvio.TERRESTRE
            Case "FLUVIAL"
                strMedio = MedioEnvio.FLUVIAL
            Case "AEREO"
                strMedio = MedioEnvio.AEREO
        End Select
        Return strMedio
    End Function

    Public Function ListarMovimientoFecha_OC(ByVal obe_DespachoMovimientos_BE As beDespachoMovimientos, ByRef PageCount As Integer) As DataTable
        Dim ObjDespachoMovimientos_BE As New DataTable
        ObjDespachoMovimientos_BE = oDatos.ListarMovimientoFecha_OC(obe_DespachoMovimientos_BE, PageCount)

        Dim drSelect As DataRow() = Nothing
        Dim objDataRow As DataRow = Nothing
        Dim objResumenFin As New DataTable
        objResumenFin = ObjDespachoMovimientos_BE.Clone
        ''Elima Columnas de transporte
        EliminaColumnas(objResumenFin)
        Dim intTemporalCount As Integer = 0
        ' Se crean la Columnas Por los tres tipos de Medio de envio
        CrearColumnasTransporte(objResumenFin, 3, 1)
        For i As Integer = 0 To ObjDespachoMovimientos_BE.Rows.Count - 1
            drSelect = ObjDespachoMovimientos_BE.Select("TCMPCL = '" + ObjDespachoMovimientos_BE.Rows(i)("TCMPCL").ToString.Trim + "' AND PLANTA = '" + ObjDespachoMovimientos_BE.Rows(i)("PLANTA").ToString + "' AND NGUIRM = '" + ObjDespachoMovimientos_BE.Rows(i)("NGUIRM").ToString + "' AND CREFFW = '" + ObjDespachoMovimientos_BE.Rows(i)("CREFFW").ToString + "' AND NSEQIN = " + ObjDespachoMovimientos_BE.Rows(i)("NSEQIN").ToString)
            ''Crea Nuevos registros
            objDataRow = objResumenFin.NewRow
            Dim value As String
            For Each dc As DataColumn In objResumenFin.Columns
                value = dc.ColumnName
                If Not value.EndsWith("_MEDENVIO") _
                            AndAlso Not value.EndsWith("_CUENTA") _
                                 AndAlso Not value.EndsWith("_GUIATRANS") _
                                    AndAlso Not value.EndsWith("_FGUIRM") _
                                     AndAlso Not value.EndsWith("_IMPORTE") _
                                      AndAlso Not value.EndsWith("_TUNDVH") _
                                       AndAlso Not value.EndsWith("_RUTA") _
                                        AndAlso Not value.EndsWith("_TCMTRT") _
                                         AndAlso Not value.EndsWith("_NPLCTR") _
                                          AndAlso Not value.EndsWith("_NPLCAC") _
                                           AndAlso Not (dc.ColumnName.EndsWith("_FECHA_GUIATARNS")) _
                                            AndAlso Not (dc.ColumnName.EndsWith("_CTRMNC")) _
                                             AndAlso Not (dc.ColumnName.EndsWith("_NRUCTR")) _
                                              AndAlso Not (dc.ColumnName.EndsWith("_NCSOTR")) _
                                               AndAlso Not (dc.ColumnName.EndsWith("_FCHFTR")) Then
                    If drSelect.Length = 0 OrElse IsDBNull(drSelect(0)(value)) Then
                        If dc.ColumnName.Equals("DIAS") OrElse dc.ColumnName.Equals("DIASCL") Then
                            objDataRow.Item(value) = 0
                        Else
                            objDataRow.Item(value) = ""
                        End If
                    Else
                        objDataRow.Item(value) = drSelect(0)(value).ToString
                    End If
                End If

            Next

            objResumenFin.Rows.Add(objDataRow)

            ''Añade los registros en los Campos Dinamicos
            Dim strMedioAnterior As String = ""
            Dim j As Integer = 1
            Dim ctRow As Integer = 0
            For Each dr As DataRow In drSelect
                If strMedioAnterior <> dr("MEDENVIO").ToString.Trim Then

                    j = MedioEnvioConvertInteger(dr("MEDENVIO").ToString.Trim)

                    objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item(j.ToString.Trim + "_MEDENVIO") = dr("MEDENVIO").ToString.Trim
                    objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item(j.ToString.Trim + "_GUIATRANS") = dr("GUIATRANS").ToString.Trim
                    objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item(j.ToString.Trim + "_FGUIRM") = dr("FGUIRM").ToString.Trim
                    objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item(j.ToString.Trim + "_FECHA_GUIATARNS") = dr("FECHA_GUIATARNS").ToString.Trim
                    objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item(j.ToString.Trim + "_TUNDVH") = dr("TUNDVH").ToString.Trim
                    objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item(j.ToString.Trim + "_RUTA") = dr("RUTA").ToString.Trim
                    objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item(j.ToString.Trim + "_TCMTRT") = dr("TCMTRT").ToString.Trim
                    objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item(j.ToString.Trim + "_NPLCTR") = dr("NPLCTR").ToString.Trim
                    objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item(j.ToString.Trim + "_NPLCAC") = dr("NPLCAC").ToString.Trim
                    objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item(j.ToString.Trim + "_CTRMNC") = dr("CTRMNC").ToString.Trim
                    objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item(j.ToString.Trim + "_NRUCTR") = dr("NRUCTR").ToString.Trim
                    objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item(j.ToString.Trim + "_CUENTA") = dr("CUENTA").ToString.Trim
                    objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item(j.ToString.Trim + "_NCSOTR") = dr("NCSOTR").ToString.Trim
                    objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item(j.ToString.Trim + "_FCHFTR") = dr("FCHFTR").ToString.Trim
                    objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item(j.ToString.Trim + "_IMPORTE") = dr("IMPORTE").ToString.Trim

                    strMedioAnterior = dr("MEDENVIO").ToString.Trim
                    objResumenFin.AcceptChanges()
                Else
                    ''''''''''''''''''''''''''''''''''''''''''''''''
                    Dim objDataRow2 As DataRow = Nothing
                    objDataRow2 = objResumenFin.NewRow
                    If drSelect.Length > 1 Then

                        For Each dc As DataColumn In objResumenFin.Columns
                            value = dc.ColumnName
                            If Not value.EndsWith("_MEDENVIO") _
                                        AndAlso Not value.EndsWith("_CUENTA") _
                                             AndAlso Not value.EndsWith("_GUIATRANS") _
                                                AndAlso Not value.EndsWith("_FGUIRM") _
                                                 AndAlso Not value.EndsWith("_IMPORTE") _
                                                  AndAlso Not value.EndsWith("_TUNDVH") _
                                                   AndAlso Not value.EndsWith("_RUTA") _
                                                    AndAlso Not value.EndsWith("_TCMTRT") _
                                                     AndAlso Not value.EndsWith("_NPLCTR") _
                                                      AndAlso Not value.EndsWith("_NPLCAC") _
                                                       AndAlso Not (dc.ColumnName.EndsWith("_FECHA_GUIATARNS")) _
                                                        AndAlso Not (dc.ColumnName.EndsWith("_CTRMNC")) _
                                                         AndAlso Not (dc.ColumnName.EndsWith("_NRUCTR")) _
                                                          AndAlso Not (dc.ColumnName.EndsWith("_NCSOTR")) _
                                                           AndAlso Not (dc.ColumnName.EndsWith("_FCHFTR")) Then
                                If IsDBNull(drSelect(ctRow)(value)) Then
                                    If dc.ColumnName.Equals("DIAS") OrElse dc.ColumnName.Equals("DIASCL") Then
                                        objDataRow2.Item(value) = 0
                                    Else
                                        objDataRow2.Item(value) = ""
                                    End If
                                Else
                                    objDataRow2.Item(value) = drSelect(ctRow)(value).ToString
                                End If
                            End If

                        Next


                        objResumenFin.Rows.Add(objDataRow2)

                        j = MedioEnvioConvertInteger(dr("MEDENVIO").ToString.Trim)

                        objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item(j.ToString.Trim + "_MEDENVIO") = dr("MEDENVIO").ToString.Trim
                        objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item(j.ToString.Trim + "_GUIATRANS") = dr("GUIATRANS").ToString.Trim
                        objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item(j.ToString.Trim + "_FGUIRM") = dr("FGUIRM").ToString.Trim
                        objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item(j.ToString.Trim + "_FECHA_GUIATARNS") = dr("FECHA_GUIATARNS").ToString.Trim
                        objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item(j.ToString.Trim + "_TUNDVH") = dr("TUNDVH").ToString.Trim
                        objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item(j.ToString.Trim + "_RUTA") = dr("RUTA").ToString.Trim
                        objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item(j.ToString.Trim + "_TCMTRT") = dr("TCMTRT").ToString.Trim
                        objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item(j.ToString.Trim + "_NPLCTR") = dr("NPLCTR").ToString.Trim
                        objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item(j.ToString.Trim + "_NPLCAC") = dr("NPLCAC").ToString.Trim
                        objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item(j.ToString.Trim + "_CTRMNC") = dr("CTRMNC").ToString.Trim
                        objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item(j.ToString.Trim + "_NRUCTR") = dr("NRUCTR").ToString.Trim
                        objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item(j.ToString.Trim + "_CUENTA") = dr("CUENTA").ToString.Trim
                        objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item(j.ToString.Trim + "_NCSOTR") = dr("NCSOTR").ToString.Trim
                        objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item(j.ToString.Trim + "_FCHFTR") = dr("FCHFTR").ToString.Trim
                        objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item(j.ToString.Trim + "_IMPORTE") = dr("IMPORTE").ToString.Trim

                        objResumenFin.AcceptChanges()

                    End If
                End If
                ctRow = ctRow + 1
            Next

            i = i + drSelect.Length - 1
        Next

        '' Por sino se Crearon ls Columnas "_2"
        'If objResumenFin.Columns.Item("2_MEDENVIO") Is Nothing Then
        '    CrearColumnasTransporte(objResumenFin, 1, 2)
        'End If


        'Cambia los Indices de TCTAFE y LINK al Final
        Dim colum As New DataColumn
        Dim dtCopyColum As DataTable = objResumenFin.Clone

        Dim intIndexDetalle As Integer = dtCopyColum.Columns.Count

        For Each colum In dtCopyColum.Columns
            If colum.ColumnName = "TCTAFE" OrElse colum.ColumnName = "LINK" Then
                objResumenFin.Columns(colum.ColumnName).SetOrdinal(intIndexDetalle - 1)
                objResumenFin.Columns(colum.ColumnName).ColumnName = colum.ColumnName
            End If
        Next

        Dim dvR As New DataView(objResumenFin)
        dvR.Sort = "TCMPCL,PLANTA, FSLFFW DESC,CREFFW ASC"


        objResumenFin = dvR.ToTable()
        Return objResumenFin

    End Function

End Class
