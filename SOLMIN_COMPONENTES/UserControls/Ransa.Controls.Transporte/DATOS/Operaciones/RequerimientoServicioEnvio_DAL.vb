
Imports Ransa.Utilitario
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class RequerimientoServicioEnvio_DAL

    Public Function DESTINATARIO_ENVIO_EMAIL_X_TIPO_PROCESO(ByVal PNCCLNT As Decimal, ByVal PSTIPPROC As String) As List(Of beDestinatario)

        Dim lobjSql As New SqlManager

        Dim oListDestinatarios As New List(Of beDestinatario)
        Dim obeDestinatario As beDestinatario
        Dim odtDatos As New DataTable
        Dim odtSeguimiento As New DataTable
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", 999999)
        lobjParams.Add("PSTIPPROC", PSTIPPROC)

        odtDatos = lobjSql.ExecuteDataTable("SP_SOLMIN_SC_LISTAR_EMAIL_ENVIO_REQUERIMIENTO_SERVICIO", lobjParams)

        For Each dr As DataRow In odtDatos.Rows

            obeDestinatario = New beDestinatario
            obeDestinatario.PNCCLNT = dr("CCLNT")
            obeDestinatario.PSEMAILTO = ("" & dr("EMAILTO")).ToString.Trim
            obeDestinatario.PSBU = ("" & dr("NLTECL")).ToString.Trim
            obeDestinatario.PSTIPPROC = ("" & dr("TIPPROC")).ToString.Trim
            obeDestinatario.PSTIP_MAIL_DEST = ("" & dr("TIP_MAIL_DEST")).ToString.Trim
            oListDestinatarios.Add(obeDestinatario)

        Next
        Return oListDestinatarios

    End Function


    Public Function Envio_Email_Requerimiento_Servicio(ByVal NUMREQT As Decimal, ByVal CCMPN As String) As RequerimientoServicio

        Dim lobjSql As New SqlManager

        Dim dt As New DataTable
        Dim objParam As New Parameter
        Dim Entidad As New RequerimientoServicio

        objParam.Add("PSCCMPN", CCMPN)
        objParam.Add("PNNUMREQT", NUMREQT)

        lobjSql.DefaultSchema = Autenticacion_DAL.GetLibrary(CCMPN)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_REQUERIMIENTO_SERVICIO_ENVIO_EMAIL", objParam)

        For Each Item As DataRow In dt.Rows

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
            Entidad.CCLNFC = Item("CCLNFC")
            Entidad.CCLNFC_S = Item("CCLNFC_S")
            Entidad.FCHATN_D = HelpClass.CNumero8Digitos_a_FechaDefault(CLng(Item("FCHATN"))).ToString
            Entidad.HRAATN_D = IIf(Item("HRAATN") = 0, "", HelpClass.HoraNum_a_Hora(CLng(Item("HRAATN"))).ToString)

            Entidad.SPRSTR = Item("SPRSTR")
            Entidad.SPRSTR_S = Item("SPRSTR_S")

            Entidad.TIPOCNT = Item("TIPOCNT")   'Tipo mercaderia
            Entidad.TIPOCNT_S = Item("TIPOCNT_S")

            Entidad.QPSOMR = Item("QPSOMR")
            'Entidad.QMTLRG = Item("QMTLRG")
            'Entidad.QMTALT = Item("QMTALT")
            'Entidad.QMTANC = Item("QMTANC")

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
            Entidad.TNMMDT = Item("TNMMDT").ToString.Trim

            Entidad.CUNDVH_D = Item("CUNDVH_D").ToString.Trim
            Entidad.CUNDMD = Item("CUNDMD").ToString
            Entidad.CMRCDR = CDec(Val(Item("CMRCDR").ToString.Trim))
            Entidad.CTPOSR = Item("CTPOSR").ToString.Trim

            Entidad.CUBORI = CDec(Val(Item("CUBORI").ToString))
            Entidad.CUBORI_S = Item("CUBORI_S").ToString.Trim
            Entidad.CUBDES = CDec(Val(Item("CUBDES").ToString))
            Entidad.CUBDES_S = Item("CUBDES_S").ToString.Trim

            Entidad.TOBERV = Item("TOBERV")
            Entidad.PRSCNT = Item("PRSCNT")
            Entidad.TNMMDT = Item("TNMMDT")

            'Entidad.NSECREV = Item("NSECREV")
            'Entidad.FSECREV_D = HelpClass.CNumero8Digitos_a_FechaDefault(CLng(Item("FSECREV"))).ToString

            Entidad.PNCDTR = Item("PNCDTR").ToString.Trim
            Entidad.TIRALC = Item("TIRALC").ToString.Trim

        Next

        Return Entidad

    End Function

    Public Function Registrar_Envio_Requerimiento_Servicio(ByVal beSegEnvioReq As SegEnvioRequerimiento) As SegEnvioRequerimiento
        Dim objParam As New Parameter
        Dim objSql As New SqlManager
        objParam.Add("PNNUMREQT", beSegEnvioReq.NUMREQT)
        objParam.Add("PSSESREQT", beSegEnvioReq.SESREQT)
        objParam.Add("PNFDSGDC", beSegEnvioReq.FDSGDC)
        objParam.Add("PNHDSGDC", beSegEnvioReq.HDSGDC)
        objParam.Add("PSURSPDC", beSegEnvioReq.URSPDC)
        objParam.Add("PSTOBSSG", beSegEnvioReq.TOBSSG)
        objParam.Add("PSCUSCRT", beSegEnvioReq.CUSCRT)
        objParam.Add("PSNTRMCR", beSegEnvioReq.NTRMCR)
        objParam.Add("PNRESULT", 0, ParameterDirection.Output)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(beSegEnvioReq.CCMPN)

        objSql.ExecuteNonQuery("SP_SOLMIN_ST_INSERTAR_SEG_ENVIO_REQ", objParam)
        beSegEnvioReq.NCRRSG = objSql.ParameterCollection("PNRESULT")

        Return beSegEnvioReq
    End Function

    Public Function Listar_Seg_Envio_Requerimiento(ByVal beSegEnvioReq As SegEnvioRequerimiento) As List(Of SegEnvioRequerimiento)
        Dim objSql As New SqlManager
        Dim objResultado As New DataTable
        Dim objEntidad As SegEnvioRequerimiento
        Dim objLstSegEnvioReq As New List(Of SegEnvioRequerimiento)
        'Try
        Dim objParam As New Parameter
        objParam.Add("PNNUMREQT", beSegEnvioReq.NUMREQT)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(beSegEnvioReq.CCMPN)

        objResultado = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SEG_ENVIO_REQ", objParam)

        For Each objDataRow As DataRow In objResultado.Rows
            objEntidad = New SegEnvioRequerimiento
            objEntidad.NUMREQT = objDataRow("NUMREQT").ToString.Trim
            objEntidad.NCRRSG = objDataRow("NCRRSG").ToString.Trim
            objEntidad.SESREQT = objDataRow("SESREQT").ToString.Trim
            objEntidad.FDSGDC_S = HelpClassST.FechaNum_a_Fecha(objDataRow("FDSGDC"))
            objEntidad.HDSGDC_S = IIf(objDataRow("HDSGDC") = 0, "", HelpClassST.HoraNum_a_Hora_Default(CLng(objDataRow("HDSGDC"))).ToString)
            objEntidad.URSPDC = objDataRow("URSPDC").ToString.Trim
            objEntidad.TOBSSG = objDataRow("TOBSSG").ToString.Trim
            objEntidad.SESTRG = objDataRow("SESTRG").ToString.Trim
            objEntidad.CUSCRT = objDataRow("CUSCRT").ToString.Trim
            objEntidad.FCHCRT = objDataRow("FCHCRT").ToString.Trim
            objEntidad.HRACRT = objDataRow("HRACRT").ToString.Trim
            objEntidad.NTRMCR = objDataRow("NTRMCR").ToString.Trim

            objLstSegEnvioReq.Add(objEntidad)
        Next

        'Catch ex As Exception
        '    End Try
        Return objLstSegEnvioReq
    End Function


End Class
