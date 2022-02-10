
Imports System.Text
Imports System.Runtime.CompilerServices
Imports RANSA.Controls.Email
Imports System.Configuration
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.DATOS.mantenimientos
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimiento


Public Class EnvioEmailAnulacionOperacion


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

    Private TipoProceso As String = "ST_ANULOPT"

    Private _CCLNT As Decimal = 0

    Private CCLNT_GENERAL As Decimal = 999999

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

    Public Function BuscarDestinatarios(ByVal CCLNT As Decimal) As beDestinatario

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

    Public Function Enviar_Email_Anulacion_operacion_gastos(ByVal Entidad As Solicitud_Transporte) As Int32
        Dim exito As Int32 = -1
        Dim bodyemail As String = ""
        Try
            Dim oListDestEnvio As String = ""
            Dim oListDestEnvioReplicacion As String = ""
            Dim FECHA_INCIAL As Int32 = 0
            Dim odtDatosEmbarqueFinal As New DataTable
            Dim oclsEmailManager As New clsEmailManager
            Dim obeDestinatariosEnvio As New beDestinatario
            Dim objLogica As New Solicitud_Transporte_BLL
            Dim dt As DataTable = objLogica.SP_SOLMIN_ST_LISTAR_OPERACION_ENVIO_ANULACION(Entidad.CCMPN, Entidad.NOPRCN)
            If dt.Rows.Count > 0 Then
                With Entidad
                    .NOPRCR = dt.Rows(0)("NOPRCN")
                    .NORSRT = dt.Rows(0)("NORSRT")
                    .RUTA = dt.Rows(0)("CLCLOR_S").ToString.Trim & "-" & dt.Rows(0)("CLCLDS_S").ToString.Trim
                    .CCLNT_S = dt.Rows(0)("CCLNT_S").ToString.Trim
                    .TCMTRT = dt.Rows(0)("TCMTRT").ToString.Trim
                    .UATAOP = dt.Rows(0)("UATAOP").ToString.Trim
                    .USLAOP = dt.Rows(0)("USLAOP")
                    .MOTAOP = dt.Rows(0)("MOTAOP").ToString.Trim
                    .NOPRCR = dt.Rows(0)("NOPRCR")
                    .OBSAOP = dt.Rows(0)("OBSAOP").ToString.Trim
                End With
            End If
            bodyemail = Datos_Cuerpo_Envio(Entidad)
            Dim obeDestinatario As New beDestinatario
            Dim CCLNT As Decimal
            If Entidad.CCLNT.Equals("") Then
                CCLNT = 0
            Else
                CCLNT = CDec(Entidad.CCLNT)
            End If
            obeDestinatario = BuscarDestinatarios(CCLNT) ', beSegEnvioReq.EMAILCC)
            obeDestinatariosEnvio.PSEMAILTO = obeDestinatario.PSEMAILTO
            obeDestinatariosEnvio.PSEMAILBC = obeDestinatario.PSEMAILBC
            'obeDestinatariosEnvio.PSEMAILCC = obeDestinatario.PSEMAILCC
            oclsEmailManager.MailAccount = Me.MailAccount
            oclsEmailManager.Mailpassword = Me.Mailpassword
            oclsEmailManager.MailBody = bodyemail
            oclsEmailManager.MailNotification = obeDestinatariosEnvio.PSEMAILTO
            oclsEmailManager.mailnotificationBCC = obeDestinatariosEnvio.PSEMAILBC
            'oclsEmailManager.mailnotificationCC = obeDestinatariosEnvio.PSEMAILCC
            oclsEmailManager.MailSubject = "RANSA: ANULACION DE OPERACIONES CON GASTOS Y/O AVC "
            If (obeDestinatariosEnvio.PSEMAILTO <> "") Then
                oclsEmailManager.SendMailProvider()
                exito = 1
            Else
                MsgBox("Correo no enviado.No se encontró destinatarios.", MsgBoxStyle.Critical, "Aviso")
                exito = 0
            End If


        Catch ex As Exception
            Dim msgError As String = ""
            msgError = "OCURRIÒ UN ERROR EN EL ENVIO DE ANULACIÓN DE OPERACIONES CON GASTOS Y/O AVC " & Entidad.NOPRCN
            msgError = msgError & "<br/>" & ex.Message
            Try
                Dim oclsEmailManagerGMAIL As New clsEmailManagerGMAIL
                oclsEmailManagerGMAIL.MailAccount = Me.MailAccount_Gmail
                oclsEmailManagerGMAIL.Mailpassword = Me.MailPassword_Gmail
                oclsEmailManagerGMAIL.MailBody = msgError & "<br/>" & bodyemail
                oclsEmailManagerGMAIL.MailNotification = Me.Mailto_Error
                oclsEmailManagerGMAIL.MailSubject = "ANULACION DE OPERACION CON GASTOS Y/O AVC - ERROR ENVIO RAPROBACION"
                oclsEmailManagerGMAIL.SendMailGmail()
            Catch exx As Exception
            End Try
        End Try
        Return exito

    End Function

    Private Function Datos_Cuerpo_Envio(ByVal Entidad As Solicitud_Transporte) As String
        Dim Dato As String = ""
        Dim Lista As New List(Of Dimensiones)

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
        bodyemail.Append("El " & Now.ToString & " Se ha anulado la siguiente operación con Gastos y/o AVC")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")


        With Entidad

            bodyemail.Append("<tr>")
            bodyemail.Append("<td width='22%'>")
            bodyemail.Append("Operación:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(.NOPRCN)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")


            bodyemail.Append("<tr>")
            bodyemail.Append("<td width='22%'>")

            bodyemail.Append("O/S:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(.NORSRT)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td width='22%'>")
            bodyemail.Append("Ruta:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(Entidad.RUTA)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")


            bodyemail.Append("<tr>")
            bodyemail.Append("<td width='22%'>")
            bodyemail.Append("Cliente:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(Entidad.CCLNT_S)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td width='22%'>")
            bodyemail.Append("Transportista:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(Entidad.TCMTRT)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td width='22%'>")
            bodyemail.Append("Autorizado por:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(Entidad.UATAOP.Trim)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td width='22%'>")
            bodyemail.Append("Solicitado por:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(Entidad.USLAOP.Trim)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td width='22%'>")
            bodyemail.Append("Motivo anulación:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(Entidad.MOTAOP.Trim)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")



            bodyemail.Append("<tr>")
            bodyemail.Append("<td width='22%'>")
            bodyemail.Append("Operación de reemplazo:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(Entidad.NOPRCR)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td width='22%'>")
            bodyemail.Append("Observación:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(Entidad.OBSAOP)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("</table>")

            'bodyemail.Append("<table style='font-size:10px;font-family:Arial'>")

            'bodyemail.Append("<tr>")
            'bodyemail.Append("<td colspan='5'>")

            'bodyemail.Append("<hr style='border:1px dotted; width=100%' />")
            'bodyemail.Append("</td>")
            'bodyemail.Append("</tr>")
        End With

        'bodyemail.Append("<tr>")
        'bodyemail.Append("<td colspan='5'>")
        'bodyemail.Append("<hr style='border:1px dotted; width=100%' />")
        'bodyemail.Append("</td>")
        'bodyemail.Append("</tr>")

        'bodyemail.Append(HTMLSalto)
        'bodyemail.Append(HTMLSalto)
        'bodyemail.Append(HTMLSalto)
        bodyemail.Append(HTMLSalto)
        'bodyemail.Append("</table>")

        bodyemail.Append("<table style='font-size:10px;font-family:Arial'>")
        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='5'>")
        bodyemail.Append("Anulado por : ")
        bodyemail.Append(CULUSA)
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("</table>")

        bodyemail.Append(HTMLFin)

        Return bodyemail.ToString
    End Function


End Class
