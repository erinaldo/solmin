Imports RANSA.NEGO.ProxyRansa.EnvioRecepcion
Imports RANSA.NEGO.ProxyRansa.AnulaRecepcion
Imports RANSA.DATA
Imports RANSA.TypeDef
Imports System.Xml.Serialization

''' <summary>
''' Modified: Miguel Dagnino 23/10/2015
''' </summary>
''' <remarks></remarks>
Public Class brBulto

    Public Const ProcesoExitoso As String = "S"
    Public Const ErrorProceso As String = "E"
    Public Const ErrorComunicacion As String = "F"
    Public Const ErrorConexion As String = "C"

    Dim oDatos As New daBulto

    ''' <summary>
    ''' Inserta registro en la cabecera del bulto
    ''' </summary>
    ''' <param name="obeBulto"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fintInsertarBulto(ByVal obeBulto As beBulto) As Integer
        Return oDatos.fintInsertarBulto(obeBulto)
    End Function
    ''' <summary>
    ''' Inserta registro en el detalle del bulto
    ''' </summary>
    ''' <param name="obeBulto"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fintActualizarBulto(ByVal obeBulto As beBulto) As Integer
        Return oDatos.fintActualizarBulto(obeBulto)
    End Function

    ''' <summary>
    ''' Confirmar llegada del bulto al lugar de entrega
    ''' </summary>
    ''' <param name="obeBulto"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fintConfirmarLlegada(ByVal obeBulto As beBulto) As Integer
        Return oDatos.fintConfirmarLlegada(obeBulto)
    End Function

    ''' <summary>
    ''' Lista los bulto
    ''' </summary>
    ''' <param name="obeBulto"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function floObjtenerBulto(ByVal obeBulto As beBulto) As beBulto
        Return oDatos.floObjtenerBulto(obeBulto)
    End Function

    ''' <summary>
    ''' LISTA DE BULTOS POR PLANTA SEGUN FECHA DE SALIDA 
    ''' </summary>
    ''' <param name="obeBulto"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ListarBultoPorPlanta(ByVal obeBulto As beBulto) As List(Of beBulto)
        Return oDatos.ListarBultoPorPlanta(obeBulto)
    End Function

    ''' <summary>
    ''' Eliminar la cabecera del bulto
    ''' </summary>
    ''' <param name="obeBultoPK"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function EliminarBulto(ByVal obeBultoPK As beBulto) As Integer
        Return oDatos.EliminarBulto(obeBultoPK)
    End Function

    ''' <summary>
    ''' Lista el detalle del bulto seleccionado 
    ''' </summary>
    ''' <param name="obeBultoPK "></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ListarDetalleBulto(ByVal obeBultoPK As beBulto) As List(Of beBulto)
        Return oDatos.ListarDetalleBulto(obeBultoPK)
    End Function

    ''' <summary>
    ''' Lista el detalle del bulto seleccionado como Datatable
    ''' </summary>
    ''' <param name="obeBultoPK "></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function flListarDetalleBulto(ByVal obeBultoPK As beBulto) As DataTable
        Return oDatos.flListarDetalleBulto(obeBultoPK)
    End Function
    Public Function fstrInformacionItemBulto(ByVal obeBultoPK As beBulto) As String
        Dim strInformacion As String = String.Empty
        Try
            With oDatos.floInformacionItemBulto(obeBultoPK)
                strInformacion = " Información del Item: " & vbNewLine & _
                                           " ======================" & vbNewLine & _
                                           " No. Orden Compra : " & .PSNORCML & vbNewLine & _
                                           " Detalle O/C      : " & .PSTDSCML & vbNewLine & _
                                           " Proveedor        : " & .PSTPRVCL & vbNewLine & _
                                           " Nro. Item O/C    : " & .PSTCITCL & vbNewLine & _
                                           " Área Solicitante : " & .PSTCMAEM & vbNewLine & _
                                           " Cantidad         : " & .PNQCNTIT & vbNewLine & _
                                           " Unidad           : " & .PSTUNDIT & vbNewLine & _
                                           " Precio Unitario  : " & .PNIVUNIT & vbNewLine & _
                                           " Precio Total     : " & .PNIVTOIT & vbNewLine & _
                                           " Lugar de Origen  : " & .PSTLUGOR & vbNewLine & _
                                           " Lugar de Destino : " & .PSTLUGEN
            End With
        Catch ex As Exception
        End Try
        Return strInformacion
    End Function

    ''' <summary>
    ''' Actualiza El campo  custodia
    ''' </summary>
    ''' <param name="obebulto ">Entidad Bulto</param>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Public Function ActualizarCustodia(ByVal obebulto As beBulto) As Int32
        Return oDatos.ActualizarCustodia(obebulto)
    End Function

    ''' <summary>
    ''' Eliminamos el detalle de Bulto
    ''' </summary>
    ''' <param name="obeBultoPK"></param>
    ''' <param name="strError"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function EliminarDetalleBulto(ByVal obeBultoPK As beBulto, ByRef strError As String) As Int32
        Return oDatos.EliminarDetalleBulto(obeBultoPK, strError)
    End Function

    ''' <summary>
    ''' Listar el detalle de Bulto
    ''' </summary>
    ''' <param name="obeBulto"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listaPreDespacho(ByVal obeBulto As beBulto) As List(Of beBulto)
        Return oDatos.listaPreDespacho(obeBulto)
    End Function


    ''' <summary>
    ''' Lista de bultos predespachados por código de pre despacho 
    ''' </summary>
    ''' <param name="obeBulto"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listaBultosPorCodPreDespacho(ByVal obeBulto As beBulto) As List(Of beBulto)
        Return oDatos.listaBultosPorCodPreDespacho(obeBulto)
    End Function

    Public Function listaContenidoPorCodPreDespacho(ByVal obeBulto As beBulto) As List(Of beBulto)
        Return oDatos.listaContenidoPorCodPreDespacho(obeBulto)
    End Function



    ''' <summary>
    ''' Lista de bultos predespachados por código de pre despacho 
    ''' </summary>
    ''' <param name="obeBulto"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listaItemsDeBulto(ByVal obeBulto As beBulto) As List(Of beBulto)
        Return oDatos.listaItemsDeBulto(obeBulto)
    End Function

    Public Function listaRecepcionXFechaOperadorLogistico(ByVal obeBulto As beBulto, Optional ByRef NumPaginas As Int32 = 0) As DataTable
        Return oDatos.listaRecepcionXFechaOperadorLogistico(obeBulto, NumPaginas)
    End Function

    Public Function listaExportarRecepcionXFechaOperadorLogistico(ByVal obeBulto As beBulto) As DataTable
        Return oDatos.listaExportarRecepcionXFechaOperadorlogistico(obeBulto)
    End Function

    Public Function dtItemsDeBulto(ByVal obeBulto As beBulto) As DataTable
        Return oDatos.dtItemsDeBulto(obeBulto)
    End Function


    ''' <summary>
    ''' Listado de Sub Items en almacén
    ''' </summary>
    Public Function ListarBultoSubItemsOC(ByVal obeBulto As beBulto) As List(Of beBulto)
        Return oDatos.ListarBultoSubItemsOC(obeBulto)
    End Function

    Public Function ExisteBultoParaPreDespacho(ByVal obeBulto As beBulto, ByRef strMensajeError As String) As Boolean
        If oDatos.ExisteBultoParaPreDespacho(obeBulto, strMensajeError) = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    ''' <summary>
    ''' Elimina Bulto del predespacho
    ''' </summary>
    ''' <param name="obeBulto"></param>
    ''' <param name="strMensajeError"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function EliminarBultoPreDespachos(ByVal obeBulto As beBulto, ByRef strMensajeError As String) As Boolean
        Return oDatos.EliminarBultoPreDespachos(obeBulto, strMensajeError)

    End Function


    ''' <summary>
    ''' ista de Movimiento de Item de OC
    ''' </summary>
    ''' <param name="obeBulto"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ListarMovimientoItemOrdenCompra(ByVal obeBulto As beBulto) As DataTable


        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = oDatos.ListarMovimientoItemOrdenCompra(obeBulto)
        If dtResultado.Rows.Count = 0 Then Return dtResultado
        Dim dtIngresos As DataTable = dtResultado.Copy
        Dim dtSalidas As DataTable = dtResultado.Copy
        dtIngresos.AcceptChanges()
        dtSalidas.AcceptChanges()

        Dim drs() As DataRow
        drs = dtIngresos.Select("INGSDA = 'SDA'")
        For Each dr As DataRow In drs
            dtIngresos.Rows.Remove(dr)
        Next
        drs = dtSalidas.Select("INGSDA = 'ING'")
        For Each dr As DataRow In drs
            dtSalidas.Rows.Remove(dr)
        Next
        dtIngresos.AcceptChanges()
        dtSalidas.AcceptChanges()
        'dtSalidas.LoadDataRow(dtResultado.Select("INGSDA" = "SAL"), True)
        Dim cols(23) As DataColumn
        dtSalidas.Columns.CopyTo(cols, 0)
        For Each col As DataColumn In cols
            If dtSalidas.Columns.CanRemove(col) Then
                dtSalidas.Columns.Remove(col)
            End If
            col.ColumnName = col.ColumnName & "1"
            dtIngresos.Columns.Add(col)
        Next
        dtIngresos.AcceptChanges()
        dtSalidas = dtResultado.Copy
        drs = dtSalidas.Select("INGSDA = 'ING'")
        For Each dr As DataRow In drs
            dtSalidas.Rows.Remove(dr)
        Next
        For Each dr As DataRow In dtIngresos.Rows
            drs = dtSalidas.Select(String.Format("CREFFW = '{0}' AND NSEQIN ='{1}' ", dr("CREFFW"), dr("NSEQIN")))
            If drs.Length > 0 Then
                Dim d As DataRow = drs(0)
                For Each col As DataColumn In dtSalidas.Columns
                    dr(col.ColumnName + "1") = d(col.ColumnName)
                Next
            End If
        Next
        'Dim dv As New DataView(dtIngresos)
        'dv.ToTable(True, Columnas)
        Return dtIngresos
    End Function

    Public Function ListarMovimientoItemOrdenCompra_v2(ByVal obeBulto As beBulto, Optional ByRef counter As Int32 = 0) As DataTable
        Dim dtResultado As DataTable
        dtResultado = oDatos.ListarMovimientoItemOrdenCompra_v2(obeBulto, counter)
        Return dtResultado
    End Function
    Public Function EnviarCorreoPluspetrol(ByVal obeBulto As beBulto) As Integer
        Return oDatos.EnviarCorreoPluspetrol(obeBulto)
    End Function
    ''' <summary>
    ''' Copy de Una planta X a Planta Y
    ''' </summary>
    ''' <param name="obeBulto"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CopyBultoDePlanta(ByVal obeBulto As beBulto) As Integer
        Return oDatos.CopyBultoDePlanta(obeBulto)
    End Function
    ''' <summary>
    ''' Busca el nr de guia de salida en otra planta del bulto Y si encuntra  genera guia de salida
    ''' </summary>
    ''' <param name="obeBulto"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerGuiaSalidaPorCodPreDespacho(ByVal obeBulto As beBulto) As Decimal
        Return oDatos.ObtenerGuiaSalidaPorCodPreDespacho(obeBulto)
    End Function
    'Public Function ListarEtiquetas_BultoSAT(ByVal obeBulto As beBulto, ByRef strMensajeError As String, ByVal intNroCopias As String, ByVal blnStNroEtiqSegunBulto As Boolean) As List(Of beBulto)
    '    Return oDatos.ListarEtiquetas_BultoSAT(obeBulto, strMensajeError, intNroCopias, blnStNroEtiqSegunBulto)
    'End Function
    ''' <summary>
    ''' Busca Las observaciones del Item relacionado al Bulto
    ''' </summary>
    ''' <param name="filtro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function cargaObservacionesItemOC(ByVal filtro As Hashtable) As DataTable
        Return oDatos.cargaObservacionesItemOC(filtro)
    End Function


    Public Function ListarBultoALL(ByVal obeBulto As beBulto) As DataTable
        Return oDatos.ListarBultoALL(obeBulto)
    End Function

    Public Function ListarBultoInventario(ByVal obeBulto As beBulto) As DataTable
        Return oDatos.ListarBultoInventario(obeBulto)
    End Function

    Public Function ListarBultoInventarioGP(ByVal obeBulto As beBulto) As DataTable
        Return oDatos.ListarBultoInventarioGP(obeBulto)
    End Function
    ''' <summary>
    ''' Lista de Inventario distintas Plantas
    ''' </summary>
    ''' <param name="obeBulto"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ListarBultoInventarioAll(ByVal obeBulto As beBulto) As DataSet
        Return CrearResumenesInventario(oDatos.ListarBultoInventarioAll(obeBulto))
    End Function


    Public Function CrearResumenesInventario(ByVal ObjDetalle As DataTable) As DataSet
        Dim dsReturn As New DataSet
        Dim objDataSet As New DataSet
        '  Dim objFiltros As New DataTable
        Dim objResumen As New DataTable
        Dim objResumenFin As New DataTable
        If ObjDetalle.Rows.Count = 0 Then Exit Function

        Dim objObjDetalle_Planta As DataTable = ObjDetalle.Copy
        Dim Index As Integer = 0

        For i As Integer = 0 To ObjDetalle.Columns.Count - 1
            If ObjDetalle.Columns(i).ColumnName <> "CLIENTE" _
              AndAlso ObjDetalle.Columns(i).ColumnName <> "PLANTA" _
                AndAlso ObjDetalle.Columns(i).ColumnName <> "LUGAR_DE_ENTREGA" _
                  AndAlso ObjDetalle.Columns(i).ColumnName <> "CANTIDAD_BULTO" _
                    AndAlso ObjDetalle.Columns(i).ColumnName <> "PESO_BULTO" _
                      AndAlso ObjDetalle.Columns(i).ColumnName <> "VOLUMEN" Then
                objObjDetalle_Planta.Columns.RemoveAt(Index)
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
        dv.Sort = "PLANTA,CLIENTE, LUGAR_DE_ENTREGA ASC"
        objObjDetalle_Planta = dv.ToTable()

        For i As Integer = 0 To objObjDetalle_Planta.Rows.Count - 1
            strPlanta = objObjDetalle_Planta.Rows(i).Item("PLANTA")
            strCliente = objObjDetalle_Planta.Rows(i).Item("CLIENTE")

            drSelect = objObjDetalle_Planta.Select("CLIENTE = '" + strCliente.Trim + "' AND PLANTA = '" + strPlanta.Trim + "' AND LUGAR_DE_ENTREGA = '" + objObjDetalle_Planta.Rows(i)("LUGAR_DE_ENTREGA").ToString.Trim + "'")

            TotalKG = 0
            TotalM3 = 0
            TotalBUL = 0

            For Each dr As DataRow In drSelect
                TotalKG += Convert.ToDouble(dr("PESO_BULTO"))
                TotalM3 += Convert.ToDouble(dr("VOLUMEN"))
                TotalBUL += Convert.ToDouble(dr("CANTIDAD_BULTO"))
            Next

            If drSelect.Length > 0 Then
                objDataRow = objResumen.NewRow
                objDataRow.Item("CLIENTE") = objObjDetalle_Planta.Rows(i)("CLIENTE").ToString.Trim
                objDataRow.Item("LOTE") = objObjDetalle_Planta.Rows(i)("LUGAR_DE_ENTREGA").ToString.Trim
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

        'objFiltros.TableName = "DT_Filtros"
        ObjDetalle.TableName = "DT_Detalle"
        objResumenFin.TableName = "DT_Resumen"

        '  dsReturn.Tables.Add(objFiltros)
        dsReturn.Tables.Add(ObjDetalle.Copy())
        dsReturn.Tables.Add(objResumenFin)
        dsReturn.Tables.Add(CrearResumenes_Inventario_OrdenCompra(ObjDetalle.Copy()))
        Return (dsReturn)

    End Function

    Public Function CrearResumenes_Inventario_OrdenCompra(ByVal ObjDetalle As DataTable) As DataTable
        Dim objResumen As New DataTable
        Dim objResumenFin As New DataTable
        Dim objObjDetalle_Planta As DataTable = ObjDetalle.Copy
        Dim Index As Integer = 0

        For i As Integer = 0 To ObjDetalle.Columns.Count - 1
            If ObjDetalle.Columns(i).ColumnName <> "CLIENTE" _
              AndAlso ObjDetalle.Columns(i).ColumnName <> "PLANTA" _
               AndAlso ObjDetalle.Columns(i).ColumnName <> "ORDEN_DE_COMPRA" _
                AndAlso ObjDetalle.Columns(i).ColumnName <> "PROVEEDOR" _
                 AndAlso ObjDetalle.Columns(i).ColumnName <> "CANTIDAD_BULTO" _
                   AndAlso ObjDetalle.Columns(i).ColumnName <> "PESO_BULTO" _
                     AndAlso ObjDetalle.Columns(i).ColumnName <> "VOLUMEN" Then
                objObjDetalle_Planta.Columns.RemoveAt(Index)
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
        dv.Sort = "PLANTA,CLIENTE, ORDEN_DE_COMPRA, PROVEEDOR ASC"
        objObjDetalle_Planta = dv.ToTable()

        For i As Integer = 0 To objObjDetalle_Planta.Rows.Count - 1
            strPlanta = objObjDetalle_Planta.Rows(i).Item("PLANTA")
            strCliente = objObjDetalle_Planta.Rows(i).Item("CLIENTE")
            drSelect = objObjDetalle_Planta.Select("CLIENTE = '" + strCliente.Trim + "' AND PLANTA = '" + strPlanta.Trim + "' AND ORDEN_DE_COMPRA = '" + objObjDetalle_Planta.Rows(i)("ORDEN_DE_COMPRA").ToString.Trim + "'")
            TotalKG = 0
            TotalM3 = 0
            TotalBUL = 0

            For Each dr As DataRow In drSelect
                TotalKG += Convert.ToDouble(dr("PESO_BULTO"))
                TotalM3 += Convert.ToDouble(dr("VOLUMEN"))
                TotalBUL += Convert.ToDouble(dr("CANTIDAD_BULTO"))
            Next

            If drSelect.Length > 0 Then
                objDataRow = objResumen.NewRow
                objDataRow.Item("CLIENTE") = objObjDetalle_Planta.Rows(i)("CLIENTE").ToString.Trim
                objDataRow.Item("ORDEN_COMPRA") = objObjDetalle_Planta.Rows(i)("ORDEN_DE_COMPRA").ToString.Trim
                objDataRow.Item("PROVEEDOR") = objObjDetalle_Planta.Rows(i)("PROVEEDOR").ToString.Trim
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
        Return (objResumenFin)

    End Function



    ''' <summary>
    ''' Realiza el proceso de  Pre- Despacho ,Despacho y retorna Nr Guia Salida
    ''' </summary>
    ''' <param name="obeBulto"></param>
    ''' <returns>Guía de Salida</returns>
    ''' <remarks></remarks>
    Public Function ProcesarRecojo(ByRef obeBulto As beBulto) As Decimal
        Return oDatos.ProcesarRecojo(obeBulto)
    End Function

    Public Function RollbackInsertBulto(ByVal obeBulto As beBulto) As Decimal
        Return oDatos.RollbackInsertBulto(obeBulto)
    End Function

    Public Function ActualizaObservacionesItemOC(ByVal filtro As Hashtable) As Integer

        Dim retorno As Int32 = 0
        Dim MaxLon As Int32 = 0
        Dim Obs As String = ""
        Dim ObsTmp As String = ""
        Obs = filtro("TDAITM")
        retorno = oDatos.EliminaTodosObservacionesItemOC(filtro)
        If (retorno = 1) Then
            While Obs.Length <> 0
                If (Obs.Length > 45) Then MaxLon = 45 Else MaxLon = Obs.Length
                ObsTmp = Obs.Substring(0, MaxLon)
                Obs = Obs.Remove(0, MaxLon)
                filtro("TDAITM") = ObsTmp
                retorno = oDatos.ActualizaObservacionesItemOC(filtro)
            End While
        End If
        Return retorno
    End Function

    Public Function EliminaTodosObservacionesItemOC(ByVal filtro As Hashtable) As Integer
        Return oDatos.EliminaTodosObservacionesItemOC(filtro)
    End Function

    Public Function RealizarTrasladoBultoItemOC(ByVal oListbeBulto As List(Of beBulto)) As Integer
        Dim retorno As Int32 = 0
        For Each obeBulto As beBulto In oListbeBulto
            retorno = oDatos.RealizarTrasladoBultoItemOC(obeBulto)
        Next
        Return retorno
    End Function

    Public Function ListarMovimientoDetalle_X_ItemOrdenCompra(ByVal obeBulto As beBulto) As DataTable


        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = oDatos.ListarMovimientoDetalle_X_ItemOrdenCompra(obeBulto)
        If dtResultado.Rows.Count = 0 Then Return dtResultado
        Dim dtIngresos As DataTable = dtResultado.Copy
        Dim dtSalidas As DataTable = dtResultado.Copy
        dtIngresos.AcceptChanges()
        dtSalidas.AcceptChanges()

        Dim drs() As DataRow
        drs = dtIngresos.Select("INGSDA = 'SDA'")
        For Each dr As DataRow In drs
            dtIngresos.Rows.Remove(dr)
        Next
        drs = dtSalidas.Select("INGSDA = 'ING'")
        For Each dr As DataRow In drs
            dtSalidas.Rows.Remove(dr)
        Next
        dtIngresos.AcceptChanges()
        dtSalidas.AcceptChanges()
        'dtSalidas.LoadDataRow(dtResultado.Select("INGSDA" = "SAL"), True)
        Dim cols(30) As DataColumn
        dtSalidas.Columns.CopyTo(cols, 0)
        For Each col As DataColumn In cols
            If dtSalidas.Columns.CanRemove(col) Then
                dtSalidas.Columns.Remove(col)
            End If
            col.ColumnName = col.ColumnName & "1"
            dtIngresos.Columns.Add(col)
        Next
        dtIngresos.AcceptChanges()
        dtSalidas = dtResultado.Copy
        drs = dtSalidas.Select("INGSDA = 'ING'")
        For Each dr As DataRow In drs
            dtSalidas.Rows.Remove(dr)
        Next
        For Each dr As DataRow In dtIngresos.Rows
            drs = dtSalidas.Select(String.Format("CREFFW = '{0}' AND NSEQIN ='{1}' ", dr("CREFFW"), dr("NSEQIN")))
            If drs.Length > 0 Then
                Dim d As DataRow = drs(0)
                For Each col As DataColumn In dtSalidas.Columns
                    dr(col.ColumnName + "1") = d(col.ColumnName)
                Next
            End If
        Next
        'Dim dv As New DataView(dtIngresos)
        'dv.ToTable(True, Columnas)
        Return dtIngresos
    End Function

    Public Function ActualizarBulto_Repaking_Origen(ByVal obeBulto As beBulto) As Integer
        Dim odaBulto As New daBulto
        Return odaBulto.ActualizarBulto_Repaking_Origen(obeBulto)
    End Function


    Public Function ImprimirEtiquetaBulto(ByVal obeBulto As beBulto)
        Dim odaBulto As New daBulto
        Dim obeBultoEtiqueta As List(Of beBulto)
        Dim lstrEtiquetaBulto As List(Of String) = New List(Of String)
        obeBultoEtiqueta = odaBulto.ListaImprimirEtiquetaBulto(obeBulto)
        If obeBultoEtiqueta.Count > 0 Then
            ' Obtenemos el contenido del archivo
            Dim strEtiqueta As String = My.Resources.txtEtiquetaBultoCINF_F01
            Dim intContador As Int32 = 0
            Dim intNroCopiasEtiqueta As Int32 = obeBulto.PNCATCOPYA

            strEtiqueta = strEtiqueta.Replace("xUBICACION", ("" & obeBultoEtiqueta.Item(0).PSTUBRFR).ToString.Trim)
            strEtiqueta = strEtiqueta.Replace("xPROVEEDOR", ("" & obeBultoEtiqueta.Item(0).PSTPRVCL).ToString.Trim)
            strEtiqueta = strEtiqueta.Replace("xORDEN_COMPRA", ("" & obeBultoEtiqueta.Item(0).PSNORCML).ToString.Trim)
            strEtiqueta = strEtiqueta.Replace("xGUIA_PROVEEDOR", ("" & obeBultoEtiqueta.Item(0).PSNGRPRV).ToString.Trim)
            strEtiqueta = strEtiqueta.Replace("xOBSERVACIONES", ("" & obeBultoEtiqueta.Item(0).PSDESCWB).ToString.Trim)
            strEtiqueta = strEtiqueta.Replace("xCANTIDAD", obeBultoEtiqueta.Item(0).PNQREFFW)
            strEtiqueta = strEtiqueta.Replace("xPESO", obeBultoEtiqueta.Item(0).PNQPSOBL)
            strEtiqueta = strEtiqueta.Replace("xNROWAYBILL", ("" & obeBultoEtiqueta.Item(0).PSCREFFW).ToString.Trim)
            strEtiqueta = strEtiqueta.Replace("xDESTINO", ("" & obeBultoEtiqueta.Item(0).PSTLUGEN).ToString.Trim)
            strEtiqueta = strEtiqueta.Replace("xDIRIGIDO", ("" & obeBultoEtiqueta.Item(0).PSTDSCIT).ToString.Trim)
            strEtiqueta = strEtiqueta.Replace("FF", intNroCopiasEtiqueta)
            intContador = 0
            While intContador < intNroCopiasEtiqueta
                intContador += 1
                lstrEtiquetaBulto.Add(strEtiqueta.Replace("II", intContador))
            End While

        End If
        Return lstrEtiquetaBulto
        'End Function
    End Function

    Public Function ImprimirEtiquetaBulto_Mineria(ByVal obeBulto As beBulto)
        Dim odaBulto As New daBulto
        Dim obeBultoEtiqueta As List(Of beBulto)
        Dim lstrEtiquetaBulto As List(Of String) = New List(Of String)
        Dim lstrEtiquetaBultoBase As List(Of String) = New List(Of String)
        obeBultoEtiqueta = odaBulto.ListaImprimirEtiquetaBulto(obeBulto)

        If obeBultoEtiqueta.Count > 0 Then
            ' Obtenemos el contenido del archivo
            Dim strEtiqueta As String = ""
            If obeBultoEtiqueta.Item(0).PNCOMP_IMTERMEC > 0 Then
                strEtiqueta = My.Resources.txtEtiquetaBultoCINF_F01_3
            Else
                strEtiqueta = My.Resources.txtEtiquetaBultoCINF_F01_2
            End If
            'Dim strEtiqueta As String = My.Resources.txtEtiquetaBultoCINF_F01_2
            Dim intContador As Int32 = 0
            Dim InicioImpresion As Int32 = obeBulto.InicioImpresion
            Dim FinImpresion As Int32 = obeBulto.FinImpresion
            Dim intNroCopiasEtiqueta As Int32 = obeBulto.PNCATCOPYA
            Dim textoCliente As String = ""
            Dim tamanho As Integer = odaBulto.ListaTamanhoCliente_Bulto_Mineria()
            textoCliente = ("" & obeBultoEtiqueta.Item(0).PSTCMPCL).ToString.Trim
            If textoCliente.Length > tamanho Then
                textoCliente = textoCliente.Substring(0, tamanho - 1)
            End If
            strEtiqueta = strEtiqueta.Replace("xUBICACION", textoCliente)
            strEtiqueta = strEtiqueta.Replace("xFECHA", ("" & obeBultoEtiqueta.Item(0).FechaRecepcion).ToString.Trim)
            strEtiqueta = strEtiqueta.Replace("xPROVEEDOR", ("" & obeBultoEtiqueta.Item(0).PSTPRVCL).ToString.Trim)
            strEtiqueta = strEtiqueta.Replace("xORDEN_COMPRA", ("" & obeBultoEtiqueta.Item(0).PSNORCML).ToString.Trim)
            strEtiqueta = strEtiqueta.Replace("xGUIA_PROVEEDOR", ("" & obeBultoEtiqueta.Item(0).PSNGRPRV).ToString.Trim)
            strEtiqueta = strEtiqueta.Replace("xOBSERVACIONES", ("" & obeBultoEtiqueta.Item(0).PSDESCWB).ToString.Trim)
            strEtiqueta = strEtiqueta.Replace("xCANTIDAD", obeBultoEtiqueta.Item(0).PNQREFFW)
            strEtiqueta = strEtiqueta.Replace("xPESO", obeBultoEtiqueta.Item(0).PNQPSOBL)
            strEtiqueta = strEtiqueta.Replace("xNROWAYBILL", ("" & obeBultoEtiqueta.Item(0).PSCREFFW).ToString.Trim)
            strEtiqueta = strEtiqueta.Replace("xDESTINO", ("" & obeBultoEtiqueta.Item(0).PSTLUGEN).ToString.Trim)
            strEtiqueta = strEtiqueta.Replace("xDIRIGIDO", ("" & obeBultoEtiqueta.Item(0).PSTDSCIT).ToString.Trim)
            'strEtiqueta = strEtiqueta.Replace("FF", intNroCopiasEtiqueta)
            strEtiqueta = strEtiqueta.Replace("FF", obeBultoEtiqueta.Item(0).PNQREFFW)
            'intContador = 0
            'While intContador < intNroCopiasEtiqueta
            '    intContador += 1
            '    lstrEtiquetaBulto.Add(strEtiqueta.Replace("II", intContador))
            'End While
            For PosImpresion As Integer = InicioImpresion To FinImpresion
                lstrEtiquetaBulto.Add(strEtiqueta.Replace("II", PosImpresion))
                lstrEtiquetaBultoBase.Add(strEtiqueta.Replace("II", PosImpresion))
            Next

            intContador = 1
            While intContador < intNroCopiasEtiqueta
                intContador += 1
                For Each cadEtiqueta As String In lstrEtiquetaBultoBase
                    lstrEtiquetaBulto.Add(cadEtiqueta)
                Next

            End While



        End If
        Return lstrEtiquetaBulto
        'End Function
    End Function

    ''' <summary>
    ''' Genera Codigo para Zebra con Formato 6*4
    ''' </summary>
    ''' <param name="obeBulto"></param>
    ''' <param name="bolIncluirDetalle"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ImprimirEtiquetaBultoCompleto(ByVal obeBulto As beBulto, Optional ByVal bolIncluirDetalle As Boolean = False, Optional ByVal cantInit As Integer = 1, Optional ByVal cantFin As Integer = 1, Optional ByVal IsDetailled As Boolean = False, Optional ByVal itemactual As Integer = 0)
        Dim odaBulto As New daBulto
        Dim lstrEtiquetaBulto As List(Of String) = New List(Of String)

        'For i_ticket As Integer = cantInit To cantFin
        Dim obeBultoEtiqueta As List(Of beBulto)

        obeBultoEtiqueta = odaBulto.ListaImprimirEtiquetaBultoDetalle(obeBulto)
        If obeBultoEtiqueta.Count = 0 Then
            GoTo ZonaSalida
        End If

        Dim i As Integer = 0
        Dim strEtiqueta As String = ""

        ' Dim oFile As New IO.StreamReader("ZebraTextFiles\formato_base_6x4_alterno_3.out")
        Dim oFile As IO.StreamReader

        If IsDetailled = True Then
            oFile = New IO.StreamReader("ZebraTextFiles\formato_base_6x4_alterno_2012_2.out")
        Else
            oFile = New IO.StreamReader("ZebraTextFiles\formato_base_6x4_alterno_2012.out")
        End If

        'Modificacion 14/06/2012: Rodolfo Ortiz -> Cliente Outotec
        If obeBulto.PNCCLNT = 18541 Then
            oFile = New IO.StreamReader("ZebraTextFiles\formato_base_6x4_outotec.out")
        End If

        While oFile.EndOfStream = False
            strEtiqueta = strEtiqueta + oFile.ReadLine
        End While

        ' MsgBox(strEtiqueta)

        If obeBultoEtiqueta.Count > 0 Then
            ' Obtenemos el contenido del archivo
            Dim intContador As Int32 = 0
            Dim intNroCopiasEtiqueta As Int32 = obeBulto.PNCATCOPYA

            'strEtiqueta = strEtiqueta.Replace("xUBICACION", ("" & obeBultoEtiqueta.Item(0).PSTUBRFR).ToString.Trim)
            Try
                strEtiqueta = strEtiqueta.Replace("NRO O/C", "")
                strEtiqueta = strEtiqueta.Replace("VBZONA", ("" & obeBultoEtiqueta.Item(0).PSTUBRFR).ToString.Trim)
                strEtiqueta = strEtiqueta.Replace("VBDESTINO", ("" & obeBultoEtiqueta.Item(0).PSTLUGEN).ToString.Trim)
                strEtiqueta = strEtiqueta.Replace("VBDIRIGIDOA", ("" & obeBultoEtiqueta.Item(0).PSTDSCIT).ToString.Trim)
                'strEtiqueta = strEtiqueta.Replace("ZONA", ("" & "DEST."))
                'strEtiqueta = strEtiqueta.Replace("VBUBICACION", ("" & obeBultoEtiqueta.Item(0).PSTUBRFR).ToString.Trim)
            Catch : End Try

            strEtiqueta = strEtiqueta.Replace("VBPROVEEDOR", ("" & obeBultoEtiqueta.Item(0).PSTPRVCL).ToString.Trim)
            strEtiqueta = strEtiqueta.Replace("VBORDENCOMPRA", ("" & obeBultoEtiqueta.Item(0).PSNORCML).ToString.Trim)
            strEtiqueta = strEtiqueta.Replace("VBGUIA", ("" & obeBultoEtiqueta.Item(0).PSNGRPRV).ToString.Trim)
            strEtiqueta = strEtiqueta.Replace("VBOBSERVACIONES", ("" & obeBultoEtiqueta.Item(0).PSDESCWB).ToString.Trim)
            strEtiqueta = strEtiqueta.Replace("VBCANT", obeBultoEtiqueta.Item(0).PNQREFFW)
            strEtiqueta = strEtiqueta.Replace("VBPESO", obeBultoEtiqueta.Item(0).PNQPSOBL)
            strEtiqueta = strEtiqueta.Replace("VBBULTO", ("" & obeBultoEtiqueta.Item(0).PSCREFFW).ToString.Trim)
            'strEtiqueta = strEtiqueta.Replace("VBCODIGOBARRA", ("" & obeBultoEtiqueta.Item(0).PSCREFFW).ToString.Trim)

            If IsDetailled = True Then
                strEtiqueta = strEtiqueta.Replace("VBCODIGOBARRA", ("" & obeBultoEtiqueta.Item(0).PSCREFFW).ToString.Trim & "-" & CompletarIzquierda(itemactual, 2) & "/" & CompletarIzquierda(cantFin, 2))
            Else
                strEtiqueta = strEtiqueta.Replace("VBCODIGOBARRA", ("" & obeBultoEtiqueta.Item(0).PSCREFFW).ToString.Trim)
            End If

            'strEtiqueta = strEtiqueta.Replace("xDESTINO", ("" & obeBultoEtiqueta.Item(0).PSTLUGEN).ToString.Trim)
            ' strEtiqueta = strEtiqueta.Replace("xDIRIGIDO", ("" & obeBultoEtiqueta.Item(0).PSTDSCIT).ToString.Trim)
            '  strEtiqueta = strEtiqueta.Replace("FF", intNroCopiasEtiqueta)
            Dim indice As Integer
            For indice = i To obeBultoEtiqueta.Count - 1
                If indice <= 20 Then
                    strEtiqueta = strEtiqueta.Replace("ITEM_" & indice + 1 & ".", ("" & obeBultoEtiqueta(indice).PNNRITOC).ToString.Trim)

                    If obeBultoEtiqueta(indice).PSTDITES.ToString().Trim.Length > 25 Then
                        strEtiqueta = strEtiqueta.Replace("LINEA" & indice + 1 & ".", obeBultoEtiqueta(indice).PSTDITES.ToString.Trim.Substring(0, 25))
                    Else
                        strEtiqueta = strEtiqueta.Replace("LINEA" & indice + 1 & ".", obeBultoEtiqueta(indice).PSTDITES.ToString.Trim)
                    End If

                    '  strEtiqueta = strEtiqueta.Replace("LINEA" & indice + 1 & ".", ("" & IIf(obeBultoEtiqueta(indice).PSTDITES.ToString().Trim.Length > 25, obeBultoEtiqueta(indice).PSTDITES.ToString.Trim.Substring(0, 25), obeBultoEtiqueta(indice).PSTDITES).ToString.Trim))
                    strEtiqueta = strEtiqueta.Replace("UNID" & indice + 1 & ".", ("" & obeBultoEtiqueta(indice).PSTUNDIT).ToString.Trim)

                    If obeBultoEtiqueta(indice).PSTDITES.ToString().Trim.Length > 5 Then
                        strEtiqueta = strEtiqueta.Replace("CANT" & indice + 1 & ".", obeBultoEtiqueta(indice).PNQBLTSR.ToString.Trim.Substring(0, 5))
                    Else
                        strEtiqueta = strEtiqueta.Replace("CANT" & indice + 1 & ".", obeBultoEtiqueta(indice).PNQBLTSR.ToString.Trim)
                    End If

                    If obeBultoEtiqueta(indice).PSTCITCL.ToString().Trim.Length > 10 Then
                        strEtiqueta = strEtiqueta.Replace("CODIGO" & indice + 1 & ".", obeBultoEtiqueta(indice).PSTCITCL.ToString.Trim.Substring(0, 10))
                    Else
                        strEtiqueta = strEtiqueta.Replace("CODIGO" & indice + 1 & ".", obeBultoEtiqueta(indice).PSTCITCL.ToString.Trim)
                    End If

                End If
            Next

            If indice <= 20 Then
                For t As Integer = indice To 20
                    strEtiqueta = strEtiqueta.Replace("ITEM_" & t & ".", "")
                    strEtiqueta = strEtiqueta.Replace("LINEA" & t & ".", "")
                    strEtiqueta = strEtiqueta.Replace("UNID" & t & ".", "")
                    strEtiqueta = strEtiqueta.Replace("CANT" & t & ".", "")
                    strEtiqueta = strEtiqueta.Replace("CODIGO" & t & ".", "")
                Next
            End If

            If i < obeBultoEtiqueta.Count Then
                lstrEtiquetaBulto.Add(strEtiqueta.Replace("II", intContador))
            Else
                intContador = 0
                While intContador < intNroCopiasEtiqueta
                    intContador += 1
                    lstrEtiquetaBulto.Add(strEtiqueta.Replace("II", intContador))
                End While
            End If


        End If

        'Next

