Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports Ransa.Utilitario

Namespace Operaciones

  Public Class Factura_Transporte_DAL
    Private objSql As New SqlManager

        Public Function Listar_Operacion_x_Orden_Servicio(ByVal objParametro As Hashtable) As List(Of OperacionTransporte)
            Dim objEntidad As OperacionTransporte
            Dim objGenericCollection As New List(Of OperacionTransporte)
            Dim objParam As New Parameter
            'Try

            objParam.Add("PNNMOPMM", objParametro("PNNMOPMM"))
            objParam.Add("PNNORSRT", objParametro("PNNORSRT"))
            objParam.Add("PSSESTOP", objParametro("PSSESTOP"))
            objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
            objParam.Add("PSCPLNDV", objParametro("PSCPLNDV"))
            objParam.Add("PNCCLNT", objParametro("PNCCLNT"))

            objParam.Add("PNNROVLR", objParametro("PNNROVLR"))
            objParam.Add("PSDOCVLR", objParametro("PSDOCVLR"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            Dim odtOperacion As New DataTable
            odtOperacion = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_OPERACION_X_ORDEN_SERVICIO", objParam)
            For Each objDataRow As DataRow In odtOperacion.Rows
                objEntidad = New OperacionTransporte
                objEntidad.NOPRCN = objDataRow("NOPRCN")
                objEntidad.NORSRT = objDataRow("NORSRT")
                objEntidad.CCLNT = objDataRow("CCLNT")
                objEntidad.TCMPCL = objDataRow("TCMPCL").ToString.Trim
                objEntidad.CCLNFC = objDataRow("CCLNFC")
                objEntidad.TCMPCF = objDataRow("TCMPCF").ToString.Trim
                objEntidad.CPLNCL = objDataRow("CPLNCL")
                objEntidad.TPLNTA = objDataRow("TPLNTA")
                'objEntidad.CTPOSR = objDataRow("CTPOSR")
                'objEntidad.TCMTPS = objDataRow("TCMTPS").ToString.Trim
                'objEntidad.TCMSBS = objDataRow("TCMSBS")
                'objEntidad.CMRCDR = objDataRow("CMRCDR").ToString.Trim
                'objEntidad.TCMRCD = objDataRow("TCMRCD")
                objEntidad.SESTOP = objDataRow("SESTOP")
                'objEntidad.TDRCNS = objDataRow("TDRCOR").ToString.Trim
                'objEntidad.NRUCCN = objDataRow("NRUCTR")
                objEntidad.SORGMV = objDataRow("SORGMV").ToString.Trim
                'objEntidad.TCNTCS = objDataRow("TCNTCS").ToString.Trim
                objEntidad.TCRVTA = objDataRow("TCRVTA").ToString.Trim
                objEntidad.CRGVTA = objDataRow("CRGVTA").ToString.Trim
                objEntidad.CPLNDV = objDataRow("CPLNDV")
                REM ECM-HUNDRED-INICIO
                'objEntidad.CDSCSP = objDataRow("CDSCSP").ToString.Trim
                'objEntidad.TDSCSP = objDataRow("TDSCSP").ToString.Trim

                'If String.IsNullOrEmpty(objEntidad.CDSCSP) Then
                '    objEntidad.CDSCSP_TDSCSP = ""
                'Else
                '    objEntidad.CDSCSP_TDSCSP = String.Format("{0} - {1}", objDataRow("CDSCSP").ToString.Trim, objDataRow("TDSCSP").ToString.Trim)
                'End If

                REM ECM-HUNDRED-FIN
                'objEntidad.CECO_OPE = objDataRow("CECO_OPE")
                'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
                objEntidad.PLANTA = objDataRow("PLANTA").ToString.Trim
                objEntidad.PLANTA_FACT = objDataRow("PLANTA_FACT").ToString.Trim
                'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN


                'objEntidad.CEBEO = objDataRow("CEBEO").ToString.Trim
                'objEntidad.CECOD = objDataRow("CECOD").ToString.Trim

                objEntidad.CEBE = objDataRow("CEBE").ToString.Trim
                objEntidad.CECO = objDataRow("CECO").ToString.Trim


                objEntidad.DOCVLR = objDataRow("DOCVLR").ToString.Trim
                objEntidad.NROVLR = objDataRow("NROVLR")
                objEntidad.SEGVLR = objDataRow("SEGVLR").ToString.Trim
                objEntidad.SEGVLR_DESC = objDataRow("SEGVLR_DESC").ToString.Trim
                'objEntidad.OP_FACTURABLE = objDataRow("OP_FACTURABLE").ToString.Trim

                objGenericCollection.Add(objEntidad)
            Next
            'Catch ex As Exception
            '    objGenericCollection = New List(Of OperacionTransporte)
            'End Try
            Return objGenericCollection
        End Function

    Public Function Listar_Guia_Remision_x_Operacion(ByVal objParametro As Hashtable) As List(Of Factura_Transporte)
      Dim objEntidad As New Factura_Transporte
      Dim objGenericCollection As New List(Of Factura_Transporte)
      Dim objParam As New Parameter
            'Try
            objParam.Add("PNNOPRCN", objParametro("PNNOPRCN"))
            objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
            objParam.Add("PNCPLNDV", objParametro("PNCPLNDV"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))

            For Each objDataRow As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_GUIA_REMISION_X_OPERACION_LA", objParam).Rows
                objEntidad = New Factura_Transporte
                objEntidad.NOPRCN = objDataRow("NOPRCN")
                objEntidad.NGUITR = objDataRow("NGUITR")
                objEntidad.FGUITR_S = HelpClass.CFecha_de_8_a_10(objDataRow("FGUITR"))
                objEntidad.NMNFCR = objDataRow("NMNFCR")
                objEntidad.CTRSPT = objDataRow("CTRSPT")
                objEntidad.TCMTRT = objDataRow("TCMTRT").ToString.Trim
                objEntidad.NPLVHT = objDataRow("NPLVHT").ToString.Trim
                objEntidad.CBRCNT = objDataRow("CBRCNT").ToString.Trim
                objEntidad.TDSTRT = objDataRow("TDSTRT").ToString.Trim
                objEntidad.QCNDTG = objDataRow("QCNDTG")
                objEntidad.ISRVGU = objDataRow("ISRVGU")
                objEntidad.CMNDGU = objDataRow("CMNDGU").ToString.Trim
                objEntidad.TOTSER = objDataRow("TOTSER")
                objEntidad.PBRTOR = objDataRow("PBRTOR")
                objEntidad.QBLORG = objDataRow("QBLORG")
                objEntidad.QKLMRC = objDataRow("QKLMRC")
                objGenericCollection.Add(objEntidad)
            Next
            'Catch ex As Exception
            '          objGenericCollection = New List(Of Factura_Transporte)
            '      End Try
            Return objGenericCollection
    End Function

    Public Function Listar_Orden_Servicio_Facturacion(ByVal objParametro As Hashtable) As List(Of OrdenServicioTransporte)
      Dim objEntidad As New OrdenServicioTransporte
      Dim objGenericCollection As New List(Of OrdenServicioTransporte)
      Dim objParam As New Parameter
            'Try
            objParam.Add("PNCCLNT", objParametro("PNCCLNT"))
            objParam.Add("PSSESTOP", objParametro("PSSESTOP"))
            objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
            objParam.Add("PNCPLNDV", objParametro("PNCPLNDV"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))

            For Each objDataRow As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_ORDEN_SERVICIO_FACTURACION", objParam).Rows
                objEntidad = New OrdenServicioTransporte
                objEntidad.NCTZCN = objDataRow("NCTZCN")
                objEntidad.NORSRT = objDataRow("NORSRT").ToString.Trim
                objEntidad.CCLNT = objDataRow("CCLNT").ToString.Trim
                objEntidad.CMRCDR = objDataRow("CMRCDR").ToString.Trim
                objEntidad.QMRCDR = objDataRow("QMRCDR").ToString.Trim
                objEntidad.TRFMRC = objDataRow("TRFMRC").ToString.Trim
                objEntidad.CTPOSR = objDataRow("CTPOSR").ToString.Trim
                objEntidad.RUTA = objDataRow("RUTA").ToString.Trim
                objGenericCollection.Add(objEntidad)
            Next
            'Catch ex As Exception
            '          objGenericCollection = New List(Of OrdenServicioTransporte)
            '      End Try
            Return objGenericCollection
    End Function

    Public Function Listar_Consistencia_Factura_x_Orden_Servicio(ByVal objParametro As Hashtable) As List(Of Factura_Transporte)
      Dim objEntidad As Factura_Transporte
      Dim objGenericCollection As New List(Of Factura_Transporte)
      Dim objParam As New Parameter
      Dim objDataTable As New DataTable
            'Try
            objParam.Add("PNNOPRCN", objParametro("PSNOPRCN"))
            objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
            objParam.Add("PNFECHA", objParametro("PNFECHA"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))

            For Each objDataRow As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_CONSISTENCIA_FACTURA_X_ORDEN_SERVICIO", objParam).Rows
                objEntidad = New Factura_Transporte

                objEntidad.NOPRCN = objDataRow("NOPRCN")
                objEntidad.NORSRT = objDataRow("NORSRT")
                objEntidad.CCLNT = objDataRow("CCLNT")
                objEntidad.TCMPCL = objDataRow("TCMPCL").ToString.Trim
                objEntidad.CCLNFC = objDataRow("CCLNFC")
                objEntidad.TCMPFC = objDataRow("TCMPFC").ToString.Trim
                objEntidad.TDRCFC = objDataRow("TDRCFC").ToString.Trim
                objEntidad.NRUCFC = IIf(objDataRow("NRUCFC") = 0, objDataRow("NLBTEL"), objDataRow("NRUCFC"))
                objEntidad.CMRCDR = objDataRow("CMRCDR").ToString.Trim
                objEntidad.TCMRCD = objDataRow("TCMRCD").ToString.Trim
                objEntidad.CTPOSR = objDataRow("CTPOSR").ToString.Trim
                objEntidad.TCMTPS = objDataRow("TCMTPS").ToString.Trim
                objEntidad.CTPSBS = objDataRow("CTPSBS").ToString.Trim
                objEntidad.TCMSBS = objDataRow("TCMSBS").ToString.Trim
                objEntidad.NGUITR = objDataRow("NGUITR")
                objEntidad.FGUITR_S = objDataRow("FGUITR").ToString.Trim
                objEntidad.SRPTRM = objDataRow("SRPTRM").ToString.Trim
                objEntidad.RUTA = objDataRow("RUTA").ToString.Trim
                objEntidad.CTRSPT = objDataRow("CTRSPT")
                objEntidad.TCMTRT = objDataRow("TCMTRT").ToString.Trim
                objEntidad.NPLVHT = objDataRow("NPLVHT").ToString.Trim
                objEntidad.CMNDGU = objDataRow("CMNDGU").ToString.Trim
                objEntidad.TSGNMN_S = objDataRow("TSGNMN_S").ToString.Trim
                objEntidad.ISRVGU = objDataRow("ISRVGU")
                objEntidad.QCNDTG = objDataRow("QCNDTG")
                objEntidad.CUNDSR = objDataRow("CUNDSR").ToString.Trim
                objEntidad.CMNLQT = objDataRow("CMNLQT").ToString.Trim
                objEntidad.TSGNMN_L = objDataRow("TSGNMN_L").ToString.Trim
                objEntidad.ILQDTR = objDataRow("ILQDTR")
                objEntidad.VLRFDT = objDataRow("VLRFDT")
                objEntidad.TCMTRF = IIf(objDataRow("TCMTRF").ToString.Trim = "FLETE", "1 " & objDataRow("TCMTRF").ToString.Trim, objDataRow("TCMTRF").ToString.Trim)
                objEntidad.IVNTA = objDataRow("IVNTA")
                objEntidad.PBRTOR = objDataRow("PBRTOR")
                objEntidad.CPRCN1 = objDataRow("CPRCN1")
                objEntidad.NSRCN1 = objDataRow("NSRCN1")
                objEntidad.TMNCNT = IIf(objDataRow("TMNCNT") = 0, "", objDataRow("TMNCNT"))
                objEntidad.CPRCN2 = objDataRow("CPRCN2")
                objEntidad.NSRCN2 = objDataRow("NSRCN2")
                objEntidad.TMNCN1 = IIf(objDataRow("TMNCN1") = 0, "", objDataRow("TMNCN1"))
                objEntidad.CTIGVA = objDataRow("CTIGVA")
                objEntidad.PIGVA = objDataRow("PIGVA")
                objEntidad.INDICE = objEntidad.TCMTRF & objEntidad.CUNDSR
                objEntidad.TCNFVH = objDataRow("TCNFVH")
                objEntidad.CSTNDT = objDataRow("CSTNDT")
                objEntidad.PESOL = objDataRow("PESOL")
                objGenericCollection.Add(objEntidad)
            Next
            'Catch ex As Exception
            '          objGenericCollection = New List(Of Factura_Transporte)()
            '      End Try
            Return objGenericCollection
    End Function


        'Public Function Listar_Sustento_Factura_Lote(ByVal objParametro As Hashtable, ByVal drSelect As DataRow()) As List(Of Factura_Transporte)
        '    Dim objEntidad As Factura_Transporte
        '    Dim objGenericCollection As New List(Of Factura_Transporte)
        '    Dim objParam As New Parameter
        '    Dim objDataTable As New DataTable
        '    'Try

        '    'Crea los Parametros para la Temporal
        '    Dim sbNOPRCN As New System.Text.StringBuilder()
        '    Dim sbNGUIRM As New System.Text.StringBuilder()
        '    Dim sbCSRVC As New System.Text.StringBuilder()
        '    Dim sbISRVGU As New System.Text.StringBuilder()
        '    Dim sbPESO As New System.Text.StringBuilder()
        '    Dim sbPSOVOL As New System.Text.StringBuilder()

        '    For row As Integer = 0 To drSelect.Length - 1
        '        sbNOPRCN.Append(drSelect(row).Item("NOPRCN"))
        '        sbNGUIRM.Append(drSelect(row).Item("NGUIRM"))
        '        sbCSRVC.Append(drSelect(row).Item("CRBCTC"))

        '        'If objParametro("MonedaFactura") = "DOL" Then
        '        '    If drSelect(row).Item("CMNDGU") = 100 Then
        '        '        sbISRVGU.Append(drSelect(row).Item("ISRVGU"))
        '        '    Else
        '        '        sbISRVGU.Append(CType(drSelect(row).Item("ISRVGU") * objParametro("TipoCambio"), Decimal))
        '        '    End If
        '        'Else
        '        If drSelect(row).Item("CMNDGU") = 1 Then
        '            sbISRVGU.Append(drSelect(row).Item("ISRVGU"))
        '        Else
        '            sbISRVGU.Append(CType(drSelect(row).Item("ISRVGU") / objParametro("TipoCambio"), Decimal))
        '        End If
        '        'End If

        '        sbPESO.Append(drSelect(row).Item("PESO"))
        '        sbPSOVOL.Append(drSelect(row).Item("PSOVOL"))

        '        If row < drSelect.Length - 1 Then
        '            sbNOPRCN.Append(",")
        '            sbNGUIRM.Append(",")
        '            sbCSRVC.Append(",")
        '            sbISRVGU.Append(",")
        '            sbPESO.Append(",")
        '            sbPSOVOL.Append(",")
        '        End If
        '    Next

        '    objParam.Add("PNCTPODC", objParametro("PNCTPODC"))
        '    objParam.Add("PNNDCMFC", objParametro("PNNDCMFC"))
        '    objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
        '    objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
        '    objParam.Add("PSNOPRCN", sbNOPRCN.ToString())
        '    objParam.Add("PSNGUIRM", sbNGUIRM.ToString())
        '    objParam.Add("PSCSRVC", sbCSRVC.ToString())
        '    objParam.Add("PSISRVGU", sbISRVGU.ToString())
        '    objParam.Add("PSPESO", sbPESO.ToString())
        '    objParam.Add("PSOVOL", sbPSOVOL.ToString())

        '    objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
        '    objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_SUSTENTO_FACTURA_LOTE", objParam)
        '    For Each objDataRow As DataRow In objDataTable.Rows
        '        objEntidad = New Factura_Transporte

        '        objEntidad.NOPRCN = objDataRow("NOPRCN")
        '        objEntidad.NORSRT = objDataRow("NORSRT")
        '        objEntidad.CCLNT = objDataRow("CCLNT")
        '        objEntidad.TCMPCL = objDataRow("TCMPCL").ToString.Trim
        '        objEntidad.CCLNFC = objDataRow("CCLNFC")
        '        objEntidad.TCMPFC = objDataRow("TCMPFC").ToString.Trim
        '        objEntidad.TDRCFC = objDataRow("TDRCFC").ToString.Trim
        '        objEntidad.NRUCFC = IIf(objDataRow("NRUCFC") = 0, objDataRow("NLBTEL"), objDataRow("NRUCFC"))
        '        objEntidad.CMRCDR = objDataRow("CMRCDR").ToString.Trim
        '        objEntidad.TCMRCD = objDataRow("TCMRCD").ToString.Trim
        '        objEntidad.CTPOSR = objDataRow("CTPOSR").ToString.Trim
        '        objEntidad.TCMTPS = objDataRow("TCMTPS").ToString.Trim
        '        objEntidad.CTPSBS = objDataRow("CTPSBS").ToString.Trim
        '        objEntidad.TCMSBS = objDataRow("TCMSBS").ToString.Trim
        '        objEntidad.NGUITR = objDataRow("NGUITR")
        '        objEntidad.FGUITR_S = objDataRow("FGUITR").ToString.Trim
        '        objEntidad.SRPTRM = objDataRow("SRPTRM").ToString.Trim
        '        objEntidad.RUTA = objDataRow("RUTA").ToString.Trim
        '        objEntidad.CTRSPT = objDataRow("CTRSPT")
        '        objEntidad.TCMTRT = objDataRow("TCMTRT").ToString.Trim
        '        objEntidad.NPLVHT = objDataRow("NPLVHT").ToString.Trim
        '        objEntidad.CMNDGU = objDataRow("CMNDGU").ToString.Trim
        '        objEntidad.TSGNMN_S = objDataRow("TSGNMN_S").ToString.Trim
        '        objEntidad.ISRVGU = objDataRow("ISRVGU")
        '        objEntidad.QCNDTG = objDataRow("QCNDTG")
        '        objEntidad.CUNDSR = objDataRow("CUNDSR").ToString.Trim
        '        objEntidad.CMNLQT = objDataRow("CMNLQT").ToString.Trim
        '        objEntidad.TSGNMN_L = objDataRow("TSGNMN_L").ToString.Trim
        '        objEntidad.ILQDTR = objDataRow("ILQDTR")
        '        objEntidad.VLRFDT = objDataRow("VLRFDT")
        '        objEntidad.TCMTRF = IIf(objDataRow("TCMTRF").ToString.Trim = "FLETE", "1 " & objDataRow("TCMTRF").ToString.Trim, objDataRow("TCMTRF").ToString.Trim)
        '        objEntidad.IVNTA = objDataRow("IVNTA")
        '        objEntidad.PBRTOR = objDataRow("PBRTOR")
        '        objEntidad.CPRCN1 = objDataRow("CPRCN1")
        '        objEntidad.NSRCN1 = objDataRow("NSRCN1")
        '        objEntidad.TMNCNT = IIf(objDataRow("TMNCNT") = 0, "", objDataRow("TMNCNT"))
        '        objEntidad.CPRCN2 = objDataRow("CPRCN2")
        '        objEntidad.NSRCN2 = objDataRow("NSRCN2")
        '        objEntidad.TMNCN1 = IIf(objDataRow("TMNCN1") = 0, "", objDataRow("TMNCN1"))
        '        objEntidad.CTIGVA = objDataRow("CTIGVA")
        '        objEntidad.PIGVA = objDataRow("PIGVA")
        '        objEntidad.INDICE = objEntidad.TCMTRF & objEntidad.CUNDSR
        '        objEntidad.TCNFVH = objDataRow("TCNFVH")
        '        objEntidad.CSTNDT = objDataRow("CSTNDT")
        '        objEntidad.PESOL = objDataRow("PESOL")
        '        objGenericCollection.Add(objEntidad)
        '    Next
        '    'Catch ex As Exception
        '    '    objGenericCollection = New List(Of Factura_Transporte)()
        '    'End Try
        '    Return objGenericCollection
        'End Function

    Public Function Listar_Sustento_Factura(ByVal objParametro As Hashtable) As List(Of Factura_Transporte)
      Dim objEntidad As Factura_Transporte
      Dim objGenericCollection As New List(Of Factura_Transporte)
      Dim objParam As New Parameter
      Dim objDataTable As New DataTable
            'Try
            objParam.Add("PNCTPODC", objParametro("PNCTPODC"))
            objParam.Add("PNNDCMFC", objParametro("PNNDCMFC"))
            objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objParametro("PSCDVSN"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_SUSTENTO_FACTURA", objParam)
            For Each objDataRow As DataRow In objDataTable.Rows
                objEntidad = New Factura_Transporte

                objEntidad.NOPRCN = objDataRow("NOPRCN")
                objEntidad.NORSRT = objDataRow("NORSRT")
                objEntidad.CCLNT = objDataRow("CCLNT")
                objEntidad.TCMPCL = objDataRow("TCMPCL").ToString.Trim
                objEntidad.CCLNFC = objDataRow("CCLNFC")
                objEntidad.TCMPFC = objDataRow("TCMPFC").ToString.Trim
                objEntidad.TDRCFC = objDataRow("TDRCFC").ToString.Trim
                objEntidad.NRUCFC = IIf(objDataRow("NRUCFC") = 0, objDataRow("NLBTEL"), objDataRow("NRUCFC"))
                objEntidad.CMRCDR = objDataRow("CMRCDR").ToString.Trim
                objEntidad.TCMRCD = objDataRow("TCMRCD").ToString.Trim
                objEntidad.CTPOSR = objDataRow("CTPOSR").ToString.Trim
                objEntidad.TCMTPS = objDataRow("TCMTPS").ToString.Trim
                objEntidad.CTPSBS = objDataRow("CTPSBS").ToString.Trim
                objEntidad.TCMSBS = objDataRow("TCMSBS").ToString.Trim
                objEntidad.NGUITR = objDataRow("NGUITR")
                objEntidad.FGUITR_S = objDataRow("FGUITR").ToString.Trim
                objEntidad.SRPTRM = objDataRow("SRPTRM").ToString.Trim
                objEntidad.RUTA = objDataRow("RUTA").ToString.Trim
                objEntidad.CTRSPT = objDataRow("CTRSPT")
                objEntidad.TCMTRT = objDataRow("TCMTRT").ToString.Trim
                objEntidad.NPLVHT = objDataRow("NPLVHT").ToString.Trim
                objEntidad.CMNDGU = objDataRow("CMNDGU").ToString.Trim
                objEntidad.TSGNMN_S = objDataRow("TSGNMN_S").ToString.Trim
                objEntidad.ISRVGU = objDataRow("ISRVGU")
                objEntidad.QCNDTG = objDataRow("QCNDTG")
                objEntidad.CUNDSR = objDataRow("CUNDSR").ToString.Trim
                objEntidad.CMNLQT = objDataRow("CMNLQT").ToString.Trim
                objEntidad.TSGNMN_L = objDataRow("TSGNMN_L").ToString.Trim
                objEntidad.ILQDTR = objDataRow("ILQDTR")
                objEntidad.VLRFDT = objDataRow("VLRFDT")
                objEntidad.TCMTRF = IIf(objDataRow("TCMTRF").ToString.Trim = "FLETE", "1 " & objDataRow("TCMTRF").ToString.Trim, objDataRow("TCMTRF").ToString.Trim)
                objEntidad.IVNTA = objDataRow("IVNTA")
                objEntidad.PBRTOR = objDataRow("PBRTOR")
                objEntidad.CPRCN1 = objDataRow("CPRCN1")
                objEntidad.NSRCN1 = objDataRow("NSRCN1")
                objEntidad.TMNCNT = IIf(objDataRow("TMNCNT") = 0, "", objDataRow("TMNCNT"))
                objEntidad.CPRCN2 = objDataRow("CPRCN2")
                objEntidad.NSRCN2 = objDataRow("NSRCN2")
                objEntidad.TMNCN1 = IIf(objDataRow("TMNCN1") = 0, "", objDataRow("TMNCN1"))
                objEntidad.CTIGVA = objDataRow("CTIGVA")
                objEntidad.PIGVA = objDataRow("PIGVA")
                objEntidad.INDICE = objEntidad.TCMTRF & objEntidad.CUNDSR
                objEntidad.TCNFVH = objDataRow("TCNFVH")
                objEntidad.CSTNDT = objDataRow("CSTNDT")
                objEntidad.PESOL = objDataRow("PESOL")
                objGenericCollection.Add(objEntidad)
            Next
            'Catch ex As Exception
            '          objGenericCollection = New List(Of Factura_Transporte)()
            '      End Try
            Return objGenericCollection
    End Function

    Public Function Listar_Planta_x_Cliente_Factura(ByVal objParametro As Hashtable) As List(Of Factura_Transporte)
      Dim objEntidad As Factura_Transporte
      Dim objGenericCollection As New List(Of Factura_Transporte)
      Dim objParam As New Parameter
      Dim objDataTable As New DataTable
            'Try
            objParam.Add("PNCCLNT", objParametro("PNCCLNT"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))

            For Each objDataRow As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_PLANTA_X_CLIENTE_FACTURAR", objParam).Rows
                objEntidad = New Factura_Transporte
                objEntidad.CPLNCL = objDataRow("CPLNCL")
                objEntidad.TDRCPL = objDataRow("TDRCPL").ToString.Trim
                objGenericCollection.Add(objEntidad)
            Next
            'Catch ex As Exception
            '          objGenericCollection = New List(Of Factura_Transporte)()
            '      End Try
            Return objGenericCollection
        End Function


        Public Function Listar_Cliente_IgualCodSAP(pCCMPN As String, pCCLNT As Decimal) As DataTable
            Dim objParam As New Parameter
            Dim dt As New DataTable
            objParam.Add("PSCCMPN", pCCMPN)
            objParam.Add("PNCCLNT", pCCLNT)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pCCMPN)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_CLIENTE_IGUAL_CODIGO_SAP", objParam)
            Return dt
        End Function


        Public Sub Actualizar_Cliente_Facturar(ByVal objParametro As Hashtable)
            Dim objParam As New Parameter
            Dim lint_NumDoc As Int64 = 0
            objParam.Add("PNNOPRCN", objParametro("PNNOPRCN"))
            objParam.Add("PNCCLNFC", objParametro("PNCCLNFC"))
            'objParam.Add("PNCPLNCL", objParametro("PNCPLNCL"))
            'objParam.Add("PNFULTAC", objParametro("PNFULTAC"))
            'objParam.Add("PNHULTAC", objParametro("PNHULTAC"))
            objParam.Add("PSCULUSA", objParametro("PSCULUSA"))
            objParam.Add("PSNTRMNL", objParametro("PSNTRMNL"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_CLIENTE_FACTURAR", objParam)
            
        End Sub

    Public Function Verificar_Cliente_Especial(ByVal objParametro As Hashtable) As Int64
      Dim objParam As New Parameter
      Dim lint_NumDoc As Int64 = 0
      Try
        objParam.Add("PON_NRODOCU", objParametro("PON_NRODOCU"), ParameterDirection.Output)
        objParam.Add("PNCCLNT", objParametro("PNCCLNT"))

        objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
        objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
        objParam.Add("PNCPLNDV", objParametro("PNCPLNDV"))

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))

        objSql.ExecuteNonQuery("SP_SOLMIN_ST_VERIFICAR_CLIENTE_ESPECIAL", objParam)
        lint_NumDoc = objSql.ParameterCollection("PON_NRODOCU")
      Catch ex As Exception
        lint_NumDoc = 0
      End Try
      Return lint_NumDoc
    End Function

    Public Function Obtener_Cliente_x_Orden_Servicio(ByVal objParametro As Hashtable) As String
      Dim objParam As New Parameter
      Dim lstr_Cliente As String = ""
            'Try
            objParam.Add("PNNORSRT", objParametro("PNNORSRT"))
            objParam.Add("PON_TCMPCL", "", ParameterDirection.Output)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_OBTENER_CLIENTE_X_ORDEN_SERVICIO", objParam)
            lstr_Cliente = objSql.ParameterCollection("PON_TCMPCL").ToString
            'Catch ex As Exception
            '          lstr_Cliente = ""
            '      End Try
            Return lstr_Cliente
    End Function

        Public Function Pre_Facturar_Operacion(ByVal objParametro As Hashtable) As Decimal
            Dim objParam As New Parameter
            Dim lint_Estado As Int32 = 0
            Dim NroPreFactura As Decimal = 0
            Dim dt As New DataTable
            'Try
            objParam.Add("PNNOPRCN", objParametro("PNNOPRCN"))
            objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
            objParam.Add("PNCPLNDV", objParametro("PNCPLNDV"))
            objParam.Add("PNFULTAC", objParametro("PNFULTAC"))
            objParam.Add("PNHULTAC", objParametro("PNHULTAC"))
            objParam.Add("PSCULUSA", objParametro("PSCULUSA"))
            objParam.Add("PSNTRMNL", objParametro("PSNTRMNL"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_PRE_FACTURAR_OPERACION", objParam)
            If dt.Rows.Count > 0 Then
                NroPreFactura = dt.Rows(0)("NDCPRF")
            End If

            'objSql.ExecuteNonQuery("SP_SOLMIN_ST_PRE_FACTURAR_OPERACION", objParam)
            'lint_Estado = 1
            'Catch ex As Exception
            '    lint_Estado = 0
            'End Try
            'Return lint_Estado
            Return NroPreFactura
        End Function

    Public Function Lista_Tipo_Cambio(ByVal objParametro As Hashtable) As DataTable
      Dim dt As DataTable
      Dim lobjParams As New Parameter
            'Try
            lobjParams.Add("PNCMNDA1", objParametro("PNCMNDA1"))
            lobjParams.Add("PNFCMBO", objParametro("PNFCMBO"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_TIPO_CAMBIO", lobjParams)
            'Catch ex As Exception
            '          dt = Nothing
            '      End Try
            Return dt
    End Function

    Public Function Lista_Giro_Negocio(ByVal objParametro As Hashtable) As DataTable
      Dim dt As DataTable

      Dim lobjParams As New Parameter
            'Try
            lobjParams.Add("PSCCMPN", objParametro("PSCCMPN"))
            lobjParams.Add("PSCDVSN", objParametro("PSCDVSN"))
            lobjParams.Add("PSCUSCRT", objParametro("PSCUSCRT"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_FACTURA_GIRO_NEGOCIO", lobjParams)
            'Catch ex As Exception
            '          dt = Nothing
            '      End Try

            Return dt
    End Function

    Public Function Lista_Documentos_Permitidos(ByVal objParametro As Hashtable) As DataTable
      Dim dt As DataTable
      Dim lobjParams As New Parameter
            'Try
            lobjParams.Add("PSCCMPN", objParametro("PSCCMPN"))
            lobjParams.Add("PSCDVSN", objParametro("PSCDVSN"))
            lobjParams.Add("PNCCLNT", objParametro("PNCCLNT"))
            lobjParams.Add("PSCUSCRT", objParametro("PSCUSCRT"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_FACTURA_DOCUMENTOS_PERMITIDOS", lobjParams)
            'Catch ex As Exception
            '          dt = Nothing
            '      End Try

            Return dt
        End Function
        Public Function Lista_Documentos_Permitidos_Notas(ByVal objParametro As Hashtable) As DataTable
            Dim dt As DataTable
            Dim lobjParams As New Parameter
            'Try
            lobjParams.Add("PSCCMPN", objParametro("PSCCMPN"))
            lobjParams.Add("PSCDVSN", objParametro("PSCDVSN"))
            lobjParams.Add("PNCCLNT", objParametro("PNCCLNT"))
            lobjParams.Add("PSCUSCRT", objParametro("PSCUSCRT"))
            lobjParams.Add("PNCTPODC", objParametro("PNCTPODC"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_REFACTURA_DOCUMENTOS_PERMITIDOS", lobjParams)
            'Catch ex As Exception
            '    dt = Nothing
            'End Try

            Return dt
        End Function

    Public Function Lista_Planta_Cliente(ByVal objParametro As Hashtable) As DataTable
      Dim dt As DataTable
      Dim lobjParams As New Parameter
            'Try
            lobjParams.Add("PNCCLNT", objParametro("PNCCLNFC"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_FACTURA_PLANTA_CLIENTE", lobjParams)
            'Catch ex As Exception
            '          dt = Nothing
            '      End Try

            Return dt
    End Function

    Public Function Lista_Datos_Cliente(ByVal objParametro As Hashtable) As DataTable
      Dim dt As DataTable
      Dim lobjParams As New Parameter
            'Try
            lobjParams.Add("PNCCLNT", objParametro("PNCCLNFC"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_FACTURA_DATOS_CLIENTE", lobjParams)
            'Catch ex As Exception
            '          dt = Nothing
            '      End Try

            Return dt
    End Function

        'Public Function Lista_Detalle_Servicios_Lote(ByVal objParametro As Hashtable) As DataSet
        '    Dim dt As DataSet
        '    Dim lobjParams As New Parameter
        '    'Try
        '    lobjParams.Add("PNNOPRCN", objParametro("PNNOPRCN"))
        '    lobjParams.Add("PSCMNDA1", objParametro("PSCMNDA"))
        '    lobjParams.Add("PNFECFAC", objParametro("PNFECFAC"))
        '    lobjParams.Add("PNFATNSR", objParametro("PNFATNSR"))
        '    objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
        '    'dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_FACTURA_DETALLE_SERVICIOS_PRUEBA", lobjParams)
        '    dt = objSql.ExecuteDataSet("SP_SOLMIN_ST_FACTURA_DETALLE_SERVICIOS_LOTE", lobjParams)
        '    'Catch ex As Exception
        '    '    dt = Nothing
        '    'End Try
        '    Return dt
        'End Function

    Public Function Lista_Detalle_Servicios(ByVal objParametro As Hashtable) As DataTable
      Dim dt As DataTable
      Dim lobjParams As New Parameter
            'Try
            lobjParams.Add("PNNOPRCN", objParametro("PNNOPRCN"))
            lobjParams.Add("PSCMNDA1", objParametro("PSCMNDA"))
            lobjParams.Add("PNFECFAC", objParametro("PNFECFAC"))
            lobjParams.Add("PNFATNSR", objParametro("PNFATNSR"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            'dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_FACTURA_DETALLE_SERVICIOS_PRUEBA", lobjParams)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_FACTURA_DETALLE_SERVICIOS", lobjParams)
            'Catch ex As Exception
            '          dt = Nothing
            '      End Try

            Return dt
        End Function
        Public Function Lista_Detalle_Servicios_Notas(ByVal objParametro As Hashtable) As DataTable
            Dim dt As DataTable
            Dim lobjParams As New Parameter
            'Try
            lobjParams.Add("PNNOPRCN", objParametro("PNNOPRCN"))
            lobjParams.Add("PNNDCMFC", objParametro("PNNDCMFC"))
            lobjParams.Add("PSCMNDA1", objParametro("PSCMNDA"))
            lobjParams.Add("PNFECFAC", objParametro("PNFECFAC"))
            lobjParams.Add("PNFATNSR", objParametro("PNFATNSR"))
            lobjParams.Add("PNCTPODC", objParametro("PNCTPODC"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            'dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_FACTURA_DETALLE_SERVICIOS_PRUEBA", lobjParams)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_REFACTURA_DETALLE_SERVICIOS_NOTAS", lobjParams)
            'Catch ex As Exception
            '    dt = Nothing
            'End Try

            Return dt
        End Function
        
        Public Function Lista_Detalle_Servicios_ReFactura(ByVal objParametro As Hashtable) As DataTable
            Dim dt As DataTable
            Dim lobjParams As New Parameter
            'Try
            lobjParams.Add("PNNOPRCN", objParametro("PNNOPRCN"))
            lobjParams.Add("PSCMNDA1", objParametro("PSCMNDA"))
            lobjParams.Add("PNFECFAC", objParametro("PNFECFAC"))
            lobjParams.Add("PNFATNSR", objParametro("PNFATNSR"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            'dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_FACTURA_DETALLE_SERVICIOS_PRUEBA", lobjParams)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_REFACTURA_DETALLE_SERVICIOS", lobjParams)
            'Catch ex As Exception
            '    dt = Nothing
            'End Try

            Return dt
        End Function

    Public Function Lista_Datos_Planta_Cliente(ByVal objParametro As Hashtable) As DataTable
      Dim dt As DataTable
      Dim lobjParams As New Parameter
            'Try
            lobjParams.Add("PNCCLNT", objParametro("PNCCLNFC"))
            lobjParams.Add("PNCPLNCL", objParametro("PNCPLNCL"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))

            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_FACTURA_DATOS_PLANTA_CLIENTE", lobjParams)
            'Catch ex As Exception
            '          dt = Nothing
            '      End Try

            Return dt
    End Function

    Public Function Lista_Datos_Planta(ByVal objParametro As Hashtable) As DataTable
      Dim dt As DataTable
      Dim lobjParams As New Parameter
            'Try
            lobjParams.Add("PSCCMPN", objParametro("PSCCMPN"))
            lobjParams.Add("PSCDVSN", objParametro("PSCDVSN"))
            lobjParams.Add("PNCPLNDV", objParametro("PNCPLDVN"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_FACTURA_DATOS_PLANTA", lobjParams)
            'Catch ex As Exception
            '          dt = Nothing
            '      End Try

            Return dt
    End Function

    Public Function Lista_Datos_Servicio(ByVal pobjFiltro As Hashtable) As DataTable
      Dim dt As DataTable
      Dim lobjParams As New Parameter
            'Try
            lobjParams.Add("PSCCMPN", pobjFiltro("PSCCMPN"))
            lobjParams.Add("PSCDVSN", pobjFiltro("PSCDVSN"))
            lobjParams.Add("PNCSRVNV", pobjFiltro("PNCSRVNV"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_FACTURA_DATOS_SERVICIO", lobjParams)
            'Catch ex As Exception
            '          dt = Nothing
            '      End Try

            Return dt
    End Function

    Public Function Lista_Datos_Factura(ByVal pobjFiltro As Hashtable) As DataSet
      Dim ds As DataSet
      Dim lobjParams As New Parameter
            'Try
            lobjParams.Add("PSCCMPN", pobjFiltro("PSCCMPN"))
            lobjParams.Add("PSCDVSN", pobjFiltro("PSCDVSN"))
            lobjParams.Add("PNCTPODC", pobjFiltro("PNCTPODC"))
            lobjParams.Add("PNNDCCTC", pobjFiltro("PNNDCCTC"))
            lobjParams.Add("PNESTADO", pobjFiltro("PNESTADO"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
            'ds = objSql.ExecuteDataSet("SP_SOLMIN_ST_FACTURA_LISTA_DATOS_FACTURA", lobjParams)
            ds = objSql.ExecuteDataSet("SP_SOLMIN_ST_FACTURA_LISTA_DATOS_FACTURA_V2", lobjParams)
            'Catch ex As Exception
            '          ds = Nothing
            '      End Try

            Return ds
    End Function

        Public Function Grabar_Cabecera_ReFactura(ByVal pobjArr As Object) As DataTable
            Dim dt As DataTable
            Dim lobjParams As New Parameter
            'Try
            lobjParams.Add("PSCCMPN", pobjArr(0).ToString.Trim)
            lobjParams.Add("PSCTPCTR", pobjArr(1).ToString.Trim)
            lobjParams.Add("PNCTPODC", pobjArr(2).ToString.Trim)
            lobjParams.Add("PNNINDRN", pobjArr(3).ToString.Trim)
            lobjParams.Add("PSCDVSN", pobjArr(4).ToString.Trim)
            lobjParams.Add("PSCGRONG", pobjArr(5).ToString.Trim)
            lobjParams.Add("PNCZNFCC", pobjArr(6).ToString.Trim)
            lobjParams.Add("PNCCBRD", pobjArr(7).ToString.Trim)
            lobjParams.Add("PNCCLNT", pobjArr(8).ToString.Trim)
            lobjParams.Add("PNCPLNCL", pobjArr(9).ToString.Trim)
            lobjParams.Add("PNNRUC", pobjArr(10).ToString.Trim)
            lobjParams.Add("PSCSTCDC", pobjArr(11).ToString.Trim)
            lobjParams.Add("PNCPLNDV", pobjArr(12).ToString.Trim)
            lobjParams.Add("PSSABOPN", pobjArr(13).ToString.Trim)
            lobjParams.Add("PNFDCCTC", pobjArr(14).ToString.Trim)
            lobjParams.Add("PNCMNDA", pobjArr(15).ToString.Trim)
            lobjParams.Add("PNIVLAFS", pobjArr(16).ToString.Trim)
            lobjParams.Add("PNIVLNAS", pobjArr(17).ToString.Trim)
            lobjParams.Add("PNIVLIGS", pobjArr(18).ToString.Trim)
            lobjParams.Add("PNITTFCS", pobjArr(19).ToString.Trim)
            lobjParams.Add("PNITTPGS", pobjArr(20).ToString.Trim)
            lobjParams.Add("PNIVLAFD", pobjArr(21).ToString.Trim)
            lobjParams.Add("PNIVLNAD", pobjArr(22).ToString.Trim)
            lobjParams.Add("PNIVLIGD", pobjArr(23).ToString.Trim)
            lobjParams.Add("PNITTFCD", pobjArr(24).ToString.Trim)
            lobjParams.Add("PNITTPGD", pobjArr(25).ToString.Trim)
            lobjParams.Add("PNITCCTC", pobjArr(26).ToString.Trim)
            lobjParams.Add("PSSFLLTR", pobjArr(27).ToString.Trim)
            lobjParams.Add("PSCZNCBD", pobjArr(28).ToString.Trim)
            lobjParams.Add("PNCCNCSC", pobjArr(29).ToString.Trim)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
            lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
            lobjParams.Add("PSNTRMCR", HelpClass.NombreMaquina)
            lobjParams.Add("PNNDSPGD", pobjArr(30))
            lobjParams.Add("PSCRGVTA", pobjArr(31))
            lobjParams.Add("PNFATNSR", pobjArr(32))
            lobjParams.Add("PNCTPDCO", pobjArr(33))
            lobjParams.Add("PNNDCMOR", pobjArr(34))
            lobjParams.Add("PNFDCMOR", pobjArr(35))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjArr(0).ToString.Trim)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_REFACTURA_GRABAR_CABECERA", lobjParams)
            'Catch ex As Exception
            '    dt = Nothing
            'End Try
            Return dt
        End Function
        Public Function Grabar_Cabecera_Factura(ByVal pobjArr As Object) As DataTable
            Dim dt As DataTable
            Dim lobjParams As New Parameter
            'Try
            lobjParams.Add("PSCCMPN", pobjArr(0).ToString.Trim)
            lobjParams.Add("PSCTPCTR", pobjArr(1).ToString.Trim)
            lobjParams.Add("PNCTPODC", pobjArr(2).ToString.Trim)
            lobjParams.Add("PNNINDRN", pobjArr(3).ToString.Trim)
            lobjParams.Add("PSCDVSN", pobjArr(4).ToString.Trim)
            lobjParams.Add("PSCGRONG", pobjArr(5).ToString.Trim)
            lobjParams.Add("PNCZNFCC", pobjArr(6).ToString.Trim)
            lobjParams.Add("PNCCBRD", pobjArr(7).ToString.Trim)
            lobjParams.Add("PNCCLNT", pobjArr(8).ToString.Trim)
            lobjParams.Add("PNCPLNCL", pobjArr(9).ToString.Trim)
            lobjParams.Add("PNNRUC", pobjArr(10).ToString.Trim)
            lobjParams.Add("PSCSTCDC", pobjArr(11).ToString.Trim)
            lobjParams.Add("PNCPLNDV", pobjArr(12).ToString.Trim)
            lobjParams.Add("PSSABOPN", pobjArr(13).ToString.Trim)
            lobjParams.Add("PNFDCCTC", pobjArr(14).ToString.Trim)
            lobjParams.Add("PNCMNDA", pobjArr(15).ToString.Trim)
            lobjParams.Add("PNIVLAFS", pobjArr(16).ToString.Trim)
            lobjParams.Add("PNIVLNAS", pobjArr(17).ToString.Trim)
            lobjParams.Add("PNIVLIGS", pobjArr(18).ToString.Trim)
            lobjParams.Add("PNITTFCS", pobjArr(19).ToString.Trim)
            lobjParams.Add("PNITTPGS", pobjArr(20).ToString.Trim)
            lobjParams.Add("PNIVLAFD", pobjArr(21).ToString.Trim)
            lobjParams.Add("PNIVLNAD", pobjArr(22).ToString.Trim)
            lobjParams.Add("PNIVLIGD", pobjArr(23).ToString.Trim)
            lobjParams.Add("PNITTFCD", pobjArr(24).ToString.Trim)
            lobjParams.Add("PNITTPGD", pobjArr(25).ToString.Trim)
            lobjParams.Add("PNITCCTC", pobjArr(26).ToString.Trim)
            lobjParams.Add("PNCTPDCO", pobjArr(27).ToString.Trim)
            lobjParams.Add("PNNDCMOR", pobjArr(28).ToString.Trim)
            lobjParams.Add("PNFDCMOR", pobjArr(29).ToString.Trim)
            lobjParams.Add("PSSFLLTR", pobjArr(30).ToString.Trim)
            lobjParams.Add("PSCZNCBD", pobjArr(31).ToString.Trim)
            lobjParams.Add("PNCCNCSC", pobjArr(32).ToString.Trim)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
            lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
            lobjParams.Add("PSNTRMCR", HelpClass.NombreMaquina)
            lobjParams.Add("PNNDSPGD", pobjArr(33))
            lobjParams.Add("PSCRGVTA", pobjArr(34))
            lobjParams.Add("PNFATNSR", pobjArr(35))
            'lobjParams.Add("PNOCompra", pobjArr(36).ToString.Trim) 'OMVB REQ11072019  ORDEN DE COMPRA
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjArr(0).ToString.Trim)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_FACTURA_GRABAR_CABECERA", lobjParams)
            'Catch ex As Exception
            '    dt = Nothing
            'End Try
            Return dt
        End Function
        Public Sub Grabar_Detalle_ReFactura(ByVal pobjArr As Object)
            'Try

            Dim lobjParams As New Parameter

            lobjParams.Add("PSCCMPN", pobjArr(0).ToString.Trim)
            lobjParams.Add("PNCTPODC", pobjArr(1).ToString.Trim)
            lobjParams.Add("PNNDCCTC", pobjArr(2).ToString.Trim)
            lobjParams.Add("PNNINDRN", pobjArr(3).ToString.Trim)
            lobjParams.Add("PNNCRDCC", pobjArr(4).ToString.Trim)
            lobjParams.Add("PNCRBCTC", pobjArr(5).ToString.Trim)
            lobjParams.Add("PSSTCCTC", pobjArr(6).ToString.Trim)
            lobjParams.Add("PSCUNCNA", pobjArr(7).ToString.Trim)
            lobjParams.Add("PNQAPCTC", pobjArr(8).ToString.Trim)
            lobjParams.Add("PSCUTCTC", pobjArr(9).ToString.Trim)
            lobjParams.Add("PNITRCTC", pobjArr(10).ToString.Trim)
            lobjParams.Add("PNIVLDCS", pobjArr(11).ToString.Trim)
            lobjParams.Add("PNIVLDCD", pobjArr(12).ToString.Trim)
            lobjParams.Add("PNNCTDCC", pobjArr(13).ToString.Trim)
            lobjParams.Add("PNFDCCTC", pobjArr(14).ToString.Trim)
            lobjParams.Add("PSCDVSN", pobjArr(15).ToString.Trim)
            lobjParams.Add("PSCGRNGD", pobjArr(16).ToString.Trim)
            lobjParams.Add("PNCCNCSD", pobjArr(17).ToString.Trim)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
            lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
            lobjParams.Add("PSNTRMCR", HelpClass.NombreMaquina)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjArr(0).ToString.Trim)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_REFACTURA_GRABAR_DETALLE", lobjParams)
            'Catch ex As Exception
            '    Throw New Exception(ex.Message)
            'End Try
        End Sub
        Public Sub Grabar_Detalle_Factura(ByVal pobjArr As Object)
            'Try

            Dim lobjParams As New Parameter

            lobjParams.Add("PSCCMPN", pobjArr(0).ToString.Trim)
            lobjParams.Add("PNCTPODC", pobjArr(1).ToString.Trim)
            lobjParams.Add("PNNDCCTC", pobjArr(2).ToString.Trim)
            lobjParams.Add("PNNINDRN", pobjArr(3).ToString.Trim)
            lobjParams.Add("PNNCRDCC", pobjArr(4).ToString.Trim)
            lobjParams.Add("PNCRBCTC", pobjArr(5).ToString.Trim)
            lobjParams.Add("PSSTCCTC", pobjArr(6).ToString.Trim)
            lobjParams.Add("PSCUNCNA", pobjArr(7).ToString.Trim)
            lobjParams.Add("PNQAPCTC", pobjArr(8).ToString.Trim)
            lobjParams.Add("PSCUTCTC", pobjArr(9).ToString.Trim)
            lobjParams.Add("PNITRCTC", pobjArr(10).ToString.Trim)
            lobjParams.Add("PNIVLDCS", pobjArr(11).ToString.Trim)
            lobjParams.Add("PNIVLDCD", pobjArr(12).ToString.Trim)
            lobjParams.Add("PNNCTDCC", pobjArr(13).ToString.Trim)
            lobjParams.Add("PNFDCCTC", pobjArr(14).ToString.Trim)
            lobjParams.Add("PSCDVSN", pobjArr(15).ToString.Trim)
            lobjParams.Add("PSCGRNGD", pobjArr(16).ToString.Trim)
            lobjParams.Add("PNCCNCSD", pobjArr(17).ToString.Trim)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
            lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
            lobjParams.Add("PSNTRMCR", HelpClass.NombreMaquina)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjArr(0).ToString.Trim)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_FACTURA_GRABAR_DETALLE", lobjParams)
            'Catch ex As Exception
            '    Throw New Exception(ex.Message)
            'End Try
        End Sub

    Public Sub Grabar_Referencia_Factura(ByVal pobjArr As Object)
            'Try

            Dim lobjParams As New Parameter

            lobjParams.Add("PSCCMPN", pobjArr(0).ToString.Trim)
            lobjParams.Add("PNCTPODC", pobjArr(1).ToString.Trim)
            lobjParams.Add("PNNDCCTC", pobjArr(2).ToString.Trim)
            lobjParams.Add("PNNINDRN", pobjArr(3).ToString.Trim)
            lobjParams.Add("PNCTPDCC", pobjArr(4).ToString.Trim)
            lobjParams.Add("PSTOBCTC", pobjArr(5).ToString.Trim)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
            lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
            lobjParams.Add("PSNTRMCR", HelpClass.NombreMaquina)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjArr(0).ToString.Trim)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_FACTURA_GRABAR_REFERENCIA", lobjParams)
            'Catch ex As Exception
            '          Throw New Exception(ex.Message)
            '      End Try
    End Sub
    Public Sub Actualizar_Detalle_ReFacturado(ByVal pobjFiltro As Hashtable)
            'Try

            Dim lobjParams As New Parameter

            lobjParams.Add("PNNOPRCN", pobjFiltro("PNNOPRCN"))
            lobjParams.Add("PNNGUIRM", pobjFiltro("PNNGUIRM"))
            lobjParams.Add("PNCRBCTC", pobjFiltro("PNCRBCTC"))
            lobjParams.Add("PNQCNDTG", pobjFiltro("PNQCNDTG")) 'CANTIDAD
            lobjParams.Add("PSCUNDSR", pobjFiltro("PSCUNDSR")) 'CODIGO UNIDAD SERVICIO
            lobjParams.Add("PNISRVGU", pobjFiltro("PNISRVGU")) 'IMPORTE
            lobjParams.Add("PNIVLRLV", pobjFiltro("PNIVLRLV")) 'IMPORTE VALOR REAL
            lobjParams.Add("PNCMNDGU", pobjFiltro("PNCMNDGU"))
            lobjParams.Add("PNCTPODC", pobjFiltro("PNCTPODC"))
            lobjParams.Add("PNNDCMFC", pobjFiltro("PNNDCMFC"))
            lobjParams.Add("PNFECFAC", pobjFiltro("PNFECFAC"))
            lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
            lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd"))
            lobjParams.Add("PNHULTAC", Format(Now, "HHmmss"))
            lobjParams.Add("PSNTRMNL", HelpClass.NombreMaquina)
            lobjParams.Add("PSLIBERAR", pobjFiltro("PSLIBERAR"))
            lobjParams.Add("PNCTPDCO", pobjFiltro("PNCTPDCO"))
            lobjParams.Add("PNNDCMOR", pobjFiltro("PNNDCMOR"))

            lobjParams.Add("PNISRVGF", pobjFiltro("PNISRVGF"))
            lobjParams.Add("PNCMNDGF", pobjFiltro("PNCMNDGF"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_REFACTURA_ACTUALIZAR_DETALLE_REFACTURADO", lobjParams)
            'Catch ex As Exception
            '          Throw New Exception(ex.Message)
            '      End Try
    End Sub
        Public Sub Actualizar_Detalle_Facturado(ByVal pobjFiltro As Hashtable)
            'Try

            Dim lobjParams As New Parameter

            lobjParams.Add("PNNOPRCN", pobjFiltro("PNNOPRCN"))
            lobjParams.Add("PNNGUIRM", pobjFiltro("PNNGUIRM"))
            lobjParams.Add("PNCRBCTC", pobjFiltro("PNCRBCTC"))
            lobjParams.Add("PNQCNDTG", pobjFiltro("PNQCNDTG")) 'CANTIDAD
            lobjParams.Add("PSCUNDSR", pobjFiltro("PSCUNDSR")) 'CODIGO UNIDAD SERVICIO
            lobjParams.Add("PNISRVGU", pobjFiltro("PNISRVGU")) 'IMPORTE
            lobjParams.Add("PNCMNDGU", pobjFiltro("PNCMNDGU"))
            lobjParams.Add("PNCTPODC", pobjFiltro("PNCTPODC"))
            lobjParams.Add("PNNDCMFC", pobjFiltro("PNNDCMFC"))
            lobjParams.Add("PNFECFAC", pobjFiltro("PNFECFAC"))
            lobjParams.Add("PNFLGFAC", pobjFiltro("PNFLGFAC"))
            lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
            lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd"))
            lobjParams.Add("PNHULTAC", Format(Now, "HHmmss"))
            lobjParams.Add("PSNTRMNL", HelpClass.NombreMaquina)


            lobjParams.Add("PNISRVGF", pobjFiltro("PNISRVGF"))
            lobjParams.Add("PNCMNDGF", pobjFiltro("PNCMNDGF"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_FACTURA_ACTUALIZAR_DETALLE_FACTURADO", lobjParams)
            'Catch ex As Exception
            '    Throw New Exception(ex.Message)
            'End Try
        End Sub

        'Public Sub Actualizar_Detalle_Facturado_Lote(ByVal pobjFiltro As Hashtable)
        '    'Try

        '    Dim lobjParams As New Parameter

        '    lobjParams.Add("PNNOPRCN", pobjFiltro("PNNOPRCN"))
        '    lobjParams.Add("PNNGUIRM", pobjFiltro("PNNGUIRM"))
        '    lobjParams.Add("PNCRBCTC", pobjFiltro("PNCRBCTC"))
        '    lobjParams.Add("PNQCNDTG", pobjFiltro("PNQCNDTG")) 'CANTIDAD
        '    lobjParams.Add("PSCUNDSR", pobjFiltro("PSCUNDSR")) 'CODIGO UNIDAD SERVICIO
        '    lobjParams.Add("PNISRVGU", pobjFiltro("PNISRVGU")) 'IMPORTE
        '    lobjParams.Add("PNCMNDGU", pobjFiltro("PNCMNDGU"))
        '    lobjParams.Add("PNCTPODC", pobjFiltro("PNCTPODC"))
        '    lobjParams.Add("PNNDCMFC", pobjFiltro("PNNDCMFC"))
        '    lobjParams.Add("PNFECFAC", pobjFiltro("PNFECFAC"))
        '    lobjParams.Add("PNFLGFAC", pobjFiltro("PNFLGFAC"))

        '    lobjParams.Add("PNPSOVOL", pobjFiltro("PNPESOVOL"))
        '    lobjParams.Add("PNPESO", pobjFiltro("PNPESO"))

        '    lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        '    lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd"))
        '    lobjParams.Add("PNHULTAC", Format(Now, "HHmmss"))
        '    lobjParams.Add("PSNTRMNL", HelpClass.NombreMaquina)

        '    lobjParams.Add("PNISRVGF", pobjFiltro("PNISRVGF"))
        '    lobjParams.Add("PNCMNDGF", pobjFiltro("PNCMNDGF"))

        '    objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
        '    objSql.ExecuteNonQuery("SP_SOLMIN_ST_FACTURA_ACTUALIZAR_DETALLE_FACTURADO_LOTE", lobjParams)
        '    'Catch ex As Exception
        '    '    Throw New Exception(ex.Message)
        '    'End Try
        'End Sub


    Public Sub Enviar_Documento_SAP(ByVal pobjFiltro As Hashtable)
            Try
                Dim lobjParams As New Parameter

                lobjParams.Add("PSCCMPN", pobjFiltro("PSCCMPN"))
                lobjParams.Add("PSCTPODC", pobjFiltro("PSCTPODC"))
                lobjParams.Add("PSNDCCTC", pobjFiltro("PSNDCCTC"))
                'objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
                objSql.ExecuteNonQuery("SP_SOLMIN_AS400_CL_RSAP104", lobjParams)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
    End Sub

    Public Function Comprobar_Envio_Documento_SAP(ByVal pobjFiltro As Hashtable) As DataTable
      Dim dt As DataTable
      Dim lobjParams As New Parameter

      lobjParams.Add("PSCCMPN", pobjFiltro("PSCCMPN"))
      lobjParams.Add("PNCTPODC", pobjFiltro("PNCTPODC"))
      lobjParams.Add("PNNDCCTC", pobjFiltro("PNNDCCTC"))
      objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
      dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_FACTURA_COMPROBAR_ENVIO_DOCUMENTO", lobjParams)
      Return dt
    End Function

        'Public Function Registrar_Orden_Interna_Factura_Lote(ByVal pobjFiltro As Hashtable) As Int32
        '    Dim lintEstado As Int32 = 0
        '    Dim lobjParams As New Parameter
        '    Try
        '        lobjParams.Add("PSCCMPN", pobjFiltro("PSCCMPN"))
        '        lobjParams.Add("PNCTPODC", pobjFiltro("PSCTPODC"))
        '        lobjParams.Add("PNNDCCTC", pobjFiltro("PSNDCCTC"))

        '        lobjParams.Add("PSNOPRCN", pobjFiltro("PSNOPRCN"))
        '        lobjParams.Add("PSNGUIRM", pobjFiltro("PSNGUIRM"))
        '        lobjParams.Add("PSCSRVC", pobjFiltro("PSCSRVC"))
        '        lobjParams.Add("PSISRVGU", pobjFiltro("PSISRVGU"))

        '        lobjParams.Add("PNFECFAC", pobjFiltro("PNFECFAC"))
        '        lobjParams.Add("PNMONEDA", pobjFiltro("PNMONEDA"))
        '        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        '        lobjParams.Add("PNFCHCRT", Format(Now, "yyyyMMdd"))
        '        lobjParams.Add("PNHRACRT", Format(Now, "HHmmss"))
        '        lobjParams.Add("PSNTRMCR", HelpClass.NombreMaquina)
        '        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
        '        objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_ORDEN_INTERNA_FACTURA_LOTE", lobjParams)
        '        lintEstado = 1
        '    Catch ex As Exception
        '        lintEstado = 0
        '    End Try

        '    Return lintEstado
        'End Function

    Public Function Registrar_Orden_Interna_Factura(ByVal pobjFiltro As Hashtable) As Int32
      Dim lintEstado As Int32 = 0
      Dim lobjParams As New Parameter
      Try
        lobjParams.Add("PSCCMPN", pobjFiltro("PSCCMPN"))
        lobjParams.Add("PNCTPODC", pobjFiltro("PSCTPODC"))
        lobjParams.Add("PNNDCCTC", pobjFiltro("PSNDCCTC"))
        lobjParams.Add("PNFECFAC", pobjFiltro("PNFECFAC"))
        lobjParams.Add("PNMONEDA", pobjFiltro("PNMONEDA"))
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNFCHCRT", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHRACRT", Format(Now, "HHmmss"))
        lobjParams.Add("PSNTRMCR", HelpClass.NombreMaquina)
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_ORDEN_INTERNA_FACTURA", lobjParams)
        lintEstado = 1
      Catch ex As Exception
        lintEstado = 0
      End Try

      Return lintEstado
    End Function

        'Public Function Cerrar_Orden_Interna_Factura(ByVal pobjFiltro As Hashtable) As Int32
        '    Dim lintEstado As Int32 = 0
        '    Dim lobjParams As New Parameter
        '    Try
        '        lobjParams.Add("PNCTPODC", pobjFiltro("PSCTPODC"))
        '        lobjParams.Add("PNNDCCTC", pobjFiltro("PSNDCCTC"))
        '        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
        '        objSql.ExecuteNonQuery("SP_SOLMIN_ST_CERRAR_ORDEN_INTERNA_SAP", lobjParams)
        '        lintEstado = 1
        '    Catch ex As Exception
        '        lintEstado = 0
        '    End Try
        '    Return lintEstado
        'End Function

        Public Function Obtener_Fecha_Servidor() As Date
            Dim lobjParams As New Parameter
            Dim strFecha As Date
            'Try
            lobjParams.Add("DTFECHA", "", ParameterDirection.Output)
            objSql.ExecuteNonQuery("SP_SOLMIN_OBTENER_FECHA_SERVIDOR", lobjParams)
            strFecha = objSql.ParameterCollection("DTFECHA")
            'Catch : End Try
            Return strFecha
        End Function

    'Public Function Obtener_Fecha_Factura_Ultima() As Date
    '  Dim lobjParams As New Parameter
    '  Dim strFecha As Date
    '  Try
    '    lobjParams.Add("DTFECHA", "", ParameterDirection.Output)
    '    objSql.ExecuteNonQuery("SP_SOLMIN_OBTENER_FECHA_SERVIDOR", lobjParams)
    '    strFecha = objSql.ParameterCollection("DTFECHA")
    '  Catch : End Try
    '  Return strFecha
    'End Function

    Public Function Obtener_Referencia_Ruta(ByVal pstrOperacion As String, ByVal strCodCom As String) As String
            Dim dt As DataTable
            Dim ruta As String = ""
      Dim lobjParams As New Parameter
            'Try
            lobjParams.Add("PSNOPRCN", pstrOperacion)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCodCom)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_FACTURA_OBTENER_REFERENCIA_RUTA", lobjParams)
            If dt.Rows.Count > 0 Then
                ruta = dt.Rows(0).Item("RUTA").ToString
            End If
            'Catch ex As Exception
            '          dt = Nothing
            '      End Try
            Return ruta
        End Function


        Public Function Obtener_Referencia_Documento(ByVal pstrOperacion As String, ByVal strCodCom As String) As DataSet
            Dim ds As DataSet
            Dim lobjParams As New Parameter
            'Try
            lobjParams.Add("PSNOPRCN", pstrOperacion)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCodCom)
            ds = objSql.ExecuteDataSet("SP_SOLMIN_ST_FACTURA_OBTENER_REFERENCIA_DOCUMENTO", lobjParams)

            'Catch ex As Exception
            '    ds = Nothing
            'End Try
            Return ds
        End Function



    Public Function Validar_Cliente_SAP(ByVal objParameter As Hashtable) As String

      Dim lobjParams As New Parameter
      Dim strResultado As String = ""
      Try
        lobjParams.Add("PSCCMPN", objParameter("CCMPN"))
        lobjParams.Add("PSCDVSN", objParameter("CDVSN"))
        lobjParams.Add("PSCRGVTA", objParameter("CRGVTA"))
        lobjParams.Add("PNCCLNT", objParameter("CCLNT"))
        lobjParams.Add("PARAM_MSGRET", "", ParameterDirection.Output)
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParameter("CCMPN"))
        objSql.ExecuteNonQuery("SP_SOLMIN_AS400_CL_SAP103C", lobjParams)
        strResultado = objSql.ParameterCollection("PARAM_MSGRET").ToString.Trim
      Catch ex As Exception
        strResultado = "" ' ex.Message.ToString.Trim
      End Try
      Return strResultado
    End Function

    Public Function Mostrar_Factura_Detallada(ByVal pobjFiltro As Hashtable) As DataTable
      Dim dt As DataTable
      Dim lobjParams As New Parameter
            'Try
            lobjParams.Add("PSNOPRCN", pobjFiltro("PSNOPRCN"))
            lobjParams.Add("PNFECFAC", pobjFiltro("PNFECFAC"))
            'lobjParams.Add("PSCMNDA", pobjFiltro("PSCMNDA"))
            lobjParams.Add("PSCCMPN", pobjFiltro("PSCCMPN"))
            lobjParams.Add("PSCDVSN", pobjFiltro("PSCDVSN"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_IMPRIMIR_SUSTENTO_FACTURA_1", lobjParams)
            'Catch ex As Exception
            '          dt = Nothing
            '      End Try

            Return dt
    End Function
        Public Function Mostrar_ReFactura_Detallada(ByVal pobjFiltro As Hashtable) As DataTable
            Dim dt As DataTable
            Dim lobjParams As New Parameter
            'Try
            lobjParams.Add("PSNOPRCN", pobjFiltro("PSNOPRCN"))
            lobjParams.Add("PNFECFAC", pobjFiltro("PNFECFAC"))
            lobjParams.Add("PNCTPODC", pobjFiltro("PNCTPODC"))
            lobjParams.Add("PSCCMPN", pobjFiltro("PSCCMPN"))
            lobjParams.Add("PSCDVSN", pobjFiltro("PSCDVSN"))
            lobjParams.Add("PNTPCMBO", pobjFiltro("PNTPCMBO"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_IMPRIMIR_SUSTENTO_REFACTURA", lobjParams)
            'Catch ex As Exception
            '    dt = Nothing
            'End Try

            Return dt
        End Function
        Public Function Listar_Facturas_X_Operaciones_Liberadas(ByVal pobjFiltro As Hashtable) As DataTable
            Dim dt As DataTable
            Dim lobjParams As New Parameter
            'Try
            lobjParams.Add("PSNOPRCN", pobjFiltro("PSNOPRCN"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_FACTURAS_X_OPERACIONES_LIBERADAS", lobjParams)
            'Catch ex As Exception
            '    dt = Nothing
            'End Try

            Return dt
        End Function

        Public Function Listar_Importes_Servicio_Operaciones(ByVal objParametro As Hashtable) As DataTable
            Dim dt As DataTable
            Dim lobjParams As New Parameter
            'Try
            lobjParams.Add("PSNOPRCN", objParametro("PSNOPRCN"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_IMPORTE_SERVICIO", lobjParams)
            'Catch ex As Exception
            '    dt = Nothing
            'End Try
            Return dt
        End Function

        Public Sub Actualizar_Facturacion_Libre(ByVal pobjFiltro As Hashtable) 'As Int32
            Dim lintEstado As Int32 = 0
            'Try
            Dim lobjParams As New Parameter
            lobjParams.Add("PNNOPRCN", pobjFiltro("PNNOPRCN2"))
            lobjParams.Add("PNCTPDCF", pobjFiltro("PNCTPDCF"))
            lobjParams.Add("PNNDCMFC", pobjFiltro("PNNDCMFC"))
            lobjParams.Add("PSSESTOP", pobjFiltro("PSSESTOP"))
            'lobjParams.Add("PNFECFAC", pobjFiltro("PNFECFAC"))
            lobjParams.Add("PSTRFSRC", pobjFiltro("PSTRFSRC"))
            lobjParams.Add("PSCCMPN", pobjFiltro("PSCCMPN"))
            lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
            lobjParams.Add("PSNTRMNL", HelpClass.NombreMaquina)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_FACTURACION_LIBRE", lobjParams)
            '    lintEstado = 0
            'Catch ex As Exception
            '    lintEstado = 1
            'End Try
            'Return lintEstado
        End Sub

        Public Function Validar_Facturacion_Libre(ByVal pobjFiltro As Hashtable, ByRef sMensajeError As String) As Boolean 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
            Dim output As New DataTable 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
            Dim bResultado As Boolean = True
            Try
                Dim lobjParams As New Parameter
                lobjParams.Add("PSCCMPN", pobjFiltro("PSCCMPN"))
                lobjParams.Add("PNNOPRCN", pobjFiltro("PNNOPRCN"))
                lobjParams.Add("PNCTPDCF", pobjFiltro("PNCTPDCF"))
                lobjParams.Add("PNNDCMFC", pobjFiltro("PNNDCMFC"))

                lobjParams.Add("PSFLAGDOCSAP", pobjFiltro("PSFLAGDOCSAP"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
                output = objSql.ExecuteDataTable("SP_SOLMIN_ST_VALIDAR_FACTURACION_LIBRE", lobjParams)
               
                If Not output Is Nothing Then
                    For Each row As DataRow In output.Rows
                        If row("STATUS").ToString.Trim = "N" Then
                            sMensajeError += row("OBSRESULT").ToString.Trim & Environment.NewLine
                        End If
                    Next
                Else
                    sMensajeError = "No se ha encontrado registros en la tabla."
                    bResultado = False
                End If
                'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN

                If sMensajeError <> "" Then bResultado = False
            Catch ex As Exception
                sMensajeError = ex.Message
                bResultado = False
            End Try
            Return bResultado
        End Function

        Public Sub fintActualizarFacturaDetracionSPOT(ByVal pobjFiltro As Hashtable)
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            Dim dt As New DataTable
            lobjParams.Add("PSCCMPN", pobjFiltro("PSCCMPN"))
            lobjParams.Add("PNCTPODC", pobjFiltro("PNCTPODC"))
            lobjParams.Add("PNNDCFCC", pobjFiltro("PNNDCFCC"))
            lobjSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
            lobjSql.ExecuteNonQuery("SP_SOLMIN_ST_FACTURA_GRABAR_DETRACCION_SPOT", lobjParams)
        End Sub

        Public Sub Registrar_Refactura_Historial_RZCT34(ByVal pobjFiltro As Hashtable)
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            Dim dt As New DataTable
            lobjParams.Add("PSCCMPN", pobjFiltro("PSCCMPN"))
            lobjParams.Add("PNTDOCOR", pobjFiltro("PNTDOCOR"))
            lobjParams.Add("PNNDOCOR", pobjFiltro("PNNDOCOR"))
            lobjParams.Add("PNTDOCGN", pobjFiltro("PNTDOCGN"))
            lobjParams.Add("PNNDOCGN", pobjFiltro("PNNDOCGN"))
            lobjParams.Add("PSFLGRFC", pobjFiltro("PSFLGRFC"))
            lobjParams.Add("PNTOR_HIST", pobjFiltro("PNTOR_HIST"))
            lobjParams.Add("PNNDOC_HIST", pobjFiltro("PNNDOC_HIST"))         
            lobjParams.Add("PSUSRCRT", ConfigurationWizard.UserName)
            lobjParams.Add("PSPRGCRT", pobjFiltro("PSPRGCRT"))
            lobjParams.Add("PSNTRMNL", HelpClass.NombreMaquina)
            lobjSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
            lobjSql.ExecuteNonQuery("SP_SOLMIN_ST_FACTURA_GRABAR_HISTORIAL_REFACTURA_RZCT34", lobjParams)
        End Sub


        Public Function Lista_Datos_Cuenta_Corriente(ByVal pobjFiltro As Hashtable) As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            Dim dt As New DataTable
            lobjParams.Add("PSCCMPN", pobjFiltro("PSCCMPN"))
            lobjParams.Add("PNCTPODC", pobjFiltro("PNCTPODC"))
            lobjParams.Add("PNNDCCTC", pobjFiltro("PNNDCCTC"))
            lobjSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_DOC_CUENTA_CTE", lobjParams)
            Return dt
        End Function

        ''' <summary>
        ''' Revierte las operaciones provisionadas
        ''' </summary>
        ''' <param name="pobjFiltro"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function fintRevertirProvisionXFactura(ByVal pobjFiltro As Hashtable, EsxPorPreDocumento As Boolean) As Integer
            'Try
            Dim EsPreDocumento As String = "N"
            If EsxPorPreDocumento = True Then
                EsPreDocumento = "S"
            End If
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            Dim dt As New DataTable
            lobjParams.Add("PSCCMPN", pobjFiltro("PSCCMPN"))
            lobjParams.Add("PNCTPODC", pobjFiltro("PNCTPODC"))
            lobjParams.Add("PNNDCMFC", pobjFiltro("PNNDCMFC"))
            lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
            lobjParams.Add("PSNTRMNL", HelpClass.NombreMaquina)
            lobjParams.Add("PSXPREDOC", EsPreDocumento)
            lobjSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
            'lobjSql.ExecuteNonQuery("SP_SOLMIN_CT_REVERTIR_PROVISION_OPERACIONES_TRANSPORTE_X_FACTURA", lobjParams)
            'lobjSql.ExecuteNonQuery("SP_SOLMIN_CT_REVERTIR_PROVISION_OPERACIONES_TRANSPORTE_X_FACTURA_V2", lobjParams)
            lobjSql.ExecuteNonQuery("SP_SOLMIN_CT_REVERTIR_PROVISION_OPERACIONES_TRANSPORTE_X_FACTURA_V3", lobjParams)

            Return 1
            'Catch ex As Exception
            '    Return -1
            'End Try

        End Function


#Region "GENERAL"
        Public Function Lista_Detalle_Servicios_General(ByVal objParametro As Hashtable) As DataTable
            Dim dt As DataTable
            Dim lobjParams As New Parameter
            Dim moneda As String = ("" & objParametro("PSCMNDA")).ToString.Trim
            lobjParams.Add("PNNOPRCN", objParametro("PNNOPRCN"))
            lobjParams.Add("PSCMNDA1", objParametro("PSCMNDA"))
            lobjParams.Add("PNFECFAC", objParametro("PNFECFAC"))
            lobjParams.Add("PNFATNSR", objParametro("PNFATNSR"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_FACTURA_DETALLE_SERVICIOS_GENERAL", lobjParams)
            dt.Columns.Add("ISRVGU", Type.GetType("System.Decimal"))
            dt.Columns.Add("TOTAL", Type.GetType("System.Decimal"))
            dt.Columns.Add("IMPSOL", Type.GetType("System.Decimal"))

            For Each Item As DataRow In dt.Rows
                If moneda = "SOL" Then
                    Select Case Item("CMNDA1")
                        Case 1 'SOL -> SOL
                            Item("ISRVGU") = Math.Round(Item("TARIFA"), 5)
                        Case 100 'DOL -> SOL
                            Item("ISRVGU") = Math.Round(Item("TARIFA") * Item("TIPO_CAMBIO"), 5)
                    End Select
                    Item("TOTAL") = Math.Round(Item("QATNAN") * Item("ISRVGU"), 5, MidpointRounding.AwayFromZero)

                ElseIf moneda = "DOL" Then
                    Select Case Item("CMNDA1")
                        Case 100 'DOL -> DOL
                            Item("ISRVGU") = Math.Round(Item("TARIFA"), 5)
                        Case 1 'SOL  --> DOL
                            Item("ISRVGU") = Math.Round(Item("TARIFA") / Item("TIPO_CAMBIO"), 5)
                    End Select
                    Item("TOTAL") = Math.Round(Item("QATNAN") * Item("ISRVGU"), 5, MidpointRounding.AwayFromZero)
                End If

                Select Case Item("CMNDA1")
                    Case 1
                        Item("IMPSOL") = Math.Round(Item("TARIFA"), 5)
                    Case 100
                        Item("IMPSOL") = Math.Round(Item("TARIFA") * Item("TIPO_CAMBIO"), 5)
                End Select

            Next

            Return dt
        End Function

        Public Sub Actualizar_Detalle_Facturado_General(ByVal pobjFiltro As Hashtable)
           
            Dim lobjParams As New Parameter

            lobjParams.Add("PNNOPRCN", pobjFiltro("PNNOPRCN"))
            lobjParams.Add("PNNGUIRM", pobjFiltro("PNNGUIRM"))
            lobjParams.Add("PNCRBCTC", pobjFiltro("PNCRBCTC"))
            lobjParams.Add("PNQCNDTG", pobjFiltro("PNQCNDTG")) 'CANTIDAD
            lobjParams.Add("PSCUNDSR", pobjFiltro("PSCUNDSR")) 'CODIGO UNIDAD SERVICIO
            lobjParams.Add("PNISRVGU", pobjFiltro("PNISRVGU")) 'IMPORTE
            lobjParams.Add("PNCMNDGU", pobjFiltro("PNCMNDGU"))
            lobjParams.Add("PNISRVGF", pobjFiltro("PNISRVGF"))
            lobjParams.Add("PNCMNDGF", pobjFiltro("PNCMNDGF"))
            lobjParams.Add("PNCTPODC", pobjFiltro("PNCTPODC"))
            lobjParams.Add("PNNDCMFC", pobjFiltro("PNNDCMFC"))
            lobjParams.Add("PNFECFAC", pobjFiltro("PNFECFAC"))
            lobjParams.Add("PNFLGFAC", pobjFiltro("PNFLGFAC"))
            lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
            lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd"))
            lobjParams.Add("PNHULTAC", Format(Now, "HHmmss"))
            lobjParams.Add("PSNTRMNL", HelpClass.NombreMaquina)
            lobjParams.Add("PNNCRRGU", pobjFiltro("PNNCRRGU"))


            lobjParams.Add("PNNPRLQD", pobjFiltro("PNNPRLQD"))
            lobjParams.Add("PNNPREDOC", pobjFiltro("PNNPREDOC"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_FACTURA_ACTUALIZAR_DETALLE_FACTURADO_GENERAL", lobjParams)
           
        End Sub

        Public Function Registrar_Orden_Interna_Factura_General(ByVal pobjFiltro As Hashtable, EsxPreDocumento As Boolean) As Int32
            Dim lintEstado As Int32 = 0
            Dim psPredocumento As String = "N"
            If EsxPreDocumento = True Then
                psPredocumento = "S"
            End If
            Dim lobjParams As New Parameter
            'Try
            lobjParams.Add("PSCCMPN", pobjFiltro("PSCCMPN"))
            lobjParams.Add("PNCTPODC", pobjFiltro("PSCTPODC"))
            lobjParams.Add("PNNDCCTC", pobjFiltro("PSNDCCTC"))
            lobjParams.Add("PNFECFAC", pobjFiltro("PNFECFAC"))
            lobjParams.Add("PNMONEDA", pobjFiltro("PNMONEDA"))
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            'lobjParams.Add("PNFCHCRT", Format(Now, "yyyyMMdd"))
            'lobjParams.Add("PNHRACRT", Format(Now, "HHmmss"))
            lobjParams.Add("PSNTRMCR", HelpClass.NombreMaquina)
            lobjParams.Add("PSPREDOC", psPredocumento)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
            'objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_ORDEN_INTERNA_FACTURA_GENERAL", lobjParams)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_ORDEN_INTERNA_FACTURA_GENERAL_V2", lobjParams)
            lintEstado = 1
            'Catch ex As Exception
            '    lintEstado = 0
            'End Try

            Return lintEstado
        End Function

        'Public Function Lista_Detalle_Servicios_Lote_General(ByVal objParametro As Hashtable) As DataTable
        '    'Dim ds As DataSet
        '    Dim dt As DataTable
        '    Dim lobjParams As New Parameter

        'lobjParams.Add("PNNOPRCN", objParametro("PNNOPRCN"))
        'lobjParams.Add("PSCMNDA1", objParametro("PSCMNDA"))
        'lobjParams.Add("PNFECFAC", objParametro("PNFECFAC"))
        'lobjParams.Add("PNFATNSR", objParametro("PNFATNSR"))
        'Dim moneda As String = ("" & objParametro("PSCMNDA")).ToString.Trim
        'objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
        'ds = objSql.ExecuteDataSet("SP_SOLMIN_ST_FACTURA_DETALLE_SERVICIOS_LOTE_GENERAL", lobjParams)

        'ds.Tables(0).Columns.Add("ISRVGU", Type.GetType("System.Decimal"))
        'ds.Tables(0).Columns.Add("TOTAL", Type.GetType("System.Decimal"))
        'ds.Tables(0).Columns.Add("IMPSOL", Type.GetType("System.Decimal"))

        'For Each Item As DataRow In ds.Tables(0).Rows
        '    If moneda = "SOL" Then
        '        Select Case Item("CMNDA1")
        '            Case 1 'SOL -> SOL
        '                Item("ISRVGU") = Math.Round(Item("ISRVGU_ORIGEN"), 5)
        '            Case 100 'DOL -> SOL
        '                Item("ISRVGU") = Math.Round(Item("ISRVGU_ORIGEN") * Item("TIPO_CAMBIO"), 5)
        '        End Select
        '        Item("TOTAL") = Math.Round(Item("QATNAN") * Item("ISRVGU"), 2)

        '    ElseIf moneda = "DOL" Then
        '        Select Case Item("CMNDA1")
        '            Case 100 'DOL -> DOL
        '                Item("ISRVGU") = Math.Round(Item("ISRVGU_ORIGEN"), 5)
        '            Case 1 'SOL  --> DOL
        '                Item("ISRVGU") = Math.Round(Item("ISRVGU_ORIGEN") / Item("TIPO_CAMBIO"), 5)
        '                'A SOLES
        '        End Select
        '        Item("TOTAL") = Math.Round(Item("QATNAN") * Item("ISRVGU"), 2)
        '    End If

        '    Select Case Item("CMNDA1")
        '        Case 1
        '            Item("IMPSOL") = Math.Round(Item("ISRVGU_ORIGEN"), 5)
        '        Case 100
        '            Item("IMPSOL") = Math.Round(Item("ISRVGU_ORIGEN") * Item("TIPO_CAMBIO"), 5)
        '    End Select

        'Next

        '    lobjParams.Add("PNNOPRCN", objParametro("PNNOPRCN"))
        '    lobjParams.Add("PSCMNDA1", objParametro("PSCMNDA"))
        '    lobjParams.Add("PNFECFAC", objParametro("PNFECFAC"))
        '    lobjParams.Add("PNFATNSR", objParametro("PNFATNSR"))
        '    objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
        '    dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_FACTURA_SERVICIOS_LOTE_GENERAL", lobjParams)

        '    Return dt
        'End Function

        'Public Function Lista_Documentos_Permitidos_Notas_General(ByVal objParametro As Hashtable) As DataTable
        '    Dim dt As DataTable
        '    Dim lobjParams As New Parameter

        '    lobjParams.Add("PSCCMPN", objParametro("PSCCMPN"))
        '    lobjParams.Add("PSCDVSN", objParametro("PSCDVSN"))
        '    lobjParams.Add("PNCCLNT", objParametro("PNCCLNT"))
        '    lobjParams.Add("PSCUSCRT", objParametro("PSCUSCRT"))
        '    lobjParams.Add("PNCTPODC", objParametro("PNCTPODC"))

        '    objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
        '    dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_REFACTURA_DOCUMENTOS_PERMITIDOS_GENERAL", lobjParams)

        '    Return dt
        'End Function

        Public Function Validar_Cliente_Electronico(ByVal pobjFiltro As Hashtable) As String

            Dim lobjParams As New Parameter
            Dim strResultado As String = ""
            Try
                lobjParams.Add("CCMPN", pobjFiltro("CCMPN"))
                lobjParams.Add("CZNFC", pobjFiltro("CZNFC"))
                lobjParams.Add("CCLNT", pobjFiltro("CCLNT"))
                lobjParams.Add("CRGVTA", pobjFiltro("CRGVTA"))

                lobjParams.Add("PARAM_MSGRET", "", ParameterDirection.Output)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("CCMPN"))
                objSql.ExecuteNonQuery("SP_SOLMIN_AS400_CL_SAP110", lobjParams)
                strResultado = objSql.ParameterCollection("PARAM_MSGRET").ToString.Trim
            Catch ex As Exception
                strResultado = ""
            End Try
            Return strResultado

        End Function

        REM ECM-HUNDRED-INICIO
        Public Function Validar_Cliente_Electronico_AS(ByVal Filtro As Hashtable) As String
            Dim dt As DataTable
            Dim parametro As New Parameter
            Dim resultado As String = "2"
            'Try
            parametro.Add("PNCCLNT", Filtro("PNCCLNT"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(Filtro("CCMPN"))
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_VALIDAR_CLIENTE_ELECTRONICO_AS", parametro)
            If dt.Rows.Count > 0 Then
                Dim evaluador As String = dt.Rows(0)("FLSTSE").ToString().Trim()
                If evaluador = "1" Then
                    resultado = "1"
                Else
                    resultado = "0"
                End If
            End If

            'Catch ex As Exception
            'End Try
            Return resultado
        End Function
        REM ECM-HUNDRED-FIN

        Public Function Lista_Documentos_Permitidos_Electronico(ByVal objParametro As Hashtable) As DataTable
            Dim dt As DataTable
            Dim lobjParams As New Parameter
            'Try
            lobjParams.Add("PSCCMPN", objParametro("PSCCMPN"))
            lobjParams.Add("PSCDVSN", objParametro("PSCDVSN"))
            lobjParams.Add("PNCCLNT", objParametro("PNCCLNT"))
            lobjParams.Add("PSCUSCRT", objParametro("PSCUSCRT"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_FACTURA_DOCUMENTOS_PERMITIDOS_ELECTRONICO", lobjParams)
            'Catch ex As Exception
            '    dt = Nothing
            'End Try
            Return dt
        End Function

        Public Sub Enviar_Documento_SAP_FE(ByVal pobjFiltro As Hashtable)
            Try
                Dim lobjParams As New Parameter

                lobjParams.Add("PSCCMPN", pobjFiltro("PSCCMPN"))
                lobjParams.Add("PSCTPODC", pobjFiltro("PSCTPODC"))
                lobjParams.Add("PSNDCCTC", pobjFiltro("PSNDCCTC"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
                objSql.ExecuteNonQuery("SP_SOLCT_FACTURA_ENVIAR_DOCUMENTO_SAP_FE", lobjParams)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Function Grabar_Cabecera_Factura_FE(ByVal pobjArr As Object) As Boolean
            Dim lobjParams As New Parameter
            'Try

            lobjParams.Add("PSCCMPN", pobjArr(0).ToString.Trim)
            lobjParams.Add("PSCDVSN", pobjArr(1).ToString.Trim)
            lobjParams.Add("PNCTPODC", CInt(pobjArr(2)))
            lobjParams.Add("PNNDCCTC", CInt(pobjArr(3)))
            lobjParams.Add("PNNINDRN", CInt(pobjArr(4)))
            'lobjParams.Add("PNCDMODN", pobjArr(5).ToString.Trim)
            lobjParams.Add("PNFDCCTC", CInt(pobjArr(5)))
            lobjParams.Add("PSCRGVTA", pobjArr(6).ToString.Trim)
            lobjParams.Add("PSCTPCTR", pobjArr(7).ToString.Trim)
            lobjParams.Add("PNCCLNT", CInt(pobjArr(8)))
            lobjParams.Add("PSCGRONG", pobjArr(9).ToString.Trim)
            lobjParams.Add("PNCTPDCO", CInt(pobjArr(10)))
            lobjParams.Add("PNNDCMOR", CDec(pobjArr(11)))
            lobjParams.Add("PNFDCMOR", CInt(pobjArr(12)))
            lobjParams.Add("PNCZNFCC", CInt(pobjArr(13)))
            lobjParams.Add("PNIVLDCS", CDec(pobjArr(14)))
            lobjParams.Add("PNPIGVA", CDec(pobjArr(15)))
            lobjParams.Add("PNIVLIGS", CDec(pobjArr(16)))
            lobjParams.Add("PNITTFCS", CDec(pobjArr(17)))
            lobjParams.Add("PNCMNDA", CInt(pobjArr(18)))
            lobjParams.Add("PSVALORD", CDec(pobjArr(19)))
            lobjParams.Add("PNNDSPGD", CInt(pobjArr(20)))
            lobjParams.Add("PNNFORFA", CInt(pobjArr(21)))

            lobjParams.Add("PNCDMODN", CInt(pobjArr(22)))

            lobjParams.Add("PNCTPDCOOP", CInt(pobjArr(23)))
            lobjParams.Add("PNNDCMOROP", CDec(pobjArr(24)))
            lobjParams.Add("PNFDCMOROP", CInt(pobjArr(25)))


            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)

            'dagnino 12/08/2015
            lobjParams.Add("PNCCLNTOP", CInt(pobjArr(26)))
            lobjParams.Add("PSOCCLNT", pobjArr(27).ToString.Trim)

            lobjParams.Add("ES_PREDOCUMENTO", pobjArr(28).ToString.Trim)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjArr(0).ToString.Trim)
            'objSql.ExecuteNonQuery("SP_SOLMIN_ST_FACTURA_GRABAR_CABECERA_FE", lobjParams)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_FACTURA_GRABAR_CABECERA_FEV2", lobjParams)

            Return True
            'Return True
            'Catch ex As Exception
            '    Return False
            'End Try

        End Function

        Public Function Grabar_Detalle_Factura_FE(ByVal pobjArr As Object) As Boolean
            'Try
            Dim lobjParams As New Parameter

            lobjParams.Add("PSCCMPN", pobjArr(0).ToString.Trim)
            lobjParams.Add("PNCTPODC", CInt(pobjArr(1)))
            lobjParams.Add("PNNDCCTC", CInt(pobjArr(2)))
            lobjParams.Add("PNNINDRN", CInt(pobjArr(3)))
            lobjParams.Add("PNNCRDCC", CInt(pobjArr(4)))
            lobjParams.Add("PNCSRVNV", CInt(pobjArr(5)))
            lobjParams.Add("PNQAPCTC", CDec(pobjArr(6)))
            lobjParams.Add("PSCUNCNA", pobjArr(7).ToString.Trim)
            lobjParams.Add("PNITRCTC", CDec(pobjArr(8)))
            lobjParams.Add("PNIVLDCS", CDec(pobjArr(9)))
            lobjParams.Add("PSTOBCTC", pobjArr(10).ToString.Trim)
            lobjParams.Add("PSNOMSER", pobjArr(11).ToString.Trim)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjArr(0).ToString.Trim)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_FACTURA_GRABAR_DETALLE_FE", lobjParams)
            Return True
            'Catch ex As Exception
            '    Return False
            '    Throw New Exception(ex.Message)
            'End Try
        End Function

        Public Function Obtener_Codigo_Deudor_SAP(ByVal objParameter As Hashtable) As String
            Dim lobjParams As New Parameter
            Dim strResultado As String = ""
            Try
                lobjParams.Add("PNCCLNT", objParameter("CCLNT"))
                lobjParams.Add("PARAM_RESULT", "", ParameterDirection.Output)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParameter("CCMPN"))
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_OBTENER_CODIGO_DEUDOR_SAP", lobjParams)
                strResultado = objSql.ParameterCollection("PARAM_RESULT").ToString.Trim
            Catch ex As Exception
                strResultado = "" ' ex.Message.ToString.Trim
            End Try
            Return strResultado
        End Function

        Public Function Obtener_Descripcion_Giro_Negocio(ByVal objParameter As Hashtable) As String
            Dim lobjParams As New Parameter
            Dim strResultado As String = ""
            Try
                lobjParams.Add("PSCCMPN", objParameter("CCMPN"))
                lobjParams.Add("PSCDVSN", objParameter("CDVSN"))
                lobjParams.Add("PSCGRONG", objParameter("CGRONG"))
                lobjParams.Add("PARAM_RESULT", "", ParameterDirection.Output)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParameter("CCMPN"))
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_OBTENER_DESCRIPCION_GIRO_NEGOCIO", lobjParams)
                strResultado = objSql.ParameterCollection("PARAM_RESULT").ToString.Trim
            Catch ex As Exception
                strResultado = "" ' ex.Message.ToString.Trim
            End Try
            Return strResultado
        End Function

        'Public Sub Actualizar_Detalle_Facturado_Lote_General(ByVal pobjFiltro As Hashtable)
        '    Try

        '        Dim lobjParams As New Parameter

        '        lobjParams.Add("PNNOPRCN", pobjFiltro("PNNOPRCN"))
        '        lobjParams.Add("PNNGUIRM", pobjFiltro("PNNGUIRM"))
        '        lobjParams.Add("PNCRBCTC", pobjFiltro("PNCRBCTC"))
        '        lobjParams.Add("PNQCNDTG", pobjFiltro("PNQCNDTG")) 'CANTIDAD
        '        lobjParams.Add("PSCUNDSR", pobjFiltro("PSCUNDSR")) 'CODIGO UNIDAD SERVICIO
        '        lobjParams.Add("PNISRVGU", pobjFiltro("PNISRVGU")) 'IMPORTE
        '        lobjParams.Add("PNCMNDGU", pobjFiltro("PNCMNDGU"))

        '        lobjParams.Add("PNISRVGF", pobjFiltro("PNISRVGF"))
        '        lobjParams.Add("PNCMNDGF", pobjFiltro("PNCMNDGF"))

        '        lobjParams.Add("PNCTPODC", pobjFiltro("PNCTPODC"))
        '        lobjParams.Add("PNNDCMFC", pobjFiltro("PNNDCMFC"))
        '        lobjParams.Add("PNFECFAC", pobjFiltro("PNFECFAC"))
        '        lobjParams.Add("PNFLGFAC", pobjFiltro("PNFLGFAC"))

        '        lobjParams.Add("PNPSOVOL", pobjFiltro("PNPESOVOL"))
        '        lobjParams.Add("PNPESO", pobjFiltro("PNPESO"))


        '        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        '        lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd"))
        '        lobjParams.Add("PNHULTAC", Format(Now, "HHmmss"))
        '        lobjParams.Add("PSNTRMNL", HelpClass.NombreMaquina)
        '        lobjParams.Add("PNNCRRGU", pobjFiltro("PNNCRRGU"))

        '        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
        '        objSql.ExecuteNonQuery("SP_SOLMIN_ST_FACTURA_ACTUALIZAR_DETALLE_FACTURADO_LOTE_GENERAL", lobjParams)
        '    Catch ex As Exception
        '        Throw New Exception(ex.Message)
        '    End Try
        'End Sub

        Public Function Llenar_Documentos_Notas_FE(ByVal objParametro As Hashtable) As DataTable
            Dim dt As DataTable
            Dim lobjParams As New Parameter

            lobjParams.Add("PSCCMPN", objParametro("PSCCMPN"))
            lobjParams.Add("PSCDVSN", objParametro("PSCDVSN"))
            ' lobjParams.Add("PNCCLNT", objParametro("PNCCLNT"))
            lobjParams.Add("PSCUSCRT", objParametro("PSCUSCRT"))
            lobjParams.Add("PNCTPODC", objParametro("PNCTPODC"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_REFACTURA_DOCUMENTOS_PERMITIDOS_FE", lobjParams)

            Return dt
        End Function

        Public Sub Actualizar_Detalle_ReFacturado_General(ByVal pobjFiltro As Hashtable)
            'Try

            Dim lobjParams As New Parameter

            lobjParams.Add("PNNOPRCN", pobjFiltro("PNNOPRCN"))
            lobjParams.Add("PNNGUIRM", pobjFiltro("PNNGUIRM"))
            lobjParams.Add("PNCRBCTC", pobjFiltro("PNCRBCTC"))
            lobjParams.Add("PNQCNDTG", pobjFiltro("PNQCNDTG")) 'CANTIDAD
            lobjParams.Add("PSCUNDSR", pobjFiltro("PSCUNDSR")) 'CODIGO UNIDAD SERVICIO
            lobjParams.Add("PNISRVGU", pobjFiltro("PNISRVGU")) 'IMPORTE
            lobjParams.Add("PNIVLRLV", pobjFiltro("PNIVLRLV")) 'IMPORTE VALOR REAL
            lobjParams.Add("PNCMNDGU", pobjFiltro("PNCMNDGU"))
            lobjParams.Add("PNCTPODC", pobjFiltro("PNCTPODC"))
            lobjParams.Add("PNNDCMFC", pobjFiltro("PNNDCMFC"))
            lobjParams.Add("PNFECFAC", pobjFiltro("PNFECFAC"))
            lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
            lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd"))
            lobjParams.Add("PNHULTAC", Format(Now, "HHmmss"))
            lobjParams.Add("PSNTRMNL", HelpClass.NombreMaquina)
            lobjParams.Add("PSLIBERAR", pobjFiltro("PSLIBERAR"))
            lobjParams.Add("PNCTPDCO", pobjFiltro("PNCTPDCO"))
            lobjParams.Add("PNNDCMOR", pobjFiltro("PNNDCMOR"))

            lobjParams.Add("PNISRVGF", pobjFiltro("PNISRVGF"))
            lobjParams.Add("PNCMNDGF", pobjFiltro("PNCMNDGF"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_REFACTURA_ACTUALIZAR_DETALLE_REFACTURADO_GENERAL", lobjParams)
            'Catch ex As Exception
            '    Throw New Exception(ex.Message)
            'End Try
        End Sub


        Public Sub Actualizar_Estado_Sunat(ByVal pobjFiltro As Hashtable)
            Try

                Dim lobjParams As New Parameter
                Dim objSql As New SqlManager

                lobjParams.Add("PSCCMPN", pobjFiltro("PSCCMPN"))
                lobjParams.Add("PSCTPODC", pobjFiltro("PSCTPODC"))
                lobjParams.Add("PSNDCCTC", pobjFiltro("PSNDCCTC"))
                lobjParams.Add("PSCSCDSP", pobjFiltro("PSCSCDSP"))
                lobjParams.Add("PSNDCCTE", pobjFiltro("PSNDCCTE"))


                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
                objSql.ExecuteNonQuery("SP_SOLCT_FACTURA_REENVIAR_DOCUMENTO_SAP_FE", lobjParams)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

#End Region

        Public Function Lista_Datos_Documento_Emitido(ByVal PSCCMPN As String, ByVal PNCTPODC As Decimal, ByVal PNNDCCTC As Decimal) As DataSet
            Dim dt As DataSet
            Dim lobjParams As New Parameter

            lobjParams.Add("PSCCMPN", PSCCMPN)
            lobjParams.Add("PNCTPODC", PNCTPODC)
            lobjParams.Add("PNNDCCTC", PNNDCCTC)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(PSCCMPN)
            dt = objSql.ExecuteDataSet("SP_SOLMIN_ST_FACTURA_LISTA_DATOS_DOCUMENTO_EMITIDO", lobjParams)

            Return dt
        End Function

        Public Function ValidarClienteInterno(ByVal compania As String, ByVal clienteFAC As Decimal) As DataTable
            Dim dt As DataTable
            Dim lobjParams As New Parameter

            lobjParams.Add("PSCCMPN", compania)
            lobjParams.Add("PNCCLNT", clienteFAC)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(compania)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_VALIDAR_CLIENTE_INTERNO", lobjParams)

            Return dt
        End Function

        Public Function RegistrarVentaInternaSAP(ByVal PSCCMPN As String, ByVal PNCTPODC As Decimal, ByVal PNNDCCTC As Decimal, ByVal PSAPROBADOR As String) As String ' (ByVal PSCCMPN As String, ByVal PNCTPODC As Decimal, ByVal PNNDCCTC As Decimal) As Int32 ' 
            Dim message As String = ""
            Try
                Dim lobjParams As New Parameter

                lobjParams.Add("PSCCMPN", PSCCMPN)
                lobjParams.Add("PNCTPODC", PNCTPODC)
                lobjParams.Add("PNNDCCTC", PNNDCCTC)
                'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
                lobjParams.Add("PSAPROBADOR", PSAPROBADOR)
                lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
                'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(PSCCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_VENTA_INTERNA_SAP", lobjParams)


            Catch ex As Exception
                message = ex.Message
            End Try
            Return message
        End Function

        Public Function DatosOperacionPlanta(ByVal compania As String, ByVal NOPRCN As Decimal, ByVal NPRLQD As Decimal) As DataTable
            Dim dt As DataTable
            Dim lobjParams As New Parameter

            lobjParams.Add("PNNOPRCN", NOPRCN)
            lobjParams.Add("PNNPRLQD", NPRLQD)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(compania)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_DATOS_OPERACION_PRELIQUIDACION_PLANTA_FACTURA", lobjParams)

            Return dt
        End Function

        Public Function ListarTipoDocumento(ByVal compania As String) As DataTable 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
            Dim output As New DataTable
            'Try
            Dim parameter As New Parameter
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(compania)
            output = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_DOCUMENTOS_DOC_LIBRE", parameter)
            'Catch ex As Exception
            '    output = Nothing
            'End Try

            Return output
        End Function


        Public Function ValidarOperacionesParteTransferencia(ByVal compania As String, ByVal ConsistenciaOperacion As String) As DataTable
            Dim output As New DataTable
            'Try
            Dim parameter As New Parameter
            parameter.Add("PSNOPRCN", ConsistenciaOperacion)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(compania)
            output = objSql.ExecuteDataTable("SP_SOLMIN_ST_VALIDAR_OPERACIONES_PARTE_TRANSFERENCIA", parameter)
            'Catch ex As Exception
            '    output = Nothing
            'End Try

            Return output
        End Function


        'CSR-HUNDRED-ESTIMACION-INGRESO-INICIO
        Public Function Estimacion_Ingreso_Revertir(ByVal oFiltro As Hashtable) As DataTable
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PSCCMPN", oFiltro("PSCCMPN"))
            lobjParams.Add("PNCTPODC", oFiltro("PNCTPODC"))
            lobjParams.Add("PNNDCFCC", oFiltro("PNNDCFCC"))
            lobjParams.Add("PNNSECFC", oFiltro("PNNSECFC"))
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_LISTA_ESTIMACION_INGRESO_REVERTIR", lobjParams)
            Return dt
        End Function
        'CSR-HUNDRED-ESTIMACION-INGRESO-FIN


        Public Function ValidarValorizacion_PF_PL(ByVal compania As String, Tipo As String, ByVal ListadoPF_PL As String) As String
            Dim output As New DataTable
            'Try
            Dim msgresul As String = ""
            Dim parameter As New Parameter
            parameter.Add("PSPFPL", ListadoPF_PL)
            parameter.Add("PSTIPO", Tipo)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(compania)
            output = objSql.ExecuteDataTable("SP_SOLMIN_ST_VALIDAR_LISTADO_PF_PL_VALORIZACION", parameter)
            'Catch ex As Exception
            '    output = Nothing
            'End Try
            For Each item As DataRow In output.Rows
                If item("STATUS") = "E" Then
                    msgresul = msgresul & item("OBSRESULT") & Chr(13)
                End If
            Next
            msgresul = msgresul.Trim

            Return msgresul
        End Function

        'FIXSUMMIT-20200124
        Public Function Lista_Detalle_Servicios_General_PreDocumentos(ByVal objParametro As Hashtable) As DataTable
            Dim dt As DataTable
            Dim lobjParams As New Parameter
            Dim moneda As String = ("" & objParametro("PSCMNDA")).ToString.Trim
            lobjParams.Add("PNNROPL", objParametro("PNNROPL"))
            lobjParams.Add("PSPREDOC", objParametro("PSPREDOC"))
            'lobjParams.Add("PNNOPRCN", objParametro("PNNOPRCN"))
            lobjParams.Add("PSCMNDA1", objParametro("PSCMNDA"))
            lobjParams.Add("PNFECFAC", objParametro("PNFECFAC"))
            lobjParams.Add("PNFATNSR", objParametro("PNFATNSR"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_FACTURA_DETALLE_SERVICIOS_PREDOC_GENERAL", lobjParams) 'NAME OF STORE
            dt.Columns.Add("ISRVGU", Type.GetType("System.Decimal"))
            dt.Columns.Add("TOTAL", Type.GetType("System.Decimal"))
            dt.Columns.Add("IMPSOL", Type.GetType("System.Decimal"))



            For Each Item As DataRow In dt.Rows
                If moneda = "SOL" Then
                    Select Case Item("CMNDA1")
                        Case 1 'SOL -> SOL
                            Item("ISRVGU") = Math.Round(Item("TARIFA"), 5)
                        Case 100 'DOL -> SOL
                            Item("ISRVGU") = Math.Round(Item("TARIFA") * Item("TIPO_CAMBIO"), 5)
                    End Select
                    Item("TOTAL") = Math.Round(Item("QATNAN") * Item("ISRVGU"), 5, MidpointRounding.AwayFromZero)

                ElseIf moneda = "DOL" Then
                    Select Case Item("CMNDA1")
                        Case 100 'DOL -> DOL
                            Item("ISRVGU") = Math.Round(Item("TARIFA"), 5)
                        Case 1 'SOL  --> DOL
                            Item("ISRVGU") = Math.Round(Item("TARIFA") / Item("TIPO_CAMBIO"), 5)
                    End Select
                    Item("TOTAL") = Math.Round(Item("QATNAN") * Item("ISRVGU"), 5, MidpointRounding.AwayFromZero)
                End If

                Select Case Item("CMNDA1")
                    Case 1
                        Item("IMPSOL") = Math.Round(Item("TARIFA"), 5)
                    Case 100
                        Item("IMPSOL") = Math.Round(Item("TARIFA") * Item("TIPO_CAMBIO"), 5)
                End Select

            Next
            Return dt
        End Function

        Public Function Lista_OrgVenta_Cliente(pCCMPN As String, pCCLNFC As Decimal) As DataTable
            Dim dt As DataTable
            Dim lobjParams As New Parameter

            lobjParams.Add("PSCCMPN", pCCMPN)
            lobjParams.Add("PNCCLNT", pCCLNFC)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pCCMPN)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_ORG_VENTA_CLIENTE", lobjParams)

            Return dt
        End Function

    End Class

End Namespace





