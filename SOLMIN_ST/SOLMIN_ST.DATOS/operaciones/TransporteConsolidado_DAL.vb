Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST

Public Class TransporteConsolidado_DAL
    Private objSql As New SqlManager

    Public Function Listar_Transporte_Consolidado(ByVal objEntidad As TransporteConsolidado) As List(Of TransporteConsolidado)
        Dim oDt As New DataTable
        Dim objetoEntidad As TransporteConsolidado
        Dim olbeTransporteConsolidado As New List(Of TransporteConsolidado)
        Dim objParam As New Parameter
        'Try
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PSCDVSN", objEntidad.CDVSN)
        objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
        objParam.Add("PNNMVJCS", objEntidad.NMVJCS)
        objParam.Add("PNFECINI", objEntidad.FCHINI)
        objParam.Add("PNFECFIN", objEntidad.FCHFIN)
        objParam.Add("PNCTRSPT", objEntidad.CTRSPT)
        objParam.Add("PSFLGSTS ", objEntidad.FLGSTS)
        objParam.Add("PNNOPRCN ", objEntidad.NOPRCN)
        'If Not objEntidad.NOPRCN = 0 Then
        '    objParam.Add("PNNOPRCN ", objEntidad.NOPRCN)
        'End If
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        'oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TRANSPORTE_CONSOLIDADO", objParam)
        oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TRANSPORTE_CONSOLIDADO_V2", objParam)
        For Each objDataRow As DataRow In oDt.Rows
            objetoEntidad = New TransporteConsolidado
            objetoEntidad.NMVJCS = objDataRow("NMVJCS").ToString.Trim 'NUMERO VIAJE CONSOLIDADO
            objetoEntidad.FCHVJC_S = Validacion.CFecha_a_Numero10Digitos(objDataRow("FCHVJC").ToString.Trim) 'FECHA DE VIAJE
            objetoEntidad.Ruta = objDataRow("RUTA").ToString.Trim 'RUTA
            objetoEntidad.TCMTRT = objDataRow("TCMTRT").ToString.Trim
            objetoEntidad.NPLCUN = objDataRow("NPLCUN").ToString.Trim 'TRACTO 
            objetoEntidad.NPLCAC = objDataRow("NPLCAC").ToString.Trim 'ACOPLADO
            objetoEntidad.CBRCND = objDataRow("CBRCND").ToString.Trim 'ACOPLADO
            objetoEntidad.TNMMDT = objDataRow("TNMMDT").ToString.Trim
            objetoEntidad.PMRCMC = objDataRow("PMRCMC").ToString.Trim
            objetoEntidad.QPSOBR = objDataRow("QPSOBR").ToString.Trim
            objetoEntidad.PSOVOL = objDataRow("PSOVOL").ToString.Trim
            objetoEntidad.TOBRCP = objDataRow("TOBRCP").ToString.Trim
            objetoEntidad.FLGSTS = objDataRow("FLGSTS").ToString.Trim
            objetoEntidad.CLCLOR = objDataRow("CLCLOR").ToString.Trim
            objetoEntidad.CLCLDS = objDataRow("CLCLDS").ToString.Trim
            objetoEntidad.CMEDTR = objDataRow("CMEDTR").ToString.Trim
            objetoEntidad.CTRSPT = objDataRow("CTRSPT").ToString.Trim
            objetoEntidad.CBRCNT = objDataRow("CBRCNT").ToString.Trim
            objetoEntidad.NRUCTR = objDataRow("NRUCTR").ToString.Trim

            olbeTransporteConsolidado.Add(objetoEntidad)
        Next
        'Catch ex As Exception
        '    olbeTransporteConsolidado = New List(Of TransporteConsolidado)
        'End Try
        Return olbeTransporteConsolidado
    End Function
    Public Function Registrar_Transporte_Consilidado(ByVal objEntidad As TransporteConsolidado) As TransporteConsolidado
        Dim mensaje As String = ""
        'Dim objTranporte As New TransporteConsolidado
        Try
            Dim objParam As New Parameter

            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PNNMVJCS", objEntidad.NMVJCS, ParameterDirection.Output)
            objParam.Add("PNFCHVJC", objEntidad.FCHVJC)
            objParam.Add("PNCTRSPT", objEntidad.CTRSPT)
            objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
            objParam.Add("PSNPLCAC", objEntidad.NPLCAC)
            objParam.Add("PNCLCLOR", objEntidad.CLCLOR)
            objParam.Add("PNCLCLDS", objEntidad.CLCLDS)
            objParam.Add("PNCMEDTR", objEntidad.CMEDTR)
            objParam.Add("PSTOBRCP", objEntidad.TOBRCP)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
            objParam.Add("PSFLGSTS", objEntidad.FLGSTS)
            objParam.Add("PSSESTRG", objEntidad.SESTRG)
            objParam.Add("PSCUSCTR", objEntidad.CUSCTR)
            objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
            objParam.Add("PNHRACRT", objEntidad.HRACRT)
            objParam.Add("PSNTRMCR", objEntidad.NTRMCR)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_TRANSPORTE_CONSOLIDADO", objParam)
            objEntidad.NMVJCS = objSql.ParameterCollection("PNNMVJCS")
        Catch ex As Exception
            objEntidad.NMVJCS = 0
        End Try
        Return objEntidad
    End Function

    Public Function Modificar_Transporte_Consilidado(ByVal objEntidad As TransporteConsolidado) As String
        Dim mensaje As String = ""
        Try
            Dim objParam As New Parameter

            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PNNMVJCS", objEntidad.NMVJCS)
            objParam.Add("PNFCHVJC", objEntidad.FCHVJC)
            objParam.Add("PNCTRSPT", objEntidad.CTRSPT)
            objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
            objParam.Add("PSNPLCAC", objEntidad.NPLCAC)
            objParam.Add("PNCLCLOR", objEntidad.CLCLOR)
            objParam.Add("PNCLCLDS", objEntidad.CLCLDS)
            objParam.Add("PNCMEDTR", objEntidad.CMEDTR)
            objParam.Add("PSTOBRCP", objEntidad.TOBRCP)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PSRESULT", "", ParameterDirection.Output)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_TRANSPORTE_CONSOLIDADO", objParam)
            mensaje = objSql.ParameterCollection("PSRESULT").ToString
        Catch ex As Exception
            mensaje = ex.Message
        End Try
        Return mensaje
    End Function

    Public Function Eliminar_Transporte_Consolidado(ByVal objEntidad As TransporteConsolidado) As String
        Dim mensaje As String = ""
        Try
            Dim objParam As New Parameter

            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PNNMVJCS", objEntidad.NMVJCS)
            objParam.Add("PSRESULT", "", ParameterDirection.Output)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_TRANSPORTE_CONSOLIDADO", objParam)
            mensaje = objSql.ParameterCollection("PSRESULT").ToString.Trim
        Catch ex As Exception
            mensaje = ex.Message
        End Try
        Return mensaje
    End Function

    Public Function Registrar_Solicitud_Transporte_Consolidado(ByVal objEntidad As TransporteConsolidado) As TransporteConsolidado
        Try
            Dim objParam As New Parameter
            objParam.Add("PARAM_NCSOTR", objEntidad.NCSOTR, ParameterDirection.Output)
            objParam.Add("PARAM_NORSRT", objEntidad.NORSRT)
            objParam.Add("PARAM_FECOST", objEntidad.FECOST)
            objParam.Add("PARAM_HRAOTR", objEntidad.HRAOTR)
            objParam.Add("PARAM_CCLNT", objEntidad.CCLNT)
            objParam.Add("PARAM_CTPOSR", objEntidad.CTPOSR)
            objParam.Add("PARAM_CUNDVH", objEntidad.CUNDVH)
            objParam.Add("PARAM_CMRCDR", objEntidad.CMRCDR)
            objParam.Add("PARAM_QMRCDR", objEntidad.QMRCDR)
            objParam.Add("PARAM_CUNDMD", objEntidad.CUNDMD)
            objParam.Add("PARAM_QSLCIT", objEntidad.QSLCIT)
            objParam.Add("PARAM_QATNAN", objEntidad.QATNAN)
            objParam.Add("PARAM_FINCRG", objEntidad.FINCRG)
            objParam.Add("PARAM_HINCIN", objEntidad.HINCIN)
            objParam.Add("PARAM_FENTCL", objEntidad.FENTCL)
            objParam.Add("PARAM_HRAENT", objEntidad.HRAENT)
            objParam.Add("PARAM_CLCLOR", objEntidad.CLCLOR)
            objParam.Add("PARAM_TDRCOR", objEntidad.TDRCOR)
            objParam.Add("PARAM_CLCLDS", objEntidad.CLCLDS)
            objParam.Add("PARAM_TDRENT", objEntidad.TDRENT)
            objParam.Add("PARAM_SESTRG", objEntidad.SESTRG)
            objParam.Add("PARAM_CUSCRT", objEntidad.CUSCRT)
            objParam.Add("PARAM_FCHCRT", objEntidad.FCHCRT)
            objParam.Add("PARAM_HRACRT", objEntidad.HRACRT)
            objParam.Add("PARAM_NTRMCR", objEntidad.NTRMCR)
            objParam.Add("PARAM_CULUSA", objEntidad.CULUSA)
            objParam.Add("PARAM_FULTAC", objEntidad.FULTAC)
            objParam.Add("PARAM_HULTAC", objEntidad.HULTAC)
            objParam.Add("PARAM_NTRMNL", objEntidad.NTRMNL)
            objParam.Add("PARAM_TOBS", objEntidad.TOBS)
            objParam.Add("PARAM_CCMPN", objEntidad.CCMPN)
            objParam.Add("PARAM_CDVSN", objEntidad.CDVSN)
            objParam.Add("PARAM_CPLNDV", objEntidad.CPLNDV)
            objParam.Add("PARAM_SFCRTV", objEntidad.SFCRTV)
            'OJO FALTA AGREGAR EN PRODUCCION
            objParam.Add("PARAM_NMOPMM", objEntidad.NMOPMM)
            objParam.Add("PARAM_NMOPRP", objEntidad.NMOPRP)
            objParam.Add("PARAM_CMEDTR", objEntidad.CMEDTR)
            objParam.Add("PARAM_CCTCSC", objEntidad.CCTCSC)
            objParam.Add("PARAM_TRFRN", objEntidad.TRFRN)
            objParam.Add("PARAM_NMVJCS", objEntidad.NMVJCS)
            objParam.Add("PARAM_CBRCNT", objEntidad.CBRCNT)
            objParam.Add("PARAM_CTPOVJ", objEntidad.CTPOVJ)
            objParam.Add("PARAM_SPRSTR", objEntidad.SPRSTR)
            objParam.Add("PSCTTRAN", objEntidad.CTTRAN)
            objParam.Add("PSCTIPCG", objEntidad.CTIPCG)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            'ejecuta el procedimiento almacenado
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_SOLICITUD_TRANSPORTE_CONSOLIDADO_LM", objParam)
            'Si la operación finaliza correctamente, procede a obtener el
            'numero de la solicitud generado en el stored procedure
            objEntidad.NCSOTR = objSql.ParameterCollection("PARAM_NCSOTR").ToString()
        Catch ex As Exception
            'Caso ser erroneo el procedimiento, pasa a mostrar el numero cero
            'que indica que no ha podido realizar la operación
            objEntidad.NCSOTR = 0
        End Try
        Return objEntidad
    End Function

    Public Function Modificar_Solicitud_Transporte_Consolidado(ByVal objEntidad As TransporteConsolidado) As TransporteConsolidado
        Try
            Dim objParam As New Parameter
            objParam.Add("PARAM_NCSOTR", objEntidad.NCSOTR)
            objParam.Add("PARAM_NORSRT", objEntidad.NORSRT)
            objParam.Add("PARAM_FECOST", objEntidad.FECOST)
            objParam.Add("PARAM_HRAOTR", objEntidad.HRAOTR)
            objParam.Add("PARAM_CCLNT", objEntidad.CCLNT)
            objParam.Add("PARAM_CTPOSR", objEntidad.CTPOSR)
            objParam.Add("PARAM_CUNDVH", objEntidad.CUNDVH)
            objParam.Add("PARAM_CMRCDR", objEntidad.CMRCDR)
            objParam.Add("PARAM_QMRCDR", objEntidad.QMRCDR)
            objParam.Add("PARAM_CUNDMD", objEntidad.CUNDMD)
            objParam.Add("PARAM_QSLCIT", objEntidad.QSLCIT)

            objParam.Add("PARAM_FINCRG", objEntidad.FINCRG)
            objParam.Add("PARAM_HINCIN", objEntidad.HINCIN)
            objParam.Add("PARAM_FENTCL", objEntidad.FENTCL)
            objParam.Add("PARAM_HRAENT", objEntidad.HRAENT)
            objParam.Add("PARAM_CLCLOR", objEntidad.CLCLOR)
            objParam.Add("PARAM_TDRCOR", objEntidad.TDRCOR)
            objParam.Add("PARAM_CLCLDS", objEntidad.CLCLDS)
            objParam.Add("PARAM_TDRENT", objEntidad.TDRENT)
            objParam.Add("PARAM_CULUSA", objEntidad.CULUSA)
            'objParam.Add("PARAM_FULTAC", objEntidad.FULTAC)
            'objParam.Add("PARAM_HULTAC", objEntidad.HULTAC)
            objParam.Add("PARAM_NTRMNL", objEntidad.NTRMNL)
            objParam.Add("PARAM_TOBS", objEntidad.TOBS)
            objParam.Add("PARAM_SFCRTV", objEntidad.SFCRTV)
            objParam.Add("PARAM_CCMPN", objEntidad.CCMPN)
            objParam.Add("PARAM_CDVSN", objEntidad.CDVSN)
            objParam.Add("PARAM_CPLNDV", objEntidad.CPLNDV)
            objParam.Add("PARAM_CMEDTR", objEntidad.CMEDTR)
            objParam.Add("PARAM_CCTCSC", objEntidad.CCTCSC)
            objParam.Add("PARAM_TRFRN", objEntidad.TRFRN)
            objParam.Add("PARAM_SPRSTR", objEntidad.SPRSTR)
            objParam.Add("PSCTTRAN", objEntidad.CTTRAN)
            objParam.Add("PSCTIPCG", objEntidad.CTIPCG)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            'ejecuta el procedimiento almacenado
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_SOLICITUD_TRANSPORTE_1", objParam)
        Catch ex As Exception
            'Caso ser erroneo el procedimiento, pasa a mostrar el numero cero
            'que indica que no ha podido realizar la operación
            objEntidad.NCSOTR = 0
        End Try
        Return objEntidad
    End Function
    Public Function Obtener_Datos_Solicitud_Transporte(ByVal objEntidad As TransporteConsolidado) As TransporteConsolidado
        Dim objDataTable As New DataTable
        Dim objParam As New Parameter
        Try
            objParam.Add("PNNCSOTR", objEntidad.NCSOTR)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_OBTENER_SOLICITUD_TRANSPORTE", objParam)
            With objDataTable.Rows(0)
                objEntidad.FECOST = .Item("FECOST").ToString.Trim
                objEntidad.HRAOTR = .Item("HRAOTR").ToString.Trim
                objEntidad.CCLNT = .Item("CCLNT").ToString.Trim
                objEntidad.NORSRT = .Item("NORSRT").ToString.Trim
                objEntidad.CTPOSR = .Item("CTPOSR").ToString.Trim
                objEntidad.CUNDVH = .Item("CUNDVH").ToString.Trim
                objEntidad.CMRCDR = .Item("CMRCDR").ToString.Trim
                objEntidad.QMRCDR = .Item("QMRCDR").ToString.Trim
                objEntidad.CUNDMD = .Item("CUNDMD").ToString.Trim
                objEntidad.QSLCIT = CType(.Item("QSLCIT"), Integer).ToString
                objEntidad.QATNAN = CType(.Item("QATNAN"), Integer).ToString
                objEntidad.FINCRG = .Item("FINCRG").ToString.Trim
                objEntidad.HINCIN = .Item("HINCIN").ToString.Trim
                objEntidad.FENTCL = .Item("FENTCL").ToString.Trim
                objEntidad.HRAENT = .Item("HRAENT").ToString.Trim
                objEntidad.CLCLOR = .Item("CLCLOR").ToString.Trim
                objEntidad.TDRCOR = .Item("TDRCOR").ToString.Trim
                objEntidad.CLCLDS = .Item("CLCLDS").ToString.Trim
                objEntidad.TDRENT = .Item("TDRENT").ToString.Trim
                objEntidad.SESSLC = .Item("SESSLC").ToString.Trim
                objEntidad.CUSCRT = .Item("CUSCRT").ToString.Trim
                objEntidad.FCHCRT = .Item("FCHCRT").ToString.Trim
                objEntidad.HRACRT = .Item("HRACRT").ToString.Trim
                objEntidad.NTRMCR = .Item("NTRMCR").ToString.Trim
                objEntidad.CULUSA = .Item("CULUSA").ToString.Trim
                objEntidad.FULTAC = .Item("FULTAC").ToString.Trim
                objEntidad.HULTAC = .Item("HULTAC").ToString.Trim
                objEntidad.NTRMNL = .Item("NTRMNL").ToString.Trim
                objEntidad.TOBS = .Item("TOBS").ToString.Trim
                objEntidad.SFCRTV = .Item("SFCRTV").ToString.Trim
                objEntidad.CMEDTR = .Item("CMEDTR").ToString.Trim
                objEntidad.CCTCSC = .Item("CCTCSC").ToString.Trim
                objEntidad.TRFRN = .Item("TRFRN").ToString.Trim
            End With
        Catch ex As Exception
            objEntidad.NCSOTR = 0
        End Try
        Return objEntidad
    End Function
    Public Function Listar_Guia_Transportista(ByVal objetoParametro As Hashtable) As DataTable
        Dim objDataTable As New DataTable
        Dim objParam As New Parameter
        'Try

        objParam.Add("PSCCMPN", objetoParametro("PSCCMPN"))
        objParam.Add("PSCDVSN", objetoParametro("PSCDVSN"))
        objParam.Add("PNCPLNDV", objetoParametro("PNCPLNDV"))
        objParam.Add("PNNMVJCS", objetoParametro("PNNMVJCS"))
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("PSCCMPN"))

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_TRANSPORTISTA_X_OPERACION_VIAJE", objParam)

        'Catch ex As Exception
        '    Dim s As String = ""
        'End Try
        Return objDataTable
    End Function

    Public Function Listar_Solicitudes_Transporte_Consolidado(ByVal objEntidad As TransporteConsolidado) As List(Of TransporteConsolidado)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of TransporteConsolidado)
        Dim objParam As New Parameter
        Dim objDatos As TransporteConsolidado
        'Try
        objParam.Add("PNNMVJCS", objEntidad.NMVJCS)
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PSCDVSN", objEntidad.CDVSN)
        objParam.Add("PSCPLNDV", objEntidad.CPLNDV)
        objParam.Add("PNNRUCTR", objEntidad.NRUCTR)
        objParam.Add("PNNPLCUN", objEntidad.NPLCUN)
        objParam.Add("PNNPLCAC", objEntidad.NPLCAC)
        'ejecuta el procedimiento almacenado
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        'Obteniendo resultados
        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_SOLICITUD_TRANSPORTE_CONSOLIDADO", objParam)
        'Procesandolos como una Lista
        For Each objData As DataRow In objDataTable.Rows
            objDatos = New TransporteConsolidado
            objDatos.NMVJCS = objData("NMVJCS")
            objDatos.NMOPMM = objData("NMOPMM")
            objDatos.TRFRN = objData("TRFRN").ToString.Trim
            objDatos.NCSOTR = objData("NCSOTR").ToString.Trim
            objDatos.NCRRSR = objData("NCRRSR").ToString.Trim
            objDatos.CCLNT = objData("CCLNT").ToString.Trim
            objDatos.TCMPCL = objData("TCMPCL").ToString.Trim
            'objDatos.FECOST = Validacion.CFecha_a_Numero10Digitos(objData("FECOST").ToString.Trim)
            'objDatos.HRAOTR = objData("HRAOTR").ToString.Trim
            'objDatos.FINCRG = Validacion.CFecha_a_Numero10Digitos(objData("FINCRG").ToString.Trim)
            'objDatos.HINCIN = objData("HINCIN").ToString.Trim
            'objDatos.FENTCL = Validacion.CFecha_a_Numero10Digitos(objData("FENTCL").ToString.Trim)
            'objDatos.HRAENT = objData("HRAENT").ToString.Trim
            objDatos.CLCLOR_C = objData("CLCLOR_C")
            objDatos.CLCLOR = objData("CLCLOR").ToString.Trim
            objDatos.TDRCOR = objData("TDRCOR").ToString.Trim
            objDatos.CLCLDS_C = objData("CLCLDS_C")
            objDatos.CLCLDS = objData("CLCLDS").ToString.Trim
            objDatos.TDRENT = objData("TDRENT").ToString.Trim
            objDatos.CMRCDR = objData("CMRCDR").ToString.Trim
            objDatos.TCMRCD = objData("TCMRCD").ToString.Trim
            objDatos.CUNDMD_C = objData("CUNDMD_C").ToString.Trim
            objDatos.CUNDMD = objData("CUNDMD").ToString.Trim
            objDatos.QSLCIT = CType(objData("QSLCIT"), Integer).ToString
            objDatos.QATNAN = CType(objData("QATNAN"), Integer).ToString
            objDatos.QMRCDR = objData("QMRCDR").ToString.Trim
            objDatos.SESSLC = objData("SESSLC").ToString.Trim
            objDatos.NORSRT = objData("NORSRT").ToString.Trim
            objDatos.CTPOSR = objData("CTPOSR").ToString.Trim
            If objData("TOBS").ToString.Trim.Length > 50 Then
                objDatos.TOBS = objData("TOBS").ToString.Trim.Substring(0, 50) & "..."
            Else
                objDatos.TOBS = objData("TOBS").ToString.Trim
            End If
            objDatos.CANTOP = objData("CANTOP")
            objDatos.CCMPN = objData("CCMPN").ToString.Trim
            objDatos.CDVSN = objData("CDVSN").ToString.Trim
            objDatos.CPLNDV = objData("CPLNDV")
            objDatos.SFCRTV = objData("SFCRTV")
            objDatos.TNMMDT = objData("TNMMDT")
            objDatos.NPLCUN = objData("NPLCUN")
            objDatos.NPLCAC = objData("NPLCAC")
            objDatos.CBRCNT = objData("CBRCNT").ToString()
            objDatos.CBRCND = objData("CBRCND").ToString()
            objDatos.NGUITR = objData("NGUITR")
            objDatos.NOPRCN = objData("NOPRCN")
            objDatos.NPLNMT = objData("NPLNMT")
            objDatos.NORINS = IIf(objData("NORINS") = 0, "Enviar SAP", objData("NORINS"))
            'objDatos.SEGUIMIENTO = objData("SEGUIMIENTO").ToString.Trim
            'objDatos.NGSGWP = objData("NGSGWP").ToString.Trim
            'objDatos.NCOREG = objData("NCOREG")
            'objDatos.CLIENTE_FACT = objData("CCLNFC") & " " & objData("CLIENTE_FACT")
            objDatos.DESC_NIVEL = objData("DESC_NIVEL")
            objDatos.DESC_CARGA = objData("DESC_CARGA")
            objDatos.FATNSR = objData("FATNSR")
            'FATNSR
            objGenericCollection.Add(objDatos)
        Next
        'Catch ex As Exception
        '    objGenericCollection = New List(Of TransporteConsolidado)
        'End Try
        Return objGenericCollection
    End Function

    Public Function Eliminar_Solicitud_Transporte_Consolidado(ByVal objEntidad As TransporteConsolidado) As TransporteConsolidado
        Try
            Dim objParam As New Parameter
            objParam.Add("PNNCSOTR", objEntidad.NCSOTR)
            objParam.Add("PSSESTRG", objEntidad.SESTRG)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
            objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
            objParam.Add("PNNMVJCS", objEntidad.NMVJCS)
            objParam.Add("PNCTRMNC", objEntidad.CTRSPT)
            objParam.Add("PNNGUIRM", objEntidad.NGUITR)
            objParam.Add("OURESULT", 0, ParameterDirection.Output)
            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            'ejecuta el procedimiento almacenado
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_SOLICITUD_TRANSPORTE_CONSOLIDADO", objParam)
            objEntidad.NCRRSR = objSql.ParameterCollection("OURESULT")
        Catch ex As Exception
            'Caso ser erroneo el procedimiento, pasa a mostrar el numero cero
            'que indica que no ha podido realizar la operación
            objEntidad.NCRRSR = 0
        End Try
        Return objEntidad
    End Function

    Public Function Eliminar_Guia_Remision_Servicio_Consolidado(ByVal objEntidad As ENTIDADES.mantenimientos.GuiaTransportista) As Integer
        'Try
        Dim objParam As New Parameter
        Dim retorno As Integer = -1
        objParam.Add("PNNCSOTR", objEntidad.NCSOTR)
        objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
        objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
        objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PNFULTAC", objEntidad.FULTAC)
        objParam.Add("PNHULTAC", objEntidad.HULTAC)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
        objParam.Add("OURESULT", 0, ParameterDirection.Output)
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_GUIA_TRANSPORTISTA_CONSOLIDADO", objParam)
        retorno = Convert.ToInt32(objSql.ParameterCollection("OURESULT").ToString)
        'Catch ex As Exception
        '    Return -1
        'End Try
        Return retorno

    End Function

    Public Function Validar_Estado_Traslado_Consolidado(ByVal objEntidad As TransporteConsolidado) As TransporteConsolidado
        Try
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PNNMVJCS", objEntidad.NMVJCS)
            objParam.Add("PSSESSLC", "", ParameterDirection.Output)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_VALIDAR_TRASLADO_CONSOLIDADO", objParam)
            objEntidad.SESSLC = objSql.ParameterCollection("PSSESSLC").ToString
        Catch ex As Exception
            objEntidad.SESSLC = ex.Message
        End Try
        Return objEntidad
    End Function

    Public Function Listar_Reporte_Excel(ByVal objetoParametro As Hashtable) As DataTable
        Dim objDataTable As New DataTable
        Dim objParam As New Parameter
        Try

            objParam.Add("PSCCMPN", objetoParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objetoParametro("PSCDVSN"))
            objParam.Add("PNCPLNDV", objetoParametro("PNCPLNDV"))
            objParam.Add("PNNMVJCS", objetoParametro("PNNMVJCS"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("PSCCMPN"))

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_EXPORTAR_TRASLADO_CONSOLIDADO", objParam)

        Catch ex As Exception
            Dim s As String = ""
        End Try
        Return objDataTable
    End Function
End Class