ZonaSalida:
        Return lstrEtiquetaBulto
        'End Function
    End Function

    Public Function CompletarIzquierda(ByVal Texto As String, ByVal Cantidad As Integer)
        Dim final As String = Texto
        For i As Integer = Texto.Length To Cantidad
            final = "0" & final
        Next
        Return final
    End Function

    Public Function InsertarDetalleBulto(ByVal obeBulto As beBulto) As String
        Dim odaBulto As New daBulto
        Return odaBulto.InsertarDetalleBulto(obeBulto)
    End Function

    Public Function ActualizarDetalleBulto(ByVal obeBulto As beBulto) As String
        Dim odaBulto As New daBulto
        Return odaBulto.ActualizarDetalleBulto(obeBulto)
    End Function

    ''' <summary>
    ''' Función que permite saber si el bulto se creo por el interfaz con corpesa
    ''' </summary>
    ''' <param name="obeBulto"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fbolProcesadoPorInterfaz(ByVal obeBulto As beBulto) As Integer
        Dim odaBulto As New daBulto
        Return odaBulto.fbolProcesadoPorInterfaz(obeBulto)
    End Function

    Public Function fdtListaBultoIngresadosPoraExportarTxt(ByVal obeBulto As beBulto) As DataTable
        Dim odaBulto As New daBulto
        Return odaBulto.fdtListaBultoIngresadosPoraExportarTxt(obeBulto)
    End Function

    Public Function fdtListaBultoDespachoParaExportarTxt(ByVal obeBulto As beBulto) As DataSet
        Dim odaBulto As New daBulto
        Return odaBulto.fdtListaBultoDespachoParaExportarTxt(obeBulto)


    End Function

    'Miguel 31.01.2013
    Public Function ObtenerCorreosPara(ByVal obeBulto As beBulto) As List(Of beBulto)
        Return oDatos.ObtenerCorreoPara(obeBulto)
    End Function

    Public Function ObtenerCorreosAsunto(ByVal obeBulto As beBulto) As List(Of beBulto)
        Return oDatos.ObtenerCorreoAsunto(obeBulto)
    End Function

    Public Function ObtenerCorreosDocAdjunto(ByVal obeBulto As beBulto) As List(Of beBulto)
        Return oDatos.ObtenerCorreosDocAdjunto(obeBulto)
    End Function


    'Dagnino 11.9.2015
    ''' <summary>
    ''' Función que permite saber si el cliente se encuentra habilitado para realizar el proceso de envío de confirmación
    ''' </summary>
    ''' <param name="codigoCliente"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ValidarClienteParaConfirmacion(ByVal codigoCliente As Integer) As Boolean

        Dim validFinal As Boolean

        Dim DtResultado As DataTable
        DtResultado = oDatos.ListaValidarClienteParaConfirmacion(codigoCliente)

        If Not DtResultado Is Nothing And DtResultado.Rows.Count > 0 Then
            validFinal = True
        Else
            validFinal = False
        End If

        Return validFinal
    End Function

    ''' <summary>
    ''' Función que permite obtener informacion del bulto
    ''' </summary>
    ''' <param name="obeBulto"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function EnviarInfoBulto(ByVal obeBulto As beBulto, ByRef strMessageError As String) As String
        Dim DtInfoBulto As DataTable
        Dim strEstadoRespuesta As String = String.Empty
        'Dim strMessageError As String = String.Empty

        DtInfoBulto = oDatos.ListaInfoBulto(obeBulto)

        If Not DtInfoBulto Is Nothing Then
            Dim respuestaEnvio = EnvioRecepcionBulto(DtInfoBulto, strEstadoRespuesta, strMessageError)

            If Not respuestaEnvio Is Nothing Then
                obeBulto.PSDCENSA = respuestaEnvio(0).DOCNUM
            End If

            obeBulto.PSSTRNSM = strEstadoRespuesta
            If oDatos.ActualizarEstadoEnvio(obeBulto) Then
                Return strEstadoRespuesta
            Else
                Return ErrorConexion
            End If




            'If Not respuestaEnvio Is Nothing Then

            '    If respuestaEnvio(0).TYPE = "S" Then
            '        obeBulto.PSDCENSA = respuestaEnvio(0).DOCNUM
            '        If oDatos.ActualizarEstadoEnvio(obeBulto) Then
            '            Return 1 'envio exitoso
            '        Else
            '            Return 2 'error al actualizar
            '        End If

            '    ElseIf respuestaEnvio(0).TYPE = "E" Then
            '        Return 3 'error al enviar por el  web service
            '    Else
            '        Return 4 'error al enviar por el web service (error en comunicacion)
            '    End If
            'Else
            '    Return 4
            'End If



        End If

        Return strEstadoRespuesta
    End Function
    ''' <summary>
    ''' Función que permite obtener informacion del bulto
    ''' </summary>
    ''' <param name="dtInfoBulto"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function EnvioRecepcionBulto(ByVal dtInfoBulto As DataTable, ByRef strEstadoRespuesta As String, ByRef strMessageError As String) As ProxyRansa.EnvioRecepcion.DT_RespuestEnvioRecepcionReturn()

        Try
            Dim ProxyEnvioRecepcion As New ProxyRansa.EnvioRecepcion.SI_EnvioRecepcion_Ransa_OutService()


            If Not ProxyEnvioRecepcion Is Nothing Then

                Dim outPutProxy As DT_RespuestEnvioRecepcionReturn()
                Dim inPutProxy As New DT_EnvioRecepcion()
                Dim inputItemsProxy As New DT_ItemsITEMS()
                Dim lstItems As New List(Of DT_ItemsITEMS)
                Dim arrayItems() As DT_ItemsITEMS
                Dim i As Integer = 0

                If dtInfoBulto.Rows.Count > 0 Then

                    inPutProxy.NUMBTO = dtInfoBulto.Rows(0)("CREFFW").ToString().Trim()
                    inPutProxy.FECDOC = dtInfoBulto.Rows(0)("FREFFW").ToString().Trim()
                    inPutProxy.FECCDOC = dtInfoBulto.Rows(0)("FINGAL").ToString().Trim()
                    inPutProxy.REFDOC = dtInfoBulto.Rows(0)("NGRPRV").ToString().Trim()
                    inPutProxy.CANBTO = dtInfoBulto.Rows(0)("QREFFW").ToString().Trim()
                    inPutProxy.TIPBTO = dtInfoBulto.Rows(0)("TIPBTO").ToString().Trim()
                    inPutProxy.PSOBTO = dtInfoBulto.Rows(0)("QPSOBL").ToString().Trim()
                    inPutProxy.TIND = dtInfoBulto.Rows(0)("TPOOCM").ToString().Trim()

                    For Each row As DataRow In dtInfoBulto.Rows
                        inputItemsProxy = New DT_ItemsITEMS()

                        inputItemsProxy.OC = row.Item("NORCML").ToString().Trim()
                        inputItemsProxy.OC_POS = row.Item("NRITOC").ToString().Trim()
                        inputItemsProxy.MATERIAL = row.Item("TCITCL").ToString().Trim()
                        inputItemsProxy.CANTIDADSpecified = True
                        inputItemsProxy.CANTIDAD = row.Item("QBLTSR").ToString().Trim()
                        inputItemsProxy.UMEDIDA = row.Item("TUNDIT").ToString().Trim()
                        inputItemsProxy.CENTRO = row.Item("TRFRN1").ToString().Trim()
                        inputItemsProxy.ALMACEN = row.Item("TRFRN2").ToString().Trim()

                        lstItems.Add(inputItemsProxy)
                    Next

                    arrayItems = lstItems.ToArray()

                    inPutProxy.ITEM = arrayItems

                    ProxyEnvioRecepcion.Credentials = New Net.NetworkCredential("XMPIRANSA", "b)W$(Gf~%$3]S>i$RewV6[znpGX%9ip[zgQHqUY}")
                    'a solicitud de a-zorrilla
                    ProxyEnvioRecepcion.Timeout = 180000
                    outPutProxy = ProxyEnvioRecepcion.SI_EnvioRecepcion_Ransa_Out(inPutProxy)

                    If Not outPutProxy Is Nothing Then
                        strEstadoRespuesta = outPutProxy(0).TYPE.ToString()
                        strMessageError = outPutProxy(0).MESSAGE.ToString()
                    End If

                    Return outPutProxy
                End If
            End If
        Catch ex As Exception
            strEstadoRespuesta = ErrorComunicacion
            Return Nothing
        End Try


    End Function

    ''' <summary>
    ''' Función que permite obtener informacion del bulto para anulacion
    ''' </summary>
    ''' <param name="obeBulto"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function EnviarAnulacionInfoBulto(ByVal obeBulto As beBulto, ByRef strMessageError As String) As String
        Dim DtInfoBulto As DataTable
        Dim strEstadoRespuesta As String = String.Empty
        DtInfoBulto = oDatos.ListaInfoBulto(obeBulto)

        If Not DtInfoBulto Is Nothing Then
            Dim respuestaEnvio = EnvioAnulacionRecepcionBulto(DtInfoBulto, strEstadoRespuesta, strMessageError)

            If Not respuestaEnvio Is Nothing Then
                obeBulto.PSDCENSA = respuestaEnvio(0).DOCNUM
            End If
            obeBulto.PSSTRNSM = strEstadoRespuesta
            Return strEstadoRespuesta
        End If

    End Function
    ''' <summary>
    ''' Función que permite obtener informacion del bulto para anulacion
    ''' </summary>
    ''' <param name="dtInfoBulto"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function EnvioAnulacionRecepcionBulto(ByVal dtInfoBulto As DataTable, ByRef strEstadoRespuesta As String, ByRef strMessageError As String) As ProxyRansa.AnulaRecepcion.DT_RespuestaAnulaRecepcionReturn()

        Try
            Dim ProxyEnvioAnulacionRecepcion As New ProxyRansa.AnulaRecepcion.SI_AnulaRecepcion_Ransa_OutService()


            If Not ProxyEnvioAnulacionRecepcion Is Nothing Then

                Dim outPutProxy As Object()
                Dim inPutProxy As New DT_AnulaRecepcion()

                Dim i As Integer = 0

                If dtInfoBulto.Rows.Count > 0 Then

                    inPutProxy.NUMBTO = dtInfoBulto.Rows(0)("CREFFW").ToString().Trim()
                    inPutProxy.NUMDOC = dtInfoBulto.Rows(0)("DCENSA").ToString().Trim()
                    inPutProxy.TIND = dtInfoBulto.Rows(0)("TPOOCM").ToString().Trim()

                    ProxyEnvioAnulacionRecepcion.Credentials = New Net.NetworkCredential("XMPIRANSA", "b)W$(Gf~%$3]S>i$RewV6[znpGX%9ip[zgQHqUY}")
                    outPutProxy = ProxyEnvioAnulacionRecepcion.SI_AnulaRecepcion_Ransa_Out(inPutProxy)


                    If Not outPutProxy Is Nothing Then
                        strEstadoRespuesta = outPutProxy(0).TYPE.ToString()
                        strMessageError = outPutProxy(0).MESSAGE.ToString()
                    End If

                    Return outPutProxy
                End If
            End If
        Catch ex As Exception
            strEstadoRespuesta = ErrorComunicacion
            Return Nothing
        End Try
    End Function
    'Dagnino 23.09.2015
    Public Function ObtenerBultoPedidoTraslado(ByVal obeBulto As beBulto) As DataTable
        Return oDatos.ObtenerBultoPedidoTraslado(obeBulto)
    End Function

    Public Function ActualizarDetalleBultoPedidoTraslado(ByVal obeBulto As beBulto) As String
        Dim odaBulto As New daBulto
        Return odaBulto.ActualizarDetalleBultoPedidoTraslado(obeBulto)
    End Function
