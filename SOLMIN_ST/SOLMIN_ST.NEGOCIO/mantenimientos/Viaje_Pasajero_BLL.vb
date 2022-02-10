Imports SOLMIN_ST.DATOS.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Namespace mantenimientos
    Public Class Viaje_Pasajero_BLL
        Enum MEDIO_TRANSPORTE
            AEREO = 1
            FLUVIAL = 5
            TERRESTRE = 4
        End Enum

        Public Function Insertar_Viaje_Pasajero(ByVal ObjViaje_Pasajero As Viaje_Pasajero) As Integer
            Dim oDatos As New Viaje_Pasajero_DAL
            Return oDatos.Insertar_Viaje_Pasajero(ObjViaje_Pasajero)
        End Function

        Public Function Listar_Viaje_Pasajero(ByVal ObjViaje_Pasajero As Viaje_Pasajero) As List(Of Viaje_Pasajero)
            Dim oDatos As New Viaje_Pasajero_DAL

            Dim loEntidad As List(Of Viaje_Pasajero)
            loEntidad = oDatos.Listar_Viaje_Pasajero(ObjViaje_Pasajero)

            If loEntidad.Count > 1 Then
                Dim ObjEntidad, ObjTemp As Viaje_Pasajero
                ObjTemp = Nothing

                For Each ObjEntidad In loEntidad
                    If (Not ObjTemp Is Nothing) AndAlso ObjEntidad.PNNPRGVJ = ObjTemp.PNNPRGVJ AndAlso ObjEntidad.PSORIGEN = ObjTemp.PSORIGEN AndAlso ObjEntidad.PSDESTINO = ObjTemp.PSDESTINO Then
                        ObjEntidad.PSORIGEN = ""
                        ObjEntidad.PSDESTINO = ""
                    Else
                        ObjTemp = ObjEntidad
                    End If

                Next
            End If

            Return loEntidad
        End Function
        Public Function Actualizar_Viaje_Pasajero(ByVal Obe_Viaje_Pasajero As Viaje_Pasajero) As Integer
            Dim oDatos As New Viaje_Pasajero_DAL
            Return oDatos.Actualizar_Viaje_Pasajero(Obe_Viaje_Pasajero)
        End Function

        Public Function Eliminar_Viaje_Pasajero(ByVal Obe_Viaje_Pasajero As Viaje_Pasajero) As Integer
            Dim oDatos As New Viaje_Pasajero_DAL
            Return oDatos.Eliminar_Viaje_Pasajero(Obe_Viaje_Pasajero)
        End Function

        Public Function RptListar_Programacion_Viaje(ByVal Obe_Viaje_Pasajero As Viaje_Pasajero) As DataTable
            Dim oDatos As New Viaje_Pasajero_DAL
            Dim table As DataTable
            table = oDatos.RptListar_Programacion_Viaje(Obe_Viaje_Pasajero)
            For indice As Integer = 0 To table.Rows.Count - 1
                table.Rows(indice).Item("FCHPSA") = Utility.CFecha_de_8_a_10(table.Rows(indice).Item("FCHPSA").ToString)
                table.Rows(indice).Item("FSLDRT") = Utility.CFecha_de_8_a_10(table.Rows(indice).Item("FSLDRT").ToString)
                table.Rows(indice).Item("FVCPSP") = Utility.CFecha_de_8_a_10(table.Rows(indice).Item("FVCPSP").ToString)
            Next
            Return table
        End Function

        Public Function RptListar_PasajerosXGuia(ByVal Obe_Viaje_Pasajero As Viaje_Pasajero) As DataSet
            Dim oDatos As New Viaje_Pasajero_DAL
            Return oDatos.RptListar_PasajerosXGuia(Obe_Viaje_Pasajero)

        End Function

        Public Function RptListar_Pasajeros_Contratista_Cliente(ByVal Obe_Viaje_Pasajero As Viaje_Pasajero) As DataTable
            Dim oDatos As New Viaje_Pasajero_DAL
            Return oDatos.RptListar_Pasajeros_Contratista_Cliente(Obe_Viaje_Pasajero)

        End Function

        Public Function CreaResumenMedioEnvio(ByVal dt As DataTable) As DataTable
            Dim dtResult As New DataTable("MedioEnvio")
            dtResult.Columns.Add("CLIENTE", System.Type.GetType("System.String"))
            dtResult.Columns.Add("CONTRATISTA", System.Type.GetType("System.String"))
            dtResult.Columns.Add("TERRESTRE", System.Type.GetType("System.String"))
            dtResult.Columns.Add("AEREO", System.Type.GetType("System.String"))
            dtResult.Columns.Add("FLUVIAL", System.Type.GetType("System.String"))

            dtResult.Columns("TERRESTRE").Caption = "SUBTOTAL"
            dtResult.Columns("AEREO").Caption = "SUBTOTAL"
            dtResult.Columns("FLUVIAL").Caption = "SUBTOTAL"

            Dim dvR As New DataView(dt)
            dvR.Sort = "CCLNT,TPRVCL ASC"
            Dim objResumen As DataTable = dvR.ToTable()
            Dim drSelect As DataRow()
            Dim objDataRow As DataRow
            Dim TotalA, TotalT, TotalF As Integer

            For i As Integer = 0 To objResumen.Rows.Count - 1

                TotalA = 0
                TotalT = 0
                TotalF = 0

                drSelect = objResumen.Select("CCLNT = '" + objResumen.Rows(i)("CCLNT").ToString.Trim + "' AND TPRVCL = '" + objResumen.Rows(i)("TPRVCL").ToString + "'")
                For Each dr As DataRow In drSelect
                    Select Case dr("CMEDTR")
                        Case MEDIO_TRANSPORTE.AEREO
                            TotalA += 1
                        Case MEDIO_TRANSPORTE.TERRESTRE
                            TotalT += 1
                        Case MEDIO_TRANSPORTE.FLUVIAL
                            TotalF += 1
                    End Select
                Next

                objDataRow = dtResult.NewRow
                objDataRow.Item("CLIENTE") = objResumen.Rows(i)("TCMPCL").ToString.Trim
                objDataRow.Item("CONTRATISTA") = objResumen.Rows(i)("TPRVCL").ToString.Trim
                objDataRow.Item("TERRESTRE") = TotalT.ToString
                objDataRow.Item("AEREO") = TotalA.ToString
                objDataRow.Item("FLUVIAL") = TotalF.ToString
                dtResult.Rows.Add(objDataRow)
                i = i + drSelect.Length - 1
            Next

            dvR = New DataView(dtResult)
            dvR.Sort = "CLIENTE,CONTRATISTA ASC"
            Return dvR.ToTable()

        End Function

        Public Function CreaResumenRuta(ByVal dt As DataTable) As DataTable
            Dim dtResult As New DataTable("Ruta")
            dtResult.Columns.Add("CLIENTE", System.Type.GetType("System.String"))
            dtResult.Columns.Add("CONTRATISTA", System.Type.GetType("System.String"))
            dtResult.Columns.Add("RUTA", System.Type.GetType("System.String"))
            dtResult.Columns.Add("CANTIDAD PASAJERO", System.Type.GetType("System.String"))

            dtResult.Columns("CANTIDAD PASAJERO").Caption = "SUBTOTAL"

            Dim dvR As New DataView(dt)
            dvR.Sort = "CCLNT,TPRVCL,RUTA ASC"
            Dim objResumen As DataTable = dvR.ToTable()
            Dim drSelect As DataRow()
            Dim objDataRow As DataRow

            For i As Integer = 0 To objResumen.Rows.Count - 1

                drSelect = objResumen.Select("CCLNT = '" + objResumen.Rows(i)("CCLNT").ToString.Trim + "' AND TPRVCL = '" + objResumen.Rows(i)("TPRVCL").ToString + "' AND RUTA = '" + objResumen.Rows(i)("RUTA").ToString + "'")

                objDataRow = dtResult.NewRow
                objDataRow.Item("CLIENTE") = objResumen.Rows(i)("TCMPCL").ToString.Trim
                objDataRow.Item("CONTRATISTA") = objResumen.Rows(i)("TPRVCL").ToString.Trim
                objDataRow.Item("RUTA") = objResumen.Rows(i)("RUTA").ToString.Trim
                objDataRow.Item("CANTIDAD PASAJERO") = drSelect.Length
                dtResult.Rows.Add(objDataRow)
                i = i + drSelect.Length - 1
            Next

            dvR = New DataView(dtResult)
            dvR.Sort = "CLIENTE,CONTRATISTA,RUTA ASC"
            Return dvR.ToTable()

        End Function

        Public Function CreaResumenTransportista(ByVal dt As DataTable) As DataTable
            Dim dtResult As New DataTable("Transportista")
            dtResult.Columns.Add("CLIENTE", System.Type.GetType("System.String"))
            dtResult.Columns.Add("CONTRATISTA", System.Type.GetType("System.String"))
            dtResult.Columns.Add("TRANSPORTISTA", System.Type.GetType("System.String"))
            dtResult.Columns.Add("CANTIDAD PASAJERO", System.Type.GetType("System.String"))
            dtResult.Columns.Add("NRO VIAJES", System.Type.GetType("System.String"))

            dtResult.Columns("CANTIDAD PASAJERO").Caption = "SUBTOTAL"
            dtResult.Columns("NRO VIAJES").Caption = "SUBTOTAL"

            Dim dvR As New DataView(dt)
            dvR.Sort = "CCLNT,TPRVCL,CTRMNC ASC"
            Dim objResumen As DataTable = dvR.ToTable()
            Dim drSelect As DataRow()
            Dim objDataRow As DataRow
            For i As Integer = 0 To objResumen.Rows.Count - 1
                drSelect = objResumen.Select("CCLNT = '" + objResumen.Rows(i)("CCLNT").ToString.Trim + "' AND TPRVCL = '" + objResumen.Rows(i)("TPRVCL").ToString + "' AND CTRMNC = '" + objResumen.Rows(i)("CTRMNC").ToString + "'")
                objDataRow = dtResult.NewRow
                objDataRow.Item("CLIENTE") = objResumen.Rows(i)("TCMPCL").ToString.Trim
                objDataRow.Item("CONTRATISTA") = objResumen.Rows(i)("TPRVCL").ToString.Trim
                objDataRow.Item("TRANSPORTISTA") = objResumen.Rows(i)("TCMTRT").ToString.Trim
        objDataRow.Item("CANTIDAD PASAJERO") = drSelect.Length
        If dt.Rows(0).Item("NGUITR") = 0 Then
          objDataRow.Item("NRO VIAJES") = 0
        Else
          objDataRow.Item("NRO VIAJES") = SelectDistinct(RowToDatatable(drSelect, objResumen), "NGUITR").Rows.Count

        End If

        dtResult.Rows.Add(objDataRow)
        i = i + drSelect.Length - 1
      Next

            dvR = New DataView(dtResult)
            dvR.Sort = "CLIENTE,CONTRATISTA,TRANSPORTISTA ASC"
            Return dvR.ToTable()

        End Function

        Public Function SelectDistinct(ByVal SourceTable As DataTable, ByVal ParamArray FieldNames() As String) As DataTable
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

        Private Function fieldValuesAreEqual(ByVal lastValues() As Object, ByVal currentRow As DataRow, ByVal fieldNames() As String) As Boolean
            Dim areEqual As Boolean = True

            For i As Integer = 0 To fieldNames.Length - 1
                If lastValues(i) Is Nothing OrElse Not lastValues(i).Equals(currentRow(fieldNames(i))) Then
                    areEqual = False
                    Exit For
                End If
            Next

            Return areEqual
        End Function

        Private Function createRowClone(ByVal sourceRow As DataRow, ByVal newRow As DataRow, ByVal fieldNames() As String) As DataRow
            For Each field As String In fieldNames
                newRow(field) = sourceRow(field)
            Next

            Return newRow
        End Function

        Private Sub setLastValues(ByVal lastValues() As Object, ByVal sourceRow As DataRow, ByVal fieldNames() As String)
            For i As Integer = 0 To fieldNames.Length - 1
                lastValues(i) = sourceRow(fieldNames(i))
            Next
        End Sub

        Private Function RowToDatatable(ByVal drSelect As DataRow(), ByVal tbl As DataTable) As DataTable
            Dim dt As New DataTable
            dt = tbl.Clone
            For Each row As DataRow In drSelect
                dt.ImportRow(row)
            Next
            Return dt
        End Function
    End Class
End Namespace

