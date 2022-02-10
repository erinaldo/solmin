
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.Utilitario

Namespace Operaciones

    Public Class Factura_Transporte_DAL
        Private objSql As New SqlManager

        Public Function Listar_Operacion_x_Orden_Servicio(ByVal objParametro As Hashtable) As List(Of OperacionTransporte)
            Dim objEntidad As OperacionTransporte
            Dim objGenericCollection As New List(Of OperacionTransporte)
            Dim objParam As New Parameter
            Try
                'objParam.Add("PNNCTZCN", objParametro("PNNCTZCN"))
                objParam.Add("PNNMOPMM", objParametro("PNNMOPMM"))
                objParam.Add("PNNORSRT", objParametro("PNNORSRT"))
                objParam.Add("PSSESTOP", objParametro("PSSESTOP"))
                objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
                objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
                objParam.Add("PSCPLNDV", objParametro("PSCPLNDV"))
                objParam.Add("PNCCLNT", objParametro("PNCCLNT"))
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
                    objEntidad.CTPOSR = objDataRow("CTPOSR")
                    objEntidad.TCMTPS = objDataRow("TCMTPS").ToString.Trim
                    objEntidad.TCMSBS = objDataRow("TCMSBS")
                    objEntidad.CMRCDR = objDataRow("CMRCDR").ToString.Trim
                    objEntidad.TCMRCD = objDataRow("TCMRCD")
                    objEntidad.SESTOP = objDataRow("SESTOP")
                    objEntidad.TDRCNS = objDataRow("TDRCOR").ToString.Trim
                    objEntidad.NRUCCN = objDataRow("NRUCTR")
                    objEntidad.SORGMV = objDataRow("SORGMV").ToString.Trim
                    objEntidad.TCNTCS = objDataRow("TCNTCS").ToString.Trim
                    objEntidad.TCRVTA = objDataRow("TCRVTA").ToString.Trim
                    objEntidad.CRGVTA = objDataRow("CRGVTA").ToString.Trim
                    objEntidad.CPLNDV = objDataRow("CPLNDV")
                    objGenericCollection.Add(objEntidad)
                Next
            Catch ex As Exception
                objGenericCollection = New List(Of OperacionTransporte)
            End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Guia_Remision_x_Operacion(ByVal objParametro As Hashtable) As List(Of Factura_Transporte)
            Dim objEntidad As New Factura_Transporte
            Dim objGenericCollection As New List(Of Factura_Transporte)
            Dim objParam As New Parameter
            Try
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
            Catch ex As Exception
                objGenericCollection = New List(Of Factura_Transporte)
            End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Orden_Servicio_Facturacion(ByVal objParametro As Hashtable) As List(Of OrdenServicioTransporte)
            Dim objEntidad As New OrdenServicioTransporte
            Dim objGenericCollection As New List(Of OrdenServicioTransporte)
            Dim objParam As New Parameter
            Try
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
            Catch ex As Exception
                objGenericCollection = New List(Of OrdenServicioTransporte)
            End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Consistencia_Factura_x_Orden_Servicio(ByVal objParametro As Hashtable) As List(Of Factura_Transporte)
            Dim objEntidad As Factura_Transporte
            Dim objGenericCollection As New List(Of Factura_Transporte)
            Dim objParam As New Parameter
            Dim objDataTable As New DataTable
            Try
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
            Catch ex As Exception
                objGenericCollection = New List(Of Factura_Transporte)()
            End Try
            Return objGenericCollection
        End Function


        Public Function Listar_Sustento_Factura_Lote(ByVal objParametro As Hashtable, ByVal drSelect As DataRow()) As List(Of Factura_Transporte)
            Dim objEntidad As Factura_Transporte
            Dim objGenericCollection As New List(Of Factura_Transporte)
            Dim objParam As New Parameter
            Dim objDataTable As New DataTable
            Try

                'Crea los Parametros para la Temporal
                Dim sbNOPRCN As New System.Text.StringBuilder()
                Dim sbNGUIRM As New System.Text.StringBuilder()
                Dim sbCSRVC As New System.Text.StringBuilder()
                Dim sbISRVGU As New System.Text.StringBuilder()
                Dim sbPESO As New System.Text.StringBuilder()
                Dim sbPSOVOL As New System.Text.StringBuilder()

                For row As Integer = 0 To drSelect.Length - 1
                    sbNOPRCN.Append(drSelect(row).Item("NOPRCN"))
                    sbNGUIRM.Append(drSelect(row).Item("NGUIRM"))
                    sbCSRVC.Append(drSelect(row).Item("CRBCTC"))

                    'If objParametro("MonedaFactura") = "DOL" Then
                    '    If drSelect(row).Item("CMNDGU") = 100 Then
                    '        sbISRVGU.Append(drSelect(row).Item("ISRVGU"))
                    '    Else
                    '        sbISRVGU.Append(CType(drSelect(row).Item("ISRVGU") * objParametro("TipoCambio"), Decimal))
                    '    End If
                    'Else
                    If drSelect(row).Item("CMNDGU") = 1 Then
                        sbISRVGU.Append(drSelect(row).Item("ISRVGU"))
                    Else
                        sbISRVGU.Append(CType(drSelect(row).Item("ISRVGU") / objParametro("TipoCambio"), Decimal))
                    End If
                    'End If

                    sbPESO.Append(drSelect(row).Item("PESO"))
                    sbPSOVOL.Append(drSelect(row).Item("PSOVOL"))

                    If row < drSelect.Length - 1 Then
                        sbNOPRCN.Append(",")
                        sbNGUIRM.Append(",")
                        sbCSRVC.Append(",")
                        sbISRVGU.Append(",")
                        sbPESO.Append(",")
                        sbPSOVOL.Append(",")
                    End If
                Next

                objParam.Add("PNCTPODC", objParametro("PNCTPODC"))
                objParam.Add("PNNDCMFC", objParametro("PNNDCMFC"))
                objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
                objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
                objParam.Add("PSNOPRCN", sbNOPRCN.ToString())
                objParam.Add("PSNGUIRM", sbNGUIRM.ToString())
                objParam.Add("PSCSRVC", sbCSRVC.ToString())
                objParam.Add("PSISRVGU", sbISRVGU.ToString())
                objParam.Add("PSPESO", sbPESO.ToString())
                objParam.Add("PSOVOL", sbPSOVOL.ToString())

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_SUSTENTO_FACTURA_LOTE", objParam)
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
            Catch ex As Exception
                objGenericCollection = New List(Of Factura_Transporte)()
            End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Sustento_Factura(ByVal objParametro As Hashtable) As List(Of Factura_Transporte)
            Dim objEntidad As Factura_Transporte
            Dim objGenericCollection As New List(Of Factura_Transporte)
            Dim objParam As New Parameter
            Dim objDataTable As New DataTable
            Try
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
            Catch ex As Exception
                objGenericCollection = New List(Of Factura_Transporte)()
            End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Planta_x_Cliente_Factura(ByVal objParametro As Hashtable) As List(Of Factura_Transporte)
            Dim objEntidad As Factura_Transporte
            Dim objGenericCollection As New List(Of Factura_Transporte)
            Dim objParam As New Parameter
            Dim objDataTable As New DataTable
            Try
                objParam.Add("PNCCLNT", objParametro("PNCCLNT"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))

                For Each objDataRow As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_PLANTA_X_CLIENTE_FACTURAR", objParam).Rows
                    objEntidad = New Factura_Transporte
                    objEntidad.CPLNCL = objDataRow("CPLNCL")
                    objEntidad.TDRCPL = objDataRow("TDRCPL").ToString.Trim
                    objGenericCollection.Add(objEntidad)
                Next
            Catch ex As Exception
                objGenericCollection = New List(Of Factura_Transporte)()
            End Try
            Return objGenericCollection
        End Function


        Public Function Actualizar_Cliente_Facturar(ByVal objParametro As Hashtable) As Int64
            Dim objParam As New Parameter
            Dim lint_NumDoc As Int64 = 0
            Try
                objParam.Add("PNNOPRCN", objParametro("PNNOPRCN"))
                objParam.Add("PNCCLNFC", objParametro("PNCCLNFC"))
                objParam.Add("PNCPLNCL", objParametro("PNCPLNCL"))
                objParam.Add("PNFULTAC", objParametro("PNFULTAC"))
                objParam.Add("PNHULTAC", objParametro("PNHULTAC"))
                objParam.Add("PSCULUSA", objParametro("PSCULUSA"))
                objParam.Add("PSNTRMNL", objParametro("PSNTRMNL"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_CLIENTE_FACTURAR", objParam)
                lint_NumDoc = 1
            Catch ex As Exception
                lint_NumDoc = 0
            End Try
            Return lint_NumDoc
        End Function

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
            Try
                objParam.Add("PNNORSRT", objParametro("PNNORSRT"))
                objParam.Add("PON_TCMPCL", "", ParameterDirection.Output)

                objSql.ExecuteNonQuery("SP_SOLMIN_ST_OBTENER_CLIENTE_X_ORDEN_SERVICIO", objParam)
                lstr_Cliente = objSql.ParameterCollection("PON_TCMPCL").ToString
            Catch ex As Exception
                lstr_Cliente = ""
            End Try
            Return lstr_Cliente
        End Function

        Public Function Pre_Facturar_Operacion(ByVal objParametro As Hashtable) As Int32
            Dim objParam As New Parameter
            Dim lint_Estado As Int32 = 0
            Try
                objParam.Add("PNNOPRCN", objParametro("PNNOPRCN"))
                objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
                objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
                objParam.Add("PNCPLNDV", objParametro("PNCPLNDV"))
                objParam.Add("PNFULTAC", objParametro("PNFULTAC"))
                objParam.Add("PNHULTAC", objParametro("PNHULTAC"))
                objParam.Add("PSCULUSA", objParametro("PSCULUSA"))
                objParam.Add("PSNTRMNL", objParametro("PSNTRMNL"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))

                objSql.ExecuteDataTable("SP_SOLMIN_ST_PRE_FACTURAR_OPERACION", objParam)
                lint_Estado = 1
            Catch ex As Exception
                lint_Estado = 0
            End Try
            Return lint_Estado
        End Function

        Public Function Lista_Tipo_Cambio(ByVal objParametro As Hashtable) As DataTable
            Dim dt As DataTable
            Dim lobjParams As New Parameter
            Try
                lobjParams.Add("PNCMNDA1", objParametro("PNCMNDA1"))
                lobjParams.Add("PNFCMBO", objParametro("PNFCMBO"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_TIPO_CAMBIO", lobjParams)
            Catch ex As Exception
                dt = Nothing
            End Try
            Return dt
        End Function

        Public Function Lista_Giro_Negocio(ByVal objParametro As Hashtable) As DataTable
            Dim dt As DataTable

            Dim lobjParams As New Parameter
            Try
                lobjParams.Add("PSCCMPN", objParametro("PSCCMPN"))
                lobjParams.Add("PSCDVSN", objParametro("PSCDVSN"))
                lobjParams.Add("PSCUSCRT", objParametro("PSCUSCRT"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_FACTURA_GIRO_NEGOCIO", lobjParams)
            Catch ex As Exception
                dt = Nothing
            End Try

            Return dt
        End Function

        Public Function Lista_Documentos_Permitidos(ByVal objParametro As Hashtable) As DataTable
            Dim dt As DataTable
            Dim lobjParams As New Parameter
            Try
                lobjParams.Add("PSCCMPN", objParametro("PSCCMPN"))
                lobjParams.Add("PSCDVSN", objParametro("PSCDVSN"))
                lobjParams.Add("PNCCLNT", objParametro("PNCCLNT"))
                lobjParams.Add("PSCUSCRT", objParametro("PSCUSCRT"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_FACTURA_DOCUMENTOS_PERMITIDOS", lobjParams)
            Catch ex As Exception
                dt = Nothing
            End Try

            Return dt
        End Function
        Public Function Lista_Documentos_Permitidos_Notas(ByVal objParametro As Hashtable) As DataTable
            Dim dt As DataTable
            Dim lobjParams As New Parameter
            Try
                lobjParams.Add("PSCCMPN", objParametro("PSCCMPN"))
                lobjParams.Add("PSCDVSN", objParametro("PSCDVSN"))
                lobjParams.Add("PNCCLNT", objParametro("PNCCLNT"))
                lobjParams.Add("PSCUSCRT", objParametro("PSCUSCRT"))
                lobjParams.Add("PNCTPODC", objParametro("PNCTPODC"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_REFACTURA_DOCUMENTOS_PERMITIDOS", lobjParams)
            Catch ex As Exception
                dt = Nothing
            End Try

            Return dt
        End Function

        Public Function Lista_Planta_Cliente(ByVal objParametro As Hashtable) As DataTable
            Dim dt As DataTable
            Dim lobjParams As New Parameter
            Try
                lobjParams.Add("PNCCLNT", objParametro("PNCCLNFC"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_FACTURA_PLANTA_CLIENTE", lobjParams)
            Catch ex As Exception
                dt = Nothing
            End Try

            Return dt
        End Function

        Public Function Lista_Datos_Cliente(ByVal objParametro As Hashtable) As DataTable
            Dim dt As DataTable
            Dim lobjParams As New Parameter
            Try
                lobjParams.Add("PNCCLNT", objParametro("PNCCLNFC"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_FACTURA_DATOS_CLIENTE", lobjParams)
            Catch ex As Exception
                dt = Nothing
            End Try

            Return dt
        End Function

        Public Function Lista_Detalle_Servicios_Lote(ByVal objParametro As Hashtable) As DataSet
            Dim dt As DataSet
            Dim lobjParams As New Parameter
            Try
                lobjParams.Add("PNNOPRCN", objParametro("PNNOPRCN"))
                lobjParams.Add("PSCMNDA1", objParametro("PSCMNDA"))
                lobjParams.Add("PNFECFAC", objParametro("PNFECFAC"))
                lobjParams.Add("PNFATNSR", objParametro("PNFATNSR"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
                'dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_FACTURA_DETALLE_SERVICIOS_PRUEBA", lobjParams)
                dt = objSql.ExecuteDataSet("SP_SOLMIN_ST_FACTURA_DETALLE_SERVICIOS_LOTE", lobjParams)
            Catch ex As Exception
                dt = Nothing
            End Try
            Return dt
        End Function

        Public Function Lista_Detalle_Servicios(ByVal objParametro As Hashtable) As DataTable
            Dim dt As DataTable
            Dim lobjParams As New Parameter
            Try
                lobjParams.Add("PNNOPRCN", objParametro("PNNOPRCN"))
                lobjParams.Add("PSCMNDA1", objParametro("PSCMNDA"))
                lobjParams.Add("PNFECFAC", objParametro("PNFECFAC"))
                lobjParams.Add("PNFATNSR", objParametro("PNFATNSR"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
                'dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_FACTURA_DETALLE_SERVICIOS_PRUEBA", lobjParams)
                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_FACTURA_DETALLE_SERVICIOS", lobjParams)
            Catch ex As Exception
                dt = Nothing
            End Try

            Return dt
        End Function
        Public Function Lista_Detalle_Servicios_Notas(ByVal objParametro As Hashtable) As DataTable
            Dim dt As DataTable
            Dim lobjParams As New Parameter
            Try
                lobjParams.Add("PNNOPRCN", objParametro("PNNOPRCN"))
                lobjParams.Add("PNNDCMFC", objParametro("PNNDCMFC"))
                lobjParams.Add("PSCMNDA1", objParametro("PSCMNDA"))
                lobjParams.Add("PNFECFAC", objParametro("PNFECFAC"))
                lobjParams.Add("PNFATNSR", objParametro("PNFATNSR"))
                lobjParams.Add("PNCTPODC", objParametro("PNCTPODC"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
                'dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_FACTURA_DETALLE_SERVICIOS_PRUEBA", lobjParams)
                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_REFACTURA_DETALLE_SERVICIOS_NOTAS", lobjParams)
            Catch ex As Exception
                dt = Nothing
            End Try

            Return dt
        End Function

        Public Function Lista_Detalle_Servicios_ReFactura(ByVal objParametro As Hashtable) As DataTable
            Dim dt As DataTable
            Dim lobjParams As New Parameter
            Try
                lobjParams.Add("PNNOPRCN", objParametro("PNNOPRCN"))
                lobjParams.Add("PSCMNDA1", objParametro("PSCMNDA"))
                lobjParams.Add("PNFECFAC", objParametro("PNFECFAC"))
                lobjParams.Add("PNFATNSR", objParametro("PNFATNSR"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
                'dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_FACTURA_DETALLE_SERVICIOS_PRUEBA", lobjParams)
                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_REFACTURA_DETALLE_SERVICIOS", lobjParams)
            Catch ex As Exception
                dt = Nothing
            End Try

            Return dt
        End Function

        Public Function Lista_Datos_Planta_Cliente(ByVal objParametro As Hashtable) As DataTable
            Dim dt As DataTable
            Dim lobjParams As New Parameter
            Try
                lobjParams.Add("PNCCLNT", objParametro("PNCCLNFC"))
                lobjParams.Add("PNCPLNCL", objParametro("PNCPLNCL"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))

                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_FACTURA_DATOS_PLANTA_CLIENTE", lobjParams)
            Catch ex As Exception
                dt = Nothing
            End Try

            Return dt
        End Function

        Public Function Lista_Datos_Planta(ByVal objParametro As Hashtable) As DataTable
            Dim dt As DataTable
            Dim lobjParams As New Parameter
            Try
                lobjParams.Add("PSCCMPN", objParametro("PSCCMPN"))
                lobjParams.Add("PSCDVSN", objParametro("PSCDVSN"))
                lobjParams.Add("PNCPLNDV", objParametro("PNCPLDVN"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_FACTURA_DATOS_PLANTA", lobjParams)
            Catch ex As Exception
                dt = Nothing
            End Try

            Return dt
        End Function

        Public Function Lista_Datos_Servicio(ByVal pobjFiltro As Hashtable) As DataTable
            Dim dt As DataTable
            Dim lobjParams As New Parameter
            Try
                lobjParams.Add("PSCCMPN", pobjFiltro("PSCCMPN"))
                lobjParams.Add("PSCDVSN", pobjFiltro("PSCDVSN"))
                lobjParams.Add("PNCSRVNV", pobjFiltro("PNCSRVNV"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_FACTURA_DATOS_SERVICIO", lobjParams)
            Catch ex As Exception
                dt = Nothing
            End Try

            Return dt
        End Function

        Public Function Lista_Datos_Factura(ByVal pobjFiltro As Hashtable) As DataSet
            Dim ds As DataSet
            Dim lobjParams As New Parameter
            Try
                lobjParams.Add("PSCCMPN", pobjFiltro("PSCCMPN"))
                lobjParams.Add("PSCDVSN", pobjFiltro("PSCDVSN"))
                lobjParams.Add("PNCTPODC", pobjFiltro("PNCTPODC"))
                lobjParams.Add("PNNDCCTC", pobjFiltro("PNNDCCTC"))
                lobjParams.Add("PNESTADO", pobjFiltro("PNESTADO"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
                'ds = objSql.ExecuteDataSet("SP_SOLMIN_ST_FACTURA_LISTA_DATOS_FACTURA", lobjParams)
                ds = objSql.ExecuteDataSet("SP_SOLMIN_ST_FACTURA_LISTA_DATOS_FACTURA_V2", lobjParams)
            Catch ex As Exception
                ds = Nothing
            End Try

            Return ds
        End Function

        Public Function Grabar_Cabecera_ReFactura(ByVal pobjArr As Object) As DataTable
            Dim dt As DataTable
            Dim lobjParams As New Parameter
            Try
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
                lobjParams.Add("PSNTRMCR", My.Computer.Name.Trim)
                lobjParams.Add("PNNDSPGD", pobjArr(30))
                lobjParams.Add("PSCRGVTA", pobjArr(31))
                lobjParams.Add("PNFATNSR", pobjArr(32))
                lobjParams.Add("PNCTPDCO", pobjArr(33))
                lobjParams.Add("PNNDCMOR", pobjArr(34))
                lobjParams.Add("PNFDCMOR", pobjArr(35))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjArr(0).ToString.Trim)
                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_REFACTURA_GRABAR_CABECERA", lobjParams)
            Catch ex As Exception
                dt = Nothing
            End Try
            Return dt
        End Function
        Public Function Grabar_Cabecera_Factura(ByVal pobjArr As Object) As DataTable
            Dim dt As DataTable
            Dim lobjParams As New Parameter
            Try
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
                lobjParams.Add("PSNTRMCR", My.Computer.Name.Trim)
                lobjParams.Add("PNNDSPGD", pobjArr(33))
                lobjParams.Add("PSCRGVTA", pobjArr(34))
                lobjParams.Add("PNFATNSR", pobjArr(35))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjArr(0).ToString.Trim)
                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_FACTURA_GRABAR_CABECERA", lobjParams)
            Catch ex As Exception
                dt = Nothing
            End Try
            Return dt
        End Function
        Public Sub Grabar_Detalle_ReFactura(ByVal pobjArr As Object)
            Try

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
                lobjParams.Add("PSNTRMCR", My.Computer.Name.Trim)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjArr(0).ToString.Trim)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_REFACTURA_GRABAR_DETALLE", lobjParams)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub
        Public Sub Grabar_Detalle_Factura(ByVal pobjArr As Object)
            Try

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
                lobjParams.Add("PSNTRMCR", My.Computer.Name.Trim)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjArr(0).ToString.Trim)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_FACTURA_GRABAR_DETALLE", lobjParams)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub Grabar_Referencia_Factura(ByVal pobjArr As Object)
            Try

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
                lobjParams.Add("PSNTRMCR", My.Computer.Name.Trim)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjArr(0).ToString.Trim)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_FACTURA_GRABAR_REFERENCIA", lobjParams)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub
        Public Sub Actualizar_Detalle_ReFacturado(ByVal pobjFiltro As Hashtable)
            Try

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
                lobjParams.Add("PSNTRMNL", My.Computer.Name.Trim)
                lobjParams.Add("PSLIBERAR", pobjFiltro("PSLIBERAR"))
                lobjParams.Add("PNCTPDCO", pobjFiltro("PNCTPDCO"))
                lobjParams.Add("PNNDCMOR", pobjFiltro("PNNDCMOR"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_REFACTURA_ACTUALIZAR_DETALLE_REFACTURADO", lobjParams)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub
        Public Sub Actualizar_Detalle_Facturado(ByVal pobjFiltro As Hashtable)
            Try

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
                lobjParams.Add("PSNTRMNL", My.Computer.Name.Trim)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_FACTURA_ACTUALIZAR_DETALLE_FACTURADO", lobjParams)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub Actualizar_Detalle_Facturado_Lote(ByVal pobjFiltro As Hashtable)
            Try

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

                lobjParams.Add("PNPSOVOL", pobjFiltro("PNPESOVOL"))
                lobjParams.Add("PNPESO", pobjFiltro("PNPESO"))

                lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
                lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd"))
                lobjParams.Add("PNHULTAC", Format(Now, "HHmmss"))
                lobjParams.Add("PSNTRMNL", My.Computer.Name.Trim)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_FACTURA_ACTUALIZAR_DETALLE_FACTURADO_LOTE", lobjParams)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub


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

        Public Function Registrar_Orden_Interna_Factura_Lote(ByVal pobjFiltro As Hashtable) As Int32
            Dim lintEstado As Int32 = 0
            Dim lobjParams As New Parameter
            Try
                lobjParams.Add("PSCCMPN", pobjFiltro("PSCCMPN"))
                lobjParams.Add("PNCTPODC", pobjFiltro("PSCTPODC"))
                lobjParams.Add("PNNDCCTC", pobjFiltro("PSNDCCTC"))

                lobjParams.Add("PSNOPRCN", pobjFiltro("PSNOPRCN"))
                lobjParams.Add("PSNGUIRM", pobjFiltro("PSNGUIRM"))
                lobjParams.Add("PSCSRVC", pobjFiltro("PSCSRVC"))
                lobjParams.Add("PSISRVGU", pobjFiltro("PSISRVGU"))

                lobjParams.Add("PNFECFAC", pobjFiltro("PNFECFAC"))
                lobjParams.Add("PNMONEDA", pobjFiltro("PNMONEDA"))
                lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
                lobjParams.Add("PNFCHCRT", Format(Now, "yyyyMMdd"))
                lobjParams.Add("PNHRACRT", Format(Now, "HHmmss"))
                lobjParams.Add("PSNTRMCR", My.Computer.Name.Trim)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_ORDEN_INTERNA_FACTURA_LOTE", lobjParams)
                lintEstado = 1
            Catch ex As Exception
                lintEstado = 0
            End Try

            Return lintEstado
        End Function

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
                lobjParams.Add("PSNTRMCR", My.Computer.Name.Trim)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_ORDEN_INTERNA_FACTURA", lobjParams)
                lintEstado = 1
            Catch ex As Exception
                lintEstado = 0
            End Try

            Return lintEstado
        End Function

        Public Function Cerrar_Orden_Interna_Factura(ByVal pobjFiltro As Hashtable) As Int32
            Dim lintEstado As Int32 = 0
            Dim lobjParams As New Parameter
            Try
                lobjParams.Add("PNCTPODC", pobjFiltro("PSCTPODC"))
                lobjParams.Add("PNNDCCTC", pobjFiltro("PSNDCCTC"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_CERRAR_ORDEN_INTERNA_SAP", lobjParams)
                lintEstado = 1
            Catch ex As Exception
                lintEstado = 0
            End Try

            Return lintEstado
        End Function

        Public Function Obtener_Fecha_Servidor() As Date
            Dim lobjParams As New Parameter
            Dim strFecha As Date
            Try
                lobjParams.Add("DTFECHA", "", ParameterDirection.Output)
                objSql.ExecuteNonQuery("SP_SOLMIN_OBTENER_FECHA_SERVIDOR", lobjParams)
                strFecha = objSql.ParameterCollection("DTFECHA")
            Catch : End Try
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
            Dim lobjParams As New Parameter
            Try
                lobjParams.Add("PSNOPRCN", pstrOperacion)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCodCom)
                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_FACTURA_OBTENER_REFERENCIA_RUTA", lobjParams)
            Catch ex As Exception
                dt = Nothing
            End Try
            Return dt.Rows(0).Item("RUTA").ToString
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
            Try
                lobjParams.Add("PSNOPRCN", pobjFiltro("PSNOPRCN"))
                lobjParams.Add("PNFECFAC", pobjFiltro("PNFECFAC"))
                'lobjParams.Add("PSCMNDA", pobjFiltro("PSCMNDA"))
                lobjParams.Add("PSCCMPN", pobjFiltro("PSCCMPN"))
                lobjParams.Add("PSCDVSN", pobjFiltro("PSCDVSN"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_IMPRIMIR_SUSTENTO_FACTURA_1", lobjParams)
            Catch ex As Exception
                dt = Nothing
            End Try

            Return dt
        End Function
        Public Function Mostrar_ReFactura_Detallada(ByVal pobjFiltro As Hashtable) As DataTable
            Dim dt As DataTable
            Dim lobjParams As New Parameter
            Try
                lobjParams.Add("PSNOPRCN", pobjFiltro("PSNOPRCN"))
                lobjParams.Add("PNFECFAC", pobjFiltro("PNFECFAC"))
                lobjParams.Add("PNCTPODC", pobjFiltro("PNCTPODC"))
                lobjParams.Add("PSCCMPN", pobjFiltro("PSCCMPN"))
                lobjParams.Add("PSCDVSN", pobjFiltro("PSCDVSN"))
                lobjParams.Add("PNTPCMBO", pobjFiltro("PNTPCMBO"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_IMPRIMIR_SUSTENTO_REFACTURA", lobjParams)
            Catch ex As Exception
                dt = Nothing
            End Try

            Return dt
        End Function
        Public Function Listar_Facturas_X_Operaciones_Liberadas(ByVal pobjFiltro As Hashtable) As DataTable
            Dim dt As DataTable
            Dim lobjParams As New Parameter
            Try
                lobjParams.Add("PSNOPRCN", pobjFiltro("PSNOPRCN"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_FACTURAS_X_OPERACIONES_LIBERADAS", lobjParams)
            Catch ex As Exception
                dt = Nothing
            End Try

            Return dt
        End Function

        Public Function Listar_Importes_Servicio_Operaciones(ByVal objParametro As Hashtable) As DataTable
            Dim dt As DataTable
            Dim lobjParams As New Parameter
            Try
                lobjParams.Add("PSNOPRCN", objParametro("PSNOPRCN"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_IMPORTE_SERVICIO", lobjParams)
            Catch ex As Exception
                dt = Nothing
            End Try
            Return dt
        End Function

        Public Function Actualizar_Facturacion_Libre(ByVal pobjFiltro As Hashtable) As Int32
            Dim lintEstado As Int32 = 0
            Try
                Dim lobjParams As New Parameter
                lobjParams.Add("PNNOPRCN", pobjFiltro("PNNOPRCN2"))
                lobjParams.Add("PNCTPDCF", pobjFiltro("PNCTPDCF"))
                lobjParams.Add("PNNDCMFC", pobjFiltro("PNNDCMFC"))
                lobjParams.Add("PSSESTOP", pobjFiltro("PSSESTOP"))
                'lobjParams.Add("PNFECFAC", pobjFiltro("PNFECFAC"))
                lobjParams.Add("PSTRFSRC", pobjFiltro("PSTRFSRC"))
                lobjParams.Add("PSCCMPN", pobjFiltro("PSCCMPN"))
                lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
                lobjParams.Add("PSNTRMNL", My.Computer.Name.Trim)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_FACTURACION_LIBRE", lobjParams)
                lintEstado = 0
            Catch ex As Exception
                lintEstado = 1
            End Try
            Return lintEstado
        End Function

        Public Function Validar_Facturacion_Libre(ByVal pobjFiltro As Hashtable, ByRef sErrorMesage As String) As Boolean
            Dim bResultado As Boolean = True
            Try
                Dim lobjParams As New Parameter
                lobjParams.Add("PSCCMPN", pobjFiltro("PSCCMPN"))
                lobjParams.Add("PNNOPRCN", pobjFiltro("PNNOPRCN"))
                lobjParams.Add("PNCTPDCF", pobjFiltro("PNCTPDCF"))
                lobjParams.Add("PNNDCMFC", pobjFiltro("PNNDCMFC"))
                'lobjParams.Add("PSSESTOP", pobjFiltro("PSSESTOP"))
                'lobjParams.Add("PNFECFAC", pobjFiltro("PNFECFAC"))
                'lobjParams.Add("PSTRFSRC", pobjFiltro("PSTRFSRC"))
                'lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
                'lobjParams.Add("PSNTRMNL", My.Computer.Name.Trim)
                lobjParams.Add("OU_MSGERR", "", ParameterDirection.Output)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
                objSql.ExecuteNoQuery("SP_SOLMIN_ST_VALIDAR_FACTURACION_LIBRE", lobjParams)
                sErrorMesage = "" & objSql.ParameterCollection("OU_MSGERR")
                If sErrorMesage <> "" Then bResultado = False
            Catch ex As Exception
                sErrorMesage = ex.Message
                bResultado = False
            End Try
            Return bResultado
        End Function

        Public Sub fintActualizarFacturaDetracionSPOT(ByVal pobjFiltro As Hashtable)
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            Dim dt As New DataTable
            lobjParams.Add("PSCCMPN", pobjFiltro("PSCCMPN"))
            lobjParams.Add("PNCTPODC", pobjFiltro("PNCTPDCF"))
            lobjParams.Add("PNNDCFCC", pobjFiltro("PNNDCMFC"))
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
            lobjParams.Add("PSNTRMNL", My.Computer.Name.Trim)
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
        Public Function fintRevertirProvisionXFactura(ByVal pobjFiltro As Hashtable) As Integer
            Try
                Dim lobjSql As New SqlManager
                Dim lobjParams As New Parameter
                Dim dt As New DataTable
                lobjParams.Add("PSCCMPN", pobjFiltro("PSCCMPN"))
                lobjParams.Add("PNCTPODC", pobjFiltro("PNCTPODC"))
                lobjParams.Add("PNNDCMFC", pobjFiltro("PNNDCMFC"))
                lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
                lobjParams.Add("PSNTRMNL", My.Computer.Name.Trim)

                lobjSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjFiltro("PSCCMPN"))
                lobjSql.ExecuteNonQuery("SP_SOLMIN_CT_REVERTIR_PROVISION_OPERACIONES_TRANSPORTE_X_FACTURA", lobjParams)
                Return 1
            Catch ex As Exception
                Return -1
            End Try

        End Function


    End Class
End Namespace