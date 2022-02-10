Imports RANSA.DATA
Imports RANSA.TYPEDEF

Public Class brIncidencias
    Dim oDatos As New daIncidencias



    Public Function intInsertarMaestroIncidencias(ByVal obeIncidencias As beIncidencias) As Integer
        Return oDatos.intInsertarMaestroIncidencias(obeIncidencias)
    End Function

    Public Function intActualizarMaestroIncidencias(ByVal obeIncidencias As beIncidencias) As Integer
        Return oDatos.intActualizarMaestroIncidencias(obeIncidencias)
    End Function

    Public Function intEliminarMaestroIncidencias(ByVal obeIncidencias As beIncidencias) As Integer
        Return oDatos.intEliminarMaestroIncidencias(obeIncidencias)
    End Function

    Public Function olistListarMaestroIncidencias(ByVal obeIncidencias As beIncidencias) As DataSet

        Dim dtMeses As DataTable
        Dim dsMeses As New DataSet
        Dim dsMeses_Validado As New DataSet
        Dim Estado As String = ""
        Dim dr As DataRow
        Dim m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12 As Integer

        Dim codigo As String = ""
        Dim codigo1 As String = ""

        dtMeses = New DataTable

        dtMeses.Columns.Add("CCMPN", Type.GetType("System.String"))
        dtMeses.Columns.Add("CDVSN", Type.GetType("System.String"))
        dtMeses.Columns.Add("TCMPDV", Type.GetType("System.String"))
        dtMeses.Columns.Add("CINCID", Type.GetType("System.Int32"))
        dtMeses.Columns.Add("TINCSI", Type.GetType("System.String"))

        dtMeses.Columns.Add("ENE", Type.GetType("System.Int32"))
        dtMeses.Columns.Add("FEB", Type.GetType("System.Int32"))
        dtMeses.Columns.Add("MAR", Type.GetType("System.Int32"))
        dtMeses.Columns.Add("ABR", Type.GetType("System.Int32"))
        dtMeses.Columns.Add("MAY", Type.GetType("System.Int32"))
        dtMeses.Columns.Add("JUN", Type.GetType("System.Int32"))
        dtMeses.Columns.Add("JUL", Type.GetType("System.Int32"))
        dtMeses.Columns.Add("AGO", Type.GetType("System.Int32"))
        dtMeses.Columns.Add("SEP", Type.GetType("System.Int32"))
        dtMeses.Columns.Add("OCT", Type.GetType("System.Int32"))
        dtMeses.Columns.Add("NOV", Type.GetType("System.Int32"))
        dtMeses.Columns.Add("DIC", Type.GetType("System.Int32"))
        dtMeses.Columns.Add("TOTAL", Type.GetType("System.Int32"))

        dtMeses.Columns.Add("CODIGO", Type.GetType("System.String"))

        dsMeses_Validado.Tables.Add(dtMeses)

        dsMeses = oDatos.olistListarMaestroIncidencias(obeIncidencias)

        For j As Integer = 0 To dsMeses.Tables(0).Rows.Count - 1

            m1 = 0
            m2 = 0
            m3 = 0
            m4 = 0
            m5 = 0
            m6 = 0
            m7 = 0
            m8 = 0
            m9 = 0
            m10 = 0
            m11 = 0
            m12 = 0


            dr = dsMeses_Validado.Tables(0).NewRow
            codigo = ""

            dr("CCMPN") = dsMeses.Tables(0).Rows(j).Item("CCMPN")
            dr("CDVSN") = dsMeses.Tables(0).Rows(j).Item("CDVSN")
            codigo = String.Format("{0}{1}", codigo, dsMeses.Tables(0).Rows(j).Item("CDVSN").ToString.Trim)

            dr("TCMPDV") = dsMeses.Tables(0).Rows(j).Item("TCMPDV")

            dr("CINCID") = CInt(dsMeses.Tables(0).Rows(j).Item("CINCID"))
            codigo = String.Format("{0}{1}", codigo, dsMeses.Tables(0).Rows(j).Item("CINCID").ToString.Trim)

            dr("TINCSI") = dsMeses.Tables(0).Rows(j).Item("TINCSI")


            If dsMeses_Validado.Tables(0).Rows.Count > 0 Then

                For k As Integer = 0 To dsMeses_Validado.Tables(0).Rows.Count - 1

                    Estado = ""

                    If dsMeses_Validado.Tables(0).Rows(k).Item("CODIGO").ToString.Trim = String.Format("{0}", codigo) Then

                        Select Case CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(4, 2))

                            Case 1
                                dsMeses_Validado.Tables(0).Rows(k).Item("ENE") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("ENE")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                Estado = "A"
                                Exit For
                            Case 2
                                dsMeses_Validado.Tables(0).Rows(k).Item("FEB") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("FEB")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                Estado = "A"
                                Exit For
                            Case 3
                                dsMeses_Validado.Tables(0).Rows(k).Item("MAR") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("MAR")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                Estado = "A"
                                Exit For
                            Case 4
                                dsMeses_Validado.Tables(0).Rows(k).Item("ABR") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("ABR")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                Estado = "A"
                                Exit For
                            Case 5
                                dsMeses_Validado.Tables(0).Rows(k).Item("MAY") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("MAY")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                Estado = "A"
                                Exit For
                            Case 6
                                dsMeses_Validado.Tables(0).Rows(k).Item("JUN") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("JUN")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                Estado = "A"
                                Exit For
                            Case 7
                                dsMeses_Validado.Tables(0).Rows(k).Item("JUL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("JUL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                Estado = "A"
                                Exit For
                            Case 8
                                dsMeses_Validado.Tables(0).Rows(k).Item("AGO") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("AGO")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                Estado = "A"
                                Exit For
                            Case 9
                                dsMeses_Validado.Tables(0).Rows(k).Item("SEP") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("SEP")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                Estado = "A"
                                Exit For
                            Case 10
                                dsMeses_Validado.Tables(0).Rows(k).Item("OCT") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("OCT")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                Estado = "A"
                                Exit For
                            Case 11
                                dsMeses_Validado.Tables(0).Rows(k).Item("NOV") = Val(dsMeses_Validado.Tables(0).Rows(k).Item("NOV")) + Val(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                Estado = "A"
                                Exit For
                            Case 12
                                dsMeses_Validado.Tables(0).Rows(k).Item("DIC") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("DIC")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL") = CInt(dsMeses_Validado.Tables(0).Rows(k).Item("TOTAL")) + CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                                Estado = "A"
                                Exit For
                            Case Else

                        End Select

                    End If

                    Estado = "I"

                Next

                If Estado <> "A" Then

                    Select Case CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(4, 2))

                        Case 1
                            dr("ENE") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                            m1 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                            dr("FEB") = 0
                            m2 = 0
                            dr("MAR") = 0
                            m3 = 0
                            dr("ABR") = 0
                            m4 = 0
                            dr("MAY") = 0
                            m5 = 0
                            dr("JUN") = 0
                            m6 = 0
                            dr("JUL") = 0
                            m7 = 0
                            dr("AGO") = 0
                            m8 = 0
                            dr("SEP") = 0
                            m9 = 0
                            dr("OCT") = 0
                            m10 = 0
                            dr("NOV") = 0
                            m11 = 0
                            dr("DIC") = 0
                            m12 = 0
                        Case 2
                            dr("ENE") = 0
                            m1 = 0
                            dr("FEB") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                            m2 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                            dr("MAR") = 0
                            m3 = 0
                            dr("ABR") = 0
                            m4 = 0
                            dr("MAY") = 0
                            m5 = 0
                            dr("JUN") = 0
                            m6 = 0
                            dr("JUL") = 0
                            m7 = 0
                            dr("AGO") = 0
                            m8 = 0
                            dr("SEP") = 0
                            m9 = 0
                            dr("OCT") = 0
                            m10 = 0
                            dr("NOV") = 0
                            m11 = 0
                            dr("DIC") = 0
                            m12 = 0
                        Case 3
                            dr("ENE") = 0
                            m1 = 0
                            dr("FEB") = 0
                            m2 = 0
                            dr("MAR") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                            m3 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                            dr("ABR") = 0
                            m4 = 0
                            dr("MAY") = 0
                            m5 = 0
                            dr("JUN") = 0
                            m6 = 0
                            dr("JUL") = 0
                            m7 = 0
                            dr("AGO") = 0
                            m8 = 0
                            dr("SEP") = 0
                            m9 = 0
                            dr("OCT") = 0
                            m10 = 0
                            dr("NOV") = 0
                            m11 = 0
                            dr("DIC") = 0
                            m12 = 0
                        Case 4
                            dr("ENE") = 0
                            m1 = 0
                            dr("FEB") = 0
                            m2 = 0
                            dr("MAR") = 0
                            m3 = 0
                            dr("ABR") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                            m4 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                            dr("MAY") = 0
                            m5 = 0
                            dr("JUN") = 0
                            m6 = 0
                            dr("JUL") = 0
                            m7 = 0
                            dr("AGO") = 0
                            m8 = 0
                            dr("SEP") = 0
                            m9 = 0
                            dr("OCT") = 0
                            m10 = 0
                            dr("NOV") = 0
                            m11 = 0
                            dr("DIC") = 0
                            m12 = 0

                        Case 5
                            dr("ENE") = 0
                            m1 = 0
                            dr("FEB") = 0
                            m2 = 0
                            dr("MAR") = 0
                            m3 = 0
                            dr("ABR") = 0
                            m4 = 0
                            dr("MAY") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                            m5 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                            dr("JUN") = 0
                            m6 = 0
                            dr("JUL") = 0
                            m7 = 0
                            dr("AGO") = 0
                            m8 = 0
                            dr("SEP") = 0
                            m9 = 0
                            dr("OCT") = 0
                            m10 = 0
                            dr("NOV") = 0
                            m11 = 0
                            dr("DIC") = 0
                            m12 = 0
                        Case 6
                            dr("ENE") = 0
                            m1 = 0
                            dr("FEB") = 0
                            m2 = 0
                            dr("MAR") = 0
                            m3 = 0
                            dr("ABR") = 0
                            m4 = 0
                            dr("MAY") = 0
                            m5 = 0
                            dr("JUN") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                            m6 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                            dr("JUL") = 0
                            m7 = 0
                            dr("AGO") = 0
                            m8 = 0
                            dr("SEP") = 0
                            m9 = 0
                            dr("OCT") = 0
                            m10 = 0
                            dr("NOV") = 0
                            m11 = 0
                            dr("DIC") = 0
                            m12 = 0
                        Case 7
                            dr("ENE") = 0
                            m1 = 0
                            dr("FEB") = 0
                            m2 = 0
                            dr("MAR") = 0
                            m3 = 0
                            dr("ABR") = 0
                            m4 = 0
                            dr("MAY") = 0
                            m5 = 0
                            dr("JUN") = 0
                            m6 = 0
                            dr("JUL") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                            m7 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                            dr("AGO") = 0
                            m8 = 0
                            dr("SEP") = 0
                            m9 = 0
                            dr("OCT") = 0
                            m10 = 0
                            dr("NOV") = 0
                            m11 = 0
                            dr("DIC") = 0
                            m12 = 0
                        Case 8
                            dr("ENE") = 0
                            m1 = 0
                            dr("FEB") = 0
                            m2 = 0
                            dr("MAR") = 0
                            m3 = 0
                            dr("ABR") = 0
                            m4 = 0
                            dr("MAY") = 0
                            m5 = 0
                            dr("JUN") = 0
                            m6 = 0
                            dr("JUL") = 0
                            m7 = 0
                            dr("AGO") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                            m8 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                            dr("SEP") = 0
                            m9 = 0
                            dr("OCT") = 0
                            m10 = 0
                            dr("NOV") = 0
                            m11 = 0
                            dr("DIC") = 0
                            m12 = 0
                        Case 9
                            dr("ENE") = 0
                            m1 = 0
                            dr("FEB") = 0
                            m2 = 0
                            dr("MAR") = 0
                            m3 = 0
                            dr("ABR") = 0
                            m4 = 0
                            dr("MAY") = 0
                            m5 = 0
                            dr("JUN") = 0
                            m6 = 0
                            dr("JUL") = 0
                            m7 = 0
                            dr("AGO") = 0
                            m8 = 0
                            dr("SEP") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                            m9 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                            dr("OCT") = 0
                            m10 = 0
                            dr("NOV") = 0
                            m11 = 0
                            dr("DIC") = 0
                            m12 = 0
                        Case 10
                            dr("ENE") = 0
                            m1 = 0
                            dr("FEB") = 0
                            m2 = 0
                            dr("MAR") = 0
                            m3 = 0
                            dr("ABR") = 0
                            m4 = 0
                            dr("MAY") = 0
                            m5 = 0
                            dr("JUN") = 0
                            m6 = 0
                            dr("JUL") = 0
                            m7 = 0
                            dr("AGO") = 0
                            m8 = 0
                            dr("SEP") = 0
                            m9 = 0
                            dr("OCT") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                            m10 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                            dr("NOV") = 0
                            m11 = 0
                            dr("DIC") = 0
                            m12 = 0

                        Case 11
                            dr("ENE") = 0
                            m1 = 0
                            dr("FEB") = 0
                            m2 = 0
                            dr("MAR") = 0
                            m3 = 0
                            dr("ABR") = 0
                            m4 = 0
                            dr("MAY") = 0
                            m5 = 0
                            dr("JUN") = 0
                            m6 = 0
                            dr("JUL") = 0
                            m7 = 0
                            dr("AGO") = 0
                            m8 = 0
                            dr("SEP") = 0
                            m9 = 0
                            dr("OCT") = 0
                            m10 = 0
                            dr("NOV") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                            m11 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                            dr("DIC") = 0
                            m12 = 0
                        Case 12
                            dr("ENE") = 0
                            m1 = 0
                            dr("FEB") = 0
                            m2 = 0
                            dr("MAR") = 0
                            m3 = 0
                            dr("ABR") = 0
                            m4 = 0
                            dr("MAY") = 0
                            m5 = 0
                            dr("JUN") = 0
                            m6 = 0
                            dr("JUL") = 0
                            m7 = 0
                            dr("AGO") = 0
                            m8 = 0
                            dr("SEP") = 0
                            m9 = 0
                            dr("OCT") = 0
                            m10 = 0
                            dr("NOV") = 0
                            m11 = 0
                            dr("DIC") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                            m12 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))

                        Case Else

                    End Select

                    dr("TOTAL") = m1 + m2 + m3 + m4 + m5 + m6 + m7 + m8 + m9 + m10 + m11 + m12
                    dr("CODIGO") = codigo
                    dsMeses_Validado.Tables(0).Rows.Add(dr)

                End If

            Else

                Select Case CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(4, 2))
                    Case 1
                        dr("ENE") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                        m1 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                        dr("FEB") = 0
                        m2 = 0
                        dr("MAR") = 0
                        m3 = 0
                        dr("ABR") = 0
                        m4 = 0
                        dr("MAY") = 0
                        m5 = 0
                        dr("JUN") = 0
                        m6 = 0
                        dr("JUL") = 0
                        m7 = 0
                        dr("AGO") = 0
                        m8 = 0
                        dr("SEP") = 0
                        m9 = 0
                        dr("OCT") = 0
                        m10 = 0
                        dr("NOV") = 0
                        m11 = 0
                        dr("DIC") = 0
                        m12 = 0
                    Case 2
                        dr("ENE") = 0
                        m1 = 0
                        dr("FEB") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                        m2 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                        dr("MAR") = 0
                        m3 = 0
                        dr("ABR") = 0
                        m4 = 0
                        dr("MAY") = 0
                        m5 = 0
                        dr("JUN") = 0
                        m6 = 0
                        dr("JUL") = 0
                        m7 = 0
                        dr("AGO") = 0
                        m8 = 0
                        dr("SEP") = 0
                        m9 = 0
                        dr("OCT") = 0
                        m10 = 0
                        dr("NOV") = 0
                        m11 = 0
                        dr("DIC") = 0
                        m12 = 0
                    Case 3
                        dr("ENE") = 0
                        m1 = 0
                        dr("FEB") = 0
                        m2 = 0
                        dr("MAR") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                        m3 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                        dr("ABR") = 0
                        m4 = 0
                        dr("MAY") = 0
                        m5 = 0
                        dr("JUN") = 0
                        m6 = 0
                        dr("JUL") = 0
                        m7 = 0
                        dr("AGO") = 0
                        m8 = 0
                        dr("SEP") = 0
                        m9 = 0
                        dr("OCT") = 0
                        m10 = 0
                        dr("NOV") = 0
                        m11 = 0
                        dr("DIC") = 0
                        m12 = 0
                    Case 4
                        dr("ENE") = 0
                        m1 = 0
                        dr("FEB") = 0
                        m2 = 0
                        dr("MAR") = 0
                        m3 = 0
                        dr("ABR") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                        m4 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                        dr("MAY") = 0
                        m5 = 0
                        dr("JUN") = 0
                        m6 = 0
                        dr("JUL") = 0
                        m7 = 0
                        dr("AGO") = 0
                        m8 = 0
                        dr("SEP") = 0
                        m9 = 0
                        dr("OCT") = 0
                        m10 = 0
                        dr("NOV") = 0
                        m11 = 0
                        dr("DIC") = 0
                        m12 = 0
                    Case 5
                        dr("ENE") = 0
                        m1 = 0
                        dr("FEB") = 0
                        m2 = 0
                        dr("MAR") = 0
                        m3 = 0
                        dr("ABR") = 0
                        m4 = 0
                        dr("MAY") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                        m5 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                        dr("JUN") = 0
                        m6 = 0
                        dr("JUL") = 0
                        m7 = 0
                        dr("AGO") = 0
                        m8 = 0
                        dr("SEP") = 0
                        m9 = 0
                        dr("OCT") = 0
                        m10 = 0
                        dr("NOV") = 0
                        m11 = 0
                        dr("DIC") = 0
                        m12 = 0
                    Case 6
                        dr("ENE") = 0
                        m1 = 0
                        dr("FEB") = 0
                        m2 = 0
                        dr("MAR") = 0
                        m3 = 0
                        dr("ABR") = 0
                        m4 = 0
                        dr("MAY") = 0
                        m5 = 0
                        dr("JUN") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                        m6 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                        dr("JUL") = 0
                        m7 = 0
                        dr("AGO") = 0
                        m8 = 0
                        dr("SEP") = 0
                        m9 = 0
                        dr("OCT") = 0
                        m10 = 0
                        dr("NOV") = 0
                        m11 = 0
                        dr("DIC") = 0
                        m12 = 0
                    Case 7
                        dr("ENE") = 0
                        m1 = 0
                        dr("FEB") = 0
                        m2 = 0
                        dr("MAR") = 0
                        m3 = 0
                        dr("ABR") = 0
                        m4 = 0
                        dr("MAY") = 0
                        m5 = 0
                        dr("JUN") = 0
                        m6 = 0
                        dr("JUL") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                        m7 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                        dr("AGO") = 0
                        m8 = 0
                        dr("SEP") = 0
                        m9 = 0
                        dr("OCT") = 0
                        m10 = 0
                        dr("NOV") = 0
                        m11 = 0
                        dr("DIC") = 0
                        m12 = 0
                    Case 8
                        dr("ENE") = 0
                        m1 = 0
                        dr("FEB") = 0
                        m2 = 0
                        dr("MAR") = 0
                        m3 = 0
                        dr("ABR") = 0
                        m4 = 0
                        dr("MAY") = 0
                        m5 = 0
                        dr("JUN") = 0
                        m6 = 0
                        dr("JUL") = 0
                        m7 = 0
                        dr("AGO") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                        m8 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                        dr("SEP") = 0
                        m9 = 0
                        dr("OCT") = 0
                        m10 = 0
                        dr("NOV") = 0
                        m11 = 0
                        dr("DIC") = 0
                        m12 = 0
                    Case 9
                        dr("ENE") = 0
                        m1 = 0
                        dr("FEB") = 0
                        m2 = 0
                        dr("MAR") = 0
                        m3 = 0
                        dr("ABR") = 0
                        m4 = 0
                        dr("MAY") = 0
                        m5 = 0
                        dr("JUN") = 0
                        m6 = 0
                        dr("JUL") = 0
                        m7 = 0
                        dr("AGO") = 0
                        m8 = 0
                        dr("SEP") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                        m9 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                        dr("OCT") = 0
                        m10 = 0
                        dr("NOV") = 0
                        m11 = 0
                        dr("DIC") = 0
                        m12 = 0
                    Case 10
                        dr("ENE") = 0
                        m1 = 0
                        dr("FEB") = 0
                        m2 = 0
                        dr("MAR") = 0
                        m3 = 0
                        dr("ABR") = 0
                        m4 = 0
                        dr("MAY") = 0
                        m5 = 0
                        dr("JUN") = 0
                        m6 = 0
                        dr("JUL") = 0
                        m7 = 0
                        dr("AGO") = 0
                        m8 = 0
                        dr("SEP") = 0
                        m9 = 0
                        dr("OCT") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                        m10 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                        dr("NOV") = 0
                        m11 = 0
                        dr("DIC") = 0
                        m12 = 0
                    Case 11
                        dr("ENE") = 0
                        m1 = 0
                        dr("FEB") = 0
                        m2 = 0
                        dr("MAR") = 0
                        m3 = 0
                        dr("ABR") = 0
                        m4 = 0
                        dr("MAY") = 0
                        m5 = 0
                        dr("JUN") = 0
                        m6 = 0
                        dr("JUL") = 0
                        m7 = 0
                        dr("AGO") = 0
                        m8 = 0
                        dr("SEP") = 0
                        m9 = 0
                        dr("OCT") = 0
                        m10 = 0
                        dr("NOV") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                        m11 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                        dr("DIC") = 0
                        m12 = 0
                    Case 12
                        dr("ENE") = 0
                        m1 = 0
                        dr("FEB") = 0
                        m2 = 0
                        dr("MAR") = 0
                        m3 = 0
                        dr("ABR") = 0
                        m4 = 0
                        dr("MAY") = 0
                        m5 = 0
                        dr("JUN") = 0
                        m6 = 0
                        dr("JUL") = 0
                        m7 = 0
                        dr("AGO") = 0
                        m8 = 0
                        dr("SEP") = 0
                        m9 = 0
                        dr("OCT") = 0
                        m10 = 0
                        dr("NOV") = 0
                        m11 = 0
                        dr("DIC") = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                        m12 = CInt(dsMeses.Tables(0).Rows(j).Item("QINCIDENCIA"))
                    Case Else

                End Select
                dr("TOTAL") = m1 + m2 + m3 + m4 + m5 + m6 + m7 + m8 + m9 + m10 + m11 + m12
                dr("CODIGO") = codigo
                dsMeses_Validado.Tables(0).Rows.Add(dr)
            End If
        Next

        '   COMPLETANDO CON LAS INSIDENCIAS

        For i As Integer = 0 To dsMeses.Tables(1).Rows.Count - 1

            Dim cod As String = ""
            Dim x As Integer = 0
            cod = String.Format("{0}{1}", cod, dsMeses.Tables(1).Rows(i).Item("CDVSN").ToString.Trim)
            cod = String.Format("{0}{1}", cod, dsMeses.Tables(1).Rows(i).Item("CINCID").ToString.Trim)

            For a As Integer = 0 To dsMeses_Validado.Tables(0).Rows.Count - 1

                If dsMeses_Validado.Tables(0).Rows(a).Item("CODIGO").ToString.Trim = cod Then
                    x = x + 1
                    Exit For
                End If
            Next

            If x = 0 Then
                dr = dsMeses_Validado.Tables(0).NewRow
                codigo = ""
                dr("CCMPN") = dsMeses.Tables(1).Rows(i).Item("CCMPN")
                dr("CDVSN") = dsMeses.Tables(1).Rows(i).Item("CDVSN")
                dr("TCMPDV") = dsMeses.Tables(1).Rows(i).Item("TCMPDV")
                dr("CINCID") = CInt(dsMeses.Tables(1).Rows(i).Item("CINCID"))
                dr("TINCSI") = dsMeses.Tables(1).Rows(i).Item("TINCSI")
                dr("ENE") = 0
                dr("FEB") = 0
                dr("MAR") = 0
                dr("ABR") = 0
                dr("MAY") = 0
                dr("JUN") = 0
                dr("JUL") = 0
                dr("AGO") = 0
                dr("SEP") = 0
                dr("OCT") = 0
                dr("NOV") = 0
                dr("DIC") = 0
                dr("TOTAL") = 0
                dr("CODIGO") = cod
                dsMeses_Validado.Tables(0).Rows.Add(dr)
            End If
        Next

        Return dsMeses_Validado

    End Function

    Public Function intInsertarRegistroIncidencias(ByVal obeIncidencias As beIncidencias) As Integer
        Return oDatos.intInsertarRegistroIncidencias(obeIncidencias)
    End Function

    Public Function intActualizarRegistroIncidencias(ByVal obeIncidencias As beIncidencias) As Integer
        Return oDatos.intActualizarRegistroIncidencias(obeIncidencias)
    End Function

    Public Function ConsultaIncidenciaPorFecha(ByVal obeIncidencias As beIncidencias) As DataSet
        Return oDatos.ConsultaIncidenciaPorFecha(obeIncidencias)
    End Function

    Public Function ConsultaIncidenciaPorMes(ByVal obeIncidencias As beIncidencias, ByVal Lista As List(Of String)) As DataSet

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

        dsMeses = oDatos.ConsultaIncidenciaPorMes(obeIncidencias)

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

                dr("TCMPCL") = dsMeses.Tables(0).Rows(j).Item("TCMPCL")
                dr("TCMPDV") = dsMeses.Tables(0).Rows(j).Item("TCMPDV")
                codigo = String.Format("{0}{1}", codigo, dsMeses.Tables(0).Rows(j).Item("CDVSN").ToString.Trim)
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
                                    codigo = dsMeses.Tables(0).Rows(j).Item("CCLNT").ToString.Trim
                                    codigo = String.Format("{0}{1}", codigo, dsMeses.Tables(0).Rows(j).Item("CDVSN").ToString.Trim)
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
                                                mes = 0
                                                mes = CInt(dsMeses.Tables(0).Rows(j).Item("FRGTRO").ToString.Substring(3, 2) - 1)
                                                dr("SEMANAS") = Nro_Semanas_X_Mes(anio, mes)
                                                dsMeses_Validado.Tables(0).Rows.Add(dr)
                                                Estado = "A"
                                                Exit For

                                            End If
                                        End If
                                    Next
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
                                codigo = String.Format("{0}{1}", codigo, dsMeses.Tables(0).Rows(j).Item("CDVSN").ToString.Trim)
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
                            codigo = String.Format("{0}{1}", codigo, dsMeses.Tables(0).Rows(j).Item("CDVSN").ToString.Trim)
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

    'Public Function Anio_Mes_Semana(ByVal anio As Integer) As DataTable

    '    Dim dt_Anio_Mes_Semana As New DataTable
    '    Dim dr As DataRow
    '    Dim Num_Sem_Anio As Integer = 0

    '    dt_Anio_Mes_Semana.Columns.Add("ANIO", Type.GetType("System.Int32"))
    '    dt_Anio_Mes_Semana.Columns.Add("MES", Type.GetType("System.Int32"))
    '    dt_Anio_Mes_Semana.Columns.Add("DIA", Type.GetType("System.Int32"))
    '    dt_Anio_Mes_Semana.Columns.Add("SEMANA", Type.GetType("System.Int32"))

    '    Dim TotalDiasMes As Integer
    '    Dim Dia_Inicial_Mes As String = ""
    '    Dim dia_Mes_Anio As String = ""
    '    Dim control As Integer = 0

    '    For mes As Integer = 1 To 12
    '        TotalDiasMes = 0
    '        Dia_Inicial_Mes = ""

    '        For index As Integer = 1 To TotalDiasMes
    '            dia_Mes_Anio = ""
    '            dia_Mes_Anio = String.Format("{0}/{1}/{2}", index, mes, anio)
    '            dr = dt_Anio_Mes_Semana.NewRow
    '            dr("ANIO") = anio
    '            dr("MES") = mes
    '            dr("DIA") = index
    '            dr("SEMANA") = DatePart(DateInterval.WeekOfYear, CDate(dia_Mes_Anio))
    '            dt_Anio_Mes_Semana.Rows.Add(dr)
    '        Next

    '    Next

    '    'Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton1.Click
    '    'Dim FirstDate, Msg As String
    '    'Dim SecondDate As Date
    '    'FirstDate = InputBox("Enter a date:")
    '    'SecondDate = CDate(FirstDate)
    '    'Declare variables.
    '    'Dim Dias_del_Mes As Integer = Date.DaysInMonth(CInt(txtAnio.Text.Trim), CInt(cmbMes.Properties.GetCheckedItems))
    '    'Dim Ultimo_dia_Mes As String = String.Format("{0}/{1}/{2}", Dias_del_Mes, CInt(cmbMes.Properties.GetCheckedItems), CInt(txtAnio.Text.Trim))
    '    'Dim Nro_Semanas_del_Mes As Integer = DatePart(DateInterval.WeekOfYear, CDate("28/02/2013"))
    '    'Msg = "Quarter: " & Nro_Semanas_del_Mes
    '    ' Enero
    '    ' nombre del dia -->>  WeekdayName(Weekday(SecondDate))
    '    ' dias de un mes -->>  Date.DaysInMonth(2012, 1)
    '    'DatePart(DateInterval.WeekOfYear, SecondDate)

    '    Return dt_Anio_Mes_Semana

    'End Function

    'Public Shared Function CantidadLunes(ByVal mes As Integer) As Integer
    '    Dim cantidad As Integer = 0
    '    Dim fechaRef As New Date(Year(Date.Now), mes, 1)
    '    While fechaRef.DayOfWeek <> DayOfWeek.Monday
    '        fechaRef = fechaRef.AddDays(1)
    '    End While
    '    Dim fecha As Date
    '    For i As Integer = 0 To 5
    '        fecha = fechaRef.AddDays(i * 7)
    '        If fecha.Month = mes Then
    '            cantidad = cantidad + 1
    '        Else
    '            Exit For
    '        End If
    '    Next
    '    Return cantidad
    'End Function


    Public Function olisListarRegistroIncidencias(ByVal obeIncidencias As beIncidencias) As List(Of beIncidencias)
        Return oDatos.olisListarRegistroIncidencias(obeIncidencias)
    End Function

End Class