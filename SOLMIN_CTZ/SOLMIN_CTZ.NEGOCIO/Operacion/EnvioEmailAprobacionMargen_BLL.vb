Imports System.Text
Imports System.Runtime.CompilerServices
Imports System.Configuration
Imports SOLMIN_CTZ.Entidades
Imports Ransa.Controls.Email
Imports SOLMIN_CTZ.DATOS

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

    Private TipoProceso As String = "CT_APRMROS"
    Private CCLNT_TODOS As Decimal = 999999

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



    'Private Function DatosCuerpoEnvio(ByVal oEntidad As Hashtable, ByVal DT_SERV As DataTable) As String

    '    Dim Dato As String = ""


    '    Dim bodyemail As New StringBuilder
    '    bodyemail.Append(HTMLInicio)
    '    bodyemail.Append("<table style='font-size:10px;font-family:Arial' >")
    '    bodyemail.Append("<tr>")
    '    bodyemail.Append("<td colspan='3'>")
    '    bodyemail.Append("Sres:")
    '    bodyemail.Append("</td>")
    '    bodyemail.Append("</tr>")


    '    bodyemail.Append("<tr>")
    '    bodyemail.Append("<td colspan='3'>")
    '    bodyemail.Append("El " & Now.ToString & " Se ha enviado la siguiente O/S para su aprobaci&oacute;n")

    '    bodyemail.Append("</td>")
    '    bodyemail.Append("</tr>")

    '    bodyemail.Append("<tr>")
    '    bodyemail.Append("<td colspan='3' align='center'>")
    '    bodyemail.Append("<b>SOLICITUD DE APROBACI&Oacute;N ORDEN SERVICIO</b>")
    '    bodyemail.Append("</td>")
    '    bodyemail.Append("</tr>")


    '    bodyemail.Append("<tr>")
    '    bodyemail.Append("<td width='22%'>")
    '    bodyemail.Append("Orden Servicio:")
    '    bodyemail.Append("</td>")
    '    bodyemail.Append("<td>")
    '    bodyemail.Append(oEntidad("NORSRT"))
    '    bodyemail.Append("</td>")
    '    bodyemail.Append("</tr>")


    '    bodyemail.Append("<tr>")
    '    bodyemail.Append("<td width='22%'>")
    '    bodyemail.Append("Ref Nro Tarifa:")
    '    bodyemail.Append("</td>")
    '    bodyemail.Append("<td>")
    '    bodyemail.Append(oEntidad("NRTFSV"))
    '    bodyemail.Append("</td>")
    '    bodyemail.Append("</tr>")

    '    'bodyemail.Append("<tr>")
    '    'bodyemail.Append("<td width='22%'>")
    '    'bodyemail.Append("Servicio:")
    '    'bodyemail.Append("</td>")
    '    'bodyemail.Append("<td>")
    '    'bodyemail.Append(oEntidad("SERVICIO_D"))
    '    'bodyemail.Append("</td>")
    '    'bodyemail.Append("</tr>")

    '    bodyemail.Append("<tr>")
    '    bodyemail.Append("<td width='22%'>")
    '    bodyemail.Append("Cliente:")
    '    bodyemail.Append("</td>")
    '    bodyemail.Append("<td>")
    '    bodyemail.Append(oEntidad("TCMPCL"))
    '    bodyemail.Append("</td>")
    '    bodyemail.Append("</tr>")



    '    bodyemail.Append("</table>")
    '    bodyemail.Append("<table style='font-size:10px;font-family:Arial'>")
    '    bodyemail.Append(HTMLSalto)
    '    bodyemail.Append("</table>")


    '    bodyemail.Append("<table style='font-size:10px;font-family:Arial'>")
    '    bodyemail.Append("<tr>")
    '    bodyemail.Append("<td colspan='7'>")

    '    bodyemail.Append("<hr style='border:1px dotted; width=100%' />")
    '    bodyemail.Append("</td>")
    '    bodyemail.Append("</tr>")

    '    If DT_SERV.Rows.Count > 0 Then 'servicios

    '        bodyemail.Append("<tr>")
    '        bodyemail.Append("<td width='10%'>")
    '        bodyemail.Append("Servicio")
    '        bodyemail.Append("</td>")

    '        bodyemail.Append("<td width='25%'>")
    '        bodyemail.Append("Origen")
    '        bodyemail.Append("</td>")

    '        bodyemail.Append("<td width='25%'>")
    '        bodyemail.Append("Destino")
    '        bodyemail.Append("</td>")

    '        bodyemail.Append("<td width='10%'>")
    '        bodyemail.Append("Monto Cobro(S/.)")
    '        bodyemail.Append("</td>")
    '        bodyemail.Append("<td width='10%'>")
    '        bodyemail.Append("Monto Pago(S/.)")
    '        bodyemail.Append("</td>")
    '        bodyemail.Append("<td width='10%'>")
    '        bodyemail.Append("Margen(S/.)")
    '        bodyemail.Append("</td>")
    '        bodyemail.Append("<td width='10%'>")
    '        bodyemail.Append("Margen %")
    '        bodyemail.Append("</td>")
    '        bodyemail.Append("</tr>")

    '        For Each dr As DataRow In DT_SERV.Rows

    '            bodyemail.Append("<tr>")
    '            bodyemail.Append("<td width='10%'>")
    '            bodyemail.Append(dr("SERVICIO"))
    '            bodyemail.Append("</td>")
    '            bodyemail.Append("<td width='25%'>")
    '            bodyemail.Append(("" & dr("ORIGEN")).ToString.Trim)
    '            bodyemail.Append("</td>")
    '            bodyemail.Append("<td width='10%'>")
    '            bodyemail.Append(dr("DESTINO"))
    '            bodyemail.Append("</td>")
    '            bodyemail.Append("<td width='10%'>")
    '            bodyemail.Append(Math.Round(dr("MONTOCOBRO_SOLES"), 2))
    '            bodyemail.Append("</td>")
    '            bodyemail.Append("<td width='10%'>")
    '            bodyemail.Append(Math.Round(dr("MONTOPAGO_SOLES"), 2))
    '            bodyemail.Append("</td>")
    '            bodyemail.Append("</td>")
    '            bodyemail.Append("<td width='10%'>")
    '            bodyemail.Append(Math.Round(dr("DIF_SOLES"), 2))
    '            bodyemail.Append("</td>")
    '            bodyemail.Append("<td width='10%'>")
    '            bodyemail.Append(Math.Round(dr("MARGENPOR"), 2))
    '            bodyemail.Append("</td>")
    '            bodyemail.Append("</tr>")

    '        Next

    '    End If



    '    bodyemail.Append("<tr>")
    '    bodyemail.Append("<td colspan='7'>")
    '    bodyemail.Append("<hr style='border:1px dotted; width=100%' />")
    '    bodyemail.Append("</td>")
    '    bodyemail.Append("</tr>")

    '    'bodyemail.Append(HTMLSalto)
    '    'bodyemail.Append(HTMLSalto)
    '    'bodyemail.Append(HTMLSalto)
    '    bodyemail.Append(HTMLSalto)
    '    bodyemail.Append("</table>")


    '    bodyemail.Append("<table style='font-size:10px;font-family:Arial'>")
    '    bodyemail.Append("<tr>")
    '    bodyemail.Append("<td colspan='6'>")
    '    bodyemail.Append("Enviado por : ")
    '    bodyemail.Append(CULUSA)
    '    bodyemail.Append("</td>")
    '    bodyemail.Append("</tr>")

    '    bodyemail.Append("</table>")

    '    bodyemail.Append(HTMLFin)

    '    Return bodyemail.ToString
    'End Function

    Private Function DatosCuerpoEnvio(ByVal oEntidad As Hashtable, ByVal DT_SERV As DataTable) As String

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
        bodyemail.Append("El " & Now.ToString & " Se ha enviado la siguiente O/S para su aprobaci&oacute;n")

        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='3' align='center'>")
        bodyemail.Append("<b>SOLICITUD DE APROBACI&Oacute;N ORDEN SERVICIO</b>")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")


        bodyemail.Append("<tr>")
        bodyemail.Append("<td width='22%'>")
        bodyemail.Append("Orden Servicio:")
        bodyemail.Append("</td>")
        bodyemail.Append("<td>")
        bodyemail.Append(oEntidad("NORSRT"))
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")


        bodyemail.Append("<tr>")
        bodyemail.Append("<td width='22%'>")
        bodyemail.Append("Nro Tarifa:")
        bodyemail.Append("</td>")
        bodyemail.Append("<td>")
        bodyemail.Append(oEntidad("NRTFSV"))
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        'bodyemail.Append("<tr>")
        'bodyemail.Append("<td width='22%'>")
        'bodyemail.Append("Servicio:")
        'bodyemail.Append("</td>")
        'bodyemail.Append("<td>")
        'bodyemail.Append(oEntidad("SERVICIO_D"))
        'bodyemail.Append("</td>")
        'bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td width='22%'>")
        bodyemail.Append("Cliente:")
        bodyemail.Append("</td>")
        bodyemail.Append("<td>")
        bodyemail.Append(oEntidad("TCMPCL"))
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td width='22%'>")
        bodyemail.Append("Aprobador Sugerido:")
        bodyemail.Append("</td>")
        bodyemail.Append("<td>")
        bodyemail.Append(oEntidad("APROBSUG"))
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")


        bodyemail.Append("<tr>")
        bodyemail.Append("<td width='22%'>")
        bodyemail.Append("% Aprobación:")
        bodyemail.Append("</td>")
        bodyemail.Append("<td>")
        bodyemail.Append(oEntidad("MRGPOR").ToString & " %")
        bodyemail.Append("</td>")


        bodyemail.Append("</table>")
        bodyemail.Append("<table style='font-size:10px;font-family:Arial'>")
        bodyemail.Append(HTMLSalto)
        bodyemail.Append("</table>")


        bodyemail.Append("<table style='font-size:10px;font-family:Arial'; ; width='80%'>")
        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='9'>")

        bodyemail.Append("<hr style='border:1px dotted; width=100%' />")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        If DT_SERV.Rows.Count > 0 Then 'servicios

            bodyemail.Append("<tr>")
            bodyemail.Append("<td width='10%'>")
            bodyemail.Append("Servicio")
            bodyemail.Append("</td>")

            bodyemail.Append("<td width='15%'>")
            bodyemail.Append("Origen")
            bodyemail.Append("</td>")

            bodyemail.Append("<td width='15%'>")
            bodyemail.Append("Destino")
            bodyemail.Append("</td>")


            bodyemail.Append("<td width='10%'>")
            bodyemail.Append("Tarifa Cobro")
            bodyemail.Append("</td>")
            bodyemail.Append("<td width='10%'>")
            bodyemail.Append("Tarifa Pago")
            bodyemail.Append("</td>")


            bodyemail.Append("<td width='10%'>")
            'bodyemail.Append("Tarifa Cobro(S/.)")
            bodyemail.Append("Cobro(S/.)")
            bodyemail.Append("</td>")
            bodyemail.Append("<td width='10%'>")
            'bodyemail.Append("Tarifa Pago(S/.)")
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
                bodyemail.Append(dr("SERVICIO"))
                bodyemail.Append("</td>")
                bodyemail.Append("<td width='15%'>")
                bodyemail.Append(("" & dr("ORIGEN")).ToString.Trim)
                bodyemail.Append("</td>")

                bodyemail.Append("<td width='15%'>")
                bodyemail.Append(dr("DESTINO"))
                bodyemail.Append("</td>")


                bodyemail.Append("<td width='10%'>")
                bodyemail.Append(dr("MONEDA_COBRO") & " " & dr("TARIFA_COBRO"))
                bodyemail.Append("</td>")



                bodyemail.Append("<td width='10%'>")
                bodyemail.Append(dr("MONEDA_PAGO") & " " & dr("TARIFA_PAGO"))
                bodyemail.Append("</td>")


                bodyemail.Append("<td width='10%'>")
                bodyemail.Append(Math.Round(dr("COBRO_SOL"), 2))
                bodyemail.Append("</td>")
                bodyemail.Append("<td width='10%'>")
                bodyemail.Append(Math.Round(dr("PAGO_SOL"), 2))
                bodyemail.Append("</td>")
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
        bodyemail.Append("<td colspan='9'>")
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

        Return obeDestinatario.PSTIPPROC = TipoProceso AndAlso obeDestinatario.PSTIP_MAIL_DEST = "CLIENTE"

    End Function

    Public Function BuscarDestinatarios() As beDestinatario

        Dim obeDestinatariosEnvio As New beDestinatario
        Dim oListBU As New List(Of String)
        Dim odaEnviarEmail As New EnvioEmailAprobacionMargen_DAL
        Dim oListDestinatarioBusqueda As New List(Of beDestinatario)
        Dim oListDestinatarioReplicacion As New List(Of beDestinatario)
        oListDestinatario = odaEnviarEmail.DESTINATARIO_ENVIO_EMAIL_X_TIPO_PROCESO(CCLNT_TODOS, TipoProceso)
        oListDestinatarioBusqueda = oListDestinatario.FindAll(AddressOf FindDestinatarioCliente)
        oListDestinatarioReplicacion = oListDestinatario.FindAll(AddressOf FindDestinatarioCopia)
        obeDestinatariosEnvio.PSEMAILTO = ListaEmailDistintos(oListDestinatarioBusqueda)
        obeDestinatariosEnvio.PSEMAILBC = ListaEmailDistintos(oListDestinatarioReplicacion)
        Return obeDestinatariosEnvio

    End Function

    Public Function Enviar_Email_Requerimiento_Servicio_Notificacion(ByVal oEntidad As Hashtable, ByVal DT_SERV As DataTable) As Int32
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
            oclsEmailManager.MailAccount = Me.MailAccount
            oclsEmailManager.Mailpassword = Me.Mailpassword
            oclsEmailManager.MailBody = bodyemail
            oclsEmailManager.MailNotification = obeDestinatariosEnvio.PSEMAILTO
            oclsEmailManager.mailnotificationBCC = obeDestinatariosEnvio.PSEMAILBC
            oclsEmailManager.MailSubject = String.Format("RANSA: SOLICITUD DE APROBACION DE MARGENES O/S")
            If (obeDestinatariosEnvio.PSEMAILTO <> "") Then
                oclsEmailManager.SendMailProvider()
                exito = 1
            Else
                MsgBox("Correo no enviado.No se encontró destinatarios.", MsgBoxStyle.Critical, "Aviso")
                exito = 0
            End If


        Catch ex As Exception
            Dim msgError As String = ""
            msgError = "OCURRIÒ UN ERROR EN EL ENVIO DE APROBACION O/S " & oEntidad("NORSRT")
            msgError = msgError & "<br/>" & ex.Message
            Try
                Dim oclsEmailManagerGMAIL As New clsEmailManagerGMAIL
                oclsEmailManagerGMAIL.MailAccount = Me.MailAccount_Gmail
                oclsEmailManagerGMAIL.Mailpassword = Me.MailPassword_Gmail
                oclsEmailManagerGMAIL.MailBody = msgError & "<br/>" & bodyemail
                oclsEmailManagerGMAIL.MailNotification = Me.Mailto_Error
                oclsEmailManagerGMAIL.MailSubject = "SOLICITUD APROBACION -ERROR ENVIO APROBACION O/S"
                oclsEmailManagerGMAIL.SendMailGmail()
            Catch exx As Exception
            End Try
        End Try
        Return exito

    End Function


End Class
