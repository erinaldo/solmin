Imports SOLMIN_ST.DATOS.Consultas
Imports SOLMIN_ST.ENTIDADES.Consultas

Namespace Consultas

    Public Class Indicadores_BLL
        Private Function fnDiasPorMes(ByVal Fecha As DateTime) As List(Of String)
            Dim objListDias As New List(Of String)
            Dim num_dias As Integer = DateTime.DaysInMonth(Fecha.Year, Fecha.Month)
            For i As Integer = 1 To num_dias
                objListDias.Add(i.ToString())
            Next
            Return objListDias
        End Function
        Private Sub dtMes(ByRef dtMes As DataTable)
            dtMes.Columns.Add("TIPO", Type.GetType("System.String"))
            dtMes.Columns.Add("DIA01", Type.GetType("System.Double"))
            dtMes.Columns.Add("DIA02", Type.GetType("System.Double"))
            dtMes.Columns.Add("DIA03", Type.GetType("System.Double"))
            dtMes.Columns.Add("DIA04", Type.GetType("System.Double"))
            dtMes.Columns.Add("DIA05", Type.GetType("System.Double"))
            dtMes.Columns.Add("DIA06", Type.GetType("System.Double"))
            dtMes.Columns.Add("DIA07", Type.GetType("System.Double"))
            dtMes.Columns.Add("DIA08", Type.GetType("System.Double"))
            dtMes.Columns.Add("DIA09", Type.GetType("System.Double"))
            dtMes.Columns.Add("DIA10", Type.GetType("System.Double"))
            dtMes.Columns.Add("DIA11", Type.GetType("System.Double"))
            dtMes.Columns.Add("DIA12", Type.GetType("System.Double"))
            dtMes.Columns.Add("DIA13", Type.GetType("System.Double"))
            dtMes.Columns.Add("DIA14", Type.GetType("System.Double"))
            dtMes.Columns.Add("DIA15", Type.GetType("System.Double"))
            dtMes.Columns.Add("DIA16", Type.GetType("System.Double"))
            dtMes.Columns.Add("DIA17", Type.GetType("System.Double"))
            dtMes.Columns.Add("DIA18", Type.GetType("System.Double"))
            dtMes.Columns.Add("DIA19", Type.GetType("System.Double"))
            dtMes.Columns.Add("DIA20", Type.GetType("System.Double"))
            dtMes.Columns.Add("DIA21", Type.GetType("System.Double"))
            dtMes.Columns.Add("DIA22", Type.GetType("System.Double"))
            dtMes.Columns.Add("DIA23", Type.GetType("System.Double"))
            dtMes.Columns.Add("DIA24", Type.GetType("System.Double"))
            dtMes.Columns.Add("DIA25", Type.GetType("System.Double"))
            dtMes.Columns.Add("DIA26", Type.GetType("System.Double"))
            dtMes.Columns.Add("DIA27", Type.GetType("System.Double"))
            dtMes.Columns.Add("DIA28", Type.GetType("System.Double"))
            dtMes.Columns.Add("DIA29", Type.GetType("System.Double"))
            dtMes.Columns.Add("DIA30", Type.GetType("System.Double"))
            dtMes.Columns.Add("DIA31", Type.GetType("System.Double"))
        End Sub
        Public Shared Function SelectDistinct(ByVal SourceTable As DataTable, ByVal ParamArray FieldNames() As String) As DataTable
            Dim lastValues() As Object
            Dim newTable As DataTable

            If FieldNames Is Nothing OrElse FieldNames.Length = 0 Then
                Throw New ArgumentNullException("FieldNames")
            End If

            lastValues = New Object(FieldNames.Length - 1) {}
            newTable = New DataTable

            For Each field As String In FieldNames
                newTable.Columns.Add(field, SourceTable.Columns(field).DataType)
            Next

            For Each Row As DataRow In SourceTable.Select("", String.Join(", ", FieldNames))
                If Not fieldValuesAreEqual(lastValues, Row, FieldNames) Then
                    newTable.Rows.Add(createRowClone(Row, newTable.NewRow(), FieldNames))

                    setLastValues(lastValues, Row, FieldNames)
                End If
            Next

            Return newTable
        End Function
        Private Shared Function fieldValuesAreEqual(ByVal lastValues() As Object, ByVal currentRow As DataRow, ByVal fieldNames() As String) As Boolean
            Dim areEqual As Boolean = True

            For i As Integer = 0 To fieldNames.Length - 1
                If lastValues(i) Is Nothing OrElse Not lastValues(i).Equals(currentRow(fieldNames(i))) Then
                    areEqual = False
                    Exit For
                End If
            Next

            Return areEqual
        End Function
        Private Shared Function createRowClone(ByVal sourceRow As DataRow, ByVal newRow As DataRow, ByVal fieldNames() As String) As DataRow
            For Each field As String In fieldNames
                newRow(field) = sourceRow(field)
            Next

            Return newRow
        End Function
        Private Shared Sub setLastValues(ByVal lastValues() As Object, ByVal sourceRow As DataRow, ByVal fieldNames() As String)
            For i As Integer = 0 To fieldNames.Length - 1
                lastValues(i) = sourceRow(fieldNames(i))
            Next
        End Sub
        Public Shared Function FilterSortData(ByVal dtStart As DataTable, ByVal filter As String, ByVal sort As String) As DataTable
            Dim dt As DataTable = dtStart.Clone()
            Dim drs As DataRow() = dtStart.Select(filter, sort)
            For Each dr As DataRow In drs
                dt.ImportRow(dr)
            Next
            Return dt
        End Function



        Public Sub Indicador_Operativo_km_Recorrido(ByVal objParametro As Hashtable, ByVal FEC As DateTime, ByRef dtKilometrosPorTipoTotales As DataTable, ByRef dtKilometrosPorDiaBarras As DataTable, ByRef dtKilometrosPorTipoPie As DataTable)
            Dim TOTAL, PROPIOS, TERCEROS As Double

            dtKilometrosPorTipoTotales.Columns.Add("TOTAL", Type.GetType("System.Double"))
            dtKilometrosPorTipoTotales.Columns.Add("PROPIOS", Type.GetType("System.Double"))
            dtKilometrosPorTipoTotales.Columns.Add("TERCEROS", Type.GetType("System.Double"))

            dtKilometrosPorDiaBarras.Columns.Add("DIA", Type.GetType("System.Int32"))
            dtKilometrosPorDiaBarras.Columns.Add("TIPO", Type.GetType("System.String"))
            dtKilometrosPorDiaBarras.Columns.Add("CANTIDAD", Type.GetType("System.Double"))

            dtKilometrosPorTipoPie.Columns.Add("TIPO", Type.GetType("System.String"))
            dtKilometrosPorTipoPie.Columns.Add("CANTIDAD", Type.GetType("System.Double"))

            Dim objListTipoTransporte As New List(Of TipoTransporte)
            objListTipoTransporte.Add(New TipoTransporte("P", "Propietario", 0))
            objListTipoTransporte.Add(New TipoTransporte("T", "Tercero", 0))
            Dim objListDias As List(Of String) = fnDiasPorMes(FEC)

            Dim dtIndicadores As DataTable = New Indicadores_DAL().Indicador_Operativo_km_Recorrido(objParametro)

            If dtIndicadores IsNot Nothing Then
                For Each Dia As String In objListDias
                    For Each objTipoTransporte As TipoTransporte In objListTipoTransporte
            Dim FechaAux As String = FEC.Year.ToString() & "" & IIf(FEC.Month < 10, "0" & FEC.Month.ToString(), FEC.Month.ToString()) & "" & IIf(Dia < 10, "0" & Dia, Dia)
                        Dim expression As String = "FGUIRM = '" + FechaAux + "' AND SINDRC = '" + objTipoTransporte.TIPO + "'"
                        Dim sortOrder As String = "FGUIRM DESC"
                        Dim foundRows As DataRow()
                        foundRows = dtIndicadores.Select(expression, sortOrder)
                        Dim QKMREC As Integer = 0
                        For i As Integer = 0 To foundRows.Length - 1
                            QKMREC += foundRows(i)("QKMREC")
                            objTipoTransporte.CANTIDAD += QKMREC
                            TOTAL += QKMREC
                            PROPIOS += IIf(objTipoTransporte.TIPO = "P", QKMREC, 0)
                            TERCEROS += IIf(objTipoTransporte.TIPO = "T", QKMREC, 0)
                        Next
                        Dim rowA As DataRow = dtKilometrosPorDiaBarras.NewRow
                        rowA("DIA") = Dia
                        rowA("TIPO") = objTipoTransporte.TIPO
                        rowA("CANTIDAD") = QKMREC
                        dtKilometrosPorDiaBarras.Rows.Add(rowA)
                    Next
                Next
                For Each objTipoTransporte As TipoTransporte In objListTipoTransporte
                    Dim rowB As DataRow = dtKilometrosPorTipoPie.NewRow
                    rowB("TIPO") = objTipoTransporte.TIPO
                    rowB("CANTIDAD") = ((objTipoTransporte.CANTIDAD * 100.0) / (TOTAL * 1.0))
                    dtKilometrosPorTipoPie.Rows.Add(rowB)
                Next

                Dim rowT As DataRow = dtKilometrosPorTipoTotales.NewRow
                rowT("TOTAL") = TOTAL
                rowT("PROPIOS") = PROPIOS
                rowT("TERCEROS") = TERCEROS
                dtKilometrosPorTipoTotales.Rows.Add(rowT)
            End If
            dtKilometrosPorTipoTotales.TableName = "dtKilometrosPorTipoTotales"
            dtKilometrosPorDiaBarras.TableName = "dtKilometrosPorDiaBarras"
            dtKilometrosPorTipoPie.TableName = "dtKilometrosPorTipoPie"
        End Sub
        Public Sub Indicador_Operativo_km_Estadistico(ByVal objParametro As Hashtable, ByVal FEC As DateTime, ByRef dtKilometrosEstadisticoP As DataTable, ByRef dtKilometrosEstadisticoT As DataTable)
            dtMes(dtKilometrosEstadisticoP)
            dtMes(dtKilometrosEstadisticoT)

            Dim objListDias As List(Of String) = fnDiasPorMes(FEC)

            Dim objListTipoTransporte As New List(Of TipoTransporte)
            objListTipoTransporte.Add(New TipoTransporte("P", "Propietario", 0))
            objListTipoTransporte.Add(New TipoTransporte("T", "Tercero", 0))


            Dim dtIndicadores As DataTable = New Indicadores_DAL().Indicador_Operativo_km_Recorrido(objParametro)
            If dtIndicadores IsNot Nothing Then
                For Each Tipo As TipoTransporte In objListTipoTransporte
                    If Tipo.TIPO = "P" Then
                        Dim dr As DataRow = dtKilometrosEstadisticoP.NewRow
                        dr("TIPO") = Tipo.DESCRIPCION
                        For Each Indicadores As DataRow In dtIndicadores.Rows
                            If Tipo.TIPO = Indicadores.Item("SINDRC") Then
                                Dim FGUIRM As String = "DIA" + Indicadores.Item("FGUIRM").ToString().Substring(6, 2)
                                dr(FGUIRM) = Indicadores.Item("QKMREC").ToString()
                            End If
                        Next
                        dtKilometrosEstadisticoP.Rows.Add(dr)
                    ElseIf Tipo.TIPO = "T" Then
                        Dim dr As DataRow = dtKilometrosEstadisticoT.NewRow
                        dr("TIPO") = Tipo.DESCRIPCION
                        For Each Indicadores As DataRow In dtIndicadores.Rows
                            If Tipo.TIPO = Indicadores.Item("SINDRC") Then
                                Dim FGUIRM As String = "DIA" + Indicadores.Item("FGUIRM").ToString().Substring(6, 2)
                                dr(FGUIRM) = Indicadores.Item("QKMREC").ToString()
                            End If
                        Next
                        dtKilometrosEstadisticoT.Rows.Add(dr)
                    End If
                Next
            End If
            dtKilometrosEstadisticoP.TableName = "dtKilometrosEstadisticoP"
            dtKilometrosEstadisticoT.TableName = "dtKilometrosEstadisticoT"
        End Sub

        Public Sub Indicador_Operativo_Peso_Traslado(ByVal objParametro As Hashtable, ByVal FEC As DateTime, ByRef dtPesosPorTipoTotales As DataTable, ByRef dtPesosPorDiaBarras As DataTable, ByRef dtPesosPorTipoPie As DataTable)
            Dim TOTAL, PROPIOS, TERCEROS As Double

            dtPesosPorTipoTotales.Columns.Add("TOTAL", Type.GetType("System.Double"))
            dtPesosPorTipoTotales.Columns.Add("PROPIOS", Type.GetType("System.Double"))
            dtPesosPorTipoTotales.Columns.Add("TERCEROS", Type.GetType("System.Double"))

            dtPesosPorDiaBarras.Columns.Add("DIA", Type.GetType("System.Int32"))
            dtPesosPorDiaBarras.Columns.Add("TIPO", Type.GetType("System.String"))
            dtPesosPorDiaBarras.Columns.Add("CANTIDAD", Type.GetType("System.Double"))

            dtPesosPorTipoPie.Columns.Add("TIPO", Type.GetType("System.String"))
            dtPesosPorTipoPie.Columns.Add("CANTIDAD", Type.GetType("System.Double"))

            Dim objListTipoTransporte As New List(Of TipoTransporte)
            objListTipoTransporte.Add(New TipoTransporte("P", "Propietario", 0))
            objListTipoTransporte.Add(New TipoTransporte("T", "Tercero", 0))
            Dim objListDias As List(Of String) = fnDiasPorMes(FEC)

            Dim dtIndicadores As DataTable = New Indicadores_DAL().Indicador_Operativo_Peso_Traslado(objParametro)
            If dtIndicadores IsNot Nothing Then
                For Each Dia As String In objListDias
                    For Each objTipoTransporte As TipoTransporte In objListTipoTransporte
            Dim FechaAux As String = FEC.Year.ToString() & "" & IIf(FEC.Month < 10, "0" & FEC.Month.ToString(), FEC.Month.ToString()) & "" & IIf(Dia < 10, "0" & Dia, Dia)
                        Dim expression As String = "FGUIRM = '" + FechaAux + "' AND SINDRC = '" + objTipoTransporte.TIPO + "'"
                        Dim sortOrder As String = "FGUIRM DESC"
                        Dim foundRows As DataRow()
                        foundRows = dtIndicadores.Select(expression, sortOrder)
                        Dim PMRCMC As Integer = 0
                        For i As Integer = 0 To foundRows.Length - 1
                            PMRCMC += foundRows(i)("PMRCMC")
                            objTipoTransporte.CANTIDAD += PMRCMC
                            TOTAL += PMRCMC
                            PROPIOS += IIf(objTipoTransporte.TIPO = "P", PMRCMC, 0)
                            TERCEROS += IIf(objTipoTransporte.TIPO = "T", PMRCMC, 0)
                        Next
                        Dim rowA As DataRow = dtPesosPorDiaBarras.NewRow
                        rowA("DIA") = Dia
                        rowA("TIPO") = objTipoTransporte.TIPO
                        rowA("CANTIDAD") = PMRCMC
                        dtPesosPorDiaBarras.Rows.Add(rowA)
                    Next
                Next
                For Each objTipoTransporte As TipoTransporte In objListTipoTransporte
                    Dim rowB As DataRow = dtPesosPorTipoPie.NewRow
                    rowB("TIPO") = objTipoTransporte.TIPO
                    rowB("CANTIDAD") = ((objTipoTransporte.CANTIDAD * 100.0) / (TOTAL * 1.0))
                    dtPesosPorTipoPie.Rows.Add(rowB)
                Next

                Dim rowT As DataRow = dtPesosPorTipoTotales.NewRow
                rowT("TOTAL") = TOTAL
                rowT("PROPIOS") = PROPIOS
                rowT("TERCEROS") = TERCEROS
                dtPesosPorTipoTotales.Rows.Add(rowT)
            End If
            dtPesosPorTipoTotales.TableName = "dtPesosPorTipoTotales"
            dtPesosPorDiaBarras.TableName = "dtPesosPorDiaBarras"
            dtPesosPorTipoPie.TableName = "dtPesosPorTipoPie"
        End Sub
        Public Sub Indicador_Operativo_Peso_Estadistico(ByVal objParametro As Hashtable, ByVal FEC As DateTime, ByRef dtPesosEstadisticoP As DataTable, ByRef dtPesosEstadisticoT As DataTable)
            dtMes(dtPesosEstadisticoP)
            dtMes(dtPesosEstadisticoT)

            Dim objListDias As List(Of String) = fnDiasPorMes(FEC)

            Dim objListTipoTransporte As New List(Of TipoTransporte)
            objListTipoTransporte.Add(New TipoTransporte("P", "Propietario", 0))
            objListTipoTransporte.Add(New TipoTransporte("T", "Tercero", 0))


            Dim dtIndicadores As DataTable = New Indicadores_DAL().Indicador_Operativo_Peso_Traslado(objParametro)
            If dtIndicadores IsNot Nothing Then
                For Each Tipo As TipoTransporte In objListTipoTransporte
                    If Tipo.TIPO = "P" Then
                        Dim dr As DataRow = dtPesosEstadisticoP.NewRow
                        dr("TIPO") = Tipo.DESCRIPCION
                        For Each Indicadores As DataRow In dtIndicadores.Rows
                            If Tipo.TIPO = Indicadores.Item("SINDRC") Then
                                Dim FGUIRM As String = "DIA" + Indicadores.Item("FGUIRM").ToString().Substring(6, 2)
                                dr(FGUIRM) = Indicadores.Item("PMRCMC").ToString()
                            End If
                        Next
                        dtPesosEstadisticoP.Rows.Add(dr)
                    ElseIf Tipo.TIPO = "T" Then
                        Dim dr As DataRow = dtPesosEstadisticoT.NewRow
                        dr("TIPO") = Tipo.DESCRIPCION
                        For Each Indicadores As DataRow In dtIndicadores.Rows
                            If Tipo.TIPO = Indicadores.Item("SINDRC") Then
                                Dim FGUIRM As String = "DIA" + Indicadores.Item("FGUIRM").ToString().Substring(6, 2)
                                dr(FGUIRM) = Indicadores.Item("PMRCMC").ToString()
                            End If
                        Next
                        dtPesosEstadisticoT.Rows.Add(dr)
                    End If
                Next
            End If
            dtPesosEstadisticoP.TableName = "dtPesosEstadisticoP"
            dtPesosEstadisticoT.TableName = "dtPesosEstadisticoT"
        End Sub

        Public Sub Indicador_Operativo_Viajes_Traslado(ByVal objParametro As Hashtable, ByVal FEC As DateTime, ByRef dtViajesPorTipoTotales As DataTable, ByRef dtViajesPorDiaBarras As DataTable, ByRef dtViajesPorTipoPie As DataTable)
            Dim TOTAL, PROPIOS, TERCEROS As Double

            dtViajesPorTipoTotales.Columns.Add("TOTAL", Type.GetType("System.Double"))
            dtViajesPorTipoTotales.Columns.Add("PROPIOS", Type.GetType("System.Double"))
            dtViajesPorTipoTotales.Columns.Add("TERCEROS", Type.GetType("System.Double"))

            dtViajesPorDiaBarras.Columns.Add("DIA", Type.GetType("System.Int32"))
            dtViajesPorDiaBarras.Columns.Add("TIPO", Type.GetType("System.String"))
            dtViajesPorDiaBarras.Columns.Add("CANTIDAD", Type.GetType("System.Double"))

            dtViajesPorTipoPie.Columns.Add("TIPO", Type.GetType("System.String"))
            dtViajesPorTipoPie.Columns.Add("CANTIDAD", Type.GetType("System.Double"))

            Dim objListTipoTransporte As New List(Of TipoTransporte)
            objListTipoTransporte.Add(New TipoTransporte("P", "Propietario", 0))
            objListTipoTransporte.Add(New TipoTransporte("T", "Tercero", 0))
            Dim objListDias As List(Of String) = fnDiasPorMes(FEC)

            Dim dtIndicadores As DataTable = New Indicadores_DAL().Indicador_Operativo_Viajes_Realizado(objParametro)
            If dtIndicadores IsNot Nothing Then
                For Each Dia As String In objListDias
                    For Each objTipoTransporte As TipoTransporte In objListTipoTransporte
            Dim FechaAux As String = FEC.Year.ToString() & "" & IIf(FEC.Month < 10, "0" & FEC.Month.ToString(), FEC.Month.ToString()) & "" & IIf(Dia < 10, "0" & Dia, Dia)
                        Dim expression As String = "FGUIRM = '" + FechaAux + "' AND SINDRC = '" + objTipoTransporte.TIPO + "'"
                        Dim sortOrder As String = "FGUIRM DESC"
                        Dim foundRows As DataRow()
                        foundRows = dtIndicadores.Select(expression, sortOrder)
                        Dim VIAJE As Integer = 0
                        For i As Integer = 0 To foundRows.Length - 1
                            VIAJE += foundRows(i)("VIAJE")
                            objTipoTransporte.CANTIDAD += VIAJE
                            TOTAL += VIAJE
                            PROPIOS += IIf(objTipoTransporte.TIPO = "P", VIAJE, 0)
                            TERCEROS += IIf(objTipoTransporte.TIPO = "T", VIAJE, 0)
                        Next
                        Dim rowA As DataRow = dtViajesPorDiaBarras.NewRow
                        rowA("DIA") = Dia
                        rowA("TIPO") = objTipoTransporte.TIPO
                        rowA("CANTIDAD") = VIAJE
                        dtViajesPorDiaBarras.Rows.Add(rowA)
                    Next
                Next
                For Each objTipoTransporte As TipoTransporte In objListTipoTransporte
                    Dim rowB As DataRow = dtViajesPorTipoPie.NewRow
                    rowB("TIPO") = objTipoTransporte.TIPO
                    rowB("CANTIDAD") = ((objTipoTransporte.CANTIDAD * 100.0) / (TOTAL * 1.0))
                    dtViajesPorTipoPie.Rows.Add(rowB)
                Next

                Dim rowT As DataRow = dtViajesPorTipoTotales.NewRow
                rowT("TOTAL") = TOTAL
                rowT("PROPIOS") = PROPIOS
                rowT("TERCEROS") = TERCEROS
                dtViajesPorTipoTotales.Rows.Add(rowT)
            End If
            dtViajesPorTipoTotales.TableName = "dtViajesPorTipoTotales"
            dtViajesPorDiaBarras.TableName = "dtViajesPorDiaBarras"
            dtViajesPorTipoPie.TableName = "dtViajesPorTipoPie"
        End Sub
        Public Sub Indicador_Operativo_Viajes_Estadistico(ByVal objParametro As Hashtable, ByVal FEC As DateTime, ByRef dtViajesEstadisticoP As DataTable, ByRef dtViajesEstadisticoT As DataTable)
            dtMes(dtViajesEstadisticoP)
            dtMes(dtViajesEstadisticoT)

            Dim objListDias As List(Of String) = fnDiasPorMes(FEC)

            Dim objListTipoTransporte As New List(Of TipoTransporte)
            objListTipoTransporte.Add(New TipoTransporte("P", "Propietario", 0))
            objListTipoTransporte.Add(New TipoTransporte("T", "Tercero", 0))


            Dim dtIndicadores As DataTable = New Indicadores_DAL().Indicador_Operativo_Viajes_Realizado(objParametro)
            If dtIndicadores IsNot Nothing Then
                For Each Tipo As TipoTransporte In objListTipoTransporte
                    If Tipo.TIPO = "P" Then
                        Dim dr As DataRow = dtViajesEstadisticoP.NewRow
                        dr("TIPO") = Tipo.DESCRIPCION
                        For Each Indicadores As DataRow In dtIndicadores.Rows
                            If Tipo.TIPO = Indicadores.Item("SINDRC") Then
                                Dim FGUIRM As String = "DIA" + Indicadores.Item("FGUIRM").ToString().Substring(6, 2)
                                dr(FGUIRM) = Indicadores.Item("VIAJE").ToString()
                            End If
                        Next
                        dtViajesEstadisticoP.Rows.Add(dr)
                    ElseIf Tipo.TIPO = "T" Then
                        Dim dr As DataRow = dtViajesEstadisticoT.NewRow
                        dr("TIPO") = Tipo.DESCRIPCION
                        For Each Indicadores As DataRow In dtIndicadores.Rows
                            If Tipo.TIPO = Indicadores.Item("SINDRC") Then
                                Dim FGUIRM As String = "DIA" + Indicadores.Item("FGUIRM").ToString().Substring(6, 2)
                                dr(FGUIRM) = Indicadores.Item("VIAJE").ToString()
                            End If
                        Next
                        dtViajesEstadisticoT.Rows.Add(dr)
                    End If
                Next
            End If
            dtViajesEstadisticoP.TableName = "dtViajesEstadisticoP"
            dtViajesEstadisticoT.TableName = "dtViajesEstadisticoT"
        End Sub

        Public Sub Indicador_Operativo_Cantidades_Traslado(ByVal objParametro As Hashtable, ByVal FEC As DateTime, ByRef dtCantidadesPorTipoTotales As DataTable, ByRef dtCantidadesPorDiaBarras As DataTable, ByRef dtCantidadesPorTipoPie As DataTable)
            Dim TOTAL, PROPIOS, TERCEROS As Double

            dtCantidadesPorTipoTotales.Columns.Add("TOTAL", Type.GetType("System.Double"))
            dtCantidadesPorTipoTotales.Columns.Add("PROPIOS", Type.GetType("System.Double"))
            dtCantidadesPorTipoTotales.Columns.Add("TERCEROS", Type.GetType("System.Double"))

            dtCantidadesPorDiaBarras.Columns.Add("DIA", Type.GetType("System.Int32"))
            dtCantidadesPorDiaBarras.Columns.Add("TIPO", Type.GetType("System.String"))
            dtCantidadesPorDiaBarras.Columns.Add("CANTIDAD", Type.GetType("System.Double"))

            dtCantidadesPorTipoPie.Columns.Add("TIPO", Type.GetType("System.String"))
            dtCantidadesPorTipoPie.Columns.Add("CANTIDAD", Type.GetType("System.Double"))

            Dim objListTipoTransporte As New List(Of TipoTransporte)
            objListTipoTransporte.Add(New TipoTransporte("P", "Propietario", 0))
            objListTipoTransporte.Add(New TipoTransporte("T", "Tercero", 0))
            Dim objListDias As List(Of String) = fnDiasPorMes(FEC)

            Dim dtIndicadores As DataTable = New Indicadores_DAL().Indicador_Operativo_Cantidad_Traslado(objParametro)
            If dtIndicadores IsNot Nothing Then
                For Each Dia As String In objListDias
                    For Each objTipoTransporte As TipoTransporte In objListTipoTransporte
            Dim FechaAux As String = FEC.Year.ToString() & "" & IIf(FEC.Month < 10, "0" & FEC.Month.ToString(), FEC.Month.ToString()) & "" & IIf(Dia < 10, "0" & Dia, Dia)
                        Dim expression As String = "FGUIRM = '" + FechaAux + "' AND SINDRC = '" + objTipoTransporte.TIPO + "'"
                        Dim sortOrder As String = "FGUIRM DESC"
                        Dim foundRows As DataRow()
                        foundRows = dtIndicadores.Select(expression, sortOrder)
                        Dim QMRCMC As Integer = 0
                        For i As Integer = 0 To foundRows.Length - 1
                            QMRCMC += foundRows(i)("QMRCMC")
                            objTipoTransporte.CANTIDAD += QMRCMC
                            TOTAL += QMRCMC
                            PROPIOS += IIf(objTipoTransporte.TIPO = "P", QMRCMC, 0)
                            TERCEROS += IIf(objTipoTransporte.TIPO = "T", QMRCMC, 0)
                        Next
                        Dim rowA As DataRow = dtCantidadesPorDiaBarras.NewRow
                        rowA("DIA") = Dia
                        rowA("TIPO") = objTipoTransporte.TIPO
                        rowA("CANTIDAD") = QMRCMC
                        dtCantidadesPorDiaBarras.Rows.Add(rowA)
                    Next
                Next
                For Each objTipoTransporte As TipoTransporte In objListTipoTransporte
                    Dim rowB As DataRow = dtCantidadesPorTipoPie.NewRow
                    rowB("TIPO") = objTipoTransporte.TIPO
                    rowB("CANTIDAD") = ((objTipoTransporte.CANTIDAD * 100.0) / (TOTAL * 1.0))
                    dtCantidadesPorTipoPie.Rows.Add(rowB)
                Next

                Dim rowT As DataRow = dtCantidadesPorTipoTotales.NewRow
                rowT("TOTAL") = TOTAL
                rowT("PROPIOS") = PROPIOS
                rowT("TERCEROS") = TERCEROS
                dtCantidadesPorTipoTotales.Rows.Add(rowT)
            End If
            dtCantidadesPorTipoTotales.TableName = "dtCantidadesPorTipoTotales"
            dtCantidadesPorDiaBarras.TableName = "dtCantidadesPorDiaBarras"
            dtCantidadesPorTipoPie.TableName = "dtCantidadesPorTipoPie"
        End Sub
        Public Sub Indicador_Operativo_Cantidades_Estadistico(ByVal objParametro As Hashtable, ByVal FEC As DateTime, ByRef dtCantidadesEstadisticoP As DataTable, ByRef dtCantidadesEstadisticoT As DataTable)
            dtMes(dtCantidadesEstadisticoP)
            dtMes(dtCantidadesEstadisticoT)

            Dim objListDias As List(Of String) = fnDiasPorMes(FEC)

            Dim objListTipoTransporte As New List(Of TipoTransporte)
            objListTipoTransporte.Add(New TipoTransporte("P", "Propietario", 0))
            objListTipoTransporte.Add(New TipoTransporte("T", "Tercero", 0))


            Dim dtIndicadores As DataTable = New Indicadores_DAL().Indicador_Operativo_Cantidad_Traslado(objParametro)
            If dtIndicadores IsNot Nothing Then
                For Each Tipo As TipoTransporte In objListTipoTransporte
                    If Tipo.TIPO = "P" Then
                        Dim dr As DataRow = dtCantidadesEstadisticoP.NewRow
                        dr("TIPO") = Tipo.DESCRIPCION
                        For Each Indicadores As DataRow In dtIndicadores.Rows
                            If Tipo.TIPO = Indicadores.Item("SINDRC") Then
                                Dim FGUIRM As String = "DIA" + Indicadores.Item("FGUIRM").ToString().Substring(6, 2)
                                dr(FGUIRM) = Indicadores.Item("QMRCMC").ToString()
                            End If
                        Next
                        dtCantidadesEstadisticoP.Rows.Add(dr)
                    ElseIf Tipo.TIPO = "T" Then
                        Dim dr As DataRow = dtCantidadesEstadisticoT.NewRow
                        dr("TIPO") = Tipo.DESCRIPCION
                        For Each Indicadores As DataRow In dtIndicadores.Rows
                            If Tipo.TIPO = Indicadores.Item("SINDRC") Then
                                Dim FGUIRM As String = "DIA" + Indicadores.Item("FGUIRM").ToString().Substring(6, 2)
                                dr(FGUIRM) = Indicadores.Item("QMRCMC").ToString()
                            End If
                        Next
                        dtCantidadesEstadisticoT.Rows.Add(dr)
                    End If
                Next
            End If
            dtCantidadesEstadisticoP.TableName = "dtCantidadesEstadisticoP"
            dtCantidadesEstadisticoT.TableName = "dtCantidadesEstadisticoT"
        End Sub

        Public Sub Indicador_Operativo_Rutas(ByVal objParametro As Hashtable, ByVal FEC As DateTime, ByRef dtRutasKilometros As DataTable, ByRef dtRutasPesos As DataTable, ByRef dtRutasViajes As DataTable, ByRef dtRutasCantidades As DataTable)

            dtRutasKilometros.Columns.Add("RUTA", Type.GetType("System.String"))
            dtRutasKilometros.Columns.Add("TIPO", Type.GetType("System.String"))
            dtRutasKilometros.Columns.Add("CANTIDAD", Type.GetType("System.Double"))

            dtRutasPesos.Columns.Add("RUTA", Type.GetType("System.String"))
            dtRutasPesos.Columns.Add("TIPO", Type.GetType("System.String"))
            dtRutasPesos.Columns.Add("CANTIDAD", Type.GetType("System.Double"))

            dtRutasViajes.Columns.Add("RUTA", Type.GetType("System.String"))
            dtRutasViajes.Columns.Add("TIPO", Type.GetType("System.String"))
            dtRutasViajes.Columns.Add("CANTIDAD", Type.GetType("System.Double"))

            dtRutasCantidades.Columns.Add("RUTA", Type.GetType("System.String"))
            dtRutasCantidades.Columns.Add("TIPO", Type.GetType("System.String"))
            dtRutasCantidades.Columns.Add("CANTIDAD", Type.GetType("System.Double"))

            Dim MaxBarras As Integer = 19
            Dim dtIndicadores As DataTable = New Indicadores_DAL().Indicador_Operativo_Rutas(objParametro)
            If dtIndicadores IsNot Nothing Then
                If dtIndicadores.Rows.Count > MaxBarras Then
                    Dim dtIndicadoresAux As DataTable
                    dtIndicadoresAux = FilterSortData(dtIndicadores, "", "QKMREC DESC")
                    For i As Integer = 0 To MaxBarras
                        Dim row1 As DataRow = dtRutasKilometros.NewRow
                        row1("RUTA") = dtIndicadoresAux.Rows(i).Item("RUTA").ToString()
                        row1("TIPO") = "Kilometraje"
                        row1("CANTIDAD") = dtIndicadoresAux.Rows(i).Item("QKMREC").ToString()
                        dtRutasKilometros.Rows.Add(row1)
                    Next
                    Dim QKMREC As Double = 0
                    For i As Integer = MaxBarras + 1 To dtIndicadoresAux.Rows.Count - 1
                        QKMREC += dtIndicadoresAux.Rows(i).Item("QKMREC").ToString()
                    Next
                    If dtIndicadoresAux.Rows.Count > 15 Then
                        Dim row1 As DataRow = dtRutasKilometros.NewRow
                        row1("RUTA") = "OTROS"
                        row1("TIPO") = "Kilometraje"
                        row1("CANTIDAD") = QKMREC
                        dtRutasKilometros.Rows.Add(row1)
                    End If
                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    dtIndicadoresAux = FilterSortData(dtIndicadores, "", "PMRCMC DESC")
                    For i As Integer = 0 To MaxBarras
                        Dim row2 As DataRow = dtRutasPesos.NewRow
                        row2("RUTA") = dtIndicadoresAux.Rows(i).Item("RUTA").ToString()
                        row2("TIPO") = "Peso"
                        row2("CANTIDAD") = dtIndicadoresAux.Rows(i).Item("PMRCMC").ToString()
                        dtRutasPesos.Rows.Add(row2)
                    Next
                    Dim PMRCMC As Double = 0
                    For i As Integer = MaxBarras + 1 To dtIndicadoresAux.Rows.Count - 1
                        PMRCMC += dtIndicadoresAux.Rows(i).Item("PMRCMC").ToString()
                    Next
                    If dtIndicadoresAux.Rows.Count > 15 Then
                        Dim row2 As DataRow = dtRutasPesos.NewRow
                        row2("RUTA") = "OTROS"
                        row2("TIPO") = "Peso"
                        row2("CANTIDAD") = PMRCMC
                        dtRutasPesos.Rows.Add(row2)
                    End If
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    dtIndicadoresAux = FilterSortData(dtIndicadores, "", "VIAJE DESC")
                    For i As Integer = 0 To MaxBarras
                        Dim row3 As DataRow = dtRutasViajes.NewRow
                        row3("RUTA") = dtIndicadoresAux.Rows(i).Item("RUTA").ToString()
                        row3("TIPO") = "Viajes"
                        row3("CANTIDAD") = dtIndicadoresAux.Rows(i).Item("VIAJE").ToString()
                        dtRutasViajes.Rows.Add(row3)
                    Next
                    Dim VIAJE As Double = 0
                    For i As Integer = MaxBarras + 1 To dtIndicadoresAux.Rows.Count - 1
                        VIAJE += dtIndicadoresAux.Rows(i).Item("VIAJE").ToString()
                    Next
                    If dtIndicadoresAux.Rows.Count > 15 Then
                        Dim row3 As DataRow = dtRutasViajes.NewRow
                        row3("RUTA") = "OTROS"
                        row3("TIPO") = "Viajes"
                        row3("CANTIDAD") = VIAJE
                        dtRutasViajes.Rows.Add(row3)
                    End If
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    dtIndicadoresAux = FilterSortData(dtIndicadores, "", "QMRCMC DESC")
                    For i As Integer = 0 To MaxBarras
                        Dim row4 As DataRow = dtRutasCantidades.NewRow
                        row4("RUTA") = dtIndicadoresAux.Rows(i).Item("RUTA").ToString()
                        row4("TIPO") = "Cantidad"
                        row4("CANTIDAD") = dtIndicadoresAux.Rows(i).Item("QMRCMC").ToString()
                        dtRutasCantidades.Rows.Add(row4)
                    Next
                    Dim QMRCMC As Double = 0
                    For i As Integer = MaxBarras + 1 To dtIndicadoresAux.Rows.Count - 1
                        QMRCMC += dtIndicadoresAux.Rows(i).Item("QMRCMC").ToString()
                    Next
                    If dtIndicadoresAux.Rows.Count > 15 Then
                        Dim row4 As DataRow = dtRutasCantidades.NewRow
                        row4("RUTA") = "OTROS"
                        row4("TIPO") = "Cantidad"
                        row4("CANTIDAD") = QMRCMC
                        dtRutasCantidades.Rows.Add(row4)
                    End If
                Else
                    For Each Ruta As DataRow In dtIndicadores.Rows
                        Dim row1 As DataRow = dtRutasKilometros.NewRow
                        row1("RUTA") = Ruta.Item("RUTA").ToString()
                        row1("TIPO") = "Kilometraje"
                        row1("CANTIDAD") = Ruta.Item("QKMREC").ToString()
                        dtRutasKilometros.Rows.Add(row1)

                        Dim row2 As DataRow = dtRutasPesos.NewRow
                        row2("RUTA") = Ruta.Item("RUTA").ToString()
                        row2("TIPO") = "Peso"
                        row2("CANTIDAD") = Ruta.Item("PMRCMC").ToString()
                        dtRutasPesos.Rows.Add(row2)

                        Dim row3 As DataRow = dtRutasViajes.NewRow
                        row3("RUTA") = Ruta.Item("RUTA").ToString()
                        row3("TIPO") = "Viajes"
                        row3("CANTIDAD") = Ruta.Item("VIAJE").ToString()
                        dtRutasViajes.Rows.Add(row3)

                        Dim row4 As DataRow = dtRutasCantidades.NewRow
                        row4("RUTA") = Ruta.Item("RUTA").ToString()
                        row4("TIPO") = "Cantidad"
                        row4("CANTIDAD") = Ruta.Item("QMRCMC").ToString()
                        dtRutasCantidades.Rows.Add(row4)
                    Next
                End If
            End If
            dtRutasKilometros.TableName = "dtRutasKilometros"
            dtRutasPesos.TableName = "dtRutasPesos"
            dtRutasViajes.TableName = "dtRutasViajes"
            dtRutasCantidades.TableName = "dtRutasCantidades"
        End Sub

        Public Function Indicador_Operativo(ByVal objParametro As Hashtable, ByVal FEC As DateTime) As DataSet
            Dim dtKilometrosPorTipoTotales As New DataTable
            Dim dtKilometrosPorDiaBarras As New DataTable
            Dim dtKilometrosPorTipoPie As New DataTable
            Dim dtKilometrosEstadisticoP As New DataTable
            Dim dtKilometrosEstadisticoT As New DataTable

            Dim dtPesosPorTipoTotales As New DataTable
            Dim dtPesosPorDiaBarras As New DataTable
            Dim dtPesosPorTipoPie As New DataTable
            Dim dtPesosEstadisticoP As New DataTable
            Dim dtPesosEstadisticoT As New DataTable

            Dim dtViajesPorTipoTotales As New DataTable
            Dim dtViajesPorDiaBarras As New DataTable
            Dim dtViajesPorTipoPie As New DataTable
            Dim dtViajesEstadisticoP As New DataTable
            Dim dtViajesEstadisticoT As New DataTable

            Dim dtCantidadesPorTipoTotales As New DataTable
            Dim dtCantidadesPorDiaBarras As New DataTable
            Dim dtCantidadesPorTipoPie As New DataTable
            Dim dtCantidadesEstadisticoP As New DataTable
            Dim dtCantidadesEstadisticoT As New DataTable

            Dim dtRutasKilometros As New DataTable
            Dim dtRutasPesos As New DataTable
            Dim dtRutasViajes As New DataTable
            Dim dtRutasCantidades As New DataTable

            Indicador_Operativo_km_Recorrido(objParametro, FEC, dtKilometrosPorTipoTotales, dtKilometrosPorDiaBarras, dtKilometrosPorTipoPie)
            Indicador_Operativo_km_Estadistico(objParametro, FEC, dtKilometrosEstadisticoP, dtKilometrosEstadisticoT)

            Indicador_Operativo_Peso_Traslado(objParametro, FEC, dtPesosPorTipoTotales, dtPesosPorDiaBarras, dtPesosPorTipoPie)
            Indicador_Operativo_Peso_Estadistico(objParametro, FEC, dtPesosEstadisticoP, dtPesosEstadisticoT)

            Indicador_Operativo_Viajes_Traslado(objParametro, FEC, dtViajesPorTipoTotales, dtViajesPorDiaBarras, dtViajesPorTipoPie)
            Indicador_Operativo_Viajes_Estadistico(objParametro, FEC, dtViajesEstadisticoP, dtViajesEstadisticoT)

            Indicador_Operativo_Cantidades_Traslado(objParametro, FEC, dtCantidadesPorTipoTotales, dtCantidadesPorDiaBarras, dtCantidadesPorTipoPie)
            Indicador_Operativo_Cantidades_Estadistico(objParametro, FEC, dtCantidadesEstadisticoP, dtCantidadesEstadisticoT)

            Indicador_Operativo_Rutas(objParametro, FEC, dtRutasKilometros, dtRutasPesos, dtRutasViajes, dtRutasCantidades)

            Dim ds As New DataSet
            ds.Tables.Add(dtKilometrosEstadisticoP.Copy)
            ds.Tables.Add(dtKilometrosEstadisticoT.Copy)
            ds.Tables.Add(dtKilometrosPorTipoTotales.Copy)
            ds.Tables.Add(dtKilometrosPorDiaBarras.Copy)
            ds.Tables.Add(dtKilometrosPorTipoPie.Copy)

            ds.Tables.Add(dtPesosEstadisticoP.Copy)
            ds.Tables.Add(dtPesosEstadisticoT.Copy)
            ds.Tables.Add(dtPesosPorTipoTotales.Copy)
            ds.Tables.Add(dtPesosPorDiaBarras.Copy)
            ds.Tables.Add(dtPesosPorTipoPie.Copy)

            ds.Tables.Add(dtViajesEstadisticoP.Copy)
            ds.Tables.Add(dtViajesEstadisticoT.Copy)
            ds.Tables.Add(dtViajesPorTipoTotales.Copy)
            ds.Tables.Add(dtViajesPorDiaBarras.Copy)
            ds.Tables.Add(dtViajesPorTipoPie.Copy)

            ds.Tables.Add(dtCantidadesEstadisticoP.Copy)
            ds.Tables.Add(dtCantidadesEstadisticoT.Copy)
            ds.Tables.Add(dtCantidadesPorTipoTotales.Copy)
            ds.Tables.Add(dtCantidadesPorDiaBarras.Copy)
            ds.Tables.Add(dtCantidadesPorTipoPie.Copy)

            ds.Tables.Add(dtRutasKilometros.Copy)
            ds.Tables.Add(dtRutasPesos.Copy)
            ds.Tables.Add(dtRutasViajes.Copy)
            ds.Tables.Add(dtRutasCantidades.Copy)
            Return ds
        End Function

        Public Function Indicador_Operativo_km_Recorrido(ByVal objParametro As Hashtable) As DataTable
            Return New Indicadores_DAL().Indicador_Operativo_km_Recorrido(objParametro)
        End Function
    End Class
End Namespace
