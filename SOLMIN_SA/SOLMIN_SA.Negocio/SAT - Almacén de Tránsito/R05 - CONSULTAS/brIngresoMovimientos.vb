Imports RANSA.DATA
Imports RANSA.TypeDef

Public Class brIngresoMovimientos
    Dim oDatos As New daIngresoMovimientos

    Public Function ListarMovimientoFecha(ByVal oIngresoMovimientos As beIngresoMovimientos) As List(Of beIngresoMovimientos)

        Dim lobe_IngresoMovimientos As New List(Of beIngresoMovimientos)
        lobe_IngresoMovimientos = oDatos.ListarMovimientoFecha(oIngresoMovimientos)

        Return lobe_IngresoMovimientos
    End Function

    Public Function ListarMovimientoFecha_OC(ByVal oIngresoMovimientos As beIngresoMovimientos) As List(Of beIngresoMovimientos)
        Return oDatos.ListarMovimientoFecha_OC(oIngresoMovimientos)
    End Function

    Public Function CrearResumenes_Movimientos(ByVal ObjDetalle As DataTable) As DataSet
        Dim dsReturn As New DataSet
        Dim objDataSet As New DataSet
        'Dim objFiltros As New DataTable
        Dim objResumen As New DataTable
        Dim objResumenFin As New DataTable

        Dim objObjDetalle_Planta As DataTable = ObjDetalle.Copy
        Dim Index As Integer = 0

        For i As Integer = 0 To ObjDetalle.Columns.Count - 1
            If ObjDetalle.Columns(i).ColumnName <> "PSPLANTA" _
            AndAlso ObjDetalle.Columns(i).ColumnName <> "PNCCLNT" _
            AndAlso ObjDetalle.Columns(i).ColumnName <> "PSCREFFW" _
             AndAlso ObjDetalle.Columns(i).ColumnName <> "PNNSEQIN" _
             AndAlso ObjDetalle.Columns(i).ColumnName <> "PSTCMPCL" _
                AndAlso ObjDetalle.Columns(i).ColumnName <> "PSTLUGEN" _
                  AndAlso ObjDetalle.Columns(i).ColumnName <> "PNQPEPQT" _
                    AndAlso ObjDetalle.Columns(i).ColumnName <> "PNQVLBTO" _
                      AndAlso ObjDetalle.Columns(i).ColumnName <> "PNQBLTSR" Then

                objObjDetalle_Planta.Columns.Remove(ObjDetalle.Columns(i).ColumnName)
                'Index = Index + 1
            Else
                Index = Index + 1
            End If
        Next
        Dim TotalKG, TotalM3, TotalBUL As Double
        Dim drSelect As DataRow() = Nothing
        Dim objDataRow As DataRow = Nothing
        Dim strCliente As String = ""
        Dim strPlanta As String = ""
        Dim strPlantaAnteror As String = ""
        'Struct Resumenes
        objResumen.Columns.Add(New DataColumn("CLIENTE", GetType(System.String)))
        objResumen.Columns.Add(New DataColumn("LOTE", GetType(System.String)))
        objResumen.Columns.Add(New DataColumn("PLANTA", GetType(System.String)))
        objResumen.Columns.Add(New DataColumn("KG", GetType(System.Double)))
        objResumen.Columns.Add(New DataColumn("M3", GetType(System.Double)))
        objResumen.Columns.Add(New DataColumn("BUL", GetType(System.Double)))
        objResumenFin.Columns.Add(New DataColumn("CLIENTE", GetType(System.String)))
        objResumenFin.Columns.Add(New DataColumn("LOTE", GetType(System.String)))

        'Debe de haberse Ordenado por Planta Y lote
        Dim dv As New DataView
        dv.Table = objObjDetalle_Planta
        dv.Sort = "PSPLANTA,PSTCMPCL, PSTLUGEN ASC"
        objObjDetalle_Planta = dv.ToTable()
        For i As Integer = 0 To objObjDetalle_Planta.Rows.Count - 1
            strPlanta = objObjDetalle_Planta.Rows(i).Item("PSPLANTA")
            strCliente = objObjDetalle_Planta.Rows(i).Item("PSTCMPCL")
            drSelect = objObjDetalle_Planta.Select("PSTCMPCL = '" + strCliente.Trim + "' AND PSPLANTA = '" + strPlanta.Trim + "' AND PSTLUGEN = '" + objObjDetalle_Planta.Rows(i)("PSTLUGEN").ToString.Trim + "'")
            TotalKG = 0
            TotalM3 = 0
            TotalBUL = 0


            Dim dt As DataTable = SelectDistinct(RowToDatatable(drSelect, objObjDetalle_Planta), "PSPLANTA", "PSTCMPCL", "PSCREFFW", "PNNSEQIN", "PNQPEPQT", "PNQVLBTO", "PNQBLTSR")

            For Each dr As DataRow In dt.Rows
                TotalKG += Convert.ToDouble(dr("PNQPEPQT"))
                TotalM3 += Convert.ToDouble(dr("PNQVLBTO"))
                TotalBUL += Convert.ToDouble(dr("PNQBLTSR"))
            Next

            'For Each dr As DataRow In drSelect
            '    TotalKG += Convert.ToDouble(dr("QPEPQT"))
            '    TotalM3 += Convert.ToDouble(dr("QVLBTO"))
            '    TotalBUL += Convert.ToDouble(dr("QBLTSR"))
            'Next

            If drSelect.Length > 0 Then
                objDataRow = objResumen.NewRow
                objDataRow.Item("CLIENTE") = objObjDetalle_Planta.Rows(i)("PSTCMPCL").ToString.Trim
                objDataRow.Item("LOTE") = objObjDetalle_Planta.Rows(i)("PSTLUGEN").ToString.Trim
                objDataRow.Item("PLANTA") = objObjDetalle_Planta.Rows(i)("PSPLANTA").ToString.Trim
                objDataRow.Item("KG") = TotalKG
                objDataRow.Item("M3") = TotalM3
                objDataRow.Item("BUL") = TotalBUL
                objResumen.Rows.Add(objDataRow)
                If strPlanta <> strPlantaAnteror Then
                    objResumenFin.Columns.Add(New DataColumn("PESO_" + strPlanta.Trim, GetType(System.String)))
                    objResumenFin.Columns.Add(New DataColumn("VOLUMEN_" + strPlanta.Trim, GetType(System.String)))
                    objResumenFin.Columns.Add(New DataColumn("BULTO_" + strPlanta.Trim, GetType(System.String)))
                    strPlantaAnteror = strPlanta
                End If
                i = i + drSelect.Length - 1
            End If
        Next
        '' Recorro los resumene para Construir la Tabla
        Dim dvR As New DataView(objResumen)
        dvR.Sort = "CLIENTE,LOTE ASC"
        objResumen = dvR.ToTable()
        '  Debe estar Ordenado Por Lote
        For i As Integer = 0 To objResumen.Rows.Count - 1
            drSelect = objResumen.Select("CLIENTE = '" + objResumen.Rows(i)("CLIENTE").ToString.Trim + "' AND LOTE = '" + objResumen.Rows(i)("LOTE").ToString + "'")
            objDataRow = objResumenFin.NewRow
            objDataRow.Item("CLIENTE") = objResumen.Rows(i)("CLIENTE").ToString.Trim
            objDataRow.Item("LOTE") = objResumen.Rows(i)("LOTE").ToString.Trim

            objResumenFin.Rows.Add(objDataRow)
            For Each dr As DataRow In drSelect
                objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item("PESO_" + dr("PLANTA").ToString.Trim) = dr("KG").ToString.Trim
                objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item("VOLUMEN_" + dr("PLANTA").ToString.Trim) = dr("M3").ToString.Trim
                objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item("BULTO_" + dr("PLANTA").ToString.Trim) = dr("BUL").ToString.Trim
                objResumenFin.AcceptChanges()
            Next
            i = i + drSelect.Length - 1
        Next

        ObjDetalle.TableName = "DT_Detalle"
        'objResumenFin.Namespace = "Movimiento Mercaderia"
        objResumenFin.TableName = "DT_Resumen"
        objResumenFin.Namespace = "Resumen Lote"
        'Dim dvRi As New DataView(ObjDetalle)
        'dvRi.Sort = "ROWNUMBER ASC"
        ''ObjDetalle = dvRi.ToTable()
        dsReturn.Tables.Add(ObjDetalle.Copy())
        dsReturn.Tables.Add(objResumenFin)
        dsReturn.Tables.Add(CrearResumenes_Movimiento_OrdenCompra(ObjDetalle.Copy()))
        dsReturn.Tables.Add(CrearResumenes_Inventario_SentidoCarga(ObjDetalle.Copy()))


        'Añade el Table de Clientes Distic
        Dim oDtvTemp As DataView = New DataView(objResumen)
        Dim oTdtTemp As New DataTable
        oTdtTemp = oDtvTemp.ToTable(True, "CLIENTE")
        oTdtTemp.TableName = "DT_Clientes"
        dsReturn.Tables.Add(oTdtTemp.Copy())
        Return (dsReturn)
    End Function

    Public Function CrearResumenes_Movimiento_OrdenCompra(ByVal ObjDetalle As DataTable) As DataTable
        Dim objResumen As New DataTable
        Dim objResumenFin As New DataTable
        Dim objObjDetalle_Planta As DataTable = ObjDetalle.Copy
        Dim Index As Integer = 0

        For i As Integer = 0 To ObjDetalle.Columns.Count - 1
            If ObjDetalle.Columns(i).ColumnName <> "PNCCLNT" _
             AndAlso ObjDetalle.Columns(i).ColumnName <> "PSTCMPCL" _
              AndAlso ObjDetalle.Columns(i).ColumnName <> "PSCREFFW" _
            AndAlso ObjDetalle.Columns(i).ColumnName <> "PNNSEQIN" _
              AndAlso ObjDetalle.Columns(i).ColumnName <> "PSTPRVCL" _
              AndAlso ObjDetalle.Columns(i).ColumnName <> "PSPLANTA" _
               AndAlso ObjDetalle.Columns(i).ColumnName <> "PSNORCML" _
                AndAlso ObjDetalle.Columns(i).ColumnName <> "PSTPRVCL" _
                 AndAlso ObjDetalle.Columns(i).ColumnName <> "PNQPEPQT" _
                    AndAlso ObjDetalle.Columns(i).ColumnName <> "PNQVLBTO" _
                      AndAlso ObjDetalle.Columns(i).ColumnName <> "PNQBLTSR" Then
                objObjDetalle_Planta.Columns.Remove(ObjDetalle.Columns(i).ColumnName)
                'Else
                'Index = Index + 1
            End If
        Next

        Dim TotalKG, TotalM3, TotalBUL As Double
        Dim drSelect As DataRow() = Nothing
        Dim objDataRow As DataRow = Nothing
        Dim strCliente As String = ""
        Dim strPlanta As String = ""
        Dim strPlantaAnteror As String = ""
        'Struct Resumenes 

        objResumen.Columns.Add(New DataColumn("CLIENTE", GetType(System.String)))
        objResumen.Columns.Add(New DataColumn("ORDEN_COMPRA", GetType(System.String)))
        objResumen.Columns.Add(New DataColumn("PROVEEDOR", GetType(System.String)))
        objResumen.Columns.Add(New DataColumn("PLANTA", GetType(System.String)))
        objResumen.Columns.Add(New DataColumn("KG", GetType(System.Double)))
        objResumen.Columns.Add(New DataColumn("M3", GetType(System.Double)))
        objResumen.Columns.Add(New DataColumn("BUL", GetType(System.Double)))

        objResumenFin.Columns.Add(New DataColumn("CLIENTE", GetType(System.String)))
        objResumenFin.Columns.Add(New DataColumn("ORDEN_COMPRA", GetType(System.String)))
        objResumenFin.Columns.Add(New DataColumn("PROVEEDOR", GetType(System.String)))

        'Debe de haberse Ordenado por Planta , Cliente , O/C y Proveedor
        Dim dv As New DataView
        dv.Table = objObjDetalle_Planta
        dv.Sort = "PSPLANTA,PSTCMPCL, PSNORCML, PSTPRVCL ASC"
        objObjDetalle_Planta = dv.ToTable()

        For i As Integer = 0 To objObjDetalle_Planta.Rows.Count - 1
            strPlanta = objObjDetalle_Planta.Rows(i).Item("PSPLANTA")
            strCliente = objObjDetalle_Planta.Rows(i).Item("PSTCMPCL")
            drSelect = objObjDetalle_Planta.Select("PSTCMPCL = '" + strCliente.Trim + "' AND PSPLANTA = '" + strPlanta.Trim + "' AND PSNORCML = '" + objObjDetalle_Planta.Rows(i)("PSNORCML").ToString.Trim + "'")
            TotalKG = 0
            TotalM3 = 0
            TotalBUL = 0


            Dim dt As DataTable = SelectDistinct(RowToDatatable(drSelect, objObjDetalle_Planta), "PSPLANTA", "PSTCMPCL", "PSCREFFW", "PNNSEQIN", "PNQPEPQT", "PNQVLBTO", "PNQBLTSR")

            For Each dr As DataRow In dt.Rows
                TotalKG += Convert.ToDouble(dr("PNQPEPQT"))
                TotalM3 += Convert.ToDouble(dr("PNQVLBTO"))
                TotalBUL += Convert.ToDouble(dr("PNQBLTSR"))
            Next

            'For Each dr As DataRow In drSelect
            '    TotalKG += Convert.ToDouble(dr("QPEPQT"))
            '    TotalM3 += Convert.ToDouble(dr("QVLBTO"))
            '    TotalBUL += Convert.ToDouble(dr("QBLTSR"))
            'Next

            If drSelect.Length > 0 Then
                objDataRow = objResumen.NewRow
                objDataRow.Item("CLIENTE") = objObjDetalle_Planta.Rows(i)("PSTCMPCL").ToString.Trim
                objDataRow.Item("ORDEN_COMPRA") = objObjDetalle_Planta.Rows(i)("PSNORCML").ToString.Trim
                objDataRow.Item("PROVEEDOR") = objObjDetalle_Planta.Rows(i)("PSTPRVCL").ToString.Trim
                objDataRow.Item("PLANTA") = objObjDetalle_Planta.Rows(i)("PSPLANTA").ToString.Trim
                objDataRow.Item("KG") = TotalKG
                objDataRow.Item("M3") = TotalM3
                objDataRow.Item("BUL") = TotalBUL
                objResumen.Rows.Add(objDataRow)
                If strPlanta <> strPlantaAnteror Then
                    objResumenFin.Columns.Add(New DataColumn("PESO_" + strPlanta.Trim, GetType(System.String)))
                    objResumenFin.Columns.Add(New DataColumn("VOLUMEN_" + strPlanta.Trim, GetType(System.String)))
                    objResumenFin.Columns.Add(New DataColumn("BULTO_" + strPlanta.Trim, GetType(System.String)))
                    strPlantaAnteror = strPlanta
                End If
                i = i + drSelect.Length - 1
            End If
        Next

        '' Recorro los resumene para Construir la Tabla
        Dim dvR As New DataView(objResumen)
        dvR.Sort = "CLIENTE,ORDEN_COMPRA, PROVEEDOR ASC"
        objResumen = dvR.ToTable()
        '  Debe estar Ordenado Por Lote
        For i As Integer = 0 To objResumen.Rows.Count - 1
            drSelect = objResumen.Select("CLIENTE = '" + objResumen.Rows(i)("CLIENTE").ToString.Trim + "' AND ORDEN_COMPRA = '" + objResumen.Rows(i)("ORDEN_COMPRA").ToString + "'")
            objDataRow = objResumenFin.NewRow
            objDataRow.Item("CLIENTE") = objResumen.Rows(i)("CLIENTE").ToString.Trim
            objDataRow.Item("ORDEN_COMPRA") = objResumen.Rows(i)("ORDEN_COMPRA").ToString.Trim
            objDataRow.Item("PROVEEDOR") = objResumen.Rows(i)("PROVEEDOR").ToString.Trim

            objResumenFin.Rows.Add(objDataRow)
            For Each dr As DataRow In drSelect
                objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item("PESO_" + dr("PLANTA").ToString.Trim) = dr("KG").ToString.Trim
                objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item("VOLUMEN_" + dr("PLANTA").ToString.Trim) = dr("M3").ToString.Trim
                objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item("BULTO_" + dr("PLANTA").ToString.Trim) = dr("BUL").ToString.Trim
                objResumenFin.AcceptChanges()
            Next
            i = i + drSelect.Length - 1
        Next

        objResumenFin.TableName = "DT_Resumen_OC"
        objResumenFin.Namespace = "Resumen Orden Compra"
        Return (objResumenFin)

    End Function

    Public Function CrearResumenes_Inventario_SentidoCarga(ByVal ObjDetalle As DataTable) As DataTable
        Dim objResumen As New DataTable
        Dim objResumenFin As New DataTable
        Dim objObjDetalle_Planta As DataTable = ObjDetalle.Copy
        Dim Index As Integer = 0
        For i As Integer = 0 To ObjDetalle.Columns.Count - 1
            If ObjDetalle.Columns(i).ColumnName <> "PNCCLNT" _
             AndAlso ObjDetalle.Columns(i).ColumnName <> "PSCREFFW" _
             AndAlso ObjDetalle.Columns(i).ColumnName <> "PNNSEQIN" _
             AndAlso ObjDetalle.Columns(i).ColumnName <> "PSTCMPCL" _
              AndAlso ObjDetalle.Columns(i).ColumnName <> "PSPLANTA" _
               AndAlso ObjDetalle.Columns(i).ColumnName <> "PSSENTIDO" _
                AndAlso ObjDetalle.Columns(i).ColumnName <> "PSTLUGEN" _
                 AndAlso ObjDetalle.Columns(i).ColumnName <> "PNQPEPQT" _
                   AndAlso ObjDetalle.Columns(i).ColumnName <> "PNQVLBTO" _
                     AndAlso ObjDetalle.Columns(i).ColumnName <> "PNQBLTSR" Then

                objObjDetalle_Planta.Columns.Remove(ObjDetalle.Columns(i).ColumnName)
            Else
                Index = Index + 1
            End If
        Next

        Dim TotalKG, TotalM3, TotalBUL As Double
        Dim drSelect As DataRow() = Nothing
        Dim objDataRow As DataRow = Nothing
        Dim strCliente As String = ""
        Dim strPlanta As String = ""
        Dim strPlantaAnteror As String = ""
        'Struct Resumenes 
        objResumen.Columns.Add(New DataColumn("CLIENTE", GetType(System.String)))
        objResumen.Columns.Add(New DataColumn("SENTIDO_CARGA", GetType(System.String)))
        objResumen.Columns.Add(New DataColumn("LOTE", GetType(System.String)))
        objResumen.Columns.Add(New DataColumn("PLANTA", GetType(System.String)))
        objResumen.Columns.Add(New DataColumn("KG", GetType(System.Double)))
        objResumen.Columns.Add(New DataColumn("M3", GetType(System.Double)))
        objResumen.Columns.Add(New DataColumn("BUL", GetType(System.Double)))
        objResumenFin.Columns.Add(New DataColumn("CLIENTE", GetType(System.String)))
        objResumenFin.Columns.Add(New DataColumn("SENTIDO_CARGA", GetType(System.String)))
        objResumenFin.Columns.Add(New DataColumn("LOTE", GetType(System.String)))

        'Debe de haberse Ordenado por Planta , Cliente , Sentido y Lote
        Dim dv As New DataView
        dv.Table = objObjDetalle_Planta
        dv.Sort = "PSPLANTA,PSTCMPCL, PSSENTIDO, PSTLUGEN ASC"
        objObjDetalle_Planta = dv.ToTable()

        For i As Integer = 0 To objObjDetalle_Planta.Rows.Count - 1
            strPlanta = objObjDetalle_Planta.Rows(i).Item("PSPLANTA")
            strCliente = objObjDetalle_Planta.Rows(i).Item("PSTCMPCL")
            ' Dim dt As New DataTable
            ' dt = objObjDetalle_Planta.Copy
            ' dt.DefaultView.RowFilter = "TCMPCL = '" + strCliente.Trim + "' AND PLANTA = '" + strPlanta.Trim + "' AND SENTIDO = '" + objObjDetalle_Planta.Rows(i)("SENTIDO").ToString.Trim + "' AND TLUGEN = '" + objObjDetalle_Planta.Rows(i)("TLUGEN").ToString.Trim + "'"
            ' drSelect = dt.DefaultView.ToTable
            drSelect = objObjDetalle_Planta.Select("PSTCMPCL = '" + strCliente.Trim + "' AND PSPLANTA = '" + strPlanta.Trim + "' AND PSSENTIDO = '" + objObjDetalle_Planta.Rows(i)("PSSENTIDO").ToString.Trim + "' AND PSTLUGEN = '" + objObjDetalle_Planta.Rows(i)("PSTLUGEN").ToString.Trim + "'")
            TotalKG = 0
            TotalM3 = 0
            TotalBUL = 0

            Dim dt As DataTable = SelectDistinct(RowToDatatable(drSelect, objObjDetalle_Planta), "PSPLANTA", "PSTCMPCL", "PSCREFFW", "PNNSEQIN", "PNQPEPQT", "PNQVLBTO", "PNQBLTSR")

            For Each dr As DataRow In dt.Rows
                TotalKG += Convert.ToDouble(dr("PNQPEPQT"))
                TotalM3 += Convert.ToDouble(dr("PNQVLBTO"))
                TotalBUL += Convert.ToDouble(dr("PNQBLTSR"))
            Next

            'For Each dr As DataRow In drSelect

            '    TotalKG += Convert.ToDouble(dr("QPEPQT"))
            '    TotalM3 += Convert.ToDouble(dr("QVLBTO"))
            '    TotalBUL += Convert.ToDouble(dr("QBLTSR"))
            'Next

            If drSelect.Length > 0 Then
                objDataRow = objResumen.NewRow
                objDataRow.Item("CLIENTE") = objObjDetalle_Planta.Rows(i)("PSTCMPCL").ToString.Trim
                objDataRow.Item("PLANTA") = objObjDetalle_Planta.Rows(i)("PSPLANTA").ToString.Trim
                objDataRow.Item("SENTIDO_CARGA") = objObjDetalle_Planta.Rows(i)("PSSENTIDO").ToString.Trim
                objDataRow.Item("LOTE") = objObjDetalle_Planta.Rows(i)("PSTLUGEN").ToString.Trim
                objDataRow.Item("KG") = TotalKG
                objDataRow.Item("M3") = TotalM3
                objDataRow.Item("BUL") = TotalBUL
                objResumen.Rows.Add(objDataRow)
                If strPlanta <> strPlantaAnteror Then
                    objResumenFin.Columns.Add(New DataColumn("PESO_" + strPlanta.Trim, GetType(System.String)))
                    objResumenFin.Columns.Add(New DataColumn("VOLUMEN_" + strPlanta.Trim, GetType(System.String)))
                    objResumenFin.Columns.Add(New DataColumn("BULTO_" + strPlanta.Trim, GetType(System.String)))
                    strPlantaAnteror = strPlanta
                End If
                i = i + drSelect.Length - 1
            End If
        Next
        '' Recorro los resumene para Construir la Tabla
        Dim dvR As New DataView(objResumen)
        dvR.Sort = "CLIENTE,SENTIDO_CARGA, LOTE ASC"
        objResumen = dvR.ToTable()
        '  Debe estar Ordenado Por Lote
        For i As Integer = 0 To objResumen.Rows.Count - 1
            drSelect = objResumen.Select("CLIENTE = '" + objResumen.Rows(i)("CLIENTE").ToString.Trim + "' AND SENTIDO_CARGA = '" + objResumen.Rows(i)("SENTIDO_CARGA").ToString.Trim + "' AND LOTE = '" + objResumen.Rows(i)("LOTE").ToString.Trim + "'")
            objDataRow = objResumenFin.NewRow
            objDataRow.Item("CLIENTE") = objResumen.Rows(i)("CLIENTE").ToString.Trim
            objDataRow.Item("SENTIDO_CARGA") = objResumen.Rows(i)("SENTIDO_CARGA").ToString.Trim
            objDataRow.Item("LOTE") = objResumen.Rows(i)("LOTE").ToString.Trim

            objResumenFin.Rows.Add(objDataRow)
            For Each dr As DataRow In drSelect
                objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item("PESO_" + dr("PLANTA").ToString.Trim) = dr("KG").ToString.Trim
                objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item("VOLUMEN_" + dr("PLANTA").ToString.Trim) = dr("M3").ToString.Trim
                objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item("BULTO_" + dr("PLANTA").ToString.Trim) = dr("BUL").ToString.Trim
                objResumenFin.AcceptChanges()
            Next
            i = i + drSelect.Length - 1
        Next
        objResumenFin.TableName = "DT_Resumen_Sentido"
        objResumenFin.Namespace = "Resumen Sentido Carga"

        Return (objResumenFin)

    End Function

    Private Function RowToDatatable(ByVal drSelect As DataRow(), ByVal tbl As DataTable) As DataTable
        Dim dt As New DataTable
        dt = tbl.Clone
        For Each row As DataRow In drSelect
            dt.ImportRow(row)
        Next
        Return dt
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

    Public Function CrearResumenes_Despacho(ByVal ObjDetalle As DataTable) As DataSet
        'Dim Drv As New DataView
        'Drv.Table = ObjDetalle
        'Drv.Sort = "ROWNUMBER ASC"
        'ObjDetalle = Drv.ToTable()
        ObjDetalle.Columns.Remove("ROWNUMBER")
        Dim dsReturn As New DataSet
        dsReturn = Me.CrearResumenes_MovimientosDespacho(ObjDetalle)
        dsReturn.Tables.Add(CrearResumenes_Movimiento_MedioEnVio(ObjDetalle))
        Return (dsReturn)
    End Function

    Public Function CrearResumenes_Movimiento_MedioEnVio(ByVal ObjDetalle As DataTable) As DataTable
        Dim objResumen As New DataTable
        Dim objResumenFin As New DataTable
        Dim objObjDetalle_Planta As New DataTable
        Dim objDataRow As DataRow = Nothing

        objObjDetalle_Planta.TableName = "DT_DETALLE"
        objObjDetalle_Planta.Columns.Add(New DataColumn("TCMPCL", GetType(System.String)))
        objObjDetalle_Planta.Columns.Add(New DataColumn("GUIATRANS", GetType(System.String)))
        objObjDetalle_Planta.Columns.Add(New DataColumn("MEDENVIO", GetType(System.String)))
        objObjDetalle_Planta.Columns.Add(New DataColumn("TLUGEN", GetType(System.String)))
        objObjDetalle_Planta.Columns.Add(New DataColumn("TUNDVH", GetType(System.String)))
        objObjDetalle_Planta.Columns.Add(New DataColumn("PLANTA", GetType(System.String)))
        objObjDetalle_Planta.Columns.Add(New DataColumn("CREFFW", GetType(System.String)))
        objObjDetalle_Planta.Columns.Add(New DataColumn("NSEQIN", GetType(System.String)))
        objObjDetalle_Planta.Columns.Add(New DataColumn("QPEPQT", GetType(System.Double)))
        objObjDetalle_Planta.Columns.Add(New DataColumn("QVLBTO", GetType(System.Double)))
        objObjDetalle_Planta.Columns.Add(New DataColumn("QBLTSR", GetType(System.Double)))
        objObjDetalle_Planta.Columns.Add(New DataColumn("IMPORTE", GetType(System.Double)))

        'Pobla el dataTable  y se kita la Agrupacion de Medio de envio
        Dim InsertMedio As Boolean = False
        For i As Integer = 0 To ObjDetalle.Rows.Count - 1
            InsertMedio = False
            For j As Integer = 1 To 3
                If ObjDetalle.Rows(i)(j.ToString + "_MEDENVIO").ToString.Trim <> "" Then
                    objDataRow = objObjDetalle_Planta.NewRow
                    objDataRow.Item("TCMPCL") = ObjDetalle.Rows(i)("TCMPCL").ToString.Trim
                    objDataRow.Item("GUIATRANS") = ObjDetalle.Rows(i)(j.ToString + "_GUIATRANS").ToString.Trim
                    objDataRow.Item("MEDENVIO") = ObjDetalle.Rows(i)(j.ToString + "_MEDENVIO").ToString.Trim
                    objDataRow.Item("TLUGEN") = ObjDetalle.Rows(i)("TLUGEN").ToString.Trim
                    objDataRow.Item("TUNDVH") = ObjDetalle.Rows(i)(j.ToString + "_TUNDVH").ToString.Trim
                    objDataRow.Item("PLANTA") = ObjDetalle.Rows(i)("PLANTA").ToString.Trim
                    objDataRow.Item("CREFFW") = ObjDetalle.Rows(i)("CREFFW").ToString.Trim
                    objDataRow.Item("NSEQIN") = ObjDetalle.Rows(i)("NSEQIN").ToString.Trim
                    objDataRow.Item("QPEPQT") = ObjDetalle.Rows(i)("QPEPQT").ToString.Trim
                    objDataRow.Item("QVLBTO") = ObjDetalle.Rows(i)("QVLBTO").ToString.Trim
                    objDataRow.Item("QBLTSR") = ObjDetalle.Rows(i)("QBLTSR").ToString.Trim
                    objDataRow.Item("IMPORTE") = Val("" & ObjDetalle.Rows(i)(j.ToString + "_IMPORTE").ToString.Trim & "")
                    objObjDetalle_Planta.Rows.Add(objDataRow)
                    InsertMedio = True
                End If
            Next

            If InsertMedio = False Then
                objDataRow = objObjDetalle_Planta.NewRow
                objDataRow.Item("TCMPCL") = ObjDetalle.Rows(i)("TCMPCL").ToString.Trim
                objDataRow.Item("GUIATRANS") = ""
                objDataRow.Item("MEDENVIO") = "*S/N MEDIO ENVIO"
                objDataRow.Item("TLUGEN") = ObjDetalle.Rows(i)("TLUGEN").ToString.Trim
                objDataRow.Item("TUNDVH") = ""
                objDataRow.Item("PLANTA") = ObjDetalle.Rows(i)("PLANTA").ToString.Trim
                objDataRow.Item("CREFFW") = ObjDetalle.Rows(i)("CREFFW").ToString.Trim
                objDataRow.Item("NSEQIN") = ObjDetalle.Rows(i)("NSEQIN").ToString.Trim
                objDataRow.Item("QPEPQT") = ObjDetalle.Rows(i)("QPEPQT").ToString.Trim
                objDataRow.Item("QVLBTO") = ObjDetalle.Rows(i)("QVLBTO").ToString.Trim
                objDataRow.Item("QBLTSR") = ObjDetalle.Rows(i)("QBLTSR").ToString.Trim
                objDataRow.Item("IMPORTE") = "0"
                objObjDetalle_Planta.Rows.Add(objDataRow)
            End If
        Next

        Dim TotalKG, TotalM3, TotalBUL, TotalImporte As Double
        Dim drSelectBulto As DataRow() = Nothing
        Dim drSelectImporte As DataRow() = Nothing

        Dim strCliente As String = ""
        Dim strPlanta As String = ""
        Dim strPlantaAnteror As String = ""
        'Struct Resumenes 
        objResumen.Columns.Add(New DataColumn("CLIENTE", GetType(System.String)))
        objResumen.Columns.Add(New DataColumn("MEDIO_ENVIO", GetType(System.String)))
        objResumen.Columns.Add(New DataColumn("LOTE", GetType(System.String)))
        objResumen.Columns.Add(New DataColumn("TIPO_UNIDAD", GetType(System.String)))
        objResumen.Columns.Add(New DataColumn("PLANTA", GetType(System.String)))
        objResumen.Columns.Add(New DataColumn("KG", GetType(System.Double)))
        objResumen.Columns.Add(New DataColumn("M3", GetType(System.Double)))
        objResumen.Columns.Add(New DataColumn("BUL", GetType(System.Double)))
        objResumen.Columns.Add(New DataColumn("IMPORTE", GetType(System.Double)))

        objResumenFin.Columns.Add(New DataColumn("CLIENTE", GetType(System.String)))
        objResumenFin.Columns.Add(New DataColumn("MEDIO_ENVIO", GetType(System.String)))
        objResumenFin.Columns.Add(New DataColumn("LOTE", GetType(System.String)))
        objResumenFin.Columns.Add(New DataColumn("TIPO_UNIDAD", GetType(System.String)))

        'Debe de haberse Ordenado por Planta , Cliente , MEDENVIO , TLUGEN y TUNDVH
        Dim dv As New DataView
        dv.Table = objObjDetalle_Planta
        dv.Sort = "Planta,TCMPCL, MEDENVIO,TLUGEN, TUNDVH ASC"
        objObjDetalle_Planta = dv.ToTable()


        For i As Integer = 0 To objObjDetalle_Planta.Rows.Count - 1
            strPlanta = objObjDetalle_Planta.Rows(i).Item("PLANTA")
            strCliente = objObjDetalle_Planta.Rows(i).Item("TCMPCL")
            drSelectImporte = objObjDetalle_Planta.Select("TCMPCL = '" + strCliente.Trim + "' AND PLANTA = '" + strPlanta.Trim + "' AND MEDENVIO = '" + objObjDetalle_Planta.Rows(i)("MEDENVIO").ToString.Trim + "' AND TLUGEN = '" + objObjDetalle_Planta.Rows(i)("TLUGEN").ToString.Trim + "' AND TUNDVH = '" + objObjDetalle_Planta.Rows(i)("TUNDVH").ToString.Trim + "'")
            TotalKG = 0
            TotalM3 = 0
            TotalBUL = 0
            TotalImporte = 0

            '''' Se Costruyen los Totales (Bultos Diferentes)

            Dim dt As DataTable = SelectDistinct(RowToDatatable(drSelectImporte, objObjDetalle_Planta), "PLANTA", "TCMPCL", "CREFFW", "NSEQIN", "QPEPQT", "QVLBTO", "QBLTSR")

            For Each dr As DataRow In dt.Rows
                TotalKG += Convert.ToDouble(dr("QPEPQT"))
                TotalM3 += Convert.ToDouble(dr("QVLBTO"))
                TotalBUL += Convert.ToDouble(dr("QBLTSR"))
            Next

            '''' Se Costruyen los Importes (Todos los Bultos)
            For Each dr As DataRow In drSelectImporte
                TotalImporte += Convert.ToDouble(dr("IMPORTE"))
            Next

            If drSelectImporte.Length > 0 Then
                objDataRow = objResumen.NewRow
                objDataRow.Item("CLIENTE") = objObjDetalle_Planta.Rows(i)("TCMPCL").ToString.Trim
                objDataRow.Item("MEDIO_ENVIO") = objObjDetalle_Planta.Rows(i)("MEDENVIO").ToString.Trim
                objDataRow.Item("LOTE") = objObjDetalle_Planta.Rows(i)("TLUGEN").ToString.Trim
                objDataRow.Item("TIPO_UNIDAD") = objObjDetalle_Planta.Rows(i)("TUNDVH").ToString.Trim
                objDataRow.Item("PLANTA") = objObjDetalle_Planta.Rows(i)("PLANTA").ToString.Trim
                objDataRow.Item("KG") = TotalKG
                objDataRow.Item("M3") = TotalM3
                objDataRow.Item("BUL") = TotalBUL
                objDataRow.Item("IMPORTE") = TotalImporte

                objResumen.Rows.Add(objDataRow)
                If strPlanta <> strPlantaAnteror Then
                    objResumenFin.Columns.Add(New DataColumn("PESO_" + strPlanta.Trim, GetType(System.String)))
                    objResumenFin.Columns.Add(New DataColumn("VOLUMEN_" + strPlanta.Trim, GetType(System.String)))
                    objResumenFin.Columns.Add(New DataColumn("BULTO_" + strPlanta.Trim, GetType(System.String)))
                    objResumenFin.Columns.Add(New DataColumn("IMPORTE_" + strPlanta.Trim, GetType(System.String)))
                    strPlantaAnteror = strPlanta
                End If
                i = i + drSelectImporte.Length - 1
            End If
        Next

        '' Recorro los resumene para Construir la Tabla
        Dim dvR As New DataView(objResumen)
        dvR.Sort = "CLIENTE,MEDIO_ENVIO, LOTE, TIPO_UNIDAD ASC"
        objResumen = dvR.ToTable()

        For i As Integer = 0 To objResumen.Rows.Count - 1
            drSelectImporte = objResumen.Select("CLIENTE = '" + objResumen.Rows(i)("CLIENTE").ToString.Trim + "' AND MEDIO_ENVIO = '" + objResumen.Rows(i)("MEDIO_ENVIO").ToString + "' AND LOTE = '" + objResumen.Rows(i)("LOTE").ToString + "' AND TIPO_UNIDAD = '" + objResumen.Rows(i)("TIPO_UNIDAD").ToString + "'")
            objDataRow = objResumenFin.NewRow
            objDataRow.Item("CLIENTE") = objResumen.Rows(i)("CLIENTE").ToString.Trim
            objDataRow.Item("MEDIO_ENVIO") = objResumen.Rows(i)("MEDIO_ENVIO").ToString.Trim
            objDataRow.Item("LOTE") = objResumen.Rows(i)("LOTE").ToString.Trim
            objDataRow.Item("TIPO_UNIDAD") = objResumen.Rows(i)("TIPO_UNIDAD").ToString.Trim
            objResumenFin.Rows.Add(objDataRow)
            For Each dr As DataRow In drSelectImporte
                objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item("PESO_" + dr("PLANTA").ToString.Trim) = dr("KG").ToString.Trim
                objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item("VOLUMEN_" + dr("PLANTA").ToString.Trim) = dr("M3").ToString.Trim
                objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item("BULTO_" + dr("PLANTA").ToString.Trim) = dr("BUL").ToString.Trim
                objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item("IMPORTE_" + dr("PLANTA").ToString.Trim) = dr("IMPORTE").ToString.Trim
                objResumenFin.AcceptChanges()
            Next
            i = i + drSelectImporte.Length - 1
        Next

        objResumenFin.TableName = "DT_Resumen_MedioEnvio"
        objResumenFin.Namespace = "Resumen Medio Envio"
        Return (objResumenFin)

    End Function

    Public Function CrearResumenes_MovimientosDespacho(ByVal ObjDetalle As DataTable) As DataSet
        Dim dsReturn As New DataSet
        Dim objDataSet As New DataSet
        'Dim objFiltros As New DataTable
        Dim objResumen As New DataTable
        Dim objResumenFin As New DataTable

        Dim objObjDetalle_Planta As DataTable = ObjDetalle.Copy
        Dim Index As Integer = 0

        For i As Integer = 0 To ObjDetalle.Columns.Count - 1
            If ObjDetalle.Columns(i).ColumnName <> "PLANTA" _
            AndAlso ObjDetalle.Columns(i).ColumnName <> "CCLNT" _
            AndAlso ObjDetalle.Columns(i).ColumnName <> "CREFFW" _
             AndAlso ObjDetalle.Columns(i).ColumnName <> "NSEQIN" _
             AndAlso ObjDetalle.Columns(i).ColumnName <> "TCMPCL" _
                AndAlso ObjDetalle.Columns(i).ColumnName <> "TLUGEN" _
                  AndAlso ObjDetalle.Columns(i).ColumnName <> "QPEPQT" _
                    AndAlso ObjDetalle.Columns(i).ColumnName <> "QVLBTO" _
                      AndAlso ObjDetalle.Columns(i).ColumnName <> "QBLTSR" Then

                objObjDetalle_Planta.Columns.Remove(ObjDetalle.Columns(i).ColumnName)
                'Index = Index + 1
            Else
                Index = Index + 1
            End If
        Next
        Dim TotalKG, TotalM3, TotalBUL As Double
        Dim drSelect As DataRow() = Nothing
        Dim objDataRow As DataRow = Nothing
        Dim strCliente As String = ""
        Dim strPlanta As String = ""
        Dim strPlantaAnteror As String = ""
        'Struct Resumenes
        objResumen.Columns.Add(New DataColumn("CLIENTE", GetType(System.String)))
        objResumen.Columns.Add(New DataColumn("LOTE", GetType(System.String)))
        objResumen.Columns.Add(New DataColumn("PLANTA", GetType(System.String)))
        objResumen.Columns.Add(New DataColumn("KG", GetType(System.Double)))
        objResumen.Columns.Add(New DataColumn("M3", GetType(System.Double)))
        objResumen.Columns.Add(New DataColumn("BUL", GetType(System.Double)))
        objResumenFin.Columns.Add(New DataColumn("CLIENTE", GetType(System.String)))
        objResumenFin.Columns.Add(New DataColumn("LOTE", GetType(System.String)))

        'Debe de haberse Ordenado por Planta Y lote
        Dim dv As New DataView
        dv.Table = objObjDetalle_Planta
        dv.Sort = "PLANTA,TCMPCL, TLUGEN ASC"
        objObjDetalle_Planta = dv.ToTable()
        For i As Integer = 0 To objObjDetalle_Planta.Rows.Count - 1
            strPlanta = objObjDetalle_Planta.Rows(i).Item("PLANTA")
            strCliente = objObjDetalle_Planta.Rows(i).Item("TCMPCL")
            drSelect = objObjDetalle_Planta.Select("TCMPCL = '" + strCliente.Trim + "' AND PLANTA = '" + strPlanta.Trim + "' AND TLUGEN = '" + objObjDetalle_Planta.Rows(i)("TLUGEN").ToString.Trim + "'")
            TotalKG = 0
            TotalM3 = 0
            TotalBUL = 0


            Dim dt As DataTable = SelectDistinct(RowToDatatable(drSelect, objObjDetalle_Planta), "PLANTA", "TCMPCL", "CREFFW", "NSEQIN", "QPEPQT", "QVLBTO", "QBLTSR")

            For Each dr As DataRow In dt.Rows
                TotalKG += Convert.ToDouble(dr("QPEPQT"))
                TotalM3 += Convert.ToDouble(dr("QVLBTO"))
                TotalBUL += Convert.ToDouble(dr("QBLTSR"))
            Next

            'For Each dr As DataRow In drSelect
            '    TotalKG += Convert.ToDouble(dr("QPEPQT"))
            '    TotalM3 += Convert.ToDouble(dr("QVLBTO"))
            '    TotalBUL += Convert.ToDouble(dr("QBLTSR"))
            'Next

            If drSelect.Length > 0 Then
                objDataRow = objResumen.NewRow
                objDataRow.Item("CLIENTE") = objObjDetalle_Planta.Rows(i)("TCMPCL").ToString.Trim
                objDataRow.Item("LOTE") = objObjDetalle_Planta.Rows(i)("TLUGEN").ToString.Trim
                objDataRow.Item("PLANTA") = objObjDetalle_Planta.Rows(i)("PLANTA").ToString.Trim
                objDataRow.Item("KG") = TotalKG
                objDataRow.Item("M3") = TotalM3
                objDataRow.Item("BUL") = TotalBUL
                objResumen.Rows.Add(objDataRow)
                If strPlanta <> strPlantaAnteror Then
                    objResumenFin.Columns.Add(New DataColumn("PESO_" + strPlanta.Trim, GetType(System.String)))
                    objResumenFin.Columns.Add(New DataColumn("VOLUMEN_" + strPlanta.Trim, GetType(System.String)))
                    objResumenFin.Columns.Add(New DataColumn("BULTO_" + strPlanta.Trim, GetType(System.String)))
                    strPlantaAnteror = strPlanta
                End If
                i = i + drSelect.Length - 1
            End If
        Next
        '' Recorro los resumene para Construir la Tabla
        Dim dvR As New DataView(objResumen)
        dvR.Sort = "CLIENTE,LOTE ASC"
        objResumen = dvR.ToTable()
        '  Debe estar Ordenado Por Lote
        For i As Integer = 0 To objResumen.Rows.Count - 1
            drSelect = objResumen.Select("CLIENTE = '" + objResumen.Rows(i)("CLIENTE").ToString.Trim + "' AND LOTE = '" + objResumen.Rows(i)("LOTE").ToString + "'")
            objDataRow = objResumenFin.NewRow
            objDataRow.Item("CLIENTE") = objResumen.Rows(i)("CLIENTE").ToString.Trim
            objDataRow.Item("LOTE") = objResumen.Rows(i)("LOTE").ToString.Trim

            objResumenFin.Rows.Add(objDataRow)
            For Each dr As DataRow In drSelect
                objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item("PESO_" + dr("PLANTA").ToString.Trim) = dr("KG").ToString.Trim
                objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item("VOLUMEN_" + dr("PLANTA").ToString.Trim) = dr("M3").ToString.Trim
                objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item("BULTO_" + dr("PLANTA").ToString.Trim) = dr("BUL").ToString.Trim
                objResumenFin.AcceptChanges()
            Next
            i = i + drSelect.Length - 1
        Next

        ObjDetalle.TableName = "DT_Detalle"
        'objResumenFin.Namespace = "Movimiento Mercaderia"
        objResumenFin.TableName = "DT_Resumen"
        objResumenFin.Namespace = "Resumen Lote"
        dsReturn.Tables.Add(ObjDetalle.Copy())
        dsReturn.Tables.Add(objResumenFin)
        dsReturn.Tables.Add(CrearResumenes_Movimiento_OrdenCompra_Despacho(ObjDetalle.Copy()))
        dsReturn.Tables.Add(CrearResumenes_Inventario_SentidoCarga_Despacho(ObjDetalle.Copy()))


        'Añade el Table de Clientes Distic
        Dim oDtvTemp As DataView = New DataView(objResumen)
        Dim oTdtTemp As New DataTable
        oTdtTemp = oDtvTemp.ToTable(True, "CLIENTE")
        oTdtTemp.TableName = "DT_Clientes"
        dsReturn.Tables.Add(oTdtTemp.Copy())
        Return (dsReturn)
    End Function

    Public Function CrearResumenes_Movimiento_OrdenCompra_Despacho(ByVal ObjDetalle As DataTable) As DataTable
        Dim objResumen As New DataTable
        Dim objResumenFin As New DataTable
        Dim objObjDetalle_Planta As DataTable = ObjDetalle.Copy
        Dim Index As Integer = 0

        For i As Integer = 0 To ObjDetalle.Columns.Count - 1
            If ObjDetalle.Columns(i).ColumnName <> "CCLNT" _
             AndAlso ObjDetalle.Columns(i).ColumnName <> "TCMPCL" _
              AndAlso ObjDetalle.Columns(i).ColumnName <> "CREFFW" _
            AndAlso ObjDetalle.Columns(i).ColumnName <> "NSEQIN" _
              AndAlso ObjDetalle.Columns(i).ColumnName <> "TPRVCL" _
              AndAlso ObjDetalle.Columns(i).ColumnName <> "PLANTA" _
               AndAlso ObjDetalle.Columns(i).ColumnName <> "NORCML" _
                AndAlso ObjDetalle.Columns(i).ColumnName <> "TPRVCL" _
                 AndAlso ObjDetalle.Columns(i).ColumnName <> "QPEPQT" _
                    AndAlso ObjDetalle.Columns(i).ColumnName <> "QVLBTO" _
                      AndAlso ObjDetalle.Columns(i).ColumnName <> "QBLTSR" Then
                objObjDetalle_Planta.Columns.Remove(ObjDetalle.Columns(i).ColumnName)
                'Else
                'Index = Index + 1
            End If
        Next

        Dim TotalKG, TotalM3, TotalBUL As Double
        Dim drSelect As DataRow() = Nothing
        Dim objDataRow As DataRow = Nothing
        Dim strCliente As String = ""
        Dim strPlanta As String = ""
        Dim strPlantaAnteror As String = ""
        'Struct Resumenes 

        objResumen.Columns.Add(New DataColumn("CLIENTE", GetType(System.String)))
        objResumen.Columns.Add(New DataColumn("ORDEN_COMPRA", GetType(System.String)))
        objResumen.Columns.Add(New DataColumn("PROVEEDOR", GetType(System.String)))
        objResumen.Columns.Add(New DataColumn("PLANTA", GetType(System.String)))
        objResumen.Columns.Add(New DataColumn("KG", GetType(System.Double)))
        objResumen.Columns.Add(New DataColumn("M3", GetType(System.Double)))
        objResumen.Columns.Add(New DataColumn("BUL", GetType(System.Double)))

        objResumenFin.Columns.Add(New DataColumn("CLIENTE", GetType(System.String)))
        objResumenFin.Columns.Add(New DataColumn("ORDEN_COMPRA", GetType(System.String)))
        objResumenFin.Columns.Add(New DataColumn("PROVEEDOR", GetType(System.String)))

        'Debe de haberse Ordenado por Planta , Cliente , O/C y Proveedor
        Dim dv As New DataView
        dv.Table = objObjDetalle_Planta
        dv.Sort = "PLANTA,TCMPCL, NORCML, TPRVCL ASC"
        objObjDetalle_Planta = dv.ToTable()

        For i As Integer = 0 To objObjDetalle_Planta.Rows.Count - 1
            strPlanta = objObjDetalle_Planta.Rows(i).Item("PLANTA")
            strCliente = objObjDetalle_Planta.Rows(i).Item("TCMPCL")
            drSelect = objObjDetalle_Planta.Select("TCMPCL = '" + strCliente.Trim + "' AND PLANTA = '" + strPlanta.Trim + "' AND NORCML = '" + objObjDetalle_Planta.Rows(i)("NORCML").ToString.Trim + "'")
            TotalKG = 0
            TotalM3 = 0
            TotalBUL = 0


            Dim dt As DataTable = SelectDistinct(RowToDatatable(drSelect, objObjDetalle_Planta), "PLANTA", "TCMPCL", "CREFFW", "NSEQIN", "QPEPQT", "QVLBTO", "QBLTSR")

            For Each dr As DataRow In dt.Rows
                TotalKG += Convert.ToDouble(dr("QPEPQT"))
                TotalM3 += Convert.ToDouble(dr("QVLBTO"))
                TotalBUL += Convert.ToDouble(dr("QBLTSR"))
            Next

            'For Each dr As DataRow In drSelect
            '    TotalKG += Convert.ToDouble(dr("QPEPQT"))
            '    TotalM3 += Convert.ToDouble(dr("QVLBTO"))
            '    TotalBUL += Convert.ToDouble(dr("QBLTSR"))
            'Next

            If drSelect.Length > 0 Then
                objDataRow = objResumen.NewRow
                objDataRow.Item("CLIENTE") = objObjDetalle_Planta.Rows(i)("TCMPCL").ToString.Trim
                objDataRow.Item("ORDEN_COMPRA") = objObjDetalle_Planta.Rows(i)("NORCML").ToString.Trim
                objDataRow.Item("PROVEEDOR") = objObjDetalle_Planta.Rows(i)("TPRVCL").ToString.Trim
                objDataRow.Item("PLANTA") = objObjDetalle_Planta.Rows(i)("PLANTA").ToString.Trim
                objDataRow.Item("KG") = TotalKG
                objDataRow.Item("M3") = TotalM3
                objDataRow.Item("BUL") = TotalBUL
                objResumen.Rows.Add(objDataRow)
                If strPlanta <> strPlantaAnteror Then
                    objResumenFin.Columns.Add(New DataColumn("PESO_" + strPlanta.Trim, GetType(System.String)))
                    objResumenFin.Columns.Add(New DataColumn("VOLUMEN_" + strPlanta.Trim, GetType(System.String)))
                    objResumenFin.Columns.Add(New DataColumn("BULTO_" + strPlanta.Trim, GetType(System.String)))
                    strPlantaAnteror = strPlanta
                End If
                i = i + drSelect.Length - 1
            End If
        Next

        '' Recorro los resumene para Construir la Tabla
        Dim dvR As New DataView(objResumen)
        dvR.Sort = "CLIENTE,ORDEN_COMPRA, PROVEEDOR ASC"
        objResumen = dvR.ToTable()
        '  Debe estar Ordenado Por Lote
        For i As Integer = 0 To objResumen.Rows.Count - 1
            drSelect = objResumen.Select("CLIENTE = '" + objResumen.Rows(i)("CLIENTE").ToString.Trim + "' AND ORDEN_COMPRA = '" + objResumen.Rows(i)("ORDEN_COMPRA").ToString + "'")
            objDataRow = objResumenFin.NewRow
            objDataRow.Item("CLIENTE") = objResumen.Rows(i)("CLIENTE").ToString.Trim
            objDataRow.Item("ORDEN_COMPRA") = objResumen.Rows(i)("ORDEN_COMPRA").ToString.Trim
            objDataRow.Item("PROVEEDOR") = objResumen.Rows(i)("PROVEEDOR").ToString.Trim

            objResumenFin.Rows.Add(objDataRow)
            For Each dr As DataRow In drSelect
                objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item("PESO_" + dr("PLANTA").ToString.Trim) = dr("KG").ToString.Trim
                objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item("VOLUMEN_" + dr("PLANTA").ToString.Trim) = dr("M3").ToString.Trim
                objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item("BULTO_" + dr("PLANTA").ToString.Trim) = dr("BUL").ToString.Trim
                objResumenFin.AcceptChanges()
            Next
            i = i + drSelect.Length - 1
        Next

        objResumenFin.TableName = "DT_Resumen_OC"
        objResumenFin.Namespace = "Resumen Orden Compra"
        Return (objResumenFin)

    End Function

    Public Function CrearResumenes_Inventario_SentidoCarga_Despacho(ByVal ObjDetalle As DataTable) As DataTable
        Dim objResumen As New DataTable
        Dim objResumenFin As New DataTable
        Dim objObjDetalle_Planta As DataTable = ObjDetalle.Copy
        Dim Index As Integer = 0
        For i As Integer = 0 To ObjDetalle.Columns.Count - 1
            If ObjDetalle.Columns(i).ColumnName <> "CCLNT" _
             AndAlso ObjDetalle.Columns(i).ColumnName <> "CREFFW" _
             AndAlso ObjDetalle.Columns(i).ColumnName <> "NSEQIN" _
             AndAlso ObjDetalle.Columns(i).ColumnName <> "TCMPCL" _
              AndAlso ObjDetalle.Columns(i).ColumnName <> "PLANTA" _
               AndAlso ObjDetalle.Columns(i).ColumnName <> "SENTIDO" _
                AndAlso ObjDetalle.Columns(i).ColumnName <> "TLUGEN" _
                 AndAlso ObjDetalle.Columns(i).ColumnName <> "QPEPQT" _
                   AndAlso ObjDetalle.Columns(i).ColumnName <> "QVLBTO" _
                     AndAlso ObjDetalle.Columns(i).ColumnName <> "QBLTSR" Then

                objObjDetalle_Planta.Columns.Remove(ObjDetalle.Columns(i).ColumnName)
            Else
                Index = Index + 1
            End If
        Next

        Dim TotalKG, TotalM3, TotalBUL As Double
        Dim drSelect As DataRow() = Nothing
        Dim objDataRow As DataRow = Nothing
        Dim strCliente As String = ""
        Dim strPlanta As String = ""
        Dim strPlantaAnteror As String = ""
        'Struct Resumenes 
        objResumen.Columns.Add(New DataColumn("CLIENTE", GetType(System.String)))
        objResumen.Columns.Add(New DataColumn("SENTIDO_CARGA", GetType(System.String)))
        objResumen.Columns.Add(New DataColumn("LOTE", GetType(System.String)))
        objResumen.Columns.Add(New DataColumn("PLANTA", GetType(System.String)))
        objResumen.Columns.Add(New DataColumn("KG", GetType(System.Double)))
        objResumen.Columns.Add(New DataColumn("M3", GetType(System.Double)))
        objResumen.Columns.Add(New DataColumn("BUL", GetType(System.Double)))
        objResumenFin.Columns.Add(New DataColumn("CLIENTE", GetType(System.String)))
        objResumenFin.Columns.Add(New DataColumn("SENTIDO_CARGA", GetType(System.String)))
        objResumenFin.Columns.Add(New DataColumn("LOTE", GetType(System.String)))

        'Debe de haberse Ordenado por Planta , Cliente , Sentido y Lote
        Dim dv As New DataView
        dv.Table = objObjDetalle_Planta
        dv.Sort = "PLANTA,TCMPCL, SENTIDO, TLUGEN ASC"
        objObjDetalle_Planta = dv.ToTable()

        For i As Integer = 0 To objObjDetalle_Planta.Rows.Count - 1
            strPlanta = objObjDetalle_Planta.Rows(i).Item("PLANTA")
            strCliente = objObjDetalle_Planta.Rows(i).Item("TCMPCL")
            ' Dim dt As New DataTable
            ' dt = objObjDetalle_Planta.Copy
            ' dt.DefaultView.RowFilter = "TCMPCL = '" + strCliente.Trim + "' AND PLANTA = '" + strPlanta.Trim + "' AND SENTIDO = '" + objObjDetalle_Planta.Rows(i)("SENTIDO").ToString.Trim + "' AND TLUGEN = '" + objObjDetalle_Planta.Rows(i)("TLUGEN").ToString.Trim + "'"
            ' drSelect = dt.DefaultView.ToTable
            drSelect = objObjDetalle_Planta.Select("TCMPCL = '" + strCliente.Trim + "' AND PLANTA = '" + strPlanta.Trim + "' AND SENTIDO = '" + objObjDetalle_Planta.Rows(i)("SENTIDO").ToString.Trim + "' AND TLUGEN = '" + objObjDetalle_Planta.Rows(i)("TLUGEN").ToString.Trim + "'")
            TotalKG = 0
            TotalM3 = 0
            TotalBUL = 0

            Dim dt As DataTable = SelectDistinct(RowToDatatable(drSelect, objObjDetalle_Planta), "PLANTA", "TCMPCL", "CREFFW", "NSEQIN", "QPEPQT", "QVLBTO", "QBLTSR")

            For Each dr As DataRow In dt.Rows
                TotalKG += Convert.ToDouble(dr("QPEPQT"))
                TotalM3 += Convert.ToDouble(dr("QVLBTO"))
                TotalBUL += Convert.ToDouble(dr("QBLTSR"))
            Next

            'For Each dr As DataRow In drSelect

            '    TotalKG += Convert.ToDouble(dr("QPEPQT"))
            '    TotalM3 += Convert.ToDouble(dr("QVLBTO"))
            '    TotalBUL += Convert.ToDouble(dr("QBLTSR"))
            'Next

            If drSelect.Length > 0 Then
                objDataRow = objResumen.NewRow
                objDataRow.Item("CLIENTE") = objObjDetalle_Planta.Rows(i)("TCMPCL").ToString.Trim
                objDataRow.Item("PLANTA") = objObjDetalle_Planta.Rows(i)("PLANTA").ToString.Trim
                objDataRow.Item("SENTIDO_CARGA") = objObjDetalle_Planta.Rows(i)("SENTIDO").ToString.Trim
                objDataRow.Item("LOTE") = objObjDetalle_Planta.Rows(i)("TLUGEN").ToString.Trim
                objDataRow.Item("KG") = TotalKG
                objDataRow.Item("M3") = TotalM3
                objDataRow.Item("BUL") = TotalBUL
                objResumen.Rows.Add(objDataRow)
                If strPlanta <> strPlantaAnteror Then
                    objResumenFin.Columns.Add(New DataColumn("PESO_" + strPlanta.Trim, GetType(System.String)))
                    objResumenFin.Columns.Add(New DataColumn("VOLUMEN_" + strPlanta.Trim, GetType(System.String)))
                    objResumenFin.Columns.Add(New DataColumn("BULTO_" + strPlanta.Trim, GetType(System.String)))
                    strPlantaAnteror = strPlanta
                End If
                i = i + drSelect.Length - 1
            End If
        Next
        '' Recorro los resumene para Construir la Tabla
        Dim dvR As New DataView(objResumen)
        dvR.Sort = "CLIENTE,SENTIDO_CARGA, LOTE ASC"
        objResumen = dvR.ToTable()
        '  Debe estar Ordenado Por Lote
        For i As Integer = 0 To objResumen.Rows.Count - 1
            drSelect = objResumen.Select("CLIENTE = '" + objResumen.Rows(i)("CLIENTE").ToString.Trim + "' AND SENTIDO_CARGA = '" + objResumen.Rows(i)("SENTIDO_CARGA").ToString.Trim + "' AND LOTE = '" + objResumen.Rows(i)("LOTE").ToString.Trim + "'")
            objDataRow = objResumenFin.NewRow
            objDataRow.Item("CLIENTE") = objResumen.Rows(i)("CLIENTE").ToString.Trim
            objDataRow.Item("SENTIDO_CARGA") = objResumen.Rows(i)("SENTIDO_CARGA").ToString.Trim
            objDataRow.Item("LOTE") = objResumen.Rows(i)("LOTE").ToString.Trim

            objResumenFin.Rows.Add(objDataRow)
            For Each dr As DataRow In drSelect
                objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item("PESO_" + dr("PLANTA").ToString.Trim) = dr("KG").ToString.Trim
                objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item("VOLUMEN_" + dr("PLANTA").ToString.Trim) = dr("M3").ToString.Trim
                objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item("BULTO_" + dr("PLANTA").ToString.Trim) = dr("BUL").ToString.Trim
                objResumenFin.AcceptChanges()
            Next
            i = i + drSelect.Length - 1
        Next
        objResumenFin.TableName = "DT_Resumen_Sentido"
        objResumenFin.Namespace = "Resumen Sentido Carga"

        Return (objResumenFin)

    End Function


    Public Function dtListarConsultaIntegralOC(ByVal obe_IngresoMovimientos As beIngresoMovimientos) As DataTable
        Dim odtConsultaIntegral As New DataTable
        odtConsultaIntegral = oDatos.dtListarConsultaIntegralOC(obe_IngresoMovimientos)
        Return odtConsultaIntegral
    End Function

    Public Function dtListarConsultaIntegralOCItem(ByVal obe_IngresoMovimientos As beIngresoMovimientos) As DataTable
        Dim odtConsultaIntegral As New DataTable
        odtConsultaIntegral = oDatos.dtListarConsultaIntegralItem(obe_IngresoMovimientos)
        Return odtConsultaIntegral
    End Function
End Class