#Region "Interfaz Sap"
    Public Function fdtListaBultoParaTransferir(ByVal obeBulto As beBulto, ByRef strError As String) As DataTable
        Dim odaBulto As New daBulto
        Return odaBulto.fdtListaBultoParaTransferir(obeBulto, strError)
    End Function

    Public Function fintRealizarTransferenciaBulto(ByRef obeBulto As beBulto) As Int32
        Dim odaBulto As New daBulto
        Return odaBulto.fintRealizarTransferenciaBulto(obeBulto)
    End Function
#End Region

#Region "DETALLE BULTO"

    Public Function fintInsertarBultoDetalleCarga(ByVal obeBulto As beBulto) As Integer
        Dim odaBulto As New daBulto
        Return odaBulto.fintInsertarBultoDetalleCarga(obeBulto)
    End Function

    Public Function fintInsertarBultoDetalleCargaRepacking(ByVal obeBulto As beBulto) As Integer
        Dim odaBulto As New daBulto
        Return odaBulto.fintInsertarBultoDetalleCargaRepacking(obeBulto)
    End Function

    ' Public Function fintInsertarBultoDetalleCargaRepacking(ByVal obeBulto As beBulto) As Integer


    Public Function fintActualizarBultoDetalleCarga(ByVal obeBulto As beBulto) As Integer
        Dim odaBulto As New daBulto
        Return odaBulto.fintActualizarBultoDetalleCarga(obeBulto)
    End Function

    Public Function flistListarBultoDetalleCarga(ByVal obeBulto As beBulto) As List(Of beBulto)
        Dim odaBulto As New daBulto
        Return odaBulto.flistListarBultoDetalleCarga(obeBulto)
    End Function

