Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad

Public Class clsResumenEjecutivo

    Public Function ResumenAlmacenes(ByVal pobjFiltro As beResumenEjecutivo) As DataSet
        Dim ds As DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", pobjFiltro.PSCCMPN)
        lobjParams.Add("PSCDVSN", "R")
        lobjParams.Add("PSCPLNDV", pobjFiltro.PSCPLNDV)
        lobjParams.Add("PNCCLNT", pobjFiltro.PNCCLNT)
        lobjParams.Add("PNFECINI", pobjFiltro.PNFECINI)
        lobjParams.Add("PNFECFIN", pobjFiltro.PNFECFIN)

        ds = lobjSql.ExecuteDataSet("SP_SOLMIN_SA_INDICADORES_X_MES_LM_5", lobjParams)
        ds.Tables(0).TableName = "dtSA_Recepcion"
        ds.Tables(1).TableName = "dtSA_Despacho"
        ds.Tables(2).TableName = "dtSA_StockTiempo"
        ds.Tables(3).TableName = "dtSA_ValorRecepcion"
        ds.Tables(4).TableName = "dtSA_ValorDespacho"

        Dim drSelect As DataRow() = Nothing
        Dim drMovimiento As DataRow = Nothing
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            drMovimiento = ds.Tables(0).Rows(i)
            If Not drMovimiento("STPING") Is Nothing Then
                drSelect = ds.Tables(3).Select("CODIGO = '" & drMovimiento("STPING") & "'")
            Else
                drSelect = Nothing
            End If

            If Not drSelect Is Nothing AndAlso drSelect.Length > 0 Then
                drMovimiento("VALOR") = drSelect(0)("VALOR")
                drMovimiento.AcceptChanges()
            End If
        Next

        For i As Integer = 0 To ds.Tables(1).Rows.Count - 1
            drMovimiento = ds.Tables(1).Rows(i)
            If Not drMovimiento("STPING") Is Nothing Then
                drSelect = ds.Tables(4).Select("CODIGO = '" & drMovimiento("STPING") & "'")
            Else
                drSelect = Nothing
            End If

            If Not drSelect Is Nothing AndAlso drSelect.Length > 0 Then
                drMovimiento("VALOR") = drSelect(0)("VALOR")
                drMovimiento.AcceptChanges()
            End If
        Next

        'Añade la Valorizacion  Recepciones - Despachos
        Dim dtResumen As DataTable = ds.Tables(0).Clone
        dtResumen.Columns.Remove("STPING")
        dtResumen.Columns.Add("Titulo", System.Type.GetType("System.String"))
        dtResumen.Columns.Add("Subtitulo", System.Type.GetType("System.String"))
        dtResumen.Columns.Add("Estado", System.Type.GetType("System.String"))
        dtResumen.Columns.Add("RATIO", System.Type.GetType("System.Decimal"))

        dtResumen.TableName = "dtSIL_RTipoMovimiento"

        Dim dr As DataRow = Nothing
        For Each drIngreso As DataRow In ds.Tables(0).Rows
            dr = dtResumen.NewRow()
            dr("Subtitulo") = "INGRESOS"
            dr("TIPO") = drIngreso("TIPO").ToString.Trim
            dr("CANTIDAD") = drIngreso("CANTIDAD")
            dr("PESO") = Math.Round(drIngreso("PESO"), 2, MidpointRounding.AwayFromZero)
            dr("MT2") = drIngreso("MT2")
            dr("UNIDADES") = drIngreso("UNIDADES")
            dr("OC") = drIngreso("OC")
            dr("ITEM") = drIngreso("ITEM")
            dr("VALOR") = Math.Round(drIngreso("VALOR"), 2, MidpointRounding.AwayFromZero)
            If drIngreso("PESO") = 0 Then
                dr("RATIO") = 0
            Else
                dr("RATIO") = Math.Round(dr("VALOR") / drIngreso("PESO"), 2, MidpointRounding.AwayFromZero)
            End If
            dr("Estado") = ""
            dtResumen.Rows.Add(dr)
        Next

        For Each drDespacho As DataRow In ds.Tables(1).Rows
            dr = dtResumen.NewRow()
            dr("Subtitulo") = "DESPACHOS"
            dr("TIPO") = drDespacho("TIPO").ToString.Trim
            dr("CANTIDAD") = drDespacho("CANTIDAD")
            dr("PESO") = Math.Round(drDespacho("PESO"), 2, MidpointRounding.AwayFromZero)
            dr("MT2") = drDespacho("MT2")
            dr("UNIDADES") = drDespacho("UNIDADES")
            dr("OC") = drDespacho("OC")
            dr("ITEM") = drDespacho("ITEM")
            dr("VALOR") = Math.Round(drDespacho("VALOR"), 2, MidpointRounding.AwayFromZero)
            If drDespacho("PESO") = 0 Then
                dr("RATIO") = 0
            Else
                dr("RATIO") = Math.Round(dr("VALOR") / drDespacho("PESO"), 2, MidpointRounding.AwayFromZero)
            End If
            dr("Estado") = ""
            dtResumen.Rows.Add(dr)
        Next

        'Crea la tabla para el grafico de Peso X Año
        Dim dtPesoMovimiento As New DataTable("dtSA_PesoMovimiento")
        dtPesoMovimiento.Columns.Add("MOVIMIENTO", System.Type.GetType("System.String"))
        dtPesoMovimiento.Columns.Add("PESO", System.Type.GetType("System.Decimal"))
        dtPesoMovimiento.Columns.Add("PORCENTAJE", System.Type.GetType("System.Decimal"))

        Dim dblSumaDespacho As Decimal = 0
        Dim dblSumaIngreso As Decimal = 0
        If ds.Tables(0).Rows.Count > 0 Then
            dr = dtPesoMovimiento.NewRow
            dblSumaIngreso = ds.Tables(0).Compute("Sum(PESO)", "")
            dr("MOVIMIENTO") = "RECEPCION"
            'Toneladas
            dr("PESO") = dblSumaIngreso
            dtPesoMovimiento.Rows.Add(dr)
        End If

        If ds.Tables(1).Rows.Count > 0 Then
            dblSumaDespacho = ds.Tables(1).Compute("Sum(PESO)", "")
            dr = dtPesoMovimiento.NewRow
            dr("MOVIMIENTO") = "DESPACHO"
            'Toneladas
            dr("PESO") = dblSumaDespacho
            dtPesoMovimiento.Rows.Add(dr)
            ds.Tables.Add(dtPesoMovimiento)
        End If

        For Each drPeso As DataRow In dtPesoMovimiento.Rows
            If dblSumaDespacho > 0 AndAlso dblSumaIngreso > 0 Then
                drPeso("PORCENTAJE") = (drPeso("PESO") / (dblSumaDespacho + dblSumaIngreso)) * 100
                dtPesoMovimiento.AcceptChanges()
            End If
        Next

        Dim dtTituloDesc As New DataTable("dtSA_Titulo")
        dtTituloDesc.Columns.Add("DESCRIPCION", System.Type.GetType("System.String"))
        dr = dtTituloDesc.NewRow
        Dim sb As New Text.StringBuilder

        If ds.Tables(2).Rows.Count > 0 Then
            sb.Append("""Se cuenta con un stock de ")
            sb.Append(String.Format("{0:0,0}", (ds.Tables(2).Compute("Sum(CANTIDAD)", "")).ToString))
            sb.Append(" Bultos  desde el año ")
            sb.Append(ds.Tables(2).Rows(0)("ANIO"))
            sb.Append(" hasta la fecha, ")
            sb.Append(" ocupando ")
            sb.Append(String.Format("{0:0,0}", (ds.Tables(2).Compute("Sum(MT2)", "")).ToString))
            sb.Append(" metros cuadrados"".")

            dr("DESCRIPCION") = sb.ToString
            dtTituloDesc.Rows.Add(dr)
        End If
        If ds.Tables(0).Rows.Count > 0 AndAlso ds.Tables(1).Rows.Count > 0 Then
            drMovimiento = dtTituloDesc.NewRow
            sb = New Text.StringBuilder
            sb.Append("se recepcionaron ")
            sb.Append(String.Format("{0:0,0.00}", ds.Tables(0).Compute("Sum(PESO)", "")))
            sb.Append(" TN ")
            sb.Append(" y se despacharon ")
            sb.Append(String.Format("{0:0,0.00}", ds.Tables(1).Compute("Sum(PESO)", "")))
            sb.Append(" TN"".")
            drMovimiento("DESCRIPCION") = sb.ToString
            dtTituloDesc.Rows.Add(drMovimiento)
        End If

        ds.Tables.Add(dtResumen)
        ds.Tables.Add(dtTituloDesc)
        Return ds
    End Function

    Public Function ResumenTransportes(ByVal pobjFiltro As beResumenEjecutivo) As DataSet
        Dim ds As DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", pobjFiltro.PSCCMPN)
        lobjParams.Add("PSCDVSN", "T")
        lobjParams.Add("PSCPLNDV", pobjFiltro.PSCPLNDV)
        lobjParams.Add("PNCCLNT", pobjFiltro.PNCCLNT)
        lobjParams.Add("PNFECINI", pobjFiltro.PNFECINI)
        lobjParams.Add("PNFECFIN", pobjFiltro.PNFECFIN)
        ds = lobjSql.ExecuteDataSet("SP_SOLMIN_ST_INDICADORES_X_MES_LM_3", lobjParams)

        ds.Tables(0).TableName = "dtST_TotalesTransporte"
        ds.Tables(1).TableName = "dtST_Unidades"
        ds.Tables(2).TableName = "dtST_ViajesXRuta"
        ds.Tables(3).TableName = "dtST_Propietario"


        Dim dtMedio As New DataTable("dtST_MedioTransporte")
        dtMedio.Columns.Add("CODIGO", System.Type.GetType("System.Int32"))
        dtMedio.Columns.Add("MEDIO", System.Type.GetType("System.String"))
        dtMedio.Columns.Add("CODPLANTA", System.Type.GetType("System.Int32"))

        If Not ds.Tables(0) Is Nothing AndAlso ds.Tables(0).Rows.Count() > 0 Then
            Dim dwDiv As New DataView(ds.Tables(0))
            Dim dtDiv As DataTable
            dtDiv = dwDiv.ToTable(True, "CodigoMedio", "Medio")
            Dim dr As DataRow
            For Each Item As DataRow In dtDiv.Rows
                dr = dtMedio.NewRow()
                dr("CODIGO") = Item("CodigoMedio")
                dr("MEDIO") = Item("Medio")
                dr("CODPLANTA") = pobjFiltro.PSCPLNDV
                dtMedio.Rows.Add(dr)
            Next
        Else
            Dim dr As DataRow
            dr = dtMedio.NewRow()
            dr("CODIGO") = 0
            dr("MEDIO") = ""
            dr("CODPLANTA") = pobjFiltro.PSCPLNDV
            dtMedio.Rows.Add(dr)

        End If


        Dim dt As DataTable = ds.Tables(3)
        dt.Columns.Add("VIAJE_POR", System.Type.GetType("System.Decimal"))
        dt.Columns.Add("PESO_POR", System.Type.GetType("System.Decimal"))
        dt.Columns.Add("RATIO", System.Type.GetType("System.Decimal"))
        dt.Columns.Add("RATIO_TOTAL", System.Type.GetType("System.Decimal"))
        'dt.Columns.Add("CodigoMedio", System.Type.GetType("System.Int32"))
        'dt.Columns.Add("Medio", System.Type.GetType("System.String"))


        If Not dt Is Nothing AndAlso dt.Rows.Count() > 0 Then
            Dim dblTotalPeso As Double = dt.Compute("Sum(PESO)", "")
            Dim dblTotalViaje As Double = dt.Compute("Sum(VIAJE)", "")
            If dblTotalPeso > 0 AndAlso dblTotalViaje > 0 Then
                For Each drr As DataRow In dt.Rows
                    drr("VIAJE_POR") = (drr("VIAJE") / dblTotalViaje) * 100
                    drr("PESO_POR") = (drr("PESO") / dblTotalPeso) * 100
                    drr("RATIO") = drr("PESO") / drr("VIAJE")
                    drr("RATIO_TOTAL") = dblTotalPeso / dblTotalViaje
                    'drr("CodigoMedio") = drr("CodigoMedio")
                    'drr("Medio") = drr("Medio")

                Next
            End If
        End If

        Dim dtResumen As New DataTable("dtST_Resumen")
        dtResumen.Columns.Add("Titulo", System.Type.GetType("System.String"))
        dtResumen.Columns.Add("Indicador", System.Type.GetType("System.String"))
        dtResumen.Columns.Add("Valor", System.Type.GetType("System.Double"))
        dtResumen.Columns.Add("Estado", System.Type.GetType("System.String"))
        dtResumen.Columns.Add("CodigoMedio", System.Type.GetType("System.Int32"))
        dtResumen.Columns.Add("Medio", System.Type.GetType("System.String"))

        If ds.Tables(0).Rows.Count > 0 Then
            Dim dr As DataRow

            For Each drr As DataRow In ds.Tables(0).Rows
                'Crea los Registro de 
                dr = dtResumen.NewRow()
                dr("Titulo") = "TRASLADOS TERRESTRES (US$/TN)"
                dr("Indicador") = "IMPORTE"
                dr("Valor") = drr("IMPORTE") / drr("PESO")
                dr("Estado") = "X"
                dr("CodigoMedio") = drr("CodigoMedio")
                dr("Medio") = drr("Medio")
                dtResumen.Rows.Add(dr)

                dr = dtResumen.NewRow()
                dr("Titulo") = "NÚMERO DE VIAJES REALIZADOS"
                dr("Indicador") = "VIAJE"
                dr("Valor") = drr("VIAJE")
                dr("Estado") = "X"
                dr("CodigoMedio") = drr("CodigoMedio")
                dr("Medio") = drr("Medio")
                dtResumen.Rows.Add(dr)

                dr = dtResumen.NewRow()
                dr("Titulo") = "KILOMETRAJE RECORRIDO"
                dr("Indicador") = "KM"
                dr("Valor") = drr("KILOMETRAJE")
                dr("Estado") = "X"
                dr("CodigoMedio") = drr("CodigoMedio")
                dr("Medio") = drr("Medio")
                dtResumen.Rows.Add(dr)

                dr = dtResumen.NewRow()
                dr("Titulo") = "PESO TOTAL(TN) "
                dr("Indicador") = ""
                dr("Valor") = drr("PESO")
                dr("Estado") = "X"
                dr("CodigoMedio") = drr("CodigoMedio")
                dr("Medio") = drr("Medio")
                dtResumen.Rows.Add(dr)
            Next


            'TIPO DE UNIDAD
            Dim dtResumenTipoUnidad As New DataTable("dtST_RTipoUnidad")
            dtResumenTipoUnidad.Columns.Add("INDICADOR", System.Type.GetType("System.String"))
            dtResumenTipoUnidad.Columns.Add("UNIDADES", System.Type.GetType("System.Double"))
            dtResumenTipoUnidad.Columns.Add("KILOMETRAJE", System.Type.GetType("System.Double"))
            dtResumenTipoUnidad.Columns.Add("PESO", System.Type.GetType("System.Double"))
            dtResumenTipoUnidad.Columns.Add("IMPORTE", System.Type.GetType("System.Double"))
            dtResumenTipoUnidad.Columns.Add("RATIO", System.Type.GetType("System.Double"))
            dtResumenTipoUnidad.Columns.Add("CodigoMedio", System.Type.GetType("System.Int32"))
            dtResumenTipoUnidad.Columns.Add("Medio", System.Type.GetType("System.String"))

            Dim peso As Double = 0
            For Each drUnidad As DataRow In ds.Tables(1).Rows
                dr = dtResumenTipoUnidad.NewRow()
                peso = Math.Round(drUnidad("PESO"), 2, MidpointRounding.AwayFromZero)
                dr("INDICADOR") = drUnidad("TUNDVH")
                dr("UNIDADES") = drUnidad("UNIDADES")
                dr("KILOMETRAJE") = drUnidad("KILOMETRAJE")
                dr("PESO") = peso
                dr("IMPORTE") = drUnidad("IMPORTE")

                If peso > 0 Then
                    dr("RATIO") = drUnidad("IMPORTE") / peso
                Else
                    dr("RATIO") = drUnidad("IMPORTE")
                End If
                dr("CodigoMedio") = drUnidad("CodigoMedio")
                dr("Medio") = drUnidad("Medio")
                dtResumenTipoUnidad.Rows.Add(dr)
            Next

            'RUTAS
            Dim dtResumenRuta As New DataTable("dtST_RRuta")
            dtResumenRuta.Columns.Add("INDICADOR", System.Type.GetType("System.String"))
            dtResumenRuta.Columns.Add("VIAJE", System.Type.GetType("System.Double"))
            dtResumenRuta.Columns.Add("KILOMETRAJE", System.Type.GetType("System.Double"))
            dtResumenRuta.Columns.Add("PESO", System.Type.GetType("System.Double"))
            dtResumenRuta.Columns.Add("IMPORTE", System.Type.GetType("System.Double"))
            dtResumenRuta.Columns.Add("RATIO", System.Type.GetType("System.Double"))
            dtResumenRuta.Columns.Add("CodigoMedio", System.Type.GetType("System.Int32"))
            dtResumenRuta.Columns.Add("Medio", System.Type.GetType("System.String"))



            For Each drUnidad As DataRow In ds.Tables(2).Rows
                dr = dtResumenRuta.NewRow()
                peso = Math.Round(drUnidad("PESO"), 2, MidpointRounding.AwayFromZero)
                dr("INDICADOR") = drUnidad("RUTA")
                dr("VIAJE") = drUnidad("VIAJE")
                dr("KILOMETRAJE") = drUnidad("KILOMETRAJE")
                dr("PESO") = peso
                dr("IMPORTE") = drUnidad("IMPORTE")
                If peso > 0 Then
                    dr("RATIO") = drUnidad("IMPORTE") / peso
                Else
                    dr("RATIO") = drUnidad("IMPORTE")
                End If
                dr("CodigoMedio") = drUnidad("CodigoMedio")
                dr("Medio") = drUnidad("Medio")
                dtResumenRuta.Rows.Add(dr)
            Next

            Dim dtTituloDesc As New DataTable("dtST_Titulo")
            dtTituloDesc.Columns.Add("DESCRIPCION", System.Type.GetType("System.String"))
            dtTituloDesc.Columns.Add("CodigoMedio", System.Type.GetType("System.Int32"))
            dtTituloDesc.Columns.Add("Medio", System.Type.GetType("System.String"))
            For Each drmedio As DataRow In ds.Tables(0).Rows

                dr = dtTituloDesc.NewRow
                Dim sb As New Text.StringBuilder

                sb.Append("""Alcanzamos ")
                sb.Append(String.Format("{0:n}", drmedio("KILOMETRAJE")))
                sb.Append(" kilómetros recorridos")

                Dim dtDiv As New DataTable
                Dim dwDiv As New DataView(ds.Tables(1))
                dwDiv.RowFilter = "CodigoMedio =" & drmedio("CodigoMedio")
                dtDiv = dwDiv.ToTable()

                If dtDiv.Rows.Count > 0 Then
                    sb.Append(", destacando entre los acoplados ")

                    Dim drr As DataRow = dtDiv.Select("UNIDADES = MAX(UNIDADES)")(0)
                    sb.Append(String.Format("{0:0,0}", drr("UNIDADES")))
                    sb.Append(" ")
                    If drr("UNIDADES") = 1 Then
                        sb.Append(drr("TUNDVH").ToString.Trim.ToLower)
                    Else
                        IsVocalPlural(drr("TUNDVH").ToString.Trim.ToLower, sb)
                    End If

                    sb.Append(""".")
                    dr("DESCRIPCION") = sb.ToString
                    dr("CodigoMedio") = drmedio("CodigoMedio")
                    dr("Medio") = drmedio("Medio")
                    dtTituloDesc.Rows.Add(dr)
                End If
            Next


            ds.Tables.Add(dtTituloDesc)
            ds.Tables.Add(dtResumenTipoUnidad)
            ds.Tables.Add(dtResumenRuta)
            ds.Tables.Add(dtResumen)
        End If
        ds.Tables.Add(dtMedio)
        Return ds
    End Function

    Public Function ResumenCuentaCorriente(ByVal pobjFiltro As beResumenEjecutivo) As DataSet
        'Dim ds As New DataSet("dsResumenEjecutivoCT")
        'Dim lobjSql As New SqlManager
        'Dim lobjParams As New Parameter
        'lobjParams.Add("PSCCMPN", pobjFiltro.Parametro1)
        'lobjParams.Add("PNCCLNT", pobjFiltro.Parametro2)
        'lobjParams.Add("PNFECINI ", pobjFiltro.Parametro3)
        'lobjParams.Add("PNFECFIN ", pobjFiltro.Parametro4)
        'Dim dt As New DataTable
        'dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SC_INDICADORES_X_MES", lobjParams)
        'Dim dtResumen As New DataTable("dtCT_Resumen")
        'dtResumen.Columns.Add("Titulo", System.Type.GetType("System.String"))
        'dtResumen.Columns.Add("SubTitulo", System.Type.GetType("System.String"))
        'dtResumen.Columns.Add("Indicador", System.Type.GetType("System.String"))
        'dtResumen.Columns.Add("Valor", System.Type.GetType("System.Double"))
        'dtResumen.Columns.Add("Estado", System.Type.GetType("System.String"))
        'Dim dr As DataRow = Nothing
        'If dt.Rows.Count > 0 Then
        '    For Each drTable As DataRow In dt.Rows
        '        dr = dtResumen.NewRow()
        '        dr("Titulo") = drTable("TCMTPD").ToString.ToUpper  'Tipo de Documento
        '        dr("SubTitulo") = drTable("TCMPDV") 'Division
        '        dr("Indicador") = drTable("TCMTRF").ToString.ToUpper 'Servicio
        '        dr("Valor") = drTable("IVLDCD")
        '        dr("Estado") = ""
        '        dtResumen.Rows.Add(dr)
        '    Next
        'End If
        'ds.Tables.Add(dtResumen)
        'Return ds

        Dim ds As New DataSet("dsResumenEjecutivoCT")
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", pobjFiltro.PSCCMPN)
        lobjParams.Add("PSCPLNDV", pobjFiltro.PSCPLNDV)
        lobjParams.Add("PNCCLNT", pobjFiltro.PNCCLNT)
        lobjParams.Add("PNFECINI ", pobjFiltro.PNFECINI_SC)
        lobjParams.Add("PNFECFIN ", pobjFiltro.PNFECFIN_SC)
        Dim dt As New DataTable
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SC_INDICADORES_X_MES_LM", lobjParams)
        Dim dtResumen As New DataTable("dtCT_Resumen")
        dtResumen.Columns.Add("Titulo", System.Type.GetType("System.String"))
        dtResumen.Columns.Add("SubTitulo", System.Type.GetType("System.String"))
        dtResumen.Columns.Add("Indicador", System.Type.GetType("System.String"))
        dtResumen.Columns.Add("Valor", System.Type.GetType("System.Double"))
        dtResumen.Columns.Add("TotalDiv", System.Type.GetType("System.Double"))
        dtResumen.Columns.Add("TotalDOC", System.Type.GetType("System.Double"))
        dtResumen.Columns.Add("Total", System.Type.GetType("System.Double"))
        dtResumen.Columns.Add("Estado", System.Type.GetType("System.String"))

        Dim dr As DataRow = Nothing
        Dim dwTipoDOC As New DataView(dt)
        Dim dtTipoDoc As New DataTable
        dtTipoDoc = dwTipoDOC.ToTable(True, "TCMTPD")
        Dim Total As Double = 0
        Dim TotalDOC As Double = 0
        Dim TotalDiv As Double = 0

        If dt.Rows.Count > 0 Then
            Total = dt.Compute("SUM(IVLDCD)", "")
            For Each drTable As DataRow In dtTipoDoc.Rows
                Dim dwDoc As New DataView(dt)
                Dim dtDOC As New DataTable
                dwDoc.RowFilter = "TCMTPD = '" & drTable("TCMTPD") & "'"
                dtDOC = dwDoc.ToTable()
                If dtDOC.Rows.Count > 0 Then
                    TotalDOC = dtDOC.Compute("SUM(IVLDCD)", "")
                    Dim dwTipoDiv As New DataView(dtDOC)
                    Dim dtTipoDiv As New DataTable
                    dtTipoDiv = dwTipoDiv.ToTable(True, "ORDER_DIV")
                    For Each drTipoDiv As DataRow In dtTipoDiv.Rows
                        Dim dwDiv As New DataView(dtDOC)
                        Dim dtDiv As New DataTable
                        dwDiv.RowFilter = "ORDER_DIV = " & drTipoDiv("ORDER_DIV")
                        dtDiv = dwDiv.ToTable()
                        If dtDOC.Rows.Count > 0 Then
                            TotalDiv = dtDiv.Compute("SUM(IVLDCD)", "")
                            For Each drDiv As DataRow In dtDiv.Rows
                                dr = dtResumen.NewRow()
                                dr("Titulo") = drDiv("TCMTPD").ToString.Trim.ToUpper  'Tipo de Documento
                                dr("SubTitulo") = drDiv("TCMPDV").ToString.Trim.ToUpper 'Division
                                dr("Indicador") = drDiv("TCMTRF").ToString.Trim.ToUpper 'Servicio
                                dr("Valor") = drDiv("IVLDCD")
                                dr("TotalDiv") = TotalDiv
                                dr("TotalDOC") = TotalDOC
                                dr("Total") = Total
                                dr("Estado") = ""
                                dtResumen.Rows.Add(dr)
                            Next
                        End If
                    Next
                End If
            Next
        End If

        'Grafico Facturas X Division
        Dim dtFacturaXDivision As New DataTable("dtCT_FACT_CRED")
        dtFacturaXDivision.Columns.Add("CODIGO", System.Type.GetType("System.String"))
        dtFacturaXDivision.Columns.Add("TIPO", System.Type.GetType("System.String"))
        dtFacturaXDivision.Columns.Add("CANTIDAD", System.Type.GetType("System.Decimal"))
        dtFacturaXDivision.Columns.Add("PORCENTAJE", System.Type.GetType("System.Decimal"))

        Dim dwResumen As New DataView(dtResumen)
        Dim dtR As New DataTable
        dwResumen.RowFilter = "Titulo = 'FACTURA'"
        dtR = dwResumen.ToTable(True, "SubTitulo", "TotalDiv")
        For Each drR As DataRow In dtR.Rows
            dr = dtFacturaXDivision.NewRow()
            dr("TIPO") = drR("SubTitulo")
            dr("CANTIDAD") = drR("TotalDiv") / 1000
            dtFacturaXDivision.Rows.Add(dr)
        Next
        ds.Tables.Add(dtResumen)
        ds.Tables.Add(dtFacturaXDivision)
        Return ds

    End Function

    Private Sub IsVocalPlural(ByVal i As String, ByVal sb As Text.StringBuilder)
        Dim strArary As String() = Split(i.Trim, " ")
        If strArary.Length > 0 Then
            Select Case Microsoft.VisualBasic.Right(strArary(0), 1).ToLower
                Case "a", "e", "i", "o", "u"
                    sb.Append(strArary(0))
                    sb.Append("s ")
                    For j As Integer = 1 To strArary.Length - 1
                        sb.Append(strArary(j).ToString)
                    Next
                    ' sb.Append("empleadas ")
                Case Else
                    sb.Append(strArary(0))
                    sb.Append("es ")
                    For j As Integer = 1 To strArary.Length - 1
                        sb.Append(strArary(j).ToString)
                    Next
                    ' sb.Append("empleados ")
            End Select
        End If
    End Sub

    Public Function ResumenSIL(ByVal pobjFiltro As beResumenEjecutivo) As DataSet
        Dim ds As New DataSet
        Dim ObjAgencimiemientoDAL As New clsResumenEjecutivoSIL
        ObjAgencimiemientoDAL.CalcularDatos(pobjFiltro)

        Dim dtResumen As New DataTable("dtSIL_Resumen")
        dtResumen.Columns.Add("Titulo", System.Type.GetType("System.String"))
        dtResumen.Columns.Add("Subtitulo", System.Type.GetType("System.String"))
        dtResumen.Columns.Add("Indicador", System.Type.GetType("System.String"))
        dtResumen.Columns.Add("Valor", System.Type.GetType("System.Decimal"))
        dtResumen.Columns.Add("Estado", System.Type.GetType("System.String"))
        dtResumen.Columns.Add("Total", System.Type.GetType("System.Decimal"))
        dtResumen.Columns.Add("SubTotal", System.Type.GetType("System.Decimal"))

        'Gráfico de Cantidad de Embarques X medio de Envio
        Dim dtEmbarquexMedio As New DataTable("dtSIL_EmbarquesxMedio")
        dtEmbarquexMedio.Columns.Add("CODIGO", System.Type.GetType("System.String"))
        dtEmbarquexMedio.Columns.Add("TIPO", System.Type.GetType("System.String"))
        dtEmbarquexMedio.Columns.Add("CANTIDAD", System.Type.GetType("System.Decimal"))
        dtEmbarquexMedio.Columns.Add("PORCENTAJE", System.Type.GetType("System.Decimal"))

        'Gráfico de Cantidad de Embarques X medio de Envio
        Dim dtEmbarquexCanal As New DataTable("dtSIL_EmbarquesxCanal")
        dtEmbarquexCanal.Columns.Add("CODIGO", System.Type.GetType("System.String"))
        dtEmbarquexCanal.Columns.Add("TIPO", System.Type.GetType("System.String"))
        dtEmbarquexCanal.Columns.Add("CANTIDAD", System.Type.GetType("System.Decimal"))
        dtEmbarquexCanal.Columns.Add("PORCENTAJE", System.Type.GetType("System.Decimal"))

        'grafico Costos Por Regimen
        Dim dtCostosXregimenAll As New DataTable()
        dtCostosXregimenAll.Columns.Add("TIPO", System.Type.GetType("System.String"))
        dtCostosXregimenAll.Columns.Add("CANTIDAD", System.Type.GetType("System.Decimal"))

        'Reporte de Cantidad de Embarques X medio de Envio
        Dim dtTituloDesc As New DataTable("dtSIL_Titulo")
        dtTituloDesc.Columns.Add("DESCRIPCION", System.Type.GetType("System.String"))

        Dim dr As DataRow

        ''Costos Totales
        Dim DtRCostosTotales As DataTable
        DtRCostosTotales = dtResumen.Clone()
        DtRCostosTotales.TableName = "dtSIL_ResumenCostos"

        Dim drCosto As DataRow = Nothing
        Dim TotalCosto As Decimal = 0
        Dim dblCIF As Decimal = 0
        Dim dblTotalDerecho As Decimal = 0

        'Artificio : Se colocara Estado  a los Costos que no tengan dependencia hacia otros Costos
        'CIF = FOB +  FLETE + SEGURO
        'TOTAL DERECHOS = ADVALOREM + TASA DE DESPACHO + IGV + IPM
        ' 'N' NEGRITA COSTO TOTAL DE UN CONJUNTO
        ' 'P' COSTO DEPENDIENTE
        ' VACIO CUALQUIER COSTO INDEPENDIENTE

        For Each dcCosto As DataColumn In ObjAgencimiemientoDAL.dtCostos.Columns
            If ObjAgencimiemientoDAL.dtCostos.Rows(0).Item(dcCosto.ColumnName) > 0 Then
                '  dr = dtResumen.NewRow()
                dr = DtRCostosTotales.NewRow()
                dr("Subtitulo") = "COSTOS TOTALES (US$)"
                dr("Indicador") = GetCosto(dcCosto.ColumnName)
                dr("Valor") = Math.Round(ObjAgencimiemientoDAL.dtCostos.Rows(0).Item(dcCosto.ColumnName), 2, MidpointRounding.AwayFromZero)
                dr("SubTotal") = 0
                dr("Total") = 0
                dr("Estado") = GetEstadoCosto(dcCosto.ColumnName)
                'drCosto("Subtitulo") = GetCosto(dcCosto.ColumnName)
                'drCosto("Valor") = Math.Round(ObjAgencimiemientoDAL.dtCostos.Rows(0).Item(dcCosto.ColumnName), 2)
                'dtResumen.Rows.Add(dr)
                DtRCostosTotales.Rows.Add(dr)
                If Not dr("Estado").Equals("N") Then
                    TotalCosto += dr("Valor")
                End If

            End If
        Next

        If DtRCostosTotales.Rows.Count > 0 Then
            DtRCostosTotales.Rows(0)("SubTotal") = TotalCosto
        End If

        '  DtEmbarqueCostos.Rows(IndexCosto)("Total") = TotalCosto
        'Costos x Regimen
        Dim DtRCostosRegimen As DataTable
        DtRCostosRegimen = dtResumen.Clone()
        DtRCostosRegimen.TableName = "dtSIL_RCostosRegimen"

        For Each drCostoxRegimen As DataRow In ObjAgencimiemientoDAL.dtCostosXRegimen.Rows
            If drCostoxRegimen.Item("CODIGO") > 0 Then
                For Each dcCostoxRegimen As DataColumn In ObjAgencimiemientoDAL.dtCostosXRegimen.Columns
                    If dcCostoxRegimen.ColumnName.ToLower.Contains("costo") AndAlso _
                       drCostoxRegimen.Item(dcCostoxRegimen.ColumnName) > 0 Then
                        'dr = dtResumen.NewRow()
                        dr = DtRCostosRegimen.NewRow()
                        dr("Titulo") = "IMPORTE POR REGIMEN (US$)"
                        dr("Subtitulo") = drCostoxRegimen("REGIMEN")
                        dr("Indicador") = GetCosto(Split(dcCostoxRegimen.ColumnName, "_")(0))
                        dr("Valor") = Math.Round(drCostoxRegimen.Item(dcCostoxRegimen.ColumnName), 2, MidpointRounding.AwayFromZero)
                        dr("Total") = 0
                        dr("SubTotal") = Math.Round(drCostoxRegimen.Item("TOTAL"), 2, MidpointRounding.AwayFromZero)
                        dr("Estado") = GetEstadoCosto(Split(dcCostoxRegimen.ColumnName, "_")(0))
                        '  dtResumen.Rows.Add(dr)
                        DtRCostosRegimen.Rows.Add(dr)
                    End If
                Next
            End If
        Next

        'Embarque x Medio
        '
        Dim strDescIndicador = ""
        Dim DtREmbarqueRegimen As DataTable
        DtREmbarqueRegimen = dtResumen.Clone()
        DtREmbarqueRegimen.TableName = "dtSIL_REmbarque"

        For Each drEmbarque As DataRow In ObjAgencimiemientoDAL.dtEmbarqueXRegimen.Rows
            If drEmbarque.Item("CODIGO") > 0 Then
                For Each dcEmbarquexRegimen As DataColumn In ObjAgencimiemientoDAL.dtEmbarqueXRegimen.Columns
                    If dcEmbarquexRegimen.ColumnName.ToLower.Contains("_") AndAlso _
                        drEmbarque(dcEmbarquexRegimen.ColumnName) > 0 Then
                        strDescIndicador = Split(dcEmbarquexRegimen.ColumnName, "_")(1)
                        dr = DtREmbarqueRegimen.NewRow()
                        dr("Titulo") = "EMBARQUES POR REGIMEN"
                        dr("Subtitulo") = drEmbarque("REGIMEN")
                        dr("Indicador") = "DESPACHO " & strDescIndicador
                        dr("Valor") = Math.Round(drEmbarque(dcEmbarquexRegimen.ColumnName), 2, MidpointRounding.AwayFromZero)
                        dr("Total") = ObjAgencimiemientoDAL.TotalEmbarque
                        dr("SubTotal") = Math.Round(drEmbarque("TOTAL"), 2, MidpointRounding.AwayFromZero)
                        dr("Estado") = ""
                        DtREmbarqueRegimen.Rows.Add(dr)
                    End If
                Next
            End If
        Next

        For Each drEmbarque As DataRow In ObjAgencimiemientoDAL.dtMedioTransporte.Rows
            If drEmbarque("CODIGO") <> 0 AndAlso drEmbarque("CANTIDAD") > 0 Then
                dr = dtEmbarquexMedio.NewRow()
                dr("TIPO") = "DESPACHO " & drEmbarque("TRANSPORTE")
                dr("CANTIDAD") = drEmbarque("CANTIDAD")
                dtEmbarquexMedio.Rows.Add(dr)
            End If
        Next

        ''Suma Los Embarques Por Medio Para El Pie
        Dim dblTotal As Double
        Dim drRegEmbarque As DataRow = Nothing
        If dtEmbarquexMedio.Rows.Count > 0 Then
            dblTotal = dtEmbarquexMedio.Compute("Sum(CANTIDAD)", "")
            For i As Integer = 1 To dtEmbarquexMedio.Rows.Count
                drRegEmbarque = dtEmbarquexMedio.Rows(i - 1)
                drRegEmbarque("CODIGO") = "M" & i.ToString.PadLeft(2, "0")
                drRegEmbarque("PORCENTAJE") = (drRegEmbarque("CANTIDAD") / dblTotal) * 100
                dtEmbarquexMedio.AcceptChanges()
            Next
        End If

        'Tipo de Canal
        Dim DtRTipoCanal As DataTable
        DtRTipoCanal = dtResumen.Clone()
        DtRTipoCanal.TableName = "dtSIL_RTipoCanal"

        For Each drEmbarque As DataRow In ObjAgencimiemientoDAL.dtCanalXRegimen.Rows
            If drEmbarque.Item("CODIGO") > 0 Then
                For Each dcEmbarquexRegimen As DataColumn In ObjAgencimiemientoDAL.dtCanalXRegimen.Columns
                    If dcEmbarquexRegimen.ColumnName.ToLower.Contains("_") AndAlso _
                        drEmbarque(dcEmbarquexRegimen.ColumnName) > 0 Then
                        strDescIndicador = Split(dcEmbarquexRegimen.ColumnName, "_")(1)
                        dr = DtRTipoCanal.NewRow()
                        dr("Titulo") = "TIPO DE CANAL"
                        dr("Subtitulo") = drEmbarque("REGIMEN")
                        dr("Indicador") = strDescIndicador
                        dr("Valor") = Math.Round(drEmbarque(dcEmbarquexRegimen.ColumnName), 2, MidpointRounding.AwayFromZero)
                        dr("Total") = 0 'ObjAgencimiemientoDAL.TotalEmbarque
                        dr("SubTotal") = Math.Round(drEmbarque("TOTAL"), 2, MidpointRounding.AwayFromZero)
                        dr("Estado") = ""
                        DtRTipoCanal.Rows.Add(dr)

                    End If
                Next
            End If
        Next

        ''Suma Los Embarques Por Canal Para El Pie
        For Each drCanal As DataRow In ObjAgencimiemientoDAL.dtCanal.Rows
            If drCanal("CODIGO") <> "" AndAlso drCanal("CANTIDAD") > 0 Then
                dr = dtEmbarquexCanal.NewRow()
                dr("TIPO") = drCanal("CANAL")
                dr("CANTIDAD") = drCanal("CANTIDAD")
                dtEmbarquexCanal.Rows.Add(dr)
            End If
        Next

        ''Suma Los Embarques Por Medio Para El Pie
        If dtEmbarquexCanal.Rows.Count > 0 Then
            dblTotal = dtEmbarquexCanal.Compute("Sum(CANTIDAD)", "")
            drRegEmbarque = Nothing
            For i As Integer = 1 To dtEmbarquexCanal.Rows.Count
                drRegEmbarque = dtEmbarquexCanal.Rows(i - 1)
                drRegEmbarque("CODIGO") = "C" & i.ToString.PadLeft(2, "0")
                drRegEmbarque("PORCENTAJE") = (drRegEmbarque("CANTIDAD") / dblTotal) * 100
                dtEmbarquexCanal.AcceptChanges()
            Next
        End If



        'Tiempo Promedio
        Dim DtRTiempoPromedio As DataTable
        DtRTiempoPromedio = dtResumen.Clone()
        DtRTiempoPromedio.TableName = "dtSIL_RTiempoPromedio"

        For Each drPromedio As DataRow In ObjAgencimiemientoDAL.dtTiempoPromedioXRegimen.Rows
            If drPromedio("CODIGO") <> 0 AndAlso drPromedio("TOTAL_MEDIO_EFECTIVO") > 0 AndAlso drPromedio("PROMEDIO") <> 0 Then
                dr = DtRTiempoPromedio.NewRow()
                dr("Titulo") = "TIEMPO PROMEDIO DE DESADUANAJE"
                dr("Subtitulo") = drPromedio("REGIMEN")
                dr("Indicador") = "TIEMPO PROMEDIO " & drPromedio("TRANSPORTE")
                dr("Valor") = drPromedio("PROMEDIO")
                dr("Estado") = ""
                dr("Total") = 0
                dr("SubTotal") = 0
                DtRTiempoPromedio.Rows.Add(dr)
            End If
        Next

        'Despachos
        Dim DtRTipoDespacho As DataTable
        DtRTipoDespacho = dtResumen.Clone()
        DtRTipoDespacho.TableName = "dtSIL_RTipoDespacho"

        For Each drEmbarque As DataRow In ObjAgencimiemientoDAL.dtDespachoXRegimen.Rows
            If drEmbarque.Item("CODIGO") > 0 Then
                For Each dcDespachoXRegimen As DataColumn In ObjAgencimiemientoDAL.dtDespachoXRegimen.Columns
                    If dcDespachoXRegimen.ColumnName.ToLower.Contains("_") AndAlso _
                        drEmbarque(dcDespachoXRegimen.ColumnName) > 0 Then
                        strDescIndicador = Split(dcDespachoXRegimen.ColumnName, "_")(1)
                        dr = DtRTipoDespacho.NewRow()
                        dr("Titulo") = "TIPO DESPACHO ADUANERO"
                        dr("Subtitulo") = drEmbarque("REGIMEN")
                        dr("Indicador") = strDescIndicador
                        dr("Valor") = Math.Round(drEmbarque(dcDespachoXRegimen.ColumnName), 2, MidpointRounding.AwayFromZero)
                        dr("Total") = 0 'ObjAgencimiemientoDAL.TotalEmbarque
                        dr("SubTotal") = Math.Round(drEmbarque("TOTAL"), 2, MidpointRounding.AwayFromZero)
                        dr("Estado") = ""
                        DtRTipoDespacho.Rows.Add(dr)

                    End If
                Next
            End If
        Next


        'Contenedores X Regimen
        Dim DtRContenedorRegimen As DataTable
        DtRContenedorRegimen = dtResumen.Clone()
        DtRContenedorRegimen.TableName = "dtSIL_RContenedorRegimen"

        For Each drEmbarque As DataRow In ObjAgencimiemientoDAL.dtContenedorXRegimen.Rows
            If drEmbarque.Item("CODIGO") > 0 Then
                For Each dcContenedorXRegimen As DataColumn In ObjAgencimiemientoDAL.dtContenedorXRegimen.Columns
                    If dcContenedorXRegimen.ColumnName.ToLower.Contains("_") AndAlso _
                        drEmbarque(dcContenedorXRegimen.ColumnName) > 0 Then
                        strDescIndicador = Split(dcContenedorXRegimen.ColumnName, "_")(1)
                        dr = DtRContenedorRegimen.NewRow()
                        dr("Titulo") = "CONTENEDORES POR REGIMEN"
                        dr("Subtitulo") = drEmbarque("REGIMEN")
                        dr("Indicador") = strDescIndicador
                        dr("Valor") = Math.Round(drEmbarque(dcContenedorXRegimen.ColumnName), 2, MidpointRounding.AwayFromZero)
                        dr("Total") = 0 'ObjAgencimiemientoDAL.TotalEmbarque
                        dr("SubTotal") = Math.Round(drEmbarque("TOTAL"), 2, MidpointRounding.AwayFromZero)
                        dr("Estado") = ""
                        DtRContenedorRegimen.Rows.Add(dr)
                    End If
                Next
            End If
        Next



        'Contenedores X linea Naviera
        Dim DtRContenedorLinea As DataTable
        DtRContenedorLinea = dtResumen.Clone()
        DtRContenedorLinea.TableName = "dtSIL_RContenedorLinea"

        For Each drEmbarque As DataRow In ObjAgencimiemientoDAL.dtContenedorXLineNaviera.Rows
            If drEmbarque.Item("CODIGO") > 0 Then
                For Each dcContenedorXLinea As DataColumn In ObjAgencimiemientoDAL.dtContenedorXLineNaviera.Columns
                    If dcContenedorXLinea.ColumnName.ToLower.Contains("_") AndAlso _
                        drEmbarque(dcContenedorXLinea.ColumnName) > 0 Then
                        strDescIndicador = Split(dcContenedorXLinea.ColumnName, "_")(1)
                        dr = DtRContenedorLinea.NewRow()

                        dr("Titulo") = "CONTENEDORES POR LINEA NAVIERA"
                        dr("Subtitulo") = drEmbarque("LINEA")
                        dr("Indicador") = strDescIndicador
                        dr("Valor") = Math.Round(drEmbarque(dcContenedorXLinea.ColumnName), 2, MidpointRounding.AwayFromZero)
                        dr("Total") = 0 'ObjAgencimiemientoDAL.TotalEmbarque
                        dr("SubTotal") = Math.Round(drEmbarque("TOTAL"), 2, MidpointRounding.AwayFromZero)
                        dr("Estado") = ""

                        DtRContenedorLinea.Rows.Add(dr)

                    End If
                Next
            End If
        Next




        'Regimenes
        'For Each drRegimenes As DataRow In ObjAgencimiemientoDAL.dtRegimen.Rows
        '    If drRegimenes("CODIGO") <> 0 AndAlso drRegimenes("CANTIDAD") > 0 Then
        '        dr = DtEmbarqueOtros.NewRow()
        '        dr("Titulo") = "REGIMENES"
        '        dr("Indicador") = drRegimenes("REGIMEN")
        '        dr("Valor") = drRegimenes("CANTIDAD")
        '        dr("Estado") = ""
        '        dr("Total") = 0
        '        DtEmbarqueOtros.Rows.Add(dr)
        '    End If
        'Next


        'Gráficos Costos por Regimen    
        Dim dtw As New DataView(DtRCostosRegimen)
        dtw.Sort = "SubTotal DESC"
        dtCostosXregimenAll = dtw.ToTable(True, "Subtitulo", "SubTotal")
        dtCostosXregimenAll.Columns(0).ColumnName = "TIPO"
        dtCostosXregimenAll.Columns(1).ColumnName = "CANTIDAD"
        dtCostosXregimenAll.Columns.Add("CODIGO", System.Type.GetType("System.String"))
        dtCostosXregimenAll.Columns.Add("PORCENTAJE", System.Type.GetType("System.Decimal"))
        dtCostosXregimenAll.TableName = "dtSIL_CostosXRegimen"

        Dim drRegCosto As DataRow = Nothing

        If dtCostosXregimenAll.Rows.Count > 0 Then
            dblTotal = dtCostosXregimenAll.Compute("Sum(CANTIDAD)", "")
            For i As Integer = 1 To dtCostosXregimenAll.Rows.Count
                drRegCosto = dtCostosXregimenAll.Rows(i - 1)
                drRegCosto("Codigo") = "R" & i.ToString.PadLeft(2, "0")
                drRegCosto("PORCENTAJE") = (drRegCosto("CANTIDAD") / dblTotal) * 100
                dtCostosXregimenAll.AcceptChanges()
            Next
        End If


        'Dim dtCostosXregimen As DataTable
        'dtCostosXregimen = dtCostosXregimenAll.Clone
        'Dim drOtros As DataRow = Nothing
        'Dim j As Integer = 1
        'For Each drContenedor As DataRow In dtCostosXregimenAll.Rows
        '    'Top 4
        '    If dtCostosXregimen.Rows.Count <= 2 Then
        '        drOtros = dtCostosXregimen.NewRow
        '        drOtros("TIPO") = drContenedor("TIPO")
        '        drOtros("CANTIDAD") = drContenedor("CANTIDAD")
        '        dtCostosXregimen.Rows.Add(drOtros)
        '    Else
        '        Dim drFin As DataRow = dtCostosXregimen.Rows(dtCostosXregimen.Rows.Count - 1)
        '        If drFin("TIPO") <> "OTROS" Then
        '            drOtros = dtCostosXregimen.NewRow
        '            'Valida si Hay mas Registros
        '            If (dtCostosXregimenAll.Rows.Count - j) = 0 Then
        '                drOtros("TIPO") = drContenedor("TIPO")
        '            Else
        '                drOtros("TIPO") = "OTROS"
        '            End If
        '            drOtros("CANTIDAD") = drContenedor("CANTIDAD")
        '            dtCostosXregimen.Rows.Add(drOtros)
        '        Else

        '            drFin("CANTIDAD") = drFin("CANTIDAD") + drContenedor("CANTIDAD")
        '            dtCostosXregimen.AcceptChanges()
        '        End If

        '    End If
        '    j += 1
        'Next



        'Gráfico ContenedoresxRegimen
        Dim dtContenedorXregimen As DataTable
        dtContenedorXregimen = dtEmbarquexCanal.Clone
        Dim dtw3 As New DataView(DtRContenedorRegimen)
        dtw3.Sort = "SubTotal DESC"
        dtContenedorXregimen = dtw3.ToTable(True, "Subtitulo", "SubTotal")
        dtContenedorXregimen.Columns(0).ColumnName = "TIPO"
        dtContenedorXregimen.Columns(1).ColumnName = "CANTIDAD"
        dtContenedorXregimen.Columns.Add("CODIGO", System.Type.GetType("System.String"))
        dtContenedorXregimen.Columns.Add("PORCENTAJE", System.Type.GetType("System.Decimal"))
        dtContenedorXregimen.TableName = "dtSIL_ContenedorXRegimen"

        If dtContenedorXregimen.Rows.Count > 0 Then
            dblTotal = dtContenedorXregimen.Compute("Sum(CANTIDAD)", "")
            drRegCosto = Nothing
            For i As Integer = 1 To dtContenedorXregimen.Rows.Count
                drRegCosto = dtContenedorXregimen.Rows(i - 1)
                drRegCosto("Codigo") = "R" & i.ToString.PadLeft(2, "0")
                drRegCosto("PORCENTAJE") = (drRegCosto("CANTIDAD") / dblTotal) * 100
                dtContenedorXregimen.AcceptChanges()
            Next
        End If


        'Gráfico ContenedoresxLinea
        Dim dtContenedorxLineaAll As DataTable
        dtContenedorxLineaAll = dtEmbarquexCanal.Clone
        Dim dtw2 As New DataView(DtRContenedorLinea)
        'dtw2.RowFilter = "Titulo = 'CONTENEDORES POR LINEA NAVIERA'"
        dtw2.Sort = "SubTotal DESC"
        dtContenedorxLineaAll = dtw2.ToTable(True, "Subtitulo", "SubTotal")
        dtContenedorxLineaAll.Columns(0).ColumnName = "TIPO"
        dtContenedorxLineaAll.Columns(1).ColumnName = "CANTIDAD"

        Dim dtContenedorxLinea As DataTable
        dtContenedorxLinea = dtContenedorxLineaAll.Clone
        dtContenedorxLinea.TableName = "dtSIL_ContenedorXLinea"
        dtContenedorxLinea.Columns.Add("CODIGO", System.Type.GetType("System.String"))
        dtContenedorxLinea.Columns.Add("PORCENTAJE", System.Type.GetType("System.Decimal"))

        'Solo 5 Partes en el Pie
        Dim drOtros As DataRow = Nothing
        Dim j As Integer = 1
        For Each drContenedor As DataRow In dtContenedorxLineaAll.Rows
            'Top 4
            If dtContenedorxLinea.Rows.Count <= 2 Then
                drOtros = dtContenedorxLinea.NewRow
                drOtros("TIPO") = drContenedor("TIPO")
                drOtros("CANTIDAD") = drContenedor("CANTIDAD")
                dtContenedorxLinea.Rows.Add(drOtros)
            Else
                Dim drFin As DataRow = dtContenedorxLinea.Rows(dtContenedorxLinea.Rows.Count - 1)
                If drFin("TIPO") <> "OTROS" Then
                    drOtros = dtContenedorxLinea.NewRow
                    'Valida si Hay mas Registros
                    If (dtContenedorxLineaAll.Rows.Count - j) = 0 Then
                        drOtros("TIPO") = drContenedor("TIPO")
                    Else
                        drOtros("TIPO") = "OTROS"
                    End If
                    drOtros("CANTIDAD") = drContenedor("CANTIDAD")
                    dtContenedorxLinea.Rows.Add(drOtros)
                Else

                    drFin("CANTIDAD") = drFin("CANTIDAD") + drContenedor("CANTIDAD")
                    dtContenedorxLinea.AcceptChanges()
                End If

            End If
            j += 1
        Next

        If dtContenedorxLinea.Rows.Count > 0 Then
            dblTotal = dtContenedorxLinea.Compute("Sum(CANTIDAD)", "")
            drRegCosto = Nothing
            For i As Integer = 1 To dtContenedorxLinea.Rows.Count
                drRegCosto = dtContenedorxLinea.Rows(i - 1)
                If drRegCosto("TIPO").Equals("OTROS") Then
                    drRegCosto("Codigo") = "OTROS"
                Else
                    drRegCosto("Codigo") = "L" & i.ToString.PadLeft(2, "0")
                End If
                drRegCosto("PORCENTAJE") = (drRegCosto("CANTIDAD") / dblTotal) * 100
                dtContenedorxLinea.AcceptChanges()
            Next
        End If




        'If ObjAgencimiemientoDAL.Vencimiento_RegimenXVencerMes > 0 Then
        '    dr = dtResumen.NewRow()
        '    dr("Titulo") = "VENCIMIENTO"
        '    dr("Indicador") = "CARTA FIANZA"
        '    dr("Valor") = ObjAgencimiemientoDAL.Vencimiento_CartaFianzaXVencerMes
        '    dr("Total") = 0
        '    dr("Estado") = ""
        '    dtResumen.Rows.Add(dr)
        'End If

        'If ObjAgencimiemientoDAL.Vencimiento_RegimenXVencerMes > 0 Then
        '    dr = dtResumen.NewRow()
        '    dr("Titulo") = "VENCIMIENTO"
        '    dr("Indicador") = "REGIMEN ADUANERO"
        '    dr("Valor") = ObjAgencimiemientoDAL.Vencimiento_RegimenXVencerMes
        '    dr("Total") = 0
        '    dr("Estado") = ""
        '    dtResumen.Rows.Add(dr)

        'End If

        ' Titulo del Reporte
        Dim sb As New Text.StringBuilder
        If ObjAgencimiemientoDAL.TotalEmbarque > 0 Then
            dr = dtTituloDesc.NewRow
            sb.Append("""El Costo CIF del Cliente ")
            'sb.AppendLine()
            sb.Append(pobjFiltro.RazonSocial)
            'sb.AppendLine()
            sb.Append(" suma un monto de US$ ")
            'sb.AppendLine()
            sb.Append(String.Format("{0:n}", Math.Round(ObjAgencimiemientoDAL.dtCostos.Rows(0).Item("CIF"), 2, MidpointRounding.AwayFromZero)))
            sb.Append(" , teniendo un flete valorizado en US$ ")
            sb.Append(String.Format("{0:n}", (Math.Round(ObjAgencimiemientoDAL.dtCostos.Rows(0).Item("FLETE"), 2, MidpointRounding.AwayFromZero))))
            sb.Append(". ")

            If ObjAgencimiemientoDAL.TotalEmbarque = 1 Then
                sb.Append("Se realizó 1 ")
                If DtREmbarqueRegimen.Rows.Count > 0 Then
                    sb.Append(DtREmbarqueRegimen.Rows(0).Item("Indicador").ToString.ToLower)
                End If
                sb.AppendLine()
                sb.Append(" el cual ")
                GetDespachosAnticipados(ObjAgencimiemientoDAL, sb)
            Else
                sb.Append(Chr(13))
                sb.Append("Se realizaron ")
                sb.Append(String.Format("{0:0,0}", ObjAgencimiemientoDAL.TotalEmbarque))
                sb.Append(" Despachos ")

                If DtRTipoDespacho.Rows.Count > 0 Then
                    sb.Append("entre  ")
                    Dim count As Integer = dtEmbarquexMedio.Rows.Count
                    Dim i As Integer = 1
                    For Each drEmbarque As DataRow In ObjAgencimiemientoDAL.dtMedioTransporte.Rows

                        If drEmbarque("CODIGO") <> 0 AndAlso drEmbarque("CANTIDAD") > 0 Then
                            Select Case drEmbarque("CODIGO")
                                Case 1, 2, 4
                                    sb.Append(drEmbarque("TRANSPORTE").ToString.ToLower + "s")
                                Case 3, 5
                                    sb.Append(drEmbarque("TRANSPORTE").ToString.ToLower + "es")
                                Case Else
                            End Select
                            If count - i = 1 Then
                                sb.Append(" y ")
                            ElseIf count <> i Then
                                sb.Append(", ")
                            End If
                            i += 1
                        End If
                    Next
                    sb.Append(", ")
                End If
                sb.Append("de los cuales ")
                GetDespachosAnticipados(ObjAgencimiemientoDAL, sb)
                dr("DESCRIPCION") = EquivalenciaMedioEnvio(sb.ToString)
            End If
            dtTituloDesc.Rows.Add(dr)
        End If

        'Titulo para los Contenedores
        dr = dtTituloDesc.NewRow
        sb = New Text.StringBuilder

        Dim dtContenedorValido As New DataTable
        Dim dwContenedorValido As New DataView(ObjAgencimiemientoDAL.dtContenedor)
        dwContenedorValido.RowFilter = "ES_CONTENEDOR = 'S' AND CANTIDAD <> 0 AND CODIGO <> 0"
        dtContenedorValido = dwContenedorValido.ToTable()

        Dim k As Integer = 1
        Dim countContador As Integer = dtContenedorValido.Rows.Count
        If countContador > 0 Then
            'Valida si Solo Hay un Registro
            If countContador = 1 Then
                sb.Append("""Se despachó ")
                Dim drContenedor As DataRow = dtContenedorValido.Rows(0)
                If drContenedor("CANTIDAD") > 1 Then
                    sb.Append(drContenedor("CANTIDAD"))
                    sb.Append(" contenedores de ")
                    sb.Append(drContenedor("CONTENEDOR"))
                Else
                    sb.Append("1 contenedor de ")
                    sb.Append(drContenedor("CONTENEDOR"))
                End If
            Else
                'Para Varios registros
                sb.Append("""Se despacharon ")
                For Each drContenedor As DataRow In dtContenedorValido.Rows

                    If drContenedor("CANTIDAD") > 1 Then
                        sb.Append(drContenedor("CANTIDAD"))
                        sb.Append(" contenedores de ")
                        sb.Append(drContenedor("CONTENEDOR"))
                    Else
                        sb.Append("1 contenedor de ")
                        sb.Append(drContenedor("CONTENEDOR"))
                    End If

                    If countContador - k = 1 Then
                        sb.Append(" y ")
                    ElseIf countContador <> k Then
                        sb.Append(", ")
                    End If
                    k += 1
                Next
            End If
            sb.Append(""".")
            dr("DESCRIPCION") = sb.ToString
            dtTituloDesc.Rows.Add(dr)
        End If
        'Orden Servicio 
        Dim dtOS As New DataTable()
        dtOS = ObjAgencimiemientoDAL.dtOrdenServicio.Copy
        dtOS.TableName = "dtSIL_OrdenServicio"

        ds.Tables.Add(dtTituloDesc)
        ' ds.Tables.Add(dtResumen)
        ds.Tables.Add(dtEmbarquexMedio)
        ds.Tables.Add(dtEmbarquexCanal)

        ds.Tables.Add(DtRCostosTotales)
        ds.Tables.Add(DtRCostosRegimen)
        ds.Tables.Add(DtREmbarqueRegimen)
        ds.Tables.Add(DtRTipoCanal)
        ds.Tables.Add(DtRTiempoPromedio)
        ds.Tables.Add(DtRTipoDespacho)
        ds.Tables.Add(DtRContenedorRegimen)
        ds.Tables.Add(DtRContenedorLinea)

        ds.Tables.Add(dtCostosXregimenAll)
        ds.Tables.Add(dtContenedorXregimen)
        ds.Tables.Add(dtContenedorxLinea)
        ds.Tables.Add(dtOS)
        Return ds

    End Function

    Private Function EquivalenciaMedioEnvio(ByVal strMedio As String) As String
        Return strMedio.Replace("aereo", "aéreo").Replace("maritimo", "marítimo")
    End Function

    Private Function GetDespachosAnticipados(ByVal ObjAgencimiemientoDAL As clsResumenEjecutivoSIL, ByVal sb As Text.StringBuilder) As String
        Dim strReturn As String = ""

        For Each drEmbarque As DataRow In ObjAgencimiemientoDAL.dtDespacho.Rows
            If drEmbarque("CODIGO") = 2 AndAlso drEmbarque("CANTIDAD") > 0 Then
                If drEmbarque("CANTIDAD") = 1 Then
                    sb.Append(" 1 fue Despacho Anticipado"".")
                Else
                    sb.Append(String.Format("{0:0,0}", drEmbarque("CANTIDAD")))
                    sb.Append(" fueron Despachos Anticipados"".")
                End If
            End If
        Next
        Return strReturn
    End Function

    Private Function GetCosto(ByVal Item As String) As String

        Dim strCosto As String = ""
        Select Case Item
            Case "EXW "
                strCosto = "EXW US$"
            Case "GFOB"
                strCosto = "GFOB US$"
            Case "FOB"
                strCosto = "FOB US$"
            Case "FLETE"
                strCosto = "FLETE US$"
            Case "SEGURO"
                strCosto = "SEGURO US$"
            Case "CIF"
                strCosto = "CIF US$"
            Case "ADVALO"
                strCosto = "ADVALOREM"
            Case "OTSGAS"
                strCosto = "TASA DE DESPACHO"
            Case "TOLDER"
                strCosto = "TOTAL DERECHOS US$"
            Case "ITTCAG"
                strCosto = "COMISION AGENCIAMIENTO"
            Case "ITTGOA"
                strCosto = "GASTOS OPERATIVOS AG.(AVISO DE DEBITO)"
            Case "ITTCRS"
                strCosto = "CARGO DEL SIL RANSA US$"
            Case "ITTCEM"
                strCosto = "CARGO DEL EMBARCADOR US$"
            Case "ALMLOC"
                strCosto = "ALMACENAJE LOCAL"
            Case "CARDES"
                strCosto = "CARGA Y DESCARGA EN ALMACEN "
            Case "ITTTRA"
                strCosto = "FLETE LOCAL"
            Case "CARDEC"
                strCosto = "CARGA Y DESCARGA EN DESTINO "
            Case "ITTRAC"
                strCosto = "TRACCION"
            Case Else
                strCosto = Item
        End Select
        Return strCosto
    End Function

    Private Function GetEstadoCosto(ByVal Item As String) As String
        Dim strDependencia As String = ""
        Select Case Item
            Case "FOB"
                strDependencia = "P"
            Case "FLETE"
                strDependencia = "P"
            Case "SEGURO"
                strDependencia = "P"
            Case "CIF"
                strDependencia = "N"
            Case "ADVALO"
                strDependencia = "P"
            Case "OTSGAS"
                strDependencia = "P"
            Case "IPM"
                strDependencia = "P"
            Case "IGV"
                strDependencia = "P"
            Case "TOLDER"
                strDependencia = "N"
        End Select
        Return strDependencia
    End Function

    Public Function ResumenSIl_CargaInternacional(ByVal pobjFiltro As beResumenEjecutivo) As DataSet
        Dim ds As New DataSet
        Dim dtRProveedorOC As New DataTable("dtSIL_RProvedorOC")
        dtRProveedorOC.Columns.Add("Codigo", System.Type.GetType("System.String"))
        dtRProveedorOC.Columns.Add("Indicador", System.Type.GetType("System.String"))
        dtRProveedorOC.Columns.Add("Dia", System.Type.GetType("System.Decimal"))
        dtRProveedorOC.Columns.Add("OC", System.Type.GetType("System.Decimal"))
        dtRProveedorOC.Columns.Add("DIAXOC", System.Type.GetType("System.Decimal"))
        dtRProveedorOC.Columns.Add("SubTotalDia", System.Type.GetType("System.Decimal"))
        dtRProveedorOC.Columns.Add("SubTotalOC", System.Type.GetType("System.Decimal"))

        Dim dtRPaisOC As New DataTable("dtSIL_RPaisOC")
        dtRPaisOC.Columns.Add("Indicador", System.Type.GetType("System.String"))
        dtRPaisOC.Columns.Add("Valor", System.Type.GetType("System.Decimal"))
        dtRPaisOC.Columns.Add("SubTotal", System.Type.GetType("System.Decimal"))

        Dim dtRIncotermsOC As New DataTable("dtSIL_RIncotermOC")
        dtRIncotermsOC.Columns.Add("Indicador", System.Type.GetType("System.String"))
        dtRIncotermsOC.Columns.Add("Valor", System.Type.GetType("System.Decimal"))
        dtRIncotermsOC.Columns.Add("SubTotal", System.Type.GetType("System.Decimal"))

        Dim dtRAgenteCargaOC As New DataTable("dtSIL_RAgenteCargaOC")
        dtRAgenteCargaOC.Columns.Add("Indicador", System.Type.GetType("System.String"))
        dtRAgenteCargaOC.Columns.Add("Valor", System.Type.GetType("System.Decimal"))
        dtRAgenteCargaOC.Columns.Add("SubTotal", System.Type.GetType("System.Decimal"))

        Dim dtAgenteCargaxOC As New DataTable("dtSIL_AgentesXOC")
        dtAgenteCargaxOC.Columns.Add("CODIGO", System.Type.GetType("System.String"))
        dtAgenteCargaxOC.Columns.Add("TIPO", System.Type.GetType("System.String"))
        dtAgenteCargaxOC.Columns.Add("CANTIDAD", System.Type.GetType("System.Decimal"))
        dtAgenteCargaxOC.Columns.Add("PORCENTAJE", System.Type.GetType("System.Decimal"))

        Dim ObjCargaInternacionalDAL As New clsResumenEjecutivoSIL_CI
        ObjCargaInternacionalDAL.Calculardatos(pobjFiltro)



        Dim dr As DataRow = Nothing

        For Each drProveedor As DataRow In ObjCargaInternacionalDAL.dtCIProveedor.Rows
            If Not drProveedor("PROVEEDOR").Equals("NINGUNO") AndAlso Not drProveedor("PROVEEDOR").ToString.Trim.Equals("") Then
                dr = dtRProveedorOC.NewRow()
                dr("Indicador") = drProveedor("PROVEEDOR")
                dr("Dia") = drProveedor("DIA")
                dr("OC") = drProveedor("OC")
                dr("DIAXOC") = drProveedor("DIA") * drProveedor("OC")
                dr("SubTotalDia") = 0
                dr("SubTotalOC") = 0
                dtRProveedorOC.Rows.Add(dr)

            End If
        Next

        Dim dtw As New DataView(dtRProveedorOC)
        dtw.Sort = "OC DESC"
        dtRProveedorOC = dtw.ToTable()
        Dim i As Integer = 1
        For Each drProveedor As DataRow In dtRProveedorOC.Rows
            drProveedor("Codigo") = "P" & i.ToString.PadLeft(2, "0")
            i = i + 1
        Next


        'Dim dtRProveedorOC_Otros As New DataTable
        'dtRProveedorOC_Otros = dtRProveedorOC.Clone
        'dtRProveedorOC_Otros = dtRProveedorOC 'Me.SetBarraOtros_Proveedor(dtRProveedorOC)

        'Totalaliza los Dias Promedios (Ponderado)
        Dim SubTotalOC As Double = 0
        Dim SubTotalDia As Double = 0
        If dtRProveedorOC.Rows.Count > 0 Then
            SubTotalOC = dtRProveedorOC.Compute("SUM(OC)", "")
            If SubTotalOC > 0 Then
                SubTotalDia = dtRProveedorOC.Compute("SUM(DIAXOC)", "") / SubTotalOC
            Else
                dtRProveedorOC.Rows(0)("SubTotalDia") = 0
            End If

            For Each drResumen As DataRow In dtRProveedorOC.Rows
                drResumen("SubTotalDia") = SubTotalDia
                drResumen("SubTotalOC") = SubTotalOC
                dtRProveedorOC.AcceptChanges()
            Next
        End If

        'PAIS POR ORDEN DE COMPRA
        For Each drProveedor As DataRow In ObjCargaInternacionalDAL.dtCIPais.Rows
            If Not drProveedor("PAIS").Equals("NINGUNO") AndAlso Not drProveedor("PAIS").ToString.Trim.Equals("") Then
                dr = dtRPaisOC.NewRow()
                dr("Indicador") = drProveedor("PAIS")
                dr("Valor") = drProveedor("NRO OC")
                dr("SubTotal") = 0
                dtRPaisOC.Rows.Add(dr)
            End If
        Next

        Dim dtwPaisOrigen As New DataView(dtRPaisOC)
        dtwPaisOrigen.Sort = "Valor DESC"
        dtRPaisOC = dtwPaisOrigen.ToTable()

        Dim dtRPaisOC_Otros As New DataTable
        dtRPaisOC_Otros = dtRAgenteCargaOC.Clone
        dtRPaisOC_Otros = Me.SetBarraOtros(dtRPaisOC)

        'INCOTERMS POR ORDEN DE COMPRA

        For Each drProveedor As DataRow In ObjCargaInternacionalDAL.dtCIIncoterms.Rows
            If Not drProveedor("INCOTERMS").Equals("NINGUNO") AndAlso Not drProveedor("INCOTERMS").ToString.Trim.Equals("") Then
                dr = dtRIncotermsOC.NewRow()
                dr("Indicador") = drProveedor("INCOTERMS")
                dr("Valor") = drProveedor("NRO OC")
                dr("SubTotal") = 0
                dtRIncotermsOC.Rows.Add(dr)
            End If
        Next
        Dim dtwRIncotermsOC As New DataView(dtRIncotermsOC)
        dtwRIncotermsOC.Sort = "Valor DESC"
        dtRIncotermsOC = dtwRIncotermsOC.ToTable()


        'AGENTE DE CARGA
        For Each drProveedor As DataRow In ObjCargaInternacionalDAL.dtCIAgenteCarga.Rows
            If Not drProveedor("AGENTE DE CARGA").Equals("NINGUNO") AndAlso Not drProveedor("AGENTE DE CARGA").ToString.Trim.Equals("") Then
                dr = dtRAgenteCargaOC.NewRow()
                dr("Indicador") = drProveedor("AGENTE DE CARGA")
                dr("Valor") = drProveedor("NRO OC")
                dr("SubTotal") = 0
                dtRAgenteCargaOC.Rows.Add(dr)
            End If
        Next

        Dim dtwAgenteCarga As New DataView(dtRAgenteCargaOC)
        dtwAgenteCarga.Sort = "Valor DESC"
        dtRAgenteCargaOC = dtwAgenteCarga.ToTable()

        Dim dtRAgenteCargaOC_Otros As New DataTable
        dtRAgenteCargaOC_Otros = dtRAgenteCargaOC.Clone
        dtRAgenteCargaOC_Otros = Me.SetBarraOtros(dtRAgenteCargaOC)

        'Gráfico para Agente de Carga
        Me.PorcentajePieOtros(dtRAgenteCargaOC_Otros, dtAgenteCargaxOC, "A")

        'Textos para los Gráficos
        Dim dtTituloDesc As New DataTable("dtSIL_Titulo")
        dtTituloDesc.Columns.Add("DESCRIPCION", System.Type.GetType("System.String"))
        dr = dtTituloDesc.NewRow
        Dim sb As New Text.StringBuilder

        Dim dtTotalOC As New DataTable("DtTotalOC")
        dtTotalOC.Columns.Add("TotalOC", System.Type.GetType("System.Decimal"))
        Dim drTotalOC As DataRow = dtTotalOC.NewRow
        drTotalOC("TotalOC") = ObjCargaInternacionalDAL.dlbTotalOC
        dtTotalOC.Rows.Add(drTotalOC)

        'Texto para Proveedor
        If dtRProveedorOC.Rows.Count > 0 Then
            Dim dblMaxProveedor As Double = 0
            Dim dblMinProveedor As Double = 0
            dblMaxProveedor = dtRProveedorOC.Compute("Max(OC)", String.Empty)
            dblMinProveedor = dtRProveedorOC.Compute("Min(OC)", String.Empty)
            If dblMaxProveedor <> dblMinProveedor Then
                sb.Append("""")
                sb.Append(pobjFiltro.RazonSocial)
                sb.Append(" obtuvo ")
                sb.Append(String.Format("{0:0,0}", ObjCargaInternacionalDAL.dlbTotalOC.ToString))
                sb.Append(" O/C, identificando ")
                sb.Append(" al proveedor ")
                sb.Append(dtRProveedorOC.Rows(0)("Indicador"))
                sb.Append(" con ")
                sb.Append(String.Format("{0:0,0}", dblMaxProveedor.ToString))
                sb.Append(" O/C y ")
                sb.Append(" el proveedor ")
                sb.Append(dtRProveedorOC.Rows(dtRProveedorOC.Rows.Count - 1)("Indicador"))
                sb.Append(" con ")
                sb.Append(String.Format("{0:0,0}", dblMinProveedor.ToString))
                sb.Append(" O/C"".")
            Else
                sb.Append("Alcanzó ")
                sb.Append(String.Format("{0:0,0}", ObjCargaInternacionalDAL.dlbTotalOC.ToString))
                sb.Append(" O/C"".")
            End If
            dr("DESCRIPCION") = sb.ToString
            dtTituloDesc.Rows.Add(dr)
        End If

        'Texto para AgenteCarga
        If dtRAgenteCargaOC.Rows.Count > 0 Then
            Dim dblMaxAgente As Double = 0
            Dim dblMinAgente As Double = 0
            Dim drMovimiento As DataRow = dtTituloDesc.NewRow
            dblMaxAgente = dtRAgenteCargaOC.Compute("Max(VALOR)", String.Empty)
            dblMinAgente = dtRAgenteCargaOC.Compute("Min(VALOR)", String.Empty)
            sb = New Text.StringBuilder
            If dblMaxAgente <> dblMinAgente Then
                sb.Append("""El agente de carga ")
                sb.Append(dtRAgenteCargaOC.Rows(0)("Indicador"))
                sb.Append(" obtuvo mayor")
                sb.Append(" participación con ")
                sb.Append(String.Format("{0:0,0.00}", dblMaxAgente.ToString))
                sb.Append(" O/C ")
                sb.Append(" y ")
                sb.Append("el agente de carga ")
                sb.Append(dtRAgenteCargaOC.Rows(dtRAgenteCargaOC.Rows.Count - 1)("Indicador"))
                sb.Append(" obtuvo menor")
                sb.Append(" participación con ")
                sb.Append(String.Format("{0:0,0.00}", dblMinAgente.ToString))
                sb.Append(" O/C"".")
            Else
                If dtRAgenteCargaOC.Rows.Count = 1 Then
                    sb.Append("""El Agente de Carga ")
                    sb.Append(dtRAgenteCargaOC.Rows(0).Item("Indicador"))
                    sb.Append(" obtuvo ")
                Else
                    sb.Append("""Todos los Agentes de Carga obtuvieron ")
                End If
                sb.Append(String.Format("{0:0,0.00}", dblMaxAgente.ToString))
                sb.Append(" O/C"".")
            End If

            drMovimiento("DESCRIPCION") = sb.ToString
            dtTituloDesc.Rows.Add(drMovimiento)
        End If

        ds.Tables.Add(dtTituloDesc)
        'ds.Tables.Add(dtRProveedorOC_Otros)
        ds.Tables.Add(dtRProveedorOC)
        ds.Tables.Add(dtRPaisOC_Otros)
        ds.Tables.Add(dtRIncotermsOC)
        ds.Tables.Add(dtRAgenteCargaOC_Otros)
        ds.Tables.Add(dtTotalOC)
        ds.Tables.Add(dtAgenteCargaxOC)
        Return ds
    End Function

    Private Sub PorcentajePieOtros(ByVal dtSource As DataTable, ByVal dtPieResult As DataTable, ByVal strAbrev As String)
        Dim drOtros As DataRow = Nothing
        Dim drAgenteCarga As DataRow = Nothing

        Dim dblTotal As Double
        If dtSource.Rows.Count > 0 Then
            dblTotal = dtSource.Compute("Sum(Valor)", "")
            drAgenteCarga = Nothing

            For i As Integer = 1 To dtSource.Rows.Count
                drAgenteCarga = dtSource.Rows(i - 1)
                drOtros = dtPieResult.NewRow
                drOtros("TIPO") = drAgenteCarga("Indicador")
                drOtros("CANTIDAD") = drAgenteCarga("Valor")
                drOtros("PORCENTAJE") = (drAgenteCarga("Valor") / dblTotal) * 100
                If drOtros("TIPO").Equals("OTROS") Then
                    drOtros("Codigo") = "OTROS"
                Else
                    drOtros("Codigo") = strAbrev & i.ToString.PadLeft(2, "0")
                End If
                dtPieResult.Rows.Add(drOtros)
            Next
        End If
    End Sub

    Private Function SetBarraOtros_Proveedor(ByVal dtProveedorALl As DataTable) As DataTable
        Dim drOtros As DataRow = Nothing
        Dim j As Integer = 1
        Dim drProveedor As DataRow = Nothing
        Dim dtBarraResult As New DataTable
        dtBarraResult = dtProveedorALl.Clone()

        For Each drProveedor In dtProveedorALl.Rows
            'Top 6
            If dtBarraResult.Rows.Count <= 4 Then
                drOtros = dtBarraResult.NewRow
                drOtros("Indicador") = drProveedor("Indicador")
                drOtros("Dia") = drProveedor("Dia")
                drOtros("OC") = drProveedor("OC")
                drOtros("DIAXOC") = drProveedor("DIAXOC")
                drOtros("SubTotalDia") = 0 'drAgenteCarga("SubTotalDia")
                drOtros("SubTotalOC") = 0 'drAgenteCarga("SubTotalOC")
                dtBarraResult.Rows.Add(drOtros)
            Else
                Dim drFin As DataRow = dtBarraResult.Rows(dtBarraResult.Rows.Count - 1)
                If drFin("Indicador") <> "OTROS" Then
                    drOtros = dtBarraResult.NewRow
                    'Valida si Hay mas Registros
                    If (dtProveedorALl.Rows.Count - j) = 0 Then
                        drOtros("Indicador") = drProveedor("Indicador")
                    Else
                        drOtros("Indicador") = "OTROS"
                    End If
                    drOtros("Dia") = drProveedor("Dia")
                    drOtros("OC") = drProveedor("OC")
                    drOtros("DIAXOC") = drProveedor("DIAXOC")
                    drOtros("SubTotalDia") = 0 'drAgenteCarga("SubTotalDia")
                    drOtros("SubTotalOC") = 0 'drAgenteCarga("SubTotalOC")
                    dtBarraResult.Rows.Add(drOtros)
                Else
                    drFin("Dia") = drFin("Dia") + drProveedor("Dia")
                    drFin("OC") = drFin("OC") + drProveedor("OC")
                    drFin("DIAXOC") = drFin("DIAXOC") + drProveedor("DIAXOC")
                    drOtros("SubTotalDia") = 0 'drAgenteCarga("SubTotalDia")
                    drOtros("SubTotalOC") = 0 'drAgenteCarga("SubTotalOC")
                    dtBarraResult.AcceptChanges()
                End If
            End If
            j += 1
        Next

        'Totaliza los Dias Promedios (Ponderado)
        Dim SubTotalOC As Double = 0
        Dim SubTotalDia As Double = 0
        If dtBarraResult.Rows.Count > 0 Then
            SubTotalOC = dtBarraResult.Compute("SUM(OC)", "")
            If SubTotalOC > 0 Then
                SubTotalDia = dtBarraResult.Compute("SUM(DIAXOC)", "") / SubTotalOC
            Else
                dtBarraResult.Rows(0)("SubTotalDia") = 0
            End If
            For Each drResumen As DataRow In dtBarraResult.Rows
                drResumen("SubTotalDia") = SubTotalDia
                drResumen("SubTotalOC") = SubTotalOC
                dtBarraResult.AcceptChanges()
            Next
        End If
        Return dtBarraResult
    End Function

    Private Function SetBarraOtros(ByVal dtAgenteCargaALl As DataTable) As DataTable
        Dim drOtros As DataRow = Nothing
        Dim j As Integer = 1
        Dim drAgenteCarga As DataRow = Nothing
        Dim dtBarraResult As New DataTable
        dtBarraResult = dtAgenteCargaALl.Clone()

        For Each drAgenteCarga In dtAgenteCargaALl.Rows
            'Top 6
            If dtBarraResult.Rows.Count <= 4 Then
                drOtros = dtBarraResult.NewRow
                drOtros("Indicador") = drAgenteCarga("Indicador")
                drOtros("Valor") = drAgenteCarga("Valor")
                drOtros("SubTotal") = 0
                dtBarraResult.Rows.Add(drOtros)
            Else
                Dim drFin As DataRow = dtBarraResult.Rows(dtBarraResult.Rows.Count - 1)
                If drFin("Indicador") <> "OTROS" Then
                    drOtros = dtBarraResult.NewRow
                    'Valida si Hay mas Registros
                    If (dtAgenteCargaALl.Rows.Count - j) = 0 Then
                        drOtros("Indicador") = drAgenteCarga("Indicador")
                    Else
                        drOtros("Indicador") = "OTROS"
                    End If
                    drOtros("Valor") = drAgenteCarga("Valor")
                    drOtros("SubTotal") = 0
                    dtBarraResult.Rows.Add(drOtros)
                Else
                    drFin("Valor") = drFin("Valor") + drAgenteCarga("Valor")
                    drOtros("SubTotal") = 0
                    dtBarraResult.AcceptChanges()
                End If
            End If
            j += 1
        Next

        'Totaliza los Días Promedios (Ponderado)
        Dim SubTotal As Double = 0
        If dtBarraResult.Rows.Count > 0 Then
            SubTotal = dtBarraResult.Compute("SUM(Valor)", "")
            For Each drResumen As DataRow In dtBarraResult.Rows
                drResumen("SubTotal") = SubTotal
                dtBarraResult.AcceptChanges()
            Next
        End If
        Return dtBarraResult
    End Function


    Public Function Listar_PLANTAS_X_USUARIO(ByVal strUsuario As String, ByVal strCodCompania As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSMMCUSR", strUsuario)
        lobjParams.Add("PSCCMPN", strCodCompania)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_LISTA_PLANTA_X_USUARIO_ALL", lobjParams)
        'Dim dr As DataRow
        'dr = dt.NewRow
        'dr("CPLNDV") = "0"
        'dr("TPLNTA") = "TODOS"
        'dt.Rows.InsertAt(dr, 0)
        Return dt
    End Function

End Class
