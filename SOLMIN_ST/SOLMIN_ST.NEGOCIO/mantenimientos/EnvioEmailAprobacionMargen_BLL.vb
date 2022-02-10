Imports System.Text
Imports System.Runtime.CompilerServices
Imports RANSA.Controls.Email
Imports System.Configuration
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.DATOS.mantenimientos
Imports SOLMIN_ST.ENTIDADES
Namespace mantenimientos

    Public Class EnvioEmailAprobacionMargen_BLL


        'Private oListCheckPointEnvio As New List(Of RequerimientoServicio)
        'Private PNNESTDO As Decimal = 0
        'Private PNNESTDO_ULTIMO_MODIFICADO As Decimal = 0 'PARA COLOCAR EL ASTERISCO

        Private Const HTMLInicio As String = "<HTML><BODY>"
        Private Const HTMLFin As String = "</BODY></HTML>"
        Private Const HTMLSalto As String = "<br/>"
        Private Const HTMLEspacio As String = "&nbsp;"
        Private Const CharRelleno As String = "#"
        Private _mailaccount As String = ""
        Private _mailpassword As String = ""

        Private _mailaccount_gmail As String = ""
        Private _mailpassword_gmail As String = ""
        Private _mailto_error As String = ""

        Private _CULUSA As String = ""

        Private oListDestinatario As New List(Of beDestinatario)

        Private TipoProceso As String = "ST_APROBOP"
        Private CCLNT_GENERAL As Decimal = 999999

        Private _CCLNT As Decimal = 0

        Public Property MailAccount() As String
            Get
                Return _mailaccount
            End Get
            Set(ByVal value As String)
                _mailaccount = value
            End Set
        End Property

        Public Property Mailpassword() As String
            Get
                Return _mailpassword
            End Get
            Set(ByVal value As String)
                _mailpassword = value
            End Set
        End Property


        Public Property MailAccount_Gmail() As String
            Get
                Return _mailaccount_gmail
            End Get
            Set(ByVal value As String)
                _mailaccount_gmail = value
            End Set
        End Property

        Public Property MailPassword_Gmail() As String
            Get
                Return _mailpassword_gmail
            End Get
            Set(ByVal value As String)
                _mailpassword_gmail = value
            End Set
        End Property

        Public Property Mailto_Error() As String
            Get
                Return _mailto_error
            End Get
            Set(ByVal value As String)
                _mailto_error = value
            End Set
        End Property

        Public Property CULUSA() As String
            Get
                Return _CULUSA
            End Get
            Set(ByVal value As String)
                _CULUSA = value
            End Set
        End Property


        'Public Function EnviarEmail_RequerimientoServicio(ByVal CCMPN As String, ByVal oList As List(Of GuiaTransportista)) As Int32
        '    Dim exito As Int32 = -1
        '    Dim bodyemail As String = ""


        '    Try

        '        Dim oListDestEnvio As String = ""
        '        Dim oListDestEnvioReplicacion As String = ""
        '        Dim FECHA_INCIAL As Int32 = 0


        '        Dim odtDatosEmbarqueFinal As New DataTable
        '        Dim oclsEmailManager As New clsEmailManager
        '        Dim obeDestinatariosEnvio As New beDestinatario
        '        bodyemail = DatosCuerpoEnvio(oList)
        '        Dim obeDestinatario As New beDestinatario
        '        obeDestinatario = BuscarDestinatarios(CCLNT_TODOS)
        '        obeDestinatariosEnvio.PSEMAILTO = obeDestinatario.PSEMAILTO
        '        obeDestinatariosEnvio.PSEMAILBC = obeDestinatario.PSEMAILBC
        '        oclsEmailManager.MailAccount = Me.MailAccount
        '        oclsEmailManager.Mailpassword = Me.Mailpassword
        '        oclsEmailManager.MailBody = bodyemail
        '        oclsEmailManager.MailNotification = obeDestinatariosEnvio.PSEMAILTO
        '        oclsEmailManager.mailnotificationBCC = obeDestinatariosEnvio.PSEMAILBC
        '        oclsEmailManager.MailSubject = String.Format("RANSA: Solicitud de aprobaci&oacute;n") ''MensajeAsuntoEmail 
        '        If (obeDestinatariosEnvio.PSEMAILTO <> "") Then
        '            oclsEmailManager.SendMailProvider()
        '            exito = 1
        '        Else
        '            MsgBox("Correo no enviado.No se encontró destinatarios.", MsgBoxStyle.Critical, "Aviso")
        '            exito = 0
        '        End If


        '    Catch ex As Exception
        '        Dim msgError As String = ""
        '        msgError = "OCURRIÒ UN ERROR EN EL ENVIO PARA SOLICITUD DE APROBACION DE LA OPERACION " & Entidad.NOPRCN
        '        msgError = msgError & "<br/>" & ex.Message
        '        Try
        '            Dim oclsEmailManagerGMAIL As New clsEmailManagerGMAIL
        '            oclsEmailManagerGMAIL.MailAccount = Me.MailAccount_Gmail
        '            oclsEmailManagerGMAIL.Mailpassword = Me.MailPassword_Gmail
        '            oclsEmailManagerGMAIL.MailBody = msgError & "<br/>" & bodyemail
        '            oclsEmailManagerGMAIL.MailNotification = Me.Mailto_Error
        '            oclsEmailManagerGMAIL.MailSubject = "SOLICITUD DE APROBACION"
        '            oclsEmailManagerGMAIL.SendMailGmail()
        '        Catch exx As Exception
        '        End Try
        '    End Try
        '    Return exito
        'End Function



        Private Function DatosCuerpoEnvio(ByVal oEntidad As GuiaTransportista, ByVal DT_SERV As DataTable) As String

            Dim Dato As String = ""


            Dim bodyemail As New StringBuilder
            bodyemail.Append(HTMLInicio)
            bodyemail.Append("<table style='font-size:10px;font-family:Arial' >")
            bodyemail.Append("<tr>")
            bodyemail.Append("<td colspan='3'>")
            bodyemail.Append("Sres:")
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")


            bodyemail.Append("<tr>")
            bodyemail.Append("<td colspan='3'>")
            bodyemail.Append("El " & Now.ToString & " Se ha enviado lo siguiente para su aprobaci&oacute;n")

            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td colspan='3' align='center'>")
            bodyemail.Append("<b>SOLICITUD DE APROBACI&Oacute;N</b>")
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")



            bodyemail.Append("<tr>")
            bodyemail.Append("<td width='22%'>")
            bodyemail.Append("Nro Viaje :")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append("<b>")
            bodyemail.Append(oEntidad.REFVIAJE)
            bodyemail.Append("</b>")
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")



            'bodyemail.Append("<tr>")
            'bodyemail.Append("<td width='22%'>")
            'bodyemail.Append("Gu&iacute;a Transporte:")
            'bodyemail.Append("</td>")
            'bodyemail.Append("<td>")
            'bodyemail.Append(oEntidad.NGUIRM)
            'bodyemail.Append("</td>")
            'bodyemail.Append("</tr>")

            'bodyemail.Append("<tr>")
            'bodyemail.Append("<td width='22%'>")
            'bodyemail.Append("Ruta:")
            'bodyemail.Append("</td>")
            'bodyemail.Append("<td>")
            'bodyemail.Append(oEntidad.RUTA)
            'bodyemail.Append("</td>")
            'bodyemail.Append("</tr>")


            'bodyemail.Append("<tr>")
            'bodyemail.Append("<td width='22%'>")
            'bodyemail.Append("Ref. Orden Servicio:")
            'bodyemail.Append("</td>")
            'bodyemail.Append("<td>")
            'bodyemail.Append(oEntidad.NORSRT)
            'bodyemail.Append("</td>")
            'bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td width='22%'>")
            bodyemail.Append("Aprobador sugerido:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(oEntidad.APROBSUG)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td width='22%'>")
            bodyemail.Append("Margen aprobaci&oacute;n %:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(oEntidad.MRGPOR)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")


            bodyemail.Append("</table>")

            bodyemail.Append("<table style='font-size:10px;font-family:Arial'>")

            bodyemail.Append(HTMLSalto)
            bodyemail.Append("</table>")



            bodyemail.Append("<table style='font-size:10px;font-family:Arial'>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td colspan='6'>")

            bodyemail.Append("<hr style='border:1px dotted; width=100%' />")
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")


            If DT_SERV.Rows.Count > 0 Then 'servicios

                bodyemail.Append("<tr>")

                bodyemail.Append("<td width='10%'>")
                bodyemail.Append("Operaci&oacute;n")
                bodyemail.Append("</td>")


                bodyemail.Append("<td width='15%'>")
                bodyemail.Append("Ruta")
                bodyemail.Append("</td>")


                bodyemail.Append("<td width='25%'>")
                bodyemail.Append("Servicio")
                bodyemail.Append("</td>")
                bodyemail.Append("<td width='10%'>")
                bodyemail.Append("Cobro(S/.)")
                bodyemail.Append("</td>")
                bodyemail.Append("<td width='10%'>")
                bodyemail.Append("Pago(S/.)")
                bodyemail.Append("</td>")
                bodyemail.Append("<td width='10%'>")
                bodyemail.Append("Margen(S/.)")
                bodyemail.Append("</td>")
                bodyemail.Append("<td width='10%'>")
                bodyemail.Append("Margen %")
                bodyemail.Append("</td>")
                bodyemail.Append("</tr>")

                For Each dr As DataRow In DT_SERV.Rows

                    bodyemail.Append("<tr>")

                    bodyemail.Append("<td width='10%'>")
                    bodyemail.Append(dr("NOPRCN"))
                    bodyemail.Append("</td>")

                    bodyemail.Append("<td width='15%'>")
                    bodyemail.Append(("" & dr("RUTA")).ToString.Trim)
                    bodyemail.Append("</td>")

                    bodyemail.Append("<td width='25%'>")
                    bodyemail.Append(("" & dr("SERVICIO")).ToString.Trim)
                    bodyemail.Append("</td>")
                    bodyemail.Append("<td width='10%'>")
                    bodyemail.Append(Math.Round(dr("COBRO_SOL"), 2))
                    bodyemail.Append("</td>")
                    bodyemail.Append("<td width='10%'>")
                    bodyemail.Append(Math.Round(dr("PAGO_SOL"), 2))
                    bodyemail.Append("</td>")
                    bodyemail.Append("<td width='10%'>")
                    bodyemail.Append(Math.Round(dr("MARGEN"), 2))
                    bodyemail.Append("</td>")
                    bodyemail.Append("<td width='10%'>")
                    bodyemail.Append(Math.Round(dr("MARGENPOR"), 2))
                    bodyemail.Append("</td>")
                    bodyemail.Append("</tr>")

                Next

            End If



            bodyemail.Append("<tr>")
            bodyemail.Append("<td colspan='6'>")
            bodyemail.Append("<hr style='border:1px dotted; width=100%' />")
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            'bodyemail.Append(HTMLSalto)
            'bodyemail.Append(HTMLSalto)
            'bodyemail.Append(HTMLSalto)
            bodyemail.Append(HTMLSalto)
            bodyemail.Append("</table>")


            bodyemail.Append("<table style='font-size:10px;font-family:Arial'>")
            bodyemail.Append("<tr>")
            bodyemail.Append("<td colspan='6'>")
            bodyemail.Append("Enviado por : ")
            bodyemail.Append(CULUSA)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("</table>")

            bodyemail.Append(HTMLFin)

            Return bodyemail.ToString
        End Function



        Private Function FHTML_RIGHT(ByVal cadena As String, ByVal Char_Total_Relleno As Int32, ByVal CharRelleno As String) As String
            Dim cadenaRetorno As String = cadena.PadRight(Char_Total_Relleno, CharRelleno).Replace(CharRelleno, HTMLEspacio)
            Return cadenaRetorno
        End Function

        Private Function ListaEmailDistintos(ByVal oList As List(Of beDestinatario)) As String
            Dim Tot_Destinatarios As Int32 = 0
            Dim STR_LISTA_EMAIL As String = ""
            Dim sbDestinatarios As New StringBuilder
            Dim CharSeparacion As String = ";"
            Dim ListTempEMAIL As New List(Of String)
            Dim FILA As Int32 = 0
            Dim EMAIL As String = ""
            Tot_Destinatarios = oList.Count
            ListTempEMAIL.Clear()
            For FILA = 0 To Tot_Destinatarios - 1
                EMAIL = oList(FILA).PSEMAILTO.Trim.ToLower
                If (EMAIL.Length <> 0) Then
                    If (Not ListTempEMAIL.Contains(EMAIL)) Then
                        ListTempEMAIL.Add(EMAIL)
                        sbDestinatarios.Append(EMAIL)
                        sbDestinatarios.Append(CharSeparacion)
                    End If
                End If
            Next
            STR_LISTA_EMAIL = sbDestinatarios.ToString.Trim
            If (STR_LISTA_EMAIL.Length > 0) Then
                STR_LISTA_EMAIL = STR_LISTA_EMAIL.Substring(0, STR_LISTA_EMAIL.LastIndexOf(CharSeparacion))
            End If
            Return STR_LISTA_EMAIL
        End Function


        Private Function FindDestinatarioCopia(ByVal obeDestinatario As beDestinatario) As Boolean

            Return obeDestinatario.PSTIP_MAIL_DEST = "COPIA"

        End Function

        Private Function FindDestinatarioCliente(ByVal obeDestinatario As beDestinatario) As Boolean

            Return obeDestinatario.PSTIPO_ENVIO = TipoProceso AndAlso obeDestinatario.PSTIP_MAIL_DEST = "CLIENTE"

        End Function

        Public Function BuscarDestinatarios() As beDestinatario

            Dim obeDestinatariosEnvio As New beDestinatario
            Dim oListBU As New List(Of String)
            Dim odaEnviarEmail As New DATOS.EnvioEmailNotificacion
            Dim oListDestinatarioBusqueda As New List(Of beDestinatario)
            Dim oListDestinatarioReplicacion As New List(Of beDestinatario)
            oListDestinatario = odaEnviarEmail.DESTINATARIO_ENVIO_EMAIL_X_TIPO_PROCESO(CCLNT_GENERAL, TipoProceso)
            oListDestinatarioBusqueda = oListDestinatario.FindAll(AddressOf FindDestinatarioCliente)
            oListDestinatarioReplicacion = oListDestinatario.FindAll(AddressOf FindDestinatarioCopia)
            obeDestinatariosEnvio.PSEMAILTO = ListaEmailDistintos(oListDestinatarioBusqueda)
            obeDestinatariosEnvio.PSEMAILBC = ListaEmailDistintos(oListDestinatarioReplicacion)
            Return obeDestinatariosEnvio

        End Function

        Public Function Enviar_Email_Requerimiento_Servicio_Notificacion(ByVal oEntidad As GuiaTransportista, ByVal DT_SERV As DataTable) As Int32
            Dim exito As Int32 = -1
            Dim bodyemail As String = ""


            Try

                Dim oListDestEnvio As String = ""
                Dim oListDestEnvioReplicacion As String = ""
                Dim FECHA_INCIAL As Int32 = 0

                Dim odtDatosEmbarqueFinal As New DataTable
                Dim oclsEmailManager As New clsEmailManager
                Dim obeDestinatariosEnvio As New beDestinatario
                bodyemail = DatosCuerpoEnvio(oEntidad, DT_SERV)
                Dim obeDestinatario As New beDestinatario
                obeDestinatario = BuscarDestinatarios() ', beSegEnvioReq.EMAILCC)
                obeDestinatariosEnvio.PSEMAILTO = obeDestinatario.PSEMAILTO
                obeDestinatariosEnvio.PSEMAILBC = obeDestinatario.PSEMAILBC
                'obeDestinatariosEnvio.PSEMAILCC = obeDestinatario.PSEMAILCC
                oclsEmailManager.MailAccount = Me.MailAccount
                oclsEmailManager.Mailpassword = Me.Mailpassword
                oclsEmailManager.MailBody = bodyemail
                oclsEmailManager.MailNotification = obeDestinatariosEnvio.PSEMAILTO
                oclsEmailManager.mailnotificationBCC = obeDestinatariosEnvio.PSEMAILBC
                'oclsEmailManager.mailnotificationCC = obeDestinatariosEnvio.PSEMAILCC
                oclsEmailManager.MailSubject = String.Format("RANSA: SOLICITUD DE APROBACION DE MARGENES VIAJE")
                If (obeDestinatariosEnvio.PSEMAILTO <> "") Then
                    oclsEmailManager.SendMailProvider()
                    exito = 1
                Else
                    MsgBox("Correo no enviado.No se encontró destinatarios.", MsgBoxStyle.Critical, "Aviso")
                    exito = 0
                End If


            Catch ex As Exception
                Dim msgError As String = ""
                msgError = "OCURRIÒ UN ERROR EN EL ENVIO DE APROBACION " & oEntidad.NOPRCN
                msgError = msgError & "<br/>" & ex.Message
                Try
                    Dim oclsEmailManagerGMAIL As New clsEmailManagerGMAIL
                    oclsEmailManagerGMAIL.MailAccount = Me.MailAccount_Gmail
                    oclsEmailManagerGMAIL.Mailpassword = Me.MailPassword_Gmail
                    oclsEmailManagerGMAIL.MailBody = msgError & "<br/>" & bodyemail
                    oclsEmailManagerGMAIL.MailNotification = Me.Mailto_Error
                    oclsEmailManagerGMAIL.MailSubject = "SOLICITUD APROBACION -ERROR ENVIO APROBACION"
                    oclsEmailManagerGMAIL.SendMailGmail()
                Catch exx As Exception
                End Try
            End Try
            Return exito

        End Function

        'Public Function BuscarDestinatarios_Notificacion(ByVal CCLNT As Decimal, ByVal EMAIL_RESP As String) As beDestinatario ', ByVal EMAILCC As String) As beDestinatario
        '    Dim obeDestinatariosEnvio As New beDestinatario
        '    Dim oListBU As New List(Of String)
        '    Dim odaEnvioEmail As New EnvioEmailAprobacionMargen_DAL
        '    'Dim oListDestinatarioBusqueda As New List(Of beDestinatario)
        '    Dim oListDestinatarioReplicacion As New List(Of beDestinatario)
        '    oListDestinatario = odaEnvioEmail.DESTINATARIO_ENVIO_EMAIL_X_TIPO_PROCESO(CCLNT, TipoProceso)
        '    'oListDestinatarioBusqueda = oListDestinatario.FindAll(AddressOf FindDestinatarioCliente)
        '    oListDestinatarioReplicacion = oListDestinatario.FindAll(AddressOf FindDestinatarioCopia)
        '    obeDestinatariosEnvio.PSEMAILTO = EMAIL_RESP
        '    'obeDestinatariosEnvio.PSEMAILCC = EMAILCC
        '    obeDestinatariosEnvio.PSEMAILBC = ListaEmailDistintos(oListDestinatarioReplicacion)
        '    Return obeDestinatariosEnvio
        'End Function


        'Public Function Cargar_Cuerpo_Email_Notificacion(ByVal NUMREQT As Decimal, ByVal CCMPN As String) As String
        '    Dim bodyemail As String = ""
        '    Dim Entidad As New RequerimientoServicio

        '    Dim Negocio As New RequerimientoServicioEnvio_DAL
        '    Entidad = Negocio.Envio_Email_Requerimiento_Servicio(NUMREQT, CCMPN)
        '    bodyemail = DatosCuerpoEnvioChekPoint(Entidad)

        '    Return bodyemail
        'End Function

        'Public Function Registrar_Envio_Requerimiento_Servicio(ByVal beSegEnvioReq As SegEnvioRequerimiento) As SegEnvioRequerimiento
        '    Dim Negocio As New RequerimientoServicioEnvio_DAL
        '    Return Negocio.Registrar_Envio_Requerimiento_Servicio(beSegEnvioReq)
        ''End Function

        'Public Function Listar_Seg_Envio_Requerimiento(ByVal beSegEnvioReq As SegEnvioRequerimiento) As List(Of SegEnvioRequerimiento)
        '    Dim Negocio As New RequerimientoServicioEnvio_DAL
        '    Return Negocio.Listar_Seg_Envio_Requerimiento(beSegEnvioReq)
        'End Function

    End Class
End Namespace