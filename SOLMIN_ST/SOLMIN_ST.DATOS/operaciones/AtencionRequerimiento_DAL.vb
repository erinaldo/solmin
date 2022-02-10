Imports SOLMIN_ST.ENTIDADES
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.Utilitario

Public Class AtencionRequerimiento_DAL

    Private objSql As New SqlManager

    'Public Function Lista_Requerimiento_Servicio(ByVal beEntidad As RequerimientoServicio) As List(Of RequerimientoServicio)

    '    Dim dt As New DataTable
    '    Dim objParam As New Parameter
    '    Dim Lista As New List(Of RequerimientoServicio)
    '    Dim Entidad As RequerimientoServicio

    '    objParam.Add("PSCCMPN", beEntidad.CCMPN)
    '    objParam.Add("PSCDVSN", beEntidad.CDVSN)
    '    objParam.Add("PNCPLNDV", beEntidad.CPLNDV)
    '    objParam.Add("PNCCLNT", beEntidad.CCLNT)

    '    objParam.Add("PSSESREQ", beEntidad.SESREQ)
    '    objParam.Add("PSSPRSTR", beEntidad.SPRSTR)

    '    objParam.Add("PNFECREQ_INI", beEntidad.FECREQ_INI)
    '    objParam.Add("PNFECREQ_FIN", beEntidad.FECREQ_FIN)

    '    objParam.Add("PNHRAREQ_INI", beEntidad.HRAREQ_INI)
    '    objParam.Add("PNHRAREQ_FIN", beEntidad.HRAREQ_FIN)

    '    objParam.Add("PNFCHATN_INI", beEntidad.FCHATN_INI)
    '    objParam.Add("PNFCHATN_FIN", beEntidad.FCHATN_FIN)

    '    objParam.Add("PNHRAATN_INI", beEntidad.HRAATN_INI)
    '    objParam.Add("PNHRAATN_FIN", beEntidad.HRAATN_FIN)

    '    objParam.Add("PNNUMREQT", beEntidad.NUMREQT)
    '    objParam.Add("PNNCSOTR", beEntidad.NCSOTR)

    '    objParam.Add("PSCRGVTA", beEntidad.CRGVTA)

    '    'objParam.Add("PNNOPRCN", beEntidad.NOPRCN)
    '    objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(beEntidad.CCMPN)
    '    dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_REQUERIMIENTO_SERVICIO_LIST", objParam)

    '    For Each Item As DataRow In dt.Rows
    '        Entidad = New RequerimientoServicio

    '        Entidad.CCMPN = Item("CCMPN")
    '        Entidad.CCMPN_S = Item("CCMPN_S")
    '        'Entidad.NCSOTR = Item("NCSOTR")
    '        Entidad.NUMREQT = Item("NUMREQT")
    '        Entidad.FECREQ_S = HelpClass.CNumero8Digitos_a_FechaDefault(CLng(Item("FECREQ"))).ToString
    '        Entidad.HRAREQ_S = IIf(Item("HRAREQ") = 0, "", HelpClass.HoraNum_a_Hora(CLng(Item("HRAREQ"))).ToString)
    '        Entidad.CDVSN = Item("CDVSN")
    '        Entidad.CDVSN_S = Item("CDVSN_S")
    '        Entidad.CPLNDV = Item("CPLNDV")
    '        Entidad.CPLNDV_S = Item("CPLNDV_S")
    '        Entidad.CCLNT = Item("CCLNT")
    '        Entidad.CCLNT_S = Item("CCLNT_S")

    '        Entidad.FCHATN_D = HelpClass.CNumero8Digitos_a_FechaDefault(CLng(Item("FCHATN"))).ToString
    '        Entidad.HRAATN_D = IIf(Item("HRAATN") = 0, "", HelpClass.HoraNum_a_Hora(CLng(Item("HRAATN"))).ToString)

    '        Entidad.SPRSTR = Item("SPRSTR")
    '        Entidad.SPRSTR_S = Item("SPRSTR_S")

    '        Entidad.TIPOCNT = Item("TIPOCNT")   'Tipo mercaderia
    '        Entidad.TIPOCNT_S = Item("TIPOCNT_S")

    '        Entidad.QPSOMR = Item("QPSOMR")
    '        Entidad.QMTLRG = Item("QMTLRG")
    '        Entidad.QMTALT = Item("QMTALT")
    '        Entidad.QMTANC = Item("QMTANC")

    '        'Entidad.NRCTSL = Item("NRCTSL") ' Nro. de Contrato SOLMIN
    '        'Entidad.NRTFSV = Item("NRTFSV")  'Nro. Tarifa X Servicio
    '        'Entidad.NCRRSR = Item("NCRRSR") 'Numero Correlativo del Servicio

    '        Entidad.NORSRT = Item("NORSRT")  'O/S
    '        Entidad.NDCORM = Item("NDCORM")  'O/S Agencia   

    '        Entidad.CLCLOR = Item("CLCLOR")
    '        Entidad.CLCLOR_S = Item("CLCLOR_S").ToString.Trim
    '        Entidad.CLCLDS = Item("CLCLDS")
    '        Entidad.CLCLDS_S = Item("CLCLDS_S").ToString.Trim
    '        Entidad.TDRCOR = Item("TDRCOR")
    '        Entidad.TDRENT = Item("TDRENT")

    '        Entidad.TIPSRV = Item("TIPSRV") 'Tipo req.
    '        Entidad.TIPSRV_S = Item("TIPSRV_S") 'Tipo req.

    '        Entidad.REFDO1 = Item("REFDO1").ToString.Trim 'Doc.Referencia
    '        Entidad.TOBS = Item("TOBS").ToString.Trim     'Observaciones

    '        Entidad.SESREQ = Item("SESREQ") 'Estado Req.
    '        Entidad.SESREQ_S = Item("SESREQ_S").ToString.Trim

    '        Entidad.SESTRG = Item("SESTRG")
    '        Entidad.CUSCRT = Item("CUSCRT").ToString.Trim & " - " & HelpClass.CNumero8Digitos_a_FechaDefault(CLng(Item("FCHCRT"))).ToString & " - " & IIf(Item("HRACRT") = 0, "", HelpClass.HoraNum_a_Hora(CLng(Item("HRACRT"))).ToString)
    '        Entidad.FCHCRT = Item("FCHCRT")
    '        Entidad.HRACRT = Item("HRACRT")
    '        Entidad.NTRMCR = Item("NTRMCR")
    '        If Item("CULUSA").ToString.Trim & " - " & HelpClass.CNumero8Digitos_a_FechaDefault(CLng(Item("FULTAC"))).ToString & " - " & IIf(Item("HULTAC") = 0, "", HelpClass.HoraNum_a_Hora(CLng(Item("HULTAC"))).ToString) = " -  - " Then
    '            Entidad.CULUSA = ""
    '        Else
    '            Entidad.CULUSA = Item("CULUSA").ToString.Trim & " - " & HelpClass.CNumero8Digitos_a_FechaDefault(CLng(Item("FULTAC"))).ToString & " - " & IIf(Item("HULTAC") = 0, "", HelpClass.HoraNum_a_Hora(CLng(Item("HULTAC"))).ToString)
    '        End If

    '        Entidad.FULTAC = Item("FULTAC")
    '        Entidad.HULTAC = Item("HULTAC")
    '        Entidad.NTRMNL = Item("NTRMNL")

    '        Entidad.QSLCIT = Item("QSLCIT")
    '        Entidad.CMEDTR = Item("CMEDTR")

    '        Entidad.CUNDMD = Item("CUNDMD").ToString

    '        'Entidad.CUNDVH = Item("CUNDVH").ToString.Trim
    '        Entidad.CUNDVH_D = Item("CUNDVH").ToString.Trim
    '        Entidad.QMRCDR = CDec(Val(Item("QMRCDR").ToString))

    '        Entidad.CMRCDR = CDec(Val(Item("CMRCDR").ToString.Trim))
    '        Entidad.CMRCDR_D = Item("CMRCDR_D").ToString.Trim

    '        Entidad.CTPOSR = Item("CTPOSR").ToString.Trim

    '        Entidad.CUBORI = CDec(Val(Item("CUBORI").ToString))
    '        Entidad.CUBORI_S = Item("CUBORI_S").ToString.Trim
    '        Entidad.CUBDES = CDec(Val(Item("CUBDES").ToString))
    '        Entidad.CUBDES_S = Item("CUBDES_S").ToString.Trim

    '        'Entidad.NSECREV = Item("NSECREV")
    '        'Entidad.FSECREV_D = HelpClass.CNumero8Digitos_a_FechaDefault(CLng(Item("FSECREV"))).ToString

    '        Entidad.PNCDTR = Item("PNCDTR").ToString.Trim

    '        Entidad.QUNIDJUNTA = Item("QUNIDJUNTA")
    '        Entidad.QUNIDSOLICITADAS = Item("QUNIDSOLICITADAS")

    '        Entidad.TOBERV = Item("TOBERV").ToString.Trim
    '        Entidad.PRSCNT = Item("PRSCNT").ToString.Trim

    '        Entidad.CRGVTA = Item("CRGVTA")
    '        Entidad.TCRVTA = Item("TCRVTA").ToString.Trim
    '        Entidad.TIRALC = Item("TIRALC").ToString.Trim

    '        Lista.Add(Entidad)

    '    Next

    '    Return Lista

    'End Function


    Public Function Lista_Tipo_Mercaderia() As DataTable

        Dim dt As New DataTable
        Dim objParam As New Parameter
        dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_TIPO_MERCADERIA_LIST", objParam)
        Return dt

    End Function

    'Public Sub intActualizarRequerimientoServicio(ByVal obeRequerimiento As RequerimientoServicio)

    '    Dim objParam As New Parameter
    '    objParam.Add("PNNUMREQT", obeRequerimiento.NUMREQT)
    '    objParam.Add("PSCCMPN", obeRequerimiento.CCMPN)

    '    objParam.Add("PNFECREQ", obeRequerimiento.FECREQ)
    '    objParam.Add("PNHRAREQ", obeRequerimiento.HRAREQ)

    '    objParam.Add("PSCDVSN", obeRequerimiento.CDVSN)
    '    objParam.Add("PNCPLNDV", obeRequerimiento.CPLNDV)
    '    objParam.Add("PNCCLNT", obeRequerimiento.CCLNT)

    '    objParam.Add("PNFCHATN", obeRequerimiento.FCHATN)
    '    objParam.Add("PNHRAATN", obeRequerimiento.HRAATN)

    '    objParam.Add("PSSPRSTR", obeRequerimiento.SPRSTR)
    '    objParam.Add("PSTIPOCNT", obeRequerimiento.TIPOCNT)
    '    objParam.Add("PNQPSOMR", obeRequerimiento.QPSOMR)
    '    'objParam.Add("PNQMTLRG", obeRequerimiento.QMTLRG)
    '    'objParam.Add("PNQMTALT", obeRequerimiento.QMTALT)
    '    'objParam.Add("PNQMTANC", obeRequerimiento.QMTANC)

    '    'objParam.Add("PNNRCTSL", obeRequerimiento.NRCTSL)
    '    'objParam.Add("PNNRTFSV", obeRequerimiento.NRTFSV)
    '    'objParam.Add("PNNCRRSR", obeRequerimiento.NCRRSR)

    '    objParam.Add("PNNORSRT", obeRequerimiento.NORSRT)
    '    objParam.Add("PNNDCORM", obeRequerimiento.NDCORM)
    '    objParam.Add("PSPNCDTR", obeRequerimiento.PNCDTR)
    '    objParam.Add("PNCLCLOR", obeRequerimiento.CLCLOR)
    '    objParam.Add("PNCLCLDS", obeRequerimiento.CLCLDS)
    '    objParam.Add("PSTDRCOR", obeRequerimiento.TDRCOR)
    '    objParam.Add("PSTDRENT", obeRequerimiento.TDRENT)

    '    objParam.Add("PSTIPSRV", obeRequerimiento.TIPSRV)
    '    objParam.Add("PSREFDO1", obeRequerimiento.REFDO1)
    '    objParam.Add("PSTOBS", obeRequerimiento.TOBS)
    '    objParam.Add("PSSESREQ", obeRequerimiento.SESREQ)
    '    objParam.Add("PSUSUARIO", obeRequerimiento.CULUSA)
    '    objParam.Add("PSNTRMNL", obeRequerimiento.NTRMNL)

    '    objParam.Add("PNCMEDTR", obeRequerimiento.CMEDTR)
    '    objParam.Add("PNQSLCIT", obeRequerimiento.QSLCIT)

    '    objParam.Add("PSTOBERV", obeRequerimiento.TOBERV)
    '    objParam.Add("PSPRSCNT", obeRequerimiento.PRSCNT)

    '    objParam.Add("PSTIRALC", obeRequerimiento.TIRALC)

    '    '  objParam.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result
    '    objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obeRequerimiento.CCMPN)
    '    objSql.ExecuteNonQuery("SP_SOLMIN_ST_REQUERIMIENTO_SERVICIO_UPDATE", objParam)

    '    '  Return objSql.ParameterCollection("PSRESULT")

    'End Sub

    'Public Function intInsertarRequerimientoServicio(ByVal obeRequerimiento As RequerimientoServicio) As Decimal

    '    Dim objParam As New Parameter

    '    objParam.Add("PSCCMPN", obeRequerimiento.CCMPN)

    '    objParam.Add("PNFECREQ", obeRequerimiento.FECREQ)
    '    objParam.Add("PNHRAREQ", obeRequerimiento.HRAREQ)

    '    objParam.Add("PSCDVSN", obeRequerimiento.CDVSN)
    '    objParam.Add("PNCPLNDV", obeRequerimiento.CPLNDV)
    '    objParam.Add("PNCCLNT", obeRequerimiento.CCLNT)

    '    objParam.Add("PNFCHATN", obeRequerimiento.FCHATN)
    '    objParam.Add("PNHRAATN", obeRequerimiento.HRAATN)

    '    objParam.Add("PSSPRSTR", obeRequerimiento.SPRSTR)
    '    objParam.Add("PSTIPOCNT", obeRequerimiento.TIPOCNT)
    '    objParam.Add("PNQPSOMR", obeRequerimiento.QPSOMR)
    '    'objParam.Add("PNQMTLRG", obeRequerimiento.QMTLRG)
    '    'objParam.Add("PNQMTALT", obeRequerimiento.QMTALT)
    '    'objParam.Add("PNQMTANC", obeRequerimiento.QMTANC)

    '    'objParam.Add("PNNRCTSL", obeRequerimiento.NRCTSL)
    '    'objParam.Add("PNNRTFSV", obeRequerimiento.NRTFSV)
    '    'objParam.Add("PNNCRRSR", obeRequerimiento.NCRRSR)

    '    objParam.Add("PNNORSRT", obeRequerimiento.NORSRT)
    '    objParam.Add("PNNDCORM", obeRequerimiento.NDCORM)
    '    objParam.Add("PSPNCDTR", obeRequerimiento.PNCDTR)
    '    objParam.Add("PNCLCLOR", obeRequerimiento.CLCLOR)
    '    objParam.Add("PNCLCLDS", obeRequerimiento.CLCLDS)
    '    objParam.Add("PSTDRCOR", obeRequerimiento.TDRCOR)
    '    objParam.Add("PSTDRENT", obeRequerimiento.TDRENT)

    '    objParam.Add("PSTIPSRV", obeRequerimiento.TIPSRV)
    '    objParam.Add("PSREFDO1", obeRequerimiento.REFDO1)
    '    objParam.Add("PSTOBS", obeRequerimiento.TOBS)
    '    objParam.Add("PSSESREQ", obeRequerimiento.SESREQ)
    '    objParam.Add("PSUSUARIO", obeRequerimiento.CUSCRT)
    '    objParam.Add("PSNTRMNL", obeRequerimiento.NTRMCR)

    '    objParam.Add("PNCMEDTR", obeRequerimiento.CMEDTR)
    '    objParam.Add("PNQSLCIT", obeRequerimiento.QSLCIT)

    '    objParam.Add("PSTOBERV", obeRequerimiento.TOBERV)
    '    objParam.Add("PSPRSCNT", obeRequerimiento.PRSCNT)

    '    objParam.Add("PSTIRALC", obeRequerimiento.TIRALC)

    '    objParam.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result
    '    objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obeRequerimiento.CCMPN)
    '    objSql.ExecuteNonQuery("SP_SOLMIN_ST_REQUERIMIENTO_SERVICIO_INSERT", objParam)

    '    Return objSql.ParameterCollection("PSRESULT")

    'End Function

    'Public Function intEliminarRequerimientoServicio(ByVal obeRequerimiento As RequerimientoServicio) As Integer

    '    Dim objParam As New Parameter

    '    objParam.Add("PNNUMREQT", obeRequerimiento.NUMREQT)
    '    objParam.Add("PSCCMPN", obeRequerimiento.CCMPN)
    '    objParam.Add("PSUSUARIO", obeRequerimiento.CUSCRT)
    '    objParam.Add("PSNTRMNL", obeRequerimiento.NTRMCR)

    '    'objParam.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result
    '    objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obeRequerimiento.CCMPN)
    '    objSql.ExecuteNonQuery("SP_SOLMIN_ST_REQUERIMIENTO_SERVICIO_DELETE", objParam)
    '    Return 1 'objSql.ParameterCollection("PSRESULT")
    'End Function

    'Public Function intRevisarRequerimientoServicio(ByVal obeRequerimiento As RequerimientoServicio) As Integer

    '    Dim objParam As New Parameter

    '    objParam.Add("PSNUMREQT", obeRequerimiento.NUMREQT_LIST)
    '    objParam.Add("PSCCMPN", obeRequerimiento.CCMPN)
    '    objParam.Add("PSUSUARIO", obeRequerimiento.CUSCRT)
    '    objParam.Add("PSNTRMNL", obeRequerimiento.NTRMCR)
    '    objParam.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result

    '    objSql.ExecuteNonQuery("SP_SOLMIN_ST_REQUERIMIENTO_SERVICIO_REVISAR", objParam)
    '    Return objSql.ParameterCollection("PSRESULT")
    'End Function

    Public Function intActualizarRequerimientoSolicitud(ByVal obeRequerimiento As AtencionRequerimiento) As Integer

        Dim objParam As New Parameter

        objParam.Add("PSNUMREQT", obeRequerimiento.NUMREQT)
        objParam.Add("PSCCMPN", obeRequerimiento.CCMPN)
        objParam.Add("PSUSUARIO", obeRequerimiento.CUSCRT)
        objParam.Add("PSNTRMNL", obeRequerimiento.NTRMCR)
        'objParam.Add("PNNCSOTR", obeRequerimiento.NCSOTR)
        objParam.Add("PSSESREQ", obeRequerimiento.SESREQ)

        'objParam.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obeRequerimiento.CCMPN)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_REQUERIMIENTO_ASIGNAR_SOLICITUD", objParam)
        Return 1 'objSql.ParameterCollection("PSRESULT")
    End Function

    Public Function Registrar_Solicitud_Transporte_Requerimiento(ByVal objEntidad As ENTIDADES.Operaciones.Solicitud_Transporte) As ENTIDADES.Operaciones.Solicitud_Transporte
        'Try
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
        'objParam.Add("PARAM_FCHCRT", objEntidad.FCHCRT)
        'objParam.Add("PARAM_HRACRT", objEntidad.HRACRT)
        objParam.Add("PARAM_NTRMCR", objEntidad.NTRMCR)
        objParam.Add("PARAM_CULUSA", objEntidad.CULUSA)
        'objParam.Add("PARAM_FULTAC", objEntidad.FULTAC)
        'objParam.Add("PARAM_HULTAC", objEntidad.HULTAC)
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
        objParam.Add("PARAM_CTPOVJ", objEntidad.CTPOVJ)
        objParam.Add("PARAM_SPRSTR", objEntidad.SPRSTR)

        objParam.Add("PARAM_CUBORI", objEntidad.CUBORI)
        objParam.Add("PARAM_CUBDES", objEntidad.CUBDES)

        objParam.Add("PARAM_NUMREQT", objEntidad.NUMREQT)

        objParam.Add("PSCTTRAN", objEntidad.CTTRAN)
        objParam.Add("PSCTIPCG", objEntidad.CTIPCG)
        'objParam.Add("PNCCLNFC", objEntidad.CCLNFC)
        'objParam.Add("PNCCNTCS", objEntidad.COD_CEBEDP)
        'objParam.Add("PNCENCOS", objEntidad.COD_CECODP)
        'objParam.Add("PNCCNCS1", objEntidad.COD_CEBEDT)
        'objParam.Add("PNCENCO1", objEntidad.COD_CECODT)
        'ejecuta el procedimiento almacenado
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        'ejecuta el procedimiento almacenado
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_SOLICITUD_TRANSPORTE_REQUERIMIENTO", objParam)
        'Si la operación finaliza correctamente, procede a obtener el
        'numero de la solicitud generado en el stored procedure
        objEntidad.NCSOTR = objSql.ParameterCollection("PARAM_NCSOTR").ToString()
        'Catch ex As Exception
        '    'Caso ser erroneo el procedimiento, pasa a mostrar el numero cero
        '    'que indica que no ha podido realizar la operación
        '    objEntidad.NCSOTR = 0
        'End Try
        Return objEntidad
    End Function

    Public Function Lista_Requerimiento_Servicio_Estado_Actual(ByVal beEntidad As AtencionRequerimiento) As AtencionRequerimiento

        Dim dt As New DataTable
        Dim objParam As New Parameter
        Dim Entidad As New AtencionRequerimiento

        objParam.Add("PSCCMPN", beEntidad.CCMPN)
        objParam.Add("PSCDVSN", beEntidad.CDVSN)
        objParam.Add("PNNUMREQT", beEntidad.NUMREQT)
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(beEntidad.CCMPN)

        dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_REQUERIMIENTO_SERVICIO_LISTA_ESTADO_ACTUAL", objParam)

        For Each Item As DataRow In dt.Rows

            Entidad.CCMPN = Item("CCMPN")
            Entidad.CDVSN = Item("CDVSN")
            Entidad.NUMREQT = Item("NUMREQT")
            Entidad.SESREQ = Item("SESREQ") 'Estado Req.

        Next

        Return Entidad

    End Function

    Public Function Lista_Negocio(ByVal CCMPN As String) As DataTable

        Dim dt As New DataTable
        Dim objParam As New Parameter
        objParam.Add("PSCCMPN", CCMPN)
        objParam.Add("PNCTPINC", "0")
        dt = objSql.ExecuteDataTable("SP_SOLSC_LISTA_INCIDENCIA_NEGOCIO", objParam)

        Return dt

    End Function

    'Public Function olisListarResponsables(ByVal oResponsable As beDestinatario) As List(Of beDestinatario)
    '    Dim oDt As New DataTable
    '    Dim olbeDestinatario As New List(Of beDestinatario)
    '    Dim objDestinatario As beDestinatario
    '    Dim objParam As New Parameter

    '    objParam.Add("PNCCLNT", oResponsable.PNCCLNT)
    '    objParam.Add("PSTIPPROC", oResponsable.PSTIPPROC)

    '    oDt = objSql.ExecuteDataTable("SP_SOLSC_LISTAR_RESPONSABLES_REQSERV", objParam)

    '    For Each fila As DataRow In oDt.Rows
    '        objDestinatario = New beDestinatario

    '        objDestinatario.PSEMAILTO = fila("EMAILTO").ToString.Trim
    '        objDestinatario.PSNLTECL = fila("NLTECL")
    '        objDestinatario.PSTIPPROC = fila("TIPPROC")
    '        objDestinatario.PSTNMYAP = fila("TNMYAP").ToString.Trim
    '        objDestinatario.PSNCRRIT = fila("NCRRIT")

    '        olbeDestinatario.Add(objDestinatario)
    '    Next

    '    Return olbeDestinatario

    'End Function

    Public Function Lista_Atencion_Requerimiento(ByVal beEntidad As AtencionRequerimiento) As DataTable 'List(Of AtencionRequerimiento)

        Dim dt As New DataTable
        Dim objParam As New Parameter
        ''Dim Lista As New List(Of AtencionRequerimiento)
        Dim Entidad As AtencionRequerimiento

        objParam.Add("PSCCMPN", beEntidad.CCMPN)
        objParam.Add("PSCDVSN", beEntidad.CDVSN)
        objParam.Add("PNCPLNDV", beEntidad.CPLNDV)
        objParam.Add("PNCCLNT", beEntidad.CCLNT)

        objParam.Add("PSSESREQ", beEntidad.SESREQ)
        objParam.Add("PSSPRSTR", beEntidad.SPRSTR)

        objParam.Add("PNFECREQ_INI", beEntidad.FECREQ_INI)
        objParam.Add("PNFECREQ_FIN", beEntidad.FECREQ_FIN)

        objParam.Add("PNHRAREQ_INI", beEntidad.HRAREQ_INI)
        objParam.Add("PNHRAREQ_FIN", beEntidad.HRAREQ_FIN)

        objParam.Add("PNFCHATN_INI", beEntidad.FCHATN_INI)
        objParam.Add("PNFCHATN_FIN", beEntidad.FCHATN_FIN)

        objParam.Add("PNHRAATN_INI", beEntidad.HRAATN_INI)
        objParam.Add("PNHRAATN_FIN", beEntidad.HRAATN_FIN)

        objParam.Add("PNNUMREQT", beEntidad.NUMREQT)
        objParam.Add("PNNCSOTR", beEntidad.NCSOTR)

        objParam.Add("PSCRGVTA", beEntidad.CRGVTA)
        objParam.Add("PSSJTTR", beEntidad.SJTTR)
        'objParam.Add("PNNOPRCN", beEntidad.NOPRCN)
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(beEntidad.CCMPN)
        dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_ATENCION_REQUERIMIENTO_LIST", objParam)

        For Each Item As DataRow In dt.Rows
            ''Entidad = New AtencionRequerimiento

            'Entidad.CCMPN = Item("CCMPN")
            'Entidad.CCMPN_S = Item("CCMPN_S")
            ''Entidad.NCSOTR = Item("NCSOTR")
            'Entidad.NUMREQT = Item("NUMREQT")
            Item("FECREQ") = HelpClass.CNumero8Digitos_a_FechaDefault(CLng(Item("FECREQ"))).ToString
            Item("HRAREQ") = IIf(Item("HRAREQ") = 0, "", HelpClass.HoraNum_a_Hora(CLng(Item("HRAREQ"))).ToString)
            'Entidad.CDVSN = Item("CDVSN")
            'Entidad.CDVSN_S = Item("CDVSN_S")
            'Entidad.CPLNDV = Item("CPLNDV")
            'Entidad.CPLNDV_S = Item("CPLNDV_S")
            'Entidad.CCLNT = Item("CCLNT")
            'Entidad.CCLNT_S = Item("CCLNT_S")

            Item("FCHATN") = HelpClass.CNumero8Digitos_a_FechaDefault(CLng(Item("FCHATN"))).ToString
            Item("HRAATN") = IIf(Item("HRAATN") = 0, "", HelpClass.HoraNum_a_Hora(CLng(Item("HRAATN"))).ToString)

            'Entidad.SPRSTR = Item("SPRSTR")
            'Entidad.SPRSTR_S = Item("SPRSTR_S")

            'Entidad.TIPOCNT = Item("TIPOCNT")   'Tipo mercaderia
            'Entidad.TIPOCNT_S = Item("TIPOCNT_S")

            'Entidad.QPSOMR = Item("QPSOMR")

            'Entidad.DIMENSIONES = Item("DIMENSIONES")

            ' ''Entidad.QMTLRG = Item("QMTLRG")
            ' ''Entidad.QMTALT = Item("QMTALT")
            ' ''Entidad.QMTANC = Item("QMTANC")

            ''Entidad.NRCTSL = Item("NRCTSL") ' Nro. de Contrato SOLMIN
            ''Entidad.NRTFSV = Item("NRTFSV")  'Nro. Tarifa X Servicio
            ''Entidad.NCRRSR = Item("NCRRSR") 'Numero Correlativo del Servicio

            'Entidad.NORSRT = Item("NORSRT")  'O/S
            'Entidad.NDCORM = Item("NDCORM")  'O/S Agencia   

            'Entidad.CLCLOR = Item("CLCLOR")
            Item("CLCLOR_S") = Item("CLCLOR_S").ToString.Trim
            'Entidad.CLCLDS = Item("CLCLDS")
            Item("CLCLDS_S") = Item("CLCLDS_S").ToString.Trim
            Item("TDRCOR") = Item("TDRCOR").ToString.Trim
            Item("TDRENT") = Item("TDRENT").ToString.Trim

            'Entidad.TIPSRV = Item("TIPSRV") 'Tipo req.
            'Entidad.TIPSRV_S = Item("TIPSRV_S") 'Tipo req.

            Item("REFDO1") = Item("REFDO1").ToString.Trim 'Doc.Referencia
            Item("TOBS") = Item("TOBS").ToString.Trim     'Observaciones

            'Entidad.SESREQ = Item("SESREQ") 'Estado Req.
            Item("SESREQ_S") = Item("SESREQ_S").ToString.Trim

            'Entidad.SESTRG = Item("SESTRG")
            Item("CUSCRT") = Item("CUSCRT").ToString.Trim & " - " & HelpClass.CNumero8Digitos_a_FechaDefault(CLng(Item("FCHCRT"))).ToString & " - " & IIf(Item("HRACRT") = 0, "", HelpClass.HoraNum_a_Hora(CLng(Item("HRACRT"))).ToString)
            'Entidad.FCHCRT = Item("FCHCRT")
            'Entidad.HRACRT = Item("HRACRT")
            'Entidad.NTRMCR = Item("NTRMCR")
            If Item("CULUSA").ToString.Trim & " - " & HelpClass.CNumero8Digitos_a_FechaDefault(CLng(Item("FULTAC"))).ToString & " - " & IIf(Item("HULTAC") = 0, "", HelpClass.HoraNum_a_Hora(CLng(Item("HULTAC"))).ToString) = " -  - " Then
                Item("CULUSA") = ""
            Else
                Item("CULUSA") = Item("CULUSA").ToString.Trim & " - " & HelpClass.CNumero8Digitos_a_FechaDefault(CLng(Item("FULTAC"))).ToString & " - " & IIf(Item("HULTAC") = 0, "", HelpClass.HoraNum_a_Hora(CLng(Item("HULTAC"))).ToString)
            End If

            'Entidad.FULTAC = Item("FULTAC")
            'Entidad.HULTAC = Item("HULTAC")
            'Entidad.NTRMNL = Item("NTRMNL")

            'Entidad.QSLCIT = Item("QSLCIT")
            'Entidad.CMEDTR = Item("CMEDTR")
            'Entidad.TNMMDT = Item("TNMMDT")

            'Entidad.CUNDMD = Item("CUNDMD").ToString

            ''Entidad.CUNDVH = Item("CUNDVH").ToString.Trim
            Item("CUNDVH") = Item("CUNDVH").ToString.Trim
            'Entidad.QMRCDR = CDec(Val(Item("QMRCDR").ToString))

            Item("CMRCDR") = CDec(Val(Item("CMRCDR").ToString.Trim))
            Item("CMRCDR_D") = Item("CMRCDR_D").ToString.Trim

            Item("CTPOSR") = Item("CTPOSR").ToString.Trim

            'Entidad.CUBORI = CDec(Val(Item("CUBORI").ToString))
            Item("CUBORI_S") = Item("CUBORI_S").ToString.Trim
            'Entidad.CUBDES = CDec(Val(Item("CUBDES").ToString))
            Item("CUBDES_S") = Item("CUBDES_S").ToString.Trim

            'Entidad.NSECREV = Item("NSECREV")
            'Entidad.FSECREV_D = HelpClass.CNumero8Digitos_a_FechaDefault(CLng(Item("FSECREV"))).ToString

            Item("PNCDTR") = Item("PNCDTR").ToString.Trim

            'Entidad.QUNIDJUNTA = Item("QUNIDJUNTA")
            'Entidad.QUNIDSOLICITADAS = Item("QUNIDSOLICITADAS")
            'Entidad.QUNIDATENDIDAS = Item("QATNAN")

            Item("TOBERV") = Item("TOBERV").ToString.Trim
            Item("PRSCNT") = Item("PRSCNT").ToString.Trim

            'Entidad.CRGVTA = Item("CRGVTA")
            Item("TCRVTA") = Item("TCRVTA").ToString.Trim
            Item("TIRALC") = Item("TIRALC").ToString.Trim

            'Entidad.CCLNFC = Item("CCLNFC")
            Item("CCLNFC_S") = Item("CCLNFC_S").ToString.Trim
            'Entidad.NROENV = Item("NROENV")
            'Item("SJTTR") = Item("SJTTR").ToString.Trim
            'Entidad.SOLICT = Item("SOLICT")
            'Entidad.NORSRTSR = Item("NORSRTSR")
            'Entidad.CLCLORSR = Item("CLCLORSR")
            'Item("CLCLORSR_S") = Item("CLCLORSR_S").ToString.Trim
            'Entidad.CLCLDSSR = Item("CLCLDSSR")
            'Entidad.CLCLDSSR_S = Item("CLCLDSSR_S").ToString.Trim
            'Entidad.NDCORMSR = Item("NDCORMSR")
            'Entidad.PNCDTRSR = Item("PNCDTRSR")

            '' Lista.Add(Entidad)
            Item("NORSRT_SREQ") = Item("NORSRT_SREQ")
            Item("CLCLOR_SREQ") = Item("CLCLOR_SREQ").ToString.Trim
            Item("CLCLDS_SREQ") = Item("CLCLDS_SREQ").ToString.Trim
            Item("NDCORMSR_SREQ") = Item("NDCORMSR_SREQ").ToString.Trim

            If Item("CUSOSAR").ToString.Trim & " - " & HelpClass.CNumero8Digitos_a_FechaDefault(CLng(Item("FCHOSAR"))).ToString & " - " & IIf(Item("HRAOSAR") = 0, "", HelpClass.HoraNum_a_Hora(CLng(Item("HRAOSAR"))).ToString) = " -  - " Then
                Item("CUSOSAR") = ""
            Else
                Item("CUSOSAR") = Item("CUSOSAR").ToString.Trim & " - " & HelpClass.CNumero8Digitos_a_FechaDefault(CLng(Item("FCHOSAR"))).ToString & " - " & IIf(Item("HRAOSAR") = 0, "", HelpClass.HoraNum_a_Hora(CLng(Item("HRAOSAR"))).ToString)
            End If

        Next

        Return dt

    End Function

    Public Function Obtener_Detalle_Solicitud_Asignada_X_Requerimiento(ByVal objEntidad As ENTIDADES.mantenimientos.ClaseGeneral) As List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Dim objParam As New Parameter
        Dim objDatos As ENTIDADES.mantenimientos.ClaseGeneral
        Try
            objParam.Add("PNNUMREQT", objEntidad.NUMREQT)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_SOLICITUD_ASIGNADA_LA_X_REQ_ATENCION", objParam)

            For Each objData As DataRow In objDataTable.Rows
                objDatos = New ENTIDADES.mantenimientos.ClaseGeneral
                objDatos.NCSOTR = objData("NCSOTR").ToString.Trim
                objDatos.NCRRSR = objData("NCRRSR").ToString.Trim
                objDatos.NPLNJT = objData("NPLNJT").ToString.Trim
                objDatos.NCRRPL = objData("NCRRPL").ToString.Trim
                objDatos.NRUCTR = objData("NRUCTR").ToString.Trim
                objDatos.TCMTRT = objData("TCMTRT").ToString.Trim
                objDatos.NPLCUN = objData("NPLCUN").ToString.Trim
                objDatos.NPLCAC = objData("NPLCAC").ToString.Trim
                objDatos.CBRCND = objData("CBRCNT").ToString.Trim
                objDatos.CBRCNT = objData("CBRCND").ToString.Trim
                objDatos.FASGTR = HelpClass.CFecha_de_8_a_10(objData("FASGTR").ToString.Trim)
                objDatos.HASGTR = IIf(objData("HASGTR").ToString.Trim = "00:00:00", "", objData("HASGTR").ToString.Trim)
                objDatos.SESPLN = objData("SESPLN").ToString.Trim
                objDatos.FATALM = HelpClass.CFecha_de_8_a_10(objData("FATALM").ToString.Trim)
                objDatos.HATALM = IIf(objData("HATALM").ToString.Trim = "00:00:00", "", objData("HATALM").ToString.Trim) 'objData("HATALM").ToString.Trim
                objDatos.FSLALM = HelpClass.CFecha_de_8_a_10(objData("FSLALM").ToString.Trim)
                objDatos.HSLALM = IIf(objData("HSLALM").ToString.Trim = "00:00:00", "", objData("HSLALM").ToString.Trim) 'objData("HSLALM").ToString.Trim
                objDatos.NGUITR = objData("NGUITR").ToString.Trim
                objDatos.SEGUIMIENTO = objData("SEGUIMIENTO").ToString.Trim
                objDatos.GPSLAT = objData("GPSLAT").ToString.Trim
                objDatos.GPSLON = objData("GPSLON").ToString.Trim
                objDatos.FECGPS = objData("FECGPS").ToString.Trim
                objDatos.HORGPS = objData("HORGPS").ToString.Trim
                objDatos.NOPRCN = objData("NOPRCN").ToString.Trim
                objDatos.NGUITR = objData("NGUITR").ToString.Trim
                objDatos.CBRCN2 = objData("CBRCN2").ToString.Trim
                objDatos.NORINSS = objData("NORINS").ToString.Trim
                objDatos.NPLNMT = objData("NPLNMT").ToString.Trim
                If objData("CBRCND2").ToString.Trim.Length = 0 Then
                    objDatos.CBRCND2 = objData("CBRCND").ToString.Trim
                Else
                    objDatos.CBRCND2 = objData("CBRCND").ToString.Trim & Chr(10) & objData("CBRCND2").ToString.Trim
                End If
                objDatos.NGSGWP = objData("NGSGWP").ToString.Trim
                objDatos.NCOREG = objData("NCOREG")
                objDatos.CTRSPT = objData("CTRSPT")
                'objDatos.UNIDADES = objData("UNIDADES")
                objGenericCollection.Add(objDatos)
            Next
        Catch ex As Exception
            Return New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        End Try
        Return objGenericCollection
    End Function

    Public Function Listar_Estado_Solicitud_Requerimiento(ByVal objEntidad As AtencionRequerimiento) As List(Of AtencionRequerimiento)
        Dim dt As New DataTable
        Dim objParam As New Parameter
        Dim Lista As New List(Of AtencionRequerimiento)
        Dim Entidad As AtencionRequerimiento

        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PNNUMREQT", objEntidad.NUMREQT)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_ESTADO_SOLIC_REQ", objParam)

        For Each Item As DataRow In dt.Rows
            Entidad = New AtencionRequerimiento

            Entidad.CCMPN = Item("CCMPN")
            Entidad.NUMREQT = Item("NUMREQT")
            Entidad.SESREQ = Item("SESREQ")
            Entidad.NCSOTR = Item("NCSOTR")
            Entidad.SJTTR = Item("SJTTR")
            'Entidad.SESSLC = Item("SESSLC")
            Entidad.SESTRG = Item("SESTRG")

            Lista.Add(Entidad)

        Next

        Return Lista
    End Function

    Public Function intActualizar_OS_Requerimiento(ByVal objEntidad As AtencionRequerimiento) As Integer
        Dim objParam As New Parameter

        objParam.Add("PSNUMREQT", objEntidad.NUMREQT)
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PNQSLCIT", objEntidad.QSLCIT)
        objParam.Add("PNNDCORM", objEntidad.NDCORM)
        objParam.Add("PSPNCDTR", objEntidad.PNCDTR)
        objParam.Add("PSCUSOSAR", objEntidad.CUSOSAR)
        objParam.Add("PNNORSRT", objEntidad.NORSRT)
        objParam.Add("PNCLCLOR", objEntidad.CLCLOR)
        objParam.Add("PNCLCLDS", objEntidad.CLCLDS)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_OS_REQUERIMIENTO_UPDATE", objParam)
        Return 1
    End Function

    Public Function Lista_Atencion_Requerimiento_Detalle_Exportar(ByVal beEntidad As AtencionRequerimiento) As DataTable 'List(Of AtencionRequerimiento)

        Dim dt As New DataTable
        Dim objParam As New Parameter
       
        objParam.Add("PSCCMPN", beEntidad.CCMPN)
        objParam.Add("PSCDVSN", beEntidad.CDVSN)
        objParam.Add("PNCPLNDV", beEntidad.CPLNDV)
        objParam.Add("PNCCLNT", beEntidad.CCLNT)

        objParam.Add("PSSESREQ", beEntidad.SESREQ)
        objParam.Add("PSSPRSTR", beEntidad.SPRSTR)

        objParam.Add("PNFECREQ_INI", beEntidad.FECREQ_INI)
        objParam.Add("PNFECREQ_FIN", beEntidad.FECREQ_FIN)

        objParam.Add("PNHRAREQ_INI", beEntidad.HRAREQ_INI)
        objParam.Add("PNHRAREQ_FIN", beEntidad.HRAREQ_FIN)

        objParam.Add("PNFCHATN_INI", beEntidad.FCHATN_INI)
        objParam.Add("PNFCHATN_FIN", beEntidad.FCHATN_FIN)

        objParam.Add("PNHRAATN_INI", beEntidad.HRAATN_INI)
        objParam.Add("PNHRAATN_FIN", beEntidad.HRAATN_FIN)

        objParam.Add("PNNUMREQT", beEntidad.NUMREQT)
        objParam.Add("PNNCSOTR", beEntidad.NCSOTR)

        objParam.Add("PSCRGVTA", beEntidad.CRGVTA)
        objParam.Add("PSSJTTR", beEntidad.SJTTR)
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(beEntidad.CCMPN)
        dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_ATENCION_REQUERIMIENTO_LIST_DETALLE_EXPORTAR", objParam)

        For Each Item As DataRow In dt.Rows
            Item("FECREQ_REQ") = HelpClass.FechaNum_a_Fecha(Item("FECREQ_REQ"))
            Item("HRAREQ_REQ") = IIf(Item("HRAREQ_REQ") = 0, "", HelpClass.HoraNum_a_Hora(CLng(Item("HRAREQ_REQ"))).ToString)
            Item("FCHATN_REQ") = HelpClass.FechaNum_a_Fecha(Item("FCHATN_REQ"))
            Item("HRAATN_REQ") = IIf(Item("HRAATN_REQ") = 0, "", HelpClass.HoraNum_a_Hora(CLng(Item("HRAATN_REQ"))).ToString)
            Item("NORSRT_REQ") = Item("NORSRT_REQ")
            Item("CLCLOR_SREQ") = Item("CLCLOR_SREQ").ToString.Trim
            Item("CLCLDS_SREQ") = Item("CLCLDS_SREQ").ToString.Trim
            Item("NDCORM_REQ") = Item("NDCORM_REQ").ToString.Trim
            If Item("CUSOSAR_REQ").ToString.Trim & " - " & HelpClass.FechaNum_a_Fecha(Item("FCHOSAR_REQ")) & " - " & IIf(Item("HRAOSAR_REQ") = 0, "", HelpClass.HoraNum_a_Hora(CLng(Item("HRAOSAR_REQ"))).ToString) = " -  - " Then
                Item("CUSOSAR_REQ") = ""
            Else
                Item("CUSOSAR_REQ") = Item("CUSOSAR_REQ").ToString.Trim & " - " & HelpClass.FechaNum_a_Fecha(Item("FCHOSAR_REQ")) & " - " & IIf(Item("HRAOSAR_REQ") = 0, "", HelpClass.HoraNum_a_Hora(CLng(Item("HRAOSAR_REQ"))).ToString)
            End If
            Item("CLCLOR_SREQ") = Item("CLCLOR_SREQ").ToString.Trim
            'Entidad.CLCLDS = Item("CLCLDS")
            Item("CLCLDS_SREQ") = Item("CLCLDS_SREQ").ToString.Trim
            Item("TDRCOR_REQ") = Item("TDRCOR_REQ").ToString.Trim
            Item("TDRENT_REQ") = Item("TDRENT_REQ").ToString.Trim

            'Entidad.TIPSRV = Item("TIPSRV") 'Tipo req.
            'Entidad.TIPSRV_S = Item("TIPSRV_S") 'Tipo req.

            Item("REFDO1_REQ") = Item("REFDO1_REQ").ToString.Trim 'Doc.Referencia
            Item("TOBERV_REQ") = Item("TOBERV_REQ").ToString.Trim     'Observaciones

            'Entidad.SESREQ = Item("SESREQ") 'Estado Req.
            Item("SESREQ_SREQ") = Item("SESREQ_SREQ").ToString.Trim

            'Entidad.SESTRG = Item("SESTRG")
            Item("CUSCRT_REQ") = Item("CUSCRT_REQ").ToString.Trim & " - " & HelpClass.CNumero8Digitos_a_FechaDefault(CLng(Item("FCHCRT_REQ"))).ToString & " - " & IIf(Item("HRACRT_REQ") = 0, "", HelpClass.HoraNum_a_Hora(CLng(Item("HRACRT_REQ"))).ToString)
            'Entidad.FCHCRT = Item("FCHCRT")
            'Entidad.HRACRT = Item("HRACRT")
            'Entidad.NTRMCR = Item("NTRMCR")
            If Item("CULUSA_REQ").ToString.Trim & " - " & HelpClass.FechaNum_a_Fecha(Item("FULTAC_REQ")) & " - " & IIf(Item("HULTAC_REQ") = 0, "", HelpClass.HoraNum_a_Hora(CLng(Item("HULTAC_REQ"))).ToString) = " -  - " Then
                Item("CULUSA_REQ") = ""
            Else
                Item("CULUSA_REQ") = Item("CULUSA_REQ").ToString.Trim & " - " & HelpClass.FechaNum_a_Fecha(Item("FULTAC_REQ")) & " - " & IIf(Item("HULTAC_REQ") = 0, "", HelpClass.HoraNum_a_Hora(CLng(Item("HULTAC_REQ"))).ToString)
            End If

            'Entidad.FULTAC = Item("FULTAC")
            'Entidad.HULTAC = Item("HULTAC")
            'Entidad.NTRMNL = Item("NTRMNL")

            'Entidad.QSLCIT = Item("QSLCIT")
            'Entidad.CMEDTR = Item("CMEDTR")
            'Entidad.TNMMDT = Item("TNMMDT")

            'Entidad.CUNDMD = Item("CUNDMD").ToString

            ''Entidad.CUNDVH = Item("CUNDVH").ToString.Trim
            ''Item("CUNDVH") = Item("CUNDVH").ToString.Trim
            'Entidad.QMRCDR = CDec(Val(Item("QMRCDR").ToString))

            'Item("CMRCDR") = CDec(Val(Item("CMRCDR").ToString.Trim))
            'Item("CMRCDR_D") = Item("CMRCDR_D").ToString.Trim

            'Item("CTPOSR") = Item("CTPOSR").ToString.Trim

            'Entidad.CUBORI = CDec(Val(Item("CUBORI").ToString))
            'Item("CUBORI_S") = Item("CUBORI_S").ToString.Trim
            'Entidad.CUBDES = CDec(Val(Item("CUBDES").ToString))
            'Item("CUBDES_S") = Item("CUBDES_S").ToString.Trim

            'Entidad.NSECREV = Item("NSECREV")
            'Entidad.FSECREV_D = HelpClass.CNumero8Digitos_a_FechaDefault(CLng(Item("FSECREV"))).ToString

            'Item("PNCDTR") = Item("PNCDTR").ToString.Trim

            'Entidad.QUNIDJUNTA = Item("QUNIDJUNTA")
            'Entidad.QUNIDSOLICITADAS = Item("QUNIDSOLICITADAS")
            'Entidad.QUNIDATENDIDAS = Item("QATNAN")

            'Item("TOBERV") = Item("TOBERV").ToString.Trim
            'Item("PRSCNT") = Item("PRSCNT").ToString.Trim

            'Entidad.CRGVTA = Item("CRGVTA")
            'Item("TCRVTA") = Item("TCRVTA").ToString.Trim
            'Item("TIRALC") = Item("TIRALC").ToString.Trim

            'Entidad.CCLNFC = Item("CCLNFC")
            'Item("CCLNFC_S") = Item("CCLNFC_S").ToString.Trim
            'Entidad.NROENV = Item("NROENV")
            'Item("SJTTR") = Item("SJTTR").ToString.Trim
            'Entidad.SOLICT = Item("SOLICT")
            'Entidad.NORSRTSR = Item("NORSRTSR")
            'Entidad.CLCLORSR = Item("CLCLORSR")
            'Item("CLCLORSR_S") = Item("CLCLORSR_S").ToString.Trim
            'Entidad.CLCLDSSR = Item("CLCLDSSR")
            'Entidad.CLCLDSSR_S = Item("CLCLDSSR_S").ToString.Trim
            'Entidad.NDCORMSR = Item("NDCORMSR")
            'Entidad.PNCDTRSR = Item("PNCDTRSR")

            '*************************************SOLICITUD***********************************'
            Item("NCSOTR_SOL") = ("" & Item("NCSOTR_SOL")).ToString.Trim
            Item("FECOST_SOL") = HelpClass.FechaNum_a_Fecha(Item("FECOST_SOL"))
            'Item("HRAOTR") = HelpClass.HoraNum_a_Hora_Default(Item("HRAOTR")).ToString.Trim
            'Item("FINCRG") = HelpClass.CFecha_de_8_a_10(Item("FINCRG").ToString).ToString.Trim
            'Item("HINCIN") = HelpClass.HoraNum_a_Hora_Default(Item("HINCIN")).ToString.Trim
            'Item("FENTCL") = HelpClass.CFecha_de_8_a_10(Item("FENTCL").ToString).ToString.Trim
            'Item("HRAENT") = HelpClass.HoraNum_a_Hora_Default(Item("HRAENT")).ToString.Trim
            'Item("CLCLOR") = Item("CLCLOR").ToString.Trim
            'Item("TDRCOR") = Item("TDRCOR").ToString.Trim
            'Item("CLCLDS") = Item("CLCLDS").ToString.Trim
            'Item("TDRENT") = Item("TDRENT").ToString.Trim
            'Item("CMRCDR") = Item("CMRCDR").ToString.Trim
            'Item("CUNDMD") = Item("CUNDMD").ToString.Trim
            Item("QANPRG_SOL") = CType(Val("" & Item("QANPRG_SOL")), Integer).ToString
            Item("QSLCIT_SOL") = CType(Val("" & Item("QSLCIT_SOL")), Integer).ToString
            Item("QATNAN_SOL") = CType(Val("" & Item("QATNAN_SOL")), Integer).ToString
            'Item("QMRCDR") = Item("QMRCDR").ToString.Trim
            'Item("SESSLC") = Item("SESSLC").ToString.Trim
            Item("NORSRT_SOL") = Val("" & Item("NORSRT_SOL"))

            'Item("CTPOSR") = Item("CTPOSR").ToString.Trim
            'If Item("TOBS").ToString.Trim.Length > 50 Then
            '    Item("TOBS") = Item("TOBS").ToString.Trim.Substring(0, 50) & "..."
            'Else
            '    Item("TOBS") = Item("TOBS").ToString.Trim
            'End If

            'Item("CANTOP") = Item("CANTOP").ToString.Trim
            'Item("CCMPN") = Item("CCMPN").ToString.Trim
            'Item("CDVSN") = Item("CDVSN").ToString.Trim
            'Item("SFCRTV") = Item("SFCRTV").ToString.Trim
            'Item("CCTCSC") = Item("CCTCSC").ToString.Trim
            'Item("CMEDTR") = Item("CMEDTR").ToString.Trim
            'Item("TNMMDT") = Item("TNMMDT").ToString.Trim

            'Item("FULTAC") = Item("CULUSA").ToString & " - " & HelpClass.CNumero8Digitos_a_Fecha(Item("FULTAC2")).ToString & " - " & HelpClass.HoraNum_a_Hora_Default(Item("HULTAC2")).ToString
            ''objDatos.NCTZCN = objData("NCTZCN").ToString.Trim

            'Item("UBIGEO_O") = Item("UBIGEO_O").ToString.Trim
            'Item("UBIGEO_D") = Item("UBIGEO_D").ToString.Trim
            'Item("NDCORM") = Val(Item("NDCORM").ToString.Trim)
            'Item("NUMREQT") = Val(Item("NUMREQT").ToString.Trim)

            '**********************************UNIDADES ASIGNADAS*******************************'
            'Item("NCSOTR2") = Item("NCSOTR").ToString.Trim
            'Item("NCRRSR") = Item("NCRRSR").ToString.Trim
            'Item("NPLNJT") = Item("NPLNJT").ToString.Trim
            'Item("NCRRPL") = Item("NCRRPL").ToString.Trim
            'Item("NRUCTR") = Item("NRUCTR").ToString.Trim
            Item("TCMTRT") = ("" & Item("TCMTRT")).ToString.Trim
            Item("NPLCUN") = ("" & Item("NPLCUN")).ToString.Trim
            Item("NPLCAC") = ("" & Item("NPLCAC")).ToString.Trim
            Item("CBRCND") = ("" & Item("CBRCNT")).ToString.Trim
            Item("CBRCNT") = ("" & Item("CBRCND")).ToString.Trim

            Item("FASGTR") = HelpClass.FechaNum_a_Fecha(Item("FASGTR"))
            Item("HASGTR") = IIf(("" & Item("HASGTR")).ToString.Trim = "00:00:00", "", ("" & Item("HASGTR")).ToString.Trim)
            'NewRows("SESPLN") = Item("SESPLN").ToString.Trim
            'Item("FATALM") = HelpClass.CFecha_de_8_a_10(Item("FATALM").ToString.Trim)
            'Item("HATALM") = IIf(Item("HATALM").ToString.Trim = "00:00:00", "", Item("HATALM").ToString.Trim) 'objData("HATALM").ToString.Trim
            'Item("FSLALM") = HelpClass.CFecha_de_8_a_10(Item("FSLALM").ToString.Trim)
            'Item("HSLALM") = IIf(Item("HSLALM").ToString.Trim = "00:00:00", "", Item("HSLALM").ToString.Trim) 'objData("HSLALM").ToString.Trim

            If ("" & Item("CBRCND2")).ToString.Trim.Length = 0 Then
                Item("CBRCND2") = ("" & Item("CBRCND")).ToString.Trim
            Else
                Item("CBRCND2") = ("" & Item("CBRCND")).ToString.Trim & Chr(10) & ("" & Item("CBRCND2")).ToString.Trim
            End If


        Next

        Return dt

    End Function

    Public Function Obtener_Datos_OrdenServicio_Requerimiento(ByVal beEntidad As AtencionRequerimiento) As DataTable 'List(Of AtencionRequerimiento)

        Dim dt As New DataTable
        Dim objParam As New Parameter

        objParam.Add("PSCCMPN", beEntidad.CCMPN)
        objParam.Add("PNNUMREQT", beEntidad.NUMREQT)
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(beEntidad.CCMPN)
        dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_DATOS_OS_ATENCION_REQUERIMIENTO", objParam)
        Return dt

    End Function

End Class
