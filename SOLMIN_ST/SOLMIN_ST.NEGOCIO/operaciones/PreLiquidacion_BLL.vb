Imports SOLMIN_ST.DATOS.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones

Namespace Operaciones
  Public Class PreLiquidacion_BLL
    Private objDataAccessLayer As New PreLiquidacion_DAL

        Public Function Listar_Operaciones_PreLiquidacion(ByVal objParametros As Hashtable) As DataTable
            Return objDataAccessLayer.Listar_Operaciones_PreLiquidacion(objParametros)
        End Function

        Public Function Listar_Operaciones_PreFactura(ByVal objParametros As Hashtable) As DataTable
            Return objDataAccessLayer.Listar_Operaciones_PreFactura(objParametros)
        End Function

        Public Function Listar_PreLiquidacion_Factura(ByVal objetoParametro As Hashtable) As List(Of OperacionTransporte)
            Return objDataAccessLayer.Listar_PreLiquidacion_Factura(objetoParametro)
        End Function

    Public Function Listar_PreFactura_Factura(ByVal objetoParametro As Hashtable) As List(Of OperacionTransporte)
      Return objDataAccessLayer.Listar_PreFactura_Factura(objetoParametro)
    End Function

    Public Function Listar_PreFactura(ByVal objetoParametro As Hashtable) As List(Of Factura_Transporte)
      Return objDataAccessLayer.Listar_PreFactura(objetoParametro)
    End Function

    Public Function ListarPreFacturas_x_PreLiquidacion(ByVal objetoParametro As Hashtable) As List(Of Factura_Transporte)
      Return objDataAccessLayer.ListarPreFacturas_x_PreLiquidacion(objetoParametro)
    End Function
    Public Function Listar_Liquidacion(ByVal objetoParametro As Hashtable) As List(Of Factura_Transporte)
      Return objDataAccessLayer.Listar_Liquidacion(objetoParametro)
    End Function

    Public Function Obtener_Nro_PreLiquidacion(ByVal objetoParametro As Hashtable) As Integer
      Return objDataAccessLayer.Obtener_Nro_PreLiquidacion(objetoParametro)
    End Function

        Public Function Registrar_PreLiquidacion(ByVal objEntidad As Factura_Transporte, ByVal NDCPRF As String, ByRef NPRLQD As Decimal, ACCION As String) As String
            'Try
            '    'For Each objEntidad As Factura_Transporte In objListFactura_Transporte
            'Next
            Return objDataAccessLayer.Registrar_PreLiquidacion(objEntidad, NDCPRF, NPRLQD, ACCION)
            'Catch ex As Exception
            '    Return 0
            'End Try
        End Function

    Public Function Imprimir_Reporte_Pre_Liquidacion(ByVal objEntidad As List(Of String)) As DataSet
      Return objDataAccessLayer.Imprimir_Reporte_Pre_Liquidacion(objEntidad)
    End Function

    Public Function Imprimir_Consistencia_Pre_Liquidacion(ByVal objEntidad As List(Of String)) As DataSet
      Return objDataAccessLayer.Imprimir_Consistencia_Pre_Liquidacion(objEntidad)
    End Function

    Public Function ObtenerTipoReportePreLiquidacion(ByVal objEntidad As Factura_Transporte) As DataTable
      Return objDataAccessLayer.ObtenerTipoReportePreLiquidacion(objEntidad)
    End Function

    Public Function Obtener_Reporte_Resumen_X_Lote(ByVal objEntidad As Factura_Transporte) As DataTable
      Return objDataAccessLayer.Obtener_Reporte_Resumen_X_Lote(objEntidad)
    End Function



    Public Function Lista_Operacion_Liquidacion(ByVal objListFactura_Transporte As List(Of Factura_Transporte)) As String
      Dim ListaNOPRCN As String = ""
      Dim iCont As Integer = 0
      Dim objGenericCollection As New List(Of Factura_Transporte)
            'Try
            For Each objEntidad As Factura_Transporte In objListFactura_Transporte
                objGenericCollection = objDataAccessLayer.Lista_Operacion_Liquidacion(objEntidad)
                For Each objEntidad2 As Factura_Transporte In objGenericCollection
                    ListaNOPRCN = ListaNOPRCN & objEntidad2.NOPRCN & ","
                Next
            Next
            Return ListaNOPRCN
            'Catch ex As Exception
            '          Return ""
            '      End Try
    End Function

        Public Sub Anular_Pre_Factura(ByVal objListFactura_Transporte As List(Of Factura_Transporte))
            'Try
            For Each objEntidad As Factura_Transporte In objListFactura_Transporte
                objDataAccessLayer.Anular_PreFactura(objEntidad)
            Next
            '      Return 1
            'Catch ex As Exception
            '          Return 0
            '      End Try

        End Sub

    Public Function Quitar_Pre_Factura(ByVal objListFactura_Transporte As List(Of Factura_Transporte)) As Integer
      Try
        For Each objEntidad As Factura_Transporte In objListFactura_Transporte
          objDataAccessLayer.Quitar_Pre_Factura(objEntidad)
        Next
        Return 1
      Catch ex As Exception
        Return 0
      End Try

    End Function

        Public Sub Anular_Pre_Liquidacion(ByVal objListFactura_Transporte As List(Of Factura_Transporte))
            'Try
            For Each objEntidad As Factura_Transporte In objListFactura_Transporte
                objDataAccessLayer.Anular_PreLiquidacion(objEntidad)
            Next
            '      Return 1
            'Catch ex As Exception
            '          Return 0
            '      End Try

        End Sub

    'Public Function ListarMovimiento_PreLiquidacion(ByVal objParametros As Hashtable) As DataTable
    '  Return objDataAccessLayer.ListarMovimiento_PreLiquidacion(objParametros)
    'End Function

    Public Function ListarMovimiento_PreLiquidacion(ByVal objParametros As Hashtable) As DataTable
      Dim ObjDespachoMovimientos_BE As New DataTable
      ObjDespachoMovimientos_BE = objDataAccessLayer.ListarMovimiento_PreLiquidacion(objParametros)

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
        For Each dc As Data.DataColumn In objResumenFin.Columns
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
                                         AndAlso Not (dc.ColumnName.EndsWith("_FCHFTR")) Then
            If IsDBNull(drSelect(0)(value)) Then
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

        'For jj As Integer = 0 To ObjDespachoMovimientos_BE.Columns.Count - 13
        '    objDataRow.Item(jj) = drSelect(0)(jj).ToString
        'Next

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
            'objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item(j.ToString.Trim + "_NCSOTR") = dr("NCSOTR").ToString.Trim
            objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item(j.ToString.Trim + "_FCHFTR") = dr("FCHFTR").ToString.Trim
            objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item(j.ToString.Trim + "_IMPORTE") = dr("IMPORTE").ToString.Trim

            strMedioAnterior = dr("MEDENVIO").ToString.Trim
            objResumenFin.AcceptChanges()
          Else
            ''''''''''''''''''''''''''''''''''''''''''''''''
            Dim objDataRow2 As DataRow = Nothing
            objDataRow2 = objResumenFin.NewRow
            If drSelect.Length > 1 Then

              For Each dc As Data.DataColumn In objResumenFin.Columns
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
              'objResumenFin.Rows(objResumenFin.Rows.Count - 1).Item(j.ToString.Trim + "_NCSOTR") = dr("NCSOTR").ToString.Trim
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
      Dim colum As New Data.DataColumn
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


      objResumenFin = dvR.ToTable

      Return objResumenFin

    End Function

    Public Function CrearResumenes_Movimientos(ByVal ObjDetalle As DataTable) As DataSet
      Dim dsReturn As New DataSet
      Dim objDataSet As New DataSet
      'Dim objFiltros As New DataTable
      ObjDetalle.TableName = "DT_Detalle"
      dsReturn.Tables.Add(ObjDetalle.Copy())
     
      Return (dsReturn)
    End Function

        Public Function CrearResumenes_Despacho(ByVal ObjDetalle As DataTable) As DataSet
            Dim dsReturn As New DataSet
            dsReturn = Me.CrearResumenes_Movimientos(ObjDetalle)
            dsReturn.Tables.Add(CrearResumenes_Movimiento_MedioEnVio(ObjDetalle.Copy))
            dsReturn.Tables.Add(CrearResumenes_Movimiento_CuentaImputacion(ObjDetalle.Copy))

            Dim oDtvTemp As DataView = New DataView(dsReturn.Tables(1))
            Dim oTdtTemp As New DataTable
            oTdtTemp = oDtvTemp.ToTable(True, "CLIENTE")
            oTdtTemp.TableName = "DT_Clientes"
            dsReturn.Tables.Add(oTdtTemp.Copy())
            Return (dsReturn)
        End Function

        Public Function CrearResumenes_Movimiento_CuentaImputacion(ByVal ObjDetalle As DataTable) As DataTable
            Dim objResumen As New DataTable
            Dim objResumenFin As New DataTable
            Dim objObjDetalle_Planta As New DataTable
            Dim objDataRow As DataRow = Nothing

            objObjDetalle_Planta.TableName = "DT_DETALLE"
            objObjDetalle_Planta.Columns.Add(New DataColumn("TCMPCL", GetType(System.String)))
            objObjDetalle_Planta.Columns.Add(New DataColumn("GUIATRANS", GetType(System.String)))
            objObjDetalle_Planta.Columns.Add(New DataColumn("MEDENVIO", GetType(System.String)))
            objObjDetalle_Planta.Columns.Add(New DataColumn("CUENTA", GetType(System.String)))
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
                        objDataRow.Item("CUENTA") = ObjDetalle.Rows(i)(j.ToString + "_CUENTA").ToString.Trim
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
            objResumen.Columns.Add(New DataColumn("CUENTA", GetType(System.String)))
            objResumen.Columns.Add(New DataColumn("PLANTA", GetType(System.String)))
            objResumen.Columns.Add(New DataColumn("KG", GetType(System.Double)))
            objResumen.Columns.Add(New DataColumn("M3", GetType(System.Double)))
            objResumen.Columns.Add(New DataColumn("BUL", GetType(System.Double)))
            objResumen.Columns.Add(New DataColumn("IMPORTE", GetType(System.Double)))

            objResumenFin.Columns.Add(New DataColumn("CLIENTE", GetType(System.String)))
            objResumenFin.Columns.Add(New DataColumn("MEDIO_ENVIO", GetType(System.String)))
            objResumenFin.Columns.Add(New DataColumn("CUENTA", GetType(System.String)))


            'Debe de haberse Ordenado por Planta , Cliente , MEDENVIO , TLUGEN y TUNDVH
            Dim dv As New DataView
            dv.Table = objObjDetalle_Planta
            dv.Sort = "Planta,TCMPCL, MEDENVIO,CUENTA ASC"
            objObjDetalle_Planta = dv.ToTable()


            For i As Integer = 0 To objObjDetalle_Planta.Rows.Count - 1
                strPlanta = objObjDetalle_Planta.Rows(i).Item("PLANTA")
                strCliente = objObjDetalle_Planta.Rows(i).Item("TCMPCL")
                drSelectImporte = objObjDetalle_Planta.Select("TCMPCL = '" + strCliente.Trim + "' AND PLANTA = '" + strPlanta.Trim + "' AND MEDENVIO = '" + objObjDetalle_Planta.Rows(i)("MEDENVIO").ToString.Trim + "' AND CUENTA = '" + objObjDetalle_Planta.Rows(i)("CUENTA").ToString.Trim + "'")
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
                    objDataRow.Item("CUENTA") = objObjDetalle_Planta.Rows(i)("CUENTA").ToString.Trim
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
            dvR.Sort = "CLIENTE, MEDIO_ENVIO, CUENTA ASC"
            objResumen = dvR.ToTable()

            For i As Integer = 0 To objResumen.Rows.Count - 1
                drSelectImporte = objResumen.Select("CLIENTE = '" + objResumen.Rows(i)("CLIENTE").ToString.Trim + "' AND MEDIO_ENVIO = '" + objResumen.Rows(i)("MEDIO_ENVIO").ToString + "' AND CUENTA = '" + objResumen.Rows(i)("CUENTA").ToString + "'")
                objDataRow = objResumenFin.NewRow
                objDataRow.Item("CLIENTE") = objResumen.Rows(i)("CLIENTE").ToString.Trim
                objDataRow.Item("MEDIO_ENVIO") = objResumen.Rows(i)("MEDIO_ENVIO").ToString.Trim
                objDataRow.Item("CUENTA") = objResumen.Rows(i)("CUENTA").ToString.Trim

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

            objResumenFin.TableName = "DT_Resumen_Cuenta"
            objResumenFin.Namespace = "Resumen Cuenta Imputación"
            Return (objResumenFin)

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
            dvR.Sort = "CLIENTE, MEDIO_ENVIO, LOTE, TIPO_UNIDAD ASC"
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

    '------ Exportar Reporte Valorizado

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
        'objResumenFin.Columns.Add(New DataColumn(i + "_NCSOTR", GetType(System.String)))
        objResumenFin.Columns.Add(New DataColumn(i + "_FCHFTR", GetType(System.String)))
        i = i + 1
      Next
      Return objResumenFin
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
      'objResumenFin.Columns.Remove("NCSOTR")
      objResumenFin.Columns.Remove("FCHFTR")

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

    Enum MedioEnvio
      TERRESTRE = 1
      AEREO = 2
      FLUVIAL = 3
        End Enum


        Public Function ListaDatosAdPreLiquidacion(ByVal objParametros As Hashtable) As DataTable
            Return objDataAccessLayer.ListaDatosAdPreLiquidacion(objParametros)
        End Function

        Public Sub ActualizarDatosAdPreLiquidacion(ByVal objParametros As Hashtable)
            objDataAccessLayer.ActualizarDatosAdPreLiquidacion(objParametros)
        End Sub
        Public Function ListaDatosCliente(CCMPN As String, PNCCLNT As Decimal) As DataTable
            Return objDataAccessLayer.ListaDatosCliente(CCMPN, PNCCLNT)
        End Function

  End Class
End Namespace
