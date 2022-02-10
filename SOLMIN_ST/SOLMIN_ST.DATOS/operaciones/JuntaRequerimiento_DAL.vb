Imports SOLMIN_ST.ENTIDADES
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.Utilitario

Public Class JuntaRequerimiento_DAL

    Private objSql As New SqlManager

    Public Sub Insertar_Requerimientos_X_Junta(ByVal Entidad As JuntaRequerimiento)

        Dim objParam As New Parameter

        objParam.Add("PNNPLNJT", Entidad.NPLNJT)
        objParam.Add("PNNCRRPL", Entidad.NCRRPL)
        objParam.Add("PNNUMREQT", Entidad.NUMREQT)
        objParam.Add("PNQANPRG", Entidad.QANPRG)
        objParam.Add("PSCUSCRT", Entidad.CUSCRT)
        objParam.Add("PSNTRMCR", Entidad.NTRMCR)

        objSql.ExecuteNonQuery("SP_SOLMIN_ST_REQUERIMIENTOS_X_JUNTA_INSERT", objParam)


    End Sub

    Public Function Lista_Requerimientos_X_Junta(ByVal Entidad As JuntaRequerimiento) As List(Of JuntaRequerimiento)

        Dim objParam As New Parameter
        Dim Lista As New List(Of JuntaRequerimiento)
        Dim Entida As JuntaRequerimiento
        Dim dt As New DataTable

        objParam.Add("PNNPLNJT", Entidad.NPLNJT)
        objParam.Add("PNNCRRPL", Entidad.NCRRPL)

        dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_JUNTA_X_REQUERIMIENTO_LIST", objParam)

        For Each fila As DataRow In dt.Rows

            Entida = New JuntaRequerimiento
            Entida.NPLNJT = fila("NPLNJT")
            Entida.NCRRPL = fila("NCRRPL")
            Entida.NUMREQT = fila("NUMREQT")
            Entida.QANPRG = Val(fila("QANPRG"))
            'Entida.QATNAN = Val(fila("QATNAN"))
            Entida.SESTRG = fila("SESTRG")
            If fila("SESTRG") = "A" Then
                Entida.SESTRG_D = "Activo"
            Else
                Entida.SESTRG_D = ""
            End If

            Entida.CMEDTR = fila("CMEDTR")
            Entida.CMEDTR_D = fila("CMEDTR_D").ToString.Trim
            Entida.NORSRT = fila("NORSRT")
            Entida.CLCLOR = fila("CLCLOR")
            Entida.CLCLOR_D = fila("CLCLOR_D").ToString.Trim
            Entida.CLCLDS = fila("CLCLDS")
            Entida.CLCLDS_D = fila("CLCLDS_D").ToString.Trim

            Entida.QMTALT = fila("QMTALT")
            Entida.QMTANC = fila("QMTANC")
            Entida.QMTLRG = fila("QMTLRG")
            Entida.QPSOMR = fila("QPSOMR")

            Entida.FECREQ = fila("FECREQ")
            Entida.FECREQ_S = HelpClass.CNumero8Digitos_a_FechaDefault(CLng(fila("FECREQ"))).ToString
            Entida.HRAREQ = fila("HRAREQ")
            Entida.HRAREQ_S = IIf(fila("HRAREQ") = 0, "", HelpClass.HoraNum_a_Hora(CLng(fila("HRAREQ"))).ToString)

            Entida.FCHATN = fila("FCHATN")
            Entida.FCHATN_D = HelpClass.CNumero8Digitos_a_FechaDefault(CLng(fila("FCHATN"))).ToString
            Entida.HRAATN = fila("HRAATN")
            Entida.HRAATN_D = IIf(fila("HRAATN") = 0, "", HelpClass.HoraNum_a_Hora(CLng(fila("HRAATN"))).ToString)

            Entida.UNIDADES = fila("UNIDADES")

            Lista.Add(Entida)

        Next

        Return Lista

    End Function

    Public Function Eliminar_Requerimientos_X_Junta(ByVal Entidad As JuntaRequerimiento) As Int32

        Dim objParam As New Parameter
        Dim Respuesta As Int32 = 0

        objParam.Add("PNNPLNJT", Entidad.NPLNJT)
        objParam.Add("PNNCRRPL", Entidad.NCRRPL)
        objParam.Add("PNNUMREQT", Entidad.NUMREQT)
        objParam.Add("PSUSUARIO", Entidad.CULUSA)
        objParam.Add("PSTERMINAL", Entidad.NTRMNL)
        objParam.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_REQUERIMIENTOS_X_JUNTA_ELIMINAR", objParam)
        Respuesta = objSql.ParameterCollection("PSRESULT")
        Return Respuesta

    End Function

    Public Function Lista_Requerimiento_X_Junta_RZOL48(ByVal beEntidad As AtencionRequerimiento) As List(Of AtencionRequerimiento)

        Dim dt As New DataTable
        Dim objParam As New Parameter
        Dim Lista As New List(Of AtencionRequerimiento)
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
        objParam.Add("PNNPLNJT", beEntidad.NPLNJT)
        objParam.Add("PNNCRRPL", beEntidad.NCRRPL)

        'objParam.Add("PNNCSOTR", beEntidad.NCSOTR)

        dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_REQUERIMIENTO_X_JUNTA_LIST", objParam)

        For Each Item As DataRow In dt.Rows
            Entidad = New AtencionRequerimiento

            Entidad.CCMPN = Item("CCMPN")
            Entidad.CCMPN_S = Item("CCMPN_S")
            'Entidad.NCSOTR = Item("NCSOTR")
            Entidad.NUMREQT = Item("NUMREQT")

            Entidad.FECREQ_S = HelpClass.CNumero8Digitos_a_FechaDefault(CLng(Item("FECREQ"))).ToString
            Entidad.HRAREQ_S = IIf(Item("HRAREQ") = 0, "", HelpClass.HoraNum_a_Hora(CLng(Item("HRAREQ"))).ToString)

            Entidad.CDVSN = Item("CDVSN")
            Entidad.CDVSN_S = Item("CDVSN_S")
            Entidad.CPLNDV = Item("CPLNDV")
            Entidad.CPLNDV_S = Item("CPLNDV_S")
            Entidad.CCLNT = Item("CCLNT")
            Entidad.CCLNT_S = Item("CCLNT_S")

            Entidad.FCHATN_D = HelpClass.CNumero8Digitos_a_FechaDefault(CLng(Item("FCHATN"))).ToString
            Entidad.HRAATN_D = IIf(Item("HRAATN") = 0, "", HelpClass.HoraNum_a_Hora(CLng(Item("HRAATN"))).ToString)

            Entidad.SPRSTR = Item("SPRSTR")
            Entidad.SPRSTR_S = Item("SPRSTR_S")

            Entidad.TIPOCNT = Item("TIPOCNT")   'Tipo mercaderia
            Entidad.TIPOCNT_S = Item("TIPOCNT_S")

            Entidad.QPSOMR = Item("QPSOMR")
            Entidad.QMTLRG = Item("QMTLRG")
            Entidad.QMTALT = Item("QMTALT")
            Entidad.QMTANC = Item("QMTANC")

            'Entidad.NRCTSL = Item("NRCTSL") ' Nro. de Contrato SOLMIN
            'Entidad.NRTFSV = Item("NRTFSV")  'Nro. Tarifa X Servicio
            'Entidad.NCRRSR = Item("NCRRSR") 'Numero Correlativo del Servicio

            Entidad.NORSRT = Item("NORSRT")  'O/S
            Entidad.NDCORM = Item("NDCORM")  'O/S Agencia   

            Entidad.CLCLOR = Item("CLCLOR")
            Entidad.CLCLOR_S = Item("CLCLOR_S").ToString.Trim
            Entidad.CLCLDS = Item("CLCLDS")
            Entidad.CLCLDS_S = Item("CLCLDS_S").ToString.Trim
            Entidad.TDRCOR = Item("TDRCOR")
            Entidad.TDRENT = Item("TDRENT")

            Entidad.TIPSRV = Item("TIPSRV") 'Tipo req.
            Entidad.TIPSRV_S = Item("TIPSRV_S") 'Tipo req.

            Entidad.REFDO1 = Item("REFDO1").ToString.Trim 'Doc.Referencia
            Entidad.TOBS = Item("TOBS").ToString.Trim     'Observaciones

            Entidad.SESREQ = Item("SESREQ") 'Estado Req.
            Entidad.SESREQ_S = Item("SESREQ_S").ToString.Trim

            Entidad.SESTRG = Item("SESTRG")
            Entidad.CUSCRT = Item("CUSCRT")
            Entidad.FCHCRT = Item("FCHCRT")
            Entidad.HRACRT = Item("HRACRT")
            Entidad.NTRMCR = Item("NTRMCR")
            Entidad.CULUSA = Item("CULUSA")
            Entidad.FULTAC = Item("FULTAC")
            Entidad.HULTAC = Item("HULTAC")
            Entidad.NTRMNL = Item("NTRMNL")

            Entidad.QSLCIT = Item("QSLCIT")
            Entidad.CMEDTR = Item("CMEDTR")
            Entidad.CUNDVH = CDec(Val(Item("CUNDVH").ToString.Trim))
            Entidad.CUNDMD = Item("CUNDMD").ToString
            Entidad.CMRCDR = CDec(Val(Item("CMRCDR").ToString.Trim))
            Entidad.CTPOSR = Item("CTPOSR").ToString.Trim

            Entidad.CUBORI = CDec(Val(Item("CUBORI").ToString))
            Entidad.CUBORI_S = Item("CUBORI_S").ToString.Trim
            Entidad.CUBDES = CDec(Val(Item("CUBDES").ToString))
            Entidad.CUBDES_S = Item("CUBDES_S").ToString.Trim

            'Entidad.NSECREV = Item("NSECREV")
            'Entidad.FSECREV_D = HelpClass.CNumero8Digitos_a_FechaDefault(CLng(Item("FSECREV"))).ToString

            Entidad.PNCDTR = Item("PNCDTR").ToString.Trim

            Lista.Add(Entidad)

        Next

        Return Lista

    End Function

    Public Function Listar_Junta_Transporte(ByVal objParamList As List(Of String)) As List(Of ENTIDADES.Operaciones.Junta_Transporte)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of ENTIDADES.Operaciones.Junta_Transporte)
        Dim objDatos As ENTIDADES.Operaciones.Junta_Transporte
        Dim objParam As New Parameter
        'Try
        objParam.Add("PNNPLNJT", objParamList(0))
        objParam.Add("PSSESPLN", objParamList(1))
        If objParamList(2) <> "" And objParamList(3) <> "" Then
            objParam.Add("PNFECINI", objParamList(2))
            objParam.Add("PNFECFIN", objParamList(3))
        Else
            objParam.Add("PNFECINI", 0D)
            objParam.Add("PNFECFIN", 0D)
        End If
        objParam.Add("PSCCMPN", objParamList(4))
        objParam.Add("PSCDVSN", objParamList(5))
        objParam.Add("PNCPLNDV", objParamList(6))
        objParam.Add("PNNUMREQT", objParamList(7))
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParamList(4))
        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_JUNTA_TRANSPORTISTA_REQUERIMIENTO", objParam)
        For Each objDataRow As DataRow In objDataTable.Rows
            objDatos = New ENTIDADES.Operaciones.Junta_Transporte
            objDatos.NPLNJT = objDataRow("NPLNJT").ToString.Trim
            objDatos.NCRRPL = objDataRow("NCRRPL").ToString.Trim
            objDatos.FPLNJT = HelpClass.CFecha_de_8_a_10(objDataRow("FPLNJT").ToString.Trim)
            objDatos.HPLNJT = objDataRow("HPLNJT").ToString.Trim
            objDatos.TDSCPL = objDataRow("TDSCPL").ToString.Trim
            objDatos.TRSPAT = objDataRow("TRSPAT").ToString.Trim
            objDatos.QCNASI = objDataRow("QCNASI").ToString.Trim

            objDatos.SESPLN = objDataRow("SESPLN").ToString.Trim
            objDatos.ESTADO_JNT = objDataRow("ESTADO_JNT").ToString.Trim
            'If objDataRow("SESPLN").ToString.Trim = "P" Then
            '    objDatos.SESPLN = "Pendiente"
            'Else
            '    objDatos.SESPLN = "Cerrado"
            'End If

            objDatos.CCMPN = objDataRow("CCMPN").ToString.Trim
            objDatos.CDVSN = objDataRow("CDVSN").ToString.Trim
            objDatos.CPLNDV = objDataRow("CPLNDV")
            objDatos.QPROGRAMADOS = objDataRow("QPROGRAMADOS")
            objDatos.QSOLICITUD = objDataRow("QSOLICITUD")
            objDatos.QREQUERIMIENTOS = objDataRow("QREQUERIMIENTOS")
            objDatos.QUNIDADES = objDataRow("QUNIDADES")
            objGenericCollection.Add(objDatos)
        Next
        'Catch ex As Exception
        'End Try
        Return objGenericCollection
    End Function

End Class
