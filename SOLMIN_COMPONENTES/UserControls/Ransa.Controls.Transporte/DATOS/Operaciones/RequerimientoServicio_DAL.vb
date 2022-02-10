Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.Utilitario

Public Class RequerimientoServicio_DAL
    Private objSql As New SqlManager

    Public Function Lista_Requerimiento_Servicio(ByVal beEntidad As RequerimientoServicio) As DataTable 'List(Of RequerimientoServicio)

        Dim dt As New DataTable
        Dim objParam As New Parameter
        '' Dim Lista As New List(Of RequerimientoServicio)
        ''Dim Entidad As RequerimientoServicio

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
        dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_REQUERIMIENTO_SERVICIO_LIST", objParam)

        For Each Item As DataRow In dt.Rows
            'Entidad = New RequerimientoServicio

            'Entidad.CCMPN = Item("CCMPN")
            'Entidad.CCMPN_S = Item("CCMPN_S")
            'Entidad.NCSOTR = Item("NCSOTR")
            'Entidad.NUMREQT = Item("NUMREQT")
            Item("FECREQ") = HelpClassST.CNumero8Digitos_a_Fecha(CLng(Item("FECREQ"))).ToString
            Item("HRAREQ") = IIf(Item("HRAREQ") = 0, "", HelpClassST.HoraNum_a_Hora_Default(CLng(Item("HRAREQ"))).ToString)
            'Entidad.CDVSN = Item("CDVSN")
            'Entidad.CDVSN_S = Item("CDVSN_S")
            ''Entidad.CPLNDV = Item("CPLNDV")
            'Entidad.CPLNDV_S = Item("CPLNDV_S")
            ''Entidad.CCLNT = Item("CCLNT")
            ''Entidad.CCLNT_S = Item("CCLNT_S")

            Item("FCHATN") = HelpClass.CNumero8Digitos_a_FechaDefault(CLng(Item("FCHATN"))).ToString
            Item("HRAATN") = IIf(Item("HRAATN") = 0, "", HelpClass.HoraNum_a_Hora(CLng(Item("HRAATN"))).ToString)

            ''Entidad.SPRSTR = Item("SPRSTR")
            ''Entidad.SPRSTR_S = Item("SPRSTR_S")

            ''Entidad.TIPOCNT = Item("TIPOCNT")   'Tipo mercaderia
            ''Entidad.TIPOCNT_S = Item("TIPOCNT_S")
            ''Entidad.NMRGIM = Item("NMRGIM")
            ''Entidad.QPSOMR = Item("QPSOMR")
            'Entidad.QMTLRG = Item("QMTLRG")
            'Entidad.QMTALT = Item("QMTALT")
            'Entidad.QMTANC = Item("QMTANC")

            'Entidad.NRCTSL = Item("NRCTSL") ' Nro. de Contrato SOLMIN
            'Entidad.NRTFSV = Item("NRTFSV")  'Nro. Tarifa X Servicio
            'Entidad.NCRRSR = Item("NCRRSR") 'Numero Correlativo del Servicio

            ''Entidad.NORSRT = Item("NORSRT")  'O/S
            ''Entidad.NDCORM = Item("NDCORM")  'O/S Agencia   

            ''Entidad.CLCLOR = Item("CLCLOR")
            Item("CLCLOR_S") = Item("CLCLOR_S").ToString.Trim
            ''Entidad.CLCLDS = Item("CLCLDS")
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

            Item("CUNDVH") = Item("CUNDVH").ToString.Trim
            'Item("CUNDVH") = Item("CUNDVH").ToString.Trim
            Item("CUNDVH_D") = Item("CUNDVH_D").ToString.Trim
            'Entidad.QMRCDR = CDec(Val(Item("QMRCDR").ToString))

            Item("CMRCDR") = CDec(Val(Item("CMRCDR").ToString.Trim))
            Item("CMRCDR_D") = Item("CMRCDR_D").ToString.Trim

            Item("CTPOSR") = Item("CTPOSR").ToString.Trim

            'Entidad.CUBORI = CDec(Val(Item("CUBORI").ToString))
            Item("CUBORI_S") = Item("CUBORI_S").ToString.Trim
            'Entidad.CUBDES = CDec(Val(Item("CUBDES").ToString))
            Item("CUBDES_S") = Item("CUBDES_S").ToString.Trim

            ''Entidad.NSECREV = Item("NSECREV")
            ''Entidad.FSECREV_D = HelpClass.CNumero8Digitos_a_FechaDefault(CLng(Item("FSECREV"))).ToString

            Item("PNCDTR") = Item("PNCDTR").ToString.Trim

            'Entidad.QUNIDJUNTA = Item("QUNIDJUNTA")
            'Entidad.QUNIDSOLICITADAS = Item("QUNIDSOLICITADAS")
            'Item(QUNIDATENDIDAS = Item("QATNAN")

            Item("TOBERV") = Item("TOBERV").ToString.Trim
            Item("PRSCNT") = Item("PRSCNT").ToString.Trim

            'Entidad.CRGVTA = Item("CRGVTA")
            Item("TCRVTA") = Item("TCRVTA").ToString.Trim
            Item("TIRALC") = Item("TIRALC").ToString.Trim

            'Entidad.CCLNFC = Item("CCLNFC")
            Item("CCLNFC_S") = Item("CCLNFC_S").ToString.Trim
            'Entidad.NROENV = Item("NROENV")
            Item("SJTTR") = Item("SJTTR").ToString.Trim
            'Entidad.SOLICT = Item("SOLICT")
            ''Entidad.NORSRTSR = Item("NORSRTSR")


            'Entidad.CLCLORSR = Item("CLCLORSR")
            ''Entidad.CLCLORSR_S = Item("CLCLORSR_S").ToString.Trim
            ''Entidad.CLCLDSSR = Item("CLCLDSSR")
            ''Entidad.CLCLDSSR_S = Item("CLCLDSSR_S").ToString.Trim

            ''Entidad.NDCORMSR = Item("NDCORMSR")  'O/S Agencia   
            ''Entidad.PNCDTRSR = Item("PNCDTRSR")
            'Lista.Add(Entidad)


        Next

        Return dt

    End Function


    Public Function Lista_Tipo_Mercaderia() As DataTable

        Dim dt As New DataTable
        Dim objParam As New Parameter
        dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_TIPO_MERCADERIA_LIST", objParam)
        Return dt

    End Function

    Public Sub intActualizarRequerimientoServicio(ByVal obeRequerimiento As RequerimientoServicio)

        Dim objParam As New Parameter
        objParam.Add("PNNUMREQT", obeRequerimiento.NUMREQT)
        objParam.Add("PSCCMPN", obeRequerimiento.CCMPN)

        objParam.Add("PNFECREQ", obeRequerimiento.FECREQ)
        objParam.Add("PNHRAREQ", obeRequerimiento.HRAREQ)

        objParam.Add("PSCDVSN", obeRequerimiento.CDVSN)
        objParam.Add("PNCPLNDV", obeRequerimiento.CPLNDV)
        objParam.Add("PNCCLNT", obeRequerimiento.CCLNT)

        objParam.Add("PNFCHATN", obeRequerimiento.FCHATN)
        objParam.Add("PNHRAATN", obeRequerimiento.HRAATN)

        objParam.Add("PSSPRSTR", obeRequerimiento.SPRSTR)
        objParam.Add("PSTIPOCNT", obeRequerimiento.TIPOCNT)
        objParam.Add("PNQPSOMR", obeRequerimiento.QPSOMR)
        'objParam.Add("PNQMTLRG", obeRequerimiento.QMTLRG)
        'objParam.Add("PNQMTALT", obeRequerimiento.QMTALT)
        'objParam.Add("PNQMTANC", obeRequerimiento.QMTANC)

        'objParam.Add("PNNRCTSL", obeRequerimiento.NRCTSL)
        'objParam.Add("PNNRTFSV", obeRequerimiento.NRTFSV)
        'objParam.Add("PNNCRRSR", obeRequerimiento.NCRRSR)

        objParam.Add("PNNORSRT", obeRequerimiento.NORSRT)
        objParam.Add("PNNDCORM", obeRequerimiento.NDCORM)
        objParam.Add("PSPNCDTR", obeRequerimiento.PNCDTR)
        objParam.Add("PNCLCLOR", obeRequerimiento.CLCLOR)
        objParam.Add("PNCLCLDS", obeRequerimiento.CLCLDS)
        objParam.Add("PSTDRCOR", obeRequerimiento.TDRCOR)
        objParam.Add("PSTDRENT", obeRequerimiento.TDRENT)

        objParam.Add("PSTIPSRV", obeRequerimiento.TIPSRV)
        objParam.Add("PSREFDO1", obeRequerimiento.REFDO1)
        objParam.Add("PSTOBS", obeRequerimiento.TOBS)
        objParam.Add("PSSESREQ", obeRequerimiento.SESREQ)
        objParam.Add("PSUSUARIO", obeRequerimiento.CULUSA)
        objParam.Add("PSNTRMNL", obeRequerimiento.NTRMNL)

        objParam.Add("PNCMEDTR", obeRequerimiento.CMEDTR)
        objParam.Add("PNQSLCIT", obeRequerimiento.QSLCIT)

        objParam.Add("PSTOBERV", obeRequerimiento.TOBERV)
        objParam.Add("PSPRSCNT", obeRequerimiento.PRSCNT)

        objParam.Add("PSTIRALC", obeRequerimiento.TIRALC)

        '  objParam.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obeRequerimiento.CCMPN)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_REQUERIMIENTO_SERVICIO_UPDATE", objParam)

        '  Return objSql.ParameterCollection("PSRESULT")

    End Sub

    Public Function intInsertarRequerimientoServicio(ByVal obeRequerimiento As RequerimientoServicio) As Decimal

        Dim objParam As New Parameter

        objParam.Add("PSCCMPN", obeRequerimiento.CCMPN)

        objParam.Add("PNFECREQ", obeRequerimiento.FECREQ)
        objParam.Add("PNHRAREQ", obeRequerimiento.HRAREQ)

        objParam.Add("PSCDVSN", obeRequerimiento.CDVSN)
        objParam.Add("PNCPLNDV", obeRequerimiento.CPLNDV)
        objParam.Add("PNCCLNT", obeRequerimiento.CCLNT)

        objParam.Add("PNFCHATN", obeRequerimiento.FCHATN)
        objParam.Add("PNHRAATN", obeRequerimiento.HRAATN)

        objParam.Add("PSSPRSTR", obeRequerimiento.SPRSTR)
        objParam.Add("PSTIPOCNT", obeRequerimiento.TIPOCNT)
        objParam.Add("PNQPSOMR", obeRequerimiento.QPSOMR)
        'objParam.Add("PNQMTLRG", obeRequerimiento.QMTLRG)
        'objParam.Add("PNQMTALT", obeRequerimiento.QMTALT)
        'objParam.Add("PNQMTANC", obeRequerimiento.QMTANC)

        'objParam.Add("PNNRCTSL", obeRequerimiento.NRCTSL)
        'objParam.Add("PNNRTFSV", obeRequerimiento.NRTFSV)
        'objParam.Add("PNNCRRSR", obeRequerimiento.NCRRSR)

        objParam.Add("PNNORSRT", obeRequerimiento.NORSRT)
        objParam.Add("PNNDCORM", obeRequerimiento.NDCORM)
        objParam.Add("PSPNCDTR", obeRequerimiento.PNCDTR)
        objParam.Add("PNCLCLOR", obeRequerimiento.CLCLOR)
        objParam.Add("PNCLCLDS", obeRequerimiento.CLCLDS)
        objParam.Add("PSTDRCOR", obeRequerimiento.TDRCOR)
        objParam.Add("PSTDRENT", obeRequerimiento.TDRENT)

        objParam.Add("PSTIPSRV", obeRequerimiento.TIPSRV)
        objParam.Add("PSREFDO1", obeRequerimiento.REFDO1)
        objParam.Add("PSTOBS", obeRequerimiento.TOBS)
        objParam.Add("PSSESREQ", obeRequerimiento.SESREQ)
        objParam.Add("PSUSUARIO", obeRequerimiento.CUSCRT)
        objParam.Add("PSNTRMNL", obeRequerimiento.NTRMCR)

        objParam.Add("PNCMEDTR", obeRequerimiento.CMEDTR)
        objParam.Add("PNQSLCIT", obeRequerimiento.QSLCIT)

        objParam.Add("PSTOBERV", obeRequerimiento.TOBERV)
        objParam.Add("PSPRSCNT", obeRequerimiento.PRSCNT)

        objParam.Add("PSTIRALC", obeRequerimiento.TIRALC)

        objParam.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obeRequerimiento.CCMPN)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_REQUERIMIENTO_SERVICIO_INSERT", objParam)

        Return objSql.ParameterCollection("PSRESULT")

    End Function

    Public Function intEliminarRequerimientoServicio(ByVal obeRequerimiento As RequerimientoServicio) As Integer

        Dim objParam As New Parameter

        objParam.Add("PNNUMREQT", obeRequerimiento.NUMREQT)
        objParam.Add("PSCCMPN", obeRequerimiento.CCMPN)
        objParam.Add("PSUSUARIO", obeRequerimiento.CUSCRT)
        objParam.Add("PSNTRMNL", obeRequerimiento.NTRMCR)

        'objParam.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obeRequerimiento.CCMPN)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_REQUERIMIENTO_SERVICIO_DELETE", objParam)
        Return 1 'objSql.ParameterCollection("PSRESULT")
    End Function

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

    Public Function intActualizarRequerimientoSolicitud(ByVal obeRequerimiento As RequerimientoServicio) As Integer

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

    Public Function Registrar_Solicitud_Transporte_Requerimiento(ByVal objEntidad As Operaciones.Solicitud_Transporte) As Operaciones.Solicitud_Transporte
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

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            'ejecuta el procedimiento almacenado
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_SOLICITUD_TRANSPORTE_REQUERIMIENTO", objParam)
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

    Public Function Lista_Requerimiento_Servicio_Estado_Actual(ByVal beEntidad As RequerimientoServicio) As RequerimientoServicio

        Dim dt As New DataTable
        Dim objParam As New Parameter
        Dim Entidad As New RequerimientoServicio

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

    Public Function olisListarResponsables(ByVal oResponsable As beDestinatario) As List(Of beDestinatario)
        Dim oDt As New DataTable
        Dim olbeDestinatario As New List(Of beDestinatario)
        Dim objDestinatario As beDestinatario
        Dim objParam As New Parameter

        objParam.Add("PNCCLNT", oResponsable.PNCCLNT)
        objParam.Add("PSTIPPROC", oResponsable.PSTIPPROC)

        oDt = objSql.ExecuteDataTable("SP_SOLSC_LISTAR_RESPONSABLES_REQSERV", objParam)

        For Each fila As DataRow In oDt.Rows
            objDestinatario = New beDestinatario

            objDestinatario.PSEMAILTO = fila("EMAILTO").ToString.Trim
            objDestinatario.PSNLTECL = fila("NLTECL")
            objDestinatario.PSTIPPROC = fila("TIPPROC")
            objDestinatario.PSTNMYAP = fila("TNMYAP").ToString.Trim
            objDestinatario.PSNCRRIT = fila("NCRRIT")

            olbeDestinatario.Add(objDestinatario)
        Next

        Return olbeDestinatario

    End Function


    Public Function Listar_Solicitudes_Transporte_Estado_Requerimiento(ByVal objParametros As Operaciones.Solicitud_Transporte) As List(Of Operaciones.Solicitud_Transporte)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of Operaciones.Solicitud_Transporte)
        Dim objParam As New Parameter
        Dim objDatos As Operaciones.Solicitud_Transporte

        objParam.Add("PNNUMREQT", objParametros.NUMREQT)
        '===========================================
        'ejecuta el procedimiento almacenado
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros.CCMPN) 'objParametros(5)

        'Obteniendo resultados
        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SOLICITUD_TRANSP_LA_REQ", objParam)
        'Procesandolos como una Lista
        For Each objData As DataRow In objDataTable.Rows
            objDatos = New Operaciones.Solicitud_Transporte
            objDatos.NCSOTR = objData("NCSOTR").ToString.Trim
            objDatos.CCLNT = objData("CCLNT").ToString.Trim
            objDatos.FECOST = HelpClass.CFecha_de_8_a_10(objData("FECOST").ToString).ToString.Trim
            objDatos.HRAOTR = HelpClassST.HoraNum_a_Hora_Default(objData("HRAOTR")).ToString.Trim
            objDatos.FINCRG = HelpClassST.CFecha_de_8_a_10(objData("FINCRG").ToString).ToString.Trim
            objDatos.HINCIN = HelpClassST.HoraNum_a_Hora_Default(objData("HINCIN")).ToString.Trim
            objDatos.FENTCL = HelpClassST.CFecha_de_8_a_10(objData("FENTCL").ToString).ToString.Trim
            objDatos.HRAENT = HelpClassST.HoraNum_a_Hora_Default(objData("HRAENT")).ToString.Trim
            objDatos.CLCLOR = objData("CLCLOR").ToString.Trim
            objDatos.TDRCOR = objData("TDRCOR").ToString.Trim
            objDatos.CLCLDS = objData("CLCLDS").ToString.Trim
            objDatos.TDRENT = objData("TDRENT").ToString.Trim
            objDatos.CMRCDR = objData("CMRCDR").ToString.Trim
            objDatos.CUNDMD = objData("CUNDMD").ToString.Trim
            objDatos.QSLCIT = CType(objData("QSLCIT"), Integer).ToString
            objDatos.QATNAN = CType(objData("QATNAN"), Integer).ToString
            objDatos.QANPRG = objData("QANPRG")
            objDatos.QMRCDR = objData("QMRCDR").ToString.Trim
            objDatos.SESSLC = objData("SESSLC").ToString.Trim
            objDatos.NORSRT = objData("NORSRT").ToString.Trim
            objDatos.CTPOSR = objData("CTPOSR").ToString.Trim
            If objData("TOBS").ToString.Trim.Length > 50 Then
                objDatos.TOBS = objData("TOBS").ToString.Trim.Substring(0, 50) & "..."
            Else
                objDatos.TOBS = objData("TOBS").ToString.Trim
            End If
            objDatos.CANTOP = objData("CANTOP").ToString.Trim
            objDatos.CCMPN = objData("CCMPN").ToString.Trim
            objDatos.CDVSN = objData("CDVSN").ToString.Trim
            objDatos.CPLNDV = objData("CPLNDV")
            objDatos.SFCRTV = objData("SFCRTV").ToString.Trim
            objDatos.CCTCSC = objData("CCTCSC").ToString.Trim
            objDatos.CMEDTR = objData("CMEDTR").ToString.Trim
            objDatos.TNMMDT = objData("TNMMDT").ToString.Trim
            objDatos.CLCLOR_C = objData("CLCLOR_C")
            objDatos.CLCLDS_C = objData("CLCLDS_C")
            objDatos.CUSCRT = objData("CUSCRT")
            objDatos.TRFRN = objData("TRFRN")
            objDatos.SESTRG = objData("SESTRG")
            objDatos.FULTAC = objData("CULUSA").ToString & " - " & HelpClassST.CNumero8Digitos_a_Fecha(objData("FULTAC")).ToString & " - " & HelpClassST.HoraNum_a_Hora_Default(objData("HULTAC")).ToString
            objDatos.SPRSTR = objData("SPRSTR")
            'objDatos.NCTZCN = objData("NCTZCN").ToString.Trim

            objDatos.CUBORI = objData("CUBORI")
            objDatos.UBIGEO_O = objData("UBIGEO_O").ToString.Trim
            objDatos.CUBDES = objData("CUBDES")
            objDatos.UBIGEO_D = objData("UBIGEO_D").ToString.Trim

            objDatos.NDCORM = Val(objData("NDCORM").ToString.Trim)
            objDatos.NUMREQT = Val(objData("NUMREQT").ToString.Trim)
            objDatos.UNIDADES = Val(objData("UNIDADES"))
            objGenericCollection.Add(objDatos)
        Next
        Return objGenericCollection
    End Function

    Public Function Obtener_Detalle_Solicitud_Asignada(ByVal objEntidad As mantenimientos.ClaseGeneral) As List(Of mantenimientos.ClaseGeneral)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of mantenimientos.ClaseGeneral)
        Dim objParam As New Parameter
        Dim objDatos As mantenimientos.ClaseGeneral
        Try
            objParam.Add("PNNCSOTR", objEntidad.NCSOTR)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_SOLICITUD_ASIGNADA_LA", objParam)

            For Each objData As DataRow In objDataTable.Rows
                objDatos = New mantenimientos.ClaseGeneral
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
            Return New List(Of mantenimientos.ClaseGeneral)
        End Try
        Return objGenericCollection
    End Function

    Public Function Lista_Unidades_Programadas(ByVal CCMPN As String, ByVal NUMREQT As String, ByVal SESASG As String) As List(Of Programacion_Unidad)

        Dim objParam As New Parameter
        Dim Lista As New List(Of Programacion_Unidad)
        Dim Entida As Programacion_Unidad
        Dim dt As New DataTable

        objParam.Add("PSCCMPN", CCMPN)
        objParam.Add("PNNUMREQT", NUMREQT)
        objParam.Add("PSSESASG", SESASG)

        dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_JUNTA_X_REQUERIMIENTO_UNIDADES_PROGRAMADAS_LIST_UC", objParam)

        For Each fila As DataRow In dt.Rows

            Entida = New Programacion_Unidad
            Entida.NPLNJT = fila("NPLNJT")
            Entida.NCRRPL = fila("NCRRPL")
            Entida.NUMREQT = fila("NUMREQT")
            Entida.NCRRPA = fila("NCRRPA")
            Entida.FPRASG = fila("FPRASG")
            Entida.FPRASG_D = HelpClass.CNumero8Digitos_a_FechaDefault(CLng(fila("FPRASG"))).ToString()
            Entida.NRUCTR = fila("NRUCTR")
            Entida.TCMTRT = fila("TCMTRT").ToString.Trim
            Entida.NPLCUN = fila("NPLCUN")
            Entida.NPLCAC = fila("NPLCAC")
            Entida.CBRCNT = fila("CBRCNT")
            Entida.TNMCMC = fila("TNMCMC").ToString.Trim
            Entida.CBRCN2 = fila("CBRCN2")
            Entida.TNMCMC2 = fila("TNMCMC2").ToString.Trim
            Entida.TOBS = fila("TOBS")
            Entida.SESASG = fila("SESASG")
            If fila("SESASG").ToString.Trim = "P" Then
                Entida.SESASG_D = "Programado"
            Else
                Entida.SESASG_D = "Asignado"
            End If
            Entida.SESTRG = fila("SESTRG")
            Entida.NOPRCN = fila("NOPRCN")
            Lista.Add(Entida)
        Next
        Return Lista

    End Function

    Public Function Listar_Estado_Solicitud_Requerimiento(ByVal objEntidad As Operaciones.Solicitud_Transporte) As List(Of Operaciones.Solicitud_Transporte)
        Dim dt As New DataTable
        Dim objParam As New Parameter
        Dim Lista As New List(Of Operaciones.Solicitud_Transporte)
        Dim Entidad As Operaciones.Solicitud_Transporte

        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PNNUMREQT", objEntidad.NUMREQT)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_ESTADO_SOLIC_REQ", objParam)

        For Each Item As DataRow In dt.Rows
            Entidad = New Operaciones.Solicitud_Transporte

            Entidad.CCMPN = Item("CCMPN")
            Entidad.NUMREQT = Item("NUMREQT")
            Entidad.SESREQ = Item("SESREQ")
            Entidad.NCSOTR = Item("NCSOTR")
            Entidad.SJTTR = Item("SJTTR")
            Entidad.SESSLC = Item("SESSLC")
            Entidad.SESTRG = Item("SESTRG")

            Lista.Add(Entidad)

        Next

        Return Lista
    End Function

    Public Function Obtener_Detalle_Solicitud_Asignada_X_Requerimiento(ByVal objEntidad As mantenimientos.ClaseGeneral) As List(Of mantenimientos.ClaseGeneral)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of mantenimientos.ClaseGeneral)
        Dim objParam As New Parameter
        Dim objDatos As mantenimientos.ClaseGeneral
        Try
            objParam.Add("PNNUMREQT", objEntidad.NUMREQT)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_SOLICITUD_ASIGNADA_LA_X_REQ", objParam)

            For Each objData As DataRow In objDataTable.Rows
                objDatos = New mantenimientos.ClaseGeneral
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
            Return New List(Of mantenimientos.ClaseGeneral)
        End Try
        Return objGenericCollection
    End Function

    Public Function Obtener_NroImagen_X_Requerimiento_Servicio(ByVal beEntidad As RequerimientoServicio) As List(Of RequerimientoServicio)
        Dim dt As New DataTable
        Dim objParam As New Parameter
        Dim Lista As New List(Of RequerimientoServicio)
        Dim Entidad As RequerimientoServicio

        objParam.Add("PSCCMPN", beEntidad.CCMPN)
        objParam.Add("PNNUMREQT", beEntidad.NUMREQT)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(beEntidad.CCMPN)
        dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_OBTENER_IMAGEN_REQUERIMIENTO", objParam)

        For Each Item As DataRow In dt.Rows
            Entidad = New RequerimientoServicio
            Entidad.CCMPN = Item("CCMPN")
            Entidad.NUMREQT = Item("NUMREQT")
            Entidad.NMRGIM = Item("NMRGIM")
            Lista.Add(Entidad)
        Next

        Return Lista
    End Function


    Public Function Lista_Prioridad_Requerimiento() As DataTable

        Dim dt As New DataTable
        Dim objParam As New Parameter
        dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_PRIORIDAD_REQ_LIST", objParam)
        Return dt

    End Function

    'Public Function Lista_Requerimiento_Servicio_Exportar(ByVal beEntidad As RequerimientoServicio) As DataTable

    '    Dim dt As New DataTable
    '    Dim objParam As New Parameter
    '    'Dim Lista As New List(Of RequerimientoServicio)
    '    'Dim Entidad As RequerimientoServicio
    '    'Dim oDt As New DataTable
    '    'Dim NewRows As DataRow
    '    'CrearTablaReporteExcel(oDt)

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
    '    objParam.Add("PSSJTTR", beEntidad.SJTTR)

    '    'objParam.Add("PNNOPRCN", beEntidad.NOPRCN)
    '    objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(beEntidad.CCMPN)
    '    dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_REQUERIMIENTO_SERVICIO_LIST_EXPORTAR", objParam)

    '    For Each Item As DataRow In dt.Rows

    '        'NewRows = oDt.NewRow
    '        'NewRows("CCMPN") = Item("CCMPN")
    '        'NewRows("CCMPN_S") = Item("CCMPN_S")
    '        'NewRows("NUMREQT") = Item("NUMREQT")
    '        Item("FECREQ") = HelpClassST.CNumero8Digitos_a_Fecha(CLng(Item("FECREQ"))).ToString
    '        Item("HRAREQ") = IIf(Item("HRAREQ") = 0, "", HelpClassST.HoraNum_a_Hora_Default(CLng(Item("HRAREQ"))).ToString)
    '        'NewRows("CDVSN") = Item("CDVSN")
    '        'NewRows("CDVSN_S") = Item("CDVSN_S")
    '        'NewRows("CPLNDV") = Item("CPLNDV")
    '        'NewRows("CPLNDV_S") = Item("CPLNDV_S")
    '        'NewRows("CCLNT") = Item("CCLNT")
    '        'NewRows("CCLNT_S") = Item("CCLNT_S")
    '        Item("FCHATN") = HelpClass.CNumero8Digitos_a_FechaDefault(CLng(Item("FCHATN"))).ToString
    '        Item("HRAATN") = IIf(Item("HRAATN") = 0, "", HelpClass.HoraNum_a_Hora(CLng(Item("HRAATN"))).ToString)
    '        'NewRows("SPRSTR") = Item("SPRSTR")
    '        'NewRows("SPRSTR_S") = Item("SPRSTR_S")
    '        'NewRows("TIPOCNT") = Item("TIPOCNT")
    '        'NewRows("TIPOCNT_S") = Item("TIPOCNT_S")
    '        'NewRows("NMRGIM") = Item("NMRGIM")
    '        ''NewRows("QPSOMR") = Item("QPSOMR")
    '        ''NewRows("QMTLRG") = Item("QMTLRG")
    '        ''NewRows("QMTALT") = Item("QMTALT")
    '        ''NewRows("QMTANC") = Item("QMTANC")
    '        'NewRows("NORSRT") = Item("NORSRT")
    '        'NewRows("NDCORM") = Item("NDCORM")
    '        'NewRows("CLCLOR") = Item("CLCLOR")
    '        'NewRows("CLCLOR_S") = Item("CLCLOR_S")
    '        ''NewRows("NORSRT") = Item("NORSRT")
    '        ''NewRows("NDCORM") = Item("NDCORM")
    '        ''NewRows("CLCLOR") = Item("CLCLOR")
    '        ''NewRows("CLCLOR_S") = Item("CLCLOR_S").ToString.Trim
    '        'NewRows("CLCLDS") = Item("CLCLDS")
    '        'NewRows("CLCLDS_S") = Item("CLCLDS_S").ToString.Trim
    '        'NewRows("TDRCOR") = Item("TDRCOR").ToString.Trim
    '        'NewRows("TDRENT") = Item("TDRENT").ToString.Trim

    '        'NewRows("TIPSRV") = Item("TIPSRV")
    '        'NewRows("TIPSRV_S") = Item("TIPSRV_S")
    '        'NewRows("REFDO1") = Item("REFDO1").ToString.Trim
    '        'NewRows("TOBS") = Item("TOBS").ToString.Trim
    '        'NewRows("SESREQ") = Item("SESREQ")
    '        'NewRows("SESREQ_S") = Item("SESREQ_S").ToString.Trim
    '        'NewRows("SESTRG") = Item("SESTRG")
    '        Item("CUSCRT") = Item("CUSCRT").ToString.Trim & " - " & HelpClass.CNumero8Digitos_a_FechaDefault(CLng(Item("FCHCRT"))).ToString & " - " & IIf(Item("HRACRT") = 0, "", HelpClass.HoraNum_a_Hora(CLng(Item("HRACRT"))).ToString)
    '        'NewRows("FCHCRT") = Item("FCHCRT")
    '        'NewRows("HRACRT") = Item("HRACRT")
    '        'NewRows("NTRMCR") = Item("NTRMCR")
    '        If Item("CULUSA").ToString.Trim & " - " & HelpClass.CNumero8Digitos_a_FechaDefault(CLng(Item("FULTAC"))).ToString & " - " & IIf(Item("HULTAC") = 0, "", HelpClass.HoraNum_a_Hora(CLng(Item("HULTAC"))).ToString) = " -  - " Then
    '            Item("CULUSA") = ""
    '        Else
    '            Item("CULUSA") = Item("CULUSA").ToString.Trim & " - " & HelpClass.CNumero8Digitos_a_FechaDefault(CLng(Item("FULTAC"))).ToString & " - " & IIf(Item("HULTAC") = 0, "", HelpClass.HoraNum_a_Hora(CLng(Item("HULTAC"))).ToString)
    '        End If

    '        'NewRows("FULTAC") = Item("FULTAC")
    '        'NewRows("HULTAC") = Item("HULTAC")
    '        'NewRows("NTRMNL") = Item("NTRMNL")
    '        'NewRows("QSLCIT") = Item("QSLCIT")
    '        'NewRows("CMEDTR") = Item("CMEDTR")
    '        'NewRows("TNMMDT") = Item("TNMMDT")
    '        'NewRows("CUNDMD") = Item("CUNDMD").ToString
    '        'NewRows("CUNDVH") = Item("CUNDVH").ToString
    '        'NewRows("CUNDVH_D") = Item("CUNDVH_D").ToString
    '        'Item("QMRCDR") = CDec(Val(Item("QMRCDR").ToString))
    '        'Item("CMRCDR") = CDec(Val(Item("CMRCDR").ToString))
    '        'NewRows("CMRCDR_D") = Item("CMRCDR_D").ToString
    '        'NewRows("CTPOSR") = Item("CTPOSR").ToString
    '        'NewRows("CUBORI") = CDec(Val(Item("CUBORI").ToString))
    '        'NewRows("CUBORI_S") = Item("CUBORI_S").ToString
    '        'NewRows("CUBDES") = CDec(Val(Item("CUBDES").ToString))
    '        'NewRows("CUBDES_S") = Item("CUBDES_S").ToString
    '        ' ''NewRows("NSECREV") = Item("NSECREV")
    '        ' ''NewRows("FSECREV_D") = HelpClass.CNumero8Digitos_a_FechaDefault(CLng(Item("FSECREV"))).ToString
    '        'NewRows("PNCDTR") = Item("PNCDTR").ToString
    '        'NewRows("QUNIDJUNTA") = Item("QUNIDJUNTA")
    '        'NewRows("QUNIDSOLICITADAS") = Item("QUNIDSOLICITADAS")
    '        'NewRows("QUNIDATENDIDAS") = Item("QATNAN")
    '        'NewRows("TOBERV") = Item("TOBERV").ToString.Trim
    '        'NewRows("PRSCNT") = Item("PRSCNT").ToString.Trim
    '        'NewRows("CRGVTA") = Item("CRGVTA")
    '        'NewRows("TCRVTA") = Item("TCRVTA").ToString.Trim
    '        'NewRows("TIRALC") = Item("TIRALC").ToString.Trim
    '        'NewRows("CCLNFC") = Item("CCLNFC")
    '        'NewRows("CCLNFC_S") = Item("CCLNFC_S").ToString.Trim
    '        'NewRows("NROENV") = Item("NROENV")
    '        'NewRows("SJTTR") = Item("SJTTR").ToString.Trim
    '        'NewRows("SOLICT") = Item("SOLICT")
    '        'NewRows("NORSRTSR") = Item("NORSRTSR")
    '        'NewRows("CLCLORSR") = Item("CLCLORSR")
    '        'NewRows("CLCLORSR_S") = Item("CLCLORSR_S").ToString.Trim
    '        'NewRows("CLCLDSSR") = Item("CLCLDSSR")
    '        'NewRows("CLCLDSSR_S") = Item("CLCLDSSR_S").ToString.Trim
    '        'NewRows("NDCORMSR") = Item("NDCORMSR")
    '        'NewRows("PNCDTRSR") = Item("PNCDTRSR")

    '        ''oDt.Rows.Add(NewRows)
    '        'Lista.Add(Entidad)

    '    Next

    '    Return dt

    'End Function

    ''Private Sub CrearTablaReporteExcel(ByVal oDt As DataTable)
    ''    oDt.Columns.Add(New DataColumn("CCMPN", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("CCMPN_S", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("NUMREQT", GetType(System.Double)))
    ''    oDt.Columns.Add(New DataColumn("FECREQ_S", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("HRAREQ_S", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("CDVSN", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("CDVSN_S", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("CPLNDV", GetType(System.Double)))
    ''    oDt.Columns.Add(New DataColumn("CPLNDV_S", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("CCLNT", GetType(System.Double)))
    ''    oDt.Columns.Add(New DataColumn("CCLNT_S", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("FCHATN_D", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("HRAATN_D", GetType(System.String)))

    ''    oDt.Columns.Add(New DataColumn("SPRSTR", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("SPRSTR_S", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("TIPOCNT", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("TIPOCNT_S", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("NMRGIM", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("QPSOMR", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("NORSRT", GetType(System.Double)))
    ''    oDt.Columns.Add(New DataColumn("NDCORM", GetType(System.Double)))
    ''    oDt.Columns.Add(New DataColumn("CLCLOR", GetType(System.Double)))
    ''    oDt.Columns.Add(New DataColumn("CLCLOR_S", GetType(System.String)))

    ''    oDt.Columns.Add(New DataColumn("CLCLDS", GetType(System.Double)))
    ''    oDt.Columns.Add(New DataColumn("CLCLDS_S", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("TDRCOR", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("TDRENT", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("TIPSRV", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("TIPSRV_S", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("REFDO1", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("TOBS", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("SESREQ", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("SESREQ_S", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("SESTRG", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("CUSCRT", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("FCHCRT", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("HRACRT", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("NTRMCR", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("CULUSA", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("FULTAC", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("HULTAC", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("NTRMNL", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("QSLCIT", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("CMEDTR", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("TNMMDT", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("CUNDMD", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("CUNDVH", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("CUNDVH_D", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("QMRCDR", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("CMRCDR", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("CMRCDR_D", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("CTPOSR", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("CUBORI", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("CUBORI_S", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("CUBDES", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("CUBDES_S", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("PNCDTR", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("QUNIDJUNTA", GetType(System.Double)))
    ''    oDt.Columns.Add(New DataColumn("QUNIDSOLICITADAS", GetType(System.Double)))
    ''    oDt.Columns.Add(New DataColumn("QUNIDATENDIDAS", GetType(System.Double)))
    ''    oDt.Columns.Add(New DataColumn("TOBERV", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("PRSCNT", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("CRGVTA", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("TCRVTA", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("TIRALC", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("CCLNFC", GetType(System.Double)))
    ''    oDt.Columns.Add(New DataColumn("CCLNFC_S", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("NROENV", GetType(System.Double)))
    ''    oDt.Columns.Add(New DataColumn("SJTTR", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("SOLICT", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("NORSRTSR", GetType(System.Double)))
    ''    oDt.Columns.Add(New DataColumn("CLCLORSR", GetType(System.Double)))
    ''    oDt.Columns.Add(New DataColumn("CLCLORSR_S", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("CLCLDSSR", GetType(System.Double)))
    ''    oDt.Columns.Add(New DataColumn("CLCLDSSR_S", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("NDCORMSR", GetType(System.String)))
    ''    oDt.Columns.Add(New DataColumn("PNCDTRSR", GetType(System.String)))

    ''End Sub

    Public Function Lista_Requerimiento_Servicio_Detalle_Exportar(ByVal beEntidad As RequerimientoServicio) As DataTable

        Dim dt As New DataTable
        Dim objParam As New Parameter
        'Dim Lista As New List(Of RequerimientoServicio)
        'Dim Entidad As RequerimientoServicio
        'Dim oDt As New DataTable
        'Dim NewRows As DataRow
        'CrearTablaReporteDetalladoExcel(oDt)

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
        dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_REQUERIMIENTO_SERVICIO_LIST_DETALLE_EXPORTAR", objParam)

        For Each Item As DataRow In dt.Rows
            'NewRows = oDt.NewRow
            'NewRows("CCMPN") = Item("CCMPN")
            'NewRows("CCMPN_S") = Item("CCMPN_S")
            'NewRows("NUMREQT") = Item("NUMREQT")
            Item("FECREQ") = HelpClassST.CNumero8Digitos_a_Fecha(CLng(Item("FECREQ"))).ToString
            Item("HRAREQ") = IIf(Item("HRAREQ") = 0, "", HelpClassST.HoraNum_a_Hora_Default(CLng(Item("HRAREQ"))).ToString)
            'NewRows("CDVSN") = Item("CDVSN")
            'NewRows("CDVSN_S") = Item("CDVSN_S")
            'NewRows("CPLNDV") = Item("CPLNDV")
            'NewRows("CPLNDV_S") = Item("CPLNDV_S")
            'NewRows("CCLNT") = Item("CCLNT")
            'NewRows("CCLNT_S") = Item("CCLNT_S")
            Item("FCHATN") = HelpClass.CNumero8Digitos_a_FechaDefault(CLng(Item("FCHATN"))).ToString
            Item("HRAATN") = IIf(Item("HRAATN") = 0, "", HelpClass.HoraNum_a_Hora(CLng(Item("HRAATN"))).ToString)
            'NewRows("SPRSTR") = Item("SPRSTR")
            'NewRows("SPRSTR_S") = Item("SPRSTR_S")
            'NewRows("TIPOCNT") = Item("TIPOCNT")
            'NewRows("TIPOCNT_S") = Item("TIPOCNT_S")
            'NewRows("NMRGIM") = Item("NMRGIM")
            'NewRows("QPSOMR") = Item("QPSOMR")
            'NewRows("NORSRT") = Item("NORSRT")
            'NewRows("NDCORM") = Item("NDCORM")
            'NewRows("CLCLOR") = Item("CLCLOR")
            'NewRows("CLCLOR_S") = Item("CLCLOR_S")
            'NewRows("CLCLDS") = Item("CLCLDS")
            'NewRows("CLCLDS_S") = Item("CLCLDS_S").ToString.Trim
            'NewRows("TDRCOR") = Item("TDRCOR").ToString.Trim
            'NewRows("TDRENT") = Item("TDRENT").ToString.Trim

            'NewRows("TIPSRV") = Item("TIPSRV")
            'NewRows("TIPSRV_S") = Item("TIPSRV_S")
            'NewRows("REFDO1") = Item("REFDO1").ToString.Trim
            'NewRows("TOBS") = Item("TOBS").ToString.Trim
            'NewRows("SESREQ") = Item("SESREQ")
            'NewRows("SESREQ_S") = Item("SESREQ_S").ToString.Trim
            'NewRows("SESTRG") = Item("SESTRG")
            Item("CUSCRT") = Item("CUSCRT").ToString.Trim & " - " & HelpClass.CNumero8Digitos_a_FechaDefault(CLng(Item("FCHCRT"))).ToString & " - " & IIf(Item("HRACRT") = 0, "", HelpClass.HoraNum_a_Hora(CLng(Item("HRACRT"))).ToString)
            'NewRows("FCHCRT") = Item("FCHCRT")
            'NewRows("HRACRT") = Item("HRACRT")
            'NewRows("NTRMCR") = Item("NTRMCR")
            If Item("CULUSA").ToString.Trim & " - " & HelpClass.CNumero8Digitos_a_FechaDefault(CLng(Item("FULTAC"))).ToString & " - " & IIf(Item("HULTAC") = 0, "", HelpClass.HoraNum_a_Hora(CLng(Item("HULTAC"))).ToString) = " -  - " Then
                Item("CULUSA") = ""
            Else
                Item("CULUSA") = Item("CULUSA").ToString.Trim & " - " & HelpClass.CNumero8Digitos_a_FechaDefault(CLng(Item("FULTAC"))).ToString & " - " & IIf(Item("HULTAC") = 0, "", HelpClass.HoraNum_a_Hora(CLng(Item("HULTAC"))).ToString)
            End If

            'NewRows("FULTAC") = Item("FULTAC")
            'NewRows("HULTAC") = Item("HULTAC")
            'NewRows("NTRMNL") = Item("NTRMNL")
            'NewRows("QSLCIT") = Item("QSLCIT")
            'NewRows("CMEDTR") = Item("CMEDTR")
            'NewRows("TNMMDT") = Item("TNMMDT")
            'NewRows("CUNDMD") = Item("CUNDMD").ToString
            'NewRows("CUNDVH") = Item("CUNDVH").ToString
            'NewRows("CUNDVH_D") = Item("CUNDVH_D").ToString
            Item("QMRCDR") = CDec(Val(Item("QMRCDR").ToString))
            Item("CMRCDR") = CDec(Val(Item("CMRCDR").ToString))
            'NewRows("CMRCDR_D") = Item("CMRCDR_D").ToString
            'NewRows("CTPOSR") = Item("CTPOSR").ToString
            Item("CUBORI") = CDec(Val(Item("CUBORI").ToString))
            'NewRows("CUBORI_S") = Item("CUBORI_S").ToString
            Item("CUBDES") = CDec(Val(Item("CUBDES").ToString))
            'NewRows("CUBDES_S") = Item("CUBDES_S").ToString
            ''NewRows("NSECREV") = Item("NSECREV")
            ''NewRows("FSECREV_D") = HelpClass.CNumero8Digitos_a_FechaDefault(CLng(Item("FSECREV"))).ToString
            'NewRows("PNCDTR") = Item("PNCDTR").ToString
            'NewRows("QUNIDJUNTA") = Item("QUNIDJUNTA")
            'NewRows("QUNIDSOLICITADAS") = Item("QUNIDSOLICITADAS")
            'NewRows("QUNIDATENDIDAS") = Item("QATNAN")
            'NewRows("TOBERV") = Item("TOBERV").ToString.Trim
            'NewRows("PRSCNT") = Item("PRSCNT").ToString.Trim
            'NewRows("CRGVTA") = Item("CRGVTA")
            'NewRows("TCRVTA") = Item("TCRVTA").ToString.Trim
            'NewRows("TIRALC") = Item("TIRALC").ToString.Trim
            'NewRows("CCLNFC") = Item("CCLNFC")
            'NewRows("CCLNFC_S") = Item("CCLNFC_S").ToString.Trim
            'NewRows("NROENV") = Item("NROENV")
            'NewRows("SJTTR") = Item("SJTTR").ToString.Trim
            'NewRows("SOLICT") = Item("SOLICT")
            'NewRows("NORSRTSR") = Item("NORSRTSR")
            'NewRows("CLCLORSR") = Item("CLCLORSR")
            'NewRows("CLCLORSR_S") = Item("CLCLORSR_S").ToString.Trim
            'NewRows("CLCLDSSR") = Item("CLCLDSSR")
            'NewRows("CLCLDSSR_S") = Item("CLCLDSSR_S").ToString.Trim
            'NewRows("NDCORMSR") = Item("NDCORMSR")
            'NewRows("PNCDTRSR") = Item("PNCDTRSR")

            '**************************SOLICITUD*******************************'
            'NewRows("NCSOTR") = Item("NCSOTR").ToString.Trim
            'NewRows("CCLNT") = Item("CCLNT").ToString.Trim
            Item("FECOST") = HelpClass.CFecha_de_8_a_10(Item("FECOST").ToString).ToString.Trim
            Item("HRAOTR") = HelpClassST.HoraNum_a_Hora_Default(Item("HRAOTR")).ToString.Trim
            Item("FINCRG") = HelpClassST.CFecha_de_8_a_10(Item("FINCRG").ToString).ToString.Trim
            Item("HINCIN") = HelpClassST.HoraNum_a_Hora_Default(Item("HINCIN")).ToString.Trim
            Item("FENTCL") = HelpClassST.CFecha_de_8_a_10(Item("FENTCL").ToString).ToString.Trim
            Item("HRAENT") = HelpClassST.HoraNum_a_Hora_Default(Item("HRAENT")).ToString.Trim
            'NewRows("CLCLOR") = Item("CLCLOR").ToString.Trim
            'NewRows("TDRCOR") = Item("TDRCOR").ToString.Trim
            'NewRows("CLCLDS") = Item("CLCLDS").ToString.Trim
            'NewRows("TDRENT") = Item("TDRENT").ToString.Trim
            'NewRows("CMRCDR") = Item("CMRCDR").ToString.Trim
            'NewRows("CUNDMD") = Item("CUNDMD").ToString.Trim
            Item("QSLCIT") = CType(Item("QSLCIT"), Integer).ToString
            Item("QATNAN") = CType(Item("QATNAN"), Integer).ToString
            'NewRows("QANPRG") = Item("QANPRG")
            'NewRows("QMRCDR") = Item("QMRCDR").ToString.Trim
            'NewRows("SESSLC") = Item("SESSLC").ToString.Trim
            'NewRows("NORSRT") = Item("NORSRT").ToString.Trim
            'NewRows("CTPOSR") = Item("CTPOSR").ToString.Trim
            If Item("TOBS").ToString.Trim.Length > 50 Then
                Item("TOBS") = Item("TOBS").ToString.Trim.Substring(0, 50) & "..."
            Else
                Item("TOBS") = Item("TOBS").ToString.Trim
            End If
            'NewRows("CANTOP") = Item("CANTOP").ToString.Trim
            'NewRows("CCMPN") = Item("CCMPN").ToString.Trim
            'NewRows("CDVSN") = Item("CDVSN").ToString.Trim
            'NewRows("CPLNDV") = Item("CPLNDV")
            'NewRows("SFCRTV") = Item("SFCRTV").ToString.Trim
            'NewRows("CCTCSC") = Item("CCTCSC").ToString.Trim
            'NewRows("CMEDTR") = Item("CMEDTR").ToString.Trim
            'NewRows("TNMMDT") = Item("TNMMDT").ToString.Trim
            'NewRows("CLCLOR_C") = Item("CLCLOR_C")
            'NewRows("CLCLDS_C") = Item("CLCLDS_C")
            'NewRows("CUSCRT") = Item("CUSCRT")
            'NewRows("TRFRN") = Item("TRFRN")
            'NewRows("SESTRG") = Item("SESTRG")
            Item("FULTAC") = Item("CULUSA").ToString & " - " & HelpClassST.CNumero8Digitos_a_Fecha(Item("FULTAC")).ToString & " - " & HelpClassST.HoraNum_a_Hora_Default(Item("HULTAC")).ToString
            'NewRows("SPRSTR") = Item("SPRSTR")
            ''objDatos.NCTZCN = objData("NCTZCN").ToString.Trim

            'NewRows("CUBORI") = Item("CUBORI")
            'NewRows("UBIGEO_O") = Item("UBIGEO_O").ToString.Trim
            'NewRows("CUBDES") = Item("CUBDES")
            'NewRows("UBIGEO_D") = Item("UBIGEO_D").ToString.Trim

            'NewRows("NDCORM") = Val(Item("NDCORM").ToString.Trim)
            'NewRows("NUMREQT") = Val(Item("NUMREQT").ToString.Trim)
            'NewRows("UNIDADES") = Val(Item("UNIDADES"))

            '****************************UNIDADES ASIGNADAS****************************'
            'NewRows("NCRRSR") = Item("NCRRSR").ToString.Trim
            'NewRows("NPLNJT") = Item("NPLNJT").ToString.Trim
            'NewRows("NCRRPL") = Item("NCRRPL").ToString.Trim
            'NewRows("NRUCTR") = Item("NRUCTR").ToString.Trim
            'NewRows("TCMTRT") = Item("TCMTRT").ToString.Trim
            'NewRows("NPLCUN") = Item("NPLCUN").ToString.Trim
            'NewRows("NPLCAC") = Item("NPLCAC").ToString.Trim
            'NewRows("CBRCND") = Item("CBRCNT").ToString.Trim
            'NewRows("CBRCNT") = Item("CBRCND").ToString.Trim
            Item("FASGTR") = HelpClass.CFecha_de_8_a_10(Item("FASGTR").ToString.Trim)
            Item("HASGTR") = IIf(Item("HASGTR").ToString.Trim = "00:00:00", "", Item("HASGTR").ToString.Trim)
            'NewRows("SESPLN") = Item("SESPLN").ToString.Trim
            Item("FATALM") = HelpClass.CFecha_de_8_a_10(Item("FATALM").ToString.Trim)
            Item("HATALM") = IIf(Item("HATALM").ToString.Trim = "00:00:00", "", Item("HATALM").ToString.Trim) 'objData("HATALM").ToString.Trim
            Item("FSLALM") = HelpClass.CFecha_de_8_a_10(Item("FSLALM").ToString.Trim)
            Item("HSLALM") = IIf(Item("HSLALM").ToString.Trim = "00:00:00", "", Item("HSLALM").ToString.Trim) 'objData("HSLALM").ToString.Trim
            'NewRows("NGUITR") = Item("NGUITR").ToString.Trim
            'NewRows("SEGUIMIENTO") = Item("SEGUIMIENTO").ToString.Trim
            'NewRows("GPSLAT") = Item("GPSLAT").ToString.Trim
            'NewRows("GPSLON") = Item("GPSLON").ToString.Trim
            'NewRows("FECGPS") = Item("FECGPS").ToString.Trim
            'NewRows("HORGPS") = Item("HORGPS").ToString.Trim
            'NewRows("NOPRCN") = Item("NOPRCN").ToString.Trim
            'NewRows("NGUITR") = Item("NGUITR").ToString.Trim
            'NewRows("CBRCN2") = Item("CBRCN2").ToString.Trim
            'NewRows("NORINSS") = Item("NORINS").ToString.Trim
            'NewRows("NPLNMT") = Item("NPLNMT").ToString.Trim
            If Item("CBRCND2").ToString.Trim.Length = 0 Then
                Item("CBRCND2") = Item("CBRCND").ToString.Trim
            Else
                Item("CBRCND2") = Item("CBRCND").ToString.Trim & Chr(10) & Item("CBRCND2").ToString.Trim
            End If
            'NewRows("NGSGWP") = Item("NGSGWP").ToString.Trim
            'NewRows("NCOREG") = Item("NCOREG")
            'NewRows("CTRSPT") = Item("CTRSPT")
            'oDt.Rows.Add(NewRows)

        Next

        Return dt
    End Function

    Private Sub CrearTablaReporteDetalladoExcel(ByVal oDt As DataTable)
        oDt.Columns.Add(New DataColumn("CCMPN", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CCMPN_S", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("NUMREQT", GetType(System.Double)))
        oDt.Columns.Add(New DataColumn("FECREQ_S", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("HRAREQ_S", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CDVSN", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CPLNDV", GetType(System.Double)))
        oDt.Columns.Add(New DataColumn("CPLNDV_S", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CCLNT", GetType(System.Double)))
        oDt.Columns.Add(New DataColumn("CCLNT_S", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("FCHATN_D", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("HRAATN_D", GetType(System.String)))

        oDt.Columns.Add(New DataColumn("SPRSTR", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("SPRSTR_S", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("TIPOCNT", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("TIPOCNT_S", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("NMRGIM", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("QPSOMR", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("NORSRT", GetType(System.Double)))
        oDt.Columns.Add(New DataColumn("NDCORM", GetType(System.Double)))
        oDt.Columns.Add(New DataColumn("CLCLOR", GetType(System.Double)))
        oDt.Columns.Add(New DataColumn("CLCLOR_S", GetType(System.String)))

        oDt.Columns.Add(New DataColumn("CLCLDS", GetType(System.Double)))
        oDt.Columns.Add(New DataColumn("CLCLDS_S", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("TDRCOR", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("TDRENT", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("TIPSRV", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("TIPSRV_S", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("REFDO1", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("TOBS", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("SESREQ", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("SESREQ_S", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("SESTRG", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CUSCRT", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("FCHCRT", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("HRACRT", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("NTRMCR", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CULUSA", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("FULTAC", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("HULTAC", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("NTRMNL", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("QSLCIT", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CMEDTR", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("TNMMDT", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CUNDMD", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CUNDVH", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CUNDVH_D", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("QMRCDR", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CMRCDR", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CMRCDR_D", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CTPOSR", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CUBORI", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CUBORI_S", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CUBDES", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CUBDES_S", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("PNCDTR", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("QUNIDJUNTA", GetType(System.Double)))
        oDt.Columns.Add(New DataColumn("QUNIDSOLICITADAS", GetType(System.Double)))
        oDt.Columns.Add(New DataColumn("QUNIDATENDIDAS", GetType(System.Double)))
        oDt.Columns.Add(New DataColumn("TOBERV", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("PRSCNT", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CRGVTA", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("TCRVTA", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("TIRALC", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CCLNFC", GetType(System.Double)))
        oDt.Columns.Add(New DataColumn("CCLNFC_S", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("NROENV", GetType(System.Double)))
        oDt.Columns.Add(New DataColumn("SJTTR", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("SOLICT", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("NORSRTSR", GetType(System.Double)))
        oDt.Columns.Add(New DataColumn("CLCLORSR", GetType(System.Double)))
        oDt.Columns.Add(New DataColumn("CLCLORSR_S", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CLCLDSSR", GetType(System.Double)))
        oDt.Columns.Add(New DataColumn("CLCLDSSR_S", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("NDCORMSR", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("PNCDTRSR", GetType(System.String)))
        '******************************SOLICITUD********************************'
        oDt.Columns.Add(New DataColumn("NCSOTR", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CCLNT", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("FECOST", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("HRAOTR", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("FINCRG", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("HINCIN", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("FENTCL", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("HRAENT", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CLCLOR", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("TDRCOR", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CLCLDS", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("TDRENT", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CMRCDR", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CUNDMD", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("QSLCIT", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("QATNAN", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("QANPRG", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("QMRCDR", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("SESSLC", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("NORSRT", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CTPOSR", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("TOBS", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CANTOP", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CCMPN", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CDVSN", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CPLNDV", GetType(System.Double)))
        oDt.Columns.Add(New DataColumn("SFCRTV", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CCTCSC", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CMEDTR", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("TNMMDT", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CLCLOR_C", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CLCLDS_C", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CUSCRT", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("TRFRN", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("SESTRG", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("FULTAC", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("SPRSTR", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CUBORI", GetType(System.Double)))
        oDt.Columns.Add(New DataColumn("UBIGEO_O", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CUBDES", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("UBIGEO_D", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("NDCORM", GetType(System.Double)))
        oDt.Columns.Add(New DataColumn("NUMREQT", GetType(System.Double)))
        oDt.Columns.Add(New DataColumn("UNIDADES", GetType(System.Double)))
        '******************************UNIDADES ASIGNADAS********************************'
        oDt.Columns.Add(New DataColumn("NCRRSR", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("NPLNJT", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("NCRRPL", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("NRUCTR", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("TCMTRT", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("NPLCUN", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("NPLCAC", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CBRCND", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CBRCNT", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("FASGTR", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("HASGTR", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("SESPLN", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("FATALM", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("HATALM", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("FSLALM", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("HSLALM", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("SEGUIMIENTO", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("GPSLAT", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("GPSLON", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("FECGPS", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("HORGPS", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("NOPRCN", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("NGUITR", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CBRCN2", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("NORINSS", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("NPLNMT", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("CBRCND2", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("NGSGWP", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("NCOREG", GetType(System.Double)))
        oDt.Columns.Add(New DataColumn("CTRSPT", GetType(System.Double)))

    End Sub


End Class
