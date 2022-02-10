Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports Ransa.Utilitario
Namespace Operaciones
    Public Class LiquidacionGastos_DAL
        Private objSql As New SqlManager

        Public Function Registrar_Liquidacion_Gasto(ByVal objEntidad As LiquidacionGastos) As LiquidacionGastos
            Try
                Dim objParam As New Parameter
                objParam.Add("PON_NLQGST", objEntidad.NLQGST, ParameterDirection.Output)
                objParam.Add("PNNCSOTR", objEntidad.NCSOTR)
                objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
                objParam.Add("PNCCNCST", objEntidad.CCNCST)
                objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
                objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
                objParam.Add("PSNPLCAC", objEntidad.NPLCAC)
                objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
                objParam.Add("PSUSRCRT", objEntidad.USRCRT)
                objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
                objParam.Add("PNHRACRT", objEntidad.HRACRT)
                objParam.Add("PNCLCLOR", objEntidad.CLCLOR)
                objParam.Add("PNCLCLDS", objEntidad.CLCLDS)
                objParam.Add("PSTDSCAR", objEntidad.TDSCAR)
                objParam.Add("PNNKMRTA", objEntidad.NKMRTA)
                objParam.Add("PSCULUSA", objEntidad.CULUSA)
                objParam.Add("PNFULTAC", objEntidad.FULTAC)
                objParam.Add("PNHULTAC", objEntidad.HULTAC)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_LIQUIDACION_GASTOS", objParam)
                objEntidad.NLQGST = objSql.ParameterCollection("PON_NLQGST")
            Catch ex As Exception
                objEntidad.NLQGST = 0
            End Try
            Return objEntidad
        End Function

        Public Function Eliminar_Liquidacion_Gasto(ByVal objEntidad As LiquidacionGastos) As Decimal
            'Try
            Dim NLQGST As Decimal = 0
            Dim objParam As New Parameter
            objParam.Add("PON_NLQGST", objEntidad.NLQGST, ParameterDirection.Output)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_LIQUIDACION_GASTOS", objParam)
            NLQGST = objSql.ParameterCollection("PON_NLQGST")
            'objEntidad.NLQGST = NLQGST
            'Catch ex As Exception
            '          objEntidad.NLQGST = 0
            '      End Try
            ' Return objEntidad
            Return NLQGST
        End Function

        Public Function Listar_Seguimiento_AVC(ByVal objetoParametro As Hashtable) As DataTable
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of LiquidacionGastos)
            Dim objParam As New Parameter

            objParam.Add("PNNLQGST", objetoParametro("PNNLQGST"))
            objParam.Add("PSNPLCUN", objetoParametro("PSNPLCUN"))
            objParam.Add("PSCBRCNT", objetoParametro("PSCBRCNT"))
            objParam.Add("PNFECINI", objetoParametro("PNFECINI"))
            objParam.Add("PNFECFIN", objetoParametro("PNFECFIN"))
            objParam.Add("PSSESTRG", objetoParametro("PSSESTRG"))
            objParam.Add("PSUSRCRT", objetoParametro("PSUSRCRT"))
            objParam.Add("PSUSRCRR", objetoParametro("PSUSRCRR"))
            Return objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SEGUIMIENTO_LIQ_AVC_LM", objParam)
        End Function

        Public Function Listar_Liquidacion_Gasto(ByVal objetoParametro As Hashtable) As List(Of LiquidacionGastos)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of LiquidacionGastos)
            Dim objDatos As LiquidacionGastos
            Dim objParam As New Parameter
            'Try
            objParam.Add("PNNLQGST", objetoParametro("PNNLQGST"))
            objParam.Add("PSNPLCUN", objetoParametro("PSNPLCUN"))
            objParam.Add("PSCBRCNT", objetoParametro("PSCBRCNT"))
            objParam.Add("PNFECINI", objetoParametro("PNFECINI"))
            objParam.Add("PNFECFIN", objetoParametro("PNFECFIN"))
            objParam.Add("PSSESTRG", objetoParametro("PSSESTRG"))
            objParam.Add("PSUSRCRT", objetoParametro("PSUSRCRT"))
            objParam.Add("PSUSRCRR", objetoParametro("PSUSRCRR"))


            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_LIQUIDACION_GASTOS_LM2", objParam)
            For Each objDataRow As DataRow In objDataTable.Rows
                objDatos = New LiquidacionGastos
                objDatos.NLQGST = objDataRow("NLQGST")
                objDatos.CTRSPT = objDataRow("CTRSPT")
                objDatos.TCMTRT = objDataRow("TCMTRT").ToString.Trim
                objDatos.NPLCUN = objDataRow("NPLCUN").ToString.Trim
                objDatos.NPLCAC = objDataRow("NPLCAC").ToString.Trim
                objDatos.CBRCNT = objDataRow("CBRCNT").ToString.Trim
                objDatos.CBRCND = objDataRow("CBRCND").ToString.Trim
                objDatos.FCHCRT_S = HelpClass.CFecha_de_8_a_10(objDataRow("FCHCRT").ToString.Trim) 'objDataRow("FCHCRT_S").ToString.Trim
                objDatos.SESTRG = objDataRow("SESTRG").ToString.Trim
                objDatos.QTCACT = objDataRow("QTCACT")
                objDatos.QTCSDA = objDataRow("QTCSDA")
                objDatos.QTCLLG = objDataRow("QTCLLG")
                objDatos.NULGUN = objDataRow("NULGUN")
                objDatos.USER_CREACION = objDataRow("USRCRT").ToString.Trim + " -" + HelpClass.CNumero8Digitos_a_Fecha(objDataRow("FCHCRT")).ToString.Trim + "-" + HelpClass.HoraNum_a_Hora(objDataRow("HRACRT")).ToString.Trim 'objDataRow("USER_CREACION").ToString.Trim
                objDatos.USER_LIQUIDADOR = IIf(objDataRow("USRCRR").ToString.Trim = "", "", objDataRow("USRCRR").ToString.Trim + " -" + HelpClass.CNumero8Digitos_a_Fecha(objDataRow("FCHCRR")).ToString.Trim + "-" + HelpClass.HoraNum_a_Hora(objDataRow("HRACRR")).ToString.Trim) 'objDataRow("USER_LIQUIDADOR").ToString.Trim
                objDatos.FECIDE = HelpClass.FechaNum_a_Fecha(objDataRow("FECIDE"))
                '
                objDatos.CODIGOSAP = ("" & objDataRow("CODIGOSAP")).ToString.Trim
                objGenericCollection.Add(objDatos)
            Next
            'Catch : End Try
            Return objGenericCollection
        End Function

        Public Function Eliminar_Operacion_x_Liquidacion(ByVal objEntidad As LiquidacionGastos) As Decimal
            'Try
            Dim NLQGST As Decimal = 0
            Dim objParam As New Parameter
            objParam.Add("PON_NLQGST", objEntidad.NLQGST, ParameterDirection.Output)
            objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
            objParam.Add("PNNCRRRT", objEntidad.NCRRRT)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_OPERACION_X_LIQUIDACION", objParam)
            NLQGST = objSql.ParameterCollection("PON_NLQGST")
            Return NLQGST
            'Catch ex As Exception
            '    objEntidad.NLQGST = 0
            'End Try
            'Return objEntidad
        End Function

        Public Function Listar_Operacion_x_Liquidacion(ByVal objetoParametro As Hashtable) As List(Of LiquidacionGastos)
            Dim objDataTable As New DataTable
            Dim objDatos As New LiquidacionGastos
            Dim lstr_TOBS() As String
            Dim objGenericCollection As New List(Of LiquidacionGastos)
            Dim objParam As New Parameter
            'Try
            objParam.Add("PNNLQGST", objetoParametro("PNNLQGST"))
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OPERACION_X_LIQUIDACION", objParam)
            For Each objDataRow As DataRow In objDataTable.Rows
                objDatos = New LiquidacionGastos
                objDatos.NLQGST = objDataRow("NLQGST")
                objDatos.NOPRCN = objDataRow("NOPRCN")
                objDatos.CCNCST = objDataRow("CCNCST")
                objDatos.TCNTCS = objDataRow("TCNTCS").ToString.Trim
                objDatos.NCRRRT = objDataRow("NCRRRT")
                objDatos.TLGRSL = objDataRow("TLGRSL").ToString.Trim
                objDatos.FSLDCM_S = objDataRow("FSLDCM").ToString.Trim
                objDatos.TLGRLL = objDataRow("TLGRLL").ToString.Trim
                objDatos.FLLGCM_S = objDataRow("FLLGCM").ToString.Trim
                objDatos.TDSCAR = objDataRow("TDSCAR").ToString.Trim
                objDatos.TRLCGU = objDataRow("TRLCGU").ToString.Trim
                objDatos.NKMRTA = objDataRow("NKMRTA")
                'ECM-HUNDRED-(TEP-000001-SOLMIN LIQUIDACION DE GASTOS)-INICIO
                objDatos.NMSLPE = objDataRow("NMSLPE")
                objDatos.NRFSAP = objDataRow("NRFSAP")
                objDatos.AEJINS = objDataRow("AEJINS")
                objDatos.ISLPES = objDataRow("ISLPES")
                objDatos.TADSAP = objDataRow("TADSAP")
                'ECM-HUNDRED-(TEP-000001-SOLMIN LIQUIDACION DE GASTOS)-FIN
                lstr_TOBS = objDataRow("TOBS").ToString.Trim.Split("|")
                If Not lstr_TOBS.Equals("") Then
                    objDatos.CCLNT = lstr_TOBS(0)
                    objDatos.TCMPCL = lstr_TOBS(1)

                    objDatos.NPLNMT = lstr_TOBS(3)
                End If
                If IsDBNull(objDataRow("TGASTO")) = False Then
                    objDatos.TGASTO = objDataRow("TGASTO")
                Else
                    objDatos.TGASTO = 0
                End If
                If IsDBNull(objDataRow("TAVC")) = False Then
                    objDatos.TAVC = objDataRow("TAVC")
                Else
                    objDatos.TAVC = 0
                End If
                objGenericCollection.Add(objDatos)
            Next
            'Catch : End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Liquidacion_Gastos_RPT(ByVal objetoParametro As Hashtable) As DataSet
            Dim objDataSet As New DataSet
            Dim objParam As New Parameter
            'Try
            If objetoParametro("PNCCLNT") = 0 Then
                objParam.Add("PSNPLCUN", objetoParametro("PSNPLCUN"))
                objParam.Add("PSCBRCNT", objetoParametro("PSCBRCNT"))
            Else
                objParam.Add("PNCCLNT", objetoParametro("PNCCLNT"))
            End If
            objParam.Add("PNFECINI", objetoParametro("PNFECINI"))
            objParam.Add("PNFECFIN", objetoParametro("PNFECFIN"))

            'objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_LISTAR_LIQUIDACION_GASTO_RPT", objParam)
            objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_LISTAR_LIQUIDACION_GASTO_RPT_V1", objParam)

            objDataSet.Tables(0).Columns.Add("VISTA", Type.GetType("System.String"))

            Dim valor As String = ""
            Dim valor_anterior As String = ""

            For Each fila As DataRow In objDataSet.Tables(0).Rows

                valor = fila("NLQGST").ToString.Trim
                If valor = valor_anterior Then
                    fila("VISTA") = "0"
                Else
                    fila("VISTA") = "1"
                End If
                valor_anterior = fila("NLQGST").ToString.Trim

            Next

            'Catch ex As Exception

            'End Try

            Return objDataSet
        End Function

        Public Function Listar_Liquidacion_Conductor_Gastos_RPT(ByVal objetoParametro As Hashtable) As DataSet
            Dim objDataSet As New DataSet
            Dim objParam As New Parameter
            'Try
            objParam.Add("PNCCLNT", objetoParametro("PNCCLNT"))
            objParam.Add("PSNPLCUN", objetoParametro("PSNPLCUN"))
            objParam.Add("PSCBRCNT", objetoParametro("PSCBRCNT"))
            objParam.Add("PNFECINI", objetoParametro("PNFECINI"))
            objParam.Add("PNFECFIN", objetoParametro("PNFECFIN"))
            objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_LISTAR_LIQUIDACION_GASTO_CONDUCTOR_RPT", objParam)
            'Catch ex As Exception
            'End Try
            Return objDataSet
        End Function

        Public Function Listar_Liquidacion_General_RPT(ByVal objetoParametro As Hashtable) As DataSet
            Dim objDataSet As New DataSet
            Dim objParam As New Parameter
            'Try

            objParam.Add("PSCCLNT", objetoParametro("PSCCLNT"))
            objParam.Add("PNFECINI", objetoParametro("PNFECINI"))
            objParam.Add("PNFECFIN", objetoParametro("PNFECFIN"))

            objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_LISTAR_LIQUIDACION_GENERAL_RPT", objParam)
            'Catch : End Try
            Return objDataSet
        End Function

        Public Function Registrar_Ruta_x_Operacion(ByVal objEntidad As LiquidacionGastos) As Decimal
            'Try
            Dim retorno As Decimal = 0
            Dim objParam As New Parameter
            objParam.Add("PNNLQGST", objEntidad.NLQGST)
            objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
            objParam.Add("PSTLGRSL", objEntidad.TLGRSL)
            objParam.Add("PNFSLDCM", objEntidad.FSLDCM)
            objParam.Add("PSTLGRLL", objEntidad.TLGRLL)
            objParam.Add("PNFLLGCM", objEntidad.FLLGCM)
            objParam.Add("PSTDSCAR", objEntidad.TDSCAR)
            objParam.Add("PSTRLCGU", objEntidad.TRLCGU)
            objParam.Add("PNNKMRTA", objEntidad.NKMRTA)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_OPERACION_RUTA", objParam)
            retorno = 1
            Return retorno
            'Catch ex As Exception
            '          objEntidad.NLQGST = 0
            '      End Try
            '      Return objEntidad
        End Function

        Public Function Modificar_Ruta_x_Operacion(ByVal objEntidad As LiquidacionGastos) As Decimal
            'Try
            Dim retorno As Decimal = 0
            Dim objParam As New Parameter
            objParam.Add("PNNLQGST", objEntidad.NLQGST)
            objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
            objParam.Add("PNNCRRRT", objEntidad.NCRRRT)

            objParam.Add("PNFSLDCM", objEntidad.FSLDCM)

            objParam.Add("PNFLLGCM", objEntidad.FLLGCM)
            objParam.Add("PSTDSCAR", objEntidad.TDSCAR)
            objParam.Add("PSTRLCGU", objEntidad.TRLCGU)
            objParam.Add("PNNKMRTA", objEntidad.NKMRTA)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_OPERACION_RUTA", objParam)
            retorno = 1
            Return retorno
            'Catch ex As Exception
            '          objEntidad.NLQGST = 0
            '      End Try
            '      Return objEntidad
        End Function

        Public Function Registrar_Gasto_Ruta_Operacion(ByVal objEntidad As LiquidacionGastos) As LiquidacionGastos
            Try
                Dim objParam As New Parameter
                objParam.Add("PONNLQGST", objEntidad.NLQGST, ParameterDirection.Output)
                objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
                objParam.Add("PNNCRRRT", objEntidad.NCRRRT)
                objParam.Add("PNCGSTOS", objEntidad.CGSTOS)
                objParam.Add("PNCDMNDA", objEntidad.CDMNDA)
                objParam.Add("PNIGSTOS", objEntidad.IGSTOS)
                objParam.Add("PSTOBDCT", objEntidad.TOBDCT)
                objParam.Add("PNNCTAVC", objEntidad.NCTAVC)
                objParam.Add("PSCULUSA", objEntidad.CULUSA)
                objParam.Add("PNFULTAC", objEntidad.FULTAC)
                objParam.Add("PNHULTAC", objEntidad.HULTAC)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

                objParam.Add("PNNFECINI", objEntidad.FECINI)
                objParam.Add("PNNFECFIN", objEntidad.FECFIN)
                objParam.Add("PNNCRRGT", objEntidad.NCRRGT)   'ECM-HUNDRED-(TEP-000001-SOLMIN LIQUIDACION DE GASTOS)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_GASTO_OPERACION_RUTA", objParam)
                objEntidad.NLQGST = objSql.ParameterCollection("PONNLQGST")
            Catch ex As Exception
                objEntidad.NLQGST = 0
            End Try
            Return objEntidad
        End Function



        Public Sub Actualizar_Gasto_Ruta_Operacion_X_Gasto(ByVal objEntidad As LiquidacionGastos)

            Dim objParam As New Parameter
            objParam.Add("PNNLQGST", objEntidad.NLQGST)
            objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
            objParam.Add("PNNCRRRT", objEntidad.NCRRRT)
            objParam.Add("PNCGSTOS", objEntidad.CGSTOS)
            objParam.Add("PNIGSTOS_COD", objEntidad.IGSTOS_COD)
            objParam.Add("PNIGSTOS", objEntidad.IGSTOS)
            objParam.Add("PNNFECINI", objEntidad.FECINI)
            objParam.Add("PNNFECFIN", objEntidad.FECFIN)
            objParam.Add("PSTOBDCT", objEntidad.TOBDCT)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PNNCRRGT", objEntidad.NCRRGT) 'ECM-HUNDRED-(TEP-000001-SOLMIN LIQUIDACION DE GASTOS)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_GASTO_OPERACION_RUTA_X_GASTO", objParam)
        End Sub


        Public Function Registrar_FechaRecepcion_Gasto_Ruta_Operacion(ByVal objEntidad As LiquidacionGastos)
            'Try
            Dim retorno As Decimal = 0
            Dim objParam As New Parameter
            objParam.Add("PONNLQGST", objEntidad.NLQGST, ParameterDirection.Output)
            objParam.Add("PNFECIDE", objEntidad.FECIDE)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_FECHARECEPCION_LIQUIDACION_GASTOS", objParam)
            objEntidad.NLQGST = objSql.ParameterCollection("PONNLQGST")
            retorno = 1
            'Catch ex As Exception
            '    objEntidad.NLQGST = 0
            'End Try
            'Return objEntidad
            Return retorno
        End Function

        Public Function Registrar_Gasto_Combustible(ByVal objEntidad As LiquidacionGastos) As LiquidacionGastos
            Try
                Dim objParam As New Parameter

                objParam.Add("PNNLQGST", objEntidad.NLQGST)
                objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
                objParam.Add("PNNVLRNS", objEntidad.NVLRNS)
                objParam.Add("PNNVLGRF", objEntidad.NVLGRF)
                objParam.Add("PNCGRFO", objEntidad.CGRFO)

                objParam.Add("PNQGLNCM", objEntidad.QGLNCM)
                objParam.Add("PNFCRCMB", objEntidad.FCRCMB)
                objParam.Add("PNCTPCMB", objEntidad.CTPCMB)
                objParam.Add("PNNKMRCR", objEntidad.NKMRCR)
                objParam.Add("PNICSTOS", objEntidad.ICSTOS)
                objParam.Add("PNIVNTAS", objEntidad.IVNTAS)
                objParam.Add("PSCULUSA", objEntidad.CULUSA)
                objParam.Add("PNFULTAC", objEntidad.FULTAC)
                objParam.Add("PNHULTAC", objEntidad.HULTAC)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_GASTO_COMBUSTIBLE", objParam)
            Catch ex As Exception
                objEntidad.NLQGST = 0
            End Try
            Return objEntidad
        End Function

        Public Function Modificar_Gasto_Combustible(ByVal objEntidad As LiquidacionGastos) As LiquidacionGastos
            Try
                Dim objParam As New Parameter
                objParam.Add("PNNLQGST", objEntidad.NLQGST)
                objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
                objParam.Add("PNNVLRNS", objEntidad.NVLRNS)
                objParam.Add("PNNVLGRF", objEntidad.NVLGRF)
                objParam.Add("PNCGRFO", objEntidad.CGRFO)
                objParam.Add("PNFCRCMB", objEntidad.FCRCMB)
                objParam.Add("PNQGLNCM", objEntidad.QGLNCM)
                objParam.Add("PSCTPCMB", objEntidad.CTPCMB)
                objParam.Add("PNNKMRCR", objEntidad.NKMRCR)
                objParam.Add("PNICSTOS", objEntidad.ICSTOS)
                objParam.Add("PNIVNTAS", objEntidad.IVNTAS)
                objParam.Add("PSCULUSA", objEntidad.CULUSA)
                objParam.Add("PNFULTAC", objEntidad.FULTAC)
                objParam.Add("PNHULTAC", objEntidad.HULTAC)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_GASTO_COMBUSTIBLE", objParam)
            Catch ex As Exception
                objEntidad.NLQGST = 0
            End Try
            Return objEntidad
        End Function

        Public Function Eliminar_Gasto_Ruta_Operacion(ByVal objEntidad As LiquidacionGastos) As LiquidacionGastos
            Try
                Dim objParam As New Parameter

                objParam.Add("PNNLQGST", objEntidad.NLQGST)
                objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
                objParam.Add("PNNCRRRT", objEntidad.NCRRRT)

                objParam.Add("PNCGSTOS", objEntidad.CGSTOS)
                'objParam.Add("PNIGSTOS", objEntidad.IGSTOS)
                objParam.Add("PNIGSTOS", objEntidad.NCRRGT)
                objParam.Add("PNNCTAVC", objEntidad.NCTAVC)

                objParam.Add("PSCULUSA", objEntidad.CULUSA)
                objParam.Add("PNFULTAC", objEntidad.FULTAC)
                objParam.Add("PNHULTAC", objEntidad.HULTAC)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_GASTO_OPERACION_RUTA", objParam)
            Catch ex As Exception
                objEntidad.NLQGST = 0
            End Try
            Return objEntidad
        End Function

        Public Function Eliminar_Gasto_Combustible(ByVal objEntidad As LiquidacionGastos) As LiquidacionGastos
            Try
                Dim objParam As New Parameter
                objParam.Add("PNNLQGST", objEntidad.NLQGST)
                objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
                objParam.Add("PNNVLRNS", objEntidad.NVLRNS)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_GASTO_COMBUSTIBLE", objParam)
            Catch ex As Exception
                objEntidad.NLQGST = 0
            End Try
            Return objEntidad
        End Function

        Public Function Listar_Gasto_Ruta_Operacion(ByVal objetoParametro As Hashtable) As List(Of LiquidacionGastos)
            Dim objDataTable As New DataTable
            Dim objDatos As LiquidacionGastos
            Dim objGenericCollection As New List(Of LiquidacionGastos)
            Dim objParam As New Parameter
            'Try
            objParam.Add("PNNLQGST", objetoParametro("PNNLQGST"))
            objParam.Add("PNNOPRCN", objetoParametro("PNNOPRCN"))
            objParam.Add("PNNCRRRT", objetoParametro("PNNCRRRT"))
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GASTO_OPERACION_RUTA", objParam)
            For Each objDataRow As DataRow In objDataTable.Rows
                objDatos = New LiquidacionGastos
                objDatos.NLQGST = objDataRow("NLQGST")
                objDatos.NOPRCN = objDataRow("NOPRCN")
                objDatos.NCRRRT = objDataRow("NCRRRT")
                objDatos.CGSTOS = objDataRow("CGSTOS")
                objDatos.TGSTOS = objDataRow("TGSTOS").ToString.Trim
                objDatos.CDMNDA = objDataRow("CDMNDA")
                objDatos.TMNDA = objDataRow("TMNDA").ToString.Trim
                objDatos.IGSTOS = objDataRow("IGSTOS")
                objDatos.TOBDCT = objDataRow("TOBDCT").ToString.Trim
                objDatos.NCTAVC = objDataRow("NCTAVC").ToString.Trim
                objDatos.TIPO = objDataRow("TIPO").ToString.Trim
                objDatos.FECINI = HelpClass.FechaNum_a_Fecha(objDataRow("FECINI"))
                objDatos.FECFIN = HelpClass.FechaNum_a_Fecha(objDataRow("FECFIN"))
                objDatos.NCRRGT = objDataRow("NCRRGT").ToString.Trim 'ECM-HUNDRED-(TEP-000001-SOLMIN LIQUIDACION DE GASTOS)
                objGenericCollection.Add(objDatos)
            Next
            'Catch : End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Gasto_Combustible(ByVal objetoParametro As Hashtable) As List(Of LiquidacionGastos)
            Dim objDataTable As New DataTable
            Dim objDatos As LiquidacionGastos
            Dim objGenericCollection As New List(Of LiquidacionGastos)
            Dim objParam As New Parameter
            'Try
            objParam.Add("PNNLQGST", objetoParametro("PNNLQGST"))
            objParam.Add("PNNOPRCN", objetoParametro("PNNOPRCN"))
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_GASTO_COMBUSTIBLE", objParam)
            For Each objDataRow As DataRow In objDataTable.Rows
                objDatos = New LiquidacionGastos
                objDatos.NLQGST = objDataRow("NLQGST")
                objDatos.NOPRCN = objDataRow("NOPRCN")
                objDatos.NVLRNS = objDataRow("NVLRNS")
                objDatos.NVLGRF = objDataRow("NVLGRF")
                objDatos.CGRFO = objDataRow("CGRFO")
                objDatos.TGRFO = objDataRow("TGRFO").ToString.Trim
                objDatos.TGRIFO = objDataRow("TGRIFO").ToString.Trim
                objDatos.FCRCMB_S = objDataRow("FCRCMB_S").ToString.Trim
                objDatos.QGLNCM = objDataRow("QGLNCM")
                objDatos.CTPCMB = objDataRow("CTPCMB").ToString.Trim
                objDatos.TDSCMB = objDataRow("TDSCMB").ToString.Trim
                objDatos.NKMRCR = objDataRow("NKMRCR")
                objDatos.ICSTOS = objDataRow("ICSTOS")
                objDatos.IVNTAS = objDataRow("IVNTAS")
                objDatos.NRSCVL = objDataRow("NRSCVL")
                objGenericCollection.Add(objDatos)
            Next
            'Catch : End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Gastos() As List(Of ClaseGeneral)
            Dim objDataTable As New DataTable
            Dim objDatos As ClaseGeneral
            Dim objGenericCollection As New List(Of ClaseGeneral)
            Dim objParam As New Parameter
            'Try
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_GASTO_CHOFERES", Nothing)
            For Each objDataRow As DataRow In objDataTable.Rows
                objDatos = New ClaseGeneral
                objDatos.CGSTOS = objDataRow("CGSTOS")
                objDatos.TGSTOS = objDataRow("TGSTOS").ToString.Trim
                objDatos.TAUTR = objDataRow("TAUTR")
                objDatos.TIPO = objDataRow("TIPO").ToString.Trim
                objGenericCollection.Add(objDatos)
            Next
            'Catch : End Try
            Return objGenericCollection
        End Function

        Public Function Cerrar_Lquidacion(ByVal objEntidad As LiquidacionGastos) As Decimal
            'Try
            Dim retorno As Decimal = 0
            Dim objParam As New Parameter
            objParam.Add("PON_NLQGST", objEntidad.NLQGST, ParameterDirection.Output)
            objParam.Add("PSUSRCRR", objEntidad.USRCRR)
            objParam.Add("PNFCHCRR", objEntidad.FCHCRR)
            objParam.Add("PNHRACRR", objEntidad.HRACRR)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_CERRAR_LIQUIDACION", objParam)
            retorno = objSql.ParameterCollection("PON_NLQGST")
            'Catch ex As Exception
            '    objEntidad.NLQGST = 0
            'End Try
            Return retorno
        End Function

        Public Function Lista_AVC_x_Tracto(ByVal objetoParametro As Hashtable) As List(Of ClaseGeneral)
            Dim objDataTable As New DataTable
            Dim objDatos As ClaseGeneral
            Dim objGenericCollection As New List(Of ClaseGeneral)
            Dim objParam As New Parameter
            'Try
            objParam.Add("PSNPLCUN", objetoParametro("PSNPLCUN"))
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_AVC_x_TRACTO", objParam)
            For Each objDataRow As DataRow In objDataTable.Rows
                objDatos = New ClaseGeneral
                objDatos.NCTAVC = objDataRow("NCTAVC")
                objDatos.NOPRCN = objDataRow("NOPRCN")
                objDatos.NPLCUN = objDataRow("NPLCUN").ToString.Trim
                objDatos.CBRCNT = objDataRow("CBRCNT").ToString.Trim
                objDatos.CBRCND = objDataRow("CBRCND").ToString.Trim
                objDatos.IRTAVC = objDataRow("IRTAVC")
                objDatos.IARAVC = objDataRow("IARAVC")

                objGenericCollection.Add(objDatos)
            Next
            'Catch : End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Detalle_Liquidacion_Gasto(ByVal objetoParametro As Hashtable) As DataSet
            Dim objDataSet As New DataSet
            Dim objParam As New Parameter
            'Try
            objParam.Add("PNNLQGST", objetoParametro("PNNLQGST"))
            objParam.Add("PNCTRSPT", objetoParametro("PNCTRSPT"))
            objParam.Add("PSNPLCUN", objetoParametro("PSNPLCUN"))
            objParam.Add("PSCBRCNT", objetoParametro("PSCBRCNT"))
            objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_LISTAR_DETALLE_LIQUIDACION_GASTO", objParam)
            For Each Item As DataRow In objDataSet.Tables(0).Rows
                Item("FCHCRT_S") = HelpClass.FechaNum_a_Fecha(Item("FCHCRT_S"))
                Item("FCHCRR_S") = HelpClass.FechaNum_a_Fecha(Item("FCHCRR_S"))
                Item("FSLDCM_S") = HelpClass.FechaNum_a_Fecha(Item("FSLDCM_S"))
                Item("FLLGCM_S") = HelpClass.FechaNum_a_Fecha(Item("FLLGCM_S"))
                Item("FECIDE") = HelpClass.FechaNum_a_Fecha(Item("FECIDE"))
            Next
            For Each Item As DataRow In objDataSet.Tables(1).Rows
                Item("FECINI") = HelpClass.FechaNum_a_Fecha(Item("FECINI"))
                Item("FECFIN") = HelpClass.FechaNum_a_Fecha(Item("FECFIN"))
            Next
            For Each Item As DataRow In objDataSet.Tables(2).Rows
                Item("FCRCMB_S") = HelpClass.FechaNum_a_Fecha(Item("FCRCMB_S"))
            Next
            For Each Item As DataRow In objDataSet.Tables(4).Rows
                Item("FINAVC") = HelpClass.FechaNum_a_Fecha(Item("FINAVC"))
            Next
            'Catch : End Try
            Return objDataSet
        End Function

        Public Function Listar_Liquidacion_Gasto_Detalle(ByVal objetoParametro As Hashtable) As DataTable
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            Dim oDt As New DataTable
            Dim NewRows As DataRow
            CrearTablaReporteExcel(oDt)
            'Try
            objParam.Add("PNNLQGST", objetoParametro("PNNLQGST"))
            objParam.Add("PSNPLCUN", objetoParametro("PSNPLCUN"))
            objParam.Add("PSCBRCNT", objetoParametro("PSCBRCNT"))
            objParam.Add("PNFECINI", objetoParametro("PNFECINI"))
            objParam.Add("PNFECFIN", objetoParametro("PNFECFIN"))
            objParam.Add("PSSESTRG", objetoParametro("PSSESTRG"))
            objParam.Add("PSUSRCRT", objetoParametro("PSUSRCRT"))
            objParam.Add("PSUSRCRR", objetoParametro("PSUSRCRR"))

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_LIQUIDACION_GASTOS_DETALLE_1", objParam)
            For i As Integer = 0 To objDataTable.Rows.Count - 1
                NewRows = oDt.NewRow
                NewRows("NLQGST") = objDataTable.Rows(i).Item("NLQGST").ToString.Trim

                NewRows("FECIDE") = HelpClass.FechaNum_a_Fecha(objDataTable.Rows(i).Item("FECIDE"))

                NewRows("NPLCUN") = objDataTable.Rows(i).Item("NPLCUN")
                NewRows("NPLCAC") = objDataTable.Rows(i).Item("NPLCAC")
                NewRows("CBRCNT") = objDataTable.Rows(i).Item("CBRCNT")
                NewRows("CBRCND") = objDataTable.Rows(i).Item("CBRCND")
                NewRows("SESTRG") = objDataTable.Rows(i).Item("SESTRG")
                NewRows("USRCRT") = objDataTable.Rows(i).Item("USRCRT")
                'NewRows("FCHCRT") = HelpClass.CFecha_de_8_a_10(objDataTable.Rows(i).Item("FCHCRT"))
                NewRows("FCHCRT") = HelpClass.FechaNum_a_Fecha(objDataTable.Rows(i).Item("FCHCRT"))

                NewRows("HRACRT") = " " & HelpClass.HoraNum_a_Hora(objDataTable.Rows(i).Item("HRACRT")) & " "
                NewRows("USRCRR") = IIf(objDataTable.Rows(i).Item("USRCRR").ToString.Trim = "", "", objDataTable.Rows(i).Item("USRCRR").ToString.Trim)
                NewRows("FCHCRR") = IIf(objDataTable.Rows(i).Item("USRCRR").ToString.Trim = "", "", HelpClass.FechaNum_a_Fecha(objDataTable.Rows(i).Item("FCHCRR")).ToString.Trim)
                NewRows("HRACRR") = IIf(objDataTable.Rows(i).Item("USRCRR").ToString.Trim = "", "", " " & HelpClass.HoraNum_a_Hora(objDataTable.Rows(i).Item("HRACRR")) & " ")
                'NewRows("USER_CREACION") = objDataTable.Rows(i).Item("USER_CREACION")
                'NewRows("USER_LIQUIDADOR") = objDataTable.Rows(i).Item("USER_LIQUIDADOR")
                NewRows("NOPRCN") = objDataTable.Rows(i).Item("NOPRCN")
                Dim lstr_TOBS() As String
                lstr_TOBS = objDataTable.Rows(i).Item("TOBS").ToString.Trim.Split("|")
                'NewRows("CCLNT") = lstr_TOBS(0)
                NewRows("TCMPCL") = lstr_TOBS(1)
                'NewRows("NPLNMT") = lstr_TOBS(3)
                NewRows("TCNTCS") = objDataTable.Rows(i).Item("TCNTCS")
                NewRows("TDSCAR") = objDataTable.Rows(i).Item("TDSCAR")
                NewRows("TLGRSL") = objDataTable.Rows(i).Item("TLGRSL")
                NewRows("TLGRLL") = objDataTable.Rows(i).Item("TLGRLL")
                NewRows("FSLDCM") = HelpClass.FechaNum_a_Fecha(objDataTable.Rows(i).Item("FSLDCM"))
                NewRows("TGSTOS") = objDataTable.Rows(i).Item("TGSTOS")

                'If ("" & objDataTable.Rows(i).Item("SSTGSP")).ToString.Trim = "X" Then
                '    NewRows("PLANILLA") = objDataTable.Rows(i).Item("IGSTOS")
                '    NewRows("SPEFECTIVO") = DBNull.Value
                'Else
                '    NewRows("PLANILLA") = DBNull.Value
                '    NewRows("SPEFECTIVO") = objDataTable.Rows(i).Item("IGSTOS")
                'End If

                NewRows("IGSTOS") = objDataTable.Rows(i).Item("IGSTOS")
                NewRows("TMNDA") = objDataTable.Rows(i).Item("TMNDA")
                NewRows("TOBDCT") = objDataTable.Rows(i).Item("TOBDCT")

                NewRows("FECINI") = HelpClass.FechaNum_a_Fecha(objDataTable.Rows(i).Item("FECINI"))
                NewRows("FECFIN") = HelpClass.FechaNum_a_Fecha(objDataTable.Rows(i).Item("FECFIN"))

                NewRows("NCTAVC") = objDataTable.Rows(i).Item("NCTAVC")
                oDt.Rows.Add(NewRows)
            Next
            'Catch : End Try
            Return oDt
        End Function

        Public Function Listar_Liquidacion_Gasto_Detalle_V2(ByVal objetoParametro As Hashtable) As DataTable
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            Dim oDt As New DataTable
            'Dim NewRows As DataRow
            'CrearTablaReporteExcel(oDt)
            'Try
            objParam.Add("PNNLQGST", objetoParametro("PNNLQGST"))
            objParam.Add("PSNPLCUN", objetoParametro("PSNPLCUN"))
            objParam.Add("PSCBRCNT", objetoParametro("PSCBRCNT"))
            objParam.Add("PNFECINI", objetoParametro("PNFECINI"))
            objParam.Add("PNFECFIN", objetoParametro("PNFECFIN"))
            objParam.Add("PSSESTRG", objetoParametro("PSSESTRG"))
            objParam.Add("PSUSRCRT", objetoParametro("PSUSRCRT"))
            objParam.Add("PSUSRCRR", objetoParametro("PSUSRCRR"))

            oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_LIQUIDACION_GASTOS_DETALLE_1", objParam)
            oDt.Columns.Add("TCMPCL")
            For Each Item As DataRow In oDt.Rows
                'Item("NLQGST") = Item("NLQGST").ToString.Trim
                Item("FECIDE") = HelpClass.FechaNum_a_Fecha(Item("FECIDE"))
                'Item("NPLCUN") = Item("NPLCUN")
                'Item("NPLCAC") = Item("NPLCAC")
                'Item("CBRCNT") = Item("CBRCNT")
                'Item("CBRCND") = Item("CBRCND")
                'Item("SESTRG") = Item("SESTRG")
                'Item("USRCRT") = Item("USRCRT")
                Item("FCHCRT") = HelpClass.FechaNum_a_Fecha(Item("FCHCRT"))
                Item("HRACRT") = " " & HelpClass.HoraNum_a_Hora(Item("HRACRT")) & " "
                Item("USRCRR") = IIf(Item("USRCRR").ToString.Trim = "", "", Item("USRCRR").ToString.Trim)
                Item("FCHCRR") = IIf(Item("USRCRR").ToString.Trim = "", "", HelpClass.FechaNum_a_Fecha(Item("FCHCRR")).ToString.Trim)
                Item("HRACRR") = IIf(Item("USRCRR").ToString.Trim = "", "", " " & HelpClass.HoraNum_a_Hora(Item("HRACRR")) & " ")
                'Item("NOPRCN") = Item("NOPRCN")
                Dim lstr_TOBS() As String
                lstr_TOBS = Item("TOBS").ToString.Trim.Split("|")
                Item("TCMPCL") = lstr_TOBS(1)
                'Item("TCNTCS") = Item("TCNTCS")
                'Item("TDSCAR") = Item("TDSCAR")
                'Item("TLGRSL") = Item("TLGRSL")
                'Item("TLGRLL") = Item("TLGRLL")
                Item("FSLDCM") = HelpClass.FechaNum_a_Fecha(Item("FSLDCM"))
                'Item("TGSTOS") = Item("TGSTOS")
                'Item("IGSTOS") = Item("IGSTOS")
                'Item("TMNDA") = Item("TMNDA")
                'Item("TOBDCT") = Item("TOBDCT")
                Item("FECINI") = HelpClass.FechaNum_a_Fecha(Item("FECINI"))
                Item("FECFIN") = HelpClass.FechaNum_a_Fecha(Item("FECFIN"))
                Item("CODIGOSAP") = ("" & Item("CODIGOSAP")).ToString.Trim
                'Item("NCTAVC") = Item("NCTAVC")
            Next

            'For i As Integer = 0 To oDt.Rows.Count - 1
            '    '  NewRows = oDt.NewRow
            '    NewRows("NLQGST") = objDataTable.Rows(i).Item("NLQGST").ToString.Trim

            '    NewRows("FECIDE") = HelpClass.FechaNum_a_Fecha(objDataTable.Rows(i).Item("FECIDE"))

            '    NewRows("NPLCUN") = objDataTable.Rows(i).Item("NPLCUN")
            '    NewRows("NPLCAC") = objDataTable.Rows(i).Item("NPLCAC")
            '    NewRows("CBRCNT") = objDataTable.Rows(i).Item("CBRCNT")
            '    NewRows("CBRCND") = objDataTable.Rows(i).Item("CBRCND")
            '    NewRows("SESTRG") = objDataTable.Rows(i).Item("SESTRG")
            '    NewRows("USRCRT") = objDataTable.Rows(i).Item("USRCRT")
            '    'NewRows("FCHCRT") = HelpClass.CFecha_de_8_a_10(objDataTable.Rows(i).Item("FCHCRT"))
            '    NewRows("FCHCRT") = HelpClass.FechaNum_a_Fecha(objDataTable.Rows(i).Item("FCHCRT"))

            '    NewRows("HRACRT") = " " & HelpClass.HoraNum_a_Hora(objDataTable.Rows(i).Item("HRACRT")) & " "
            '    NewRows("USRCRR") = IIf(objDataTable.Rows(i).Item("USRCRR").ToString.Trim = "", "", objDataTable.Rows(i).Item("USRCRR").ToString.Trim)
            '    NewRows("FCHCRR") = IIf(objDataTable.Rows(i).Item("USRCRR").ToString.Trim = "", "", HelpClass.FechaNum_a_Fecha(objDataTable.Rows(i).Item("FCHCRR")).ToString.Trim)
            '    NewRows("HRACRR") = IIf(objDataTable.Rows(i).Item("USRCRR").ToString.Trim = "", "", " " & HelpClass.HoraNum_a_Hora(objDataTable.Rows(i).Item("HRACRR")) & " ")
            '    'NewRows("USER_CREACION") = objDataTable.Rows(i).Item("USER_CREACION")
            '    'NewRows("USER_LIQUIDADOR") = objDataTable.Rows(i).Item("USER_LIQUIDADOR")
            '    NewRows("NOPRCN") = objDataTable.Rows(i).Item("NOPRCN")
            '    Dim lstr_TOBS() As String
            '    lstr_TOBS = objDataTable.Rows(i).Item("TOBS").ToString.Trim.Split("|")
            '    'NewRows("CCLNT") = lstr_TOBS(0)
            '    NewRows("TCMPCL") = lstr_TOBS(1)
            '    'NewRows("NPLNMT") = lstr_TOBS(3)
            '    NewRows("TCNTCS") = objDataTable.Rows(i).Item("TCNTCS")
            '    NewRows("TDSCAR") = objDataTable.Rows(i).Item("TDSCAR")
            '    NewRows("TLGRSL") = objDataTable.Rows(i).Item("TLGRSL")
            '    NewRows("TLGRLL") = objDataTable.Rows(i).Item("TLGRLL")
            '    NewRows("FSLDCM") = HelpClass.FechaNum_a_Fecha(objDataTable.Rows(i).Item("FSLDCM"))
            '    NewRows("TGSTOS") = objDataTable.Rows(i).Item("TGSTOS")

            '    'If ("" & objDataTable.Rows(i).Item("SSTGSP")).ToString.Trim = "X" Then
            '    '    NewRows("PLANILLA") = objDataTable.Rows(i).Item("IGSTOS")
            '    '    NewRows("SPEFECTIVO") = DBNull.Value
            '    'Else
            '    '    NewRows("PLANILLA") = DBNull.Value
            '    '    NewRows("SPEFECTIVO") = objDataTable.Rows(i).Item("IGSTOS")
            '    'End If

            '    NewRows("IGSTOS") = objDataTable.Rows(i).Item("IGSTOS")
            '    NewRows("TMNDA") = objDataTable.Rows(i).Item("TMNDA")
            '    NewRows("TOBDCT") = objDataTable.Rows(i).Item("TOBDCT")

            '    NewRows("FECINI") = HelpClass.FechaNum_a_Fecha(objDataTable.Rows(i).Item("FECINI"))
            '    NewRows("FECFIN") = HelpClass.FechaNum_a_Fecha(objDataTable.Rows(i).Item("FECFIN"))

            '    NewRows("NCTAVC") = objDataTable.Rows(i).Item("NCTAVC")
            '    oDt.Rows.Add(NewRows)
            'Next
            'Catch : End Try
            Return oDt
        End Function


        Private Sub CrearTablaReporteExcel(ByVal oDt As DataTable)
            oDt.Columns.Add(New DataColumn("NLQGST", GetType(System.String)))

            oDt.Columns.Add(New DataColumn("FECIDE", GetType(System.String)))

            oDt.Columns.Add(New DataColumn("NPLCUN", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("NPLCAC", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("CBRCNT", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("CBRCND", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("SESTRG", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("USRCRT", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("FCHCRT", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("HRACRT", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("USRCRR", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("FCHCRR", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("HRACRR", GetType(System.String)))
            'oDt.Columns.Add(New DataColumn("USER_CREACION", GetType(System.String)))
            'oDt.Columns.Add(New DataColumn("USER_LIQUIDADOR", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("NOPRCN", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("TCMPCL", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("TCNTCS", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("TDSCAR", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("TLGRSL", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("TLGRLL", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("FSLDCM", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("TGSTOS", GetType(System.String)))

            'oDt.Columns.Add(New DataColumn("PLANILLA", GetType(System.Double)))
            'oDt.Columns.Add(New DataColumn("SPEFECTIVO", GetType(System.Double)))

            oDt.Columns.Add(New DataColumn("IGSTOS", GetType(System.Double)))
            oDt.Columns.Add(New DataColumn("TMNDA", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("TOBDCT", GetType(System.String)))

            oDt.Columns.Add(New DataColumn("FECINI", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("FECFIN", GetType(System.String)))

            oDt.Columns.Add(New DataColumn("NCTAVC", GetType(System.String)))


        End Sub

    End Class
End Namespace

