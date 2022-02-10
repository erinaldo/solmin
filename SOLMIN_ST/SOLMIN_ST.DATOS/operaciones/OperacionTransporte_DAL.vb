Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Namespace Operaciones

    Public Class OperacionTransporte_DAL

        Private objSql As New SqlManager

        Public Function Validar_Asignacion_Operacion_Transporte(ByVal objEntidad As List(Of String)) As String
            Dim objResultado As String = ""
            Try
                Dim objParam As New Parameter
                objParam.Add("PON_STATUS", "", ParameterDirection.Output)
                objParam.Add("PNNCSOTR", objEntidad(0))
                objParam.Add("PNNORSRT", objEntidad(1))
                objParam.Add("PNCCLNT", objEntidad(2))
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_VALIDAR_ORDEN_SERVICIO", objParam)
                objResultado = objSql.ParameterCollection("PON_STATUS").ToString()
            Catch ex As Exception
                objResultado = "ERROR : " & ex.Message
            End Try
            Return objResultado
        End Function

        Public Function Registrar_Operacion_Transporte(ByVal objLista As ENTIDADES.beRespuestaOperacion, ByRef msgError As String) As ENTIDADES.beRespuestaOperacion
            msgError = ""


            Dim oRespuesta As New ENTIDADES.beRespuestaOperacion
            Try
                Dim objParam As New Parameter
             

                objParam.Add("PARAM_NCSOTR", objLista.NCSOTR)
                objParam.Add("PARAM_NCRRSR", objLista.NCRRSR)
                'objParam.Add("PARAM_NORSRT", objLista.NORSRT)
                'objParam.Add("PARAM_CCMPN", objLista.CCMPN)
                'objParam.Add("PARAM_CDVSN", objLista.CDVSN)
                'objParam.Add("PARAM_CPLNDV", objLista.CPLNDV)
                objParam.Add("PARAM_CUSCRT", objLista.CUSCRT)
                objParam.Add("PARAM_NTRMCR", objLista.NTRMCR)
                objParam.Add("PARAM_TIPO_REGISTRO", IIf(objLista.TIPO_REGISTRO = "NUEVO", 0, 1))
                objParam.Add("PARAM_SORGMV", objLista.SORGMV)
                objParam.Add("PARAM_NDCORM", objLista.NDCORM)
                objParam.Add("PARAM_PNCDTR", objLista.PNCDTR)
                objParam.Add("PARAM_FATNSR", objLista.FATNSR)
                objParam.Add("PARAM_HATNSR", objLista.HATNSR)
                objParam.Add("PARAM_CTPOVJ", objLista.CTPOVJ)
                objParam.Add("PARAM_NROOPREL", 0) 'parametro enviado desde hubsmart.Referencia a su operacion principal

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objLista.CCMPN)

                'objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_OPERACION_TRANSPORTE_1", objParam)
                Dim dt As New DataTable

                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_REGISTRAR_OPERACION_TRANSPORTE_SALM", objParam)
                'objResultado = objSql.ParameterCollection("PARAM_NOPRCN").ToString()
                For Each item As DataRow In dt.Rows
                    If item("STATUS") = "E" Then
                        msgError = msgError & item("OBSRESULT")
                    End If

                Next
                msgError = msgError.Trim
                If dt.Rows.Count > 0 Then
                    oRespuesta.NOPRCN = dt.Rows(0)("NOPRCN")
                    oRespuesta.NPLNMT = dt.Rows(0)("NPLNMT")
                    oRespuesta.NCRRPL = dt.Rows(0)("NCRRPL")
                    oRespuesta.NSBCRP = dt.Rows(0)("NSBCRP")
                End If
                'NOPRCN ,NPLNMT,NCRRPL, NSBCRP
            Catch ex As Exception
                msgError = "ERROR : " & ex.Message
            End Try
            Return oRespuesta
        End Function

        Public Function Listar_Guias_X_Operacion(ByVal objLista As List(Of String)) As DataTable
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            Try
                objParam.Add("PSCCLNT", objLista(0))
                objParam.Add("PSSESTOP", objLista(1))
                objParam.Add("PSNOPRCN", objLista(2))
                If objLista(3) <> "" And objLista(4) <> "" Then
                    objParam.Add("PNFECINI", objLista(3))
                    objParam.Add("PNFECFIN", objLista(4))
                End If
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_X_OPERACION", objParam)
            Catch ex As Exception
            End Try
            Return objDataTable
        End Function

        Public Function Listar_Operacion(ByVal objLista As List(Of String)) As DataTable
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            Try
                objParam.Add("PSCCLNT", objLista(0))
                objParam.Add("PSSESTOP", objLista(1))
                objParam.Add("PSNOPRCN", objLista(2))
                If objLista(3) <> "" And objLista(4) <> "" Then
                    objParam.Add("PNFECINI", objLista(3))
                    objParam.Add("PNFECFIN", objLista(4))
                End If
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OPERACION", objParam)
            Catch ex As Exception
                Return New DataTable
            End Try
            Return objDataTable
        End Function

        Public Function Listar_Operacion_x_Cliente(ByVal objParametro As Hashtable) As List(Of OperacionTransporte)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of OperacionTransporte)
            Dim objEntidad As OperacionTransporte
            Dim objParam As New Parameter
            Try
                objParam.Add("PNCCLNT", objParametro("CCLNT"))
                objParam.Add("PNFECINI", objParametro("FECINI"))
                objParam.Add("PNFECFIN", objParametro("FECFIN"))
                objParam.Add("PSNPLCTR", objParametro("NPLCTR"))
                objParam.Add("PSCCMPN", objParametro("CCMPN"))
                objParam.Add("PSCDVSN", objParametro("CDVSN"))
                objParam.Add("PNCPLNDV", objParametro("CPLNDV"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("CCMPN"))

                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OPERACION_X_CLIENTE_V1", objParam)
                For Each objDataRow As DataRow In objDataTable.Rows
                    objEntidad = New OperacionTransporte
                    objEntidad.NOPRCN = objDataRow("NOPRCN")
                    objEntidad.FINCOP_S = objDataRow("FINCOP").ToString.Trim
                    objEntidad.NPLNMT = objDataRow("NPLNMT")
                    objEntidad.CCLNT = objDataRow("CCLNT")
                    objEntidad.TCMPCL = objDataRow("TCMPCL").ToString.Trim
                    objEntidad.NORSRT = objDataRow("NORSRT")
                    objEntidad.SESTOP = objDataRow("SESTOP").ToString.Trim
                    objEntidad.CCNCST = objDataRow("CCNCST")
                    objEntidad.TCNTCS = objDataRow("TCNTCS").ToString.Trim
                    objEntidad.TRFMRC = objDataRow("TRFMRC").ToString.Trim
                    objEntidad.RUTA = objDataRow("RUTA").ToString.Trim
                    objEntidad.NPLVHT = objDataRow("NPLCTR").ToString.Trim
                    objEntidad.NRUCTR = objDataRow("NRUCTR").ToString.Trim
                    objEntidad.CBRCNT = objDataRow("CBRCNT").ToString.Trim
                    objEntidad.CTRSPT = objDataRow("CTRSPT")
                    objGenericCollection.Add(objEntidad)
                Next
            Catch ex As Exception
                Return New List(Of OperacionTransporte)
            End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Operacion_x_Guia_y_Tracto(ByVal objParametro As Hashtable) As List(Of OperacionTransporte)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of OperacionTransporte)
            Dim objEntidad As OperacionTransporte
            Dim objParam As New Parameter
            Try
                objParam.Add("PNNGUITR", objParametro("NGUITR"))
                objParam.Add("PNCTRSPT", objParametro("CTRSPT"))
                objParam.Add("PSNPLCTR", objParametro("NPLCTR"))
                objParam.Add("PSCCMPN", objParametro("CCMPN"))
                objParam.Add("PSCDVSN", objParametro("CDVSN"))
                objParam.Add("PNCPLNDV", objParametro("CPLNDV"))
                objParam.Add("PNFECINI", objParametro("FECINI"))
                objParam.Add("PNFECFIN", objParametro("FECFIN"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("CCMPN"))

                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OPERACION_X_GUIA_TRACTO", objParam)
                For Each objDataRow As DataRow In objDataTable.Rows
                    objEntidad = New OperacionTransporte
                    objEntidad.NGUITR = objDataRow("NGUIRM")
                    objEntidad.NOPRCN = objDataRow("NOPRCN")
                    objEntidad.FINCOP_S = objDataRow("FGUIRM").ToString.Trim
                    objEntidad.NPLNMT = objDataRow("NPLNMT")
                    objEntidad.TCMPCL = objDataRow("TCMPCL").ToString.Trim
                    objEntidad.NORSRT = objDataRow("NORSRT")
                    objEntidad.RUTA = objDataRow("RUTA").ToString
                    objEntidad.QKMREC = objDataRow("QKMREC")
                    objEntidad.PMRCDR = objDataRow("PMRCMC")
                    objEntidad.SESTOP = objDataRow("SESTOP").ToString.Trim

                    objGenericCollection.Add(objEntidad)
                Next
            Catch ex As Exception
                Return New List(Of OperacionTransporte)
            End Try
            Return objGenericCollection
        End Function

        Public Function Obtener_Numero_Planeamiento(ByVal objEntidad As OperacionTransporte) As OperacionTransporte
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            Try
                objParam.Add("PARAM_NPLNMT", 0, ParameterDirection.Output)
                objParam.Add("PARAM_NOPRCN", objEntidad.NOPRCN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_OBTENER_NUMERO_PLANEAMIENTO", objParam)
                objEntidad.NPLNMT = objSql.ParameterCollection("PARAM_NPLNMT").ToString
            Catch ex As Exception
                objEntidad.NPLNMT = "0"
            End Try
            Return objEntidad
        End Function

        Public Function Verificacion_Existencia_Operacion_Solicitud(ByVal objLista As List(Of String)) As String
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            Dim objResultado As String = ""
            Try
                objParam.Add("PON_STATUS", 0, ParameterDirection.Output)
                objParam.Add("PNNCSOTR", objLista(0))
                objParam.Add("PNNCRRSR", objLista(1))
                objParam.Add("PNNPLNJT", objLista(2))
                objParam.Add("PNNCRRPL", objLista(3))
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_VERIFICACION_EXISTENCIA_OPERACION", objParam)
                objResultado = objSql.ParameterCollection("PON_STATUS").ToString
            Catch ex As Exception
                objResultado = "0"
            End Try
            Return objResultado
        End Function

        Public Function Validar_Existe_Operacion(ByVal lint_NOPRCN As Double, ByVal strCompania As String) As Double
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            Dim Status As Double = 0
            Try
                objParam.Add("PON_NOPRCN", lint_NOPRCN, ParameterDirection.Output)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCompania)

                objSql.ExecuteNonQuery("SP_SOLMIN_ST_VERIFICAR_EXISTENCIA_OPERACION_TRANSPORTISTA", objParam)
                Status = objSql.ParameterCollection("PON_NOPRCN")
            Catch ex As Exception
                Status = 0
            End Try
            Return Status
        End Function

        Public Function Registrar_Pase_Administrativo_Operacion(ByVal ht As Hashtable) As Int16
            Try
                Dim objData As New DataTable
                Dim objParametros As New Parameter
                objSql.TransactionController(TransactionType.Automatic)
                objParametros.Add("PSNOPRCN", ht.Item("NOPRCN"))
                objParametros.Add("PSSESDCM", ht.Item("SESDCM"))
                objParametros.Add("PNFCHCRT", ht.Item("FCHCRT"))
                objParametros.Add("PNHRACRT", ht.Item("HRACRT"))
                objParametros.Add("PSCUSCRT", ht.Item("CUSCRT"))
                objParametros.Add("PSNTRMNL", ht.Item("NTRMNL"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(ht.Item("CCMPN"))

                objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_PASE_OPERACION", objParametros)
                Return 1
            Catch ex As Exception
                Return 0
            End Try

        End Function

        Public Function Listar_Operaciones(ByVal objParametro As Hashtable) As DataTable
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            Try
                objParam.Add("PSCCMPN", objParametro("CCMPN"))
                objParam.Add("PSCDVSN", objParametro("CDVSN"))
                objParam.Add("PNCPLNDV", objParametro("CPLNDV"))
                objParam.Add("PNCCLNT", objParametro("CCLNT"))
                objParam.Add("PSNRUCTR", objParametro("NRUCTR"))
                objParam.Add("PSNPLCTR", objParametro("NPLCTR"))

                objParam.Add("PNFECINI", objParametro("FECINI"))
                objParam.Add("PNFECFIN", objParametro("FECFIN"))
                objParam.Add("PNNOPRCN", objParametro("NOPRCN"))
                objParam.Add("PNNGUIRM", objParametro("NGUIRM"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("CCMPN"))

                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OPERACION_LIQ_COMBUSTIBLE", objParam)
            Catch ex As Exception
            End Try
            Return objDataTable

        End Function

        Public Function Listar_Operacion_Asignar(ByVal objParametro As Hashtable) As List(Of OperacionTransporte)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of OperacionTransporte)
            Dim objEntidad As OperacionTransporte
            Dim objParam As New Parameter
            Try
                objParam.Add("PNNOPRCN", objParametro("NOPRCN"))
                objParam.Add("PSNPLCUN", objParametro("NPLCUN"))
                'objParam.Add("PNNGUIRM", objParametro("NGUIRM"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("NOPRCN"))

                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OPERACION_X_OPR_PLC_GT", objParam)
                For Each objDataRow As DataRow In objDataTable.Rows
                    objEntidad = New OperacionTransporte
                    objEntidad.NOPRCN = objDataRow("NOPRCN")
                    objEntidad.CCLNT = objDataRow("CCLNT")
                    objEntidad.TCMPCL = objDataRow("TCMPCL")
                    objEntidad.RUTA = objDataRow("RUTA").ToString.Trim
                    objEntidad.QKMREC = objDataRow("QKMREC")
                    objEntidad.PMRCMC = objDataRow("PMRCMC")
                    objEntidad.CTPOVJ = objDataRow("CTPOVJ").ToString.Trim
                    objEntidad.NPLCUN = objDataRow("NPLCUN")
                    objEntidad.NGUIRM = objDataRow("NGUIRM")

                    objGenericCollection.Add(objEntidad)
                Next
            Catch ex As Exception
                Return New List(Of OperacionTransporte)
            End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Operacion_TipViajeConsolidado_Asignar(ByVal objParametro As Hashtable) As List(Of OperacionTransporte)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of OperacionTransporte)
            Dim objEntidad As OperacionTransporte
            Dim objParam As New Parameter
            Try
                objParam.Add("PNNOPRCN", objParametro("NOPRCN"))
                objParam.Add("PSNPLCUN", objParametro("NPLCUN"))
                objParam.Add("PNNMVJCS", objParametro("NMVJCS"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("NOPRCN"))

                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OPERACION_X_OPR_PLC_GT_CONS", objParam)
                For Each objDataRow As DataRow In objDataTable.Rows
                    objEntidad = New OperacionTransporte
                    objEntidad.NOPRCN = objDataRow("NOPRCN")
                    objEntidad.CCLNT = objDataRow("CCLNT")
                    objEntidad.TCMPCL = objDataRow("TCMPCL")
                    objEntidad.RUTA = objDataRow("RUTA").ToString.Trim
                    objEntidad.QKMREC = objDataRow("QKMREC")
                    objEntidad.PMRCMC = objDataRow("PMRCMC")
                    objEntidad.CTPOVJ = objDataRow("CTPOVJ").ToString.Trim
                    objEntidad.NPLCUN = objDataRow("NPLCUN")
                    objEntidad.NGUIRM = objDataRow("NGUIRM")

                    objGenericCollection.Add(objEntidad)
                Next
            Catch ex As Exception
                Return New List(Of OperacionTransporte)
            End Try
            Return objGenericCollection
        End Function

        Public Function Validar_Existe_Vale_Combustible(ByVal objParametro As Hashtable) As List(Of OperacionTransporte)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of OperacionTransporte)
            Dim objEntidad As OperacionTransporte
            Dim objParam As New Parameter
            Try

                objParam.Add("PNNVLGRF", objParametro("NVLGRF"))
                objParam.Add("PSCCMPN", objParametro("CCMPN"))
                objParam.Add("PSCDVSN", objParametro("CDVSN"))
                objParam.Add("PNCPLNDV", objParametro("CPLNDV"))


                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("CCMPN"))

                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_VALES_X_NRO", objParam)
                For Each objDataRow As DataRow In objDataTable.Rows
                    objEntidad = New OperacionTransporte
                    objEntidad.NVLGRF = objDataRow("NVLGRF")

                    objGenericCollection.Add(objEntidad)
                Next
            Catch ex As Exception
                Return New List(Of OperacionTransporte)
            End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Operaciones_Asignacion(ByVal objParametro As Hashtable) As DataTable
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            Try
                objParam.Add("PNNOPRCN", objParametro("NOPRCN"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("CCMPN"))
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OPERACION_LIQ_COMB", objParam)
            Catch ex As Exception
            End Try
            Return objDataTable
        End Function

        Public Function Lista_Operaciones_Liq_Combustible_X_Cliente(ByVal objParametro As Hashtable) As List(Of OperacionTransporte)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of OperacionTransporte)
            Dim objEntidad As OperacionTransporte
            Dim objParam As New Parameter
            Try
                objParam.Add("PNCCLNT", objParametro("CCLNT"))
                objParam.Add("PNFECINI", objParametro("FECINI"))
                objParam.Add("PNFECFIN", objParametro("FECFIN"))
                objParam.Add("PSNPLCTR", objParametro("NPLCTR"))
                objParam.Add("PSCCMPN", objParametro("CCMPN"))
                objParam.Add("PSCDVSN", objParametro("CDVSN"))
                objParam.Add("PNCPLNDV", objParametro("CPLNDV"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("CCMPN"))

                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OPERACION_X_CLIENTE_LIQ_COMB", objParam)
                For Each objDataRow As DataRow In objDataTable.Rows
                    objEntidad = New OperacionTransporte
                    objEntidad.NOPRCN = objDataRow("NOPRCN")
                    objEntidad.FINCOP_S = objDataRow("FINCOP").ToString.Trim
                    objEntidad.NPLNMT = objDataRow("NPLNMT")
                    objEntidad.CCLNT = objDataRow("CCLNT")
                    objEntidad.TCMPCL = objDataRow("TCMPCL").ToString.Trim
                    objEntidad.NORSRT = objDataRow("NORSRT")
                    objEntidad.SESTOP = objDataRow("SESTOP").ToString.Trim
                    objEntidad.CCNCST = objDataRow("CCNCST")
                    objEntidad.TCNTCS = objDataRow("TCNTCS").ToString.Trim
                    objEntidad.TRFMRC = objDataRow("TRFMRC").ToString.Trim
                    objEntidad.RUTA = objDataRow("RUTA").ToString.Trim
                    objEntidad.NPLVHT = objDataRow("NPLCTR").ToString.Trim
                    objGenericCollection.Add(objEntidad)
                Next
            Catch ex As Exception
                Return New List(Of OperacionTransporte)
            End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Operacion_Asignar_ImpExcel(ByVal objParametro As Hashtable) As List(Of OperacionTransporte)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of OperacionTransporte)
            Dim objEntidad As OperacionTransporte
            Dim objParam As New Parameter
            Try
                objParam.Add("PNNOPRCN", objParametro("NOPRCN"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("NOPRCN"))

                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OPERACION_X_OPR_CONS_LIQ", objParam)
                For Each objDataRow As DataRow In objDataTable.Rows
                    objEntidad = New OperacionTransporte
                    objEntidad.NOPRCN = objDataRow("NOPRCN")
                    objEntidad.CCLNT = objDataRow("CCLNT")
                    objEntidad.TCMPCL = objDataRow("TCMPCL")
                    objEntidad.RUTA = objDataRow("RUTA").ToString.Trim
                    objEntidad.QKMREC = objDataRow("QKMREC")
                    objEntidad.PMRCMC = objDataRow("PMRCMC")
                    objEntidad.CTPOVJ = objDataRow("CTPOVJ").ToString.Trim
                    objEntidad.NPLCUN = objDataRow("NPLCUN")
                    objEntidad.NGUIRM = objDataRow("NGUIRM")

                    objGenericCollection.Add(objEntidad)
                Next
            Catch ex As Exception
                Return New List(Of OperacionTransporte)
            End Try
            Return objGenericCollection
        End Function

        'Public Function Listar_Operaciones_Consumo_Neumatico(ByVal objParametro As Hashtable) As DataTable
        '    Dim objDataTable As New DataTable
        '    Dim objParam As New Parameter
        '    Try
        '        objParam.Add("PSCCMPN", objParametro("CCMPN"))
        '        objParam.Add("PSCDVSN", objParametro("CDVSN"))
        '        objParam.Add("PNCPLNDV", objParametro("CPLNDV"))
        '        objParam.Add("PNCCLNT", objParametro("CCLNT"))
        '        objParam.Add("PSNRUCTR", objParametro("NRUCTR"))
        '        objParam.Add("PSNPLCTR", objParametro("NPLCTR"))
        '        objParam.Add("PSOPCION", objParametro("OPCION"))
        '        objParam.Add("PNFECINI", objParametro("FECINI"))
        '        objParam.Add("PNFECFIN", objParametro("FECFIN"))
        '        objParam.Add("PNNOPRCN", objParametro("NOPRCN"))
        '        objParam.Add("PNNGUIRM", objParametro("NGUIRM"))
        '        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("CCMPN"))

        '        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OPERACION_CONSUMO_NEUMATICO", objParam)
        '    Catch ex As Exception
        '    End Try
        '    Return objDataTable
        'End Function

        'Public Function Listar_Operaciones_Consumo_Mantenimiento(ByVal objParametro As Hashtable) As DataTable
        '    Dim objDataTable As New DataTable
        '    Dim objParam As New Parameter
        '    Try
        '        objParam.Add("PSCCMPN", objParametro("CCMPN"))
        '        objParam.Add("PSCDVSN", objParametro("CDVSN"))
        '        objParam.Add("PNCPLNDV", objParametro("CPLNDV"))
        '        objParam.Add("PNCCLNT", objParametro("CCLNT"))
        '        objParam.Add("PSNRUCTR", objParametro("NRUCTR"))
        '        objParam.Add("PSNPLCTR", objParametro("NPLCTR"))
        '        objParam.Add("PSOPCION", objParametro("OPCION"))
        '        objParam.Add("PNFECINI", objParametro("FECINI"))
        '        objParam.Add("PNFECFIN", objParametro("FECFIN"))
        '        objParam.Add("PNNOPRCN", objParametro("NOPRCN"))
        '        objParam.Add("PNNGUIRM", objParametro("NGUIRM"))
        '        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("CCMPN"))

        '        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OPERACION_CONSUMO_MANTENIMIENTO", objParam)
        '    Catch ex As Exception
        '    End Try
        '    Return objDataTable
        'End Function

        Public Function Listar_Operacion_X_Fecha_CN(ByVal objParametro As Hashtable) As List(Of OperacionTransporte)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of OperacionTransporte)
            Dim objEntidad As OperacionTransporte
            Dim objParam As New Parameter
            Try
                objParam.Add("PSTIPO", objParametro("OPCION"))
                objParam.Add("PNFECINI", objParametro("FECINI"))
                objParam.Add("PNFECFIN", objParametro("FECFIN"))
                objParam.Add("PSCCMPN", objParametro("CCMPN"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("CCMPN"))

                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OPERACION_CN", objParam)
                For Each objDataRow As DataRow In objDataTable.Rows
                    objEntidad = New OperacionTransporte
                    objEntidad.NOPRCN = objDataRow("NOPRCN")
                    objEntidad.NPLCUN = objDataRow("NPLCUN")
                    objEntidad.QKMREC = objDataRow("QKMREC")
                    objEntidad.PMRCMC = objDataRow("PMRCMC")

                    objGenericCollection.Add(objEntidad)
                Next
            Catch ex As Exception
                Return New List(Of OperacionTransporte)
            End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Operacion_X_Fecha_CM(ByVal objParametro As Hashtable) As List(Of OperacionTransporte)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of OperacionTransporte)
            Dim objEntidad As OperacionTransporte
            Dim objParam As New Parameter
            Try
                objParam.Add("PSTIPO", objParametro("OPCION"))
                objParam.Add("PNFECINI", objParametro("FECINI"))
                objParam.Add("PNFECFIN", objParametro("FECFIN"))
                objParam.Add("PSCCMPN", objParametro("CCMPN"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("CCMPN"))

                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OPERACION_CM", objParam)
                For Each objDataRow As DataRow In objDataTable.Rows
                    objEntidad = New OperacionTransporte
                    objEntidad.NOPRCN = objDataRow("NOPRCN")
                    objEntidad.NPLCUN = objDataRow("NPLCUN")
                    objEntidad.QKMREC = objDataRow("QKMREC")
                    objEntidad.PMRCMC = objDataRow("PMRCMC")

                    objGenericCollection.Add(objEntidad)
                Next
            Catch ex As Exception
                Return New List(Of OperacionTransporte)
            End Try
            Return objGenericCollection
        End Function

        Public Function Carga_InfEscaner(ByVal objParametro As Hashtable) As DataTable
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            objParam.Add("PNNLQCMB", objParametro("PNNLQCMB"))
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_CARGAR_INFESCANER", objParam)
            Return objDataTable
        End Function

        Public Function Cargar_Ultimo_KM_Final_Unidad(CCMPN As String, NPLCUN As String) As DataTable
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            objParam.Add("PSPSCCMPN", CCMPN)
            objParam.Add("PSNPLCUN", NPLCUN)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_CARGAR_ULTIMO_KM_UNIDAD", objParam)
            Return objDataTable
        End Function


        Public Function Registrar_Recurso_Planeamiento_Operacion(oFiltro As ENTIDADES.Operaciones.OperacionTransporte, msgError As String) As DataTable

            Dim objParam As New Parameter

            objParam.Add("PARAM_CCMPN", oFiltro.CCMPN)
            objParam.Add("PARAM_NOPRCN", oFiltro.NOPRCN)
            objParam.Add("PARAM_NRUCTR", oFiltro.NRUCTR)
            objParam.Add("PARAM_NPLCTR", oFiltro.NPLCUN)
            objParam.Add("PARAM_NPLCAC", oFiltro.NPLCAC)
            objParam.Add("PARAM_CBRCNT", oFiltro.CBRCNT)
            objParam.Add("PARAM_CBRCN2", oFiltro.CBRCN2)
            objParam.Add("PARAM_QPLNPL", oFiltro.QPLNPL)
            objParam.Add("PARAM_NTRMCR", Ransa.Utilitario.HelpClass.NombreMaquina())
            objParam.Add("PARAM_CUSCRT", oFiltro.CULUSA)



            '            NOPRCN NUMERIC(10,0) ,
            'NPLNMT NUMERIC(10,0) ,
            'NCRRPL NUMERIC(10,0) ,
            'NSBCRP NUMERIC(10,0)

            msgError = ""
            Dim dt As New DataTable
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_REGISTRAR_RECURSO_PLANEAMIENTO_OPERACION", objParam)
            Dim msg As String = ""
            For Each item As DataRow In dt.Rows
                If item("STATUS") = "E" Then
                    msgError = msgError & item("OBSRESULT")
                End If
            Next
            msgError = msgError.Trim

            Return dt
        End Function



        Public Function Actualizar_Fecha_Hora_Atencion_Servicio_Operacion(ByVal beOp As ENTIDADES.Operaciones.OperacionTransporte) As String
            Dim objResultado As String = ""

            Dim objParam As New Parameter
            objParam.Add("PARAM_NOPRCN", beOp.NOPRCN)
            objParam.Add("PARAM_FATNSR", beOp.FATNSR)
            objParam.Add("PARAM_HATNSR", beOp.HATNSR)
            objParam.Add("PARAM_CULUSA", beOp.CULUSA)
            objParam.Add("PARAM_NTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina())
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(beOp.CCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_FECHA_HORA_ATENCION_SERVICIO_OPERACION", objParam)
            Return objResultado
        End Function

    End Class

End Namespace