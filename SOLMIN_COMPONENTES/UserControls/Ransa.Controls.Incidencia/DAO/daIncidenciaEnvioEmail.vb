
Imports Ransa.Utilitario
Imports Db2Manager.RansaData.iSeries.DataObjects


Public Class daIncidenciaEnvioEmail

    Public Function DESTINATARIO_ENVIO_EMAIL_X_TIPO_PROCESO(ByVal PNCCLNT As Decimal, ByVal Tipo_Proceso As String) As List(Of beDestinatario)

        Dim lobjSql As New SqlManager

        Dim oListDestinatarios As New List(Of beDestinatario)
        Dim obeDestinatario As beDestinatario
        Dim odtDatos As New DataTable
        Dim odtSeguimiento As New DataTable
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", 999999)
        lobjParams.Add("PSTIPPROC", Tipo_Proceso)

        odtDatos = lobjSql.ExecuteDataTable("SP_SOLSC_DATOS_DESTINATARIO_ENVIO_EMAILS_X_TIPO_PROCESO_INC", lobjParams)

        For Each dr As DataRow In odtDatos.Rows

            obeDestinatario = New beDestinatario
            obeDestinatario.PNCCLNT = dr("CCLNT")
            obeDestinatario.PSEMAILTO = ("" & dr("EMAILTO")).ToString.Trim
            'obeDestinatario.PSBU = ("" & dr("NLTECL")).ToString.Trim
            obeDestinatario.PSTIPPROC = ("" & dr("TIPPROC")).ToString.Trim
            obeDestinatario.PSTIP_MAIL_DEST = ("" & dr("TIP_MAIL_DEST")).ToString.Trim
            oListDestinatarios.Add(obeDestinatario)

        Next
        Return oListDestinatarios

    End Function


    Public Function Envio_Email_Incidencia(ByVal obeIncidencias As beIncidencias) As beIncidencias

        Dim lobjSql As New SqlManager

        Dim dt As New DataTable
        Dim objParam As New Parameter
        Dim Entidad As New beIncidencias
        Dim split As String()

        objParam.Add("PSCCMPN", obeIncidencias.PSCCMPN)
        objParam.Add("PNNINCSI", obeIncidencias.PNNINCSI)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SC_REGISTRO_INCIDENCIAS_ENVIO_EMAIL", objParam)

        If dt.Rows.Count > 0 Then
            Entidad.PNCCLNT = dt.Rows(0)("CCLNT")
            Entidad.PSTCMPCL = dt.Rows(0)("TCMPCL")
            Entidad.PNNINCSI = dt.Rows(0)("NINCSI")
            Entidad.PSNIVEL = dt.Rows(0)("NIVEL")
            Entidad.PSTDARINC = dt.Rows(0)("TDARINC").ToString.Trim & " - " & dt.Rows(0)("TPLNTA").ToString.Trim
            Entidad.PSREPORTADO = dt.Rows(0)("REPORTADO")
            split = dt.Rows(0)("TTPINC").ToString.Trim.Split("->")
            Entidad.PSTTPINC = split(0)
            Entidad.PSTCRVTA = dt.Rows(0)("CRGVTA").ToString.Trim & " - " & dt.Rows(0)("TCRVTA").ToString.Trim
            Entidad.PSTINCSI = dt.Rows(0)("TINCSI")
            Entidad.FechaRegistro = HelpClass.CNumero8Digitos_a_FechaDefault(CLng(dt.Rows(0)("FRGTRO"))).ToString
            Entidad.HoraRegistro = IIf(dt.Rows(0)("HRGTRO") = 0, "", HelpClass.HoraNum_a_Hora(CLng(dt.Rows(0)("HRGTRO"))).ToString)
            Entidad.PSTRDCCL = dt.Rows(0)("TRDCCL").ToString.Trim
            Entidad.PSTINCDT = dt.Rows(0)("TINCDT").ToString.Trim
            Entidad.PSCUNDCN = Val(dt.Rows(0)("QAINSM")).ToString.Trim & " " & dt.Rows(0)("MEDIDA").ToString.Trim

            If dt.Rows(0)("TALMC").ToString.Trim <> "" Then
                Entidad.PSTCMPAL = dt.Rows(0)("TALMC").ToString.Trim
                If dt.Rows(0)("TCMPAL").ToString.Trim <> "" Then
                    Entidad.PSTCMPAL = dt.Rows(0)("TALMC").ToString.Trim & " / " & dt.Rows(0)("TCMPAL").ToString.Trim
                    If dt.Rows(0)("TCMZNA").ToString.Trim <> "" Then
                        Entidad.PSTCMPAL = dt.Rows(0)("TALMC").ToString.Trim & " / " & dt.Rows(0)("TCMPAL").ToString.Trim & " / " & dt.Rows(0)("TCMZNA").ToString.Trim
                    End If
                End If
            Else
                Entidad.PSTCMPAL = ""
            End If

            

            Entidad.PSTIRALC = dt.Rows(0)("TIRALC").ToString.Trim 'RESPONSABLE
            Entidad.PSPRSCNT = dt.Rows(0)("PRSCNT").ToString.Trim 'CONTACTO
            ' PARA FORMAR TIPO PROCESO ENVIO EMAIL
            '***********************
            Entidad.PSCARINC = dt.Rows(0)("CARINC").ToString.Trim
            Entidad.PNCTPINC = dt.Rows(0)("CTPINC")
            Entidad.PSCRGVTA = dt.Rows(0)("CRGVTA").ToString.Trim
            '*******************************
        End If

        'For Each Item As DataRow In dt.Rows
        'Next

        Return Entidad

    End Function

End Class
