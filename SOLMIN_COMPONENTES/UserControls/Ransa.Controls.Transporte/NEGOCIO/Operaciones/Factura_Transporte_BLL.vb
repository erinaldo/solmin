

Namespace Operaciones
  Public Class Factura_Transporte_BLL
    Private objDataAccessLayer As New Factura_Transporte_DAL
    Private oDtCabecera As DataTable
    Private oDtDocumentos As DataTable
        Private oDtServicioActualizar As DataTable
        Private oDsServicioLote As DataSet
    Public oTipoDocumento As Double
    Private dblTipoCambio As Double
    Private strGiroNeg As String
    Private strPlantaCli As String
    Private strPtoVenta As String
    Private strCodTabla As String
    Private dblTipoDoc As Double
    Private strTipomoneda As String
    Private intNroMaxItem As Integer = 0
    Private objTipoDetraccion As Hashtable
    Private objValorReferencial As Hashtable
    Private objRegistroItemFactura As New List(Of Int32)

#Region "Atributo"
    Sub New()
      oDtCabecera = New DataTable
    End Sub

    Property PlantaCliente()
      Get
        Return strPlantaCli
      End Get
      Set(ByVal value)
        strPlantaCli = value
      End Set
    End Property

    Property PuntoVenta()
      Get
        Return strPtoVenta
      End Get
      Set(ByVal value)
        strPtoVenta = value
      End Set
    End Property

    Property GiroNegocio()
      Get
        Return strGiroNeg
      End Get
      Set(ByVal value)
        strGiroNeg = value
      End Set
    End Property

    Property TipoCambio()
      Get
        Return dblTipoCambio
      End Get
      Set(ByVal value)
        dblTipoCambio = value
      End Set
    End Property

    Property Tipomoneda()
      Get
        Return strTipomoneda
      End Get
      Set(ByVal value)
        strTipomoneda = value
      End Set
    End Property

    Property MaxItemFAct() As Integer
      Get
        Return intNroMaxItem
      End Get
      Set(ByVal value As Integer)
        intNroMaxItem = value
      End Set
    End Property

    Public ReadOnly Property NroItemFactura() As List(Of Int32)
      Get
        Return objRegistroItemFactura
      End Get
    End Property

        Private _lstOperaciones As List(Of ConsistenciaOperacion)
        Public Property ListaOperaciones() As List(Of ConsistenciaOperacion)
            Get
                Return _lstOperaciones
            End Get
            Set(ByVal value As List(Of ConsistenciaOperacion))
                _lstOperaciones = value
            End Set
        End Property