#End Region

  
    'RCS-HUNDRED-INICIO 
    Private Function ValidarBloqueoCredito(ByVal codigoCompania As String, ByVal codCliente As String) As Boolean
        Dim dtBloqueoCredito As DataTable = oDatos.ValidarBloqueoCredito(codigoCompania, codCliente) 
        Return dtBloqueoCredito.Rows.Count = 0
    End Function




    'RCS-HUNDRED-FIN

    Private Function ValidarLimiteCredito(ByVal codigoCompania As String, ByVal codCliente As String) As DataTable
        Return oDatos.ValidarLimiteCredito(codigoCompania, codCliente)
    End Function

    Public Function ValidarLimiteCredito(ByVal codigoCompania As String, ByVal codigoCliente As String, ByRef mensaje As String) As Boolean
        Dim result As Boolean = True
        Dim dataTable As New DataTable
        Dim msgError As String = ""
        If ValidarBloqueoCredito(codigoCompania, codigoCliente) Then 'RCS-HUNDRED
            dataTable = Me.ValidarLimiteCredito(codigoCompania, codigoCliente)
            Dim result1 As String = dataTable.Rows(0)("PARAM_FLGSF1")
            Dim result2 As String = dataTable.Rows(0)("PARAM_FLGSF2")
            Dim result3 As String = dataTable.Rows(0)("PARAM_FLGSF3")
            Dim result4 As String = dataTable.Rows(0)("PARAM_FLGSF4")
            Dim result5 As String = dataTable.Rows(0)("PARAM_FLGSF5")



            Dim comodin As String = ""
            If (result1 = "0" Or result2 = "0" Or result3 = "0" Or result4 = "0") Then
                mensaje += "No existe la conexión con el SAP "
                result = False
            End If


            If (result1 = "X") Then
                mensaje += String.Format("Cliente con crédito sobregirado {0}", Environment.NewLine)
                result = False
            End If

            If (result2 = "X") Then
                If (mensaje.Contains("Cliente")) Then comodin = "y " Else comodin = "Cliente"
                mensaje += String.Format("{0} con PAs vencidas {1}", comodin, Environment.NewLine)
                result = False
            End If



            If (result3 = "X") Then
                If (mensaje.Contains("Cliente")) Then comodin = "y " Else comodin = "Cliente"
                mensaje += String.Format("{0} con Provisiones {1}", comodin, Environment.NewLine)
                result = False
            End If


            If (result4 = "X") Then
                If (mensaje.Contains("Cliente")) Then comodin = "y " Else comodin = "Cliente"
                mensaje += String.Format("{0} con cheques rechazados {1}", comodin, Environment.NewLine)
                result = False
            End If
        End If



        Return result


    End Function


#Region "WsBroker"
    Public Function ListaRecepcionEnviarWS(ByVal obeBulto As beBulto) As DataTable
        Dim odaBulto As New daBulto
        Return odaBulto.ListaRecepcionEnviarWS(obeBulto)
    End Function
    Public Function ActualizarEstadoEnvioRecepcionWS(ByVal obeBulto As beBulto) As Boolean
        Dim odaBulto As New daBulto
        Return odaBulto.ActualizarEstadoEnvioRecepcionWS(obeBulto)
    End Function
    Public Function VerificarClienteHabilitado(ByVal intCCLNT As Integer) As Boolean
        Dim odaBulto As New daBulto
        Return odaBulto.VerificarClienteHabilitado(intCCLNT)
    End Function
#End Region

End Class
