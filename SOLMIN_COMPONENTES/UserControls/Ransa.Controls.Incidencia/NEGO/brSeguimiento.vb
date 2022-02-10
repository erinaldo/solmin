Public Class brSeguimiento
    Dim oDatos As New daSeguimiento

    Public Function intInsertarMaestroIncidencias(ByVal obeSeguimiento As beSeguimiento) As Integer
        Return oDatos.intInsertarMaestroIncidencias(obeSeguimiento)
    End Function

    Public Function Lista_Nivel_y_Reportado() As DataSet
        Dim ds As New DataSet

        ds = oDatos.dsLista_Nivel_y_Reportado()

        Return ds
    End Function

    'Public Function Lista_Origenes() As DataTable

    '    Dim dt As New DataTable
    '    Dim dr As DataRow
    '    dt.Columns.Add("SORINC")
    '    dt.Columns.Add("DESCRIPCION")

    '    dr = dt.NewRow
    '    dr("SORINC") = "Q"
    '    dr("DESCRIPCION") = "Queja cliente"
    '    dt.Rows.Add(dr)

    '    dr = dt.NewRow
    '    dr("SORINC") = "N"
    '    dr("DESCRIPCION") = "Negocio"
    '    dt.Rows.Add(dr)

    '    dr = dt.NewRow
    '    dr("SORINC") = "O"
    '    dr("DESCRIPCION") = "Operación"
    '    dt.Rows.Add(dr)

    '    dr = dt.NewRow
    '    dr("SORINC") = "A"
    '    dr("DESCRIPCION") = "Administración"
    '    dt.Rows.Add(dr)

    '    Return dt
    'End Function

    Public Sub intActualizarMaestroIncidencias(ByVal obeSeguimiento As beSeguimiento)
        oDatos.intActualizarMaestroIncidencias(obeSeguimiento)
    End Sub

    Public Function intEliminarMaestroIncidencias(ByVal obeSeguimiento As beSeguimiento) As Integer
        Return oDatos.intEliminarMaestroIncidencias(obeSeguimiento)
    End Function

    Public Sub intGuardarImagenIncidencias(ByVal NINCSI As Decimal, ByVal NMRGIM As Decimal, ByVal usuario As String, ByVal NTRMNL As String)
        oDatos.intGuardarImagenIncidencias(NINCSI, NMRGIM, usuario, NTRMNL)
    End Sub

    Public Sub intEliminarImagenIncidencias(ByVal NINCSI As Decimal, ByVal NMRGIM As Decimal, ByVal usuario As String, ByVal NTRMNL As String)
        oDatos.intEliminarImagenIncidencias(NINCSI, NMRGIM, usuario, NTRMNL)
    End Sub

    'Public Function olistListarMaestroIncidencias(ByVal obeIncidencias As beIncidencias) As DataSet

    '    Dim dtMeses As DataTable
    '    Dim dsMeses As New DataSet
    '    Dim dsMeses_Validado As New DataSet
    '    Dim Estado As String = ""
    '    Dim dr As DataRow
    '    Dim m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12 As Integer

    '    Dim codigo As String = ""
    '    Dim codigo1 As String = ""

    '    dtMeses = New DataTable

    '    dtMeses.Columns.Add("CCMPN", Type.GetType("System.String"))
    '    dtMeses.Columns.Add("CDVSN", Type.GetType("System.String"))
    '    dtMeses.Columns.Add("TCMPDV", Type.GetType("System.String"))
    '    dtMeses.Columns.Add("CINCID", Type.GetType("System.Int32"))
    '    dtMeses.Columns.Add("TINCSI", Type.GetType("System.String"))

    '    dtMeses.Columns.Add("ENE", Type.GetType("System.Int32"))
    '    dtMeses.Columns.Add("FEB", Type.GetType("System.Int32"))
    '    dtMeses.Columns.Add("MAR", Type.GetType("System.Int32"))
    '    dtMeses.Columns.Add("ABR", Type.GetType("System.Int32"))
    '    dtMeses.Columns.Add("MAY", Type.GetType("System.Int32"))
    '    dtMeses.Columns.Add("JUN", Type.GetType("System.Int32"))
    '    dtMeses.Columns.Add("JUL", Type.GetType("System.Int32"))
    '    dtMeses.Columns.Add("AGO", Type.GetType("System.Int32"))
    '    dtMeses.Columns.Add("SEP", Type.GetType("System.Int32"))
    '    dtMeses.Columns.Add("OCT", Type.GetType("System.Int32"))
    '    dtMeses.Columns.Add("NOV", Type.GetType("System.Int32"))
    '    dtMeses.Columns.Add("DIC", Type.GetType("System.Int32"))
    '    dtMeses.Columns.Add("TOTAL", Type.GetType("System.Int32"))

    '    dtMeses.Columns.Add("CODIGO", Type.GetType("System.String"))

    '    dsMeses_Validado.Tables.Add(dtMeses)

    '    dsMeses = oDatos.olistListarMaestroIncidencias(obeIncidencias)

    '    For j As Integer = 0 To dsMeses.Tables(0).Rows.Count - 1

    '        m1 = 0
    '        m2 = 0
    '        m3 = 0
    '        m4 = 0
    '        m5 = 0
    '        m6 = 0
    '        m7 = 0
    '        m8 = 0
    '        m9 = 0
    '        m10 = 0
    '        m11 = 0
    '        m12 = 0

    '        dr = dsMeses_Validado.Tables(0).NewRow
    '        codigo = ""

    '        dr("CCMPN") = dsMeses.Tables(0).Rows(j).Item("CCMPN")
    '        dr("CDVSN") = dsMeses.Tables(0).Rows(j).Item("CDVSN")
    '        codigo = String.Format("{0}{1}", codigo, dsMeses.Tables(0).Rows(j).Item("CDVSN").ToString.Trim)

    '        dr("TCMPDV") = dsMeses.Tables(0).Rows(j).Item("TCMPDV").Trim

    '        dr("CINCID") = CInt(dsMeses.Tables(0).Rows(j).Item("CINCID"))
    '        codigo = String.Format("{0}{1}", codigo, dsMeses.Tables(0).Rows(j).Item("CINCID").ToString.Trim)

    '        dr("TINCSI") = dsMeses.Tables(0).Rows(j).Item("TINCSI").Trim


    '        If dsMeses_Validado.Tables(0).Rows.Count > 0 Then

    '            For k As Integer = 0 To dsMeses_Validado.Tables(0).Rows.Count - 1

    '                Estado = ""

    '                If dsMeses_Validado.Tables(0).Rows(k).Item("CODIGO").ToString.Trim = String.Format("{0}", codigo) Then

    '                    Select Case CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(4, 2))

    '                        Case 1
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("ENE") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("ENE")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            Estado = "A"
    '                            Exit For
    '                        Case 2
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("FEB") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("FEB")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            Estado = "A"
    '                            Exit For
    '                        Case 3
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("MAR") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("MAR")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            Estado = "A"
    '                            Exit For
    '                        Case 4
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("ABR") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("ABR")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            Estado = "A"
    '                            Exit For
    '                        Case 5
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("MAY") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("MAY")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            Estado = "A"
    '                            Exit For
    '                        Case 6
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("JUN") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("JUN")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            Estado = "A"
    '                            Exit For
    '                        Case 7
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("JUL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("JUL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            Estado = "A"
    '                            Exit For
    '                        Case 8
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("AGO") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("AGO")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            Estado = "A"
    '                            Exit For
    '                        Case 9
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("SEP") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("SEP")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            Estado = "A"
    '                            Exit For
    '                        Case 10
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("OCT") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("OCT")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            Estado = "A"
    '                            Exit For
    '                        Case 11
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("NOV") = Val(dsMeses_Validado.Tables(0).Rows(k).Item("NOV")) + Val(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            Estado = "A"
    '                            Exit For
    '                        Case 12
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("DIC") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("DIC")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            Estado = "A"
    '                            Exit For
    '                        Case Else

    '                    End Select

    '                End If

    '                Estado = "I"

    '            Next

    '            If Estado <> "A" Then

    '                Select Case CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(4, 2))

    '                    Case 1
    '                        dr("ENE") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        m1 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        dr("FEB") = 0
    '                        m2 = 0
    '                        dr("MAR") = 0
    '                        m3 = 0
    '                        dr("ABR") = 0
    '                        m4 = 0
    '                        dr("MAY") = 0
    '                        m5 = 0
    '                        dr("JUN") = 0
    '                        m6 = 0
    '                        dr("JUL") = 0
    '                        m7 = 0
    '                        dr("AGO") = 0
    '                        m8 = 0
    '                        dr("SEP") = 0
    '                        m9 = 0
    '                        dr("OCT") = 0
    '                        m10 = 0
    '                        dr("NOV") = 0
    '                        m11 = 0
    '                        dr("DIC") = 0
    '                        m12 = 0
    '                    Case 2
    '                        dr("ENE") = 0
    '                        m1 = 0
    '                        dr("FEB") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        m2 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        dr("MAR") = 0
    '                        m3 = 0
    '                        dr("ABR") = 0
    '                        m4 = 0
    '                        dr("MAY") = 0
    '                        m5 = 0
    '                        dr("JUN") = 0
    '                        m6 = 0
    '                        dr("JUL") = 0
    '                        m7 = 0
    '                        dr("AGO") = 0
    '                        m8 = 0
    '                        dr("SEP") = 0
    '                        m9 = 0
    '                        dr("OCT") = 0
    '                        m10 = 0
    '                        dr("NOV") = 0
    '                        m11 = 0
    '                        dr("DIC") = 0
    '                        m12 = 0
    '                    Case 3
    '                        dr("ENE") = 0
    '                        m1 = 0
    '                        dr("FEB") = 0
    '                        m2 = 0
    '                        dr("MAR") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        m3 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        dr("ABR") = 0
    '                        m4 = 0
    '                        dr("MAY") = 0
    '                        m5 = 0
    '                        dr("JUN") = 0
    '                        m6 = 0
    '                        dr("JUL") = 0
    '                        m7 = 0
    '                        dr("AGO") = 0
    '                        m8 = 0
    '                        dr("SEP") = 0
    '                        m9 = 0
    '                        dr("OCT") = 0
    '                        m10 = 0
    '                        dr("NOV") = 0
    '                        m11 = 0
    '                        dr("DIC") = 0
    '                        m12 = 0
    '                    Case 4
    '                        dr("ENE") = 0
    '                        m1 = 0
    '                        dr("FEB") = 0
    '                        m2 = 0
    '                        dr("MAR") = 0
    '                        m3 = 0
    '                        dr("ABR") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        m4 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        dr("MAY") = 0
    '                        m5 = 0
    '                        dr("JUN") = 0
    '                        m6 = 0
    '                        dr("JUL") = 0
    '                        m7 = 0
    '                        dr("AGO") = 0
    '                        m8 = 0
    '                        dr("SEP") = 0
    '                        m9 = 0
    '                        dr("OCT") = 0
    '                        m10 = 0
    '                        dr("NOV") = 0
    '                        m11 = 0
    '                        dr("DIC") = 0
    '                        m12 = 0

    '                    Case 5
    '                        dr("ENE") = 0
    '                        m1 = 0
    '                        dr("FEB") = 0
    '                        m2 = 0
    '                        dr("MAR") = 0
    '                        m3 = 0
    '                        dr("ABR") = 0
    '                        m4 = 0
    '                        dr("MAY") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        m5 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        dr("JUN") = 0
    '                        m6 = 0
    '                        dr("JUL") = 0
    '                        m7 = 0
    '                        dr("AGO") = 0
    '                        m8 = 0
    '                        dr("SEP") = 0
    '                        m9 = 0
    '                        dr("OCT") = 0
    '                        m10 = 0
    '                        dr("NOV") = 0
    '                        m11 = 0
    '                        dr("DIC") = 0
    '                        m12 = 0
    '                    Case 6
    '                        dr("ENE") = 0
    '                        m1 = 0
    '                        dr("FEB") = 0
    '                        m2 = 0
    '                        dr("MAR") = 0
    '                        m3 = 0
    '                        dr("ABR") = 0
    '                        m4 = 0
    '                        dr("MAY") = 0
    '                        m5 = 0
    '                        dr("JUN") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        m6 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        dr("JUL") = 0
    '                        m7 = 0
    '                        dr("AGO") = 0
    '                        m8 = 0
    '                        dr("SEP") = 0
    '                        m9 = 0
    '                        dr("OCT") = 0
    '                        m10 = 0
    '                        dr("NOV") = 0
    '                        m11 = 0
    '                        dr("DIC") = 0
    '                        m12 = 0
    '                    Case 7
    '                        dr("ENE") = 0
    '                        m1 = 0
    '                        dr("FEB") = 0
    '                        m2 = 0
    '                        dr("MAR") = 0
    '                        m3 = 0
    '                        dr("ABR") = 0
    '                        m4 = 0
    '                        dr("MAY") = 0
    '                        m5 = 0
    '                        dr("JUN") = 0
    '                        m6 = 0
    '                        dr("JUL") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        m7 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        dr("AGO") = 0
    '                        m8 = 0
    '                        dr("SEP") = 0
    '                        m9 = 0
    '                        dr("OCT") = 0
    '                        m10 = 0
    '                        dr("NOV") = 0
    '                        m11 = 0
    '                        dr("DIC") = 0
    '                        m12 = 0
    '                    Case 8
    '                        dr("ENE") = 0
    '                        m1 = 0
    '                        dr("FEB") = 0
    '                        m2 = 0
    '                        dr("MAR") = 0
    '                        m3 = 0
    '                        dr("ABR") = 0
    '                        m4 = 0
    '                        dr("MAY") = 0
    '                        m5 = 0
    '                        dr("JUN") = 0
    '                        m6 = 0
    '                        dr("JUL") = 0
    '                        m7 = 0
    '                        dr("AGO") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        m8 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        dr("SEP") = 0
    '                        m9 = 0
    '                        dr("OCT") = 0
    '                        m10 = 0
    '                        dr("NOV") = 0
    '                        m11 = 0
    '                        dr("DIC") = 0
    '                        m12 = 0
    '                    Case 9
    '                        dr("ENE") = 0
    '                        m1 = 0
    '                        dr("FEB") = 0
    '                        m2 = 0
    '                        dr("MAR") = 0
    '                        m3 = 0
    '                        dr("ABR") = 0
    '                        m4 = 0
    '                        dr("MAY") = 0
    '                        m5 = 0
    '                        dr("JUN") = 0
    '                        m6 = 0
    '                        dr("JUL") = 0
    '                        m7 = 0
    '                        dr("AGO") = 0
    '                        m8 = 0
    '                        dr("SEP") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        m9 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        dr("OCT") = 0
    '                        m10 = 0
    '                        dr("NOV") = 0
    '                        m11 = 0
    '                        dr("DIC") = 0
    '                        m12 = 0
    '                    Case 10
    '                        dr("ENE") = 0
    '                        m1 = 0
    '                        dr("FEB") = 0
    '                        m2 = 0
    '                        dr("MAR") = 0
    '                        m3 = 0
    '                        dr("ABR") = 0
    '                        m4 = 0
    '                        dr("MAY") = 0
    '                        m5 = 0
    '                        dr("JUN") = 0
    '                        m6 = 0
    '                        dr("JUL") = 0
    '                        m7 = 0
    '                        dr("AGO") = 0
    '                        m8 = 0
    '                        dr("SEP") = 0
    '                        m9 = 0
    '                        dr("OCT") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        m10 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        dr("NOV") = 0
    '                        m11 = 0
    '                        dr("DIC") = 0
    '                        m12 = 0

    '                    Case 11
    '                        dr("ENE") = 0
    '                        m1 = 0
    '                        dr("FEB") = 0
    '                        m2 = 0
    '                        dr("MAR") = 0
    '                        m3 = 0
    '                        dr("ABR") = 0
    '                        m4 = 0
    '                        dr("MAY") = 0
    '                        m5 = 0
    '                        dr("JUN") = 0
    '                        m6 = 0
    '                        dr("JUL") = 0
    '                        m7 = 0
    '                        dr("AGO") = 0
    '                        m8 = 0
    '                        dr("SEP") = 0
    '                        m9 = 0
    '                        dr("OCT") = 0
    '                        m10 = 0
    '                        dr("NOV") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        m11 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        dr("DIC") = 0
    '                        m12 = 0
    '                    Case 12
    '                        dr("ENE") = 0
    '                        m1 = 0
    '                        dr("FEB") = 0
    '                        m2 = 0
    '                        dr("MAR") = 0
    '                        m3 = 0
    '                        dr("ABR") = 0
    '                        m4 = 0
    '                        dr("MAY") = 0
    '                        m5 = 0
    '                        dr("JUN") = 0
    '                        m6 = 0
    '                        dr("JUL") = 0
    '                        m7 = 0
    '                        dr("AGO") = 0
    '                        m8 = 0
    '                        dr("SEP") = 0
    '                        m9 = 0
    '                        dr("OCT") = 0
    '                        m10 = 0
    '                        dr("NOV") = 0
    '                        m11 = 0
    '                        dr("DIC") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        m12 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))

    '                    Case Else

    '                End Select

    '                dr("TOTAL") = m1 + m2 + m3 + m4 + m5 + m6 + m7 + m8 + m9 + m10 + m11 + m12
    '                dr("CODIGO") = codigo
    '                dsMeses_Validado.Tables(0).Rows.Add(dr)

    '            End If

    '        Else

    '            Select Case CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(4, 2))
    '                Case 1
    '                    dr("ENE") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    m1 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    dr("FEB") = 0
    '                    m2 = 0
    '                    dr("MAR") = 0
    '                    m3 = 0
    '                    dr("ABR") = 0
    '                    m4 = 0
    '                    dr("MAY") = 0
    '                    m5 = 0
    '                    dr("JUN") = 0
    '                    m6 = 0
    '                    dr("JUL") = 0
    '                    m7 = 0
    '                    dr("AGO") = 0
    '                    m8 = 0
    '                    dr("SEP") = 0
    '                    m9 = 0
    '                    dr("OCT") = 0
    '                    m10 = 0
    '                    dr("NOV") = 0
    '                    m11 = 0
    '                    dr("DIC") = 0
    '                    m12 = 0
    '                Case 2
    '                    dr("ENE") = 0
    '                    m1 = 0
    '                    dr("FEB") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    m2 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    dr("MAR") = 0
    '                    m3 = 0
    '                    dr("ABR") = 0
    '                    m4 = 0
    '                    dr("MAY") = 0
    '                    m5 = 0
    '                    dr("JUN") = 0
    '                    m6 = 0
    '                    dr("JUL") = 0
    '                    m7 = 0
    '                    dr("AGO") = 0
    '                    m8 = 0
    '                    dr("SEP") = 0
    '                    m9 = 0
    '                    dr("OCT") = 0
    '                    m10 = 0
    '                    dr("NOV") = 0
    '                    m11 = 0
    '                    dr("DIC") = 0
    '                    m12 = 0
    '                Case 3
    '                    dr("ENE") = 0
    '                    m1 = 0
    '                    dr("FEB") = 0
    '                    m2 = 0
    '                    dr("MAR") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    m3 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    dr("ABR") = 0
    '                    m4 = 0
    '                    dr("MAY") = 0
    '                    m5 = 0
    '                    dr("JUN") = 0
    '                    m6 = 0
    '                    dr("JUL") = 0
    '                    m7 = 0
    '                    dr("AGO") = 0
    '                    m8 = 0
    '                    dr("SEP") = 0
    '                    m9 = 0
    '                    dr("OCT") = 0
    '                    m10 = 0
    '                    dr("NOV") = 0
    '                    m11 = 0
    '                    dr("DIC") = 0
    '                    m12 = 0
    '                Case 4
    '                    dr("ENE") = 0
    '                    m1 = 0
    '                    dr("FEB") = 0
    '                    m2 = 0
    '                    dr("MAR") = 0
    '                    m3 = 0
    '                    dr("ABR") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    m4 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    dr("MAY") = 0
    '                    m5 = 0
    '                    dr("JUN") = 0
    '                    m6 = 0
    '                    dr("JUL") = 0
    '                    m7 = 0
    '                    dr("AGO") = 0
    '                    m8 = 0
    '                    dr("SEP") = 0
    '                    m9 = 0
    '                    dr("OCT") = 0
    '                    m10 = 0
    '                    dr("NOV") = 0
    '                    m11 = 0
    '                    dr("DIC") = 0
    '                    m12 = 0
    '                Case 5
    '                    dr("ENE") = 0
    '                    m1 = 0
    '                    dr("FEB") = 0
    '                    m2 = 0
    '                    dr("MAR") = 0
    '                    m3 = 0
    '                    dr("ABR") = 0
    '                    m4 = 0
    '                    dr("MAY") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    m5 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    dr("JUN") = 0
    '                    m6 = 0
    '                    dr("JUL") = 0
    '                    m7 = 0
    '                    dr("AGO") = 0
    '                    m8 = 0
    '                    dr("SEP") = 0
    '                    m9 = 0
    '                    dr("OCT") = 0
    '                    m10 = 0
    '                    dr("NOV") = 0
    '                    m11 = 0
    '                    dr("DIC") = 0
    '                    m12 = 0
    '                Case 6
    '                    dr("ENE") = 0
    '                    m1 = 0
    '                    dr("FEB") = 0
    '                    m2 = 0
    '                    dr("MAR") = 0
    '                    m3 = 0
    '                    dr("ABR") = 0
    '                    m4 = 0
    '                    dr("MAY") = 0
    '                    m5 = 0
    '                    dr("JUN") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    m6 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    dr("JUL") = 0
    '                    m7 = 0
    '                    dr("AGO") = 0
    '                    m8 = 0
    '                    dr("SEP") = 0
    '                    m9 = 0
    '                    dr("OCT") = 0
    '                    m10 = 0
    '                    dr("NOV") = 0
    '                    m11 = 0
    '                    dr("DIC") = 0
    '                    m12 = 0
    '                Case 7
    '                    dr("ENE") = 0
    '                    m1 = 0
    '                    dr("FEB") = 0
    '                    m2 = 0
    '                    dr("MAR") = 0
    '                    m3 = 0
    '                    dr("ABR") = 0
    '                    m4 = 0
    '                    dr("MAY") = 0
    '                    m5 = 0
    '                    dr("JUN") = 0
    '                    m6 = 0
    '                    dr("JUL") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    m7 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    dr("AGO") = 0
    '                    m8 = 0
    '                    dr("SEP") = 0
    '                    m9 = 0
    '                    dr("OCT") = 0
    '                    m10 = 0
    '                    dr("NOV") = 0
    '                    m11 = 0
    '                    dr("DIC") = 0
    '                    m12 = 0
    '                Case 8
    '                    dr("ENE") = 0
    '                    m1 = 0
    '                    dr("FEB") = 0
    '                    m2 = 0
    '                    dr("MAR") = 0
    '                    m3 = 0
    '                    dr("ABR") = 0
    '                    m4 = 0
    '                    dr("MAY") = 0
    '                    m5 = 0
    '                    dr("JUN") = 0
    '                    m6 = 0
    '                    dr("JUL") = 0
    '                    m7 = 0
    '                    dr("AGO") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    m8 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    dr("SEP") = 0
    '                    m9 = 0
    '                    dr("OCT") = 0
    '                    m10 = 0
    '                    dr("NOV") = 0
    '                    m11 = 0
    '                    dr("DIC") = 0
    '                    m12 = 0
    '                Case 9
    '                    dr("ENE") = 0
    '                    m1 = 0
    '                    dr("FEB") = 0
    '                    m2 = 0
    '                    dr("MAR") = 0
    '                    m3 = 0
    '                    dr("ABR") = 0
    '                    m4 = 0
    '                    dr("MAY") = 0
    '                    m5 = 0
    '                    dr("JUN") = 0
    '                    m6 = 0
    '                    dr("JUL") = 0
    '                    m7 = 0
    '                    dr("AGO") = 0
    '                    m8 = 0
    '                    dr("SEP") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    m9 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    dr("OCT") = 0
    '                    m10 = 0
    '                    dr("NOV") = 0
    '                    m11 = 0
    '                    dr("DIC") = 0
    '                    m12 = 0
    '                Case 10
    '                    dr("ENE") = 0
    '                    m1 = 0
    '                    dr("FEB") = 0
    '                    m2 = 0
    '                    dr("MAR") = 0
    '                    m3 = 0
    '                    dr("ABR") = 0
    '                    m4 = 0
    '                    dr("MAY") = 0
    '                    m5 = 0
    '                    dr("JUN") = 0
    '                    m6 = 0
    '                    dr("JUL") = 0
    '                    m7 = 0
    '                    dr("AGO") = 0
    '                    m8 = 0
    '                    dr("SEP") = 0
    '                    m9 = 0
    '                    dr("OCT") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    m10 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    dr("NOV") = 0
    '                    m11 = 0
    '                    dr("DIC") = 0
    '                    m12 = 0
    '                Case 11
    '                    dr("ENE") = 0
    '                    m1 = 0
    '                    dr("FEB") = 0
    '                    m2 = 0
    '                    dr("MAR") = 0
    '                    m3 = 0
    '                    dr("ABR") = 0
    '                    m4 = 0
    '                    dr("MAY") = 0
    '                    m5 = 0
    '                    dr("JUN") = 0
    '                    m6 = 0
    '                    dr("JUL") = 0
    '                    m7 = 0
    '                    dr("AGO") = 0
    '                    m8 = 0
    '                    dr("SEP") = 0
    '                    m9 = 0
    '                    dr("OCT") = 0
    '                    m10 = 0
    '                    dr("NOV") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    m11 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    dr("DIC") = 0
    '                    m12 = 0
    '                Case 12
    '                    dr("ENE") = 0
    '                    m1 = 0
    '                    dr("FEB") = 0
    '                    m2 = 0
    '                    dr("MAR") = 0
    '                    m3 = 0
    '                    dr("ABR") = 0
    '                    m4 = 0
    '                    dr("MAY") = 0
    '                    m5 = 0
    '                    dr("JUN") = 0
    '                    m6 = 0
    '                    dr("JUL") = 0
    '                    m7 = 0
    '                    dr("AGO") = 0
    '                    m8 = 0
    '                    dr("SEP") = 0
    '                    m9 = 0
    '                    dr("OCT") = 0
    '                    m10 = 0
    '                    dr("NOV") = 0
    '                    m11 = 0
    '                    dr("DIC") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    m12 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                Case Else

    '            End Select
    '            dr("TOTAL") = m1 + m2 + m3 + m4 + m5 + m6 + m7 + m8 + m9 + m10 + m11 + m12
    '            dr("CODIGO") = codigo
    '            dsMeses_Validado.Tables(0).Rows.Add(dr)
    '        End If
    '    Next

    '    '   COMPLETANDO CON LAS INCIDENCIAS

    '    For i As Integer = 0 To dsMeses.Tables(1).Rows.Count - 1

    '        Dim cod As String = ""
    '        Dim x As Integer = 0
    '        cod = String.Format("{0}{1}", cod, dsMeses.Tables(1).Rows(i).Item("CDVSN").ToString.Trim)
    '        cod = String.Format("{0}{1}", cod, dsMeses.Tables(1).Rows(i).Item("CINCID").ToString.Trim)

    '        For a As Integer = 0 To dsMeses_Validado.Tables(0).Rows.Count - 1

    '            If dsMeses_Validado.Tables(0).Rows(a).Item("CODIGO").ToString.Trim = cod Then
    '                x = x + 1
    '                Exit For
    '            End If
    '        Next

    '        If x = 0 Then
    '            dr = dsMeses_Validado.Tables(0).NewRow
    '            codigo = ""
    '            dr("CCMPN") = dsMeses.Tables(1).Rows(i).Item("CCMPN")
    '            dr("CDVSN") = dsMeses.Tables(1).Rows(i).Item("CDVSN")
    '            dr("TCMPDV") = dsMeses.Tables(1).Rows(i).Item("TCMPDV").Trim
    '            dr("CINCID") = CInt(dsMeses.Tables(1).Rows(i).Item("CINCID"))
    '            dr("TINCSI") = dsMeses.Tables(1).Rows(i).Item("TINCSI").Trim
    '            dr("ENE") = 0
    '            dr("FEB") = 0
    '            dr("MAR") = 0
    '            dr("ABR") = 0
    '            dr("MAY") = 0
    '            dr("JUN") = 0
    '            dr("JUL") = 0
    '            dr("AGO") = 0
    '            dr("SEP") = 0
    '            dr("OCT") = 0
    '            dr("NOV") = 0
    '            dr("DIC") = 0
    '            dr("TOTAL") = 0
    '            dr("CODIGO") = cod
    '            dsMeses_Validado.Tables(0).Rows.Add(dr)
    '        End If
    '    Next


    '    Return dsMeses_Validado

    'End Function

    Public Function olistListarMaestroIncidencias(ByVal obeSeguimiento As beSeguimiento) As DataTable
        Dim dtMeses As DataTable
        Dim dsMeses As New DataSet
        dtMeses = New DataTable
        Const MES_INI As Int32 = 1
        Const MES_FIN As Int32 = 12
        dtMeses.Columns.Add("CCMPN", Type.GetType("System.String"))
        dtMeses.Columns.Add("CDVSN", Type.GetType("System.String"))
        dtMeses.Columns.Add("TCMPDV", Type.GetType("System.String"))
        dtMeses.Columns.Add("CINCID", Type.GetType("System.Int32")) 'TIPO INCIDENCIA
        dtMeses.Columns.Add("TINCSI", Type.GetType("System.String"))
        dtMeses.Columns.Add("MES_01", Type.GetType("System.Int32")).Caption = "ENE"
        dtMeses.Columns.Add("MES_02", Type.GetType("System.Int32")).Caption = "FEB"
        dtMeses.Columns.Add("MES_03", Type.GetType("System.Int32")).Caption = "MAR"
        dtMeses.Columns.Add("MES_04", Type.GetType("System.Int32")).Caption = "ABR"
        dtMeses.Columns.Add("MES_05", Type.GetType("System.Int32")).Caption = "MAY"
        dtMeses.Columns.Add("MES_06", Type.GetType("System.Int32")).Caption = "JUN"
        dtMeses.Columns.Add("MES_07", Type.GetType("System.Int32")).Caption = "JUL"
        dtMeses.Columns.Add("MES_08", Type.GetType("System.Int32")).Caption = "AGO"
        dtMeses.Columns.Add("MES_09", Type.GetType("System.Int32")).Caption = "SEP"
        dtMeses.Columns.Add("MES_10", Type.GetType("System.Int32")).Caption = "OCT"
        dtMeses.Columns.Add("MES_11", Type.GetType("System.Int32")).Caption = "NOV"
        dtMeses.Columns.Add("MES_12", Type.GetType("System.Int32")).Caption = "DIC"

        dtMeses.Columns.Add("INC_01", Type.GetType("System.String"))
        dtMeses.Columns.Add("INC_02", Type.GetType("System.String"))
        dtMeses.Columns.Add("INC_03", Type.GetType("System.String"))
        dtMeses.Columns.Add("INC_04", Type.GetType("System.String"))
        dtMeses.Columns.Add("INC_05", Type.GetType("System.String"))
        dtMeses.Columns.Add("INC_06", Type.GetType("System.String"))
        dtMeses.Columns.Add("INC_07", Type.GetType("System.String"))
        dtMeses.Columns.Add("INC_08", Type.GetType("System.String"))
        dtMeses.Columns.Add("INC_09", Type.GetType("System.String"))
        dtMeses.Columns.Add("INC_10", Type.GetType("System.String"))
        dtMeses.Columns.Add("INC_11", Type.GetType("System.String"))
        dtMeses.Columns.Add("INC_12", Type.GetType("System.String"))
        dtMeses.Columns.Add("TOTAL", Type.GetType("System.Int32"))
        dtMeses.Columns.Add("CODIGO", Type.GetType("System.String"))

        Dim ds As New DataSet
        dsMeses = oDatos.olistListarMaestroIncidencias_v2(obeSeguimiento)
        Dim dtResult As New DataTable
        Dim dsMaestInc As New DataTable
        dtResult = dsMeses.Tables(0).Copy
        dsMaestInc = dsMeses.Tables(1).Copy

        Dim drInc As DataRow
        Dim LisIncVisitado As New Hashtable
        Dim CodFila As String = ""
        For Fila_M As Integer = 0 To dsMaestInc.Rows.Count - 1
            drInc = dtMeses.NewRow
            drInc("CCMPN") = dsMaestInc.Rows(Fila_M)("CCMPN")
            drInc("CDVSN") = dsMaestInc.Rows(Fila_M)("CDVSN")
            drInc("TCMPDV") = dsMaestInc.Rows(Fila_M)("TCMPDV").ToString.Trim
            drInc("CINCID") = dsMaestInc.Rows(Fila_M)("CINCID")
            drInc("TINCSI") = dsMaestInc.Rows(Fila_M)("TINCSI")
            CodFila = drInc("CCMPN") & "_" & drInc("CDVSN") & "_" & drInc("CINCID")
            drInc("CODIGO") = CodFila
            drInc("TOTAL") = 0
            For FILA_MES As Integer = MES_INI To MES_FIN
                drInc("MES_" & FILA_MES.ToString.PadLeft(2, "0")) = 0
            Next
            LisIncVisitado.Add(CodFila, Fila_M)
            dtMeses.Rows.Add(drInc)
        Next

        Dim codigo As String = ""
        Dim CCMPN As String = ""
        Dim CDVSN As String = ""
        Dim CINCID As String = ""
        Dim oLisVisitado As New Hashtable
        Dim Fila As Int32 = 0
        Dim Columna_Mes As String = ""
        For Fila_Result As Integer = 0 To dtResult.Rows.Count - 1
            CCMPN = dtResult.Rows(Fila_Result)("CCMPN")
            CDVSN = dtResult.Rows(Fila_Result)("CDVSN")
            CINCID = dtResult.Rows(Fila_Result)("CINCID")
            Columna_Mes = dtResult.Rows(Fila_Result).Item("FRGTRO").ToString.Substring(4, 2)
            codigo = CCMPN & "_" & CDVSN & "_" & CINCID
            Fila = LisIncVisitado(codigo)
            dtMeses.Rows(Fila)("MES_" & Columna_Mes) = dtMeses.Rows(Fila)("MES_" & Columna_Mes) + 1
            dtMeses.Rows(Fila)("INC_" & Columna_Mes) = ("" & dtMeses.Rows(Fila)("INC_" & Columna_Mes)).ToString.Trim & "," & dtResult.Rows(Fila_Result)("NINCSI")
        Next

        Dim Total_Mes As Int32 = 0
        For Fila_Mes As Integer = 0 To dtMeses.Rows.Count - 1
            Total_Mes = 0
            For Col_Mes As Integer = MES_INI To MES_FIN
                Total_Mes = Total_Mes + dtMeses.Rows(Fila_Mes)("MES_" & Col_Mes.ToString.PadLeft(2, "0"))
            Next
            dtMeses.Rows(Fila_Mes)("TOTAL") = Total_Mes
        Next
        For Colum As Integer = MES_INI To MES_FIN
            dtMeses.Columns("MES_" & Colum.ToString.PadLeft(2, "0")).ColumnName = dtMeses.Columns("MES_" & Colum.ToString.PadLeft(2, "0")).Caption
        Next
        Return dtMeses

    End Function

    Public Function olistListarMaestroIncidenciasClientePerfil(ByVal obeSeguimiento As beSeguimiento) As DataSet

        Dim dsMeses As New DataSet
        dsMeses = oDatos.olistListarMaestroIncidenciasClientePerfil(obeSeguimiento)
        Return dsMeses

    End Function

    'Public Function olistListarMaestroIncidenciasCliente(ByVal obeIncidencias As beIncidencias) As DataSet

    '    Dim dtMeses As DataTable
    '    Dim dsMeses As New DataSet
    '    Dim dsMeses_Validado As New DataSet
    '    Dim Estado As String = ""
    '    Dim dr As DataRow
    '    Dim m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12 As Integer

    '    Dim codigo As String = ""
    '    Dim codigo1 As String = ""

    '    dtMeses = New DataTable

    '    dtMeses.Columns.Add("CCMPN", Type.GetType("System.String"))
    '    dtMeses.Columns.Add("CDVSN", Type.GetType("System.String"))
    '    dtMeses.Columns.Add("TCMPDV", Type.GetType("System.String"))
    '    dtMeses.Columns.Add("CCLNT", Type.GetType("System.Decimal"))
    '    dtMeses.Columns.Add("TCMPCL", Type.GetType("System.String"))
    '    dtMeses.Columns.Add("CINCID", Type.GetType("System.Int32"))
    '    dtMeses.Columns.Add("TINCSI", Type.GetType("System.String"))

    '    dtMeses.Columns.Add("ENE", Type.GetType("System.Int32"))
    '    dtMeses.Columns.Add("FEB", Type.GetType("System.Int32"))
    '    dtMeses.Columns.Add("MAR", Type.GetType("System.Int32"))
    '    dtMeses.Columns.Add("ABR", Type.GetType("System.Int32"))
    '    dtMeses.Columns.Add("MAY", Type.GetType("System.Int32"))
    '    dtMeses.Columns.Add("JUN", Type.GetType("System.Int32"))
    '    dtMeses.Columns.Add("JUL", Type.GetType("System.Int32"))
    '    dtMeses.Columns.Add("AGO", Type.GetType("System.Int32"))
    '    dtMeses.Columns.Add("SEP", Type.GetType("System.Int32"))
    '    dtMeses.Columns.Add("OCT", Type.GetType("System.Int32"))
    '    dtMeses.Columns.Add("NOV", Type.GetType("System.Int32"))
    '    dtMeses.Columns.Add("DIC", Type.GetType("System.Int32"))
    '    dtMeses.Columns.Add("TOTAL", Type.GetType("System.Int32"))

    '    dtMeses.Columns.Add("CODIGO", Type.GetType("System.String"))
    '    dtMeses.Columns.Add("INCIDENCIA", Type.GetType("System.String"))

    '    dsMeses_Validado.Tables.Add(dtMeses)

    '    dsMeses = oDatos.olistListarMaestroIncidenciasCliente(obeIncidencias)

    '    For j As Integer = 0 To dsMeses.Tables(0).Rows.Count - 1

    '        m1 = 0
    '        m2 = 0
    '        m3 = 0
    '        m4 = 0
    '        m5 = 0
    '        m6 = 0
    '        m7 = 0
    '        m8 = 0
    '        m9 = 0
    '        m10 = 0
    '        m11 = 0
    '        m12 = 0

    '        dr = dsMeses_Validado.Tables(0).NewRow
    '        codigo = ""

    '        dr("CCMPN") = dsMeses.Tables(0).Rows(j).Item("CCMPN")
    '        dr("CDVSN") = dsMeses.Tables(0).Rows(j).Item("CDVSN")

    '        codigo = String.Format("{0}{1}", codigo, dsMeses.Tables(0).Rows(j).Item("CDVSN").ToString.Trim)

    '        dr("TCMPDV") = dsMeses.Tables(0).Rows(j).Item("TCMPDV").Trim

    '        dr("CCLNT") = dsMeses.Tables(0).Rows(j).Item("CCLNT")
    '        dr("TCMPCL") = dsMeses.Tables(0).Rows(j).Item("TCMPCL").Trim

    '        dr("CINCID") = CInt(dsMeses.Tables(0).Rows(j).Item("CINCID"))
    '        codigo = String.Format("{0}{1}", codigo, dsMeses.Tables(0).Rows(j).Item("CINCID").ToString.Trim)

    '        dr("TINCSI") = dsMeses.Tables(0).Rows(j).Item("TINCSI").Trim

    '        If dsMeses_Validado.Tables(0).Rows.Count > 0 Then

    '            For k As Integer = 0 To dsMeses_Validado.Tables(0).Rows.Count - 1

    '                Estado = ""

    '                If dsMeses_Validado.Tables(0).Rows(k).Item("CODIGO").ToString.Trim = String.Format("{0}", codigo) Then

    '                    Select Case CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(4, 2))

    '                        Case 1
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("ENE") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("ENE")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            Estado = "A"
    '                            Exit For
    '                        Case 2
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("FEB") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("FEB")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            Estado = "A"
    '                            Exit For
    '                        Case 3
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("MAR") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("MAR")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            Estado = "A"
    '                            Exit For
    '                        Case 4
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("ABR") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("ABR")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            Estado = "A"
    '                            Exit For
    '                        Case 5
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("MAY") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("MAY")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            Estado = "A"
    '                            Exit For
    '                        Case 6
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("JUN") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("JUN")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            Estado = "A"
    '                            Exit For
    '                        Case 7
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("JUL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("JUL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            Estado = "A"
    '                            Exit For
    '                        Case 8
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("AGO") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("AGO")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            Estado = "A"
    '                            Exit For
    '                        Case 9
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("SEP") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("SEP")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            Estado = "A"
    '                            Exit For
    '                        Case 10
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("OCT") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("OCT")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            Estado = "A"
    '                            Exit For
    '                        Case 11
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("NOV") = Val(dsMeses_Validado.Tables(0).Rows(k).Item("NOV")) + Val(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            Estado = "A"
    '                            Exit For
    '                        Case 12
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("DIC") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("DIC")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                            Estado = "A"
    '                            Exit For
    '                        Case Else

    '                    End Select

    '                End If

    '                Estado = "I"

    '            Next

    '            If Estado <> "A" Then

    '                Select Case CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(4, 2))

    '                    Case 1
    '                        dr("ENE") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        m1 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        dr("FEB") = 0
    '                        m2 = 0
    '                        dr("MAR") = 0
    '                        m3 = 0
    '                        dr("ABR") = 0
    '                        m4 = 0
    '                        dr("MAY") = 0
    '                        m5 = 0
    '                        dr("JUN") = 0
    '                        m6 = 0
    '                        dr("JUL") = 0
    '                        m7 = 0
    '                        dr("AGO") = 0
    '                        m8 = 0
    '                        dr("SEP") = 0
    '                        m9 = 0
    '                        dr("OCT") = 0
    '                        m10 = 0
    '                        dr("NOV") = 0
    '                        m11 = 0
    '                        dr("DIC") = 0
    '                        m12 = 0
    '                    Case 2
    '                        dr("ENE") = 0
    '                        m1 = 0
    '                        dr("FEB") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        m2 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        dr("MAR") = 0
    '                        m3 = 0
    '                        dr("ABR") = 0
    '                        m4 = 0
    '                        dr("MAY") = 0
    '                        m5 = 0
    '                        dr("JUN") = 0
    '                        m6 = 0
    '                        dr("JUL") = 0
    '                        m7 = 0
    '                        dr("AGO") = 0
    '                        m8 = 0
    '                        dr("SEP") = 0
    '                        m9 = 0
    '                        dr("OCT") = 0
    '                        m10 = 0
    '                        dr("NOV") = 0
    '                        m11 = 0
    '                        dr("DIC") = 0
    '                        m12 = 0
    '                    Case 3
    '                        dr("ENE") = 0
    '                        m1 = 0
    '                        dr("FEB") = 0
    '                        m2 = 0
    '                        dr("MAR") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        m3 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        dr("ABR") = 0
    '                        m4 = 0
    '                        dr("MAY") = 0
    '                        m5 = 0
    '                        dr("JUN") = 0
    '                        m6 = 0
    '                        dr("JUL") = 0
    '                        m7 = 0
    '                        dr("AGO") = 0
    '                        m8 = 0
    '                        dr("SEP") = 0
    '                        m9 = 0
    '                        dr("OCT") = 0
    '                        m10 = 0
    '                        dr("NOV") = 0
    '                        m11 = 0
    '                        dr("DIC") = 0
    '                        m12 = 0
    '                    Case 4
    '                        dr("ENE") = 0
    '                        m1 = 0
    '                        dr("FEB") = 0
    '                        m2 = 0
    '                        dr("MAR") = 0
    '                        m3 = 0
    '                        dr("ABR") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        m4 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        dr("MAY") = 0
    '                        m5 = 0
    '                        dr("JUN") = 0
    '                        m6 = 0
    '                        dr("JUL") = 0
    '                        m7 = 0
    '                        dr("AGO") = 0
    '                        m8 = 0
    '                        dr("SEP") = 0
    '                        m9 = 0
    '                        dr("OCT") = 0
    '                        m10 = 0
    '                        dr("NOV") = 0
    '                        m11 = 0
    '                        dr("DIC") = 0
    '                        m12 = 0

    '                    Case 5
    '                        dr("ENE") = 0
    '                        m1 = 0
    '                        dr("FEB") = 0
    '                        m2 = 0
    '                        dr("MAR") = 0
    '                        m3 = 0
    '                        dr("ABR") = 0
    '                        m4 = 0
    '                        dr("MAY") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        m5 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        dr("JUN") = 0
    '                        m6 = 0
    '                        dr("JUL") = 0
    '                        m7 = 0
    '                        dr("AGO") = 0
    '                        m8 = 0
    '                        dr("SEP") = 0
    '                        m9 = 0
    '                        dr("OCT") = 0
    '                        m10 = 0
    '                        dr("NOV") = 0
    '                        m11 = 0
    '                        dr("DIC") = 0
    '                        m12 = 0
    '                    Case 6
    '                        dr("ENE") = 0
    '                        m1 = 0
    '                        dr("FEB") = 0
    '                        m2 = 0
    '                        dr("MAR") = 0
    '                        m3 = 0
    '                        dr("ABR") = 0
    '                        m4 = 0
    '                        dr("MAY") = 0
    '                        m5 = 0
    '                        dr("JUN") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        m6 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        dr("JUL") = 0
    '                        m7 = 0
    '                        dr("AGO") = 0
    '                        m8 = 0
    '                        dr("SEP") = 0
    '                        m9 = 0
    '                        dr("OCT") = 0
    '                        m10 = 0
    '                        dr("NOV") = 0
    '                        m11 = 0
    '                        dr("DIC") = 0
    '                        m12 = 0
    '                    Case 7
    '                        dr("ENE") = 0
    '                        m1 = 0
    '                        dr("FEB") = 0
    '                        m2 = 0
    '                        dr("MAR") = 0
    '                        m3 = 0
    '                        dr("ABR") = 0
    '                        m4 = 0
    '                        dr("MAY") = 0
    '                        m5 = 0
    '                        dr("JUN") = 0
    '                        m6 = 0
    '                        dr("JUL") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        m7 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        dr("AGO") = 0
    '                        m8 = 0
    '                        dr("SEP") = 0
    '                        m9 = 0
    '                        dr("OCT") = 0
    '                        m10 = 0
    '                        dr("NOV") = 0
    '                        m11 = 0
    '                        dr("DIC") = 0
    '                        m12 = 0
    '                    Case 8
    '                        dr("ENE") = 0
    '                        m1 = 0
    '                        dr("FEB") = 0
    '                        m2 = 0
    '                        dr("MAR") = 0
    '                        m3 = 0
    '                        dr("ABR") = 0
    '                        m4 = 0
    '                        dr("MAY") = 0
    '                        m5 = 0
    '                        dr("JUN") = 0
    '                        m6 = 0
    '                        dr("JUL") = 0
    '                        m7 = 0
    '                        dr("AGO") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        m8 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        dr("SEP") = 0
    '                        m9 = 0
    '                        dr("OCT") = 0
    '                        m10 = 0
    '                        dr("NOV") = 0
    '                        m11 = 0
    '                        dr("DIC") = 0
    '                        m12 = 0
    '                    Case 9
    '                        dr("ENE") = 0
    '                        m1 = 0
    '                        dr("FEB") = 0
    '                        m2 = 0
    '                        dr("MAR") = 0
    '                        m3 = 0
    '                        dr("ABR") = 0
    '                        m4 = 0
    '                        dr("MAY") = 0
    '                        m5 = 0
    '                        dr("JUN") = 0
    '                        m6 = 0
    '                        dr("JUL") = 0
    '                        m7 = 0
    '                        dr("AGO") = 0
    '                        m8 = 0
    '                        dr("SEP") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        m9 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        dr("OCT") = 0
    '                        m10 = 0
    '                        dr("NOV") = 0
    '                        m11 = 0
    '                        dr("DIC") = 0
    '                        m12 = 0
    '                    Case 10
    '                        dr("ENE") = 0
    '                        m1 = 0
    '                        dr("FEB") = 0
    '                        m2 = 0
    '                        dr("MAR") = 0
    '                        m3 = 0
    '                        dr("ABR") = 0
    '                        m4 = 0
    '                        dr("MAY") = 0
    '                        m5 = 0
    '                        dr("JUN") = 0
    '                        m6 = 0
    '                        dr("JUL") = 0
    '                        m7 = 0
    '                        dr("AGO") = 0
    '                        m8 = 0
    '                        dr("SEP") = 0
    '                        m9 = 0
    '                        dr("OCT") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        m10 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        dr("NOV") = 0
    '                        m11 = 0
    '                        dr("DIC") = 0
    '                        m12 = 0

    '                    Case 11
    '                        dr("ENE") = 0
    '                        m1 = 0
    '                        dr("FEB") = 0
    '                        m2 = 0
    '                        dr("MAR") = 0
    '                        m3 = 0
    '                        dr("ABR") = 0
    '                        m4 = 0
    '                        dr("MAY") = 0
    '                        m5 = 0
    '                        dr("JUN") = 0
    '                        m6 = 0
    '                        dr("JUL") = 0
    '                        m7 = 0
    '                        dr("AGO") = 0
    '                        m8 = 0
    '                        dr("SEP") = 0
    '                        m9 = 0
    '                        dr("OCT") = 0
    '                        m10 = 0
    '                        dr("NOV") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        m11 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        dr("DIC") = 0
    '                        m12 = 0
    '                    Case 12
    '                        dr("ENE") = 0
    '                        m1 = 0
    '                        dr("FEB") = 0
    '                        m2 = 0
    '                        dr("MAR") = 0
    '                        m3 = 0
    '                        dr("ABR") = 0
    '                        m4 = 0
    '                        dr("MAY") = 0
    '                        m5 = 0
    '                        dr("JUN") = 0
    '                        m6 = 0
    '                        dr("JUL") = 0
    '                        m7 = 0
    '                        dr("AGO") = 0
    '                        m8 = 0
    '                        dr("SEP") = 0
    '                        m9 = 0
    '                        dr("OCT") = 0
    '                        m10 = 0
    '                        dr("NOV") = 0
    '                        m11 = 0
    '                        dr("DIC") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                        m12 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))

    '                    Case Else

    '                End Select

    '                dr("TOTAL") = m1 + m2 + m3 + m4 + m5 + m6 + m7 + m8 + m9 + m10 + m11 + m12
    '                dr("CODIGO") = codigo
    '                dsMeses_Validado.Tables(0).Rows.Add(dr)

    '            End If

    '        Else

    '            Select Case CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(4, 2))
    '                Case 1
    '                    dr("ENE") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    m1 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    dr("FEB") = 0
    '                    m2 = 0
    '                    dr("MAR") = 0
    '                    m3 = 0
    '                    dr("ABR") = 0
    '                    m4 = 0
    '                    dr("MAY") = 0
    '                    m5 = 0
    '                    dr("JUN") = 0
    '                    m6 = 0
    '                    dr("JUL") = 0
    '                    m7 = 0
    '                    dr("AGO") = 0
    '                    m8 = 0
    '                    dr("SEP") = 0
    '                    m9 = 0
    '                    dr("OCT") = 0
    '                    m10 = 0
    '                    dr("NOV") = 0
    '                    m11 = 0
    '                    dr("DIC") = 0
    '                    m12 = 0
    '                Case 2
    '                    dr("ENE") = 0
    '                    m1 = 0
    '                    dr("FEB") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    m2 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    dr("MAR") = 0
    '                    m3 = 0
    '                    dr("ABR") = 0
    '                    m4 = 0
    '                    dr("MAY") = 0
    '                    m5 = 0
    '                    dr("JUN") = 0
    '                    m6 = 0
    '                    dr("JUL") = 0
    '                    m7 = 0
    '                    dr("AGO") = 0
    '                    m8 = 0
    '                    dr("SEP") = 0
    '                    m9 = 0
    '                    dr("OCT") = 0
    '                    m10 = 0
    '                    dr("NOV") = 0
    '                    m11 = 0
    '                    dr("DIC") = 0
    '                    m12 = 0
    '                Case 3
    '                    dr("ENE") = 0
    '                    m1 = 0
    '                    dr("FEB") = 0
    '                    m2 = 0
    '                    dr("MAR") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    m3 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    dr("ABR") = 0
    '                    m4 = 0
    '                    dr("MAY") = 0
    '                    m5 = 0
    '                    dr("JUN") = 0
    '                    m6 = 0
    '                    dr("JUL") = 0
    '                    m7 = 0
    '                    dr("AGO") = 0
    '                    m8 = 0
    '                    dr("SEP") = 0
    '                    m9 = 0
    '                    dr("OCT") = 0
    '                    m10 = 0
    '                    dr("NOV") = 0
    '                    m11 = 0
    '                    dr("DIC") = 0
    '                    m12 = 0
    '                Case 4
    '                    dr("ENE") = 0
    '                    m1 = 0
    '                    dr("FEB") = 0
    '                    m2 = 0
    '                    dr("MAR") = 0
    '                    m3 = 0
    '                    dr("ABR") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    m4 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    dr("MAY") = 0
    '                    m5 = 0
    '                    dr("JUN") = 0
    '                    m6 = 0
    '                    dr("JUL") = 0
    '                    m7 = 0
    '                    dr("AGO") = 0
    '                    m8 = 0
    '                    dr("SEP") = 0
    '                    m9 = 0
    '                    dr("OCT") = 0
    '                    m10 = 0
    '                    dr("NOV") = 0
    '                    m11 = 0
    '                    dr("DIC") = 0
    '                    m12 = 0
    '                Case 5
    '                    dr("ENE") = 0
    '                    m1 = 0
    '                    dr("FEB") = 0
    '                    m2 = 0
    '                    dr("MAR") = 0
    '                    m3 = 0
    '                    dr("ABR") = 0
    '                    m4 = 0
    '                    dr("MAY") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    m5 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    dr("JUN") = 0
    '                    m6 = 0
    '                    dr("JUL") = 0
    '                    m7 = 0
    '                    dr("AGO") = 0
    '                    m8 = 0
    '                    dr("SEP") = 0
    '                    m9 = 0
    '                    dr("OCT") = 0
    '                    m10 = 0
    '                    dr("NOV") = 0
    '                    m11 = 0
    '                    dr("DIC") = 0
    '                    m12 = 0
    '                Case 6
    '                    dr("ENE") = 0
    '                    m1 = 0
    '                    dr("FEB") = 0
    '                    m2 = 0
    '                    dr("MAR") = 0
    '                    m3 = 0
    '                    dr("ABR") = 0
    '                    m4 = 0
    '                    dr("MAY") = 0
    '                    m5 = 0
    '                    dr("JUN") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    m6 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    dr("JUL") = 0
    '                    m7 = 0
    '                    dr("AGO") = 0
    '                    m8 = 0
    '                    dr("SEP") = 0
    '                    m9 = 0
    '                    dr("OCT") = 0
    '                    m10 = 0
    '                    dr("NOV") = 0
    '                    m11 = 0
    '                    dr("DIC") = 0
    '                    m12 = 0
    '                Case 7
    '                    dr("ENE") = 0
    '                    m1 = 0
    '                    dr("FEB") = 0
    '                    m2 = 0
    '                    dr("MAR") = 0
    '                    m3 = 0
    '                    dr("ABR") = 0
    '                    m4 = 0
    '                    dr("MAY") = 0
    '                    m5 = 0
    '                    dr("JUN") = 0
    '                    m6 = 0
    '                    dr("JUL") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    m7 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    dr("AGO") = 0
    '                    m8 = 0
    '                    dr("SEP") = 0
    '                    m9 = 0
    '                    dr("OCT") = 0
    '                    m10 = 0
    '                    dr("NOV") = 0
    '                    m11 = 0
    '                    dr("DIC") = 0
    '                    m12 = 0
    '                Case 8
    '                    dr("ENE") = 0
    '                    m1 = 0
    '                    dr("FEB") = 0
    '                    m2 = 0
    '                    dr("MAR") = 0
    '                    m3 = 0
    '                    dr("ABR") = 0
    '                    m4 = 0
    '                    dr("MAY") = 0
    '                    m5 = 0
    '                    dr("JUN") = 0
    '                    m6 = 0
    '                    dr("JUL") = 0
    '                    m7 = 0
    '                    dr("AGO") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    m8 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    dr("SEP") = 0
    '                    m9 = 0
    '                    dr("OCT") = 0
    '                    m10 = 0
    '                    dr("NOV") = 0
    '                    m11 = 0
    '                    dr("DIC") = 0
    '                    m12 = 0
    '                Case 9
    '                    dr("ENE") = 0
    '                    m1 = 0
    '                    dr("FEB") = 0
    '                    m2 = 0
    '                    dr("MAR") = 0
    '                    m3 = 0
    '                    dr("ABR") = 0
    '                    m4 = 0
    '                    dr("MAY") = 0
    '                    m5 = 0
    '                    dr("JUN") = 0
    '                    m6 = 0
    '                    dr("JUL") = 0
    '                    m7 = 0
    '                    dr("AGO") = 0
    '                    m8 = 0
    '                    dr("SEP") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    m9 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    dr("OCT") = 0
    '                    m10 = 0
    '                    dr("NOV") = 0
    '                    m11 = 0
    '                    dr("DIC") = 0
    '                    m12 = 0
    '                Case 10
    '                    dr("ENE") = 0
    '                    m1 = 0
    '                    dr("FEB") = 0
    '                    m2 = 0
    '                    dr("MAR") = 0
    '                    m3 = 0
    '                    dr("ABR") = 0
    '                    m4 = 0
    '                    dr("MAY") = 0
    '                    m5 = 0
    '                    dr("JUN") = 0
    '                    m6 = 0
    '                    dr("JUL") = 0
    '                    m7 = 0
    '                    dr("AGO") = 0
    '                    m8 = 0
    '                    dr("SEP") = 0
    '                    m9 = 0
    '                    dr("OCT") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    m10 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    dr("NOV") = 0
    '                    m11 = 0
    '                    dr("DIC") = 0
    '                    m12 = 0
    '                Case 11
    '                    dr("ENE") = 0
    '                    m1 = 0
    '                    dr("FEB") = 0
    '                    m2 = 0
    '                    dr("MAR") = 0
    '                    m3 = 0
    '                    dr("ABR") = 0
    '                    m4 = 0
    '                    dr("MAY") = 0
    '                    m5 = 0
    '                    dr("JUN") = 0
    '                    m6 = 0
    '                    dr("JUL") = 0
    '                    m7 = 0
    '                    dr("AGO") = 0
    '                    m8 = 0
    '                    dr("SEP") = 0
    '                    m9 = 0
    '                    dr("OCT") = 0
    '                    m10 = 0
    '                    dr("NOV") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    m11 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    dr("DIC") = 0
    '                    m12 = 0
    '                Case 12
    '                    dr("ENE") = 0
    '                    m1 = 0
    '                    dr("FEB") = 0
    '                    m2 = 0
    '                    dr("MAR") = 0
    '                    m3 = 0
    '                    dr("ABR") = 0
    '                    m4 = 0
    '                    dr("MAY") = 0
    '                    m5 = 0
    '                    dr("JUN") = 0
    '                    m6 = 0
    '                    dr("JUL") = 0
    '                    m7 = 0
    '                    dr("AGO") = 0
    '                    m8 = 0
    '                    dr("SEP") = 0
    '                    m9 = 0
    '                    dr("OCT") = 0
    '                    m10 = 0
    '                    dr("NOV") = 0
    '                    m11 = 0
    '                    dr("DIC") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                    m12 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
    '                Case Else

    '            End Select
    '            dr("TOTAL") = m1 + m2 + m3 + m4 + m5 + m6 + m7 + m8 + m9 + m10 + m11 + m12
    '            dr("CODIGO") = codigo
    '            dsMeses_Validado.Tables(0).Rows.Add(dr)
    '        End If
    '    Next

    '    '   COMPLETANDO CON LAS INCIDENCIAS

    '    For i As Integer = 0 To dsMeses.Tables(1).Rows.Count - 1

    '        Dim cod As String = ""
    '        Dim x As Integer = 0
    '        cod = String.Format("{0}{1}", cod, dsMeses.Tables(1).Rows(i).Item("CDVSN").ToString.Trim)
    '        cod = String.Format("{0}{1}", cod, dsMeses.Tables(1).Rows(i).Item("CINCID").ToString.Trim)

    '        For a As Integer = 0 To dsMeses_Validado.Tables(0).Rows.Count - 1

    '            If dsMeses_Validado.Tables(0).Rows(a).Item("CODIGO").ToString.Trim = cod Then
    '                x = x + 1
    '                Exit For
    '            End If
    '        Next

    '        If x = 0 Then
    '            dr = dsMeses_Validado.Tables(0).NewRow
    '            codigo = ""
    '            dr("CCMPN") = dsMeses.Tables(1).Rows(i).Item("CCMPN")
    '            dr("CDVSN") = dsMeses.Tables(1).Rows(i).Item("CDVSN")
    '            dr("TCMPDV") = dsMeses.Tables(1).Rows(i).Item("TCMPDV").Trim
    '            dr("CCLNT") = dsMeses.Tables(1).Rows(i).Item("CCLNT")
    '            dr("TCMPCL") = dsMeses.Tables(1).Rows(i).Item("TCMPCL").Trim
    '            dr("CINCID") = CInt(dsMeses.Tables(1).Rows(i).Item("CINCID"))
    '            dr("TINCSI") = dsMeses.Tables(1).Rows(i).Item("TINCSI").Trim
    '            dr("ENE") = 0
    '            dr("FEB") = 0
    '            dr("MAR") = 0
    '            dr("ABR") = 0
    '            dr("MAY") = 0
    '            dr("JUN") = 0
    '            dr("JUL") = 0
    '            dr("AGO") = 0
    '            dr("SEP") = 0
    '            dr("OCT") = 0
    '            dr("NOV") = 0
    '            dr("DIC") = 0
    '            dr("TOTAL") = 0
    '            dr("CODIGO") = cod
    '            dsMeses_Validado.Tables(0).Rows.Add(dr)
    '        End If
    '    Next

    '    Return dsMeses_Validado

    'End Function

    Public Function olistListarMaestroIncidenciasCliente(ByVal obeSeguimiento As beSeguimiento) As DataTable

        Dim dtMeses As DataTable
        Dim dsMeses As New DataSet
        dtMeses = New DataTable

        Const MES_INI As Int32 = 1
        Const MES_FIN As Int32 = 12

        dtMeses.Columns.Add("CCMPN", Type.GetType("System.String"))
        dtMeses.Columns.Add("CDVSN", Type.GetType("System.String"))
        dtMeses.Columns.Add("TCMPDV", Type.GetType("System.String"))
        dtMeses.Columns.Add("CCLNT", Type.GetType("System.Decimal"))
        dtMeses.Columns.Add("TCMPCL", Type.GetType("System.String"))
        dtMeses.Columns.Add("CINCID", Type.GetType("System.Int32")) 'TIPO INCIDENCIA
        dtMeses.Columns.Add("TINCSI", Type.GetType("System.String"))

        dtMeses.Columns.Add("MES_01", Type.GetType("System.Int32")).Caption = "ENE"
        dtMeses.Columns.Add("MES_02", Type.GetType("System.Int32")).Caption = "FEB"
        dtMeses.Columns.Add("MES_03", Type.GetType("System.Int32")).Caption = "MAR"
        dtMeses.Columns.Add("MES_04", Type.GetType("System.Int32")).Caption = "ABR"
        dtMeses.Columns.Add("MES_05", Type.GetType("System.Int32")).Caption = "MAY"
        dtMeses.Columns.Add("MES_06", Type.GetType("System.Int32")).Caption = "JUN"
        dtMeses.Columns.Add("MES_07", Type.GetType("System.Int32")).Caption = "JUL"
        dtMeses.Columns.Add("MES_08", Type.GetType("System.Int32")).Caption = "AGO"
        dtMeses.Columns.Add("MES_09", Type.GetType("System.Int32")).Caption = "SEP"
        dtMeses.Columns.Add("MES_10", Type.GetType("System.Int32")).Caption = "OCT"
        dtMeses.Columns.Add("MES_11", Type.GetType("System.Int32")).Caption = "NOV"
        dtMeses.Columns.Add("MES_12", Type.GetType("System.Int32")).Caption = "DIC"

        dtMeses.Columns.Add("INC_01", Type.GetType("System.String"))
        dtMeses.Columns.Add("INC_02", Type.GetType("System.String"))
        dtMeses.Columns.Add("INC_03", Type.GetType("System.String"))
        dtMeses.Columns.Add("INC_04", Type.GetType("System.String"))
        dtMeses.Columns.Add("INC_05", Type.GetType("System.String"))
        dtMeses.Columns.Add("INC_06", Type.GetType("System.String"))
        dtMeses.Columns.Add("INC_07", Type.GetType("System.String"))
        dtMeses.Columns.Add("INC_08", Type.GetType("System.String"))
        dtMeses.Columns.Add("INC_09", Type.GetType("System.String"))
        dtMeses.Columns.Add("INC_10", Type.GetType("System.String"))
        dtMeses.Columns.Add("INC_11", Type.GetType("System.String"))
        dtMeses.Columns.Add("INC_12", Type.GetType("System.String"))

        dtMeses.Columns.Add("TOTAL", Type.GetType("System.Int32"))
        dtMeses.Columns.Add("CODIGO", Type.GetType("System.String"))

        Dim ds As New DataSet

        dsMeses = oDatos.olistListarMaestroIncidenciasCliente(obeSeguimiento)

        Dim dtResult As New DataTable
        Dim dsMaestInc As New DataTable

        dtResult = dsMeses.Tables(0).Copy
        dsMaestInc = dsMeses.Tables(1).Copy

        Dim drInc As DataRow
        Dim LisIncVisitado As New Hashtable
        Dim CodFila As String = ""

        For Fila_M As Integer = 0 To dsMaestInc.Rows.Count - 1
            drInc = dtMeses.NewRow
            drInc("CCMPN") = dsMaestInc.Rows(Fila_M)("CCMPN")
            drInc("CDVSN") = dsMaestInc.Rows(Fila_M)("CDVSN")
            drInc("TCMPDV") = dsMaestInc.Rows(Fila_M)("TCMPDV").ToString.Trim
            drInc("CCLNT") = dsMaestInc.Rows(Fila_M)("CCLNT")
            drInc("TCMPCL") = dsMaestInc.Rows(Fila_M)("TCMPCL").ToString.Trim
            drInc("CINCID") = dsMaestInc.Rows(Fila_M)("CINCID")
            drInc("TINCSI") = dsMaestInc.Rows(Fila_M)("TINCSI")
            CodFila = drInc("CCMPN") & "_" & drInc("CDVSN") & "_" & drInc("CINCID")
            drInc("CODIGO") = CodFila
            drInc("TOTAL") = 0
            For FILA_MES As Integer = MES_INI To MES_FIN
                drInc("MES_" & FILA_MES.ToString.PadLeft(2, "0")) = 0
            Next
            LisIncVisitado.Add(CodFila, Fila_M)
            dtMeses.Rows.Add(drInc)
        Next

        Dim codigo As String = ""
        Dim CCMPN As String = ""
        Dim CDVSN As String = ""
        Dim CCLNT As String = ""
        Dim CINCID As String = ""
        Dim oLisVisitado As New Hashtable
        Dim Fila As Int32 = 0
        Dim Columna_Mes As String = ""

        For Fila_Result As Integer = 0 To dtResult.Rows.Count - 1
            CCMPN = dtResult.Rows(Fila_Result)("CCMPN")
            CDVSN = dtResult.Rows(Fila_Result)("CDVSN")
            CINCID = dtResult.Rows(Fila_Result)("CINCID")
            Columna_Mes = dtResult.Rows(Fila_Result).Item("FRGTRO").ToString.Substring(4, 2)
            codigo = CCMPN & "_" & CDVSN & "_" & CINCID
            Fila = LisIncVisitado(codigo)
            dtMeses.Rows(Fila)("MES_" & Columna_Mes) = dtMeses.Rows(Fila)("MES_" & Columna_Mes) + 1
            dtMeses.Rows(Fila)("INC_" & Columna_Mes) = ("" & dtMeses.Rows(Fila)("INC_" & Columna_Mes)).ToString.Trim ' & "," & dtResult.Rows(Fila_Result)("NINCSI")
        Next

        Dim Total_Mes As Int32 = 0
        For Fila_Mes As Integer = 0 To dtMeses.Rows.Count - 1
            Total_Mes = 0
            For Col_Mes As Integer = MES_INI To MES_FIN
                Total_Mes = Total_Mes + dtMeses.Rows(Fila_Mes)("MES_" & Col_Mes.ToString.PadLeft(2, "0"))
            Next
            dtMeses.Rows(Fila_Mes)("TOTAL") = Total_Mes
        Next

        For Colum As Integer = MES_INI To MES_FIN
            dtMeses.Columns("MES_" & Colum.ToString.PadLeft(2, "0")).ColumnName = dtMeses.Columns("MES_" & Colum.ToString.PadLeft(2, "0")).Caption
        Next
        Return dtMeses

    End Function

    Public Function intInsertarRegistroIncidencias(ByVal obeSeguimiento As beSeguimiento) As Integer
        Return oDatos.intInsertarRegistroIncidencias(obeSeguimiento)
    End Function

    Public Sub InsertarIncidenciasCliente(ByVal obeSeguimiento As beSeguimiento)
        oDatos.intInsertarIncidenciasCliente(obeSeguimiento)
    End Sub

    Public Function intEliminarIncidenciasCliente(ByVal obeSeguimiento As beSeguimiento) As Integer
        Return oDatos.intEliminarIncidenciasCliente(obeSeguimiento)
    End Function

    Public Sub intActualizarRegistroIncidencias(ByVal obeSeguimiento As beSeguimiento)
        oDatos.intActualizarRegistroIncidencias(obeSeguimiento)
    End Sub

    Public Sub intActualizarSeguimiento_Revision(ByVal obeSeguimiento As beSeguimiento)
        oDatos.intActualizarSeguimiento_Revision(obeSeguimiento)
    End Sub

    Public Sub intActualizarSeguimiento_Concluido(ByVal obeSeguimiento As beSeguimiento)
        oDatos.intActualizarSeguimiento_Concluido(obeSeguimiento)
    End Sub

    Public Sub intGuardarImagenSeguimiento(ByVal NINCSI As Decimal, ByVal NMRGIA As Decimal, ByVal usuario As String, ByVal NTRMNL As String)
        oDatos.intGuardarImagenSeguimiento(NINCSI, NMRGIA, usuario, NTRMNL)
    End Sub

    Public Function ConsultaSeguimientoPorFecha(ByVal obeSeguimiento As beSeguimiento) As DataSet

        Dim dt_Incidencia_Estados As New DataTable
        Dim dtResultado As New DataTable
        Dim dtMaestroSeguimiento As New DataTable
        Dim drSeg As DataRow

        Dim LisSegVisitado As New Hashtable
        Dim CodFila As String = ""

        dt_Incidencia_Estados.Columns.Add("CARINC", Type.GetType("System.String"))
        dt_Incidencia_Estados.Columns.Add("TDARINC", Type.GetType("System.String"))
        dt_Incidencia_Estados.Columns.Add("CINCID", Type.GetType("System.Int32"))
        dt_Incidencia_Estados.Columns.Add("TINCDT", Type.GetType("System.String"))

        dt_Incidencia_Estados.Columns.Add("REPORTADO", Type.GetType("System.Int32"))
        dt_Incidencia_Estados.Columns.Add("REVISADO", Type.GetType("System.Int32"))
        dt_Incidencia_Estados.Columns.Add("CONCLUIDO", Type.GetType("System.Int32"))
        dt_Incidencia_Estados.Columns.Add("CODIGO", Type.GetType("System.String"))
        dt_Incidencia_Estados.Columns.Add("TOTAL", Type.GetType("System.Int32"))

        dtResultado = oDatos.ConsultaSeguimientoPorFecha(obeSeguimiento).Tables(0).Copy

        If dtResultado.Rows.Count > 0 Then

            dtMaestroSeguimiento = dtResultado.Copy

            For Fila_M As Integer = 0 To dtMaestroSeguimiento.Rows.Count - 1

                CodFila = dtMaestroSeguimiento.Rows(Fila_M)("CARINC") & "_" & dtMaestroSeguimiento.Rows(Fila_M)("CINCID")
                If Not LisSegVisitado.Contains(CodFila) Then
                    drSeg = dt_Incidencia_Estados.NewRow
                    drSeg("CARINC") = dtMaestroSeguimiento.Rows(Fila_M)("CARINC").ToString.Trim
                    drSeg("TDARINC") = dtMaestroSeguimiento.Rows(Fila_M)("TDARINC").ToString.Trim
                    drSeg("CINCID") = dtMaestroSeguimiento.Rows(Fila_M)("CINCID")
                    drSeg("TINCDT") = dtMaestroSeguimiento.Rows(Fila_M)("TINCSI").ToString.Trim

                    drSeg("REPORTADO") = 0
                    drSeg("REVISADO") = 0
                    drSeg("CONCLUIDO") = 0
                    drSeg("CODIGO") = CodFila
                    drSeg("TOTAL") = 0
                    dt_Incidencia_Estados.Rows.Add(drSeg)
                    LisSegVisitado.Add(CodFila, dt_Incidencia_Estados.Rows.Count - 1)

                End If


            Next

            Dim codigo As String = ""
            Dim CARINC As String = ""
            Dim CINCID As String = ""
            Dim oLisVisitado As New Hashtable
            Dim Fila As Int32 = 0
            Dim Columna_Mes As String = ""
            For Fila_Result As Integer = 0 To dtResultado.Rows.Count - 1
                CARINC = dtResultado.Rows(Fila_Result)("CARINC")
                CINCID = dtResultado.Rows(Fila_Result)("CINCID")

                codigo = CARINC & "_" & CINCID
                Fila = LisSegVisitado(codigo)

                Select Case dtResultado.Rows(Fila_Result)("SESINC")

                    Case "P"
                        dt_Incidencia_Estados.Rows(Fila)("REPORTADO") = dt_Incidencia_Estados.Rows(Fila)("REPORTADO") + 1
                    Case "R"
                        dt_Incidencia_Estados.Rows(Fila)("REVISADO") = dt_Incidencia_Estados.Rows(Fila)("REVISADO") + 1
                    Case "C"
                        dt_Incidencia_Estados.Rows(Fila)("CONCLUIDO") = dt_Incidencia_Estados.Rows(Fila)("CONCLUIDO") + 1
                End Select
                dt_Incidencia_Estados.Rows(Fila)("TOTAL") = dt_Incidencia_Estados.Rows(Fila)("REPORTADO") + dt_Incidencia_Estados.Rows(Fila)("REVISADO") + dt_Incidencia_Estados.Rows(Fila)("CONCLUIDO")

            Next

            Dim TOTAL_REPORTADO As Int32 = 0
            Dim TOTAL_REVISADO As Int32 = 0
            Dim TOTAL_CONCLUIDO As Int32 = 0

            TOTAL_REPORTADO = dt_Incidencia_Estados.Compute("SUM(REPORTADO)", "")
            TOTAL_REVISADO = dt_Incidencia_Estados.Compute("SUM(REVISADO)", "")
            TOTAL_CONCLUIDO = dt_Incidencia_Estados.Compute("SUM(CONCLUIDO)", "")

            Dim dt_Total_Estados As New DataTable
            Dim dr As DataRow

            dt_Total_Estados.Columns.Add("ESTADO", Type.GetType("System.String"))
            dt_Total_Estados.Columns.Add("TOTAL", Type.GetType("System.Int32"))

            dr = dt_Total_Estados.NewRow
            dr("ESTADO") = "01-REPORTADO"
            dr("TOTAL") = TOTAL_REPORTADO
            dt_Total_Estados.Rows.Add(dr)
            dr = dt_Total_Estados.NewRow
            dr("ESTADO") = "02-REVISADO"
            dr("TOTAL") = TOTAL_REVISADO
            dt_Total_Estados.Rows.Add(dr)
            dr = dt_Total_Estados.NewRow
            dr("ESTADO") = "03-CONCLUIDO"
            dr("TOTAL") = TOTAL_CONCLUIDO
            dt_Total_Estados.Rows.Add(dr)


            Dim dsGeneral As New DataSet
            dsGeneral.Tables.Add(dtResultado.Copy)
            dsGeneral.Tables.Add(dt_Incidencia_Estados.Copy)
            dsGeneral.Tables.Add(dt_Total_Estados.Copy)

            Return dsGeneral

        Else
            Dim dsGeneral As New DataSet
            Dim dtTabla As New DataTable
            dsGeneral.Tables.Add(dtTabla)
            Return dsGeneral

        End If

    End Function

    Public Sub intEliminarImagenSeguimiento(ByVal NINCSI As Decimal, ByVal NMRGIA As Decimal, ByVal usuario As String, ByVal NTRMNL As String)
        oDatos.intEliminarImagenSeguimiento(NINCSI, NMRGIA, usuario, NTRMNL)
    End Sub


    Public Sub intEliminarRegistroIncidencias(ByVal obeSeguimiento As beSeguimiento)
        oDatos.intEliminarRegistroIncidencias(obeSeguimiento)
    End Sub

    Public Function ConsultaIncidenciaPorFecha(ByVal obeSeguimiento As beSeguimiento) As DataSet
        Return oDatos.ConsultaIncidenciaPorFecha(obeSeguimiento)
    End Function

    Function Anio_Semanal(ByVal anio As Int32) As DataTable

        Dim dt As New DataTable
        Dim dr As DataRow
        dt.Columns.Add("MES")
        dt.Columns.Add("SEMANA")
        dt.Columns.Add("FECHA", Type.GetType("System.Decimal"))
        dt.Columns.Add("NRO")
        Dim dia_fin As Int32 = 0
        Dim num_sem As Int32 = 0
        Dim fecha As Date
        Dim sem As Int32 = 0
        Dim sem_ant As Int32 = 0
        Dim ultimo_dia As Int32 = 0

        For mes As Integer = 1 To 12
            ultimo_dia = Date.DaysInMonth(anio, 12)
            dr = dt.NewRow
            dia_fin = Date.DaysInMonth(anio, mes)

            For dia As Integer = 1 To dia_fin
                sem_ant = 1
                fecha = CDate(String.Format("{0}/{1}/{2}", dia.ToString.PadLeft(2, "0"), mes.ToString.PadLeft(2, "0"), anio))
                sem = DatePart(DateInterval.WeekOfYear, fecha)
                If sem > 1 Then
                    If dia = 1 Then
                        fecha = CDate(String.Format("{0}/{1}/{2}", Date.DaysInMonth(anio, mes - 1), (mes - 1).ToString.PadLeft(2, "0"), anio))
                        sem_ant = DatePart(DateInterval.WeekOfYear, fecha)
                    Else
                        fecha = CDate(String.Format("{0}/{1}/{2}", (dia - 1).ToString.PadLeft(2, "0"), mes.ToString.PadLeft(2, "0"), anio))
                        sem_ant = DatePart(DateInterval.WeekOfYear, fecha)
                    End If
                End If
                If dia = 1 And mes = 1 Then
                    dr = dt.NewRow
                    dr("MES") = String.Format("{0}", mes.ToString.PadLeft(2, "0"))
                    dr("SEMANA") = String.Format("{0}", sem.ToString.PadLeft(2, "0"))
                    dr("FECHA") = CDec(String.Format("{0}{1}01", anio, mes.ToString.PadLeft(2, "0")))
                    dr("NRO") = ""
                    dt.Rows.Add(dr)
                Else
                    If sem <> sem_ant Then
                        dr = dt.NewRow
                        dr("MES") = String.Format("{0}", mes.ToString.PadLeft(2, "0"))
                        dr("SEMANA") = String.Format("{0}", sem_ant.ToString.PadLeft(2, "0"))
                        dr("FECHA") = CDec(String.Format("{0}{1}{2}", anio, mes.ToString.PadLeft(2, "0"), (dia - 1).ToString.PadLeft(2, "0")))
                        dr("NRO") = ""
                        dt.Rows.Add(dr)


                        dr = dt.NewRow
                        dr("MES") = String.Format("{0}", mes.ToString.PadLeft(2, "0"))
                        dr("SEMANA") = String.Format("{0}", sem.ToString.PadLeft(2, "0"))
                        dr("FECHA") = CDec(String.Format("{0}{1}{2}", anio, mes.ToString.PadLeft(2, "0"), dia.ToString.PadLeft(2, "0")))
                        dr("NRO") = ""
                        dt.Rows.Add(dr)
                    End If
                End If
                If mes = 12 And ultimo_dia = dia Then
                    dr = dt.NewRow
                    dr("MES") = String.Format("{0}", mes.ToString.PadLeft(2, "0"))
                    dr("SEMANA") = String.Format("{0}", sem)
                    dr("FECHA") = CDec(String.Format("{0}{1}{2}", anio, mes.ToString.PadLeft(2, "0"), ultimo_dia.ToString.PadLeft(2, "0")))
                    dr("NRO") = ""
                    dt.Rows.Add(dr)
                End If
            Next
        Next

        Dim dtFinal As New DataTable
        Dim dr1 As DataRow
        dtFinal.Columns.Add("SEM")
        dtFinal.Columns.Add("NRO")
        Dim cont As Int32 = 0

        Dim num_semanas As Int32 = 0
        For mes As Integer = 1 To 12
            num_semanas = Nro_Semanas_X_Mes(anio, mes)
            For i As Integer = 1 To num_semanas
                dr1 = dtFinal.NewRow
                cont = cont + 1
                dr1("SEM") = i
                dr1("NRO") = cont
                dtFinal.Rows.Add(dr1)
                dr1 = dtFinal.NewRow
                dr1("SEM") = i
                dr1("NRO") = cont
                dtFinal.Rows.Add(dr1)

            Next
        Next

        For j As Integer = 0 To dt.Rows.Count - 1
            For k As Integer = 0 To dtFinal.Rows.Count - 1
                If j = k Then
                    dt.Rows(j)("SEMANA") = dtFinal.Rows(k)("SEM").ToString.PadLeft(2, "0")
                    dt.Rows(j)("NRO") = dtFinal.Rows(k)("NRO").ToString
                End If
            Next
        Next

        Return dt

    End Function

    Public Function ConsultaIncidenciaPorMes(ByVal obeSeguimiento As beSeguimiento, ByVal Lista As List(Of String)) As DataSet

        Dim dtMeses As DataTable
        Dim dsMeses As New DataSet
        Dim dsMeses_Validado As New DataSet
        Dim Estado As String = ""
        Dim dr As DataRow
        Dim s1, s2, s3, s4, s5 As Integer
        Dim codigo As String = ""
        Dim codigo1 As String = ""
        Dim mes As Integer = 0
        Dim dia As Integer = 0
        Dim Num_Semana As Integer = 0
        Dim Num_Semana_Data As Integer = 0
        Dim Fecha As String = ""
        Dim control As Integer = 0
        Dim valida As String = ""

        dtMeses = New DataTable
        dtMeses.Columns.Add("TCMPCL", Type.GetType("System.String"))
        dtMeses.Columns.Add("TCMPDV", Type.GetType("System.String"))
        dtMeses.Columns.Add("IDMES", Type.GetType("System.Int32"))
        dtMeses.Columns.Add("MES", Type.GetType("System.String"))
        dtMeses.Columns.Add("CINCID", Type.GetType("System.Int32"))
        dtMeses.Columns.Add("TINCSI", Type.GetType("System.String"))
        For index As Integer = 1 To 5
            dtMeses.Columns.Add(String.Format("SEMANA-0{0}", index), Type.GetType("System.Int32"))
        Next
        dtMeses.Columns.Add("TOTAL", Type.GetType("System.Int32"))
        dtMeses.Columns.Add("CODIGO", Type.GetType("System.String"))
        dtMeses.Columns.Add("SEMANAS", Type.GetType("System.Int32"))
        dtMeses.TableName = "MESES"
        dsMeses_Validado.Tables.Add(dtMeses)

        dsMeses = oDatos.ConsultaIncidenciaPorMes(obeSeguimiento)

        If dsMeses.Tables(0).Rows.Count > 0 Then
            Dim anio As Integer = CInt(dsMeses.Tables(0).Rows(0).Item("FRGTRO").ToString.Substring(6, 4))

            For j As Integer = 0 To dsMeses.Tables(0).Rows.Count - 1
                mes = 0
                dia = 0
                Fecha = ""
                Estado = ""
                Num_Semana = 0
                Num_Semana_Data = 0

                dr = dsMeses_Validado.Tables("MESES").NewRow
                codigo = ""

                dr("TCMPCL") = dsMeses.Tables(0).Rows(j).Item("TCMPCL").ToString.Trim
                dr("TCMPDV") = dsMeses.Tables(0).Rows(j).Item("TCMPDV").ToString.Trim
                codigo = String.Format("{0}{1}", codigo, dsMeses.Tables(0).Rows(j).Item("CARINC").ToString.Trim)
                dr("IDMES") = CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(3, 2))
                codigo = String.Format("{0}{1}", codigo, MonthName(CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(3, 2)).ToString.Trim))
                If dr("IDMES") < 10 Then
                    dr("MES") = String.Format("0{0}-{1}", dr("IDMES"), MonthName(CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(3, 2))).ToUpper)
                Else
                    dr("MES") = String.Format("{0}-{1}", dr("IDMES"), MonthName(CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(3, 2))).ToUpper)
                End If
                dr("CINCID") = dsMeses.Tables(0).Rows(j).Item("CINCID")
                codigo = String.Format("{0}{1}", codigo, dsMeses.Tables(0).Rows(j).Item("CINCID").ToString.Trim)
                dr("TINCSI") = dsMeses.Tables(0).Rows(j).Item("TINCSI")

                If dsMeses_Validado.Tables(0).Rows.Count > 0 Then

                    For k As Integer = 0 To dsMeses_Validado.Tables(0).Rows.Count - 1
                        s1 = 0
                        s2 = 0
                        s3 = 0
                        s4 = 0
                        s5 = 0
                        Estado = ""
                        If dsMeses_Validado.Tables(0).Rows(k).Item("CODIGO").ToString.Trim = String.Format("{0}", codigo) Then

                            mes = CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(3, 2))
                            dia = CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(0, 2))
                            Fecha = String.Format("{0}/{1}/{2}", dia, mes, anio)
                            Num_Semana = DatePart(DateInterval.WeekOfYear, CDate(Fecha))
                            Dim ultimo_dia As Integer = 0
                            If mes > 1 Then
                                If mes = 12 Then
                                    ultimo_dia = Date.DaysInMonth(anio, mes - 1)
                                    control = 0
                                    control = DatePart(DateInterval.WeekOfYear, CDate(String.Format("{0}/{1}/{2}", ultimo_dia, mes - 1, anio)))
                                    Num_Semana = Num_Semana - control
                                Else
                                    ultimo_dia = Date.DaysInMonth(anio, mes - 1)
                                    control = 0
                                    control = DatePart(DateInterval.WeekOfYear, CDate(String.Format("{0}/{1}/{2}", ultimo_dia, mes - 1, anio)))
                                    Num_Semana = Num_Semana - control
                                End If
                            End If

                            Select Case Num_Semana

                                Case 1
                                    dsMeses_Validado.Tables(0).Rows(k).Item("SEMANA-01") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("SEMANA-01")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                    dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                    Estado = "A"
                                    Exit For
                                Case 2
                                    dsMeses_Validado.Tables(0).Rows(k).Item("SEMANA-02") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("SEMANA-02")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                    dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                    Estado = "A"
                                    Exit For
                                Case 3
                                    dsMeses_Validado.Tables(0).Rows(k).Item("SEMANA-03") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("SEMANA-03")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                    dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                    Estado = "A"
                                    Exit For
                                Case 4
                                    dsMeses_Validado.Tables(0).Rows(k).Item("SEMANA-04") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("SEMANA-04")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                    dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                    Estado = "A"
                                    Exit For
                                Case 5
                                    dsMeses_Validado.Tables(0).Rows(k).Item("SEMANA-05") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("SEMANA-05")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                    dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                    Estado = "A"
                                    Exit For

                                Case Else

                                    codigo = ""
                                    codigo = String.Format("{0}{1}", codigo, dsMeses.Tables(0).Rows(j).Item("CARINC").ToString.Trim)
                                    codigo = String.Format("{0}{1}", codigo, MonthName(CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(3, 2) - 1).ToString.Trim))
                                    codigo = String.Format("{0}{1}", codigo, dsMeses.Tables(0).Rows(j).Item("CINCID").ToString.Trim)

                                    dr("IDMES") = CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(3, 2)) - 1

                                    If dr("IDMES") < 10 Then
                                        dr("MES") = String.Format("0{0}-{1}", dr("IDMES"), MonthName(CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(3, 2)) - 1).ToUpper)
                                    Else
                                        dr("MES") = String.Format("{0}-{1}", dr("IDMES"), MonthName(CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(3, 2)) - 1).ToUpper)
                                    End If

                                    control = Nro_Semanas_X_Mes(anio, mes - 1)

                                    For p As Integer = 0 To dsMeses_Validado.Tables(0).Rows.Count - 1
                                        Estado = ""
                                        If dsMeses_Validado.Tables(0).Rows(p).Item("CODIGO").ToString.Trim = String.Format("{0}", codigo) Then

                                            Select Case control
                                                Case 4
                                                    dsMeses_Validado.Tables(0).Rows(p).Item("SEMANA-04") = CInt(dsMeses_Validado.Tables(0).Rows(p).Item("SEMANA-04")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                                    dsMeses_Validado.Tables(0).Rows(p).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(p).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                                    Estado = "A"
                                                    Exit For
                                                Case 5
                                                    dsMeses_Validado.Tables(0).Rows(p).Item("SEMANA-05") = CInt(dsMeses_Validado.Tables(0).Rows(p).Item("SEMANA-05")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                                    dsMeses_Validado.Tables(0).Rows(p).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(p).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                                    Estado = "A"
                                                    Exit For
                                                Case Else
                                            End Select
                                            Estado = "I"
                                        End If
                                    Next

                                    If Estado <> "A" Then
                                        Select Case control

                                            Case 4
                                                dr("SEMANA-04") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                                s4 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                                dr("SEMANA-01") = 0
                                                dr("SEMANA-03") = 0
                                                dr("SEMANA-02") = 0
                                                dr("SEMANA-05") = 0

                                            Case 5
                                                dr("SEMANA-05") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                                s5 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                                dr("SEMANA-01") = 0
                                                dr("SEMANA-03") = 0
                                                dr("SEMANA-02") = 0
                                                dr("SEMANA-04") = 0

                                            Case Else
                                        End Select

                                        dr("TOTAL") = s4 + s5
                                        dr("CODIGO") = codigo
                                        mes = 0
                                        mes = CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(3, 2) - 1)
                                        dr("SEMANAS") = Nro_Semanas_X_Mes(anio, mes)
                                        dsMeses_Validado.Tables(0).Rows.Add(dr)
                                        Estado = "A"
                                        Exit For

                                    End If

                                    If Estado = "A" Then
                                        Exit For
                                    End If

                            End Select
                        End If

                        Estado = "I"
                    Next

                    If Estado <> "A" Then
                        'Estado = ""
                        Dim ultimo_dia As Integer
                        mes = CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(3, 2))
                        dia = CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(0, 2))
                        Fecha = String.Format("{0}/{1}/{2}", dia, mes, anio)
                        Num_Semana = 0
                        Num_Semana = DatePart(DateInterval.WeekOfYear, CDate(Fecha))
                        ultimo_dia = 0
                        If mes > 1 Then
                            If mes = 12 Then
                                ultimo_dia = Date.DaysInMonth(anio, mes - 1)
                                control = 0
                                control = DatePart(DateInterval.WeekOfYear, CDate(String.Format("{0}/{1}/{2}", ultimo_dia, mes - 1, anio)))
                                Num_Semana = Num_Semana - control
                            Else
                                ultimo_dia = Date.DaysInMonth(anio, mes - 1)
                                control = 0
                                control = DatePart(DateInterval.WeekOfYear, CDate(String.Format("{0}/{1}/{2}", ultimo_dia, mes - 1, anio)))
                                Num_Semana = Num_Semana - control

                            End If
                        End If

                        Select Case Num_Semana

                            Case 1
                                dr("SEMANA-01") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                s1 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                dr("SEMANA-02") = 0
                                dr("SEMANA-03") = 0
                                dr("SEMANA-04") = 0
                                dr("SEMANA-05") = 0
                                'Estado = "I"


                            Case 2
                                dr("SEMANA-02") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                s2 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                dr("SEMANA-01") = 0
                                dr("SEMANA-03") = 0
                                dr("SEMANA-04") = 0
                                dr("SEMANA-05") = 0
                                'Estado = "I"

                            Case 3
                                dr("SEMANA-03") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                s3 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                dr("SEMANA-01") = 0
                                dr("SEMANA-02") = 0
                                dr("SEMANA-04") = 0
                                dr("SEMANA-05") = 0
                                'Estado = "I"

                            Case 4
                                dr("SEMANA-04") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                s4 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                dr("SEMANA-01") = 0
                                dr("SEMANA-03") = 0
                                dr("SEMANA-02") = 0
                                dr("SEMANA-05") = 0
                                'Estado = "I"

                            Case 5
                                dr("SEMANA-05") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                s4 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                dr("SEMANA-01") = 0
                                dr("SEMANA-03") = 0
                                dr("SEMANA-02") = 0
                                dr("SEMANA-04") = 0
                                'Estado = "I"

                            Case Else

                                codigo = ""
                                codigo = String.Format("{0}{1}", codigo, dsMeses.Tables(0).Rows(j).Item("CARINC").ToString.Trim)
                                codigo = String.Format("{0}{1}", codigo, MonthName(CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(3, 2) - 1).ToString.Trim))
                                codigo = String.Format("{0}{1}", codigo, dsMeses.Tables(0).Rows(j).Item("CINCID").ToString.Trim)

                                'Estado = ""

                                dr("IDMES") = CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(3, 2)) - 1

                                If dr("IDMES") < 10 Then
                                    dr("MES") = String.Format("0{0}-{1}", dr("IDMES"), MonthName(CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(3, 2)) - 1).ToUpper)
                                Else
                                    dr("MES") = String.Format("{0}-{1}", dr("IDMES"), MonthName(CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(3, 2)) - 1).ToUpper)
                                End If

                                control = Nro_Semanas_X_Mes(anio, mes - 1)


                                For r As Integer = 0 To dsMeses_Validado.Tables(0).Rows.Count - 1
                                    Estado = ""
                                    If dsMeses_Validado.Tables(0).Rows(r).Item("CODIGO").ToString.Trim = String.Format("{0}", codigo) Then

                                        Select Case control
                                            Case 4
                                                dsMeses_Validado.Tables(0).Rows(r).Item("SEMANA-04") = CInt(dsMeses_Validado.Tables(0).Rows(r).Item("SEMANA-04")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                                dsMeses_Validado.Tables(0).Rows(r).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(r).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                                Estado = "A"
                                                Exit For
                                            Case 5
                                                dsMeses_Validado.Tables(0).Rows(r).Item("SEMANA-05") = CInt(dsMeses_Validado.Tables(0).Rows(r).Item("SEMANA-05")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                                dsMeses_Validado.Tables(0).Rows(r).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(r).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                                Estado = "A"
                                                Exit For
                                            Case Else
                                        End Select
                                        Estado = "I"
                                    End If
                                Next
                                If Estado <> "A" Then
                                    Select Case control

                                        Case 4
                                            dr("SEMANA-04") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                            s4 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                            dr("SEMANA-01") = 0
                                            dr("SEMANA-03") = 0
                                            dr("SEMANA-02") = 0
                                            dr("SEMANA-05") = 0

                                        Case 5
                                            dr("SEMANA-05") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                            s5 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                            dr("SEMANA-01") = 0
                                            dr("SEMANA-03") = 0
                                            dr("SEMANA-02") = 0
                                            dr("SEMANA-04") = 0

                                        Case Else
                                    End Select

                                    dr("TOTAL") = s4 + s5
                                    dr("CODIGO") = codigo
                                    mes = 0
                                    mes = CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(3, 2) - 1)
                                    dr("SEMANAS") = Nro_Semanas_X_Mes(anio, mes)
                                    dsMeses_Validado.Tables(0).Rows.Add(dr)
                                    Estado = ""
                                    Estado = "A"

                                End If

                        End Select

                    End If


                    If Estado <> "A" Then
                        dr("TOTAL") = s1 + s2 + s3 + s4 + s5
                        dr("CODIGO") = codigo
                        mes = 0
                        mes = CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(3, 2))
                        dr("SEMANAS") = Nro_Semanas_X_Mes(anio, mes)
                        dsMeses_Validado.Tables(0).Rows.Add(dr)
                    End If


                Else
                    Dim ultimo_dia As Integer
                    mes = CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(3, 2))
                    dia = CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(0, 2))
                    Fecha = String.Format("{0}/{1}/{2}", dia, mes, anio)
                    Num_Semana = DatePart(DateInterval.WeekOfYear, CDate(Fecha))
                    ultimo_dia = 0
                    If mes > 1 Then
                        If mes = 12 Then
                            ultimo_dia = Date.DaysInMonth(anio, mes - 1)
                            control = 0
                            control = DatePart(DateInterval.WeekOfYear, CDate(String.Format("{0}/{1}/{2}", ultimo_dia, mes - 1, anio)))
                            Num_Semana = Num_Semana - control
                        Else
                            ultimo_dia = Date.DaysInMonth(anio, mes - 1)
                            control = 0
                            control = DatePart(DateInterval.WeekOfYear, CDate(String.Format("{0}/{1}/{2}", ultimo_dia, mes - 1, anio)))
                            Num_Semana = Num_Semana - control
                        End If
                    End If

                    Select Case Num_Semana

                        Case 1
                            dr("SEMANA-01") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                            s1 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                            dr("SEMANA-02") = 0
                            dr("SEMANA-03") = 0
                            dr("SEMANA-04") = 0
                            dr("SEMANA-05") = 0

                        Case 2
                            dr("SEMANA-02") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                            s2 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                            dr("SEMANA-01") = 0
                            dr("SEMANA-03") = 0
                            dr("SEMANA-04") = 0
                            dr("SEMANA-05") = 0

                        Case 3
                            dr("SEMANA-03") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                            s3 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                            dr("SEMANA-01") = 0
                            dr("SEMANA-02") = 0
                            dr("SEMANA-04") = 0
                            dr("SEMANA-05") = 0

                        Case 4
                            dr("SEMANA-04") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                            s4 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                            dr("SEMANA-01") = 0
                            dr("SEMANA-03") = 0
                            dr("SEMANA-02") = 0
                            dr("SEMANA-05") = 0

                        Case 5
                            dr("SEMANA-05") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                            s4 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                            dr("SEMANA-01") = 0
                            dr("SEMANA-03") = 0
                            dr("SEMANA-02") = 0
                            dr("SEMANA-04") = 0

                        Case Else

                            codigo = ""
                            codigo = String.Format("{0}{1}", codigo, dsMeses.Tables(0).Rows(j).Item("CARINC").ToString.Trim)
                            codigo = String.Format("{0}{1}", codigo, MonthName(CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(3, 2)) - 1).ToString.Trim)
                            codigo = String.Format("{0}{1}", codigo, dsMeses.Tables(0).Rows(j).Item("CINCID").ToString.Trim)

                            Estado = ""

                            dr("IDMES") = CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(3, 2)) - 1

                            If dr("IDMES") < 10 Then
                                dr("MES") = String.Format("0{0}-{1}", dr("IDMES"), MonthName(CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(3, 2)) - 1).ToUpper)
                            Else
                                dr("MES") = String.Format("{0}-{1}", dr("IDMES"), MonthName(CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(3, 2)) - 1).ToUpper)
                            End If

                            control = Nro_Semanas_X_Mes(anio, mes - 1)

                            If dsMeses_Validado.Tables(0).Rows.Count > 0 Then

                                For k As Integer = 0 To dsMeses_Validado.Tables(0).Rows.Count - 1
                                    Estado = ""
                                    If dsMeses_Validado.Tables(0).Rows(k).Item("CODIGO").ToString.Trim = String.Format("{0}", codigo) Then

                                        Select Case control
                                            Case 4
                                                dsMeses_Validado.Tables(0).Rows(k).Item("SEMANA-04") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("SEMANA-04")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                                dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                                Estado = "A"
                                                Exit For
                                            Case 5
                                                dsMeses_Validado.Tables(0).Rows(k).Item("SEMANA-05") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("SEMANA-05")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                                dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                                Estado = "A"
                                                Exit For
                                            Case Else
                                        End Select
                                        Estado = "I"
                                    Else
                                        If Estado <> "A" Then
                                            Select Case control

                                                Case 4
                                                    dr("SEMANA-04") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                                    s4 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                                    dr("SEMANA-01") = 0
                                                    dr("SEMANA-03") = 0
                                                    dr("SEMANA-02") = 0
                                                    dr("SEMANA-05") = 0

                                                Case 5
                                                    dr("SEMANA-05") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                                    s5 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                                    dr("SEMANA-01") = 0
                                                    dr("SEMANA-03") = 0
                                                    dr("SEMANA-02") = 0
                                                    dr("SEMANA-04") = 0

                                                Case Else
                                            End Select

                                            dr("TOTAL") = s4 + s5
                                            dr("CODIGO") = codigo
                                            mes = CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(3, 2) - 1)
                                            dr("SEMANAS") = Nro_Semanas_X_Mes(anio, mes)
                                            dsMeses_Validado.Tables(0).Rows.Add(dr)
                                            valida = ""
                                            valida = "A"
                                        End If
                                    End If
                                Next

                            Else

                                Select Case control

                                    Case 4
                                        dr("SEMANA-04") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                        s4 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                        dr("SEMANA-01") = 0
                                        dr("SEMANA-03") = 0
                                        dr("SEMANA-02") = 0
                                        dr("SEMANA-05") = 0

                                    Case 5
                                        dr("SEMANA-05") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                        s5 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                        dr("SEMANA-01") = 0
                                        dr("SEMANA-03") = 0
                                        dr("SEMANA-02") = 0
                                        dr("SEMANA-04") = 0

                                    Case Else
                                End Select

                                dr("TOTAL") = s4 + s5
                                dr("CODIGO") = codigo
                                mes = CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(3, 2) - 1)
                                dr("SEMANAS") = Nro_Semanas_X_Mes(anio, mes)
                                dsMeses_Validado.Tables(0).Rows.Add(dr)
                                valida = "A"

                            End If
                    End Select

                    If valida <> "A" Then
                        dr("TOTAL") = s1 + s2 + s3 + s4 + s5
                        dr("CODIGO") = codigo
                        mes = CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(3, 2))
                        dr("SEMANAS") = Nro_Semanas_X_Mes(anio, mes)
                        dsMeses_Validado.Tables(0).Rows.Add(dr)
                    End If
                End If
            Next
            Return dsMeses_Validado
        Else
            Return Nothing
        End If

    End Function

    Public Function ConsultaIncidenciaPorMes_V1(ByVal obeSeguimiento As beSeguimiento, ByVal Lista As List(Of String)) As DataSet

        Dim dtMeses As DataTable
        Dim dsMeses As New DataSet
        Dim dsMeses_Validado As New DataSet
        Dim dr As DataRow
        Dim codigo As String = ""
        Dim Num_Semana As Integer = 0
        Dim semana As String = ""
        Dim Suma As Int32 = 0
        Dim Nom_Semana As String = ""

        Dim Tabla_Anio_Sem As DataTable
        Tabla_Anio_Sem = Anio_Semanal(obeSeguimiento.ANIO)

        dtMeses = New DataTable
        dtMeses.Columns.Add("TCMPCL", Type.GetType("System.String"))
        dtMeses.Columns.Add("TCMPDV", Type.GetType("System.String"))
        dtMeses.Columns.Add("IDMES", Type.GetType("System.Int32"))
        dtMeses.Columns.Add("MES", Type.GetType("System.String"))
        dtMeses.Columns.Add("CINCID", Type.GetType("System.Int32"))
        dtMeses.Columns.Add("TINCSI", Type.GetType("System.String"))
        For index As Integer = 1 To 5
            dtMeses.Columns.Add(String.Format("SEMANA-0{0}", index), Type.GetType("System.Int32"))
        Next
        dtMeses.Columns.Add("TOTAL", Type.GetType("System.Int32"))
        dtMeses.Columns.Add("CODIGO", Type.GetType("System.String"))
        dtMeses.Columns.Add("SEMANAS", Type.GetType("System.Int32"))
        dtMeses.TableName = "MESES"
        dsMeses_Validado.Tables.Add(dtMeses)

        dsMeses = oDatos.ConsultaIncidenciaPorMes(obeSeguimiento)

        Dim Visitados As New Hashtable
        Dim FilaActual As Int32 = 0

        If dsMeses.Tables(0).Rows.Count > 0 Then
            Dim anio As Integer = CInt(dsMeses.Tables(0).Rows(0).Item("FRGTRO").ToString.Substring(6, 4))

            For j As Integer = 0 To dsMeses.Tables(0).Rows.Count - 1
                Num_Semana = 0
                semana = ""
                codigo = ""
                Num_Semana = DatePart(DateInterval.WeekOfYear, CDate(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString))
                Dim dr_sem1 As DataRow()
                dr_sem1 = Tabla_Anio_Sem.Select("NRO = '" & Num_Semana & "'")

                codigo = dsMeses.Tables(0).Rows(j).Item("CCMPN").ToString.Trim & "_" & dsMeses.Tables(0).Rows(j).Item("CARINC").ToString.Trim
                codigo = codigo & "_" & dr_sem1(0).Item("MES").ToString.Trim & "_" & dsMeses.Tables(0).Rows(j).Item("CINCID")

                If Not Visitados.Contains(codigo) Then
                    Visitados.Add(codigo, dsMeses_Validado.Tables("MESES").Rows.Count)
                    FilaActual = Visitados(codigo)

                    dr = dsMeses_Validado.Tables("MESES").NewRow
                    dr("TCMPCL") = dsMeses.Tables(0).Rows(j).Item("TCMPCL").ToString.Trim
                    dr("TCMPDV") = dsMeses.Tables(0).Rows(j).Item("TCMPDV").ToString.Trim
                    dr("IDMES") = CInt(dr_sem1(0).Item("MES"))
                    dr("MES") = String.Format("{0}-{1}", dr("IDMES").ToString.PadLeft(2, "0"), MonthName(CInt(dr_sem1(0).Item("MES"))).ToUpper)
                    dr("CINCID") = dsMeses.Tables(0).Rows(j).Item("CINCID")
                    dr("TINCSI") = dsMeses.Tables(0).Rows(j).Item("TINCSI").ToString.Trim
                    For sem As Integer = 1 To 5
                        semana = String.Format("SEMANA-0{0}", sem)
                        dr(semana) = 0
                    Next
                    dr("TOTAL") = 0
                    dr("CODIGO") = codigo
                    dr("SEMANAS") = Nro_Semanas_X_Mes(anio, CInt(dr_sem1(0).Item("MES")))
                    semana = String.Format("SEMANA-{0}", dr_sem1(0).Item("SEMANA"))
                    dsMeses_Validado.Tables("MESES").Rows.Add(dr)
                    dsMeses_Validado.Tables("MESES").Rows(FilaActual)(semana) = dsMeses_Validado.Tables("MESES").Rows(FilaActual)(semana) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                Else
                    semana = String.Format("SEMANA-{0}", dr_sem1(0).Item("SEMANA"))
                    FilaActual = Visitados(codigo)
                    dsMeses_Validado.Tables("MESES").Rows(FilaActual)(semana) = dsMeses_Validado.Tables("MESES").Rows(FilaActual)(semana) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                End If
            Next

        End If

        For j As Integer = 0 To dsMeses_Validado.Tables("MESES").Rows.Count - 1
            Suma = 0
            For index As Integer = 1 To 5
                Nom_Semana = String.Format("SEMANA-0{0}", index)
                Suma = Suma + dsMeses_Validado.Tables("MESES").Rows(j)(Nom_Semana)
            Next
            dsMeses_Validado.Tables("MESES").Rows(j)("TOTAL") = Suma
        Next

        Return dsMeses_Validado

    End Function

    Public Function Nro_Semanas_X_Mes(ByVal anio As Integer, ByVal mes As Integer) As Integer
        Dim semanas As Integer = 0
        Dim ultimo_dia1 As Integer = Date.DaysInMonth(anio, mes)
        If mes > 1 Then
            Dim ultimo_dia2 As Integer = Date.DaysInMonth(anio, mes - 1)
            Dim semana_fin As Integer = DatePart(DateInterval.WeekOfYear, CDate(String.Format("{0}/{1}/{2}", ultimo_dia1, mes, anio)))
            Dim semana_ini As Integer = DatePart(DateInterval.WeekOfYear, CDate(String.Format("{0}/{1}/{2}", ultimo_dia2, mes - 1, anio)))
            semanas = semana_fin - semana_ini
            Return semanas
        Else
            Return DatePart(DateInterval.WeekOfYear, CDate(String.Format("{0}/{1}/{2}", ultimo_dia1, mes, anio)))
        End If
    End Function

    Public Function olisListarRegistroIncidencias(ByVal obeSeguimiento As beSeguimiento, ByVal PLANTAS As String) As List(Of beSeguimiento)
        Return oDatos.olisListarRegistroIncidencias(obeSeguimiento, PLANTAS)
    End Function

    Public Function Lista_Incidencia_Estados() As DataTable
        Return oDatos.Lista_Incidencia_Estados()
    End Function

    Public Function Consulta_Estado_Actual_Seguimiento(ByVal NINCSI As Decimal) As String
        Return oDatos.Consulta_Estado_Actual_Seguimiento(NINCSI)
    End Function

    Public Function Lista_Tipo_Solucion() As DataTable
        Return oDatos.Lista_Tipo_Solucion
    End Function

    Public Function Lista_Accion() As DataTable
        Return oDatos.Lista_Accion
    End Function

    Public Function Lista_Efectos() As DataTable
        Return oDatos.Lista_Efectos
    End Function


    Public Function Lista_Clasificacion() As DataTable
        Return oDatos.Lista_Clasificacion
    End Function

    Public Function Lista_Seguimiento_Asumidos() As DataTable
        Return oDatos.Lista_Seguimiento_Asumidos
    End Function


    Public Function olisListarRegistroIncidenciasVista(ByVal obeSeguimiento As beSeguimiento) As List(Of beSeguimiento)
        Return oDatos.olisListarRegistroIncidenciasVista(obeSeguimiento)
    End Function

    Public Function ListarIncidenciasCliente(ByVal obeSeguimiento As beSeguimiento) As List(Of beSeguimiento)
        Return oDatos.ListarIncidenciasCliente(obeSeguimiento)
    End Function

    Public Function olisListarTipoIncidenciasCliente(ByVal obeSeguimiento As beSeguimiento) As List(Of beSeguimiento)
        Return oDatos.olisListarTipoIncidenciasCliente(obeSeguimiento)
    End Function

End Class