#End Region


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

        'Private Function filtraServicio(ByVal dt1 As DataTable, ByVal dt2 As DataRow) As DataRow
        '    Dim rowArray() As DataRow
        '    rowArray = dt1.Select("NOPRCN= " & dt2.Item("NOPRCN") & " AND NGUITR= " & dt2.Item("NGUIRM") & " AND NCRRGU= " & dt2.Item("NCRRGU"))
        '    Return rowArray(0)
        'End Function
        'Private Function filtraDetalle(ByVal dt1 As DataTable, ByVal dt2 As DataRow) As DataRow
        '    Dim rowArray() As DataRow
        '    rowArray = dt1.Select("NOPRCN= " & dt2.Item("NOPRCN") & " AND NGUIRM = " & dt2.Item("NGUITR") & " AND NCRRGU= " & dt2.Item("NCRRGU"))
        '    Return rowArray(0)
        'End Function

        'Private Function filtraServicioRows(ByVal dt1 As DataTable, ByVal dt2 As DataTable) As DataTable
        '    Dim dt As DataTable
        '    dt = dt1.Clone
        '    For Each row As DataRow In dt2.Rows
        '        dt.ImportRow(dt1.Select("NOPRCN= " & row.Item("NOPRCN") & " AND NGUITR= " & row.Item("NGUIRM") & " AND NCRRGU= " & row.Item("NCRRGU"))(0))
        '    Next
        '    Return dt
        'End Function

        'Private Function filtraDetalle(ByVal dt1 As DataTable, ByVal dt2 As DataTable) As DataTable
        '    Dim dt As DataTable
        '    dt = dt1.Clone
        '    For Each row As DataRow In dt2.Rows
        '        dt.ImportRow(dt1.Select("NOPRCN= " & row.Item("NOPRCN") & " AND NGUIRM = " & row.Item("NGUITR") & " AND NCRRGU= " & row.Item("NCRRGU"))(0))
        '    Next
        '    Return dt
        'End Function

        Public Function ObtieneLote() As DataTable
            Return SelectDistinct(oDtServicioActualizar.Copy, "LOTE", "NDCCTC").Copy
        End Function

        Public Function ObtieneServicios_Factura(ByVal pintFact As Integer) As DataRow()
            Return oDtServicioActualizar.Select("NDCCTC= '" & pintFact.ToString & "'")
        End Function

        Private Function RowToDatatable(ByVal drSelect As DataRow(), ByVal tbl As DataTable) As DataTable
            Dim dt As New DataTable
            dt = tbl.Clone
            For Each row As DataRow In drSelect
                dt.ImportRow(row)
            Next
            Return dt
        End Function

        Public Function ObtieneLoteXFactura(ByVal intFactura As Integer) As String
            Return oDtServicioActualizar.Select("NDCCTC = '" & intFactura.ToString & "'")(0).Item("LOTE").ToString.Trim
        End Function

        Public Function Listar_Guia_Remision_x_Operacion(ByVal objetoParametro As Hashtable) As List(Of Factura_Transporte)
            Return objDataAccessLayer.Listar_Guia_Remision_x_Operacion(objetoParametro)
        End Function

    Public Function Listar_Operacion_x_Orden_Servicio(ByVal objetoParametro As Hashtable) As List(Of OperacionTransporte)
      Return objDataAccessLayer.Listar_Operacion_x_Orden_Servicio(objetoParametro)
    End Function

    Public Function Listar_Orden_Servicio_Facturacion(ByVal objParametro As Hashtable) As List(Of OrdenServicioTransporte)
      Return objDataAccessLayer.Listar_Orden_Servicio_Facturacion(objParametro)
    End Function

    Public Function Listar_Consistencia_Factura_x_Orden_Servicio(ByVal objParametro As Hashtable) As List(Of Factura_Transporte)
      Return objDataAccessLayer.Listar_Consistencia_Factura_x_Orden_Servicio(objParametro)
    End Function

        Public Function Listar_Sustento_Factura(ByVal objParametro As Hashtable) As List(Of Factura_Transporte)
            Return objDataAccessLayer.Listar_Sustento_Factura(objParametro)
        End Function

        Public Function Listar_Sustento_Factura_Lote(ByVal objParametro As Hashtable, ByVal drSelect As DataRow()) As List(Of Factura_Transporte)
            objParametro.Add("TipoCambio", dblTipoCambio)
            objParametro.Add("MonedaFactura", strTipomoneda)
            Return objDataAccessLayer.Listar_Sustento_Factura_Lote(objParametro, drSelect)
        End Function

    Public Function Listar_Planta_x_Cliente_Factura(ByVal objParametro As Hashtable) As List(Of Factura_Transporte)
      Return objDataAccessLayer.Listar_Planta_x_Cliente_Factura(objParametro)
    End Function

    Public Function Actualizar_Cliente_Facturar(ByVal objParametro As Hashtable) As Int64
      Return objDataAccessLayer.Actualizar_Cliente_Facturar(objParametro)
    End Function

    Public Function Obtener_Cliente_x_Orden_Servicio(ByVal objParametro As Hashtable) As String
      Return objDataAccessLayer.Obtener_Cliente_x_Orden_Servicio(objParametro)
    End Function

    Public Function Verificar_Cliente_Especial(ByVal objParametro As Hashtable) As Int64
      Return objDataAccessLayer.Verificar_Cliente_Especial(objParametro)
    End Function

    Public Function Pre_Facturar_Operacion(ByVal objParametro As Hashtable) As Int32
      Return objDataAccessLayer.Pre_Facturar_Operacion(objParametro)
    End Function

    Public Function Lista_Tipo_Cambio(ByVal objParametro As Hashtable) As DataTable
      Return objDataAccessLayer.Lista_Tipo_Cambio(objParametro)
    End Function

    Public Function Lista_Giro_Negocio(ByVal objParametro As Hashtable) As DataTable
      Return objDataAccessLayer.Lista_Giro_Negocio(objParametro)
    End Function

    Public Sub Llenar_Documentos(ByVal objParametro As Hashtable)
      oDtDocumentos = objDataAccessLayer.Lista_Documentos_Permitidos(objParametro)
    End Sub
    Public Sub Llenar_Documentos_Notas(ByVal objParametro As Hashtable)
      oDtDocumentos = objDataAccessLayer.Lista_Documentos_Permitidos_Notas(objParametro)
    End Sub

    Public Function Lista_Planta_Cliente(ByVal objParametro As Hashtable) As DataTable
      Return objDataAccessLayer.Lista_Planta_Cliente(objParametro)
    End Function

    Public Function Lista_Punto_Venta(ByVal objParametro As Hashtable) As DataTable
      Dim oDr() As DataRow
      Dim oDrNew As DataRow
      Dim oDt As DataTable
      Dim intCont As Integer
      Try
        oDr = oDtDocumentos.Select("CGRONG = '" & objParametro("CGRONG") & "'")
        oTipoDocumento = CType(oDr(0).Item("CTPODC").ToString.Trim, Double)
        oDt = New DataTable
        oDt.Columns.Add(New DataColumn("NPTOVT", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("TOBSAD", GetType(System.String)))
        For intCont = 0 To oDr.Length - 1
          oDrNew = oDt.NewRow
          oDrNew.Item("NPTOVT") = oDr(intCont).Item("NPTOVT").ToString.Trim
          oDrNew.Item("TOBSAD") = oDr(intCont).Item("TOBSAD").ToString.Trim
          oDt.Rows.Add(oDrNew)
        Next intCont
      Catch ex As Exception
        oDt = New DataTable
      End Try
      Return oDt
    End Function

    Public Function Lista_Datos_Cliente(ByVal objParametro As Hashtable) As DataTable
      Return objDataAccessLayer.Lista_Datos_Cliente(objParametro)
    End Function

    Public Sub Limpiar_Datos_Factura()
      oDtCabecera = New DataTable
    End Sub

    Public Function Cantidad_ReFacturas(ByRef objParametro As Hashtable) As Integer ', ByVal lboolEstado As Int32
      Dim oDt As DataTable
      Dim intCant, intIafcdt As Integer ', intCentCosto As Integer
      Dim oDr() As DataRow
      Dim strDetraccion, strIGV As String ', strMoneda As String
      Dim oDrNew As DataRow
      Dim dblTotal As Double = 0
      oDtServicioActualizar = New DataTable
      Crear_Estructura_Actualizar_Servicio(oDtServicioActualizar)
      objTipoDetraccion = New Hashtable
      objValorReferencial = New Hashtable
      oDt = objDataAccessLayer.Lista_Detalle_Servicios_ReFactura(objParametro)
      While (1)
        If oDt.Rows.Count = 0 Then
          Exit While
        End If
        intCant = intCant + 1
        strDetraccion = oDt.Rows(0).Item("SRBAFD").ToString.Trim
        intIafcdt = oDt.Rows(0).Item("IPRCDT")
        strIGV = oDt.Rows(0).Item("CTIGVA").ToString.Trim
        'intCentCosto = oDt.Rows(0).Item("CCNCST")
        'strMoneda = oDt.Rows(0).Item("CMNDA1").ToString.Trim
        oDr = oDt.Select("SRBAFD <> '" & strDetraccion & "' OR CTIGVA <> " & strIGV & " OR IPRCDT = " & intIafcdt) '" OR CMNDA1 <> " & strMoneda)
        objTipoDetraccion.Add(intCant, oDt.Rows(0).Item("IPRCDT"))
        dblTotal = 0
        For intContador As Integer = 0 To oDr.Length - 1
          If (strDetraccion = oDr(intContador).Item("SRBAFD").ToString.Trim) And (intIafcdt = oDr(intContador).Item("IPRCDT")) And (strIGV = oDr(intContador).Item("CTIGVA").ToString.Trim) Then
            oDrNew = oDtServicioActualizar.NewRow
            dblTotal += oDr(intContador).Item("VLRFDT")
            oDrNew.Item("CTPODC") = dblTipoDoc
            oDrNew.Item("NDCCTC") = intCant
            oDrNew.Item("NOPRCN") = oDr(intContador).Item("NOPRCN").ToString.Trim
            oDrNew.Item("NGUIRM") = oDr(intContador).Item("NGUITR").ToString.Trim
            oDrNew.Item("CRBCTC") = oDr(intContador).Item("CSRVC").ToString.Trim
            oDrNew.Item("QCNDTG") = oDr(intContador).Item("QATNAN")
            oDrNew.Item("CUNDSR") = oDr(intContador).Item("CUNDSR").ToString.Trim
            oDrNew.Item("ISRVGU") = oDr(intContador).Item("IMPSOL")
            oDtServicioActualizar.Rows.Add(oDrNew)
          End If
        Next
        objValorReferencial.Add(intCant, dblTotal)
        If oDr.Length = 0 Then
          Exit While
        Else
          Eliminar_Rows_Detalles(oDt, strDetraccion, strIGV, intIafcdt) 'strMoneda)
        End If

      End While
      objParametro = Nothing
      objParametro = objValorReferencial
      Return intCant
        End Function

        Public Function Traer_Facturas_Lote(ByRef objParametro As Hashtable) As DataTable
            oDsServicioLote = objDataAccessLayer.Lista_Detalle_Servicios_Lote(objParametro)
            Return oDsServicioLote.Tables(1)
        End Function

        Public Function Cantidad_Facturas_Lote(ByRef objParametro As Hashtable, ByVal dtparamLote As DataTable) As Integer ', ByVal lboolEstado As Int32
            Dim intCant, intIafcdt As Integer ', intCentCosto As Integer
            Dim strDetraccion, strIGV As String ', strMoneda As String
            Dim oDrNew As DataRow
            Dim dblTotal As Double = 0
            oDtServicioActualizar = New DataTable
            Crear_Estructura_Actualizar_Servicio(oDtServicioActualizar)

            oDtServicioActualizar.Columns.Add(New DataColumn("NCRRGU", GetType(System.Double))) 'Correlativo
            oDtServicioActualizar.Columns.Add(New DataColumn("IMPORTE", GetType(System.Double))) 'Importe
            oDtServicioActualizar.Columns.Add(New DataColumn("TOTAL", GetType(System.Double))) 'Total
            oDtServicioActualizar.Columns.Add(New DataColumn("LOTE", GetType(System.String))) 'Lote
            oDtServicioActualizar.Columns.Add(New DataColumn("PSOVOL", GetType(System.Double))) 'Peso Volumen
            oDtServicioActualizar.Columns.Add(New DataColumn("PESO", GetType(System.Double))) 'Peso Kg

            oDtServicioActualizar.Columns.Add(New DataColumn("CCMPN", GetType(System.String)))  'Divición
            oDtServicioActualizar.Columns.Add(New DataColumn("CDVSN", GetType(System.String)))  'Divición
            oDtServicioActualizar.Columns.Add(New DataColumn("SRPTRM", GetType(System.String))) 'Tipo de Unidad
            oDtServicioActualizar.Columns.Add(New DataColumn("CCNCST", GetType(System.Double))) 'Centro de Beneficio Propio
            oDtServicioActualizar.Columns.Add(New DataColumn("CCNCS1", GetType(System.Double))) 'Centro de Beneficio Tercero
            oDtServicioActualizar.Columns.Add(New DataColumn("PIGVA", GetType(System.Double))) 'IGV
            oDtServicioActualizar.Columns.Add(New DataColumn("TSGNMN", GetType(System.String))) 'IGV

            objTipoDetraccion = New Hashtable
            objValorReferencial = New Hashtable

            'oDsServicioLote = objDataAccessLayer.Lista_Detalle_Servicios_Lote(objParametro)
            Dim dtLote As DataTable = dtparamLote
            Dim drLoteCero As DataRow() = dtLote.Select("PESO_VOL = 0")
            Dim strOperacionesCero As New Text.StringBuilder
            Dim dtCero As New DataTable
            dtCero = SelectDistinct(RowToDatatable(drLoteCero, dtLote).Copy, "NOPRCN").Copy()

            If drLoteCero.Length > 0 Then
                For row As Integer = 0 To dtCero.Rows.Count - 1
                    strOperacionesCero.Append(dtCero.Rows(row).Item("NOPRCN"))
                    If row < dtCero.Rows.Count - 1 Then
                        strOperacionesCero.Append(",")
                    End If
                Next
                objParametro("PSOPERACIONES") = strOperacionesCero.ToString
                Return -1
            End If
            Dim dtServiciosTemp As DataTable
            Dim dblPsoVolOperacion As Double = 0
            Dim dblPsoVolOperacionLote As Double = 0
            Dim dblPesoOperacionLote As Double = 0
            Dim drLoteSelect As DataRow() = Nothing
            Dim drLoteOperacionSelect As DataRow() = Nothing
            Dim drSelectServicio As DataRow() = Nothing
            Dim dtServDetraccion As New DataTable
            Dim drSelectDetraccion As DataRow() = Nothing
            Dim dtOperacionXlote As New DataTable
            Dim dtGuiaOperacionLote As New DataTable
            Dim drSelectServicio_Operaciones As DataRow() = Nothing
            Dim dtOperaciones_Lote As New DataTable
            Dim strOperaciones As System.Text.StringBuilder

            For i As Integer = 0 To dtLote.Rows.Count - 1
                'Filtra los lotes del primer lote de la selección
                'debe estar ordenado por Lote
                'Recorre los Lotes
                dtServiciosTemp = oDsServicioLote.Tables(0).Copy

                dtServiciosTemp.Columns.Add(New DataColumn("PSOVOL", GetType(System.Double))) 'Peso Volumen
                dtServiciosTemp.Columns.Add(New DataColumn("PESO", GetType(System.Double))) 'Peso Kg
                drLoteSelect = dtLote.Select("LOTE = '" + dtLote.Rows(i)("LOTE").ToString + "'")
                'Ordenado por Operacion
                'Copia la Estructura a un Dt
                dtOperacionXlote = Nothing
                dtOperacionXlote = RowToDatatable(drLoteSelect, dtLote)
                Dim dvSort As New DataView(dtOperacionXlote)
                dvSort.Sort = "NOPRCN ASC"
                dtOperacionXlote = dvSort.ToTable()

                If drLoteSelect.Length > 0 Then
                    'Guarda las operaciones del lote 
                    dtOperaciones_Lote = SelectDistinct(dtOperacionXlote.Copy, "NOPRCN").Copy
                    strOperaciones = New System.Text.StringBuilder
                    strOperaciones.Append("NOPRCN IN ( ")
                    For row As Integer = 0 To dtOperaciones_Lote.Rows.Count - 1
                        strOperaciones.Append(dtOperaciones_Lote.Rows(row).Item("NOPRCN"))
                        If row < dtOperaciones_Lote.Rows.Count - 1 Then
                            strOperaciones.Append(",")
                        End If
                    Next
                    strOperaciones.Append(" )")
                    drSelectServicio_Operaciones = dtServiciosTemp.Select(strOperaciones.ToString)

                    If Not dtLote.Rows(i)("TIPO").ToString.Equals("MANUAL") Then
                        'Procedimiento para Distribuir Importes Segun Peso Volumen
                        For ii As Integer = 0 To dtOperacionXlote.Rows.Count - 1
                            'Obtiene las Guías de las Operaciones
                            drLoteOperacionSelect = dtOperacionXlote.Select("NOPRCN = " + dtOperacionXlote.Rows(ii)("NOPRCN").ToString + "")
                            dtGuiaOperacionLote = Nothing
                            dtGuiaOperacionLote = RowToDatatable(drLoteOperacionSelect, dtLote)
                            If drLoteOperacionSelect.Length > 0 Then
                                'Suma el Peso Volumen de todas las guías de la operacion
                                dblPsoVolOperacion = dtLote.Compute("Sum(PESO_VOL)", "CCLNT = " + dtOperacionXlote.Rows(ii)("CCLNT").ToString.Trim + " AND NOPRCN = " + dtOperacionXlote.Rows(ii)("NOPRCN").ToString)
                                'Suma el Peso Volumen de las Guias de una operacion en un Lote
                                dblPsoVolOperacionLote = dtGuiaOperacionLote.Compute("Sum(PESO_VOL)", "CCLNT = " + dtOperacionXlote.Rows(ii)("CCLNT").ToString.Trim + " AND NOPRCN = " + dtOperacionXlote.Rows(ii)("NOPRCN").ToString)
                                dblPesoOperacionLote = dtGuiaOperacionLote.Compute("Sum(PESO)", "CCLNT = " + dtOperacionXlote.Rows(ii)("CCLNT").ToString.Trim + " AND NOPRCN = " + dtOperacionXlote.Rows(ii)("NOPRCN").ToString)
                                'Obtiene los servicios de la operacion Actual
                                drSelectServicio = dtServiciosTemp.Select("CCLNT = " + dtOperacionXlote.Rows(ii)("CCLNT").ToString.Trim + " AND NOPRCN = " + dtOperacionXlote.Rows(ii)("NOPRCN").ToString) '+ " AND NGUITR = " + dr("NRGUCL").ToString)
                                If drSelectServicio.Length > 0 Then
                                    'Importa los Servicios por Operación en un Repositorio
                                    'Ordenar por SRBAFD,CTIGVA,IPRCDT
                                    'Recalcula los Nuevos Importes de los servicios X Operacion
                                    For Each drServ As DataRow In drSelectServicio
                                        drServ.Item("IMPSOL") = drServ.Item("IMPSOL") * dblPsoVolOperacionLote / dblPsoVolOperacion
                                        drServ.Item("ISRVGU") = drServ.Item("ISRVGU") * dblPsoVolOperacionLote / dblPsoVolOperacion
                                        drServ.Item("PSOVOL") = dblPsoVolOperacionLote
                                        drServ.Item("PESO") = dblPesoOperacionLote
                                    Next
                                End If
                                ''Incrementa Lote Operacion
                                ii = ii + drLoteOperacionSelect.Length - 1
                            End If
                        Next
                    Else
                        For Each drServ As DataRow In drSelectServicio_Operaciones
                            drServ.Item("PSOVOL") = 0
                            drServ.Item("PESO") = 0
                        Next
                    End If
                    ''Recorren los Servicios y los Distribuye segun criterios
                    dtServDetraccion = Nothing
                    dtServDetraccion = RowToDatatable(drSelectServicio_Operaciones, dtServiciosTemp)
                    While (1)
                        If dtServDetraccion.Rows.Count = 0 Then
                            Exit While
                        End If
                        intCant = intCant + 1
                        strDetraccion = dtServDetraccion.Rows(0).Item("SRBAFD").ToString.Trim
                        intIafcdt = dtServDetraccion.Rows(0).Item("IPRCDT")
                        strIGV = dtServDetraccion.Rows(0).Item("CTIGVA").ToString.Trim
                        drSelectDetraccion = dtServDetraccion.Select("SRBAFD <> '" & strDetraccion & "' OR CTIGVA <> " & strIGV & " OR IPRCDT = " & intIafcdt) '" OR CMNDA1 <> " & strMoneda)

                        If drSelectDetraccion.Length > 0 Then
                            objTipoDetraccion.Add(intCant, drSelectDetraccion(0).Item("IPRCDT"))
                            dblTotal = 0
                            For Each drServ As DataRow In drSelectDetraccion
                                If (strDetraccion = drServ.Item("SRBAFD").ToString.Trim) And (intIafcdt = drServ.Item("IPRCDT")) And (strIGV = drServ.Item("CTIGVA").ToString.Trim) Then
                                    oDrNew = oDtServicioActualizar.NewRow
                                    dblTotal += drServ.Item("VLRFDT")
                                    oDrNew.Item("CTPODC") = dblTipoDoc
                                    oDrNew.Item("NDCCTC") = intCant
                                    oDrNew.Item("NOPRCN") = drServ.Item("NOPRCN").ToString.Trim
                                    oDrNew.Item("NGUIRM") = drServ.Item("NGUITR").ToString.Trim
                                    oDrNew.Item("CRBCTC") = drServ.Item("CSRVC").ToString.Trim
                                    oDrNew.Item("QCNDTG") = drServ.Item("QATNAN")
                                    oDrNew.Item("CUNDSR") = drServ.Item("CUNDSR").ToString.Trim
                                    oDrNew.Item("ISRVGU") = Format(drServ.Item("IMPSOL"), "###,###,###,###,###.00")
                                    oDrNew.Item("IMPORTE") = Format(drServ.Item("ISRVGU"), "###,###,###,###,###.00")
                                    oDrNew.Item("TOTAL") = Format(drServ.Item("ISRVGU") * drServ.Item("QATNAN"), "###,###,###,###,###.00")
                                    oDrNew.Item("LOTE") = dtLote.Rows(i)("LOTE").ToString.Trim
                                    oDrNew.Item("NCRRGU") = drServ.Item("NCRRGU").ToString.Trim
                                    oDrNew.Item("SRPTRM") = drServ.Item("SRPTRM").ToString.Trim
                                    oDrNew.Item("PSOVOL") = drServ.Item("PSOVOL").ToString.Trim
                                    oDrNew.Item("PESO") = drServ.Item("PESO").ToString.Trim
                                    oDrNew.Item("CCMPN") = drServ.Item("CCMPN").ToString.Trim
                                    oDrNew.Item("CDVSN") = drServ.Item("CDVSN").ToString.Trim
                                    oDrNew.Item("SRPTRM") = drServ.Item("SRPTRM").ToString.Trim
                                    oDrNew.Item("CCNCST") = drServ.Item("CCNCST")
                                    oDrNew.Item("CCNCS1") = drServ.Item("CCNCS1")
                                    oDrNew.Item("PIGVA") = drServ.Item("PIGVA")
                                    oDrNew.Item("CMNDGU") = drServ.Item("CMNDA1").ToString.Trim
                                    oDrNew.Item("TSGNMN") = drServ.Item("TSGNMN")
                                    oDtServicioActualizar.Rows.Add(oDrNew)
                                End If
                            Next
                        End If

                        objValorReferencial.Add(intCant, dblTotal)
                        If dtServDetraccion.Rows.Count = 0 Then
                            Exit While
                        Else
                            Eliminar_Rows_Detalles(dtServDetraccion, strDetraccion, strIGV, intIafcdt) 'strMoneda)
                        End If
                    End While
                    'Incrementa Lote
                    i = i + drLoteSelect.Length - 1
                End If
            Next
            objParametro = Nothing
            objParametro = objValorReferencial
            Return intCant
        End Function

    Public Function Cantidad_Facturas(ByRef objParametro As Hashtable) As Integer ', ByVal lboolEstado As Int32
      Dim oDt As DataTable
      Dim intCant, intIafcdt As Integer ', intCentCosto As Integer
      Dim oDr() As DataRow
      Dim strDetraccion, strIGV As String ', strMoneda As String
      Dim oDrNew As DataRow
      Dim dblTotal As Double = 0
      oDtServicioActualizar = New DataTable
      Crear_Estructura_Actualizar_Servicio(oDtServicioActualizar)
      objTipoDetraccion = New Hashtable
      objValorReferencial = New Hashtable
      oDt = objDataAccessLayer.Lista_Detalle_Servicios(objParametro)
      While (1)
        If oDt.Rows.Count = 0 Then
          Exit While
        End If
        intCant = intCant + 1
        strDetraccion = oDt.Rows(0).Item("SRBAFD").ToString.Trim
        intIafcdt = oDt.Rows(0).Item("IPRCDT")
        strIGV = oDt.Rows(0).Item("CTIGVA").ToString.Trim
        'intCentCosto = oDt.Rows(0).Item("CCNCST")
        'strMoneda = oDt.Rows(0).Item("CMNDA1").ToString.Trim
        oDr = oDt.Select("SRBAFD <> '" & strDetraccion & "' OR CTIGVA <> " & strIGV & " OR IPRCDT = " & intIafcdt) '" OR CMNDA1 <> " & strMoneda)
        objTipoDetraccion.Add(intCant, oDt.Rows(0).Item("IPRCDT"))
        dblTotal = 0
        For intContador As Integer = 0 To oDr.Length - 1
          If (strDetraccion = oDr(intContador).Item("SRBAFD").ToString.Trim) And (intIafcdt = oDr(intContador).Item("IPRCDT")) And (strIGV = oDr(intContador).Item("CTIGVA").ToString.Trim) Then
            oDrNew = oDtServicioActualizar.NewRow
            dblTotal += oDr(intContador).Item("VLRFDT")
            oDrNew.Item("CTPODC") = dblTipoDoc
            oDrNew.Item("NDCCTC") = intCant
            oDrNew.Item("NOPRCN") = oDr(intContador).Item("NOPRCN").ToString.Trim
            oDrNew.Item("NGUIRM") = oDr(intContador).Item("NGUITR").ToString.Trim
            oDrNew.Item("CRBCTC") = oDr(intContador).Item("CSRVC").ToString.Trim
            oDrNew.Item("QCNDTG") = oDr(intContador).Item("QATNAN")
            oDrNew.Item("CUNDSR") = oDr(intContador).Item("CUNDSR").ToString.Trim
            oDrNew.Item("ISRVGU") = oDr(intContador).Item("IMPSOL")
            oDtServicioActualizar.Rows.Add(oDrNew)
          End If
        Next
        objValorReferencial.Add(intCant, dblTotal)
        If oDr.Length = 0 Then
          Exit While
        Else
          Eliminar_Rows_Detalles(oDt, strDetraccion, strIGV, intIafcdt) 'strMoneda)
        End If

      End While
      objParametro = Nothing
      objParametro = objValorReferencial
      Return intCant
    End Function

    Public Function Cantidad_ReFacturas_Notas(ByRef objParametro As Hashtable) As Integer ', ByVal lboolEstado As Int32
      Dim oDt As DataTable
      Dim intCant, intIafcdt As Integer ', intCentCosto As Integer
      Dim oDr() As DataRow
      Dim strDetraccion, strIGV As String ', strMoneda As String
      Dim oDrNew As DataRow
      Dim dblTotal As Double = 0
      Dim intMoneda As Int32 = 0
      oDtServicioActualizar = New DataTable
      Crear_Estructura_Actualizar_Servicio(oDtServicioActualizar)
      objTipoDetraccion = New Hashtable
      objValorReferencial = New Hashtable
      oDt = objDataAccessLayer.Lista_Detalle_Servicios_Notas(objParametro)
      intMoneda = IIf(objParametro("PSCMNDA").Equals("SOL"), 1, 100)
      While (1)
        If oDt.Rows.Count = 0 Then
          Exit While
        End If
        intCant = intCant + 1
        strDetraccion = oDt.Rows(0).Item("SRBAFD").ToString.Trim
        intIafcdt = oDt.Rows(0).Item("IPRCDT")
        strIGV = oDt.Rows(0).Item("CTIGVA").ToString.Trim
        'intCentCosto = oDt.Rows(0).Item("CCNCST")
        'strMoneda = oDt.Rows(0).Item("CMNDA1").ToString.Trim
        oDr = oDt.Select("SRBAFD <> '" & strDetraccion & "' OR CTIGVA <> " & strIGV & " OR IPRCDT = " & intIafcdt) '" OR CMNDA1 <> " & strMoneda)
        objTipoDetraccion.Add(intCant, oDt.Rows(0).Item("IPRCDT"))
        dblTotal = 0
        For intContador As Integer = 0 To oDr.Length - 1
          If (strDetraccion = oDr(intContador).Item("SRBAFD").ToString.Trim) And (intIafcdt = oDr(intContador).Item("IPRCDT")) And (strIGV = oDr(intContador).Item("CTIGVA").ToString.Trim) Then
            oDrNew = oDtServicioActualizar.NewRow
            dblTotal += oDr(intContador).Item("VLRFDT")
            oDrNew.Item("CTPODC") = dblTipoDoc
            oDrNew.Item("NDCCTC") = intCant
            oDrNew.Item("NOPRCN") = oDr(intContador).Item("NOPRCN").ToString.Trim
            oDrNew.Item("NGUIRM") = oDr(intContador).Item("NGUITR").ToString.Trim
            oDrNew.Item("CRBCTC") = oDr(intContador).Item("CSRVC").ToString.Trim
            oDrNew.Item("QCNDTG") = oDr(intContador).Item("QATNAN")
            oDrNew.Item("CUNDSR") = oDr(intContador).Item("CUNDSR").ToString.Trim
            oDrNew.Item("ISRVGU") = oDr(intContador).Item("IMPSOL")
                        oDrNew.Item("CMNDGU") = intMoneda
                        oDrNew.Item("IVLRLV") = oDr(intContador).Item("IMPSOLFAC")
            oDtServicioActualizar.Rows.Add(oDrNew)
          End If
        Next
        objValorReferencial.Add(intCant, dblTotal)
        If oDr.Length = 0 Then
          Exit While
        Else
          Eliminar_Rows_Detalles(oDt, strDetraccion, strIGV, intIafcdt) 'strMoneda)
        End If

      End While
      objParametro = Nothing
      objParametro = objValorReferencial
      Return intCant
    End Function

    Public Sub Eliminar_Rows_Detalles(ByRef poDt As DataTable, ByVal pstrDetraccion As String, ByVal pstrIGV As String, ByVal intIafcdt As Integer) 'ByVal pstrMoneda As String)
      Dim intCont As Integer

      For intCont = poDt.Rows.Count - 1 To 0 Step -1
        If poDt.Rows(intCont).Item("SRBAFD").ToString.Trim = pstrDetraccion And poDt.Rows(intCont).Item("CTIGVA").ToString.Trim = pstrIGV And poDt.Rows(intCont).Item("IPRCDT").ToString.Trim = intIafcdt Then 'poDt.Rows(intCont).Item("CMNDA1").ToString.Trim = pstrMoneda Then
          poDt.Rows.RemoveAt(intCont)
        End If
      Next intCont
        End Sub

        Public Function Lista_Cabecera_Factura(ByVal pobjFiltro As Hashtable) As DataTable
            Try
                Dim oDtCliente As DataTable
                Dim oDtPlantaCliente As DataTable
                Dim oDtPlanta As DataTable
                Dim oDr As DataRow
                Dim intCont As Integer
                Dim objFiltro As New Hashtable
                Crear_Estructura_Cabecera(oDtCabecera)
                objFiltro.Add("PNCCLNFC", pobjFiltro("PNCCLNFC"))
                objFiltro.Add("PSCCMPN", pobjFiltro("PSCCMPN"))

                oDtCliente = objDataAccessLayer.Lista_Datos_Cliente(objFiltro)
                objFiltro.Add("PNCPLNCL", strPlantaCli)
                oDtPlantaCliente = objDataAccessLayer.Lista_Datos_Planta_Cliente(objFiltro)
                objFiltro = New Hashtable
                objFiltro.Add("PSCCMPN", pobjFiltro("PSCCMPN"))
                objFiltro.Add("PSCDVSN", pobjFiltro("PSCDVSN"))
                objFiltro.Add("PNCPLDVN", pobjFiltro("PNCPLDVN"))
                oDtPlanta = objDataAccessLayer.Lista_Datos_Planta(objFiltro)
                Buscar_Documento() 'Obtiene el código de RZZM04
                For intCont = 0 To pobjFiltro("CANTFACT") - 1
                    oDr = oDtCabecera.NewRow
                    oDr.Item("CCMPN") = pobjFiltro("PSCCMPN")
                    oDr.Item("CTPODC") = dblTipoDoc
                    oDr.Item("NDCCTC") = intCont + 1
                    oDr.Item("NINDRN") = "0"
                    oDr.Item("CDVSN") = pobjFiltro("PSCDVSN")
                    oDr.Item("CGRONG") = strGiroNeg
                    oDr.Item("CZNFCC") = IIf(pobjFiltro("PNCZNFCC") = 0, oDtPlanta.Rows(0).Item("CZNFCC").ToString.Trim, pobjFiltro("PNCZNFCC").ToString.Trim)
                    oDr.Item("CCBRD") = oDtPlantaCliente.Rows(0).Item("CCBRD").ToString.Trim
                    oDr.Item("CCLNT") = oDtCliente.Rows(0).Item("CCLNT").ToString.Trim
                    oDr.Item("CPLNCL") = strPlantaCli
                    oDr.Item("NRUC") = oDtCliente.Rows(0).Item("NRUC").ToString.Trim
                    oDr.Item("CSTCDC") = "ZZ"
                    oDr.Item("CPLNDV") = pobjFiltro("PNCPLDVN")
                    oDr.Item("SABOPN") = "P"
                    oDr.Item("FDCCTC") = Format(pobjFiltro("PDFECFAC"), "yyyyMMdd")
                    oDr.Item("CMNDA") = IIf(pobjFiltro("PNCMNDA1") = "DOL" OrElse pobjFiltro("PNCMNDA1") = "100", 100, 1)
                    oDr.Item("ITTPGS") = 0
                    oDr.Item("ITTPGD") = 0
                    oDr.Item("ITCCTC") = pobjFiltro("PNTPCAM") 'dblTipoCambio
                    oDr.Item("SFLLTR") = IIf(oDtCliente.Rows(0).Item("CTPOCL").ToString.Trim.Equals("F"), "F", "T")
                    oDr.Item("NCTDCC") = intCont
                    oDr.Item("CZNCBD") = oDtCliente.Rows(0).Item("CZNCBR").ToString.Trim
                    oDr.Item("NDSPGD") = objTipoDetraccion(intCont + 1)
                    oDr.Item("VLRFDT") = objValorReferencial(intCont + 1)
                    oDr.Item("CRGVTA") = pobjFiltro("PSCRGVTA")
                    oDr.Item("FATNSR") = pobjFiltro("PNFATNSR")
                    oDr.Item("CTPDCO") = pobjFiltro("PNCTPDCO")
                    oDr.Item("NDCMOR") = pobjFiltro("PNNDCMOR")
                    oDr.Item("FDCMOR") = pobjFiltro("PNFDCMOR")

                    oDtCabecera.Rows.Add(oDr)
                Next intCont
            Catch ex As Exception
            End Try
            Return oDtCabecera
        End Function

        Public Function Lista_Cabecera_ReFactura(ByVal pobjFiltro As Hashtable) As DataTable
            Try
                Dim oDtCliente As DataTable
                Dim oDtPlantaCliente As DataTable
                Dim oDtPlanta As DataTable
                Dim oDr As DataRow
                Dim intCont As Integer
                Dim objFiltro As New Hashtable
                Crear_Estructura_Cabecera(oDtCabecera)
                objFiltro.Add("PNCCLNFC", pobjFiltro("PNCCLNFC"))
                objFiltro.Add("PSCCMPN", pobjFiltro("PSCCMPN"))

                oDtCliente = objDataAccessLayer.Lista_Datos_Cliente(objFiltro)
                objFiltro.Add("PNCPLNCL", strPlantaCli)
                oDtPlantaCliente = objDataAccessLayer.Lista_Datos_Planta_Cliente(objFiltro)
                objFiltro = New Hashtable
                objFiltro.Add("PSCCMPN", pobjFiltro("PSCCMPN"))
                objFiltro.Add("PSCDVSN", pobjFiltro("PSCDVSN"))
                objFiltro.Add("PNCPLDVN", pobjFiltro("PNCPLDVN"))
                oDtPlanta = objDataAccessLayer.Lista_Datos_Planta(objFiltro)
                Buscar_Documento() 'Obtiene el código de RZZM04
                For intCont = 0 To pobjFiltro("CANTFACT") - 1
                    oDr = oDtCabecera.NewRow
                    oDr.Item("CCMPN") = pobjFiltro("PSCCMPN")
                    oDr.Item("CTPODC") = dblTipoDoc
                    oDr.Item("NDCCTC") = intCont + 1
                    oDr.Item("NINDRN") = "0"
                    oDr.Item("CDVSN") = pobjFiltro("PSCDVSN")
                    oDr.Item("CGRONG") = strGiroNeg
                    oDr.Item("CZNFCC") = IIf(pobjFiltro("PNCZNFCC") = 0, oDtPlanta.Rows(0).Item("CZNFCC").ToString.Trim, pobjFiltro("PNCZNFCC").ToString.Trim)
                    oDr.Item("CCBRD") = oDtPlantaCliente.Rows(0).Item("CCBRD").ToString.Trim
                    oDr.Item("CCLNT") = oDtCliente.Rows(0).Item("CCLNT").ToString.Trim
                    oDr.Item("CPLNCL") = strPlantaCli
                    oDr.Item("NRUC") = oDtCliente.Rows(0).Item("NRUC").ToString.Trim
                    oDr.Item("CSTCDC") = "ZZ"
                    oDr.Item("CPLNDV") = pobjFiltro("PNCPLDVN")
                    oDr.Item("SABOPN") = "P"
                    oDr.Item("FDCCTC") = Format(pobjFiltro("PDFECFAC"), "yyyyMMdd")
                    oDr.Item("CMNDA") = IIf(pobjFiltro("PNCMNDA1") = "DOL" OrElse pobjFiltro("PNCMNDA1") = "100", 100, 1)
                    oDr.Item("ITTPGS") = 0
                    oDr.Item("ITTPGD") = 0
                    oDr.Item("ITCCTC") = pobjFiltro("PNTPCAM") 'dblTipoCambio
                    oDr.Item("SFLLTR") = IIf(oDtCliente.Rows(0).Item("CTPOCL").ToString.Trim.Equals("F"), "F", "T")
                    oDr.Item("NCTDCC") = intCont
                    oDr.Item("CZNCBD") = oDtCliente.Rows(0).Item("CZNCBR").ToString.Trim
                    oDr.Item("NDSPGD") = objTipoDetraccion(intCont + 1)
                    oDr.Item("VLRFDT") = objValorReferencial(intCont + 1)
                    oDr.Item("CRGVTA") = pobjFiltro("PSCRGVTA")
                    oDr.Item("FATNSR") = pobjFiltro("PNFATNSR")
                    oDr.Item("CTPDCO") = 0
                    oDr.Item("NDCMOR") = 0
                    oDr.Item("FDCMOR") = 0

                    oDtCabecera.Rows.Add(oDr)
                Next intCont
            Catch ex As Exception
            End Try
            Return oDtCabecera
        End Function

        Public Function Lista_Detalle_ReFacturas(ByVal pobjFiltro As Hashtable, ByRef strIGV As Hashtable) As DataTable
            Dim oDt As New DataTable
            Dim oDtServicios As DataTable
            Dim oDtFactura As DataTable
            Dim intDetalle As Integer
            Dim intNumFactura As Integer = 0
            Dim dblCenCos, dblCenCosMax As Double
            Dim dblTotalCant As Double
            Dim dblTotalMonto As Double
            Dim bolMismaUnidad As Boolean = True
            Dim bolMismaTarifa As Boolean = True
            Dim bolMismoCCosto As Boolean = True
            Dim dblTarifaAnt As Double = 0
            Dim oDr As DataRow
            Dim oDrDet() As DataRow
            Dim CodServicio As String
            Dim intTotalItems, intNumItems, intContador As Integer
            'Dim oDrItemCenCos() As DataRow
            Dim dblPorIgv As Double

            Dim objHas As Hashtable
            Dim objLista As List(Of Hashtable)
            Dim lintIndice As Int32
            Dim objGrid As Object
            Dim lstrCGRNGD As String = ""

            Crear_Estructura_Detalle(oDt)
            oDtServicios = objDataAccessLayer.Lista_Detalle_Servicios_ReFactura(pobjFiltro)

            If pobjFiltro("PSSTATUS") = 0 Then

                While (1) 'Se repite por la cantidad de Factura
                    intNumFactura = intNumFactura + 1
                    If intNumFactura > pobjFiltro("CANTFACT") Then
                        Exit While
                    End If
                    If oTipoDocumento = 1 Then
                        oDtFactura = Detalle_Factura(oDtServicios)
                    Else
                        oDtFactura = oDtServicios
                    End If
                    If oDtFactura.Rows(0).Item("SRPTRM").ToString.Trim = "P" Then
                        dblCenCosMax = oDtFactura.Rows(0).Item("CCNCST").ToString.Trim
                    Else
                        dblCenCosMax = oDtFactura.Rows(0).Item("CCNCS1").ToString.Trim
                    End If
                    oDtCabecera.Rows(intNumFactura - 1).Item("CCNCSC") = dblCenCosMax
                    intTotalItems = oDtFactura.Rows.Count
                    'If intTotalItems > 15 Then intNroMaxItem = intTotalItems
                    intNumItems = 0
                    intDetalle = 0
                    dblPorIgv = oDtFactura.Rows(0).Item("PIGVA").ToString.Trim
                    'strIGV = dblPorIgv.ToString
                    strIGV.Add(intNumFactura, dblPorIgv.ToString)
                    While (1) 'Se repite por la cantidad de Detalles de la Factura
                        If intNumItems > intTotalItems - 1 Then
                            Exit While
                        End If
                        If oTipoDocumento = 1 Then
                            CodServicio = oDtFactura.Rows(0).Item("CSRVC").ToString.Trim
                        Else
                            CodServicio = oDtFactura.Rows(intNumItems).Item("CSRVC").ToString.Trim
                        End If
                        oDrDet = oDtFactura.Select("CSRVC = " & CodServicio)
                        Validar_Detalles(oDrDet, bolMismoCCosto, bolMismaUnidad) 'Indica si tiene mismo centro o misma unidad
                        If bolMismoCCosto Then 'Es el mismo centro de costo o el mismo tipo de unidades
                            objLista = New List(Of Hashtable)

                            For lint As Int32 = 0 To oDrDet.Length - 1
                                objHas = New Hashtable
                                objHas.Add(1, oDrDet(lint).ItemArray(8))
                                objHas.Add(2, oDrDet(lint).ItemArray(9))
                                objHas.Add(3, oDrDet(lint).ItemArray(5))
                                objHas.Add(4, oDrDet(lint).ItemArray(7))
                                objLista.Add(objHas)
                            Next
                            lintIndice = 0
                            While (1)
                                'oListaTemp = New List(Of Int32)
                                dblTotalMonto = 0
                                dblTotalCant = 0
                                intContador = 0
                                If objLista.Count <= 0 Then
                                    Exit While
                                End If
                                For lintIndice = 0 To objLista.Count - 1
                                    If lintIndice = 0 Then
                                        dblTarifaAnt = objLista(lintIndice).Item(1) 'oDrDet(intCont).Item("NRTFSV")
                                        dblTotalMonto = dblTotalMonto + objLista(lintIndice).Item(2) 'oDrDet(intCont).Item("TOTAL")
                                        'If bolMismaUnidad Then
                                        dblTotalCant = dblTotalCant + objLista(lintIndice).Item(3) 'oDrDet(intCont).Item("QATNAN").ToString.Trim
                                        'End If
                                        intNumItems += 1
                                        intContador += 1
                                        'oListaTemp.Add(lintIndice)
                                    Else
                                        If dblTarifaAnt = objLista(lintIndice).Item(1) Then 'oDrDet(intCont).Item("NRTFSV") Then
                                            dblTotalMonto = dblTotalMonto + objLista(lintIndice).Item(2) 'oDrDet(intCont).Item("TOTAL")
                                            'If bolMismaUnidad Then
                                            dblTotalCant = dblTotalCant + objLista(lintIndice).Item(3) 'oDrDet(intCont).Item("QATNAN").ToString.Trim
                                            'End If
                                            intNumItems += 1
                                            intContador += 1
                                            'oListaTemp.Add(lintIndice)
                                        End If
                                    End If
                                Next
                                If oDrDet(0).Item("SRPTRM").ToString.Trim = "P" Then
                                    dblCenCos = oDrDet(0).Item("CCNCST").ToString.Trim
                                    lstrCGRNGD = "9"
                                Else
                                    dblCenCos = oDrDet(0).Item("CCNCS1").ToString.Trim
                                    lstrCGRNGD = "10"
                                End If
                                intDetalle = intDetalle + 1
                                oDr = oDt.NewRow
                                oDr("CCMPN") = oDrDet(0).Item("CCMPN").ToString.Trim
                                oDr("CTPODC") = dblTipoDoc
                                oDr("NDCCTC") = intNumFactura 'Numero del documento
                                oDr("NINDRN") = "0"
                                oDr("NCRDCC") = intDetalle
                                oDr("CRBCTC") = oDrDet(0).Item("CSRVC").ToString.Trim
                                oDr("STCCTC") = "" 'Flag tipo control
                                If bolMismaUnidad Then
                                    oDr("CUNCNA") = oDrDet(0).Item("CUNDSR").ToString.Trim
                                    oDr("QAPCTC") = dblTotalCant 'oDrDet(0).Item("QCNESP").ToString.Trim
                                    oDr("ITRCTC") = dblTarifaAnt 'Format(dblTotalMonto / dblTotalCant, "###,###,###,###,###.00000") 'dblTotalCant
                                Else
                                    oDr("CUNCNA") = objLista(0).Item(4) '"UNI"
                                    oDr("QAPCTC") = dblTotalCant '"1"
                                    oDr("ITRCTC") = dblTarifaAnt 'Format(dblTotalMonto / dblTotalCant, "###,###,###,###,###.00000") 'dblTotalMonto
                                End If
                                oDr("CUTCTC") = oDrDet(0).Item("TSGNMN").ToString.Trim
                                dblTotalMonto = Format(dblTotalMonto, "###,###,###,###,###.00")
                                If oDrDet(0).Item("TSGNMN").ToString.Trim = "SOL" Then
                                    oDr("IVLDCS") = dblTotalMonto
                                    oDr("IVLDCD") = Format(dblTotalMonto / dblTipoCambio, "###,###,###,###,###.00")
                                Else
                                    oDr("IVLDCS") = Format(dblTotalMonto * dblTipoCambio, "###,###,###,###,###.00")
                                    oDr("IVLDCD") = dblTotalMonto
                                End If
                                oDr("NCTDCC") = intNumFactura
                                oDr("FDCCTC") = oDtCabecera.Rows(intNumFactura - 1).Item("FDCCTC").ToString.Trim
                                oDr("CDVSN") = oDrDet(0).Item("CDVSN").ToString.Trim
                                oDr("CGRNGD") = lstrCGRNGD 'oDtCabecera.Rows(intNumFactura - 1).Item("CGRONG").ToString.Trim
                                oDr("CCNCSD") = dblCenCos
                                oDt.Rows.Add(oDr)
                                objLista.RemoveRange(0, intContador)
                            End While
                        Else
                            bolMismaUnidad = True
                            Dim odrPropio() As DataRow = oDtFactura.Select("CSRVC = " & CodServicio & " And SRPTRM = 'P'")
                            Dim odrTercero() As DataRow = oDtFactura.Select("CSRVC = " & CodServicio & " And SRPTRM <> 'P'")
                            'oDrItemCenCos = Lista_Items_Igual_CCosto(bolMismaUnidad, oDrDet) 'Devuelve los items que tienen el mismo centro de costo y elimina estos registros de oDrDet
                            objLista = New List(Of Hashtable)
                            For lint As Int32 = 0 To odrPropio.Length - 1
                                objHas = New Hashtable
                                objHas.Add(1, odrPropio(lint).ItemArray(8))
                                objHas.Add(2, odrPropio(lint).ItemArray(9))
                                objHas.Add(3, odrPropio(lint).ItemArray(5))
                                objHas.Add(4, odrPropio(lint).ItemArray(7))
                                objLista.Add(objHas)
                            Next
                            lintIndice = 0
                            While (1)
                                'oListaTemp = New List(Of Int32)
                                dblTotalMonto = 0
                                dblTotalCant = 0
                                intContador = 0
                                If objLista.Count < 1 Then
                                    Exit While
                                End If
                                For lintIndice = 0 To objLista.Count - 1
                                    If lintIndice = 0 Then
                                        dblTarifaAnt = objLista(lintIndice).Item(1) 'oDrDet(intCont).Item("NRTFSV")
                                        dblTotalMonto = dblTotalMonto + objLista(lintIndice).Item(2) 'oDrDet(intCont).Item("TOTAL")
                                        'If bolMismaUnidad Then
                                        dblTotalCant = dblTotalCant + objLista(lintIndice).Item(3) 'oDrDet(intCont).Item("QATNAN").ToString.Trim
                                        'End If
                                        intNumItems += 1
                                        intContador += 1
                                        'oListaTemp.Add(lintIndice)
                                    Else
                                        If dblTarifaAnt = objLista(lintIndice).Item(1) Then 'oDrDet(intCont).Item("NRTFSV") Then
                                            dblTotalMonto = dblTotalMonto + objLista(lintIndice).Item(2) 'oDrDet(intCont).Item("TOTAL")
                                            'If bolMismaUnidad Then
                                            dblTotalCant = dblTotalCant + objLista(lintIndice).Item(3) 'oDrDet(intCont).Item("QATNAN").ToString.Trim
                                            'End If
                                            intNumItems += 1
                                            intContador += 1
                                            'oListaTemp.Add(lintIndice)
                                        End If
                                    End If
                                Next
                                If odrPropio(0).Item("SRPTRM").ToString.Trim = "P" Then
                                    dblCenCos = odrPropio(0).Item("CCNCST").ToString.Trim
                                    lstrCGRNGD = "9"
                                Else
                                    dblCenCos = odrPropio(0).Item("CCNCS1").ToString.Trim
                                    lstrCGRNGD = "10"
                                End If
                                intDetalle = intDetalle + 1
                                oDr = oDt.NewRow
                                oDr("CCMPN") = odrPropio(0).Item("CCMPN").ToString.Trim
                                oDr("CTPODC") = dblTipoDoc
                                oDr("NDCCTC") = intNumFactura 'Numero del documento
                                oDr("NINDRN") = "0"
                                oDr("NCRDCC") = intDetalle
                                oDr("CRBCTC") = odrPropio(0).Item("CSRVC").ToString.Trim
                                oDr("STCCTC") = "" 'Flag tipo control
                                If bolMismaUnidad Then
                                    oDr("CUNCNA") = odrPropio(0).Item("CUNDSR").ToString.Trim
                                    oDr("QAPCTC") = dblTotalCant 'oDrDet(0).Item("QCNESP").ToString.Trim
                                    oDr("ITRCTC") = dblTarifaAnt 'Format(dblTotalMonto / dblTotalCant, "###,###,###,###,###.00000") 'dblTotalCant
                                Else
                                    oDr("CUNCNA") = objLista(0).Item(4) '"UNI"
                                    oDr("QAPCTC") = dblTotalCant '"1"
                                    oDr("ITRCTC") = dblTarifaAnt 'Format(dblTotalMonto / dblTotalCant, "###,###,###,###,###.00000") 'dblTotalMonto
                                End If
                                oDr("CUTCTC") = odrPropio(0).Item("TSGNMN").ToString.Trim
                                dblTotalMonto = Format(dblTotalMonto, "###,###,###,###,###.00")
                                If odrPropio(0).Item("TSGNMN").ToString.Trim = "SOL" Then
                                    oDr("IVLDCS") = dblTotalMonto
                                    oDr("IVLDCD") = Format(dblTotalMonto / dblTipoCambio, "###,###,###,###,###.00")
                                Else
                                    oDr("IVLDCS") = Format(dblTotalMonto * dblTipoCambio, "###,###,###,###,###.00")
                                    oDr("IVLDCD") = dblTotalMonto
                                End If
                                oDr("NCTDCC") = intNumFactura
                                oDr("FDCCTC") = oDtCabecera.Rows(intNumFactura - 1).Item("FDCCTC").ToString.Trim
                                oDr("CDVSN") = odrPropio(0).Item("CDVSN").ToString.Trim
                                oDr("CGRNGD") = lstrCGRNGD 'oDtCabecera.Rows(intNumFactura - 1).Item("CGRONG").ToString.Trim
                                oDr("CCNCSD") = dblCenCos
                                oDt.Rows.Add(oDr)
                                objLista.RemoveRange(0, intContador)
                            End While

                            objLista = New List(Of Hashtable)
                            For lint As Int32 = 0 To odrTercero.Length - 1
                                objHas = New Hashtable
                                objHas.Add(1, odrTercero(lint).ItemArray(8)) 'oDrDet(lint).Item("NRTFSV"))
                                objHas.Add(2, odrTercero(lint).ItemArray(9)) 'oDrDet(lint).Item("TOTAL"))
                                objHas.Add(3, odrTercero(lint).ItemArray(5)) 'oDrDet(lint).Item("QATNAN"))
                                objHas.Add(4, odrTercero(lint).ItemArray(7))
                                objLista.Add(objHas)
                            Next
                            lintIndice = 0
                            While (1)
                                'oListaTemp = New List(Of Int32)
                                dblTotalMonto = 0
                                dblTotalCant = 0
                                intContador = 0
                                If objLista.Count < 1 Then
                                    Exit While
                                End If
                                For lintIndice = 0 To objLista.Count - 1
                                    If lintIndice = 0 Then
                                        dblTarifaAnt = objLista(lintIndice).Item(1) 'oDrDet(intCont).Item("NRTFSV")
                                        dblTotalMonto = dblTotalMonto + objLista(lintIndice).Item(2) 'oDrDet(intCont).Item("TOTAL")
                                        'If bolMismaUnidad Then
                                        dblTotalCant = dblTotalCant + objLista(lintIndice).Item(3) 'oDrDet(intCont).Item("QATNAN").ToString.Trim
                                        'End If
                                        intNumItems += 1
                                        intContador += 1
                                        'oListaTemp.Add(lintIndice)
                                    Else
                                        If dblTarifaAnt = objLista(lintIndice).Item(1) Then 'oDrDet(intCont).Item("NRTFSV") Then
                                            dblTotalMonto = dblTotalMonto + objLista(lintIndice).Item(2) 'oDrDet(intCont).Item("TOTAL")
                                            'If bolMismaUnidad Then
                                            dblTotalCant = dblTotalCant + objLista(lintIndice).Item(3) 'oDrDet(intCont).Item("QATNAN").ToString.Trim
                                            'End If
                                            intNumItems += 1
                                            intContador += 1
                                            'oListaTemp.Add(lintIndice)
                                        End If
                                    End If
                                Next
                                If odrTercero(0).Item("SRPTRM").ToString.Trim = "P" Then
                                    dblCenCos = odrTercero(0).Item("CCNCST").ToString.Trim
                                    lstrCGRNGD = "9"
                                Else
                                    dblCenCos = odrTercero(0).Item("CCNCS1").ToString.Trim
                                    lstrCGRNGD = "10"
                                End If
                                intDetalle = intDetalle + 1
                                oDr = oDt.NewRow
                                oDr("CCMPN") = odrTercero(0).Item("CCMPN").ToString.Trim
                                oDr("CTPODC") = dblTipoDoc
                                oDr("NDCCTC") = intNumFactura 'Numero del documento
                                oDr("NINDRN") = "0"
                                oDr("NCRDCC") = intDetalle
                                oDr("CRBCTC") = odrTercero(0).Item("CSRVC").ToString.Trim
                                oDr("STCCTC") = "" 'Flag tipo control
                                If bolMismaUnidad Then
                                    oDr("CUNCNA") = odrTercero(0).Item("CUNDSR").ToString.Trim
                                    oDr("QAPCTC") = dblTotalCant 'oDrDet(0).Item("QCNESP").ToString.Trim
                                    oDr("ITRCTC") = dblTarifaAnt 'Format(dblTotalMonto / dblTotalCant, "###,###,###,###,###.00000") 'dblTotalCant
                                Else
                                    oDr("CUNCNA") = objLista(0).Item(4) '"UNI"
                                    oDr("QAPCTC") = dblTotalCant '"1"
                                    oDr("ITRCTC") = dblTarifaAnt 'Format(dblTotalMonto / dblTotalCant, "###,###,###,###,###.00000") 'dblTotalMonto
                                End If
                                oDr("CUTCTC") = odrTercero(0).Item("TSGNMN").ToString.Trim
                                dblTotalMonto = Format(dblTotalMonto, "###,###,###,###,###.00")
                                If odrTercero(0).Item("TSGNMN").ToString.Trim = "SOL" Then
                                    oDr("IVLDCS") = dblTotalMonto
                                    oDr("IVLDCD") = Format(dblTotalMonto / dblTipoCambio, "###,###,###,###,###.00")
                                Else
                                    oDr("IVLDCS") = Format(dblTotalMonto * dblTipoCambio, "###,###,###,###,###.00")
                                    oDr("IVLDCD") = dblTotalMonto
                                End If
                                oDr("NCTDCC") = intNumFactura
                                oDr("FDCCTC") = oDtCabecera.Rows(intNumFactura - 1).Item("FDCCTC").ToString.Trim
                                oDr("CDVSN") = odrTercero(0).Item("CDVSN").ToString.Trim
                                oDr("CGRNGD") = lstrCGRNGD 'oDtCabecera.Rows(intNumFactura - 1).Item("CGRONG").ToString.Trim
                                oDr("CCNCSD") = dblCenCos
                                oDt.Rows.Add(oDr)
                                objLista.RemoveRange(0, intContador)
                            End While

                        End If
                        objRegistroItemFactura.Add(intDetalle)

                        If oTipoDocumento = 1 Then
                            Quitar_Detalles_Utilizados(oDtFactura, CodServicio) 'Eliminar los registros utilizados de oDtFactura
                        End If
                    End While

                    If dblPorIgv > 0 Then
                        Agregar_Detalle_IGV(oDt, intNumFactura, dblPorIgv)
                    End If
                    Actualizar_Montos_Cabecera(oDt, intNumFactura, dblPorIgv)
                End While

            Else
                '-----------------------------------------------------------------------------------------------------
                '-----------------------------------------------------------------------------------------------------

                While (1) 'Se repite por la cantidad de Factura
                    intNumFactura = intNumFactura + 1
                    If intNumFactura > pobjFiltro("CANTFACT") Then
                        Exit While
                    End If
                    If oTipoDocumento = 1 Then
                        oDtFactura = Detalle_Factura(oDtServicios)
                    Else
                        oDtFactura = oDtServicios
                    End If
                    dblCenCosMax = oDtFactura.Rows(0).Item("CCNCST").ToString.Trim
                    oDtCabecera.Rows(intNumFactura - 1).Item("CCNCSC") = dblCenCosMax
                    intTotalItems = oDtFactura.Rows.Count
                    'If intTotalItems > 15 Then intNroMaxItem = intTotalItems
                    intNumItems = 0
                    intDetalle = 0
                    dblPorIgv = oDtFactura.Rows(0).Item("PIGVA").ToString.Trim
                    'strIGV = dblPorIgv.ToString
                    strIGV.Add(intNumFactura, dblPorIgv.ToString)
                    While (1) 'Se repite por la cantidad de Detalles de la Factura
                        dblTotalMonto = 0
                        dblTotalCant = 0
                        If intNumItems > intTotalItems - 1 Then
                            Exit While
                        End If
                        If oTipoDocumento = 1 Then
                            CodServicio = oDtFactura.Rows(0).Item("CSRVC").ToString.Trim
                        Else
                            CodServicio = oDtFactura.Rows(intNumItems).Item("CSRVC").ToString.Trim
                        End If
                        oDrDet = oDtFactura.Select("CSRVC = " & CodServicio)
                        Validar_Detalles(oDrDet, bolMismoCCosto, bolMismaUnidad) 'Indica si tiene mismo centro o misma unidad
                        If bolMismoCCosto Then
                            For lint As Int32 = 0 To oDrDet.Length - 1
                                dblTotalMonto = dblTotalMonto + oDrDet(lint).ItemArray(9)
                                dblTotalCant = dblTotalCant + oDrDet(lint).ItemArray(5)
                                intNumItems += 1
                            Next
                            lintIndice = 0
                            If oDrDet(0).Item("SRPTRM").ToString.Trim = "P" Then
                                dblCenCos = oDrDet(0).Item("CCNCST").ToString.Trim
                                lstrCGRNGD = "9"
                            Else
                                dblCenCos = oDrDet(0).Item("CCNCS1").ToString.Trim
                                lstrCGRNGD = "10"
                            End If
                            intDetalle = intDetalle + 1
                            oDr = oDt.NewRow
                            oDr("CCMPN") = oDrDet(0).Item("CCMPN").ToString.Trim
                            oDr("CTPODC") = dblTipoDoc
                            oDr("NDCCTC") = intNumFactura 'Numero del documento
                            oDr("NINDRN") = "0"
                            oDr("NCRDCC") = intDetalle
                            oDr("CRBCTC") = oDrDet(0).Item("CSRVC").ToString.Trim
                            oDr("STCCTC") = "" 'Flag tipo control
                            dblTotalMonto = Format(dblTotalMonto, "###,###,###,###,###.00")
                            'If bolMismaUnidad Then
                            '  oDr("CUNCNA") = oDrDet(0).Item("CUNDSR").ToString.Trim
                            '  oDr("QAPCTC") = dblTotalCant 'oDrDet(0).Item("QCNESP").ToString.Trim
                            '  oDr("ITRCTC") = Format(dblTotalMonto / dblTotalCant, "###,###,###,###,###.00000") 'dblTotalCant
                            'Else
                            oDr("CUNCNA") = "UNI"
                            oDr("QAPCTC") = "1"
                            oDr("ITRCTC") = Format(dblTotalMonto, "###,###,###,###,###.00000") 'dblTotalMonto
                            'End If
                            oDr("CUTCTC") = oDrDet(0).Item("TSGNMN").ToString.Trim
                            If oDrDet(0).Item("TSGNMN").ToString.Trim = "SOL" Then
                                oDr("IVLDCS") = dblTotalMonto
                                oDr("IVLDCD") = Format(dblTotalMonto / dblTipoCambio, "###,###,###,###,###.00")
                            Else
                                oDr("IVLDCS") = Format(dblTotalMonto * dblTipoCambio, "###,###,###,###,###.00")
                                oDr("IVLDCD") = dblTotalMonto
                            End If
                            oDr("NCTDCC") = intNumFactura
                            oDr("FDCCTC") = oDtCabecera.Rows(intNumFactura - 1).Item("FDCCTC").ToString.Trim
                            oDr("CDVSN") = oDrDet(0).Item("CDVSN").ToString.Trim
                            oDr("CGRNGD") = lstrCGRNGD 'oDtCabecera.Rows(intNumFactura - 1).Item("CGRONG").ToString.Trim
                            oDr("CCNCSD") = dblCenCos
                            oDt.Rows.Add(oDr)
                        Else
                            '-----------------------------------------------------------------------------------------------
                            bolMismaUnidad = True
                            Dim odrPropio() As DataRow = oDtFactura.Select("CSRVC = " & CodServicio & " And SRPTRM = 'P'")
                            Dim odrTercero() As DataRow = oDtFactura.Select("CSRVC = " & CodServicio & " And SRPTRM <> 'P'")
                            For lintContador As Int16 = 0 To 1
                                objGrid = New Object
                                dblTotalMonto = 0
                                dblTotalCant = 0
                                If lintContador = 0 Then
                                    For lint As Int32 = 0 To odrPropio.Length - 1
                                        dblTotalMonto = dblTotalMonto + odrPropio(lint).ItemArray(9)
                                        dblTotalCant = dblTotalCant + odrPropio(lint).ItemArray(5)
                                        intNumItems += 1
                                    Next
                                    objGrid = odrPropio
                                Else
                                    For lint As Int32 = 0 To odrTercero.Length - 1
                                        dblTotalMonto = dblTotalMonto + odrTercero(lint).ItemArray(9)
                                        dblTotalCant = dblTotalCant + odrTercero(lint).ItemArray(5)
                                        intNumItems += 1
                                    Next
                                    objGrid = odrTercero
                                End If
                                lintIndice = 0
                                If objGrid(0).Item("SRPTRM").ToString.Trim = "P" Then
                                    dblCenCos = objGrid(0).Item("CCNCST").ToString.Trim
                                    lstrCGRNGD = "9"
                                Else
                                    dblCenCos = objGrid(0).Item("CCNCS1").ToString.Trim
                                    lstrCGRNGD = "10"
                                End If
                                intDetalle = intDetalle + 1
                                oDr = oDt.NewRow
                                oDr("CCMPN") = objGrid(0).Item("CCMPN").ToString.Trim
                                oDr("CTPODC") = dblTipoDoc
                                oDr("NDCCTC") = intNumFactura 'Numero del documento
                                oDr("NINDRN") = "0"
                                oDr("NCRDCC") = intDetalle
                                oDr("CRBCTC") = objGrid(0).Item("CSRVC").ToString.Trim
                                oDr("STCCTC") = "" 'Flag tipo control
                                dblTotalMonto = Format(dblTotalMonto, "###,###,###,###,###.00")
                                'If bolMismaUnidad Then
                                '  oDr("CUNCNA") = objGrid(0).Item("CUNDSR").ToString.Trim
                                '  oDr("QAPCTC") = dblTotalCant 'oDrDet(0).Item("QCNESP").ToString.Trim
                                '  oDr("ITRCTC") = Format(dblTotalMonto / dblTotalCant, "###,###,###,###,###.00000") 'dblTotalCant
                                'Else
                                oDr("CUNCNA") = "UNI"
                                oDr("QAPCTC") = "1"
                                oDr("ITRCTC") = Format(dblTotalMonto, "###,###,###,###,###.00000") 'dblTotalMonto
                                'End If
                                oDr("CUTCTC") = objGrid(0).Item("TSGNMN").ToString.Trim
                                If odrPropio(0).Item("TSGNMN").ToString.Trim = "SOL" Then
                                    oDr("IVLDCS") = dblTotalMonto
                                    oDr("IVLDCD") = Format(dblTotalMonto / dblTipoCambio, "###,###,###,###,###.00")
                                Else
                                    oDr("IVLDCS") = Format(dblTotalMonto * dblTipoCambio, "###,###,###,###,###.00")
                                    oDr("IVLDCD") = dblTotalMonto
                                End If
                                oDr("NCTDCC") = intNumFactura
                                oDr("FDCCTC") = oDtCabecera.Rows(intNumFactura - 1).Item("FDCCTC").ToString.Trim
                                oDr("CDVSN") = objGrid(0).Item("CDVSN").ToString.Trim
                                oDr("CGRNGD") = lstrCGRNGD 'oDtCabecera.Rows(intNumFactura - 1).Item("CGRONG").ToString.Trim
                                oDr("CCNCSD") = dblCenCos
                                oDt.Rows.Add(oDr)
                            Next
                        End If
                        objRegistroItemFactura.Add(intDetalle)
                        If oTipoDocumento = 1 Then
                            Quitar_Detalles_Utilizados(oDtFactura, CodServicio) 'Eliminar los registros utilizados de oDtFactura
                        End If
                    End While
                    If dblPorIgv > 0 Then
                        Agregar_Detalle_IGV(oDt, intNumFactura, dblPorIgv)
                    End If
                    Actualizar_Montos_Cabecera(oDt, intNumFactura, dblPorIgv)
                End While
            End If
            Return oDt
        End Function

        Public Function Lista_Detalle_ReFacturas_Notas2(ByVal pobjFiltro As Hashtable, ByRef strIGV As Hashtable) As DataTable
            Dim oDt As New DataTable
            Dim oDtFactura As DataTable
            Dim oDtServicios As DataTable
            Dim intNumFactura As Integer = 0
            Dim drServicioSelect As DataRow() = Nothing
            Dim dblCenCosMax As Double
            Dim intDetalle As Integer
            Dim dblPorIgv As Double
            Dim CodServicio As Integer
            Dim ImporteServicio As Double
            Dim oDrDet() As DataRow
            Dim oDtFactura_Detalle As DataTable
            Dim bolMismaUnidad As Boolean = True
            Dim bolMismaTarifa As Boolean = True
            Dim bolMismoCCosto As Boolean = True
            Dim IsPreLiq As Boolean = pobjFiltro("PSSTATUS")
            Crear_Estructura_Detalle_ReFactura(oDt)
            oDtServicios = objDataAccessLayer.Lista_Detalle_Servicios_Notas(pobjFiltro)

            While (1) 'Se repite por la cantidad de Factura
                intNumFactura = intNumFactura + 1
                If intNumFactura > pobjFiltro("CANTFACT") Then
                    Exit While
                End If

                If oTipoDocumento = 3 Or oTipoDocumento = 2 Then
                    oDtFactura = Detalle_Factura(oDtServicios)
                Else
                    oDtFactura = oDtServicios
                End If

                If oDtFactura.Rows(0).Item("SRPTRM").ToString.Trim = "P" Then
                    dblCenCosMax = oDtFactura.Rows(0).Item("CCNCST").ToString.Trim
                Else
                    dblCenCosMax = oDtFactura.Rows(0).Item("CCNCS1").ToString.Trim
                End If

                'End If
                oDtCabecera.Rows(intNumFactura - 1).Item("CCNCSC") = dblCenCosMax
                dblPorIgv = oDtFactura.Rows(0).Item("PIGVA").ToString.Trim
                strIGV.Add(intNumFactura, dblPorIgv.ToString)
                intDetalle = 0

                'Incrementa por la cantidad de Items de la Factura
                For item As Integer = 0 To oDtFactura.Rows.Count - 1

                    CodServicio = oDtFactura.Rows(item).Item("CSRVC") 'filtraServicio(oDtServicios, oDtFactura.Rows(item)).Item("CSRVC").ToString.Trim
                    ImporteServicio = oDtFactura.Rows(item).Item("ISRVGU")
                    'PRELIQUIDACION
                    '*************************************************
                    'Ordenado por Codigo y tarifa
                    Dim count As Integer
                    oDrDet = Nothing
                    If IsPreLiq Then
                        oDrDet = oDtFactura.Select("CRBCTC='" & CodServicio & "'")
                    Else
                        oDrDet = oDtFactura.Select("CSRVC='" & CodServicio & "' AND Convert(ISRVGU, 'System.Decimal')  ='" & Decimal.Parse(ImporteServicio).ToString & "'")
                    End If
                    count = oDrDet.Length
                    oDtFactura_Detalle = Nothing
                    oDtFactura_Detalle = RowToDatatable(oDrDet, oDtFactura)
                    'Indica si tiene mismo centro o misma unidad
                    Validar_Detalles(oDrDet, bolMismoCCosto, bolMismaUnidad)

                    If bolMismoCCosto Then
                        ConstruyeDetalle(oDtFactura_Detalle, intDetalle, bolMismaUnidad, oDt, _
                        dblTipoDoc, intNumFactura, ImporteServicio, dblTipoCambio, IsPreLiq)
                    Else
                        bolMismaUnidad = True
                        oDrDet = Nothing
                        'Unidades Propias
                        oDrDet = oDtFactura_Detalle.Select("SRPTRM = 'P'")
                        ConstruyeDetalle(RowToDatatable(oDrDet, oDtFactura).Copy, _
                        intDetalle, bolMismaUnidad, oDt, dblTipoDoc, intNumFactura, _
                        ImporteServicio, dblTipoCambio, IsPreLiq)
                        oDrDet = Nothing
                        'Unidades Terceras
                        oDrDet = oDtFactura_Detalle.Select("SRPTRM <> 'P'")
                        ConstruyeDetalle(RowToDatatable(oDrDet, oDtFactura).Copy, _
                        intDetalle, bolMismaUnidad, oDt, dblTipoDoc, intNumFactura, _
                        ImporteServicio, dblTipoCambio, IsPreLiq)
                    End If

                    objRegistroItemFactura.Add(intDetalle)

                    If (oTipoDocumento = 3 Or oTipoDocumento = 2) AndAlso oDrDet.Length > 0 Then
                        'Incrementa el detalle de la Factura
                        item = item + count - 1
                    End If
                Next
                'Incrementa la Factura
                If dblPorIgv > 0 Then
                    Agregar_Detalle_IGV(oDt, intNumFactura, dblPorIgv)
                End If
                Actualizar_Montos_Cabecera(oDt, intNumFactura, dblPorIgv)
            End While
            Return oDt
        End Function

        Public Function Lista_Detalle_ReFacturas_Notas(ByVal pobjFiltro As Hashtable, ByRef strIGV As Hashtable, Optional ByVal lstrConsistencia As List(Of ConsistenciaOperacion) = Nothing, Optional ByVal TNC As String = "") As DataTable
            Dim oDt As New DataTable
            Dim oDtServicios As DataTable
            Dim oDtFactura As DataTable
            Dim intDetalle As Integer
            Dim intNumFactura As Integer = 0
            Dim dblCenCos, dblCenCosMax As Double
            Dim dblTotalCant As Double
            Dim dblTotalMonto As Double
            Dim bolMismaUnidad As Boolean = True
            Dim bolMismaTarifa As Boolean = True
            Dim bolMismoCCosto As Boolean = True
            Dim dblTarifaAnt As Double = 0
            Dim oDr As DataRow
            Dim oDrDet() As DataRow
            Dim CodServicio As String
            Dim intTotalItems, intNumItems, intContador As Integer
            'Dim oDrItemCenCos() As DataRow
            Dim dblPorIgv As Double

            Dim objHas As Hashtable
            Dim objLista As List(Of Hashtable)
            Dim lintIndice As Int32
            Dim objGrid As Object
            Dim lstrCGRNGD As String = ""
            Dim ImporteNC As Double = 0
            Dim dblImporteFacturado As Double = 0

            Crear_Estructura_Detalle_ReFactura(oDt)
            oDtServicios = objDataAccessLayer.Lista_Detalle_Servicios_Notas(pobjFiltro) 'ordenado por servicio y importe de servicio de guia

            If pobjFiltro("PSSTATUS") = 0 Then

                While (1) 'Se repite por la cantidad de Factura
                    intNumFactura = intNumFactura + 1
                    If intNumFactura > pobjFiltro("CANTFACT") Then
                        Exit While
                    End If
                    If oTipoDocumento = 3 Or oTipoDocumento = 2 Then
                        oDtFactura = Detalle_Factura(oDtServicios)
                    Else
                        oDtFactura = oDtServicios
                    End If
                    If oDtFactura.Rows(0).Item("SRPTRM").ToString.Trim = "P" Then
                        dblCenCosMax = oDtFactura.Rows(0).Item("CCNCST").ToString.Trim
                    Else
                        dblCenCosMax = oDtFactura.Rows(0).Item("CCNCS1").ToString.Trim
                    End If
                    oDtCabecera.Rows(intNumFactura - 1).Item("CCNCSC") = dblCenCosMax

                    intTotalItems = oDtFactura.Rows.Count

                    'If intTotalItems > 15 Then intNroMaxItem = intTotalItems
                    intNumItems = 0
                    intDetalle = 0
                    dblPorIgv = oDtFactura.Rows(0).Item("PIGVA").ToString.Trim
                    'strIGV = dblPorIgv.ToString
                    strIGV.Add(intNumFactura, dblPorIgv.ToString)
                    While (1) 'Se repite por la cantidad de Detalles de la Factura

                        If intNumItems > intTotalItems - 1 Then 'numero de items
                            Exit While
                        End If
                        If oTipoDocumento = 3 Or oTipoDocumento = 2 Then
                            CodServicio = oDtFactura.Rows(0).Item("CSRVC").ToString.Trim 'servicios
                        Else
                            CodServicio = oDtFactura.Rows(intNumItems).Item("CSRVC").ToString.Trim
                        End If
                        oDrDet = oDtFactura.Select("CSRVC = " & CodServicio)
                        Validar_Detalles(oDrDet, bolMismoCCosto, bolMismaUnidad) 'Indica si tiene mismo centro o misma unidad
                        If bolMismoCCosto Then 'Es el mismo centro de costo o el mismo tipo de unidades
                            objLista = New List(Of Hashtable)

                            For lint As Int32 = 0 To oDrDet.Length - 1
                                objHas = New Hashtable
                                objHas.Add(1, oDrDet(lint).ItemArray(8))
                                objHas.Add(2, oDrDet(lint).ItemArray(9))
                                objHas.Add(3, oDrDet(lint).ItemArray(5))
                                objHas.Add(4, oDrDet(lint).ItemArray(7))
                                objLista.Add(objHas)
                            Next
                            lintIndice = 0

                            While (1)
                                'oListaTemp = New List(Of Int32)
                                dblTotalMonto = 0
                                dblTotalCant = 0
                                intContador = 0
                                If objLista.Count <= 0 Then
                                    Exit While
                                End If
                                For lintIndice = 0 To objLista.Count - 1
                                    If lintIndice = 0 Then
                                        dblTarifaAnt = objLista(lintIndice).Item(1) 'oDrDet(intCont).Item("NRTFSV")
                                        dblTotalMonto = dblTotalMonto + objLista(lintIndice).Item(2) 'oDrDet(intCont).Item("TOTAL")
                                        'If bolMismaUnidad Then
                                        dblTotalCant = dblTotalCant + objLista(lintIndice).Item(3) 'oDrDet(intCont).Item("QATNAN").ToString.Trim
                                        'End If
                                        intNumItems += 1
                                        intContador += 1
                                        'oListaTemp.Add(lintIndice)
                                    Else
                                        If dblTarifaAnt = objLista(lintIndice).Item(1) Then 'oDrDet(intCont).Item("NRTFSV") Then
                                            dblTotalMonto = dblTotalMonto + objLista(lintIndice).Item(2) 'oDrDet(intCont).Item("TOTAL")
                                            'If bolMismaUnidad Then
                                            dblTotalCant = dblTotalCant + objLista(lintIndice).Item(3) 'oDrDet(intCont).Item("QATNAN").ToString.Trim
                                            'End If
                                            intNumItems += 1
                                            intContador += 1
                                            'oListaTemp.Add(lintIndice)
                                        End If
                                    End If
                                Next
                                If oDrDet(0).Item("SRPTRM").ToString.Trim = "P" Then
                                    dblCenCos = oDrDet(0).Item("CCNCST").ToString.Trim
                                    lstrCGRNGD = "9"
                                Else
                                    dblCenCos = oDrDet(0).Item("CCNCS1").ToString.Trim
                                    lstrCGRNGD = "10"
                                End If
                                intDetalle = intDetalle + 1
                                oDr = oDt.NewRow
                                oDr("CCMPN") = oDrDet(0).Item("CCMPN").ToString.Trim
                                oDr("CTPODC") = dblTipoDoc
                                oDr("NDCCTC") = intNumFactura 'Numero del documento
                                oDr("NINDRN") = "0"
                                oDr("NCRDCC") = intDetalle
                                oDr("CRBCTC") = oDrDet(0).Item("CSRVC").ToString.Trim
                                oDr("STCCTC") = "" 'Flag tipo control

                                If bolMismaUnidad Then
                                    oDr("CUNCNA") = oDrDet(0).Item("CUNDSR").ToString.Trim
                                    oDr("QAPCTC") = dblTotalCant 'oDrDet(0).Item("QCNESP").ToString.Trim
                                    oDr("ITRCTC") = dblTarifaAnt 'Format(dblTotalMonto / dblTotalCant, "###,###,###,###,###.00000") 'dblTotalCant
                                Else
                                    oDr("CUNCNA") = objLista(0).Item(4) '"UNI"
                                    oDr("QAPCTC") = dblTotalCant '"1"
                                    oDr("ITRCTC") = dblTarifaAnt 'Format(dblTotalMonto / dblTotalCant, "###,###,###,###,###.00000") 'dblTotalMonto
                                End If
                                oDr("CUTCTC") = oDrDet(0).Item("TSGNMN").ToString.Trim
                                dblTotalMonto = Format(dblTotalMonto, "###,###,###,###,###.00")
                                If oDrDet(0).Item("TSGNMN").ToString.Trim = "SOL" Then
                                    oDr("IVLDCS") = dblTotalMonto
                                    oDr("IVLDCD") = Format(dblTotalMonto / dblTipoCambio, "###,###,###,###,###.00")
                                Else
                                    oDr("IVLDCS") = Format(dblTotalMonto * dblTipoCambio, "###,###,###,###,###.00")
                                    oDr("IVLDCD") = dblTotalMonto
                                End If
                                oDr("NCTDCC") = intNumFactura
                                oDr("FDCCTC") = oDtCabecera.Rows(intNumFactura - 1).Item("FDCCTC").ToString.Trim
                                oDr("CDVSN") = oDrDet(0).Item("CDVSN").ToString.Trim
                                oDr("CGRNGD") = lstrCGRNGD 'oDtCabecera.Rows(intNumFactura - 1).Item("CGRONG").ToString.Trim
                                oDr("CCNCSD") = dblCenCos
                                oDt.Rows.Add(oDr)
                                objLista.RemoveRange(0, intContador)
                            End While
                        Else
                            bolMismaUnidad = True
                            Dim odrPropio() As DataRow = oDtFactura.Select("CSRVC = " & CodServicio & " And SRPTRM = 'P'")
                            Dim odrTercero() As DataRow = oDtFactura.Select("CSRVC = " & CodServicio & " And SRPTRM <> 'P'")
                            'oDrItemCenCos = Lista_Items_Igual_CCosto(bolMismaUnidad, oDrDet) 'Devuelve los items que tienen el mismo centro de costo y elimina estos registros de oDrDet

                            objLista = New List(Of Hashtable)
                            For lint As Int32 = 0 To odrPropio.Length - 1
                                objHas = New Hashtable
                                objHas.Add(1, odrPropio(lint).ItemArray(8))
                                objHas.Add(2, odrPropio(lint).ItemArray(9))
                                objHas.Add(3, odrPropio(lint).ItemArray(5))
                                objHas.Add(4, odrPropio(lint).ItemArray(7))
                                objLista.Add(objHas)
                            Next
                            lintIndice = 0
                            While (1)
                                'oListaTemp = New List(Of Int32)

                                dblTotalMonto = 0
                                dblTotalCant = 0
                                intContador = 0
                                If objLista.Count < 1 Then
                                    Exit While
                                End If
                                For lintIndice = 0 To objLista.Count - 1
                                    If lintIndice = 0 Then
                                        dblTarifaAnt = objLista(lintIndice).Item(1) 'oDrDet(intCont).Item("NRTFSV")
                                        dblTotalMonto = dblTotalMonto + objLista(lintIndice).Item(2) 'oDrDet(intCont).Item("TOTAL")
                                        'If bolMismaUnidad Then
                                        dblTotalCant = dblTotalCant + objLista(lintIndice).Item(3) 'oDrDet(intCont).Item("QATNAN").ToString.Trim
                                        'End If
                                        intNumItems += 1
                                        intContador += 1
                                        'oListaTemp.Add(lintIndice)
                                    Else
                                        If dblTarifaAnt = objLista(lintIndice).Item(1) Then 'oDrDet(intCont).Item("NRTFSV") Then
                                            dblTotalMonto = dblTotalMonto + objLista(lintIndice).Item(2) 'oDrDet(intCont).Item("TOTAL")
                                            'If bolMismaUnidad Then
                                            dblTotalCant = dblTotalCant + objLista(lintIndice).Item(3) 'oDrDet(intCont).Item("QATNAN").ToString.Trim
                                            'End If
                                            intNumItems += 1
                                            intContador += 1
                                            'oListaTemp.Add(lintIndice)
                                        End If
                                    End If
                                Next
                                If odrPropio(0).Item("SRPTRM").ToString.Trim = "P" Then
                                    dblCenCos = odrPropio(0).Item("CCNCST").ToString.Trim
                                    lstrCGRNGD = "9"
                                Else
                                    dblCenCos = odrPropio(0).Item("CCNCS1").ToString.Trim
                                    lstrCGRNGD = "10"
                                End If
                                intDetalle = intDetalle + 1
                                oDr = oDt.NewRow

                                oDr("CCMPN") = odrPropio(0).Item("CCMPN").ToString.Trim
                                oDr("CTPODC") = dblTipoDoc
                                oDr("NDCCTC") = intNumFactura 'Numero del documento
                                oDr("NINDRN") = "0"
                                oDr("NCRDCC") = intDetalle
                                oDr("CRBCTC") = odrPropio(0).Item("CSRVC").ToString.Trim
                                oDr("STCCTC") = "" 'Flag tipo control

                                If bolMismaUnidad Then
                                    oDr("CUNCNA") = odrPropio(0).Item("CUNDSR").ToString.Trim
                                    oDr("QAPCTC") = dblTotalCant 'oDrDet(0).Item("QCNESP").ToString.Trim
                                    oDr("ITRCTC") = dblTarifaAnt 'Format(dblTotalMonto / dblTotalCant, "###,###,###,###,###.00000") 'dblTotalCant
                                Else
                                    oDr("CUNCNA") = objLista(0).Item(4) '"UNI"
                                    oDr("QAPCTC") = dblTotalCant '"1"
                                    oDr("ITRCTC") = dblTarifaAnt 'Format(dblTotalMonto / dblTotalCant, "###,###,###,###,###.00000") 'dblTotalMonto
                                End If
                                oDr("CUTCTC") = odrPropio(0).Item("TSGNMN").ToString.Trim
                                dblTotalMonto = Format(dblTotalMonto, "###,###,###,###,###.00")
                                If odrPropio(0).Item("TSGNMN").ToString.Trim = "SOL" Then
                                    oDr("IVLDCS") = dblTotalMonto
                                    oDr("IVLDCD") = Format(dblTotalMonto / dblTipoCambio, "###,###,###,###,###.00")
                                Else
                                    oDr("IVLDCS") = Format(dblTotalMonto * dblTipoCambio, "###,###,###,###,###.00")
                                    oDr("IVLDCD") = dblTotalMonto
                                End If
                                oDr("NCTDCC") = intNumFactura
                                oDr("FDCCTC") = oDtCabecera.Rows(intNumFactura - 1).Item("FDCCTC").ToString.Trim
                                oDr("CDVSN") = odrPropio(0).Item("CDVSN").ToString.Trim
                                oDr("CGRNGD") = lstrCGRNGD 'oDtCabecera.Rows(intNumFactura - 1).Item("CGRONG").ToString.Trim
                                oDr("CCNCSD") = dblCenCos
                                oDt.Rows.Add(oDr)
                                objLista.RemoveRange(0, intContador)
                            End While

                            objLista = New List(Of Hashtable)
                            For lint As Int32 = 0 To odrTercero.Length - 1
                                objHas = New Hashtable
                                objHas.Add(1, odrTercero(lint).ItemArray(8)) 'oDrDet(lint).Item("NRTFSV"))
                                objHas.Add(2, odrTercero(lint).ItemArray(9)) 'oDrDet(lint).Item("TOTAL"))
                                objHas.Add(3, odrTercero(lint).ItemArray(5)) 'oDrDet(lint).Item("QATNAN"))
                                objHas.Add(4, odrTercero(lint).ItemArray(7))
                                objLista.Add(objHas)
                            Next
                            lintIndice = 0

                            While (1)
                                'oListaTemp = New List(Of Int32)
                                dblTotalMonto = 0
                                dblTotalCant = 0
                                intContador = 0

                                If objLista.Count < 1 Then
                                    Exit While
                                End If
                                For lintIndice = 0 To objLista.Count - 1
                                    If lintIndice = 0 Then
                                        dblTarifaAnt = objLista(lintIndice).Item(1) 'oDrDet(intCont).Item("NRTFSV")
                                        dblTotalMonto = dblTotalMonto + objLista(lintIndice).Item(2) 'oDrDet(intCont).Item("TOTAL")
                                        'If bolMismaUnidad Then
                                        dblTotalCant = dblTotalCant + objLista(lintIndice).Item(3) 'oDrDet(intCont).Item("QATNAN").ToString.Trim
                                        'End If
                                        intNumItems += 1
                                        intContador += 1
                                        'oListaTemp.Add(lintIndice)
                                    Else
                                        If dblTarifaAnt = objLista(lintIndice).Item(1) Then 'oDrDet(intCont).Item("NRTFSV") Then
                                            dblTotalMonto = dblTotalMonto + objLista(lintIndice).Item(2) 'oDrDet(intCont).Item("TOTAL")
                                            'If bolMismaUnidad Then
                                            dblTotalCant = dblTotalCant + objLista(lintIndice).Item(3) 'oDrDet(intCont).Item("QATNAN").ToString.Trim
                                            'End If
                                            intNumItems += 1
                                            intContador += 1
                                            'oListaTemp.Add(lintIndice)
                                        End If
                                    End If
                                Next
                                If odrTercero(0).Item("SRPTRM").ToString.Trim = "P" Then
                                    dblCenCos = odrTercero(0).Item("CCNCST").ToString.Trim
                                    lstrCGRNGD = "9"
                                Else
                                    dblCenCos = odrTercero(0).Item("CCNCS1").ToString.Trim
                                    lstrCGRNGD = "10"
                                End If
                                intDetalle = intDetalle + 1
                                oDr = oDt.NewRow
                                oDr("CCMPN") = odrTercero(0).Item("CCMPN").ToString.Trim
                                oDr("CTPODC") = dblTipoDoc
                                oDr("NDCCTC") = intNumFactura 'Numero del documento
                                oDr("NINDRN") = "0"
                                oDr("NCRDCC") = intDetalle
                                oDr("CRBCTC") = odrTercero(0).Item("CSRVC").ToString.Trim
                                oDr("STCCTC") = "" 'Flag tipo control

                                If bolMismaUnidad Then
                                    oDr("CUNCNA") = odrTercero(0).Item("CUNDSR").ToString.Trim
                                    oDr("QAPCTC") = dblTotalCant 'oDrDet(0).Item("QCNESP").ToString.Trim
                                    oDr("ITRCTC") = dblTarifaAnt 'Format(dblTotalMonto / dblTotalCant, "###,###,###,###,###.00000") 'dblTotalCant
                                Else
                                    oDr("CUNCNA") = objLista(0).Item(4) '"UNI"
                                    oDr("QAPCTC") = dblTotalCant '"1"
                                    oDr("ITRCTC") = dblTarifaAnt 'Format(dblTotalMonto / dblTotalCant, "###,###,###,###,###.00000") 'dblTotalMonto
                                End If
                                oDr("CUTCTC") = odrTercero(0).Item("TSGNMN").ToString.Trim
                                dblTotalMonto = Format(dblTotalMonto, "###,###,###,###,###.00")
                                If odrTercero(0).Item("TSGNMN").ToString.Trim = "SOL" Then
                                    oDr("IVLDCS") = dblTotalMonto
                                    oDr("IVLDCD") = Format(dblTotalMonto / dblTipoCambio, "###,###,###,###,###.00")
                                Else
                                    oDr("IVLDCS") = Format(dblTotalMonto * dblTipoCambio, "###,###,###,###,###.00")
                                    oDr("IVLDCD") = dblTotalMonto
                                End If
                                oDr("NCTDCC") = intNumFactura
                                oDr("FDCCTC") = oDtCabecera.Rows(intNumFactura - 1).Item("FDCCTC").ToString.Trim
                                oDr("CDVSN") = odrTercero(0).Item("CDVSN").ToString.Trim
                                oDr("CGRNGD") = lstrCGRNGD 'oDtCabecera.Rows(intNumFactura - 1).Item("CGRONG").ToString.Trim
                                oDr("CCNCSD") = dblCenCos

                                oDt.Rows.Add(oDr)
                                objLista.RemoveRange(0, intContador)

                            End While

                        End If
                        objRegistroItemFactura.Add(intDetalle)

                        If oTipoDocumento = 3 Or oTipoDocumento = 2 Then
                            Quitar_Detalles_Utilizados(oDtFactura, CodServicio) 'Eliminar los registros utilizados de oDtFactura
                        End If
                    End While

                    If dblPorIgv > 0 Then
                        Agregar_Detalle_IGV(oDt, intNumFactura, dblPorIgv)
                    End If
                    Actualizar_Montos_Cabecera(oDt, intNumFactura, dblPorIgv)
                End While

            Else
                '-----------------------------------------------------------------------------------------------------
                '-----------------------------------------------------------------------------------------------------

                While (1) 'Se repite por la cantidad de Factura
                    intNumFactura = intNumFactura + 1
                    If intNumFactura > pobjFiltro("CANTFACT") Then
                        Exit While
                    End If
                    If oTipoDocumento = 3 Or oTipoDocumento = 2 Then
                        oDtFactura = Detalle_Factura(oDtServicios)
                    Else
                        oDtFactura = oDtServicios
                    End If
                    dblCenCosMax = oDtFactura.Rows(0).Item("CCNCST").ToString.Trim
                    oDtCabecera.Rows(intNumFactura - 1).Item("CCNCSC") = dblCenCosMax
                    intTotalItems = oDtFactura.Rows.Count
                    'If intTotalItems > 15 Then intNroMaxItem = intTotalItems
                    intNumItems = 0
                    intDetalle = 0
                    dblPorIgv = oDtFactura.Rows(0).Item("PIGVA").ToString.Trim
                    'strIGV = dblPorIgv.ToString
                    strIGV.Add(intNumFactura, dblPorIgv.ToString)
                    While (1) 'Se repite por la cantidad de Detalles de la Factura
                        dblTotalMonto = 0
                        dblTotalCant = 0
                        If intNumItems > intTotalItems - 1 Then
                            Exit While
                        End If
                        If oTipoDocumento = 3 Or oTipoDocumento = 2 Then
                            CodServicio = oDtFactura.Rows(0).Item("CSRVC").ToString.Trim
                        Else
                            CodServicio = oDtFactura.Rows(intNumItems).Item("CSRVC").ToString.Trim
                        End If
                        oDrDet = oDtFactura.Select("CSRVC = " & CodServicio)
                        Validar_Detalles(oDrDet, bolMismoCCosto, bolMismaUnidad) 'Indica si tiene mismo centro o misma unidad
                        If bolMismoCCosto Then
                            For lint As Int32 = 0 To oDrDet.Length - 1
                                dblTotalMonto = dblTotalMonto + oDrDet(lint).ItemArray(9)
                                dblTotalCant = dblTotalCant + oDrDet(lint).ItemArray(5)
                                intNumItems += 1
                            Next
                            lintIndice = 0
                            If oDrDet(0).Item("SRPTRM").ToString.Trim = "P" Then
                                dblCenCos = oDrDet(0).Item("CCNCST").ToString.Trim
                                lstrCGRNGD = "9"
                            Else
                                dblCenCos = oDrDet(0).Item("CCNCS1").ToString.Trim
                                lstrCGRNGD = "10"
                            End If
                            intDetalle = intDetalle + 1
                            oDr = oDt.NewRow
                            oDr("CCMPN") = oDrDet(0).Item("CCMPN").ToString.Trim
                            oDr("CTPODC") = dblTipoDoc
                            oDr("NDCCTC") = intNumFactura 'Numero del documento
                            oDr("NINDRN") = oDrDet(0).Item("NOPRCN").ToString.Trim '"0"
                            oDr("NCRDCC") = intDetalle
                            oDr("CRBCTC") = oDrDet(0).Item("CSRVC").ToString.Trim
                            oDr("STCCTC") = "" 'Flag tipo control
                            dblTotalMonto = Format(dblTotalMonto, "###,###,###,###,###.00")
                            'If bolMismaUnidad Then
                            '  oDr("CUNCNA") = oDrDet(0).Item("CUNDSR").ToString.Trim
                            '  oDr("QAPCTC") = dblTotalCant 'oDrDet(0).Item("QCNESP").ToString.Trim
                            '  oDr("ITRCTC") = Format(dblTotalMonto / dblTotalCant, "###,###,###,###,###.00000") 'dblTotalCant
                            'Else
                            oDr("CUNCNA") = "UNI"
                            oDr("QAPCTC") = "1"
                            oDr("ITRCTC") = Format(dblTotalMonto, "###,###,###,###,###.00000") 'dblTotalMonto
                            'End If
                            oDr("CUTCTC") = oDrDet(0).Item("TSGNMN").ToString.Trim
                            If oDrDet(0).Item("TSGNMN").ToString.Trim = "SOL" Then
                                oDr("IVLDCS") = dblTotalMonto
                                oDr("IVLDCD") = Format(dblTotalMonto / dblTipoCambio, "###,###,###,###,###.00")
                            Else
                                oDr("IVLDCS") = Format(dblTotalMonto * dblTipoCambio, "###,###,###,###,###.00")
                                oDr("IVLDCD") = dblTotalMonto
                            End If
                            oDr("NCTDCC") = intNumFactura
                            oDr("FDCCTC") = oDtCabecera.Rows(intNumFactura - 1).Item("FDCCTC").ToString.Trim
                            oDr("CDVSN") = oDrDet(0).Item("CDVSN").ToString.Trim
                            oDr("CGRNGD") = lstrCGRNGD 'oDtCabecera.Rows(intNumFactura - 1).Item("CGRONG").ToString.Trim
                            oDr("CCNCSD") = dblCenCos
                            oDt.Rows.Add(oDr)

                        Else
                            '-----------------------------------------------------------------------------------------------
                            bolMismaUnidad = True
                            Dim odrPropio() As DataRow = oDtFactura.Select("CSRVC = " & CodServicio & " And SRPTRM = 'P'")
                            Dim odrTercero() As DataRow = oDtFactura.Select("CSRVC = " & CodServicio & " And SRPTRM <> 'P'")
                            For lintContador As Int16 = 0 To 1
                                objGrid = New Object
                                dblTotalMonto = 0
                                dblTotalCant = 0
                                If lintContador = 0 Then
                                    For lint As Int32 = 0 To odrPropio.Length - 1
                                        dblTotalMonto = dblTotalMonto + odrPropio(lint).ItemArray(9)
                                        dblTotalCant = dblTotalCant + odrPropio(lint).ItemArray(5)
                                        intNumItems += 1
                                    Next
                                    objGrid = odrPropio
                                Else
                                    For lint As Int32 = 0 To odrTercero.Length - 1
                                        dblTotalMonto = dblTotalMonto + odrTercero(lint).ItemArray(9)
                                        dblTotalCant = dblTotalCant + odrTercero(lint).ItemArray(5)
                                        intNumItems += 1
                                    Next
                                    objGrid = odrTercero
                                End If
                                lintIndice = 0
                                If objGrid(0).Item("SRPTRM").ToString.Trim = "P" Then
                                    dblCenCos = objGrid(0).Item("CCNCST").ToString.Trim
                                    lstrCGRNGD = "9"
                                Else
                                    dblCenCos = objGrid(0).Item("CCNCS1").ToString.Trim
                                    lstrCGRNGD = "10"
                                End If
                                intDetalle = intDetalle + 1
                                oDr = oDt.NewRow
                                oDr("CCMPN") = objGrid(0).Item("CCMPN").ToString.Trim
                                oDr("CTPODC") = dblTipoDoc
                                oDr("NDCCTC") = intNumFactura 'Numero del documento
                                oDr("NINDRN") = objGrid(0).Item("NOPRCN").ToString.Trim '"0"
                                oDr("NCRDCC") = intDetalle
                                oDr("CRBCTC") = objGrid(0).Item("CSRVC").ToString.Trim
                                oDr("STCCTC") = "" 'Flag tipo control
                                dblTotalMonto = Format(dblTotalMonto, "###,###,###,###,###.00")
                                'If bolMismaUnidad Then
                                '  oDr("CUNCNA") = objGrid(0).Item("CUNDSR").ToString.Trim
                                '  oDr("QAPCTC") = dblTotalCant 'oDrDet(0).Item("QCNESP").ToString.Trim
                                '  oDr("ITRCTC") = Format(dblTotalMonto / dblTotalCant, "###,###,###,###,###.00000") 'dblTotalCant
                                'Else
                                oDr("CUNCNA") = "UNI"
                                oDr("QAPCTC") = "1"
                                oDr("ITRCTC") = Format(dblTotalMonto, "###,###,###,###,###.00000") 'dblTotalMonto
                                'End If
                                oDr("CUTCTC") = objGrid(0).Item("TSGNMN").ToString.Trim
                                If odrPropio(0).Item("TSGNMN").ToString.Trim = "SOL" Then
                                    oDr("IVLDCS") = dblTotalMonto
                                    oDr("IVLDCD") = Format(dblTotalMonto / dblTipoCambio, "###,###,###,###,###.00")
                                Else
                                    oDr("IVLDCS") = Format(dblTotalMonto * dblTipoCambio, "###,###,###,###,###.00")
                                    oDr("IVLDCD") = dblTotalMonto
                                End If
                                oDr("NCTDCC") = intNumFactura
                                oDr("FDCCTC") = oDtCabecera.Rows(intNumFactura - 1).Item("FDCCTC").ToString.Trim
                                oDr("CDVSN") = objGrid(0).Item("CDVSN").ToString.Trim
                                oDr("CGRNGD") = lstrCGRNGD 'oDtCabecera.Rows(intNumFactura - 1).Item("CGRONG").ToString.Trim
                                oDr("CCNCSD") = dblCenCos

                                oDt.Rows.Add(oDr)
                            Next
                        End If
                        objRegistroItemFactura.Add(intDetalle)
                        If oTipoDocumento = 3 Or oTipoDocumento = 2 Then
                            Quitar_Detalles_Utilizados(oDtFactura, CodServicio) 'Eliminar los registros utilizados de oDtFactura
                        End If
                    End While
                    If dblPorIgv > 0 Then
                        Agregar_Detalle_IGV(oDt, intNumFactura, dblPorIgv)
                    End If
                    Actualizar_Montos_Cabecera(oDt, intNumFactura, dblPorIgv)
                End While
            End If
            Return oDt
        End Function

        Public Function Lista_Detalle_Factura_Lote(ByVal pobjFiltro As Hashtable, ByRef strIGV As Hashtable) As DataTable
            Dim drServicioSelect As DataRow() = Nothing
            Dim drServicioSelect_Fact As DataRow() = Nothing
            Dim oDt As New DataTable
            Dim oDtServicios As DataTable
            Dim oDtFactura_Detalle As DataTable
            Dim oDtFactura As DataTable
            Dim intDetalle As Integer
            Dim intNumFactura As Integer = 0
            Dim dblCenCosMax As Double
            Dim bolMismaUnidad As Boolean = True
            Dim bolMismaTarifa As Boolean = True
            Dim bolMismoCCosto As Boolean = True
            Dim oDrDet() As DataRow
            Dim CodServicio As Integer
            Dim ImporteServicio As Double
            Dim dblPorIgv As Double
            Dim lstrCGRNGD As String = ""
            Dim IsPreLiq As Boolean = pobjFiltro("PSSTATUS")

            Crear_Estructura_Detalle(oDt)
            oDtServicios = oDsServicioLote.Tables(0).Copy
            '*********************************************************************************************
            'FACTURACION DE OPERACIONES
            ''If pobjFiltro("PSSTATUS") = 0 Then
            'Para el caso en que el documento sea Factura
            'El el caso de la boleta falta implementar, se debe de hacer otra lógica quitando las facturaciones 
            'por detraccion en al momento de contar las facturas
            'Se repite Para todas las Facturas
            For row As Integer = 0 To oDtServicioActualizar.Rows.Count - 1
                intNumFactura = intNumFactura + 1
                drServicioSelect = oDtServicioActualizar.Select("NDCCTC = '" + intNumFactura.ToString + "'")
                oDtFactura = Nothing
                oDtFactura = RowToDatatable(drServicioSelect, oDtServicioActualizar)
                Dim dvSort As New DataView(oDtFactura)
                dvSort.Sort = "CRBCTC ASC , IMPORTE DESC"
                oDtFactura = dvSort.ToTable()

                'If oTipoDocumento <> 1 Then
                '    oDtFactura = oDtServicios
                'End If

                'PRELIQUIDACION
                '*************************************************
                If IsPreLiq Then
                    dblCenCosMax = oDtServicioActualizar.Rows(row).Item("CCNCST").ToString.Trim
                Else
                    If oDtServicioActualizar.Rows(row).Item("SRPTRM").ToString.Trim = "P" Then
                        dblCenCosMax = oDtServicioActualizar.Rows(row).Item("CCNCST").ToString.Trim
                    Else
                        dblCenCosMax = oDtServicioActualizar.Rows(row).Item("CCNCS1").ToString.Trim
                    End If
                End If
                oDtCabecera.Rows(intNumFactura - 1).Item("CCNCSC") = dblCenCosMax
                dblPorIgv = oDtServicioActualizar.Rows(row).Item("PIGVA").ToString.Trim
                strIGV.Add(intNumFactura, dblPorIgv.ToString)
                intDetalle = 0
                If drServicioSelect.Length > 0 Then
                    'Incrementa por la cantidad de Items de la Factura
                    For item As Integer = 0 To oDtFactura.Rows.Count - 1
                        CodServicio = oDtFactura.Rows(item).Item("CRBCTC") 'filtraServicio(oDtServicios, oDtFactura.Rows(item)).Item("CSRVC").ToString.Trim
                        ImporteServicio = oDtFactura.Rows(item).Item("IMPORTE")
                        'PRELIQUIDACION
                        '*************************************************
                        'Ordenado por Codigo y tarifa
                        Dim count As Integer
                        oDrDet = Nothing
                        If IsPreLiq Then
                            oDrDet = oDtFactura.Select("CRBCTC='" & CodServicio & "'")
                        Else
                            oDrDet = oDtFactura.Select("CRBCTC='" & CodServicio & "' AND Convert(IMPORTE, 'System.Decimal')  ='" & Decimal.Parse(ImporteServicio).ToString & "'")
                        End If

                        count = oDrDet.Length
                        oDtFactura_Detalle = Nothing
                        oDtFactura_Detalle = RowToDatatable(oDrDet, oDtFactura)
                        'Indica si tiene mismo centro o misma unidad
                        Validar_Detalles_lote(oDrDet, bolMismoCCosto, bolMismaUnidad)
                        'Es el mismo centro de costo o el mismo tipo de unidades
                        If bolMismoCCosto Then
                            ConstruyeDetalle(oDtFactura_Detalle, intDetalle, bolMismaUnidad, oDt, _
                            dblTipoDoc, intNumFactura, ImporteServicio, dblTipoCambio, IsPreLiq)
                        Else
                            bolMismaUnidad = True
                            oDrDet = Nothing
                            'Unidades Propias

                            oDrDet = oDtFactura_Detalle.Select("SRPTRM = 'P'")
                            ConstruyeDetalle(RowToDatatable(oDrDet, oDtFactura).Copy, _
                            intDetalle, bolMismaUnidad, oDt, dblTipoDoc, intNumFactura, ImporteServicio, dblTipoCambio, IsPreLiq)
                            oDrDet = Nothing
                            'Unidades Terceras
                            oDrDet = oDtFactura_Detalle.Select("SRPTRM <> 'P'")
                            ConstruyeDetalle(RowToDatatable(oDrDet, oDtFactura).Copy, _
                            intDetalle, bolMismaUnidad, oDt, dblTipoDoc, intNumFactura, ImporteServicio, dblTipoCambio, IsPreLiq)
                        End If
                        objRegistroItemFactura.Add(intDetalle)
                        If oTipoDocumento = 1 AndAlso oDrDet.Length > 0 Then
                            'Incrementa el detalle de la Factura
                            item = item + count - 1
                        End If
                    Next
                    'Incrementa la Factura
                    If dblPorIgv > 0 Then
                        Agregar_Detalle_IGV(oDt, intNumFactura, dblPorIgv)
                    End If
                    Actualizar_Montos_Cabecera(oDt, intNumFactura, dblPorIgv)
                    row = row + drServicioSelect.Length - 1
                End If
            Next
            Return oDt
        End Function

        Private Sub ConstruyeDetalle(ByRef oDtFactura_Detalle As DataTable, ByRef intDetalle As Integer, ByRef bolMismaUnidad As Boolean, _
                                    ByRef oDt As DataTable, ByRef dblTipoDoc As Double, _
                                    ByRef intNumFactura As Integer, ByRef ImporteServicio As Double, _
                                    ByRef dblTipoCambio As Double, IsPreLiq as Boolean )

            Dim lstrCGRNGD As String
            Dim oDr As DataRow
            Dim dblCenCos As Double
            Dim dblTotalCant As Double
            Dim dblTotalMonto As Double
            Dim oDrActual As DataRow
            Dim dvSortDetalle As New DataView(oDtFactura_Detalle)
            dvSortDetalle.Sort = "SRPTRM ASC,CCNCST ASC,CCNCS1 ASC"
            oDtFactura_Detalle = dvSortDetalle.ToTable()
            Dim oDrDetFactura() As DataRow

            For y As Integer = 0 To oDtFactura_Detalle.Rows.Count - 1
                oDr = Nothing
                oDrActual = oDtFactura_Detalle.Rows(y)
                If oDrActual.Item("SRPTRM").ToString.Trim = "P" Then
                    dblCenCos = oDrActual.Item("CCNCST").ToString.Trim
                    oDrDetFactura = oDtFactura_Detalle.Select("SRPTRM = '" + oDrActual.Item("SRPTRM").ToString + "' AND CCNCST = '" + oDrActual.Item("CCNCST").ToString + "'")
                    lstrCGRNGD = "9"
                Else
                    dblCenCos = oDrActual.Item("CCNCS1").ToString.Trim
                    oDrDetFactura = oDtFactura_Detalle.Select("SRPTRM = '" + oDrActual.Item("SRPTRM").ToString + "' AND CCNCS1 ='" + oDrActual.Item("CCNCS1").ToString + "'")
                    lstrCGRNGD = "10"
                End If

                If oDtFactura_Detalle.Columns.Item("QCNDTG") Is Nothing Then
                    dblTotalCant = RowToDatatable(oDrDetFactura, oDtFactura_Detalle).Compute("Sum(QATNAN)", "")
                Else
                    dblTotalCant = RowToDatatable(oDrDetFactura, oDtFactura_Detalle).Compute("Sum(QCNDTG)", "")
                End If

                dblTotalMonto = RowToDatatable(oDrDetFactura, oDtFactura_Detalle).Compute("Sum(TOTAL)", "")
                intDetalle = intDetalle + 1

                oDr = oDt.NewRow
                oDr("CCMPN") = oDrActual.Item("CCMPN").ToString.Trim
                oDr("CTPODC") = dblTipoDoc
                oDr("NDCCTC") = intNumFactura 'Numero del documento
                oDr("NINDRN") = "0"
                oDr("NCRDCC") = intDetalle

                If oDtFactura_Detalle.Columns.Item("CRBCTC") Is Nothing Then
                    oDr("CRBCTC") = oDrActual.Item("CSRVC").ToString.Trim
                Else
                    oDr("CRBCTC") = oDrActual.Item("CRBCTC").ToString.Trim
                End If
                oDr("STCCTC") = "" 'Flag tipo control
                'PRELIQUIDACION
                '*************************************************
                If IsPreLiq Then
                    oDr("CUNCNA") = "UNI"
                    oDr("QAPCTC") = "1"
                    oDr("ITRCTC") = Format(dblTotalMonto, "###,###,###,###,###.00000")
                Else
                    If bolMismaUnidad Then
                        oDr("CUNCNA") = oDrActual.Item("CUNDSR").ToString.Trim
                        oDr("QAPCTC") = dblTotalCant 'oDrDet(0).Item("QCNESP").ToString.Trim
                        oDr("ITRCTC") = ImporteServicio 'Format(dblTotalMonto / dblTotalCant, "###,###,###,###,###.00000") 'dblTotalCant
                    Else
                        oDr("CUNCNA") = oDrActual.Item("CUNDSR") '"UNI"
                        oDr("QAPCTC") = dblTotalCant '"1"
                        oDr("ITRCTC") = ImporteServicio 'Format(dblTotalMonto / dblTotalCant, "###,###,###,###,###.00000") 'dblTotalMonto
                        'ITRCTC es la tarifa del rubro(del servicio)
                    End If
                End If
                oDr("CUTCTC") = oDrActual.Item("TSGNMN").ToString.Trim
                dblTotalMonto = Format(dblTotalMonto, "###,###,###,###,###.00")
                If oDrActual.Item("TSGNMN").ToString.Trim = "SOL" Then
                    oDr("IVLDCS") = dblTotalMonto
                    oDr("IVLDCD") = Format(dblTotalMonto / dblTipoCambio, "###,###,###,###,###.00")
                Else
                    oDr("IVLDCS") = Format(dblTotalMonto * dblTipoCambio, "###,###,###,###,###.00")
                    oDr("IVLDCD") = dblTotalMonto
                End If
                oDr("NCTDCC") = intNumFactura
                oDr("FDCCTC") = oDtCabecera.Rows(intNumFactura - 1).Item("FDCCTC").ToString.Trim
                oDr("CDVSN") = oDrActual.Item("CDVSN").ToString.Trim
                oDr("CGRNGD") = lstrCGRNGD 'oDtCabecera.Rows(intNumFactura - 1).Item("CGRONG").ToString.Trim
                oDr("CCNCSD") = dblCenCos
                oDt.Rows.Add(oDr)
                y = y + oDrDetFactura.Length - 1
            Next
        End Sub

        Public Function Lista_Detalle_Factura2(ByVal pobjFiltro As Hashtable, ByRef strIGV As Hashtable) As DataTable
            Dim oDt As New DataTable
            Dim oDtFactura As DataTable
            Dim oDtServicios As DataTable
            Dim intNumFactura As Integer = 0
            Dim drServicioSelect As DataRow() = Nothing
            Dim dblCenCosMax As Double
            Dim intDetalle As Integer
            Dim dblPorIgv As Double
            Dim CodServicio As Integer
            'Dim ImporteServicio As Double
            Dim ImporteServicio As Decimal = 0
            Dim oDrDet() As DataRow
            Dim oDtFactura_Detalle As DataTable
            Dim bolMismaUnidad As Boolean = True
            Dim bolMismaTarifa As Boolean = True
            Dim bolMismoCCosto As Boolean = True
            Dim IsPreLiq As Boolean = pobjFiltro("PSSTATUS")


            oDtServicios = objDataAccessLayer.Lista_Detalle_Servicios(pobjFiltro)
            Crear_Estructura_Detalle(oDt)

            While (1) 'Se repite por la cantidad de Factura
                intNumFactura = intNumFactura + 1
                If intNumFactura > pobjFiltro("CANTFACT") Then
                    Exit While
                End If

                If oTipoDocumento = 1 Then
                    oDtFactura = Detalle_Factura(oDtServicios)
                Else
                    oDtFactura = oDtServicios
                End If

                If oDtFactura.Rows(0).Item("SRPTRM").ToString.Trim = "P" Then
                    dblCenCosMax = oDtFactura.Rows(0).Item("CCNCST").ToString.Trim
                Else
                    dblCenCosMax = oDtFactura.Rows(0).Item("CCNCS1").ToString.Trim
                End If

                'End If
                oDtCabecera.Rows(intNumFactura - 1).Item("CCNCSC") = dblCenCosMax
                dblPorIgv = oDtFactura.Rows(0).Item("PIGVA").ToString.Trim
                strIGV.Add(intNumFactura, dblPorIgv.ToString)
                intDetalle = 0

                'Incrementa por la cantidad de Items de la Factura
                For item As Integer = 0 To oDtFactura.Rows.Count - 1

                    CodServicio = oDtFactura.Rows(item).Item("CSRVC") 'filtraServicio(oDtServicios, oDtFactura.Rows(item)).Item("CSRVC").ToString.Trim
                    ImporteServicio = oDtFactura.Rows(item).Item("ISRVGU")
                    'PRELIQUIDACION
                    '*************************************************
                    'Ordenado por Codigo y tarifa
                    Dim count As Integer
                    oDrDet = Nothing
                    If IsPreLiq Then
                        oDrDet = oDtFactura.Select("CSRVC='" & CodServicio & "'")
                    Else
                        oDrDet = oDtFactura.Select("CSRVC='" & CodServicio & "' AND Convert(ISRVGU, 'System.Decimal')  ='" & Decimal.Parse(ImporteServicio).ToString & "'")
                    End If
                    count = oDrDet.Length
                    oDtFactura_Detalle = Nothing
                    oDtFactura_Detalle = RowToDatatable(oDrDet, oDtFactura)
                    'Indica si tiene mismo centro o misma unidad
                    Validar_Detalles(oDrDet, bolMismoCCosto, bolMismaUnidad)

                    If bolMismoCCosto Then
                        ConstruyeDetalle(oDtFactura_Detalle, intDetalle, bolMismaUnidad, oDt, _
                        dblTipoDoc, intNumFactura, ImporteServicio, dblTipoCambio, IsPreLiq)
                    Else
                        bolMismaUnidad = True
                        oDrDet = Nothing
                        'Unidades Propias
                        oDrDet = oDtFactura_Detalle.Select("SRPTRM = 'P'")
                        ConstruyeDetalle(RowToDatatable(oDrDet, oDtFactura).Copy, _
                        intDetalle, bolMismaUnidad, oDt, dblTipoDoc, intNumFactura, _
                        ImporteServicio, dblTipoCambio, IsPreLiq)
                        oDrDet = Nothing
                        'Unidades Terceras
                        oDrDet = oDtFactura_Detalle.Select("SRPTRM <> 'P'")
                        ConstruyeDetalle(RowToDatatable(oDrDet, oDtFactura).Copy, _
                        intDetalle, bolMismaUnidad, oDt, dblTipoDoc, intNumFactura, _
                        ImporteServicio, dblTipoCambio, IsPreLiq)
                    End If

                    objRegistroItemFactura.Add(intDetalle)
                    If oTipoDocumento = 1 AndAlso oDrDet.Length > 0 Then
                        'Incrementa el detalle de la Factura
                        item = item + count - 1
                    End If
                Next
                'Incrementa la Factura
                If dblPorIgv > 0 Then
                    Agregar_Detalle_IGV(oDt, intNumFactura, dblPorIgv)
                End If
                Actualizar_Montos_Cabecera(oDt, intNumFactura, dblPorIgv)

            End While
            Return oDt
        End Function

        Public Function Lista_Detalle_Factura(ByVal pobjFiltro As Hashtable, ByRef strIGV As Hashtable) As DataTable
            Dim oDt As New DataTable
            Dim oDtServicios As DataTable
            Dim oDtFactura As DataTable
            Dim intDetalle As Integer
            Dim intNumFactura As Integer = 0
            Dim dblCenCos, dblCenCosMax As Double
            Dim dblTotalCant As Double
            Dim dblTotalMonto As Double
            Dim bolMismaUnidad As Boolean = True
            Dim bolMismaTarifa As Boolean = True
            Dim bolMismoCCosto As Boolean = True
            Dim dblTarifaAnt As Double = 0
            Dim oDr As DataRow
            Dim oDrDet() As DataRow
            Dim CodServicio As String
            Dim intTotalItems, intNumItems, intContador As Integer
            'Dim oDrItemCenCos() As DataRow
            Dim dblPorIgv As Double

            Dim objHas As Hashtable
            Dim objLista As List(Of Hashtable)
            Dim lintIndice As Int32
            Dim objGrid As Object
            Dim lstrCGRNGD As String = ""

            Crear_Estructura_Detalle(oDt)
            oDtServicios = objDataAccessLayer.Lista_Detalle_Servicios(pobjFiltro)

            If pobjFiltro("PSSTATUS") = 0 Then

                While (1) 'Se repite por la cantidad de Factura
                    intNumFactura = intNumFactura + 1
                    If intNumFactura > pobjFiltro("CANTFACT") Then
                        Exit While
                    End If
                    If oTipoDocumento = 1 Then
                        oDtFactura = Detalle_Factura(oDtServicios)
                    Else
                        oDtFactura = oDtServicios
                    End If
                    If oDtFactura.Rows(0).Item("SRPTRM").ToString.Trim = "P" Then
                        dblCenCosMax = oDtFactura.Rows(0).Item("CCNCST").ToString.Trim
                    Else
                        dblCenCosMax = oDtFactura.Rows(0).Item("CCNCS1").ToString.Trim
                    End If
                    oDtCabecera.Rows(intNumFactura - 1).Item("CCNCSC") = dblCenCosMax
                    intTotalItems = oDtFactura.Rows.Count
                    'If intTotalItems > 15 Then intNroMaxItem = intTotalItems
                    intNumItems = 0
                    intDetalle = 0
                    dblPorIgv = oDtFactura.Rows(0).Item("PIGVA").ToString.Trim
                    'strIGV = dblPorIgv.ToString
                    strIGV.Add(intNumFactura, dblPorIgv.ToString)
                    While (1) 'Se repite por la cantidad de Detalles de la Factura
                        If intNumItems > intTotalItems - 1 Then
                            Exit While
                        End If
                        If oTipoDocumento = 1 Then
                            CodServicio = oDtFactura.Rows(0).Item("CSRVC").ToString.Trim
                        Else
                            CodServicio = oDtFactura.Rows(intNumItems).Item("CSRVC").ToString.Trim
                        End If
                        oDrDet = oDtFactura.Select("CSRVC = " & CodServicio)
                        Validar_Detalles(oDrDet, bolMismoCCosto, bolMismaUnidad) 'Indica si tiene mismo centro o misma unidad
                        If bolMismoCCosto Then 'Es el mismo centro de costo o el mismo tipo de unidades
                            objLista = New List(Of Hashtable)

                            For lint As Int32 = 0 To oDrDet.Length - 1
                                objHas = New Hashtable
                                objHas.Add(1, oDrDet(lint).ItemArray(8))
                                objHas.Add(2, oDrDet(lint).ItemArray(9))
                                objHas.Add(3, oDrDet(lint).ItemArray(5))
                                objHas.Add(4, oDrDet(lint).ItemArray(7))
                                objLista.Add(objHas)
                            Next
                            lintIndice = 0
                            While (1)
                                'oListaTemp = New List(Of Int32)
                                dblTotalMonto = 0
                                dblTotalCant = 0
                                intContador = 0
                                If objLista.Count <= 0 Then
                                    Exit While
                                End If
                                For lintIndice = 0 To objLista.Count - 1
                                    If lintIndice = 0 Then
                                        dblTarifaAnt = objLista(lintIndice).Item(1) 'oDrDet(intCont).Item("NRTFSV")
                                        dblTotalMonto = dblTotalMonto + objLista(lintIndice).Item(2) 'oDrDet(intCont).Item("TOTAL")
                                        'If bolMismaUnidad Then
                                        dblTotalCant = dblTotalCant + objLista(lintIndice).Item(3) 'oDrDet(intCont).Item("QATNAN").ToString.Trim
                                        'End If
                                        intNumItems += 1
                                        intContador += 1
                                        'oListaTemp.Add(lintIndice)
                                    Else
                                        If dblTarifaAnt = objLista(lintIndice).Item(1) Then 'oDrDet(intCont).Item("NRTFSV") Then
                                            dblTotalMonto = dblTotalMonto + objLista(lintIndice).Item(2) 'oDrDet(intCont).Item("TOTAL")
                                            'If bolMismaUnidad Then
                                            dblTotalCant = dblTotalCant + objLista(lintIndice).Item(3) 'oDrDet(intCont).Item("QATNAN").ToString.Trim
                                            'End If
                                            intNumItems += 1
                                            intContador += 1
                                            'oListaTemp.Add(lintIndice)
                                        End If
                                    End If
                                Next
                                If oDrDet(0).Item("SRPTRM").ToString.Trim = "P" Then
                                    dblCenCos = oDrDet(0).Item("CCNCST").ToString.Trim
                                    lstrCGRNGD = "9"
                                Else
                                    dblCenCos = oDrDet(0).Item("CCNCS1").ToString.Trim
                                    lstrCGRNGD = "10"
                                End If
                                intDetalle = intDetalle + 1
                                oDr = oDt.NewRow
                                oDr("CCMPN") = oDrDet(0).Item("CCMPN").ToString.Trim
                                oDr("CTPODC") = dblTipoDoc
                                oDr("NDCCTC") = intNumFactura 'Numero del documento
                                oDr("NINDRN") = "0"
                                oDr("NCRDCC") = intDetalle
                                oDr("CRBCTC") = oDrDet(0).Item("CSRVC").ToString.Trim
                                oDr("STCCTC") = "" 'Flag tipo control
                                If bolMismaUnidad Then
                                    oDr("CUNCNA") = oDrDet(0).Item("CUNDSR").ToString.Trim
                                    oDr("QAPCTC") = dblTotalCant 'oDrDet(0).Item("QCNESP").ToString.Trim
                                    oDr("ITRCTC") = dblTarifaAnt 'Format(dblTotalMonto / dblTotalCant, "###,###,###,###,###.00000") 'dblTotalCant
                                Else
                                    oDr("CUNCNA") = objLista(0).Item(4) '"UNI"
                                    oDr("QAPCTC") = dblTotalCant '"1"
                                    oDr("ITRCTC") = dblTarifaAnt 'Format(dblTotalMonto / dblTotalCant, "###,###,###,###,###.00000") 'dblTotalMonto
                                End If
                                oDr("CUTCTC") = oDrDet(0).Item("TSGNMN").ToString.Trim
                                dblTotalMonto = Format(dblTotalMonto, "###,###,###,###,###.00")
                                If oDrDet(0).Item("TSGNMN").ToString.Trim = "SOL" Then
                                    oDr("IVLDCS") = dblTotalMonto
                                    oDr("IVLDCD") = Format(dblTotalMonto / dblTipoCambio, "###,###,###,###,###.00")
                                Else
                                    oDr("IVLDCS") = Format(dblTotalMonto * dblTipoCambio, "###,###,###,###,###.00")
                                    oDr("IVLDCD") = dblTotalMonto
                                End If
                                oDr("NCTDCC") = intNumFactura
                                oDr("FDCCTC") = oDtCabecera.Rows(intNumFactura - 1).Item("FDCCTC").ToString.Trim
                                oDr("CDVSN") = oDrDet(0).Item("CDVSN").ToString.Trim
                                oDr("CGRNGD") = lstrCGRNGD 'oDtCabecera.Rows(intNumFactura - 1).Item("CGRONG").ToString.Trim
                                oDr("CCNCSD") = dblCenCos
                                oDt.Rows.Add(oDr)
                                objLista.RemoveRange(0, intContador)
                            End While
                        Else
                            bolMismaUnidad = True
                            Dim odrPropio() As DataRow = oDtFactura.Select("CSRVC = " & CodServicio & " And SRPTRM = 'P'")
                            Dim odrTercero() As DataRow = oDtFactura.Select("CSRVC = " & CodServicio & " And SRPTRM <> 'P'")
                            'oDrItemCenCos = Lista_Items_Igual_CCosto(bolMismaUnidad, oDrDet) 'Devuelve los items que tienen el mismo centro de costo y elimina estos registros de oDrDet
                            objLista = New List(Of Hashtable)
                            For lint As Int32 = 0 To odrPropio.Length - 1
                                objHas = New Hashtable
                                objHas.Add(1, odrPropio(lint).ItemArray(8))
                                objHas.Add(2, odrPropio(lint).ItemArray(9))
                                objHas.Add(3, odrPropio(lint).ItemArray(5))
                                objHas.Add(4, odrPropio(lint).ItemArray(7))
                                objLista.Add(objHas)
                            Next
                            lintIndice = 0
                            While (1)
                                'oListaTemp = New List(Of Int32)
                                dblTotalMonto = 0
                                dblTotalCant = 0
                                intContador = 0
                                If objLista.Count < 1 Then
                                    Exit While
                                End If
                                For lintIndice = 0 To objLista.Count - 1
                                    If lintIndice = 0 Then
                                        dblTarifaAnt = objLista(lintIndice).Item(1) 'oDrDet(intCont).Item("NRTFSV")
                                        dblTotalMonto = dblTotalMonto + objLista(lintIndice).Item(2) 'oDrDet(intCont).Item("TOTAL")
                                        'If bolMismaUnidad Then
                                        dblTotalCant = dblTotalCant + objLista(lintIndice).Item(3) 'oDrDet(intCont).Item("QATNAN").ToString.Trim
                                        'End If
                                        intNumItems += 1
                                        intContador += 1
                                        'oListaTemp.Add(lintIndice)
                                    Else
                                        If dblTarifaAnt = objLista(lintIndice).Item(1) Then 'oDrDet(intCont).Item("NRTFSV") Then
                                            dblTotalMonto = dblTotalMonto + objLista(lintIndice).Item(2) 'oDrDet(intCont).Item("TOTAL")
                                            'If bolMismaUnidad Then
                                            dblTotalCant = dblTotalCant + objLista(lintIndice).Item(3) 'oDrDet(intCont).Item("QATNAN").ToString.Trim
                                            'End If
                                            intNumItems += 1
                                            intContador += 1
                                            'oListaTemp.Add(lintIndice)
                                        End If
                                    End If
                                Next
                                If odrPropio(0).Item("SRPTRM").ToString.Trim = "P" Then
                                    dblCenCos = odrPropio(0).Item("CCNCST").ToString.Trim
                                    lstrCGRNGD = "9"
                                Else
                                    dblCenCos = odrPropio(0).Item("CCNCS1").ToString.Trim
                                    lstrCGRNGD = "10"
                                End If
                                intDetalle = intDetalle + 1
                                oDr = oDt.NewRow
                                oDr("CCMPN") = odrPropio(0).Item("CCMPN").ToString.Trim
                                oDr("CTPODC") = dblTipoDoc
                                oDr("NDCCTC") = intNumFactura 'Numero del documento
                                oDr("NINDRN") = "0"
                                oDr("NCRDCC") = intDetalle
                                oDr("CRBCTC") = odrPropio(0).Item("CSRVC").ToString.Trim
                                oDr("STCCTC") = "" 'Flag tipo control
                                If bolMismaUnidad Then
                                    oDr("CUNCNA") = odrPropio(0).Item("CUNDSR").ToString.Trim
                                    oDr("QAPCTC") = dblTotalCant 'oDrDet(0).Item("QCNESP").ToString.Trim
                                    oDr("ITRCTC") = dblTarifaAnt 'Format(dblTotalMonto / dblTotalCant, "###,###,###,###,###.00000") 'dblTotalCant
                                Else
                                    oDr("CUNCNA") = objLista(0).Item(4) '"UNI"
                                    oDr("QAPCTC") = dblTotalCant '"1"
                                    oDr("ITRCTC") = dblTarifaAnt 'Format(dblTotalMonto / dblTotalCant, "###,###,###,###,###.00000") 'dblTotalMonto
                                End If
                                oDr("CUTCTC") = odrPropio(0).Item("TSGNMN").ToString.Trim
                                dblTotalMonto = Format(dblTotalMonto, "###,###,###,###,###.00")
                                If odrPropio(0).Item("TSGNMN").ToString.Trim = "SOL" Then
                                    oDr("IVLDCS") = dblTotalMonto
                                    oDr("IVLDCD") = Format(dblTotalMonto / dblTipoCambio, "###,###,###,###,###.00")
                                Else
                                    oDr("IVLDCS") = Format(dblTotalMonto * dblTipoCambio, "###,###,###,###,###.00")
                                    oDr("IVLDCD") = dblTotalMonto
                                End If
                                oDr("NCTDCC") = intNumFactura
                                oDr("FDCCTC") = oDtCabecera.Rows(intNumFactura - 1).Item("FDCCTC").ToString.Trim
                                oDr("CDVSN") = odrPropio(0).Item("CDVSN").ToString.Trim
                                oDr("CGRNGD") = lstrCGRNGD 'oDtCabecera.Rows(intNumFactura - 1).Item("CGRONG").ToString.Trim
                                oDr("CCNCSD") = dblCenCos
                                oDt.Rows.Add(oDr)
                                objLista.RemoveRange(0, intContador)
                            End While

                            objLista = New List(Of Hashtable)
                            For lint As Int32 = 0 To odrTercero.Length - 1
                                objHas = New Hashtable
                                objHas.Add(1, odrTercero(lint).ItemArray(8)) 'oDrDet(lint).Item("NRTFSV"))
                                objHas.Add(2, odrTercero(lint).ItemArray(9)) 'oDrDet(lint).Item("TOTAL"))
                                objHas.Add(3, odrTercero(lint).ItemArray(5)) 'oDrDet(lint).Item("QATNAN"))
                                objHas.Add(4, odrTercero(lint).ItemArray(7))
                                objLista.Add(objHas)
                            Next
                            lintIndice = 0
                            While (1)
                                'oListaTemp = New List(Of Int32)
                                dblTotalMonto = 0
                                dblTotalCant = 0
                                intContador = 0
                                If objLista.Count < 1 Then
                                    Exit While
                                End If
                                For lintIndice = 0 To objLista.Count - 1
                                    If lintIndice = 0 Then
                                        dblTarifaAnt = objLista(lintIndice).Item(1) 'oDrDet(intCont).Item("NRTFSV")
                                        dblTotalMonto = dblTotalMonto + objLista(lintIndice).Item(2) 'oDrDet(intCont).Item("TOTAL")
                                        'If bolMismaUnidad Then
                                        dblTotalCant = dblTotalCant + objLista(lintIndice).Item(3) 'oDrDet(intCont).Item("QATNAN").ToString.Trim
                                        'End If
                                        intNumItems += 1
                                        intContador += 1
                                        'oListaTemp.Add(lintIndice)
                                    Else
                                        If dblTarifaAnt = objLista(lintIndice).Item(1) Then 'oDrDet(intCont).Item("NRTFSV") Then
                                            dblTotalMonto = dblTotalMonto + objLista(lintIndice).Item(2) 'oDrDet(intCont).Item("TOTAL")
                                            'If bolMismaUnidad Then
                                            dblTotalCant = dblTotalCant + objLista(lintIndice).Item(3) 'oDrDet(intCont).Item("QATNAN").ToString.Trim
                                            'End If
                                            intNumItems += 1
                                            intContador += 1
                                            'oListaTemp.Add(lintIndice)
                                        End If
                                    End If
                                Next
                                If odrTercero(0).Item("SRPTRM").ToString.Trim = "P" Then
                                    dblCenCos = odrTercero(0).Item("CCNCST").ToString.Trim
                                    lstrCGRNGD = "9"
                                Else
                                    dblCenCos = odrTercero(0).Item("CCNCS1").ToString.Trim
                                    lstrCGRNGD = "10"
                                End If
                                intDetalle = intDetalle + 1
                                oDr = oDt.NewRow
                                oDr("CCMPN") = odrTercero(0).Item("CCMPN").ToString.Trim
                                oDr("CTPODC") = dblTipoDoc
                                oDr("NDCCTC") = intNumFactura 'Numero del documento
                                oDr("NINDRN") = "0"
                                oDr("NCRDCC") = intDetalle
                                oDr("CRBCTC") = odrTercero(0).Item("CSRVC").ToString.Trim
                                oDr("STCCTC") = "" 'Flag tipo control
                                If bolMismaUnidad Then
                                    oDr("CUNCNA") = odrTercero(0).Item("CUNDSR").ToString.Trim
                                    oDr("QAPCTC") = dblTotalCant 'oDrDet(0).Item("QCNESP").ToString.Trim
                                    oDr("ITRCTC") = dblTarifaAnt 'Format(dblTotalMonto / dblTotalCant, "###,###,###,###,###.00000") 'dblTotalCant
                                Else
                                    oDr("CUNCNA") = objLista(0).Item(4) '"UNI"
                                    oDr("QAPCTC") = dblTotalCant '"1"
                                    oDr("ITRCTC") = dblTarifaAnt 'Format(dblTotalMonto / dblTotalCant, "###,###,###,###,###.00000") 'dblTotalMonto
                                End If
                                oDr("CUTCTC") = odrTercero(0).Item("TSGNMN").ToString.Trim
                                dblTotalMonto = Format(dblTotalMonto, "###,###,###,###,###.00")
                                If odrTercero(0).Item("TSGNMN").ToString.Trim = "SOL" Then
                                    oDr("IVLDCS") = dblTotalMonto
                                    oDr("IVLDCD") = Format(dblTotalMonto / dblTipoCambio, "###,###,###,###,###.00")
                                Else
                                    oDr("IVLDCS") = Format(dblTotalMonto * dblTipoCambio, "###,###,###,###,###.00")
                                    oDr("IVLDCD") = dblTotalMonto
                                End If
                                oDr("NCTDCC") = intNumFactura
                                oDr("FDCCTC") = oDtCabecera.Rows(intNumFactura - 1).Item("FDCCTC").ToString.Trim
                                oDr("CDVSN") = odrTercero(0).Item("CDVSN").ToString.Trim
                                oDr("CGRNGD") = lstrCGRNGD 'oDtCabecera.Rows(intNumFactura - 1).Item("CGRONG").ToString.Trim
                                oDr("CCNCSD") = dblCenCos
                                oDt.Rows.Add(oDr)
                                objLista.RemoveRange(0, intContador)
                            End While

                        End If
                        objRegistroItemFactura.Add(intDetalle)

                        If oTipoDocumento = 1 Then
                            Quitar_Detalles_Utilizados(oDtFactura, CodServicio) 'Eliminar los registros utilizados de oDtFactura
                        End If
                    End While

                    If dblPorIgv > 0 Then
                        Agregar_Detalle_IGV(oDt, intNumFactura, dblPorIgv)
                    End If
                    Actualizar_Montos_Cabecera(oDt, intNumFactura, dblPorIgv)
                End While

            Else
                '-----------------------------------------------------------------------------------------------------
                '-----------------------------------------------------------------------------------------------------

                While (1) 'Se repite por la cantidad de Factura
                    intNumFactura = intNumFactura + 1
                    If intNumFactura > pobjFiltro("CANTFACT") Then
                        Exit While
                    End If
                    If oTipoDocumento = 1 Then
                        oDtFactura = Detalle_Factura(oDtServicios)
                    Else
                        oDtFactura = oDtServicios
                    End If
                    dblCenCosMax = oDtFactura.Rows(0).Item("CCNCST").ToString.Trim
                    oDtCabecera.Rows(intNumFactura - 1).Item("CCNCSC") = dblCenCosMax
                    intTotalItems = oDtFactura.Rows.Count
                    'If intTotalItems > 15 Then intNroMaxItem = intTotalItems
                    intNumItems = 0
                    intDetalle = 0
                    dblPorIgv = oDtFactura.Rows(0).Item("PIGVA").ToString.Trim
                    'strIGV = dblPorIgv.ToString
                    strIGV.Add(intNumFactura, dblPorIgv.ToString)
                    While (1) 'Se repite por la cantidad de Detalles de la Factura
                        dblTotalMonto = 0
                        dblTotalCant = 0
                        If intNumItems > intTotalItems - 1 Then
                            Exit While
                        End If
                        If oTipoDocumento = 1 Then
                            CodServicio = oDtFactura.Rows(0).Item("CSRVC").ToString.Trim
                        Else
                            CodServicio = oDtFactura.Rows(intNumItems).Item("CSRVC").ToString.Trim
                        End If
                        oDrDet = oDtFactura.Select("CSRVC = " & CodServicio)
                        Validar_Detalles(oDrDet, bolMismoCCosto, bolMismaUnidad) 'Indica si tiene mismo centro o misma unidad
                        If bolMismoCCosto Then
                            For lint As Int32 = 0 To oDrDet.Length - 1
                                dblTotalMonto = dblTotalMonto + oDrDet(lint).ItemArray(9)
                                dblTotalCant = dblTotalCant + oDrDet(lint).ItemArray(5)
                                intNumItems += 1
                            Next
                            lintIndice = 0
                            If oDrDet(0).Item("SRPTRM").ToString.Trim = "P" Then
                                dblCenCos = oDrDet(0).Item("CCNCST").ToString.Trim
                                lstrCGRNGD = "9"
                            Else
                                dblCenCos = oDrDet(0).Item("CCNCS1").ToString.Trim
                                lstrCGRNGD = "10"
                            End If
                            intDetalle = intDetalle + 1
                            oDr = oDt.NewRow
                            oDr("CCMPN") = oDrDet(0).Item("CCMPN").ToString.Trim
                            oDr("CTPODC") = dblTipoDoc
                            oDr("NDCCTC") = intNumFactura 'Numero del documento
                            oDr("NINDRN") = "0"
                            oDr("NCRDCC") = intDetalle
                            oDr("CRBCTC") = oDrDet(0).Item("CSRVC").ToString.Trim
                            oDr("STCCTC") = "" 'Flag tipo control
                            dblTotalMonto = Format(dblTotalMonto, "###,###,###,###,###.00")
                            'If bolMismaUnidad Then
                            '  oDr("CUNCNA") = oDrDet(0).Item("CUNDSR").ToString.Trim
                            '  oDr("QAPCTC") = dblTotalCant 'oDrDet(0).Item("QCNESP").ToString.Trim
                            '  oDr("ITRCTC") = Format(dblTotalMonto / dblTotalCant, "###,###,###,###,###.00000") 'dblTotalCant
                            'Else
                            oDr("CUNCNA") = "UNI"
                            oDr("QAPCTC") = "1"
                            oDr("ITRCTC") = Format(dblTotalMonto, "###,###,###,###,###.00000") 'dblTotalMonto
                            'End If
                            oDr("CUTCTC") = oDrDet(0).Item("TSGNMN").ToString.Trim
                            If oDrDet(0).Item("TSGNMN").ToString.Trim = "SOL" Then
                                oDr("IVLDCS") = dblTotalMonto
                                oDr("IVLDCD") = Format(dblTotalMonto / dblTipoCambio, "###,###,###,###,###.00")
                            Else
                                oDr("IVLDCS") = Format(dblTotalMonto * dblTipoCambio, "###,###,###,###,###.00")
                                oDr("IVLDCD") = dblTotalMonto
                            End If
                            oDr("NCTDCC") = intNumFactura
                            oDr("FDCCTC") = oDtCabecera.Rows(intNumFactura - 1).Item("FDCCTC").ToString.Trim
                            oDr("CDVSN") = oDrDet(0).Item("CDVSN").ToString.Trim
                            oDr("CGRNGD") = lstrCGRNGD 'oDtCabecera.Rows(intNumFactura - 1).Item("CGRONG").ToString.Trim
                            oDr("CCNCSD") = dblCenCos
                            oDt.Rows.Add(oDr)
                        Else
                            '-----------------------------------------------------------------------------------------------
                            bolMismaUnidad = True
                            Dim odrPropio() As DataRow = oDtFactura.Select("CSRVC = " & CodServicio & " And SRPTRM = 'P'")
                            Dim odrTercero() As DataRow = oDtFactura.Select("CSRVC = " & CodServicio & " And SRPTRM <> 'P'")
                            For lintContador As Int16 = 0 To 1
                                objGrid = New Object
                                dblTotalMonto = 0
                                dblTotalCant = 0
                                If lintContador = 0 Then
                                    For lint As Int32 = 0 To odrPropio.Length - 1
                                        dblTotalMonto = dblTotalMonto + odrPropio(lint).ItemArray(9)
                                        dblTotalCant = dblTotalCant + odrPropio(lint).ItemArray(5)
                                        intNumItems += 1
                                    Next
                                    objGrid = odrPropio
                                Else
                                    For lint As Int32 = 0 To odrTercero.Length - 1
                                        dblTotalMonto = dblTotalMonto + odrTercero(lint).ItemArray(9)
                                        dblTotalCant = dblTotalCant + odrTercero(lint).ItemArray(5)
                                        intNumItems += 1
                                    Next
                                    objGrid = odrTercero
                                End If
                                lintIndice = 0
                                If objGrid(0).Item("SRPTRM").ToString.Trim = "P" Then
                                    dblCenCos = objGrid(0).Item("CCNCST").ToString.Trim
                                    lstrCGRNGD = "9"
                                Else
                                    dblCenCos = objGrid(0).Item("CCNCS1").ToString.Trim
                                    lstrCGRNGD = "10"
                                End If
                                intDetalle = intDetalle + 1
                                oDr = oDt.NewRow
                                oDr("CCMPN") = objGrid(0).Item("CCMPN").ToString.Trim
                                oDr("CTPODC") = dblTipoDoc
                                oDr("NDCCTC") = intNumFactura 'Numero del documento
                                oDr("NINDRN") = "0"
                                oDr("NCRDCC") = intDetalle
                                oDr("CRBCTC") = objGrid(0).Item("CSRVC").ToString.Trim
                                oDr("STCCTC") = "" 'Flag tipo control
                                dblTotalMonto = Format(dblTotalMonto, "###,###,###,###,###.00")
                                'If bolMismaUnidad Then
                                '  oDr("CUNCNA") = objGrid(0).Item("CUNDSR").ToString.Trim
                                '  oDr("QAPCTC") = dblTotalCant 'oDrDet(0).Item("QCNESP").ToString.Trim
                                '  oDr("ITRCTC") = Format(dblTotalMonto / dblTotalCant, "###,###,###,###,###.00000") 'dblTotalCant
                                'Else
                                oDr("CUNCNA") = "UNI"
                                oDr("QAPCTC") = "1"
                                oDr("ITRCTC") = Format(dblTotalMonto, "###,###,###,###,###.00000") 'dblTotalMonto
                                'End If
                                oDr("CUTCTC") = objGrid(0).Item("TSGNMN").ToString.Trim
                                If odrPropio(0).Item("TSGNMN").ToString.Trim = "SOL" Then
                                    oDr("IVLDCS") = dblTotalMonto
                                    oDr("IVLDCD") = Format(dblTotalMonto / dblTipoCambio, "###,###,###,###,###.00")
                                Else
                                    oDr("IVLDCS") = Format(dblTotalMonto * dblTipoCambio, "###,###,###,###,###.00")
                                    oDr("IVLDCD") = dblTotalMonto
                                End If
                                oDr("NCTDCC") = intNumFactura
                                oDr("FDCCTC") = oDtCabecera.Rows(intNumFactura - 1).Item("FDCCTC").ToString.Trim
                                oDr("CDVSN") = objGrid(0).Item("CDVSN").ToString.Trim
                                oDr("CGRNGD") = lstrCGRNGD 'oDtCabecera.Rows(intNumFactura - 1).Item("CGRONG").ToString.Trim
                                oDr("CCNCSD") = dblCenCos
                                oDt.Rows.Add(oDr)
                            Next
                        End If
                        objRegistroItemFactura.Add(intDetalle)
                        If oTipoDocumento = 1 Then
                            Quitar_Detalles_Utilizados(oDtFactura, CodServicio) 'Eliminar los registros utilizados de oDtFactura
                        End If
                    End While
                    If dblPorIgv > 0 Then
                        Agregar_Detalle_IGV(oDt, intNumFactura, dblPorIgv)
                    End If
                    Actualizar_Montos_Cabecera(oDt, intNumFactura, dblPorIgv)
                End While
            End If
            Return oDt
        End Function

        Private Function Lista_Items_Igual_CCosto(ByRef pbolUnidad As Boolean, ByVal poDr() As DataRow) As DataRow()
            Dim oDr() As DataRow
            Dim intCont As Integer
            pbolUnidad = True
            For intCont = 0 To poDr.Length - 1
            Next intCont
            Return oDr
        End Function


        Private Sub Validar_Detalles_lote(ByVal poDr() As DataRow, ByRef pbolMismoCentro As Boolean, ByRef pbolMismaUnidad As Boolean)
            Dim intCont As Integer
            'Dim strCentro As String
            Dim strTipo As String
            Dim strCCostoP As String
            Dim strCCostoT As String
            Dim strUnidad As String
            pbolMismoCentro = True
            pbolMismaUnidad = True
            strCCostoP = poDr(0).Item("CCNCST").ToString.Trim
            strCCostoT = poDr(0).Item("CCNCS1").ToString.Trim
            strTipo = poDr(0).Item("SRPTRM").ToString.Trim
            strUnidad = poDr(0).Item("CUNDSR").ToString.Trim

            For intCont = 0 To poDr.Length - 1 '
                If poDr(intCont).Item("SRPTRM").ToString.Trim = "P" Then
                    If poDr(intCont).Item("SRPTRM").ToString.Trim <> strTipo _
                    OrElse poDr(intCont).Item("CCNCST").ToString.Trim <> strCCostoP Then
                        pbolMismoCentro = False
                        Exit For
                    End If
                Else
                    If poDr(intCont).Item("SRPTRM").ToString.Trim <> strTipo _
                    OrElse poDr(intCont).Item("CCNCS1").ToString.Trim <> strCCostoT Then
                        pbolMismoCentro = False
                        Exit For
                    End If
                End If
            Next intCont

            For intCont = 0 To poDr.Length - 1
                If poDr(intCont).Item("CUNDSR").ToString.Trim <> strUnidad Then
                    pbolMismaUnidad = False
                    Exit For
                End If
            Next intCont
        End Sub

        Private Sub Validar_Detalles(ByVal poDr() As DataRow, ByRef pbolMismoCentro As Boolean, ByRef pbolMismaUnidad As Boolean)
            Dim intCont As Integer
            'Dim strCentro As String
            Dim strTipo As String
            Dim strUnidad As String
            Dim strCCostoP As String
            Dim strCCostoT As String

            pbolMismoCentro = True
            pbolMismaUnidad = True
            strCCostoP = poDr(0).Item("CCNCST").ToString.Trim
            strCCostoT = poDr(0).Item("CCNCS1").ToString.Trim
            strTipo = poDr(0).Item("SRPTRM").ToString.Trim 'poDr(0).Item("CCNCST").ToString.Trim
            strUnidad = poDr(0).Item("CUNDSR").ToString.Trim

            For intCont = 0 To poDr.Length - 1 '
                If poDr(intCont).Item("SRPTRM").ToString.Trim = "P" Then
                    If poDr(intCont).Item("SRPTRM").ToString.Trim <> strTipo _
                    OrElse poDr(intCont).Item("CCNCST").ToString.Trim <> strCCostoP Then
                        pbolMismoCentro = False
                        Exit For
                    End If
                Else
                    If poDr(intCont).Item("SRPTRM").ToString.Trim <> strTipo _
                    OrElse poDr(intCont).Item("CCNCS1").ToString.Trim <> strCCostoT Then
                        pbolMismoCentro = False
                        Exit For
                    End If
                End If
            Next intCont

            'For intCont = 0 To poDr.Length - 1 '
            '    If poDr(intCont).Item("SRPTRM").ToString.Trim <> strTipo Then 'poDr(intCont).Item("CCNCST").ToString.Trim <> strCentro Then
            '        pbolMismoCentro = False
            '        Exit For
            '    End If
            'Next intCont

            For intCont = 0 To poDr.Length - 1
                If poDr(intCont).Item("CUNDSR").ToString.Trim <> strUnidad Then
                    pbolMismaUnidad = False
                    Exit For
                End If
            Next intCont

        End Sub

        Private Function Detalle_Factura(ByRef poDt As DataTable) As DataTable
            Dim oDt As DataTable
            Dim intCont, intIafcdt As Integer
            Dim intCol As Integer
            Dim oDr() As DataRow
            Dim oDrNew As DataRow
            Dim strDetraccion, strIGV As String ', strMoneda As String

            oDt = poDt.Copy
            oDt.Clear()
            strDetraccion = poDt.Rows(0).Item("SRBAFD").ToString.Trim
            intIafcdt = poDt.Rows(0).Item("IPRCDT")
            strIGV = poDt.Rows(0).Item("CTIGVA").ToString.Trim
            'strMoneda = poDt.Rows(0).Item("CMNDA1").ToString.Trim
            oDr = poDt.Select("SRBAFD = '" & strDetraccion & "' AND CTIGVA = " & strIGV & " AND IPRCDT = " & intIafcdt) '" AND CMNDA1 = " & strMoneda)
            For intCont = 0 To oDr.Length - 1
                oDrNew = oDt.NewRow
                For intCol = 0 To oDt.Columns.Count - 1
                    oDrNew.Item(intCol) = oDr(intCont).Item(intCol).ToString.Trim
                Next intCol
                oDt.Rows.Add(oDrNew)
            Next intCont
            Eliminar_Rows_Detalles(poDt, strDetraccion, strIGV, intIafcdt) 'strMoneda)
            Dim dvSort As New DataView(oDt)
            dvSort.Sort = "CSRVC ASC , ISRVGU DESC"
            oDt = dvSort.ToTable()

            Return oDt
        End Function

        Private Sub Quitar_Detalles_Utilizados(ByRef poDt As DataTable, ByVal pdblServicio As Double)
            Dim intCont As Integer

            For intCont = poDt.Rows.Count - 1 To 0 Step -1
                If poDt.Rows(intCont).Item("CSRVC") = pdblServicio Then
                    poDt.Rows.RemoveAt(intCont)
                End If
            Next intCont
        End Sub

        Private Sub Actualizar_Montos_Cabecera(ByVal poDt As DataTable, ByVal pintFactura As Integer, ByVal pdblIGV As Integer)
            Dim intCont As Integer
            Dim dblTotalAfecto As Double = 0
            Dim dblTotalInAfecto As Double = 0
            Dim bolSol As Boolean = False

            If pdblIGV > 0 Then
                For intCont = 0 To poDt.Rows.Count - 1
                    If poDt.Rows(intCont).Item("NDCCTC").ToString.Trim = pintFactura And poDt.Rows(intCont).Item("CRBCTC").ToString.Trim <> "999" Then
                        If strTipomoneda = "SOL" Then 'poDt.Rows(intCont).Item("CUTCTC").ToString.Trim = "SOL" Then
                            bolSol = True
                            dblTotalAfecto = dblTotalAfecto + poDt.Rows(intCont).Item("IVLDCS")
                        Else
                            bolSol = False
                            dblTotalAfecto = dblTotalAfecto + poDt.Rows(intCont).Item("IVLDCD")
                        End If
                    End If
                Next intCont
            Else
                For intCont = 0 To poDt.Rows.Count - 1
                    If poDt.Rows(intCont).Item("NDCCTC").ToString.Trim = pintFactura Then
                        If poDt.Rows(intCont).Item("CUTCTC").ToString.Trim = "SOL" Then
                            bolSol = True
                            dblTotalInAfecto = dblTotalInAfecto + poDt.Rows(intCont).Item("IVLDCS").ToString.Trim
                        Else
                            bolSol = False
                            dblTotalInAfecto = dblTotalInAfecto + poDt.Rows(intCont).Item("IVLDCD").ToString.Trim
                        End If
                    End If
                Next intCont
            End If

            If bolSol Then
                oDtCabecera.Rows(pintFactura - 1).Item("IVLAFS") = dblTotalAfecto
                oDtCabecera.Rows(pintFactura - 1).Item("IVLNAS") = dblTotalInAfecto
                oDtCabecera.Rows(pintFactura - 1).Item("IVLIGS") = IIf(pdblIGV > 0, Format(dblTotalAfecto * (pdblIGV / 100), "###,###,###,###,###.00"), pdblIGV)
                oDtCabecera.Rows(pintFactura - 1).Item("ITTFCS") = dblTotalAfecto + dblTotalInAfecto + IIf(pdblIGV > 0, Format(dblTotalAfecto * (pdblIGV / 100), "###,###,###,###,###.00"), pdblIGV) 'oDtCabecera.Rows(pintFactura - 1).Item("IVLIGS")
                oDtCabecera.Rows(pintFactura - 1).Item("IVLAFD") = Format((dblTotalAfecto / dblTipoCambio), "###,###,###,###,###.00")
                oDtCabecera.Rows(pintFactura - 1).Item("IVLNAD") = Format((dblTotalInAfecto / dblTipoCambio), "###,###,###,###,###.00")
                oDtCabecera.Rows(pintFactura - 1).Item("IVLIGD") = IIf(pdblIGV > 0, Format((dblTotalAfecto / dblTipoCambio) * (pdblIGV / 100), "###,###,###,###,###.00"), pdblIGV)
                oDtCabecera.Rows(pintFactura - 1).Item("ITTFCD") = Format((dblTotalAfecto / dblTipoCambio) + (dblTotalInAfecto / dblTipoCambio) + IIf(pdblIGV > 0, Format((dblTotalAfecto / dblTipoCambio) * (pdblIGV / 100), "###,###,###,###,###.00"), pdblIGV), "###,###,###,###,###.00")
                'oDtCabecera.Rows(pintFactura - 1).Item("IVLAFD") + oDtCabecera.Rows(pintFactura - 1).Item("IVLNAD") + oDtCabecera.Rows(pintFactura - 1).Item("IVLIGD")
            Else
                oDtCabecera.Rows(pintFactura - 1).Item("IVLAFS") = Format((dblTotalAfecto * dblTipoCambio), "###,###,###,###,###.00")
                oDtCabecera.Rows(pintFactura - 1).Item("IVLNAS") = Format((dblTotalInAfecto * dblTipoCambio), "###,###,###,###,###.00")
                oDtCabecera.Rows(pintFactura - 1).Item("IVLIGS") = IIf(pdblIGV > 0, Format((dblTotalAfecto * dblTipoCambio) * (pdblIGV / 100), "###,###,###,###,###.00"), pdblIGV)
                oDtCabecera.Rows(pintFactura - 1).Item("ITTFCS") = Format((dblTotalAfecto * dblTipoCambio) + (dblTotalInAfecto * dblTipoCambio) + IIf(pdblIGV > 0, Format((dblTotalAfecto * dblTipoCambio) * (pdblIGV / 100), "###,###,###,###,###.00"), pdblIGV), "###,###,###,###,###.00")
                'oDtCabecera.Rows(pintFactura - 1).Item("IVLAFS") + oDtCabecera.Rows(pintFactura - 1).Item("IVLNAS") + oDtCabecera.Rows(pintFactura - 1).Item("IVLIGS")
                oDtCabecera.Rows(pintFactura - 1).Item("IVLAFD") = dblTotalAfecto
                oDtCabecera.Rows(pintFactura - 1).Item("IVLNAD") = dblTotalInAfecto
                oDtCabecera.Rows(pintFactura - 1).Item("IVLIGD") = IIf(pdblIGV > 0, Format(dblTotalAfecto * (pdblIGV / 100), "###,###,###,###,###.0000"), pdblIGV)
                oDtCabecera.Rows(pintFactura - 1).Item("ITTFCD") = Format(dblTotalAfecto + dblTotalInAfecto + IIf(pdblIGV > 0, Format(dblTotalAfecto * (pdblIGV / 100), "###,###,###,###,###.00"), pdblIGV), "###,###,###,###,###.00")
                'oDtCabecera.Rows(pintFactura - 1).Item("IVLIGD")
            End If
        End Sub

        Private Sub Agregar_Detalle_IGV(ByRef poDt As DataTable, ByVal pintFactura As Integer, ByVal pdblIGV As Integer)
            Dim oDr As DataRow
            Dim intCont As Integer
            Dim intDet As Integer = 1
            Dim dblTotal As Double = 0

            For intCont = 0 To poDt.Rows.Count - 1
                If poDt.Rows(intCont).Item("NDCCTC").ToString.Trim = pintFactura Then
                    intDet = intDet + 1
                    'If poDt.Rows(intCont).Item("CUTCTC").ToString.Trim = "SOL" Then
                    'dblTotal = dblTotal + poDt.Rows(intCont).Item("IVLDCS").ToString.Trim
                    'Else
                    dblTotal = dblTotal + poDt.Rows(intCont).Item("IVLDCD")
                    'End If
                End If
            Next intCont
            oDr = poDt.NewRow

            oDr("CCMPN") = poDt.Rows(0).Item("CCMPN").ToString.Trim
            oDr("CTPODC") = dblTipoDoc
            oDr("NDCCTC") = pintFactura
            oDr("NINDRN") = "0"
            oDr("NCRDCC") = intDet
            oDr("CRBCTC") = "999"
            oDr("QAPCTC") = "0"
            oDr("ITRCTC") = "0"
            oDr("STCCTC") = "" 'Flag tipo control
            'If poDt.Rows(0).Item("CUTCTC").ToString.Trim = "SOL" Then
            '  oDr("IVLDCS") = Format(dblTotal * (pdblIGV / 100), "###,###,###,###,##0.000")
            '  oDr("IVLDCD") = Format((dblTotal / dblTipoCambio) * (pdblIGV / 100), "###,###,###,###,##0.000")
            'Else
            dblTotal = Format(dblTotal, "###,###,###,###,###.00")
            oDr("IVLDCS") = Format((dblTotal * dblTipoCambio) * (pdblIGV / 100), "###,###,###,###,###.00")
            oDr("IVLDCD") = Format(dblTotal * (pdblIGV / 100), "###,###,###,###,###.00")
            'End If
            oDr("NCTDCC") = pintFactura
            oDr("FDCCTC") = oDtCabecera.Rows(pintFactura - 1).Item("FDCCTC").ToString.Trim
            oDr("CDVSN") = poDt.Rows(0).Item("CDVSN").ToString.Trim
            oDr("CGRNGD") = ""
            oDr("CCNCSD") = "0"
            poDt.Rows.Add(oDr)
        End Sub

        Private Sub Crear_Estructura_Actualizar_Servicio(ByRef poDt As DataTable)
            poDt.Columns.Add(New DataColumn("CTPODC", GetType(System.String))) 'Tipo de Documento
            poDt.Columns.Add(New DataColumn("NDCCTC", GetType(System.String))) 'Numero de Documento    
            poDt.Columns.Add(New DataColumn("NOPRCN", GetType(System.Int64)))  '-- Operación
            poDt.Columns.Add(New DataColumn("NGUIRM", GetType(System.Int64)))  '-- Nro Guía Remisión
            poDt.Columns.Add(New DataColumn("CRBCTC", GetType(System.String))) 'Servicio
            poDt.Columns.Add(New DataColumn("QCNDTG", GetType(System.Double))) 'Cantidad
            poDt.Columns.Add(New DataColumn("CUNDSR", GetType(System.String))) 'Unidad de Medida
            poDt.Columns.Add(New DataColumn("ISRVGU", GetType(System.Double))) 'Importe Servicio ACTUAL
            poDt.Columns.Add(New DataColumn("CMNDGU", GetType(System.Int32))) 'Moneda
            poDt.Columns.Add(New DataColumn("IVLRLV", GetType(System.Double))) 'Importe Servicio FACTURA

        End Sub

        Private Sub Crear_Estructura_Detalle(ByRef poDt As DataTable)
            poDt.Columns.Add(New DataColumn("CCMPN", GetType(System.String)))  'Compañia
            poDt.Columns.Add(New DataColumn("CTPODC", GetType(System.String))) 'Tipo de Documento
            poDt.Columns.Add(New DataColumn("NDCCTC", GetType(System.String))) 'Numero de Documento
            poDt.Columns.Add(New DataColumn("NINDRN", GetType(System.String))) 'Indice de Renovacion = 0
            poDt.Columns.Add(New DataColumn("NCRDCC", GetType(System.String))) 'Correlativo del Detalle
            poDt.Columns.Add(New DataColumn("CRBCTC", GetType(System.String))) 'Servicio
            poDt.Columns.Add(New DataColumn("STCCTC", GetType(System.String))) 'Flag tipo control = ""
            poDt.Columns.Add(New DataColumn("CUNCNA", GetType(System.String))) 'Unidad del Servicio
            poDt.Columns.Add(New DataColumn("QAPCTC", GetType(System.String))) 'Cantidad del Servicio
            poDt.Columns.Add(New DataColumn("CUTCTC", GetType(System.String))) 'Moneda de la Tarifa
            poDt.Columns.Add(New DataColumn("ITRCTC", GetType(System.String))) 'Tarifa del Servicio
            poDt.Columns.Add(New DataColumn("IVLDCS", GetType(System.String))) 'Monto Total Soles
            poDt.Columns.Add(New DataColumn("IVLDCD", GetType(System.String))) 'Monto Total Dolares
            poDt.Columns.Add(New DataColumn("NCTDCC", GetType(System.String))) 'Control Documento
            poDt.Columns.Add(New DataColumn("FDCCTC", GetType(System.String))) 'Fecha de Emision
            poDt.Columns.Add(New DataColumn("CDVSN", GetType(System.String)))  'Division
            poDt.Columns.Add(New DataColumn("CGRNGD", GetType(System.String))) 'Giro de Negocio
            poDt.Columns.Add(New DataColumn("CCNCSD", GetType(System.String))) 'Centro de Costo
            'poDt.Columns.Add(New DataColumn("NOPRCN", GetType(System.Int64)))  '-- Operación
            'poDt.Columns.Add(New DataColumn("NGUIRM", GetType(System.Int64)))  '-- Nro Guía Remisión
        End Sub
        Private Sub Crear_Estructura_Detalle_ReFactura(ByRef poDt As DataTable)
            poDt.Columns.Add(New DataColumn("CCMPN", GetType(System.String)))  'Compañia
            poDt.Columns.Add(New DataColumn("CTPODC", GetType(System.String))) 'Tipo de Documento
            poDt.Columns.Add(New DataColumn("NDCCTC", GetType(System.String))) 'Numero de Documento
            poDt.Columns.Add(New DataColumn("NINDRN", GetType(System.String))) 'Indice de Renovacion = 0
            poDt.Columns.Add(New DataColumn("NCRDCC", GetType(System.String))) 'Correlativo del Detalle
            poDt.Columns.Add(New DataColumn("CRBCTC", GetType(System.String))) 'Servicio
            poDt.Columns.Add(New DataColumn("STCCTC", GetType(System.String))) 'Flag tipo control = ""
            poDt.Columns.Add(New DataColumn("CUNCNA", GetType(System.String))) 'Unidad del Servicio
            poDt.Columns.Add(New DataColumn("QAPCTC", GetType(System.String))) 'Cantidad del Servicio
            poDt.Columns.Add(New DataColumn("CUTCTC", GetType(System.String))) 'Moneda de la Tarifa
            poDt.Columns.Add(New DataColumn("ITRCTC", GetType(System.String))) 'Tarifa del Servicio
            poDt.Columns.Add(New DataColumn("IVLDCS", GetType(System.String))) 'Monto Total Soles
            poDt.Columns.Add(New DataColumn("IVLDCD", GetType(System.String))) 'Monto Total Dolares
            poDt.Columns.Add(New DataColumn("NCTDCC", GetType(System.String))) 'Control Documento
            poDt.Columns.Add(New DataColumn("FDCCTC", GetType(System.String))) 'Fecha de Emision
            poDt.Columns.Add(New DataColumn("CDVSN", GetType(System.String)))  'Division
            poDt.Columns.Add(New DataColumn("CGRNGD", GetType(System.String))) 'Giro de Negocio
            poDt.Columns.Add(New DataColumn("CCNCSD", GetType(System.String))) 'Centro de Costo
            'poDt.Columns.Add(New DataColumn("NOPRCN", GetType(System.Int64)))  '-- Operación
            'poDt.Columns.Add(New DataColumn("NGUIRM", GetType(System.Int64)))  '-- Nro Guía Remisión
        End Sub

        Private Sub Crear_Estructura_Cabecera(ByRef poDt As DataTable)
            poDt.Columns.Add(New DataColumn("CCMPN", GetType(System.String)))  'Compañia
            poDt.Columns.Add(New DataColumn("CTPODC", GetType(System.String))) 'Tipo de Documento
            poDt.Columns.Add(New DataColumn("NDCCTC", GetType(System.String))) 'Numero de Documento
            poDt.Columns.Add(New DataColumn("NINDRN", GetType(System.String))) 'Indice de Renovacion = 0
            poDt.Columns.Add(New DataColumn("CDVSN", GetType(System.String)))  'Division
            poDt.Columns.Add(New DataColumn("CGRONG", GetType(System.String))) 'Giro de Negocio
            poDt.Columns.Add(New DataColumn("CZNFCC", GetType(System.String))) 'Zona de Facturacion
            poDt.Columns.Add(New DataColumn("CCBRD", GetType(System.String)))  'Codigo de Cobrador
            poDt.Columns.Add(New DataColumn("CCLNT", GetType(System.String)))  'Cliente
            poDt.Columns.Add(New DataColumn("CPLNCL", GetType(System.String))) 'Planta Cliente
            poDt.Columns.Add(New DataColumn("NRUC", GetType(System.String)))   'RUC
            poDt.Columns.Add(New DataColumn("CSTCDC", GetType(System.String))) 'Situacion Documento ='ZZ'
            poDt.Columns.Add(New DataColumn("CPLNDV", GetType(System.String))) 'Planta
            poDt.Columns.Add(New DataColumn("SABOPN", GetType(System.String))) 'Abono Pendiente='P'
            poDt.Columns.Add(New DataColumn("FDCCTC", GetType(System.String))) 'Fecha de Emision
            poDt.Columns.Add(New DataColumn("CMNDA", GetType(System.String)))  'Moneda
            poDt.Columns.Add(New DataColumn("IVLAFS", GetType(System.String))) 'Monto Afecto Soles
            poDt.Columns.Add(New DataColumn("IVLNAS", GetType(System.String))) 'Monto No Afecto Soles
            poDt.Columns.Add(New DataColumn("IVLIGS", GetType(System.String))) 'Monto IGV Soles
            poDt.Columns.Add(New DataColumn("ITTFCS", GetType(System.String))) 'Total Monto Soles
            poDt.Columns.Add(New DataColumn("ITTPGS", GetType(System.String))) 'Pago Soles = 0
            poDt.Columns.Add(New DataColumn("IVLAFD", GetType(System.String))) 'Monto Afecto Dolares
            poDt.Columns.Add(New DataColumn("IVLNAD", GetType(System.String))) 'Monto No Afecto Dolares
            poDt.Columns.Add(New DataColumn("IVLIGD", GetType(System.String))) 'Monto IGV Dolares
            poDt.Columns.Add(New DataColumn("ITTFCD", GetType(System.String))) 'Total Monto Dolares
            poDt.Columns.Add(New DataColumn("ITTPGD", GetType(System.String))) 'Pago Dolares = 0
            poDt.Columns.Add(New DataColumn("ITCCTC", GetType(System.String))) 'Tipo Cambio
            poDt.Columns.Add(New DataColumn("SFLLTR", GetType(System.String))) 'Filial / Tercero
            poDt.Columns.Add(New DataColumn("NCTDCC", GetType(System.String))) 'Control Documento
            poDt.Columns.Add(New DataColumn("CZNCBD", GetType(System.String))) 'Zona Cobrador
            poDt.Columns.Add(New DataColumn("CCNCSC", GetType(System.String))) 'Centro de Costo
            poDt.Columns.Add(New DataColumn("NDSPGD", GetType(System.Int32)))  '--
            poDt.Columns.Add(New DataColumn("VLRFDT", GetType(System.Double))) '--
            poDt.Columns.Add(New DataColumn("CRGVTA", GetType(System.String))) '--
            poDt.Columns.Add(New DataColumn("FATNSR", GetType(System.Double))) '--
            poDt.Columns.Add(New DataColumn("CTPDCO", GetType(System.Double))) '--
            poDt.Columns.Add(New DataColumn("NDCMOR", GetType(System.Double))) '--
            poDt.Columns.Add(New DataColumn("FDCMOR", GetType(System.Double))) '--

        End Sub

        Private Sub Buscar_Documento()
            Dim intCont As Integer

            dblTipoDoc = oDtDocumentos.Rows(0).Item("CTPODC").ToString.Trim
            For intCont = 0 To oDtDocumentos.Rows.Count - 1
                If oDtDocumentos.Rows(intCont).Item("NPTOVT").ToString.Trim = strPtoVenta Then
                    strCodTabla = oDtDocumentos.Rows(intCont).Item("CTPCTR").ToString.Trim
                    Exit For
                End If
            Next intCont
        End Sub

        Public Function Lista_Datos_Servicio(ByVal pobjFiltro As Hashtable) As DataTable
            Return objDataAccessLayer.Lista_Datos_Servicio(pobjFiltro)
        End Function

        Public Function Lista_Datos_Factura(ByVal pobjFiltro As Hashtable) As DataSet
            Return objDataAccessLayer.Lista_Datos_Factura(pobjFiltro)
        End Function

        Public Sub Grabar_Factura(ByVal pintFact As Integer, ByRef poDtCabFact As DataTable, ByRef poDtDetFact As DataTable, ByRef pstrNumFac As Int64, Optional ByVal pintFlagFac As Int32 = 0)
            Try
                Dim intCont As Integer
                Dim intRow As Integer
                Dim obj(2) As Object
                Dim objCab(35) As Object
                Dim objDet(20) As Object
                Dim oDt As DataTable
                Dim dblNumFactura As Int64
                Dim dblNumControl As Int64
                Dim lintFecFac As Int64 = 0

                For intCont = 0 To poDtCabFact.Rows.Count - 1
                    If poDtCabFact.Rows(intCont).Item("NDCCTC") = pintFact Then
                        objCab(0) = poDtCabFact.Rows(intCont).Item("CCMPN")
                        objCab(1) = strCodTabla
                        objCab(2) = poDtCabFact.Rows(intCont).Item("CTPODC")
                        objCab(3) = poDtCabFact.Rows(intCont).Item("NINDRN")
                        objCab(4) = poDtCabFact.Rows(intCont).Item("CDVSN")
                        objCab(5) = poDtCabFact.Rows(intCont).Item("CGRONG")
                        objCab(6) = poDtCabFact.Rows(intCont).Item("CZNFCC")
                        objCab(7) = poDtCabFact.Rows(intCont).Item("CCBRD")
                        objCab(8) = poDtCabFact.Rows(intCont).Item("CCLNT")
                        objCab(9) = poDtCabFact.Rows(intCont).Item("CPLNCL")
                        objCab(10) = poDtCabFact.Rows(intCont).Item("NRUC")
                        objCab(11) = poDtCabFact.Rows(intCont).Item("CSTCDC")
                        objCab(12) = poDtCabFact.Rows(intCont).Item("CPLNDV")
                        objCab(13) = poDtCabFact.Rows(intCont).Item("SABOPN")
                        objCab(14) = poDtCabFact.Rows(intCont).Item("FDCCTC")
                        objCab(15) = poDtCabFact.Rows(intCont).Item("CMNDA")
                        objCab(16) = poDtCabFact.Rows(intCont).Item("IVLAFS")
                        objCab(17) = poDtCabFact.Rows(intCont).Item("IVLNAS")
                        objCab(18) = poDtCabFact.Rows(intCont).Item("IVLIGS")
                        objCab(19) = poDtCabFact.Rows(intCont).Item("ITTFCS")
                        objCab(20) = poDtCabFact.Rows(intCont).Item("ITTPGS")
                        objCab(21) = poDtCabFact.Rows(intCont).Item("IVLAFD")
                        objCab(22) = poDtCabFact.Rows(intCont).Item("IVLNAD")
                        objCab(23) = poDtCabFact.Rows(intCont).Item("IVLIGD")
                        objCab(24) = poDtCabFact.Rows(intCont).Item("ITTFCD")
                        objCab(25) = poDtCabFact.Rows(intCont).Item("ITTPGD")
                        objCab(26) = poDtCabFact.Rows(intCont).Item("ITCCTC")
                        objCab(27) = poDtCabFact.Rows(intCont).Item("CTPDCO")
                        objCab(28) = poDtCabFact.Rows(intCont).Item("NDCMOR")
                        objCab(29) = poDtCabFact.Rows(intCont).Item("FDCMOR")
                        objCab(30) = poDtCabFact.Rows(intCont).Item("SFLLTR")
                        objCab(31) = poDtCabFact.Rows(intCont).Item("CZNCBD")
                        objCab(32) = poDtCabFact.Rows(intCont).Item("CCNCSC")
                        objCab(33) = CType(poDtCabFact.Rows(intCont).Item("NDSPGD"), Int32)
                        objCab(34) = poDtCabFact.Rows(intCont).Item("CRGVTA")
                        objCab(35) = poDtCabFact.Rows(intCont).Item("FATNSR")
                        lintFecFac = poDtCabFact.Rows(intCont).Item("FDCCTC")
                        oDt = objDataAccessLayer.Grabar_Cabecera_Factura(objCab)
                        dblNumFactura = oDt.Rows(0).Item("NULCTR")
                        dblNumControl = oDt.Rows(0).Item("NCTRRL")
                        poDtCabFact.Rows(intCont).Item("NDCCTC") = dblNumFactura
                        poDtCabFact.Rows(intCont).Item("NCTDCC") = dblNumControl

                        For intRow = 0 To poDtDetFact.Rows.Count - 1
                            If poDtDetFact.Rows(intRow).Item("NDCCTC") = pintFact Then
                                ' poDtDetFact.Rows(intRow).Item("NDCCTC") = pintFact And Not (poDtDetFact.Rows(intRow).Item("CCNCSD") Is DBNull.Value)
                                objDet(0) = poDtDetFact.Rows(intRow).Item("CCMPN")
                                objDet(1) = poDtDetFact.Rows(intRow).Item("CTPODC")
                                objDet(2) = dblNumFactura
                                objDet(3) = poDtDetFact.Rows(intRow).Item("NINDRN")
                                objDet(4) = poDtDetFact.Rows(intRow).Item("NCRDCC")
                                objDet(5) = poDtDetFact.Rows(intRow).Item("CRBCTC")
                                objDet(6) = poDtDetFact.Rows(intRow).Item("STCCTC")
                                objDet(7) = poDtDetFact.Rows(intRow).Item("CUNCNA")
                                objDet(8) = poDtDetFact.Rows(intRow).Item("QAPCTC")
                                objDet(9) = poDtDetFact.Rows(intRow).Item("CUTCTC")
                                objDet(10) = poDtDetFact.Rows(intRow).Item("ITRCTC")
                                objDet(11) = poDtDetFact.Rows(intRow).Item("IVLDCS")
                                objDet(12) = poDtDetFact.Rows(intRow).Item("IVLDCD")
                                objDet(13) = dblNumControl
                                objDet(14) = poDtDetFact.Rows(intRow).Item("FDCCTC")
                                objDet(15) = poDtDetFact.Rows(intRow).Item("CDVSN")
                                objDet(16) = poDtDetFact.Rows(intRow).Item("CGRNGD")
                                objDet(17) = poDtDetFact.Rows(intRow).Item("CCNCSD")
                                'objDet(18) = poDtDetFact.Rows(intRow).Item("NOPRCN")
                                'objDet(19) = poDtDetFact.Rows(intRow).Item("NGUIRM")
                                objDataAccessLayer.Grabar_Detalle_Factura(objDet)
                                poDtDetFact.Rows(intRow).Item("NDCCTC") = dblNumFactura
                                poDtDetFact.Rows(intRow).Item("NCTDCC") = dblNumControl
                            End If
                        Next intRow


                        'ACTUALIZACION SPOT
                        Try
                            Dim CCMPN As String = ("" & poDtCabFact.Rows(intCont).Item("CCMPN")).ToString.Trim
                            Dim CTPODC As Decimal = poDtCabFact.Rows(intCont).Item("CTPODC")
                            Dim NDCFCC As Decimal = dblNumFactura
                            ActualizarSPOT(CCMPN, CTPODC, NDCFCC)
                        Catch ex As Exception
                        End Try
                        '**********************
                        Try
                            Dim NUMDOC_GEN As Decimal = dblNumFactura
                            Dim CCMPN As String = ("" & poDtCabFact.Rows(intCont).Item("CCMPN")).ToString.Trim
                            Dim CTPDCO As Decimal = poDtCabFact.Rows(intCont).Item("CTPDCO")
                            Dim NDCMOR As Decimal = poDtCabFact.Rows(intCont).Item("NDCMOR")
                            Dim TIPOODC_GEN As Decimal = poDtCabFact.Rows(intCont).Item("CTPODC")
                            Dim CDVSN As String = ("" & poDtCabFact.Rows(intCont).Item("CDVSN")).ToString.Trim
                            RegistrarHistorialRefacturaRZCT34(CCMPN, CDVSN, CTPDCO, NDCMOR, TIPOODC_GEN, NUMDOC_GEN, oDtServicioActualizar, pintFact)
                        Catch ex As Exception
                        End Try

                        Exit For
                    End If
                Next intCont


                pstrNumFac = dblNumFactura
                Dim oDr() As DataRow
                Dim objFiltro As Hashtable
                oDr = oDtServicioActualizar.Select("NDCCTC = " & pintFact)
                For intContador As Integer = 0 To oDr.Length - 1
                    objFiltro = New Hashtable
                    objFiltro.Add("PNNOPRCN", oDr(intContador).Item("NOPRCN").ToString.Trim)
                    objFiltro.Add("PNNGUIRM", oDr(intContador).Item("NGUIRM").ToString.Trim)
                    objFiltro.Add("PNCRBCTC", oDr(intContador).Item("CRBCTC").ToString.Trim)
                    objFiltro.Add("PNQCNDTG", oDr(intContador).Item("QCNDTG")) 'CANTIDAD
                    objFiltro.Add("PSCUNDSR", oDr(intContador).Item("CUNDSR").ToString.Trim) 'CODIGO UNIDAD SERVICIO
                    objFiltro.Add("PNISRVGU", oDr(intContador).Item("ISRVGU")) 'IMPORTE
                    objFiltro.Add("PNCMNDGU", 1) 'CODIGO MONEDA
                    objFiltro.Add("PNCTPODC", poDtCabFact.Rows(0).Item("CTPODC"))
                    objFiltro.Add("PNNDCMFC", dblNumFactura)
                    objFiltro.Add("PNFECFAC", lintFecFac)
                    objFiltro.Add("PSCCMPN", poDtCabFact.Rows(0).Item("CCMPN").ToString.Trim)
                    objFiltro.Add("PNFLGFAC", pintFlagFac)
                    objDataAccessLayer.Actualizar_Detalle_Facturado(objFiltro)
                Next

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Private Sub ActualizarSPOT(ByVal CCMPN As String, ByVal CTPODC As Decimal, ByVal NDCFCC As Decimal)
            If CTPODC = 1 OrElse CTPODC = 2 Then
                Dim oFiltroActSPOT As New Hashtable
                oFiltroActSPOT("PSCCMPN") = CCMPN
                oFiltroActSPOT("PNCTPODC") = CTPODC
                oFiltroActSPOT("PNNDCFCC") = NDCFCC
                objDataAccessLayer.fintActualizarFacturaDetracionSPOT(oFiltroActSPOT)
            End If
        End Sub

        'oFiltroActSPOT("PSCCMPN") = ("" & poDtCabFact.Rows(intCont).Item("CCMPN")).ToString.Trim
        'oFiltroActSPOT("PNCTPODC") = poDtCabFact.Rows(intCont).Item("CTPODC")
        'oFiltroActSPOT("PNNDCFCC") = dblNumFactura

        Private Function EsParaRefactura(ByVal oDtServicio As DataTable, ByVal pintFact As Int32) As String
            Dim drHistRefact() As DataRow
            drHistRefact = oDtServicio.Select("NDCCTC = " & pintFact)
            Dim FlgRefact As String = ""
            Dim FlgLib As String = ""
            If (ListaOperaciones IsNot Nothing AndAlso drHistRefact.Length > 0) Then
                For intContador As Integer = 0 To drHistRefact.Length - 1
                    FlgLib = TraerEstadooperacion(drHistRefact(intContador).Item("NOPRCN"))
                    If FlgLib = "SI" Then
                        Exit For
                    End If
                Next
            End If
            If FlgLib = "SI" Then
                FlgRefact = "X"
            Else
                FlgRefact = ""
            End If
            Return FlgRefact
        End Function

        Private Sub RegistrarHistorialRefacturaRZCT34(ByVal CCMPN As String, ByVal CDVSN As String, ByVal CTPDCO As Decimal, ByVal NDCMOR As Decimal, ByVal TIPOODC_GEN As Decimal, ByVal NUMDOC_GEN As Decimal, ByVal oDtServicio As DataTable, ByVal pintFact As Int32)

            Dim dtOrigen As New DataTable
            Dim TipoDocHist As Decimal = 0
            Dim NumDocHist As Decimal = 0
            Dim TipoHistTemp As Decimal = CTPDCO
            Dim NumDocHistTemp As Decimal = NDCMOR
            TipoDocHist = TipoHistTemp
            NumDocHist = NumDocHistTemp
            Dim numVecesMax As Int32 = 100
            If NumDocHistTemp > 0 Then
                While (numVecesMax > 0 AndAlso NumDocHistTemp <> 0)
                    Dim oHasFiltro As New Hashtable
                    TipoDocHist = TipoHistTemp
                    NumDocHist = NumDocHistTemp
                    oHasFiltro("PSCCMPN") = CCMPN
                    oHasFiltro("PNCTPODC") = TipoHistTemp
                    oHasFiltro("PNNDCCTC") = NumDocHistTemp
                    dtOrigen = objDataAccessLayer.Lista_Datos_Cuenta_Corriente(oHasFiltro)
                    If dtOrigen.Rows.Count > 0 Then
                        TipoHistTemp = dtOrigen.Rows(0)("CTPDCO")
                        NumDocHistTemp = dtOrigen.Rows(0)("NDCMOR")
                    Else
                        Exit While
                    End If
                    numVecesMax = numVecesMax - 1
                End While
                Dim oFiltroHistRefactura As New Hashtable
                oFiltroHistRefactura("PSCCMPN") = CCMPN
                oFiltroHistRefactura("PNTDOCOR") = CTPDCO
                oFiltroHistRefactura("PNNDOCOR") = NDCMOR
                oFiltroHistRefactura("PNTDOCGN") = TIPOODC_GEN
                oFiltroHistRefactura("PNNDOCGN") = NUMDOC_GEN
                oFiltroHistRefactura("PSPRGCRT") = "SOLMIN_ST"
                oFiltroHistRefactura("PNTOR_HIST") = TipoDocHist
                oFiltroHistRefactura("PNNDOC_HIST") = NumDocHist
                oFiltroHistRefactura("PSFLGRFC") = EsParaRefactura(oDtServicio, pintFact)
                objDataAccessLayer.Registrar_Refactura_Historial_RZCT34(oFiltroHistRefactura)
            End If

        End Sub


        Public Sub Grabar_Factura_Lote(ByVal pintFact As Integer, ByRef poDtCabFact As DataTable, ByRef poDtDetFact As DataTable, ByRef pstrNumFac As Int64, Optional ByVal pintFlagFac As Int32 = 0)
            Try
                Dim intCont As Integer
                Dim intRow As Integer
                Dim obj(2) As Object
                Dim objCab(35) As Object
                Dim objDet(20) As Object
                Dim oDt As DataTable
                Dim dblNumFactura As Int64
                Dim dblNumControl As Int64
                Dim lintFecFac As Int64 = 0

                For intCont = 0 To poDtCabFact.Rows.Count - 1
                    If poDtCabFact.Rows(intCont).Item("NDCCTC") = pintFact Then
                        objCab(0) = poDtCabFact.Rows(intCont).Item("CCMPN")
                        objCab(1) = strCodTabla
                        objCab(2) = poDtCabFact.Rows(intCont).Item("CTPODC")
                        objCab(3) = poDtCabFact.Rows(intCont).Item("NINDRN")
                        objCab(4) = poDtCabFact.Rows(intCont).Item("CDVSN")
                        objCab(5) = poDtCabFact.Rows(intCont).Item("CGRONG")
                        objCab(6) = poDtCabFact.Rows(intCont).Item("CZNFCC")
                        objCab(7) = poDtCabFact.Rows(intCont).Item("CCBRD")
                        objCab(8) = poDtCabFact.Rows(intCont).Item("CCLNT")
                        objCab(9) = poDtCabFact.Rows(intCont).Item("CPLNCL")
                        objCab(10) = poDtCabFact.Rows(intCont).Item("NRUC")
                        objCab(11) = poDtCabFact.Rows(intCont).Item("CSTCDC")
                        objCab(12) = poDtCabFact.Rows(intCont).Item("CPLNDV")
                        objCab(13) = poDtCabFact.Rows(intCont).Item("SABOPN")
                        objCab(14) = poDtCabFact.Rows(intCont).Item("FDCCTC")
                        objCab(15) = poDtCabFact.Rows(intCont).Item("CMNDA")
                        objCab(16) = poDtCabFact.Rows(intCont).Item("IVLAFS")
                        objCab(17) = poDtCabFact.Rows(intCont).Item("IVLNAS")
                        objCab(18) = poDtCabFact.Rows(intCont).Item("IVLIGS")
                        objCab(19) = poDtCabFact.Rows(intCont).Item("ITTFCS")
                        objCab(20) = poDtCabFact.Rows(intCont).Item("ITTPGS")
                        objCab(21) = poDtCabFact.Rows(intCont).Item("IVLAFD")
                        objCab(22) = poDtCabFact.Rows(intCont).Item("IVLNAD")
                        objCab(23) = poDtCabFact.Rows(intCont).Item("IVLIGD")
                        objCab(24) = poDtCabFact.Rows(intCont).Item("ITTFCD")
                        objCab(25) = poDtCabFact.Rows(intCont).Item("ITTPGD")
                        objCab(26) = poDtCabFact.Rows(intCont).Item("ITCCTC")
                        objCab(27) = poDtCabFact.Rows(intCont).Item("CTPDCO")
                        objCab(28) = poDtCabFact.Rows(intCont).Item("NDCMOR")
                        objCab(29) = poDtCabFact.Rows(intCont).Item("FDCMOR")
                        objCab(30) = poDtCabFact.Rows(intCont).Item("SFLLTR")
                        objCab(31) = poDtCabFact.Rows(intCont).Item("CZNCBD")
                        objCab(32) = poDtCabFact.Rows(intCont).Item("CCNCSC")
                        objCab(33) = CType(poDtCabFact.Rows(intCont).Item("NDSPGD"), Int32)
                        objCab(34) = poDtCabFact.Rows(intCont).Item("CRGVTA")
                        objCab(35) = poDtCabFact.Rows(intCont).Item("FATNSR")
                        lintFecFac = poDtCabFact.Rows(intCont).Item("FDCCTC")
                        oDt = objDataAccessLayer.Grabar_Cabecera_Factura(objCab)
                        dblNumFactura = oDt.Rows(0).Item("NULCTR")
                        dblNumControl = oDt.Rows(0).Item("NCTRRL")
                        poDtCabFact.Rows(intCont).Item("NDCCTC") = dblNumFactura
                        poDtCabFact.Rows(intCont).Item("NCTDCC") = dblNumControl

                        For intRow = 0 To poDtDetFact.Rows.Count - 1
                            If poDtDetFact.Rows(intRow).Item("NDCCTC") = pintFact Then
                                ' poDtDetFact.Rows(intRow).Item("NDCCTC") = pintFact And Not (poDtDetFact.Rows(intRow).Item("CCNCSD") Is DBNull.Value)
                                objDet(0) = poDtDetFact.Rows(intRow).Item("CCMPN")
                                objDet(1) = poDtDetFact.Rows(intRow).Item("CTPODC")
                                objDet(2) = dblNumFactura
                                objDet(3) = poDtDetFact.Rows(intRow).Item("NINDRN")
                                objDet(4) = poDtDetFact.Rows(intRow).Item("NCRDCC")
                                objDet(5) = poDtDetFact.Rows(intRow).Item("CRBCTC")
                                objDet(6) = poDtDetFact.Rows(intRow).Item("STCCTC")
                                objDet(7) = poDtDetFact.Rows(intRow).Item("CUNCNA")
                                objDet(8) = poDtDetFact.Rows(intRow).Item("QAPCTC")
                                objDet(9) = poDtDetFact.Rows(intRow).Item("CUTCTC")
                                objDet(10) = poDtDetFact.Rows(intRow).Item("ITRCTC")
                                objDet(11) = poDtDetFact.Rows(intRow).Item("IVLDCS")
                                objDet(12) = poDtDetFact.Rows(intRow).Item("IVLDCD")
                                objDet(13) = dblNumControl
                                objDet(14) = poDtDetFact.Rows(intRow).Item("FDCCTC")
                                objDet(15) = poDtDetFact.Rows(intRow).Item("CDVSN")
                                objDet(16) = poDtDetFact.Rows(intRow).Item("CGRNGD")
                                objDet(17) = poDtDetFact.Rows(intRow).Item("CCNCSD")
                                'objDet(18) = poDtDetFact.Rows(intRow).Item("NOPRCN")
                                'objDet(19) = poDtDetFact.Rows(intRow).Item("NGUIRM")
                                objDataAccessLayer.Grabar_Detalle_Factura(objDet)
                                poDtDetFact.Rows(intRow).Item("NDCCTC") = dblNumFactura
                                poDtDetFact.Rows(intRow).Item("NCTDCC") = dblNumControl
                            End If
                        Next intRow

                        ''ACTUALIZACION SPOT
                        Try
                            Dim CCMPN As String = ("" & poDtCabFact.Rows(intCont).Item("CCMPN")).ToString.Trim
                            Dim CTPODC As Decimal = poDtCabFact.Rows(intCont).Item("CTPODC")
                            Dim NDCFCC As Decimal = dblNumFactura
                            ActualizarSPOT(CCMPN, CTPODC, NDCFCC)
                        Catch ex As Exception
                        End Try
                        '**********************
                        Try
                            Dim NUMDOC_GEN As Decimal = dblNumFactura
                            Dim CCMPN As String = ("" & poDtCabFact.Rows(intCont).Item("CCMPN")).ToString.Trim
                            Dim CTPDCO As Decimal = poDtCabFact.Rows(intCont).Item("CTPDCO")
                            Dim NDCMOR As Decimal = poDtCabFact.Rows(intCont).Item("NDCMOR")
                            Dim TIPOODC_GEN As Decimal = poDtCabFact.Rows(intCont).Item("CTPODC")
                            Dim CDVSN As String = ("" & poDtCabFact.Rows(intCont).Item("CDVSN")).ToString.Trim
                            RegistrarHistorialRefacturaRZCT34(CCMPN, CDVSN, CTPDCO, NDCMOR, TIPOODC_GEN, NUMDOC_GEN, oDtServicioActualizar, pintFact)
                        Catch ex As Exception
                        End Try

                        Exit For
                    End If
                Next intCont
                pstrNumFac = dblNumFactura
                Dim oDr() As DataRow
                Dim objFiltro As Hashtable
                oDr = oDtServicioActualizar.Select("NDCCTC = " & pintFact)
                For intContador As Integer = 0 To oDr.Length - 1
                    objFiltro = New Hashtable
                    objFiltro.Add("PNNOPRCN", oDr(intContador).Item("NOPRCN").ToString.Trim)
                    objFiltro.Add("PNNGUIRM", oDr(intContador).Item("NGUIRM").ToString.Trim)
                    objFiltro.Add("PNCRBCTC", oDr(intContador).Item("CRBCTC").ToString.Trim)
                    objFiltro.Add("PNQCNDTG", oDr(intContador).Item("QCNDTG")) 'CANTIDAD
                    objFiltro.Add("PSCUNDSR", oDr(intContador).Item("CUNDSR").ToString.Trim) 'CODIGO UNIDAD SERVICIO
                    objFiltro.Add("PNISRVGU", oDr(intContador).Item("ISRVGU")) 'IMPORTE
                    objFiltro.Add("PNCMNDGU", 1) 'CODIGO MONEDA
                    objFiltro.Add("PNCTPODC", poDtCabFact.Rows(0).Item("CTPODC"))
                    objFiltro.Add("PNNDCMFC", dblNumFactura)
                    objFiltro.Add("PNFECFAC", lintFecFac)
                    objFiltro.Add("PSCCMPN", poDtCabFact.Rows(0).Item("CCMPN").ToString.Trim)
                    objFiltro.Add("PNFLGFAC", pintFlagFac)
                    objFiltro.Add("PNPESOVOL", oDr(intContador).Item("PSOVOL").ToString.Trim)
                    objFiltro.Add("PNPESO", oDr(intContador).Item("PESO").ToString.Trim)

                    objDataAccessLayer.Actualizar_Detalle_Facturado_Lote(objFiltro)
                Next

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub Grabar_ReFactura(ByVal pintFact As Integer, ByRef poDtCabFact As DataTable, ByRef poDtDetFact As DataTable, ByRef pstrNumFac As Int64)
            Try
                Dim intCont As Integer
                Dim intRow As Integer
                Dim obj(2) As Object
                Dim objCab(35) As Object
                Dim objDet(20) As Object
                Dim oDt As DataTable
                Dim dblNumFactura As Int64
                Dim dblNumControl As Int64
                Dim lintFecFac As Int64 = 0

                For intCont = 0 To poDtCabFact.Rows.Count - 1
                    If poDtCabFact.Rows(intCont).Item("NDCCTC") = pintFact Then
                        objCab(0) = poDtCabFact.Rows(intCont).Item("CCMPN")
                        objCab(1) = strCodTabla
                        objCab(2) = poDtCabFact.Rows(intCont).Item("CTPODC")
                        objCab(3) = poDtCabFact.Rows(intCont).Item("NINDRN")
                        objCab(4) = poDtCabFact.Rows(intCont).Item("CDVSN")
                        objCab(5) = poDtCabFact.Rows(intCont).Item("CGRONG")
                        objCab(6) = poDtCabFact.Rows(intCont).Item("CZNFCC")
                        objCab(7) = poDtCabFact.Rows(intCont).Item("CCBRD")
                        objCab(8) = poDtCabFact.Rows(intCont).Item("CCLNT")
                        objCab(9) = poDtCabFact.Rows(intCont).Item("CPLNCL")
                        objCab(10) = poDtCabFact.Rows(intCont).Item("NRUC")
                        objCab(11) = poDtCabFact.Rows(intCont).Item("CSTCDC")
                        objCab(12) = poDtCabFact.Rows(intCont).Item("CPLNDV")
                        objCab(13) = poDtCabFact.Rows(intCont).Item("SABOPN")
                        objCab(14) = poDtCabFact.Rows(intCont).Item("FDCCTC")
                        objCab(15) = poDtCabFact.Rows(intCont).Item("CMNDA")
                        objCab(16) = poDtCabFact.Rows(intCont).Item("IVLAFS")
                        objCab(17) = poDtCabFact.Rows(intCont).Item("IVLNAS")
                        objCab(18) = poDtCabFact.Rows(intCont).Item("IVLIGS")
                        objCab(19) = poDtCabFact.Rows(intCont).Item("ITTFCS")
                        objCab(20) = poDtCabFact.Rows(intCont).Item("ITTPGS")
                        objCab(21) = poDtCabFact.Rows(intCont).Item("IVLAFD")
                        objCab(22) = poDtCabFact.Rows(intCont).Item("IVLNAD")
                        objCab(23) = poDtCabFact.Rows(intCont).Item("IVLIGD")
                        objCab(24) = poDtCabFact.Rows(intCont).Item("ITTFCD")
                        objCab(25) = poDtCabFact.Rows(intCont).Item("ITTPGD")
                        objCab(26) = poDtCabFact.Rows(intCont).Item("ITCCTC")
                        objCab(27) = poDtCabFact.Rows(intCont).Item("SFLLTR")
                        objCab(28) = poDtCabFact.Rows(intCont).Item("CZNCBD")
                        objCab(29) = poDtCabFact.Rows(intCont).Item("CCNCSC")
                        objCab(30) = CType(poDtCabFact.Rows(intCont).Item("NDSPGD"), Int32)
                        objCab(31) = poDtCabFact.Rows(intCont).Item("CRGVTA")
                        objCab(32) = poDtCabFact.Rows(intCont).Item("FATNSR")
                        objCab(33) = poDtCabFact.Rows(intCont).Item("CTPDCO")
                        objCab(34) = poDtCabFact.Rows(intCont).Item("NDCMOR")
                        objCab(35) = poDtCabFact.Rows(intCont).Item("FDCMOR")
                        lintFecFac = poDtCabFact.Rows(intCont).Item("FDCCTC")
                        oDt = objDataAccessLayer.Grabar_Cabecera_ReFactura(objCab)
                        dblNumFactura = oDt.Rows(0).Item("NULCTR")
                        dblNumControl = oDt.Rows(0).Item("NCTRRL")
                        poDtCabFact.Rows(intCont).Item("NDCCTC") = dblNumFactura
                        poDtCabFact.Rows(intCont).Item("NCTDCC") = dblNumControl

                        For intRow = 0 To poDtDetFact.Rows.Count - 1
                            If poDtDetFact.Rows(intRow).Item("NDCCTC") = pintFact Then
                                ' poDtDetFact.Rows(intRow).Item("NDCCTC") = pintFact And Not (poDtDetFact.Rows(intRow).Item("CCNCSD") Is DBNull.Value)
                                objDet(0) = poDtDetFact.Rows(intRow).Item("CCMPN")
                                objDet(1) = poDtDetFact.Rows(intRow).Item("CTPODC")
                                objDet(2) = dblNumFactura
                                objDet(3) = poDtDetFact.Rows(intRow).Item("NINDRN")
                                objDet(4) = poDtDetFact.Rows(intRow).Item("NCRDCC")
                                objDet(5) = poDtDetFact.Rows(intRow).Item("CRBCTC")
                                objDet(6) = poDtDetFact.Rows(intRow).Item("STCCTC")
                                objDet(7) = poDtDetFact.Rows(intRow).Item("CUNCNA")
                                objDet(8) = poDtDetFact.Rows(intRow).Item("QAPCTC")
                                objDet(9) = poDtDetFact.Rows(intRow).Item("CUTCTC")
                                objDet(10) = poDtDetFact.Rows(intRow).Item("ITRCTC")
                                objDet(11) = poDtDetFact.Rows(intRow).Item("IVLDCS")
                                objDet(12) = poDtDetFact.Rows(intRow).Item("IVLDCD")
                                objDet(13) = dblNumControl
                                objDet(14) = poDtDetFact.Rows(intRow).Item("FDCCTC")
                                objDet(15) = poDtDetFact.Rows(intRow).Item("CDVSN")
                                objDet(16) = poDtDetFact.Rows(intRow).Item("CGRNGD")
                                objDet(17) = poDtDetFact.Rows(intRow).Item("CCNCSD")
                                'objDet(18) = poDtDetFact.Rows(intRow).Item("NOPRCN")
                                'objDet(19) = poDtDetFact.Rows(intRow).Item("NGUIRM")
                                objDataAccessLayer.Grabar_Detalle_ReFactura(objDet)
                                poDtDetFact.Rows(intRow).Item("NDCCTC") = dblNumFactura
                                poDtDetFact.Rows(intRow).Item("NCTDCC") = dblNumControl
                            End If
                        Next intRow

                        'ACTUALIZACION SPOT
                        Try
                            Dim CCMPN As String = ("" & poDtCabFact.Rows(intCont).Item("CCMPN")).ToString.Trim
                            Dim CTPODC As Decimal = poDtCabFact.Rows(intCont).Item("CTPODC")
                            Dim NDCFCC As Decimal = dblNumFactura
                            ActualizarSPOT(CCMPN, CTPODC, NDCFCC)
                        Catch ex As Exception
                        End Try
                        '**********************
                        Try
                            Dim NUMDOC_GEN As Decimal = dblNumFactura
                            Dim CCMPN As String = ("" & poDtCabFact.Rows(intCont).Item("CCMPN")).ToString.Trim
                            Dim CTPDCO As Decimal = poDtCabFact.Rows(intCont).Item("CTPDCO")
                            Dim NDCMOR As Decimal = poDtCabFact.Rows(intCont).Item("NDCMOR")
                            Dim TIPOODC_GEN As Decimal = poDtCabFact.Rows(intCont).Item("CTPODC")
                            Dim CDVSN As String = ("" & poDtCabFact.Rows(intCont).Item("CDVSN")).ToString.Trim
                            RegistrarHistorialRefacturaRZCT34(CCMPN, CDVSN, CTPDCO, NDCMOR, TIPOODC_GEN, NUMDOC_GEN, oDtServicioActualizar, pintFact)
                        Catch ex As Exception
                        End Try

                        Exit For
                    End If
                Next intCont
                pstrNumFac = dblNumFactura
                Dim oDr() As DataRow
                Dim objFiltro As Hashtable
                'SI LA NOTA DE CREDITO ES PARCIAL

                oDr = oDtServicioActualizar.Select("NDCCTC = " & pintFact)
                For intContador As Integer = 0 To oDr.Length - 1
                    objFiltro = New Hashtable
                    objFiltro.Add("PNNOPRCN", oDr(intContador).Item("NOPRCN").ToString.Trim)
                    objFiltro.Add("PNNGUIRM", oDr(intContador).Item("NGUIRM").ToString.Trim)
                    objFiltro.Add("PNCRBCTC", oDr(intContador).Item("CRBCTC").ToString.Trim)
                    objFiltro.Add("PNCTPODC", poDtCabFact.Rows(0).Item("CTPODC"))
                    objFiltro.Add("PNNDCMFC", dblNumFactura)
                    objFiltro.Add("PNFECFAC", lintFecFac)
                    objFiltro.Add("PNQCNDTG", oDr(intContador).Item("QCNDTG")) 'CANTIDAD
                    objFiltro.Add("PSCUNDSR", oDr(intContador).Item("CUNDSR").ToString.Trim) 'CODIGO UNIDAD SERVICIO
                    objFiltro.Add("PNISRVGU", oDr(intContador).Item("ISRVGU")) 'IMPORTE ACTUAL
                    objFiltro.Add("PNCMNDGU", 1) 'CODIGO MONEDA
                    objFiltro.Add("PSCCMPN", poDtCabFact.Rows(0).Item("CCMPN"))
                    objFiltro.Add("PSLIBERAR", TraerEstadooperacion(oDr(intContador).Item("NOPRCN")))
                    objFiltro.Add("PNIVLRLV", oDr(intContador).Item("IVLRLV")) 'IMPORTE FACTURA
                    objFiltro.Add("PNCTPDCO", poDtCabFact.Rows(0).Item("CTPDCO"))
                    objFiltro.Add("PNNDCMOR", poDtCabFact.Rows(0).Item("NDCMOR"))
                    objDataAccessLayer.Actualizar_Detalle_ReFacturado(objFiltro)
                Next

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub
        Private Function TraerEstadooperacion(ByVal operacion As Double) As String
            Dim result As String = ""
            For i As Integer = 0 To ListaOperaciones.Count - 1
                If operacion = ListaOperaciones(i).Operacion Then
                    result = ListaOperaciones(i).Liberar
                    Exit For
                End If
            Next
            Return result
        End Function
        Public Sub Grabar_Referencia_Factura(ByVal pintFact As Int64, ByVal pintReferencia As Integer, ByVal poDtCabFact As DataTable, ByVal pstrObs As String)
            Try
                If pstrObs.Trim <> "" Then
                    Dim intCont As Integer
                    Dim intPos As Integer
                    Dim objObs(6) As Object
                    Dim strObs() As String
                    Dim strObservacion As String = ""

                    For intCont = 0 To poDtCabFact.Rows.Count - 1
                        If poDtCabFact.Rows(intCont).Item("NDCCTC") = pintFact Then
                            intPos = intCont
                            Exit For
                        End If
                    Next intCont
                    strObs = pstrObs.Split(vbCrLf)
                    For intCont = 0 To strObs.Length - 1
                        If strObs(intCont).Length > 70 Then
                            strObservacion = Mid(strObs(intCont), 1, 70)
                        Else
                            strObservacion = strObs(intCont).Trim
                        End If
                        objObs(0) = poDtCabFact.Rows(intPos).Item("CCMPN")
                        objObs(1) = poDtCabFact.Rows(intPos).Item("CTPODC")
                        objObs(2) = poDtCabFact.Rows(intPos).Item("NDCCTC")
                        objObs(3) = poDtCabFact.Rows(intPos).Item("NINDRN")
                        objObs(4) = pintReferencia
                        objObs(5) = strObservacion
                        objDataAccessLayer.Grabar_Referencia_Factura(objObs)
                    Next intCont
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub Actualizar_Detalle_Facturado(ByVal pobjFiltro As Hashtable)
            Try
                Dim strOperacion As String = pobjFiltro("PNNOPRCN")
                Dim strTemp As String = ""
                While strOperacion.Trim.Length > 1
                    If strOperacion.Trim.Contains(",") Then
                        strTemp = strOperacion.Substring(0, strOperacion.Trim.IndexOf(","))
                        strOperacion = strOperacion.Substring(strTemp.Trim.Length + 1)
                    Else
                        strTemp = strOperacion.Trim
                        strOperacion = strOperacion.Substring(strTemp.Trim.Length)
                    End If
                    pobjFiltro("PNNOPRCN") = strTemp
                    pobjFiltro("PSCCMPN") = pobjFiltro("PSCCMPN")

                    objDataAccessLayer.Actualizar_Detalle_Facturado(pobjFiltro)
                End While

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub Enviar_Documento_SAP(ByVal pobjFiltro As Hashtable)
            Try
                objDataAccessLayer.Enviar_Documento_SAP(pobjFiltro)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Function Comprobar_Envio_Documento_SAP(ByVal pobjFiltro As Hashtable) As DataTable
            Return objDataAccessLayer.Comprobar_Envio_Documento_SAP(pobjFiltro)
        End Function

        Public Function Registrar_Orden_Interna_Factura(ByVal pobjFiltro As Hashtable) As Int32
            Return objDataAccessLayer.Registrar_Orden_Interna_Factura(pobjFiltro)
        End Function

        Public Function Registrar_Orden_Interna_Factura_Lote(ByVal pobjFiltro As Hashtable) As Int32
            Return objDataAccessLayer.Registrar_Orden_Interna_Factura_Lote(pobjFiltro)
        End Function

        Public Function Cerrar_Orden_Interna_Factura(ByVal pobjFiltro As Hashtable) As Int32
            Return objDataAccessLayer.Cerrar_Orden_Interna_Factura(pobjFiltro)
        End Function

        Public Function Obtener_Fecha_Servidor() As Date
            Return objDataAccessLayer.Obtener_Fecha_Servidor
        End Function

        Public Function Obtener_Referencia_Ruta(ByVal pstrOperacion As String, ByVal strCodCom As String) As String
            Return objDataAccessLayer.Obtener_Referencia_Ruta(pstrOperacion, strCodCom)
        End Function

        Public Function Validar_Cliente_SAP(ByVal objParameter As Hashtable, ByRef strEstado As String) As String
            Dim strResultado As String = ""
            Dim strMensaje As String = ""
            strResultado = objDataAccessLayer.Validar_Cliente_SAP(objParameter)
            If strResultado <> "" Then
                strEstado = strResultado.Substring(0, 1)
                Select Case strEstado
                    Case "B"
                        strMensaje = strResultado.Substring(2)
                    Case "C"
                        strMensaje = strResultado.Substring(2)
                    Case "D"
                        strMensaje = strResultado.Substring(2)
                End Select

            End If
            Return strMensaje
        End Function

        Public Function Mostrar_Factura_Detallada(ByVal pobjFiltro As Hashtable, ByVal NroFactura As Int64, ByVal objDataDetallada As DataTable) As DataTable
            Dim objData As New DataTable
            Dim objDataDetalleResumen As DataTable = objDataDetallada.Clone
            Dim objDataDetalle As DataTable = objDataDetallada.Clone
            Dim intCount As Int16 = 0
            Dim NewRows As DataRow
            Dim oDr() As DataRow
            oDr = oDtServicioActualizar.Select("NDCCTC = " & NroFactura, "NOPRCN, NGUIRM DESC")
            'pobjFiltro.Add("PSCMNDA", strTipomoneda)
            objData = objDataAccessLayer.Mostrar_Factura_Detallada(pobjFiltro)
            For lintCount As Int32 = 0 To objData.Rows.Count - 1
                For lint As Int32 = 0 To oDr.Length - 1
                    If objData.Rows(lintCount).Item("NOPRCN") = oDr(lint)("NOPRCN") And objData.Rows(lintCount).Item("NGUIRM") = oDr(lint)("NGUIRM") _
                           And objData.Rows(lintCount).Item("CSRVC") = oDr(lint)("CRBCTC") Then
                        intCount += 1
                        If intCount = 1 Then
                            NewRows = objDataDetalleResumen.NewRow
                            NewRows("CCMPN") = objDataDetallada.Rows(0).Item("CCMPN")
                            NewRows("CTPODC") = objDataDetallada.Rows(0).Item("CTPODC")
                            NewRows("NDCCTC") = NroFactura 'objDataDetallada.Rows(0).Item("NDCCTC")
                            NewRows("NINDRN") = objDataDetallada.Rows(0).Item("NINDRN")
                            NewRows("NCRDCC") = lintCount + 1
                            NewRows("CRBCTC") = objData.Rows(lintCount).Item("CSRVC") & "   " & objData.Rows(lintCount).Item("TCMTRF").ToString.Trim
                            NewRows("STCCTC") = objData.Rows(lintCount).Item("RUTA").ToString.Trim
                            NewRows("CUNCNA") = objData.Rows(lintCount).Item("CUNCNA").ToString.Trim
                            NewRows("QAPCTC") = objData.Rows(lintCount).Item("QAPCTC")
                            NewRows("CUTCTC") = objDataDetallada.Rows(0).Item("CUTCTC")
                            If objDataDetallada.Rows(0).Item("CUTCTC") = "SOL" Then
                                NewRows("ITRCTC") = Format(objData.Rows(lintCount).Item("IVLDCS"), "###,###,###,###.00000")
                            Else
                                NewRows("ITRCTC") = Format(objData.Rows(lintCount).Item("IVLDCD"), "###,###,###,###.00000")
                            End If
                            NewRows("IVLDCS") = Format(objData.Rows(lintCount).Item("IVLDCS"), "###,###,###,###.00000") 'CType(objData.Rows(lintCount).Item("IVLDCS"), Double)
                            NewRows("IVLDCD") = Format(objData.Rows(lintCount).Item("IVLDCD"), "###,###,###,###.00000") 'CType(objData.Rows(lintCount).Item("IVLDCD"), Double)
                            NewRows("NCTDCC") = objDataDetallada.Rows(0).Item("NCTDCC")
                            NewRows("FDCCTC") = objDataDetallada.Rows(0).Item("FDCCTC")
                            NewRows("CDVSN") = objDataDetallada.Rows(0).Item("CDVSN")
                            NewRows("CGRNGD") = objDataDetallada.Rows(0).Item("CGRNGD")
                            NewRows("CCNCSD") = objDataDetallada.Rows(0).Item("CCNCSD")
                            objDataDetalleResumen.Rows.Add(NewRows)
                        End If
                    End If
                Next
                intCount = 0
            Next
            Dim strRuta As String = ""
            Dim strServicio As String = ""
            Dim dblTarifa As String = "0"
            Dim strUnidad As String = ""
            Dim oDrResumen() As DataRow
            Dim objDataPrueba As DataTable = objDataDetalleResumen.Clone
            Dim intNroViajes As Int32 = 0
            Dim lintItem As Int32 = 0
            While (1)
                If objDataDetalleResumen.Rows.Count = 0 Then Exit While
                strServicio = objDataDetalleResumen.Rows(0).Item("CRBCTC").ToString.Trim
                strRuta = objDataDetalleResumen.Rows(0).Item("STCCTC").ToString.Trim
                If objDataDetalleResumen.Rows(0).Item("CUTCTC") = "SOL" Then
                    dblTarifa = objDataDetalleResumen.Rows(0).Item("IVLDCS")
                Else
                    dblTarifa = objDataDetalleResumen.Rows(0).Item("IVLDCD")
                End If
                strUnidad = objDataDetalleResumen.Rows(0).Item("CUNCNA").ToString.Trim
                oDrResumen = objDataDetalleResumen.Select("TRIM(CRBCTC) = '" & Trim(strServicio) & "' AND TRIM(STCCTC) = '" & strRuta & "' AND ITRCTC = '" & dblTarifa & "' AND TRIM(CUNCNA) = '" & strUnidad & "'")
                NewRows = objDataPrueba.NewRow
                Dim dblCantidad As Double = Suma_Cantidad_Detallada(oDrResumen)
                lintItem += 1
                NewRows("CCMPN") = objDataDetalleResumen.Rows(0).Item("CCMPN")
                NewRows("CTPODC") = objDataDetalleResumen.Rows(0).Item("CTPODC")
                NewRows("NDCCTC") = objDataDetalleResumen.Rows(0).Item("NDCCTC")
                NewRows("NINDRN") = objDataDetalleResumen.Rows(0).Item("NINDRN")
                NewRows("NCRDCC") = lintItem
                NewRows("CRBCTC") = objDataDetalleResumen.Rows(0).Item("CRBCTC")
                NewRows("STCCTC") = objDataDetalleResumen.Rows(0).Item("STCCTC")
                NewRows("CUNCNA") = objDataDetalleResumen.Rows(0).Item("CUNCNA")
                NewRows("QAPCTC") = dblCantidad 'oDrResumen.Length
                NewRows("CUTCTC") = objDataDetalleResumen.Rows(0).Item("CUTCTC")
                If objDataDetalleResumen.Rows(0).Item("CUTCTC") = "SOL" Then
                    NewRows("ITRCTC") = objDataDetalleResumen.Rows(0).Item("IVLDCS")
                Else
                    NewRows("ITRCTC") = objDataDetalleResumen.Rows(0).Item("IVLDCD")
                End If
                NewRows("IVLDCS") = (objDataDetalleResumen.Rows(0).Item("IVLDCS") * dblCantidad)
                NewRows("IVLDCD") = (objDataDetalleResumen.Rows(0).Item("IVLDCD") * dblCantidad)
                NewRows("NCTDCC") = objDataDetalleResumen.Rows(0).Item("NCTDCC")
                NewRows("FDCCTC") = objDataDetalleResumen.Rows(0).Item("FDCCTC")
                NewRows("CDVSN") = objDataDetalleResumen.Rows(0).Item("CDVSN")
                NewRows("CGRNGD") = objDataDetalleResumen.Rows(0).Item("CGRNGD")
                NewRows("CCNCSD") = objDataDetalleResumen.Rows(0).Item("CCNCSD")
                objDataPrueba.Rows.Add(NewRows)
                Eliminar_Rows_Servicios_Detallado(objDataDetalleResumen, strServicio, strRuta, dblTarifa, strUnidad)
            End While

            Return objDataPrueba
        End Function

        Public Function Mostrar_Factura_Consolidada(ByVal pobjFiltro As Hashtable, ByVal NroFactura As Int64, ByVal objDataDetallada As DataTable) As DataTable
            Dim objData As New DataTable
            Dim objDataDetalleResumen As DataTable = objDataDetallada.Clone
            Dim objDataDetalle As DataTable = objDataDetallada.Clone
            Dim intCount As Int16 = 0
            Dim NewRows As DataRow
            Dim oDr() As DataRow
            Dim dtAntes As DataTable = objDataDetallada.Copy
            oDr = oDtServicioActualizar.Select("NDCCTC = " & NroFactura, "NOPRCN, NGUIRM DESC")
            'pobjFiltro.Add("PSCMNDA", strTipomoneda)
            'lista detallados
            objData = objDataAccessLayer.Mostrar_Factura_Detallada(pobjFiltro)
            'agregado
            For lintCount As Int32 = 0 To objData.Rows.Count - 1
                For lint As Int32 = 0 To oDr.Length - 1
                    If objData.Rows(lintCount).Item("NOPRCN") = oDr(lint)("NOPRCN") And objData.Rows(lintCount).Item("NGUIRM") = oDr(lint)("NGUIRM") _
                           And objData.Rows(lintCount).Item("CSRVC") = oDr(lint)("CRBCTC") Then
                        intCount += 1
                        If intCount = 1 Then
                            NewRows = objDataDetalleResumen.NewRow
                            NewRows("CCMPN") = objDataDetallada.Rows(0).Item("CCMPN")
                            NewRows("CTPODC") = objDataDetallada.Rows(0).Item("CTPODC")
                            NewRows("NDCCTC") = NroFactura 'objDataDetallada.Rows(0).Item("NDCCTC")
                            NewRows("NINDRN") = objDataDetallada.Rows(0).Item("NINDRN")
                            NewRows("NCRDCC") = lintCount + 1
                            NewRows("CRBCTC") = objData.Rows(lintCount).Item("CSRVC") & "   " & objData.Rows(lintCount).Item("TCMTRF").ToString.Trim
                            NewRows("STCCTC") = objData.Rows(lintCount).Item("RUTA").ToString.Trim
                            NewRows("CUNCNA") = objData.Rows(lintCount).Item("CUNCNA").ToString.Trim
                            NewRows("QAPCTC") = objData.Rows(lintCount).Item("QAPCTC")
                            NewRows("CUTCTC") = objDataDetallada.Rows(0).Item("CUTCTC")
                            If objDataDetallada.Rows(0).Item("CUTCTC") = "SOL" Then
                                NewRows("ITRCTC") = Format(objData.Rows(lintCount).Item("IVLDCS"), "###,###,###,###.00000")
                                'NewRows("ITRCTC") = Format(Convert.ToDouble(objDataDetallada.Rows(0).Item("IVLDCS")), "###,###,###,###.00000")
                            Else
                                NewRows("ITRCTC") = Format(objData.Rows(lintCount).Item("IVLDCD"), "###,###,###,###.00000")
                            End If
                            NewRows("IVLDCS") = Format(objData.Rows(lintCount).Item("IVLDCS"), "###,###,###,###.00000") 'Convert.ToDouble(objDataDetallada.Rows(0).Item("IVLDCS")) ' 'CType(objData.Rows(lintCount).Item("IVLDCS"), Double)
                            NewRows("IVLDCD") = Format(objData.Rows(lintCount).Item("IVLDCD"), "###,###,###,###.00000") 'Convert.ToDouble(objDataDetallada.Rows(0).Item("IVLDCD")) ' 'CType(objData.Rows(lintCount).Item("IVLDCD"), Double)
                            NewRows("NCTDCC") = objDataDetallada.Rows(0).Item("NCTDCC")
                            NewRows("FDCCTC") = objDataDetallada.Rows(0).Item("FDCCTC")
                            NewRows("CDVSN") = objDataDetallada.Rows(0).Item("CDVSN")
                            NewRows("CGRNGD") = objDataDetallada.Rows(0).Item("CGRNGD")
                            NewRows("CCNCSD") = objDataDetallada.Rows(0).Item("CCNCSD")
                            objDataDetalleResumen.Rows.Add(NewRows)
                        End If
                    End If
                Next
                intCount = 0
            Next
            Dim strRuta As String = ""
            Dim strServicio As String = ""
            Dim dblTarifa As String = "0"
            Dim strUnidad As String = ""
            Dim oDrResumen() As DataRow
            Dim objDataPrueba As DataTable = objDataDetalleResumen.Clone
            Dim intNroViajes As Int32 = 0
            Dim lintItem As Int32 = 0
            While (1)
                If objDataDetalleResumen.Rows.Count = 0 Then Exit While
                strServicio = objDataDetalleResumen.Rows(0).Item("CRBCTC").ToString.Trim
                strRuta = objDataDetalleResumen.Rows(0).Item("STCCTC").ToString.Trim
                If objDataDetalleResumen.Rows(0).Item("CUTCTC") = "SOL" Then
                    dblTarifa = objDataDetalleResumen.Rows(0).Item("IVLDCS")
                Else
                    dblTarifa = objDataDetalleResumen.Rows(0).Item("IVLDCD")
                End If
                strUnidad = objDataDetalleResumen.Rows(0).Item("CUNCNA").ToString.Trim
                oDrResumen = objDataDetalleResumen.Select("TRIM(CRBCTC) = '" & Trim(strServicio) & "'")
                NewRows = objDataPrueba.NewRow
                'Dim dblCantidad As Double = Suma_Cantidad_Detallada(oDrResumen)
                Dim dblImporte As Double = Suma_Cantidad_Importe_Soles(oDrResumen)

                lintItem += 1
                NewRows("CCMPN") = objDataDetalleResumen.Rows(0).Item("CCMPN")
                NewRows("CTPODC") = objDataDetalleResumen.Rows(0).Item("CTPODC")
                NewRows("NDCCTC") = objDataDetalleResumen.Rows(0).Item("NDCCTC")
                NewRows("NINDRN") = objDataDetalleResumen.Rows(0).Item("NINDRN")
                NewRows("NCRDCC") = lintItem
                NewRows("CRBCTC") = objDataDetalleResumen.Rows(0).Item("CRBCTC")
                NewRows("STCCTC") = "" 'objDataDetalleResumen.Rows(0).Item("STCCTC")
                NewRows("CUNCNA") = "UNI"
                NewRows("QAPCTC") = 1 'dblCantidad 'oDrResumen.Length
                NewRows("CUTCTC") = objDataDetalleResumen.Rows(0).Item("CUTCTC")
                If objDataDetalleResumen.Rows(0).Item("CUTCTC") = "SOL" Then
                    NewRows("ITRCTC") = dblImporte
                Else
                    NewRows("ITRCTC") = dblImporte / TipoCambio
                End If
                NewRows("IVLDCS") = (dblImporte)
                NewRows("IVLDCD") = (dblImporte / TipoCambio)
                NewRows("NCTDCC") = objDataDetalleResumen.Rows(0).Item("NCTDCC")
                NewRows("FDCCTC") = objDataDetalleResumen.Rows(0).Item("FDCCTC")
                NewRows("CDVSN") = objDataDetalleResumen.Rows(0).Item("CDVSN")
                NewRows("CGRNGD") = objDataDetalleResumen.Rows(0).Item("CGRNGD")
                NewRows("CCNCSD") = objDataDetalleResumen.Rows(0).Item("CCNCSD")
                objDataPrueba.Rows.Add(NewRows)
                Eliminar_Rows_Servicios_Consolidado(objDataDetalleResumen, strServicio)
            End While

            Return objDataPrueba
        End Function

        Public Function Mostrar_ReFactura_Consolidada(ByVal pobjFiltro As Hashtable, ByVal NroFactura As Int64, ByVal objDataDetallada As DataTable, Optional ByVal TNC As Integer = 0, Optional ByVal TipoCambioFactura As Double = 0) As DataTable
            Dim objData As New DataTable
            Dim objDataDetalleResumen As DataTable = objDataDetallada.Clone
            Dim objDataDetalle As DataTable = objDataDetallada.Clone
            Dim intCount As Int16 = 0
            Dim NewRows As DataRow
            Dim oDr() As DataRow
            oDr = oDtServicioActualizar.Select("NDCCTC = " & NroFactura, "NOPRCN, NGUIRM DESC")
            'pobjFiltro.Add("PSCMNDA", strTipomoneda)
            'lista detallados
            objData = objDataAccessLayer.Mostrar_ReFactura_Detallada(pobjFiltro) 'ORDENADO POR OPERACION Y GUIA

            For lintCount As Int32 = 0 To objData.Rows.Count - 1
                For lint As Int32 = 0 To oDr.Length - 1
                    If objData.Rows(lintCount).Item("NOPRCN") = oDr(lint)("NOPRCN") And objData.Rows(lintCount).Item("NGUIRM") = oDr(lint)("NGUIRM") _
                           And objData.Rows(lintCount).Item("CSRVC") = oDr(lint)("CRBCTC") Then
                        intCount += 1
                        If intCount = 1 Then
                            NewRows = objDataDetalleResumen.NewRow
                            NewRows("CCMPN") = objDataDetallada.Rows(0).Item("CCMPN")
                            NewRows("CTPODC") = objDataDetallada.Rows(0).Item("CTPODC")
                            NewRows("NDCCTC") = NroFactura 'objDataDetallada.Rows(0).Item("NDCCTC")
                            NewRows("NINDRN") = objDataDetallada.Rows(0).Item("NINDRN")
                            NewRows("NCRDCC") = lintCount + 1
                            NewRows("CRBCTC") = objData.Rows(lintCount).Item("CSRVC") & "   " & objData.Rows(lintCount).Item("TCMTRF").ToString.Trim
                            NewRows("STCCTC") = objData.Rows(lintCount).Item("RUTA").ToString.Trim
                            NewRows("CUNCNA") = objData.Rows(lintCount).Item("CUNCNA").ToString.Trim
                            NewRows("QAPCTC") = objData.Rows(lintCount).Item("QAPCTC")
                            NewRows("CUTCTC") = objDataDetallada.Rows(0).Item("CUTCTC")
                            If objDataDetallada.Rows(0).Item("CUTCTC") = "SOL" Then
                                NewRows("ITRCTC") = Format(objData.Rows(lintCount).Item("IVLDCS"), "###,###,###,###.00000")
                                'NewRows("ITRCTC") = Format(Convert.ToDouble(objDataDetallada.Rows(0).Item("IVLDCS")), "###,###,###,###.00000")
                            Else
                                NewRows("ITRCTC") = Format(objData.Rows(lintCount).Item("IVLDCD"), "###,###,###,###.00000")
                            End If
                            NewRows("IVLDCS") = Format(objData.Rows(lintCount).Item("IVLDCS"), "###,###,###,###.00000") 'Convert.ToDouble(objDataDetallada.Rows(0).Item("IVLDCS")) ' 'CType(objData.Rows(lintCount).Item("IVLDCS"), Double)
                            NewRows("IVLDCD") = Format(objData.Rows(lintCount).Item("IVLDCD"), "###,###,###,###.00000") 'Convert.ToDouble(objDataDetallada.Rows(0).Item("IVLDCD")) ' 'CType(objData.Rows(lintCount).Item("IVLDCD"), Double)
                            NewRows("NCTDCC") = objDataDetallada.Rows(0).Item("NCTDCC")
                            NewRows("FDCCTC") = objDataDetallada.Rows(0).Item("FDCCTC")
                            NewRows("CDVSN") = objDataDetallada.Rows(0).Item("CDVSN")
                            NewRows("CGRNGD") = objDataDetallada.Rows(0).Item("CGRNGD")
                            NewRows("CCNCSD") = objDataDetallada.Rows(0).Item("CCNCSD")
                            objDataDetalleResumen.Rows.Add(NewRows)
                        End If
                    End If
                Next
                intCount = 0
            Next
            Dim strRuta As String = ""
            Dim strServicio As String = ""
            Dim dblTarifa As String = "0"
            Dim strUnidad As String = ""
            Dim oDrResumen() As DataRow
            Dim objDataPrueba As DataTable = objDataDetalleResumen.Clone
            Dim intNroViajes As Int32 = 0
            Dim lintItem As Int32 = 0
            While (1)
                If objDataDetalleResumen.Rows.Count = 0 Then Exit While
                strServicio = objDataDetalleResumen.Rows(0).Item("CRBCTC").ToString.Trim
                strRuta = objDataDetalleResumen.Rows(0).Item("STCCTC").ToString.Trim
                If objDataDetalleResumen.Rows(0).Item("CUTCTC") = "SOL" Then
                    dblTarifa = objDataDetalleResumen.Rows(0).Item("IVLDCS")
                Else
                    dblTarifa = objDataDetalleResumen.Rows(0).Item("IVLDCD")
                End If
                strUnidad = objDataDetalleResumen.Rows(0).Item("CUNCNA").ToString.Trim
                oDrResumen = objDataDetalleResumen.Select("TRIM(CRBCTC) = '" & Trim(strServicio) & "'")
                NewRows = objDataPrueba.NewRow
                'Dim dblCantidad As Double = Suma_Cantidad_Detallada(oDrResumen)
                Dim dblImporte As Double = Suma_Cantidad_Importe_Soles(oDrResumen)

                lintItem += 1
                NewRows("CCMPN") = objDataDetalleResumen.Rows(0).Item("CCMPN")
                NewRows("CTPODC") = objDataDetalleResumen.Rows(0).Item("CTPODC")
                NewRows("NDCCTC") = objDataDetalleResumen.Rows(0).Item("NDCCTC")
                NewRows("NINDRN") = objDataDetalleResumen.Rows(0).Item("NINDRN")
                NewRows("NCRDCC") = lintItem
                NewRows("CRBCTC") = objDataDetalleResumen.Rows(0).Item("CRBCTC")
                NewRows("STCCTC") = "" 'objDataDetalleResumen.Rows(0).Item("STCCTC")
                NewRows("CUNCNA") = "UNI"
                NewRows("QAPCTC") = 1 'dblCantidad 'oDrResumen.Length
                NewRows("CUTCTC") = objDataDetalleResumen.Rows(0).Item("CUTCTC")
                If objDataDetalleResumen.Rows(0).Item("CUTCTC") = "SOL" Then
                    NewRows("ITRCTC") = dblImporte
                Else
                    NewRows("ITRCTC") = dblImporte / IIf(objDataDetalleResumen.Rows(0).Item("CTPODC") = 2, dblTipoCambio, ListaOperaciones(0).TipoCambioFactura)
                End If
                NewRows("IVLDCS") = (dblImporte)
                NewRows("IVLDCD") = (dblImporte / IIf(objDataDetalleResumen.Rows(0).Item("CTPODC") = 2, dblTipoCambio, ListaOperaciones(0).TipoCambioFactura))
                NewRows("NCTDCC") = objDataDetalleResumen.Rows(0).Item("NCTDCC")
                NewRows("FDCCTC") = objDataDetalleResumen.Rows(0).Item("FDCCTC")
                NewRows("CDVSN") = objDataDetalleResumen.Rows(0).Item("CDVSN")
                NewRows("CGRNGD") = objDataDetalleResumen.Rows(0).Item("CGRNGD")
                NewRows("CCNCSD") = objDataDetalleResumen.Rows(0).Item("CCNCSD")
                objDataPrueba.Rows.Add(NewRows)
                Eliminar_Rows_Servicios_Consolidado(objDataDetalleResumen, strServicio)
            End While

            Return objDataPrueba
        End Function
        Private Sub ActualizarServicios(ByVal NOPRCN As Double, ByVal CSRVC As Integer, ByVal QAPCTC As Integer, ByVal TARIFA As Double)
            For Indice As Integer = 0 To oDtServicioActualizar.Rows.Count - 1
                If oDtServicioActualizar.Rows(Indice).Item("ISRVGU") = NOPRCN And oDtServicioActualizar.Rows(Indice).Item("ISRVGU") = CSRVC And oDtServicioActualizar.Rows(Indice).Item("ISRVGU") = QAPCTC Then
                    oDtServicioActualizar.Rows(Indice).Item("ISRVGU") = TARIFA
                End If
            Next
        End Sub
        Private Function Suma_Cantidad_Importe_Soles(ByVal oDrResumen() As DataRow) As Double
            Dim dblImporte As Double = 0
            For intIndice As Int32 = 0 To oDrResumen.Length - 1
                dblImporte += (oDrResumen(intIndice).Item(8) * oDrResumen(intIndice).Item(11))
            Next
            Return dblImporte
        End Function

        Private Function Suma_Cantidad_Detallada(ByVal oDrResumen() As DataRow) As Double
            Dim dblCantidad As Double = 0
            For intIndice As Int32 = 0 To oDrResumen.Length - 1
                dblCantidad += oDrResumen(intIndice).Item(8)
            Next
            Return dblCantidad
        End Function

        Private Sub Eliminar_Rows_Servicios_Detallado(ByRef poDt As DataTable, ByVal strServicio As String, ByVal strRuta As String, ByVal dblTarifa As Double, ByVal strUnidad As String)
            Dim intCont As Integer

            For intCont = poDt.Rows.Count - 1 To 0 Step -1
                If poDt.Rows(intCont).Item("CRBCTC").ToString.Trim = strServicio And poDt.Rows(intCont).Item("STCCTC").ToString.Trim = strRuta And poDt.Rows(intCont).Item("ITRCTC") = dblTarifa And poDt.Rows(intCont).Item("CUNCNA").ToString.Trim = strUnidad Then
                    poDt.Rows.RemoveAt(intCont)
                End If
            Next intCont
        End Sub

        Private Sub Eliminar_Rows_Servicios_Consolidado(ByRef poDt As DataTable, ByVal strServicio As String)
            Dim intCont As Integer

            For intCont = poDt.Rows.Count - 1 To 0 Step -1
                If poDt.Rows(intCont).Item("CRBCTC").ToString.Trim = strServicio Then
                    poDt.Rows.RemoveAt(intCont)
                End If
            Next intCont
        End Sub
        Public Function Listar_Facturas_X_Operaciones_Liberadas(ByVal pobjFiltro As Hashtable) As DataTable
            Dim Factura_TransporteDAL As New Factura_Transporte_DAL
            Return Factura_TransporteDAL.Listar_Facturas_X_Operaciones_Liberadas(pobjFiltro)
        End Function

        Public Function Listar_Importes_Servicio_Operaciones(ByVal objParametro As Hashtable) As DataTable
            Return objDataAccessLayer.Listar_Importes_Servicio_Operaciones(objParametro)
        End Function

        Public Function Actualizar_Facturacion_Libre(ByVal pobjFiltro As Hashtable) As Int32
            Try
                Dim strOperacion As String = pobjFiltro("PNNOPRCN2")
                Dim strTemp As String = ""
                While strOperacion.Trim.Length > 1
                    If strOperacion.Trim.Contains(",") Then
                        strTemp = strOperacion.Substring(0, strOperacion.Trim.IndexOf(","))
                        strOperacion = strOperacion.Substring(strTemp.Trim.Length + 1)
                    Else
                        strTemp = strOperacion.Trim
                        strOperacion = strOperacion.Substring(strTemp.Trim.Length)
                    End If
                    pobjFiltro("PNNOPRCN2") = strTemp
                    pobjFiltro("PSCCMPN") = pobjFiltro("PSCCMPN")
                    objDataAccessLayer.Actualizar_Facturacion_Libre(pobjFiltro)
                End While
                Return 0
            Catch ex As Exception
                'Throw New Exception(ex.Message)
                Return 1
            End Try
        End Function

        Public Function Validar_Facturacion_Libre(ByVal pobjFiltro As Hashtable, ByRef sErrorMesage As String) As Boolean
            Dim bResultado As Boolean = True
            Try
                'Dim strOperacion As String = pobjFiltro("PNNOPRCN")
                'Dim strTemp As String = ""
                'While strOperacion.Trim.Length > 1
                'If strOperacion.Trim.Contains(",") Then
                'strTemp = strOperacion.Substring(0, strOperacion.Trim.IndexOf(","))
                'strOperacion = strOperacion.Substring(strTemp.Trim.Length + 1)
                'Else
                'strTemp = strOperacion.Trim
                'strOperacion = strOperacion.Substring(strTemp.Trim.Length)
                'End If
                'pobjFiltro("PNNOPRCN") = strTemp
                'pobjFiltro("PSCCMPN") = pobjFiltro("PSCCMPN")

                bResultado = objDataAccessLayer.Validar_Facturacion_Libre(pobjFiltro, sErrorMesage)
                'If sErrorMesage <> "" Then
                'Exit While
                'End If
                'End While
                Return bResultado
            Catch ex As Exception
                sErrorMesage = ex.Message
                bResultado = False
            End Try
        End Function
    End Class

End Namespace
